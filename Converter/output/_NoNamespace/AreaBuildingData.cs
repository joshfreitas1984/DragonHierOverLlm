// ============================================================
// Type  : AreaBuildingData
// Token : 0x20001EF
// ============================================================

public class AreaBuildingData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000DC6
    public int buildingID;

    // Token: 0x4000DC7
    public int lv;

    // Token: 0x4000DC8
    public int buildTimeLeft;

    // Token: 0x4000DC9
    public int upgradeTimeLeft;

    // Token: 0x4000DCA
    public int destroyTimeLeft;

    // Token: 0x4000DCB
    public bool noCancel;

    // Token: 0x4000DCC
    public ItemListData shopItemList;

    // Token: 0x4000DCD
    public List<MissionData> missionDatas;

    // Token: 0x4000DCE
    public float produceRate;

    // Token: 0x4000DCF
    public float resourceStoreRate;

    // Token: 0x4000DD0
    public int areaID;

    // Token: 0x4000DD1
    public int belongHeroID;

    // Token: 0x4000DD2
    public int missionNumCount;

    // Token: 0x4000DD3
    public int plotNumCount;

    // Token: 0x4000DD4
    public int enemyMonth;

    // Token: 0x4000DD5
    public static float SelfHouseTotalAddPerLv;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000F5D
    // RVA   : 0xA2AE30   Offset: 0xA2A230   Length: 0x1C
    public void /*ctor*/()
    {
        ulong uVar1;
        this.produceRate = 0x3f800000;
        this.resourceStoreRate = 0x3f800000;
        this.belongHeroID = 0xffffffff;
        ZhSegment.Initialize(this,0);
        this.areaID = param_2;
        this.shopItemList = new ItemListData(0);
        uVar1 = il2cpp_internal(DAT_181d94b68);
        FUN_181330100(uVar1,DAT_181d948a0);
        this.missionDatas = uVar1;
        this.resourceStoreRate = (float)this.lv * 0.2 + 1.0;
    }

    // Token : 0x6000F5E
    // RVA   : 0xA2AE50   Offset: 0xA2A250   Length: 0x102
    public void /*ctor*/(int _buildingID, int _lv, int _areaID)
    {
        ulong uVar1;
        this.produceRate = 0x3f800000;
        this.resourceStoreRate = 0x3f800000;
        this.belongHeroID = 0xffffffff;
        ZhSegment.Initialize(this,0);
        this.areaID = _buildingID;
        this.shopItemList = new ItemListData(0);
        uVar1 = il2cpp_internal(DAT_181d94b68);
        FUN_181330100(uVar1,DAT_181d948a0);
        this.missionDatas = uVar1;
        this.resourceStoreRate = (float)this.lv * 0.2 + 1.0;
    }

    // Token : 0x6000F5F
    // RVA   : 0xA2AF60   Offset: 0xA2A360   Length: 0xE2
    public void /*ctor*/(int _areaID)
    {
        ulong uVar1;
        this.produceRate = 0x3f800000;
        this.resourceStoreRate = 0x3f800000;
        this.belongHeroID = 0xffffffff;
        ZhSegment.Initialize(this,0);
        this.areaID = _areaID;
        this.shopItemList = new ItemListData(0);
        uVar1 = il2cpp_internal(DAT_181d94b68);
        FUN_181330100(uVar1,DAT_181d948a0);
        this.missionDatas = uVar1;
        this.resourceStoreRate = (float)this.lv * 0.2 + 1.0;
    }

    // Token : 0x6000F60
    // RVA   : 0xA29CA0   Offset: 0xA290A0   Length: 0x20
    public int GetStealItemMaxLv()
    {
        Mathf.Max(0,~(int)((float)this.lv * -0.5),0);
    }

    // Token : 0x6000F61
    // RVA   : 0xA287B0   Offset: 0xA27BB0   Length: 0x16E
    public void ChangeEnemyMonth(int num)
    {
        long lVar1;
        this.enemyMonth = this.enemyMonth + num;
        lVar1 = PlotController.SpringFestivelRewardLvTalkText;
        if (lVar1 != null) {
          if (*(int64 *)(lVar1 + 88) != 0) {
            lVar1 = PlotController.SpringFestivelRewardLvTalkText;
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

    // Token : 0x6000F62
    // RVA   : 0xA29970   Offset: 0xA28D70   Length: 0x50
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

    // Token : 0x6000F63
    // RVA   : 0xA29920   Offset: 0xA28D20   Length: 0x4C
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

    // Token : 0x6000F64
    // RVA   : 0xA29C20   Offset: 0xA29020   Length: 0x6
    public float GetResourceProduceRate()
    {
        uint32 FUN_180a29c20(int64 this)
        {
        return this.resourceStoreRate;
    }

    // Token : 0x6000F65
    // RVA   : 0xA299D0   Offset: 0xA28DD0   Length: 0x19
    public float GetMaxResourceRate()
    {
        float FUN_180a299d0(int64 this)
        {
        return (float)this.lv * 0.2 + 1.0;
    }

    // Token : 0x6000F66
    // RVA   : 0xA27E80   Offset: 0xA27280   Length: 0xDE
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
          uVar1 = FUN_1810e3cd0(this.resourceStoreRate + fVar2);
          this.resourceStoreRate = uVar1;
        }
    }

    // Token : 0x6000F67
    // RVA   : 0xA2ADD0   Offset: 0xA2A1D0   Length: 0x1E
    public void ResetResourceStoreRate()
    {
        void FUN_180a2add0(int64 this)
        {
        this.resourceStoreRate = (float)this.lv * 0.2 + 1.0;
    }

    // Token : 0x6000F68
    // RVA   : 0xA2AD10   Offset: 0xA2A110   Length: 0xBE
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

    // Token : 0x6000F69
    // RVA   : 0xA28C80   Offset: 0xA28080   Length: 0xE4
    public AreaBuildingDataBase DataBase()
    {
        long lVar1;
        ulong uVar2;
        if (this.buildingID < 0) {
          return 0;
        }
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d72d50 + 184) + 32);
        if ((lVar1 != null) && (lVar1 = *(int64 *)(lVar1 + 224)) != null) {
          uVar2 = FUN_1817da420(lVar1,this.buildingID,DAT_181db7bf0);
          return uVar2;
        }
    }

    // Token : 0x6000F6A
    // RVA   : 0xA27F60   Offset: 0xA27360   Length: 0x8
    public bool BuildingAvailable()
    {
        return this.enemyMonth < 1;
    }

    // Token : 0x6000F6B
    // RVA   : 0xA296A0   Offset: 0xA28AA0   Length: 0x98
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

    // Token : 0x6000F6C
    // RVA   : 0xA29C30   Offset: 0xA29030   Length: 0x6E
    public float GetSelfHouseTotalAdd()
    {
        return (float)this.lv * **(float **)(DAT_181dac570 + 184) + 1.0;
    }

    // Token : 0x6000F6D
    // RVA   : 0xA28920   Offset: 0xA27D20   Length: 0x1DE
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
        lVar2 = **(int64 **)(DAT_181d7f6c0 + 184);
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

    // Token : 0x6000F6E
    // RVA   : 0xA28D70   Offset: 0xA28170   Length: 0x2D
    public List<AreaBuildingRateChange> GetAreaBuildingRateChange()
    {
        long lVar1;
        lVar1 = AreaBuildingData.DataBase(this,0);
        if (lVar1 != null) {
          AreaBuildingDataBase.GetAreaBuildingRateChange(lVar1,this.lv,0);
          return;
        }
    }

    // Token : 0x6000F6F
    // RVA   : 0xA292A0   Offset: 0xA286A0   Length: 0x2D
    public ForceSpeAddData GetBuildingSpeAddData()
    {
        long lVar1;
        lVar1 = AreaBuildingData.DataBase(this,0);
        if (lVar1 != null) {
          AreaBuildingDataBase.GetBuildingSpeAddData(lVar1,this.lv,0);
          return;
        }
    }

    // Token : 0x6000F70
    // RVA   : 0xA297E0   Offset: 0xA28BE0   Length: 0x31
    public float GetChangeMaxPeople()
    {
        long lVar1;
        lVar1 = AreaBuildingData.DataBase(this,0);
        if (lVar1 != null) {
          return (float)(this.lv + 1) * *(float *)(lVar1 + 92);
        }
    }

    // Token : 0x6000F71
    // RVA   : 0xA29790   Offset: 0xA28B90   Length: 0x47
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

    // Token : 0x6000F72
    // RVA   : 0xA29740   Offset: 0xA28B40   Length: 0x47
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

    // Token : 0x6000F73
    // RVA   : 0xA29CC0   Offset: 0xA290C0   Length: 0x32
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

    // Token : 0x6000F74
    // RVA   : 0xA29D00   Offset: 0xA29100   Length: 0xEA
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

    // Token : 0x6000F75
    // RVA   : 0xA29AE0   Offset: 0xA28EE0   Length: 0x13B
    public List<float> GetObstacleRemoveCostResource(float rate)
    {
        long lVar1;
        float fVar2;
        lVar1 = il2cpp_internal(DAT_181d96ee8);
        FUN_181330100(lVar1,DAT_181da0d10);
        if (lVar1 != null) {
          FUN_18181e420(lVar1,0,DAT_181da0e10);
          FUN_18181e420(lVar1,0,DAT_181da0e10);
          FUN_18181e420(lVar1,0,DAT_181da0e10);
          FUN_18181e420(lVar1,0,DAT_181da0e10);
          FUN_18181e420(lVar1,0,DAT_181da0e10);
          FUN_18181e420(lVar1,0,DAT_181da0e10);
          fVar2 = (float)Mathf.Max();
          FUN_18182a350(lVar1,1,fVar2 * 500.0 * rate,DAT_181da1110);
          return lVar1;
        }
    }

    // Token : 0x6000F76
    // RVA   : 0xA29290   Offset: 0xA28690   Length: 0xA
    public int GetBuildingCureSkill()
    {
        return (this.lv + 5) * 5;
    }

    // Token : 0x6000F77
    // RVA   : 0xA29280   Offset: 0xA28680   Length: 0xC
    public int GetBuildingCureCost()
    {
        return (this.lv + 5) * 10;
    }

    // Token : 0x6000F78
    // RVA   : 0xA2ACA0   Offset: 0xA2A0A0   Length: 0x6E
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

    // Token : 0x6000F79
    // RVA   : 0xA29890   Offset: 0xA28C90   Length: 0x88
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

    // Token : 0x6000F7A
    // RVA   : 0xA29220   Offset: 0xA28620   Length: 0x54
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

    // Token : 0x6000F7B
    // RVA   : 0xA29A60   Offset: 0xA28E60   Length: 0x76
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

    // Token : 0x6000F7C
    // RVA   : 0xA29030   Offset: 0xA28430   Length: 0x1E0
    public float GetBuildSpeedRate()
    {
        int iVar1;
        bool cVar2;
        long lVar3;
        float fVar4;
        float fVar5;
        lVar3 = AreaBuildingData.GetArea(this,0);
        if ((lVar3 != null) && (lVar3.TimeDifficulty != null)) {
          fVar4 = (float)ForceSpeAddData.Get(lVar3.TimeDifficulty,13);
          lVar3 = AreaBuildingData.GetArea(this,0);
          if (lVar3 != null) {
            cVar2 = AreaData.HaveForce(lVar3,0);
            if (!cVar2) {
              return fVar4 + 1.0;
            }
            lVar3 = AreaBuildingData.GetArea(this,0);
            if (((lVar3 != null) && (lVar3 = AreaData.GetForce(lVar3,0)) != null) &&
               (lVar3.monthBreakEquipTime != null)) {
              fVar5 = (float)ForceSpeAddData.Get(lVar3.monthBreakEquipTime,12);
              fVar5 = fVar4 + 1.0 + fVar5;
              if (((GameController._instance != null) &&
                  (lVar3 = GameController._instance.worldData) != null) &&
                 (lVar3 = WorldData.Player(lVar3,0)) != null) {
                iVar1 = *(int *)(lVar3 + 132);
                lVar3 = AreaBuildingData.GetArea(this,0);
                if (lVar3 != null) {
                  if (iVar1 != lVar3.lastRandomWorldEventDay) {
                    lVar3 = FUN_18046c0a0(0);
                    if ((lVar3 == null) || (lVar3.villageAreaID == null)) throw; // [null/range check failed]
                    fVar4 = (float)WorldData.GetAIForceDevelopSpeed(lVar3.villageAreaID,0);
                    fVar5 = fVar5 + fVar4 * 0.05;
                  }
                  return fVar5;
                }
              }
            }
          }
        }
    }

    // Token : 0x6000F7D
    // RVA   : 0xA28DA0   Offset: 0xA281A0   Length: 0xBE
    public AreaData GetArea()
    {
        long lVar1;
        if ((GameController._instance != null) &&
           (lVar1 = GameController._instance.worldData) != null) {
          WorldData.GetArea(lVar1,this.areaID,0);
          return;
        }
    }

    // Token : 0x6000F7E
    // RVA   : 0xA27F70   Offset: 0xA27370   Length: 0x837
    public bool CanUpgrade()
    {
        var pStatics_3d40 = *(int64*)(DAT_181d73d40 + 184);
        float fVar1;
        uint uVar2;
        int iVar3;
        long lVar4;
        long lVar5;
        ulong uVar6;
        ulong uVar7;

        if ((lVar4 = PlotController.SpringFestivelRewardLvTalkText?.TempHeros) == null) throw; // [null/range check failed]
        lVar4 = AreaData.GetCenterBuilding(lVar4,0);
        if (this == lVar4) {

          if ((lVar4 = PlotController.SpringFestivelRewardLvTalkText?.TempHeros) == null) throw; // [null/range check failed]
          if (lVar4.Forces != null) {
            lVar4 = FUN_18046bac0(0);
            if ((lVar4 == null) || (lVar4.TempHeros == null)) throw; // [null/range check failed]
            if (*(int *)(lVar4.TempHeros + 72) != 1) goto LAB_180a282a8;
          }

          if ((lVar4 = PlotController.SpringFestivelRewardLvTalkText?.TempHeros) == null) throw; // [null/range check failed]
          fVar1 = lVar4.Heros;
          lVar4 = *(int64 *)(pStatics_3d40 + 0x670);
          lVar5 = PlotController.SpringFestivelRewardLvTalkText;
          if ((((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 88)) == null) ||
              (lVar5 = AreaData.GetCenterBuilding(lVar5,0)) == null) || (lVar4 == null))
          throw; // [null/range check failed]
          uVar2 = *(uint32 *)(lVar5 + 20);
          if (lVar4.cityAreaID <= uVar2) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          uVar6 = lVar4.chapter;
          if (fVar1 < uVar6[uVar2]) goto LAB_180a2879e;
        }
        LAB_180a282a8:

        if ((lVar4 = PlotController.SpringFestivelRewardLvTalkText?.TempHeros) == null) throw; // [null/range check failed]
        lVar4 = AreaData.GetCenterBuilding(lVar4,0);
        if (this == lVar4) {

          if ((lVar4 = PlotController.SpringFestivelRewardLvTalkText?.TempHeros) == null) throw; // [null/range check failed]
          if (lVar4.Forces == 2) {
            lVar4 = FUN_18046bac0(0);
            if (((lVar4 == null) || (lVar4.TempHeros == null)) ||
               (lVar4 = AreaData.GetForce(lVar4.TempHeros,0)) == null)
            throw; // [null/range check failed]
            iVar3 = *(int *)(lVar4 + 132);
            lVar4 = *(int64 *)(pStatics_3d40 + 0x678);
            lVar5 = PlotController.SpringFestivelRewardLvTalkText;
            if ((((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 88)) == null) ||
                (lVar5 = AreaData.GetCenterBuilding(lVar5,0)) == null) || (lVar4 == null))
            throw; // [null/range check failed]
            uVar2 = *(uint32 *)(lVar5 + 20);
            if (lVar4.cityAreaID <= uVar2) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            uVar6 = lVar4.chapter;
            if ((float)iVar3 < uVar6[uVar2]) goto LAB_180a2879e;
          }
        }

        if ((lVar4 = PlotController.SpringFestivelRewardLvTalkText?.TempHeros) != null) {
          lVar4 = AreaData.GetCenterBuilding(lVar4,0);
          if (this != lVar4) {
            iVar3 = this.lv;

            if (((lVar4 = PlotController.SpringFestivelRewardLvTalkText?.TempHeros) == null) ||
               (uVar6 = AreaData.GetCenterBuilding(lVar4,0)) == null) throw; // [null/range check failed]
            if (*(int *)(uVar6 + 20) <= iVar3) goto LAB_180a2879e;
          }
          if ((GameController._instance != null) &&
             (lVar4 = GameController._instance.worldData) != null) {
            lVar4 = WorldData.GetHeroForce(lVar4,0,0);
            uVar7 = AreaBuildingData.GetUpgradeCostResource(this);
            if (lVar4 != null) {
              uVar6 = ForceData.HaveResource(lVar4,uVar7,0);
              if ((char)uVar6) {
                lVar4 = FUN_18046c0a0(0);
                if (((lVar4 == null) || (lVar4.villageAreaID == null)) ||
                   (lVar4 = WorldData.Player(lVar4.villageAreaID,0)) == null)
                throw; // [null/range check failed]
                iVar3 = lVar4.forceMeetingStarted;
                uVar6 = *(uint64 *)(DAT_181dac470 + 184);
                if (*(int *)(uVar6 + 24) <= iVar3) {
                  return CONCAT71((int7)(uVar6 >> 8),1);
                }
              }
        LAB_180a2879e:
              return uVar6 & 0xffffffffffffff00;
            }
          }
        }
    }

    // Token : 0x6000F7F
    // RVA   : 0xA29F10   Offset: 0xA29310   Length: 0xD8B
    public string GetUpgradeDescribe()
    {
        var pStatics_3d40 = *(int64*)(DAT_181d73d40 + 184);
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

        if ((lVar5 = PlotController.SpringFestivelRewardLvTalkText?.TempHeros) == null) throw; // [null/range check failed]
        lVar5 = AreaData.GetCenterBuilding(lVar5,0);
        if (this == lVar5) {

          if ((lVar5 = PlotController.SpringFestivelRewardLvTalkText?.TempHeros) == null) throw; // [null/range check failed]
          if (lVar5.Forces != null) {
            lVar5 = FUN_18046bac0(0);
            if ((lVar5 == null) || (lVar5.TempHeros == null)) throw; // [null/range check failed]
            if (*(int *)(lVar5.TempHeros + 72) != 1) goto LAB_180a2a3d8;
          }

          if ((lVar5 = PlotController.SpringFestivelRewardLvTalkText?.TempHeros) == null) throw; // [null/range check failed]
          fVar1 = lVar5.Heros;
          lVar5 = *(int64 *)(pStatics_3d40 + 0x670);
          lVar6 = PlotController.SpringFestivelRewardLvTalkText;
          if ((((lVar6 == null) || (lVar6 = *(int64 *)(lVar6 + 88)) == null) ||
              (lVar6 = AreaData.GetCenterBuilding(lVar6,0)) == null) || (lVar5 == null))
          throw; // [null/range check failed]
          uVar2 = *(uint32 *)(lVar6 + 20);
          if (lVar5.cityAreaID <= uVar2) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          if (lVar5.chapter[uVar2] <= fVar1)
          goto LAB_180a2a3d8;
          uVar8 = *(uint64 *)(pStatics_3d40 + 0x2d0);
          lVar5 = *(int64 *)(pStatics_3d40 + 0x670);
          lVar6 = PlotController.SpringFestivelRewardLvTalkText;
          if ((((lVar6 == null) || (lVar6 = *(int64 *)(lVar6 + 88)) == null) ||
              (lVar6 = AreaData.GetCenterBuilding(lVar6,0)) == null) || (lVar5 == null)) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          uVar2 = *(uint32 *)(lVar6 + 20);
          if (lVar5.cityAreaID <= uVar2) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          local_res18[0] = lVar5.chapter[uVar2];
          uVar7 = il2cpp_value_box(DAT_181da22f0,local_res18);
          uVar10 = "需要\n{0}人口 {1}</color>\n\n";
        LAB_180a2a9ad:
          uVar8 = String.Format(uVar10,uVar8,uVar7,0);
          uVar9 = String.Concat(uVar9,uVar8,0);
        }
        else {
        LAB_180a2a3d8:

          if ((lVar5 = PlotController.SpringFestivelRewardLvTalkText?.TempHeros) == null) throw; // [null/range check failed]
          lVar5 = AreaData.GetCenterBuilding(lVar5,0);
          if (this == lVar5) {

            if ((lVar5 = PlotController.SpringFestivelRewardLvTalkText?.TempHeros) == null) throw; // [null/range check failed]
            if (lVar5.Forces == 2) {
              lVar5 = FUN_18046bac0(0);
              if (((lVar5 == null) || (lVar5.TempHeros == null)) ||
                 (lVar5 = AreaData.GetForce(lVar5.TempHeros,0)) == null)
              throw; // [null/range check failed]
              iVar3 = *(int *)(lVar5 + 132);
              lVar5 = *(int64 *)(pStatics_3d40 + 0x678);
              lVar6 = PlotController.SpringFestivelRewardLvTalkText;
              if ((((lVar6 == null) || (lVar6 = *(int64 *)(lVar6 + 88)) == null) ||
                  (lVar6 = AreaData.GetCenterBuilding(lVar6,0)) == null) || (lVar5 == null))
              throw; // [null/range check failed]
              uVar2 = *(uint32 *)(lVar6 + 20);
              if (lVar5.cityAreaID <= uVar2) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              if ((float)iVar3 < lVar5.chapter[uVar2]
                 ) {
                uVar8 = *(uint64 *)(pStatics_3d40 + 0x2d0);
                lVar5 = *(int64 *)(pStatics_3d40 + 0x678);
                lVar6 = PlotController.SpringFestivelRewardLvTalkText;
                if ((((lVar6 == null) || (lVar6 = *(int64 *)(lVar6 + 88)) == null) ||
                    (lVar6 = AreaData.GetCenterBuilding(lVar6,0)) == null) || (lVar5 == null)) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                uVar2 = *(uint32 *)(lVar6 + 20);
                if (lVar5.cityAreaID <= uVar2) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                local_res20[0] =
                     lVar5.chapter[uVar2];
                uVar7 = il2cpp_value_box(DAT_181da22f0,local_res20);
                uVar10 = "需要\n{0}弟子 {1}</color>\n\n";
                goto LAB_180a2a9ad;
              }
            }
          }

          if ((lVar5 = PlotController.SpringFestivelRewardLvTalkText?.TempHeros) == null) throw; // [null/range check failed]
          lVar5 = AreaData.GetCenterBuilding(lVar5,0);
          if (this != lVar5) {
            iVar3 = this.lv;

            if (((lVar5 = PlotController.SpringFestivelRewardLvTalkText?.TempHeros) == null) ||
               (lVar5 = AreaData.GetCenterBuilding(lVar5,0)) == null) throw; // [null/range check failed]
            if (*(int *)(lVar5 + 20) <= iVar3) {
              uVar8 = *(uint64 *)(pStatics_3d40 + 0x2d0);

              if ((((lVar5 = PlotController.SpringFestivelRewardLvTalkText?.TempHeros) == null) ||
                  (lVar5 = AreaData.GetCenterBuilding(lVar5,0)) == null) ||
                 (lVar5 = AreaBuildingData.DataBase(lVar5,0)) == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              uVar8 = String.Concat(uVar8,lVar5.cityAreaID,0);
              local_38 = this.lv + 1;
              uVar7 = il2cpp_value_box(DAT_181d80430,&local_38);
              uVar10 = "需要\n{0} {1}级</color>\n\n";
              goto LAB_180a2a9ad;
            }
          }
        }
        if (((GameController._instance != null) &&
            (lVar5 = GameController._instance.worldData) != null) &&
           (lVar5 = WorldData.Player(lVar5,0)) != null) {
          iVar3 = lVar5.forceMeetingStarted;
          if (iVar3 < AreaBuildController.UpgradeBuildNeedForceLv) {
            lVar5 = *(int64 *)(pStatics_3d40 + 0x3d8);
            uVar2 = AreaBuildController.UpgradeBuildNeedForceLv;
            if (lVar5 == null) throw; // [null/range check failed]
            if (lVar5.cityAreaID <= uVar2) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            uVar8 = GlobalData.GenerateRareLvColorText
                              (*(uint64 *)
                                (lVar5.chapter + 32 + (int64)(int)uVar2 * 8),
                               AreaBuildController.UpgradeBuildNeedForceLv,0);
            uVar8 = String.Format("需要 {0}\n\n",uVar8,0);
            uVar9 = String.Concat(uVar8,uVar9,0);
          }
          iVar3 = this.lv;
          lVar5 = AreaBuildingData.DataBase(this,0);
          if (lVar5 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          fVar1 = lVar5.TempHeros;
          fVar11 = (float)AreaBuildingData.GetBuildSpeedRate(this,0);
          uVar4 = Mathf.RoundToInt(((float)(iVar3 + 1) * fVar1) / fVar11,0);
          local_34[0] = Mathf.Max(1,uVar4);
          uVar8 = il2cpp_value_box(DAT_181d80430,local_34);
          uVar10 = AreaBuildingData.GetUpgradeCostResource(this);
          uVar10 = GlobalData.GetResourceDescribe(uVar10,0);
          uVar8 = String.Format("消耗 ({0}天)\n{1}",uVar8,uVar10,0);
          String.Concat(uVar9,uVar8,0);
          return;
        }
    }

    // Token : 0x6000F80
    // RVA   : 0xA29820   Offset: 0xA28C20   Length: 0x68
    public string GetDestroyCostText()
    {
        ulong uVar1;
        uint[] local_res18 = new uint[4];
        local_res18[0] = AreaBuildingData.GetDestroyTime(this,0);
        uVar1 = il2cpp_value_box(DAT_181d80430,local_res18);
        String.Format("消耗 ({0}天)",uVar1,0);
    }

    // Token : 0x6000F81
    // RVA   : 0xA29DF0   Offset: 0xA291F0   Length: 0x115
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
          uVar5 = il2cpp_value_box(DAT_181d80430,local_res8);
          uVar6 = AreaBuildingData.GetUpgradeCostResource(this);
          uVar6 = GlobalData.GetResourceDescribe(uVar6,0);
          String.Format("消耗 ({0}天)\n{1}",uVar5,uVar6,0);
          return;
        }
    }

    // Token : 0x6000F82
    // RVA   : 0xA299F0   Offset: 0xA28DF0   Length: 0x68
    public string GetMoveCostText()
    {
        ulong uVar1;
        uint[] local_res18 = new uint[4];
        local_res18[0] = AreaBuildingData.GetMoveTime(this,0);
        uVar1 = il2cpp_value_box(DAT_181d80430,local_res18);
        String.Format("消耗 ({0}天)",uVar1,0);
    }

    // Token : 0x6000F83
    // RVA   : 0xA292D0   Offset: 0xA286D0   Length: 0x3C6
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
              goto LAB_180a295c8;
            }
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        lVar4 = *(int64 *)(*(int64 *)(DAT_181dac470 + 184) + 8);
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
        LAB_180a295c8:
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

    // Token : 0x6000F84
    // RVA   : 0xA28E60   Offset: 0xA28260   Length: 0x1CA
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

    // Token : 0x6000F85
    // RVA   : 0xA28B00   Offset: 0xA27F00   Length: 0x175
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

    // Token : 0x6000F86
    // RVA   : 0xA2ADF0   Offset: 0xA2A1F0   Length: 0x39
    private static void /*cctor*/()
    {
        **(uint32 **)(DAT_181dac570 + 184) = 0x3dcccccd;
    }

}
