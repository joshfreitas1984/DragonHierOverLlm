// ============================================================
// Type  : WorldPlotEventStartData
// Token : 0x2000205
// ============================================================

public class WorldPlotEventStartData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000E3A
    public string name;

    // Token: 0x4000E3B
    public float difficulty;

    // Token: 0x4000E3C
    public int plotID;

    // Token: 0x4000E3D
    public PlotTriggerType triggerType;

    // Token: 0x4000E3E
    public string triggerTargetID;

    // Token: 0x4000E3F
    public int startLeftDay;

    // Token: 0x4000E40
    public int targetEventSaveRecord;

    // Token: 0x4000E41
    public EventData targetEvent;

    // Token: 0x4000E42
    public bool noAutoDestroy;

    // Token: 0x4000E43
    public string outtimeCallSpeFuc;

    // Token: 0x4000E44
    public bool notImportant;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000FB9
    // RVA   : 0x210B70   Offset: 0x20F370   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
        if (param_2 != 0) {
          this.name = *(uint64 *)(param_2 + 16);
          this.difficulty = *(uint32 *)(param_2 + 28);
          this.plotID = *(uint32 *)(param_2 + 32);
          this.triggerType = *(uint32 *)(param_2 + 36);
          this.triggerTargetID = *(uint64 *)(param_2 + 40);
          this.startLeftDay = *(uint32 *)(param_2 + 68);
          this.noAutoDestroy = *(uint8 *)(param_2 + 128);
          this.outtimeCallSpeFuc = *(uint64 *)(param_2 + 120);
          this.notImportant = *(uint8 *)(param_2 + 129);
          return;
        }
    }

    // Token : 0x6000FBA
    // RVA   : 0xB2DDF0   Offset: 0xB2C5F0   Length: 0x83
    public void /*ctor*/(int _plotID, PlotTriggerType _triggerType, string _triggerTargetID, int _startLeftDay, string _name, float _difficulty, EventData _targetEvent)
    {
        ZhSegment.Initialize(this,0);
        if (_plotID != null) {
          this.name = *(uint64 *)(_plotID + 16);
          this.difficulty = *(uint32 *)(_plotID + 28);
          this.plotID = *(uint32 *)(_plotID + 32);
          this.triggerType = *(uint32 *)(_plotID + 36);
          this.triggerTargetID = *(uint64 *)(_plotID + 40);
          this.startLeftDay = *(uint32 *)(_plotID + 68);
          this.noAutoDestroy = *(uint8 *)(_plotID + 128);
          this.outtimeCallSpeFuc = *(uint64 *)(_plotID + 120);
          this.notImportant = *(uint8 *)(_plotID + 129);
          return;
        }
    }

    // Token : 0x6000FBB
    // RVA   : 0xB2DD60   Offset: 0xB2C560   Length: 0x88
    public void /*ctor*/(WorldPlotEventData worldPlotEventData)
    {
        ZhSegment.Initialize(this,0);
        if (worldPlotEventData != null) {
          this.name = *(uint64 *)(worldPlotEventData + 16);
          this.difficulty = *(uint32 *)(worldPlotEventData + 28);
          this.plotID = *(uint32 *)(worldPlotEventData + 32);
          this.triggerType = *(uint32 *)(worldPlotEventData + 36);
          this.triggerTargetID = *(uint64 *)(worldPlotEventData + 40);
          this.startLeftDay = *(uint32 *)(worldPlotEventData + 68);
          this.noAutoDestroy = *(uint8 *)(worldPlotEventData + 128);
          this.outtimeCallSpeFuc = *(uint64 *)(worldPlotEventData + 120);
          this.notImportant = *(uint8 *)(worldPlotEventData + 129);
          return;
        }
    }

    // Token : 0x6000FBC
    // RVA   : 0xB2DBE0   Offset: 0xB2C3E0   Length: 0x175
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
