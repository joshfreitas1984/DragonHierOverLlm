// ============================================================
// Type  : WorldPlotEventData
// Token : 0x200020A
// ============================================================

public class WorldPlotEventData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000EB6
    public string name;

    // Token: 0x4000EB7
    public AvailableGameMode availableMode;

    // Token: 0x4000EB8
    public float difficulty;

    // Token: 0x4000EB9
    public int plotID;

    // Token: 0x4000EBA
    public PlotTriggerType triggerType;

    // Token: 0x4000EBB
    public string triggerTargetID;

    // Token: 0x4000EBC
    public List<WorldPlotEventNeedData> needDatas;

    // Token: 0x4000EBD
    public TimeData startTime;

    // Token: 0x4000EBE
    public int startTimeRandomDayRange;

    // Token: 0x4000EBF
    public int startContinueTime;

    // Token: 0x4000EC0
    public WorldPlotEventRepeatType repeatType;

    // Token: 0x4000EC1
    public int repeatTime;

    // Token: 0x4000EC2
    public TimeData endTime;

    // Token: 0x4000EC3
    public WorldPlotEventStartRemindType startRemindType;

    // Token: 0x4000EC4
    public string startRemindSouce;

    // Token: 0x4000EC5
    public string startRemindText;

    // Token: 0x4000EC6
    public string startCallSpeFuc;

    // Token: 0x4000EC7
    public string outtimeCallSpeFuc;

    // Token: 0x4000EC8
    public bool noAutoDestroy;

    // Token: 0x4000EC9
    public bool notImportant;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000FEF
    // RVA   : 0x210B70   Offset: 0x20FF70   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x6000FF0
    // RVA   : 0x9D5A10   Offset: 0x9D4E10   Length: 0x175
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
