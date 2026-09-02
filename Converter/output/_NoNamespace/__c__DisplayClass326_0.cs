// ============================================================
// Type  : <>c__DisplayClass326_0
// Token : 0x20002B2
// ============================================================

public class <>c__DisplayClass326_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001606
    public Text targetText;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600171B
    // RVA   : 0x210B70   Offset: 0x20F370   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x600171C
    // RVA   : 0x8D6F00   Offset: 0x8D5700   Length: 0x69
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
