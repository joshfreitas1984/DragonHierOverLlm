// ============================================================
// Type  : GameMenuController
// Token : 0x20002A1
// ============================================================

public class GameMenuController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40014AE
    public GameObject gameMenu;

    // Token: 0x40014AF
    public SaveLoadMenuController saveLoadMenuController;

    // Token: 0x40014B0
    public SettingMenuController settingMenuController;

    // Token: 0x40014B1
    public HandBookMenuController handBookMenuController;

    // Token: 0x40014B2
    private static GameMenuController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600164D
    // RVA   : 0xCBDD70   Offset: 0xCBC570   Length: 0x36
    public static GameMenuController get_Instance()
    {
        return **(uint64 **)(DAT_181d4e090 + 184);
    }

    // Token : 0x600164E
    // RVA   : 0xCBC090   Offset: 0xCBA890   Length: 0x99
    private void Awake()
    {
        ulong uVar1;
        bool cVar3;
        uVar1 = **(uint64 **)(DAT_181d4e090 + 184);
        cVar3 = Object.op_Equality(uVar1,0,0);
        if (cVar3) {
          puVar2 = *(uint64 **)(DAT_181d4e090 + 184);
          *puVar2 = this;
          il2cpp_internal(puVar2,this);
        }
    }

    // Token : 0x600164F
    // RVA   : 0xCBCA60   Offset: 0xCBB260   Length: 0xFEC
    public void ShowGameMenu()
    {
        var pStatics_1c88 = *(int64*)(DAT_181d91c88 + 184);
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        var pStatics_ef00 = *(int64*)(DAT_181d4ef00 + 184);
        int iVar1;
        bool cVar2;
        long lVar3;
        ulong uVar4;
        ulong uVar7;
        ulong uVar8;
        long lVar9;
        long lVar10;
        ulong uVar11;
        uint uVar12;
        uint local_28;
        uint uStack_24;
        uint uStack_20;
        uint32 uStack_1c;
        if (this.gameMenu != null) {
          GameObject.SetActive(this.gameMenu,1,0);
          if (((this.gameMenu != null) &&
              (lVar3 = GameObject.get_transform(this.gameMenu,0)) != null) &&
             (lVar3 = Transform.Find(lVar3,"GameMenu",0)) != null) {
            local_28 = 0;
            uStack_24 = 0x3f800000;
            uStack_20 = 0x3f800000;
            Transform.set_localScale(lVar3,&local_28,0);
            if ((this.gameMenu != null) &&
               (lVar3 = GameObject.get_transform(this.gameMenu,0)) != null) {
              uVar4 = Transform.Find(lVar3,"GameMenu",0);
              uVar4 = ShortcutExtensions.DOScale(uVar4,0x3f800000,0x3e800000,0);
              TweenSettingsExtensions.SetUpdate(uVar4,1,DAT_181d98af0);
              if ((this.gameMenu != null) &&
                 ((lVar3 = GameObject.get_transform(this.gameMenu,0), lVar3 != null &&
                  (lVar3 = Transform.Find(lVar3,"BlackBack",0)) != null))) {
                plVar5 = (int64 *)Component.GetComponent(lVar3,DAT_181d6bc40);
                puVar6 = (uint32 *)FUN_180d904c0(&local_28,0);
                if (plVar5 != (int64 *)0) {
                  local_28 = *puVar6;
                  uStack_24 = puVar6[1];
                  uStack_20 = puVar6[2];
                  uStack_1c = puVar6[3];
                  (**(code **)(*plVar5 + 0x2a8))(plVar5,&local_28,*(uint64 *)(*plVar5 + 0x2b0));
                  if (((this.gameMenu != null) &&
                      (lVar3 = GameObject.get_transform(this.gameMenu,0)) != null) &&
                     (lVar3 = Transform.Find(lVar3,"BlackBack",0)) != null) {
                    uVar4 = Component.GetComponent(lVar3,DAT_181d6bc40);
                    uVar4 = DOTweenModuleUI.DOFade(uVar4,0x3f000000,0x3e800000,0);
                    TweenSettingsExtensions.SetUpdate(uVar4,1,DAT_181d98958);
                    if (((this.gameMenu != null) &&
                        (lVar3 = GameObject.get_transform(this.gameMenu,0)) != null)
                       && ((lVar3 = Transform.Find(lVar3,"GameInfoBack",0), lVar3 != null &&
                           (lVar3 = Component.GetComponent(lVar3,DAT_181d6b0c0)) != null))) {
                      CanvasGroup.set_alpha(lVar3,0,0);
                      if (((this.gameMenu != null) &&
                          (lVar3 = GameObject.get_transform(this.gameMenu,0)) != null
                          ) && (lVar3 = Transform.Find(lVar3,"GameInfoBack",0)) != null) {
                        uVar4 = Component.GetComponent(lVar3,DAT_181d6b0c0);
                        uVar4 = DOTweenModuleUI.DOFade(uVar4,0x3f800000,0x3e800000,0);
                        TweenSettingsExtensions.SetUpdate(uVar4,1,DAT_181d989e0);
                        if (((this.gameMenu != null) &&
                            (lVar3 = GameObject.get_transform(this.gameMenu,0),
                            lVar3 != null)) && (lVar3 = Transform.Find(lVar3,"GameInfoBack",0)) != null)
                        {
                          uVar4 = Transform.Find(lVar3,"GameInfo",0);
                          cVar2 = Object.op_Inequality(uVar4,0,0);
                          if (cVar2) {
                            uVar4 = **(uint64 **)(DAT_181d4df90 + 184);
                            cVar2 = Object.op_Inequality(uVar4,0,0);
                            if (cVar2) {
                              if ((((this.gameMenu == null) ||
                                   (lVar3 = GameObject.get_transform(this.gameMenu,0),
                                   lVar3 == null)) ||
                                  (lVar3 = Transform.Find(lVar3,"GameInfoBack",0)) == null) ||
                                 (lVar3 = Transform.Find(lVar3,"GameInfo",0)) == null)
                              throw; // [null/range check failed]
                              uVar4 = Component.GetComponent(lVar3,DAT_181d6d8c0);
                              lVar3 = *(int64 *)(pStatics_ef00 + 184);
                              if (((*pStatics_df90 == 0) ||
                                  (lVar9 = *(int64 *)(*pStatics_df90 + 32),
                                  lVar9 == null)) || (lVar3 == null)) throw; // [null/range check failed]
                              uVar12 = *(uint32 *)(lVar9 + 156);
                              if (*(uint32 *)(lVar3 + 24) <= uVar12) {
                                ThrowHelper.ThrowArgumentOutOfRangeException(0);
                              }
                              uVar8 = *(uint64 *)
                                       (*(int64 *)(lVar3 + 16) + 32 + (int64)(int)uVar12 * 8);
                              lVar3 = FUN_18046c0a0(0);
                              if ((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) throw; // [null/range check failed]
                              uVar7 = WorldData.GetDifficlutyName(*(int64 *)(lVar3 + 32),0);
                              uVar8 = String.Format("模式: {0}\n难度: {1}",uVar8,uVar7,0);
                              LTLocalization.SetText(uVar4,uVar8,0);
                              if (((this.gameMenu == null) ||
                                  ((lVar3 = GameObject.get_transform(this.gameMenu,0),
                                   lVar3 == null ||
                                   (lVar3 = Transform.Find(lVar3,"GameInfoBack",0)) == null))) ||
                                 (lVar3 = Transform.Find(lVar3,"GameInfo",0)) == null)
                              throw; // [null/range check failed]
                              lVar9 = Component.GetComponent(lVar3,DAT_181d6ccc0);
                              lVar3 = *(int64 *)(pStatics_ef00 + 200);
                              if ((*pStatics_df90 == 0) ||
                                 (lVar10 = *(int64 *)(*pStatics_df90 + 32),
                                 lVar10 == null)) throw; // [null/range check failed]
                              iVar1 = *(int *)(lVar10 + 160);
                              lVar10 = FUN_18046c0a0(0);
                              if ((lVar10 == null) || ((*(int64 *)(lVar10 + 32) == 0 || (lVar3 == null))))
                              throw; // [null/range check failed]
                              uVar12 = (uint32)(*(char *)(*(int64 *)(lVar10 + 32) + 164) == false) +
                                       iVar1;
                              if (*(uint32 *)(lVar3 + 24) <= uVar12) {
                                ThrowHelper.ThrowArgumentOutOfRangeException(0);
                              }
                              if (lVar9 == null) throw; // [null/range check failed]
                              *(uint64 *)(lVar9 + 24) =
                                   *(uint64 *)
                                    (*(int64 *)(lVar3 + 16) + 32 + (int64)(int)uVar12 * 8);
                              il2cpp_internal();
                            }
                          }
                          if (((this.gameMenu != null) &&
                              (lVar3 = GameObject.get_transform(this.gameMenu,0),
                              lVar3 != null)) && (lVar3 = Transform.Find(lVar3,"GameInfoBack",0)) != null
                             ) {
                            uVar4 = Transform.Find(lVar3,"ChapterInfo",0);
                            cVar2 = Object.op_Inequality(uVar4,0,0);
                            if (cVar2) {
                              uVar4 = *(uint64 *)(pStatics_1c88 + 8);
                              cVar2 = Object.op_Inequality(uVar4,0,0);
                              if (cVar2) {
                                if ((*pStatics_df90 == 0) ||
                                   (lVar3 = *(int64 *)(*pStatics_df90 + 32),
                                   lVar3 == null)) throw; // [null/range check failed]
                                if (*(int *)(lVar3 + 156) == 1) {
                                  if ((((this.gameMenu == null) ||
                                       (lVar3 = GameObject.get_transform(this.gameMenu,0)
                                       , lVar3 == null)) ||
                                      (lVar3 = Transform.Find(lVar3,"GameInfoBack",0)) == null) ||
                                     (lVar3 = Transform.Find(lVar3,"ChapterInfo",0)) == null)
                                  throw; // [null/range check failed]
                                  uVar4 = Component.GetComponent(lVar3,DAT_181d6d8c0);
                                  lVar3 = FUN_18046bd00(0);
                                  if (lVar3 == null) throw; // [null/range check failed]
                                  uVar8 = ChapterController.GetChapterDescribe(lVar3,"\n",0);
                                }
                                else {
                                  lVar3 = FUN_18046c0a0(0);
                                  if ((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0))
                                  throw; // [null/range check failed]
                                  lVar9 = this.gameMenu;
                                  if (*(int *)(*(int64 *)(lVar3 + 32) + 16) < 0) {
                                    if (((lVar9 == null) ||
                                        (lVar3 = GameObject.get_transform(lVar9,0)) == null) ||
                                       ((lVar3 = Transform.Find(lVar3,"GameInfoBack",0), lVar3 == null ||
                                        (lVar3 = Transform.Find(lVar3,"ChapterInfo",0)) == null)))
                                    throw; // [null/range check failed]
                                    uVar4 = Component.GetComponent(lVar3,DAT_181d6d8c0);
                                    uVar8 = "";
                                  }
                                  else {
                                    if ((((lVar9 == null) ||
                                         (lVar3 = GameObject.get_transform(lVar9,0)) == null) ||
                                        (lVar3 = Transform.Find(lVar3,"GameInfoBack",0)) == null) ||
                                       (lVar3 = Transform.Find(lVar3,"ChapterInfo",0)) == null)
                                    throw; // [null/range check failed]
                                    uVar4 = Component.GetComponent(lVar3,DAT_181d6d8c0);
                                    lVar3 = FUN_18046c0a0(0);
                                    if ((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0))
                                    throw; // [null/range check failed]
                                    iVar1 = *(int *)(*(int64 *)(lVar3 + 32) + 16);
                                    uVar8 = GlobalData.GetNumText(iVar1 + 1,0);
                                    lVar3 = *pStatics_1c88;
                                    if (((*pStatics_df90 == 0) ||
                                        (lVar9 = *(int64 *)
                                                  (*pStatics_df90 + 32),
                                        lVar9 == null)) || (lVar3 == null)) throw; // [null/range check failed]
                                    uVar7 = FUN_180002f80(lVar3,*(uint32 *)(lVar9 + 16),
                                                          DAT_181d7c9c0);
                                    lVar3 = FUN_18046bd00(0);
                                    if (lVar3 == null) throw; // [null/range check failed]
                                    uVar11 = ChapterController.GetChapterDescribe(lVar3,"\n",0);
                                    uVar8 = String.Format("第{0}章 {1}\n{2}",uVar8,uVar7,uVar11,0);
                                  }
                                }
                                LTLocalization.SetText(uVar4,uVar8,0);
                              }
                            }
                            if (((this.gameMenu != null) &&
                                (lVar3 = GameObject.get_transform(this.gameMenu,0),
                                lVar3 != null)) &&
                               (lVar3 = Transform.Find(lVar3,"GameInfoBack",0)) != null) {
                              uVar4 = Transform.Find(lVar3,"CustomDifficultyIcon",0);
                              cVar2 = Object.op_Inequality(uVar4,0,0);
                              if (cVar2) {
                                if ((((this.gameMenu == null) ||
                                     (lVar3 = GameObject.get_transform(this.gameMenu,0),
                                     lVar3 == null)) ||
                                    (lVar3 = Transform.Find(lVar3,"GameInfoBack",0)) == null) ||
                                   (lVar3 = Transform.Find(lVar3,"CustomDifficultyIcon",0)) == null)
                                throw; // [null/range check failed]
                                lVar3 = Component.get_gameObject(lVar3,0);
                                if (lVar3 == null) throw; // [null/range check failed]
                                GameObject.SetActive(lVar3,1,0);
                                if (((this.gameMenu == null) ||
                                    (lVar3 = GameObject.get_transform(this.gameMenu,0),
                                    lVar3 == null)) ||
                                   ((lVar3 = Transform.Find(lVar3,"GameInfoBack",0), lVar3 == null ||
                                    (lVar3 = Transform.Find(lVar3,"CustomDifficultyIcon",0)) == null)))
                                throw; // [null/range check failed]
                                lVar3 = Component.GetComponent(lVar3,DAT_181d6ccc0);
                                if ((((*pStatics_df90 == 0) ||
                                     (lVar9 = *(int64 *)(*pStatics_df90 + 32),
                                     lVar9 == null)) || (lVar9 = *(int64 *)(lVar9 + 0x260)) == null)
                                   || (uVar4 = CustomDifficultyData.GetCustomDifficultyFullDescribe
                                                         (lVar9,0), lVar3 == null)) throw; // [null/range check failed]
                                *(uint64 *)(lVar3 + 24) = uVar4;
                              }
                              plVar5 = (int64 *)Resources.Load("Sound/SoundEffect/Paper",0);
                              plVar13 = (int64 *)0;
                              if ((plVar5 != (int64 *)0) && (*plVar5 == DAT_181d8a228)) {
                                plVar13 = plVar5;
                              }
                              NGUITools.PlaySound(plVar13,0);
                              lVar3 = *(int64 *)(*(int64 *)(DAT_181d4e010 + 184) + 32);
                              if (lVar3 != null) {
                                GameDataController.SavePlayerprefData(lVar3,0);
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

    // Token : 0x6001650
    // RVA   : 0xCBDAB0   Offset: 0xCBC2B0   Length: 0x2B3
    public void UnshowGameMenu()
    {
        long lVar1;
        ulong uVar2;
        ulong uVar3;
        uint local_18;
        uint local_14;
        uint local_10;
        if (this.gameMenu != null) {
          lVar1 = GameObject.get_transform(this.gameMenu,0);
          if (lVar1 != null) {
            uVar2 = Transform.Find(lVar1,"GameMenu",0);
            local_18 = 0;
            local_14 = 0x3f800000;
            local_10 = 0x3f800000;
            uVar2 = ShortcutExtensions.DOScale(uVar2,&local_18,0x3e4ccccd,0);
            uVar2 = TweenSettingsExtensions.SetUpdate(uVar2,1,DAT_181d98af0);
            uVar3 = new OnTooltipCB(this,DAT_181d9bcf8,0);
            TweenSettingsExtensions.OnComplete(uVar2,uVar3,DAT_181d96ee8);
            if (this.gameMenu != null) {
              lVar1 = GameObject.get_transform(this.gameMenu,0);
              if (lVar1 != null) {
                lVar1 = Transform.Find(lVar1,"BlackBack",0);
                if (lVar1 != null) {
                  uVar2 = Component.GetComponent(lVar1,DAT_181d6bc40);
                  uVar2 = DOTweenModuleUI.DOFade(uVar2,0,0x3e4ccccd,0);
                  TweenSettingsExtensions.SetUpdate(uVar2,1,DAT_181d98958);
                  if (this.gameMenu != null) {
                    lVar1 = GameObject.get_transform(this.gameMenu,0);
                    if (lVar1 != null) {
                      lVar1 = Transform.Find(lVar1,"GameInfoBack",0);
                      if (lVar1 != null) {
                        uVar2 = Component.GetComponent(lVar1,DAT_181d6b0c0);
                        uVar2 = DOTweenModuleUI.DOFade(uVar2,0,0x3e4ccccd,0);
                        TweenSettingsExtensions.SetUpdate(uVar2,1,DAT_181d989e0);
                        plVar4 = (int64 *)Resources.Load("Sound/SoundEffect/PaperQuick",0);
                        plVar5 = (int64 *)0;
                        if ((plVar4 != (int64 *)0) && (*plVar4 == DAT_181d8a228)) {
                          plVar5 = plVar4;
                        }
                        NGUITools.PlaySound(plVar5,0);
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

    // Token : 0x6001651
    // RVA   : 0xCBC410   Offset: 0xCBAC10   Length: 0x62D
    public void SaveButtonClicked()
    {
        var pStatics_0c98 = *(int64*)(DAT_181da0c98 + 184);
        var pStatics_b128 = *(int64*)(DAT_181d8b128 + 184);
        bool cVar1;
        long lVar2;
        ulong uVar3;
        lVar2 = *(int64 *)(*(int64 *)(DAT_181d4e010 + 184) + 32);
        if (lVar2 == null) throw; // [null/range check failed]
        cVar1 = GameDataController.HaveTask(lVar2,0);
        if (!cVar1) {
          if (*(int64 *)(lVar2 + 48) == 0) throw; // [null/range check failed]
          cVar1 = GameSaveData.CheckAllFinished(*(int64 *)(lVar2 + 48),0);
          if (!cVar1) goto LAB_180cbc959;
          uVar3 = *(uint64 *)(pStatics_0c98 + 8);
          cVar1 = Object.op_Inequality(uVar3,0,0);
          if (!cVar1) {
        LAB_180cbc6ed:
            uVar3 = *(uint64 *)(pStatics_b128 + 80);
            cVar1 = Object.op_Inequality(uVar3,0,0);
            if (cVar1) {
              lVar2 = *(int64 *)(pStatics_b128 + 80);
              if (lVar2 == null) throw; // [null/range check failed]
              if (*(int *)(lVar2 + 36) != 0) {
                lVar2 = FUN_18046c0a0(0);
                uVar3 = "战斗中无法存档！";
                goto joined_r0x000180cbc6d8;
              }
            }
            uVar3 = FUN_18046c3a0(0);
            cVar1 = Object.op_Inequality(uVar3,0,0);
            if (cVar1) {
              lVar2 = FUN_18046c3a0(0);
              if ((lVar2 == null) || (*(int64 *)(lVar2 + 40) == 0)) throw; // [null/range check failed]
              cVar1 = GameObject.get_activeSelf(*(int64 *)(lVar2 + 40),0);
              if (cVar1) {
                lVar2 = FUN_18046c0a0(0);
                uVar3 = "会议中无法存档！";
                goto joined_r0x000180cbc6d8;
              }
            }
            if (this.saveLoadMenuController != null) {
              SaveLoadMenuController.ShowLoadMenu(this.saveLoadMenuController,0,0);
              return;
            }
            throw; // [null/range check failed]
          }
          lVar2 = *(int64 *)(pStatics_0c98 + 8);
          if (lVar2 == null) throw; // [null/range check failed]
          cVar1 = ExploreController.IsExploring(lVar2,0);
          if (!cVar1) goto LAB_180cbc6ed;
          lVar2 = FUN_18046c0a0(0);
          uVar3 = "探索中无法存档！";
        }
        else {
        LAB_180cbc959:
          lVar2 = **(int64 **)(DAT_181d4df90 + 184);
          uVar3 = "演算中无法存档！";
        }
        joined_r0x000180cbc6d8:
        if (lVar2 != null) {
          GameController.ShowTextOnMouse(lVar2,uVar3,0);
          plVar4 = (int64 *)Resources.Load("Sound/SoundEffect/WrongClick",0);
          plVar5 = (int64 *)0;
          if ((plVar4 != (int64 *)0) && (*plVar4 == DAT_181d8a228)) {
            plVar5 = plVar4;
          }
          NGUITools.PlaySound(plVar5,0);
          return;
        }
    }

    // Token : 0x6001652
    // RVA   : 0xCBC150   Offset: 0xCBA950   Length: 0x1F6
    public void LoadButtonClicked()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        long lVar1;
        bool cVar2;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d4e010 + 184) + 32);
        if ((lVar1 != null) && (lVar1 = *(int64 *)(lVar1 + 48)) != null) {
          cVar2 = GameSaveData.CheckAllFinished(lVar1,0);
          if (!cVar2) {
            if (*pStatics != 0) {
              GameController.ShowTextOnMouse(*pStatics,"存档中无法读档！",0);
              plVar3 = (int64 *)Resources.Load("Sound/SoundEffect/WrongClick",0);
              plVar4 = (int64 *)0;
              if ((plVar3 != (int64 *)0) && (*plVar3 == DAT_181d8a228)) {
                plVar4 = plVar3;
              }
              NGUITools.PlaySound(plVar4,0);
              return;
            }
          }
          else if (this.saveLoadMenuController != null) {
            SaveLoadMenuController.ShowLoadMenu(this.saveLoadMenuController,1);
            return;
          }
        }
    }

    // Token : 0x6001653
    // RVA   : 0xCBCA40   Offset: 0xCBB240   Length: 0x1D
    public void SettingButtonClicked()
    {
        if (this.settingMenuController != null) {
          SettingMenuController.ShowSettingMenu(this.settingMenuController,0);
          return;
        }
    }

    // Token : 0x6001654
    // RVA   : 0xCBC130   Offset: 0xCBA930   Length: 0x1D
    public void HandBookButtonClicked()
    {
        if (this.handBookMenuController != null) {
          HandBookMenuController.ShowHandBookMenu(this.handBookMenuController,0);
          return;
        }
    }

    // Token : 0x6001655
    // RVA   : 0xCBC350   Offset: 0xCBAB50   Length: 0xB9
    public void QuitButtonClicked()
    {
        long lVar1;
        ulong uVar2;
        lVar1 = **(int64 **)(DAT_181d834f0 + 184);
        uVar2 = Component.get_gameObject(this,0);
        if (lVar1 != null) {
          SureMenu.CallSureMenu(lVar1,"确认退出游戏吗？\n<color=red>未保存的进度将会丢失！</color>","SureQuitGame",0,uVar2,1,0,0,0,0);
          return;
        }
    }

    // Token : 0x6001656
    // RVA   : 0xCBDA50   Offset: 0xCBC250   Length: 0x5C
    public void SureQuitGame()
    {
        SceneManager.LoadScene("TitleScene",0);
    }

    // Token : 0x6001657
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

    // Token : 0x6001658
    // RVA   : 0x790570   Offset: 0x78ED70   Length: 0x20
    private void <UnshowGameMenu>b__9_0()
    {
        if (this.gameMenu != null) {
          GameObject.SetActive(this.gameMenu,0,0);
          return;
        }
    }

}
