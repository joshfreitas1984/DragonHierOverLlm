// ============================================================
// Type  : GameMenuController
// Token : 0x20002B0
// ============================================================

public class GameMenuController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40015B0
    public GameObject gameMenu;

    // Token: 0x40015B1
    public SaveLoadMenuController saveLoadMenuController;

    // Token: 0x40015B2
    public SettingMenuController settingMenuController;

    // Token: 0x40015B3
    public HandBookMenuController handBookMenuController;

    // Token: 0x40015B4
    private static GameMenuController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600170D
    // RVA   : 0x6BA700   Offset: 0x6B9500   Length: 0x36
    public static GameMenuController get_Instance()
    {
        return **(uint64 **)(DAT_181e52980 + 184);
    }

    // Token : 0x600170E
    // RVA   : 0x6B89C0   Offset: 0x6B77C0   Length: 0x99
    private void Awake()
    {
        ulong uVar1;
        bool cVar3;
        uVar1 = **(uint64 **)(DAT_181e52980 + 184);
        cVar3 = Object.op_Equality(uVar1,0,0);
        if (cVar3) {
          puVar2 = *(uint64 **)(DAT_181e52980 + 184);
          *puVar2 = this;
          il2cpp_internal(puVar2,this);
        }
    }

    // Token : 0x600170F
    // RVA   : 0x6B9360   Offset: 0x6B8160   Length: 0x107C
    public void ShowGameMenu()
    {
        var pStatics_38e8 = *(int64*)(DAT_181e538e8 + 184);
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
              TweenSettingsExtensions.SetUpdate(uVar4,1,DAT_181ea59e0);
              if ((this.gameMenu != null) &&
                 ((lVar3 = GameObject.get_transform(this.gameMenu,0), lVar3 != null &&
                  (lVar3 = Transform.Find(lVar3,"BlackBack",0)) != null))) {
                plVar5 = (int64 *)Component.GetComponent(lVar3,DAT_181e777b8);
                puVar6 = (uint32 *)FUN_180af4e90(&local_28,0);
                if (plVar5 != (int64 *)0) {
                  local_28 = *puVar6;
                  uStack_24 = puVar6[1];
                  uStack_20 = puVar6[2];
                  uStack_1c = puVar6[3];
                  (**(code **)(*plVar5 + 0x2a8))(plVar5,&local_28,*(uint64 *)(*plVar5 + 0x2b0));
                  if (((this.gameMenu != null) &&
                      (lVar3 = GameObject.get_transform(this.gameMenu,0)) != null) &&
                     (lVar3 = Transform.Find(lVar3,"BlackBack",0)) != null) {
                    uVar4 = Component.GetComponent(lVar3,DAT_181e777b8);
                    uVar4 = DOTweenModuleUI.DOFade(uVar4,0x3f000000,0x3e800000,0);
                    TweenSettingsExtensions.SetUpdate(uVar4,1,DAT_181ea5848);
                    if (((this.gameMenu != null) &&
                        (lVar3 = GameObject.get_transform(this.gameMenu,0)) != null)
                       && ((lVar3 = Transform.Find(lVar3,"GameInfoBack",0), lVar3 != null &&
                           (lVar3 = Component.GetComponent(lVar3,DAT_181e76c38)) != null))) {
                      CanvasGroup.set_alpha(lVar3,0,0);
                      if (((this.gameMenu != null) &&
                          (lVar3 = GameObject.get_transform(this.gameMenu,0)) != null
                          ) && (lVar3 = Transform.Find(lVar3,"GameInfoBack",0)) != null) {
                        uVar4 = Component.GetComponent(lVar3,DAT_181e76c38);
                        uVar4 = DOTweenModuleUI.DOFade(uVar4,0x3f800000,0x3e800000,0);
                        TweenSettingsExtensions.SetUpdate(uVar4,1,DAT_181ea58d0);
                        if (((this.gameMenu != null) &&
                            (lVar3 = GameObject.get_transform(this.gameMenu,0),
                            lVar3 != null)) && (lVar3 = Transform.Find(lVar3,"GameInfoBack",0)) != null)
                        {
                          uVar4 = Transform.Find(lVar3,"GameInfo",0);
                          cVar2 = Object.op_Inequality(uVar4,0,0);
                          if (cVar2) {
                            uVar4 = **(uint64 **)(DAT_181e52870 + 184);
                            cVar2 = Object.op_Inequality(uVar4,0,0);
                            if (cVar2) {
                              if ((((this.gameMenu == null) ||
                                   (lVar3 = GameObject.get_transform(this.gameMenu,0),
                                   lVar3 == null)) ||
                                  (lVar3 = Transform.Find(lVar3,"GameInfoBack",0)) == null) ||
                                 (lVar3 = Transform.Find(lVar3,"GameInfo",0)) == null)
                              throw; // [null/range check failed]
                              uVar4 = Component.GetComponent(lVar3,DAT_181e79538);
                              lVar3 = *(int64 *)(pStatics_38e8 + 184);
                              if (((GameController._instance == null) ||
                                  (lVar9 = GameController._instance.worldData,
                                  lVar9 == null)) || (lVar3 == null)) throw; // [null/range check failed]
                              uVar12 = lVar9.gameMode;
                              if (lVar3.cityAreaID <= uVar12) {
                                ThrowHelper.ThrowArgumentOutOfRangeException(0);
                              }
                              uVar8 = *(uint64 *)
                                       (lVar3.chapter + 32 + (int64)(int)uVar12 * 8);
                              lVar3 = FUN_1802106e0(0);
                              if ((lVar3 == null) || (lVar3.villageAreaID == null)) throw; // [null/range check failed]
                              uVar7 = WorldData.GetDifficlutyName(lVar3.villageAreaID,0);
                              uVar8 = String.Format("模式: {0}\n难度: {1}",uVar8,uVar7,0);
                              LTLocalization.SetText(uVar4,uVar8,0);
                              if (((this.gameMenu == null) ||
                                  (lVar3 = GameObject.get_transform(this.gameMenu,0),
                                  lVar3 == null)) ||
                                 ((lVar3 = Transform.Find(lVar3,"GameInfoBack",0), lVar3 == null ||
                                  (lVar3 = Transform.Find(lVar3,"GameInfo",0)) == null)))
                              throw; // [null/range check failed]
                              lVar9 = Component.GetComponent(lVar3,DAT_181e788b8);
                              lVar3 = *(int64 *)(pStatics_38e8 + 200);
                              if ((GameController._instance == null) ||
                                 (lVar10 = GameController._instance.worldData,
                                 lVar10 == null)) throw; // [null/range check failed]
                              iVar1 = lVar10.gameDifficulty;
                              lVar10 = FUN_1802106e0(0);
                              if ((lVar10 == null) || ((lVar10.villageAreaID == null || (lVar3 == null))))
                              throw; // [null/range check failed]
                              uVar12 = (uint32)(*(char *)(lVar10.villageAreaID + 164) == false) +
                                       iVar1;
                              if (lVar3.cityAreaID <= uVar12) {
                                ThrowHelper.ThrowArgumentOutOfRangeException(0);
                              }
                              if (lVar9 == null) throw; // [null/range check failed]
                              lVar9.cityAreaID =
                                   *(uint64 *)
                                    (lVar3.chapter + 32 + (int64)(int)uVar12 * 8);
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
                              uVar4 = ChapterController._instance;
                              cVar2 = Object.op_Inequality(uVar4,0,0);
                              if (cVar2) {
                                if ((GameController._instance == null) ||
                                   (lVar3 = GameController._instance.worldData,
                                   lVar3 == null)) throw; // [null/range check failed]
                                if (lVar3.gameMode == 1) {
                                  if ((((this.gameMenu == null) ||
                                       (lVar3 = GameObject.get_transform(this.gameMenu,0)
                                       , lVar3 == null)) ||
                                      (lVar3 = Transform.Find(lVar3,"GameInfoBack",0)) == null) ||
                                     (lVar3 = Transform.Find(lVar3,"ChapterInfo",0)) == null)
                                  throw; // [null/range check failed]
                                  uVar4 = Component.GetComponent(lVar3,DAT_181e79538);
                                  lVar3 = FUN_180210340(0);
                                  if (lVar3 == null) throw; // [null/range check failed]
                                  uVar8 = ChapterController.GetChapterDescribe(lVar3,"\n",0);
                                }
                                else {
                                  lVar3 = FUN_1802106e0(0);
                                  if ((lVar3 == null) || (lVar3.villageAreaID == null))
                                  throw; // [null/range check failed]
                                  lVar9 = this.gameMenu;
                                  if (*(int *)(lVar3.villageAreaID + 16) < 0) {
                                    if (((lVar9 == null) ||
                                        (lVar3 = GameObject.get_transform(lVar9,0)) == null) ||
                                       ((lVar3 = Transform.Find(lVar3,"GameInfoBack",0), lVar3 == null ||
                                        (lVar3 = Transform.Find(lVar3,"ChapterInfo",0)) == null)))
                                    throw; // [null/range check failed]
                                    uVar4 = Component.GetComponent(lVar3,DAT_181e79538);
                                    uVar8 = "";
                                    if (((*(byte *)(DAT_181e64c70 + 0x133) & 4) != 0) &&
                                       (*(int *)(DAT_181e64c70 + 224) == 0)) {
                                      il2cpp_runtime_class_init();
                                      uVar8 = "";
                                    }
                                  }
                                  else {
                                    if ((((lVar9 == null) ||
                                         (lVar3 = GameObject.get_transform(lVar9,0)) == null) ||
                                        (lVar3 = Transform.Find(lVar3,"GameInfoBack",0)) == null) ||
                                       (lVar3 = Transform.Find(lVar3,"ChapterInfo",0)) == null)
                                    throw; // [null/range check failed]
                                    uVar4 = Component.GetComponent(lVar3,DAT_181e79538);
                                    lVar3 = FUN_1802106e0(0);
                                    if ((lVar3 == null) || (lVar3.villageAreaID == null))
                                    throw; // [null/range check failed]
                                    iVar1 = *(int *)(lVar3.villageAreaID + 16);
                                    uVar8 = GlobalData.GetNumText(iVar1 + 1,0);
                                    lVar3 = ChapterController.chapterTitles;
                                    if (((GameController._instance == null) ||
                                        (lVar9 = *(int64 *)
                                                  (GameController._instance + 32),
                                        lVar9 == null)) || (lVar3 == null)) throw; // [null/range check failed]
                                    uVar7 = FUN_1800024b0(lVar3,lVar9.chapter,
                                                          DAT_181e86970);
                                    lVar3 = FUN_180210340(0);
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
                                if (((this.gameMenu == null) ||
                                    (lVar3 = GameObject.get_transform(this.gameMenu,0),
                                    lVar3 == null)) ||
                                   ((lVar3 = Transform.Find(lVar3,"GameInfoBack",0), lVar3 == null ||
                                    (lVar3 = Transform.Find(lVar3,"CustomDifficultyIcon",0)) == null)))
                                throw; // [null/range check failed]
                                lVar3 = Component.get_gameObject(lVar3,0);
                                if (lVar3 == null) throw; // [null/range check failed]
                                GameObject.SetActive(lVar3,1,0);
                                if ((((this.gameMenu == null) ||
                                     (lVar3 = GameObject.get_transform(this.gameMenu,0),
                                     lVar3 == null)) ||
                                    (lVar3 = Transform.Find(lVar3,"GameInfoBack",0)) == null) ||
                                   (lVar3 = Transform.Find(lVar3,"CustomDifficultyIcon",0)) == null)
                                throw; // [null/range check failed]
                                lVar3 = Component.GetComponent(lVar3,DAT_181e788b8);
                                if ((((GameController._instance == null) ||
                                     (lVar9 = GameController._instance.worldData,
                                     lVar9 == null)) || (lVar9 = lVar9.customDifficultyData) == null)
                                   || (uVar4 = CustomDifficultyData.GetCustomDifficultyFullDescribe
                                                         (lVar9,0), lVar3 == null)) throw; // [null/range check failed]
                                lVar3.cityAreaID = uVar4;
                              }
                              plVar5 = (int64 *)Resources.Load("Sound/SoundEffect/Paper",0);
                              plVar13 = (int64 *)0;
                              if ((plVar5 != (int64 *)0) && (*plVar5 == DAT_181e8f4a0)) {
                                plVar13 = plVar5;
                              }
                              NGUITools.PlaySound(plVar13,0);
                              lVar3 = *(int64 *)(*(int64 *)(DAT_181e528f8 + 184) + 32);
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

    // Token : 0x6001710
    // RVA   : 0x6BA440   Offset: 0x6B9240   Length: 0x2B3
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
            uVar2 = TweenSettingsExtensions.SetUpdate(uVar2,1,DAT_181ea59e0);
            uVar3 = new OnTooltipCB(this,DAT_181e50b48,0);
            TweenSettingsExtensions.OnComplete(uVar2,uVar3,DAT_181ea3dc0);
            if (this.gameMenu != null) {
              lVar1 = GameObject.get_transform(this.gameMenu,0);
              if (lVar1 != null) {
                lVar1 = Transform.Find(lVar1,"BlackBack",0);
                if (lVar1 != null) {
                  uVar2 = Component.GetComponent(lVar1,DAT_181e777b8);
                  uVar2 = DOTweenModuleUI.DOFade(uVar2,0,0x3e4ccccd,0);
                  TweenSettingsExtensions.SetUpdate(uVar2,1,DAT_181ea5848);
                  if (this.gameMenu != null) {
                    lVar1 = GameObject.get_transform(this.gameMenu,0);
                    if (lVar1 != null) {
                      lVar1 = Transform.Find(lVar1,"GameInfoBack",0);
                      if (lVar1 != null) {
                        uVar2 = Component.GetComponent(lVar1,DAT_181e76c38);
                        uVar2 = DOTweenModuleUI.DOFade(uVar2,0,0x3e4ccccd,0);
                        TweenSettingsExtensions.SetUpdate(uVar2,1,DAT_181ea58d0);
                        plVar4 = (int64 *)Resources.Load("Sound/SoundEffect/PaperQuick",0);
                        plVar5 = (int64 *)0;
                        if ((plVar4 != (int64 *)0) && (*plVar4 == DAT_181e8f4a0)) {
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

    // Token : 0x6001711
    // RVA   : 0x6B8D30   Offset: 0x6B7B30   Length: 0x60F
    public void SaveButtonClicked()
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        lVar2 = *(int64 *)(*(int64 *)(DAT_181e528f8 + 184) + 32);
        if (lVar2 == null) throw; // [null/range check failed]
        cVar1 = GameDataController.CanSaveLoad(lVar2,0);
        if (!cVar1) {
          lVar2 = GameController._instance;
          uVar3 = "演算中无法存档！";
          if (lVar2 == null) throw; // [null/range check failed]
          goto LAB_1806b92dd;
        }
        uVar3 = BattleController.AttackAreaTypeStartMovePower;
        cVar1 = Object.op_Inequality(uVar3,0,0);
        if (!cVar1) {
        LAB_1806b8fef:
          uVar3 = PlotController.LaBaFestivelResultTalkText;
          cVar1 = Object.op_Inequality(uVar3,0,0);
          if (cVar1) {
            lVar2 = PlotController.LaBaFestivelResultTalkText;
            if (lVar2 == null) throw; // [null/range check failed]
            if (*(int *)(lVar2 + 36) != 0) {
              lVar2 = FUN_1802106e0(0);
              uVar3 = "战斗中无法存档！";
              goto joined_r0x0001806b8fda;
            }
          }
          uVar3 = FUN_1802109d0(0);
          cVar1 = Object.op_Inequality(uVar3,0,0);
          if (cVar1) {
            lVar2 = FUN_1802109d0(0);
            if ((lVar2 == null) || (lVar2.needAutoSave == null)) throw; // [null/range check failed]
            cVar1 = GameObject.get_activeSelf(lVar2.needAutoSave,0);
            if (cVar1) {
              lVar2 = FUN_1802106e0(0);
              uVar3 = "会议中无法存档！";
              goto joined_r0x0001806b8fda;
            }
          }
          if (this.saveLoadMenuController != null) {
            SaveLoadMenuController.ShowLoadMenu(this.saveLoadMenuController,0,0);
            return;
          }
        }
        else {
          lVar2 = BattleController.AttackAreaTypeStartMovePower;
          if (lVar2 == null) throw; // [null/range check failed]
          cVar1 = ExploreController.IsExploring(lVar2,0);
          if (!cVar1) goto LAB_1806b8fef;
          lVar2 = FUN_1802106e0(0);
          uVar3 = "探索中无法存档！";
        joined_r0x0001806b8fda:
          if (lVar2 != null) {
        LAB_1806b92dd:
            GameController.ShowTextOnMouse(lVar2,uVar3,0);
            plVar4 = (int64 *)Resources.Load("Sound/SoundEffect/WrongClick",0);
            plVar5 = (int64 *)0;
            if ((plVar4 != (int64 *)0) && (*plVar4 == DAT_181e8f4a0)) {
              plVar5 = plVar4;
            }
            NGUITools.PlaySound(plVar5,0);
            return;
          }
        }
    }

    // Token : 0x6001712
    // RVA   : 0x6B8A80   Offset: 0x6B7880   Length: 0x1E9
    public void LoadButtonClicked()
    {
        long lVar1;
        bool cVar2;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181e528f8 + 184) + 32);
        if (lVar1 != null) {
          cVar2 = GameDataController.CanLoad(lVar1,0);
          if (!cVar2) {
            if (GameController._instance != null) {
              GameController.ShowTextOnMouse(GameController._instance,"存档中无法读档！",0);
              plVar3 = (int64 *)Resources.Load("Sound/SoundEffect/WrongClick",0);
              plVar4 = (int64 *)0;
              if ((plVar3 != (int64 *)0) && (*plVar3 == DAT_181e8f4a0)) {
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

    // Token : 0x6001713
    // RVA   : 0x6B9340   Offset: 0x6B8140   Length: 0x1D
    public void SettingButtonClicked()
    {
        if (this.settingMenuController != null) {
          SettingMenuController.ShowSettingMenu(this.settingMenuController,0);
          return;
        }
    }

    // Token : 0x6001714
    // RVA   : 0x6B8A60   Offset: 0x6B7860   Length: 0x1D
    public void HandBookButtonClicked()
    {
        if (this.handBookMenuController != null) {
          HandBookMenuController.ShowHandBookMenu(this.handBookMenuController,0);
          return;
        }
    }

    // Token : 0x6001715
    // RVA   : 0x6B8C70   Offset: 0x6B7A70   Length: 0xB9
    public void QuitButtonClicked()
    {
        long lVar1;
        ulong uVar2;
        lVar1 = **(int64 **)(DAT_181e88b68 + 184);
        uVar2 = Component.get_gameObject(this,0);
        if (lVar1 != null) {
          SureMenu.CallSureMenu(lVar1,"确认退出游戏吗？\n<color=red>未保存的进度将会丢失！</color>","SureQuitGame",0,uVar2,1,0,0,0,0);
          return;
        }
    }

    // Token : 0x6001716
    // RVA   : 0x6BA3E0   Offset: 0x6B91E0   Length: 0x5C
    public void SureQuitGame()
    {
        SceneManager.LoadScene("TitleScene",0);
    }

    // Token : 0x6001717
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

    // Token : 0x6001718
    // RVA   : 0x52B140   Offset: 0x529F40   Length: 0x20
    private void <UnshowGameMenu>b__9_0()
    {
        if (this.gameMenu != null) {
          GameObject.SetActive(this.gameMenu,0,0);
          return;
        }
    }

}
