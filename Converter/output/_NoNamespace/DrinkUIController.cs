// ============================================================
// Type  : DrinkUIController
// Token : 0x2000267
// ============================================================

public class DrinkUIController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400133F
    public DrinkType drinkType;

    // Token: 0x4001340
    public DrinkState drinkState;

    // Token: 0x4001341
    public int round;

    // Token: 0x4001342
    public GameObject wineIcon;

    // Token: 0x4001343
    public GameObject wineCancel;

    // Token: 0x4001344
    private ItemData wineData;

    // Token: 0x4001345
    public float extraWineRate;

    // Token: 0x4001346
    public GameObject foodIcon;

    // Token: 0x4001347
    public GameObject foodCancel;

    // Token: 0x4001348
    private ItemData foodData;

    // Token: 0x4001349
    public float extraFoodRate;

    // Token: 0x400134A
    public GameObject treasureIcon;

    // Token: 0x400134B
    public GameObject treasureCancel;

    // Token: 0x400134C
    private ItemData treasureData;

    // Token: 0x400134D
    public float extraTreasureRate;

    // Token: 0x400134E
    public HeroData enemyData;

    // Token: 0x400134F
    public GameObject drinkUIPanel;

    // Token: 0x4001350
    public GameObject nextButton;

    // Token: 0x4001351
    public GameObject playerIcon;

    // Token: 0x4001352
    public GameObject playerBar;

    // Token: 0x4001353
    public GameObject enemyIcon;

    // Token: 0x4001354
    public GameObject enemyBar;

    // Token: 0x4001355
    public AudioSource pourWaterAudio;

    // Token: 0x4001356
    public float playerFillAmount;

    // Token: 0x4001357
    public float playerFillTarget;

    // Token: 0x4001358
    public int playerFillCount;

    // Token: 0x4001359
    public float enemyFillAmount;

    // Token: 0x400135A
    public bool outFilling;

    // Token: 0x400135B
    public bool playerLose;

    // Token: 0x400135C
    public bool enemyLose;

    // Token: 0x400135D
    public string fightEndCallFuc;

    // Token: 0x400135E
    private static float MaxFillAmount;

    // Token: 0x400135F
    private static List<string> DirnkOverFillText;

    // Token: 0x4001360
    public static List<string> DrinkTalkText;

    // Token: 0x4001361
    public static List<string> DrinkPoemText;

    // Token: 0x4001362
    private GameObject temp;

    // Token: 0x4001363
    private static DrinkUIController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60013B8
    // RVA   : 0x940700   Offset: 0x93FB00   Length: 0x58
    public static DrinkUIController get_Instance()
    {
        return *(uint64 *)(*(int64 *)(DAT_181dc2568 + 184) + 32);
    }

    // Token : 0x60013B9
    // RVA   : 0x93B510   Offset: 0x93A910   Length: 0x68
    private void Awake()
    {
        puVar1 = (uint64 *)(*(int64 *)(DAT_181dc2568 + 184) + 32);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x60013BA
    // RVA   : 0x93BEE0   Offset: 0x93B2E0   Length: 0x40F
    private void FixedUpdate()
    {
        int iVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        float fVar5;
        float fVar6;
        iVar1 = this.drinkState;
        if (iVar1 == 0) {
          return;
        }
        if (iVar1 == 2) {
          fVar6 = this.enemyFillAmount;
          if (!this.outFilling) {
            fVar5 = (float)Time.get_fixedDeltaTime();
            fVar6 = (this.enemyFillAmount + this.enemyFillAmount + 1.0) * fVar5 + fVar6;
            this.enemyFillAmount = fVar6;
            DrinkUIController.SetFillAmount(this,this.enemyBar,fVar6,0);
            fVar6 = this.enemyFillAmount;
            if (**(float **)(DAT_181dc2568 + 184) <= fVar6) {
              this.enemyFillAmount = **(uint32 **)(DAT_181dc2568 + 184);
        LAB_18093c20c:
              this.outFilling = !this.outFilling;
            }
          }
          else {
            fVar5 = (float)Time.get_fixedDeltaTime();
            fVar6 = fVar6 - (this.enemyFillAmount + this.enemyFillAmount + 1.0) * fVar5;
            this.enemyFillAmount = fVar6;
            DrinkUIController.SetFillAmount(this,this.enemyBar,fVar6,0);
            if (this.enemyFillAmount <= 0.0) {
              this.enemyFillAmount = 0;
              goto LAB_18093c20c;
            }
          }
        }
        else if (iVar1 == 3) {
          fVar6 = *(float *)(this + 200);
          if (!this.outFilling) {
            fVar5 = (float)Time.get_fixedDeltaTime();
            fVar6 = (*(float *)(this + 200) + *(float *)(this + 200) + 1.0) * fVar5 + fVar6;
            *(float *)(this + 200) = fVar6;
            DrinkUIController.SetFillAmount(this,this.playerBar,fVar6,0);
            if ((this.playerFillCount < 1) ||
               (fVar6 = this.playerFillTarget, *(float *)(this + 200) < fVar6)) {
              fVar6 = *(float *)(this + 200);
              if (**(float **)(DAT_181dc2568 + 184) <= fVar6) {
                this.playerFillCount = this.playerFillCount + 1;
                *(uint32 *)(this + 200) = **(uint32 **)(DAT_181dc2568 + 184);
                goto LAB_18093c20c;
              }
            }
            else {
              *(float *)(this + 200) = fVar6;
              DrinkUIController.SetFillAmount(this,this.playerBar,fVar6,0);
              this.drinkState = 4;
              if (this.pourWaterAudio == null) throw; // [null/range check failed]
              AudioSource.Stop(this.pourWaterAudio,0);
              DrinkUIController.SetNextButtonActive(this,1,0);
            }
          }
          else {
            fVar5 = (float)Time.get_fixedDeltaTime();
            fVar6 = fVar6 - (*(float *)(this + 200) + *(float *)(this + 200) + 1.0) * fVar5;
            *(float *)(this + 200) = fVar6;
            DrinkUIController.SetFillAmount(this,this.playerBar,fVar6,0);
            if (*(float *)(this + 200) <= 0.0) {
              *(uint32 *)(this + 200) = 0;
              goto LAB_18093c20c;
            }
          }
        }
        if (((this.drinkUIPanel != null) &&
            (lVar2 = GameObject.get_transform(this.drinkUIPanel,0)) != null) &&
           (lVar2 = Transform.Find(lVar2,"Round",0)) != null) {
          uVar3 = Component.GetComponent(lVar2,DAT_181d96160);
          iVar1 = this.round;
          uVar4 = GlobalData.GetNumText(iVar1 + 1,0);
          uVar4 = String.Format("第{0}轮",uVar4,0);
          LTLocalization.SetText(uVar3,uVar4,0);
          return;
        }
    }

    // Token : 0x60013BB
    // RVA   : 0x93F640   Offset: 0x93EA40   Length: 0x1A
    public void SetPlayerFillAmount(float num)
    {
        void FUN_18093f640(int64 this,uint32 num)
        {
        *(uint32 *)(this + 200) = num;
        DrinkUIController.SetFillAmount(this,this.playerBar,num,0);
    }

    // Token : 0x60013BC
    // RVA   : 0x93F150   Offset: 0x93E550   Length: 0x1A
    public void SetEnemyFillAmount(float num)
    {
        void FUN_18093f150(int64 this,uint32 num)
        {
        this.enemyFillAmount = num;
        DrinkUIController.SetFillAmount(this,this.enemyBar,num,0);
    }

    // Token : 0x60013BD
    // RVA   : 0x93F170   Offset: 0x93E570   Length: 0x38A
    public void SetFillAmount(GameObject targetBar, float fillAmount)
    {
        uint uVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        if (targetBar != null) {
          lVar2 = GameObject.get_transform(targetBar,0);
          if (fillAmount <= 1.0) {
            if (((lVar2 != null) && (lVar2 = Transform.Find(lVar2,"Cover",0)) != null) &&
               (lVar2 = Component.GetComponent(lVar2,DAT_181d94460)) != null) {
              Image.set_fillAmount(lVar2,fillAmount,0);
              lVar2 = GameObject.get_transform(targetBar,0);
              if (((lVar2 != null) && (lVar2 = Transform.Find(lVar2,"BadCover",0)) != null) &&
                 (lVar2 = Component.GetComponent(lVar2,DAT_181d94460)) != null) {
                Image.set_fillAmount(lVar2,0,0);
                lVar2 = GameObject.get_transform(targetBar,0);
                if ((lVar2 != null) && (lVar2 = Transform.Find(lVar2,"Percent",0)) != null) {
                  uVar3 = Component.GetComponent(lVar2,DAT_181d96160);
                  uVar1 = Mathf.RoundToInt(fillAmount * 10.0,0);
                  uVar4 = GlobalData.GetNumText(uVar1,0);
                  uVar4 = String.Format("{0}成",uVar4,0);
        LAB_18093f382:
                  LTLocalization.SetText(uVar3,uVar4,0);
                  return;
                }
              }
            }
          }
          else if (((lVar2 != null) && (lVar2 = Transform.Find(lVar2,"Cover",0)) != null) &&
                  (lVar2 = Component.GetComponent(lVar2,DAT_181d94460)) != null) {
            Image.set_fillAmount(lVar2,0x3f800000,0);
            lVar2 = GameObject.get_transform(targetBar,0);
            if ((lVar2 != null) && (lVar2 = Transform.Find(lVar2,"BadCover",0)) != null) {
              lVar2 = Component.GetComponent(lVar2,DAT_181d94460);
              if (lVar2 != null) {
                Image.set_fillAmount
                          (lVar2,(fillAmount - 1.0) / (**(float **)(DAT_181dc2568 + 184) - 1.0),0);
                lVar2 = GameObject.get_transform(targetBar,0);
                if ((lVar2 != null) && (lVar2 = Transform.Find(lVar2,"Percent",0)) != null) {
                  uVar3 = Component.GetComponent(lVar2,DAT_181d96160);
                  uVar4 = "溢出";
                  if (((*(byte *)(DAT_181d84898 + 0x133) & 4) != 0) &&
                     (*(int *)(DAT_181d84898 + 224) == 0)) {
                    il2cpp_runtime_class_init();
                    uVar4 = "溢出";
                  }
                  goto LAB_18093f382;
                }
              }
            }
          }
        }
    }

    // Token : 0x60013BE
    // RVA   : 0x93EB00   Offset: 0x93DF00   Length: 0x128
    public void SetAllItemChooseButtonActive(bool _interactable)
    {
        long lVar1;
        if (this.wineIcon != null) {
          lVar1 = GameObject.get_transform(this.wineIcon,0);
          if (lVar1 != null) {
            lVar1 = FUN_180da9a20(lVar1,0);
            if (lVar1 != null) {
              lVar1 = Component.GetComponent(lVar1,DAT_181d93760);
              if (lVar1 != null) {
                Selectable.set_interactable(lVar1,_interactable,0);
                if (this.foodIcon != null) {
                  lVar1 = GameObject.get_transform(this.foodIcon,0);
                  if (lVar1 != null) {
                    lVar1 = FUN_180da9a20(lVar1,0);
                    if (lVar1 != null) {
                      lVar1 = Component.GetComponent(lVar1,DAT_181d93760);
                      if (lVar1 != null) {
                        Selectable.set_interactable(lVar1,_interactable,0);
                        if (this.treasureIcon != null) {
                          lVar1 = GameObject.get_transform(this.treasureIcon,0);
                          if (lVar1 != null) {
                            lVar1 = FUN_180da9a20(lVar1,0);
                            if (lVar1 != null) {
                              lVar1 = Component.GetComponent(lVar1,DAT_181d93760);
                              if (lVar1 != null) {
                                Selectable.set_interactable(lVar1,_interactable,0);
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

    // Token : 0x60013BF
    // RVA   : 0x93F660   Offset: 0x93EA60   Length: 0xA2A
    public void ShowDrinkUI(DrinkType _drinkType, HeroData _enemyData, ItemData _wineData, string _fightEndCallFuc)
    {
        var pStatics_2ee8 = *(int64*)(DAT_181d72ee8 + 184);
        void DrinkUIController.ShowDrinkUI
                     (int64 this,int _drinkType,int64 _enemyData,int64 _wineData,int64 _fightEndCallFuc)
        {
        int64 *plVar1;
        int64 *plVar2;
        int64 lVar3;
        char cVar4;
        int64 lVar5;
        uint64 uVar6;
        uint64 uVar7;
        bool bVar8;
        float fVar9;
        uint32 uVar10;
        uint32 in_stack_ffffffffffffffb0;
        if (**(int **)(DAT_181d73d40 + 184) == 2) {
          this.enemyData = _enemyData;
          if ((_drinkType == 1) && (_wineData == null)) {
            lVar5 = FUN_18046c0a0(0);
            if ((this.enemyData == null) || (lVar5 == null)) throw; // [null/range check failed]
            in_stack_ffffffffffffffb0 = 0;
            _wineData = GameController.GenerateRandomItem(lVar5,2);
          }
          DrinkUIController.SetDrinkWine(this,_wineData,0);
          fVar9 = 1.0;
          uVar6 = this.enemyData;
          lVar5 = *(int64 *)(*(int64 *)(DAT_181d91b88 + 184) + 24);
          if (_drinkType != null) {
            fVar9 = 0.5;
          }
          Mathf.Min(0x41f00000,
                     (this.extraWineRate + 1.0 + this.extraFoodRate +
                     this.extraTreasureRate) * fVar9,0);
          if (lVar5 != null) {
            uVar7 = 0;
            in_stack_ffffffffffffffb0 = in_stack_ffffffffffffffb0 & 0xffffff00;
            uVar10 = 0;
            PlotController.PlotChangeHeroFavor(lVar5,uVar6);
            if ((_fightEndCallFuc != null) && (cVar4 = String.op_Inequality(_fightEndCallFuc,"",0), cVar4))
            {
              lVar5 = FUN_18046c400(0);
              if (lVar5 == null) throw; // [null/range check failed]
              Component.SendMessage(lVar5,_fightEndCallFuc,"win",0,uVar10,in_stack_ffffffffffffffb0,uVar7)
              ;
            }
            return;
          }
        }
        else if (this.drinkUIPanel != null) {
          GameObject.SetActive(this.drinkUIPanel,1,0);
          this.drinkType = _drinkType;
          this.drinkState = 1;
          DrinkUIController.SetAllIconButtonActive(this,1,0);
          DrinkUIController.RefreshExtraRateInfo(this,0);
          if (((this.drinkUIPanel != null) &&
              (lVar5 = GameObject.get_transform(this.drinkUIPanel,0)) != null) &&
             (lVar5 = Transform.Find(lVar5,"PlayerIcon",0)) != null) {
            uVar6 = Component.get_gameObject(lVar5,0);
            if (*pStatics_2ee8 != 0) {
              uVar7 = *(uint64 *)(*pStatics_2ee8 + 144);
              lVar5 = GlobalData.AddChild(uVar6,uVar7,0);
              this.temp = lVar5;
              if (*plVar1 != 0) {
                lVar5 = GameObject.GetComponent(*plVar1,DAT_181d71b50);
                if (((GameController._instance != null) &&
                    (lVar3 = GameController._instance.worldData) != null) &&
                   (uVar6 = WorldData.Player(lVar3,0), lVar5 != null)) {
                  *(uint64 *)(lVar5 + 32) = uVar6;
                  if ((*plVar1 != 0) &&
                     (lVar5 = GameObject.GetComponent(*plVar1,DAT_181d71b50)) != null) {
                    *(uint32 *)(lVar5 + 24) = 0;
                    if ((*plVar1 != 0) &&
                       (lVar5 = GameObject.GetComponent(*plVar1,DAT_181d71b50)) != null) {
                      *(uint8 *)(lVar5 + 88) = 1;
                      this.playerIcon = *plVar1;
                      this.enemyData = _enemyData;
                      this.fightEndCallFuc = _fightEndCallFuc;
                      if (((this.drinkUIPanel != null) &&
                          (lVar5 = GameObject.get_transform(this.drinkUIPanel,0)) != null
                          ) && (lVar5 = Transform.Find(lVar5,"EnemyHobby",0)) != null) {
                        uVar6 = Component.GetComponent(lVar5,DAT_181d96160);
                        if (*plVar2 != 0) {
                          uVar7 = HeroData.GetHobbyDescribe(*plVar2,0);
                          uVar7 = String.Concat("喜好 ",uVar7,0);
                          LTLocalization.SetText(uVar6,uVar7,0);
                          if (((this.drinkUIPanel != null) &&
                              (lVar5 = GameObject.get_transform(this.drinkUIPanel,0),
                              lVar5 != null)) && (lVar5 = Transform.Find(lVar5,"EnemyIcon",0)) != null
                             ) {
                            uVar6 = Component.get_gameObject(lVar5,0);
                            if (*pStatics_2ee8 != 0) {
                              lVar5 = GlobalData.AddChild
                                                (uVar6,*(uint64 *)
                                                        (*pStatics_2ee8 + 144),0);
                              *plVar1 = lVar5;
                              il2cpp_internal(plVar1,lVar5);
                              if (*plVar1 != 0) {
                                lVar5 = GameObject.GetComponent(*plVar1,DAT_181d71b50);
                                if (lVar5 != null) {
                                  *(int64 *)(lVar5 + 32) = *plVar2;
                                  if ((*plVar1 != 0) &&
                                     (lVar5 = GameObject.GetComponent(*plVar1,DAT_181d71b50)) != null
                                     ) {
                                    *(uint32 *)(lVar5 + 24) = 0;
                                    if ((*plVar1 != 0) &&
                                       (lVar5 = GameObject.GetComponent(*plVar1,DAT_181d71b50),
                                       lVar5 != null)) {
                                      *(uint8 *)(lVar5 + 88) = 1;
                                      this.enemyIcon = *plVar1;
                                      bVar8 = this.drinkType == null;
                                      if (((this.wineIcon != null) &&
                                          (lVar5 = GameObject.get_transform
                                                             (this.wineIcon,0), lVar5 != null
                                          )) && ((lVar5 = FUN_180da9a20(lVar5,0), lVar5 != null &&
                                                 (lVar5 = Component.GetComponent(lVar5,DAT_181d93760),
                                                 lVar5 != null)))) {
                                        Selectable.set_interactable(lVar5,bVar8,0);
                                        if ((((this.foodIcon != null) &&
                                             (lVar5 = GameObject.get_transform
                                                                (this.foodIcon,0),
                                             lVar5 != null)) && (lVar5 = FUN_180da9a20(lVar5,0)) != null)
                                           && (lVar5 = Component.GetComponent(lVar5,DAT_181d93760),
                                              lVar5 != null)) {
                                          Selectable.set_interactable(lVar5,bVar8,0);
                                          if (((this.treasureIcon != null) &&
                                              (lVar5 = GameObject.get_transform
                                                                 (this.treasureIcon,0),
                                              lVar5 != null)) &&
                                             ((lVar5 = FUN_180da9a20(lVar5,0), lVar5 != null &&
                                              (lVar5 = Component.GetComponent(lVar5,DAT_181d93760),
                                              lVar5 != null)))) {
                                            Selectable.set_interactable(lVar5,bVar8,0);
                                            if (this.drinkType != 1) {
                                              DrinkUIController.SetDrinkWine(this,_wineData,0);
        LAB_18093fe41:
                                              DrinkUIController.SetNextButtonText
                                                        (this,"开席",0);
                                              return;
                                            }
                                            if (_wineData == null) {
                                              lVar5 = FUN_18046c0a0(0);
                                              if ((*plVar2 == 0) || (lVar5 == null)) throw; // [null/range check failed]
                                              _wineData = GameController.GenerateRandomItem(lVar5,2);
                                            }
                                            DrinkUIController.SetDrinkWine(this,_wineData,0);
                                            lVar5 = FUN_18046c0a0(0);
                                            if ((*plVar2 != 0) && (lVar5 != null)) {
                                              uVar6 = GameController.GenerateRandomItem(lVar5,2);
                                              DrinkUIController.SetDrinkFood(this,uVar6,0);
                                              lVar5 = FUN_18046c0a0(0);
                                              if ((*plVar2 != 0) && (lVar5 != null)) {
                                                uVar6 = GameController.GenerateRandomItem(lVar5,4);
                                                DrinkUIController.SetDrinkTreasure(this,uVar6,0);
                                                goto LAB_18093fe41;
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

    // Token : 0x60013C0
    // RVA   : 0x93BC20   Offset: 0x93B020   Length: 0x220
    public void DrinkWineChoose()
    {
        long lVar1;
        long lVar2;
        ulong uVar3;
        uint[] local_res8 = new uint[2];
        uint[] local_res18 = new uint[2];
        uint[] local_res20 = new uint[2];
        uint local_28;
        uint[] local_24 = new uint[3];
        if (this.wineData != null) {
          return;
        }
        lVar1 = **(int64 **)(DAT_181db7518 + 184);
        lVar2 = il2cpp_internal(DAT_181d94e50);
        FUN_18132faf0(lVar2,DAT_181d95788);
        local_res8[0] = 0;
        uVar3 = il2cpp_value_box(DAT_181d80418,local_res8);
        if (lVar2 != null) {
          FUN_18181e0a0(lVar2,uVar3,DAT_181d95888);
          local_res18[0] = 2;
          uVar3 = il2cpp_value_box(DAT_181d80418,local_res18);
          FUN_18181e0a0(lVar2,uVar3,DAT_181d95888);
          if (this.enemyData != null) {
            local_res20[0] = this.enemyData.heroForceLv;
            uVar3 = il2cpp_value_box(DAT_181d80418,local_res20);
            FUN_18181e0a0(lVar2,uVar3,DAT_181d95888);
            local_28 = 0xffffffff;
            uVar3 = il2cpp_value_box(DAT_181d80418,&local_28);
            FUN_18181e0a0(lVar2,uVar3,DAT_181d95888);
            local_24[0] = 1;
            uVar3 = il2cpp_value_box(DAT_181d80418,local_24);
            FUN_18181e0a0(lVar2,uVar3,DAT_181d95888);
            uVar3 = Component.get_gameObject(this,0);
            if (lVar1 != null) {
              ChooseController.ShowChoosePanel(lVar1,1,lVar2,uVar3,"DrinkWineChoosen",0,0,0,0,0);
              return;
            }
          }
        }
    }

    // Token : 0x60013C1
    // RVA   : 0x93BE50   Offset: 0x93B250   Length: 0x8A
    public void DrinkWineChoosen()
    {
        var pStatics = *(int64*)(DAT_181db7518 + 184);
        long lVar1;
        if ((*pStatics != 0) &&
           (lVar1 = *(int64 *)(*pStatics + 72)) != null) {
          lVar1 = GameObject.GetComponent(lVar1,DAT_181d720a0);
          if (lVar1 != null) {
            DrinkUIController.SetDrinkWine(this,*(uint64 *)(lVar1 + 32),0);
            return;
          }
        }
    }

    // Token : 0x60013C2
    // RVA   : 0x93EFA0   Offset: 0x93E3A0   Length: 0x1A5
    public void SetDrinkWine(ItemData targetWine)
    {
        var pStatics = *(int64*)(DAT_181d72ee8 + 184);
        ulong uVar1;
        ulong uVar2;
        long lVar3;
        uint uVar4;
        this.wineData = targetWine;
        uVar2 = this.wineIcon;
        if (*pStatics != 0) {
          uVar1 = *(uint64 *)(*pStatics + 160);
          uVar2 = GlobalData.AddChild(uVar2,uVar1,0);
          this.temp = uVar2;
          if (this.temp != null) {
            lVar3 = GameObject.GetComponent(this.temp,DAT_181d720a0);
            if (lVar3 != null) {
              *(uint64 *)(lVar3 + 32) = this.wineData;
              if (this.temp != null) {
                lVar3 = GameObject.GetComponent(this.temp,DAT_181d720a0);
                if (lVar3 != null) {
                  *(uint32 *)(lVar3 + 40) = 1;
                  if (this.enemyData != null) {
                    uVar4 = HeroData.GetItemFavorValue
                                      (this.enemyData,this.wineData,
                                       0x41a00000,0);
                    uVar4 = Mathf.Max(0x3d4ccccd,uVar4,0);
                    this.extraWineRate = uVar4;
                    DrinkUIController.RefreshExtraRateInfo(this,0);
                    if (this.wineCancel != null) {
                      GameObject.SetActive(this.wineCancel,this.drinkType == null,0)
                      ;
                      return;
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x60013C3
    // RVA   : 0x93BB80   Offset: 0x93AF80   Length: 0x9A
    public void DrinkWineCancel()
    {
        ulong uVar1;
        this.wineData = 0;
        uVar1 = this.wineIcon;
        GlobalData.DeleteAllChild(uVar1,0);
        this.extraWineRate = 0;
        DrinkUIController.RefreshExtraRateInfo(this,0);
        if (this.wineCancel != null) {
          GameObject.SetActive(this.wineCancel,0,0);
          return;
        }
    }

    // Token : 0x60013C4
    // RVA   : 0x93B620   Offset: 0x93AA20   Length: 0x21C
    public void DrinkFoodChoose()
    {
        long lVar1;
        long lVar2;
        ulong uVar3;
        uint[] local_res8 = new uint[2];
        uint[] local_res18 = new uint[2];
        uint[] local_res20 = new uint[2];
        uint local_28;
        uint[] local_24 = new uint[3];
        if (this.foodData != null) {
          return;
        }
        lVar1 = **(int64 **)(DAT_181db7518 + 184);
        lVar2 = il2cpp_internal(DAT_181d94e50);
        FUN_18132faf0(lVar2,DAT_181d95788);
        local_res8[0] = 0;
        uVar3 = il2cpp_value_box(DAT_181d80418,local_res8);
        if (lVar2 != null) {
          FUN_18181e0a0(lVar2,uVar3,DAT_181d95888);
          local_res18[0] = 2;
          uVar3 = il2cpp_value_box(DAT_181d80418,local_res18);
          FUN_18181e0a0(lVar2,uVar3,DAT_181d95888);
          if (this.enemyData != null) {
            local_res20[0] = this.enemyData.heroForceLv;
            uVar3 = il2cpp_value_box(DAT_181d80418,local_res20);
            FUN_18181e0a0(lVar2,uVar3,DAT_181d95888);
            local_28 = 0xffffffff;
            uVar3 = il2cpp_value_box(DAT_181d80418,&local_28);
            FUN_18181e0a0(lVar2,uVar3,DAT_181d95888);
            local_24[0] = 0;
            uVar3 = il2cpp_value_box(DAT_181d80418,local_24);
            FUN_18181e0a0(lVar2,uVar3,DAT_181d95888);
            uVar3 = Component.get_gameObject(this,0);
            if (lVar1 != null) {
              ChooseController.ShowChoosePanel(lVar1,1,lVar2,uVar3,"DrinkFoodChoosen",0,0,0,0,0);
              return;
            }
          }
        }
    }

    // Token : 0x60013C5
    // RVA   : 0x93B840   Offset: 0x93AC40   Length: 0x8A
    public void DrinkFoodChoosen()
    {
        var pStatics = *(int64*)(DAT_181db7518 + 184);
        long lVar1;
        if ((*pStatics != 0) &&
           (lVar1 = *(int64 *)(*pStatics + 72)) != null) {
          lVar1 = GameObject.GetComponent(lVar1,DAT_181d720a0);
          if (lVar1 != null) {
            DrinkUIController.SetDrinkFood(this,*(uint64 *)(lVar1 + 32),0);
            return;
          }
        }
    }

    // Token : 0x60013C6
    // RVA   : 0x93EC30   Offset: 0x93E030   Length: 0x1A5
    public void SetDrinkFood(ItemData targetFood)
    {
        var pStatics = *(int64*)(DAT_181d72ee8 + 184);
        ulong uVar1;
        ulong uVar2;
        long lVar3;
        uint uVar4;
        this.foodData = targetFood;
        uVar2 = this.foodIcon;
        if (*pStatics != 0) {
          uVar1 = *(uint64 *)(*pStatics + 160);
          uVar2 = GlobalData.AddChild(uVar2,uVar1,0);
          this.temp = uVar2;
          if (this.temp != null) {
            lVar3 = GameObject.GetComponent(this.temp,DAT_181d720a0);
            if (lVar3 != null) {
              *(uint64 *)(lVar3 + 32) = this.foodData;
              if (this.temp != null) {
                lVar3 = GameObject.GetComponent(this.temp,DAT_181d720a0);
                if (lVar3 != null) {
                  *(uint32 *)(lVar3 + 40) = 1;
                  if (this.enemyData != null) {
                    uVar4 = HeroData.GetItemFavorValue
                                      (this.enemyData,this.foodData,
                                       0x41a00000,0);
                    uVar4 = Mathf.Max(0x3d4ccccd,uVar4,0);
                    this.extraFoodRate = uVar4;
                    DrinkUIController.RefreshExtraRateInfo(this,0);
                    if (this.foodCancel != null) {
                      GameObject.SetActive(this.foodCancel,this.drinkType == null,0)
                      ;
                      return;
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x60013C7
    // RVA   : 0x93B580   Offset: 0x93A980   Length: 0x9A
    public void DrinkFoodCancel()
    {
        ulong uVar1;
        this.foodData = 0;
        uVar1 = this.foodIcon;
        GlobalData.DeleteAllChild(uVar1,0);
        this.extraFoodRate = 0;
        DrinkUIController.RefreshExtraRateInfo(this,0);
        if (this.foodCancel != null) {
          GameObject.SetActive(this.foodCancel,0,0);
          return;
        }
    }

    // Token : 0x60013C8
    // RVA   : 0x93B970   Offset: 0x93AD70   Length: 0x17B
    public void DrinkTreasureChoose()
    {
        long lVar1;
        long lVar2;
        ulong uVar3;
        uint[] local_res8 = new uint[2];
        uint[] local_res18 = new uint[4];
        if (this.treasureData != null) {
          return;
        }
        lVar1 = **(int64 **)(DAT_181db7518 + 184);
        lVar2 = il2cpp_internal(DAT_181d94e50);
        FUN_18132faf0(lVar2,DAT_181d95788);
        local_res8[0] = 0;
        uVar3 = il2cpp_value_box(DAT_181d80418,local_res8);
        if (lVar2 != null) {
          FUN_18181e0a0(lVar2,uVar3,DAT_181d95888);
          local_res18[0] = 4;
          uVar3 = il2cpp_value_box(DAT_181d80418,local_res18);
          FUN_18181e0a0(lVar2,uVar3,DAT_181d95888);
          uVar3 = Component.get_gameObject(this,0);
          if (lVar1 != null) {
            ChooseController.ShowChoosePanel(lVar1,1,lVar2,uVar3,"DrinkTreasureChoosen",0,0,0,0,0);
            return;
          }
        }
    }

    // Token : 0x60013C9
    // RVA   : 0x93BAF0   Offset: 0x93AEF0   Length: 0x8A
    public void DrinkTreasureChoosen()
    {
        var pStatics = *(int64*)(DAT_181db7518 + 184);
        long lVar1;
        if ((*pStatics != 0) &&
           (lVar1 = *(int64 *)(*pStatics + 72)) != null) {
          lVar1 = GameObject.GetComponent(lVar1,DAT_181d720a0);
          if (lVar1 != null) {
            DrinkUIController.SetDrinkTreasure(this,*(uint64 *)(lVar1 + 32),0);
            return;
          }
        }
    }

    // Token : 0x60013CA
    // RVA   : 0x93EDE0   Offset: 0x93E1E0   Length: 0x1B4
    public void SetDrinkTreasure(ItemData targetTreasure)
    {
        var pStatics = *(int64*)(DAT_181d72ee8 + 184);
        ulong uVar1;
        ulong uVar2;
        long lVar3;
        float fVar4;
        uint uVar5;
        this.treasureData = targetTreasure;
        uVar2 = this.treasureIcon;
        if (*pStatics != 0) {
          uVar1 = *(uint64 *)(*pStatics + 160);
          uVar2 = GlobalData.AddChild(uVar2,uVar1,0);
          this.temp = uVar2;
          if (this.temp != null) {
            lVar3 = GameObject.GetComponent(this.temp,DAT_181d720a0);
            if (lVar3 != null) {
              *(uint64 *)(lVar3 + 32) = this.treasureData;
              if (this.temp != null) {
                lVar3 = GameObject.GetComponent(this.temp,DAT_181d720a0);
                if (lVar3 != null) {
                  *(uint32 *)(lVar3 + 40) = 1;
                  if (this.enemyData != null) {
                    fVar4 = (float)HeroData.GetItemFavorValue
                                             (this.enemyData,
                                              this.treasureData,0x41a00000,0);
                    uVar5 = Mathf.Max(0x3c23d70a,fVar4 * 0.2,0);
                    this.extraTreasureRate = uVar5;
                    DrinkUIController.RefreshExtraRateInfo(this,0);
                    if (this.treasureCancel != null) {
                      GameObject.SetActive(this.treasureCancel,this.drinkType == null,0)
                      ;
                      return;
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x60013CB
    // RVA   : 0x93B8D0   Offset: 0x93ACD0   Length: 0x9D
    public void DrinkTreasureCancel()
    {
        ulong uVar1;
        this.treasureData = 0;
        uVar1 = this.treasureIcon;
        GlobalData.DeleteAllChild(uVar1,0);
        this.extraTreasureRate = 0;
        DrinkUIController.RefreshExtraRateInfo(this,0);
        if (this.treasureCancel != null) {
          GameObject.SetActive(this.treasureCancel,0,0);
          return;
        }
    }

    // Token : 0x60013CC
    // RVA   : 0x93E890   Offset: 0x93DC90   Length: 0x134
    public void RefreshExtraRateInfo()
    {
        long lVar1;
        ulong uVar2;
        ulong uVar3;
        float[] local_res8 = new float[2];
        if (this.drinkUIPanel != null) {
          lVar1 = GameObject.get_transform(this.drinkUIPanel,0);
          if (lVar1 != null) {
            lVar1 = Transform.Find(lVar1,"ExtraRateInfo",0);
            if (lVar1 != null) {
              uVar2 = Component.GetComponent(lVar1,DAT_181d96160);
              local_res8[0] =
                   (this.extraWineRate + 1.0 + this.extraFoodRate +
                   this.extraTreasureRate) * 100.0;
              uVar3 = Single.ToString(local_res8,"f0",0);
              uVar3 = String.Format("宴会评分\n<b>{0}</b>",uVar3,0);
              LTLocalization.SetText(uVar2,uVar3,0);
              return;
            }
          }
        }
    }

    // Token : 0x60013CD
    // RVA   : 0x93C590   Offset: 0x93B990   Length: 0x314
    public void HideDrinkUI()
    {
        long lVar1;
        ulong uVar2;
        if (this.drinkUIPanel != null) {
          GameObject.SetActive(this.drinkUIPanel,0,0);
          this.drinkState = 0;
          if (this.drinkUIPanel != null) {
            lVar1 = GameObject.get_transform(this.drinkUIPanel,0);
            if (lVar1 != null) {
              lVar1 = Transform.Find(lVar1,"PlayerIcon",0);
              if (lVar1 != null) {
                uVar2 = Component.get_gameObject(lVar1,0);
                GlobalData.DeleteAllChild(uVar2,0);
                if (this.drinkUIPanel != null) {
                  lVar1 = GameObject.get_transform(this.drinkUIPanel,0);
                  if (lVar1 != null) {
                    lVar1 = Transform.Find(lVar1,"EnemyIcon",0);
                    if (lVar1 != null) {
                      uVar2 = Component.get_gameObject(lVar1,0);
                      GlobalData.DeleteAllChild(uVar2,0);
                      if (this.drinkUIPanel != null) {
                        lVar1 = GameObject.get_transform(this.drinkUIPanel,0);
                        if (lVar1 != null) {
                          lVar1 = Transform.Find(lVar1,"FinalResult",0);
                          if (lVar1 != null) {
                            lVar1 = Component.get_gameObject(lVar1,0);
                            if (lVar1 != null) {
                              GameObject.SetActive(lVar1,0,0);
                              this.wineData = 0;
                              uVar2 = this.wineIcon;
                              GlobalData.DeleteAllChild(uVar2,0);
                              this.extraWineRate = 0;
                              DrinkUIController.RefreshExtraRateInfo(this,0);
                              if (this.wineCancel != null) {
                                GameObject.SetActive(this.wineCancel,0,0);
                                this.foodData = 0;
                                uVar2 = this.foodIcon;
                                GlobalData.DeleteAllChild(uVar2,0);
                                this.extraFoodRate = 0;
                                DrinkUIController.RefreshExtraRateInfo(this,0);
                                if (this.foodCancel != null) {
                                  GameObject.SetActive(this.foodCancel,0,0);
                                  this.treasureData = 0;
                                  uVar2 = this.treasureIcon;
                                  GlobalData.DeleteAllChild(uVar2,0);
                                  this.extraTreasureRate = 0;
                                  DrinkUIController.RefreshExtraRateInfo(this,0);
                                  if (this.treasureCancel != null) {
                                    GameObject.SetActive(this.treasureCancel,0,0);
                                    this.round = 0;
                                    this.playerLose = 0;
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

    // Token : 0x60013CE
    // RVA   : 0x93F570   Offset: 0x93E970   Length: 0xC0
    public void SetNextButtonText(string _text)
    {
        long lVar1;
        ulong uVar2;
        if (this.nextButton != null) {
          lVar1 = GameObject.get_transform(this.nextButton,0);
          if (lVar1 != null) {
            lVar1 = Transform.Find(lVar1,"Label",0);
            if (lVar1 != null) {
              uVar2 = Component.GetComponent(lVar1,DAT_181d96160);
              LTLocalization.SetText(uVar2,_text,0);
              return;
            }
          }
        }
    }

    // Token : 0x60013CF
    // RVA   : 0x93F500   Offset: 0x93E900   Length: 0x67
    public void SetNextButtonActive(bool _interactable)
    {
        long lVar1;
        if (this.nextButton != null) {
          lVar1 = GameObject.GetComponent(this.nextButton,DAT_181dc7c00);
          if (lVar1 != null) {
            Selectable.set_interactable(lVar1,_interactable,0);
            return;
          }
        }
    }

    // Token : 0x60013D0
    // RVA   : 0x93C2F0   Offset: 0x93B6F0   Length: 0x161
    public float GetDrinkCost(float fillAmount)
    {
        long lVar1;
        float fVar2;
        ulong uVar3;
        if ((GameController._instance != null) &&
           (lVar1 = GameController._instance.worldData) != null) {
          lVar1 = WorldData.Player(lVar1,0);
          if ((lVar1 != null) && (this.enemyData != null)) {
            Mathf.Max(lVar1.totalEnemyKilled);
            fVar2 = (float)Mathf.Max(0x41c80000);
            uVar3 = Mathf.Min(fVar2 * 4.0,(float)this.round * fVar2 + fVar2,0);
            if (1.0 < fillAmount) {
              fillAmount = fillAmount * 0.0;
            }
            return CONCAT44((int)((uint64)uVar3 >> 32),-(float)uVar3 * fillAmount) ^ 0x8000000000000000;
          }
        }
    }

    // Token : 0x60013D1
    // RVA   : 0x93C460   Offset: 0x93B860   Length: 0x10E
    public float GetRandomPlayerFillAmount()
    {
        float fVar1;
        fVar1 = (float)Random.get_value(0);
        if (fVar1 < 0.1) {
          Random.Range(0x3f800000,**(uint32 **)(DAT_181dc2568 + 184),0);
          return;
        }
        if (fVar1 < 0.2) {
          Random.Range(0,0x3e99999a,0);
          return;
        }
        if (0.35 <= fVar1) {
          if (0.85 <= fVar1) {
            Random.Range(0x3f666666,0x3f800000,0);
            return;
          }
          Random.Range(0x3f19999a,0x3f666666,0);
          return;
        }
        Random.Range(0x3e99999a,0x3f19999a,0);
    }

    // Token : 0x60013D2
    // RVA   : 0x93E9D0   Offset: 0x93DDD0   Length: 0x128
    public void SetAllIconButtonActive(bool active)
    {
        long lVar1;
        if (this.wineIcon != null) {
          lVar1 = GameObject.get_transform(this.wineIcon,0);
          if (lVar1 != null) {
            lVar1 = FUN_180da9a20(lVar1,0);
            if (lVar1 != null) {
              lVar1 = Component.GetComponent(lVar1,DAT_181d93760);
              if (lVar1 != null) {
                Selectable.set_interactable(lVar1,active,0);
                if (this.foodIcon != null) {
                  lVar1 = GameObject.get_transform(this.foodIcon,0);
                  if (lVar1 != null) {
                    lVar1 = FUN_180da9a20(lVar1,0);
                    if (lVar1 != null) {
                      lVar1 = Component.GetComponent(lVar1,DAT_181d93760);
                      if (lVar1 != null) {
                        Selectable.set_interactable(lVar1,active,0);
                        if (this.treasureIcon != null) {
                          lVar1 = GameObject.get_transform(this.treasureIcon,0);
                          if (lVar1 != null) {
                            lVar1 = FUN_180da9a20(lVar1,0);
                            if (lVar1 != null) {
                              lVar1 = Component.GetComponent(lVar1,DAT_181d93760);
                              if (lVar1 != null) {
                                Selectable.set_interactable(lVar1,active,0);
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

    // Token : 0x60013D3
    // RVA   : 0x93CDC0   Offset: 0x93C1C0   Length: 0x1AB8
    public void NextButtonClicked()
    {
        var pStatics_3d40 = *(int64*)(DAT_181d73d40 + 184);
        bool cVar2;
        ulong uVar3;
        ulong uVar7;
        long lVar9;
        long lVar10;
        ulong uVar11;
        long lVar12;
        ulong uVar13;
        uint uVar14;
        float fVar16;
        uint uVar17;
        float fVar18;
        float fVar19;
        uint uVar20;
        float fVar21;
        float[] local_res18 = new float[2];
        float[] local_res20 = new float[2];
        ulong uVar22;
        ulong in_stack_ffffffffffffff10;
        ulong local_c8;
        ulong local_b8;
        float local_b0;
        byte[] local_a8 = new byte[16];
        uint local_98;
        uint uStack_94;
        uint uStack_90;
        uint32 uStack_8c;
        uVar7 = "";
        uVar20 = 0;
        local_res18[0] = 0.0;
        local_res20[0] = 0.0;
        switch(this.drinkState) {
        case 1:
          if (this.wineData == null) {
            lVar9 = FUN_18046c0a0(0);
            fVar18 = local_b0;
            if (lVar9 == null) goto LAB_18093e83f;
            GameController.ShowTextOnMouse(lVar9,"需要选择醇酒方能开始！",0);
          }
          else {
            this.drinkState = 2;
            fVar18 = local_b0;
            if (this.pourWaterAudio == null) goto LAB_18093e83f;
            AudioSource.Play(this.pourWaterAudio,0);
            DrinkUIController.SetNextButtonText(this,"斟酒",0);
            DrinkUIController.SetAllIconButtonActive(this,0,0);
            fVar18 = local_b0;
            if (this.wineCancel == null) goto LAB_18093e83f;
            GameObject.SetActive(this.wineCancel,0,0);
            fVar18 = local_b0;
            if (this.foodCancel == null) goto LAB_18093e83f;
            GameObject.SetActive(this.foodCancel,0,0);
            fVar18 = local_b0;
            if (this.treasureCancel == null) goto LAB_18093e83f;
            GameObject.SetActive(this.treasureCancel,0,0);
            if (this.drinkType == null) {
              lVar9 = FUN_18046c0a0(0);
              fVar18 = local_b0;
              if (((lVar9 == null) || (lVar9.name == null)) ||
                 (lVar9 = WorldData.Player(lVar9.name,0), fVar18 = local_b0) == null
                 ) goto LAB_18093e83f;
              HeroData.LoseItem(lVar9,this.wineData,1,0);
              lVar9 = FUN_18046c0a0(0);
              fVar18 = local_b0;
              if (((lVar9 == null) || (lVar9.name == null)) ||
                 (lVar9 = WorldData.Player(lVar9.name,0), fVar18 = local_b0) == null
                 ) goto LAB_18093e83f;
              HeroData.LoseItem(lVar9,this.foodData,1,0);
            }
          }
          break;
        case 2:
          this.drinkState = 3;
          DrinkUIController.SetNextButtonText(this,"痛饮",0);
          DrinkUIController.SetNextButtonActive(this,0,0);
          fVar21 = (float)Random.get_value(0);
          if (fVar21 < 0.1) {
            uVar20 = 0x3f800000;
            uVar17 = **(uint32 **)(DAT_181dc2568 + 184);
          }
          else if (fVar21 < 0.2) {
            uVar17 = 0x3e99999a;
          }
          else if (fVar21 < 0.35) {
            uVar20 = 0x3e99999a;
            uVar17 = 0x3f19999a;
          }
          else if (fVar21 < 0.85) {
            uVar20 = 0x3f19999a;
            uVar17 = 0x3f666666;
          }
          else {
            uVar20 = 0x3f666666;
            uVar17 = 0x3f800000;
          }
          uVar20 = Random.Range(uVar20,uVar17,0);
          this.playerFillTarget = uVar20;
          this.playerFillCount = 0;
          this.outFilling = 0;
          break;
        case 3:
          break;
        case 4:
          lVar9 = FUN_1807789e0(0);
          fVar18 = local_b0;
          if (lVar9 == null) goto LAB_18093e83f;
          HeroLittleTalkController.ClearAll(lVar9,0);
          plVar8 = (int64 *)0;
          bVar1 = false;
          if (this.treasureData != null) {
            lVar9 = this.treasureData.treasureData;
            fVar18 = local_b0;
            if (lVar9 == null) goto LAB_18093e83f;
            if (!lVar9.itemID) {
              lVar9.itemID = 1;
              lVar9 = this.treasureData;
              plVar5 = plVar8;
              plVar15 = plVar8;
              if (lVar9 != null) {
                while( true ) {
                  fVar18 = local_b0;
                  if ((lVar9.treasureData == null) ||
                     (lVar10 = *(int64 *)(lVar9.treasureData + 24)) == null)
                  goto LAB_18093e83f;
                  uVar14 = (uint32)plVar5;
                  if (lVar10.summonLv <= (int)uVar14) break;
                  if (((lVar9 == null) || (lVar9.treasureData == null)) ||
                     (lVar9 = *(int64 *)(lVar9.treasureData + 40)) == null)
                  goto LAB_18093e83f;
                  if (lVar9.subType <= uVar14) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  if ((*(char *)(lVar9.itemID + 32 + (int64)plVar15) == false) &&
                     (!bVar1)) {
                    fVar18 = local_b0;
                    if (this.enemyData == null) goto LAB_18093e83f;
                    uVar20 = HeroData.GetIdentifyKnowledge(this.enemyData,0);
                    fVar18 = local_b0;
                    if (((this.treasureData == null) ||
                        (lVar9 = this.treasureData.treasureData) == null) ||
                       (lVar9 = lVar9.name) == null) goto LAB_18093e83f;
                    uVar7 = FUN_1800d6790(lVar9,plVar5,DAT_181da1078);
                    cVar2 = ItemData.TryIdentifyOneResult(uVar20,uVar7,0);
                    if (cVar2) {
                      bVar1 = true;
                      fVar18 = local_b0;
                      if (((this.treasureData == null) ||
                          (lVar9 = this.treasureData.treasureData) == null) ||
                         (lVar9 = lVar9.checkName) == null) goto LAB_18093e83f;
                      FUN_1817f42f0(lVar9,plVar5,1,DAT_181d80720);
                      lVar9 = FUN_1807789e0(0);
                      fVar18 = local_b0;
                      if (lVar9 == null) goto LAB_18093e83f;
                      HeroLittleTalkController.HeroTalk
                                (lVar9,this.playerIcon,"原来如此",0x40c00000,0);
                      lVar9 = FUN_1807789e0(0);
                      uVar7 = this.enemyIcon;
                      fVar18 = local_b0;
                      if (this.treasureData == null) goto LAB_18093e83f;
                      uVar11 = ItemData.Name(this.treasureData,1,0);
                      fVar18 = local_b0;
                      if (this.treasureData == null) goto LAB_18093e83f;
                      uVar20 = this.treasureData.itemLv;
                      uVar11 = GlobalData.GenerateRareLvColorText(uVar11,uVar20,0);
                      lVar10 = *(int64 *)(pStatics_3d40 + 0x520);
                      fVar18 = local_b0;
                      if (lVar10 == null) goto LAB_18093e83f;
                      uVar3 = FUN_180002f80(lVar10,plVar5,DAT_181da4358);
                      lVar10 = *(int64 *)(pStatics_3d40 + 0x508);
                      fVar18 = local_b0;
                      if (((this.treasureData == null) ||
                          (lVar12 = this.treasureData.treasureData) == null) ||
                         ((lVar12 = *(int64 *)(lVar12 + 24), lVar12 == null ||
                          (uVar20 = FUN_1800d6760(lVar12,plVar5,DAT_181d8fa18), fVar18 = local_b0,
                          lVar10 == null)))) goto LAB_18093e83f;
                      uVar13 = FUN_180002f80(lVar10,uVar20,DAT_181da4358);
                      fVar18 = local_b0;
                      if (((this.treasureData == null) ||
                          (lVar10 = this.treasureData.treasureData) == null) ||
                         (lVar10 = lVar10.summonLv) == null) goto LAB_18093e83f;
                      uVar20 = FUN_1800d6760(lVar10,plVar5,DAT_181d8fa18);
                      uVar13 = GlobalData.GenerateRareLvColorText(uVar13,uVar20,0);
                      uVar11 = String.Format("咦？如果没走眼的话，这个{0}的{1}应当是{2}啊。",uVar11,uVar3,uVar13,0);
                      fVar18 = local_b0;
                      if (lVar9 == null) goto LAB_18093e83f;
                      in_stack_ffffffffffffff08 = (uint32 *)0;
                      HeroLittleTalkController.HeroTalk(lVar9,uVar7,uVar11,0x40c00000,0);
                    }
                  }
                  fVar18 = local_b0;
                  if (((this.treasureData == null) ||
                      (lVar9 = this.treasureData.treasureData) == null) ||
                     (lVar9 = lVar9.checkName) == null) goto LAB_18093e83f;
                  cVar2 = FUN_180133a50(lVar9,plVar5,DAT_181d806a0);
                  fVar18 = local_b0;
                  if (!cVar2) {
                    if ((this.treasureData == null) ||
                       (lVar9 = this.treasureData.treasureData) == null)
                    goto LAB_18093e83f;
                    lVar9.itemID = 0;
                  }
                  lVar9 = this.treasureData;
                  plVar5 = (int64 *)(uint64)(uVar14 + 1);
                  plVar15 = (int64 *)((int64)plVar15 + 1);
                  if (lVar9 == null) goto LAB_18093e83f;
                }
                if (!bVar1) goto LAB_18093d6b8;
                if (lVar9 != null) {
                  ItemData.CountValueAndWeight(lVar9,0);
                  goto LAB_18093da5b;
                }
              }
              goto LAB_18093e83f;
            }
          }
        LAB_18093d6b8:
          if (**(int **)(DAT_181d73d40 + 184) != 2) {
            fVar21 = (float)Random.get_value(0);
            if (fVar21 < 0.7) {
              uVar7 = this.playerIcon;
              lVar9 = **(int64 **)(DAT_181d761e8 + 184);
              if (*(float *)(this + 200) <= 1.0) {
                lVar10 = DrinkUIController.DrinkTalkText;
              }
              else {
                lVar10 = DrinkUIController.DirnkOverFillText;
              }
              fVar18 = local_b0;
              if (lVar10 == null) goto LAB_18093e83f;
              uVar20 = FUN_180d95a30(0,lVar10.summonLv,0);
              uVar11 = FUN_180002f80(lVar10,uVar20,DAT_181da4358);
              fVar18 = local_b0;
              if (lVar9 == null) goto LAB_18093e83f;
              HeroLittleTalkController.HeroTalk(lVar9,uVar7,uVar11,0x40400000,0);
              lVar9 = FUN_1807789e0(0);
              uVar7 = this.enemyIcon;
              if (this.enemyFillAmount <= 1.0) {
                lVar10 = DrinkUIController.DrinkTalkText;
              }
              else {
        LAB_18093d9bd:
                lVar10 = DrinkUIController.DirnkOverFillText;
              }
              fVar18 = local_b0;
              if (lVar10 == null) goto LAB_18093e83f;
              uVar20 = FUN_180d95a30(0,lVar10.summonLv,0);
              uVar11 = FUN_180002f80(lVar10,uVar20,DAT_181da4358);
            }
            else {
              lVar9 = DrinkUIController.DrinkPoemText;
              fVar18 = local_b0;
              if (lVar9 == null) goto LAB_18093e83f;
              uVar20 = FUN_180d95a30(0,lVar9.subType,0);
              lVar9 = FUN_180002f80(lVar9,uVar20,DAT_181da4358);
              lVar10 = FUN_1800d60b0(DAT_181da1040,1);
              fVar18 = local_b0;
              if (lVar10 == null) goto LAB_18093e83f;
              if (lVar10.summonLv == null) {
                uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar7,0);
              }
              lVar10.summonControlable = 0xff0c;
              if (lVar9 == null) goto LAB_18093e83f;
              lVar10 = String.Split(lVar9,lVar10,0);
              lVar9 = FUN_1807789e0(0);
              uVar7 = this.playerIcon;
              if (*(float *)(this + 200) <= 1.0) {
                fVar18 = local_b0;
                if (lVar10 == null) goto LAB_18093e83f;
                if (lVar10.summonLv == null) {
                  uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar7,0);
                }
                uVar11 = lVar10.summonControlable;
              }
              else {
                lVar12 = DrinkUIController.DirnkOverFillText;
                fVar18 = local_b0;
                if (lVar12 == null) goto LAB_18093e83f;
                uVar20 = FUN_180d95a30(0,*(uint32 *)(lVar12 + 24),0);
                uVar11 = FUN_180002f80(lVar12,uVar20,DAT_181da4358);
              }
              fVar18 = local_b0;
              if (lVar9 == null) goto LAB_18093e83f;
              HeroLittleTalkController.HeroTalk(lVar9,uVar7,uVar11,0x40400000,0);
              lVar9 = FUN_1807789e0(0);
              uVar7 = this.enemyIcon;
              if (1.0 < this.enemyFillAmount) goto LAB_18093d9bd;
              fVar18 = local_b0;
              if (lVar10 == null) goto LAB_18093e83f;
              if (lVar10.summonLv < 2) {
                uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar7,0);
              }
              uVar11 = lVar10.summonSourceHero;
            }
            fVar18 = local_b0;
            if (lVar9 == null) goto LAB_18093e83f;
            in_stack_ffffffffffffff08 = (uint32 *)0;
            HeroLittleTalkController.HeroTalk(lVar9,uVar7,uVar11,0x40400000,0);
          }
        LAB_18093da5b:
          fVar21 = (float)DrinkUIController.GetDrinkCost(this,*(uint32 *)(this + 200),0);
          lVar9 = FUN_18046c0a0(0);
          fVar18 = local_b0;
          if (((lVar9 == null) || (lVar9.name == null)) ||
             (lVar9 = WorldData.Player(lVar9.name,0), fVar18 = local_b0) == null)
          goto LAB_18093e83f;
          cVar2 = HeroData.HaveForceFunction(lVar9,0,0);
          if (!cVar2) {
            local_res18[0] = 1.0;
          }
          else {
            local_res18[0] = 0.8;
          }
          local_res18[0] = fVar21 * local_res18[0];
          if (local_res18[0] != 0.0) {
            lVar9 = FUN_18046c0a0(0);
            fVar18 = local_b0;
            if (((lVar9 == null) || (lVar9.name == null)) ||
               (lVar9 = WorldData.Player(lVar9.name,0), fVar18 = local_b0) == null)
            goto LAB_18093e83f;
            HeroData.ChangeMana
                      (lVar9,local_res18[0],1,1,(uint64)in_stack_ffffffffffffff08 & 0xffffffffffffff00,
                       0);
            fVar18 = local_b0;
            if ((this.playerIcon == null) ||
               (lVar9 = GameObject.GetComponent(this.playerIcon,DAT_181d71b50),
               fVar18 = local_b0, lVar9 == null)) goto LAB_18093e83f;
            HeroIconController.RefreshHeroIcon(lVar9,0);
            lVar9 = FUN_18046c0a0(0);
            uVar7 = Single.ToString(local_res18,"f0",0);
            uVar7 = String.Concat("内力",uVar7,0);
            fVar18 = local_b0;
            if ((this.playerIcon == null) ||
               (lVar10 = GameObject.get_transform(this.playerIcon,0), fVar18 = local_b0,
               lVar10 == null)) goto LAB_18093e83f;
            puVar6 = (uint64 *)Transform.get_position(local_a8,lVar10,0);
            uVar11 = *puVar6;
            local_b0 = *(float *)(puVar6 + 1);
            puVar6 = (uint64 *)Vector3.get_up(&local_98,0);
            local_c8 = CONCAT44((float)((uint64)*puVar6 >> 32) * 0.2 +
                                (float)((uint64)uVar11 >> 32),(float)*puVar6 * 0.2 + (float)uVar11);
            fVar21 = *(float *)(puVar6 + 1) * 0.2 + local_b0;
            local_b8 = uVar11;
            puVar4 = (uint32 *)Color.get_blue(&local_98,0);
            fVar18 = local_b0;
            if (lVar9 == null) goto LAB_18093e83f;
            local_98 = *puVar4;
            uStack_94 = puVar4[1];
            uStack_90 = puVar4[2];
            uStack_8c = puVar4[3];
            in_stack_ffffffffffffff08 = &local_98;
            local_b8 = local_c8;
            local_b0 = fVar21;
            GameController.ShowTextAtPos(lVar9,uVar7,&local_b8,26,in_stack_ffffffffffffff08,0);
          }
          lVar9 = FUN_18046c0a0(0);
          fVar18 = local_b0;
          if (((lVar9 == null) || (lVar9.name == null)) ||
             (lVar9 = WorldData.Player(lVar9.name,0), fVar18 = local_b0) == null)
          goto LAB_18093e83f;
          if (*(float *)(lVar9 + 400) <= 0.0) {
            this.playerLose = 1;
          }
          uVar7 = DrinkUIController.GetDrinkCost(this,this.enemyFillAmount,0);
          local_res20[0] = (float)uVar7;
          if (local_res20[0] != 0.0) {
            fVar18 = local_b0;
            if (this.enemyData == null) goto LAB_18093e83f;
            HeroData.ChangeMana
                      (this.enemyData,uVar7,1,1,
                       (uint64)in_stack_ffffffffffffff08 & 0xffffffffffffff00,0);
            fVar18 = local_b0;
            if ((this.enemyIcon == null) ||
               (lVar9 = GameObject.GetComponent(this.enemyIcon,DAT_181d71b50),
               fVar18 = local_b0, lVar9 == null)) goto LAB_18093e83f;
            HeroIconController.RefreshHeroIcon(lVar9,0);
            lVar9 = FUN_18046c0a0(0);
            uVar7 = Single.ToString(local_res20,"f0",0);
            uVar7 = String.Concat("内力",uVar7,0);
            fVar18 = local_b0;
            if ((this.enemyIcon == null) ||
               (lVar10 = GameObject.get_transform(this.enemyIcon,0), fVar18 = local_b0,
               lVar10 == null)) goto LAB_18093e83f;
            puVar6 = (uint64 *)Transform.get_position(&local_98,lVar10,0);
            uVar11 = *puVar6;
            fVar21 = *(float *)(puVar6 + 1);
            puVar6 = (uint64 *)Vector3.get_up(&local_98,0);
            local_b8 = *puVar6;
            local_b0 = *(float *)(puVar6 + 1);
            local_c8 = CONCAT44((float)((uint64)local_b8 >> 32) * 0.2 +
                                (float)((uint64)uVar11 >> 32),(float)local_b8 * 0.2 + (float)uVar11);
            fVar19 = local_b0 * 0.2;
            puVar4 = (uint32 *)Color.get_blue(&local_98,0);
            fVar18 = local_b0;
            if (lVar9 == null) goto LAB_18093e83f;
            local_98 = *puVar4;
            uStack_94 = puVar4[1];
            uStack_90 = puVar4[2];
            uStack_8c = puVar4[3];
            local_b8 = local_c8;
            local_b0 = fVar19 + fVar21;
            GameController.ShowTextAtPos(lVar9,uVar7,&local_b8,26,&local_98,0);
          }
          fVar18 = local_b0;
          if (this.enemyData == null) goto LAB_18093e83f;
          if (this.enemyData.mana <= 0.0) {
            this.enemyLose = 1;
          }
          if (*(float *)(this + 200) <= 1.0) {
            if (((this.playerBar == null) ||
                (lVar9 = GameObject.get_transform(this.playerBar,0), fVar18 = local_b0,
                lVar9 == null)) ||
               (lVar9 = Transform.Find(lVar9,"Cover",0), fVar18 = local_b0) == null)
            goto LAB_18093e83f;
            uVar7 = Component.GetComponent(lVar9,DAT_181d94460);
            DOTweenModuleUI.DOFillAmount(uVar7,0,0x3f000000,0);
          }
          if (this.enemyFillAmount <= 1.0) {
            fVar18 = local_b0;
            if (((this.enemyBar == null) ||
                (lVar9 = GameObject.get_transform(this.enemyBar,0), fVar18 = local_b0,
                lVar9 == null)) ||
               (lVar9 = Transform.Find(lVar9,"Cover",0), fVar18 = local_b0) == null)
            goto LAB_18093e83f;
            uVar7 = Component.GetComponent(lVar9,DAT_181d94460);
            DOTweenModuleUI.DOFillAmount(uVar7,0,0x3f000000,0);
          }
          this.drinkState = 5;
          DrinkUIController.SetNextButtonText(this,"下轮",0);
          plVar5 = (int64 *)Resources.Load("Sound/SoundEffect/Drink",0);
          if ((plVar5 != (int64 *)0) && (*plVar5 == DAT_181daf348)) {
            plVar8 = plVar5;
          }
          NGUITools.PlaySound(plVar8,0);
          break;
        case 5:
          *(uint32 *)(this + 200) = 0;
          DrinkUIController.SetFillAmount(this,this.playerBar,0,0);
          this.enemyFillAmount = 0;
          DrinkUIController.SetFillAmount(this,this.enemyBar,0,0);
          if ((!this.playerLose) && (!this.enemyLose)) {
            this.round = this.round + 1;
            this.drinkState = 2;
            fVar18 = local_b0;
            if (this.pourWaterAudio == null) goto LAB_18093e83f;
            AudioSource.Play(this.pourWaterAudio,0);
            uVar7 = "斟酒";
          }
          else {
            this.drinkState = 6;
            DrinkUIController.ManageDrinkBuff(this,0);
            fVar18 = local_b0;
            if ((this.drinkUIPanel == null) ||
               ((lVar9 = GameObject.get_transform(this.drinkUIPanel,0), fVar18 = local_b0,
                lVar9 == null ||
                (lVar9 = Transform.Find(lVar9,"FinalResult",0), fVar18 = local_b0) == null)))
            goto LAB_18093e83f;
            lVar9 = Component.get_gameObject(lVar9,0);
            fVar18 = local_b0;
            if (lVar9 == null) goto LAB_18093e83f;
            GameObject.SetActive(lVar9,1,0);
            fVar18 = local_b0;
            if (((this.drinkUIPanel == null) ||
                (lVar9 = GameObject.get_transform(this.drinkUIPanel,0), fVar18 = local_b0,
                lVar9 == null)) ||
               (lVar9 = Transform.Find(lVar9,"FinalResult",0), fVar18 = local_b0) == null)
            goto LAB_18093e83f;
            lVar9 = Component.GetComponent(lVar9,DAT_181d94460);
            if (!this.enemyLose) {
              lVar10 = FUN_18046bb80(0);
              fVar18 = local_b0;
              if (lVar10 == null) goto LAB_18093e83f;
              uVar7 = lVar10.dodgeSkillSaveRecord;
            }
            else {
              lVar10 = FUN_18046bb80(0);
              fVar18 = local_b0;
              if (lVar10 == null) goto LAB_18093e83f;
              uVar7 = lVar10.internalSkill;
            }
            fVar18 = local_b0;
            if (lVar9 == null) goto LAB_18093e83f;
            Image.set_sprite(lVar9,uVar7,0);
            fVar18 = local_b0;
            if ((this.drinkUIPanel == null) ||
               (lVar9 = GameObject.get_transform(this.drinkUIPanel,0), fVar18 = local_b0,
               lVar9 == null)) goto LAB_18093e83f;
            lVar9 = Transform.Find(lVar9,"FinalResult",0);
            puVar6 = (uint64 *)Vector3.get_one(&local_98,0);
            local_b8 = *puVar6;
            local_b0 = *(float *)(puVar6 + 1) * 5.0;
            local_c8 = CONCAT44((float)((uint64)local_b8 >> 32) * 5.0,(float)local_b8 * 5.0);
            fVar18 = *(float *)(puVar6 + 1);
            if (lVar9 == null) goto LAB_18093e83f;
            local_b8 = local_c8;
            Transform.set_localScale(lVar9,&local_b8,0);
            fVar18 = local_b0;
            if ((this.drinkUIPanel == null) ||
               (lVar9 = GameObject.get_transform(this.drinkUIPanel,0), fVar18 = local_b0,
               lVar9 == null)) goto LAB_18093e83f;
            uVar7 = Transform.Find(lVar9,"FinalResult",0);
            uVar7 = ShortcutExtensions.DOScale(uVar7,0x3f800000,0x3e99999a,0);
            uVar7 = TweenSettingsExtensions.SetDelay(uVar7,0x3dcccccd,DAT_181dc0c60);
            TweenSettingsExtensions.SetEase(uVar7,9,DAT_181dc0f80);
            uVar7 = "FightWin";
            if (!this.enemyLose) {
              uVar7 = "FightLose";
            }
            uVar7 = String.Concat("Sound/SoundEffect/",uVar7,0);
            plVar8 = (int64 *)Resources.Load(uVar7,0);
            plVar5 = (int64 *)0;
            if ((plVar8 != (int64 *)0) && (*plVar8 == DAT_181daf348)) {
              plVar5 = plVar8;
            }
            NGUITools.PlaySound(plVar5,0);
            uVar7 = "散席";
          }
          DrinkUIController.SetNextButtonText(this,uVar7,0);
          break;
        case 6:
          if (this.drinkType == null) {
            fVar21 = 1.0;
          }
          else {
            fVar21 = 0.5;
          }
          lVar9 = FUN_18046c0a0(0);
          fVar18 = local_b0;
          if (((lVar9 == null) || (lVar9.name == null)) ||
             (lVar9 = WorldData.Player(lVar9.name,0), fVar18 = local_b0) == null)
          goto LAB_18093e83f;
          cVar2 = HeroData.HaveForceFunction(lVar9,0,0);
          uVar3 = "draw";
          uVar11 = "lose";
          uVar20 = (uint32)((uint64)in_stack_ffffffffffffff08 >> 32);
          if (!cVar2) {
            fVar19 = 1.0;
          }
          else {
            fVar19 = 1.2;
          }
          uVar13 = 0;
          if (!this.playerLose) {
            if (this.enemyLose) {
              lVar9 = FUN_18046c100(0);
              fVar18 = local_b0;
              if (lVar9 == null) goto LAB_18093e83f;
              GameDataController.ChangeAchStats(lVar9,3,0x3f800000);
              uVar3 = "win";
              lVar9 = FUN_18046c400(0);
              fVar18 = this.extraWineRate + 1.0 + this.extraFoodRate +
                       this.extraTreasureRate;
              goto LAB_18093e5bc;
            }
          }
          else {
            if (!this.enemyLose) {
              lVar9 = FUN_18046c400(0);
              fVar18 = (this.extraWineRate + 1.0 + this.extraFoodRate +
                       this.extraTreasureRate) * 0.5;
              uVar3 = uVar11;
            }
            else {
              lVar9 = FUN_18046c400(0);
              fVar18 = (this.extraWineRate + 1.0 + this.extraFoodRate +
                       this.extraTreasureRate) * 0.75;
            }
        LAB_18093e5bc:
            uVar7 = this.enemyData;
            fVar16 = (float)Mathf.Min(0x41a00000,fVar18,0);
            fVar18 = local_b0;
            if (lVar9 == null) goto LAB_18093e83f;
            uVar22 = (uint64)in_stack_ffffffffffffff08 & 0xffffffff00000000;
            PlotController.PlotChangeHeroFavor
                      (lVar9,uVar7,fVar16 * fVar19 * fVar21,0x42c80000,uVar22,
                       in_stack_ffffffffffffff10 & 0xffffffffffffff00,0);
            uVar20 = (uint32)(uVar22 >> 32);
            uVar7 = uVar3;
          }
          if (this.fightEndCallFuc != null) {
            cVar2 = String.op_Inequality(this.fightEndCallFuc,"",0);
            if (cVar2) {
              lVar9 = FUN_18046c400(0);
              fVar18 = local_b0;
              if (lVar9 == null) goto LAB_18093e83f;
              Component.SendMessage(lVar9,this.fightEndCallFuc,uVar7,0);
            }
          }
          lVar9 = this.enemyData;
          uVar7 = this.wineData;
          uVar11 = uVar13;
          if (this.drinkType == null) {
            lVar10 = FUN_18046c0a0(0);
            fVar18 = local_b0;
            if ((lVar10 == null) || (lVar10.summonControlable == null)) goto LAB_18093e83f;
            uVar11 = WorldData.Player(lVar10.summonControlable,0);
          }
          fVar18 = local_b0;
          if (lVar9 == null) {
        LAB_18093e83f:
            local_b0 = fVar18;
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          uVar3 = CONCAT44(uVar20,0x3f000000);
          HeroData.CosumeMedFood(lVar9,uVar7,1,uVar11,uVar3,0);
          uVar20 = (uint32)((uint64)uVar3 >> 32);
          lVar9 = FUN_18046c0a0(0);
          fVar18 = local_b0;
          if (((lVar9 == null) || (lVar9.name == null)) ||
             (lVar9 = WorldData.Player(lVar9.name,0), fVar18 = local_b0) == null)
          goto LAB_18093e83f;
          uVar7 = CONCAT44(uVar20,0x3f000000);
          HeroData.CosumeMedFood(lVar9,this.wineData,1,0,uVar7,0);
          uVar20 = (uint32)((uint64)uVar7 >> 32);
          lVar9 = this.foodData;
          if (lVar9 != null) {
            lVar10 = this.enemyData;
            if (this.drinkType == null) {
              lVar12 = FUN_18046c0a0(0);
              fVar18 = local_b0;
              if ((lVar12 == null) || (*(int64 *)(lVar12 + 32) == 0)) goto LAB_18093e83f;
              uVar13 = WorldData.Player(*(int64 *)(lVar12 + 32),0);
            }
            fVar18 = local_b0;
            if (lVar10 == null) goto LAB_18093e83f;
            uVar7 = CONCAT44(uVar20,0x3f000000);
            HeroData.CosumeMedFood(lVar10,lVar9,1,uVar13,uVar7,0);
            uVar20 = (uint32)((uint64)uVar7 >> 32);
            lVar9 = FUN_18046c0a0(0);
            fVar18 = local_b0;
            if (((lVar9 == null) || (lVar9.name == null)) ||
               (lVar9 = WorldData.Player(lVar9.name,0), fVar18 = local_b0) == null)
            goto LAB_18093e83f;
            HeroData.CosumeMedFood
                      (lVar9,this.foodData,1,0,CONCAT44(uVar20,0x3f000000),0);
          }
          DrinkUIController.HideDrinkUI(this,0);
          break;
        default:
          goto switchD_18093d048_default;
        }
        switchD_18093d048_default:
    }

    // Token : 0x60013D4
    // RVA   : 0x93C8B0   Offset: 0x93BCB0   Length: 0x50E
    public void ManageDrinkBuff()
    {
        float fVar1;
        bool cVar2;
        long lVar3;
        long lVar4;
        lVar3 = this.enemyData;
        if (lVar3 != null) {
          if (lVar3.totalWinFightCount / lVar3.maxMana < 0.8) {
            HeroData.AddTag(lVar3,0x14d - (int)((lVar3.totalWinFightCount * 5.0) /
                                                lVar3.maxMana),0x40800000,0,0,1,0);
          }
          if (((GameController._instance != null) &&
              (lVar3 = GameController._instance.worldData) != null) &&
             (lVar3 = WorldData.Player(lVar3,0)) != null) {
            fVar1 = lVar3.totalWinFightCount;
            if (((GameController._instance != null) &&
                (lVar3 = GameController._instance.worldData) != null) &&
               (lVar3 = WorldData.Player(lVar3,0)) != null) {
              if (fVar1 / lVar3.maxMana < 0.8) {
                if ((GameController._instance == null) ||
                   (lVar3 = GameController._instance.worldData) == null)
                throw; // [null/range check failed]
                lVar3 = WorldData.Player(lVar3,0);
                if (((GameController._instance == null) ||
                    (lVar4 = GameController._instance.worldData) == null) ||
                   (lVar4 = WorldData.Player(lVar4,0)) == null) throw; // [null/range check failed]
                fVar1 = lVar4.totalWinFightCount;
                if (((GameController._instance == null) ||
                    (lVar4 = GameController._instance.worldData) == null) ||
                   ((lVar4 = WorldData.Player(lVar4,0), lVar4 == null || (lVar3 == null)))) throw; // [null/range check failed]
                HeroData.AddTag(lVar3,0x14d - (int)((fVar1 * 5.0) / lVar4.totalEnemyKilled),0x40800000
                                 ,0,1,1,0);
              }
              if (((GameController._instance != null) &&
                  (lVar3 = GameController._instance.worldData) != null) &&
                 (lVar3 = WorldData.Player(lVar3,0)) != null) {
                cVar2 = HeroData.HaveForceFunction(lVar3,0,0);
                if (!cVar2) {
                  return;
                }
                if (((GameController._instance != null) &&
                    (lVar3 = GameController._instance.worldData) != null) &&
                   (lVar3 = WorldData.Player(lVar3,0)) != null) {
                  HeroData.GetWineSpeBuff(lVar3,this.wineData,0);
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x60013D5
    // RVA   : 0x93C570   Offset: 0x93B970   Length: 0x1B
    public float GetTotalExtraRate()
    {
        float FUN_18093c570(int64 this)
        {
        return this.extraWineRate + 1.0 + this.extraFoodRate + this.extraTreasureRate;
    }

    // Token : 0x60013D6
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

    // Token : 0x60013D7
    // RVA   : 0x940090   Offset: 0x93F490   Length: 0x662
    private static void /*cctor*/()
    {
        long lVar1;
        **(uint32 **)(DAT_181dc2568 + 184) = 0x3fa00000;
        lVar1 = il2cpp_internal(DAT_181d97750);
        FUN_18132faf0(lVar1,DAT_181da3bd8);
        if (lVar1 != null) {
          FUN_18181e0a0(lVar1,"把酒撒出来，这杯可就不作数了",DAT_181da3d58);
          FUN_18181e0a0(lVar1,"月盈则亏，水满则溢，这杯酒喝不得",DAT_181da3d58);
          FUN_18181e0a0(lVar1,"按照规矩，这溢出来的酒可不用喝",DAT_181da3d58);
          DrinkUIController.DirnkOverFillText = lVar1;
          lVar1 = il2cpp_internal(DAT_181d97750);
          FUN_18132faf0(lVar1,DAT_181da3bd8);
          if (lVar1 != null) {
            FUN_18181e0a0(lVar1,"一杯一杯又一杯",DAT_181da3d58);
            FUN_18181e0a0(lVar1,"酒不醉人人自醉",DAT_181da3d58);
            FUN_18181e0a0(lVar1,"来来来！把酒斟上！",DAT_181da3d58);
            FUN_18181e0a0(lVar1,"我没醉！我还能喝！",DAT_181da3d58);
            FUN_18181e0a0(lVar1,"天旋地转",DAT_181da3d58);
            FUN_18181e0a0(lVar1,"嗝~",DAT_181da3d58);
            FUN_18181e0a0(lVar1,"喝喝喝！",DAT_181da3d58);
            FUN_18181e0a0(lVar1,"人在江湖走，哪能不喝酒",DAT_181da3d58);
            FUN_18181e0a0(lVar1,"酒逢知已千杯少",DAT_181da3d58);
            FUN_18181e0a0(lVar1,"万水千山总是情，少喝一杯可不行",DAT_181da3d58);
            FUN_18181e0a0(lVar1,"一切尽在不言中",DAT_181da3d58);
            FUN_18181e0a0(lVar1,"咕嘟咕嘟咕嘟",DAT_181da3d58);
            FUN_18181e0a0(lVar1,"哈~真是好酒！",DAT_181da3d58);
            FUN_18181e0a0(lVar1,"斟酒之时，可不能厚此薄彼！",DAT_181da3d58);
            FUN_18181e0a0(lVar1,"天下英雄，唯你我二人耳~",DAT_181da3d58);
            FUN_18181e0a0(lVar1,"习武之人若不喝上两盅，手脚便没有力气",DAT_181da3d58);
            FUN_18181e0a0(lVar1,"一饮而尽才是真英雄好汉",DAT_181da3d58);
            FUN_18181e0a0(lVar1,"干杯！",DAT_181da3d58);
            FUN_18181e0a0(lVar1,"我先干为敬！",DAT_181da3d58);
            FUN_18181e0a0(lVar1,"将进酒，杯莫停！杯莫停！",DAT_181da3d58);
            FUN_18181e0a0(lVar1,"纵横酒场多年未逢对手",DAT_181da3d58);
            DrinkUIController.DrinkTalkText = lVar1;
            lVar1 = il2cpp_internal(DAT_181d97750);
            FUN_18132faf0(lVar1,DAT_181da3bd8);
            if (lVar1 != null) {
              FUN_18181e0a0(lVar1,"天子呼来不上船，自称臣是酒中仙。",DAT_181da3d58);
              FUN_18181e0a0(lVar1,"抽刀断水水更流，举杯消愁愁更愁",DAT_181da3d58);
              FUN_18181e0a0(lVar1,"举杯邀明月，对饮成三人",DAT_181da3d58);
              FUN_18181e0a0(lVar1,"两人对酌山花开，一杯一杯复一杯",DAT_181da3d58);
              FUN_18181e0a0(lVar1,"满堂花醉三千客，一剑霜寒十四州",DAT_181da3d58);
              FUN_18181e0a0(lVar1,"举世皆浊我独清，众人皆醉我独醒",DAT_181da3d58);
              FUN_18181e0a0(lVar1,"葡萄美酒夜光杯，欲饮琵琶马上催",DAT_181da3d58);
              FUN_18181e0a0(lVar1,"想当年金戈铁马，气吞万里如虎",DAT_181da3d58);
              FUN_18181e0a0(lVar1,"何以解忧，唯有杜康",DAT_181da3d58);
              FUN_18181e0a0(lVar1,"劝君更尽一杯酒，西出阳关无故人",DAT_181da3d58);
              FUN_18181e0a0(lVar1,"对酒当歌，人生几何？",DAT_181da3d58);
              FUN_18181e0a0(lVar1,"人生得意须尽欢，莫使金樽空对月",DAT_181da3d58);
              FUN_18181e0a0(lVar1,"酒入愁肠，化作相思泪",DAT_181da3d58);
              FUN_18181e0a0(lVar1,"浊酒一杯家万里，燕然未勒归无计",DAT_181da3d58);
              FUN_18181e0a0(lVar1,"桃李春风一杯酒，江湖夜雨十年灯",DAT_181da3d58);
              DrinkUIController.DrinkPoemText = lVar1;
              return;
            }
          }
        }
    }

}
