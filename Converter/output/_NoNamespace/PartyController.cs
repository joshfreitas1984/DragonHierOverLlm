// ============================================================
// Type  : PartyController
// Token : 0x200030D
// ============================================================

public class PartyController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001860
    public PartyType partyType;

    // Token: 0x4001861
    public PartyState partyState;

    // Token: 0x4001862
    public GameObject partyUIPanel;

    // Token: 0x4001863
    public GameObject startButton;

    // Token: 0x4001864
    public AudioSource partySound;

    // Token: 0x4001865
    public GameObject wineIcon;

    // Token: 0x4001866
    public GameObject wineCancel;

    // Token: 0x4001867
    private ItemData wineData;

    // Token: 0x4001868
    public float wineScore;

    // Token: 0x4001869
    public GameObject foodIcon;

    // Token: 0x400186A
    public GameObject foodCancel;

    // Token: 0x400186B
    private ItemData foodData;

    // Token: 0x400186C
    public float foodScore;

    // Token: 0x400186D
    public GameObject treasureIcon;

    // Token: 0x400186E
    public GameObject treasureCancel;

    // Token: 0x400186F
    private ItemData treasureData;

    // Token: 0x4001870
    public float treasureScore;

    // Token: 0x4001871
    public float baseScore;

    // Token: 0x4001872
    public float scoreRate;

    // Token: 0x4001873
    public AreaData sourceArea;

    // Token: 0x4001874
    public HeroData sourceHero;

    // Token: 0x4001875
    public HeroData sourceAssistHero;

    // Token: 0x4001876
    public List<HeroData> targetHero;

    // Token: 0x4001877
    public List<GameObject> targetHeroIcon;

    // Token: 0x4001878
    public float heroConsumeRate;

    // Token: 0x4001879
    public bool skipping;

    // Token: 0x400187A
    public GameObject skipButton;

    // Token: 0x400187B
    private GameObject temp;

    // Token: 0x400187C
    private static PartyController _instance;

    // Token: 0x400187D
    public static List<string> PartyMeetTalkText;

    // Token: 0x400187E
    public static List<string> WeddingMeetTalkText;

    // Token: 0x400187F
    public static List<string> PartyFavorChangeText;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001920
    // RVA   : 0x478790   Offset: 0x476F90   Length: 0x57
    public static PartyController get_Instance()
    {
        return **(uint64 **)(DAT_181d6b060 + 184);
    }

    // Token : 0x6001921
    // RVA   : 0x475250   Offset: 0x473A50   Length: 0x61
    private void Awake()
    {
        puVar1 = *(uint64 **)(DAT_181d6b060 + 184);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x6001922
    // RVA   : 0x476330   Offset: 0x474B30   Length: 0x674
    public void PartyStart(PartyType _partyType, HeroData _sourceHero, AreaData _sourceArea, float _baseScore, float _scoreRate, HeroData _sourceAssistHero)
    {
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        var pStatics_e188 = *(int64*)(DAT_181d4e188 + 184);
        void PartyController.PartyStart
                     (int64 this,uint32 _partyType,int64 _sourceHero,uint64 _sourceArea,
                     uint32 _baseScore,uint32 _scoreRate,uint64 _sourceAssistHero)
        {
        int64 *plVar1;
        int64 *plVar2;
        uint64 uVar3;
        int64 lVar4;
        uint64 uVar5;
        this.baseScore = _baseScore;
        this.scoreRate = _scoreRate;
        this.sourceArea = _sourceArea;
        this.partyType = _partyType;
        this.partyState = 1;
        this.sourceHero = _sourceHero;
        this.sourceAssistHero = _sourceAssistHero;
        if (this.partyUIPanel != null) {
          GameObject.SetActive(this.partyUIPanel,1,0);
          if ((this.partyUIPanel != null) &&
             (lVar4 = GameObject.GetComponent(this.partyUIPanel,DAT_181d9f080)) != null)
          {
            CanvasGroup.set_alpha(lVar4,0,0);
            if (this.partyUIPanel != null) {
              uVar5 = GameObject.GetComponent(this.partyUIPanel,DAT_181d9f080);
              DOTweenModuleUI.DOFade(uVar5,0x3f800000);
              PartyController.SetAllIconButtonActive(this,1,0);
              PartyController.RefreshExtraRateInfo(this,0);
              if (((this.partyUIPanel != null) &&
                  (lVar4 = GameObject.get_transform(this.partyUIPanel,0)) != null) &&
                 (lVar4 = Transform.Find(lVar4,"MainGrid",0)) != null) {
                uVar5 = Component.get_gameObject(lVar4,0);
                if (*pStatics_e188 != 0) {
                  uVar3 = *(uint64 *)(*pStatics_e188 + 144);
                  lVar4 = GlobalData.AddChild(uVar5,uVar3,0);
                  this.temp = lVar4;
                  if (*plVar2 != 0) {
                    lVar4 = GameObject.GetComponent(*plVar2,DAT_181d9fb20);
                    if (lVar4 != null) {
                      *(int64 *)(lVar4 + 32) = *plVar1;
                      if ((*plVar2 != 0) &&
                         (lVar4 = GameObject.GetComponent(*plVar2,DAT_181d9fb20)) != null) {
                        *(uint32 *)(lVar4 + 24) = 0;
                        if ((*plVar2 != 0) &&
                           (lVar4 = GameObject.GetComponent(*plVar2,DAT_181d9fb20)) != null) {
                          *(uint8 *)(lVar4 + 88) = 1;
                          if (this.sourceAssistHero != null) {
                            if (((this.partyUIPanel == null) ||
                                (lVar4 = GameObject.get_transform(this.partyUIPanel,0),
                                lVar4 == null)) ||
                               (lVar4 = Transform.Find(lVar4,"AssistGrid",0)) == null)
                            throw; // [null/range check failed]
                            uVar5 = Component.get_gameObject(lVar4,0);
                            if (*pStatics_e188 == 0) throw; // [null/range check failed]
                            uVar3 = *(uint64 *)(*pStatics_e188 + 144);
                            lVar4 = GlobalData.AddChild(uVar5,uVar3,0);
                            *plVar2 = lVar4;
                            il2cpp_internal(plVar2,lVar4);
                            if (*plVar2 == 0) throw; // [null/range check failed]
                            lVar4 = GameObject.GetComponent(*plVar2,DAT_181d9fb20);
                            if (lVar4 == null) throw; // [null/range check failed]
                            *(uint64 *)(lVar4 + 32) = this.sourceAssistHero;
                            if ((*plVar2 == 0) ||
                               (lVar4 = GameObject.GetComponent(*plVar2,DAT_181d9fb20)) == null)
                            throw; // [null/range check failed]
                            *(uint32 *)(lVar4 + 24) = 0;
                            if ((*plVar2 == 0) ||
                               (lVar4 = GameObject.GetComponent(*plVar2,DAT_181d9fb20)) == null)
                            throw; // [null/range check failed]
                            *(uint8 *)(lVar4 + 88) = 1;
                          }
                          if (*plVar1 != 0) {
                            if (*(int *)(*plVar1 + 88) == 0) {
                              if (this.startButton != null) {
                                GameObject.SetActive(this.startButton,1,0);
                                return;
                              }
                            }
                            else {
                              if ((*plVar1 != 0) && (*pStatics_df90 != 0)) {
                                uVar5 = GameController.GenerateRandomItem
                                                  (*pStatics_df90,2);
                                PartyController.SetDrinkWine(this,uVar5,0);
                                if ((*plVar1 != 0) && (*pStatics_df90 != 0)) {
                                  uVar5 = GameController.GenerateRandomItem
                                                    (*pStatics_df90,2);
                                  PartyController.SetDrinkFood(this,uVar5,0);
                                  if ((*plVar1 != 0) && (*pStatics_df90 != 0)) {
                                    uVar5 = GameController.GenerateRandomItem
                                                      (*pStatics_df90,4);
                                    PartyController.SetDrinkTreasure(this,uVar5,0);
                                    PartyController.StartButtonClicked(this,0);
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

    // Token : 0x6001923
    // RVA   : 0x475F10   Offset: 0x474710   Length: 0x41D
    public void PartyEnd()
    {
        var pStatics = *(int64*)(DAT_181d51180 + 184);
        ulong uVar1;
        ulong uVar2;
        long lVar3;
        int[] local_res18 = new int[2];
        if (*pStatics != 0) {
          HeroLittleTalkController.ClearAll(*pStatics,0);
          this.partyState = 0;
          if (this.partyUIPanel != null) {
            uVar1 = GameObject.GetComponent(this.partyUIPanel,DAT_181d9f080);
            uVar1 = DOTweenModuleUI.DOFade(uVar1,0,0x3f000000,0);
            uVar2 = new OnTooltipCB(this,DAT_181d6d3f0,0);
            TweenSettingsExtensions.OnComplete(uVar1,uVar2,DAT_181d96d50);
            if (this.partyUIPanel != null) {
              lVar3 = GameObject.get_transform(this.partyUIPanel,0);
              if (lVar3 != null) {
                lVar3 = Transform.Find(lVar3,"MainGrid",0);
                if (lVar3 != null) {
                  uVar1 = Component.get_gameObject(lVar3,0);
                  GlobalData.DeleteAllChild(uVar1,0);
                  if (this.partyUIPanel != null) {
                    lVar3 = GameObject.get_transform(this.partyUIPanel,0);
                    if (lVar3 != null) {
                      lVar3 = Transform.Find(lVar3,"AssistGrid",0);
                      if (lVar3 != null) {
                        uVar1 = Component.get_gameObject(lVar3,0);
                        GlobalData.DeleteAllChild(uVar1,0);
                        local_res18[0] = 0;
                        do {
                          if (this.partyUIPanel == null) throw; // [null/range check failed]
                          lVar3 = GameObject.get_transform(this.partyUIPanel,0);
                          if (lVar3 == null) throw; // [null/range check failed]
                          lVar3 = Transform.Find(lVar3,"HeroGrid",0);
                          uVar1 = Int32.ToString(local_res18,0);
                          if (lVar3 == null) throw; // [null/range check failed]
                          lVar3 = Transform.Find(lVar3,uVar1,0);
                          if (lVar3 == null) throw; // [null/range check failed]
                          uVar1 = Component.get_gameObject(lVar3);
                          GlobalData.DeleteAllChild(uVar1);
                          local_res18[0] = local_res18[0] + 1;
                        } while (local_res18[0] < 12);
                        this.wineData = 0;
                        uVar1 = this.wineIcon;
                        GlobalData.DeleteAllChild(uVar1,0);
                        this.wineScore = 0;
                        PartyController.RefreshExtraRateInfo(this,0);
                        if (this.wineCancel != null) {
                          GameObject.SetActive(this.wineCancel,0,0);
                          this.foodData = 0;
                          uVar1 = this.foodIcon;
                          GlobalData.DeleteAllChild(uVar1,0);
                          this.foodScore = 0;
                          PartyController.RefreshExtraRateInfo(this,0);
                          if (this.foodCancel != null) {
                            GameObject.SetActive(this.foodCancel,0,0);
                            this.treasureData = 0;
                            uVar1 = this.treasureIcon;
                            GlobalData.DeleteAllChild(uVar1,0);
                            this.treasureScore = 0;
                            PartyController.RefreshExtraRateInfo(this,0);
                            if (this.treasureCancel != null) {
                              GameObject.SetActive(this.treasureCancel,0,0);
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

    // Token : 0x6001924
    // RVA   : 0x476B90   Offset: 0x475390   Length: 0x128
    public void SetAllIconButtonActive(bool active)
    {
        long lVar1;
        if (this.wineIcon != null) {
          lVar1 = GameObject.get_transform(this.wineIcon,0);
          if (lVar1 != null) {
            lVar1 = FUN_180da0f00(lVar1,0);
            if (lVar1 != null) {
              lVar1 = Component.GetComponent(lVar1,DAT_181d6af40);
              if (lVar1 != null) {
                Selectable.set_interactable(lVar1,active,0);
                if (this.foodIcon != null) {
                  lVar1 = GameObject.get_transform(this.foodIcon,0);
                  if (lVar1 != null) {
                    lVar1 = FUN_180da0f00(lVar1,0);
                    if (lVar1 != null) {
                      lVar1 = Component.GetComponent(lVar1,DAT_181d6af40);
                      if (lVar1 != null) {
                        Selectable.set_interactable(lVar1,active,0);
                        if (this.treasureIcon != null) {
                          lVar1 = GameObject.get_transform(this.treasureIcon,0);
                          if (lVar1 != null) {
                            lVar1 = FUN_180da0f00(lVar1,0);
                            if (lVar1 != null) {
                              lVar1 = Component.GetComponent(lVar1,DAT_181d6af40);
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

    // Token : 0x6001925
    // RVA   : 0x475A20   Offset: 0x474220   Length: 0x20E
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
        lVar1 = **(int64 **)(DAT_181d92370 + 184);
        lVar2 = il2cpp_internal(DAT_181d701b0);
        FUN_180f58a90(lVar2,DAT_181d6dfe8);
        local_res8[0] = 0;
        uVar3 = il2cpp_value_box(DAT_181d5b2f8,local_res8);
        if (lVar2 != null) {
          FUN_181827900(lVar2,uVar3,DAT_181d6e0e8);
          local_res18[0] = 2;
          uVar3 = il2cpp_value_box(DAT_181d5b2f8,local_res18);
          FUN_181827900(lVar2,uVar3,DAT_181d6e0e8);
          local_res20[0] = 0xffffffff;
          uVar3 = il2cpp_value_box(DAT_181d5b2f8,local_res20);
          FUN_181827900(lVar2,uVar3,DAT_181d6e0e8);
          local_28 = 0xffffffff;
          uVar3 = il2cpp_value_box(DAT_181d5b2f8,&local_28);
          FUN_181827900(lVar2,uVar3,DAT_181d6e0e8);
          local_24[0] = 1;
          uVar3 = il2cpp_value_box(DAT_181d5b2f8,local_24);
          FUN_181827900(lVar2,uVar3,DAT_181d6e0e8);
          uVar3 = Component.get_gameObject(this,0);
          if (lVar1 != null) {
            ChooseController.ShowChoosePanel(lVar1,1,lVar2,uVar3,"DrinkWineChoosen",0,0,0,0,0);
            return;
          }
        }
    }

    // Token : 0x6001926
    // RVA   : 0x475C30   Offset: 0x474430   Length: 0x8A
    public void DrinkWineChoosen()
    {
        var pStatics = *(int64*)(DAT_181d92370 + 184);
        long lVar1;
        if ((*pStatics != 0) &&
           (lVar1 = *(int64 *)(*pStatics + 72)) != null) {
          lVar1 = GameObject.GetComponent(lVar1,DAT_181da0070);
          if (lVar1 != null) {
            PartyController.SetDrinkWine(this,*(uint64 *)(lVar1 + 32),0);
            return;
          }
        }
    }

    // Token : 0x6001927
    // RVA   : 0x476FE0   Offset: 0x4757E0   Length: 0x176
    public void SetDrinkWine(ItemData targetWine)
    {
        var pStatics = *(int64*)(DAT_181d4e188 + 184);
        ulong uVar1;
        ulong uVar2;
        long lVar3;
        this.wineData = targetWine;
        uVar2 = this.wineIcon;
        if (*pStatics != 0) {
          uVar1 = *(uint64 *)(*pStatics + 160);
          uVar2 = GlobalData.AddChild(uVar2,uVar1,0);
          this.temp = uVar2;
          if (this.temp != null) {
            lVar3 = GameObject.GetComponent(this.temp,DAT_181da0070);
            if (lVar3 != null) {
              *(uint64 *)(lVar3 + 32) = this.wineData;
              if (this.temp != null) {
                lVar3 = GameObject.GetComponent(this.temp,DAT_181da0070);
                if (lVar3 != null) {
                  *(uint32 *)(lVar3 + 40) = 1;
                  if (this.wineData != null) {
                    this.wineScore = (float)this.wineData.value;
                    PartyController.RefreshExtraRateInfo(this,0);
                    if (this.wineCancel != null) {
                      GameObject.SetActive(this.wineCancel,1,0);
                      return;
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6001928
    // RVA   : 0x475980   Offset: 0x474180   Length: 0x9A
    public void DrinkWineCancel()
    {
        ulong uVar1;
        this.wineData = 0;
        uVar1 = this.wineIcon;
        GlobalData.DeleteAllChild(uVar1,0);
        this.wineScore = 0;
        PartyController.RefreshExtraRateInfo(this,0);
        if (this.wineCancel != null) {
          GameObject.SetActive(this.wineCancel,0,0);
          return;
        }
    }

    // Token : 0x6001929
    // RVA   : 0x475420   Offset: 0x473C20   Length: 0x20A
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
        lVar1 = **(int64 **)(DAT_181d92370 + 184);
        lVar2 = il2cpp_internal(DAT_181d701b0);
        FUN_180f58a90(lVar2,DAT_181d6dfe8);
        local_res8[0] = 0;
        uVar3 = il2cpp_value_box(DAT_181d5b2f8,local_res8);
        if (lVar2 != null) {
          FUN_181827900(lVar2,uVar3,DAT_181d6e0e8);
          local_res18[0] = 2;
          uVar3 = il2cpp_value_box(DAT_181d5b2f8,local_res18);
          FUN_181827900(lVar2,uVar3,DAT_181d6e0e8);
          local_res20[0] = 0xffffffff;
          uVar3 = il2cpp_value_box(DAT_181d5b2f8,local_res20);
          FUN_181827900(lVar2,uVar3,DAT_181d6e0e8);
          local_28 = 0xffffffff;
          uVar3 = il2cpp_value_box(DAT_181d5b2f8,&local_28);
          FUN_181827900(lVar2,uVar3,DAT_181d6e0e8);
          local_24[0] = 0;
          uVar3 = il2cpp_value_box(DAT_181d5b2f8,local_24);
          FUN_181827900(lVar2,uVar3,DAT_181d6e0e8);
          uVar3 = Component.get_gameObject(this,0);
          if (lVar1 != null) {
            ChooseController.ShowChoosePanel(lVar1,1,lVar2,uVar3,"DrinkFoodChoosen",0,0,0,0,0);
            return;
          }
        }
    }

    // Token : 0x600192A
    // RVA   : 0x475630   Offset: 0x473E30   Length: 0x8A
    public void DrinkFoodChoosen()
    {
        var pStatics = *(int64*)(DAT_181d92370 + 184);
        long lVar1;
        if ((*pStatics != 0) &&
           (lVar1 = *(int64 *)(*pStatics + 72)) != null) {
          lVar1 = GameObject.GetComponent(lVar1,DAT_181da0070);
          if (lVar1 != null) {
            PartyController.SetDrinkFood(this,*(uint64 *)(lVar1 + 32),0);
            return;
          }
        }
    }

    // Token : 0x600192B
    // RVA   : 0x476CC0   Offset: 0x4754C0   Length: 0x176
    public void SetDrinkFood(ItemData targetFood)
    {
        var pStatics = *(int64*)(DAT_181d4e188 + 184);
        ulong uVar1;
        ulong uVar2;
        long lVar3;
        this.foodData = targetFood;
        uVar2 = this.foodIcon;
        if (*pStatics != 0) {
          uVar1 = *(uint64 *)(*pStatics + 160);
          uVar2 = GlobalData.AddChild(uVar2,uVar1,0);
          this.temp = uVar2;
          if (this.temp != null) {
            lVar3 = GameObject.GetComponent(this.temp,DAT_181da0070);
            if (lVar3 != null) {
              *(uint64 *)(lVar3 + 32) = this.foodData;
              if (this.temp != null) {
                lVar3 = GameObject.GetComponent(this.temp,DAT_181da0070);
                if (lVar3 != null) {
                  *(uint32 *)(lVar3 + 40) = 1;
                  if (this.foodData != null) {
                    this.foodScore = (float)this.foodData.value;
                    PartyController.RefreshExtraRateInfo(this,0);
                    if (this.foodCancel != null) {
                      GameObject.SetActive(this.foodCancel,1,0);
                      return;
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x600192C
    // RVA   : 0x475380   Offset: 0x473B80   Length: 0x9A
    public void DrinkFoodCancel()
    {
        ulong uVar1;
        this.foodData = 0;
        uVar1 = this.foodIcon;
        GlobalData.DeleteAllChild(uVar1,0);
        this.foodScore = 0;
        PartyController.RefreshExtraRateInfo(this,0);
        if (this.foodCancel != null) {
          GameObject.SetActive(this.foodCancel,0,0);
          return;
        }
    }

    // Token : 0x600192D
    // RVA   : 0x475770   Offset: 0x473F70   Length: 0x17E
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
        lVar1 = **(int64 **)(DAT_181d92370 + 184);
        lVar2 = il2cpp_internal(DAT_181d701b0);
        FUN_180f58a90(lVar2,DAT_181d6dfe8);
        local_res8[0] = 0;
        uVar3 = il2cpp_value_box(DAT_181d5b2f8,local_res8);
        if (lVar2 != null) {
          FUN_181827900(lVar2,uVar3,DAT_181d6e0e8);
          local_res18[0] = 4;
          uVar3 = il2cpp_value_box(DAT_181d5b2f8,local_res18);
          FUN_181827900(lVar2,uVar3,DAT_181d6e0e8);
          uVar3 = Component.get_gameObject(this,0);
          if (lVar1 != null) {
            ChooseController.ShowChoosePanel(lVar1,1,lVar2,uVar3,"DrinkTreasureChoosen",0,0,0,0,0);
            return;
          }
        }
    }

    // Token : 0x600192E
    // RVA   : 0x4758F0   Offset: 0x4740F0   Length: 0x8A
    public void DrinkTreasureChoosen()
    {
        var pStatics = *(int64*)(DAT_181d92370 + 184);
        long lVar1;
        if ((*pStatics != 0) &&
           (lVar1 = *(int64 *)(*pStatics + 72)) != null) {
          lVar1 = GameObject.GetComponent(lVar1,DAT_181da0070);
          if (lVar1 != null) {
            PartyController.SetDrinkTreasure(this,*(uint64 *)(lVar1 + 32),0);
            return;
          }
        }
    }

    // Token : 0x600192F
    // RVA   : 0x476E40   Offset: 0x475640   Length: 0x194
    public void SetDrinkTreasure(ItemData targetTreasure)
    {
        var pStatics = *(int64*)(DAT_181d4e188 + 184);
        ulong uVar1;
        ulong uVar2;
        long lVar3;
        this.treasureData = targetTreasure;
        uVar2 = this.treasureIcon;
        if (*pStatics != 0) {
          uVar1 = *(uint64 *)(*pStatics + 160);
          uVar2 = GlobalData.AddChild(uVar2,uVar1,0);
          this.temp = uVar2;
          if (this.temp != null) {
            lVar3 = GameObject.GetComponent(this.temp,DAT_181da0070);
            if (lVar3 != null) {
              *(uint64 *)(lVar3 + 32) = this.treasureData;
              if (this.temp != null) {
                lVar3 = GameObject.GetComponent(this.temp,DAT_181da0070);
                if (lVar3 != null) {
                  *(uint32 *)(lVar3 + 40) = 1;
                  if (this.treasureData != null) {
                    this.treasureScore =
                         (float)this.treasureData.value * 0.25;
                    PartyController.RefreshExtraRateInfo(this,0);
                    if (this.treasureCancel != null) {
                      GameObject.SetActive(this.treasureCancel,1,0);
                      return;
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6001930
    // RVA   : 0x4756C0   Offset: 0x473EC0   Length: 0xA3
    public void DrinkTreasureCancel()
    {
        ulong uVar1;
        this.treasureData = 0;
        uVar1 = this.treasureIcon;
        GlobalData.DeleteAllChild(uVar1,0);
        this.treasureScore = 0;
        PartyController.RefreshExtraRateInfo(this,0);
        if (this.treasureCancel != null) {
          GameObject.SetActive(this.treasureCancel,0,0);
          return;
        }
    }

    // Token : 0x6001931
    // RVA   : 0x4769B0   Offset: 0x4751B0   Length: 0x1DF
    public void RefreshExtraRateInfo()
    {
        long lVar1;
        ulong uVar2;
        ulong uVar3;
        ulong uVar4;
        uint uVar5;
        float fVar6;
        float[] local_res8 = new float[2];
        if (this.partyUIPanel != null) {
          lVar1 = GameObject.get_transform(this.partyUIPanel,0);
          if (lVar1 != null) {
            lVar1 = Transform.Find(lVar1,"ExtraRateInfo",0);
            if (lVar1 != null) {
              uVar2 = Component.GetComponent(lVar1,DAT_181d6d8c0);
              local_res8[0] =
                   (this.baseScore + this.wineScore + this.foodScore +
                   this.treasureScore) * this.scoreRate;
              uVar3 = Single.ToString(local_res8,"f0",0);
              uVar5 = Mathf.Max(0x3f800000,
                                 (this.wineScore + this.baseScore +
                                  this.foodScore + this.treasureScore) *
                                 this.scoreRate * 0.01,0);
              uVar5 = Mathf.Log(uVar5,0x40000000,0);
              fVar6 = (float)Mathf.Max(0,uVar5,0);
              uVar3 = GlobalData.GenerateRareLvColorText(uVar3,(int)fVar6,0);
              local_res8[0] = this.scoreRate * 100.0;
              uVar4 = Single.ToString(local_res8,"f0",0);
              uVar3 = String.Format("宴会评分(x{1}%)\n<b>{0}</b>",uVar3,uVar4,0);
              LTLocalization.SetText(uVar2,uVar3,0);
              return;
            }
          }
        }
    }

    // Token : 0x6001932
    // RVA   : 0x475E00   Offset: 0x474600   Length: 0x23
    public float GetTotalScore()
    {
        return (this.baseScore + this.wineScore + this.foodScore +
               this.treasureScore) * this.scoreRate;
    }

    // Token : 0x6001933
    // RVA   : 0x475DA0   Offset: 0x4745A0   Length: 0x60
    public float GetMaxHeroLv()
    {
        uint uVar1;
        uVar1 = Mathf.Max(0x3f800000,
                           (this.wineScore + this.baseScore +
                            this.foodScore + this.treasureScore) *
                           this.scoreRate * 0.01,0);
        uVar1 = Mathf.Log(uVar1,0x40000000,0);
        Mathf.Max(0,uVar1,0);
    }

    // Token : 0x6001934
    // RVA   : 0x477470   Offset: 0x475C70   Length: 0xEB1
    public void StartButtonClicked()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        bool cVar2;
        uint uVar3;
        int iVar4;
        long lVar5;
        long lVar6;
        ulong uVar7;
        uint uVar8;
        uint uVar9;
        uint uVar10;
        float fVar11;
        ulong uVar12;
        byte[] auVar13 = new byte[16];
        byte[] auVar14 = new byte[16];
        float fVar15;
        uint64 extraout_XMM0_Qb;
        if (this.startButton != null) {
          GameObject.SetActive(this.startButton,0,0);
          PartyController.SetAllIconButtonActive(this,0,0);
          if (this.wineCancel != null) {
            GameObject.SetActive(this.wineCancel,0,0);
            if (this.foodCancel != null) {
              GameObject.SetActive(this.foodCancel,0,0);
              if (this.treasureCancel != null) {
                GameObject.SetActive(this.treasureCancel,0,0);
                if (this.sourceHero != null) {
                  if (this.sourceHero.heroID == null) {
                    if (((*pStatics == 0) ||
                        (lVar5 = *(int64 *)(*pStatics + 32)) == null)
                       || (lVar5 = WorldData.Player(lVar5,0)) == null) goto LAB_18047831c;
                    HeroData.LoseItem(lVar5,this.wineData,1,0);
                    if (((*pStatics == 0) ||
                        (lVar5 = *(int64 *)(*pStatics + 32)) == null)
                       || (lVar5 = WorldData.Player(lVar5,0)) == null) goto LAB_18047831c;
                    HeroData.LoseItem(lVar5,this.foodData,1,0);
                  }
                  iVar4 = this.partyType;
                  uVar8 = 0;
                  this.partyState = 2;
                  if (iVar4 == 0) {
                    lVar5 = this.sourceArea;
                    if (lVar5 != null) {
                      lVar6 = 32;
                      uVar9 = uVar8;
                      while (lVar5.insideHeros != null) {
                        if (*(int *)(lVar5.insideHeros + 24) <= (int)uVar9) {
                          uVar9 = uVar8;
                          if (lVar5 != null) goto LAB_180477d10;
                          break;
                        }
                        if ((lVar5 = lVar5?.insideHeros) == null) break;
                        if (lVar5.areaName <= uVar9) {
                          ThrowHelper.ThrowArgumentOutOfRangeException(0);
                        }
                        if (this.sourceHero == null) break;
                        if (*(int *)(lVar5.areaID + lVar6) !=
                            this.sourceHero.heroID) {
                          lVar5 = this.targetHero;
                          if ((this.sourceArea == null) ||
                             (uVar12 = AreaData.GetInsideHero(this.sourceArea,uVar9,0),
                             lVar5 == null)) break;
                          cVar2 = FUN_1818279a0(lVar5,uVar12,DAT_181d63ef8);
                          if (!cVar2) {
                            if ((this.sourceArea == null) ||
                               (lVar5 = this.sourceArea.insideHeros) == null)
                            break;
                            iVar4 = FUN_1800d6750(lVar5,uVar9,DAT_181d68270);
                            if (iVar4 != 0) {
                              if ((this.sourceArea == null) ||
                                 (lVar5 = AreaData.GetInsideHero(this.sourceArea,uVar9,0),
                                 lVar5 == null)) break;
                              iVar4 = lVar5.mapWidth;
                              fVar15 = (float)PartyController.GetMaxHeroLv(this,0);
                              if ((float)iVar4 <= fVar15) {
                                if ((this.sourceArea == null) ||
                                   (lVar5 = AreaData.GetInsideHero(this.sourceArea,uVar9,0)
                                   , lVar5 == null)) break;
                                if (!lVar5.changeAreaState) {
                                  if ((this.sourceArea == null) ||
                                     (lVar5 = AreaData.GetInsideHero
                                                        (this.sourceArea,uVar9,0),
                                     lVar5 == null)) break;
                                  if (*(char *)(lVar5 + 209) == false) {
                                    if ((this.sourceArea == null) ||
                                       (lVar5 = AreaData.GetInsideHero
                                                          (this.sourceArea,uVar9,0),
                                       lVar5 == null)) break;
                                    if (!lVar5.autoBuildResourceRateLimit) {
                                      if ((this.sourceArea == null) ||
                                         (lVar5 = AreaData.GetInsideHero
                                                            (this.sourceArea,uVar9,0),
                                         lVar5 == null)) break;
                                      cVar2 = HeroData.CanPlayerMeet(lVar5,0);
                                      if (!cVar2) goto LAB_180477cd7;
                                    }
                                    lVar5 = this.targetHero;
                                    if ((this.sourceArea == null) ||
                                       (uVar12 = AreaData.GetInsideHero
                                                           (this.sourceArea,uVar9,0),
                                       lVar5 == null)) break;
                                    FUN_181827900(lVar5,uVar12,DAT_181d63d78);
                                  }
                                }
                              }
                            }
                          }
                        }
        LAB_180477cd7:
                        lVar5 = this.sourceArea;
                        uVar9 = uVar9 + 1;
                        lVar6 = lVar6 + 4;
                        if (lVar5 == null) break;
                      }
                    }
                  }
                  else if (iVar4 == 1) {
                    lVar5 = this.sourceHero;
                    if (lVar5 != null) {
                      while ((lVar5 = HeroData.GetForce(lVar5,0,0), lVar5 != null &&
                             (lVar5.belongForceID != null))) {
                        if (*(int *)(lVar5.belongForceID + 24) <= (int)uVar8)
                        goto LAB_18047779d;
                        if ((this.sourceHero == null) ||
                           (lVar5 = HeroData.GetForce(this.sourceHero,0,0)) == null)
                        break;
                        lVar6 = ForceData.GetOwnHero(lVar5);
                        lVar5 = this.sourceHero;
                        if (lVar6 != lVar5) {
                          if (((lVar5 == null) || (lVar5 = HeroData.GetForce(lVar5,0,0)) == null) ||
                             (lVar5.belongForceID == null)) break;
                          iVar4 = FUN_1800d6750();
                          if (iVar4 != 0) {
                            if (((this.sourceHero == null) ||
                                (lVar5 = HeroData.GetForce(this.sourceHero,0,0), lVar5 == null
                                )) || (lVar5 = ForceData.GetOwnHero(lVar5)) == null) break;
                            if (!lVar5.changeAreaState) {
                              if (((this.sourceHero == null) ||
                                  (lVar5 = HeroData.GetForce(this.sourceHero,0,0),
                                  lVar5 == null)) || (lVar5 = ForceData.GetOwnHero(lVar5)) == null)
                              break;
                              if (*(char *)(lVar5 + 209) == false) {
                                lVar5 = this.targetHero;
                                if (((this.sourceHero == null) ||
                                    (lVar6 = HeroData.GetForce(this.sourceHero,0,0),
                                    lVar6 == null)) || (ForceData.GetOwnHero(lVar6,uVar8,0), lVar5 == null))
                                break;
                                FUN_181827900(lVar5);
                              }
                            }
                          }
                        }
                        lVar5 = this.sourceHero;
                        uVar8 = uVar8 + 1;
                        if (lVar5 == null) break;
                      }
                    }
                  }
                  else {
                    if (iVar4 == 2) {
                      PartyController.AddFriendToList
                                (this,this.sourceHero,this.targetHero,
                                 this.sourceAssistHero,0);
                      PartyController.AddFriendToList
                                (this,this.sourceAssistHero,this.targetHero,
                                 this.sourceHero,0);
                    }
        LAB_18047779d:
                    if (this.sourceHero != null) {
                      PartyController.ChangeBaseScore
                                (this,this.sourceHero.fame * 0.1,0);
                      if (this.sourceAssistHero != null) {
                        PartyController.ChangeBaseScore
                                  (this,this.sourceAssistHero.fame * 0.1,0);
                      }
                      fVar15 = 2.0;
                      if (this.partyType == 2) {
                        lVar5 = this.targetHero;
                        lVar5 = GlobalData.SortHeroList(lVar5,1);
                        *plVar1 = lVar5;
                        il2cpp_internal(plVar1,lVar5);
                        lVar5 = *plVar1;
                        while (lVar5 != null) {
                          if (lVar5.areaName < 13) goto LAB_18047807f;
                          if (lVar5 == null) break;
                          FUN_18182b220(lVar5,lVar5.areaName + -1,DAT_181d641f8);
                          lVar5 = *plVar1;
                        }
                      }
                      else {
                        fVar11 = (float)Random.Range();
                        uVar12 = Mathf.Max();
                        Mathf.Log(uVar12,0x40000000,0);
                        auVar13._0_8_ = Mathf.Max();
                        auVar13._8_8_ = extraout_XMM0_Qb;
                        auVar14._4_12_ = auVar13._4_12_;
                        auVar14._0_4_ = (float)auVar13._0_8_ + fVar11;
                        uVar3 = Mathf.RoundToInt(auVar14._0_8_,0);
                        iVar4 = Mathf.Clamp(uVar3,1,12);
                        lVar5 = this.targetHero;
                        while (lVar5 != null) {
                          if (lVar5.areaName <= iVar4) {
                            if (this.sourceHero == null) break;
                            if (this.sourceHero.heroID != null) {
                              if (lVar5 == null) break;
                              if (0 < lVar5.areaName) {
                                uVar3 = FUN_180d8cf10(0,lVar5.areaName,0);
                                FUN_18182b220(lVar5,uVar3,DAT_181d641f8);
                                lVar5 = *plVar1;
                              }
                              if (((*pStatics == 0) ||
                                  (lVar6 = *(int64 *)(*pStatics + 32),
                                  lVar6 == null)) || (uVar12 = WorldData.Player(lVar6,0), lVar5 == null))
                              break;
                              FUN_181827900(lVar5,uVar12,DAT_181d63d78);
                              lVar5 = *plVar1;
                            }
                            lVar5 = GlobalData.SortHeroList(lVar5,0,0);
                            *plVar1 = lVar5;
                            il2cpp_internal(plVar1,lVar5);
        LAB_18047807f:
                            if (this.sourceAssistHero == null) {
                              fVar15 = 1.0;
                            }
                            lVar5 = this.targetHero;
                            if (lVar5 != null) {
                              *(float *)(this + 200) = 1.0 / ((float)lVar5.areaName + fVar15);
                              lVar5 = this.targetHero;
                              if (lVar5 != null) {
                                if (lVar5.areaName < 1) {
                                  lVar5 = **(int64 **)(DAT_181d6c960 + 184);
                                  lVar6 = il2cpp_internal(DAT_181d72a30);
                                  FUN_180f58a90(lVar6,DAT_181d7c250);
                                  if (lVar6 != null) {
                                    FUN_181827900(lVar6,"结束宴会;EndParty",DAT_181d7c3d0);
                                    if (this.sourceHero != null) {
                                      uVar12 = Int32.ToString(this.sourceHero + 88,0);
                                      uVar7 = new SinglePlotData("啊这......附近竟无人参加宴会吗？\n可惜浪费了一桌好酒好菜啊......",lVar6,1,0,3,uVar12,1,0,0);
                                      if (lVar5 != null) {
                                        PlotController.AddPlot(lVar5,uVar7,0);
                                        return;
                                      }
                                    }
                                  }
                                }
                                else {
                                  lVar5 = new WarpText_d__8(0,0);
                                  if (lVar5 != null) {
                                    lVar5.areaStartLv = this;
                                    FUN_180d837c0(this,lVar5,0);
                                    return;
                                  }
                                }
                              }
                            }
                            break;
                          }
                          if (lVar5 == null) break;
                          FUN_180d8cf10(0,lVar5.areaName,0);
                          FUN_18182b220(lVar5);
                          lVar5 = *plVar1;
                        }
                      }
                    }
                  }
                }
              }
            }
          }
        }
        LAB_18047831c:
                          // WARNING: Subroutine does not return
        FUN_1800d6620();
        LAB_180477d10:
        if (lVar5.nearAreaID == null) goto LAB_18047831c;
        if (*(int *)(lVar5.nearAreaID + 24) <= (int)uVar9) goto LAB_18047779d;
        lVar5 = FUN_18046c0a0(0);
        if (lVar5 == null) goto LAB_18047831c;
        lVar5 = lVar5.areaStartLv;
        if (((this.sourceArea == null) ||
            (lVar6 = this.sourceArea.nearAreaID) == null) ||
           (uVar3 = FUN_1800d6750(lVar6,uVar9,DAT_181d68270), lVar5 == null)) goto LAB_18047831c;
        lVar5 = WorldData.GetArea(lVar5,uVar3,0);
        uVar10 = uVar8;
        while( true ) {
          if ((lVar5 == null) || (lVar6 = lVar5.insideHeros) == null) goto LAB_18047831c;
          if (lVar6.Count <= (int)uVar10) break;
          iVar4 = FUN_1800d6750(lVar6,uVar10,DAT_181d68270);
          if (this.sourceHero == null) goto LAB_18047831c;
          if (iVar4 != this.sourceHero.heroID) {
            lVar6 = this.targetHero;
            uVar12 = AreaData.GetInsideHero(lVar5,uVar10,0);
            if (lVar6 == null) goto LAB_18047831c;
            cVar2 = FUN_1818279a0(lVar6,uVar12,DAT_181d63ef8);
            if (!cVar2) {
              if (lVar5.insideHeros == null) goto LAB_18047831c;
              iVar4 = FUN_1800d6750(lVar5.insideHeros,uVar10,DAT_181d68270);
              if (iVar4 != 0) {
                lVar6 = AreaData.GetInsideHero(lVar5,uVar10,0);
                if (lVar6 == null) goto LAB_18047831c;
                iVar4 = *(int *)(lVar6 + 184);
                fVar15 = (float)PartyController.GetMaxHeroLv(this,0);
                if ((float)iVar4 <= fVar15) {
                  lVar6 = AreaData.GetInsideHero(lVar5,uVar10,0);
                  if (lVar6 == null) goto LAB_18047831c;
                  if (*(char *)(lVar6 + 96) == false) {
                    lVar6 = AreaData.GetInsideHero(lVar5,uVar10,0);
                    if (lVar6 == null) goto LAB_18047831c;
                    if (*(char *)(lVar6 + 209) == false) {
                      lVar6 = AreaData.GetInsideHero(lVar5,uVar10,0);
                      if (lVar6 == null) goto LAB_18047831c;
                      if (*(char *)(lVar6 + 0x120) == false) {
                        lVar6 = AreaData.GetInsideHero(lVar5,uVar10,0);
                        if (lVar6 == null) goto LAB_18047831c;
                        cVar2 = HeroData.CanPlayerMeet(lVar6,0);
                        if (!cVar2) goto LAB_180477f2b;
                      }
                      lVar6 = this.targetHero;
                      uVar12 = AreaData.GetInsideHero(lVar5,uVar10,0);
                      if (lVar6 == null) goto LAB_18047831c;
                      FUN_181827900(lVar6,uVar12,DAT_181d63d78);
                    }
                  }
                }
              }
            }
          }
        LAB_180477f2b:
          uVar10 = uVar10 + 1;
        }
        lVar5 = this.sourceArea;
        uVar9 = uVar9 + 1;
        if (lVar5 == null) goto LAB_18047831c;
        goto LAB_180477d10;
    }

    // Token : 0x6001935
    // RVA   : 0x474870   Offset: 0x473070   Length: 0x9DB
    public void AddFriendToList(HeroData sourceHeroData, List<HeroData> targetList, HeroData restrictHeroData)
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        void PartyController.AddFriendToList
                     (uint64 this,int64 sourceHeroData,int64 targetList,int64 restrictHeroData)
        {
        char cVar1;
        uint32 uVar2;
        int64 lVar3;
        uint64 uVar4;
        int64 lVar5;
        int iVar6;
        uint32 uVar7;
        int iVar8;
        float fVar9;
        if (sourceHeroData != null) {
          if (*(char *)(sourceHeroData + 180) == false) {
            lVar3 = HeroData.GetForce(sourceHeroData,0,0);
            if (lVar3 != null) {
              lVar3 = HeroData.GetForce(sourceHeroData,0,0);
              if (lVar3 == null) throw; // [null/range check failed]
              lVar3 = ForceData.GetLeader(lVar3,0);
              if (lVar3 != restrictHeroData) {
                lVar3 = HeroData.GetForce(sourceHeroData,0,0);
                if (lVar3 == null) throw; // [null/range check failed]
                uVar4 = ForceData.GetLeader(lVar3,0);
                if (targetList == null) throw; // [null/range check failed]
                cVar1 = FUN_1818279a0(targetList,uVar4,DAT_181d63ef8);
                if (!cVar1) {
                  lVar3 = HeroData.GetForce(sourceHeroData,0,0);
                  if (lVar3 == null) throw; // [null/range check failed]
                  uVar4 = ForceData.GetLeader(lVar3,0);
                  FUN_181827900(targetList,uVar4,DAT_181d63d78);
                }
              }
            }
          }
          cVar1 = HeroData.HaveTeacher(sourceHeroData,0);
          if (cVar1) {
            if ((*pStatics == 0) ||
               (lVar3 = *(int64 *)(*pStatics + 32)) == null)
            throw; // [null/range check failed]
            lVar3 = WorldData.GetHero(lVar3,*(uint32 *)(sourceHeroData + 0x31c),0);
            if (lVar3 != restrictHeroData) {
              lVar3 = FUN_18046c0a0(0);
              if ((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) throw; // [null/range check failed]
              uVar4 = WorldData.GetHero(*(int64 *)(lVar3 + 32),*(uint32 *)(sourceHeroData + 0x31c),0);
              if (targetList == null) throw; // [null/range check failed]
              cVar1 = FUN_1818279a0(targetList,uVar4,DAT_181d63ef8);
              if (!cVar1) {
                lVar3 = FUN_18046c0a0(0);
                if ((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) throw; // [null/range check failed]
                uVar4 = WorldData.GetHero(*(int64 *)(lVar3 + 32),*(uint32 *)(sourceHeroData + 0x31c),0)
                ;
                FUN_181827900(targetList,uVar4,DAT_181d63d78);
              }
            }
          }
          iVar8 = 0;
          iVar6 = 0;
          while (*(int64 *)(sourceHeroData + 800) != 0) {
            if (*(int *)(*(int64 *)(sourceHeroData + 800) + 24) <= iVar6) goto LAB_180474cdb;
            lVar3 = FUN_18046c0a0(0);
            if (lVar3 == null) break;
            lVar3 = *(int64 *)(lVar3 + 32);
            if (*(int64 *)(sourceHeroData + 800) == 0) break;
            uVar2 = FUN_1800d6750(*(int64 *)(sourceHeroData + 800),iVar6,DAT_181d68270);
            if (lVar3 == null) break;
            lVar3 = WorldData.GetHero(lVar3,uVar2,0);
            if (lVar3 != restrictHeroData) {
              lVar3 = FUN_18046c0a0(0);
              if (lVar3 == null) break;
              lVar3 = *(int64 *)(lVar3 + 32);
              if (*(int64 *)(sourceHeroData + 800) == 0) break;
              uVar2 = FUN_1800d6750(*(int64 *)(sourceHeroData + 800),iVar6,DAT_181d68270);
              if (lVar3 == null) break;
              uVar4 = WorldData.GetHero(lVar3,uVar2,0);
              if (targetList == null) break;
              cVar1 = FUN_1818279a0(targetList,uVar4,DAT_181d63ef8);
              if (!cVar1) {
                lVar3 = FUN_18046c0a0(0);
                if (lVar3 == null) break;
                lVar3 = *(int64 *)(lVar3 + 32);
                if (*(int64 *)(sourceHeroData + 800) == 0) break;
                uVar2 = FUN_1800d6750(*(int64 *)(sourceHeroData + 800),iVar6,DAT_181d68270);
                if (lVar3 == null) break;
                uVar4 = WorldData.GetHero(lVar3,uVar2,0);
                FUN_181827900(targetList,uVar4,DAT_181d63d78);
              }
            }
            iVar6 = iVar6 + 1;
          }
        }
        throw; // [null/range check failed]
        LAB_180474cdb:
        if (*(int64 *)(sourceHeroData + 0x348) == 0) throw; // [null/range check failed]
        if (*(int *)(*(int64 *)(sourceHeroData + 0x348) + 24) <= iVar8) {
          if (*(int *)(sourceHeroData + 88) != 0) goto LAB_1804751b1;
          iVar6 = 1;
          goto LAB_180474e90;
        }
        lVar3 = FUN_18046c0a0(0);
        if (lVar3 == null) throw; // [null/range check failed]
        lVar3 = *(int64 *)(lVar3 + 32);
        if (*(int64 *)(sourceHeroData + 0x348) == 0) throw; // [null/range check failed]
        uVar2 = FUN_1800d6750(*(int64 *)(sourceHeroData + 0x348),iVar8,DAT_181d68270);
        if (lVar3 == null) throw; // [null/range check failed]
        lVar3 = WorldData.GetHero(lVar3,uVar2,0);
        if (lVar3 != restrictHeroData) {
          lVar3 = FUN_18046c0a0(0);
          if (lVar3 == null) throw; // [null/range check failed]
          lVar3 = *(int64 *)(lVar3 + 32);
          if (*(int64 *)(sourceHeroData + 0x348) == 0) throw; // [null/range check failed]
          uVar2 = FUN_1800d6750(*(int64 *)(sourceHeroData + 0x348),iVar8,DAT_181d68270);
          if (lVar3 == null) throw; // [null/range check failed]
          uVar4 = WorldData.GetHero(lVar3,uVar2,0);
          if (targetList == null) throw; // [null/range check failed]
          cVar1 = FUN_1818279a0(targetList,uVar4,DAT_181d63ef8);
          if (!cVar1) {
            lVar3 = FUN_18046c0a0(0);
            if (lVar3 == null) throw; // [null/range check failed]
            lVar3 = *(int64 *)(lVar3 + 32);
            if (*(int64 *)(sourceHeroData + 0x348) == 0) throw; // [null/range check failed]
            uVar2 = FUN_1800d6750(*(int64 *)(sourceHeroData + 0x348),iVar8,DAT_181d68270);
            if (lVar3 == null) throw; // [null/range check failed]
            uVar4 = WorldData.GetHero(lVar3,uVar2,0);
            FUN_181827900(targetList,uVar4,DAT_181d63d78);
          }
        }
        iVar8 = iVar8 + 1;
        goto LAB_180474cdb;
        LAB_180474e90:
        if (((*pStatics == 0) ||
            (lVar3 = *(int64 *)(*pStatics + 32)) == null) ||
           (lVar3 = *(int64 *)(lVar3 + 80)) == null) throw; // [null/range check failed]
        if (*(int *)(lVar3 + 24) <= iVar6) goto LAB_1804751b1;
        lVar3 = FUN_18046c0a0(0);
        if (((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) ||
           (lVar3 = *(int64 *)(*(int64 *)(lVar3 + 32) + 80)) == null) throw; // [null/range check failed]
        lVar3 = FUN_180002f80(lVar3,iVar6,DAT_181d643f8);
        if (lVar3 != null) {
          lVar3 = FUN_18046c0a0(0);
          if (((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) ||
             (lVar3 = *(int64 *)(*(int64 *)(lVar3 + 32) + 80)) == null) throw; // [null/range check failed]
          lVar3 = FUN_180002f80(lVar3,iVar6,DAT_181d643f8);
          if (lVar3 == null) throw; // [null/range check failed]
          fVar9 = (float)HeroData.Favor(lVar3,0,0);
          if (50.0 <= fVar9) {
            lVar3 = FUN_18046c0a0(0);
            if (((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) ||
               (lVar3 = *(int64 *)(*(int64 *)(lVar3 + 32) + 80)) == null)
            throw; // [null/range check failed]
            lVar3 = FUN_180002f80(lVar3,iVar6,DAT_181d643f8);
            if (lVar3 != restrictHeroData) {
              lVar3 = FUN_18046c0a0(0);
              if (((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) ||
                 (lVar3 = *(int64 *)(*(int64 *)(lVar3 + 32) + 80)) == null)
              throw; // [null/range check failed]
              lVar3 = FUN_180002f80(lVar3,iVar6,DAT_181d643f8);
              if (lVar3 == null) throw; // [null/range check failed]
              cVar1 = HeroData.HavePrelover(sourceHeroData,*(uint32 *)(lVar3 + 88),0);
              if (!cVar1) {
                lVar3 = FUN_18046c0a0(0);
                if (((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) ||
                   (lVar3 = *(int64 *)(*(int64 *)(lVar3 + 32) + 80)) == null)
                throw; // [null/range check failed]
                uVar4 = FUN_180002f80(lVar3,iVar6,DAT_181d643f8);
                if (targetList == null) throw; // [null/range check failed]
                cVar1 = FUN_1818279a0(targetList,uVar4,DAT_181d63ef8);
                if (!cVar1) {
                  lVar3 = FUN_18046c0a0(0);
                  if (((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) ||
                     (lVar3 = *(int64 *)(*(int64 *)(lVar3 + 32) + 80)) == null)
                  throw; // [null/range check failed]
                  uVar4 = FUN_180002f80(lVar3,iVar6,DAT_181d643f8);
                  FUN_181827900(targetList,uVar4,DAT_181d63d78);
                }
              }
            }
          }
        }
        iVar6 = iVar6 + 1;
        goto LAB_180474e90;
        LAB_1804751b1:
        if (targetList != null) {
          uVar7 = *(int *)(targetList + 24) - 1;
          if (-1 < (int)uVar7) {
            lVar3 = (int64)(int)uVar7 * 8 + 32;
            do {
              if (*(uint32 *)(targetList + 24) <= uVar7) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar5 = *(int64 *)(lVar3 + *(int64 *)(targetList + 16));
              if (lVar5 == null) throw; // [null/range check failed]
              if (*(char *)(lVar5 + 96) == false) {
                lVar5 = FUN_180002f80(targetList,uVar7,DAT_181d643f8);
                if (lVar5 == null) throw; // [null/range check failed]
                if (*(char *)(lVar5 + 209) == false)
                {
                  }
                  else {
                }
                FUN_18182b220(targetList,uVar7,DAT_181d641f8);
              }
              lVar3 = lVar3 + -8;
              uVar7 = uVar7 - 1;
            } while (-1 < (int)uVar7);
          }
          return;
        }
    }

    // Token : 0x6001936
    // RVA   : 0x475E30   Offset: 0x474630   Length: 0x6C
    public IEnumerator HeroEnteringParty()
    {
        long lVar1;
        lVar1 = new WarpText_d__8(0,0);
        if (lVar1 != null) {
          *(uint64 *)(lVar1 + 32) = this;
          return lVar1;
        }
    }

    // Token : 0x6001937
    // RVA   : 0x4752C0   Offset: 0x473AC0   Length: 0xBC
    public void ChangeBaseScore(float delta)
    {
        long lVar1;
        ulong uVar2;
        this.baseScore = delta + this.baseScore;
        PartyController.RefreshExtraRateInfo(this,0);
        if (this.partyUIPanel != null) {
          lVar1 = GameObject.get_transform(this.partyUIPanel,0);
          if (lVar1 != null) {
            uVar2 = Transform.Find(lVar1,"ExtraRateInfo",0);
            uVar2 = ShortcutExtensions.DOScale(uVar2,0x3fc00000,0x3e19999a,0);
            TweenSettingsExtensions.SetLoops(uVar2,2,1,DAT_181d98060);
            return;
          }
        }
    }

    // Token : 0x6001938
    // RVA   : 0x475EA0   Offset: 0x4746A0   Length: 0x6C
    public IEnumerator PartyContinue()
    {
        long lVar1;
        lVar1 = new WarpText_d__8(0,0);
        if (lVar1 != null) {
          *(uint64 *)(lVar1 + 32) = this;
          return lVar1;
        }
    }

    // Token : 0x6001939
    // RVA   : 0x475D30   Offset: 0x474530   Length: 0x6C
    public IEnumerator FinishParty()
    {
        long lVar1;
        lVar1 = new WarpText_d__8(0,0);
        if (lVar1 != null) {
          *(uint64 *)(lVar1 + 32) = this;
          return lVar1;
        }
    }

    // Token : 0x600193A
    // RVA   : 0x475CC0   Offset: 0x4744C0   Length: 0x6C
    public IEnumerator EndParty()
    {
        long lVar1;
        lVar1 = new WarpText_d__8(0,0);
        if (lVar1 != null) {
          *(uint64 *)(lVar1 + 32) = this;
          return lVar1;
        }
    }

    // Token : 0x600193B
    // RVA   : 0x4772E0   Offset: 0x475AE0   Length: 0x18A
    public void SkipButtonClicked()
    {
        bool cVar1;
        long lVar2;
        uint local_18;
        uint uStack_14;
        uint uStack_10;
        uint32 uStack_c;
        cVar1 = this.skipping;
        lVar2 = this.skipButton;
        this.skipping = !cVar1;
        if (!cVar1) {
          if (lVar2 != null) {
            lVar2 = GameObject.get_transform(lVar2,0);
            if (lVar2 != null) {
              lVar2 = Transform.Find(lVar2,"Icon",0);
              if (lVar2 != null) {
                plVar3 = (int64 *)Component.GetComponent(lVar2,DAT_181d6bc40);
                puVar4 = (uint32 *)Color.get_red(&local_18,0);
                if (plVar3 != (int64 *)0) {
                  local_18 = *puVar4;
                  uStack_14 = puVar4[1];
                  uStack_10 = puVar4[2];
                  uStack_c = puVar4[3];
                  (**(code **)(*plVar3 + 0x2a8))(plVar3,&local_18,*(uint64 *)(*plVar3 + 0x2b0));
                  return;
                }
              }
            }
          }
        }
        else if (lVar2 != null) {
          lVar2 = GameObject.get_transform(lVar2,0);
          if (lVar2 != null) {
            lVar2 = Transform.Find(lVar2,"Icon",0);
            if (lVar2 != null) {
              plVar3 = (int64 *)Component.GetComponent(lVar2,DAT_181d6bc40);
              lVar2 = *(int64 *)(DAT_181d4ef00 + 184);
              if (plVar3 != (int64 *)0) {
                local_18 = *(uint32 *)(lVar2 + 0x390);
                uStack_14 = *(uint32 *)(lVar2 + 0x394);
                uStack_10 = *(uint32 *)(lVar2 + 0x398);
                uStack_c = *(uint32 *)(lVar2 + 0x39c);
                (**(code **)(*plVar3 + 0x2a8))(plVar3,&local_18,*(uint64 *)(*plVar3 + 0x2b0));
                return;
              }
            }
          }
        }
    }

    // Token : 0x600193C
    // RVA   : 0x477160   Offset: 0x475960   Length: 0x17F
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

    // Token : 0x600193D
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

    // Token : 0x600193E
    // RVA   : 0x478380   Offset: 0x476B80   Length: 0x40C
    private static void /*cctor*/()
    {
        var pStatics = *(int64*)(DAT_181d6b060 + 184);
        long lVar1;
        lVar1 = il2cpp_internal(DAT_181d72a30);
        FUN_180f58a90(lVar1,DAT_181d7c250);
        if (lVar1 != null) {
          FUN_181827900(lVar1,"听闻#SourceInteractName#在此举办宴会，我就立刻赶来了！\n上次喝得不够尽兴，今天咱俩可得不醉不归！",DAT_181d7c3d0);
          FUN_181827900(lVar1,"哈哈，#SourceInteractName#一日不见，如隔三秋。\n我不请自来，还望莫要嫌弃。",DAT_181d7c3d0);
          FUN_181827900(lVar1,"#SourceInteractName#举办宴会，怎能少了我捧场？\n有什么需要帮忙的，只管开口便是。",DAT_181d7c3d0);
          FUN_181827900(lVar1,"闻着酒香一路而来，没想到是#SourceInteractName#你在举办宴会啊！\n也罢也罢，既来之则安之，我找个位置去也。",DAT_181d7c3d0);
          FUN_181827900(lVar1,"#SourceInteractName#举办宴会，我怎能不来？\n哈哈哈，若能在此遇上其他熟人，那可就热闹了！",DAT_181d7c3d0);
          FUN_181827900(lVar1,"无巧不成书，我恰好在附近逗留，便听闻#SourceInteractName#宴会之消息，\n看来今天这杯酒，是不得不喝了呀！",DAT_181d7c3d0);
          FUN_181827900(lVar1,"今日路过此地，竟恰好赶上#SourceInteractName#的宴会，\n真是有缘千里来相会，不喝一杯也不行了。",DAT_181d7c3d0);
          FUN_181827900(lVar1,"#SourceInteractName#在这儿大摆宴席，想必是遇上啥喜事了，\n等会可得和我好好说道说道。",DAT_181d7c3d0);
          FUN_181827900(lVar1,"几日不见，#SourceInteractName#风姿依旧，\n看来这人逢喜事精神爽，果不是虚言啊。",DAT_181d7c3d0);
          plVar2 = (int64 *)(pStatics + 8);
          *plVar2 = lVar1;
          il2cpp_internal(plVar2,lVar1);
          lVar1 = il2cpp_internal(DAT_181d72a30);
          FUN_180f58a90(lVar1,DAT_181d7c250);
          if (lVar1 != null) {
            FUN_181827900(lVar1,"一听说#SourceInteractName#要和{0}在此举办婚礼，我就马不停蹄赶来了！\n还特意备了这#PlotInteractItemName#聊表心意，不必客气！",DAT_181d7c3d0);
            FUN_181827900(lVar1,"哈哈，#SourceInteractName#和{0}的大喜之日，怎能少了我#$TargetInteractName#捧场！\n这#PlotInteractItemName#是我准备的贺礼，#PlayerName#一定要收下！",DAT_181d7c3d0);
            FUN_181827900(lVar1,"几日未见，没想到#SourceInteractName#就要和{0}拜堂成亲了，恭喜恭喜！\n我临时准备了这#PlotInteractItemName#作礼，还望莫要嫌弃。",DAT_181d7c3d0);
            FUN_181827900(lVar1,"#SourceInteractName#风采照人，{0}也是仪态非凡，\n天生才子佳人配，只羡鸳鸯不羡仙，当真是天作之合！\n这份#PlotInteractItemName#贺礼，请两位收下。",DAT_181d7c3d0);
            FUN_181827900(lVar1,"百年恩爱双心结，千里姻缘一线牵，\n看到#SourceInteractName#和{0}终于修成正果，我也是由衷欢喜！\n这#PlotInteractItemName#作为贺礼虽不甚名贵，却也是我的一片心意，还请两位笑纳。",DAT_181d7c3d0);
            FUN_181827900(lVar1,"牲酒赛秋社，箫鼓迎新婚，\n今天是#SourceInteractName#和{0}大喜的日子，不好好热闹一番怎么行？\n你看，我还带了这件#PlotInteractItemName#作为新婚之礼，不成敬意，不成敬意！",DAT_181d7c3d0);
            FUN_181827900(lVar1,"#SourceInteractName#和{0}二位春光满面，笑语盈盈，真是人逢喜事精神爽！\n收下这件#PlotInteractItemName#，我也好沾沾你们的喜气，哈哈！",DAT_181d7c3d0);
            FUN_181827900(lVar1,"哎呀呀，#SourceInteractName#和{0}这对神仙侠侣终于成婚，我#$TargetInteractName#岂能不来？\n来来来，这件#PlotInteractItemName#是我的贺礼，你们小两口收好了。",DAT_181d7c3d0);
            plVar2 = (int64 *)(pStatics + 16);
            *plVar2 = lVar1;
            il2cpp_internal(plVar2,lVar1);
            lVar1 = il2cpp_internal(DAT_181d72a30);
            FUN_180f58a90(lVar1,DAT_181d7c250);
            if (lVar1 != null) {
              FUN_181827900(lVar1,"（无趣）哎，食之无味弃之可惜，\n看在#SourceInteractName#面子上，还算勉强喝了几杯。",DAT_181d7c3d0);
              FUN_181827900(lVar1,"（平平）筵席虽不甚精美，但也算热闹欢腾。\n饮宴过后只觉烦恼疲惫一扫而空，快哉快哉！",DAT_181d7c3d0);
              FUN_181827900(lVar1,"（满意）食不厌精，烩不厌细，\n多谢#SourceInteractName#慷慨大方，尽地主之谊，方才使得举座皆欢，宾朋尽乐。",DAT_181d7c3d0);
              FUN_181827900(lVar1,"（欢喜）金樽清酒斗十千，玉盘珍羞直万钱。\n若非#SourceInteractName#情高志远，品味不俗，难成此精美绝伦之筵席，佩服佩服。",DAT_181d7c3d0);
              FUN_181827900(lVar1,"（极乐）此宴只应天上有，人间能得几回闻。\n如此极尽华美之筵席只消稍作体会，怕是连宫廷御宴也再难入眼了。",DAT_181d7c3d0);
              plVar2 = (int64 *)(pStatics + 24);
              *plVar2 = lVar1;
              il2cpp_internal(plVar2,lVar1);
              return;
            }
          }
        }
    }

    // Token : 0x600193F
    // RVA   : 0x478350   Offset: 0x476B50   Length: 0x20
    private void <PartyEnd>b__33_0()
    {
        if (this.partyUIPanel != null) {
          GameObject.SetActive(this.partyUIPanel,0,0);
          return;
        }
    }

    // Token : 0x6001940
    // RVA   : 0x478330   Offset: 0x476B30   Length: 0x1D
    private void <PartyContinue>b__56_0()
    {
        if (this.partySound != null) {
          AudioSource.Stop(this.partySound,0);
          return;
        }
    }

}
