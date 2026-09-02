// ============================================================
// Type  : <>c__DisplayClass7_0
// Token : 0x2000457
// ============================================================

public class <>c__DisplayClass7_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4002007
    public LayoutElement target;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002657
    // RVA   : 0x210B70   Offset: 0x20F370   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x6002658
    // RVA   : 0x8D7950   Offset: 0x8D6150   Length: 0x5E
    internal Vector2 <DOFlexibleSize>b__0()
    {
        uint uVar2;
        uint uVar3;
        plVar1 = this.target;
        if (plVar1 != (int64 *)0) {
          uVar2 = (**(code **)(*plVar1 + 0x3a8))(plVar1,*(uint64 *)(*plVar1 + 0x3b0));
          plVar1 = this.target;
          if (plVar1 != (int64 *)0) {
            uVar3 = (**(code **)(*plVar1 + 0x3c8))(plVar1,*(uint64 *)(*plVar1 + 0x3d0));
            return CONCAT44(uVar3,uVar2);
          }
        }
    }

    // Token : 0x6002659
    // RVA   : 0x8D79B0   Offset: 0x8D61B0   Length: 0x57
    internal void <DOFlexibleSize>b__1(Vector2 x)
    {
        uint local_res8;
        uint32 uStackX_c;
        plVar1 = this.target;
        if (plVar1 != (int64 *)0) {
          local_res8 = (uint32)x;
          (**(code **)(*plVar1 + 0x3b8))(plVar1,local_res8,*(uint64 *)(*plVar1 + 0x3c0));
          plVar1 = this.target;
          if (plVar1 != (int64 *)0) {
            uStackX_c = (uint32)((uint64)x >> 32);
                          // WARNING: Could not recover jumptable at 0x0001808d79fb. Too many branches
                          // WARNING: Treating indirect jump as call
            (**(code **)(*plVar1 + 0x3d8))(plVar1,uStackX_c,*(uint64 *)(*plVar1 + 0x3e0));
            return;
          }
        }
    }

}
