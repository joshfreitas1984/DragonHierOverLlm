// ============================================================
// Type  : EnhanceUIController
// Token : 0x2000269
// ============================================================

public class EnhanceUIController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400136A
    public CraftType enhanceType;

    // Token: 0x400136B
    public GameObject enhanceUIPanel;

    // Token: 0x400136C
    public AreaBuildingData targetBuilding;

    // Token: 0x400136D
    public bool useMoney;

    // Token: 0x400136E
    public GameObject enhanceTargetClearButton;

    // Token: 0x400136F
    public GameObject enhanceMaterialClearButton;

    // Token: 0x4001370
    public GameObject enhanceTargetItemIcon;

    // Token: 0x4001371
    public GameObject enhanceMaterialItemIcon;

    // Token: 0x4001372
    private static EnhanceUIController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60013DD
    // RVA   : 0x9440C0   Offset: 0x9434C0   Length: 0x36
    public static EnhanceUIController get_Instance()
    {
        return **(uint64 **)(DAT_181dc3770 + 184);
    }

    // Token : 0x60013DE
    // RVA   : 0x940C00   Offset: 0x940000   Length: 0xD7
    private void Awake()
    {
        bool cVar2;
        ulong uVar3;
        uVar3 = **(uint64 **)(DAT_181dc3770 + 184);
        cVar2 = Object.op_Equality(uVar3,0,0);
        if (!cVar2) {
          uVar3 = Component.get_gameObject(this,0);
          Object.Destroy(uVar3,0);
          return;
        }
        puVar1 = *(uint64 **)(DAT_181dc3770 + 184);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x60013DF
    // RVA   : 0x9433D0   Offset: 0x9427D0   Length: 0xCEC
    private void Update()
    {
        var pStatics = *(int64*)(DAT_181d73d40 + 184);
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
            uVar6 = Component.GetComponent(lVar5,DAT_181d96160);
            plVar7 = (int64 *)FUN_1800d60b0(DAT_181da4120,7);
            if (this.targetBuilding == null) throw; // [null/range check failed]
            iVar3 = this.targetBuilding.lv;
            iVar4 = EnhanceUIController.EnhanceNeedBuildingLv(this,0);
            uVar11 = "提升强化等级至+{6}\n{0}需要建筑等级 {1}级</color>\n{2}需要{5}技能 {3}</color>\n{4}";
            if (iVar3 < iVar4) {
              lVar5 = *(int64 *)(pStatics + 0x2d0);
            }
            else {
              lVar5 = *(int64 *)(pStatics + 0x268);
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
            lVar5 = il2cpp_value_box(DAT_181d80418,local_res8);
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
              lVar5 = *(int64 *)(pStatics + 0x2d0);
            }
            else {
              lVar5 = *(int64 *)(pStatics + 0x268);
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
            lVar5 = il2cpp_value_box(DAT_181d80418,local_res8);
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
              lVar5 = *(int64 *)(pStatics + 0x438);
              if (lVar5 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              if (*(int *)(lVar5 + 24) == 0) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              uVar10 = *(uint64 *)(*(int64 *)(lVar5 + 16) + 32);
              local_res8[0] = EnhanceUIController.GetEnhanceResourceCostNum(this,0);
              uVar9 = il2cpp_value_box(DAT_181da22d8,local_res8);
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
            lVar5 = *(int64 *)(pStatics + 0x4b0);
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
        LAB_1809440b1:
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
            lVar5 = il2cpp_value_box(DAT_181d80418,local_res18);
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
               (lVar5 = Transform.Find(lVar5,"EnhanceExtraAdd",0)) == null) goto LAB_1809440b1;
            uVar11 = Component.GetComponent(lVar5,DAT_181d96160);
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
               (lVar5 = Transform.Find(lVar5,"CostTime",0)) == null) goto LAB_1809440ab;
            uVar6 = Component.GetComponent(lVar5,DAT_181d96160);
            local_res8[0] = EnhanceUIController.EnhanceNeedTime(this,0);
            uVar11 = il2cpp_value_box(DAT_181d80418,local_res8);
            uVar11 = String.Format("消耗时间：{0}天",uVar11,0);
            LTLocalization.SetText(uVar6,uVar11,0);
            if (((this.enhanceUIPanel == null) ||
                (lVar5 = GameObject.get_transform(this.enhanceUIPanel,0)) == null) ||
               (lVar5 = Transform.Find(lVar5,"EnhanceButton",0)) == null) goto LAB_1809440ab;
            lVar5 = Component.GetComponent(lVar5,DAT_181d93760);
            if (this.targetBuilding == null) goto LAB_1809440ab;
            iVar3 = this.targetBuilding.lv;
            iVar4 = EnhanceUIController.EnhanceNeedBuildingLv(this,0);
            if (iVar3 < iVar4) {
        LAB_180943ca7:
              uVar2 = 0;
            }
            else {
              fVar13 = (float)EnhanceUIController.GetPlayerTargetSkill(this,0);
              iVar3 = EnhanceUIController.EnhanceNeedSkillLv(this,0);
              if ((fVar13 < (float)iVar3) ||
                 (cVar1 = EnhanceUIController.HaveResource(this,0), !cVar1))
              goto LAB_180943ca7;
              uVar6 = this.enhanceMaterialItemIcon;
              uVar2 = Object.op_Inequality(uVar6,0,0);
            }
            if (lVar5 != null) {
              Selectable.set_interactable(lVar5,uVar2,0);
              return;
            }
        LAB_1809440ab:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          if (((lVar5 == null) || (lVar5 = GameObject.get_transform(lVar5,0)) == null) ||
             (lVar5 = Transform.Find(lVar5,"EnhanceCost",0)) == null) throw; // [null/range check failed]
          uVar6 = Component.GetComponent(lVar5,DAT_181d96160);
          lVar5 = *(int64 *)(pStatics + 0x580);
          uVar11 = *(uint64 *)(pStatics + 0x2d0);
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
          uVar6 = Component.GetComponent(lVar5,DAT_181d96160);
          LTLocalization.SetText(uVar6,"",0);
          if (this.enhanceUIPanel == null) throw; // [null/range check failed]
          lVar5 = GameObject.get_transform(this.enhanceUIPanel,0);
          uVar6 = "EnhanceExtraAdd";
        }
        else {
          if (((this.enhanceUIPanel == null) ||
              (lVar5 = GameObject.get_transform(this.enhanceUIPanel,0)) == null) ||
             (lVar5 = Transform.Find(lVar5,"EnhanceCost",0)) == null) throw; // [null/range check failed]
          uVar6 = Component.GetComponent(lVar5,DAT_181d96160);
          LTLocalization.SetText(uVar6,"",0);
          if (((this.enhanceUIPanel == null) ||
              (lVar5 = GameObject.get_transform(this.enhanceUIPanel,0)) == null) ||
             (lVar5 = Transform.Find(lVar5,"EnhanceExtraAdd",0)) == null) throw; // [null/range check failed]
          uVar6 = Component.GetComponent(lVar5,DAT_181d96160);
          LTLocalization.SetText(uVar6,"",0);
          if (this.enhanceUIPanel == null) throw; // [null/range check failed]
          lVar5 = GameObject.get_transform(this.enhanceUIPanel,0);
          uVar6 = "CostTime";
        }
        if ((lVar5 != null) && (lVar5 = Transform.Find(lVar5,uVar6,0)) != null) {
          uVar6 = Component.GetComponent(lVar5,DAT_181d96160);
          LTLocalization.SetText(uVar6,"",0);
          if (((this.enhanceUIPanel != null) &&
              ((lVar5 = GameObject.get_transform(this.enhanceUIPanel,0), lVar5 != null &&
               (lVar5 = Transform.Find(lVar5,"EnhanceButton",0)) != null))) &&
             (lVar5 = Component.GetComponent(lVar5,DAT_181d93760)) != null) {
            Selectable.set_interactable(lVar5,0,0);
            return;
          }
        }
    }

    // Token : 0x60013E0
    // RVA   : 0x943030   Offset: 0x942430   Length: 0x30
    public void HideEnhanceUI()
    {
        if (this.enhanceUIPanel != null) {
          GameObject.SetActive(this.enhanceUIPanel,0,0);
          EnhanceUIController.ClearEnhanceTarget(this,0);
          return;
        }
    }

    // Token : 0x60013E1
    // RVA   : 0x943070   Offset: 0x942470   Length: 0x356
    public void OpenEnhanceUI(CraftType _enhanceType, AreaBuildingData _targetBuilding, bool _useMoney)
    {
        void EnhanceUIController.OpenEnhanceUI
                     (int64 this,int _enhanceType,uint64 _targetBuilding,uint8 _useMoney)
        {
        uint32 uVar1;
        uint64 uVar2;
        char cVar3;
        int64 *plVar4;
        int64 lVar5;
        uint64 uVar6;
        int64 *plVar7;
        int local_res10 [2];
        uVar6 = "Sound/SoundEffect/Armor";
        if (((_enhanceType == null) || (uVar6 = "Sound/SoundEffect/Med", _enhanceType == 1)) ||
           (uVar6 = "Sound/SoundEffect/Food", _enhanceType == 2)) {
          plVar4 = (int64 *)Resources.Load(uVar6,0);
          plVar7 = (int64 *)0;
          if ((plVar4 != (int64 *)0) && (*plVar4 == DAT_181daf348)) {
            plVar7 = plVar4;
          }
          NGUITools.PlaySound(plVar7,0);
        }
        if (this.enhanceUIPanel != null) {
          GameObject.SetActive(this.enhanceUIPanel,1,0);
          this.targetBuilding = _targetBuilding;
          this.enhanceType = _enhanceType;
          this.useMoney = _useMoney;
          if (((this.enhanceUIPanel != null) &&
              (lVar5 = GameObject.get_transform(this.enhanceUIPanel,0)) != null) &&
             (lVar5 = Transform.Find(lVar5,"Title",0)) != null) {
            uVar6 = Component.GetComponent(lVar5,DAT_181d96160);
            lVar5 = *(int64 *)(*(int64 *)(DAT_181d73d40 + 184) + 0x580);
            if (lVar5 != null) {
              uVar1 = this.enhanceType;
              if (*(uint32 *)(lVar5 + 24) <= uVar1) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              uVar2 = lVar5[uVar1];
              LTLocalization.SetText(uVar6,uVar2,0);
              local_res10[0] = 0;
              do {
                if ((this.enhanceUIPanel == null) ||
                   (lVar5 = GameObject.get_transform(this.enhanceUIPanel,0)) == null)
                break;
                lVar5 = Transform.Find(lVar5,"Decoration",0);
                uVar6 = Int32.ToString(local_res10,0);
                if ((lVar5 == null) ||
                   ((lVar5 = Transform.Find(lVar5,uVar6,0), lVar5 == null ||
                    (lVar5 = Component.get_gameObject(lVar5,0)) == null))) break;
                cVar3 = GameObject.get_activeSelf(lVar5,0);
                if ((bool)cVar3 != (this.enhanceType == local_res10[0])) {
                  if ((this.enhanceUIPanel == null) ||
                     (lVar5 = GameObject.get_transform(this.enhanceUIPanel,0)) == null)
                  break;
                  lVar5 = Transform.Find(lVar5,"Decoration",0);
                  uVar6 = Int32.ToString(local_res10,0);
                  if ((lVar5 == null) || (lVar5 = Transform.Find(lVar5,uVar6,0)) == null) break;
                  lVar5 = Component.get_gameObject(lVar5,0);
                  if (lVar5 == null) break;
                  GameObject.SetActive(lVar5,this.enhanceType == local_res10[0]);
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

    // Token : 0x60013E2
    // RVA   : 0x941F30   Offset: 0x941330   Length: 0x35D
    public void EnhanceTargetButtonClicked()
    {
        var pStatics = *(int64*)(DAT_181db7518 + 184);
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
            lVar3 = il2cpp_internal(DAT_181d94e50);
            FUN_18132faf0(lVar3,DAT_181d95788);
            local_res8[0] = 0;
            uVar4 = il2cpp_value_box(DAT_181d80418,local_res8);
            if (lVar3 == null) {
        LAB_18094227c:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            FUN_18181e0a0(lVar3,uVar4,DAT_181d95888);
            local_res18[0] = 0;
            uVar4 = il2cpp_value_box(DAT_181d80418,local_res18);
            FUN_18181e0a0(lVar3,uVar4,DAT_181d95888);
            uVar4 = Component.get_gameObject(this,0);
            if (lVar5 == null) goto LAB_18094227c;
          }
          else if (iVar1 == 1) {
            lVar5 = *pStatics;
            lVar3 = il2cpp_internal(DAT_181d94e50);
            FUN_18132faf0(lVar3,DAT_181d95788);
            local_res8[0] = 0;
            uVar4 = il2cpp_value_box(DAT_181d80418,local_res8);
            if (lVar3 == null) {
        LAB_180942288:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            FUN_18181e0a0(lVar3,uVar4,DAT_181d95888);
            local_res18[0] = 1;
            uVar4 = il2cpp_value_box(DAT_181d80418,local_res18);
            FUN_18181e0a0(lVar3,uVar4,DAT_181d95888);
            uVar4 = Component.get_gameObject(this,0);
            if (lVar5 == null) goto LAB_180942288;
          }
          else {
            if (iVar1 != 2) {
              return;
            }
            lVar5 = *pStatics;
            lVar3 = il2cpp_internal(DAT_181d94e50);
            FUN_18132faf0(lVar3,DAT_181d95788);
            local_res8[0] = 0;
            uVar4 = il2cpp_value_box(DAT_181d80418,local_res8);
            if (lVar3 == null) {
        LAB_180942282:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            FUN_18181e0a0(lVar3,uVar4,DAT_181d95888);
            local_res18[0] = 2;
            uVar4 = il2cpp_value_box(DAT_181d80418,local_res18);
            FUN_18181e0a0(lVar3,uVar4,DAT_181d95888);
            uVar4 = Component.get_gameObject(this,0);
            if (lVar5 == null) goto LAB_180942282;
          }
          ChooseController.ShowChoosePanel(lVar5,1,lVar3,uVar4,"EnhanceTargetChoosen",0,0,0,0,0);
        }
    }

    // Token : 0x60013E3
    // RVA   : 0x942290   Offset: 0x941690   Length: 0x260
    public void EnhanceTargetChoosen()
    {
        var pStatics_2ee8 = *(int64*)(DAT_181d72ee8 + 184);
        var pStatics_7518 = *(int64*)(DAT_181db7518 + 184);
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
              if (*pStatics_2ee8 != 0) {
                uVar1 = *(uint64 *)(*pStatics_2ee8 + 160);
                uVar3 = GlobalData.AddChild(uVar3,uVar1,0);
                this.enhanceTargetItemIcon = uVar3;
                if (this.enhanceTargetItemIcon != null) {
                  lVar2 = GameObject.GetComponent(this.enhanceTargetItemIcon,DAT_181d720a0);
                  if ((*pStatics_7518 != 0) &&
                     (lVar4 = *(int64 *)(*pStatics_7518 + 72)) != null) {
                    lVar4 = GameObject.GetComponent(lVar4,DAT_181d720a0);
                    if ((lVar4 != null) && (lVar2 != null)) {
                      *(uint64 *)(lVar2 + 32) = *(uint64 *)(lVar4 + 32);
                      if (this.enhanceTargetItemIcon != null) {
                        lVar2 = GameObject.GetComponent(this.enhanceTargetItemIcon,DAT_181d720a0);
                        if (lVar2 != null) {
                          *(uint32 *)(lVar2 + 40) = 1;
                          if (this.enhanceTargetItemIcon != null) {
                            lVar2 = GameObject.GetComponent(this.enhanceTargetItemIcon,DAT_181d720a0);
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

    // Token : 0x60013E4
    // RVA   : 0x940E90   Offset: 0x940290   Length: 0x1A0
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

    // Token : 0x60013E5
    // RVA   : 0x941420   Offset: 0x940820   Length: 0x4EB
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
            lVar4 = il2cpp_internal(DAT_181d94e50);
            FUN_18132faf0(lVar4,DAT_181d95788);
            local_res8[0] = 0;
            uVar5 = il2cpp_value_box(DAT_181d80418,local_res8);
            if (lVar4 == null) {
        LAB_180941906:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            FUN_18181e0a0(lVar4,uVar5,DAT_181d95888);
            local_res18[0] = 5;
            uVar5 = il2cpp_value_box(DAT_181d80418,local_res18);
            FUN_18181e0a0(lVar4,uVar5,DAT_181d95888);
            if (((this.enhanceTargetItemIcon == null) ||
                (lVar6 = GameObject.GetComponent(this.enhanceTargetItemIcon,DAT_181d720a0), lVar6 == null
                )) || (*(int64 *)(lVar6 + 32) == 0)) goto LAB_180941906;
            local_res20[0] = *(uint32 *)(*(int64 *)(lVar6 + 32) + 60);
            uVar5 = il2cpp_value_box(DAT_181d80418,local_res20);
            FUN_18181e0a0(lVar4,uVar5,DAT_181d95888);
            uVar5 = Component.get_gameObject(this,0);
            if (lVar3 == null) goto LAB_180941906;
            uVar7 = 3;
          }
          else if (iVar1 == 1) {
            lVar3 = FUN_18046bd60(0);
            lVar4 = il2cpp_internal(DAT_181d94e50);
            FUN_18132faf0(lVar4,DAT_181d95788);
            local_res8[0] = 0;
            uVar5 = il2cpp_value_box(DAT_181d80418,local_res8);
            if (lVar4 == null) {
        LAB_180941900:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            FUN_18181e0a0(lVar4,uVar5,DAT_181d95888);
            local_res18[0] = 5;
            uVar5 = il2cpp_value_box(DAT_181d80418,local_res18);
            FUN_18181e0a0(lVar4,uVar5,DAT_181d95888);
            if (((this.enhanceTargetItemIcon == null) ||
                (lVar6 = GameObject.GetComponent(this.enhanceTargetItemIcon,DAT_181d720a0), lVar6 == null
                )) || (*(int64 *)(lVar6 + 32) == 0)) goto LAB_180941900;
            local_res20[0] = *(uint32 *)(*(int64 *)(lVar6 + 32) + 60);
            uVar5 = il2cpp_value_box(DAT_181d80418,local_res20);
            FUN_18181e0a0(lVar4,uVar5,DAT_181d95888);
            uVar5 = Component.get_gameObject(this,0);
            if (lVar3 == null) goto LAB_180941900;
            uVar7 = 4;
          }
          else {
            if (iVar1 != 2) {
              return;
            }
            lVar3 = FUN_18046bd60(0);
            lVar4 = il2cpp_internal(DAT_181d94e50);
            FUN_18132faf0(lVar4,DAT_181d95788);
            local_res8[0] = 0;
            uVar5 = il2cpp_value_box(DAT_181d80418,local_res8);
            if (lVar4 == null) {
        LAB_1809418fa:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            FUN_18181e0a0(lVar4,uVar5,DAT_181d95888);
            local_res18[0] = 5;
            uVar5 = il2cpp_value_box(DAT_181d80418,local_res18);
            FUN_18181e0a0(lVar4,uVar5,DAT_181d95888);
            if (((this.enhanceTargetItemIcon == null) ||
                (lVar6 = GameObject.GetComponent(this.enhanceTargetItemIcon,DAT_181d720a0), lVar6 == null
                )) || (*(int64 *)(lVar6 + 32) == 0)) goto LAB_1809418fa;
            local_res20[0] = *(uint32 *)(*(int64 *)(lVar6 + 32) + 60);
            uVar5 = il2cpp_value_box(DAT_181d80418,local_res20);
            FUN_18181e0a0(lVar4,uVar5,DAT_181d95888);
            uVar5 = Component.get_gameObject(this,0);
            if (lVar3 == null) goto LAB_1809418fa;
            uVar7 = 5;
          }
          ChooseController.ShowChoosePanel(lVar3,1,lVar4,uVar5,"EnhanceMaterialChoosen",0,uVar7,0,0,0);
        }
    }

    // Token : 0x60013E6
    // RVA   : 0x941910   Offset: 0x940D10   Length: 0x260
    public void EnhanceMaterialChoosen()
    {
        var pStatics_2ee8 = *(int64*)(DAT_181d72ee8 + 184);
        var pStatics_7518 = *(int64*)(DAT_181db7518 + 184);
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
              if (*pStatics_2ee8 != 0) {
                uVar1 = *(uint64 *)(*pStatics_2ee8 + 160);
                uVar3 = GlobalData.AddChild(uVar3,uVar1,0);
                this.enhanceMaterialItemIcon = uVar3;
                if (this.enhanceMaterialItemIcon != null) {
                  lVar2 = GameObject.GetComponent(this.enhanceMaterialItemIcon,DAT_181d720a0);
                  if ((*pStatics_7518 != 0) &&
                     (lVar4 = *(int64 *)(*pStatics_7518 + 72)) != null) {
                    lVar4 = GameObject.GetComponent(lVar4,DAT_181d720a0);
                    if ((lVar4 != null) && (lVar2 != null)) {
                      *(uint64 *)(lVar2 + 32) = *(uint64 *)(lVar4 + 32);
                      if (this.enhanceMaterialItemIcon != null) {
                        lVar2 = GameObject.GetComponent(this.enhanceMaterialItemIcon,DAT_181d720a0);
                        if (lVar2 != null) {
                          *(uint32 *)(lVar2 + 40) = 1;
                          if (this.enhanceMaterialItemIcon != null) {
                            lVar2 = GameObject.GetComponent(this.enhanceMaterialItemIcon,DAT_181d720a0);
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

    // Token : 0x60013E7
    // RVA   : 0x940DB0   Offset: 0x9401B0   Length: 0xDD
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

    // Token : 0x60013E8
    // RVA   : 0x9428B0   Offset: 0x941CB0   Length: 0x218
    public float GetEnhanceResourceCostNum()
    {
        int iVar1;
        bool cVar2;
        long lVar3;
        iVar1 = this.enhanceType;
        if (iVar1 == 0) {
          if (((this.enhanceTargetItemIcon != null) &&
              (lVar3 = GameObject.GetComponent(this.enhanceTargetItemIcon,DAT_181d720a0)) != null)
             && (*(int64 *)(lVar3 + 32) != 0)) {
            EnhanceUIController.GetNowEnhanceLv(this,0);
            return;
          }
        }
        else if (iVar1 == 1) {
          if (((this.enhanceTargetItemIcon != null) &&
              (lVar3 = GameObject.GetComponent(this.enhanceTargetItemIcon,DAT_181d720a0)) != null)
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
              (lVar3 = GameObject.GetComponent(this.enhanceTargetItemIcon,DAT_181d720a0)) != null)
             && (*(int64 *)(lVar3 + 32) != 0)) {
            EnhanceUIController.GetNowEnhanceLv(this,0);
            return;
          }
        }
    }

    // Token : 0x60013E9
    // RVA   : 0x942AD0   Offset: 0x941ED0   Length: 0x189
    public List<ResourceData> GetEnhanceResourceCost()
    {
        int iVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        uint uVar5;
        lVar2 = il2cpp_internal(DAT_181d969d0);
        FUN_18132faf0(lVar2,DAT_181d9f778);
        iVar1 = this.enhanceType;
        if (iVar1 == 0) {
          uVar5 = EnhanceUIController.GetEnhanceResourceCostNum(this,0);
          uVar3 = new PlotChoiceRequirement(2,uVar5);
          if (lVar2 == null) goto LAB_180942c54;
          FUN_18181e0a0(lVar2,uVar3,DAT_181d9f7f8);
          uVar5 = EnhanceUIController.GetEnhanceResourceCostNum(this,0);
          uVar3 = new PlotChoiceRequirement(3,uVar5);
        }
        else {
          if (iVar1 == 1) {
            uVar5 = EnhanceUIController.GetEnhanceResourceCostNum(this,0);
            uVar3 = il2cpp_internal(DAT_181d9c700);
            uVar4 = 4;
          }
          else {
            if (iVar1 != 2) {
              return lVar2;
            }
            uVar5 = EnhanceUIController.GetEnhanceResourceCostNum(this,0);
            uVar3 = il2cpp_internal(DAT_181d9c700);
            uVar4 = 1;
          }
          PlotChoiceRequirement.ctor(uVar3,uVar4,uVar5,0);
          if (lVar2 == null) {
        LAB_180942c54:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
        }
        FUN_18181e0a0(lVar2,uVar3,DAT_181d9f7f8);
        return lVar2;
    }

    // Token : 0x60013EA
    // RVA   : 0x941040   Offset: 0x940440   Length: 0x3DB
    public void EnhanceButtonClicked()
    {
        int iVar1;
        uint uVar2;
        long lVar3;
        uint uVar4;
        long lVar5;
        ulong uVar6;
        float fVar9;
        if (!this.useMoney) {
          if (((GameController._instance == null) ||
              (lVar5 = GameController._instance.worldData) == null) ||
             (lVar5 = WorldData.Player(lVar5,0)) == null) throw; // [null/range check failed]
          lVar5 = HeroData.GetForce(lVar5,0,0);
          uVar6 = EnhanceUIController.GetEnhanceResourceCost(this,0);
          if (lVar5 == null) throw; // [null/range check failed]
          ForceData.CostResource(lVar5,uVar6,1,0);
        }
        else {
          if ((GameController._instance == null) ||
             (lVar5 = GameController._instance.worldData) == null)
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
          if ((plVar7 != (int64 *)0) && (*plVar7 == DAT_181daf348)) {
            plVar8 = plVar7;
          }
          NGUITools.PlaySound(plVar8,0);
        }
        lVar5 = *(int64 *)(*(int64 *)(DAT_181db5de8 + 184) + 8);
        lVar3 = *(int64 *)(*(int64 *)(DAT_181d73d40 + 184) + 0x580);
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

    // Token : 0x60013EB
    // RVA   : 0x941B80   Offset: 0x940F80   Length: 0x175
    public int EnhanceNeedBuildingLv()
    {
        int iVar1;
        bool cVar2;
        int iVar3;
        uint uVar4;
        long lVar5;
        float fVar6;
        iVar3 = EnhanceUIController.GetNowEnhanceLv(this,0);
        if (this.enhanceTargetItemIcon == null) {
        LAB_180941cf0:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        lVar5 = GameObject.GetComponent(this.enhanceTargetItemIcon,DAT_181d720a0);
        if ((lVar5 == null) || (lVar5.villageAreaID == null)) goto LAB_180941cf0;
        iVar1 = *(int *)(lVar5.villageAreaID + 60);
        if (this.enhanceType == 1) {
          if ((GameController._instance == null) ||
             (lVar5 = GameController._instance.worldData) == null)
          goto LAB_180941cf0;
          lVar5 = WorldData.Player(lVar5,0);
          if (lVar5 == null) goto LAB_180941cf0;
          cVar2 = HeroData.HaveForceFunction(lVar5,2);
          if (cVar2) {
            fVar6 = 0.5;
            goto LAB_180941cc3;
          }
        }
        fVar6 = 1.0;
        LAB_180941cc3:
        uVar4 = Mathf.RoundToInt((float)(iVar3 + -4 + iVar1) * fVar6,0);
        Mathf.Clamp(uVar4,0,10);
    }

    // Token : 0x60013EC
    // RVA   : 0x941D00   Offset: 0x941100   Length: 0x17C
    public int EnhanceNeedSkillLv()
    {
        int iVar1;
        bool cVar2;
        int iVar3;
        uint uVar4;
        long lVar5;
        float fVar6;
        iVar3 = EnhanceUIController.GetNowEnhanceLv(this,0);
        if (this.enhanceTargetItemIcon == null) {
        LAB_180941e77:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        lVar5 = GameObject.GetComponent(this.enhanceTargetItemIcon,DAT_181d720a0);
        if ((lVar5 == null) || (lVar5.villageAreaID == null)) goto LAB_180941e77;
        iVar1 = *(int *)(lVar5.villageAreaID + 60);
        if (this.enhanceType == 1) {
          if ((GameController._instance == null) ||
             (lVar5 = GameController._instance.worldData) == null)
          goto LAB_180941e77;
          lVar5 = WorldData.Player(lVar5,0);
          if (lVar5 == null) goto LAB_180941e77;
          cVar2 = HeroData.HaveForceFunction(lVar5,2);
          if (cVar2) {
            fVar6 = 0.5;
            goto LAB_180941e4a;
          }
        }
        fVar6 = 1.0;
        LAB_180941e4a:
        uVar4 = Mathf.RoundToInt((float)((iVar1 * 2 + 1 + iVar3) * 5) * fVar6,0);
        Mathf.Clamp(uVar4,0,100);
    }

    // Token : 0x60013ED
    // RVA   : 0x941E80   Offset: 0x941280   Length: 0xA3
    public int EnhanceNeedTime()
    {
        int iVar1;
        long lVar2;
        if (this.enhanceType != null) {
          return 1;
        }
        iVar1 = 0;
        if (!DAT_181e9d534) {
          il2cpp_runtime_class_init(&DAT_181d720a0);
          iVar1 = this.enhanceType;
          DAT_181e9d534 = true;
        }
        lVar2 = this.enhanceTargetItemIcon;
        if (iVar1 == 0) {
          if (lVar2 == null) throw; // [null/range check failed]
          lVar2 = GameObject.GetComponent(lVar2,DAT_181d720a0);
          if ((lVar2 == null) || (*(int64 *)(lVar2 + 32) == 0)) throw; // [null/range check failed]
          lVar2 = *(int64 *)(*(int64 *)(lVar2 + 32) + 96);
        }
        else {
          if (lVar2 == null) throw; // [null/range check failed]
          lVar2 = GameObject.GetComponent(lVar2,DAT_181d720a0);
          if ((lVar2 == null) || (*(int64 *)(lVar2 + 32) == 0)) throw; // [null/range check failed]
          lVar2 = *(int64 *)(*(int64 *)(lVar2 + 32) + 104);
        }
        if (lVar2 != null) {
          return *(int *)(lVar2 + 16) + 1;
        }
    }

    // Token : 0x60013EE
    // RVA   : 0x942C60   Offset: 0x942060   Length: 0x8A
    public int GetNowEnhanceLv()
    {
        long lVar1;
        lVar1 = this.enhanceTargetItemIcon;
        if (this.enhanceType == null) {
          if (lVar1 == null) throw; // [null/range check failed]
          lVar1 = GameObject.GetComponent(lVar1,DAT_181d720a0);
          if ((lVar1 == null) || (*(int64 *)(lVar1 + 32) == 0)) throw; // [null/range check failed]
          lVar1 = *(int64 *)(*(int64 *)(lVar1 + 32) + 96);
        }
        else {
          if (lVar1 == null) throw; // [null/range check failed]
          lVar1 = GameObject.GetComponent(lVar1,DAT_181d720a0);
          if ((lVar1 == null) || (*(int64 *)(lVar1 + 32) == 0)) throw; // [null/range check failed]
          lVar1 = *(int64 *)(*(int64 *)(lVar1 + 32) + 104);
        }
        if (lVar1 != null) {
          return *(uint32 *)(lVar1 + 16);
        }
    }

    // Token : 0x60013EF
    // RVA   : 0x942E20   Offset: 0x942220   Length: 0x26
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

    // Token : 0x60013F0
    // RVA   : 0x942CF0   Offset: 0x9420F0   Length: 0x128
    public float GetPlayerTargetSkill()
    {
        int iVar1;
        long lVar2;
        uint uVar3;
        if ((GameController._instance != null) &&
           (lVar2 = GameController._instance.worldData) != null) {
          lVar2 = WorldData.Player(lVar2,0);
          if (lVar2 != null) {
            iVar1 = this.enhanceType;
            uVar3 = 0;
            lVar2 = lVar2.showRoomChangeFame;
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
              if (lVar2.cityAreaID <= uVar3) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              return *(uint32 *)(lVar2.chapter + 32 + (uint64)uVar3 * 4);
            }
          }
        }
    }

    // Token : 0x60013F1
    // RVA   : 0x940CE0   Offset: 0x9400E0   Length: 0xCE
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

    // Token : 0x60013F2
    // RVA   : 0x942E50   Offset: 0x942250   Length: 0x1D2
    public bool HaveResource()
    {
        int iVar1;
        byte uVar2;
        long lVar3;
        ulong uVar4;
        float extraout_XMM0_Da;
        if (!this.useMoney) {
          if ((GameController._instance != null) &&
             (lVar3 = GameController._instance.worldData) != null) {
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
          if ((GameController._instance != null) &&
             (lVar3 = GameController._instance.worldData) != null) {
            lVar3 = WorldData.Player(lVar3,0);
            if ((lVar3 != null) && (lVar3.speBookStorageSpeAdd != null)) {
              iVar1 = *(int *)(lVar3.speBookStorageSpeAdd + 24);
              EnhanceUIController.GetEnhanceResourceCostNum(this,0);
              return extraout_XMM0_Da <= (float)iVar1;
            }
          }
        }
    }

    // Token : 0x60013F3
    // RVA   : 0x942500   Offset: 0x941900   Length: 0x3AC
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
          if (((lVar3 == null) || (lVar3 = GameObject.GetComponent(lVar3,DAT_181d720a0)) == null) ||
             (*(int64 *)(lVar3 + 32) == 0)) throw; // [null/range check failed]
          lVar3 = *(int64 *)(*(int64 *)(lVar3 + 32) + 96);
        }
        else {
          if (((lVar3 == null) || (lVar3 = GameObject.GetComponent(lVar3,DAT_181d720a0)) == null) ||
             (*(int64 *)(lVar3 + 32) == 0)) throw; // [null/range check failed]
          lVar3 = *(int64 *)(*(int64 *)(lVar3 + 32) + 104);
        }
        if (lVar3 != null) {
          lVar3 = *(int64 *)(lVar3 + 40);
          if (((this.enhanceMaterialItemIcon != null) &&
              (lVar4 = GameObject.GetComponent(this.enhanceMaterialItemIcon,DAT_181d720a0)) != null)
             && ((*(int64 *)(lVar4 + 32) != 0 &&
                 (lVar4 = *(int64 *)(*(int64 *)(lVar4 + 32) + 128)) != null))) {
            lVar4 = *(int64 *)(lVar4 + 16);
            if ((lVar3 != null) && (lVar4 != null)) {
              if ((*(int64 *)(lVar3 + 16) == 0) ||
                 (lVar5 = Dictionary_2.get_Keys(*(int64 *)(lVar3 + 16),DAT_181dbe4b8)) == null)
              throw; // [null/range check failed]
              FUN_180ecbf30(&local_68,lVar5,DAT_181dc36f0);
              local_80 = CONCAT44(uStack_64,local_68);
              uStack_78 = CONCAT44(uStack_5c,uStack_60);
              local_70 = local_58;
              while (cVar2 = FUN_1811c4f60(&local_80,DAT_181d9b258), uVar1 = local_70, cVar2) {
                fVar9 = (float)HeroSpeAddData.Get(lVar3,local_70 & 0xffffffff,0);
                if ((fVar9 != 0.0) &&
                   (fVar9 = (float)HeroSpeAddData.Get(lVar4,uVar1 & 0xffffffff,0), fVar9 != 0.0)) {
                  fVar9 = (float)HeroSpeAddData.Get(lVar4,uVar1 & 0xffffffff,0);
                  fVar10 = (float)HeroSpeAddData.Get(lVar3,uVar1 & 0xffffffff);
                  if (fVar10 < fVar9) {
                    cVar2 = FUN_18171e540(uVar7,"",0);
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
              ZhSegment.Initialize(&local_80,DAT_181d9b1d8);
            }
            cVar2 = FUN_180d755b0(uVar7,0);
            if (!cVar2) {
              return uVar7;
            }
            return "无";
          }
        }
    }

    // Token : 0x60013F4
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
