// ============================================================
// Type  : <>c__DisplayClass35_0
// Token : 0x2000487
// ============================================================

public class <>c__DisplayClass35_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40021C6
    public int v;

    // Token: 0x40021C7
    public Text target;

    // Token: 0x40021C8
    public bool addThousandsSeparator;

    // Token: 0x40021C9
    public CultureInfo cInfo;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60027DC
    // RVA   : 0x42F150   Offset: 0x42DF50   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x60027DD
    // RVA   : 0x210C90   Offset: 0x20FA90   Length: 0x2A6
    internal int <DOCounter>b__0()
    {
        return this.v;
    }

    // Token : 0x60027DE
    // RVA   : 0x67F750   Offset: 0x67E550   Length: 0x82
    internal void <DOCounter>b__1(int x)
    {
        ulong uVar3;
        this.v = x;
        plVar2 = this.target;
        if (!this.addThousandsSeparator) {
          uVar3 = Int32.ToString(puVar1,0);
        }
        else {
          uVar3 = Int32.ToString(puVar1,"N0",this.cInfo,0);
        }
        if (plVar2 != (int64 *)0) {
                          // WARNING: Could not recover jumptable at 0x00018067f7c6. Too many branches
                          // WARNING: Treating indirect jump as call
          (**(code **)(*plVar2 + 0x5e8))(plVar2,uVar3,*(uint64 *)(*plVar2 + 0x5f0));
          return;
        }
    }

}
