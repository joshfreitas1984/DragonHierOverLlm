// ============================================================
// Type  : BattlePlotData
// Token : 0x2000153
// ============================================================

public class BattlePlotData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000886
    public BattlePlotTrigger battlePlotTrigger;

    // Token: 0x4000887
    public string battlePlotTarget;

    // Token: 0x4000888
    public int battlePlotID;

    // Token: 0x4000889
    public bool noAutoDestroy;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000AD2
    // RVA   : 0x8DF770   Offset: 0x8DDF70   Length: 0x58
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
