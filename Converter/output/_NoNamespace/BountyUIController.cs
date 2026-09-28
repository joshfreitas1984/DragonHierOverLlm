// ============================================================
// Type  : BountyUIController
// Token : 0x20001A3
// ============================================================

public class BountyUIController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000B75
    public GameObject bountyUIPanel;

    // Token: 0x4000B76
    public GameObject bountyGrid;

    // Token: 0x4000B77
    public GameObject bountyIconPrefab;

    // Token: 0x4000B78
    public AreaBuildingData targetBuildingData;

    // Token: 0x4000B79
    private GameObject newObj;

    // Token: 0x4000B7A
    private static BountyUIController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000D77
    // RVA   : 0xC8C850   Offset: 0xC8BC50   Length: 0x36
    public static BountyUIController get_Instance()
    {
        return **(uint64 **)(DAT_181db30a0 + 184);
    }

    // Token : 0x6000D78
    // RVA   : 0xC8BC40   Offset: 0xC8B040   Length: 0x43
    private void Awake()
    {
        puVar1 = *(uint64 **)(DAT_181db30a0 + 184);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x6000D79
    // RVA   : 0xC8C660   Offset: 0xC8BA60   Length: 0x6E
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

    // Token : 0x6000D7A
    // RVA   : 0xC8C6D0   Offset: 0xC8BAD0   Length: 0x175
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
                uVar2 = Component.GetComponent(lVar1,DAT_181d96160);
                LTLocalization.SetText(uVar2,_title,0);
                plVar3 = (int64 *)Resources.Load("Sound/SoundEffect/OpenBook",0);
                plVar4 = (int64 *)0;
                if ((plVar3 != (int64 *)0) && (*plVar3 == DAT_181daf348)) {
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

    // Token : 0x6000D7B
    // RVA   : 0xC8C210   Offset: 0xC8B610   Length: 0x445
    public void FreshBounty()
    {
        ulong uVar1;
        bool cVar2;
        ulong uVar3;
        long lVar4;
        long lVar5;
        int iVar6;
        uVar3 = this.bountyGrid;
        GlobalData.DeleteAllChild(uVar3,0);
        lVar4 = this.targetBuildingData;
        iVar6 = 0;
        if (lVar4 != null) {
          while (lVar4.missionDatas != null) {
            if (*(int *)(lVar4.missionDatas + 24) <= iVar6) {
              if ((((this.bountyUIPanel == null) ||
                   (lVar4 = GameObject.get_transform(this.bountyUIPanel,0)) == null) ||
                  (lVar4 = Transform.Find(lVar4,"Grid",0)) == null) ||
                 (lVar4 = Component.GetComponent(lVar4,DAT_181d96960)) == null) break;
              UIGrid.set_repositionNow(lVar4,1,0);
              BountyUIController.FreshBountyNum(this,0);
              if (this.targetBuildingData == null) break;
              if (this.targetBuildingData.buildingID == null) {
                lVar4 = FUN_18046c0a0(0);
                if (((lVar4 == null) || (lVar4.destroyTimeLeft == null)) ||
                   (lVar4 = WorldData.Player(lVar4.destroyTimeLeft,0)) == null) break;
                cVar2 = HeroData.HaveServantForce(lVar4,0);
                if (cVar2) {
                  lVar4 = FUN_18046c0a0(0);
                  if (((lVar4 == null) || (lVar4.destroyTimeLeft == null)) ||
                     (lVar4 = WorldData.Player(lVar4.destroyTimeLeft,0)) == null) break;
                  iVar6 = *(int *)(lVar4 + 0x380);
                  if ((this.targetBuildingData == null) ||
                     (lVar4 = AreaBuildingData.GetArea(this.targetBuildingData,0)) == null)
                  break;
                  if (iVar6 == *(int *)(lVar4 + 112)) {
                    if (((this.bountyUIPanel != null) &&
                        (lVar4 = GameObject.get_transform(this.bountyUIPanel,0)) != null)
                       && ((lVar4 = Transform.Find(lVar4,"FreshButton",0), lVar4 != null &&
                           (lVar4 = Component.get_gameObject(lVar4,0)) != null))) {
                      GameObject.SetActive(lVar4,1,0);
                      if (((this.bountyUIPanel != null) &&
                          (lVar4 = GameObject.get_transform(this.bountyUIPanel,0)) != null
                          ) && (lVar4 = Transform.Find(lVar4,"FreshButton",0)) != null) {
                        lVar4 = Component.GetComponent(lVar4,DAT_181d93760);
                        lVar5 = FUN_18046c0a0(0);
                        if (((lVar5 != null) && (*(int64 *)(lVar5 + 32) != 0)) && (lVar4 != null)) {
                          Selectable.set_interactable
                                    (lVar4,*(int *)(*(int64 *)(lVar5 + 32) + 0x150) < 1,0);
                          return;
                        }
                      }
                    }
                    break;
                  }
                }
              }
              if ((((this.bountyUIPanel != null) &&
                   (lVar4 = GameObject.get_transform(this.bountyUIPanel,0)) != null) &&
                  (lVar4 = Transform.Find(lVar4,"FreshButton",0)) != null) &&
                 (lVar4 = Component.get_gameObject(lVar4,0)) != null) {
                GameObject.SetActive(lVar4,0,0);
                return;
              }
              break;
            }
            uVar3 = this.bountyGrid;
            uVar1 = this.bountyIconPrefab;
            uVar3 = GlobalData.AddChild(uVar3,uVar1,0);
            this.newObj = uVar3;
            if (this.newObj == null) break;
            lVar4 = GameObject.GetComponent(this.newObj,DAT_181dc77c0);
            if (((this.targetBuildingData == null) ||
                (lVar5 = this.targetBuildingData.missionDatas) == null) ||
               (uVar3 = FUN_180002f80(lVar5,iVar6), lVar4 == null)) break;
            lVar4.buildTimeLeft = uVar3;
            lVar4 = this.targetBuildingData;
            iVar6 = iVar6 + 1;
            if (lVar4 == null) break;
          }
        }
    }

    // Token : 0x6000D7C
    // RVA   : 0xC8BE30   Offset: 0xC8B230   Length: 0x3DB
    public void FreshBountyNum()
    {
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
              uVar4 = Component.GetComponent(lVar3,DAT_181d96160);
              if ((GameController._instance != null) &&
                 (lVar3 = GameController._instance.worldData) != null) {
                lVar3 = WorldData.Player(lVar3,0);
                if (lVar3 != null) {
                  local_res8[0] = HeroData.GetBountyMissionNum(lVar3,0);
                  uVar5 = Int32.ToString(local_res8,0);
                  if ((GameController._instance != null) &&
                     (lVar3 = GameController._instance.worldData) != null) {
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
                            plVar7 = (int64 *)Component.GetComponent(lVar3,DAT_181d96160);
                            if ((GameController._instance != null) &&
                               (lVar3 = GameController._instance.worldData,
                               lVar3 != null)) {
                              lVar3 = WorldData.Player(lVar3,0);
                              if (lVar3 != null) {
                                iVar1 = HeroData.GetBountyMissionNum(lVar3,0);
                                if ((GameController._instance != null) &&
                                   (lVar3 = GameController._instance.worldData,
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

    // Token : 0x6000D7D
    // RVA   : 0xC8BC90   Offset: 0xC8B090   Length: 0x198
    public void FreshBountyButtonClicked()
    {
        long lVar2;
        if (GameController._instance != null) {
          GameController.ManageBuildingBounty
                    (GameController._instance,this.targetBuildingData,1,0);
          if ((GameController._instance != null) &&
             (lVar2 = GameController._instance.worldData) != null) {
            piVar1 = (int *)(lVar2 + 0x150);
            *piVar1 = *piVar1 + 1;
            BountyUIController.FreshBounty(this,0);
            plVar3 = (int64 *)Resources.Load("Sound/SoundEffect/OpenBook",0);
            plVar4 = (int64 *)0;
            if ((plVar3 != (int64 *)0) && (*plVar3 == DAT_181daf348)) {
              plVar4 = plVar3;
            }
            NGUITools.PlaySound(plVar4,0);
            return;
          }
        }
    }

    // Token : 0x6000D7E
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
