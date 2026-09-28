// ============================================================
// Type  : FightMatchController
// Token : 0x200027F
// ============================================================

public class FightMatchController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400141E
    public FightMatchType fightMatchType;

    // Token: 0x400141F
    public GameObject fightMatchPanel;

    // Token: 0x4001420
    public GameObject nextButton;

    // Token: 0x4001421
    public GameObject fightMatchCouplePrefab;

    // Token: 0x4001422
    public float matchDifficulty;

    // Token: 0x4001423
    public List<ItemData> rewardList;

    // Token: 0x4001424
    public List<FightMatchCouple> fightMatchCoupleList;

    // Token: 0x4001425
    public List<HeroData> HeroFinalList;

    // Token: 0x4001426
    public int fightRound;

    // Token: 0x4001427
    public WatchFightType watchFightType;

    // Token: 0x4001428
    public FightMatchCouple nowFightMatchCouple;

    // Token: 0x4001429
    public FightMatchCouple nextFightMatchCouple;

    // Token: 0x400142A
    public string endMatchCallPlot;

    // Token: 0x400142B
    public bool isForceMatch;

    // Token: 0x400142C
    public bool isForceGroupMatch;

    // Token: 0x400142D
    public List<List<int>> forceGroupMatchHeroList;

    // Token: 0x400142E
    public bool skipping;

    // Token: 0x400142F
    public GameObject skipButton;

    // Token: 0x4001430
    public List<Sprite> nextIconSprite;

    // Token: 0x4001431
    public List<Sprite> middleIconSprite;

    // Token: 0x4001432
    private GameObject tempObj;

    // Token: 0x4001433
    public static List<string> AreaFightMatchResultString;

    // Token: 0x4001434
    public static List<int> AreaFightMatchMoneyReward;

    // Token: 0x4001435
    public static List<int> AreaFightMatchFameReward;

    // Token: 0x4001436
    public static List<string> ForceFightMatchResultString;

    // Token: 0x4001437
    public static List<int> ForceFightMatchMoneyReward;

    // Token: 0x4001438
    public static List<int> ForceFightMatchContriReward;

    // Token: 0x4001439
    public static List<string> AreaDebateMatchResultString;

    // Token: 0x400143A
    private static FightMatchController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600145E
    // RVA   : 0xB2D4B0   Offset: 0xB2C8B0   Length: 0x58
    public static FightMatchController get_Instance()
    {
        return *(uint64 *)(*(int64 *)(DAT_181dc6e20 + 184) + 56);
    }

    // Token : 0x600145F
    // RVA   : 0xB2A220   Offset: 0xB29620   Length: 0x68
    private void Awake()
    {
        puVar1 = (uint64 *)(*(int64 *)(DAT_181dc6e20 + 184) + 56);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x6001460
    // RVA   : 0xB2CFD0   Offset: 0xB2C3D0   Length: 0x6B
    private void Update()
    {
        long lVar1;
        if (!this.skipping) {
          return;
        }
        if ((this.nextButton != null) &&
           (lVar1 = GameObject.GetComponent(this.nextButton,DAT_181dc7c00)) != null) {
          if (*(char *)(lVar1 + 208) == false) {
            return;
          }
          FightMatchController.StartFightRound(this,0);
          return;
        }
    }

    // Token : 0x6001461
    // RVA   : 0xB2C150   Offset: 0xB2B550   Length: 0x122
    public void SetRound(int num)
    {
        uint uVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        this.fightRound = num;
        if (this.fightMatchPanel != null) {
          lVar2 = GameObject.get_transform(this.fightMatchPanel,0);
          if (lVar2 != null) {
            lVar2 = Transform.Find(lVar2,"Round",0);
            if (lVar2 != null) {
              uVar3 = Component.GetComponent(lVar2,DAT_181d96160);
              uVar1 = this.fightRound;
              uVar4 = GlobalData.GetNumText(uVar1,0);
              uVar4 = String.Format("第{0}轮",uVar4,0);
              LTLocalization.SetText(uVar3,uVar4,0);
              return;
            }
          }
        }
    }

    // Token : 0x6001462
    // RVA   : 0xB2AD70   Offset: 0xB2A170   Length: 0x4A
    public string GetMatchTypeName()
    {
        ulong uVar1;
        uVar1 = "辩才大会";
        if (this.fightMatchType == null) {
          uVar1 = "比武大会";
        }
        return uVar1;
    }

    // Token : 0x6001463
    // RVA   : 0xB2BA30   Offset: 0xB2AE30   Length: 0x69F
    public void RestartFightMatch(FightMatchType _fightMatchType, List<HeroData> heroList, WatchFightType targetType, string _endMatchCallPlot, float _difficulty, bool _isForceMatch, bool _generateReward, List<ItemData> _rewardList, bool _isForceGroupMatch)
    {
        var pStatics = *(int64*)(DAT_181d72ee8 + 184);
        void FightMatchController.RestartFightMatch
                     (int64 this,uint32 _fightMatchType,uint64 heroList,uint32 targetType,
                     uint64 _endMatchCallPlot,uint32 _difficulty,uint8 _isForceMatch,char _generateReward,
                     int64 _rewardList,uint8 _isForceGroupMatch)
        {
        uint32 uVar1;
        uint8 uVar2;
        uint8 uVar3;
        uint32 uVar4;
        char cVar5;
        uint32 uVar6;
        uint64 uVar7;
        int64 lVar8;
        uint64 uVar9;
        int64 *plVar10;
        uint64 uVar11;
        int64 *plVar12;
        int local_res10 [2];
        this.fightMatchType = _fightMatchType;
        this.watchFightType = targetType;
        local_res10[0] = 0;
        uVar7 = il2cpp_internal(DAT_181d93350);
        FUN_18132faf0(uVar7,DAT_181d8b418);
        this.HeroFinalList = uVar7;
        this.matchDifficulty = _difficulty;
        this.endMatchCallPlot = _endMatchCallPlot;
        this.isForceMatch = _isForceMatch;
        this.isForceGroupMatch = _isForceGroupMatch;
        if (((this.fightMatchPanel == null) ||
            (lVar8 = GameObject.get_transform(this.fightMatchPanel,0)) == null) ||
           (lVar8 = Transform.Find(lVar8,"Title",0)) == null) throw; // [null/range check failed]
        uVar9 = Component.GetComponent(lVar8,DAT_181d96160);
        uVar7 = "掌门大会";
        if (!this.isForceGroupMatch) {
          if (!this.isForceMatch) {
            lVar8 = *(int64 *)(*(int64 *)(DAT_181d73d40 + 184) + 0x408);
            uVar6 = Mathf.RoundToInt(this.matchDifficulty * 0.5,0);
            if (lVar8 == null) throw; // [null/range check failed]
            if (*(uint32 *)(lVar8 + 24) <= uVar6) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            uVar7 = lVar8[uVar6];
          }
          else {
            lVar8 = FUN_18046c0a0(0);
            if ((((lVar8 == null) || (*(int64 *)(lVar8 + 32) == 0)) ||
                (lVar8 = WorldData.Player(*(int64 *)(lVar8 + 32),0)) == null) ||
               (lVar8 = HeroData.GetForce(lVar8,0,0)) == null) throw; // [null/range check failed]
            cVar5 = FUN_180d755b0(*(uint64 *)(lVar8 + 0x198),0);
            if (!cVar5) {
              uVar7 = *(uint64 *)(lVar8 + 0x198);
            }
            else {
              uVar7 = *(uint64 *)(lVar8 + 24);
            }
          }
          uVar11 = "辩才大会";
          if (this.fightMatchType == null) {
            uVar11 = "比武大会";
          }
          uVar7 = String.Concat(uVar7,uVar11,0);
        }
        LTLocalization.SetText(uVar9,uVar7,0);
        if (!_generateReward) {
          if ((((this.fightMatchPanel != null) &&
               (lVar8 = GameObject.get_transform(this.fightMatchPanel,0)) != null) &&
              (lVar8 = Transform.Find(lVar8,"RewardItem",0)) != null) &&
             (lVar8 = Component.get_gameObject(lVar8,0)) != null) {
            GameObject.SetActive(lVar8,0,0);
        LAB_180b2c03a:
            FightMatchController.SetRound(this,1);
            uVar7 = FightMatchController.StartFightMatch(this,heroList,0);
            FUN_180d8c2e0(this,uVar7,0);
            plVar10 = (int64 *)Resources.Load("Sound/SoundEffect/紧密鼓点",0);
            plVar12 = (int64 *)0;
            if ((plVar10 != (int64 *)0) && (*plVar10 == DAT_181daf348)) {
              plVar12 = plVar10;
            }
            NGUITools.PlaySound(plVar12,0);
            return;
          }
        }
        else if (this.rewardList != null) {
          FUN_1812f9a10(this.rewardList,DAT_181d90b18);
          if (((this.fightMatchPanel != null) &&
              (lVar8 = GameObject.get_transform(this.fightMatchPanel,0)) != null) &&
             (lVar8 = Transform.Find(lVar8,"RewardItem",0)) != null) {
            lVar8 = Component.get_gameObject(lVar8,0);
            if (lVar8 != null) {
              GameObject.SetActive(lVar8,1,0);
              if ((_rewardList == null) || (*(int *)(_rewardList + 24) == 0)) {
                uVar4 = this.fightMatchType;
                uVar2 = this.isForceMatch;
                uVar3 = this.isForceGroupMatch;
                uVar1 = this.matchDifficulty;
                _rewardList = FightMatchController.GenerateFightMatchRewardItemList
                                    (uVar4,uVar1,uVar2,uVar3,0);
              }
              this.rewardList = _rewardList;
              do {
                if ((this.fightMatchPanel == null) ||
                   (lVar8 = GameObject.get_transform(this.fightMatchPanel,0)) == null)
                throw; // [null/range check failed]
                lVar8 = Transform.Find(lVar8,"RewardItem",0);
                uVar7 = Int32.ToString(local_res10,0);
                if (lVar8 == null) throw; // [null/range check failed]
                uVar7 = Transform.Find(lVar8,uVar7,0);
                if (*pStatics == 0) throw; // [null/range check failed]
                uVar9 = *(uint64 *)(*pStatics + 160);
                uVar7 = NGUITools.AddChild(uVar7,uVar9,0);
                this.tempObj = uVar7;
                if (this.tempObj == null) throw; // [null/range check failed]
                lVar8 = GameObject.GetComponent(this.tempObj,DAT_181d720a0);
                if ((this.rewardList == null) ||
                   (uVar7 = FUN_180002f80(this.rewardList,local_res10[0]), lVar8 == null))
                throw; // [null/range check failed]
                *(uint64 *)(lVar8 + 32) = uVar7;
                if ((this.tempObj == null) ||
                   (lVar8 = GameObject.GetComponent()) == null) throw; // [null/range check failed]
                *(uint32 *)(lVar8 + 40) = 1;
                local_res10[0] = local_res10[0] + 1;
              } while (local_res10[0] < 3);
              goto LAB_180b2c03a;
            }
          }
        }
    }

    // Token : 0x6001464
    // RVA   : 0xB2A890   Offset: 0xB29C90   Length: 0x4D9
    public static List<ItemData> GenerateFightMatchRewardItemList(FightMatchType matchType, float difficulty, bool _isForceMatch, bool _isForceGroupMatch)
    {
        int64 FightMatchController.GenerateFightMatchRewardItemList
                         (int matchType,float difficulty,char _isForceMatch,char _isForceGroupMatch)
        {
        uint32 uVar1;
        uint32 uVar2;
        int64 lVar3;
        int64 lVar4;
        int64 *plVar5;
        uint64 uVar6;
        int iVar7;
        int iVar8;
        float fVar9;
        float fVar10;
        lVar3 = il2cpp_internal(DAT_181d940d0);
        FUN_18132faf0(lVar3,DAT_181d90998);
        lVar4 = *(int64 *)(*(int64 *)(DAT_181d73d40 + 184) + 0x4d0);
        if (lVar4 == null) goto LAB_180b2ad64;
        uVar1 = GlobalData.RandomRange(0,*(uint32 *)(lVar4 + 24),0,0);
        if (matchType == null) {
          lVar4 = il2cpp_internal(DAT_181d941d0);
          FUN_18132faf0(lVar4,DAT_181d91218);
          if (!_isForceGroupMatch) {
            if (lVar4 == null) goto LAB_180b2ad64;
            FUN_18182a0b0(lVar4,0,DAT_181d91298);
            FUN_18182a0b0(lVar4,3,DAT_181d91298);
            uVar6 = 6;
          }
          else {
            if (lVar4 == null) {
        LAB_180b2ad64:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            uVar6 = 3;
          }
        }
        else {
          if (matchType != 1) goto LAB_180b2ab57;
          lVar4 = il2cpp_internal(DAT_181d941d0);
          FUN_18132faf0(lVar4,DAT_181d91218);
          if (lVar4 == null) goto LAB_180b2ad64;
          FUN_18182a0b0(lVar4,1,DAT_181d91298);
          FUN_18182a0b0(lVar4,2,DAT_181d91298);
          uVar6 = 4;
        }
        FUN_18182a0b0(lVar4,uVar6,DAT_181d91298);
        uVar1 = *(uint32 *)(lVar4 + 24);
        uVar2 = GlobalData.RandomRange(0,uVar1,0,0);
        if (*(uint32 *)(lVar4 + 24) <= uVar2) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        uVar1 = lVar4[uVar2];
        LAB_180b2ab57:
        iVar8 = 0;
        iVar7 = iVar8;
        do {
          lVar4 = FUN_18046c0a0(0);
          if (!_isForceGroupMatch) {
            if (!_isForceMatch) {
              fVar9 = 1.0;
              goto LAB_180b2abe2;
            }
            fVar9 = 2.0;
            fVar10 = 1.5;
          }
          else {
            fVar9 = 4.0;
            if (!_isForceMatch) {
        LAB_180b2abe2:
              fVar10 = 1.0;
            }
            else {
              fVar10 = 1.5;
            }
          }
          if (lVar4 == null) goto LAB_180b2ad64;
          uVar6 = GameController.GenerateRandomItem
                            (lVar4,uVar1,(fVar9 + difficulty) - (float)iVar7,fVar10 - (float)iVar8 * 0.5,1,
                             0xffffffff,0,0,0);
          if (lVar3 == null) goto LAB_180b2ad64;
          FUN_18181e0a0(lVar3,uVar6,DAT_181d90a98);
          iVar8 = iVar8 + 1;
          iVar7 = iVar7 + 2;
          if (5 < iVar7) {
            lVar4 = FightMatchController.AreaFightMatchMoneyReward;
            if (lVar4 == null) {
              uVar6 = **(uint64 **)(DAT_181d76fd8 + 184);
              var lVar4 = new OnTooltipCB(uVar6,DAT_181da3608,DAT_181dab4b8);
              FightMatchController.AreaFightMatchMoneyReward = lVar4;
            }
            List_1.Sort(lVar3,lVar4,DAT_181d90e18);
            return lVar3;
          }
        } while( true );
    }

    // Token : 0x6001465
    // RVA   : 0xB2C4A0   Offset: 0xB2B8A0   Length: 0x88
    public IEnumerator StartFightMatch(List<HeroData> heroList)
    {
        long lVar1;
        lVar1 = new WarpText_d__8(0,0);
        if (lVar1 != null) {
          *(uint64 *)(lVar1 + 32) = this;
          *(uint64 *)(lVar1 + 40) = heroList;
          return lVar1;
        }
    }

    // Token : 0x6001466
    // RVA   : 0xB2B520   Offset: 0xB2A920   Length: 0x503
    public void RegenerateFightMatchCouples()
    {
        long lVar1;
        ulong uVar2;
        ulong uVar3;
        long lVar4;
        long lVar5;
        long lVar6;
        int[] local_res8 = new int[2];
        lVar1 = this.fightMatchCoupleList;
        local_res8[0] = 0;
        while (lVar1 != null) {
          if (lVar1.Count <= local_res8[0]) {
            return;
          }
          if (((this.fightMatchPanel == null) ||
              (lVar1 = GameObject.get_transform(this.fightMatchPanel,0)) == null) ||
             (lVar1 = Transform.Find(lVar1,"FightCoupleGrid",0)) == null) break;
          uVar2 = Component.get_gameObject(lVar1,0);
          uVar3 = this.fightMatchCouplePrefab;
          lVar1 = GlobalData.AddChild(uVar2,uVar3,0);
          uVar3 = Int32.ToString(local_res8,0);
          if (lVar1 == null) break;
          Object.set_name(lVar1,uVar3,0);
          if (((this.fightMatchCoupleList == null) ||
              (lVar4 = FUN_180002f80(this.fightMatchCoupleList,local_res8[0],DAT_181d87ea0),
              lVar4 == null)) || (*(int64 *)(lVar4 + 24) == 0)) break;
          if (0 < *(int *)(*(int64 *)(lVar4 + 24) + 24)) {
            lVar4 = GameObject.get_transform(lVar1,0);
            if (lVar4 == null) break;
            uVar3 = Transform.Find(lVar4,"LeftHeroPos",0);
            lVar4 = FUN_18046c1a0(0);
            if (lVar4 == null) break;
            uVar2 = *(uint64 *)(lVar4 + 144);
            lVar4 = NGUITools.AddChild(uVar3,uVar2,0);
            if (lVar4 == null) break;
            lVar5 = GameObject.GetComponent(lVar4,DAT_181d71b50);
            if (((this.fightMatchCoupleList == null) ||
                (lVar6 = FUN_180002f80(this.fightMatchCoupleList,local_res8[0],DAT_181d87ea0),
                lVar6 == null)) || (lVar6 = *(int64 *)(lVar6 + 24)) == null) break;
            if (*(int *)(lVar6 + 24) == 0) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            if (lVar5 == null) break;
            *(uint64 *)(lVar5 + 32) = *(uint64 *)(*(int64 *)(lVar6 + 16) + 32);
            lVar4 = GameObject.GetComponent(lVar4,DAT_181d71b50);
            if (lVar4 == null) break;
            *(uint32 *)(lVar4 + 24) = 2;
          }
          if (((this.fightMatchCoupleList == null) ||
              (lVar4 = FUN_180002f80(this.fightMatchCoupleList,local_res8[0],DAT_181d87ea0),
              lVar4 == null)) || (*(int64 *)(lVar4 + 32) == 0)) break;
          if (0 < *(int *)(*(int64 *)(lVar4 + 32) + 24)) {
            lVar4 = GameObject.get_transform(lVar1,0);
            if (lVar4 == null) break;
            uVar3 = Transform.Find(lVar4,"RightHeroPos",0);
            lVar4 = FUN_18046c1a0(0);
            if (lVar4 == null) break;
            uVar2 = *(uint64 *)(lVar4 + 144);
            lVar4 = NGUITools.AddChild(uVar3,uVar2,0);
            if (lVar4 == null) break;
            lVar5 = GameObject.GetComponent(lVar4,DAT_181d71b50);
            if (((this.fightMatchCoupleList == null) ||
                (lVar6 = FUN_180002f80(this.fightMatchCoupleList,local_res8[0],DAT_181d87ea0),
                lVar6 == null)) || (lVar6 = *(int64 *)(lVar6 + 32)) == null) break;
            if (*(int *)(lVar6 + 24) == 0) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            if (lVar5 == null) break;
            *(uint64 *)(lVar5 + 32) = *(uint64 *)(*(int64 *)(lVar6 + 16) + 32);
            lVar4 = GameObject.GetComponent(lVar4,DAT_181d71b50);
            if (lVar4 == null) break;
            *(uint32 *)(lVar4 + 24) = 2;
          }
          lVar4 = GameObject.get_transform(lVar1,0);
          if ((lVar4 == null) || (lVar4 = Transform.Find(lVar4,"MiddleIcon",0)) == null) break;
          lVar4 = Component.GetComponent(lVar4,DAT_181d94460);
          if ((this.middleIconSprite == null) ||
             (uVar3 = FUN_180002f80(this.middleIconSprite,this.fightMatchType,
                                    DAT_181da39d8), lVar4 == null)) break;
          Image.set_sprite(lVar4,uVar3,0);
          lVar1 = GameObject.get_transform(lVar1,0);
          if (((lVar1 == null) || (lVar1 = Transform.Find(lVar1,"MiddleIcon",0)) == null) ||
             (plVar7 = (int64 *)Component.GetComponent(lVar1,DAT_181d94460), plVar7 == (int64 *)0
             )) break;
          (**(code **)(*plVar7 + 0x408))(plVar7);
          local_res8[0] = local_res8[0] + 1;
          lVar1 = this.fightMatchCoupleList;
        }
    }

    // Token : 0x6001467
    // RVA   : 0xB2CD30   Offset: 0xB2C130   Length: 0x29D
    public void SureWatchFight()
    {
        long lVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        ulong uVar5;
        long lVar6;
        if (this.fightMatchPanel != null) {
          GameObject.SetActive(this.fightMatchPanel,0,0);
          if (this.fightMatchType == null) {
            lVar1 = *(int64 *)(*(int64 *)(DAT_181db0248 + 184) + 80);
            lVar6 = this.nowFightMatchCouple;
            if (lVar6 != null) {
              uVar3 = lVar6.heroList0;
              uVar4 = lVar6.heroList1;
              uVar5 = new BattleMapTypeData(3);
              if (lVar1 != null) {
                BattleController.PrepareBattleMap(lVar1,0,uVar3,uVar4,"FightMatchCoupleResult",0,0,uVar5,0);
                return;
              }
            }
          }
          else {
            lVar1 = *(int64 *)(*(int64 *)(DAT_181dbfc40 + 184) + 32);
            if ((this.nowFightMatchCouple != null) &&
               (lVar6 = this.nowFightMatchCouple.heroList0) != null) {
              if (lVar6.heroList0 == null) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar6 = *(int64 *)(lVar6.id + 32);
              if (lVar6 != null) {
                lVar2 = this.nowFightMatchCouple;
                if (*(int *)(lVar6 + 88) == 0) {
                  if (lVar2 == null) throw; // [null/range check failed]
                  lVar6 = lVar2.heroList1;
                }
                else {
                  if (lVar2 == null) throw; // [null/range check failed]
                  lVar6 = lVar2.heroList0;
                }
                if (lVar6 != null) {
                  if (lVar6.heroList0 == null) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  if (lVar1 != null) {
                    DebateUIController.ShowDebateUI
                              (lVar1,*(uint64 *)(lVar6.id + 32),"DebateMatchCoupleResult",0);
                    return;
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6001468
    // RVA   : 0xB2A290   Offset: 0xB29690   Length: 0x18E
    public void CancelWatchFight()
    {
        long lVar1;
        ulong uVar2;
        uint uVar3;
        uint uVar4;
        lVar1 = this.nowFightMatchCouple;
        if (this.fightMatchType != null) {
          if ((lVar1 = lVar1?.heroList0) != null) {
            if (lVar1.heroList0 == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar1 = *(int64 *)(lVar1.id + 32);
            if (lVar1 != null) {
              uVar3 = HeroData.GetDebateScore(lVar1,0);
              if ((this.nowFightMatchCouple != null) &&
                 (lVar1 = this.nowFightMatchCouple.heroList1) != null) {
                if (lVar1.heroList0 == null) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar1 = *(int64 *)(lVar1.id + 32);
                if (lVar1 != null) {
                  uVar4 = HeroData.GetDebateScore(lVar1,0);
                  uVar3 = GlobalData.CaculateWinTeam(uVar3,uVar4,0);
                  uVar2 = FightMatchController.EndFightRound(this,uVar3,0);
                  FUN_180d8c2e0(this,uVar2,0);
                  return;
                }
              }
            }
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        uVar3 = GlobalData.ManageHeroAutoFight(lVar1,0,0x3f800000,0x3f800000,0);
        uVar2 = FightMatchController.EndFightRound(this,uVar3,0);
        FUN_180d8c2e0(this,uVar2,0);
    }

    // Token : 0x6001469
    // RVA   : 0xB2C0D0   Offset: 0xB2B4D0   Length: 0x76
    public bool RoundFinished()
    {
        uint uVar1;
        long lVar2;
        long lVar3;
        lVar2 = this.fightMatchCoupleList;
        if (lVar2 != null) {
          uVar1 = lVar2.Count;
          if (uVar1 <= uVar1 - 1) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar3 = *(int64 *)(lVar2._items + 24 + (int64)(int)uVar1 * 8);
          if (lVar3 != null) {
            return CONCAT71((int7)((uint64)lVar2._items >> 8),
                            *(int *)(lVar3 + 40) != -1);
          }
        }
    }

    // Token : 0x600146A
    // RVA   : 0xB2C530   Offset: 0xB2B930   Length: 0x7FA
    public void StartFightRound()
    {
        bool cVar2;
        long lVar3;
        ulong uVar4;
        ulong uVar5;
        ulong uVar6;
        long lVar7;
        long lVar8;
        ulong uVar9;
        ulong uVar10;
        long lVar11;
        uint uVar12;
        if ((this.nextButton != null) &&
           (lVar3 = GameObject.GetComponent(this.nextButton,DAT_181dc7c00)) != null) {
          Selectable.set_interactable(lVar3,0,0);
          lVar3 = this.fightMatchCoupleList;
          if (lVar3 != null) {
            uVar12 = lVar3.Count;
            if (uVar12 <= uVar12 - 1) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar3 = *(int64 *)(lVar3._items + 24 + (int64)(int)uVar12 * 8);
            if (lVar3 != null) {
              lVar7 = this.fightMatchCoupleList;
              if (*(int *)(lVar3 + 40) == -1) {
                uVar4 = 0;
                if (lVar7 != null) {
                  lVar3 = 32;
                  uVar10 = uVar4;
                  do {
                    uVar12 = (uint32)uVar10;
                    if (lVar7.Count <= (int)uVar12) {
                      return;
                    }
                    if (lVar7 == null) break;
                    if (lVar7.Count <= uVar12) {
                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                    }
                    lVar11 = *(int64 *)(lVar3 + lVar7._items);
                    if (lVar11 == null) break;
                    lVar7 = this.fightMatchCoupleList;
                    if (lVar11.winTeam == -1) {
                      if (lVar7 == null) break;
                      lVar3 = FUN_180002f80(lVar7,uVar10,DAT_181d87ea0);
                      this.nowFightMatchCouple = lVar3;
                      lVar3 = this.fightMatchCoupleList;
                      if (lVar3 == null) break;
                      if ((int)uVar12 < lVar3.Count + -1) {
                        uVar4 = FUN_180002f80(lVar3,uVar12 + 1,DAT_181d87ea0);
                      }
                      this.nextFightMatchCouple = uVar4;
                      if ((*plVar1 == 0) || (lVar3 = *(int64 *)(*plVar1 + 32)) == null) break;
                      if (lVar3.Count == null) {
                        lVar3 = FightMatchController.EndFightRound(this,0,0);
        LAB_180b2caf5:
                        FUN_180d8c2e0(this,lVar3,0);
                        return;
                      }
                      cVar2 = FightMatchController.FightCoupleHavePlayer();
                      if (!cVar2) {
                        if (((this.skipping) || (this.watchFightType == null)) ||
                           (this.fightMatchType == 1)) {
                          FightMatchController.CancelWatchFight(this,0);
                          return;
                        }
                        if (this.watchFightType != 1) {
                          return;
                        }
                        lVar3 = FUN_180778ae0(0);
                        if ((*plVar1 != 0) && (lVar7 = *(int64 *)(*plVar1 + 24)) != null) {
                          if (lVar7.Count == null) {
                            ThrowHelper.ThrowArgumentOutOfRangeException(0);
                          }
                          lVar7 = *(int64 *)(lVar7._items + 32);
                          if (lVar7 != null) {
                            uVar5 = HeroData.HeroName(lVar7,0,0);
                            if ((*plVar1 != 0) && (lVar7 = *(int64 *)(*plVar1 + 32)) != null) {
                              if (lVar7.Count == null) {
                                ThrowHelper.ThrowArgumentOutOfRangeException(0);
                              }
                              lVar7 = *(int64 *)(lVar7._items + 32);
                              if (lVar7 != null) {
                                uVar6 = HeroData.HeroName(lVar7,0,0);
                                uVar5 = String.Format("本场为{0}对战{1}\n是否观战？",uVar5,uVar6,0);
                                if (lVar3 != null) {
                                  SureMenu.CallSureMenu
                                            (lVar3,uVar5,"SureWatchFight","","FightMatchController",1,0,
                                             "CancelWatchFight","",0);
                                  return;
                                }
                              }
                            }
                          }
                        }
                        break;
                      }
                      lVar3 = FUN_18046c400(0);
                      uVar5 = "没想到这轮的对手是#PlayerName#啊，\n我可不会口下留情，进言吧！";
                      if ((this.fightMatchType != 1) &&
                         (uVar5 = "没想到这轮的对手是#PlayerName#啊，\n我可不会手下留情，进招吧！", this.isForceGroupMatch)) {
                        uVar5 = "没想到这轮的对手是#PlayerForceName#啊。\n久闻贵派高手如云，今天我#TargetForceName#正好来讨教讨教！";
                      }
                      lVar7 = il2cpp_internal(DAT_181d97750);
                      FUN_18132faf0(lVar7,DAT_181da3bd8);
                      if (lVar7 == null) break;
                      FUN_18181e0a0(lVar7,"请指教;PlayerFightMatch",DAT_181da3d58);
                      if (*plVar1 == 0) break;
                      lVar11 = *(int64 *)(*plVar1 + 24);
                      lVar8 = FUN_18046c0a0(0);
                      if (((lVar8 == null) || (*(int64 *)(lVar8 + 32) == 0)) ||
                         (uVar6 = WorldData.Player(*(int64 *)(lVar8 + 32),0), lVar11 == null)) break;
                      cVar2 = FUN_18181e400(lVar11,uVar6,DAT_181d8b698);
                      lVar11 = *plVar1;
                      if (!cVar2) {
                        if (lVar11 == null) break;
                        lVar11 = lVar11.heroList0;
                      }
                      else {
                        if (lVar11 == null) break;
                        lVar11 = lVar11.heroList1;
                      }
                      if (lVar11 != null) {
                        if (lVar11.heroList0 == null) {
                          ThrowHelper.ThrowArgumentOutOfRangeException(0);
                        }
                        lVar11 = *(int64 *)(lVar11.id + 32);
                        if (lVar11 != null) {
                          uVar6 = Int32.ToString(lVar11 + 88,0);
                          uVar9 = new SinglePlotData(uVar5,lVar7,3,uVar6,0);
                          if (lVar3 != null) {
                            PlotController.ChangePlot(lVar3,uVar9,0);
                            return;
                          }
                        }
                      }
                      break;
                    }
                    uVar10 = (uint64)(uVar12 + 1);
                    lVar3 = lVar3 + 8;
                  } while (lVar7 != null);
                }
              }
              else if (lVar7 != null) {
                if (lVar7.Count == 1) {
                  lVar3 = this.HeroFinalList;
                  lVar7 = *(int64 *)(lVar7._items + 32);
                  if (lVar7 != null) {
                    lVar11 = this.nowFightMatchCouple;
                    if (*(int *)(lVar7 + 40) == 0) {
                      if (lVar11 == null) throw; // [null/range check failed]
                      lVar7 = lVar11.heroList0;
                    }
                    else {
                      if (lVar11 == null) throw; // [null/range check failed]
                      lVar7 = lVar11.heroList1;
                    }
                    if (lVar7 != null) {
                      if (lVar7.Count == null) {
                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                      }
                      if (lVar3 != null) {
                        FUN_181822520(lVar3,0,*(uint64 *)(lVar7._items + 32),
                                      DAT_181d8b818);
                        FightMatchController.EndFightMatch(this,0);
                        return;
                      }
                    }
                  }
                }
                else {
                  lVar7 = il2cpp_internal(DAT_181d93350);
                  FUN_18132faf0(lVar7,DAT_181d8b418);
                  lVar3 = this.fightMatchCoupleList;
                  uVar12 = 0;
                  if (lVar3 != null) {
                    lVar11 = 32;
                    while ((int)uVar12 < lVar3.Count) {
                      if (lVar3 == null) throw; // [null/range check failed]
                      if (lVar3.Count <= uVar12) {
                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                      }
                      lVar3 = *(int64 *)(lVar11 + lVar3._items);
                      if (lVar3 == null) throw; // [null/range check failed]
                      lVar8 = this.fightMatchCoupleList;
                      if (*(int *)(lVar3 + 40) == 0) {
                        if ((lVar8 == null) ||
                           (lVar3 = FUN_180002f80(lVar8,uVar12,DAT_181d87ea0)) == null)
                        throw; // [null/range check failed]
                        lVar3 = lVar3.Count;
                      }
                      else {
                        if ((lVar8 == null) ||
                           (lVar3 = FUN_180002f80(lVar8,uVar12,DAT_181d87ea0)) == null)
                        throw; // [null/range check failed]
                        lVar3 = *(int64 *)(lVar3 + 32);
                      }
                      if (lVar3 == null) throw; // [null/range check failed]
                      if (lVar3.Count == null) {
                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                      }
                      if (lVar7 == null) throw; // [null/range check failed]
                      FUN_18181e0a0(lVar7,*(uint64 *)(lVar3._items + 32));
                      lVar3 = this.fightMatchCoupleList;
                      uVar12 = uVar12 + 1;
                      lVar11 = lVar11 + 8;
                      if (lVar3 == null) throw; // [null/range check failed]
                    }
                    FightMatchController.SetRound(this,this.fightRound + 1,0);
                    lVar3 = new WarpText_d__8(0,0);
                    if (lVar3 != null) {
                      *(int64 *)(lVar3 + 32) = this;
                      *(int64 *)(lVar3 + 40) = lVar7;
                      goto LAB_180b2caf5;
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x600146B
    // RVA   : 0xB2A6D0   Offset: 0xB29AD0   Length: 0x1B7
    public bool FightCoupleHavePlayer(FightMatchCouple targetCouple)
    {
        long lVar1;
        long lVar2;
        bool cVar3;
        ulong uVar4;
        if (targetCouple != null) {
          lVar1 = *(int64 *)(targetCouple + 24);
          if ((GameController._instance != null) &&
             (lVar2 = GameController._instance.worldData) != null) {
            uVar4 = WorldData.Player(lVar2,0);
            if (lVar1 != null) {
              cVar3 = FUN_18181e400(lVar1,uVar4,DAT_181d8b698);
              if (cVar3) {
                return true;
              }
              lVar1 = *(int64 *)(targetCouple + 32);
              if ((GameController._instance != null) &&
                 (lVar2 = GameController._instance.worldData) != null) {
                uVar4 = WorldData.Player(lVar2,0);
                if (lVar1 != null) {
                  uVar4 = FUN_18181e400(lVar1,uVar4,DAT_181d8b698);
                  return uVar4;
                }
              }
            }
          }
        }
    }

    // Token : 0x600146C
    // RVA   : 0xB2A420   Offset: 0xB29820   Length: 0x22D
    public void EndFightMatch()
    {
        long lVar2;
        ulong uVar3;
        int[] local_res8 = new int[2];
        plVar1 = (int64 *)Resources.Load("Sound/SoundEffect/终场锣",0);
        plVar4 = (int64 *)0;
        if ((plVar1 != (int64 *)0) && (*plVar1 == DAT_181daf348)) {
          plVar4 = plVar1;
        }
        NGUITools.PlaySound(plVar4,0);
        FightMatchController.SetSkippingState(this,0,0);
        if (this.fightMatchPanel != null) {
          GameObject.SetActive(this.fightMatchPanel,0,0);
          local_res8[0] = 0;
          do {
            if (this.fightMatchPanel == null) throw; // [null/range check failed]
            lVar2 = GameObject.get_transform(this.fightMatchPanel,0);
            if (lVar2 == null) throw; // [null/range check failed]
            lVar2 = Transform.Find(lVar2,"RewardItem",0);
            uVar3 = Int32.ToString(local_res8,0);
            if (lVar2 == null) throw; // [null/range check failed]
            lVar2 = Transform.Find(lVar2,uVar3,0);
            if (lVar2 == null) throw; // [null/range check failed]
            uVar3 = Component.get_gameObject(lVar2);
            GlobalData.DeleteAllChild(uVar3);
            local_res8[0] = local_res8[0] + 1;
          } while (local_res8[0] < 3);
          lVar2 = *(int64 *)(*(int64 *)(DAT_181d91b88 + 184) + 24);
          if (lVar2 != null) {
            lVar2 = Component.get_gameObject(lVar2,0);
            if (lVar2 != null) {
              GameObject.SendMessage(lVar2,this.endMatchCallPlot,0);
              return;
            }
          }
        }
    }

    // Token : 0x600146D
    // RVA   : 0xB2A650   Offset: 0xB29A50   Length: 0x7B
    public IEnumerator EndFightRound(int winTeam)
    {
        long lVar1;
        lVar1 = new WarpText_d__8(0,0);
        if (lVar1 != null) {
          *(uint64 *)(lVar1 + 32) = this;
          *(uint32 *)(lVar1 + 40) = winTeam;
          return lVar1;
        }
    }

    // Token : 0x600146E
    // RVA   : 0xB2AEB0   Offset: 0xB2A2B0   Length: 0x661
    public void RefreshNextButton(int nextID)
    {
        long lVar1;
        bool cVar2;
        ulong uVar3;
        long lVar4;
        long lVar5;
        ulong uVar6;
        lVar5 = this.fightMatchCoupleList;
        if (lVar5 == null) throw; // [null/range check failed]
        if (nextID == lVar5.Count) {
          if (((this.nextButton == null) ||
              (lVar5 = GameObject.get_transform(this.nextButton,0)) == null) ||
             (lVar5 = Transform.Find(lVar5,"Icon",0)) == null) throw; // [null/range check failed]
          lVar4 = Component.GetComponent(lVar5,DAT_181d94460);
          lVar5 = this.nextIconSprite;
          if (lVar5 == null) throw; // [null/range check failed]
          if (lVar5.Count == null) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          if (lVar4 == null) throw; // [null/range check failed]
          Image.set_sprite(lVar4,*(uint64 *)(lVar5._items + 32),0);
          if (((this.nextButton == null) ||
              (lVar5 = GameObject.get_transform(this.nextButton,0)) == null) ||
             (lVar5 = Transform.Find(lVar5,"Label",0)) == null) throw; // [null/range check failed]
          uVar3 = Component.GetComponent(lVar5,DAT_181d96160);
          if (this.fightMatchCoupleList == null) throw; // [null/range check failed]
          uVar6 = "下一轮";
          if (this.fightMatchCoupleList.Count == 1) {
            uVar6 = "结束";
          }
          LTLocalization.SetText(uVar3,uVar6,0);
          if (this.fightMatchCoupleList == null) throw; // [null/range check failed]
          if (this.fightMatchCoupleList.Count != 1) {
            if (!this.skipping) {
              return;
            }
            FightMatchController.StartFightRound(this,0);
            return;
          }
        }
        else {
          if (lVar5.Count <= nextID) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar4 = (int64)(int)nextID * 8 + 32;
          lVar5 = *(int64 *)(lVar4 + lVar5._items);
          if (lVar5 == null) throw; // [null/range check failed]
          lVar5 = lVar5.Count;
          if (((GameController._instance == null) ||
              (lVar1 = GameController._instance.worldData) == null) ||
             (uVar3 = WorldData.Player(lVar1,0), lVar5 == null)) throw; // [null/range check failed]
          cVar2 = FUN_18181e400(lVar5,uVar3,DAT_181d8b698);
          if (!cVar2) {
            lVar5 = this.fightMatchCoupleList;
            if (lVar5 == null) throw; // [null/range check failed]
            if (lVar5.Count <= nextID) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar5 = *(int64 *)(lVar4 + lVar5._items);
            if (lVar5 == null) throw; // [null/range check failed]
            lVar5 = *(int64 *)(lVar5 + 32);
            lVar4 = FUN_18046c0a0(0);
            if (((lVar4 == null) || (*(int64 *)(lVar4 + 32) == 0)) ||
               (uVar3 = WorldData.Player(*(int64 *)(lVar4 + 32),0), lVar5 == null)) throw; // [null/range check failed]
            cVar2 = FUN_18181e400(lVar5,uVar3,DAT_181d8b698);
            if (!cVar2) {
              if (((this.nextButton != null) &&
                  (lVar5 = GameObject.get_transform(this.nextButton,0)) != null) &&
                 (lVar5 = Transform.Find(lVar5,"Icon",0)) != null) {
                lVar4 = Component.GetComponent(lVar5,DAT_181d94460);
                lVar5 = this.nextIconSprite;
                if (lVar5 != null) {
                  if (lVar5.Count == null) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  if (lVar4 != null) {
                    Image.set_sprite(lVar4,*(uint64 *)(lVar5._items + 32),0);
                    if (((this.nextButton != null) &&
                        (lVar5 = GameObject.get_transform(this.nextButton,0)) != null)
                       && (lVar5 = Transform.Find(lVar5,"Label",0)) != null) {
                      uVar3 = Component.GetComponent(lVar5,DAT_181d96160);
                      LTLocalization.SetText(uVar3,"下一场",0);
                      if ((this.skipButton != null) &&
                         (lVar5 = GameObject.GetComponent(this.skipButton,DAT_181dc7c00),
                         lVar5 != null)) {
                        Selectable.set_interactable(lVar5,1,0);
                        return;
                      }
                    }
                  }
                }
              }
              throw; // [null/range check failed]
            }
          }
          if (((this.nextButton == null) ||
              (lVar5 = GameObject.get_transform(this.nextButton,0)) == null) ||
             (lVar5 = Transform.Find(lVar5,"Icon",0)) == null) throw; // [null/range check failed]
          lVar4 = Component.GetComponent(lVar5,DAT_181d94460);
          lVar5 = this.nextIconSprite;
          if (lVar5 == null) throw; // [null/range check failed]
          if (lVar5.Count < 2) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          if (lVar4 == null) throw; // [null/range check failed]
          Image.set_sprite(lVar4,*(uint64 *)(lVar5._items + 40),0);
          if (((this.nextButton == null) ||
              (lVar5 = GameObject.get_transform(this.nextButton,0)) == null) ||
             (lVar5 = Transform.Find(lVar5,"Label",0)) == null) throw; // [null/range check failed]
          uVar3 = Component.GetComponent(lVar5,DAT_181d96160);
          LTLocalization.SetText(uVar3,"战斗",0);
        }
        if ((this.skipButton != null) &&
           (lVar5 = GameObject.GetComponent(this.skipButton,DAT_181dc7c00)) != null) {
          Selectable.set_interactable(lVar5,0,0);
          FightMatchController.SetSkippingState(this,0,0);
          return;
        }
    }

    // Token : 0x600146F
    // RVA   : 0xB2ADC0   Offset: 0xB2A1C0   Length: 0xE1
    public void NextButtonClicked()
    {
        if (!this.skipping) {
          FightMatchController.StartFightRound(this,0);
          return;
        }
        if (GameController._instance != null) {
          GameController.ShowTextOnMouse(GameController._instance,"快进中",0);
          return;
        }
    }

    // Token : 0x6001470
    // RVA   : 0xB2C480   Offset: 0xB2B880   Length: 0x12
    public void SkipButtonClicked()
    {
        void FUN_180b2c480(int64 this)
        {
        FightMatchController.SetSkippingState(this,!this.skipping,0);
    }

    // Token : 0x6001471
    // RVA   : 0xB2C280   Offset: 0xB2B680   Length: 0x7A
    public void SetSkippingButtonState(bool state)
    {
        long lVar1;
        if (this.skipButton != null) {
          lVar1 = GameObject.GetComponent(this.skipButton,DAT_181dc7c00);
          if (lVar1 != null) {
            Selectable.set_interactable(lVar1,state,0);
            if (!state) {
              FightMatchController.SetSkippingState(this,0,0);
            }
            return;
          }
        }
    }

    // Token : 0x6001472
    // RVA   : 0xB2C300   Offset: 0xB2B700   Length: 0x17F
    public void SetSkippingState(bool state)
    {
        long lVar1;
        uint local_18;
        uint uStack_14;
        uint uStack_10;
        uint32 uStack_c;
        lVar1 = this.skipButton;
        this.skipping = state;
        if (!state) {
          if (lVar1 != null) {
            lVar1 = GameObject.get_transform(lVar1,0);
            if (lVar1 != null) {
              lVar1 = Transform.Find(lVar1,"Icon",0);
              if (lVar1 != null) {
                plVar2 = (int64 *)Component.GetComponent(lVar1,DAT_181d94460);
                lVar1 = *(int64 *)(DAT_181d73d40 + 184);
                if (plVar2 != (int64 *)0) {
                  local_18 = *(uint32 *)(lVar1 + 0x398);
                  uStack_14 = *(uint32 *)(lVar1 + 0x39c);
                  uStack_10 = *(uint32 *)(lVar1 + 0x3a0);
                  uStack_c = *(uint32 *)(lVar1 + 0x3a4);
                  (**(code **)(*plVar2 + 0x2a8))(plVar2,&local_18,*(uint64 *)(*plVar2 + 0x2b0));
                  return;
                }
              }
            }
          }
        }
        else if (lVar1 != null) {
          lVar1 = GameObject.get_transform(lVar1,0);
          if (lVar1 != null) {
            lVar1 = Transform.Find(lVar1,"Icon",0);
            if (lVar1 != null) {
              plVar2 = (int64 *)Component.GetComponent(lVar1,DAT_181d94460);
              puVar3 = (uint32 *)Color.get_red(&local_18,0);
              if (plVar2 != (int64 *)0) {
                local_18 = *puVar3;
                uStack_14 = puVar3[1];
                uStack_10 = puVar3[2];
                uStack_c = puVar3[3];
                (**(code **)(*plVar2 + 0x2a8))(plVar2,&local_18,*(uint64 *)(*plVar2 + 0x2b0));
                return;
              }
            }
          }
        }
    }

    // Token : 0x6001473
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

    // Token : 0x6001474
    // RVA   : 0xB2D040   Offset: 0xB2C440   Length: 0x46E
    private static void /*cctor*/()
    {
        var pStatics = *(int64*)(DAT_181dc6e20 + 184);
        long lVar1;
        lVar1 = il2cpp_internal(DAT_181d97750);
        FUN_18132faf0(lVar1,DAT_181da3bd8);
        if (lVar1 != null) {
          FUN_18181e0a0(lVar1,"阁下武功超绝，技压群雄，实在是让人敬佩不已！",DAT_181da3d58);
          FUN_18181e0a0(lVar1,"阁下功夫高强，与冠军不逞多让，只可惜棋差一着，令人扼腕。",DAT_181da3d58);
          FUN_18181e0a0(lVar1,"阁下身手不俗，奈何发挥不佳，只能屈居第三，还望不要灰心气馁。",DAT_181da3d58);
          plVar2 = pStatics;
          *plVar2 = lVar1;
          il2cpp_internal(plVar2,lVar1);
          lVar1 = il2cpp_internal(DAT_181d93cd0);
          FUN_18132faf0(lVar1,DAT_181d8f098);
          if (lVar1 != null) {
            FUN_18182a0b0(lVar1,100,DAT_181d8f218);
            FUN_18182a0b0(lVar1,40,DAT_181d8f218);
            FUN_18182a0b0(lVar1,20,DAT_181d8f218);
            PlotController.fightSkillIndexCache = lVar1;
            lVar1 = il2cpp_internal(DAT_181d93cd0);
            FUN_18132faf0(lVar1,DAT_181d8f098);
            if (lVar1 != null) {
              FUN_18182a0b0(lVar1,5,DAT_181d8f218);
              FUN_18182a0b0(lVar1,2,DAT_181d8f218);
              FUN_18182a0b0(lVar1,1,DAT_181d8f218);
              PlotController.livingSkillIndexCache = lVar1;
              lVar1 = il2cpp_internal(DAT_181d97750);
              FUN_18132faf0(lVar1,DAT_181da3bd8);
              if (lVar1 != null) {
                FUN_18181e0a0(lVar1,"一年以来你的武功进步如此迅速，为师真为你感到高兴！",DAT_181da3d58);
                FUN_18181e0a0(lVar1,"只差数招便夺得第一，不必灰心，明年再接再厉。",DAT_181da3d58);
                FUN_18181e0a0(lVar1,"你的功夫小有所成，但仍有进步空间，切勿骄傲自满。",DAT_181da3d58);
                PlotController._instance = lVar1;
                lVar1 = il2cpp_internal(DAT_181d93cd0);
                FUN_18132faf0(lVar1,DAT_181d8f098);
                if (lVar1 != null) {
                  FUN_18182a0b0(lVar1,200,DAT_181d8f218);
                  FUN_18182a0b0(lVar1,80,DAT_181d8f218);
                  FUN_18182a0b0(lVar1,40,DAT_181d8f218);
                  PlotController.LeftFaceHideOffset = lVar1;
                  lVar1 = il2cpp_internal(DAT_181d93cd0);
                  FUN_18132faf0(lVar1,DAT_181d8f098);
                  if (lVar1 != null) {
                    FUN_18182a0b0(lVar1,25,DAT_181d8f218);
                    FUN_18182a0b0(lVar1,10,DAT_181d8f218);
                    FUN_18182a0b0(lVar1,5,DAT_181d8f218);
                    plVar2 = (int64 *)(pStatics + 40);
                    *plVar2 = lVar1;
                    il2cpp_internal(plVar2,lVar1);
                    lVar1 = il2cpp_internal(DAT_181d97750);
                    FUN_18132faf0(lVar1,DAT_181da3bd8);
                    if (lVar1 != null) {
                      FUN_18181e0a0(lVar1,"阁下舌灿莲花，技压群雄，实在是让人敬佩不已！",DAT_181da3d58);
                      FUN_18181e0a0(lVar1,"阁下口若悬河，与冠军不逞多让，只可惜棋差一着，令人扼腕。",DAT_181da3d58);
                      FUN_18181e0a0(lVar1,"阁下口才不俗，奈何发挥不佳，只能屈居第三，还望不要灰心气馁。",DAT_181da3d58);
                      PlotController.CheckHideChoice = lVar1;
                      return;
                    }
                  }
                }
              }
            }
          }
        }
    }

}
