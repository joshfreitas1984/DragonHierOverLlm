// ============================================================
// Type  : <>c__DisplayClass327_0
// Token : 0x20002B8
// ============================================================

public class <>c__DisplayClass327_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40016BA
    public Text targetText;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600175F
    // RVA   : 0x210B70   Offset: 0x20FF70   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x6001760
    // RVA   : 0x939A80   Offset: 0x938E80   Length: 0x69
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
