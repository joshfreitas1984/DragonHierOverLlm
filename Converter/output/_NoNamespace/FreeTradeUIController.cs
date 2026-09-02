// ============================================================
// Type  : FreeTradeUIController
// Token : 0x200028D
// ============================================================

public class FreeTradeUIController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40013F0
    public FreeTradeUIType freeTradeUIType;

    // Token: 0x40013F1
    private List<float> resourceNum;

    // Token: 0x40013F2
    private List<float> resourceValueRateChange;

    // Token: 0x40013F3
    public float money;

    // Token: 0x40013F4
    public GameObject freeTradeUIPanel;

    // Token: 0x40013F5
    private ForceData playerForce;

    // Token: 0x40013F6
    private static FreeTradeUIController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60014AC
    // RVA   : 0x788B10   Offset: 0x787310   Length: 0x36
    public static FreeTradeUIController get_Instance()
    {
        return **(uint64 **)(DAT_181da3520 + 184);
    }

    // Token : 0x60014AD
    // RVA   : 0x7872F0   Offset: 0x785AF0   Length: 0x43
    private void Awake()
    {
        puVar1 = *(uint64 **)(DAT_181da3520 + 184);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x60014AE
    // RVA   : 0x7879B0   Offset: 0x7861B0   Length: 0x30
    public void HideFreeTradeUI()
    {
        if (this.freeTradeUIPanel != null) {
          GameObject.SetActive(this.freeTradeUIPanel,0,0);
          FreeTradeUIController.ResetResource(this,0);
          return;
        }
    }

    // Token : 0x60014AF
    // RVA   : 0x788030   Offset: 0x786830   Length: 0x183
    public void ShowFreeTradeUI(FreeTradeUIType targetType, ForceData targetForce)
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        long lVar2;
        ulong uVar3;
        plVar1 = (int64 *)Resources.Load("Sound/SoundEffect/Deal",0);
        plVar4 = (int64 *)0;
        if ((plVar1 != (int64 *)0) && (*plVar1 == DAT_181d8a228)) {
          plVar4 = plVar1;
        }
        NGUITools.PlaySound(plVar4,0);
        if (this.freeTradeUIPanel != null) {
          GameObject.SetActive(this.freeTradeUIPanel,1,0);
          this.freeTradeUIType = targetType;
          if ((*pStatics != 0) &&
             (lVar2 = *(int64 *)(*pStatics + 32)) != null) {
            lVar2 = WorldData.Player(lVar2,0);
            if (lVar2 != null) {
              uVar3 = HeroData.GetForce(lVar2,0,0);
              this.playerForce = uVar3;
              FreeTradeUIController.FreshFreeTradeUI(this,0);
              return;
            }
          }
        }
    }

    // Token : 0x60014B0
    // RVA   : 0x7881C0   Offset: 0x7869C0   Length: 0x7AC
    public void SureButtonClicked()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        int iVar2;
        uint uVar3;
        long lVar4;
        ulong uVar6;
        uint uVar7;
        uint uVar9;
        long lVar10;
        float fVar11;
        float fVar12;
        if (this.money <= 0.0 && this.money != null.0) {
          if ((((*pStatics == 0) ||
               (lVar4 = *(int64 *)(*pStatics + 32)) == null) ||
              (lVar4 = WorldData.Player(lVar4,0)) == null) || (*(int64 *)(lVar4 + 0x220) == 0))
          goto LAB_180788967;
          iVar2 = *(int *)(*(int64 *)(lVar4 + 0x220) + 24);
          if (this.freeTradeUIType == 1) {
            if ((this.playerForce == null) ||
               (lVar4 = this.playerForce.resourceStore) == null)
            goto LAB_180788967;
            if (lVar4.forceName == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            fVar11 = *(float *)(lVar4.forceID + 32);
          }
          else {
            fVar11 = 0.0;
          }
          if ((float)iVar2 + fVar11 + this.money < 0.0) {
            lVar4 = FUN_18046c0a0(0);
            if (lVar4 != null) {
              GameController.ShowTextOnMouse(lVar4,"银钱不足！",0);
              plVar5 = (int64 *)Resources.Load("Sound/SoundEffect/WrongClick",0);
              plVar8 = (int64 *)0;
              if ((plVar5 != (int64 *)0) && (*plVar5 == DAT_181d8a228)) {
                plVar8 = plVar5;
              }
              NGUITools.PlaySound(plVar8,0);
              return;
            }
            goto LAB_180788967;
          }
        }
        lVar4 = this.resourceNum;
        uVar7 = 0;
        if (lVar4 != null) {
          lVar10 = 32;
          uVar9 = uVar7;
          while ((int)uVar9 < lVar4.forceName) {
            if (lVar4 == null) goto LAB_180788967;
            if (lVar4.forceName <= uVar9) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            pfVar1 = (float *)(lVar10 + lVar4.forceID);
            if (*pfVar1 <= 0.0 && *pfVar1 != 0.0) {
              if ((this.playerForce == null) ||
                 (lVar4 = this.playerForce.resourceStore) == null)
              goto LAB_180788967;
              fVar11 = (float)FUN_1800d6780(lVar4,uVar9,DAT_181d796d8);
              if (this.resourceNum == null) goto LAB_180788967;
              fVar12 = (float)FUN_1800d6780(this.resourceNum,uVar9,DAT_181d796d8);
              if (fVar12 + fVar11 < 0.0) {
                lVar4 = FUN_18046c0a0(0);
                lVar10 = *(int64 *)(*(int64 *)(DAT_181d4ef00 + 184) + 0x430);
                if (lVar10 != null) {
                  uVar6 = FUN_180002f80(lVar10,uVar9,DAT_181d7c9c0);
                  uVar6 = String.Concat("门派",uVar6,"不足！",0);
                  if (lVar4 != null) {
                    GameController.ShowTextOnMouse(lVar4,uVar6,0);
                    return;
                  }
                }
                goto LAB_180788967;
              }
            }
            lVar4 = this.resourceNum;
            uVar9 = uVar9 + 1;
            lVar10 = lVar10 + 4;
            if (lVar4 == null) goto LAB_180788967;
          }
          fVar11 = this.money;
          if (0.0 < fVar11) {
        LAB_18078874f:
            lVar4 = this.playerForce;
            if (lVar4 == null) goto LAB_180788967;
        LAB_18078875c:
            ForceData.ChangeResource(lVar4,0,fVar11,1,1,0);
          }
          else {
            if (this.freeTradeUIType == 1) {
              if ((this.playerForce != null) &&
                 (lVar4 = this.playerForce.resourceStore) != null) {
                if (lVar4.forceName == null) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  fVar11 = this.money;
                }
                if (0.0 <= fVar11 + *(float *)(lVar4.forceID + 32)) goto LAB_18078874f;
                lVar4 = FUN_18046c0a0(0);
                if ((lVar4 != null) && (lVar4.defaultSkinID != null)) {
                  lVar4 = WorldData.Player(lVar4.defaultSkinID,0);
                  if ((this.playerForce != null) &&
                     (lVar10 = this.playerForce.resourceStore) != null) {
                    if (*(int *)(lVar10 + 24) == 0) {
                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                    }
                    uVar3 = Mathf.RoundToInt(this.money +
                                              *(float *)(*(int64 *)(lVar10 + 16) + 32),0);
                    if (lVar4 != null) {
                      HeroData.ChangeMoney(lVar4,uVar3,1,0);
                      lVar4 = this.playerForce;
                      if ((lVar4 != null) && (lVar10 = lVar4.resourceStore) != null) {
                        if (*(int *)(lVar10 + 24) == 0) {
                          ThrowHelper.ThrowArgumentOutOfRangeException(0);
                        }
                        fVar11 = -*(float *)(*(int64 *)(lVar10 + 16) + 32);
                        goto LAB_18078875c;
                      }
                    }
                  }
                }
              }
              goto LAB_180788967;
            }
            lVar4 = FUN_18046c0a0(0);
            if ((lVar4 == null) || (lVar4.defaultSkinID == null)) goto LAB_180788967;
            lVar4 = WorldData.Player(lVar4.defaultSkinID,0);
            uVar3 = Mathf.RoundToInt(this.money,0);
            if (lVar4 == null) goto LAB_180788967;
            HeroData.ChangeMoney(lVar4,uVar3,1,0);
          }
          if (((*pStatics != 0) &&
              (lVar4 = *(int64 *)(*pStatics + 32)) != null) &&
             (lVar4 = WorldData.Player(lVar4,0)) != null) {
            HeroData.ChangeResource
                      (lVar4,this.resourceNum,1,this.freeTradeUIType != 1,0);
            lVar4 = *(int64 *)(*(int64 *)(DAT_181d87630 + 184) + 56);
            if (lVar4 != null) {
              if (lVar4.leader == null) goto LAB_180788958;
              lVar4 = this.resourceNum;
              if (lVar4 != null) goto LAB_1807888b7;
            }
          }
        }
        LAB_180788967:
                          // WARNING: Subroutine does not return
        FUN_1800d6620();
        while( true ) {
          fVar11 = (float)FUN_1800d6780(lVar4,uVar7,DAT_181d796d8);
          if (this.resourceValueRateChange == null) break;
          fVar12 = (float)FUN_1800d6780(this.resourceValueRateChange,uVar7,DAT_181d796d8);
          FUN_181814d10(lVar4,uVar7,fVar12 + fVar11,DAT_181d79758);
          lVar4 = this.resourceNum;
          uVar7 = uVar7 + 1;
          if (lVar4 == null) break;
        LAB_1807888b7:
          if (lVar4.forceName <= (int)uVar7) {
        LAB_180788958:
            FreeTradeUIController.ResetResource(this,0);
            return;
          }
          lVar4 = FUN_18046bac0(0);
          if (((lVar4 == null) || (lVar4.leader == null)) ||
             (lVar4 = *(int64 *)(lVar4.leader + 144)) == null) break;
        }
        goto LAB_180788967;
    }

    // Token : 0x60014B1
    // RVA   : 0x787F80   Offset: 0x786780   Length: 0xAC
    public void ResetResource()
    {
        long lVar1;
        int iVar2;
        iVar2 = 0;
        lVar1 = this.resourceNum;
        while (lVar1 != null) {
          if (lVar1.Count <= iVar2) {
            this.money = 0;
            FreeTradeUIController.FreshFreeTradeUI(this,0);
            return;
          }
          if (lVar1 == null) break;
          FUN_181814d10(lVar1,iVar2,0,DAT_181d79758);
          if (this.resourceValueRateChange == null) break;
          FUN_181814d10(this.resourceValueRateChange,iVar2,0,DAT_181d79758);
          iVar2 = iVar2 + 1;
          lVar1 = this.resourceNum;
        }
    }

    // Token : 0x60014B2
    // RVA   : 0x7876C0   Offset: 0x785EC0   Length: 0x2E8
    public float GetResourceValueRate(int resourceID)
    {
        var pStatics = *(int64*)(DAT_181d87630 + 184);
        float fVar1;
        float fVar2;
        float fVar3;
        long lVar4;
        long lVar5;
        long lVar6;
        float fVar7;
        lVar6 = (int64)(int)resourceID;
        lVar4 = *(int64 *)(pStatics + 56);
        if (lVar4 != null) {
          if (*(int64 *)(lVar4 + 88) == 0) {
            fVar7 = 1.0;
        LAB_18078796c:
            Mathf.Max(0x3dcccccd,fVar7,0);
            return;
          }
          lVar4 = *(int64 *)(pStatics + 56);
          if (((lVar4 != null) && (lVar4 = *(int64 *)(lVar4 + 88)) != null) &&
             (lVar4 = *(int64 *)(lVar4 + 136)) != null) {
            if (*(uint32 *)(lVar4 + 24) <= resourceID) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            fVar1 = *(float *)(*(int64 *)(lVar4 + 16) + 32 + lVar6 * 4);
            lVar4 = *(int64 *)(pStatics + 56);
            if (((lVar4 != null) && (lVar4 = *(int64 *)(lVar4 + 88)) != null) &&
               (lVar4 = *(int64 *)(lVar4 + 144)) != null) {
              if (*(uint32 *)(lVar4 + 24) <= resourceID) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar5 = this.resourceValueRateChange;
              fVar2 = *(float *)(*(int64 *)(lVar4 + 16) + 32 + lVar6 * 4);
              if (lVar5 != null) {
                if (lVar5.Count <= resourceID) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                fVar3 = *(float *)(lVar5._items + 32 + lVar6 * 4);
                lVar6 = *(int64 *)(pStatics + 56);
                if (lVar6 != null) {
                  fVar7 = (float)AreaController.GetAreaSpePriceRate(lVar6,0);
                  fVar7 = fVar7 * (fVar2 + fVar1 + fVar3);
                  goto LAB_18078796c;
                }
              }
            }
          }
        }
    }

    // Token : 0x60014B3
    // RVA   : 0x787340   Offset: 0x785B40   Length: 0x379
    public void FreshFreeTradeUI()
    {
        var pStatics = *(int64*)(DAT_181d4ef00 + 184);
        long lVar1;
        ulong uVar2;
        ulong uVar3;
        ulong uVar4;
        long lVar5;
        float fVar6;
        uint[] local_res8 = new uint[2];
        float[] local_res18 = new float[4];
        local_res18[0] = 0.0;
        if (this.freeTradeUIPanel != null) {
          lVar1 = GameObject.get_transform(this.freeTradeUIPanel,0);
          if (lVar1 != null) {
            lVar1 = Transform.Find(lVar1,"Money",0);
            if (lVar1 != null) {
              uVar2 = Component.GetComponent(lVar1,DAT_181d6d8c0);
              uVar3 = Single.ToString(this + 48,"+0;-0;0",0);
              LTLocalization.SetText(uVar2,uVar3,0);
              local_res8[0] = 1;
              while (this.freeTradeUIPanel != null) {
                lVar1 = GameObject.get_transform(this.freeTradeUIPanel,0);
                uVar2 = Int32.ToString(local_res8,0);
                if (lVar1 == null) break;
                lVar1 = Transform.Find(lVar1,uVar2,0);
                if (lVar1 == null) break;
                lVar1 = Transform.Find(lVar1,"Num",0);
                if (lVar1 == null) break;
                uVar2 = Component.GetComponent(lVar1,DAT_181d6d8c0);
                lVar1 = this.resourceNum;
                lVar5 = (int64)(int)local_res8[0];
                if (lVar1 == null) break;
                if (lVar1.Count <= local_res8[0]) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                local_res18[0] = *(float *)(lVar1._items + 32 + lVar5 * 4);
                uVar3 = Single.ToString(local_res18,"+0;-0;0",0);
                LTLocalization.SetText(uVar2,uVar3,0);
                fVar6 = (float)FreeTradeUIController.GetResourceValueRate(this,local_res8[0],0);
                if (this.freeTradeUIPanel == null) break;
                lVar1 = GameObject.get_transform(this.freeTradeUIPanel,0);
                uVar2 = Int32.ToString(local_res8,0);
                if (lVar1 == null) break;
                lVar1 = Transform.Find(lVar1,uVar2,0);
                if (lVar1 == null) break;
                lVar1 = Transform.Find(lVar1,"ValueRate",0);
                if (lVar1 == null) break;
                uVar2 = Component.GetComponent(lVar1,DAT_181d6d8c0);
                if (1.0 < fVar6) {
                  uVar3 = *(uint64 *)(pStatics + 0x2c8);
                }
                else {
                  uVar3 = *(uint64 *)(pStatics + 0x260);
                }
                local_res18[0] = fVar6 * 100.0;
                uVar4 = Single.ToString(local_res18,"f0",0);
                String.Concat(uVar3,uVar4,"%</color>",0);
                LTLocalization.SetText(uVar2);
                local_res8[0] = local_res8[0] + 1;
                if (4 < (int)local_res8[0]) {
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x60014B4
    // RVA   : 0x7879F0   Offset: 0x7861F0   Length: 0x58A
    public void PlusMinusButtonClicked(GameObject buttonClicked)
    {
        bool cVar1;
        uint uVar2;
        long lVar3;
        ulong uVar4;
        int iVar6;
        float fVar8;
        float fVar9;
        if (((buttonClicked != null) && (lVar3 = GameObject.get_transform(buttonClicked,0)) != null) &&
           (lVar3 = FUN_180da0f00(lVar3,0)) != null) {
          uVar4 = Object.get_name(lVar3,0);
          uVar2 = Int32.Parse(uVar4,0);
          uVar4 = Object.get_name(buttonClicked,0);
          cVar1 = FUN_1816fd990(uVar4,"Plus",0);
          plVar7 = (int64 *)0;
          plVar5 = plVar7;
          if (!cVar1) {
            do {
              cVar1 = FUN_1804625f0(0x130,0);
              iVar6 = 1;
              if (cVar1) {
                iVar6 = 10;
              }
              if (iVar6 <= (int)plVar5) goto LAB_180787f24;
              lVar3 = this.resourceNum;
              if (lVar3 == null) throw; // [null/range check failed]
              if (lVar3.Count <= uVar2) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              if (lVar3._items[uVar2] <= 0.0) {
                if (this.freeTradeUIType == null) {
                  lVar3 = FUN_18046c0a0(0);
                  uVar4 = "非掌门无法出售门派资源";
        joined_r0x000180787ec1:
                  if (lVar3 == null) throw; // [null/range check failed]
        LAB_180787ece:
                  GameController.ShowTextOnMouse(lVar3,uVar4,0);
                  plVar5 = (int64 *)Resources.Load("Sound/SoundEffect/WrongClick",0);
                  if ((plVar5 != (int64 *)0) && (*plVar5 == DAT_181d8a228)) {
                    plVar7 = plVar5;
                  }
                  NGUITools.PlaySound(plVar7,0);
        LAB_180787f24:
                  FreeTradeUIController.FreshFreeTradeUI(this,0);
                  return;
                }
                if (this.resourceNum == null) throw; // [null/range check failed]
                fVar8 = (float)FUN_1800d6780(this.resourceNum,uVar2,DAT_181d796d8);
                if (fVar8 <= -10000.0) {
                  lVar3 = FUN_18046c0a0(0);
                  uVar4 = "已达出售上限";
                  if (lVar3 != null) goto LAB_180787ece;
                  throw; // [null/range check failed]
                }
                fVar8 = this.money;
                fVar9 = (float)FreeTradeUIController.GetResourceValueRate(this,uVar2,0);
                lVar3 = this.resourceValueRateChange;
                this.money = fVar9 * 100.0 + fVar8;
                if (lVar3 == null) throw; // [null/range check failed]
                fVar8 = (float)FUN_1800d6780(lVar3,uVar2,DAT_181d796d8);
                FUN_181814d10(lVar3,uVar2,fVar8 - 0.1,DAT_181d79758);
              }
              else {
                lVar3 = this.resourceValueRateChange;
                if (lVar3 == null) throw; // [null/range check failed]
                fVar8 = (float)FUN_1800d6780(lVar3,uVar2,DAT_181d796d8);
                FUN_181814d10(lVar3,uVar2,fVar8 - 0.1,DAT_181d79758);
                fVar8 = this.money;
                fVar9 = (float)FreeTradeUIController.GetResourceValueRate(this,uVar2,0);
                this.money = fVar9 * 100.0 + fVar8;
              }
              lVar3 = this.resourceNum;
              if (lVar3 == null) throw; // [null/range check failed]
              fVar8 = (float)FUN_1800d6780(lVar3,uVar2);
              FUN_181814d10(lVar3,uVar2,fVar8 - 100.0,DAT_181d79758);
              plVar5 = (int64 *)(uint64)((int)plVar5 + 1);
            } while( true );
          }
          while( true ) {
            cVar1 = FUN_1804625f0(0x130,0);
            iVar6 = 1;
            if (cVar1) {
              iVar6 = 10;
            }
            if (iVar6 <= (int)plVar5) goto LAB_180787f24;
            lVar3 = this.resourceNum;
            if (lVar3 == null) break;
            if (lVar3.Count <= uVar2) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            if (0.0 <= lVar3._items[uVar2]) {
              if (this.resourceNum == null) break;
              fVar8 = (float)FUN_1800d6780(this.resourceNum,uVar2,DAT_181d796d8);
              if (10000.0 <= fVar8) {
                lVar3 = FUN_18046c0a0(0);
                uVar4 = "已达购买上限";
                goto joined_r0x000180787ec1;
              }
              fVar8 = this.money;
              fVar9 = (float)FreeTradeUIController.GetResourceValueRate(this,uVar2,0);
              lVar3 = this.resourceValueRateChange;
              this.money = fVar8 - fVar9 * 100.0;
              if (lVar3 == null) break;
              fVar8 = (float)FUN_1800d6780(lVar3,uVar2,DAT_181d796d8);
              FUN_181814d10(lVar3,uVar2,fVar8 + 0.1,DAT_181d79758);
            }
            else {
              lVar3 = this.resourceValueRateChange;
              if (lVar3 == null) break;
              fVar8 = (float)FUN_1800d6780(lVar3,uVar2,DAT_181d796d8);
              FUN_181814d10(lVar3,uVar2,fVar8 + 0.1,DAT_181d79758);
              fVar8 = this.money;
              fVar9 = (float)FreeTradeUIController.GetResourceValueRate(this,uVar2,0);
              this.money = fVar8 - fVar9 * 100.0;
            }
            lVar3 = this.resourceNum;
            if (lVar3 == null) break;
            fVar8 = (float)FUN_1800d6780(lVar3,uVar2,DAT_181d796d8);
            FUN_181814d10(lVar3,uVar2,fVar8 + 100.0,DAT_181d79758);
            plVar5 = (int64 *)(uint64)((int)plVar5 + 1);
          }
        }
    }

    // Token : 0x60014B5
    // RVA   : 0x788970   Offset: 0x787170   Length: 0x19E
    public void /*ctor*/()
    {
        long lVar1;
        lVar1 = il2cpp_internal(DAT_181d721b0);
        FUN_180f58a90(lVar1,DAT_181d79358);
        if (lVar1 != null) {
          FUN_181805690(lVar1,0,DAT_181d79458);
          FUN_181805690(lVar1,0,DAT_181d79458);
          FUN_181805690(lVar1,0,DAT_181d79458);
          FUN_181805690(lVar1,0,DAT_181d79458);
          FUN_181805690(lVar1,0,DAT_181d79458);
          FUN_181805690(lVar1,0,DAT_181d79458);
          this.resourceNum = lVar1;
          lVar1 = il2cpp_internal(DAT_181d721b0);
          FUN_180f58a90(lVar1,DAT_181d79358);
          if (lVar1 != null) {
            FUN_181805690(lVar1,0,DAT_181d79458);
            FUN_181805690(lVar1,0,DAT_181d79458);
            FUN_181805690(lVar1,0,DAT_181d79458);
            FUN_181805690(lVar1,0,DAT_181d79458);
            FUN_181805690(lVar1,0,DAT_181d79458);
            FUN_181805690(lVar1,0,DAT_181d79458);
            this.resourceValueRateChange = lVar1;
            FUN_18044ef50(this,0);
            return;
          }
        }
    }

}
