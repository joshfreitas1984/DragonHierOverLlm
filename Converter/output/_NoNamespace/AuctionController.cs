// ============================================================
// Type  : AuctionController
// Token : 0x2000147
// ============================================================

public class AuctionController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400081C
    public GameObject auctionPanel;

    // Token: 0x400081D
    public GameObject playerAuctionUI;

    // Token: 0x400081E
    public GameObject startAuctionButton;

    // Token: 0x400081F
    public GameObject leaveAuctionButton;

    // Token: 0x4000820
    public GameObject auctionSlotPrefab;

    // Token: 0x4000821
    public Image timeBar;

    // Token: 0x4000822
    public AuctionStep auctionStep;

    // Token: 0x4000823
    public bool havePlayer;

    // Token: 0x4000824
    public float auctionDifficulty;

    // Token: 0x4000825
    public int round;

    // Token: 0x4000826
    public List<ItemData> auctionItemList;

    // Token: 0x4000827
    public ItemData playerSellItem;

    // Token: 0x4000828
    public List<GameObject> auctionItemIconList;

    // Token: 0x4000829
    public List<HeroData> heroList;

    // Token: 0x400082A
    public List<GameObject> heroIconList;

    // Token: 0x400082B
    public string endMatchCallPlot;

    // Token: 0x400082C
    public string auctionKeeper;

    // Token: 0x400082D
    public float nowOfferMoney;

    // Token: 0x400082E
    public float offerRoundLeftTime;

    // Token: 0x400082F
    private static float offerRoundTotalTime;

    // Token: 0x4000830
    public HeroData nowOfferHero;

    // Token: 0x4000831
    public float nextOfferTime;

    // Token: 0x4000832
    public HeroData nextOfferHero;

    // Token: 0x4000833
    public float playerOfferMoney;

    // Token: 0x4000834
    public bool skipping;

    // Token: 0x4000835
    public GameObject skipButton;

    // Token: 0x4000836
    public GameObject talkPanel;

    // Token: 0x4000837
    public GameObject highLightBack;

    // Token: 0x4000838
    public GameObject highLightCover;

    // Token: 0x4000839
    private GameObject tempObj;

    // Token: 0x400083A
    private static List<string> offerHeroTalk;

    // Token: 0x400083B
    private static List<string> dealHeroTalk;

    // Token: 0x400083C
    private static AuctionController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000A8B
    // RVA   : 0x7F61D0   Offset: 0x7F49D0   Length: 0x58
    public static AuctionController get_Instance()
    {
        return *(uint64 *)(*(int64 *)(DAT_181d8a1a8 + 184) + 24);
    }

    // Token : 0x6000A8C
    // RVA   : 0x7F3520   Offset: 0x7F1D20   Length: 0x68
    private void Awake()
    {
        puVar1 = (uint64 *)(*(int64 *)(DAT_181d8a1a8 + 184) + 24);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x6000A8D
    // RVA   : 0x7F5810   Offset: 0x7F4010   Length: 0x5D6
    private void Update()
    {
        long lVar1;
        ulong uVar2;
        ulong uVar3;
        ulong uVar4;
        float fVar7;
        uint uVar8;
        uint uVar9;
        uint uVar10;
        uint uVar11;
        float fVar12;
        float fVar13;
        int[] local_res8 = new int[2];
        uint local_28;
        uint uStack_24;
        uint uStack_20;
        uint32 uStack_1c;
        local_res8[0] = 0;
        if (this.auctionStep == null) {
          return;
        }
        lVar1 = this.timeBar;
        fVar13 = this.offerRoundLeftTime;
        if (lVar1 != null) {
          Image.set_fillAmount(lVar1,fVar13 / **(float **)(DAT_181d8a1a8 + 184),0);
          if (((this.auctionPanel != null) &&
              (lVar1 = GameObject.get_transform(this.auctionPanel,0)) != null) &&
             (lVar1 = Transform.Find(lVar1,"Round",0)) != null) {
            uVar2 = Component.GetComponent(lVar1,DAT_181d6d8c0);
            uVar8 = this.round;
            uVar3 = GlobalData.GetNumText(uVar8,0);
            uVar3 = String.Format("第{0}件",uVar3,0);
            LTLocalization.SetText(uVar2,uVar3,0);
            if (this.havePlayer) {
              if (((this.playerAuctionUI == null) ||
                  (lVar1 = GameObject.get_transform(this.playerAuctionUI,0)) == null) ||
                 (lVar1 = Transform.Find(lVar1,"PlayerOfferMoney",0)) == null) throw; // [null/range check failed]
              uVar2 = Component.GetComponent(lVar1,DAT_181d6d8c0);
              local_res8[0] = (int)this.playerOfferMoney;
              uVar3 = Int32.ToString(local_res8,0);
              lVar1 = FUN_18046c0a0(0);
              if ((((lVar1 == null) || (*(int64 *)(lVar1 + 32) == 0)) ||
                  (lVar1 = WorldData.Player(*(int64 *)(lVar1 + 32),0)) == null) ||
                 (*(int64 *)(lVar1 + 0x220) == 0)) throw; // [null/range check failed]
              uVar4 = Int32.ToString(*(int64 *)(lVar1 + 0x220) + 24,0);
              uVar3 = String.Concat(uVar3,"/",uVar4,0);
              LTLocalization.SetText(uVar2,uVar3,0);
              if (((this.playerAuctionUI == null) ||
                  (lVar1 = GameObject.get_transform(this.playerAuctionUI,0)) == null) ||
                 (lVar1 = Transform.Find(lVar1,"PlayerOfferMoney",0)) == null) throw; // [null/range check failed]
              plVar5 = (int64 *)Component.GetComponent(lVar1,DAT_181d6d8c0);
              fVar13 = this.playerOfferMoney;
              lVar1 = FUN_18046c0a0(0);
              if (((lVar1 == null) || (*(int64 *)(lVar1 + 32) == 0)) ||
                 ((lVar1 = WorldData.Player(*(int64 *)(lVar1 + 32),0), lVar1 == null ||
                  (*(int64 *)(lVar1 + 0x220) == 0)))) throw; // [null/range check failed]
              if (*(int *)(*(int64 *)(lVar1 + 0x220) + 24) < (int)fVar13) {
                puVar6 = (uint32 *)Color.get_red(&local_28,0);
                uVar8 = *puVar6;
                uVar9 = puVar6[1];
                uVar10 = puVar6[2];
                uVar11 = puVar6[3];
              }
              else {
                lVar1 = *(int64 *)(DAT_181d4ef00 + 184);
                uVar8 = *(uint32 *)(lVar1 + 0x390);
                uVar9 = *(uint32 *)(lVar1 + 0x394);
                uVar10 = *(uint32 *)(lVar1 + 0x398);
                uVar11 = *(uint32 *)(lVar1 + 0x39c);
              }
              if (plVar5 == (int64 *)0) throw; // [null/range check failed]
              local_28 = uVar8;
              uStack_24 = uVar9;
              uStack_20 = uVar10;
              uStack_1c = uVar11;
              (**(code **)(*plVar5 + 0x2a8))(plVar5,&local_28,*(uint64 *)(*plVar5 + 0x2b0));
              if ((((this.playerAuctionUI == null) ||
                   (lVar1 = GameObject.get_transform(this.playerAuctionUI,0)) == null) ||
                  (lVar1 = Transform.Find(lVar1,"AddButton",0)) == null) ||
                 (lVar1 = Component.GetComponent(lVar1,DAT_181d6af40)) == null) throw; // [null/range check failed]
              Selectable.set_interactable(lVar1,this.auctionStep == 2,0);
              if (((this.playerAuctionUI == null) ||
                  (lVar1 = GameObject.get_transform(this.playerAuctionUI,0)) == null) ||
                 ((lVar1 = Transform.Find(lVar1,"MinusButton",0), lVar1 == null ||
                  (lVar1 = Component.GetComponent(lVar1,DAT_181d6af40)) == null)))
              throw; // [null/range check failed]
              Selectable.set_interactable(lVar1,this.auctionStep == 2,0);
              if (((this.playerAuctionUI == null) ||
                  (lVar1 = GameObject.get_transform(this.playerAuctionUI,0)) == null) ||
                 ((lVar1 = Transform.Find(lVar1,"OfferButton",0), lVar1 == null ||
                  (lVar1 = Component.GetComponent(lVar1,DAT_181d6af40)) == null)))
              throw; // [null/range check failed]
              Selectable.set_interactable(lVar1,this.auctionStep == 2,0);
            }
            if (this.auctionStep == 2) {
              fVar13 = this.offerRoundLeftTime;
              fVar7 = (float)Time.get_deltaTime(0);
              if (!this.skipping) {
                fVar12 = 1.0;
              }
              else {
                fVar12 = 10.0;
              }
              fVar13 = fVar13 - fVar7 * fVar12;
              this.offerRoundLeftTime = fVar13;
              if ((this.nextOfferHero == null) || (this.nextOfferTime < fVar13)) {
                if (0.0 < fVar13) {
                  return;
                }
                lVar1 = new WarpText_d__8(0,0);
                if (lVar1 == null) throw; // [null/range check failed]
                *(int64 *)(lVar1 + 32) = this;
              }
              else {
                uVar8 = AuctionController.GetNextOfferMoney(this,0);
                lVar1 = AuctionController.RefreshOfferMoney
                                  (this,uVar8,this.nextOfferHero,0);
              }
              FUN_180d837c0(this,lVar1,0);
            }
            return;
          }
        }
    }

    // Token : 0x6000A8E
    // RVA   : 0x7F3590   Offset: 0x7F1D90   Length: 0x46D
    public void EndAuction()
    {
        var pStatics = *(int64*)(DAT_181d6c960 + 184);
        long lVar1;
        ulong uVar2;
        long lVar3;
        if (this.playerSellItem != null) {
          if (*pStatics == 0) throw; // [null/range check failed]
          PlotController.ClearPlayerAuctionItem(*pStatics,0);
          this.playerSellItem = 0;
        }
        this.auctionStep = 0;
        AuctionController.SetSkippingState(this,0,0);
        if (this.auctionPanel != null) {
          lVar1 = GameObject.get_transform(this.auctionPanel,0);
          if (lVar1 != null) {
            lVar1 = Transform.Find(lVar1,"AuctionItemNow",0);
            if (lVar1 != null) {
              uVar2 = Component.get_gameObject(lVar1,0);
              GlobalData.DeleteAllChild(uVar2,0);
              if (this.auctionItemList != null) {
                FUN_180f56130(this.auctionItemList,DAT_181d69370);
                if (this.auctionPanel != null) {
                  lVar1 = GameObject.get_transform(this.auctionPanel,0);
                  if (lVar1 != null) {
                    lVar1 = Transform.Find(lVar1,"AuctionItem",0);
                    if (lVar1 != null) {
                      uVar2 = Component.get_gameObject(lVar1,0);
                      GlobalData.DeleteAllChild(uVar2,0);
                      if (this.heroList != null) {
                        FUN_180f56130(this.heroList,DAT_181d63e78);
                        if (this.auctionPanel != null) {
                          lVar1 = GameObject.get_transform(this.auctionPanel,0);
                          if (lVar1 != null) {
                            lVar1 = Transform.Find(lVar1,"HeroGrid",0);
                            if (lVar1 != null) {
                              uVar2 = Component.get_gameObject(lVar1,0);
                              GlobalData.DeleteAllChild(uVar2,0);
                              if (this.auctionPanel != null) {
                                GameObject.SetActive(this.auctionPanel,0,0);
                                lVar1 = this.endMatchCallPlot;
                                lVar3 = FUN_1800d60b0(DAT_181d7c118,1);
                                if (lVar3 != null) {
                                  if (*(int *)(lVar3 + 24) == 0) {
                                    uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                    FUN_1800d65f0(uVar2,0);
                                  }
                                  *(uint16 *)(lVar3 + 32) = 45;
                                  if (lVar1 != null) {
                                    lVar1 = String.Split(lVar1,lVar3,0);
                                    if (lVar1 != null) {
                                      if (*(int *)(lVar1 + 24) < 2) {
                                        if (*pStatics != 0) {
                                          lVar1 = Component.get_gameObject
                                                            (*pStatics,0);
                                          if (lVar1 != null) {
                                            GameObject.SendMessage
                                                      (lVar1,this.endMatchCallPlot,0);
                                            return;
                                          }
                                        }
                                      }
                                      else {
                                        if (*pStatics != 0) {
                                          lVar3 = Component.get_gameObject
                                                            (*pStatics,0);
                                          if (*(uint32 *)(lVar1 + 24) == 0) {
                                            uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                            FUN_1800d65f0(uVar2,0);
                                          }
                                          if (*(uint32 *)(lVar1 + 24) < 2) {
                                            uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                            FUN_1800d65f0(uVar2,0);
                                          }
                                          if (lVar3 != null) {
                                            GameObject.SendMessage
                                                      (lVar3,*(uint64 *)(lVar1 + 32),
                                                       *(uint64 *)(lVar1 + 40),0);
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

    // Token : 0x6000A8F
    // RVA   : 0x7F2F10   Offset: 0x7F1710   Length: 0x608
    public void AutoFinishAuction()
    {
        var pStatics_d610 = *(int64*)(DAT_181d9d610 + 184);
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        bool cVar1;
        uint uVar2;
        int iVar3;
        long lVar4;
        ulong uVar5;
        long lVar6;
        int iVar8;
        float fVar9;
        lVar6 = this.auctionItemList;
        lVar4 = *(int64 *)(pStatics_d610 + 8);
        if (lVar4 == null) {
          uVar5 = **(uint64 **)(DAT_181d9d610 + 184);
          lVar4 = new OnTooltipCB(uVar5,DAT_181d6e018,DAT_181d86118);
          plVar7 = (int64 *)(pStatics_d610 + 8);
          *plVar7 = lVar4;
          il2cpp_internal(plVar7,lVar4);
        }
        if (lVar6 == null) throw; // [null/range check failed]
        List_1.Sort(lVar6,lVar4,DAT_181d69670);
        if (this.playerSellItem != null) {
          if (this.auctionItemList == null) throw; // [null/range check failed]
          cVar1 = FUN_1818279a0(this.auctionItemList,this.playerSellItem,DAT_181d693f0)
          ;
          if (cVar1) {
            if (this.auctionItemList == null) throw; // [null/range check failed]
            FUN_181801c10(this.auctionItemList,this.playerSellItem,DAT_181d69570);
            if (this.auctionItemList == null) throw; // [null/range check failed]
            FUN_18182ac70(this.auctionItemList,0,this.playerSellItem,DAT_181d694f0);
          }
        }
        lVar6 = this.heroList;
        if (((*pStatics_df90 != 0) &&
            (lVar4 = *(int64 *)(*pStatics_df90 + 32)) != null) &&
           (uVar5 = WorldData.Player(lVar4,0), lVar6 != null)) {
          FUN_181801c10(lVar6,uVar5,DAT_181d640f8);
          lVar6 = this.heroList;
          lVar4 = *(int64 *)(pStatics_d610 + 16);
          if (lVar4 == null) {
            uVar5 = **(uint64 **)(DAT_181d9d610 + 184);
            lVar4 = new OnTooltipCB(uVar5,DAT_181d6e098,DAT_181d85f18);
            plVar7 = (int64 *)(pStatics_d610 + 16);
            *plVar7 = lVar4;
            il2cpp_internal(plVar7,lVar4);
          }
          if (lVar6 != null) {
            List_1.Sort(lVar6,lVar4,DAT_181d64278);
            lVar6 = this.auctionItemList;
            iVar8 = 0;
            if (lVar6 != null) {
              while( true ) {
                if (lVar6.Count <= iVar8) {
                  return;
                }
                if (this.heroList == null) break;
                if (this.heroList.Count <= iVar8) {
                  return;
                }
                fVar9 = (float)GlobalData.RandomRange();
                if ((this.auctionItemList == null) ||
                   (lVar6 = FUN_180002f80(this.auctionItemList,iVar8,DAT_181d69770)) == null)
                break;
                uVar2 = Mathf.RoundToInt((float)*(int *)(lVar6 + 56) * fVar9,0);
                if ((this.heroList == null) ||
                   ((lVar6 = FUN_180002f80(this.heroList,iVar8,DAT_181d643f8), lVar6 == null
                    || (*(int64 *)(lVar6 + 0x220) == 0)))) break;
                iVar3 = Mathf.Min(uVar2,*(uint32 *)(*(int64 *)(lVar6 + 0x220) + 24),0);
                if (this.heroList == null) break;
                lVar6 = FUN_180002f80(this.heroList,iVar8,DAT_181d643f8);
                if ((this.auctionItemList == null) ||
                   (lVar4 = FUN_180002f80(this.auctionItemList,iVar8,DAT_181d69770), lVar6 == null))
                break;
                HeroData.ChangeMoney(lVar6,-iVar3,lVar4 == this.playerSellItem);
                if (this.heroList == null) break;
                lVar6 = FUN_180002f80(this.heroList,iVar8,DAT_181d643f8);
                if ((this.auctionItemList == null) ||
                   (uVar5 = FUN_180002f80(this.auctionItemList,iVar8,DAT_181d69770), lVar6 == null))
                break;
                HeroData.GetItem(lVar6,uVar5,1);
                if (this.auctionItemList == null) break;
                lVar6 = FUN_180002f80(this.auctionItemList,iVar8);
                if (lVar6 == this.playerSellItem) {
                  lVar6 = FUN_18046c0a0(0);
                  if (((lVar6 == null) || (*(int64 *)(lVar6 + 32) == 0)) ||
                     (lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0)) == null) break;
                  HeroData.ChangeMoney(lVar6,(int)((float)iVar3 * 0.9));
                }
                lVar6 = this.auctionItemList;
                iVar8 = iVar8 + 1;
                if (lVar6 == null) break;
              }
            }
          }
        }
    }

    // Token : 0x6000A90
    // RVA   : 0x7F4080   Offset: 0x7F2880   Length: 0x44D
    public void RestartAuction(List<HeroData> _heroList, ItemListData _auctionItemList, ItemData _playerSellItem, string _endMatchCallPlot, float _difficulty, bool _havePlayer, string _auctionKeeper)
    {
        var pStatics = *(int64*)(DAT_181d4e188 + 184);
        void AuctionController.RestartAuction
                     (int64 this,uint64 _heroList,int64 _auctionItemList,uint64 _playerSellItem,
                     uint64 _endMatchCallPlot,uint32 _difficulty,uint8 _havePlayer,uint64 _auctionKeeper)
        {
        int64 *plVar1;
        uint32 uVar2;
        int64 lVar3;
        uint64 uVar4;
        uint64 uVar5;
        int iVar6;
        if (this.auctionPanel != null) {
          GameObject.SetActive(this.auctionPanel,1,0);
          this.havePlayer = _havePlayer;
          if (this.playerAuctionUI != null) {
            GameObject.SetActive(this.playerAuctionUI,_havePlayer,0);
            iVar6 = 0;
            this.auctionDifficulty = _difficulty;
            this.endMatchCallPlot = _endMatchCallPlot;
            this.round = 0;
            this.auctionKeeper = _auctionKeeper;
            this.heroList = _heroList;
            if (_auctionItemList != null) {
              this.auctionItemList = *(uint64 *)(_auctionItemList + 40);
              this.playerSellItem = _playerSellItem;
              if (this.playerSellItem != null) {
                if (this.auctionItemList == null) throw; // [null/range check failed]
                FUN_18182ac70(this.auctionItemList,0,this.playerSellItem,DAT_181d694f0)
                ;
              }
              AuctionController.GenerateAucitonItemIcon(this,0);
              this.auctionStep = 1;
              if (((this.auctionPanel != null) &&
                  (lVar3 = GameObject.get_transform(this.auctionPanel,0)) != null) &&
                 (lVar3 = Transform.Find(lVar3,"Title",0)) != null) {
                uVar4 = Component.GetComponent(lVar3,DAT_181d6d8c0);
                lVar3 = *(int64 *)(*(int64 *)(DAT_181d4ef00 + 184) + 0x500);
                uVar2 = Mathf.RoundToInt(this.auctionDifficulty * 0.5,0);
                if (lVar3 != null) {
                  if (lVar3.Count <= uVar2) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  uVar5 = String.Concat(*(uint64 *)
                                          (lVar3._items + 32 + (int64)(int)uVar2 * 8),
                                         "拍卖大会",0);
                  LTLocalization.SetText(uVar4,uVar5,0);
                  if (this.heroIconList != null) {
                    FUN_180f56130(this.heroIconList,DAT_181d61c78);
                    this.nowOfferHero = 0;
                    lVar3 = this.heroList;
                    if (lVar3 != null) {
                      while( true ) {
                        if (lVar3.Count <= iVar6) {
                          AuctionController.StartAuctionRoundPlot(this,0);
                          return;
                        }
                        if ((this.auctionPanel == null) ||
                           (lVar3 = GameObject.get_transform(this.auctionPanel,0), lVar3 == null
                           )) break;
                        uVar4 = Transform.Find(lVar3,"HeroGrid",0);
                        if (*pStatics == 0) break;
                        uVar5 = *(uint64 *)(*pStatics + 144);
                        lVar3 = NGUITools.AddChild(uVar4,uVar5,0);
                        this.tempObj = lVar3;
                        if (*plVar1 == 0) break;
                        lVar3 = GameObject.GetComponent(*plVar1,DAT_181d9fb20);
                        if ((this.heroList == null) ||
                           (uVar4 = FUN_180002f80(this.heroList,iVar6,DAT_181d643f8),
                           lVar3 == null)) break;
                        *(uint64 *)(lVar3 + 32) = uVar4;
                        if ((*plVar1 == 0) ||
                           (lVar3 = GameObject.GetComponent(*plVar1,DAT_181d9fb20)) == null) break;
                        lVar3.Count = 2;
                        if (((*plVar1 == 0) ||
                            (lVar3 = GameObject.GetComponent(*plVar1,DAT_181d9fb20)) == null) ||
                           (*(uint8 *)(lVar3 + 88) = 1, this.heroIconList == null)) break;
                        FUN_181827900();
                        lVar3 = this.heroList;
                        iVar6 = iVar6 + 1;
                        if (lVar3 == null) break;
                      }
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6000A91
    // RVA   : 0x7F3A00   Offset: 0x7F2200   Length: 0x244
    public void GenerateAucitonItemIcon()
    {
        long lVar1;
        ulong uVar2;
        ulong uVar3;
        long lVar4;
        int iVar5;
        if (this.auctionItemIconList != null) {
          FUN_180f56130(this.auctionItemIconList,DAT_181d61c78);
          lVar1 = this.auctionItemList;
          iVar5 = 0;
          if (lVar1 != null) {
            while( true ) {
              if (lVar1.Count <= iVar5) {
                return;
              }
              if ((this.auctionPanel == null) ||
                 (lVar1 = GameObject.get_transform(this.auctionPanel,0)) == null) break;
              uVar2 = Transform.Find(lVar1,"AuctionItem",0);
              uVar3 = this.auctionSlotPrefab;
              uVar3 = NGUITools.AddChild(uVar2,uVar3,0);
              this.tempObj = uVar3;
              if ((this.tempObj == null) ||
                 (lVar1 = GameObject.get_transform(this.tempObj,0)) == null) break;
              uVar3 = Transform.Find(lVar1,"ItemIconPos",0);
              lVar1 = FUN_18046c1a0(0);
              if ((lVar1 == null) ||
                 (lVar1 = NGUITools.AddChild(uVar3,*(uint64 *)(lVar1 + 160),0)) == null) break;
              lVar4 = GameObject.GetComponent(lVar1,DAT_181da0070);
              if ((this.auctionItemList == null) ||
                 (uVar3 = FUN_180002f80(this.auctionItemList,iVar5,DAT_181d69770), lVar4 == null))
              break;
              *(uint64 *)(lVar4 + 32) = uVar3;
              lVar1 = GameObject.GetComponent(lVar1,DAT_181da0070);
              if ((lVar1 == null) || (*(uint32 *)(lVar1 + 40) = 1, this.auctionItemIconList == null))
              break;
              FUN_181827900();
              lVar1 = this.auctionItemList;
              iVar5 = iVar5 + 1;
              if (lVar1 == null) break;
            }
          }
        }
    }

    // Token : 0x6000A92
    // RVA   : 0x7F4E30   Offset: 0x7F3630   Length: 0x541
    public void StartAuctionRoundPlot()
    {
        uint uVar1;
        long lVar2;
        long lVar4;
        long lVar5;
        ulong uVar6;
        ulong uVar7;
        ulong uVar8;
        long lVar10;
        int[] local_res8 = new int[2];
        this.round = this.round + 1;
        plVar3 = (int64 *)Resources.Load("Sound/SoundEffect/紧张",0);
        plVar9 = (int64 *)0;
        if ((plVar3 != (int64 *)0) && (plVar9 = (int64 *)0, *plVar3 == DAT_181d8a228)) {
          plVar9 = plVar3;
        }
        NGUITools.PlaySound(plVar9,0);
        lVar2 = **(int64 **)(DAT_181d6c960 + 184);
        plVar3 = (int64 *)FUN_1800d60b0(DAT_181d7f180,5);
        uVar1 = this.round;
        lVar4 = GlobalData.GetNumText(uVar1,0);
        if (plVar3 != (int64 *)0) {
          if (lVar4 != null) {
            lVar5 = il2cpp_internal(lVar4,*(uint64 *)(*plVar3 + 64));
            if (lVar5 == null) {
              uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar8,0);
            }
          }
          if ((int)plVar3[3] == 0) {
            uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar8,0);
          }
          plVar3[4] = lVar4;
          il2cpp_internal(plVar3 + 4,lVar4);
          lVar4 = this.auctionItemList;
          if (lVar4 != null) {
            if (lVar4.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar4 = *(int64 *)(lVar4._items + 32);
            if (lVar4 != null) {
              local_res8[0] = (int)((float)*(int *)(lVar4 + 56) * 0.5);
              lVar4 = Int32.ToString(local_res8,0);
              if (lVar4 != null) {
                lVar5 = il2cpp_internal(lVar4,*(uint64 *)(*plVar3 + 64));
                if (lVar5 == null) {
                  uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar8,0);
                }
              }
              if (*(uint32 *)(plVar3 + 3) < 2) {
                uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar8,0);
              }
              plVar3[5] = lVar4;
              il2cpp_internal(plVar3 + 5,lVar4);
              lVar4 = this.auctionItemList;
              if (lVar4 != null) {
                if (lVar4.Count == null) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar4 = *(int64 *)(lVar4._items + 32);
                if (lVar4 != null) {
                  lVar4 = ItemData.Name(lVar4,1,0);
                  if (lVar4 != null) {
                    lVar5 = il2cpp_internal(lVar4,*(uint64 *)(*plVar3 + 64));
                    if (lVar5 == null) {
                      uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar8,0);
                    }
                  }
                  if (*(uint32 *)(plVar3 + 3) < 3) {
                    uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar8,0);
                  }
                  plVar3[6] = lVar4;
                  il2cpp_internal(plVar3 + 6,lVar4);
                  lVar4 = this.auctionItemList;
                  if (lVar4 != null) {
                    if (lVar4.Count == null) {
                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                    }
                    lVar4 = *(int64 *)(lVar4._items + 32);
                    if (lVar4 != null) {
                      lVar4 = ItemData.GetItemTypeDescribe(lVar4,0,0);
                      if (lVar4 != null) {
                        lVar5 = il2cpp_internal(lVar4,*(uint64 *)(*plVar3 + 64));
                        if (lVar5 == null) {
                          uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1800d65f0(uVar8,0);
                        }
                      }
                      if (*(uint32 *)(plVar3 + 3) < 4) {
                        uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar8,0);
                      }
                      plVar3[7] = lVar4;
                      il2cpp_internal(plVar3 + 7,lVar4);
                      lVar4 = this.auctionItemList;
                      lVar5 = this.playerSellItem;
                      if (lVar4 != null) {
                        if (lVar4.Count == null) {
                          ThrowHelper.ThrowArgumentOutOfRangeException(0);
                        }
                        uVar8 = "第{0}件拍品是......{2}！\n此乃一件{3}{4}，起拍价{1}两。\n请各位做好准备，进入唱价环节！";
                        lVar10 = "";
                        if (lVar5 == *(int64 *)(lVar4._items + 32)) {
                          lVar10 = "，由#$PlayerName#大侠委托出售";
                        }
                        if (lVar10 != null) {
                          lVar4 = il2cpp_internal(lVar10,*(uint64 *)(*plVar3 + 64));
                          if (lVar4 == null) {
                            uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                            FUN_1800d65f0(uVar8,0);
                          }
                        }
                        if (*(uint32 *)(plVar3 + 3) < 5) {
                          uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1800d65f0(uVar8,0);
                        }
                        plVar3[8] = lVar10;
                        il2cpp_internal(plVar3 + 8,lVar10);
                        uVar6 = String.Format(uVar8,plVar3,0);
                        uVar8 = this.auctionKeeper;
                        uVar7 = new SinglePlotData(uVar6,0,5,uVar8,1,0,0,"StartAuctionRoundPlotFuc",1,0,0,0,0,0);
                        if (lVar2 != null) {
                          PlotController.ChangePlot(lVar2,uVar7,0);
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

    // Token : 0x6000A93
    // RVA   : 0x7F5380   Offset: 0x7F3B80   Length: 0x6C
    public IEnumerator StartAuctionRound()
    {
        long lVar1;
        lVar1 = new WarpText_d__8(0,0);
        if (lVar1 != null) {
          *(uint64 *)(lVar1 + 32) = this;
          return lVar1;
        }
    }

    // Token : 0x6000A94
    // RVA   : 0x7F4D00   Offset: 0x7F3500   Length: 0x12E
    public void StartAuctionRoundButtonClicked()
    {
        long lVar1;
        ulong uVar3;
        if (this.startAuctionButton != null) {
          GameObject.SetActive(this.startAuctionButton,0,0);
          if (this.leaveAuctionButton != null) {
            GameObject.SetActive(this.leaveAuctionButton,0,0);
            plVar2 = (int64 *)Resources.Load("Sound/SoundEffect/开场锣",0);
            plVar4 = (int64 *)0;
            if ((plVar2 != (int64 *)0) && (*plVar2 == DAT_181d8a228)) {
              plVar4 = plVar2;
            }
            NGUITools.PlaySound(plVar4);
            lVar1 = this.auctionItemList;
            if (lVar1 != null) {
              if (lVar1.Count == null) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar1 = *(int64 *)(lVar1._items + 32);
              if (lVar1 != null) {
                uVar3 = AuctionController.RefreshOfferMoney
                                  (this,(float)*(int *)(lVar1 + 56) * 0.5,0,0);
                FUN_180d837c0(this,uVar3,0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x6000A95
    // RVA   : 0x7F3D50   Offset: 0x7F2550   Length: 0xB9
    public void LeaveAuctionButtonClicked()
    {
        long lVar1;
        ulong uVar2;
        lVar1 = **(int64 **)(DAT_181d834f0 + 184);
        uVar2 = Component.get_gameObject(this,0);
        if (lVar1 != null) {
          SureMenu.CallSureMenu(lVar1,"确认离开本场拍卖大会吗？","SureLeaveAuction",0,uVar2,1,0,0,0,0);
          return;
        }
    }

    // Token : 0x6000A96
    // RVA   : 0x7F53F0   Offset: 0x7F3BF0   Length: 0x1F
    public void SureLeaveAuction()
    {
        AuctionController.AutoFinishAuction(this,0);
        AuctionController.EndAuction(this,0);
    }

    // Token : 0x6000A97
    // RVA   : 0x7F4C90   Offset: 0x7F3490   Length: 0x6C
    public IEnumerator StartAuctionDeal()
    {
        long lVar1;
        lVar1 = new WarpText_d__8(0,0);
        if (lVar1 != null) {
          *(uint64 *)(lVar1 + 32) = this;
          return lVar1;
        }
    }

    // Token : 0x6000A98
    // RVA   : 0x7F3CC0   Offset: 0x7F24C0   Length: 0x83
    public float GetNextOfferMoney()
    {
        long lVar1;
        if (this.nowOfferMoney == null.0) {
          return;
        }
        lVar1 = this.auctionItemList;
        if (lVar1 != null) {
          if (lVar1.Count == null) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          if (*(int64 *)(lVar1._items + 32) != 0) {
            return;
          }
        }
    }

    // Token : 0x6000A99
    // RVA   : 0x7F3C50   Offset: 0x7F2450   Length: 0x63
    public float GetMinOfferMoneyDelta()
    {
        long lVar1;
        lVar1 = this.auctionItemList;
        if (lVar1 != null) {
          if (lVar1.Count == null) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar1 = *(int64 *)(lVar1._items + 32);
          if (lVar1 != null) {
            return (float)*(int *)(lVar1 + 56) * 0.1;
          }
        }
    }

    // Token : 0x6000A9A
    // RVA   : 0x7F4990   Offset: 0x7F3190   Length: 0xD1
    public void SetOfferMoney(float newOfferMoney)
    {
        long lVar1;
        ulong uVar2;
        ulong uVar3;
        uint uVar4;
        int[] local_res10 = new int[6];
        this.nowOfferMoney = newOfferMoney;
        if (this.auctionPanel != null) {
          lVar1 = GameObject.get_transform(this.auctionPanel,0);
          if (lVar1 != null) {
            lVar1 = Transform.Find(lVar1,"NowOfferMoney",0);
            if (lVar1 != null) {
              uVar2 = Component.GetComponent(lVar1,DAT_181d6d8c0);
              local_res10[0] = (int)this.nowOfferMoney;
              uVar3 = Int32.ToString(local_res10,0);
              LTLocalization.SetText(uVar2,uVar3,0);
              uVar4 = AuctionController.GetNextOfferMoney(this,0);
              this.playerOfferMoney = uVar4;
              return;
            }
          }
        }
    }

    // Token : 0x6000A9B
    // RVA   : 0x7F44D0   Offset: 0x7F2CD0   Length: 0x4BE
    public void SetOfferHero(HeroData targetHero)
    {
        ulong uVar1;
        uint uVar2;
        long lVar3;
        long lVar5;
        ulong local_68;
        float local_60;
        ulong local_58;
        float local_50;
        byte[] local_48 = new byte[8];
        float local_40;
        byte[] local_38 = new byte[32];
        this.nowOfferHero = targetHero;
        lVar3 = *(int64 *)(this + 200);
        if (this.nowOfferHero == null) {
          if (lVar3 != null) {
            lVar3 = GameObject.get_transform(lVar3,0);
            puVar4 = (uint64 *)Vector3.get_zero(local_48,0);
            if (lVar3 != null) {
              local_60 = *(float *)(puVar4 + 1);
              local_68 = *puVar4;
              Transform.set_localScale(lVar3,&local_68,0);
              if (this.highLightCover != null) {
                lVar3 = GameObject.get_transform(this.highLightCover,0);
                puVar4 = (uint64 *)Vector3.get_zero(local_48,0);
                if (lVar3 != null) {
                  local_60 = *(float *)(puVar4 + 1);
                  local_68 = *puVar4;
                  Transform.set_localScale(lVar3,&local_68,0);
                  return;
                }
              }
            }
          }
        }
        else if (lVar3 != null) {
          lVar3 = GameObject.get_transform(lVar3,0);
          puVar4 = (uint64 *)Vector3.get_one(local_38,0);
          local_58 = *puVar4;
          local_40 = *(float *)(puVar4 + 1);
          local_60 = local_40 * 1.2;
          local_68 = CONCAT44((float)((uint64)local_58 >> 32) * 1.2,(float)local_58 * 1.2);
          local_50 = local_40;
          if (lVar3 != null) {
            local_58 = local_68;
            local_50 = local_60;
            Transform.set_localScale(lVar3,&local_58,0);
            if (this.highLightCover != null) {
              lVar3 = GameObject.get_transform(this.highLightCover,0);
              puVar4 = (uint64 *)Vector3.get_one(local_38,0);
              if (lVar3 != null) {
                local_50 = *(float *)(puVar4 + 1);
                local_58 = *puVar4;
                Transform.set_localScale(lVar3,&local_58,0);
                if (*(int64 *)(this + 200) != 0) {
                  lVar5 = GameObject.get_transform(*(int64 *)(this + 200),0);
                  lVar3 = this.heroIconList;
                  if (this.heroList != null) {
                    uVar2 = FUN_1817ff280(this.heroList,this.nowOfferHero,
                                          DAT_181d63ff8);
                    if (lVar3 != null) {
                      if (lVar3.Count <= uVar2) {
                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                      }
                      lVar3 = lVar3._items[uVar2]
                      ;
                      if (((lVar3 != null) && (lVar3 = GameObject.get_transform(lVar3,0)) != null) &&
                         (puVar4 = (uint64 *)Transform.get_position(local_38,lVar3,0), lVar5 != null)) {
                        local_58 = *puVar4;
                        local_50 = *(float *)(puVar4 + 1);
                        Transform.set_position(lVar5,&local_58,0);
                        if ((*(int64 *)(this + 200) != 0) &&
                           (lVar3 = GameObject.get_transform(*(int64 *)(this + 200),0)) != null
                           ) {
                          puVar4 = (uint64 *)Transform.get_localPosition(local_38,lVar3,0);
                          local_60 = *(float *)(puVar4 + 1);
                          uVar1 = *puVar4;
                          puVar4 = (uint64 *)Vector3.get_up(local_38,0);
                          local_50 = *(float *)(puVar4 + 1) * 9.0 + local_60;
                          local_58 = CONCAT44((float)((uint64)*puVar4 >> 32) * 9.0 +
                                              (float)((uint64)uVar1 >> 32),
                                              (float)*puVar4 * 9.0 + (float)uVar1);
                          local_40 = local_50;
                          Transform.set_localPosition(lVar3,&local_58,0);
                          if (this.highLightCover != null) {
                            lVar5 = GameObject.get_transform(this.highLightCover,0);
                            lVar3 = this.heroIconList;
                            if (this.heroList != null) {
                              uVar2 = FUN_1817ff280(this.heroList,
                                                    this.nowOfferHero,DAT_181d63ff8);
                              if (lVar3 != null) {
                                if (lVar3.Count <= uVar2) {
                                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                }
                                lVar3 = *(int64 *)
                                         (lVar3._items + 32 + (int64)(int)uVar2 * 8);
                                if (((lVar3 != null) &&
                                    (lVar3 = GameObject.get_transform(lVar3,0)) != null) &&
                                   (puVar4 = (uint64 *)Transform.get_position(local_38,lVar3,0),
                                   lVar5 != null)) {
                                  local_58 = *puVar4;
                                  local_50 = *(float *)(puVar4 + 1);
                                  Transform.set_position(lVar5,&local_58,0);
                                  if ((this.highLightCover != null) &&
                                     (lVar3 = GameObject.get_transform(this.highLightCover,0),
                                     lVar3 != null)) {
                                    puVar4 = (uint64 *)Transform.get_localPosition(local_38,lVar3,0);
                                    local_50 = *(float *)(puVar4 + 1) + 0.0;
                                    local_58 = CONCAT44((float)((uint64)*puVar4 >> 32) - 40.0,
                                                        (float)*puVar4 + 50.0);
                                    local_40 = local_50;
                                    Transform.set_localPosition(lVar3,&local_58,0);
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

    // Token : 0x6000A9C
    // RVA   : 0x7F3FE0   Offset: 0x7F27E0   Length: 0x9A
    public IEnumerator RefreshOfferMoney(float newOfferMoney, HeroData newOfferHero)
    {
        int64 AuctionController.RefreshOfferMoney
                         (uint64 this,uint32 newOfferMoney,uint64 newOfferHero)
        {
        int64 lVar1;
        var lVar1 = new WarpText_d__8(0,0);
        if (lVar1 != null) {
          *(uint64 *)(lVar1 + 32) = this;
          *(uint64 *)(lVar1 + 40) = newOfferHero;
          *(uint32 *)(lVar1 + 48) = newOfferMoney;
          return lVar1;
        }
    }

    // Token : 0x6000A9D
    // RVA   : 0x7F2C20   Offset: 0x7F1420   Length: 0x2E6
    public void AddOfferMoneyButtonClicked()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        float fVar1;
        int iVar2;
        long lVar3;
        if ((((*pStatics != 0) &&
             (lVar3 = *(int64 *)(*pStatics + 32)) != null) &&
            (lVar3 = WorldData.Player(lVar3,0)) != null) && (*(int64 *)(lVar3 + 0x220) != 0)) {
          iVar2 = *(int *)(*(int64 *)(lVar3 + 0x220) + 24);
          fVar1 = this.playerOfferMoney;
          lVar3 = this.auctionItemList;
          if (lVar3 != null) {
            if (lVar3.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar3 = *(int64 *)(lVar3._items + 32);
            if (lVar3 != null) {
              if ((float)iVar2 < (float)*(int *)(lVar3 + 56) * 0.1 + fVar1) {
                if (*pStatics != 0) {
                  GameController.ShowTextOnMouse(*pStatics,"银钱不足！",0);
                  plVar4 = (int64 *)Resources.Load("Sound/SoundEffect/WrongClick",0);
                  plVar5 = (int64 *)0;
                  if ((plVar4 != (int64 *)0) && (*plVar4 == DAT_181d8a228)) {
                    plVar5 = plVar4;
                  }
                  NGUITools.PlaySound(plVar5,0);
                  return;
                }
              }
              else {
                fVar1 = this.playerOfferMoney;
                lVar3 = this.auctionItemList;
                if (lVar3 != null) {
                  if (lVar3.Count == null) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  lVar3 = *(int64 *)(lVar3._items + 32);
                  if (lVar3 != null) {
                    this.playerOfferMoney = (float)*(int *)(lVar3 + 56) * 0.1 + fVar1;
                    return;
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6000A9E
    // RVA   : 0x7F3E10   Offset: 0x7F2610   Length: 0x1C5
    public void MinusOfferMoneyButtonClicked()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        float fVar1;
        int iVar2;
        long lVar3;
        float fVar4;
        fVar1 = this.playerOfferMoney;
        lVar3 = this.auctionItemList;
        if (lVar3 != null) {
          if (lVar3.Count == null) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar3 = *(int64 *)(lVar3._items + 32);
          if (lVar3 != null) {
            iVar2 = *(int *)(lVar3 + 56);
            fVar4 = (float)AuctionController.GetNextOfferMoney(this,0);
            if (fVar1 - (float)iVar2 * 0.1 < fVar4) {
              if (*pStatics != 0) {
                GameController.ShowTextOnMouse(*pStatics,"已是最低出价",0);
                return;
              }
            }
            else {
              fVar1 = this.playerOfferMoney;
              lVar3 = this.auctionItemList;
              if (lVar3 != null) {
                if (lVar3.Count == null) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar3 = *(int64 *)(lVar3._items + 32);
                if (lVar3 != null) {
                  this.playerOfferMoney = fVar1 - (float)*(int *)(lVar3 + 56) * 0.1;
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x6000A9F
    // RVA   : 0x7F5410   Offset: 0x7F3C10   Length: 0x2B8
    public void SureOfferMoneyButtonClicked()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        float fVar1;
        long lVar2;
        ulong uVar3;
        if ((*pStatics != 0) &&
           (lVar2 = *(int64 *)(*pStatics + 32)) != null) {
          lVar2 = WorldData.Player(lVar2,0);
          if ((lVar2 != null) && (*(int64 *)(lVar2 + 0x220) != 0)) {
            fVar1 = this.playerOfferMoney;
            if ((float)*(int *)(*(int64 *)(lVar2 + 0x220) + 24) < fVar1) {
              if (*pStatics != 0) {
                GameController.ShowTextOnMouse(*pStatics,"银钱不足！",0);
                plVar4 = (int64 *)Resources.Load("Sound/SoundEffect/WrongClick",0);
                plVar5 = (int64 *)0;
                if ((plVar4 != (int64 *)0) && (*plVar4 == DAT_181d8a228)) {
                  plVar5 = plVar4;
                }
                NGUITools.PlaySound(plVar5,0);
                return;
              }
            }
            else {
              if ((*pStatics != 0) &&
                 (lVar2 = *(int64 *)(*pStatics + 32)) != null) {
                uVar3 = WorldData.Player(lVar2,0);
                uVar3 = AuctionController.RefreshOfferMoney(this,fVar1,uVar3,0);
                FUN_180d837c0(this,uVar3,0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x6000AA0
    // RVA   : 0x7F4C70   Offset: 0x7F3470   Length: 0x12
    public void SkipButtonClicked()
    {
        void FUN_1807f4c70(int64 this)
        {
        AuctionController.SetSkippingState(this,!this.skipping,0);
    }

    // Token : 0x6000AA1
    // RVA   : 0x7F4A70   Offset: 0x7F3270   Length: 0x7A
    public void SetSkippingButtonState(bool state)
    {
        long lVar1;
        if (this.skipButton != null) {
          lVar1 = GameObject.GetComponent(this.skipButton,DAT_181d9ee60);
          if (lVar1 != null) {
            Selectable.set_interactable(lVar1,state,0);
            if (!state) {
              AuctionController.SetSkippingState(this,0,0);
            }
            return;
          }
        }
    }

    // Token : 0x6000AA2
    // RVA   : 0x7F4AF0   Offset: 0x7F32F0   Length: 0x17F
    public void SetSkippingState(bool state)
    {
        long lVar1;
        uint local_18;
        uint uStack_14;
        uint uStack_10;
        uint32 uStack_c;
        lVar1 = this.skipButton;
        this.skipping = state;
        if (!state) {
          if (lVar1 != null) {
            lVar1 = GameObject.get_transform(lVar1,0);
            if (lVar1 != null) {
              lVar1 = Transform.Find(lVar1,"Icon",0);
              if (lVar1 != null) {
                plVar2 = (int64 *)Component.GetComponent(lVar1,DAT_181d6bc40);
                lVar1 = *(int64 *)(DAT_181d4ef00 + 184);
                if (plVar2 != (int64 *)0) {
                  local_18 = *(uint32 *)(lVar1 + 0x390);
                  uStack_14 = *(uint32 *)(lVar1 + 0x394);
                  uStack_10 = *(uint32 *)(lVar1 + 0x398);
                  uStack_c = *(uint32 *)(lVar1 + 0x39c);
                  (**(code **)(*plVar2 + 0x2a8))(plVar2,&local_18,*(uint64 *)(*plVar2 + 0x2b0));
                  return;
                }
              }
            }
          }
        }
        else if (lVar1 != null) {
          lVar1 = GameObject.get_transform(lVar1,0);
          if (lVar1 != null) {
            lVar1 = Transform.Find(lVar1,"Icon",0);
            if (lVar1 != null) {
              plVar2 = (int64 *)Component.GetComponent(lVar1,DAT_181d6bc40);
              puVar3 = (uint32 *)Color.get_red(&local_18,0);
              if (plVar2 != (int64 *)0) {
                local_18 = *puVar3;
                uStack_14 = puVar3[1];
                uStack_10 = puVar3[2];
                uStack_c = puVar3[3];
                (**(code **)(*plVar2 + 0x2a8))(plVar2,&local_18,*(uint64 *)(*plVar2 + 0x2b0));
                return;
              }
            }
          }
        }
    }

    // Token : 0x6000AA3
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

    // Token : 0x6000AA4
    // RVA   : 0x7F5DF0   Offset: 0x7F45F0   Length: 0x3DC
    private static void /*cctor*/()
    {
        var pStatics = *(int64*)(DAT_181d8a1a8 + 184);
        long lVar1;
        **(uint32 **)(DAT_181d8a1a8 + 184) = 0x40a00000;
        lVar1 = il2cpp_internal(DAT_181d72a30);
        FUN_180f58a90(lVar1,DAT_181d7c250);
        if (lVar1 != null) {
          FUN_181827900(lVar1,"我出{0}两！",DAT_181d7c3d0);
          FUN_181827900(lVar1,"{0}两！",DAT_181d7c3d0);
          FUN_181827900(lVar1,"便是{0}两，我也要将这{1}拿下！",DAT_181d7c3d0);
          FUN_181827900(lVar1,"那就{0}两好了",DAT_181d7c3d0);
          FUN_181827900(lVar1,"这{1}，非得值{0}两不可",DAT_181d7c3d0);
          FUN_181827900(lVar1,"我一见这{1}便喜欢得紧，花上{0}两又何妨？",DAT_181d7c3d0);
          FUN_181827900(lVar1,"此{1}深得我心，愿以{0}两拿下！",DAT_181d7c3d0);
          FUN_181827900(lVar1,"若能以{0}两拿下此{1}，也是一件美事",DAT_181d7c3d0);
          FUN_181827900(lVar1,"{0}两！今日不拿下此{1}誓不罢休！",DAT_181d7c3d0);
          FUN_181827900(lVar1,"虽不想与同道相争，奈何这{1}着实诱人，我出{0}两！",DAT_181d7c3d0);
          FUN_181827900(lVar1,"{0}两虽不是小数目，但为了此{1}也是值得",DAT_181d7c3d0);
          plVar2 = (int64 *)(pStatics + 8);
          *plVar2 = lVar1;
          il2cpp_internal(plVar2,lVar1);
          lVar1 = il2cpp_internal(DAT_181d72a30);
          FUN_180f58a90(lVar1,DAT_181d7c250);
          if (lVar1 != null) {
            FUN_181827900(lVar1,"承让承让",DAT_181d7c3d0);
            FUN_181827900(lVar1,"不好意思，这件{1}我就笑纳了",DAT_181d7c3d0);
            FUN_181827900(lVar1,"得了这{1}，定能叫我如虎添翼",DAT_181d7c3d0);
            FUN_181827900(lVar1,"这{1}虽不便宜，但终究还是被我拿下",DAT_181d7c3d0);
            FUN_181827900(lVar1,"各位既囊中羞涩，又何必与我一争高下",DAT_181d7c3d0);
            FUN_181827900(lVar1,"被看上的宝物，自是逃不出我手掌心",DAT_181d7c3d0);
            FUN_181827900(lVar1,"收获颇丰，真是不虚此行",DAT_181d7c3d0);
            FUN_181827900(lVar1,"物有所值，算是捡了个便宜",DAT_181d7c3d0);
            FUN_181827900(lVar1,"一分价钱一分货",DAT_181d7c3d0);
            FUN_181827900(lVar1,"今日真是吉星高照，助我拿下此{1}",DAT_181d7c3d0);
            FUN_181827900(lVar1,"回去后定要将此{1}好好收藏起来",DAT_181d7c3d0);
            plVar2 = (int64 *)(pStatics + 16);
            *plVar2 = lVar1;
            il2cpp_internal(plVar2,lVar1);
            return;
          }
        }
    }

    // Token : 0x6000AA5
    // RVA   : 0x7F56D0   Offset: 0x7F3ED0   Length: 0x9C
    private void <StartAuctionDeal>b__46_0()
    {
        long lVar1;
        ulong uVar2;
        if (this.auctionPanel != null) {
          lVar1 = GameObject.get_transform(this.auctionPanel,0);
          if (lVar1 != null) {
            lVar1 = Transform.Find(lVar1,"AuctionItemNow",0);
            if (lVar1 != null) {
              uVar2 = Component.get_gameObject(lVar1,0);
              GlobalData.DeleteAllChild(uVar2,0);
              return;
            }
          }
        }
    }

    // Token : 0x6000AA6
    // RVA   : 0x7F5770   Offset: 0x7F3F70   Length: 0x9C
    private void <StartAuctionDeal>b__46_1()
    {
        long lVar1;
        ulong uVar2;
        if (this.auctionPanel != null) {
          lVar1 = GameObject.get_transform(this.auctionPanel,0);
          if (lVar1 != null) {
            lVar1 = Transform.Find(lVar1,"AuctionItemNow",0);
            if (lVar1 != null) {
              uVar2 = Component.get_gameObject(lVar1,0);
              GlobalData.DeleteAllChild(uVar2,0);
              return;
            }
          }
        }
    }

}
