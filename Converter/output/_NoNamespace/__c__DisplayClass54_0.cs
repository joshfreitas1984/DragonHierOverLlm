// ============================================================
// Type  : <>c__DisplayClass54_0
// Token : 0x20002F3
// ============================================================

public class <>c__DisplayClass54_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001881
    public Dictionary<ItemData, string> sortKeys;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600189F
    // RVA   : 0x210B70   Offset: 0x20FF70   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x60018A0
    // RVA   : 0x8F61D0   Offset: 0x8F55D0   Length: 0x89
    internal int <ResetSortType>b__0(ItemData a, ItemData b)
    {
        ulong uVar1;
        ulong uVar2;
        if (this.sortKeys != null) {
          uVar1 = FUN_1817c63a0(this.sortKeys,a,DAT_181dc2430);
          if (this.sortKeys != null) {
            uVar2 = FUN_1817c63a0(this.sortKeys,b,DAT_181dc2430);
            String.CompareOrdinal(uVar1,uVar2,0);
            return;
          }
        }
    }

}
