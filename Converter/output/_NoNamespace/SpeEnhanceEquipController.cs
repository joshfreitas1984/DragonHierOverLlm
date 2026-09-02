// ============================================================
// Type  : SpeEnhanceEquipController
// Token : 0x200035E
// ============================================================

public class SpeEnhanceEquipController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001ACC
    public GameObject speEnhanceEquipUI;

    // Token: 0x4001ACD
    public GameObject speEnhanceEquipChoicePrefab;

    // Token: 0x4001ACE
    public GameObject enhanceChoiceGrid;

    // Token: 0x4001ACF
    public GameObject enhanceTargetItemIcon;

    // Token: 0x4001AD0
    public GameObject enhanceTargetClearButton;

    // Token: 0x4001AD1
    public GameObject nowChoice;

    // Token: 0x4001AD2
    public bool needRefresh;

    // Token: 0x4001AD3
    private static SpeEnhanceEquipController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60020D3
    // RVA   : 0x97D9B0   Offset: 0x97C1B0   Length: 0x36
    public static SpeEnhanceEquipController get_Instance()
    {
        return **(uint64 **)(DAT_181d7f030 + 184);
    }

    // Token : 0x60020D4
    // RVA   : 0x97BB30   Offset: 0x97A330   Length: 0x43
    private void Awake()
    {
        puVar1 = *(uint64 **)(DAT_181d7f030 + 184);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x60020D5
    // RVA   : 0x97D970   Offset: 0x97C170   Length: 0x3D
    private void Update()
    {
        bool cVar1;
        if (this.speEnhanceEquipUI == null) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        cVar1 = GameObject.get_activeSelf(this.speEnhanceEquipUI,0);
        if ((cVar1) && (this.needRefresh)) {
          SpeEnhanceEquipController.RefreshUI(this,0);
          return;
        }
    }

    // Token : 0x60020D6
    // RVA   : 0x97CFE0   Offset: 0x97B7E0   Length: 0x102
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

    // Token : 0x60020D7
    // RVA   : 0x97D8C0   Offset: 0x97C0C0   Length: 0xAF
    public void ShowSpeEnhanceEquipUI()
    {
        if (this.speEnhanceEquipUI != null) {
          GameObject.SetActive(this.speEnhanceEquipUI,1,0);
          SpeEnhanceEquipController.RefreshUI(this,0);
          plVar1 = (int64 *)Resources.Load("Sound/SoundEffect/OpenBook",0);
          plVar2 = (int64 *)0;
          if ((plVar1 != (int64 *)0) && (*plVar1 == DAT_181d8a228)) {
            plVar2 = plVar1;
          }
          NGUITools.PlaySound(plVar2,0);
          return;
        }
    }

    // Token : 0x60020D8
    // RVA   : 0x97D280   Offset: 0x97BA80   Length: 0x3D9
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
        plVar4 = (int64 *)Component.GetComponent(lVar3,DAT_181d6bc40);
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
        FUN_1809981e0(&local_28,0x3f800000,0x3f800000,0x3f800000,uVar7,0);
        if (plVar4 == (int64 *)0) {
        LAB_18097d654:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        local_18 = (uint32)local_28;
        uStack_14 = local_28._4_4_;
        uStack_10 = (uint32)uStack_20;
        uStack_c = uStack_20._4_4_;
        (**(code **)(*plVar4 + 0x2a8))(plVar4,&local_18,*(uint64 *)(*plVar4 + 0x2b0));
        if (((this.speEnhanceEquipUI == null) ||
            (lVar3 = GameObject.get_transform(this.speEnhanceEquipUI,0)) == null) ||
           (lVar3 = Transform.Find(lVar3,"CostStone",0)) == null) goto LAB_18097d654;
        uVar5 = Component.GetComponent(lVar3,DAT_181d6d8c0);
        uVar6 = this.enhanceTargetItemIcon;
        cVar2 = Object.op_Equality(uVar6,0,0);
        uVar6 = "0";
        if (!cVar2) {
          if (((this.enhanceTargetItemIcon == null) ||
              (lVar3 = GameObject.GetComponent(this.enhanceTargetItemIcon,DAT_181da0070)) == null)
             || (*(int64 *)(lVar3 + 32) == 0)) throw; // [null/range check failed]
          iVar1 = *(int *)(*(int64 *)(lVar3 + 32) + 60);
          if (((this.enhanceTargetItemIcon == null) ||
              (lVar3 = GameObject.GetComponent(this.enhanceTargetItemIcon,DAT_181da0070)) == null)
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
          uVar5 = Component.GetComponent(lVar3,DAT_181d6d8c0);
          uVar6 = this.enhanceTargetItemIcon;
          cVar2 = Object.op_Equality(uVar6,0,0);
          uVar6 = "";
          if (!cVar2) {
            local_res18[0] = SpeEnhanceEquipController.GetTimeNeed(this,0);
            uVar6 = il2cpp_value_box(DAT_181d5b2f8,local_res18);
            uVar6 = String.Format("消耗时间：{0}天",uVar6,0);
          }
          LTLocalization.SetText(uVar5,uVar6,0);
          SpeEnhanceEquipController.RefreshEnhanceButtonState(this,0);
          return;
        }
    }

    // Token : 0x60020D9
    // RVA   : 0x97BC90   Offset: 0x97A490   Length: 0x56
    public void ClearAllChoice()
    {
        ulong uVar1;
        uVar1 = this.enhanceChoiceGrid;
        GlobalData.DeleteAllChild(uVar1,0);
    }

    // Token : 0x60020DA
    // RVA   : 0x97CAE0   Offset: 0x97B2E0   Length: 0x39F
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
           (lVar4 = GameObject.GetComponent(this.enhanceTargetItemIcon,DAT_181da0070)) != null) {
          lVar4 = *(int64 *)(lVar4 + 32);
          iVar8 = 0;
          iVar9 = 0;
          if (lVar4 != null) {
            while ((((*(int64 *)(lVar4 + 96) != 0 &&
                     (lVar5 = *(int64 *)(*(int64 *)(lVar4 + 96) + 32)) != null) &&
                    (lVar5 = *(int64 *)(lVar5 + 16)) != null) &&
                   (lVar5 = Dictionary_2.get_Keys(lVar5,DAT_181d98b10)) != null)) {
              iVar2 = FUN_180bf8ff0(lVar5,DAT_181d9c818);
              if (iVar2 <= iVar9) goto LAB_18097cd1e;
              if (((*(int64 *)(lVar4 + 96) == 0) ||
                  (lVar5 = *(int64 *)(*(int64 *)(lVar4 + 96) + 32)) == null) ||
                 (lVar5 = *(int64 *)(lVar5 + 16)) == null) break;
              uVar6 = Dictionary_2.get_Keys(lVar5,DAT_181d98b10);
              uVar3 = FUN_18095e200(uVar6,iVar9,DAT_181d8a338);
              lVar5 = new HeroSpeAddData(0);
              lVar7 = FUN_18046c100(0);
              if ((((lVar7 == null) || (*(int64 *)(lVar7 + 144) == 0)) ||
                  (lVar7 = FUN_180002f80(*(int64 *)(lVar7 + 144),uVar3,DAT_181d64878)) == null) ||
                 (lVar5 == null)) break;
              uVar6 = HeroSpeAddData.Set(lVar5,uVar3,*(uint32 *)(lVar7 + 32));
              SpeEnhanceEquipController.CreateEnhanceChoiceButton(this,uVar6,1,0);
              iVar9 = iVar9 + 1;
            }
          }
        }
        LAB_18097ce7a:
                          // WARNING: Subroutine does not return
        FUN_1800d6620();
        LAB_18097cd1e:
        if (((*(int64 *)(lVar4 + 96) == 0) ||
            (lVar5 = *(int64 *)(*(int64 *)(lVar4 + 96) + 40)) == null) ||
           ((lVar5 = *(int64 *)(lVar5 + 16), lVar5 == null ||
            (lVar5 = Dictionary_2.get_Keys(lVar5,DAT_181d98b10)) == null))) goto LAB_18097ce7a;
        iVar9 = FUN_180bf8ff0(lVar5,DAT_181d9c818);
        if (iVar9 <= iVar8) {
          SpeEnhanceEquipController.CreateEnhanceChoiceButton(this,0,1,0);
          return;
        }
        if (((*(int64 *)(lVar4 + 96) == 0) ||
            (lVar5 = *(int64 *)(*(int64 *)(lVar4 + 96) + 40)) == null) ||
           (lVar5 = *(int64 *)(lVar5 + 16)) == null) goto LAB_18097ce7a;
        uVar6 = Dictionary_2.get_Keys(lVar5,DAT_181d98b10);
        uVar3 = FUN_18095e200(uVar6,iVar8,DAT_181d8a338);
        lVar5 = new HeroSpeAddData(0);
        lVar7 = FUN_18046c100(0);
        if ((((lVar7 == null) || (*(int64 *)(lVar7 + 144) == 0)) ||
            (lVar7 = FUN_180002f80(*(int64 *)(lVar7 + 144),uVar3,DAT_181d64878)) == null) ||
           (lVar5 == null)) goto LAB_18097ce7a;
        uVar6 = HeroSpeAddData.Set(lVar5,uVar3,*(float *)(lVar7 + 32) + *(float *)(lVar7 + 32));
        SpeEnhanceEquipController.CreateEnhanceChoiceButton(this,uVar6,0,0);
        iVar8 = iVar8 + 1;
        goto LAB_18097cd1e;
    }

    // Token : 0x60020DB
    // RVA   : 0x97BB80   Offset: 0x97A380   Length: 0x104
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
            lVar5 = FUN_18046c0a0(0);
            if ((lVar5 != null) && (*(int64 *)(lVar5 + 32) != 0)) {
              iVar1 = *(int *)(*(int64 *)(lVar5 + 32) + 0x230);
              iVar4 = SpeEnhanceEquipController.GetStoneNeed(this,0);
              return iVar4 <= iVar1;
            }
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
        }
        return false;
    }

    // Token : 0x60020DC
    // RVA   : 0x97CE80   Offset: 0x97B680   Length: 0x93
    public int GetStoneNeed()
    {
        int iVar1;
        long lVar2;
        if (this.enhanceTargetItemIcon != null) {
          lVar2 = GameObject.GetComponent(this.enhanceTargetItemIcon,DAT_181da0070);
          if ((lVar2 != null) && (*(int64 *)(lVar2 + 32) != 0)) {
            iVar1 = *(int *)(*(int64 *)(lVar2 + 32) + 60);
            if (this.enhanceTargetItemIcon != null) {
              lVar2 = GameObject.GetComponent(this.enhanceTargetItemIcon,DAT_181da0070);
              if (((lVar2 != null) && (*(int64 *)(lVar2 + 32) != 0)) &&
                 (lVar2 = *(int64 *)(*(int64 *)(lVar2 + 32) + 96)) != null) {
                return *(int *)(lVar2 + 72) + 1 + iVar1;
              }
            }
          }
        }
    }

    // Token : 0x60020DD
    // RVA   : 0x97D660   Offset: 0x97BE60   Length: 0x25F
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
              plVar6 = (int64 *)Component.GetComponent(lVar4,DAT_181d6bc40);
              FUN_181098a50(local_18,0);
              if (plVar6 == (int64 *)0) break;
              (**(code **)(*plVar6 + 0x2a8))(plVar6);
            }
            else {
              if (((lVar4 == null) || (lVar4 = GameObject.get_transform(lVar4,0)) == null) ||
                 (lVar4 = Transform.GetChild(lVar4,iVar7,0)) == null) break;
              plVar6 = (int64 *)Component.GetComponent(lVar4,DAT_181d6bc40);
              if (plVar6 == (int64 *)0) break;
              (**(code **)(*plVar6 + 0x2a8))(plVar6);
            }
            lVar4 = this.enhanceChoiceGrid;
            iVar7 = iVar7 + 1;
            if (lVar4 == null) break;
          }
        }
    }

    // Token : 0x60020DE
    // RVA   : 0x97D0F0   Offset: 0x97B8F0   Length: 0x183
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
        lVar5 = Component.GetComponent(lVar5,DAT_181d6af40);
        uVar2 = this.enhanceTargetItemIcon;
        cVar3 = Object.op_Inequality(uVar2,0,0);
        if (!cVar3) {
        LAB_18097d24d:
          bVar7 = false;
        }
        else {
          uVar2 = this.nowChoice;
          cVar3 = Object.op_Inequality(uVar2,0,0);
          if (!cVar3) goto LAB_18097d24d;
          lVar6 = FUN_18046c0a0(0);
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

    // Token : 0x60020DF
    // RVA   : 0x97CF20   Offset: 0x97B720   Length: 0xBF
    public int GetTimeNeed()
    {
        int iVar1;
        long lVar2;
        if (this.enhanceTargetItemIcon != null) {
          lVar2 = GameObject.GetComponent(this.enhanceTargetItemIcon,DAT_181da0070);
          if ((lVar2 != null) && (*(int64 *)(lVar2 + 32) != 0)) {
            iVar1 = *(int *)(*(int64 *)(lVar2 + 32) + 60);
            if (this.enhanceTargetItemIcon != null) {
              lVar2 = GameObject.GetComponent(this.enhanceTargetItemIcon,DAT_181da0070);
              if (((lVar2 != null) && (*(int64 *)(lVar2 + 32) != 0)) &&
                 (lVar2 = *(int64 *)(*(int64 *)(lVar2 + 32) + 96)) != null) {
                return (int)((float)iVar1 * 0.5 + 1.0 + (float)*(int *)(lVar2 + 72) * 0.5);
              }
            }
          }
        }
    }

    // Token : 0x60020E0
    // RVA   : 0x97BDE0   Offset: 0x97A5E0   Length: 0x203
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
        if ((lVar1 != null) && (lVar2 = GameObject.GetComponent(lVar1,DAT_181da17b0)) != null) {
          *(int64 *)(lVar2 + 24) = _speAddData;
          lVar2 = GameObject.GetComponent(lVar1,DAT_181da17b0);
          if (lVar2 != null) {
            *(byte *)(lVar2 + 32) = _isBaseAdd;
            lVar2 = GameObject.get_transform(lVar1,0);
            if ((lVar2 != null) && (lVar2 = Transform.Find(lVar2,"Text",0)) != null) {
              uVar3 = Component.GetComponent(lVar2,DAT_181d6d8c0);
              uVar4 = "重量-10%";
              if (_speAddData != null) {
                uVar4 = HeroSpeAddData.GetDescribe(_speAddData,_isBaseAdd ^ 1,1,1,0,0);
              }
              LTLocalization.SetText(uVar3,uVar4,0);
              lVar2 = GameObject.get_transform(lVar1,0);
              if ((lVar2 != null) && (lVar2 = Transform.Find(lVar2,"Type",0)) != null) {
                uVar3 = Component.GetComponent(lVar2,DAT_181d6d8c0);
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

    // Token : 0x60020E1
    // RVA   : 0x97BFF0   Offset: 0x97A7F0   Length: 0x12A
    public GameObject CreateEnhanceTargetIcon(GameObject parent, ItemData targetItemData)
    {
        var pStatics = *(int64*)(DAT_181d4e188 + 184);
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
            lVar3 = GameObject.GetComponent(lVar2,DAT_181da0070);
            if (lVar3 != null) {
              *(uint64 *)(lVar3 + 32) = targetItemData;
              lVar3 = GameObject.GetComponent(lVar2,DAT_181da0070);
              if (lVar3 != null) {
                *(uint32 *)(lVar3 + 40) = 1;
                lVar3 = GameObject.GetComponent(lVar2,DAT_181da0070);
                if (lVar3 != null) {
                  ItemIconController.AutoSetName(lVar3,1,0);
                  return lVar2;
                }
              }
            }
          }
        }
    }

    // Token : 0x60020E2
    // RVA   : 0x97C2F0   Offset: 0x97AAF0   Length: 0x1A6
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
        lVar1 = **(int64 **)(DAT_181d92370 + 184);
        lVar3 = il2cpp_internal(DAT_181d701b0);
        FUN_180f58a90(lVar3,DAT_181d6dfe8);
        local_res8[0] = 0;
        uVar4 = il2cpp_value_box(DAT_181d5b2f8,local_res8);
        if (lVar3 != null) {
          FUN_181827900(lVar3,uVar4,DAT_181d6e0e8);
          local_res18[0] = 0;
          uVar4 = il2cpp_value_box(DAT_181d5b2f8,local_res18);
          FUN_181827900(lVar3,uVar4,DAT_181d6e0e8);
          uVar4 = Component.get_gameObject(this,0);
          if (lVar1 != null) {
            ChooseController.ShowChoosePanel(lVar1,1,lVar3,uVar4,"EnhanceTargetChoosen",0,0,0,0,0);
            return;
          }
        }
    }

    // Token : 0x60020E3
    // RVA   : 0x97C4A0   Offset: 0x97ACA0   Length: 0x230
    public void EnhanceTargetChoosen()
    {
        var pStatics_2370 = *(int64*)(DAT_181d92370 + 184);
        var pStatics_e188 = *(int64*)(DAT_181d4e188 + 184);
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
              if ((*pStatics_2370 != 0) &&
                 (lVar3 = *(int64 *)(*pStatics_2370 + 72)) != null) {
                lVar3 = GameObject.GetComponent(lVar3,DAT_181da0070);
                if (lVar3 != null) {
                  uVar1 = *(uint64 *)(lVar3 + 32);
                  if (*pStatics_e188 != 0) {
                    uVar2 = *(uint64 *)(*pStatics_e188 + 160);
                    lVar3 = GlobalData.AddChild(uVar4,uVar2,0);
                    if (lVar3 != null) {
                      lVar5 = GameObject.GetComponent(lVar3,DAT_181da0070);
                      if (lVar5 != null) {
                        *(uint64 *)(lVar5 + 32) = uVar1;
                        lVar5 = GameObject.GetComponent(lVar3,DAT_181da0070);
                        if (lVar5 != null) {
                          *(uint32 *)(lVar5 + 40) = 1;
                          lVar5 = GameObject.GetComponent(lVar3,DAT_181da0070);
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

    // Token : 0x60020E4
    // RVA   : 0x97BCF0   Offset: 0x97A4F0   Length: 0xEC
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

    // Token : 0x60020E5
    // RVA   : 0x97C120   Offset: 0x97A920   Length: 0x1C3
    public void EnhanceButtonClicked()
    {
        long lVar1;
        uint uVar2;
        plVar3 = (int64 *)Resources.Load("Sound/SoundEffect/SpeEffect/修理升级",0);
        plVar4 = (int64 *)0;
        if ((plVar3 != (int64 *)0) && (*plVar3 == DAT_181d8a228)) {
          plVar4 = plVar3;
        }
        NGUITools.PlaySound(plVar4,0);
        plVar4 = (int64 *)Resources.Load("Sound/SoundEffect/Button/CraftButton",0);
        plVar3 = (int64 *)0;
        if ((plVar4 != (int64 *)0) && (*plVar4 == DAT_181d8a228)) {
          plVar3 = plVar4;
        }
        NGUITools.PlaySound(plVar3,0);
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d90b30 + 184) + 8);
        uVar2 = SpeEnhanceEquipController.GetTimeNeed(this,0);
        if (lVar1 != null) {
          WorkingUIController.StartWorking
                    (lVar1,"锻造",uVar2,"","","FinishSpeEnhance","",0);
          return;
        }
    }

    // Token : 0x60020E6
    // RVA   : 0x97C6E0   Offset: 0x97AEE0   Length: 0x3F8
    public void FinishSpeEnhance()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        int iVar2;
        long lVar3;
        ulong uVar4;
        long lVar5;
        if (*pStatics != 0) {
          lVar3 = *(int64 *)(*pStatics + 32);
          iVar2 = SpeEnhanceEquipController.GetStoneNeed(this,0);
          if (lVar3 != null) {
            WorldData.ChangeSpeEnhanceStoneNum(lVar3,-iVar2,1,0);
            if (this.nowChoice != null) {
              lVar3 = GameObject.GetComponent(this.nowChoice,DAT_181da17b0);
              if (lVar3 != null) {
                if (*(int64 *)(lVar3 + 24) == 0) {
                  if (this.enhanceTargetItemIcon == null) throw; // [null/range check failed]
                  lVar3 = GameObject.GetComponent(this.enhanceTargetItemIcon,DAT_181da0070);
                  if (((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) ||
                     (lVar3 = *(int64 *)(*(int64 *)(lVar3 + 32) + 96)) == null)
                  throw; // [null/range check failed]
                  piVar1 = (int *)(lVar3 + 76);
                  *piVar1 = *piVar1 + 1;
                }
                else {
                  if (this.nowChoice == null) throw; // [null/range check failed]
                  lVar3 = GameObject.GetComponent(this.nowChoice,DAT_181da17b0);
                  if (lVar3 == null) throw; // [null/range check failed]
                  lVar5 = this.enhanceTargetItemIcon;
                  if (*(char *)(lVar3 + 32) == false) {
                    if (lVar5 == null) throw; // [null/range check failed]
                    lVar3 = GameObject.GetComponent(lVar5,DAT_181da0070);
                    if (((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) ||
                       (lVar3 = *(int64 *)(*(int64 *)(lVar3 + 32) + 96)) == null)
                    throw; // [null/range check failed]
                    puVar6 = (uint64 *)(lVar3 + 40);
                  }
                  else {
                    if (lVar5 == null) throw; // [null/range check failed]
                    lVar3 = GameObject.GetComponent(lVar5,DAT_181da0070);
                    if (((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) ||
                       (lVar3 = *(int64 *)(*(int64 *)(lVar3 + 32) + 96)) == null)
                    throw; // [null/range check failed]
                    puVar6 = (uint64 *)(lVar3 + 32);
                  }
                  uVar4 = *puVar6;
                  if (this.nowChoice == null) throw; // [null/range check failed]
                  lVar3 = GameObject.GetComponent(this.nowChoice,DAT_181da17b0);
                  if (lVar3 == null) throw; // [null/range check failed]
                  uVar4 = HeroSpeAddData.op_Addition(uVar4,*(uint64 *)(lVar3 + 24),0);
                  *puVar6 = uVar4;
                  il2cpp_internal(puVar6,uVar4);
                }
                if (this.enhanceTargetItemIcon != null) {
                  lVar3 = GameObject.GetComponent(this.enhanceTargetItemIcon,DAT_181da0070);
                  if (((lVar3 != null) && (*(int64 *)(lVar3 + 32) != 0)) &&
                     (lVar3 = *(int64 *)(*(int64 *)(lVar3 + 32) + 96)) != null) {
                    piVar1 = (int *)(lVar3 + 72);
                    *piVar1 = *piVar1 + 1;
                    if (this.enhanceTargetItemIcon != null) {
                      lVar3 = GameObject.GetComponent(this.enhanceTargetItemIcon,DAT_181da0070);
                      if ((lVar3 != null) && (*(int64 *)(lVar3 + 32) != 0)) {
                        ItemData.CountValueAndWeight(*(int64 *)(lVar3 + 32),0);
                        lVar3 = **(int64 **)(DAT_181d7f230 + 184);
                        if (this.enhanceTargetItemIcon != null) {
                          lVar5 = GameObject.GetComponent(this.enhanceTargetItemIcon,DAT_181da0070);
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

    // Token : 0x60020E7
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
