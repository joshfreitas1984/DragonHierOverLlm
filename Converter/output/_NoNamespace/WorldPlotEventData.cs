// ============================================================
// Type  : WorldPlotEventData
// Token : 0x2000204
// ============================================================

public class WorldPlotEventData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000E26
    public string name;

    // Token: 0x4000E27
    public AvailableGameMode availableMode;

    // Token: 0x4000E28
    public float difficulty;

    // Token: 0x4000E29
    public int plotID;

    // Token: 0x4000E2A
    public PlotTriggerType triggerType;

    // Token: 0x4000E2B
    public string triggerTargetID;

    // Token: 0x4000E2C
    public List<WorldPlotEventNeedData> needDatas;

    // Token: 0x4000E2D
    public TimeData startTime;

    // Token: 0x4000E2E
    public int startTimeRandomDayRange;

    // Token: 0x4000E2F
    public int startContinueTime;

    // Token: 0x4000E30
    public WorldPlotEventRepeatType repeatType;

    // Token: 0x4000E31
    public int repeatTime;

    // Token: 0x4000E32
    public TimeData endTime;

    // Token: 0x4000E33
    public WorldPlotEventStartRemindType startRemindType;

    // Token: 0x4000E34
    public string startRemindSouce;

    // Token: 0x4000E35
    public string startRemindText;

    // Token: 0x4000E36
    public string startCallSpeFuc;

    // Token: 0x4000E37
    public string outtimeCallSpeFuc;

    // Token: 0x4000E38
    public bool noAutoDestroy;

    // Token: 0x4000E39
    public bool notImportant;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000FB7
    // RVA   : 0x210B70   Offset: 0x20F370   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x6000FB8
    // RVA   : 0xB2D8E0   Offset: 0xB2C0E0   Length: 0x175
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
        plVar1 = (int64 *)il2cpp_internal(DAT_181d63ff0);
        plVar4 = plVar1;
        MemoryStream.ctor(plVar1,1000,0);
        local_38 = 0;
        uStack_30 = 0;
        StreamingContext.ctor(&local_38,64,0);
        lVar2 = il2cpp_internal(DAT_181d8c5a8);
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
            FUN_180002970(0,DAT_181d53c70,plVar1);
            return uVar3;
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
    }

}
