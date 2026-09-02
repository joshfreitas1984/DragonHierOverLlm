// ============================================================
// Type  : HeroSearchController
// Token : 0x20002CD
// ============================================================

public class HeroSearchController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001695
    public GameObject heroSearchPanel;

    // Token: 0x4001696
    public GameObject heroSearchList;

    // Token: 0x4001697
    public GameObject forceIDFliterObj;

    // Token: 0x4001698
    public InputField heroSearchNameInputField;

    // Token: 0x4001699
    public bool interestingStarFliter;

    // Token: 0x400169A
    public int forceIDFliter;

    // Token: 0x400169B
    private List<bool> speFliter;

    // Token: 0x400169C
    private List<bool> sexFliter;

    // Token: 0x400169D
    private List<bool> forceLvFliter;

    // Token: 0x400169E
    private bool inited;

    // Token: 0x400169F
    private GameObject temp;

    // Token: 0x40016A0
    private static HeroSearchController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60017B3
    // RVA   : 0xB39770   Offset: 0xB37F70   Length: 0x36
    public static HeroSearchController get_Instance()
    {
        return **(uint64 **)(DAT_181d51200 + 184);
    }

    // Token : 0x60017B4
    // RVA   : 0xB37350   Offset: 0xB35B50   Length: 0xD7
    private void Awake()
    {
        bool cVar2;
        ulong uVar3;
        uVar3 = **(uint64 **)(DAT_181d51200 + 184);
        cVar2 = Object.op_Equality(uVar3,0,0);
        if (!cVar2) {
          uVar3 = Component.get_gameObject(this,0);
          Object.Destroy(uVar3,0);
          return;
        }
        puVar1 = *(uint64 **)(DAT_181d51200 + 184);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x60017B5
    // RVA   : 0xB39460   Offset: 0xB37C60   Length: 0x158
    private void Start()
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        if (**(int **)(DAT_181d4ef00 + 184) == 1) {
          cVar1 = RailManager.get_Initialized(0);
          if (!cVar1) {
            Debug.LogError("Rail sdk is not initialized!",0);
            return;
          }
          lVar2 = RailCallBackHelper.get_Instance(0);
          uVar3 = new OnTooltipCB(this,DAT_181d50510,0);
          if (lVar2 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          RailCallBackHelper.RegisterCallback(lVar2,0x1f45,uVar3,0);
        }
    }

    // Token : 0x60017B6
    // RVA   : 0xB382F0   Offset: 0xB36AF0   Length: 0x2ED
    public void OpenHeroSearch()
    {
        long lVar1;
        ulong uVar5;
        ulong local_38;
        ulong uStack_30;
        byte[] local_28 = new byte[32];
        if (!this.inited) {
          HeroSearchController.Init(this,0);
        }
        if (this.heroSearchPanel != null) {
          GameObject.SetActive(this.heroSearchPanel,1,0);
          if (this.heroSearchPanel != null) {
            lVar1 = GameObject.get_transform(this.heroSearchPanel,0);
            if (lVar1 != null) {
              lVar1 = Transform.Find(lVar1,"BlackBackground",0);
              if (lVar1 != null) {
                plVar2 = (int64 *)Component.GetComponent(lVar1,DAT_181d6bc40);
                if (this.heroSearchPanel != null) {
                  lVar1 = GameObject.get_transform(this.heroSearchPanel,0);
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
                          if (this.heroSearchPanel != null) {
                            lVar1 = GameObject.get_transform(this.heroSearchPanel,0);
                            if (lVar1 != null) {
                              lVar1 = Transform.Find(lVar1,"BlackBackground",0);
                              if (lVar1 != null) {
                                uVar5 = Component.GetComponent(lVar1,DAT_181d6bc40);
                                uVar5 = DOTweenModuleUI.DOFade(uVar5,0x3f000000,0x3e800000,0);
                                TweenSettingsExtensions.SetUpdate(uVar5,1,DAT_181d98958);
                                if (this.heroSearchPanel != null) {
                                  lVar1 = GameObject.get_transform(this.heroSearchPanel,0);
                                  if (lVar1 != null) {
                                    lVar1 = Transform.Find(lVar1,"HeroSearchRoot",0);
                                    if (lVar1 != null) {
                                      local_38 = 0x3f80000000000000;
                                      uStack_30 = CONCAT44(uStack_30._4_4_,0x3f800000);
                                      Transform.set_localScale(lVar1,&local_38,0);
                                      if (this.heroSearchPanel != null) {
                                        lVar1 = GameObject.get_transform(this.heroSearchPanel,0)
                                        ;
                                        if (lVar1 != null) {
                                          uVar5 = Transform.Find(lVar1,"HeroSearchRoot",0);
                                          uVar5 = ShortcutExtensions.DOScaleX
                                                            (uVar5,0x3f800000,0x3e800000,0);
                                          TweenSettingsExtensions.SetUpdate(uVar5,1,DAT_181d98af0);
                                          HeroSearchController.RefreshFliter(this,0);
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

    // Token : 0x60017B7
    // RVA   : 0xB37970   Offset: 0xB36170   Length: 0x194
    public void HideHeroSearch()
    {
        long lVar1;
        ulong uVar2;
        ulong uVar3;
        if (this.heroSearchPanel != null) {
          lVar1 = GameObject.get_transform(this.heroSearchPanel,0);
          if (lVar1 != null) {
            lVar1 = Transform.Find(lVar1,"BlackBackground",0);
            if (lVar1 != null) {
              uVar2 = Component.GetComponent(lVar1,DAT_181d6bc40);
              uVar2 = DOTweenModuleUI.DOFade(uVar2,0,0x3e4ccccd,0);
              TweenSettingsExtensions.SetUpdate(uVar2,1,DAT_181d98958);
              if (this.heroSearchPanel != null) {
                lVar1 = GameObject.get_transform(this.heroSearchPanel,0);
                if (lVar1 != null) {
                  uVar2 = Transform.Find(lVar1,"HeroSearchRoot",0);
                  uVar2 = ShortcutExtensions.DOScaleX(uVar2,0,0x3e4ccccd,0);
                  uVar2 = TweenSettingsExtensions.SetUpdate(uVar2,1,DAT_181d98af0);
                  uVar3 = new OnTooltipCB(this,DAT_181d50490,0);
                  TweenSettingsExtensions.OnComplete(uVar2,uVar3,DAT_181d96ee8);
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x60017B8
    // RVA   : 0xB37B10   Offset: 0xB36310   Length: 0x51C
    public void Init()
    {
        var pStatics = *(int64*)(DAT_181d4ef00 + 184);
        bool cVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        long lVar5;
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
        this.inited = 1;
        if (this.forceIDFliterObj != null) {
          lVar2 = GameObject.get_transform(this.forceIDFliterObj,0);
          if (lVar2 != null) {
            lVar2 = Component.GetComponent(lVar2,DAT_181d6b540);
            if (lVar2 != null) {
              lVar2 = Dropdown.get_options(lVar2,0);
              uVar3 = LTLocalization.GetText("所有门派",0,1,0);
              uVar4 = new ByteReader(uVar3,0);
              if (lVar2 != null) {
                FUN_181827900(lVar2,uVar4,DAT_181d878e8);
                if (this.forceIDFliterObj != null) {
                  lVar2 = GameObject.get_transform(this.forceIDFliterObj,0);
                  if (lVar2 != null) {
                    lVar2 = Component.GetComponent(lVar2,DAT_181d6b540);
                    if (lVar2 != null) {
                      lVar2 = Dropdown.get_options(lVar2,0);
                      uVar3 = LTLocalization.GetText("江湖散人",0,1,0);
                      uVar4 = new ByteReader(uVar3,0);
                      if (lVar2 != null) {
                        FUN_181827900(lVar2,uVar4,DAT_181d878e8);
                        lVar2 = *(int64 *)(*(int64 *)(DAT_181d4e010 + 184) + 32);
                        if ((lVar2 != null) && (lVar2 = *(int64 *)(lVar2 + 208)) != null) {
                          lVar2 = FUN_1808acf30(lVar2,DAT_181d94200);
                          if (lVar2 != null) {
                            ValueCollection.GetEnumerator(&local_28,lVar2,DAT_181d56968);
                            local_40 = local_28;
                            uStack_3c = uStack_24;
                            uStack_38 = uStack_20;
                            uStack_34 = uStack_1c;
                            local_30 = local_18;
        LAB_180b37de0:
                            do {
                              cVar1 = FUN_1811d7520(&local_40,DAT_181d71cb8);
                              lVar2 = local_30;
                              if (!cVar1) {
                                ZhSegment.Initialize(&local_40,DAT_181d71c38);
                                return;
                              }
                              if (*(int *)(pStatics + 8) == 1) {
                                lVar5 = *(int64 *)(pStatics + 32);
                                if (lVar2 == null) {
                          // WARNING: Subroutine does not return
                                  FUN_1800d6620();
                                }
                                if (lVar5 == null) {
                          // WARNING: Subroutine does not return
                                  FUN_1800d6620();
                                }
                                cVar1 = FUN_181815240(lVar5,*(uint32 *)(lVar2 + 16),DAT_181d67bf8);
                                if (!cVar1) {
                                  if (this.forceIDFliterObj == null) {
                          // WARNING: Subroutine does not return
                                    FUN_1800d6620();
                                  }
                                  lVar2 = GameObject.get_transform(this.forceIDFliterObj,0);
                                  if (lVar2 == null) {
                          // WARNING: Subroutine does not return
                                    FUN_1800d6620();
                                  }
                                  lVar2 = Component.GetComponent(lVar2,DAT_181d6b540);
                                  if (lVar2 == null) {
                          // WARNING: Subroutine does not return
                                    FUN_1800d6620();
                                  }
                                  lVar2 = Dropdown.get_options(lVar2,0);
                                  uVar3 = new ByteReader("???",0);
                                  if (lVar2 == null) {
                          // WARNING: Subroutine does not return
                                    FUN_1800d6620();
                                  }
                                  FUN_181827900(lVar2,uVar3,DAT_181d878e8);
                                  goto LAB_180b37de0;
                                }
                              }
                              if (this.forceIDFliterObj == null) {
                          // WARNING: Subroutine does not return
                                FUN_1800d6620();
                              }
                              lVar5 = GameObject.get_transform(this.forceIDFliterObj,0);
                              if (lVar5 == null) {
                          // WARNING: Subroutine does not return
                                FUN_1800d6620();
                              }
                              lVar5 = Component.GetComponent(lVar5,DAT_181d6b540);
                              if (lVar5 == null) {
                          // WARNING: Subroutine does not return
                                FUN_1800d6620();
                              }
                              lVar5 = Dropdown.get_options(lVar5,0);
                              if (lVar2 == null) {
                          // WARNING: Subroutine does not return
                                FUN_1800d6620();
                              }
                              uVar3 = LTLocalization.GetText(*(uint64 *)(lVar2 + 24),0,1,0);
                              uVar4 = new ByteReader(uVar3,0);
                              if (lVar5 == null) {
                          // WARNING: Subroutine does not return
                                FUN_1800d6620();
                              }
                              FUN_181827900(lVar5,uVar4,DAT_181d878e8);
                            } while( true );
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

    // Token : 0x60017B9
    // RVA   : 0xB37220   Offset: 0xB35A20   Length: 0x12D
    public void AddHeroIcon(HeroData target)
    {
        var pStatics = *(int64*)(DAT_181d4e188 + 184);
        ulong uVar1;
        ulong uVar2;
        long lVar3;
        if (!this.inited) {
          return;
        }
        uVar2 = this.heroSearchList;
        if (*pStatics != 0) {
          uVar1 = *(uint64 *)(*pStatics + 144);
          uVar2 = GlobalData.AddChild(uVar2,uVar1,0);
          this.temp = uVar2;
          if ((this.temp != null) &&
             (lVar3 = GameObject.GetComponent(this.temp,DAT_181d9fb20)) != null)
          {
            *(uint64 *)(lVar3 + 32) = target;
            if ((this.temp != null) &&
               (lVar3 = GameObject.GetComponent(this.temp,DAT_181d9fb20)) != null
               ) {
              *(uint32 *)(lVar3 + 24) = 0;
              return;
            }
          }
        }
    }

    // Token : 0x60017BA
    // RVA   : 0xB37430   Offset: 0xB35C30   Length: 0x2B4
    public void EditHeroName()
    {
        long lVar1;
        long lVar4;
        ulong uVar5;
        ushort uVar6;
        ushort uVar7;
        if (**(int **)(DAT_181d4ef00 + 184) == 1) {
          lVar1 = new c.DisplayClass9_0(0);
          if ((this.heroSearchNameInputField != null) && (lVar1 != null)) {
            *(uint64 *)(lVar1 + 16) = *(uint64 *)(this.heroSearchNameInputField + 0x170);
            *(uint8 *)(lVar1 + 24) = *(uint8 *)(*(int64 *)(DAT_181d4ef00 + 184) + 128);
            plVar2 = (int64 *)rail_api.RailFactory(0);
            if (plVar2 != (int64 *)0) {
              lVar4 = *plVar2;
              uVar7 = 0;
              if (*(uint16 *)(lVar4 + 0x12a) != 0) {
                uVar6 = uVar7;
                do {
                  if (*(int64 *)(*(int64 *)(lVar4 + 176) + (uint64)uVar6 * 16) ==
                      DAT_181d56638) {
                    puVar3 = (uint64 *)
                             ((int64)
                              *(int *)(*(int64 *)(lVar4 + 176) + 8 + (uint64)uVar6 * 16) * 16 +
                              0x248 + lVar4);
                    goto LAB_180b375cf;
                  }
                  uVar6 = uVar6 + 1;
                } while (uVar6 < *(uint16 *)(lVar4 + 0x12a));
              }
              puVar3 = (uint64 *)FUN_1800914f0(plVar2,DAT_181d56638,17);
        LAB_180b375cf:
              plVar2 = (int64 *)(*(code *)*puVar3)(plVar2,puVar3[1]);
              uVar5 = "";
              if (plVar2 != (int64 *)0) {
                lVar4 = *plVar2;
                if (*(uint16 *)(lVar4 + 0x12a) != 0) {
                  do {
                    if (*(int64 *)(*(int64 *)(lVar4 + 176) + (uint64)uVar7 * 16) ==
                        DAT_181d57ca8) {
                      puVar3 = (uint64 *)
                               ((int64)
                                *(int *)(*(int64 *)(lVar4 + 176) + 8 + (uint64)uVar7 * 16) * 16
                                + 0x1f8 + lVar4);
                      goto LAB_180b37637;
                    }
                    uVar7 = uVar7 + 1;
                  } while (uVar7 < *(uint16 *)(lVar4 + 0x12a));
                }
                puVar3 = (uint64 *)FUN_1800914f0(plVar2,DAT_181d57ca8,12);
        LAB_180b37637:
                          // WARNING: Could not recover jumptable at 0x000180b37658. Too many branches
                          // WARNING: Treating indirect jump as call
                (*(code *)*puVar3)(plVar2,lVar1,uVar5,puVar3[1]);
                return;
              }
            }
          }
        }
        else {
          lVar1 = this.heroSearchNameInputField;
          lVar4 = CISFilterWordsSDK.get_Instance(0);
          if ((this.heroSearchNameInputField != null) && (lVar4 != null)) {
            uVar5 = CISFilterWordsSDK.FilterReplaceWithChar
                              (lVar4,*(uint64 *)(this.heroSearchNameInputField + 0x170),42,0);
            if (lVar1 != null) {
              InputField.set_text(lVar1,uVar5,0);
              return;
            }
          }
        }
    }

    // Token : 0x60017BB
    // RVA   : 0xB38240   Offset: 0xB36A40   Length: 0xA0
    public void OnEditHeroNameFliterResult(RAILEventID id, EventBase data)
    {
        void HeroSearchController.OnEditHeroNameFliterResult
                     (int64 this,int id,int64 *data)
        {
        if (data != (int64 *)0) {
          if (((int)data[2] == 0) && (id == 0x1f45)) {
            if (this.heroSearchNameInputField == null) throw; // [null/range check failed]
            InputField.set_text(this.heroSearchNameInputField,data[8],0);
          }
          return;
        }
    }

    // Token : 0x60017BC
    // RVA   : 0xB376F0   Offset: 0xB35EF0   Length: 0x7
    public void FinishEditSearchHeroName()
    {
        void FUN_180b376f0(uint64 this)
        {
        HeroSearchController.RegenerateHeroIcon(this,0);
    }

    // Token : 0x60017BD
    // RVA   : 0xB38030   Offset: 0xB36830   Length: 0x201
    public void InterestingStarFliterButtonClicked()
    {
        long lVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        this.interestingStarFliter = !this.interestingStarFliter;
        if (this.heroSearchPanel != null) {
          lVar2 = GameObject.get_transform(this.heroSearchPanel,0);
          if (lVar2 != null) {
            lVar2 = Transform.Find(lVar2,"HeroSearchRoot",0);
            if (lVar2 != null) {
              lVar2 = Transform.Find(lVar2,"InterestingStarFliter",0);
              if (lVar2 != null) {
                lVar2 = Component.GetComponent(lVar2,DAT_181d6bc40);
                uVar4 = "UIAtlas";
                lVar1 = **(int64 **)(DAT_181d86270 + 184);
                uVar3 = "已收藏";
                if (!this.interestingStarFliter) {
                  uVar3 = "未收藏";
                }
                uVar3 = String.Concat("收藏-",uVar3,0);
                if (lVar1 != null) {
                  uVar4 = TextureController.LoadAtlasSprite(lVar1,uVar4,uVar3,0);
                  if (lVar2 != null) {
                    Image.set_sprite(lVar2,uVar4,0);
                    HeroSearchController.RegenerateHeroIcon(this,0);
                    plVar5 = (int64 *)Resources.Load("Sound/SoundEffect/Button/TabButton",0);
                    plVar6 = (int64 *)0;
                    if ((plVar5 != (int64 *)0) && (*plVar5 == DAT_181d8a228)) {
                      plVar6 = plVar5;
                    }
                    NGUITools.PlaySound(plVar6,0);
                    return;
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x60017BE
    // RVA   : 0xB37700   Offset: 0xB35F00   Length: 0x12F
    public void ForceIDFliterChanged()
    {
        long lVar1;
        if (this.heroSearchPanel != null) {
          lVar1 = GameObject.get_transform(this.heroSearchPanel,0);
          if (lVar1 != null) {
            lVar1 = Transform.Find(lVar1,"HeroSearchRoot",0);
            if (lVar1 != null) {
              lVar1 = Transform.Find(lVar1,"ForceIDFliter",0);
              if (lVar1 != null) {
                lVar1 = Component.GetComponent(lVar1,DAT_181d6b540);
                if (lVar1 != null) {
                  this.forceIDFliter = *(int *)(lVar1 + 0x120) + -2;
                  HeroSearchController.RegenerateHeroIcon(this,0);
                  plVar2 = (int64 *)Resources.Load("Sound/SoundEffect/Button/TabButton",0);
                  plVar3 = (int64 *)0;
                  if ((plVar2 != (int64 *)0) && (*plVar2 == DAT_181d8a228)) {
                    plVar3 = plVar2;
                  }
                  NGUITools.PlaySound(plVar3,0);
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x60017BF
    // RVA   : 0xB391E0   Offset: 0xB379E0   Length: 0x131
    public void SexFliterClicked(GameObject buttonClicked)
    {
        long lVar1;
        uint uVar2;
        ulong uVar3;
        long lVar4;
        lVar1 = this.sexFliter;
        if (buttonClicked != null) {
          uVar3 = Object.get_name(buttonClicked,0);
          uVar2 = Int32.Parse(uVar3,0);
          lVar4 = GameObject.GetComponent(buttonClicked,DAT_181da2130);
          if ((lVar4 != null) && (lVar1 != null)) {
            FUN_181814bb0(lVar1,uVar2,*(uint8 *)(lVar4 + 0x118),DAT_181d58f90);
            HeroSearchController.RefreshFliter(this,0);
            plVar5 = (int64 *)Resources.Load("Sound/SoundEffect/Button/TabButton",0);
            plVar6 = (int64 *)0;
            if ((plVar5 != (int64 *)0) && (*plVar5 == DAT_181d8a228)) {
              plVar6 = plVar5;
            }
            NGUITools.PlaySound(plVar6,0);
            return;
          }
        }
    }

    // Token : 0x60017C0
    // RVA   : 0xB37830   Offset: 0xB36030   Length: 0x131
    public void ForceLvFliterClicked(GameObject buttonClicked)
    {
        long lVar1;
        uint uVar2;
        ulong uVar3;
        long lVar4;
        lVar1 = this.forceLvFliter;
        if (buttonClicked != null) {
          uVar3 = Object.get_name(buttonClicked,0);
          uVar2 = Int32.Parse(uVar3,0);
          lVar4 = GameObject.GetComponent(buttonClicked,DAT_181da2130);
          if ((lVar4 != null) && (lVar1 != null)) {
            FUN_181814bb0(lVar1,uVar2,*(uint8 *)(lVar4 + 0x118),DAT_181d58f90);
            HeroSearchController.RefreshFliter(this,0);
            plVar5 = (int64 *)Resources.Load("Sound/SoundEffect/Button/TabButton",0);
            plVar6 = (int64 *)0;
            if ((plVar5 != (int64 *)0) && (*plVar5 == DAT_181d8a228)) {
              plVar6 = plVar5;
            }
            NGUITools.PlaySound(plVar6,0);
            return;
          }
        }
    }

    // Token : 0x60017C1
    // RVA   : 0xB39320   Offset: 0xB37B20   Length: 0x131
    public void SpeFliterClicked(GameObject buttonClicked)
    {
        long lVar1;
        uint uVar2;
        ulong uVar3;
        long lVar4;
        lVar1 = this.speFliter;
        if (buttonClicked != null) {
          uVar3 = Object.get_name(buttonClicked,0);
          uVar2 = Int32.Parse(uVar3,0);
          lVar4 = GameObject.GetComponent(buttonClicked,DAT_181da2130);
          if ((lVar4 != null) && (lVar1 != null)) {
            FUN_181814bb0(lVar1,uVar2,*(uint8 *)(lVar4 + 0x118),DAT_181d58f90);
            HeroSearchController.RefreshFliter(this,0);
            plVar5 = (int64 *)Resources.Load("Sound/SoundEffect/Button/TabButton",0);
            plVar6 = (int64 *)0;
            if ((plVar5 != (int64 *)0) && (*plVar5 == DAT_181d8a228)) {
              plVar6 = plVar5;
            }
            NGUITools.PlaySound(plVar6,0);
            return;
          }
        }
    }

    // Token : 0x60017C2
    // RVA   : 0xB38D10   Offset: 0xB37510   Length: 0x4C2
    public void RegenerateHeroIcon()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        bool cVar1;
        long lVar2;
        ulong uVar3;
        int iVar4;
        uVar3 = this.heroSearchList;
        GlobalData.DeleteAllChild(uVar3,0);
        if (this.heroSearchNameInputField != null) {
          cVar1 = FUN_1816fd990(*(uint64 *)(this.heroSearchNameInputField + 0x170),"",0);
          if ((!cVar1) || (this.interestingStarFliter)) {
            iVar4 = 0;
            bVar5 = false;
          }
          else {
            iVar4 = 0;
            bVar5 = this.forceIDFliter == -2;
          }
          do {
            if (((*pStatics == 0) ||
                (lVar2 = *(int64 *)(*pStatics + 32)) == null) ||
               (lVar2 = *(int64 *)(lVar2 + 80)) == null) break;
            if (*(int *)(lVar2 + 24) <= iVar4) {
              HeroSearchController.RefreshFliter(this,0);
              return;
            }
            lVar2 = FUN_18046c0a0(0);
            if (((lVar2 == null) || (*(int64 *)(lVar2 + 32) == 0)) ||
               (lVar2 = *(int64 *)(*(int64 *)(lVar2 + 32) + 80)) == null) break;
            lVar2 = FUN_180002f80(lVar2,iVar4,DAT_181d643f8);
            if (lVar2 != null) {
              lVar2 = FUN_18046c0a0(0);
              if (((lVar2 == null) || (*(int64 *)(lVar2 + 32) == 0)) ||
                 (lVar2 = *(int64 *)(*(int64 *)(lVar2 + 32) + 80)) == null) break;
              lVar2 = FUN_180002f80(lVar2,iVar4,DAT_181d643f8);
              if (lVar2 == null) break;
              if ((*(char *)(lVar2 + 96) == false) && (!bVar5)) {
                lVar2 = FUN_18046c0a0(0);
                if (((lVar2 == null) || (*(int64 *)(lVar2 + 32) == 0)) ||
                   (lVar2 = *(int64 *)(*(int64 *)(lVar2 + 32) + 80)) == null) break;
                lVar2 = FUN_180002f80(lVar2,iVar4,DAT_181d643f8);
                if (((lVar2 == null) || (this.heroSearchNameInputField == null)) ||
                   (*(int64 *)(lVar2 + 104) == 0)) break;
                cVar1 = String.Contains(*(int64 *)(lVar2 + 104),
                                         *(uint64 *)(this.heroSearchNameInputField + 0x170),0);
                if (!cVar1) {
                  lVar2 = FUN_18046c0a0(0);
                  if (((lVar2 == null) || (*(int64 *)(lVar2 + 32) == 0)) ||
                     (lVar2 = *(int64 *)(*(int64 *)(lVar2 + 32) + 80)) == null) break;
                  lVar2 = FUN_180002f80(lVar2,iVar4,DAT_181d643f8);
                  if (lVar2 == null) break;
                  lVar2 = LTLocalization.GetText(*(uint64 *)(lVar2 + 104),0,1,0);
                  if ((this.heroSearchNameInputField == null) || (lVar2 == null)) break;
                  cVar1 = String.Contains(lVar2,*(uint64 *)(this.heroSearchNameInputField + 0x170),0)
                  ;
                  if (!cVar1) goto LAB_180b391ad;
                }
                if (this.interestingStarFliter) {
                  lVar2 = FUN_18046c0a0(0);
                  if (((lVar2 == null) || (*(int64 *)(lVar2 + 32) == 0)) ||
                     (lVar2 = *(int64 *)(*(int64 *)(lVar2 + 32) + 80)) == null) break;
                  lVar2 = FUN_180002f80(lVar2,iVar4,DAT_181d643f8);
                  if (lVar2 == null) break;
                  if (*(char *)(lVar2 + 48) == false) goto LAB_180b391ad;
                }
                if (this.forceIDFliter != -2) {
                  lVar2 = FUN_18046c0a0(0);
                  if (((lVar2 == null) || (*(int64 *)(lVar2 + 32) == 0)) ||
                     (lVar2 = *(int64 *)(*(int64 *)(lVar2 + 32) + 80)) == null) break;
                  lVar2 = FUN_180002f80(lVar2,iVar4,DAT_181d643f8);
                  if (lVar2 == null) break;
                  if (*(int *)(lVar2 + 132) != this.forceIDFliter) goto LAB_180b391ad;
                }
                lVar2 = FUN_18046c0a0(0);
                if (((lVar2 == null) || (*(int64 *)(lVar2 + 32) == 0)) ||
                   (lVar2 = *(int64 *)(*(int64 *)(lVar2 + 32) + 80)) == null) break;
                uVar3 = FUN_180002f80(lVar2,iVar4,DAT_181d643f8);
                HeroSearchController.AddHeroIcon(this,uVar3,0);
              }
            }
        LAB_180b391ad:
            iVar4 = iVar4 + 1;
          } while( true );
        }
    }

    // Token : 0x60017C3
    // RVA   : 0xB385E0   Offset: 0xB36DE0   Length: 0x728
    public void RefreshFliter()
    {
        bool cVar1;
        int iVar2;
        long lVar3;
        long lVar4;
        ulong uVar5;
        if (this.heroSearchNameInputField != null) {
          cVar1 = FUN_1816fd990(*(uint64 *)(this.heroSearchNameInputField + 0x170),"",0);
          if ((!cVar1) || (this.interestingStarFliter)) {
            bVar6 = false;
          }
          else {
            bVar6 = this.forceIDFliter == -2;
          }
          if ((this.heroSearchList != null) &&
             (lVar3 = GameObject.get_transform(this.heroSearchList,0)) != null) {
            iVar2 = Transform.get_childCount(lVar3,0);
        joined_r0x000180b3869d:
            while( true ) {
              iVar2 = iVar2 + -1;
              if (iVar2 < 0) {
                return;
              }
              if ((((this.heroSearchList == null) ||
                   (lVar3 = GameObject.get_transform(this.heroSearchList,0)) == null) ||
                  (lVar3 = Transform.GetChild(lVar3,iVar2,0)) == null) ||
                 (lVar3 = Component.GetComponent(lVar3,DAT_181d6b8c0)) == null) throw; // [null/range check failed]
              lVar4 = this.heroSearchList;
              if (*(int64 *)(lVar3 + 32) != 0) break;
              if (((lVar4 == null) || (lVar3 = GameObject.get_transform(lVar4,0)) == null) ||
                 (lVar3 = Transform.GetChild(lVar3,iVar2,0)) == null) throw; // [null/range check failed]
              uVar5 = Component.get_gameObject(lVar3);
              Object.Destroy(uVar5);
            }
            if ((((lVar4 == null) || (lVar3 = GameObject.get_transform(lVar4,0)) == null) ||
                (lVar3 = Transform.GetChild(lVar3,iVar2,0)) == null) ||
               ((lVar3 = Component.GetComponent(lVar3,DAT_181d6b8c0), lVar3 == null ||
                (*(int64 *)(lVar3 + 32) == 0)))) throw; // [null/range check failed]
            if ((*(char *)(*(int64 *)(lVar3 + 32) + 96) == false) && (!bVar6)) {
              if ((((this.heroSearchList == null) ||
                   (lVar3 = GameObject.get_transform(this.heroSearchList,0)) == null) ||
                  (lVar3 = Transform.GetChild(lVar3,iVar2,0)) == null) ||
                 ((((lVar3 = Component.GetComponent(lVar3,DAT_181d6b8c0), lVar3 == null ||
                    (*(int64 *)(lVar3 + 32) == 0)) || (this.heroSearchNameInputField == null)) ||
                  (lVar3 = *(int64 *)(*(int64 *)(lVar3 + 32) + 104)) == null)))
              throw; // [null/range check failed]
              cVar1 = String.Contains(lVar3,*(uint64 *)(this.heroSearchNameInputField + 0x170));
              if (!cVar1) {
                if ((this.heroSearchList == null) ||
                   (lVar3 = GameObject.get_transform(this.heroSearchList,0)) == null)
                throw; // [null/range check failed]
                lVar3 = Transform.GetChild(lVar3,iVar2,0);
                if ((lVar3 == null) ||
                   ((lVar3 = Component.GetComponent(lVar3,DAT_181d6b8c0), lVar3 == null ||
                    (*(int64 *)(lVar3 + 32) == 0)))) throw; // [null/range check failed]
                lVar3 = LTLocalization.GetText(*(uint64 *)(*(int64 *)(lVar3 + 32) + 104),0,1,0)
                ;
                if ((this.heroSearchNameInputField == null) || (lVar3 == null)) throw; // [null/range check failed]
                cVar1 = String.Contains(lVar3,*(uint64 *)(this.heroSearchNameInputField + 0x170));
                if (!cVar1) goto LAB_180b38be0;
              }
              if (this.interestingStarFliter) {
                if ((((this.heroSearchList == null) ||
                     (lVar3 = GameObject.get_transform(this.heroSearchList,0)) == null) ||
                    (lVar3 = Transform.GetChild(lVar3,iVar2,0)) == null) ||
                   ((lVar3 = Component.GetComponent(lVar3,DAT_181d6b8c0), lVar3 == null ||
                    (*(int64 *)(lVar3 + 32) == 0)))) throw; // [null/range check failed]
                if (*(char *)(*(int64 *)(lVar3 + 32) + 48) == false) goto LAB_180b38be0;
              }
              if (this.forceIDFliter != -2) {
                if (((this.heroSearchList == null) ||
                    (lVar3 = GameObject.get_transform(this.heroSearchList,0)) == null) ||
                   ((lVar3 = Transform.GetChild(lVar3,iVar2,0), lVar3 == null ||
                    ((lVar3 = Component.GetComponent(lVar3,DAT_181d6b8c0), lVar3 == null ||
                     (*(int64 *)(lVar3 + 32) == 0)))))) throw; // [null/range check failed]
                if (*(int *)(*(int64 *)(lVar3 + 32) + 132) != this.forceIDFliter)
                goto LAB_180b38be0;
              }
              if ((((this.heroSearchList == null) ||
                   (lVar3 = GameObject.get_transform(this.heroSearchList,0)) == null) ||
                  (lVar3 = Transform.GetChild(lVar3,iVar2,0)) == null) ||
                 ((lVar3 = Component.GetComponent(lVar3,DAT_181d6b8c0), lVar3 == null ||
                  (*(int64 *)(lVar3 + 32) == 0)))) throw; // [null/range check failed]
              lVar4 = this.sexFliter;
              if (*(char *)(*(int64 *)(lVar3 + 32) + 128) == false) {
                if (lVar4 == null) throw; // [null/range check failed]
                if (lVar4.Count == null) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                cVar1 = *(char *)(lVar4._items + 32);
              }
              else {
                if (lVar4 == null) throw; // [null/range check failed]
                if (lVar4.Count < 2) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                cVar1 = *(char *)(lVar4._items + 33);
              }
              if (cVar1) {
                lVar3 = this.forceLvFliter;
                if (((this.heroSearchList == null) ||
                    (lVar4 = GameObject.get_transform(this.heroSearchList,0)) == null) ||
                   ((lVar4 = Transform.GetChild(lVar4,iVar2,0), lVar4 == null ||
                    (((lVar4 = Component.GetComponent(lVar4,DAT_181d6b8c0), lVar4 == null ||
                      (*(int64 *)(lVar4 + 32) == 0)) || (lVar3 == null)))))) throw; // [null/range check failed]
                cVar1 = FUN_180132d10(lVar3,*(uint32 *)(*(int64 *)(lVar4 + 32) + 184));
                if (cVar1) {
                  if (((this.heroSearchList == null) ||
                      (lVar3 = GameObject.get_transform(this.heroSearchList,0)) == null) ||
                     ((lVar3 = Transform.GetChild(lVar3,iVar2,0), lVar3 == null ||
                      ((lVar3 = Component.GetComponent(lVar3,DAT_181d6b8c0), lVar3 == null ||
                       (*(int64 *)(lVar3 + 32) == 0)))))) throw; // [null/range check failed]
                  lVar4 = this.speFliter;
                  if (*(char *)(*(int64 *)(lVar3 + 32) + 92) == false) {
                    if (lVar4 == null) throw; // [null/range check failed]
                    if (lVar4.Count < 2) {
                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                    }
                    cVar1 = *(char *)(lVar4._items + 33);
                  }
                  else {
                    if (lVar4 == null) throw; // [null/range check failed]
                    if (lVar4.Count == null) {
                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                    }
                    cVar1 = *(char *)(lVar4._items + 32);
                  }
                  if (cVar1) {
                    if ((((this.heroSearchList == null) ||
                         (lVar3 = GameObject.get_transform(this.heroSearchList,0)) == null)
                        || (lVar3 = Transform.GetChild(lVar3,iVar2,0)) == null) ||
                       (lVar3 = Component.get_gameObject(lVar3)) == null) throw; // [null/range check failed]
                    cVar1 = GameObject.get_activeSelf(lVar3);
                    if (!cVar1) {
                      if (((this.heroSearchList == null) ||
                          (lVar3 = GameObject.get_transform(this.heroSearchList,0)) == null
                          ) || ((lVar3 = Transform.GetChild(lVar3,iVar2,0), lVar3 == null ||
                                (lVar3 = Component.get_gameObject(lVar3,0)) == null)))
                      throw; // [null/range check failed]
                      GameObject.SetActive(lVar3);
                    }
                    goto joined_r0x000180b3869d;
                  }
                }
              }
            }
        LAB_180b38be0:
            if (((this.heroSearchList == null) ||
                (lVar3 = GameObject.get_transform(this.heroSearchList,0)) == null) ||
               ((lVar3 = Transform.GetChild(lVar3,iVar2,0), lVar3 == null ||
                (lVar3 = Component.get_gameObject(lVar3)) == null))) throw; // [null/range check failed]
            cVar1 = GameObject.get_activeSelf(lVar3);
            if (cVar1) {
              if ((((this.heroSearchList == null) ||
                   (lVar3 = GameObject.get_transform(this.heroSearchList,0)) == null) ||
                  (lVar3 = Transform.GetChild(lVar3,iVar2,0)) == null) ||
                 (lVar3 = Component.get_gameObject(lVar3)) == null) throw; // [null/range check failed]
              GameObject.SetActive(lVar3);
            }
            goto joined_r0x000180b3869d;
          }
        }
    }

    // Token : 0x60017C4
    // RVA   : 0xB395C0   Offset: 0xB37DC0   Length: 0x1AD
    public void /*ctor*/()
    {
        long lVar1;
        this.forceIDFliter = 0xfffffffe;
        lVar1 = il2cpp_internal(DAT_181d6cb30);
        FUN_180f58a90(lVar1,DAT_181d58d10);
        if (lVar1 != null) {
          FUN_181805880(lVar1,1,DAT_181d58d90);
          FUN_181805880(lVar1,1,DAT_181d58d90);
          this.speFliter = lVar1;
          lVar1 = il2cpp_internal(DAT_181d6cb30);
          FUN_180f58a90(lVar1,DAT_181d58d10);
          if (lVar1 != null) {
            FUN_181805880(lVar1,1,DAT_181d58d90);
            FUN_181805880(lVar1,1,DAT_181d58d90);
            this.sexFliter = lVar1;
            lVar1 = il2cpp_internal(DAT_181d6cb30);
            FUN_180f58a90(lVar1,DAT_181d58d10);
            if (lVar1 != null) {
              FUN_181805880(lVar1,1,DAT_181d58d90);
              FUN_181805880(lVar1,1,DAT_181d58d90);
              FUN_181805880(lVar1,1,DAT_181d58d90);
              FUN_181805880(lVar1,1,DAT_181d58d90);
              FUN_181805880(lVar1,1,DAT_181d58d90);
              FUN_181805880(lVar1,1,DAT_181d58d90);
              this.forceLvFliter = lVar1;
              FUN_18044ef50(this,0);
              return;
            }
          }
        }
    }

    // Token : 0x60017C5
    // RVA   : 0x790570   Offset: 0x78ED70   Length: 0x20
    private void <HideHeroSearch>b__17_0()
    {
        if (this.heroSearchPanel != null) {
          GameObject.SetActive(this.heroSearchPanel,0,0);
          return;
        }
    }

}
