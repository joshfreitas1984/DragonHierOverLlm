// ============================================================
// Type  : PrisonController
// Token : 0x2000323
// ============================================================

public class PrisonController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400194E
    public GameObject prisonPanel;

    // Token: 0x400194F
    public static readonly int BadFameEveryDay;

    // Token: 0x4001950
    public static readonly int BuyGuardCdTime;

    // Token: 0x4001951
    public static readonly int BuyGuardCureMinFavor;

    // Token: 0x4001952
    public static readonly int BuyGuardMedMinFavor;

    // Token: 0x4001953
    public static readonly int StealPrisonMinFavor;

    // Token: 0x4001954
    public static readonly int BreakChainMinFavor;

    // Token: 0x4001955
    public static readonly int EscapePrisonMinFavor;

    // Token: 0x4001956
    public bool needRefreshUI;

    // Token: 0x4001957
    private static PrisonController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001F60
    // RVA   : 0xBDD670   Offset: 0xBDBE70   Length: 0x58
    public static PrisonController get_Instance()
    {
        return *(uint64 *)(*(int64 *)(DAT_181d6da60 + 184) + 32);
    }

    // Token : 0x6001F61
    // RVA   : 0xBD9FE0   Offset: 0xBD87E0   Length: 0xE0
    private void Awake()
    {
        var pStatics = *(int64*)(DAT_181d6da60 + 184);
        ulong uVar1;
        bool cVar2;
        uVar1 = *(uint64 *)(pStatics + 32);
        cVar2 = Object.op_Equality(uVar1,0,0);
        if (cVar2) {
          puVar3 = (uint64 *)(pStatics + 32);
          *puVar3 = this;
          il2cpp_internal(puVar3,this);
        }
    }

    // Token : 0x6001F62
    // RVA   : 0xBDD5A0   Offset: 0xBDBDA0   Length: 0xE
    private void Update()
    {
        void FUN_180bdd5a0(int64 this)
        {
        if (this.needRefreshUI) {
          PrisonController.RefreshUI(this,0);
          return;
        }
    }

    // Token : 0x6001F63
    // RVA   : 0xBDACF0   Offset: 0xBD94F0   Length: 0xB8
    public void LoadGameReshowPrison()
    {
        if (this.prisonPanel != null) {
          GameObject.SetActive(this.prisonPanel,1,0);
          PrisonController.RefreshUI(this,0);
          plVar1 = (int64 *)Resources.Load("Sound/SoundEffect/Door/BigDoor3",0);
          plVar2 = (int64 *)0;
          if ((plVar1 != (int64 *)0) && (*plVar1 == DAT_181d8a228)) {
            plVar2 = plVar1;
          }
          NGUITools.PlaySound(plVar2,0x3f800000,0);
          return;
        }
    }

    // Token : 0x6001F64
    // RVA   : 0xBDC3D0   Offset: 0xBDABD0   Length: 0x11CA
    public void StartPrison()
    {
        var pStatics_a578 = *(int64*)(DAT_181d5a578 + 184);
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        var pStatics_ef00 = *(int64*)(DAT_181d4ef00 + 184);
        long lVar1;
        long lVar2;
        ulong uVar4;
        long lVar6;
        ulong uVar7;
        long lVar8;
        ulong uVar9;
        ulong in_stack_ffffffffffffff90;
        uint uVar12;
        ulong uVar11;
        ulong in_stack_ffffffffffffff98;
        uint uVar13;
        ulong uVar14;
        ulong local_48;
        uint local_40;
        ulong local_38;
        ulong uStack_30;
        uVar12 = (uint32)((uint64)in_stack_ffffffffffffff90 >> 32);
        uVar13 = (uint32)((uint64)in_stack_ffffffffffffff98 >> 32);
        if (this.prisonPanel == null) throw; // [null/range check failed]
        GameObject.SetActive(this.prisonPanel,1,0);
        if (*(char *)(pStatics_ef00 + 4) != false) {
          if (this.prisonPanel == null) throw; // [null/range check failed]
          lVar1 = GameObject.get_transform(this.prisonPanel,0);
          if (lVar1 == null) throw; // [null/range check failed]
          lVar1 = Transform.Find(lVar1,"PrisonUI",0);
          if (lVar1 == null) throw; // [null/range check failed]
          lVar1 = Transform.Find(lVar1,"1",0);
          if (lVar1 == null) throw; // [null/range check failed]
          lVar1 = Component.get_gameObject(lVar1,0);
          if (lVar1 == null) throw; // [null/range check failed]
          GameObject.SetActive(lVar1,0,0);
          if (this.prisonPanel == null) throw; // [null/range check failed]
          lVar1 = GameObject.get_transform(this.prisonPanel,0);
          if (lVar1 == null) throw; // [null/range check failed]
          lVar1 = Transform.Find(lVar1,"PrisonUI",0);
          if (lVar1 == null) throw; // [null/range check failed]
          lVar1 = Transform.Find(lVar1,"2",0);
          if (this.prisonPanel == null) throw; // [null/range check failed]
          lVar2 = GameObject.get_transform(this.prisonPanel,0);
          if (lVar2 == null) throw; // [null/range check failed]
          lVar2 = Transform.Find(lVar2,"PrisonUI",0);
          if (lVar2 == null) throw; // [null/range check failed]
          lVar2 = Transform.Find(lVar2,"1",0);
          if (lVar2 == null) throw; // [null/range check failed]
          puVar3 = (uint64 *)Transform.get_localPosition(&local_38,lVar2,0);
          if (lVar1 == null) throw; // [null/range check failed]
          local_48 = *puVar3;
          local_40 = *(uint32 *)(puVar3 + 1);
          Transform.set_localPosition(lVar1,&local_48,0);
          if (this.prisonPanel == null) throw; // [null/range check failed]
          lVar1 = GameObject.get_transform(this.prisonPanel,0);
          if (lVar1 == null) throw; // [null/range check failed]
          lVar1 = Transform.Find(lVar1,"PrisonUI",0);
          if (lVar1 == null) throw; // [null/range check failed]
          lVar1 = Transform.Find(lVar1,"3",0);
          if (lVar1 == null) throw; // [null/range check failed]
          lVar1 = Component.get_gameObject(lVar1,0);
          if (lVar1 == null) throw; // [null/range check failed]
          GameObject.SetActive(lVar1,0,0);
        }
        if ((*pStatics_df90 != 0) &&
           (lVar1 = *(int64 *)(*pStatics_df90 + 32)) != null) {
          lVar1 = WorldData.Player(lVar1,0);
          if (lVar1 != null) {
            HeroData.GoInPrison(lVar1,0);
            if ((*pStatics_df90 != 0) &&
               (lVar1 = *(int64 *)(*pStatics_df90 + 32)) != null) {
              if (*(int64 *)(lVar1 + 0x1b0) == 0) {
                if (*pStatics_df90 == 0) throw; // [null/range check failed]
                lVar1 = *(int64 *)(*pStatics_df90 + 32);
                lVar2 = new ZhSegment(0);
                *(uint64 *)(lVar2 + 16) = 0x42c80000;
                uVar4 = new ItemListData(0);
                *(uint64 *)(lVar2 + 24) = uVar4;
                if (lVar1 == null) throw; // [null/range check failed]
                plVar5 = (int64 *)(lVar1 + 0x1b0);
                *plVar5 = lVar2;
                il2cpp_internal(plVar5,lVar2);
              }
              if (((*pStatics_df90 != 0) &&
                  (lVar1 = *(int64 *)(*pStatics_df90 + 32)) != null) &&
                 (lVar1 = *(int64 *)(lVar1 + 0x1b0)) != null) {
                lVar1 = *(int64 *)(lVar1 + 24);
                if ((*pStatics_df90 != 0) &&
                   (lVar2 = *(int64 *)(*pStatics_df90 + 32)) != null) {
                  lVar2 = WorldData.Player(lVar2,0);
                  if ((lVar2 != null) && (lVar1 != null)) {
                    ItemListData.GetItem(lVar1,*(uint64 *)(lVar2 + 0x220),0);
                    if ((*pStatics_df90 != 0) &&
                       (lVar1 = *(int64 *)(*pStatics_df90 + 32)) != null)
                    {
                      lVar1 = WorldData.Player(lVar1,0);
                      if (lVar1 != null) {
                        HeroData.LoseAllItem(lVar1,0);
                        if (*pStatics_a578 != 0) {
                          puVar3 = &local_38;
                          local_38 = 0;
                          uStack_30 = 0;
                          uVar4 = "Woosh";
                          InfoController.AddInfoTab
                                    (*pStatics_a578,"你的所有物品被收入监狱库房中","UIAtlas",
                                     "从事工作_被囚禁","Woosh",CONCAT44(uVar12,0x3f800000),
                                     CONCAT44(uVar13,0x40a00000),puVar3,0);
                          if ((*pStatics_df90 != 0) &&
                             (lVar1 = *(int64 *)(*pStatics_df90 + 32),
                             lVar1 != null)) {
                            lVar1 = WorldData.Player(lVar1,0);
                            if (lVar1 != null) {
                              uVar4 = CONCAT71((int7)((uint64)uVar4 >> 8),1);
                              HeroData.AddTag(lVar1,0x170,0xbf800000,0,uVar4,1,0);
                              if ((*pStatics_df90 != 0) &&
                                 (lVar1 = *(int64 *)(*pStatics_df90 + 32),
                                 lVar1 != null)) {
                                lVar1 = WorldData.Player(lVar1,0);
                                if (lVar1 != null) {
                                  uVar4 = CONCAT71((int7)((uint64)uVar4 >> 8),1);
                                  HeroData.AddTag(lVar1,0x171,0xbf800000,0,uVar4,1,0);
                                  uVar12 = (uint32)((uint64)uVar4 >> 32);
                                  if (((*pStatics_df90 != 0) &&
                                      (lVar1 = *(int64 *)(*pStatics_df90 + 32)
                                      , lVar1 != null)) && (lVar1 = *(int64 *)(lVar1 + 0x1b0)) != null
                                     ) {
                                    *(uint32 *)(lVar1 + 16) = 0x42c80000;
                                    if (((*pStatics_df90 != 0) &&
                                        (lVar1 = *(int64 *)
                                                  (*pStatics_df90 + 32),
                                        lVar1 != null)) && (lVar1 = *(int64 *)(lVar1 + 0x1b0)) != null
                                       ) {
                                      *(uint32 *)(lVar1 + 20) = 0;
                                      if (((*pStatics_df90 != 0) &&
                                          (lVar1 = *(int64 *)
                                                    (*pStatics_df90 + 32),
                                          lVar1 != null)) &&
                                         (lVar1 = *(int64 *)(lVar1 + 0x1b0)) != null) {
                                        *(uint32 *)(lVar1 + 32) = 0;
                                        PrisonController.RefreshUI(this,0);
                                        plVar5 = (int64 *)Resources.Load("Sound/SoundEffect/Door/BigDoor3",0);
                                        plVar10 = (int64 *)0;
                                        if ((plVar5 != (int64 *)0) && (*plVar5 == DAT_181d8a228)) {
                                          plVar10 = plVar5;
                                        }
                                        NGUITools.PlaySound(plVar10,0x3f800000,0);
                                        lVar1 = new ZhSegment(0);
                                        uVar4 = il2cpp_internal(DAT_181d705b0);
                                        FUN_180f58a90(uVar4,DAT_181d6fb68);
                                        *(uint64 *)(lVar1 + 32) = uVar4;
                                        uVar4 = il2cpp_internal(DAT_181d722b0);
                                        FUN_180f58a90(uVar4,DAT_181d799d8);
                                        *(uint64 *)(lVar1 + 64) = uVar4;
                                        lVar2 = *(int64 *)(lVar1 + 64);
                                        uVar4 = "你就是#$PlayerName#？\n哼哼，你这家伙近来行凶作恶，犯下{0}恶名。\n为了搜捕你，可费了咱们不少功夫。";
                                        if (*(char *)(pStatics_ef00 + 4) != false) {
                                          uVar4 = "你就是#$PlayerName#？\n哼哼，你这家伙近来四处挑战他人，积累了{0}点威慑值。";
                                        }
                                        if ((*pStatics_df90 != 0) &&
                                           (lVar6 = *(int64 *)
                                                     (*pStatics_df90 + 32),
                                           lVar6 != null)) {
                                          lVar6 = WorldData.Player(lVar6,0);
                                          if (lVar6 != null) {
                                            uVar7 = Single.ToString(lVar6 + 0x1c8,"f0",0);
                                            uVar4 = String.Format(uVar4,uVar7,0);
                                            lVar6 = *(int64 *)(*(int64 *)(DAT_181d8ee60 + 184) + 8)
                                            ;
                                            if ((*pStatics_df90 != 0) &&
                                               (lVar8 = *(int64 *)
                                                         (*pStatics_df90 + 32),
                                               lVar8 != null)) {
                                              lVar8 = WorldData.Player(lVar8,0);
                                              if ((lVar8 != null) && (lVar6 != null)) {
                                                uVar13 = 0;
                                                uVar7 = BuildingUIController.GenerateBuildingNPCString
                                                                  (lVar6,"官差",0xfffffffb,
                                                                   0xffffffff,
                                                                   CONCAT44(uVar12,*(uint32 *)
                                                                                    (lVar8 + 184)),0);
                                                uVar9 = il2cpp_internal(DAT_181d7d2b0);
                                                uVar14 = (uint64)puVar3 & 0xffffffff00000000;
                                                uVar11 = CONCAT44(uVar13,3);
                                                SinglePlotData.ctor
                                                          (uVar9,uVar4,0,5,uVar7,uVar11,"0",
                                                           uVar14,0,0);
                                                if (lVar2 != null) {
                                                  FUN_181827900(lVar2,uVar9,DAT_181d79a58);
                                                  lVar2 = *(int64 *)(lVar1 + 64);
                                                  uVar4 = "不过既然进了牢中带上手铐脚镣，任你功夫再高也得低头做人。\n若是敢动逃跑越狱的歪心思，可别怪本官不客气！";
                                                  if (*(char *)(pStatics_ef00 + 4)
                                                      != false) {
                                                    uVar4 = "不过既然进了思过室带上手铐脚镣，任你功夫再高也得低头做人。\n若是敢动逃跑的歪心思，可别怪我不客气！";
                                                  }
                                                  uVar7 = FUN_180004500(DAT_181d63120);
                                                  uVar4 = String.Format(uVar4,uVar7,0);
                                                  uVar7 = il2cpp_internal(DAT_181d7d2b0);
                                                  uVar14 = uVar14 & 0xffffffff00000000;
                                                  uVar11 = uVar11 & 0xffffffff00000000;
                                                  SinglePlotData.ctor
                                                            (uVar7,uVar4,0,0,0,uVar11,0,uVar14,0,0);
                                                  if (lVar2 != null) {
                                                    FUN_181827900(lVar2,uVar7,DAT_181d79a58);
                                                    lVar2 = *(int64 *)(lVar1 + 64);
                                                    uVar4 = "此外，你身上所有物品都会保管在库房中，待出狱之时自会如数奉还。\n望你在此好生反省，争取早日洗心革面，重新做人。";
                                                    if (*(char *)(pStatics_ef00 + 4)
                                                        != false) {
                                                      uVar4 = "此外，你身上所有物品都会保管在库房中，待离开之时自会如数奉还。\n望你在此好生反省，争取早日完成思过。";
                                                    }
                                                    uVar7 = FUN_180004500(DAT_181d63120);
                                                    uVar4 = String.Format(uVar4,uVar7,0);
                                                    lVar6 = il2cpp_internal(DAT_181d72a30);
                                                    FUN_180f58a90(lVar6,DAT_181d7c250);
                                                    if ((*pStatics_df90 != 0) &&
                                                       (lVar8 = *(int64 *)
                                                                 (*pStatics_df90 +
                                                                 32), lVar8 != null)) {
                                                      lVar8 = WorldData.Player(lVar8,0);
                                                      if (lVar8 != null) {
                                                        uVar7 = "HideInteractUI";
                                                        if (999.0 < *(float *)(lVar8 + 0x1c8) ||
                                                            *(float *)(lVar8 + 0x1c8) == 999.0) {
                                                          uVar7 = "PlotStartGameResult;10";
                                                        }
                                                        uVar7 = String.Concat("虎落平阳;",uVar7,0);
                                                        if (lVar6 != null) {
                                                          FUN_181827900(lVar6,uVar7,DAT_181d7c3d0);
                                                          uVar7 = il2cpp_internal(DAT_181d7d2b0);
                                                          SinglePlotData.ctor
                                                                    (uVar7,uVar4,lVar6,0,0,
                                                                     uVar11 & 0xffffffff00000000,0,
                                                                     uVar14 & 0xffffffff00000000,0,0);
                                                          if (lVar2 != null) {
                                                            FUN_181827900(lVar2,uVar7,DAT_181d79a58);
                                                            if (**(int64 **)(DAT_181d6c960 + 184) != 0
                                                               ) {
                                                              PlotController.ChangePlot
                                                                        (**(int64 **)
                                                                           (DAT_181d6c960 + 184),lVar1,0)
                                                              ;
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
                }
              }
            }
          }
        }
    }

    // Token : 0x6001F65
    // RVA   : 0xBDA700   Offset: 0xBD8F00   Length: 0x4CA
    public void EndPrison()
    {
        var pStatics_a578 = *(int64*)(DAT_181d5a578 + 184);
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        long lVar1;
        long lVar2;
        ulong local_28;
        ulong uStack_20;
        if (this.prisonPanel != null) {
          GameObject.SetActive(this.prisonPanel,0,0);
          if ((*pStatics_df90 != 0) &&
             (lVar2 = *(int64 *)(*pStatics_df90 + 32)) != null) {
            lVar2 = WorldData.Player(lVar2,0);
            if (lVar2 != null) {
              lVar2 = *(int64 *)(lVar2 + 0x220);
              if ((((*pStatics_df90 != 0) &&
                   (lVar1 = *(int64 *)(*pStatics_df90 + 32)) != null) &&
                  (lVar1 = *(int64 *)(lVar1 + 0x1b0)) != null) && (lVar2 != null)) {
                ItemListData.GetItem(lVar2,*(uint64 *)(lVar1 + 24),0);
                if (((*pStatics_df90 != 0) &&
                    (lVar2 = *(int64 *)(*pStatics_df90 + 32)) != null) &&
                   ((lVar2 = *(int64 *)(lVar2 + 0x1b0), lVar2 != null &&
                    (lVar2 = *(int64 *)(lVar2 + 24)) != null))) {
                  ItemListData.ClearAllItem(lVar2,0);
                  if (*pStatics_a578 != 0) {
                    local_28 = 0;
                    uStack_20 = 0;
                    InfoController.AddInfoTab
                              (*pStatics_a578,"你取回了监狱库房中的所有物品","UIAtlas",
                               "从事工作_交易","Woosh",0x3f800000,0x40a00000,&local_28,0);
                    if ((*pStatics_df90 != 0) &&
                       (lVar2 = *(int64 *)(*pStatics_df90 + 32)) != null)
                    {
                      lVar2 = WorldData.Player(lVar2,0);
                      if (lVar2 != null) {
                        HeroData.RemoveTag(lVar2,0x170,1,0);
                        if ((*pStatics_df90 != 0) &&
                           (lVar2 = *(int64 *)(*pStatics_df90 + 32),
                           lVar2 != null)) {
                          lVar2 = WorldData.Player(lVar2,0);
                          if (lVar2 != null) {
                            HeroData.RemoveTag(lVar2,0x171,1,0);
                            if ((*pStatics_df90 != 0) &&
                               (lVar2 = *(int64 *)(*pStatics_df90 + 32),
                               lVar2 != null)) {
                              lVar2 = WorldData.Player(lVar2,0);
                              if (lVar2 != null) {
                                HeroData.GoOutPrison(lVar2,0);
                                plVar3 = (int64 *)Resources.Load("Sound/SoundEffect/Door/BigDoor0",0);
                                plVar4 = (int64 *)0;
                                if ((plVar3 != (int64 *)0) && (*plVar3 == DAT_181d8a228)) {
                                  plVar4 = plVar3;
                                }
                                NGUITools.PlaySound(plVar4,0x3f800000,0);
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
            }
          }
        }
    }

    // Token : 0x6001F66
    // RVA   : 0xBDA0C0   Offset: 0xBD88C0   Length: 0x319
    public void ChangeGuardAlert(float num, bool showInfo)
    {
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        var pStatics_ef00 = *(int64*)(DAT_181d4ef00 + 184);
        long lVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        ulong uVar5;
        uint uVar6;
        float[] local_res10 = new float[2];
        ulong local_28;
        ulong uStack_20;
        local_res10[0] = num;
        if ((*pStatics_df90 != 0) &&
           (lVar1 = *(int64 *)(*pStatics_df90 + 32)) != null) {
          lVar1 = *(int64 *)(lVar1 + 0x1b0);
          if (((*pStatics_df90 != 0) &&
              (lVar2 = *(int64 *)(*pStatics_df90 + 32)) != null) &&
             (lVar2 = *(int64 *)(lVar2 + 0x1b0)) != null) {
            uVar6 = FUN_1810a8ba0(*(float *)(lVar2 + 16) + local_res10[0],0,0x42c80000,0);
            if (lVar1 != null) {
              *(uint32 *)(lVar1 + 16) = uVar6;
              this.needRefreshUI = 1;
              if (showInfo) {
                lVar1 = **(int64 **)(DAT_181d5a578 + 184);
                uVar3 = Single.ToString(local_res10,"+0;-0;0",0);
                uVar4 = "{1}守卫警戒{0}</color>";
                if (0.0 <= local_res10[0]) {
                  uVar5 = *(uint64 *)(pStatics_ef00 + 0x2c8);
                }
                else {
                  uVar5 = *(uint64 *)(pStatics_ef00 + 0x260);
                }
                uVar4 = String.Format(uVar4,uVar3,uVar5,0);
                if (lVar1 == null) throw; // [null/range check failed]
                local_28 = 0;
                uStack_20 = 0;
                InfoController.AddInfoTab
                          (lVar1,uVar4,"UIAtlas","守卫警戒","Woosh",0x3f800000,0x40a00000,
                           &local_28,0);
              }
              return;
            }
          }
        }
    }

    // Token : 0x6001F67
    // RVA   : 0xBDA3E0   Offset: 0xBD8BE0   Length: 0x31D
    public void ChangeGuardFavor(float num, bool showInfo)
    {
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        var pStatics_ef00 = *(int64*)(DAT_181d4ef00 + 184);
        long lVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        ulong uVar5;
        uint uVar6;
        float[] local_res10 = new float[2];
        ulong local_28;
        ulong uStack_20;
        local_res10[0] = num;
        if ((*pStatics_df90 != 0) &&
           (lVar1 = *(int64 *)(*pStatics_df90 + 32)) != null) {
          lVar1 = *(int64 *)(lVar1 + 0x1b0);
          if (((*pStatics_df90 != 0) &&
              (lVar2 = *(int64 *)(*pStatics_df90 + 32)) != null) &&
             (lVar2 = *(int64 *)(lVar2 + 0x1b0)) != null) {
            uVar6 = FUN_1810a8ba0(*(float *)(lVar2 + 20) + local_res10[0],0,0x42c80000,0);
            if (lVar1 != null) {
              *(uint32 *)(lVar1 + 20) = uVar6;
              this.needRefreshUI = 1;
              if (showInfo) {
                lVar1 = **(int64 **)(DAT_181d5a578 + 184);
                uVar3 = Single.ToString(local_res10,"+0;-0;0",0);
                uVar4 = "{1}守卫熟络{0}</color>";
                if (local_res10[0] <= 0.0) {
                  uVar5 = *(uint64 *)(pStatics_ef00 + 0x2c8);
                }
                else {
                  uVar5 = *(uint64 *)(pStatics_ef00 + 0x260);
                }
                uVar4 = String.Format(uVar4,uVar3,uVar5,0);
                if (lVar1 == null) throw; // [null/range check failed]
                local_28 = 0;
                uStack_20 = 0;
                InfoController.AddInfoTab
                          (lVar1,uVar4,"UIAtlas","守卫熟络","Woosh",0x3f800000,0x40a00000,
                           &local_28,0);
              }
              return;
            }
          }
        }
    }

    // Token : 0x6001F68
    // RVA   : 0xBDBC10   Offset: 0xBDA410   Length: 0x7B0
    public void RefreshUI()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        int iVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        int[] local_res8 = new int[2];
        int[] local_res18 = new int[2];
        int[] local_res20 = new int[2];
        uint[] local_18 = new uint[4];
        this.needRefreshUI = 0;
        if (this.prisonPanel != null) {
          lVar2 = GameObject.get_transform(this.prisonPanel,0);
          if (lVar2 != null) {
            lVar2 = Transform.Find(lVar2,"PrisonUI",0);
            if (lVar2 != null) {
              lVar2 = Transform.Find(lVar2,"GuardAlert",0);
              if (lVar2 != null) {
                lVar2 = Transform.Find(lVar2,"Text",0);
                if (lVar2 != null) {
                  uVar3 = Component.GetComponent(lVar2,DAT_181d6d8c0);
                  if (((*pStatics != 0) &&
                      (lVar2 = *(int64 *)(*pStatics + 32)) != null)
                     && (lVar2 = *(int64 *)(lVar2 + 0x1b0)) != null) {
                    local_res18[0] = (int)*(float *)(lVar2 + 16);
                    uVar4 = il2cpp_value_box(DAT_181d5b2f8,local_res18);
                    uVar4 = String.Format("{0}%",uVar4,0);
                    LTLocalization.SetText(uVar3,uVar4,0);
                    if (this.prisonPanel != null) {
                      lVar2 = GameObject.get_transform(this.prisonPanel,0);
                      if (lVar2 != null) {
                        lVar2 = Transform.Find(lVar2,"PrisonUI",0);
                        if (lVar2 != null) {
                          lVar2 = Transform.Find(lVar2,"GuardAlert",0);
                          if (lVar2 != null) {
                            lVar2 = Transform.Find(lVar2,"Slider",0);
                            if (lVar2 != null) {
                              plVar5 = (int64 *)Component.GetComponent(lVar2,DAT_181d6d2c0);
                              if (((*pStatics != 0) &&
                                  (lVar2 = *(int64 *)(*pStatics + 32),
                                  lVar2 != null)) &&
                                 ((lVar2 = *(int64 *)(lVar2 + 0x1b0), lVar2 != null &&
                                  (plVar5 != (int64 *)0)))) {
                                (**(code **)(*plVar5 + 0x428))
                                          (plVar5,*(float *)(lVar2 + 16) * 0.01,
                                           *(uint64 *)(*plVar5 + 0x430));
                                if (this.prisonPanel != null) {
                                  lVar2 = GameObject.get_transform(this.prisonPanel,0);
                                  if (lVar2 != null) {
                                    lVar2 = Transform.Find(lVar2,"PrisonUI",0);
                                    if (lVar2 != null) {
                                      lVar2 = Transform.Find(lVar2,"GuardFavor",0);
                                      if (lVar2 != null) {
                                        lVar2 = Transform.Find(lVar2,"Text",0);
                                        if (lVar2 != null) {
                                          uVar3 = Component.GetComponent(lVar2,DAT_181d6d8c0);
                                          if (((*pStatics != 0) &&
                                              (lVar2 = *(int64 *)
                                                        (*pStatics + 32),
                                              lVar2 != null)) &&
                                             (lVar2 = *(int64 *)(lVar2 + 0x1b0)) != null) {
                                            local_res20[0] = (int)*(float *)(lVar2 + 20);
                                            uVar4 = il2cpp_value_box(DAT_181d5b2f8,local_res20);
                                            uVar4 = String.Format("{0}%",uVar4,0);
                                            LTLocalization.SetText(uVar3,uVar4,0);
                                            if (this.prisonPanel != null) {
                                              lVar2 = GameObject.get_transform
                                                                (this.prisonPanel,0);
                                              if (lVar2 != null) {
                                                lVar2 = Transform.Find(lVar2,"PrisonUI",0);
                                                if (lVar2 != null) {
                                                  lVar2 = Transform.Find(lVar2,"GuardFavor",0);
                                                  if (lVar2 != null) {
                                                    lVar2 = Transform.Find(lVar2,"Slider",0);
                                                    if (lVar2 != null) {
                                                      plVar5 = (int64 *)
                                                               Component.GetComponent
                                                                         (lVar2,DAT_181d6d2c0);
                                                      if (((*pStatics != 0) &&
                                                          (lVar2 = *(int64 *)
                                                                    (*pStatics
                                                                    + 32), lVar2 != null)) &&
                                                         ((lVar2 = *(int64 *)(lVar2 + 0x1b0),
                                                          lVar2 != null && (plVar5 != (int64 *)0)))) {
                                                        (**(code **)(*plVar5 + 0x428))
                                                                  (plVar5,*(float *)(lVar2 + 20) * 0.01,
                                                                   *(uint64 *)(*plVar5 + 0x430));
                                                        if (this.prisonPanel != null) {
                                                          lVar2 = GameObject.get_transform
                                                                            (this.prisonPanel
                                                                             ,0);
                                                          if (lVar2 != null) {
                                                            lVar2 = Transform.Find(lVar2,"PrisonUI",0)
                                                            ;
                                                            if (lVar2 != null) {
                                                              lVar2 = Transform.Find(lVar2,"LeftTime",
                                                                                      0);
                                                              if (lVar2 != null) {
                                                                uVar3 = Component.GetComponent
                                                                                  (lVar2,DAT_181d6d8c0);
                                                                local_18[0] = 
                                                        PrisonController.GetLeftPrisonDay(this,0);
                                                        uVar4 = il2cpp_value_box(DAT_181d5b2f8,local_18);
                                                        uVar4 = String.Format("{0}天",uVar4,0);
                                                        LTLocalization.SetText(uVar3,uVar4,0);
                                                        if (this.prisonPanel != null) {
                                                          lVar2 = GameObject.get_transform
                                                                            (this.prisonPanel
                                                                             ,0);
                                                          if (lVar2 != null) {
                                                            lVar2 = Transform.Find(lVar2,"PrisonUI",0)
                                                            ;
                                                            if (lVar2 != null) {
                                                              lVar2 = Transform.Find(lVar2,"0",
                                                                                      0);
                                                              if (lVar2 != null) {
                                                                lVar2 = Transform.Find(lVar2,
                                                        "Text",0);
                                                        if (lVar2 != null) {
                                                          uVar4 = Component.GetComponent
                                                                            (lVar2,DAT_181d6d8c0);
                                                          iVar1 = PrisonController.GetLeftPrisonDay
                                                                            (this,0);
                                                          uVar3 = "出狱";
                                                          if (0 < iVar1) {
                                                            uVar3 = "继续坐牢";
                                                          }
                                                          LTLocalization.SetText(uVar4,uVar3,0);
                                                          local_res8[0] = 1;
                                                          while (this.prisonPanel != null) {
                                                            lVar2 = GameObject.get_transform
                                                                              (*(int64 *)
                                                                                (this + 24),0);
                                                            if (lVar2 == null) break;
                                                            lVar2 = Transform.Find(lVar2,"PrisonUI",0)
                                                            ;
                                                            uVar3 = Int32.ToString(local_res8,0);
                                                            if (lVar2 == null) break;
                                                            lVar2 = Transform.Find(lVar2,uVar3,0);
                                                            if (lVar2 == null) break;
                                                            lVar2 = Component.GetComponent
                                                                              (lVar2,DAT_181d6af40);
                                                            PrisonController.GetLeftPrisonDay(this,0);
                                                            if (lVar2 == null) break;
                                                            Selectable.set_interactable(lVar2);
                                                            local_res8[0] = local_res8[0] + 1;
                                                            if (3 < local_res8[0]) {
                                                              return;
                                                            }
                                                          }
                          // WARNING: Subroutine does not return
                                                          FUN_1800d6620();
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
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6001F69
    // RVA   : 0xBDABD0   Offset: 0xBD93D0   Length: 0x11B
    public int GetLeftPrisonDay()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        float fVar1;
        long lVar2;
        if ((*pStatics != 0) &&
           (lVar2 = *(int64 *)(*pStatics + 32)) != null) {
          lVar2 = WorldData.Player(lVar2,0);
          if (lVar2 != null) {
            fVar1 = *(float *)(lVar2 + 0x1c8);
            Mathf.CeilToInt(fVar1 / (float)**(int **)(DAT_181d6da60 + 184),0);
            return;
          }
        }
    }

    // Token : 0x6001F6A
    // RVA   : 0xBDADB0   Offset: 0xBD95B0   Length: 0xE5A
    public void PrisonButtonClicked(GameObject buttonClicked)
    {
        var pStatics_da60 = *(int64*)(DAT_181d6da60 + 184);
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        var pStatics_ef00 = *(int64*)(DAT_181d4ef00 + 184);
        bool cVar1;
        int iVar2;
        long lVar3;
        long lVar4;
        ulong uVar5;
        ulong uVar6;
        ulong uVar7;
        uint[] local_res10 = new uint[4];
        int[] local_res20 = new int[2];
        int local_48;
        int local_44;
        uint local_40;
        int local_3c;
        uint32 local_38 [4];
        if (buttonClicked == null) goto LAB_180bdbbe7;
        lVar3 = Object.get_name(buttonClicked,0);
        if (lVar3 == null) {
          return;
        }
        cVar1 = FUN_1816fd990(lVar3,"0",0);
        if (!cVar1) {
          cVar1 = FUN_1816fd990(lVar3,"1",0);
          if (cVar1) {
            lVar3 = FUN_18046c0a0(0);
            if (((lVar3 != null) && (*(int64 *)(lVar3 + 32) != 0)) &&
               (lVar3 = WorldData.Player(*(int64 *)(lVar3 + 32),0)) != null) {
              local_res20[0] = HeroData.GetBadFameFineMoney(lVar3,0);
              lVar4 = FUN_18046c440(0);
              local_48 = local_res20[0];
              uVar6 = il2cpp_value_box(DAT_181d5b2f8,&local_48);
              uVar6 = String.Format("江湖声望和恶名越高，就需要缴纳越多罚金。\n眼下我需要一次性缴纳{0}两的罚金，方能将当前的恶名与悬赏一笔勾销。",uVar6,0);
              lVar3 = il2cpp_internal(DAT_181d72a30);
              FUN_180f58a90(lVar3,DAT_181d7c250);
              uVar5 = Int32.ToString(local_res20,0);
              uVar5 = String.Concat("缴纳罚金;ClearBadFame;;0/",uVar5,0);
              if (lVar3 != null) {
                FUN_181827900(lVar3,uVar5,DAT_181d7c3d0);
                FUN_181827900(lVar3,"还是算了;HideInteractUI",DAT_181d7c3d0);
                uVar5 = new SinglePlotData(uVar6,lVar3,1,0,3,"0",1,0,0);
                if (lVar4 != null) goto LAB_180bdb0d6;
              }
            }
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          cVar1 = FUN_1816fd990(lVar3,"2",0);
          if (cVar1) {
            lVar3 = FUN_18046c0a0(0);
            if (((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) ||
               (lVar3 = *(int64 *)(*(int64 *)(lVar3 + 32) + 0x1b0)) == null)
            goto LAB_180bdbbe7;
            if (*(float *)(lVar3 + 32) <= 0.0) {
              lVar3 = FUN_18046c0a0(0);
              if (((lVar3 != null) && (*(int64 *)(lVar3 + 32) != 0)) &&
                 (lVar3 = WorldData.Player(*(int64 *)(lVar3 + 32),0)) != null) {
                iVar2 = Mathf.RoundToInt((*(float *)(lVar3 + 0x1c8) * 0.1 + 1.0) * 100.0,0);
                lVar4 = FUN_18046c440(0);
                uVar6 = "只要花上些小钱贿赂狱卒，便可与其搞好关系。\n待到熟络之后，也能请他们帮忙行些方便。";
                if (*(char *)(pStatics_ef00 + 4) != false) {
                  uVar6 = "只要花上些小钱赔礼道歉，便可展现诚意。\n待到熟络之后，也能请守卫帮忙行些方便。";
                }
                lVar3 = il2cpp_internal(DAT_181d72a30);
                FUN_180f58a90(lVar3,DAT_181d7c250);
                local_48 = iVar2;
                uVar5 = il2cpp_value_box(DAT_181d5b2f8,&local_48);
                uVar5 = String.Format("贿赂狱卒;BuyPrisonGuard;0;0/{0};♦降低少量警觉度\n♦增加少量熟络度",uVar5,0);
                if (lVar3 != null) {
                  FUN_181827900(lVar3,uVar5,DAT_181d7c3d0);
                  local_44 = iVar2 * 2;
                  uVar5 = il2cpp_value_box(DAT_181d5b2f8,&local_44);
                  local_40 = *(uint32 *)(pStatics_da60 + 8);
                  uVar7 = il2cpp_value_box(DAT_181d5b2f8,&local_40);
                  uVar5 = String.Format("治疗伤势;BuyPrisonGuard;1;0/{0};♦治疗全伤势10点;GuardFavor/{1}",uVar5,uVar7,0);
                  FUN_181827900(lVar3,uVar5,DAT_181d7c3d0);
                  local_3c = iVar2 * 5;
                  uVar5 = il2cpp_value_box(DAT_181d5b2f8,&local_3c);
                  local_38[0] = *(uint32 *)(pStatics_da60 + 12);
                  uVar7 = il2cpp_value_box(DAT_181d5b2f8,local_38);
                  uVar5 = String.Format("获取药品;BuyPrisonGuard;2;0/{0};♦获取随机药品;GuardFavor/{1}",uVar5,uVar7,0);
                  FUN_181827900(lVar3,uVar5,DAT_181d7c3d0);
                  FUN_181827900(lVar3,"还是算了;HideInteractUI",DAT_181d7c3d0);
                  uVar5 = new SinglePlotData(uVar6,lVar3,1,0,3,"0",1,0,0);
                  if (lVar4 != null) goto LAB_180bdb0d6;
                }
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              goto LAB_180bdbbe7;
            }
            lVar4 = FUN_18046c440(0);
            uVar6 = "还需等待{0}日方能再次贿赂狱卒。";
            if (*(char *)(pStatics_ef00 + 4) != false) {
              uVar6 = "还需等待{0}日方能再次赔礼道歉";
            }
            if (((*pStatics_df90 == 0) ||
                (lVar3 = *(int64 *)(*pStatics_df90 + 32)) == null) ||
               (lVar3 = *(int64 *)(lVar3 + 0x1b0)) == null) {
        LAB_180bdbbff:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            local_38[0] = *(uint32 *)(lVar3 + 32);
            uVar5 = il2cpp_value_box(DAT_181d7d0b8,local_38);
            uVar6 = String.Format(uVar6,uVar5,0);
            uVar5 = new SinglePlotData(uVar6,0,1,0,3,"0",1,0,0);
            if (lVar4 == null) goto LAB_180bdbbff;
            goto LAB_180bdb0d6;
          }
          cVar1 = FUN_1816fd990(lVar3,"3",0);
          if (!cVar1) {
            return;
          }
          lVar3 = il2cpp_internal(DAT_181d72a30);
          FUN_180f58a90(lVar3,DAT_181d7c250);
          uVar6 = "{0};PrepareBreakPrison;2;;;GuardFavor/{1}";
          uVar5 = "寻找物品";
          if (*(char *)(pStatics_ef00 + 4) == false) {
            uVar5 = "偷取物品";
          }
          local_38[0] = *(uint32 *)(pStatics_da60 + 16);
          uVar7 = il2cpp_value_box(DAT_181d5b2f8,local_38);
          uVar6 = String.Format(uVar6,uVar5,uVar7,0);
          if (lVar3 == null) {
        LAB_180bdbc05:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          FUN_181827900(lVar3,uVar6,DAT_181d7c3d0);
          local_res10[0] = *(uint32 *)(pStatics_da60 + 24);
          uVar6 = Int32.ToString(local_res10,0);
          uVar6 = String.Concat("暗中逃跑;PrepareBreakPrison;3;;;GuardFavor/",uVar6,0);
          FUN_181827900(lVar3,uVar6,DAT_181d7c3d0);
          FUN_181827900(lVar3,"强行越狱;PrepareBreakPrison;4",DAT_181d7c3d0);
          FUN_181827900(lVar3,"还是算了;HideInteractUI",DAT_181d7c3d0);
          lVar4 = FUN_18046c0a0(0);
          if (((lVar4 == null) || (*(int64 *)(lVar4 + 32) == 0)) ||
             (lVar4 = WorldData.Player(*(int64 *)(lVar4 + 32),0)) == null) goto LAB_180bdbc05;
          cVar1 = HeroData.HaveTag(lVar4,0x171,0);
          if (cVar1) {
            local_res10[0] = *(uint32 *)(pStatics_da60 + 20);
            uVar6 = Int32.ToString(local_res10,0);
            uVar6 = String.Concat("解开脚镣;PrepareBreakPrison;1;;;GuardFavor/",uVar6,0);
            FUN_18182ac70(lVar3,1,uVar6,DAT_181d7c6c8);
          }
          lVar4 = FUN_18046c0a0(0);
          if (((lVar4 == null) || (*(int64 *)(lVar4 + 32) == 0)) ||
             (lVar4 = WorldData.Player(*(int64 *)(lVar4 + 32),0)) == null) goto LAB_180bdbbe7;
          cVar1 = HeroData.HaveTag(lVar4,0x170,0);
          if (cVar1) {
            local_res10[0] = *(uint32 *)(pStatics_da60 + 20);
            uVar6 = Int32.ToString(local_res10,0);
            uVar6 = String.Concat("解开手铐;PrepareBreakPrison;0;;;GuardFavor/",uVar6,0);
            FUN_18182ac70(lVar3,1,uVar6,DAT_181d7c6c8);
          }
          lVar4 = FUN_18046c440(0);
          uVar5 = il2cpp_internal(DAT_181d7d2b0);
          uVar6 = "哼，我#$PlayerName#堂堂一代大侠，\n岂能在此处虚度光阴，受尽白眼！\n得想个办法，尽快逃出这鬼地方才行。";
        }
        else {
          iVar2 = PrisonController.GetLeftPrisonDay(this,0);
          if (0 < iVar2) {
            lVar4 = FUN_18046c440(0);
            local_48 = **(int **)(DAT_181d6da60 + 184);
            uVar6 = il2cpp_value_box(DAT_181d5b2f8,&local_48);
            uVar6 = String.Format("每日可降低{0}点恶名，待恶名降低到0时便可出狱。\n同时每日也会累积少量伤势，不过若能与看守更为熟络，便也能少受些罪。",uVar6,0);
            lVar3 = il2cpp_internal(DAT_181d72a30);
            FUN_180f58a90(lVar3,DAT_181d7c250);
            if (lVar3 != null) {
              FUN_181827900(lVar3,"1天;PlayerContinuePrison;1",DAT_181d7c3d0);
              FUN_181827900(lVar3,"5天;PlayerContinuePrison;5",DAT_181d7c3d0);
              FUN_181827900(lVar3,"10天;PlayerContinuePrison;10",DAT_181d7c3d0);
              FUN_181827900(lVar3,"取消;HideInteractUI",DAT_181d7c3d0);
              uVar5 = new SinglePlotData(uVar6,lVar3,1,0,3,"0",1,0,0);
              if (lVar4 != null) goto LAB_180bdb0d6;
            }
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          lVar4 = FUN_18046c440(0);
          lVar3 = il2cpp_internal(DAT_181d72a30);
          FUN_180f58a90(lVar3,DAT_181d7c250);
          if (lVar3 == null) goto LAB_180bdbbe7;
          FUN_181827900(lVar3,"重见天日;PlayerFinishPrison",DAT_181d7c3d0);
          uVar5 = il2cpp_internal(DAT_181d7d2b0);
          uVar6 = "刑期已满，总算可以离开这鬼地方了......";
        }
        SinglePlotData.ctor(uVar5,uVar6,lVar3,1,0,3,"0",1,0,0);
        if (lVar4 == null) {
        LAB_180bdbbe7:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        LAB_180bdb0d6:
        PlotController.ChangePlot(lVar4,uVar5,0);
    }

    // Token : 0x6001F6B
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

    // Token : 0x6001F6C
    // RVA   : 0xBDD5B0   Offset: 0xBDBDB0   Length: 0xB7
    private static void /*cctor*/()
    {
        var pStatics = *(int64*)(DAT_181d6da60 + 184);
        **(uint32 **)(DAT_181d6da60 + 184) = 5;
        *(uint32 *)(pStatics + 4) = 5;
        *(uint32 *)(pStatics + 8) = 20;
        *(uint32 *)(pStatics + 12) = 40;
        *(uint32 *)(pStatics + 16) = 10;
        *(uint32 *)(pStatics + 20) = 30;
        *(uint32 *)(pStatics + 24) = 50;
    }

}
