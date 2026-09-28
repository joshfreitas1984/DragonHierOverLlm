// ============================================================
// Type  : <>c__DisplayClass11_0
// Token : 0x2000462
// ============================================================

public class <>c__DisplayClass11_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4002115
    public Outline target;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60026E6
    // RVA   : 0x210B70   Offset: 0x20FF70   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x60026E7
    // RVA   : 0x937140   Offset: 0x936540   Length: 0x21
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

    // Token : 0x60026E8
    // RVA   : 0x937170   Offset: 0x936570   Length: 0x2C
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
