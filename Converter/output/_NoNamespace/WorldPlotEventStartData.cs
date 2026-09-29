// ============================================================
// Type  : WorldPlotEventStartData
// Token : 0x200020B
// ============================================================

public class WorldPlotEventStartData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000ECA
    public string name;

    // Token: 0x4000ECB
    public float difficulty;

    // Token: 0x4000ECC
    public int plotID;

    // Token: 0x4000ECD
    public PlotTriggerType triggerType;

    // Token: 0x4000ECE
    public string triggerTargetID;

    // Token: 0x4000ECF
    public int startLeftDay;

    // Token: 0x4000ED0
    public int targetEventSaveRecord;

    // Token: 0x4000ED1
    public EventData targetEvent;

    // Token: 0x4000ED2
    public bool noAutoDestroy;

    // Token: 0x4000ED3
    public string outtimeCallSpeFuc;

    // Token: 0x4000ED4
    public bool notImportant;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000FF1
    // RVA   : 0x210B70   Offset: 0x20FF70   Length: 0x7
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

    // Token : 0x6000FF2
    // RVA   : 0x9D65B0   Offset: 0x9D59B0   Length: 0x83
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

    // Token : 0x6000FF3
    // RVA   : 0x9D6520   Offset: 0x9D5920   Length: 0x88
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

    // Token : 0x6000FF4
    // RVA   : 0x9D63A0   Offset: 0x9D57A0   Length: 0x175
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
        plVar1 = (int64 *)il2cpp_internal(DAT_181d89228);
        plVar4 = plVar1;
        MemoryStream.ctor(plVar1,1000,0);
        local_38 = 0;
        uStack_30 = 0;
        StreamingContext.ctor(&local_38,64,0);
        lVar2 = il2cpp_internal(DAT_181db1748);
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
            FUN_180002970(0,DAT_181d78db8,plVar1);
            return uVar3;
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
    }

}
