// ============================================================
// Type  : BattlePlotData
// Token : 0x2000153
// ============================================================

public class BattlePlotData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400088F
    public BattlePlotTrigger battlePlotTrigger;

    // Token: 0x4000890
    public string battlePlotTarget;

    // Token: 0x4000891
    public int battlePlotID;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000AD4
    // RVA   : 0x5EA620   Offset: 0x5E9420   Length: 0x50
    public void /*ctor*/(BattlePlotTrigger _battlePlotTrigger, string _battlePlotTarget, int _battlePlotID)
    {
        ZhSegment.Initialize(this,0);
        this.battlePlotTarget = _battlePlotTarget;
        this.battlePlotTrigger = _battlePlotTrigger;
        this.battlePlotID = _battlePlotID;
    }

}
