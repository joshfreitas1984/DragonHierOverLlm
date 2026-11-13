// ============================================================
// Type  : HandBookMenuController
// Token : 0x20002C5
// ============================================================

public class HandBookMenuController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001712
    public GameObject handBookMenu;

    // Token: 0x4001713
    public GameObject skillHandBookForceTabPrefab;

    // Token: 0x4001714
    public GameObject unlockSkillHandBookPrefab;

    // Token: 0x4001715
    public GameObject skillHandBookForceTabList;

    // Token: 0x4001716
    public GameObject skillHandBookSkillIconList;

    // Token: 0x4001717
    public GameObject heroHandBookIconPrefab;

    // Token: 0x4001718
    public GameObject heroHandBookIconList;

    // Token: 0x4001719
    private bool inited;

    // Token: 0x400171A
    private GameObject temp;

    // Token: 0x400171B
    private static HandBookMenuController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60017DF
    // RVA   : 0x5AE220   Offset: 0x5AD020   Length: 0x36
    public static HandBookMenuController get_Instance()
    {
        return **(uint64 **)(DAT_181e55378 + 184);
    }

    // Token : 0x60017E0
    // RVA   : 0x5AC3D0   Offset: 0x5AB1D0   Length: 0x99
    private void Awake()
    {
        ulong uVar1;
        bool cVar3;
        uVar1 = **(uint64 **)(DAT_181e55378 + 184);
        cVar3 = Object.op_Equality(uVar1,0,0);
        if (cVar3) {
          puVar2 = *(uint64 **)(DAT_181e55378 + 184);
          *puVar2 = this;
          il2cpp_internal(puVar2,this);
        }
    }

    // Token : 0x60017E1
    // RVA   : 0x5AD710   Offset: 0x5AC510   Length: 0x7E3
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
            plVar6 = (int64 *)Component.GetComponent(lVar5,DAT_181e777b8);
            if (((this.handBookMenu != null) &&
                (lVar5 = GameObject.get_transform(this.handBookMenu,0)) != null) &&
               ((lVar5 = Transform.Find(lVar5,"BlackBackground",0), lVar5 != null &&
                (plVar7 = (int64 *)Component.GetComponent(lVar5,DAT_181e777b8),
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
                  uVar9 = Component.GetComponent(lVar5,DAT_181e777b8);
                  uVar9 = DOTweenModuleUI.DOFade(uVar9,0x3f000000,0x3e800000,0);
                  TweenSettingsExtensions.SetUpdate(uVar9,1,DAT_181ea5848);
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
                      TweenSettingsExtensions.SetUpdate(uVar9,1,DAT_181ea59e0);
                      if (!this.inited) {
                        HandBookMenuController.Init(this,0);
                      }
                      bVar2 = true;
                      lVar5 = GameController.ChangeAllAreaStateIDs;
                      if (((lVar5 != null) && (lVar5 = *(int64 *)(lVar5 + 0x160)) != null) &&
                         (lVar5 = FUN_1806e0520(lVar5,DAT_181e9b7f0)) != null) {
                        ValueCollection.GetEnumerator(&local_60,lVar5,DAT_181e612a8);
                        local_48 = local_60;
                        uStack_44 = uStack_5c;
                        uStack_40 = uStack_58;
                        uStack_3c = uStack_54;
                        local_38 = local_50;
                        do {
                          do {
                            cVar3 = FUN_180dd6250(&local_48,DAT_181e7a530);
                            lVar5 = local_38;
                            if (!cVar3) {
                              ZhSegment.Initialize(&local_48,DAT_181e7a4b0);
                              goto LAB_1805adc8c;
                            }
                            if (local_38 == 0) {
                          // WARNING: Subroutine does not return
                              FUN_1801e0300();
                            }
                          } while (*(char *)(local_38 + 96) != false);
                          lVar1 = GameController.difficultyExtraPoint;
                          if (lVar1 == null) {
                          // WARNING: Subroutine does not return
                            FUN_1801e0300();
                          }
                          lVar1 = *(int64 *)(lVar1 + 16);
                          uVar9 = Int32.ToString(lVar5 + 88,0);
                          uVar9 = String.Concat("HandBookHero_",uVar9,0);
                          if (lVar1 == null) {
                          // WARNING: Subroutine does not return
                            FUN_1801e0300();
                          }
                          iVar4 = PlayerPrefDictionary.GetInt(lVar1,uVar9);
                        } while (iVar4 != 0);
                        bVar2 = false;
                        ZhSegment.Initialize(&local_48,DAT_181e7a4b0);
        LAB_1805adc8c:
                        if (bVar2) {
                          lVar5 = FUN_180210740(0);
                          if (lVar5 == null) throw; // [null/range check failed]
                          GameDataController.ChangeAchStats(lVar5,47,0x3f800000);
                        }
                        lVar5 = FUN_180210740(0);
                        if (((lVar5 != null) && (*(int64 *)(lVar5 + 0x138) != 0)) &&
                           (lVar5 = FUN_1806e0520(*(int64 *)(lVar5 + 0x138),DAT_181e9db68)) != null
                           ) {
                          ValueCollection.GetEnumerator(&local_60,lVar5,DAT_181e61da0);
                          local_78 = CONCAT44(uStack_5c,local_60);
                          uStack_70 = CONCAT44(uStack_54,uStack_58);
                          local_68 = local_50;
                          while (cVar3 = FUN_180dd6250(&local_78,DAT_181e7be30), lVar5 = local_68,
                                cVar3) {
                            lVar1 = GameController.difficultyExtraPoint;
                            if (lVar1 == null) {
                          // WARNING: Subroutine does not return
                              FUN_1801e0300();
                            }
                            lVar1 = *(int64 *)(lVar1 + 16);
                            if (lVar5 == null) {
                          // WARNING: Subroutine does not return
                              FUN_1801e0300();
                            }
                            uVar9 = Int32.ToString(lVar5 + 20,0);
                            uVar9 = String.Concat("HandBookSkill_",uVar9,0);
                            if (lVar1 == null) {
                          // WARNING: Subroutine does not return
                              FUN_1801e0300();
                            }
                            iVar4 = PlayerPrefDictionary.GetInt(lVar1,uVar9);
                            if (iVar4 == 0) {
                              ZhSegment.Initialize(&local_78,DAT_181e7bdb0);
                              return;
                            }
                          }
                          ZhSegment.Initialize(&local_78,DAT_181e7bdb0);
                          lVar5 = FUN_180210740(0);
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

    // Token : 0x60017E2
    // RVA   : 0x5ADF00   Offset: 0x5ACD00   Length: 0x31A
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
                  lVar1 = Component.GetComponent(lVar1,DAT_181e796b8);
                  if (lVar1 != null) {
                    Toggle.set_isOn(lVar1,1,0);
                    if (this.handBookMenu != null) {
                      lVar1 = GameObject.get_transform(this.handBookMenu,0);
                      if (lVar1 != null) {
                        lVar1 = Transform.Find(lVar1,"BlackBackground",0);
                        if (lVar1 != null) {
                          uVar2 = Component.GetComponent(lVar1,DAT_181e777b8);
                          uVar2 = DOTweenModuleUI.DOFade(uVar2,0,0x3e4ccccd,0);
                          TweenSettingsExtensions.SetUpdate(uVar2,1,DAT_181ea5848);
                          if (this.handBookMenu != null) {
                            lVar1 = GameObject.get_transform(this.handBookMenu,0);
                            if (lVar1 != null) {
                              uVar2 = Transform.Find(lVar1,"HandBookRoot",0);
                              local_18 = 0;
                              local_14 = 0x3f800000;
                              local_10 = 0x3f800000;
                              uVar2 = ShortcutExtensions.DOScale(uVar2,&local_18,0x3e4ccccd,0);
                              uVar2 = TweenSettingsExtensions.SetUpdate(uVar2,1,DAT_181ea59e0);
                              uVar3 = new OnTooltipCB(this,DAT_181e5b548,0);
                              TweenSettingsExtensions.OnComplete(uVar2,uVar3,DAT_181ea3dc0);
                              plVar4 = (int64 *)Resources.Load("Sound/SoundEffect/OpenBook",0);
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
          }
        }
    }

    // Token : 0x60017E3
    // RVA   : 0x5AC470   Offset: 0x5AB270   Length: 0x77B
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
            lVar3 = GameObject.GetComponent(this.temp,DAT_181e56840);
            if (lVar3 != null) {
              *(uint32 *)(lVar3 + 24) = 0xffffffff;
              if (this.temp != null) {
                lVar3 = GameObject.get_transform(this.temp,0);
                if (lVar3 != null) {
                  lVar3 = Transform.Find(lVar3,"Name",0);
                  if (lVar3 != null) {
                    uVar2 = Component.GetComponent(lVar3,DAT_181e79538);
                    LTLocalization.SetText(uVar2,"江湖",0);
                    if (this.temp != null) {
                      lVar3 = GameObject.get_transform(this.temp,0);
                      if (lVar3 != null) {
                        lVar3 = Transform.Find(lVar3,"Icon",0);
                        if (lVar3 != null) {
                          plVar4 = (int64 *)Component.GetComponent(lVar3,DAT_181e777b8);
                          puVar5 = (uint32 *)FUN_180af4e90(&local_58,0);
                          if (plVar4 != (int64 *)0) {
                            local_58 = *puVar5;
                            uStack_54 = puVar5[1];
                            uStack_50 = puVar5[2];
                            uStack_4c = puVar5[3];
                            (**(code **)(*plVar4 + 0x2a8))
                                      (plVar4,&local_58,*(uint64 *)(*plVar4 + 0x2b0));
                            lVar3 = *(int64 *)(*(int64 *)(DAT_181e528f8 + 184) + 32);
                            if ((lVar3 != null) && (lVar3 = *(int64 *)(lVar3 + 208)) != null) {
                              lVar3 = FUN_1806e0520(lVar3,DAT_181e9add8);
                              if (lVar3 != null) {
                                ValueCollection.GetEnumerator(&local_48,lVar3,DAT_181e611b0);
                                local_30 = local_48;
                                uStack_2c = uStack_44;
                                uStack_28 = uStack_40;
                                uStack_24 = uStack_3c;
                                local_20 = local_38;
                                while( true ) {
                                  do {
                                    do {
                                      do {
                                        cVar1 = FUN_180dd6250(&local_30,DAT_181e79f30);
                                        lVar3 = local_20;
                                        if (!cVar1) {
                                          ZhSegment.Initialize(&local_30,DAT_181e79eb0);
                                          return;
                                        }
                                        if (local_20 == 0) {
                          // WARNING: Subroutine does not return
                                          FUN_1801e0300();
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
                                        FUN_1801e0300();
                                      }
                                      Object.set_name(lVar6,uVar2);
                                      if (this.temp == null) {
                          // WARNING: Subroutine does not return
                                        FUN_1801e0300();
                                      }
                                      lVar6 = GameObject.GetComponent
                                                        (this.temp,DAT_181e56840);
                                      if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                                        FUN_1801e0300();
                                      }
                                      *(uint32 *)(lVar6 + 24) = *(uint32 *)(lVar3 + 16);
                                      if (this.temp == null) {
                          // WARNING: Subroutine does not return
                                        FUN_1801e0300();
                                      }
                                      lVar6 = GameObject.get_transform(this.temp,0);
                                      if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                                        FUN_1801e0300();
                                      }
                                      lVar6 = Transform.Find(lVar6,"Name");
                                      if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                                        FUN_1801e0300();
                                      }
                                      uVar2 = Component.GetComponent(lVar6,DAT_181e79538);
                                      uVar7 = ForceData.GetForceName(lVar3,1);
                                      LTLocalization.SetText(uVar2,uVar7);
                                      if (this.temp == null) {
                          // WARNING: Subroutine does not return
                                        FUN_1801e0300();
                                      }
                                      lVar6 = GameObject.get_transform(this.temp,0);
                                      if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                                        FUN_1801e0300();
                                      }
                                      lVar6 = Transform.Find(lVar6,"Icon");
                                      if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                                        FUN_1801e0300();
                                      }
                                      lVar6 = Component.GetComponent(lVar6,DAT_181e777b8);
                                      uVar2 = ForceData.GetForceIcon(lVar3,0);
                                      if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                                        FUN_1801e0300();
                                      }
                                      Image.set_sprite(lVar6,uVar2);
                                    } while (PlotController.fightSkillIndexCache != 1);
                                    lVar6 = PlotController.LeftFaceHideOffset;
                                    if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                                      FUN_1801e0300();
                                    }
                                    cVar1 = FUN_18176a2d0(lVar6,*(uint32 *)(lVar3 + 16));
                                  } while (cVar1);
                                  if (this.temp == null) {
                          // WARNING: Subroutine does not return
                                    FUN_1801e0300();
                                  }
                                  lVar3 = GameObject.GetComponent
                                                    (this.temp,DAT_181e53cb0);
                                  if (lVar3 == null) {
                          // WARNING: Subroutine does not return
                                    FUN_1801e0300();
                                  }
                                  Selectable.set_interactable(lVar3,0,0);
                                  if (this.temp == null) {
                          // WARNING: Subroutine does not return
                                    FUN_1801e0300();
                                  }
                                  lVar3 = GameObject.get_transform(this.temp,0);
                                  if (lVar3 == null) {
                          // WARNING: Subroutine does not return
                                    FUN_1801e0300();
                                  }
                                  lVar3 = Transform.Find(lVar3,"Name",0);
                                  if (lVar3 == null) {
                          // WARNING: Subroutine does not return
                                    FUN_1801e0300();
                                  }
                                  uVar2 = Component.GetComponent(lVar3,DAT_181e79538);
                                  LTLocalization.SetText(uVar2,"???",0);
                                  if (this.temp == null) {
                          // WARNING: Subroutine does not return
                                    FUN_1801e0300();
                                  }
                                  lVar3 = GameObject.get_transform(this.temp,0);
                                  if (lVar3 == null) {
                          // WARNING: Subroutine does not return
                                    FUN_1801e0300();
                                  }
                                  lVar3 = Transform.Find(lVar3,"Icon",0);
                                  if (lVar3 == null) break;
                                  plVar4 = (int64 *)Component.GetComponent(lVar3,DAT_181e777b8);
                                  puVar5 = (uint32 *)Color.get_black(&local_48,0);
                                  if (plVar4 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                                    FUN_1801e0300();
                                  }
                                  local_58 = *puVar5;
                                  uStack_54 = puVar5[1];
                                  uStack_50 = puVar5[2];
                                  uStack_4c = puVar5[3];
                                  (**(code **)(*plVar4 + 0x2a8))(plVar4,&local_58);
                                }
                          // WARNING: Subroutine does not return
                                FUN_1801e0300();
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

    // Token : 0x60017E4
    // RVA   : 0x5AD3D0   Offset: 0x5AC1D0   Length: 0x338
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
            (lVar4 = Component.GetComponent(lVar4,DAT_181e796b8)) != null))) {
          if (*(char *)(lVar4 + 0x118) == false) {
            return;
          }
          if ((this.heroHandBookIconList != null) &&
             (lVar4 = GameObject.get_transform(this.heroHandBookIconList,0)) != null) {
            iVar3 = Transform.get_childCount(lVar4,0);
            if (iVar3 != 0) {
              return;
            }
            lVar4 = FUN_180210740(0);
            if (((lVar4 != null) && (*(int64 *)(lVar4 + 0x160) != 0)) &&
               (lVar4 = FUN_1806e0520(*(int64 *)(lVar4 + 0x160),DAT_181e9b7f0)) != null) {
              ValueCollection.GetEnumerator(&local_28,lVar4,DAT_181e612a8);
              local_40 = local_28;
              uStack_3c = uStack_24;
              uStack_38 = uStack_20;
              uStack_34 = uStack_1c;
              local_30 = local_18;
              while( true ) {
                do {
                  cVar2 = FUN_180dd6250(&local_40,DAT_181e7a530);
                  lVar4 = local_30;
                  if (!cVar2) {
                    ZhSegment.Initialize(&local_40,DAT_181e7a4b0);
                    return;
                  }
                  if (local_30 == 0) {
                          // WARNING: Subroutine does not return
                    FUN_1801e0300();
                  }
                } while (*(char *)(local_30 + 96) != false);
                uVar5 = this.heroHandBookIconList;
                uVar1 = this.heroHandBookIconPrefab;
                uVar5 = GlobalData.AddChild(uVar5,uVar1,0);
                this.temp = uVar5;
                if (this.temp == null) {
                          // WARNING: Subroutine does not return
                  FUN_1801e0300();
                }
                lVar6 = GameObject.GetComponent(this.temp,DAT_181e54b90);
                if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1801e0300();
                }
                *(int64 *)(lVar6 + 24) = lVar4;
                if (this.temp == null) break;
                lVar4 = GameObject.GetComponent(this.temp,DAT_181e54b90);
                if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1801e0300();
                }
                HeroHandBookIconController.Init(lVar4,0);
              }
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
          }
        }
    }

    // Token : 0x60017E5
    // RVA   : 0x5ACBF0   Offset: 0x5AB9F0   Length: 0x7DE
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
        lVar4 = GameController.ChangeAllAreaStateIDs;
        if ((lVar4 != null) && (lVar4 = *(int64 *)(lVar4 + 0x138)) != null) {
          lVar4 = FUN_1806e0520(lVar4,DAT_181e9db68);
          if (lVar4 != null) {
            ValueCollection.GetEnumerator(&local_70,lVar4,DAT_181e61da0);
            local_58 = local_70;
            uStack_54 = uStack_6c;
            uStack_50 = uStack_68;
            uStack_4c = uStack_64;
            local_48 = local_60;
            while( true ) {
              while( true ) {
                do {
                  cVar2 = FUN_180dd6250(&local_58,DAT_181e7be30);
                  lVar4 = local_48;
                  if (!cVar2) {
                    ZhSegment.Initialize(&local_58,DAT_181e7bdb0);
                    uVar6 = this.skillHandBookSkillIconList;
                    GlobalData.SortChild(uVar6,0);
                    return;
                  }
                  if (local_48 == 0) {
                          // WARNING: Subroutine does not return
                    FUN_1801e0300();
                  }
                } while (*(int *)(local_48 + 24) != forceID);
                uVar1 = *(uint32 *)(local_48 + 20);
                lVar5 = new KungfuSkillLvData(uVar1,0);
                lVar7 = GameController.difficultyExtraPoint;
                if (lVar7 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1801e0300();
                }
                lVar7 = *(int64 *)(lVar7 + 16);
                uVar6 = Int32.ToString(lVar4 + 20,0);
                uVar6 = String.Concat("HandBookSkill_",uVar6);
                if (lVar7 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1801e0300();
                }
                iVar3 = PlayerPrefDictionary.GetInt(lVar7,uVar6);
                if (iVar3 != 1) break;
                if (lVar5 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1801e0300();
                }
                KungfuSkillLvData.Upgrade(lVar5,10);
                uVar6 = this.skillHandBookSkillIconList;
                lVar4 = FUN_1802107e0(0);
                if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1801e0300();
                }
                uVar12 = *(uint64 *)(lVar4 + 168);
                uVar6 = GlobalData.AddChild(uVar6,uVar12);
                this.temp = uVar6;
                if (this.temp == null) {
                          // WARNING: Subroutine does not return
                  FUN_1801e0300();
                }
                lVar4 = GameObject.GetComponent(this.temp,DAT_181e568c8);
                if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1801e0300();
                }
                *(int64 *)(lVar4 + 32) = lVar5;
                if (this.temp == null) {
                          // WARNING: Subroutine does not return
                  FUN_1801e0300();
                }
                lVar4 = GameObject.GetComponent(this.temp,DAT_181e568c8);
                if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1801e0300();
                }
                *(uint32 *)(lVar4 + 40) = 2;
                if (this.temp == null) {
                          // WARNING: Subroutine does not return
                  FUN_1801e0300();
                }
                lVar4 = GameObject.GetComponent(this.temp,DAT_181e568c8);
                if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1801e0300();
                }
                SkillIconController.AutoSetName(lVar4,1);
              }
              uVar6 = this.skillHandBookSkillIconList;
              uVar12 = this.unlockSkillHandBookPrefab;
              uVar6 = GlobalData.AddChild(uVar6,uVar12,0);
              this.temp = uVar6;
              if (this.temp == null) {
                          // WARNING: Subroutine does not return
                FUN_1801e0300();
              }
              lVar7 = GameObject.get_transform(this.temp,0);
              if (lVar7 == null) {
                          // WARNING: Subroutine does not return
                FUN_1801e0300();
              }
              lVar7 = Transform.Find(lVar7,"Light",0);
              if (lVar7 == null) {
                          // WARNING: Subroutine does not return
                FUN_1801e0300();
              }
              plVar8 = (int64 *)Component.GetComponent(lVar7,DAT_181e777b8);
              lVar7 = FUN_180210740(0);
              if (lVar7 == null) {
                          // WARNING: Subroutine does not return
                FUN_1801e0300();
              }
              if (*(int64 *)(lVar7 + 56) == 0) {
                          // WARNING: Subroutine does not return
                FUN_1801e0300();
              }
              lVar7 = FUN_1800024b0(*(int64 *)(lVar7 + 56),*(uint32 *)(lVar4 + 52),
                                    DAT_181e80560);
              if (lVar7 == null) {
                          // WARNING: Subroutine does not return
                FUN_1801e0300();
              }
              local_88 = *(uint32 *)(lVar7 + 24);
              uStack_84 = *(uint32 *)(lVar7 + 28);
              uStack_80 = *(uint32 *)(lVar7 + 32);
              uStack_7c = *(uint32 *)(lVar7 + 36);
              puVar9 = (uint32 *)GlobalData.SetColorAlpha(&local_70,&local_88,0x3f000000,0);
              if (plVar8 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                FUN_1801e0300();
              }
              local_88 = *puVar9;
              uStack_84 = puVar9[1];
              uStack_80 = puVar9[2];
              uStack_7c = puVar9[3];
              (**(code **)(*plVar8 + 0x2a8))(plVar8,&local_88,*(uint64 *)(*plVar8 + 0x2b0));
              if (this.temp == null) {
                          // WARNING: Subroutine does not return
                FUN_1801e0300();
              }
              lVar7 = GameObject.get_transform(this.temp,0);
              if (lVar7 == null) {
                          // WARNING: Subroutine does not return
                FUN_1801e0300();
              }
              lVar7 = Transform.Find(lVar7,"Icon",0);
              if (lVar7 == null) {
                          // WARNING: Subroutine does not return
                FUN_1801e0300();
              }
              lVar10 = Component.GetComponent(lVar7,DAT_181e777b8);
              lVar11 = FUN_180210d00(0);
              lVar7 = *(int64 *)(*(int64 *)(DAT_181e538e8 + 184) + 0x4a8);
              if (lVar7 == null) {
                          // WARNING: Subroutine does not return
                FUN_1801e0300();
              }
              uVar6 = FUN_1800024b0(lVar7,*(uint32 *)(lVar4 + 48),DAT_181e86970);
              if (lVar11 == null) {
                          // WARNING: Subroutine does not return
                FUN_1801e0300();
              }
              uVar6 = TextureController.LoadAtlasSprite(lVar11,"UIAtlas",uVar6,0);
              if (lVar10 == null) {
                          // WARNING: Subroutine does not return
                FUN_1801e0300();
              }
              Image.set_sprite(lVar10,uVar6,0);
              lVar4 = this.temp;
              if (lVar5 == null) break;
              lVar7 = KungfuSkillLvData.DataBase(lVar5,0);
              if (lVar7 == null) {
                          // WARNING: Subroutine does not return
                FUN_1801e0300();
              }
              uVar6 = Int32.ToString(lVar7 + 52,0);
              lVar7 = KungfuSkillLvData.DataBase(lVar5,0);
              if (lVar7 == null) {
                          // WARNING: Subroutine does not return
                FUN_1801e0300();
              }
              uVar12 = Int32.ToString(lVar7 + 52,"",0);
              lVar7 = KungfuSkillLvData.DataBase(lVar5,0);
              if (lVar7 == null) {
                          // WARNING: Subroutine does not return
                FUN_1801e0300();
              }
              local_res20[0] = *(int *)(lVar7 + 24) + 1;
              uVar13 = Int32.ToString(local_res20,"00",0);
              uVar14 = Int32.ToString(lVar5 + 16,"0000",0);
              uVar6 = String.Concat(uVar6,uVar12,uVar13,uVar14,0);
              if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                FUN_1801e0300();
              }
              Object.set_name(lVar4,uVar6);
            }
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
        }
    }

    // Token : 0x60017E6
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

    // Token : 0x60017E7
    // RVA   : 0x52B140   Offset: 0x529F40   Length: 0x20
    private void <UnshowHandBookMenu>b__14_0()
    {
        if (this.handBookMenu != null) {
          GameObject.SetActive(this.handBookMenu,0,0);
          return;
        }
    }

}
