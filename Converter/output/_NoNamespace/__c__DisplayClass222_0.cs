// ============================================================
// Type  : <>c__DisplayClass222_0
// Token : 0x20002A4
// ============================================================

public class <>c__DisplayClass222_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001517
    public HeroData heroData;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001644
    // RVA   : 0x210B70   Offset: 0x20FF70   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x6001645
    // RVA   : 0x937BA0   Offset: 0x936FA0   Length: 0x1D
    internal bool <HeroLeaveArea>b__0(int x)
    {
        long lVar1;
        lVar1 = this.heroData;
        if (lVar1 != null) {
          return CONCAT71((int7)((uint64)lVar1 >> 8),x == lVar1.heroID);
        }
    }

}
