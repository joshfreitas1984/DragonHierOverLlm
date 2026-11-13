// ============================================================
// Type  : ForceGroupFightMatchChooseController
// Token : 0x2000293
// ============================================================

public class ForceGroupFightMatchChooseController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40014B7
    public GameObject forceGroupFightMatchChooseUIPanel;

    // Token: 0x40014B8
    public List<int> forceGroupMatchHeroListChoosen;

    // Token: 0x40014B9
    private static ForceGroupFightMatchChooseController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600151D
    // RVA   : 0x8FF770   Offset: 0x8FE570   Length: 0x36
    public static ForceGroupFightMatchChooseController get_Instance()
    {
        return **(uint64 **)(DAT_181e50b38 + 184);
    }

    // Token : 0x600151E
    // RVA   : 0x8FE400   Offset: 0x8FD200   Length: 0x43
    private void Awake()
    {
        puVar1 = *(uint64 **)(DAT_181e50b38 + 184);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x600151F
    // RVA   : 0x8FF090   Offset: 0x8FDE90   Length: 0x40A
    public void ShowForceGroupFightMatchChoosePanel()
    {
        bool cVar1;
        long lVar2;
        long lVar3;
        ulong uVar4;
        if (this.forceGroupFightMatchChooseUIPanel != null) {
          GameObject.SetActive(this.forceGroupFightMatchChooseUIPanel,1,0);
          if ((GameController._instance != null) &&
             (lVar2 = GameController._instance.worldData) != null) {
            lVar2 = WorldData.Player(lVar2,0);
            if (lVar2 != null) {
              if (!lVar2.hour) {
                lVar2 = *(int64 *)(*(int64 *)(DAT_181e71f68 + 184) + 24);
                if ((GameController._instance != null) &&
                   (lVar3 = GameController._instance.worldData) != null) {
                  lVar3 = WorldData.Player(lVar3,0);
                  if (lVar3 != null) {
                    uVar4 = HeroData.GetForceLeader(lVar3,0);
                    if (lVar2 != null) {
                      uVar4 = PlotController.GetForceGroupMatchHeroIDList(lVar2,uVar4,0);
                      this.forceGroupMatchHeroListChoosen = uVar4;
                      if (this.forceGroupMatchHeroListChoosen != null) {
                        cVar1 = FUN_18176a2d0(this.forceGroupMatchHeroListChoosen,0,DAT_181e71570);
                        if (!cVar1) {
                          if (this.forceGroupMatchHeroListChoosen == null) throw; // [null/range check failed]
                          FUN_181774110(this.forceGroupMatchHeroListChoosen,4,0,DAT_181e71cf0);
                        }
        LAB_1808ff481:
                        ForceGroupFightMatchChooseController.RefreshUI(this,0);
                        return;
                      }
                    }
                  }
                }
              }
              else {
                lVar2 = il2cpp_internal(DAT_181e73cb8);
                FUN_1810f3480(lVar2,DAT_181e71270);
                if ((GameController._instance != null) &&
                   (lVar3 = GameController._instance.worldData) != null) {
                  lVar3 = WorldData.Player(lVar3,0);
                  if (lVar3 != null) {
                    lVar3 = HeroData.GetForceLeader(lVar3,0);
                    if ((lVar3 != null) && (lVar2 != null)) {
                      FUN_181769fe0(lVar2,lVar3.TempHeros,DAT_181e713f0);
                      FUN_181769fe0(lVar2,0xffffffff,DAT_181e713f0);
                      FUN_181769fe0(lVar2,0xffffffff,DAT_181e713f0);
                      FUN_181769fe0(lVar2,0xffffffff,DAT_181e713f0);
                      FUN_181769fe0(lVar2,0xffffffff,DAT_181e713f0);
                      this.forceGroupMatchHeroListChoosen = lVar2;
                      goto LAB_1808ff481;
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6001520
    // RVA   : 0x52B140   Offset: 0x529F40   Length: 0x20
    public void HideForceGroupFightMatchChoosePanel()
    {
        if (this.forceGroupFightMatchChooseUIPanel != null) {
          GameObject.SetActive(this.forceGroupFightMatchChooseUIPanel,0,0);
          return;
        }
    }

    // Token : 0x6001521
    // RVA   : 0x8FEA60   Offset: 0x8FD860   Length: 0x624
    public void RefreshUI()
    {
        ulong uVar1;
        int iVar2;
        uint uVar3;
        long lVar4;
        ulong uVar5;
        long lVar6;
        long lVar8;
        int[] local_res8 = new int[2];
        ulong local_68;
        uint local_60;
        ulong local_58;
        uint local_50;
        byte[] local_48 = new byte[16];
        byte[] local_38 = new byte[16];
        byte[] local_28 = new byte[16];
        lVar4 = this.forceGroupMatchHeroListChoosen;
        local_res8[0] = 0;
        while (lVar4 != null) {
          if (lVar4.Count <= local_res8[0]) {
            return;
          }
          if (this.forceGroupFightMatchChooseUIPanel == null) break;
          lVar4 = GameObject.get_transform(this.forceGroupFightMatchChooseUIPanel,0);
          uVar5 = Int32.ToString(local_res8,0);
          if (((lVar4 == null) || (lVar4 = Transform.Find(lVar4,uVar5,0)) == null) ||
             (lVar4 = Transform.Find(lVar4,"HeroIcon",0)) == null) break;
          uVar5 = Component.get_gameObject(lVar4,0);
          GlobalData.DeleteAllChild(uVar5,0);
          if (this.forceGroupMatchHeroListChoosen == null) break;
          iVar2 = FUN_180002480(this.forceGroupMatchHeroListChoosen,local_res8[0]);
          lVar4 = this.forceGroupFightMatchChooseUIPanel;
          if (iVar2 == -1) {
            if (lVar4 == null) break;
            lVar4 = GameObject.get_transform(lVar4,0);
            uVar5 = Int32.ToString(local_res8,0);
            if ((lVar4 == null) || (lVar4 = Transform.Find(lVar4,uVar5,0)) == null) break;
            lVar4 = Transform.Find(lVar4,"ClearButton",0);
            puVar7 = (uint64 *)Vector3.get_zero(local_28,0);
            if (lVar4 == null) break;
            local_50 = *(uint32 *)(puVar7 + 1);
            local_58 = *puVar7;
            Transform.set_localScale(lVar4,&local_58);
            if (this.forceGroupFightMatchChooseUIPanel == null) break;
            lVar4 = GameObject.get_transform(this.forceGroupFightMatchChooseUIPanel,0);
            uVar5 = Int32.ToString(local_res8,0);
            if (((lVar4 == null) || (lVar4 = Transform.Find(lVar4,uVar5,0)) == null) ||
               (lVar4 = Transform.Find(lVar4,"HeroBack",0)) == null) break;
            lVar4 = Component.GetComponent(lVar4,DAT_181e76ab8);
            lVar6 = FUN_1802106e0(0);
            if (((lVar6 == null) || (*(int64 *)(lVar6 + 32) == 0)) ||
               ((lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0), lVar6 == null || (lVar4 == null))))
            break;
            Selectable.set_interactable(lVar4);
          }
          else {
            if (lVar4 == null) break;
            lVar4 = GameObject.get_transform(lVar4,0);
            uVar5 = Int32.ToString(local_res8,0);
            if ((lVar4 == null) || (lVar4 = Transform.Find(lVar4,uVar5,0)) == null) break;
            lVar4 = Transform.Find(lVar4,"ClearButton",0);
            if (local_res8[0] == 0) {
        LAB_1808feca6:
              puVar7 = (uint64 *)Vector3.get_zero(local_38,0);
            }
            else {
              lVar6 = FUN_1802106e0(0);
              if (((lVar6 == null) || (*(int64 *)(lVar6 + 32) == 0)) ||
                 (lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0)) == null) break;
              if (*(char *)(lVar6 + 180) == false) goto LAB_1808feca6;
              puVar7 = (uint64 *)Vector3.get_one(local_48,0);
            }
            if (lVar4 == null) break;
            local_68 = *puVar7;
            local_60 = *(uint32 *)(puVar7 + 1);
            Transform.set_localScale(lVar4,&local_68,0);
            if (this.forceGroupFightMatchChooseUIPanel == null) break;
            lVar4 = GameObject.get_transform(this.forceGroupFightMatchChooseUIPanel,0);
            uVar5 = Int32.ToString(local_res8,0);
            if (((lVar4 == null) || (lVar4 = Transform.Find(lVar4,uVar5,0)) == null) ||
               ((lVar4 = Transform.Find(lVar4,"HeroBack",0), lVar4 == null ||
                (lVar4 = Component.GetComponent(lVar4,DAT_181e76ab8)) == null))) break;
            Selectable.set_interactable(lVar4,0,0);
            if (this.forceGroupFightMatchChooseUIPanel == null) break;
            lVar4 = GameObject.get_transform(this.forceGroupFightMatchChooseUIPanel,0);
            uVar5 = Int32.ToString(local_res8,0);
            if (((lVar4 == null) || (lVar4 = Transform.Find(lVar4,uVar5,0)) == null) ||
               (lVar4 = Transform.Find(lVar4,"HeroIcon",0)) == null) break;
            uVar5 = Component.get_gameObject(lVar4,0);
            lVar4 = FUN_1802107e0(0);
            if (lVar4 == null) break;
            uVar1 = *(uint64 *)(lVar4 + 144);
            lVar4 = GlobalData.AddChild(uVar5,uVar1,0);
            if ((lVar4 == null) || (lVar6 = GameObject.GetComponent(lVar4,DAT_181e54c18)) == null)
            break;
            *(uint8 *)(lVar6 + 88) = 1;
            lVar6 = GameObject.GetComponent(lVar4,DAT_181e54c18);
            lVar8 = FUN_1802106e0(0);
            if (lVar8 == null) break;
            lVar8 = *(int64 *)(lVar8 + 32);
            if (((this.forceGroupMatchHeroListChoosen == null) ||
                (uVar3 = FUN_180002480(this.forceGroupMatchHeroListChoosen,local_res8[0]), lVar8 == null)) ||
               (uVar5 = WorldData.GetHero(lVar8,uVar3), lVar6 == null)) break;
            *(uint64 *)(lVar6 + 32) = uVar5;
            lVar4 = GameObject.GetComponent(lVar4);
            if (lVar4 == null) break;
            lVar4.Count = 0;
          }
          local_res8[0] = local_res8[0] + 1;
          lVar4 = this.forceGroupMatchHeroListChoosen;
        }
    }

    // Token : 0x6001522
    // RVA   : 0x8FE5E0   Offset: 0x8FD3E0   Length: 0x47D
    public void HeroBackClicked(GameObject buttonClicked)
    {
        bool cVar1;
        long lVar2;
        long lVar3;
        long lVar4;
        ulong uVar5;
        ulong uVar6;
        int iVar7;
        lVar2 = il2cpp_internal(DAT_181e73338);
        FUN_1810f3480(lVar2,DAT_181e6d6f0);
        iVar7 = 0;
        while( true ) {
          if ((GameController._instance == null) ||
             (lVar3 = GameController._instance.worldData) == null)
          throw; // [null/range check failed]
          lVar3 = WorldData.Player(lVar3,0);
          if (lVar3 == null) throw; // [null/range check failed]
          lVar3 = HeroData.GetForce(lVar3,0,0);
          if ((lVar3 == null) || (lVar3.lastRandomWorldEventDay == null)) throw; // [null/range check failed]
          if (*(int *)(lVar3.lastRandomWorldEventDay + 24) <= iVar7) break;
          lVar3 = this.forceGroupMatchHeroListChoosen;
          lVar4 = FUN_1802106e0(0);
          if ((lVar4 == null) || (*(int64 *)(lVar4 + 32) == 0)) throw; // [null/range check failed]
          lVar4 = WorldData.Player(*(int64 *)(lVar4 + 32),0);
          if (lVar4 == null) throw; // [null/range check failed]
          lVar4 = HeroData.GetForce(lVar4,0,0);
          if ((lVar4 == null) || (*(int64 *)(lVar4 + 112) == 0)) throw; // [null/range check failed]
          FUN_180002480(*(int64 *)(lVar4 + 112),iVar7,DAT_181e71bf0);
          if (lVar3 == null) throw; // [null/range check failed]
          cVar1 = FUN_18176a2d0(lVar3);
          if (!cVar1) {
            lVar3 = FUN_1802106e0(0);
            if ((lVar3 == null) || (lVar3.villageAreaID == null)) throw; // [null/range check failed]
            lVar3 = WorldData.Player(lVar3.villageAreaID,0);
            if (lVar3 == null) throw; // [null/range check failed]
            lVar3 = HeroData.GetForce(lVar3,0,0);
            if (lVar3 == null) throw; // [null/range check failed]
            lVar3 = ForceData.GetOwnHero(lVar3);
            if (lVar3 == null) throw; // [null/range check failed]
            if (!lVar3.BigMapRandomEventDatas) {
              lVar3 = FUN_1802106e0(0);
              if ((lVar3 == null) || (lVar3.villageAreaID == null)) throw; // [null/range check failed]
              lVar3 = WorldData.Player(lVar3.villageAreaID,0);
              if (lVar3 == null) throw; // [null/range check failed]
              lVar3 = HeroData.GetForce(lVar3,0,0);
              if (lVar3 == null) throw; // [null/range check failed]
              lVar3 = ForceData.GetOwnHero(lVar3);
              if (lVar3 == null) throw; // [null/range check failed]
              if (*(char *)(lVar3 + 209) == false) {
                lVar3 = FUN_1802106e0(0);
                if ((lVar3 == null) || (lVar3.villageAreaID == null)) throw; // [null/range check failed]
                lVar3 = WorldData.Player(lVar3.villageAreaID,0);
                if (lVar3 == null) throw; // [null/range check failed]
                lVar3 = HeroData.GetForce(lVar3,0,0);
                if (lVar3 == null) throw; // [null/range check failed]
                ForceData.GetOwnHero(lVar3,iVar7,0);
                if (lVar2 == null) throw; // [null/range check failed]
                FUN_18175de30(lVar2);
              }
            }
          }
          iVar7 = iVar7 + 1;
        }
        lVar3 = **(int64 **)(DAT_181e977e8 + 184);
        uVar5 = Component.get_gameObject(this,0);
        if (buttonClicked != null) {
          lVar4 = GameObject.get_transform(buttonClicked,0);
          if (lVar4 != null) {
            lVar4 = FUN_180b05920(lVar4,0);
            if (lVar4 != null) {
              uVar6 = Object.get_name(lVar4,0);
              if (lVar3 != null) {
                ChooseController.ShowChoosePanel(lVar3,2,lVar2,uVar5,"GroupFightMatchHeroChoosen",uVar6,0,0,0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x6001523
    // RVA   : 0x8FE500   Offset: 0x8FD300   Length: 0xDA
    public void GroupFightMatchHeroChoosen(string param)
    {
        var pStatics = *(int64*)(DAT_181e977e8 + 184);
        void ForceGroupFightMatchChooseController.GroupFightMatchHeroChoosen
                     (int64 this,uint64 param)
        {
        int64 lVar1;
        uint32 uVar2;
        int64 lVar3;
        lVar1 = this.forceGroupMatchHeroListChoosen;
        uVar2 = Int32.Parse(param,0);
        if ((*pStatics != 0) &&
           (lVar3 = *(int64 *)(*pStatics + 72)) != null) {
          lVar3 = GameObject.GetComponent(lVar3,DAT_181e54c18);
          if ((lVar3 != null) && ((*(int64 *)(lVar3 + 32) != 0 && (lVar1 != null)))) {
            FUN_181774110(lVar1,uVar2,*(uint32 *)(*(int64 *)(lVar3 + 32) + 88),DAT_181e71cf0);
            ForceGroupFightMatchChooseController.RefreshUI(this,0);
            return;
          }
        }
    }

    // Token : 0x6001524
    // RVA   : 0x8FE450   Offset: 0x8FD250   Length: 0xA6
    public void ClearButtonClicked(GameObject buttonClicked)
    {
        long lVar1;
        ulong uVar2;
        uint uVar3;
        long lVar4;
        lVar1 = this.forceGroupMatchHeroListChoosen;
        if (buttonClicked != null) {
          lVar4 = GameObject.get_transform(buttonClicked,0);
          if (lVar4 != null) {
            lVar4 = FUN_180b05920(lVar4,0);
            if (lVar4 != null) {
              uVar2 = Object.get_name(lVar4,0);
              uVar3 = Int32.Parse(uVar2,0);
              if (lVar1 != null) {
                FUN_181774110(lVar1,uVar3,0xffffffff,DAT_181e71cf0);
                ForceGroupFightMatchChooseController.RefreshUI(this,0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x6001525
    // RVA   : 0x8FF4A0   Offset: 0x8FE2A0   Length: 0x1E9
    public void SureButtonClicked()
    {
        long lVar1;
        long lVar2;
        uint uVar3;
        lVar1 = this.forceGroupMatchHeroListChoosen;
        uVar3 = 0;
        if (lVar1 != null) {
          lVar2 = 32;
          do {
            if (lVar1.Count <= (int)uVar3) {
              if (this.forceGroupFightMatchChooseUIPanel != null) {
                GameObject.SetActive(this.forceGroupFightMatchChooseUIPanel,0,0);
                lVar1 = *(int64 *)(*(int64 *)(DAT_181e71f68 + 184) + 24);
                if (lVar1 != null) {
                  PlotController.RealStartForceGroupFightMatchPlot(lVar1,"true",0);
                  return;
                }
              }
              break;
            }
            if (lVar1 == null) break;
            if (lVar1.Count <= uVar3) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            if (*(int *)(lVar2 + lVar1._items) == -1) {
              lVar1 = FUN_180518720(0);
              if (lVar1 != null) {
                SureMenu.CallSureMenu(lVar1,"参赛人数不足5人，确认出战吗？","SureStartForceGroupFight",0,"ForceGroupFightMatchChooseController",0);
                return;
              }
              break;
            }
            lVar1 = this.forceGroupMatchHeroListChoosen;
            uVar3 = uVar3 + 1;
            lVar2 = lVar2 + 4;
          } while (lVar1 != null);
        }
    }

    // Token : 0x6001526
    // RVA   : 0x8FF690   Offset: 0x8FE490   Length: 0xDD
    public void SureStartForceGroupFight()
    {
        long lVar1;
        if (this.forceGroupFightMatchChooseUIPanel != null) {
          GameObject.SetActive(this.forceGroupFightMatchChooseUIPanel,0,0);
          lVar1 = *(int64 *)(*(int64 *)(DAT_181e71f68 + 184) + 24);
          if (lVar1 != null) {
            PlotController.RealStartForceGroupFightMatchPlot(lVar1,"true",0);
            return;
          }
        }
    }

    // Token : 0x6001527
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

}
