// ============================================================
// Type  : PointConnection
// Token : 0x2000382
// ============================================================

public class PointConnection
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001BEA
    public int pointID;

    // Token: 0x4001BEB
    public int nextPoint;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002203
    // RVA   : 0x248060   Offset: 0x246860   Length: 0x34
    public void /*ctor*/(int _pointID, int _nextPoint)
    {
        ZhSegment.Initialize(this,0);
        this.pointID = _pointID;
        this.nextPoint = _nextPoint;
    }

}
