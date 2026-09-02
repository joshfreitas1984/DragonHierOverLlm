// ============================================================
// Type  : <>c__DisplayClass30_0
// Token : 0x200046E
// ============================================================

public class <>c__DisplayClass30_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4002023
    public ScrollRect target;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60026A0
    // RVA   : 0x210B70   Offset: 0x20F370   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x60026A1
    // RVA   : 0x8D6E20   Offset: 0x8D5620   Length: 0x4C
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

    // Token : 0x60026A2
    // RVA   : 0x8D6E70   Offset: 0x8D5670   Length: 0x46
    internal void <DONormalizedPos>b__1(Vector2 x)
    {
        uint local_res8;
        uint32 uStackX_c;
        if (this.target != null) {
          local_res8 = (uint32)x;
          FUN_181369950(this.target,local_res8,0);
          if (this.target != null) {
            uStackX_c = (uint32)((uint64)x >> 32);
            FUN_18136a4a0(this.target,uStackX_c,0);
            return;
          }
        }
    }

}
