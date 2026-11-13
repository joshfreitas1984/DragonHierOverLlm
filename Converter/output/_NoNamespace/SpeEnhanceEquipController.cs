// ============================================================
// Type  : SpeEnhanceEquipController
// Token : 0x2000372
// ============================================================

public class SpeEnhanceEquipController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001C60
    public GameObject speEnhanceEquipUI;

    // Token: 0x4001C61
    public GameObject speEnhanceEquipChoicePrefab;

    // Token: 0x4001C62
    public GameObject enhanceChoiceGrid;

    // Token: 0x4001C63
    public GameObject enhanceTargetItemIcon;

    // Token: 0x4001C64
    public GameObject enhanceTargetClearButton;

    // Token: 0x4001C65
    public GameObject nowChoice;

    // Token: 0x4001C66
    public bool needRefresh;

    // Token: 0x4001C67
    private static SpeEnhanceEquipController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60021FE
    // RVA   : 0x6B85A0   Offset: 0x6B73A0   Length: 0xB6
    public static SpeEnhanceEquipController get_Instance()
    {
        return **(uint64 **)(DAT_181e846a8 + 184);
    }

    // Token : 0x60021FF
    // RVA   : 0x6B6680   Offset: 0x6B5480   Length: 0x43
    private void Awake()
    {
        puVar1 = *(uint64 **)(DAT_181e846a8 + 184);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x6002200
    // RVA   : 0x6B8560   Offset: 0x6B7360   Length: 0x3D
    private void Update()
    {
        bool cVar1;
        if (this.speEnhanceEquipUI == null) {
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        cVar1 = GameObject.get_activeSelf(this.speEnhanceEquipUI,0);
        if ((cVar1) && (this.needRefresh)) {
          SpeEnhanceEquipController.RefreshUI(this,0);
          return;
        }
    }

    // Token : 0x6002201
    // RVA   : 0x6B7B80   Offset: 0x6B6980   Length: 0x102
    public void HideSpeEnhanceEquipUI()
    {
        ulong uVar1;
        uVar1 = this.enhanceTargetItemIcon;
        Object.Destroy(uVar1,0);
        this.enhanceTargetItemIcon = 0;
        if (this.enhanceTargetClearButton != null) {
          GameObject.SetActive(this.enhanceTargetClearButton,0,0);
          this.nowChoice = 0;
          uVar1 = this.enhanceChoiceGrid;
          GlobalData.DeleteAllChild(uVar1,0);
          this.needRefresh = 1;
          if (this.speEnhanceEquipUI != null) {
            GameObject.SetActive(this.speEnhanceEquipUI,0,0);
            return;
          }
        }
    }

    // Token : 0x6002202
    // RVA   : 0x6B84B0   Offset: 0x6B72B0   Length: 0xAF
    public void ShowSpeEnhanceEquipUI()
    {
        if (this.speEnhanceEquipUI != null) {
          GameObject.SetActive(this.speEnhanceEquipUI,1,0);
          SpeEnhanceEquipController.RefreshUI(this,0);
          plVar1 = (int64 *)Resources.Load("Sound/SoundEffect/OpenBook",0);
          plVar2 = (int64 *)0;
          if ((plVar1 != (int64 *)0) && (*plVar1 == DAT_181e8f4a0)) {
            plVar2 = plVar1;
          }
          NGUITools.PlaySound(plVar2,0);
          return;
        }
    }

    // Token : 0x6002203
    // RVA   : 0x6B7E20   Offset: 0x6B6C20   Length: 0x427
    public void RefreshUI()
    {
        int iVar1;
        bool cVar2;
        long lVar3;
        ulong uVar5;
        ulong uVar6;
        uint uVar7;
        int[] local_res8 = new int[2];
        uint[] local_res18 = new uint[2];
        ulong local_28;
        ulong uStack_20;
        uint local_18;
        uint uStack_14;
        uint uStack_10;
        uint32 uStack_c;
        local_res8[0] = 0;
        this.needRefresh = 0;
        if ((((this.speEnhanceEquipUI == null) ||
             (lVar3 = GameObject.get_transform(this.speEnhanceEquipUI,0)) == null) ||
            (lVar3 = Transform.Find(lVar3,"EnhanceChoice",0)) == null) ||
           (lVar3 = Transform.Find(lVar3,"Back",0)) == null) throw; // [null/range check failed]
        plVar4 = (int64 *)Component.GetComponent(lVar3,DAT_181e777b8);
        uVar6 = this.enhanceTargetItemIcon;
        cVar2 = Object.op_Equality(uVar6,0,0);
        if (!cVar2) {
          uVar7 = 0x3f800000;
        }
        else {
          uVar7 = 0x3f000000;
        }
        local_28 = 0;
        uStack_20 = 0;
        FUN_1807282e0(&local_28,0x3f800000,0x3f800000,0x3f800000,uVar7,0);
        if (plVar4 == (int64 *)0) {
        LAB_1806b8242:
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        local_18 = (uint32)local_28;
        uStack_14 = local_28._4_4_;
        uStack_10 = (uint32)uStack_20;
        uStack_c = uStack_20._4_4_;
        (**(code **)(*plVar4 + 0x2a8))(plVar4,&local_18,*(uint64 *)(*plVar4 + 0x2b0));
        if (((this.speEnhanceEquipUI == null) ||
            (lVar3 = GameObject.get_transform(this.speEnhanceEquipUI,0)) == null) ||
           (lVar3 = Transform.Find(lVar3,"CostStone",0)) == null) goto LAB_1806b8242;
        uVar5 = Component.GetComponent(lVar3,DAT_181e79538);
        uVar6 = this.enhanceTargetItemIcon;
        cVar2 = Object.op_Equality(uVar6,0,0);
        uVar6 = "0";
        if (!cVar2) {
          if (((this.enhanceTargetItemIcon == null) ||
              (lVar3 = GameObject.GetComponent(this.enhanceTargetItemIcon,DAT_181e55168)) == null)
             || (*(int64 *)(lVar3 + 32) == 0)) throw; // [null/range check failed]
          iVar1 = *(int *)(*(int64 *)(lVar3 + 32) + 60);
          if (((this.enhanceTargetItemIcon == null) ||
              (lVar3 = GameObject.GetComponent(this.enhanceTargetItemIcon,DAT_181e55168)) == null)
             || ((*(int64 *)(lVar3 + 32) == 0 ||
                 (lVar3 = *(int64 *)(*(int64 *)(lVar3 + 32) + 96)) == null)))
          throw; // [null/range check failed]
          local_res8[0] = ~*(uint32 *)(lVar3 + 72) - iVar1;
          uVar6 = Int32.ToString(local_res8,0);
        }
        LTLocalization.SetText(uVar5,uVar6,0);
        if (((this.speEnhanceEquipUI != null) &&
            (lVar3 = GameObject.get_transform(this.speEnhanceEquipUI,0)) != null) &&
           (lVar3 = Transform.Find(lVar3,"CostTime",0)) != null) {
          uVar5 = Component.GetComponent(lVar3,DAT_181e79538);
          uVar6 = this.enhanceTargetItemIcon;
          cVar2 = Object.op_Equality(uVar6,0,0);
          uVar6 = "";
          if (!cVar2) {
            local_res18[0] = SpeEnhanceEquipController.GetTimeNeed(this,0);
            uVar6 = il2cpp_value_box(DAT_181e60808,local_res18);
            uVar6 = String.Format("消耗时间：{0}天",uVar6,0);
          }
          LTLocalization.SetText(uVar5,uVar6,0);
          SpeEnhanceEquipController.RefreshEnhanceButtonState(this,0);
          return;
        }
    }

    // Token : 0x6002204
    // RVA   : 0x6B67E0   Offset: 0x6B55E0   Length: 0x56
    public void ClearAllChoice()
    {
        ulong uVar1;
        uVar1 = this.enhanceChoiceGrid;
        GlobalData.DeleteAllChild(uVar1,0);
    }

    // Token : 0x6002205
    // RVA   : 0x6B7680   Offset: 0x6B6480   Length: 0x39F
    public void GenerateChoice()
    {
        bool cVar1;
        int iVar2;
        uint uVar3;
        long lVar4;
        long lVar5;
        ulong uVar6;
        long lVar7;
        int iVar8;
        int iVar9;
        uVar6 = this.enhanceTargetItemIcon;
        cVar1 = Object.op_Inequality(uVar6,0,0);
        if (!cVar1) {
          return;
        }
        if ((this.enhanceTargetItemIcon != null) &&
           (lVar4 = GameObject.GetComponent(this.enhanceTargetItemIcon,DAT_181e55168)) != null) {
          lVar4 = *(int64 *)(lVar4 + 32);
          iVar8 = 0;
          iVar9 = 0;
          if (lVar4 != null) {
            while ((((*(int64 *)(lVar4 + 96) != 0 &&
                     (lVar5 = *(int64 *)(*(int64 *)(lVar4 + 96) + 32)) != null) &&
                    (lVar5 = *(int64 *)(lVar5 + 16)) != null) &&
                   (lVar5 = Dictionary_2.get_Keys(lVar5,DAT_181e9fd50)) != null)) {
              iVar2 = FUN_180b34300(lVar5,DAT_181ea5bc8);
              if (iVar2 <= iVar9) goto LAB_1806b78be;
              if (((*(int64 *)(lVar4 + 96) == 0) ||
                  (lVar5 = *(int64 *)(*(int64 *)(lVar4 + 96) + 32)) == null) ||
                 (lVar5 = *(int64 *)(lVar5 + 16)) == null) break;
              uVar6 = Dictionary_2.get_Keys(lVar5,DAT_181e9fd50);
              uVar3 = FUN_180779bf0(uVar6,iVar9,DAT_181e96680);
              lVar5 = new HeroSpeAddData(0);
              lVar7 = FUN_180210740(0);
              if ((((lVar7 == null) || (*(int64 *)(lVar7 + 144) == 0)) ||
                  (lVar7 = FUN_1800024b0(*(int64 *)(lVar7 + 144),uVar3,DAT_181e6e1f0)) == null) ||
                 (lVar5 == null)) break;
              uVar6 = HeroSpeAddData.Set(lVar5,uVar3,*(uint32 *)(lVar7 + 32));
              SpeEnhanceEquipController.CreateEnhanceChoiceButton(this,uVar6,1,0);
              iVar9 = iVar9 + 1;
            }
          }
        }
        LAB_1806b7a1a:
                          // WARNING: Subroutine does not return
        FUN_1801e0300();
        LAB_1806b78be:
        if (((*(int64 *)(lVar4 + 96) == 0) ||
            (lVar5 = *(int64 *)(*(int64 *)(lVar4 + 96) + 40)) == null) ||
           ((lVar5 = *(int64 *)(lVar5 + 16), lVar5 == null ||
            (lVar5 = Dictionary_2.get_Keys(lVar5,DAT_181e9fd50)) == null))) goto LAB_1806b7a1a;
        iVar9 = FUN_180b34300(lVar5,DAT_181ea5bc8);
        if (iVar9 <= iVar8) {
          SpeEnhanceEquipController.CreateEnhanceChoiceButton(this,0,1,0);
          return;
        }
        if (((*(int64 *)(lVar4 + 96) == 0) ||
            (lVar5 = *(int64 *)(*(int64 *)(lVar4 + 96) + 40)) == null) ||
           (lVar5 = *(int64 *)(lVar5 + 16)) == null) goto LAB_1806b7a1a;
        uVar6 = Dictionary_2.get_Keys(lVar5,DAT_181e9fd50);
        uVar3 = FUN_180779bf0(uVar6,iVar8,DAT_181e96680);
        lVar5 = new HeroSpeAddData(0);
        lVar7 = FUN_180210740(0);
        if ((((lVar7 == null) || (*(int64 *)(lVar7 + 144) == 0)) ||
            (lVar7 = FUN_1800024b0(*(int64 *)(lVar7 + 144),uVar3,DAT_181e6e1f0)) == null) ||
           (lVar5 == null)) goto LAB_1806b7a1a;
        uVar6 = HeroSpeAddData.Set(lVar5,uVar3,*(float *)(lVar7 + 32) + *(float *)(lVar7 + 32));
        SpeEnhanceEquipController.CreateEnhanceChoiceButton(this,uVar6,0,0);
        iVar8 = iVar8 + 1;
        goto LAB_1806b78be;
    }

    // Token : 0x6002206
    // RVA   : 0x6B66D0   Offset: 0x6B54D0   Length: 0x104
    public bool CanEnhance()
    {
        int iVar1;
        ulong uVar2;
        bool cVar3;
        int iVar4;
        long lVar5;
        uVar2 = this.enhanceTargetItemIcon;
        cVar3 = Object.op_Inequality(uVar2,0,0);
        if (cVar3) {
          uVar2 = this.nowChoice;
          cVar3 = Object.op_Inequality(uVar2,0,0);
          if (cVar3) {
            lVar5 = FUN_1802106e0(0);
            if ((lVar5 != null) && (*(int64 *)(lVar5 + 32) != 0)) {
              iVar1 = *(int *)(*(int64 *)(lVar5 + 32) + 0x230);
              iVar4 = SpeEnhanceEquipController.GetStoneNeed(this,0);
              return iVar4 <= iVar1;
            }
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
        }
        return false;
    }

    // Token : 0x6002207
    // RVA   : 0x6B7A20   Offset: 0x6B6820   Length: 0x93
    public int GetStoneNeed()
    {
        int iVar1;
        long lVar2;
        if (this.enhanceTargetItemIcon != null) {
          lVar2 = GameObject.GetComponent(this.enhanceTargetItemIcon,DAT_181e55168);
          if ((lVar2 != null) && (*(int64 *)(lVar2 + 32) != 0)) {
            iVar1 = *(int *)(*(int64 *)(lVar2 + 32) + 60);
            if (this.enhanceTargetItemIcon != null) {
              lVar2 = GameObject.GetComponent(this.enhanceTargetItemIcon,DAT_181e55168);
              if (((lVar2 != null) && (*(int64 *)(lVar2 + 32) != 0)) &&
                 (lVar2 = *(int64 *)(*(int64 *)(lVar2 + 32) + 96)) != null) {
                return *(int *)(lVar2 + 72) + 1 + iVar1;
              }
            }
          }
        }
    }

    // Token : 0x6002208
    // RVA   : 0x6B8250   Offset: 0x6B7050   Length: 0x25F
    public void SetNowChoice(GameObject target)
    {
        ulong uVar1;
        bool cVar2;
        int iVar3;
        long lVar4;
        ulong uVar5;
        int iVar7;
        byte[] local_18 = new byte[16];
        this.nowChoice = target;
        lVar4 = this.enhanceChoiceGrid;
        iVar7 = 0;
        if (lVar4 != null) {
          while (lVar4 = GameObject.get_transform(lVar4,0)) != null {
            iVar3 = Transform.get_childCount(lVar4,0);
            if (iVar3 <= iVar7) {
              SpeEnhanceEquipController.RefreshEnhanceButtonState(this,0);
              return;
            }
            if (((this.enhanceChoiceGrid == null) ||
                (lVar4 = GameObject.get_transform(this.enhanceChoiceGrid,0)) == null) ||
               (lVar4 = Transform.GetChild(lVar4,iVar7,0)) == null) break;
            uVar5 = Component.get_gameObject(lVar4,0);
            uVar1 = this.nowChoice;
            cVar2 = Object.op_Equality(uVar5,uVar1,0);
            lVar4 = this.enhanceChoiceGrid;
            if (!cVar2) {
              if (((lVar4 == null) || (lVar4 = GameObject.get_transform(lVar4,0)) == null) ||
                 (lVar4 = Transform.GetChild(lVar4,iVar7,0)) == null) break;
              plVar6 = (int64 *)Component.GetComponent(lVar4,DAT_181e777b8);
              FUN_180f24d00(local_18,0);
              if (plVar6 == (int64 *)0) break;
              (**(code **)(*plVar6 + 0x2a8))(plVar6);
            }
            else {
              if (((lVar4 == null) || (lVar4 = GameObject.get_transform(lVar4,0)) == null) ||
                 (lVar4 = Transform.GetChild(lVar4,iVar7,0)) == null) break;
              plVar6 = (int64 *)Component.GetComponent(lVar4,DAT_181e777b8);
              if (plVar6 == (int64 *)0) break;
              (**(code **)(*plVar6 + 0x2a8))(plVar6);
            }
            lVar4 = this.enhanceChoiceGrid;
            iVar7 = iVar7 + 1;
            if (lVar4 == null) break;
          }
        }
    }

    // Token : 0x6002209
    // RVA   : 0x6B7C90   Offset: 0x6B6A90   Length: 0x183
    public void RefreshEnhanceButtonState()
    {
        int iVar1;
        ulong uVar2;
        bool cVar3;
        int iVar4;
        long lVar5;
        long lVar6;
        if (this.speEnhanceEquipUI == null) throw; // [null/range check failed]
        lVar5 = GameObject.get_transform(this.speEnhanceEquipUI,0);
        if (lVar5 == null) throw; // [null/range check failed]
        lVar5 = Transform.Find(lVar5,"EnhanceButton",0);
        if (lVar5 == null) throw; // [null/range check failed]
        lVar5 = Component.GetComponent(lVar5,DAT_181e76ab8);
        uVar2 = this.enhanceTargetItemIcon;
        cVar3 = Object.op_Inequality(uVar2,0,0);
        if (!cVar3) {
        LAB_1806b7ded:
          bVar7 = false;
        }
        else {
          uVar2 = this.nowChoice;
          cVar3 = Object.op_Inequality(uVar2,0,0);
          if (!cVar3) goto LAB_1806b7ded;
          lVar6 = FUN_1802106e0(0);
          if ((lVar6 == null) || (*(int64 *)(lVar6 + 32) == 0)) throw; // [null/range check failed]
          iVar1 = *(int *)(*(int64 *)(lVar6 + 32) + 0x230);
          iVar4 = SpeEnhanceEquipController.GetStoneNeed(this,0);
          bVar7 = iVar4 <= iVar1;
        }
        if (lVar5 != null) {
          Selectable.set_interactable(lVar5,bVar7,0);
          return;
        }
    }

    // Token : 0x600220A
    // RVA   : 0x6B7AC0   Offset: 0x6B68C0   Length: 0xBF
    public int GetTimeNeed()
    {
        int iVar1;
        long lVar2;
        if (this.enhanceTargetItemIcon != null) {
          lVar2 = GameObject.GetComponent(this.enhanceTargetItemIcon,DAT_181e55168);
          if ((lVar2 != null) && (*(int64 *)(lVar2 + 32) != 0)) {
            iVar1 = *(int *)(*(int64 *)(lVar2 + 32) + 60);
            if (this.enhanceTargetItemIcon != null) {
              lVar2 = GameObject.GetComponent(this.enhanceTargetItemIcon,DAT_181e55168);
              if (((lVar2 != null) && (*(int64 *)(lVar2 + 32) != 0)) &&
                 (lVar2 = *(int64 *)(*(int64 *)(lVar2 + 32) + 96)) != null) {
                return (int)((float)iVar1 * 0.5 + 1.0 + (float)*(int *)(lVar2 + 72) * 0.5);
              }
            }
          }
        }
    }

    // Token : 0x600220B
    // RVA   : 0x6B6930   Offset: 0x6B5730   Length: 0x254
    public GameObject CreateEnhanceChoiceButton(HeroSpeAddData _speAddData, bool _isBaseAdd)
    {
        int64 SpeEnhanceEquipController.CreateEnhanceChoiceButton
                         (int64 this,int64 _speAddData,byte _isBaseAdd)
        {
        int64 lVar1;
        int64 lVar2;
        uint64 uVar3;
        uint64 uVar4;
        uVar4 = this.enhanceChoiceGrid;
        uVar3 = this.speEnhanceEquipChoicePrefab;
        lVar1 = GlobalData.AddChild(uVar4,uVar3,0);
        if ((lVar1 != null) && (lVar2 = GameObject.GetComponent(lVar1,DAT_181e56a60)) != null) {
          *(int64 *)(lVar2 + 24) = _speAddData;
          lVar2 = GameObject.GetComponent(lVar1,DAT_181e56a60);
          if (lVar2 != null) {
            *(byte *)(lVar2 + 32) = _isBaseAdd;
            lVar2 = GameObject.get_transform(lVar1,0);
            if ((lVar2 != null) && (lVar2 = Transform.Find(lVar2,"Text",0)) != null) {
              uVar3 = Component.GetComponent(lVar2,DAT_181e79538);
              uVar4 = "重量-10%";
              if (_speAddData != null) {
                uVar4 = HeroSpeAddData.GetDescribe(_speAddData,_isBaseAdd ^ 1,1,1,0,0);
              }
              LTLocalization.SetText(uVar3,uVar4,0);
              lVar2 = GameObject.get_transform(lVar1,0);
              if ((lVar2 != null) && (lVar2 = Transform.Find(lVar2,"Type",0)) != null) {
                uVar3 = Component.GetComponent(lVar2,DAT_181e79538);
                uVar4 = "额外";
                if (_isBaseAdd != null) {
                  uVar4 = "基础";
                }
                LTLocalization.SetText(uVar3,uVar4,0);
                return lVar1;
              }
            }
          }
        }
    }

    // Token : 0x600220C
    // RVA   : 0x6B6B90   Offset: 0x6B5990   Length: 0x12A
    public GameObject CreateEnhanceTargetIcon(GameObject parent, ItemData targetItemData)
    {
        var pStatics = *(int64*)(DAT_181e52a90 + 184);
        int64 SpeEnhanceEquipController.CreateEnhanceTargetIcon
                         (uint64 this,uint64 parent,uint64 targetItemData)
        {
        uint64 uVar1;
        int64 lVar2;
        int64 lVar3;
        if (*pStatics != 0) {
          uVar1 = *(uint64 *)(*pStatics + 160);
          lVar2 = GlobalData.AddChild(parent,uVar1,0);
          if (lVar2 != null) {
            lVar3 = GameObject.GetComponent(lVar2,DAT_181e55168);
            if (lVar3 != null) {
              *(uint64 *)(lVar3 + 32) = targetItemData;
              lVar3 = GameObject.GetComponent(lVar2,DAT_181e55168);
              if (lVar3 != null) {
                *(uint32 *)(lVar3 + 40) = 1;
                lVar3 = GameObject.GetComponent(lVar2,DAT_181e55168);
                if (lVar3 != null) {
                  ItemIconController.AutoSetName(lVar3,1,0);
                  return lVar2;
                }
              }
            }
          }
        }
    }

    // Token : 0x600220D
    // RVA   : 0x6B6E90   Offset: 0x6B5C90   Length: 0x1A6
    public void EnhanceTargetButtonClicked()
    {
        long lVar1;
        bool cVar2;
        long lVar3;
        ulong uVar4;
        uint[] local_res8 = new uint[2];
        uint[] local_res18 = new uint[4];
        uVar4 = this.enhanceTargetItemIcon;
        cVar2 = Object.op_Inequality(uVar4,0,0);
        if (cVar2) {
          return;
        }
        lVar1 = **(int64 **)(DAT_181e977e8 + 184);
        lVar3 = il2cpp_internal(DAT_181e74e38);
        FUN_1810f3480(lVar3,DAT_181e77ae0);
        local_res8[0] = 0;
        uVar4 = il2cpp_value_box(DAT_181e60808,local_res8);
        if (lVar3 != null) {
          FUN_18175de30(lVar3,uVar4,DAT_181e77be0);
          local_res18[0] = 0;
          uVar4 = il2cpp_value_box(DAT_181e60808,local_res18);
          FUN_18175de30(lVar3,uVar4,DAT_181e77be0);
          uVar4 = Component.get_gameObject(this,0);
          if (lVar1 != null) {
            ChooseController.ShowChoosePanel(lVar1,1,lVar3,uVar4,"EnhanceTargetChoosen",0,0,0,0,0);
            return;
          }
        }
    }

    // Token : 0x600220E
    // RVA   : 0x6B7040   Offset: 0x6B5E40   Length: 0x230
    public void EnhanceTargetChoosen()
    {
        var pStatics_2a90 = *(int64*)(DAT_181e52a90 + 184);
        var pStatics_77e8 = *(int64*)(DAT_181e977e8 + 184);
        ulong uVar1;
        ulong uVar2;
        long lVar3;
        ulong uVar4;
        long lVar5;
        if (this.speEnhanceEquipUI != null) {
          lVar3 = GameObject.get_transform(this.speEnhanceEquipUI,0);
          if (lVar3 != null) {
            lVar3 = Transform.Find(lVar3,"EnhanceTarget",0);
            if (lVar3 != null) {
              uVar4 = Component.get_gameObject(lVar3,0);
              if ((*pStatics_77e8 != 0) &&
                 (lVar3 = *(int64 *)(*pStatics_77e8 + 72)) != null) {
                lVar3 = GameObject.GetComponent(lVar3,DAT_181e55168);
                if (lVar3 != null) {
                  uVar1 = *(uint64 *)(lVar3 + 32);
                  if (*pStatics_2a90 != 0) {
                    uVar2 = *(uint64 *)(*pStatics_2a90 + 160);
                    lVar3 = GlobalData.AddChild(uVar4,uVar2,0);
                    if (lVar3 != null) {
                      lVar5 = GameObject.GetComponent(lVar3,DAT_181e55168);
                      if (lVar5 != null) {
                        *(uint64 *)(lVar5 + 32) = uVar1;
                        lVar5 = GameObject.GetComponent(lVar3,DAT_181e55168);
                        if (lVar5 != null) {
                          *(uint32 *)(lVar5 + 40) = 1;
                          lVar5 = GameObject.GetComponent(lVar3,DAT_181e55168);
                          if (lVar5 != null) {
                            ItemIconController.AutoSetName(lVar5,1,0);
                            this.enhanceTargetItemIcon = lVar3;
                            if (this.enhanceTargetClearButton != null) {
                              GameObject.SetActive(this.enhanceTargetClearButton,1,0);
                              SpeEnhanceEquipController.GenerateChoice(this,0);
                              this.needRefresh = 1;
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

    // Token : 0x600220F
    // RVA   : 0x6B6840   Offset: 0x6B5640   Length: 0xEC
    public void ClearEnhanceTarget()
    {
        ulong uVar1;
        uVar1 = this.enhanceTargetItemIcon;
        Object.Destroy(uVar1,0);
        this.enhanceTargetItemIcon = 0;
        if (this.enhanceTargetClearButton != null) {
          GameObject.SetActive(this.enhanceTargetClearButton,0,0);
          this.nowChoice = 0;
          uVar1 = this.enhanceChoiceGrid;
          GlobalData.DeleteAllChild(uVar1,0);
          this.needRefresh = 1;
          return;
        }
    }

    // Token : 0x6002210
    // RVA   : 0x6B6CC0   Offset: 0x6B5AC0   Length: 0x1C3
    public void EnhanceButtonClicked()
    {
        long lVar1;
        uint uVar2;
        plVar3 = (int64 *)Resources.Load("Sound/SoundEffect/SpeEffect/修理升级",0);
        plVar4 = (int64 *)0;
        if ((plVar3 != (int64 *)0) && (*plVar3 == DAT_181e8f4a0)) {
          plVar4 = plVar3;
        }
        NGUITools.PlaySound(plVar4,0);
        plVar4 = (int64 *)Resources.Load("Sound/SoundEffect/Button/CraftButton",0);
        plVar3 = (int64 *)0;
        if ((plVar4 != (int64 *)0) && (*plVar4 == DAT_181e8f4a0)) {
          plVar3 = plVar4;
        }
        NGUITools.PlaySound(plVar3,0);
        lVar1 = *(int64 *)(*(int64 *)(DAT_181e962e8 + 184) + 8);
        uVar2 = SpeEnhanceEquipController.GetTimeNeed(this,0);
        if (lVar1 != null) {
          WorkingUIController.StartWorking
                    (lVar1,"锻造",uVar2,"","","FinishSpeEnhance","",0);
          return;
        }
    }

    // Token : 0x6002211
    // RVA   : 0x6B7280   Offset: 0x6B6080   Length: 0x3F8
    public void FinishSpeEnhance()
    {
        int iVar2;
        long lVar3;
        ulong uVar4;
        long lVar5;
        if (GameController._instance != null) {
          lVar3 = GameController._instance.worldData;
          iVar2 = SpeEnhanceEquipController.GetStoneNeed(this,0);
          if (lVar3 != null) {
            WorldData.ChangeSpeEnhanceStoneNum(lVar3,-iVar2,1,0);
            if (this.nowChoice != null) {
              lVar3 = GameObject.GetComponent(this.nowChoice,DAT_181e56a60);
              if (lVar3 != null) {
                if (lVar3.cityAreaID == null) {
                  if (this.enhanceTargetItemIcon == null) throw; // [null/range check failed]
                  lVar3 = GameObject.GetComponent(this.enhanceTargetItemIcon,DAT_181e55168);
                  if (((lVar3 == null) || (lVar3.villageAreaID == null)) ||
                     (lVar3 = *(int64 *)(lVar3.villageAreaID + 96)) == null)
                  throw; // [null/range check failed]
                  piVar1 = (int *)(lVar3 + 76);
                  *piVar1 = *piVar1 + 1;
                }
                else {
                  if (this.nowChoice == null) throw; // [null/range check failed]
                  lVar3 = GameObject.GetComponent(this.nowChoice,DAT_181e56a60);
                  if (lVar3 == null) throw; // [null/range check failed]
                  lVar5 = this.enhanceTargetItemIcon;
                  if (!lVar3.villageAreaID) {
                    if (lVar5 == null) throw; // [null/range check failed]
                    lVar3 = GameObject.GetComponent(lVar5,DAT_181e55168);
                    if (((lVar3 == null) || (lVar3.villageAreaID == null)) ||
                       (lVar3 = *(int64 *)(lVar3.villageAreaID + 96)) == null)
                    throw; // [null/range check failed]
                    puVar6 = (uint64 *)(lVar3 + 40);
                  }
                  else {
                    if (lVar5 == null) throw; // [null/range check failed]
                    lVar3 = GameObject.GetComponent(lVar5,DAT_181e55168);
                    if (((lVar3 == null) || (lVar3.villageAreaID == null)) ||
                       (lVar3 = *(int64 *)(lVar3.villageAreaID + 96)) == null)
                    throw; // [null/range check failed]
                    puVar6 = (uint64 *)(lVar3 + 32);
                  }
                  uVar4 = *puVar6;
                  if (this.nowChoice == null) throw; // [null/range check failed]
                  lVar3 = GameObject.GetComponent(this.nowChoice,DAT_181e56a60);
                  if (lVar3 == null) throw; // [null/range check failed]
                  uVar4 = HeroSpeAddData.op_Addition(uVar4,lVar3.cityAreaID,0);
                  *puVar6 = uVar4;
                  il2cpp_internal(puVar6,uVar4);
                }
                if (this.enhanceTargetItemIcon != null) {
                  lVar3 = GameObject.GetComponent(this.enhanceTargetItemIcon,DAT_181e55168);
                  if (((lVar3 != null) && (lVar3.villageAreaID != null)) &&
                     (lVar3 = *(int64 *)(lVar3.villageAreaID + 96)) != null) {
                    piVar1 = (int *)(lVar3 + 72);
                    *piVar1 = *piVar1 + 1;
                    if (this.enhanceTargetItemIcon != null) {
                      lVar3 = GameObject.GetComponent(this.enhanceTargetItemIcon,DAT_181e55168);
                      if ((lVar3 != null) && (lVar3.villageAreaID != null)) {
                        ItemData.CountValueAndWeight(lVar3.villageAreaID,0);
                        lVar3 = **(int64 **)(DAT_181e848a8 + 184);
                        if (this.enhanceTargetItemIcon != null) {
                          lVar5 = GameObject.GetComponent(this.enhanceTargetItemIcon,DAT_181e55168);
                          if ((lVar5 != null) && (lVar3 != null)) {
                            SpeShowController.ShowGetItem
                                      (lVar3,*(uint64 *)(lVar5 + 32),0xffffffff,0,0);
                            uVar4 = this.enhanceChoiceGrid;
                            GlobalData.DeleteAllChild(uVar4,0);
                            SpeEnhanceEquipController.GenerateChoice(this,0);
                            this.needRefresh = 1;
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

    // Token : 0x6002212
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

}
