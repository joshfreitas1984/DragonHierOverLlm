// ============================================================
// Type  : ExploreTileObstacleData
// Token : 0x200026F
// ============================================================

public class ExploreTileObstacleData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001316
    public int obstacleType;

    // Token: 0x4001317
    public int needNum;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60013CF
    // RVA   : 0x248060   Offset: 0x246860   Length: 0x34
    public void /*ctor*/(int _obstacleType, int _needNum)
    {
        ZhSegment.Initialize(this,0);
        this.obstacleType = _obstacleType;
        this.needNum = _needNum;
    }

}
