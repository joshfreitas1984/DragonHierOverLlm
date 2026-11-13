// ============================================================
// Type  : ExploreTileObstacleData
// Token : 0x200027C
// ============================================================

public class ExploreTileObstacleData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40013F7
    public int obstacleType;

    // Token: 0x40013F8
    public int needNum;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001478
    // RVA   : 0x520230   Offset: 0x51F030   Length: 0x34
    public void /*ctor*/(int _obstacleType, int _needNum)
    {
        ZhSegment.Initialize(this,0);
        this.obstacleType = _obstacleType;
        this.needNum = _needNum;
    }

}
