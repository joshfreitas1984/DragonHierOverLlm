// ============================================================
// Type  : PlotData
// Token : 0x2000203
// ============================================================

public class PlotData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000E8D
    public string plotName;

    // Token: 0x4000E8E
    public bool spePlot;

    // Token: 0x4000E8F
    public int plotID;

    // Token: 0x4000E90
    public List<PlotRandomHeroData> plotRandomHero;

    // Token: 0x4000E91
    public bool differentForce;

    // Token: 0x4000E92
    public int targetHeroID;

    // Token: 0x4000E93
    public string plotCallFuc;

    // Token: 0x4000E94
    public bool randomStartPlot;

    // Token: 0x4000E95
    public List<SinglePlotData> plotDatas;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000FEB
    // RVA   : 0xB0C360   Offset: 0xB0B760   Length: 0xBB
    public void /*ctor*/()
    {
        ulong uVar1;
        ZhSegment.Initialize(this,0);
        uVar1 = il2cpp_internal(DAT_181d952d0);
        FUN_18132faf0(uVar1,DAT_181d97508);
        this.plotRandomHero = uVar1;
        uVar1 = il2cpp_internal(DAT_181d96fd0);
        FUN_18132faf0(uVar1,DAT_181da1370);
        this.plotDatas = uVar1;
    }

    // Token : 0x6000FEC
    // RVA   : 0xB0C1E0   Offset: 0xB0B5E0   Length: 0x175
    public virtual object Clone()
    {
        long lVar2;
        ulong uVar3;
        ulong local_38;
        ulong uStack_30;
        uint local_28;
        uint uStack_24;
        uint uStack_20;
        uint32 uStack_1c;
        plVar1 = (int64 *)il2cpp_internal(DAT_181d89210);
        plVar4 = plVar1;
        MemoryStream.ctor(plVar1,1000,0);
        local_38 = 0;
        uStack_30 = 0;
        StreamingContext.ctor(&local_38,64,0);
        lVar2 = il2cpp_internal(DAT_181db1730);
        local_28 = (uint32)local_38;
        uStack_24 = local_38._4_4_;
        uStack_20 = (uint32)uStack_30;
        uStack_1c = uStack_30._4_4_;
        BinaryFormatter.ctor(lVar2,0,&local_28,0,plVar4);
        if (lVar2 != null) {
          BinaryFormatter.Serialize(lVar2,plVar1,this,0);
          if (plVar1 != (int64 *)0) {
            (**(code **)(*plVar1 + 0x2c8))(plVar1,0,0,*(uint64 *)(*plVar1 + 0x2d0));
            uVar3 = BinaryFormatter.Deserialize(lVar2,plVar1,0);
            (**(code **)(*plVar1 + 0x238))(plVar1,*(uint64 *)(*plVar1 + 0x240));
            FUN_180002970(0,DAT_181d78da0,plVar1);
            return uVar3;
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
    }

}
