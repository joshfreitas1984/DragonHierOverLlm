// ============================================================
// Type  : MissionTargetData
// Token : 0x2000246
// ============================================================

public class MissionTargetData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40011BF
    public string describe;

    // Token: 0x40011C0
    public int missionEventDataSaveRecord;

    // Token: 0x40011C1
    public EventData missionEventData;

    // Token: 0x40011C2
    public MissionTriggerType missionTriggerType;

    // Token: 0x40011C3
    public MissionTargetAreaTypeLimit missionTargetAreaTypeLimit;

    // Token: 0x40011C4
    public string tirggerTargetID;

    // Token: 0x40011C5
    public List<MissionNeedData> missionNeedDatas;

    // Token: 0x40011C6
    public List<ChoiceRequirementType> missionRequirementTypeList;

    // Token: 0x40011C7
    public ChoiceRequirementType missionRequirementType;

    // Token: 0x40011C8
    public float missionRequirementNum;

    // Token: 0x40011C9
    public int missionTargetFinishCallPlotID;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60012C9
    // RVA   : 0xAF0360   Offset: 0xAEEB60   Length: 0xD4
    public void /*ctor*/()
    {
        long lVar1;
        ulong uVar2;
        this.missionTargetFinishCallPlotID = 0xffffffff;
        ZhSegment.Initialize(this,0);
        lVar1 = il2cpp_internal(DAT_181d6ff30);
        FUN_180f58a90(lVar1,DAT_181d6d568);
        uVar2 = new ZhSegment(0);
        if (lVar1 != null) {
          FUN_181827900(lVar1,uVar2,DAT_181d6d5e8);
          this.missionNeedDatas = lVar1;
          return;
        }
    }

    // Token : 0x60012CA
    // RVA   : 0xAF0220   Offset: 0xAEEA20   Length: 0x139
    public bool MissionNumMeetRequire()
    {
        float fVar1;
        long lVar2;
        uint uVar3;
        long lVar4;
        lVar2 = this.missionNeedDatas;
        uVar3 = 0;
        if (lVar2 != null) {
          lVar4 = 32;
          while( true ) {
            if (lVar2.Count <= (int)uVar3) {
              return true;
            }
            if (lVar2 == null) break;
            if (lVar2.Count <= uVar3) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar2 = *(int64 *)(lVar4 + lVar2._items);
            if (lVar2 == null) break;
            if (*(float *)(lVar2 + 40) <= 0.0) {
              return false;
            }
            if ((this.missionNeedDatas == null) ||
               (lVar2 = FUN_180002f80(this.missionNeedDatas,uVar3,DAT_181d6d6e8)) == null)
            break;
            fVar1 = *(float *)(lVar2 + 36);
            if ((this.missionNeedDatas == null) ||
               (lVar2 = FUN_180002f80(this.missionNeedDatas,uVar3,DAT_181d6d6e8)) == null)
            break;
            if (fVar1 < *(float *)(lVar2 + 40)) {
              return false;
            }
            lVar2 = this.missionNeedDatas;
            uVar3 = uVar3 + 1;
            lVar4 = lVar4 + 8;
            if (lVar2 == null) break;
          }
        }
    }

    // Token : 0x60012CB
    // RVA   : 0xAF00A0   Offset: 0xAEE8A0   Length: 0x175
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
