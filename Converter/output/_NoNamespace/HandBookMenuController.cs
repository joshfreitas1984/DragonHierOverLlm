// ============================================================
// Type  : HandBookMenuController
// Token : 0x20002BC
// ============================================================

public class HandBookMenuController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40016BE
    public GameObject handBookMenu;

    // Token: 0x40016BF
    public GameObject skillHandBookForceTabPrefab;

    // Token: 0x40016C0
    public GameObject unlockSkillHandBookPrefab;

    // Token: 0x40016C1
    public GameObject skillHandBookForceTabList;

    // Token: 0x40016C2
    public GameObject skillHandBookSkillIconList;

    // Token: 0x40016C3
    public GameObject heroHandBookIconPrefab;

    // Token: 0x40016C4
    public GameObject heroHandBookIconList;

    // Token: 0x40016C5
    private bool inited;

    // Token: 0x40016C6
    private GameObject temp;

    // Token: 0x40016C7
    private static HandBookMenuController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001763
    // RVA   : 0x875E10   Offset: 0x875210   Length: 0x36
    public static HandBookMenuController get_Instance()
    {
        return **(uint64 **)(DAT_181d757d0 + 184);
    }

    // Token : 0x6001764
    // RVA   : 0x873FC0   Offset: 0x8733C0   Length: 0x99
    private void Awake()
    {
        ulong uVar1;
        bool cVar3;
        uVar1 = **(uint64 **)(DAT_181d757d0 + 184);
        cVar3 = Object.op_Equality(uVar1,0,0);
        if (cVar3) {
          puVar2 = *(uint64 **)(DAT_181d757d0 + 184);
          *puVar2 = this;
          il2cpp_internal(puVar2,this);
        }
    }

    // Token : 0x6001765
    // RVA   : 0x875300   Offset: 0x874700   Length: 0x7E3
    public void ShowHandBookMenu()
    {
        long lVar1;
        bool cVar3;
        int iVar4;
        long lVar5;
        ulong uVar9;
        ulong local_88;
        ulong uStack_80;
        ulong local_78;
        ulong uStack_70;
        long local_68;
        uint local_60;
        uint32 uStack_5c;
        uint32 uStack_58;
        uint32 uStack_54;
        int64 local_50;
        uint32 local_48;
        uint32 uStack_44;
        uint32 uStack_40;
        uint32 uStack_3c;
        int64 local_38;
        local_78 = 0;
        uStack_70 = 0;
        local_68 = 0;
        if (this.handBookMenu != null) {
          GameObject.SetActive(this.handBookMenu,1,0);
          if (((this.handBookMenu != null) &&
              (lVar5 = GameObject.get_transform(this.handBookMenu,0)) != null) &&
             (lVar5 = Transform.Find(lVar5,"BlackBackground",0)) != null) {
            plVar6 = (int64 *)Component.GetComponent(lVar5,DAT_181d94478);
            if (((this.handBookMenu != null) &&
                (lVar5 = GameObject.get_transform(this.handBookMenu,0)) != null) &&
               ((lVar5 = Transform.Find(lVar5,"BlackBackground",0), lVar5 != null &&
                (plVar7 = (int64 *)Component.GetComponent(lVar5,DAT_181d94478),
                plVar7 != (int64 *)0)))) {
              puVar8 = (uint64 *)
                       (**(code **)(*plVar7 + 0x298))(&local_88,plVar7,*(uint64 *)(*plVar7 + 0x2a0));
              local_88 = *puVar8;
              uStack_80 = puVar8[1];
              puVar8 = (uint64 *)GlobalData.SetColorAlpha(&local_60,&local_88,0,0);
              if (plVar6 != (int64 *)0) {
                local_88 = *puVar8;
                uStack_80 = puVar8[1];
                (**(code **)(*plVar6 + 0x2a8))(plVar6,&local_88,*(uint64 *)(*plVar6 + 0x2b0));
                if (((this.handBookMenu != null) &&
                    (lVar5 = GameObject.get_transform(this.handBookMenu,0)) != null) &&
                   (lVar5 = Transform.Find(lVar5,"BlackBackground",0)) != null) {
                  uVar9 = Component.GetComponent(lVar5,DAT_181d94478);
                  uVar9 = DOTweenModuleUI.DOFade(uVar9,0x3f000000,0x3e800000,0);
                  TweenSettingsExtensions.SetUpdate(uVar9,1,DAT_181dc1dc8);
                  if (((this.handBookMenu != null) &&
                      (lVar5 = GameObject.get_transform(this.handBookMenu,0)) != null) &&
                     (lVar5 = Transform.Find(lVar5,"HandBookRoot",0)) != null) {
                    local_88 = 0x3f80000000000000;
                    uStack_80 = CONCAT44(uStack_80._4_4_,0x3f800000);
                    Transform.set_localScale(lVar5,&local_88,0);
                    if ((this.handBookMenu != null) &&
                       (lVar5 = GameObject.get_transform(this.handBookMenu,0)) != null) {
                      uVar9 = Transform.Find(lVar5,"HandBookRoot",0);
                      uVar9 = ShortcutExtensions.DOScale(uVar9,0x3f800000,0x3e800000,0);
                      TweenSettingsExtensions.SetUpdate(uVar9,1,DAT_181dc1f60);
                      if (!this.inited) {
                        HandBookMenuController.Init(this,0);
                      }
                      bVar2 = true;
                      lVar5 = GameController.lockObj;
                      if (((lVar5 != null) && (lVar5 = *(int64 *)(lVar5 + 0x150)) != null) &&
                         (lVar5 = FUN_1808ae5b0(lVar5,DAT_181dba218)) != null) {
                        ValueCollection.GetEnumerator(&local_60,lVar5,DAT_181d7e788);
                        local_48 = local_60;
                        uStack_44 = uStack_5c;
                        uStack_40 = uStack_58;
                        uStack_3c = uStack_54;
                        local_38 = local_50;
                        do {
                          do {
                            cVar3 = FUN_1811c4590(&local_48,DAT_181d98770);
                            lVar5 = local_38;
                            if (!cVar3) {
                              ZhSegment.Initialize(&local_48,DAT_181d986f0);
                              goto LAB_18087587c;
                            }
                            if (local_38 == 0) {
                          // WARNING: Subroutine does not return
                              FUN_1800d6620();
                            }
                          } while (*(char *)(local_38 + 96) != false);
                          lVar1 = GameController.difficultyExtraPoint;
                          if (lVar1 == null) {
                          // WARNING: Subroutine does not return
                            FUN_1800d6620();
                          }
                          lVar1 = *(int64 *)(lVar1 + 16);
                          uVar9 = Int32.ToString(lVar5 + 88,0);
                          uVar9 = String.Concat("HandBookHero_",uVar9,0);
                          if (lVar1 == null) {
                          // WARNING: Subroutine does not return
                            FUN_1800d6620();
                          }
                          iVar4 = PlayerPrefDictionary.GetInt(lVar1,uVar9);
                        } while (iVar4 != 0);
                        bVar2 = false;
                        ZhSegment.Initialize(&local_48,DAT_181d986f0);
        LAB_18087587c:
                        if (bVar2) {
                          lVar5 = FUN_18046c100(0);
                          if (lVar5 == null) throw; // [null/range check failed]
                          GameDataController.ChangeAchStats(lVar5,47,0x3f800000);
                        }
                        lVar5 = FUN_18046c100(0);
                        if (((lVar5 != null) && (*(int64 *)(lVar5 + 0x128) != 0)) &&
                           (lVar5 = FUN_1808ae5b0(*(int64 *)(lVar5 + 0x128),DAT_181dbc480)) != null
                           ) {
                          ValueCollection.GetEnumerator(&local_60,lVar5,DAT_181d7f270);
                          local_78 = CONCAT44(uStack_5c,local_60);
                          uStack_70 = CONCAT44(uStack_54,uStack_58);
                          local_68 = local_50;
                          while (cVar3 = FUN_1811c4590(&local_78,DAT_181d9a070), lVar5 = local_68,
                                cVar3) {
                            lVar1 = GameController.difficultyExtraPoint;
                            if (lVar1 == null) {
                          // WARNING: Subroutine does not return
                              FUN_1800d6620();
                            }
                            lVar1 = *(int64 *)(lVar1 + 16);
                            if (lVar5 == null) {
                          // WARNING: Subroutine does not return
                              FUN_1800d6620();
                            }
                            uVar9 = Int32.ToString(lVar5 + 20,0);
                            uVar9 = String.Concat("HandBookSkill_",uVar9,0);
                            if (lVar1 == null) {
                          // WARNING: Subroutine does not return
                              FUN_1800d6620();
                            }
                            iVar4 = PlayerPrefDictionary.GetInt(lVar1,uVar9);
                            if (iVar4 == 0) {
                              ZhSegment.Initialize(&local_78,DAT_181d99ff0);
                              return;
                            }
                          }
                          ZhSegment.Initialize(&local_78,DAT_181d99ff0);
                          lVar5 = FUN_18046c100(0);
                          if (lVar5 != null) {
                            GameDataController.ChangeAchStats(lVar5,48,0x3f800000);
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

    // Token : 0x6001766
    // RVA   : 0x875AF0   Offset: 0x874EF0   Length: 0x31A
    public void UnshowHandBookMenu()
    {
        long lVar1;
        ulong uVar2;
        ulong uVar3;
        uint local_18;
        uint local_14;
        uint local_10;
        uVar2 = this.skillHandBookSkillIconList;
        GlobalData.DeleteAllChild(uVar2,0);
        GlobalData.DeleteAllChild(this.heroHandBookIconList,0);
        if (this.handBookMenu != null) {
          lVar1 = GameObject.get_transform(this.handBookMenu,0);
          if (lVar1 != null) {
            lVar1 = Transform.Find(lVar1,"HandBookRoot",0);
            if (lVar1 != null) {
              lVar1 = Transform.Find(lVar1,"Tabs",0);
              if (lVar1 != null) {
                lVar1 = Transform.Find(lVar1,"0",0);
                if (lVar1 != null) {
                  lVar1 = Component.GetComponent(lVar1,DAT_181d962f8);
                  if (lVar1 != null) {
                    Toggle.set_isOn(lVar1,1,0);
                    if (this.handBookMenu != null) {
                      lVar1 = GameObject.get_transform(this.handBookMenu,0);
                      if (lVar1 != null) {
                        lVar1 = Transform.Find(lVar1,"BlackBackground",0);
                        if (lVar1 != null) {
                          uVar2 = Component.GetComponent(lVar1,DAT_181d94478);
                          uVar2 = DOTweenModuleUI.DOFade(uVar2,0,0x3e4ccccd,0);
                          TweenSettingsExtensions.SetUpdate(uVar2,1,DAT_181dc1dc8);
                          if (this.handBookMenu != null) {
                            lVar1 = GameObject.get_transform(this.handBookMenu,0);
                            if (lVar1 != null) {
                              uVar2 = Transform.Find(lVar1,"HandBookRoot",0);
                              local_18 = 0;
                              local_14 = 0x3f800000;
                              local_10 = 0x3f800000;
                              uVar2 = ShortcutExtensions.DOScale(uVar2,&local_18,0x3e4ccccd,0);
                              uVar2 = TweenSettingsExtensions.SetUpdate(uVar2,1,DAT_181dc1f60);
                              uVar3 = new OnTooltipCB(this,DAT_181d78348,0);
                              TweenSettingsExtensions.OnComplete(uVar2,uVar3,DAT_181dc0380);
                              plVar4 = (int64 *)Resources.Load("Sound/SoundEffect/OpenBook",0);
                              plVar5 = (int64 *)0;
                              if ((plVar4 != (int64 *)0) && (*plVar4 == DAT_181daf360)) {
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
          }
        }
    }

    // Token : 0x6001767
    // RVA   : 0x874060   Offset: 0x873460   Length: 0x77B
    public void Init()
    {
        bool cVar1;
        ulong uVar2;
        long lVar3;
        long lVar6;
        ulong uVar7;
        uint local_58;
        uint uStack_54;
        uint uStack_50;
        uint32 uStack_4c;
        uint32 local_48;
        uint32 uStack_44;
        uint32 uStack_40;
        uint32 uStack_3c;
        int64 local_38;
        uint32 local_30;
        uint32 uStack_2c;
        uint32 uStack_28;
        uint32 uStack_24;
        int64 local_20;
        this.inited = 1;
        uVar2 = this.skillHandBookForceTabList;
        uVar7 = this.skillHandBookForceTabPrefab;
        uVar2 = GlobalData.AddChild(uVar2,uVar7,0);
        this.temp = uVar2;
        if (this.temp != null) {
          Object.set_name(this.temp,"-1",0);
          if (this.temp != null) {
            lVar3 = GameObject.GetComponent(this.temp,DAT_181d73778);
            if (lVar3 != null) {
              *(uint32 *)(lVar3 + 24) = 0xffffffff;
              if (this.temp != null) {
                lVar3 = GameObject.get_transform(this.temp,0);
                if (lVar3 != null) {
                  lVar3 = Transform.Find(lVar3,"Name",0);
                  if (lVar3 != null) {
                    uVar2 = Component.GetComponent(lVar3,DAT_181d96178);
                    LTLocalization.SetText(uVar2,"江湖",0);
                    if (this.temp != null) {
                      lVar3 = GameObject.get_transform(this.temp,0);
                      if (lVar3 != null) {
                        lVar3 = Transform.Find(lVar3,"Icon",0);
                        if (lVar3 != null) {
                          plVar4 = (int64 *)Component.GetComponent(lVar3,DAT_181d94478);
                          puVar5 = (uint32 *)FUN_180d995f0(&local_58,0);
                          if (plVar4 != (int64 *)0) {
                            local_58 = *puVar5;
                            uStack_54 = puVar5[1];
                            uStack_50 = puVar5[2];
                            uStack_4c = puVar5[3];
                            (**(code **)(*plVar4 + 0x2a8))
                                      (plVar4,&local_58,*(uint64 *)(*plVar4 + 0x2b0));
                            lVar3 = *(int64 *)(*(int64 *)(DAT_181d72d50 + 184) + 32);
                            if ((lVar3 != null) && (lVar3 = *(int64 *)(lVar3 + 208)) != null) {
                              lVar3 = FUN_1808ae5b0(lVar3,DAT_181db9800);
                              if (lVar3 != null) {
                                ValueCollection.GetEnumerator(&local_48,lVar3,DAT_181d7e688);
                                local_30 = local_48;
                                uStack_2c = uStack_44;
                                uStack_28 = uStack_40;
                                uStack_24 = uStack_3c;
                                local_20 = local_38;
                                while( true ) {
                                  do {
                                    do {
                                      do {
                                        cVar1 = FUN_1811c4590(&local_30,DAT_181d98170);
                                        lVar3 = local_20;
                                        if (!cVar1) {
                                          ZhSegment.Initialize(&local_30,DAT_181d980f0);
                                          return;
                                        }
                                        if (local_20 == 0) {
                          // WARNING: Subroutine does not return
                                          FUN_1800d6620();
                                        }
                                      } while (*(char *)(local_20 + 36) == false);
                                      uVar2 = this.skillHandBookForceTabList;
                                      uVar7 = this.skillHandBookForceTabPrefab;
                                      uVar2 = GlobalData.AddChild(uVar2,uVar7,0);
                                      this.temp = uVar2;
                                      lVar6 = this.temp;
                                      uVar2 = Int32.ToString(lVar3 + 16,"00");
                                      if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                                        FUN_1800d6620();
                                      }
                                      Object.set_name(lVar6,uVar2);
                                      if (this.temp == null) {
                          // WARNING: Subroutine does not return
                                        FUN_1800d6620();
                                      }
                                      lVar6 = GameObject.GetComponent
                                                        (this.temp,DAT_181d73778);
                                      if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                                        FUN_1800d6620();
                                      }
                                      *(uint32 *)(lVar6 + 24) = *(uint32 *)(lVar3 + 16);
                                      if (this.temp == null) {
                          // WARNING: Subroutine does not return
                                        FUN_1800d6620();
                                      }
                                      lVar6 = GameObject.get_transform(this.temp,0);
                                      if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                                        FUN_1800d6620();
                                      }
                                      lVar6 = Transform.Find(lVar6,"Name");
                                      if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                                        FUN_1800d6620();
                                      }
                                      uVar2 = Component.GetComponent(lVar6,DAT_181d96178);
                                      uVar7 = ForceData.GetForceName(lVar3,1);
                                      LTLocalization.SetText(uVar2,uVar7);
                                      if (this.temp == null) {
                          // WARNING: Subroutine does not return
                                        FUN_1800d6620();
                                      }
                                      lVar6 = GameObject.get_transform(this.temp,0);
                                      if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                                        FUN_1800d6620();
                                      }
                                      lVar6 = Transform.Find(lVar6,"Icon");
                                      if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                                        FUN_1800d6620();
                                      }
                                      lVar6 = Component.GetComponent(lVar6,DAT_181d94478);
                                      uVar2 = ForceData.GetForceIcon(lVar3,0);
                                      if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                                        FUN_1800d6620();
                                      }
                                      Image.set_sprite(lVar6,uVar2);
                                    } while (PlotController.fightSkillIndexCache != 1);
                                    lVar6 = PlotController.LeftFaceHideOffset;
                                    if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                                      FUN_1800d6620();
                                    }
                                    cVar1 = FUN_18182a9b0(lVar6,*(uint32 *)(lVar3 + 16));
                                  } while (cVar1);
                                  if (this.temp == null) {
                          // WARNING: Subroutine does not return
                                    FUN_1800d6620();
                                  }
                                  lVar3 = GameObject.GetComponent
                                                    (this.temp,DAT_181dc7c18);
                                  if (lVar3 == null) {
                          // WARNING: Subroutine does not return
                                    FUN_1800d6620();
                                  }
                                  Selectable.set_interactable(lVar3,0,0);
                                  if (this.temp == null) {
                          // WARNING: Subroutine does not return
                                    FUN_1800d6620();
                                  }
                                  lVar3 = GameObject.get_transform(this.temp,0);
                                  if (lVar3 == null) {
                          // WARNING: Subroutine does not return
                                    FUN_1800d6620();
                                  }
                                  lVar3 = Transform.Find(lVar3,"Name",0);
                                  if (lVar3 == null) {
                          // WARNING: Subroutine does not return
                                    FUN_1800d6620();
                                  }
                                  uVar2 = Component.GetComponent(lVar3,DAT_181d96178);
                                  LTLocalization.SetText(uVar2,"???",0);
                                  if (this.temp == null) {
                          // WARNING: Subroutine does not return
                                    FUN_1800d6620();
                                  }
                                  lVar3 = GameObject.get_transform(this.temp,0);
                                  if (lVar3 == null) {
                          // WARNING: Subroutine does not return
                                    FUN_1800d6620();
                                  }
                                  lVar3 = Transform.Find(lVar3,"Icon",0);
                                  if (lVar3 == null) break;
                                  plVar4 = (int64 *)Component.GetComponent(lVar3,DAT_181d94478);
                                  puVar5 = (uint32 *)Color.get_black(&local_48,0);
                                  if (plVar4 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                                    FUN_1800d6620();
                                  }
                                  local_58 = *puVar5;
                                  uStack_54 = puVar5[1];
                                  uStack_50 = puVar5[2];
                                  uStack_4c = puVar5[3];
                                  (**(code **)(*plVar4 + 0x2a8))(plVar4,&local_58);
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

    // Token : 0x6001768
    // RVA   : 0x874FC0   Offset: 0x8743C0   Length: 0x338
    public void ShowHandBookHero()
    {
        ulong uVar1;
        bool cVar2;
        int iVar3;
        long lVar4;
        ulong uVar5;
        long lVar6;
        uint local_40;
        uint32 uStack_3c;
        uint32 uStack_38;
        uint32 uStack_34;
        int64 local_30;
        uint32 local_28;
        uint32 uStack_24;
        uint32 uStack_20;
        uint32 uStack_1c;
        int64 local_18;
        if ((((this.handBookMenu != null) &&
             (lVar4 = GameObject.get_transform(this.handBookMenu,0)) != null) &&
            (lVar4 = Transform.Find(lVar4,"HandBookRoot",0)) != null) &&
           (((lVar4 = Transform.Find(lVar4,"Tabs",0), lVar4 != null &&
             (lVar4 = Transform.Find(lVar4,"1",0)) != null) &&
            (lVar4 = Component.GetComponent(lVar4,DAT_181d962f8)) != null))) {
          if (*(char *)(lVar4 + 0x118) == false) {
            return;
          }
          if ((this.heroHandBookIconList != null) &&
             (lVar4 = GameObject.get_transform(this.heroHandBookIconList,0)) != null) {
            iVar3 = Transform.get_childCount(lVar4,0);
            if (iVar3 != 0) {
              return;
            }
            lVar4 = FUN_18046c100(0);
            if (((lVar4 != null) && (*(int64 *)(lVar4 + 0x150) != 0)) &&
               (lVar4 = FUN_1808ae5b0(*(int64 *)(lVar4 + 0x150),DAT_181dba218)) != null) {
              ValueCollection.GetEnumerator(&local_28,lVar4,DAT_181d7e788);
              local_40 = local_28;
              uStack_3c = uStack_24;
              uStack_38 = uStack_20;
              uStack_34 = uStack_1c;
              local_30 = local_18;
              while( true ) {
                do {
                  cVar2 = FUN_1811c4590(&local_40,DAT_181d98770);
                  lVar4 = local_30;
                  if (!cVar2) {
                    ZhSegment.Initialize(&local_40,DAT_181d986f0);
                    return;
                  }
                  if (local_30 == 0) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                } while (*(char *)(local_30 + 96) != false);
                uVar5 = this.heroHandBookIconList;
                uVar1 = this.heroHandBookIconPrefab;
                uVar5 = GlobalData.AddChild(uVar5,uVar1,0);
                this.temp = uVar5;
                if (this.temp == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                lVar6 = GameObject.GetComponent(this.temp,DAT_181d71ac8);
                if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                *(int64 *)(lVar6 + 24) = lVar4;
                if (this.temp == null) break;
                lVar4 = GameObject.GetComponent(this.temp,DAT_181d71ac8);
                if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                HeroHandBookIconController.Init(lVar4,0);
              }
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
          }
        }
    }

    // Token : 0x6001769
    // RVA   : 0x8747E0   Offset: 0x873BE0   Length: 0x7DE
    public void ShowForceSkill(int forceID)
    {
        uint uVar1;
        bool cVar2;
        int iVar3;
        long lVar4;
        long lVar5;
        ulong uVar6;
        long lVar7;
        long lVar10;
        long lVar11;
        ulong uVar12;
        ulong uVar13;
        ulong uVar14;
        int[] local_res20 = new int[2];
        uint local_88;
        uint uStack_84;
        uint uStack_80;
        uint32 uStack_7c;
        uint32 local_70;
        uint32 uStack_6c;
        uint32 uStack_68;
        uint32 uStack_64;
        int64 local_60;
        uint32 local_58;
        uint32 uStack_54;
        uint32 uStack_50;
        uint32 uStack_4c;
        int64 local_48;
        local_res20[0] = 0;
        uVar6 = this.skillHandBookSkillIconList;
        GlobalData.DeleteAllChild(uVar6,0);
        lVar4 = GameController.lockObj;
        if ((lVar4 != null) && (lVar4 = *(int64 *)(lVar4 + 0x128)) != null) {
          lVar4 = FUN_1808ae5b0(lVar4,DAT_181dbc480);
          if (lVar4 != null) {
            ValueCollection.GetEnumerator(&local_70,lVar4,DAT_181d7f270);
            local_58 = local_70;
            uStack_54 = uStack_6c;
            uStack_50 = uStack_68;
            uStack_4c = uStack_64;
            local_48 = local_60;
            while( true ) {
              while( true ) {
                do {
                  cVar2 = FUN_1811c4590(&local_58,DAT_181d9a070);
                  lVar4 = local_48;
                  if (!cVar2) {
                    ZhSegment.Initialize(&local_58,DAT_181d99ff0);
                    uVar6 = this.skillHandBookSkillIconList;
                    GlobalData.SortChild(uVar6,0);
                    return;
                  }
                  if (local_48 == 0) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                } while (*(int *)(local_48 + 24) != forceID);
                uVar1 = *(uint32 *)(local_48 + 20);
                lVar5 = new KungfuSkillLvData(uVar1,0);
                lVar7 = GameController.difficultyExtraPoint;
                if (lVar7 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                lVar7 = *(int64 *)(lVar7 + 16);
                uVar6 = Int32.ToString(lVar4 + 20,0);
                uVar6 = String.Concat("HandBookSkill_",uVar6);
                if (lVar7 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                iVar3 = PlayerPrefDictionary.GetInt(lVar7,uVar6);
                if (iVar3 != 1) break;
                if (lVar5 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                KungfuSkillLvData.Upgrade(lVar5,10);
                uVar6 = this.skillHandBookSkillIconList;
                lVar4 = FUN_18046c1a0(0);
                if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                uVar12 = *(uint64 *)(lVar4 + 168);
                uVar6 = GlobalData.AddChild(uVar6,uVar12);
                this.temp = uVar6;
                if (this.temp == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                lVar4 = GameObject.GetComponent(this.temp,DAT_181d73800);
                if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                *(int64 *)(lVar4 + 32) = lVar5;
                if (this.temp == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                lVar4 = GameObject.GetComponent(this.temp,DAT_181d73800);
                if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                *(uint32 *)(lVar4 + 40) = 2;
                if (this.temp == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                lVar4 = GameObject.GetComponent(this.temp,DAT_181d73800);
                if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                SkillIconController.AutoSetName(lVar4,1);
              }
              uVar6 = this.skillHandBookSkillIconList;
              uVar12 = this.unlockSkillHandBookPrefab;
              uVar6 = GlobalData.AddChild(uVar6,uVar12,0);
              this.temp = uVar6;
              if (this.temp == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              lVar7 = GameObject.get_transform(this.temp,0);
              if (lVar7 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              lVar7 = Transform.Find(lVar7,"Light",0);
              if (lVar7 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              plVar8 = (int64 *)Component.GetComponent(lVar7,DAT_181d94478);
              lVar7 = FUN_18046c100(0);
              if (lVar7 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              if (*(int64 *)(lVar7 + 56) == 0) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              lVar7 = FUN_180002f80(*(int64 *)(lVar7 + 56),*(uint32 *)(lVar4 + 52),
                                    DAT_181d9e120);
              if (lVar7 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              local_88 = *(uint32 *)(lVar7 + 24);
              uStack_84 = *(uint32 *)(lVar7 + 28);
              uStack_80 = *(uint32 *)(lVar7 + 32);
              uStack_7c = *(uint32 *)(lVar7 + 36);
              puVar9 = (uint32 *)GlobalData.SetColorAlpha(&local_70,&local_88,0x3f000000,0);
              if (plVar8 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              local_88 = *puVar9;
              uStack_84 = puVar9[1];
              uStack_80 = puVar9[2];
              uStack_7c = puVar9[3];
              (**(code **)(*plVar8 + 0x2a8))(plVar8,&local_88,*(uint64 *)(*plVar8 + 0x2b0));
              if (this.temp == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              lVar7 = GameObject.get_transform(this.temp,0);
              if (lVar7 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              lVar7 = Transform.Find(lVar7,"Icon",0);
              if (lVar7 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              lVar10 = Component.GetComponent(lVar7,DAT_181d94478);
              lVar11 = FUN_18046c680(0);
              lVar7 = *(int64 *)(*(int64 *)(DAT_181d73d40 + 184) + 0x4a0);
              if (lVar7 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              uVar6 = FUN_180002f80(lVar7,*(uint32 *)(lVar4 + 48),DAT_181da4370);
              if (lVar11 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              uVar6 = TextureController.LoadAtlasSprite(lVar11,"UIAtlas",uVar6,0);
              if (lVar10 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              Image.set_sprite(lVar10,uVar6,0);
              lVar4 = this.temp;
              if (lVar5 == null) break;
              lVar7 = KungfuSkillLvData.DataBase(lVar5,0);
              if (lVar7 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              uVar6 = Int32.ToString(lVar7 + 52,0);
              lVar7 = KungfuSkillLvData.DataBase(lVar5,0);
              if (lVar7 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              uVar12 = Int32.ToString(lVar7 + 52,"",0);
              lVar7 = KungfuSkillLvData.DataBase(lVar5,0);
              if (lVar7 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              local_res20[0] = *(int *)(lVar7 + 24) + 1;
              uVar13 = Int32.ToString(local_res20,"00",0);
              uVar14 = Int32.ToString(lVar5 + 16,"0000",0);
              uVar6 = String.Concat(uVar6,uVar12,uVar13,uVar14,0);
              if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              Object.set_name(lVar4,uVar6);
            }
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
        }
    }

    // Token : 0x600176A
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

    // Token : 0x600176B
    // RVA   : 0x78D070   Offset: 0x78C470   Length: 0x20
    private void <UnshowHandBookMenu>b__14_0()
    {
        if (this.handBookMenu != null) {
          GameObject.SetActive(this.handBookMenu,0,0);
          return;
        }
    }

}
