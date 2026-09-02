// ============================================================
// Type  : HandBookMenuController
// Token : 0x20002B6
// ============================================================

public class HandBookMenuController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400160A
    public GameObject handBookMenu;

    // Token: 0x400160B
    public GameObject skillHandBookForceTabPrefab;

    // Token: 0x400160C
    public GameObject unlockSkillHandBookPrefab;

    // Token: 0x400160D
    public GameObject skillHandBookForceTabList;

    // Token: 0x400160E
    public GameObject skillHandBookSkillIconList;

    // Token: 0x400160F
    public GameObject heroHandBookIconPrefab;

    // Token: 0x4001610
    public GameObject heroHandBookIconList;

    // Token: 0x4001611
    private bool inited;

    // Token: 0x4001612
    private GameObject temp;

    // Token: 0x4001613
    private static HandBookMenuController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600171F
    // RVA   : 0x876B10   Offset: 0x875310   Length: 0x36
    public static HandBookMenuController get_Instance()
    {
        return **(uint64 **)(DAT_181d50800 + 184);
    }

    // Token : 0x6001720
    // RVA   : 0x875210   Offset: 0x873A10   Length: 0x99
    private void Awake()
    {
        ulong uVar1;
        bool cVar3;
        uVar1 = **(uint64 **)(DAT_181d50800 + 184);
        cVar3 = Object.op_Equality(uVar1,0,0);
        if (cVar3) {
          puVar2 = *(uint64 **)(DAT_181d50800 + 184);
          *puVar2 = this;
          il2cpp_internal(puVar2,this);
        }
    }

    // Token : 0x6001721
    // RVA   : 0x876500   Offset: 0x874D00   Length: 0x2E4
    public void ShowHandBookMenu()
    {
        long lVar1;
        ulong uVar5;
        ulong local_38;
        ulong uStack_30;
        byte[] local_28 = new byte[32];
        if (this.handBookMenu != null) {
          GameObject.SetActive(this.handBookMenu,1,0);
          if (this.handBookMenu != null) {
            lVar1 = GameObject.get_transform(this.handBookMenu,0);
            if (lVar1 != null) {
              lVar1 = Transform.Find(lVar1,"BlackBackground",0);
              if (lVar1 != null) {
                plVar2 = (int64 *)Component.GetComponent(lVar1,DAT_181d6bc40);
                if (this.handBookMenu != null) {
                  lVar1 = GameObject.get_transform(this.handBookMenu,0);
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
                          if (this.handBookMenu != null) {
                            lVar1 = GameObject.get_transform(this.handBookMenu,0);
                            if (lVar1 != null) {
                              lVar1 = Transform.Find(lVar1,"BlackBackground",0);
                              if (lVar1 != null) {
                                uVar5 = Component.GetComponent(lVar1,DAT_181d6bc40);
                                uVar5 = DOTweenModuleUI.DOFade(uVar5,0x3f000000,0x3e800000,0);
                                TweenSettingsExtensions.SetUpdate(uVar5,1,DAT_181d98958);
                                if (this.handBookMenu != null) {
                                  lVar1 = GameObject.get_transform(this.handBookMenu,0);
                                  if (lVar1 != null) {
                                    lVar1 = Transform.Find(lVar1,"HandBookRoot",0);
                                    if (lVar1 != null) {
                                      local_38 = 0x3f80000000000000;
                                      uStack_30 = CONCAT44(uStack_30._4_4_,0x3f800000);
                                      Transform.set_localScale(lVar1,&local_38,0);
                                      if (this.handBookMenu != null) {
                                        lVar1 = GameObject.get_transform(this.handBookMenu,0)
                                        ;
                                        if (lVar1 != null) {
                                          uVar5 = Transform.Find(lVar1,"HandBookRoot",0);
                                          uVar5 = ShortcutExtensions.DOScale
                                                            (uVar5,0x3f800000,0x3e800000,0);
                                          TweenSettingsExtensions.SetUpdate(uVar5,1,DAT_181d98af0);
                                          if (!this.inited) {
                                            HandBookMenuController.Init(this,0);
                                          }
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

    // Token : 0x6001722
    // RVA   : 0x8767F0   Offset: 0x874FF0   Length: 0x31A
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
                  lVar1 = Component.GetComponent(lVar1,DAT_181d6da40);
                  if (lVar1 != null) {
                    Toggle.set_isOn(lVar1,1,0);
                    if (this.handBookMenu != null) {
                      lVar1 = GameObject.get_transform(this.handBookMenu,0);
                      if (lVar1 != null) {
                        lVar1 = Transform.Find(lVar1,"BlackBackground",0);
                        if (lVar1 != null) {
                          uVar2 = Component.GetComponent(lVar1,DAT_181d6bc40);
                          uVar2 = DOTweenModuleUI.DOFade(uVar2,0,0x3e4ccccd,0);
                          TweenSettingsExtensions.SetUpdate(uVar2,1,DAT_181d98958);
                          if (this.handBookMenu != null) {
                            lVar1 = GameObject.get_transform(this.handBookMenu,0);
                            if (lVar1 != null) {
                              uVar2 = Transform.Find(lVar1,"HandBookRoot",0);
                              local_18 = 0;
                              local_14 = 0x3f800000;
                              local_10 = 0x3f800000;
                              uVar2 = ShortcutExtensions.DOScale(uVar2,&local_18,0x3e4ccccd,0);
                              uVar2 = TweenSettingsExtensions.SetUpdate(uVar2,1,DAT_181d98af0);
                              uVar3 = new OnTooltipCB(this,DAT_181d4f710,0);
                              TweenSettingsExtensions.OnComplete(uVar2,uVar3,DAT_181d96ee8);
                              plVar4 = (int64 *)Resources.Load("Sound/SoundEffect/OpenBook",0);
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
          }
        }
    }

    // Token : 0x6001723
    // RVA   : 0x8752B0   Offset: 0x873AB0   Length: 0x729
    public void Init()
    {
        var pStatics = *(int64*)(DAT_181d4ef00 + 184);
        ulong uVar1;
        bool cVar2;
        ulong uVar3;
        long lVar4;
        long lVar7;
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
        uVar3 = this.skillHandBookForceTabList;
        uVar1 = this.skillHandBookForceTabPrefab;
        uVar3 = GlobalData.AddChild(uVar3,uVar1,0);
        this.temp = uVar3;
        if (this.temp != null) {
          Object.set_name(this.temp,"-1",0);
          if (this.temp != null) {
            lVar4 = GameObject.GetComponent(this.temp,DAT_181da15b0);
            if (lVar4 != null) {
              *(uint32 *)(lVar4 + 24) = 0xffffffff;
              if (this.temp != null) {
                lVar4 = GameObject.get_transform(this.temp,0);
                if (lVar4 != null) {
                  lVar4 = Transform.Find(lVar4,"Name",0);
                  if (lVar4 != null) {
                    uVar3 = Component.GetComponent(lVar4,DAT_181d6d8c0);
                    LTLocalization.SetText(uVar3,"江湖",0);
                    if (this.temp != null) {
                      lVar4 = GameObject.get_transform(this.temp,0);
                      if (lVar4 != null) {
                        lVar4 = Transform.Find(lVar4,"Icon",0);
                        if (lVar4 != null) {
                          plVar5 = (int64 *)Component.GetComponent(lVar4,DAT_181d6bc40);
                          puVar6 = (uint32 *)FUN_180d904c0(&local_58,0);
                          if (plVar5 != (int64 *)0) {
                            local_58 = *puVar6;
                            uStack_54 = puVar6[1];
                            uStack_50 = puVar6[2];
                            uStack_4c = puVar6[3];
                            (**(code **)(*plVar5 + 0x2a8))
                                      (plVar5,&local_58,*(uint64 *)(*plVar5 + 0x2b0));
                            lVar4 = *(int64 *)(*(int64 *)(DAT_181d4e010 + 184) + 32);
                            if ((lVar4 != null) && (lVar4 = *(int64 *)(lVar4 + 208)) != null) {
                              lVar4 = FUN_1808acf30(lVar4,DAT_181d94200);
                              if (lVar4 != null) {
                                ValueCollection.GetEnumerator(&local_48,lVar4,DAT_181d56968);
                                local_30 = local_48;
                                uStack_2c = uStack_44;
                                uStack_28 = uStack_40;
                                uStack_24 = uStack_3c;
                                local_20 = local_38;
                                while( true ) {
                                  do {
                                    do {
                                      do {
                                        cVar2 = FUN_1811d7520(&local_30,DAT_181d71cb8);
                                        lVar4 = local_20;
                                        if (!cVar2) {
                                          ZhSegment.Initialize(&local_30,DAT_181d71c38);
                                          return;
                                        }
                                        if (local_20 == 0) {
                          // WARNING: Subroutine does not return
                                          FUN_1800d6620();
                                        }
                                      } while (*(char *)(local_20 + 36) == false);
                                      uVar3 = this.skillHandBookForceTabList;
                                      uVar1 = this.skillHandBookForceTabPrefab;
                                      uVar3 = GlobalData.AddChild(uVar3,uVar1,0);
                                      this.temp = uVar3;
                                      lVar7 = this.temp;
                                      puVar6 = (uint32 *)(lVar4 + 16);
                                      uVar3 = Int32.ToString(puVar6,"00",0);
                                      if (lVar7 == null) {
                          // WARNING: Subroutine does not return
                                        FUN_1800d6620();
                                      }
                                      Object.set_name(lVar7,uVar3,0);
                                      if (this.temp == null) {
                          // WARNING: Subroutine does not return
                                        FUN_1800d6620();
                                      }
                                      lVar7 = GameObject.GetComponent
                                                        (this.temp,DAT_181da15b0);
                                      if (lVar7 == null) {
                          // WARNING: Subroutine does not return
                                        FUN_1800d6620();
                                      }
                                      *(uint32 *)(lVar7 + 24) = *puVar6;
                                      if (this.temp == null) {
                          // WARNING: Subroutine does not return
                                        FUN_1800d6620();
                                      }
                                      lVar7 = GameObject.get_transform(this.temp,0);
                                      if (lVar7 == null) {
                          // WARNING: Subroutine does not return
                                        FUN_1800d6620();
                                      }
                                      lVar7 = Transform.Find(lVar7,"Name",0);
                                      if (lVar7 == null) {
                          // WARNING: Subroutine does not return
                                        FUN_1800d6620();
                                      }
                                      uVar3 = Component.GetComponent(lVar7,DAT_181d6d8c0);
                                      LTLocalization.SetText(uVar3,*(uint64 *)(lVar4 + 24),0);
                                      if (this.temp == null) {
                          // WARNING: Subroutine does not return
                                        FUN_1800d6620();
                                      }
                                      lVar4 = GameObject.get_transform(this.temp,0);
                                      if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                                        FUN_1800d6620();
                                      }
                                      lVar4 = Transform.Find(lVar4,"Icon",0);
                                      if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                                        FUN_1800d6620();
                                      }
                                      lVar4 = Component.GetComponent(lVar4,DAT_181d6bc40);
                                      lVar7 = FUN_18046c6c0(0);
                                      uVar3 = GlobalData.GetForceIconName(*puVar6,0);
                                      if (lVar7 == null) {
                          // WARNING: Subroutine does not return
                                        FUN_1800d6620();
                                      }
                                      uVar3 = TextureController.LoadAtlasSprite
                                                        (lVar7,"UIAtlas",uVar3,0);
                                      if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                                        FUN_1800d6620();
                                      }
                                      Image.set_sprite(lVar4,uVar3);
                                    } while (*(int *)(pStatics + 8) != 1);
                                    lVar4 = *(int64 *)(pStatics + 32);
                                    if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                                      FUN_1800d6620();
                                    }
                                    cVar2 = FUN_181815240(lVar4,*puVar6);
                                  } while (cVar2);
                                  if (this.temp == null) {
                          // WARNING: Subroutine does not return
                                    FUN_1800d6620();
                                  }
                                  lVar4 = GameObject.GetComponent
                                                    (this.temp,DAT_181d9ee60);
                                  if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                                    FUN_1800d6620();
                                  }
                                  Selectable.set_interactable(lVar4,0,0);
                                  if (this.temp == null) {
                          // WARNING: Subroutine does not return
                                    FUN_1800d6620();
                                  }
                                  lVar4 = GameObject.get_transform(this.temp,0);
                                  if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                                    FUN_1800d6620();
                                  }
                                  lVar4 = Transform.Find(lVar4,"Name",0);
                                  if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                                    FUN_1800d6620();
                                  }
                                  uVar3 = Component.GetComponent(lVar4,DAT_181d6d8c0);
                                  LTLocalization.SetText(uVar3,"???",0);
                                  if (this.temp == null) {
                          // WARNING: Subroutine does not return
                                    FUN_1800d6620();
                                  }
                                  lVar4 = GameObject.get_transform(this.temp,0);
                                  if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                                    FUN_1800d6620();
                                  }
                                  lVar4 = Transform.Find(lVar4,"Icon",0);
                                  if (lVar4 == null) break;
                                  plVar5 = (int64 *)Component.GetComponent(lVar4,DAT_181d6bc40);
                                  puVar6 = (uint32 *)Color.get_black(&local_48,0);
                                  if (plVar5 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                                    FUN_1800d6620();
                                  }
                                  local_58 = *puVar6;
                                  uStack_54 = puVar6[1];
                                  uStack_50 = puVar6[2];
                                  uStack_4c = puVar6[3];
                                  (**(code **)(*plVar5 + 0x2a8))(plVar5,&local_58);
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

    // Token : 0x6001724
    // RVA   : 0x8761C0   Offset: 0x8749C0   Length: 0x338
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
            (lVar4 = Component.GetComponent(lVar4,DAT_181d6da40)) != null))) {
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
               (lVar4 = FUN_1808acf30(*(int64 *)(lVar4 + 0x150),DAT_181d94a80)) != null) {
              ValueCollection.GetEnumerator(&local_28,lVar4,DAT_181d56ae8);
              local_40 = local_28;
              uStack_3c = uStack_24;
              uStack_38 = uStack_20;
              uStack_34 = uStack_1c;
              local_30 = local_18;
              while( true ) {
                do {
                  cVar2 = FUN_1811d7520(&local_40,DAT_181d722b8);
                  lVar4 = local_30;
                  if (!cVar2) {
                    ZhSegment.Initialize(&local_40,DAT_181d72238);
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
                lVar6 = GameObject.GetComponent(this.temp,DAT_181d9fa98);
                if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                *(int64 *)(lVar6 + 24) = lVar4;
                if (this.temp == null) break;
                lVar4 = GameObject.GetComponent(this.temp,DAT_181d9fa98);
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

    // Token : 0x6001725
    // RVA   : 0x8759E0   Offset: 0x8741E0   Length: 0x7DE
    public void ShowForceSkill(int forceID)
    {
        var pStatics = *(int64*)(DAT_181d4e010 + 184);
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
        lVar4 = *(int64 *)(pStatics + 32);
        if ((lVar4 != null) && (lVar4 = *(int64 *)(lVar4 + 0x128)) != null) {
          lVar4 = FUN_1808acf30(lVar4,DAT_181d96ce8);
          if (lVar4 != null) {
            ValueCollection.GetEnumerator(&local_70,lVar4,DAT_181d575e8);
            local_58 = local_70;
            uStack_54 = uStack_6c;
            uStack_50 = uStack_68;
            uStack_4c = uStack_64;
            local_48 = local_60;
            while( true ) {
              while( true ) {
                do {
                  cVar2 = FUN_1811d7520(&local_58,DAT_181d73bb8);
                  lVar4 = local_48;
                  if (!cVar2) {
                    ZhSegment.Initialize(&local_58,DAT_181d73b38);
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
                lVar7 = *(int64 *)(pStatics + 8);
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
                lVar4 = GameObject.GetComponent(this.temp,DAT_181da1630);
                if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                *(int64 *)(lVar4 + 32) = lVar5;
                if (this.temp == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                lVar4 = GameObject.GetComponent(this.temp,DAT_181da1630);
                if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                *(uint32 *)(lVar4 + 40) = 2;
                if (this.temp == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                lVar4 = GameObject.GetComponent(this.temp,DAT_181da1630);
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
              plVar8 = (int64 *)Component.GetComponent(lVar7,DAT_181d6bc40);
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
                                    DAT_181d76758);
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
              lVar10 = Component.GetComponent(lVar7,DAT_181d6bc40);
              lVar11 = FUN_18046c6c0(0);
              lVar7 = *(int64 *)(*(int64 *)(DAT_181d4ef00 + 184) + 0x498);
              if (lVar7 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              uVar6 = FUN_180002f80(lVar7,*(uint32 *)(lVar4 + 48),DAT_181d7c9c0);
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

    // Token : 0x6001726
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

    // Token : 0x6001727
    // RVA   : 0x790570   Offset: 0x78ED70   Length: 0x20
    private void <UnshowHandBookMenu>b__14_0()
    {
        if (this.handBookMenu != null) {
          GameObject.SetActive(this.handBookMenu,0,0);
          return;
        }
    }

}
