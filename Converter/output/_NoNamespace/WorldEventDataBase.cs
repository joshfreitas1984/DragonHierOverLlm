// ============================================================
// Type  : WorldEventDataBase
// Token : 0x20001D9
// ============================================================

public class WorldEventDataBase
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000C9C
    public int id;

    // Token: 0x4000C9D
    public string name;

    // Token: 0x4000C9E
    public TimeData startTime;

    // Token: 0x4000C9F
    public List<PlotSignRequirement> plotSignRequirements;

    // Token: 0x4000CA0
    public WorldEventRepeatType repeatType;

    // Token: 0x4000CA1
    public int repeatDay;

    // Token: 0x4000CA2
    public int repeatDayRandomRange;

    // Token: 0x4000CA3
    public int lastTime;

    // Token: 0x4000CA4
    public bool noRandomDifficulty;

    // Token: 0x4000CA5
    public int forceDifficulty;

    // Token: 0x4000CA6
    public string startCallPlot;

    // Token: 0x4000CA7
    public WorldEventRandomArea eventRandomArea;

    // Token: 0x4000CA8
    public EventData eventData;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000ECB
    // RVA   : 0x71DD00   Offset: 0x71CB00   Length: 0x175
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

    // Token : 0x6000ECC
    // RVA   : 0x71DE80   Offset: 0x71CC80   Length: 0xE
    public void /*ctor*/()
    {
        this.forceDifficulty = 0xffffffff;
        ZhSegment.Initialize(this,0);
    }

}
