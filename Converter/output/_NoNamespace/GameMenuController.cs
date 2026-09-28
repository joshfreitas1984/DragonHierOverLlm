// ============================================================
// Type  : GameMenuController
// Token : 0x20002A7
// ============================================================

public class GameMenuController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001560
    public GameObject gameMenu;

    // Token: 0x4001561
    public SaveLoadMenuController saveLoadMenuController;

    // Token: 0x4001562
    public SettingMenuController settingMenuController;

    // Token: 0x4001563
    public HandBookMenuController handBookMenuController;

    // Token: 0x4001564
    private static GameMenuController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001691
    // RVA   : 0xC2EDB0   Offset: 0xC2E1B0   Length: 0x15E
    public static GameMenuController get_Instance()
    {
        return **(uint64 **)(DAT_181d72dd8 + 184);
    }

    // Token : 0x6001692
    // RVA   : 0xC2D040   Offset: 0xC2C440   Length: 0x99
    private void Awake()
    {
        ulong uVar1;
        bool cVar3;
        uVar1 = **(uint64 **)(DAT_181d72dd8 + 184);
        cVar3 = Object.op_Equality(uVar1,0,0);
        if (cVar3) {
          puVar2 = *(uint64 **)(DAT_181d72dd8 + 184);
          *puVar2 = this;
          il2cpp_internal(puVar2,this);
        }
    }

    // Token : 0x6001693
    // RVA   : 0xC2DA10   Offset: 0xC2CE10   Length: 0x107C
    public void ShowGameMenu()
    {
        var pStatics_2cc8 = *(int64*)(DAT_181d72cc8 + 184);
        var pStatics_3d40 = *(int64*)(DAT_181d73d40 + 184);
        var pStatics_6e30 = *(int64*)(DAT_181db6e30 + 184);
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
              TweenSettingsExtensions.SetUpdate(uVar4,1,DAT_181dc1db0);
              if ((this.gameMenu != null) &&
                 ((lVar3 = GameObject.get_transform(this.gameMenu,0), lVar3 != null &&
                  (lVar3 = Transform.Find(lVar3,"BlackBack",0)) != null))) {
                plVar5 = (int64 *)Component.GetComponent(lVar3,DAT_181d94460);
                puVar6 = (uint32 *)FUN_180d98fe0(&local_28,0);
                if (plVar5 != (int64 *)0) {
                  local_28 = *puVar6;
                  uStack_24 = puVar6[1];
                  uStack_20 = puVar6[2];
                  uStack_1c = puVar6[3];
                  (**(code **)(*plVar5 + 0x2a8))(plVar5,&local_28,*(uint64 *)(*plVar5 + 0x2b0));
                  if (((this.gameMenu != null) &&
                      (lVar3 = GameObject.get_transform(this.gameMenu,0)) != null) &&
                     (lVar3 = Transform.Find(lVar3,"BlackBack",0)) != null) {
                    uVar4 = Component.GetComponent(lVar3,DAT_181d94460);
                    uVar4 = DOTweenModuleUI.DOFade(uVar4,0x3f000000,0x3e800000,0);
                    TweenSettingsExtensions.SetUpdate(uVar4,1,DAT_181dc1c20);
                    if (((this.gameMenu != null) &&
                        (lVar3 = GameObject.get_transform(this.gameMenu,0)) != null)
                       && ((lVar3 = Transform.Find(lVar3,"GameInfoBack",0), lVar3 != null &&
                           (lVar3 = Component.GetComponent(lVar3,DAT_181d938e0)) != null))) {
                      CanvasGroup.set_alpha(lVar3,0,0);
                      if (((this.gameMenu != null) &&
                          (lVar3 = GameObject.get_transform(this.gameMenu,0)) != null
                          ) && (lVar3 = Transform.Find(lVar3,"GameInfoBack",0)) != null) {
                        uVar4 = Component.GetComponent(lVar3,DAT_181d938e0);
                        uVar4 = DOTweenModuleUI.DOFade(uVar4,0x3f800000,0x3e800000,0);
                        TweenSettingsExtensions.SetUpdate(uVar4,1,DAT_181dc1ca8);
                        if (((this.gameMenu != null) &&
                            (lVar3 = GameObject.get_transform(this.gameMenu,0),
                            lVar3 != null)) && (lVar3 = Transform.Find(lVar3,"GameInfoBack",0)) != null)
                        {
                          uVar4 = Transform.Find(lVar3,"GameInfo",0);
                          cVar2 = Object.op_Inequality(uVar4,0,0);
                          if (cVar2) {
                            uVar4 = **(uint64 **)(DAT_181d72cc8 + 184);
                            cVar2 = Object.op_Inequality(uVar4,0,0);
                            if (cVar2) {
                              if ((((this.gameMenu == null) ||
                                   (lVar3 = GameObject.get_transform(this.gameMenu,0),
                                   lVar3 == null)) ||
                                  (lVar3 = Transform.Find(lVar3,"GameInfoBack",0)) == null) ||
                                 (lVar3 = Transform.Find(lVar3,"GameInfo",0)) == null)
                              throw; // [null/range check failed]
                              uVar4 = Component.GetComponent(lVar3,DAT_181d96160);
                              lVar3 = *(int64 *)(pStatics_3d40 + 184);
                              if (((*pStatics_2cc8 == 0) ||
                                  (lVar9 = *(int64 *)(*pStatics_2cc8 + 32),
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
                                  (lVar3 = GameObject.get_transform(this.gameMenu,0),
                                  lVar3 == null)) ||
                                 ((lVar3 = Transform.Find(lVar3,"GameInfoBack",0), lVar3 == null ||
                                  (lVar3 = Transform.Find(lVar3,"GameInfo",0)) == null)))
                              throw; // [null/range check failed]
                              lVar9 = Component.GetComponent(lVar3,DAT_181d95560);
                              lVar3 = *(int64 *)(pStatics_3d40 + 200);
                              if ((*pStatics_2cc8 == 0) ||
                                 (lVar10 = *(int64 *)(*pStatics_2cc8 + 32),
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
                              uVar4 = *(uint64 *)(pStatics_6e30 + 8);
                              cVar2 = Object.op_Inequality(uVar4,0,0);
                              if (cVar2) {
                                if ((*pStatics_2cc8 == 0) ||
                                   (lVar3 = *(int64 *)(*pStatics_2cc8 + 32),
                                   lVar3 == null)) throw; // [null/range check failed]
                                if (*(int *)(lVar3 + 156) == 1) {
                                  if ((((this.gameMenu == null) ||
                                       (lVar3 = GameObject.get_transform(this.gameMenu,0)
                                       , lVar3 == null)) ||
                                      (lVar3 = Transform.Find(lVar3,"GameInfoBack",0)) == null) ||
                                     (lVar3 = Transform.Find(lVar3,"ChapterInfo",0)) == null)
                                  throw; // [null/range check failed]
                                  uVar4 = Component.GetComponent(lVar3,DAT_181d96160);
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
                                    uVar4 = Component.GetComponent(lVar3,DAT_181d96160);
                                    uVar8 = "";
                                    if (((*(byte *)(DAT_181d84898 + 0x133) & 4) != 0) &&
                                       (*(int *)(DAT_181d84898 + 224) == 0)) {
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
                                    uVar4 = Component.GetComponent(lVar3,DAT_181d96160);
                                    lVar3 = FUN_18046c0a0(0);
                                    if ((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0))
                                    throw; // [null/range check failed]
                                    iVar1 = *(int *)(*(int64 *)(lVar3 + 32) + 16);
                                    uVar8 = GlobalData.GetNumText(iVar1 + 1,0);
                                    lVar3 = *pStatics_6e30;
                                    if (((*pStatics_2cc8 == 0) ||
                                        (lVar9 = *(int64 *)
                                                  (*pStatics_2cc8 + 32),
                                        lVar9 == null)) || (lVar3 == null)) throw; // [null/range check failed]
                                    uVar7 = FUN_180002f80(lVar3,*(uint32 *)(lVar9 + 16),
                                                          DAT_181da4358);
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
                                lVar3 = Component.GetComponent(lVar3,DAT_181d95560);
                                if ((((*pStatics_2cc8 == 0) ||
                                     (lVar9 = *(int64 *)(*pStatics_2cc8 + 32),
                                     lVar9 == null)) || (lVar9 = *(int64 *)(lVar9 + 0x260)) == null)
                                   || (uVar4 = CustomDifficultyData.GetCustomDifficultyFullDescribe
                                                         (lVar9,0), lVar3 == null)) throw; // [null/range check failed]
                                *(uint64 *)(lVar3 + 24) = uVar4;
                              }
                              plVar5 = (int64 *)Resources.Load("Sound/SoundEffect/Paper",0);
                              plVar13 = (int64 *)0;
                              if ((plVar5 != (int64 *)0) && (*plVar5 == DAT_181daf348)) {
                                plVar13 = plVar5;
                              }
                              NGUITools.PlaySound(plVar13,0);
                              lVar3 = *(int64 *)(*(int64 *)(DAT_181d72d50 + 184) + 32);
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

    // Token : 0x6001694
    // RVA   : 0xC2EAF0   Offset: 0xC2DEF0   Length: 0x2B3
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
            uVar2 = TweenSettingsExtensions.SetUpdate(uVar2,1,DAT_181dc1db0);
            uVar3 = new OnTooltipCB(this,DAT_181dc4a98,0);
            TweenSettingsExtensions.OnComplete(uVar2,uVar3,DAT_181dc01d0);
            if (this.gameMenu != null) {
              lVar1 = GameObject.get_transform(this.gameMenu,0);
              if (lVar1 != null) {
                lVar1 = Transform.Find(lVar1,"BlackBack",0);
                if (lVar1 != null) {
                  uVar2 = Component.GetComponent(lVar1,DAT_181d94460);
                  uVar2 = DOTweenModuleUI.DOFade(uVar2,0,0x3e4ccccd,0);
                  TweenSettingsExtensions.SetUpdate(uVar2,1,DAT_181dc1c20);
                  if (this.gameMenu != null) {
                    lVar1 = GameObject.get_transform(this.gameMenu,0);
                    if (lVar1 != null) {
                      lVar1 = Transform.Find(lVar1,"GameInfoBack",0);
                      if (lVar1 != null) {
                        uVar2 = Component.GetComponent(lVar1,DAT_181d938e0);
                        uVar2 = DOTweenModuleUI.DOFade(uVar2,0,0x3e4ccccd,0);
                        TweenSettingsExtensions.SetUpdate(uVar2,1,DAT_181dc1ca8);
                        plVar4 = (int64 *)Resources.Load("Sound/SoundEffect/PaperQuick",0);
                        plVar5 = (int64 *)0;
                        if ((plVar4 != (int64 *)0) && (*plVar4 == DAT_181daf348)) {
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

    // Token : 0x6001695
    // RVA   : 0xC2D3C0   Offset: 0xC2C7C0   Length: 0x62D
    public void SaveButtonClicked()
    {
        var pStatics_0248 = *(int64*)(DAT_181db0248 + 184);
        var pStatics_5e30 = *(int64*)(DAT_181dc5e30 + 184);
        bool cVar1;
        long lVar2;
        ulong uVar3;
        lVar2 = *(int64 *)(*(int64 *)(DAT_181d72d50 + 184) + 32);
        if (lVar2 == null) throw; // [null/range check failed]
        cVar1 = GameDataController.HaveTask(lVar2,0);
        if (!cVar1) {
          if (*(int64 *)(lVar2 + 48) == 0) throw; // [null/range check failed]
          cVar1 = GameSaveData.CheckAllFinished(*(int64 *)(lVar2 + 48),0);
          if (!cVar1) goto LAB_180c2d909;
          uVar3 = *(uint64 *)(pStatics_5e30 + 8);
          cVar1 = Object.op_Inequality(uVar3,0,0);
          if (!cVar1) {
        LAB_180c2d69d:
            uVar3 = *(uint64 *)(pStatics_0248 + 80);
            cVar1 = Object.op_Inequality(uVar3,0,0);
            if (cVar1) {
              lVar2 = *(int64 *)(pStatics_0248 + 80);
              if (lVar2 == null) throw; // [null/range check failed]
              if (*(int *)(lVar2 + 36) != 0) {
                lVar2 = FUN_18046c0a0(0);
                uVar3 = "战斗中无法存档！";
                goto joined_r0x000180c2d688;
              }
            }
            uVar3 = FUN_18046c360(0);
            cVar1 = Object.op_Inequality(uVar3,0,0);
            if (cVar1) {
              lVar2 = FUN_18046c360(0);
              if ((lVar2 == null) || (*(int64 *)(lVar2 + 40) == 0)) throw; // [null/range check failed]
              cVar1 = GameObject.get_activeSelf(*(int64 *)(lVar2 + 40),0);
              if (cVar1) {
                lVar2 = FUN_18046c0a0(0);
                uVar3 = "会议中无法存档！";
                goto joined_r0x000180c2d688;
              }
            }
            if (this.saveLoadMenuController != null) {
              SaveLoadMenuController.ShowLoadMenu(this.saveLoadMenuController,0,0);
              return;
            }
            throw; // [null/range check failed]
          }
          lVar2 = *(int64 *)(pStatics_5e30 + 8);
          if (lVar2 == null) throw; // [null/range check failed]
          cVar1 = ExploreController.IsExploring(lVar2,0);
          if (!cVar1) goto LAB_180c2d69d;
          lVar2 = FUN_18046c0a0(0);
          uVar3 = "探索中无法存档！";
        }
        else {
        LAB_180c2d909:
          lVar2 = **(int64 **)(DAT_181d72cc8 + 184);
          uVar3 = "演算中无法存档！";
        }
        joined_r0x000180c2d688:
        if (lVar2 != null) {
          GameController.ShowTextOnMouse(lVar2,uVar3,0);
          plVar4 = (int64 *)Resources.Load("Sound/SoundEffect/WrongClick",0);
          plVar5 = (int64 *)0;
          if ((plVar4 != (int64 *)0) && (*plVar4 == DAT_181daf348)) {
            plVar5 = plVar4;
          }
          NGUITools.PlaySound(plVar5,0);
          return;
        }
    }

    // Token : 0x6001696
    // RVA   : 0xC2D100   Offset: 0xC2C500   Length: 0x1F6
    public void LoadButtonClicked()
    {
        var pStatics = *(int64*)(DAT_181d72cc8 + 184);
        long lVar1;
        bool cVar2;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d72d50 + 184) + 32);
        if ((lVar1 != null) && (lVar1 = *(int64 *)(lVar1 + 48)) != null) {
          cVar2 = GameSaveData.CheckAllFinished(lVar1,0);
          if (!cVar2) {
            if (*pStatics != 0) {
              GameController.ShowTextOnMouse(*pStatics,"存档中无法读档！",0);
              plVar3 = (int64 *)Resources.Load("Sound/SoundEffect/WrongClick",0);
              plVar4 = (int64 *)0;
              if ((plVar3 != (int64 *)0) && (*plVar3 == DAT_181daf348)) {
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

    // Token : 0x6001697
    // RVA   : 0xC2D9F0   Offset: 0xC2CDF0   Length: 0x1D
    public void SettingButtonClicked()
    {
        if (this.settingMenuController != null) {
          SettingMenuController.ShowSettingMenu(this.settingMenuController,0);
          return;
        }
    }

    // Token : 0x6001698
    // RVA   : 0xC2D0E0   Offset: 0xC2C4E0   Length: 0x1D
    public void HandBookButtonClicked()
    {
        if (this.handBookMenuController != null) {
          HandBookMenuController.ShowHandBookMenu(this.handBookMenuController,0);
          return;
        }
    }

    // Token : 0x6001699
    // RVA   : 0xC2D300   Offset: 0xC2C700   Length: 0xB9
    public void QuitButtonClicked()
    {
        long lVar1;
        ulong uVar2;
        lVar1 = **(int64 **)(DAT_181da8710 + 184);
        uVar2 = Component.get_gameObject(this,0);
        if (lVar1 != null) {
          SureMenu.CallSureMenu(lVar1,"确认退出游戏吗？\n<color=red>未保存的进度将会丢失！</color>","SureQuitGame",0,uVar2,1,0,0,0,0);
          return;
        }
    }

    // Token : 0x600169A
    // RVA   : 0xC2EA90   Offset: 0xC2DE90   Length: 0x5C
    public void SureQuitGame()
    {
        SceneManager.LoadScene("TitleScene",0);
    }

    // Token : 0x600169B
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

    // Token : 0x600169C
    // RVA   : 0x78D070   Offset: 0x78C470   Length: 0x20
    private void <UnshowGameMenu>b__9_0()
    {
        if (this.gameMenu != null) {
          GameObject.SetActive(this.gameMenu,0,0);
          return;
        }
    }

}
