// ============================================================
// Type  : BranchUIController
// Token : 0x20001A0
// ============================================================

public class BranchUIController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000AF9
    public GameObject branchUIPanel;

    // Token: 0x4000AFA
    public GameObject branchUI;

    // Token: 0x4000AFB
    public AreaData areaData;

    // Token: 0x4000AFC
    public AreaBuildingData branchBuildingData;

    // Token: 0x4000AFD
    public GameObject branchLeaderSettingRoot;

    // Token: 0x4000AFE
    public GameObject branchLeaderSettingTabPrefab;

    // Token: 0x4000AFF
    private static BranchUIController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000D58
    // RVA   : 0xCE9BC0   Offset: 0xCE83C0   Length: 0x36
    public static BranchUIController get_Instance()
    {
        return **(uint64 **)(DAT_181d8e2b0 + 184);
    }

    // Token : 0x6000D59
    // RVA   : 0xCE8050   Offset: 0xCE6850   Length: 0x43
    private void Awake()
    {
        puVar1 = *(uint64 **)(DAT_181d8e2b0 + 184);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x6000D5A
    // RVA   : 0xCE9B40   Offset: 0xCE8340   Length: 0x74
    private void Start()
    {
        long lVar1;
        ulong uVar2;
        if (this.branchUIPanel != null) {
          lVar1 = GameObject.get_transform(this.branchUIPanel,0);
          if (lVar1 != null) {
            lVar1 = Transform.Find(lVar1,"BranchUI",0);
            if (lVar1 != null) {
              uVar2 = Component.get_gameObject(lVar1,0);
              this.branchUI = uVar2;
              return;
            }
          }
        }
    }

    // Token : 0x6000D5B
    // RVA   : 0xCE9280   Offset: 0xCE7A80   Length: 0x8B7
    public void ShowBranchUI(AreaData targetArea)
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        ulong uVar1;
        ulong uVar3;
        long lVar4;
        long lVar6;
        long lVar7;
        ulong local_28;
        uint local_20;
        uint local_18;
        uint uStack_14;
        uint uStack_10;
        uint32 uStack_c;
        plVar2 = (int64 *)Resources.Load("Sound/SoundEffect/Door/BigDoor1",0);
        plVar10 = (int64 *)0;
        plVar9 = plVar10;
        if ((plVar2 != (int64 *)0) && (plVar9 = (int64 *)0, *plVar2 == DAT_181d8a228)) {
          plVar9 = plVar2;
        }
        NGUITools.PlaySound(plVar9,0);
        this.areaData = targetArea;
        if (targetArea != null) {
          uVar3 = AreaData.FindBuilding(targetArea,"分舵",0);
          this.branchBuildingData = uVar3;
          if (this.branchUIPanel != null) {
            GameObject.SetActive(this.branchUIPanel,1,0);
            if (this.branchUI != null) {
              lVar4 = GameObject.get_transform(this.branchUI,0);
              if (lVar4 != null) {
                local_28 = 0x3f80000000000000;
                local_20 = 0x3f800000;
                Transform.set_localScale(lVar4,&local_28,0);
                if (this.branchUI != null) {
                  uVar3 = GameObject.get_transform(this.branchUI,0);
                  puVar5 = (uint64 *)Vector3.get_one(&local_18,0);
                  local_20 = *(uint32 *)(puVar5 + 1);
                  local_28 = *puVar5;
                  ShortcutExtensions.DOScale(uVar3,&local_28,0x3e4ccccd,0);
                  if (this.branchUIPanel != null) {
                    lVar4 = GameObject.get_transform(this.branchUIPanel,0);
                    if (lVar4 != null) {
                      lVar4 = Transform.Find(lVar4,"BlackBackground",0);
                      if (lVar4 != null) {
                        uVar3 = Component.GetComponent(lVar4,DAT_181d6bc40);
                        DOTweenModuleUI.DOFade(uVar3,0x3f000000,0x3e4ccccd,0);
                        uVar3 = this.branchLeaderSettingRoot;
                        uVar1 = this.branchLeaderSettingTabPrefab;
                        lVar4 = GlobalData.AddChild(uVar3,uVar1,0);
                        if (lVar4 != null) {
                          lVar6 = GameObject.GetComponent(lVar4,DAT_181d9ebb8);
                          if (lVar6 != null) {
                            *(uint64 *)(lVar6 + 32) = this.areaData;
                            lVar6 = GameObject.GetComponent(lVar4,DAT_181d9ebb8);
                            if (this.areaData != null) {
                              uVar3 = AreaData.GetForce(this.areaData,0);
                              if (lVar6 != null) {
                                *(uint64 *)(lVar6 + 40) = uVar3;
                                lVar4 = GameObject.GetComponent(lVar4,DAT_181d9ebb8);
                                if (this.areaData != null) {
                                  lVar6 = AreaData.GetForce(this.areaData,0);
                                  if ((*pStatics != 0) &&
                                     (lVar7 = *(int64 *)(*pStatics + 32),
                                     lVar7 != null)) {
                                    lVar7 = WorldData.Player(lVar7,0);
                                    if (lVar7 != null) {
                                      lVar7 = HeroData.GetForce(lVar7,0,0);
                                      if (lVar6 == lVar7) {
                                        if ((*pStatics == 0) ||
                                           (lVar6 = *(int64 *)
                                                     (*pStatics + 32),
                                           lVar6 == null)) throw; // [null/range check failed]
                                        lVar6 = WorldData.Player(lVar6,0);
                                        if (lVar6 == null) throw; // [null/range check failed]
                                        plVar10 = (int64 *)(uint64)(3 < *(int *)(lVar6 + 184));
                                      }
                                      if (lVar4 != null) {
                                        *(char *)(lVar4 + 24) = (char)plVar10;
                                        if (this.areaData != null) {
                                          lVar4 = AreaData.GetForce(this.areaData,0);
                                          if ((*pStatics != 0) &&
                                             (lVar6 = *(int64 *)
                                                       (*pStatics + 32),
                                             lVar6 != null)) {
                                            lVar6 = WorldData.Player(lVar6,0);
                                            if (lVar6 != null) {
                                              lVar6 = HeroData.GetForce(lVar6,0,0);
                                              if (lVar4 == lVar6) {
                                                if ((*pStatics != 0) &&
                                                   (lVar4 = *(int64 *)
                                                             (*pStatics + 32
                                                             ), lVar4 != null)) {
                                                  lVar4 = WorldData.Player(lVar4,0);
                                                  if (lVar4 != null) {
                                                    lVar6 = this.branchUI;
                                                    if (*(int *)(lVar4 + 184) < 4) {
                                                      if (lVar6 != null) {
                                                        lVar4 = GameObject.get_transform(lVar6,0);
                                                        if (lVar4 != null) {
                                                          lVar4 = Transform.Find(lVar4,"NotSelfText",0);
                                                          if (lVar4 != null) {
                                                            uVar3 = Component.GetComponent
                                                                              (lVar4,DAT_181d6d8c0);
                                                            LTLocalization.SetText(uVar3,"长老以上方能进行管理",0)
                                                            ;
                                                            if (this.branchUI != null) {
                                                              lVar4 = GameObject.get_transform
                                                                                (*(int64 *)
                                                                                  (this + 32),0);
                                                              if (lVar4 != null) {
                                                                lVar4 = Transform.Find(lVar4,
                                                        "NotSelfText",0);
                                                        if (lVar4 != null) {
                                                          plVar2 = (int64 *)
                                                                   Component.GetComponent
                                                                             (lVar4,DAT_181d6d8c0);
                                                          lVar4 = FUN_18046c100(0);
                                                          if ((lVar4 != null) &&
                                                             (lVar4 = *(int64 *)(lVar4 + 56),
                                                             lVar4 != null)) {
                                                            if (*(uint32 *)(lVar4 + 24) < 5) {

                                                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                                        }
                                                        lVar4 = *(int64 *)
                                                                 (*(int64 *)(lVar4 + 16) + 64);
                                                        if ((lVar4 != null) && (plVar2 != (int64 *)0)) {
                                                          local_18 = *(uint32 *)(lVar4 + 24);
                                                          uStack_14 = *(uint32 *)(lVar4 + 28);
                                                          uStack_10 = *(uint32 *)(lVar4 + 32);
                                                          uStack_c = *(uint32 *)(lVar4 + 36);
                                                          (**(code **)(*plVar2 + 0x2a8))
                                                                    (plVar2,&local_18,
                                                                     *(uint64 *)(*plVar2 + 0x2b0));
                                                          goto LAB_180ce9b0e;
                                                        }
                                                        }
                                                        }
                                                        }
                                                        }
                                                        }
                                                        }
                                                      }
                                                    }
                                                    else if (lVar6 != null) {
                                                      lVar4 = GameObject.get_transform(lVar6,0);
                                                      if (lVar4 != null) {
                                                        lVar4 = Transform.Find(lVar4,"NotSelfText",0);
                                                        if (lVar4 != null) {
                                                          plVar2 = (int64 *)
                                                                   Component.GetComponent
                                                                             (lVar4,DAT_181d6d8c0);
                                                          if (plVar2 != (int64 *)0) {
                                                            (**(code **)(*plVar2 + 0x5e8))
                                                                      (plVar2,"",
                                                                       *(uint64 *)(*plVar2 + 0x5f0));
        LAB_180ce9b0e:
                                                            BranchUIController.RefreshBranchUI(this,0)
                                                            ;
                                                            return;
                                                          }
                                                        }
                                                      }
                                                    }
                                                  }
                                                }
                                              }
                                              else if (this.branchUI != null) {
                                                lVar4 = GameObject.get_transform
                                                                  (this.branchUI,0);
                                                if (lVar4 != null) {
                                                  lVar4 = Transform.Find(lVar4,"NotSelfText",0);
                                                  if (lVar4 != null) {
                                                    uVar3 = Component.GetComponent(lVar4,DAT_181d6d8c0);
                                                    LTLocalization.SetText(uVar3,"非本门分舵无法管理",0);
                                                    if (this.branchUI != null) {
                                                      lVar4 = GameObject.get_transform
                                                                        (this.branchUI,0);
                                                      if (lVar4 != null) {
                                                        lVar4 = Transform.Find(lVar4,"NotSelfText",0);
                                                        if (lVar4 != null) {
                                                          plVar2 = (int64 *)
                                                                   Component.GetComponent
                                                                             (lVar4,DAT_181d6d8c0);
                                                          puVar8 = (uint32 *)
                                                                   Color.get_red(&local_18,0);
                                                          if (plVar2 != (int64 *)0) {
                                                            local_18 = *puVar8;
                                                            uStack_14 = puVar8[1];
                                                            uStack_10 = puVar8[2];
                                                            uStack_c = puVar8[3];
                                                            (**(code **)(*plVar2 + 0x2a8))
                                                                      (plVar2,&local_18,
                                                                       *(uint64 *)(*plVar2 + 0x2b0));
                                                            goto LAB_180ce9b0e;
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

    // Token : 0x6000D5C
    // RVA   : 0xCE81B0   Offset: 0xCE69B0   Length: 0x141
    public void HideBranchUI()
    {
        ulong uVar1;
        ulong uVar2;
        long lVar3;
        uint local_18;
        uint local_14;
        uint local_10;
        if (this.branchUI != null) {
          uVar1 = GameObject.get_transform(this.branchUI,0);
          local_18 = 0;
          local_14 = 0x3f800000;
          local_10 = 0x3f800000;
          uVar1 = ShortcutExtensions.DOScale(uVar1,&local_18,0x3e4ccccd,0);
          uVar2 = new OnTooltipCB(this,DAT_181d64ad0,0);
          TweenSettingsExtensions.OnComplete(uVar1,uVar2,DAT_181d96ee8);
          if (this.branchUIPanel != null) {
            lVar3 = GameObject.get_transform(this.branchUIPanel,0);
            if (lVar3 != null) {
              lVar3 = Transform.Find(lVar3,"BlackBackground",0);
              if (lVar3 != null) {
                uVar1 = Component.GetComponent(lVar3,DAT_181d6bc40);
                DOTweenModuleUI.DOFade(uVar1,0,0x3e4ccccd,0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x6000D5D
    // RVA   : 0x790570   Offset: 0x78ED70   Length: 0x20
    public void DisactiveUIPanel()
    {
        if (this.branchUIPanel != null) {
          GameObject.SetActive(this.branchUIPanel,0,0);
          return;
        }
    }

    // Token : 0x6000D5E
    // RVA   : 0xCE8300   Offset: 0xCE6B00   Length: 0xF76
    public void RefreshBranchUI()
    {
        uint uVar1;
        bool cVar2;
        int iVar3;
        long lVar4;
        ulong uVar5;
        ulong uVar6;
        long lVar7;
        uint[] local_res8 = new uint[2];
        uint[] local_res18 = new uint[2];
        if ((((this.branchUI != null) &&
             (lVar4 = GameObject.get_transform(this.branchUI,0)) != null) &&
            (lVar4 = Transform.Find(lVar4,"BuildingLv",0)) != null) &&
           (lVar4 = Transform.Find(lVar4,"Lv",0)) != null) {
          uVar5 = Component.GetComponent(lVar4,DAT_181d6d8c0);
          if (this.branchBuildingData != null) {
            uVar1 = this.branchBuildingData.lv;
            uVar6 = GlobalData.GetNumText(uVar1,0);
            uVar6 = String.Format("{0}级",uVar6,0);
            LTLocalization.SetText(uVar5,uVar6,0);
            lVar4 = this.areaData;
            local_res8[0] = 0;
            if (lVar4 != null) {
              while (lVar4.areaBranchDefenceLv != null) {
                if (*(int *)(lVar4.areaBranchDefenceLv + 24) <= (int)local_res8[0]) {
                  return;
                }
                if ((this.branchUI == null) ||
                   (lVar4 = GameObject.get_transform(this.branchUI,0)) == null)
                break;
                lVar4 = Transform.Find(lVar4,"Grid",0);
                uVar5 = Int32.ToString(local_res8,0);
                if ((lVar4 == null) ||
                   ((lVar4 = Transform.Find(lVar4,uVar5,0), lVar4 == null ||
                    (lVar4 = Transform.Find(lVar4,"Lv",0)) == null))) break;
                uVar5 = Component.GetComponent(lVar4,DAT_181d6d8c0);
                if (this.areaData == null) break;
                lVar4 = this.areaData.areaBranchDefenceLv;
                lVar7 = (int64)(int)local_res8[0];
                if (lVar4 == null) break;
                if (lVar4.areaName <= local_res8[0]) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                uVar1 = *(uint32 *)(lVar4.areaID + 32 + lVar7 * 4);
                uVar6 = GlobalData.GetNumText(uVar1,0);
                uVar6 = String.Format("{0}级",uVar6,0);
                LTLocalization.SetText(uVar5,uVar6,0);
                if ((this.areaData == null) ||
                   (lVar4 = this.areaData.areaBranchDefenceUpgradeLeftTime) == null) break;
                iVar3 = FUN_1800d6750(lVar4,local_res8[0]);
                lVar4 = this.branchUI;
                if (iVar3 < 1) {
                  if ((lVar4 == null) || (lVar4 = GameObject.get_transform(lVar4,0)) == null) break;
                  lVar4 = Transform.Find(lVar4,"Grid");
                  uVar5 = Int32.ToString(local_res8,0);
                  if ((lVar4 == null) ||
                     ((lVar4 = Transform.Find(lVar4,uVar5), lVar4 == null ||
                      (lVar4 = Transform.Find(lVar4,"UpgradeText")) == null))) break;
                  uVar5 = Component.GetComponent(lVar4,DAT_181d6d8c0);
                  uVar6 = "";
                }
                else {
                  if ((lVar4 == null) || (lVar4 = GameObject.get_transform(lVar4,0)) == null) {
        LAB_180ce9271:
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  lVar4 = Transform.Find(lVar4,"Grid",0);
                  uVar5 = Int32.ToString(local_res8,0);
                  if ((lVar4 == null) ||
                     ((lVar4 = Transform.Find(lVar4,uVar5,0), lVar4 == null ||
                      (lVar4 = Transform.Find(lVar4,"UpgradeText",0)) == null))) goto LAB_180ce9271;
                  uVar5 = Component.GetComponent(lVar4,DAT_181d6d8c0);
                  if ((this.areaData == null) ||
                     (lVar4 = this.areaData.areaBranchDefenceUpgradeLeftTime) == null)
                  goto LAB_180ce9271;
                  local_res18[0] = FUN_1800d6750(lVar4,local_res8[0]);
                  uVar6 = il2cpp_value_box(DAT_181d5b2f8,local_res18);
                  uVar6 = String.Format("升级中\n剩余{0}天",uVar6);
                }
                LTLocalization.SetText(uVar5,uVar6);
                cVar2 = GameController.MeetCondition("我",0);
                if (!cVar2) {
                  lVar4 = this.branchUI;
        LAB_180ce91bb:
                  if ((lVar4 == null) || (lVar4 = GameObject.get_transform(lVar4,0)) == null) break;
                  lVar4 = Transform.Find(lVar4,"Grid");
                  uVar5 = Int32.ToString(local_res8,0);
                  if ((lVar4 == null) ||
                     (((lVar4 = Transform.Find(lVar4,uVar5), lVar4 == null ||
                       (lVar4 = Transform.Find(lVar4)) == null) ||
                      (lVar4 = Component.get_gameObject(lVar4)) == null))) break;
                  GameObject.SetActive(lVar4);
                }
                else {
                  if ((this.areaData == null) ||
                     (lVar4 = this.areaData.areaBranchDefenceUpgradeLeftTime) == null) break;
                  iVar3 = FUN_1800d6750(lVar4,local_res8[0]);
                  lVar4 = this.branchUI;
                  if (0 < iVar3) goto LAB_180ce91bb;
                  if ((lVar4 == null) || (lVar4 = GameObject.get_transform(lVar4,0)) == null) break;
                  lVar4 = Transform.Find(lVar4,"Grid",0);
                  uVar5 = Int32.ToString(local_res8,0);
                  if ((lVar4 == null) ||
                     ((lVar4 = Transform.Find(lVar4,uVar5,0), lVar4 == null ||
                      (lVar4 = Transform.Find(lVar4,"Upgrade",0)) == null))) break;
                  lVar4 = Component.get_gameObject(lVar4,0);
                  if (lVar4 == null) break;
                  GameObject.SetActive(lVar4,1,0);
                  if ((this.branchUI == null) ||
                     (lVar4 = GameObject.get_transform(this.branchUI,0)) == null)
                  break;
                  lVar4 = Transform.Find(lVar4,"Grid",0);
                  uVar5 = Int32.ToString(local_res8,0);
                  if ((lVar4 == null) ||
                     (((lVar4 = Transform.Find(lVar4,uVar5,0), lVar4 == null ||
                       (lVar4 = Transform.Find(lVar4,"Upgrade",0)) == null) ||
                      (lVar4 = Component.GetComponent(lVar4,DAT_181d6af40)) == null))) break;
                  Selectable.set_interactable(lVar4,1,0);
                  if ((this.branchUI == null) ||
                     (lVar4 = GameObject.get_transform(this.branchUI,0)) == null)
                  break;
                  lVar4 = Transform.Find(lVar4,"Grid",0);
                  uVar5 = Int32.ToString(local_res8,0);
                  if ((lVar4 == null) ||
                     ((lVar4 = Transform.Find(lVar4,uVar5,0), lVar4 == null ||
                      (lVar4 = Transform.Find(lVar4,"Upgrade",0)) == null))) break;
                  lVar4 = Component.GetComponent(lVar4,DAT_181d6ccc0);
                  if (this.areaData == null) break;
                  uVar5 = AreaData.GetUpgradeDefenceLvCost(this.areaData,local_res8[0],0)
                  ;
                  uVar5 = GlobalData.GetResourceDescribe(uVar5,0);
                  if (lVar4 == null) break;
                  lVar4.areaName = uVar5;
                  lVar4 = FUN_18046c0a0(0);
                  if (((lVar4 == null) || (lVar4.areaStartLv == null)) ||
                     (lVar4 = WorldData.Player(lVar4.areaStartLv,0)) == null) break;
                  lVar4 = HeroData.GetForce(lVar4,0,0);
                  if ((this.areaData == null) ||
                     (uVar5 = AreaData.GetUpgradeDefenceLvCost
                                        (this.areaData,local_res8[0],0), lVar4 == null))
                  break;
                  cVar2 = ForceData.HaveResource(lVar4,uVar5,0);
                  if (!cVar2) {
                    if ((this.branchUI == null) ||
                       (lVar4 = GameObject.get_transform(this.branchUI,0)) == null)
                    break;
                    lVar4 = Transform.Find(lVar4,"Grid",0);
                    uVar5 = Int32.ToString(local_res8,0);
                    if ((lVar4 == null) ||
                       (((lVar4 = Transform.Find(lVar4,uVar5,0), lVar4 == null ||
                         (lVar4 = Transform.Find(lVar4,"Upgrade",0)) == null) ||
                        (lVar4 = Component.GetComponent(lVar4,DAT_181d6af40)) == null))) break;
                    Selectable.set_interactable(lVar4,0,0);
                  }
                  if ((this.areaData == null) ||
                     (lVar4 = this.areaData.areaBranchDefenceLv) == null) break;
                  iVar3 = FUN_1800d6750(lVar4,local_res8[0]);
                  if (iVar3 < 10) {
                    if ((this.areaData == null) ||
                       (this.areaData.areaBranchDefenceLv == null)) break;
                    iVar3 = FUN_1800d6750();
                    if (this.branchBuildingData == null) break;
                    if (this.branchBuildingData.lv <= iVar3) {
                      if ((this.branchUI != null) &&
                         (lVar4 = GameObject.get_transform(this.branchUI,0)) != null)
                      {
                        lVar4 = Transform.Find(lVar4,"Grid");
                        uVar5 = Int32.ToString(local_res8,0);
                        if ((lVar4 != null) &&
                           (((lVar4 = Transform.Find(lVar4,uVar5), lVar4 != null &&
                             (lVar4 = Transform.Find(lVar4,"Upgrade")) != null) &&
                            (lVar4 = Component.GetComponent(lVar4,DAT_181d6af40)) != null))) {
                          Selectable.set_interactable(lVar4,0);
                          if ((this.branchUI != null) &&
                             (lVar4 = GameObject.get_transform(this.branchUI,0),
                             lVar4 != null)) {
                            lVar4 = Transform.Find(lVar4,"Grid");
                            uVar5 = Int32.ToString(local_res8,0);
                            if ((lVar4 != null) &&
                               ((lVar4 = Transform.Find(lVar4,uVar5), lVar4 != null &&
                                (lVar4 = Transform.Find(lVar4,"Upgrade")) != null))) {
                              lVar4 = Component.GetComponent(lVar4,DAT_181d6ccc0);
                              if ((this.branchUI != null) &&
                                 (lVar7 = GameObject.get_transform(this.branchUI,0),
                                 lVar7 != null)) {
                                lVar7 = Transform.Find(lVar7,"Grid");
                                uVar5 = Int32.ToString(local_res8,0);
                                if ((((lVar7 != null) && (lVar7 = Transform.Find(lVar7,uVar5)) != null)
                                    && (lVar7 = Transform.Find(lVar7,"Upgrade")) != null) &&
                                   ((lVar7 = Component.GetComponent(lVar7,DAT_181d6ccc0), lVar7 != null &&
                                    (uVar5 = String.Concat("<color=red>需要 升级分舵</color>\n\n",*(uint64 *)(lVar7 + 24)),
                                    lVar4 != null)))) {
                                  lVar4.areaName = uVar5;
                                  goto LAB_180ce8f26;
                                }
                              }
                            }
                          }
                        }
                      }
                      break;
                    }
                  }
                  else {
                    if ((this.branchUI == null) ||
                       (lVar4 = GameObject.get_transform(this.branchUI,0)) == null)
                    break;
                    lVar4 = Transform.Find(lVar4,"Grid");
                    uVar5 = Int32.ToString(local_res8,0);
                    if ((lVar4 == null) ||
                       (((lVar4 = Transform.Find(lVar4,uVar5), lVar4 == null ||
                         (lVar4 = Transform.Find(lVar4,"Upgrade")) == null) ||
                        (lVar4 = Component.GetComponent(lVar4,DAT_181d6af40)) == null))) break;
                    Selectable.set_interactable(lVar4,0);
                    if ((this.branchUI == null) ||
                       (lVar4 = GameObject.get_transform(this.branchUI,0)) == null)
                    break;
                    lVar4 = Transform.Find(lVar4,"Grid");
                    uVar5 = Int32.ToString(local_res8,0);
                    if ((lVar4 == null) ||
                       (((lVar4 = Transform.Find(lVar4,uVar5), lVar4 == null ||
                         (lVar4 = Transform.Find(lVar4,"Upgrade")) == null) ||
                        (lVar4 = Component.GetComponent(lVar4,DAT_181d6ccc0)) == null))) break;
                    lVar4.areaName = "登峰造极";
        LAB_180ce8f26:
                    il2cpp_internal();
                  }
                  cVar2 = GameController.MeetCondition("亲传弟子");
                  if (!cVar2) {
                    if ((this.branchUI == null) ||
                       (lVar4 = GameObject.get_transform(this.branchUI,0)) == null)
                    break;
                    lVar4 = Transform.Find(lVar4,"Grid");
                    uVar5 = Int32.ToString(local_res8,0);
                    if ((lVar4 == null) ||
                       (((lVar4 = Transform.Find(lVar4,uVar5), lVar4 == null ||
                         (lVar4 = Transform.Find(lVar4,"Upgrade")) == null) ||
                        (lVar4 = Component.GetComponent(lVar4,DAT_181d6af40)) == null))) break;
                    Selectable.set_interactable(lVar4,0);
                    if ((this.branchUI == null) ||
                       (lVar4 = GameObject.get_transform(this.branchUI,0)) == null)
                    break;
                    lVar4 = Transform.Find(lVar4,"Grid");
                    uVar5 = Int32.ToString(local_res8,0);
                    if ((lVar4 == null) ||
                       ((lVar4 = Transform.Find(lVar4,uVar5), lVar4 == null ||
                        (lVar4 = Transform.Find(lVar4,"Upgrade")) == null))) break;
                    lVar4 = Component.GetComponent(lVar4,DAT_181d6ccc0);
                    lVar7 = *(int64 *)(*(int64 *)(DAT_181d4ef00 + 184) + 0x3d0);
                    if (lVar7 == null) break;
                    if (*(uint32 *)(lVar7 + 24) < 4) {
                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                    }
                    uVar5 = GlobalData.GenerateRareLvColorText
                                      (*(uint64 *)(*(int64 *)(lVar7 + 16) + 56),3);
                    uVar5 = String.Format("需要 {0}\n\n",uVar5);
                    if ((this.branchUI == null) ||
                       (lVar7 = GameObject.get_transform(this.branchUI,0)) == null)
                    break;
                    lVar7 = Transform.Find(lVar7,"Grid");
                    uVar6 = Int32.ToString(local_res8,0);
                    if (((lVar7 == null) ||
                        (((lVar7 = Transform.Find(lVar7,uVar6), lVar7 == null ||
                          (lVar7 = Transform.Find(lVar7,"Upgrade")) == null) ||
                         (lVar7 = Component.GetComponent(lVar7,DAT_181d6ccc0)) == null))) ||
                       (uVar5 = String.Concat(uVar5,*(uint64 *)(lVar7 + 24)), lVar4 == null)) break;
                    lVar4.areaName = uVar5;
                  }
                }
                lVar4 = this.areaData;
                local_res8[0] = local_res8[0] + 1;
                if (lVar4 == null) break;
              }
            }
          }
        }
    }

    // Token : 0x6000D5F
    // RVA   : 0xCE80A0   Offset: 0xCE68A0   Length: 0x10B
    public void DefenceUpgradeButtonClicked(GameObject buttonClicked)
    {
        long lVar1;
        uint uVar2;
        long lVar3;
        ulong uVar4;
        lVar1 = this.areaData;
        if (buttonClicked != null) {
          lVar3 = GameObject.get_transform(buttonClicked,0);
          if (lVar3 != null) {
            lVar3 = FUN_180da0f00(lVar3,0);
            if (lVar3 != null) {
              uVar4 = Object.get_name(lVar3,0);
              uVar2 = Int32.Parse(uVar4,0);
              if (lVar1 != null) {
                AreaData.StartUpgradeDefenceLv(lVar1,uVar2,0);
                BranchUIController.RefreshBranchUI(this,0);
                plVar5 = (int64 *)Resources.Load("Sound/SoundEffect/WoodWork",0);
                plVar6 = (int64 *)0;
                if ((plVar5 != (int64 *)0) && (*plVar5 == DAT_181d8a228)) {
                  plVar6 = plVar5;
                }
                NGUITools.PlaySound(plVar6,0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x6000D60
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
