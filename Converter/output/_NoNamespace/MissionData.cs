// ============================================================
// Type  : MissionData
// Token : 0x2000251
// ============================================================

public class MissionData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400128B
    public static List<string> MissionBountyTypeRewardType;

    // Token: 0x400128C
    public int id;

    // Token: 0x400128D
    public string name;

    // Token: 0x400128E
    public int speMissionID;

    // Token: 0x400128F
    public int leftTime;

    // Token: 0x4001290
    public int stageMinLeftTime;

    // Token: 0x4001291
    public float difficulty;

    // Token: 0x4001292
    public float difficultyRate;

    // Token: 0x4001293
    public float rewardRate;

    // Token: 0x4001294
    public float treasureLv;

    // Token: 0x4001295
    public List<BountyType> bountyTypes;

    // Token: 0x4001296
    public int minForceLv;

    // Token: 0x4001297
    public MissionSourceType missionSourceType;

    // Token: 0x4001298
    public BountyType missionBountyType;

    // Token: 0x4001299
    public int sourceHeroID;

    // Token: 0x400129A
    public int sourceForceID;

    // Token: 0x400129B
    public int missionHeroID;

    // Token: 0x400129C
    public bool missionDisableQuickTravel;

    // Token: 0x400129D
    public bool missionHideTargetPlace;

    // Token: 0x400129E
    public string missionHideTargetPlaceString;

    // Token: 0x400129F
    public int missionRandomSeed;

    // Token: 0x40012A0
    public List<MissionTargetData> missionTargetDatas;

    // Token: 0x40012A1
    public bool noAutoFinish;

    // Token: 0x40012A2
    public int missionFunds;

    // Token: 0x40012A3
    public float missionFameReward;

    // Token: 0x40012A4
    public float missionContributionRewardBase;

    // Token: 0x40012A5
    public float missionContributionReward;

    // Token: 0x40012A6
    public int missionMoneyReward;

    // Token: 0x40012A7
    public string missionJoinTeamHero;

    // Token: 0x40012A8
    public List<int> missionJoinTeamHeroID;

    // Token: 0x40012A9
    public static List<float> MissionTargetTypeBaseMissionContribution;

    // Token: 0x40012AA
    public static List<MissionTargetType> MissionTargetNpc;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001331
    // RVA   : 0xE98EA0   Offset: 0xE97CA0   Length: 0x191
    public void /*ctor*/()
    {
        long lVar1;
        ulong uVar2;
        this.speMissionID = 0xffffffff;
        this.difficultyRate = 0x3f800000;
        this.rewardRate = 0x3f800000;
        this.sourceHeroID = 0xffffffffffffffff;
        this.missionHeroID = 0xffffffff;
        ZhSegment.Initialize(this,0);
        lVar1 = il2cpp_internal(DAT_181e74c38);
        FUN_1810f3480(lVar1,DAT_181e771e0);
        uVar2 = new MissionTargetData(0);
        if (lVar1 != null) {
          FUN_18175de30(lVar1,uVar2,DAT_181e772e0);
          this.missionTargetDatas = lVar1;
          uVar2 = il2cpp_internal(DAT_181e73cb8);
          FUN_1810f3480(uVar2,DAT_181e71270);
          this.missionJoinTeamHeroID = uVar2;
          return;
        }
    }

    // Token : 0x6001332
    // RVA   : 0xE98360   Offset: 0xE97160   Length: 0x2DB
    public bool MissionRelateToHero(int targetHeroID)
    {
        ulong uVar1;
        bool cVar2;
        long lVar3;
        ulong uVar4;
        long lVar5;
        int iVar6;
        uint uVar7;
        long lVar8;
        uint[] local_res10 = new uint[2];
        local_res10[0] = targetHeroID;
        if ((this.sourceHeroID != 0xffffffff) && (this.sourceHeroID == local_res10[0])) {
          return true;
        }
        lVar3 = this.missionTargetDatas;
        uVar7 = 0;
        if (lVar3 != null) {
          lVar8 = 32;
          while( true ) {
            if (lVar3.Count <= (int)uVar7) {
              return false;
            }
            if (lVar3 == null) break;
            if (lVar3.Count <= uVar7) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar3 = *(int64 *)(lVar8 + lVar3._items);
            if (lVar3 == null) break;
            if (*(int *)(lVar3 + 40) == 5) {
              if ((this.missionTargetDatas == null) ||
                 (lVar3 = FUN_1800024b0(this.missionTargetDatas,uVar7,DAT_181e77460)) == null)
              break;
              uVar1 = *(uint64 *)(lVar3 + 48);
              uVar4 = Int32.ToString(local_res10,0);
              cVar2 = FUN_1816387f0(uVar1,uVar4,0);
              if (cVar2) {
                return true;
              }
            }
            if ((this.missionTargetDatas == null) ||
               (lVar3 = FUN_1800024b0(this.missionTargetDatas,uVar7,DAT_181e77460)) == null)
            break;
            if (*(int64 *)(lVar3 + 56) != 0) {
              iVar6 = 0;
              while( true ) {
                if (((this.missionTargetDatas == null) ||
                    (lVar3 = FUN_1800024b0(this.missionTargetDatas,uVar7,DAT_181e77460)) == null
                    ) || (*(int64 *)(lVar3 + 56) == 0)) throw; // [null/range check failed]
                if (*(int *)(*(int64 *)(lVar3 + 56) + 24) <= iVar6) break;
                lVar3 = *(int64 *)(*(int64 *)(DAT_181e6ad70 + 184) + 16);
                if (((this.missionTargetDatas == null) ||
                    (lVar5 = FUN_1800024b0(this.missionTargetDatas,uVar7,DAT_181e77460)) == null
                    ) || ((*(int64 *)(lVar5 + 56) == 0 ||
                          ((lVar5 = FUN_1800024b0(*(int64 *)(lVar5 + 56),iVar6,DAT_181e77160),
                           lVar5 == null || (lVar3 == null)))))) throw; // [null/range check failed]
                cVar2 = FUN_18176a2d0(lVar3,*(uint32 *)(lVar5 + 16),DAT_181e775e0);
                if (cVar2) {
                  if ((((this.missionTargetDatas == null) ||
                       (lVar3 = FUN_1800024b0(this.missionTargetDatas,uVar7,DAT_181e77460),
                       lVar3 == null)) || (*(int64 *)(lVar3 + 56) == 0)) ||
                     (lVar3 = FUN_1800024b0(*(int64 *)(lVar3 + 56),iVar6,DAT_181e77160)) == null)
                  throw; // [null/range check failed]
                  uVar1 = lVar3.Count;
                  uVar4 = Int32.ToString(local_res10,0);
                  cVar2 = FUN_1816387f0(uVar1,uVar4,0);
                  if (cVar2) {
                    return true;
                  }
                }
                iVar6 = iVar6 + 1;
              }
            }
            lVar3 = this.missionTargetDatas;
            uVar7 = uVar7 + 1;
            lVar8 = lVar8 + 8;
            if (lVar3 == null) break;
          }
        }
    }

    // Token : 0x6001333
    // RVA   : 0xE98670   Offset: 0xE97470   Length: 0xDC
    public MissionData SetForceMission(string _name, MissionTargetType _missionTargetType, float _difficulty)
    {
        int64 MissionData.SetForceMission
                         (int64 this,uint64 _name,uint32 _missionTargetType,float _difficulty,
                         uint32 param_5,float param_6)
        {
        int iVar1;
        int64 lVar2;
        this.missionSourceType = 2;
        this.noAutoFinish = 1;
        if (((GameController._instance != null) &&
            (lVar2 = GameController._instance.worldData) != null) &&
           (lVar2 = lVar2.worldTime) != null) {
          iVar1 = lVar2.Count;
          this.name = _name;
          this.leftTime = 31 - iVar1;
          lVar2 = this.missionTargetDatas;
          if (lVar2 != null) {
            if (lVar2.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar2 = *(int64 *)(lVar2._items + 32);
            if ((lVar2 = lVar2?.Inns) != null) {
              if (lVar2.Count == null) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar2 = *(int64 *)(lVar2._items + 32);
              if (lVar2 != null) {
                lVar2._items = _missionTargetType;
                this.difficulty = _difficulty;
                this.minForceLv = param_5;
                this.missionContributionRewardBase = param_6;
                this.missionContributionReward = (_difficulty * 0.2 + 1.0) * param_6;
                return this;
              }
            }
          }
        }
    }

    // Token : 0x6001334
    // RVA   : 0xE98750   Offset: 0xE97550   Length: 0xE5
    public MissionData SetForceMission(string _name, MissionTargetType _missionTargetType, float _difficulty, int _minForceLv)
    {
        int64 MissionData.SetForceMission
                         (int64 this,uint64 _name,uint32 _missionTargetType,float _difficulty,
                         uint32 _minForceLv,float param_6)
        {
        int iVar1;
        int64 lVar2;
        this.missionSourceType = 2;
        this.noAutoFinish = 1;
        if (((GameController._instance != null) &&
            (lVar2 = GameController._instance.worldData) != null) &&
           (lVar2 = lVar2.worldTime) != null) {
          iVar1 = lVar2.Count;
          this.name = _name;
          this.leftTime = 31 - iVar1;
          lVar2 = this.missionTargetDatas;
          if (lVar2 != null) {
            if (lVar2.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar2 = *(int64 *)(lVar2._items + 32);
            if ((lVar2 = lVar2?.Inns) != null) {
              if (lVar2.Count == null) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar2 = *(int64 *)(lVar2._items + 32);
              if (lVar2 != null) {
                lVar2._items = _missionTargetType;
                this.difficulty = _difficulty;
                this.minForceLv = _minForceLv;
                this.missionContributionRewardBase = param_6;
                this.missionContributionReward = (_difficulty * 0.2 + 1.0) * param_6;
                return this;
              }
            }
          }
        }
    }

    // Token : 0x6001335
    // RVA   : 0xE98840   Offset: 0xE97640   Length: 0x1B8
    public MissionData SetForceMission(string _name, MissionTargetType _missionTargetType, float _difficulty, int _minForceLv, float _baseMissionContributionReward)
    {
        int64 MissionData.SetForceMission
                         (int64 this,uint64 _name,uint32 _missionTargetType,float _difficulty,
                         uint32 _minForceLv,float _baseMissionContributionReward)
        {
        int iVar1;
        int64 lVar2;
        this.missionSourceType = 2;
        this.noAutoFinish = 1;
        if (((GameController._instance != null) &&
            (lVar2 = GameController._instance.worldData) != null) &&
           (lVar2 = lVar2.worldTime) != null) {
          iVar1 = lVar2.Count;
          this.name = _name;
          this.leftTime = 31 - iVar1;
          lVar2 = this.missionTargetDatas;
          if (lVar2 != null) {
            if (lVar2.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar2 = *(int64 *)(lVar2._items + 32);
            if ((lVar2 = lVar2?.Inns) != null) {
              if (lVar2.Count == null) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar2 = *(int64 *)(lVar2._items + 32);
              if (lVar2 != null) {
                lVar2._items = _missionTargetType;
                this.difficulty = _difficulty;
                this.minForceLv = _minForceLv;
                this.missionContributionRewardBase = _baseMissionContributionReward;
                this.missionContributionReward = (_difficulty * 0.2 + 1.0) * _baseMissionContributionReward;
                return this;
              }
            }
          }
        }
    }

    // Token : 0x6001336
    // RVA   : 0xE98640   Offset: 0xE97440   Length: 0x26
    public void SetDifficulty(float _difficulty)
    {
        void FUN_180e98640(int64 this,float _difficulty)
        {
        this.difficulty = _difficulty;
        this.missionContributionReward = (_difficulty * 0.2 + 1.0) * this.missionContributionRewardBase;
    }

    // Token : 0x6001337
    // RVA   : 0xE97070   Offset: 0xE95E70   Length: 0x28
    public int GetRareLv()
    {
        int iVar1;
        iVar1 = Mathf.RoundToInt(this,0);
        return (int)((float)iVar1 * 0.5);
    }

    // Token : 0x6001338
    // RVA   : 0xE938E0   Offset: 0xE926E0   Length: 0x53
    public string GetMissionDescribe()
    {
        void MissionData.GetMissionDescribe
                     (uint64 this,uint8 param_2,uint8 param_3,uint8 param_4,
                     uint8 param_5)
        {
        uint64 uVar1;
        uint64 uVar2;
        uVar1 = MissionData.GetMissionBaseDescribe(this,param_4,0);
        uVar2 = MissionData.GetMissionExtraDescribe(this,param_2,param_3,param_4,param_5,0);
        String.Concat(uVar1,uVar2,0);
    }

    // Token : 0x6001339
    // RVA   : 0xE930C0   Offset: 0xE91EC0   Length: 0x170
    public string GetBountyTargetItem()
    {
        long lVar1;
        uint uVar2;
        uint uVar3;
        ulong uVar4;
        ulong uVar5;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181e538e8 + 184) + 0x510);
        uVar2 = Mathf.RoundToInt(this.difficulty * 0.5,0);
        if (lVar1 != null) {
          if (lVar1.Count <= uVar2) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          uVar4 = lVar1._items[uVar2];
          uVar3 = Mathf.RoundToInt(this.difficulty * 0.5,0);
          uVar4 = GlobalData.GenerateRareLvColorText(uVar4,uVar3,0);
          lVar1 = this.missionTargetDatas;
          if (lVar1 != null) {
            if (lVar1.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar1 = *(int64 *)(lVar1._items + 32);
            if ((lVar1 != null) && (lVar1 = *(int64 *)(lVar1 + 56)) != null) {
              if (lVar1.Count == null) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar1 = *(int64 *)(lVar1._items + 32);
              if (lVar1 != null) {
                uVar3 = Int32.Parse(lVar1.Count,0);
                uVar5 = GlobalData.GetHobbyString(uVar3,0);
                String.Format("<b>{0}级{1}</b>",uVar4,uVar5,0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x600133A
    // RVA   : 0xE93240   Offset: 0xE92040   Length: 0x694
    public string GetMissionBaseDescribe(bool showFinishRate)
    {
        bool cVar1;
        uint uVar2;
        uint uVar3;
        long lVar4;
        ulong uVar5;
        long lVar6;
        ulong uVar7;
        ulong uVar8;
        int[] local_res8 = new int[2];
        lVar4 = this.missionTargetDatas;
        local_res8[0] = 0;
        if (lVar4 != null) {
          if (lVar4.Count == null) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar4 = *(int64 *)(lVar4._items + 32);
          if (lVar4 != null) {
            if (lVar4._items == null) {
              lVar4 = MissionData.GetMissionTargetDescribe(this,showFinishRate,0);
            }
            else {
              lVar4 = this.missionTargetDatas;
              if (lVar4 == null) throw; // [null/range check failed]
              if (lVar4.Count == null) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              uVar8 = "<b>{0}</b>";
              uVar7 = "#TargetPlace#";
              lVar4 = *(int64 *)(lVar4._items + 32);
              if (lVar4 == null) throw; // [null/range check failed]
              lVar4 = lVar4._items;
              if (!this.missionHideTargetPlace) {
                uVar5 = MissionData.GetTriggerTargetDescribe(this,0,0,0);
              }
              else {
                uVar5 = this.missionHideTargetPlaceString;
              }
              uVar8 = String.Format(uVar8,uVar5,0);
              if (lVar4 == null) throw; // [null/range check failed]
              lVar4 = String.Replace(lVar4,uVar7,uVar8,0);
              uVar7 = MissionData.GetTriggerTargetDescribe(this,1,0);
              uVar7 = String.Format("<b>{0}</b>",uVar7,0);
              if (lVar4 == null) throw; // [null/range check failed]
              lVar6 = String.Replace(lVar4,"#NextTargetPlace#",uVar7,0);
              lVar4 = this.missionTargetDatas;
              if (lVar4 == null) throw; // [null/range check failed]
              if (lVar4.Count == null) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar4 = *(int64 *)(lVar4._items + 32);
              if (lVar4 == null) throw; // [null/range check failed]
              uVar3 = *(uint32 *)(lVar4 + 72);
              uVar7 = GlobalData.GetRequireTypeText(uVar3,0);
              uVar7 = String.Format("<b>{0}</b>",uVar7,0);
              if (lVar6 == null) throw; // [null/range check failed]
              lVar4 = String.Replace(lVar6,"#MissionRequireType#",uVar7,0);
              local_res8[0] = this.missionMoneyReward * 2;
              uVar7 = Int32.ToString(local_res8,0);
              if (lVar4 == null) throw; // [null/range check failed]
              lVar4 = String.Replace(lVar4,"#BountyDebtsMoney#",uVar7,0);
              uVar7 = "#SourceHeroName#";
              uVar8 = "";
              if (0 < this.sourceHeroID) {
                lVar6 = FUN_1802106e0(0);
                if (((lVar6 == null) || (lVar6.villageAreaID == null)) ||
                   (lVar6 = WorldData.GetHero(lVar6.villageAreaID,this.sourceHeroID
                                               ,0), lVar6 == null)) throw; // [null/range check failed]
                uVar8 = lVar6.AreaMapRandomEventDatas;
              }
              if (lVar4 == null) throw; // [null/range check failed]
              lVar4 = String.Replace(lVar4,uVar7,uVar8,0);
              if (((GameController._instance == null) ||
                  (lVar6 = GameController._instance.worldData) == null) ||
                 (lVar6 = WorldData.Player(lVar6,0)) == null) throw; // [null/range check failed]
              local_res8[0] = HeroData.GetUpgradeForceLvNeedContribution(lVar6,0x3f800000,0);
              uVar7 = Int32.ToString(local_res8,0);
              if (lVar4 == null) throw; // [null/range check failed]
              lVar4 = String.Replace(lVar4,"#UpgradeForceLvNeedContributionNum#",uVar7,0);
              if (((GameController._instance == null) ||
                  (lVar6 = GameController._instance.worldData) == null) ||
                 (lVar6 = WorldData.Player(lVar6,0)) == null) throw; // [null/range check failed]
              local_res8[0] = HeroData.GetUpgradeForceLvNeedSkillNum(lVar6,0);
              uVar7 = Int32.ToString(local_res8,0);
              if ((lVar4 == null) || (lVar4 = String.Replace(lVar4,"#UpgradeForceLvNeedSkillNum#",uVar7,0)) == null)
              throw; // [null/range check failed]
              lVar4 = String.Replace(lVar4,"\\n","\n",0);
            }
            if (lVar4 != null) {
              cVar1 = String.Contains(lVar4,"#BountyHeroItemDescribe#",0);
              if (!cVar1) {
                return lVar4;
              }
              lVar6 = *(int64 *)(*(int64 *)(DAT_181e538e8 + 184) + 0x510);
              uVar2 = Mathf.RoundToInt(this.difficulty * 0.5,0);
              if (lVar6 != null) {
                if (lVar6.Count <= uVar2) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                uVar7 = lVar6._items[uVar2];
                uVar3 = Mathf.RoundToInt(this.difficulty * 0.5,0);
                uVar7 = GlobalData.GenerateRareLvColorText(uVar7,uVar3,0);
                lVar6 = this.missionTargetDatas;
                if (lVar6 != null) {
                  if (lVar6.Count == null) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  lVar6 = *(int64 *)(lVar6._items + 32);
                  if ((lVar6 = lVar6?.Inns) != null) {
                    if (lVar6.Count == null) {
                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                    }
                    lVar6 = *(int64 *)(lVar6._items + 32);
                    if (lVar6 != null) {
                      uVar3 = Int32.Parse(lVar6.Count,0);
                      uVar8 = GlobalData.GetHobbyString(uVar3,0);
                      uVar7 = String.Format("<b>{0}级{1}</b>",uVar7,uVar8,0);
                      lVar4 = String.Replace(lVar4,"#BountyHeroItemDescribe#",uVar7,0);
                      return lVar4;
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x600133B
    // RVA   : 0xE939D0   Offset: 0xE927D0   Length: 0x842
    public string GetMissionExtraDescribe(bool showMissionTargetType, bool showDifficulty, bool showFinishRate, bool showForceContribution)
    {
        var pStatics = *(int64*)(DAT_181e538e8 + 184);
        uint64
        MissionData.GetMissionExtraDescribe
                (int64 this,char showMissionTargetType,char showDifficulty,uint8 showFinishRate,char showForceContribution)
        {
        uint32 uVar1;
        uint32 uVar2;
        int64 lVar3;
        char cVar4;
        uint64 uVar5;
        uint64 uVar6;
        uint64 uVar7;
        int64 lVar8;
        int64 lVar9;
        uint64 uVar10;
        uint64 uVar11;
        int local_res8 [2];
        char local_res10;
        char local_res18;
        uint8 local_res20;
        uint32 local_78;
        float local_74 [13];
        local_res10 = showMissionTargetType;
        local_res18 = showDifficulty;
        local_res20 = showFinishRate;
        uVar7 = "";
        lVar9 = this.missionTargetDatas;
        if (lVar9 != null) {
          if (lVar9.Count == null) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar9 = *(int64 *)(lVar9._items + 32);
          if (lVar9 != null) {
            if (0.0 < *(float *)(lVar9 + 76)) {
              lVar9 = this.missionTargetDatas;
              if (lVar9 == null) {
        LAB_180e94207:
                          // WARNING: Subroutine does not return
                FUN_1801e0300();
              }
              if (lVar9.Count == null) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar9 = *(int64 *)(lVar9._items + 32);
              if (lVar9 == null) goto LAB_180e94207;
              uVar1 = *(uint32 *)(lVar9 + 72);
              uVar5 = GlobalData.GetRequireTypeText(uVar1,0);
              lVar9 = this.missionTargetDatas;
              if (lVar9 == null) goto LAB_180e94207;
              if (lVar9.Count == null) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar9 = *(int64 *)(lVar9._items + 32);
              if (lVar9 == null) goto LAB_180e94207;
              local_res8[0] = *(int *)(lVar9 + 76);
              uVar6 = il2cpp_value_box(DAT_181e82730,local_res8);
              lVar9 = this.missionTargetDatas;
              lVar8 = *(int64 *)(*(int64 *)(DAT_181e71f68 + 184) + 24);
              if (lVar9 == null) goto LAB_180e94207;
              if (lVar9.Count == null) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar9 = *(int64 *)(lVar9._items + 32);
              if (lVar9 == null) goto LAB_180e94207;
              lVar3 = this.missionTargetDatas;
              uVar1 = *(uint32 *)(lVar9 + 72);
              if (lVar3 == null) goto LAB_180e94207;
              if (lVar3.Count == null) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar9 = *(int64 *)(lVar3._items + 32);
              if ((lVar9 == null) || (lVar8 == null)) goto LAB_180e94207;
              cVar4 = PlotController.CheckMeetRequire(lVar8,uVar1,*(uint32 *)(lVar9 + 76),0,0);
              uVar10 = "\n需要:{2}{0}{1}</color>";
              if (!cVar4) {
                lVar8 = FUN_180210a70(0);
                lVar9 = this.missionTargetDatas;
                if (lVar9 == null) throw; // [null/range check failed]
                if (lVar9.Count == null) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar9 = *(int64 *)(lVar9._items + 32);
                if (lVar9 == null) throw; // [null/range check failed]
                lVar3 = this.missionTargetDatas;
                uVar1 = *(uint32 *)(lVar9 + 72);
                if (lVar3 == null) throw; // [null/range check failed]
                if (lVar3.Count == null) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar9 = *(int64 *)(lVar3._items + 32);
                if ((lVar9 == null) || (lVar8 == null)) throw; // [null/range check failed]
                cVar4 = PlotController.CheckMeetRequire(lVar8,uVar1,*(uint32 *)(lVar9 + 76),1,0);
                if (!cVar4) {
                  uVar11 = *(uint64 *)(pStatics + 0x2d8);
                }
                else {
                  uVar11 = *(uint64 *)(pStatics + 0x250);
                }
              }
              else {
                uVar11 = *(uint64 *)(pStatics + 0x270);
              }
              uVar5 = String.Format(uVar10,uVar5,uVar6,uVar11,0);
              uVar7 = String.Concat(uVar7,uVar5,0);
              showFinishRate = local_res20;
              showDifficulty = local_res18;
            }
            if (local_res10) {
              lVar9 = this.missionTargetDatas;
              if (lVar9 == null) throw; // [null/range check failed]
              if (lVar9.Count == null) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar9 = *(int64 *)(lVar9._items + 32);
              if ((lVar9 == null) || (lVar9 = *(int64 *)(lVar9 + 56)) == null) throw; // [null/range check failed]
              if (lVar9.Count == null) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar9 = *(int64 *)(lVar9._items + 32);
              if (lVar9 == null) throw; // [null/range check failed]
              if (lVar9._items != null) {
                uVar5 = MissionData.GetMissionTargetDescribe(this,showFinishRate,0);
                uVar7 = String.Concat(uVar7,"\n\n目标:\n",uVar5,0);
              }
            }
            if (showDifficulty) {
              uVar1 = this.difficulty;
              uVar5 = GlobalData.GetDifficultyStarString(uVar1,0);
              uVar5 = String.Format("\n难度:{0}",uVar5,0);
              uVar7 = String.Concat(uVar7,uVar5,0);
            }
            if (this.missionMoneyReward != null) {
              local_res8[0] = this.missionMoneyReward;
              uVar5 = il2cpp_value_box(DAT_181e60808,local_res8);
              uVar5 = String.Format("\n银两:{0}",uVar5,0);
              uVar7 = String.Concat(uVar7,uVar5,0);
            }
            uVar5 = "\n{0}:{1}";
            if (this.missionFameReward != null.0) {
              lVar9 = "声望";
              if (this.missionSourceType == 3) {
                lVar9 = MissionData.MissionBountyTypeRewardType;
                if (lVar9 == null) throw; // [null/range check failed]
                uVar2 = this.missionBountyType;
                if (lVar9.Count <= uVar2) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar9 = lVar9._items[uVar2];
              }
              uVar6 = "#SourceHeroName#";
              uVar10 = "";
              if (0 < this.sourceHeroID) {
                lVar8 = FUN_1802106e0(0);
                if (((lVar8 == null) || (*(int64 *)(lVar8 + 32) == 0)) ||
                   (lVar8 = WorldData.GetHero(*(int64 *)(lVar8 + 32),this.sourceHeroID
                                               ,0), lVar8 == null)) throw; // [null/range check failed]
                uVar10 = *(uint64 *)(lVar8 + 104);
              }
              if (lVar9 == null) throw; // [null/range check failed]
              lVar9 = String.Replace(lVar9,uVar6,uVar10,0);
              uVar6 = "#SourceForceName#";
              uVar10 = "本门";
              if (this.sourceForceID != -1) {
                lVar8 = FUN_1802106e0(0);
                if ((lVar8 == null) || (*(int64 *)(lVar8 + 32) == 0)) throw; // [null/range check failed]
                lVar8 = WorldData.GetForce(*(int64 *)(lVar8 + 32),this.sourceForceID,0)
                ;
                if (lVar8 == null) throw; // [null/range check failed]
                uVar10 = ForceData.GetForceName(lVar8,1,0);
              }
              if (lVar9 == null) {
                          // WARNING: Subroutine does not return
                FUN_1801e0300();
              }
              uVar6 = String.Replace(lVar9,uVar6,uVar10,0);
              local_78 = this.missionFameReward;
              uVar10 = il2cpp_value_box(DAT_181e82730,&local_78);
              uVar5 = String.Format(uVar5,uVar6,uVar10,0);
              uVar7 = String.Concat(uVar7,uVar5,0);
            }
            if ((showForceContribution) && (local_74[0] = this.missionContributionReward, local_74[0] != 0.0)) {
              uVar5 = il2cpp_value_box(DAT_181e82730,local_74);
              uVar5 = String.Format("\n本门功绩:{0}",uVar5,0);
              uVar7 = String.Concat(uVar7,uVar5,0);
            }
            return uVar7;
          }
        }
    }

    // Token : 0x600133C
    // RVA   : 0xE93940   Offset: 0xE92740   Length: 0x87
    public string GetMissionDescribe(bool showMissionTargetType, bool showDifficulty, bool showFinishRate, bool showForceContribution)
    {
        void MissionData.GetMissionDescribe
                     (uint64 this,uint8 showMissionTargetType,uint8 showDifficulty,uint8 showFinishRate,
                     uint8 showForceContribution)
        {
        uint64 uVar1;
        uint64 uVar2;
        uVar1 = MissionData.GetMissionBaseDescribe(this,showFinishRate,0);
        uVar2 = MissionData.GetMissionExtraDescribe(this,showMissionTargetType,showDifficulty,showFinishRate,showForceContribution,0);
        String.Concat(uVar1,uVar2,0);
    }

    // Token : 0x600133D
    // RVA   : 0xE97800   Offset: 0xE96600   Length: 0x151
    public int GetTargetInnID()
    {
        long lVar1;
        ulong uVar2;
        lVar1 = this.missionTargetDatas;
        if (lVar1 != null) {
          if (lVar1.Count == null) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar1 = *(int64 *)(lVar1._items + 32);
          if ((lVar1 != null) && (lVar1 = *(int64 *)(lVar1 + 56)) != null) {
            if (lVar1.Count < 1) {
              return 0xffffffff;
            }
            lVar1 = this.missionTargetDatas;
            if (lVar1 != null) {
              if (lVar1.Count == null) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar1 = *(int64 *)(lVar1._items + 32);
              if ((lVar1 != null) && (lVar1 = *(int64 *)(lVar1 + 56)) != null) {
                if (lVar1.Count == null) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar1 = *(int64 *)(lVar1._items + 32);
                if (lVar1 != null) {
                  if (lVar1._items != null) {
                    return 0xffffffff;
                  }
                  lVar1 = this.missionTargetDatas;
                  if (lVar1 != null) {
                    if (lVar1.Count == null) {
                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                    }
                    lVar1 = *(int64 *)(lVar1._items + 32);
                    if (lVar1 != null) {
                      if (*(int *)(lVar1 + 40) != 6) {
                        return 0xffffffff;
                      }
                      lVar1 = this.missionTargetDatas;
                      if (lVar1 != null) {
                        if (lVar1.Count == null) {
                          ThrowHelper.ThrowArgumentOutOfRangeException(0);
                        }
                        lVar1 = *(int64 *)(lVar1._items + 32);
                        if (lVar1 != null) {
                          uVar2 = Int32.Parse(*(uint64 *)(lVar1 + 48),0);
                          return uVar2;
                        }
                      }
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x600133E
    // RVA   : 0xE970A0   Offset: 0xE95EA0   Length: 0x734
    public List<int> GetTargetAreaID()
    {
        int iVar1;
        long lVar2;
        uint uVar3;
        long lVar4;
        long lVar5;
        long lVar6;
        ulong uVar7;
        long lVar8;
        uint uVar9;
        lVar4 = il2cpp_internal(DAT_181e73cb8);
        FUN_1810f3480(lVar4,DAT_181e71270);
        lVar5 = this.missionTargetDatas;
        uVar9 = 0;
        if (lVar5 != null) {
          lVar8 = 0;
          while( true ) {
            if (lVar5.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar5 = *(int64 *)(lVar5._items + 32);
            if ((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 56)) == null) break;
            if (lVar5.Count <= (int)uVar9) {
              return lVar4;
            }
            lVar5 = this.missionTargetDatas;
            if (lVar5 == null) break;
            if (lVar5.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar5 = *(int64 *)(lVar5._items + 32);
            if ((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 56)) == null) break;
            if (lVar5.Count <= uVar9) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar5 = *(int64 *)(lVar5._items + 32 + lVar8 * 8);
            if (lVar5 == null) break;
            lVar6 = this.missionTargetDatas;
            if (lVar5._items == null) {
              if (lVar6 == null) break;
              if (lVar6.Count == null) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar5 = *(int64 *)(lVar6._items + 32);
              if (lVar5 == null) break;
              iVar1 = *(int *)(lVar5 + 40);
              if (iVar1 - 1U < 4) {
                lVar5 = this.missionTargetDatas;
                if (lVar5 != null) {
                  if (lVar5.Count == null) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  lVar5 = *(int64 *)(lVar5._items + 32);
                  if (lVar5 != null) {
                    lVar5 = *(int64 *)(lVar5 + 48);
                    lVar6 = FUN_1801dfd90(DAT_181e81128,1);
                    if (lVar6 != null) {
                      if (lVar6.Count == null) {
                        uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1801e02d0(uVar7,0);
                      }
                      *(uint16 *)(lVar6 + 32) = 58;
                      if (lVar5 != null) {
                        lVar5 = String.Split(lVar5,lVar6,0);
                        lVar6 = FUN_1802106e0(0);
                        if ((lVar6 != null) && (lVar6 = *(int64 *)(lVar6 + 32), lVar5 != null)) {
                          if (lVar5.Count == null) {
                            uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                            FUN_1801e02d0(uVar7,0);
                          }
                          uVar3 = Int32.Parse(*(uint64 *)(lVar5 + 32),0);
                          if (((lVar6 != null) && (lVar5 = WorldData.GetArea(lVar6,uVar3,0)) != null) &&
                             (lVar4 != null)) {
                            FUN_181769fe0();
                            goto LAB_180e97778;
                          }
                        }
                      }
                    }
                  }
                }
                break;
              }
              if (iVar1 == 5) {
                lVar5 = FUN_1802106e0(0);
                if (lVar5 == null) break;
                lVar5 = *(int64 *)(lVar5 + 32);
                lVar6 = FUN_1802106e0(0);
                if (lVar6 == null) break;
                lVar2 = this.missionTargetDatas;
                lVar6 = *(int64 *)(lVar6 + 32);
                if (lVar2 == null) break;
                if (lVar2.Count == null) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar2 = *(int64 *)(lVar2._items + 32);
                if ((((lVar2 == null) || (uVar3 = Int32.Parse(*(uint64 *)(lVar2 + 48),0), lVar6 == null))
                    || (lVar6 = WorldData.GetHero(lVar6,uVar3,0)) == null) ||
                   (((uVar3 = HeroData.GetAreaID(lVar6,1,0), lVar5 == null ||
                     (lVar5 = WorldData.GetArea(lVar5,uVar3,0)) == null) || (lVar4 == null)))) break;
                FUN_181769fe0();
              }
            }
            else {
              if (lVar6 == null) break;
              if (lVar6.Count == null) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar5 = *(int64 *)(lVar6._items + 32);
              if (((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 56)) == null) ||
                 (lVar5 = FUN_1800024b0(lVar5,uVar9,DAT_181e77160)) == null) break;
              switch(lVar5._items) {
              case 1:
              case 4:
              case 17:
              case 18:
              case 20:
              case 21:
                lVar5 = this.missionTargetDatas;
                if (lVar5 != null) {
                  if (lVar5.Count == null) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  lVar5 = *(int64 *)(lVar5._items + 32);
                  if (((lVar5 != null) && (lVar5 = *(int64 *)(lVar5 + 56)) != null) &&
                     (lVar5 = FUN_1800024b0(lVar5,uVar9,DAT_181e77160)) != null) {
                    Int32.Parse(lVar5.Count,0);
                    goto LAB_180e973a2;
                  }
                }
                throw; // [null/range check failed]
              default:
                lVar5 = FUN_1802106e0(0);
                if (((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) ||
                   (lVar5 = WorldData.Player(*(int64 *)(lVar5 + 32),0)) == null)
                throw; // [null/range check failed]
                lVar5 = HeroData.GetForce(lVar5,0,0);
                if (lVar5 != null) {
                  lVar5 = FUN_1802106e0(0);
                  if (((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) ||
                     ((lVar5 = WorldData.Player(*(int64 *)(lVar5 + 32),0), lVar5 == null ||
                      (lVar5 = HeroData.GetForce(lVar5,0,0)) == null))) throw; // [null/range check failed]
                }
                if (lVar4 == null) throw; // [null/range check failed]
                FUN_181769fe0();
                break;
              case 3:
              case 11:
              case 12:
              case 16:
              case 19:
              case 23:
              case 24:
                lVar5 = FUN_1802106e0(0);
                if (lVar5 == null) throw; // [null/range check failed]
                lVar6 = this.missionTargetDatas;
                lVar5 = *(int64 *)(lVar5 + 32);
                if (lVar6 == null) throw; // [null/range check failed]
                if (lVar6.Count == null) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar6 = *(int64 *)(lVar6._items + 32);
                if ((((lVar6 == null) || (lVar6 = *(int64 *)(lVar6 + 56)) == null) ||
                    (lVar6 = FUN_1800024b0(lVar6,uVar9,DAT_181e77160)) == null) ||
                   ((uVar3 = Int32.Parse(lVar6.Count,0), lVar5 == null ||
                    (lVar5 = WorldData.GetHero(lVar5,uVar3,0)) == null))) throw; // [null/range check failed]
                HeroData.GetAreaID(lVar5,1,0);
        LAB_180e973a2:
                if (lVar4 == null) throw; // [null/range check failed]
                FUN_181769fe0();
                break;
              case 14:
              case 15:
                lVar5 = FUN_1802106e0(0);
                if (lVar5 == null) throw; // [null/range check failed]
                lVar6 = this.missionTargetDatas;
                lVar5 = *(int64 *)(lVar5 + 32);
                if (lVar6 == null) throw; // [null/range check failed]
                if (lVar6.Count == null) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar6 = *(int64 *)(lVar6._items + 32);
                if (((((lVar6 == null) || (lVar6 = *(int64 *)(lVar6 + 56)) == null) ||
                     (lVar6 = FUN_1800024b0(lVar6,uVar9,DAT_181e77160)) == null) ||
                    ((uVar3 = Int32.Parse(lVar6.Count,0), lVar5 == null ||
                     (lVar5 = WorldData.GetForce(lVar5,uVar3,0)) == null))) || (lVar4 == null))
                throw; // [null/range check failed]
                FUN_181769fe0();
              }
            }
        LAB_180e97778:
            lVar5 = this.missionTargetDatas;
            uVar9 = uVar9 + 1;
            lVar8 = lVar8 + 1;
            if (lVar5 == null) break;
          }
        }
    }

    // Token : 0x600133F
    // RVA   : 0xE97960   Offset: 0xE96760   Length: 0x8D0
    public string GetTriggerTargetDescribe(int targetID, bool unclear)
    {
        int iVar1;
        uint uVar2;
        long lVar3;
        long lVar4;
        ulong uVar5;
        long lVar6;
        long lVar7;
        ulong uVar8;
        int iVar9;
        lVar7 = "";
        lVar6 = this.missionTargetDatas;
        if (lVar6 == null) throw; // [null/range check failed]
        if ((int)lVar6.Count <= (int)targetID) {
          return false;
        }
        if (lVar6.Count <= targetID) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        lVar4 = (int64)(int)targetID * 8 + 32;
        lVar6 = *(int64 *)(lVar4 + lVar6._items);
        if (lVar6 == null) throw; // [null/range check failed]
        switch(*(uint32 *)(lVar6 + 40)) {
        case 1:
        case 2:
        case 3:
        case 4:
          lVar6 = this.missionTargetDatas;
          if (lVar6 != null) {
            if (lVar6.Count <= targetID) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar6 = *(int64 *)(lVar4 + lVar6._items);
            if (lVar6 != null) {
              lVar6 = *(int64 *)(lVar6 + 48);
              lVar7 = FUN_1801dfd90(DAT_181e81128,1);
              if (lVar7 != null) {
                if (*(int *)(lVar7 + 24) == 0) {
                  uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1801e02d0(uVar5,0);
                }
                *(uint16 *)(lVar7 + 32) = 58;
                if (lVar6 != null) {
                  lVar6 = String.Split(lVar6,lVar7,0);
                  lVar7 = FUN_1802106e0(0);
                  if ((lVar7 != null) && (lVar7 = *(int64 *)(lVar7 + 32), lVar6 != null)) {
                    if (lVar6.Count == null) {
                      uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1801e02d0(uVar5,0);
                    }
                    uVar2 = Int32.Parse(*(uint64 *)(lVar6 + 32),0);
                    if ((lVar7 != null) && (lVar7 = WorldData.GetArea(lVar7,uVar2,0)) != null) {
                      lVar7 = AreaData.GetAreaName(lVar7,0);
                      if (unclear) {
                        lVar3 = FUN_1802106e0(0);
                        if (lVar3 == null) break;
                        lVar3 = *(int64 *)(lVar3 + 32);
                        if (lVar6.Count == null) {
                          uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1801e02d0(uVar5,0);
                        }
                        uVar2 = Int32.Parse(*(uint64 *)(lVar6 + 32),0);
                        if ((lVar3 == null) || (lVar3 = WorldData.GetArea(lVar3,uVar2,0)) == null)
                        break;
                        if (*(int *)(lVar3 + 72) == 1) {
                          uVar2 = 2;
                        }
                        else {
                          if (lVar7 == null) break;
                          uVar2 = *(uint32 *)(lVar7 + 16);
                        }
                        uVar2 = GlobalData.RandomRange(0,uVar2,0,0);
                        lVar7 = GlobalData.StringReplace(lVar7,uVar2,63,0);
                      }
                      lVar3 = this.missionTargetDatas;
                      if (lVar3 != null) {
                        if (lVar3.Count <= targetID) {
                          ThrowHelper.ThrowArgumentOutOfRangeException(0);
                        }
                        lVar4 = *(int64 *)(lVar4 + lVar3._items);
                        if (lVar4 != null) {
                          if (*(int *)(lVar4 + 40) == 2) {
                            lVar6 = String.Concat(lVar7,"内",0);
                            return lVar6;
                          }
                          if ((this.missionTargetDatas != null) &&
                             (lVar4 = FUN_1800024b0(this.missionTargetDatas,targetID,DAT_181e77460),
                             lVar4 != null)) {
                            if (*(int *)(lVar4 + 40) == 1) {
                              uVar5 = "?";
                              if (!unclear) {
                                lVar4 = *(int64 *)(*(int64 *)(DAT_181e538e8 + 184) + 0x3d0);
                                if (lVar6.Count < 2) {
                                  uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                  FUN_1801e02d0(uVar5,0);
                                }
                                uVar2 = Int32.Parse(*(uint64 *)(lVar6 + 40),0);
                                if (lVar4 == null) break;
                                uVar5 = FUN_1800024b0(lVar4,uVar2,DAT_181e86970);
                              }
                              lVar6 = String.Concat(lVar7,uVar5,"方",0);
                              return lVar6;
                            }
                            if ((this.missionTargetDatas != null) &&
                               (lVar4 = FUN_1800024b0(this.missionTargetDatas,targetID,DAT_181e77460)
                               , lVar4 != null)) {
                              if (*(int *)(lVar4 + 40) != 4) {
                                return lVar7;
                              }
                              if (!unclear) {
                                lVar4 = FUN_180210740(0);
                                if (lVar4 != null) {
                                  lVar4 = *(int64 *)(lVar4 + 224);
                                  if (lVar6.Count < 2) {
                                    uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                    FUN_1801e02d0(uVar5,0);
                                  }
                                  uVar2 = Int32.Parse(*(uint64 *)(lVar6 + 40),0);
                                  if ((lVar4 != null) &&
                                     (lVar6 = FUN_18171b450(lVar4,uVar2,DAT_181e98c78)) != null) {
                                    lVar6 = String.Concat(lVar7,lVar6.Count,0);
                                    return lVar6;
                                  }
                                }
                              }
                              else {
                                lVar4 = FUN_180210740(0);
                                if (lVar4 != null) {
                                  lVar4 = *(int64 *)(lVar4 + 224);
                                  if (lVar6.Count < 2) {
                                    uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                    FUN_1801e02d0(uVar5,0);
                                  }
                                  uVar2 = Int32.Parse(*(uint64 *)(lVar6 + 40),0);
                                  if (((lVar4 != null) &&
                                      (lVar6 = FUN_18171b450(lVar4,uVar2,DAT_181e98c78)) != null) &&
                                     (lVar6 = lVar6.Count) != null) {
                                    uVar2 = lVar6._items;
                                    iVar1 = GlobalData.RandomRange(0,uVar2,0,0);
                                    iVar9 = 0;
                                    do {
                                      if (lVar6._items <= iVar9) {
                                        lVar6 = String.Concat(lVar7,lVar6,0);
                                        return lVar6;
                                      }
                                      if (iVar9 != iVar1) {
                                        lVar6 = GlobalData.StringReplace(lVar6,iVar9,63,0);
                                      }
                                      iVar9 = iVar9 + 1;
                                    } while (lVar6 != null);
                                  }
                                }
                              }
                            }
                          }
                        }
                      }
                    }
                  }
                }
              }
            }
          }
          break;
        case 5:
          lVar6 = FUN_1802106e0(0);
          if (lVar6 != null) {
            lVar6 = *(int64 *)(lVar6 + 32);
            if (((this.missionTargetDatas != null) &&
                (lVar7 = FUN_1800024b0(this.missionTargetDatas,targetID,DAT_181e77460)) != null)
               && ((uVar2 = Int32.Parse(*(uint64 *)(lVar7 + 48),0), lVar6 != null &&
                   (lVar6 = WorldData.GetHero(lVar6,uVar2,0)) != null))) {
              uVar5 = HeroData.Name(lVar6,1,0);
              uVar8 = HeroData.AtAreaName(lVar6,0);
              uVar8 = String.Format("[{0}]",uVar8,0);
              lVar6 = String.Concat(uVar5,uVar8,0);
              return lVar6;
            }
          }
          break;
        case 6:
          lVar6 = FUN_1802106e0(0);
          if (lVar6 != null) {
            lVar6 = *(int64 *)(lVar6 + 32);
            if ((((this.missionTargetDatas != null) &&
                 (lVar7 = FUN_1800024b0(this.missionTargetDatas,targetID,DAT_181e77460)) != null)
                && (uVar2 = Int32.Parse(*(uint64 *)(lVar7 + 48),0), lVar6 != null)) &&
               (lVar6 = WorldData.GetInn(lVar6,uVar2,0)) != null) {
              return lVar6.Count;
            }
          }
          break;
        case 7:
          lVar6 = FUN_180210740(0);
          if (((this.missionTargetDatas == null) ||
              (lVar7 = FUN_1800024b0(this.missionTargetDatas,targetID,DAT_181e77460)) == null) ||
             ((uVar2 = Int32.Parse(*(uint64 *)(lVar7 + 48),0), lVar6 == null ||
              (lVar6 = GameDataController.GetSkillDataBase(lVar6,uVar2,0)) == null))) break;
          uVar8 = KungfuSkillData.Name(lVar6,0,0);
          uVar5 = "阅读{0}秘籍";
          goto LAB_180e98197;
        case 8:
          lVar6 = FUN_180210740(0);
          if ((((this.missionTargetDatas == null) ||
               (lVar7 = FUN_1800024b0(this.missionTargetDatas,targetID,DAT_181e77460)) == null)
              || (uVar2 = Int32.Parse(*(uint64 *)(lVar7 + 48),0), lVar6 == null)) ||
             (lVar6 = GameDataController.GetSkillDataBase(lVar6,uVar2,0)) == null) break;
          uVar8 = KungfuSkillData.Name(lVar6,0,0);
          uVar5 = "练习{0}";
        LAB_180e98197:
          lVar7 = String.Format(uVar5,uVar8,0);
        switchD_180e97aae_default:
          return lVar7;
        default:
          goto switchD_180e97aae_default;
        }
    }

    // Token : 0x6001340
    // RVA   : 0xE94220   Offset: 0xE93020   Length: 0x2DEC
    public string GetMissionTargetDescribe(bool showFinishRate)
    {
        var pStatics = *(int64*)(DAT_181e538e8 + 184);
        long lVar1;
        bool cVar2;
        uint uVar3;
        long lVar4;
        long lVar5;
        ulong uVar6;
        ulong uVar7;
        long lVar9;
        ulong uVar10;
        int iVar11;
        uint[] local_res8 = new uint[2];
        bool local_res10;
        uint[] local_res20 = new uint[2];
        uint local_a8;
        uint local_a4;
        uint local_a0;
        uint32 local_9c;
        uint32 local_98;
        uint32 local_94;
        uint32 local_90;
        uint32 local_8c;
        uint32 local_88;
        uint32 local_84;
        uint32 local_80;
        uint32 local_7c;
        uint32 local_78;
        uint32 local_74;
        uint32 local_70;
        uint32 local_6c;
        uint32 local_68;
        uint32 local_64;
        uint32 local_60;
        uint32 local_5c;
        uint32 local_58;
        uint32 local_54;
        uint32 local_50;
        int local_4c;
        uint32 local_48 [4];
        local_res10 = showFinishRate;
        iVar11 = 0;
        lVar5 = "";
        while (lVar4 = this.missionTargetDatas) != null {
          if (*(int *)(lVar4 + 24) == 0) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar4 = *(int64 *)(*(int64 *)(lVar4 + 16) + 32);
          if ((lVar4 == null) || (lVar4 = *(int64 *)(lVar4 + 56)) == null) break;
          if (*(int *)(lVar4 + 24) <= iVar11) {
            return lVar5;
          }
          lVar4 = lVar5;
          if (0 < iVar11) {
            lVar4 = String.Concat(lVar5,"\n",0);
          }
          lVar5 = this.missionTargetDatas;
          if (lVar5 == null) {
        LAB_180e97006:
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          if (lVar5.Count == null) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar5 = *(int64 *)(lVar5._items + 32);
          if (((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 56)) == null) ||
             (lVar5 = FUN_1800024b0(lVar5,iVar11)) == null) goto LAB_180e97006;
          switch(lVar5._items) {
          case 1:
            lVar5 = FUN_1802106e0(0);
            if (lVar5 == null) {
        LAB_180e96eb6:
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            lVar9 = this.missionTargetDatas;
            lVar5 = *(int64 *)(lVar5 + 32);
            if (lVar9 == null) goto LAB_180e96eb6;
            if (lVar9.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar9 = *(int64 *)(lVar9._items + 32);
            if (((lVar9 == null) || (lVar9 = *(int64 *)(lVar9 + 56)) == null) ||
               ((lVar9 = FUN_1800024b0(lVar9,iVar11,DAT_181e77160), lVar9 == null ||
                ((uVar3 = Int32.Parse(lVar9.Count,0), lVar5 == null ||
                 (lVar5 = WorldData.GetArea(lVar5,uVar3,0)) == null))))) goto LAB_180e96eb6;
            uVar10 = AreaData.GetAreaName(lVar5,0);
            lVar5 = this.missionTargetDatas;
            if (lVar5 == null) goto LAB_180e96eb6;
            if (lVar5.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar5 = *(int64 *)(lVar5._items + 32);
            if (((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 56)) == null) ||
               (lVar5 = FUN_1800024b0(lVar5,iVar11,DAT_181e77160)) == null) goto LAB_180e96eb6;
            local_res8[0] = *(uint32 *)(lVar5 + 40);
            uVar7 = il2cpp_value_box(DAT_181e82730,local_res8);
            uVar6 = "在{0}分舵探索{1}次";
            break;
          case 2:
            lVar5 = this.missionTargetDatas;
            if (lVar5 == null) {
        LAB_180e96ebc:
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            if (lVar5.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar5 = *(int64 *)(lVar5._items + 32);
            if (((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 56)) == null) ||
               (lVar5 = FUN_1800024b0(lVar5,iVar11,DAT_181e77160)) == null) goto LAB_180e96ebc;
            local_res20[0] = *(uint32 *)(lVar5 + 40);
            uVar10 = il2cpp_value_box(DAT_181e82730,local_res20);
            lVar5 = this.missionTargetDatas;
            lVar9 = *(int64 *)(pStatics + 0x440);
            if (lVar5 == null) goto LAB_180e96ebc;
            if (lVar5.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar5 = *(int64 *)(lVar5._items + 32);
            if ((((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 56)) == null) ||
                (lVar5 = FUN_1800024b0(lVar5,iVar11,DAT_181e77160)) == null) || (lVar9 == null))
            goto LAB_180e96ebc;
            uVar7 = FUN_1800024b0(lVar9,*(uint32 *)(lVar5 + 32),DAT_181e86970);
            uVar6 = "为门派获取{0}{1}";
            break;
          case 3:
            lVar5 = FUN_1802106e0(0);
            if (lVar5 == null) goto LAB_180e97006;
            lVar9 = this.missionTargetDatas;
            lVar5 = *(int64 *)(lVar5 + 32);
            if (lVar9 == null) goto LAB_180e97006;
            if (lVar9.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar9 = *(int64 *)(lVar9._items + 32);
            if ((((lVar9 == null) || (lVar9 = *(int64 *)(lVar9 + 56)) == null) ||
                (lVar9 = FUN_1800024b0(lVar9,iVar11,DAT_181e77160)) == null) ||
               (uVar3 = Int32.Parse(lVar9.Count,0), lVar5 == null)) goto LAB_180e97006;
            lVar5 = WorldData.GetHero(lVar5,uVar3,0);
            if (lVar5 == null) {
              return "任务对象已死亡";
            }
            lVar5 = FUN_1802106e0(0);
            if (lVar5 == null) {
        LAB_180e96ec2:
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            lVar9 = this.missionTargetDatas;
            lVar5 = *(int64 *)(lVar5 + 32);
            if (lVar9 == null) goto LAB_180e96ec2;
            if (lVar9.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar9 = *(int64 *)(lVar9._items + 32);
            if (((lVar9 == null) || (lVar9 = *(int64 *)(lVar9 + 56)) == null) ||
               ((lVar9 = FUN_1800024b0(lVar9,iVar11,DAT_181e77160), lVar9 == null ||
                ((uVar3 = Int32.Parse(lVar9.Count,0), lVar5 == null ||
                 (lVar5 = WorldData.GetHero(lVar5,uVar3,0)) == null))))) goto LAB_180e96ec2;
            uVar10 = HeroData.Name(lVar5,1,0);
            lVar5 = this.missionTargetDatas;
            if (lVar5 == null) goto LAB_180e96ec2;
            if (lVar5.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar5 = *(int64 *)(lVar5._items + 32);
            if (((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 56)) == null) ||
               (lVar5 = FUN_1800024b0(lVar5,iVar11,DAT_181e77160)) == null) goto LAB_180e96ec2;
            local_a8 = *(uint32 *)(lVar5 + 40);
            uVar7 = il2cpp_value_box(DAT_181e82730,&local_a8);
            uVar6 = "增进与{0}的好感{1}点";
            break;
          case 4:
            lVar5 = FUN_1802106e0(0);
            if (lVar5 == null) {
        LAB_180e96ec8:
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            lVar9 = this.missionTargetDatas;
            lVar5 = *(int64 *)(lVar5 + 32);
            if (lVar9 == null) goto LAB_180e96ec8;
            if (lVar9.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar9 = *(int64 *)(lVar9._items + 32);
            if (((lVar9 == null) || (lVar9 = *(int64 *)(lVar9 + 56)) == null) ||
               ((lVar9 = FUN_1800024b0(lVar9,iVar11,DAT_181e77160), lVar9 == null ||
                ((uVar3 = Int32.Parse(lVar9.Count,0), lVar5 == null ||
                 (lVar5 = WorldData.GetArea(lVar5,uVar3,0)) == null))))) goto LAB_180e96ec8;
            uVar10 = AreaData.GetAreaName(lVar5,0);
            lVar5 = this.missionTargetDatas;
            lVar9 = *(int64 *)(pStatics + 0x628);
            if (lVar5 == null) goto LAB_180e96ec8;
            if (lVar5.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar5 = *(int64 *)(lVar5._items + 32);
            if ((((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 56)) == null) ||
                (lVar5 = FUN_1800024b0(lVar5,iVar11,DAT_181e77160)) == null) || (lVar9 == null))
            goto LAB_180e96ec8;
            uVar6 = FUN_1800024b0(lVar9,*(uint32 *)(lVar5 + 32),DAT_181e86970);
            lVar5 = this.missionTargetDatas;
            if (lVar5 == null) goto LAB_180e96ec8;
            if (lVar5.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar5 = *(int64 *)(lVar5._items + 32);
            if (((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 56)) == null) ||
               (lVar5 = FUN_1800024b0(lVar5,iVar11,DAT_181e77160)) == null) goto LAB_180e96ec8;
            local_a4 = *(uint32 *)(lVar5 + 40);
            uVar7 = il2cpp_value_box(DAT_181e82730,&local_a4);
            uVar10 = String.Format("提升{0}的{1}{2}点",uVar10,uVar6,uVar7,0);
            lVar5 = String.Concat(lVar4,uVar10,0);
            goto LAB_180e96c34;
          case 5:
            lVar5 = this.missionTargetDatas;
            if (lVar5 == null) {
        LAB_180e96ece:
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            if (lVar5.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar5 = *(int64 *)(lVar5._items + 32);
            if (((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 56)) == null) ||
               (lVar5 = FUN_1800024b0(lVar5,iVar11,DAT_181e77160)) == null) goto LAB_180e96ece;
            local_a0 = *(uint32 *)(lVar5 + 40);
            uVar10 = il2cpp_value_box(DAT_181e82730,&local_a0);
            lVar5 = this.missionTargetDatas;
            lVar9 = *(int64 *)(pStatics + 0x4d8);
            if (lVar5 == null) goto LAB_180e96ece;
            if (lVar5.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar5 = *(int64 *)(lVar5._items + 32);
            if ((((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 56)) == null) ||
                (lVar5 = FUN_1800024b0(lVar5,iVar11,DAT_181e77160)) == null) || (lVar9 == null))
            goto LAB_180e96ece;
            uVar7 = FUN_1800024b0(lVar9,*(uint32 *)(lVar5 + 32),DAT_181e86970);
            uVar6 = "制作价值{0}的{1}";
            break;
          case 6:
            lVar5 = this.missionTargetDatas;
            if (lVar5 == null) {
        LAB_180e96ed4:
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            if (lVar5.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar5 = *(int64 *)(lVar5._items + 32);
            if (((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 56)) == null) ||
               (lVar5 = FUN_1800024b0(lVar5,iVar11,DAT_181e77160)) == null) goto LAB_180e96ed4;
            local_9c = *(uint32 *)(lVar5 + 40);
            uVar10 = il2cpp_value_box(DAT_181e82730,&local_9c);
            lVar5 = this.missionTargetDatas;
            lVar9 = *(int64 *)(pStatics + 0x3e0);
            if (lVar5 == null) goto LAB_180e96ed4;
            if (lVar5.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar5 = *(int64 *)(lVar5._items + 32);
            if ((((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 56)) == null) ||
                (lVar5 = FUN_1800024b0(lVar5,iVar11,DAT_181e77160)) == null) || (lVar9 == null))
            goto LAB_180e96ed4;
            uVar6 = FUN_1800024b0(lVar9,*(uint32 *)(lVar5 + 32),DAT_181e86970);
            lVar5 = this.missionTargetDatas;
            if (lVar5 == null) goto LAB_180e96ed4;
            if (lVar5.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar5 = *(int64 *)(lVar5._items + 32);
            if (((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 56)) == null) ||
               (lVar5 = FUN_1800024b0(lVar5,iVar11,DAT_181e77160)) == null) goto LAB_180e96ed4;
            uVar7 = GlobalData.GenerateRareLvColorText(uVar6,*(uint32 *)(lVar5 + 32),0);
            uVar6 = "招募{0}名{1}";
            break;
          case 7:
            lVar5 = this.missionTargetDatas;
            if (lVar5 == null) {
        LAB_180e96eda:
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            if (lVar5.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar5 = *(int64 *)(lVar5._items + 32);
            if (((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 56)) == null) ||
               (lVar5 = FUN_1800024b0(lVar5,iVar11,DAT_181e77160)) == null) goto LAB_180e96eda;
            local_98 = *(uint32 *)(lVar5 + 40);
            uVar10 = il2cpp_value_box(DAT_181e82730,&local_98);
            lVar5 = this.missionTargetDatas;
            lVar9 = *(int64 *)(pStatics + 0x518);
            if (lVar5 == null) goto LAB_180e96eda;
            if (lVar5.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar5 = *(int64 *)(lVar5._items + 32);
            if (((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 56)) == null) ||
               ((lVar5 = FUN_1800024b0(lVar5,iVar11,DAT_181e77160), lVar5 == null || (lVar9 == null))))
            goto LAB_180e96eda;
            uVar6 = FUN_1800024b0(lVar9,*(uint32 *)(lVar5 + 32),DAT_181e86970);
            lVar5 = this.missionTargetDatas;
            if (lVar5 == null) goto LAB_180e96eda;
            if (lVar5.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar5 = *(int64 *)(lVar5._items + 32);
            if (((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 56)) == null) ||
               (lVar5 = FUN_1800024b0(lVar5,iVar11,DAT_181e77160)) == null) goto LAB_180e96eda;
            uVar7 = GlobalData.GenerateRareLvColorText(uVar6,*(uint32 *)(lVar5 + 32),0);
            uVar6 = "学习{0}门{1}武功";
            break;
          case 8:
            plVar8 = (int64 *)FUN_1801dfd90(DAT_181e84278,4);
            lVar9 = FUN_180210740(0);
            lVar5 = this.missionTargetDatas;
            if (lVar5 == null) {
        LAB_180e96f60:
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            if (lVar5.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar5 = *(int64 *)(lVar5._items + 32);
            if (((((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 56)) == null) ||
                 (lVar5 = FUN_1800024b0(lVar5,iVar11,DAT_181e77160)) == null) ||
                ((uVar3 = Int32.Parse(lVar5.Count,0), lVar9 == null ||
                 (lVar5 = GameDataController.GetSkillDataBase(lVar9,uVar3,0)) == null))) ||
               (lVar5 = KungfuSkillData.Name(lVar5,1,0), plVar8 == (int64 *)0)) goto LAB_180e96f60;
            if ((lVar5 != null) &&
               (lVar9 = il2cpp_internal(lVar5,*(uint64 *)(*plVar8 + 64))) == null) {
              uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar10,0);
            }
            if ((int)plVar8[3] == 0) {
              uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar10,0);
            }
            plVar8[4] = lVar5;
            il2cpp_internal(plVar8 + 4,lVar5);
            lVar5 = FUN_1802106e0(0);
            if ((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) goto LAB_180e96f60;
            lVar9 = WorldData.Player(*(int64 *)(lVar5 + 32),0);
            lVar5 = this.missionTargetDatas;
            if (lVar5 == null) goto LAB_180e96f60;
            if (lVar5.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar5 = *(int64 *)(lVar5._items + 32);
            if ((((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 56)) == null) ||
                (lVar5 = FUN_1800024b0(lVar5,iVar11,DAT_181e77160)) == null) ||
               ((uVar3 = Int32.Parse(lVar5.Count,0), lVar9 == null ||
                (lVar5 = HeroData.FindSkill(lVar9,uVar3,0)) == null))) goto LAB_180e96f60;
            local_94 = *(uint32 *)(lVar5 + 20);
            lVar5 = il2cpp_value_box(DAT_181e60808,&local_94);
            if ((lVar5 != null) &&
               (lVar9 = il2cpp_internal(lVar5,*(uint64 *)(*plVar8 + 64))) == null) {
              uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar10,0);
            }
            if (*(uint32 *)(plVar8 + 3) < 2) {
              uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar10,0);
            }
            plVar8[5] = lVar5;
            il2cpp_internal(plVar8 + 5,lVar5);
            lVar5 = this.missionTargetDatas;
            if (lVar5 == null) goto LAB_180e96f60;
            if (lVar5.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar5 = *(int64 *)(lVar5._items + 32);
            if (((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 56)) == null) ||
               (lVar5 = FUN_1800024b0(lVar5,iVar11,DAT_181e77160)) == null) goto LAB_180e96f60;
            local_90 = *(uint32 *)(lVar5 + 40);
            lVar5 = il2cpp_value_box(DAT_181e82730,&local_90);
            if ((lVar5 != null) &&
               (lVar9 = il2cpp_internal(lVar5,*(uint64 *)(*plVar8 + 64))) == null) {
              uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar10,0);
            }
            if (*(uint32 *)(plVar8 + 3) < 3) {
              uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar10,0);
            }
            plVar8[6] = lVar5;
            il2cpp_internal(plVar8 + 6,lVar5);
            lVar5 = *(int64 *)(pStatics + 0x4a8);
            lVar9 = this.missionTargetDatas;
            lVar1 = *(int64 *)(*(int64 *)(DAT_181e528f8 + 184) + 32);
            if (lVar9 == null) goto LAB_180e96f60;
            if (lVar9.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar9 = *(int64 *)(lVar9._items + 32);
            if ((((lVar9 == null) || (lVar9 = *(int64 *)(lVar9 + 56)) == null) ||
                (lVar9 = FUN_1800024b0(lVar9,iVar11,DAT_181e77160)) == null) ||
               (((uVar3 = Int32.Parse(lVar9.Count,0), lVar1 == null ||
                 (lVar9 = GameDataController.GetSkillDataBase(lVar1,uVar3,0)) == null) ||
                (lVar5 == null)))) goto LAB_180e96f60;
            lVar5 = FUN_1800024b0(lVar5,*(uint32 *)(lVar9 + 48));
            if ((lVar5 != null) &&
               (lVar9 = il2cpp_internal(lVar5,*(uint64 *)(*plVar8 + 64))) == null) {
              uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar10,0);
            }
            if (*(uint32 *)(plVar8 + 3) < 4) {
              uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar10,0);
            }
            plVar8[7] = lVar5;
            il2cpp_internal(plVar8 + 7,lVar5);
            uVar10 = String.Format("{3}{0}({1}级)提升{2}级",plVar8);
            lVar5 = String.Concat(lVar4,uVar10,0);
            goto LAB_180e96c34;
          case 9:
            lVar5 = this.missionTargetDatas;
            lVar9 = *(int64 *)(pStatics + 0x4b8);
            if (lVar5 == null) {
        LAB_180e96f66:
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            if (lVar5.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar5 = *(int64 *)(lVar5._items + 32);
            if ((((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 56)) == null) ||
                (lVar5 = FUN_1800024b0(lVar5,iVar11,DAT_181e77160)) == null) ||
               (uVar3 = Int32.Parse(lVar5.Count,0), lVar9 == null)) goto LAB_180e96f66;
            uVar10 = FUN_1800024b0(lVar9,uVar3,DAT_181e86970);
            lVar5 = FUN_1802106e0(0);
            if (((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) ||
               (lVar5 = WorldData.Player(*(int64 *)(lVar5 + 32),0)) == null) goto LAB_180e96f66;
            lVar9 = this.missionTargetDatas;
            lVar5 = *(int64 *)(lVar5 + 0x158);
            if (lVar9 == null) goto LAB_180e96f66;
            if (lVar9.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar9 = *(int64 *)(lVar9._items + 32);
            if ((((lVar9 == null) || (lVar9 = *(int64 *)(lVar9 + 56)) == null) ||
                (lVar9 = FUN_1800024b0(lVar9,iVar11,DAT_181e77160)) == null) ||
               (uVar3 = Int32.Parse(lVar9.Count,0), lVar5 == null)) goto LAB_180e96f66;
            local_8c = FUN_1800024e0(lVar5,uVar3,DAT_181e83530);
            uVar6 = il2cpp_value_box(DAT_181e82730,&local_8c);
            lVar5 = this.missionTargetDatas;
            if (lVar5 == null) goto LAB_180e96f66;
            if (lVar5.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar5 = *(int64 *)(lVar5._items + 32);
            if (((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 56)) == null) ||
               (lVar5 = FUN_1800024b0(lVar5,iVar11,DAT_181e77160)) == null) goto LAB_180e96f66;
            local_88 = *(uint32 *)(lVar5 + 40);
            uVar7 = il2cpp_value_box(DAT_181e82730,&local_88);
            uVar10 = String.Format("{0}({1}级)提升{2}级",uVar10,uVar6,uVar7,0);
            lVar5 = String.Concat(lVar4,uVar10,0);
            goto LAB_180e96c34;
          case 10:
            lVar5 = this.missionTargetDatas;
            if (lVar5 == null) {
        LAB_180e96f6c:
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            if (lVar5.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar5 = *(int64 *)(lVar5._items + 32);
            if (((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 56)) == null) ||
               (lVar5 = FUN_1800024b0(lVar5,iVar11,DAT_181e77160)) == null) goto LAB_180e96f6c;
            local_84 = *(uint32 *)(lVar5 + 40);
            uVar10 = il2cpp_value_box(DAT_181e82730,&local_84);
            lVar9 = FUN_180210740(0);
            lVar5 = this.missionTargetDatas;
            if (lVar5 == null) goto LAB_180e96f6c;
            if (lVar5.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar5 = *(int64 *)(lVar5._items + 32);
            if ((((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 56)) == null) ||
                (lVar5 = FUN_1800024b0(lVar5,iVar11,DAT_181e77160)) == null) ||
               ((uVar3 = Int32.Parse(lVar5.Count,0), lVar9 == null ||
                (lVar5 = GameDataController.GetSkillDataBase(lVar9,uVar3,0)) == null)))
            goto LAB_180e96f6c;
            uVar7 = KungfuSkillData.Name(lVar5,1,0);
            uVar6 = "编纂{0}本{1}秘籍";
            break;
          case 11:
            lVar5 = FUN_1802106e0(0);
            if (lVar5 == null) goto LAB_180e97006;
            lVar9 = this.missionTargetDatas;
            lVar5 = *(int64 *)(lVar5 + 32);
            if (lVar9 == null) goto LAB_180e97006;
            if (lVar9.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar9 = *(int64 *)(lVar9._items + 32);
            if ((((lVar9 == null) || (lVar9 = *(int64 *)(lVar9 + 56)) == null) ||
                (lVar9 = FUN_1800024b0(lVar9,iVar11,DAT_181e77160)) == null) ||
               (uVar3 = Int32.Parse(lVar9.Count,0), lVar5 == null)) goto LAB_180e97006;
            lVar5 = WorldData.GetHero(lVar5,uVar3,0);
            if (lVar5 == null) {
              return "任务对象已死亡";
            }
            lVar5 = FUN_1802106e0(0);
            if (lVar5 == null) {
        LAB_180e96f72:
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            lVar9 = this.missionTargetDatas;
            lVar5 = *(int64 *)(lVar5 + 32);
            if (lVar9 == null) goto LAB_180e96f72;
            if (lVar9.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar9 = *(int64 *)(lVar9._items + 32);
            if (((lVar9 == null) || (lVar9 = *(int64 *)(lVar9 + 56)) == null) ||
               ((lVar9 = FUN_1800024b0(lVar9,iVar11,DAT_181e77160), lVar9 == null ||
                ((uVar3 = Int32.Parse(lVar9.Count,0), lVar5 == null ||
                 (lVar5 = WorldData.GetHero(lVar5,uVar3,0)) == null))))) goto LAB_180e96f72;
            uVar10 = HeroData.Name(lVar5,1,0);
            lVar5 = this.missionTargetDatas;
            if (lVar5 == null) goto LAB_180e96f72;
            if (lVar5.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar5 = *(int64 *)(lVar5._items + 32);
            if (((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 56)) == null) ||
               (lVar5 = FUN_1800024b0(lVar5,iVar11,DAT_181e77160)) == null) goto LAB_180e96f72;
            local_80 = *(uint32 *)(lVar5 + 40);
            uVar7 = il2cpp_value_box(DAT_181e82730,&local_80);
            uVar6 = "与{0}切磋获胜{1}次";
            break;
          case 12:
            lVar5 = FUN_1802106e0(0);
            if (lVar5 == null) goto LAB_180e97006;
            lVar9 = this.missionTargetDatas;
            lVar5 = *(int64 *)(lVar5 + 32);
            if (lVar9 == null) goto LAB_180e97006;
            if (lVar9.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar9 = *(int64 *)(lVar9._items + 32);
            if (((lVar9 == null) || (lVar9 = *(int64 *)(lVar9 + 56)) == null) ||
               ((lVar9 = FUN_1800024b0(lVar9,iVar11,DAT_181e77160), lVar9 == null ||
                (uVar3 = Int32.Parse(lVar9.Count,0), lVar5 == null)))) goto LAB_180e97006;
            lVar5 = WorldData.GetHero(lVar5,uVar3,0);
            if (lVar5 == null) {
              return "任务对象已死亡";
            }
            lVar5 = FUN_1802106e0(0);
            if (lVar5 == null) {
        LAB_180e96f78:
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            lVar9 = this.missionTargetDatas;
            lVar5 = *(int64 *)(lVar5 + 32);
            if (lVar9 == null) goto LAB_180e96f78;
            if (lVar9.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar9 = *(int64 *)(lVar9._items + 32);
            if ((((lVar9 == null) || (lVar9 = *(int64 *)(lVar9 + 56)) == null) ||
                (lVar9 = FUN_1800024b0(lVar9,iVar11,DAT_181e77160)) == null) ||
               ((uVar3 = Int32.Parse(lVar9.Count,0), lVar5 == null ||
                (lVar5 = WorldData.GetHero(lVar5,uVar3,0)) == null))) goto LAB_180e96f78;
            uVar10 = HeroData.Name(lVar5,1,0);
            lVar5 = this.missionTargetDatas;
            if (lVar5 == null) goto LAB_180e96f78;
            if (lVar5.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar5 = *(int64 *)(lVar5._items + 32);
            if (((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 56)) == null) ||
               (lVar5 = FUN_1800024b0(lVar5,iVar11,DAT_181e77160)) == null) goto LAB_180e96f78;
            local_7c = *(uint32 *)(lVar5 + 40);
            uVar7 = il2cpp_value_box(DAT_181e82730,&local_7c);
            uVar6 = "向{0}传授{1}门武功";
            break;
          case 13:
            lVar5 = this.missionTargetDatas;
            if (lVar5 == null) {
        LAB_180e96f7e:
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            if (lVar5.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar5 = *(int64 *)(lVar5._items + 32);
            if (((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 56)) == null) ||
               (lVar5 = FUN_1800024b0(lVar5,iVar11,DAT_181e77160)) == null) goto LAB_180e96f7e;
            local_78 = *(uint32 *)(lVar5 + 40);
            uVar10 = il2cpp_value_box(DAT_181e82730,&local_78);
            lVar5 = this.missionTargetDatas;
            lVar9 = *(int64 *)(pStatics + 0x518);
            if (lVar5 == null) goto LAB_180e96f7e;
            if (lVar5.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar5 = *(int64 *)(lVar5._items + 32);
            if (((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 56)) == null) ||
               ((lVar5 = FUN_1800024b0(lVar5,iVar11,DAT_181e77160), lVar5 == null || (lVar9 == null))))
            goto LAB_180e96f7e;
            uVar6 = FUN_1800024b0(lVar9,*(uint32 *)(lVar5 + 32),DAT_181e86970);
            lVar5 = this.missionTargetDatas;
            if (lVar5 == null) goto LAB_180e96f7e;
            if (lVar5.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar5 = *(int64 *)(lVar5._items + 32);
            if (((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 56)) == null) ||
               (lVar5 = FUN_1800024b0(lVar5,iVar11,DAT_181e77160)) == null) goto LAB_180e96f7e;
            uVar7 = GlobalData.GenerateRareLvColorText(uVar6,*(uint32 *)(lVar5 + 32),0);
            uVar6 = "搜集{0}本{1}秘籍";
            break;
          case 14:
            lVar5 = FUN_1802106e0(0);
            if (lVar5 == null) {
        LAB_180e96f84:
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            lVar9 = this.missionTargetDatas;
            lVar5 = *(int64 *)(lVar5 + 32);
            if (lVar9 == null) goto LAB_180e96f84;
            if (lVar9.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar9 = *(int64 *)(lVar9._items + 32);
            if ((((lVar9 == null) || (lVar9 = *(int64 *)(lVar9 + 56)) == null) ||
                (lVar9 = FUN_1800024b0(lVar9,iVar11,DAT_181e77160)) == null) ||
               ((uVar3 = Int32.Parse(lVar9.Count,0), lVar5 == null ||
                (lVar5 = WorldData.GetForce(lVar5,uVar3,0)) == null))) goto LAB_180e96f84;
            uVar10 = ForceData.GetForceName(lVar5,1,0);
            lVar5 = this.missionTargetDatas;
            if (lVar5 == null) goto LAB_180e96f84;
            if (lVar5.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar5 = *(int64 *)(lVar5._items + 32);
            if (((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 56)) == null) ||
               (lVar5 = FUN_1800024b0(lVar5,iVar11,DAT_181e77160)) == null) goto LAB_180e96f84;
            local_74 = *(uint32 *)(lVar5 + 40);
            uVar7 = il2cpp_value_box(DAT_181e82730,&local_74);
            uVar6 = "提升与{0}的关系{1}点";
            break;
          case 15:
            lVar5 = FUN_1802106e0(0);
            if (lVar5 == null) {
        LAB_180e96f8a:
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            lVar9 = this.missionTargetDatas;
            lVar5 = *(int64 *)(lVar5 + 32);
            if (lVar9 == null) goto LAB_180e96f8a;
            if (lVar9.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar9 = *(int64 *)(lVar9._items + 32);
            if ((((lVar9 == null) || (lVar9 = *(int64 *)(lVar9 + 56)) == null) ||
                (lVar9 = FUN_1800024b0(lVar9,iVar11,DAT_181e77160)) == null) ||
               ((uVar3 = Int32.Parse(lVar9.Count,0), lVar5 == null ||
                (lVar5 = WorldData.GetForce(lVar5,uVar3,0)) == null))) goto LAB_180e96f8a;
            uVar10 = ForceData.GetForceName(lVar5,1,0);
            lVar5 = this.missionTargetDatas;
            if (lVar5 == null) goto LAB_180e96f8a;
            if (lVar5.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar5 = *(int64 *)(lVar5._items + 32);
            if (((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 56)) == null) ||
               (lVar5 = FUN_1800024b0(lVar5,iVar11,DAT_181e77160)) == null) goto LAB_180e96f8a;
            local_70 = *(uint32 *)(lVar5 + 40);
            uVar7 = il2cpp_value_box(DAT_181e82730,&local_70);
            uVar6 = "降低与{0}的关系{1}点";
            break;
          case 16:
            lVar5 = FUN_1802106e0(0);
            if (lVar5 == null) goto LAB_180e97006;
            lVar9 = this.missionTargetDatas;
            lVar5 = *(int64 *)(lVar5 + 32);
            if (lVar9 == null) goto LAB_180e97006;
            if (lVar9.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar9 = *(int64 *)(lVar9._items + 32);
            if (((lVar9 == null) || (lVar9 = *(int64 *)(lVar9 + 56)) == null) ||
               ((lVar9 = FUN_1800024b0(lVar9,iVar11,DAT_181e77160), lVar9 == null ||
                (uVar3 = Int32.Parse(lVar9.Count,0), lVar5 == null)))) goto LAB_180e97006;
            lVar5 = WorldData.GetHero(lVar5,uVar3,0);
            if (lVar5 == null) {
              return "任务对象已死亡";
            }
            lVar5 = FUN_1802106e0(0);
            if (lVar5 == null) {
        LAB_180e96f90:
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            lVar9 = this.missionTargetDatas;
            lVar5 = *(int64 *)(lVar5 + 32);
            if (lVar9 == null) goto LAB_180e96f90;
            if (lVar9.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar9 = *(int64 *)(lVar9._items + 32);
            if ((((lVar9 == null) || (lVar9 = *(int64 *)(lVar9 + 56)) == null) ||
                (lVar9 = FUN_1800024b0(lVar9,iVar11,DAT_181e77160)) == null) ||
               ((uVar3 = Int32.Parse(lVar9.Count,0), lVar5 == null ||
                (lVar5 = WorldData.GetHero(lVar5,uVar3,0)) == null))) goto LAB_180e96f90;
            uVar10 = HeroData.GetHeroName(lVar5,0,0);
            lVar5 = this.missionTargetDatas;
            if (lVar5 == null) goto LAB_180e96f90;
            if (lVar5.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar5 = *(int64 *)(lVar5._items + 32);
            if (((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 56)) == null) ||
               (lVar5 = FUN_1800024b0(lVar5,iVar11,DAT_181e77160)) == null) goto LAB_180e96f90;
            local_6c = *(uint32 *)(lVar5 + 40);
            uVar7 = il2cpp_value_box(DAT_181e82730,&local_6c);
            uVar6 = "袭击{0}{1}次";
            break;
          case 17:
            lVar5 = FUN_1802106e0(0);
            if (lVar5 == null) {
        LAB_180e96f96:
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            lVar9 = this.missionTargetDatas;
            lVar5 = *(int64 *)(lVar5 + 32);
            if (lVar9 == null) goto LAB_180e96f96;
            if (lVar9.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar9 = *(int64 *)(lVar9._items + 32);
            if ((((lVar9 == null) || (lVar9 = *(int64 *)(lVar9 + 56)) == null) ||
                (lVar9 = FUN_1800024b0(lVar9,iVar11,DAT_181e77160)) == null) ||
               ((uVar3 = Int32.Parse(lVar9.Count,0), lVar5 == null ||
                (lVar5 = WorldData.GetArea(lVar5,uVar3,0)) == null))) goto LAB_180e96f96;
            uVar10 = AreaData.GetAreaName(lVar5,0);
            lVar5 = this.missionTargetDatas;
            lVar9 = *(int64 *)(pStatics + 0x628);
            if (lVar5 == null) goto LAB_180e96f96;
            if (lVar5.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar5 = *(int64 *)(lVar5._items + 32);
            if (((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 56)) == null) ||
               ((lVar5 = FUN_1800024b0(lVar5,iVar11,DAT_181e77160), lVar5 == null || (lVar9 == null))))
            goto LAB_180e96f96;
            uVar6 = FUN_1800024b0(lVar9,*(uint32 *)(lVar5 + 32),DAT_181e86970);
            if ((((this.missionTargetDatas == null) ||
                 (lVar5 = FUN_1800024b0(this.missionTargetDatas,0,DAT_181e77460)) == null) ||
                (*(int64 *)(lVar5 + 56) == 0)) ||
               (lVar5 = FUN_1800024b0(*(int64 *)(lVar5 + 56),iVar11,DAT_181e77160)) == null)
            goto LAB_180e96f96;
            local_68 = *(uint32 *)(lVar5 + 40);
            uVar7 = il2cpp_value_box(DAT_181e82730,&local_68);
            uVar10 = String.Format("降低{0}的{1}{2}点",uVar10,uVar6,uVar7,0);
            lVar5 = String.Concat(lVar4,uVar10,0);
            goto LAB_180e96c34;
          case 18:
            lVar5 = FUN_1802106e0(0);
            if (lVar5 == null) {
        LAB_180e96f9c:
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            lVar5 = *(int64 *)(lVar5 + 32);
            if ((((this.missionTargetDatas == null) ||
                 (lVar9 = FUN_1800024b0(this.missionTargetDatas,0,DAT_181e77460)) == null) ||
                (*(int64 *)(lVar9 + 56) == 0)) ||
               (((lVar9 = FUN_1800024b0(*(int64 *)(lVar9 + 56),iVar11,DAT_181e77160), lVar9 == null ||
                 (uVar3 = Int32.Parse(lVar9.Count,0), lVar5 == null)) ||
                (lVar5 = WorldData.GetArea(lVar5,uVar3,0)) == null))) goto LAB_180e96f9c;
            uVar10 = AreaData.GetAreaName(lVar5,0);
            if (((this.missionTargetDatas == null) ||
                (lVar5 = FUN_1800024b0(this.missionTargetDatas,0,DAT_181e77460)) == null) ||
               ((*(int64 *)(lVar5 + 56) == 0 ||
                (lVar5 = FUN_1800024b0(*(int64 *)(lVar5 + 56),iVar11,DAT_181e77160)) == null)))
            goto LAB_180e96f9c;
            local_64 = *(uint32 *)(lVar5 + 40);
            uVar7 = il2cpp_value_box(DAT_181e82730,&local_64);
            uVar6 = "窃取{0}资源{1}次";
            break;
          case 19:
            lVar5 = FUN_1802106e0(0);
            if (lVar5 == null) throw; // [null/range check failed]
            lVar5 = *(int64 *)(lVar5 + 32);
            if ((((this.missionTargetDatas == null) ||
                 (lVar9 = FUN_1800024b0(this.missionTargetDatas,0,DAT_181e77460)) == null) ||
                (*(int64 *)(lVar9 + 56) == 0)) ||
               ((lVar9 = FUN_1800024b0(*(int64 *)(lVar9 + 56),iVar11,DAT_181e77160), lVar9 == null ||
                (uVar3 = Int32.Parse(lVar9.Count,0), lVar5 == null)))) throw; // [null/range check failed]
            lVar5 = WorldData.GetHero(lVar5,uVar3,0);
            if (lVar5 == null) {
              return "任务对象已死亡";
            }
            lVar5 = FUN_1802106e0(0);
            if (lVar5 == null) {
        LAB_180e96fa2:
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            lVar5 = *(int64 *)(lVar5 + 32);
            if ((((this.missionTargetDatas == null) ||
                 (lVar9 = FUN_1800024b0(this.missionTargetDatas,0,DAT_181e77460)) == null) ||
                (*(int64 *)(lVar9 + 56) == 0)) ||
               (((lVar9 = FUN_1800024b0(*(int64 *)(lVar9 + 56),iVar11,DAT_181e77160), lVar9 == null ||
                 (uVar3 = Int32.Parse(lVar9.Count,0), lVar5 == null)) ||
                (lVar5 = WorldData.GetHero(lVar5,uVar3,0)) == null))) goto LAB_180e96fa2;
            uVar10 = HeroData.GetHeroName(lVar5,0,0);
            if (((this.missionTargetDatas == null) ||
                (lVar5 = FUN_1800024b0(this.missionTargetDatas,0,DAT_181e77460)) == null) ||
               ((*(int64 *)(lVar5 + 56) == 0 ||
                (lVar5 = FUN_1800024b0(*(int64 *)(lVar5 + 56),iVar11,DAT_181e77160)) == null)))
            goto LAB_180e96fa2;
            local_60 = *(uint32 *)(lVar5 + 40);
            uVar7 = il2cpp_value_box(DAT_181e82730,&local_60);
            uVar6 = "降低{0}忠诚{1}点";
            break;
          case 20:
            lVar5 = FUN_1802106e0(0);
            if (lVar5 != null) {
              lVar5 = *(int64 *)(lVar5 + 32);
              if ((((this.missionTargetDatas != null) &&
                   (lVar9 = FUN_1800024b0(this.missionTargetDatas,0,DAT_181e77460)) != null) &&
                  (*(int64 *)(lVar9 + 56) != 0)) &&
                 (((lVar9 = FUN_1800024b0(*(int64 *)(lVar9 + 56),iVar11), lVar9 != null &&
                   (uVar3 = Int32.Parse(lVar9.Count,0), lVar5 != null)) &&
                  (lVar5 = WorldData.GetArea(lVar5,uVar3)) != null))) {
                uVar10 = AreaData.GetAreaName(lVar5,0);
                uVar10 = String.Format("攻略{0}",uVar10);
                lVar5 = String.Concat(lVar4,uVar10,0);
                goto LAB_180e96c34;
              }
            }
            throw; // [null/range check failed]
          case 21:
            lVar5 = FUN_1802106e0(0);
            if (lVar5 == null) {
        LAB_180e96fa8:
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            lVar5 = *(int64 *)(lVar5 + 32);
            if ((((this.missionTargetDatas == null) ||
                 (lVar9 = FUN_1800024b0(this.missionTargetDatas,0,DAT_181e77460)) == null) ||
                (*(int64 *)(lVar9 + 56) == 0)) ||
               (((lVar9 = FUN_1800024b0(*(int64 *)(lVar9 + 56),iVar11,DAT_181e77160), lVar9 == null ||
                 (uVar3 = Int32.Parse(lVar9.Count,0), lVar5 == null)) ||
                (lVar5 = WorldData.GetArea(lVar5,uVar3,0)) == null))) goto LAB_180e96fa8;
            uVar10 = AreaData.GetAreaName(lVar5,0);
            if (((this.missionTargetDatas == null) ||
                (lVar5 = FUN_1800024b0(this.missionTargetDatas,0,DAT_181e77460)) == null) ||
               ((*(int64 *)(lVar5 + 56) == 0 ||
                (lVar5 = FUN_1800024b0(*(int64 *)(lVar5 + 56),iVar11,DAT_181e77160)) == null)))
            goto LAB_180e96fa8;
            local_5c = *(uint32 *)(lVar5 + 40);
            uVar7 = il2cpp_value_box(DAT_181e82730,&local_5c);
            uVar6 = "在{0}岗哨巡查{1}次";
            break;
          case 22:
            if (((this.missionTargetDatas == null) ||
                (lVar5 = FUN_1800024b0(this.missionTargetDatas,0,DAT_181e77460)) == null) ||
               ((*(int64 *)(lVar5 + 56) == 0 ||
                (lVar5 = FUN_1800024b0(*(int64 *)(lVar5 + 56),iVar11,DAT_181e77160)) == null))) {
        LAB_180e96fae:
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            local_58 = *(uint32 *)(lVar5 + 40);
            uVar10 = il2cpp_value_box(DAT_181e82730,&local_58);
            lVar5 = *(int64 *)(pStatics + 0x510);
            if ((((this.missionTargetDatas == null) ||
                 (lVar9 = FUN_1800024b0(this.missionTargetDatas,0,DAT_181e77460)) == null) ||
                (*(int64 *)(lVar9 + 56) == 0)) ||
               ((lVar9 = FUN_1800024b0(*(int64 *)(lVar9 + 56),iVar11,DAT_181e77160), lVar9 == null ||
                (lVar5 == null)))) goto LAB_180e96fae;
            uVar6 = FUN_1800024b0(lVar5,*(uint32 *)(lVar9 + 32),DAT_181e86970);
            if (((this.missionTargetDatas == null) ||
                ((lVar5 = FUN_1800024b0(this.missionTargetDatas,0,DAT_181e77460), lVar5 == null ||
                 (*(int64 *)(lVar5 + 56) == 0)))) ||
               (lVar5 = FUN_1800024b0(*(int64 *)(lVar5 + 56),iVar11,DAT_181e77160)) == null)
            goto LAB_180e96fae;
            uVar7 = GlobalData.GenerateRareLvColorText(uVar6,*(uint32 *)(lVar5 + 32),0);
            uVar6 = "搜集{0}件{1}珍宝";
            break;
          case 23:
            lVar5 = FUN_1802106e0(0);
            if (lVar5 == null) goto LAB_180e97006;
            lVar9 = this.missionTargetDatas;
            lVar5 = *(int64 *)(lVar5 + 32);
            if (lVar9 == null) goto LAB_180e97006;
            if (lVar9.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar9 = *(int64 *)(lVar9._items + 32);
            if ((((lVar9 == null) || (lVar9 = *(int64 *)(lVar9 + 56)) == null) ||
                (lVar9 = FUN_1800024b0(lVar9,iVar11,DAT_181e77160)) == null) ||
               (uVar3 = Int32.Parse(lVar9.Count,0), lVar5 == null)) goto LAB_180e97006;
            lVar5 = WorldData.GetHero(lVar5,uVar3,0);
            if (lVar5 == null) {
              return "任务对象已死亡";
            }
            lVar5 = FUN_1802106e0(0);
            if (lVar5 == null) {
        LAB_180e96fb4:
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            lVar9 = this.missionTargetDatas;
            lVar5 = *(int64 *)(lVar5 + 32);
            if (lVar9 == null) goto LAB_180e96fb4;
            if (lVar9.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar9 = *(int64 *)(lVar9._items + 32);
            if (((lVar9 == null) || (lVar9 = *(int64 *)(lVar9 + 56)) == null) ||
               ((lVar9 = FUN_1800024b0(lVar9,iVar11,DAT_181e77160), lVar9 == null ||
                ((uVar3 = Int32.Parse(lVar9.Count,0), lVar5 == null ||
                 (lVar5 = WorldData.GetHero(lVar5,uVar3,0)) == null))))) goto LAB_180e96fb4;
            uVar10 = HeroData.Name(lVar5,1,0);
            lVar5 = this.missionTargetDatas;
            if (lVar5 == null) goto LAB_180e96fb4;
            if (lVar5.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar5 = *(int64 *)(lVar5._items + 32);
            if (((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 56)) == null) ||
               (lVar5 = FUN_1800024b0(lVar5,iVar11,DAT_181e77160)) == null) goto LAB_180e96fb4;
            local_54 = *(uint32 *)(lVar5 + 40);
            uVar7 = il2cpp_value_box(DAT_181e82730,&local_54);
            uVar6 = "指点{0}武功{1}次";
            break;
          case 24:
            lVar5 = FUN_1802106e0(0);
            if (lVar5 == null) goto LAB_180e97006;
            lVar9 = this.missionTargetDatas;
            lVar5 = *(int64 *)(lVar5 + 32);
            if (lVar9 == null) goto LAB_180e97006;
            if (lVar9.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar9 = *(int64 *)(lVar9._items + 32);
            if (((lVar9 == null) || (lVar9 = *(int64 *)(lVar9 + 56)) == null) ||
               ((lVar9 = FUN_1800024b0(lVar9,iVar11,DAT_181e77160), lVar9 == null ||
                (uVar3 = Int32.Parse(lVar9.Count,0), lVar5 == null)))) goto LAB_180e97006;
            lVar5 = WorldData.GetHero(lVar5,uVar3,0);
            if (lVar5 == null) {
              return "任务对象已死亡";
            }
            lVar5 = FUN_1802106e0(0);
            if (lVar5 == null) {
        LAB_180e96fba:
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            lVar9 = this.missionTargetDatas;
            lVar5 = *(int64 *)(lVar5 + 32);
            if (lVar9 == null) goto LAB_180e96fba;
            if (lVar9.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar9 = *(int64 *)(lVar9._items + 32);
            if ((((lVar9 == null) || (lVar9 = *(int64 *)(lVar9 + 56)) == null) ||
                (lVar9 = FUN_1800024b0(lVar9,iVar11,DAT_181e77160)) == null) ||
               ((uVar3 = Int32.Parse(lVar9.Count,0), lVar5 == null ||
                (lVar5 = WorldData.GetHero(lVar5,uVar3,0)) == null))) goto LAB_180e96fba;
            uVar10 = HeroData.GetHeroName(lVar5,0,0);
            lVar5 = this.missionTargetDatas;
            if (lVar5 == null) goto LAB_180e96fba;
            if (lVar5.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar5 = *(int64 *)(lVar5._items + 32);
            if (((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 56)) == null) ||
               (lVar5 = FUN_1800024b0(lVar5,iVar11,DAT_181e77160)) == null) goto LAB_180e96fba;
            local_50 = *(uint32 *)(lVar5 + 40);
            uVar7 = il2cpp_value_box(DAT_181e82730,&local_50);
            uVar6 = "向{0}下毒{1}点";
            break;
          default:
            lVar5 = "";
            if (lVar4 != null) {
              lVar5 = lVar4;
            }
            goto LAB_180e96c34;
          }
          uVar10 = String.Format(uVar6,uVar10,uVar7,0);
          lVar5 = String.Concat(lVar4,uVar10,0);
        LAB_180e96c34:
          if (local_res10) {
            plVar8 = (int64 *)FUN_1801dfd90(DAT_181e84278,4);
            cVar2 = MissionData.MissionNeedFinished(this,iVar11,0);
            uVar6 = "({0}{1}/{2}{3})";
            uVar10 = "  ";
            lVar4 = "";
            if (cVar2) {
              lVar4 = *(int64 *)(pStatics + 0x270);
            }
            if (plVar8 == (int64 *)0) {
        LAB_180e97000:
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            if ((lVar4 != null) &&
               (lVar9 = il2cpp_internal(lVar4,*(uint64 *)(*plVar8 + 64))) == null) {
              uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar10,0);
            }
            FUN_1800025b0(plVar8,0,lVar4);
            if ((((this.missionTargetDatas == null) ||
                 (lVar4 = FUN_1800024b0(this.missionTargetDatas,0,DAT_181e77460)) == null) ||
                (*(int64 *)(lVar4 + 56) == 0)) ||
               (lVar4 = FUN_1800024b0(*(int64 *)(lVar4 + 56),iVar11,DAT_181e77160)) == null)
            goto LAB_180e97000;
            local_4c = (int)*(float *)(lVar4 + 36);
            lVar4 = il2cpp_value_box(DAT_181e60808,&local_4c);
            if ((lVar4 != null) &&
               (lVar9 = il2cpp_internal(lVar4,*(uint64 *)(*plVar8 + 64))) == null) {
              uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar10,0);
            }
            FUN_1800025b0(plVar8,1,lVar4);
            if (((this.missionTargetDatas == null) ||
                (lVar4 = FUN_1800024b0(this.missionTargetDatas,0,DAT_181e77460)) == null) ||
               ((*(int64 *)(lVar4 + 56) == 0 ||
                (lVar4 = FUN_1800024b0(*(int64 *)(lVar4 + 56),iVar11,DAT_181e77160)) == null)))
            goto LAB_180e97000;
            local_48[0] = Mathf.CeilToInt(*(uint32 *)(lVar4 + 40),0);
            lVar4 = il2cpp_value_box(DAT_181e60808,local_48);
            if ((lVar4 != null) &&
               (lVar9 = il2cpp_internal(lVar4,*(uint64 *)(*plVar8 + 64))) == null) {
              uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar10,0);
            }
            FUN_1800025b0(plVar8,2,lVar4);
            cVar2 = MissionData.MissionNeedFinished(this,iVar11,0);
            lVar4 = "";
            if (cVar2) {
              lVar4 = "</color>";
            }
            if ((lVar4 != null) &&
               (lVar9 = il2cpp_internal(lVar4,*(uint64 *)(*plVar8 + 64))) == null) {
              uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar10,0);
            }
            FUN_1800025b0(plVar8,3,lVar4);
            String.Format(uVar6,plVar8,0);
            lVar5 = String.Concat(lVar5,uVar10);
          }
          iVar11 = iVar11 + 1;
        }
    }

    // Token : 0x6001341
    // RVA   : 0xE98250   Offset: 0xE97050   Length: 0x10A
    public bool MissionNeedFinished(int needDataID)
    {
        float fVar1;
        long lVar2;
        long lVar3;
        lVar2 = this.missionTargetDatas;
        if (lVar2 != null) {
          if (lVar2.Count == null) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar2 = *(int64 *)(lVar2._items + 32);
          if ((lVar2 != null) && (lVar2 = *(int64 *)(lVar2 + 56)) != null) {
            if (lVar2.Count <= needDataID) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar2 = lVar2._items[needDataID];
            if (lVar2 != null) {
              lVar3 = this.missionTargetDatas;
              fVar1 = *(float *)(lVar2 + 36);
              if (lVar3 != null) {
                if (lVar3.Count == null) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar2 = *(int64 *)(lVar3._items + 32);
                if ((lVar2 != null) && (lVar2 = *(int64 *)(lVar2 + 56)) != null) {
                  if (lVar2.Count <= needDataID) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  lVar3 = lVar2._items[needDataID];
                  if (lVar3 != null) {
                    return CONCAT71((int7)((uint64)lVar2._items >> 8),
                                    *(float *)(lVar3 + 40) <= fVar1);
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6001342
    // RVA   : 0xE92CE0   Offset: 0xE91AE0   Length: 0x3D2
    public virtual object Clone()
    {
        uint uVar1;
        long lVar2;
        long lVar3;
        ulong uVar4;
        long lVar5;
        uint uVar8;
        long lVar10;
        lVar3 = new MissionData(0);
        if (lVar3 != null) {
          *(uint32 *)(lVar3 + 16) = this.id;
          *(uint64 *)(lVar3 + 24) = this.name;
          plVar7 = (int64 *)0;
          *(uint32 *)(lVar3 + 32) = this.speMissionID;
          *(uint32 *)(lVar3 + 36) = this.leftTime;
          *(uint32 *)(lVar3 + 40) = this.stageMinLeftTime;
          *(uint32 *)(lVar3 + 44) = this.difficulty;
          *(uint32 *)(lVar3 + 48) = this.difficultyRate;
          *(uint32 *)(lVar3 + 52) = this.rewardRate;
          *(uint32 *)(lVar3 + 56) = this.treasureLv;
          lVar5 = this.bountyTypes;
          plVar6 = plVar7;
          if (lVar5 != null) {
            plVar6 = (int64 *)il2cpp_internal(DAT_181e716b8);
            FUN_181779b60(plVar6,lVar5,DAT_181e62878);
          }
          *(uint64 *)(lVar3 + 64) = plVar6;
          *(uint32 *)(lVar3 + 72) = this.minForceLv;
          *(uint32 *)(lVar3 + 76) = this.missionSourceType;
          *(uint32 *)(lVar3 + 80) = this.missionBountyType;
          *(uint32 *)(lVar3 + 84) = this.sourceHeroID;
          *(uint32 *)(lVar3 + 88) = this.sourceForceID;
          *(uint32 *)(lVar3 + 92) = this.missionHeroID;
          *(uint8 *)(lVar3 + 96) = this.missionDisableQuickTravel;
          *(uint8 *)(lVar3 + 97) = this.missionHideTargetPlace;
          *(uint64 *)(lVar3 + 104) = this.missionHideTargetPlaceString;
          *(uint32 *)(lVar3 + 112) = this.missionRandomSeed;
          if (this.missionTargetDatas == null) {
            *(uint64 *)(lVar3 + 120) = 0;
        LAB_180e92fd7:
            *(uint8 *)(lVar3 + 128) = this.noAutoFinish;
            *(uint32 *)(lVar3 + 132) = this.missionFunds;
            *(uint32 *)(lVar3 + 136) = this.missionFameReward;
            *(uint32 *)(lVar3 + 140) = this.missionContributionRewardBase;
            *(uint32 *)(lVar3 + 144) = this.missionContributionReward;
            *(uint32 *)(lVar3 + 148) = this.missionMoneyReward;
            *(uint64 *)(lVar3 + 152) = this.missionJoinTeamHero;
            lVar5 = this.missionJoinTeamHeroID;
            if (lVar5 != null) {
              plVar7 = (int64 *)il2cpp_internal(DAT_181e73cb8);
              FUN_18177a7d0(plVar7,lVar5,DAT_181e712f0);
            }
            *(uint64 *)(lVar3 + 160) = plVar7;
            return lVar3;
          }
          uVar1 = this.missionTargetDatas.Count;
          uVar4 = new List_1(uVar1,DAT_181e77260);
          *(uint64 *)(lVar3 + 120) = uVar4;
          lVar5 = this.missionTargetDatas;
          if (lVar5 != null) {
            lVar10 = 32;
            plVar6 = plVar7;
            while( true ) {
              uVar8 = (uint32)plVar6;
              if (lVar5.Count <= (int)uVar8) goto LAB_180e92fd7;
              lVar2 = *(int64 *)(lVar3 + 120);
              if (lVar5 == null) break;
              if (lVar5.Count <= uVar8) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              plVar9 = plVar7;
              if (*(int64 *)(lVar10 + lVar5._items) != 0) {
                if ((this.missionTargetDatas == null) ||
                   (lVar5 = FUN_1800024b0(this.missionTargetDatas,plVar6,DAT_181e77460)) == null
                   ) break;
                plVar6 = (int64 *)MissionTargetData.Clone(lVar5,0);
                if (plVar6 != (int64 *)0) {
                }
              }
              if (lVar2 == null) break;
              FUN_18175de30(lVar2,plVar9,DAT_181e772e0);
              lVar5 = this.missionTargetDatas;
              plVar6 = (int64 *)(uint64)(uVar8 + 1);
              lVar10 = lVar10 + 8;
              if (lVar5 == null) break;
            }
          }
        }
    }

    // Token : 0x6001343
    // RVA   : 0xE98A00   Offset: 0xE97800   Length: 0x497
    private static void /*cctor*/()
    {
        var pStatics = *(int64*)(DAT_181e6ad70 + 184);
        long lVar1;
        lVar1 = il2cpp_internal(DAT_181e77728);
        FUN_1810f3480(lVar1,DAT_181e861f0);
        if (lVar1 != null) {
          FUN_18175de30(lVar1,"#SourceForceName#功绩",DAT_181e86370);
          FUN_18175de30(lVar1,"声望",DAT_181e86370);
          FUN_18175de30(lVar1,"官府功绩",DAT_181e86370);
          FUN_18175de30(lVar1,"#SourceHeroName#好感",DAT_181e86370);
          plVar2 = pStatics;
          *plVar2 = lVar1;
          il2cpp_internal(plVar2,lVar1);
          lVar1 = il2cpp_internal(DAT_181e76ea8);
          FUN_1810f3480(lVar1,DAT_181e83230);
          if (lVar1 != null) {
            FUN_18175dba0(lVar1,0,DAT_181e83330);
            FUN_18175dba0(lVar1,0x41200000,DAT_181e83330);
            FUN_18175dba0(lVar1,0x41200000,DAT_181e83330);
            FUN_18175dba0(lVar1,0x41700000,DAT_181e83330);
            FUN_18175dba0(lVar1,0x41700000,DAT_181e83330);
            FUN_18175dba0(lVar1,0x41a00000,DAT_181e83330);
            FUN_18175dba0(lVar1,0x41c80000,DAT_181e83330);
            FUN_18175dba0(lVar1,0x41700000,DAT_181e83330);
            FUN_18175dba0(lVar1,0x41200000,DAT_181e83330);
            FUN_18175dba0(lVar1,0x41200000,DAT_181e83330);
            FUN_18175dba0(lVar1,0x41a00000,DAT_181e83330);
            FUN_18175dba0(lVar1,0x41200000,DAT_181e83330);
            FUN_18175dba0(lVar1,0x41a00000,DAT_181e83330);
            FUN_18175dba0(lVar1,0x41c80000,DAT_181e83330);
            FUN_18175dba0(lVar1,0x41a00000,DAT_181e83330);
            FUN_18175dba0(lVar1,0x41200000,DAT_181e83330);
            FUN_18175dba0(lVar1,0x41a00000,DAT_181e83330);
            FUN_18175dba0(lVar1,0x41c80000,DAT_181e83330);
            FUN_18175dba0(lVar1,0x41700000,DAT_181e83330);
            FUN_18175dba0(lVar1,0x41a00000,DAT_181e83330);
            FUN_18175dba0(lVar1,0,DAT_181e83330);
            FUN_18175dba0(lVar1,0x41200000,DAT_181e83330);
            FUN_18175dba0(lVar1,0x41700000,DAT_181e83330);
            FUN_18175dba0(lVar1,0x41700000,DAT_181e83330);
            FUN_18175dba0(lVar1,0x41500000,DAT_181e83330);
            MissionData.MissionTargetTypeBaseMissionContribution = lVar1;
            lVar1 = il2cpp_internal(DAT_181e74cb8);
            FUN_1810f3480(lVar1,DAT_181e774e0);
            if (lVar1 != null) {
              FUN_181769fe0(lVar1,3,DAT_181e77560);
              FUN_181769fe0(lVar1,11,DAT_181e77560);
              FUN_181769fe0(lVar1,12,DAT_181e77560);
              FUN_181769fe0(lVar1,16,DAT_181e77560);
              FUN_181769fe0(lVar1,24,DAT_181e77560);
              FUN_181769fe0(lVar1,19,DAT_181e77560);
              FUN_181769fe0(lVar1,23,DAT_181e77560);
              MissionData.MissionTargetNpc = lVar1;
              return;
            }
          }
        }
    }

}
