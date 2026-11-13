// ============================================================
// Type  : <>c__DisplayClass331_0
// Token : 0x20002C1
// ============================================================

public class <>c__DisplayClass331_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400170E
    public Text targetText;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60017DB
    // RVA   : 0x42F150   Offset: 0x42DF50   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x60017DC
    // RVA   : 0x67F640   Offset: 0x67E440   Length: 0x69
    internal void <DoTweenTextValue>b__0(float value)
    {
        ulong uVar2;
        uint[] local_res10 = new uint[6];
        local_res10[0] = value;
        plVar1 = this.targetText;
        uVar2 = Single.ToString(local_res10,"f0",0);
        if (plVar1 != (int64 *)0) {
          (**(code **)(*plVar1 + 0x5e8))(plVar1,uVar2,*(uint64 *)(*plVar1 + 0x5f0));
          return;
        }
    }

}
