// ============================================================
// Type  : <>c__DisplayClass40_0
// Token : 0x200048C
// ============================================================

public class <>c__DisplayClass40_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40021D0
    public Color to;

    // Token: 0x40021D1
    public Text target;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60027EB
    // RVA   : 0x42F150   Offset: 0x42DF50   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x60027EC
    // RVA   : 0x67F840   Offset: 0x67E640   Length: 0xB
    internal Color <DOBlendableColor>b__0()
    {
        uint64 * FUN_18067f840(uint64 *this,int64 param_2)
        {
        uint64 uVar1;
        uVar1 = *(uint64 *)(param_2 + 24);
        *this = *(uint64 *)(param_2 + 16);
        this[1] = uVar1;
        return this;
    }

    // Token : 0x60027ED
    // RVA   : 0x67F850   Offset: 0x67E650   Length: 0xBF
    internal void <DOBlendableColor>b__1(Color x)
    {
        uint uVar2;
        uint uVar3;
        uint uVar4;
        ulong uVar5;
        ulong uVar6;
        uint local_48;
        uint uStack_44;
        uint uStack_40;
        uint32 uStack_3c;
        uint64 local_38;
        uint64 uStack_30;
        uint8 local_28 [32];
        local_48 = this.to;
        uStack_44 = *(uint32 *)(this + 20);
        uStack_40 = *(uint32 *)(this + 24);
        uStack_3c = *(uint32 *)(this + 28);
        local_38 = *x;
        uStack_30 = x[1];
        puVar7 = (uint64 *)FUN_180f25080(local_28,&local_38,&local_48,0);
        uVar2 = *(uint32 *)((int64)x + 4);
        uVar3 = *(uint32 *)(x + 1);
        uVar4 = *(uint32 *)((int64)x + 12);
        plVar1 = this.target;
        uVar5 = *puVar7;
        uVar6 = puVar7[1];
        this.to = *(uint32 *)x;
        *(uint32 *)(this + 20) = uVar2;
        *(uint32 *)(this + 24) = uVar3;
        *(uint32 *)(this + 28) = uVar4;
        if (plVar1 != (int64 *)0) {
          puVar8 = (uint32 *)
                   (**(code **)(*plVar1 + 0x298))(local_28,plVar1,*(uint64 *)(*plVar1 + 0x2a0));
          local_48 = *puVar8;
          uStack_44 = puVar8[1];
          uStack_40 = puVar8[2];
          uStack_3c = puVar8[3];
          local_38 = uVar5;
          uStack_30 = uVar6;
          puVar7 = (uint64 *)FUN_180f24d40(local_28,&local_48,&local_38,0);
          local_38 = *puVar7;
          uStack_30 = puVar7[1];
          (**(code **)(*plVar1 + 0x2a8))(plVar1,&local_38,*(uint64 *)(*plVar1 + 0x2b0));
          return;
        }
    }

}
