// ============================================================
// Type  : <>c__DisplayClass35_0
// Token : 0x2000473
// ============================================================

public class <>c__DisplayClass35_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4002028
    public int v;

    // Token: 0x4002029
    public Text target;

    // Token: 0x400202A
    public bool addThousandsSeparator;

    // Token: 0x400202B
    public CultureInfo cInfo;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60026AF
    // RVA   : 0x210B70   Offset: 0x20F370   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x60026B0
    // RVA   : 0x20F070   Offset: 0x20D870   Length: 0xC8
    internal int <DOCounter>b__0()
    {
        return this.v;
    }

    // Token : 0x60026B1
    // RVA   : 0x8D7050   Offset: 0x8D5850   Length: 0x82
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
                          // WARNING: Could not recover jumptable at 0x0001808d70c6. Too many branches
                          // WARNING: Treating indirect jump as call
          (**(code **)(*plVar2 + 0x5e8))(plVar2,uVar3,*(uint64 *)(*plVar2 + 0x5f0));
          return;
        }
    }

}
