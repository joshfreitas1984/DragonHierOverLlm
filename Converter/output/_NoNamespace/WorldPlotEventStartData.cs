// ============================================================
// Type  : WorldPlotEventStartData
// Token : 0x200020D
// ============================================================

public class WorldPlotEventStartData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000EDE
    public string name;

    // Token: 0x4000EDF
    public float difficulty;

    // Token: 0x4000EE0
    public int plotID;

    // Token: 0x4000EE1
    public PlotTriggerType triggerType;

    // Token: 0x4000EE2
    public string triggerTargetID;

    // Token: 0x4000EE3
    public int startLeftDay;

    // Token: 0x4000EE4
    public int targetEventSaveRecord;

    // Token: 0x4000EE5
    public EventData targetEvent;

    // Token: 0x4000EE6
    public bool noAutoDestroy;

    // Token: 0x4000EE7
    public string outtimeCallSpeFuc;

    // Token: 0x4000EE8
    public bool notImportant;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000FFA
    // RVA   : 0x42F150   Offset: 0x42DF50   Length: 0x7
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

    // Token : 0x6000FFB
    // RVA   : 0x7218F0   Offset: 0x7206F0   Length: 0x83
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

    // Token : 0x6000FFC
    // RVA   : 0x721860   Offset: 0x720660   Length: 0x88
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

    // Token : 0x6000FFD
    // RVA   : 0x7216E0   Offset: 0x7204E0   Length: 0x175
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
