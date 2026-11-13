// ============================================================
// Type  : CraftPoisonUIController
// Token : 0x200025A
// ============================================================

public class CraftPoisonUIController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40012C7
    public GameObject poisonUIPanel;

    // Token: 0x40012C8
    public CraftPoisonType craftPoisonType;

    // Token: 0x40012C9
    public AreaBuildingData targetBuilding;

    // Token: 0x40012CA
    public bool useMoney;

    // Token: 0x40012CB
    public GameObject poisonTargetItemIcon;

    // Token: 0x40012CC
    public GameObject poisonTargetClearButton;

    // Token: 0x40012CD
    public GameObject poisonMaterialItemIcon;

    // Token: 0x40012CE
    public GameObject poisonMaterialClearButton;

    // Token: 0x40012CF
    public GameObject poisonMaterialItemIconSub;

    // Token: 0x40012D0
    public GameObject poisonMaterialClearButtonSub;

    // Token: 0x40012D1
    public Button craftPoisonButton;

    // Token: 0x40012D2
    public Text CostTime;

    // Token: 0x40012D3
    public Text PoisonExtraAdd;

    // Token: 0x40012D4
    private static CraftPoisonUIController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001358
    // RVA   : 0x64E160   Offset: 0x64CF60   Length: 0x36
    public static CraftPoisonUIController get_Instance()
    {
        return **(uint64 **)(DAT_181e9aa48 + 184);
    }

    // Token : 0x6001359
    // RVA   : 0x64BB60   Offset: 0x64A960   Length: 0xD7
    private void Awake()
    {
        bool cVar2;
        ulong uVar3;
        uVar3 = **(uint64 **)(DAT_181e9aa48 + 184);
        cVar2 = Object.op_Equality(uVar3,0,0);
        if (!cVar2) {
          uVar3 = Component.get_gameObject(this,0);
          Object.Destroy(uVar3,0);
          return;
        }
        puVar1 = *(uint64 **)(DAT_181e9aa48 + 184);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x600135A
    // RVA   : 0x64C6C0   Offset: 0x64B4C0   Length: 0x30
    public void HideCraftPoisonUI()
    {
        if (this.poisonUIPanel != null) {
          GameObject.SetActive(this.poisonUIPanel,0,0);
          CraftPoisonUIController.ClearPoisonTarget(this,0);
          return;
        }
    }

    // Token : 0x600135B
    // RVA   : 0x64C700   Offset: 0x64B500   Length: 0xE6
    public void OpenCraftPoisonUI(AreaBuildingData _targetBuilding, bool _useMoney)
    {
        void CraftPoisonUIController.OpenCraftPoisonUI
                     (int64 this,uint64 _targetBuilding,uint8 _useMoney)
        {
        int64 *plVar1;
        int64 *plVar2;
        plVar1 = (int64 *)Resources.Load("Sound/SoundEffect/Med",0);
        plVar2 = (int64 *)0;
        if ((plVar1 != (int64 *)0) && (*plVar1 == DAT_181e8f4a0)) {
          plVar2 = plVar1;
        }
        NGUITools.PlaySound(plVar2,0);
        if (this.poisonUIPanel != null) {
          GameObject.SetActive(this.poisonUIPanel,1,0);
          this.targetBuilding = _targetBuilding;
          this.useMoney = _useMoney;
          CraftPoisonUIController.RefreshCraftPoisonInfo(this,0);
          return;
        }
    }

    // Token : 0x600135C
    // RVA   : 0x64BC40   Offset: 0x64AA40   Length: 0x11F
    public void ChangeCraftPoisonTypeClicked(GameObject buttonClicked)
    {
        int iVar1;
        int iVar2;
        uint uVar3;
        long lVar4;
        ulong uVar5;
        if ((buttonClicked != null) && (lVar4 = GameObject.GetComponent(buttonClicked,DAT_181e57478)) != null) {
          if (*(char *)(lVar4 + 0x118) != false) {
            iVar1 = this.craftPoisonType;
            uVar5 = Object.get_name(buttonClicked,0);
            iVar2 = Int32.Parse(uVar5,0);
            if (iVar1 != iVar2) {
              uVar5 = Object.get_name(buttonClicked,0);
              uVar3 = Int32.Parse(uVar5,0);
              this.craftPoisonType = uVar3;
              CraftPoisonUIController.ClearPoisonTarget(this,0);
              plVar6 = (int64 *)Resources.Load("Sound/SoundEffect/Button/TabButton",0);
              plVar7 = (int64 *)0;
              if ((plVar6 != (int64 *)0) && (*plVar6 == DAT_181e8f4a0)) {
                plVar7 = plVar6;
              }
              NGUITools.PlaySound(plVar7,0);
            }
          }
          return;
        }
    }

    // Token : 0x600135D
    // RVA   : 0x64D450   Offset: 0x64C250   Length: 0x325
    public void PoisonTargetButtonClicked()
    {
        var pStatics = *(int64*)(DAT_181e977e8 + 184);
        int iVar1;
        bool cVar2;
        long lVar3;
        ulong uVar4;
        long lVar5;
        uint[] local_res8 = new uint[2];
        uint[] local_res18 = new uint[4];
        uint uVar6;
        uVar4 = this.poisonTargetItemIcon;
        cVar2 = Object.op_Inequality(uVar4,0,0);
        if (!cVar2) {
          iVar1 = this.craftPoisonType;
          if (iVar1 == 0) {
            lVar5 = *pStatics;
            lVar3 = il2cpp_internal(DAT_181e74e38);
            FUN_1810f3480(lVar3,DAT_181e77ae0);
            local_res8[0] = 0;
            uVar4 = il2cpp_value_box(DAT_181e60808,local_res8);
            if (lVar3 == null) {
        LAB_18064d764:
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            FUN_18175de30(lVar3,uVar4,DAT_181e77be0);
            local_res18[0] = 0;
            uVar4 = il2cpp_value_box(DAT_181e60808,local_res18);
            FUN_18175de30(lVar3,uVar4,DAT_181e77be0);
            uVar4 = Component.get_gameObject(this,0);
            if (lVar5 == null) goto LAB_18064d764;
            uVar6 = 16;
          }
          else if (iVar1 == 1) {
            lVar5 = *pStatics;
            lVar3 = il2cpp_internal(DAT_181e74e38);
            FUN_1810f3480(lVar3,DAT_181e77ae0);
            local_res8[0] = 0;
            uVar4 = il2cpp_value_box(DAT_181e60808,local_res8);
            if (lVar3 == null) {
        LAB_18064d770:
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            FUN_18175de30(lVar3,uVar4,DAT_181e77be0);
            uVar4 = Component.get_gameObject(this,0);
            if (lVar5 == null) goto LAB_18064d770;
            uVar6 = 0;
          }
          else {
            if (iVar1 != 2) {
              return;
            }
            lVar5 = *pStatics;
            lVar3 = il2cpp_internal(DAT_181e74e38);
            FUN_1810f3480(lVar3,DAT_181e77ae0);
            local_res8[0] = 0;
            uVar4 = il2cpp_value_box(DAT_181e60808,local_res8);
            if (lVar3 == null) {
        LAB_18064d76a:
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            FUN_18175de30(lVar3,uVar4,DAT_181e77be0);
            uVar4 = Component.get_gameObject(this,0);
            if (lVar5 == null) goto LAB_18064d76a;
            uVar6 = 17;
          }
          ChooseController.ShowChoosePanel(lVar5,1,lVar3,uVar4,"PoisonTargetChoosen",0,uVar6,0,0,0);
        }
    }

    // Token : 0x600135E
    // RVA   : 0x64D780   Offset: 0x64C580   Length: 0x202
    public void PoisonTargetChoosen()
    {
        var pStatics_2a90 = *(int64*)(DAT_181e52a90 + 184);
        var pStatics_77e8 = *(int64*)(DAT_181e977e8 + 184);
        ulong uVar1;
        long lVar2;
        ulong uVar3;
        long lVar4;
        if (this.poisonUIPanel != null) {
          lVar2 = GameObject.get_transform(this.poisonUIPanel,0);
          if (lVar2 != null) {
            lVar2 = Transform.Find(lVar2,"PoisonTarget",0);
            if (lVar2 != null) {
              uVar3 = Component.get_gameObject(lVar2,0);
              if (*pStatics_2a90 != 0) {
                uVar1 = *(uint64 *)(*pStatics_2a90 + 160);
                uVar3 = GlobalData.AddChild(uVar3,uVar1,0);
                this.poisonTargetItemIcon = uVar3;
                if (this.poisonTargetItemIcon != null) {
                  lVar2 = GameObject.GetComponent(this.poisonTargetItemIcon,DAT_181e55168);
                  if ((*pStatics_77e8 != 0) &&
                     (lVar4 = *(int64 *)(*pStatics_77e8 + 72)) != null) {
                    lVar4 = GameObject.GetComponent(lVar4,DAT_181e55168);
                    if ((lVar4 != null) && (lVar2 != null)) {
                      *(uint64 *)(lVar2 + 32) = *(uint64 *)(lVar4 + 32);
                      if (this.poisonTargetItemIcon != null) {
                        lVar2 = GameObject.GetComponent(this.poisonTargetItemIcon,DAT_181e55168);
                        if (lVar2 != null) {
                          *(uint32 *)(lVar2 + 40) = 1;
                          if (this.poisonTargetItemIcon != null) {
                            lVar2 = GameObject.GetComponent(this.poisonTargetItemIcon,DAT_181e55168);
                            if (lVar2 != null) {
                              ItemIconController.AutoSetName(lVar2,1,0);
                              if (this.poisonTargetClearButton != null) {
                                GameObject.SetActive(this.poisonTargetClearButton,1,0);
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

    // Token : 0x600135F
    // RVA   : 0x64BF40   Offset: 0x64AD40   Length: 0x226
    public void ClearPoisonTarget()
    {
        long lVar1;
        ulong uVar2;
        uVar2 = this.poisonTargetItemIcon;
        Object.Destroy(uVar2,0);
        this.poisonTargetItemIcon = 0;
        if (this.poisonTargetClearButton != null) {
          GameObject.SetActive(this.poisonTargetClearButton,0,0);
          uVar2 = this.poisonMaterialItemIcon;
          Object.Destroy(uVar2,0);
          this.poisonMaterialItemIcon = 0;
          if (this.poisonMaterialClearButton != null) {
            GameObject.SetActive(this.poisonMaterialClearButton,0,0);
            CraftPoisonUIController.RefreshCraftPoisonInfo(this,0);
            if (this.poisonUIPanel != null) {
              lVar1 = GameObject.get_transform(this.poisonUIPanel,0);
              if (lVar1 != null) {
                uVar2 = Transform.Find(lVar1,"MaterialLine",0);
                ShortcutExtensions.DOScaleX(uVar2,0,0x3e800000,0);
                uVar2 = this.poisonMaterialItemIconSub;
                Object.Destroy(uVar2,0);
                this.poisonMaterialItemIconSub = 0;
                if (this.poisonMaterialClearButtonSub != null) {
                  GameObject.SetActive(this.poisonMaterialClearButtonSub,0,0);
                  CraftPoisonUIController.RefreshCraftPoisonInfo(this,0);
                  if (this.poisonUIPanel != null) {
                    lVar1 = GameObject.get_transform(this.poisonUIPanel,0);
                    if (lVar1 != null) {
                      uVar2 = Transform.Find(lVar1,"MaterialLineSub",0);
                      ShortcutExtensions.DOScaleX(uVar2,0,0x3e800000,0);
                      return;
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6001360
    // RVA   : 0x64CCB0   Offset: 0x64BAB0   Length: 0x2BF
    public void PoisonMaterialButtonClicked()
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        long lVar4;
        uint[] local_res8 = new uint[2];
        uint[] local_res18 = new uint[4];
        uVar3 = this.poisonMaterialItemIcon;
        cVar1 = Object.op_Inequality(uVar3,0,0);
        if (cVar1) {
          return;
        }
        uVar3 = this.poisonTargetItemIcon;
        cVar1 = Object.op_Equality(uVar3,0,0);
        if (!cVar1) {
          lVar4 = **(int64 **)(DAT_181e977e8 + 184);
          lVar2 = il2cpp_internal(DAT_181e74e38);
          FUN_1810f3480(lVar2,DAT_181e77ae0);
          local_res8[0] = 0;
          uVar3 = il2cpp_value_box(DAT_181e60808,local_res8);
          if (lVar2 != null) {
            FUN_18175de30(lVar2,uVar3,DAT_181e77be0);
            local_res18[0] = 5;
            uVar3 = il2cpp_value_box(DAT_181e60808,local_res18);
            FUN_18175de30(lVar2,uVar3,DAT_181e77be0);
            uVar3 = Component.get_gameObject(this,0);
            if (lVar4 != null) {
              ChooseController.ShowChoosePanel(lVar4,1,lVar2,uVar3,"PoisonMaterialChoosen",0,15,0,0,0);
              return;
            }
          }
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        lVar4 = FUN_1802106e0(0);
        if (lVar4 == null) {
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        GameController.ShowTextOnMouse(lVar4,"需要先选择用毒目标！",0);
        plVar5 = (int64 *)Resources.Load("Sound/SoundEffect/WrongClick",0);
        plVar6 = (int64 *)0;
        if ((plVar5 != (int64 *)0) && (*plVar5 == DAT_181e8f4a0)) {
          plVar6 = plVar5;
        }
        NGUITools.PlaySound(plVar6,0);
    }

    // Token : 0x6001361
    // RVA   : 0x64D1E0   Offset: 0x64BFE0   Length: 0x26E
    public void PoisonMaterialChoosen()
    {
        var pStatics_2a90 = *(int64*)(DAT_181e52a90 + 184);
        var pStatics_77e8 = *(int64*)(DAT_181e977e8 + 184);
        ulong uVar1;
        long lVar2;
        ulong uVar3;
        long lVar4;
        if (this.poisonUIPanel != null) {
          lVar2 = GameObject.get_transform(this.poisonUIPanel,0);
          if (lVar2 != null) {
            lVar2 = Transform.Find(lVar2,"PoisonMaterial",0);
            if (lVar2 != null) {
              uVar3 = Component.get_gameObject(lVar2,0);
              if (*pStatics_2a90 != 0) {
                uVar1 = *(uint64 *)(*pStatics_2a90 + 160);
                uVar3 = GlobalData.AddChild(uVar3,uVar1,0);
                this.poisonMaterialItemIcon = uVar3;
                if (this.poisonMaterialItemIcon != null) {
                  lVar2 = GameObject.GetComponent(this.poisonMaterialItemIcon,DAT_181e55168);
                  if ((*pStatics_77e8 != 0) &&
                     (lVar4 = *(int64 *)(*pStatics_77e8 + 72)) != null) {
                    lVar4 = GameObject.GetComponent(lVar4,DAT_181e55168);
                    if ((lVar4 != null) && (lVar2 != null)) {
                      *(uint64 *)(lVar2 + 32) = *(uint64 *)(lVar4 + 32);
                      if (this.poisonMaterialItemIcon != null) {
                        lVar2 = GameObject.GetComponent(this.poisonMaterialItemIcon,DAT_181e55168);
                        if (lVar2 != null) {
                          *(uint32 *)(lVar2 + 40) = 1;
                          if (this.poisonMaterialItemIcon != null) {
                            lVar2 = GameObject.GetComponent(this.poisonMaterialItemIcon,DAT_181e55168);
                            if (lVar2 != null) {
                              ItemIconController.AutoSetName(lVar2,1,0);
                              if (this.poisonMaterialClearButton != null) {
                                GameObject.SetActive(this.poisonMaterialClearButton,1,0);
                                CraftPoisonUIController.RefreshCraftPoisonInfo(this,0);
                                if (this.poisonUIPanel != null) {
                                  lVar2 = GameObject.get_transform(this.poisonUIPanel,0);
                                  if (lVar2 != null) {
                                    uVar3 = Transform.Find(lVar2,"MaterialLine",0);
                                    ShortcutExtensions.DOScaleX(uVar3,0x3f800000,0x3e800000,0);
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

    // Token : 0x6001362
    // RVA   : 0x64BE50   Offset: 0x64AC50   Length: 0xE7
    public void ClearPoisonMaterial()
    {
        long lVar1;
        ulong uVar2;
        uVar2 = this.poisonMaterialItemIcon;
        Object.Destroy(uVar2,0);
        this.poisonMaterialItemIcon = 0;
        if (this.poisonMaterialClearButton != null) {
          GameObject.SetActive(this.poisonMaterialClearButton,0,0);
          CraftPoisonUIController.RefreshCraftPoisonInfo(this,0);
          if (this.poisonUIPanel != null) {
            lVar1 = GameObject.get_transform(this.poisonUIPanel,0);
            if (lVar1 != null) {
              uVar2 = Transform.Find(lVar1,"MaterialLine",0);
              ShortcutExtensions.DOScaleX(uVar2,0,0x3e800000,0);
              return;
            }
          }
        }
    }

    // Token : 0x6001363
    // RVA   : 0x64C9F0   Offset: 0x64B7F0   Length: 0x2BF
    public void PoisonMaterialButtonClickedSub()
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        long lVar4;
        uint[] local_res8 = new uint[2];
        uint[] local_res18 = new uint[4];
        uVar3 = this.poisonMaterialItemIconSub;
        cVar1 = Object.op_Inequality(uVar3,0,0);
        if (cVar1) {
          return;
        }
        uVar3 = this.poisonTargetItemIcon;
        cVar1 = Object.op_Equality(uVar3,0,0);
        if (!cVar1) {
          lVar4 = **(int64 **)(DAT_181e977e8 + 184);
          lVar2 = il2cpp_internal(DAT_181e74e38);
          FUN_1810f3480(lVar2,DAT_181e77ae0);
          local_res8[0] = 0;
          uVar3 = il2cpp_value_box(DAT_181e60808,local_res8);
          if (lVar2 != null) {
            FUN_18175de30(lVar2,uVar3,DAT_181e77be0);
            local_res18[0] = 5;
            uVar3 = il2cpp_value_box(DAT_181e60808,local_res18);
            FUN_18175de30(lVar2,uVar3,DAT_181e77be0);
            uVar3 = Component.get_gameObject(this,0);
            if (lVar4 != null) {
              ChooseController.ShowChoosePanel(lVar4,1,lVar2,uVar3,"PoisonMaterialChoosenSub",0,15,0,0,0);
              return;
            }
          }
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        lVar4 = FUN_1802106e0(0);
        if (lVar4 == null) {
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        GameController.ShowTextOnMouse(lVar4,"需要先选择用毒目标！",0);
        plVar5 = (int64 *)Resources.Load("Sound/SoundEffect/WrongClick",0);
        plVar6 = (int64 *)0;
        if ((plVar5 != (int64 *)0) && (*plVar5 == DAT_181e8f4a0)) {
          plVar6 = plVar5;
        }
        NGUITools.PlaySound(plVar6,0);
    }

    // Token : 0x6001364
    // RVA   : 0x64CF70   Offset: 0x64BD70   Length: 0x26E
    public void PoisonMaterialChoosenSub()
    {
        var pStatics_2a90 = *(int64*)(DAT_181e52a90 + 184);
        var pStatics_77e8 = *(int64*)(DAT_181e977e8 + 184);
        ulong uVar1;
        long lVar2;
        ulong uVar3;
        long lVar4;
        if (this.poisonUIPanel != null) {
          lVar2 = GameObject.get_transform(this.poisonUIPanel,0);
          if (lVar2 != null) {
            lVar2 = Transform.Find(lVar2,"PoisonMaterialSub",0);
            if (lVar2 != null) {
              uVar3 = Component.get_gameObject(lVar2,0);
              if (*pStatics_2a90 != 0) {
                uVar1 = *(uint64 *)(*pStatics_2a90 + 160);
                uVar3 = GlobalData.AddChild(uVar3,uVar1,0);
                this.poisonMaterialItemIconSub = uVar3;
                if (this.poisonMaterialItemIconSub != null) {
                  lVar2 = GameObject.GetComponent(this.poisonMaterialItemIconSub,DAT_181e55168);
                  if ((*pStatics_77e8 != 0) &&
                     (lVar4 = *(int64 *)(*pStatics_77e8 + 72)) != null) {
                    lVar4 = GameObject.GetComponent(lVar4,DAT_181e55168);
                    if ((lVar4 != null) && (lVar2 != null)) {
                      *(uint64 *)(lVar2 + 32) = *(uint64 *)(lVar4 + 32);
                      if (this.poisonMaterialItemIconSub != null) {
                        lVar2 = GameObject.GetComponent(this.poisonMaterialItemIconSub,DAT_181e55168);
                        if (lVar2 != null) {
                          *(uint32 *)(lVar2 + 40) = 1;
                          if (this.poisonMaterialItemIconSub != null) {
                            lVar2 = GameObject.GetComponent(this.poisonMaterialItemIconSub,DAT_181e55168);
                            if (lVar2 != null) {
                              ItemIconController.AutoSetName(lVar2,1,0);
                              if (this.poisonMaterialClearButtonSub != null) {
                                GameObject.SetActive(this.poisonMaterialClearButtonSub,1,0);
                                CraftPoisonUIController.RefreshCraftPoisonInfo(this,0);
                                if (this.poisonUIPanel != null) {
                                  lVar2 = GameObject.get_transform(this.poisonUIPanel,0);
                                  if (lVar2 != null) {
                                    uVar3 = Transform.Find(lVar2,"MaterialLineSub",0);
                                    ShortcutExtensions.DOScaleX(uVar3,0x3f800000,0x3e800000,0);
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

    // Token : 0x6001365
    // RVA   : 0x64BD60   Offset: 0x64AB60   Length: 0xE7
    public void ClearPoisonMaterialSub()
    {
        long lVar1;
        ulong uVar2;
        uVar2 = this.poisonMaterialItemIconSub;
        Object.Destroy(uVar2,0);
        this.poisonMaterialItemIconSub = 0;
        if (this.poisonMaterialClearButtonSub != null) {
          GameObject.SetActive(this.poisonMaterialClearButtonSub,0,0);
          CraftPoisonUIController.RefreshCraftPoisonInfo(this,0);
          if (this.poisonUIPanel != null) {
            lVar1 = GameObject.get_transform(this.poisonUIPanel,0);
            if (lVar1 != null) {
              uVar2 = Transform.Find(lVar1,"MaterialLineSub",0);
              ShortcutExtensions.DOScaleX(uVar2,0,0x3e800000,0);
              return;
            }
          }
        }
    }

    // Token : 0x6001366
    // RVA   : 0x64C550   Offset: 0x64B350   Length: 0x16F
    public HeroSpeAddData GetTotalPoisonSpeAddData()
    {
        bool cVar1;
        ulong uVar2;
        long lVar3;
        ulong uVar4;
        uVar2 = new HeroSpeAddData(0);
        uVar4 = this.poisonMaterialItemIcon;
        cVar1 = Object.op_Inequality(uVar4,0,0);
        if (cVar1) {
          if ((((this.poisonMaterialItemIcon == null) ||
               (lVar3 = GameObject.GetComponent(this.poisonMaterialItemIcon,DAT_181e55168)) == null
               ) || (*(int64 *)(lVar3 + 32) == 0)) ||
             (lVar3 = *(int64 *)(*(int64 *)(lVar3 + 32) + 128)) == null) throw; // [null/range check failed]
          uVar2 = HeroSpeAddData.op_Addition(uVar2,*(uint64 *)(lVar3 + 16),0);
        }
        uVar4 = this.poisonMaterialItemIconSub;
        cVar1 = Object.op_Inequality(uVar4,0,0);
        if (!cVar1) {
          return uVar2;
        }
        if (((this.poisonMaterialItemIconSub != null) &&
            (lVar3 = GameObject.GetComponent(this.poisonMaterialItemIconSub,DAT_181e55168)) != null)
           && ((*(int64 *)(lVar3 + 32) != 0 &&
               (lVar3 = *(int64 *)(*(int64 *)(lVar3 + 32) + 128)) != null))) {
          uVar4 = HeroSpeAddData.op_Addition(uVar2,*(uint64 *)(lVar3 + 16),0);
          return uVar4;
        }
    }

    // Token : 0x6001367
    // RVA   : 0x64D990   Offset: 0x64C790   Length: 0x7CF
    public void RefreshCraftPoisonInfo()
    {
        int iVar1;
        bool cVar3;
        long lVar4;
        ulong uVar6;
        ulong uVar7;
        long lVar8;
        ulong uVar9;
        ulong uVar10;
        float fVar11;
        uint[] local_res18 = new uint[2];
        uint[] local_res20 = new uint[2];
        ulong in_stack_ffffffffffffffb8;
        uint local_38;
        uint uStack_34;
        uint uStack_30;
        uint32 uStack_2c;
        local_res18[0] = 0;
        if (((GameController._instance == null) ||
            (lVar4 = GameController._instance.worldData) == null) ||
           (lVar4 = WorldData.Player(lVar4,0)) == null) goto LAB_18064e154;
        cVar3 = HeroData.HaveForceFunction(lVar4,7);
        lVar4 = this.poisonUIPanel;
        if (!cVar3) {
          if (((lVar4 == null) || (lVar4 = GameObject.get_transform(lVar4,0)) == null) ||
             (lVar4 = Transform.Find(lVar4,"PoisonMaterialSub",0)) == null) goto LAB_18064e154;
          lVar4 = Component.get_gameObject(lVar4,0);
          if (lVar4 == null) goto LAB_18064e154;
          uVar10 = 0;
        }
        else {
          if (((lVar4 == null) || (lVar4 = GameObject.get_transform(lVar4,0)) == null) ||
             (lVar4 = Transform.Find(lVar4,"PoisonMaterialSub",0)) == null) goto LAB_18064e154;
          lVar4 = Component.get_gameObject(lVar4,0);
          if (lVar4 == null) goto LAB_18064e154;
          uVar10 = 1;
        }
        GameObject.SetActive(lVar4,uVar10,0);
        uVar10 = this.poisonTargetItemIcon;
        cVar3 = Object.op_Equality(uVar10,0,0);
        if (!cVar3) {
          uVar10 = this.poisonMaterialItemIcon;
          cVar3 = Object.op_Equality(uVar10,0,0);
          if (cVar3) {
            uVar10 = this.poisonMaterialItemIconSub;
            cVar3 = Object.op_Equality(uVar10,0,0);
            if (cVar3) goto LAB_18064e0fd;
          }
          plVar2 = this.PoisonExtraAdd;
          puVar5 = (uint32 *)Color.get_black(&local_38,0);
          if (plVar2 == (int64 *)0) {
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          local_38 = *puVar5;
          uStack_34 = puVar5[1];
          uStack_30 = puVar5[2];
          uStack_2c = puVar5[3];
          (**(code **)(*plVar2 + 0x2a8))(plVar2,&local_38,*(uint64 *)(*plVar2 + 0x2b0));
          uVar10 = this.CostTime;
          local_res20[0] = CraftPoisonUIController.GetCostTime(this,0);
          uVar6 = il2cpp_value_box(DAT_181e60808,local_res20);
          uVar6 = String.Format("消耗时间：{0}天",uVar6,0);
          LTLocalization.SetText(uVar10,uVar6,0);
          LTLocalization.SetText(this.PoisonExtraAdd,"",0);
          iVar1 = this.craftPoisonType;
          if (iVar1 == 0) {
            uVar10 = this.PoisonExtraAdd;
            local_res18[0] = CraftPoisonUIController.GetChangePoisonNum(this,0);
            uVar6 = Single.ToString(local_res18,"f0",0);
            uVar9 = new HeroSpeAddData(0);
            uVar7 = this.poisonMaterialItemIcon;
            cVar3 = Object.op_Inequality(uVar7,0,0);
            if (cVar3) {
              if ((((this.poisonMaterialItemIcon == null) ||
                   (lVar4 = GameObject.GetComponent(this.poisonMaterialItemIcon,DAT_181e55168),
                   lVar4 == null)) || (lVar4.villageAreaID == null)) ||
                 (lVar4 = *(int64 *)(lVar4.villageAreaID + 128)) == null)
              goto LAB_18064e154;
              uVar9 = HeroSpeAddData.op_Addition(uVar9,lVar4.chapter,0);
            }
            uVar7 = this.poisonMaterialItemIconSub;
            cVar3 = Object.op_Inequality(uVar7,0,0);
            if (cVar3) {
              if (((this.poisonMaterialItemIconSub == null) ||
                  (lVar4 = GameObject.GetComponent(this.poisonMaterialItemIconSub,DAT_181e55168),
                  lVar4 == null)) ||
                 ((lVar4.villageAreaID == null ||
                  (lVar4 = *(int64 *)(lVar4.villageAreaID + 128)) == null)))
              goto LAB_18064e154;
              uVar9 = HeroSpeAddData.op_Addition(uVar9,lVar4.chapter,0);
            }
            fVar11 = (float)CraftPoisonUIController.GetChangePoisonNum(this,0);
            lVar4 = HeroSpeAddData.op_Multiply(uVar9,fVar11 * 0.01,0);
            if (lVar4 == null) goto LAB_18064e154;
            uVar7 = HeroSpeAddData.GetDescribe
                              (lVar4,1,1,1,in_stack_ffffffffffffffb8 & 0xffffffffffffff00,0);
            uVar6 = String.Concat("淬毒 ",uVar6,"\n\n淬毒加成\n",uVar7,0);
            LTLocalization.SetText(uVar10,uVar6,0);
            lVar4 = this.craftPoisonButton;
          }
          else {
            if (iVar1 == 1) {
              uVar10 = this.PoisonExtraAdd;
              local_res18[0] = CraftPoisonUIController.GetChangePoisonNum(this,0);
              uVar7 = Single.ToString(local_res18,"f0",0);
              uVar6 = "下毒 ";
            }
            else {
              if (iVar1 != 2) {
                return;
              }
              uVar10 = this.PoisonExtraAdd;
              local_res18[0] = CraftPoisonUIController.GetChangePoisonNum(this,0);
              uVar7 = Single.ToString(local_res18,"f0",0);
              uVar6 = "消毒 ";
            }
            uVar6 = String.Concat(uVar6,uVar7,0);
            LTLocalization.SetText(uVar10,uVar6,0);
            fVar11 = (float)CraftPoisonUIController.GetChangePoisonNum(this,0);
            if (((this.poisonTargetItemIcon == null) ||
                (lVar8 = GameObject.GetComponent(this.poisonTargetItemIcon,DAT_181e55168), lVar8 == null
                )) || (*(int64 *)(lVar8 + 32) == 0)) goto LAB_18064e154;
            lVar4 = this.craftPoisonButton;
            if (fVar11 < *(float *)(*(int64 *)(lVar8 + 32) + 76)) {
              if (lVar4 != null) {
                Selectable.set_interactable(lVar4,0,0);
                plVar2 = this.PoisonExtraAdd;
                lVar4 = *(int64 *)(DAT_181e538e8 + 184);
                if (plVar2 != (int64 *)0) {
                  local_38 = *(uint32 *)(lVar4 + 0x2f8);
                  uStack_34 = *(uint32 *)(lVar4 + 0x2fc);
                  uStack_30 = *(uint32 *)(lVar4 + 0x300);
                  uStack_2c = *(uint32 *)(lVar4 + 0x304);
                  (**(code **)(*plVar2 + 0x2a8))(plVar2,&local_38,*(uint64 *)(*plVar2 + 0x2b0));
                  return;
                }
              }
              goto LAB_18064e154;
            }
          }
          if (lVar4 == null) {
        LAB_18064e154:
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          uVar10 = 1;
        }
        else {
        LAB_18064e0fd:
          uVar10 = this.CostTime;
          LTLocalization.SetText(uVar10,"",0);
          LTLocalization.SetText(this.PoisonExtraAdd,"",0);
          lVar4 = this.craftPoisonButton;
          if (lVar4 == null) goto LAB_18064e154;
          uVar10 = 0;
        }
        Selectable.set_interactable(lVar4,uVar10,0);
    }

    // Token : 0x6001368
    // RVA   : 0x64C420   Offset: 0x64B220   Length: 0x126
    public float GetMaterialTotalCraftRate()
    {
        bool cVar1;
        long lVar2;
        float fVar3;
        ulong uVar4;
        float fVar5;
        uint uVar6;
        fVar5 = 0.0;
        uVar6 = 0;
        uVar4 = this.poisonMaterialItemIcon;
        cVar1 = Object.op_Inequality(uVar4,0,0);
        if (cVar1) {
          if (this.poisonMaterialItemIcon == null) goto LAB_18064c541;
          lVar2 = GameObject.GetComponent(this.poisonMaterialItemIcon,DAT_181e55168);
          if ((lVar2 == null) || (*(int64 *)(lVar2 + 32) == 0)) goto LAB_18064c541;
          uVar4 = ItemData.GetMaterialExtraCraftRate(*(int64 *)(lVar2 + 32),0);
          uVar6 = (uint32)((uint64)uVar4 >> 32);
          fVar5 = (float)uVar4 + 0.0;
        }
        uVar4 = this.poisonMaterialItemIconSub;
        cVar1 = Object.op_Inequality(uVar4,0,0);
        if (cVar1) {
          if (this.poisonMaterialItemIconSub != null) {
            lVar2 = GameObject.GetComponent(this.poisonMaterialItemIconSub,DAT_181e55168);
            if ((lVar2 != null) && (*(int64 *)(lVar2 + 32) != 0)) {
              fVar3 = (float)ItemData.GetMaterialExtraCraftRate(*(int64 *)(lVar2 + 32),0);
              fVar5 = fVar5 + fVar3;
              goto LAB_18064c52e;
            }
          }
        LAB_18064c541:
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        LAB_18064c52e:
        return CONCAT44(uVar6,fVar5);
    }

    // Token : 0x6001369
    // RVA   : 0x64C170   Offset: 0x64AF70   Length: 0x227
    public float GetChangePoisonNum()
    {
        float fVar1;
        bool cVar2;
        long lVar3;
        float fVar4;
        ulong uVar5;
        float fVar6;
        uint uVar7;
        if ((GameController._instance != null) &&
           (lVar3 = GameController._instance.worldData) != null) {
          lVar3 = WorldData.Player(lVar3,0);
          if ((lVar3 = lVar3?.showRoomChangeFame) != null) {
            if (lVar3.cityAreaID < 2) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            fVar1 = *(float *)(lVar3.chapter + 36);
            fVar6 = 0.0;
            uVar7 = 0;
            uVar5 = this.poisonMaterialItemIcon;
            cVar2 = Object.op_Inequality(uVar5,0,0);
            if (cVar2) {
              if (this.poisonMaterialItemIcon == null) throw; // [null/range check failed]
              lVar3 = GameObject.GetComponent(this.poisonMaterialItemIcon,DAT_181e55168);
              if ((lVar3 == null) || (lVar3.villageAreaID == null)) throw; // [null/range check failed]
              uVar5 = ItemData.GetMaterialExtraCraftRate(lVar3.villageAreaID,0);
              uVar7 = (uint32)((uint64)uVar5 >> 32);
              fVar6 = (float)uVar5 + 0.0;
            }
            uVar5 = this.poisonMaterialItemIconSub;
            cVar2 = Object.op_Inequality(uVar5,0,0);
            if (!cVar2) {
        LAB_18064c36e:
              return CONCAT44(uVar7,(fVar6 + 1.0) * fVar1);
            }
            if (this.poisonMaterialItemIconSub != null) {
              lVar3 = GameObject.GetComponent(this.poisonMaterialItemIconSub,DAT_181e55168);
              if ((lVar3 != null) && (lVar3.villageAreaID != null)) {
                fVar4 = (float)ItemData.GetMaterialExtraCraftRate(lVar3.villageAreaID,0);
                fVar6 = fVar6 + fVar4;
                goto LAB_18064c36e;
              }
            }
          }
        }
    }

    // Token : 0x600136A
    // RVA   : 0x64C3A0   Offset: 0x64B1A0   Length: 0x7F
    public int GetCostTime()
    {
        long lVar1;
        if (this.craftPoisonType != null) {
          return 1;
        }
        if (this.poisonTargetItemIcon != null) {
          lVar1 = GameObject.GetComponent(this.poisonTargetItemIcon,DAT_181e55168);
          if ((lVar1 != null) && (*(int64 *)(lVar1 + 32) != 0)) {
            return 1 - (int)((float)*(int *)(*(int64 *)(lVar1 + 32) + 60) * -0.5);
          }
        }
    }

    // Token : 0x600136B
    // RVA   : 0x64C7F0   Offset: 0x64B5F0   Length: 0x1FA
    public void PoisonButtonClicked()
    {
        uint uVar1;
        long lVar2;
        long lVar3;
        ulong uVar4;
        uint uVar5;
        plVar6 = (int64 *)Resources.Load("Sound/SoundEffect/SpeEffect/毒气",0);
        plVar7 = (int64 *)0;
        if ((plVar6 != (int64 *)0) && (*plVar6 == DAT_181e8f4a0)) {
          plVar7 = plVar6;
        }
        NGUITools.PlaySound(plVar7,0);
        lVar2 = *(int64 *)(*(int64 *)(DAT_181e962e8 + 184) + 8);
        lVar3 = *(int64 *)(*(int64 *)(DAT_181e538e8 + 184) + 0x5a8);
        if (lVar3 != null) {
          uVar1 = this.craftPoisonType;
          if (*(uint32 *)(lVar3 + 24) <= uVar1) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          uVar4 = lVar3[uVar1];
          uVar5 = CraftPoisonUIController.GetCostTime(this,0);
          if (lVar2 != null) {
            WorkingUIController.StartWorking
                      (lVar2,uVar4,uVar5,"","","FinishCraftPoison","",0);
            return;
          }
        }
    }

    // Token : 0x600136C
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

}
