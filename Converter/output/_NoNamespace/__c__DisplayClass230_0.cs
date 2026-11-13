// ============================================================
// Type  : <>c__DisplayClass230_0
// Token : 0x20002AC
// ============================================================

public class <>c__DisplayClass230_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400155C
    public HeroData heroData;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60016B6
    // RVA   : 0x42F150   Offset: 0x42DF50   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x60016B7
    // RVA   : 0x67EC30   Offset: 0x67DA30   Length: 0x1D
    internal bool <HeroLeaveArea>b__0(int x)
    {
        long lVar1;
        lVar1 = this.heroData;
        if (lVar1 != null) {
          return CONCAT71((int7)((uint64)lVar1 >> 8),x == lVar1.heroID);
        }
    }

}
