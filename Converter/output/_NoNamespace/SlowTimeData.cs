// ============================================================
// Type  : SlowTimeData
// Token : 0x2000396
// ============================================================

public class SlowTimeData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001C74
    public float slowTime;

    // Token: 0x4001C75
    public float slowTimeScale;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002273
    // RVA   : 0x9781B0   Offset: 0x9769B0   Length: 0x3A
    public void /*ctor*/(float _slowTime, float _slowTimeScale)
    {
        ZhSegment.Initialize(this,0);
        this.slowTime = _slowTime;
        this.slowTimeScale = _slowTimeScale;
    }

}
