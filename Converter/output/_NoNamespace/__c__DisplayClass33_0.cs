// ============================================================
// Type  : <>c__DisplayClass33_0
// Token : 0x2000485
// ============================================================

public class <>c__DisplayClass33_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40021C4
    public Slider target;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60027D6
    // RVA   : 0x42F150   Offset: 0x42DF50   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x60027D7
    // RVA   : 0x67F6F0   Offset: 0x67E4F0   Length: 0x27
    internal float <DOValue>b__0()
    {
        plVar1 = this.target;
        if (plVar1 != (int64 *)0) {
                          // WARNING: Could not recover jumptable at 0x00018067f70b. Too many branches
                          // WARNING: Treating indirect jump as call
          (**(code **)(*plVar1 + 0x418))(plVar1,*(uint64 *)(*plVar1 + 0x420));
          return;
        }
    }

    // Token : 0x60027D8
    // RVA   : 0x67F720   Offset: 0x67E520   Length: 0x27
    internal void <DOValue>b__1(float x)
    {
        plVar1 = this.target;
        if (plVar1 != (int64 *)0) {
                          // WARNING: Could not recover jumptable at 0x00018067f73b. Too many branches
                          // WARNING: Treating indirect jump as call
          (**(code **)(*plVar1 + 0x428))(plVar1,x,*(uint64 *)(*plVar1 + 0x430));
          return;
        }
    }

}
