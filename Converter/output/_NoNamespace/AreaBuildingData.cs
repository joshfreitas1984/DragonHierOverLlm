// ============================================================
// Type  : AreaBuildingData
// Token : 0x20001E9
// ============================================================

public class AreaBuildingData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000D38
    public int buildingID;

    // Token: 0x4000D39
    public int lv;

    // Token: 0x4000D3A
    public int buildTimeLeft;

    // Token: 0x4000D3B
    public int upgradeTimeLeft;

    // Token: 0x4000D3C
    public int destroyTimeLeft;

    // Token: 0x4000D3D
    public bool noCancel;

    // Token: 0x4000D3E
    public ItemListData shopItemList;

    // Token: 0x4000D3F
    public List<MissionData> missionDatas;

    // Token: 0x4000D40
    public float produceRate;

    // Token: 0x4000D41
    public float resourceStoreRate;

    // Token: 0x4000D42
    public int areaID;

    // Token: 0x4000D43
    public int belongHeroID;

    // Token: 0x4000D44
    public int missionNumCount;

    // Token: 0x4000D45
    public int plotNumCount;

    // Token: 0x4000D46
    public int enemyMonth;

    // Token: 0x4000D47
    public static float SelfHouseTotalAddPerLv;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000F28
    // RVA   : 0xA18C00   Offset: 0xA17400   Length: 0x1C
    public void /*ctor*/()
    {
        ulong uVar1;
        this.produceRate = 0x3f800000;
        this.resourceStoreRate = 0x3f800000;
        this.belongHeroID = 0xffffffff;
        ZhSegment.Initialize(this,0);
        this.areaID = param_2;
        this.shopItemList = new ItemListData(0);
        uVar1 = il2cpp_internal(DAT_181d6feb0);
        FUN_180f58a90(uVar1,DAT_181d6d0e8);
        this.missionDatas = uVar1;
        this.resourceStoreRate = (float)this.lv * 0.2 + 1.0;
    }

    // Token : 0x6000F29
    // RVA   : 0xA18C20   Offset: 0xA17420   Length: 0x102
    public void /*ctor*/(int _buildingID, int _lv, int _areaID)
    {
        ulong uVar1;
        this.produceRate = 0x3f800000;
        this.resourceStoreRate = 0x3f800000;
        this.belongHeroID = 0xffffffff;
        ZhSegment.Initialize(this,0);
        this.areaID = _buildingID;
        this.shopItemList = new ItemListData(0);
        uVar1 = il2cpp_internal(DAT_181d6feb0);
        FUN_180f58a90(uVar1,DAT_181d6d0e8);
        this.missionDatas = uVar1;
        this.resourceStoreRate = (float)this.lv * 0.2 + 1.0;
    }

    // Token : 0x6000F2A
    // RVA   : 0xA18D30   Offset: 0xA17530   Length: 0xE2
    public void /*ctor*/(int _areaID)
    {
        ulong uVar1;
        this.produceRate = 0x3f800000;
        this.resourceStoreRate = 0x3f800000;
        this.belongHeroID = 0xffffffff;
        ZhSegment.Initialize(this,0);
        this.areaID = _areaID;
        this.shopItemList = new ItemListData(0);
        uVar1 = il2cpp_internal(DAT_181d6feb0);
        FUN_180f58a90(uVar1,DAT_181d6d0e8);
        this.missionDatas = uVar1;
        this.resourceStoreRate = (float)this.lv * 0.2 + 1.0;
    }

    // Token : 0x6000F2B
    // RVA   : 0xA17A70   Offset: 0xA16270   Length: 0x20
    public int GetStealItemMaxLv()
    {
        Mathf.Max(0,~(int)((float)this.lv * -0.5),0);
    }

    // Token : 0x6000F2C
    // RVA   : 0xA16590   Offset: 0xA14D90   Length: 0x16E
    public void ChangeEnemyMonth(int num)
    {
        var pStatics = *(int64*)(DAT_181d87630 + 184);
        long lVar1;
        this.enemyMonth = this.enemyMonth + num;
        lVar1 = *(int64 *)(pStatics + 56);
        if (lVar1 != null) {
          if (*(int64 *)(lVar1 + 88) != 0) {
            lVar1 = *(int64 *)(pStatics + 56);
            if ((lVar1 == null) || (lVar1 = *(int64 *)(lVar1 + 88)) == null) throw; // [null/range check failed]
            if (*(int *)(lVar1 + 16) == this.areaID) {
              lVar1 = FUN_18046bac0(0);
              if (lVar1 == null) throw; // [null/range check failed]
              *(uint8 *)(lVar1 + 224) = 1;
            }
          }
          return;
        }
    }

    // Token : 0x6000F2D
    // RVA   : 0xA17740   Offset: 0xA15F40   Length: 0x50
    public float GetExtraPartyScore()
    {
        long lVar1;
        lVar1 = AreaBuildingData.DataBase(this,0);
        if (lVar1 == null) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        if (*(int *)(lVar1 + 48) == 6) {
          return (float)(this.lv * 100) + 500.0;
        }
        return (float)this.lv * 50.0;
    }

    // Token : 0x6000F2E
    // RVA   : 0xA176F0   Offset: 0xA15EF0   Length: 0x4C
    public float GetExtraPartyRate()
    {
        long lVar1;
        lVar1 = AreaBuildingData.DataBase(this,0);
        if (lVar1 == null) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        if (*(int *)(lVar1 + 48) == 6) {
          return (float)this.lv * 0.1 + 0.5;
        }
        return (float)this.lv * 0.05;
    }

    // Token : 0x6000F2F
    // RVA   : 0xA179F0   Offset: 0xA161F0   Length: 0x6
    public float GetResourceProduceRate()
    {
        uint32 FUN_180a179f0(int64 this)
        {
        return this.resourceStoreRate;
    }

    // Token : 0x6000F30
    // RVA   : 0xA177A0   Offset: 0xA15FA0   Length: 0x19
    public float GetMaxResourceRate()
    {
        float FUN_180a177a0(int64 this)
        {
        return (float)this.lv * 0.2 + 1.0;
    }

    // Token : 0x6000F31
    // RVA   : 0xA15C60   Offset: 0xA14460   Length: 0xDE
    public void AutoManageResourceRate()
    {
        uint uVar1;
        float fVar2;
        fVar2 = (((float)this.lv * 0.2 + 1.0) - this.resourceStoreRate) * 0.5;
        if (fVar2 != 0.0) {
          if (fVar2 <= 0.0) {
            fVar2 = (float)Mathf.Min(0xbdcccccd);
            uVar1 = Mathf.Max(this.resourceStoreRate + fVar2,
                               (float)this.lv * 0.2 + 1.0,0);
            this.resourceStoreRate = uVar1;
            return;
          }
          fVar2 = (float)Mathf.Max(0x3dcccccd,fVar2,0);
          uVar1 = FUN_1810a8ba0(this.resourceStoreRate + fVar2);
          this.resourceStoreRate = uVar1;
        }
    }

    // Token : 0x6000F32
    // RVA   : 0xA18BA0   Offset: 0xA173A0   Length: 0x1E
    public void ResetResourceStoreRate()
    {
        void FUN_180a18ba0(int64 this)
        {
        this.resourceStoreRate = (float)this.lv * 0.2 + 1.0;
    }

    // Token : 0x6000F33
    // RVA   : 0xA18AE0   Offset: 0xA172E0   Length: 0xBE
    public string Name(bool withLv)
    {
        uint uVar1;
        ulong uVar2;
        long lVar3;
        uVar2 = "";
        if (withLv) {
          uVar1 = this.lv;
          uVar2 = GlobalData.GetNumText(uVar1,0);
          uVar2 = String.Format("{0}级",uVar2,0);
        }
        lVar3 = AreaBuildingData.DataBase(this,0);
        if (lVar3 == null) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        String.Concat(uVar2,*(uint64 *)(lVar3 + 24),0);
    }

    // Token : 0x6000F34
    // RVA   : 0xA16A60   Offset: 0xA15260   Length: 0xE4
    public AreaBuildingDataBase DataBase()
    {
        long lVar1;
        ulong uVar2;
        if (this.buildingID < 0) {
          return 0;
        }
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d4e010 + 184) + 32);
        if ((lVar1 != null) && (lVar1 = *(int64 *)(lVar1 + 224)) != null) {
          uVar2 = FUN_1817cc780(lVar1,this.buildingID,DAT_181d925f0);
          return uVar2;
        }
    }

    // Token : 0x6000F35
    // RVA   : 0xA15D40   Offset: 0xA14540   Length: 0x8
    public bool BuildingAvailable()
    {
        return this.enemyMonth < 1;
    }

    // Token : 0x6000F36
    // RVA   : 0xA17470   Offset: 0xA15C70   Length: 0x98
    public int GetBuyMoney()
    {
        int iVar1;
        long lVar2;
        lVar2 = AreaBuildingData.DataBase(this,0);
        if ((lVar2 != null) && (lVar2 = *(int64 *)(lVar2 + 80)) != null) {
          if (*(int *)(lVar2 + 24) == 0) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          iVar1 = Mathf.RoundToInt((float)(this.lv + 1) *
                                    *(float *)(*(int64 *)(lVar2 + 16) + 32) * 0.5 *
                                    (float)this.lv,0);
          return iVar1 + 5000;
        }
    }

    // Token : 0x6000F37
    // RVA   : 0xA17A00   Offset: 0xA16200   Length: 0x6E
    public float GetSelfHouseTotalAdd()
    {
        return (float)this.lv * **(float **)(DAT_181d87438 + 184) + 1.0;
    }

    // Token : 0x6000F38
    // RVA   : 0xA16700   Offset: 0xA14F00   Length: 0x1DE
    public void ChangeResourceRate(float result, bool showInfo)
    {
        float fVar1;
        long lVar2;
        long lVar3;
        ulong uVar4;
        ulong uVar5;
        float fVar6;
        float[] local_res18 = new float[4];
        ulong local_48;
        ulong uStack_40;
        fVar1 = this.resourceStoreRate;
        fVar6 = (float)this.lv * 0.2 + 1.0;
        if (fVar6 <= fVar1) {
          result = result / ((fVar1 - fVar6) * 5.0 + 1.0);
        }
        this.resourceStoreRate = fVar1 + result;
        if (!showInfo) {
          return;
        }
        lVar2 = **(int64 **)(DAT_181d5a578 + 184);
        lVar3 = AreaBuildingData.DataBase(this,0);
        if (lVar3 != null) {
          uVar5 = *(uint64 *)(lVar3 + 24);
          local_res18[0] = result * 100.0;
          uVar4 = Single.ToString(local_res18,"f0",0);
          uVar4 = String.Concat(uVar4,"%",0);
          uVar5 = String.Format("{0}资源储量增加了{1}",uVar5,uVar4,0);
          if (lVar2 != null) {
            local_48 = 0;
            uStack_40 = 0;
            InfoController.AddInfoTab
                      (lVar2,uVar5,"UIAtlas","从事工作_探索","Woosh",0x3f800000,0x40a00000,
                       &local_48,0);
            return;
          }
        }
    }

    // Token : 0x6000F39
    // RVA   : 0xA16B50   Offset: 0xA15350   Length: 0x2D
    public List<AreaBuildingRateChange> GetAreaBuildingRateChange()
    {
        long lVar1;
        lVar1 = AreaBuildingData.DataBase(this,0);
        if (lVar1 != null) {
          AreaBuildingDataBase.GetAreaBuildingRateChange(lVar1,this.lv,0);
          return;
        }
    }

    // Token : 0x6000F3A
    // RVA   : 0xA17070   Offset: 0xA15870   Length: 0x2D
    public ForceSpeAddData GetBuildingSpeAddData()
    {
        long lVar1;
        lVar1 = AreaBuildingData.DataBase(this,0);
        if (lVar1 != null) {
          AreaBuildingDataBase.GetBuildingSpeAddData(lVar1,this.lv,0);
          return;
        }
    }

    // Token : 0x6000F3B
    // RVA   : 0xA175B0   Offset: 0xA15DB0   Length: 0x31
    public float GetChangeMaxPeople()
    {
        long lVar1;
        lVar1 = AreaBuildingData.DataBase(this,0);
        if (lVar1 != null) {
          return (float)(this.lv + 1) * *(float *)(lVar1 + 92);
        }
    }

    // Token : 0x6000F3C
    // RVA   : 0xA17560   Offset: 0xA15D60   Length: 0x47
    public float GetChangeAreaState(AreaStateType areaStateType)
    {
        long lVar1;
        lVar1 = AreaBuildingData.DataBase(this,0);
        if (lVar1 != null) {
          AreaBuildingDataBase.GetChangeAreaState
                    (lVar1,areaStateType,this.lv,this.produceRate,0);
          return;
        }
    }

    // Token : 0x6000F3D
    // RVA   : 0xA17510   Offset: 0xA15D10   Length: 0x47
    public float GetChangeAllAreaState(AreaStateType areaStateType)
    {
        long lVar1;
        lVar1 = AreaBuildingData.DataBase(this,0);
        if (lVar1 != null) {
          AreaBuildingDataBase.GetChangeAllAreaState
                    (lVar1,areaStateType,this.lv,this.produceRate,0);
          return;
        }
    }

    // Token : 0x6000F3E
    // RVA   : 0xA17A90   Offset: 0xA16290   Length: 0x32
    public List<float> GetTotalChangeResource()
    {
        long lVar1;
        lVar1 = AreaBuildingData.DataBase(this,0);
        if (lVar1 != null) {
          AreaBuildingDataBase.GetTotalChangeResource
                    (lVar1,this.lv,this.produceRate,0);
          return;
        }
    }

    // Token : 0x6000F3F
    // RVA   : 0xA17AD0   Offset: 0xA162D0   Length: 0xEA
    public List<float> GetUpgradeCostResource(float rate)
    {
        long lVar1;
        ulong uVar2;
        lVar1 = AreaBuildingData.DataBase(this,0);
        if (lVar1 != null) {
          uVar2 = *(uint64 *)(lVar1 + 80);
          uVar2 = GlobalData.ListMulti(uVar2);
          GlobalData.ListMulti(uVar2);
          return;
        }
    }

    // Token : 0x6000F40
    // RVA   : 0xA178B0   Offset: 0xA160B0   Length: 0x13B
    public List<float> GetObstacleRemoveCostResource(float rate)
    {
        long lVar1;
        float fVar2;
        lVar1 = il2cpp_internal(DAT_181d721b0);
        FUN_180f58a90(lVar1,DAT_181d79358);
        if (lVar1 != null) {
          FUN_181805690(lVar1,0,DAT_181d79458);
          FUN_181805690(lVar1,0,DAT_181d79458);
          FUN_181805690(lVar1,0,DAT_181d79458);
          FUN_181805690(lVar1,0,DAT_181d79458);
          FUN_181805690(lVar1,0,DAT_181d79458);
          FUN_181805690(lVar1,0,DAT_181d79458);
          fVar2 = (float)Mathf.Max();
          FUN_181814d10(lVar1,1,fVar2 * 500.0 * rate,DAT_181d79758);
          return lVar1;
        }
    }

    // Token : 0x6000F41
    // RVA   : 0xA17060   Offset: 0xA15860   Length: 0xA
    public int GetBuildingCureSkill()
    {
        return (this.lv + 5) * 5;
    }

    // Token : 0x6000F42
    // RVA   : 0xA17050   Offset: 0xA15850   Length: 0xC
    public int GetBuildingCureCost()
    {
        return (this.lv + 5) * 10;
    }

    // Token : 0x6000F43
    // RVA   : 0xA18A70   Offset: 0xA17270   Length: 0x6E
    public int GetUpgradeTime()
    {
        float fVar1;
        int iVar2;
        uint uVar3;
        long lVar4;
        float fVar5;
        iVar2 = this.lv;
        lVar4 = AreaBuildingData.DataBase(this,0);
        if (lVar4 != null) {
          fVar1 = *(float *)(lVar4 + 88);
          fVar5 = (float)AreaBuildingData.GetBuildSpeedRate(this,0);
          uVar3 = Mathf.RoundToInt(((float)(iVar2 + 1) * fVar1) / fVar5,0);
          Mathf.Max(1,uVar3);
          return;
        }
    }

    // Token : 0x6000F44
    // RVA   : 0xA17660   Offset: 0xA15E60   Length: 0x88
    public int GetDestroyTime()
    {
        int iVar1;
        uint uVar2;
        long lVar3;
        float fVar4;
        float fVar5;
        iVar1 = this.lv;
        if (this.buildingID < 0) {
          fVar5 = 10.0;
        }
        else {
          lVar3 = AreaBuildingData.DataBase(this,0);
          if (lVar3 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          fVar5 = *(float *)(lVar3 + 88);
        }
        fVar4 = (float)AreaBuildingData.GetBuildSpeedRate(this,0);
        uVar2 = Mathf.RoundToInt(((float)(iVar1 + 1) * fVar5) / fVar4,0);
        Mathf.Max(1,uVar2);
    }

    // Token : 0x6000F45
    // RVA   : 0xA16FF0   Offset: 0xA157F0   Length: 0x54
    public int GetBuildTime()
    {
        float fVar1;
        uint uVar2;
        long lVar3;
        float fVar4;
        lVar3 = AreaBuildingData.DataBase(this,0);
        if (lVar3 != null) {
          fVar1 = *(float *)(lVar3 + 88);
          fVar4 = (float)AreaBuildingData.GetBuildSpeedRate(this,0);
          uVar2 = Mathf.RoundToInt(fVar1 / fVar4,0);
          Mathf.Max(1,uVar2);
          return;
        }
    }

    // Token : 0x6000F46
    // RVA   : 0xA17830   Offset: 0xA16030   Length: 0x76
    public int GetMoveTime()
    {
        float fVar1;
        int iVar2;
        uint uVar3;
        long lVar4;
        float fVar5;
        iVar2 = this.lv;
        lVar4 = AreaBuildingData.DataBase(this,0);
        if (lVar4 != null) {
          fVar1 = *(float *)(lVar4 + 88);
          fVar5 = (float)AreaBuildingData.GetBuildSpeedRate(this,0);
          uVar3 = Mathf.RoundToInt(((float)(iVar2 + 1) * fVar1 * 0.5) / fVar5,0);
          Mathf.Max(1,uVar3);
          return;
        }
    }

    // Token : 0x6000F47
    // RVA   : 0xA16E10   Offset: 0xA15610   Length: 0x1D8
    public float GetBuildSpeedRate()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        int iVar1;
        long lVar2;
        float fVar3;
        float fVar4;
        lVar2 = AreaBuildingData.GetArea(this,0);
        if ((lVar2 != null) && (*(int64 *)(lVar2 + 176) != 0)) {
          fVar3 = (float)ForceSpeAddData.Get(*(int64 *)(lVar2 + 176),13);
          lVar2 = AreaBuildingData.GetArea(this,0);
          if (lVar2 != null) {
            if (*(int *)(lVar2 + 112) < 0) {
              return fVar3 + 1.0;
            }
            lVar2 = AreaBuildingData.GetArea(this,0);
            if (((lVar2 != null) && (lVar2 = AreaData.GetForce(lVar2,0)) != null) &&
               (*(int64 *)(lVar2 + 0x148) != 0)) {
              fVar4 = (float)ForceSpeAddData.Get(*(int64 *)(lVar2 + 0x148),12);
              fVar4 = fVar3 + 1.0 + fVar4;
              if (((*pStatics != 0) &&
                  (lVar2 = *(int64 *)(*pStatics + 32)) != null) &&
                 (lVar2 = WorldData.Player(lVar2,0)) != null) {
                iVar1 = *(int *)(lVar2 + 132);
                lVar2 = AreaBuildingData.GetArea(this,0);
                if (lVar2 != null) {
                  if (iVar1 != *(int *)(lVar2 + 112)) {
                    lVar2 = FUN_18046c0a0(0);
                    if ((lVar2 == null) || (*(int64 *)(lVar2 + 32) == 0)) throw; // [null/range check failed]
                    fVar3 = (float)WorldData.GetAIForceDevelopSpeed(*(int64 *)(lVar2 + 32),0);
                    fVar4 = fVar4 + fVar3 * 0.05;
                  }
                  return fVar4;
                }
              }
            }
          }
        }
    }

    // Token : 0x6000F48
    // RVA   : 0xA16B80   Offset: 0xA15380   Length: 0xBE
    public AreaData GetArea()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        long lVar1;
        if ((*pStatics != 0) &&
           (lVar1 = *(int64 *)(*pStatics + 32)) != null) {
          WorldData.GetArea(lVar1,this.areaID,0);
          return;
        }
    }

    // Token : 0x6000F49
    // RVA   : 0xA15D50   Offset: 0xA14550   Length: 0x837
    public bool CanUpgrade()
    {
        var pStatics_7630 = *(int64*)(DAT_181d87630 + 184);
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        var pStatics_ef00 = *(int64*)(DAT_181d4ef00 + 184);
        float fVar1;
        uint uVar2;
        int iVar3;
        long lVar4;
        long lVar5;
        ulong uVar6;
        ulong uVar7;
        lVar4 = *(int64 *)(pStatics_7630 + 56);
        if ((lVar4 == null) || (lVar4 = *(int64 *)(lVar4 + 88)) == null) throw; // [null/range check failed]
        lVar4 = AreaData.GetCenterBuilding(lVar4,0);
        if (this == lVar4) {
          lVar4 = *(int64 *)(pStatics_7630 + 56);
          if ((lVar4 == null) || (lVar4 = *(int64 *)(lVar4 + 88)) == null) throw; // [null/range check failed]
          if (*(int *)(lVar4 + 72) != 0) {
            lVar4 = FUN_18046bac0(0);
            if ((lVar4 == null) || (*(int64 *)(lVar4 + 88) == 0)) throw; // [null/range check failed]
            if (*(int *)(*(int64 *)(lVar4 + 88) + 72) != 1) goto LAB_180a16088;
          }
          lVar4 = *(int64 *)(pStatics_7630 + 56);
          if ((lVar4 == null) || (lVar4 = *(int64 *)(lVar4 + 88)) == null) throw; // [null/range check failed]
          fVar1 = *(float *)(lVar4 + 80);
          lVar4 = *(int64 *)(pStatics_ef00 + 0x668);
          lVar5 = *(int64 *)(pStatics_7630 + 56);
          if ((((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 88)) == null) ||
              (lVar5 = AreaData.GetCenterBuilding(lVar5,0)) == null) || (lVar4 == null))
          throw; // [null/range check failed]
          uVar2 = *(uint32 *)(lVar5 + 20);
          if (*(uint32 *)(lVar4 + 24) <= uVar2) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          uVar6 = *(uint64 *)(lVar4 + 16);
          if (fVar1 < uVar6[uVar2]) goto LAB_180a1657e;
        }
        LAB_180a16088:
        lVar4 = *(int64 *)(pStatics_7630 + 56);
        if ((lVar4 == null) || (lVar4 = *(int64 *)(lVar4 + 88)) == null) throw; // [null/range check failed]
        lVar4 = AreaData.GetCenterBuilding(lVar4,0);
        if (this == lVar4) {
          lVar4 = *(int64 *)(pStatics_7630 + 56);
          if ((lVar4 == null) || (lVar4 = *(int64 *)(lVar4 + 88)) == null) throw; // [null/range check failed]
          if (*(int *)(lVar4 + 72) == 2) {
            lVar4 = FUN_18046bac0(0);
            if (((lVar4 == null) || (*(int64 *)(lVar4 + 88) == 0)) ||
               (lVar4 = AreaData.GetForce(*(int64 *)(lVar4 + 88),0)) == null)
            throw; // [null/range check failed]
            iVar3 = *(int *)(lVar4 + 132);
            lVar4 = *(int64 *)(pStatics_ef00 + 0x670);
            lVar5 = *(int64 *)(pStatics_7630 + 56);
            if ((((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 88)) == null) ||
                (lVar5 = AreaData.GetCenterBuilding(lVar5,0)) == null) || (lVar4 == null))
            throw; // [null/range check failed]
            uVar2 = *(uint32 *)(lVar5 + 20);
            if (*(uint32 *)(lVar4 + 24) <= uVar2) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            uVar6 = *(uint64 *)(lVar4 + 16);
            if ((float)iVar3 < uVar6[uVar2]) goto LAB_180a1657e;
          }
        }
        lVar4 = *(int64 *)(pStatics_7630 + 56);
        if ((lVar4 != null) && (lVar4 = *(int64 *)(lVar4 + 88)) != null) {
          lVar4 = AreaData.GetCenterBuilding(lVar4,0);
          if (this != lVar4) {
            iVar3 = this.lv;
            lVar4 = *(int64 *)(pStatics_7630 + 56);
            if (((lVar4 == null) || (lVar4 = *(int64 *)(lVar4 + 88)) == null) ||
               (uVar6 = AreaData.GetCenterBuilding(lVar4,0)) == null) throw; // [null/range check failed]
            if (*(int *)(uVar6 + 20) <= iVar3) goto LAB_180a1657e;
          }
          if ((*pStatics_df90 != 0) &&
             (lVar4 = *(int64 *)(*pStatics_df90 + 32)) != null) {
            lVar4 = WorldData.GetHeroForce(lVar4,0,0);
            uVar7 = AreaBuildingData.GetUpgradeCostResource(this);
            if (lVar4 != null) {
              uVar6 = ForceData.HaveResource(lVar4,uVar7,0);
              if ((char)uVar6) {
                lVar4 = FUN_18046c0a0(0);
                if (((lVar4 == null) || (*(int64 *)(lVar4 + 32) == 0)) ||
                   (lVar4 = WorldData.Player(*(int64 *)(lVar4 + 32),0)) == null)
                throw; // [null/range check failed]
                iVar3 = *(int *)(lVar4 + 184);
                uVar6 = *(uint64 *)(DAT_181d87338 + 184);
                if (*(int *)(uVar6 + 24) <= iVar3) {
                  return CONCAT71((int7)(uVar6 >> 8),1);
                }
              }
        LAB_180a1657e:
              return uVar6 & 0xffffffffffffff00;
            }
          }
        }
    }

    // Token : 0x6000F4A
    // RVA   : 0xA17CE0   Offset: 0xA164E0   Length: 0xD8B
    public string GetUpgradeDescribe()
    {
        var pStatics_7338 = *(int64*)(DAT_181d87338 + 184);
        var pStatics_7630 = *(int64*)(DAT_181d87630 + 184);
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        var pStatics_ef00 = *(int64*)(DAT_181d4ef00 + 184);
        float fVar1;
        uint uVar2;
        int iVar3;
        uint uVar4;
        long lVar5;
        long lVar6;
        ulong uVar7;
        ulong uVar8;
        ulong uVar9;
        ulong uVar10;
        float fVar11;
        uint[] local_res18 = new uint[2];
        uint[] local_res20 = new uint[2];
        int local_38;
        uint[] local_34 = new uint[7];
        uVar9 = "";
        lVar5 = *(int64 *)(pStatics_7630 + 56);
        if ((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 88)) == null) throw; // [null/range check failed]
        lVar5 = AreaData.GetCenterBuilding(lVar5,0);
        if (this == lVar5) {
          lVar5 = *(int64 *)(pStatics_7630 + 56);
          if ((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 88)) == null) throw; // [null/range check failed]
          if (*(int *)(lVar5 + 72) != 0) {
            lVar5 = FUN_18046bac0(0);
            if ((lVar5 == null) || (*(int64 *)(lVar5 + 88) == 0)) throw; // [null/range check failed]
            if (*(int *)(*(int64 *)(lVar5 + 88) + 72) != 1) goto LAB_180a181a8;
          }
          lVar5 = *(int64 *)(pStatics_7630 + 56);
          if ((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 88)) == null) throw; // [null/range check failed]
          fVar1 = *(float *)(lVar5 + 80);
          lVar5 = *(int64 *)(pStatics_ef00 + 0x668);
          lVar6 = *(int64 *)(pStatics_7630 + 56);
          if ((((lVar6 == null) || (lVar6 = *(int64 *)(lVar6 + 88)) == null) ||
              (lVar6 = AreaData.GetCenterBuilding(lVar6,0)) == null) || (lVar5 == null))
          throw; // [null/range check failed]
          uVar2 = *(uint32 *)(lVar6 + 20);
          if (*(uint32 *)(lVar5 + 24) <= uVar2) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          if (lVar5[uVar2] <= fVar1)
          goto LAB_180a181a8;
          uVar8 = *(uint64 *)(pStatics_ef00 + 0x2c8);
          lVar5 = *(int64 *)(pStatics_ef00 + 0x668);
          lVar6 = *(int64 *)(pStatics_7630 + 56);
          if ((((lVar6 == null) || (lVar6 = *(int64 *)(lVar6 + 88)) == null) ||
              (lVar6 = AreaData.GetCenterBuilding(lVar6,0)) == null) || (lVar5 == null)) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          uVar2 = *(uint32 *)(lVar6 + 20);
          if (*(uint32 *)(lVar5 + 24) <= uVar2) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          local_res18[0] = lVar5[uVar2];
          uVar7 = il2cpp_value_box(DAT_181d7d0b8,local_res18);
          uVar10 = "需要\n{0}人口 {1}</color>\n\n";
        LAB_180a1877d:
          uVar8 = String.Format(uVar10,uVar8,uVar7,0);
          uVar9 = String.Concat(uVar9,uVar8,0);
        }
        else {
        LAB_180a181a8:
          lVar5 = *(int64 *)(pStatics_7630 + 56);
          if ((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 88)) == null) throw; // [null/range check failed]
          lVar5 = AreaData.GetCenterBuilding(lVar5,0);
          if (this == lVar5) {
            lVar5 = *(int64 *)(pStatics_7630 + 56);
            if ((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 88)) == null) throw; // [null/range check failed]
            if (*(int *)(lVar5 + 72) == 2) {
              lVar5 = FUN_18046bac0(0);
              if (((lVar5 == null) || (*(int64 *)(lVar5 + 88) == 0)) ||
                 (lVar5 = AreaData.GetForce(*(int64 *)(lVar5 + 88),0)) == null)
              throw; // [null/range check failed]
              iVar3 = *(int *)(lVar5 + 132);
              lVar5 = *(int64 *)(pStatics_ef00 + 0x670);
              lVar6 = *(int64 *)(pStatics_7630 + 56);
              if ((((lVar6 == null) || (lVar6 = *(int64 *)(lVar6 + 88)) == null) ||
                  (lVar6 = AreaData.GetCenterBuilding(lVar6,0)) == null) || (lVar5 == null))
              throw; // [null/range check failed]
              uVar2 = *(uint32 *)(lVar6 + 20);
              if (*(uint32 *)(lVar5 + 24) <= uVar2) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              if ((float)iVar3 < lVar5[uVar2]
                 ) {
                uVar8 = *(uint64 *)(pStatics_ef00 + 0x2c8);
                lVar5 = *(int64 *)(pStatics_ef00 + 0x670);
                lVar6 = *(int64 *)(pStatics_7630 + 56);
                if ((((lVar6 == null) || (lVar6 = *(int64 *)(lVar6 + 88)) == null) ||
                    (lVar6 = AreaData.GetCenterBuilding(lVar6,0)) == null) || (lVar5 == null)) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                uVar2 = *(uint32 *)(lVar6 + 20);
                if (*(uint32 *)(lVar5 + 24) <= uVar2) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                local_res20[0] =
                     lVar5[uVar2];
                uVar7 = il2cpp_value_box(DAT_181d7d0b8,local_res20);
                uVar10 = "需要\n{0}弟子 {1}</color>\n\n";
                goto LAB_180a1877d;
              }
            }
          }
          lVar5 = *(int64 *)(pStatics_7630 + 56);
          if ((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 88)) == null) throw; // [null/range check failed]
          lVar5 = AreaData.GetCenterBuilding(lVar5,0);
          if (this != lVar5) {
            iVar3 = this.lv;
            lVar5 = *(int64 *)(pStatics_7630 + 56);
            if (((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 88)) == null) ||
               (lVar5 = AreaData.GetCenterBuilding(lVar5,0)) == null) throw; // [null/range check failed]
            if (*(int *)(lVar5 + 20) <= iVar3) {
              uVar8 = *(uint64 *)(pStatics_ef00 + 0x2c8);
              lVar5 = *(int64 *)(pStatics_7630 + 56);
              if ((((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 88)) == null) ||
                  (lVar5 = AreaData.GetCenterBuilding(lVar5,0)) == null) ||
                 (lVar5 = AreaBuildingData.DataBase(lVar5,0)) == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              uVar8 = String.Concat(uVar8,*(uint64 *)(lVar5 + 24),0);
              local_38 = this.lv + 1;
              uVar7 = il2cpp_value_box(DAT_181d5b2f8,&local_38);
              uVar10 = "需要\n{0} {1}级</color>\n\n";
              goto LAB_180a1877d;
            }
          }
        }
        if (((*pStatics_df90 != 0) &&
            (lVar5 = *(int64 *)(*pStatics_df90 + 32)) != null) &&
           (lVar5 = WorldData.Player(lVar5,0)) != null) {
          iVar3 = *(int *)(lVar5 + 184);
          if (iVar3 < *(int *)(pStatics_7338 + 24)) {
            lVar5 = *(int64 *)(pStatics_ef00 + 0x3d0);
            uVar2 = *(uint32 *)(pStatics_7338 + 24);
            if (lVar5 == null) throw; // [null/range check failed]
            if (*(uint32 *)(lVar5 + 24) <= uVar2) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            uVar8 = GlobalData.GenerateRareLvColorText
                              (*(uint64 *)
                                (*(int64 *)(lVar5 + 16) + 32 + (int64)(int)uVar2 * 8),
                               *(uint32 *)(pStatics_7338 + 24),0);
            uVar8 = String.Format("需要 {0}\n\n",uVar8,0);
            uVar9 = String.Concat(uVar8,uVar9,0);
          }
          iVar3 = this.lv;
          lVar5 = AreaBuildingData.DataBase(this,0);
          if (lVar5 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          fVar1 = *(float *)(lVar5 + 88);
          fVar11 = (float)AreaBuildingData.GetBuildSpeedRate(this,0);
          uVar4 = Mathf.RoundToInt(((float)(iVar3 + 1) * fVar1) / fVar11,0);
          local_34[0] = Mathf.Max(1,uVar4);
          uVar8 = il2cpp_value_box(DAT_181d5b2f8,local_34);
          uVar10 = AreaBuildingData.GetUpgradeCostResource(this);
          uVar10 = GlobalData.GetResourceDescribe(uVar10,0);
          uVar8 = String.Format("消耗 ({0}天)\n{1}",uVar8,uVar10,0);
          String.Concat(uVar9,uVar8,0);
          return;
        }
    }

    // Token : 0x6000F4B
    // RVA   : 0xA175F0   Offset: 0xA15DF0   Length: 0x68
    public string GetDestroyCostText()
    {
        ulong uVar1;
        uint[] local_res18 = new uint[4];
        local_res18[0] = AreaBuildingData.GetDestroyTime(this,0);
        uVar1 = il2cpp_value_box(DAT_181d5b2f8,local_res18);
        String.Format("消耗 ({0}天)",uVar1,0);
    }

    // Token : 0x6000F4C
    // RVA   : 0xA17BC0   Offset: 0xA163C0   Length: 0x115
    public string GetUpgradeCostText()
    {
        float fVar1;
        int iVar2;
        uint uVar3;
        long lVar4;
        ulong uVar5;
        ulong uVar6;
        float fVar7;
        uint[] local_res8 = new uint[2];
        iVar2 = this.lv;
        lVar4 = AreaBuildingData.DataBase(this,0);
        if (lVar4 != null) {
          fVar1 = *(float *)(lVar4 + 88);
          fVar7 = (float)AreaBuildingData.GetBuildSpeedRate(this,0);
          uVar3 = Mathf.RoundToInt(((float)(iVar2 + 1) * fVar1) / fVar7,0);
          local_res8[0] = Mathf.Max(1,uVar3);
          uVar5 = il2cpp_value_box(DAT_181d5b2f8,local_res8);
          uVar6 = AreaBuildingData.GetUpgradeCostResource(this);
          uVar6 = GlobalData.GetResourceDescribe(uVar6,0);
          String.Format("消耗 ({0}天)\n{1}",uVar5,uVar6,0);
          return;
        }
    }

    // Token : 0x6000F4D
    // RVA   : 0xA177C0   Offset: 0xA15FC0   Length: 0x68
    public string GetMoveCostText()
    {
        ulong uVar1;
        uint[] local_res18 = new uint[4];
        local_res18[0] = AreaBuildingData.GetMoveTime(this,0);
        uVar1 = il2cpp_value_box(DAT_181d5b2f8,local_res18);
        String.Format("消耗 ({0}天)",uVar1,0);
    }

    // Token : 0x6000F4E
    // RVA   : 0xA170A0   Offset: 0xA158A0   Length: 0x3C6
    public string GetBuildingText(bool showBuildingName, bool detail, bool showBuildTime)
    {
        uint64
        AreaBuildingData.GetBuildingText
                (int64 this,uint8 showBuildingName,uint8 detail,char showBuildTime)
        {
        uint32 uVar1;
        uint32 uVar2;
        uint32 uVar3;
        int64 lVar4;
        uint64 uVar5;
        uint64 uVar6;
        uint64 uVar7;
        float local_res8 [2];
        uint64 in_stack_ffffffffffffffa8;
        uint32 uVar8;
        uVar8 = (uint32)((uint64)in_stack_ffffffffffffffa8 >> 32);
        if (this.buildingID != -1) {
          lVar4 = AreaBuildingData.DataBase(this,0);
          uVar2 = this.lv;
          uVar1 = this.produceRate;
          uVar5 = AreaBuildingData.GetArea(this,0);
          if (lVar4 != null) {
            uVar5 = AreaBuildingDataBase.GetBuildingText
                              (lVar4,uVar2,detail,0,CONCAT44(uVar8,uVar1),showBuildingName,uVar5,0);
            local_res8[0] = this.produceRate * 100.0;
            uVar6 = Single.ToString(local_res8,"f0",0);
            uVar5 = String.Concat(uVar5,"\n\n生产效率\n",uVar6,"%",0);
            lVar4 = AreaBuildingData.DataBase(this,0);
            if (lVar4 != null) {
              if (*(int *)(lVar4 + 48) == 4) {
                local_res8[0] = this.resourceStoreRate * 100.0;
                uVar6 = Single.ToString(local_res8,"f0",0);
                local_res8[0] = ((float)this.lv * 0.2 + 1.0) * 100.0;
                uVar7 = Single.ToString(local_res8,"f0",0);
                uVar6 = String.Format("\n\n资源储量\n{0}%/{1}%",uVar6,uVar7,0);
                uVar5 = String.Concat(uVar5,uVar6,0);
              }
              goto LAB_180a17398;
            }
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        lVar4 = *(int64 *)(*(int64 *)(DAT_181d87338 + 184) + 8);
        uVar3 = Mathf.CeilToInt((float)this.lv * 0.5,0);
        if (lVar4 == null) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        if (*(uint32 *)(lVar4 + 24) <= uVar3) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        uVar5 = lVar4[uVar3];
        uVar8 = this.lv;
        uVar6 = GlobalData.GetNumText(uVar8,0);
        uVar5 = String.Format("<color=grey><size=17>{0} {1}级</size></color>",uVar5,uVar6,0);
        LAB_180a17398:
        if (showBuildTime) {
          if (0 < this.buildTimeLeft) {
            uVar6 = Int32.ToString(this + 24,0);
            uVar5 = String.Concat(uVar5,"\n\n建造中 ",uVar6,"天",0);
          }
          if (0 < this.upgradeTimeLeft) {
            uVar6 = Int32.ToString(this + 28,0);
            uVar5 = String.Concat(uVar5,"\n\n升级中 ",uVar6,"天",0);
          }
          if (0 < this.destroyTimeLeft) {
            uVar6 = Int32.ToString(this + 32,0);
            uVar5 = String.Concat(uVar5,"\n\n拆除中 ",uVar6,"天",0);
          }
        }
        return uVar5;
    }

    // Token : 0x6000F4F
    // RVA   : 0xA16C40   Offset: 0xA15440   Length: 0x1CA
    public string GetBuidlingDetailText(bool showBuildingName, bool detail)
    {
        uint64
        AreaBuildingData.GetBuidlingDetailText(int64 this,uint8 showBuildingName,uint8 detail)
        {
        uint32 uVar1;
        uint32 uVar2;
        int64 lVar3;
        uint64 uVar4;
        uint64 uVar5;
        uint64 uVar6;
        float local_res10 [2];
        uint64 in_stack_ffffffffffffffb8;
        uint32 uVar7;
        uVar7 = (uint32)((uint64)in_stack_ffffffffffffffb8 >> 32);
        lVar3 = AreaBuildingData.DataBase(this,0);
        uVar2 = this.lv;
        uVar1 = this.produceRate;
        uVar4 = AreaBuildingData.GetArea(this,0);
        if (lVar3 != null) {
          uVar4 = AreaBuildingDataBase.GetBuildingText
                            (lVar3,uVar2,detail,0,CONCAT44(uVar7,uVar1),showBuildingName,uVar4,0);
          local_res10[0] = this.produceRate * 100.0;
          uVar5 = Single.ToString(local_res10,"f0",0);
          uVar4 = String.Concat(uVar4,"\n\n生产效率\n",uVar5,"%",0);
          lVar3 = AreaBuildingData.DataBase(this,0);
          if (lVar3 != null) {
            if (*(int *)(lVar3 + 48) == 4) {
              local_res10[0] = this.resourceStoreRate * 100.0;
              uVar5 = Single.ToString(local_res10,"f0",0);
              local_res10[0] = ((float)this.lv * 0.2 + 1.0) * 100.0;
              uVar6 = Single.ToString(local_res10,"f0",0);
              uVar5 = String.Format("\n\n资源储量\n{0}%/{1}%",uVar5,uVar6,0);
              uVar4 = String.Concat(uVar4,uVar5,0);
            }
            return uVar4;
          }
        }
    }

    // Token : 0x6000F50
    // RVA   : 0xA168E0   Offset: 0xA150E0   Length: 0x175
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

    // Token : 0x6000F51
    // RVA   : 0xA18BC0   Offset: 0xA173C0   Length: 0x39
    private static void /*cctor*/()
    {
        **(uint32 **)(DAT_181d87438 + 184) = 0x3dcccccd;
    }

}
