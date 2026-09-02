// ============================================================
// Type  : SpePoisonController
// Token : 0x200035F
// ============================================================

public class SpePoisonController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001AD4
    public GameObject spePoisonUI;

    // Token: 0x4001AD5
    public List<GameObject> materialIcon;

    // Token: 0x4001AD6
    public int spePoisonType;

    // Token: 0x4001AD7
    public SpePoisonData targetSpePoisonData;

    // Token: 0x4001AD8
    public bool needRefresh;

    // Token: 0x4001AD9
    private static SpePoisonController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60020E8
    // RVA   : 0x980730   Offset: 0x97EF30   Length: 0x36
    public static SpePoisonController get_Instance()
    {
        return **(uint64 **)(DAT_181d7f130 + 184);
    }

    // Token : 0x60020E9
    // RVA   : 0x97DB90   Offset: 0x97C390   Length: 0x43
    private void Awake()
    {
        puVar1 = *(uint64 **)(DAT_181d7f130 + 184);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x60020EA
    // RVA   : 0x9806F0   Offset: 0x97EEF0   Length: 0x3D
    private void Update()
    {
        bool cVar1;
        if (this.spePoisonUI == null) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        cVar1 = GameObject.get_activeSelf(this.spePoisonUI,0);
        if ((cVar1) && (this.needRefresh)) {
          SpePoisonController.RefreshUI(this,0);
          return;
        }
    }

    // Token : 0x60020EB
    // RVA   : 0x97E8C0   Offset: 0x97D0C0   Length: 0x17AE
    private void RefreshUI()
    {
        var pStatics_6270 = *(int64*)(DAT_181d86270 + 184);
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        byte uVar1;
        bool cVar2;
        uint uVar3;
        long lVar4;
        ulong uVar5;
        ulong uVar6;
        long lVar7;
        long lVar10;
        float fVar11;
        uint uVar12;
        uint[] local_res8 = new uint[2];
        uint[] local_res18 = new uint[2];
        uint[] local_res20 = new uint[2];
        uint local_78;
        int local_74;
        ulong local_70;
        ulong uStack_68;
        uint local_58;
        uint uStack_54;
        uint uStack_50;
        uint32 uStack_4c;
        uVar3 = 0;
        local_78 = 0;
        local_res8[0] = 0;
        local_res20[0] = 0;
        local_res18[0] = 0;
        this.needRefresh = 0;
        if (this.spePoisonType == null) {
          if ((*pStatics_df90 == 0) ||
             (lVar4 = *(int64 *)(*pStatics_df90 + 32)) == null)
          throw; // [null/range check failed]
          uVar6 = *(uint64 *)(lVar4 + 0x208);
        }
        else {
          if ((*pStatics_df90 == 0) ||
             (lVar4 = *(int64 *)(*pStatics_df90 + 32)) == null)
          throw; // [null/range check failed]
          uVar6 = *(uint64 *)(lVar4 + 0x210);
        }
        this.targetSpePoisonData = uVar6;
        if (((this.spePoisonUI != null) &&
            (lVar4 = GameObject.get_transform(this.spePoisonUI,0)) != null) &&
           (lVar4 = Transform.Find(lVar4,"Title",0)) != null) {
          uVar5 = Component.GetComponent(lVar4,DAT_181d6d8c0);
          uVar6 = "炼蛊";
          if (this.spePoisonType == null) {
            uVar6 = "引毒";
          }
          LTLocalization.SetText(uVar5,uVar6,0);
          local_74 = 0;
          do {
            if (this.spePoisonUI == null) throw; // [null/range check failed]
            lVar4 = GameObject.get_transform(this.spePoisonUI,0);
            uVar6 = Int32.ToString(&local_74,0);
            uVar6 = String.Concat("Material",uVar6,0);
            if (((lVar4 == null) || (lVar4 = Transform.Find(lVar4,uVar6)) == null) ||
               (lVar4 = Transform.Find(lVar4,"Label")) == null) throw; // [null/range check failed]
            uVar5 = Component.GetComponent(lVar4,DAT_181d6d8c0);
            uVar6 = "药引\n食材";
            if (this.spePoisonType != null) {
              uVar6 = "毒物";
            }
            String.Format("{0}\n（消耗）",uVar6);
            LTLocalization.SetText(uVar5);
            local_74 = local_74 + 1;
          } while (local_74 < 3);
          lVar4 = this.targetSpePoisonData;
          if (lVar4 != null) {
            if ((lVar4.leftTime < 1) && (!lVar4.finished)) {
              if ((((this.spePoisonUI != null) &&
                   (lVar4 = GameObject.get_transform(this.spePoisonUI,0)) != null) &&
                  (lVar4 = Transform.Find(lVar4,"RateInfo",0)) != null) &&
                 (lVar4 = Transform.Find(lVar4,"Rate",0)) != null) {
                uVar6 = Component.GetComponent(lVar4,DAT_181d6d8c0);
                local_78 = SpePoisonController.GetTotalScore(this,0);
                uVar5 = Single.ToString(&local_78,"f0",0);
                fVar11 = (float)SpePoisonController.GetTotalScore(this,0);
                uVar12 = Mathf.Max(0x3f800000,fVar11 * 0.05,0);
                fVar11 = (float)Mathf.Log(uVar12,0x40000000,0);
                uVar5 = GlobalData.GenerateRareLvColorText(uVar5,(int)fVar11,0);
                LTLocalization.SetText(uVar6,uVar5,0);
                if (((this.spePoisonUI != null) &&
                    (lVar4 = GameObject.get_transform(this.spePoisonUI,0)) != null) &&
                   ((lVar4 = Transform.Find(lVar4,"StartButton",0), lVar4 != null &&
                    (lVar4 = Transform.Find(lVar4,"Label",0)) != null))) {
                  uVar5 = Component.GetComponent(lVar4,DAT_181d6d8c0);
                  uVar6 = "炼蛊";
                  if (this.spePoisonType == null) {
                    uVar6 = "引毒";
                  }
                  LTLocalization.SetText(uVar5,uVar6,0);
                  if (((this.spePoisonUI != null) &&
                      (lVar4 = GameObject.get_transform(this.spePoisonUI,0)) != null) &&
                     (lVar4 = Transform.Find(lVar4,"StartButton",0)) != null) {
                    lVar4 = Component.GetComponent(lVar4,DAT_181d6af40);
                    uVar1 = SpePoisonController.CanStart(this,0);
                    if (lVar4 != null) {
                      Selectable.set_interactable(lVar4,uVar1,0);
                      if (((this.spePoisonUI != null) &&
                          (lVar4 = GameObject.get_transform(this.spePoisonUI,0)) != null
                          ) && ((lVar4 = Transform.Find(lVar4,"StartButton",0), lVar4 != null &&
                                (lVar4 = Transform.Find(lVar4,"CostTime",0)) != null))) {
                        uVar5 = Component.GetComponent(lVar4,DAT_181d6d8c0);
                        cVar2 = SpePoisonController.CanStart(this,0);
                        uVar6 = "";
                        if (cVar2) {
                          local_res20[0] = SpePoisonController.GetCostTime(this,0);
                          uVar6 = Int32.ToString(local_res20,0);
                          uVar6 = String.Concat("消耗天数 ",uVar6,0);
                        }
                        LTLocalization.SetText(uVar5,uVar6,0);
                        lVar4 = this.materialIcon;
                        if (lVar4 != null) {
                          while ((int)uVar3 < lVar4.leftTime) {
                            if (this.spePoisonUI == null) throw; // [null/range check failed]
                            lVar4 = GameObject.get_transform(this.spePoisonUI,0);
                            uVar6 = Int32.ToString(local_res18,0);
                            uVar6 = String.Concat("Material",uVar6,0);
                            if (((lVar4 == null) || (lVar4 = Transform.Find(lVar4,uVar6,0)) == null) ||
                               (lVar4 = Component.GetComponent(lVar4,DAT_181d6af40)) == null)
                            throw; // [null/range check failed]
                            Selectable.set_interactable(lVar4,1,0);
                            if (this.spePoisonUI == null) throw; // [null/range check failed]
                            lVar4 = GameObject.get_transform(this.spePoisonUI,0);
                            uVar6 = Int32.ToString(local_res18,0);
                            uVar6 = String.Concat("Material",uVar6,0);
                            if (((lVar4 == null) || (lVar4 = Transform.Find(lVar4,uVar6,0)) == null) ||
                               (lVar4 = Transform.Find(lVar4,"Cancel",0)) == null)
                            throw; // [null/range check failed]
                            lVar7 = Component.get_gameObject(lVar4,0);
                            lVar4 = this.materialIcon;
                            lVar10 = (int64)(int)local_res18[0];
                            if (lVar4 == null) throw; // [null/range check failed]
                            if (lVar4.leftTime <= local_res18[0]) {
                              ThrowHelper.ThrowArgumentOutOfRangeException(0);
                            }
                            uVar6 = *(uint64 *)(lVar4.material + 32 + lVar10 * 8);
                            uVar1 = Object.op_Inequality(uVar6,0,0);
                            if ((lVar7 == null) ||
                               (GameObject.SetActive(lVar7,uVar1,0), this.materialIcon == null))
                            throw; // [null/range check failed]
                            uVar6 = FUN_180002f80();
                            cVar2 = Object.op_Inequality(uVar6);
                            if (cVar2) {
                              if ((((this.materialIcon == null) ||
                                   (lVar4 = FUN_180002f80(this.materialIcon,local_res18[0]),
                                   lVar4 == null)) ||
                                  (lVar4 = GameObject.get_transform(lVar4,0)) == null) ||
                                 (lVar4 = Component.GetComponent(lVar4)) == null) throw; // [null/range check failed]
                              CanvasGroup.set_alpha(lVar4,0x3f800000);
                            }
                            lVar4 = this.materialIcon;
                            uVar3 = local_res18[0] + 1;
                            local_res18[0] = uVar3;
                            if (lVar4 == null) throw; // [null/range check failed]
                          }
                          cVar2 = SpePoisonController.CanStart(this,0);
                          lVar4 = this.spePoisonUI;
                          if (!cVar2) {
                            if (((lVar4 == null) || (lVar4 = GameObject.get_transform(lVar4,0)) == null)
                               || (lVar4 = Transform.Find(lVar4,"ResultIcon",0)) == null) {
        LAB_180980063:
                          // WARNING: Subroutine does not return
                              FUN_1800d6620();
                            }
                            plVar8 = (int64 *)Component.GetComponent(lVar4,DAT_181d6bc40);
                            puVar9 = (uint32 *)FUN_180d904c0(&local_58,0);
                            if (plVar8 == (int64 *)0) goto LAB_180980063;
                            local_58 = *puVar9;
                            uStack_54 = puVar9[1];
                            uStack_50 = puVar9[2];
                            uStack_4c = puVar9[3];
                            (**(code **)(*plVar8 + 0x2a8))
                                      (plVar8,&local_58,*(uint64 *)(*plVar8 + 0x2b0));
                            if (((this.spePoisonUI == null) ||
                                (lVar4 = GameObject.get_transform(this.spePoisonUI,0),
                                lVar4 == null)) ||
                               (lVar4 = Transform.Find(lVar4,"ResultBack",0)) == null)
                            goto LAB_180980063;
                            plVar8 = (int64 *)Component.GetComponent(lVar4,DAT_181d6bc40);
                            local_70 = 0;
                            uStack_68 = 0;
                            FUN_1809981e0(&local_70,0x3f800000,0x3f800000,0x3f800000,0x3f19999a,0);
                            if (plVar8 == (int64 *)0) goto LAB_180980063;
                            local_58 = (uint32)local_70;
                            uStack_54 = local_70._4_4_;
                            uStack_50 = (uint32)uStack_68;
                            uStack_4c = uStack_68._4_4_;
                          }
                          else {
                            if (((lVar4 == null) || (lVar4 = GameObject.get_transform(lVar4,0)) == null)
                               || (lVar4 = Transform.Find(lVar4,"ResultIcon",0)) == null) {
        LAB_180980069:
                          // WARNING: Subroutine does not return
                              FUN_1800d6620();
                            }
                            lVar4 = Component.GetComponent(lVar4,DAT_181d6bc40);
                            lVar7 = *pStatics_6270;
                            fVar11 = (float)SpePoisonController.GetTotalScore(this,0);
                            uVar12 = Mathf.Max(0x3f800000,fVar11 * 0.05,0);
                            fVar11 = (float)Mathf.Log(uVar12,0x40000000,0);
                            local_res20[0] = Mathf.Clamp((int)fVar11,0,5);
                            uVar6 = Int32.ToString(local_res20,0);
                            uVar6 = String.Concat("毒物_",uVar6,0);
                            if ((lVar7 == null) ||
                               (uVar6 = TextureController.LoadAtlasSprite(lVar7,"IconAtlas",uVar6,0),
                               lVar4 == null)) goto LAB_180980069;
                            Image.set_sprite(lVar4,uVar6,0);
                            if ((this.spePoisonUI == null) ||
                               ((lVar4 = GameObject.get_transform(this.spePoisonUI,0),
                                lVar4 == null || (lVar4 = Transform.Find(lVar4,"ResultIcon",0)) == null
                                ))) goto LAB_180980069;
                            plVar8 = (int64 *)Component.GetComponent(lVar4,DAT_181d6bc40);
                            local_70 = 0;
                            uStack_68 = 0;
                            FUN_1809981e0(&local_70,0,0,0,0x3f19999a,0);
                            if (plVar8 == (int64 *)0) goto LAB_180980069;
                            local_58 = (uint32)local_70;
                            uStack_54 = local_70._4_4_;
                            uStack_50 = (uint32)uStack_68;
                            uStack_4c = uStack_68._4_4_;
                            (**(code **)(*plVar8 + 0x2a8))
                                      (plVar8,&local_58,*(uint64 *)(*plVar8 + 0x2b0));
                            if (((this.spePoisonUI == null) ||
                                (lVar4 = GameObject.get_transform(this.spePoisonUI,0),
                                lVar4 == null)) ||
                               (lVar4 = Transform.Find(lVar4,"ResultBack",0)) == null)
                            goto LAB_180980069;
                            plVar8 = (int64 *)Component.GetComponent(lVar4,DAT_181d6bc40);
                            puVar9 = (uint32 *)FUN_181098a50(&local_58,0);
                            if (plVar8 == (int64 *)0) goto LAB_180980069;
                            local_58 = *puVar9;
                            uStack_54 = puVar9[1];
                            uStack_50 = puVar9[2];
                            uStack_4c = puVar9[3];
                          }
                          (**(code **)(*plVar8 + 0x2a8))
                                    (plVar8,&local_58,*(uint64 *)(*plVar8 + 0x2b0));
                          if ((((this.spePoisonUI != null) &&
                               (lVar4 = GameObject.get_transform(this.spePoisonUI,0),
                               lVar4 != null)) &&
                              (lVar4 = Transform.Find(lVar4,"ResultBack",0)) != null) &&
                             (lVar4 = Component.GetComponent(lVar4,DAT_181d6dc40)) != null) {
                            UITweener.ResetToBeginning(lVar4,0);
                            if (((this.spePoisonUI != null) &&
                                (lVar4 = GameObject.get_transform(this.spePoisonUI,0),
                                lVar4 != null)) &&
                               ((lVar4 = Transform.Find(lVar4,"ResultBack",0), lVar4 != null &&
                                (lVar4 = Component.GetComponent(lVar4,DAT_181d6dc40)) != null))) {
                              Behaviour.set_enabled(lVar4,0,0);
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
            else if ((this.spePoisonUI != null) &&
                    (((lVar4 = GameObject.get_transform(this.spePoisonUI,0), lVar4 != null &&
                      (lVar4 = Transform.Find(lVar4,"RateInfo",0)) != null) &&
                     (lVar4 = Transform.Find(lVar4,"Rate",0)) != null))) {
              uVar6 = Component.GetComponent(lVar4,DAT_181d6d8c0);
              if (this.targetSpePoisonData != null) {
                local_78 = SpePoisonData.GetTotalScore
                                     (this.targetSpePoisonData,this.spePoisonType,0);
                uVar5 = Single.ToString(&local_78,"f0",0);
                if (this.targetSpePoisonData != null) {
                  fVar11 = (float)SpePoisonData.GetScoreLv
                                            (this.targetSpePoisonData,this.spePoisonType
                                             ,0);
                  uVar5 = GlobalData.GenerateRareLvColorText(uVar5,(int)fVar11,0);
                  LTLocalization.SetText(uVar6,uVar5,0);
                  if (this.targetSpePoisonData != null) {
                    lVar4 = this.spePoisonUI;
                    if (!this.targetSpePoisonData.finished) {
                      if (((lVar4 == null) || (lVar4 = GameObject.get_transform(lVar4,0)) == null) ||
                         ((lVar4 = Transform.Find(lVar4,"StartButton",0), lVar4 == null ||
                          (lVar4 = Transform.Find(lVar4,"Label",0)) == null)))
                      throw; // [null/range check failed]
                      uVar5 = Component.GetComponent(lVar4,DAT_181d6d8c0);
                      uVar6 = "炼蛊中";
                      if (this.spePoisonType == null) {
                        uVar6 = "引毒中";
                      }
                      LTLocalization.SetText(uVar5,uVar6,0);
                      if ((((this.spePoisonUI == null) ||
                           (lVar4 = GameObject.get_transform(this.spePoisonUI,0), lVar4 == null
                           )) || (lVar4 = Transform.Find(lVar4,"StartButton",0)) == null) ||
                         (lVar4 = Component.GetComponent(lVar4,DAT_181d6af40)) == null)
                      throw; // [null/range check failed]
                      Selectable.set_interactable(lVar4,0,0);
                      if (((this.spePoisonUI == null) ||
                          (lVar4 = GameObject.get_transform(this.spePoisonUI,0)) == null
                          ) || ((lVar4 = Transform.Find(lVar4,"StartButton",0), lVar4 == null ||
                                (lVar4 = Transform.Find(lVar4,"CostTime",0)) == null)))
                      throw; // [null/range check failed]
                      uVar6 = Component.GetComponent(lVar4,DAT_181d6d8c0);
                      if (this.targetSpePoisonData == null) throw; // [null/range check failed]
                      uVar5 = Int32.ToString(this.targetSpePoisonData + 24,0);
                      uVar5 = String.Concat("剩余天数 ",uVar5,0);
                      LTLocalization.SetText(uVar6,uVar5,0);
                      if (((this.spePoisonUI == null) ||
                          (lVar4 = GameObject.get_transform(this.spePoisonUI,0)) == null
                          ) || ((lVar4 = Transform.Find(lVar4,"ResultBack",0), lVar4 == null ||
                                (lVar4 = Component.GetComponent(lVar4,DAT_181d6dc40)) == null)))
                      throw; // [null/range check failed]
                      UITweener.PlayForward(lVar4,0);
                    }
                    else {
                      if (((lVar4 == null) || (lVar4 = GameObject.get_transform(lVar4,0)) == null) ||
                         ((lVar4 = Transform.Find(lVar4,"StartButton",0), lVar4 == null ||
                          (lVar4 = Transform.Find(lVar4,"Label",0)) == null)))
                      throw; // [null/range check failed]
                      uVar6 = Component.GetComponent(lVar4,DAT_181d6d8c0);
                      LTLocalization.SetText(uVar6,"大功告成",0);
                      if ((((this.spePoisonUI == null) ||
                           (lVar4 = GameObject.get_transform(this.spePoisonUI,0), lVar4 == null
                           )) || (lVar4 = Transform.Find(lVar4,"StartButton",0)) == null) ||
                         (lVar4 = Component.GetComponent(lVar4,DAT_181d6af40)) == null)
                      throw; // [null/range check failed]
                      Selectable.set_interactable(lVar4,1,0);
                      if (((this.spePoisonUI == null) ||
                          (lVar4 = GameObject.get_transform(this.spePoisonUI,0)) == null
                          ) || (lVar4 = Transform.Find(lVar4,"Result",0)) == null)
                      throw; // [null/range check failed]
                      uVar6 = Component.get_gameObject(lVar4,0);
                      if (this.targetSpePoisonData == null) throw; // [null/range check failed]
                      SpePoisonController.CreateSpePoisonItemIcon
                                (this,uVar6,this.targetSpePoisonData.result,0);
                      if (((this.spePoisonUI == null) ||
                          (lVar4 = GameObject.get_transform(this.spePoisonUI,0)) == null
                          ) || ((lVar4 = Transform.Find(lVar4,"StartButton",0), lVar4 == null ||
                                (lVar4 = Transform.Find(lVar4,"CostTime",0)) == null)))
                      throw; // [null/range check failed]
                      uVar6 = Component.GetComponent(lVar4,DAT_181d6d8c0);
                      LTLocalization.SetText(uVar6,"",0);
                      if ((((this.spePoisonUI == null) ||
                           (lVar4 = GameObject.get_transform(this.spePoisonUI,0), lVar4 == null
                           )) || (lVar4 = Transform.Find(lVar4,"ResultBack",0)) == null) ||
                         (lVar4 = Component.GetComponent(lVar4,DAT_181d6dc40)) == null)
                      throw; // [null/range check failed]
                      UITweener.ResetToBeginning(lVar4,0);
                      if (((this.spePoisonUI == null) ||
                          (lVar4 = GameObject.get_transform(this.spePoisonUI,0)) == null
                          ) || ((lVar4 = Transform.Find(lVar4,"ResultBack",0), lVar4 == null ||
                                (lVar4 = Component.GetComponent(lVar4,DAT_181d6dc40)) == null)))
                      throw; // [null/range check failed]
                      Behaviour.set_enabled(lVar4,0,0);
                    }
                    lVar4 = this.materialIcon;
                    if (lVar4 != null) {
                      while( true ) {
                        lVar7 = this.spePoisonUI;
                        if (lVar4.leftTime <= (int)uVar3) {
                          if (((lVar7 != null) && (lVar4 = GameObject.get_transform(lVar7,0)) != null)
                             && (lVar4 = Transform.Find(lVar4,"ResultIcon",0)) != null) {
                            lVar4 = Component.GetComponent(lVar4,DAT_181d6bc40);
                            lVar7 = *pStatics_6270;
                            if (this.targetSpePoisonData != null) {
                              fVar11 = (float)SpePoisonData.GetScoreLv
                                                        (this.targetSpePoisonData,
                                                         this.spePoisonType,0);
                              local_res20[0] = Mathf.Clamp((int)fVar11,0,5);
                              uVar6 = Int32.ToString(local_res20,0);
                              uVar6 = String.Concat("毒物_",uVar6,0);
                              if ((lVar7 != null) &&
                                 (uVar6 = TextureController.LoadAtlasSprite(lVar7,"IconAtlas",uVar6,0),
                                 lVar4 != null)) {
                                Image.set_sprite(lVar4,uVar6,0);
                                if ((this.spePoisonUI != null) &&
                                   ((lVar4 = GameObject.get_transform(this.spePoisonUI,0),
                                    lVar4 != null &&
                                    (lVar4 = Transform.Find(lVar4,"ResultIcon",0)) != null))) {
                                  plVar8 = (int64 *)Component.GetComponent(lVar4,DAT_181d6bc40);
                                  local_70 = 0;
                                  uStack_68 = 0;
                                  FUN_1809981e0(&local_70,0,0,0,0x3f19999a,0);
                                  if (plVar8 != (int64 *)0) {
                                    local_58 = (uint32)local_70;
                                    uStack_54 = local_70._4_4_;
                                    uStack_50 = (uint32)uStack_68;
                                    uStack_4c = uStack_68._4_4_;
                                    (**(code **)(*plVar8 + 0x2a8))
                                              (plVar8,&local_58,*(uint64 *)(*plVar8 + 0x2b0));
                                    if (((this.spePoisonUI != null) &&
                                        (lVar4 = GameObject.get_transform
                                                           (this.spePoisonUI,0), lVar4 != null))
                                       && (lVar4 = Transform.Find(lVar4,"ResultBack",0)) != null) {
                                      plVar8 = (int64 *)Component.GetComponent(lVar4,DAT_181d6bc40);
                                      puVar9 = (uint32 *)FUN_181098a50(&local_58,0);
                                      if (plVar8 != (int64 *)0) {
                                        local_58 = *puVar9;
                                        uStack_54 = puVar9[1];
                                        uStack_50 = puVar9[2];
                                        uStack_4c = puVar9[3];
                                        (**(code **)(*plVar8 + 0x2a8))
                                                  (plVar8,&local_58,*(uint64 *)(*plVar8 + 0x2b0));
                                        return;
                                      }
                                    }
                                  }
                                }
                              }
                            }
                          }
                          // WARNING: Subroutine does not return
                          FUN_1800d6620();
                        }
                        if (lVar7 == null) break;
                        lVar4 = GameObject.get_transform(lVar7,0);
                        uVar6 = Int32.ToString(local_res8,0);
                        uVar6 = String.Concat("Material",uVar6,0);
                        if (((lVar4 == null) || (lVar4 = Transform.Find(lVar4,uVar6,0)) == null) ||
                           (lVar4 = Component.GetComponent(lVar4,DAT_181d6af40)) == null) break;
                        Selectable.set_interactable(lVar4,0,0);
                        lVar4 = this.materialIcon;
                        lVar7 = (int64)(int)local_res8[0];
                        if (lVar4 == null) break;
                        if (lVar4.leftTime <= local_res8[0]) {
                          ThrowHelper.ThrowArgumentOutOfRangeException(0);
                        }
                        uVar6 = *(uint64 *)(lVar4.material + 32 + lVar7 * 8);
                        cVar2 = Object.op_Equality(uVar6,0,0);
                        if (cVar2) {
                          if ((this.targetSpePoisonData == null) ||
                             (lVar4 = this.targetSpePoisonData.material) == null)
                          break;
                          lVar4 = FUN_180002f80(lVar4,local_res8[0],DAT_181d69770);
                          uVar3 = local_res8[0];
                          if (lVar4 != null) {
                            if ((this.targetSpePoisonData == null) ||
                               (lVar4 = this.targetSpePoisonData.material) == null)
                            break;
                            uVar6 = FUN_180002f80(lVar4,local_res8[0],DAT_181d69770);
                            SpePoisonController.CreateSpePoisonMaterialItemIcon(this,uVar3,uVar6);
                          }
                        }
                        if (this.spePoisonUI == null) break;
                        lVar4 = GameObject.get_transform(this.spePoisonUI,0);
                        uVar6 = Int32.ToString(local_res8,0);
                        uVar6 = String.Concat("Material",uVar6,0);
                        if ((((lVar4 == null) || (lVar4 = Transform.Find(lVar4,uVar6,0)) == null) ||
                            (lVar4 = Transform.Find(lVar4,"Cancel",0)) == null) ||
                           (lVar4 = Component.get_gameObject(lVar4,0)) == null) break;
                        GameObject.SetActive(lVar4,0,0);
                        if (this.materialIcon == null) break;
                        uVar6 = FUN_180002f80(this.materialIcon,local_res8[0],DAT_181d62178);
                        cVar2 = Object.op_Inequality(uVar6,0,0);
                        if (cVar2) {
                          if (((this.materialIcon == null) ||
                              (lVar4 = FUN_180002f80(this.materialIcon,local_res8[0],
                                                     DAT_181d62178), lVar4 == null)) ||
                             (lVar4 = GameObject.get_transform(lVar4,0)) == null) break;
                          lVar4 = Component.GetComponent(lVar4);
                          if (this.targetSpePoisonData == null) break;
                          if (!this.targetSpePoisonData.finished) {
                            uVar12 = 0x3f800000;
                          }
                          else {
                            uVar12 = 0x3f333333;
                          }
                          if (lVar4 == null) break;
                          CanvasGroup.set_alpha(lVar4,uVar12,0);
                        }
                        lVar4 = this.materialIcon;
                        uVar3 = local_res8[0] + 1;
                        local_res8[0] = uVar3;
                        if (lVar4 == null) break;
                      }
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x60020EC
    // RVA   : 0x97DBE0   Offset: 0x97C3E0   Length: 0x109
    public bool CanStart()
    {
        ulong uVar1;
        bool cVar2;
        long lVar3;
        uint uVar4;
        int iVar5;
        long lVar6;
        lVar3 = this.materialIcon;
        iVar5 = 0;
        uVar4 = 0;
        if (lVar3 != null) {
          lVar6 = 32;
          do {
            if (lVar3.Count <= (int)uVar4) {
              if (this.spePoisonType == null) {
                bVar7 = SBORROW4(iVar5,1);
                iVar5 = iVar5 + -1;
              }
              else {
                bVar7 = SBORROW4(iVar5,2);
                iVar5 = iVar5 + -2;
              }
              return CONCAT71((int7)((uint64)lVar3 >> 8),bVar7 == iVar5 < 0);
            }
            if (lVar3 == null) break;
            if (lVar3.Count <= uVar4) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            uVar1 = *(uint64 *)(lVar6 + lVar3._items);
            cVar2 = Object.op_Inequality(uVar1,0,0);
            if (cVar2) {
              iVar5 = iVar5 + 1;
            }
            lVar3 = this.materialIcon;
            uVar4 = uVar4 + 1;
            lVar6 = lVar6 + 8;
          } while (lVar3 != null);
        }
    }

    // Token : 0x60020ED
    // RVA   : 0x97E250   Offset: 0x97CA50   Length: 0x144
    public int GetCostTime()
    {
        bool cVar1;
        int iVar2;
        long lVar3;
        int iVar4;
        long lVar5;
        uint uVar6;
        lVar3 = this.materialIcon;
        uVar6 = 0;
        iVar4 = 10;
        if (lVar3 != null) {
          lVar5 = 32;
          while( true ) {
            if (lVar3.Count <= (int)uVar6) {
              return iVar4;
            }
            if (lVar3 == null) break;
            if (lVar3.Count <= uVar6) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar3 = *(int64 *)(lVar5 + lVar3._items);
            cVar1 = Object.op_Inequality(lVar3,0,0);
            if (!cVar1) {
              iVar2 = 0;
            }
            else {
              if (((lVar3 == null) || (lVar3 = GameObject.GetComponent(lVar3)) == null) ||
                 (*(int64 *)(lVar3 + 32) == 0)) break;
              iVar2 = *(int *)(*(int64 *)(lVar3 + 32) + 60);
            }
            iVar4 = iVar4 + iVar2;
            uVar6 = uVar6 + 1;
            lVar3 = this.materialIcon;
            lVar5 = lVar5 + 8;
            if (lVar3 == null) break;
          }
        }
    }

    // Token : 0x60020EE
    // RVA   : 0x97E440   Offset: 0x97CC40   Length: 0x98
    public int GetMaterialTime(GameObject targetItem)
    {
        bool cVar1;
        long lVar2;
        cVar1 = Object.op_Inequality(targetItem,0,0);
        if (!cVar1) {
          return 0;
        }
        if (targetItem != null) {
          lVar2 = GameObject.GetComponent(targetItem,DAT_181da0070);
          if ((lVar2 != null) && (*(int64 *)(lVar2 + 32) != 0)) {
            return *(uint32 *)(*(int64 *)(lVar2 + 32) + 60);
          }
        }
    }

    // Token : 0x60020EF
    // RVA   : 0x97E520   Offset: 0x97CD20   Length: 0x168
    public float GetTotalScore()
    {
        bool cVar1;
        long lVar2;
        long lVar3;
        uint uVar4;
        float fVar5;
        float fVar6;
        lVar2 = this.materialIcon;
        uVar4 = 0;
        fVar6 = 0.0;
        if (lVar2 != null) {
          lVar3 = 32;
          while( true ) {
            if (lVar2.Count <= (int)uVar4) {
              if (this.spePoisonType == null) {
                fVar6 = fVar6 * 0.5;
              }
              else {
                fVar6 = fVar6 * 1.0;
              }
              return fVar6;
            }
            if (lVar2 == null) break;
            if (lVar2.Count <= uVar4) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar2 = *(int64 *)(lVar3 + lVar2._items);
            cVar1 = Object.op_Inequality(lVar2,0,0);
            if (!cVar1) {
              fVar5 = 0.0;
            }
            else {
              if (((lVar2 == null) || (lVar2 = GameObject.GetComponent(lVar2)) == null) ||
                 (*(int64 *)(lVar2 + 32) == 0)) break;
              fVar5 = (float)*(int *)(*(int64 *)(lVar2 + 32) + 56);
            }
            lVar2 = this.materialIcon;
            fVar6 = fVar6 + fVar5;
            uVar4 = uVar4 + 1;
            lVar3 = lVar3 + 8;
            if (lVar2 == null) break;
          }
        }
    }

    // Token : 0x60020F0
    // RVA   : 0x97E3A0   Offset: 0x97CBA0   Length: 0x9E
    public float GetMaterialScore(GameObject targetItem)
    {
        bool cVar1;
        long lVar2;
        cVar1 = Object.op_Inequality(targetItem,0,0);
        if (!cVar1) {
          return;
        }
        if (targetItem != null) {
          lVar2 = GameObject.GetComponent(targetItem,DAT_181da0070);
          if ((lVar2 != null) && (*(int64 *)(lVar2 + 32) != 0)) {
            return;
          }
        }
    }

    // Token : 0x60020F1
    // RVA   : 0x97E4E0   Offset: 0x97CCE0   Length: 0x3A
    public float GetScoreLv()
    {
        float fVar1;
        uint uVar2;
        fVar1 = (float)SpePoisonController.GetTotalScore(this,0);
        uVar2 = Mathf.Max(0x3f800000,fVar1 * 0.05,0);
        Mathf.Log(uVar2,0x40000000,0);
    }

    // Token : 0x60020F2
    // RVA   : 0x97E690   Offset: 0x97CE90   Length: 0x2D
    public void HideSpePoisonUI()
    {
        SpePoisonController.ClearAllSpePoisonMaterial(this,0);
        if (this.spePoisonUI != null) {
          GameObject.SetActive(this.spePoisonUI,0,0);
          return;
        }
    }

    // Token : 0x60020F3
    // RVA   : 0x980070   Offset: 0x97E870   Length: 0xAF
    public void ShowSpePoisonUI()
    {
        if (this.spePoisonUI != null) {
          GameObject.SetActive(this.spePoisonUI,1,0);
          SpePoisonController.RefreshUI(this,0);
          plVar1 = (int64 *)Resources.Load("Sound/SoundEffect/OpenBook",0);
          plVar2 = (int64 *)0;
          if ((plVar1 != (int64 *)0) && (*plVar1 == DAT_181d8a228)) {
            plVar2 = plVar1;
          }
          NGUITools.PlaySound(plVar2,0);
          return;
        }
    }

    // Token : 0x60020F4
    // RVA   : 0x9801D0   Offset: 0x97E9D0   Length: 0x123
    public void SpePoisonTypeButtonClicked(GameObject buttonClicked)
    {
        int iVar1;
        int iVar2;
        uint uVar3;
        long lVar4;
        ulong uVar5;
        if (buttonClicked != null) {
          lVar4 = GameObject.GetComponent(buttonClicked,DAT_181da2130);
          if (lVar4 != null) {
            if (*(char *)(lVar4 + 0x118) != false) {
              iVar1 = this.spePoisonType;
              uVar5 = Object.get_name(buttonClicked,0);
              iVar2 = Int32.Parse(uVar5,0);
              if (iVar1 != iVar2) {
                SpePoisonController.ClearAllSpePoisonMaterial(this,0);
                uVar5 = Object.get_name(buttonClicked,0);
                uVar3 = Int32.Parse(uVar5,0);
                this.spePoisonType = uVar3;
                this.needRefresh = 1;
              }
              plVar6 = (int64 *)Resources.Load("Sound/SoundEffect/Button/TabButton",0);
              plVar7 = (int64 *)0;
              if ((plVar6 != (int64 *)0) && (*plVar6 == DAT_181d8a228)) {
                plVar7 = plVar6;
              }
              NGUITools.PlaySound(plVar7,0);
            }
            return;
          }
        }
    }

    // Token : 0x60020F5
    // RVA   : 0x97DCF0   Offset: 0x97C4F0   Length: 0x1EE
    public void ClearAllSpePoisonMaterial()
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        uint uVar4;
        long lVar5;
        lVar2 = this.materialIcon;
        uVar4 = 0;
        if (lVar2 != null) {
          lVar5 = 32;
          do {
            if (lVar2.Count <= (int)uVar4) {
              if (((this.spePoisonUI != null) &&
                  (lVar2 = GameObject.get_transform(this.spePoisonUI,0)) != null) &&
                 (lVar2 = Transform.Find(lVar2,"Result",0)) != null) {
                uVar3 = Component.get_gameObject(lVar2,0);
                GlobalData.DeleteAllChild(uVar3,0);
                return;
              }
              break;
            }
            if (!DAT_181e781f0) {
              il2cpp_runtime_class_init(&DAT_181d62178);
              il2cpp_runtime_class_init(&DAT_181d62278);
              il2cpp_runtime_class_init(&DAT_181d68fe8);
              lVar2 = this.materialIcon;
              DAT_181e781f0 = true;
            }
            if (lVar2 == null) break;
            if (lVar2.Count <= uVar4) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            uVar3 = *(uint64 *)(lVar5 + lVar2._items);
            cVar1 = Object.op_Inequality(uVar3);
            if (cVar1) {
              lVar2 = this.materialIcon;
              if (lVar2 == null) break;
              if (lVar2.Count <= uVar4) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              uVar3 = *(uint64 *)(lVar5 + lVar2._items);
              Object.Destroy(uVar3,0);
              if (this.materialIcon == null) break;
              FUN_18182f280();
              this.needRefresh = 1;
            }
            lVar2 = this.materialIcon;
            uVar4 = uVar4 + 1;
            lVar5 = lVar5 + 8;
          } while (lVar2 != null);
        }
    }

    // Token : 0x60020F6
    // RVA   : 0x97E140   Offset: 0x97C940   Length: 0x10A
    public void CreateSpePoisonMaterialItemIcon(int id, ItemData targetItemData)
    {
        void SpePoisonController.CreateSpePoisonMaterialItemIcon
                     (int64 this,uint32 id,uint64 targetItemData)
        {
        int64 lVar1;
        uint32 uVar2;
        int64 lVar3;
        uint64 uVar4;
        uint32 local_res10 [2];
        local_res10[0] = id;
        uVar2 = local_res10[0];
        lVar1 = this.materialIcon;
        if (this.spePoisonUI != null) {
          lVar3 = GameObject.get_transform(this.spePoisonUI,0);
          uVar4 = Int32.ToString(local_res10,0);
          uVar4 = String.Concat("Material",uVar4,0);
          if (lVar3 != null) {
            lVar3 = Transform.Find(lVar3,uVar4,0);
            if (lVar3 != null) {
              lVar3 = Transform.Find(lVar3,"Icon",0);
              if (lVar3 != null) {
                uVar4 = Component.get_gameObject(lVar3,0);
                uVar4 = SpePoisonController.CreateSpePoisonItemIcon(this,uVar4,targetItemData,0);
                if (lVar1 != null) {
                  FUN_18182f280(lVar1,uVar2,uVar4,DAT_181d62278);
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x60020F7
    // RVA   : 0x97E010   Offset: 0x97C810   Length: 0x12A
    public GameObject CreateSpePoisonItemIcon(GameObject parent, ItemData targetItemData)
    {
        var pStatics = *(int64*)(DAT_181d4e188 + 184);
        int64 SpePoisonController.CreateSpePoisonItemIcon
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

    // Token : 0x60020F8
    // RVA   : 0x97E6C0   Offset: 0x97CEC0   Length: 0x1F7
    public void MaterialButtonClicked(int id)
    {
        long lVar1;
        uint uVar2;
        bool cVar3;
        long lVar4;
        ulong uVar5;
        ulong uVar6;
        uint[] local_res8 = new uint[2];
        uint[] local_res10 = new uint[2];
        uint[] local_res20 = new uint[2];
        local_res10[0] = id;
        uVar2 = local_res10[0];
        lVar1 = this.materialIcon;
        if (lVar1 == null) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        if (lVar1.Count <= local_res10[0]) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        uVar5 = lVar1._items[uVar2];
        cVar3 = Object.op_Inequality(uVar5,0,0);
        if (cVar3) {
          return;
        }
        lVar1 = **(int64 **)(DAT_181d92370 + 184);
        lVar4 = il2cpp_internal(DAT_181d701b0);
        FUN_180f58a90(lVar4,DAT_181d6dfe8);
        local_res8[0] = 0;
        uVar5 = il2cpp_value_box(DAT_181d5b2f8,local_res8);
        if (lVar4 != null) {
          FUN_181827900(lVar4,uVar5,DAT_181d6e0e8);
          local_res20[0] = 5;
          uVar5 = il2cpp_value_box(DAT_181d5b2f8,local_res20);
          FUN_181827900(lVar4,uVar5,DAT_181d6e0e8);
          uVar5 = Component.get_gameObject(this,0);
          uVar6 = Int32.ToString(local_res10,0);
          if (lVar1 != null) {
            ChooseController.ShowChoosePanel(lVar1,1,lVar4,uVar5,"SpePoisonMaterialChoosen",uVar6,20,0,0,0);
            return;
          }
        }
    }

    // Token : 0x60020F9
    // RVA   : 0x980120   Offset: 0x97E920   Length: 0xA9
    public void SpePoisonMaterialChoosen(string id)
    {
        var pStatics = *(int64*)(DAT_181d92370 + 184);
        uint uVar1;
        long lVar2;
        uVar1 = Int32.Parse(id,0);
        if ((*pStatics != 0) &&
           (lVar2 = *(int64 *)(*pStatics + 72)) != null) {
          lVar2 = GameObject.GetComponent(lVar2,DAT_181da0070);
          if (lVar2 != null) {
            SpePoisonController.CreateSpePoisonMaterialItemIcon
                      (this,uVar1,*(uint64 *)(lVar2 + 32),0);
            this.needRefresh = 1;
            return;
          }
        }
    }

    // Token : 0x60020FA
    // RVA   : 0x97DEE0   Offset: 0x97C6E0   Length: 0x123
    public void ClearSpePoisonMaterial(int id)
    {
        long lVar1;
        long lVar2;
        ulong uVar3;
        bool cVar4;
        lVar2 = this.materialIcon;
        if (lVar2 != null) {
          if (lVar2.Count <= id) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar1 = (int64)(int)id * 8 + 32;
          uVar3 = *(uint64 *)(lVar1 + lVar2._items);
          cVar4 = Object.op_Inequality(uVar3,0,0);
          if (!cVar4) {
            return;
          }
          lVar2 = this.materialIcon;
          if (lVar2 != null) {
            if (lVar2.Count <= id) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            uVar3 = *(uint64 *)(lVar1 + lVar2._items);
            Object.Destroy(uVar3,0);
            if (this.materialIcon != null) {
              FUN_18182f280(this.materialIcon,id,0,DAT_181d62278);
              this.needRefresh = 1;
              return;
            }
          }
        }
    }

    // Token : 0x60020FB
    // RVA   : 0x980300   Offset: 0x97EB00   Length: 0x3EA
    public void StartButtonClicked()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        ulong uVar1;
        bool cVar2;
        uint uVar3;
        long lVar4;
        long lVar5;
        uint uVar8;
        long lVar9;
        if (this.targetSpePoisonData != null) {
          if (!this.targetSpePoisonData.finished) {
            lVar5 = this.materialIcon;
            uVar8 = 0;
            if (lVar5 != null) {
              lVar9 = 32;
              do {
                if (lVar5.leftTime <= (int)uVar8) {
                  lVar5 = this.targetSpePoisonData;
                  uVar3 = SpePoisonController.GetCostTime(this,0);
                  if (lVar5 != null) {
                    lVar5.leftTime = uVar3;
                    goto LAB_18098067b;
                  }
                  break;
                }
                if (lVar5 == null) break;
                if (lVar5.leftTime <= uVar8) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                uVar1 = *(uint64 *)(lVar9 + lVar5.material);
                cVar2 = Object.op_Inequality(uVar1,0,0);
                lVar5 = this.targetSpePoisonData;
                if (!cVar2) {
                  if ((lVar5 == null) || (lVar5.material == null)) break;
                  FUN_18182f280();
                }
                else {
                  if (lVar5 == null) break;
                  lVar5 = lVar5.material;
                  if ((((this.materialIcon == null) ||
                       (lVar4 = FUN_180002f80(this.materialIcon,uVar8,DAT_181d62178),
                       lVar4 == null)) || (lVar4 = GameObject.GetComponent(lVar4,DAT_181da0070)) == null
                      ) || (lVar5 == null)) break;
                  FUN_18182f280(lVar5,uVar8,*(uint64 *)(lVar4 + 32),DAT_181d697f0);
                  lVar5 = FUN_18046c0a0(0);
                  if ((lVar5 == null) || (lVar5.result == null)) break;
                  lVar5 = WorldData.Player(lVar5.result,0);
                  if ((this.materialIcon == null) ||
                     (((lVar4 = FUN_180002f80(this.materialIcon,uVar8,DAT_181d62178),
                       lVar4 == null || (lVar4 = GameObject.GetComponent(lVar4,DAT_181da0070)) == null)
                      || (lVar5 == null)))) break;
                  HeroData.LoseItem(lVar5,*(uint64 *)(lVar4 + 32),1,0);
                }
                lVar5 = this.materialIcon;
                uVar8 = uVar8 + 1;
                lVar9 = lVar9 + 8;
              } while (lVar5 != null);
            }
          }
          else {
            if ((*pStatics != 0) &&
               (lVar5 = *(int64 *)(*pStatics + 32)) != null) {
              lVar5 = WorldData.Player(lVar5,0);
              if ((this.targetSpePoisonData != null) && (lVar5 != null)) {
                HeroData.GetItem(lVar5,this.targetSpePoisonData.result,0,1,
                                  0xffffffff,0,0);
                if (this.targetSpePoisonData != null) {
                  SpePoisonData.Reset(this.targetSpePoisonData,0);
                  SpePoisonController.ClearAllSpePoisonMaterial(this,0);
        LAB_18098067b:
                  plVar6 = (int64 *)Resources.Load("Sound/SoundEffect/SpeEffect/毒气",0);
                  plVar7 = (int64 *)0;
                  if ((plVar6 != (int64 *)0) && (*plVar6 == DAT_181d8a228)) {
                    plVar7 = plVar6;
                  }
                  NGUITools.PlaySound(plVar7,0);
                  this.needRefresh = 1;
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x60020FC
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
