// ============================================================
// Type  : MinMaxRangeAttribute
// Token : 0x2000084
// ============================================================

public class MinMaxRangeAttribute
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400032A
    public float minLimit;

    // Token: 0x400032B
    public float maxLimit;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000361
    // RVA   : 0xE63740   Offset: 0xE62B40   Length: 0x3A
    public void /*ctor*/(float minLimit, float maxLimit)
    {
        SmokeTrailPoint.ctor(this,0);
        this.minLimit = minLimit;
        this.maxLimit = maxLimit;
    }

}
