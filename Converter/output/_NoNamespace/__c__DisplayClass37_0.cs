// ============================================================
// Type  : <>c__DisplayClass37_0
// Token : 0x2000475
// ============================================================

public class <>c__DisplayClass37_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400202D
    public Text target;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60026B5
    // RVA   : 0x210B70   Offset: 0x20F370   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x60026B6
    // RVA   : 0x8D70E0   Offset: 0x8D58E0   Length: 0x27
    internal string <DOText>b__0()
    {
        plVar1 = this.target;
        if (plVar1 != (int64 *)0) {
                          // WARNING: Could not recover jumptable at 0x0001808d70fb. Too many branches
                          // WARNING: Treating indirect jump as call
          (**(code **)(*plVar1 + 0x5d8))(plVar1,*(uint64 *)(*plVar1 + 0x5e0));
          return;
        }
    }

    // Token : 0x60026B7
    // RVA   : 0x8D7110   Offset: 0x8D5910   Length: 0x27
    internal void <DOText>b__1(string x)
    {
        plVar1 = this.target;
        if (plVar1 != (int64 *)0) {
                          // WARNING: Could not recover jumptable at 0x0001808d712b. Too many branches
                          // WARNING: Treating indirect jump as call
          (**(code **)(*plVar1 + 0x5e8))(plVar1,x,*(uint64 *)(*plVar1 + 0x5f0));
          return;
        }
    }

}
