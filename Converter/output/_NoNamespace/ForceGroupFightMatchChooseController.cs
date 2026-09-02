// ============================================================
// Type  : ForceGroupFightMatchChooseController
// Token : 0x2000285
// ============================================================

public class ForceGroupFightMatchChooseController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40013C3
    public GameObject forceGroupFightMatchChooseUIPanel;

    // Token: 0x40013C4
    public List<int> forceGroupMatchHeroListChoosen;

    // Token: 0x40013C5
    private static ForceGroupFightMatchChooseController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600146D
    // RVA   : 0xBB4A50   Offset: 0xBB3250   Length: 0x36
    public static ForceGroupFightMatchChooseController get_Instance()
    {
        return **(uint64 **)(DAT_181da2aa0 + 184);
    }

    // Token : 0x600146E
    // RVA   : 0xBB36E0   Offset: 0xBB1EE0   Length: 0x43
    private void Awake()
    {
        puVar1 = *(uint64 **)(DAT_181da2aa0 + 184);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x600146F
    // RVA   : 0xBB4370   Offset: 0xBB2B70   Length: 0x409
    public void ShowForceGroupFightMatchChoosePanel()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        bool cVar1;
        long lVar2;
        long lVar3;
        ulong uVar4;
        if (this.forceGroupFightMatchChooseUIPanel != null) {
          GameObject.SetActive(this.forceGroupFightMatchChooseUIPanel,1,0);
          if ((*pStatics != 0) &&
             (lVar2 = *(int64 *)(*pStatics + 32)) != null) {
            lVar2 = WorldData.Player(lVar2,0);
            if (lVar2 != null) {
              if (*(char *)(lVar2 + 180) == false) {
                lVar2 = **(int64 **)(DAT_181d6c960 + 184);
                if ((*pStatics != 0) &&
                   (lVar3 = *(int64 *)(*pStatics + 32)) != null) {
                  lVar3 = WorldData.Player(lVar3,0);
                  if (lVar3 != null) {
                    uVar4 = HeroData.GetForceLeader(lVar3,0);
                    if (lVar2 != null) {
                      uVar4 = PlotController.GetForceGroupMatchHeroIDList(lVar2,uVar4,0);
                      this.forceGroupMatchHeroListChoosen = uVar4;
                      if (this.forceGroupMatchHeroListChoosen != null) {
                        cVar1 = FUN_181815240(this.forceGroupMatchHeroListChoosen,0,DAT_181d67bf8);
                        if (!cVar1) {
                          if (this.forceGroupMatchHeroListChoosen == null) throw; // [null/range check failed]
                          FUN_18181e970(this.forceGroupMatchHeroListChoosen,4,0,DAT_181d68370);
                        }
        LAB_180bb4760:
                        ForceGroupFightMatchChooseController.RefreshUI(this,0);
                        return;
                      }
                    }
                  }
                }
              }
              else {
                lVar2 = il2cpp_internal(DAT_181d6f030);
                FUN_180f58a90(lVar2,DAT_181d678f8);
                if ((*pStatics != 0) &&
                   (lVar3 = *(int64 *)(*pStatics + 32)) != null) {
                  lVar3 = WorldData.Player(lVar3,0);
                  if (lVar3 != null) {
                    lVar3 = HeroData.GetForceLeader(lVar3,0);
                    if ((lVar3 != null) && (lVar2 != null)) {
                      FUN_181814fa0(lVar2,*(uint32 *)(lVar3 + 88),DAT_181d67a78);
                      FUN_181814fa0(lVar2,0xffffffff,DAT_181d67a78);
                      FUN_181814fa0(lVar2,0xffffffff,DAT_181d67a78);
                      FUN_181814fa0(lVar2,0xffffffff,DAT_181d67a78);
                      FUN_181814fa0(lVar2,0xffffffff,DAT_181d67a78);
                      this.forceGroupMatchHeroListChoosen = lVar2;
                      goto LAB_180bb4760;
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6001470
    // RVA   : 0x790570   Offset: 0x78ED70   Length: 0x20
    public void HideForceGroupFightMatchChoosePanel()
    {
        if (this.forceGroupFightMatchChooseUIPanel != null) {
          GameObject.SetActive(this.forceGroupFightMatchChooseUIPanel,0,0);
          return;
        }
    }

    // Token : 0x6001471
    // RVA   : 0xBB3D40   Offset: 0xBB2540   Length: 0x624
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
          iVar2 = FUN_1800d6750(this.forceGroupMatchHeroListChoosen,local_res8[0]);
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
            lVar4 = Component.GetComponent(lVar4,DAT_181d6af40);
            lVar6 = FUN_18046c0a0(0);
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
        LAB_180bb3f86:
              puVar7 = (uint64 *)Vector3.get_zero(local_38,0);
            }
            else {
              lVar6 = FUN_18046c0a0(0);
              if (((lVar6 == null) || (*(int64 *)(lVar6 + 32) == 0)) ||
                 (lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0)) == null) break;
              if (*(char *)(lVar6 + 180) == false) goto LAB_180bb3f86;
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
                (lVar4 = Component.GetComponent(lVar4,DAT_181d6af40)) == null))) break;
            Selectable.set_interactable(lVar4,0,0);
            if (this.forceGroupFightMatchChooseUIPanel == null) break;
            lVar4 = GameObject.get_transform(this.forceGroupFightMatchChooseUIPanel,0);
            uVar5 = Int32.ToString(local_res8,0);
            if (((lVar4 == null) || (lVar4 = Transform.Find(lVar4,uVar5,0)) == null) ||
               (lVar4 = Transform.Find(lVar4,"HeroIcon",0)) == null) break;
            uVar5 = Component.get_gameObject(lVar4,0);
            lVar4 = FUN_18046c1a0(0);
            if (lVar4 == null) break;
            uVar1 = *(uint64 *)(lVar4 + 144);
            lVar4 = GlobalData.AddChild(uVar5,uVar1,0);
            if ((lVar4 == null) || (lVar6 = GameObject.GetComponent(lVar4,DAT_181d9fb20)) == null)
            break;
            *(uint8 *)(lVar6 + 88) = 1;
            lVar6 = GameObject.GetComponent(lVar4,DAT_181d9fb20);
            lVar8 = FUN_18046c0a0(0);
            if (lVar8 == null) break;
            lVar8 = *(int64 *)(lVar8 + 32);
            if (((this.forceGroupMatchHeroListChoosen == null) ||
                (uVar3 = FUN_1800d6750(this.forceGroupMatchHeroListChoosen,local_res8[0]), lVar8 == null)) ||
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

    // Token : 0x6001472
    // RVA   : 0xBB38C0   Offset: 0xBB20C0   Length: 0x47D
    public void HeroBackClicked(GameObject buttonClicked)
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        bool cVar1;
        long lVar2;
        long lVar3;
        long lVar4;
        ulong uVar5;
        ulong uVar6;
        int iVar7;
        lVar2 = il2cpp_internal(DAT_181d6e6b0);
        FUN_180f58a90(lVar2,DAT_181d63c78);
        iVar7 = 0;
        while( true ) {
          if ((*pStatics == 0) ||
             (lVar3 = *(int64 *)(*pStatics + 32)) == null)
          throw; // [null/range check failed]
          lVar3 = WorldData.Player(lVar3,0);
          if (lVar3 == null) throw; // [null/range check failed]
          lVar3 = HeroData.GetForce(lVar3,0,0);
          if ((lVar3 == null) || (*(int64 *)(lVar3 + 112) == 0)) throw; // [null/range check failed]
          if (*(int *)(*(int64 *)(lVar3 + 112) + 24) <= iVar7) break;
          lVar3 = this.forceGroupMatchHeroListChoosen;
          lVar4 = FUN_18046c0a0(0);
          if ((lVar4 == null) || (*(int64 *)(lVar4 + 32) == 0)) throw; // [null/range check failed]
          lVar4 = WorldData.Player(*(int64 *)(lVar4 + 32),0);
          if (lVar4 == null) throw; // [null/range check failed]
          lVar4 = HeroData.GetForce(lVar4,0,0);
          if ((lVar4 == null) || (*(int64 *)(lVar4 + 112) == 0)) throw; // [null/range check failed]
          FUN_1800d6750(*(int64 *)(lVar4 + 112),iVar7,DAT_181d68270);
          if (lVar3 == null) throw; // [null/range check failed]
          cVar1 = FUN_181815240(lVar3);
          if (!cVar1) {
            lVar3 = FUN_18046c0a0(0);
            if ((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) throw; // [null/range check failed]
            lVar3 = WorldData.Player(*(int64 *)(lVar3 + 32),0);
            if (lVar3 == null) throw; // [null/range check failed]
            lVar3 = HeroData.GetForce(lVar3,0,0);
            if (lVar3 == null) throw; // [null/range check failed]
            lVar3 = ForceData.GetOwnHero(lVar3);
            if (lVar3 == null) throw; // [null/range check failed]
            if (*(char *)(lVar3 + 96) == false) {
              lVar3 = FUN_18046c0a0(0);
              if ((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) throw; // [null/range check failed]
              lVar3 = WorldData.Player(*(int64 *)(lVar3 + 32),0);
              if (lVar3 == null) throw; // [null/range check failed]
              lVar3 = HeroData.GetForce(lVar3,0,0);
              if (lVar3 == null) throw; // [null/range check failed]
              lVar3 = ForceData.GetOwnHero(lVar3);
              if (lVar3 == null) throw; // [null/range check failed]
              if (*(char *)(lVar3 + 209) == false) {
                lVar3 = FUN_18046c0a0(0);
                if ((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) throw; // [null/range check failed]
                lVar3 = WorldData.Player(*(int64 *)(lVar3 + 32),0);
                if (lVar3 == null) throw; // [null/range check failed]
                lVar3 = HeroData.GetForce(lVar3,0,0);
                if (lVar3 == null) throw; // [null/range check failed]
                ForceData.GetOwnHero(lVar3,iVar7,0);
                if (lVar2 == null) throw; // [null/range check failed]
                FUN_181827900(lVar2);
              }
            }
          }
          iVar7 = iVar7 + 1;
        }
        lVar3 = **(int64 **)(DAT_181d92370 + 184);
        uVar5 = Component.get_gameObject(this,0);
        if (buttonClicked != null) {
          lVar4 = GameObject.get_transform(buttonClicked,0);
          if (lVar4 != null) {
            lVar4 = FUN_180da0f00(lVar4,0);
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

    // Token : 0x6001473
    // RVA   : 0xBB37E0   Offset: 0xBB1FE0   Length: 0xDA
    public void GroupFightMatchHeroChoosen(string param)
    {
        var pStatics = *(int64*)(DAT_181d92370 + 184);
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
          lVar3 = GameObject.GetComponent(lVar3,DAT_181d9fb20);
          if ((lVar3 != null) && ((*(int64 *)(lVar3 + 32) != 0 && (lVar1 != null)))) {
            FUN_18181e970(lVar1,uVar2,*(uint32 *)(*(int64 *)(lVar3 + 32) + 88),DAT_181d68370);
            ForceGroupFightMatchChooseController.RefreshUI(this,0);
            return;
          }
        }
    }

    // Token : 0x6001474
    // RVA   : 0xBB3730   Offset: 0xBB1F30   Length: 0xA6
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
            lVar4 = FUN_180da0f00(lVar4,0);
            if (lVar4 != null) {
              uVar2 = Object.get_name(lVar4,0);
              uVar3 = Int32.Parse(uVar2,0);
              if (lVar1 != null) {
                FUN_18181e970(lVar1,uVar3,0xffffffff,DAT_181d68370);
                ForceGroupFightMatchChooseController.RefreshUI(this,0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x6001475
    // RVA   : 0xBB4780   Offset: 0xBB2F80   Length: 0x1E8
    public void SureButtonClicked()
    {
        var pStatics = *(int64*)(DAT_181d6c960 + 184);
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
                if (*pStatics != 0) {
                  PlotController.RealStartForceGroupFightMatchPlot
                            (*pStatics,"true",0);
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
              lVar1 = FUN_18077c2c0(0);
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

    // Token : 0x6001476
    // RVA   : 0xBB4970   Offset: 0xBB3170   Length: 0xDC
    public void SureStartForceGroupFight()
    {
        var pStatics = *(int64*)(DAT_181d6c960 + 184);
        if (this.forceGroupFightMatchChooseUIPanel != null) {
          GameObject.SetActive(this.forceGroupFightMatchChooseUIPanel,0,0);
          if (*pStatics != 0) {
            PlotController.RealStartForceGroupFightMatchPlot
                      (*pStatics,"true",0);
            return;
          }
        }
    }

    // Token : 0x6001477
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
