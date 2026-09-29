// ============================================================
// Type  : PrisonData
// Token : 0x20001DB
// ============================================================

public class PrisonData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000C9E
    public float guardAlert;

    // Token: 0x4000C9F
    public float guardFavor;

    // Token: 0x4000CA0
    public ItemListData prisonItemKeep;

    // Token: 0x4000CA1
    public float buyGuardCd;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000ECD
    // RVA   : 0xB12260   Offset: 0xB11660   Length: 0x6D
    public void /*ctor*/()
    {
        ulong uVar1;
        ZhSegment.Initialize(this,0);
        this.guardAlert = 0x42c80000;
        this.prisonItemKeep = new ItemListData(0);
    }

}
