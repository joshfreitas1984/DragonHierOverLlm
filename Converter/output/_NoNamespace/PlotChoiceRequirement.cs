// ============================================================
// Type  : PlotChoiceRequirement
// Token : 0x2000319
// ============================================================

public class PlotChoiceRequirement
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40018D1
    public ChoiceRequirementType requireType;

    // Token: 0x40018D2
    public float requireNum;

    // Token: 0x40018D3
    public bool autoChangeReuqireByDifficulty;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001966
    // RVA   : 0x47A090   Offset: 0x478890   Length: 0x36
    public void /*ctor*/(ChoiceRequirementType _requireType, float _requireNum)
    {
        ZhSegment.Initialize(this,0);
        this.requireNum = _requireNum;
        this.requireType = _requireType;
    }

}
