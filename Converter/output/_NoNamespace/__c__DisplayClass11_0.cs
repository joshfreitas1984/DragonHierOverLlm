// ============================================================
// Type  : <>c__DisplayClass11_0
// Token : 0x200045B
// ============================================================

public class <>c__DisplayClass11_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400200B
    public Outline target;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002663
    // RVA   : 0x210B70   Offset: 0x20F370   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x6002664
    // RVA   : 0x8D4B90   Offset: 0x8D3390   Length: 0x21
    internal Color <DOFade>b__0()
    {
        long lVar1;
        ulong uVar2;
        lVar1 = *(int64 *)(param_2 + 16);
        if (lVar1 != null) {
          uVar2 = *(uint64 *)(lVar1 + 40);
          *this = *(uint64 *)(lVar1 + 32);
          this[1] = uVar2;
          return this;
        }
    }

    // Token : 0x6002665
    // RVA   : 0x8D4BC0   Offset: 0x8D33C0   Length: 0x2C
    internal void <DOFade>b__1(Color x)
    {
        uint local_18;
        uint uStack_14;
        uint uStack_10;
        uint32 uStack_c;
        if (this.target != null) {
          local_18 = *x;
          uStack_14 = x[1];
          uStack_10 = x[2];
          uStack_c = x[3];
          Shadow.set_effectColor(this.target,&local_18,0);
          return;
        }
    }

}
