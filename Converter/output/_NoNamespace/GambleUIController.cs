// ============================================================
// Type  : GambleUIController
// Token : 0x2000290
// ============================================================

public class GambleUIController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001403
    public HeroData enemyData;

    // Token: 0x4001404
    public GameObject gambleUIPanel;

    // Token: 0x4001405
    public GameObject nextButton;

    // Token: 0x4001406
    public Toggle defaultBetButton;

    // Token: 0x4001407
    public GambleState gambleState;

    // Token: 0x4001408
    public GameObject playerIcon;

    // Token: 0x4001409
    public GameObject enemyIcon;

    // Token: 0x400140A
    public List<Sprite> diceSprite;

    // Token: 0x400140B
    public int round;

    // Token: 0x400140C
    public int playerWinCount;

    // Token: 0x400140D
    public int enemyWinCount;

    // Token: 0x400140E
    public List<int> playerDiceResult;

    // Token: 0x400140F
    public int playerDiceResultLv;

    // Token: 0x4001410
    public int playerDiceResultTotal;

    // Token: 0x4001411
    public List<int> enemyDiceResult;

    // Token: 0x4001412
    public int enemyDiceResultLv;

    // Token: 0x4001413
    public int enemyDiceResultTotal;

    // Token: 0x4001414
    public GambleResult gambleResult;

    // Token: 0x4001415
    public int betNumID;

    // Token: 0x4001416
    private static List<string> diceResultLvName;

    // Token: 0x4001417
    private static List<int> betLvNum;

    // Token: 0x4001418
    private static List<string> GambleTalkText;

    // Token: 0x4001419
    private static List<string> GambleWinTalkText;

    // Token: 0x400141A
    private static List<string> GambleLoseTalkText;

    // Token: 0x400141B
    public string fightEndCallFuc;

    // Token: 0x400141C
    private List<GambleResult> gambleResults;

    // Token: 0x400141D
    private GameObject temp;

    // Token: 0x400141E
    private static GambleUIController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60014B6
    // RVA   : 0x78F040   Offset: 0x78D840   Length: 0x58
    public static GambleUIController get_Instance()
    {
        return *(uint64 *)(*(int64 *)(DAT_181d4de90 + 184) + 40);
    }

    // Token : 0x60014B7
    // RVA   : 0x788B50   Offset: 0x787350   Length: 0x68
    private void Awake()
    {
        puVar1 = (uint64 *)(*(int64 *)(DAT_181d4de90 + 184) + 40);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x60014B8
    // RVA   : 0x78E890   Offset: 0x78D090   Length: 0xF9
    private void Update()
    {
        int iVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        if (this.gambleState == null) {
          return;
        }
        if (((this.gambleUIPanel != null) &&
            (lVar2 = GameObject.get_transform(this.gambleUIPanel,0)) != null) &&
           (lVar2 = Transform.Find(lVar2,"Round",0)) != null) {
          uVar3 = Component.GetComponent(lVar2,DAT_181d6d8c0);
          iVar1 = this.round;
          uVar4 = GlobalData.GetNumText(iVar1 + 1,0);
          uVar4 = String.Format("第{0}轮",uVar4,0);
          LTLocalization.SetText(uVar3,uVar4,0);
          return;
        }
    }

    // Token : 0x60014B9
    // RVA   : 0x78DD90   Offset: 0x78C590   Length: 0x7C0
    public void ShowGambleUI(HeroData _enemyData, string _fightEndCallFuc)
    {
        var pStatics_8ad8 = *(int64*)(DAT_181d88ad8 + 184);
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        var pStatics_e188 = *(int64*)(DAT_181d4e188 + 184);
        long lVar2;
        long lVar3;
        ulong uVar4;
        ulong uVar5;
        int iVar6;
        int[] local_res8 = new int[2];
        uint[] local_28 = new uint[4];
        bVar7 = !DAT_181e75816;
        local_res8[0] = 0;
        local_28[0] = 0;
        this.round = 0;
        this.enemyWinCount = 0;
        if (bVar7) {
          il2cpp_runtime_class_init(&DAT_181d617f8);
          il2cpp_runtime_class_init(&DAT_181d618f8);
          DAT_181e75816 = true;
        }
        lVar3 = this.gambleResults;
        iVar6 = 0;
        while (lVar3 != null) {
          if (lVar3.Count <= iVar6) {
            GambleUIController.RefreshRoundIcon(this,0);
            if (this.gambleUIPanel != null) {
              GameObject.SetActive(this.gambleUIPanel,1,0);
              this.fightEndCallFuc = _fightEndCallFuc;
              this.gambleState = 1;
              if (((this.gambleUIPanel != null) &&
                  (lVar3 = GameObject.get_transform(this.gambleUIPanel,0)) != null) &&
                 (lVar3 = Transform.Find(lVar3,"PlayerIcon",0)) != null) {
                uVar4 = Component.get_gameObject(lVar3,0);
                if (*pStatics_e188 != 0) {
                  uVar5 = *(uint64 *)(*pStatics_e188 + 144);
                  lVar3 = GlobalData.AddChild(uVar4,uVar5,0);
                  this.temp = lVar3;
                  if (*plVar1 != 0) {
                    lVar3 = GameObject.GetComponent(*plVar1,DAT_181d9fb20);
                    if (((*pStatics_df90 != 0) &&
                        (lVar2 = *(int64 *)(*pStatics_df90 + 32)) != null)
                       && (uVar4 = WorldData.Player(lVar2,0), lVar3 != null)) {
                      *(uint64 *)(lVar3 + 32) = uVar4;
                      if ((*plVar1 != 0) &&
                         (lVar3 = GameObject.GetComponent(*plVar1,DAT_181d9fb20)) != null) {
                        lVar3.Count = 0;
                        if ((*plVar1 != 0) &&
                           (lVar3 = GameObject.GetComponent(*plVar1,DAT_181d9fb20)) != null) {
                          *(uint8 *)(lVar3 + 88) = 1;
                          this.playerIcon = *plVar1;
                          this.enemyData = _enemyData;
                          if (((this.gambleUIPanel != null) &&
                              (lVar3 = GameObject.get_transform(this.gambleUIPanel,0),
                              lVar3 != null)) && (lVar3 = Transform.Find(lVar3,"EnemyIcon",0)) != null
                             ) {
                            uVar4 = Component.get_gameObject(lVar3,0);
                            if (*pStatics_e188 != 0) {
                              lVar3 = GlobalData.AddChild
                                                (uVar4,*(uint64 *)
                                                        (*pStatics_e188 + 144),0);
                              *plVar1 = lVar3;
                              il2cpp_internal(plVar1,lVar3);
                              if (*plVar1 != 0) {
                                lVar3 = GameObject.GetComponent(*plVar1,DAT_181d9fb20);
                                if (lVar3 != null) {
                                  *(uint64 *)(lVar3 + 32) = this.enemyData;
                                  if ((*plVar1 != 0) &&
                                     (lVar3 = GameObject.GetComponent(*plVar1,DAT_181d9fb20)) != null
                                     ) {
                                    lVar3.Count = 0;
                                    if ((*plVar1 != 0) &&
                                       (lVar3 = GameObject.GetComponent(*plVar1,DAT_181d9fb20),
                                       lVar3 != null)) {
                                      *(uint8 *)(lVar3 + 88) = 1;
                                      this.enemyIcon = *plVar1;
                                      iVar6 = 0;
                                      goto LAB_18078e250;
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
            break;
          }
          if (lVar3 == null) break;
          FUN_18181e970(lVar3,iVar6);
          iVar6 = iVar6 + 1;
          lVar3 = this.gambleResults;
        }
        LAB_18078e54b:
                          // WARNING: Subroutine does not return
        FUN_1800d6620();
        LAB_18078e250:
        lVar3 = *(int64 *)(*(int64 *)(DAT_181d4de90 + 184) + 8);
        if (lVar3 == null) goto LAB_18078e54b;
        lVar2 = this.gambleUIPanel;
        if (lVar3.Count <= iVar6) {
          if ((((lVar2 != null) && (lVar3 = GameObject.get_transform(lVar2,0)) != null) &&
              (lVar3 = Transform.Find(lVar3,"BetTab",0)) != null) &&
             (lVar3 = Component.get_gameObject(lVar3,0)) != null) {
            GameObject.SetActive(lVar3,0,0);
            if (((this.gambleUIPanel != null) &&
                (lVar3 = GameObject.get_transform(this.gambleUIPanel,0)) != null) &&
               ((lVar3 = Transform.Find(lVar3,"RerollButton",0), lVar3 != null &&
                (lVar3 = Component.get_gameObject(lVar3,0)) != null))) {
              GameObject.SetActive(lVar3,0,0);
              GambleUIController.SetBetButtonActive(this,0,0);
              uVar4 = "开始";
              if (((this.nextButton != null) &&
                  (lVar3 = GameObject.get_transform(this.nextButton,0)) != null) &&
                 (lVar3 = Transform.Find(lVar3,"Label",0)) != null) {
                uVar5 = Component.GetComponent(lVar3,DAT_181d6d8c0);
                LTLocalization.SetText(uVar5,uVar4,0);
                if ((this.nextButton != null) &&
                   (lVar3 = GameObject.GetComponent(this.nextButton,DAT_181d9ee60),
                   lVar3 != null)) {
                  Selectable.set_interactable(lVar3,1,0);
                  if (*pStatics_8ad8 != 0) {
                    TutorialController.StartTutorial
                              (*pStatics_8ad8,"博骰教程",0);
                    return;
                  }
                }
              }
            }
          }
          goto LAB_18078e54b;
        }
        if ((lVar2 == null) || (lVar3 = GameObject.get_transform(lVar2,0)) == null) goto LAB_18078e54b;
        lVar3 = Transform.Find(lVar3,"BetTab",0);
        uVar4 = Int32.ToString(local_res8,0);
        if ((lVar3 == null) ||
           ((lVar3 = Transform.Find(lVar3,uVar4,0), lVar3 == null ||
            (lVar3 = Transform.Find(lVar3,"Label",0)) == null))) goto LAB_18078e54b;
        uVar4 = Component.GetComponent(lVar3,DAT_181d6d8c0);
        local_28[0] = GambleUIController.GetBetMoney(this,local_res8[0]);
        uVar5 = Int32.ToString(local_28,0);
        uVar5 = String.Concat(uVar5,"两");
        LTLocalization.SetText(uVar4,uVar5);
        local_res8[0] = local_res8[0] + 1;
        iVar6 = local_res8[0];
        goto LAB_18078e250;
    }

    // Token : 0x60014BA
    // RVA   : 0x788C40   Offset: 0x787440   Length: 0x177
    public int GetBetMoney(int betLv, int enemyLv)
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        int iVar1;
        bool cVar2;
        int iVar3;
        long lVar4;
        if (enemyLv == -1) {
          if (this.enemyData == null) throw; // [null/range check failed]
          enemyLv = this.enemyData.heroForceLv;
        }
        lVar4 = *(int64 *)(*(int64 *)(DAT_181d4de90 + 184) + 8);
        if (lVar4 != null) {
          if (*(uint32 *)(lVar4 + 24) <= betLv) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          iVar1 = lVar4[betLv];
          if ((*pStatics != 0) &&
             (lVar4 = *(int64 *)(*pStatics + 32)) != null) {
            lVar4 = WorldData.Player(lVar4,0);
            if (lVar4 != null) {
              cVar2 = HeroData.HaveForceFunction(lVar4,0,0);
              iVar3 = enemyLv * 2 + 2;
              if (!cVar2) {
                iVar3 = enemyLv + 1;
              }
              return iVar3 * iVar1;
            }
          }
        }
    }

    // Token : 0x60014BB
    // RVA   : 0x789180   Offset: 0x787980   Length: 0xD
    public int GetMinBetMoney(int enemyLv)
    {
        GambleUIController.GetBetMoney(this,0,enemyLv,0);
    }

    // Token : 0x60014BC
    // RVA   : 0x789190   Offset: 0x787990   Length: 0x11C
    public void HideGambleUI()
    {
        long lVar1;
        ulong uVar2;
        if (this.gambleUIPanel != null) {
          GameObject.SetActive(this.gambleUIPanel,0,0);
          this.gambleState = 0;
          if (this.gambleUIPanel != null) {
            lVar1 = GameObject.get_transform(this.gambleUIPanel,0);
            if (lVar1 != null) {
              lVar1 = Transform.Find(lVar1,"PlayerIcon",0);
              if (lVar1 != null) {
                uVar2 = Component.get_gameObject(lVar1,0);
                GlobalData.DeleteAllChild(uVar2,0);
                if (this.gambleUIPanel != null) {
                  lVar1 = GameObject.get_transform(this.gambleUIPanel,0);
                  if (lVar1 != null) {
                    lVar1 = Transform.Find(lVar1,"EnemyIcon",0);
                    if (lVar1 != null) {
                      uVar2 = Component.get_gameObject(lVar1,0);
                      GlobalData.DeleteAllChild(uVar2,0);
                      return;
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x60014BD
    // RVA   : 0x78D5F0   Offset: 0x78BDF0   Length: 0x88
    public void ResetGambleResults()
    {
        long lVar1;
        int iVar2;
        iVar2 = 0;
        lVar1 = this.gambleResults;
        while (lVar1 != null) {
          if (lVar1.Count <= iVar2) {
            return;
          }
          if (lVar1 == null) break;
          FUN_18181e970(lVar1,iVar2,0,DAT_181d618f8);
          iVar2 = iVar2 + 1;
          lVar1 = this.gambleResults;
        }
    }

    // Token : 0x60014BE
    // RVA   : 0x78C4F0   Offset: 0x78ACF0   Length: 0x3B2
    public void RefreshRoundIcon()
    {
        int iVar1;
        long lVar2;
        ulong uVar3;
        uint uVar6;
        uint[] local_res8 = new uint[2];
        uint local_58;
        uint uStack_54;
        uint uStack_50;
        uint32 uStack_4c;
        uint8 local_48 [16];
        uint8 local_38 [16];
        uint8 local_28 [16];
        uint8 local_18 [16];
        lVar2 = this.gambleResults;
        local_res8[0] = 0;
        uVar6 = local_res8[0];
        while (local_res8[0] = uVar6, lVar2 != null) {
          if (lVar2.Count <= (int)uVar6) {
            return;
          }
          if (lVar2 == null) break;
          if (lVar2.Count <= uVar6) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          iVar1 = lVar2._items[uVar6];
          if (iVar1 == 0) {
            if ((this.gambleUIPanel == null) ||
               (lVar2 = GameObject.get_transform(this.gambleUIPanel,0)) == null) break;
            lVar2 = Transform.Find(lVar2,"RoundIcon",0);
            uVar3 = Int32.ToString(local_res8,0);
            if ((lVar2 == null) ||
               ((lVar2 = Transform.Find(lVar2,uVar3,0), lVar2 == null ||
                (lVar2 = Transform.Find(lVar2,"Result",0)) == null))) break;
            plVar4 = (int64 *)Component.GetComponent(lVar2,DAT_181d6bc40);
            puVar5 = (uint32 *)FUN_180d904c0(local_18,0);
        LAB_18078c83b:
            if (plVar4 == (int64 *)0) break;
            local_58 = *puVar5;
            uStack_54 = puVar5[1];
            uStack_50 = puVar5[2];
            uStack_4c = puVar5[3];
            (**(code **)(*plVar4 + 0x2a8))(plVar4,&local_58,*(uint64 *)(*plVar4 + 0x2b0));
          }
          else {
            if (iVar1 == 1) {
              if ((this.gambleUIPanel != null) &&
                 (lVar2 = GameObject.get_transform(this.gambleUIPanel,0)) != null) {
                lVar2 = Transform.Find(lVar2,"RoundIcon",0);
                uVar3 = Int32.ToString(local_res8,0);
                if ((lVar2 != null) &&
                   ((lVar2 = Transform.Find(lVar2,uVar3,0), lVar2 != null &&
                    (lVar2 = Transform.Find(lVar2,"Result",0)) != null))) {
                  plVar4 = (int64 *)Component.GetComponent(lVar2,DAT_181d6bc40);
                  puVar5 = (uint32 *)Color.get_green(local_28,0);
                  goto LAB_18078c83b;
                }
              }
              break;
            }
            if (iVar1 == 2) {
              if ((this.gambleUIPanel != null) &&
                 (lVar2 = GameObject.get_transform(this.gambleUIPanel,0)) != null) {
                lVar2 = Transform.Find(lVar2,"RoundIcon",0);
                uVar3 = Int32.ToString(local_res8,0);
                if ((lVar2 != null) &&
                   ((lVar2 = Transform.Find(lVar2,uVar3,0), lVar2 != null &&
                    (lVar2 = Transform.Find(lVar2,"Result",0)) != null))) {
                  plVar4 = (int64 *)Component.GetComponent(lVar2,DAT_181d6bc40);
                  puVar5 = (uint32 *)Color.get_red(local_38,0);
                  goto LAB_18078c83b;
                }
              }
              break;
            }
            if (iVar1 == 3) {
              if ((this.gambleUIPanel != null) &&
                 (lVar2 = GameObject.get_transform(this.gambleUIPanel,0)) != null) {
                lVar2 = Transform.Find(lVar2,"RoundIcon",0);
                uVar3 = Int32.ToString(local_res8,0);
                if ((lVar2 != null) &&
                   ((lVar2 = Transform.Find(lVar2,uVar3,0), lVar2 != null &&
                    (lVar2 = Transform.Find(lVar2,"Result",0)) != null))) {
                  plVar4 = (int64 *)Component.GetComponent(lVar2,DAT_181d6bc40);
                  puVar5 = (uint32 *)Color.get_yellow(local_48,0);
                  goto LAB_18078c83b;
                }
              }
              break;
            }
          }
          uVar6 = local_res8[0] + 1;
          lVar2 = this.gambleResults;
        }
    }

    // Token : 0x60014BF
    // RVA   : 0x788BC0   Offset: 0x7873C0   Length: 0x78
    public void BetButtonClicked(GameObject buttonClicked)
    {
        ulong uVar1;
        uint uVar2;
        long lVar3;
        if (buttonClicked != null) {
          lVar3 = GameObject.GetComponent(buttonClicked,DAT_181da2130);
          if (lVar3 != null) {
            if (*(char *)(lVar3 + 0x118) != false) {
              uVar1 = Object.get_name(buttonClicked,0);
              uVar2 = Int32.Parse(uVar1,0);
              this.betNumID = uVar2;
            }
            return;
          }
        }
    }

    // Token : 0x60014C0
    // RVA   : 0x78DB20   Offset: 0x78C320   Length: 0x90
    public void SetNextButtonText(string _text)
    {
        long lVar1;
        ulong uVar2;
        if (this.nextButton != null) {
          lVar1 = GameObject.get_transform(this.nextButton,0);
          if (lVar1 != null) {
            lVar1 = Transform.Find(lVar1,"Label",0);
            if (lVar1 != null) {
              uVar2 = Component.GetComponent(lVar1,DAT_181d6d8c0);
              LTLocalization.SetText(uVar2,_text,0);
              return;
            }
          }
        }
    }

    // Token : 0x60014C1
    // RVA   : 0x78DAB0   Offset: 0x78C2B0   Length: 0x64
    public void SetNextButtonActive(bool _interactable)
    {
        long lVar1;
        if (this.nextButton != null) {
          lVar1 = GameObject.GetComponent(this.nextButton,DAT_181d9ee60);
          if (lVar1 != null) {
            Selectable.set_interactable(lVar1,_interactable,0);
            return;
          }
        }
    }

    // Token : 0x60014C2
    // RVA   : 0x78D680   Offset: 0x78BE80   Length: 0x42F
    public void SetBetButtonActive(bool _interactable)
    {
        int iVar1;
        bool cVar2;
        int iVar3;
        long lVar4;
        ulong uVar5;
        long lVar6;
        uint uVar10;
        uint uVar11;
        uint uVar12;
        uint uVar13;
        int[] local_res20 = new int[2];
        ulong local_68;
        ulong uStack_60;
        byte[] local_58 = new byte[64];
        local_res20[0] = 0;
        do {
          if (this.gambleUIPanel == null) goto LAB_18078daaa;
          lVar4 = GameObject.get_transform(this.gambleUIPanel,0);
          if (lVar4 == null) goto LAB_18078daaa;
          lVar4 = Transform.Find(lVar4,"BetTab",0);
          uVar5 = Int32.ToString(local_res20,0);
          if (lVar4 == null) goto LAB_18078daaa;
          lVar4 = Transform.Find(lVar4,uVar5,0);
          if (lVar4 == null) goto LAB_18078daaa;
          uVar5 = Component.GetComponent(lVar4);
          cVar2 = Object.op_Inequality(uVar5);
          if (cVar2) {
            if (this.gambleUIPanel == null) goto LAB_18078daaa;
            lVar4 = GameObject.get_transform(this.gambleUIPanel,0);
            if (lVar4 == null) goto LAB_18078daaa;
            lVar4 = Transform.Find(lVar4,"BetTab",0);
            uVar5 = Int32.ToString(local_res20,0);
            if (lVar4 == null) goto LAB_18078daaa;
            lVar4 = Transform.Find(lVar4,uVar5,0);
            if (lVar4 == null) goto LAB_18078daaa;
            lVar4 = Component.GetComponent(lVar4,DAT_181d6da40);
            if (!_interactable) {
              bVar9 = false;
            }
            else if (local_res20[0] == 0) {
              bVar9 = true;
            }
            else {
              lVar6 = FUN_18046c0a0(0);
              if ((lVar6 == null) || (*(int64 *)(lVar6 + 32) == 0)) goto LAB_18078daaa;
              lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0);
              if ((lVar6 == null) || (*(int64 *)(lVar6 + 0x220) == 0)) goto LAB_18078daaa;
              iVar1 = *(int *)(*(int64 *)(lVar6 + 0x220) + 24);
              iVar3 = GambleUIController.GetBetMoney(this,local_res20[0],0xffffffff);
              bVar9 = iVar3 <= iVar1;
            }
            if (lVar4 == null) goto LAB_18078daaa;
            Selectable.set_interactable(lVar4,bVar9,0);
            if (this.gambleUIPanel == null) goto LAB_18078daaa;
            lVar4 = GameObject.get_transform(this.gambleUIPanel,0);
            if (lVar4 == null) goto LAB_18078daaa;
            lVar4 = Transform.Find(lVar4,"BetTab",0);
            uVar5 = Int32.ToString(local_res20,0);
            if (lVar4 == null) goto LAB_18078daaa;
            lVar4 = Transform.Find(lVar4,uVar5,0);
            if (lVar4 == null) goto LAB_18078daaa;
            lVar4 = Transform.Find(lVar4,"Label",0);
            if (lVar4 == null) goto LAB_18078daaa;
            plVar7 = (int64 *)Component.GetComponent(lVar4,DAT_181d6d8c0);
            if (local_res20[0] == 0) {
        LAB_18078da1c:
              local_68 = 0;
              uStack_60 = 0;
              Color.ctor(&local_68,0x3f57d7d8,0x3f41c1c2,0x3eb8b8b9,0);
              uVar10 = (uint32)local_68;
              uVar11 = local_68._4_4_;
              uVar12 = (uint32)uStack_60;
              uVar13 = uStack_60._4_4_;
            }
            else {
              lVar4 = FUN_18046c0a0(0);
              if ((lVar4 == null) || (*(int64 *)(lVar4 + 32) == 0)) goto LAB_18078daaa;
              lVar4 = WorldData.Player(*(int64 *)(lVar4 + 32),0);
              if ((lVar4 == null) || (*(int64 *)(lVar4 + 0x220) == 0)) goto LAB_18078daaa;
              iVar1 = *(int *)(*(int64 *)(lVar4 + 0x220) + 24);
              iVar3 = GambleUIController.GetBetMoney(this,local_res20[0],0xffffffff);
              if (iVar3 <= iVar1) goto LAB_18078da1c;
              puVar8 = (uint32 *)Color.get_red(local_58,0);
              uVar10 = *puVar8;
              uVar11 = puVar8[1];
              uVar12 = puVar8[2];
              uVar13 = puVar8[3];
            }
            if (plVar7 == (int64 *)0) {
        LAB_18078daaa:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            local_68 = CONCAT44(uVar11,uVar10);
            uStack_60 = CONCAT44(uVar13,uVar12);
            (**(code **)(*plVar7 + 0x2a8))(plVar7);
          }
          local_res20[0] = local_res20[0] + 1;
          if (2 < local_res20[0]) {
            return;
          }
        } while( true );
    }

    // Token : 0x60014C3
    // RVA   : 0x7892B0   Offset: 0x787AB0   Length: 0x3228
    public void NextButtonClicked()
    {
        var pStatics_1180 = *(int64*)(DAT_181d51180 + 184);
        var pStatics_25a8 = *(int64*)(DAT_181d525a8 + 184);
        var pStatics_de90 = *(int64*)(DAT_181d4de90 + 184);
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        var pStatics_ef00 = *(int64*)(DAT_181d4ef00 + 184);
        bool cVar1;
        int iVar2;
        int iVar3;
        uint uVar4;
        uint uVar5;
        uint uVar6;
        long lVar7;
        ulong uVar9;
        ulong uVar10;
        long lVar13;
        ulong uVar14;
        long lVar15;
        int iVar17;
        long lVar18;
        uint[] local_res18 = new uint[2];
        int[] local_res20 = new int[2];
        ulong in_stack_fffffffffffffef8;
        ulong uVar19;
        ulong uVar20;
        ulong uVar21;
        ulong in_stack_ffffffffffffff00;
        ulong uVar22;
        ulong in_stack_ffffffffffffff10;
        uint uVar24;
        ulong uVar23;
        uint local_c8;
        uint uStack_c4;
        uint uStack_c0;
        uint local_b8;
        uint uStack_b4;
        uint uStack_b0;
        uint local_a8;
        uint uStack_a4;
        uint uStack_a0;
        uint local_98;
        uint uStack_94;
        uint uStack_90;
        uint32 uStack_8c;
        uint32 local_88;
        uint32 uStack_84;
        uint32 uStack_80;
        uint32 uStack_7c;
        uVar4 = (uint32)((uint64)in_stack_fffffffffffffef8 >> 32);
        uVar24 = (uint32)((uint64)in_stack_ffffffffffffff10 >> 32);
        lVar7 = new c.DisplayClass9_0(0);
        if (lVar7 == null) goto LAB_18078c4cb;
        lVar7.summonLv = this;
        iVar3 = this.gambleState;
        if (iVar3 == 1) {
          this.gambleState = 2;
          GambleUIController.SetNextButtonActive(this,0,0);
          if (*pStatics_1180 != 0) {
            HeroLittleTalkController.ClearAll(*pStatics_1180,0);
            uVar9 = this.playerIcon;
            lVar7 = *pStatics_1180;
            lVar13 = *(int64 *)(pStatics_de90 + 16);
            if (lVar13 != null) {
              uVar6 = FUN_180d8cf10(0,lVar13.Count,0);
              if (lVar13.Count <= uVar6) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              if (lVar7 != null) {
                HeroLittleTalkController.HeroTalk
                          (lVar7,uVar9,
                           lVar13._items[uVar6]
                           ,0xbf800000,0);
                uVar9 = this.enemyIcon;
                lVar7 = *pStatics_1180;
                lVar13 = *(int64 *)(pStatics_de90 + 16);
                if (lVar13 != null) {
                  uVar6 = FUN_180d8cf10(0,lVar13.Count,0);
                  if (lVar13.Count <= uVar6) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  if (lVar7 != null) {
                    HeroLittleTalkController.HeroTalk
                              (lVar7,uVar9,
                               *(uint64 *)
                                (lVar13._items + 32 + (int64)(int)uVar6 * 8),
                               0xbf800000,0);
                    local_res18[0] = 0;
                    while( true ) {
                      lVar7 = this.playerDiceResult;
                      uVar4 = FUN_180d8cf10(0,6);
                      if (lVar7 == null) break;
                      FUN_181814fa0(lVar7,uVar4,DAT_181d67a78);
                      lVar7 = this.playerDiceResult;
                      iVar3 = this.playerDiceResultTotal;
                      lVar13 = (int64)(int)local_res18[0];
                      if (lVar7 == null) break;
                      if (lVar7.summonLv <= local_res18[0]) {
                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                      }
                      this.playerDiceResultTotal =
                           iVar3 + 1 + *(int *)(lVar7.isSummon + 32 + lVar13 * 4);
                      if ((this.gambleUIPanel == null) ||
                         (lVar7 = GameObject.get_transform(this.gambleUIPanel,0)) == null)
                      break;
                      lVar7 = Transform.Find(lVar7,"PlayerDice",0);
                      uVar9 = Int32.ToString(local_res18,0);
                      if ((lVar7 == null) ||
                         ((lVar7 = Transform.Find(lVar7,uVar9,0), lVar7 == null ||
                          (lVar7 = Transform.Find(lVar7,"Dice",0)) == null))) break;
                      lVar15 = Component.GetComponent(lVar7,DAT_181d6bc40);
                      lVar7 = this.playerDiceResult;
                      lVar13 = this.diceSprite;
                      lVar18 = (int64)(int)local_res18[0];
                      if (lVar7 == null) break;
                      if (lVar7.summonLv <= local_res18[0]) {
                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                      }
                      if (lVar13 == null) break;
                      uVar6 = *(uint32 *)(lVar7.isSummon + 32 + lVar18 * 4);
                      if (lVar13.Count <= uVar6) {
                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                      }
                      if (lVar15 == null) break;
                      Image.set_sprite(lVar15,*(uint64 *)
                                                (lVar13._items + 32 +
                                                (int64)(int)uVar6 * 8),0);
                      lVar7 = this.enemyDiceResult;
                      uVar4 = FUN_180d8cf10(0,6);
                      if (lVar7 == null) break;
                      FUN_181814fa0(lVar7,uVar4,DAT_181d67a78);
                      lVar7 = this.enemyDiceResult;
                      iVar3 = this.enemyDiceResultTotal;
                      lVar13 = (int64)(int)local_res18[0];
                      if (lVar7 == null) break;
                      if (lVar7.summonLv <= local_res18[0]) {
                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                      }
                      this.enemyDiceResultTotal =
                           iVar3 + 1 + *(int *)(lVar7.isSummon + 32 + lVar13 * 4);
                      if ((this.gambleUIPanel == null) ||
                         (lVar7 = GameObject.get_transform(this.gambleUIPanel,0)) == null)
                      break;
                      lVar7 = Transform.Find(lVar7,"EnemyDice",0);
                      uVar9 = Int32.ToString(local_res18,0);
                      if ((lVar7 == null) ||
                         ((lVar7 = Transform.Find(lVar7,uVar9,0), lVar7 == null ||
                          (lVar7 = Transform.Find(lVar7,"Dice",0)) == null))) break;
                      lVar15 = Component.GetComponent(lVar7,DAT_181d6bc40);
                      lVar7 = this.enemyDiceResult;
                      lVar13 = this.diceSprite;
                      lVar18 = (int64)(int)local_res18[0];
                      if (lVar7 == null) break;
                      if (lVar7.summonLv <= local_res18[0]) {
                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                      }
                      if (lVar13 == null) break;
                      uVar6 = *(uint32 *)(lVar7.isSummon + 32 + lVar18 * 4);
                      if (lVar13.Count <= uVar6) {
                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                      }
                      if (lVar15 == null) break;
                      Image.set_sprite(lVar15,*(uint64 *)
                                                (lVar13._items + 32 +
                                                (int64)(int)uVar6 * 8),0);
                      if ((this.gambleUIPanel == null) ||
                         (lVar7 = GameObject.get_transform(this.gambleUIPanel,0)) == null)
                      break;
                      lVar7 = Transform.Find(lVar7,"PlayerDice",0);
                      uVar9 = Int32.ToString(local_res18,0);
                      if ((lVar7 == null) || (lVar7 = Transform.Find(lVar7,uVar9,0)) == null) break;
                      uVar9 = Transform.Find(lVar7,"Cover",0);
                      local_a8 = 0x41800000;
                      uStack_a4 = 0;
                      uStack_a0 = 0;
                      ShortcutExtensions.DOShakePosition(uVar9);
                      if ((this.gambleUIPanel == null) ||
                         (lVar7 = GameObject.get_transform(this.gambleUIPanel,0)) == null)
                      break;
                      lVar7 = Transform.Find(lVar7,"EnemyDice",0);
                      uVar9 = Int32.ToString(local_res18,0);
                      if ((lVar7 == null) || (lVar7 = Transform.Find(lVar7,uVar9,0)) == null) break;
                      uVar9 = Transform.Find(lVar7,"Cover",0);
                      local_b8 = 0x41800000;
                      uStack_b4 = 0;
                      uStack_b0 = 0;
                      ShortcutExtensions.DOShakePosition(uVar9);
                      lVar7 = this.gambleUIPanel;
                      if ((int)local_res18[0] < 1) {
                        if ((lVar7 == null) || (lVar7 = GameObject.get_transform(lVar7,0)) == null)
                        break;
                        lVar7 = Transform.Find(lVar7,"PlayerDice",0);
                        uVar9 = Int32.ToString(local_res18,0);
                        if ((lVar7 == null) ||
                           ((lVar7 = Transform.Find(lVar7,uVar9,0), lVar7 == null ||
                            (lVar7 = Transform.Find(lVar7,"Cover",0)) == null))) break;
                        uVar9 = Component.GetComponent(lVar7,DAT_181d6bc40);
                        DOTweenModuleUI.DOFade(uVar9);
                        TweenSettingsExtensions.SetDelay();
                      }
                      else {
                        if ((lVar7 == null) || (lVar7 = GameObject.get_transform(lVar7,0)) == null)
                        break;
                        lVar7 = Transform.Find(lVar7,"PlayerDice",0);
                        uVar9 = Int32.ToString(local_res18,0);
                        if ((lVar7 == null) || (lVar7 = Transform.Find(lVar7,uVar9,0)) == null) break;
                        uVar9 = Transform.Find(lVar7,"Cover",0);
                        local_c8 = 0;
                        uStack_c4 = 0x43070000;
                        uStack_c0 = 0;
                        uVar9 = ShortcutExtensions.DOLocalMove(uVar9,&local_c8,0x3f000000,0,0);
                        uVar9 = TweenSettingsExtensions.SetDelay
                                          (uVar9,(float)(int)local_res18[0] * 0.5 + 1.0,DAT_181d97978);
                        lVar7 = *(int64 *)(pStatics_25a8 + 8);
                        if (lVar7 == null) {
                          uVar10 = **(uint64 **)(DAT_181d525a8 + 184);
                          lVar7 = new OnTooltipCB(uVar10,DAT_181d7ad88,0);
                          plVar11 = (int64 *)(pStatics_25a8 + 8);
                          *plVar11 = lVar7;
                          il2cpp_internal(plVar11,lVar7);
                        }
                        TweenSettingsExtensions.OnPlay(uVar9,lVar7,DAT_181d97108);
                        lVar7 = this.gambleUIPanel;
                        if (local_res18[0] == 3) {
                          if ((lVar7 == null) || (lVar7 = GameObject.get_transform(lVar7,0)) == null)
                          break;
                          lVar7 = Transform.Find(lVar7,"EnemyDice",0);
                          uVar9 = Int32.ToString(local_res18,0);
                          if ((lVar7 == null) || (lVar7 = Transform.Find(lVar7,uVar9,0)) == null) break;
                          uVar9 = Transform.Find(lVar7,"Cover",0);
                          local_88 = 0;
                          uStack_84 = 0x43070000;
                          uStack_80 = 0;
                          uVar9 = ShortcutExtensions.DOLocalMove(uVar9,&local_88,0x3f000000,0,0);
                          uVar9 = TweenSettingsExtensions.SetDelay
                                            (uVar9,(float)(int)local_res18[0] * 0.5 + 1.0,DAT_181d97978);
                          uVar10 = new OnTooltipCB(this,DAT_181d9b730,0);
                          TweenSettingsExtensions.OnComplete(uVar9,uVar10);
                        }
                        else {
                          if ((lVar7 == null) || (lVar7 = GameObject.get_transform(lVar7,0)) == null)
                          break;
                          lVar7 = Transform.Find(lVar7,"EnemyDice",0);
                          uVar9 = Int32.ToString(local_res18,0);
                          if ((lVar7 == null) || (lVar7 = Transform.Find(lVar7,uVar9,0)) == null) break;
                          uVar9 = Transform.Find(lVar7,"Cover",0);
                          local_98 = 0;
                          uStack_94 = 0x43070000;
                          uStack_90 = 0;
                          uVar9 = ShortcutExtensions.DOLocalMove(uVar9,&local_98,0x3f000000,0,0);
                          TweenSettingsExtensions.SetDelay(uVar9,(float)(int)local_res18[0] * 0.5 + 1.0);
                        }
                      }
                      local_res18[0] = local_res18[0] + 1;
                      if (3 < (int)local_res18[0]) {
                        plVar11 = (int64 *)Resources.Load("Sound/SoundEffect/RollDice",0);
                        plVar16 = (int64 *)0;
                        if ((plVar11 != (int64 *)0) && (*plVar11 == DAT_181d8a228)) {
                          plVar16 = plVar11;
                        }
                        NGUITools.PlaySound(plVar16,0);
                        return;
                      }
                    }
                  }
                }
              }
            }
          }
          goto LAB_18078c4cb;
        }
        if (iVar3 != 2) {
          if (iVar3 == 3) {
            this.gambleState = 4;
            GambleUIController.SetNextButtonActive(this,0,0);
            GambleUIController.SetBetButtonActive(this,0,0);
            if (*pStatics_1180 == 0) goto LAB_18078c4cb;
            HeroLittleTalkController.ClearAll(*pStatics_1180,0);
            if ((((this.gambleUIPanel == null) ||
                 (lVar7 = GameObject.get_transform(this.gambleUIPanel,0)) == null) ||
                (lVar7 = Transform.Find(lVar7,"PlayerDice",0)) == null) ||
               ((lVar7 = Transform.Find(lVar7,"0",0), lVar7 == null ||
                (lVar7 = Transform.Find(lVar7,"Cover",0)) == null))) goto LAB_18078c4cb;
            uVar9 = Component.GetComponent(lVar7,DAT_181d6bc40);
            DOTweenModuleUI.DOFade(uVar9);
            if (((this.gambleUIPanel == null) ||
                ((lVar7 = GameObject.get_transform(this.gambleUIPanel,0), lVar7 == null ||
                 (lVar7 = Transform.Find(lVar7,"PlayerDice",0)) == null))) ||
               (lVar7 = Transform.Find(lVar7,"0",0)) == null) goto LAB_18078c4cb;
            uVar9 = Transform.Find(lVar7,"Cover",0);
            local_a8 = 0;
            uStack_a4 = 0x43070000;
            uStack_a0 = 0;
            uVar9 = ShortcutExtensions.DOLocalMove(uVar9,&local_a8,0x3f000000,0,0);
            lVar7 = *(int64 *)(pStatics_25a8 + 24);
            if (lVar7 == null) {
              uVar10 = **(uint64 **)(DAT_181d525a8 + 184);
              lVar7 = new OnTooltipCB(uVar10,DAT_181d7ac88,0);
              plVar11 = (int64 *)(pStatics_25a8 + 24);
              *plVar11 = lVar7;
              il2cpp_internal(plVar11,lVar7);
            }
            TweenSettingsExtensions.OnPlay(uVar9,lVar7,DAT_181d97108);
            if ((((this.gambleUIPanel == null) ||
                 (lVar7 = GameObject.get_transform(this.gambleUIPanel,0)) == null) ||
                (lVar7 = Transform.Find(lVar7,"EnemyDice",0)) == null) ||
               (lVar7 = Transform.Find(lVar7,"0",0)) == null) goto LAB_18078c4cb;
            uVar9 = Transform.Find(lVar7,"Cover",0);
            local_a8 = 0;
            uStack_a4 = 0x43070000;
            uStack_a0 = 0;
            uVar9 = ShortcutExtensions.DOLocalMove(uVar9,&local_a8,0x3f000000,0,0);
            lVar7 = *(int64 *)(pStatics_25a8 + 32);
            if (lVar7 == null) {
              uVar10 = **(uint64 **)(DAT_181d525a8 + 184);
              lVar7 = new OnTooltipCB(uVar10,DAT_181d7ad08,0);
              plVar11 = (int64 *)(pStatics_25a8 + 32);
              *plVar11 = lVar7;
              il2cpp_internal(plVar11,lVar7);
            }
            TweenSettingsExtensions.OnPlay(uVar9,lVar7,DAT_181d97108);
            uVar4 = GambleUIController.GetDiceResultLv(this,this.playerDiceResult,0);
            this.playerDiceResultLv = uVar4;
            uVar4 = GambleUIController.GetDiceResultLv(this,this.enemyDiceResult,0);
            this.enemyDiceResultLv = uVar4;
            if (((this.gambleUIPanel == null) ||
                (lVar7 = GameObject.get_transform(this.gambleUIPanel,0)) == null) ||
               (lVar7 = Transform.Find(lVar7,"PlayerResult",0)) == null) goto LAB_18078c4cb;
            uVar9 = Component.GetComponent(lVar7,DAT_181d6d8c0);
            uVar6 = this.playerDiceResultLv;
            lVar13 = (int64)(int)uVar6;
            lVar7 = *pStatics_de90;
            if (lVar7 == null) goto LAB_18078c4cb;
            if (lVar7.summonLv <= uVar6) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
              uVar6 = this.playerDiceResultLv;
            }
            uVar10 = *(uint64 *)(lVar7.isSummon + 32 + lVar13 * 8);
            uVar19 = "";
            if (uVar6 == this.enemyDiceResultLv) {
              uVar19 = Int32.ToString(this + 116,0);
              uVar19 = String.Concat("\n",uVar19,"点",0);
            }
            uVar10 = String.Concat(uVar10,uVar19,0);
            LTLocalization.SetText(uVar9,uVar10,0);
            if ((this.gambleUIPanel == null) ||
               (lVar7 = GameObject.get_transform(this.gambleUIPanel,0)) == null)
            goto LAB_18078c4cb;
            uVar9 = Transform.Find(lVar7,"PlayerResult",0);
            uVar9 = ShortcutExtensions.DOScale(uVar9);
            TweenSettingsExtensions.SetDelay(uVar9);
            if ((this.gambleUIPanel == null) ||
               ((lVar7 = GameObject.get_transform(this.gambleUIPanel,0), lVar7 == null ||
                (lVar7 = Transform.Find(lVar7,"EnemyResult",0)) == null))) goto LAB_18078c4cb;
            uVar9 = Component.GetComponent(lVar7,DAT_181d6d8c0);
            uVar6 = this.enemyDiceResultLv;
            lVar13 = (int64)(int)uVar6;
            lVar7 = *pStatics_de90;
            if (lVar7 == null) goto LAB_18078c4cb;
            if (lVar7.summonLv <= uVar6) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
              uVar6 = this.enemyDiceResultLv;
            }
            uVar10 = *(uint64 *)(lVar7.isSummon + 32 + lVar13 * 8);
            uVar19 = "";
            if (this.playerDiceResultLv == uVar6) {
              uVar19 = Int32.ToString(this + 132,0);
              uVar19 = String.Concat("\n",uVar19,"点",0);
            }
            uVar10 = String.Concat(uVar10,uVar19,0);
            LTLocalization.SetText(uVar9,uVar10,0);
            if ((this.gambleUIPanel == null) ||
               (lVar7 = GameObject.get_transform(this.gambleUIPanel,0)) == null)
            goto LAB_18078c4cb;
            uVar9 = Transform.Find(lVar7,"EnemyResult",0);
            uVar9 = ShortcutExtensions.DOScale(uVar9);
            uVar10 = TweenSettingsExtensions.SetDelay(uVar9);
            uVar19 = il2cpp_internal(DAT_181d88bd8);
            uVar9 = DAT_181d9b628;
            goto LAB_18078b283;
          }
          if (iVar3 == 4) {
            this.gambleState = 5;
            GambleUIController.SetNextButtonActive(this,0,0);
            if (*pStatics_1180 == 0) goto LAB_18078c4cb;
            HeroLittleTalkController.ClearAll(*pStatics_1180,0);
            if (this.enemyDiceResultLv < this.playerDiceResultLv) {
        LAB_18078a159:
              uVar4 = 1;
            }
            else if (this.playerDiceResultLv < this.enemyDiceResultLv) {
        LAB_18078a152:
              uVar4 = 2;
            }
            else {
              if (this.enemyDiceResultTotal < this.playerDiceResultTotal) goto LAB_18078a159;
              if (this.playerDiceResultTotal < this.enemyDiceResultTotal) goto LAB_18078a152;
              uVar4 = 3;
            }
            this.gambleResult = uVar4;
            if (this.gambleResults == null) goto LAB_18078c4d1;
            FUN_18181e970(this.gambleResults,this.round,uVar4,
                          DAT_181d618f8);
            GambleUIController.RefreshRoundIcon(this,0);
            iVar3 = this.gambleResult;
            if (iVar3 == 1) {
              if (((this.gambleUIPanel == null) ||
                  (lVar7 = GameObject.get_transform(this.gambleUIPanel,0)) == null) ||
                 (lVar7 = Transform.Find(lVar7,"PlayerWin",0)) == null) goto LAB_18078c4d1;
              uVar9 = Component.GetComponent(lVar7,DAT_181d6d8c0);
              LTLocalization.SetText(uVar9,"胜",0);
              if (((this.gambleUIPanel == null) ||
                  (lVar7 = GameObject.get_transform(this.gambleUIPanel,0)) == null) ||
                 (lVar7 = Transform.Find(lVar7,"PlayerWin",0)) == null) goto LAB_18078c4d1;
              plVar11 = (int64 *)Component.GetComponent(lVar7,DAT_181d6d8c0);
              lVar7 = pStatics_ef00;
              if (plVar11 == (int64 *)0) goto LAB_18078c4d1;
              local_88 = lVar7.dodgeSkill;
              uStack_84 = *(uint32 *)(lVar7 + 0x284);
              uStack_80 = lVar7.uniqueSkillSaveRecord;
              uStack_7c = *(uint32 *)(lVar7 + 0x28c);
              (**(code **)(*plVar11 + 0x2a8))(plVar11,&local_88,*(uint64 *)(*plVar11 + 0x2b0));
              if (((this.gambleUIPanel == null) ||
                  (lVar7 = GameObject.get_transform(this.gambleUIPanel,0)) == null) ||
                 (lVar7 = Transform.Find(lVar7,"EnemyWin",0)) == null) goto LAB_18078c4d1;
              uVar9 = Component.GetComponent(lVar7,DAT_181d6d8c0);
              LTLocalization.SetText(uVar9,"败",0);
              if (((this.gambleUIPanel == null) ||
                  (lVar7 = GameObject.get_transform(this.gambleUIPanel,0)) == null) ||
                 (lVar7 = Transform.Find(lVar7,"EnemyWin",0)) == null) goto LAB_18078c4d1;
              plVar11 = (int64 *)Component.GetComponent(lVar7,DAT_181d6d8c0);
              lVar7 = pStatics_ef00;
              if (plVar11 == (int64 *)0) goto LAB_18078c4d1;
              local_88 = lVar7.missions;
              uStack_84 = *(uint32 *)(lVar7 + 0x2ec);
              uStack_80 = lVar7.inTeam;
              uStack_7c = lVar7.teamLeader;
              (**(code **)(*plVar11 + 0x2a8))(plVar11,&local_88,*(uint64 *)(*plVar11 + 0x2b0));
              lVar7 = FUN_18046c0a0(0);
              if ((lVar7 == null) || (lVar7.summonControlable == null)) goto LAB_18078c4d1;
              lVar7 = WorldData.Player(lVar7.summonControlable,0);
              iVar3 = GambleUIController.GetBetMoney(this,this.betNumID,0xffffffff);
              iVar2 = (this.playerDiceResultLv == 5) + 1;
              if (lVar7 == null) goto LAB_18078c4d1;
              iVar17 = iVar2 * 2;
              if (this.enemyDiceResultLv != 5) {
                iVar17 = iVar2;
              }
              HeroData.ChangeMoney(lVar7,iVar17 * iVar3,1,0);
              lVar7 = this.enemyData;
              iVar3 = GambleUIController.GetBetMoney
                                (this,this.betNumID,0xffffffff,0);
              iVar2 = (this.playerDiceResultLv == 5) + 1;
              if (lVar7 == null) goto LAB_18078c4d1;
              iVar17 = iVar2 * 2;
              if (this.enemyDiceResultLv != 5) {
                iVar17 = iVar2;
              }
              HeroData.ChangeMoney(lVar7,-(iVar17 * iVar3),1,0);
              this.playerWinCount = this.playerWinCount + 1;
              lVar7 = FUN_18046c220(0);
              uVar9 = this.playerIcon;
              lVar13 = *(int64 *)(pStatics_de90 + 24);
              if (lVar13 == null) goto LAB_18078c4d1;
              uVar4 = FUN_180d8cf10(0,lVar13.Count,0);
              uVar10 = FUN_180002f80(lVar13,uVar4,DAT_181d7c9c0);
              if (lVar7 == null) goto LAB_18078c4d1;
              HeroLittleTalkController.HeroTalk(lVar7,uVar9,uVar10,0xbf800000,0);
              lVar13 = FUN_18046c220(0);
              uVar9 = this.enemyIcon;
              lVar7 = *(int64 *)(pStatics_de90 + 32);
              if (lVar7 == null) goto LAB_18078c4d1;
              uVar4 = FUN_180d8cf10(0,lVar7.summonLv,0);
              uVar10 = FUN_180002f80(lVar7,uVar4,DAT_181d7c9c0);
              if (lVar13 == null) goto LAB_18078c4d1;
              HeroLittleTalkController.HeroTalk(lVar13,uVar9,uVar10,0xbf800000,0);
              lVar7 = FUN_18046c100(0);
              if (lVar7 == null) goto LAB_18078c4d1;
              GameDataController.ChangeAchStats(lVar7,4,0x3f800000);
            }
            else if (iVar3 == 2) {
              if (((this.gambleUIPanel == null) ||
                  (lVar7 = GameObject.get_transform(this.gambleUIPanel,0)) == null) ||
                 (lVar7 = Transform.Find(lVar7,"PlayerWin",0)) == null) goto LAB_18078c4d1;
              uVar9 = Component.GetComponent(lVar7,DAT_181d6d8c0);
              LTLocalization.SetText(uVar9,"败",0);
              if (((this.gambleUIPanel == null) ||
                  (lVar7 = GameObject.get_transform(this.gambleUIPanel,0)) == null) ||
                 (lVar7 = Transform.Find(lVar7,"PlayerWin",0)) == null) goto LAB_18078c4d1;
              plVar11 = (int64 *)Component.GetComponent(lVar7,DAT_181d6d8c0);
              lVar7 = pStatics_ef00;
              if (plVar11 == (int64 *)0) goto LAB_18078c4d1;
              local_88 = lVar7.missions;
              uStack_84 = *(uint32 *)(lVar7 + 0x2ec);
              uStack_80 = lVar7.inTeam;
              uStack_7c = lVar7.teamLeader;
              (**(code **)(*plVar11 + 0x2a8))(plVar11,&local_88,*(uint64 *)(*plVar11 + 0x2b0));
              if (((this.gambleUIPanel == null) ||
                  (lVar7 = GameObject.get_transform(this.gambleUIPanel,0)) == null) ||
                 (lVar7 = Transform.Find(lVar7,"EnemyWin",0)) == null) goto LAB_18078c4d1;
              uVar9 = Component.GetComponent(lVar7,DAT_181d6d8c0);
              LTLocalization.SetText(uVar9,"胜",0);
              if (((this.gambleUIPanel == null) ||
                  (lVar7 = GameObject.get_transform(this.gambleUIPanel,0)) == null) ||
                 (lVar7 = Transform.Find(lVar7,"EnemyWin",0)) == null) goto LAB_18078c4d1;
              plVar11 = (int64 *)Component.GetComponent(lVar7,DAT_181d6d8c0);
              lVar7 = pStatics_ef00;
              if (plVar11 == (int64 *)0) goto LAB_18078c4d1;
              local_88 = lVar7.dodgeSkill;
              uStack_84 = *(uint32 *)(lVar7 + 0x284);
              uStack_80 = lVar7.uniqueSkillSaveRecord;
              uStack_7c = *(uint32 *)(lVar7 + 0x28c);
              (**(code **)(*plVar11 + 0x2a8))(plVar11,&local_88,*(uint64 *)(*plVar11 + 0x2b0));
              lVar7 = FUN_18046c0a0(0);
              if ((lVar7 == null) || (lVar7.summonControlable == null)) goto LAB_18078c4d1;
              lVar7 = WorldData.Player(lVar7.summonControlable,0);
              iVar3 = GambleUIController.GetBetMoney(this,this.betNumID,0xffffffff);
              iVar2 = (this.playerDiceResultLv == 5) + 1;
              if (lVar7 == null) goto LAB_18078c4d1;
              iVar17 = iVar2 * 2;
              if (this.enemyDiceResultLv != 5) {
                iVar17 = iVar2;
              }
              HeroData.ChangeMoney(lVar7,-(iVar17 * iVar3),1,0);
              lVar7 = this.enemyData;
              iVar3 = GambleUIController.GetBetMoney
                                (this,this.betNumID,0xffffffff,0);
              iVar2 = (this.playerDiceResultLv == 5) + 1;
              if (lVar7 == null) goto LAB_18078c4d1;
              iVar17 = iVar2 * 2;
              if (this.enemyDiceResultLv != 5) {
                iVar17 = iVar2;
              }
              HeroData.ChangeMoney(lVar7,iVar17 * iVar3,1,0);
              this.enemyWinCount = this.enemyWinCount + 1;
              lVar7 = FUN_18046c220(0);
              uVar9 = this.playerIcon;
              lVar13 = *(int64 *)(pStatics_de90 + 32);
              if (lVar13 == null) goto LAB_18078c4d1;
              uVar4 = FUN_180d8cf10(0,lVar13.Count,0);
              uVar10 = FUN_180002f80(lVar13,uVar4,DAT_181d7c9c0);
              if (lVar7 == null) goto LAB_18078c4d1;
              HeroLittleTalkController.HeroTalk(lVar7,uVar9,uVar10,0xbf800000,0);
              lVar13 = FUN_18046c220(0);
              uVar9 = this.enemyIcon;
              lVar7 = *(int64 *)(pStatics_de90 + 24);
              if (lVar7 == null) goto LAB_18078c4d1;
              uVar4 = FUN_180d8cf10(0,lVar7.summonLv,0);
              uVar10 = FUN_180002f80(lVar7,uVar4,DAT_181d7c9c0);
              if (lVar13 == null) goto LAB_18078c4d1;
              HeroLittleTalkController.HeroTalk(lVar13,uVar9,uVar10,0xbf800000,0);
            }
            else if (iVar3 == 3) {
              if (((this.gambleUIPanel == null) ||
                  (lVar7 = GameObject.get_transform(this.gambleUIPanel,0)) == null) ||
                 (lVar7 = Transform.Find(lVar7,"PlayerWin",0)) == null) goto LAB_18078c4d1;
              uVar9 = Component.GetComponent(lVar7,DAT_181d6d8c0);
              LTLocalization.SetText(uVar9,"平",0);
              if (((this.gambleUIPanel == null) ||
                  (lVar7 = GameObject.get_transform(this.gambleUIPanel,0)) == null) ||
                 (lVar7 = Transform.Find(lVar7,"PlayerWin",0)) == null) goto LAB_18078c4d1;
              plVar11 = (int64 *)Component.GetComponent(lVar7,DAT_181d6d8c0);
              puVar12 = (uint32 *)FUN_1810988d0(&local_88,0);
              if (plVar11 == (int64 *)0) goto LAB_18078c4d1;
              local_88 = *puVar12;
              uStack_84 = puVar12[1];
              uStack_80 = puVar12[2];
              uStack_7c = puVar12[3];
              (**(code **)(*plVar11 + 0x2a8))(plVar11,&local_88,*(uint64 *)(*plVar11 + 0x2b0));
              if (((this.gambleUIPanel == null) ||
                  (lVar7 = GameObject.get_transform(this.gambleUIPanel,0)) == null) ||
                 (lVar7 = Transform.Find(lVar7,"EnemyWin",0)) == null) goto LAB_18078c4d1;
              uVar9 = Component.GetComponent(lVar7,DAT_181d6d8c0);
              LTLocalization.SetText(uVar9,"平",0);
              if (((this.gambleUIPanel == null) ||
                  (lVar7 = GameObject.get_transform(this.gambleUIPanel,0)) == null) ||
                 (lVar7 = Transform.Find(lVar7,"EnemyWin",0)) == null) goto LAB_18078c4d1;
              plVar11 = (int64 *)Component.GetComponent(lVar7,DAT_181d6d8c0);
              puVar12 = (uint32 *)FUN_1810988d0(&local_88,0);
              if (plVar11 == (int64 *)0) goto LAB_18078c4d1;
              local_88 = *puVar12;
              uStack_84 = puVar12[1];
              uStack_80 = puVar12[2];
              uStack_7c = puVar12[3];
              (**(code **)(*plVar11 + 0x2a8))(plVar11,&local_88,*(uint64 *)(*plVar11 + 0x2b0));
              lVar7 = FUN_18046c220(0);
              if (lVar7 == null) goto LAB_18078c4d1;
              HeroLittleTalkController.HeroTalk
                        (lVar7,this.playerIcon,"............",0xbf800000,0);
              lVar7 = FUN_18046c220(0);
              if (lVar7 == null) goto LAB_18078c4d1;
              HeroLittleTalkController.HeroTalk
                        (lVar7,this.enemyIcon,"............",0xbf800000,0);
            }
            if ((this.gambleUIPanel != null) &&
               (lVar7 = GameObject.get_transform(this.gambleUIPanel,0)) != null) {
              uVar9 = Transform.Find(lVar7,"PlayerWin",0);
              uVar9 = ShortcutExtensions.DOScale(uVar9);
              TweenSettingsExtensions.SetEase(uVar9,27,DAT_181d97ca8);
              if ((this.gambleUIPanel != null) &&
                 (lVar7 = GameObject.get_transform(this.gambleUIPanel,0)) != null) {
                uVar9 = Transform.Find(lVar7,"EnemyWin",0);
                uVar9 = ShortcutExtensions.DOScale(uVar9);
                uVar10 = TweenSettingsExtensions.SetEase(uVar9,27,DAT_181d97ca8);
                uVar19 = il2cpp_internal(DAT_181d88bd8);
                uVar9 = DAT_181d9b6a8;
        LAB_18078b283:
                OnTooltipCB.ctor(uVar19,this,uVar9,0);
                TweenSettingsExtensions.OnComplete(uVar10,uVar19,DAT_181d96ee8);
                return;
              }
            }
            goto LAB_18078c4d1;
          }
          if (iVar3 != 5) {
            return;
          }
          this.round = this.round + 1;
          if ((((this.gambleUIPanel == null) ||
               (lVar7 = GameObject.get_transform(this.gambleUIPanel,0)) == null) ||
              (lVar7 = Transform.Find(lVar7,"BetTab",0)) == null) ||
             (lVar7 = Component.get_gameObject(lVar7,0)) == null) goto LAB_18078c4d1;
          GameObject.SetActive(lVar7,0,0);
          GambleUIController.SetNextButtonActive(this,0,0);
          if (*pStatics_1180 == 0) goto LAB_18078c4d1;
          HeroLittleTalkController.ClearAll(*pStatics_1180,0);
          if (this.playerDiceResult == null) goto LAB_18078c4d1;
          FUN_180f56130(this.playerDiceResult,DAT_181d67b78);
          this.playerDiceResultTotal = 0;
          if (this.enemyDiceResult == null) goto LAB_18078c4d1;
          FUN_180f56130(this.enemyDiceResult,DAT_181d67b78);
          this.enemyDiceResultTotal = 0;
          if ((this.gambleUIPanel == null) ||
             (lVar7 = GameObject.get_transform(this.gambleUIPanel,0)) == null)
          goto LAB_18078c4d1;
          lVar7 = Transform.Find(lVar7,"PlayerResult",0);
          puVar8 = (uint64 *)Vector3.get_zero(&local_98,0);
          if (lVar7 == null) goto LAB_18078c4d1;
          uStack_80 = *(uint32 *)(puVar8 + 1);
          local_88 = (uint32)*puVar8;
          uStack_84 = (uint32)((uint64)*puVar8 >> 32);
          Transform.set_localScale(lVar7,&local_88,0);
          if ((this.gambleUIPanel == null) ||
             (lVar7 = GameObject.get_transform(this.gambleUIPanel,0)) == null)
          goto LAB_18078c4d1;
          lVar7 = Transform.Find(lVar7,"EnemyResult",0);
          puVar8 = (uint64 *)Vector3.get_zero(&local_98,0);
          if (lVar7 == null) goto LAB_18078c4d1;
          uStack_80 = *(uint32 *)(puVar8 + 1);
          local_88 = (uint32)*puVar8;
          uStack_84 = (uint32)((uint64)*puVar8 >> 32);
          Transform.set_localScale(lVar7,&local_88,0);
          if ((this.gambleUIPanel == null) ||
             (lVar7 = GameObject.get_transform(this.gambleUIPanel,0)) == null)
          goto LAB_18078c4d1;
          lVar7 = Transform.Find(lVar7,"PlayerWin",0);
          puVar8 = (uint64 *)Vector3.get_zero(&local_98,0);
          if (lVar7 == null) goto LAB_18078c4d1;
          uStack_80 = *(uint32 *)(puVar8 + 1);
          local_88 = (uint32)*puVar8;
          uStack_84 = (uint32)((uint64)*puVar8 >> 32);
          Transform.set_localScale(lVar7,&local_88,0);
          if ((this.gambleUIPanel == null) ||
             (lVar7 = GameObject.get_transform(this.gambleUIPanel,0)) == null)
          goto LAB_18078c4d1;
          lVar7 = Transform.Find(lVar7,"EnemyWin",0);
          puVar8 = (uint64 *)Vector3.get_zero(&local_98,0);
          if (lVar7 == null) goto LAB_18078c4d1;
          uStack_80 = *(uint32 *)(puVar8 + 1);
          local_88 = (uint32)*puVar8;
          uStack_84 = (uint32)((uint64)*puVar8 >> 32);
          Transform.set_localScale(lVar7,&local_88,0);
          if (this.defaultBetButton == null) goto LAB_18078c4d1;
          Toggle.set_isOn(this.defaultBetButton,1,0);
          local_res20[0] = 0;
          do {
            if ((this.gambleUIPanel == null) ||
               (lVar7 = GameObject.get_transform(this.gambleUIPanel,0)) == null)
            goto LAB_18078c4d1;
            lVar7 = Transform.Find(lVar7,"PlayerDice",0);
            uVar9 = Int32.ToString(local_res20,0);
            if ((lVar7 == null) || (lVar7 = Transform.Find(lVar7,uVar9,0)) == null) goto LAB_18078c4d1;
            uVar9 = Transform.Find(lVar7,"Cover",0);
            local_c8 = 0;
            uStack_c4 = 0x420c0000;
            uStack_c0 = 0;
            ShortcutExtensions.DOLocalMove(uVar9,&local_c8,0x3f000000,0,0);
            lVar7 = this.gambleUIPanel;
            if (local_res20[0] == 0) {
              if ((lVar7 == null) || (lVar7 = GameObject.get_transform(lVar7,0)) == null)
              goto LAB_18078c4d1;
              lVar7 = Transform.Find(lVar7,"EnemyDice",0);
              uVar9 = Int32.ToString(local_res20,0);
              if ((lVar7 == null) || (lVar7 = Transform.Find(lVar7,uVar9,0)) == null)
              goto LAB_18078c4d1;
              uVar9 = Transform.Find(lVar7,"Cover",0);
              local_a8 = 0;
              uStack_a4 = 0x420c0000;
              uStack_a0 = 0;
              uVar19 = 0;
              uVar9 = ShortcutExtensions.DOLocalMove(uVar9,&local_a8,0x3f000000,0,0);
              uVar10 = new OnTooltipCB(this,DAT_181d9b5a0);
              TweenSettingsExtensions.OnComplete(uVar9);
            }
            else {
              if ((lVar7 == null) || (lVar7 = GameObject.get_transform(lVar7,0)) == null)
              goto LAB_18078c4d1;
              lVar7 = Transform.Find(lVar7,"EnemyDice",0);
              uVar9 = Int32.ToString(local_res20,0);
              if ((lVar7 == null) || (lVar7 = Transform.Find(lVar7,uVar9,0)) == null)
              goto LAB_18078c4d1;
              uVar9 = Transform.Find(lVar7,"Cover",0);
              local_b8 = 0;
              uStack_b4 = 0x420c0000;
              uStack_b0 = 0;
              uVar19 = 0;
              ShortcutExtensions.DOLocalMove(uVar9,&local_b8,0x3f000000,0,0);
            }
            local_res20[0] = local_res20[0] + 1;
          } while (local_res20[0] < 4);
          if ((((*pStatics_df90 == 0) ||
               (lVar7 = *(int64 *)(*pStatics_df90 + 32)) == null) ||
              (lVar7 = WorldData.Player(lVar7,0)) == null) || (lVar7.itemListData == null))
          goto LAB_18078c4d1;
          iVar3 = *(int *)(lVar7.itemListData + 24);
          iVar2 = GambleUIController.GetBetMoney(this,0,0xffffffff);
          if (iVar3 < iVar2) {
            uVar9 = "银钱不足以最低下注！";
            lVar7 = *pStatics_df90;
            if (lVar7 == null) goto LAB_18078c4d1;
            lVar7 = GameController.ShowTextOnMouse(lVar7,uVar9,0);
            if ((lVar7 == null) || (lVar7 = GameObject.GetComponent(lVar7,DAT_181da1eb0)) == null)
            goto LAB_18078c4d1;
            Text.set_fontSize(lVar7,22);
            this.round = 3;
          }
          if (this.round < 3) {
            this.gambleState = 1;
            return;
          }
          if (this.playerWinCount < 3) {
            if (2 < this.enemyWinCount) {
              if (((*pStatics_df90 == 0) ||
                  (lVar7 = *(int64 *)(*pStatics_df90 + 32)) == null) ||
                 (lVar7 = WorldData.Player(lVar7,0)) == null) goto LAB_18078c4d1;
              uVar20 = CONCAT71((int7)((uint64)uVar19 >> 8),1);
              HeroData.AddTag(lVar7,0x154,0x40c00000,0,uVar20,1,0);
              lVar7 = this.enemyData;
              if (lVar7 == null) goto LAB_18078c4d1;
              uVar9 = 0x153;
              goto LAB_180789ecd;
            }
          }
          else {
            if (((*pStatics_df90 == 0) ||
                (lVar7 = *(int64 *)(*pStatics_df90 + 32)) == null) ||
               (lVar7 = WorldData.Player(lVar7,0)) == null) goto LAB_18078c4d1;
            uVar20 = CONCAT71((int7)((uint64)uVar19 >> 8),1);
            HeroData.AddTag(lVar7,0x153,0x40c00000,0,uVar20,1,0);
            lVar7 = this.enemyData;
            if (lVar7 == null) goto LAB_18078c4d1;
            uVar9 = 0x154;
        LAB_180789ecd:
            HeroData.AddTag(lVar7,uVar9,0x40c00000,0,uVar20 & 0xffffffffffffff00,1,0);
          }
          if (this.gambleUIPanel != null) {
            GameObject.SetActive(this.gambleUIPanel,0,0);
            this.gambleState = 0;
            if (((this.gambleUIPanel != null) &&
                (lVar7 = GameObject.get_transform(this.gambleUIPanel,0)) != null) &&
               (lVar7 = Transform.Find(lVar7,"PlayerIcon",0)) != null) {
              uVar9 = Component.get_gameObject(lVar7,0);
              GlobalData.DeleteAllChild(uVar9,0);
              if (((this.gambleUIPanel != null) &&
                  (lVar7 = GameObject.get_transform(this.gambleUIPanel,0)) != null) &&
                 (lVar7 = Transform.Find(lVar7,"EnemyIcon",0)) != null) {
                uVar9 = Component.get_gameObject(lVar7,0);
                GlobalData.DeleteAllChild(uVar9,0);
                if (this.fightEndCallFuc == null) {
                  return;
                }
                cVar1 = String.op_Inequality(this.fightEndCallFuc,"",0);
                if (!cVar1) {
                  return;
                }
                uVar9 = this.fightEndCallFuc;
                lVar7 = **(int64 **)(DAT_181d6c960 + 184);
                uVar10 = Int32.ToString(this + 92,0);
                uVar19 = Int32.ToString(this + 96,0);
                uVar10 = String.Concat(uVar10,":",uVar19,0);
                if (lVar7 != null) {
                  Component.SendMessage(lVar7,uVar9,uVar10,0);
                  return;
                }
              }
            }
          }
        LAB_18078c4d1:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        this.gambleState = 3;
        if (((this.gambleUIPanel == null) ||
            (lVar13 = GameObject.get_transform(this.gambleUIPanel,0)) == null) ||
           ((lVar13 = Transform.Find(lVar13,"RerollButton",0), lVar13 == null ||
            (lVar13 = Component.get_gameObject(lVar13,0)) == null))) goto LAB_18078c4cb;
        GameObject.SetActive(lVar13,0,0);
        GambleUIController.SetNextButtonActive(this,0,0);
        lVar7.isSummon = 0xffffffff;
        if (this.enemyDiceResult == null) goto LAB_18078c4cb;
        uVar9 = FUN_180f582c0(this.enemyDiceResult,DAT_181d680f0);
        lVar13 = il2cpp_internal(DAT_181d6f030);
        FUN_18182e120(lVar13,uVar9,DAT_181d67978);
        if (lVar13 == null) goto LAB_18078c4cb;
        List_1.Sort(lVar13,DAT_181d67ff0);
        uVar5 = GambleUIController.GetDiceResultLv(this,this.enemyDiceResult,0);
        switch(uVar5) {
        case 0:
          lVar18 = this.enemyDiceResult;
          if (lVar13.Count == null) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          if (lVar18 == null) goto LAB_18078c4cb;
          uVar5 = *(uint32 *)(lVar13._items + 32);
          break;
        case 1:
          uVar6 = lVar13.Count;
          if (uVar6 == 0) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
            uVar6 = lVar13.Count;
          }
          lVar15 = lVar13._items;
          iVar3 = *(int *)(lVar15 + 32);
          if (uVar6 < 2) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
            lVar15 = lVar13._items;
            uVar6 = lVar13.Count;
          }
          lVar18 = this.enemyDiceResult;
          if (iVar3 == *(int *)(lVar15 + 36)) {
            if (uVar6 < 3) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
              lVar15 = lVar13._items;
            }
            if (lVar18 == null) goto LAB_18078c4cb;
            uVar5 = *(uint32 *)(lVar15 + 40);
          }
          else {
        LAB_18078b3fe:
            if (uVar6 == 0) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
              lVar15 = lVar13._items;
            }
            if (lVar18 == null) goto LAB_18078c4cb;
            uVar5 = *(uint32 *)(lVar15 + 32);
          }
          break;
        default:
          goto switchD_18078b3a0_caseD_2;
        case 3:
          uVar6 = lVar13.Count;
          if (uVar6 == 0) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
            uVar6 = lVar13.Count;
          }
          lVar15 = lVar13._items;
          iVar3 = *(int *)(lVar15 + 32);
          if (uVar6 < 2) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
            lVar15 = lVar13._items;
            uVar6 = lVar13.Count;
          }
          lVar18 = this.enemyDiceResult;
          if (iVar3 != *(int *)(lVar15 + 36)) goto LAB_18078b3fe;
          if (uVar6 < 4) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
            lVar15 = lVar13._items;
          }
          if (lVar18 == null) goto LAB_18078c4cb;
          uVar5 = *(uint32 *)(lVar15 + 44);
        }
        uVar5 = FUN_1817ff280(lVar18,uVar5,DAT_181d67d78);
        lVar7.isSummon = uVar5;
        switchD_18078b3a0_caseD_2:
        if (lVar7.isSummon < 0) {
          lVar7 = FUN_18046c0a0(0);
          if ((((this.gambleUIPanel == null) ||
               (lVar13 = GameObject.get_transform(this.gambleUIPanel,0)) == null) ||
              (lVar13 = Transform.Find(lVar13,"EnemyDice",0)) == null) ||
             (puVar8 = (uint64 *)Transform.get_position(&local_88,lVar13,0), uVar9 = "不重投",
             lVar7 == null)) goto LAB_18078c4cb;
          uVar10 = *puVar8;
          uVar4 = *(uint32 *)(puVar8 + 1);
          puVar8 = (uint64 *)Color.get_yellow(&local_b8,0);
          uVar19 = *puVar8;
          uVar14 = puVar8[1];
          uStack_a4 = 0x3dcccccd;
          local_a8 = 0;
          uStack_a0 = 0;
          local_98 = (uint32)uVar19;
          uStack_94 = (uint32)((uint64)uVar19 >> 32);
          uStack_90 = (uint32)uVar14;
          uStack_8c = (uint32)((uint64)uVar14 >> 32);
          local_88 = (uint32)uVar10;
          uStack_84 = (uint32)((uint64)uVar10 >> 32);
          uStack_80 = uVar4;
          GameController.ShowTextAtPos
                    (lVar7,uVar9,&local_88,20,&local_98,&local_a8,0,CONCAT44(uVar24,9),"UIAtlas",0,0
                     ,0);
          GambleUIController.ShowBetUI(this,0);
        }
        else {
          uVar9 = DOTween.Sequence(0);
          if (lVar7.isSummon == null) {
            plVar11 = (int64 *)Resources.Load("Sound/SoundEffect/RollDice",0);
            plVar16 = (int64 *)0;
            if ((plVar11 != (int64 *)0) && (plVar16 = (int64 *)0, *plVar11 == DAT_181d8a228)) {
              plVar16 = plVar11;
            }
            NGUITools.PlaySound(plVar16,0);
            if ((this.gambleUIPanel == null) ||
               (lVar13 = GameObject.get_transform(this.gambleUIPanel,0)) == null)
            goto LAB_18078c4cb;
            lVar13 = Transform.Find(lVar13,"EnemyDice",0);
            uVar10 = Int32.ToString(lVar7 + 16,0);
            if ((lVar13 == null) || (lVar13 = Transform.Find(lVar13,uVar10,0)) == null)
            goto LAB_18078c4cb;
            uVar10 = Transform.Find(lVar13,"Cover",0);
            uVar23 = 0;
            local_a8 = 0x41800000;
            uVar22 = 1;
            in_stack_ffffffffffffff00 = in_stack_ffffffffffffff00 & 0xffffffffffffff00;
            uVar21 = CONCAT44(uVar4,0x42b40000);
            uStack_a4 = 0;
            uStack_a0 = 0;
            uVar19 = ShortcutExtensions.DOShakePosition(uVar10);
            uVar14 = il2cpp_internal(DAT_181d88bd8);
            OnTooltipCB.ctor(uVar14,lVar7,DAT_181d7af88,0,uVar21,in_stack_ffffffffffffff00,uVar22,uVar23)
            ;
            uVar10 = DAT_181d96ff8;
          }
          else {
            if ((this.gambleUIPanel == null) ||
               (lVar13 = GameObject.get_transform(this.gambleUIPanel,0)) == null) {
        LAB_18078c4cb:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar13 = Transform.Find(lVar13,"EnemyDice",0);
            uVar10 = Int32.ToString(lVar7 + 16,0);
            if ((lVar13 == null) || (lVar13 = Transform.Find(lVar13,uVar10,0)) == null)
            goto LAB_18078c4cb;
            uVar10 = Transform.Find(lVar13,"Cover",0);
            uStack_a4 = 0x420c0000;
            local_a8 = 0;
            uStack_a0 = 0;
            uVar10 = ShortcutExtensions.DOLocalMove(uVar10,&local_a8,0x3f000000,0,0);
            TweenSettingsExtensions.Append(uVar9,uVar10,0);
            if ((this.gambleUIPanel == null) ||
               (lVar13 = GameObject.get_transform(this.gambleUIPanel,0)) == null)
            goto LAB_18078c4cb;
            lVar13 = Transform.Find(lVar13,"EnemyDice",0);
            uVar10 = Int32.ToString(lVar7 + 16,0);
            if ((lVar13 == null) || (lVar13 = Transform.Find(lVar13,uVar10,0)) == null)
            goto LAB_18078c4cb;
            uVar10 = Transform.Find(lVar13,"Cover",0);
            local_a8 = 0x41800000;
            uStack_a4 = 0;
            uStack_a0 = 0;
            uVar10 = ShortcutExtensions.DOShakePosition(uVar10);
            local_c8 = (uint32)uVar10;
            uStack_c4 = (uint32)((uint64)uVar10 >> 32);
            lVar13 = *(int64 *)(pStatics_25a8 + 16);
            if (lVar13 == null) {
              uVar10 = **(uint64 **)(DAT_181d525a8 + 184);
              lVar13 = new OnTooltipCB(uVar10,DAT_181d7ae08,0);
              plVar11 = (int64 *)(pStatics_25a8 + 16);
              *plVar11 = lVar13;
              il2cpp_internal(plVar11,lVar13);
            }
            uVar10 = TweenSettingsExtensions.OnStart(CONCAT44(uStack_c4,local_c8),lVar13,DAT_181d97298);
            uVar19 = new OnTooltipCB(lVar7,DAT_181d7b008,0);
            uVar10 = TweenSettingsExtensions.OnComplete(uVar10,uVar19,DAT_181d96ff8);
            TweenSettingsExtensions.Append(uVar9,uVar10,0);
            if ((this.gambleUIPanel == null) ||
               (lVar13 = GameObject.get_transform(this.gambleUIPanel,0)) == null)
            goto LAB_18078c4cb;
            lVar13 = Transform.Find(lVar13,"EnemyDice",0);
            uVar10 = Int32.ToString(lVar7 + 16,0);
            if ((lVar13 == null) || (lVar7 = Transform.Find(lVar13,uVar10,0)) == null)
            goto LAB_18078c4cb;
            uVar10 = Transform.Find(lVar7,"Cover",0);
            uStack_a4 = 0x43070000;
            local_a8 = 0;
            uStack_a0 = 0;
            uVar19 = ShortcutExtensions.DOLocalMove(uVar10,&local_a8,0x3f000000,0,0);
            uVar14 = new OnTooltipCB(this,DAT_181d9b7b8,0);
            uVar10 = DAT_181d96ee8;
          }
          uVar10 = TweenSettingsExtensions.OnComplete(uVar19,uVar14,uVar10);
          TweenSettingsExtensions.Append(uVar9,uVar10,0);
        }
    }

    // Token : 0x60014C4
    // RVA   : 0x78C8B0   Offset: 0x78B0B0   Length: 0x905
    public void RerollButtonClicked(GameObject buttonClicked)
    {
        var pStatics = *(int64*)(DAT_181d525a8 + 184);
        uint uVar1;
        long lVar2;
        ulong uVar3;
        long lVar4;
        ulong uVar5;
        ulong uVar6;
        ulong uVar7;
        ulong in_stack_ffffffffffffffa8;
        uint uVar9;
        uint local_38;
        ulong local_34;
        uVar9 = (uint32)((uint64)in_stack_ffffffffffffffa8 >> 32);
        lVar2 = new c.DisplayClass9_0(0);
        if (lVar2 != null) {
          *(int64 *)(lVar2 + 16) = this;
          if (buttonClicked != null) {
            uVar3 = Object.get_name(buttonClicked,0);
            uVar1 = Int32.Parse(uVar3,0);
            *(uint32 *)(lVar2 + 24) = uVar1;
            if (this.gambleUIPanel != null) {
              lVar4 = GameObject.get_transform(this.gambleUIPanel,0);
              if (lVar4 != null) {
                lVar4 = Transform.Find(lVar4,"RerollButton",0);
                if (lVar4 != null) {
                  lVar4 = Component.get_gameObject(lVar4,0);
                  if (lVar4 != null) {
                    GameObject.SetActive(lVar4,0,0);
                    if (this.nextButton != null) {
                      lVar4 = GameObject.GetComponent(this.nextButton,DAT_181d9ee60);
                      if (lVar4 != null) {
                        Selectable.set_interactable(lVar4,0,0);
                        uVar3 = DOTween.Sequence(0);
                        lVar4 = this.gambleUIPanel;
                        if (*(int *)(lVar2 + 24) == 0) {
                          if (lVar4 != null) {
                            lVar4 = GameObject.get_transform(lVar4,0);
                            if (lVar4 != null) {
                              lVar4 = Transform.Find(lVar4,"PlayerDice",0);
                              uVar5 = Int32.ToString(lVar2 + 24,0);
                              if (lVar4 != null) {
                                lVar4 = Transform.Find(lVar4,uVar5,0);
                                if (lVar4 != null) {
                                  lVar4 = Transform.Find(lVar4,"Cover",0);
                                  if (lVar4 != null) {
                                    uVar5 = Component.GetComponent(lVar4,DAT_181d6bc40);
                                    uVar5 = DOTweenModuleUI.DOFade(uVar5,0x3f800000,0x3f000000,0);
                                    TweenSettingsExtensions.Append(uVar3,uVar5,0);
                                    if (this.gambleUIPanel != null) {
                                      lVar4 = GameObject.get_transform(this.gambleUIPanel,0);
                                      if (lVar4 != null) {
                                        lVar4 = Transform.Find(lVar4,"PlayerDice",0);
                                        uVar5 = Int32.ToString(lVar2 + 24,0);
                                        if (lVar4 != null) {
                                          lVar4 = Transform.Find(lVar4,uVar5,0);
                                          if (lVar4 != null) {
                                            uVar5 = Transform.Find(lVar4,"Cover",0);
                                            local_38 = 0x41800000;
                                            local_34 = 0;
                                            uVar5 = ShortcutExtensions.DOShakePosition
                                                              (uVar5,0x3f800000,&local_38,25,
                                                               CONCAT44(uVar9,0x42b40000),0,1,0);
                                            lVar4 = *(int64 *)
                                                     (pStatics + 40);
                                            if (lVar4 == null) {
                                              uVar6 = **(uint64 **)(DAT_181d525a8 + 184);
                                              lVar4 = new OnTooltipCB(uVar6,DAT_181d7ae88,0);
                                              plVar8 = (int64 *)
                                                       (pStatics + 40);
                                              *plVar8 = lVar4;
                                              il2cpp_internal(plVar8,lVar4);
                                            }
                                            uVar5 = TweenSettingsExtensions.OnStart
                                                              (uVar5,lVar4,DAT_181d97298);
                                            uVar6 = new OnTooltipCB(lVar2,DAT_181d7b088,0);
                                            uVar5 = TweenSettingsExtensions.OnComplete
                                                              (uVar5,uVar6,DAT_181d96ff8);
                                            TweenSettingsExtensions.Append(uVar3,uVar5,0);
                                            if (this.gambleUIPanel != null) {
                                              lVar4 = GameObject.get_transform
                                                                (this.gambleUIPanel,0);
                                              if (lVar4 != null) {
                                                lVar4 = Transform.Find(lVar4,"PlayerDice",0);
                                                uVar5 = Int32.ToString(lVar2 + 24,0);
                                                if (lVar4 != null) {
                                                  lVar4 = Transform.Find(lVar4,uVar5,0);
                                                  if (lVar4 != null) {
                                                    lVar4 = Transform.Find(lVar4,"Cover",0);
                                                    if (lVar4 != null) {
                                                      uVar5 = Component.GetComponent(lVar4,DAT_181d6bc40)
                                                      ;
                                                      uVar6 = DOTweenModuleUI.DOFade
                                                                        (uVar5,0x3e800000,0x3f000000,0);
                                                      uVar7 = new OnTooltipCB(lVar2,DAT_181d7b108,0);
                                                      uVar5 = DAT_181d96cc8;
                                                      goto LAB_18078ce3f;
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
                        else if (lVar4 != null) {
                          lVar4 = GameObject.get_transform(lVar4,0);
                          if (lVar4 != null) {
                            lVar4 = Transform.Find(lVar4,"PlayerDice",0);
                            uVar5 = Int32.ToString(lVar2 + 24,0);
                            if (lVar4 != null) {
                              lVar4 = Transform.Find(lVar4,uVar5,0);
                              if (lVar4 != null) {
                                uVar5 = Transform.Find(lVar4,"Cover",0);
                                local_38 = 0;
                                local_34 = 0x420c0000;
                                uVar9 = 0;
                                uVar5 = ShortcutExtensions.DOLocalMove(uVar5,&local_38,0x3f000000,0,0);
                                TweenSettingsExtensions.Append(uVar3,uVar5,0);
                                if (this.gambleUIPanel != null) {
                                  lVar4 = GameObject.get_transform(this.gambleUIPanel,0);
                                  if (lVar4 != null) {
                                    lVar4 = Transform.Find(lVar4,"PlayerDice",0);
                                    uVar5 = Int32.ToString(lVar2 + 24,0);
                                    if (lVar4 != null) {
                                      lVar4 = Transform.Find(lVar4,uVar5,0);
                                      if (lVar4 != null) {
                                        uVar5 = Transform.Find(lVar4,"Cover",0);
                                        local_38 = 0x41800000;
                                        local_34 = 0;
                                        uVar5 = ShortcutExtensions.DOShakePosition
                                                          (uVar5,0x3f800000,&local_38,25,
                                                           CONCAT44(uVar9,0x42b40000),0,1,0);
                                        lVar4 = *(int64 *)(pStatics + 48);
                                        if (lVar4 == null) {
                                          uVar6 = **(uint64 **)(DAT_181d525a8 + 184);
                                          lVar4 = new OnTooltipCB(uVar6,DAT_181d7af08,0);
                                          plVar8 = (int64 *)
                                                   (pStatics + 48);
                                          *plVar8 = lVar4;
                                          il2cpp_internal(plVar8,lVar4);
                                        }
                                        uVar5 = TweenSettingsExtensions.OnStart
                                                          (uVar5,lVar4,DAT_181d97298);
                                        uVar6 = new OnTooltipCB(lVar2,DAT_181d7b188,0);
                                        uVar5 = TweenSettingsExtensions.OnComplete
                                                          (uVar5,uVar6,DAT_181d96ff8);
                                        TweenSettingsExtensions.Append(uVar3,uVar5,0);
                                        if (this.gambleUIPanel != null) {
                                          lVar4 = GameObject.get_transform
                                                            (this.gambleUIPanel,0);
                                          if (lVar4 != null) {
                                            lVar4 = Transform.Find(lVar4,"PlayerDice",0);
                                            uVar5 = Int32.ToString(lVar2 + 24,0);
                                            if (lVar4 != null) {
                                              lVar4 = Transform.Find(lVar4,uVar5,0);
                                              if (lVar4 != null) {
                                                uVar5 = Transform.Find(lVar4,"Cover",0);
                                                local_38 = 0;
                                                local_34 = 0x43070000;
                                                uVar6 = ShortcutExtensions.DOLocalMove
                                                                  (uVar5,&local_38,0x3f000000,0,0);
                                                uVar7 = new OnTooltipCB(lVar2,DAT_181d7b208,0);
                                                uVar5 = DAT_181d96ee8;
        LAB_18078ce3f:
                                                uVar5 = TweenSettingsExtensions.OnComplete
                                                                  (uVar6,uVar7,uVar5);
                                                TweenSettingsExtensions.Append(uVar3,uVar5,0);
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

    // Token : 0x60014C5
    // RVA   : 0x78DBC0   Offset: 0x78C3C0   Length: 0x1C4
    public void ShowBetUI()
    {
        long lVar1;
        ulong uVar3;
        ulong uVar4;
        ulong local_28;
        uint local_20;
        byte[] local_18 = new byte[16];
        GambleUIController.SetNextButtonText(this,"下注",0);
        if (this.gambleUIPanel != null) {
          lVar1 = GameObject.get_transform(this.gambleUIPanel,0);
          if (lVar1 != null) {
            lVar1 = Transform.Find(lVar1,"BetTab",0);
            if (lVar1 != null) {
              lVar1 = Component.get_gameObject(lVar1,0);
              if (lVar1 != null) {
                GameObject.SetActive(lVar1,1,0);
                if (this.gambleUIPanel != null) {
                  lVar1 = GameObject.get_transform(this.gambleUIPanel,0);
                  if (lVar1 != null) {
                    lVar1 = Transform.Find(lVar1,"BetTab",0);
                    puVar2 = (uint64 *)Vector3.get_zero(local_18,0);
                    if (lVar1 != null) {
                      local_20 = *(uint32 *)(puVar2 + 1);
                      local_28 = *puVar2;
                      Transform.set_localScale(lVar1,&local_28,0);
                      if (this.gambleUIPanel != null) {
                        lVar1 = GameObject.get_transform(this.gambleUIPanel,0);
                        if (lVar1 != null) {
                          uVar3 = Transform.Find(lVar1,"BetTab",0);
                          uVar3 = ShortcutExtensions.DOScale(uVar3,0x3f800000,0x3e800000,0);
                          uVar4 = new OnTooltipCB(this,DAT_181d9b840,0);
                          TweenSettingsExtensions.OnComplete(uVar3,uVar4,DAT_181d96ee8);
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

    // Token : 0x60014C6
    // RVA   : 0x78D3E0   Offset: 0x78BBE0   Length: 0x20B
    public void RerollPlayerDice(int rerollID)
    {
        int iVar1;
        uint uVar2;
        uint uVar3;
        long lVar4;
        ulong uVar5;
        long lVar6;
        long lVar7;
        long lVar8;
        uint[] local_res10 = new uint[2];
        local_res10[0] = rerollID;
        lVar4 = this.playerDiceResult;
        iVar1 = this.playerDiceResultTotal;
        lVar8 = (int64)(int)local_res10[0];
        if (lVar4 != null) {
          lVar6 = lVar4;
          if (lVar4.Count <= local_res10[0]) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
            lVar6 = this.playerDiceResult;
          }
          uVar2 = local_res10[0];
          this.playerDiceResultTotal =
               (iVar1 - *(int *)(lVar4._items + 32 + lVar8 * 4)) + -1;
          uVar3 = FUN_180d8cf10(0,6);
          if (lVar6 != null) {
            FUN_18181e970(lVar6,uVar2,uVar3,DAT_181d68370);
            lVar4 = this.playerDiceResult;
            iVar1 = this.playerDiceResultTotal;
            lVar8 = (int64)(int)local_res10[0];
            if (lVar4 != null) {
              if (lVar4.Count <= local_res10[0]) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              this.playerDiceResultTotal =
                   iVar1 + 1 + *(int *)(lVar4._items + 32 + lVar8 * 4);
              if (this.gambleUIPanel != null) {
                lVar4 = GameObject.get_transform(this.gambleUIPanel,0);
                if (lVar4 != null) {
                  lVar4 = Transform.Find(lVar4,"PlayerDice",0);
                  uVar5 = Int32.ToString(local_res10,0);
                  if (lVar4 != null) {
                    lVar4 = Transform.Find(lVar4,uVar5,0);
                    if (lVar4 != null) {
                      lVar4 = Transform.Find(lVar4,"Dice",0);
                      if (lVar4 != null) {
                        lVar6 = Component.GetComponent(lVar4,DAT_181d6bc40);
                        lVar4 = this.diceSprite;
                        lVar8 = this.playerDiceResult;
                        lVar7 = (int64)(int)local_res10[0];
                        if (lVar8 != null) {
                          if (lVar8.Count <= local_res10[0]) {
                            ThrowHelper.ThrowArgumentOutOfRangeException(0);
                          }
                          if (lVar4 != null) {
                            uVar2 = *(uint32 *)(lVar8._items + 32 + lVar7 * 4);
                            if (lVar4.Count <= uVar2) {
                              ThrowHelper.ThrowArgumentOutOfRangeException(0);
                            }
                            if (lVar6 != null) {
                              Image.set_sprite(lVar6,*(uint64 *)
                                                       (lVar4._items + 32 +
                                                       (int64)(int)uVar2 * 8),0);
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

    // Token : 0x60014C7
    // RVA   : 0x78D1C0   Offset: 0x78B9C0   Length: 0x217
    public void RerollEnemyDice(int rerollID)
    {
        int iVar1;
        uint uVar2;
        uint uVar3;
        long lVar4;
        ulong uVar5;
        long lVar6;
        long lVar7;
        long lVar8;
        uint[] local_res10 = new uint[2];
        local_res10[0] = rerollID;
        lVar4 = this.enemyDiceResult;
        iVar1 = this.enemyDiceResultTotal;
        lVar8 = (int64)(int)local_res10[0];
        if (lVar4 != null) {
          lVar6 = lVar4;
          if (lVar4.Count <= local_res10[0]) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
            lVar6 = this.enemyDiceResult;
          }
          uVar2 = local_res10[0];
          this.enemyDiceResultTotal =
               (iVar1 - *(int *)(lVar4._items + 32 + lVar8 * 4)) + -1;
          uVar3 = FUN_180d8cf10(0,6);
          if (lVar6 != null) {
            FUN_18181e970(lVar6,uVar2,uVar3,DAT_181d68370);
            lVar4 = this.enemyDiceResult;
            iVar1 = this.enemyDiceResultTotal;
            lVar8 = (int64)(int)local_res10[0];
            if (lVar4 != null) {
              if (lVar4.Count <= local_res10[0]) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              this.enemyDiceResultTotal =
                   iVar1 + 1 + *(int *)(lVar4._items + 32 + lVar8 * 4);
              if (this.gambleUIPanel != null) {
                lVar4 = GameObject.get_transform(this.gambleUIPanel,0);
                if (lVar4 != null) {
                  lVar4 = Transform.Find(lVar4,"EnemyDice",0);
                  uVar5 = Int32.ToString(local_res10,0);
                  if (lVar4 != null) {
                    lVar4 = Transform.Find(lVar4,uVar5,0);
                    if (lVar4 != null) {
                      lVar4 = Transform.Find(lVar4,"Dice",0);
                      if (lVar4 != null) {
                        lVar6 = Component.GetComponent(lVar4,DAT_181d6bc40);
                        lVar4 = this.diceSprite;
                        lVar8 = this.enemyDiceResult;
                        lVar7 = (int64)(int)local_res10[0];
                        if (lVar8 != null) {
                          if (lVar8.Count <= local_res10[0]) {
                            ThrowHelper.ThrowArgumentOutOfRangeException(0);
                          }
                          if (lVar4 != null) {
                            uVar2 = *(uint32 *)(lVar8._items + 32 + lVar7 * 4);
                            if (lVar4.Count <= uVar2) {
                              ThrowHelper.ThrowArgumentOutOfRangeException(0);
                            }
                            if (lVar6 != null) {
                              Image.set_sprite(lVar6,*(uint64 *)
                                                       (lVar4._items + 32 +
                                                       (int64)(int)uVar2 * 8),0);
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

    // Token : 0x60014C8
    // RVA   : 0x788DC0   Offset: 0x7875C0   Length: 0x1B
    public int GetBetRate()
    {
        char FUN_180788dc0(int64 this)
        {
        char cVar1;
        char cVar2;
        cVar2 = (this.playerDiceResultLv == 5) + true;
        cVar1 = cVar2 * '\x02';
        if (this.enemyDiceResultLv != 5) {
          cVar1 = cVar2;
        }
        return cVar1;
    }

    // Token : 0x60014C9
    // RVA   : 0x788DE0   Offset: 0x7875E0   Length: 0x398
    public int GetDiceResultLv(List<int> diceResult)
    {
        int iVar1;
        uint uVar2;
        ulong uVar3;
        long lVar4;
        long lVar5;
        if (diceResult != null) {
          uVar3 = FUN_180f582c0(diceResult,DAT_181d680f0);
          lVar4 = il2cpp_internal(DAT_181d6f030);
          FUN_18182e120(lVar4,uVar3,DAT_181d67978);
          if (lVar4 != null) {
            List_1.Sort(lVar4,DAT_181d67ff0);
            uVar2 = *(uint32 *)(lVar4 + 24);
            if (uVar2 == 0) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
              uVar2 = *(uint32 *)(lVar4 + 24);
            }
            lVar5 = *(int64 *)(lVar4 + 16);
            iVar1 = *(int *)(lVar5 + 32);
            if (uVar2 < 2) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
              lVar5 = *(int64 *)(lVar4 + 16);
            }
            if (iVar1 == *(int *)(lVar5 + 36)) {
              uVar2 = *(uint32 *)(lVar4 + 24);
              if (uVar2 < 2) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
                lVar5 = *(int64 *)(lVar4 + 16);
                uVar2 = *(uint32 *)(lVar4 + 24);
              }
              iVar1 = *(int *)(lVar5 + 36);
              if (uVar2 < 3) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
                lVar5 = *(int64 *)(lVar4 + 16);
              }
              if (iVar1 == *(int *)(lVar5 + 40)) {
                uVar2 = *(uint32 *)(lVar4 + 24);
                if (uVar2 < 3) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  lVar5 = *(int64 *)(lVar4 + 16);
                  uVar2 = *(uint32 *)(lVar4 + 24);
                }
                iVar1 = *(int *)(lVar5 + 40);
                if (uVar2 < 4) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  lVar5 = *(int64 *)(lVar4 + 16);
                }
                if (iVar1 == *(int *)(lVar5 + 44)) {
                  return 5;
                }
              }
            }
            uVar2 = *(uint32 *)(lVar4 + 24);
            if (uVar2 == 0) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
              lVar5 = *(int64 *)(lVar4 + 16);
              uVar2 = *(uint32 *)(lVar4 + 24);
            }
            iVar1 = *(int *)(lVar5 + 32);
            if (uVar2 < 2) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
              lVar5 = *(int64 *)(lVar4 + 16);
            }
            if (iVar1 + 1 == *(int *)(lVar5 + 36)) {
              uVar2 = *(uint32 *)(lVar4 + 24);
              if (uVar2 < 2) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
                lVar5 = *(int64 *)(lVar4 + 16);
                uVar2 = *(uint32 *)(lVar4 + 24);
              }
              iVar1 = *(int *)(lVar5 + 36);
              if (uVar2 < 3) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
                lVar5 = *(int64 *)(lVar4 + 16);
              }
              if (iVar1 + 1 == *(int *)(lVar5 + 40)) {
                uVar2 = *(uint32 *)(lVar4 + 24);
                if (uVar2 < 3) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  lVar5 = *(int64 *)(lVar4 + 16);
                  uVar2 = *(uint32 *)(lVar4 + 24);
                }
                iVar1 = *(int *)(lVar5 + 40);
                if (uVar2 < 4) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  lVar5 = *(int64 *)(lVar4 + 16);
                }
                if (iVar1 + 1 == *(int *)(lVar5 + 44)) {
                  return 4;
                }
              }
            }
            uVar2 = *(uint32 *)(lVar4 + 24);
            if (uVar2 < 2) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
              lVar5 = *(int64 *)(lVar4 + 16);
              uVar2 = *(uint32 *)(lVar4 + 24);
            }
            iVar1 = *(int *)(lVar5 + 36);
            if (uVar2 < 3) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
              lVar5 = *(int64 *)(lVar4 + 16);
            }
            if (iVar1 == *(int *)(lVar5 + 40)) {
              uVar2 = *(uint32 *)(lVar4 + 24);
              if (uVar2 == 0) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
                lVar5 = *(int64 *)(lVar4 + 16);
                uVar2 = *(uint32 *)(lVar4 + 24);
              }
              iVar1 = *(int *)(lVar5 + 32);
              if (uVar2 < 2) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
                lVar5 = *(int64 *)(lVar4 + 16);
              }
              if (iVar1 != *(int *)(lVar5 + 36)) {
                uVar2 = *(uint32 *)(lVar4 + 24);
                if (uVar2 < 3) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  lVar5 = *(int64 *)(lVar4 + 16);
                  uVar2 = *(uint32 *)(lVar4 + 24);
                }
                iVar1 = *(int *)(lVar5 + 40);
                if (uVar2 < 4) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  lVar5 = *(int64 *)(lVar4 + 16);
                }
                if (iVar1 == *(int *)(lVar5 + 44))
                {
                  }
                  return 3;
                  }
                }
            uVar2 = *(uint32 *)(lVar4 + 24);
            if (uVar2 == 0) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
              lVar5 = *(int64 *)(lVar4 + 16);
              uVar2 = *(uint32 *)(lVar4 + 24);
            }
            iVar1 = *(int *)(lVar5 + 32);
            if (uVar2 < 2) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
              lVar5 = *(int64 *)(lVar4 + 16);
            }
            if (iVar1 == *(int *)(lVar5 + 36)) {
              uVar2 = *(uint32 *)(lVar4 + 24);
              if (uVar2 < 3) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
                lVar5 = *(int64 *)(lVar4 + 16);
                uVar2 = *(uint32 *)(lVar4 + 24);
              }
              iVar1 = *(int *)(lVar5 + 40);
              if (uVar2 < 4) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
                lVar5 = *(int64 *)(lVar4 + 16);
              }
              if (iVar1 == *(int *)(lVar5 + 44)) {
                return 2;
              }
            }
            uVar2 = *(uint32 *)(lVar4 + 24);
            if (uVar2 == 0) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
              lVar5 = *(int64 *)(lVar4 + 16);
              uVar2 = *(uint32 *)(lVar4 + 24);
            }
            iVar1 = *(int *)(lVar5 + 32);
            if (uVar2 < 2) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
              lVar5 = *(int64 *)(lVar4 + 16);
            }
            if (iVar1 != *(int *)(lVar5 + 36)) {
              uVar2 = *(uint32 *)(lVar4 + 24);
              if (uVar2 < 2) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
                lVar5 = *(int64 *)(lVar4 + 16);
                uVar2 = *(uint32 *)(lVar4 + 24);
              }
              iVar1 = *(int *)(lVar5 + 36);
              if (uVar2 < 3) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
                lVar5 = *(int64 *)(lVar4 + 16);
              }
              if (iVar1 != *(int *)(lVar5 + 40)) {
                uVar2 = *(uint32 *)(lVar4 + 24);
                if (uVar2 < 3) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  lVar5 = *(int64 *)(lVar4 + 16);
                  uVar2 = *(uint32 *)(lVar4 + 24);
                }
                iVar1 = *(int *)(lVar5 + 40);
                if (uVar2 < 4) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  lVar5 = *(int64 *)(lVar4 + 16);
                }
                if (iVar1 != *(int *)(lVar5 + 44)) {
                  return 0;
                }
              }
            }
            return 1;
          }
        }
    }

    // Token : 0x60014CA
    // RVA   : 0x78EF70   Offset: 0x78D770   Length: 0xC2
    public void /*ctor*/()
    {
        long lVar1;
        lVar1 = il2cpp_internal(DAT_181d6e230);
        FUN_180f58a90(lVar1,DAT_181d616f8);
        if (lVar1 != null) {
          FUN_181814fa0(lVar1,0,DAT_181d61778);
          FUN_181814fa0(lVar1,0,DAT_181d61778);
          FUN_181814fa0(lVar1,0,DAT_181d61778);
          this.gambleResults = lVar1;
          FUN_18044ef50(this,0);
          return;
        }
    }

    // Token : 0x60014CB
    // RVA   : 0x78E990   Offset: 0x78D190   Length: 0x5DE
    private static void /*cctor*/()
    {
        var pStatics = *(int64*)(DAT_181d4de90 + 184);
        long lVar1;
        lVar1 = il2cpp_internal(DAT_181d72a30);
        FUN_180f58a90(lVar1,DAT_181d7c250);
        if (lVar1 != null) {
          FUN_181827900(lVar1,"杂色",DAT_181d7c3d0);
          FUN_181827900(lVar1,"一对",DAT_181d7c3d0);
          FUN_181827900(lVar1,"两双",DAT_181d7c3d0);
          FUN_181827900(lVar1,"三条",DAT_181d7c3d0);
          FUN_181827900(lVar1,"四顺",DAT_181d7c3d0);
          FUN_181827900(lVar1,"同花",DAT_181d7c3d0);
          plVar2 = pStatics;
          *plVar2 = lVar1;
          il2cpp_internal(plVar2,lVar1);
          lVar1 = il2cpp_internal(DAT_181d6f030);
          FUN_180f58a90(lVar1,DAT_181d678f8);
          if (lVar1 != null) {
            FUN_181814fa0(lVar1,10,DAT_181d67a78);
            FUN_181814fa0(lVar1,20,DAT_181d67a78);
            FUN_181814fa0(lVar1,30,DAT_181d67a78);
            plVar2 = (int64 *)(pStatics + 8);
            *plVar2 = lVar1;
            il2cpp_internal(plVar2,lVar1);
            lVar1 = il2cpp_internal(DAT_181d72a30);
            FUN_180f58a90(lVar1,DAT_181d7c250);
            if (lVar1 != null) {
              FUN_181827900(lVar1,"天灵灵地灵灵",DAT_181d7c3d0);
              FUN_181827900(lVar1,"这次手气如何？",DAT_181d7c3d0);
              FUN_181827900(lVar1,"成败在此一举",DAT_181d7c3d0);
              FUN_181827900(lVar1,"同花！同花！同花！",DAT_181d7c3d0);
              FUN_181827900(lVar1,"这次一定红！",DAT_181d7c3d0);
              FUN_181827900(lVar1,"今天便要教你开开眼界",DAT_181d7c3d0);
              FUN_181827900(lVar1,"买定离手！",DAT_181d7c3d0);
              FUN_181827900(lVar1,"血战到底",DAT_181d7c3d0);
              FUN_181827900(lVar1,"小赌怡情，大赌伤身",DAT_181d7c3d0);
              FUN_181827900(lVar1,"人无千日好，花无百日红",DAT_181d7c3d0);
              FUN_181827900(lVar1,"时来运转",DAT_181d7c3d0);
              FUN_181827900(lVar1,"知己知彼，百战不殆",DAT_181d7c3d0);
              FUN_181827900(lVar1,"成王败寇，在此一把",DAT_181d7c3d0);
              plVar2 = (int64 *)(pStatics + 16);
              *plVar2 = lVar1;
              il2cpp_internal(plVar2,lVar1);
              lVar1 = il2cpp_internal(DAT_181d72a30);
              FUN_180f58a90(lVar1,DAT_181d7c250);
              if (lVar1 != null) {
                FUN_181827900(lVar1,"承让承让",DAT_181d7c3d0);
                FUN_181827900(lVar1,"哈哈，赢了！",DAT_181d7c3d0);
                FUN_181827900(lVar1,"还是我技高一筹！",DAT_181d7c3d0);
                FUN_181827900(lVar1,"稳如泰山",DAT_181d7c3d0);
                FUN_181827900(lVar1,"手气来了",DAT_181d7c3d0);
                plVar2 = (int64 *)(pStatics + 24);
                *plVar2 = lVar1;
                il2cpp_internal(plVar2,lVar1);
                lVar1 = il2cpp_internal(DAT_181d72a30);
                FUN_180f58a90(lVar1,DAT_181d7c250);
                if (lVar1 != null) {
                  FUN_181827900(lVar1,"该死，早知如此...",DAT_181d7c3d0);
                  FUN_181827900(lVar1,"悔不当初",DAT_181d7c3d0);
                  FUN_181827900(lVar1,"愿赌服输",DAT_181d7c3d0);
                  FUN_181827900(lVar1,"兵败如山倒",DAT_181d7c3d0);
                  FUN_181827900(lVar1,"哼！就差一点",DAT_181d7c3d0);
                  plVar2 = (int64 *)(pStatics + 32);
                  *plVar2 = lVar1;
                  il2cpp_internal(plVar2,lVar1);
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x60014CC
    // RVA   : 0x78E660   Offset: 0x78CE60   Length: 0x1A0
    private void <NextButtonClicked>b__42_5()
    {
        long lVar1;
        ulong uVar3;
        ulong local_28;
        uint local_20;
        byte[] local_18 = new byte[16];
        GambleUIController.SetNextButtonText(this,"跳过",0);
        if (this.nextButton != null) {
          lVar1 = GameObject.GetComponent(this.nextButton,DAT_181d9ee60);
          if (lVar1 != null) {
            Selectable.set_interactable(lVar1,1,0);
            if (this.gambleUIPanel != null) {
              lVar1 = GameObject.get_transform(this.gambleUIPanel,0);
              if (lVar1 != null) {
                lVar1 = Transform.Find(lVar1,"RerollButton",0);
                if (lVar1 != null) {
                  lVar1 = Component.get_gameObject(lVar1,0);
                  if (lVar1 != null) {
                    GameObject.SetActive(lVar1,1,0);
                    if (this.gambleUIPanel != null) {
                      lVar1 = GameObject.get_transform(this.gambleUIPanel,0);
                      if (lVar1 != null) {
                        lVar1 = Transform.Find(lVar1,"RerollButton",0);
                        puVar2 = (uint64 *)Vector3.get_zero(local_18,0);
                        if (lVar1 != null) {
                          local_20 = *(uint32 *)(puVar2 + 1);
                          local_28 = *puVar2;
                          Transform.set_localScale(lVar1,&local_28,0);
                          if (this.gambleUIPanel != null) {
                            lVar1 = GameObject.get_transform(this.gambleUIPanel,0);
                            if (lVar1 != null) {
                              uVar3 = Transform.Find(lVar1,"RerollButton",0);
                              ShortcutExtensions.DOScale(uVar3,0x3f800000,0x3e4ccccd,0);
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

    // Token : 0x60014CD
    // RVA   : 0x78E810   Offset: 0x78D010   Length: 0x7
    private void <NextButtonClicked>b__42_9()
    {
        void FUN_18078e810(uint64 this)
        {
        GambleUIController.ShowBetUI(this,0);
    }

    // Token : 0x60014CE
    // RVA   : 0x78E570   Offset: 0x78CD70   Length: 0x44
    private void <NextButtonClicked>b__42_2()
    {
        MonoBehaviour.Invoke(this,"NextButtonClicked",0x3f800000,0);
    }

    // Token : 0x60014CF
    // RVA   : 0x78E5C0   Offset: 0x78CDC0   Length: 0x9C
    private void <NextButtonClicked>b__42_3()
    {
        long lVar1;
        ulong uVar2;
        uVar2 = "下轮";
        if (this.round == 2) {
          uVar2 = "结束";
        }
        GambleUIController.SetNextButtonText(this,uVar2,0);
        if (this.nextButton != null) {
          lVar1 = GameObject.GetComponent(this.nextButton,DAT_181d9ee60);
          if (lVar1 != null) {
            Selectable.set_interactable(lVar1,1,0);
            return;
          }
        }
    }

    // Token : 0x60014D0
    // RVA   : 0x78E560   Offset: 0x78CD60   Length: 0x7
    private void <NextButtonClicked>b__42_10()
    {
        void FUN_18078e560(uint64 this)
        {
        GambleUIController.NextButtonClicked(this,0);
    }

    // Token : 0x60014D1
    // RVA   : 0x78E820   Offset: 0x78D020   Length: 0x63
    private void <ShowBetUI>b__44_0()
    {
        long lVar1;
        if (this.nextButton != null) {
          lVar1 = GameObject.GetComponent(this.nextButton,DAT_181d9ee60);
          if (lVar1 != null) {
            Selectable.set_interactable(lVar1,1,0);
            GambleUIController.SetBetButtonActive(this,1,0);
            return;
          }
        }
    }

}
