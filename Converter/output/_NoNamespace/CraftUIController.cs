// ============================================================
// Type  : CraftUIController
// Token : 0x2000252
// ============================================================

public class CraftUIController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001218
    public CraftType craftType;

    // Token: 0x4001219
    public AreaBuildingData targetBuilding;

    // Token: 0x400121A
    public GameObject creaftUIPanel;

    // Token: 0x400121B
    public ItemData craftMaterialData;

    // Token: 0x400121C
    public GameObject craftMaterialItemIcon;

    // Token: 0x400121D
    public ItemData craftMaterialDataSub;

    // Token: 0x400121E
    public GameObject craftMaterialItemIconSub;

    // Token: 0x400121F
    public int resourceCostID;

    // Token: 0x4001220
    public int targetSubType;

    // Token: 0x4001221
    public int targetWeaponType;

    // Token: 0x4001222
    public int targetFoodSubType;

    // Token: 0x4001223
    public GameObject clearMaterialButton;

    // Token: 0x4001224
    public GameObject clearMaterialButtonSub;

    // Token: 0x4001225
    public GameObject forceCraftToggle;

    // Token: 0x4001226
    public bool forceCraft;

    // Token: 0x4001227
    public bool useMoney;

    // Token: 0x4001228
    public GameObject setNameInput;

    // Token: 0x4001229
    public string craftSettingName;

    // Token: 0x400122A
    private static CraftUIController _instance;

    // Token: 0x400122B
    public List<ItemData> craftResultList;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001308
    // RVA   : 0xA50000   Offset: 0xA4E800   Length: 0x36
    public static CraftUIController get_Instance()
    {
        return **(uint64 **)(DAT_181d95650 + 184);
    }

    // Token : 0x6001309
    // RVA   : 0xA4B090   Offset: 0xA49890   Length: 0xD7
    private void Awake()
    {
        bool cVar2;
        ulong uVar3;
        uVar3 = **(uint64 **)(DAT_181d95650 + 184);
        cVar2 = Object.op_Equality(uVar3,0,0);
        if (!cVar2) {
          uVar3 = Component.get_gameObject(this,0);
          Object.Destroy(uVar3,0);
          return;
        }
        puVar1 = *(uint64 **)(DAT_181d95650 + 184);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x600130A
    // RVA   : 0xA4FE90   Offset: 0xA4E690   Length: 0x158
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
          uVar3 = new OnTooltipCB(this,DAT_181d753c0,0);
          if (lVar2 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          RailCallBackHelper.RegisterCallback(lVar2,0x1f45,uVar3,0);
        }
    }

    // Token : 0x600130B
    // RVA   : 0xA4E4C0   Offset: 0xA4CCC0   Length: 0xCF1
    public void RefreshCraftUI()
    {
        bool cVar1;
        byte uVar2;
        uint uVar3;
        long lVar4;
        ulong uVar5;
        ulong uVar6;
        float fVar10;
        uint uVar11;
        uint uVar12;
        uint uVar13;
        float fVar14;
        int[] local_res8 = new int[4];
        float[] local_res18 = new float[2];
        int[] local_res20 = new int[2];
        uint[] local_128 = new uint[4];
        ulong local_118;
        ulong uStack_110;
        ulong local_108;
        uint local_100;
        ulong local_f8;
        uint local_f0;
        ulong local_e8;
        uint local_e0;
        ulong local_d8;
        uint local_d0;
        byte[] local_c8 = new byte[16];
        byte[] local_b8 = new byte[16];
        byte[] local_a8 = new byte[16];
        byte[] local_98 = new byte[16];
        byte[] local_88 = new byte[16];
        byte[] local_78 = new byte[80];
        local_res20[0] = 0;
        if (this.creaftUIPanel != null) {
          cVar1 = GameObject.get_activeSelf(this.creaftUIPanel,0);
          if (!cVar1) {
            return;
          }
          if (((this.creaftUIPanel == null) ||
              (lVar4 = GameObject.get_transform(this.creaftUIPanel,0)) == null) ||
             (lVar4 = Transform.Find(lVar4,"CostTime",0)) == null) throw; // [null/range check failed]
          uVar5 = Component.GetComponent(lVar4,DAT_181d6d8c0);
          if (this.craftType == null) {
            fVar10 = 1.0;
          }
          else {
            fVar10 = 0.5;
          }
          uVar3 = Mathf.RoundToInt(fVar10 * (float)(this.resourceCostID + 1),0);
          local_128[0] = Mathf.Max(1,uVar3);
          uVar6 = Int32.ToString(local_128,0);
          uVar6 = String.Concat("消耗时间：",uVar6,"天",0);
          LTLocalization.SetText(uVar5,uVar6,0);
          if (((this.creaftUIPanel == null) ||
              (lVar4 = GameObject.get_transform(this.creaftUIPanel,0)) == null) ||
             (lVar4 = Transform.Find(lVar4,"Rate",0)) == null) throw; // [null/range check failed]
          uVar5 = Component.GetComponent(lVar4,DAT_181d6d8c0);
          uVar3 = this.resourceCostID;
          if (!this.useMoney) {
            uVar6 = CraftUIController.GetResourceCost(this,uVar3,0);
            fVar10 = (float)GlobalData.GetResourceTotalValue(uVar6,0);
            uVar3 = this.resourceCostID;
          }
          else {
            fVar10 = (float)CraftUIController.GetResourceCostNum();
          }
          if ((this.craftMaterialData == null) && (this.craftMaterialDataSub == null)) {
            fVar14 = 0.5;
          }
          else {
            fVar14 = 1.0;
          }
          local_res18[0] = (float)CraftUIController.GetCraftRate(this,uVar3,0);
          local_res18[0] = local_res18[0] * fVar14 * fVar10;
          uVar6 = Single.ToString(local_res18,"f0",0);
          LTLocalization.SetText(uVar5,uVar6,0);
          local_res8[0] = 0;
          do {
            if ((this.creaftUIPanel == null) ||
               (lVar4 = GameObject.get_transform(this.creaftUIPanel,0)) == null)
            throw; // [null/range check failed]
            lVar4 = Transform.Find(lVar4,"ResourceCostGrid",0);
            uVar5 = Int32.ToString(local_res8,0);
            if ((lVar4 == null) || (lVar4 = Transform.Find(lVar4,uVar5,0)) == null) throw; // [null/range check failed]
            plVar7 = (int64 *)Component.GetComponent(lVar4,DAT_181d6bc40);
            if (this.resourceCostID == local_res8[0]) {
              puVar8 = (uint32 *)FUN_181098a50(local_88,0);
              uVar3 = *puVar8;
              uVar11 = puVar8[1];
              uVar12 = puVar8[2];
              uVar13 = puVar8[3];
            }
            else {
              local_118 = 0;
              uStack_110 = 0;
              FUN_1809981e0(&local_118);
              uVar3 = (uint32)local_118;
              uVar11 = local_118._4_4_;
              uVar12 = (uint32)uStack_110;
              uVar13 = uStack_110._4_4_;
            }
            if (plVar7 == (int64 *)0) throw; // [null/range check failed]
            local_118 = CONCAT44(uVar11,uVar3);
            uStack_110 = CONCAT44(uVar13,uVar12);
            (**(code **)(*plVar7 + 0x2a8))(plVar7,&local_118,*(uint64 *)(*plVar7 + 0x2b0));
            if ((this.creaftUIPanel == null) ||
               (lVar4 = GameObject.get_transform(this.creaftUIPanel,0)) == null)
            throw; // [null/range check failed]
            lVar4 = Transform.Find(lVar4,"ResourceCostGrid",0);
            uVar5 = Int32.ToString(local_res8,0);
            if ((lVar4 == null) ||
               ((lVar4 = Transform.Find(lVar4,uVar5,0), lVar4 == null ||
                (lVar4 = Transform.Find(lVar4,"Rate",0)) == null))) throw; // [null/range check failed]
            uVar5 = Component.GetComponent(lVar4,DAT_181d6d8c0);
            local_res18[0] = (float)CraftUIController.GetCraftRate(this,local_res8[0],0);
            local_res18[0] = local_res18[0] * 100.0;
            uVar6 = Single.ToString(local_res18,"f0",0);
            uVar6 = String.Concat("制作效率",uVar6,"%",0);
            LTLocalization.SetText(uVar5,uVar6,0);
            if ((this.creaftUIPanel == null) ||
               (lVar4 = GameObject.get_transform(this.creaftUIPanel,0)) == null)
            throw; // [null/range check failed]
            lVar4 = Transform.Find(lVar4,"ResourceCostGrid",0);
            uVar5 = Int32.ToString(local_res8,0);
            if (((lVar4 == null) || (lVar4 = Transform.Find(lVar4,uVar5,0)) == null) ||
               (lVar4 = Transform.Find(lVar4,"Num",0)) == null) throw; // [null/range check failed]
            uVar5 = Component.GetComponent(lVar4,DAT_181d6d8c0);
            local_res18[0] = (float)CraftUIController.GetResourceCostNum(this,local_res8[0],0);
            uVar6 = Single.ToString(local_res18,0);
            LTLocalization.SetText(uVar5,uVar6,0);
            if ((this.creaftUIPanel == null) ||
               (lVar4 = GameObject.get_transform(this.creaftUIPanel,0)) == null)
            throw; // [null/range check failed]
            lVar4 = Transform.Find(lVar4,"ResourceCostGrid",0);
            uVar5 = Int32.ToString(local_res8,0);
            if ((lVar4 == null) ||
               ((lVar4 = Transform.Find(lVar4,uVar5,0), lVar4 == null ||
                (lVar4 = Transform.Find(lVar4,"Num",0)) == null))) throw; // [null/range check failed]
            plVar7 = (int64 *)Component.GetComponent(lVar4,DAT_181d6d8c0);
            cVar1 = CraftUIController.HaveResource(this,local_res8[0],0);
            if (!cVar1) {
              lVar4 = *(int64 *)(DAT_181d4ef00 + 184);
              uVar3 = *(uint32 *)(lVar4 + 0x2e8);
              uVar11 = *(uint32 *)(lVar4 + 0x2ec);
              uVar12 = *(uint32 *)(lVar4 + 0x2f0);
              uVar13 = *(uint32 *)(lVar4 + 0x2f4);
            }
            else {
              puVar8 = (uint32 *)FUN_181098a50(local_78,0);
              uVar3 = *puVar8;
              uVar11 = puVar8[1];
              uVar12 = puVar8[2];
              uVar13 = puVar8[3];
            }
            if (plVar7 == (int64 *)0) throw; // [null/range check failed]
            local_118 = CONCAT44(uVar11,uVar3);
            uStack_110 = CONCAT44(uVar13,uVar12);
            (**(code **)(*plVar7 + 0x2a8))(plVar7,&local_118);
            fVar10 = (float)CraftUIController.GetCraftTargetSkillNum(this,0);
            if (fVar10 / 20.0 < (float)local_res8[0]) {
        LAB_180a4edd0:
              if ((this.creaftUIPanel == null) ||
                 (lVar4 = GameObject.get_transform(this.creaftUIPanel,0)) == null)
              throw; // [null/range check failed]
              lVar4 = Transform.Find(lVar4,"ResourceCostGrid",0);
              uVar5 = Int32.ToString(local_res8,0);
              if ((lVar4 == null) ||
                 ((lVar4 = Transform.Find(lVar4,uVar5,0), lVar4 == null ||
                  (lVar4 = Component.GetComponent(lVar4,DAT_181d6af40)) == null)))
              throw; // [null/range check failed]
              Selectable.set_interactable(lVar4,0);
              if ((this.creaftUIPanel == null) ||
                 (lVar4 = GameObject.get_transform(this.creaftUIPanel,0)) == null)
              throw; // [null/range check failed]
              lVar4 = Transform.Find(lVar4,"ResourceCostGrid",0);
              uVar5 = Int32.ToString(local_res8,0);
              if ((lVar4 == null) || (lVar4 = Transform.Find(lVar4,uVar5,0)) == null)
              throw; // [null/range check failed]
              lVar4 = Transform.Find(lVar4,"Lock",0);
              puVar9 = (uint64 *)Vector3.get_one(local_a8,0);
              if (lVar4 == null) throw; // [null/range check failed]
              local_e0 = *(uint32 *)(puVar9 + 1);
              local_e8 = *puVar9;
              Transform.set_localScale(lVar4,&local_e8);
              if ((this.creaftUIPanel == null) ||
                 (lVar4 = GameObject.get_transform(this.creaftUIPanel,0)) == null)
              throw; // [null/range check failed]
              lVar4 = Transform.Find(lVar4,"ResourceCostGrid",0);
              uVar5 = Int32.ToString(local_res8,0);
              if ((lVar4 == null) || (lVar4 = Transform.Find(lVar4,uVar5,0)) == null)
              throw; // [null/range check failed]
              lVar4 = Transform.Find(lVar4,"Source",0);
              puVar9 = (uint64 *)Vector3.get_zero(local_98,0);
              if (lVar4 == null) throw; // [null/range check failed]
              local_d8 = *puVar9;
              local_d0 = *(uint32 *)(puVar9 + 1);
            }
            else {
              if (!this.useMoney) {
                lVar4 = FUN_18046c0a0(0);
                if (((lVar4 == null) || (*(int64 *)(lVar4 + 32) == 0)) ||
                   (lVar4 = WorldData.Player(*(int64 *)(lVar4 + 32),0)) == null)
                throw; // [null/range check failed]
                if (*(int *)(lVar4 + 184) < local_res8[0]) goto LAB_180a4edd0;
              }
              if ((this.creaftUIPanel == null) ||
                 (lVar4 = GameObject.get_transform(this.creaftUIPanel,0)) == null)
              throw; // [null/range check failed]
              lVar4 = Transform.Find(lVar4,"ResourceCostGrid",0);
              uVar5 = Int32.ToString(local_res8,0);
              if ((lVar4 == null) ||
                 ((lVar4 = Transform.Find(lVar4,uVar5,0), lVar4 == null ||
                  (lVar4 = Component.GetComponent(lVar4,DAT_181d6af40)) == null)))
              throw; // [null/range check failed]
              Selectable.set_interactable(lVar4,1);
              if ((this.creaftUIPanel == null) ||
                 (lVar4 = GameObject.get_transform(this.creaftUIPanel,0)) == null)
              throw; // [null/range check failed]
              lVar4 = Transform.Find(lVar4,"ResourceCostGrid",0);
              uVar5 = Int32.ToString(local_res8,0);
              if ((lVar4 == null) || (lVar4 = Transform.Find(lVar4,uVar5,0)) == null)
              throw; // [null/range check failed]
              lVar4 = Transform.Find(lVar4,"Lock",0);
              puVar9 = (uint64 *)Vector3.get_zero(local_c8,0);
              if (lVar4 == null) throw; // [null/range check failed]
              local_100 = *(uint32 *)(puVar9 + 1);
              local_108 = *puVar9;
              Transform.set_localScale(lVar4,&local_108);
              if ((this.creaftUIPanel == null) ||
                 (lVar4 = GameObject.get_transform(this.creaftUIPanel,0)) == null)
              throw; // [null/range check failed]
              lVar4 = Transform.Find(lVar4,"ResourceCostGrid",0);
              uVar5 = Int32.ToString(local_res8,0);
              if ((lVar4 == null) || (lVar4 = Transform.Find(lVar4,uVar5,0)) == null)
              throw; // [null/range check failed]
              lVar4 = Transform.Find(lVar4,"Source",0);
              puVar9 = (uint64 *)Vector3.get_one(local_b8,0);
              if (lVar4 == null) throw; // [null/range check failed]
              local_f8 = *puVar9;
              local_f0 = *(uint32 *)(puVar9 + 1);
            }
            Transform.set_localScale(lVar4);
            local_res8[0] = local_res8[0] + 1;
          } while (local_res8[0] < 6);
          do {
            if ((this.creaftUIPanel == null) ||
               (lVar4 = GameObject.get_transform(this.creaftUIPanel,0)) == null)
            throw; // [null/range check failed]
            lVar4 = Transform.Find(lVar4,"EquipLittleType",0);
            uVar5 = Int32.ToString(local_res20,0);
            if ((lVar4 == null) ||
               ((lVar4 = Transform.Find(lVar4,uVar5,0), lVar4 == null ||
                (lVar4 = Component.get_gameObject(lVar4,0)) == null))) throw; // [null/range check failed]
            GameObject.SetActive(lVar4);
            local_res20[0] = local_res20[0] + 1;
          } while (local_res20[0] < 4);
          if (((this.creaftUIPanel == null) ||
              (lVar4 = GameObject.get_transform(this.creaftUIPanel,0)) == null) ||
             (lVar4 = Transform.Find(lVar4,"CraftButton",0)) == null) throw; // [null/range check failed]
          lVar4 = Component.GetComponent(lVar4,DAT_181d6af40);
          uVar2 = CraftUIController.HaveResource(this,this.resourceCostID,0);
          if (lVar4 == null) throw; // [null/range check failed]
          Selectable.set_interactable(lVar4,uVar2,0);
          lVar4 = this.forceCraftToggle;
          if (!this.useMoney) {
            if ((this.craftMaterialData != null) || (this.craftMaterialDataSub != null)) {
              if ((lVar4 == null) || (lVar4 = GameObject.GetComponent(lVar4,DAT_181da2130)) == null)
              throw; // [null/range check failed]
              uVar5 = 1;
              goto LAB_180a4f125;
            }
            if ((lVar4 == null) || (lVar4 = GameObject.GetComponent(lVar4,DAT_181da2130)) == null)
            throw; // [null/range check failed]
            uVar5 = 1;
          }
          else {
            if ((lVar4 == null) || (lVar4 = GameObject.GetComponent(lVar4,DAT_181da2130)) == null)
            throw; // [null/range check failed]
            uVar5 = 0;
          }
          Toggle.set_isOn(lVar4,uVar5,0);
          if ((this.forceCraftToggle != null) &&
             (lVar4 = GameObject.GetComponent(this.forceCraftToggle,DAT_181da2130)) != null)
          {
            uVar5 = 0;
        LAB_180a4f125:
            Selectable.set_interactable(lVar4,uVar5,0);
            return;
          }
        }
    }

    // Token : 0x600130C
    // RVA   : 0xA4D2B0   Offset: 0xA4BAB0   Length: 0x13
    public bool HaveNoMaterial()
    {
        if (this.craftMaterialData != null) {
          return false;
        }
        return this.craftMaterialDataSub == null;
    }

    // Token : 0x600130D
    // RVA   : 0xA4D4C0   Offset: 0xA4BCC0   Length: 0x30
    public void HideCraftUI()
    {
        if (this.creaftUIPanel != null) {
          GameObject.SetActive(this.creaftUIPanel,0,0);
          CraftUIController.ClearAllCraftMaterial(this,0);
          return;
        }
    }

    // Token : 0x600130E
    // RVA   : 0xA4D5F0   Offset: 0xA4BDF0   Length: 0xD75
    public void OpenCraftUI(CraftType _targetType, AreaBuildingData _targetBuilding, bool _useMoney)
    {
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        var pStatics_ef00 = *(int64*)(DAT_181d4ef00 + 184);
        void CraftUIController.OpenCraftUI
                     (int64 this,int _targetType,uint64 _targetBuilding,uint8 _useMoney)
        {
        uint32 uVar1;
        char cVar2;
        int64 *plVar3;
        int64 lVar4;
        uint64 uVar5;
        uint64 uVar6;
        uint64 uVar7;
        int64 lVar8;
        int64 *plVar9;
        uint32 uVar10;
        int iVar11;
        float fVar12;
        int local_res8 [2];
        int local_res10 [2];
        int local_48;
        int local_44 [7];
        local_48 = 0;
        uVar5 = "Sound/SoundEffect/Armor";
        if (((_targetType == null) || (uVar5 = "Sound/SoundEffect/Med", _targetType == 1)) ||
           (uVar5 = "Sound/SoundEffect/Food", _targetType == 2)) {
          plVar3 = (int64 *)Resources.Load(uVar5,0);
          plVar9 = (int64 *)0;
          if ((plVar3 != (int64 *)0) && (*plVar3 == DAT_181d8a228)) {
            plVar9 = plVar3;
          }
          NGUITools.PlaySound(plVar9,0);
        }
        CraftUIController.ClearAllCraftMaterial(this,0);
        if (this.creaftUIPanel == null) throw; // [null/range check failed]
        GameObject.SetActive(this.creaftUIPanel,1,0);
        this.targetBuilding = _targetBuilding;
        this.craftType = _targetType;
        lVar4 = this.creaftUIPanel;
        this.useMoney = _useMoney;
        this.resourceCostID = 0;
        if (this.craftType == null) {
          if (((lVar4 == null) || (lVar4 = GameObject.get_transform(lVar4,0)) == null) ||
             (lVar4 = Transform.Find(lVar4,"EquipSubTypeChooseGrid",0)) == null) throw; // [null/range check failed]
          lVar4 = Component.get_gameObject(lVar4,0);
          if (lVar4 == null) throw; // [null/range check failed]
          GameObject.SetActive(lVar4,1,0);
          if (((this.creaftUIPanel == null) ||
              (lVar4 = GameObject.get_transform(this.creaftUIPanel,0)) == null) ||
             ((lVar4 = Transform.Find(lVar4,"EquipSubTypeChooseGrid",0), lVar4 == null ||
              ((lVar4 = Transform.Find(lVar4,"0",0), lVar4 == null ||
               (lVar4 = Component.GetComponent(lVar4,DAT_181d6da40)) == null))))) throw; // [null/range check failed]
          Toggle.set_isOn(lVar4,1,0);
        }
        else {
          if ((((lVar4 == null) || (lVar4 = GameObject.get_transform(lVar4,0)) == null) ||
              (lVar4 = Transform.Find(lVar4,"EquipSubTypeChooseGrid",0)) == null) ||
             (lVar4 = Component.get_gameObject(lVar4,0)) == null) throw; // [null/range check failed]
          GameObject.SetActive(lVar4,0,0);
        }
        lVar4 = this.creaftUIPanel;
        if (this.craftType == 2) {
          if (((lVar4 == null) || (lVar4 = GameObject.get_transform(lVar4,0)) == null) ||
             (lVar4 = Transform.Find(lVar4,"FoodSubTypeChooseGrid",0)) == null) throw; // [null/range check failed]
          lVar4 = Component.get_gameObject(lVar4,0);
          if (lVar4 == null) throw; // [null/range check failed]
          GameObject.SetActive(lVar4,1,0);
          if (((this.creaftUIPanel == null) ||
              (lVar4 = GameObject.get_transform(this.creaftUIPanel,0)) == null) ||
             ((lVar4 = Transform.Find(lVar4,"FoodSubTypeChooseGrid",0), lVar4 == null ||
              ((lVar4 = Transform.Find(lVar4,"0",0), lVar4 == null ||
               (lVar4 = Component.GetComponent(lVar4,DAT_181d6da40)) == null))))) throw; // [null/range check failed]
          Toggle.set_isOn(lVar4,1,0);
        }
        else {
          if ((((lVar4 == null) || (lVar4 = GameObject.get_transform(lVar4,0)) == null) ||
              (lVar4 = Transform.Find(lVar4,"FoodSubTypeChooseGrid",0)) == null) ||
             (lVar4 = Component.get_gameObject(lVar4,0)) == null) throw; // [null/range check failed]
          GameObject.SetActive(lVar4,0,0);
        }
        if (((this.creaftUIPanel != null) &&
            (lVar4 = GameObject.get_transform(this.creaftUIPanel,0)) != null) &&
           (lVar4 = Transform.Find(lVar4,"Title",0)) != null) {
          uVar5 = Component.GetComponent(lVar4,DAT_181d6d8c0);
          lVar4 = *(int64 *)(pStatics_ef00 + 0x570);
          if (lVar4 == null) throw; // [null/range check failed]
          uVar1 = this.craftType;
          if (*(uint32 *)(lVar4 + 24) <= uVar1) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          LTLocalization.SetText
                    (uVar5,lVar4[uVar1],
                     0);
          local_res10[0] = 0;
          do {
            iVar11 = 3;
            if (!this.useMoney) {
              iVar11 = this.craftType;
            }
            local_res8[0] = 0;
            do {
              if ((this.creaftUIPanel == null) ||
                 (lVar4 = GameObject.get_transform(this.creaftUIPanel,0)) == null)
              throw; // [null/range check failed]
              lVar4 = Transform.Find(lVar4,"ResourceCostGrid",0);
              uVar5 = Int32.ToString(local_res10,0);
              if ((lVar4 == null) || (lVar4 = Transform.Find(lVar4,uVar5,0)) == null)
              throw; // [null/range check failed]
              lVar4 = Transform.Find(lVar4,"Source",0);
              uVar5 = Int32.ToString(local_res8,0);
              if (((lVar4 == null) || (lVar4 = Transform.Find(lVar4,uVar5,0)) == null) ||
                 (lVar4 = Component.get_gameObject(lVar4,0)) == null) throw; // [null/range check failed]
              cVar2 = GameObject.get_activeSelf(lVar4,0);
              if ((bool)cVar2 != (iVar11 == local_res8[0])) {
                if ((this.creaftUIPanel == null) ||
                   (lVar4 = GameObject.get_transform(this.creaftUIPanel,0)) == null)
                throw; // [null/range check failed]
                lVar4 = Transform.Find(lVar4,"ResourceCostGrid",0);
                uVar5 = Int32.ToString(local_res10,0);
                if ((lVar4 == null) || (lVar4 = Transform.Find(lVar4,uVar5,0)) == null)
                throw; // [null/range check failed]
                lVar4 = Transform.Find(lVar4,"Source",0);
                uVar5 = Int32.ToString(local_res8,0);
                if ((lVar4 == null) || (lVar4 = Transform.Find(lVar4,uVar5,0)) == null)
                throw; // [null/range check failed]
                lVar4 = Component.get_gameObject(lVar4,0);
                if (lVar4 == null) throw; // [null/range check failed]
                GameObject.SetActive(lVar4,iVar11 == local_res8[0]);
              }
              local_res8[0] = local_res8[0] + 1;
            } while (local_res8[0] < 4);
            if (0 < local_res10[0]) {
              if ((this.creaftUIPanel == null) ||
                 (lVar4 = GameObject.get_transform(this.creaftUIPanel,0)) == null)
              goto LAB_180a4e360;
              lVar4 = Transform.Find(lVar4,"ResourceCostGrid",0);
              uVar5 = Int32.ToString(local_res10,0);
              if ((lVar4 == null) || (lVar4 = Transform.Find(lVar4,uVar5,0)) == null)
              goto LAB_180a4e360;
              lVar4 = Component.GetComponent(lVar4,DAT_181d6ccc0);
              lVar8 = *(int64 *)(pStatics_ef00 + 0x4a8);
              iVar11 = this.craftType;
              if (iVar11 == 0) {
        LAB_180a4dd9c:
                uVar10 = 6;
              }
              else if (iVar11 == 1) {
                uVar10 = 7;
              }
              else {
                if (iVar11 != 2) goto LAB_180a4dd9c;
                uVar10 = 8;
              }
              if (lVar8 == null) {
        LAB_180a4e360:
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              uVar5 = FUN_180002f80(lVar8,uVar10,DAT_181d7c9c0);
              local_44[0] = local_res10[0] * 20;
              uVar6 = il2cpp_value_box(DAT_181d5b2f8,local_44);
              uVar5 = String.Format("{0} {1}",uVar5,uVar6,0);
              fVar12 = (float)CraftUIController.GetCraftTargetSkillNum(this,0);
              uVar7 = GlobalData.GenerateChangeColorText(uVar5,(float)local_res10[0] <= fVar12 / 20.0,0);
              uVar5 = "解锁需要:\n{0}{1}";
              uVar6 = "";
              if (!this.useMoney) {
                lVar8 = *(int64 *)(pStatics_ef00 + 0x3d0);
                if (lVar8 == null) throw; // [null/range check failed]
                uVar6 = FUN_180002f80(lVar8,local_res10[0],DAT_181d7c9c0);
                lVar8 = FUN_18046c0a0(0);
                if ((lVar8 == null) || (*(int64 *)(lVar8 + 32) == 0)) throw; // [null/range check failed]
                lVar8 = WorldData.Player(*(int64 *)(lVar8 + 32),0);
                if (lVar8 == null) throw; // [null/range check failed]
                uVar6 = GlobalData.GenerateChangeColorText
                                  (uVar6,local_res10[0] <= *(int *)(lVar8 + 184),0);
                uVar6 = String.Concat("\n",uVar6,0);
              }
              uVar5 = String.Format(uVar5,uVar7,uVar6,0);
              if (lVar4 == null) throw; // [null/range check failed]
              *(uint64 *)(lVar4 + 24) = uVar5;
            }
            local_res10[0] = local_res10[0] + 1;
          } while (local_res10[0] < 6);
          do {
            if ((this.creaftUIPanel == null) ||
               (lVar4 = GameObject.get_transform(this.creaftUIPanel,0)) == null)
            throw; // [null/range check failed]
            lVar4 = Transform.Find(lVar4,"Decoration",0);
            uVar5 = Int32.ToString(&local_48,0);
            if ((lVar4 == null) ||
               ((lVar4 = Transform.Find(lVar4,uVar5,0), lVar4 == null ||
                (lVar4 = Component.get_gameObject(lVar4,0)) == null))) throw; // [null/range check failed]
            cVar2 = GameObject.get_activeSelf(lVar4,0);
            if ((bool)cVar2 != (this.craftType == local_48)) {
              if ((this.creaftUIPanel == null) ||
                 (lVar4 = GameObject.get_transform(this.creaftUIPanel,0)) == null)
              throw; // [null/range check failed]
              lVar4 = Transform.Find(lVar4,"Decoration",0);
              uVar5 = Int32.ToString(&local_48,0);
              if ((lVar4 == null) || (lVar4 = Transform.Find(lVar4,uVar5,0)) == null)
              throw; // [null/range check failed]
              lVar4 = Component.get_gameObject(lVar4,0);
              if (lVar4 == null) throw; // [null/range check failed]
              GameObject.SetActive(lVar4,this.craftType == local_48);
            }
            local_48 = local_48 + 1;
          } while (local_48 < 3);
          if (this.forceCraftToggle == null) throw; // [null/range check failed]
          GameObject.SetActive
                    (this.forceCraftToggle,
                     CONCAT31((int3)((uint32)local_48 >> 8),!this.useMoney),0);
          if (((*pStatics_df90 == 0) ||
              (lVar4 = *(int64 *)(*pStatics_df90 + 32)) == null) ||
             (lVar4 = WorldData.Player(lVar4,0)) == null) throw; // [null/range check failed]
          cVar2 = HeroData.HaveForceFunction(lVar4,2);
          if ((!cVar2) || (this.craftType != 1)) {
            if (((*pStatics_df90 == 0) ||
                (lVar4 = *(int64 *)(*pStatics_df90 + 32)) == null) ||
               (lVar4 = WorldData.Player(lVar4,0)) == null) throw; // [null/range check failed]
            cVar2 = HeroData.HaveForceFunction(lVar4,6);
            if ((!cVar2) || (this.craftType != null)) {
              if (((*pStatics_df90 == 0) ||
                  (lVar4 = *(int64 *)(*pStatics_df90 + 32)) == null) ||
                 (lVar4 = WorldData.Player(lVar4,0)) == null) throw; // [null/range check failed]
              cVar2 = HeroData.HaveForceFunction(lVar4,12);
              if ((!cVar2) || (this.craftType != 2)) {
                if ((this.creaftUIPanel == null) ||
                   ((lVar4 = GameObject.get_transform(this.creaftUIPanel,0), lVar4 == null ||
                    (lVar4 = Transform.Find(lVar4,"CraftMaterialSub",0)) == null))) throw; // [null/range check failed]
                lVar4 = Component.get_gameObject(lVar4,0);
                if (lVar4 == null) throw; // [null/range check failed]
                uVar5 = 0;
                goto LAB_180a4e323;
              }
            }
          }
          if (((this.creaftUIPanel != null) &&
              (lVar4 = GameObject.get_transform(this.creaftUIPanel,0)) != null) &&
             (lVar4 = Transform.Find(lVar4,"CraftMaterialSub",0)) != null) {
            lVar4 = Component.get_gameObject(lVar4,0);
            if (lVar4 != null) {
              uVar5 = 1;
        LAB_180a4e323:
              GameObject.SetActive(lVar4,uVar5,0);
              CraftUIController.RefreshCraftUI(this,0);
              return;
            }
          }
        }
    }

    // Token : 0x600130F
    // RVA   : 0xA4B270   Offset: 0xA49A70   Length: 0xC4
    public void ChangeResourceCostID(GameObject buttonClicked)
    {
        uint uVar1;
        ulong uVar2;
        if (buttonClicked != null) {
          uVar2 = Object.get_name(buttonClicked,0);
          uVar1 = Int32.Parse(uVar2,0);
          this.resourceCostID = uVar1;
          CraftUIController.RefreshCraftUI(this,0);
          plVar3 = (int64 *)Resources.Load("Sound/SoundEffect/Button/TabButton",0);
          plVar4 = (int64 *)0;
          if ((plVar3 != (int64 *)0) && (*plVar3 == DAT_181d8a228)) {
            plVar4 = plVar3;
          }
          NGUITools.PlaySound(plVar4,0);
          return;
        }
    }

    // Token : 0x6001310
    // RVA   : 0xA4B340   Offset: 0xA49B40   Length: 0x1F8
    public void ChangeSubTypeChoose(GameObject buttonClicked)
    {
        uint uVar1;
        long lVar2;
        ulong uVar3;
        int[] local_res10 = new int[2];
        if (buttonClicked != null) {
          lVar2 = GameObject.GetComponent(buttonClicked,DAT_181da2130);
          if (lVar2 != null) {
            if (*(char *)(lVar2 + 0x118) != false) {
              uVar3 = Object.get_name(buttonClicked,0);
              uVar1 = Int32.Parse(uVar3,0);
              this.targetSubType = uVar1;
              CraftUIController.RefreshCraftUI(this,0);
              this.targetWeaponType = 0;
              local_res10[0] = 0;
              do {
                if (this.creaftUIPanel == null) {
        LAB_180a4b533:
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                lVar2 = GameObject.get_transform(this.creaftUIPanel,0);
                if (lVar2 == null) goto LAB_180a4b533;
                lVar2 = Transform.Find(lVar2,"EquipLittleType",0);
                uVar3 = Int32.ToString(local_res10,0);
                if (lVar2 == null) goto LAB_180a4b533;
                lVar2 = Transform.Find(lVar2,uVar3,0);
                if (lVar2 == null) goto LAB_180a4b533;
                lVar2 = Transform.Find(lVar2,"0",0);
                if (lVar2 == null) goto LAB_180a4b533;
                lVar2 = Component.GetComponent(lVar2,DAT_181d6da40);
                if (lVar2 == null) goto LAB_180a4b533;
                Toggle.set_isOn(lVar2);
                local_res10[0] = local_res10[0] + 1;
              } while (local_res10[0] < 4);
              plVar4 = (int64 *)Resources.Load("Sound/SoundEffect/Button/TabButton",0);
              plVar5 = (int64 *)0;
              if ((plVar4 != (int64 *)0) && (*plVar4 == DAT_181d8a228)) {
                plVar5 = plVar4;
              }
              NGUITools.PlaySound(plVar5,0);
            }
            return;
          }
        }
    }

    // Token : 0x6001311
    // RVA   : 0xA4B170   Offset: 0xA49970   Length: 0xF6
    public void ChangeFoodSubTypeChoose(GameObject buttonClicked)
    {
        uint uVar1;
        long lVar2;
        ulong uVar3;
        if (buttonClicked != null) {
          lVar2 = GameObject.GetComponent(buttonClicked,DAT_181da2130);
          if (lVar2 != null) {
            if (*(char *)(lVar2 + 0x118) != false) {
              uVar3 = Object.get_name(buttonClicked,0);
              uVar1 = Int32.Parse(uVar3,0);
              this.targetFoodSubType = uVar1;
              CraftUIController.RefreshCraftUI(this,0);
              plVar4 = (int64 *)Resources.Load("Sound/SoundEffect/Button/TabButton",0);
              plVar5 = (int64 *)0;
              if ((plVar4 != (int64 *)0) && (*plVar4 == DAT_181d8a228)) {
                plVar5 = plVar4;
              }
              NGUITools.PlaySound(plVar5,0);
            }
            return;
          }
        }
    }

    // Token : 0x6001312
    // RVA   : 0xA4B540   Offset: 0xA49D40   Length: 0xF6
    public void ChangeWeaponTypeChoose(GameObject buttonClicked)
    {
        uint uVar1;
        long lVar2;
        ulong uVar3;
        if (buttonClicked != null) {
          lVar2 = GameObject.GetComponent(buttonClicked,DAT_181da2130);
          if (lVar2 != null) {
            if (*(char *)(lVar2 + 0x118) != false) {
              uVar3 = Object.get_name(buttonClicked,0);
              uVar1 = Int32.Parse(uVar3,0);
              this.targetWeaponType = uVar1;
              CraftUIController.RefreshCraftUI(this,0);
              plVar4 = (int64 *)Resources.Load("Sound/SoundEffect/Button/TabButton",0);
              plVar5 = (int64 *)0;
              if ((plVar4 != (int64 *)0) && (*plVar4 == DAT_181d8a228)) {
                plVar5 = plVar4;
              }
              NGUITools.PlaySound(plVar5,0);
            }
            return;
          }
        }
    }

    // Token : 0x6001313
    // RVA   : 0xA4F250   Offset: 0xA4DA50   Length: 0x101
    public void ResetWeaponType()
    {
        long lVar1;
        ulong uVar2;
        int[] local_res8 = new int[2];
        this.targetWeaponType = 0;
        local_res8[0] = 0;
        while (this.creaftUIPanel != null) {
          lVar1 = GameObject.get_transform(this.creaftUIPanel,0);
          if (lVar1 == null) break;
          lVar1 = Transform.Find(lVar1,"EquipLittleType",0);
          uVar2 = Int32.ToString(local_res8,0);
          if (lVar1 == null) break;
          lVar1 = Transform.Find(lVar1,uVar2,0);
          if (lVar1 == null) break;
          lVar1 = Transform.Find(lVar1,"0",0);
          if (lVar1 == null) break;
          lVar1 = Component.GetComponent(lVar1,DAT_181d6da40);
          if (lVar1 == null) break;
          Toggle.set_isOn(lVar1);
          local_res8[0] = local_res8[0] + 1;
          if (3 < local_res8[0]) {
            return;
          }
        }
    }

    // Token : 0x6001314
    // RVA   : 0xA4CFB0   Offset: 0xA4B7B0   Length: 0x144
    public float GetResourceCostNum(int _resourceCostID)
    {
        int iVar1;
        ulong in_RAX;
        ulong uVar2;
        iVar1 = this.craftType;
        if (!this.useMoney) {
          if (iVar1 == 0) {
            uVar2 = FUN_1801f7f00();
            return uVar2;
          }
          if ((iVar1 != 1) && (iVar1 != 2)) {
            return in_RAX;
          }
          uVar2 = FUN_1801f7f00();
        }
        else {
          uVar2 = FUN_1801f7f00();
          if (iVar1 == 0) {
            uVar2 = (uint64)(uint32)-this.targetSubType;
          }
        }
        return uVar2;
    }

    // Token : 0x6001315
    // RVA   : 0xA4D100   Offset: 0xA4B900   Length: 0x1A1
    public List<ResourceData> GetResourceCost(int _resourceCostID)
    {
        int iVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        uint uVar5;
        lVar2 = il2cpp_internal(DAT_181d71cb0);
        FUN_180f58a90(lVar2,DAT_181d77dd8);
        iVar1 = this.craftType;
        if (iVar1 == 0) {
          uVar5 = CraftUIController.GetResourceCostNum(this,_resourceCostID,0);
          uVar3 = new PlotChoiceRequirement(2,uVar5);
          if (lVar2 == null) goto LAB_180a4d29c;
          FUN_181827900(lVar2,uVar3,DAT_181d77e58);
          uVar5 = CraftUIController.GetResourceCostNum(this,_resourceCostID,0);
          uVar3 = new PlotChoiceRequirement(3,uVar5);
        }
        else {
          if (iVar1 == 1) {
            uVar5 = CraftUIController.GetResourceCostNum(this,_resourceCostID,0);
            uVar3 = il2cpp_internal(DAT_181d774d0);
            uVar4 = 4;
          }
          else {
            if (iVar1 != 2) {
              return lVar2;
            }
            uVar5 = CraftUIController.GetResourceCostNum(this,_resourceCostID,0);
            uVar3 = il2cpp_internal(DAT_181d774d0);
            uVar4 = 1;
          }
          PlotChoiceRequirement.ctor(uVar3,uVar4,uVar5,0);
          if (lVar2 == null) {
        LAB_180a4d29c:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
        }
        FUN_181827900(lVar2,uVar3,DAT_181d77e58);
        return lVar2;
    }

    // Token : 0x6001316
    // RVA   : 0xA4C9A0   Offset: 0xA4B1A0   Length: 0xCB
    public float GetCraftFinalValue()
    {
        ulong uVar1;
        uint uVar2;
        float fVar3;
        float fVar4;
        float fVar5;
        uVar2 = this.resourceCostID;
        if (!this.useMoney) {
          uVar1 = CraftUIController.GetResourceCost(this,uVar2);
          fVar3 = (float)GlobalData.GetResourceTotalValue(uVar1,0);
          uVar2 = this.resourceCostID;
        }
        else {
          fVar3 = (float)CraftUIController.GetResourceCostNum();
        }
        if ((this.craftMaterialData == null) && (this.craftMaterialDataSub == null)) {
          fVar5 = 0.5;
        }
        else {
          fVar5 = 1.0;
        }
        fVar4 = (float)CraftUIController.GetCraftRate(this,uVar2,0);
        return fVar4 * fVar5 * fVar3;
    }

    // Token : 0x6001317
    // RVA   : 0xA4CED0   Offset: 0xA4B6D0   Length: 0x21
    public LivingSkillType GetCraftTargetSkillType()
    {
        uint32 FUN_180a4ced0(int64 this)
        {
        int iVar1;
        iVar1 = this.craftType;
        if (iVar1 != 0) {
          if (iVar1 == 1) {
            return 7;
          }
          if (iVar1 == 2) {
            return 8;
          }
        }
        return 6;
    }

    // Token : 0x6001318
    // RVA   : 0xA4CDB0   Offset: 0xA4B5B0   Length: 0x11C
    public float GetCraftTargetSkillNum()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        int iVar1;
        long lVar2;
        uint uVar3;
        if ((*pStatics == 0) ||
           (lVar2 = *(int64 *)(*pStatics + 32)) == null)
        throw; // [null/range check failed]
        lVar2 = WorldData.Player(lVar2,0);
        if (lVar2 == null) throw; // [null/range check failed]
        iVar1 = this.craftType;
        lVar2 = *(int64 *)(lVar2 + 0x168);
        if (iVar1 == 0) {
        LAB_180a4ce9a:
          uVar3 = 6;
        }
        else if (iVar1 == 1) {
          uVar3 = 7;
        }
        else {
          if (iVar1 != 2) goto LAB_180a4ce9a;
          uVar3 = 8;
        }
        if (lVar2 != null) {
          if (*(uint32 *)(lVar2 + 24) <= uVar3) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          return *(uint32 *)(*(int64 *)(lVar2 + 16) + 32 + (uint64)uVar3 * 4);
        }
    }

    // Token : 0x6001319
    // RVA   : 0xA4CA70   Offset: 0xA4B270   Length: 0x337
    public float GetCraftRate(int costID)
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        int iVar1;
        bool cVar2;
        long lVar3;
        float fVar4;
        float fVar5;
        float fVar6;
        float fVar7;
        fVar7 = 0.0;
        if ((*pStatics == 0) ||
           (lVar3 = *(int64 *)(*pStatics + 32)) == null)
        throw; // [null/range check failed]
        lVar3 = WorldData.Player(lVar3,0);
        if (lVar3 == null) throw; // [null/range check failed]
        cVar2 = HeroData.HaveForceFunction(lVar3,2);
        if ((!cVar2) || (this.craftType != 1)) {
          if ((*pStatics == 0) ||
             (lVar3 = *(int64 *)(*pStatics + 32)) == null)
          throw; // [null/range check failed]
          lVar3 = WorldData.Player(lVar3,0);
          if (lVar3 == null) throw; // [null/range check failed]
          cVar2 = HeroData.HaveForceFunction(lVar3,6);
          if ((cVar2) && (this.craftType == null)) goto LAB_180a4ccd1;
          if ((*pStatics == 0) ||
             (lVar3 = *(int64 *)(*pStatics + 32)) == null)
          throw; // [null/range check failed]
          lVar3 = WorldData.Player(lVar3,0);
          if (lVar3 == null) throw; // [null/range check failed]
          cVar2 = HeroData.HaveForceFunction(lVar3,12);
          if ((cVar2) && (this.craftType == 2)) goto LAB_180a4ccd1;
        }
        else {
        LAB_180a4ccd1:
          fVar7 = 0.2;
        }
        fVar4 = (float)CraftUIController.GetCraftTargetSkillNum(this,0);
        if (this.targetBuilding != null) {
          iVar1 = this.targetBuilding.lv;
          if (this.craftMaterialData == null) {
            fVar6 = 0.0;
          }
          else {
            fVar6 = (float)ItemData.GetMaterialExtraCraftRate(this.craftMaterialData,0);
          }
          if (this.craftMaterialDataSub == null) {
            fVar5 = 0.0;
          }
          else {
            fVar5 = (float)ItemData.GetMaterialExtraCraftRate(this.craftMaterialDataSub,0);
          }
          Mathf.Max(0,((fVar4 - (float)costID * 35.0) + (float)iVar1 * 5.0) * 0.01 + fVar7 + 1.0 +
                       fVar5 + fVar6,0);
          return;
        }
    }

    // Token : 0x600131A
    // RVA   : 0xA4CF50   Offset: 0xA4B750   Length: 0x58
    public float GetMaretialExtraCraftRate()
    {
        float fVar1;
        float fVar2;
        fVar1 = 0.0;
        if (this.craftMaterialData == null) {
          fVar2 = 0.0;
        }
        else {
          fVar2 = (float)ItemData.GetMaterialExtraCraftRate(this.craftMaterialData,0);
        }
        if (this.craftMaterialDataSub != null) {
          fVar1 = (float)ItemData.GetMaterialExtraCraftRate(this.craftMaterialDataSub,0);
        }
        return fVar1 + fVar2;
    }

    // Token : 0x600131B
    // RVA   : 0xA4BEF0   Offset: 0xA4A6F0   Length: 0x1E4
    public void CraftMaterialButtonClicked()
    {
        int iVar1;
        long lVar2;
        bool cVar3;
        long lVar4;
        ulong uVar5;
        uint uVar6;
        uint[] local_res8 = new uint[2];
        uint[] local_res18 = new uint[2];
        uVar5 = this.craftMaterialItemIcon;
        cVar3 = Object.op_Equality(uVar5,0,0);
        if (!cVar3) {
          return;
        }
        iVar1 = this.craftType;
        uVar6 = 0;
        if (iVar1 == 0) {
          uVar6 = 3;
        }
        else if (iVar1 == 1) {
          uVar6 = 4;
        }
        else if (iVar1 == 2) {
          uVar6 = 5;
        }
        lVar2 = **(int64 **)(DAT_181d92370 + 184);
        lVar4 = il2cpp_internal(DAT_181d701b0);
        FUN_180f58a90(lVar4,DAT_181d6dfe8);
        local_res8[0] = 0;
        uVar5 = il2cpp_value_box(DAT_181d5b2f8,local_res8);
        if (lVar4 != null) {
          FUN_181827900(lVar4,uVar5,DAT_181d6e0e8);
          local_res18[0] = 5;
          uVar5 = il2cpp_value_box(DAT_181d5b2f8,local_res18);
          FUN_181827900(lVar4,uVar5,DAT_181d6e0e8);
          uVar5 = Component.get_gameObject(this,0);
          if (lVar2 != null) {
            ChooseController.ShowChoosePanel(lVar2,1,lVar4,uVar5,"CraftMaterialChoosen",0,uVar6,0,0,0);
            return;
          }
        }
    }

    // Token : 0x600131C
    // RVA   : 0xA4B840   Offset: 0xA4A040   Length: 0xB0
    public void ClearCraftMaterial()
    {
        ulong uVar1;
        this.craftMaterialData = 0;
        uVar1 = this.craftMaterialItemIcon;
        Object.Destroy(uVar1,0);
        this.craftMaterialItemIcon = 0;
        if (this.clearMaterialButton != null) {
          GameObject.SetActive(this.clearMaterialButton,0,0);
          CraftUIController.RefreshCraftUI(this,0);
          return;
        }
    }

    // Token : 0x600131D
    // RVA   : 0xA4C310   Offset: 0xA4AB10   Length: 0x228
    public void CraftMaterialChoosen()
    {
        var pStatics_2370 = *(int64*)(DAT_181d92370 + 184);
        var pStatics_e188 = *(int64*)(DAT_181d4e188 + 184);
        ulong uVar1;
        long lVar2;
        ulong uVar3;
        if ((*pStatics_2370 != 0) &&
           (lVar2 = *(int64 *)(*pStatics_2370 + 72)) != null) {
          lVar2 = GameObject.GetComponent(lVar2,DAT_181da0070);
          if (lVar2 != null) {
            this.craftMaterialData = *(uint64 *)(lVar2 + 32);
            if (this.creaftUIPanel != null) {
              lVar2 = GameObject.get_transform(this.creaftUIPanel,0);
              if (lVar2 != null) {
                lVar2 = Transform.Find(lVar2,"CraftMaterial",0);
                if (lVar2 != null) {
                  uVar3 = Component.get_gameObject(lVar2,0);
                  if (*pStatics_e188 != 0) {
                    uVar1 = *(uint64 *)(*pStatics_e188 + 160);
                    uVar3 = GlobalData.AddChild(uVar3,uVar1,0);
                    this.craftMaterialItemIcon = uVar3;
                    if (this.craftMaterialItemIcon != null) {
                      lVar2 = GameObject.GetComponent(this.craftMaterialItemIcon,DAT_181da0070);
                      if (lVar2 != null) {
                        *(uint64 *)(lVar2 + 32) = this.craftMaterialData;
                        if (this.craftMaterialItemIcon != null) {
                          lVar2 = GameObject.GetComponent(this.craftMaterialItemIcon,DAT_181da0070);
                          if (lVar2 != null) {
                            *(uint32 *)(lVar2 + 40) = 1;
                            if (this.craftMaterialItemIcon != null) {
                              lVar2 = GameObject.GetComponent
                                                (this.craftMaterialItemIcon,DAT_181da0070);
                              if (lVar2 != null) {
                                ItemIconController.AutoSetName(lVar2,1,0);
                                if (this.clearMaterialButton != null) {
                                  GameObject.SetActive(this.clearMaterialButton,1,0);
                                  CraftUIController.RefreshCraftUI(this,0);
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

    // Token : 0x600131E
    // RVA   : 0xA4BD00   Offset: 0xA4A500   Length: 0x1E4
    public void CraftMaterialButtonClickedSub()
    {
        int iVar1;
        long lVar2;
        bool cVar3;
        long lVar4;
        ulong uVar5;
        uint uVar6;
        uint[] local_res8 = new uint[2];
        uint[] local_res18 = new uint[2];
        uVar5 = this.craftMaterialItemIconSub;
        cVar3 = Object.op_Equality(uVar5,0,0);
        if (!cVar3) {
          return;
        }
        iVar1 = this.craftType;
        uVar6 = 0;
        if (iVar1 == 0) {
          uVar6 = 3;
        }
        else if (iVar1 == 1) {
          uVar6 = 4;
        }
        else if (iVar1 == 2) {
          uVar6 = 5;
        }
        lVar2 = **(int64 **)(DAT_181d92370 + 184);
        lVar4 = il2cpp_internal(DAT_181d701b0);
        FUN_180f58a90(lVar4,DAT_181d6dfe8);
        local_res8[0] = 0;
        uVar5 = il2cpp_value_box(DAT_181d5b2f8,local_res8);
        if (lVar4 != null) {
          FUN_181827900(lVar4,uVar5,DAT_181d6e0e8);
          local_res18[0] = 5;
          uVar5 = il2cpp_value_box(DAT_181d5b2f8,local_res18);
          FUN_181827900(lVar4,uVar5,DAT_181d6e0e8);
          uVar5 = Component.get_gameObject(this,0);
          if (lVar2 != null) {
            ChooseController.ShowChoosePanel(lVar2,1,lVar4,uVar5,"CraftMaterialChoosenSub",0,uVar6,0,0,0);
            return;
          }
        }
    }

    // Token : 0x600131F
    // RVA   : 0xA4B780   Offset: 0xA49F80   Length: 0xB0
    public void ClearCraftMaterialSub()
    {
        ulong uVar1;
        this.craftMaterialDataSub = 0;
        uVar1 = this.craftMaterialItemIconSub;
        Object.Destroy(uVar1,0);
        this.craftMaterialItemIconSub = 0;
        if (this.clearMaterialButtonSub != null) {
          GameObject.SetActive(this.clearMaterialButtonSub,0,0);
          CraftUIController.RefreshCraftUI(this,0);
          return;
        }
    }

    // Token : 0x6001320
    // RVA   : 0xA4C0E0   Offset: 0xA4A8E0   Length: 0x228
    public void CraftMaterialChoosenSub()
    {
        var pStatics_2370 = *(int64*)(DAT_181d92370 + 184);
        var pStatics_e188 = *(int64*)(DAT_181d4e188 + 184);
        ulong uVar1;
        long lVar2;
        ulong uVar3;
        if ((*pStatics_2370 != 0) &&
           (lVar2 = *(int64 *)(*pStatics_2370 + 72)) != null) {
          lVar2 = GameObject.GetComponent(lVar2,DAT_181da0070);
          if (lVar2 != null) {
            this.craftMaterialDataSub = *(uint64 *)(lVar2 + 32);
            if (this.creaftUIPanel != null) {
              lVar2 = GameObject.get_transform(this.creaftUIPanel,0);
              if (lVar2 != null) {
                lVar2 = Transform.Find(lVar2,"CraftMaterialSub",0);
                if (lVar2 != null) {
                  uVar3 = Component.get_gameObject(lVar2,0);
                  if (*pStatics_e188 != 0) {
                    uVar1 = *(uint64 *)(*pStatics_e188 + 160);
                    uVar3 = GlobalData.AddChild(uVar3,uVar1,0);
                    this.craftMaterialItemIconSub = uVar3;
                    if (this.craftMaterialItemIconSub != null) {
                      lVar2 = GameObject.GetComponent(this.craftMaterialItemIconSub,DAT_181da0070);
                      if (lVar2 != null) {
                        *(uint64 *)(lVar2 + 32) = this.craftMaterialDataSub;
                        if (this.craftMaterialItemIconSub != null) {
                          lVar2 = GameObject.GetComponent(this.craftMaterialItemIconSub,DAT_181da0070);
                          if (lVar2 != null) {
                            *(uint32 *)(lVar2 + 40) = 1;
                            if (this.craftMaterialItemIconSub != null) {
                              lVar2 = GameObject.GetComponent
                                                (this.craftMaterialItemIconSub,DAT_181da0070);
                              if (lVar2 != null) {
                                ItemIconController.AutoSetName(lVar2,1,0);
                                if (this.clearMaterialButtonSub != null) {
                                  GameObject.SetActive(this.clearMaterialButtonSub,1,0);
                                  CraftUIController.RefreshCraftUI(this,0);
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

    // Token : 0x6001321
    // RVA   : 0xA4B640   Offset: 0xA49E40   Length: 0x138
    public void ClearAllCraftMaterial()
    {
        ulong uVar1;
        this.craftMaterialData = 0;
        uVar1 = this.craftMaterialItemIcon;
        Object.Destroy(uVar1,0);
        this.craftMaterialItemIcon = 0;
        if (this.clearMaterialButton != null) {
          GameObject.SetActive(this.clearMaterialButton,0,0);
          CraftUIController.RefreshCraftUI(this,0);
          this.craftMaterialDataSub = 0;
          uVar1 = this.craftMaterialItemIconSub;
          Object.Destroy(uVar1,0);
          this.craftMaterialItemIconSub = 0;
          if (this.clearMaterialButtonSub != null) {
            GameObject.SetActive(this.clearMaterialButtonSub,0,0);
            CraftUIController.RefreshCraftUI(this,0);
            return;
          }
        }
    }

    // Token : 0x6001322
    // RVA   : 0xA4C8D0   Offset: 0xA4B0D0   Length: 0xC2
    public void ForceCraftToggleButtonClicked()
    {
        long lVar1;
        if (this.forceCraftToggle != null) {
          lVar1 = GameObject.GetComponent(this.forceCraftToggle,DAT_181da2130);
          if (lVar1 != null) {
            this.forceCraft = *(uint8 *)(lVar1 + 0x118);
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

    // Token : 0x6001323
    // RVA   : 0xA4D2D0   Offset: 0xA4BAD0   Length: 0x1E8
    public bool HaveResource(int _resourceCostID)
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        int iVar1;
        byte uVar2;
        long lVar3;
        ulong uVar4;
        float extraout_XMM0_Da;
        if (!this.useMoney) {
          if ((*pStatics != 0) &&
             (lVar3 = *(int64 *)(*pStatics + 32)) != null) {
            lVar3 = WorldData.Player(lVar3,0);
            if (lVar3 != null) {
              lVar3 = HeroData.GetForce(lVar3,0,0);
              uVar4 = CraftUIController.GetResourceCost(this,_resourceCostID,0);
              if (lVar3 != null) {
                uVar2 = ForceData.HaveResource(lVar3,uVar4,0);
                return uVar2;
              }
            }
          }
        }
        else {
          if ((*pStatics != 0) &&
             (lVar3 = *(int64 *)(*pStatics + 32)) != null) {
            lVar3 = WorldData.Player(lVar3,0);
            if ((lVar3 != null) && (*(int64 *)(lVar3 + 0x220) != 0)) {
              iVar1 = *(int *)(*(int64 *)(lVar3 + 0x220) + 24);
              CraftUIController.GetResourceCostNum(this,_resourceCostID,0);
              return extraout_XMM0_Da <= (float)iVar1;
            }
          }
        }
    }

    // Token : 0x6001324
    // RVA   : 0xA4CF00   Offset: 0xA4B700   Length: 0x48
    public int GetCraftTime()
    {
        uint uVar1;
        float fVar2;
        if (this.craftType == null) {
          fVar2 = 1.0;
        }
        else {
          fVar2 = 0.5;
        }
        uVar1 = Mathf.RoundToInt((float)(this.resourceCostID + 1) * fVar2,0);
        Mathf.Max(1,uVar1);
    }

    // Token : 0x6001325
    // RVA   : 0xA4B900   Offset: 0xA4A100   Length: 0x3F5
    public void CraftButtonClicked()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        long lVar1;
        bool cVar2;
        uint uVar3;
        long lVar5;
        ulong uVar6;
        uint uVar8;
        long lVar9;
        float fVar10;
        cVar2 = CraftUIController.HaveResource(this,this.resourceCostID,0);
        if (!cVar2) {
          if (*pStatics != 0) {
            GameController.ShowTextOnMouse(*pStatics,"资源不足！",0);
            plVar4 = (int64 *)Resources.Load("Sound/SoundEffect/WrongClick",0);
            plVar7 = (int64 *)0;
            if ((plVar4 != (int64 *)0) && (*plVar4 == DAT_181d8a228)) {
              plVar7 = plVar4;
            }
            NGUITools.PlaySound(plVar7,0);
            return;
          }
          throw; // [null/range check failed]
        }
        if (!this.useMoney) {
          lVar5 = FUN_18046c0a0(0);
          if (((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) ||
             (lVar5 = WorldData.Player(*(int64 *)(lVar5 + 32),0)) == null) throw; // [null/range check failed]
          lVar5 = HeroData.GetForce(lVar5,0,0);
          uVar6 = CraftUIController.GetResourceCost(this,this.resourceCostID,0);
          if (lVar5 == null) throw; // [null/range check failed]
          ForceData.CostResource(lVar5,uVar6,1,0);
        }
        else {
          lVar5 = FUN_18046c0a0(0);
          if ((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) throw; // [null/range check failed]
          lVar5 = WorldData.Player(*(int64 *)(lVar5 + 32),0);
          fVar10 = (float)CraftUIController.GetResourceCostNum(this,this.resourceCostID,0)
          ;
          if (lVar5 == null) throw; // [null/range check failed]
          HeroData.ChangeMoney(lVar5,-(int)fVar10,1,0);
        }
        lVar5 = *(int64 *)(*(int64 *)(DAT_181d90b30 + 184) + 8);
        uVar8 = this.craftType;
        lVar9 = (int64)(int)uVar8;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d4ef00 + 184) + 0x570);
        if (lVar1 != null) {
          if (*(uint32 *)(lVar1 + 24) <= uVar8) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
            uVar8 = this.craftType;
          }
          uVar6 = *(uint64 *)(*(int64 *)(lVar1 + 16) + 32 + lVar9 * 8);
          if (uVar8 == 0) {
            fVar10 = 1.0;
          }
          else {
            fVar10 = 0.5;
          }
          uVar3 = Mathf.RoundToInt((float)(this.resourceCostID + 1) * fVar10,0);
          uVar3 = Mathf.Max(1,uVar3);
          if (lVar5 != null) {
            WorkingUIController.StartWorking
                      (lVar5,uVar6,uVar3,"","","FinishCraft","",0);
            CraftUIController.PlayCraftSound(this,0);
            return;
          }
        }
    }

    // Token : 0x6001326
    // RVA   : 0xA4E370   Offset: 0xA4CB70   Length: 0xCE
    public void PlayCraftSound()
    {
        int iVar1;
        ulong uVar3;
        iVar1 = this.craftType;
        uVar3 = "Sound/SoundEffect/SpeEffect/修理升级";
        if (((iVar1 != 0) && (uVar3 = "Sound/SoundEffect/CraftMed", iVar1 != 1)) && (uVar3 = "Sound/SoundEffect/CraftFood", iVar1 != 2))
        {
          return;
        }
        plVar2 = (int64 *)Resources.Load(uVar3,0);
        plVar4 = (int64 *)0;
        if ((plVar2 != (int64 *)0) && (*plVar2 == DAT_181d8a228)) {
          plVar4 = plVar2;
        }
        NGUITools.PlaySound(plVar4,0);
    }

    // Token : 0x6001327
    // RVA   : 0xA4F1C0   Offset: 0xA4D9C0   Length: 0x80
    public void ResetSetNameInput()
    {
        long lVar1;
        if (this.setNameInput != null) {
          lVar1 = GameObject.GetComponent(this.setNameInput,DAT_181d9ffe8);
          if (lVar1 != null) {
            InputField.set_text(lVar1,"",0);
            this.craftSettingName = "";
            return;
          }
        }
    }

    // Token : 0x6001328
    // RVA   : 0xA4F690   Offset: 0xA4DE90   Length: 0x740
    public void ShowCraftResultChoosePanel()
    {
        var pStatics = *(int64*)(DAT_181d4e188 + 184);
        ulong uVar1;
        long lVar2;
        ulong uVar3;
        long lVar4;
        int[] local_res8 = new int[2];
        if (((this.creaftUIPanel != null) &&
            (lVar2 = GameObject.get_transform(this.creaftUIPanel,0)) != null) &&
           (lVar2 = Transform.Find(lVar2,"CraftResult",0)) != null) {
          lVar2 = Component.get_gameObject(lVar2,0);
          if (lVar2 != null) {
            GameObject.SetActive(lVar2,1,0);
            if (this.craftMaterialData != null) {
              if (((this.creaftUIPanel == null) ||
                  (lVar2 = GameObject.get_transform(this.creaftUIPanel,0)) == null) ||
                 ((lVar2 = Transform.Find(lVar2,"CraftResult",0), lVar2 == null ||
                  (lVar2 = Transform.Find(lVar2,"Material",0)) == null))) throw; // [null/range check failed]
              uVar3 = Component.get_gameObject(lVar2,0);
              if (*pStatics == 0) throw; // [null/range check failed]
              uVar1 = *(uint64 *)(*pStatics + 160);
              lVar2 = GlobalData.AddChild(uVar3,uVar1,0);
              if (lVar2 == null) throw; // [null/range check failed]
              lVar4 = GameObject.GetComponent(lVar2,DAT_181da0070);
              if (lVar4 == null) throw; // [null/range check failed]
              *(uint64 *)(lVar4 + 32) = this.craftMaterialData;
              lVar2 = GameObject.GetComponent(lVar2,DAT_181da0070);
              if (lVar2 == null) throw; // [null/range check failed]
              *(uint32 *)(lVar2 + 40) = 1;
            }
            if (this.craftMaterialDataSub != null) {
              if ((((this.creaftUIPanel == null) ||
                   (lVar2 = GameObject.get_transform(this.creaftUIPanel,0)) == null) ||
                  (lVar2 = Transform.Find(lVar2,"CraftResult",0)) == null) ||
                 (lVar2 = Transform.Find(lVar2,"SubMaterial",0)) == null) throw; // [null/range check failed]
              uVar3 = Component.get_gameObject(lVar2,0);
              if (*pStatics == 0) throw; // [null/range check failed]
              uVar1 = *(uint64 *)(*pStatics + 160);
              lVar2 = GlobalData.AddChild(uVar3,uVar1,0);
              if (lVar2 == null) throw; // [null/range check failed]
              lVar4 = GameObject.GetComponent(lVar2,DAT_181da0070);
              if (lVar4 == null) throw; // [null/range check failed]
              *(uint64 *)(lVar4 + 32) = this.craftMaterialDataSub;
              lVar2 = GameObject.GetComponent(lVar2,DAT_181da0070);
              if (lVar2 == null) throw; // [null/range check failed]
              *(uint32 *)(lVar2 + 40) = 1;
            }
            if ((this.setNameInput != null) &&
               (lVar2 = GameObject.GetComponent(this.setNameInput,DAT_181d9ffe8)) != null
               ) {
              InputField.set_text(lVar2,"",0);
              this.craftSettingName = "";
              lVar2 = this.craftResultList;
              local_res8[0] = 0;
              if (lVar2 != null) {
                while( true ) {
                  if (lVar2.Count <= local_res8[0]) {
                    return;
                  }
                  if ((this.creaftUIPanel == null) ||
                     (lVar2 = GameObject.get_transform(this.creaftUIPanel,0)) == null)
                  break;
                  lVar2 = Transform.Find(lVar2,"CraftResult",0);
                  uVar3 = Int32.ToString(local_res8,0);
                  if ((lVar2 == null) ||
                     ((lVar2 = Transform.Find(lVar2,uVar3,0), lVar2 == null ||
                      (lVar2 = Transform.Find(lVar2,"ItemIcon",0)) == null))) break;
                  uVar3 = Component.get_gameObject(lVar2,0);
                  if (*pStatics == 0) break;
                  uVar1 = *(uint64 *)(*pStatics + 160);
                  lVar2 = GlobalData.AddChild(uVar3,uVar1,0);
                  if (lVar2 == null) break;
                  lVar4 = GameObject.GetComponent(lVar2,DAT_181da0070);
                  if ((this.craftResultList == null) ||
                     (uVar3 = FUN_180002f80(this.craftResultList,local_res8[0],DAT_181d69770),
                     lVar4 == null)) break;
                  *(uint64 *)(lVar4 + 32) = uVar3;
                  lVar4 = GameObject.GetComponent(lVar2,DAT_181da0070);
                  if (lVar4 == null) break;
                  *(uint32 *)(lVar4 + 40) = 1;
                  lVar4 = GameObject.GetComponent(lVar2,DAT_181da0070);
                  if (lVar4 == null) break;
                  ItemIconController.AutoSetName(lVar4,1,0);
                  uVar3 = CraftUIController.PlayItemSound(this,lVar2,0);
                  FUN_180d837c0(this,uVar3,0);
                  lVar4 = FUN_18046c600(0);
                  if (lVar4 == null) break;
                  uVar3 = CraftUIController.ShowItemParticle
                                    (this,*(uint64 *)(lVar4 + 128),lVar2,0,0x3f800000,0xffffffff,0
                                    );
                  FUN_180d837c0(this,uVar3,0);
                  lVar4 = FUN_18046c600(0);
                  if (lVar4 == null) break;
                  uVar3 = CraftUIController.ShowItemParticle
                                    (this,*(uint64 *)(lVar4 + 136),lVar2,0,0x3f800000,0xffffffff,0
                                    );
                  FUN_180d837c0(this,uVar3,0);
                  lVar4 = FUN_18046c600(0);
                  if (lVar4 == null) break;
                  uVar3 = CraftUIController.ShowItemParticle
                                    (this,*(uint64 *)(lVar4 + 152),lVar2,0,0x3f800000,0xffffffff,0
                                    );
                  FUN_180d837c0(this,uVar3,0);
                  if ((this.craftResultList == null) || (lVar4 = FUN_180002f80()) == null)
                  break;
                  if (4 < *(int *)(lVar4 + 64)) {
                    lVar4 = FUN_18046c600(0);
                    if (lVar4 == null) break;
                    CraftUIController.ShowItemParticle
                              (this,*(uint64 *)(lVar4 + 144),lVar2,0,0x3f800000,0xffffffff,0);
                    FUN_180d837c0(this);
                  }
                  lVar2 = this.craftResultList;
                  local_res8[0] = local_res8[0] + 1;
                  if (lVar2 == null) break;
                }
              }
            }
          }
        }
    }

    // Token : 0x6001329
    // RVA   : 0xA4C540   Offset: 0xA4AD40   Length: 0x383
    public void CraftResultChoosen(int id)
    {
        long lVar1;
        long lVar2;
        ulong uVar3;
        int[] local_res10 = new int[2];
        CraftUIController.PlayCraftSound(this,0);
        lVar2 = this.craftResultList;
        lVar1 = **(int64 **)(DAT_181d6c960 + 184);
        if (lVar2 != null) {
          if (lVar2.Count <= id) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          if (lVar1 != null) {
            PlotController.CraftResultChoosen
                      (lVar1,*(uint64 *)
                              (lVar2._items + 32 + (int64)(int)id * 8),0);
            if (this.craftResultList != null) {
              FUN_180f56130(this.craftResultList,DAT_181d69370);
              if (this.creaftUIPanel != null) {
                lVar2 = GameObject.get_transform(this.creaftUIPanel,0);
                if (lVar2 != null) {
                  lVar2 = Transform.Find(lVar2,"CraftResult",0);
                  if (lVar2 != null) {
                    lVar2 = Component.get_gameObject(lVar2,0);
                    if (lVar2 != null) {
                      GameObject.SetActive(lVar2,0,0);
                      if (this.creaftUIPanel != null) {
                        lVar2 = GameObject.get_transform(this.creaftUIPanel,0);
                        if (lVar2 != null) {
                          lVar2 = Transform.Find(lVar2,"CraftResult",0);
                          if (lVar2 != null) {
                            lVar2 = Transform.Find(lVar2,"Material",0);
                            if (lVar2 != null) {
                              uVar3 = Component.get_gameObject(lVar2,0);
                              GlobalData.DeleteAllChild(uVar3,0);
                              if (this.creaftUIPanel != null) {
                                lVar2 = GameObject.get_transform(this.creaftUIPanel,0);
                                if (lVar2 != null) {
                                  lVar2 = Transform.Find(lVar2,"CraftResult",0);
                                  if (lVar2 != null) {
                                    lVar2 = Transform.Find(lVar2,"SubMaterial",0);
                                    if (lVar2 != null) {
                                      uVar3 = Component.get_gameObject(lVar2,0);
                                      GlobalData.DeleteAllChild(uVar3,0);
                                      local_res10[0] = 0;
                                      while (this.creaftUIPanel != null) {
                                        lVar2 = GameObject.get_transform(this.creaftUIPanel,0)
                                        ;
                                        if (lVar2 == null) break;
                                        lVar2 = Transform.Find(lVar2,"CraftResult",0);
                                        uVar3 = Int32.ToString(local_res10,0);
                                        if (lVar2 == null) break;
                                        lVar2 = Transform.Find(lVar2,uVar3,0);
                                        if (lVar2 == null) break;
                                        lVar2 = Transform.Find(lVar2,"ItemIcon",0);
                                        if (lVar2 == null) break;
                                        uVar3 = Component.get_gameObject(lVar2);
                                        GlobalData.DeleteAllChild(uVar3);
                                        local_res10[0] = local_res10[0] + 1;
                                        if (2 < local_res10[0]) {
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

    // Token : 0x600132A
    // RVA   : 0xA4FDE0   Offset: 0xA4E5E0   Length: 0xAC
    public IEnumerator ShowItemParticle(GameObject targetParticle, GameObject targetItemIcon, float delayTime, float scale, int rareLv)
    {
        int64 CraftUIController.ShowItemParticle
                         (uint64 this,uint64 targetParticle,uint64 targetItemIcon,uint32 delayTime,
                         uint32 scale,uint32 rareLv)
        {
        int64 lVar1;
        var lVar1 = new WarpText_d__8(0,0);
        if (lVar1 != null) {
          *(uint64 *)(lVar1 + 48) = targetParticle;
          *(uint64 *)(lVar1 + 40) = targetItemIcon;
          *(uint32 *)(lVar1 + 60) = rareLv;
          *(uint32 *)(lVar1 + 32) = delayTime;
          *(uint32 *)(lVar1 + 56) = scale;
          return lVar1;
        }
    }

    // Token : 0x600132B
    // RVA   : 0xA4E440   Offset: 0xA4CC40   Length: 0x7E
    public IEnumerator PlayItemSound(GameObject targetItemIcon, float delayTime)
    {
        long lVar1;
        lVar1 = new WarpText_d__8(0,0);
        if (lVar1 != null) {
          *(uint64 *)(lVar1 + 40) = targetItemIcon;
          *(uint32 *)(lVar1 + 32) = delayTime;
          return lVar1;
        }
    }

    // Token : 0x600132C
    // RVA   : 0xA4F360   Offset: 0xA4DB60   Length: 0x32D
    public void SetNameEndEdit()
    {
        long lVar1;
        long lVar2;
        ulong uVar5;
        ushort uVar6;
        ushort uVar7;
        if (**(int **)(DAT_181d4ef00 + 184) == 1) {
          lVar1 = new c.DisplayClass9_0(0);
          if (this.setNameInput != null) {
            lVar2 = GameObject.GetComponent(this.setNameInput,DAT_181d9ffe8);
            if ((lVar2 != null) && (lVar1 != null)) {
              *(uint64 *)(lVar1 + 16) = *(uint64 *)(lVar2 + 0x170);
              *(uint8 *)(lVar1 + 24) = *(uint8 *)(*(int64 *)(DAT_181d4ef00 + 184) + 128);
              plVar3 = (int64 *)rail_api.RailFactory(0);
              if (plVar3 != (int64 *)0) {
                lVar2 = *plVar3;
                uVar7 = 0;
                if (*(uint16 *)(lVar2 + 0x12a) != 0) {
                  uVar6 = uVar7;
                  do {
                    if (*(int64 *)(*(int64 *)(lVar2 + 176) + (uint64)uVar6 * 16) ==
                        DAT_181d56638) {
                      puVar4 = (uint64 *)
                               ((int64)
                                *(int *)(*(int64 *)(lVar2 + 176) + 8 + (uint64)uVar6 * 16) * 16
                                + 0x248 + lVar2);
                      goto LAB_180a4f52c;
                    }
                    uVar6 = uVar6 + 1;
                  } while (uVar6 < *(uint16 *)(lVar2 + 0x12a));
                }
                puVar4 = (uint64 *)FUN_1800914f0(plVar3,DAT_181d56638,17);
        LAB_180a4f52c:
                plVar3 = (int64 *)(*(code *)*puVar4)(plVar3,puVar4[1]);
                uVar5 = "";
                if (plVar3 != (int64 *)0) {
                  lVar2 = *plVar3;
                  if (*(uint16 *)(lVar2 + 0x12a) != 0) {
                    do {
                      if (*(int64 *)(*(int64 *)(lVar2 + 176) + (uint64)uVar7 * 16) ==
                          DAT_181d57ca8) {
                        puVar4 = (uint64 *)
                                 ((int64)
                                  *(int *)(*(int64 *)(lVar2 + 176) + 8 + (uint64)uVar7 * 16) *
                                  16 + 0x1f8 + lVar2);
                        goto LAB_180a4f597;
                      }
                      uVar7 = uVar7 + 1;
                    } while (uVar7 < *(uint16 *)(lVar2 + 0x12a));
                  }
                  puVar4 = (uint64 *)FUN_1800914f0(plVar3,DAT_181d57ca8,12);
        LAB_180a4f597:
                          // WARNING: Could not recover jumptable at 0x000180a4f5b8. Too many branches
                          // WARNING: Treating indirect jump as call
                  (*(code *)*puVar4)(plVar3,lVar1,uVar5,puVar4[1]);
                  return;
                }
              }
            }
          }
        }
        else {
          lVar1 = CISFilterWordsSDK.get_Instance(0);
          if (this.setNameInput != null) {
            lVar2 = GameObject.GetComponent(this.setNameInput,DAT_181d9ffe8);
            if ((lVar2 != null) && (lVar1 != null)) {
              uVar5 = CISFilterWordsSDK.FilterReplaceWithChar
                                (lVar1,*(uint64 *)(lVar2 + 0x170),42,0);
              this.craftSettingName = uVar5;
              if (this.setNameInput != null) {
                lVar1 = GameObject.GetComponent(this.setNameInput,DAT_181d9ffe8);
                if (lVar1 != null) {
                  InputField.set_text(lVar1,this.craftSettingName,0);
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x600132D
    // RVA   : 0xA4D500   Offset: 0xA4BD00   Length: 0xE1
    public void OnSetCraftNameFliterResult(RAILEventID id, EventBase data)
    {
        long lVar1;
        if (data != (int64 *)0) {
          if (((int)data[2] != 0) || (id != 0x1f45)) {
            return;
          }
          this.craftSettingName = data[8];
          if ((this.setNameInput != null) &&
             (lVar1 = GameObject.GetComponent(this.setNameInput,DAT_181d9ffe8)) != null)
          {
            InputField.set_text(lVar1,this.craftSettingName,0);
            return;
          }
        }
    }

    // Token : 0x600132E
    // RVA   : 0xA4FFF0   Offset: 0xA4E7F0   Length: 0xB
    public void /*ctor*/()
    {
        void FUN_180a4fff0(int64 this)
        {
        this.forceCraft = 1;
        FUN_18044ef50(this,0);
    }

}
