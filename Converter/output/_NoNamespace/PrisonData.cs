// ============================================================
// Type  : PrisonData
// Token : 0x20001D5
// ============================================================

public class PrisonData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000C11
    public float guardAlert;

    // Token: 0x4000C12
    public float guardFavor;

    // Token: 0x4000C13
    public ItemListData prisonItemKeep;

    // Token: 0x4000C14
    public float buyGuardCd;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000E98
    // RVA   : 0xBDD6D0   Offset: 0xBDBED0   Length: 0x6D
    public void /*ctor*/()
    {
        ulong uVar1;
        ZhSegment.Initialize(this,0);
        this.guardAlert = 0x42c80000;
        this.prisonItemKeep = new ItemListData(0);
    }

}
