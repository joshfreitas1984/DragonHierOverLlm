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
    // RVA   : 0x928E70   Offset: 0x928270   Length: 0x89
    internal int <ResetSortType>b__0(ItemData a, ItemData b)
    {
        ulong uVar1;
        ulong uVar2;
        if (this.sortKeys != null) {
          uVar1 = FUN_1817c69b0(this.sortKeys,a,DAT_181dc2448);
          if (this.sortKeys != null) {
            uVar2 = FUN_1817c69b0(this.sortKeys,b,DAT_181dc2448);
            String.CompareOrdinal(uVar1,uVar2,0);
            return;
          }
        }
    }

}
