// ============================================================
// Type  : PrisonController
// Token : 0x200032A
// ============================================================

public class PrisonController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001A45
    public GameObject prisonPanel;

    // Token: 0x4001A46
    public static readonly int BadFameEveryDay;

    // Token: 0x4001A47
    public static readonly int BuyGuardCdTime;

    // Token: 0x4001A48
    public static readonly int BuyGuardCureMinFavor;

    // Token: 0x4001A49
    public static readonly int BuyGuardMedMinFavor;

    // Token: 0x4001A4A
    public static readonly int StealPrisonMinFavor;

    // Token: 0x4001A4B
    public static readonly int BreakChainMinFavor;

    // Token: 0x4001A4C
    public static readonly int EscapePrisonMinFavor;

    // Token: 0x4001A4D
    public bool needRefreshUI;

    // Token: 0x4001A4E
    private static PrisonController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001FE0
    // RVA   : 0xB11B40   Offset: 0xB10F40   Length: 0x58
    public static PrisonController get_Instance()
    {
        return *(uint64 *)(*(int64 *)(DAT_181d92c88 + 184) + 32);
    }

    // Token : 0x6001FE1
    // RVA   : 0xB0E460   Offset: 0xB0D860   Length: 0xE0
    private void Awake()
    {
        var pStatics = *(int64*)(DAT_181d92c88 + 184);
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

    // Token : 0x6001FE2
    // RVA   : 0xB11A70   Offset: 0xB10E70   Length: 0xE
    private void Update()
    {
        void FUN_180b11a70(int64 this)
        {
        if (this.needRefreshUI) {
          PrisonController.RefreshUI(this,0);
          return;
        }
    }

    // Token : 0x6001FE3
    // RVA   : 0xB0F170   Offset: 0xB0E570   Length: 0xB8
    public void LoadGameReshowPrison()
    {
        if (this.prisonPanel != null) {
          GameObject.SetActive(this.prisonPanel,1,0);
          PrisonController.RefreshUI(this,0);
          plVar1 = (int64 *)Resources.Load("Sound/SoundEffect/Door/BigDoor3",0);
          plVar2 = (int64 *)0;
          if ((plVar1 != (int64 *)0) && (*plVar1 == DAT_181daf348)) {
            plVar2 = plVar1;
          }
          NGUITools.PlaySound(plVar2,0x3f800000,0);
          return;
        }
    }

    // Token : 0x6001FE4
    // RVA   : 0xB108A0   Offset: 0xB0FCA0   Length: 0x11CB
    public void StartPrison()
    {
        var pStatics_2cc8 = *(int64*)(DAT_181d72cc8 + 184);
        var pStatics_3d40 = *(int64*)(DAT_181d73d40 + 184);
        var pStatics_f6a8 = *(int64*)(DAT_181d7f6a8 + 184);
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
        if (*(char *)(pStatics_3d40 + 4) != false) {
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
        if ((*pStatics_2cc8 != 0) &&
           (lVar1 = *(int64 *)(*pStatics_2cc8 + 32)) != null) {
          lVar1 = WorldData.Player(lVar1,0);
          if (lVar1 != null) {
            HeroData.GoInPrison(lVar1,0);
            if ((*pStatics_2cc8 != 0) &&
               (lVar1 = *(int64 *)(*pStatics_2cc8 + 32)) != null) {
              if (*(int64 *)(lVar1 + 0x1b0) == 0) {
                if (*pStatics_2cc8 == 0) throw; // [null/range check failed]
                lVar1 = *(int64 *)(*pStatics_2cc8 + 32);
                lVar2 = new ZhSegment(0);
                *(uint64 *)(lVar2 + 16) = 0x42c80000;
                uVar4 = new ItemListData(0);
                *(uint64 *)(lVar2 + 24) = uVar4;
                if (lVar1 == null) throw; // [null/range check failed]
                plVar5 = (int64 *)(lVar1 + 0x1b0);
                *plVar5 = lVar2;
                il2cpp_internal(plVar5,lVar2);
              }
              if (((*pStatics_2cc8 != 0) &&
                  (lVar1 = *(int64 *)(*pStatics_2cc8 + 32)) != null) &&
                 (lVar1 = *(int64 *)(lVar1 + 0x1b0)) != null) {
                lVar1 = *(int64 *)(lVar1 + 24);
                if ((*pStatics_2cc8 != 0) &&
                   (lVar2 = *(int64 *)(*pStatics_2cc8 + 32)) != null) {
                  lVar2 = WorldData.Player(lVar2,0);
                  if ((lVar2 != null) && (lVar1 != null)) {
                    ItemListData.GetItem(lVar1,*(uint64 *)(lVar2 + 0x220),0);
                    if ((*pStatics_2cc8 != 0) &&
                       (lVar1 = *(int64 *)(*pStatics_2cc8 + 32)) != null)
                    {
                      lVar1 = WorldData.Player(lVar1,0);
                      if (lVar1 != null) {
                        HeroData.LoseAllItem(lVar1,0);
                        if (*pStatics_f6a8 != 0) {
                          puVar3 = &local_38;
                          local_38 = 0;
                          uStack_30 = 0;
                          uVar4 = "Woosh";
                          InfoController.AddInfoTab
                                    (*pStatics_f6a8,"你的所有物品被收入监狱库房中","UIAtlas",
                                     "从事工作_被囚禁","Woosh",CONCAT44(uVar12,0x3f800000),
                                     CONCAT44(uVar13,0x40a00000),puVar3,0);
                          if ((*pStatics_2cc8 != 0) &&
                             (lVar1 = *(int64 *)(*pStatics_2cc8 + 32),
                             lVar1 != null)) {
                            lVar1 = WorldData.Player(lVar1,0);
                            if (lVar1 != null) {
                              uVar4 = CONCAT71((int7)((uint64)uVar4 >> 8),1);
                              HeroData.AddTag(lVar1,0x170,0xbf800000,0,uVar4,1,0);
                              if ((*pStatics_2cc8 != 0) &&
                                 (lVar1 = *(int64 *)(*pStatics_2cc8 + 32),
                                 lVar1 != null)) {
                                lVar1 = WorldData.Player(lVar1,0);
                                if (lVar1 != null) {
                                  uVar4 = CONCAT71((int7)((uint64)uVar4 >> 8),1);
                                  HeroData.AddTag(lVar1,0x171,0xbf800000,0,uVar4,1,0);
                                  uVar12 = (uint32)((uint64)uVar4 >> 32);
                                  if (((*pStatics_2cc8 != 0) &&
                                      (lVar1 = *(int64 *)(*pStatics_2cc8 + 32)
                                      , lVar1 != null)) && (lVar1 = *(int64 *)(lVar1 + 0x1b0)) != null
                                     ) {
                                    *(uint32 *)(lVar1 + 16) = 0x42c80000;
                                    if (((*pStatics_2cc8 != 0) &&
                                        (lVar1 = *(int64 *)
                                                  (*pStatics_2cc8 + 32),
                                        lVar1 != null)) && (lVar1 = *(int64 *)(lVar1 + 0x1b0)) != null
                                       ) {
                                      *(uint32 *)(lVar1 + 20) = 0;
                                      if (((*pStatics_2cc8 != 0) &&
                                          (lVar1 = *(int64 *)
                                                    (*pStatics_2cc8 + 32),
                                          lVar1 != null)) &&
                                         (lVar1 = *(int64 *)(lVar1 + 0x1b0)) != null) {
                                        *(uint32 *)(lVar1 + 32) = 0;
                                        PrisonController.RefreshUI(this,0);
                                        plVar5 = (int64 *)Resources.Load("Sound/SoundEffect/Door/BigDoor3",0);
                                        plVar10 = (int64 *)0;
                                        if ((plVar5 != (int64 *)0) && (*plVar5 == DAT_181daf348)) {
                                          plVar10 = plVar5;
                                        }
                                        NGUITools.PlaySound(plVar10,0x3f800000,0);
                                        lVar1 = new ZhSegment(0);
                                        uVar4 = il2cpp_internal(DAT_181d952d0);
                                        FUN_18132faf0(uVar4,DAT_181d97508);
                                        *(uint64 *)(lVar1 + 32) = uVar4;
                                        uVar4 = il2cpp_internal(DAT_181d96fd0);
                                        FUN_18132faf0(uVar4,DAT_181da1370);
                                        *(uint64 *)(lVar1 + 64) = uVar4;
                                        lVar2 = *(int64 *)(lVar1 + 64);
                                        uVar4 = "你就是#$PlayerName#？\n哼哼，你这家伙近来行凶作恶，犯下{0}恶名。\n为了搜捕你，可费了咱们不少功夫。";
                                        if (*(char *)(pStatics_3d40 + 4) != false) {
                                          uVar4 = "你就是#$PlayerName#？\n哼哼，你这家伙近来四处挑战他人，积累了{0}点威慑值。";
                                        }
                                        if ((*pStatics_2cc8 != 0) &&
                                           (lVar6 = *(int64 *)
                                                     (*pStatics_2cc8 + 32),
                                           lVar6 != null)) {
                                          lVar6 = WorldData.Player(lVar6,0);
                                          if (lVar6 != null) {
                                            uVar7 = Single.ToString(lVar6 + 0x1c8,"f0",0);
                                            uVar4 = String.Format(uVar4,uVar7,0);
                                            lVar6 = *(int64 *)(*(int64 *)(DAT_181db4008 + 184) + 8)
                                            ;
                                            if ((*pStatics_2cc8 != 0) &&
                                               (lVar8 = *(int64 *)
                                                         (*pStatics_2cc8 + 32),
                                               lVar8 != null)) {
                                              lVar8 = WorldData.Player(lVar8,0);
                                              if ((lVar8 != null) && (lVar6 != null)) {
                                                uVar13 = 0;
                                                uVar7 = BuildingUIController.GenerateBuildingNPCString
                                                                  (lVar6,"官差",0xfffffffb,
                                                                   0xffffffff,
                                                                   CONCAT44(uVar12,*(uint32 *)
                                                                                    (lVar8 + 184)),0);
                                                uVar9 = il2cpp_internal(DAT_181da24d8);
                                                uVar14 = (uint64)puVar3 & 0xffffffff00000000;
                                                uVar11 = CONCAT44(uVar13,3);
                                                SinglePlotData.ctor
                                                          (uVar9,uVar4,0,5,uVar7,uVar11,"0",
                                                           uVar14,0,0);
                                                if (lVar2 != null) {
                                                  FUN_18181e0a0(lVar2,uVar9,DAT_181da13f0);
                                                  lVar2 = *(int64 *)(lVar1 + 64);
                                                  uVar4 = "不过既然进了牢中带上手铐脚镣，任你功夫再高也得低头做人。\n若是敢动逃跑越狱的歪心思，可别怪本官不客气！";
                                                  if (*(char *)(pStatics_3d40 + 4)
                                                      != false) {
                                                    uVar4 = "不过既然进了思过室带上手铐脚镣，任你功夫再高也得低头做人。\n若是敢动逃跑的歪心思，可别怪我不客气！";
                                                  }
                                                  uVar7 = FUN_180004500(DAT_181d8b140);
                                                  uVar4 = String.Format(uVar4,uVar7,0);
                                                  uVar7 = il2cpp_internal(DAT_181da24d8);
                                                  uVar14 = uVar14 & 0xffffffff00000000;
                                                  uVar11 = uVar11 & 0xffffffff00000000;
                                                  SinglePlotData.ctor
                                                            (uVar7,uVar4,0,0,0,uVar11,0,uVar14,0,0);
                                                  if (lVar2 != null) {
                                                    FUN_18181e0a0(lVar2,uVar7,DAT_181da13f0);
                                                    lVar2 = *(int64 *)(lVar1 + 64);
                                                    uVar4 = "此外，你身上所有物品都会保管在库房中，待出狱之时自会如数奉还。\n望你在此好生反省，争取早日洗心革面，重新做人。";
                                                    if (*(char *)(pStatics_3d40 + 4)
                                                        != false) {
                                                      uVar4 = "此外，你身上所有物品都会保管在库房中，待离开之时自会如数奉还。\n望你在此好生反省，争取早日完成思过。";
                                                    }
                                                    uVar7 = FUN_180004500(DAT_181d8b140);
                                                    uVar4 = String.Format(uVar4,uVar7,0);
                                                    lVar6 = il2cpp_internal(DAT_181d97750);
                                                    FUN_18132faf0(lVar6,DAT_181da3bd8);
                                                    if ((*pStatics_2cc8 != 0) &&
                                                       (lVar8 = *(int64 *)
                                                                 (*pStatics_2cc8 +
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
                                                          FUN_18181e0a0(lVar6,uVar7,DAT_181da3d58);
                                                          uVar7 = il2cpp_internal(DAT_181da24d8);
                                                          SinglePlotData.ctor
                                                                    (uVar7,uVar4,lVar6,0,0,
                                                                     uVar11 & 0xffffffff00000000,0,
                                                                     uVar14 & 0xffffffff00000000,0,0);
                                                          if (lVar2 != null) {
                                                            FUN_18181e0a0(lVar2,uVar7,DAT_181da13f0);
                                                            lVar2 = *(int64 *)
                                                                     (*(int64 *)(DAT_181d91b88 + 184)
                                                                     + 24);
                                                            if (lVar2 != null) {
                                                              PlotController.ChangePlot(lVar2,lVar1,0);
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

    // Token : 0x6001FE5
    // RVA   : 0xB0EB80   Offset: 0xB0DF80   Length: 0x4CA
    public void EndPrison()
    {
        var pStatics_2cc8 = *(int64*)(DAT_181d72cc8 + 184);
        var pStatics_f6a8 = *(int64*)(DAT_181d7f6a8 + 184);
        long lVar1;
        long lVar2;
        ulong local_28;
        ulong uStack_20;
        if (this.prisonPanel != null) {
          GameObject.SetActive(this.prisonPanel,0,0);
          if ((*pStatics_2cc8 != 0) &&
             (lVar2 = *(int64 *)(*pStatics_2cc8 + 32)) != null) {
            lVar2 = WorldData.Player(lVar2,0);
            if (lVar2 != null) {
              lVar2 = *(int64 *)(lVar2 + 0x220);
              if ((((*pStatics_2cc8 != 0) &&
                   (lVar1 = *(int64 *)(*pStatics_2cc8 + 32)) != null) &&
                  (lVar1 = *(int64 *)(lVar1 + 0x1b0)) != null) && (lVar2 != null)) {
                ItemListData.GetItem(lVar2,*(uint64 *)(lVar1 + 24),0);
                if (((*pStatics_2cc8 != 0) &&
                    (lVar2 = *(int64 *)(*pStatics_2cc8 + 32)) != null) &&
                   ((lVar2 = *(int64 *)(lVar2 + 0x1b0), lVar2 != null &&
                    (lVar2 = *(int64 *)(lVar2 + 24)) != null))) {
                  ItemListData.ClearAllItem(lVar2,0);
                  if (*pStatics_f6a8 != 0) {
                    local_28 = 0;
                    uStack_20 = 0;
                    InfoController.AddInfoTab
                              (*pStatics_f6a8,"你取回了监狱库房中的所有物品","UIAtlas",
                               "从事工作_交易","Woosh",0x3f800000,0x40a00000,&local_28,0);
                    if ((*pStatics_2cc8 != 0) &&
                       (lVar2 = *(int64 *)(*pStatics_2cc8 + 32)) != null)
                    {
                      lVar2 = WorldData.Player(lVar2,0);
                      if (lVar2 != null) {
                        HeroData.RemoveTag(lVar2,0x170,1,0);
                        if ((*pStatics_2cc8 != 0) &&
                           (lVar2 = *(int64 *)(*pStatics_2cc8 + 32),
                           lVar2 != null)) {
                          lVar2 = WorldData.Player(lVar2,0);
                          if (lVar2 != null) {
                            HeroData.RemoveTag(lVar2,0x171,1,0);
                            if ((*pStatics_2cc8 != 0) &&
                               (lVar2 = *(int64 *)(*pStatics_2cc8 + 32),
                               lVar2 != null)) {
                              lVar2 = WorldData.Player(lVar2,0);
                              if (lVar2 != null) {
                                HeroData.GoOutPrison(lVar2,0);
                                plVar3 = (int64 *)Resources.Load("Sound/SoundEffect/Door/BigDoor0",0);
                                plVar4 = (int64 *)0;
                                if ((plVar3 != (int64 *)0) && (*plVar3 == DAT_181daf348)) {
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

    // Token : 0x6001FE6
    // RVA   : 0xB0E540   Offset: 0xB0D940   Length: 0x319
    public void ChangeGuardAlert(float num, bool showInfo)
    {
        var pStatics_2cc8 = *(int64*)(DAT_181d72cc8 + 184);
        var pStatics_3d40 = *(int64*)(DAT_181d73d40 + 184);
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
        if ((*pStatics_2cc8 != 0) &&
           (lVar1 = *(int64 *)(*pStatics_2cc8 + 32)) != null) {
          lVar1 = *(int64 *)(lVar1 + 0x1b0);
          if (((*pStatics_2cc8 != 0) &&
              (lVar2 = *(int64 *)(*pStatics_2cc8 + 32)) != null) &&
             (lVar2 = *(int64 *)(lVar2 + 0x1b0)) != null) {
            uVar6 = FUN_1810e36c0(*(float *)(lVar2 + 16) + local_res10[0],0,0x42c80000,0);
            if (lVar1 != null) {
              *(uint32 *)(lVar1 + 16) = uVar6;
              this.needRefreshUI = 1;
              if (showInfo) {
                lVar1 = **(int64 **)(DAT_181d7f6a8 + 184);
                uVar3 = Single.ToString(local_res10,"+0;-0;0",0);
                uVar4 = "{1}守卫警戒{0}</color>";
                if (0.0 <= local_res10[0]) {
                  uVar5 = *(uint64 *)(pStatics_3d40 + 0x2d0);
                }
                else {
                  uVar5 = *(uint64 *)(pStatics_3d40 + 0x268);
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

    // Token : 0x6001FE7
    // RVA   : 0xB0E860   Offset: 0xB0DC60   Length: 0x31D
    public void ChangeGuardFavor(float num, bool showInfo)
    {
        var pStatics_2cc8 = *(int64*)(DAT_181d72cc8 + 184);
        var pStatics_3d40 = *(int64*)(DAT_181d73d40 + 184);
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
        if ((*pStatics_2cc8 != 0) &&
           (lVar1 = *(int64 *)(*pStatics_2cc8 + 32)) != null) {
          lVar1 = *(int64 *)(lVar1 + 0x1b0);
          if (((*pStatics_2cc8 != 0) &&
              (lVar2 = *(int64 *)(*pStatics_2cc8 + 32)) != null) &&
             (lVar2 = *(int64 *)(lVar2 + 0x1b0)) != null) {
            uVar6 = FUN_1810e36c0(*(float *)(lVar2 + 20) + local_res10[0],0,0x42c80000,0);
            if (lVar1 != null) {
              *(uint32 *)(lVar1 + 20) = uVar6;
              this.needRefreshUI = 1;
              if (showInfo) {
                lVar1 = **(int64 **)(DAT_181d7f6a8 + 184);
                uVar3 = Single.ToString(local_res10,"+0;-0;0",0);
                uVar4 = "{1}守卫熟络{0}</color>";
                if (local_res10[0] <= 0.0) {
                  uVar5 = *(uint64 *)(pStatics_3d40 + 0x2d0);
                }
                else {
                  uVar5 = *(uint64 *)(pStatics_3d40 + 0x268);
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

    // Token : 0x6001FE8
    // RVA   : 0xB10090   Offset: 0xB0F490   Length: 0x805
    public void RefreshUI()
    {
        var pStatics = *(int64*)(DAT_181d72cc8 + 184);
        int iVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        int[] local_res8 = new int[4];
        int[] local_res18 = new int[2];
        int[] local_res20 = new int[2];
        uint[] local_28 = new uint[4];
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
                  uVar3 = Component.GetComponent(lVar2,DAT_181d96160);
                  if (((*pStatics != 0) &&
                      (lVar2 = *(int64 *)(*pStatics + 32)) != null)
                     && (lVar2 = *(int64 *)(lVar2 + 0x1b0)) != null) {
                    local_res18[0] = (int)*(float *)(lVar2 + 16);
                    uVar4 = il2cpp_value_box(DAT_181d80418,local_res18);
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
                              plVar5 = (int64 *)Component.GetComponent(lVar2,DAT_181d95b60);
                              if ((((*pStatics != 0) &&
                                   (lVar2 = *(int64 *)(*pStatics + 32),
                                   lVar2 != null)) && (lVar2 = *(int64 *)(lVar2 + 0x1b0)) != null) &&
                                 (plVar5 != (int64 *)0)) {
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
                                          uVar3 = Component.GetComponent(lVar2,DAT_181d96160);
                                          if (((*pStatics != 0) &&
                                              (lVar2 = *(int64 *)
                                                        (*pStatics + 32),
                                              lVar2 != null)) &&
                                             (lVar2 = *(int64 *)(lVar2 + 0x1b0)) != null) {
                                            local_res20[0] = (int)*(float *)(lVar2 + 20);
                                            uVar4 = il2cpp_value_box(DAT_181d80418,local_res20);
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
                                                                         (lVar2,DAT_181d95b60);
                                                      if ((((*pStatics != 0)
                                                           && (lVar2 = *(int64 *)
                                                                        (**(int64 **)
                                                                           (DAT_181d72cc8 + 184) + 32),
                                                              lVar2 != null)) &&
                                                          (lVar2 = *(int64 *)(lVar2 + 0x1b0),
                                                          lVar2 != null)) && (plVar5 != (int64 *)0)) {
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
                                                                                  (lVar2,DAT_181d96160);
                                                                local_28[0] = 
                                                        PrisonController.GetLeftPrisonDay(this,0);
                                                        uVar4 = il2cpp_value_box(DAT_181d80418,local_28);
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
                                                                            (lVar2,DAT_181d96160);
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
                                                                              (lVar2,DAT_181d93760);
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

    // Token : 0x6001FE9
    // RVA   : 0xB0F050   Offset: 0xB0E450   Length: 0x11B
    public int GetLeftPrisonDay()
    {
        var pStatics = *(int64*)(DAT_181d72cc8 + 184);
        float fVar1;
        long lVar2;
        if ((*pStatics != 0) &&
           (lVar2 = *(int64 *)(*pStatics + 32)) != null) {
          lVar2 = WorldData.Player(lVar2,0);
          if (lVar2 != null) {
            fVar1 = *(float *)(lVar2 + 0x1c8);
            Mathf.CeilToInt(fVar1 / (float)**(int **)(DAT_181d92c88 + 184),0);
            return;
          }
        }
    }

    // Token : 0x6001FEA
    // RVA   : 0xB0F230   Offset: 0xB0E630   Length: 0xE5A
    public void PrisonButtonClicked(GameObject buttonClicked)
    {
        var pStatics_2c88 = *(int64*)(DAT_181d92c88 + 184);
        var pStatics_2cc8 = *(int64*)(DAT_181d72cc8 + 184);
        var pStatics_3d40 = *(int64*)(DAT_181d73d40 + 184);
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
        if (buttonClicked == null) goto LAB_180b10067;
        lVar3 = Object.get_name(buttonClicked,0);
        if (lVar3 == null) {
          return;
        }
        cVar1 = FUN_18171e540(lVar3,"0",0);
        if (!cVar1) {
          cVar1 = FUN_18171e540(lVar3,"1",0);
          if (cVar1) {
            lVar3 = FUN_18046c0a0(0);
            if (((lVar3 != null) && (*(int64 *)(lVar3 + 32) != 0)) &&
               (lVar3 = WorldData.Player(*(int64 *)(lVar3 + 32),0)) != null) {
              local_res20[0] = HeroData.GetBadFameFineMoney(lVar3,0);
              lVar4 = FUN_18046c400(0);
              local_48 = local_res20[0];
              uVar6 = il2cpp_value_box(DAT_181d80418,&local_48);
              uVar6 = String.Format("江湖声望和恶名越高，就需要缴纳越多罚金。\n眼下我需要一次性缴纳{0}两的罚金，方能将当前的恶名与悬赏一笔勾销。",uVar6,0);
              lVar3 = il2cpp_internal(DAT_181d97750);
              FUN_18132faf0(lVar3,DAT_181da3bd8);
              uVar5 = Int32.ToString(local_res20,0);
              uVar5 = String.Concat("缴纳罚金;ClearBadFame;;0/",uVar5,0);
              if (lVar3 != null) {
                FUN_18181e0a0(lVar3,uVar5,DAT_181da3d58);
                FUN_18181e0a0(lVar3,"还是算了;HideInteractUI",DAT_181da3d58);
                uVar5 = new SinglePlotData(uVar6,lVar3,1,0,3,"0",1,0,0);
                if (lVar4 != null) goto LAB_180b0f556;
              }
            }
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          cVar1 = FUN_18171e540(lVar3,"2",0);
          if (cVar1) {
            lVar3 = FUN_18046c0a0(0);
            if (((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) ||
               (lVar3 = *(int64 *)(*(int64 *)(lVar3 + 32) + 0x1b0)) == null)
            goto LAB_180b10067;
            if (*(float *)(lVar3 + 32) <= 0.0) {
              lVar3 = FUN_18046c0a0(0);
              if (((lVar3 != null) && (*(int64 *)(lVar3 + 32) != 0)) &&
                 (lVar3 = WorldData.Player(*(int64 *)(lVar3 + 32),0)) != null) {
                iVar2 = Mathf.RoundToInt((*(float *)(lVar3 + 0x1c8) * 0.1 + 1.0) * 100.0,0);
                lVar4 = FUN_18046c400(0);
                uVar6 = "只要花上些小钱贿赂狱卒，便可与其搞好关系。\n待到熟络之后，也能请他们帮忙行些方便。";
                if (*(char *)(pStatics_3d40 + 4) != false) {
                  uVar6 = "只要花上些小钱赔礼道歉，便可展现诚意。\n待到熟络之后，也能请守卫帮忙行些方便。";
                }
                lVar3 = il2cpp_internal(DAT_181d97750);
                FUN_18132faf0(lVar3,DAT_181da3bd8);
                local_48 = iVar2;
                uVar5 = il2cpp_value_box(DAT_181d80418,&local_48);
                uVar5 = String.Format("贿赂狱卒;BuyPrisonGuard;0;0/{0};♦降低少量警觉度\n♦增加少量熟络度",uVar5,0);
                if (lVar3 != null) {
                  FUN_18181e0a0(lVar3,uVar5,DAT_181da3d58);
                  local_44 = iVar2 * 2;
                  uVar5 = il2cpp_value_box(DAT_181d80418,&local_44);
                  local_40 = *(uint32 *)(pStatics_2c88 + 8);
                  uVar7 = il2cpp_value_box(DAT_181d80418,&local_40);
                  uVar5 = String.Format("治疗伤势;BuyPrisonGuard;1;0/{0};♦治疗全伤势10点;GuardFavor/{1}",uVar5,uVar7,0);
                  FUN_18181e0a0(lVar3,uVar5,DAT_181da3d58);
                  local_3c = iVar2 * 5;
                  uVar5 = il2cpp_value_box(DAT_181d80418,&local_3c);
                  local_38[0] = *(uint32 *)(pStatics_2c88 + 12);
                  uVar7 = il2cpp_value_box(DAT_181d80418,local_38);
                  uVar5 = String.Format("获取药品;BuyPrisonGuard;2;0/{0};♦获取随机药品;GuardFavor/{1}",uVar5,uVar7,0);
                  FUN_18181e0a0(lVar3,uVar5,DAT_181da3d58);
                  FUN_18181e0a0(lVar3,"还是算了;HideInteractUI",DAT_181da3d58);
                  uVar5 = new SinglePlotData(uVar6,lVar3,1,0,3,"0",1,0,0);
                  if (lVar4 != null) goto LAB_180b0f556;
                }
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              goto LAB_180b10067;
            }
            lVar4 = FUN_18046c400(0);
            uVar6 = "还需等待{0}日方能再次贿赂狱卒。";
            if (*(char *)(pStatics_3d40 + 4) != false) {
              uVar6 = "还需等待{0}日方能再次赔礼道歉";
            }
            if (((*pStatics_2cc8 == 0) ||
                (lVar3 = *(int64 *)(*pStatics_2cc8 + 32)) == null) ||
               (lVar3 = *(int64 *)(lVar3 + 0x1b0)) == null) {
        LAB_180b1007f:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            local_38[0] = *(uint32 *)(lVar3 + 32);
            uVar5 = il2cpp_value_box(DAT_181da22d8,local_38);
            uVar6 = String.Format(uVar6,uVar5,0);
            uVar5 = new SinglePlotData(uVar6,0,1,0,3,"0",1,0,0);
            if (lVar4 == null) goto LAB_180b1007f;
            goto LAB_180b0f556;
          }
          cVar1 = FUN_18171e540(lVar3,"3",0);
          if (!cVar1) {
            return;
          }
          lVar3 = il2cpp_internal(DAT_181d97750);
          FUN_18132faf0(lVar3,DAT_181da3bd8);
          uVar6 = "{0};PrepareBreakPrison;2;;;GuardFavor/{1}";
          uVar5 = "寻找物品";
          if (*(char *)(pStatics_3d40 + 4) == false) {
            uVar5 = "偷取物品";
          }
          local_38[0] = *(uint32 *)(pStatics_2c88 + 16);
          uVar7 = il2cpp_value_box(DAT_181d80418,local_38);
          uVar6 = String.Format(uVar6,uVar5,uVar7,0);
          if (lVar3 == null) {
        LAB_180b10085:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          FUN_18181e0a0(lVar3,uVar6,DAT_181da3d58);
          local_res10[0] = *(uint32 *)(pStatics_2c88 + 24);
          uVar6 = Int32.ToString(local_res10,0);
          uVar6 = String.Concat("暗中逃跑;PrepareBreakPrison;3;;;GuardFavor/",uVar6,0);
          FUN_18181e0a0(lVar3,uVar6,DAT_181da3d58);
          FUN_18181e0a0(lVar3,"强行越狱;PrepareBreakPrison;4",DAT_181da3d58);
          FUN_18181e0a0(lVar3,"还是算了;HideInteractUI",DAT_181da3d58);
          lVar4 = FUN_18046c0a0(0);
          if (((lVar4 == null) || (*(int64 *)(lVar4 + 32) == 0)) ||
             (lVar4 = WorldData.Player(*(int64 *)(lVar4 + 32),0)) == null) goto LAB_180b10085;
          cVar1 = HeroData.HaveTag(lVar4,0x171,0);
          if (cVar1) {
            local_res10[0] = *(uint32 *)(pStatics_2c88 + 20);
            uVar6 = Int32.ToString(local_res10,0);
            uVar6 = String.Concat("解开脚镣;PrepareBreakPrison;1;;;GuardFavor/",uVar6,0);
            FUN_181822520(lVar3,1,uVar6,DAT_181da4058);
          }
          lVar4 = FUN_18046c0a0(0);
          if (((lVar4 == null) || (*(int64 *)(lVar4 + 32) == 0)) ||
             (lVar4 = WorldData.Player(*(int64 *)(lVar4 + 32),0)) == null) goto LAB_180b10067;
          cVar1 = HeroData.HaveTag(lVar4,0x170,0);
          if (cVar1) {
            local_res10[0] = *(uint32 *)(pStatics_2c88 + 20);
            uVar6 = Int32.ToString(local_res10,0);
            uVar6 = String.Concat("解开手铐;PrepareBreakPrison;0;;;GuardFavor/",uVar6,0);
            FUN_181822520(lVar3,1,uVar6,DAT_181da4058);
          }
          lVar4 = FUN_18046c400(0);
          uVar5 = il2cpp_internal(DAT_181da24d8);
          uVar6 = "哼，我#$PlayerName#堂堂一代大侠，\n岂能在此处虚度光阴，受尽白眼！\n得想个办法，尽快逃出这鬼地方才行。";
        }
        else {
          iVar2 = PrisonController.GetLeftPrisonDay(this,0);
          if (0 < iVar2) {
            lVar4 = FUN_18046c400(0);
            local_48 = **(int **)(DAT_181d92c88 + 184);
            uVar6 = il2cpp_value_box(DAT_181d80418,&local_48);
            uVar6 = String.Format("每日可降低{0}点恶名，待恶名降低到0时便可出狱。\n同时每日也会累积少量伤势，不过若能与看守更为熟络，便也能少受些罪。",uVar6,0);
            lVar3 = il2cpp_internal(DAT_181d97750);
            FUN_18132faf0(lVar3,DAT_181da3bd8);
            if (lVar3 != null) {
              FUN_18181e0a0(lVar3,"1天;PlayerContinuePrison;1",DAT_181da3d58);
              FUN_18181e0a0(lVar3,"5天;PlayerContinuePrison;5",DAT_181da3d58);
              FUN_18181e0a0(lVar3,"10天;PlayerContinuePrison;10",DAT_181da3d58);
              FUN_18181e0a0(lVar3,"取消;HideInteractUI",DAT_181da3d58);
              uVar5 = new SinglePlotData(uVar6,lVar3,1,0,3,"0",1,0,0);
              if (lVar4 != null) goto LAB_180b0f556;
            }
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          lVar4 = FUN_18046c400(0);
          lVar3 = il2cpp_internal(DAT_181d97750);
          FUN_18132faf0(lVar3,DAT_181da3bd8);
          if (lVar3 == null) goto LAB_180b10067;
          FUN_18181e0a0(lVar3,"重见天日;PlayerFinishPrison",DAT_181da3d58);
          uVar5 = il2cpp_internal(DAT_181da24d8);
          uVar6 = "刑期已满，总算可以离开这鬼地方了......";
        }
        SinglePlotData.ctor(uVar5,uVar6,lVar3,1,0,3,"0",1,0,0);
        if (lVar4 == null) {
        LAB_180b10067:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        LAB_180b0f556:
        PlotController.ChangePlot(lVar4,uVar5,0);
    }

    // Token : 0x6001FEB
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

    // Token : 0x6001FEC
    // RVA   : 0xB11A80   Offset: 0xB10E80   Length: 0xB7
    private static void /*cctor*/()
    {
        var pStatics = *(int64*)(DAT_181d92c88 + 184);
        **(uint32 **)(DAT_181d92c88 + 184) = 5;
        *(uint32 *)(pStatics + 4) = 5;
        *(uint32 *)(pStatics + 8) = 20;
        *(uint32 *)(pStatics + 12) = 40;
        *(uint32 *)(pStatics + 16) = 10;
        *(uint32 *)(pStatics + 20) = 30;
        *(uint32 *)(pStatics + 24) = 50;
    }

}
