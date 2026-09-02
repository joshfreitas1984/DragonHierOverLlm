// ============================================================
// Type  : EnhanceUIController
// Token : 0x2000263
// ============================================================

public class EnhanceUIController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40012C7
    public CraftType enhanceType;

    // Token: 0x40012C8
    public GameObject enhanceUIPanel;

    // Token: 0x40012C9
    public AreaBuildingData targetBuilding;

    // Token: 0x40012CA
    public bool useMoney;

    // Token: 0x40012CB
    public GameObject enhanceTargetClearButton;

    // Token: 0x40012CC
    public GameObject enhanceMaterialClearButton;

    // Token: 0x40012CD
    public GameObject enhanceTargetItemIcon;

    // Token: 0x40012CE
    public GameObject enhanceMaterialItemIcon;

    // Token: 0x40012CF
    private static EnhanceUIController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600139C
    // RVA   : 0x934640   Offset: 0x932E40   Length: 0x36
    public static EnhanceUIController get_Instance()
    {
        return **(uint64 **)(DAT_181d9e5d0 + 184);
    }

    // Token : 0x600139D
    // RVA   : 0x931240   Offset: 0x92FA40   Length: 0xD7
    private void Awake()
    {
        bool cVar2;
        ulong uVar3;
        uVar3 = **(uint64 **)(DAT_181d9e5d0 + 184);
        cVar2 = Object.op_Equality(uVar3,0,0);
        if (!cVar2) {
          uVar3 = Component.get_gameObject(this,0);
          Object.Destroy(uVar3,0);
          return;
        }
        puVar1 = *(uint64 **)(DAT_181d9e5d0 + 184);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x600139E
    // RVA   : 0x9339E0   Offset: 0x9321E0   Length: 0xC5C
    private void Update()
    {
        var pStatics = *(int64*)(DAT_181d4ef00 + 184);
        bool cVar1;
        byte uVar2;
        int iVar3;
        int iVar4;
        long lVar5;
        ulong uVar6;
        long lVar8;
        ulong uVar9;
        ulong uVar10;
        ulong uVar11;
        uint uVar12;
        float fVar13;
        uint[] local_res8 = new uint[2];
        int[] local_res18 = new int[4];
        uVar6 = this.enhanceTargetItemIcon;
        cVar1 = Object.op_Equality(uVar6,0,0);
        if (!cVar1) {
          iVar3 = EnhanceUIController.GetNowEnhanceLv(this,0);
          lVar5 = this.enhanceUIPanel;
          if (iVar3 < 10) {
            if (((lVar5 == null) || (lVar5 = GameObject.get_transform(lVar5,0)) == null) ||
               (lVar5 = Transform.Find(lVar5,"EnhanceCost",0)) == null) throw; // [null/range check failed]
            uVar6 = Component.GetComponent(lVar5,DAT_181d6d8c0);
            plVar7 = (int64 *)FUN_1800d60b0(DAT_181d7f180,7);
            if (this.targetBuilding == null) throw; // [null/range check failed]
            iVar3 = this.targetBuilding.lv;
            iVar4 = EnhanceUIController.EnhanceNeedBuildingLv(this,0);
            uVar11 = "提升强化等级至+{6}\n{0}需要建筑等级 {1}级</color>\n{2}需要{5}技能 {3}</color>\n{4}";
            if (iVar3 < iVar4) {
              lVar5 = *(int64 *)(pStatics + 0x2c8);
            }
            else {
              lVar5 = *(int64 *)(pStatics + 0x260);
            }
            if (plVar7 == (int64 *)0) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            if ((lVar5 != null) &&
               (lVar8 = il2cpp_internal(lVar5,*(uint64 *)(*plVar7 + 64))) == null) {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar6,0);
            }
            if ((int)plVar7[3] == 0) {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar6,0);
            }
            plVar7[4] = lVar5;
            il2cpp_internal(plVar7 + 4,lVar5);
            local_res8[0] = EnhanceUIController.EnhanceNeedBuildingLv(this,0);
            lVar5 = il2cpp_value_box(DAT_181d5b2f8,local_res8);
            if ((lVar5 != null) &&
               (lVar8 = il2cpp_internal(lVar5,*(uint64 *)(*plVar7 + 64))) == null) {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar6,0);
            }
            if (*(uint32 *)(plVar7 + 3) < 2) {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar6,0);
            }
            plVar7[5] = lVar5;
            il2cpp_internal(plVar7 + 5,lVar5);
            fVar13 = (float)EnhanceUIController.GetPlayerTargetSkill(this,0);
            iVar3 = EnhanceUIController.EnhanceNeedSkillLv(this,0);
            if (fVar13 < (float)iVar3) {
              lVar5 = *(int64 *)(pStatics + 0x2c8);
            }
            else {
              lVar5 = *(int64 *)(pStatics + 0x260);
            }
            if ((lVar5 != null) &&
               (lVar8 = il2cpp_internal(lVar5,*(uint64 *)(*plVar7 + 64))) == null) {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar6,0);
            }
            if (*(uint32 *)(plVar7 + 3) < 3) {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar6,0);
            }
            plVar7[6] = lVar5;
            il2cpp_internal(plVar7 + 6,lVar5);
            local_res8[0] = EnhanceUIController.EnhanceNeedSkillLv(this,0);
            lVar5 = il2cpp_value_box(DAT_181d5b2f8,local_res8);
            if ((lVar5 != null) &&
               (lVar8 = il2cpp_internal(lVar5,*(uint64 *)(*plVar7 + 64))) == null) {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar6,0);
            }
            if (*(uint32 *)(plVar7 + 3) < 4) {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar6,0);
            }
            plVar7[7] = lVar5;
            il2cpp_internal(plVar7 + 7,lVar5);
            if (!this.useMoney) {
              uVar10 = EnhanceUIController.GetEnhanceResourceCost(this,0);
              lVar5 = GlobalData.GetResourceDescribe(uVar10,0);
            }
            else {
              lVar5 = *(int64 *)(pStatics + 0x430);
              if (lVar5 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              if (*(int *)(lVar5 + 24) == 0) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              uVar10 = *(uint64 *)(*(int64 *)(lVar5 + 16) + 32);
              local_res8[0] = EnhanceUIController.GetEnhanceResourceCostNum(this,0);
              uVar9 = il2cpp_value_box(DAT_181d7d0b8,local_res8);
              uVar10 = String.Format("{0}-{1}",uVar10,uVar9,0);
              uVar2 = EnhanceUIController.HaveResource(this,0);
              lVar5 = GlobalData.GenerateChangeColorText(uVar10,uVar2,0);
            }
            if ((lVar5 != null) &&
               (lVar8 = il2cpp_internal(lVar5,*(uint64 *)(*plVar7 + 64))) == null) {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar6,0);
            }
            if (*(uint32 *)(plVar7 + 3) < 5) {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar6,0);
            }
            plVar7[8] = lVar5;
            il2cpp_internal(plVar7 + 8,lVar5);
            uVar12 = 0;
            iVar3 = this.enhanceType;
            lVar5 = *(int64 *)(pStatics + 0x4a8);
            if (iVar3 == 0) {
              uVar12 = 6;
            }
            else if (iVar3 == 1) {
              uVar12 = 7;
            }
            else if (iVar3 == 2) {
              uVar12 = 8;
            }
            if (lVar5 == null) {
        LAB_180934631:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            if (*(uint32 *)(lVar5 + 24) <= uVar12) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar5 = *(int64 *)(*(int64 *)(lVar5 + 16) + 32 + (uint64)uVar12 * 8);
            if ((lVar5 != null) &&
               (lVar8 = il2cpp_internal(lVar5,*(uint64 *)(*plVar7 + 64))) == null) {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar6,0);
            }
            if (*(uint32 *)(plVar7 + 3) < 6) {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar6,0);
            }
            plVar7[9] = lVar5;
            il2cpp_internal(plVar7 + 9,lVar5);
            local_res18[0] = EnhanceUIController.GetNowEnhanceLv(this,0);
            local_res18[0] = local_res18[0] + 1;
            lVar5 = il2cpp_value_box(DAT_181d5b2f8,local_res18);
            if ((lVar5 != null) &&
               (lVar8 = il2cpp_internal(lVar5,*(uint64 *)(*plVar7 + 64))) == null) {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar6,0);
            }
            if (*(uint32 *)(plVar7 + 3) < 7) {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar6,0);
            }
            plVar7[10] = lVar5;
            il2cpp_internal(plVar7 + 10,lVar5);
            uVar11 = String.Format(uVar11,plVar7,0);
            LTLocalization.SetText(uVar6,uVar11,0);
            if (((this.enhanceUIPanel == null) ||
                (lVar5 = GameObject.get_transform(this.enhanceUIPanel,0)) == null) ||
               (lVar5 = Transform.Find(lVar5,"EnhanceExtraAdd",0)) == null) goto LAB_180934631;
            uVar11 = Component.GetComponent(lVar5,DAT_181d6d8c0);
            uVar6 = this.enhanceTargetItemIcon;
            cVar1 = Object.op_Equality(uVar6,0,0);
            uVar6 = "";
            if (!cVar1) {
              uVar6 = this.enhanceMaterialItemIcon;
              cVar1 = Object.op_Equality(uVar6,0,0);
              uVar6 = "";
              if (!cVar1) {
                uVar6 = EnhanceUIController.GetEnhanceExtraAdd(this,0);
                uVar6 = String.Concat("强化特性\n",uVar6,0);
              }
            }
            LTLocalization.SetText(uVar11,uVar6,0);
            if (((this.enhanceUIPanel == null) ||
                (lVar5 = GameObject.get_transform(this.enhanceUIPanel,0)) == null) ||
               (lVar5 = Transform.Find(lVar5,"CostTime",0)) == null) goto LAB_18093462b;
            uVar6 = Component.GetComponent(lVar5,DAT_181d6d8c0);
            local_res8[0] = EnhanceUIController.EnhanceNeedTime(this,0);
            uVar11 = il2cpp_value_box(DAT_181d5b2f8,local_res8);
            uVar11 = String.Format("消耗时间：{0}天",uVar11,0);
            LTLocalization.SetText(uVar6,uVar11,0);
            if (((this.enhanceUIPanel == null) ||
                (lVar5 = GameObject.get_transform(this.enhanceUIPanel,0)) == null) ||
               (lVar5 = Transform.Find(lVar5,"EnhanceButton",0)) == null) goto LAB_18093462b;
            lVar5 = Component.GetComponent(lVar5,DAT_181d6af40);
            if (this.targetBuilding == null) goto LAB_18093462b;
            iVar3 = this.targetBuilding.lv;
            iVar4 = EnhanceUIController.EnhanceNeedBuildingLv(this,0);
            if (iVar3 < iVar4) {
        LAB_180934269:
              uVar2 = 0;
            }
            else {
              fVar13 = (float)EnhanceUIController.GetPlayerTargetSkill(this,0);
              iVar3 = EnhanceUIController.EnhanceNeedSkillLv(this,0);
              if ((fVar13 < (float)iVar3) ||
                 (cVar1 = EnhanceUIController.HaveResource(this,0), !cVar1))
              goto LAB_180934269;
              uVar6 = this.enhanceMaterialItemIcon;
              uVar2 = Object.op_Inequality(uVar6,0,0);
            }
            if (lVar5 != null) {
              Selectable.set_interactable(lVar5,uVar2,0);
              return;
            }
        LAB_18093462b:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          if (((lVar5 == null) || (lVar5 = GameObject.get_transform(lVar5,0)) == null) ||
             (lVar5 = Transform.Find(lVar5,"EnhanceCost",0)) == null) throw; // [null/range check failed]
          uVar6 = Component.GetComponent(lVar5,DAT_181d6d8c0);
          lVar5 = *(int64 *)(pStatics + 0x578);
          uVar11 = *(uint64 *)(pStatics + 0x2c8);
          if (lVar5 == null) throw; // [null/range check failed]
          uVar12 = this.enhanceType;
          if (*(uint32 *)(lVar5 + 24) <= uVar12) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          uVar11 = String.Format("{0}已{1}至满级</color>",uVar11,
                                  *(uint64 *)
                                   (*(int64 *)(lVar5 + 16) + 32 + (int64)(int)uVar12 * 8),0);
          LTLocalization.SetText(uVar6,uVar11,0);
          if (((this.enhanceUIPanel == null) ||
              (lVar5 = GameObject.get_transform(this.enhanceUIPanel,0)) == null) ||
             (lVar5 = Transform.Find(lVar5,"CostTime",0)) == null) throw; // [null/range check failed]
          uVar6 = Component.GetComponent(lVar5,DAT_181d6d8c0);
          LTLocalization.SetText(uVar6,"",0);
          if (this.enhanceUIPanel == null) throw; // [null/range check failed]
          lVar5 = GameObject.get_transform(this.enhanceUIPanel,0);
          uVar6 = "EnhanceExtraAdd";
        }
        else {
          if (((this.enhanceUIPanel == null) ||
              (lVar5 = GameObject.get_transform(this.enhanceUIPanel,0)) == null) ||
             (lVar5 = Transform.Find(lVar5,"EnhanceCost",0)) == null) throw; // [null/range check failed]
          uVar6 = Component.GetComponent(lVar5,DAT_181d6d8c0);
          LTLocalization.SetText(uVar6,"",0);
          if (((this.enhanceUIPanel == null) ||
              (lVar5 = GameObject.get_transform(this.enhanceUIPanel,0)) == null) ||
             (lVar5 = Transform.Find(lVar5,"EnhanceExtraAdd",0)) == null) throw; // [null/range check failed]
          uVar6 = Component.GetComponent(lVar5,DAT_181d6d8c0);
          LTLocalization.SetText(uVar6,"",0);
          if (this.enhanceUIPanel == null) throw; // [null/range check failed]
          lVar5 = GameObject.get_transform(this.enhanceUIPanel,0);
          uVar6 = "CostTime";
        }
        if ((lVar5 != null) && (lVar5 = Transform.Find(lVar5,uVar6,0)) != null) {
          uVar6 = Component.GetComponent(lVar5,DAT_181d6d8c0);
          LTLocalization.SetText(uVar6,"",0);
          if ((this.enhanceUIPanel != null) &&
             (((lVar5 = GameObject.get_transform(this.enhanceUIPanel,0), lVar5 != null &&
               (lVar5 = Transform.Find(lVar5,"EnhanceButton",0)) != null) &&
              (lVar5 = Component.GetComponent(lVar5,DAT_181d6af40)) != null))) {
            Selectable.set_interactable(lVar5,0,0);
            return;
          }
        }
    }

    // Token : 0x600139F
    // RVA   : 0x933670   Offset: 0x931E70   Length: 0x30
    public void HideEnhanceUI()
    {
        if (this.enhanceUIPanel != null) {
          GameObject.SetActive(this.enhanceUIPanel,0,0);
          EnhanceUIController.ClearEnhanceTarget(this,0);
          return;
        }
    }

    // Token : 0x60013A0
    // RVA   : 0x9336B0   Offset: 0x931EB0   Length: 0x325
    public void OpenEnhanceUI(CraftType _enhanceType, AreaBuildingData _targetBuilding, bool _useMoney)
    {
        void EnhanceUIController.OpenEnhanceUI
                     (int64 this,int _enhanceType,uint64 _targetBuilding,uint8 _useMoney)
        {
        uint32 uVar1;
        char cVar2;
        int64 *plVar3;
        int64 lVar4;
        uint64 uVar5;
        int64 *plVar6;
        int local_res10 [2];
        uVar5 = "Sound/SoundEffect/Armor";
        if (((_enhanceType == null) || (uVar5 = "Sound/SoundEffect/Med", _enhanceType == 1)) ||
           (uVar5 = "Sound/SoundEffect/Food", _enhanceType == 2)) {
          plVar3 = (int64 *)Resources.Load(uVar5,0);
          plVar6 = (int64 *)0;
          if ((plVar3 != (int64 *)0) && (*plVar3 == DAT_181d8a228)) {
            plVar6 = plVar3;
          }
          NGUITools.PlaySound(plVar6,0);
        }
        if (this.enhanceUIPanel != null) {
          GameObject.SetActive(this.enhanceUIPanel,1,0);
          this.targetBuilding = _targetBuilding;
          this.enhanceType = _enhanceType;
          this.useMoney = _useMoney;
          if (((this.enhanceUIPanel != null) &&
              (lVar4 = GameObject.get_transform(this.enhanceUIPanel,0)) != null) &&
             (lVar4 = Transform.Find(lVar4,"Title",0)) != null) {
            uVar5 = Component.GetComponent(lVar4,DAT_181d6d8c0);
            lVar4 = *(int64 *)(*(int64 *)(DAT_181d4ef00 + 184) + 0x578);
            if (lVar4 != null) {
              uVar1 = this.enhanceType;
              if (*(uint32 *)(lVar4 + 24) <= uVar1) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              LTLocalization.SetText
                        (uVar5,*(uint64 *)
                                (*(int64 *)(lVar4 + 16) + 32 + (int64)(int)uVar1 * 8),0);
              local_res10[0] = 0;
              do {
                if ((this.enhanceUIPanel == null) ||
                   (lVar4 = GameObject.get_transform(this.enhanceUIPanel,0)) == null)
                break;
                lVar4 = Transform.Find(lVar4,"Decoration",0);
                uVar5 = Int32.ToString(local_res10,0);
                if ((lVar4 == null) ||
                   ((lVar4 = Transform.Find(lVar4,uVar5,0), lVar4 == null ||
                    (lVar4 = Component.get_gameObject(lVar4,0)) == null))) break;
                cVar2 = GameObject.get_activeSelf(lVar4,0);
                if ((bool)cVar2 != (this.enhanceType == local_res10[0])) {
                  if ((this.enhanceUIPanel == null) ||
                     (lVar4 = GameObject.get_transform(this.enhanceUIPanel,0)) == null)
                  break;
                  lVar4 = Transform.Find(lVar4,"Decoration",0);
                  uVar5 = Int32.ToString(local_res10,0);
                  if ((lVar4 == null) || (lVar4 = Transform.Find(lVar4,uVar5,0)) == null) break;
                  lVar4 = Component.get_gameObject(lVar4,0);
                  if (lVar4 == null) break;
                  GameObject.SetActive(lVar4,this.enhanceType == local_res10[0]);
                }
                local_res10[0] = local_res10[0] + 1;
                if (2 < local_res10[0]) {
                  return;
                }
              } while( true );
            }
          }
        }
    }

    // Token : 0x60013A1
    // RVA   : 0x932570   Offset: 0x930D70   Length: 0x35D
    public void EnhanceTargetButtonClicked()
    {
        var pStatics = *(int64*)(DAT_181d92370 + 184);
        int iVar1;
        bool cVar2;
        long lVar3;
        ulong uVar4;
        long lVar5;
        uint[] local_res8 = new uint[2];
        uint[] local_res18 = new uint[4];
        uVar4 = this.enhanceTargetItemIcon;
        cVar2 = Object.op_Inequality(uVar4,0,0);
        if (!cVar2) {
          iVar1 = this.enhanceType;
          if (iVar1 == 0) {
            lVar5 = *pStatics;
            lVar3 = il2cpp_internal(DAT_181d701b0);
            FUN_180f58a90(lVar3,DAT_181d6dfe8);
            local_res8[0] = 0;
            uVar4 = il2cpp_value_box(DAT_181d5b2f8,local_res8);
            if (lVar3 == null) {
        LAB_1809328bc:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            FUN_181827900(lVar3,uVar4,DAT_181d6e0e8);
            local_res18[0] = 0;
            uVar4 = il2cpp_value_box(DAT_181d5b2f8,local_res18);
            FUN_181827900(lVar3,uVar4,DAT_181d6e0e8);
            uVar4 = Component.get_gameObject(this,0);
            if (lVar5 == null) goto LAB_1809328bc;
          }
          else if (iVar1 == 1) {
            lVar5 = *pStatics;
            lVar3 = il2cpp_internal(DAT_181d701b0);
            FUN_180f58a90(lVar3,DAT_181d6dfe8);
            local_res8[0] = 0;
            uVar4 = il2cpp_value_box(DAT_181d5b2f8,local_res8);
            if (lVar3 == null) {
        LAB_1809328c8:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            FUN_181827900(lVar3,uVar4,DAT_181d6e0e8);
            local_res18[0] = 1;
            uVar4 = il2cpp_value_box(DAT_181d5b2f8,local_res18);
            FUN_181827900(lVar3,uVar4,DAT_181d6e0e8);
            uVar4 = Component.get_gameObject(this,0);
            if (lVar5 == null) goto LAB_1809328c8;
          }
          else {
            if (iVar1 != 2) {
              return;
            }
            lVar5 = *pStatics;
            lVar3 = il2cpp_internal(DAT_181d701b0);
            FUN_180f58a90(lVar3,DAT_181d6dfe8);
            local_res8[0] = 0;
            uVar4 = il2cpp_value_box(DAT_181d5b2f8,local_res8);
            if (lVar3 == null) {
        LAB_1809328c2:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            FUN_181827900(lVar3,uVar4,DAT_181d6e0e8);
            local_res18[0] = 2;
            uVar4 = il2cpp_value_box(DAT_181d5b2f8,local_res18);
            FUN_181827900(lVar3,uVar4,DAT_181d6e0e8);
            uVar4 = Component.get_gameObject(this,0);
            if (lVar5 == null) goto LAB_1809328c2;
          }
          ChooseController.ShowChoosePanel(lVar5,1,lVar3,uVar4,"EnhanceTargetChoosen",0,0,0,0,0);
        }
    }

    // Token : 0x60013A2
    // RVA   : 0x9328D0   Offset: 0x9310D0   Length: 0x260
    public void EnhanceTargetChoosen()
    {
        var pStatics_2370 = *(int64*)(DAT_181d92370 + 184);
        var pStatics_e188 = *(int64*)(DAT_181d4e188 + 184);
        ulong uVar1;
        long lVar2;
        ulong uVar3;
        long lVar4;
        if (this.enhanceUIPanel != null) {
          lVar2 = GameObject.get_transform(this.enhanceUIPanel,0);
          if (lVar2 != null) {
            lVar2 = Transform.Find(lVar2,"EnhanceTarget",0);
            if (lVar2 != null) {
              uVar3 = Component.get_gameObject(lVar2,0);
              if (*pStatics_e188 != 0) {
                uVar1 = *(uint64 *)(*pStatics_e188 + 160);
                uVar3 = GlobalData.AddChild(uVar3,uVar1,0);
                this.enhanceTargetItemIcon = uVar3;
                if (this.enhanceTargetItemIcon != null) {
                  lVar2 = GameObject.GetComponent(this.enhanceTargetItemIcon,DAT_181da0070);
                  if ((*pStatics_2370 != 0) &&
                     (lVar4 = *(int64 *)(*pStatics_2370 + 72)) != null) {
                    lVar4 = GameObject.GetComponent(lVar4,DAT_181da0070);
                    if ((lVar4 != null) && (lVar2 != null)) {
                      *(uint64 *)(lVar2 + 32) = *(uint64 *)(lVar4 + 32);
                      if (this.enhanceTargetItemIcon != null) {
                        lVar2 = GameObject.GetComponent(this.enhanceTargetItemIcon,DAT_181da0070);
                        if (lVar2 != null) {
                          *(uint32 *)(lVar2 + 40) = 1;
                          if (this.enhanceTargetItemIcon != null) {
                            lVar2 = GameObject.GetComponent(this.enhanceTargetItemIcon,DAT_181da0070);
                            if (lVar2 != null) {
                              ItemIconController.AutoSetName(lVar2,1,0);
                              if (this.enhanceTargetClearButton != null) {
                                GameObject.SetActive(this.enhanceTargetClearButton,1,0);
                                if (this.enhanceUIPanel != null) {
                                  lVar2 = GameObject.get_transform(this.enhanceUIPanel,0);
                                  if (lVar2 != null) {
                                    uVar3 = Transform.Find(lVar2,"TargetLine",0);
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

    // Token : 0x60013A3
    // RVA   : 0x9314D0   Offset: 0x92FCD0   Length: 0x1A0
    public void ClearEnhanceTarget()
    {
        long lVar1;
        ulong uVar2;
        uVar2 = this.enhanceTargetItemIcon;
        Object.Destroy(uVar2,0);
        this.enhanceTargetItemIcon = 0;
        if (this.enhanceTargetClearButton != null) {
          GameObject.SetActive(this.enhanceTargetClearButton,0,0);
          uVar2 = this.enhanceMaterialItemIcon;
          Object.Destroy(uVar2,0);
          this.enhanceMaterialItemIcon = 0;
          if (this.enhanceMaterialClearButton != null) {
            GameObject.SetActive(this.enhanceMaterialClearButton,0,0);
            if (this.enhanceUIPanel != null) {
              lVar1 = GameObject.get_transform(this.enhanceUIPanel,0);
              if (lVar1 != null) {
                uVar2 = Transform.Find(lVar1,"MaterialLine",0);
                ShortcutExtensions.DOScaleX(uVar2,0,0x3e800000,0);
                if (this.enhanceUIPanel != null) {
                  lVar1 = GameObject.get_transform(this.enhanceUIPanel,0);
                  if (lVar1 != null) {
                    uVar2 = Transform.Find(lVar1,"TargetLine",0);
                    ShortcutExtensions.DOScaleX(uVar2,0,0x3e800000,0);
                    return;
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x60013A4
    // RVA   : 0x931A60   Offset: 0x930260   Length: 0x4EB
    public void EnhanceMaterialButtonClicked()
    {
        int iVar1;
        bool cVar2;
        long lVar3;
        long lVar4;
        ulong uVar5;
        long lVar6;
        uint[] local_res8 = new uint[2];
        uint[] local_res18 = new uint[2];
        uint[] local_res20 = new uint[2];
        uint uVar7;
        uVar5 = this.enhanceMaterialItemIcon;
        cVar2 = Object.op_Inequality(uVar5,0,0);
        if (!cVar2) {
          uVar5 = this.enhanceTargetItemIcon;
          cVar2 = Object.op_Equality(uVar5,0,0);
          if (cVar2) {
            lVar3 = FUN_18046c0a0(0);
            if (lVar3 != null) {
              GameController.ShowTextOnMouse(lVar3,"需要先选择强化目标！",0);
              return;
            }
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          iVar1 = this.enhanceType;
          if (iVar1 == 0) {
            lVar3 = FUN_18046bd60(0);
            lVar4 = il2cpp_internal(DAT_181d701b0);
            FUN_180f58a90(lVar4,DAT_181d6dfe8);
            local_res8[0] = 0;
            uVar5 = il2cpp_value_box(DAT_181d5b2f8,local_res8);
            if (lVar4 == null) {
        LAB_180931f46:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            FUN_181827900(lVar4,uVar5,DAT_181d6e0e8);
            local_res18[0] = 5;
            uVar5 = il2cpp_value_box(DAT_181d5b2f8,local_res18);
            FUN_181827900(lVar4,uVar5,DAT_181d6e0e8);
            if (((this.enhanceTargetItemIcon == null) ||
                (lVar6 = GameObject.GetComponent(this.enhanceTargetItemIcon,DAT_181da0070), lVar6 == null
                )) || (*(int64 *)(lVar6 + 32) == 0)) goto LAB_180931f46;
            local_res20[0] = *(uint32 *)(*(int64 *)(lVar6 + 32) + 60);
            uVar5 = il2cpp_value_box(DAT_181d5b2f8,local_res20);
            FUN_181827900(lVar4,uVar5,DAT_181d6e0e8);
            uVar5 = Component.get_gameObject(this,0);
            if (lVar3 == null) goto LAB_180931f46;
            uVar7 = 3;
          }
          else if (iVar1 == 1) {
            lVar3 = FUN_18046bd60(0);
            lVar4 = il2cpp_internal(DAT_181d701b0);
            FUN_180f58a90(lVar4,DAT_181d6dfe8);
            local_res8[0] = 0;
            uVar5 = il2cpp_value_box(DAT_181d5b2f8,local_res8);
            if (lVar4 == null) {
        LAB_180931f40:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            FUN_181827900(lVar4,uVar5,DAT_181d6e0e8);
            local_res18[0] = 5;
            uVar5 = il2cpp_value_box(DAT_181d5b2f8,local_res18);
            FUN_181827900(lVar4,uVar5,DAT_181d6e0e8);
            if (((this.enhanceTargetItemIcon == null) ||
                (lVar6 = GameObject.GetComponent(this.enhanceTargetItemIcon,DAT_181da0070), lVar6 == null
                )) || (*(int64 *)(lVar6 + 32) == 0)) goto LAB_180931f40;
            local_res20[0] = *(uint32 *)(*(int64 *)(lVar6 + 32) + 60);
            uVar5 = il2cpp_value_box(DAT_181d5b2f8,local_res20);
            FUN_181827900(lVar4,uVar5,DAT_181d6e0e8);
            uVar5 = Component.get_gameObject(this,0);
            if (lVar3 == null) goto LAB_180931f40;
            uVar7 = 4;
          }
          else {
            if (iVar1 != 2) {
              return;
            }
            lVar3 = FUN_18046bd60(0);
            lVar4 = il2cpp_internal(DAT_181d701b0);
            FUN_180f58a90(lVar4,DAT_181d6dfe8);
            local_res8[0] = 0;
            uVar5 = il2cpp_value_box(DAT_181d5b2f8,local_res8);
            if (lVar4 == null) {
        LAB_180931f3a:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            FUN_181827900(lVar4,uVar5,DAT_181d6e0e8);
            local_res18[0] = 5;
            uVar5 = il2cpp_value_box(DAT_181d5b2f8,local_res18);
            FUN_181827900(lVar4,uVar5,DAT_181d6e0e8);
            if (((this.enhanceTargetItemIcon == null) ||
                (lVar6 = GameObject.GetComponent(this.enhanceTargetItemIcon,DAT_181da0070), lVar6 == null
                )) || (*(int64 *)(lVar6 + 32) == 0)) goto LAB_180931f3a;
            local_res20[0] = *(uint32 *)(*(int64 *)(lVar6 + 32) + 60);
            uVar5 = il2cpp_value_box(DAT_181d5b2f8,local_res20);
            FUN_181827900(lVar4,uVar5,DAT_181d6e0e8);
            uVar5 = Component.get_gameObject(this,0);
            if (lVar3 == null) goto LAB_180931f3a;
            uVar7 = 5;
          }
          ChooseController.ShowChoosePanel(lVar3,1,lVar4,uVar5,"EnhanceMaterialChoosen",0,uVar7,0,0,0);
        }
    }

    // Token : 0x60013A5
    // RVA   : 0x931F50   Offset: 0x930750   Length: 0x260
    public void EnhanceMaterialChoosen()
    {
        var pStatics_2370 = *(int64*)(DAT_181d92370 + 184);
        var pStatics_e188 = *(int64*)(DAT_181d4e188 + 184);
        ulong uVar1;
        long lVar2;
        ulong uVar3;
        long lVar4;
        if (this.enhanceUIPanel != null) {
          lVar2 = GameObject.get_transform(this.enhanceUIPanel,0);
          if (lVar2 != null) {
            lVar2 = Transform.Find(lVar2,"EnhanceMaterial",0);
            if (lVar2 != null) {
              uVar3 = Component.get_gameObject(lVar2,0);
              if (*pStatics_e188 != 0) {
                uVar1 = *(uint64 *)(*pStatics_e188 + 160);
                uVar3 = GlobalData.AddChild(uVar3,uVar1,0);
                this.enhanceMaterialItemIcon = uVar3;
                if (this.enhanceMaterialItemIcon != null) {
                  lVar2 = GameObject.GetComponent(this.enhanceMaterialItemIcon,DAT_181da0070);
                  if ((*pStatics_2370 != 0) &&
                     (lVar4 = *(int64 *)(*pStatics_2370 + 72)) != null) {
                    lVar4 = GameObject.GetComponent(lVar4,DAT_181da0070);
                    if ((lVar4 != null) && (lVar2 != null)) {
                      *(uint64 *)(lVar2 + 32) = *(uint64 *)(lVar4 + 32);
                      if (this.enhanceMaterialItemIcon != null) {
                        lVar2 = GameObject.GetComponent(this.enhanceMaterialItemIcon,DAT_181da0070);
                        if (lVar2 != null) {
                          *(uint32 *)(lVar2 + 40) = 1;
                          if (this.enhanceMaterialItemIcon != null) {
                            lVar2 = GameObject.GetComponent(this.enhanceMaterialItemIcon,DAT_181da0070);
                            if (lVar2 != null) {
                              ItemIconController.AutoSetName(lVar2,1,0);
                              if (this.enhanceMaterialClearButton != null) {
                                GameObject.SetActive(this.enhanceMaterialClearButton,1,0);
                                if (this.enhanceUIPanel != null) {
                                  lVar2 = GameObject.get_transform(this.enhanceUIPanel,0);
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

    // Token : 0x60013A6
    // RVA   : 0x9313F0   Offset: 0x92FBF0   Length: 0xDD
    public void ClearEnhanceMaterial()
    {
        long lVar1;
        ulong uVar2;
        uVar2 = this.enhanceMaterialItemIcon;
        Object.Destroy(uVar2,0);
        this.enhanceMaterialItemIcon = 0;
        if (this.enhanceMaterialClearButton != null) {
          GameObject.SetActive(this.enhanceMaterialClearButton,0,0);
          if (this.enhanceUIPanel != null) {
            lVar1 = GameObject.get_transform(this.enhanceUIPanel,0);
            if (lVar1 != null) {
              uVar2 = Transform.Find(lVar1,"MaterialLine",0);
              ShortcutExtensions.DOScaleX(uVar2,0,0x3e800000,0);
              return;
            }
          }
        }
    }

    // Token : 0x60013A7
    // RVA   : 0x932EF0   Offset: 0x9316F0   Length: 0x218
    public float GetEnhanceResourceCostNum()
    {
        int iVar1;
        bool cVar2;
        long lVar3;
        iVar1 = this.enhanceType;
        if (iVar1 == 0) {
          if (((this.enhanceTargetItemIcon != null) &&
              (lVar3 = GameObject.GetComponent(this.enhanceTargetItemIcon,DAT_181da0070)) != null)
             && (*(int64 *)(lVar3 + 32) != 0)) {
            EnhanceUIController.GetNowEnhanceLv(this,0);
            return;
          }
        }
        else if (iVar1 == 1) {
          if (((this.enhanceTargetItemIcon != null) &&
              (lVar3 = GameObject.GetComponent(this.enhanceTargetItemIcon,DAT_181da0070)) != null)
             && (*(int64 *)(lVar3 + 32) != 0)) {
            EnhanceUIController.GetNowEnhanceLv(this,0);
            lVar3 = FUN_18046c0a0(0);
            if (((lVar3 != null) && (*(int64 *)(lVar3 + 32) != 0)) &&
               (lVar3 = WorldData.Player(*(int64 *)(lVar3 + 32),0)) != null) {
              cVar2 = HeroData.HaveForceFunction(lVar3,2);
              if (cVar2) {
                return;
              }
              return;
            }
          }
        }
        else {
          if (iVar1 != 2) {
            return;
          }
          if (((this.enhanceTargetItemIcon != null) &&
              (lVar3 = GameObject.GetComponent(this.enhanceTargetItemIcon,DAT_181da0070)) != null)
             && (*(int64 *)(lVar3 + 32) != 0)) {
            EnhanceUIController.GetNowEnhanceLv(this,0);
            return;
          }
        }
    }

    // Token : 0x60013A8
    // RVA   : 0x933110   Offset: 0x931910   Length: 0x189
    public List<ResourceData> GetEnhanceResourceCost()
    {
        int iVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        uint uVar5;
        lVar2 = il2cpp_internal(DAT_181d71cb0);
        FUN_180f58a90(lVar2,DAT_181d77dd8);
        iVar1 = this.enhanceType;
        if (iVar1 == 0) {
          uVar5 = EnhanceUIController.GetEnhanceResourceCostNum(this,0);
          uVar3 = new PlotChoiceRequirement(2,uVar5);
          if (lVar2 == null) goto LAB_180933294;
          FUN_181827900(lVar2,uVar3,DAT_181d77e58);
          uVar5 = EnhanceUIController.GetEnhanceResourceCostNum(this,0);
          uVar3 = new PlotChoiceRequirement(3,uVar5);
        }
        else {
          if (iVar1 == 1) {
            uVar5 = EnhanceUIController.GetEnhanceResourceCostNum(this,0);
            uVar3 = il2cpp_internal(DAT_181d774d0);
            uVar4 = 4;
          }
          else {
            if (iVar1 != 2) {
              return lVar2;
            }
            uVar5 = EnhanceUIController.GetEnhanceResourceCostNum(this,0);
            uVar3 = il2cpp_internal(DAT_181d774d0);
            uVar4 = 1;
          }
          PlotChoiceRequirement.ctor(uVar3,uVar4,uVar5,0);
          if (lVar2 == null) {
        LAB_180933294:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
        }
        FUN_181827900(lVar2,uVar3,DAT_181d77e58);
        return lVar2;
    }

    // Token : 0x60013A9
    // RVA   : 0x931680   Offset: 0x92FE80   Length: 0x3DB
    public void EnhanceButtonClicked()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        int iVar1;
        uint uVar2;
        long lVar3;
        uint uVar4;
        long lVar5;
        ulong uVar6;
        float fVar9;
        if (!this.useMoney) {
          if (((*pStatics == 0) ||
              (lVar5 = *(int64 *)(*pStatics + 32)) == null) ||
             (lVar5 = WorldData.Player(lVar5,0)) == null) throw; // [null/range check failed]
          lVar5 = HeroData.GetForce(lVar5,0,0);
          uVar6 = EnhanceUIController.GetEnhanceResourceCost(this,0);
          if (lVar5 == null) throw; // [null/range check failed]
          ForceData.CostResource(lVar5,uVar6,1,0);
        }
        else {
          if ((*pStatics == 0) ||
             (lVar5 = *(int64 *)(*pStatics + 32)) == null)
          throw; // [null/range check failed]
          lVar5 = WorldData.Player(lVar5,0);
          fVar9 = (float)EnhanceUIController.GetEnhanceResourceCostNum(this,0);
          if (lVar5 == null) throw; // [null/range check failed]
          HeroData.ChangeMoney(lVar5,-(int)fVar9,1,0);
        }
        iVar1 = this.enhanceType;
        uVar6 = "Sound/SoundEffect/SpeEffect/修理升级";
        if (((iVar1 == 0) || (uVar6 = "Sound/SoundEffect/CraftMed", iVar1 == 1)) || (uVar6 = "Sound/SoundEffect/CraftFood", iVar1 == 2))
        {
          plVar7 = (int64 *)Resources.Load(uVar6,0);
          plVar8 = (int64 *)0;
          if ((plVar7 != (int64 *)0) && (*plVar7 == DAT_181d8a228)) {
            plVar8 = plVar7;
          }
          NGUITools.PlaySound(plVar8,0);
        }
        lVar5 = *(int64 *)(*(int64 *)(DAT_181d90b30 + 184) + 8);
        lVar3 = *(int64 *)(*(int64 *)(DAT_181d4ef00 + 184) + 0x578);
        if (lVar3 != null) {
          uVar2 = this.enhanceType;
          if (*(uint32 *)(lVar3 + 24) <= uVar2) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          uVar6 = lVar3[uVar2];
          uVar4 = EnhanceUIController.EnhanceNeedTime(this,0);
          if (lVar5 != null) {
            WorkingUIController.StartWorking
                      (lVar5,uVar6,uVar4,"","","FinishEnhance","",0);
            return;
          }
        }
    }

    // Token : 0x60013AA
    // RVA   : 0x9321C0   Offset: 0x9309C0   Length: 0x175
    public int EnhanceNeedBuildingLv()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        int iVar1;
        bool cVar2;
        int iVar3;
        uint uVar4;
        long lVar5;
        float fVar6;
        iVar3 = EnhanceUIController.GetNowEnhanceLv(this,0);
        if (this.enhanceTargetItemIcon == null) {
        LAB_180932330:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        lVar5 = GameObject.GetComponent(this.enhanceTargetItemIcon,DAT_181da0070);
        if ((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) goto LAB_180932330;
        iVar1 = *(int *)(*(int64 *)(lVar5 + 32) + 60);
        if (this.enhanceType == 1) {
          if ((*pStatics == 0) ||
             (lVar5 = *(int64 *)(*pStatics + 32)) == null)
          goto LAB_180932330;
          lVar5 = WorldData.Player(lVar5,0);
          if (lVar5 == null) goto LAB_180932330;
          cVar2 = HeroData.HaveForceFunction(lVar5,2);
          if (cVar2) {
            fVar6 = 0.5;
            goto LAB_180932303;
          }
        }
        fVar6 = 1.0;
        LAB_180932303:
        uVar4 = Mathf.RoundToInt((float)(iVar3 + -4 + iVar1) * fVar6,0);
        Mathf.Clamp(uVar4,0,10);
    }

    // Token : 0x60013AB
    // RVA   : 0x932340   Offset: 0x930B40   Length: 0x17C
    public int EnhanceNeedSkillLv()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        int iVar1;
        bool cVar2;
        int iVar3;
        uint uVar4;
        long lVar5;
        float fVar6;
        iVar3 = EnhanceUIController.GetNowEnhanceLv(this,0);
        if (this.enhanceTargetItemIcon == null) {
        LAB_1809324b7:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        lVar5 = GameObject.GetComponent(this.enhanceTargetItemIcon,DAT_181da0070);
        if ((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) goto LAB_1809324b7;
        iVar1 = *(int *)(*(int64 *)(lVar5 + 32) + 60);
        if (this.enhanceType == 1) {
          if ((*pStatics == 0) ||
             (lVar5 = *(int64 *)(*pStatics + 32)) == null)
          goto LAB_1809324b7;
          lVar5 = WorldData.Player(lVar5,0);
          if (lVar5 == null) goto LAB_1809324b7;
          cVar2 = HeroData.HaveForceFunction(lVar5,2);
          if (cVar2) {
            fVar6 = 0.5;
            goto LAB_18093248a;
          }
        }
        fVar6 = 1.0;
        LAB_18093248a:
        uVar4 = Mathf.RoundToInt((float)((iVar1 * 2 + 1 + iVar3) * 5) * fVar6,0);
        Mathf.Clamp(uVar4,0,100);
    }

    // Token : 0x60013AC
    // RVA   : 0x9324C0   Offset: 0x930CC0   Length: 0xA3
    public int EnhanceNeedTime()
    {
        int iVar1;
        long lVar2;
        if (this.enhanceType != null) {
          return 1;
        }
        iVar1 = 0;
        if (!DAT_181e78040) {
          il2cpp_runtime_class_init(&DAT_181da0070);
          iVar1 = this.enhanceType;
          DAT_181e78040 = true;
        }
        lVar2 = this.enhanceTargetItemIcon;
        if (iVar1 == 0) {
          if (lVar2 == null) throw; // [null/range check failed]
          lVar2 = GameObject.GetComponent(lVar2,DAT_181da0070);
          if ((lVar2 == null) || (*(int64 *)(lVar2 + 32) == 0)) throw; // [null/range check failed]
          lVar2 = *(int64 *)(*(int64 *)(lVar2 + 32) + 96);
        }
        else {
          if (lVar2 == null) throw; // [null/range check failed]
          lVar2 = GameObject.GetComponent(lVar2,DAT_181da0070);
          if ((lVar2 == null) || (*(int64 *)(lVar2 + 32) == 0)) throw; // [null/range check failed]
          lVar2 = *(int64 *)(*(int64 *)(lVar2 + 32) + 104);
        }
        if (lVar2 != null) {
          return *(int *)(lVar2 + 16) + 1;
        }
    }

    // Token : 0x60013AD
    // RVA   : 0x9332A0   Offset: 0x931AA0   Length: 0x8A
    public int GetNowEnhanceLv()
    {
        long lVar1;
        lVar1 = this.enhanceTargetItemIcon;
        if (this.enhanceType == null) {
          if (lVar1 == null) throw; // [null/range check failed]
          lVar1 = GameObject.GetComponent(lVar1,DAT_181da0070);
          if ((lVar1 == null) || (*(int64 *)(lVar1 + 32) == 0)) throw; // [null/range check failed]
          lVar1 = *(int64 *)(*(int64 *)(lVar1 + 32) + 96);
        }
        else {
          if (lVar1 == null) throw; // [null/range check failed]
          lVar1 = GameObject.GetComponent(lVar1,DAT_181da0070);
          if ((lVar1 == null) || (*(int64 *)(lVar1 + 32) == 0)) throw; // [null/range check failed]
          lVar1 = *(int64 *)(*(int64 *)(lVar1 + 32) + 104);
        }
        if (lVar1 != null) {
          return *(uint32 *)(lVar1 + 16);
        }
    }

    // Token : 0x60013AE
    // RVA   : 0x933460   Offset: 0x931C60   Length: 0x26
    public int GetTargetSkillType()
    {
        int iVar1;
        iVar1 = this.enhanceType;
        if (iVar1 == 0) {
          return 6;
        }
        if (iVar1 != 1) {
          if (iVar1 == 2) {
            return 8;
          }
          return 0;
        }
        return 7;
    }

    // Token : 0x60013AF
    // RVA   : 0x933330   Offset: 0x931B30   Length: 0x128
    public float GetPlayerTargetSkill()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        int iVar1;
        long lVar2;
        uint uVar3;
        if ((*pStatics != 0) &&
           (lVar2 = *(int64 *)(*pStatics + 32)) != null) {
          lVar2 = WorldData.Player(lVar2,0);
          if (lVar2 != null) {
            iVar1 = this.enhanceType;
            uVar3 = 0;
            lVar2 = *(int64 *)(lVar2 + 0x168);
            if (iVar1 == 0) {
              uVar3 = 6;
            }
            else if (iVar1 == 1) {
              uVar3 = 7;
            }
            else if (iVar1 == 2) {
              uVar3 = 8;
            }
            if (lVar2 != null) {
              if (*(uint32 *)(lVar2 + 24) <= uVar3) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              return *(uint32 *)(*(int64 *)(lVar2 + 16) + 32 + (uint64)uVar3 * 4);
            }
          }
        }
    }

    // Token : 0x60013B0
    // RVA   : 0x931320   Offset: 0x92FB20   Length: 0xCE
    public bool CanEnhance()
    {
        int iVar1;
        ulong uVar2;
        ulong uVar3;
        float fVar4;
        if (this.targetBuilding != null) {
          iVar1 = this.targetBuilding.lv;
          uVar3 = EnhanceUIController.EnhanceNeedBuildingLv(this,0);
          if ((int)uVar3 <= iVar1) {
            fVar4 = (float)EnhanceUIController.GetPlayerTargetSkill(this,0);
            uVar3 = EnhanceUIController.EnhanceNeedSkillLv(this,0);
            if ((float)(int)uVar3 <= fVar4) {
              uVar3 = EnhanceUIController.HaveResource(this,0);
              if ((char)uVar3) {
                uVar2 = this.enhanceMaterialItemIcon;
                uVar3 = Object.op_Inequality(uVar2,0,0);
                return uVar3;
              }
            }
          }
          return uVar3 & 0xffffffffffffff00;
        }
    }

    // Token : 0x60013B1
    // RVA   : 0x933490   Offset: 0x931C90   Length: 0x1D2
    public bool HaveResource()
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
              uVar4 = EnhanceUIController.GetEnhanceResourceCost(this,0);
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
              EnhanceUIController.GetEnhanceResourceCostNum(this,0);
              return extraout_XMM0_Da <= (float)iVar1;
            }
          }
        }
    }

    // Token : 0x60013B2
    // RVA   : 0x932B40   Offset: 0x931340   Length: 0x3AC
    public string GetEnhanceExtraAdd()
    {
        ulong uVar1;
        bool cVar2;
        long lVar3;
        long lVar4;
        long lVar5;
        ulong uVar6;
        ulong uVar7;
        ulong uVar8;
        float fVar9;
        float fVar10;
        ulong local_80;
        ulong uStack_78;
        ulong local_70;
        uint local_68;
        uint uStack_64;
        uint uStack_60;
        uint32 uStack_5c;
        uint64 local_58;
        local_80 = 0;
        uStack_78 = 0;
        local_70 = 0;
        uVar7 = this.enhanceTargetItemIcon;
        cVar2 = Object.op_Equality(uVar7,0,0);
        if (cVar2) {
          return "";
        }
        uVar7 = this.enhanceMaterialItemIcon;
        cVar2 = Object.op_Equality(uVar7,0,0);
        uVar7 = "";
        if (cVar2) {
          return "";
        }
        lVar3 = this.enhanceTargetItemIcon;
        if (this.enhanceType == null) {
          if (((lVar3 == null) || (lVar3 = GameObject.GetComponent(lVar3,DAT_181da0070)) == null) ||
             (*(int64 *)(lVar3 + 32) == 0)) throw; // [null/range check failed]
          lVar3 = *(int64 *)(*(int64 *)(lVar3 + 32) + 96);
        }
        else {
          if (((lVar3 == null) || (lVar3 = GameObject.GetComponent(lVar3,DAT_181da0070)) == null) ||
             (*(int64 *)(lVar3 + 32) == 0)) throw; // [null/range check failed]
          lVar3 = *(int64 *)(*(int64 *)(lVar3 + 32) + 104);
        }
        if (lVar3 != null) {
          lVar3 = *(int64 *)(lVar3 + 40);
          if (((this.enhanceMaterialItemIcon != null) &&
              (lVar4 = GameObject.GetComponent(this.enhanceMaterialItemIcon,DAT_181da0070)) != null)
             && ((*(int64 *)(lVar4 + 32) != 0 &&
                 (lVar4 = *(int64 *)(*(int64 *)(lVar4 + 32) + 128)) != null))) {
            lVar4 = *(int64 *)(lVar4 + 16);
            if ((lVar3 != null) && (lVar4 != null)) {
              if ((*(int64 *)(lVar3 + 16) == 0) ||
                 (lVar5 = Dictionary_2.get_Keys(*(int64 *)(lVar3 + 16),DAT_181d98b10)) == null)
              throw; // [null/range check failed]
              FUN_180ed4d30(&local_68,lVar5,DAT_181d9c570);
              local_80 = CONCAT44(uStack_64,local_68);
              uStack_78 = CONCAT44(uStack_5c,uStack_60);
              local_70 = local_58;
              while (cVar2 = FUN_1811d8280(&local_80,DAT_181d74c38), uVar1 = local_70, cVar2) {
                fVar9 = (float)HeroSpeAddData.Get(lVar3,local_70 & 0xffffffff,0);
                if ((fVar9 != 0.0) &&
                   (fVar9 = (float)HeroSpeAddData.Get(lVar4,uVar1 & 0xffffffff,0), fVar9 != 0.0)) {
                  fVar9 = (float)HeroSpeAddData.Get(lVar4,uVar1 & 0xffffffff,0);
                  fVar10 = (float)HeroSpeAddData.Get(lVar3,uVar1 & 0xffffffff);
                  if (fVar10 < fVar9) {
                    cVar2 = FUN_1816fd990(uVar7,"",0);
                    uVar8 = "\n";
                    if (cVar2) {
                      uVar8 = "";
                    }
                    uVar6 = HeroSpeAddData.GetDescribe
                                      (lVar4,uVar1 & 0xffffffff,uVar1 & 0xffffffff,1,1,1,0,0);
                    uVar7 = String.Concat(uVar7,uVar8,uVar6,0);
                  }
                }
              }
              ZhSegment.Initialize(&local_80,DAT_181d74bb8);
            }
            cVar2 = FUN_180d6ca90(uVar7,0);
            if (!cVar2) {
              return uVar7;
            }
            return "无";
          }
        }
    }

    // Token : 0x60013B3
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
