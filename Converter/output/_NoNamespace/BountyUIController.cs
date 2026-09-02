// ============================================================
// Type  : BountyUIController
// Token : 0x200019D
// ============================================================

public class BountyUIController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000AE9
    public GameObject bountyUIPanel;

    // Token: 0x4000AEA
    public GameObject bountyGrid;

    // Token: 0x4000AEB
    public GameObject bountyIconPrefab;

    // Token: 0x4000AEC
    public AreaBuildingData targetBuildingData;

    // Token: 0x4000AED
    private GameObject newObj;

    // Token: 0x4000AEE
    private static BountyUIController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000D43
    // RVA   : 0xCE6670   Offset: 0xCE4E70   Length: 0x36
    public static BountyUIController get_Instance()
    {
        return **(uint64 **)(DAT_181d8def8 + 184);
    }

    // Token : 0x6000D44
    // RVA   : 0xCE5AC0   Offset: 0xCE42C0   Length: 0x43
    private void Awake()
    {
        puVar1 = *(uint64 **)(DAT_181d8def8 + 184);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x6000D45
    // RVA   : 0xCE64B0   Offset: 0xCE4CB0   Length: 0x6E
    public void HideBountyUI()
    {
        ulong uVar1;
        if (this.bountyUIPanel != null) {
          GameObject.SetActive(this.bountyUIPanel,0,0);
          uVar1 = this.bountyGrid;
          GlobalData.DeleteAllChild(uVar1,0);
          return;
        }
    }

    // Token : 0x6000D46
    // RVA   : 0xCE6520   Offset: 0xCE4D20   Length: 0x148
    public void ShowBountyUI(AreaBuildingData _targetBuildingData, string _title)
    {
        long lVar1;
        ulong uVar2;
        if (this.bountyUIPanel != null) {
          GameObject.SetActive(this.bountyUIPanel,1,0);
          this.targetBuildingData = _targetBuildingData;
          if (this.bountyUIPanel != null) {
            lVar1 = GameObject.get_transform(this.bountyUIPanel,0);
            if (lVar1 != null) {
              lVar1 = Transform.Find(lVar1,"Title",0);
              if (lVar1 != null) {
                uVar2 = Component.GetComponent(lVar1,DAT_181d6d8c0);
                LTLocalization.SetText(uVar2,_title,0);
                plVar3 = (int64 *)Resources.Load("Sound/SoundEffect/OpenBook",0);
                plVar4 = (int64 *)0;
                if ((plVar3 != (int64 *)0) && (*plVar3 == DAT_181d8a228)) {
                  plVar4 = plVar3;
                }
                NGUITools.PlaySound(plVar4,0);
                BountyUIController.FreshBounty(this,0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x6000D47
    // RVA   : 0xCE6060   Offset: 0xCE4860   Length: 0x440
    public void FreshBounty()
    {
        ulong uVar1;
        ulong uVar2;
        long lVar3;
        long lVar4;
        int iVar5;
        uVar2 = this.bountyGrid;
        GlobalData.DeleteAllChild(uVar2,0);
        lVar3 = this.targetBuildingData;
        iVar5 = 0;
        if (lVar3 != null) {
          while (lVar3.missionDatas != null) {
            if (*(int *)(lVar3.missionDatas + 24) <= iVar5) {
              if ((((this.bountyUIPanel == null) ||
                   (lVar3 = GameObject.get_transform(this.bountyUIPanel,0)) == null) ||
                  (lVar3 = Transform.Find(lVar3,"Grid",0)) == null) ||
                 (lVar3 = Component.GetComponent(lVar3,DAT_181d6e0c0)) == null) break;
              UIGrid.set_repositionNow(lVar3,1,0);
              BountyUIController.FreshBountyNum(this,0);
              if (this.targetBuildingData == null) break;
              if (this.targetBuildingData.buildingID == null) {
                lVar3 = FUN_18046c0a0(0);
                if (((lVar3 == null) || (lVar3.destroyTimeLeft == null)) ||
                   (lVar3 = WorldData.Player(lVar3.destroyTimeLeft,0)) == null) break;
                if (-1 < *(int *)(lVar3 + 0x380)) {
                  lVar3 = FUN_18046c0a0(0);
                  if (((lVar3 == null) || (lVar3.destroyTimeLeft == null)) ||
                     (lVar3 = WorldData.Player(lVar3.destroyTimeLeft,0)) == null) break;
                  iVar5 = *(int *)(lVar3 + 0x380);
                  if ((this.targetBuildingData == null) ||
                     (lVar3 = AreaBuildingData.GetArea(this.targetBuildingData,0)) == null)
                  break;
                  if (iVar5 == *(int *)(lVar3 + 112)) {
                    if (((this.bountyUIPanel != null) &&
                        (lVar3 = GameObject.get_transform(this.bountyUIPanel,0)) != null)
                       && ((lVar3 = Transform.Find(lVar3,"FreshButton",0), lVar3 != null &&
                           (lVar3 = Component.get_gameObject(lVar3,0)) != null))) {
                      GameObject.SetActive(lVar3,1,0);
                      if (((this.bountyUIPanel != null) &&
                          (lVar3 = GameObject.get_transform(this.bountyUIPanel,0)) != null
                          ) && (lVar3 = Transform.Find(lVar3,"FreshButton",0)) != null) {
                        lVar3 = Component.GetComponent(lVar3,DAT_181d6af40);
                        lVar4 = FUN_18046c0a0(0);
                        if (((lVar4 != null) && (*(int64 *)(lVar4 + 32) != 0)) && (lVar3 != null)) {
                          Selectable.set_interactable
                                    (lVar3,*(int *)(*(int64 *)(lVar4 + 32) + 0x150) < 1,0);
                          return;
                        }
                      }
                    }
                    break;
                  }
                }
              }
              if ((((this.bountyUIPanel != null) &&
                   (lVar3 = GameObject.get_transform(this.bountyUIPanel,0)) != null) &&
                  (lVar3 = Transform.Find(lVar3,"FreshButton",0)) != null) &&
                 (lVar3 = Component.get_gameObject(lVar3,0)) != null) {
                GameObject.SetActive(lVar3,0,0);
                return;
              }
              break;
            }
            uVar2 = this.bountyGrid;
            uVar1 = this.bountyIconPrefab;
            uVar2 = GlobalData.AddChild(uVar2,uVar1,0);
            this.newObj = uVar2;
            if (this.newObj == null) break;
            lVar3 = GameObject.GetComponent(this.newObj,DAT_181d9ea20);
            if (((this.targetBuildingData == null) ||
                (lVar4 = this.targetBuildingData.missionDatas) == null) ||
               (uVar2 = FUN_180002f80(lVar4,iVar5), lVar3 == null)) break;
            lVar3.buildTimeLeft = uVar2;
            lVar3 = this.targetBuildingData;
            iVar5 = iVar5 + 1;
            if (lVar3 == null) break;
          }
        }
    }

    // Token : 0x6000D48
    // RVA   : 0xCE5CB0   Offset: 0xCE44B0   Length: 0x3AE
    public void FreshBountyNum()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        int iVar1;
        int iVar2;
        long lVar3;
        ulong uVar4;
        ulong uVar5;
        ulong uVar6;
        uint[] local_res8 = new uint[2];
        uint local_18;
        uint uStack_14;
        uint uStack_10;
        uint32 uStack_c;
        if (this.bountyUIPanel != null) {
          lVar3 = GameObject.get_transform(this.bountyUIPanel,0);
          if (lVar3 != null) {
            lVar3 = Transform.Find(lVar3,"BountyNum",0);
            if (lVar3 != null) {
              uVar4 = Component.GetComponent(lVar3,DAT_181d6d8c0);
              if ((*pStatics != 0) &&
                 (lVar3 = *(int64 *)(*pStatics + 32)) != null) {
                lVar3 = WorldData.Player(lVar3,0);
                if (lVar3 != null) {
                  local_res8[0] = HeroData.GetBountyMissionNum(lVar3,0);
                  uVar5 = Int32.ToString(local_res8,0);
                  if ((*pStatics != 0) &&
                     (lVar3 = *(int64 *)(*pStatics + 32)) != null) {
                    lVar3 = WorldData.Player(lVar3,0);
                    if (lVar3 != null) {
                      local_res8[0] = HeroData.GetMaxBountyMissionNum(lVar3,0);
                      uVar6 = Int32.ToString(local_res8,0);
                      uVar5 = String.Concat("已领委托 ",uVar5,"/",uVar6,0);
                      LTLocalization.SetText(uVar4,uVar5,0);
                      if (this.bountyUIPanel != null) {
                        lVar3 = GameObject.get_transform(this.bountyUIPanel,0);
                        if (lVar3 != null) {
                          lVar3 = Transform.Find(lVar3,"BountyNum",0);
                          if (lVar3 != null) {
                            plVar7 = (int64 *)Component.GetComponent(lVar3,DAT_181d6d8c0);
                            if ((*pStatics != 0) &&
                               (lVar3 = *(int64 *)(*pStatics + 32),
                               lVar3 != null)) {
                              lVar3 = WorldData.Player(lVar3,0);
                              if (lVar3 != null) {
                                iVar1 = HeroData.GetBountyMissionNum(lVar3,0);
                                if ((*pStatics != 0) &&
                                   (lVar3 = *(int64 *)(*pStatics + 32),
                                   lVar3 != null)) {
                                  lVar3 = WorldData.Player(lVar3,0);
                                  if (lVar3 != null) {
                                    iVar2 = HeroData.GetMaxBountyMissionNum(lVar3,0);
                                    if (iVar1 < iVar2) {
                                      puVar8 = (uint32 *)Color.get_black(&local_18,0);
                                    }
                                    else {
                                      puVar8 = (uint32 *)Color.get_red();
                                    }
                                    local_18 = *puVar8;
                                    uStack_14 = puVar8[1];
                                    uStack_10 = puVar8[2];
                                    uStack_c = puVar8[3];
                                    if (plVar7 != (int64 *)0) {
                                      (**(code **)(*plVar7 + 0x2a8))
                                                (plVar7,&local_18,*(uint64 *)(*plVar7 + 0x2b0));
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

    // Token : 0x6000D49
    // RVA   : 0xCE5B10   Offset: 0xCE4310   Length: 0x198
    public void FreshBountyButtonClicked()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        long lVar2;
        if (*pStatics != 0) {
          GameController.ManageBuildingBounty
                    (*pStatics,this.targetBuildingData,1,0);
          if ((*pStatics != 0) &&
             (lVar2 = *(int64 *)(*pStatics + 32)) != null) {
            piVar1 = (int *)(lVar2 + 0x150);
            *piVar1 = *piVar1 + 1;
            BountyUIController.FreshBounty(this,0);
            plVar3 = (int64 *)Resources.Load("Sound/SoundEffect/OpenBook",0);
            plVar4 = (int64 *)0;
            if ((plVar3 != (int64 *)0) && (*plVar3 == DAT_181d8a228)) {
              plVar4 = plVar3;
            }
            NGUITools.PlaySound(plVar4,0);
            return;
          }
        }
    }

    // Token : 0x6000D4A
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
