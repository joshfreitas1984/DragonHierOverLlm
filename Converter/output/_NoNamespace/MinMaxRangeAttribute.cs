// ============================================================
// Type  : MinMaxRangeAttribute
// Token : 0x2000083
// ============================================================

public class MinMaxRangeAttribute
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400030A
    public float minLimit;

    // Token: 0x400030B
    public float maxLimit;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000348
    // RVA   : 0xE92CA0   Offset: 0xE91AA0   Length: 0x3A
    public void /*ctor*/(float minLimit, float maxLimit)
    {
        SmokeTrailPoint.ctor(this,0);
        this.minLimit = minLimit;
        this.maxLimit = maxLimit;
    }

}
