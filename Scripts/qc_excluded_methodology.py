#!/usr/bin/env python3
"""Excluded-methodology recall/precision for a QC evaluator Results.yaml.

Reconstructs the ad hoc analysis used in every round of
docs/plans/qc-evaluator-comparison.md since the Fourth round: excludes gold-set
detection rows whose defectCategories include a seam-shaped label
(omitted-separator / literal-newline / misplaced-separator - all deprioritized,
see plan doc "QC separator/newline defects deprioritized"), plus the one gold
item explicitly marked EXCLUDE FROM QC EVALUATOR SCORING
(sampleId 50ff7ccfb54c694e). Comparison.yaml's own raw aggregate is NOT this
number - it includes those excluded rows.

Usage: python Scripts/qc_excluded_methodology.py <Results.yaml> [GoldSet.yaml]
"""
import sys
import yaml
from collections import defaultdict

SEAM_CATEGORIES = {"omitted-separator", "literal-newline", "misplaced-separator"}
EXCLUDED_SAMPLE_IDS = {"50ff7ccfb54c694e"}


def load_gold_defect_categories(gold_set_path):
    with open(gold_set_path, encoding="utf-8") as f:
        gold = yaml.safe_load(f)
    # (sampleId, candidateName) -> defectCategories list
    lookup = {}
    for item in gold.get("detectionItems", gold.get("items", [])):
        sample_id = item["sampleId"]
        for candidate_name, label_info in item.get("labels", {}).items():
            lookup[(sample_id, candidate_name)] = label_info.get("defectCategories", []) or []
    return lookup


def is_excluded(sample_id, defect_categories):
    if sample_id in EXCLUDED_SAMPLE_IDS:
        return True
    return any(cat in SEAM_CATEGORIES for cat in defect_categories)


def main():
    if len(sys.argv) < 2:
        print(__doc__)
        sys.exit(1)
    results_path = sys.argv[1]
    gold_set_path = sys.argv[2] if len(sys.argv) > 2 else "Files/Goldset/GoldSet.yaml"

    gold_lookup = load_gold_defect_categories(gold_set_path)

    with open(results_path, encoding="utf-8") as f:
        results_doc = yaml.safe_load(f)

    tp = fp = fn = tn = 0
    per_category = defaultdict(lambda: {"tp": 0, "fn": 0})
    excluded_count = 0
    skipped_no_gold_match = 0

    for row in results_doc["results"]:
        if row.get("evaluationKind") != "detection":
            continue
        resultId_parts = row["resultId"].split(":")
        # detection:{sampleId}:{candidateName}:{evaluatorModel}
        candidate_name = resultId_parts[2] if len(resultId_parts) > 2 else None
        sample_id = row["sampleId"]

        defect_categories = gold_lookup.get((sample_id, candidate_name))
        if defect_categories is None:
            skipped_no_gold_match += 1
            continue

        if is_excluded(sample_id, defect_categories):
            excluded_count += 1
            continue

        expected_defect = row["expectedLabel"] == "Defect"
        actual_defect = row["actualLabel"] == "Defect"

        if expected_defect and actual_defect:
            tp += 1
        elif expected_defect and not actual_defect:
            fn += 1
        elif not expected_defect and actual_defect:
            fp += 1
        else:
            tn += 1

        if expected_defect:
            for cat in defect_categories:
                if cat in SEAM_CATEGORIES:
                    continue
                if actual_defect:
                    per_category[cat]["tp"] += 1
                else:
                    per_category[cat]["fn"] += 1

    recall = tp / (tp + fn) if (tp + fn) else float("nan")
    precision = tp / (tp + fp) if (tp + fp) else float("nan")

    print(f"Model: {results_doc.get('modelName', '?')}")
    print(f"Excluded-methodology detection: recall {recall:.3f} ({tp}/{tp + fn}), "
          f"precision {precision:.3f} ({tp}/{tp + fp})")
    print(f"TP={tp} FP={fp} FN={fn} TN={tn}  excluded={excluded_count}  "
          f"skipped_no_gold_match={skipped_no_gold_match}")
    print()
    print("Per-category recall (excluding seam-mapped rows):")
    for cat in sorted(per_category):
        c = per_category[cat]
        total = c["tp"] + c["fn"]
        print(f"  {cat}: {c['tp']}/{total} ({c['tp'] / total:.3f})" if total else f"  {cat}: n/a")


if __name__ == "__main__":
    main()
