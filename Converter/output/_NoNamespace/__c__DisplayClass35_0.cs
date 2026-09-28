// ============================================================
// Type  : <>c__DisplayClass35_0
// Token : 0x200047A
// ============================================================

public class <>c__DisplayClass35_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4002132
    public int v;

    // Token: 0x4002133
    public Text target;

    // Token: 0x4002134
    public bool addThousandsSeparator;

    // Token: 0x4002135
    public CultureInfo cInfo;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002732
    // RVA   : 0x210B70   Offset: 0x20FF70   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x6002733
    // RVA   : 0x20F070   Offset: 0x20E470   Length: 0xC8
    internal int <DOCounter>b__0()
    {
        return this.v;
    }

    // Token : 0x6002734
    // RVA   : 0x939540   Offset: 0x938940   Length: 0x82
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
                          // WARNING: Could not recover jumptable at 0x0001809395b6. Too many branches
                          // WARNING: Treating indirect jump as call
          (**(code **)(*plVar2 + 0x5e8))(plVar2,uVar3,*(uint64 *)(*plVar2 + 0x5f0));
          return;
        }
    }

}
