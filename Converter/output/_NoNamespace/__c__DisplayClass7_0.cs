// ============================================================
// Type  : <>c__DisplayClass7_0
// Token : 0x200045E
// ============================================================

public class <>c__DisplayClass7_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4002112
    public LayoutElement target;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60026DA
    // RVA   : 0x210B70   Offset: 0x20FF70   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x60026DB
    // RVA   : 0x93A4D0   Offset: 0x9398D0   Length: 0x5E
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

    // Token : 0x60026DC
    // RVA   : 0x93A530   Offset: 0x939930   Length: 0x57
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
                          // WARNING: Could not recover jumptable at 0x00018093a57b. Too many branches
                          // WARNING: Treating indirect jump as call
            (**(code **)(*plVar1 + 0x3d8))(plVar1,uStackX_c,*(uint64 *)(*plVar1 + 0x3e0));
            return;
          }
        }
    }

}
