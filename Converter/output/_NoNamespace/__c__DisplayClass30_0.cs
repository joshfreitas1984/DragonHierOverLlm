// ============================================================
// Type  : <>c__DisplayClass30_0
// Token : 0x2000482
// ============================================================

public class <>c__DisplayClass30_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40021C1
    public ScrollRect target;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60027CD
    // RVA   : 0x42F150   Offset: 0x42DF50   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x60027CE
    // RVA   : 0x67F520   Offset: 0x67E320   Length: 0x4C
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

    // Token : 0x60027CF
    // RVA   : 0x67F570   Offset: 0x67E370   Length: 0x46
    internal void <DONormalizedPos>b__1(Vector2 x)
    {
        uint local_res8;
        uint32 uStackX_c;
        if (this.target != null) {
          local_res8 = (uint32)x;
          FUN_181273960(this.target,local_res8,0);
          if (this.target != null) {
            uStackX_c = (uint32)((uint64)x >> 32);
            FUN_1812744b0(this.target,uStackX_c,0);
            return;
          }
        }
    }

}
