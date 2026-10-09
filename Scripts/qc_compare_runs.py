#!/usr/bin/env python3
"""Compare several QC evaluator Results.yaml runs (e.g. one per prompt version) side by side.

Scores every run with the same excluded methodology as qc_excluded_methodology.py (seam-shaped
categories and EXCLUDED_SAMPLE_IDS left out), then splits the gold set into:
  - held-out: detection pairs that already existed in GoldSet.yaml at --heldout-rev, i.e. not
    written alongside the prompt change being tested - the fair regression check;
  - new: pairs added since that revision (often written together with the prompt change, so a win
    there is expected rather than evidence the change generalises).
Finally lists every pair where a run's Pass/Defect verdict differs from the FIRST run's.

Expected labels always come from the CURRENT gold set, not from each Results.yaml (which records the
labels in force when that run happened), so an older run is rescored correctly after a gold-set
label is corrected.

Run each prompt version at qualityControl.detectionTemperature 0 so results are deterministic and
differences are real rather than sampling noise.

Usage:
  python Scripts/qc_compare_runs.py [--gold Files/Goldset/GoldSet.yaml] [--heldout-rev <git rev>] \
      NAME=path/to/Results.yaml [NAME=path/to/Results.yaml ...]
"""
import argparse
import os
import subprocess
import sys

import yaml

sys.path.insert(0, os.path.dirname(os.path.abspath(__file__)))
from qc_excluded_methodology import is_excluded  # noqa: E402


def load_yaml(path):
    with open(path, encoding="utf-8-sig") as f:
        return yaml.safe_load(f)


def gold_pairs(gold):
    return {
        (item["sampleId"], candidate): info
        for item in gold.get("detectionItems", gold.get("items", []))
        for candidate, info in (item.get("labels") or {}).items()
    }


def gold_at_rev(rev, gold_path):
    shown = subprocess.run(["git", "show", f"{rev}:{gold_path}"], capture_output=True, check=True)
    return yaml.safe_load(shown.stdout.decode("utf-8-sig"))


def detection_rows(results_path, pairs):
    rows = {}
    for row in load_yaml(results_path)["results"]:
        if row.get("evaluationKind") != "detection":
            continue
        key = (row["sampleId"], row["resultId"].split(":")[2])
        info = pairs.get(key)
        if info is None or is_excluded(key[0], info.get("defectCategories") or []):
            continue
        rows[key] = {**row, "expectedLabel": info["label"]}
    return rows


def score(rows):
    expected = [r for r in rows if r["expectedLabel"] == "Defect"]
    flagged = [r for r in rows if r["actualLabel"] == "Defect"]
    tp = sum(r["actualLabel"] == "Defect" for r in expected)
    recall = f"{tp / len(expected):.3f} ({tp}/{len(expected)})" if expected else "n/a"
    precision = f"{tp / len(flagged):.3f} ({tp}/{len(flagged)})" if flagged else "n/a"
    return recall, precision, len(flagged) - tp


def main():
    parser = argparse.ArgumentParser(description=__doc__, formatter_class=argparse.RawDescriptionHelpFormatter)
    parser.add_argument("--gold", default="Files/Goldset/GoldSet.yaml")
    parser.add_argument("--heldout-rev", help="git rev whose gold set defines the held-out pairs")
    parser.add_argument("runs", nargs="+", metavar="NAME=Results.yaml")
    args = parser.parse_args()

    pairs = gold_pairs(load_yaml(args.gold))
    runs = {}
    for spec in args.runs:
        name, _, path = spec.partition("=")
        runs[name] = detection_rows(path, pairs)

    subsets = {"all": lambda key: True}
    if args.heldout_rev:
        heldout = set(gold_pairs(gold_at_rev(args.heldout_rev, args.gold)))
        subsets[f"held-out (in gold set at {args.heldout_rev})"] = lambda key: key in heldout
        subsets["new since then"] = lambda key: key not in heldout

    width = max(len(name) for name in runs)
    for subset, include in subsets.items():
        print(f"== {subset} ==")
        for name, rows in runs.items():
            recall, precision, fp = score([row for key, row in rows.items() if include(key)])
            print(f"  {name:<{width}}  recall {recall:<14}  precision {precision:<14}  FP {fp}")
        print()

    baseline_name, baseline = next(iter(runs.items()))
    for name, rows in list(runs.items())[1:]:
        print(f"== verdicts that differ: {baseline_name} -> {name} ==")
        for key in sorted(baseline):
            if key not in rows or baseline[key]["actualLabel"] == rows[key]["actualLabel"]:
                continue
            row = rows[key]
            if row["actualLabel"] == row["expectedLabel"]:
                outcome = "better"
            elif baseline[key]["actualLabel"] == row["expectedLabel"]:
                outcome = "worse"
            else:
                outcome = "both wrong"
            categories = ",".join(row.get("actualDefectCategories") or [])
            print(f"  {key[0]} [{key[1]}] expected {row['expectedLabel']}: "
                  f"{baseline[key]['actualLabel']} -> {row['actualLabel']} {categories}  ({outcome})")
        print()


if __name__ == "__main__":
    main()
