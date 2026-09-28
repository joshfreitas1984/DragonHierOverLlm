// ============================================================
// Type  : ForceGroupFightMatchChooseController
// Token : 0x200028B
// ============================================================

public class ForceGroupFightMatchChooseController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001474
    public GameObject forceGroupFightMatchChooseUIPanel;

    // Token: 0x4001475
    public List<int> forceGroupMatchHeroListChoosen;

    // Token: 0x4001476
    private static ForceGroupFightMatchChooseController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60014B1
    // RVA   : 0xB3D6D0   Offset: 0xB3CAD0   Length: 0x36
    public static ForceGroupFightMatchChooseController get_Instance()
    {
        return **(uint64 **)(DAT_181dc7e10 + 184);
    }

    // Token : 0x60014B2
    // RVA   : 0xB3C360   Offset: 0xB3B760   Length: 0x43
    private void Awake()
    {
        puVar1 = *(uint64 **)(DAT_181dc7e10 + 184);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x60014B3
    // RVA   : 0xB3CFF0   Offset: 0xB3C3F0   Length: 0x40A
    public void ShowForceGroupFightMatchChoosePanel()
    {
        var pStatics = *(int64*)(DAT_181d72cc8 + 184);
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
                lVar2 = *(int64 *)(*(int64 *)(DAT_181d91b88 + 184) + 24);
                if ((*pStatics != 0) &&
                   (lVar3 = *(int64 *)(*pStatics + 32)) != null) {
                  lVar3 = WorldData.Player(lVar3,0);
                  if (lVar3 != null) {
                    uVar4 = HeroData.GetForceLeader(lVar3,0);
                    if (lVar2 != null) {
                      uVar4 = PlotController.GetForceGroupMatchHeroIDList(lVar2,uVar4,0);
                      this.forceGroupMatchHeroListChoosen = uVar4;
                      if (this.forceGroupMatchHeroListChoosen != null) {
                        cVar1 = FUN_18182a3a0(this.forceGroupMatchHeroListChoosen,0,DAT_181d8f398);
                        if (!cVar1) {
                          if (this.forceGroupMatchHeroListChoosen == null) throw; // [null/range check failed]
                          FUN_181833d40(this.forceGroupMatchHeroListChoosen,4,0,DAT_181d8fb18);
                        }
        LAB_180b3d3e1:
                        ForceGroupFightMatchChooseController.RefreshUI(this,0);
                        return;
                      }
                    }
                  }
                }
              }
              else {
                lVar2 = il2cpp_internal(DAT_181d93cd0);
                FUN_18132faf0(lVar2,DAT_181d8f098);
                if ((*pStatics != 0) &&
                   (lVar3 = *(int64 *)(*pStatics + 32)) != null) {
                  lVar3 = WorldData.Player(lVar3,0);
                  if (lVar3 != null) {
                    lVar3 = HeroData.GetForceLeader(lVar3,0);
                    if ((lVar3 != null) && (lVar2 != null)) {
                      FUN_18182a0b0(lVar2,*(uint32 *)(lVar3 + 88),DAT_181d8f218);
                      FUN_18182a0b0(lVar2,0xffffffff,DAT_181d8f218);
                      FUN_18182a0b0(lVar2,0xffffffff,DAT_181d8f218);
                      FUN_18182a0b0(lVar2,0xffffffff,DAT_181d8f218);
                      FUN_18182a0b0(lVar2,0xffffffff,DAT_181d8f218);
                      this.forceGroupMatchHeroListChoosen = lVar2;
                      goto LAB_180b3d3e1;
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x60014B4
    // RVA   : 0x78D070   Offset: 0x78C470   Length: 0x20
    public void HideForceGroupFightMatchChoosePanel()
    {
        if (this.forceGroupFightMatchChooseUIPanel != null) {
          GameObject.SetActive(this.forceGroupFightMatchChooseUIPanel,0,0);
          return;
        }
    }

    // Token : 0x60014B5
    // RVA   : 0xB3C9C0   Offset: 0xB3BDC0   Length: 0x624
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
          iVar2 = FUN_1800d6760(this.forceGroupMatchHeroListChoosen,local_res8[0]);
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
            lVar4 = Component.GetComponent(lVar4,DAT_181d93760);
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
        LAB_180b3cc06:
              puVar7 = (uint64 *)Vector3.get_zero(local_38,0);
            }
            else {
              lVar6 = FUN_18046c0a0(0);
              if (((lVar6 == null) || (*(int64 *)(lVar6 + 32) == 0)) ||
                 (lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0)) == null) break;
              if (*(char *)(lVar6 + 180) == false) goto LAB_180b3cc06;
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
                (lVar4 = Component.GetComponent(lVar4,DAT_181d93760)) == null))) break;
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
            if ((lVar4 == null) || (lVar6 = GameObject.GetComponent(lVar4,DAT_181d71b50)) == null)
            break;
            *(uint8 *)(lVar6 + 88) = 1;
            lVar6 = GameObject.GetComponent(lVar4,DAT_181d71b50);
            lVar8 = FUN_18046c0a0(0);
            if (lVar8 == null) break;
            lVar8 = *(int64 *)(lVar8 + 32);
            if (((this.forceGroupMatchHeroListChoosen == null) ||
                (uVar3 = FUN_1800d6760(this.forceGroupMatchHeroListChoosen,local_res8[0]), lVar8 == null)) ||
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

    // Token : 0x60014B6
    // RVA   : 0xB3C540   Offset: 0xB3B940   Length: 0x47D
    public void HeroBackClicked(GameObject buttonClicked)
    {
        var pStatics = *(int64*)(DAT_181d72cc8 + 184);
        bool cVar1;
        long lVar2;
        long lVar3;
        long lVar4;
        ulong uVar5;
        ulong uVar6;
        int iVar7;
        lVar2 = il2cpp_internal(DAT_181d93350);
        FUN_18132faf0(lVar2,DAT_181d8b418);
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
          FUN_1800d6760(*(int64 *)(lVar4 + 112),iVar7,DAT_181d8fa18);
          if (lVar3 == null) throw; // [null/range check failed]
          cVar1 = FUN_18182a3a0(lVar3);
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
                FUN_18181e0a0(lVar2);
              }
            }
          }
          iVar7 = iVar7 + 1;
        }
        lVar3 = **(int64 **)(DAT_181db7518 + 184);
        uVar5 = Component.get_gameObject(this,0);
        if (buttonClicked != null) {
          lVar4 = GameObject.get_transform(buttonClicked,0);
          if (lVar4 != null) {
            lVar4 = FUN_180da9a20(lVar4,0);
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

    // Token : 0x60014B7
    // RVA   : 0xB3C460   Offset: 0xB3B860   Length: 0xDA
    public void GroupFightMatchHeroChoosen(string param)
    {
        var pStatics = *(int64*)(DAT_181db7518 + 184);
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
          lVar3 = GameObject.GetComponent(lVar3,DAT_181d71b50);
          if ((lVar3 != null) && ((*(int64 *)(lVar3 + 32) != 0 && (lVar1 != null)))) {
            FUN_181833d40(lVar1,uVar2,*(uint32 *)(*(int64 *)(lVar3 + 32) + 88),DAT_181d8fb18);
            ForceGroupFightMatchChooseController.RefreshUI(this,0);
            return;
          }
        }
    }

    // Token : 0x60014B8
    // RVA   : 0xB3C3B0   Offset: 0xB3B7B0   Length: 0xA6
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
            lVar4 = FUN_180da9a20(lVar4,0);
            if (lVar4 != null) {
              uVar2 = Object.get_name(lVar4,0);
              uVar3 = Int32.Parse(uVar2,0);
              if (lVar1 != null) {
                FUN_181833d40(lVar1,uVar3,0xffffffff,DAT_181d8fb18);
                ForceGroupFightMatchChooseController.RefreshUI(this,0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x60014B9
    // RVA   : 0xB3D400   Offset: 0xB3C800   Length: 0x1E9
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
                lVar1 = *(int64 *)(*(int64 *)(DAT_181d91b88 + 184) + 24);
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
              lVar1 = FUN_180778ae0(0);
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

    // Token : 0x60014BA
    // RVA   : 0xB3D5F0   Offset: 0xB3C9F0   Length: 0xDD
    public void SureStartForceGroupFight()
    {
        long lVar1;
        if (this.forceGroupFightMatchChooseUIPanel != null) {
          GameObject.SetActive(this.forceGroupFightMatchChooseUIPanel,0,0);
          lVar1 = *(int64 *)(*(int64 *)(DAT_181d91b88 + 184) + 24);
          if (lVar1 != null) {
            PlotController.RealStartForceGroupFightMatchPlot(lVar1,"true",0);
            return;
          }
        }
    }

    // Token : 0x60014BB
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
