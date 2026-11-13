// ============================================================
// Type  : ControlPoint
// Token : 0x2000436
// ============================================================

public class ControlPoint
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4002110
    public Vector3 p;

    // Token: 0x4002111
    public Vector3 forward;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600265B
    // RVA   : 0x42F150   Offset: 0x42DF50   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

}
