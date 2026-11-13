// ============================================================
// Type  : CustomSkillCreateController
// Token : 0x2000261
// ============================================================

public class CustomSkillCreateController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001301
    public GameObject customSkillCreateUI;

    // Token: 0x4001302
    public int templateSkillID;

    // Token: 0x4001303
    public KungfuSkillData draftSkillData;

    // Token: 0x4001304
    public InputField skillName;

    // Token: 0x4001305
    public InputField skillDescribe;

    // Token: 0x4001306
    public Image skillIcon;

    // Token: 0x4001307
    public Text skillPointText;

    // Token: 0x4001308
    public Text manaCostText;

    // Token: 0x4001309
    public Slider internalHpManaRatioSlider;

    // Token: 0x400130A
    public GameObject externalDamageUI;

    // Token: 0x400130B
    public GameObject customSkillDamageRatioPrefab;

    // Token: 0x400130C
    public GameObject externalDamageRangeUI;

    // Token: 0x400130D
    public GameObject externalPostureUI;

    // Token: 0x400130E
    public GameObject speAddDataGrid;

    // Token: 0x400130F
    public GameObject speAddDataPrefab;

    // Token: 0x4001310
    public GameObject chooseNewSpeAddDataButton;

    // Token: 0x4001311
    public GameObject chooseUI;

    // Token: 0x4001312
    public GameObject chooseGrid;

    // Token: 0x4001313
    public GameObject chooseButtonPrefab;

    // Token: 0x4001314
    private static CustomSkillCreateController _instance;

    // Token: 0x4001315
    private static readonly int[] SpeAddNumMax;

    // Token: 0x4001316
    private static readonly float[] ManaCostRate;

    // Token: 0x4001317
    private static readonly int[] EffectBudget;

    // Token: 0x4001318
    private static readonly int[] ExternalEffectBudget;

    // Token: 0x4001319
    private static readonly int[] CreateSkillNeed;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60013A8
    // RVA   : 0x65B2A0   Offset: 0x65A0A0   Length: 0x57
    public static CustomSkillCreateController get_Instance()
    {
        return **(uint64 **)(DAT_181e9bac0 + 184);
    }

    // Token : 0x60013A9
    // RVA   : 0x655720   Offset: 0x654520   Length: 0x61
    private void Awake()
    {
        puVar1 = *(uint64 **)(DAT_181e9bac0 + 184);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x60013AA
    // RVA   : 0x65AF70   Offset: 0x659D70   Length: 0x158
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
          uVar3 = new OnTooltipCB(this,DAT_181e82790,0);
          if (lVar2 == null) {
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          RailCallBackHelper.RegisterCallback(lVar2,0x1f45,uVar3,0);
        }
    }

    // Token : 0x60013AB
    // RVA   : 0x65A6C0   Offset: 0x6594C0   Length: 0x777
    public void ShowCreatePanel(int _templateSkillID)
    {
        var pStatics_38e8 = *(int64*)(DAT_181e538e8 + 184);
        uint uVar1;
        long lVar2;
        ulong uVar3;
        long lVar4;
        ulong uVar6;
        lVar4 = *(int64 *)(*(int64 *)(DAT_181e528f8 + 184) + 32);
        if (lVar4 != null) {
          lVar4 = GameDataController.GetSkillDataBase(lVar4,_templateSkillID,0);
          this.templateSkillID = _templateSkillID;
          if (lVar4 != null) {
            plVar5 = (int64 *)KungfuSkillData.Clone(lVar4,0);
            this.draftSkillData = plVar5;
            if (this.draftSkillData != null) {
              this.draftSkillData.skillID = 0;
              if (this.draftSkillData != null) {
                this.draftSkillData.belongForceID = 0xffffffff;
                if (this.draftSkillData != null) {
                  this.draftSkillData.name = "";
                  if (this.draftSkillData != null) {
                    this.draftSkillData.describe = "";
                    if (this.draftSkillData != null) {
                      this.draftSkillData.summonID = 0xffffffff;
                      if (this.draftSkillData != null) {
                        this.draftSkillData.summonSkill = 0;
                        if (this.draftSkillData != null) {
                          this.draftSkillData.hide = 0;
                          if (this.draftSkillData != null) {
                            this.draftSkillData.battleMaxUseTime = 0;
                            lVar2 = this.draftSkillData;
                            uVar6 = KungfuSkillData.GetSkillIcon(lVar4,0);
                            if (lVar2 != null) {
                              lVar2.iconName = uVar6;
                              lVar4 = this.draftSkillData;
                              uVar6 = new HeroSpeAddData(0);
                              if (lVar4 != null) {
                                lVar4.equipAddData = uVar6;
                                lVar4 = this.draftSkillData;
                                uVar6 = new HeroSpeAddData(0);
                                if (lVar4 != null) {
                                  lVar4.useAddData = uVar6;
                                  if (this.customSkillCreateUI != null) {
                                    GameObject.SetActive(this.customSkillCreateUI,1,0);
                                    CustomSkillCreateController.RefreshSkillIcon(this,0);
                                    if (((GameController._instance != null) &&
                                        (lVar4 = *(int64 *)
                                                  (GameController._instance + 32),
                                        lVar4 != null)) && (lVar4 = WorldData.Player(lVar4,0)) != null)
                                    {
                                      uVar6 = lVar4.useAddData;
                                      lVar4 = this.draftSkillData;
                                      lVar2 = *(int64 *)(pStatics_38e8 + 0x518);
                                      if ((lVar4 != null) && (lVar2 != null)) {
                                        uVar1 = lVar4.rareLv;
                                        if (lVar2.belongForceID <= uVar1) {
                                          ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                          lVar4 = this.draftSkillData;
                                        }
                                        uVar3 = *(uint64 *)
                                                 (lVar2.summonSkill + 32 +
                                                 (int64)(int)uVar1 * 8);
                                        lVar2 = *(int64 *)(pStatics_38e8 + 0x4a8)
                                        ;
                                        if ((lVar4 != null) && (lVar2 != null)) {
                                          uVar1 = lVar4.type;
                                          if (lVar2.belongForceID <= uVar1) {
                                            ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                          }
                                          uVar6 = String.Format("{0}所创之{1}{2}",uVar6,uVar3,
                                                                 *(uint64 *)
                                                                  (lVar2.summonSkill + 32 +
                                                                  (int64)(int)uVar1 * 8),0);
                                          if (this.skillDescribe != null) {
                                            InputField.set_text(this.skillDescribe,uVar6,0);
                                            if (this.draftSkillData != null) {
                                              puVar7 = (uint64 *)
                                                       (this.draftSkillData + 40);
                                              *puVar7 = uVar6;
                                              il2cpp_internal(puVar7,uVar6);
                                            }
                                            if (this.chooseNewSpeAddDataButton != null) {
                                              lVar4 = GameObject.GetComponent
                                                                (this.chooseNewSpeAddDataButton,
                                                                 DAT_181e56510);
                                              if (this.draftSkillData != null) {
                                                uVar6 = "可复刻所有已习得外功的使用效果";
                                                if (this.draftSkillData.type < 3) {
                                                  uVar6 = "可复刻所有已习得内功/轻功/绝技的装备效果";
                                                }
                                                if (lVar4 != null) {
                                                  lVar4.belongForceID = uVar6;
                                                  lVar4 = this.draftSkillData;
                                                  if (lVar4 != null) {
                                                    if (lVar4.type < 3) {
                                                      if (this.internalHpManaRatioSlider != null) {
                                                        lVar4 = Component.get_gameObject
                                                                          (this.internalHpManaRatioSlider,0
                                                                          );
                                                        if ((this.draftSkillData != null) &&
                                                           (lVar4 != null)) {
                                                          GameObject.SetActive
                                                                    (lVar4,*(int *)(*(int64 *)
                                                                                     (this + 40) +
                                                                                   48) == 0,0);
                                                          if (this.draftSkillData != null) {
                                                            if (*(int *)(this.draftSkillData +
                                                                        48) == 0) {
                                                              plVar5 = this.internalHpManaRatioSlider;
                                                              if (plVar5 == (int64 *)0)
                                                              throw; // [null/range check failed]
                                                              (**(code **)(*plVar5 + 0x428))
                                                                        (plVar5,*(float *)(plVar5 + 34)
                                                                                * 0.5,
                                                                         *(uint64 *)(*plVar5 + 0x430))
                                                              ;

                                                        CustomSkillCreateController.InternalHpManaRatioSliderChanged
                                                                  (this,0);
                                                        }
                                                        if (this.externalDamageUI != null) {
                                                          GameObject.SetActive
                                                                    (this.externalDamageUI,0,0);
                                                          if (this.externalDamageRangeUI != null) {
                                                            GameObject.SetActive
                                                                      (this.externalDamageRangeUI,0,0);
                                                            if (this.externalPostureUI != null) {
                                                              GameObject.SetActive
                                                                        (this.externalPostureUI,0,0
                                                                        );
                                                              goto LAB_18065adaa;
                                                            }
                                                          }
                                                        }
                                                        }
                                                        }
                                                      }
                                                    }
                                                    else {
                                                      lVar4.baseDamage = 0x3f800000;
                                                      if (this.draftSkillData != null) {
                                                        uVar6 = *(uint64 *)
                                                                 (this.draftSkillData + 72);
                                                        CustomSkillCreateController.ResetAttriRatioValue
                                                                  (uVar6,0);
                                                        if ((this.internalHpManaRatioSlider != null) &&
                                                           (lVar4 = Component.get_gameObject
                                                                              (*(int64 *)
                                                                                (this + 88),0),
                                                           lVar4 != null)) {
                                                          GameObject.SetActive(lVar4,0,0);
                                                          if (this.externalDamageUI != null) {
                                                            GameObject.SetActive
                                                                      (this.externalDamageUI,1,0);

                                                        CustomSkillCreateController.RefreshBaseDamageUI
                                                                  (this,0);
                                                        CustomSkillCreateController.InitDamageRatioUI
                                                                  (this,0);
                                                        if (this.externalDamageRangeUI != null) {
                                                          GameObject.SetActive
                                                                    (this.externalDamageRangeUI,1,0);

                                                        CustomSkillCreateController.RefreshDamageRangeUI
                                                                  (this,0);
                                                        if (this.externalPostureUI != null) {
                                                          GameObject.SetActive
                                                                    (this.externalPostureUI,1,0);
                                                          CustomSkillCreateController.RefreshPostureUI
                                                                    (this,0);
        LAB_18065adaa:

                                                        CustomSkillCreateController.RefreshSpeAddDataGrid
                                                                  (this,0);
                                                        CustomSkillCreateController.RefreshSkillPointText
                                                                  (this,0);
                                                        plVar5 = (int64 *)
                                                                 Resources.Load("Sound/SoundEffect/SpeEffect/加速旋转",0);
                                                        plVar8 = (int64 *)0;
                                                        if ((plVar5 != (int64 *)0) &&
                                                           (*plVar5 == DAT_181e8f4a0)) {
                                                          plVar8 = plVar5;
                                                        }
                                                        NGUITools.PlaySound(plVar8,0);
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

    // Token : 0x60013AC
    // RVA   : 0x6593B0   Offset: 0x6581B0   Length: 0x2B6
    public void RefreshDamageRangeUI()
    {
        bool cVar1;
        long lVar2;
        uint local_18;
        uint local_14;
        uint local_10;
        lVar2 = this.draftSkillData;
        if (lVar2 != null) {
          if (((lVar2.attackRangeData == null) || (*(int *)(lVar2.attackRangeData + 24) == 0))
             || (lVar2.damageRangeData == null)) {
            return;
          }
          if (((this.externalDamageRangeUI != null) &&
              (lVar2 = GameObject.get_transform(this.externalDamageRangeUI,0)) != null) &&
             ((lVar2 = Transform.Find(lVar2,"SkillRangeUI",0), lVar2 != null &&
              (lVar2 = Component.GetComponent(lVar2,DAT_181e78eb8)) != null))) {
            SkillRangeUIController.RefreshSkillRange(lVar2,this.draftSkillData,0);
            if (((this.externalDamageRangeUI != null) &&
                (lVar2 = GameObject.get_transform(this.externalDamageRangeUI,0)) != null) &&
               ((lVar2 = Transform.Find(lVar2,"SkillRangeUI",0), lVar2 != null &&
                ((lVar2 = Transform.Find(lVar2,"1",0), lVar2 != null &&
                 (lVar2 = Component.get_gameObject(lVar2,0)) != null))))) {
              cVar1 = GameObject.get_activeSelf(lVar2,0);
              lVar2 = this.externalDamageRangeUI;
              if (!cVar1) {
                if (((lVar2 != null) && (lVar2 = GameObject.get_transform(lVar2,0)) != null) &&
                   ((lVar2 = Transform.Find(lVar2,"SkillRangeUI",0), lVar2 != null &&
                    (lVar2 = Transform.Find(lVar2,"0",0)) != null))) {
                  local_14 = 0xc2f00000;
        LAB_18065963b:
                  local_18 = 0;
                  local_10 = 0;
                  Transform.set_localPosition(lVar2,&local_18,0);
                  return;
                }
              }
              else if ((((lVar2 != null) && (lVar2 = GameObject.get_transform(lVar2,0)) != null) &&
                       (lVar2 = Transform.Find(lVar2,"SkillRangeUI",0)) != null) &&
                      (lVar2 = Transform.Find(lVar2,"0",0)) != null) {
                local_14 = 0xc2700000;
                local_18 = 0;
                local_10 = 0;
                Transform.set_localPosition(lVar2,&local_18,0);
                if (((this.externalDamageRangeUI != null) &&
                    (lVar2 = GameObject.get_transform(this.externalDamageRangeUI,0)) != null) &&
                   ((lVar2 = Transform.Find(lVar2,"SkillRangeUI",0), lVar2 != null &&
                    (lVar2 = Transform.Find(lVar2,"1",0)) != null))) {
                  local_14 = 0xc3340000;
                  goto LAB_18065963b;
                }
              }
            }
          }
        }
    }

    // Token : 0x60013AD
    // RVA   : 0x655940   Offset: 0x654740   Length: 0x1CD
    public void ChooseDamageRangeButtonClicked()
    {
        long lVar1;
        long lVar2;
        ulong uVar3;
        uint[] local_res18 = new uint[2];
        uint[] local_res20 = new uint[2];
        uint local_28;
        uint[] local_24 = new uint[3];
        lVar1 = **(int64 **)(DAT_181e977e8 + 184);
        lVar2 = il2cpp_internal(DAT_181e74e38);
        FUN_1810f3480(lVar2,DAT_181e77ae0);
        local_res18[0] = 0;
        uVar3 = il2cpp_value_box(DAT_181e60808,local_res18);
        if (lVar2 != null) {
          FUN_18175de30(lVar2,uVar3,DAT_181e77be0);
          if (this.draftSkillData != null) {
            local_res20[0] = this.draftSkillData.type;
            uVar3 = il2cpp_value_box(DAT_181e60808,local_res20);
            FUN_18175de30(lVar2,uVar3,DAT_181e77be0);
            local_28 = 0;
            uVar3 = il2cpp_value_box(DAT_181e60808,&local_28);
            FUN_18175de30(lVar2,uVar3,DAT_181e77be0);
            if (this.draftSkillData != null) {
              local_24[0] = this.draftSkillData.rareLv;
              uVar3 = il2cpp_value_box(DAT_181e60808,local_24);
              FUN_18175de30(lVar2,uVar3,DAT_181e77be0);
              uVar3 = Component.get_gameObject(this,0);
              if (lVar1 != null) {
                ChooseController.ShowChoosePanel(lVar1,0,lVar2,uVar3,"DamageRangeChoosen",0,0,0,0,0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x60013AE
    // RVA   : 0x656220   Offset: 0x655020   Length: 0x427
    public void DamageRangeChoosen()
    {
        var pStatics_77e8 = *(int64*)(DAT_181e977e8 + 184);
        long lVar2;
        bool cVar3;
        long lVar4;
        ulong uVar5;
        uint local_60;
        uint32 uStack_5c;
        uint32 uStack_58;
        uint32 uStack_54;
        int64 local_50;
        uint32 local_48;
        uint32 uStack_44;
        uint32 uStack_40;
        uint32 uStack_3c;
        int64 local_38;
        if ((((*pStatics_77e8 != 0) &&
             (lVar4 = *(int64 *)(*pStatics_77e8 + 72)) != null) &&
            (lVar4 = GameObject.GetComponent(lVar4,DAT_181e568c8)) != null) &&
           (lVar4.name != null)) {
          lVar4 = KungfuSkillLvData.DataBase(lVar4.name,0);
          if (lVar4 == null) {
            return;
          }
          if (((lVar4.attackRangeData == null) || (*(int *)(lVar4.attackRangeData + 24) == 0))
             || (lVar4.damageRangeData == null)) {
            if (GameController._instance != null) {
              GameController.ShowTextOnMouse(GameController._instance,"该武学没有可复制的范围数据",0);
              return;
            }
          }
          else {
            lVar2 = this.draftSkillData;
            uVar5 = il2cpp_internal(DAT_181e773a8);
            FUN_1810f3480(uVar5,DAT_181e84db0);
            if (lVar2 != null) {
              lVar2.attackRangeData = uVar5;
              if (lVar4.attackRangeData != null) {
                FUN_1816629a0(&local_48,lVar4.attackRangeData,DAT_181e84eb0);
                local_60 = local_48;
                uStack_5c = uStack_44;
                uStack_58 = uStack_40;
                uStack_54 = uStack_3c;
                local_50 = local_38;
                while (cVar3 = FUN_1807b3f30(&local_60,DAT_181e73340), cVar3) {
                  if (this.draftSkillData == null) {
                          // WARNING: Subroutine does not return
                    FUN_1801e0300();
                  }
                  lVar2 = this.draftSkillData.attackRangeData;
                  if (local_50 == 0) {
                          // WARNING: Subroutine does not return
                    FUN_1801e0300();
                  }
                  plVar6 = (int64 *)SkillAttackRangeData.Clone(local_50,0);
                  if (lVar2 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1801e0300();
                  }
                  plVar7 = (int64 *)0;
                  if (plVar6 != (int64 *)0) {
                  }
                  FUN_18175de30(lVar2,plVar7,DAT_181e84e30);
                }
                ZhSegment.Initialize(&local_60,DAT_181e732c0);
                lVar2 = this.draftSkillData;
                if ((lVar4.damageRangeData != null) &&
                   (plVar6 = (int64 *)SkillDamageRangeData.Clone(lVar4.damageRangeData,0),
                   lVar2 != null)) {
                  plVar7 = (int64 *)0;
                  if (plVar6 != (int64 *)0) {
                  }
                  lVar2.damageRangeData = plVar7;
                  lVar4 = this.draftSkillData;
                  if (lVar4 != null) {
                    KungfuSkillData.RefreshMaxAttackRange(lVar4,0);
                    CustomSkillCreateController.RefreshDamageRangeUI(this,0);
                    return;
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x60013AF
    // RVA   : 0x659770   Offset: 0x658570   Length: 0x185
    public void RefreshPostureUI()
    {
        bool cVar1;
        long lVar2;
        ulong uVar4;
        ulong uVar5;
        if (((this.externalPostureUI != null) &&
            (lVar2 = GameObject.get_transform(this.externalPostureUI,0)) != null) &&
           (lVar2 = Transform.Find(lVar2,"PartPostureText",0)) != null) {
          plVar3 = (int64 *)Component.GetComponent(lVar2,DAT_181e79538);
          if (this.draftSkillData != null) {
            lVar2 = this.draftSkillData.atkPartPosture;
            uVar4 = "无";
            if ((lVar2 != null) &&
               (cVar1 = PartPostureData.IsEmpty(lVar2,0), uVar4 = "无", !cVar1)) {
              uVar4 = PartPostureData.GetSkillDescribe(lVar2,0);
            }
            if (this.draftSkillData != null) {
              lVar2 = this.draftSkillData.defPartPosture;
              uVar5 = "无";
              if ((lVar2 != null) &&
                 (cVar1 = PartPostureData.IsEmpty(lVar2,0), uVar5 = "无", !cVar1)) {
                uVar5 = PartPostureData.GetSkillDescribe(lVar2,0);
              }
              uVar4 = String.Format("进攻架势\n{0}\n防御架势\n{1}",uVar4,uVar5,0);
              if (plVar3 != (int64 *)0) {
                          // WARNING: Could not recover jumptable at 0x0001806598e9. Too many branches
                          // WARNING: Treating indirect jump as call
                (**(code **)(*plVar3 + 0x5e8))(plVar3,uVar4,*(uint64 *)(*plVar3 + 0x5f0));
                return;
              }
            }
          }
        }
    }

    // Token : 0x60013B0
    // RVA   : 0x657990   Offset: 0x656790   Length: 0x54
    private string GetPostureDescribe(PartPostureData posture)
    {
        bool cVar1;
        ulong uVar2;
        if (posture != null) {
          cVar1 = PartPostureData.IsEmpty(posture,0);
          if (!cVar1) {
            uVar2 = PartPostureData.GetSkillDescribe(posture,0);
            return uVar2;
          }
        }
        return "无";
    }

    // Token : 0x60013B1
    // RVA   : 0x655D70   Offset: 0x654B70   Length: 0x1F6
    public void ChoosePostureButtonClicked()
    {
        long lVar1;
        long lVar2;
        ulong uVar3;
        uint[] local_res8 = new uint[2];
        uint[] local_res18 = new uint[2];
        uint[] local_res20 = new uint[2];
        uint[] local_28 = new uint[4];
        if (this.draftSkillData == null) {
          return;
        }
        lVar1 = **(int64 **)(DAT_181e977e8 + 184);
        lVar2 = il2cpp_internal(DAT_181e74e38);
        FUN_1810f3480(lVar2,DAT_181e77ae0);
        local_res8[0] = 0;
        uVar3 = il2cpp_value_box(DAT_181e60808,local_res8);
        if (lVar2 != null) {
          FUN_18175de30(lVar2,uVar3,DAT_181e77be0);
          if (this.draftSkillData != null) {
            local_res18[0] = this.draftSkillData.type;
            uVar3 = il2cpp_value_box(DAT_181e60808,local_res18);
            FUN_18175de30(lVar2,uVar3,DAT_181e77be0);
            local_res20[0] = 0;
            uVar3 = il2cpp_value_box(DAT_181e60808,local_res20);
            FUN_18175de30(lVar2,uVar3,DAT_181e77be0);
            if (this.draftSkillData != null) {
              local_28[0] = this.draftSkillData.rareLv;
              uVar3 = il2cpp_value_box(DAT_181e60808,local_28);
              FUN_18175de30(lVar2,uVar3,DAT_181e77be0);
              uVar3 = Component.get_gameObject(this,0);
              if (lVar1 != null) {
                ChooseController.ShowChoosePanel(lVar1,0,lVar2,uVar3,"PostureChoosen",0,0,0,0,0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x60013B2
    // RVA   : 0x6589C0   Offset: 0x6577C0   Length: 0x267
    public void PostureChoosen()
    {
        var pStatics = *(int64*)(DAT_181e977e8 + 184);
        long lVar2;
        bool cVar3;
        long lVar4;
        if (this.draftSkillData == null) {
          return;
        }
        if ((((*pStatics != 0) &&
             (lVar4 = *(int64 *)(*pStatics + 72)) != null) &&
            (lVar4 = GameObject.GetComponent(lVar4,DAT_181e568c8)) != null) &&
           (*(int64 *)(lVar4 + 32) != 0)) {
          lVar4 = KungfuSkillLvData.DataBase(*(int64 *)(lVar4 + 32),0);
          if (lVar4 == null) {
            return;
          }
          if (((*(int64 *)(lVar4 + 136) == 0) ||
              (cVar3 = PartPostureData.IsEmpty(*(int64 *)(lVar4 + 136),0), cVar3)) &&
             ((*(int64 *)(lVar4 + 144) == 0 ||
              (cVar3 = PartPostureData.IsEmpty(*(int64 *)(lVar4 + 144),0), cVar3)))) {
            lVar4 = FUN_1802106e0(0);
            if (lVar4 != null) {
              GameController.ShowTextOnMouse(lVar4,"该武学没有可复制的架势数据",0);
              return;
            }
          }
          else {
            lVar2 = this.draftSkillData;
            if (*(int64 *)(lVar4 + 136) == 0) {
              plVar5 = (int64 *)0;
            }
            else {
              plVar5 = (int64 *)PartPostureData.Clone(*(int64 *)(lVar4 + 136),0);
            }
            if (lVar2 != null) {
              lVar2.atkPartPosture = plVar5;
              lVar2 = this.draftSkillData;
              plVar5 = (int64 *)0;
              if ((*(int64 *)(lVar4 + 144) != 0) &&
                 (plVar6 = (int64 *)PartPostureData.Clone(*(int64 *)(lVar4 + 144),0),
                 plVar6 != (int64 *)0)) {
              }
              if (lVar2 != null) {
                lVar2.defPartPosture = plVar5;
                CustomSkillCreateController.RefreshPostureUI(this,0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x60013B3
    // RVA   : 0x658400   Offset: 0x657200   Length: 0x36
    private bool IsHpManaPoolKey(int key)
    {
        ulong uVar1;
        uVar1 = this.draftSkillData;
        if (uVar1 == 0) {
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        if (uVar1.type != null) {
          return uVar1 & 0xffffffffffffff00;
        }
        uVar2 = (undefined7)(uVar1 >> 8);
        if (key == 57) {
          return CONCAT71(uVar2,1);
        }
        return CONCAT71(uVar2,key == 59);
    }

    // Token : 0x60013B4
    // RVA   : 0x6579F0   Offset: 0x6567F0   Length: 0x16A
    public int GetSpeAddDataCount()
    {
        ulong uVar1;
        bool cVar2;
        long lVar3;
        int iVar4;
        long lVar5;
        float fVar6;
        uint local_60;
        uint32 uStack_5c;
        uint32 uStack_58;
        uint32 uStack_54;
        uint64 local_50;
        uint32 local_48;
        uint32 uStack_44;
        uint32 uStack_40;
        uint32 uStack_3c;
        uint64 local_38;
        iVar4 = 0;
        lVar5 = this.draftSkillData;
        if (lVar5 != null) {
          if (lVar5.type < 3) {
            lVar5 = lVar5.equipAddData;
          }
          else {
            lVar5 = lVar5.useAddData;
          }
          if ((lVar5 != null) && (lVar3 = HeroSpeAddData.GetKeys(lVar5,0)) != null) {
            FUN_18175fc30(&local_48,lVar3,DAT_181e71670);
            local_60 = local_48;
            uStack_5c = uStack_44;
            uStack_58 = uStack_40;
            uStack_54 = uStack_3c;
            local_50 = local_38;
            while (cVar2 = FUN_1807b40e0(&local_60,DAT_181e6f540), uVar1 = local_50, cVar2) {
              fVar6 = (float)HeroSpeAddData.Get(lVar5,local_50 & 0xffffffff,0);
              if ((fVar6 != 0.0) &&
                 (cVar2 = CustomSkillCreateController.IsHpManaPoolKey(this,uVar1 & 0xffffffff),
                 !cVar2)) {
                iVar4 = iVar4 + 1;
              }
            }
            ZhSegment.Initialize(&local_60,DAT_181e6f4c0);
            return iVar4;
          }
        }
    }

    // Token : 0x60013B5
    // RVA   : 0x657B60   Offset: 0x656960   Length: 0x2A
    public HeroSpeAddData GetTargetSpeAdd()
    {
        long lVar1;
        lVar1 = this.draftSkillData;
        if (lVar1 == null) {
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        if (lVar1.type < 3) {
          return lVar1.equipAddData;
        }
        return lVar1.useAddData;
    }

    // Token : 0x60013B6
    // RVA   : 0x659C60   Offset: 0x658A60   Length: 0x285
    public void RefreshSpeAddDataGrid()
    {
        long lVar1;
        int iVar2;
        uint uVar3;
        long lVar4;
        ulong uVar6;
        ulong uVar7;
        uint[] local_res8 = new uint[2];
        uint[] local_res18 = new uint[4];
        if (this.chooseNewSpeAddDataButton != null) {
          lVar4 = GameObject.GetComponent(this.chooseNewSpeAddDataButton,DAT_181e53cb0);
          iVar2 = CustomSkillCreateController.GetSpeAddDataCount(this,0);
          lVar1 = CustomSkillCreateController.SpeAddNumMax;
          if (this.draftSkillData != null) {
            uVar3 = Mathf.Clamp(this.draftSkillData.rareLv,0,5);
            if (lVar1 != null) {
              if (*(uint32 *)(lVar1 + 24) <= uVar3) {
                uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1801e02d0(uVar6,0);
              }
              if (lVar4 != null) {
                Selectable.set_interactable
                          (lVar4,iVar2 < lVar1[uVar3],0);
                if (this.chooseNewSpeAddDataButton != null) {
                  lVar4 = GameObject.get_transform(this.chooseNewSpeAddDataButton,0);
                  if (lVar4 != null) {
                    lVar4 = Transform.Find(lVar4,"Text",0);
                    if (lVar4 != null) {
                      plVar5 = (int64 *)Component.GetComponent(lVar4,DAT_181e79538);
                      local_res8[0] = CustomSkillCreateController.GetSpeAddDataCount(this,0);
                      uVar6 = il2cpp_value_box(DAT_181e60808,local_res8);
                      lVar4 = CustomSkillCreateController.SpeAddNumMax;
                      if (this.draftSkillData != null) {
                        uVar3 = Mathf.Clamp(this.draftSkillData.rareLv,0,5);
                        if (lVar4 != null) {
                          if (*(uint32 *)(lVar4 + 24) <= uVar3) {
                            uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                            FUN_1801e02d0(uVar6,0);
                          }
                          local_res18[0] = lVar4[uVar3];
                          uVar7 = il2cpp_value_box(DAT_181e60808,local_res18);
                          uVar6 = String.Format("新增特效 {0}/{1}",uVar6,uVar7,0);
                          if (plVar5 != (int64 *)0) {
                            (**(code **)(*plVar5 + 0x5e8))(plVar5,uVar6,*(uint64 *)(*plVar5 + 0x5f0));
                            if (this.speAddDataGrid != null) {
                              lVar4 = GameObject.GetComponent
                                                (this.speAddDataGrid,DAT_181e579c8);
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
          }
        }
    }

    // Token : 0x60013B7
    // RVA   : 0x655B10   Offset: 0x654910   Length: 0x25A
    public void ChooseNewSpeAddDataButtonClicked()
    {
        int iVar1;
        uint uVar2;
        long lVar3;
        ulong uVar5;
        if (this.draftSkillData == null) {
          return;
        }
        iVar1 = CustomSkillCreateController.GetSpeAddDataCount(this,0);
        lVar3 = *(int64 *)(*(int64 *)(DAT_181e9bac0 + 184) + 8);
        if ((this.draftSkillData != null) &&
           (uVar2 = Mathf.Clamp(this.draftSkillData.rareLv,0,5), lVar3 != null))
        {
          if (*(uint32 *)(lVar3 + 24) <= uVar2) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar5,0);
          }
          if (iVar1 < lVar3[uVar2]) {
            lVar3 = CustomSkillCreateController.GetAvailableSpeAddList(this,0);
            if (lVar3 != null) {
              if (*(int *)(lVar3 + 24) == 0) {
                lVar3 = FUN_1802106e0(0);
                if (lVar3 != null) {
                  GameController.ShowTextOnMouse(lVar3,"没有可添加的特效条目",0);
                  return;
                }
              }
              else {
                CustomSkillCreateController.RefreshChooseSpeAddDataUI(this,lVar3,0);
                if (this.chooseUI != null) {
                  GameObject.SetActive(this.chooseUI,1,0);
                  uVar5 = "Sound/SoundEffect/OpenBook";
                  goto LAB_180655d02;
                }
              }
            }
          }
          else {
            lVar3 = FUN_1802106e0(0);
            if (lVar3 != null) {
              GameController.ShowTextOnMouse(lVar3,"词条已达上限",0);
              uVar5 = "Sound/SoundEffect/WrongClick";
        LAB_180655d02:
              plVar4 = (int64 *)Resources.Load(uVar5,0);
              plVar6 = (int64 *)0;
              if ((plVar4 != (int64 *)0) && (*plVar4 == DAT_181e8f4a0)) {
                plVar6 = plVar4;
              }
              NGUITools.PlaySound(plVar6,0);
              return;
            }
          }
        }
    }

    // Token : 0x60013B8
    // RVA   : 0x657120   Offset: 0x655F20   Length: 0x41A
    public List<int> GetAvailableSpeAddList()
    {
        int iVar1;
        ulong uVar2;
        bool cVar3;
        long lVar4;
        long lVar5;
        long lVar6;
        long lVar7;
        float fVar8;
        ulong local_a8;
        ulong uStack_a0;
        ulong local_98;
        long local_90;
        uint local_88;
        uint uStack_84;
        uint uStack_80;
        uint32 uStack_7c;
        uint64 local_78;
        uint32 local_70;
        uint32 uStack_6c;
        uint32 uStack_68;
        uint32 uStack_64;
        uint64 local_60;
        local_a8 = 0;
        uStack_a0 = 0;
        local_98 = 0;
        lVar7 = this.draftSkillData;
        if (lVar7 != null) {
          iVar1 = lVar7.type;
          if (iVar1 < 3) {
            lVar7 = lVar7.equipAddData;
          }
          else {
            lVar7 = lVar7.useAddData;
          }
          local_90 = lVar7;
          lVar4 = il2cpp_internal(DAT_181e73cb8);
          FUN_1810f3480(lVar4,DAT_181e71270);
          if ((((GameController._instance != null) &&
               (lVar5 = GameController._instance.worldData) != null) &&
              (lVar5 = WorldData.Player(lVar5,0)) != null) && (lVar5.customDifficultyData != null)) {
            FUN_1816629a0(&local_88,lVar5.customDifficultyData,DAT_181e744f0);
            local_70 = local_88;
            uStack_6c = uStack_84;
            uStack_68 = uStack_80;
            uStack_64 = uStack_7c;
            local_60 = local_78;
            while (cVar3 = FUN_1807b3f30(&local_70,DAT_181e6ffc0), cVar3) {
              if (local_60 == 0) {
                          // WARNING: Subroutine does not return
                FUN_1801e0300();
              }
              lVar5 = KungfuSkillLvData.DataBase(local_60,0);
              if ((lVar5 != null) && (lVar5.Areas < 3 == iVar1 < 3)) {
                if (iVar1 < 3) {
                  lVar5 = lVar5.BigMapRandomEventDatas;
                }
                else {
                  lVar5 = lVar5.AreaMapRandomEventDatas;
                }
                if (lVar5 != null) {
                  lVar6 = HeroSpeAddData.GetKeys(lVar5,0);
                  if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1801e0300();
                  }
                  FUN_18175fc30(&local_88,lVar6,DAT_181e71670);
                  local_a8 = CONCAT44(uStack_84,local_88);
                  uStack_a0 = CONCAT44(uStack_7c,uStack_80);
                  local_98 = local_78;
                  while (cVar3 = FUN_1807b40e0(&local_a8,DAT_181e6f540), uVar2 = local_98, cVar3)
                  {
                    fVar8 = (float)HeroSpeAddData.Get(lVar5,local_98 & 0xffffffff,0);
                    if (fVar8 != 0.0) {
                      if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                        FUN_1801e0300();
                      }
                      cVar3 = FUN_18176a2d0(lVar4,uVar2 & 0xffffffff);
                      if ((!cVar3) &&
                         (cVar3 = CustomSkillCreateController.IsHpManaPoolKey(this,uVar2 & 0xffffffff)
                         , !cVar3)) {
                        if (lVar7 == null) {
                          // WARNING: Subroutine does not return
                          FUN_1801e0300();
                        }
                        fVar8 = (float)HeroSpeAddData.Get(lVar7,uVar2 & 0xffffffff,0);
                        if (fVar8 == 0.0) {
                          FUN_181769fe0(lVar4,uVar2 & 0xffffffff);
                        }
                      }
                    }
                  }
                  ZhSegment.Initialize(&local_a8,DAT_181e6f4c0);
                }
              }
            }
            ZhSegment.Initialize(&local_70,DAT_181e6ff40);
            if (lVar4 != null) {
              List_1.Sort(lVar4,DAT_181e71970);
              return lVar4;
            }
          }
        }
    }

    // Token : 0x60013B9
    // RVA   : 0x6591F0   Offset: 0x657FF0   Length: 0x1BB
    public void RefreshChooseSpeAddDataUI(List<int> pool)
    {
        ulong uVar1;
        ulong uVar2;
        ulong uVar3;
        bool cVar4;
        long lVar5;
        uint local_40;
        uint32 uStack_3c;
        uint32 uStack_38;
        uint32 uStack_34;
        uint64 local_30;
        uint32 local_28;
        uint32 uStack_24;
        uint32 uStack_20;
        uint32 uStack_1c;
        uint64 local_18;
        uVar1 = this.chooseGrid;
        GlobalData.DeleteAllChild(uVar1,0);
        if (pool != null) {
          FUN_18175fc30(&local_28,pool,DAT_181e71670);
          local_40 = local_28;
          uStack_3c = uStack_24;
          uStack_38 = uStack_20;
          uStack_34 = uStack_1c;
          local_30 = local_18;
          while( true ) {
            cVar4 = FUN_1807b40e0(&local_40,DAT_181e6f540);
            uVar3 = local_30;
            if (!cVar4) {
              ZhSegment.Initialize(&local_40,DAT_181e6f4c0);
              return;
            }
            uVar1 = this.chooseGrid;
            uVar2 = this.chooseButtonPrefab;
            lVar5 = GlobalData.AddChild(uVar1,uVar2,0);
            if (lVar5 == null) break;
            lVar5 = GameObject.GetComponent(lVar5,DAT_181e54310);
            if (lVar5 == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            CustomSkillChooseSpeAddController.Init(lVar5,uVar3 & 0xffffffff);
          }
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
    }

    // Token : 0x60013BA
    // RVA   : 0x6561F0   Offset: 0x654FF0   Length: 0x23
    public void CloseChooseUI()
    {
        if (this.chooseUI != null) {
          GameObject.SetActive(this.chooseUI,0,0);
          return;
        }
    }

    // Token : 0x60013BB
    // RVA   : 0x655F70   Offset: 0x654D70   Length: 0x27E
    public void ChooseSpeAddData(int speAddType)
    {
        long lVar1;
        ulong uVar2;
        ulong uVar3;
        long lVar4;
        float fVar7;
        lVar4 = this.draftSkillData;
        if (lVar4 != null) {
          if (lVar4.type < 3) {
            lVar4 = lVar4.equipAddData;
          }
          else {
            lVar4 = lVar4.useAddData;
          }
          if (lVar4 != null) {
            fVar7 = (float)HeroSpeAddData.Get(lVar4,speAddType,0);
            if (fVar7 != 0.0) {
              return;
            }
            lVar1 = *(int64 *)(*(int64 *)(DAT_181e528f8 + 184) + 32);
            if ((lVar1 != null) && (lVar1 = *(int64 *)(lVar1 + 144)) != null) {
              if (*(uint32 *)(lVar1 + 24) <= speAddType) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar1 = lVar1[speAddType];
              if (lVar1 != null) {
                HeroSpeAddData.Set(lVar4,speAddType,*(uint32 *)(lVar1 + 32),0);
                if (this.chooseUI != null) {
                  GameObject.SetActive(this.chooseUI,0,0);
                  uVar2 = this.speAddDataGrid;
                  uVar3 = this.speAddDataPrefab;
                  lVar4 = GlobalData.AddChild(uVar2,uVar3,0);
                  if ((lVar4 != null) && (lVar4 = GameObject.GetComponent(lVar4,DAT_181e54420)) != null)
                  {
                    lVar4.belongForceID = speAddType;
                    CustomSkillSpeAddDataController.RefreshSpeAddUI(lVar4,0);
                    CustomSkillCreateController.RefreshSpeAddDataGrid(this,0);
                    CustomSkillCreateController.RefreshSkillPointText(this,0);
                    plVar5 = (int64 *)Resources.Load("Sound/SoundEffect/PaperQuick",0);
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

    // Token : 0x60013BC
    // RVA   : 0x657EE0   Offset: 0x656CE0   Length: 0x21C
    public void InitDamageRatioUI()
    {
        ulong uVar1;
        long lVar2;
        ulong uVar3;
        int iVar4;
        float fVar5;
        lVar2 = this.draftSkillData;
        if (lVar2 != null) {
          if (lVar2.addDamageRatio == null) {
            uVar1 = new AttriNumData(0);
            lVar2.addDamageRatio = uVar1;
          }
          iVar4 = 0;
          do {
            if (this.draftSkillData == null) throw; // [null/range check failed]
            uVar1 = this.draftSkillData.addDamageRatio;
            fVar5 = (float)CustomSkillDamageRatioController.GetRatioValue(uVar1,iVar4,0);
            if (fVar5 != 0.0) {
              if (((this.externalDamageUI == null) ||
                  (lVar2 = GameObject.get_transform(this.externalDamageUI,0)) == null) ||
                 (lVar2 = Transform.Find(lVar2,"AddDamageRatioGrid")) == null) throw; // [null/range check failed]
              uVar3 = Component.get_gameObject(lVar2,0);
              uVar1 = this.customSkillDamageRatioPrefab;
              lVar2 = GlobalData.AddChild(uVar3,uVar1);
              if ((lVar2 == null) || (lVar2 = GameObject.GetComponent(lVar2,DAT_181e54398)) == null)
              throw; // [null/range check failed]
              lVar2.belongForceID = iVar4;
              CustomSkillDamageRatioController.RefreshAttriRatioUI(lVar2,0);
            }
            iVar4 = iVar4 + 1;
          } while (iVar4 < 28);
          if ((((this.externalDamageUI != null) &&
               (lVar2 = GameObject.get_transform(this.externalDamageUI,0)) != null) &&
              (lVar2 = Transform.Find(lVar2,"AddDamageRatioGrid",0)) != null) &&
             (lVar2 = Component.GetComponent(lVar2,DAT_181e79d38)) != null) {
            UIGrid.set_repositionNow(lVar2,1,0);
            return;
          }
        }
    }

    // Token : 0x60013BD
    // RVA   : 0x65A420   Offset: 0x659220   Length: 0x1FD
    public void ResetSkillName()
    {
        long lVar1;
        long lVar2;
        ulong uVar3;
        if (**(int **)(DAT_181e538e8 + 184) == 1) {
          lVar1 = new c.DisplayClass9_0(0);
          if ((this.skillName != null) && (lVar1 != null)) {
            *(uint64 *)(lVar1 + 16) = *(uint64 *)(this.skillName + 0x170);
            *(uint8 *)(lVar1 + 24) = *(uint8 *)(*(int64 *)(DAT_181e538e8 + 184) + 128);
            lVar2 = rail_api.RailFactory(0);
            if ((lVar2 != null) && (lVar2 = FUN_180002280(17,DAT_181e5b750,lVar2)) != null) {
              FUN_180060560(12,DAT_181e5cf10,lVar2,lVar1,"");
              return;
            }
          }
        }
        else {
          lVar1 = CISFilterWordsSDK.get_Instance(0);
          if ((this.skillName != null) && (lVar1 != null)) {
            uVar3 = CISFilterWordsSDK.FilterReplaceWithChar
                              (lVar1,*(uint64 *)(this.skillName + 0x170),42,0);
            if (this.skillName != null) {
              InputField.set_text(this.skillName,uVar3,0);
              if (this.draftSkillData == null) {
                return;
              }
              this.draftSkillData.name = uVar3;
              return;
            }
          }
        }
    }

    // Token : 0x60013BE
    // RVA   : 0x65A220   Offset: 0x659020   Length: 0x1FD
    public void ResetSkillDescribe()
    {
        long lVar1;
        long lVar2;
        ulong uVar3;
        if (**(int **)(DAT_181e538e8 + 184) == 1) {
          lVar1 = new c.DisplayClass9_0(0);
          if ((this.skillDescribe != null) && (lVar1 != null)) {
            *(uint64 *)(lVar1 + 16) = *(uint64 *)(this.skillDescribe + 0x170);
            *(uint8 *)(lVar1 + 24) = *(uint8 *)(*(int64 *)(DAT_181e538e8 + 184) + 128);
            lVar2 = rail_api.RailFactory(0);
            if ((lVar2 != null) && (lVar2 = FUN_180002280(17,DAT_181e5b750,lVar2)) != null) {
              FUN_180060560(12,DAT_181e5cf10,lVar2,lVar1,"");
              return;
            }
          }
        }
        else {
          lVar1 = CISFilterWordsSDK.get_Instance(0);
          if ((this.skillDescribe != null) && (lVar1 != null)) {
            uVar3 = CISFilterWordsSDK.FilterReplaceWithChar
                              (lVar1,*(uint64 *)(this.skillDescribe + 0x170),42,0);
            if (this.skillDescribe != null) {
              InputField.set_text(this.skillDescribe,uVar3,0);
              if (this.draftSkillData == null) {
                return;
              }
              this.draftSkillData.describe = uVar3;
              return;
            }
          }
        }
    }

    // Token : 0x60013BF
    // RVA   : 0x6588C0   Offset: 0x6576C0   Length: 0xF9
    public void OnResetSkillFliterResult(RAILEventID id, EventBase data)
    {
        void CustomSkillCreateController.OnResetSkillFliterResult
                     (int64 this,int id,int64 *data)
        {
        char cVar1;
        if (data != (int64 *)0) {
          if (((int)data[2] != 0) || (id != 0x1f45)) {
            return;
          }
          if (this.skillName != null) {
            cVar1 = FUN_1816387f0(data[7],*(uint64 *)(this.skillName + 0x170),0);
            if (cVar1) {
              CustomSkillCreateController.SetFliteredSkillName(this,data[8],0);
            }
            if (this.skillDescribe != null) {
              cVar1 = FUN_1816387f0(data[7],*(uint64 *)(this.skillDescribe + 0x170),0);
              if (!cVar1) {
                return;
              }
              CustomSkillCreateController.SetFliteredSkillDescribe(this,data[8],0);
              return;
            }
          }
        }
    }

    // Token : 0x60013C0
    // RVA   : 0x65A670   Offset: 0x659470   Length: 0x49
    public void SetFliteredSkillName(string fliteredTotalName)
    {
        if (this.skillName != null) {
          InputField.set_text(this.skillName,fliteredTotalName,0);
          if (this.draftSkillData != null) {
            this.draftSkillData.name = fliteredTotalName;
          }
          return;
        }
    }

    // Token : 0x60013C1
    // RVA   : 0x65A620   Offset: 0x659420   Length: 0x49
    public void SetFliteredSkillDescribe(string fliteredTotalDescribe)
    {
        if (this.skillDescribe != null) {
          InputField.set_text(this.skillDescribe,fliteredTotalDescribe,0);
          if (this.draftSkillData != null) {
            this.draftSkillData.describe = fliteredTotalDescribe;
          }
          return;
        }
    }

    // Token : 0x60013C2
    // RVA   : 0x659900   Offset: 0x658700   Length: 0xFB
    public void RefreshSkillIcon()
    {
        long lVar1;
        long lVar2;
        bool cVar3;
        ulong uVar4;
        if (this.draftSkillData != null) {
          uVar4 = this.skillIcon;
          cVar3 = Object.op_Equality(uVar4,0,0);
          if (!cVar3) {
            lVar1 = this.skillIcon;
            lVar2 = **(int64 **)(DAT_181e8b8e8 + 184);
            if (((this.draftSkillData == null) ||
                (uVar4 = KungfuSkillData.GetSkillIcon(this.draftSkillData,0), lVar2 == null)) ||
               (uVar4 = TextureController.LoadAtlasSprite(lVar2,"IconAtlas",uVar4,0), lVar1 == null)) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            Image.set_sprite(lVar1,uVar4,0);
          }
        }
    }

    // Token : 0x60013C3
    // RVA   : 0x658C30   Offset: 0x657A30   Length: 0x49A
    public void RandomSkillIcon()
    {
        int iVar1;
        bool cVar2;
        uint uVar3;
        ulong uVar4;
        long lVar5;
        long lVar6;
        ulong uVar7;
        uint local_50;
        uint32 uStack_4c;
        uint32 uStack_48;
        uint32 uStack_44;
        int64 local_40;
        uint32 local_38;
        uint32 uStack_34;
        uint32 uStack_30;
        uint32 uStack_2c;
        int64 local_28;
        if (this.draftSkillData == null) {
          return;
        }
        uVar4 = KungfuSkillData.GetSkillIcon(this.draftSkillData,0);
        lVar5 = il2cpp_internal(DAT_181e77728);
        FUN_1810f3480(lVar5,DAT_181e861f0);
        lVar6 = *(int64 *)(*(int64 *)(DAT_181e528f8 + 184) + 32);
        if (((lVar6 != null) && (lVar6 = *(int64 *)(lVar6 + 0x138)) != null) &&
           (lVar6 = FUN_1806e0520(lVar6,DAT_181e9db68)) != null) {
          ValueCollection.GetEnumerator(&local_38,lVar6,DAT_181e61da0);
          local_50 = local_38;
          uStack_4c = uStack_34;
          uStack_48 = uStack_30;
          uStack_44 = uStack_2c;
          local_40 = local_28;
          while (cVar2 = FUN_180dd6250(&local_50,DAT_181e7be30), cVar2) {
            if (local_40 == 0) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            lVar6 = this.draftSkillData;
            if (lVar6 == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            if (((*(int *)(local_40 + 48) == lVar6.type) &&
                (*(int *)(local_40 + 52) == lVar6.rareLv)) &&
               (*(char *)(local_40 + 200) == false)) {
              uVar7 = KungfuSkillData.GetSkillIcon(local_40,0);
              cVar2 = FUN_180ad1200(uVar7,0);
              if ((!cVar2) && (cVar2 = FUN_1816387f0(uVar7,uVar4), !cVar2)) {
                if (lVar5 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1801e0300();
                }
                cVar2 = FUN_18175e190(lVar5,uVar7);
                if (!cVar2) {
                  FUN_18175de30(lVar5,uVar7);
                }
              }
            }
          }
          ZhSegment.Initialize(&local_50,DAT_181e7bdb0);
          if (lVar5 != null) {
            iVar1 = *(int *)(lVar5 + 24);
            if (iVar1 == 0) {
              if (GameController._instance != null) {
                GameController.ShowTextOnMouse(GameController._instance,"没有更多可选图标",0);
                return;
              }
            }
            else {
              lVar6 = this.draftSkillData;
              uVar3 = GlobalData.RandomRange(0,iVar1,0,0);
              if (*(uint32 *)(lVar5 + 24) <= uVar3) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              if (lVar6 != null) {
                lVar6.iconName =
                     lVar5[uVar3];
                il2cpp_internal();
                CustomSkillCreateController.RefreshSkillIcon(this,0);
                plVar8 = (int64 *)Resources.Load("Sound/SoundEffect/Dice",0);
                plVar9 = (int64 *)0;
                if ((plVar8 != (int64 *)0) && (*plVar8 == DAT_181e8f4a0)) {
                  plVar9 = plVar8;
                }
                NGUITools.PlaySound(plVar9,0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x60013C4
    // RVA   : 0x659A00   Offset: 0x658800   Length: 0x258
    public void RefreshSkillPointText()
    {
        var pStatics = *(int64*)(DAT_181e538e8 + 184);
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        float fVar5;
        float fVar6;
        uint uVar7;
        uint uVar8;
        uint uVar9;
        uint uVar10;
        uint[] local_res8 = new uint[2];
        uint[] local_res18 = new uint[2];
        uint local_28;
        uint uStack_24;
        uint uStack_20;
        uint32 uStack_1c;
        plVar1 = this.skillPointText;
        uVar3 = this.draftSkillData;
        local_res8[0] = CustomSkillCreateController.GetUsedBudget(uVar3,0);
        uVar3 = il2cpp_value_box(DAT_181e82730,local_res8);
        local_res18[0] = CustomSkillCreateController.GetEffectBudget(this.draftSkillData,0);
        uVar4 = il2cpp_value_box(DAT_181e82730,local_res18);
        uVar3 = String.Format("武学点数 {0:0.#}/{1}",uVar3,uVar4,0);
        if (plVar1 == (int64 *)0) {
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        (**(code **)(*plVar1 + 0x5e8))(plVar1,uVar3,*(uint64 *)(*plVar1 + 0x5f0));
        plVar1 = this.skillPointText;
        fVar5 = (float)CustomSkillCreateController.GetUsedBudget(this.draftSkillData,0);
        fVar6 = (float)CustomSkillCreateController.GetEffectBudget(this.draftSkillData,0);
        if (fVar5 <= fVar6 + 0.001) {
          lVar2 = pStatics;
          uVar7 = *(uint32 *)(lVar2 + 0x2b0);
          uVar8 = *(uint32 *)(lVar2 + 0x2b4);
          uVar9 = *(uint32 *)(lVar2 + 0x2b8);
          uVar10 = *(uint32 *)(lVar2 + 700);
        }
        else {
          lVar2 = pStatics;
          uVar7 = *(uint32 *)(lVar2 + 0x318);
          uVar8 = *(uint32 *)(lVar2 + 0x31c);
          uVar9 = *(uint32 *)(lVar2 + 800);
          uVar10 = *(uint32 *)(lVar2 + 0x324);
        }
        if (plVar1 != (int64 *)0) {
          local_28 = uVar7;
          uStack_24 = uVar8;
          uStack_20 = uVar9;
          uStack_1c = uVar10;
          (**(code **)(*plVar1 + 0x2a8))(plVar1,&local_28,*(uint64 *)(*plVar1 + 0x2b0));
          CustomSkillCreateController.RefreshManaCost(this,0);
          lVar2 = this.draftSkillData;
          plVar1 = this.manaCostText;
          if (lVar2 != null) {
            uVar3 = "";
            if (2 < lVar2.type) {
              local_res8[0] = lVar2.manaCost;
              uVar3 = il2cpp_value_box(DAT_181e82730,local_res8);
              uVar3 = String.Format("内力消耗 {0}",uVar3,0);
            }
            if (plVar1 != (int64 *)0) {
              (**(code **)(*plVar1 + 0x5e8))(plVar1,uVar3,*(uint64 *)(*plVar1 + 0x5f0));
              return;
            }
          }
        }
    }

    // Token : 0x60013C5
    // RVA   : 0x659670   Offset: 0x658470   Length: 0xF0
    public void RefreshManaCost()
    {
        long lVar1;
        long lVar2;
        uint uVar3;
        uint uVar4;
        int iVar5;
        ulong uVar6;
        float fVar7;
        lVar1 = this.draftSkillData;
        if ((lVar1 == null) || (lVar1.type < 3)) {
          return;
        }
        uVar3 = Mathf.Clamp(lVar1.rareLv,0,5);
        lVar1 = this.draftSkillData;
        fVar7 = (float)CustomSkillCreateController.GetUsedBudget(lVar1,0);
        lVar2 = *(int64 *)(*(int64 *)(DAT_181e9bac0 + 184) + 16);
        if (lVar2 != null) {
          if (*(uint32 *)(lVar2 + 24) <= uVar3) {
            uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar6,0);
          }
          uVar4 = Mathf.RoundToInt(lVar2[uVar3] * fVar7,0);
          iVar5 = Mathf.Max(1,uVar4);
          if (lVar1 != null) {
            lVar1.manaCost = (float)iVar5;
            return;
          }
        }
    }

    // Token : 0x60013C6
    // RVA   : 0x658100   Offset: 0x656F00   Length: 0x2FD
    public void InternalHpManaRatioSliderChanged()
    {
        int iVar1;
        long lVar2;
        ulong uVar4;
        float fVar5;
        float fVar6;
        uint[] local_res8 = new uint[2];
        uint[] local_res18 = new uint[2];
        plVar3 = this.internalHpManaRatioSlider;
        if (plVar3 != (int64 *)0) {
          fVar5 = (float)(**(code **)(*plVar3 + 0x418))(plVar3,*(uint64 *)(*plVar3 + 0x420));
          if (this.internalHpManaRatioSlider != null) {
            fVar6 = *(float *)(this.internalHpManaRatioSlider + 0x110);
            if (this.draftSkillData != null) {
              iVar1 = Mathf.Clamp(this.draftSkillData.rareLv,0,5);
              fVar5 = (float)Mathf.Clamp01(fVar5 / fVar6,0);
              if (this.draftSkillData != null) {
                lVar2 = this.draftSkillData.equipAddData;
                fVar6 = (float)((iVar1 + 1) * 20);
                Mathf.RoundToInt((fVar6 + fVar6) * fVar5,0);
                if (lVar2 != null) {
                  HeroSpeAddData.Set(lVar2,57);
                  if (this.draftSkillData != null) {
                    lVar2 = this.draftSkillData.equipAddData;
                    Mathf.RoundToInt(fVar6 * 4.0 * (1.0 - fVar5),0);
                    if (lVar2 != null) {
                      HeroSpeAddData.Set(lVar2,59);
                      if (this.internalHpManaRatioSlider != null) {
                        lVar2 = Component.get_transform(this.internalHpManaRatioSlider,0);
                        if (lVar2 != null) {
                          lVar2 = Transform.Find(lVar2,"Hp",0);
                          if (lVar2 != null) {
                            plVar3 = (int64 *)Component.GetComponent(lVar2,DAT_181e79538);
                            if ((this.draftSkillData != null) &&
                               (lVar2 = this.draftSkillData.equipAddData) != null)
                            {
                              local_res8[0] = HeroSpeAddData.Get(lVar2,57);
                              uVar4 = il2cpp_value_box(DAT_181e82730,local_res8);
                              uVar4 = String.Format("生命{0}",uVar4,0);
                              if (plVar3 != (int64 *)0) {
                                (**(code **)(*plVar3 + 0x5e8))
                                          (plVar3,uVar4,*(uint64 *)(*plVar3 + 0x5f0));
                                if (this.internalHpManaRatioSlider != null) {
                                  lVar2 = Component.get_transform(this.internalHpManaRatioSlider,0);
                                  if (lVar2 != null) {
                                    lVar2 = Transform.Find(lVar2,"Mp",0);
                                    if (lVar2 != null) {
                                      plVar3 = (int64 *)Component.GetComponent(lVar2,DAT_181e79538);
                                      if ((this.draftSkillData != null) &&
                                         (lVar2 = this.draftSkillData.equipAddData,
                                         lVar2 != null)) {
                                        local_res18[0] = HeroSpeAddData.Get(lVar2,59);
                                        uVar4 = il2cpp_value_box(DAT_181e82730,local_res18);
                                        uVar4 = String.Format("内力{0}",uVar4,0);
                                        if (plVar3 != (int64 *)0) {
                                          (**(code **)(*plVar3 + 0x5e8))
                                                    (plVar3,uVar4,*(uint64 *)(*plVar3 + 0x5f0));
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

    // Token : 0x60013C7
    // RVA   : 0x655620   Offset: 0x654420   Length: 0xFF
    public void ApplyHpManaRatio(float ratio)
    {
        long lVar1;
        int iVar2;
        float fVar3;
        float fVar4;
        if (this.draftSkillData != null) {
          iVar2 = Mathf.Clamp(this.draftSkillData.rareLv,0,5);
          fVar3 = (float)Mathf.Clamp01(ratio,0);
          if (this.draftSkillData != null) {
            lVar1 = this.draftSkillData.equipAddData;
            fVar4 = (float)((iVar2 + 1) * 20);
            Mathf.RoundToInt((fVar4 + fVar4) * fVar3,0);
            if (lVar1 != null) {
              HeroSpeAddData.Set(lVar1,57);
              if (this.draftSkillData != null) {
                lVar1 = this.draftSkillData.equipAddData;
                Mathf.RoundToInt(fVar4 * 4.0 * (1.0 - fVar3),0);
                if (lVar1 != null) {
                  HeroSpeAddData.Set(lVar1,59);
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x60013C8
    // RVA   : 0x657540   Offset: 0x656340   Length: 0x65
    public int GetBaseDamageMax()
    {
        ulong uVar1;
        float fVar2;
        uVar1 = this.draftSkillData;
        fVar2 = (float)CustomSkillCreateController.GetEffectBudget(uVar1,0);
        Mathf.RoundToInt(fVar2 * 0.6,0);
    }

    // Token : 0x60013C9
    // RVA   : 0x655790   Offset: 0x654590   Length: 0x1A0
    public void ChangeBaseDamageButtonClicked(GameObject buttonClicked)
    {
        float fVar1;
        long lVar2;
        bool cVar3;
        ulong uVar4;
        int iVar7;
        uint uVar8;
        byte[] auVar9 = new byte[16];
        byte[] auVar10 = new byte[16];
        uint64 extraout_XMM0_Qb;
        lVar2 = this.draftSkillData;
        if ((lVar2 != null) && (fVar1 = lVar2.baseDamage, buttonClicked != null)) {
          uVar4 = Object.get_name(buttonClicked,0);
          cVar3 = FUN_1816387f0(uVar4,"Right",0);
          iVar7 = -1;
          if (cVar3) {
            iVar7 = 1;
          }
          uVar4 = this.draftSkillData;
          auVar9._0_8_ = CustomSkillCreateController.GetEffectBudget(uVar4,0);
          auVar9._8_8_ = extraout_XMM0_Qb;
          auVar10._4_12_ = auVar9._4_12_;
          auVar10._0_4_ = (float)auVar9._0_8_ * 0.6;
          Mathf.RoundToInt(auVar10._0_8_,0);
          uVar8 = FUN_180f34e60((float)iVar7 + fVar1,0x3f800000);
          lVar2.baseDamage = uVar8;
          CustomSkillCreateController.RefreshBaseDamageUI(this,0);
          CustomSkillCreateController.RefreshSkillPointText(this,0);
          plVar5 = (int64 *)Resources.Load("Sound/SoundEffect/Button/TabButton",0);
          plVar6 = (int64 *)0;
          if ((plVar5 != (int64 *)0) && (*plVar5 == DAT_181e8f4a0)) {
            plVar6 = plVar5;
          }
          NGUITools.PlaySound(plVar6,0);
          return;
        }
    }

    // Token : 0x60013CA
    // RVA   : 0x6590D0   Offset: 0x657ED0   Length: 0x11E
    public void RefreshBaseDamageUI()
    {
        long lVar1;
        ulong uVar3;
        uint[] local_res8 = new uint[2];
        if (this.externalDamageUI != null) {
          lVar1 = GameObject.get_transform(this.externalDamageUI,0);
          if (lVar1 != null) {
            lVar1 = Transform.Find(lVar1,"BaseDamage",0);
            if (lVar1 != null) {
              lVar1 = Transform.Find(lVar1,"Text",0);
              if (lVar1 != null) {
                plVar2 = (int64 *)Component.GetComponent(lVar1,DAT_181e79538);
                if (this.draftSkillData != null) {
                  local_res8[0] = this.draftSkillData.baseDamage;
                  uVar3 = il2cpp_value_box(DAT_181e82730,local_res8);
                  uVar3 = String.Format("基础伤害 {0}",uVar3,0);
                  if (plVar2 != (int64 *)0) {
                    (**(code **)(*plVar2 + 0x5e8))(plVar2,uVar3,*(uint64 *)(*plVar2 + 0x5f0));
                    return;
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x60013CB
    // RVA   : 0x65A110   Offset: 0x658F10   Length: 0x10A
    public void ResetCreateUI()
    {
        long lVar1;
        ulong uVar2;
        if (this.skillName != null) {
          InputField.set_text(this.skillName,"",0);
          if (this.skillDescribe != null) {
            InputField.set_text(this.skillDescribe,"",0);
            this.draftSkillData = 0;
            if (this.externalDamageUI != null) {
              lVar1 = GameObject.get_transform(this.externalDamageUI,0);
              if (lVar1 != null) {
                lVar1 = Transform.Find(lVar1,"AddDamageRatioGrid",0);
                if (lVar1 != null) {
                  uVar2 = Component.get_gameObject(lVar1,0);
                  GlobalData.DeleteAllChild(uVar2,0);
                  GlobalData.DeleteAllChild(this.speAddDataGrid,0);
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x60013CC
    // RVA   : 0x656BA0   Offset: 0x6559A0   Length: 0x3F1
    public void FinishCreate()
    {
        bool cVar1;
        ulong uVar2;
        ulong uVar3;
        long lVar4;
        float fVar5;
        float fVar6;
        lVar4 = this.draftSkillData;
        if (lVar4 == null) {
          return;
        }
        if (lVar4.skillID != null) {
          return;
        }
        if (this.skillName == null) goto LAB_180656f8c;
        cVar1 = String.op_Inequality
                          (lVar4.name,
                           *(uint64 *)(this.skillName + 0x170),0);
        if (!cVar1) {
          if ((this.draftSkillData == null) || (this.skillDescribe == null))
          goto LAB_180656f8c;
          cVar1 = String.op_Inequality
                            (this.draftSkillData.describe,
                             *(uint64 *)(this.skillDescribe + 0x170),0);
          if (cVar1) goto LAB_180656cac;
        LAB_180656d2a:
          if (this.skillName == null) {
        LAB_180656f8c:
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          cVar1 = String.IsNullOrWhiteSpace(*(uint64 *)(this.skillName + 0x170),0);
          uVar3 = "请先输入武学名称";
          if (!cVar1) {
            if (this.draftSkillData == null) goto LAB_180656f8c;
            uVar3 = this.draftSkillData.name;
            cVar1 = CustomSkillCreateController.IsSkillNameTaken(uVar3,0);
            uVar3 = "已有同名武学，请更换名称";
            if (!cVar1) {
              uVar3 = this.draftSkillData;
              fVar5 = (float)CustomSkillCreateController.GetUsedBudget(uVar3,0);
              fVar6 = (float)CustomSkillCreateController.GetEffectBudget
                                       (this.draftSkillData,0);
              uVar3 = "功法点数超出上限";
              if (fVar5 <= fVar6 + 0.001) {
                if (this.draftSkillData != null) {
                  uVar2 = String.Format("确定要完成自创武学《{0}》吗？",
                                         this.draftSkillData.name,0);
                  uVar3 = this.draftSkillData;
                  fVar5 = (float)CustomSkillCreateController.GetEffectBudget(uVar3,0);
                  fVar6 = (float)CustomSkillCreateController.GetUsedBudget
                                           (this.draftSkillData,0);
                  if (0.001 < fVar5 - fVar6) {
                    uVar3 = String.Format("\n{0}武学点数尚未完全分配！</color>",
                                           *(uint64 *)(*(int64 *)(DAT_181e538e8 + 184) + 0x2e0),0)
                    ;
                    uVar2 = String.Concat(uVar2,uVar3,0);
                  }
                  lVar4 = **(int64 **)(DAT_181e88b68 + 184);
                  uVar3 = Component.get_gameObject(this,0);
                  if (lVar4 != null) {
                    SureMenu.CallSureMenu(lVar4,uVar2,"FinishCreateConfirmed",0,uVar3,1,0,0,0,0);
                    return;
                  }
                }
                goto LAB_180656f8c;
              }
            }
          }
          CustomSkillCreateController.ShowSubmitError(this,uVar3,0);
        }
        else {
        LAB_180656cac:
          CustomSkillCreateController.ResetSkillName(this,0);
          CustomSkillCreateController.ResetSkillDescribe(this,0);
          if ((this.draftSkillData == null) || (this.skillName == null))
          goto LAB_180656f8c;
          cVar1 = String.op_Inequality
                            (this.draftSkillData.name,
                             *(uint64 *)(this.skillName + 0x170),0);
          if (!cVar1) {
            if ((this.draftSkillData == null) || (this.skillDescribe == null))
            goto LAB_180656f8c;
            cVar1 = String.op_Inequality
                              (this.draftSkillData.describe,
                               *(uint64 *)(this.skillDescribe + 0x170),0);
            if (!cVar1) goto LAB_180656d2a;
          }
          lVar4 = FUN_1802106e0(0);
          if (lVar4 == null) goto LAB_180656f8c;
          GameController.ShowTextOnMouse(lVar4,"敏感词检测中，请稍候再确认",0);
        }
    }

    // Token : 0x60013CD
    // RVA   : 0x656650   Offset: 0x655450   Length: 0x54A
    public void FinishCreateConfirmed()
    {
        int iVar1;
        long lVar2;
        long lVar3;
        ulong uVar4;
        uint uVar7;
        CustomSkillCreateController.RefreshManaCost(this,0);
        if (this.draftSkillData != null) {
          KungfuSkillData.RefreshMaxAttackRange(this.draftSkillData,0);
          lVar2 = new ZhSegment(0);
          if (lVar2 != null) {
            lVar2.chapter = this.draftSkillData;
            if (((GameController._instance != null) &&
                (lVar3 = GameController._instance.worldData) != null) &&
               (lVar3 = WorldData.Player(lVar3,0)) != null) {
              lVar2.cityAreaID = lVar3.AreaMapRandomEventDatas;
              lVar2.villageAreaID = 1;
              if ((GameController._instance != null) &&
                 (lVar3 = GameController._instance.worldData) != null) {
                iVar1 = WorldData.AddCustomSkill(lVar3,lVar2,0);
                if (iVar1 < 0) {
                  Debug.LogError("[CustomSkill] 登记失败（草稿保留，可重试）",0);
                  return;
                }
                if (this.skillName != null) {
                  InputField.set_text(this.skillName,"",0);
                  if (this.skillDescribe != null) {
                    InputField.set_text(this.skillDescribe,"",0);
                    this.draftSkillData = 0;
                    if (((this.externalDamageUI != null) &&
                        (lVar2 = GameObject.get_transform(this.externalDamageUI,0)) != null)
                       && (lVar2 = Transform.Find(lVar2,"AddDamageRatioGrid",0)) != null) {
                      uVar4 = Component.get_gameObject(lVar2,0);
                      GlobalData.DeleteAllChild(uVar4,0);
                      GlobalData.DeleteAllChild(this.speAddDataGrid,0);
                      if (this.customSkillCreateUI != null) {
                        GameObject.SetActive(this.customSkillCreateUI,0,0);
                        if ((GameController._instance != null) &&
                           (lVar2 = GameController._instance.worldData,
                           lVar2 != null)) {
                          lVar2 = WorldData.Player(lVar2,0);
                          uVar4 = new KungfuSkillLvData(iVar1,0);
                          if (lVar2 != null) {
                            uVar7 = 0;
                            HeroData.GetSkill(lVar2,uVar4,1,1,0);
                            if ((GameController._instance != null) &&
                               (lVar2 = GameController._instance.worldData,
                               lVar2 != null)) {
                              lVar2 = WorldData.Player(lVar2,0);
                              lVar3 = new ItemData(3);
                              if (lVar3 != null) {
                                uVar4 = ItemData.SetBookData(lVar3,iVar1,0,0);
                                if (lVar2 != null) {
                                  HeroData.GetItem(lVar2,uVar4,1,0,CONCAT44(uVar7,0xffffffff),0,0);
                                  plVar5 = (int64 *)Resources.Load("Sound/SoundEffect/LevelUp",0);
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
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x60013CE
    // RVA   : 0x65AE40   Offset: 0x659C40   Length: 0x124
    private void ShowSubmitError(string msg)
    {
        if (GameController._instance != null) {
          GameController.ShowTextOnMouse(GameController._instance,msg,0);
          plVar1 = (int64 *)Resources.Load("Sound/SoundEffect/WrongClick",0);
          plVar2 = (int64 *)0;
          if ((plVar1 != (int64 *)0) && (*plVar1 == DAT_181e8f4a0)) {
            plVar2 = plVar1;
          }
          NGUITools.PlaySound(plVar2,0);
          return;
        }
    }

    // Token : 0x60013CF
    // RVA   : 0x658440   Offset: 0x657240   Length: 0x471
    private static bool IsSkillNameTaken(string name)
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        int iVar4;
        int iVar5;
        int aiStack_7c [5];
        int local_68;
        uint64 local_60;
        uint64 uStack_58;
        int64 local_50;
        uint32 local_48;
        uint32 uStack_44;
        uint32 uStack_40;
        uint32 uStack_3c;
        int64 local_38;
        uint32 local_30;
        uint32 uStack_2c;
        uint32 uStack_28;
        uint32 uStack_24;
        int64 local_20;
        local_res18 = 0;
        local_60 = 0;
        uStack_58 = 0;
        local_50 = 0;
        local_68 = 0;
        lVar2 = *(int64 *)(*(int64 *)(DAT_181e528f8 + 184) + 32);
        if (((lVar2 != null) && (lVar2 = *(int64 *)(lVar2 + 0x138)) != null) &&
           (lVar2 = FUN_1806e0520(lVar2,DAT_181e9db68)) != null) {
          ValueCollection.GetEnumerator(&local_30,lVar2,DAT_181e61da0);
          local_48 = local_30;
          uStack_44 = uStack_2c;
          uStack_40 = uStack_28;
          uStack_3c = uStack_24;
          local_38 = local_20;
          do {
            cVar1 = FUN_180dd6250(&local_48,DAT_181e7be30);
            if (!cVar1) {
              aiStack_7c[1] = 76;
              iVar4 = local_68 + 1;
              local_68 = iVar4;
              ZhSegment.Initialize(&local_48,DAT_181e7bdb0);
              goto LAB_1806586a2;
            }
            if (local_38 == 0) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            cVar1 = String.Equals(*(uint64 *)(local_38 + 32),name,5);
          } while (!cVar1);
          local_res18 = 1;
          aiStack_7c[1] = 191;
          iVar4 = local_68 + 1;
          local_68 = iVar4;
          ZhSegment.Initialize(&local_48,DAT_181e7bdb0);
        LAB_1806586a2:
          iVar5 = iVar4;
          if (iVar4 != 0) {
            if (aiStack_7c[iVar4] == 191) goto LAB_18065886a;
            local_68 = iVar4;
            if (aiStack_7c[iVar4] == 76) {
              iVar5 = iVar4 + -1;
              local_68 = iVar4 + -1;
            }
          }
          lVar2 = FUN_1802106e0(0);
          if ((lVar2 != null) && (uVar3 = *(uint64 *)(lVar2 + 32)) != null) {
            if (*(int64 *)(uVar3 + 0x268) != 0) {
              lVar2 = FUN_1802106e0(0);
              if ((((lVar2 == null) || (*(int64 *)(lVar2 + 32) == 0)) ||
                  (lVar2 = *(int64 *)(*(int64 *)(lVar2 + 32) + 0x268)) == null) ||
                 (lVar2 = FUN_1806e0520(lVar2,DAT_181e9a998)) == null) throw; // [null/range check failed]
              ValueCollection.GetEnumerator(&local_30,lVar2,DAT_181e61130);
              local_50 = local_20;
              do {
                cVar1 = FUN_180dd6250(&local_60,DAT_181e79db0);
                if (!cVar1) {
                  aiStack_7c[(int64)iVar5 + 1] = 189;
                  iVar4 = local_68 + 1;
                  local_68 = iVar4;
                  uVar3 = ZhSegment.Initialize(&local_60,DAT_181e79d30);
                  goto LAB_180658859;
                }
              } while (((local_50 == 0) || (*(int64 *)(local_50 + 16) == 0)) ||
                      (cVar1 = String.Equals(*(uint64 *)(*(int64 *)(local_50 + 16) + 32),
                                              name,5), !cVar1));
              local_res18 = 1;
              aiStack_7c[(int64)iVar5 + 1] = 191;
              iVar4 = local_68 + 1;
              local_68 = iVar4;
              uVar3 = ZhSegment.Initialize(&local_60,DAT_181e79d30);
        LAB_180658859:
              if ((iVar4 != 0) && (uVar3 = (uint64)iVar4, aiStack_7c[uVar3] == 191)) {
        LAB_18065886a:
                return (uint64)local_res18;
              }
            }
            return uVar3 & 0xffffffffffffff00;
          }
        }
    }

    // Token : 0x60013D0
    // RVA   : 0x6575B0   Offset: 0x6563B0   Length: 0x81
    public static int GetCreateSkillNeed(int lv)
    {
        long lVar1;
        ulong uVar2;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181e9bac0 + 184) + 40);
        if (lVar1 != null) {
          if (lv < *(uint32 *)(lVar1 + 24)) {
            return lVar1[lv];
          }
          uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1801e02d0(uVar2,0);
        }
    }

    // Token : 0x60013D1
    // RVA   : 0x657640   Offset: 0x656440   Length: 0x20A
    public static float GetEffectBudgetRate(KungfuSkillData draft)
    {
        uint uVar1;
        uint uVar2;
        long lVar3;
        ulong uVar4;
        float fVar5;
        if ((GameController._instance != null) &&
           (lVar3 = GameController._instance.worldData) != null) {
          lVar3 = WorldData.Player(lVar3,0);
          if ((lVar3 != null) && ((draft != null && (lVar3 = lVar3.monthFreshBountyTime) != null))) {
            uVar1 = *(uint32 *)(draft + 48);
            if (lVar3.cityAreaID <= uVar1) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            uVar2 = *(uint32 *)(draft + 52);
            fVar5 = lVar3.chapter[uVar1];
            lVar3 = *(int64 *)(*(int64 *)(DAT_181e9bac0 + 184) + 40);
            if (lVar3 != null) {
              if (uVar2 < lVar3.cityAreaID) {
                fVar5 = (float)FUN_180f34e60(fVar5 / (float)*(int *)(lVar3 + 32 +
                                                                    (int64)(int)uVar2 * 4));
                return (fVar5 - 1.0) * 0.5 + 1.0;
              }
              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar4,0);
            }
          }
        }
    }

    // Token : 0x60013D2
    // RVA   : 0x657850   Offset: 0x656650   Length: 0x13E
    public static float GetEffectBudget(KungfuSkillData draft)
    {
        long lVar1;
        uint uVar2;
        ulong uVar3;
        if (draft == null) {
          return;
        }
        uVar2 = Mathf.Clamp(*(uint32 *)(draft + 52),0,5);
        if (*(int *)(draft + 48) < 3) {
          lVar1 = CustomSkillCreateController.EffectBudget;
          if (lVar1 == null) {
        LAB_180657989:
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          if (*(uint32 *)(lVar1 + 24) <= uVar2) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar3,0);
          }
        }
        else {
          lVar1 = CustomSkillCreateController.ExternalEffectBudget;
          if (lVar1 == null) goto LAB_180657989;
          if (*(uint32 *)(lVar1 + 24) <= uVar2) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar3,0);
          }
        }
        CustomSkillCreateController.GetEffectBudgetRate(draft,0);
        Mathf.RoundToInt();
    }

    // Token : 0x60013D3
    // RVA   : 0x657B90   Offset: 0x656990   Length: 0x2C7
    public static float GetUsedBudget(KungfuSkillData draft)
    {
        long lVar1;
        long lVar2;
        uint uVar3;
        long lVar4;
        uint uVar5;
        long lVar6;
        float fVar7;
        float fVar8;
        uint uVar10;
        ulong uVar9;
        if (draft == null) {
          return 0;
        }
        if (*(int *)(draft + 48) < 3) {
          if (*(int64 *)(draft + 96) == 0) {
            fVar7 = 0.0;
            uVar10 = 0;
          }
          else {
            uVar9 = HeroSpeAddData.GetValue(*(int64 *)(draft + 96),0);
            uVar10 = (uint32)((uint64)uVar9 >> 32);
            if ((*(int *)(draft + 48) == 0) && (*(int64 *)(draft + 96) != 0)) {
              fVar8 = (float)HeroSpeAddData.Get(*(int64 *)(draft + 96),57);
              if (*(int64 *)(draft + 96) == 0) goto LAB_180657e52;
              fVar7 = (float)HeroSpeAddData.Get(*(int64 *)(draft + 96),59);
              fVar7 = fVar7 * 0.25 + fVar8 * 0.5;
            }
            else {
              fVar7 = 0.0;
            }
            fVar7 = (float)uVar9 - fVar7;
          }
        }
        else {
          fVar8 = *(float *)(draft + 60);
          lVar1 = *(int64 *)(draft + 72);
          if (lVar1 != null) {
            uVar5 = 0;
            lVar6 = 32;
            uVar3 = 0;
            lVar4 = 32;
            fVar7 = 0.0;
            while (lVar2 = *(int64 *)(lVar1 + 16)) != null {
              if ((int)*(uint32 *)(lVar2 + 24) <= (int)uVar3) {
                uVar3 = 0;
                lVar4 = 32;
                goto LAB_180657d80;
              }
              if (*(uint32 *)(lVar2 + 24) <= uVar3) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              uVar3 = uVar3 + 1;
              fVar7 = fVar7 + *(float *)(*(int64 *)(lVar2 + 16) + lVar4);
              lVar4 = lVar4 + 4;
            }
        LAB_180657e52:
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          fVar7 = 0.0;
        LAB_180657e26:
          uVar10 = 0;
          fVar7 = fVar7 + fVar8;
          if (*(int64 *)(draft + 104) != 0) {
            fVar8 = (float)HeroSpeAddData.GetValue(*(int64 *)(draft + 104),0);
            fVar7 = fVar7 + fVar8;
          }
        }
        return CONCAT44(uVar10,fVar7);
        LAB_180657d80:
        lVar2 = *(int64 *)(lVar1 + 24);
        if (lVar2 == null) goto LAB_180657e52;
        if ((int)*(uint32 *)(lVar2 + 24) <= (int)uVar3) goto LAB_180657db2;
        if (*(uint32 *)(lVar2 + 24) <= uVar3) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        uVar3 = uVar3 + 1;
        fVar7 = fVar7 + *(float *)(*(int64 *)(lVar2 + 16) + lVar4);
        lVar4 = lVar4 + 4;
        goto LAB_180657d80;
        LAB_180657db2:
        lVar4 = *(int64 *)(lVar1 + 32);
        if (lVar4 == null) goto LAB_180657e52;
        if ((int)*(uint32 *)(lVar4 + 24) <= (int)uVar5) {
          fVar7 = *(float *)(lVar1 + 40) * 10.0 + fVar7 + *(float *)(lVar1 + 44) +
                  *(float *)(lVar1 + 48) * 10.0 + *(float *)(lVar1 + 52);
          goto LAB_180657e26;
        }
        if (*(uint32 *)(lVar4 + 24) <= uVar5) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        uVar5 = uVar5 + 1;
        fVar7 = fVar7 + *(float *)(*(int64 *)(lVar4 + 16) + lVar6);
        lVar6 = lVar6 + 4;
        goto LAB_180657db2;
    }

    // Token : 0x60013D4
    // RVA   : 0x657E60   Offset: 0x656C60   Length: 0x73
    public static float GetUsedHpManaBudget(KungfuSkillData draft)
    {
        float fVar1;
        float fVar2;
        if (((draft != null) && (*(int *)(draft + 48) == 0)) && (*(int64 *)(draft + 96) != 0)) {
          fVar1 = (float)HeroSpeAddData.Get(*(int64 *)(draft + 96),57);
          if (*(int64 *)(draft + 96) != 0) {
            fVar2 = (float)HeroSpeAddData.Get(*(int64 *)(draft + 96),59);
            return fVar2 * 0.25 + fVar1 * 0.5;
          }
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        return 0.0;
    }

    // Token : 0x60013D5
    // RVA   : 0x656FA0   Offset: 0x655DA0   Length: 0x170
    public static float GetAttriRatioValue(AttriNumData ratio)
    {
        long lVar1;
        uint uVar2;
        uint uVar3;
        long lVar4;
        long lVar5;
        float fVar6;
        if (ratio == null) {
          return 0.0;
        }
        uVar3 = 0;
        lVar5 = 32;
        uVar2 = 0;
        lVar4 = 32;
        fVar6 = 0.0;
        while (lVar1 = *(int64 *)(ratio + 16)) != null {
          if ((int)*(uint32 *)(lVar1 + 24) <= (int)uVar2) {
            uVar2 = 0;
            lVar4 = 32;
            goto LAB_180657050;
          }
          if (*(uint32 *)(lVar1 + 24) <= uVar2) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          uVar2 = uVar2 + 1;
          fVar6 = fVar6 + *(float *)(*(int64 *)(lVar1 + 16) + lVar4);
          lVar4 = lVar4 + 4;
        }
        LAB_18065710b:
                          // WARNING: Subroutine does not return
        FUN_1801e0300();
        LAB_180657050:
        lVar1 = *(int64 *)(ratio + 24);
        if (lVar1 == null) goto LAB_18065710b;
        if ((int)*(uint32 *)(lVar1 + 24) <= (int)uVar2) goto LAB_180657083;
        if (*(uint32 *)(lVar1 + 24) <= uVar2) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        uVar2 = uVar2 + 1;
        fVar6 = fVar6 + *(float *)(*(int64 *)(lVar1 + 16) + lVar4);
        lVar4 = lVar4 + 4;
        goto LAB_180657050;
        LAB_180657083:
        while( true ) {
          lVar4 = *(int64 *)(ratio + 32);
          if (lVar4 == null) break;
          if ((int)*(uint32 *)(lVar4 + 24) <= (int)uVar3) {
            return *(float *)(ratio + 40) * 10.0 + fVar6 + *(float *)(ratio + 44) +
                   *(float *)(ratio + 48) * 10.0 + *(float *)(ratio + 52);
          }
          if (*(uint32 *)(lVar4 + 24) <= uVar3) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          uVar3 = uVar3 + 1;
          fVar6 = fVar6 + *(float *)(*(int64 *)(lVar4 + 16) + lVar5);
          lVar5 = lVar5 + 4;
        }
        goto LAB_18065710b;
    }

    // Token : 0x60013D6
    // RVA   : 0x659EF0   Offset: 0x658CF0   Length: 0x210
    public static void ResetAttriRatioValue(AttriNumData ratio)
    {
        long lVar1;
        uint uVar2;
        uint uVar3;
        long lVar4;
        long lVar5;
        if (ratio == null) {
          return;
        }
        uVar2 = 0;
        lVar5 = 32;
        uVar3 = 0;
        lVar4 = 32;
        while (lVar1 = *(int64 *)(ratio + 16)) != null {
          if ((int)*(uint32 *)(lVar1 + 24) <= (int)uVar3) {
            uVar3 = 0;
            lVar4 = 32;
            goto LAB_180659fd2;
          }
          if (*(uint32 *)(lVar1 + 24) <= uVar3) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          if (*(float *)(lVar4 + *(int64 *)(lVar1 + 16)) != 0.0) {
            if (*(int64 *)(ratio + 16) == 0) break;
            FUN_181769c70(*(int64 *)(ratio + 16),uVar3,0x3f800000,DAT_181e835b0);
          }
          uVar3 = uVar3 + 1;
          lVar4 = lVar4 + 4;
        }
        LAB_18065a0fb:
                          // WARNING: Subroutine does not return
        FUN_1801e0300();
        LAB_180659fd2:
        lVar1 = *(int64 *)(ratio + 24);
        if (lVar1 == null) goto LAB_18065a0fb;
        if ((int)*(uint32 *)(lVar1 + 24) <= (int)uVar3) goto LAB_18065a02a;
        if (*(uint32 *)(lVar1 + 24) <= uVar3) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        if (*(float *)(lVar4 + *(int64 *)(lVar1 + 16)) != 0.0) {
          if (*(int64 *)(ratio + 24) == 0) goto LAB_18065a0fb;
          FUN_181769c70(*(int64 *)(ratio + 24),uVar3,0x3f800000,DAT_181e835b0);
        }
        uVar3 = uVar3 + 1;
        lVar4 = lVar4 + 4;
        goto LAB_180659fd2;
        LAB_18065a02a:
        lVar4 = *(int64 *)(ratio + 32);
        if (lVar4 == null) goto LAB_18065a0fb;
        if ((int)*(uint32 *)(lVar4 + 24) <= (int)uVar2) {
          if (*(float *)(ratio + 40) != 0.0) {
            *(uint32 *)(ratio + 40) = 0x3dcccccd;
          }
          if (*(float *)(ratio + 44) != 0.0) {
            *(uint32 *)(ratio + 44) = 0x3f800000;
          }
          if (*(float *)(ratio + 48) != 0.0) {
            *(uint32 *)(ratio + 48) = 0x3dcccccd;
          }
          if (*(float *)(ratio + 52) == 0.0) {
            return;
          }
          *(uint32 *)(ratio + 52) = 0x3f800000;
          return;
        }
        if (*(uint32 *)(lVar4 + 24) <= uVar2) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        if (*(float *)(lVar5 + *(int64 *)(lVar4 + 16)) != 0.0) {
          if (*(int64 *)(ratio + 32) == 0) goto LAB_18065a0fb;
          FUN_181769c70(*(int64 *)(ratio + 32),uVar2,0x3f800000,DAT_181e835b0);
        }
        uVar2 = uVar2 + 1;
        lVar5 = lVar5 + 4;
        goto LAB_18065a02a;
    }

    // Token : 0x60013D7
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

    // Token : 0x60013D8
    // RVA   : 0x65B0D0   Offset: 0x659ED0   Length: 0x1CA
    private static void /*cctor*/()
    {
        ulong uVar1;
        uVar1 = FUN_1801dfd90(DAT_181e836f8,6);
        RuntimeHelpers.InitializeArray(uVar1,DAT_181e9f020,0);
        CustomSkillCreateController.SpeAddNumMax = uVar1;
        uVar1 = FUN_1801dfd90(DAT_181e854f8,6);
        RuntimeHelpers.InitializeArray(uVar1,DAT_181e9f5f8,0);
        CustomSkillCreateController.ManaCostRate = uVar1;
        uVar1 = FUN_1801dfd90(DAT_181e836f8,6);
        RuntimeHelpers.InitializeArray(uVar1,DAT_181e9ef10,0);
        CustomSkillCreateController.EffectBudget = uVar1;
        uVar1 = FUN_1801dfd90(DAT_181e836f8,6);
        RuntimeHelpers.InitializeArray(uVar1,DAT_181e9f4e8,0);
        CustomSkillCreateController.ExternalEffectBudget = uVar1;
        uVar1 = FUN_1801dfd90(DAT_181e836f8,6);
        RuntimeHelpers.InitializeArray(uVar1,DAT_181e9ee88,0);
        CustomSkillCreateController.CreateSkillNeed = uVar1;
    }

}
