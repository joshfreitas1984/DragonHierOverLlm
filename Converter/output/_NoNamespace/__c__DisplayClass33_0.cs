// ============================================================
// Type  : <>c__DisplayClass33_0
// Token : 0x2000478
// ============================================================

public class <>c__DisplayClass33_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4002130
    public Slider target;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600272C
    // RVA   : 0x210B70   Offset: 0x20FF70   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x600272D
    // RVA   : 0x9394E0   Offset: 0x9388E0   Length: 0x27
    internal float <DOValue>b__0()
    {
        plVar1 = this.target;
        if (plVar1 != (int64 *)0) {
                          // WARNING: Could not recover jumptable at 0x0001809394fb. Too many branches
                          // WARNING: Treating indirect jump as call
          (**(code **)(*plVar1 + 0x418))(plVar1,*(uint64 *)(*plVar1 + 0x420));
          return;
        }
    }

    // Token : 0x600272E
    // RVA   : 0x939510   Offset: 0x938910   Length: 0x27
    internal void <DOValue>b__1(float x)
    {
        plVar1 = this.target;
        if (plVar1 != (int64 *)0) {
                          // WARNING: Could not recover jumptable at 0x00018093952b. Too many branches
                          // WARNING: Treating indirect jump as call
          (**(code **)(*plVar1 + 0x428))(plVar1,x,*(uint64 *)(*plVar1 + 0x430));
          return;
        }
    }

}
