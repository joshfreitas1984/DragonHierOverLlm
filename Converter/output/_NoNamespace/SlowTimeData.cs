// ============================================================
// Type  : SlowTimeData
// Token : 0x200039D
// ============================================================

public class SlowTimeData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001D79
    public float slowTime;

    // Token: 0x4001D7A
    public float slowTimeScale;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60022F5
    // RVA   : 0x98AEE0   Offset: 0x98A2E0   Length: 0x3A
    public void /*ctor*/(float _slowTime, float _slowTimeScale)
    {
        ZhSegment.Initialize(this,0);
        this.slowTime = _slowTime;
        this.slowTimeScale = _slowTimeScale;
    }

}
