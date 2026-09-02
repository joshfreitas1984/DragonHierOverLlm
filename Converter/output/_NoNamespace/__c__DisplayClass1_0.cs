// ============================================================
// Type  : <>c__DisplayClass1_0
// Token : 0x2000452
// ============================================================

public class <>c__DisplayClass1_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4002002
    public Graphic target;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002648
    // RVA   : 0x210B70   Offset: 0x20F370   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x6002649
    // RVA   : 0x8D54B0   Offset: 0x8D3CB0   Length: 0x3B
    internal Color <DOColor>b__0()
    {
        ulong uVar2;
        byte[] local_18 = new byte[16];
        plVar1 = *(int64 **)(param_2 + 16);
        if (plVar1 != (int64 *)0) {
          puVar3 = (uint64 *)
                   (**(code **)(*plVar1 + 0x298))(local_18,plVar1,*(uint64 *)(*plVar1 + 0x2a0));
          uVar2 = puVar3[1];
          *this = *puVar3;
          this[1] = uVar2;
          return this;
        }
    }

    // Token : 0x600264A
    // RVA   : 0x8D54F0   Offset: 0x8D3CF0   Length: 0x34
    internal void <DOColor>b__1(Color x)
    {
        uint local_18;
        uint uStack_14;
        uint uStack_10;
        uint32 uStack_c;
        plVar1 = this.target;
        if (plVar1 != (int64 *)0) {
          local_18 = *x;
          uStack_14 = x[1];
          uStack_10 = x[2];
          uStack_c = x[3];
          (**(code **)(*plVar1 + 0x2a8))(plVar1,&local_18,*(uint64 *)(*plVar1 + 0x2b0));
          return;
        }
    }

}
