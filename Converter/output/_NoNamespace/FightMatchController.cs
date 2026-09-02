// ============================================================
// Type  : FightMatchController
// Token : 0x2000279
// ============================================================

public class FightMatchController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400136D
    public FightMatchType fightMatchType;

    // Token: 0x400136E
    public GameObject fightMatchPanel;

    // Token: 0x400136F
    public GameObject nextButton;

    // Token: 0x4001370
    public GameObject fightMatchCouplePrefab;

    // Token: 0x4001371
    public float matchDifficulty;

    // Token: 0x4001372
    public List<ItemData> rewardList;

    // Token: 0x4001373
    public List<FightMatchCouple> fightMatchCoupleList;

    // Token: 0x4001374
    public List<HeroData> HeroFinalList;

    // Token: 0x4001375
    public int fightRound;

    // Token: 0x4001376
    public WatchFightType watchFightType;

    // Token: 0x4001377
    public FightMatchCouple nowFightMatchCouple;

    // Token: 0x4001378
    public FightMatchCouple nextFightMatchCouple;

    // Token: 0x4001379
    public string endMatchCallPlot;

    // Token: 0x400137A
    public bool isForceMatch;

    // Token: 0x400137B
    public bool isForceGroupMatch;

    // Token: 0x400137C
    public List<List<int>> forceGroupMatchHeroList;

    // Token: 0x400137D
    public bool skipping;

    // Token: 0x400137E
    public GameObject skipButton;

    // Token: 0x400137F
    public List<Sprite> nextIconSprite;

    // Token: 0x4001380
    public List<Sprite> middleIconSprite;

    // Token: 0x4001381
    private GameObject tempObj;

    // Token: 0x4001382
    public static List<string> AreaFightMatchResultString;

    // Token: 0x4001383
    public static List<int> AreaFightMatchMoneyReward;

    // Token: 0x4001384
    public static List<int> AreaFightMatchFameReward;

    // Token: 0x4001385
    public static List<string> ForceFightMatchResultString;

    // Token: 0x4001386
    public static List<int> ForceFightMatchMoneyReward;

    // Token: 0x4001387
    public static List<int> ForceFightMatchContriReward;

    // Token: 0x4001388
    public static List<string> AreaDebateMatchResultString;

    // Token: 0x4001389
    private static FightMatchController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600141A
    // RVA   : 0xBA4AB0   Offset: 0xBA32B0   Length: 0x58
    public static FightMatchController get_Instance()
    {
        return *(uint64 *)(*(int64 *)(DAT_181da1ba0 + 184) + 56);
    }

    // Token : 0x600141B
    // RVA   : 0xBA1930   Offset: 0xBA0130   Length: 0x68
    private void Awake()
    {
        puVar1 = (uint64 *)(*(int64 *)(DAT_181da1ba0 + 184) + 56);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x600141C
    // RVA   : 0xBA45D0   Offset: 0xBA2DD0   Length: 0x6B
    private void Update()
    {
        long lVar1;
        if (!this.skipping) {
          return;
        }
        if ((this.nextButton != null) &&
           (lVar1 = GameObject.GetComponent(this.nextButton,DAT_181d9ee60)) != null) {
          if (*(char *)(lVar1 + 208) == false) {
            return;
          }
          FightMatchController.StartFightRound(this,0);
          return;
        }
    }

    // Token : 0x600141D
    // RVA   : 0xBA3790   Offset: 0xBA1F90   Length: 0xED
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
              uVar3 = Component.GetComponent(lVar2,DAT_181d6d8c0);
              uVar1 = this.fightRound;
              uVar4 = GlobalData.GetNumText(uVar1,0);
              uVar4 = String.Format("第{0}轮",uVar4,0);
              LTLocalization.SetText(uVar3,uVar4,0);
              return;
            }
          }
        }
    }

    // Token : 0x600141E
    // RVA   : 0xBA2480   Offset: 0xBA0C80   Length: 0x4A
    public string GetMatchTypeName()
    {
        ulong uVar1;
        uVar1 = "辩才大会";
        if (this.fightMatchType == null) {
          uVar1 = "比武大会";
        }
        return uVar1;
    }

    // Token : 0x600141F
    // RVA   : 0xBA30C0   Offset: 0xBA18C0   Length: 0x64F
    public void RestartFightMatch(FightMatchType _fightMatchType, List<HeroData> heroList, WatchFightType targetType, string _endMatchCallPlot, float _difficulty, bool _isForceMatch, bool _generateReward, List<ItemData> _rewardList, bool _isForceGroupMatch)
    {
        var pStatics = *(int64*)(DAT_181d4e188 + 184);
        void FightMatchController.RestartFightMatch
                     (int64 this,uint32 _fightMatchType,uint64 heroList,uint32 targetType,
                     uint64 _endMatchCallPlot,uint32 _difficulty,uint8 _isForceMatch,char _generateReward,
                     int64 _rewardList,uint8 _isForceGroupMatch)
        {
        uint32 uVar1;
        uint8 uVar2;
        uint8 uVar3;
        uint32 uVar4;
        uint32 uVar5;
        uint64 uVar6;
        int64 lVar7;
        uint64 uVar8;
        int64 *plVar9;
        uint64 uVar10;
        int64 *plVar11;
        int local_res10 [2];
        this.fightMatchType = _fightMatchType;
        this.watchFightType = targetType;
        local_res10[0] = 0;
        uVar6 = il2cpp_internal(DAT_181d6e6b0);
        FUN_180f58a90(uVar6,DAT_181d63c78);
        this.HeroFinalList = uVar6;
        this.matchDifficulty = _difficulty;
        this.endMatchCallPlot = _endMatchCallPlot;
        this.isForceMatch = _isForceMatch;
        this.isForceGroupMatch = _isForceGroupMatch;
        if (((this.fightMatchPanel == null) ||
            (lVar7 = GameObject.get_transform(this.fightMatchPanel,0)) == null) ||
           (lVar7 = Transform.Find(lVar7,"Title",0)) == null) throw; // [null/range check failed]
        uVar8 = Component.GetComponent(lVar7,DAT_181d6d8c0);
        uVar6 = "掌门大会";
        if (!this.isForceGroupMatch) {
          if (!this.isForceMatch) {
            lVar7 = *(int64 *)(*(int64 *)(DAT_181d4ef00 + 184) + 0x400);
            uVar5 = Mathf.RoundToInt(this.matchDifficulty * 0.5,0);
            if (lVar7 == null) throw; // [null/range check failed]
            if (*(uint32 *)(lVar7 + 24) <= uVar5) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            uVar6 = lVar7[uVar5];
          }
          else {
            lVar7 = FUN_18046c0a0(0);
            if ((((lVar7 == null) || (*(int64 *)(lVar7 + 32) == 0)) ||
                (lVar7 = WorldData.Player(*(int64 *)(lVar7 + 32),0)) == null) ||
               (lVar7 = HeroData.GetForce(lVar7,0,0)) == null) throw; // [null/range check failed]
            uVar6 = *(uint64 *)(lVar7 + 24);
          }
          uVar10 = "辩才大会";
          if (this.fightMatchType == null) {
            uVar10 = "比武大会";
          }
          uVar6 = String.Concat(uVar6,uVar10,0);
        }
        LTLocalization.SetText(uVar8,uVar6,0);
        if (!_generateReward) {
          if ((((this.fightMatchPanel != null) &&
               (lVar7 = GameObject.get_transform(this.fightMatchPanel,0)) != null) &&
              (lVar7 = Transform.Find(lVar7,"RewardItem",0)) != null) &&
             (lVar7 = Component.get_gameObject(lVar7,0)) != null) {
            GameObject.SetActive(lVar7,0,0);
        LAB_180ba367a:
            FightMatchController.SetRound(this,1);
            uVar6 = FightMatchController.StartFightMatch(this,heroList,0);
            FUN_180d837c0(this,uVar6,0);
            plVar9 = (int64 *)Resources.Load("Sound/SoundEffect/紧密鼓点",0);
            plVar11 = (int64 *)0;
            if ((plVar9 != (int64 *)0) && (*plVar9 == DAT_181d8a228)) {
              plVar11 = plVar9;
            }
            NGUITools.PlaySound(plVar11,0);
            return;
          }
        }
        else if (this.rewardList != null) {
          FUN_180f56130(this.rewardList,DAT_181d69370);
          if (((this.fightMatchPanel != null) &&
              (lVar7 = GameObject.get_transform(this.fightMatchPanel,0)) != null) &&
             (lVar7 = Transform.Find(lVar7,"RewardItem",0)) != null) {
            lVar7 = Component.get_gameObject(lVar7,0);
            if (lVar7 != null) {
              GameObject.SetActive(lVar7,1,0);
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
                   (lVar7 = GameObject.get_transform(this.fightMatchPanel,0)) == null)
                throw; // [null/range check failed]
                lVar7 = Transform.Find(lVar7,"RewardItem",0);
                uVar6 = Int32.ToString(local_res10,0);
                if (lVar7 == null) throw; // [null/range check failed]
                uVar6 = Transform.Find(lVar7,uVar6,0);
                if (*pStatics == 0) throw; // [null/range check failed]
                uVar8 = *(uint64 *)(*pStatics + 160);
                uVar6 = NGUITools.AddChild(uVar6,uVar8,0);
                this.tempObj = uVar6;
                if (this.tempObj == null) throw; // [null/range check failed]
                lVar7 = GameObject.GetComponent(this.tempObj,DAT_181da0070);
                if ((this.rewardList == null) ||
                   (uVar6 = FUN_180002f80(this.rewardList,local_res10[0]), lVar7 == null))
                throw; // [null/range check failed]
                *(uint64 *)(lVar7 + 32) = uVar6;
                if ((this.tempObj == null) ||
                   (lVar7 = GameObject.GetComponent()) == null) throw; // [null/range check failed]
                *(uint32 *)(lVar7 + 40) = 1;
                local_res10[0] = local_res10[0] + 1;
              } while (local_res10[0] < 3);
              goto LAB_180ba367a;
            }
          }
        }
    }

    // Token : 0x6001420
    // RVA   : 0xBA1FA0   Offset: 0xBA07A0   Length: 0x4D9
    public static List<ItemData> GenerateFightMatchRewardItemList(FightMatchType matchType, float difficulty, bool _isForceMatch, bool _isForceGroupMatch)
    {
        var pStatics = *(int64*)(DAT_181d51d28 + 184);
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
        lVar3 = il2cpp_internal(DAT_181d6f430);
        FUN_180f58a90(lVar3,DAT_181d691f0);
        lVar4 = *(int64 *)(*(int64 *)(DAT_181d4ef00 + 184) + 0x4c8);
        if (lVar4 == null) goto LAB_180ba2474;
        uVar1 = GlobalData.RandomRange(0,*(uint32 *)(lVar4 + 24),0,0);
        if (matchType == null) {
          lVar4 = il2cpp_internal(DAT_181d6f530);
          FUN_180f58a90(lVar4,DAT_181d69a70);
          if (!_isForceGroupMatch) {
            if (lVar4 == null) goto LAB_180ba2474;
            FUN_181814fa0(lVar4,0,DAT_181d69af0);
            FUN_181814fa0(lVar4,3,DAT_181d69af0);
            uVar6 = 6;
          }
          else {
            if (lVar4 == null) {
        LAB_180ba2474:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            uVar6 = 3;
          }
        }
        else {
          if (matchType != 1) goto LAB_180ba2267;
          lVar4 = il2cpp_internal(DAT_181d6f530);
          FUN_180f58a90(lVar4,DAT_181d69a70);
          if (lVar4 == null) goto LAB_180ba2474;
          FUN_181814fa0(lVar4,1,DAT_181d69af0);
          FUN_181814fa0(lVar4,2,DAT_181d69af0);
          uVar6 = 4;
        }
        FUN_181814fa0(lVar4,uVar6,DAT_181d69af0);
        uVar1 = *(uint32 *)(lVar4 + 24);
        uVar2 = GlobalData.RandomRange(0,uVar1,0,0);
        if (*(uint32 *)(lVar4 + 24) <= uVar2) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        uVar1 = lVar4[uVar2];
        LAB_180ba2267:
        iVar8 = 0;
        iVar7 = iVar8;
        do {
          lVar4 = FUN_18046c0a0(0);
          if (!_isForceGroupMatch) {
            if (!_isForceMatch) {
              fVar9 = 1.0;
              goto LAB_180ba22f2;
            }
            fVar9 = 2.0;
            fVar10 = 1.5;
          }
          else {
            fVar9 = 4.0;
            if (!_isForceMatch) {
        LAB_180ba22f2:
              fVar10 = 1.0;
            }
            else {
              fVar10 = 1.5;
            }
          }
          if (lVar4 == null) goto LAB_180ba2474;
          uVar6 = GameController.GenerateRandomItem
                            (lVar4,uVar1,(fVar9 + difficulty) - (float)iVar7,fVar10 - (float)iVar8 * 0.5,1,
                             0xffffffff,0,0,0);
          if (lVar3 == null) goto LAB_180ba2474;
          FUN_181827900(lVar3,uVar6,DAT_181d692f0);
          iVar8 = iVar8 + 1;
          iVar7 = iVar7 + 2;
          if (5 < iVar7) {
            lVar4 = *(int64 *)(pStatics + 8);
            if (lVar4 == null) {
              uVar6 = **(uint64 **)(DAT_181d51d28 + 184);
              var lVar4 = new OnTooltipCB(uVar6,DAT_181d7a788,DAT_181d86118);
              plVar5 = (int64 *)(pStatics + 8);
              *plVar5 = lVar4;
              il2cpp_internal(plVar5,lVar4);
            }
            List_1.Sort(lVar3,lVar4,DAT_181d69670);
            return lVar3;
          }
        } while( true );
    }

    // Token : 0x6001421
    // RVA   : 0xBA3AA0   Offset: 0xBA22A0   Length: 0x88
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

    // Token : 0x6001422
    // RVA   : 0xBA2BB0   Offset: 0xBA13B0   Length: 0x503
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
              (lVar4 = FUN_180002f80(this.fightMatchCoupleList,local_res8[0],DAT_181d606f8),
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
            lVar5 = GameObject.GetComponent(lVar4,DAT_181d9fb20);
            if (((this.fightMatchCoupleList == null) ||
                (lVar6 = FUN_180002f80(this.fightMatchCoupleList,local_res8[0],DAT_181d606f8),
                lVar6 == null)) || (lVar6 = *(int64 *)(lVar6 + 24)) == null) break;
            if (*(int *)(lVar6 + 24) == 0) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            if (lVar5 == null) break;
            *(uint64 *)(lVar5 + 32) = *(uint64 *)(*(int64 *)(lVar6 + 16) + 32);
            lVar4 = GameObject.GetComponent(lVar4,DAT_181d9fb20);
            if (lVar4 == null) break;
            *(uint32 *)(lVar4 + 24) = 2;
          }
          if (((this.fightMatchCoupleList == null) ||
              (lVar4 = FUN_180002f80(this.fightMatchCoupleList,local_res8[0],DAT_181d606f8),
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
            lVar5 = GameObject.GetComponent(lVar4,DAT_181d9fb20);
            if (((this.fightMatchCoupleList == null) ||
                (lVar6 = FUN_180002f80(this.fightMatchCoupleList,local_res8[0],DAT_181d606f8),
                lVar6 == null)) || (lVar6 = *(int64 *)(lVar6 + 32)) == null) break;
            if (*(int *)(lVar6 + 24) == 0) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            if (lVar5 == null) break;
            *(uint64 *)(lVar5 + 32) = *(uint64 *)(*(int64 *)(lVar6 + 16) + 32);
            lVar4 = GameObject.GetComponent(lVar4,DAT_181d9fb20);
            if (lVar4 == null) break;
            *(uint32 *)(lVar4 + 24) = 2;
          }
          lVar4 = GameObject.get_transform(lVar1,0);
          if ((lVar4 == null) || (lVar4 = Transform.Find(lVar4,"MiddleIcon",0)) == null) break;
          lVar4 = Component.GetComponent(lVar4,DAT_181d6bc40);
          if ((this.middleIconSprite == null) ||
             (uVar3 = FUN_180002f80(this.middleIconSprite,this.fightMatchType,
                                    DAT_181d7c050), lVar4 == null)) break;
          Image.set_sprite(lVar4,uVar3,0);
          lVar1 = GameObject.get_transform(lVar1,0);
          if (((lVar1 == null) || (lVar1 = Transform.Find(lVar1,"MiddleIcon",0)) == null) ||
             (plVar7 = (int64 *)Component.GetComponent(lVar1,DAT_181d6bc40), plVar7 == (int64 *)0
             )) break;
          (**(code **)(*plVar7 + 0x408))(plVar7);
          local_res8[0] = local_res8[0] + 1;
          lVar1 = this.fightMatchCoupleList;
        }
    }

    // Token : 0x6001423
    // RVA   : 0xBA4330   Offset: 0xBA2B30   Length: 0x29D
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
            lVar1 = *(int64 *)(*(int64 *)(DAT_181d8b128 + 184) + 80);
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
            lVar1 = *(int64 *)(*(int64 *)(DAT_181d9aa90 + 184) + 32);
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

    // Token : 0x6001424
    // RVA   : 0xBA19A0   Offset: 0xBA01A0   Length: 0x18E
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
                  FUN_180d837c0(this,uVar2,0);
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
        FUN_180d837c0(this,uVar2,0);
    }

    // Token : 0x6001425
    // RVA   : 0xBA3710   Offset: 0xBA1F10   Length: 0x76
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

    // Token : 0x6001426
    // RVA   : 0xBA3B30   Offset: 0xBA2330   Length: 0x7FA
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
           (lVar3 = GameObject.GetComponent(this.nextButton,DAT_181d9ee60)) != null) {
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
                      lVar3 = FUN_180002f80(lVar7,uVar10,DAT_181d606f8);
                      this.nowFightMatchCouple = lVar3;
                      lVar3 = this.fightMatchCoupleList;
                      if (lVar3 == null) break;
                      if ((int)uVar12 < lVar3.Count + -1) {
                        uVar4 = FUN_180002f80(lVar3,uVar12 + 1,DAT_181d606f8);
                      }
                      this.nextFightMatchCouple = uVar4;
                      if ((*plVar1 == 0) || (lVar3 = *(int64 *)(*plVar1 + 32)) == null) break;
                      if (lVar3.Count == null) {
                        lVar3 = FightMatchController.EndFightRound(this,0,0);
        LAB_180ba40f5:
                        FUN_180d837c0(this,lVar3,0);
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
                        lVar3 = FUN_18077c2c0(0);
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
                      lVar3 = FUN_18046c440(0);
                      uVar5 = "没想到这轮的对手是#PlayerName#啊，\n我可不会口下留情，进言吧！";
                      if ((this.fightMatchType != 1) &&
                         (uVar5 = "没想到这轮的对手是#PlayerName#啊，\n我可不会手下留情，进招吧！", this.isForceGroupMatch)) {
                        uVar5 = "没想到这轮的对手是#PlayerForceName#啊。\n久闻贵派高手如云，今天我#TargetForceName#正好来讨教讨教！";
                      }
                      lVar7 = il2cpp_internal(DAT_181d72a30);
                      FUN_180f58a90(lVar7,DAT_181d7c250);
                      if (lVar7 == null) break;
                      FUN_181827900(lVar7,"请指教;PlayerFightMatch",DAT_181d7c3d0);
                      if (*plVar1 == 0) break;
                      lVar11 = *(int64 *)(*plVar1 + 24);
                      lVar8 = FUN_18046c0a0(0);
                      if (((lVar8 == null) || (*(int64 *)(lVar8 + 32) == 0)) ||
                         (uVar6 = WorldData.Player(*(int64 *)(lVar8 + 32),0), lVar11 == null)) break;
                      cVar2 = FUN_1818279a0(lVar11,uVar6,DAT_181d63ef8);
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
                        FUN_18182ac70(lVar3,0,*(uint64 *)(lVar7._items + 32),
                                      DAT_181d64078);
                        FightMatchController.EndFightMatch(this,0);
                        return;
                      }
                    }
                  }
                }
                else {
                  lVar7 = il2cpp_internal(DAT_181d6e6b0);
                  FUN_180f58a90(lVar7,DAT_181d63c78);
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
                           (lVar3 = FUN_180002f80(lVar8,uVar12,DAT_181d606f8)) == null)
                        throw; // [null/range check failed]
                        lVar3 = lVar3.Count;
                      }
                      else {
                        if ((lVar8 == null) ||
                           (lVar3 = FUN_180002f80(lVar8,uVar12,DAT_181d606f8)) == null)
                        throw; // [null/range check failed]
                        lVar3 = *(int64 *)(lVar3 + 32);
                      }
                      if (lVar3 == null) throw; // [null/range check failed]
                      if (lVar3.Count == null) {
                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                      }
                      if (lVar7 == null) throw; // [null/range check failed]
                      FUN_181827900(lVar7,*(uint64 *)(lVar3._items + 32));
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
                      goto LAB_180ba40f5;
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6001427
    // RVA   : 0xBA1DE0   Offset: 0xBA05E0   Length: 0x1B7
    public bool FightCoupleHavePlayer(FightMatchCouple targetCouple)
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        long lVar1;
        long lVar2;
        bool cVar3;
        ulong uVar4;
        if (targetCouple != null) {
          lVar1 = *(int64 *)(targetCouple + 24);
          if ((*pStatics != 0) &&
             (lVar2 = *(int64 *)(*pStatics + 32)) != null) {
            uVar4 = WorldData.Player(lVar2,0);
            if (lVar1 != null) {
              cVar3 = FUN_1818279a0(lVar1,uVar4,DAT_181d63ef8);
              if (cVar3) {
                return true;
              }
              lVar1 = *(int64 *)(targetCouple + 32);
              if ((*pStatics != 0) &&
                 (lVar2 = *(int64 *)(*pStatics + 32)) != null) {
                uVar4 = WorldData.Player(lVar2,0);
                if (lVar1 != null) {
                  uVar4 = FUN_1818279a0(lVar1,uVar4,DAT_181d63ef8);
                  return uVar4;
                }
              }
            }
          }
        }
    }

    // Token : 0x6001428
    // RVA   : 0xBA1B30   Offset: 0xBA0330   Length: 0x22C
    public void EndFightMatch()
    {
        var pStatics = *(int64*)(DAT_181d6c960 + 184);
        long lVar2;
        ulong uVar3;
        int[] local_res8 = new int[2];
        plVar1 = (int64 *)Resources.Load("Sound/SoundEffect/终场锣",0);
        plVar4 = (int64 *)0;
        if ((plVar1 != (int64 *)0) && (*plVar1 == DAT_181d8a228)) {
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
          if (*pStatics != 0) {
            lVar2 = Component.get_gameObject(*pStatics,0);
            if (lVar2 != null) {
              GameObject.SendMessage(lVar2,this.endMatchCallPlot,0);
              return;
            }
          }
        }
    }

    // Token : 0x6001429
    // RVA   : 0xBA1D60   Offset: 0xBA0560   Length: 0x7B
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

    // Token : 0x600142A
    // RVA   : 0xBA25C0   Offset: 0xBA0DC0   Length: 0x5E7
    public void RefreshNextButton(int nextID)
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
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
          lVar4 = Component.GetComponent(lVar5,DAT_181d6bc40);
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
          uVar3 = Component.GetComponent(lVar5,DAT_181d6d8c0);
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
          if (((*pStatics == 0) ||
              (lVar1 = *(int64 *)(*pStatics + 32)) == null) ||
             (uVar3 = WorldData.Player(lVar1,0), lVar5 == null)) throw; // [null/range check failed]
          cVar2 = FUN_1818279a0(lVar5,uVar3,DAT_181d63ef8);
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
            cVar2 = FUN_1818279a0(lVar5,uVar3,DAT_181d63ef8);
            if (!cVar2) {
              if (((this.nextButton != null) &&
                  (lVar5 = GameObject.get_transform(this.nextButton,0)) != null) &&
                 (lVar5 = Transform.Find(lVar5,"Icon",0)) != null) {
                lVar4 = Component.GetComponent(lVar5,DAT_181d6bc40);
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
                      uVar3 = Component.GetComponent(lVar5,DAT_181d6d8c0);
                      LTLocalization.SetText(uVar3,"下一场",0);
                      if ((this.skipButton != null) &&
                         (lVar5 = GameObject.GetComponent(this.skipButton,DAT_181d9ee60),
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
          lVar4 = Component.GetComponent(lVar5,DAT_181d6bc40);
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
          uVar3 = Component.GetComponent(lVar5,DAT_181d6d8c0);
          LTLocalization.SetText(uVar3,"战斗",0);
        }
        if ((this.skipButton != null) &&
           (lVar5 = GameObject.GetComponent(this.skipButton,DAT_181d9ee60)) != null) {
          Selectable.set_interactable(lVar5,0,0);
          FightMatchController.SetSkippingState(this,0,0);
          return;
        }
    }

    // Token : 0x600142B
    // RVA   : 0xBA24D0   Offset: 0xBA0CD0   Length: 0xE1
    public void NextButtonClicked()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        if (!this.skipping) {
          FightMatchController.StartFightRound(this,0);
          return;
        }
        if (*pStatics != 0) {
          GameController.ShowTextOnMouse(*pStatics,"快进中",0);
          return;
        }
    }

    // Token : 0x600142C
    // RVA   : 0xBA3A80   Offset: 0xBA2280   Length: 0x12
    public void SkipButtonClicked()
    {
        void FUN_180ba3a80(int64 this)
        {
        FightMatchController.SetSkippingState(this,!this.skipping,0);
    }

    // Token : 0x600142D
    // RVA   : 0xBA3880   Offset: 0xBA2080   Length: 0x7A
    public void SetSkippingButtonState(bool state)
    {
        long lVar1;
        if (this.skipButton != null) {
          lVar1 = GameObject.GetComponent(this.skipButton,DAT_181d9ee60);
          if (lVar1 != null) {
            Selectable.set_interactable(lVar1,state,0);
            if (!state) {
              FightMatchController.SetSkippingState(this,0,0);
            }
            return;
          }
        }
    }

    // Token : 0x600142E
    // RVA   : 0xBA3900   Offset: 0xBA2100   Length: 0x17F
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
                plVar2 = (int64 *)Component.GetComponent(lVar1,DAT_181d6bc40);
                lVar1 = *(int64 *)(DAT_181d4ef00 + 184);
                if (plVar2 != (int64 *)0) {
                  local_18 = *(uint32 *)(lVar1 + 0x390);
                  uStack_14 = *(uint32 *)(lVar1 + 0x394);
                  uStack_10 = *(uint32 *)(lVar1 + 0x398);
                  uStack_c = *(uint32 *)(lVar1 + 0x39c);
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
              plVar2 = (int64 *)Component.GetComponent(lVar1,DAT_181d6bc40);
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

    // Token : 0x600142F
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

    // Token : 0x6001430
    // RVA   : 0xBA4640   Offset: 0xBA2E40   Length: 0x46E
    private static void /*cctor*/()
    {
        var pStatics = *(int64*)(DAT_181da1ba0 + 184);
        long lVar1;
        lVar1 = il2cpp_internal(DAT_181d72a30);
        FUN_180f58a90(lVar1,DAT_181d7c250);
        if (lVar1 != null) {
          FUN_181827900(lVar1,"阁下武功超绝，技压群雄，实在是让人敬佩不已！",DAT_181d7c3d0);
          FUN_181827900(lVar1,"阁下功夫高强，与冠军不逞多让，只可惜棋差一着，令人扼腕。",DAT_181d7c3d0);
          FUN_181827900(lVar1,"阁下身手不俗，奈何发挥不佳，只能屈居第三，还望不要灰心气馁。",DAT_181d7c3d0);
          plVar2 = pStatics;
          *plVar2 = lVar1;
          il2cpp_internal(plVar2,lVar1);
          lVar1 = il2cpp_internal(DAT_181d6f030);
          FUN_180f58a90(lVar1,DAT_181d678f8);
          if (lVar1 != null) {
            FUN_181814fa0(lVar1,100,DAT_181d67a78);
            FUN_181814fa0(lVar1,40,DAT_181d67a78);
            FUN_181814fa0(lVar1,20,DAT_181d67a78);
            plVar2 = (int64 *)(pStatics + 8);
            *plVar2 = lVar1;
            il2cpp_internal(plVar2,lVar1);
            lVar1 = il2cpp_internal(DAT_181d6f030);
            FUN_180f58a90(lVar1,DAT_181d678f8);
            if (lVar1 != null) {
              FUN_181814fa0(lVar1,5,DAT_181d67a78);
              FUN_181814fa0(lVar1,2,DAT_181d67a78);
              FUN_181814fa0(lVar1,1,DAT_181d67a78);
              plVar2 = (int64 *)(pStatics + 16);
              *plVar2 = lVar1;
              il2cpp_internal(plVar2,lVar1);
              lVar1 = il2cpp_internal(DAT_181d72a30);
              FUN_180f58a90(lVar1,DAT_181d7c250);
              if (lVar1 != null) {
                FUN_181827900(lVar1,"一年以来你的武功进步如此迅速，为师真为你感到高兴！",DAT_181d7c3d0);
                FUN_181827900(lVar1,"只差数招便夺得第一，不必灰心，明年再接再厉。",DAT_181d7c3d0);
                FUN_181827900(lVar1,"你的功夫小有所成，但仍有进步空间，切勿骄傲自满。",DAT_181d7c3d0);
                plVar2 = (int64 *)(pStatics + 24);
                *plVar2 = lVar1;
                il2cpp_internal(plVar2,lVar1);
                lVar1 = il2cpp_internal(DAT_181d6f030);
                FUN_180f58a90(lVar1,DAT_181d678f8);
                if (lVar1 != null) {
                  FUN_181814fa0(lVar1,200,DAT_181d67a78);
                  FUN_181814fa0(lVar1,80,DAT_181d67a78);
                  FUN_181814fa0(lVar1,40,DAT_181d67a78);
                  plVar2 = (int64 *)(pStatics + 32);
                  *plVar2 = lVar1;
                  il2cpp_internal(plVar2,lVar1);
                  lVar1 = il2cpp_internal(DAT_181d6f030);
                  FUN_180f58a90(lVar1,DAT_181d678f8);
                  if (lVar1 != null) {
                    FUN_181814fa0(lVar1,25,DAT_181d67a78);
                    FUN_181814fa0(lVar1,10,DAT_181d67a78);
                    FUN_181814fa0(lVar1,5,DAT_181d67a78);
                    plVar2 = (int64 *)(pStatics + 40);
                    *plVar2 = lVar1;
                    il2cpp_internal(plVar2,lVar1);
                    lVar1 = il2cpp_internal(DAT_181d72a30);
                    FUN_180f58a90(lVar1,DAT_181d7c250);
                    if (lVar1 != null) {
                      FUN_181827900(lVar1,"阁下舌灿莲花，技压群雄，实在是让人敬佩不已！",DAT_181d7c3d0);
                      FUN_181827900(lVar1,"阁下口若悬河，与冠军不逞多让，只可惜棋差一着，令人扼腕。",DAT_181d7c3d0);
                      FUN_181827900(lVar1,"阁下口才不俗，奈何发挥不佳，只能屈居第三，还望不要灰心气馁。",DAT_181d7c3d0);
                      plVar2 = (int64 *)(pStatics + 48);
                      *plVar2 = lVar1;
                      il2cpp_internal(plVar2,lVar1);
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
