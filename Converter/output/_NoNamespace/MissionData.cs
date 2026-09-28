// ============================================================
// Type  : MissionData
// Token : 0x200024D
// ============================================================

public class MissionData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400126D
    public static List<string> MissionBountyTypeRewardType;

    // Token: 0x400126E
    public int id;

    // Token: 0x400126F
    public string name;

    // Token: 0x4001270
    public int speMissionID;

    // Token: 0x4001271
    public int leftTime;

    // Token: 0x4001272
    public int stageMinLeftTime;

    // Token: 0x4001273
    public float difficulty;

    // Token: 0x4001274
    public float difficultyRate;

    // Token: 0x4001275
    public float rewardRate;

    // Token: 0x4001276
    public float treasureLv;

    // Token: 0x4001277
    public List<BountyType> bountyTypes;

    // Token: 0x4001278
    public int minForceLv;

    // Token: 0x4001279
    public MissionSourceType missionSourceType;

    // Token: 0x400127A
    public BountyType missionBountyType;

    // Token: 0x400127B
    public int sourceHeroID;

    // Token: 0x400127C
    public int sourceForceID;

    // Token: 0x400127D
    public int missionHeroID;

    // Token: 0x400127E
    public bool missionDisableQuickTravel;

    // Token: 0x400127F
    public bool missionHideTargetPlace;

    // Token: 0x4001280
    public string missionHideTargetPlaceString;

    // Token: 0x4001281
    public int missionRandomSeed;

    // Token: 0x4001282
    public List<MissionTargetData> missionTargetDatas;

    // Token: 0x4001283
    public bool noAutoFinish;

    // Token: 0x4001284
    public int missionFunds;

    // Token: 0x4001285
    public float missionFameReward;

    // Token: 0x4001286
    public float missionContributionRewardBase;

    // Token: 0x4001287
    public float missionContributionReward;

    // Token: 0x4001288
    public int missionMoneyReward;

    // Token: 0x4001289
    public string missionJoinTeamHero;

    // Token: 0x400128A
    public List<int> missionJoinTeamHeroID;

    // Token: 0x400128B
    public static List<float> MissionTargetTypeBaseMissionContribution;

    // Token: 0x400128C
    public static List<MissionTargetType> MissionTargetNpc;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600130D
    // RVA   : 0xE694A0   Offset: 0xE688A0   Length: 0x1F7
    public void /*ctor*/()
    {
        long lVar1;
        long lVar2;
        long lVar3;
        ulong uVar4;
        this.speMissionID = 0xffffffff;
        this.difficultyRate = 0x3f800000;
        this.rewardRate = 0x3f800000;
        this.sourceHeroID = 0xffffffffffffffff;
        this.missionHeroID = 0xffffffff;
        ZhSegment.Initialize(this,0);
        lVar1 = il2cpp_internal(DAT_181d94c50);
        FUN_18132faf0(lVar1,DAT_181d94f08);
        lVar2 = il2cpp_internal(DAT_181d8ab10);
        *(uint32 *)(lVar2 + 80) = 0xffffffff;
        ZhSegment.Initialize(lVar2,0);
        lVar3 = il2cpp_internal(DAT_181d94bd0);
        FUN_18132faf0(lVar3,DAT_181d94d08);
        uVar4 = new ZhSegment(0);
        if (lVar3 != null) {
          FUN_18181e0a0(lVar3,uVar4,DAT_181d94d88);
          *(int64 *)(lVar2 + 56) = lVar3;
          if (lVar1 != null) {
            FUN_18181e0a0(lVar1,lVar2,DAT_181d94f88);
            this.missionTargetDatas = lVar1;
            uVar4 = il2cpp_internal(DAT_181d93cd0);
            FUN_18132faf0(uVar4,DAT_181d8f098);
            this.missionJoinTeamHeroID = uVar4;
            return;
          }
        }
    }

    // Token : 0x600130E
    // RVA   : 0xE68960   Offset: 0xE67D60   Length: 0x2DB
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
                 (lVar3 = FUN_180002f80(this.missionTargetDatas,uVar7,DAT_181d95108)) == null)
              break;
              uVar1 = *(uint64 *)(lVar3 + 48);
              uVar4 = Int32.ToString(local_res10,0);
              cVar2 = FUN_18171e540(uVar1,uVar4,0);
              if (cVar2) {
                return true;
              }
            }
            if ((this.missionTargetDatas == null) ||
               (lVar3 = FUN_180002f80(this.missionTargetDatas,uVar7,DAT_181d95108)) == null)
            break;
            if (*(int64 *)(lVar3 + 56) != 0) {
              iVar6 = 0;
              while( true ) {
                if (((this.missionTargetDatas == null) ||
                    (lVar3 = FUN_180002f80(this.missionTargetDatas,uVar7,DAT_181d95108)) == null
                    ) || (*(int64 *)(lVar3 + 56) == 0)) throw; // [null/range check failed]
                if (*(int *)(*(int64 *)(lVar3 + 56) + 24) <= iVar6) break;
                lVar3 = *(int64 *)(*(int64 *)(DAT_181d8a990 + 184) + 16);
                if (((this.missionTargetDatas == null) ||
                    (lVar5 = FUN_180002f80(this.missionTargetDatas,uVar7,DAT_181d95108)) == null
                    ) || ((*(int64 *)(lVar5 + 56) == 0 ||
                          ((lVar5 = FUN_180002f80(*(int64 *)(lVar5 + 56),iVar6,DAT_181d94e88),
                           lVar5 == null || (lVar3 == null)))))) throw; // [null/range check failed]
                cVar2 = FUN_18182a3a0(lVar3,*(uint32 *)(lVar5 + 16),DAT_181d95288);
                if (cVar2) {
                  if ((((this.missionTargetDatas == null) ||
                       (lVar3 = FUN_180002f80(this.missionTargetDatas,uVar7,DAT_181d95108),
                       lVar3 == null)) || (*(int64 *)(lVar3 + 56) == 0)) ||
                     (lVar3 = FUN_180002f80(*(int64 *)(lVar3 + 56),iVar6,DAT_181d94e88)) == null)
                  throw; // [null/range check failed]
                  uVar1 = lVar3.Count;
                  uVar4 = Int32.ToString(local_res10,0);
                  cVar2 = FUN_18171e540(uVar1,uVar4,0);
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

    // Token : 0x600130F
    // RVA   : 0xE68C70   Offset: 0xE68070   Length: 0xDC
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

    // Token : 0x6001310
    // RVA   : 0xE68D50   Offset: 0xE68150   Length: 0xE5
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

    // Token : 0x6001311
    // RVA   : 0xE68E40   Offset: 0xE68240   Length: 0x1B8
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

    // Token : 0x6001312
    // RVA   : 0xE68C40   Offset: 0xE68040   Length: 0x26
    public void SetDifficulty(float _difficulty)
    {
        void FUN_180e68c40(int64 this,float _difficulty)
        {
        this.difficulty = _difficulty;
        this.missionContributionReward = (_difficulty * 0.2 + 1.0) * this.missionContributionRewardBase;
    }

    // Token : 0x6001313
    // RVA   : 0xE67670   Offset: 0xE66A70   Length: 0x28
    public int GetRareLv()
    {
        int iVar1;
        iVar1 = Mathf.RoundToInt(this,0);
        return (int)((float)iVar1 * 0.5);
    }

    // Token : 0x6001314
    // RVA   : 0xE63EE0   Offset: 0xE632E0   Length: 0x53
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

    // Token : 0x6001315
    // RVA   : 0xE636C0   Offset: 0xE62AC0   Length: 0x170
    public string GetBountyTargetItem()
    {
        long lVar1;
        uint uVar2;
        uint uVar3;
        ulong uVar4;
        ulong uVar5;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d73d40 + 184) + 0x4f0);
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

    // Token : 0x6001316
    // RVA   : 0xE63840   Offset: 0xE62C40   Length: 0x694
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
                lVar6 = FUN_18046c0a0(0);
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
              lVar6 = *(int64 *)(*(int64 *)(DAT_181d73d40 + 184) + 0x4f0);
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

    // Token : 0x6001317
    // RVA   : 0xE63FD0   Offset: 0xE633D0   Length: 0x842
    public string GetMissionExtraDescribe(bool showMissionTargetType, bool showDifficulty, bool showFinishRate, bool showForceContribution)
    {
        var pStatics = *(int64*)(DAT_181d73d40 + 184);
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
        LAB_180e64807:
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              if (lVar9.Count == null) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar9 = *(int64 *)(lVar9._items + 32);
              if (lVar9 == null) goto LAB_180e64807;
              uVar1 = *(uint32 *)(lVar9 + 72);
              uVar5 = GlobalData.GetRequireTypeText(uVar1,0);
              lVar9 = this.missionTargetDatas;
              if (lVar9 == null) goto LAB_180e64807;
              if (lVar9.Count == null) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar9 = *(int64 *)(lVar9._items + 32);
              if (lVar9 == null) goto LAB_180e64807;
              local_res8[0] = *(int *)(lVar9 + 76);
              uVar6 = il2cpp_value_box(DAT_181da22d8,local_res8);
              lVar9 = this.missionTargetDatas;
              lVar8 = *(int64 *)(*(int64 *)(DAT_181d91b88 + 184) + 24);
              if (lVar9 == null) goto LAB_180e64807;
              if (lVar9.Count == null) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar9 = *(int64 *)(lVar9._items + 32);
              if (lVar9 == null) goto LAB_180e64807;
              lVar3 = this.missionTargetDatas;
              uVar1 = *(uint32 *)(lVar9 + 72);
              if (lVar3 == null) goto LAB_180e64807;
              if (lVar3.Count == null) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar9 = *(int64 *)(lVar3._items + 32);
              if ((lVar9 == null) || (lVar8 == null)) goto LAB_180e64807;
              cVar4 = PlotController.CheckMeetRequire(lVar8,uVar1,*(uint32 *)(lVar9 + 76),0,0);
              uVar10 = "\n需要:{2}{0}{1}</color>";
              if (!cVar4) {
                lVar8 = FUN_18046c400(0);
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
                  uVar11 = *(uint64 *)(pStatics + 0x2d0);
                }
                else {
                  uVar11 = *(uint64 *)(pStatics + 0x248);
                }
              }
              else {
                uVar11 = *(uint64 *)(pStatics + 0x268);
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
              uVar5 = il2cpp_value_box(DAT_181d80418,local_res8);
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
                lVar8 = FUN_18046c0a0(0);
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
                lVar8 = FUN_18046c0a0(0);
                if ((lVar8 == null) || (*(int64 *)(lVar8 + 32) == 0)) throw; // [null/range check failed]
                lVar8 = WorldData.GetForce(*(int64 *)(lVar8 + 32),this.sourceForceID,0)
                ;
                if (lVar8 == null) throw; // [null/range check failed]
                uVar10 = ForceData.GetForceName(lVar8,1,0);
              }
              if (lVar9 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              uVar6 = String.Replace(lVar9,uVar6,uVar10,0);
              local_78 = this.missionFameReward;
              uVar10 = il2cpp_value_box(DAT_181da22d8,&local_78);
              uVar5 = String.Format(uVar5,uVar6,uVar10,0);
              uVar7 = String.Concat(uVar7,uVar5,0);
            }
            if ((showForceContribution) && (local_74[0] = this.missionContributionReward, local_74[0] != 0.0)) {
              uVar5 = il2cpp_value_box(DAT_181da22d8,local_74);
              uVar5 = String.Format("\n本门功绩:{0}",uVar5,0);
              uVar7 = String.Concat(uVar7,uVar5,0);
            }
            return uVar7;
          }
        }
    }

    // Token : 0x6001318
    // RVA   : 0xE63F40   Offset: 0xE63340   Length: 0x87
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

    // Token : 0x6001319
    // RVA   : 0xE67E00   Offset: 0xE67200   Length: 0x151
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

    // Token : 0x600131A
    // RVA   : 0xE676A0   Offset: 0xE66AA0   Length: 0x734
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
        lVar4 = il2cpp_internal(DAT_181d93cd0);
        FUN_18132faf0(lVar4,DAT_181d8f098);
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
                    lVar6 = FUN_1800d60b0(DAT_181da1040,1);
                    if (lVar6 != null) {
                      if (lVar6.Count == null) {
                        uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar7,0);
                      }
                      *(uint16 *)(lVar6 + 32) = 58;
                      if (lVar5 != null) {
                        lVar5 = String.Split(lVar5,lVar6,0);
                        lVar6 = FUN_18046c0a0(0);
                        if ((lVar6 != null) && (lVar6 = *(int64 *)(lVar6 + 32), lVar5 != null)) {
                          if (lVar5.Count == null) {
                            uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                            FUN_1800d65f0(uVar7,0);
                          }
                          uVar3 = Int32.Parse(*(uint64 *)(lVar5 + 32),0);
                          if (((lVar6 != null) && (lVar5 = WorldData.GetArea(lVar6,uVar3,0)) != null) &&
                             (lVar4 != null)) {
                            FUN_18182a0b0();
                            goto LAB_180e67d78;
                          }
                        }
                      }
                    }
                  }
                }
                break;
              }
              if (iVar1 == 5) {
                lVar5 = FUN_18046c0a0(0);
                if (lVar5 == null) break;
                lVar5 = *(int64 *)(lVar5 + 32);
                lVar6 = FUN_18046c0a0(0);
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
                FUN_18182a0b0();
              }
            }
            else {
              if (lVar6 == null) break;
              if (lVar6.Count == null) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar5 = *(int64 *)(lVar6._items + 32);
              if (((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 56)) == null) ||
                 (lVar5 = FUN_180002f80(lVar5,uVar9,DAT_181d94e88)) == null) break;
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
                     (lVar5 = FUN_180002f80(lVar5,uVar9,DAT_181d94e88)) != null) {
                    Int32.Parse(lVar5.Count,0);
                    goto LAB_180e679a2;
                  }
                }
                throw; // [null/range check failed]
              default:
                lVar5 = FUN_18046c0a0(0);
                if (((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) ||
                   (lVar5 = WorldData.Player(*(int64 *)(lVar5 + 32),0)) == null)
                throw; // [null/range check failed]
                lVar5 = HeroData.GetForce(lVar5,0,0);
                if (lVar5 != null) {
                  lVar5 = FUN_18046c0a0(0);
                  if (((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) ||
                     ((lVar5 = WorldData.Player(*(int64 *)(lVar5 + 32),0), lVar5 == null ||
                      (lVar5 = HeroData.GetForce(lVar5,0,0)) == null))) throw; // [null/range check failed]
                }
                if (lVar4 == null) throw; // [null/range check failed]
                FUN_18182a0b0();
                break;
              case 3:
              case 11:
              case 12:
              case 16:
              case 19:
              case 23:
              case 24:
                lVar5 = FUN_18046c0a0(0);
                if (lVar5 == null) throw; // [null/range check failed]
                lVar6 = this.missionTargetDatas;
                lVar5 = *(int64 *)(lVar5 + 32);
                if (lVar6 == null) throw; // [null/range check failed]
                if (lVar6.Count == null) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar6 = *(int64 *)(lVar6._items + 32);
                if ((((lVar6 == null) || (lVar6 = *(int64 *)(lVar6 + 56)) == null) ||
                    (lVar6 = FUN_180002f80(lVar6,uVar9,DAT_181d94e88)) == null) ||
                   ((uVar3 = Int32.Parse(lVar6.Count,0), lVar5 == null ||
                    (lVar5 = WorldData.GetHero(lVar5,uVar3,0)) == null))) throw; // [null/range check failed]
                HeroData.GetAreaID(lVar5,1,0);
        LAB_180e679a2:
                if (lVar4 == null) throw; // [null/range check failed]
                FUN_18182a0b0();
                break;
              case 14:
              case 15:
                lVar5 = FUN_18046c0a0(0);
                if (lVar5 == null) throw; // [null/range check failed]
                lVar6 = this.missionTargetDatas;
                lVar5 = *(int64 *)(lVar5 + 32);
                if (lVar6 == null) throw; // [null/range check failed]
                if (lVar6.Count == null) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar6 = *(int64 *)(lVar6._items + 32);
                if (((((lVar6 == null) || (lVar6 = *(int64 *)(lVar6 + 56)) == null) ||
                     (lVar6 = FUN_180002f80(lVar6,uVar9,DAT_181d94e88)) == null) ||
                    ((uVar3 = Int32.Parse(lVar6.Count,0), lVar5 == null ||
                     (lVar5 = WorldData.GetForce(lVar5,uVar3,0)) == null))) || (lVar4 == null))
                throw; // [null/range check failed]
                FUN_18182a0b0();
              }
            }
        LAB_180e67d78:
            lVar5 = this.missionTargetDatas;
            uVar9 = uVar9 + 1;
            lVar8 = lVar8 + 1;
            if (lVar5 == null) break;
          }
        }
    }

    // Token : 0x600131B
    // RVA   : 0xE67F60   Offset: 0xE67360   Length: 0x8D0
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
              lVar7 = FUN_1800d60b0(DAT_181da1040,1);
              if (lVar7 != null) {
                if (*(int *)(lVar7 + 24) == 0) {
                  uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar5,0);
                }
                *(uint16 *)(lVar7 + 32) = 58;
                if (lVar6 != null) {
                  lVar6 = String.Split(lVar6,lVar7,0);
                  lVar7 = FUN_18046c0a0(0);
                  if ((lVar7 != null) && (lVar7 = *(int64 *)(lVar7 + 32), lVar6 != null)) {
                    if (lVar6.Count == null) {
                      uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar5,0);
                    }
                    uVar2 = Int32.Parse(*(uint64 *)(lVar6 + 32),0);
                    if ((lVar7 != null) && (lVar7 = WorldData.GetArea(lVar7,uVar2,0)) != null) {
                      lVar7 = AreaData.GetAreaName(lVar7,0);
                      if (unclear) {
                        lVar3 = FUN_18046c0a0(0);
                        if (lVar3 == null) break;
                        lVar3 = *(int64 *)(lVar3 + 32);
                        if (lVar6.Count == null) {
                          uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1800d65f0(uVar5,0);
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
                             (lVar4 = FUN_180002f80(this.missionTargetDatas,targetID,DAT_181d95108),
                             lVar4 != null)) {
                            if (*(int *)(lVar4 + 40) == 1) {
                              uVar5 = "?";
                              if (!unclear) {
                                lVar4 = *(int64 *)(*(int64 *)(DAT_181d73d40 + 184) + 0x3c8);
                                if (lVar6.Count < 2) {
                                  uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                  FUN_1800d65f0(uVar5,0);
                                }
                                uVar2 = Int32.Parse(*(uint64 *)(lVar6 + 40),0);
                                if (lVar4 == null) break;
                                uVar5 = FUN_180002f80(lVar4,uVar2,DAT_181da4358);
                              }
                              lVar6 = String.Concat(lVar7,uVar5,"方",0);
                              return lVar6;
                            }
                            if ((this.missionTargetDatas != null) &&
                               (lVar4 = FUN_180002f80(this.missionTargetDatas,targetID,DAT_181d95108)
                               , lVar4 != null)) {
                              if (*(int *)(lVar4 + 40) != 4) {
                                return lVar7;
                              }
                              if (!unclear) {
                                lVar4 = FUN_18046c100(0);
                                if (lVar4 != null) {
                                  lVar4 = *(int64 *)(lVar4 + 224);
                                  if (lVar6.Count < 2) {
                                    uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                    FUN_1800d65f0(uVar5,0);
                                  }
                                  uVar2 = Int32.Parse(*(uint64 *)(lVar6 + 40),0);
                                  if ((lVar4 != null) &&
                                     (lVar6 = FUN_1817d9e10(lVar4,uVar2,DAT_181db7bd8)) != null) {
                                    lVar6 = String.Concat(lVar7,lVar6.Count,0);
                                    return lVar6;
                                  }
                                }
                              }
                              else {
                                lVar4 = FUN_18046c100(0);
                                if (lVar4 != null) {
                                  lVar4 = *(int64 *)(lVar4 + 224);
                                  if (lVar6.Count < 2) {
                                    uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                    FUN_1800d65f0(uVar5,0);
                                  }
                                  uVar2 = Int32.Parse(*(uint64 *)(lVar6 + 40),0);
                                  if (((lVar4 != null) &&
                                      (lVar6 = FUN_1817d9e10(lVar4,uVar2,DAT_181db7bd8)) != null) &&
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
          lVar6 = FUN_18046c0a0(0);
          if (lVar6 != null) {
            lVar6 = *(int64 *)(lVar6 + 32);
            if (((this.missionTargetDatas != null) &&
                (lVar7 = FUN_180002f80(this.missionTargetDatas,targetID,DAT_181d95108)) != null)
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
          lVar6 = FUN_18046c0a0(0);
          if (lVar6 != null) {
            lVar6 = *(int64 *)(lVar6 + 32);
            if ((((this.missionTargetDatas != null) &&
                 (lVar7 = FUN_180002f80(this.missionTargetDatas,targetID,DAT_181d95108)) != null)
                && (uVar2 = Int32.Parse(*(uint64 *)(lVar7 + 48),0), lVar6 != null)) &&
               (lVar6 = WorldData.GetInn(lVar6,uVar2,0)) != null) {
              return lVar6.Count;
            }
          }
          break;
        case 7:
          lVar6 = FUN_18046c100(0);
          if (((this.missionTargetDatas == null) ||
              (lVar7 = FUN_180002f80(this.missionTargetDatas,targetID,DAT_181d95108)) == null) ||
             ((uVar2 = Int32.Parse(*(uint64 *)(lVar7 + 48),0), lVar6 == null ||
              (lVar6 = GameDataController.GetSkillDataBase(lVar6,uVar2,0)) == null))) break;
          uVar8 = KungfuSkillData.Name(lVar6,0,0);
          uVar5 = "阅读{0}秘籍";
          goto LAB_180e68797;
        case 8:
          lVar6 = FUN_18046c100(0);
          if ((((this.missionTargetDatas == null) ||
               (lVar7 = FUN_180002f80(this.missionTargetDatas,targetID,DAT_181d95108)) == null)
              || (uVar2 = Int32.Parse(*(uint64 *)(lVar7 + 48),0), lVar6 == null)) ||
             (lVar6 = GameDataController.GetSkillDataBase(lVar6,uVar2,0)) == null) break;
          uVar8 = KungfuSkillData.Name(lVar6,0,0);
          uVar5 = "练习{0}";
        LAB_180e68797:
          lVar7 = String.Format(uVar5,uVar8,0);
        switchD_180e680ae_default:
          return lVar7;
        default:
          goto switchD_180e680ae_default;
        }
    }

    // Token : 0x600131C
    // RVA   : 0xE64820   Offset: 0xE63C20   Length: 0x2DEC
    public string GetMissionTargetDescribe(bool showFinishRate)
    {
        var pStatics = *(int64*)(DAT_181d73d40 + 184);
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
        LAB_180e67606:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          if (lVar5.Count == null) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar5 = *(int64 *)(lVar5._items + 32);
          if (((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 56)) == null) ||
             (lVar5 = FUN_180002f80(lVar5,iVar11)) == null) goto LAB_180e67606;
          switch(lVar5._items) {
          case 1:
            lVar5 = FUN_18046c0a0(0);
            if (lVar5 == null) {
        LAB_180e674b6:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar9 = this.missionTargetDatas;
            lVar5 = *(int64 *)(lVar5 + 32);
            if (lVar9 == null) goto LAB_180e674b6;
            if (lVar9.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar9 = *(int64 *)(lVar9._items + 32);
            if (((lVar9 == null) || (lVar9 = *(int64 *)(lVar9 + 56)) == null) ||
               ((lVar9 = FUN_180002f80(lVar9,iVar11,DAT_181d94e88), lVar9 == null ||
                ((uVar3 = Int32.Parse(lVar9.Count,0), lVar5 == null ||
                 (lVar5 = WorldData.GetArea(lVar5,uVar3,0)) == null))))) goto LAB_180e674b6;
            uVar10 = AreaData.GetAreaName(lVar5,0);
            lVar5 = this.missionTargetDatas;
            if (lVar5 == null) goto LAB_180e674b6;
            if (lVar5.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar5 = *(int64 *)(lVar5._items + 32);
            if (((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 56)) == null) ||
               (lVar5 = FUN_180002f80(lVar5,iVar11,DAT_181d94e88)) == null) goto LAB_180e674b6;
            local_res8[0] = *(uint32 *)(lVar5 + 40);
            uVar7 = il2cpp_value_box(DAT_181da22d8,local_res8);
            uVar6 = "在{0}分舵探索{1}次";
            break;
          case 2:
            lVar5 = this.missionTargetDatas;
            if (lVar5 == null) {
        LAB_180e674bc:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            if (lVar5.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar5 = *(int64 *)(lVar5._items + 32);
            if (((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 56)) == null) ||
               (lVar5 = FUN_180002f80(lVar5,iVar11,DAT_181d94e88)) == null) goto LAB_180e674bc;
            local_res20[0] = *(uint32 *)(lVar5 + 40);
            uVar10 = il2cpp_value_box(DAT_181da22d8,local_res20);
            lVar5 = this.missionTargetDatas;
            lVar9 = *(int64 *)(pStatics + 0x438);
            if (lVar5 == null) goto LAB_180e674bc;
            if (lVar5.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar5 = *(int64 *)(lVar5._items + 32);
            if ((((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 56)) == null) ||
                (lVar5 = FUN_180002f80(lVar5,iVar11,DAT_181d94e88)) == null) || (lVar9 == null))
            goto LAB_180e674bc;
            uVar7 = FUN_180002f80(lVar9,*(uint32 *)(lVar5 + 32),DAT_181da4358);
            uVar6 = "为门派获取{0}{1}";
            break;
          case 3:
            lVar5 = FUN_18046c0a0(0);
            if (lVar5 == null) goto LAB_180e67606;
            lVar9 = this.missionTargetDatas;
            lVar5 = *(int64 *)(lVar5 + 32);
            if (lVar9 == null) goto LAB_180e67606;
            if (lVar9.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar9 = *(int64 *)(lVar9._items + 32);
            if ((((lVar9 == null) || (lVar9 = *(int64 *)(lVar9 + 56)) == null) ||
                (lVar9 = FUN_180002f80(lVar9,iVar11,DAT_181d94e88)) == null) ||
               (uVar3 = Int32.Parse(lVar9.Count,0), lVar5 == null)) goto LAB_180e67606;
            lVar5 = WorldData.GetHero(lVar5,uVar3,0);
            if (lVar5 == null) {
              return "任务对象已死亡";
            }
            lVar5 = FUN_18046c0a0(0);
            if (lVar5 == null) {
        LAB_180e674c2:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar9 = this.missionTargetDatas;
            lVar5 = *(int64 *)(lVar5 + 32);
            if (lVar9 == null) goto LAB_180e674c2;
            if (lVar9.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar9 = *(int64 *)(lVar9._items + 32);
            if (((lVar9 == null) || (lVar9 = *(int64 *)(lVar9 + 56)) == null) ||
               ((lVar9 = FUN_180002f80(lVar9,iVar11,DAT_181d94e88), lVar9 == null ||
                ((uVar3 = Int32.Parse(lVar9.Count,0), lVar5 == null ||
                 (lVar5 = WorldData.GetHero(lVar5,uVar3,0)) == null))))) goto LAB_180e674c2;
            uVar10 = HeroData.Name(lVar5,1,0);
            lVar5 = this.missionTargetDatas;
            if (lVar5 == null) goto LAB_180e674c2;
            if (lVar5.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar5 = *(int64 *)(lVar5._items + 32);
            if (((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 56)) == null) ||
               (lVar5 = FUN_180002f80(lVar5,iVar11,DAT_181d94e88)) == null) goto LAB_180e674c2;
            local_a8 = *(uint32 *)(lVar5 + 40);
            uVar7 = il2cpp_value_box(DAT_181da22d8,&local_a8);
            uVar6 = "增进与{0}的好感{1}点";
            break;
          case 4:
            lVar5 = FUN_18046c0a0(0);
            if (lVar5 == null) {
        LAB_180e674c8:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar9 = this.missionTargetDatas;
            lVar5 = *(int64 *)(lVar5 + 32);
            if (lVar9 == null) goto LAB_180e674c8;
            if (lVar9.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar9 = *(int64 *)(lVar9._items + 32);
            if (((lVar9 == null) || (lVar9 = *(int64 *)(lVar9 + 56)) == null) ||
               ((lVar9 = FUN_180002f80(lVar9,iVar11,DAT_181d94e88), lVar9 == null ||
                ((uVar3 = Int32.Parse(lVar9.Count,0), lVar5 == null ||
                 (lVar5 = WorldData.GetArea(lVar5,uVar3,0)) == null))))) goto LAB_180e674c8;
            uVar10 = AreaData.GetAreaName(lVar5,0);
            lVar5 = this.missionTargetDatas;
            lVar9 = *(int64 *)(pStatics + 0x608);
            if (lVar5 == null) goto LAB_180e674c8;
            if (lVar5.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar5 = *(int64 *)(lVar5._items + 32);
            if ((((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 56)) == null) ||
                (lVar5 = FUN_180002f80(lVar5,iVar11,DAT_181d94e88)) == null) || (lVar9 == null))
            goto LAB_180e674c8;
            uVar6 = FUN_180002f80(lVar9,*(uint32 *)(lVar5 + 32),DAT_181da4358);
            lVar5 = this.missionTargetDatas;
            if (lVar5 == null) goto LAB_180e674c8;
            if (lVar5.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar5 = *(int64 *)(lVar5._items + 32);
            if (((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 56)) == null) ||
               (lVar5 = FUN_180002f80(lVar5,iVar11,DAT_181d94e88)) == null) goto LAB_180e674c8;
            local_a4 = *(uint32 *)(lVar5 + 40);
            uVar7 = il2cpp_value_box(DAT_181da22d8,&local_a4);
            uVar10 = String.Format("提升{0}的{1}{2}点",uVar10,uVar6,uVar7,0);
            lVar5 = String.Concat(lVar4,uVar10,0);
            goto LAB_180e67234;
          case 5:
            lVar5 = this.missionTargetDatas;
            if (lVar5 == null) {
        LAB_180e674ce:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            if (lVar5.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar5 = *(int64 *)(lVar5._items + 32);
            if (((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 56)) == null) ||
               (lVar5 = FUN_180002f80(lVar5,iVar11,DAT_181d94e88)) == null) goto LAB_180e674ce;
            local_a0 = *(uint32 *)(lVar5 + 40);
            uVar10 = il2cpp_value_box(DAT_181da22d8,&local_a0);
            lVar5 = this.missionTargetDatas;
            lVar9 = *(int64 *)(pStatics + 0x4d0);
            if (lVar5 == null) goto LAB_180e674ce;
            if (lVar5.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar5 = *(int64 *)(lVar5._items + 32);
            if ((((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 56)) == null) ||
                (lVar5 = FUN_180002f80(lVar5,iVar11,DAT_181d94e88)) == null) || (lVar9 == null))
            goto LAB_180e674ce;
            uVar7 = FUN_180002f80(lVar9,*(uint32 *)(lVar5 + 32),DAT_181da4358);
            uVar6 = "制作价值{0}的{1}";
            break;
          case 6:
            lVar5 = this.missionTargetDatas;
            if (lVar5 == null) {
        LAB_180e674d4:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            if (lVar5.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar5 = *(int64 *)(lVar5._items + 32);
            if (((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 56)) == null) ||
               (lVar5 = FUN_180002f80(lVar5,iVar11,DAT_181d94e88)) == null) goto LAB_180e674d4;
            local_9c = *(uint32 *)(lVar5 + 40);
            uVar10 = il2cpp_value_box(DAT_181da22d8,&local_9c);
            lVar5 = this.missionTargetDatas;
            lVar9 = *(int64 *)(pStatics + 0x3d8);
            if (lVar5 == null) goto LAB_180e674d4;
            if (lVar5.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar5 = *(int64 *)(lVar5._items + 32);
            if ((((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 56)) == null) ||
                (lVar5 = FUN_180002f80(lVar5,iVar11,DAT_181d94e88)) == null) || (lVar9 == null))
            goto LAB_180e674d4;
            uVar6 = FUN_180002f80(lVar9,*(uint32 *)(lVar5 + 32),DAT_181da4358);
            lVar5 = this.missionTargetDatas;
            if (lVar5 == null) goto LAB_180e674d4;
            if (lVar5.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar5 = *(int64 *)(lVar5._items + 32);
            if (((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 56)) == null) ||
               (lVar5 = FUN_180002f80(lVar5,iVar11,DAT_181d94e88)) == null) goto LAB_180e674d4;
            uVar7 = GlobalData.GenerateRareLvColorText(uVar6,*(uint32 *)(lVar5 + 32),0);
            uVar6 = "招募{0}名{1}";
            break;
          case 7:
            lVar5 = this.missionTargetDatas;
            if (lVar5 == null) {
        LAB_180e674da:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            if (lVar5.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar5 = *(int64 *)(lVar5._items + 32);
            if (((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 56)) == null) ||
               (lVar5 = FUN_180002f80(lVar5,iVar11,DAT_181d94e88)) == null) goto LAB_180e674da;
            local_98 = *(uint32 *)(lVar5 + 40);
            uVar10 = il2cpp_value_box(DAT_181da22d8,&local_98);
            lVar5 = this.missionTargetDatas;
            lVar9 = *(int64 *)(pStatics + 0x4f8);
            if (lVar5 == null) goto LAB_180e674da;
            if (lVar5.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar5 = *(int64 *)(lVar5._items + 32);
            if (((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 56)) == null) ||
               ((lVar5 = FUN_180002f80(lVar5,iVar11,DAT_181d94e88), lVar5 == null || (lVar9 == null))))
            goto LAB_180e674da;
            uVar6 = FUN_180002f80(lVar9,*(uint32 *)(lVar5 + 32),DAT_181da4358);
            lVar5 = this.missionTargetDatas;
            if (lVar5 == null) goto LAB_180e674da;
            if (lVar5.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar5 = *(int64 *)(lVar5._items + 32);
            if (((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 56)) == null) ||
               (lVar5 = FUN_180002f80(lVar5,iVar11,DAT_181d94e88)) == null) goto LAB_180e674da;
            uVar7 = GlobalData.GenerateRareLvColorText(uVar6,*(uint32 *)(lVar5 + 32),0);
            uVar6 = "学习{0}门{1}武功";
            break;
          case 8:
            plVar8 = (int64 *)FUN_1800d60b0(DAT_181da4120,4);
            lVar9 = FUN_18046c100(0);
            lVar5 = this.missionTargetDatas;
            if (lVar5 == null) {
        LAB_180e67560:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            if (lVar5.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar5 = *(int64 *)(lVar5._items + 32);
            if (((((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 56)) == null) ||
                 (lVar5 = FUN_180002f80(lVar5,iVar11,DAT_181d94e88)) == null) ||
                ((uVar3 = Int32.Parse(lVar5.Count,0), lVar9 == null ||
                 (lVar5 = GameDataController.GetSkillDataBase(lVar9,uVar3,0)) == null))) ||
               (lVar5 = KungfuSkillData.Name(lVar5,1,0), plVar8 == (int64 *)0)) goto LAB_180e67560;
            if ((lVar5 != null) &&
               (lVar9 = il2cpp_internal(lVar5,*(uint64 *)(*plVar8 + 64))) == null) {
              uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar10,0);
            }
            if ((int)plVar8[3] == 0) {
              uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar10,0);
            }
            plVar8[4] = lVar5;
            il2cpp_internal(plVar8 + 4,lVar5);
            lVar5 = FUN_18046c0a0(0);
            if ((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) goto LAB_180e67560;
            lVar9 = WorldData.Player(*(int64 *)(lVar5 + 32),0);
            lVar5 = this.missionTargetDatas;
            if (lVar5 == null) goto LAB_180e67560;
            if (lVar5.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar5 = *(int64 *)(lVar5._items + 32);
            if ((((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 56)) == null) ||
                (lVar5 = FUN_180002f80(lVar5,iVar11,DAT_181d94e88)) == null) ||
               ((uVar3 = Int32.Parse(lVar5.Count,0), lVar9 == null ||
                (lVar5 = HeroData.FindSkill(lVar9,uVar3,0)) == null))) goto LAB_180e67560;
            local_94 = *(uint32 *)(lVar5 + 20);
            lVar5 = il2cpp_value_box(DAT_181d80418,&local_94);
            if ((lVar5 != null) &&
               (lVar9 = il2cpp_internal(lVar5,*(uint64 *)(*plVar8 + 64))) == null) {
              uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar10,0);
            }
            if (*(uint32 *)(plVar8 + 3) < 2) {
              uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar10,0);
            }
            plVar8[5] = lVar5;
            il2cpp_internal(plVar8 + 5,lVar5);
            lVar5 = this.missionTargetDatas;
            if (lVar5 == null) goto LAB_180e67560;
            if (lVar5.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar5 = *(int64 *)(lVar5._items + 32);
            if (((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 56)) == null) ||
               (lVar5 = FUN_180002f80(lVar5,iVar11,DAT_181d94e88)) == null) goto LAB_180e67560;
            local_90 = *(uint32 *)(lVar5 + 40);
            lVar5 = il2cpp_value_box(DAT_181da22d8,&local_90);
            if ((lVar5 != null) &&
               (lVar9 = il2cpp_internal(lVar5,*(uint64 *)(*plVar8 + 64))) == null) {
              uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar10,0);
            }
            if (*(uint32 *)(plVar8 + 3) < 3) {
              uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar10,0);
            }
            plVar8[6] = lVar5;
            il2cpp_internal(plVar8 + 6,lVar5);
            lVar5 = *(int64 *)(pStatics + 0x4a0);
            lVar9 = this.missionTargetDatas;
            lVar1 = *(int64 *)(*(int64 *)(DAT_181d72d50 + 184) + 32);
            if (lVar9 == null) goto LAB_180e67560;
            if (lVar9.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar9 = *(int64 *)(lVar9._items + 32);
            if ((((lVar9 == null) || (lVar9 = *(int64 *)(lVar9 + 56)) == null) ||
                (lVar9 = FUN_180002f80(lVar9,iVar11,DAT_181d94e88)) == null) ||
               (((uVar3 = Int32.Parse(lVar9.Count,0), lVar1 == null ||
                 (lVar9 = GameDataController.GetSkillDataBase(lVar1,uVar3,0)) == null) ||
                (lVar5 == null)))) goto LAB_180e67560;
            lVar5 = FUN_180002f80(lVar5,*(uint32 *)(lVar9 + 48));
            if ((lVar5 != null) &&
               (lVar9 = il2cpp_internal(lVar5,*(uint64 *)(*plVar8 + 64))) == null) {
              uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar10,0);
            }
            if (*(uint32 *)(plVar8 + 3) < 4) {
              uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar10,0);
            }
            plVar8[7] = lVar5;
            il2cpp_internal(plVar8 + 7,lVar5);
            uVar10 = String.Format("{3}{0}({1}级)提升{2}级",plVar8);
            lVar5 = String.Concat(lVar4,uVar10,0);
            goto LAB_180e67234;
          case 9:
            lVar5 = this.missionTargetDatas;
            lVar9 = *(int64 *)(pStatics + 0x4b0);
            if (lVar5 == null) {
        LAB_180e67566:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            if (lVar5.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar5 = *(int64 *)(lVar5._items + 32);
            if ((((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 56)) == null) ||
                (lVar5 = FUN_180002f80(lVar5,iVar11,DAT_181d94e88)) == null) ||
               (uVar3 = Int32.Parse(lVar5.Count,0), lVar9 == null)) goto LAB_180e67566;
            uVar10 = FUN_180002f80(lVar9,uVar3,DAT_181da4358);
            lVar5 = FUN_18046c0a0(0);
            if (((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) ||
               (lVar5 = WorldData.Player(*(int64 *)(lVar5 + 32),0)) == null) goto LAB_180e67566;
            lVar9 = this.missionTargetDatas;
            lVar5 = *(int64 *)(lVar5 + 0x158);
            if (lVar9 == null) goto LAB_180e67566;
            if (lVar9.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar9 = *(int64 *)(lVar9._items + 32);
            if ((((lVar9 == null) || (lVar9 = *(int64 *)(lVar9 + 56)) == null) ||
                (lVar9 = FUN_180002f80(lVar9,iVar11,DAT_181d94e88)) == null) ||
               (uVar3 = Int32.Parse(lVar9.Count,0), lVar5 == null)) goto LAB_180e67566;
            local_8c = FUN_1800d6790(lVar5,uVar3,DAT_181da1078);
            uVar6 = il2cpp_value_box(DAT_181da22d8,&local_8c);
            lVar5 = this.missionTargetDatas;
            if (lVar5 == null) goto LAB_180e67566;
            if (lVar5.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar5 = *(int64 *)(lVar5._items + 32);
            if (((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 56)) == null) ||
               (lVar5 = FUN_180002f80(lVar5,iVar11,DAT_181d94e88)) == null) goto LAB_180e67566;
            local_88 = *(uint32 *)(lVar5 + 40);
            uVar7 = il2cpp_value_box(DAT_181da22d8,&local_88);
            uVar10 = String.Format("{0}({1}级)提升{2}级",uVar10,uVar6,uVar7,0);
            lVar5 = String.Concat(lVar4,uVar10,0);
            goto LAB_180e67234;
          case 10:
            lVar5 = this.missionTargetDatas;
            if (lVar5 == null) {
        LAB_180e6756c:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            if (lVar5.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar5 = *(int64 *)(lVar5._items + 32);
            if (((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 56)) == null) ||
               (lVar5 = FUN_180002f80(lVar5,iVar11,DAT_181d94e88)) == null) goto LAB_180e6756c;
            local_84 = *(uint32 *)(lVar5 + 40);
            uVar10 = il2cpp_value_box(DAT_181da22d8,&local_84);
            lVar9 = FUN_18046c100(0);
            lVar5 = this.missionTargetDatas;
            if (lVar5 == null) goto LAB_180e6756c;
            if (lVar5.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar5 = *(int64 *)(lVar5._items + 32);
            if ((((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 56)) == null) ||
                (lVar5 = FUN_180002f80(lVar5,iVar11,DAT_181d94e88)) == null) ||
               ((uVar3 = Int32.Parse(lVar5.Count,0), lVar9 == null ||
                (lVar5 = GameDataController.GetSkillDataBase(lVar9,uVar3,0)) == null)))
            goto LAB_180e6756c;
            uVar7 = KungfuSkillData.Name(lVar5,1,0);
            uVar6 = "编纂{0}本{1}秘籍";
            break;
          case 11:
            lVar5 = FUN_18046c0a0(0);
            if (lVar5 == null) goto LAB_180e67606;
            lVar9 = this.missionTargetDatas;
            lVar5 = *(int64 *)(lVar5 + 32);
            if (lVar9 == null) goto LAB_180e67606;
            if (lVar9.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar9 = *(int64 *)(lVar9._items + 32);
            if ((((lVar9 == null) || (lVar9 = *(int64 *)(lVar9 + 56)) == null) ||
                (lVar9 = FUN_180002f80(lVar9,iVar11,DAT_181d94e88)) == null) ||
               (uVar3 = Int32.Parse(lVar9.Count,0), lVar5 == null)) goto LAB_180e67606;
            lVar5 = WorldData.GetHero(lVar5,uVar3,0);
            if (lVar5 == null) {
              return "任务对象已死亡";
            }
            lVar5 = FUN_18046c0a0(0);
            if (lVar5 == null) {
        LAB_180e67572:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar9 = this.missionTargetDatas;
            lVar5 = *(int64 *)(lVar5 + 32);
            if (lVar9 == null) goto LAB_180e67572;
            if (lVar9.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar9 = *(int64 *)(lVar9._items + 32);
            if (((lVar9 == null) || (lVar9 = *(int64 *)(lVar9 + 56)) == null) ||
               ((lVar9 = FUN_180002f80(lVar9,iVar11,DAT_181d94e88), lVar9 == null ||
                ((uVar3 = Int32.Parse(lVar9.Count,0), lVar5 == null ||
                 (lVar5 = WorldData.GetHero(lVar5,uVar3,0)) == null))))) goto LAB_180e67572;
            uVar10 = HeroData.Name(lVar5,1,0);
            lVar5 = this.missionTargetDatas;
            if (lVar5 == null) goto LAB_180e67572;
            if (lVar5.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar5 = *(int64 *)(lVar5._items + 32);
            if (((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 56)) == null) ||
               (lVar5 = FUN_180002f80(lVar5,iVar11,DAT_181d94e88)) == null) goto LAB_180e67572;
            local_80 = *(uint32 *)(lVar5 + 40);
            uVar7 = il2cpp_value_box(DAT_181da22d8,&local_80);
            uVar6 = "与{0}切磋获胜{1}次";
            break;
          case 12:
            lVar5 = FUN_18046c0a0(0);
            if (lVar5 == null) goto LAB_180e67606;
            lVar9 = this.missionTargetDatas;
            lVar5 = *(int64 *)(lVar5 + 32);
            if (lVar9 == null) goto LAB_180e67606;
            if (lVar9.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar9 = *(int64 *)(lVar9._items + 32);
            if (((lVar9 == null) || (lVar9 = *(int64 *)(lVar9 + 56)) == null) ||
               ((lVar9 = FUN_180002f80(lVar9,iVar11,DAT_181d94e88), lVar9 == null ||
                (uVar3 = Int32.Parse(lVar9.Count,0), lVar5 == null)))) goto LAB_180e67606;
            lVar5 = WorldData.GetHero(lVar5,uVar3,0);
            if (lVar5 == null) {
              return "任务对象已死亡";
            }
            lVar5 = FUN_18046c0a0(0);
            if (lVar5 == null) {
        LAB_180e67578:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar9 = this.missionTargetDatas;
            lVar5 = *(int64 *)(lVar5 + 32);
            if (lVar9 == null) goto LAB_180e67578;
            if (lVar9.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar9 = *(int64 *)(lVar9._items + 32);
            if ((((lVar9 == null) || (lVar9 = *(int64 *)(lVar9 + 56)) == null) ||
                (lVar9 = FUN_180002f80(lVar9,iVar11,DAT_181d94e88)) == null) ||
               ((uVar3 = Int32.Parse(lVar9.Count,0), lVar5 == null ||
                (lVar5 = WorldData.GetHero(lVar5,uVar3,0)) == null))) goto LAB_180e67578;
            uVar10 = HeroData.Name(lVar5,1,0);
            lVar5 = this.missionTargetDatas;
            if (lVar5 == null) goto LAB_180e67578;
            if (lVar5.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar5 = *(int64 *)(lVar5._items + 32);
            if (((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 56)) == null) ||
               (lVar5 = FUN_180002f80(lVar5,iVar11,DAT_181d94e88)) == null) goto LAB_180e67578;
            local_7c = *(uint32 *)(lVar5 + 40);
            uVar7 = il2cpp_value_box(DAT_181da22d8,&local_7c);
            uVar6 = "向{0}传授{1}门武功";
            break;
          case 13:
            lVar5 = this.missionTargetDatas;
            if (lVar5 == null) {
        LAB_180e6757e:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            if (lVar5.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar5 = *(int64 *)(lVar5._items + 32);
            if (((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 56)) == null) ||
               (lVar5 = FUN_180002f80(lVar5,iVar11,DAT_181d94e88)) == null) goto LAB_180e6757e;
            local_78 = *(uint32 *)(lVar5 + 40);
            uVar10 = il2cpp_value_box(DAT_181da22d8,&local_78);
            lVar5 = this.missionTargetDatas;
            lVar9 = *(int64 *)(pStatics + 0x4f8);
            if (lVar5 == null) goto LAB_180e6757e;
            if (lVar5.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar5 = *(int64 *)(lVar5._items + 32);
            if (((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 56)) == null) ||
               ((lVar5 = FUN_180002f80(lVar5,iVar11,DAT_181d94e88), lVar5 == null || (lVar9 == null))))
            goto LAB_180e6757e;
            uVar6 = FUN_180002f80(lVar9,*(uint32 *)(lVar5 + 32),DAT_181da4358);
            lVar5 = this.missionTargetDatas;
            if (lVar5 == null) goto LAB_180e6757e;
            if (lVar5.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar5 = *(int64 *)(lVar5._items + 32);
            if (((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 56)) == null) ||
               (lVar5 = FUN_180002f80(lVar5,iVar11,DAT_181d94e88)) == null) goto LAB_180e6757e;
            uVar7 = GlobalData.GenerateRareLvColorText(uVar6,*(uint32 *)(lVar5 + 32),0);
            uVar6 = "搜集{0}本{1}秘籍";
            break;
          case 14:
            lVar5 = FUN_18046c0a0(0);
            if (lVar5 == null) {
        LAB_180e67584:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar9 = this.missionTargetDatas;
            lVar5 = *(int64 *)(lVar5 + 32);
            if (lVar9 == null) goto LAB_180e67584;
            if (lVar9.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar9 = *(int64 *)(lVar9._items + 32);
            if ((((lVar9 == null) || (lVar9 = *(int64 *)(lVar9 + 56)) == null) ||
                (lVar9 = FUN_180002f80(lVar9,iVar11,DAT_181d94e88)) == null) ||
               ((uVar3 = Int32.Parse(lVar9.Count,0), lVar5 == null ||
                (lVar5 = WorldData.GetForce(lVar5,uVar3,0)) == null))) goto LAB_180e67584;
            uVar10 = ForceData.GetForceName(lVar5,1,0);
            lVar5 = this.missionTargetDatas;
            if (lVar5 == null) goto LAB_180e67584;
            if (lVar5.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar5 = *(int64 *)(lVar5._items + 32);
            if (((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 56)) == null) ||
               (lVar5 = FUN_180002f80(lVar5,iVar11,DAT_181d94e88)) == null) goto LAB_180e67584;
            local_74 = *(uint32 *)(lVar5 + 40);
            uVar7 = il2cpp_value_box(DAT_181da22d8,&local_74);
            uVar6 = "提升与{0}的关系{1}点";
            break;
          case 15:
            lVar5 = FUN_18046c0a0(0);
            if (lVar5 == null) {
        LAB_180e6758a:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar9 = this.missionTargetDatas;
            lVar5 = *(int64 *)(lVar5 + 32);
            if (lVar9 == null) goto LAB_180e6758a;
            if (lVar9.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar9 = *(int64 *)(lVar9._items + 32);
            if ((((lVar9 == null) || (lVar9 = *(int64 *)(lVar9 + 56)) == null) ||
                (lVar9 = FUN_180002f80(lVar9,iVar11,DAT_181d94e88)) == null) ||
               ((uVar3 = Int32.Parse(lVar9.Count,0), lVar5 == null ||
                (lVar5 = WorldData.GetForce(lVar5,uVar3,0)) == null))) goto LAB_180e6758a;
            uVar10 = ForceData.GetForceName(lVar5,1,0);
            lVar5 = this.missionTargetDatas;
            if (lVar5 == null) goto LAB_180e6758a;
            if (lVar5.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar5 = *(int64 *)(lVar5._items + 32);
            if (((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 56)) == null) ||
               (lVar5 = FUN_180002f80(lVar5,iVar11,DAT_181d94e88)) == null) goto LAB_180e6758a;
            local_70 = *(uint32 *)(lVar5 + 40);
            uVar7 = il2cpp_value_box(DAT_181da22d8,&local_70);
            uVar6 = "降低与{0}的关系{1}点";
            break;
          case 16:
            lVar5 = FUN_18046c0a0(0);
            if (lVar5 == null) goto LAB_180e67606;
            lVar9 = this.missionTargetDatas;
            lVar5 = *(int64 *)(lVar5 + 32);
            if (lVar9 == null) goto LAB_180e67606;
            if (lVar9.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar9 = *(int64 *)(lVar9._items + 32);
            if (((lVar9 == null) || (lVar9 = *(int64 *)(lVar9 + 56)) == null) ||
               ((lVar9 = FUN_180002f80(lVar9,iVar11,DAT_181d94e88), lVar9 == null ||
                (uVar3 = Int32.Parse(lVar9.Count,0), lVar5 == null)))) goto LAB_180e67606;
            lVar5 = WorldData.GetHero(lVar5,uVar3,0);
            if (lVar5 == null) {
              return "任务对象已死亡";
            }
            lVar5 = FUN_18046c0a0(0);
            if (lVar5 == null) {
        LAB_180e67590:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar9 = this.missionTargetDatas;
            lVar5 = *(int64 *)(lVar5 + 32);
            if (lVar9 == null) goto LAB_180e67590;
            if (lVar9.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar9 = *(int64 *)(lVar9._items + 32);
            if ((((lVar9 == null) || (lVar9 = *(int64 *)(lVar9 + 56)) == null) ||
                (lVar9 = FUN_180002f80(lVar9,iVar11,DAT_181d94e88)) == null) ||
               ((uVar3 = Int32.Parse(lVar9.Count,0), lVar5 == null ||
                (lVar5 = WorldData.GetHero(lVar5,uVar3,0)) == null))) goto LAB_180e67590;
            uVar10 = HeroData.GetHeroName(lVar5,0,0);
            lVar5 = this.missionTargetDatas;
            if (lVar5 == null) goto LAB_180e67590;
            if (lVar5.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar5 = *(int64 *)(lVar5._items + 32);
            if (((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 56)) == null) ||
               (lVar5 = FUN_180002f80(lVar5,iVar11,DAT_181d94e88)) == null) goto LAB_180e67590;
            local_6c = *(uint32 *)(lVar5 + 40);
            uVar7 = il2cpp_value_box(DAT_181da22d8,&local_6c);
            uVar6 = "袭击{0}{1}次";
            break;
          case 17:
            lVar5 = FUN_18046c0a0(0);
            if (lVar5 == null) {
        LAB_180e67596:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar9 = this.missionTargetDatas;
            lVar5 = *(int64 *)(lVar5 + 32);
            if (lVar9 == null) goto LAB_180e67596;
            if (lVar9.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar9 = *(int64 *)(lVar9._items + 32);
            if ((((lVar9 == null) || (lVar9 = *(int64 *)(lVar9 + 56)) == null) ||
                (lVar9 = FUN_180002f80(lVar9,iVar11,DAT_181d94e88)) == null) ||
               ((uVar3 = Int32.Parse(lVar9.Count,0), lVar5 == null ||
                (lVar5 = WorldData.GetArea(lVar5,uVar3,0)) == null))) goto LAB_180e67596;
            uVar10 = AreaData.GetAreaName(lVar5,0);
            lVar5 = this.missionTargetDatas;
            lVar9 = *(int64 *)(pStatics + 0x608);
            if (lVar5 == null) goto LAB_180e67596;
            if (lVar5.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar5 = *(int64 *)(lVar5._items + 32);
            if (((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 56)) == null) ||
               ((lVar5 = FUN_180002f80(lVar5,iVar11,DAT_181d94e88), lVar5 == null || (lVar9 == null))))
            goto LAB_180e67596;
            uVar6 = FUN_180002f80(lVar9,*(uint32 *)(lVar5 + 32),DAT_181da4358);
            if ((((this.missionTargetDatas == null) ||
                 (lVar5 = FUN_180002f80(this.missionTargetDatas,0,DAT_181d95108)) == null) ||
                (*(int64 *)(lVar5 + 56) == 0)) ||
               (lVar5 = FUN_180002f80(*(int64 *)(lVar5 + 56),iVar11,DAT_181d94e88)) == null)
            goto LAB_180e67596;
            local_68 = *(uint32 *)(lVar5 + 40);
            uVar7 = il2cpp_value_box(DAT_181da22d8,&local_68);
            uVar10 = String.Format("降低{0}的{1}{2}点",uVar10,uVar6,uVar7,0);
            lVar5 = String.Concat(lVar4,uVar10,0);
            goto LAB_180e67234;
          case 18:
            lVar5 = FUN_18046c0a0(0);
            if (lVar5 == null) {
        LAB_180e6759c:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar5 = *(int64 *)(lVar5 + 32);
            if ((((this.missionTargetDatas == null) ||
                 (lVar9 = FUN_180002f80(this.missionTargetDatas,0,DAT_181d95108)) == null) ||
                (*(int64 *)(lVar9 + 56) == 0)) ||
               (((lVar9 = FUN_180002f80(*(int64 *)(lVar9 + 56),iVar11,DAT_181d94e88), lVar9 == null ||
                 (uVar3 = Int32.Parse(lVar9.Count,0), lVar5 == null)) ||
                (lVar5 = WorldData.GetArea(lVar5,uVar3,0)) == null))) goto LAB_180e6759c;
            uVar10 = AreaData.GetAreaName(lVar5,0);
            if (((this.missionTargetDatas == null) ||
                (lVar5 = FUN_180002f80(this.missionTargetDatas,0,DAT_181d95108)) == null) ||
               ((*(int64 *)(lVar5 + 56) == 0 ||
                (lVar5 = FUN_180002f80(*(int64 *)(lVar5 + 56),iVar11,DAT_181d94e88)) == null)))
            goto LAB_180e6759c;
            local_64 = *(uint32 *)(lVar5 + 40);
            uVar7 = il2cpp_value_box(DAT_181da22d8,&local_64);
            uVar6 = "窃取{0}资源{1}次";
            break;
          case 19:
            lVar5 = FUN_18046c0a0(0);
            if (lVar5 == null) throw; // [null/range check failed]
            lVar5 = *(int64 *)(lVar5 + 32);
            if ((((this.missionTargetDatas == null) ||
                 (lVar9 = FUN_180002f80(this.missionTargetDatas,0,DAT_181d95108)) == null) ||
                (*(int64 *)(lVar9 + 56) == 0)) ||
               ((lVar9 = FUN_180002f80(*(int64 *)(lVar9 + 56),iVar11,DAT_181d94e88), lVar9 == null ||
                (uVar3 = Int32.Parse(lVar9.Count,0), lVar5 == null)))) throw; // [null/range check failed]
            lVar5 = WorldData.GetHero(lVar5,uVar3,0);
            if (lVar5 == null) {
              return "任务对象已死亡";
            }
            lVar5 = FUN_18046c0a0(0);
            if (lVar5 == null) {
        LAB_180e675a2:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar5 = *(int64 *)(lVar5 + 32);
            if ((((this.missionTargetDatas == null) ||
                 (lVar9 = FUN_180002f80(this.missionTargetDatas,0,DAT_181d95108)) == null) ||
                (*(int64 *)(lVar9 + 56) == 0)) ||
               (((lVar9 = FUN_180002f80(*(int64 *)(lVar9 + 56),iVar11,DAT_181d94e88), lVar9 == null ||
                 (uVar3 = Int32.Parse(lVar9.Count,0), lVar5 == null)) ||
                (lVar5 = WorldData.GetHero(lVar5,uVar3,0)) == null))) goto LAB_180e675a2;
            uVar10 = HeroData.GetHeroName(lVar5,0,0);
            if (((this.missionTargetDatas == null) ||
                (lVar5 = FUN_180002f80(this.missionTargetDatas,0,DAT_181d95108)) == null) ||
               ((*(int64 *)(lVar5 + 56) == 0 ||
                (lVar5 = FUN_180002f80(*(int64 *)(lVar5 + 56),iVar11,DAT_181d94e88)) == null)))
            goto LAB_180e675a2;
            local_60 = *(uint32 *)(lVar5 + 40);
            uVar7 = il2cpp_value_box(DAT_181da22d8,&local_60);
            uVar6 = "降低{0}忠诚{1}点";
            break;
          case 20:
            lVar5 = FUN_18046c0a0(0);
            if (lVar5 != null) {
              lVar5 = *(int64 *)(lVar5 + 32);
              if ((((this.missionTargetDatas != null) &&
                   (lVar9 = FUN_180002f80(this.missionTargetDatas,0,DAT_181d95108)) != null) &&
                  (*(int64 *)(lVar9 + 56) != 0)) &&
                 (((lVar9 = FUN_180002f80(*(int64 *)(lVar9 + 56),iVar11), lVar9 != null &&
                   (uVar3 = Int32.Parse(lVar9.Count,0), lVar5 != null)) &&
                  (lVar5 = WorldData.GetArea(lVar5,uVar3)) != null))) {
                uVar10 = AreaData.GetAreaName(lVar5,0);
                uVar10 = String.Format("攻略{0}",uVar10);
                lVar5 = String.Concat(lVar4,uVar10,0);
                goto LAB_180e67234;
              }
            }
            throw; // [null/range check failed]
          case 21:
            lVar5 = FUN_18046c0a0(0);
            if (lVar5 == null) {
        LAB_180e675a8:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar5 = *(int64 *)(lVar5 + 32);
            if ((((this.missionTargetDatas == null) ||
                 (lVar9 = FUN_180002f80(this.missionTargetDatas,0,DAT_181d95108)) == null) ||
                (*(int64 *)(lVar9 + 56) == 0)) ||
               (((lVar9 = FUN_180002f80(*(int64 *)(lVar9 + 56),iVar11,DAT_181d94e88), lVar9 == null ||
                 (uVar3 = Int32.Parse(lVar9.Count,0), lVar5 == null)) ||
                (lVar5 = WorldData.GetArea(lVar5,uVar3,0)) == null))) goto LAB_180e675a8;
            uVar10 = AreaData.GetAreaName(lVar5,0);
            if (((this.missionTargetDatas == null) ||
                (lVar5 = FUN_180002f80(this.missionTargetDatas,0,DAT_181d95108)) == null) ||
               ((*(int64 *)(lVar5 + 56) == 0 ||
                (lVar5 = FUN_180002f80(*(int64 *)(lVar5 + 56),iVar11,DAT_181d94e88)) == null)))
            goto LAB_180e675a8;
            local_5c = *(uint32 *)(lVar5 + 40);
            uVar7 = il2cpp_value_box(DAT_181da22d8,&local_5c);
            uVar6 = "在{0}岗哨巡查{1}次";
            break;
          case 22:
            if (((this.missionTargetDatas == null) ||
                (lVar5 = FUN_180002f80(this.missionTargetDatas,0,DAT_181d95108)) == null) ||
               ((*(int64 *)(lVar5 + 56) == 0 ||
                (lVar5 = FUN_180002f80(*(int64 *)(lVar5 + 56),iVar11,DAT_181d94e88)) == null))) {
        LAB_180e675ae:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            local_58 = *(uint32 *)(lVar5 + 40);
            uVar10 = il2cpp_value_box(DAT_181da22d8,&local_58);
            lVar5 = *(int64 *)(pStatics + 0x4f0);
            if ((((this.missionTargetDatas == null) ||
                 (lVar9 = FUN_180002f80(this.missionTargetDatas,0,DAT_181d95108)) == null) ||
                (*(int64 *)(lVar9 + 56) == 0)) ||
               ((lVar9 = FUN_180002f80(*(int64 *)(lVar9 + 56),iVar11,DAT_181d94e88), lVar9 == null ||
                (lVar5 == null)))) goto LAB_180e675ae;
            uVar6 = FUN_180002f80(lVar5,*(uint32 *)(lVar9 + 32),DAT_181da4358);
            if (((this.missionTargetDatas == null) ||
                ((lVar5 = FUN_180002f80(this.missionTargetDatas,0,DAT_181d95108), lVar5 == null ||
                 (*(int64 *)(lVar5 + 56) == 0)))) ||
               (lVar5 = FUN_180002f80(*(int64 *)(lVar5 + 56),iVar11,DAT_181d94e88)) == null)
            goto LAB_180e675ae;
            uVar7 = GlobalData.GenerateRareLvColorText(uVar6,*(uint32 *)(lVar5 + 32),0);
            uVar6 = "搜集{0}件{1}珍宝";
            break;
          case 23:
            lVar5 = FUN_18046c0a0(0);
            if (lVar5 == null) goto LAB_180e67606;
            lVar9 = this.missionTargetDatas;
            lVar5 = *(int64 *)(lVar5 + 32);
            if (lVar9 == null) goto LAB_180e67606;
            if (lVar9.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar9 = *(int64 *)(lVar9._items + 32);
            if ((((lVar9 == null) || (lVar9 = *(int64 *)(lVar9 + 56)) == null) ||
                (lVar9 = FUN_180002f80(lVar9,iVar11,DAT_181d94e88)) == null) ||
               (uVar3 = Int32.Parse(lVar9.Count,0), lVar5 == null)) goto LAB_180e67606;
            lVar5 = WorldData.GetHero(lVar5,uVar3,0);
            if (lVar5 == null) {
              return "任务对象已死亡";
            }
            lVar5 = FUN_18046c0a0(0);
            if (lVar5 == null) {
        LAB_180e675b4:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar9 = this.missionTargetDatas;
            lVar5 = *(int64 *)(lVar5 + 32);
            if (lVar9 == null) goto LAB_180e675b4;
            if (lVar9.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar9 = *(int64 *)(lVar9._items + 32);
            if (((lVar9 == null) || (lVar9 = *(int64 *)(lVar9 + 56)) == null) ||
               ((lVar9 = FUN_180002f80(lVar9,iVar11,DAT_181d94e88), lVar9 == null ||
                ((uVar3 = Int32.Parse(lVar9.Count,0), lVar5 == null ||
                 (lVar5 = WorldData.GetHero(lVar5,uVar3,0)) == null))))) goto LAB_180e675b4;
            uVar10 = HeroData.Name(lVar5,1,0);
            lVar5 = this.missionTargetDatas;
            if (lVar5 == null) goto LAB_180e675b4;
            if (lVar5.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar5 = *(int64 *)(lVar5._items + 32);
            if (((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 56)) == null) ||
               (lVar5 = FUN_180002f80(lVar5,iVar11,DAT_181d94e88)) == null) goto LAB_180e675b4;
            local_54 = *(uint32 *)(lVar5 + 40);
            uVar7 = il2cpp_value_box(DAT_181da22d8,&local_54);
            uVar6 = "指点{0}武功{1}次";
            break;
          case 24:
            lVar5 = FUN_18046c0a0(0);
            if (lVar5 == null) goto LAB_180e67606;
            lVar9 = this.missionTargetDatas;
            lVar5 = *(int64 *)(lVar5 + 32);
            if (lVar9 == null) goto LAB_180e67606;
            if (lVar9.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar9 = *(int64 *)(lVar9._items + 32);
            if (((lVar9 == null) || (lVar9 = *(int64 *)(lVar9 + 56)) == null) ||
               ((lVar9 = FUN_180002f80(lVar9,iVar11,DAT_181d94e88), lVar9 == null ||
                (uVar3 = Int32.Parse(lVar9.Count,0), lVar5 == null)))) goto LAB_180e67606;
            lVar5 = WorldData.GetHero(lVar5,uVar3,0);
            if (lVar5 == null) {
              return "任务对象已死亡";
            }
            lVar5 = FUN_18046c0a0(0);
            if (lVar5 == null) {
        LAB_180e675ba:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar9 = this.missionTargetDatas;
            lVar5 = *(int64 *)(lVar5 + 32);
            if (lVar9 == null) goto LAB_180e675ba;
            if (lVar9.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar9 = *(int64 *)(lVar9._items + 32);
            if ((((lVar9 == null) || (lVar9 = *(int64 *)(lVar9 + 56)) == null) ||
                (lVar9 = FUN_180002f80(lVar9,iVar11,DAT_181d94e88)) == null) ||
               ((uVar3 = Int32.Parse(lVar9.Count,0), lVar5 == null ||
                (lVar5 = WorldData.GetHero(lVar5,uVar3,0)) == null))) goto LAB_180e675ba;
            uVar10 = HeroData.GetHeroName(lVar5,0,0);
            lVar5 = this.missionTargetDatas;
            if (lVar5 == null) goto LAB_180e675ba;
            if (lVar5.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar5 = *(int64 *)(lVar5._items + 32);
            if (((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 56)) == null) ||
               (lVar5 = FUN_180002f80(lVar5,iVar11,DAT_181d94e88)) == null) goto LAB_180e675ba;
            local_50 = *(uint32 *)(lVar5 + 40);
            uVar7 = il2cpp_value_box(DAT_181da22d8,&local_50);
            uVar6 = "向{0}下毒{1}点";
            break;
          default:
            lVar5 = "";
            if (lVar4 != null) {
              lVar5 = lVar4;
            }
            goto LAB_180e67234;
          }
          uVar10 = String.Format(uVar6,uVar10,uVar7,0);
          lVar5 = String.Concat(lVar4,uVar10,0);
        LAB_180e67234:
          if (local_res10) {
            plVar8 = (int64 *)FUN_1800d60b0(DAT_181da4120,4);
            cVar2 = MissionData.MissionNeedFinished(this,iVar11,0);
            uVar6 = "({0}{1}/{2}{3})";
            uVar10 = "  ";
            lVar4 = "";
            if (cVar2) {
              lVar4 = *(int64 *)(pStatics + 0x268);
            }
            if (plVar8 == (int64 *)0) {
        LAB_180e67600:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            if ((lVar4 != null) &&
               (lVar9 = il2cpp_internal(lVar4,*(uint64 *)(*plVar8 + 64))) == null) {
              uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar10,0);
            }
            FUN_180002fd0(plVar8,0,lVar4);
            if ((((this.missionTargetDatas == null) ||
                 (lVar4 = FUN_180002f80(this.missionTargetDatas,0,DAT_181d95108)) == null) ||
                (*(int64 *)(lVar4 + 56) == 0)) ||
               (lVar4 = FUN_180002f80(*(int64 *)(lVar4 + 56),iVar11,DAT_181d94e88)) == null)
            goto LAB_180e67600;
            local_4c = (int)*(float *)(lVar4 + 36);
            lVar4 = il2cpp_value_box(DAT_181d80418,&local_4c);
            if ((lVar4 != null) &&
               (lVar9 = il2cpp_internal(lVar4,*(uint64 *)(*plVar8 + 64))) == null) {
              uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar10,0);
            }
            FUN_180002fd0(plVar8,1,lVar4);
            if (((this.missionTargetDatas == null) ||
                (lVar4 = FUN_180002f80(this.missionTargetDatas,0,DAT_181d95108)) == null) ||
               ((*(int64 *)(lVar4 + 56) == 0 ||
                (lVar4 = FUN_180002f80(*(int64 *)(lVar4 + 56),iVar11,DAT_181d94e88)) == null)))
            goto LAB_180e67600;
            local_48[0] = Mathf.CeilToInt(*(uint32 *)(lVar4 + 40),0);
            lVar4 = il2cpp_value_box(DAT_181d80418,local_48);
            if ((lVar4 != null) &&
               (lVar9 = il2cpp_internal(lVar4,*(uint64 *)(*plVar8 + 64))) == null) {
              uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar10,0);
            }
            FUN_180002fd0(plVar8,2,lVar4);
            cVar2 = MissionData.MissionNeedFinished(this,iVar11,0);
            lVar4 = "";
            if (cVar2) {
              lVar4 = "</color>";
            }
            if ((lVar4 != null) &&
               (lVar9 = il2cpp_internal(lVar4,*(uint64 *)(*plVar8 + 64))) == null) {
              uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar10,0);
            }
            FUN_180002fd0(plVar8,3,lVar4);
            String.Format(uVar6,plVar8,0);
            lVar5 = String.Concat(lVar5,uVar10);
          }
          iVar11 = iVar11 + 1;
        }
    }

    // Token : 0x600131D
    // RVA   : 0xE68850   Offset: 0xE67C50   Length: 0x10A
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

    // Token : 0x600131E
    // RVA   : 0xE63540   Offset: 0xE62940   Length: 0x175
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
        plVar1 = (int64 *)il2cpp_internal(DAT_181d89210);
        plVar4 = plVar1;
        MemoryStream.ctor(plVar1,1000,0);
        local_38 = 0;
        uStack_30 = 0;
        StreamingContext.ctor(&local_38,64,0);
        lVar2 = il2cpp_internal(DAT_181db1730);
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
            FUN_180002970(0,DAT_181d78da0,plVar1);
            return uVar3;
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
    }

    // Token : 0x600131F
    // RVA   : 0xE69000   Offset: 0xE68400   Length: 0x497
    private static void /*cctor*/()
    {
        var pStatics = *(int64*)(DAT_181d8a990 + 184);
        long lVar1;
        lVar1 = il2cpp_internal(DAT_181d97750);
        FUN_18132faf0(lVar1,DAT_181da3bd8);
        if (lVar1 != null) {
          FUN_18181e0a0(lVar1,"#SourceForceName#功绩",DAT_181da3d58);
          FUN_18181e0a0(lVar1,"声望",DAT_181da3d58);
          FUN_18181e0a0(lVar1,"官府功绩",DAT_181da3d58);
          FUN_18181e0a0(lVar1,"#SourceHeroName#好感",DAT_181da3d58);
          plVar2 = pStatics;
          *plVar2 = lVar1;
          il2cpp_internal(plVar2,lVar1);
          lVar1 = il2cpp_internal(DAT_181d96ed0);
          FUN_18132faf0(lVar1,DAT_181da0cf8);
          if (lVar1 != null) {
            FUN_18181de10(lVar1,0,DAT_181da0df8);
            FUN_18181de10(lVar1,0x41200000,DAT_181da0df8);
            FUN_18181de10(lVar1,0x41200000,DAT_181da0df8);
            FUN_18181de10(lVar1,0x41700000,DAT_181da0df8);
            FUN_18181de10(lVar1,0x41700000,DAT_181da0df8);
            FUN_18181de10(lVar1,0x41a00000,DAT_181da0df8);
            FUN_18181de10(lVar1,0x41c80000,DAT_181da0df8);
            FUN_18181de10(lVar1,0x41700000,DAT_181da0df8);
            FUN_18181de10(lVar1,0x41200000,DAT_181da0df8);
            FUN_18181de10(lVar1,0x41200000,DAT_181da0df8);
            FUN_18181de10(lVar1,0x41a00000,DAT_181da0df8);
            FUN_18181de10(lVar1,0x41200000,DAT_181da0df8);
            FUN_18181de10(lVar1,0x41a00000,DAT_181da0df8);
            FUN_18181de10(lVar1,0x41c80000,DAT_181da0df8);
            FUN_18181de10(lVar1,0x41a00000,DAT_181da0df8);
            FUN_18181de10(lVar1,0x41200000,DAT_181da0df8);
            FUN_18181de10(lVar1,0x41a00000,DAT_181da0df8);
            FUN_18181de10(lVar1,0x41c80000,DAT_181da0df8);
            FUN_18181de10(lVar1,0x41700000,DAT_181da0df8);
            FUN_18181de10(lVar1,0x41a00000,DAT_181da0df8);
            FUN_18181de10(lVar1,0,DAT_181da0df8);
            FUN_18181de10(lVar1,0x41200000,DAT_181da0df8);
            FUN_18181de10(lVar1,0x41700000,DAT_181da0df8);
            FUN_18181de10(lVar1,0x41700000,DAT_181da0df8);
            FUN_18181de10(lVar1,0x41500000,DAT_181da0df8);
            MissionData.MissionTargetTypeBaseMissionContribution = lVar1;
            lVar1 = il2cpp_internal(DAT_181d94cd0);
            FUN_18132faf0(lVar1,DAT_181d95188);
            if (lVar1 != null) {
              FUN_18182a0b0(lVar1,3,DAT_181d95208);
              FUN_18182a0b0(lVar1,11,DAT_181d95208);
              FUN_18182a0b0(lVar1,12,DAT_181d95208);
              FUN_18182a0b0(lVar1,16,DAT_181d95208);
              FUN_18182a0b0(lVar1,24,DAT_181d95208);
              FUN_18182a0b0(lVar1,19,DAT_181d95208);
              FUN_18182a0b0(lVar1,23,DAT_181d95208);
              MissionData.MissionTargetNpc = lVar1;
              return;
            }
          }
        }
    }

}
