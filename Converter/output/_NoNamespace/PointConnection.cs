// ============================================================
// Type  : PointConnection
// Token : 0x2000396
// ============================================================

public class PointConnection
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001D82
    public int pointID;

    // Token: 0x4001D83
    public int nextPoint;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600232F
    // RVA   : 0x520230   Offset: 0x51F030   Length: 0x34
    public void /*ctor*/(int _pointID, int _nextPoint)
    {
        ZhSegment.Initialize(this,0);
        this.pointID = _pointID;
        this.nextPoint = _nextPoint;
    }

}
