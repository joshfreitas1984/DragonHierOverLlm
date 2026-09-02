// ============================================================
// Type  : <>c__DisplayClass221_0
// Token : 0x200029E
// ============================================================

public class <>c__DisplayClass221_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001465
    public HeroData heroData;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001600
    // RVA   : 0x210B70   Offset: 0x20F370   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x6001601
    // RVA   : 0x8D56B0   Offset: 0x8D3EB0   Length: 0x1D
    internal bool <HeroLeaveArea>b__0(int x)
    {
        long lVar1;
        lVar1 = this.heroData;
        if (lVar1 != null) {
          return CONCAT71((int7)((uint64)lVar1 >> 8),x == lVar1.heroID);
        }
    }

}
