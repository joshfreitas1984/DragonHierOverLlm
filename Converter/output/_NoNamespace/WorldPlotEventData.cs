// ============================================================
// Type  : WorldPlotEventData
// Token : 0x200020C
// ============================================================

public class WorldPlotEventData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000ECA
    public string name;

    // Token: 0x4000ECB
    public AvailableGameMode availableMode;

    // Token: 0x4000ECC
    public float difficulty;

    // Token: 0x4000ECD
    public int plotID;

    // Token: 0x4000ECE
    public PlotTriggerType triggerType;

    // Token: 0x4000ECF
    public string triggerTargetID;

    // Token: 0x4000ED0
    public List<WorldPlotEventNeedData> needDatas;

    // Token: 0x4000ED1
    public TimeData startTime;

    // Token: 0x4000ED2
    public int startTimeRandomDayRange;

    // Token: 0x4000ED3
    public int startContinueTime;

    // Token: 0x4000ED4
    public WorldPlotEventRepeatType repeatType;

    // Token: 0x4000ED5
    public int repeatTime;

    // Token: 0x4000ED6
    public TimeData endTime;

    // Token: 0x4000ED7
    public WorldPlotEventStartRemindType startRemindType;

    // Token: 0x4000ED8
    public string startRemindSouce;

    // Token: 0x4000ED9
    public string startRemindText;

    // Token: 0x4000EDA
    public string startCallSpeFuc;

    // Token: 0x4000EDB
    public string outtimeCallSpeFuc;

    // Token: 0x4000EDC
    public bool noAutoDestroy;

    // Token: 0x4000EDD
    public bool notImportant;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000FF8
    // RVA   : 0x42F150   Offset: 0x42DF50   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x6000FF9
    // RVA   : 0x7213E0   Offset: 0x7201E0   Length: 0x175
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
        plVar1 = (int64 *)il2cpp_internal(DAT_181e695f0);
        plVar4 = plVar1;
        MemoryStream.ctor(plVar1,1000,0);
        local_38 = 0;
        uStack_30 = 0;
        StreamingContext.ctor(&local_38,64,0);
        lVar2 = il2cpp_internal(DAT_181e91a00);
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
            FUN_180002280(0,DAT_181e58ab8,plVar1);
            return uVar3;
          }
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
    }

}
