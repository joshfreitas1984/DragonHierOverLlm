// ============================================================
// Type  : <>c__DisplayClass33_0
// Token : 0x2000471
// ============================================================

public class <>c__DisplayClass33_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4002026
    public Slider target;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60026A9
    // RVA   : 0x210B70   Offset: 0x20F370   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x60026AA
    // RVA   : 0x8D6FF0   Offset: 0x8D57F0   Length: 0x27
    internal float <DOValue>b__0()
    {
        plVar1 = this.target;
        if (plVar1 != (int64 *)0) {
                          // WARNING: Could not recover jumptable at 0x0001808d700b. Too many branches
                          // WARNING: Treating indirect jump as call
          (**(code **)(*plVar1 + 0x418))(plVar1,*(uint64 *)(*plVar1 + 0x420));
          return;
        }
    }

    // Token : 0x60026AB
    // RVA   : 0x8D7020   Offset: 0x8D5820   Length: 0x27
    internal void <DOValue>b__1(float x)
    {
        plVar1 = this.target;
        if (plVar1 != (int64 *)0) {
                          // WARNING: Could not recover jumptable at 0x0001808d703b. Too many branches
                          // WARNING: Treating indirect jump as call
          (**(code **)(*plVar1 + 0x428))(plVar1,x,*(uint64 *)(*plVar1 + 0x430));
          return;
        }
    }

}
