// ============================================================
// Type  : SettingMenuController
// Token : 0x2000347
// ============================================================

public class SettingMenuController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001A4C
    public GameObject settingMenu;

    // Token: 0x4001A4D
    public Slider volumeSlider;

    // Token: 0x4001A4E
    public Slider bgmVolumeSlider;

    // Token: 0x4001A4F
    public Slider soundEffectVolumeSlider;

    // Token: 0x4001A50
    public Dropdown solutionDropDown;

    // Token: 0x4001A51
    public Dropdown languageDropDown;

    // Token: 0x4001A52
    public Toggle fullScreen;

    // Token: 0x4001A53
    public Toggle skipTutorial;

    // Token: 0x4001A54
    public Dropdown autoSave;

    // Token: 0x4001A55
    public Toggle fastTalk;

    // Token: 0x4001A56
    public Toggle fightViewFollow;

    // Token: 0x4001A57
    public Toggle fightScreenShake;

    // Token: 0x4001A58
    public Toggle skipSpeGetItem;

    // Token: 0x4001A59
    public Toggle rightPopInfo;

    // Token: 0x4001A5A
    public Toggle evadeBalance;

    // Token: 0x4001A5B
    public static List<SystemLanguage> TargetLanguage;

    // Token: 0x4001A5C
    private static SettingMenuController _instance;

    // Token: 0x4001A5D
    private bool inited;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002062
    // RVA   : 0x96AD40   Offset: 0x969540   Length: 0x58
    public static SettingMenuController get_Instance()
    {
        return *(uint64 *)(*(int64 *)(DAT_181d7c740 + 184) + 8);
    }

    // Token : 0x6002063
    // RVA   : 0x968CB0   Offset: 0x9674B0   Length: 0xE0
    private void Awake()
    {
        var pStatics = *(int64*)(DAT_181d7c740 + 184);
        ulong uVar1;
        bool cVar2;
        uVar1 = *(uint64 *)(pStatics + 8);
        cVar2 = Object.op_Equality(uVar1,0,0);
        if (cVar2) {
          puVar3 = (uint64 *)(pStatics + 8);
          *puVar3 = this;
          il2cpp_internal(puVar3,this);
        }
    }

    // Token : 0x6002064
    // RVA   : 0x969180   Offset: 0x967980   Length: 0x8F2
    public void RefreshSettingState()
    {
        var pStatics_e010 = *(int64*)(DAT_181d4e010 + 184);
        var pStatics_ef00 = *(int64*)(DAT_181d4ef00 + 184);
        long lVar2;
        long lVar3;
        bool cVar4;
        int iVar5;
        ulong uVar6;
        ulong uVar7;
        long lVar8;
        uint uVar9;
        uint[] local_res8 = new uint[2];
        uint[] local_res18 = new uint[4];
        if (!this.inited) {
          lVar8 = this.solutionDropDown;
          this.inited = 1;
          if (lVar8 == null) throw; // [null/range check failed]
          Dropdown.AddOptions(lVar8,*(uint64 *)(pStatics_ef00 + 176),0);
        }
        plVar1 = this.volumeSlider;
        lVar8 = *(int64 *)(pStatics_e010 + 8);
        if ((lVar8 != null) && (lVar8 = *(int64 *)(lVar8 + 16)) != null) {
          uVar9 = PlayerPrefDictionary.GetFloat(lVar8,"Volume",0);
          if (plVar1 != (int64 *)0) {
            (**(code **)(*plVar1 + 0x428))(plVar1,uVar9,*(uint64 *)(*plVar1 + 0x430));
            plVar1 = this.bgmVolumeSlider;
            lVar8 = *(int64 *)(pStatics_e010 + 8);
            if ((lVar8 != null) && (lVar8 = *(int64 *)(lVar8 + 16)) != null) {
              uVar9 = PlayerPrefDictionary.GetFloat(lVar8,"BgmVolume",0);
              if (plVar1 != (int64 *)0) {
                (**(code **)(*plVar1 + 0x428))(plVar1,uVar9,*(uint64 *)(*plVar1 + 0x430));
                plVar1 = this.soundEffectVolumeSlider;
                lVar8 = *(int64 *)(pStatics_e010 + 8);
                if ((lVar8 != null) && (lVar8 = *(int64 *)(lVar8 + 16)) != null) {
                  uVar9 = PlayerPrefDictionary.GetFloat(lVar8,"SoundEffectVolume",0);
                  if (plVar1 != (int64 *)0) {
                    (**(code **)(*plVar1 + 0x428))(plVar1,uVar9,*(uint64 *)(*plVar1 + 0x430));
                    lVar8 = this.solutionDropDown;
                    lVar2 = *(int64 *)(pStatics_ef00 + 176);
                    lVar3 = *(int64 *)(pStatics_e010 + 8);
                    if ((lVar3 != null) && (lVar3 = *(int64 *)(lVar3 + 16)) != null) {
                      local_res8[0] = PlayerPrefDictionary.GetInt(lVar3,"ScreenWidth",0);
                      uVar6 = Int32.ToString(local_res8,0);
                      lVar3 = *(int64 *)(pStatics_e010 + 8);
                      if ((lVar3 != null) && (lVar3 = *(int64 *)(lVar3 + 16)) != null) {
                        local_res8[0] = PlayerPrefDictionary.GetInt(lVar3,"ScreenHeight",0);
                        uVar7 = Int32.ToString(local_res8,0);
                        uVar6 = String.Concat(uVar6,"x",uVar7,0);
                        if (lVar2 != null) {
                          uVar9 = FUN_1817ff280(lVar2,uVar6,DAT_181d7c648);
                          if (lVar8 != null) {
                            Dropdown.set_value(lVar8,uVar9,0);
                            local_res18[0] = SceneManager.GetActiveScene(0);
                            lVar8 = Scene.get_name(local_res18,0);
                            if (lVar8 != null) {
                              cVar4 = String.Contains(lVar8,"Title",0);
                              lVar8 = this.languageDropDown;
                              if (!cVar4) {
                                if (lVar8 == null) throw; // [null/range check failed]
                                lVar8 = Component.get_gameObject(lVar8,0);
                                if (lVar8 == null) throw; // [null/range check failed]
                                GameObject.SetActive(lVar8,0,0);
                              }
                              else {
                                if (lVar8 == null) throw; // [null/range check failed]
                                lVar8 = Component.get_gameObject(lVar8,0);
                                if (lVar8 == null) throw; // [null/range check failed]
                                GameObject.SetActive(lVar8,1,0);
                                lVar8 = this.languageDropDown;
                                lVar2 = **(int64 **)(DAT_181d7c740 + 184);
                                uVar9 = LTLocalization.GetNowSystemLanguage(0);
                                if (lVar2 == null) throw; // [null/range check failed]
                                uVar9 = FUN_1817ff280(lVar2,uVar9,DAT_181d7d1b8);
                                if (lVar8 == null) throw; // [null/range check failed]
                                Dropdown.set_value(lVar8,uVar9,0);
                              }
                              lVar8 = this.fullScreen;
                              lVar2 = *(int64 *)(pStatics_e010 + 8);
                              if ((lVar2 != null) && (lVar2 = *(int64 *)(lVar2 + 16)) != null) {
                                iVar5 = PlayerPrefDictionary.GetInt(lVar2,"FullScreen",0);
                                if (lVar8 != null) {
                                  Toggle.set_isOn(lVar8,iVar5 == 1,0);
                                  lVar8 = this.skipTutorial;
                                  lVar2 = *(int64 *)(pStatics_e010 + 8);
                                  if ((lVar2 != null) && (lVar2 = *(int64 *)(lVar2 + 16)) != null) {
                                    iVar5 = PlayerPrefDictionary.GetInt(lVar2,"SkipTutorial",0);
                                    if (lVar8 != null) {
                                      Toggle.set_isOn(lVar8,iVar5 == 1,0);
                                      lVar8 = this.autoSave;
                                      lVar2 = *(int64 *)(pStatics_e010 + 8);
                                      if ((lVar2 != null) &&
                                         (lVar2 = *(int64 *)(lVar2 + 16)) != null) {
                                        uVar9 = PlayerPrefDictionary.GetInt(lVar2,"AutoSave",0);
                                        if (lVar8 != null) {
                                          Dropdown.set_value(lVar8,uVar9,0);
                                          if (*(char *)(pStatics_ef00 + 16) !=
                                              false) {
                                            if (this.settingMenu == null) throw; // [null/range check failed]
                                            lVar8 = GameObject.get_transform
                                                              (this.settingMenu,0);
                                            if (lVar8 == null) throw; // [null/range check failed]
                                            lVar8 = Transform.Find(lVar8,"SettingRoot",0);
                                            if (lVar8 == null) throw; // [null/range check failed]
                                            lVar8 = Transform.Find(lVar8,"AutoSaveDropdown",0);
                                            if (lVar8 == null) throw; // [null/range check failed]
                                            lVar8 = Component.get_gameObject(lVar8,0);
                                            if (lVar8 == null) throw; // [null/range check failed]
                                            GameObject.SetActive(lVar8,0,0);
                                          }
                                          lVar8 = this.fastTalk;
                                          lVar2 = *(int64 *)(pStatics_e010 + 8);
                                          if ((lVar2 != null) &&
                                             (lVar2 = *(int64 *)(lVar2 + 16)) != null) {
                                            iVar5 = PlayerPrefDictionary.GetInt(lVar2,"FastTalk",0);
                                            if (lVar8 != null) {
                                              Toggle.set_isOn(lVar8,iVar5 == 1,0);
                                              lVar8 = this.fightViewFollow;
                                              lVar2 = *(int64 *)
                                                       (pStatics_e010 + 8);
                                              if ((lVar2 != null) &&
                                                 (lVar2 = *(int64 *)(lVar2 + 16)) != null) {
                                                iVar5 = PlayerPrefDictionary.GetInt
                                                                  (lVar2,"FightViewFollow",0);
                                                if (lVar8 != null) {
                                                  Toggle.set_isOn(lVar8,iVar5 == 1,0);
                                                  lVar8 = this.fightScreenShake;
                                                  lVar2 = *(int64 *)
                                                           (pStatics_e010 + 8);
                                                  if ((lVar2 != null) &&
                                                     (lVar2 = *(int64 *)(lVar2 + 16)) != null) {
                                                    iVar5 = PlayerPrefDictionary.GetInt
                                                                      (lVar2,"FightScreenShake",0);
                                                    if (lVar8 != null) {
                                                      Toggle.set_isOn(lVar8,iVar5 == 1,0);
                                                      lVar8 = this.skipSpeGetItem;
                                                      lVar2 = *(int64 *)
                                                               (pStatics_e010 + 8);
                                                      if ((lVar2 != null) &&
                                                         (lVar2 = *(int64 *)(lVar2 + 16)) != null
                                                         ) {
                                                        iVar5 = PlayerPrefDictionary.GetInt
                                                                          (lVar2,"SkipSpeGetItem",0);
                                                        if (lVar8 != null) {
                                                          Toggle.set_isOn(lVar8,iVar5 == 1,0);
                                                          lVar8 = this.rightPopInfo;
                                                          lVar2 = *(int64 *)
                                                                   (pStatics_e010 +
                                                                   8);
                                                          if ((lVar2 != null) &&
                                                             (lVar2 = *(int64 *)(lVar2 + 16),
                                                             lVar2 != null)) {
                                                            iVar5 = PlayerPrefDictionary.GetInt
                                                                              (lVar2,"RightPopInfo",0);
                                                            if (lVar8 != null) {
                                                              Toggle.set_isOn(lVar8,iVar5 == 1,0);
                                                              lVar8 = this.evadeBalance;
                                                              lVar2 = *(int64 *)
                                                                       (*(int64 *)
                                                                         (DAT_181d4e010 + 184) + 8);
                                                              if ((lVar2 != null) &&
                                                                 (lVar2 = *(int64 *)(lVar2 + 16),
                                                                 lVar2 != null)) {
                                                                iVar5 = PlayerPrefDictionary.GetInt
                                                                                  (lVar2,"NoEvadeBalance",0);
                                                                if (lVar8 != null) {
                                                                  Toggle.set_isOn(lVar8,iVar5 == 0,0);
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
        }
    }

    // Token : 0x6002065
    // RVA   : 0x96A250   Offset: 0x968A50   Length: 0x2DD
    public void ShowSettingMenu()
    {
        long lVar1;
        ulong uVar5;
        ulong local_38;
        ulong uStack_30;
        byte[] local_28 = new byte[32];
        if (this.settingMenu != null) {
          GameObject.SetActive(this.settingMenu,1,0);
          if (this.settingMenu != null) {
            lVar1 = GameObject.get_transform(this.settingMenu,0);
            if (lVar1 != null) {
              lVar1 = Transform.Find(lVar1,"BlackBackground",0);
              if (lVar1 != null) {
                plVar2 = (int64 *)Component.GetComponent(lVar1,DAT_181d6bc40);
                if (this.settingMenu != null) {
                  lVar1 = GameObject.get_transform(this.settingMenu,0);
                  if (lVar1 != null) {
                    lVar1 = Transform.Find(lVar1,"BlackBackground",0);
                    if (lVar1 != null) {
                      plVar3 = (int64 *)Component.GetComponent(lVar1,DAT_181d6bc40);
                      if (plVar3 != (int64 *)0) {
                        puVar4 = (uint64 *)
                                 (**(code **)(*plVar3 + 0x298))
                                           (&local_38,plVar3,*(uint64 *)(*plVar3 + 0x2a0));
                        local_38 = *puVar4;
                        uStack_30 = puVar4[1];
                        puVar4 = (uint64 *)GlobalData.SetColorAlpha(local_28,&local_38,0,0);
                        if (plVar2 != (int64 *)0) {
                          local_38 = *puVar4;
                          uStack_30 = puVar4[1];
                          (**(code **)(*plVar2 + 0x2a8))
                                    (plVar2,&local_38,*(uint64 *)(*plVar2 + 0x2b0));
                          if (this.settingMenu != null) {
                            lVar1 = GameObject.get_transform(this.settingMenu,0);
                            if (lVar1 != null) {
                              lVar1 = Transform.Find(lVar1,"BlackBackground",0);
                              if (lVar1 != null) {
                                uVar5 = Component.GetComponent(lVar1,DAT_181d6bc40);
                                uVar5 = DOTweenModuleUI.DOFade(uVar5,0x3f000000,0x3e800000,0);
                                TweenSettingsExtensions.SetUpdate(uVar5,1,DAT_181d98958);
                                if (this.settingMenu != null) {
                                  lVar1 = GameObject.get_transform(this.settingMenu,0);
                                  if (lVar1 != null) {
                                    lVar1 = Transform.Find(lVar1,"SettingRoot",0);
                                    if (lVar1 != null) {
                                      local_38 = 0x3f80000000000000;
                                      uStack_30 = CONCAT44(uStack_30._4_4_,0x3f800000);
                                      Transform.set_localScale(lVar1,&local_38,0);
                                      if (this.settingMenu != null) {
                                        lVar1 = GameObject.get_transform(this.settingMenu,0)
                                        ;
                                        if (lVar1 != null) {
                                          uVar5 = Transform.Find(lVar1,"SettingRoot",0);
                                          uVar5 = ShortcutExtensions.DOScale
                                                            (uVar5,0x3f800000,0x3e800000,0);
                                          TweenSettingsExtensions.SetUpdate(uVar5,1,DAT_181d98af0);
                                          SettingMenuController.RefreshSettingState(this,0);
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

    // Token : 0x6002066
    // RVA   : 0x96A840   Offset: 0x969040   Length: 0x2B0
    public void UnshowSettingMenu()
    {
        long lVar1;
        ulong uVar2;
        ulong uVar3;
        uint local_18;
        uint local_14;
        uint local_10;
        if (this.settingMenu != null) {
          lVar1 = GameObject.get_transform(this.settingMenu,0);
          if (lVar1 != null) {
            lVar1 = Transform.Find(lVar1,"BlackBackground",0);
            if (lVar1 != null) {
              uVar2 = Component.GetComponent(lVar1,DAT_181d6bc40);
              uVar2 = DOTweenModuleUI.DOFade(uVar2,0,0x3e4ccccd,0);
              TweenSettingsExtensions.SetUpdate(uVar2,1,DAT_181d98958);
              if (this.settingMenu != null) {
                lVar1 = GameObject.get_transform(this.settingMenu,0);
                if (lVar1 != null) {
                  uVar2 = Transform.Find(lVar1,"SettingRoot",0);
                  local_18 = 0;
                  local_14 = 0x3f800000;
                  local_10 = 0x3f800000;
                  uVar2 = ShortcutExtensions.DOScale(uVar2,&local_18,0x3e4ccccd,0);
                  uVar2 = TweenSettingsExtensions.SetUpdate(uVar2,1,DAT_181d98af0);
                  uVar3 = new OnTooltipCB(this,DAT_181d7eb40,0);
                  TweenSettingsExtensions.OnComplete(uVar2,uVar3,DAT_181d96ee8);
                  lVar1 = *(int64 *)(*(int64 *)(DAT_181d4e010 + 184) + 32);
                  if (lVar1 != null) {
                    GameDataController.SavePlayerprefData(lVar1,0);
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

    // Token : 0x6002067
    // RVA   : 0x96AB00   Offset: 0x969300   Length: 0x17C
    public void VolumeSliderChanged()
    {
        var pStatics = *(int64*)(DAT_181d4e010 + 184);
        long lVar1;
        ulong uVar3;
        uint uVar4;
        lVar1 = *(int64 *)(pStatics + 8);
        if (lVar1 != null) {
          lVar1 = *(int64 *)(lVar1 + 16);
          plVar2 = this.volumeSlider;
          if (plVar2 != (int64 *)0) {
            uVar4 = (**(code **)(*plVar2 + 0x418))(plVar2,*(uint64 *)(*plVar2 + 0x420));
            if (lVar1 != null) {
              PlayerPrefDictionary.SetKey(lVar1,"Volume",uVar4,0);
              plVar2 = this.volumeSlider;
              if (plVar2 != (int64 *)0) {
                uVar4 = (**(code **)(*plVar2 + 0x418))(plVar2,*(uint64 *)(*plVar2 + 0x420));
                AudioListener.set_volume(uVar4,0);
                lVar1 = *(int64 *)(pStatics + 32);
                if (lVar1 != null) {
                  uVar3 = *(uint64 *)(lVar1 + 0x1f0);
                  NGUITools.PlaySound(uVar3,0x3e4ccccd,0);
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x6002068
    // RVA   : 0x968D90   Offset: 0x967590   Length: 0x2C9
    public void BgmVolumeSliderChanged()
    {
        var pStatics_a9a8 = *(int64*)(DAT_181d8a9a8 + 184);
        var pStatics_e010 = *(int64*)(DAT_181d4e010 + 184);
        long lVar1;
        ulong uVar3;
        bool cVar4;
        uint uVar5;
        lVar1 = *(int64 *)(pStatics_e010 + 8);
        if (lVar1 != null) {
          lVar1 = *(int64 *)(lVar1 + 16);
          plVar2 = this.bgmVolumeSlider;
          if (plVar2 != (int64 *)0) {
            uVar5 = (**(code **)(*plVar2 + 0x418))(plVar2,*(uint64 *)(*plVar2 + 0x420));
            if (lVar1 != null) {
              PlayerPrefDictionary.SetKey(lVar1,"BgmVolume",uVar5,0);
              uVar3 = *(uint64 *)(pStatics_a9a8 + 8);
              cVar4 = Object.op_Inequality(uVar3,0,0);
              if (cVar4) {
                lVar1 = *(int64 *)(pStatics_a9a8 + 8);
                if (lVar1 == null) throw; // [null/range check failed]
                BGMController.RefreshNowBgmVolumn(lVar1,0);
              }
              lVar1 = *(int64 *)(pStatics_e010 + 32);
              if (lVar1 != null) {
                uVar3 = *(uint64 *)(lVar1 + 0x1f0);
                NGUITools.PlaySound(uVar3,0x3e4ccccd,0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x6002069
    // RVA   : 0x96A6A0   Offset: 0x968EA0   Length: 0x195
    public void SoundEffectVolumeSliderChanged()
    {
        var pStatics = *(int64*)(DAT_181d4e010 + 184);
        long lVar2;
        ulong uVar3;
        uint uVar4;
        plVar1 = this.soundEffectVolumeSlider;
        if (plVar1 != (int64 *)0) {
          uVar4 = (**(code **)(*plVar1 + 0x418))(plVar1,*(uint64 *)(*plVar1 + 0x420));
          *(uint32 *)(pStatics + 16) = uVar4;
          lVar2 = *(int64 *)(pStatics + 8);
          if (lVar2 != null) {
            plVar1 = this.soundEffectVolumeSlider;
            lVar2 = *(int64 *)(lVar2 + 16);
            if (plVar1 != (int64 *)0) {
              uVar4 = (**(code **)(*plVar1 + 0x418))(plVar1,*(uint64 *)(*plVar1 + 0x420));
              if (lVar2 != null) {
                PlayerPrefDictionary.SetKey(lVar2,"SoundEffectVolume",uVar4,0);
                lVar2 = *(int64 *)(pStatics + 32);
                if (lVar2 != null) {
                  uVar3 = *(uint64 *)(lVar2 + 0x1f0);
                  NGUITools.PlaySound(uVar3,0x3e4ccccd,0);
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x600206A
    // RVA   : 0x96A530   Offset: 0x968D30   Length: 0x162
    public void SolutionDropDownValueChange()
    {
        uint uVar1;
        byte uVar2;
        uint uVar3;
        uint uVar4;
        long lVar5;
        long lVar6;
        ulong uVar7;
        if (this.solutionDropDown != null) {
          uVar1 = *(uint32 *)(this.solutionDropDown + 0x120);
          lVar6 = *(int64 *)(*(int64 *)(DAT_181d4ef00 + 184) + 176);
          if (lVar6 != null) {
            if (*(uint32 *)(lVar6 + 24) <= uVar1) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar6 = lVar6[uVar1];
            lVar5 = FUN_1800d60b0(DAT_181d7c118,1);
            if (lVar5 != null) {
              if (*(int *)(lVar5 + 24) == 0) {
                uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar7,0);
              }
              *(uint16 *)(lVar5 + 32) = 120;
              if (lVar6 != null) {
                lVar6 = String.Split(lVar6,lVar5,0);
                if (lVar6 != null) {
                  if (*(int *)(lVar6 + 24) == 0) {
                    uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar7,0);
                  }
                  uVar3 = Int32.Parse(*(uint64 *)(lVar6 + 32),0);
                  if (1 < *(uint32 *)(lVar6 + 24)) {
                    uVar4 = Int32.Parse(*(uint64 *)(lVar6 + 40),0);
                    uVar2 = Screen.get_fullScreen(0);
                    GlobalData.SetResolution(uVar3,uVar4,uVar2,0);
                    return;
                  }
                  uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar7,0);
                }
              }
            }
          }
        }
    }

    // Token : 0x600206B
    // RVA   : 0x969DE0   Offset: 0x9685E0   Length: 0x151
    public void SetResolution(int resulotionID)
    {
        byte uVar1;
        uint uVar2;
        uint uVar3;
        long lVar4;
        long lVar5;
        ulong uVar6;
        lVar5 = *(int64 *)(*(int64 *)(DAT_181d4ef00 + 184) + 176);
        if (lVar5 != null) {
          if (*(uint32 *)(lVar5 + 24) <= resulotionID) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar5 = lVar5[resulotionID];
          lVar4 = FUN_1800d60b0(DAT_181d7c118,1);
          if (lVar4 != null) {
            if (*(int *)(lVar4 + 24) == 0) {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar6,0);
            }
            *(uint16 *)(lVar4 + 32) = 120;
            if (lVar5 != null) {
              lVar5 = String.Split(lVar5,lVar4,0);
              if (lVar5 != null) {
                if (*(int *)(lVar5 + 24) == 0) {
                  uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar6,0);
                }
                uVar2 = Int32.Parse(*(uint64 *)(lVar5 + 32),0);
                if (1 < *(uint32 *)(lVar5 + 24)) {
                  uVar3 = Int32.Parse(*(uint64 *)(lVar5 + 40),0);
                  uVar1 = Screen.get_fullScreen(0);
                  GlobalData.SetResolution(uVar2,uVar3,uVar1,0);
                  return;
                }
                uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar6,0);
              }
            }
          }
        }
    }

    // Token : 0x600206C
    // RVA   : 0x9690D0   Offset: 0x9678D0   Length: 0xA6
    public void LanguageDropDownValueChange()
    {
        uint uVar1;
        long lVar2;
        lVar2 = **(int64 **)(DAT_181d7c740 + 184);
        if ((this.languageDropDown != null) && (lVar2 != null)) {
          uVar1 = *(uint32 *)(this.languageDropDown + 0x120);
          if (*(uint32 *)(lVar2 + 24) <= uVar1) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          LTLocalization.ManualSetLanguage
                    (lVar2[uVar1],0);
          return;
        }
    }

    // Token : 0x600206D
    // RVA   : 0x969060   Offset: 0x967860   Length: 0x67
    public void FullScreenButtonClicked()
    {
        byte uVar1;
        if (this.fullScreen != null) {
          uVar1 = *(uint8 *)(this.fullScreen + 0x118);
          GlobalData.SetFullScreen(uVar1,0);
          return;
        }
    }

    // Token : 0x600206E
    // RVA   : 0x96A0A0   Offset: 0x9688A0   Length: 0x1A6
    public void SetSkipTutorial()
    {
        var pStatics_8ad8 = *(int64*)(DAT_181d88ad8 + 184);
        var pStatics_e010 = *(int64*)(DAT_181d4e010 + 184);
        long lVar1;
        ulong uVar2;
        bool cVar3;
        int iVar4;
        lVar1 = *(int64 *)(pStatics_e010 + 8);
        if (lVar1 != null) {
          lVar1 = *(int64 *)(lVar1 + 16);
          if ((this.skipTutorial != null) && (lVar1 != null)) {
            PlayerPrefDictionary.SetKey
                      (lVar1,"SkipTutorial",*(char *)(this.skipTutorial + 0x118) != false,0);
            uVar2 = **(uint64 **)(DAT_181d88ad8 + 184);
            cVar3 = Object.op_Inequality(uVar2,0,0);
            if (cVar3) {
              lVar1 = *(int64 *)(pStatics_e010 + 8);
              if ((lVar1 == null) || (lVar1 = *(int64 *)(lVar1 + 16)) == null) throw; // [null/range check failed]
              iVar4 = PlayerPrefDictionary.GetInt(lVar1,"SkipTutorial",0);
              if (iVar4 == 1) {
                if (*pStatics_8ad8 == 0) throw; // [null/range check failed]
                *(uint8 *)(*pStatics_8ad8 + 89) = 0;
              }
            }
            return;
          }
        }
    }

    // Token : 0x600206F
    // RVA   : 0x969A80   Offset: 0x968280   Length: 0x9B
    public void SetAutoSave()
    {
        long lVar1;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d4e010 + 184) + 8);
        if (((lVar1 != null) && (this.autoSave != null)) &&
           (lVar1 = *(int64 *)(lVar1 + 16)) != null) {
          PlayerPrefDictionary.SetKey
                    (lVar1,"AutoSave",*(uint32 *)(this.autoSave + 0x120),0);
          return;
        }
    }

    // Token : 0x6002070
    // RVA   : 0x969B20   Offset: 0x968320   Length: 0xA2
    public void SetFastTalk()
    {
        long lVar1;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d4e010 + 184) + 8);
        if (lVar1 != null) {
          lVar1 = *(int64 *)(lVar1 + 16);
          if ((this.fastTalk != null) && (lVar1 != null)) {
            PlayerPrefDictionary.SetKey
                      (lVar1,"FastTalk",*(char *)(this.fastTalk + 0x118) != false,0);
            return;
          }
        }
    }

    // Token : 0x6002071
    // RVA   : 0x969C80   Offset: 0x968480   Length: 0xA2
    public void SetFightViewFollow()
    {
        long lVar1;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d4e010 + 184) + 8);
        if (lVar1 != null) {
          lVar1 = *(int64 *)(lVar1 + 16);
          if ((this.fightViewFollow != null) && (lVar1 != null)) {
            PlayerPrefDictionary.SetKey
                      (lVar1,"FightViewFollow",*(char *)(this.fightViewFollow + 0x118) != false,0);
            return;
          }
        }
    }

    // Token : 0x6002072
    // RVA   : 0x969BD0   Offset: 0x9683D0   Length: 0xA2
    public void SetFightScreenShake()
    {
        long lVar1;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d4e010 + 184) + 8);
        if (lVar1 != null) {
          lVar1 = *(int64 *)(lVar1 + 16);
          if ((this.fightScreenShake != null) && (lVar1 != null)) {
            PlayerPrefDictionary.SetKey
                      (lVar1,"FightScreenShake",*(char *)(this.fightScreenShake + 0x118) != false,0);
            return;
          }
        }
    }

    // Token : 0x6002073
    // RVA   : 0x969FF0   Offset: 0x9687F0   Length: 0xA2
    public void SetSkipSpeGetItem()
    {
        long lVar1;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d4e010 + 184) + 8);
        if (lVar1 != null) {
          lVar1 = *(int64 *)(lVar1 + 16);
          if ((this.skipSpeGetItem != null) && (lVar1 != null)) {
            PlayerPrefDictionary.SetKey
                      (lVar1,"SkipSpeGetItem",*(char *)(this.skipSpeGetItem + 0x118) != false,0);
            return;
          }
        }
    }

    // Token : 0x6002074
    // RVA   : 0x969F40   Offset: 0x968740   Length: 0xA5
    public void SetRightPopInfo()
    {
        long lVar1;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d4e010 + 184) + 8);
        if (lVar1 != null) {
          lVar1 = *(int64 *)(lVar1 + 16);
          if ((this.rightPopInfo != null) && (lVar1 != null)) {
            PlayerPrefDictionary.SetKey
                      (lVar1,"RightPopInfo",*(char *)(this.rightPopInfo + 0x118) != false,0);
            return;
          }
        }
    }

    // Token : 0x6002075
    // RVA   : 0x969D30   Offset: 0x968530   Length: 0xA5
    public void SetNoEvadeBalance()
    {
        long lVar1;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d4e010 + 184) + 8);
        if (lVar1 != null) {
          lVar1 = *(int64 *)(lVar1 + 16);
          if ((this.evadeBalance != null) && (lVar1 != null)) {
            PlayerPrefDictionary.SetKey
                      (lVar1,"NoEvadeBalance",*(char *)(this.evadeBalance + 0x118) == false,0);
            return;
          }
        }
    }

    // Token : 0x6002076
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

    // Token : 0x6002077
    // RVA   : 0x96AC80   Offset: 0x969480   Length: 0xB4
    private static void /*cctor*/()
    {
        long lVar2;
        lVar2 = il2cpp_internal(DAT_181d72d30);
        FUN_180f58a90(lVar2,DAT_181d7d0c0);
        if (lVar2 != null) {
          FUN_181814fa0(lVar2,40,DAT_181d7d140);
          FUN_181814fa0(lVar2,41,DAT_181d7d140);
          plVar1 = *(int64 **)(DAT_181d7c740 + 184);
          *plVar1 = lVar2;
          il2cpp_internal(plVar1,lVar2);
          return;
        }
    }

    // Token : 0x6002078
    // RVA   : 0x790570   Offset: 0x78ED70   Length: 0x20
    private void <UnshowSettingMenu>b__23_0()
    {
        if (this.settingMenu != null) {
          GameObject.SetActive(this.settingMenu,0,0);
          return;
        }
    }

}
