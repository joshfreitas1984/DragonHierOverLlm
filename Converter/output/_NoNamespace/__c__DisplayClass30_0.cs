// ============================================================
// Type  : <>c__DisplayClass30_0
// Token : 0x2000475
// ============================================================

public class <>c__DisplayClass30_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400212E
    public ScrollRect target;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002723
    // RVA   : 0x210B70   Offset: 0x20FF70   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x6002724
    // RVA   : 0x9399A0   Offset: 0x938DA0   Length: 0x4C
    internal Vector2 <DONormalizedPos>b__0()
    {
        uint uVar1;
        uint uVar2;
        if (this.target != null) {
          uVar1 = ScrollRect.get_horizontalNormalizedPosition(this.target,0);
          if (this.target != null) {
            uVar2 = ScrollRect.get_verticalNormalizedPosition(this.target,0);
            return CONCAT44(uVar2,uVar1);
          }
        }
    }

    // Token : 0x6002725
    // RVA   : 0x9399F0   Offset: 0x938DF0   Length: 0x46
    internal void <DONormalizedPos>b__1(Vector2 x)
    {
        uint local_res8;
        uint32 uStackX_c;
        if (this.target != null) {
          local_res8 = (uint32)x;
          FUN_1813bb510(this.target,local_res8,0);
          if (this.target != null) {
            uStackX_c = (uint32)((uint64)x >> 32);
            FUN_1813bc060(this.target,uStackX_c,0);
            return;
          }
        }
    }

}
