// ============================================================
// Type  : ManageReplaceForceController
// Token : 0x200030A
// ============================================================

public class ManageReplaceForceController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001911
    public ForceData targetForce;

    // Token: 0x4001912
    public GameObject manageReplaceForceUI;

    // Token: 0x4001913
    public GameObject manageReplaceForceUIRoot;

    // Token: 0x4001914
    public InputField forceBaseName;

    // Token: 0x4001915
    public InputField forceTypeName;

    // Token: 0x4001916
    public Image colorImage;

    // Token: 0x4001917
    public Slider sliderRed;

    // Token: 0x4001918
    public Slider sliderGreen;

    // Token: 0x4001919
    public Slider sliderBlue;

    // Token: 0x400191A
    public Image forceIconImage;

    // Token: 0x400191B
    public Slider forceIconSlider;

    // Token: 0x400191C
    public List<int> dismissHeroIdList;

    // Token: 0x400191D
    public GameObject replaceForceHeroPrefab;

    // Token: 0x400191E
    public GameObject replaceForceHeroList;

    // Token: 0x400191F
    public Dropdown forceStyleDropdown;

    // Token: 0x4001920
    public Dropdown forceItemFocusDropdown;

    // Token: 0x4001921
    private List<float> forceItemFocusRate;

    // Token: 0x4001922
    public GameObject replaceForceSkillPrefab;

    // Token: 0x4001923
    public Text forceFightSkillNum;

    // Token: 0x4001924
    public GameObject forceFightSkillGrid;

    // Token: 0x4001925
    public GameObject forceFightSkillAdd;

    // Token: 0x4001926
    public Text forceLivingSkillNum;

    // Token: 0x4001927
    public GameObject forceLivingSkillGrid;

    // Token: 0x4001928
    public GameObject forceLivingSkillAdd;

    // Token: 0x4001929
    private readonly int MaxFightSkillFocusNum;

    // Token: 0x400192A
    private readonly int MaxLivingSkillFocusNum;

    // Token: 0x400192B
    private GameObject temp;

    // Token: 0x400192C
    private static ManageReplaceForceController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001962
    // RVA   : 0x7CF280   Offset: 0x7CE080   Length: 0x36
    public static ManageReplaceForceController get_Instance()
    {
        return **(uint64 **)(DAT_181e67d70 + 184);
    }

    // Token : 0x6001963
    // RVA   : 0x7CC000   Offset: 0x7CAE00   Length: 0xD7
    private void Awake()
    {
        bool cVar2;
        ulong uVar3;
        uVar3 = **(uint64 **)(DAT_181e67d70 + 184);
        cVar2 = Object.op_Equality(uVar3,0,0);
        if (!cVar2) {
          uVar3 = Component.get_gameObject(this,0);
          Object.Destroy(uVar3,0);
          return;
        }
        puVar1 = *(uint64 **)(DAT_181e67d70 + 184);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x6001964
    // RVA   : 0x7CE120   Offset: 0x7CCF20   Length: 0x158
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
          uVar3 = new OnTooltipCB(this,DAT_181e6bd78,0);
          if (lVar2 == null) {
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          RailCallBackHelper.RegisterCallback(lVar2,0x1f45,uVar3,0);
        }
    }

    // Token : 0x6001965
    // RVA   : 0x7CD800   Offset: 0x7CC600   Length: 0x916
    public void ShowManageReplaceForceUI(ForceData _targetForce)
    {
        var pStatics = *(int64*)(DAT_181e538e8 + 184);
        ulong uVar2;
        bool cVar3;
        uint uVar4;
        uint uVar5;
        ulong uVar6;
        long lVar7;
        int iVar8;
        long lVar9;
        uint uVar10;
        long lVar11;
        float fVar12;
        int[] local_res8 = new int[2];
        ulong local_48;
        ulong uStack_40;
        local_48 = 0;
        uStack_40 = 0;
        this.targetForce = _targetForce;
        if (this.manageReplaceForceUI != null) {
          GameObject.SetActive(this.manageReplaceForceUI,1,0);
          if ((this.targetForce != null) &&
             (lVar7 = this.targetForce.forceName) != null) {
            lVar9 = this.forceBaseName;
            if (lVar7.forceID == 2) {
              uVar6 = String.Substring(lVar7,0,1);
              if (lVar9 == null) goto LAB_1807ce111;
              InputField.set_text(lVar9,uVar6,0);
              lVar7 = this.forceTypeName;
              if ((this.targetForce == null) ||
                 (lVar9 = this.targetForce.forceName) == null)
              goto LAB_1807ce111;
              uVar6 = String.Substring(lVar9,1,1,0);
            }
            else {
              uVar6 = String.Substring(lVar7,0,2);
              if (lVar9 == null) goto LAB_1807ce111;
              InputField.set_text(lVar9,uVar6,0);
              lVar7 = this.forceTypeName;
              if ((this.targetForce == null) ||
                 (lVar9 = this.targetForce.forceName) == null)
              goto LAB_1807ce111;
              uVar6 = String.Substring(lVar9,2);
            }
            if (lVar7 != null) {
              InputField.set_text(lVar7,uVar6,0);
              if (this.targetForce != null) {
                uVar6 = String.Concat("#",this.targetForce.color
                                       ,0);
                ColorUtility.TryParseHtmlString(uVar6,&local_48,0);
                plVar1 = this.sliderRed;
                Mathf.RoundToInt((float)local_48 * 255.0,0);
                if (plVar1 != (int64 *)0) {
                  lVar7 = *plVar1;
                  (**(code **)(lVar7 + 0x428))(plVar1,lVar7,*(uint64 *)(lVar7 + 0x430));
                  plVar1 = this.sliderGreen;
                  Mathf.RoundToInt(local_48._4_4_ * 255.0,0);
                  if (plVar1 != (int64 *)0) {
                    lVar7 = *plVar1;
                    (**(code **)(lVar7 + 0x428))(plVar1,lVar7,*(uint64 *)(lVar7 + 0x430));
                    plVar1 = this.sliderBlue;
                    Mathf.RoundToInt((float)uStack_40 * 255.0,0);
                    if (plVar1 != (int64 *)0) {
                      lVar7 = *plVar1;
                      (**(code **)(lVar7 + 0x428))(plVar1,lVar7,*(uint64 *)(lVar7 + 0x430));
                      local_res8[0] = 1;
                      while( true ) {
                        lVar7 = **(int64 **)(DAT_181e8b8e8 + 184);
                        uVar6 = Int32.ToString(local_res8,0);
                        uVar6 = String.Concat("自选标志",uVar6,0);
                        if (lVar7 == null) goto LAB_1807ce111;
                        uVar6 = TextureController.LoadAtlasSprite(lVar7,"UIAtlas",uVar6,0);
                        cVar3 = Object.op_Inequality(uVar6);
                        if (!cVar3) break;
                        local_res8[0] = local_res8[0] + 1;
                      }
                      if (this.forceIconSlider != null) {
                        Slider.set_maxValue();
                        ManageReplaceForceController.FreshForceIcon(this,0);
                        uVar6 = il2cpp_internal(DAT_181e73cb8);
                        FUN_1810f3480(uVar6,DAT_181e71270);
                        this.dismissHeroIdList = uVar6;
                        lVar7 = this.targetForce;
                        uVar10 = 0;
                        iVar8 = 0;
                        if (lVar7 != null) {
                          while (lVar7.ownHeros != null) {
                            if (*(int *)(lVar7.ownHeros + 24) <= iVar8) {
                              lVar7 = this.forceStyleDropdown;
                              if (lVar7 != null) {
                                Dropdown.AddOptions
                                          (lVar7,*(uint64 *)
                                                  (pStatics + 0x1c0),0);
                                lVar7 = this.forceStyleDropdown;
                                lVar9 = *(int64 *)(pStatics + 0x1c0);
                                if (((this.targetForce != null) && (lVar9 != null)) &&
                                   (uVar4 = FUN_181662a20(lVar9,*(uint64 *)
                                                                 (this.targetForce + 40),
                                                          DAT_181e865f0), lVar7 != null)) {
                                  Dropdown.set_value(lVar7,uVar4,0);
                                  if (this.forceItemFocusDropdown != null) {
                                    Dropdown.AddOptions
                                              (this.forceItemFocusDropdown,
                                               *(uint64 *)
                                                (pStatics + 0x4d8),0);
                                    lVar7 = this.forceItemFocusDropdown;
                                    if ((this.targetForce != null) &&
                                       (lVar9 = this.targetForce.itemFocus,
                                       lVar9 != null)) {
                                      if (lVar9.Count == null) {
                                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                      }
                                      uVar4 = Mathf.RoundToInt(*(uint32 *)
                                                                 (lVar9._items + 32),0);
                                      if (lVar7 != null) {
                                        Dropdown.set_value(lVar7,uVar4,0);
                                        if (this.targetForce != null) {
                                          lVar7 = this.targetForce.itemFocus;
                                          lVar9 = this.forceItemFocusRate;
                                          if (lVar7 != null) {
                                            if (lVar7.forceName == null) {
                                              ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                            }
                                            uVar5 = Mathf.RoundToInt(*(uint32 *)
                                                                       (lVar7.forceID + 32
                                                                       ),0);
                                            if (lVar9 != null) {
                                              if (lVar9.Count <= uVar5) {
                                                ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                              }
                                              FUN_181769c70(lVar7,1,*(uint32 *)
                                                                     (lVar9._items + 32 +
                                                                     (int64)(int)uVar5 * 4),
                                                            DAT_181e835b0);
                                              lVar7 = this.targetForce;
                                              uVar5 = 0;
                                              if (lVar7 != null) {
                                                lVar9 = 32;
                                                lVar11 = 32;
                                                goto LAB_1807cdfc0;
                                              }
                                            }
                                          }
                                        }
                                      }
                                    }
                                  }
                                }
                              }
                              break;
                            }
                            uVar6 = this.replaceForceHeroList;
                            uVar2 = this.replaceForceHeroPrefab;
                            lVar7 = GlobalData.AddChild(uVar6,uVar2);
                            this.temp = lVar7;
                            if (*plVar1 == 0) break;
                            lVar7 = GameObject.GetComponent(*plVar1,DAT_181e55da0);
                            if ((this.targetForce == null) ||
                               (uVar6 = ForceData.GetOwnHero(this.targetForce,iVar8),
                               lVar7 == null)) break;
                            lVar7.forceName = uVar6;
                            if ((*plVar1 == 0) ||
                               (lVar7 = GameObject.GetComponent(*plVar1,DAT_181e55da0)) == null)
                            break;
                            ReplaceForceHeroController.Init(lVar7,0);
                            if (((*plVar1 == 0) ||
                                (lVar7 = GameObject.GetComponent(*plVar1,DAT_181e55da0)) == null) ||
                               (lVar7.forceName == null)) break;
                            fVar12 = (float)HeroData.Favor(lVar7.forceName,0);
                            if (fVar12 < 40.0) {
                              if (((*plVar1 == 0) ||
                                  (lVar7 = GameObject.get_transform(*plVar1,0)) == null) ||
                                 ((lVar7 = Transform.Find(lVar7,"Toggle"), lVar7 == null ||
                                  (lVar7 = Component.GetComponent(lVar7,DAT_181e796b8)) == null)))
                              break;
                              Toggle.set_isOn(lVar7,0);
                              if (((*plVar1 == 0) ||
                                  (lVar7 = GameObject.get_transform(*plVar1,0)) == null) ||
                                 ((lVar7 = Transform.Find(lVar7,"Toggle"), lVar7 == null ||
                                  (lVar7 = Component.GetComponent(lVar7,DAT_181e796b8)) == null)))
                              break;
                              Selectable.set_interactable(lVar7,0);
                            }
                            lVar7 = this.targetForce;
                            iVar8 = iVar8 + 1;
                            if (lVar7 == null) break;
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
        LAB_1807ce111:
                          // WARNING: Subroutine does not return
        FUN_1801e0300();
        LAB_1807cdfc0:
        if (lVar7.kungfuSkillFocus == null) goto LAB_1807ce111;
        if (*(int *)(lVar7.kungfuSkillFocus + 24) <= (int)uVar5) {
          if (lVar7 != null) goto LAB_1807ce050;
          goto LAB_1807ce111;
        }
        uVar6 = this.forceFightSkillGrid;
        if ((lVar7 = lVar7?.kungfuSkillFocus) == null) goto LAB_1807ce111;
        if (lVar7.forceName <= uVar5) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        ManageReplaceForceController.AddForceSkillPrefab
                  (this,uVar6,*(uint32 *)(lVar7.forceID + lVar11),0);
        lVar7 = this.targetForce;
        uVar5 = uVar5 + 1;
        lVar11 = lVar11 + 4;
        if (lVar7 == null) goto LAB_1807ce111;
        goto LAB_1807cdfc0;
        LAB_1807ce050:
        if (lVar7.livingSkillFocus == null) goto LAB_1807ce111;
        if (*(int *)(lVar7.livingSkillFocus + 24) <= (int)uVar10) {
          ManageReplaceForceController.RegenerateAddOption(this,this.forceFightSkillAdd,0);
          ManageReplaceForceController.RegenerateAddOption(this,this.forceLivingSkillAdd,0);
          return;
        }
        uVar6 = *(uint64 *)(this + 200);
        if ((lVar7 = lVar7?.livingSkillFocus) == null) goto LAB_1807ce111;
        if (lVar7.forceName <= uVar10) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        ManageReplaceForceController.AddForceSkillPrefab
                  (this,uVar6,*(uint32 *)(lVar7.forceID + lVar9),0);
        lVar7 = this.targetForce;
        uVar10 = uVar10 + 1;
        lVar9 = lVar9 + 4;
        if (lVar7 == null) goto LAB_1807ce111;
        goto LAB_1807ce050;
    }

    // Token : 0x6001966
    // RVA   : 0x7CF0C0   Offset: 0x7CDEC0   Length: 0x71
    public void UnshowManageReplaceForceUI()
    {
        ulong uVar1;
        if (this.manageReplaceForceUI != null) {
          GameObject.SetActive(this.manageReplaceForceUI,0,0);
          uVar1 = this.replaceForceHeroList;
          GlobalData.DeleteAllChild(uVar1,0);
          return;
        }
    }

    // Token : 0x6001967
    // RVA   : 0x7CD430   Offset: 0x7CC230   Length: 0x2BE
    public void ResetForceName()
    {
        long lVar1;
        ulong uVar2;
        long lVar3;
        ushort uVar6;
        ushort uVar7;
        if ((this.forceBaseName != null) && (this.forceTypeName != null)) {
          uVar2 = String.Concat(*(uint64 *)(this.forceBaseName + 0x170),
                                 *(uint64 *)(this.forceTypeName + 0x170),0);
          if (**(int **)(DAT_181e538e8 + 184) == 1) {
            lVar3 = new c.DisplayClass9_0(0);
            if (lVar3 != null) {
              *(uint64 *)(lVar3 + 16) = uVar2;
              *(uint8 *)(lVar3 + 24) = *(uint8 *)(*(int64 *)(DAT_181e538e8 + 184) + 128);
              plVar4 = (int64 *)rail_api.RailFactory(0);
              if (plVar4 != (int64 *)0) {
                lVar1 = *plVar4;
                uVar7 = 0;
                if (*(uint16 *)(lVar1 + 0x12a) != 0) {
                  uVar6 = uVar7;
                  do {
                    if (*(int64 *)(*(int64 *)(lVar1 + 176) + (uint64)uVar6 * 16) ==
                        DAT_181e5b750) {
                      puVar5 = (uint64 *)
                               ((int64)
                                *(int *)(*(int64 *)(lVar1 + 176) + 8 + (uint64)uVar6 * 16) * 16
                                + 0x248 + lVar1);
                      goto LAB_1807cd5ee;
                    }
                    uVar6 = uVar6 + 1;
                  } while (uVar6 < *(uint16 *)(lVar1 + 0x12a));
                }
                puVar5 = (uint64 *)FUN_18019b1f0(plVar4,DAT_181e5b750,17);
        LAB_1807cd5ee:
                plVar4 = (int64 *)(*(code *)*puVar5)(plVar4,puVar5[1]);
                uVar2 = "";
                if (plVar4 != (int64 *)0) {
                  lVar1 = *plVar4;
                  if (*(uint16 *)(lVar1 + 0x12a) != 0) {
                    do {
                      if (*(int64 *)(*(int64 *)(lVar1 + 176) + (uint64)uVar7 * 16) ==
                          DAT_181e5cf10) {
                        puVar5 = (uint64 *)
                                 ((int64)
                                  *(int *)(*(int64 *)(lVar1 + 176) + 8 + (uint64)uVar7 * 16) *
                                  16 + 0x1f8 + lVar1);
                        goto LAB_1807cd657;
                      }
                      uVar7 = uVar7 + 1;
                    } while (uVar7 < *(uint16 *)(lVar1 + 0x12a));
                  }
                  puVar5 = (uint64 *)FUN_18019b1f0(plVar4,DAT_181e5cf10,12);
        LAB_1807cd657:
                          // WARNING: Could not recover jumptable at 0x0001807cd678. Too many branches
                          // WARNING: Treating indirect jump as call
                  (*(code *)*puVar5)(plVar4,lVar3,uVar2,puVar5[1]);
                  return;
                }
              }
            }
          }
          else {
            lVar3 = CISFilterWordsSDK.get_Instance(0);
            if (lVar3 != null) {
              uVar2 = CISFilterWordsSDK.FilterReplaceWithChar(lVar3,uVar2,42,0);
              ManageReplaceForceController.SetFliteredForceName(this,uVar2,0);
              return;
            }
          }
        }
    }

    // Token : 0x6001968
    // RVA   : 0x7CCB40   Offset: 0x7CB940   Length: 0x9A
    public void OnResetForceNameFliterResult(RAILEventID id, EventBase data)
    {
        void ManageReplaceForceController.OnResetForceNameFliterResult
                     (uint64 this,int id,int64 *data)
        {
        if (data != (int64 *)0) {
          if (((int)data[2] == 0) && (id == 0x1f45)) {
            ManageReplaceForceController.SetFliteredForceName(this,data[8],0);
          }
          return;
        }
    }

    // Token : 0x6001969
    // RVA   : 0x7CD6F0   Offset: 0x7CC4F0   Length: 0x107
    public void SetFliteredForceName(string fliteredTotalName)
    {
        uint uVar1;
        long lVar2;
        ulong uVar3;
        lVar2 = this.forceBaseName;
        if (((lVar2 != null) && (*(int64 *)(lVar2 + 0x170) != 0)) && (fliteredTotalName != null)) {
          uVar1 = *(uint32 *)(*(int64 *)(lVar2 + 0x170) + 16);
          uVar3 = String.Substring(fliteredTotalName,0,uVar1,0);
          uVar3 = LTLocalization.GetText(uVar3,0,1,0);
          InputField.set_text(lVar2,uVar3,0);
          lVar2 = this.forceTypeName;
          uVar3 = String.Substring(fliteredTotalName,uVar1,0);
          uVar3 = LTLocalization.GetText(uVar3,0,1,0);
          if (lVar2 != null) {
            InputField.set_text(lVar2,uVar3,0);
            return;
          }
        }
    }

    // Token : 0x600196A
    // RVA   : 0x7CC540   Offset: 0x7CB340   Length: 0x269
    public void ColorSliderValueChanged()
    {
        long lVar3;
        ulong uVar5;
        uint[] local_res8 = new uint[2];
        uint local_18;
        uint uStack_14;
        uint uStack_10;
        uint32 uStack_c;
        plVar1 = this.colorImage;
        puVar2 = (uint32 *)ManageReplaceForceController.GetSetColor(&local_18,this,0);
        if (plVar1 != (int64 *)0) {
          local_18 = *puVar2;
          uStack_14 = puVar2[1];
          uStack_10 = puVar2[2];
          uStack_c = puVar2[3];
          (**(code **)(*plVar1 + 0x2a8))(plVar1,&local_18,*(uint64 *)(*plVar1 + 0x2b0));
          if (this.sliderRed != null) {
            lVar3 = Component.get_transform(this.sliderRed,0);
            if (lVar3 != null) {
              lVar3 = Transform.Find(lVar3,"Id",0);
              if (lVar3 != null) {
                plVar4 = (int64 *)Component.GetComponent(lVar3,DAT_181e79538);
                plVar1 = this.sliderRed;
                if (plVar1 != (int64 *)0) {
                  local_res8[0] = (**(code **)(*plVar1 + 0x418))(plVar1,*(uint64 *)(*plVar1 + 0x420));
                  uVar5 = Single.ToString(local_res8,"f0",0);
                  if (plVar4 != (int64 *)0) {
                    (**(code **)(*plVar4 + 0x5e8))(plVar4,uVar5,*(uint64 *)(*plVar4 + 0x5f0));
                    if (this.sliderGreen != null) {
                      lVar3 = Component.get_transform(this.sliderGreen,0);
                      if (lVar3 != null) {
                        lVar3 = Transform.Find(lVar3,"Id",0);
                        if (lVar3 != null) {
                          plVar4 = (int64 *)Component.GetComponent(lVar3,DAT_181e79538);
                          plVar1 = this.sliderGreen;
                          if (plVar1 != (int64 *)0) {
                            local_res8[0] =
                                 (**(code **)(*plVar1 + 0x418))(plVar1,*(uint64 *)(*plVar1 + 0x420));
                            uVar5 = Single.ToString(local_res8,"f0",0);
                            if (plVar4 != (int64 *)0) {
                              (**(code **)(*plVar4 + 0x5e8))
                                        (plVar4,uVar5,*(uint64 *)(*plVar4 + 0x5f0));
                              if (this.sliderBlue != null) {
                                lVar3 = Component.get_transform(this.sliderBlue,0);
                                if (lVar3 != null) {
                                  lVar3 = Transform.Find(lVar3,"Id",0);
                                  if (lVar3 != null) {
                                    plVar4 = (int64 *)Component.GetComponent(lVar3,DAT_181e79538);
                                    plVar1 = this.sliderBlue;
                                    if (plVar1 != (int64 *)0) {
                                      local_res8[0] =
                                           (**(code **)(*plVar1 + 0x418))
                                                     (plVar1,*(uint64 *)(*plVar1 + 0x420));
                                      uVar5 = Single.ToString(local_res8,"f0",0);
                                      if (plVar4 != (int64 *)0) {
                                        (**(code **)(*plVar4 + 0x5e8))
                                                  (plVar4,uVar5,*(uint64 *)(*plVar4 + 0x5f0));
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

    // Token : 0x600196B
    // RVA   : 0x7CCA10   Offset: 0x7CB810   Length: 0xC0
    public Color GetSetColor()
    {
        float fVar2;
        float fVar3;
        float fVar4;
        plVar1 = *(int64 **)(param_2 + 72);
        if (plVar1 != (int64 *)0) {
          fVar2 = (float)(**(code **)(*plVar1 + 0x418))(plVar1,*(uint64 *)(*plVar1 + 0x420));
          plVar1 = *(int64 **)(param_2 + 80);
          if (plVar1 != (int64 *)0) {
            fVar3 = (float)(**(code **)(*plVar1 + 0x418))(plVar1,*(uint64 *)(*plVar1 + 0x420));
            plVar1 = *(int64 **)(param_2 + 88);
            if (plVar1 != (int64 *)0) {
              fVar4 = (float)(**(code **)(*plVar1 + 0x418))(plVar1,*(uint64 *)(*plVar1 + 0x420));
              *this = 0;
              this[1] = 0;
              Color.ctor(this,fVar2 / 255.0,fVar3 / 255.0,fVar4 / 255.0,0);
              return this;
            }
          }
        }
    }

    // Token : 0x600196C
    // RVA   : 0x7CCAE0   Offset: 0x7CB8E0   Length: 0x55
    public void IconSliderValueChanged()
    {
        long lVar1;
        uint uVar3;
        lVar1 = this.targetForce;
        plVar2 = this.forceIconSlider;
        if (plVar2 != (int64 *)0) {
          (**(code **)(*plVar2 + 0x418))(plVar2,*(uint64 *)(*plVar2 + 0x420));
          uVar3 = Mathf.RoundToInt();
          if (lVar1 != null) {
            lVar1.forceSetIcon = uVar3;
            ManageReplaceForceController.FreshForceIcon(this,0);
            return;
          }
        }
    }

    // Token : 0x600196D
    // RVA   : 0x7CC900   Offset: 0x7CB700   Length: 0x107
    public void FreshForceIcon()
    {
        ulong uVar2;
        long lVar4;
        uint[] local_res8 = new uint[2];
        lVar4 = this.forceIconImage;
        if (this.targetForce != null) {
          uVar2 = ForceData.GetForceIcon(this.targetForce,0);
          if (lVar4 != null) {
            Image.set_sprite(lVar4,uVar2,0);
            if (this.forceIconSlider != null) {
              lVar4 = Component.get_transform(this.forceIconSlider,0);
              if (lVar4 != null) {
                lVar4 = Transform.Find(lVar4,"Id",0);
                if (lVar4 != null) {
                  plVar3 = (int64 *)Component.GetComponent(lVar4,DAT_181e79538);
                  plVar1 = this.forceIconSlider;
                  if (plVar1 != (int64 *)0) {
                    (**(code **)(*plVar1 + 0x418))(plVar1,*(uint64 *)(*plVar1 + 0x420));
                    local_res8[0] = Mathf.RoundToInt();
                    uVar2 = Int32.ToString(local_res8,0);
                    if (plVar3 != (int64 *)0) {
                      (**(code **)(*plVar3 + 0x5e8))(plVar3,uVar2,*(uint64 *)(*plVar3 + 0x5f0));
                      return;
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x600196E
    // RVA   : 0x7CC2C0   Offset: 0x7CB0C0   Length: 0x27A
    public void ChooseAllHeroButtonClicked()
    {
        bool cVar1;
        int iVar2;
        long lVar3;
        ulong uVar4;
        int iVar5;
        lVar3 = this.replaceForceHeroList;
        iVar5 = 0;
        if (lVar3 != null) {
          while (lVar3 = GameObject.get_transform(lVar3,0)) != null {
            iVar2 = Transform.get_childCount(lVar3,0);
            if (iVar2 <= iVar5) {
              return;
            }
            if (((this.replaceForceHeroList == null) ||
                (lVar3 = GameObject.get_transform(this.replaceForceHeroList,0)) == null) ||
               (lVar3 = Transform.GetChild(lVar3,iVar5,0)) == null) break;
            uVar4 = Component.GetComponent(lVar3);
            cVar1 = Object.op_Inequality(uVar4);
            if (cVar1) {
              if (((this.replaceForceHeroList == null) ||
                  (lVar3 = GameObject.get_transform(this.replaceForceHeroList,0)) == null) ||
                 ((lVar3 = Transform.GetChild(lVar3,iVar5,0), lVar3 == null ||
                  ((lVar3 = Transform.Find(lVar3,"Toggle"), lVar3 == null ||
                   (lVar3 = Component.GetComponent(lVar3)) == null))))) break;
              if (*(char *)(lVar3 + 208) != false) {
                if ((((this.replaceForceHeroList == null) ||
                     (lVar3 = GameObject.get_transform(this.replaceForceHeroList,0)) == null) ||
                    (lVar3 = Transform.GetChild(lVar3,iVar5,0)) == null) ||
                   ((lVar3 = Transform.Find(lVar3,"Toggle"), lVar3 == null ||
                    (lVar3 = Component.GetComponent(lVar3)) == null))) break;
                if (*(char *)(lVar3 + 0x118) == false) {
                  if (((this.replaceForceHeroList == null) ||
                      (lVar3 = GameObject.get_transform(this.replaceForceHeroList,0)) == null) ||
                     ((lVar3 = Transform.GetChild(lVar3,iVar5,0), lVar3 == null ||
                      ((lVar3 = Transform.Find(lVar3,"Toggle"), lVar3 == null ||
                       (lVar3 = Component.GetComponent(lVar3,DAT_181e796b8)) == null))))) break;
                  Toggle.set_isOn(lVar3);
                }
              }
            }
            lVar3 = this.replaceForceHeroList;
            iVar5 = iVar5 + 1;
            if (lVar3 == null) break;
          }
        }
    }

    // Token : 0x600196F
    // RVA   : 0x7CEE40   Offset: 0x7CDC40   Length: 0x27A
    public void UnchooseAllHeroButtonClicked()
    {
        bool cVar1;
        int iVar2;
        long lVar3;
        ulong uVar4;
        int iVar5;
        lVar3 = this.replaceForceHeroList;
        iVar5 = 0;
        if (lVar3 != null) {
          while (lVar3 = GameObject.get_transform(lVar3,0)) != null {
            iVar2 = Transform.get_childCount(lVar3,0);
            if (iVar2 <= iVar5) {
              return;
            }
            if (((this.replaceForceHeroList == null) ||
                (lVar3 = GameObject.get_transform(this.replaceForceHeroList,0)) == null) ||
               (lVar3 = Transform.GetChild(lVar3,iVar5,0)) == null) break;
            uVar4 = Component.GetComponent(lVar3);
            cVar1 = Object.op_Inequality(uVar4);
            if (cVar1) {
              if (((this.replaceForceHeroList == null) ||
                  (lVar3 = GameObject.get_transform(this.replaceForceHeroList,0)) == null) ||
                 ((lVar3 = Transform.GetChild(lVar3,iVar5,0), lVar3 == null ||
                  ((lVar3 = Transform.Find(lVar3,"Toggle"), lVar3 == null ||
                   (lVar3 = Component.GetComponent(lVar3)) == null))))) break;
              if (*(char *)(lVar3 + 208) != false) {
                if ((((this.replaceForceHeroList == null) ||
                     (lVar3 = GameObject.get_transform(this.replaceForceHeroList,0)) == null) ||
                    (lVar3 = Transform.GetChild(lVar3,iVar5,0)) == null) ||
                   ((lVar3 = Transform.Find(lVar3,"Toggle"), lVar3 == null ||
                    (lVar3 = Component.GetComponent(lVar3)) == null))) break;
                if (*(char *)(lVar3 + 0x118) != false) {
                  if (((this.replaceForceHeroList == null) ||
                      (lVar3 = GameObject.get_transform(this.replaceForceHeroList,0)) == null) ||
                     ((lVar3 = Transform.GetChild(lVar3,iVar5,0), lVar3 == null ||
                      ((lVar3 = Transform.Find(lVar3,"Toggle"), lVar3 == null ||
                       (lVar3 = Component.GetComponent(lVar3)) == null))))) break;
                  Toggle.set_isOn(lVar3);
                }
              }
            }
            lVar3 = this.replaceForceHeroList;
            iVar5 = iVar5 + 1;
            if (lVar3 == null) break;
          }
        }
    }

    // Token : 0x6001970
    // RVA   : 0x7CC1F0   Offset: 0x7CAFF0   Length: 0xC6
    public void ChangeForceStyle()
    {
        uint uVar1;
        long lVar2;
        long lVar3;
        lVar2 = this.targetForce;
        lVar3 = *(int64 *)(*(int64 *)(DAT_181e538e8 + 184) + 0x1c0);
        if ((this.forceStyleDropdown != null) && (lVar3 != null)) {
          uVar1 = *(uint32 *)(this.forceStyleDropdown + 0x120);
          if (*(uint32 *)(lVar3 + 24) <= uVar1) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          if (lVar2 != null) {
            lVar2.forceStyle =
                 lVar3[uVar1];
            il2cpp_internal();
            return;
          }
        }
    }

    // Token : 0x6001971
    // RVA   : 0x7CC0E0   Offset: 0x7CAEE0   Length: 0x100
    public void ChangeForceItemFocus()
    {
        long lVar1;
        long lVar2;
        uint uVar3;
        if (((this.targetForce != null) && (this.forceItemFocusDropdown != null)) &&
           (lVar1 = this.targetForce.itemFocus) != null) {
          FUN_181769c70(lVar1,0);
          if (this.targetForce != null) {
            lVar1 = this.targetForce.itemFocus;
            lVar2 = this.forceItemFocusRate;
            if (lVar1 != null) {
              if (*(int *)(lVar1 + 24) == 0) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              uVar3 = Mathf.RoundToInt(*(uint32 *)(*(int64 *)(lVar1 + 16) + 32),0);
              if (lVar2 != null) {
                if (lVar2.Count <= uVar3) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                FUN_181769c70(lVar1,1);
                return;
              }
            }
          }
        }
    }

    // Token : 0x6001972
    // RVA   : 0x7CBD90   Offset: 0x7CAB90   Length: 0x26A
    public void AddForceSkill(GameObject targetDropDown)
    {
        var pStatics = *(int64*)(DAT_181e538e8 + 184);
        uint uVar1;
        bool cVar2;
        uint uVar3;
        long lVar5;
        long lVar6;
        long lVar7;
        ulong uVar9;
        plVar4 = (int64 *)Resources.Load("Sound/SoundEffect/Button/TabButton",0);
        plVar8 = (int64 *)0;
        if ((plVar4 != (int64 *)0) && (*plVar4 == DAT_181e8f4a0)) {
          plVar8 = plVar4;
        }
        NGUITools.PlaySound(plVar8,0);
        if ((targetDropDown != null) && (lVar5 = GameObject.GetComponent(targetDropDown,DAT_181e54530)) != null) {
          if (*(int *)(lVar5 + 0x120) == 0) {
            return;
          }
          uVar9 = this.forceFightSkillAdd;
          cVar2 = Object.op_Equality(targetDropDown,uVar9,0);
          if (!cVar2) {
            uVar9 = *(uint64 *)(this + 200);
            lVar5 = *(int64 *)(pStatics + 0x4b8);
          }
          else {
            uVar9 = this.forceFightSkillGrid;
            lVar5 = *(int64 *)(pStatics + 0x4a8);
          }
          lVar6 = GameObject.GetComponent(targetDropDown,DAT_181e54530);
          if (lVar6 != null) {
            lVar6 = Dropdown.get_options(lVar6,0);
            lVar7 = GameObject.GetComponent(targetDropDown,DAT_181e54530);
            if ((lVar7 != null) && (lVar6 != null)) {
              uVar1 = *(uint32 *)(lVar7 + 0x120);
              if (*(uint32 *)(lVar6 + 24) <= uVar1) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar6 = lVar6[uVar1];
              if ((lVar6 != null) && (lVar5 != null)) {
                uVar3 = FUN_181662a20(lVar5,*(uint64 *)(lVar6 + 16),DAT_181e865f0);
                ManageReplaceForceController.AddForceSkillPrefab(this,uVar9,uVar3,0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x6001973
    // RVA   : 0x7CB960   Offset: 0x7CA760   Length: 0x426
    public void AddForceSkillPrefab(GameObject targetGrid, int _skillID)
    {
        var pStatics = *(int64*)(DAT_181e538e8 + 184);
        void ManageReplaceForceController.AddForceSkillPrefab
                     (int64 this,int64 targetGrid,uint32 _skillID)
        {
        char cVar1;
        uint32 uVar2;
        uint64 uVar3;
        int64 lVar4;
        int64 *plVar5;
        int64 lVar6;
        uVar3 = this.replaceForceSkillPrefab;
        uVar3 = GlobalData.AddChild(targetGrid,uVar3,0);
        this.temp = uVar3;
        if (this.temp != null) {
          lVar4 = GameObject.GetComponent(this.temp,DAT_181e55e28);
          if (lVar4 != null) {
            *(uint32 *)(lVar4 + 24) = _skillID;
            if (this.temp != null) {
              lVar4 = GameObject.get_transform(this.temp,0);
              if (lVar4 != null) {
                lVar4 = Transform.Find(lVar4,"Text",0);
                if (lVar4 != null) {
                  plVar5 = (int64 *)Component.GetComponent(lVar4,DAT_181e79538);
                  uVar3 = this.forceFightSkillGrid;
                  cVar1 = Object.op_Equality(targetGrid,uVar3,0);
                  if (!cVar1) {
                    lVar4 = *(int64 *)(pStatics + 0x4b8);
                  }
                  else {
                    lVar4 = *(int64 *)(pStatics + 0x4a8);
                  }
                  if (lVar4 != null) {
                    if (*(uint32 *)(lVar4 + 24) <= _skillID) {
                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                    }
                    if (plVar5 != (int64 *)0) {
                      (**(code **)(*plVar5 + 0x5e8))
                                (plVar5,*(uint64 *)
                                         (*(int64 *)(lVar4 + 16) + 32 + (int64)(int)_skillID * 8)
                                 ,*(uint64 *)(*plVar5 + 0x5f0));
                      uVar3 = this.forceFightSkillGrid;
                      cVar1 = Object.op_Equality(targetGrid,uVar3,0);
                      lVar4 = this.temp;
                      if (!cVar1) {
                        if (lVar4 == null) throw; // [null/range check failed]
                        lVar4 = GameObject.get_transform(lVar4,0);
                        if (this.forceLivingSkillAdd == null) throw; // [null/range check failed]
                        lVar6 = GameObject.get_transform(this.forceLivingSkillAdd,0);
                        if (lVar6 == null) throw; // [null/range check failed]
                        uVar2 = Transform.GetSiblingIndex(lVar6,0);
                        if (lVar4 == null) throw; // [null/range check failed]
                        Transform.SetSiblingIndex(lVar4,uVar2,0);
                        if ((this.targetForce == null) ||
                           (lVar4 = this.targetForce.livingSkillFocus) == null)
                        throw; // [null/range check failed]
                        cVar1 = FUN_18176a2d0(lVar4,_skillID,DAT_181e71570);
                        if (!cVar1) {
                          if ((this.targetForce == null) ||
                             (lVar4 = this.targetForce.livingSkillFocus) == null)
                          throw; // [null/range check failed]
                          FUN_181769fe0(lVar4,_skillID,DAT_181e713f0);
                        }
                        uVar3 = this.forceLivingSkillAdd;
                      }
                      else {
                        if (lVar4 == null) throw; // [null/range check failed]
                        lVar4 = GameObject.get_transform(lVar4,0);
                        if (this.forceFightSkillAdd == null) throw; // [null/range check failed]
                        lVar6 = GameObject.get_transform(this.forceFightSkillAdd,0);
                        if (lVar6 == null) throw; // [null/range check failed]
                        uVar2 = Transform.GetSiblingIndex(lVar6,0);
                        if (lVar4 == null) throw; // [null/range check failed]
                        Transform.SetSiblingIndex(lVar4,uVar2,0);
                        if ((this.targetForce == null) ||
                           (lVar4 = this.targetForce.kungfuSkillFocus) == null)
                        throw; // [null/range check failed]
                        cVar1 = FUN_18176a2d0(lVar4,_skillID,DAT_181e71570);
                        if (!cVar1) {
                          if ((this.targetForce == null) ||
                             (lVar4 = this.targetForce.kungfuSkillFocus) == null)
                          throw; // [null/range check failed]
                          FUN_181769fe0(lVar4,_skillID,DAT_181e713f0);
                        }
                        uVar3 = this.forceFightSkillAdd;
                      }
                      ManageReplaceForceController.RegenerateAddOption(this,uVar3,0);
                      if (targetGrid != null) {
                        lVar4 = GameObject.GetComponent(targetGrid,DAT_181e579c8);
                        if (lVar4 != null) {
                          UIGrid.set_repositionNow(lVar4,1,0);
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

    // Token : 0x6001974
    // RVA   : 0x7CD0E0   Offset: 0x7CBEE0   Length: 0x345
    public void RemoveForceSkill(GameObject targetForceSkill)
    {
        bool cVar1;
        long lVar3;
        ulong uVar4;
        long lVar5;
        ulong uVar7;
        plVar2 = (int64 *)Resources.Load("Sound/SoundEffect/Woosh",0);
        plVar8 = (int64 *)0;
        plVar6 = plVar8;
        if ((plVar2 != (int64 *)0) && (plVar6 = (int64 *)0, *plVar2 == DAT_181e8f4a0)) {
          plVar6 = plVar2;
        }
        NGUITools.PlaySound(plVar6,0);
        if (((targetForceSkill == null) || (lVar3 = GameObject.get_transform(targetForceSkill,0)) == null) ||
           (lVar3 = FUN_180b05920(lVar3,0)) == null) throw; // [null/range check failed]
        uVar4 = Component.get_gameObject(lVar3,0);
        uVar7 = this.forceFightSkillGrid;
        cVar1 = Object.op_Equality(uVar4,uVar7,0);
        lVar3 = this.targetForce;
        if (!cVar1) {
          if (lVar3 == null) throw; // [null/range check failed]
          lVar3 = lVar3.livingSkillFocus;
          lVar5 = GameObject.GetComponent(targetForceSkill,DAT_181e55e28);
          if ((lVar5 == null) || (lVar3 == null)) throw; // [null/range check failed]
          FUN_181665e90(lVar3,*(uint32 *)(lVar5 + 24),DAT_181e717f0);
          uVar7 = this.forceLivingSkillAdd;
        }
        else {
          if ((lVar3 = lVar3?.kungfuSkillFocus) == null) throw; // [null/range check failed]
          if (lVar3.forceName < 2) {
            lVar3 = FUN_1802106e0(0);
            if (lVar3 != null) {
              GameController.ShowTextOnMouse(lVar3,"至少一个武学专长！",0);
              plVar2 = (int64 *)Resources.Load("Sound/SoundEffect/WrongClick",0);
              if ((plVar2 != (int64 *)0) && (*plVar2 == DAT_181e8f4a0)) {
                plVar8 = plVar2;
              }
              NGUITools.PlaySound(plVar8,0);
              return;
            }
            throw; // [null/range check failed]
          }
          lVar5 = GameObject.GetComponent(targetForceSkill,DAT_181e55e28);
          if (lVar5 == null) throw; // [null/range check failed]
          FUN_181665e90(lVar3,*(uint32 *)(lVar5 + 24),DAT_181e717f0);
          uVar7 = this.forceFightSkillAdd;
        }
        ManageReplaceForceController.RegenerateAddOption(this,uVar7,0);
        Object.Destroy(targetForceSkill,0);
        lVar3 = GameObject.get_transform(targetForceSkill,0);
        if (((lVar3 != null) && (lVar3 = FUN_180b05920(lVar3,0)) != null) &&
           (lVar3 = Component.GetComponent(lVar3,DAT_181e79d38)) != null) {
          UIGrid.set_repositionNow(lVar3,1,0);
          return;
        }
    }

    // Token : 0x6001975
    // RVA   : 0x7CCBE0   Offset: 0x7CB9E0   Length: 0x4F0
    public void RegenerateAddOption(GameObject targetAdd)
    {
        var pStatics = *(int64*)(DAT_181e538e8 + 184);
        long lVar1;
        bool cVar2;
        long lVar3;
        ulong uVar4;
        ulong uVar5;
        long lVar6;
        int iVar7;
        uint[] local_res10 = new uint[2];
        uint[] local_res20 = new uint[2];
        if ((targetAdd != null) && (lVar3 = GameObject.GetComponent(targetAdd,DAT_181e54530)) != null) {
          Dropdown.ClearOptions(lVar3,0);
          lVar3 = il2cpp_internal(DAT_181e77728);
          FUN_1810f3480(lVar3,DAT_181e861f0);
          if (lVar3 != null) {
            FUN_18175de30(lVar3,"无",DAT_181e86370);
            uVar4 = this.forceFightSkillAdd;
            cVar2 = Object.op_Equality(targetAdd,uVar4,0);
            iVar7 = 0;
            if (!cVar2) {
              while( true ) {
                lVar6 = *(int64 *)(pStatics + 0x4b8);
                if (lVar6 == null) break;
                lVar1 = this.targetForce;
                if (*(int *)(lVar6 + 24) <= iVar7) {
                  if ((lVar1 != null) && (lVar1.livingSkillFocus != null)) {
                    GameObject.SetActive
                              (targetAdd,*(int *)(lVar1.livingSkillFocus + 24) <
                                       this.MaxLivingSkillFocusNum,0);
                    plVar8 = this.forceLivingSkillNum;
                    if ((this.targetForce != null) &&
                       (lVar6 = this.targetForce.livingSkillFocus) != null) {
                      local_res10[0] = *(uint32 *)(lVar6 + 24);
                      uVar4 = il2cpp_value_box(DAT_181e60808,local_res10);
                      local_res20[0] = this.MaxLivingSkillFocusNum;
                      uVar5 = il2cpp_value_box(DAT_181e60808,local_res20);
                      uVar4 = String.Format("{0}/{1}",uVar4,uVar5,0);
                      if (plVar8 != (int64 *)0) goto LAB_1807cd071;
                    }
                  }
                          // WARNING: Subroutine does not return
                  FUN_1801e0300();
                }
                if ((lVar1 == null) || (lVar1.livingSkillFocus == null)) break;
                cVar2 = FUN_18176a2d0(lVar1.livingSkillFocus,iVar7);
                if (!cVar2) {
                  lVar6 = *(int64 *)(pStatics + 0x4b8);
                  if (lVar6 == null) break;
                  uVar4 = FUN_1800024b0(lVar6,iVar7,DAT_181e86970);
                  FUN_18175de30(lVar3,uVar4);
                }
                iVar7 = iVar7 + 1;
              }
            }
            else {
              while( true ) {
                lVar6 = *(int64 *)(pStatics + 0x4a8);
                if (lVar6 == null) break;
                lVar1 = this.targetForce;
                if (*(int *)(lVar6 + 24) <= iVar7) {
                  if ((lVar1 != null) && (lVar1.kungfuSkillFocus != null)) {
                    GameObject.SetActive
                              (targetAdd,*(int *)(lVar1.kungfuSkillFocus + 24) <
                                       this.MaxFightSkillFocusNum,0);
                    plVar8 = this.forceFightSkillNum;
                    if ((this.targetForce != null) &&
                       (lVar6 = this.targetForce.kungfuSkillFocus) != null) {
                      local_res10[0] = *(uint32 *)(lVar6 + 24);
                      uVar4 = il2cpp_value_box(DAT_181e60808,local_res10);
                      local_res20[0] = this.MaxFightSkillFocusNum;
                      uVar5 = il2cpp_value_box(DAT_181e60808,local_res20);
                      uVar4 = String.Format("{0}/{1}",uVar4,uVar5,0);
                      if (plVar8 != (int64 *)0) goto LAB_1807cd071;
                    }
                  }
                          // WARNING: Subroutine does not return
                  FUN_1801e0300();
                }
                if ((lVar1 == null) || (lVar1.kungfuSkillFocus == null)) break;
                cVar2 = FUN_18176a2d0(lVar1.kungfuSkillFocus,iVar7);
                if (!cVar2) {
                  lVar6 = *(int64 *)(pStatics + 0x4a8);
                  if (lVar6 == null) break;
                  uVar4 = FUN_1800024b0(lVar6,iVar7,DAT_181e86970);
                  FUN_18175de30(lVar3,uVar4);
                }
                iVar7 = iVar7 + 1;
              }
            }
          }
        }
        LAB_1807cd0bf:
                          // WARNING: Subroutine does not return
        FUN_1801e0300();
        LAB_1807cd071:
        (**(code **)(*plVar8 + 0x5e8))(plVar8,uVar4,*(uint64 *)(*plVar8 + 0x5f0));
        lVar6 = GameObject.GetComponent(targetAdd,DAT_181e54530);
        if (lVar6 != null) {
          Dropdown.AddOptions(lVar6,lVar3,0);
          return;
        }
        goto LAB_1807cd0bf;
    }

    // Token : 0x6001976
    // RVA   : 0x7CE280   Offset: 0x7CD080   Length: 0x23A
    public void SureButtonClicked()
    {
        long lVar1;
        bool cVar2;
        ulong uVar3;
        if (this.forceBaseName == null) throw; // [null/range check failed]
        cVar2 = FUN_1816387f0(*(uint64 *)(this.forceBaseName + 0x170),"",0);
        if (!cVar2) {
          if (this.forceTypeName == null) throw; // [null/range check failed]
          cVar2 = FUN_1816387f0(*(uint64 *)(this.forceTypeName + 0x170),"",0);
          if (!cVar2) {
            lVar1 = **(int64 **)(DAT_181e88b68 + 184);
            uVar3 = Component.get_gameObject(this,0);
            if (lVar1 != null) {
              SureMenu.CallSureMenu(lVar1,"确认以当前设置自立门户吗？\n（所有未保留弟子都会退出门派）","SureReplaceForce",0,uVar3,1,0,0,0,0);
              return;
            }
            throw; // [null/range check failed]
          }
        }
        if (GameController._instance != null) {
          GameController.ShowTextOnMouse(GameController._instance,"请完整设置门派名称！",0);
          plVar4 = (int64 *)Resources.Load("Sound/SoundEffect/WrongClick",0);
          plVar5 = (int64 *)0;
          if ((plVar4 != (int64 *)0) && (*plVar4 == DAT_181e8f4a0)) {
            plVar5 = plVar4;
          }
          NGUITools.PlaySound(plVar5,0);
          return;
        }
    }

    // Token : 0x6001977
    // RVA   : 0x7CE4C0   Offset: 0x7CD2C0   Length: 0x973
    public void SureReplaceForce()
    {
        long lVar2;
        ulong uVar3;
        bool cVar4;
        uint uVar5;
        int iVar6;
        long lVar7;
        ulong uVar8;
        uint uVar10;
        long lVar11;
        uint uVar12;
        uint local_58;
        uint uStack_54;
        uint uStack_50;
        uint32 uStack_4c;
        uint64 local_48;
        uint64 local_38;
        uint64 uStack_30;
        uint64 local_28;
        local_38 = 0;
        uStack_30 = 0;
        local_28 = 0;
        uVar12 = 0;
        lVar7 = this.dismissHeroIdList;
        uVar10 = uVar12;
        if (lVar7 != null) {
          while ((int)uVar10 < lVar7.forceName) {
            lVar7 = FUN_1802106e0(0);
            if (lVar7 == null) throw; // [null/range check failed]
            lVar7 = lVar7.defaultSkinID;
            if (((this.dismissHeroIdList == null) ||
                (uVar5 = FUN_180002480(this.dismissHeroIdList,uVar10,DAT_181e71bf0), lVar7 == null))
               || (lVar7 = WorldData.GetHero(lVar7,uVar5,0)) == null) throw; // [null/range check failed]
            HeroData.LeaveForce(lVar7,1);
            uVar10 = uVar10 + 1;
            lVar7 = this.dismissHeroIdList;
            if (lVar7 == null) throw; // [null/range check failed]
          }
          if (this.targetForce != null) {
            this.targetForce.replacedForce = 1;
            lVar7 = this.targetForce;
            if (((this.forceBaseName != null) && (this.forceTypeName != null)) &&
               (uVar8 = String.Concat(*(uint64 *)(this.forceBaseName + 0x170),
                                       *(uint64 *)(this.forceTypeName + 0x170),0),
               lVar7 != null)) {
              lVar7.forceSetName = uVar8;
              if (this.targetForce != null) {
                lVar7 = ForceData.MainArea(this.targetForce,0);
                if ((this.targetForce != null) && (lVar7 != null)) {
                  lVar7.thisMonthReduceOtherForceFavor = this.targetForce.forceSetName;
                  if ((this.targetForce != null) &&
                     (lVar7 = ForceData.MainArea(this.targetForce,0)) != null) {
                    *(uint8 *)(lVar7 + 241) = 1;
                    lVar7 = this.targetForce;
                    puVar9 = (uint32 *)ManageReplaceForceController.GetSetColor(&local_58,this,0);
                    local_58 = *puVar9;
                    uStack_54 = puVar9[1];
                    uStack_50 = puVar9[2];
                    uStack_4c = puVar9[3];
                    uVar8 = ColorUtility.ToHtmlStringRGB(&local_58,0);
                    if (lVar7 != null) {
                      lVar7.color = uVar8;
                      if ((GameController._instance != null) &&
                         (lVar7 = GameController._instance.worldData) != null
                         ) {
                        lVar7 = WorldData.Player(lVar7,0);
                        if ((this.targetForce != null) && (lVar7 != null)) {
                          HeroData.JoinForce(lVar7,this.targetForce.forceID,
                                              0,0,1,0,0);
                          lVar7 = this.targetForce;
                          if (((GameController._instance != null) &&
                              (lVar11 = GameController._instance.worldData,
                              lVar11 != null)) && (uVar8 = WorldData.Player(lVar11,0), lVar7 != null)) {
                            ForceData.SetLeader(lVar7,uVar8,1,0);
                            lVar7 = this.targetForce;
                            if (lVar7 != null) {
                              lVar11 = 32;
                              uVar10 = uVar12;
                              goto LAB_1807ce8d0;
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
        throw; // [null/range check failed]
        LAB_1807cec80:
        if (lVar7.ownResourcePointsID == null) throw; // [null/range check failed]
        if (*(int *)(lVar7.ownResourcePointsID + 24) <= (int)uVar12) {
          lVar7 = FUN_180210740(0);
          if (lVar7 != null) {
            GameDataController.ChangeAchStats(lVar7,43,0x3f800000);
            if (this.manageReplaceForceUI != null) {
              GameObject.SetActive(this.manageReplaceForceUI,0,0);
              uVar8 = this.replaceForceHeroList;
              GlobalData.DeleteAllChild(uVar8,0);
              lVar7 = FUN_180210a70(0);
              if (lVar7 != null) {
                PlotController.FinishReplaceOtherForcePlot(lVar7,0);
                return;
              }
            }
          }
          throw; // [null/range check failed]
        }
        lVar7 = FUN_1802106e0(0);
        if (lVar7 == null) throw; // [null/range check failed]
        lVar7 = lVar7.defaultSkinID;
        if ((((this.targetForce == null) ||
             (lVar11 = this.targetForce.ownResourcePointsID) == null) ||
            (uVar5 = FUN_180002480(lVar11,uVar12), lVar7 == null)) ||
           (lVar7 = WorldData.GetResourcePoint(lVar7,uVar5)) == null) throw; // [null/range check failed]
        *(uint8 *)(lVar7 + 74) = 1;
        uVar12 = uVar12 + 1;
        lVar7 = this.targetForce;
        if (lVar7 == null) throw; // [null/range check failed]
        goto LAB_1807cec80;
        LAB_1807ce8d0:
        if ((lVar7.ownHeros == null) || (lVar7 == null)) throw; // [null/range check failed]
        if ((int)uVar10 < *(int *)(lVar7.ownHeros + 24)) {
          lVar7 = lVar7.ownHeros;
          if (lVar7 == null) throw; // [null/range check failed]
          if (lVar7.forceName <= uVar10) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          if (*(int *)(lVar11 + lVar7.forceID) != 0) {
            lVar7 = FUN_1802106e0(0);
            if ((lVar7 == null) || (lVar7.defaultSkinID == null)) throw; // [null/range check failed]
            lVar7 = WorldData.Player(lVar7.defaultSkinID,0);
            if ((this.targetForce == null) ||
               ((lVar2 = this.targetForce.ownHeros, lVar2 == null ||
                (uVar5 = FUN_180002480(lVar2,uVar10,DAT_181e71bf0), lVar7 == null)))) throw; // [null/range check failed]
            HeroData.AddStudent(lVar7,uVar5,0);
          }
          uVar10 = uVar10 + 1;
          lVar11 = lVar11 + 4;
          lVar7 = this.targetForce;
          if (lVar7 == null) throw; // [null/range check failed]
          goto LAB_1807ce8d0;
        }
        if (lVar7.forceFavorDict == null) goto LAB_1807ceaf8;
        lVar7 = Dictionary_2.get_Keys(lVar7.forceFavorDict,DAT_181e9fd50);
        if (lVar7 == null) throw; // [null/range check failed]
        iVar6 = FUN_180b34300(lVar7,DAT_181ea5bc8);
        if (iVar6 < 1) goto LAB_1807ceaf8;
        if ((this.targetForce == null) ||
           (lVar7 = this.targetForce.forceFavorDict) == null) throw; // [null/range check failed]
        uVar8 = Dictionary_2.get_Keys(lVar7,DAT_181e9fd50);
        lVar7 = FUN_18077cf20(uVar8,DAT_181e98ba0);
        if (lVar7 == null) throw; // [null/range check failed]
        FUN_18175fc30(&local_58,lVar7,DAT_181e71670);
        local_38 = CONCAT44(uStack_54,local_58);
        uStack_30 = CONCAT44(uStack_4c,uStack_50);
        local_28 = local_48;
        while (cVar4 = FUN_1807b40e0(&local_38,DAT_181e6f540), uVar3 = local_28, cVar4) {
          lVar7 = this.targetForce;
          if (lVar7 == null) {
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          uVar5 = ForceData.GetForceStartFavor(lVar7,local_28 & 0xffffffff,0);
          ForceData.SetForceFavor(lVar7,uVar3 & 0xffffffff,uVar5);
        }
        ZhSegment.Initialize(&local_38,DAT_181e6f4c0);
        LAB_1807ceaf8:
        if (this.targetForce == null) throw; // [null/range check failed]
        this.targetForce.forceDetailDirty = 1;
        if (this.targetForce == null) throw; // [null/range check failed]
        this.targetForce.forceHeroDetailDirty = 1;
        lVar7 = *(int64 *)(*(int64 *)(DAT_181e8c8b0 + 184) + 56);
        if (lVar7 != null) {
          lVar7.allyForce = 1;
          lVar7 = this.targetForce;
          uVar10 = uVar12;
          if (lVar7 != null) {
            while (lVar7.ownAreasID != null) {
              if (*(int *)(lVar7.ownAreasID + 24) <= (int)uVar10) {
                if (lVar7 != null) goto LAB_1807cec80;
                break;
              }
              lVar7 = FUN_1802106e0(0);
              if (lVar7 == null) break;
              lVar7 = lVar7.defaultSkinID;
              if (((this.targetForce == null) ||
                  (lVar11 = this.targetForce.ownAreasID) == null) ||
                 ((uVar5 = FUN_180002480(lVar11,uVar10,DAT_181e71bf0), lVar7 == null ||
                  (lVar7 = WorldData.GetArea(lVar7,uVar5,0)) == null))) break;
              lVar7.thisMonthGetHero = 1;
              lVar7 = this.targetForce;
              uVar10 = uVar10 + 1;
              if (lVar7 == null) break;
            }
          }
        }
    }

    // Token : 0x6001978
    // RVA   : 0x7CC7B0   Offset: 0x7CB5B0   Length: 0x143
    public void ForceIconLeftRightButtonClicked(GameObject buttonClicked)
    {
        void ManageReplaceForceController.ForceIconLeftRightButtonClicked
                     (int64 this,int64 buttonClicked)
        {
        char cVar1;
        int64 *plVar2;
        int64 lVar3;
        int64 *plVar4;
        float fVar5;
        plVar2 = (int64 *)Resources.Load("Sound/SoundEffect/Button/TabButton",0);
        plVar4 = (int64 *)0;
        if ((plVar2 != (int64 *)0) && (*plVar2 == DAT_181e8f4a0)) {
          plVar4 = plVar2;
        }
        NGUITools.PlaySound(plVar4,0);
        if (buttonClicked != null) {
          lVar3 = Object.get_name(buttonClicked,0);
          if (lVar3 != null) {
            cVar1 = String.Contains(lVar3,"Left",0);
            plVar2 = this.forceIconSlider;
            if (!cVar1) {
              if (plVar2 == (int64 *)0) throw; // [null/range check failed]
              fVar5 = (float)(**(code **)(*plVar2 + 0x418))(plVar2,*(uint64 *)(*plVar2 + 0x420));
              fVar5 = fVar5 + 1.0;
            }
            else {
              if (plVar2 == (int64 *)0) throw; // [null/range check failed]
              fVar5 = (float)(**(code **)(*plVar2 + 0x418))(plVar2,*(uint64 *)(*plVar2 + 0x420));
              fVar5 = fVar5 - 1.0;
            }
                          // WARNING: Could not recover jumptable at 0x0001807cc8e7. Too many branches
                          // WARNING: Treating indirect jump as call
            (**(code **)(*plVar2 + 0x428))(plVar2,fVar5,*(uint64 *)(*plVar2 + 0x430));
            return;
          }
        }
    }

    // Token : 0x6001979
    // RVA   : 0x7CF140   Offset: 0x7CDF40   Length: 0x13C
    public void /*ctor*/()
    {
        long lVar1;
        lVar1 = il2cpp_internal(DAT_181e76ea8);
        FUN_1810f3480(lVar1,DAT_181e83230);
        if (lVar1 != null) {
          FUN_18175dba0(lVar1,0x3f800000,DAT_181e83330);
          FUN_18175dba0(lVar1,0x3f800000,DAT_181e83330);
          FUN_18175dba0(lVar1,0x3f800000,DAT_181e83330);
          FUN_18175dba0(lVar1,0x3f000000,DAT_181e83330);
          FUN_18175dba0(lVar1,0x3f800000,DAT_181e83330);
          FUN_18175dba0(lVar1,0x3f800000,DAT_181e83330);
          FUN_18175dba0(lVar1,0x3f800000,DAT_181e83330);
          this.forceItemFocusRate = lVar1;
          this.MaxFightSkillFocusNum = 4;
          this.MaxLivingSkillFocusNum = 2;
          FUN_180ae8740(this,0);
          return;
        }
    }

}
