// ============================================================
// Type  : <>c__DisplayClass10_0
// Token : 0x2000461
// ============================================================

public class <>c__DisplayClass10_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4002115
    public Outline target;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60026E3
    // RVA   : 0x210B70   Offset: 0x20FF70   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x60026E4
    // RVA   : 0x937980   Offset: 0x936D80   Length: 0x21
    internal Color <DOColor>b__0()
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

    // Token : 0x60026E5
    // RVA   : 0x9379B0   Offset: 0x936DB0   Length: 0x2C
    internal void <DOColor>b__1(Color x)
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
