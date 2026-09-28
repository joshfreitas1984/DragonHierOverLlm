// ============================================================
// Type  : PointConnection
// Token : 0x2000389
// ============================================================

public class PointConnection
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001CEF
    public int pointID;

    // Token: 0x4001CF0
    public int nextPoint;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002285
    // RVA   : 0x248060   Offset: 0x247460   Length: 0x34
    public void /*ctor*/(int _pointID, int _nextPoint)
    {
        ZhSegment.Initialize(this,0);
        this.pointID = _pointID;
        this.nextPoint = _nextPoint;
    }

}
