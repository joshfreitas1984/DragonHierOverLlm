// ============================================================
// Type  : ForceAttackAreaResultController
// Token : 0x2000287
// ============================================================

public class ForceAttackAreaResultController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001457
    public ForceData attackForce;

    // Token: 0x4001458
    public ForceData defenceForce;

    // Token: 0x4001459
    public AreaData targetArea;

    // Token: 0x400145A
    public float deltaFightScore;

    // Token: 0x400145B
    public float deltaDefence;

    // Token: 0x400145C
    public bool showing;

    // Token: 0x400145D
    public bool animing;

    // Token: 0x400145E
    public GameObject forceAttackAreaResultUIPanel;

    // Token: 0x400145F
    private static ForceAttackAreaResultController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001496
    // RVA   : 0xB30D80   Offset: 0xB30180   Length: 0x36
    public static ForceAttackAreaResultController get_Instance()
    {
        return **(uint64 **)(DAT_181dc7bf0 + 184);
    }

    // Token : 0x6001497
    // RVA   : 0xB2FFC0   Offset: 0xB2F3C0   Length: 0x99
    private void Awake()
    {
        ulong uVar1;
        bool cVar3;
        uVar1 = **(uint64 **)(DAT_181dc7bf0 + 184);
        cVar3 = Object.op_Equality(uVar1,0,0);
        if (cVar3) {
          puVar2 = *(uint64 **)(DAT_181dc7bf0 + 184);
          *puVar2 = this;
          il2cpp_internal(puVar2,this);
        }
    }

    // Token : 0x6001498
    // RVA   : 0xB30CE0   Offset: 0xB300E0   Length: 0x95
    private void Update()
    {
        bool cVar1;
        long lVar2;
        if ((this.showing) && (!this.animing)) {
          cVar1 = Input.GetMouseButtonDown(0,0);
          if (cVar1) {
            bVar3 = !DAT_181e9dd59;
            this.animing = 1;
            if (bVar3) {
              il2cpp_runtime_class_init(&DAT_181d77458);
              DAT_181e9dd59 = true;
            }
            lVar2 = new WarpText_d__8(0,0);
            if (lVar2 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            *(int64 *)(lVar2 + 32) = this;
            FUN_180d8c2e0(this,lVar2,0);
          }
        }
    }

    // Token : 0x6001499
    // RVA   : 0xB30060   Offset: 0xB2F460   Length: 0x6C
    public IEnumerator ManageForceAttackReduceDefence()
    {
        long lVar1;
        lVar1 = new WarpText_d__8(0,0);
        if (lVar1 != null) {
          *(uint64 *)(lVar1 + 32) = this;
          return lVar1;
        }
    }

    // Token : 0x600149A
    // RVA   : 0xB300D0   Offset: 0xB2F4D0   Length: 0x493
    public void RefreshUI()
    {
        uint uVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        float[] local_res8 = new float[2];
        if (this.forceAttackAreaResultUIPanel != null) {
          lVar2 = GameObject.get_transform(this.forceAttackAreaResultUIPanel,0);
          if (lVar2 != null) {
            lVar2 = Transform.Find(lVar2,"Support",0);
            if (lVar2 != null) {
              uVar3 = Component.GetComponent(lVar2,DAT_181d96160);
              if (this.targetArea != null) {
                uVar1 = this.targetArea.support;
                GlobalData.DoTweenTextValue(uVar3,uVar1,0x3e4ccccd,0);
                if (this.forceAttackAreaResultUIPanel != null) {
                  lVar2 = GameObject.get_transform(this.forceAttackAreaResultUIPanel,0);
                  if (lVar2 != null) {
                    lVar2 = Transform.Find(lVar2,"Safe",0);
                    if (lVar2 != null) {
                      uVar3 = Component.GetComponent(lVar2,DAT_181d96160);
                      if (this.targetArea != null) {
                        GlobalData.DoTweenTextValue
                                  (uVar3,this.targetArea.safe,0x3e4ccccd,
                                   0);
                        if (this.forceAttackAreaResultUIPanel != null) {
                          lVar2 = GameObject.get_transform(this.forceAttackAreaResultUIPanel,0);
                          if (lVar2 != null) {
                            lVar2 = Transform.Find(lVar2,"DefenceText",0);
                            if (lVar2 != null) {
                              uVar3 = Component.GetComponent(lVar2,DAT_181d96160);
                              if (this.targetArea != null) {
                                GlobalData.DoTweenTextValue
                                          (uVar3,this.targetArea.defence,
                                           0x3e4ccccd,0);
                                if (this.forceAttackAreaResultUIPanel != null) {
                                  lVar2 = GameObject.get_transform(this.forceAttackAreaResultUIPanel,0);
                                  if (lVar2 != null) {
                                    lVar2 = Transform.Find(lVar2,"LeftFightScore",0);
                                    if (lVar2 != null) {
                                      uVar3 = Component.GetComponent(lVar2,DAT_181d96160);
                                      GlobalData.DoTweenTextValue
                                                (uVar3,this.deltaFightScore,0x3e4ccccd,0);
                                      if (this.forceAttackAreaResultUIPanel != null) {
                                        lVar2 = GameObject.get_transform(this.forceAttackAreaResultUIPanel,0)
                                        ;
                                        if (lVar2 != null) {
                                          lVar2 = Transform.Find(lVar2,"DefenceBar",0);
                                          if (lVar2 != null) {
                                            lVar2 = Component.GetComponent(lVar2,DAT_181d94460);
                                            if ((this.targetArea != null) && (lVar2 != null)) {
                                              Image.set_fillAmount
                                                        (lVar2,*(float *)(this.targetArea +
                                                                         92) / 100.0,0);
                                              if (this.forceAttackAreaResultUIPanel != null) {
                                                lVar2 = GameObject.get_transform
                                                                  (this.forceAttackAreaResultUIPanel,0);
                                                if (lVar2 != null) {
                                                  lVar2 = Transform.Find(lVar2,"SupportDefenceRate",0);
                                                  if (lVar2 != null) {
                                                    uVar3 = Component.GetComponent(lVar2,DAT_181d96160);
                                                    if (this.targetArea != null) {
                                                      local_res8[0] =
                                                           *(float *)(*(int64 *)(DAT_181d73d40 + 184)
                                                                     + 132) *
                                                           *(float *)(this.targetArea + 88
                                                                     );
                                                      uVar4 = Single.ToString(local_res8,"f0",0)
                                                      ;
                                                      uVar4 = String.Format("减伤{0}%",uVar4,0);
                                                      LTLocalization.SetText(uVar3,uVar4,0);
                                                      if (this.forceAttackAreaResultUIPanel != null) {
                                                        lVar2 = GameObject.get_transform
                                                                          (this.forceAttackAreaResultUIPanel,0
                                                                          );
                                                        if (lVar2 != null) {
                                                          lVar2 = Transform.Find(lVar2,"SafeDefenceRate",0);
                                                          if (lVar2 != null) {
                                                            uVar3 = Component.GetComponent
                                                                              (lVar2,DAT_181d96160);
                                                            if (this.targetArea != null) {
                                                              local_res8[0] =
                                                                   *(float *)(*(int64 *)
                                                                               (DAT_181d73d40 + 184) +
                                                                             132) *
                                                                   *(float *)(*(int64 *)
                                                                               (this + 40) + 84);
                                                              uVar4 = Single.ToString(local_res8,
                                                                                       "f0",0);
                                                              uVar4 = String.Format("减伤{0}%",uVar4,0
                                                                                    );
                                                              LTLocalization.SetText(uVar3,uVar4,0);
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

    // Token : 0x600149B
    // RVA   : 0xB30570   Offset: 0xB2F970   Length: 0x46D
    public void ShowForceAttackAreaResultUI(ForceData _attackForce, ForceData _defenceForce, AreaData _targetArea, float _deltaFightScore)
    {
        var pStatics = *(int64*)(DAT_181dab490 + 184);
        void ForceAttackAreaResultController.ShowForceAttackAreaResultUI
                     (int64 this,uint64 _attackForce,uint64 _defenceForce,uint64 _targetArea,
                     uint32 _deltaFightScore)
        {
        uint64 uVar1;
        char cVar2;
        int64 lVar3;
        uint64 uVar4;
        this.attackForce = _attackForce;
        this.defenceForce = _defenceForce;
        this.targetArea = _targetArea;
        this.deltaFightScore = _deltaFightScore;
        this.showing = 1;
        if (this.forceAttackAreaResultUIPanel != null) {
          lVar3 = GameObject.get_transform(this.forceAttackAreaResultUIPanel,0);
          if (lVar3 != null) {
            lVar3 = Transform.Find(lVar3,"AreaName",0);
            if (lVar3 != null) {
              uVar1 = Component.GetComponent(lVar3,DAT_181d96160);
              if (this.targetArea != null) {
                uVar4 = AreaData.GetAreaName(this.targetArea,0);
                uVar4 = String.Concat(uVar4,"攻防战",0);
                LTLocalization.SetText(uVar1,uVar4,0);
                if (this.forceAttackAreaResultUIPanel != null) {
                  lVar3 = GameObject.get_transform(this.forceAttackAreaResultUIPanel,0);
                  if (lVar3 != null) {
                    lVar3 = Transform.Find(lVar3,"AreaIcon",0);
                    if (lVar3 != null) {
                      lVar3 = Component.GetComponent(lVar3,DAT_181d94460);
                      if ((this.targetArea != null) &&
                         (*pStatics != 0)) {
                        uVar1 = TextureController.LoadAtlasSprite
                                          (*pStatics,"AreaIconAtlas",
                                           this.targetArea.spriteName,0);
                        if (lVar3 != null) {
                          Image.set_sprite(lVar3,uVar1,0);
                          if (this.forceAttackAreaResultUIPanel != null) {
                            lVar3 = GameObject.get_transform(this.forceAttackAreaResultUIPanel,0);
                            if (lVar3 != null) {
                              lVar3 = Transform.Find(lVar3,"AttackForceName",0);
                              if (lVar3 != null) {
                                uVar1 = Component.GetComponent(lVar3,DAT_181d96160);
                                lVar3 = this.attackForce;
                                if (lVar3 != null) {
                                  cVar2 = FUN_180d755b0(lVar3.forceSetName,0);
                                  if (!cVar2) {
                                    uVar4 = lVar3.forceSetName;
                                  }
                                  else {
                                    uVar4 = lVar3.forceName;
                                  }
                                  LTLocalization.SetText(uVar1,uVar4,0);
                                  if (this.forceAttackAreaResultUIPanel != null) {
                                    lVar3 = GameObject.get_transform(this.forceAttackAreaResultUIPanel,0);
                                    if (lVar3 != null) {
                                      lVar3 = Transform.Find(lVar3,"AttackForceIcon",0);
                                      if (lVar3 != null) {
                                        lVar3 = Component.GetComponent(lVar3,DAT_181d94460);
                                        if (this.attackForce != null) {
                                          uVar1 = ForceData.GetForceIcon(this.attackForce,0)
                                          ;
                                          if (lVar3 != null) {
                                            Image.set_sprite(lVar3,uVar1,0);
                                            if (this.forceAttackAreaResultUIPanel != null) {
                                              lVar3 = GameObject.get_transform
                                                                (this.forceAttackAreaResultUIPanel,0);
                                              if (lVar3 != null) {
                                                lVar3 = Transform.Find(lVar3,"DefenceForceName",0);
                                                if (lVar3 != null) {
                                                  uVar1 = Component.GetComponent(lVar3,DAT_181d96160);
                                                  lVar3 = this.defenceForce;
                                                  if (lVar3 != null) {
                                                    cVar2 = FUN_180d755b0(lVar3.forceSetName,0
                                                                         );
                                                    if (!cVar2) {
                                                      uVar4 = lVar3.forceSetName;
                                                    }
                                                    else {
                                                      uVar4 = lVar3.forceName;
                                                    }
                                                    LTLocalization.SetText(uVar1,uVar4,0);
                                                    if (this.forceAttackAreaResultUIPanel != null) {
                                                      lVar3 = GameObject.get_transform
                                                                        (this.forceAttackAreaResultUIPanel,0);
                                                      if (lVar3 != null) {
                                                        lVar3 = Transform.Find(lVar3,"DefenceForceIcon",0);
                                                        if (lVar3 != null) {
                                                          lVar3 = Component.GetComponent
                                                                            (lVar3,DAT_181d94460);
                                                          if (this.defenceForce != null) {
                                                            uVar1 = ForceData.GetForceIcon
                                                                              (*(int64 *)
                                                                                (this + 32),0);
                                                            if (lVar3 != null) {
                                                              Image.set_sprite(lVar3,uVar1,0);
                                                              ForceAttackAreaResultController.RefreshUI
                                                                        (this,0);
                                                              if (this.forceAttackAreaResultUIPanel != null) {
                                                                GameObject.SetActive
                                                                          (this.forceAttackAreaResultUIPanel,1
                                                                           ,0);
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

    // Token : 0x600149C
    // RVA   : 0xB309E0   Offset: 0xB2FDE0   Length: 0x2FE
    public void UnshowForceAttackAreaResultUI()
    {
        var pStatics = *(int64*)(DAT_181d72cc8 + 184);
        byte uVar1;
        long lVar2;
        long lVar3;
        ulong uVar4;
        ulong uVar5;
        ulong uVar6;
        ulong uVar7;
        if (this.showing) {
          return;
        }
        if (this.forceAttackAreaResultUIPanel != null) {
          GameObject.SetActive(this.forceAttackAreaResultUIPanel,0,0);
          if (*pStatics != 0) {
            uVar1 = GameController.MangeForceTryConquerArea
                              (*pStatics,this.attackForce,
                               this.defenceForce,this.targetArea,0);
            if (*pStatics != 0) {
              GameController.ShowForceAttackAreaInfo
                        (*pStatics,this.attackForce,
                         this.defenceForce,this.targetArea,1,uVar1,0);
              lVar3 = this.attackForce;
              if (((*pStatics != 0) &&
                  (lVar2 = *(int64 *)(*pStatics + 32)) != null) &&
                 (lVar2 = WorldData.Player(lVar2,0)) != null) {
                lVar2 = HeroData.GetForce(lVar2,0,0);
                if (lVar3 == lVar2) {
                  lVar3 = FUN_18046c400(0);
                  if (lVar3 != null) {
                    uVar5 = this.targetArea;
                    uVar6 = 0;
                    uVar4 = this.defenceForce;
                    uVar7 = 1;
        LAB_180b30c7c:
                    PlotController.StartPlayerAttackAreaFightResultPlot
                              (lVar3,uVar4,uVar5,uVar6,uVar7,0,0);
                    return;
                  }
                }
                else {
                  lVar3 = this.defenceForce;
                  lVar2 = FUN_18046c0a0(0);
                  if (((lVar2 != null) && (*(int64 *)(lVar2 + 32) != 0)) &&
                     (lVar2 = WorldData.Player(*(int64 *)(lVar2 + 32),0)) != null) {
                    lVar2 = HeroData.GetForce(lVar2,0,0);
                    if (lVar3 != lVar2) {
                      return;
                    }
                    lVar3 = FUN_18046c400(0);
                    if (lVar3 != null) {
                      uVar5 = this.targetArea;
                      uVar6 = 1;
                      uVar4 = this.attackForce;
                      uVar7 = 0;
                      goto LAB_180b30c7c;
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x600149D
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
