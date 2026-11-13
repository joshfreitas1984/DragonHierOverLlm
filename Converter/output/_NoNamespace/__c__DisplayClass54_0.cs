// ============================================================
// Type  : <>c__DisplayClass54_0
// Token : 0x20002FC
// ============================================================

public class <>c__DisplayClass54_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40018D7
    public Dictionary<ItemData, string> sortKeys;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600191B
    // RVA   : 0x42F150   Offset: 0x42DF50   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x600191C
    // RVA   : 0x617690   Offset: 0x616490   Length: 0x89
    internal int <ResetSortType>b__0(ItemData a, ItemData b)
    {
        ulong uVar1;
        ulong uVar2;
        if (this.sortKeys != null) {
          uVar1 = FUN_1817072e0(this.sortKeys,a,DAT_181ea3cd0);
          if (this.sortKeys != null) {
            uVar2 = FUN_1817072e0(this.sortKeys,b,DAT_181ea3cd0);
            String.CompareOrdinal(uVar1,uVar2,0);
            return;
          }
        }
    }

}
