// ============================================================
// Type  : WeaponResearchUIController
// Token : 0x20003BD
// ============================================================

public class WeaponResearchUIController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001E6C
    public GameObject weaponResearchUI;

    // Token: 0x4001E6D
    public GameObject researchTargetItemIcon;

    // Token: 0x4001E6E
    public GameObject researchTargetClearButton;

    // Token: 0x4001E6F
    private static WeaponResearchUIController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600241B
    // RVA   : 0x96FEA0   Offset: 0x96ECA0   Length: 0x36
    public static WeaponResearchUIController get_Instance()
    {
        return **(uint64 **)(DAT_181e95380 + 184);
    }

    // Token : 0x600241C
    // RVA   : 0x96D740   Offset: 0x96C540   Length: 0x43
    private void Awake()
    {
        puVar1 = *(uint64 **)(DAT_181e95380 + 184);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x600241D
    // RVA   : 0x96DB60   Offset: 0x96C960   Length: 0xC7
    public void HideWeaponResearchUI()
    {
        ulong uVar1;
        bool cVar2;
        uVar1 = this.researchTargetItemIcon;
        cVar2 = Object.op_Inequality(uVar1,0,0);
        if (cVar2) {
          uVar1 = this.researchTargetItemIcon;
          Object.Destroy(uVar1,0);
          this.researchTargetItemIcon = 0;
        }
        if (this.weaponResearchUI != null) {
          GameObject.SetActive(this.weaponResearchUI,0,0);
          return;
        }
    }

    // Token : 0x600241E
    // RVA   : 0x96F2B0   Offset: 0x96E0B0   Length: 0xBE6
    public void ShowWeaponResearchUI()
    {
        var pStatics_38e8 = *(int64*)(DAT_181e538e8 + 184);
        float fVar1;
        int iVar2;
        long lVar3;
        ulong uVar4;
        long lVar5;
        ulong uVar6;
        ulong uVar7;
        uint[] local_res8 = new uint[2];
        float[] local_res18 = new float[4];
        if (this.weaponResearchUI != null) {
          GameObject.SetActive(this.weaponResearchUI,1,0);
          if (this.weaponResearchUI != null) {
            lVar3 = GameObject.get_transform(this.weaponResearchUI,0);
            if (lVar3 != null) {
              lVar3 = Transform.Find(lVar3,"Title",0);
              if (lVar3 != null) {
                uVar4 = Component.GetComponent(lVar3,DAT_181e79538);
                lVar3 = *(int64 *)(pStatics_38e8 + 0x4a8);
                if ((GameController._instance != null) &&
                   (lVar5 = GameController._instance.worldData) != null) {
                  lVar5 = WorldData.Player(lVar5,0);
                  if (lVar5 != null) {
                    iVar2 = HeroData.GetWeaponResearchWeaponType(lVar5,0);
                    if (lVar3 != null) {
                      if (*(uint32 *)(lVar3 + 24) <= iVar2 + 3U) {
                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                      }
                      uVar6 = String.Concat(*(uint64 *)
                                              (*(int64 *)(lVar3 + 16) + 32 +
                                              (int64)(int)(iVar2 + 3U) * 8),"研究",0);
                      LTLocalization.SetText(uVar4,uVar6,0);
                      if (this.weaponResearchUI != null) {
                        lVar3 = GameObject.get_transform(this.weaponResearchUI,0);
                        if (lVar3 != null) {
                          lVar3 = Transform.Find(lVar3,"ResearchTarget",0);
                          if (lVar3 != null) {
                            lVar3 = Transform.Find(lVar3,"Label",0);
                            if (lVar3 != null) {
                              uVar4 = Component.GetComponent(lVar3,DAT_181e79538);
                              lVar3 = *(int64 *)(pStatics_38e8 + 0x4a8);
                              if ((GameController._instance != null) &&
                                 (lVar5 = GameController._instance.worldData,
                                 lVar5 != null)) {
                                lVar5 = WorldData.Player(lVar5,0);
                                if (lVar5 != null) {
                                  iVar2 = HeroData.GetWeaponResearchWeaponType(lVar5,0);
                                  if (lVar3 != null) {
                                    if (*(uint32 *)(lVar3 + 24) <= iVar2 + 3U) {
                                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                    }
                                    uVar6 = String.Concat(*(uint64 *)
                                                            (*(int64 *)(lVar3 + 16) + 32 +
                                                            (int64)(int)(iVar2 + 3U) * 8),"兵器\n（消耗）"
                                                           ,0);
                                    LTLocalization.SetText(uVar4,uVar6,0);
                                    if (this.weaponResearchUI != null) {
                                      lVar3 = GameObject.get_transform(this.weaponResearchUI,0);
                                      if (lVar3 != null) {
                                        lVar3 = Transform.Find(lVar3,"ResearchLv",0);
                                        if (lVar3 != null) {
                                          uVar4 = Component.GetComponent(lVar3,DAT_181e79538);
                                          if (((GameController._instance != null) &&
                                              (lVar3 = *(int64 *)
                                                        (GameController._instance + 32),
                                              lVar3 != null)) &&
                                             (lVar3 = *(int64 *)(lVar3 + 0x1e8)) != null) {
                                            uVar6 = Int32.ToString(lVar3 + 16,0);
                                            uVar6 = String.Concat("等级",uVar6,0);
                                            LTLocalization.SetText(uVar4,uVar6,0);
                                            if (this.weaponResearchUI != null) {
                                              lVar3 = GameObject.get_transform
                                                                (this.weaponResearchUI,0);
                                              if (lVar3 != null) {
                                                lVar3 = Transform.Find(lVar3,"ResearchLvAdd",0);
                                                if (lVar3 != null) {
                                                  uVar4 = Component.GetComponent(lVar3,DAT_181e79538);
                                                  lVar3 = *(int64 *)
                                                           (pStatics_38e8 + 0x4a8);
                                                  if ((GameController._instance != null) &&
                                                     (lVar5 = *(int64 *)
                                                               (GameController._instance +
                                                               32), lVar5 != null)) {
                                                    lVar5 = WorldData.Player(lVar5,0);
                                                    if (lVar5 != null) {
                                                      iVar2 = HeroData.GetWeaponResearchWeaponType
                                                                        (lVar5,0);
                                                      if (lVar3 != null) {
                                                        if (*(uint32 *)(lVar3 + 24) <= iVar2 + 3U) {
                                                          ThrowHelper.ThrowArgumentOutOfRangeException(0)
                                                          ;
                                                        }
                                                        uVar6 = *(uint64 *)
                                                                 (*(int64 *)(lVar3 + 16) + 32 +
                                                                 (int64)(int)(iVar2 + 3U) * 8);
                                                        if (((GameController._instance != null)
                                                            && (lVar3 = *(int64 *)
                                                                         (**(int64 **)
                                                                            (DAT_181e52870 + 184) + 32)
                                                               , lVar3 != null)) &&
                                                           (lVar3 = *(int64 *)(lVar3 + 0x1e8),
                                                           lVar3 != null)) {
                                                          local_res8[0] = *(uint32 *)(lVar3 + 16);
                                                          uVar7 = il2cpp_value_box(DAT_181e60808,
                                                                                   local_res8);
                                                          uVar6 = String.Format("等级加成\n{0}威力+{1}%",uVar6,uVar7
                                                                                 ,0);
                                                          LTLocalization.SetText(uVar4,uVar6,0);
                                                          if (this.weaponResearchUI != null) {
                                                            lVar3 = GameObject.get_transform
                                                                              (*(int64 *)
                                                                                (this + 24),0);
                                                            if (lVar3 != null) {
                                                              lVar3 = Transform.Find(lVar3,"ExpBarBack",
                                                                                      0);
                                                              if (lVar3 != null) {
                                                                lVar3 = Transform.Find(lVar3,
                                                        "ExpText",0);
                                                        if (lVar3 != null) {
                                                          uVar4 = Component.GetComponent
                                                                            (lVar3,DAT_181e79538);
                                                          if (((GameController._instance != null
                                                               ) && (lVar3 = *(int64 *)
                                                                              (**(int64 **)
                                                                                 (DAT_181e52870 + 184) +
                                                                              32), lVar3 != null)) &&
                                                             (lVar3 = *(int64 *)(lVar3 + 0x1e8),
                                                             lVar3 != null)) {
                                                            uVar6 = Single.ToString(lVar3 + 20,
                                                                                     "f0",0);
                                                            if (((GameController._instance !=
                                                                  0) && (lVar3 = *(int64 *)
                                                                                  (**(int64 **)
                                                                                     (DAT_181e52870 + 184
                                                                                     ) + 32), lVar3 != null
                                                                        )) &&
                                                               (lVar3 = *(int64 *)(lVar3 + 0x1e8),
                                                               lVar3 != null)) {
                                                              iVar2 = *(int *)(lVar3 + 16);
                                                              local_res18[0] =
                                                                   (float)((iVar2 + 2) * (iVar2 + 1)) *
                                                                   0.5;
                                                              uVar7 = il2cpp_value_box(DAT_181e82730,
                                                                                       local_res18);
                                                              uVar6 = String.Format("{0}/{1}",uVar6,
                                                                                     uVar7,0);
                                                              LTLocalization.SetText(uVar4,uVar6,0);
                                                              if (this.weaponResearchUI != null) {
                                                                lVar3 = GameObject.get_transform
                                                                                  (*(int64 *)
                                                                                    (this + 24),0);
                                                                if (lVar3 != null) {
                                                                  lVar3 = Transform.Find(lVar3,
                                                        "ExpBarBack",0);
                                                        if (lVar3 != null) {
                                                          lVar3 = Transform.Find(lVar3,"ExpBar",0);
                                                          if (lVar3 != null) {
                                                            lVar3 = Component.GetComponent
                                                                              (lVar3,DAT_181e777b8);
                                                            if (((GameController._instance !=
                                                                  0) && (lVar5 = *(int64 *)
                                                                                  (**(int64 **)
                                                                                     (DAT_181e52870 + 184
                                                                                     ) + 32), lVar5 != null
                                                                        )) &&
                                                               (lVar5 = lVar5.weaponResearchData,
                                                               lVar5 != null)) {
                                                              fVar1 = *(float *)(lVar5 + 20);
                                                              if (((*(byte *)(DAT_181e52870 + 0x133) & 4)
                                                                   != 0) &&
                                                                 (*(int *)(DAT_181e52870 + 224) == 0)) {
                                                                il2cpp_runtime_class_init();
                                                              }
                                                              if ((((GameController._instance
                                                                     != 0) &&
                                                                   (lVar5 = *(int64 *)
                                                                             (**(int64 **)
                                                                                (DAT_181e52870 + 184) +
                                                                             32), lVar5 != null)) &&
                                                                  (lVar5 = lVar5.weaponResearchData,
                                                                  lVar5 != null)) && (lVar3 != null)) {
                                                                iVar2 = lVar5.chapter;
                                                                Image.set_fillAmount
                                                                          (lVar3,fVar1 / ((float)((iVar2 +
                                                                                                  2) * (
                                                        iVar2 + 1)) * 0.5),0);
                                                        if (((GameController._instance != null)
                                                            && (lVar3 = *(int64 *)
                                                                         (**(int64 **)
                                                                            (DAT_181e52870 + 184) + 32)
                                                               , lVar3 != null)) &&
                                                           (lVar3 = *(int64 *)(lVar3 + 0x1e8),
                                                           lVar3 != null)) {
                                                          if (0 < *(int *)(lVar3 + 40)) {
                                                            if (((GameController._instance ==
                                                                  0) || (lVar3 = *(int64 *)
                                                                                  (**(int64 **)
                                                                                     (DAT_181e52870 + 184
                                                                                     ) + 32), lVar3 == null
                                                                        )) ||
                                                               (lVar3 = *(int64 *)(lVar3 + 0x1e8),
                                                               lVar3 == null)) {
        LAB_18096fe91:
                          // WARNING: Subroutine does not return
                                                              FUN_1801e0300();
                                                            }
                                                            if (*(int64 *)(lVar3 + 24) != 0) {
                                                              if (((*(byte *)(DAT_181e52870 + 0x133) & 4)
                                                                   != 0) &&
                                                                 (*(int *)(DAT_181e52870 + 224) == 0)) {
                                                                il2cpp_runtime_class_init();
                                                              }
                                                              lVar3 = FUN_1802106e0(0);
                                                              if (((lVar3 == null) ||
                                                                  (*(int64 *)(lVar3 + 32) == 0)) ||
                                                                 (lVar3 = *(int64 *)
                                                                           (*(int64 *)(lVar3 + 32) +
                                                                           0x1e8), lVar3 == null))
                                                              goto LAB_18096fe91;

                                                        WeaponResearchUIController.CreateResearchTargetItemIcon
                                                                  (this,*(uint64 *)(lVar3 + 24),0
                                                                  );
                                                        }
                                                        }
                                                        WeaponResearchUIController.RefreshUI(this,0);
                                                        plVar8 = (int64 *)
                                                                 Resources.Load("Sound/SoundEffect/OpenBook",0);
                                                        plVar9 = (int64 *)0;
                                                        if ((plVar8 != (int64 *)0) &&
                                                           (*plVar8 == DAT_181e8f4a0)) {
                                                          plVar9 = plVar8;
                                                        }
                                                        NGUITools.PlaySound(plVar9,0);
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

    // Token : 0x600241F
    // RVA   : 0x96DC30   Offset: 0x96CA30   Length: 0xEAD
    public void RefreshUI()
    {
        var pStatics_38e8 = *(int64*)(DAT_181e538e8 + 184);
        bool cVar1;
        int iVar2;
        long lVar3;
        ulong uVar4;
        long lVar6;
        ulong uVar7;
        ulong uVar8;
        uint[] local_res18 = new uint[2];
        uint[] local_res20 = new uint[2];
        uint local_28;
        uint uStack_24;
        uint uStack_20;
        uint32 uStack_1c;
        if (((GameController._instance == null) ||
            (lVar3 = GameController._instance.worldData) == null) ||
           (lVar3 = lVar3.weaponResearchData) == null) goto LAB_18096eacc;
        lVar6 = this.weaponResearchUI;
        if (lVar3.forceAreaID < 1) {
          if (((lVar6 == null) || (lVar3 = GameObject.get_transform(lVar6,0)) == null) ||
             ((lVar3 = Transform.Find(lVar3,"SureButton",0), lVar3 == null ||
              (lVar3 = Transform.Find(lVar3,"Label",0)) == null))) {
        LAB_18096eacc:
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          uVar4 = Component.GetComponent(lVar3,DAT_181e79538);
          LTLocalization.SetText(uVar4,"确认",0);
          if ((((this.weaponResearchUI == null) ||
               (lVar3 = GameObject.get_transform(this.weaponResearchUI,0)) == null) ||
              (lVar3 = Transform.Find(lVar3,"SureButton",0)) == null) ||
             (lVar3 = Transform.Find(lVar3,"Label",0)) == null) goto LAB_18096eacc;
          plVar5 = (int64 *)Component.GetComponent(lVar3,DAT_181e79538);
          lVar3 = pStatics_38e8;
          if (plVar5 == (int64 *)0) goto LAB_18096eacc;
          local_28 = *(uint32 *)(lVar3 + 0x380);
          uStack_24 = *(uint32 *)(lVar3 + 900);
          uStack_20 = *(uint32 *)(lVar3 + 0x388);
          uStack_1c = *(uint32 *)(lVar3 + 0x38c);
          (**(code **)(*plVar5 + 0x2a8))(plVar5,&local_28,*(uint64 *)(*plVar5 + 0x2b0));
          if (((this.weaponResearchUI == null) ||
              (lVar3 = GameObject.get_transform(this.weaponResearchUI,0)) == null) ||
             ((lVar3 = Transform.Find(lVar3,"ResearchTarget",0), lVar3 == null ||
              (lVar3 = Component.GetComponent(lVar3,DAT_181e76ab8)) == null))) goto LAB_18096eacc;
          Selectable.set_interactable(lVar3,1,0);
          if (((this.weaponResearchUI == null) ||
              (lVar3 = GameObject.get_transform(this.weaponResearchUI,0)) == null) ||
             (lVar3 = Transform.Find(lVar3,"SureButton",0)) == null) goto LAB_18096eacc;
          lVar3 = Component.get_gameObject(lVar3,0);
          if (lVar3 == null) goto LAB_18096eacc;
          GameObject.SetActive(lVar3,1,0);
          uVar4 = this.researchTargetItemIcon;
          cVar1 = Object.op_Inequality(uVar4,0,0);
          lVar3 = this.weaponResearchUI;
          if (cVar1) {
            if (((lVar3 == null) || (lVar3 = GameObject.get_transform(lVar3,0)) == null) ||
               ((lVar3 = Transform.Find(lVar3,"SureButton",0), lVar3 == null ||
                (lVar3 = Component.GetComponent(lVar3,DAT_181e76ab8)) == null))) {
        LAB_18096ead2:
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            Selectable.set_interactable(lVar3,1,0);
            if (((this.weaponResearchUI == null) ||
                (lVar3 = GameObject.get_transform(this.weaponResearchUI,0)) == null) ||
               (lVar3 = Transform.Find(lVar3,"ResearchText",0)) == null) goto LAB_18096ead2;
            uVar4 = Component.GetComponent(lVar3,DAT_181e79538);
            local_res18[0] = WeaponResearchUIController.GetResearchDay(this,0);
            uVar7 = il2cpp_value_box(DAT_181e60808,local_res18);
            local_res20[0] = WeaponResearchUIController.GetExpNum(this,0);
            uVar8 = il2cpp_value_box(DAT_181e60808,local_res20);
            uVar7 = String.Format("研究时间 {0}日\n获取经验 {1}",uVar7,uVar8,0);
            LTLocalization.SetText(uVar4,uVar7,0);
            if (((this.weaponResearchUI == null) ||
                (lVar3 = GameObject.get_transform(this.weaponResearchUI,0)) == null) ||
               (lVar3 = Transform.Find(lVar3,"ResearchExtraAdd",0)) == null) goto LAB_18096ead2;
            uVar4 = Component.GetComponent(lVar3,DAT_181e79538);
            if ((((this.researchTargetItemIcon == null) ||
                 (lVar3 = GameObject.GetComponent(this.researchTargetItemIcon,DAT_181e55168),
                 lVar3 == null)) || (lVar3.villageAreaID == null)) ||
               ((lVar3 = *(int64 *)(lVar3.villageAreaID + 96), lVar3 == null ||
                (lVar3 = lVar3.forceAreaID) == null))) goto LAB_18096ead2;
            uVar7 = HeroSpeAddData.GetDescribe(lVar3,1,1,1,0,0);
            lVar3 = *(int64 *)(pStatics_38e8 + 0x4a8);
            if ((((GameController._instance == null) ||
                 (lVar6 = GameController._instance.worldData) == null) ||
                (lVar6 = WorldData.Player(lVar6,0)) == null) ||
               (iVar2 = HeroData.GetWeaponResearchWeaponType(lVar6,0), lVar3 == null)) goto LAB_18096ead2;
            if (lVar3.cityAreaID <= iVar2 + 3U) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            uVar7 = String.Format("{1}特效\n{0}",uVar7,
                                   *(uint64 *)
                                    (lVar3.chapter + 32 + (int64)(int)(iVar2 + 3U) * 8)
                                   ,0);
            LTLocalization.SetText(uVar4,uVar7,0);
            lVar3 = this.researchTargetClearButton;
            if (lVar3 == null) goto LAB_18096ead2;
            uVar4 = 1;
            goto LAB_18096e28f;
          }
          if (((lVar3 == null) || (lVar3 = GameObject.get_transform(lVar3,0)) == null) ||
             ((lVar3 = Transform.Find(lVar3,"SureButton",0), lVar3 == null ||
              (lVar3 = Component.GetComponent(lVar3,DAT_181e76ab8)) == null))) goto LAB_18096eacc;
          Selectable.set_interactable(lVar3,0,0);
          if (((this.weaponResearchUI == null) ||
              (lVar3 = GameObject.get_transform(this.weaponResearchUI,0)) == null) ||
             (lVar3 = Transform.Find(lVar3,"ResearchExtraAdd",0)) == null) goto LAB_18096eacc;
          uVar4 = Component.GetComponent(lVar3,DAT_181e79538);
          LTLocalization.SetText(uVar4,"",0);
          if (((this.weaponResearchUI == null) ||
              (lVar3 = GameObject.get_transform(this.weaponResearchUI,0)) == null) ||
             (lVar3 = Transform.Find(lVar3,"ResearchText",0)) == null) goto LAB_18096eacc;
          uVar4 = Component.GetComponent(lVar3,DAT_181e79538);
          lVar3 = *(int64 *)(pStatics_38e8 + 0x4a8);
          if ((((GameController._instance == null) ||
               (lVar6 = GameController._instance.worldData) == null) ||
              (lVar6 = WorldData.Player(lVar6,0)) == null) ||
             (iVar2 = HeroData.GetWeaponResearchWeaponType(lVar6,0), lVar3 == null)) goto LAB_18096eacc;
          if (lVar3.cityAreaID <= iVar2 + 3U) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          uVar7 = String.Format("消耗{0}武器\n研究获取经验",
                                 *(uint64 *)
                                  (lVar3.chapter + 32 + (int64)(int)(iVar2 + 3U) * 8),0
                                );
          LTLocalization.SetText(uVar4,uVar7,0);
          lVar3 = this.researchTargetClearButton;
          if (lVar3 == null) goto LAB_18096eacc;
        }
        else {
          if (((lVar6 == null) || (lVar3 = GameObject.get_transform(lVar6,0)) == null) ||
             ((lVar3 = Transform.Find(lVar3,"ResearchTarget",0), lVar3 == null ||
              (lVar3 = Component.GetComponent(lVar3,DAT_181e76ab8)) == null))) {
        LAB_18096ead8:
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          Selectable.set_interactable(lVar3,0,0);
          if (((this.weaponResearchUI == null) ||
              (lVar3 = GameObject.get_transform(this.weaponResearchUI,0)) == null) ||
             ((lVar3 = Transform.Find(lVar3,"SureButton",0), lVar3 == null ||
              (lVar3 = Transform.Find(lVar3,"Label",0)) == null))) goto LAB_18096ead8;
          uVar4 = Component.GetComponent(lVar3,DAT_181e79538);
          LTLocalization.SetText(uVar4,"研究中",0);
          if ((((this.weaponResearchUI == null) ||
               (lVar3 = GameObject.get_transform(this.weaponResearchUI,0)) == null) ||
              (lVar3 = Transform.Find(lVar3,"SureButton",0)) == null) ||
             (lVar3 = Transform.Find(lVar3,"Label",0)) == null) goto LAB_18096ead8;
          plVar5 = (int64 *)Component.GetComponent(lVar3,DAT_181e79538);
          puVar9 = (uint32 *)Color.get_red(&local_28,0);
          if (plVar5 == (int64 *)0) goto LAB_18096ead8;
          local_28 = *puVar9;
          uStack_24 = puVar9[1];
          uStack_20 = puVar9[2];
          uStack_1c = puVar9[3];
          (**(code **)(*plVar5 + 0x2a8))(plVar5,&local_28,*(uint64 *)(*plVar5 + 0x2b0));
          if (((this.weaponResearchUI == null) ||
              (lVar3 = GameObject.get_transform(this.weaponResearchUI,0)) == null) ||
             ((lVar3 = Transform.Find(lVar3,"SureButton",0), lVar3 == null ||
              (lVar3 = Component.GetComponent(lVar3,DAT_181e76ab8)) == null))) goto LAB_18096ead8;
          Selectable.set_interactable(lVar3,0,0);
          if (((this.weaponResearchUI == null) ||
              (lVar3 = GameObject.get_transform(this.weaponResearchUI,0)) == null) ||
             (lVar3 = Transform.Find(lVar3,"ResearchText",0)) == null) goto LAB_18096ead8;
          uVar4 = Component.GetComponent(lVar3,DAT_181e79538);
          if (((GameController._instance == null) ||
              (lVar3 = GameController._instance.worldData) == null) ||
             (lVar3 = lVar3.weaponResearchData) == null) goto LAB_18096ead8;
          local_res18[0] = lVar3.forceAreaID;
          uVar7 = il2cpp_value_box(DAT_181e60808,local_res18);
          local_res20[0] = WeaponResearchUIController.GetExpNum(this,0);
          uVar8 = il2cpp_value_box(DAT_181e60808,local_res20);
          uVar7 = String.Format("剩余时间 {0}日\n获取经验 {1}",uVar7,uVar8,0);
          LTLocalization.SetText(uVar4,uVar7,0);
          if (((this.weaponResearchUI == null) ||
              (lVar3 = GameObject.get_transform(this.weaponResearchUI,0)) == null) ||
             (lVar3 = Transform.Find(lVar3,"ResearchExtraAdd",0)) == null) goto LAB_18096ead8;
          uVar4 = Component.GetComponent(lVar3,DAT_181e79538);
          if ((((GameController._instance == null) ||
               (lVar3 = GameController._instance.worldData) == null) ||
              (lVar3 = lVar3.weaponResearchData) == null) ||
             (lVar3 = lVar3.villageAreaID) == null) goto LAB_18096ead8;
          uVar7 = HeroSpeAddData.GetDescribe(lVar3,1,1,1,0,0);
          lVar3 = *(int64 *)(pStatics_38e8 + 0x4a8);
          if ((((GameController._instance == null) ||
               (lVar6 = GameController._instance.worldData) == null) ||
              (lVar6 = WorldData.Player(lVar6,0)) == null) ||
             (iVar2 = HeroData.GetWeaponResearchWeaponType(lVar6,0), lVar3 == null)) goto LAB_18096ead8;
          if (lVar3.cityAreaID <= iVar2 + 3U) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          uVar7 = String.Format("{1}特效\n{0}",uVar7,
                                 *(uint64 *)
                                  (lVar3.chapter + 32 + (int64)(int)(iVar2 + 3U) * 8),0
                                );
          LTLocalization.SetText(uVar4,uVar7,0);
          lVar3 = this.researchTargetClearButton;
          if (lVar3 == null) goto LAB_18096ead8;
        }
        uVar4 = 0;
        LAB_18096e28f:
        GameObject.SetActive(lVar3,uVar4,0);
    }

    // Token : 0x6002420
    // RVA   : 0x96D9F0   Offset: 0x96C7F0   Length: 0xAE
    public int GetExpNum()
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        uVar3 = this.researchTargetItemIcon;
        cVar1 = Object.op_Equality(uVar3,0,0);
        if (cVar1) {
          return 0;
        }
        if (this.researchTargetItemIcon != null) {
          lVar2 = GameObject.GetComponent(this.researchTargetItemIcon,DAT_181e55168);
          if ((lVar2 != null) && (*(int64 *)(lVar2 + 32) != 0)) {
            uVar3 = ItemData.GetWeaponResearchExp(*(int64 *)(lVar2 + 32),0);
            return uVar3;
          }
        }
    }

    // Token : 0x6002421
    // RVA   : 0x96DAA0   Offset: 0x96C8A0   Length: 0xB0
    public int GetResearchDay()
    {
        ulong uVar1;
        bool cVar2;
        long lVar3;
        uVar1 = this.researchTargetItemIcon;
        cVar2 = Object.op_Equality(uVar1,0,0);
        if (cVar2) {
          return 0;
        }
        if (this.researchTargetItemIcon != null) {
          lVar3 = GameObject.GetComponent(this.researchTargetItemIcon,DAT_181e55168);
          if ((lVar3 != null) && (*(int64 *)(lVar3 + 32) != 0)) {
            return (*(int *)(*(int64 *)(lVar3 + 32) + 60) + 1) * 5;
          }
        }
    }

    // Token : 0x6002422
    // RVA   : 0x96EAE0   Offset: 0x96D8E0   Length: 0x3E2
    public void ResearchButtonClicked()
    {
        uint uVar1;
        long lVar2;
        long lVar4;
        if ((GameController._instance != null) &&
           (lVar4 = GameController._instance.worldData) != null) {
          lVar4 = lVar4.weaponResearchData;
          if ((this.researchTargetItemIcon != null) &&
             ((lVar2 = GameObject.GetComponent(this.researchTargetItemIcon,DAT_181e55168), lVar2 != null
              && (lVar4 != null)))) {
            lVar4.cityAreaID = *(uint64 *)(lVar2 + 32);
            if ((GameController._instance != null) &&
               (lVar4 = GameController._instance.worldData) != null) {
              lVar4 = lVar4.weaponResearchData;
              uVar1 = WeaponResearchUIController.GetResearchDay(this,0);
              if (lVar4 != null) {
                lVar4.forceAreaID = uVar1;
                if ((GameController._instance != null) &&
                   (lVar4 = GameController._instance.worldData) != null) {
                  lVar4 = lVar4.weaponResearchData;
                  if ((this.researchTargetItemIcon != null) &&
                     ((((lVar2 = GameObject.GetComponent(this.researchTargetItemIcon,DAT_181e55168),
                        lVar2 != null && (*(int64 *)(lVar2 + 32) != 0)) &&
                       (lVar2 = *(int64 *)(*(int64 *)(lVar2 + 32) + 96)) != null) &&
                      ((lVar2 = *(int64 *)(lVar2 + 40), lVar2 != null &&
                       (plVar3 = (int64 *)HeroSpeAddData.Clone(lVar2,0), lVar4 != null)))))) {
                    lVar4.villageAreaID = plVar3;
                    if ((GameController._instance != null) &&
                       (lVar4 = GameController._instance.worldData) != null)
                    {
                      lVar4 = WorldData.Player(lVar4,0);
                      if ((this.researchTargetItemIcon != null) &&
                         ((lVar2 = GameObject.GetComponent(this.researchTargetItemIcon,DAT_181e55168),
                          lVar2 != null && (lVar4 != null)))) {
                        HeroData.LoseItem(lVar4,*(uint64 *)(lVar2 + 32),1,0);
                        plVar3 = (int64 *)Resources.Load("Sound/SoundEffect/SpeEffect/修理升级",0);
                        plVar5 = (int64 *)0;
                        if ((plVar3 != (int64 *)0) && (*plVar3 == DAT_181e8f4a0)) {
                          plVar5 = plVar3;
                        }
                        NGUITools.PlaySound(plVar5,0);
                        WeaponResearchUIController.RefreshUI(this,0);
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

    // Token : 0x6002423
    // RVA   : 0x96EED0   Offset: 0x96DCD0   Length: 0x339
    public void ResearchTargetButtonClicked()
    {
        long lVar1;
        bool cVar2;
        long lVar3;
        ulong uVar4;
        long lVar5;
        uint[] local_res8 = new uint[2];
        uint[] local_res18 = new uint[2];
        uint[] local_res20 = new uint[2];
        uint local_28;
        uint local_24;
        uint local_20;
        uint32 local_1c;
        uVar4 = this.researchTargetItemIcon;
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
          local_res20[0] = 0xffffffff;
          uVar4 = il2cpp_value_box(DAT_181e60808,local_res20);
          FUN_18175de30(lVar3,uVar4,DAT_181e77be0);
          local_28 = 0xffffffff;
          uVar4 = il2cpp_value_box(DAT_181e60808,&local_28);
          FUN_18175de30(lVar3,uVar4,DAT_181e77be0);
          local_24 = 0;
          uVar4 = il2cpp_value_box(DAT_181e60808,&local_24);
          FUN_18175de30(lVar3,uVar4,DAT_181e77be0);
          local_20 = 0xffffffff;
          uVar4 = il2cpp_value_box(DAT_181e60808,&local_20);
          FUN_18175de30(lVar3,uVar4,DAT_181e77be0);
          if (((GameController._instance != null) &&
              (lVar5 = GameController._instance.worldData) != null) &&
             (lVar5 = WorldData.Player(lVar5,0)) != null) {
            local_1c = HeroData.GetWeaponResearchWeaponType(lVar5,0);
            uVar4 = il2cpp_value_box(DAT_181e60808,&local_1c);
            FUN_18175de30(lVar3,uVar4,DAT_181e77be0);
            uVar4 = Component.get_gameObject(this,0);
            if (lVar1 != null) {
              ChooseController.ShowChoosePanel(lVar1,1,lVar3,uVar4,"ResearchTargetChoosen",0,0,0,0,0);
              return;
            }
          }
        }
    }

    // Token : 0x6002424
    // RVA   : 0x96F210   Offset: 0x96E010   Length: 0x94
    public void ResearchTargetChoosen()
    {
        var pStatics = *(int64*)(DAT_181e977e8 + 184);
        long lVar1;
        if ((*pStatics != 0) &&
           (lVar1 = *(int64 *)(*pStatics + 72)) != null) {
          lVar1 = GameObject.GetComponent(lVar1,DAT_181e55168);
          if (lVar1 != null) {
            WeaponResearchUIController.CreateResearchTargetItemIcon
                      (this,*(uint64 *)(lVar1 + 32),0);
            WeaponResearchUIController.RefreshUI(this,0);
            return;
          }
        }
    }

    // Token : 0x6002425
    // RVA   : 0x96D850   Offset: 0x96C650   Length: 0x19B
    public void CreateResearchTargetItemIcon(ItemData targetItemData)
    {
        var pStatics = *(int64*)(DAT_181e52a90 + 184);
        ulong uVar1;
        long lVar2;
        ulong uVar3;
        if (this.weaponResearchUI != null) {
          lVar2 = GameObject.get_transform(this.weaponResearchUI,0);
          if (lVar2 != null) {
            lVar2 = Transform.Find(lVar2,"ResearchTarget",0);
            if (lVar2 != null) {
              uVar3 = Component.get_gameObject(lVar2,0);
              if (*pStatics != 0) {
                uVar1 = *(uint64 *)(*pStatics + 160);
                uVar3 = GlobalData.AddChild(uVar3,uVar1,0);
                this.researchTargetItemIcon = uVar3;
                if (this.researchTargetItemIcon != null) {
                  lVar2 = GameObject.GetComponent(this.researchTargetItemIcon,DAT_181e55168);
                  if (lVar2 != null) {
                    *(uint64 *)(lVar2 + 32) = targetItemData;
                    if (this.researchTargetItemIcon != null) {
                      lVar2 = GameObject.GetComponent(this.researchTargetItemIcon,DAT_181e55168);
                      if (lVar2 != null) {
                        *(uint32 *)(lVar2 + 40) = 1;
                        if (this.researchTargetItemIcon != null) {
                          lVar2 = GameObject.GetComponent(this.researchTargetItemIcon,DAT_181e55168);
                          if (lVar2 != null) {
                            ItemIconController.AutoSetName(lVar2,1,0);
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

    // Token : 0x6002426
    // RVA   : 0x96D790   Offset: 0x96C590   Length: 0xBA
    public void ClearResearchTarget()
    {
        ulong uVar1;
        bool cVar2;
        uVar1 = this.researchTargetItemIcon;
        cVar2 = Object.op_Inequality(uVar1,0,0);
        if (cVar2) {
          uVar1 = this.researchTargetItemIcon;
          Object.Destroy(uVar1,0);
          this.researchTargetItemIcon = 0;
          WeaponResearchUIController.RefreshUI(this,0);
        }
    }

    // Token : 0x6002427
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

}
