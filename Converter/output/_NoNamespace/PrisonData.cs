// ============================================================
// Type  : PrisonData
// Token : 0x20001DD
// ============================================================

public class PrisonData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000CB1
    public float guardAlert;

    // Token: 0x4000CB2
    public float guardFavor;

    // Token: 0x4000CB3
    public ItemListData prisonItemKeep;

    // Token: 0x4000CB4
    public float buyGuardCd;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000ED3
    // RVA   : 0x8B4670   Offset: 0x8B3470   Length: 0x6D
    public void /*ctor*/()
    {
        ulong uVar1;
        ZhSegment.Initialize(this,0);
        this.guardAlert = 0x42c80000;
        this.prisonItemKeep = new ItemListData(0);
    }

}
