// ============================================================
// Type  : MissionTargetData
// Token : 0x2000250
// ============================================================

public class MissionTargetData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001280
    public string describe;

    // Token: 0x4001281
    public int missionEventDataSaveRecord;

    // Token: 0x4001282
    public EventData missionEventData;

    // Token: 0x4001283
    public MissionTriggerType missionTriggerType;

    // Token: 0x4001284
    public MissionTargetAreaTypeLimit missionTargetAreaTypeLimit;

    // Token: 0x4001285
    public string tirggerTargetID;

    // Token: 0x4001286
    public List<MissionNeedData> missionNeedDatas;

    // Token: 0x4001287
    public List<ChoiceRequirementType> missionRequirementTypeList;

    // Token: 0x4001288
    public ChoiceRequirementType missionRequirementType;

    // Token: 0x4001289
    public float missionRequirementNum;

    // Token: 0x400128A
    public int missionTargetFinishCallPlotID;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600132E
    // RVA   : 0x848260   Offset: 0x847060   Length: 0xD4
    public void /*ctor*/()
    {
        long lVar1;
        ulong uVar2;
        this.missionTargetFinishCallPlotID = 0xffffffff;
        ZhSegment.Initialize(this,0);
        lVar1 = il2cpp_internal(DAT_181e74bb8);
        FUN_1810f3480(lVar1,DAT_181e76f60);
        uVar2 = new ZhSegment(0);
        if (lVar1 != null) {
          FUN_18175de30(lVar1,uVar2,DAT_181e77060);
          this.missionNeedDatas = lVar1;
          return;
        }
    }

    // Token : 0x600132F
    // RVA   : 0x848120   Offset: 0x846F20   Length: 0x139
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
               (lVar2 = FUN_1800024b0(this.missionNeedDatas,uVar3,DAT_181e77160)) == null)
            break;
            fVar1 = *(float *)(lVar2 + 36);
            if ((this.missionNeedDatas == null) ||
               (lVar2 = FUN_1800024b0(this.missionNeedDatas,uVar3,DAT_181e77160)) == null)
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

    // Token : 0x6001330
    // RVA   : 0x847D40   Offset: 0x846B40   Length: 0x3D0
    public virtual object Clone()
    {
        uint uVar1;
        long lVar2;
        long lVar3;
        long lVar4;
        ulong uVar5;
        uint uVar8;
        long lVar10;
        lVar3 = il2cpp_internal(DAT_181e6aef0);
        *(uint32 *)(lVar3 + 80) = 0xffffffff;
        ZhSegment.Initialize(lVar3,0);
        lVar4 = il2cpp_internal(DAT_181e74bb8);
        FUN_1810f3480(lVar4,DAT_181e76f60);
        uVar5 = new ZhSegment(0);
        if (lVar4 != null) {
          FUN_18175de30(lVar4,uVar5,DAT_181e77060);
          *(int64 *)(lVar3 + 56) = lVar4;
          *(uint64 *)(lVar3 + 16) = this.describe;
          *(uint32 *)(lVar3 + 24) = this.missionEventDataSaveRecord;
          if (this.missionEventData == null) {
            plVar6 = (int64 *)0;
          }
          else {
            plVar6 = (int64 *)EventData.Clone(this.missionEventData,0);
          }
          plVar7 = (int64 *)0;
          *(int64 **)(lVar3 + 32) = plVar6;
          *(uint32 *)(lVar3 + 40) = this.missionTriggerType;
          *(uint32 *)(lVar3 + 44) = this.missionTargetAreaTypeLimit;
          *(uint64 *)(lVar3 + 48) = this.tirggerTargetID;
          if (this.missionNeedDatas == null) {
            *(uint64 *)(lVar3 + 56) = 0;
        LAB_18084808a:
            lVar4 = this.missionRequirementTypeList;
            if (lVar4 != null) {
              plVar7 = (int64 *)il2cpp_internal(DAT_181e71b38);
              FUN_181779b60(plVar7,lVar4,DAT_181e644f8);
            }
            *(uint64 *)(lVar3 + 64) = plVar7;
            *(uint32 *)(lVar3 + 72) = this.missionRequirementType;
            *(uint32 *)(lVar3 + 76) = this.missionRequirementNum;
            *(uint32 *)(lVar3 + 80) = this.missionTargetFinishCallPlotID;
            return lVar3;
          }
          uVar1 = this.missionNeedDatas.Count;
          uVar5 = new List_1(uVar1,DAT_181e76fe0);
          *(uint64 *)(lVar3 + 56) = uVar5;
          lVar4 = this.missionNeedDatas;
          if (lVar4 != null) {
            lVar10 = 32;
            plVar6 = plVar7;
            while( true ) {
              uVar8 = (uint32)plVar6;
              if (lVar4.Count <= (int)uVar8) goto LAB_18084808a;
              lVar2 = *(int64 *)(lVar3 + 56);
              if (lVar4 == null) break;
              if (lVar4.Count <= uVar8) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              plVar9 = plVar7;
              if (*(int64 *)(lVar10 + lVar4._items) != 0) {
                if ((this.missionNeedDatas == null) ||
                   (lVar4 = FUN_1800024b0(this.missionNeedDatas,plVar6,DAT_181e77160)) == null
                   ) break;
                plVar6 = (int64 *)MissionNeedData.Clone(lVar4,0);
                if (plVar6 != (int64 *)0) {
                }
              }
              if (lVar2 == null) break;
              FUN_18175de30(lVar2,plVar9,DAT_181e77060);
              lVar4 = this.missionNeedDatas;
              plVar6 = (int64 *)(uint64)(uVar8 + 1);
              lVar10 = lVar10 + 8;
              if (lVar4 == null) break;
            }
          }
        }
    }

}
