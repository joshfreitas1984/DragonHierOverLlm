// ============================================================
// Type  : ExploreTileObstacleData
// Token : 0x2000275
// ============================================================

public class ExploreTileObstacleData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40013B9
    public int obstacleType;

    // Token: 0x40013BA
    public int needNum;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001410
    // RVA   : 0x248060   Offset: 0x247460   Length: 0x34
    public void /*ctor*/(int _obstacleType, int _needNum)
    {
        ZhSegment.Initialize(this,0);
        this.obstacleType = _obstacleType;
        this.needNum = _needNum;
    }

}
