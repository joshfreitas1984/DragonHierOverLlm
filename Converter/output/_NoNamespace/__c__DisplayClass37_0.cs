// ============================================================
// Type  : <>c__DisplayClass37_0
// Token : 0x200047C
// ============================================================

public class <>c__DisplayClass37_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4002137
    public Text target;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002738
    // RVA   : 0x210B70   Offset: 0x20FF70   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x6002739
    // RVA   : 0x9395D0   Offset: 0x9389D0   Length: 0x27
    internal string <DOText>b__0()
    {
        plVar1 = this.target;
        if (plVar1 != (int64 *)0) {
                          // WARNING: Could not recover jumptable at 0x0001809395eb. Too many branches
                          // WARNING: Treating indirect jump as call
          (**(code **)(*plVar1 + 0x5d8))(plVar1,*(uint64 *)(*plVar1 + 0x5e0));
          return;
        }
    }

    // Token : 0x600273A
    // RVA   : 0x939600   Offset: 0x938A00   Length: 0x27
    internal void <DOText>b__1(string x)
    {
        plVar1 = this.target;
        if (plVar1 != (int64 *)0) {
                          // WARNING: Could not recover jumptable at 0x00018093961b. Too many branches
                          // WARNING: Treating indirect jump as call
          (**(code **)(*plVar1 + 0x5e8))(plVar1,x,*(uint64 *)(*plVar1 + 0x5f0));
          return;
        }
    }

}
