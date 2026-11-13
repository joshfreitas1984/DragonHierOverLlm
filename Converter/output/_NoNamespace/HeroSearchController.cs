// ============================================================
// Type  : HeroSearchController
// Token : 0x20002DC
// ============================================================

public class HeroSearchController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400179E
    public GameObject heroSearchPanel;

    // Token: 0x400179F
    public GameObject heroSearchList;

    // Token: 0x40017A0
    public GameObject forceIDFliterObj;

    // Token: 0x40017A1
    public InputField heroSearchNameInputField;

    // Token: 0x40017A2
    public bool interestingStarFliter;

    // Token: 0x40017A3
    public int forceIDFliter;

    // Token: 0x40017A4
    private List<bool> speFliter;

    // Token: 0x40017A5
    private List<bool> sexFliter;

    // Token: 0x40017A6
    private List<bool> forceLvFliter;

    // Token: 0x40017A7
    private bool inited;

    // Token: 0x40017A8
    private GameObject temp;

    // Token: 0x40017A9
    private static HeroSearchController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001873
    // RVA   : 0x89CD30   Offset: 0x89BB30   Length: 0x36
    public static HeroSearchController get_Instance()
    {
        return **(uint64 **)(DAT_181e55e18 + 184);
    }

    // Token : 0x6001874
    // RVA   : 0x89A870   Offset: 0x899670   Length: 0xD7
    private void Awake()
    {
        bool cVar2;
        ulong uVar3;
        uVar3 = **(uint64 **)(DAT_181e55e18 + 184);
        cVar2 = Object.op_Equality(uVar3,0,0);
        if (!cVar2) {
          uVar3 = Component.get_gameObject(this,0);
          Object.Destroy(uVar3,0);
          return;
        }
        puVar1 = *(uint64 **)(DAT_181e55e18 + 184);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x6001875
    // RVA   : 0x89CA20   Offset: 0x89B820   Length: 0x158
    private void Start()
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        if (**(int **)(DAT_181e538e8 + 184) == 1) {
          cVar1 = RailManager.get_Initialized(0);
          if (!cVar1) {
            Debug.LogError("Rail sdk is not initialized!",0);
            return;
          }
          lVar2 = RailCallBackHelper.get_Instance(0);
          uVar3 = new OnTooltipCB(this,DAT_181e5c3f8,0);
          if (lVar2 == null) {
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          RailCallBackHelper.RegisterCallback(lVar2,0x1f45,uVar3,0);
        }
    }

    // Token : 0x6001876
    // RVA   : 0x89B850   Offset: 0x89A650   Length: 0x2ED
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
                plVar2 = (int64 *)Component.GetComponent(lVar1,DAT_181e777b8);
                if (this.heroSearchPanel != null) {
                  lVar1 = GameObject.get_transform(this.heroSearchPanel,0);
                  if (lVar1 != null) {
                    lVar1 = Transform.Find(lVar1,"BlackBackground",0);
                    if (lVar1 != null) {
                      plVar3 = (int64 *)Component.GetComponent(lVar1,DAT_181e777b8);
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
                                uVar5 = Component.GetComponent(lVar1,DAT_181e777b8);
                                uVar5 = DOTweenModuleUI.DOFade(uVar5,0x3f000000,0x3e800000,0);
                                TweenSettingsExtensions.SetUpdate(uVar5,1,DAT_181ea5848);
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
                                          TweenSettingsExtensions.SetUpdate(uVar5,1,DAT_181ea59e0);
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

    // Token : 0x6001877
    // RVA   : 0x89AE90   Offset: 0x899C90   Length: 0x194
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
              uVar2 = Component.GetComponent(lVar1,DAT_181e777b8);
              uVar2 = DOTweenModuleUI.DOFade(uVar2,0,0x3e4ccccd,0);
              TweenSettingsExtensions.SetUpdate(uVar2,1,DAT_181ea5848);
              if (this.heroSearchPanel != null) {
                lVar1 = GameObject.get_transform(this.heroSearchPanel,0);
                if (lVar1 != null) {
                  uVar2 = Transform.Find(lVar1,"HeroSearchRoot",0);
                  uVar2 = ShortcutExtensions.DOScaleX(uVar2,0,0x3e4ccccd,0);
                  uVar2 = TweenSettingsExtensions.SetUpdate(uVar2,1,DAT_181ea59e0);
                  uVar3 = new OnTooltipCB(this,DAT_181e5c370,0);
                  TweenSettingsExtensions.OnComplete(uVar2,uVar3,DAT_181ea3dc0);
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x6001878
    // RVA   : 0x89B030   Offset: 0x899E30   Length: 0x559
    public void Init()
    {
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
            lVar2 = Component.GetComponent(lVar2,DAT_181e770b8);
            if (lVar2 != null) {
              lVar2 = Dropdown.get_options(lVar2,0);
              uVar3 = LTLocalization.GetText("所有门派",0,1,0);
              uVar4 = new ByteReader(uVar3,0);
              if (lVar2 != null) {
                FUN_18175de30(lVar2,uVar4,DAT_181e91df0);
                if (this.forceIDFliterObj != null) {
                  lVar2 = GameObject.get_transform(this.forceIDFliterObj,0);
                  if (lVar2 != null) {
                    lVar2 = Component.GetComponent(lVar2,DAT_181e770b8);
                    if (lVar2 != null) {
                      lVar2 = Dropdown.get_options(lVar2,0);
                      uVar3 = LTLocalization.GetText("江湖散人",0,1,0);
                      uVar4 = new ByteReader(uVar3,0);
                      if (lVar2 != null) {
                        FUN_18175de30(lVar2,uVar4,DAT_181e91df0);
                        if (((GameController._instance != null) &&
                            (lVar2 = GameController._instance.worldData,
                            lVar2 != null)) && (lVar2 = lVar2.Forces) != null) {
                          FUN_1816629a0(&local_28,lVar2,DAT_181e6a378);
                          local_40 = local_28;
                          uStack_3c = uStack_24;
                          uStack_38 = uStack_20;
                          uStack_34 = uStack_1c;
                          local_30 = local_18;
        LAB_18089b310:
                          do {
                            cVar1 = FUN_1807b3f30(&local_40,DAT_181e6e0c0);
                            lVar2 = local_30;
                            if (!cVar1) {
                              ZhSegment.Initialize(&local_40,DAT_181e6e040);
                              return;
                            }
                            if (PlotController.fightSkillIndexCache == 1) {
                              lVar5 = PlotController.LeftFaceHideOffset;
                              if (lVar2 == null) {
                          // WARNING: Subroutine does not return
                                FUN_1801e0300();
                              }
                              if (lVar5 == null) {
                          // WARNING: Subroutine does not return
                                FUN_1801e0300();
                              }
                              cVar1 = FUN_18176a2d0(lVar5,lVar2.chapter,DAT_181e71570);
                              if (!cVar1) {
                                if (this.forceIDFliterObj == null) {
                          // WARNING: Subroutine does not return
                                  FUN_1801e0300();
                                }
                                lVar2 = GameObject.get_transform(this.forceIDFliterObj,0);
                                if (lVar2 == null) {
                          // WARNING: Subroutine does not return
                                  FUN_1801e0300();
                                }
                                lVar2 = Component.GetComponent(lVar2,DAT_181e770b8);
                                if (lVar2 == null) {
                          // WARNING: Subroutine does not return
                                  FUN_1801e0300();
                                }
                                lVar2 = Dropdown.get_options(lVar2,0);
                                uVar3 = new ByteReader("???",0);
                                if (lVar2 == null) {
                          // WARNING: Subroutine does not return
                                  FUN_1801e0300();
                                }
                                FUN_18175de30(lVar2,uVar3);
                                goto LAB_18089b310;
                              }
                            }
                            if (this.forceIDFliterObj == null) {
                          // WARNING: Subroutine does not return
                              FUN_1801e0300();
                            }
                            lVar5 = GameObject.get_transform(this.forceIDFliterObj,0);
                            if (lVar5 == null) {
                          // WARNING: Subroutine does not return
                              FUN_1801e0300();
                            }
                            lVar5 = Component.GetComponent(lVar5,DAT_181e770b8);
                            if (lVar5 == null) {
                          // WARNING: Subroutine does not return
                              FUN_1801e0300();
                            }
                            lVar5 = Dropdown.get_options(lVar5,0);
                            if (lVar2 == null) {
                          // WARNING: Subroutine does not return
                              FUN_1801e0300();
                            }
                            uVar3 = ForceData.GetForceName(lVar2,1,0);
                            uVar3 = LTLocalization.GetText(uVar3,0,1,0);
                            uVar4 = new ByteReader(uVar3,0);
                            if (lVar5 == null) {
                          // WARNING: Subroutine does not return
                              FUN_1801e0300();
                            }
                            FUN_18175de30(lVar5,uVar4);
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

    // Token : 0x6001879
    // RVA   : 0x89A740   Offset: 0x899540   Length: 0x12D
    public void AddHeroIcon(HeroData target)
    {
        var pStatics = *(int64*)(DAT_181e52a90 + 184);
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
             (lVar3 = GameObject.GetComponent(this.temp,DAT_181e54c18)) != null)
          {
            *(uint64 *)(lVar3 + 32) = target;
            if ((this.temp != null) &&
               (lVar3 = GameObject.GetComponent(this.temp,DAT_181e54c18)) != null
               ) {
              *(uint32 *)(lVar3 + 24) = 0;
              return;
            }
          }
        }
    }

    // Token : 0x600187A
    // RVA   : 0x89A950   Offset: 0x899750   Length: 0x2B4
    public void EditHeroName()
    {
        long lVar1;
        long lVar4;
        ulong uVar5;
        ushort uVar6;
        ushort uVar7;
        if (**(int **)(DAT_181e538e8 + 184) == 1) {
          lVar1 = new c.DisplayClass9_0(0);
          if ((this.heroSearchNameInputField != null) && (lVar1 != null)) {
            *(uint64 *)(lVar1 + 16) = *(uint64 *)(this.heroSearchNameInputField + 0x170);
            *(uint8 *)(lVar1 + 24) = *(uint8 *)(*(int64 *)(DAT_181e538e8 + 184) + 128);
            plVar2 = (int64 *)rail_api.RailFactory(0);
            if (plVar2 != (int64 *)0) {
              lVar4 = *plVar2;
              uVar7 = 0;
              if (*(uint16 *)(lVar4 + 0x12a) != 0) {
                uVar6 = uVar7;
                do {
                  if (*(int64 *)(*(int64 *)(lVar4 + 176) + (uint64)uVar6 * 16) ==
                      DAT_181e5b750) {
                    puVar3 = (uint64 *)
                             ((int64)
                              *(int *)(*(int64 *)(lVar4 + 176) + 8 + (uint64)uVar6 * 16) * 16 +
                              0x248 + lVar4);
                    goto LAB_18089aaef;
                  }
                  uVar6 = uVar6 + 1;
                } while (uVar6 < *(uint16 *)(lVar4 + 0x12a));
              }
              puVar3 = (uint64 *)FUN_18019b1f0(plVar2,DAT_181e5b750,17);
        LAB_18089aaef:
              plVar2 = (int64 *)(*(code *)*puVar3)(plVar2,puVar3[1]);
              uVar5 = "";
              if (plVar2 != (int64 *)0) {
                lVar4 = *plVar2;
                if (*(uint16 *)(lVar4 + 0x12a) != 0) {
                  do {
                    if (*(int64 *)(*(int64 *)(lVar4 + 176) + (uint64)uVar7 * 16) ==
                        DAT_181e5cf10) {
                      puVar3 = (uint64 *)
                               ((int64)
                                *(int *)(*(int64 *)(lVar4 + 176) + 8 + (uint64)uVar7 * 16) * 16
                                + 0x1f8 + lVar4);
                      goto LAB_18089ab57;
                    }
                    uVar7 = uVar7 + 1;
                  } while (uVar7 < *(uint16 *)(lVar4 + 0x12a));
                }
                puVar3 = (uint64 *)FUN_18019b1f0(plVar2,DAT_181e5cf10,12);
        LAB_18089ab57:
                          // WARNING: Could not recover jumptable at 0x00018089ab78. Too many branches
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

    // Token : 0x600187B
    // RVA   : 0x89B7A0   Offset: 0x89A5A0   Length: 0xA0
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

    // Token : 0x600187C
    // RVA   : 0x89AC10   Offset: 0x899A10   Length: 0x7
    public void FinishEditSearchHeroName()
    {
        void FUN_18089ac10(uint64 this)
        {
        HeroSearchController.RegenerateHeroIcon(this,0);
    }

    // Token : 0x600187D
    // RVA   : 0x89B590   Offset: 0x89A390   Length: 0x201
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
                lVar2 = Component.GetComponent(lVar2,DAT_181e777b8);
                uVar4 = "UIAtlas";
                lVar1 = **(int64 **)(DAT_181e8b8e8 + 184);
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
                    if ((plVar5 != (int64 *)0) && (*plVar5 == DAT_181e8f4a0)) {
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

    // Token : 0x600187E
    // RVA   : 0x89AC20   Offset: 0x899A20   Length: 0x12F
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
                lVar1 = Component.GetComponent(lVar1,DAT_181e770b8);
                if (lVar1 != null) {
                  this.forceIDFliter = *(int *)(lVar1 + 0x120) + -2;
                  HeroSearchController.RegenerateHeroIcon(this,0);
                  plVar2 = (int64 *)Resources.Load("Sound/SoundEffect/Button/TabButton",0);
                  plVar3 = (int64 *)0;
                  if ((plVar2 != (int64 *)0) && (*plVar2 == DAT_181e8f4a0)) {
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

    // Token : 0x600187F
    // RVA   : 0x89C7A0   Offset: 0x89B5A0   Length: 0x131
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
          lVar4 = GameObject.GetComponent(buttonClicked,DAT_181e57478);
          if ((lVar4 != null) && (lVar1 != null)) {
            FUN_18166b1c0(lVar1,uVar2,*(uint8 *)(lVar4 + 0x118),DAT_181e627f8);
            HeroSearchController.RefreshFliter(this,0);
            plVar5 = (int64 *)Resources.Load("Sound/SoundEffect/Button/TabButton",0);
            plVar6 = (int64 *)0;
            if ((plVar5 != (int64 *)0) && (*plVar5 == DAT_181e8f4a0)) {
              plVar6 = plVar5;
            }
            NGUITools.PlaySound(plVar6,0);
            return;
          }
        }
    }

    // Token : 0x6001880
    // RVA   : 0x89AD50   Offset: 0x899B50   Length: 0x131
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
          lVar4 = GameObject.GetComponent(buttonClicked,DAT_181e57478);
          if ((lVar4 != null) && (lVar1 != null)) {
            FUN_18166b1c0(lVar1,uVar2,*(uint8 *)(lVar4 + 0x118),DAT_181e627f8);
            HeroSearchController.RefreshFliter(this,0);
            plVar5 = (int64 *)Resources.Load("Sound/SoundEffect/Button/TabButton",0);
            plVar6 = (int64 *)0;
            if ((plVar5 != (int64 *)0) && (*plVar5 == DAT_181e8f4a0)) {
              plVar6 = plVar5;
            }
            NGUITools.PlaySound(plVar6,0);
            return;
          }
        }
    }

    // Token : 0x6001881
    // RVA   : 0x89C8E0   Offset: 0x89B6E0   Length: 0x131
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
          lVar4 = GameObject.GetComponent(buttonClicked,DAT_181e57478);
          if ((lVar4 != null) && (lVar1 != null)) {
            FUN_18166b1c0(lVar1,uVar2,*(uint8 *)(lVar4 + 0x118),DAT_181e627f8);
            HeroSearchController.RefreshFliter(this,0);
            plVar5 = (int64 *)Resources.Load("Sound/SoundEffect/Button/TabButton",0);
            plVar6 = (int64 *)0;
            if ((plVar5 != (int64 *)0) && (*plVar5 == DAT_181e8f4a0)) {
              plVar6 = plVar5;
            }
            NGUITools.PlaySound(plVar6,0);
            return;
          }
        }
    }

    // Token : 0x6001882
    // RVA   : 0x89C2A0   Offset: 0x89B0A0   Length: 0x4F8
    public void RegenerateHeroIcon()
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        int iVar4;
        uVar3 = this.heroSearchList;
        GlobalData.DeleteAllChild(uVar3,0);
        if (this.heroSearchNameInputField != null) {
          cVar1 = FUN_1816387f0(*(uint64 *)(this.heroSearchNameInputField + 0x170),"",0);
          if ((!cVar1) || (this.interestingStarFliter)) {
            iVar4 = 0;
            bVar5 = false;
          }
          else {
            iVar4 = 0;
            bVar5 = this.forceIDFliter == -2;
          }
          do {
            if (((GameController._instance == null) ||
                (lVar2 = GameController._instance.worldData) == null) ||
               (lVar2 = lVar2.Heros) == null) break;
            if (lVar2.cityAreaID <= iVar4) {
              HeroSearchController.RefreshFliter(this,0);
              return;
            }
            lVar2 = FUN_1802106e0(0);
            if (((lVar2 == null) || (lVar2.villageAreaID == null)) ||
               (lVar2 = *(int64 *)(lVar2.villageAreaID + 80)) == null) break;
            lVar2 = FUN_1800024b0(lVar2,iVar4,DAT_181e6dd70);
            if (lVar2 != null) {
              lVar2 = FUN_1802106e0(0);
              if (((lVar2 == null) || (lVar2.villageAreaID == null)) ||
                 (lVar2 = *(int64 *)(lVar2.villageAreaID + 80)) == null) break;
              lVar2 = FUN_1800024b0(lVar2,iVar4,DAT_181e6dd70);
              if (lVar2 == null) break;
              if ((!lVar2.BigMapRandomEventDatas) && (!bVar5)) {
                lVar2 = FUN_1802106e0(0);
                if (((lVar2 == null) || (lVar2.villageAreaID == null)) ||
                   (lVar2 = *(int64 *)(lVar2.villageAreaID + 80)) == null) break;
                lVar2 = FUN_1800024b0(lVar2,iVar4,DAT_181e6dd70);
                if (((lVar2 == null) || (this.heroSearchNameInputField == null)) ||
                   (lVar2.AreaMapRandomEventDatas == null)) break;
                cVar1 = String.Contains(lVar2.AreaMapRandomEventDatas,
                                         *(uint64 *)(this.heroSearchNameInputField + 0x170),0);
                if (!cVar1) {
                  lVar2 = FUN_1802106e0(0);
                  if (((lVar2 == null) || (lVar2.villageAreaID == null)) ||
                     (lVar2 = *(int64 *)(lVar2.villageAreaID + 80)) == null) break;
                  lVar2 = FUN_1800024b0(lVar2,iVar4,DAT_181e6dd70);
                  if (lVar2 == null) break;
                  uVar3 = lVar2.AreaMapRandomEventDatas;
                  lVar2 = LTLocalization.GetText(uVar3,0,1,0);
                  if ((this.heroSearchNameInputField == null) || (lVar2 == null)) break;
                  cVar1 = String.Contains(lVar2,*(uint64 *)(this.heroSearchNameInputField + 0x170),0)
                  ;
                  if (!cVar1) goto LAB_18089c76e;
                }
                if (this.interestingStarFliter) {
                  lVar2 = FUN_1802106e0(0);
                  if (((lVar2 == null) || (lVar2.villageAreaID == null)) ||
                     (lVar2 = *(int64 *)(lVar2.villageAreaID + 80)) == null) break;
                  lVar2 = FUN_1800024b0(lVar2,iVar4,DAT_181e6dd70);
                  if (lVar2 == null) break;
                  if (!lVar2.Areas) goto LAB_18089c76e;
                }
                if (this.forceIDFliter != -2) {
                  lVar2 = FUN_1802106e0(0);
                  if (((lVar2 == null) || (lVar2.villageAreaID == null)) ||
                     (lVar2 = *(int64 *)(lVar2.villageAreaID + 80)) == null) break;
                  lVar2 = FUN_1800024b0(lVar2,iVar4,DAT_181e6dd70);
                  if (lVar2 == null) break;
                  if (*(int *)(lVar2 + 132) != this.forceIDFliter) goto LAB_18089c76e;
                }
                lVar2 = FUN_1802106e0(0);
                if (((lVar2 == null) || (lVar2.villageAreaID == null)) ||
                   (lVar2 = *(int64 *)(lVar2.villageAreaID + 80)) == null) break;
                uVar3 = FUN_1800024b0(lVar2,iVar4,DAT_181e6dd70);
                HeroSearchController.AddHeroIcon(this,uVar3,0);
              }
            }
        LAB_18089c76e:
            iVar4 = iVar4 + 1;
          } while( true );
        }
    }

    // Token : 0x6001883
    // RVA   : 0x89BB40   Offset: 0x89A940   Length: 0x756
    public void RefreshFliter()
    {
        bool cVar1;
        int iVar2;
        long lVar3;
        long lVar4;
        ulong uVar5;
        if (this.heroSearchNameInputField != null) {
          cVar1 = FUN_1816387f0(*(uint64 *)(this.heroSearchNameInputField + 0x170),"",0);
          if ((!cVar1) || (this.interestingStarFliter)) {
            bVar6 = false;
          }
          else {
            bVar6 = this.forceIDFliter == -2;
          }
          if ((this.heroSearchList != null) &&
             (lVar3 = GameObject.get_transform(this.heroSearchList,0)) != null) {
            iVar2 = Transform.get_childCount(lVar3,0);
        joined_r0x00018089bc09:
            while( true ) {
              iVar2 = iVar2 + -1;
              if (iVar2 < 0) {
                return;
              }
              if ((((this.heroSearchList == null) ||
                   (lVar3 = GameObject.get_transform(this.heroSearchList,0)) == null) ||
                  (lVar3 = Transform.GetChild(lVar3,iVar2,0)) == null) ||
                 (lVar3 = Component.GetComponent(lVar3,DAT_181e77438)) == null) throw; // [null/range check failed]
              lVar4 = this.heroSearchList;
              if (*(int64 *)(lVar3 + 32) != 0) break;
              if (((lVar4 == null) || (lVar3 = GameObject.get_transform(lVar4,0)) == null) ||
                 (lVar3 = Transform.GetChild(lVar3,iVar2,0)) == null) throw; // [null/range check failed]
              uVar5 = Component.get_gameObject(lVar3);
              Object.Destroy(uVar5);
            }
            if ((((lVar4 == null) || (lVar3 = GameObject.get_transform(lVar4,0)) == null) ||
                (lVar3 = Transform.GetChild(lVar3,iVar2,0)) == null) ||
               ((lVar3 = Component.GetComponent(lVar3,DAT_181e77438), lVar3 == null ||
                (*(int64 *)(lVar3 + 32) == 0)))) throw; // [null/range check failed]
            if ((*(char *)(*(int64 *)(lVar3 + 32) + 96) == false) && (!bVar6)) {
              if ((((this.heroSearchList == null) ||
                   (lVar3 = GameObject.get_transform(this.heroSearchList,0)) == null) ||
                  (lVar3 = Transform.GetChild(lVar3,iVar2,0)) == null) ||
                 ((((lVar3 = Component.GetComponent(lVar3,DAT_181e77438), lVar3 == null ||
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
                   ((lVar3 = Component.GetComponent(lVar3,DAT_181e77438), lVar3 == null ||
                    (*(int64 *)(lVar3 + 32) == 0)))) throw; // [null/range check failed]
                uVar5 = *(uint64 *)(*(int64 *)(lVar3 + 32) + 104);
                lVar3 = LTLocalization.GetText(uVar5,0,1,0);
                if ((this.heroSearchNameInputField == null) || (lVar3 == null)) throw; // [null/range check failed]
                cVar1 = String.Contains(lVar3,*(uint64 *)(this.heroSearchNameInputField + 0x170));
                if (!cVar1) goto LAB_18089c16e;
              }
              if (this.interestingStarFliter) {
                if ((((this.heroSearchList == null) ||
                     (lVar3 = GameObject.get_transform(this.heroSearchList,0)) == null) ||
                    (lVar3 = Transform.GetChild(lVar3,iVar2,0)) == null) ||
                   ((lVar3 = Component.GetComponent(lVar3,DAT_181e77438), lVar3 == null ||
                    (*(int64 *)(lVar3 + 32) == 0)))) throw; // [null/range check failed]
                if (*(char *)(*(int64 *)(lVar3 + 32) + 48) == false) goto LAB_18089c16e;
              }
              if (this.forceIDFliter != -2) {
                if (((this.heroSearchList == null) ||
                    (lVar3 = GameObject.get_transform(this.heroSearchList,0)) == null) ||
                   ((lVar3 = Transform.GetChild(lVar3,iVar2,0), lVar3 == null ||
                    ((lVar3 = Component.GetComponent(lVar3,DAT_181e77438), lVar3 == null ||
                     (*(int64 *)(lVar3 + 32) == 0)))))) throw; // [null/range check failed]
                if (*(int *)(*(int64 *)(lVar3 + 32) + 132) != this.forceIDFliter)
                goto LAB_18089c16e;
              }
              if ((((this.heroSearchList == null) ||
                   (lVar3 = GameObject.get_transform(this.heroSearchList,0)) == null) ||
                  (lVar3 = Transform.GetChild(lVar3,iVar2,0)) == null) ||
                 ((lVar3 = Component.GetComponent(lVar3,DAT_181e77438), lVar3 == null ||
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
                    (((lVar4 = Component.GetComponent(lVar4,DAT_181e77438), lVar4 == null ||
                      (*(int64 *)(lVar4 + 32) == 0)) || (lVar3 == null)))))) throw; // [null/range check failed]
                cVar1 = FUN_180060680(lVar3,*(uint32 *)(*(int64 *)(lVar4 + 32) + 184));
                if (cVar1) {
                  if (((this.heroSearchList == null) ||
                      (lVar3 = GameObject.get_transform(this.heroSearchList,0)) == null) ||
                     ((lVar3 = Transform.GetChild(lVar3,iVar2,0), lVar3 == null ||
                      ((lVar3 = Component.GetComponent(lVar3,DAT_181e77438), lVar3 == null ||
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
                    goto joined_r0x00018089bc09;
                  }
                }
              }
            }
        LAB_18089c16e:
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
            goto joined_r0x00018089bc09;
          }
        }
    }

    // Token : 0x6001884
    // RVA   : 0x89CB80   Offset: 0x89B980   Length: 0x1AD
    public void /*ctor*/()
    {
        long lVar1;
        this.forceIDFliter = 0xfffffffe;
        lVar1 = il2cpp_internal(DAT_181e71638);
        FUN_1810f3480(lVar1,DAT_181e624f8);
        if (lVar1 != null) {
          FUN_181660e60(lVar1,1,DAT_181e625f8);
          FUN_181660e60(lVar1,1,DAT_181e625f8);
          this.speFliter = lVar1;
          lVar1 = il2cpp_internal(DAT_181e71638);
          FUN_1810f3480(lVar1,DAT_181e624f8);
          if (lVar1 != null) {
            FUN_181660e60(lVar1,1,DAT_181e625f8);
            FUN_181660e60(lVar1,1,DAT_181e625f8);
            this.sexFliter = lVar1;
            lVar1 = il2cpp_internal(DAT_181e71638);
            FUN_1810f3480(lVar1,DAT_181e624f8);
            if (lVar1 != null) {
              FUN_181660e60(lVar1,1,DAT_181e625f8);
              FUN_181660e60(lVar1,1,DAT_181e625f8);
              FUN_181660e60(lVar1,1,DAT_181e625f8);
              FUN_181660e60(lVar1,1,DAT_181e625f8);
              FUN_181660e60(lVar1,1,DAT_181e625f8);
              FUN_181660e60(lVar1,1,DAT_181e625f8);
              this.forceLvFliter = lVar1;
              FUN_180ae8740(this,0);
              return;
            }
          }
        }
    }

    // Token : 0x6001885
    // RVA   : 0x52B140   Offset: 0x529F40   Length: 0x20
    private void <HideHeroSearch>b__17_0()
    {
        if (this.heroSearchPanel != null) {
          GameObject.SetActive(this.heroSearchPanel,0,0);
          return;
        }
    }

}
