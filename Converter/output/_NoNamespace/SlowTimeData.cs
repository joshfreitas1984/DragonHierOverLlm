// ============================================================
// Type  : SlowTimeData
// Token : 0x20003AA
// ============================================================

public class SlowTimeData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001E0C
    public float slowTime;

    // Token: 0x4001E0D
    public float slowTimeScale;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600239F
    // RVA   : 0x6B2CC0   Offset: 0x6B1AC0   Length: 0x3A
    public void /*ctor*/(float _slowTime, float _slowTimeScale)
    {
        ZhSegment.Initialize(this,0);
        this.slowTime = _slowTime;
        this.slowTimeScale = _slowTimeScale;
    }

}
