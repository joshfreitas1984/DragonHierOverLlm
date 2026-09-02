// ============================================================
// Type  : WeaponResearchUIController
// Token : 0x20003A9
// ============================================================

public class WeaponResearchUIController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001CD4
    public GameObject weaponResearchUI;

    // Token: 0x4001CD5
    public GameObject researchTargetItemIcon;

    // Token: 0x4001CD6
    public GameObject researchTargetClearButton;

    // Token: 0x4001CD7
    private static WeaponResearchUIController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60022EF
    // RVA   : 0x9E26D0   Offset: 0x9E0ED0   Length: 0x36
    public static WeaponResearchUIController get_Instance()
    {
        return **(uint64 **)(DAT_181d8fbd8 + 184);
    }

    // Token : 0x60022F0
    // RVA   : 0x9DFE80   Offset: 0x9DE680   Length: 0x43
    private void Awake()
    {
        puVar1 = *(uint64 **)(DAT_181d8fbd8 + 184);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x60022F1
    // RVA   : 0x9E02A0   Offset: 0x9DEAA0   Length: 0xC7
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

    // Token : 0x60022F2
    // RVA   : 0x9E1A70   Offset: 0x9E0270   Length: 0xC55
    public void ShowWeaponResearchUI()
    {
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        var pStatics_ef00 = *(int64*)(DAT_181d4ef00 + 184);
        float fVar1;
        long lVar2;
        int iVar3;
        long lVar4;
        ulong uVar5;
        ulong uVar6;
        ulong uVar7;
        uint[] local_res8 = new uint[2];
        float[] local_res18 = new float[4];
        if (this.weaponResearchUI != null) {
          GameObject.SetActive(this.weaponResearchUI,1,0);
          if (this.weaponResearchUI != null) {
            lVar4 = GameObject.get_transform(this.weaponResearchUI,0);
            if (lVar4 != null) {
              lVar4 = Transform.Find(lVar4,"Title",0);
              if (lVar4 != null) {
                uVar5 = Component.GetComponent(lVar4,DAT_181d6d8c0);
                lVar4 = *(int64 *)(pStatics_ef00 + 0x498);
                if ((*pStatics_df90 != 0) &&
                   (lVar2 = *(int64 *)(*pStatics_df90 + 32)) != null) {
                  lVar2 = *(int64 *)(lVar2 + 80);
                  if (lVar2 != null) {
                    if (*(int *)(lVar2 + 24) == 0) {
                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                    }
                    lVar2 = *(int64 *)(*(int64 *)(lVar2 + 16) + 32);
                    if (lVar2 != null) {
                      iVar3 = HeroData.GetWeaponResearchWeaponType(lVar2,0);
                      if (lVar4 != null) {
                        if (*(uint32 *)(lVar4 + 24) <= iVar3 + 3U) {
                          ThrowHelper.ThrowArgumentOutOfRangeException(0);
                        }
                        uVar6 = String.Concat(*(uint64 *)
                                                (*(int64 *)(lVar4 + 16) + 32 +
                                                (int64)(int)(iVar3 + 3U) * 8),"研究",0);
                        LTLocalization.SetText(uVar5,uVar6,0);
                        if (this.weaponResearchUI != null) {
                          lVar4 = GameObject.get_transform(this.weaponResearchUI,0);
                          if (lVar4 != null) {
                            lVar4 = Transform.Find(lVar4,"ResearchTarget",0);
                            if (lVar4 != null) {
                              lVar4 = Transform.Find(lVar4,"Label",0);
                              if (lVar4 != null) {
                                uVar5 = Component.GetComponent(lVar4,DAT_181d6d8c0);
                                lVar4 = *(int64 *)(pStatics_ef00 + 0x498);
                                if ((*pStatics_df90 != 0) &&
                                   (lVar2 = *(int64 *)(*pStatics_df90 + 32),
                                   lVar2 != null)) {
                                  lVar2 = *(int64 *)(lVar2 + 80);
                                  if (lVar2 != null) {
                                    if (*(int *)(lVar2 + 24) == 0) {
                                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                    }
                                    lVar2 = *(int64 *)(*(int64 *)(lVar2 + 16) + 32);
                                    if (lVar2 != null) {
                                      iVar3 = HeroData.GetWeaponResearchWeaponType(lVar2,0);
                                      if (lVar4 != null) {
                                        if (*(uint32 *)(lVar4 + 24) <= iVar3 + 3U) {
                                          ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                        }
                                        uVar6 = String.Concat(*(uint64 *)
                                                                (*(int64 *)(lVar4 + 16) + 32 +
                                                                (int64)(int)(iVar3 + 3U) * 8),
                                                               "兵器\n（消耗）",0);
                                        LTLocalization.SetText(uVar5,uVar6,0);
                                        if (this.weaponResearchUI != null) {
                                          lVar4 = GameObject.get_transform
                                                            (this.weaponResearchUI,0);
                                          if (lVar4 != null) {
                                            lVar4 = Transform.Find(lVar4,"ResearchLv",0);
                                            if (lVar4 != null) {
                                              uVar5 = Component.GetComponent(lVar4,DAT_181d6d8c0);
                                              if (((*pStatics_df90 != 0) &&
                                                  (lVar4 = *(int64 *)
                                                            (*pStatics_df90 + 32)
                                                  , lVar4 != null)) &&
                                                 (lVar4 = *(int64 *)(lVar4 + 0x1e8)) != null) {
                                                uVar6 = Int32.ToString(lVar4 + 16,0);
                                                uVar6 = String.Concat("等级",uVar6,0);
                                                LTLocalization.SetText(uVar5,uVar6,0);
                                                if (this.weaponResearchUI != null) {
                                                  lVar4 = GameObject.get_transform
                                                                    (this.weaponResearchUI,0);
                                                  if (lVar4 != null) {
                                                    lVar4 = Transform.Find(lVar4,"ResearchLvAdd",0);
                                                    if (lVar4 != null) {
                                                      uVar5 = Component.GetComponent(lVar4,DAT_181d6d8c0)
                                                      ;
                                                      lVar4 = *(int64 *)
                                                               (pStatics_ef00 +
                                                               0x498);
                                                      if ((*pStatics_df90 != 0) &&
                                                         (lVar2 = *(int64 *)
                                                                   (*pStatics_df90
                                                                   + 32), lVar2 != null)) {
                                                        lVar2 = *(int64 *)(lVar2 + 80);
                                                        if (lVar2 != null) {
                                                          if (*(int *)(lVar2 + 24) == 0) {
                                                            ThrowHelper.ThrowArgumentOutOfRangeException
                                                                      (0);
                                                          }
                                                          lVar2 = *(int64 *)
                                                                   (*(int64 *)(lVar2 + 16) + 32);
                                                          if (lVar2 != null) {
                                                            iVar3 = HeroData.GetWeaponResearchWeaponType
                                                                              (lVar2,0);
                                                            if (lVar4 != null) {
                                                              if (*(uint32 *)(lVar4 + 24) <= iVar3 + 3U) {

                                                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                                        }
                                                        uVar6 = *(uint64 *)
                                                                 (*(int64 *)(lVar4 + 16) + 32 +
                                                                 (int64)(int)(iVar3 + 3U) * 8);
                                                        if (((*pStatics_df90 != 0)
                                                            && (lVar4 = *(int64 *)
                                                                         (**(int64 **)
                                                                            (DAT_181d4df90 + 184) + 32)
                                                               , lVar4 != null)) &&
                                                           (lVar4 = *(int64 *)(lVar4 + 0x1e8),
                                                           lVar4 != null)) {
                                                          local_res8[0] = *(uint32 *)(lVar4 + 16);
                                                          uVar7 = il2cpp_value_box(DAT_181d5b2f8,
                                                                                   local_res8);
                                                          uVar6 = String.Format("等级加成\n{0}威力+{1}%",uVar6,uVar7
                                                                                 ,0);
                                                          LTLocalization.SetText(uVar5,uVar6,0);
                                                          if (this.weaponResearchUI != null) {
                                                            lVar4 = GameObject.get_transform
                                                                              (*(int64 *)
                                                                                (this + 24),0);
                                                            if (lVar4 != null) {
                                                              lVar4 = Transform.Find(lVar4,"ExpBarBack",
                                                                                      0);
                                                              if (lVar4 != null) {
                                                                lVar4 = Transform.Find(lVar4,
                                                        "ExpText",0);
                                                        if (lVar4 != null) {
                                                          uVar5 = Component.GetComponent
                                                                            (lVar4,DAT_181d6d8c0);
                                                          if (((*pStatics_df90 != 0
                                                               ) && (lVar4 = *(int64 *)
                                                                              (**(int64 **)
                                                                                 (DAT_181d4df90 + 184) +
                                                                              32), lVar4 != null)) &&
                                                             (lVar4 = *(int64 *)(lVar4 + 0x1e8),
                                                             lVar4 != null)) {
                                                            uVar6 = Single.ToString(lVar4 + 20,
                                                                                     "f0",0);
                                                            if (((*pStatics_df90 !=
                                                                  0) && (lVar4 = *(int64 *)
                                                                                  (**(int64 **)
                                                                                     (DAT_181d4df90 + 184
                                                                                     ) + 32), lVar4 != null
                                                                        )) &&
                                                               (lVar4 = *(int64 *)(lVar4 + 0x1e8),
                                                               lVar4 != null)) {
                                                              iVar3 = *(int *)(lVar4 + 16);
                                                              local_res18[0] =
                                                                   (float)((iVar3 + 2) * (iVar3 + 1)) *
                                                                   0.5;
                                                              uVar7 = il2cpp_value_box(DAT_181d7d0b8,
                                                                                       local_res18);
                                                              uVar6 = String.Format("{0}/{1}",uVar6,
                                                                                     uVar7,0);
                                                              LTLocalization.SetText(uVar5,uVar6,0);
                                                              if (this.weaponResearchUI != null) {
                                                                lVar4 = GameObject.get_transform
                                                                                  (*(int64 *)
                                                                                    (this + 24),0);
                                                                if (lVar4 != null) {
                                                                  lVar4 = Transform.Find(lVar4,
                                                        "ExpBarBack",0);
                                                        if (lVar4 != null) {
                                                          lVar4 = Transform.Find(lVar4,"ExpBar",0);
                                                          if (lVar4 != null) {
                                                            lVar4 = Component.GetComponent
                                                                              (lVar4,DAT_181d6bc40);
                                                            if (((*pStatics_df90 !=
                                                                  0) && (lVar2 = *(int64 *)
                                                                                  (**(int64 **)
                                                                                     (DAT_181d4df90 + 184
                                                                                     ) + 32), lVar2 != null
                                                                        )) &&
                                                               (lVar2 = *(int64 *)(lVar2 + 0x1e8),
                                                               lVar2 != null)) {
                                                              fVar1 = *(float *)(lVar2 + 20);
                                                              if (((*(byte *)(DAT_181d4df90 + 0x133) & 4)
                                                                   != 0) &&
                                                                 (*(int *)(DAT_181d4df90 + 224) == 0)) {
                                                                il2cpp_runtime_class_init();
                                                              }
                                                              if ((((*pStatics_df90
                                                                     != 0) &&
                                                                   (lVar2 = *(int64 *)
                                                                             (**(int64 **)
                                                                                (DAT_181d4df90 + 184) +
                                                                             32), lVar2 != null)) &&
                                                                  (lVar2 = *(int64 *)(lVar2 + 0x1e8),
                                                                  lVar2 != null)) && (lVar4 != null)) {
                                                                iVar3 = *(int *)(lVar2 + 16);
                                                                Image.set_fillAmount
                                                                          (lVar4,fVar1 / ((float)((iVar3 +
                                                                                                  2) * (
                                                        iVar3 + 1)) * 0.5),0);
                                                        if (((*pStatics_df90 != 0)
                                                            && (lVar4 = *(int64 *)
                                                                         (**(int64 **)
                                                                            (DAT_181d4df90 + 184) + 32)
                                                               , lVar4 != null)) &&
                                                           (lVar4 = *(int64 *)(lVar4 + 0x1e8),
                                                           lVar4 != null)) {
                                                          if (0 < *(int *)(lVar4 + 40)) {
                                                            if (((*pStatics_df90 ==
                                                                  0) || (lVar4 = *(int64 *)
                                                                                  (**(int64 **)
                                                                                     (DAT_181d4df90 + 184
                                                                                     ) + 32), lVar4 == null
                                                                        )) ||
                                                               (lVar4 = *(int64 *)(lVar4 + 0x1e8),
                                                               lVar4 == null)) {
        LAB_1809e26c0:
                          // WARNING: Subroutine does not return
                                                              FUN_1800d6620();
                                                            }
                                                            if (*(int64 *)(lVar4 + 24) != 0) {
                                                              if (((*(byte *)(DAT_181d4df90 + 0x133) & 4)
                                                                   != 0) &&
                                                                 (*(int *)(DAT_181d4df90 + 224) == 0)) {
                                                                il2cpp_runtime_class_init();
                                                              }
                                                              lVar4 = FUN_18046c0a0(0);
                                                              if (((lVar4 == null) ||
                                                                  (*(int64 *)(lVar4 + 32) == 0)) ||
                                                                 (lVar4 = *(int64 *)
                                                                           (*(int64 *)(lVar4 + 32) +
                                                                           0x1e8), lVar4 == null))
                                                              goto LAB_1809e26c0;

                                                        WeaponResearchUIController.CreateResearchTargetItemIcon
                                                                  (this,*(uint64 *)(lVar4 + 24),0
                                                                  );
                                                        }
                                                        }
                                                        WeaponResearchUIController.RefreshUI(this,0);
                                                        plVar8 = (int64 *)
                                                                 Resources.Load("Sound/SoundEffect/OpenBook",0);
                                                        plVar9 = (int64 *)0;
                                                        if ((plVar8 != (int64 *)0) &&
                                                           (*plVar8 == DAT_181d8a228)) {
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
          }
        }
    }

    // Token : 0x60022F3
    // RVA   : 0x9E0370   Offset: 0x9DEB70   Length: 0xEBD
    public void RefreshUI()
    {
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        var pStatics_ef00 = *(int64*)(DAT_181d4ef00 + 184);
        long lVar1;
        bool cVar2;
        int iVar3;
        long lVar4;
        ulong uVar5;
        ulong uVar7;
        ulong uVar8;
        uint[] local_res18 = new uint[2];
        uint[] local_res20 = new uint[2];
        uint local_28;
        uint uStack_24;
        uint uStack_20;
        uint32 uStack_1c;
        if (((*pStatics_df90 == 0) ||
            (lVar4 = *(int64 *)(*pStatics_df90 + 32)) == null) ||
           (lVar4 = *(int64 *)(lVar4 + 0x1e8)) == null) goto LAB_1809e121c;
        lVar1 = this.weaponResearchUI;
        if (*(int *)(lVar4 + 40) < 1) {
          if ((((lVar1 == null) || (lVar4 = GameObject.get_transform(lVar1,0)) == null) ||
              (lVar4 = Transform.Find(lVar4,"SureButton",0)) == null) ||
             (lVar4 = Transform.Find(lVar4,"Label",0)) == null) {
        LAB_1809e121c:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          uVar5 = Component.GetComponent(lVar4,DAT_181d6d8c0);
          LTLocalization.SetText(uVar5,"确认",0);
          if (((this.weaponResearchUI == null) ||
              (lVar4 = GameObject.get_transform(this.weaponResearchUI,0)) == null) ||
             ((lVar4 = Transform.Find(lVar4,"SureButton",0), lVar4 == null ||
              (lVar4 = Transform.Find(lVar4,"Label",0)) == null))) goto LAB_1809e121c;
          plVar6 = (int64 *)Component.GetComponent(lVar4,DAT_181d6d8c0);
          lVar4 = pStatics_ef00;
          if (plVar6 == (int64 *)0) goto LAB_1809e121c;
          local_28 = *(uint32 *)(lVar4 + 0x370);
          uStack_24 = *(uint32 *)(lVar4 + 0x374);
          uStack_20 = *(uint32 *)(lVar4 + 0x378);
          uStack_1c = *(uint32 *)(lVar4 + 0x37c);
          (**(code **)(*plVar6 + 0x2a8))(plVar6,&local_28,*(uint64 *)(*plVar6 + 0x2b0));
          if ((((this.weaponResearchUI == null) ||
               (lVar4 = GameObject.get_transform(this.weaponResearchUI,0)) == null) ||
              (lVar4 = Transform.Find(lVar4,"ResearchTarget",0)) == null) ||
             (lVar4 = Component.GetComponent(lVar4,DAT_181d6af40)) == null) goto LAB_1809e121c;
          Selectable.set_interactable(lVar4,1,0);
          if (((this.weaponResearchUI == null) ||
              (lVar4 = GameObject.get_transform(this.weaponResearchUI,0)) == null) ||
             (lVar4 = Transform.Find(lVar4,"SureButton",0)) == null) goto LAB_1809e121c;
          lVar4 = Component.get_gameObject(lVar4,0);
          if (lVar4 == null) goto LAB_1809e121c;
          GameObject.SetActive(lVar4,1,0);
          uVar5 = this.researchTargetItemIcon;
          cVar2 = Object.op_Inequality(uVar5,0,0);
          lVar4 = this.weaponResearchUI;
          if (cVar2) {
            if ((((lVar4 == null) || (lVar4 = GameObject.get_transform(lVar4,0)) == null) ||
                (lVar4 = Transform.Find(lVar4,"SureButton",0)) == null) ||
               (lVar4 = Component.GetComponent(lVar4,DAT_181d6af40)) == null) {
        LAB_1809e1222:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            Selectable.set_interactable(lVar4,1,0);
            if (((this.weaponResearchUI == null) ||
                (lVar4 = GameObject.get_transform(this.weaponResearchUI,0)) == null) ||
               (lVar4 = Transform.Find(lVar4,"ResearchText",0)) == null) goto LAB_1809e1222;
            uVar5 = Component.GetComponent(lVar4,DAT_181d6d8c0);
            local_res18[0] = WeaponResearchUIController.GetResearchDay(this,0);
            uVar7 = il2cpp_value_box(DAT_181d5b2f8,local_res18);
            local_res20[0] = WeaponResearchUIController.GetExpNum(this,0);
            uVar8 = il2cpp_value_box(DAT_181d5b2f8,local_res20);
            uVar7 = String.Format("研究时间 {0}日\n获取经验 {1}",uVar7,uVar8,0);
            LTLocalization.SetText(uVar5,uVar7,0);
            if (((this.weaponResearchUI == null) ||
                (lVar4 = GameObject.get_transform(this.weaponResearchUI,0)) == null) ||
               (lVar4 = Transform.Find(lVar4,"ResearchExtraAdd",0)) == null) goto LAB_1809e1222;
            uVar5 = Component.GetComponent(lVar4,DAT_181d6d8c0);
            if ((((this.researchTargetItemIcon == null) ||
                 (lVar4 = GameObject.GetComponent(this.researchTargetItemIcon,DAT_181da0070),
                 lVar4 == null)) || (*(int64 *)(lVar4 + 32) == 0)) ||
               ((lVar4 = *(int64 *)(*(int64 *)(lVar4 + 32) + 96), lVar4 == null ||
                (lVar4 = *(int64 *)(lVar4 + 40)) == null))) goto LAB_1809e1222;
            uVar7 = HeroSpeAddData.GetDescribe(lVar4,1,1,1,0,0);
            lVar4 = *(int64 *)(pStatics_ef00 + 0x498);
            if ((*pStatics_df90 == 0) ||
               (lVar1 = *(int64 *)(*pStatics_df90 + 32)) == null)
            goto LAB_1809e1222;
            lVar1 = *(int64 *)(lVar1 + 80);
            if (lVar1 == null) goto LAB_1809e1222;
            if (*(int *)(lVar1 + 24) == 0) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar1 = *(int64 *)(*(int64 *)(lVar1 + 16) + 32);
            if ((lVar1 == null) || (iVar3 = HeroData.GetWeaponResearchWeaponType(lVar1,0), lVar4 == null))
            goto LAB_1809e1222;
            if (*(uint32 *)(lVar4 + 24) <= iVar3 + 3U) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            uVar7 = String.Format("{1}特效\n{0}",uVar7,
                                   *(uint64 *)
                                    (*(int64 *)(lVar4 + 16) + 32 + (int64)(int)(iVar3 + 3U) * 8)
                                   ,0);
            LTLocalization.SetText(uVar5,uVar7,0);
            lVar4 = this.researchTargetClearButton;
            if (lVar4 == null) goto LAB_1809e1222;
            uVar5 = 1;
            goto LAB_1809e09b5;
          }
          if ((((lVar4 == null) || (lVar4 = GameObject.get_transform(lVar4,0)) == null) ||
              (lVar4 = Transform.Find(lVar4,"SureButton",0)) == null) ||
             (lVar4 = Component.GetComponent(lVar4,DAT_181d6af40)) == null) goto LAB_1809e121c;
          Selectable.set_interactable(lVar4,0,0);
          if (((this.weaponResearchUI == null) ||
              (lVar4 = GameObject.get_transform(this.weaponResearchUI,0)) == null) ||
             (lVar4 = Transform.Find(lVar4,"ResearchExtraAdd",0)) == null) goto LAB_1809e121c;
          uVar5 = Component.GetComponent(lVar4,DAT_181d6d8c0);
          LTLocalization.SetText(uVar5,"",0);
          if (((this.weaponResearchUI == null) ||
              (lVar4 = GameObject.get_transform(this.weaponResearchUI,0)) == null) ||
             (lVar4 = Transform.Find(lVar4,"ResearchText",0)) == null) goto LAB_1809e121c;
          uVar5 = Component.GetComponent(lVar4,DAT_181d6d8c0);
          lVar4 = *(int64 *)(pStatics_ef00 + 0x498);
          if ((*pStatics_df90 == 0) ||
             (lVar1 = *(int64 *)(*pStatics_df90 + 32)) == null)
          goto LAB_1809e121c;
          lVar1 = *(int64 *)(lVar1 + 80);
          if (lVar1 == null) goto LAB_1809e121c;
          if (*(int *)(lVar1 + 24) == 0) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar1 = *(int64 *)(*(int64 *)(lVar1 + 16) + 32);
          if ((lVar1 == null) || (iVar3 = HeroData.GetWeaponResearchWeaponType(lVar1,0), lVar4 == null))
          goto LAB_1809e121c;
          if (*(uint32 *)(lVar4 + 24) <= iVar3 + 3U) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          uVar7 = String.Format("消耗{0}武器\n研究获取经验",
                                 *(uint64 *)
                                  (*(int64 *)(lVar4 + 16) + 32 + (int64)(int)(iVar3 + 3U) * 8),0
                                );
          LTLocalization.SetText(uVar5,uVar7,0);
          lVar4 = this.researchTargetClearButton;
          if (lVar4 == null) goto LAB_1809e121c;
        }
        else {
          if (((lVar1 == null) || (lVar4 = GameObject.get_transform(lVar1,0)) == null) ||
             ((lVar4 = Transform.Find(lVar4,"ResearchTarget",0), lVar4 == null ||
              (lVar4 = Component.GetComponent(lVar4,DAT_181d6af40)) == null))) {
        LAB_1809e1228:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          Selectable.set_interactable(lVar4,0,0);
          if (((this.weaponResearchUI == null) ||
              (lVar4 = GameObject.get_transform(this.weaponResearchUI,0)) == null) ||
             ((lVar4 = Transform.Find(lVar4,"SureButton",0), lVar4 == null ||
              (lVar4 = Transform.Find(lVar4,"Label",0)) == null))) goto LAB_1809e1228;
          uVar5 = Component.GetComponent(lVar4,DAT_181d6d8c0);
          LTLocalization.SetText(uVar5,"研究中",0);
          if ((((this.weaponResearchUI == null) ||
               (lVar4 = GameObject.get_transform(this.weaponResearchUI,0)) == null) ||
              (lVar4 = Transform.Find(lVar4,"SureButton",0)) == null) ||
             (lVar4 = Transform.Find(lVar4,"Label",0)) == null) goto LAB_1809e1228;
          plVar6 = (int64 *)Component.GetComponent(lVar4,DAT_181d6d8c0);
          puVar9 = (uint32 *)Color.get_red(&local_28,0);
          if (plVar6 == (int64 *)0) goto LAB_1809e1228;
          local_28 = *puVar9;
          uStack_24 = puVar9[1];
          uStack_20 = puVar9[2];
          uStack_1c = puVar9[3];
          (**(code **)(*plVar6 + 0x2a8))(plVar6,&local_28,*(uint64 *)(*plVar6 + 0x2b0));
          if (((this.weaponResearchUI == null) ||
              (lVar4 = GameObject.get_transform(this.weaponResearchUI,0)) == null) ||
             ((lVar4 = Transform.Find(lVar4,"SureButton",0), lVar4 == null ||
              (lVar4 = Component.GetComponent(lVar4,DAT_181d6af40)) == null))) goto LAB_1809e1228;
          Selectable.set_interactable(lVar4,0,0);
          if (((this.weaponResearchUI == null) ||
              (lVar4 = GameObject.get_transform(this.weaponResearchUI,0)) == null) ||
             (lVar4 = Transform.Find(lVar4,"ResearchText",0)) == null) goto LAB_1809e1228;
          uVar5 = Component.GetComponent(lVar4,DAT_181d6d8c0);
          if (((*pStatics_df90 == 0) ||
              (lVar4 = *(int64 *)(*pStatics_df90 + 32)) == null) ||
             (lVar4 = *(int64 *)(lVar4 + 0x1e8)) == null) goto LAB_1809e1228;
          local_res18[0] = *(uint32 *)(lVar4 + 40);
          uVar7 = il2cpp_value_box(DAT_181d5b2f8,local_res18);
          local_res20[0] = WeaponResearchUIController.GetExpNum(this,0);
          uVar8 = il2cpp_value_box(DAT_181d5b2f8,local_res20);
          uVar7 = String.Format("剩余时间 {0}日\n获取经验 {1}",uVar7,uVar8,0);
          LTLocalization.SetText(uVar5,uVar7,0);
          if (((this.weaponResearchUI == null) ||
              (lVar4 = GameObject.get_transform(this.weaponResearchUI,0)) == null) ||
             (lVar4 = Transform.Find(lVar4,"ResearchExtraAdd",0)) == null) goto LAB_1809e1228;
          uVar5 = Component.GetComponent(lVar4,DAT_181d6d8c0);
          if ((((*pStatics_df90 == 0) ||
               (lVar4 = *(int64 *)(*pStatics_df90 + 32)) == null) ||
              (lVar4 = *(int64 *)(lVar4 + 0x1e8)) == null) ||
             (lVar4 = *(int64 *)(lVar4 + 32)) == null) goto LAB_1809e1228;
          uVar7 = HeroSpeAddData.GetDescribe(lVar4,1,1,1,0,0);
          lVar4 = *(int64 *)(pStatics_ef00 + 0x498);
          if ((*pStatics_df90 == 0) ||
             (lVar1 = *(int64 *)(*pStatics_df90 + 32)) == null)
          goto LAB_1809e1228;
          lVar1 = *(int64 *)(lVar1 + 80);
          if (lVar1 == null) goto LAB_1809e1228;
          if (*(int *)(lVar1 + 24) == 0) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar1 = *(int64 *)(*(int64 *)(lVar1 + 16) + 32);
          if ((lVar1 == null) || (iVar3 = HeroData.GetWeaponResearchWeaponType(lVar1,0), lVar4 == null))
          goto LAB_1809e1228;
          if (*(uint32 *)(lVar4 + 24) <= iVar3 + 3U) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          uVar7 = String.Format("{1}特效\n{0}",uVar7,
                                 *(uint64 *)
                                  (*(int64 *)(lVar4 + 16) + 32 + (int64)(int)(iVar3 + 3U) * 8),0
                                );
          LTLocalization.SetText(uVar5,uVar7,0);
          lVar4 = this.researchTargetClearButton;
          if (lVar4 == null) goto LAB_1809e1228;
        }
        uVar5 = 0;
        LAB_1809e09b5:
        GameObject.SetActive(lVar4,uVar5,0);
    }

    // Token : 0x60022F4
    // RVA   : 0x9E0130   Offset: 0x9DE930   Length: 0xAE
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
          lVar2 = GameObject.GetComponent(this.researchTargetItemIcon,DAT_181da0070);
          if ((lVar2 != null) && (*(int64 *)(lVar2 + 32) != 0)) {
            uVar3 = ItemData.GetWeaponResearchExp(*(int64 *)(lVar2 + 32),0);
            return uVar3;
          }
        }
    }

    // Token : 0x60022F5
    // RVA   : 0x9E01E0   Offset: 0x9DE9E0   Length: 0xB0
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
          lVar3 = GameObject.GetComponent(this.researchTargetItemIcon,DAT_181da0070);
          if ((lVar3 != null) && (*(int64 *)(lVar3 + 32) != 0)) {
            return (*(int *)(*(int64 *)(lVar3 + 32) + 60) + 1) * 5;
          }
        }
    }

    // Token : 0x60022F6
    // RVA   : 0x9E1230   Offset: 0x9DFA30   Length: 0x416
    public void ResearchButtonClicked()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        long lVar1;
        uint uVar2;
        long lVar3;
        if ((*pStatics != 0) &&
           (lVar1 = *(int64 *)(*pStatics + 32)) != null) {
          lVar1 = *(int64 *)(lVar1 + 0x1e8);
          if ((this.researchTargetItemIcon != null) &&
             ((lVar3 = GameObject.GetComponent(this.researchTargetItemIcon,DAT_181da0070), lVar3 != null
              && (lVar1 != null)))) {
            *(uint64 *)(lVar1 + 24) = *(uint64 *)(lVar3 + 32);
            if ((*pStatics != 0) &&
               (lVar1 = *(int64 *)(*pStatics + 32)) != null) {
              lVar1 = *(int64 *)(lVar1 + 0x1e8);
              uVar2 = WeaponResearchUIController.GetResearchDay(this,0);
              if (lVar1 != null) {
                *(uint32 *)(lVar1 + 40) = uVar2;
                if ((*pStatics != 0) &&
                   (lVar1 = *(int64 *)(*pStatics + 32)) != null) {
                  lVar1 = *(int64 *)(lVar1 + 0x1e8);
                  if ((this.researchTargetItemIcon != null) &&
                     ((((lVar3 = GameObject.GetComponent(this.researchTargetItemIcon,DAT_181da0070),
                        lVar3 != null && (*(int64 *)(lVar3 + 32) != 0)) &&
                       (lVar3 = *(int64 *)(*(int64 *)(lVar3 + 32) + 96)) != null) &&
                      ((lVar3 = *(int64 *)(lVar3 + 40), lVar3 != null &&
                       (plVar4 = (int64 *)HeroSpeAddData.Clone(lVar3,0), lVar1 != null)))))) {
                    *(int64 **)(lVar1 + 32) = plVar4;
                    if ((*pStatics != 0) &&
                       (lVar1 = *(int64 *)(*pStatics + 32)) != null)
                    {
                      lVar1 = *(int64 *)(lVar1 + 80);
                      if (lVar1 != null) {
                        if (*(int *)(lVar1 + 24) == 0) {
                          ThrowHelper.ThrowArgumentOutOfRangeException(0);
                        }
                        lVar1 = *(int64 *)(*(int64 *)(lVar1 + 16) + 32);
                        if (((this.researchTargetItemIcon != null) &&
                            (lVar3 = GameObject.GetComponent(this.researchTargetItemIcon,DAT_181da0070)
                            , lVar3 != null)) && (lVar1 != null)) {
                          HeroData.LoseItem(lVar1,*(uint64 *)(lVar3 + 32),1,0);
                          plVar4 = (int64 *)Resources.Load("Sound/SoundEffect/SpeEffect/修理升级",0);
                          plVar5 = (int64 *)0;
                          if ((plVar4 != (int64 *)0) && (*plVar4 == DAT_181d8a228)) {
                            plVar5 = plVar4;
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
    }

    // Token : 0x60022F7
    // RVA   : 0x9E1650   Offset: 0x9DFE50   Length: 0x378
    public void ResearchTargetButtonClicked()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        long lVar1;
        long lVar2;
        bool cVar3;
        long lVar4;
        ulong uVar5;
        uint[] local_res8 = new uint[4];
        uint[] local_res18 = new uint[2];
        uint[] local_res20 = new uint[2];
        uint local_38;
        uint local_34;
        uint local_30;
        uint32 local_2c;
        uVar5 = this.researchTargetItemIcon;
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
          local_res18[0] = 0;
          uVar5 = il2cpp_value_box(DAT_181d5b2f8,local_res18);
          FUN_181827900(lVar4,uVar5,DAT_181d6e0e8);
          local_res20[0] = 0xffffffff;
          uVar5 = il2cpp_value_box(DAT_181d5b2f8,local_res20);
          FUN_181827900(lVar4,uVar5,DAT_181d6e0e8);
          local_38 = 0xffffffff;
          uVar5 = il2cpp_value_box(DAT_181d5b2f8,&local_38);
          FUN_181827900(lVar4,uVar5,DAT_181d6e0e8);
          local_34 = 0;
          uVar5 = il2cpp_value_box(DAT_181d5b2f8,&local_34);
          FUN_181827900(lVar4,uVar5,DAT_181d6e0e8);
          local_30 = 0xffffffff;
          uVar5 = il2cpp_value_box(DAT_181d5b2f8,&local_30);
          FUN_181827900(lVar4,uVar5,DAT_181d6e0e8);
          if ((*pStatics != 0) &&
             (lVar2 = *(int64 *)(*pStatics + 32)) != null) {
            lVar2 = *(int64 *)(lVar2 + 80);
            if (lVar2 != null) {
              if (*(int *)(lVar2 + 24) == 0) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar2 = *(int64 *)(*(int64 *)(lVar2 + 16) + 32);
              if (lVar2 != null) {
                local_2c = HeroData.GetWeaponResearchWeaponType(lVar2,0);
                uVar5 = il2cpp_value_box(DAT_181d5b2f8,&local_2c);
                FUN_181827900(lVar4,uVar5,DAT_181d6e0e8);
                uVar5 = Component.get_gameObject(this,0);
                if (lVar1 != null) {
                  ChooseController.ShowChoosePanel(lVar1,1,lVar4,uVar5,"ResearchTargetChoosen",0,0,0,0,0);
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x60022F8
    // RVA   : 0x9E19D0   Offset: 0x9E01D0   Length: 0x94
    public void ResearchTargetChoosen()
    {
        var pStatics = *(int64*)(DAT_181d92370 + 184);
        long lVar1;
        if ((*pStatics != 0) &&
           (lVar1 = *(int64 *)(*pStatics + 72)) != null) {
          lVar1 = GameObject.GetComponent(lVar1,DAT_181da0070);
          if (lVar1 != null) {
            WeaponResearchUIController.CreateResearchTargetItemIcon
                      (this,*(uint64 *)(lVar1 + 32),0);
            WeaponResearchUIController.RefreshUI(this,0);
            return;
          }
        }
    }

    // Token : 0x60022F9
    // RVA   : 0x9DFF90   Offset: 0x9DE790   Length: 0x19B
    public void CreateResearchTargetItemIcon(ItemData targetItemData)
    {
        var pStatics = *(int64*)(DAT_181d4e188 + 184);
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
                  lVar2 = GameObject.GetComponent(this.researchTargetItemIcon,DAT_181da0070);
                  if (lVar2 != null) {
                    *(uint64 *)(lVar2 + 32) = targetItemData;
                    if (this.researchTargetItemIcon != null) {
                      lVar2 = GameObject.GetComponent(this.researchTargetItemIcon,DAT_181da0070);
                      if (lVar2 != null) {
                        *(uint32 *)(lVar2 + 40) = 1;
                        if (this.researchTargetItemIcon != null) {
                          lVar2 = GameObject.GetComponent(this.researchTargetItemIcon,DAT_181da0070);
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

    // Token : 0x60022FA
    // RVA   : 0x9DFED0   Offset: 0x9DE6D0   Length: 0xBA
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

    // Token : 0x60022FB
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
