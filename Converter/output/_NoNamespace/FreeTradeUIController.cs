// ============================================================
// Type  : FreeTradeUIController
// Token : 0x2000293
// ============================================================

public class FreeTradeUIController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40014A1
    public FreeTradeUIType freeTradeUIType;

    // Token: 0x40014A2
    private List<float> resourceNum;

    // Token: 0x40014A3
    private List<float> resourceValueRateChange;

    // Token: 0x40014A4
    public float money;

    // Token: 0x40014A5
    public GameObject freeTradeUIPanel;

    // Token: 0x40014A6
    private ForceData playerForce;

    // Token: 0x40014A7
    private static FreeTradeUIController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60014F0
    // RVA   : 0x785570   Offset: 0x784970   Length: 0x36
    public static FreeTradeUIController get_Instance()
    {
        return **(uint64 **)(DAT_181d71ab8 + 184);
    }

    // Token : 0x60014F1
    // RVA   : 0x783CF0   Offset: 0x7830F0   Length: 0x43
    private void Awake()
    {
        puVar1 = *(uint64 **)(DAT_181d71ab8 + 184);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x60014F2
    // RVA   : 0x784410   Offset: 0x783810   Length: 0x30
    public void HideFreeTradeUI()
    {
        if (this.freeTradeUIPanel != null) {
          GameObject.SetActive(this.freeTradeUIPanel,0,0);
          FreeTradeUIController.ResetResource(this,0);
          return;
        }
    }

    // Token : 0x60014F3
    // RVA   : 0x784A90   Offset: 0x783E90   Length: 0x183
    public void ShowFreeTradeUI(FreeTradeUIType targetType, ForceData targetForce)
    {
        long lVar2;
        ulong uVar3;
        plVar1 = (int64 *)Resources.Load("Sound/SoundEffect/Deal",0);
        plVar4 = (int64 *)0;
        if ((plVar1 != (int64 *)0) && (*plVar1 == DAT_181daf348)) {
          plVar4 = plVar1;
        }
        NGUITools.PlaySound(plVar4,0);
        if (this.freeTradeUIPanel != null) {
          GameObject.SetActive(this.freeTradeUIPanel,1,0);
          this.freeTradeUIType = targetType;
          if ((GameController._instance != null) &&
             (lVar2 = GameController._instance.worldData) != null) {
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

    // Token : 0x60014F4
    // RVA   : 0x784C20   Offset: 0x784020   Length: 0x7AC
    public void SureButtonClicked()
    {
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
          if ((((GameController._instance == null) ||
               (lVar4 = GameController._instance.worldData) == null) ||
              (lVar4 = WorldData.Player(lVar4,0)) == null) || (lVar4.speBookStorageSpeAdd == null))
          goto LAB_1807853c7;
          iVar2 = *(int *)(lVar4.speBookStorageSpeAdd + 24);
          if (this.freeTradeUIType == 1) {
            if ((this.playerForce == null) ||
               (lVar4 = this.playerForce.resourceStore) == null)
            goto LAB_1807853c7;
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
              if ((plVar5 != (int64 *)0) && (*plVar5 == DAT_181daf348)) {
                plVar8 = plVar5;
              }
              NGUITools.PlaySound(plVar8,0);
              return;
            }
            goto LAB_1807853c7;
          }
        }
        lVar4 = this.resourceNum;
        uVar7 = 0;
        if (lVar4 != null) {
          lVar10 = 32;
          uVar9 = uVar7;
          while ((int)uVar9 < lVar4.forceName) {
            if (lVar4 == null) goto LAB_1807853c7;
            if (lVar4.forceName <= uVar9) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            pfVar1 = (float *)(lVar10 + lVar4.forceID);
            if (*pfVar1 <= 0.0 && *pfVar1 != 0.0) {
              if ((this.playerForce == null) ||
                 (lVar4 = this.playerForce.resourceStore) == null)
              goto LAB_1807853c7;
              fVar11 = (float)FUN_1800d6790(lVar4,uVar9,DAT_181da1078);
              if (this.resourceNum == null) goto LAB_1807853c7;
              fVar12 = (float)FUN_1800d6790(this.resourceNum,uVar9,DAT_181da1078);
              if (fVar12 + fVar11 < 0.0) {
                lVar4 = FUN_18046c0a0(0);
                lVar10 = *(int64 *)(*(int64 *)(DAT_181d73d40 + 184) + 0x438);
                if (lVar10 != null) {
                  uVar6 = FUN_180002f80(lVar10,uVar9,DAT_181da4358);
                  uVar6 = String.Concat("门派",uVar6,"不足！",0);
                  if (lVar4 != null) {
                    GameController.ShowTextOnMouse(lVar4,uVar6,0);
                    return;
                  }
                }
                goto LAB_1807853c7;
              }
            }
            lVar4 = this.resourceNum;
            uVar9 = uVar9 + 1;
            lVar10 = lVar10 + 4;
            if (lVar4 == null) goto LAB_1807853c7;
          }
          fVar11 = this.money;
          if (0.0 < fVar11) {
        LAB_1807851af:
            lVar4 = this.playerForce;
            if (lVar4 == null) goto LAB_1807853c7;
        LAB_1807851bc:
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
                if (0.0 <= fVar11 + *(float *)(lVar4.forceID + 32)) goto LAB_1807851af;
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
                        goto LAB_1807851bc;
                      }
                    }
                  }
                }
              }
              goto LAB_1807853c7;
            }
            lVar4 = FUN_18046c0a0(0);
            if ((lVar4 == null) || (lVar4.defaultSkinID == null)) goto LAB_1807853c7;
            lVar4 = WorldData.Player(lVar4.defaultSkinID,0);
            uVar3 = Mathf.RoundToInt(this.money,0);
            if (lVar4 == null) goto LAB_1807853c7;
            HeroData.ChangeMoney(lVar4,uVar3,1,0);
          }
          if (((GameController._instance != null) &&
              (lVar4 = GameController._instance.worldData) != null) &&
             (lVar4 = WorldData.Player(lVar4,0)) != null) {
            HeroData.ChangeResource
                      (lVar4,this.resourceNum,1,this.freeTradeUIType != 1,0);
            lVar4 = *(int64 *)(*(int64 *)(DAT_181dac758 + 184) + 56);
            if (lVar4 != null) {
              if (lVar4.leader == null) goto LAB_1807853b8;
              lVar4 = this.resourceNum;
              if (lVar4 != null) goto LAB_180785317;
            }
          }
        }
        LAB_1807853c7:
                          // WARNING: Subroutine does not return
        FUN_1800d6620();
        while( true ) {
          fVar11 = (float)FUN_1800d6790(lVar4,uVar7,DAT_181da1078);
          if (this.resourceValueRateChange == null) break;
          fVar12 = (float)FUN_1800d6790(this.resourceValueRateChange,uVar7,DAT_181da1078);
          FUN_181829d40(lVar4,uVar7,fVar12 + fVar11,DAT_181da10f8);
          lVar4 = this.resourceNum;
          uVar7 = uVar7 + 1;
          if (lVar4 == null) break;
        LAB_180785317:
          if (lVar4.forceName <= (int)uVar7) {
        LAB_1807853b8:
            FreeTradeUIController.ResetResource(this,0);
            return;
          }
          lVar4 = FUN_18046bac0(0);
          if (((lVar4 == null) || (lVar4.leader == null)) ||
             (lVar4 = *(int64 *)(lVar4.leader + 144)) == null) break;
        }
        goto LAB_1807853c7;
    }

    // Token : 0x60014F5
    // RVA   : 0x7849E0   Offset: 0x783DE0   Length: 0xAC
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
          FUN_181829d40(lVar1,iVar2,0,DAT_181da10f8);
          if (this.resourceValueRateChange == null) break;
          FUN_181829d40(this.resourceValueRateChange,iVar2,0,DAT_181da10f8);
          iVar2 = iVar2 + 1;
          lVar1 = this.resourceNum;
        }
    }

    // Token : 0x60014F6
    // RVA   : 0x784120   Offset: 0x783520   Length: 0x2E8
    public float GetResourceValueRate(int resourceID)
    {
        float fVar1;
        float fVar2;
        float fVar3;
        long lVar4;
        long lVar5;
        long lVar6;
        float fVar7;
        lVar6 = (int64)(int)resourceID;
        lVar4 = PlotController.SpringFestivelRewardLvTalkText;
        if (lVar4 != null) {
          if (*(int64 *)(lVar4 + 88) == 0) {
            fVar7 = 1.0;
        LAB_1807843cc:
            Mathf.Max(0x3dcccccd,fVar7,0);
            return;
          }
          lVar4 = PlotController.SpringFestivelRewardLvTalkText;
          if (((lVar4 != null) && (lVar4 = *(int64 *)(lVar4 + 88)) != null) &&
             (lVar4 = *(int64 *)(lVar4 + 136)) != null) {
            if (*(uint32 *)(lVar4 + 24) <= resourceID) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            fVar1 = *(float *)(*(int64 *)(lVar4 + 16) + 32 + lVar6 * 4);
            lVar4 = PlotController.SpringFestivelRewardLvTalkText;
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
                lVar6 = PlotController.SpringFestivelRewardLvTalkText;
                if (lVar6 != null) {
                  fVar7 = (float)AreaController.GetAreaSpePriceRate(lVar6,0);
                  fVar7 = fVar7 * (fVar2 + fVar1 + fVar3);
                  goto LAB_1807843cc;
                }
              }
            }
          }
        }
    }

    // Token : 0x60014F7
    // RVA   : 0x783D40   Offset: 0x783140   Length: 0x3DC
    public void FreshFreeTradeUI()
    {
        var pStatics = *(int64*)(DAT_181d73d40 + 184);
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
              uVar2 = Component.GetComponent(lVar1,DAT_181d96160);
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
                uVar2 = Component.GetComponent(lVar1,DAT_181d96160);
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
                uVar2 = Component.GetComponent(lVar1,DAT_181d96160);
                if (1.0 < fVar6) {
                  uVar3 = *(uint64 *)(pStatics + 0x2d0);
                }
                else {
                  uVar3 = *(uint64 *)(pStatics + 0x268);
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

    // Token : 0x60014F8
    // RVA   : 0x784450   Offset: 0x783850   Length: 0x58A
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
           (lVar3 = FUN_180da9a20(lVar3,0)) != null) {
          uVar4 = Object.get_name(lVar3,0);
          uVar2 = Int32.Parse(uVar4,0);
          uVar4 = Object.get_name(buttonClicked,0);
          cVar1 = FUN_18171e540(uVar4,"Plus",0);
          plVar7 = (int64 *)0;
          plVar5 = plVar7;
          if (!cVar1) {
            do {
              cVar1 = FUN_1804625f0(0x130,0);
              iVar6 = 1;
              if (cVar1) {
                iVar6 = 10;
              }
              if (iVar6 <= (int)plVar5) goto LAB_180784984;
              lVar3 = this.resourceNum;
              if (lVar3 == null) throw; // [null/range check failed]
              if (lVar3.Count <= uVar2) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              if (lVar3._items[uVar2] <= 0.0) {
                if (this.freeTradeUIType == null) {
                  lVar3 = FUN_18046c0a0(0);
                  uVar4 = "非掌门无法出售门派资源";
        joined_r0x000180784921:
                  if (lVar3 == null) throw; // [null/range check failed]
        LAB_18078492e:
                  GameController.ShowTextOnMouse(lVar3,uVar4,0);
                  plVar5 = (int64 *)Resources.Load("Sound/SoundEffect/WrongClick",0);
                  if ((plVar5 != (int64 *)0) && (*plVar5 == DAT_181daf348)) {
                    plVar7 = plVar5;
                  }
                  NGUITools.PlaySound(plVar7,0);
        LAB_180784984:
                  FreeTradeUIController.FreshFreeTradeUI(this,0);
                  return;
                }
                if (this.resourceNum == null) throw; // [null/range check failed]
                fVar8 = (float)FUN_1800d6790(this.resourceNum,uVar2,DAT_181da1078);
                if (fVar8 <= -10000.0) {
                  lVar3 = FUN_18046c0a0(0);
                  uVar4 = "已达出售上限";
                  if (lVar3 != null) goto LAB_18078492e;
                  throw; // [null/range check failed]
                }
                fVar8 = this.money;
                fVar9 = (float)FreeTradeUIController.GetResourceValueRate(this,uVar2,0);
                lVar3 = this.resourceValueRateChange;
                this.money = fVar9 * 100.0 + fVar8;
                if (lVar3 == null) throw; // [null/range check failed]
                fVar8 = (float)FUN_1800d6790(lVar3,uVar2,DAT_181da1078);
                FUN_181829d40(lVar3,uVar2,fVar8 - 0.1,DAT_181da10f8);
              }
              else {
                lVar3 = this.resourceValueRateChange;
                if (lVar3 == null) throw; // [null/range check failed]
                fVar8 = (float)FUN_1800d6790(lVar3,uVar2,DAT_181da1078);
                FUN_181829d40(lVar3,uVar2,fVar8 - 0.1,DAT_181da10f8);
                fVar8 = this.money;
                fVar9 = (float)FreeTradeUIController.GetResourceValueRate(this,uVar2,0);
                this.money = fVar9 * 100.0 + fVar8;
              }
              lVar3 = this.resourceNum;
              if (lVar3 == null) throw; // [null/range check failed]
              fVar8 = (float)FUN_1800d6790(lVar3,uVar2);
              FUN_181829d40(lVar3,uVar2,fVar8 - 100.0,DAT_181da10f8);
              plVar5 = (int64 *)(uint64)((int)plVar5 + 1);
            } while( true );
          }
          while( true ) {
            cVar1 = FUN_1804625f0(0x130,0);
            iVar6 = 1;
            if (cVar1) {
              iVar6 = 10;
            }
            if (iVar6 <= (int)plVar5) goto LAB_180784984;
            lVar3 = this.resourceNum;
            if (lVar3 == null) break;
            if (lVar3.Count <= uVar2) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            if (0.0 <= lVar3._items[uVar2]) {
              if (this.resourceNum == null) break;
              fVar8 = (float)FUN_1800d6790(this.resourceNum,uVar2,DAT_181da1078);
              if (10000.0 <= fVar8) {
                lVar3 = FUN_18046c0a0(0);
                uVar4 = "已达购买上限";
                goto joined_r0x000180784921;
              }
              fVar8 = this.money;
              fVar9 = (float)FreeTradeUIController.GetResourceValueRate(this,uVar2,0);
              lVar3 = this.resourceValueRateChange;
              this.money = fVar8 - fVar9 * 100.0;
              if (lVar3 == null) break;
              fVar8 = (float)FUN_1800d6790(lVar3,uVar2,DAT_181da1078);
              FUN_181829d40(lVar3,uVar2,fVar8 + 0.1,DAT_181da10f8);
            }
            else {
              lVar3 = this.resourceValueRateChange;
              if (lVar3 == null) break;
              fVar8 = (float)FUN_1800d6790(lVar3,uVar2,DAT_181da1078);
              FUN_181829d40(lVar3,uVar2,fVar8 + 0.1,DAT_181da10f8);
              fVar8 = this.money;
              fVar9 = (float)FreeTradeUIController.GetResourceValueRate(this,uVar2,0);
              this.money = fVar8 - fVar9 * 100.0;
            }
            lVar3 = this.resourceNum;
            if (lVar3 == null) break;
            fVar8 = (float)FUN_1800d6790(lVar3,uVar2,DAT_181da1078);
            FUN_181829d40(lVar3,uVar2,fVar8 + 100.0,DAT_181da10f8);
            plVar5 = (int64 *)(uint64)((int)plVar5 + 1);
          }
        }
    }

    // Token : 0x60014F9
    // RVA   : 0x7853D0   Offset: 0x7847D0   Length: 0x19E
    public void /*ctor*/()
    {
        long lVar1;
        lVar1 = il2cpp_internal(DAT_181d96ed0);
        FUN_18132faf0(lVar1,DAT_181da0cf8);
        if (lVar1 != null) {
          FUN_18181de10(lVar1,0,DAT_181da0df8);
          FUN_18181de10(lVar1,0,DAT_181da0df8);
          FUN_18181de10(lVar1,0,DAT_181da0df8);
          FUN_18181de10(lVar1,0,DAT_181da0df8);
          FUN_18181de10(lVar1,0,DAT_181da0df8);
          FUN_18181de10(lVar1,0,DAT_181da0df8);
          this.resourceNum = lVar1;
          lVar1 = il2cpp_internal(DAT_181d96ed0);
          FUN_18132faf0(lVar1,DAT_181da0cf8);
          if (lVar1 != null) {
            FUN_18181de10(lVar1,0,DAT_181da0df8);
            FUN_18181de10(lVar1,0,DAT_181da0df8);
            FUN_18181de10(lVar1,0,DAT_181da0df8);
            FUN_18181de10(lVar1,0,DAT_181da0df8);
            FUN_18181de10(lVar1,0,DAT_181da0df8);
            FUN_18181de10(lVar1,0,DAT_181da0df8);
            this.resourceValueRateChange = lVar1;
            FUN_18044ef50(this,0);
            return;
          }
        }
    }

}
