// ============================================================
// Type  : WorldEventDataBase
// Token : 0x20001D7
// ============================================================

public class WorldEventDataBase
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000C89
    public int id;

    // Token: 0x4000C8A
    public string name;

    // Token: 0x4000C8B
    public TimeData startTime;

    // Token: 0x4000C8C
    public List<PlotSignRequirement> plotSignRequirements;

    // Token: 0x4000C8D
    public WorldEventRepeatType repeatType;

    // Token: 0x4000C8E
    public int repeatDay;

    // Token: 0x4000C8F
    public int repeatDayRandomRange;

    // Token: 0x4000C90
    public int lastTime;

    // Token: 0x4000C91
    public bool noRandomDifficulty;

    // Token: 0x4000C92
    public int forceDifficulty;

    // Token: 0x4000C93
    public string startCallPlot;

    // Token: 0x4000C94
    public WorldEventRandomArea eventRandomArea;

    // Token: 0x4000C95
    public EventData eventData;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000EC5
    // RVA   : 0x9D2380   Offset: 0x9D1780   Length: 0x175
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

    // Token : 0x6000EC6
    // RVA   : 0x9D2500   Offset: 0x9D1900   Length: 0xE
    public void /*ctor*/()
    {
        this.forceDifficulty = 0xffffffff;
        ZhSegment.Initialize(this,0);
    }

}
