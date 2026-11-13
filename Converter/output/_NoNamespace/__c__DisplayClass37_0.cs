// ============================================================
// Type  : <>c__DisplayClass37_0
// Token : 0x2000489
// ============================================================

public class <>c__DisplayClass37_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40021CB
    public Text target;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60027E2
    // RVA   : 0x42F150   Offset: 0x42DF50   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x60027E3
    // RVA   : 0x67F7E0   Offset: 0x67E5E0   Length: 0x27
    internal string <DOText>b__0()
    {
        plVar1 = this.target;
        if (plVar1 != (int64 *)0) {
                          // WARNING: Could not recover jumptable at 0x00018067f7fb. Too many branches
                          // WARNING: Treating indirect jump as call
          (**(code **)(*plVar1 + 0x5d8))(plVar1,*(uint64 *)(*plVar1 + 0x5e0));
          return;
        }
    }

    // Token : 0x60027E4
    // RVA   : 0x67F810   Offset: 0x67E610   Length: 0x27
    internal void <DOText>b__1(string x)
    {
        plVar1 = this.target;
        if (plVar1 != (int64 *)0) {
                          // WARNING: Could not recover jumptable at 0x00018067f82b. Too many branches
                          // WARNING: Treating indirect jump as call
          (**(code **)(*plVar1 + 0x5e8))(plVar1,x,*(uint64 *)(*plVar1 + 0x5f0));
          return;
        }
    }

}
