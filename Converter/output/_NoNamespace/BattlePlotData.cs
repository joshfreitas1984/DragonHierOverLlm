// ============================================================
// Type  : BattlePlotData
// Token : 0x2000157
// ============================================================

public class BattlePlotData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40008AD
    public BattlePlotTrigger battlePlotTrigger;

    // Token: 0x40008AE
    public string battlePlotTarget;

    // Token: 0x40008AF
    public int battlePlotID;

    // Token: 0x40008B0
    public bool noAutoDestroy;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000AF5
    // RVA   : 0x8CA950   Offset: 0x8C9D50   Length: 0x58
    public void /*ctor*/(BattlePlotTrigger _battlePlotTrigger, string _battlePlotTarget, int _battlePlotID, bool _noAutoDestroy)
    {
        void BattlePlotData.ctor
                     (int64 this,uint32 _battlePlotTrigger,uint64 _battlePlotTarget,uint32 _battlePlotID,
                     uint8 _noAutoDestroy)
        {
        ZhSegment.Initialize(this,0);
        this.battlePlotTarget = _battlePlotTarget;
        this.battlePlotTrigger = _battlePlotTrigger;
        this.battlePlotID = _battlePlotID;
        this.noAutoDestroy = _noAutoDestroy;
    }

}
