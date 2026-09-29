// ============================================================
// Type  : PlotChoiceRequirement
// Token : 0x2000320
// ============================================================

public class PlotChoiceRequirement
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40019C4
    public ChoiceRequirementType requireType;

    // Token: 0x40019C5
    public float requireNum;

    // Token: 0x40019C6
    public bool autoChangeReuqireByDifficulty;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60019C5
    // RVA   : 0x46E160   Offset: 0x46D560   Length: 0x36
    public void /*ctor*/(ChoiceRequirementType _requireType, float _requireNum)
    {
        ZhSegment.Initialize(this,0);
        this.requireNum = _requireNum;
        this.requireType = _requireType;
    }

}
