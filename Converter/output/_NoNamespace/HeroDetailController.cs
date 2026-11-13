// ============================================================
// Type  : HeroDetailController
// Token : 0x20002CA
// ============================================================

public class HeroDetailController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001743
    public SkillListType nowSkillListType;

    // Token: 0x4001744
    public GameObject heroDetailPanel;

    // Token: 0x4001745
    public GameObject heroDetailTabPrefab;

    // Token: 0x4001746
    public GameObject heroBaseFightDataPrefab;

    // Token: 0x4001747
    public GameObject heroExtraFightDataPrefab;

    // Token: 0x4001748
    public GameObject forceContributionInfoPrefab;

    // Token: 0x4001749
    public ItemListController itemListController;

    // Token: 0x400174A
    public GameObject skillGrid;

    // Token: 0x400174B
    public HeroData mainShowHero;

    // Token: 0x400174C
    public HeroData nowShowHero;

    // Token: 0x400174D
    private int originSkinID;

    // Token: 0x400174E
    private int originSkinLV;

    // Token: 0x400174F
    private GameObject temp;

    // Token: 0x4001750
    private bool init;

    // Token: 0x4001751
    public Dropdown skillSortTypeDropDown;

    // Token: 0x4001752
    public SkillSortType skillSortType;

    // Token: 0x4001753
    public bool reverseOrder;

    // Token: 0x4001754
    public bool itemSpeControlable;

    // Token: 0x4001755
    private static HeroDetailController _instance;

    // Token: 0x4001756
    private bool sortTypeLoaded;

    // Token: 0x4001757
    public GameObject clothGrid;

    // Token: 0x4001758
    public GameObject clothChoicePrefab;

    // Token: 0x4001759
    private bool clothListInited;

    // Token: 0x400175A
    private int tempSkinID;

    // Token: 0x400175B
    private int tempSkinLv;

    // Token: 0x400175C
    private int tempHairID;

    // Token: 0x400175D
    private int tempBeardID;

    // Token: 0x400175E
    private int tempOtherID;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60017ED
    // RVA   : 0xB206A0   Offset: 0xB1F4A0   Length: 0x36
    public static HeroDetailController get_Instance()
    {
        return **(uint64 **)(DAT_181e55ae8 + 184);
    }

    // Token : 0x60017EE
    // RVA   : 0xB0ABC0   Offset: 0xB099C0   Length: 0xB6
    private void Awake()
    {
        ulong uVar1;
        bool cVar3;
        uVar1 = **(uint64 **)(DAT_181e55ae8 + 184);
        cVar3 = Object.op_Equality(uVar1,0,0);
        if (cVar3) {
          plVar2 = *(int64 **)(DAT_181e55ae8 + 184);
          *plVar2 = this;
          il2cpp_internal(plVar2,this);
        }
        this.mainShowHero = 0;
        this.nowShowHero = 0;
    }

    // Token : 0x60017EF
    // RVA   : 0xB1F390   Offset: 0xB1E190   Length: 0x158
    private void Start()
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        if (**(int **)(DAT_181e538e8 + 184) == 1) {
          cVar1 = RailManager.get_Initialized(0);
          if (!cVar1) {
            Debug.LogError("Rail sdk is not initialized!",0);
            return;
          }
          lVar2 = RailCallBackHelper.get_Instance(0);
          uVar3 = new OnTooltipCB(this,DAT_181e5c150,0);
          if (lVar2 == null) {
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          RailCallBackHelper.RegisterCallback(lVar2,0x1f45,uVar3,0);
        }
    }

    // Token : 0x60017F0
    // RVA   : 0xB20460   Offset: 0xB1F260   Length: 0x1D
    private void Update()
    {
        void FUN_180b20460(int64 this)
        {
        int64 lVar1;
        lVar1 = this.nowShowHero;
        if ((lVar1 != null) && (lVar1.heroDetailDirty)) {
          HeroData.CheckHeroDetailDirty(lVar1,0,0);
          return;
        }
    }

    // Token : 0x60017F1
    // RVA   : 0xB1E500   Offset: 0xB1D300   Length: 0xF8
    public void SetHeroDetail(int id)
    {
        if ((id != null) && (id != this.mainShowHero)) {
          HeroDetailController.ShowHeroDetail(this,id,0,0);
          return;
        }
        HeroDetailController.UnshowHeroDetail(this,0);
    }

    // Token : 0x60017F2
    // RVA   : 0xB1E600   Offset: 0xB1D400   Length: 0x1D
    public void SetHeroDetail(HeroData targetHero)
    {
        if ((targetHero != null) && (targetHero != this.mainShowHero)) {
          HeroDetailController.ShowHeroDetail(this,targetHero,0,0);
          return;
        }
        HeroDetailController.UnshowHeroDetail(this,0);
    }

    // Token : 0x60017F3
    // RVA   : 0xB20250   Offset: 0xB1F050   Length: 0x20F
    public void UnshowHeroDetail()
    {
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        uint local_18;
        uint local_14;
        uint local_10;
        plVar1 = (int64 *)Resources.Load("Sound/SoundEffect/PaperQuick",0);
        plVar5 = (int64 *)0;
        if ((plVar1 != (int64 *)0) && (*plVar1 == DAT_181e8f4a0)) {
          plVar5 = plVar1;
        }
        NGUITools.PlaySound(plVar5,0);
        HeroDetailController.HideNameInput(this,0);
        HeroDetailController.SetClothList(this,0,0);
        if (this.heroDetailPanel != null) {
          lVar2 = GameObject.get_transform(this.heroDetailPanel,0);
          if (lVar2 != null) {
            lVar2 = Transform.Find(lVar2,"BlackBackground",0);
            if (lVar2 != null) {
              uVar3 = Component.GetComponent(lVar2,DAT_181e777b8);
              uVar3 = DOTweenModuleUI.DOFade(uVar3,0,0x3e4ccccd,0);
              uVar3 = TweenSettingsExtensions.SetUpdate(uVar3,1,DAT_181ea5848);
              TweenSettingsExtensions.SetEase(uVar3,9,DAT_181ea48e0);
              if (this.heroDetailPanel != null) {
                uVar3 = GameObject.get_transform(this.heroDetailPanel,0);
                local_18 = 0;
                local_14 = 0x3f800000;
                local_10 = 0x3f800000;
                uVar3 = ShortcutExtensions.DOScale(uVar3,&local_18,0x3e4ccccd,0);
                uVar4 = new OnTooltipCB(this,DAT_181e5c0c8,0);
                TweenSettingsExtensions.OnComplete(uVar3,uVar4,DAT_181ea3dc0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x60017F4
    // RVA   : 0xB14A20   Offset: 0xB13820   Length: 0x55E
    public void LoadSortTypeFromWorldData()
    {
        long lVar1;
        long lVar2;
        int iVar3;
        ulong uVar4;
        int iVar5;
        uint local_18;
        float local_14;
        uint local_10;
        if (this.sortTypeLoaded) {
          return;
        }
        this.sortTypeLoaded = 1;
        if (this.itemListController != null) {
          lVar2 = this.itemListController.sortTypeDropDown;
          if (((GameController._instance != null) &&
              (lVar1 = GameController._instance.worldData) != null) &&
             (lVar2 != null)) {
            Dropdown.set_value(lVar2,lVar1.itemSortType,0);
            lVar2 = this.itemListController;
            if (((GameController._instance != null) &&
                (lVar1 = GameController._instance.worldData) != null) &&
               (lVar2 != null)) {
              lVar2.reverseOrder = lVar1.itemReverseOrder;
              if ((((this.itemListController != null) &&
                   (lVar2 = this.itemListController.sortTypeDropDown) != null) &&
                  (lVar2 = Component.get_transform(lVar2,0)) != null) &&
                 ((lVar2 = FUN_180b05920(lVar2,0), lVar2 != null &&
                  (lVar2 = Transform.Find(lVar2,"ReverseType",0)) != null))) {
                lVar2 = Transform.Find(lVar2,"Icon",0);
                if (this.itemListController != null) {
                  iVar5 = -1;
                  iVar3 = -1;
                  if (!this.itemListController.reverseOrder) {
                    iVar3 = 1;
                  }
                  if (lVar2 != null) {
                    local_18 = 0x3f800000;
                    local_10 = 0x3f800000;
                    local_14 = (float)iVar3;
                    Transform.set_localScale(lVar2,&local_18,0);
                    if (((this.itemListController != null) &&
                        (lVar2 = this.itemListController.sortTypeDropDown) != null) &&
                       ((lVar2 = Component.get_transform(lVar2,0), lVar2 != null &&
                        ((lVar2 = FUN_180b05920(lVar2,0), lVar2 != null &&
                         (lVar2 = Transform.Find(lVar2,"ReverseType",0)) != null))))) {
                      lVar2 = Component.GetComponent(lVar2,DAT_181e788b8);
                      if (this.itemListController != null) {
                        uVar4 = "升序";
                        if (this.itemListController.reverseOrder) {
                          uVar4 = "降序";
                        }
                        if (lVar2 != null) {
                          lVar2.itemGrid = uVar4;
                          lVar2 = this.skillSortTypeDropDown;
                          if (((GameController._instance != null) &&
                              (lVar1 = GameController._instance.worldData,
                              lVar1 != null)) && (lVar2 != null)) {
                            Dropdown.set_value(lVar2,lVar1.skillSortType,0);
                            if ((GameController._instance != null) &&
                               (lVar2 = GameController._instance.worldData,
                               lVar2 != null)) {
                              this.reverseOrder = lVar2.skillReverseOrder;
                              if ((this.skillSortTypeDropDown != null) &&
                                 (((lVar2 = Component.get_transform(this.skillSortTypeDropDown,0),
                                   lVar2 != null && (lVar2 = FUN_180b05920(lVar2,0)) != null) &&
                                  (lVar2 = Transform.Find(lVar2,"ReverseType",0)) != null))) {
                                lVar2 = Transform.Find(lVar2,"Icon",0);
                                if (!this.reverseOrder) {
                                  iVar5 = 1;
                                }
                                if (lVar2 != null) {
                                  local_18 = 0x3f800000;
                                  local_10 = 0x3f800000;
                                  local_14 = (float)iVar5;
                                  Transform.set_localScale(lVar2,&local_18,0);
                                  if (((this.skillSortTypeDropDown != null) &&
                                      (lVar2 = Component.get_transform(this.skillSortTypeDropDown,0),
                                      lVar2 != null)) &&
                                     ((lVar2 = FUN_180b05920(lVar2,0), lVar2 != null &&
                                      (lVar2 = Transform.Find(lVar2,"ReverseType",0)) != null))) {
                                    lVar2 = Component.GetComponent(lVar2,DAT_181e788b8);
                                    uVar4 = "升序";
                                    if (this.reverseOrder) {
                                      uVar4 = "降序";
                                    }
                                    if (lVar2 != null) {
                                      lVar2.itemGrid = uVar4;
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

    // Token : 0x60017F5
    // RVA   : 0xB1EEF0   Offset: 0xB1DCF0   Length: 0x3D1
    public void ShowHeroDetail(HeroData targetHero, bool _itemSpeControlable)
    {
        var pStatics = *(int64*)(DAT_181e6af70 + 184);
        long lVar1;
        long lVar2;
        ulong uVar5;
        ulong uVar6;
        uint local_18;
        uint uStack_14;
        uint uStack_10;
        uint32 uStack_c;
        lVar1 = new c.DisplayClass9_0(0);
        if (lVar1 != null) {
          *(uint64 *)(lVar1 + 16) = targetHero;
          lVar2 = *(int64 *)(lVar1 + 16);
          if ((lVar2 == null) || (*(char *)(lVar2 + 16) != false)) {
            return;
          }
          HeroData.CheckHeroDetailDirty(lVar2,1,0);
          this.mainShowHero = *(uint64 *)(lVar1 + 16);
          this.itemSpeControlable = _itemSpeControlable;
          if (this.heroDetailPanel != null) {
            GameObject.SetActive(this.heroDetailPanel,1,0);
            HeroDetailController.LoadSortTypeFromWorldData(this,0);
            if (*pStatics != 0) {
              MissionUIController.ShowMissionUI(*pStatics,0,0);
              HeroDetailController.FreshHeroDetail(this,1,0);
              if ((this.heroDetailPanel != null) &&
                 (lVar2 = GameObject.get_transform(this.heroDetailPanel,0)) != null) {
                uStack_14 = 0x3f800000;
                local_18 = 0;
                uStack_10 = 0x3f800000;
                Transform.set_localScale(lVar2,&local_18,0);
                if ((this.heroDetailPanel != null) &&
                   ((lVar2 = GameObject.get_transform(this.heroDetailPanel,0), lVar2 != null &&
                    (lVar2 = Transform.Find(lVar2,"BlackBackground",0)) != null))) {
                  plVar3 = (int64 *)Component.GetComponent(lVar2,DAT_181e777b8);
                  puVar4 = (uint32 *)FUN_180af4e90(&local_18,0);
                  if (plVar3 != (int64 *)0) {
                    local_18 = *puVar4;
                    uStack_14 = puVar4[1];
                    uStack_10 = puVar4[2];
                    uStack_c = puVar4[3];
                    (**(code **)(*plVar3 + 0x2a8))(plVar3,&local_18,*(uint64 *)(*plVar3 + 0x2b0));
                    if (((this.heroDetailPanel != null) &&
                        (lVar2 = GameObject.get_transform(this.heroDetailPanel,0)) != null)
                       && (lVar2 = Transform.Find(lVar2,"BlackBackground",0)) != null) {
                      uVar5 = Component.GetComponent(lVar2,DAT_181e777b8);
                      uVar5 = DOTweenModuleUI.DOFade(uVar5,0x3f000000,0x3e800000,0);
                      uVar5 = TweenSettingsExtensions.SetUpdate(uVar5,1,DAT_181ea5848);
                      TweenSettingsExtensions.SetEase(uVar5,8,DAT_181ea48e0);
                      if (this.heroDetailPanel != null) {
                        uVar5 = GameObject.get_transform(this.heroDetailPanel,0);
                        uVar5 = ShortcutExtensions.DOScale(uVar5,0x3f800000,0x3e800000,0);
                        uVar5 = TweenSettingsExtensions.SetUpdate(uVar5,1,DAT_181ea59e0);
                        uVar6 = new OnTooltipCB(lVar1,DAT_181e89120,0);
                        TweenSettingsExtensions.OnComplete(uVar5,uVar6,DAT_181ea3dc0);
                        plVar3 = (int64 *)Resources.Load("Sound/SoundEffect/Paper",0);
                        plVar7 = (int64 *)0;
                        if ((plVar3 != (int64 *)0) && (*plVar3 == DAT_181e8f4a0)) {
                          plVar7 = plVar3;
                        }
                        NGUITools.PlaySound(plVar7,0);
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

    // Token : 0x60017F6
    // RVA   : 0xB13EB0   Offset: 0xB12CB0   Length: 0x902
    private void Init()
    {
        var pStatics_2a90 = *(int64*)(DAT_181e52a90 + 184);
        var pStatics_b8e8 = *(int64*)(DAT_181e8b8e8 + 184);
        bool cVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        long lVar6;
        int iVar7;
        int[] local_res8 = new int[4];
        int[] local_res18 = new int[4];
        ulong local_60;
        ulong uStack_58;
        long local_50;
        byte[] local_48 = new byte[16];
        long local_38;
        iVar7 = 0;
        local_res18[0] = 0;
        local_60 = 0;
        uStack_58 = 0;
        local_50 = 0;
        this.init = 1;
        local_res8[0] = 0;
        do {
          if ((this.heroDetailPanel == null) ||
             (lVar2 = GameObject.get_transform(this.heroDetailPanel,0)) == null)
          throw; // [null/range check failed]
          lVar2 = Transform.Find(lVar2,"Item",0);
          uVar3 = Int32.ToString(local_res8,0);
          uVar3 = String.Concat("EquipSlot",uVar3);
          if ((lVar2 == null) || (lVar2 = Transform.Find(lVar2,uVar3,0)) == null) throw; // [null/range check failed]
          uVar3 = Component.get_gameObject(lVar2,0);
          if (*pStatics_2a90 == 0) throw; // [null/range check failed]
          uVar4 = *(uint64 *)(*pStatics_2a90 + 160);
          uVar3 = GlobalData.AddChild(uVar3,uVar4);
          this.temp = uVar3;
          if ((this.temp == null) ||
             (Object.set_name(), this.temp == null)) throw; // [null/range check failed]
          GameObject.SetActive();
          local_res8[0] = local_res8[0] + 1;
        } while (local_res8[0] < 8);
        while( true ) {
          lVar2 = this.heroDetailPanel;
          if (*(int *)(*(int64 *)(DAT_181e538e8 + 184) + 140) + 3 <= iVar7) break;
          if ((lVar2 == null) || (lVar2 = GameObject.get_transform(lVar2,0)) == null)
          throw; // [null/range check failed]
          lVar2 = Transform.Find(lVar2,"Skill");
          uVar3 = Int32.ToString(local_res18,0);
          uVar3 = String.Concat("SkillSlot",uVar3);
          if ((lVar2 == null) || (lVar2 = Transform.Find(lVar2,uVar3)) == null) throw; // [null/range check failed]
          uVar3 = Component.get_gameObject(lVar2,0);
          if (*pStatics_2a90 == 0) throw; // [null/range check failed]
          uVar4 = *(uint64 *)(*pStatics_2a90 + 168);
          uVar3 = GlobalData.AddChild(uVar3,uVar4);
          this.temp = uVar3;
          if ((this.temp == null) ||
             (Object.set_name(), this.temp == null)) throw; // [null/range check failed]
          GameObject.SetActive();
          iVar7 = local_res18[0] + 1;
          local_res18[0] = iVar7;
        }
        if ((((lVar2 != null) && (lVar2 = GameObject.get_transform(lVar2,0)) != null) &&
            (lVar2 = Transform.Find(lVar2,"ForceContribution",0)) != null) &&
           ((lVar2 = Transform.Find(lVar2,"Viewport",0), lVar2 != null &&
            (lVar2 = Transform.Find(lVar2,"Content",0)) != null))) {
          uVar4 = Component.get_gameObject(lVar2,0);
          uVar3 = this.forceContributionInfoPrefab;
          uVar3 = GlobalData.AddChild(uVar4,uVar3,0);
          this.temp = uVar3;
          if (this.temp != null) {
            Object.set_name(this.temp,"-1",0);
            if (((this.temp != null) &&
                (lVar2 = GameObject.get_transform(this.temp,0)) != null) &&
               (lVar2 = Transform.Find(lVar2,"ForceIcon",0)) != null) {
              lVar2 = Component.GetComponent(lVar2,DAT_181e777b8);
              if ((*pStatics_b8e8 != 0) &&
                 (uVar3 = TextureController.LoadAtlasSprite
                                    (*pStatics_b8e8,"UIAtlas","官府功绩",0),
                 lVar2 != null)) {
                Image.set_sprite(lVar2,uVar3,0);
                if ((this.temp != null) &&
                   (((lVar2 = GameObject.get_transform(this.temp,0), lVar2 != null &&
                     (lVar2 = Transform.Find(lVar2,"ForceName",0)) != null) &&
                    (plVar5 = (int64 *)Component.GetComponent(lVar2,DAT_181e79538),
                    plVar5 != (int64 *)0)))) {
                  (**(code **)(*plVar5 + 0x5e8))(plVar5,"官府",*(uint64 *)(*plVar5 + 0x5f0));
                  lVar2 = FUN_1802106e0(0);
                  if (((lVar2 != null) && (*(int64 *)(lVar2 + 32) != 0)) &&
                     (lVar2 = *(int64 *)(*(int64 *)(lVar2 + 32) + 72)) != null) {
                    FUN_1816629a0(local_48,lVar2,DAT_181e6a378);
                    local_50 = local_38;
                    while( true ) {
                      cVar1 = FUN_1807b3f30(&local_60,DAT_181e6e0c0);
                      lVar2 = local_50;
                      if (!cVar1) {
                        ZhSegment.Initialize(&local_60,DAT_181e6e040);
                        return;
                      }
                      if (this.heroDetailPanel == null) {
                          // WARNING: Subroutine does not return
                        FUN_1801e0300();
                      }
                      lVar6 = GameObject.get_transform(this.heroDetailPanel,0);
                      if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                        FUN_1801e0300();
                      }
                      lVar6 = Transform.Find(lVar6,"ForceContribution",0);
                      if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                        FUN_1801e0300();
                      }
                      lVar6 = Transform.Find(lVar6,"Viewport",0);
                      if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                        FUN_1801e0300();
                      }
                      lVar6 = Transform.Find(lVar6,"Content",0);
                      if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                        FUN_1801e0300();
                      }
                      uVar4 = Component.get_gameObject(lVar6,0);
                      uVar3 = this.forceContributionInfoPrefab;
                      uVar3 = GlobalData.AddChild(uVar4,uVar3,0);
                      this.temp = uVar3;
                      lVar6 = this.temp;
                      if (lVar2 == null) {
                          // WARNING: Subroutine does not return
                        FUN_1801e0300();
                      }
                      uVar3 = Int32.ToString(lVar2 + 16,0);
                      if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                        FUN_1801e0300();
                      }
                      Object.set_name(lVar6,uVar3,0);
                      if (this.temp == null) break;
                      lVar6 = GameObject.get_transform(this.temp,0);
                      if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                        FUN_1801e0300();
                      }
                      lVar6 = Transform.Find(lVar6,"ForceIcon",0);
                      if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                        FUN_1801e0300();
                      }
                      lVar6 = Component.GetComponent(lVar6,DAT_181e777b8);
                      uVar3 = ForceData.GetForceIcon(lVar2,0);
                      if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                        FUN_1801e0300();
                      }
                      Image.set_sprite(lVar6,uVar3,0);
                      if (this.temp == null) {
                          // WARNING: Subroutine does not return
                        FUN_1801e0300();
                      }
                      lVar6 = GameObject.get_transform(this.temp,0);
                      if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                        FUN_1801e0300();
                      }
                      lVar6 = Transform.Find(lVar6,"ForceName",0);
                      if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                        FUN_1801e0300();
                      }
                      plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181e79538);
                      uVar3 = ForceData.GetForceName(lVar2,1,0);
                      if (plVar5 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                        FUN_1801e0300();
                      }
                      (**(code **)(*plVar5 + 0x5e8))(plVar5,uVar3);
                    }
                          // WARNING: Subroutine does not return
                    FUN_1801e0300();
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x60017F7
    // RVA   : 0xB0C6E0   Offset: 0xB0B4E0   Length: 0x1D7
    public void FreshHeroDetail(bool resetPos)
    {
        long lVar1;
        uint uVar2;
        long lVar3;
        ulong uVar4;
        int iVar5;
        if (!this.init) {
          HeroDetailController.Init(this,0);
        }
        if (((this.heroDetailPanel != null) &&
            (lVar3 = GameObject.get_transform(this.heroDetailPanel,0)) != null) &&
           (lVar3 = Transform.Find(lVar3,"HeroTabGrid",0)) != null) {
          uVar4 = Component.get_gameObject(lVar3,0);
          GlobalData.DeleteAllChild(uVar4,0);
          HeroDetailController.CreateHeroDetailTab(this,this.mainShowHero,0);
          lVar3 = this.mainShowHero;
          iVar5 = 0;
          if (lVar3 != null) {
            while (lVar3.teamMates != null) {
              if (*(int *)(lVar3.teamMates + 24) <= iVar5) {
                HeroDetailController.FreshNowHeroDetail(this,lVar3,resetPos,0);
                return;
              }
              lVar3 = FUN_1802106e0(0);
              if (lVar3 == null) break;
              lVar3 = lVar3.summonControlable;
              if (((this.mainShowHero == null) ||
                  (lVar1 = this.mainShowHero.teamMates) == null) ||
                 (uVar2 = FUN_180002480(lVar1,iVar5,DAT_181e71bf0), lVar3 == null)) break;
              uVar4 = WorldData.GetHero(lVar3,uVar2,0);
              HeroDetailController.CreateHeroDetailTab(this,uVar4,0);
              lVar3 = this.mainShowHero;
              iVar5 = iVar5 + 1;
              if (lVar3 == null) break;
            }
          }
        }
    }

    // Token : 0x60017F8
    // RVA   : 0xB14F80   Offset: 0xB13D80   Length: 0x37
    public bool NowShowHeroItemControlable()
    {
        bool cVar1;
        if (this.nowShowHero == null) {
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        cVar1 = HeroData.ItemControlable(this.nowShowHero,0);
        if (cVar1) {
          return true;
        }
        return this.itemSpeControlable;
    }

    // Token : 0x60017F9
    // RVA   : 0xB0B6C0   Offset: 0xB0A4C0   Length: 0x1C4
    public void CreateHeroDetailTab(HeroData targetHero)
    {
        long lVar1;
        ulong uVar2;
        ulong uVar3;
        if (this.heroDetailPanel != null) {
          lVar1 = GameObject.get_transform(this.heroDetailPanel,0);
          if (lVar1 != null) {
            lVar1 = Transform.Find(lVar1,"HeroTabGrid",0);
            if (lVar1 != null) {
              uVar2 = Component.get_gameObject(lVar1,0);
              uVar3 = this.heroDetailTabPrefab;
              uVar3 = GlobalData.AddChild(uVar2,uVar3,0);
              this.temp = uVar3;
              if (this.temp != null) {
                lVar1 = GameObject.get_transform(this.temp,0);
                if (lVar1 != null) {
                  lVar1 = Transform.Find(lVar1,"Label",0);
                  if (lVar1 != null) {
                    uVar3 = Component.GetComponent(lVar1,DAT_181e79538);
                    if (targetHero != null) {
                      uVar2 = HeroData.HeroName(targetHero,0,0);
                      LTLocalization.SetText(uVar3,uVar2,0);
                      if (this.temp != null) {
                        lVar1 = GameObject.GetComponent(this.temp,DAT_181e54b08);
                        if (lVar1 != null) {
                          *(int64 *)(lVar1 + 24) = targetHero;
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

    // Token : 0x60017FA
    // RVA   : 0xB191A0   Offset: 0xB17FA0   Length: 0x87
    public void RefreshHeroSkeleton()
    {
        long lVar1;
        long lVar2;
        ulong uVar3;
        lVar1 = this.nowShowHero;
        if (this.heroDetailPanel != null) {
          lVar2 = GameObject.get_transform(this.heroDetailPanel,0);
          if (lVar2 != null) {
            uVar3 = Transform.Find(lVar2,"Face",0);
            if (lVar1 != null) {
              HeroData.SetSkeletonGraphic(lVar1,uVar3,0xffffff9d,0xffffffff,0);
              return;
            }
          }
        }
    }

    // Token : 0x60017FB
    // RVA   : 0xB0C8C0   Offset: 0xB0B6C0   Length: 0x7381
    public void FreshNowHeroDetail(HeroData targetHero, bool resetPos)
    {
        // Decompilation failed
        // Type: HeroDetailController
        // Member: FreshNowHeroDetail
        // RVA: 0xB0C8C0
        // Error: Exception while decompiling 180b0c8c0: process: timeout
    }

    // Token : 0x60017FC
    // RVA   : 0xB20480   Offset: 0xB1F280   Length: 0x1C3
    public void UseSpeSkeletonButtonClicked()
    {
        long lVar1;
        ulong uVar2;
        long lVar3;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181e528f8 + 184) + 8);
        if (lVar1 != null) {
          lVar1 = *(int64 *)(lVar1 + 16);
          if (this.nowShowHero != null) {
            uVar2 = String.Concat(this.nowShowHero.heroName,"hideSpeSkeleton",0);
            if (this.heroDetailPanel != null) {
              lVar3 = GameObject.get_transform(this.heroDetailPanel,0);
              if (lVar3 != null) {
                lVar3 = Transform.Find(lVar3,"UseSpeSkeleton",0);
                if (lVar3 != null) {
                  lVar3 = Component.GetComponent(lVar3,DAT_181e796b8);
                  if ((lVar3 != null) && (lVar1 != null)) {
                    PlayerPrefDictionary.SetKey(lVar1,uVar2,*(char *)(lVar3 + 0x118) == false,0);
                    HeroDetailController.RefreshHeroSkeleton(this,0);
                    plVar4 = (int64 *)Resources.Load("Sound/SoundEffect/Paper",0);
                    plVar5 = (int64 *)0;
                    if ((plVar4 != (int64 *)0) && (*plVar4 == DAT_181e8f4a0)) {
                      plVar5 = plVar4;
                    }
                    NGUITools.PlaySound(plVar5,0);
                    return;
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x60017FD
    // RVA   : 0xB1D9F0   Offset: 0xB1C7F0   Length: 0x7ED
    public void SetAttriDetail(Transform parent, float totalNum, float baseNum, float maxNum)
    {
        var pStatics = *(int64*)(DAT_181e538e8 + 184);
        void HeroDetailController.SetAttriDetail
                     (uint64 this,int64 parent,float totalNum,float baseNum,float maxNum)
        {
        uint32 uVar1;
        uint32 uVar2;
        int64 lVar3;
        int64 lVar4;
        uint64 uVar5;
        uint64 uVar6;
        uint64 uVar7;
        int64 *plVar8;
        float fVar9;
        float local_res10 [2];
        float local_res18 [2];
        float local_res20 [2];
        uint64 local_58;
        uint64 uStack_50;
        local_res18[0] = totalNum;
        local_res20[0] = baseNum;
        local_res10[0] = 0.0;
        if ((parent != null) && (lVar3 = Transform.Find(parent,"BarBack",0)) != null) {
          lVar3 = Component.GetComponent(lVar3,DAT_181e782b8);
          fVar9 = (float)FUN_180f34e60();
          lVar4 = Transform.Find(parent,"BarBack",0);
          if ((lVar4 != null) && (lVar4 = Component.GetComponent(lVar4,DAT_181e782b8)) != null) {
            local_58 = RectTransform.get_sizeDelta(lVar4,0);
            if (lVar3 != null) {
              RectTransform.set_sizeDelta(lVar3,fVar9 * 1.5,0);
              lVar3 = Transform.Find(parent,"Bar",0);
              if (lVar3 != null) {
                lVar3 = Component.GetComponent(lVar3,DAT_181e782b8);
                if ((((float)*(int *)(pStatics + 248) < maxNum) &&
                    ((*(byte *)(DAT_181e538e8 + 0x133) & 4) != 0)) &&
                   (*(int *)(DAT_181e538e8 + 224) == 0)) {
                  il2cpp_runtime_class_init(DAT_181e538e8);
                }
                fVar9 = (float)FUN_180f34e60();
                lVar4 = Transform.Find(parent,"Bar",0);
                if ((lVar4 != null) && (lVar4 = Component.GetComponent(lVar4,DAT_181e782b8)) != null) {
                  local_58 = RectTransform.get_sizeDelta(lVar4,0);
                  if (lVar3 != null) {
                    RectTransform.set_sizeDelta(lVar3,fVar9 * 1.5,0);
                    lVar3 = Transform.Find(parent,"Total",0);
                    if (lVar3 != null) {
                      uVar5 = Component.GetComponent(lVar3,DAT_181e79538);
                      uVar6 = Single.ToString(local_res18,"f0",0);
                      LTLocalization.SetText(uVar5,uVar6,0);
                      lVar3 = Transform.Find(parent,"Num",0);
                      if (lVar3 != null) {
                        uVar5 = Component.GetComponent(lVar3,DAT_181e79538);
                        uVar6 = Single.ToString(local_res20,"f0",0);
                        uVar7 = Single.ToString(&maxNum,"f0",0);
                        uVar6 = String.Concat(uVar6,"/",uVar7,0);
                        LTLocalization.SetText(uVar5,uVar6,0);
                        if (local_res18[0] == local_res20[0]) {
                          lVar3 = Transform.Find(parent,"SpeAdd",0);
                          if (lVar3 == null) throw; // [null/range check failed]
                          uVar5 = Component.GetComponent(lVar3,DAT_181e79538);
                          LTLocalization.SetText(uVar5,"",0);
                        }
                        else {
                          lVar3 = Transform.Find(parent,"SpeAdd",0);
                          if (lVar3 == null) throw; // [null/range check failed]
                          uVar5 = Component.GetComponent(lVar3,DAT_181e79538);
                          local_res10[0] = local_res18[0] - local_res20[0];
                          uVar6 = Single.ToString(local_res10,"+0;-0;",0);
                          LTLocalization.SetText(uVar5,uVar6,0);
                          lVar3 = Transform.Find(parent,"SpeAdd",0);
                          if (lVar3 == null) throw; // [null/range check failed]
                          plVar8 = (int64 *)Component.GetComponent(lVar3,DAT_181e79538);
                          if (local_res18[0] - local_res20[0] < 0.0) {
                            uVar5 = *(uint64 *)(pStatics + 0x308);
                            uVar6 = *(uint64 *)(pStatics + 0x310);
                          }
                          else {
                            uVar5 = *(uint64 *)(pStatics + 0x2a0);
                            uVar6 = *(uint64 *)(pStatics + 0x2a8);
                          }
                          if (plVar8 == (int64 *)0) throw; // [null/range check failed]
                          local_58 = uVar5;
                          uStack_50 = uVar6;
                          (**(code **)(*plVar8 + 0x2a8))
                                    (plVar8,&local_58,*(uint64 *)(*plVar8 + 0x2b0));
                        }
                        lVar3 = Transform.Find(parent,"Lv",0);
                        if (lVar3 != null) {
                          uVar5 = Component.GetComponent(lVar3,DAT_181e79538);
                          lVar3 = *(int64 *)(pStatics + 0x580);
                          uVar1 = GlobalData.GetAttriLv(pStatics,0);
                          if (lVar3 != null) {
                            if (*(uint32 *)(lVar3 + 24) <= uVar1) {
                              ThrowHelper.ThrowArgumentOutOfRangeException(0);
                            }
                            uVar6 = *(uint64 *)
                                     (*(int64 *)(lVar3 + 16) + 32 + (int64)(int)uVar1 * 8);
                            LTLocalization.SetText(uVar5,uVar6,0);
                            lVar3 = Transform.Find(parent,"Lv",0);
                            if (lVar3 != null) {
                              plVar8 = (int64 *)Component.GetComponent(lVar3,DAT_181e79538);
                              lVar3 = *(int64 *)(*(int64 *)(DAT_181e528f8 + 184) + 32);
                              if (lVar3 != null) {
                                lVar3 = *(int64 *)(lVar3 + 56);
                                uVar2 = GlobalData.GetAttriLv();
                                uVar1 = Mathf.Min(5,uVar2);
                                if (lVar3 != null) {
                                  if (*(uint32 *)(lVar3 + 24) <= uVar1) {
                                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                  }
                                  lVar3 = *(int64 *)
                                           (*(int64 *)(lVar3 + 16) + 32 + (int64)(int)uVar1 * 8)
                                  ;
                                  if ((lVar3 != null) && (plVar8 != (int64 *)0)) {
                                    local_58 = *(uint64 *)(lVar3 + 24);
                                    uStack_50 = *(uint64 *)(lVar3 + 32);
                                    (**(code **)(*plVar8 + 0x2a8))
                                              (plVar8,&local_58,*(uint64 *)(*plVar8 + 0x2b0));
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

    // Token : 0x60017FE
    // RVA   : 0xB19230   Offset: 0xB18030   Length: 0x1C1
    public void RefreshHeroTagList(GameObject targetTagGrid)
    {
        var pStatics = *(int64*)(DAT_181e52a90 + 184);
        long lVar1;
        long lVar2;
        long lVar3;
        ulong uVar4;
        int iVar5;
        GlobalData.DeleteAllChild(targetTagGrid,0);
        lVar2 = this.nowShowHero;
        iVar5 = 0;
        if (lVar2 != null) {
          while (lVar2.heroTagData != null) {
            if (*(int *)(lVar2.heroTagData + 24) <= iVar5) {
              return;
            }
            if (*pStatics == 0) break;
            uVar4 = *(uint64 *)(*pStatics + 200);
            lVar2 = GlobalData.AddChild(targetTagGrid,uVar4,0);
            if (lVar2 == null) break;
            lVar3 = GameObject.GetComponent(lVar2,DAT_181e54db0);
            if (((this.nowShowHero == null) ||
                (lVar1 = this.nowShowHero.heroTagData) == null) ||
               (uVar4 = FUN_1800024b0(lVar1,iVar5), lVar3 == null)) break;
            *(uint64 *)(lVar3 + 32) = uVar4;
            lVar2 = GameObject.GetComponent(lVar2,DAT_181e54db0);
            if (lVar2 == null) break;
            iVar5 = iVar5 + 1;
            lVar2.summonSourceHero = 1;
            lVar2 = this.nowShowHero;
            if (lVar2 == null) break;
          }
        }
    }

    // Token : 0x60017FF
    // RVA   : 0xB154C0   Offset: 0xB142C0   Length: 0x83E
    public static void RefreshBuffGrid(GameObject targetBuffGrid, HeroData targetHero)
    {
        var pStatics = *(int64*)(DAT_181e538e8 + 184);
        ulong uVar1;
        bool cVar2;
        long lVar3;
        long lVar4;
        ulong uVar5;
        long lVar7;
        ulong uVar8;
        ulong uVar9;
        float fVar10;
        uint[] local_res8 = new uint[4];
        uint local_80;
        uint32 uStack_7c;
        uint32 uStack_78;
        uint32 uStack_74;
        uint64 local_70;
        uint32 local_68;
        uint32 uStack_64;
        uint32 uStack_60;
        uint32 uStack_5c;
        uint64 local_58;
        local_res8[0] = 0;
        GlobalData.DeleteAllChild(targetBuffGrid,0);
        if (((targetHero == null) || (*(int64 *)(targetHero + 0x2c0) == 0)) ||
           (lVar3 = HeroSpeAddData.GetKeys(*(int64 *)(targetHero + 0x2c0),0)) == null) {
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        FUN_18175fc30(&local_68,lVar3,DAT_181e71670);
        local_80 = local_68;
        uStack_7c = uStack_64;
        uStack_78 = uStack_60;
        uStack_74 = uStack_5c;
        local_70 = local_58;
        while( true ) {
          do {
            do {
              cVar2 = FUN_1807b40e0(&local_80,DAT_181e6f540);
              uVar1 = local_70;
              if (!cVar2) {
                ZhSegment.Initialize(&local_80,DAT_181e6f4c0);
                return;
              }
              lVar3 = FUN_180210740(0);
              if (lVar3 == null) {
                          // WARNING: Subroutine does not return
                FUN_1801e0300();
              }
              if (*(int64 *)(lVar3 + 144) == 0) {
                          // WARNING: Subroutine does not return
                FUN_1801e0300();
              }
              lVar3 = FUN_1800024b0(*(int64 *)(lVar3 + 144),uVar1 & 0xffffffff,DAT_181e6e1f0);
              if (lVar3 == null) {
                          // WARNING: Subroutine does not return
                FUN_1801e0300();
              }
            } while (*(int *)(lVar3 + 60) == 0);
            if (*(int64 *)(targetHero + 0x2c0) == 0) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            fVar10 = (float)HeroSpeAddData.Get(*(int64 *)(targetHero + 0x2c0),uVar1 & 0xffffffff,0);
          } while (fVar10 <= 0.0);
          lVar3 = FUN_1802101c0(0);
          if (lVar3 == null) {
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          uVar5 = *(uint64 *)(lVar3 + 0x158);
          lVar3 = GlobalData.AddChild(targetBuffGrid,uVar5,0);
          if (lVar3 == null) {
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          lVar4 = GameObject.get_transform(lVar3,0);
          if (lVar4 == null) {
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          lVar4 = Transform.Find(lVar4,"Text",0);
          if (lVar4 == null) {
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          uVar5 = Component.GetComponent(lVar4,DAT_181e79538);
          plVar6 = (int64 *)FUN_1801dfd90(DAT_181e85e38,5);
          lVar4 = FUN_180210740(0);
          if (lVar4 == null) {
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          if (*(int64 *)(lVar4 + 144) == 0) {
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          lVar4 = FUN_1800024b0(*(int64 *)(lVar4 + 144),uVar1 & 0xffffffff,DAT_181e6e1f0);
          if (lVar4 == null) break;
          if (*(char *)(lVar4 + 64) == false) {
            lVar4 = *(int64 *)(pStatics + 0x2d8);
          }
          else {
            lVar4 = *(int64 *)(pStatics + 0x270);
          }
          if (plVar6 == (int64 *)0) {
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          if ((lVar4 != null) &&
             (lVar7 = il2cpp_internal(lVar4,*(uint64 *)(*plVar6 + 64))) == null) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar5,0);
          }
          FUN_1800025b0(plVar6,0,lVar4);
          lVar4 = FUN_180210740(0);
          if (lVar4 == null) {
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          if (*(int64 *)(lVar4 + 144) == 0) {
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          lVar4 = FUN_1800024b0(*(int64 *)(lVar4 + 144),uVar1 & 0xffffffff,DAT_181e6e1f0);
          if (lVar4 == null) {
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          lVar4 = *(int64 *)(lVar4 + 16);
          if ((lVar4 != null) &&
             (lVar7 = il2cpp_internal(lVar4,*(uint64 *)(*plVar6 + 64))) == null) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar5,0);
          }
          if (*(uint32 *)(plVar6 + 3) < 2) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar5,0);
          }
          plVar6[5] = lVar4;
          il2cpp_internal(plVar6 + 5,lVar4);
          lVar4 = HeroData.GetBuffLevelString(targetHero,uVar1 & 0xffffffff,0);
          if ((lVar4 != null) &&
             (lVar7 = il2cpp_internal(lVar4,*(uint64 *)(*plVar6 + 64))) == null) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar5,0);
          }
          if (*(uint32 *)(plVar6 + 3) < 3) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar5,0);
          }
          plVar6[6] = lVar4;
          il2cpp_internal(plVar6 + 6,lVar4);
          if (*(int64 *)(targetHero + 0x2c0) == 0) {
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          fVar10 = (float)HeroSpeAddData.Get(*(int64 *)(targetHero + 0x2c0),uVar1 & 0xffffffff,0);
          lVar4 = "(永久)";
          if (fVar10 < 999.0) {
            lVar4 = FUN_180210740(0);
            if (lVar4 == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            if (*(int64 *)(lVar4 + 144) == 0) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            lVar4 = FUN_1800024b0(*(int64 *)(lVar4 + 144),uVar1 & 0xffffffff,DAT_181e6e1f0);
            if (lVar4 == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            uVar9 = "[{0}合]";
            if (*(int *)(lVar4 + 60) == -1) {
              uVar9 = "({0}秒)";
            }
            if (*(int64 *)(targetHero + 0x2c0) == 0) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            local_res8[0] = HeroSpeAddData.Get(*(int64 *)(targetHero + 0x2c0),uVar1 & 0xffffffff,0);
            uVar8 = Single.ToString(local_res8,"f0",0);
            lVar4 = String.Format(uVar9,uVar8,0);
          }
          if ((lVar4 != null) &&
             (lVar7 = il2cpp_internal(lVar4,*(uint64 *)(*plVar6 + 64))) == null) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar5,0);
          }
          FUN_1800025b0(plVar6,3,lVar4);
          if (("</color>" != 0) &&
             (lVar4 = il2cpp_internal("</color>",*(uint64 *)(*plVar6 + 64))) == null) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar5,0);
          }
          lVar4 = "</color>";
          if (*(uint32 *)(plVar6 + 3) < 5) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar5,0);
          }
          plVar6[8] = "</color>";
          il2cpp_internal(plVar6 + 8,lVar4);
          uVar9 = String.Concat(plVar6,0);
          LTLocalization.SetText(uVar5,uVar9,0);
          lVar3 = GameObject.GetComponent(lVar3,DAT_181e56510);
          lVar4 = FUN_180210740(0);
          if (lVar4 == null) {
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          if (*(int64 *)(lVar4 + 144) == 0) {
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          lVar4 = FUN_1800024b0(*(int64 *)(lVar4 + 144),uVar1 & 0xffffffff,DAT_181e6e1f0);
          if (lVar4 == null) {
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          if (lVar3 == null) {
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          *(uint64 *)(lVar3 + 24) = *(uint64 *)(lVar4 + 24);
        }
    }

    // Token : 0x6001800
    // RVA   : 0xB15450   Offset: 0xB14250   Length: 0x6C
    public static IEnumerator RefreshBuffGridPos(GameObject targetBuffGrid)
    {
        long lVar1;
        lVar1 = new WarpText_d__8(0,0);
        if (lVar1 != null) {
          *(uint64 *)(lVar1 + 32) = targetBuffGrid;
          return lVar1;
        }
    }

    // Token : 0x6001801
    // RVA   : 0xB19560   Offset: 0xB18360   Length: 0x1404
    public void RefreshLifeList(bool resetPos)
    {
        var pStatics = *(int64*)(DAT_181e538e8 + 184);
        long lVar1;
        bool cVar2;
        long lVar3;
        ulong uVar4;
        ulong uVar5;
        ulong uVar6;
        long lVar7;
        uint uVar8;
        long lVar9;
        uint uVar10;
        uint[] local_res8 = new uint[2];
        uint[] local_res20 = new uint[2];
        if ((((this.heroDetailPanel != null) &&
             (lVar3 = GameObject.get_transform(this.heroDetailPanel,0)) != null) &&
            (lVar3 = Transform.Find(lVar3,"Life",0)) != null) &&
           ((lVar3 = Transform.Find(lVar3,"Teacher",0), lVar3 != null &&
            (lVar3 = Transform.Find(lVar3,"Content",0)) != null))) {
          uVar4 = Component.get_gameObject(lVar3,0);
          GlobalData.DeleteAllChild(uVar4,0);
          if (((this.heroDetailPanel != null) &&
              (lVar3 = GameObject.get_transform(this.heroDetailPanel,0)) != null) &&
             ((lVar3 = Transform.Find(lVar3,"Life",0), lVar3 != null &&
              ((lVar3 = Transform.Find(lVar3,"Teacher",0), lVar3 != null &&
               (lVar3 = Transform.Find(lVar3,"Content",0)) != null))))) {
            uVar4 = Component.get_gameObject(lVar3,0);
            if (this.nowShowHero != null) {
              HeroDetailController.CreateLifeHeroIcon
                        (this,uVar4,this.nowShowHero.Teacher,0);
              if ((((this.heroDetailPanel != null) &&
                   (lVar3 = GameObject.get_transform(this.heroDetailPanel,0)) != null) &&
                  (lVar3 = Transform.Find(lVar3,"Life",0)) != null) &&
                 ((lVar3 = Transform.Find(lVar3,"Student",0), lVar3 != null &&
                  (lVar3 = Transform.Find(lVar3,"Num",0)) != null))) {
                uVar4 = Component.GetComponent(lVar3,DAT_181e79538);
                if (this.nowShowHero != null) {
                  cVar2 = HeroData.HaveForce(this.nowShowHero,0);
                  uVar5 = "";
                  if (!cVar2) {
                    if ((this.nowShowHero == null) ||
                       (lVar3 = this.nowShowHero.Students) == null) {
        LAB_180b1a947:
                          // WARNING: Subroutine does not return
                      FUN_1801e0300();
                    }
                    local_res8[0] = lVar3.summonLv;
                    uVar5 = il2cpp_value_box(DAT_181e60808,local_res8);
                    if (this.nowShowHero == null) goto LAB_180b1a947;
                    local_res20[0] = HeroData.GetMaxStudent(this.nowShowHero,0);
                    uVar6 = il2cpp_value_box(DAT_181e60808,local_res20);
                    uVar5 = String.Format("{0}/{1}",uVar5,uVar6,0);
                  }
                  LTLocalization.SetText(uVar4,uVar5,0);
                  if ((((this.heroDetailPanel != null) &&
                       (lVar3 = GameObject.get_transform(this.heroDetailPanel,0)) != null)
                      && (lVar3 = Transform.Find(lVar3,"Life",0)) != null) &&
                     (((lVar3 = Transform.Find(lVar3,"Student",0), lVar3 != null &&
                       (lVar3 = Transform.Find(lVar3,"Viewport",0)) != null) &&
                      (lVar3 = Transform.Find(lVar3,"Content",0)) != null))) {
                    uVar4 = Component.get_gameObject(lVar3,0);
                    GlobalData.DeleteAllChild(uVar4,0);
                    lVar3 = this.nowShowHero;
                    uVar10 = 0;
                    uVar8 = 0;
                    if (lVar3 != null) {
                      lVar9 = 32;
                      while (lVar3.Students != 0) {
                        lVar7 = this.heroDetailPanel;
                        if (*(int *)(lVar3.Students + 24) <= (int)uVar8) {
                          if ((((lVar7 != null) && (lVar3 = GameObject.get_transform(lVar7,0)) != null)
                              && (lVar3 = Transform.Find(lVar3,"Life",0)) != null) &&
                             ((lVar3 = Transform.Find(lVar3,"Lover",0), lVar3 != null &&
                              (lVar3 = Transform.Find(lVar3,"Content",0)) != null))) {
                            uVar4 = Component.get_gameObject(lVar3,0);
                            GlobalData.DeleteAllChild(uVar4,0);
                            if (((this.heroDetailPanel != null) &&
                                (lVar3 = GameObject.get_transform(this.heroDetailPanel,0),
                                lVar3 != null)) &&
                               ((lVar3 = Transform.Find(lVar3,"Life",0), lVar3 != null &&
                                ((lVar3 = Transform.Find(lVar3,"Lover",0), lVar3 != null &&
                                 (lVar3 = Transform.Find(lVar3,"Content",0)) != null))))) {
                              uVar4 = Component.get_gameObject(lVar3,0);
                              if (this.nowShowHero != null) {
                                HeroDetailController.CreateLifeHeroIcon
                                          (this,uVar4,
                                           this.nowShowHero.Lover,0);
                                if ((((this.heroDetailPanel != null) &&
                                     (lVar3 = GameObject.get_transform(this.heroDetailPanel,0),
                                     lVar3 != null)) &&
                                    (lVar3 = Transform.Find(lVar3,"Life",0)) != null) &&
                                   ((lVar3 = Transform.Find(lVar3,"Prelover",0), lVar3 != null &&
                                    (lVar3 = Transform.Find(lVar3,"Num",0)) != null))) {
                                  uVar4 = Component.GetComponent(lVar3,DAT_181e79538);
                                  if ((this.nowShowHero != null) &&
                                     (lVar3 = this.nowShowHero.PreLovers,
                                     lVar3 != null)) {
                                    local_res8[0] = lVar3.summonLv;
                                    uVar5 = il2cpp_value_box(DAT_181e60808,local_res8);
                                    local_res20[0] =
                                         *(uint32 *)(pStatics + 148);
                                    uVar6 = il2cpp_value_box(DAT_181e60808,local_res20);
                                    uVar5 = String.Format("{0}/{1}",uVar5,uVar6,0);
                                    LTLocalization.SetText(uVar4,uVar5,0);
                                    if ((((this.heroDetailPanel != null) &&
                                         (lVar3 = GameObject.get_transform
                                                            (this.heroDetailPanel,0), lVar3 != null)
                                         ) && (lVar3 = Transform.Find(lVar3,"Life",0)) != null
                                        ) && (((lVar3 = Transform.Find(lVar3,"Prelover",0), lVar3 != null
                                               && (lVar3 = Transform.Find(lVar3,"Viewport",0),
                                                  lVar3 != null)) &&
                                              (lVar3 = Transform.Find(lVar3,"Content",0)) != null
                                              ))) {
                                      uVar4 = Component.get_gameObject(lVar3,0);
                                      GlobalData.DeleteAllChild(uVar4,0);
                                      lVar3 = this.nowShowHero;
                                      uVar8 = 0;
                                      if (lVar3 != null) goto LAB_180b19e20;
                                      break;
                                    }
                                  }
                                }
                              }
                            }
                          }
                          // WARNING: Subroutine does not return
                          FUN_1801e0300();
                        }
                        if (((((lVar7 == null) || (lVar3 = GameObject.get_transform(lVar7,0)) == null)
                             || (lVar3 = Transform.Find(lVar3,"Life",0)) == null) ||
                            ((lVar3 = Transform.Find(lVar3,"Student",0), lVar3 == null ||
                             (lVar3 = Transform.Find(lVar3,"Viewport",0)) == null))) ||
                           (lVar3 = Transform.Find(lVar3,"Content",0)) == null) break;
                        uVar4 = Component.get_gameObject(lVar3,0);
                        if ((this.nowShowHero == null) ||
                           (lVar3 = this.nowShowHero.Students) == null)
                        break;
                        if (lVar3.summonLv <= uVar8) {
                          ThrowHelper.ThrowArgumentOutOfRangeException(0);
                        }
                        HeroDetailController.CreateLifeHeroIcon(this,uVar4);
                        lVar3 = this.nowShowHero;
                        uVar8 = uVar8 + 1;
                        if (lVar3 == null) break;
                      }
                    }
                  }
                }
              }
            }
          }
        }
        LAB_180b1a94d:
                          // WARNING: Subroutine does not return
        FUN_1801e0300();
        LAB_180b19e20:
        if (lVar3.PreLovers == null) goto LAB_180b1a94d;
        lVar7 = this.heroDetailPanel;
        if (*(int *)(lVar3.PreLovers + 24) <= (int)uVar8) {
          if (((lVar7 != null) && (lVar3 = GameObject.get_transform(lVar7,0)) != null) &&
             ((lVar3 = Transform.Find(lVar3,"Life",0), lVar3 != null &&
              ((lVar3 = Transform.Find(lVar3,"Brother",0), lVar3 != null &&
               (lVar3 = Transform.Find(lVar3,"Num",0)) != null))))) {
            uVar4 = Component.GetComponent(lVar3,DAT_181e79538);
            if ((this.nowShowHero != null) &&
               (lVar3 = this.nowShowHero.Brothers) != null) {
              local_res8[0] = lVar3.summonLv;
              uVar5 = il2cpp_value_box(DAT_181e60808,local_res8);
              local_res20[0] = *(uint32 *)(pStatics + 152);
              uVar6 = il2cpp_value_box(DAT_181e60808,local_res20);
              uVar5 = String.Format("{0}/{1}",uVar5,uVar6,0);
              LTLocalization.SetText(uVar4,uVar5,0);
              if (((((this.heroDetailPanel != null) &&
                    (lVar3 = GameObject.get_transform(this.heroDetailPanel,0)) != null) &&
                   (lVar3 = Transform.Find(lVar3,"Life",0)) != null) &&
                  ((lVar3 = Transform.Find(lVar3,"Brother",0), lVar3 != null &&
                   (lVar3 = Transform.Find(lVar3,"Viewport",0)) != null))) &&
                 (lVar3 = Transform.Find(lVar3,"Content",0)) != null) {
                uVar4 = Component.get_gameObject(lVar3,0);
                GlobalData.DeleteAllChild(uVar4,0);
                lVar3 = this.nowShowHero;
                uVar8 = 0;
                if (lVar3 != null) goto LAB_180b1a120;
                goto LAB_180b1a94d;
              }
            }
          }
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        if ((((lVar7 == null) || (lVar3 = GameObject.get_transform(lVar7,0)) == null) ||
            (lVar3 = Transform.Find(lVar3,"Life",0)) == null) ||
           (((lVar3 = Transform.Find(lVar3,"Prelover",0), lVar3 == null ||
             (lVar3 = Transform.Find(lVar3,"Viewport",0)) == null) ||
            (lVar3 = Transform.Find(lVar3,"Content",0)) == null))) goto LAB_180b1a94d;
        uVar4 = Component.get_gameObject(lVar3,0);
        if ((this.nowShowHero == null) ||
           (lVar3 = this.nowShowHero.PreLovers) == null) goto LAB_180b1a94d;
        if (lVar3.summonLv <= uVar8) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        HeroDetailController.CreateLifeHeroIcon(this,uVar4);
        lVar3 = this.nowShowHero;
        uVar8 = uVar8 + 1;
        if (lVar3 == null) goto LAB_180b1a94d;
        goto LAB_180b19e20;
        LAB_180b1a120:
        if (lVar3.Brothers == null) goto LAB_180b1a94d;
        lVar7 = this.heroDetailPanel;
        if (*(int *)(lVar3.Brothers + 24) <= (int)uVar8) {
          if (((lVar7 != null) && (lVar3 = GameObject.get_transform(lVar7,0)) != null) &&
             ((lVar3 = Transform.Find(lVar3,"Life",0), lVar3 != null &&
              ((lVar3 = Transform.Find(lVar3,"Friend",0), lVar3 != null &&
               (lVar3 = Transform.Find(lVar3,"Num",0)) != null))))) {
            uVar4 = Component.GetComponent(lVar3,DAT_181e79538);
            if ((this.nowShowHero != null) &&
               (lVar3 = this.nowShowHero.Friends) != null) {
              local_res8[0] = lVar3.summonLv;
              uVar5 = il2cpp_value_box(DAT_181e60808,local_res8);
              local_res20[0] = *(uint32 *)(pStatics + 144);
              uVar6 = il2cpp_value_box(DAT_181e60808,local_res20);
              uVar5 = String.Format("{0}/{1}",uVar5,uVar6,0);
              LTLocalization.SetText(uVar4,uVar5,0);
              if ((((this.heroDetailPanel != null) &&
                   (lVar3 = GameObject.get_transform(this.heroDetailPanel,0)) != null) &&
                  (lVar3 = Transform.Find(lVar3,"Life",0)) != null) &&
                 (((lVar3 = Transform.Find(lVar3,"Friend",0), lVar3 != null &&
                   (lVar3 = Transform.Find(lVar3,"Viewport",0)) != null) &&
                  (lVar3 = Transform.Find(lVar3,"Content",0)) != null))) {
                uVar4 = Component.get_gameObject(lVar3,0);
                GlobalData.DeleteAllChild(uVar4,0);
                lVar3 = this.nowShowHero;
                uVar8 = 0;
                if (lVar3 != null) {
                  lVar7 = 32;
                  goto LAB_180b1a420;
                }
                goto LAB_180b1a94d;
              }
            }
          }
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        if (((((lVar7 == null) || (lVar3 = GameObject.get_transform(lVar7,0)) == null) ||
             (lVar3 = Transform.Find(lVar3,"Life",0)) == null) ||
            ((lVar3 = Transform.Find(lVar3,"Brother",0), lVar3 == null ||
             (lVar3 = Transform.Find(lVar3,"Viewport",0)) == null))) ||
           (lVar3 = Transform.Find(lVar3,"Content",0)) == null) goto LAB_180b1a94d;
        uVar4 = Component.get_gameObject(lVar3,0);
        if ((this.nowShowHero == null) ||
           (lVar3 = this.nowShowHero.Brothers) == null) goto LAB_180b1a94d;
        if (lVar3.summonLv <= uVar8) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        HeroDetailController.CreateLifeHeroIcon(this,uVar4);
        lVar3 = this.nowShowHero;
        uVar8 = uVar8 + 1;
        if (lVar3 == null) goto LAB_180b1a94d;
        goto LAB_180b1a120;
        LAB_180b1a420:
        if (lVar3.Friends == null) goto LAB_180b1a94d;
        lVar1 = this.heroDetailPanel;
        if (*(int *)(lVar3.Friends + 24) <= (int)uVar8) {
          if (((lVar1 != null) && (lVar3 = GameObject.get_transform(lVar1,0)) != null) &&
             ((lVar3 = Transform.Find(lVar3,"Life",0), lVar3 != null &&
              (((lVar3 = Transform.Find(lVar3,"Hater",0), lVar3 != null &&
                (lVar3 = Transform.Find(lVar3,"Viewport",0)) != null) &&
               (lVar3 = Transform.Find(lVar3,"Content",0)) != null))))) {
            uVar4 = Component.get_gameObject(lVar3,0);
            GlobalData.DeleteAllChild(uVar4,0);
            lVar3 = this.nowShowHero;
            if (lVar3 != null) goto LAB_180b1a600;
          }
          goto LAB_180b1a94d;
        }
        if ((((lVar1 == null) || (lVar3 = GameObject.get_transform(lVar1,0)) == null) ||
            (lVar3 = Transform.Find(lVar3,"Life",0)) == null) ||
           (((lVar3 = Transform.Find(lVar3,"Friend",0), lVar3 == null ||
             (lVar3 = Transform.Find(lVar3,"Viewport",0)) == null) ||
            (lVar3 = Transform.Find(lVar3,"Content",0)) == null))) goto LAB_180b1a94d;
        uVar4 = Component.get_gameObject(lVar3,0);
        if ((this.nowShowHero == null) ||
           (lVar3 = this.nowShowHero.Friends) == null) goto LAB_180b1a94d;
        if (lVar3.summonLv <= uVar8) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        HeroDetailController.CreateLifeHeroIcon
                  (this,uVar4,*(uint32 *)(lVar3.isSummon + lVar7),0);
        lVar3 = this.nowShowHero;
        uVar8 = uVar8 + 1;
        lVar7 = lVar7 + 4;
        if (lVar3 == null) goto LAB_180b1a94d;
        goto LAB_180b1a420;
        LAB_180b1a600:
        if (lVar3.Haters == null) goto LAB_180b1a94d;
        if (*(int *)(lVar3.Haters + 24) <= (int)uVar10) {
          if (resetPos) {
            if (((this.heroDetailPanel == null) ||
                (lVar3 = GameObject.get_transform(this.heroDetailPanel,0)) == null) ||
               ((lVar3 = Transform.Find(lVar3,"Life",0), lVar3 == null ||
                (((lVar3 = Transform.Find(lVar3,"Student",0), lVar3 == null ||
                  (lVar3 = Component.GetComponent(lVar3,DAT_181e78538)) == null) ||
                 (lVar3.heroAIData == null)))))) goto LAB_180b1a94d;
            Scrollbar.set_value(lVar3.heroAIData,0x3f800000,0);
            if (((this.heroDetailPanel == null) ||
                (lVar3 = GameObject.get_transform(this.heroDetailPanel,0)) == null) ||
               ((lVar3 = Transform.Find(lVar3,"Life",0), lVar3 == null ||
                (((lVar3 = Transform.Find(lVar3,"Brother",0), lVar3 == null ||
                  (lVar3 = Component.GetComponent(lVar3,DAT_181e78538)) == null) ||
                 (lVar3.heroAIData == null)))))) goto LAB_180b1a94d;
            Scrollbar.set_value(lVar3.heroAIData,0x3f800000,0);
            if (((((this.heroDetailPanel == null) ||
                  (lVar3 = GameObject.get_transform(this.heroDetailPanel,0)) == null) ||
                 (lVar3 = Transform.Find(lVar3,"Life",0)) == null) ||
                ((lVar3 = Transform.Find(lVar3,"Friend",0), lVar3 == null ||
                 (lVar3 = Component.GetComponent(lVar3,DAT_181e78538)) == null))) ||
               (lVar3.heroAIData == null)) goto LAB_180b1a94d;
            Scrollbar.set_value(lVar3.heroAIData,0x3f800000,0);
            if (((this.heroDetailPanel == null) ||
                (lVar3 = GameObject.get_transform(this.heroDetailPanel,0)) == null) ||
               ((lVar3 = Transform.Find(lVar3,"Life",0), lVar3 == null ||
                (((lVar3 = Transform.Find(lVar3,"Hater",0), lVar3 == null ||
                  (lVar3 = Component.GetComponent(lVar3,DAT_181e78538)) == null) ||
                 (lVar3.heroAIData == null)))))) goto LAB_180b1a94d;
            Scrollbar.set_value(lVar3.heroAIData,0x3f800000,0);
          }
          return;
        }
        if (((this.heroDetailPanel == null) ||
            (lVar3 = GameObject.get_transform(this.heroDetailPanel,0)) == null) ||
           (((lVar3 = Transform.Find(lVar3,"Life",0), lVar3 == null ||
             ((lVar3 = Transform.Find(lVar3,"Hater",0), lVar3 == null ||
              (lVar3 = Transform.Find(lVar3,"Viewport",0)) == null))) ||
            (lVar3 = Transform.Find(lVar3,"Content",0)) == null))) goto LAB_180b1a94d;
        uVar4 = Component.get_gameObject(lVar3,0);
        if ((this.nowShowHero == null) ||
           (lVar3 = this.nowShowHero.Haters) == null) goto LAB_180b1a94d;
        if (lVar3.summonLv <= uVar10) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        HeroDetailController.CreateLifeHeroIcon
                  (this,uVar4,*(uint32 *)(lVar3.isSummon + lVar9),0);
        lVar3 = this.nowShowHero;
        uVar10 = uVar10 + 1;
        lVar9 = lVar9 + 4;
        if (lVar3 == null) goto LAB_180b1a94d;
        goto LAB_180b1a600;
    }

    // Token : 0x6001802
    // RVA   : 0xB0B890   Offset: 0xB0A690   Length: 0x1F4
    public void CreateLifeHeroIcon(GameObject targetObj, int heroID)
    {
        var pStatics_2a90 = *(int64*)(DAT_181e52a90 + 184);
        long lVar1;
        ulong uVar2;
        long lVar3;
        if (heroID == -1) {
          return;
        }
        if (*pStatics_2a90 != 0) {
          uVar2 = *(uint64 *)(*pStatics_2a90 + 144);
          uVar2 = GlobalData.AddChild(targetObj,uVar2,0);
          this.temp = uVar2;
          if (this.temp != null) {
            lVar3 = GameObject.GetComponent(this.temp,DAT_181e54c18);
            if (((GameController._instance != null) &&
                (lVar1 = GameController._instance.worldData) != null) &&
               (uVar2 = WorldData.GetHero(lVar1,heroID,0), lVar3 != null)) {
              *(uint64 *)(lVar3 + 32) = uVar2;
              if ((this.temp != null) &&
                 (lVar3 = GameObject.GetComponent(this.temp,DAT_181e54c18),
                 lVar3 != null)) {
                *(uint32 *)(lVar3 + 24) = 0;
                if ((this.temp != null) &&
                   (lVar3 = GameObject.GetComponent(this.temp,DAT_181e54c18),
                   lVar3 != null)) {
                  HeroIconController.AutoSetName(lVar3,0);
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x6001803
    // RVA   : 0xB18BD0   Offset: 0xB179D0   Length: 0x5C3
    public void RefreshForceContributionInfoData()
    {
        bool cVar1;
        long lVar2;
        ulong uVar4;
        long lVar5;
        float fVar7;
        uint uVar8;
        uint uVar9;
        uint uVar10;
        uint uVar11;
        int[] local_res8 = new int[2];
        uint local_58;
        uint uStack_54;
        uint uStack_50;
        uint32 uStack_4c;
        uint32 local_48;
        uint32 uStack_44;
        uint32 uStack_40;
        uint32 uStack_3c;
        int64 local_38;
        uint32 local_30;
        uint32 uStack_2c;
        uint32 uStack_28;
        uint32 uStack_24;
        int64 local_20;
        if (this.heroDetailPanel != null) {
          lVar2 = GameObject.get_transform(this.heroDetailPanel,0);
          if (lVar2 != null) {
            lVar2 = Transform.Find(lVar2,"ForceContribution",0);
            if (lVar2 != null) {
              lVar2 = Transform.Find(lVar2,"Viewport",0);
              if (lVar2 != null) {
                lVar2 = Transform.Find(lVar2,"Content",0);
                if (lVar2 != null) {
                  lVar2 = Transform.Find(lVar2,"-1",0);
                  if (lVar2 != null) {
                    lVar2 = Transform.Find(lVar2,"Num",0);
                    if (lVar2 != null) {
                      plVar3 = (int64 *)Component.GetComponent(lVar2,DAT_181e79538);
                      if (this.nowShowHero != null) {
                        local_res8[0] = (int)this.nowShowHero.governContribution;
                        uVar4 = Int32.ToString(local_res8,0);
                        if (plVar3 != (int64 *)0) {
                          (**(code **)(*plVar3 + 0x5e8))(plVar3,uVar4,*(uint64 *)(*plVar3 + 0x5f0));
                          if (((GameController._instance != null) &&
                              (lVar2 = GameController._instance.worldData,
                              lVar2 != null)) && (lVar2 = lVar2.Forces) != null) {
                            FUN_1816629a0(&local_48,lVar2,DAT_181e6a378);
                            local_30 = local_48;
                            uStack_2c = uStack_44;
                            uStack_28 = uStack_40;
                            uStack_24 = uStack_3c;
                            local_20 = local_38;
                            while( true ) {
                              cVar1 = FUN_1807b3f30(&local_30,DAT_181e6e0c0);
                              lVar2 = local_20;
                              if (!cVar1) {
                                ZhSegment.Initialize(&local_30,DAT_181e6e040);
                                return;
                              }
                              if (this.heroDetailPanel == null) {
                          // WARNING: Subroutine does not return
                                FUN_1801e0300();
                              }
                              lVar5 = GameObject.get_transform(this.heroDetailPanel,0);
                              if (lVar5 == null) {
                          // WARNING: Subroutine does not return
                                FUN_1801e0300();
                              }
                              lVar5 = Transform.Find(lVar5,"ForceContribution",0);
                              if (lVar5 == null) {
                          // WARNING: Subroutine does not return
                                FUN_1801e0300();
                              }
                              lVar5 = Transform.Find(lVar5,"Viewport",0);
                              if (lVar5 == null) {
                          // WARNING: Subroutine does not return
                                FUN_1801e0300();
                              }
                              lVar5 = Transform.Find(lVar5,"Content",0);
                              if (lVar2 == null) {
                          // WARNING: Subroutine does not return
                                FUN_1801e0300();
                              }
                              uVar4 = Int32.ToString(lVar2 + 16,0);
                              if (lVar5 == null) {
                          // WARNING: Subroutine does not return
                                FUN_1801e0300();
                              }
                              lVar5 = Transform.Find(lVar5,uVar4,0);
                              if (lVar5 == null) {
                          // WARNING: Subroutine does not return
                                FUN_1801e0300();
                              }
                              lVar5 = Transform.Find(lVar5,"Num",0);
                              if (lVar5 == null) {
                          // WARNING: Subroutine does not return
                                FUN_1801e0300();
                              }
                              plVar3 = (int64 *)Component.GetComponent(lVar5,DAT_181e79538);
                              lVar5 = this.nowShowHero;
                              if (lVar5 == null) {
                          // WARNING: Subroutine does not return
                                FUN_1801e0300();
                              }
                              if (lVar5.belongForceID == lVar2.chapter) {
                                fVar7 = lVar5.forceContribution;
                              }
                              else {
                                fVar7 = lVar2.skinUnlockData;
                              }
                              local_res8[0] = (int)fVar7;
                              uVar4 = Int32.ToString(local_res8,0);
                              if (plVar3 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                                FUN_1801e0300();
                              }
                              (**(code **)(*plVar3 + 0x5e8))
                                        (plVar3,uVar4,*(uint64 *)(*plVar3 + 0x5f0));
                              if (this.heroDetailPanel == null) {
                          // WARNING: Subroutine does not return
                                FUN_1801e0300();
                              }
                              lVar5 = GameObject.get_transform(this.heroDetailPanel,0);
                              if (lVar5 == null) {
                          // WARNING: Subroutine does not return
                                FUN_1801e0300();
                              }
                              lVar5 = Transform.Find(lVar5,"ForceContribution",0);
                              if (lVar5 == null) {
                          // WARNING: Subroutine does not return
                                FUN_1801e0300();
                              }
                              lVar5 = Transform.Find(lVar5,"Viewport",0);
                              if (lVar5 == null) {
                          // WARNING: Subroutine does not return
                                FUN_1801e0300();
                              }
                              lVar5 = Transform.Find(lVar5,"Content",0);
                              uVar4 = Int32.ToString(lVar2 + 16,0);
                              if (lVar5 == null) {
                          // WARNING: Subroutine does not return
                                FUN_1801e0300();
                              }
                              lVar5 = Transform.Find(lVar5,uVar4,0);
                              if (lVar5 == null) break;
                              lVar5 = Transform.Find(lVar5,"ForceName",0);
                              if (lVar5 == null) {
                          // WARNING: Subroutine does not return
                                FUN_1801e0300();
                              }
                              plVar3 = (int64 *)Component.GetComponent(lVar5,DAT_181e79538);
                              if (this.nowShowHero == null) {
                          // WARNING: Subroutine does not return
                                FUN_1801e0300();
                              }
                              if (this.nowShowHero.belongForceID == lVar2.chapter
                                 ) {
                                lVar2 = *(int64 *)(DAT_181e538e8 + 184);
                                uVar8 = lVar2.resourcePointDict;
                                uVar9 = *(uint32 *)(lVar2 + 0x2a4);
                                uVar10 = lVar2.innDict;
                                uVar11 = *(uint32 *)(lVar2 + 0x2ac);
                              }
                              else {
                                puVar6 = (uint32 *)Color.get_black(&local_48,0);
                                uVar8 = *puVar6;
                                uVar9 = puVar6[1];
                                uVar10 = puVar6[2];
                                uVar11 = puVar6[3];
                              }
                              if (plVar3 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                                FUN_1801e0300();
                              }
                              local_58 = uVar8;
                              uStack_54 = uVar9;
                              uStack_50 = uVar10;
                              uStack_4c = uVar11;
                              (**(code **)(*plVar3 + 0x2a8))(plVar3,&local_58);
                            }
                          // WARNING: Subroutine does not return
                            FUN_1801e0300();
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

    // Token : 0x6001804
    // RVA   : 0xB17C00   Offset: 0xB16A00   Length: 0xFCD
    public void RefreshFightData()
    {
        var pStatics = *(int64*)(DAT_181e538e8 + 184);
        ulong uVar1;
        ulong uVar2;
        bool cVar3;
        int iVar4;
        int iVar5;
        long lVar6;
        ulong uVar7;
        ulong uVar8;
        ulong uVar9;
        long lVar10;
        int iVar11;
        int iVar12;
        float fVar13;
        float[] local_res18 = new float[2];
        int local_res20;
        int aiStack_ac [7];
        uint64 local_90;
        uint64 uStack_88;
        uint64 local_80;
        uint32 local_78;
        uint32 uStack_74;
        uint32 uStack_70;
        uint32 uStack_6c;
        uint64 local_68;
        local_90 = 0;
        uStack_88 = 0;
        local_80 = 0;
        local_res18[0] = 0.0;
        iVar12 = 0;
        aiStack_ac[2] = 0;
        if (((((this.heroDetailPanel != null) &&
              (lVar6 = GameObject.get_transform(this.heroDetailPanel,0)) != null) &&
             (lVar6 = Transform.Find(lVar6,"DetailInfo",0)) != null) &&
            ((lVar6 = Transform.Find(lVar6,"Viewport",0), lVar6 != null &&
             (lVar6 = Transform.Find(lVar6,"Content",0)) != null))) &&
           (lVar6 = Transform.Find(lVar6,"BaseFightData",0)) != null) {
          iVar4 = Transform.get_childCount(lVar6,0);
          iVar5 = iVar12;
          iVar11 = iVar12;
          if (iVar4 == 0) {
            while( true ) {
              uVar7 = DAT_181e998a0;
              uVar7 = Type.GetTypeFromHandle(uVar7,0);
              lVar6 = Enum.GetNames(uVar7,0);
              if (lVar6 == null) break;
              if (*(int *)(lVar6 + 24) <= iVar5) goto LAB_180b17fb1;
              if ((((this.heroDetailPanel == null) ||
                   (lVar6 = GameObject.get_transform(this.heroDetailPanel,0)) == null) ||
                  (lVar6 = Transform.Find(lVar6,"DetailInfo",0)) == null) ||
                 (((lVar6 = Transform.Find(lVar6,"Viewport",0), lVar6 == null ||
                   (lVar6 = Transform.Find(lVar6,"Content",0)) == null) ||
                  (lVar6 = Transform.Find(lVar6,"BaseFightData",0)) == null))) break;
              uVar8 = Component.get_gameObject(lVar6,0);
              uVar7 = this.heroBaseFightDataPrefab;
              uVar7 = GlobalData.AddChild(uVar8,uVar7);
              this.temp = uVar7;
              if ((this.temp == null) || (lVar6 = GameObject.GetComponent()) == null
                 ) break;
              *(int *)(lVar6 + 24) = iVar5;
              iVar5 = iVar5 + 1;
            }
          }
          else {
        LAB_180b17fb1:
            uVar7 = DAT_181e998a0;
            uVar7 = Type.GetTypeFromHandle(uVar7,0);
            lVar6 = Enum.GetNames(uVar7,0);
            if (lVar6 == null) throw; // [null/range check failed]
            if (iVar11 < *(int *)(lVar6 + 24)) {
              if ((((this.heroDetailPanel == null) ||
                   (lVar6 = GameObject.get_transform(this.heroDetailPanel,0)) == null) ||
                  (lVar6 = Transform.Find(lVar6,"DetailInfo",0)) == null) ||
                 (((lVar6 = Transform.Find(lVar6,"Viewport",0), lVar6 == null ||
                   (lVar6 = Transform.Find(lVar6,"Content",0)) == null) ||
                  ((lVar6 = Transform.Find(lVar6,"BaseFightData",0), lVar6 == null ||
                   (lVar6 = Transform.GetChild(lVar6,iVar11)) == null))))) throw; // [null/range check failed]
              uVar7 = Component.get_gameObject(lVar6,0);
              this.temp = uVar7;
              if (this.temp == null) throw; // [null/range check failed]
              lVar6 = GameObject.GetComponent(this.temp,DAT_181e549f8);
              if (lVar6 == null) throw; // [null/range check failed]
              *(uint64 *)(lVar6 + 32) = this.nowShowHero;
              if ((this.temp == null) || (lVar6 = GameObject.GetComponent()) == null
                 ) throw; // [null/range check failed]
              HeroBaseFightDataController.RefreshData(lVar6);
              iVar11 = iVar11 + 1;
              goto LAB_180b17fb1;
            }
            local_res20 = 0;
            if ((((this.nowShowHero == null) ||
                 (lVar6 = this.nowShowHero.totalAddData) == null) ||
                (lVar6 = *(int64 *)(lVar6 + 16)) == null) ||
               (lVar6 = Dictionary_2.get_Keys(lVar6,DAT_181e9fd50)) == null) throw; // [null/range check failed]
            FUN_180b274e0(&local_78,lVar6,DAT_181ea5920);
            local_90 = CONCAT44(uStack_74,local_78);
            uStack_88 = CONCAT44(uStack_6c,uStack_70);
            local_80 = local_68;
            while (cVar3 = FUN_180dd6f80(&local_90,DAT_181e7d130), uVar2 = local_80, cVar3) {
              if (((int)local_80 - 0xfU < 9) || (77 < (int)local_80)) {
                if (this.heroDetailPanel == null) {
                          // WARNING: Subroutine does not return
                  FUN_1801e0300();
                }
                lVar6 = GameObject.get_transform(this.heroDetailPanel,0);
                if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1801e0300();
                }
                lVar6 = Transform.Find(lVar6,"DetailInfo",0);
                if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1801e0300();
                }
                lVar6 = Transform.Find(lVar6,"Viewport",0);
                if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1801e0300();
                }
                lVar6 = Transform.Find(lVar6,"Content",0);
                if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1801e0300();
                }
                lVar6 = Transform.Find(lVar6,"ExtraFightData",0);
                if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1801e0300();
                }
                iVar5 = Transform.get_childCount(lVar6,0);
                lVar6 = this.heroDetailPanel;
                if (iVar12 < iVar5) {
                  if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1801e0300();
                  }
                  lVar6 = GameObject.get_transform(lVar6,0);
                  if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1801e0300();
                  }
                  lVar6 = Transform.Find(lVar6,"DetailInfo",0);
                  if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1801e0300();
                  }
                  lVar6 = Transform.Find(lVar6,"Viewport",0);
                  if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1801e0300();
                  }
                  lVar6 = Transform.Find(lVar6,"Content",0);
                  if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1801e0300();
                  }
                  lVar6 = Transform.Find(lVar6,"ExtraFightData",0);
                  if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1801e0300();
                  }
                  lVar6 = Transform.GetChild(lVar6,iVar12,0);
                  if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1801e0300();
                  }
                  uVar7 = Component.get_gameObject(lVar6,0);
                  this.temp = uVar7;
                }
                else {
                  if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1801e0300();
                  }
                  lVar6 = GameObject.get_transform(lVar6,0);
                  if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1801e0300();
                  }
                  lVar6 = Transform.Find(lVar6,"DetailInfo",0);
                  if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1801e0300();
                  }
                  lVar6 = Transform.Find(lVar6,"Viewport",0);
                  if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1801e0300();
                  }
                  lVar6 = Transform.Find(lVar6,"Content",0);
                  if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1801e0300();
                  }
                  lVar6 = Transform.Find(lVar6,"ExtraFightData",0);
                  if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1801e0300();
                  }
                  uVar8 = Component.get_gameObject(lVar6,0);
                  uVar7 = this.heroExtraFightDataPrefab;
                  uVar7 = GlobalData.AddChild(uVar8,uVar7,0);
                  this.temp = uVar7;
                }
                if (this.temp == null) {
                          // WARNING: Subroutine does not return
                  FUN_1801e0300();
                }
                lVar6 = GameObject.get_transform(this.temp,0);
                if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1801e0300();
                }
                lVar6 = Transform.Find(lVar6,"Text",0);
                if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1801e0300();
                }
                uVar7 = Component.GetComponent(lVar6,DAT_181e79538);
                if (this.nowShowHero == null) {
                          // WARNING: Subroutine does not return
                  FUN_1801e0300();
                }
                lVar6 = this.nowShowHero.totalAddData;
                if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1801e0300();
                }
                lVar6 = *(int64 *)(lVar6 + 16);
                if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1801e0300();
                }
                fVar13 = (float)FUN_18171b3b0(lVar6,uVar2 & 0xffffffff,DAT_181e9fcc8);
                if (fVar13 <= 0.0) {
                  uVar8 = *(uint64 *)(pStatics + 0x2d8);
                }
                else {
                  uVar8 = *(uint64 *)(pStatics + 0x270);
                }
                lVar6 = *(int64 *)(*(int64 *)(DAT_181e528f8 + 184) + 32);
                if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1801e0300();
                }
                lVar6 = *(int64 *)(lVar6 + 144);
                if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1801e0300();
                }
                lVar6 = FUN_1800024b0(lVar6,uVar2 & 0xffffffff,DAT_181e6e1f0);
                if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1801e0300();
                }
                uVar1 = *(uint64 *)(lVar6 + 16);
                lVar6 = FUN_180210740(0);
                if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1801e0300();
                }
                if (*(int64 *)(lVar6 + 144) == 0) {
                          // WARNING: Subroutine does not return
                  FUN_1801e0300();
                }
                lVar6 = FUN_1800024b0(*(int64 *)(lVar6 + 144),uVar2 & 0xffffffff,DAT_181e6e1f0);
                if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1801e0300();
                }
                lVar10 = this.nowShowHero;
                if (*(char *)(lVar6 + 56) == false) {
                  if (lVar10 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1801e0300();
                  }
                  if (lVar10.totalAddData == null) {
                          // WARNING: Subroutine does not return
                    FUN_1801e0300();
                  }
                  lVar6 = *(int64 *)(lVar10.totalAddData + 16);
                  if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1801e0300();
                  }
                  local_res18[0] = (float)FUN_18171b3b0(lVar6,uVar2 & 0xffffffff,DAT_181e9fcc8);
                  uVar9 = Single.ToString(local_res18,"+0.##;-0.##;0",0);
                }
                else {
                  if (lVar10 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1801e0300();
                  }
                  if (lVar10.totalAddData == null) {
                          // WARNING: Subroutine does not return
                    FUN_1801e0300();
                  }
                  lVar6 = *(int64 *)(lVar10.totalAddData + 16);
                  if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1801e0300();
                  }
                  local_res18[0] = (float)FUN_18171b3b0(lVar6,uVar2 & 0xffffffff,DAT_181e9fcc8);
                  local_res18[0] = local_res18[0] * 100.0;
                  uVar9 = Single.ToString(local_res18,"+0.##;-0.##;0",0);
                  uVar9 = String.Concat(uVar9,"%",0);
                }
                uVar8 = String.Concat(uVar8,uVar1,uVar9,"</color>",0);
                LTLocalization.SetText(uVar7,uVar8,0);
                lVar6 = FUN_180210740(0);
                if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1801e0300();
                }
                if (*(int64 *)(lVar6 + 144) == 0) {
                          // WARNING: Subroutine does not return
                  FUN_1801e0300();
                }
                lVar6 = FUN_1800024b0(*(int64 *)(lVar6 + 144),uVar2 & 0xffffffff);
                if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1801e0300();
                }
                lVar10 = this.temp;
                if (*(char *)(lVar6 + 89) == false) {
                  if (lVar10 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1801e0300();
                  }
                  lVar6 = GameObject.GetComponent(lVar10,DAT_181e56510);
                  if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1801e0300();
                  }
                  *(uint64 *)(lVar6 + 24) = "";
                  local_res20 = iVar12 + 1;
                  iVar12 = local_res20;
                }
                else {
                  if (lVar10 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1801e0300();
                  }
                  lVar6 = GameObject.GetComponent(lVar10,DAT_181e56510);
                  lVar10 = FUN_180210740(0);
                  if (lVar10 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1801e0300();
                  }
                  if (lVar10.forceJobType == null) {
                          // WARNING: Subroutine does not return
                    FUN_1801e0300();
                  }
                  lVar10 = FUN_1800024b0(lVar10.forceJobType,uVar2 & 0xffffffff);
                  if (lVar10 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1801e0300();
                  }
                  uVar7 = HeroSpeAddDataBase.GetDescribe(lVar10,0);
                  if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1801e0300();
                  }
                  *(uint64 *)(lVar6 + 24) = uVar7;
                  local_res20 = iVar12 + 1;
                  iVar12 = local_res20;
                }
              }
            }
            aiStack_ac[1] = 0x414;
            iVar5 = aiStack_ac[2] + 1;
            aiStack_ac[2] = iVar5;
            ZhSegment.Initialize(&local_90,DAT_181e7d0b0);
            if ((iVar5 != 0) && (aiStack_ac[iVar5] == 0x414)) goto LAB_180b18a24;
            while ((((this.heroDetailPanel != null &&
                     ((lVar6 = GameObject.get_transform(this.heroDetailPanel,0), lVar6 != null &&
                      (lVar6 = Transform.Find(lVar6,"DetailInfo",0)) != null))) &&
                    (lVar6 = Transform.Find(lVar6,"Viewport",0)) != null) &&
                   (lVar6 = Transform.Find(lVar6,"Content",0)) != null)) {
              lVar6 = Transform.Find(lVar6,"ExtraFightData",0);
              if ((((this.heroDetailPanel == null) ||
                   (lVar10 = GameObject.get_transform(this.heroDetailPanel,0)) == null) ||
                  (lVar10 = Transform.Find(lVar10,"DetailInfo",0)) == null) ||
                 (((lVar10 = Transform.Find(lVar10,"Viewport",0), lVar10 == null ||
                   (lVar10 = Transform.Find(lVar10,"Content",0)) == null) ||
                  ((lVar10 = Transform.Find(lVar10,"ExtraFightData",0), lVar10 == null ||
                   ((iVar5 = Transform.get_childCount(lVar10,0), lVar6 == null ||
                    (lVar6 = Transform.GetChild(lVar6,iVar5 + -1)) == null))))))) break;
              uVar7 = Component.get_gameObject(lVar6,0);
              Object.DestroyImmediate(uVar7,0);
        LAB_180b18a24:
              if (((((this.heroDetailPanel == null) ||
                    (lVar6 = GameObject.get_transform(this.heroDetailPanel,0)) == null) ||
                   (lVar6 = Transform.Find(lVar6,"DetailInfo",0)) == null) ||
                  ((lVar6 = Transform.Find(lVar6,"Viewport",0), lVar6 == null ||
                   (lVar6 = Transform.Find(lVar6,"Content",0)) == null))) ||
                 (lVar6 = Transform.Find(lVar6,"ExtraFightData",0)) == null) break;
              iVar5 = Transform.get_childCount(lVar6);
              if (iVar5 <= iVar12) {
                return;
              }
            }
          }
        }
    }

    // Token : 0x6001805
    // RVA   : 0xB1A970   Offset: 0xB19770   Length: 0x208B
    public void RefreshSkillEquipList(bool resetPos)
    {
        float fVar1;
        bool cVar2;
        byte uVar3;
        long lVar4;
        ulong uVar5;
        long lVar8;
        int iVar9;
        int iVar10;
        int[] local_res8 = new int[2];
        ulong local_78;
        ulong local_68;
        float local_60;
        uint local_48;
        uint uStack_44;
        uint uStack_40;
        uint32 uStack_3c;
        iVar10 = 0;
        local_res8[0] = 0;
        fVar1 = local_60;
        if (this.nowShowHero == null) goto LAB_180b1c9f6;
        lVar4 = this.heroDetailPanel;
        if (this.nowShowHero.internalSkill == null) {
          if (((((lVar4 == null) ||
                (lVar4 = GameObject.get_transform(lVar4,0), fVar1 = local_60) == null) ||
               (lVar4 = Transform.Find(lVar4,"Skill",0), fVar1 = local_60) == null) ||
              ((lVar4 = Transform.Find(lVar4,"SkillSlot0",0), fVar1 = local_60, lVar4 == null ||
               (lVar4 = Transform.Find(lVar4,"NowEquipment",0), fVar1 = local_60) == null))) ||
             (lVar4 = Component.get_gameObject(lVar4,0), fVar1 = local_60) == null)
          goto LAB_180b1c9f6;
          cVar2 = GameObject.get_activeSelf(lVar4,0);
          if (cVar2) {
            fVar1 = local_60;
            if (((this.heroDetailPanel == null) ||
                (lVar4 = GameObject.get_transform(this.heroDetailPanel,0), fVar1 = local_60,
                lVar4 == null)) ||
               ((lVar4 = Transform.Find(lVar4,"Skill",0), fVar1 = local_60, lVar4 == null ||
                ((lVar4 = Transform.Find(lVar4,"SkillSlot0",0), fVar1 = local_60, lVar4 == null ||
                 (lVar4 = Transform.Find(lVar4,"NowEquipment",0), fVar1 = local_60) == null)))))
            goto LAB_180b1c9f6;
            uVar5 = Component.get_gameObject(lVar4,0);
            HeroDetailController.UnshowEquipIcon(this,uVar5,resetPos,0);
          }
        }
        else {
          if (((((lVar4 == null) ||
                (lVar4 = GameObject.get_transform(lVar4,0), fVar1 = local_60) == null) ||
               (lVar4 = Transform.Find(lVar4,"Skill",0), fVar1 = local_60) == null) ||
              ((lVar4 = Transform.Find(lVar4,"SkillSlot0",0), fVar1 = local_60, lVar4 == null ||
               (lVar4 = Transform.Find(lVar4,"NowEquipment",0), fVar1 = local_60) == null))) ||
             (lVar4 = Component.get_gameObject(lVar4,0), fVar1 = local_60) == null)
          goto LAB_180b1c9f6;
          cVar2 = GameObject.get_activeSelf(lVar4,0);
          if (!cVar2) {
            fVar1 = local_60;
            if (((this.heroDetailPanel == null) ||
                (lVar4 = GameObject.get_transform(this.heroDetailPanel,0), fVar1 = local_60,
                lVar4 == null)) ||
               ((lVar4 = Transform.Find(lVar4,"Skill",0), fVar1 = local_60, lVar4 == null ||
                ((lVar4 = Transform.Find(lVar4,"SkillSlot0",0), fVar1 = local_60, lVar4 == null ||
                 (lVar4 = Transform.Find(lVar4,"NowEquipment",0), fVar1 = local_60) == null)))))
            goto LAB_180b1c9f6;
            uVar5 = Component.get_gameObject(lVar4,0);
            HeroDetailController.ShowEquipIcon(this,uVar5,resetPos,0);
          }
          fVar1 = local_60;
          if ((((this.heroDetailPanel == null) ||
               (lVar4 = GameObject.get_transform(this.heroDetailPanel,0), fVar1 = local_60,
               lVar4 == null)) ||
              (lVar4 = Transform.Find(lVar4,"Skill",0), fVar1 = local_60) == null) ||
             (lVar4 = Transform.Find(lVar4,"SkillSlot0",0), fVar1 = local_60) == null)
          goto LAB_180b1c9f6;
          lVar4 = Transform.Find(lVar4,"NowEquipment",0);
          puVar6 = (uint64 *)Vector3.get_one(&local_48,0);
          local_68 = *puVar6;
          local_60 = *(float *)(puVar6 + 1) * 1.2;
          local_78 = CONCAT44((float)((uint64)local_68 >> 32) * 1.2,(float)local_68 * 1.2);
          fVar1 = *(float *)(puVar6 + 1);
          if (lVar4 == null) goto LAB_180b1c9f6;
          local_68 = local_78;
          Transform.set_localScale(lVar4,&local_68,0);
          fVar1 = local_60;
          if (((this.heroDetailPanel == null) ||
              (lVar4 = GameObject.get_transform(this.heroDetailPanel,0), fVar1 = local_60,
              lVar4 == null)) ||
             ((lVar4 = Transform.Find(lVar4,"Skill",0), fVar1 = local_60, lVar4 == null ||
              ((lVar4 = Transform.Find(lVar4,"SkillSlot0",0), fVar1 = local_60, lVar4 == null ||
               (lVar4 = Transform.Find(lVar4,"NowEquipment",0), fVar1 = local_60) == null)))))
          goto LAB_180b1c9f6;
          lVar4 = Component.GetComponent(lVar4,DAT_181e78e38);
          fVar1 = local_60;
          if ((this.nowShowHero == null) || (lVar4 == null)) goto LAB_180b1c9f6;
          lVar4.summonControlable = this.nowShowHero.internalSkill;
          fVar1 = local_60;
          if ((((this.heroDetailPanel == null) ||
               (lVar4 = GameObject.get_transform(this.heroDetailPanel,0), fVar1 = local_60,
               lVar4 == null)) ||
              (lVar4 = Transform.Find(lVar4,"Skill",0), fVar1 = local_60) == null) ||
             (((lVar4 = Transform.Find(lVar4,"SkillSlot0",0), fVar1 = local_60, lVar4 == null ||
               (lVar4 = Transform.Find(lVar4,"NowEquipment",0), fVar1 = local_60) == null) ||
              (lVar4 = Component.GetComponent(lVar4,DAT_181e78e38), fVar1 = local_60) == null)))
          goto LAB_180b1c9f6;
          *(uint8 *)(lVar4 + 44) = 0;
          if (((this.heroDetailPanel == null) ||
              (lVar4 = GameObject.get_transform(this.heroDetailPanel,0), fVar1 = local_60,
              lVar4 == null)) ||
             ((lVar4 = Transform.Find(lVar4,"Skill",0), fVar1 = local_60, lVar4 == null ||
              (((lVar4 = Transform.Find(lVar4,"SkillSlot0",0), fVar1 = local_60, lVar4 == null ||
                (lVar4 = Transform.Find(lVar4,"NowEquipment",0), fVar1 = local_60) == null) ||
               (lVar4 = Component.GetComponent(lVar4,DAT_181e78e38), fVar1 = local_60) == null)))))
          goto LAB_180b1c9f6;
          lVar4.summonSourceHero = 1;
          if ((((this.heroDetailPanel == null) ||
               (lVar4 = GameObject.get_transform(this.heroDetailPanel,0), fVar1 = local_60,
               lVar4 == null)) ||
              (lVar4 = Transform.Find(lVar4,"Skill",0), fVar1 = local_60) == null) ||
             ((lVar4 = Transform.Find(lVar4,"SkillSlot0",0), fVar1 = local_60, lVar4 == null ||
              (lVar4 = Transform.Find(lVar4,"NowEquipment",0), fVar1 = local_60) == null)))
          goto LAB_180b1c9f6;
          lVar4 = Component.GetComponent(lVar4,DAT_181e76ab8);
          fVar1 = local_60;
          if (this.nowShowHero == null) goto LAB_180b1c9f6;
          cVar2 = HeroData.ItemControlable(this.nowShowHero,0);
          uVar3 = 1;
          if (!cVar2) {
            uVar3 = this.itemSpeControlable;
          }
          fVar1 = local_60;
          if (lVar4 == null) goto LAB_180b1c9f6;
          Selectable.set_interactable(lVar4,uVar3,0);
        }
        fVar1 = local_60;
        if (this.nowShowHero == null) goto LAB_180b1c9f6;
        lVar4 = this.heroDetailPanel;
        if (this.nowShowHero.dodgeSkill == null) {
          if ((((lVar4 == null) || (lVar4 = GameObject.get_transform(lVar4,0), fVar1 = local_60) == null
               ) || (lVar4 = Transform.Find(lVar4,"Skill",0), fVar1 = local_60) == null) ||
             (((lVar4 = Transform.Find(lVar4,"SkillSlot1",0), fVar1 = local_60, lVar4 == null ||
               (lVar4 = Transform.Find(lVar4,"NowEquipment",0), fVar1 = local_60) == null) ||
              (lVar4 = Component.get_gameObject(lVar4,0), fVar1 = local_60) == null)))
          goto LAB_180b1c9f6;
          cVar2 = GameObject.get_activeSelf(lVar4,0);
          if (cVar2) {
            fVar1 = local_60;
            if (((this.heroDetailPanel == null) ||
                (lVar4 = GameObject.get_transform(this.heroDetailPanel,0), fVar1 = local_60,
                lVar4 == null)) ||
               ((lVar4 = Transform.Find(lVar4,"Skill",0), fVar1 = local_60, lVar4 == null ||
                ((lVar4 = Transform.Find(lVar4,"SkillSlot1",0), fVar1 = local_60, lVar4 == null ||
                 (lVar4 = Transform.Find(lVar4,"NowEquipment",0), fVar1 = local_60) == null)))))
            goto LAB_180b1c9f6;
            uVar5 = Component.get_gameObject(lVar4,0);
            HeroDetailController.UnshowEquipIcon(this,uVar5,resetPos,0);
          }
        }
        else {
          if (((((lVar4 == null) ||
                (lVar4 = GameObject.get_transform(lVar4,0), fVar1 = local_60) == null) ||
               (lVar4 = Transform.Find(lVar4,"Skill",0), fVar1 = local_60) == null) ||
              ((lVar4 = Transform.Find(lVar4,"SkillSlot1",0), fVar1 = local_60, lVar4 == null ||
               (lVar4 = Transform.Find(lVar4,"NowEquipment",0), fVar1 = local_60) == null))) ||
             (lVar4 = Component.get_gameObject(lVar4,0), fVar1 = local_60) == null)
          goto LAB_180b1c9f6;
          cVar2 = GameObject.get_activeSelf(lVar4,0);
          if (!cVar2) {
            fVar1 = local_60;
            if (((this.heroDetailPanel == null) ||
                (lVar4 = GameObject.get_transform(this.heroDetailPanel,0), fVar1 = local_60,
                lVar4 == null)) ||
               ((lVar4 = Transform.Find(lVar4,"Skill",0), fVar1 = local_60, lVar4 == null ||
                ((lVar4 = Transform.Find(lVar4,"SkillSlot1",0), fVar1 = local_60, lVar4 == null ||
                 (lVar4 = Transform.Find(lVar4,"NowEquipment",0), fVar1 = local_60) == null)))))
            goto LAB_180b1c9f6;
            uVar5 = Component.get_gameObject(lVar4,0);
            HeroDetailController.ShowEquipIcon(this,uVar5,resetPos,0);
          }
          fVar1 = local_60;
          if ((((this.heroDetailPanel == null) ||
               (lVar4 = GameObject.get_transform(this.heroDetailPanel,0), fVar1 = local_60,
               lVar4 == null)) ||
              (lVar4 = Transform.Find(lVar4,"Skill",0), fVar1 = local_60) == null) ||
             (lVar4 = Transform.Find(lVar4,"SkillSlot1",0), fVar1 = local_60) == null)
          goto LAB_180b1c9f6;
          lVar4 = Transform.Find(lVar4,"NowEquipment",0);
          puVar6 = (uint64 *)Vector3.get_one(&local_48,0);
          local_68 = *puVar6;
          local_60 = *(float *)(puVar6 + 1) * 1.1;
          local_78 = CONCAT44((float)((uint64)local_68 >> 32) * 1.1,(float)local_68 * 1.1);
          fVar1 = *(float *)(puVar6 + 1);
          if (lVar4 == null) goto LAB_180b1c9f6;
          local_68 = local_78;
          Transform.set_localScale(lVar4,&local_68,0);
          fVar1 = local_60;
          if (((this.heroDetailPanel == null) ||
              (lVar4 = GameObject.get_transform(this.heroDetailPanel,0), fVar1 = local_60,
              lVar4 == null)) ||
             ((lVar4 = Transform.Find(lVar4,"Skill",0), fVar1 = local_60, lVar4 == null ||
              ((lVar4 = Transform.Find(lVar4,"SkillSlot1",0), fVar1 = local_60, lVar4 == null ||
               (lVar4 = Transform.Find(lVar4,"NowEquipment",0), fVar1 = local_60) == null)))))
          goto LAB_180b1c9f6;
          lVar4 = Component.GetComponent(lVar4,DAT_181e78e38);
          fVar1 = local_60;
          if ((this.nowShowHero == null) || (lVar4 == null)) goto LAB_180b1c9f6;
          lVar4.summonControlable = this.nowShowHero.dodgeSkill;
          fVar1 = local_60;
          if (((((this.heroDetailPanel == null) ||
                (lVar4 = GameObject.get_transform(this.heroDetailPanel,0), fVar1 = local_60,
                lVar4 == null)) ||
               (lVar4 = Transform.Find(lVar4,"Skill",0), fVar1 = local_60) == null) ||
              ((lVar4 = Transform.Find(lVar4,"SkillSlot1",0), fVar1 = local_60, lVar4 == null ||
               (lVar4 = Transform.Find(lVar4,"NowEquipment",0), fVar1 = local_60) == null))) ||
             (lVar4 = Component.GetComponent(lVar4,DAT_181e78e38), fVar1 = local_60) == null)
          goto LAB_180b1c9f6;
          *(uint8 *)(lVar4 + 44) = 0;
          if (((this.heroDetailPanel == null) ||
              (lVar4 = GameObject.get_transform(this.heroDetailPanel,0), fVar1 = local_60,
              lVar4 == null)) ||
             ((lVar4 = Transform.Find(lVar4,"Skill",0), fVar1 = local_60, lVar4 == null ||
              (((lVar4 = Transform.Find(lVar4,"SkillSlot1",0), fVar1 = local_60, lVar4 == null ||
                (lVar4 = Transform.Find(lVar4,"NowEquipment",0), fVar1 = local_60) == null) ||
               (lVar4 = Component.GetComponent(lVar4,DAT_181e78e38), fVar1 = local_60) == null)))))
          goto LAB_180b1c9f6;
          lVar4.summonSourceHero = 1;
          if (((this.heroDetailPanel == null) ||
              (lVar4 = GameObject.get_transform(this.heroDetailPanel,0), fVar1 = local_60,
              lVar4 == null)) ||
             ((lVar4 = Transform.Find(lVar4,"Skill",0), fVar1 = local_60, lVar4 == null ||
              ((lVar4 = Transform.Find(lVar4,"SkillSlot1",0), fVar1 = local_60, lVar4 == null ||
               (lVar4 = Transform.Find(lVar4,"NowEquipment",0), fVar1 = local_60) == null)))))
          goto LAB_180b1c9f6;
          lVar4 = Component.GetComponent(lVar4,DAT_181e76ab8);
          fVar1 = local_60;
          if (this.nowShowHero == null) goto LAB_180b1c9f6;
          cVar2 = HeroData.ItemControlable(this.nowShowHero,0);
          uVar3 = 1;
          if (!cVar2) {
            uVar3 = this.itemSpeControlable;
          }
          fVar1 = local_60;
          if (lVar4 == null) goto LAB_180b1c9f6;
          Selectable.set_interactable(lVar4,uVar3,0);
        }
        fVar1 = local_60;
        if (this.nowShowHero != null) {
          lVar4 = this.heroDetailPanel;
          if (this.nowShowHero.uniqueSkill == null) {
            if (((((lVar4 != null) &&
                  (lVar4 = GameObject.get_transform(lVar4,0), fVar1 = local_60) != null) &&
                 (lVar4 = Transform.Find(lVar4,"Skill",0), fVar1 = local_60) != null) &&
                ((lVar4 = Transform.Find(lVar4,"SkillSlot2",0), fVar1 = local_60, lVar4 != null &&
                 (lVar4 = Transform.Find(lVar4,"NowEquipment",0), fVar1 = local_60) != null))) &&
               (lVar4 = Component.get_gameObject(lVar4,0), fVar1 = local_60) != null) {
              cVar2 = GameObject.get_activeSelf(lVar4,0);
              if (cVar2) {
                fVar1 = local_60;
                if (((this.heroDetailPanel == null) ||
                    (lVar4 = GameObject.get_transform(this.heroDetailPanel,0), fVar1 = local_60,
                    lVar4 == null)) ||
                   ((lVar4 = Transform.Find(lVar4,"Skill",0), fVar1 = local_60, lVar4 == null ||
                    ((lVar4 = Transform.Find(lVar4,"SkillSlot2",0), fVar1 = local_60, lVar4 == null ||
                     (lVar4 = Transform.Find(lVar4,"NowEquipment",0), fVar1 = local_60) == null)))))
                goto LAB_180b1c9f6;
                uVar5 = Component.get_gameObject(lVar4,0);
                HeroDetailController.UnshowEquipIcon(this,uVar5,resetPos,0);
              }
        LAB_180b1bb93:
              lVar4 = this.nowShowHero;
              if (lVar4 != null) {
                while (lVar4.attackSkills != null) {
                  if (*(int *)(lVar4.attackSkills + 24) <= iVar10) {
                    return;
                  }
                  fVar1 = local_60;
                  if (lVar4 == null) goto LAB_180b1c9f6;
                  cVar2 = HeroData.AttackSkillSlotUnlocked(lVar4,iVar10,0);
                  lVar4 = this.heroDetailPanel;
                  fVar1 = local_60;
                  if (!cVar2) {
                    if ((lVar4 == null) ||
                       (lVar4 = GameObject.get_transform(lVar4,0), fVar1 = local_60) == null)
                    goto LAB_180b1c9f6;
                    lVar4 = Transform.Find(lVar4,"Skill",0);
                    iVar9 = iVar10 + 3;
                    local_res8[0] = iVar9;
                    uVar5 = Int32.ToString(local_res8,0);
                    uVar5 = String.Concat("SkillSlot",uVar5,0);
                    fVar1 = local_60;
                    if ((lVar4 == null) ||
                       (((lVar4 = Transform.Find(lVar4,uVar5,0), fVar1 = local_60, lVar4 == null ||
                         (lVar4 = Transform.Find(lVar4,"Lock",0), fVar1 = local_60) == null)
                        || (lVar4 = Component.get_gameObject(lVar4,0), fVar1 = local_60) == null)))
                    goto LAB_180b1c9f6;
                    cVar2 = GameObject.get_activeSelf(lVar4,0);
                    if (!cVar2) {
                      fVar1 = local_60;
                      if ((this.heroDetailPanel == null) ||
                         (lVar4 = GameObject.get_transform(this.heroDetailPanel,0),
                         fVar1 = local_60, lVar4 == null)) goto LAB_180b1c9f6;
                      lVar4 = Transform.Find(lVar4,"Skill",0);
                      local_res8[0] = iVar9;
                      uVar5 = Int32.ToString(local_res8,0);
                      uVar5 = String.Concat("SkillSlot",uVar5,0);
                      fVar1 = local_60;
                      if ((lVar4 == null) ||
                         ((lVar4 = Transform.Find(lVar4,uVar5,0), fVar1 = local_60, lVar4 == null ||
                          (lVar4 = Transform.Find(lVar4,"Lock",0), fVar1 = local_60) == null))
                         ) goto LAB_180b1c9f6;
                      lVar4 = Component.get_gameObject(lVar4,0);
                      fVar1 = local_60;
                      if (lVar4 == null) goto LAB_180b1c9f6;
                      GameObject.SetActive(lVar4,1,0);
                    }
                    fVar1 = local_60;
                    if ((this.heroDetailPanel == null) ||
                       (lVar4 = GameObject.get_transform(this.heroDetailPanel,0),
                       fVar1 = local_60, lVar4 == null)) goto LAB_180b1c9f6;
                    lVar4 = Transform.Find(lVar4,"Skill",0);
                    local_res8[0] = iVar9;
                    uVar5 = Int32.ToString(local_res8,0);
                    uVar5 = String.Concat("SkillSlot",uVar5,0);
                    fVar1 = local_60;
                    if ((lVar4 == null) ||
                       (((lVar4 = Transform.Find(lVar4,uVar5,0), fVar1 = local_60, lVar4 == null ||
                         (lVar4 = Transform.Find(lVar4,"Text",0), fVar1 = local_60) == null)
                        || (lVar4 = Component.get_gameObject(lVar4,0), fVar1 = local_60) == null)))
                    goto LAB_180b1c9f6;
                    cVar2 = GameObject.get_activeSelf(lVar4,0);
                    if (cVar2) {
                      fVar1 = local_60;
                      if ((this.heroDetailPanel == null) ||
                         (lVar4 = GameObject.get_transform(this.heroDetailPanel,0),
                         fVar1 = local_60, lVar4 == null)) goto LAB_180b1c9f6;
                      lVar4 = Transform.Find(lVar4,"Skill",0);
                      local_res8[0] = iVar9;
                      uVar5 = Int32.ToString(local_res8,0);
                      uVar5 = String.Concat("SkillSlot",uVar5,0);
                      fVar1 = local_60;
                      if (((lVar4 == null) ||
                          ((lVar4 = Transform.Find(lVar4,uVar5,0), fVar1 = local_60, lVar4 == null ||
                           (lVar4 = Transform.Find(lVar4,"Text",0), fVar1 = local_60) == null)
                          )) || (lVar4 = Component.get_gameObject(lVar4,0), fVar1 = local_60) == null
                         ) goto LAB_180b1c9f6;
                      GameObject.SetActive(lVar4,0,0);
                    }
                    fVar1 = local_60;
                    if ((this.heroDetailPanel == null) ||
                       (lVar4 = GameObject.get_transform(this.heroDetailPanel,0),
                       fVar1 = local_60, lVar4 == null)) goto LAB_180b1c9f6;
                    lVar4 = Transform.Find(lVar4,"Skill",0);
                    local_res8[0] = iVar9;
                    uVar5 = Int32.ToString(local_res8,0);
                    uVar5 = String.Concat("SkillSlot",uVar5,0);
                    fVar1 = local_60;
                    if ((lVar4 == null) ||
                       (((lVar4 = Transform.Find(lVar4,uVar5,0), fVar1 = local_60, lVar4 == null ||
                         (lVar4 = Transform.Find(lVar4,"Lock",0), fVar1 = local_60) == null)
                        || (lVar4 = Transform.Find(lVar4,"Light",0), fVar1 = local_60) == null)
                       )) goto LAB_180b1c9f6;
                    plVar7 = (int64 *)Component.GetComponent(lVar4,DAT_181e777b8);
                    lVar4 = FUN_180210740(0);
                    fVar1 = local_60;
                    if (((lVar4 == null) || (lVar4.dailyAIManaged == null)) ||
                       ((lVar4 = FUN_1800024b0(lVar4.dailyAIManaged,iVar10 + -2,DAT_181e80560),
                        fVar1 = local_60, lVar4 == null || (plVar7 == (int64 *)0)))) goto LAB_180b1c9f6;
                    local_48 = lVar4.summonLv;
                    uStack_44 = lVar4.summonMoveRange;
                    uStack_40 = lVar4.summonControlable;
                    uStack_3c = *(uint32 *)(lVar4 + 36);
                    (**(code **)(*plVar7 + 0x2a8))(plVar7,&local_48,*(uint64 *)(*plVar7 + 0x2b0));
                    fVar1 = local_60;
                    if ((this.heroDetailPanel == null) ||
                       (lVar4 = GameObject.get_transform(this.heroDetailPanel,0),
                       fVar1 = local_60, lVar4 == null)) goto LAB_180b1c9f6;
                    lVar4 = Transform.Find(lVar4,"Skill",0);
                    local_res8[0] = iVar9;
                    uVar5 = Int32.ToString(local_res8,0);
                    uVar5 = String.Concat("SkillSlot",uVar5,0);
                    fVar1 = local_60;
                    if ((lVar4 == null) ||
                       ((lVar4 = Transform.Find(lVar4,uVar5,0), fVar1 = local_60, lVar4 == null ||
                        (lVar4 = Transform.Find(lVar4,"Lock",0), fVar1 = local_60) == null)))
                    goto LAB_180b1c9f6;
                    lVar4 = Component.GetComponent(lVar4,DAT_181e788b8);
                    lVar8 = *(int64 *)(*(int64 *)(DAT_181e538e8 + 184) + 0x518);
                    if (lVar8 == null) break;
                    uVar5 = FUN_1800024b0(lVar8,iVar10 + -2,DAT_181e86970);
                    uVar5 = GlobalData.GenerateRareLvColorText(uVar5,iVar10 + -2,0);
                    uVar5 = String.Format("习得{0}武功后解锁",uVar5,0);
                    if (lVar4 == null) break;
                    lVar4.summonLv = uVar5;
                  }
                  else {
                    if ((lVar4 == null) ||
                       (lVar4 = GameObject.get_transform(lVar4,0), fVar1 = local_60) == null)
                    goto LAB_180b1c9f6;
                    lVar4 = Transform.Find(lVar4,"Skill",0);
                    iVar9 = iVar10 + 3;
                    local_res8[0] = iVar9;
                    uVar5 = Int32.ToString(local_res8,0);
                    uVar5 = String.Concat("SkillSlot",uVar5,0);
                    fVar1 = local_60;
                    if ((lVar4 == null) ||
                       (((lVar4 = Transform.Find(lVar4,uVar5,0), fVar1 = local_60, lVar4 == null ||
                         (lVar4 = Transform.Find(lVar4,"Lock",0), fVar1 = local_60) == null)
                        || (lVar4 = Component.get_gameObject(lVar4,0), fVar1 = local_60) == null)))
                    goto LAB_180b1c9f6;
                    cVar2 = GameObject.get_activeSelf(lVar4,0);
                    if (cVar2) {
                      fVar1 = local_60;
                      if ((this.heroDetailPanel == null) ||
                         (lVar4 = GameObject.get_transform(this.heroDetailPanel,0),
                         fVar1 = local_60, lVar4 == null)) goto LAB_180b1c9f6;
                      lVar4 = Transform.Find(lVar4,"Skill",0);
                      local_res8[0] = iVar9;
                      uVar5 = Int32.ToString(local_res8,0);
                      uVar5 = String.Concat("SkillSlot",uVar5,0);
                      fVar1 = local_60;
                      if (((lVar4 == null) ||
                          ((lVar4 = Transform.Find(lVar4,uVar5,0), fVar1 = local_60, lVar4 == null ||
                           (lVar4 = Transform.Find(lVar4,"Lock",0), fVar1 = local_60) == null)
                          )) || (lVar4 = Component.get_gameObject(lVar4,0), fVar1 = local_60) == null
                         ) goto LAB_180b1c9f6;
                      GameObject.SetActive(lVar4,0,0);
                    }
                    fVar1 = local_60;
                    if ((this.heroDetailPanel == null) ||
                       (lVar4 = GameObject.get_transform(this.heroDetailPanel,0),
                       fVar1 = local_60, lVar4 == null)) goto LAB_180b1c9f6;
                    lVar4 = Transform.Find(lVar4,"Skill",0);
                    local_res8[0] = iVar9;
                    uVar5 = Int32.ToString(local_res8,0);
                    uVar5 = String.Concat("SkillSlot",uVar5,0);
                    fVar1 = local_60;
                    if ((lVar4 == null) ||
                       (((lVar4 = Transform.Find(lVar4,uVar5,0), fVar1 = local_60, lVar4 == null ||
                         (lVar4 = Transform.Find(lVar4,"Text",0), fVar1 = local_60) == null)
                        || (lVar4 = Component.get_gameObject(lVar4,0), fVar1 = local_60) == null)))
                    goto LAB_180b1c9f6;
                    cVar2 = GameObject.get_activeSelf(lVar4,0);
                    if (!cVar2) {
                      fVar1 = local_60;
                      if ((this.heroDetailPanel == null) ||
                         (lVar4 = GameObject.get_transform(this.heroDetailPanel,0),
                         fVar1 = local_60, lVar4 == null)) goto LAB_180b1c9f6;
                      lVar4 = Transform.Find(lVar4,"Skill",0);
                      local_res8[0] = iVar9;
                      uVar5 = Int32.ToString(local_res8,0);
                      uVar5 = String.Concat("SkillSlot",uVar5,0);
                      fVar1 = local_60;
                      if ((lVar4 == null) ||
                         ((lVar4 = Transform.Find(lVar4,uVar5,0), fVar1 = local_60, lVar4 == null ||
                          (lVar4 = Transform.Find(lVar4,"Text",0), fVar1 = local_60) == null))
                         ) goto LAB_180b1c9f6;
                      lVar4 = Component.get_gameObject(lVar4,0);
                      fVar1 = local_60;
                      if (lVar4 == null) goto LAB_180b1c9f6;
                      GameObject.SetActive(lVar4,1,0);
                    }
                  }
                  iVar9 = iVar10 + 3;
                  if ((this.nowShowHero == null) ||
                     (lVar4 = this.nowShowHero.attackSkills) == null) break;
                  lVar8 = FUN_1800024b0(lVar4,iVar10,DAT_181e747f0);
                  lVar4 = this.heroDetailPanel;
                  if (lVar8 == null) {
                    if ((lVar4 == null) || (lVar4 = GameObject.get_transform(lVar4,0)) == null) break;
                    lVar4 = Transform.Find(lVar4,"Skill",0);
                    local_res8[0] = iVar9;
                    uVar5 = Int32.ToString(local_res8,0);
                    uVar5 = String.Concat("SkillSlot",uVar5,0);
                    if ((lVar4 == null) ||
                       (((lVar4 = Transform.Find(lVar4,uVar5,0), lVar4 == null ||
                         (lVar4 = Transform.Find(lVar4,"NowEquipment",0)) == null) ||
                        (lVar4 = Component.get_gameObject(lVar4,0)) == null))) break;
                    cVar2 = GameObject.get_activeSelf(lVar4,0);
                    if (cVar2) {
                      if ((this.heroDetailPanel == null) ||
                         (lVar4 = GameObject.get_transform(this.heroDetailPanel,0)) == null)
                      break;
                      lVar4 = Transform.Find(lVar4,"Skill",0);
                      local_res8[0] = iVar9;
                      uVar5 = Int32.ToString(local_res8,0);
                      uVar5 = String.Concat("SkillSlot",uVar5,0);
                      if ((lVar4 == null) ||
                         ((lVar4 = Transform.Find(lVar4,uVar5,0), lVar4 == null ||
                          (lVar4 = Transform.Find(lVar4,"NowEquipment",0)) == null))) break;
                      uVar5 = Component.get_gameObject(lVar4,0);
                      HeroDetailController.UnshowEquipIcon(this,uVar5,resetPos);
                    }
                  }
                  else {
                    if ((lVar4 == null) || (lVar4 = GameObject.get_transform(lVar4,0)) == null) break;
                    lVar4 = Transform.Find(lVar4,"Skill",0);
                    local_res8[0] = iVar9;
                    uVar5 = Int32.ToString(local_res8,0);
                    uVar5 = String.Concat("SkillSlot",uVar5,0);
                    if ((lVar4 == null) ||
                       (((lVar4 = Transform.Find(lVar4,uVar5,0), lVar4 == null ||
                         (lVar4 = Transform.Find(lVar4,"NowEquipment",0)) == null) ||
                        (lVar4 = Component.get_gameObject(lVar4,0)) == null))) break;
                    cVar2 = GameObject.get_activeSelf(lVar4,0);
                    if (!cVar2) {
                      if ((this.heroDetailPanel == null) ||
                         (lVar4 = GameObject.get_transform(this.heroDetailPanel,0)) == null)
                      break;
                      lVar4 = Transform.Find(lVar4,"Skill",0);
                      local_res8[0] = iVar9;
                      uVar5 = Int32.ToString(local_res8,0);
                      uVar5 = String.Concat("SkillSlot",uVar5,0);
                      if ((lVar4 == null) ||
                         ((lVar4 = Transform.Find(lVar4,uVar5,0), lVar4 == null ||
                          (lVar4 = Transform.Find(lVar4,"NowEquipment",0)) == null))) break;
                      uVar5 = Component.get_gameObject(lVar4,0);
                      HeroDetailController.ShowEquipIcon(this,uVar5,resetPos,0);
                    }
                    if ((this.heroDetailPanel == null) ||
                       (lVar4 = GameObject.get_transform(this.heroDetailPanel,0)) == null)
                    break;
                    lVar4 = Transform.Find(lVar4,"Skill",0);
                    local_res8[0] = iVar9;
                    uVar5 = Int32.ToString(local_res8,0);
                    uVar5 = String.Concat("SkillSlot",uVar5,0);
                    if ((lVar4 == null) ||
                       ((lVar4 = Transform.Find(lVar4,uVar5,0), lVar4 == null ||
                        (lVar4 = Transform.Find(lVar4,"NowEquipment",0)) == null))) break;
                    lVar4 = Component.GetComponent(lVar4,DAT_181e78e38);
                    if ((this.nowShowHero == null) ||
                       ((lVar8 = this.nowShowHero.attackSkills, lVar8 == null ||
                        (uVar5 = FUN_1800024b0(lVar8,iVar10,DAT_181e747f0), lVar4 == null)))) break;
                    lVar4.summonControlable = uVar5;
                    if ((this.heroDetailPanel == null) ||
                       (lVar4 = GameObject.get_transform(this.heroDetailPanel,0)) == null)
                    break;
                    lVar4 = Transform.Find(lVar4,"Skill",0);
                    local_res8[0] = iVar9;
                    uVar5 = Int32.ToString(local_res8,0);
                    uVar5 = String.Concat("SkillSlot",uVar5,0);
                    if ((((lVar4 == null) || (lVar4 = Transform.Find(lVar4,uVar5,0)) == null) ||
                        (lVar4 = Transform.Find(lVar4,"NowEquipment",0)) == null) ||
                       (lVar4 = Component.GetComponent(lVar4,DAT_181e78e38)) == null) break;
                    *(uint8 *)(lVar4 + 44) = 0;
                    if ((this.heroDetailPanel == null) ||
                       (lVar4 = GameObject.get_transform(this.heroDetailPanel,0)) == null)
                    break;
                    lVar4 = Transform.Find(lVar4,"Skill",0);
                    local_res8[0] = iVar9;
                    uVar5 = Int32.ToString(local_res8,0);
                    uVar5 = String.Concat("SkillSlot",uVar5,0);
                    if ((lVar4 == null) ||
                       (((lVar4 = Transform.Find(lVar4,uVar5,0), lVar4 == null ||
                         (lVar4 = Transform.Find(lVar4,"NowEquipment",0)) == null) ||
                        (lVar4 = Component.GetComponent(lVar4,DAT_181e78e38)) == null))) break;
                    lVar4.summonSourceHero = 1;
                    if ((this.heroDetailPanel == null) ||
                       (lVar4 = GameObject.get_transform(this.heroDetailPanel,0)) == null)
                    break;
                    lVar4 = Transform.Find(lVar4,"Skill",0);
                    local_res8[0] = iVar9;
                    uVar5 = Int32.ToString(local_res8,0);
                    uVar5 = String.Concat("SkillSlot",uVar5,0);
                    if ((lVar4 == null) ||
                       ((lVar4 = Transform.Find(lVar4,uVar5,0), lVar4 == null ||
                        (lVar4 = Transform.Find(lVar4,"NowEquipment",0)) == null))) break;
                    lVar4 = Component.GetComponent(lVar4,DAT_181e76ab8);
                    uVar3 = HeroDetailController.NowShowHeroItemControlable(this,0);
                    if (lVar4 == null) break;
                    Selectable.set_interactable(lVar4,uVar3,0);
                  }
                  lVar4 = this.nowShowHero;
                  iVar10 = iVar10 + 1;
                  if (lVar4 == null) break;
                }
              }
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
          }
          else if (((((lVar4 != null) &&
                     (lVar4 = GameObject.get_transform(lVar4,0), fVar1 = local_60) != null) &&
                    (lVar4 = Transform.Find(lVar4,"Skill",0), fVar1 = local_60) != null) &&
                   ((lVar4 = Transform.Find(lVar4,"SkillSlot2",0), fVar1 = local_60, lVar4 != null &&
                    (lVar4 = Transform.Find(lVar4,"NowEquipment",0), fVar1 = local_60) != null))) &&
                  (lVar4 = Component.get_gameObject(lVar4,0), fVar1 = local_60) != null) {
            cVar2 = GameObject.get_activeSelf(lVar4,0);
            if (!cVar2) {
              fVar1 = local_60;
              if (((this.heroDetailPanel == null) ||
                  (lVar4 = GameObject.get_transform(this.heroDetailPanel,0), fVar1 = local_60,
                  lVar4 == null)) ||
                 ((lVar4 = Transform.Find(lVar4,"Skill",0), fVar1 = local_60, lVar4 == null ||
                  ((lVar4 = Transform.Find(lVar4,"SkillSlot2",0), fVar1 = local_60, lVar4 == null ||
                   (lVar4 = Transform.Find(lVar4,"NowEquipment",0), fVar1 = local_60) == null)))))
              goto LAB_180b1c9f6;
              uVar5 = Component.get_gameObject(lVar4,0);
              HeroDetailController.ShowEquipIcon(this,uVar5,resetPos,0);
            }
            fVar1 = local_60;
            if ((((this.heroDetailPanel != null) &&
                 (lVar4 = GameObject.get_transform(this.heroDetailPanel,0), fVar1 = local_60,
                 lVar4 != null)) &&
                (lVar4 = Transform.Find(lVar4,"Skill",0), fVar1 = local_60) != null) &&
               (lVar4 = Transform.Find(lVar4,"SkillSlot2",0), fVar1 = local_60) != null) {
              lVar4 = Transform.Find(lVar4,"NowEquipment",0);
              puVar6 = (uint64 *)Vector3.get_one(&local_48,0);
              local_68 = *puVar6;
              local_60 = *(float *)(puVar6 + 1) * 1.1;
              local_78 = CONCAT44((float)((uint64)local_68 >> 32) * 1.1,(float)local_68 * 1.1);
              fVar1 = *(float *)(puVar6 + 1);
              if (lVar4 != null) {
                local_68 = local_78;
                Transform.set_localScale(lVar4,&local_68,0);
                fVar1 = local_60;
                if (((this.heroDetailPanel != null) &&
                    (lVar4 = GameObject.get_transform(this.heroDetailPanel,0), fVar1 = local_60,
                    lVar4 != null)) &&
                   ((lVar4 = Transform.Find(lVar4,"Skill",0), fVar1 = local_60, lVar4 != null &&
                    ((lVar4 = Transform.Find(lVar4,"SkillSlot2",0), fVar1 = local_60, lVar4 != null &&
                     (lVar4 = Transform.Find(lVar4,"NowEquipment",0), fVar1 = local_60) != null))))) {
                  lVar4 = Component.GetComponent(lVar4,DAT_181e78e38);
                  fVar1 = local_60;
                  if ((this.nowShowHero != null) && (lVar4 != null)) {
                    lVar4.summonControlable = this.nowShowHero.uniqueSkill
                    ;
                    il2cpp_internal();
                    fVar1 = local_60;
                    if (((((this.heroDetailPanel != null) &&
                          (lVar4 = GameObject.get_transform(this.heroDetailPanel,0),
                          fVar1 = local_60, lVar4 != null)) &&
                         (lVar4 = Transform.Find(lVar4,"Skill",0), fVar1 = local_60) != null)
                        && ((lVar4 = Transform.Find(lVar4,"SkillSlot2",0), fVar1 = local_60, lVar4 != null
                            && (lVar4 = Transform.Find(lVar4,"NowEquipment",0), fVar1 = local_60,
                               lVar4 != null)))) &&
                       (lVar4 = Component.GetComponent(lVar4,DAT_181e78e38), fVar1 = local_60, lVar4 != null
                       )) {
                      *(uint8 *)(lVar4 + 44) = 0;
                      if (((this.heroDetailPanel != null) &&
                          (lVar4 = GameObject.get_transform(this.heroDetailPanel,0),
                          fVar1 = local_60, lVar4 != null)) &&
                         ((lVar4 = Transform.Find(lVar4,"Skill",0), fVar1 = local_60, lVar4 != null &&
                          (((lVar4 = Transform.Find(lVar4,"SkillSlot2",0), fVar1 = local_60, lVar4 != null
                            && (lVar4 = Transform.Find(lVar4,"NowEquipment",0), fVar1 = local_60,
                               lVar4 != null)) &&
                           (lVar4 = Component.GetComponent(lVar4,DAT_181e78e38), fVar1 = local_60,
                           lVar4 != null)))))) {
                        lVar4.summonSourceHero = 1;
                        if ((((this.heroDetailPanel != null) &&
                             (lVar4 = GameObject.get_transform(this.heroDetailPanel,0),
                             fVar1 = local_60, lVar4 != null)) &&
                            (lVar4 = Transform.Find(lVar4,"Skill",0), fVar1 = local_60) != null
                            ) && ((lVar4 = Transform.Find(lVar4,"SkillSlot2",0), fVar1 = local_60,
                                  lVar4 != null &&
                                  (lVar4 = Transform.Find(lVar4,"NowEquipment",0), fVar1 = local_60,
                                  lVar4 != null)))) {
                          lVar4 = Component.GetComponent(lVar4,DAT_181e76ab8);
                          fVar1 = local_60;
                          if (this.nowShowHero != null) {
                            cVar2 = HeroData.ItemControlable(this.nowShowHero,0);
                            uVar3 = 1;
                            if (!cVar2) {
                              uVar3 = this.itemSpeControlable;
                            }
                            fVar1 = local_60;
                            if (lVar4 != null) {
                              Selectable.set_interactable(lVar4,uVar3,0);
                              goto LAB_180b1bb93;
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
        LAB_180b1c9f6:
        local_60 = fVar1;
    }

    // Token : 0x6001806
    // RVA   : 0xB175F0   Offset: 0xB163F0   Length: 0x608
    public void RefreshEquipSlot(int slotID, ItemData targetItem, bool resetPos)
    {
        void HeroDetailController.RefreshEquipSlot
                     (int64 this,uint32 slotID,int64 targetItem,char resetPos)
        {
        char cVar1;
        char cVar2;
        uint32 uVar3;
        int64 lVar4;
        uint64 uVar5;
        uint32 local_res10 [2];
        local_res10[0] = slotID;
        lVar4 = this.heroDetailPanel;
        if (targetItem == null) {
          if ((lVar4 != null) && (lVar4 = GameObject.get_transform(lVar4,0)) != null) {
            lVar4 = Transform.Find(lVar4,"Item",0);
            uVar5 = Int32.ToString(local_res10,0);
            uVar5 = String.Concat("EquipSlot",uVar5,0);
            if ((lVar4 != null) &&
               (((lVar4 = Transform.Find(lVar4,uVar5,0), lVar4 != null &&
                 (lVar4 = Transform.Find(lVar4,"NowEquipment",0)) != null) &&
                (lVar4 = Component.get_gameObject(lVar4,0)) != null))) {
              cVar1 = GameObject.get_activeSelf(lVar4,0);
              if (!cVar1) {
                return;
              }
              if ((this.heroDetailPanel != null) &&
                 (lVar4 = GameObject.get_transform(this.heroDetailPanel,0)) != null) {
                lVar4 = Transform.Find(lVar4,"Item",0);
                uVar5 = Int32.ToString(local_res10,0);
                uVar5 = String.Concat("EquipSlot",uVar5,0);
                if ((lVar4 != null) &&
                   ((lVar4 = Transform.Find(lVar4,uVar5,0), lVar4 != null &&
                    (lVar4 = Transform.Find(lVar4,"NowEquipment",0)) != null))) {
                  uVar5 = Component.get_gameObject(lVar4,0);
                  HeroDetailController.UnshowEquipIcon(this,uVar5,resetPos,0);
                  return;
                }
              }
            }
          }
          throw; // [null/range check failed]
        }
        if ((lVar4 == null) || (lVar4 = GameObject.get_transform(lVar4,0)) == null) throw; // [null/range check failed]
        lVar4 = Transform.Find(lVar4,"Item",0);
        uVar5 = Int32.ToString(local_res10,0);
        uVar5 = String.Concat("EquipSlot",uVar5,0);
        if ((lVar4 == null) ||
           (((lVar4 = Transform.Find(lVar4,uVar5,0), lVar4 == null ||
             (lVar4 = Transform.Find(lVar4,"NowEquipment",0)) == null) ||
            (lVar4 = Component.get_gameObject(lVar4,0)) == null))) throw; // [null/range check failed]
        cVar1 = GameObject.get_activeSelf(lVar4,0);
        if (!cVar1) {
        LAB_180b17929:
          if ((this.heroDetailPanel == null) ||
             (lVar4 = GameObject.get_transform(this.heroDetailPanel,0)) == null)
          throw; // [null/range check failed]
          lVar4 = Transform.Find(lVar4,"Item",0);
          uVar5 = Int32.ToString(local_res10,0);
          uVar5 = String.Concat("EquipSlot",uVar5,0);
          if ((lVar4 == null) ||
             ((lVar4 = Transform.Find(lVar4,uVar5,0), lVar4 == null ||
              (lVar4 = Transform.Find(lVar4,"NowEquipment",0)) == null))) throw; // [null/range check failed]
          uVar5 = Component.get_gameObject(lVar4,0);
          HeroDetailController.ShowEquipIcon(this,uVar5,resetPos,0);
        }
        else if (!resetPos) {
          if ((this.heroDetailPanel == null) ||
             (lVar4 = GameObject.get_transform(this.heroDetailPanel,0)) == null)
          throw; // [null/range check failed]
          lVar4 = Transform.Find(lVar4,"Item",0);
          uVar5 = Int32.ToString(local_res10,0);
          uVar5 = String.Concat("EquipSlot",uVar5,0);
          if (((lVar4 == null) ||
              ((lVar4 = Transform.Find(lVar4,uVar5,0), lVar4 == null ||
               (lVar4 = Transform.Find(lVar4,"NowEquipment",0)) == null))) ||
             (lVar4 = Component.GetComponent(lVar4,DAT_181e77938)) == null) throw; // [null/range check failed]
          if (*(int64 *)(lVar4 + 32) != targetItem) goto LAB_180b17929;
        }
        if ((this.heroDetailPanel != null) &&
           (lVar4 = GameObject.get_transform(this.heroDetailPanel,0)) != null) {
          lVar4 = Transform.Find(lVar4,"Item",0);
          uVar5 = Int32.ToString(local_res10,0);
          uVar5 = String.Concat("EquipSlot",uVar5,0);
          if ((lVar4 != null) &&
             (((lVar4 = Transform.Find(lVar4,uVar5,0), lVar4 != null &&
               (lVar4 = Transform.Find(lVar4,"NowEquipment",0)) != null) &&
              (lVar4 = Component.GetComponent(lVar4,DAT_181e77938)) != null))) {
            *(int64 *)(lVar4 + 32) = targetItem;
            if ((this.heroDetailPanel != null) &&
               (lVar4 = GameObject.get_transform(this.heroDetailPanel,0)) != null) {
              lVar4 = Transform.Find(lVar4,"Item",0);
              uVar5 = Int32.ToString(local_res10,0);
              uVar5 = String.Concat("EquipSlot",uVar5,0);
              if ((lVar4 != null) &&
                 (((lVar4 = Transform.Find(lVar4,uVar5,0), lVar4 != null &&
                   (lVar4 = Transform.Find(lVar4,"NowEquipment",0)) != null) &&
                  (lVar4 = Component.GetComponent(lVar4,DAT_181e77938)) != null))) {
                *(uint8 *)(lVar4 + 64) = 0;
                if ((this.heroDetailPanel != null) &&
                   (lVar4 = GameObject.get_transform(this.heroDetailPanel,0)) != null) {
                  lVar4 = Transform.Find(lVar4,"Item",0);
                  uVar5 = Int32.ToString(local_res10,0);
                  uVar5 = String.Concat("EquipSlot",uVar5,0);
                  if ((lVar4 != null) &&
                     ((lVar4 = Transform.Find(lVar4,uVar5,0), lVar4 != null &&
                      (lVar4 = Transform.Find(lVar4,"NowEquipment",0)) != null))) {
                    lVar4 = Component.GetComponent(lVar4,DAT_181e77938);
                    if (this.nowShowHero != null) {
                      cVar2 = HeroData.ItemControlable(this.nowShowHero,0);
                      cVar1 = true;
                      if (!cVar2) {
                        cVar1 = this.itemSpeControlable;
                      }
                      if (lVar4 != null) {
                        uVar3 = 4;
                        if (!cVar1) {
                          uVar3 = 1;
                        }
                        *(uint32 *)(lVar4 + 40) = uVar3;
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

    // Token : 0x6001807
    // RVA   : 0xB16710   Offset: 0xB15510   Length: 0xED5
    public void RefreshEquipList(bool resetPos)
    {
        var pStatics_38e8 = *(int64*)(DAT_181e538e8 + 184);
        float fVar2;
        long lVar3;
        byte uVar4;
        int iVar5;
        uint uVar6;
        long lVar7;
        ulong uVar8;
        ulong uVar9;
        ulong uVar10;
        ulong uVar11;
        ulong uVar12;
        int iVar14;
        float fVar15;
        float[] local_res8 = new float[2];
        byte local_res10;
        uint local_68;
        uint uStack_64;
        uint uStack_60;
        uint32 uStack_5c;
        local_res10 = resetPos;
        local_res8[0] = 0.0;
        if ((((this.heroDetailPanel != null) &&
             (lVar7 = GameObject.get_transform(this.heroDetailPanel,0)) != null) &&
            (lVar7 = Transform.Find(lVar7,"Item",0)) != null) &&
           ((lVar7 = Transform.Find(lVar7,"EquipmentWeight",0), lVar7 != null &&
            (lVar7 = Component.GetComponent(lVar7,DAT_181e788b8)) != null))) {
          lVar7.summonLv = "<b>装备负重</b>";
          iVar14 = 0;
          while( true ) {
            lVar7 = *(int64 *)(pStatics_38e8 + 0x600);
            if (lVar7 == null) throw; // [null/range check failed]
            lVar3 = this.heroDetailPanel;
            if (lVar7.summonLv <= iVar14) break;
            if ((((lVar3 == null) || (lVar7 = GameObject.get_transform(lVar3,0)) == null) ||
                (lVar7 = Transform.Find(lVar7,"Item",0)) == null) ||
               ((lVar7 = Transform.Find(lVar7,"EquipmentWeight",0), lVar7 == null ||
                (lVar7 = Component.GetComponent(lVar7,DAT_181e788b8)) == null))) throw; // [null/range check failed]
            uVar12 = lVar7.summonLv;
            uVar11 = "\n{0}{1} 速度x{2}%";
            lVar3 = *(int64 *)(pStatics_38e8 + 0x600);
            if (lVar3 == null) throw; // [null/range check failed]
            uVar8 = "超重";
            if (iVar14 != *(int *)(lVar3 + 24) + -1) {
              lVar3 = *(int64 *)(pStatics_38e8 + 0x600);
              if (lVar3 == null) throw; // [null/range check failed]
              uVar8 = FUN_1800024b0(lVar3,iVar14,DAT_181e86970);
              uVar8 = String.Concat(uVar8,"装",0);
            }
            lVar3 = *(int64 *)(pStatics_38e8 + 0x600);
            if (lVar3 == null) throw; // [null/range check failed]
            uVar10 = "<";
            if (iVar14 == *(int *)(lVar3 + 24) + -1) {
              uVar10 = ">";
            }
            iVar5 = Mathf.Min(5,iVar14 + 1);
            if ((this.nowShowHero == null) ||
               (lVar3 = this.nowShowHero.totalAddData) == null)
            throw; // [null/range check failed]
            local_res8[0] = (float)HeroSpeAddData.Get(lVar3,207,0);
            local_res8[0] = local_res8[0] * (float)iVar5 * 0.2;
            uVar9 = Single.ToString(local_res8,"0.#",0);
            uVar10 = String.Concat(uVar10,uVar9,0);
            lVar3 = *(int64 *)(pStatics_38e8 + 0x608);
            if (lVar3 == null) throw; // [null/range check failed]
            local_res8[0] = (float)FUN_1800024e0(lVar3,iVar14,DAT_181e83530);
            local_res8[0] = local_res8[0] * 100.0;
            uVar9 = Single.ToString(local_res8,"f0",0);
            uVar11 = String.Format(uVar11,uVar8,uVar10,uVar9,0);
            uVar12 = String.Concat(uVar12,uVar11);
            lVar7.summonLv = uVar12;
            iVar14 = iVar14 + 1;
          }
          if ((((lVar3 != null) && (lVar7 = GameObject.get_transform(lVar3,0)) != null) &&
              (lVar7 = Transform.Find(lVar7,"Item",0)) != null) &&
             ((lVar7 = Transform.Find(lVar7,"EquipmentWeight",0), lVar7 != null &&
              (lVar7 = Component.GetComponent(lVar7,DAT_181e788b8)) != null))) {
            uVar12 = lVar7.summonLv;
            uVar11 = FUN_1800020e0(DAT_181e6dc98);
            uVar11 = String.Format("\n每超重1点速度-1%/闪避-1%",uVar11,0);
            uVar12 = String.Concat(uVar12,uVar11,0);
            *puVar1 = uVar12;
            il2cpp_internal(puVar1,uVar12);
            if (((this.heroDetailPanel != null) &&
                ((lVar7 = GameObject.get_transform(this.heroDetailPanel,0), lVar7 != null &&
                 (lVar7 = Transform.Find(lVar7,"Item",0)) != null))) &&
               (lVar7 = Transform.Find(lVar7,"EquipmentWeight",0)) != null) {
              uVar12 = Component.GetComponent(lVar7,DAT_181e79538);
              lVar7 = this.nowShowHero;
              if ((lVar7 != null) && (lVar7.nowEquipment != null)) {
                fVar2 = *(float *)(lVar7.nowEquipment + 16);
                if (lVar7.totalAddData != null) {
                  fVar15 = (float)HeroSpeAddData.Get(lVar7.totalAddData,207,0);
                  uVar11 = "{0}/{1}";
                  if (fVar15 < fVar2) {
                    uVar11 = "{2}{0}/{1}</color>";
                  }
                  if ((this.nowShowHero != null) &&
                     (lVar7 = this.nowShowHero.nowEquipment) != null) {
                    uVar8 = Single.ToString(lVar7 + 16,"0.#",0);
                    if ((this.nowShowHero != null) &&
                       (lVar7 = this.nowShowHero.totalAddData) != null) {
                      local_res8[0] = (float)HeroSpeAddData.Get(lVar7,207,0);
                      uVar10 = Single.ToString(local_res8,"0.#",0);
                      uVar11 = String.Format(uVar11,uVar8,uVar10,
                                              *(uint64 *)(pStatics_38e8 + 0x2d0)
                                              ,0);
                      LTLocalization.SetText(uVar12,uVar11,0);
                      if ((((this.heroDetailPanel != null) &&
                           (lVar7 = GameObject.get_transform(this.heroDetailPanel,0), lVar7 != null
                           )) && (lVar7 = Transform.Find(lVar7,"Item",0)) != null) &&
                         ((lVar7 = Transform.Find(lVar7,"EquipmentWeight",0), lVar7 != null &&
                          (lVar7 = Transform.Find(lVar7,"Lv",0)) != null))) {
                        uVar12 = Component.GetComponent(lVar7,DAT_181e79538);
                        lVar7 = *(int64 *)(pStatics_38e8 + 0x600);
                        if (this.nowShowHero != null) {
                          uVar6 = HeroData.GetEquipmentWeightLv(this.nowShowHero,0);
                          if (lVar7 != null) {
                            if (lVar7.summonLv <= uVar6) {
                              ThrowHelper.ThrowArgumentOutOfRangeException(0);
                            }
                            LTLocalization.SetText
                                      (uVar12,*(uint64 *)
                                               (lVar7.isSummon + 32 +
                                               (int64)(int)uVar6 * 8),0);
                            if (((this.heroDetailPanel != null) &&
                                (lVar7 = GameObject.get_transform(this.heroDetailPanel,0),
                                lVar7 != null)) &&
                               ((lVar7 = Transform.Find(lVar7,"Item",0), lVar7 != null &&
                                ((lVar7 = Transform.Find(lVar7,"EquipmentWeight",0), lVar7 != null &&
                                 (lVar7 = Transform.Find(lVar7,"Lv",0)) != null))))) {
                              plVar13 = (int64 *)Component.GetComponent(lVar7,DAT_181e79538);
                              lVar7 = GameController.ChangeAllAreaStateIDs;
                              if (lVar7 != null) {
                                lVar7 = lVar7.dailyAIManaged;
                                lVar3 = GameController.ChangeAllAreaStateIDs;
                                if ((lVar3 != null) && (lVar3 = *(int64 *)(lVar3 + 56)) != null) {
                                  iVar14 = *(int *)(lVar3 + 24);
                                  if ((this.nowShowHero != null) &&
                                     (iVar5 = HeroData.GetEquipmentWeightLv
                                                        (this.nowShowHero,0), lVar7 != null)) {
                                    iVar14 = iVar14 - iVar5;
                                    if (lVar7.summonLv <= iVar14 - 1U) {
                                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                    }
                                    lVar7 = *(int64 *)
                                             (lVar7.isSummon + 24 + (int64)iVar14 * 8);
                                    if ((lVar7 != null) && (plVar13 != (int64 *)0)) {
                                      local_68 = lVar7.summonLv;
                                      uStack_64 = lVar7.summonMoveRange;
                                      uStack_60 = lVar7.summonControlable;
                                      uStack_5c = *(uint32 *)(lVar7 + 36);
                                      (**(code **)(*plVar13 + 0x2a8))
                                                (plVar13,&local_68,*(uint64 *)(*plVar13 + 0x2b0));
                                      if ((this.heroDetailPanel != null) &&
                                         ((((lVar7 = GameObject.get_transform
                                                               (this.heroDetailPanel,0),
                                            lVar7 != null &&
                                            (lVar7 = Transform.Find(lVar7,"Item",0)) != null)
                                           && (lVar7 = Transform.Find(lVar7,"EquipmentWeight",0)) != null
                                           ) && (lVar7 = Transform.Find(lVar7,"Icon",0),
                                                lVar7 != null)))) {
                                        lVar7 = Component.GetComponent(lVar7,DAT_181e788b8);
                                        if (this.nowShowHero != null) {
                                          iVar14 = HeroData.GetEquipmentWeightLv
                                                             (this.nowShowHero,0);
                                          uVar12 = "<b>{0}</b>\n速度x{1}%";
                                          lVar3 = *(int64 *)
                                                   (pStatics_38e8 + 0x600);
                                          if (lVar3 != null) {
                                            uVar11 = "超重";
                                            if (iVar14 != *(int *)(lVar3 + 24) + -1) {
                                              lVar3 = *(int64 *)
                                                       (pStatics_38e8 + 0x600);
                                              if (this.nowShowHero == null) throw; // [null/range check failed]
                                              uVar6 = HeroData.GetEquipmentWeightLv
                                                                (this.nowShowHero,0);
                                              if (lVar3 == null) throw; // [null/range check failed]
                                              if (*(uint32 *)(lVar3 + 24) <= uVar6) {
                                                ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                              }
                                              uVar11 = String.Concat(*(uint64 *)
                                                                       (*(int64 *)(lVar3 + 16) + 32
                                                                       + (int64)(int)uVar6 * 8),
                                                                      "装",0);
                                            }
                                            lVar3 = *(int64 *)
                                                     (pStatics_38e8 + 0x608);
                                            if (this.nowShowHero != null) {
                                              uVar6 = HeroData.GetEquipmentWeightLv
                                                                (this.nowShowHero,0);
                                              if (lVar3 != null) {
                                                if (*(uint32 *)(lVar3 + 24) <= uVar6) {
                                                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                                }
                                                local_res8[0] =
                                                     *(float *)(*(int64 *)(lVar3 + 16) + 32 +
                                                               (int64)(int)uVar6 * 4) * 100.0;
                                                uVar8 = Single.ToString(local_res8,"f0",0);
                                                uVar12 = String.Format(uVar12,uVar11,uVar8,0);
                                                if (lVar7 != null) {
                                                  lVar7.summonLv = uVar12;
                                                  il2cpp_internal((uint64 *)(lVar7 + 24),uVar12)
                                                  ;
                                                  if (((this.nowShowHero != null) &&
                                                      (lVar7 = *(int64 *)
                                                                (this.nowShowHero + 0x1f8),
                                                      lVar7 != null)) &&
                                                     (lVar7 = lVar7.summonControlable) != null) {
                                                    if (lVar7.summonLv == null) {
                                                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                                    }
                                                    uVar4 = local_res10;
                                                    HeroDetailController.RefreshEquipSlot
                                                              (this,0,
                                                               *(uint64 *)
                                                                (lVar7.isSummon + 32),
                                                               local_res10,0);
                                                    if (((this.nowShowHero != null) &&
                                                        (lVar7 = *(int64 *)
                                                                  (this.nowShowHero + 0x1f8),
                                                        lVar7 != null)) &&
                                                       (lVar7 = lVar7.dailyAIManaged) != null)
                                                    {
                                                      if (lVar7.summonLv == null) {
                                                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                                      }
                                                      HeroDetailController.RefreshEquipSlot
                                                                (this,1,
                                                                 *(uint64 *)
                                                                  (lVar7.isSummon + 32),
                                                                 uVar4,0);
                                                      if (((this.nowShowHero != null) &&
                                                          (lVar7 = *(int64 *)
                                                                    (this.nowShowHero + 0x1f8
                                                                    ), lVar7 != null)) &&
                                                         (lVar7 = lVar7.heroAISettingData) != null
                                                         ) {
                                                        if (lVar7.summonLv == null) {
                                                          ThrowHelper.ThrowArgumentOutOfRangeException(0)
                                                          ;
                                                        }
                                                        HeroDetailController.RefreshEquipSlot
                                                                  (this,2,
                                                                   *(uint64 *)
                                                                    (lVar7.isSummon + 32),
                                                                   uVar4,0);
                                                        if (((this.nowShowHero != null) &&
                                                            (lVar7 = *(int64 *)
                                                                      (this.nowShowHero +
                                                                      0x1f8), lVar7 != null)) &&
                                                           (lVar7 = lVar7.heroName,
                                                           lVar7 != null)) {
                                                          if (lVar7.summonLv == null) {
                                                            ThrowHelper.ThrowArgumentOutOfRangeException
                                                                      (0);
                                                          }
                                                          HeroDetailController.RefreshEquipSlot
                                                                    (this,3,
                                                                     *(uint64 *)
                                                                      (lVar7.isSummon + 32)
                                                                     ,uVar4,0);
                                                          if (((this.nowShowHero != null) &&
                                                              (lVar7 = *(int64 *)
                                                                        (this.nowShowHero +
                                                                        0x1f8), lVar7 != null)) &&
                                                             (lVar7 = lVar7.isFemale,
                                                             lVar7 != null)) {
                                                            if (lVar7.summonLv == null) {

                                                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                                        }
                                                        HeroDetailController.RefreshEquipSlot
                                                                  (this,4,
                                                                   *(uint64 *)
                                                                    (lVar7.isSummon + 32),
                                                                   uVar4,0);
                                                        if (((this.nowShowHero != null) &&
                                                            (lVar7 = *(int64 *)
                                                                      (this.nowShowHero +
                                                                      0x1f8), lVar7 != null)) &&
                                                           (lVar7 = lVar7.isFemale,
                                                           lVar7 != null)) {
                                                          if (lVar7.summonLv < 2) {
                                                            ThrowHelper.ThrowArgumentOutOfRangeException
                                                                      (0);
                                                          }
                                                          HeroDetailController.RefreshEquipSlot
                                                                    (this,5,
                                                                     *(uint64 *)
                                                                      (lVar7.isSummon + 40)
                                                                     ,uVar4,0);
                                                          if (this.nowShowHero != null) {
                                                            HeroDetailController.RefreshEquipSlot
                                                                      (this,6,
                                                                       *(uint64 *)
                                                                        (this.nowShowHero +
                                                                        0x208),uVar4,0);
                                                            if (this.nowShowHero != null) {
                                                              HeroDetailController.RefreshEquipSlot
                                                                        (this,7,
                                                                         *(uint64 *)
                                                                          (this.nowShowHero +
                                                                          0x218),uVar4,0);
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
    }

    // Token : 0x6001808
    // RVA   : 0xB1EBF0   Offset: 0xB1D9F0   Length: 0x2F0
    public void ShowEquipIcon(GameObject target, bool resetPos)
    {
        long lVar1;
        long lVar2;
        long lVar4;
        ulong uVar5;
        ulong uVar6;
        ulong local_28;
        uint local_20;
        byte[] local_18 = new byte[16];
        lVar1 = new c.DisplayClass9_0(0);
        if (lVar1 != null) {
          *(uint64 *)(lVar1 + 16) = target;
          if (*(int64 *)(lVar1 + 16) != 0) {
            GameObject.SetActive(*(int64 *)(lVar1 + 16),1,0);
            if (*(int64 *)(lVar1 + 16) != 0) {
              lVar2 = GameObject.get_transform(*(int64 *)(lVar1 + 16),0);
              puVar3 = (uint64 *)Vector3.get_one(local_18,0);
              if (lVar2 != null) {
                local_20 = *(uint32 *)(puVar3 + 1);
                local_28 = *puVar3;
                Transform.set_localScale(lVar2,&local_28,0);
                if ((*(int64 *)(lVar1 + 16) != 0) &&
                   (lVar2 = GameObject.GetComponent(*(int64 *)(lVar1 + 16),DAT_181e53ed0),
                   lVar2 != null)) {
                  CanvasGroup.set_alpha(lVar2,0x3f800000,0);
                  lVar2 = *(int64 *)(lVar1 + 16);
                  if (!resetPos) {
                    if ((lVar2 != null) &&
                       (lVar2 = GameObject.GetComponent(lVar2,DAT_181e53cb0)) != null) {
                      Selectable.set_interactable(lVar2,0,0);
                      if (*(int64 *)(lVar1 + 16) != 0) {
                        lVar2 = GameObject.get_transform(*(int64 *)(lVar1 + 16),0);
                        lVar4 = Camera.get_main(0);
                        puVar3 = (uint64 *)Input.get_mousePosition(local_18,0);
                        if (lVar4 != null) {
                          local_20 = *(uint32 *)(puVar3 + 1);
                          local_28 = *puVar3;
                          puVar3 = (uint64 *)Camera.ScreenToWorldPoint(local_18,lVar4,&local_28,0);
                          if (lVar2 != null) {
                            local_28 = *puVar3;
                            local_20 = *(uint32 *)(puVar3 + 1);
                            Transform.set_position(lVar2,&local_28,0);
                            if (*(int64 *)(lVar1 + 16) != 0) {
                              uVar5 = GameObject.get_transform(*(int64 *)(lVar1 + 16),0);
                              puVar3 = (uint64 *)Vector3.get_zero(local_18,0);
                              local_20 = *(uint32 *)(puVar3 + 1);
                              local_28 = *puVar3;
                              uVar5 = ShortcutExtensions.DOLocalMove(uVar5,&local_28,0x3f000000,0,0);
                              uVar5 = TweenSettingsExtensions.SetEase(uVar5,9,DAT_181ea4b88);
                              uVar6 = new OnTooltipCB(lVar1,DAT_181e891a0,0);
                              TweenSettingsExtensions.OnComplete(uVar5,uVar6,DAT_181ea3dc0);
                              return;
                            }
                          }
                        }
                      }
                    }
                  }
                  else if ((lVar2 != null) &&
                          (lVar1 = GameObject.GetComponent(lVar2,DAT_181e53cb0)) != null) {
                    Selectable.set_interactable(lVar1,1,0);
                    return;
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6001809
    // RVA   : 0xB20070   Offset: 0xB1EE70   Length: 0x1DE
    public void UnshowEquipIcon(GameObject target, bool resetPos)
    {
        long lVar1;
        ulong uVar2;
        long lVar3;
        ulong uVar4;
        lVar1 = new c.DisplayClass9_0(0);
        if (lVar1 != null) {
          *(uint64 *)(lVar1 + 16) = target;
          lVar3 = *(int64 *)(lVar1 + 16);
          if (!resetPos) {
            if (lVar3 != null) {
              uVar2 = GameObject.GetComponent(lVar3,DAT_181e53ed0);
              uVar2 = DOTweenModuleUI.DOFade(uVar2,0,0x3e800000,0);
              TweenSettingsExtensions.SetEase(uVar2,8,DAT_181ea49f0);
              if ((*(int64 *)(lVar1 + 16) != 0) &&
                 (lVar3 = GameObject.GetComponent(*(int64 *)(lVar1 + 16),DAT_181e53cb0)) != null
                 ) {
                Selectable.set_interactable(lVar3,0,0);
                if (*(int64 *)(lVar1 + 16) != 0) {
                  uVar2 = GameObject.get_transform(*(int64 *)(lVar1 + 16),0);
                  uVar2 = ShortcutExtensions.DOScale(uVar2,0x3fc00000,0x3e800000,0);
                  uVar2 = TweenSettingsExtensions.SetEase(uVar2,8,DAT_181ea4b88);
                  uVar4 = new OnTooltipCB(lVar1,DAT_181e89220,0);
                  TweenSettingsExtensions.OnComplete(uVar2,uVar4,DAT_181ea3dc0);
                  return;
                }
              }
            }
          }
          else if (lVar3 != null) {
            GameObject.SetActive(lVar3,0,0);
            return;
          }
        }
    }

    // Token : 0x600180A
    // RVA   : 0xB1CA00   Offset: 0xB1B800   Length: 0x724
    public void RefreshSkillList(bool resetPos)
    {
        bool cVar2;
        int iVar3;
        int iVar4;
        long lVar5;
        ulong uVar6;
        long lVar7;
        long lVar8;
        uint uVar9;
        uint uVar10;
        if ((this.skillGrid == null) ||
           (lVar5 = GameObject.get_transform(this.skillGrid,0)) == null) {
        LAB_180b1d11f:
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        iVar3 = Transform.get_childCount(lVar5,0);
        joined_r0x000180b1cac4:
        iVar3 = iVar3 + -1;
        if (-1 < iVar3) {
          if (((this.skillGrid != null) &&
              (lVar5 = GameObject.get_transform(this.skillGrid,0)) != null) &&
             (lVar5 = Transform.GetChild(lVar5,iVar3,0)) != null) {
            uVar6 = Component.GetComponent(lVar5,DAT_181e78e38);
            cVar2 = Object.op_Equality(uVar6,0);
            if (cVar2) goto LAB_180b1cc3b;
            if (this.nowShowHero != null) {
              lVar5 = this.nowShowHero.kungfuSkills;
              if (((this.skillGrid != null) &&
                  (lVar7 = GameObject.get_transform(this.skillGrid,0)) != null) &&
                 ((lVar7 = Transform.GetChild(lVar7,iVar3,0), lVar7 != null &&
                  ((lVar7 = Component.GetComponent(lVar7,DAT_181e78e38), lVar7 != null && (lVar5 != null))))))
              {
                cVar2 = FUN_18175e190(lVar5,*(uint64 *)(lVar7 + 32));
                if (!cVar2) goto LAB_180b1cc3b;
                if (((((this.skillGrid != null) &&
                      (lVar5 = GameObject.get_transform(this.skillGrid,0)) != null) &&
                     (lVar5 = Transform.GetChild(lVar5,iVar3,0)) != null) &&
                    ((lVar5 = Component.GetComponent(lVar5), lVar5 != null &&
                     (lVar5.summonControlable != null)))) &&
                   (lVar5 = KungfuSkillLvData.DataBase()) != null) goto code_r0x000180b1cc2f;
              }
            }
          }
          goto LAB_180b1d11f;
        }
        lVar5 = this.nowShowHero;
        uVar10 = 0;
        if (lVar5 == null) goto LAB_180b1d11f;
        lVar7 = 32;
        LAB_180b1cd20:
        if (lVar5.kungfuSkills != null) {
          if ((int)uVar10 < *(int *)(lVar5.kungfuSkills + 24)) {
            if ((lVar5 = lVar5?.kungfuSkills) != null) {
              if (lVar5.summonLv <= uVar10) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar5 = *(int64 *)(lVar7 + lVar5.isSummon);
              if ((lVar5 != null) && (lVar5 = KungfuSkillLvData.DataBase(lVar5,0)) != null) {
                if (lVar5.interestingStar == this.nowSkillListType) {
                  iVar3 = 0;
                  do {
                    if ((this.skillGrid == null) ||
                       (lVar5 = GameObject.get_transform(this.skillGrid,0)) == null)
                    goto LAB_180b1d11f;
                    iVar4 = Transform.get_childCount(lVar5,0);
                    lVar5 = this.skillGrid;
                    if (iVar4 <= iVar3) {
                      lVar8 = FUN_1802107e0(0);
                      if (lVar8 == null) goto LAB_180b1d11f;
                      uVar6 = *(uint64 *)(lVar8 + 168);
                      lVar5 = GlobalData.AddChild(lVar5,uVar6,0);
                      this.temp = lVar5;
                      if (*plVar1 == 0) goto LAB_180b1d11f;
                      lVar5 = GameObject.GetComponent(*plVar1,DAT_181e568c8);
                      if (((this.nowShowHero == null) ||
                          (lVar8 = this.nowShowHero.kungfuSkills) == null) ||
                         (uVar6 = FUN_1800024b0(lVar8,uVar10), lVar5 == null)) goto LAB_180b1d11f;
                      lVar5.summonControlable = uVar6;
                      goto LAB_180b1d012;
                    }
                    if (((lVar5 == null) || (lVar5 = GameObject.get_transform(lVar5,0)) == null) ||
                       (lVar5 = Transform.GetChild(lVar5,iVar3)) == null) goto LAB_180b1d11f;
                    uVar6 = Component.GetComponent(lVar5);
                    cVar2 = Object.op_Inequality(uVar6);
                    if (cVar2) {
                      if ((((this.skillGrid == null) ||
                           (lVar5 = GameObject.get_transform(this.skillGrid,0), lVar5 == null
                           )) || (lVar5 = Transform.GetChild(lVar5,iVar3,0)) == null) ||
                         (lVar5 = Component.GetComponent(lVar5,DAT_181e78e38)) == null)
                      goto LAB_180b1d11f;
                      lVar5 = lVar5.summonControlable;
                      if ((this.nowShowHero == null) ||
                         (this.nowShowHero.kungfuSkills == null)) goto LAB_180b1d11f;
                      lVar8 = FUN_1800024b0();
                      if (lVar5 == lVar8) goto LAB_180b1cebc;
                    }
                    iVar3 = iVar3 + 1;
                  } while( true );
                }
                goto LAB_180b1d072;
              }
            }
            goto LAB_180b1d11f;
          }
          HeroDetailController.ResetSkillSortType(this,0);
          if (resetPos) {
            if (((this.skillGrid == null) ||
                (lVar5 = GameObject.get_transform(this.skillGrid,0)) == null) ||
               ((lVar5 = FUN_180b05920(lVar5,0), lVar5 == null ||
                (((lVar5 = FUN_180b05920(lVar5,0), lVar5 == null ||
                  (lVar5 = Component.GetComponent(lVar5,DAT_181e78538)) == null) ||
                 (lVar5.heroAIDataArriveTargetRecord == null)))))) goto LAB_180b1d11f;
            Scrollbar.set_value(lVar5.heroAIDataArriveTargetRecord,0x3f800000,0);
          }
          return;
        }
        goto LAB_180b1d11f;
        code_r0x000180b1cc2f:
        if (lVar5.interestingStar != this.nowSkillListType) {
        LAB_180b1cc3b:
          if (((this.skillGrid == null) ||
              (lVar5 = GameObject.get_transform(this.skillGrid,0)) == null) ||
             ((lVar5 = Transform.GetChild(lVar5,iVar3,0), lVar5 == null ||
              (lVar5 = Component.get_gameObject(lVar5,0)) == null))) goto LAB_180b1d11f;
          GameObject.SetActive(lVar5,0);
          if (((this.skillGrid == null) ||
              (lVar5 = GameObject.get_transform(this.skillGrid,0)) == null) ||
             (lVar5 = Transform.GetChild(lVar5,iVar3,0)) == null) goto LAB_180b1d11f;
          uVar6 = Component.get_gameObject(lVar5);
          Object.Destroy(uVar6);
        }
        goto joined_r0x000180b1cac4;
        LAB_180b1cebc:
        if (((this.skillGrid == null) ||
            (lVar5 = GameObject.get_transform(this.skillGrid,0)) == null) ||
           (lVar5 = Transform.GetChild(lVar5,iVar3)) == null) goto LAB_180b1d11f;
        uVar6 = Component.get_gameObject(lVar5,0);
        this.temp = uVar6;
        if ((((this.skillGrid == null) ||
             (lVar5 = GameObject.get_transform(this.skillGrid,0)) == null) ||
            (lVar5 = Transform.GetChild(lVar5,iVar3)) == null) ||
           (lVar5 = Component.GetComponent(lVar5,DAT_181e78e38)) == null) goto LAB_180b1d11f;
        *(uint8 *)(lVar5 + 44) = 0;
        LAB_180b1d012:
        lVar5 = this.temp;
        if ((lVar5 == null) || (lVar5 = GameObject.GetComponent(lVar5,DAT_181e568c8)) == null)
        goto LAB_180b1d11f;
        lVar5.summonLv = uVar10;
        lVar5 = this.temp;
        if (lVar5 == null) goto LAB_180b1d11f;
        lVar5 = GameObject.GetComponent(lVar5,DAT_181e568c8);
        cVar2 = HeroDetailController.NowShowHeroItemControlable(this,0);
        uVar9 = 2;
        if (cVar2) {
          uVar9 = 0;
        }
        if (lVar5 == null) goto LAB_180b1d11f;
        lVar5.summonSourceHero = uVar9;
        LAB_180b1d072:
        lVar5 = this.nowShowHero;
        uVar10 = uVar10 + 1;
        lVar7 = lVar7 + 8;
        if (lVar5 == null) goto LAB_180b1d11f;
        goto LAB_180b1cd20;
    }

    // Token : 0x600180B
    // RVA   : 0xB0B0B0   Offset: 0xB09EB0   Length: 0x15D
    public void ChangeSkillSortType()
    {
        long lVar1;
        if (this.skillSortTypeDropDown != null) {
          this.skillSortType = *(uint32 *)(this.skillSortTypeDropDown + 0x120);
          if ((GameController._instance != null) &&
             (lVar1 = GameController._instance.worldData) != null) {
            lVar1.skillSortType = this.skillSortType;
            HeroDetailController.ResetSkillSortType(this,0);
            plVar2 = (int64 *)Resources.Load("Sound/SoundEffect/Armor",0);
            plVar3 = (int64 *)0;
            if ((plVar2 != (int64 *)0) && (*plVar2 == DAT_181e8f4a0)) {
              plVar3 = plVar2;
            }
            NGUITools.PlaySound(plVar3,0x3f19999a,0);
            return;
          }
        }
    }

    // Token : 0x600180C
    // RVA   : 0xB0AE60   Offset: 0xB09C60   Length: 0x243
    public void ChangeSkillReverseType(GameObject buttonClicked)
    {
        long lVar1;
        ulong uVar2;
        int iVar4;
        uint local_18;
        float local_14;
        uint local_10;
        this.reverseOrder = !this.reverseOrder;
        if (((GameController._instance != null) &&
            (lVar1 = GameController._instance.worldData) != null) &&
           (lVar1.skillReverseOrder = this.reverseOrder, buttonClicked != null)) {
          lVar1 = GameObject.get_transform(buttonClicked,0);
          if (lVar1 != null) {
            uVar2 = Transform.Find(lVar1,"Icon",0);
            iVar4 = -1;
            if (!this.reverseOrder) {
              iVar4 = 1;
            }
            local_18 = 0x3f800000;
            local_10 = 0x3f800000;
            local_14 = (float)iVar4;
            ShortcutExtensions.DOScale(uVar2,&local_18,0x3e4ccccd,0);
            lVar1 = GameObject.GetComponent(buttonClicked,DAT_181e56510);
            uVar2 = "升序";
            if (this.reverseOrder) {
              uVar2 = "降序";
            }
            if (lVar1 != null) {
              lVar1.cityAreaID = uVar2;
              HeroDetailController.ResetSkillSortType(this,0);
              plVar3 = (int64 *)Resources.Load("Sound/SoundEffect/Armor",0);
              plVar5 = (int64 *)0;
              if ((plVar3 != (int64 *)0) && (*plVar3 == DAT_181e8f4a0)) {
                plVar5 = plVar3;
              }
              NGUITools.PlaySound(plVar5,0x3f19999a,0);
              return;
            }
          }
        }
    }

    // Token : 0x600180D
    // RVA   : 0xB1D8C0   Offset: 0xB1C6C0   Length: 0x123
    public void ResetSkillSortType()
    {
        int iVar1;
        long lVar2;
        int iVar3;
        lVar2 = this.skillGrid;
        iVar3 = 0;
        if (lVar2 != null) {
          while (lVar2 = GameObject.get_transform(lVar2,0)) != null {
            iVar1 = Transform.get_childCount(lVar2,0);
            lVar2 = this.skillGrid;
            if (iVar1 <= iVar3) {
              GlobalData.SortChild(lVar2,0);
              return;
            }
            if ((((lVar2 == null) || (lVar2 = GameObject.get_transform(lVar2,0)) == null) ||
                (lVar2 = Transform.GetChild(lVar2,iVar3,0)) == null) ||
               (lVar2 = Component.GetComponent(lVar2,DAT_181e78e38)) == null) break;
            SkillIconController.AutoSetName
                      (lVar2,this.skillSortType,this.reverseOrder,0);
            lVar2 = this.skillGrid;
            iVar3 = iVar3 + 1;
            if (lVar2 == null) break;
          }
        }
    }

    // Token : 0x600180E
    // RVA   : 0xB0AD80   Offset: 0xB09B80   Length: 0xDD
    public void ChangeSkillListType(GameObject ButtonClicked)
    {
        int iVar1;
        int iVar2;
        ulong uVar3;
        iVar1 = this.nowSkillListType;
        if (ButtonClicked != null) {
          uVar3 = Object.get_name(ButtonClicked,0);
          iVar2 = Int32.Parse(uVar3,0);
          this.nowSkillListType = iVar2;
          if (iVar1 != iVar2) {
            HeroDetailController.RefreshSkillList(this,1,0);
            plVar4 = (int64 *)Resources.Load("Sound/SoundEffect/Button/TabButton",0);
            plVar5 = (int64 *)0;
            if ((plVar4 != (int64 *)0) && (*plVar4 == DAT_181e8f4a0)) {
              plVar5 = plVar4;
            }
            NGUITools.PlaySound(plVar5,0);
          }
          return;
        }
    }

    // Token : 0x600180F
    // RVA   : 0xB0BDB0   Offset: 0xB0ABB0   Length: 0x2F6
    public void ExchangeTeamButtonClicked()
    {
        long lVar1;
        bool cVar2;
        long lVar3;
        if (this.nowShowHero != null) {
          cVar2 = HeroData.ItemExchangeable(this.nowShowHero,0);
          if (!cVar2) {
            lVar1 = PlotController.fightSkillIndexCache;
            if ((GameController._instance != null) &&
               (lVar3 = GameController._instance.worldData) != null) {
              lVar3 = WorldData.Player(lVar3,0);
              if ((lVar3 != null) && ((this.nowShowHero != null && (lVar1 != null)))) {
                TradeUIController.ShowTradeUI
                          (lVar1,3,lVar3.speBookStorageSpeAdd,
                           this.nowShowHero.itemListData,0,0);
                return;
              }
            }
          }
          else {
            lVar1 = PlotController.fightSkillIndexCache;
            if ((GameController._instance != null) &&
               (lVar3 = GameController._instance.worldData) != null) {
              lVar3 = WorldData.Player(lVar3,0);
              if ((lVar3 != null) && ((this.nowShowHero != null && (lVar1 != null)))) {
                TradeUIController.ShowTradeUI
                          (lVar1,1,lVar3.speBookStorageSpeAdd,
                           this.nowShowHero.itemListData,0,0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x6001810
    // RVA   : 0xB14810   Offset: 0xB13610   Length: 0x20F
    public void LeaveTeamButtonClicked()
    {
        long lVar1;
        long lVar2;
        ulong uVar3;
        lVar1 = BuildingUIController.PartyLvName;
        if (lVar1 != null) {
          *(uint64 *)(lVar1 + 112) = this.nowShowHero;
          HeroDetailController.UnshowHeroDetail(this,0);
          lVar1 = BuildingUIController.PartyLvName;
          lVar2 = il2cpp_internal(DAT_181e77728);
          FUN_1810f3480(lVar2,DAT_181e861f0);
          if (lVar2 != null) {
            FUN_18175de30(lVar2,"后会有期;SureHeroLeaveTeam",DAT_181e86370);
            FUN_18175de30(lVar2,"开个玩笑;HideInteractUITemp",DAT_181e86370);
            uVar3 = new SinglePlotData("#PlayerName#已不需要我继续助阵了吗？",lVar2,0,0);
            if (lVar1 != null) {
              PlotController.ChangePlot(lVar1,uVar3,0);
              return;
            }
          }
        }
    }

    // Token : 0x6001811
    // RVA   : 0xB1FEF0   Offset: 0xB1ECF0   Length: 0x120
    public void TalkButtonClicked()
    {
        long lVar1;
        lVar1 = BuildingUIController.PartyLvName;
        if (lVar1 != null) {
          *(uint64 *)(lVar1 + 112) = this.nowShowHero;
          HeroDetailController.UnshowHeroDetail(this,0);
          lVar1 = BuildingUIController.PartyLvName;
          if (lVar1 != null) {
            PlotController.ChangeNormalMeetNpcPlot(lVar1,0);
            return;
          }
        }
    }

    // Token : 0x6001812
    // RVA   : 0xB147C0   Offset: 0xB135C0   Length: 0x43
    public void InterestingStartButtonClicked()
    {
        long lVar1;
        lVar1 = this.nowShowHero;
        if (lVar1 != null) {
          lVar1.interestingStar = !lVar1.interestingStar;
          if (this.nowShowHero != null) {
            HeroData.set_HeroIconDirty
                      (this.nowShowHero,CONCAT71((int7)((uint64)lVar1 >> 8),1),0);
            HeroDetailController.RefreshInterestingStar(this,0);
            return;
          }
        }
    }

    // Token : 0x6001813
    // RVA   : 0xB19400   Offset: 0xB18200   Length: 0x152
    public void RefreshInterestingStar()
    {
        long lVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        if (this.heroDetailPanel != null) {
          lVar2 = GameObject.get_transform(this.heroDetailPanel,0);
          if (lVar2 != null) {
            lVar2 = Transform.Find(lVar2,"InterestingStarButton",0);
            if (lVar2 != null) {
              lVar2 = Component.GetComponent(lVar2,DAT_181e777b8);
              uVar4 = "UIAtlas";
              lVar1 = **(int64 **)(DAT_181e8b8e8 + 184);
              if (this.nowShowHero != null) {
                uVar3 = "已收藏";
                if (!this.nowShowHero.interestingStar) {
                  uVar3 = "未收藏";
                }
                uVar3 = String.Concat("收藏-",uVar3,0);
                if (lVar1 != null) {
                  uVar4 = TextureController.LoadAtlasSprite(lVar1,uVar4,uVar3,0);
                  if (lVar2 != null) {
                    Image.set_sprite(lVar2,uVar4,0);
                    return;
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6001814
    // RVA   : 0xB0BA90   Offset: 0xB0A890   Length: 0x252
    public void DiscardButtonClicked()
    {
        long lVar1;
        ulong uVar2;
        long lVar3;
        lVar1 = PlotController.fightSkillIndexCache;
        if ((GameController._instance != null) &&
           (lVar3 = GameController._instance.worldData) != null) {
          lVar3 = WorldData.Player(lVar3,0);
          if (lVar3 != null) {
            uVar2 = lVar3.speBookStorageSpeAdd;
            lVar3 = PlotController.fightSkillIndexCache;
            if ((lVar3 != null) && (lVar1 != null)) {
              TradeUIController.ShowTradeUI(lVar1,1,uVar2,lVar3.forceMeetingStarted,0,0);
              plVar4 = (int64 *)Resources.Load("Sound/SoundEffect/Armor",0);
              plVar5 = (int64 *)0;
              if ((plVar4 != (int64 *)0) && (*plVar4 == DAT_181e8f4a0)) {
                plVar5 = plVar4;
              }
              NGUITools.PlaySound(plVar5,0);
              return;
            }
          }
        }
    }

    // Token : 0x6001815
    // RVA   : 0xB0AC80   Offset: 0xB09A80   Length: 0xFB
    public void ChangeClothButtonClicked()
    {
        bool cVar1;
        long lVar2;
        if (this.heroDetailPanel != null) {
          lVar2 = GameObject.get_transform(this.heroDetailPanel,0);
          if (lVar2 != null) {
            lVar2 = Transform.Find(lVar2,"ClothList",0);
            if (lVar2 != null) {
              lVar2 = Component.get_gameObject(lVar2,0);
              if (lVar2 != null) {
                cVar1 = GameObject.get_activeSelf(lVar2,0);
                HeroDetailController.SetClothList(this,!cVar1,0);
                plVar3 = (int64 *)Resources.Load("Sound/SoundEffect/Bag",0);
                plVar4 = (int64 *)0;
                if ((plVar3 != (int64 *)0) && (*plVar3 == DAT_181e8f4a0)) {
                  plVar4 = plVar3;
                }
                NGUITools.PlaySound(plVar4,0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x6001816
    // RVA   : 0xB0A640   Offset: 0xB09440   Length: 0x48B
    public GameObject AddClothChoice(int skinID, int skinLv)
    {
        long lVar1;
        long lVar2;
        ulong uVar4;
        ulong uVar5;
        long lVar6;
        int[] local_res8 = new int[2];
        ulong uVar7;
        uint[] local_38 = new uint[4];
        uint local_28;
        uint uStack_24;
        uint uStack_20;
        uint32 uStack_1c;
        uVar4 = this.clothGrid;
        uVar5 = this.clothChoicePrefab;
        lVar1 = GlobalData.AddChild(uVar4,uVar5,0);
        if (lVar1 != null) {
          lVar2 = GameObject.GetComponent(lVar1,DAT_181e54068);
          if (lVar2 != null) {
            *(int *)(lVar2 + 24) = skinID;
            lVar2 = GameObject.GetComponent(lVar1,DAT_181e54068);
            if (lVar2 != null) {
              *(uint32 *)(lVar2 + 28) = skinLv;
              lVar2 = GameObject.get_transform(lVar1,0);
              if (lVar2 != null) {
                lVar2 = Transform.Find(lVar2,"Icon",0);
                if (lVar2 != null) {
                  plVar3 = (int64 *)Component.GetComponent(lVar2,DAT_181e777b8);
                  lVar2 = GameController.ChangeAllAreaStateIDs;
                  if ((lVar2 != null) && (lVar2 = *(int64 *)(lVar2 + 56)) != null) {
                    if (*(uint32 *)(lVar2 + 24) <= skinLv) {
                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                    }
                    lVar2 = lVar2[skinLv]
                    ;
                    if ((lVar2 != null) && (plVar3 != (int64 *)0)) {
                      local_28 = *(uint32 *)(lVar2 + 24);
                      uStack_24 = *(uint32 *)(lVar2 + 28);
                      uStack_20 = *(uint32 *)(lVar2 + 32);
                      uStack_1c = *(uint32 *)(lVar2 + 36);
                      (**(code **)(*plVar3 + 0x2a8))(plVar3,&local_28,*(uint64 *)(*plVar3 + 0x2b0));
                      lVar2 = GameObject.get_transform(lVar1,0);
                      if (lVar2 != null) {
                        lVar2 = Transform.Find(lVar2,"Text",0);
                        if (lVar2 != null) {
                          uVar4 = Component.GetComponent(lVar2,DAT_181e79538);
                          lVar2 = GameController.ChangeAllAreaStateIDs;
                          if (lVar2 != null) {
                            lVar2 = GameDataController.FindSkinDataBase(lVar2,skinID,0);
                            if (lVar2 != null) {
                              uVar7 = 0;
                              uVar5 = SkinDataBase.GetSkinFullName(lVar2,skinLv,1,0,0);
                              LTLocalization.SetText(uVar4,uVar5,0);
                              lVar2 = GameObject.GetComponent(lVar1,DAT_181e56510);
                              lVar6 = GameController.ChangeAllAreaStateIDs;
                              if (lVar6 != null) {
                                lVar6 = GameDataController.FindSkinDataBase(lVar6,skinID,0);
                                if (lVar6 != null) {
                                  lVar6 = SkinDataBase.GetSkinSpeAdd(lVar6,skinLv,0);
                                  if (lVar6 != null) {
                                    uVar4 = HeroSpeAddData.GetDescribe
                                                      (lVar6,1,1,1,uVar7 & 0xffffffffffffff00,0);
                                    if (lVar2 != null) {
                                      *(uint64 *)(lVar2 + 24) = uVar4;
                                      local_res8[0] = skinID + 100;
                                      uVar4 = Int32.ToString(local_res8,"000",0);
                                      local_38[0] = skinLv;
                                      uVar5 = il2cpp_value_box(DAT_181e60808,local_38);
                                      uVar4 = String.Format("{0}_{1}",uVar4,uVar5,0);
                                      Object.set_name(lVar1,uVar4,0);
                                      return lVar1;
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

    // Token : 0x6001817
    // RVA   : 0xB13D40   Offset: 0xB12B40   Length: 0x160
    public void InitClothList()
    {
        long lVar1;
        int iVar2;
        int iVar3;
        this.clothListInited = 1;
        iVar3 = 0;
        while( true ) {
          lVar1 = *(int64 *)(*(int64 *)(DAT_181e528f8 + 184) + 32);
          if ((lVar1 == null) || (lVar1 = *(int64 *)(lVar1 + 0x1b8)) == null) break;
          if (*(int *)(lVar1 + 24) <= iVar3) {
            return;
          }
          iVar2 = 0;
          do {
            lVar1 = FUN_180210740(0);
            if (((lVar1 == null) || (*(int64 *)(lVar1 + 0x1b8) == 0)) ||
               (lVar1 = FUN_1800024b0(*(int64 *)(lVar1 + 0x1b8),iVar3,DAT_181e855b0)) == null)
            throw; // [null/range check failed]
            HeroDetailController.AddClothChoice(this,*(uint32 *)(lVar1 + 16),iVar2,0);
            iVar2 = iVar2 + 1;
          } while (iVar2 < 6);
          iVar3 = iVar3 + 1;
        }
    }

    // Token : 0x6001818
    // RVA   : 0xB1E1E0   Offset: 0xB1CFE0   Length: 0x318
    public void SetClothList(bool active)
    {
        ulong uVar1;
        long lVar2;
        int iVar3;
        int iVar4;
        if (!this.clothListInited) {
          this.clothListInited = 1;
          iVar4 = 0;
          while( true ) {
            lVar2 = *(int64 *)(*(int64 *)(DAT_181e528f8 + 184) + 32);
            if ((lVar2 == null) || (lVar2 = *(int64 *)(lVar2 + 0x1b8)) == null) break;
            if (*(int *)(lVar2 + 24) <= iVar4) goto LAB_180b1e397;
            iVar3 = 0;
            do {
              lVar2 = FUN_180210740(0);
              if (((lVar2 == null) || (*(int64 *)(lVar2 + 0x1b8) == 0)) ||
                 (lVar2 = FUN_1800024b0(*(int64 *)(lVar2 + 0x1b8),iVar4,DAT_181e855b0)) == null)
              throw; // [null/range check failed]
              HeroDetailController.AddClothChoice(this,*(uint32 *)(lVar2 + 16),iVar3,0);
              iVar3 = iVar3 + 1;
            } while (iVar3 < 6);
            iVar4 = iVar4 + 1;
          }
        }
        else {
        LAB_180b1e397:
          if ((((this.heroDetailPanel != null) &&
               (lVar2 = GameObject.get_transform(this.heroDetailPanel,0)) != null) &&
              (lVar2 = Transform.Find(lVar2,"ClothList",0)) != null) &&
             (lVar2 = Component.get_gameObject(lVar2,0)) != null) {
            GameObject.SetActive(lVar2,active,0);
            if (!active) {
              this.tempSkinID = 0xffffff9d;
              this.tempSkinLv = 0xffffff9d;
              this.tempHairID = 0xffffff9d;
              this.tempBeardID = 0xffffff9d;
              this.tempOtherID = 0xffffff9d;
              HeroDetailController.RefreshHeroSkeleton(this,0);
            }
            else {
              uVar1 = this.clothGrid;
              GlobalData.SortChild(uVar1,0);
              HeroDetailController.RefreshClothList(this,0);
              HeroDetailController.ResetFaceSetting(this,0);
              if (((this.heroDetailPanel == null) ||
                  (lVar2 = GameObject.get_transform(this.heroDetailPanel,0)) == null) ||
                 ((lVar2 = Transform.Find(lVar2,"ClothList",0), lVar2 == null ||
                  ((lVar2 = Transform.Find(lVar2,"SureButton",0), lVar2 == null ||
                   (lVar2 = Component.GetComponent(lVar2,DAT_181e76ab8)) == null)))))
              throw; // [null/range check failed]
              Selectable.set_interactable(lVar2,0,0);
            }
            return;
          }
        }
    }

    // Token : 0x6001819
    // RVA   : 0xB15D00   Offset: 0xB14B00   Length: 0xA0C
    public void RefreshClothList()
    {
        uint uVar1;
        bool cVar2;
        int iVar3;
        int iVar4;
        long lVar5;
        long lVar6;
        int iVar10;
        ulong local_58;
        uint local_50;
        byte[] local_48 = new byte[16];
        byte[] local_38 = new byte[16];
        uint local_28;
        uint uStack_24;
        uint uStack_20;
        uint32 uStack_1c;
        uint8 local_18 [16];
        lVar5 = this.clothGrid;
        iVar10 = 0;
        if (lVar5 != null) {
          while (lVar5 = GameObject.get_transform(lVar5,0)) != null {
            iVar3 = Transform.get_childCount(lVar5,0);
            if (iVar3 <= iVar10) {
              return;
            }
            lVar5 = FUN_1802106e0(0);
            if (lVar5 == null) break;
            lVar5 = *(int64 *)(lVar5 + 32);
            if ((((this.clothGrid == null) ||
                 (lVar6 = GameObject.get_transform(this.clothGrid,0)) == null) ||
                (lVar6 = Transform.GetChild(lVar6,iVar10,0)) == null) ||
               (lVar6 = Component.GetComponent(lVar6,DAT_181e76e38)) == null) break;
            uVar1 = *(uint32 *)(lVar6 + 24);
            if (((this.clothGrid == null) ||
                (lVar6 = GameObject.get_transform(this.clothGrid,0)) == null) ||
               ((lVar6 = Transform.GetChild(lVar6,iVar10,0), lVar6 == null ||
                ((lVar6 = Component.GetComponent(lVar6,DAT_181e76e38), lVar6 == null || (lVar5 == null))))))
            break;
            cVar2 = WorldData.SkinUnlocked(lVar5,uVar1,*(uint32 *)(lVar6 + 28),0);
            lVar5 = this.clothGrid;
            if (!cVar2) {
              if (((lVar5 == null) || (lVar5 = GameObject.get_transform(lVar5,0)) == null) ||
                 ((lVar5 = Transform.GetChild(lVar5,iVar10,0), lVar5 == null ||
                  (lVar5 = Component.get_gameObject(lVar5)) == null))) break;
              cVar2 = GameObject.get_activeSelf(lVar5);
              if (cVar2) {
                if ((this.clothGrid == null) ||
                   (lVar5 = GameObject.get_transform(this.clothGrid,0)) == null)
                break;
                lVar5 = Transform.GetChild(lVar5,iVar10,0);
        LAB_180b166b7:
                if ((lVar5 == null) || (lVar5 = Component.get_gameObject(lVar5)) == null) break;
                GameObject.SetActive(lVar5);
              }
            }
            else {
              if ((((lVar5 == null) || (lVar5 = GameObject.get_transform(lVar5,0)) == null) ||
                  (lVar5 = Transform.GetChild(lVar5,iVar10,0)) == null) ||
                 (lVar5 = Component.get_gameObject(lVar5,0)) == null) break;
              cVar2 = GameObject.get_activeSelf(lVar5,0);
              if (!cVar2) {
                if (((this.clothGrid == null) ||
                    (lVar5 = GameObject.get_transform(this.clothGrid,0)) == null) ||
                   (lVar5 = Transform.GetChild(lVar5,iVar10,0)) == null) break;
                lVar5 = Component.get_gameObject(lVar5,0);
                if (lVar5 == null) break;
                GameObject.SetActive(lVar5,1,0);
              }
              if (((this.clothGrid == null) ||
                  (lVar5 = GameObject.get_transform(this.clothGrid,0)) == null) ||
                 (lVar5 = Transform.GetChild(lVar5,iVar10,0)) == null) break;
              lVar5 = Component.GetComponent(lVar5,DAT_181e76ab8);
              if (this.nowShowHero == null) break;
              iVar3 = this.nowShowHero.heroForceLv;
              if ((((this.clothGrid == null) ||
                   (lVar6 = GameObject.get_transform(this.clothGrid,0)) == null) ||
                  (lVar6 = Transform.GetChild(lVar6,iVar10,0)) == null) ||
                 ((lVar6 = Component.GetComponent(lVar6,DAT_181e76e38), lVar6 == null || (lVar5 == null))))
              break;
              Selectable.set_interactable(lVar5,*(int *)(lVar6 + 28) <= iVar3,0);
              if ((this.clothGrid == null) ||
                 ((lVar5 = GameObject.get_transform(this.clothGrid,0), lVar5 == null ||
                  (lVar5 = Transform.GetChild(lVar5,iVar10,0)) == null))) break;
              lVar5 = Transform.Find(lVar5,"Equip",0);
              if (this.nowShowHero == null) break;
              iVar3 = this.nowShowHero.skinID;
              if ((((this.clothGrid == null) ||
                   (lVar6 = GameObject.get_transform(this.clothGrid,0)) == null) ||
                  (lVar6 = Transform.GetChild(lVar6,iVar10,0)) == null) ||
                 (lVar6 = Component.GetComponent(lVar6,DAT_181e76e38)) == null) break;
              if (iVar3 == *(int *)(lVar6 + 24)) {
                if (this.nowShowHero == null) break;
                iVar3 = this.nowShowHero.skinLv;
                if (((this.clothGrid == null) ||
                    (lVar6 = GameObject.get_transform(this.clothGrid,0)) == null) ||
                   ((lVar6 = Transform.GetChild(lVar6,iVar10,0), lVar6 == null ||
                    (lVar6 = Component.GetComponent(lVar6,DAT_181e76e38)) == null))) break;
                if (iVar3 == *(int *)(lVar6 + 28))
                {
                  puVar7 = (uint64 *)Vector3.get_one(local_48,0);
                  }
                  else {
                }
                puVar7 = (uint64 *)Vector3.get_zero(local_38,0);
              }
              if (lVar5 == null) break;
              local_58 = *puVar7;
              local_50 = *(uint32 *)(puVar7 + 1);
              Transform.set_localScale(lVar5,&local_58,0);
              iVar3 = this.tempSkinID;
              if (iVar3 == -99) {
                if (this.nowShowHero == null) break;
                iVar3 = this.nowShowHero.skinID;
              }
              if (((this.clothGrid == null) ||
                  (lVar5 = GameObject.get_transform(this.clothGrid,0)) == null) ||
                 ((lVar5 = Transform.GetChild(lVar5,iVar10,0), lVar5 == null ||
                  (lVar5 = Component.GetComponent(lVar5,DAT_181e76e38)) == null))) break;
              if (iVar3 == *(int *)(lVar5 + 24)) {
                iVar3 = this.tempSkinLv;
                if (iVar3 == -99) {
                  if (this.nowShowHero == null) break;
                  iVar3 = this.nowShowHero.skinLv;
                }
                if ((((this.clothGrid == null) ||
                     (lVar5 = GameObject.get_transform(this.clothGrid,0)) == null) ||
                    (lVar5 = Transform.GetChild(lVar5,iVar10,0)) == null) ||
                   (lVar5 = Component.GetComponent(lVar5,DAT_181e76e38)) == null) break;
                if (iVar3 != *(int *)(lVar5 + 28)) goto LAB_180b16388;
                if (((this.clothGrid == null) ||
                    (lVar5 = GameObject.get_transform(this.clothGrid,0)) == null) ||
                   (lVar5 = Transform.GetChild(lVar5,iVar10,0)) == null) break;
                plVar8 = (int64 *)Component.GetComponent(lVar5,DAT_181e777b8);
                lVar5 = *(int64 *)(DAT_181e538e8 + 184);
                if (plVar8 == (int64 *)0) break;
                local_28 = *(uint32 *)(lVar5 + 0x380);
                uStack_24 = *(uint32 *)(lVar5 + 900);
                uStack_20 = *(uint32 *)(lVar5 + 0x388);
                uStack_1c = *(uint32 *)(lVar5 + 0x38c);
                (**(code **)(*plVar8 + 0x2a8))(plVar8,&local_28);
              }
              else {
        LAB_180b16388:
                if (((this.clothGrid == null) ||
                    (lVar5 = GameObject.get_transform(this.clothGrid,0)) == null) ||
                   (lVar5 = Transform.GetChild(lVar5,iVar10,0)) == null) break;
                plVar8 = (int64 *)Component.GetComponent(lVar5,DAT_181e777b8);
                puVar9 = (uint32 *)FUN_180f24d00(local_18,0);
                if (plVar8 == (int64 *)0) break;
                local_28 = *puVar9;
                uStack_24 = puVar9[1];
                uStack_20 = puVar9[2];
                uStack_1c = puVar9[3];
                (**(code **)(*plVar8 + 0x2a8))(plVar8,&local_28);
              }
              if ((((this.clothGrid == null) ||
                   (lVar5 = GameObject.get_transform(this.clothGrid,0)) == null) ||
                  (lVar5 = Transform.GetChild(lVar5,iVar10,0)) == null) ||
                 (lVar5 = Component.GetComponent(lVar5,DAT_181e76e38)) == null) break;
              iVar3 = *(int *)(lVar5 + 24);
              if (this.nowShowHero == null) break;
              iVar4 = HeroData.GetDefaultSkinID(this.nowShowHero,0);
              if (iVar3 == iVar4) {
                if (((this.clothGrid == null) ||
                    (lVar5 = GameObject.get_transform(this.clothGrid,0)) == null) ||
                   ((lVar5 = Transform.GetChild(lVar5,iVar10,0), lVar5 == null ||
                    ((lVar5 = Component.GetComponent(lVar5,DAT_181e76e38), lVar5 == null ||
                     (this.nowShowHero == null)))))) break;
                if (*(int *)(lVar5 + 28) == this.nowShowHero.heroForceLv) {
                  if ((((this.clothGrid == null) ||
                       (lVar5 = GameObject.get_transform(this.clothGrid,0)) == null)
                      || (lVar5 = Transform.GetChild(lVar5,iVar10,0)) == null) ||
                     ((lVar5 = Transform.Find(lVar5,"Default"), lVar5 == null ||
                      (lVar5 = Component.get_gameObject(lVar5,0)) == null))) break;
                  cVar2 = GameObject.get_activeSelf(lVar5,0);
                  if (!cVar2) {
                    if (((this.clothGrid == null) ||
                        (lVar5 = GameObject.get_transform(this.clothGrid,0)) == null)
                       || ((lVar5 = Transform.GetChild(lVar5,iVar10,0), lVar5 == null ||
                           (lVar5 = Transform.Find(lVar5,"Default")) == null))) break;
                    lVar5 = Component.get_gameObject(lVar5,0);
                    if (lVar5 == null) break;
                    GameObject.SetActive(lVar5,1);
                  }
                  if (((this.clothGrid != null) &&
                      (lVar5 = GameObject.get_transform(this.clothGrid,0)) != null) &&
                     (lVar5 = Transform.GetChild(lVar5,iVar10,0)) != null) {
                    Transform.SetAsFirstSibling(lVar5);
                    goto LAB_180b166d8;
                  }
                  break;
                }
              }
              if (((this.clothGrid == null) ||
                  (lVar5 = GameObject.get_transform(this.clothGrid,0)) == null) ||
                 ((lVar5 = Transform.GetChild(lVar5,iVar10,0), lVar5 == null ||
                  ((lVar5 = Transform.Find(lVar5), lVar5 == null ||
                   (lVar5 = Component.get_gameObject(lVar5)) == null))))) break;
              cVar2 = GameObject.get_activeSelf(lVar5);
              if (cVar2) {
                if (((this.clothGrid != null) &&
                    (lVar5 = GameObject.get_transform(this.clothGrid,0)) != null) &&
                   (lVar5 = Transform.GetChild(lVar5,iVar10,0)) != null) {
                  lVar5 = Transform.Find(lVar5);
                  goto LAB_180b166b7;
                }
                break;
              }
            }
        LAB_180b166d8:
            lVar5 = this.clothGrid;
            iVar10 = iVar10 + 1;
            if (lVar5 == null) break;
          }
        }
    }

    // Token : 0x600181A
    // RVA   : 0xB0B210   Offset: 0xB0A010   Length: 0x4A8
    public void ClothChoiceButtonClicked(int skinID, int skinLv)
    {
        long lVar1;
        ulong uVar2;
        long lVar3;
        lVar1 = this.nowShowHero;
        if (lVar1 != null) {
          if (lVar1.heroForceLv < (int)skinLv) {
            lVar1 = GameController._instance;
            lVar3 = *(int64 *)(*(int64 *)(DAT_181e538e8 + 184) + 0x3e0);
            if (lVar3 == null) throw; // [null/range check failed]
            if (*(uint32 *)(lVar3 + 24) <= skinLv) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            uVar2 = String.Format("角色等级未达{0}！",
                                   *(uint64 *)
                                    (*(int64 *)(lVar3 + 16) + 32 + (int64)(int)skinLv * 8),0);
          }
          else {
            if ((skinID != 10) || (!lVar1.isFemale)) {
              plVar4 = (int64 *)Resources.Load("Sound/SoundEffect/Bag",0);
              plVar5 = (int64 *)0;
              if ((plVar4 != (int64 *)0) && (plVar5 = (int64 *)0, *plVar4 == DAT_181e8f4a0)) {
                plVar5 = plVar4;
              }
              NGUITools.PlaySound(plVar5,0);
              this.tempSkinLv = skinLv;
              lVar1 = this.nowShowHero;
              this.tempSkinID = skinID;
              if (((this.heroDetailPanel != null) &&
                  (lVar3 = GameObject.get_transform(this.heroDetailPanel,0)) != null) &&
                 (uVar2 = Transform.Find(lVar3,"Face",0), lVar1 != null)) {
                HeroData.SetSkeletonGraphic
                          (lVar1,uVar2,this.tempSkinID,this.tempSkinLv,0);
                HeroDetailController.RefreshClothList(this,0);
                HeroDetailController.ResetFaceSetting(this,0);
                lVar1 = this.nowShowHero;
                if (lVar1 != null) {
                  if ((this.tempSkinID == lVar1.skinID) &&
                     (this.tempSkinLv == lVar1.skinLv)) {
                    if ((((this.heroDetailPanel != null) &&
                         (lVar1 = GameObject.get_transform(this.heroDetailPanel,0)) != null)
                        && (lVar1 = Transform.Find(lVar1,"ClothList",0)) != null) &&
                       ((lVar1 = Transform.Find(lVar1,"SureButton",0), lVar1 != null &&
                        (lVar1 = Component.GetComponent(lVar1,DAT_181e76ab8)) != null))) {
                      Selectable.set_interactable(lVar1,0,0);
                      return;
                    }
                  }
                  else if ((((this.heroDetailPanel != null) &&
                            ((lVar1 = GameObject.get_transform(this.heroDetailPanel,0),
                             lVar1 != null && (lVar1 = Transform.Find(lVar1,"ClothList",0)) != null)))
                           && (lVar1 = Transform.Find(lVar1,"SureButton",0)) != null) &&
                          (lVar1 = Component.GetComponent(lVar1,DAT_181e76ab8)) != null) {
                    Selectable.set_interactable(lVar1,1,0);
                    return;
                  }
                }
              }
              throw; // [null/range check failed]
            }
            lVar1 = FUN_1802106e0(0);
            uVar2 = FUN_1800020e0(DAT_181e6dc98);
            uVar2 = String.Format("女性角色无法穿着！",uVar2,0);
          }
          if (lVar1 != null) {
            GameController.ShowTextOnMouse(lVar1,uVar2,0);
            plVar4 = (int64 *)Resources.Load("Sound/SoundEffect/WrongClick",0);
            plVar5 = (int64 *)0;
            if ((plVar4 != (int64 *)0) && (*plVar4 == DAT_181e8f4a0)) {
              plVar5 = plVar4;
            }
            NGUITools.PlaySound(plVar5,0);
            return;
          }
        }
    }

    // Token : 0x600181B
    // RVA   : 0xB1D130   Offset: 0xB1BF30   Length: 0x783
    public void ResetFaceSetting()
    {
        var pStatics = *(int64*)(DAT_181e538e8 + 184);
        bool cVar1;
        long lVar2;
        long lVar3;
        ulong uVar4;
        long lVar5;
        int[] local_res8 = new int[2];
        if ((((this.heroDetailPanel != null) &&
             (lVar2 = GameObject.get_transform(this.heroDetailPanel,0)) != null) &&
            (lVar2 = Transform.Find(lVar2,"ClothList",0)) != null) &&
           (lVar2 = Transform.Find(lVar2,"FaceSetting",0)) != null) {
          lVar3 = Component.get_gameObject(lVar2,0);
          lVar2 = this.nowShowHero;
          if (lVar2 != null) {
            if ((lVar2.heroID == null) || (!lVar2.speHero)) {
              if (lVar3 != null) {
                GameObject.SetActive(lVar3,1,0);
                lVar2 = this.nowShowHero;
                local_res8[0] = 0;
                do {
                  if (((lVar2 == null) || (lVar2.faceData == null)) ||
                     (lVar2 = *(int64 *)(lVar2.faceData + 16)) == null) break;
                  if (lVar2.summonLv <= local_res8[0]) {
                    return;
                  }
                  lVar2 = *(int64 *)(pStatics + 0x1e8);
                  if (lVar2 == null) break;
                  uVar4 = FUN_1800024b0(lVar2,local_res8[0],DAT_181e86970);
                  cVar1 = String.op_Inequality(uVar4,"发后",0);
                  if (cVar1) {
                    lVar2 = GameObject.get_transform(lVar3,0);
                    uVar4 = Int32.ToString(local_res8,0);
                    if (lVar2 == null) break;
                    uVar4 = Transform.Find(lVar2,uVar4,0);
                    cVar1 = Object.op_Inequality(uVar4,0,0);
                    if (cVar1) {
                      if (this.nowShowHero == null) break;
                      if (!this.nowShowHero.isFemale) {
        LAB_180b1d4a3:
                        lVar2 = *(int64 *)(pStatics + 0x1e8);
                        if (lVar2 == null) break;
                        uVar4 = FUN_1800024b0(lVar2,local_res8[0],DAT_181e86970);
                        cVar1 = FUN_1816387f0(uVar4,"胡",0);
                        if (cVar1) {
                          lVar2 = GameObject.get_transform(lVar3,0);
                          uVar4 = Int32.ToString(local_res8,0);
                          if (((lVar2 == null) || (lVar2 = Transform.Find(lVar2,uVar4,0)) == null) ||
                             (lVar2 = Component.GetComponent(lVar2,DAT_181e78f38)) == null) break;
                          Selectable.set_interactable(lVar2,1,0);
                        }
                        lVar2 = GameObject.get_transform(lVar3,0);
                        uVar4 = Int32.ToString(local_res8,0);
                        if ((lVar2 == null) || (lVar2 = Transform.Find(lVar2,uVar4,0)) == null) break;
                        lVar2 = Component.GetComponent(lVar2,DAT_181e78f38);
                        if (this.nowShowHero == null) break;
                        if (!this.nowShowHero.isFemale) {
                          lVar5 = FUN_180210740(0);
                          if (lVar5 == null) break;
                          lVar5 = *(int64 *)(lVar5 + 0x168);
                        }
                        else {
                          lVar5 = FUN_180210740(0);
                          if (lVar5 == null) break;
                          lVar5 = *(int64 *)(lVar5 + 0x170);
                        }
                        if (((lVar5 == null) || (*(int64 *)(lVar5 + 16) == 0)) ||
                           (FUN_180002480(*(int64 *)(lVar5 + 16),local_res8[0],DAT_181e71bf0),
                           lVar2 == null)) break;
                        Slider.set_maxValue(lVar2);
                        lVar2 = *(int64 *)(pStatics + 0x1e8);
                        if (lVar2 == null) break;
                        uVar4 = FUN_1800024b0(lVar2,local_res8[0],DAT_181e86970);
                        cVar1 = FUN_1816387f0(uVar4,"胡",0);
                        if (!cVar1) {
                          lVar2 = *(int64 *)(pStatics + 0x1e8);
                          if (lVar2 == null) break;
                          uVar4 = FUN_1800024b0(lVar2,local_res8[0],DAT_181e86970);
                          cVar1 = FUN_1816387f0(uVar4,"发",0);
                          if (!cVar1) {
                            lVar2 = *(int64 *)(pStatics + 0x1e8);
                            if (lVar2 == null) break;
                            uVar4 = FUN_1800024b0(lVar2,local_res8[0],DAT_181e86970);
                            cVar1 = FUN_1816387f0(uVar4,"杂",0);
                            if (!cVar1) goto LAB_180b1d801;
                          }
                        }
                        lVar2 = GameObject.get_transform(lVar3,0);
                        uVar4 = Int32.ToString(local_res8,0);
                        if (((lVar2 == null) || (lVar2 = Transform.Find(lVar2,uVar4,0)) == null) ||
                           (lVar2 = Component.GetComponent(lVar2,DAT_181e78f38)) == null) break;
                        Slider.set_minValue(lVar2);
                      }
                      else {
                        lVar2 = *(int64 *)(pStatics + 0x1e8);
                        if (lVar2 == null) break;
                        uVar4 = FUN_1800024b0(lVar2,local_res8[0],DAT_181e86970);
                        cVar1 = FUN_1816387f0(uVar4,"胡",0);
                        if (!cVar1) goto LAB_180b1d4a3;
                        lVar2 = GameObject.get_transform(lVar3,0);
                        uVar4 = Int32.ToString(local_res8,0);
                        if (((lVar2 == null) || (lVar2 = Transform.Find(lVar2,uVar4,0)) == null) ||
                           (lVar2 = Component.GetComponent(lVar2,DAT_181e78f38)) == null) break;
                        Selectable.set_interactable(lVar2,0,0);
                      }
        LAB_180b1d801:
                      lVar2 = GameObject.get_transform(lVar3,0);
                      uVar4 = Int32.ToString(local_res8,0);
                      if ((lVar2 == null) || (lVar2 = Transform.Find(lVar2,uVar4,0)) == null) break;
                      plVar6 = (int64 *)Component.GetComponent(lVar2,DAT_181e78f38);
                      if ((this.nowShowHero == null) ||
                         (((lVar2 = this.nowShowHero.faceData, lVar2 == null ||
                           (lVar2 = lVar2.isSummon) == null) ||
                          (FUN_180002480(lVar2,local_res8[0],DAT_181e71bf0), plVar6 == (int64 *)0))))
                      break;
                      lVar2 = *plVar6;
                      (**(code **)(lVar2 + 0x428))(plVar6,lVar2,*(uint64 *)(lVar2 + 0x430));
                    }
                  }
                  lVar2 = this.nowShowHero;
                  local_res8[0] = local_res8[0] + 1;
                } while( true );
              }
            }
            else if (lVar3 != null) {
              GameObject.SetActive(lVar3,0,0);
              return;
            }
          }
        }
    }

    // Token : 0x600181C
    // RVA   : 0xB0C0B0   Offset: 0xB0AEB0   Length: 0x62F
    public void FaceSliderChanged(GameObject target)
    {
        int iVar1;
        ulong uVar2;
        long lVar4;
        ulong uVar5;
        long lVar6;
        float fVar7;
        uint[] local_res10 = new uint[2];
        if (target == null) throw; // [null/range check failed]
        uVar2 = Object.get_name(target,0);
        iVar1 = Int32.Parse(uVar2,0);
        if (iVar1 == 3) {
          plVar3 = (int64 *)GameObject.GetComponent(target,DAT_181e569d8);
          if (plVar3 == (int64 *)0) throw; // [null/range check failed]
          fVar7 = (float)(**(code **)(*plVar3 + 0x418))(plVar3,*(uint64 *)(*plVar3 + 0x420));
          this.tempHairID = (int)fVar7;
        }
        else if (iVar1 == 7) {
          plVar3 = (int64 *)GameObject.GetComponent(target,DAT_181e569d8);
          if (plVar3 == (int64 *)0) throw; // [null/range check failed]
          fVar7 = (float)(**(code **)(*plVar3 + 0x418))(plVar3,*(uint64 *)(*plVar3 + 0x420));
          this.tempBeardID = (int)fVar7;
        }
        else if (iVar1 == 8) {
          plVar3 = (int64 *)GameObject.GetComponent(target,DAT_181e569d8);
          if (plVar3 == (int64 *)0) throw; // [null/range check failed]
          fVar7 = (float)(**(code **)(*plVar3 + 0x418))(plVar3,*(uint64 *)(*plVar3 + 0x420));
          this.tempOtherID = (int)fVar7;
        }
        lVar4 = GameObject.get_transform(target,0);
        if (lVar4 == null) {
        LAB_180b0c6da:
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        lVar4 = Transform.Find(lVar4,"Id",0);
        if (lVar4 == null) goto LAB_180b0c6da;
        uVar2 = Component.GetComponent(lVar4,DAT_181e79538);
        plVar3 = (int64 *)GameObject.GetComponent(target,DAT_181e569d8);
        if (plVar3 == (int64 *)0) goto LAB_180b0c6da;
        local_res10[0] = (**(code **)(*plVar3 + 0x418))(plVar3,*(uint64 *)(*plVar3 + 0x420));
        uVar5 = il2cpp_value_box(DAT_181e82730,local_res10);
        uVar5 = String.Format("({0})",uVar5,0);
        LTLocalization.SetText(uVar2,uVar5,0);
        lVar4 = this.nowShowHero;
        if (this.heroDetailPanel == null) goto LAB_180b0c6da;
        lVar6 = GameObject.get_transform(this.heroDetailPanel,0);
        if (lVar6 == null) goto LAB_180b0c6da;
        uVar2 = Transform.Find(lVar6,"Face",0);
        if (lVar4 == null) goto LAB_180b0c6da;
        uVar2 = HeroData.GetSkeletonGraphic(lVar4,uVar2,0);
        plVar3 = (int64 *)GameObject.GetComponent(target,DAT_181e569d8);
        if (plVar3 == (int64 *)0) goto LAB_180b0c6da;
        fVar7 = (float)(**(code **)(*plVar3 + 0x418))(plVar3,*(uint64 *)(*plVar3 + 0x420));
        HeroData.SetSkeletonGraphicFaceSlot(lVar4,uVar2,iVar1,(int)fVar7,0);
        if (iVar1 == 3) {
          lVar4 = this.nowShowHero;
          if (this.heroDetailPanel == null) throw; // [null/range check failed]
          lVar6 = GameObject.get_transform(this.heroDetailPanel,0);
          if (lVar6 == null) throw; // [null/range check failed]
          uVar2 = Transform.Find(lVar6,"Face",0);
          if (lVar4 == null) throw; // [null/range check failed]
          uVar2 = HeroData.GetSkeletonGraphic(lVar4,uVar2,0);
          plVar3 = (int64 *)GameObject.GetComponent(target,DAT_181e569d8);
          if (plVar3 == (int64 *)0) throw; // [null/range check failed]
          fVar7 = (float)(**(code **)(*plVar3 + 0x418))(plVar3,*(uint64 *)(*plVar3 + 0x420));
          HeroData.SetSkeletonGraphicFaceSlot(lVar4,uVar2,6,(int)fVar7,0);
        }
        iVar1 = this.tempHairID;
        if (((this.nowShowHero == null) ||
            (lVar4 = this.nowShowHero.faceData) == null) ||
           (lVar4 = lVar4.isSummon) == null) throw; // [null/range check failed]
        if (lVar4.summonLv < 4) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        if (iVar1 == *(int *)(lVar4.isSummon + 44)) {
          iVar1 = this.tempBeardID;
          if (((this.nowShowHero == null) ||
              (lVar4 = this.nowShowHero.faceData) == null) ||
             (lVar4 = lVar4.isSummon) == null) throw; // [null/range check failed]
          if (lVar4.summonLv < 7) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          if (iVar1 != *(int *)(lVar4.isSummon + 56)) goto LAB_180b0c593;
          iVar1 = this.tempOtherID;
          if (((this.nowShowHero == null) ||
              (lVar4 = this.nowShowHero.faceData) == null) ||
             (lVar4 = lVar4.isSummon) == null) throw; // [null/range check failed]
          if (lVar4.summonLv < 8) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          if (iVar1 != *(int *)(lVar4.isSummon + 60)) goto LAB_180b0c593;
          if (this.heroDetailPanel == null) throw; // [null/range check failed]
          lVar4 = GameObject.get_transform(this.heroDetailPanel,0);
          if (lVar4 == null) throw; // [null/range check failed]
          lVar4 = Transform.Find(lVar4,"ClothList",0);
          if (lVar4 == null) throw; // [null/range check failed]
          lVar4 = Transform.Find(lVar4,"SureButton",0);
          if (lVar4 == null) throw; // [null/range check failed]
          lVar4 = Component.GetComponent(lVar4,DAT_181e76ab8);
          if (lVar4 == null) throw; // [null/range check failed]
          uVar2 = 0;
        }
        else {
        LAB_180b0c593:
          if (this.heroDetailPanel == null) throw; // [null/range check failed]
          lVar4 = GameObject.get_transform(this.heroDetailPanel,0);
          if (lVar4 == null) throw; // [null/range check failed]
          lVar4 = Transform.Find(lVar4,"ClothList",0);
          if (lVar4 == null) throw; // [null/range check failed]
          lVar4 = Transform.Find(lVar4,"SureButton",0);
          if (lVar4 == null) throw; // [null/range check failed]
          lVar4 = Component.GetComponent(lVar4,DAT_181e76ab8);
          if (lVar4 == null) throw; // [null/range check failed]
          uVar2 = 1;
        }
        Selectable.set_interactable(lVar4,uVar2,0);
        lVar4 = *(int64 *)(*(int64 *)(DAT_181e528f8 + 184) + 32);
        if (lVar4 != null) {
          uVar2 = lVar4.horse;
          NGUITools.PlaySound(uVar2,0x3e4ccccd,0);
          return;
        }
    }

    // Token : 0x600181D
    // RVA   : 0xB1F720   Offset: 0xB1E520   Length: 0x3A2
    public void SureChangeNowShowHeroCloth()
    {
        var pStatics = *(int64*)(DAT_181e569c8 + 184);
        long lVar1;
        long lVar2;
        ulong uVar3;
        bool cVar4;
        int iVar5;
        uint uVar7;
        if (this.nowShowHero == null) throw; // [null/range check failed]
        this.nowShowHero.playerSetSkin = 1;
        if ((this.tempSkinID != -99) && (this.tempSkinLv != -99)) {
          if (this.nowShowHero == null) throw; // [null/range check failed]
          this.nowShowHero.setSkinID = this.tempSkinID;
          if (this.nowShowHero == null) throw; // [null/range check failed]
          this.nowShowHero.setSkinLv = this.tempSkinLv;
          if (this.nowShowHero == null) throw; // [null/range check failed]
          HeroData.SetSkin(this.nowShowHero,this.tempSkinID,
                            this.tempSkinLv,0);
        }
        if (this.tempHairID != -99) {
          if (((this.nowShowHero == null) ||
              (lVar1 = this.nowShowHero.faceData) == null) ||
             (lVar1 = lVar1.isSummon) == null) throw; // [null/range check failed]
          FUN_181774110(lVar1,3,this.tempHairID,DAT_181e71cf0);
          if (((this.nowShowHero == null) ||
              (lVar1 = this.nowShowHero.faceData) == null) ||
             (lVar1 = lVar1.isSummon) == null) throw; // [null/range check failed]
          FUN_181774110(lVar1,6,this.tempHairID,DAT_181e71cf0);
        }
        if (this.tempBeardID != -99) {
          if (((this.nowShowHero == null) ||
              (lVar1 = this.nowShowHero.faceData) == null) ||
             (lVar1 = lVar1.isSummon) == null) throw; // [null/range check failed]
          FUN_181774110(lVar1,7,this.tempBeardID,DAT_181e71cf0);
        }
        if (this.tempOtherID != -99) {
          if (((this.nowShowHero == null) ||
              (lVar1 = this.nowShowHero.faceData) == null) ||
             (lVar1 = lVar1.isSummon) == null) throw; // [null/range check failed]
          FUN_181774110(lVar1,8,this.tempOtherID,DAT_181e71cf0);
        }
        lVar1 = this.nowShowHero;
        lVar2 = *(int64 *)(*(int64 *)(DAT_181e528f8 + 184) + 8);
        if ((lVar2 != null) && (lVar2 = *(int64 *)(lVar2 + 16)) != null) {
          iVar5 = PlayerPrefDictionary.GetInt(lVar2,"TestMode",0);
          uVar7 = 30;
          if (iVar5 == 1) {
            uVar7 = 0;
          }
          if (lVar1 != null) {
            lVar1.changeSkinCd = uVar7;
            HeroDetailController.RefreshHeroSkeleton(this,0);
            HeroDetailController.SetClothList(this,0,0);
            plVar6 = (int64 *)Resources.Load("Sound/SoundEffect/Armor",0);
            plVar8 = (int64 *)0;
            if ((plVar6 != (int64 *)0) && (*plVar6 == DAT_181e8f4a0)) {
              plVar8 = plVar6;
            }
            NGUITools.PlaySound(plVar8,0);
            if (this.nowShowHero != null) {
              if (this.nowShowHero.heroID == null) {
                uVar3 = **(uint64 **)(DAT_181e569c8 + 184);
                cVar4 = Object.op_Inequality(uVar3,0,0);
                if (cVar4) {
                  if (*pStatics == 0) throw; // [null/range check failed]
                  *(uint8 *)(*pStatics + 248) = 1;
                }
              }
              return;
            }
          }
        }
    }

    // Token : 0x600181E
    // RVA   : 0xB0BCF0   Offset: 0xB0AAF0   Length: 0xBE
    public void EquipLockButtonClicked()
    {
        long lVar1;
        long lVar2;
        lVar1 = this.nowShowHero;
        if (this.heroDetailPanel != null) {
          lVar2 = GameObject.get_transform(this.heroDetailPanel,0);
          if (lVar2 != null) {
            lVar2 = Transform.Find(lVar2,"Item",0);
            if (lVar2 != null) {
              lVar2 = Transform.Find(lVar2,"EquipLock",0);
              if (lVar2 != null) {
                lVar2 = Component.GetComponent(lVar2,DAT_181e796b8);
                if ((lVar2 != null) && (lVar1 != null)) {
                  lVar1.equipLock = *(uint8 *)(lVar2 + 0x118);
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x600181F
    // RVA   : 0xB1F2D0   Offset: 0xB1E0D0   Length: 0xBE
    public void SkillLockButtonClicked()
    {
        long lVar1;
        long lVar2;
        lVar1 = this.nowShowHero;
        if (this.heroDetailPanel != null) {
          lVar2 = GameObject.get_transform(this.heroDetailPanel,0);
          if (lVar2 != null) {
            lVar2 = Transform.Find(lVar2,"Skill",0);
            if (lVar2 != null) {
              lVar2 = Transform.Find(lVar2,"SkillLock",0);
              if (lVar2 != null) {
                lVar2 = Component.GetComponent(lVar2,DAT_181e796b8);
                if ((lVar2 != null) && (lVar1 != null)) {
                  lVar1.skillLock = *(uint8 *)(lVar2 + 0x118);
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x6001820
    // RVA   : 0xB1E620   Offset: 0xB1D420   Length: 0x153
    public void SetNameButtonClicked()
    {
        bool cVar1;
        long lVar2;
        long lVar3;
        if (this.heroDetailPanel != null) {
          lVar2 = GameObject.get_transform(this.heroDetailPanel,0);
          if (lVar2 != null) {
            lVar2 = Transform.Find(lVar2,"SetNameInput",0);
            if (lVar2 != null) {
              lVar2 = Component.get_gameObject(lVar2,0);
              if (this.heroDetailPanel != null) {
                lVar3 = GameObject.get_transform(this.heroDetailPanel,0);
                if (lVar3 != null) {
                  lVar3 = Transform.Find(lVar3,"SetNameInput",0);
                  if (lVar3 != null) {
                    lVar3 = Component.get_gameObject(lVar3,0);
                    if (lVar3 != null) {
                      cVar1 = GameObject.get_activeSelf(lVar3,0);
                      if (lVar2 != null) {
                        GameObject.SetActive(lVar2,!cVar1,0);
                        plVar4 = (int64 *)Resources.Load("Sound/SoundEffect/PaperQuick",0);
                        plVar5 = (int64 *)0;
                        if ((plVar4 != (int64 *)0) && (*plVar4 == DAT_181e8f4a0)) {
                          plVar5 = plVar4;
                        }
                        NGUITools.PlaySound(plVar5,0);
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

    // Token : 0x6001821
    // RVA   : 0xB1E780   Offset: 0xB1D580   Length: 0x351
    public void SetNameEndEdit()
    {
        long lVar1;
        long lVar2;
        ulong uVar5;
        ushort uVar6;
        ushort uVar7;
        if (**(int **)(DAT_181e538e8 + 184) == 1) {
          lVar1 = new c.DisplayClass9_0(0);
          if (this.heroDetailPanel != null) {
            lVar2 = GameObject.get_transform(this.heroDetailPanel,0);
            if (lVar2 != null) {
              lVar2 = Transform.Find(lVar2,"SetNameInput",0);
              if (lVar2 != null) {
                lVar2 = Component.GetComponent(lVar2,DAT_181e77838);
                if ((lVar2 != null) && (lVar1 != null)) {
                  *(uint64 *)(lVar1 + 16) = *(uint64 *)(lVar2 + 0x170);
                  *(uint8 *)(lVar1 + 24) =
                       *(uint8 *)(*(int64 *)(DAT_181e538e8 + 184) + 128);
                  plVar3 = (int64 *)rail_api.RailFactory(0);
                  if (plVar3 != (int64 *)0) {
                    lVar2 = *plVar3;
                    uVar7 = 0;
                    if (*(uint16 *)(lVar2 + 0x12a) != 0) {
                      uVar6 = uVar7;
                      do {
                        if (*(int64 *)(*(int64 *)(lVar2 + 176) + (uint64)uVar6 * 16) ==
                            DAT_181e5b750) {
                          puVar4 = (uint64 *)
                                   ((int64)
                                    *(int *)(*(int64 *)(lVar2 + 176) + 8 + (uint64)uVar6 * 16) *
                                    16 + 0x248 + lVar2);
                          goto LAB_180b1e97f;
                        }
                        uVar6 = uVar6 + 1;
                      } while (uVar6 < *(uint16 *)(lVar2 + 0x12a));
                    }
                    puVar4 = (uint64 *)FUN_18019b1f0(plVar3,DAT_181e5b750,17);
        LAB_180b1e97f:
                    plVar3 = (int64 *)(*(code *)*puVar4)(plVar3,puVar4[1]);
                    uVar5 = "";
                    if (plVar3 != (int64 *)0) {
                      lVar2 = *plVar3;
                      if (*(uint16 *)(lVar2 + 0x12a) != 0) {
                        do {
                          if (*(int64 *)(*(int64 *)(lVar2 + 176) + (uint64)uVar7 * 16) ==
                              DAT_181e5cf10) {
                            puVar4 = (uint64 *)
                                     ((int64)
                                      *(int *)(*(int64 *)(lVar2 + 176) + 8 + (uint64)uVar7 * 16)
                                      * 16 + 0x1f8 + lVar2);
                            goto LAB_180b1e9e7;
                          }
                          uVar7 = uVar7 + 1;
                        } while (uVar7 < *(uint16 *)(lVar2 + 0x12a));
                      }
                      puVar4 = (uint64 *)FUN_18019b1f0(plVar3,DAT_181e5cf10,12);
        LAB_180b1e9e7:
                      (*(code *)*puVar4)(plVar3,lVar1,uVar5,puVar4[1]);
                      goto LAB_180b1eaae;
                    }
                  }
                }
              }
            }
          }
        }
        else {
          lVar1 = CISFilterWordsSDK.get_Instance(0);
          if (this.heroDetailPanel != null) {
            lVar2 = GameObject.get_transform(this.heroDetailPanel,0);
            if (lVar2 != null) {
              lVar2 = Transform.Find(lVar2,"SetNameInput",0);
              if (lVar2 != null) {
                lVar2 = Component.GetComponent(lVar2,DAT_181e77838);
                if ((lVar2 != null) && (lVar1 != null)) {
                  uVar5 = CISFilterWordsSDK.FilterReplaceWithChar
                                    (lVar1,*(uint64 *)(lVar2 + 0x170),42,0);
                  HeroDetailController.SetNowShowHeroSettingName(this,uVar5,0);
        LAB_180b1eaae:
                  HeroDetailController.HideNameInput(this,0);
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x6001822
    // RVA   : 0xB1EAE0   Offset: 0xB1D8E0   Length: 0x108
    public void SetNowShowHeroSettingName(string targetName)
    {
        bool cVar1;
        if ((this.nowShowHero != null) &&
           (cVar1 = String.op_Inequality
                              (this.nowShowHero.settingName,targetName,0),
           cVar1)) {
          if (this.nowShowHero != null) {
            this.nowShowHero.settingName = targetName;
            if (this.nowShowHero != null) {
              this.nowShowHero.heroDetailDirty = 1;
              if (this.nowShowHero != null) {
                HeroData.set_HeroIconDirty(this.nowShowHero,1,0);
                plVar2 = (int64 *)Resources.Load("Sound/SoundEffect/PencilWriting",0);
                plVar4 = (int64 *)0;
                if ((plVar2 != (int64 *)0) && (*plVar2 == DAT_181e8f4a0)) {
                  plVar4 = plVar2;
                }
                NGUITools.PlaySound(plVar4,0);
                return;
              }
            }
          }
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
    }

    // Token : 0x6001823
    // RVA   : 0xB13C50   Offset: 0xB12A50   Length: 0xE9
    public void HideNameInput()
    {
        long lVar1;
        if (this.heroDetailPanel != null) {
          lVar1 = GameObject.get_transform(this.heroDetailPanel,0);
          if (lVar1 != null) {
            lVar1 = Transform.Find(lVar1,"SetNameInput",0);
            if (lVar1 != null) {
              lVar1 = Component.get_gameObject(lVar1,0);
              if (lVar1 != null) {
                GameObject.SetActive(lVar1,0,0);
                if (this.heroDetailPanel != null) {
                  lVar1 = GameObject.get_transform(this.heroDetailPanel,0);
                  if (lVar1 != null) {
                    lVar1 = Transform.Find(lVar1,"SetNameInput",0);
                    if (lVar1 != null) {
                      lVar1 = Component.GetComponent(lVar1,DAT_181e77838);
                      if (lVar1 != null) {
                        InputField.set_text(lVar1,"",0);
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

    // Token : 0x6001824
    // RVA   : 0xB14FC0   Offset: 0xB13DC0   Length: 0x9A
    public void OnSetHeroNameFliterResult(RAILEventID id, EventBase data)
    {
        void HeroDetailController.OnSetHeroNameFliterResult
                     (uint64 this,int id,int64 *data)
        {
        if (data != (int64 *)0) {
          if (((int)data[2] == 0) && (id == 0x1f45)) {
            HeroDetailController.SetNowShowHeroSettingName(this,data[8],0);
          }
          return;
        }
    }

    // Token : 0x6001825
    // RVA   : 0xB15060   Offset: 0xB13E60   Length: 0x3E5
    public void RecruitUnlockButtonClicked()
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        uint[] local_res18 = new uint[4];
        if ((GameController._instance != null) &&
           (lVar2 = GameController._instance.worldData) != null) {
          lVar2 = WorldData.Player(lVar2,0);
          if (lVar2 != null) {
            lVar2 = HeroData.GetForce(lVar2,0,0);
            if (lVar2 != null) {
              if ((GameController._instance == null) ||
                 (lVar2 = GameController._instance.worldData) == null)
              throw; // [null/range check failed]
              lVar2 = WorldData.Player(lVar2,0);
              if (lVar2 == null) throw; // [null/range check failed]
              lVar2 = HeroData.GetForce(lVar2,0,0);
              if (this.nowShowHero == null) throw; // [null/range check failed]
              HeroData.GetRecruitUnlockCost(this.nowShowHero,0);
              if (lVar2 == null) throw; // [null/range check failed]
              cVar1 = ForceData.HaveResource(lVar2,5);
              if (cVar1) {
                lVar2 = **(int64 **)(DAT_181e88b68 + 184);
                if (this.nowShowHero != null) {
                  local_res18[0] = HeroData.GetRecruitUnlockCost(this.nowShowHero,0);
                  uVar3 = il2cpp_value_box(DAT_181e60808,local_res18);
                  if (this.nowShowHero != null) {
                    uVar4 = HeroData.GetHeroName(this.nowShowHero,0,0);
                    uVar3 = String.Format("确认要消耗{0}点门派威望\n解锁{1}的招募吗？",uVar3,uVar4,0);
                    uVar4 = Component.get_gameObject(this,0);
                    if (lVar2 != null) {
                      SureMenu.CallSureMenu(lVar2,uVar3,"SureUnlockRecruit",0,uVar4,1,0,0,0,0);
                      return;
                    }
                  }
                }
                          // WARNING: Subroutine does not return
                FUN_1801e0300();
              }
            }
            if (GameController._instance != null) {
              GameController.ShowTextOnMouse(GameController._instance,"门派威望不足！",0);
              plVar5 = (int64 *)Resources.Load("Sound/SoundEffect/WrongClick",0);
              plVar6 = (int64 *)0;
              if ((plVar5 != (int64 *)0) && (*plVar5 == DAT_181e8f4a0)) {
                plVar6 = plVar5;
              }
              NGUITools.PlaySound(plVar6,0);
              return;
            }
          }
        }
    }

    // Token : 0x6001826
    // RVA   : 0xB1FAD0   Offset: 0xB1E8D0   Length: 0x418
    public void SureUnlockRecruit()
    {
        long lVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        uint[] local_res18 = new uint[2];
        uint[] local_res20 = new uint[2];
        int[] local_38 = new int[4];
        ulong local_28;
        ulong uStack_20;
        if ((GameController._instance != null) &&
           (lVar2 = GameController._instance.worldData) != null) {
          lVar2 = WorldData.Player(lVar2,0);
          if (lVar2 != null) {
            lVar2 = HeroData.GetForce(lVar2,0,0);
            if (this.nowShowHero != null) {
              HeroData.GetRecruitUnlockCost(this.nowShowHero,0);
              if (lVar2 != null) {
                ForceData.CostResource(lVar2,5);
                if ((GameController._instance != null) &&
                   (lVar2 = GameController._instance.worldData) != null) {
                  lVar2 = lVar2.PlotEventLog;
                  if (this.nowShowHero != null) {
                    local_res18[0] = this.nowShowHero.heroForceLv;
                    uVar3 = il2cpp_value_box(DAT_181e60808,local_res18);
                    uVar3 = String.Format("RecruitUnlockNumLv{0}",uVar3,0);
                    if ((GameController._instance != null) &&
                       (lVar1 = GameController._instance.worldData) != null)
                    {
                      lVar1 = lVar1.PlotEventLog;
                      if (this.nowShowHero != null) {
                        local_res20[0] = this.nowShowHero.heroForceLv;
                        uVar4 = il2cpp_value_box(DAT_181e60808,local_res20);
                        uVar4 = String.Format("RecruitUnlockNumLv{0}",uVar4,0);
                        if (lVar1 != null) {
                          local_38[0] = PlotEventLogData.GetInt(lVar1,uVar4,0);
                          local_38[0] = local_38[0] + 1;
                          uVar4 = Int32.ToString(local_38,"f0",0);
                          if (lVar2 != null) {
                            PlotEventLogData.Set(lVar2,uVar3,uVar4,0);
                            if (this.nowShowHero != null) {
                              this.nowShowHero.recruitAble = 1;
                              if (this.nowShowHero != null) {
                                this.nowShowHero.heroDetailDirty = 1;
                                lVar2 = **(int64 **)(DAT_181e5fa68 + 184);
                                if (this.nowShowHero != null) {
                                  uVar3 = HeroData.HeroName(this.nowShowHero,0,0);
                                  uVar3 = String.Concat(uVar3,"可进行招募",0);
                                  if (lVar2 != null) {
                                    local_28 = 0;
                                    uStack_20 = 0;
                                    InfoController.AddInfoTab
                                              (lVar2,uVar3,"UIAtlas","资源_人口","BigSuccess",
                                               0x3f800000,0x40a00000,&local_28,0);
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

    // Token : 0x6001827
    // RVA   : 0xB0AAD0   Offset: 0xB098D0   Length: 0xEC
    public void AllLeaveTeamButtonClicked()
    {
        long lVar1;
        ulong uVar2;
        ulong uVar3;
        lVar1 = **(int64 **)(DAT_181e88b68 + 184);
        uVar2 = FUN_1800020e0(DAT_181e6dc98);
        uVar2 = String.Format("确认要解散全体队友吗？",uVar2,0);
        uVar3 = Component.get_gameObject(this,0);
        if (lVar1 != null) {
          SureMenu.CallSureMenu(lVar1,uVar2,"SureAllLeaveTeam",0,uVar3,1,0,0,0,0);
          return;
        }
    }

    // Token : 0x6001828
    // RVA   : 0xB1F4F0   Offset: 0xB1E2F0   Length: 0x229
    public void SureAllLeaveTeam()
    {
        bool cVar2;
        uint uVar3;
        long lVar4;
        long lVar5;
        int iVar6;
        bVar1 = false;
        if ((((GameController._instance != null) &&
             (lVar4 = GameController._instance.worldData) != null) &&
            (lVar4 = WorldData.Player(lVar4,0)) != null) && (*(int64 *)(lVar4 + 0x2f8) != 0)) {
          iVar6 = *(int *)(*(int64 *)(lVar4 + 0x2f8) + 24) + -1;
          if (-1 < iVar6) {
            do {
              lVar4 = FUN_1802106e0(0);
              if (lVar4 == null) throw; // [null/range check failed]
              lVar4 = lVar4.villageAreaID;
              lVar5 = FUN_1802106e0(0);
              if (((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) ||
                 ((lVar5 = WorldData.Player(*(int64 *)(lVar5 + 32),0), lVar5 == null ||
                  (((*(int64 *)(lVar5 + 0x2f8) == 0 ||
                    (uVar3 = FUN_180002480(*(int64 *)(lVar5 + 0x2f8),iVar6,DAT_181e71bf0), lVar4 == null))
                   || (lVar4 = WorldData.GetHero(lVar4,uVar3,0)) == null))))) throw; // [null/range check failed]
              cVar2 = HeroData.MissionKeepInTeam(lVar4);
              if (!cVar2) {
                lVar5 = FUN_1802106e0(0);
                if (lVar5 == null) throw; // [null/range check failed]
                GameController.HeroLeaveTeam(lVar5,lVar4,0);
                bVar1 = true;
              }
              iVar6 = iVar6 + -1;
            } while (-1 < iVar6);
            if (bVar1) {
              HeroDetailController.FreshHeroDetail(this,1,0);
            }
          }
          return;
        }
    }

    // Token : 0x6001829
    // RVA   : 0xB20650   Offset: 0xB1F450   Length: 0x47
    public void /*ctor*/()
    {
        void FUN_180b20650(int64 this)
        {
        this.originSkinID = 999999;
        this.originSkinLV = 999999;
        this.tempSkinID = 0xffffff9d;
        this.tempSkinLv = 0xffffff9d;
        this.tempHairID = 0xffffff9d;
        this.tempBeardID = 0xffffff9d;
        this.tempOtherID = 0xffffff9d;
        FUN_180ae8740(this,0);
    }

    // Token : 0x600182A
    // RVA   : 0xB20020   Offset: 0xB1EE20   Length: 0x4B
    private void <UnshowHeroDetail>b__26_0()
    {
        this.mainShowHero = 0;
        this.nowShowHero = 0;
        if (this.heroDetailPanel != null) {
          GameObject.SetActive(this.heroDetailPanel,0,0);
          return;
        }
    }

}
