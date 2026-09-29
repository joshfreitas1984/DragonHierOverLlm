// ============================================================
// Type  : WeaponResearchUIController
// Token : 0x20003B0
// ============================================================

public class WeaponResearchUIController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001DDA
    public GameObject weaponResearchUI;

    // Token: 0x4001DDB
    public GameObject researchTargetItemIcon;

    // Token: 0x4001DDC
    public GameObject researchTargetClearButton;

    // Token: 0x4001DDD
    private static WeaponResearchUIController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002371
    // RVA   : 0xC16BF0   Offset: 0xC15FF0   Length: 0x36
    public static WeaponResearchUIController get_Instance()
    {
        return **(uint64 **)(DAT_181db4ea8 + 184);
    }

    // Token : 0x6002372
    // RVA   : 0xC14490   Offset: 0xC13890   Length: 0x43
    private void Awake()
    {
        puVar1 = *(uint64 **)(DAT_181db4ea8 + 184);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x6002373
    // RVA   : 0xC148B0   Offset: 0xC13CB0   Length: 0xC7
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

    // Token : 0x6002374
    // RVA   : 0xC16000   Offset: 0xC15400   Length: 0xBE6
    public void ShowWeaponResearchUI()
    {
        var pStatics_3d40 = *(int64*)(DAT_181d73d40 + 184);
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
                uVar4 = Component.GetComponent(lVar3,DAT_181d96178);
                lVar3 = *(int64 *)(pStatics_3d40 + 0x4a0);
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
                              uVar4 = Component.GetComponent(lVar3,DAT_181d96178);
                              lVar3 = *(int64 *)(pStatics_3d40 + 0x4a0);
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
                                          uVar4 = Component.GetComponent(lVar3,DAT_181d96178);
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
                                                  uVar4 = Component.GetComponent(lVar3,DAT_181d96178);
                                                  lVar3 = *(int64 *)
                                                           (pStatics_3d40 + 0x4a0);
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
                                                                            (DAT_181d72cc8 + 184) + 32)
                                                               , lVar3 != null)) &&
                                                           (lVar3 = *(int64 *)(lVar3 + 0x1e8),
                                                           lVar3 != null)) {
                                                          local_res8[0] = *(uint32 *)(lVar3 + 16);
                                                          uVar7 = il2cpp_value_box(DAT_181d80430,
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
                                                                            (lVar3,DAT_181d96178);
                                                          if (((GameController._instance != null
                                                               ) && (lVar3 = *(int64 *)
                                                                              (**(int64 **)
                                                                                 (DAT_181d72cc8 + 184) +
                                                                              32), lVar3 != null)) &&
                                                             (lVar3 = *(int64 *)(lVar3 + 0x1e8),
                                                             lVar3 != null)) {
                                                            uVar6 = Single.ToString(lVar3 + 20,
                                                                                     "f0",0);
                                                            if (((GameController._instance !=
                                                                  0) && (lVar3 = *(int64 *)
                                                                                  (**(int64 **)
                                                                                     (DAT_181d72cc8 + 184
                                                                                     ) + 32), lVar3 != null
                                                                        )) &&
                                                               (lVar3 = *(int64 *)(lVar3 + 0x1e8),
                                                               lVar3 != null)) {
                                                              iVar2 = *(int *)(lVar3 + 16);
                                                              local_res18[0] =
                                                                   (float)((iVar2 + 2) * (iVar2 + 1)) *
                                                                   0.5;
                                                              uVar7 = il2cpp_value_box(DAT_181da22f0,
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
                                                                              (lVar3,DAT_181d94478);
                                                            if (((GameController._instance !=
                                                                  0) && (lVar5 = *(int64 *)
                                                                                  (**(int64 **)
                                                                                     (DAT_181d72cc8 + 184
                                                                                     ) + 32), lVar5 != null
                                                                        )) &&
                                                               (lVar5 = lVar5.weaponResearchData,
                                                               lVar5 != null)) {
                                                              fVar1 = *(float *)(lVar5 + 20);
                                                              if (((*(byte *)(DAT_181d72cc8 + 0x133) & 4)
                                                                   != 0) &&
                                                                 (*(int *)(DAT_181d72cc8 + 224) == 0)) {
                                                                il2cpp_runtime_class_init();
                                                              }
                                                              if ((((GameController._instance
                                                                     != 0) &&
                                                                   (lVar5 = *(int64 *)
                                                                             (**(int64 **)
                                                                                (DAT_181d72cc8 + 184) +
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
                                                                            (DAT_181d72cc8 + 184) + 32)
                                                               , lVar3 != null)) &&
                                                           (lVar3 = *(int64 *)(lVar3 + 0x1e8),
                                                           lVar3 != null)) {
                                                          if (0 < *(int *)(lVar3 + 40)) {
                                                            if (((GameController._instance ==
                                                                  0) || (lVar3 = *(int64 *)
                                                                                  (**(int64 **)
                                                                                     (DAT_181d72cc8 + 184
                                                                                     ) + 32), lVar3 == null
                                                                        )) ||
                                                               (lVar3 = *(int64 *)(lVar3 + 0x1e8),
                                                               lVar3 == null)) {
        LAB_180c16be1:
                          // WARNING: Subroutine does not return
                                                              FUN_1800d6620();
                                                            }
                                                            if (*(int64 *)(lVar3 + 24) != 0) {
                                                              if (((*(byte *)(DAT_181d72cc8 + 0x133) & 4)
                                                                   != 0) &&
                                                                 (*(int *)(DAT_181d72cc8 + 224) == 0)) {
                                                                il2cpp_runtime_class_init();
                                                              }
                                                              lVar3 = FUN_18046c0a0(0);
                                                              if (((lVar3 == null) ||
                                                                  (*(int64 *)(lVar3 + 32) == 0)) ||
                                                                 (lVar3 = *(int64 *)
                                                                           (*(int64 *)(lVar3 + 32) +
                                                                           0x1e8), lVar3 == null))
                                                              goto LAB_180c16be1;

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
                                                           (*plVar8 == DAT_181daf360)) {
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

    // Token : 0x6002375
    // RVA   : 0xC14980   Offset: 0xC13D80   Length: 0xEAD
    public void RefreshUI()
    {
        var pStatics_3d40 = *(int64*)(DAT_181d73d40 + 184);
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
           (lVar3 = lVar3.weaponResearchData) == null) goto LAB_180c1581c;
        lVar6 = this.weaponResearchUI;
        if (lVar3.forceAreaID < 1) {
          if (((lVar6 == null) || (lVar3 = GameObject.get_transform(lVar6,0)) == null) ||
             ((lVar3 = Transform.Find(lVar3,"SureButton",0), lVar3 == null ||
              (lVar3 = Transform.Find(lVar3,"Label",0)) == null))) {
        LAB_180c1581c:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          uVar4 = Component.GetComponent(lVar3,DAT_181d96178);
          LTLocalization.SetText(uVar4,"确认",0);
          if ((((this.weaponResearchUI == null) ||
               (lVar3 = GameObject.get_transform(this.weaponResearchUI,0)) == null) ||
              (lVar3 = Transform.Find(lVar3,"SureButton",0)) == null) ||
             (lVar3 = Transform.Find(lVar3,"Label",0)) == null) goto LAB_180c1581c;
          plVar5 = (int64 *)Component.GetComponent(lVar3,DAT_181d96178);
          lVar3 = pStatics_3d40;
          if (plVar5 == (int64 *)0) goto LAB_180c1581c;
          local_28 = *(uint32 *)(lVar3 + 0x378);
          uStack_24 = *(uint32 *)(lVar3 + 0x37c);
          uStack_20 = *(uint32 *)(lVar3 + 0x380);
          uStack_1c = *(uint32 *)(lVar3 + 900);
          (**(code **)(*plVar5 + 0x2a8))(plVar5,&local_28,*(uint64 *)(*plVar5 + 0x2b0));
          if (((this.weaponResearchUI == null) ||
              (lVar3 = GameObject.get_transform(this.weaponResearchUI,0)) == null) ||
             ((lVar3 = Transform.Find(lVar3,"ResearchTarget",0), lVar3 == null ||
              (lVar3 = Component.GetComponent(lVar3,DAT_181d93778)) == null))) goto LAB_180c1581c;
          Selectable.set_interactable(lVar3,1,0);
          if (((this.weaponResearchUI == null) ||
              (lVar3 = GameObject.get_transform(this.weaponResearchUI,0)) == null) ||
             (lVar3 = Transform.Find(lVar3,"SureButton",0)) == null) goto LAB_180c1581c;
          lVar3 = Component.get_gameObject(lVar3,0);
          if (lVar3 == null) goto LAB_180c1581c;
          GameObject.SetActive(lVar3,1,0);
          uVar4 = this.researchTargetItemIcon;
          cVar1 = Object.op_Inequality(uVar4,0,0);
          lVar3 = this.weaponResearchUI;
          if (cVar1) {
            if (((lVar3 == null) || (lVar3 = GameObject.get_transform(lVar3,0)) == null) ||
               ((lVar3 = Transform.Find(lVar3,"SureButton",0), lVar3 == null ||
                (lVar3 = Component.GetComponent(lVar3,DAT_181d93778)) == null))) {
        LAB_180c15822:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            Selectable.set_interactable(lVar3,1,0);
            if (((this.weaponResearchUI == null) ||
                (lVar3 = GameObject.get_transform(this.weaponResearchUI,0)) == null) ||
               (lVar3 = Transform.Find(lVar3,"ResearchText",0)) == null) goto LAB_180c15822;
            uVar4 = Component.GetComponent(lVar3,DAT_181d96178);
            local_res18[0] = WeaponResearchUIController.GetResearchDay(this,0);
            uVar7 = il2cpp_value_box(DAT_181d80430,local_res18);
            local_res20[0] = WeaponResearchUIController.GetExpNum(this,0);
            uVar8 = il2cpp_value_box(DAT_181d80430,local_res20);
            uVar7 = String.Format("研究时间 {0}日\n获取经验 {1}",uVar7,uVar8,0);
            LTLocalization.SetText(uVar4,uVar7,0);
            if (((this.weaponResearchUI == null) ||
                (lVar3 = GameObject.get_transform(this.weaponResearchUI,0)) == null) ||
               (lVar3 = Transform.Find(lVar3,"ResearchExtraAdd",0)) == null) goto LAB_180c15822;
            uVar4 = Component.GetComponent(lVar3,DAT_181d96178);
            if ((((this.researchTargetItemIcon == null) ||
                 (lVar3 = GameObject.GetComponent(this.researchTargetItemIcon,DAT_181d720a0),
                 lVar3 == null)) || (lVar3.villageAreaID == null)) ||
               ((lVar3 = *(int64 *)(lVar3.villageAreaID + 96), lVar3 == null ||
                (lVar3 = lVar3.forceAreaID) == null))) goto LAB_180c15822;
            uVar7 = HeroSpeAddData.GetDescribe(lVar3,1,1,1,0,0);
            lVar3 = *(int64 *)(pStatics_3d40 + 0x4a0);
            if ((((GameController._instance == null) ||
                 (lVar6 = GameController._instance.worldData) == null) ||
                (lVar6 = WorldData.Player(lVar6,0)) == null) ||
               (iVar2 = HeroData.GetWeaponResearchWeaponType(lVar6,0), lVar3 == null)) goto LAB_180c15822;
            if (lVar3.cityAreaID <= iVar2 + 3U) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            uVar7 = String.Format("{1}特效\n{0}",uVar7,
                                   *(uint64 *)
                                    (lVar3.chapter + 32 + (int64)(int)(iVar2 + 3U) * 8)
                                   ,0);
            LTLocalization.SetText(uVar4,uVar7,0);
            lVar3 = this.researchTargetClearButton;
            if (lVar3 == null) goto LAB_180c15822;
            uVar4 = 1;
            goto LAB_180c14fdf;
          }
          if (((lVar3 == null) || (lVar3 = GameObject.get_transform(lVar3,0)) == null) ||
             ((lVar3 = Transform.Find(lVar3,"SureButton",0), lVar3 == null ||
              (lVar3 = Component.GetComponent(lVar3,DAT_181d93778)) == null))) goto LAB_180c1581c;
          Selectable.set_interactable(lVar3,0,0);
          if (((this.weaponResearchUI == null) ||
              (lVar3 = GameObject.get_transform(this.weaponResearchUI,0)) == null) ||
             (lVar3 = Transform.Find(lVar3,"ResearchExtraAdd",0)) == null) goto LAB_180c1581c;
          uVar4 = Component.GetComponent(lVar3,DAT_181d96178);
          LTLocalization.SetText(uVar4,"",0);
          if (((this.weaponResearchUI == null) ||
              (lVar3 = GameObject.get_transform(this.weaponResearchUI,0)) == null) ||
             (lVar3 = Transform.Find(lVar3,"ResearchText",0)) == null) goto LAB_180c1581c;
          uVar4 = Component.GetComponent(lVar3,DAT_181d96178);
          lVar3 = *(int64 *)(pStatics_3d40 + 0x4a0);
          if ((((GameController._instance == null) ||
               (lVar6 = GameController._instance.worldData) == null) ||
              (lVar6 = WorldData.Player(lVar6,0)) == null) ||
             (iVar2 = HeroData.GetWeaponResearchWeaponType(lVar6,0), lVar3 == null)) goto LAB_180c1581c;
          if (lVar3.cityAreaID <= iVar2 + 3U) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          uVar7 = String.Format("消耗{0}武器\n研究获取经验",
                                 *(uint64 *)
                                  (lVar3.chapter + 32 + (int64)(int)(iVar2 + 3U) * 8),0
                                );
          LTLocalization.SetText(uVar4,uVar7,0);
          lVar3 = this.researchTargetClearButton;
          if (lVar3 == null) goto LAB_180c1581c;
        }
        else {
          if (((lVar6 == null) || (lVar3 = GameObject.get_transform(lVar6,0)) == null) ||
             ((lVar3 = Transform.Find(lVar3,"ResearchTarget",0), lVar3 == null ||
              (lVar3 = Component.GetComponent(lVar3,DAT_181d93778)) == null))) {
        LAB_180c15828:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          Selectable.set_interactable(lVar3,0,0);
          if (((this.weaponResearchUI == null) ||
              (lVar3 = GameObject.get_transform(this.weaponResearchUI,0)) == null) ||
             ((lVar3 = Transform.Find(lVar3,"SureButton",0), lVar3 == null ||
              (lVar3 = Transform.Find(lVar3,"Label",0)) == null))) goto LAB_180c15828;
          uVar4 = Component.GetComponent(lVar3,DAT_181d96178);
          LTLocalization.SetText(uVar4,"研究中",0);
          if ((((this.weaponResearchUI == null) ||
               (lVar3 = GameObject.get_transform(this.weaponResearchUI,0)) == null) ||
              (lVar3 = Transform.Find(lVar3,"SureButton",0)) == null) ||
             (lVar3 = Transform.Find(lVar3,"Label",0)) == null) goto LAB_180c15828;
          plVar5 = (int64 *)Component.GetComponent(lVar3,DAT_181d96178);
          puVar9 = (uint32 *)Color.get_red(&local_28,0);
          if (plVar5 == (int64 *)0) goto LAB_180c15828;
          local_28 = *puVar9;
          uStack_24 = puVar9[1];
          uStack_20 = puVar9[2];
          uStack_1c = puVar9[3];
          (**(code **)(*plVar5 + 0x2a8))(plVar5,&local_28,*(uint64 *)(*plVar5 + 0x2b0));
          if (((this.weaponResearchUI == null) ||
              (lVar3 = GameObject.get_transform(this.weaponResearchUI,0)) == null) ||
             ((lVar3 = Transform.Find(lVar3,"SureButton",0), lVar3 == null ||
              (lVar3 = Component.GetComponent(lVar3,DAT_181d93778)) == null))) goto LAB_180c15828;
          Selectable.set_interactable(lVar3,0,0);
          if (((this.weaponResearchUI == null) ||
              (lVar3 = GameObject.get_transform(this.weaponResearchUI,0)) == null) ||
             (lVar3 = Transform.Find(lVar3,"ResearchText",0)) == null) goto LAB_180c15828;
          uVar4 = Component.GetComponent(lVar3,DAT_181d96178);
          if (((GameController._instance == null) ||
              (lVar3 = GameController._instance.worldData) == null) ||
             (lVar3 = lVar3.weaponResearchData) == null) goto LAB_180c15828;
          local_res18[0] = lVar3.forceAreaID;
          uVar7 = il2cpp_value_box(DAT_181d80430,local_res18);
          local_res20[0] = WeaponResearchUIController.GetExpNum(this,0);
          uVar8 = il2cpp_value_box(DAT_181d80430,local_res20);
          uVar7 = String.Format("剩余时间 {0}日\n获取经验 {1}",uVar7,uVar8,0);
          LTLocalization.SetText(uVar4,uVar7,0);
          if (((this.weaponResearchUI == null) ||
              (lVar3 = GameObject.get_transform(this.weaponResearchUI,0)) == null) ||
             (lVar3 = Transform.Find(lVar3,"ResearchExtraAdd",0)) == null) goto LAB_180c15828;
          uVar4 = Component.GetComponent(lVar3,DAT_181d96178);
          if ((((GameController._instance == null) ||
               (lVar3 = GameController._instance.worldData) == null) ||
              (lVar3 = lVar3.weaponResearchData) == null) ||
             (lVar3 = lVar3.villageAreaID) == null) goto LAB_180c15828;
          uVar7 = HeroSpeAddData.GetDescribe(lVar3,1,1,1,0,0);
          lVar3 = *(int64 *)(pStatics_3d40 + 0x4a0);
          if ((((GameController._instance == null) ||
               (lVar6 = GameController._instance.worldData) == null) ||
              (lVar6 = WorldData.Player(lVar6,0)) == null) ||
             (iVar2 = HeroData.GetWeaponResearchWeaponType(lVar6,0), lVar3 == null)) goto LAB_180c15828;
          if (lVar3.cityAreaID <= iVar2 + 3U) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          uVar7 = String.Format("{1}特效\n{0}",uVar7,
                                 *(uint64 *)
                                  (lVar3.chapter + 32 + (int64)(int)(iVar2 + 3U) * 8),0
                                );
          LTLocalization.SetText(uVar4,uVar7,0);
          lVar3 = this.researchTargetClearButton;
          if (lVar3 == null) goto LAB_180c15828;
        }
        uVar4 = 0;
        LAB_180c14fdf:
        GameObject.SetActive(lVar3,uVar4,0);
    }

    // Token : 0x6002376
    // RVA   : 0xC14740   Offset: 0xC13B40   Length: 0xAE
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
          lVar2 = GameObject.GetComponent(this.researchTargetItemIcon,DAT_181d720a0);
          if ((lVar2 != null) && (*(int64 *)(lVar2 + 32) != 0)) {
            uVar3 = ItemData.GetWeaponResearchExp(*(int64 *)(lVar2 + 32),0);
            return uVar3;
          }
        }
    }

    // Token : 0x6002377
    // RVA   : 0xC147F0   Offset: 0xC13BF0   Length: 0xB0
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
          lVar3 = GameObject.GetComponent(this.researchTargetItemIcon,DAT_181d720a0);
          if ((lVar3 != null) && (*(int64 *)(lVar3 + 32) != 0)) {
            return (*(int *)(*(int64 *)(lVar3 + 32) + 60) + 1) * 5;
          }
        }
    }

    // Token : 0x6002378
    // RVA   : 0xC15830   Offset: 0xC14C30   Length: 0x3E2
    public void ResearchButtonClicked()
    {
        uint uVar1;
        long lVar2;
        long lVar4;
        if ((GameController._instance != null) &&
           (lVar4 = GameController._instance.worldData) != null) {
          lVar4 = lVar4.weaponResearchData;
          if ((this.researchTargetItemIcon != null) &&
             ((lVar2 = GameObject.GetComponent(this.researchTargetItemIcon,DAT_181d720a0), lVar2 != null
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
                     ((((lVar2 = GameObject.GetComponent(this.researchTargetItemIcon,DAT_181d720a0),
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
                         ((lVar2 = GameObject.GetComponent(this.researchTargetItemIcon,DAT_181d720a0),
                          lVar2 != null && (lVar4 != null)))) {
                        HeroData.LoseItem(lVar4,*(uint64 *)(lVar2 + 32),1,0);
                        plVar3 = (int64 *)Resources.Load("Sound/SoundEffect/SpeEffect/修理升级",0);
                        plVar5 = (int64 *)0;
                        if ((plVar3 != (int64 *)0) && (*plVar3 == DAT_181daf360)) {
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

    // Token : 0x6002379
    // RVA   : 0xC15C20   Offset: 0xC15020   Length: 0x339
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
        lVar1 = **(int64 **)(DAT_181db7530 + 184);
        lVar3 = il2cpp_internal(DAT_181d94e68);
        FUN_181330100(lVar3,DAT_181d957a0);
        local_res8[0] = 0;
        uVar4 = il2cpp_value_box(DAT_181d80430,local_res8);
        if (lVar3 != null) {
          FUN_18181e6b0(lVar3,uVar4,DAT_181d958a0);
          local_res18[0] = 0;
          uVar4 = il2cpp_value_box(DAT_181d80430,local_res18);
          FUN_18181e6b0(lVar3,uVar4,DAT_181d958a0);
          local_res20[0] = 0xffffffff;
          uVar4 = il2cpp_value_box(DAT_181d80430,local_res20);
          FUN_18181e6b0(lVar3,uVar4,DAT_181d958a0);
          local_28 = 0xffffffff;
          uVar4 = il2cpp_value_box(DAT_181d80430,&local_28);
          FUN_18181e6b0(lVar3,uVar4,DAT_181d958a0);
          local_24 = 0;
          uVar4 = il2cpp_value_box(DAT_181d80430,&local_24);
          FUN_18181e6b0(lVar3,uVar4,DAT_181d958a0);
          local_20 = 0xffffffff;
          uVar4 = il2cpp_value_box(DAT_181d80430,&local_20);
          FUN_18181e6b0(lVar3,uVar4,DAT_181d958a0);
          if (((GameController._instance != null) &&
              (lVar5 = GameController._instance.worldData) != null) &&
             (lVar5 = WorldData.Player(lVar5,0)) != null) {
            local_1c = HeroData.GetWeaponResearchWeaponType(lVar5,0);
            uVar4 = il2cpp_value_box(DAT_181d80430,&local_1c);
            FUN_18181e6b0(lVar3,uVar4,DAT_181d958a0);
            uVar4 = Component.get_gameObject(this,0);
            if (lVar1 != null) {
              ChooseController.ShowChoosePanel(lVar1,1,lVar3,uVar4,"ResearchTargetChoosen",0,0,0,0,0);
              return;
            }
          }
        }
    }

    // Token : 0x600237A
    // RVA   : 0xC15F60   Offset: 0xC15360   Length: 0x94
    public void ResearchTargetChoosen()
    {
        var pStatics = *(int64*)(DAT_181db7530 + 184);
        long lVar1;
        if ((*pStatics != 0) &&
           (lVar1 = *(int64 *)(*pStatics + 72)) != null) {
          lVar1 = GameObject.GetComponent(lVar1,DAT_181d720a0);
          if (lVar1 != null) {
            WeaponResearchUIController.CreateResearchTargetItemIcon
                      (this,*(uint64 *)(lVar1 + 32),0);
            WeaponResearchUIController.RefreshUI(this,0);
            return;
          }
        }
    }

    // Token : 0x600237B
    // RVA   : 0xC145A0   Offset: 0xC139A0   Length: 0x19B
    public void CreateResearchTargetItemIcon(ItemData targetItemData)
    {
        var pStatics = *(int64*)(DAT_181d72ee8 + 184);
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
                  lVar2 = GameObject.GetComponent(this.researchTargetItemIcon,DAT_181d720a0);
                  if (lVar2 != null) {
                    *(uint64 *)(lVar2 + 32) = targetItemData;
                    if (this.researchTargetItemIcon != null) {
                      lVar2 = GameObject.GetComponent(this.researchTargetItemIcon,DAT_181d720a0);
                      if (lVar2 != null) {
                        *(uint32 *)(lVar2 + 40) = 1;
                        if (this.researchTargetItemIcon != null) {
                          lVar2 = GameObject.GetComponent(this.researchTargetItemIcon,DAT_181d720a0);
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

    // Token : 0x600237C
    // RVA   : 0xC144E0   Offset: 0xC138E0   Length: 0xBA
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

    // Token : 0x600237D
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
