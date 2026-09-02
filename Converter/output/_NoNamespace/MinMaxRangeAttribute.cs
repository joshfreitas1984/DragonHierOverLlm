// ============================================================
// Type  : MinMaxRangeAttribute
// Token : 0x2000083
// ============================================================

public class MinMaxRangeAttribute
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400030E
    public float minLimit;

    // Token: 0x400030F
    public float maxLimit;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000349
    // RVA   : 0xAE9280   Offset: 0xAE7A80   Length: 0x3A
    public void /*ctor*/(float minLimit, float maxLimit)
    {
        SmokeTrailPoint.ctor(this,0);
        this.minLimit = minLimit;
        this.maxLimit = maxLimit;
    }

}
