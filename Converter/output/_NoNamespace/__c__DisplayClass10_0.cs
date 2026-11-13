// ============================================================
// Type  : <>c__DisplayClass10_0
// Token : 0x200046E
// ============================================================

public class <>c__DisplayClass10_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40021A8
    public Outline target;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600278D
    // RVA   : 0x42F150   Offset: 0x42DF50   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x600278E
    // RVA   : 0x67DBB0   Offset: 0x67C9B0   Length: 0x21
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

    // Token : 0x600278F
    // RVA   : 0x67DBE0   Offset: 0x67C9E0   Length: 0x2C
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
