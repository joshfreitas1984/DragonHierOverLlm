// ============================================================
// Type  : WorldEventDataBase
// Token : 0x20001D1
// ============================================================

public class WorldEventDataBase
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000BFC
    public int id;

    // Token: 0x4000BFD
    public string name;

    // Token: 0x4000BFE
    public TimeData startTime;

    // Token: 0x4000BFF
    public List<PlotSignRequirement> plotSignRequirements;

    // Token: 0x4000C00
    public WorldEventRepeatType repeatType;

    // Token: 0x4000C01
    public int repeatDay;

    // Token: 0x4000C02
    public int repeatDayRandomRange;

    // Token: 0x4000C03
    public int lastTime;

    // Token: 0x4000C04
    public bool noRandomDifficulty;

    // Token: 0x4000C05
    public int forceDifficulty;

    // Token: 0x4000C06
    public string startCallPlot;

    // Token: 0x4000C07
    public WorldEventRandomArea eventRandomArea;

    // Token: 0x4000C08
    public EventData eventData;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000E90
    // RVA   : 0xB2A3C0   Offset: 0xB28BC0   Length: 0x175
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

    // Token : 0x6000E91
    // RVA   : 0xB2A540   Offset: 0xB28D40   Length: 0xE
    public void /*ctor*/()
    {
        this.forceDifficulty = 0xffffffff;
        ZhSegment.Initialize(this,0);
    }

}
