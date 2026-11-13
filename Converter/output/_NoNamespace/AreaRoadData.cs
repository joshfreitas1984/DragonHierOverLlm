// ============================================================
// Type  : AreaRoadData
// Token : 0x20001F3
// ============================================================

public class AreaRoadData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000DEE
    public int areaID;

    // Token: 0x4000DEF
    public int roadLv;

    // Token: 0x4000DF0
    public int upgradeTimeLeft;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000F90
    // RVA   : 0x51FED0   Offset: 0x51ECD0   Length: 0x287
    public string GetUpgradeCostText()
    {
        int iVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        float fVar5;
        float fVar6;
        uint[] local_res8 = new uint[2];
        iVar1 = this.roadLv;
        lVar2 = AreaRoadData.GetArea(this,0);
        if ((lVar2 != null) && (*(int64 *)(lVar2 + 176) != 0)) {
          fVar5 = (float)ForceSpeAddData.Get(*(int64 *)(lVar2 + 176),13);
          fVar5 = fVar5 + 1.0;
          lVar2 = AreaRoadData.GetArea(this,0);
          if (lVar2 != null) {
            if (*(int *)(lVar2 + 112) != -1) {
              lVar2 = AreaRoadData.GetArea(this,0);
              if (lVar2 == null) throw; // [null/range check failed]
              lVar2 = AreaData.GetForce(lVar2,0);
              if ((lVar2 == null) || (*(int64 *)(lVar2 + 0x148) == 0)) throw; // [null/range check failed]
              fVar6 = (float)ForceSpeAddData.Get(*(int64 *)(lVar2 + 0x148),12);
              fVar5 = fVar5 + fVar6;
            }
            local_res8[0] = Mathf.RoundToInt(((float)(iVar1 + 1) * 10.0) / fVar5,0);
            uVar3 = il2cpp_value_box(DAT_181e60808,local_res8);
            lVar2 = il2cpp_internal(DAT_181e76ea8);
            FUN_1810f3480(lVar2,DAT_181e83230);
            if (lVar2 != null) {
              FUN_18175dba0(lVar2);
              FUN_18175dba0(lVar2);
              FUN_18175dba0(lVar2);
              FUN_18175dba0(lVar2);
              FUN_18175dba0(lVar2);
              FUN_18175dba0(lVar2);
              uVar4 = GlobalData.ListMulti(lVar2);
              uVar4 = GlobalData.GetResourceDescribe(uVar4,0);
              String.Format("消耗 ({0}天)\n{1}",uVar3,uVar4,0);
              return;
            }
          }
        }
    }

    // Token : 0x6000F91
    // RVA   : 0x51FDA0   Offset: 0x51EBA0   Length: 0x12F
    public List<float> GetUpgradeCostResource()
    {
        long lVar1;
        lVar1 = il2cpp_internal(DAT_181e76ea8);
        FUN_1810f3480(lVar1,DAT_181e83230);
        if (lVar1 != null) {
          FUN_18175dba0(lVar1);
          FUN_18175dba0(lVar1);
          FUN_18175dba0(lVar1);
          FUN_18175dba0(lVar1);
          FUN_18175dba0(lVar1);
          FUN_18175dba0(lVar1);
          GlobalData.ListMulti(lVar1);
          return;
        }
    }

    // Token : 0x6000F92
    // RVA   : 0x520160   Offset: 0x51EF60   Length: 0xCC
    public int GetUpgradeTime()
    {
        int iVar1;
        long lVar2;
        float fVar3;
        float fVar4;
        iVar1 = this.roadLv;
        lVar2 = AreaRoadData.GetArea(this,0);
        if ((lVar2 != null) && (*(int64 *)(lVar2 + 176) != 0)) {
          fVar3 = (float)ForceSpeAddData.Get(*(int64 *)(lVar2 + 176),13);
          fVar3 = fVar3 + 1.0;
          lVar2 = AreaRoadData.GetArea(this,0);
          if (lVar2 != null) {
            if (*(int *)(lVar2 + 112) == -1) {
        LAB_1805201fb:
              Mathf.RoundToInt(((float)(iVar1 + 1) * 10.0) / fVar3,0);
              return;
            }
            lVar2 = AreaRoadData.GetArea(this,0);
            if (lVar2 != null) {
              lVar2 = AreaData.GetForce(lVar2,0);
              if ((lVar2 != null) && (*(int64 *)(lVar2 + 0x148) != 0)) {
                fVar4 = (float)ForceSpeAddData.Get(*(int64 *)(lVar2 + 0x148),12);
                fVar3 = fVar3 + fVar4;
                goto LAB_1805201fb;
              }
            }
          }
        }
    }

    // Token : 0x6000F93
    // RVA   : 0x51FAB0   Offset: 0x51E8B0   Length: 0xA3
    public float GetBuildSpeedRate()
    {
        long lVar1;
        float fVar2;
        float fVar3;
        lVar1 = AreaRoadData.GetArea(this,0);
        if ((lVar1 != null) && (*(int64 *)(lVar1 + 176) != 0)) {
          fVar2 = (float)ForceSpeAddData.Get(*(int64 *)(lVar1 + 176),13);
          lVar1 = AreaRoadData.GetArea(this,0);
          if (lVar1 != null) {
            if (*(int *)(lVar1 + 112) == -1) {
              return fVar2 + 1.0;
            }
            lVar1 = AreaRoadData.GetArea(this,0);
            if (((lVar1 != null) && (lVar1 = AreaData.GetForce(lVar1,0)) != null) &&
               (*(int64 *)(lVar1 + 0x148) != 0)) {
              fVar3 = (float)ForceSpeAddData.Get(*(int64 *)(lVar1 + 0x148),12);
              return fVar2 + 1.0 + fVar3;
            }
          }
        }
    }

    // Token : 0x6000F94
    // RVA   : 0x51F9F0   Offset: 0x51E7F0   Length: 0xBE
    public AreaData GetArea()
    {
        long lVar1;
        if ((GameController._instance != null) &&
           (lVar1 = GameController._instance.worldData) != null) {
          WorldData.GetArea(lVar1,this.areaID,0);
          return;
        }
    }

    // Token : 0x6000F95
    // RVA   : 0x51FB60   Offset: 0x51E960   Length: 0x11
    public float GetProduceRateChange()
    {
        return (float)this.roadLv * 0.05;
    }

    // Token : 0x6000F96
    // RVA   : 0x51FB80   Offset: 0x51E980   Length: 0x213
    public string GetRoadDescribe()
    {
        uint uVar1;
        ulong uVar2;
        ulong uVar3;
        long lVar4;
        ulong uVar5;
        ulong uVar6;
        int[] local_res8 = new int[2];
        float[] local_res18 = new float[2];
        uVar1 = this.roadLv;
        local_res8[0] = 0;
        uVar2 = GlobalData.GetNumText(uVar1,0);
        uVar3 = String.Format("<size=17>道路 {0}级</size>",uVar2,0);
        lVar4 = AreaRoadData.GetArea(this,0);
        uVar2 = "\n\n每月产出\n{2}{0}</color>\n\n周边效率+{1}%";
        if (lVar4 == null) {
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        if (*(int *)(lVar4 + 72) == 2) {
          uVar5 = Int32.ToString(this + 20,0);
          uVar6 = "威望+";
        }
        else {
          local_res8[0] = this.roadLv * 5;
          uVar5 = Int32.ToString(local_res8,0);
          uVar6 = "人口+";
        }
        uVar6 = String.Concat(uVar6,uVar5,0);
        local_res18[0] = (float)this.roadLv * 0.05 * 100.0;
        uVar5 = il2cpp_value_box(DAT_181e82730,local_res18);
        uVar6 = String.Format(uVar2,uVar6,uVar5,
                               *(uint64 *)(*(int64 *)(DAT_181e538e8 + 184) + 0x270),0);
        uVar2 = "";
        if (0 < this.upgradeTimeLeft) {
          uVar2 = Int32.ToString(this + 24,0);
          uVar2 = String.Concat("\n\n升级中 ",uVar2,"天",0);
        }
        String.Concat(uVar3,uVar6,uVar2,0);
    }

    // Token : 0x6000F97
    // RVA   : 0x520230   Offset: 0x51F030   Length: 0x34
    public void /*ctor*/(int _areaID, int _roadLv)
    {
        ZhSegment.Initialize(this,0);
        this.areaID = _areaID;
        this.roadLv = _roadLv;
    }

    // Token : 0x6000F98
    // RVA   : 0x51F870   Offset: 0x51E670   Length: 0x175
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
