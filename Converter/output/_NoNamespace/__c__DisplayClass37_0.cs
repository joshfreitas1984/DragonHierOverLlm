// ============================================================
// Type  : <>c__DisplayClass37_0
// Token : 0x200047C
// ============================================================

public class <>c__DisplayClass37_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4002138
    public Text target;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002738
    // RVA   : 0x210B70   Offset: 0x20FF70   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x6002739
    // RVA   : 0x939C60   Offset: 0x939060   Length: 0x27
    internal string <DOText>b__0()
    {
        plVar1 = this.target;
        if (plVar1 != (int64 *)0) {
                          // WARNING: Could not recover jumptable at 0x000180939c7b. Too many branches
                          // WARNING: Treating indirect jump as call
          (**(code **)(*plVar1 + 0x5d8))(plVar1,*(uint64 *)(*plVar1 + 0x5e0));
          return;
        }
    }

    // Token : 0x600273A
    // RVA   : 0x939C90   Offset: 0x939090   Length: 0x27
    internal void <DOText>b__1(string x)
    {
        plVar1 = this.target;
        if (plVar1 != (int64 *)0) {
                          // WARNING: Could not recover jumptable at 0x000180939cab. Too many branches
                          // WARNING: Treating indirect jump as call
          (**(code **)(*plVar1 + 0x5e8))(plVar1,x,*(uint64 *)(*plVar1 + 0x5f0));
          return;
        }
    }

}
