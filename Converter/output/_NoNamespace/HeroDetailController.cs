// ============================================================
// Type  : HeroDetailController
// Token : 0x20002BB
// ============================================================

public class HeroDetailController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400163B
    public SkillListType nowSkillListType;

    // Token: 0x400163C
    public GameObject heroDetailPanel;

    // Token: 0x400163D
    public GameObject heroDetailTabPrefab;

    // Token: 0x400163E
    public GameObject heroBaseFightDataPrefab;

    // Token: 0x400163F
    public GameObject heroExtraFightDataPrefab;

    // Token: 0x4001640
    public GameObject forceContributionInfoPrefab;

    // Token: 0x4001641
    public ItemListController itemListController;

    // Token: 0x4001642
    public GameObject skillGrid;

    // Token: 0x4001643
    public HeroData mainShowHero;

    // Token: 0x4001644
    public HeroData nowShowHero;

    // Token: 0x4001645
    private int originSkinID;

    // Token: 0x4001646
    private int originSkinLV;

    // Token: 0x4001647
    private GameObject temp;

    // Token: 0x4001648
    private bool init;

    // Token: 0x4001649
    public Dropdown skillSortTypeDropDown;

    // Token: 0x400164A
    public SkillSortType skillSortType;

    // Token: 0x400164B
    public bool reverseOrder;

    // Token: 0x400164C
    public bool itemSpeControlable;

    // Token: 0x400164D
    private static HeroDetailController _instance;

    // Token: 0x400164E
    private bool sortTypeLoaded;

    // Token: 0x400164F
    public GameObject clothGrid;

    // Token: 0x4001650
    public GameObject clothChoicePrefab;

    // Token: 0x4001651
    private bool clothListInited;

    // Token: 0x4001652
    private int tempSkinID;

    // Token: 0x4001653
    private int tempSkinLv;

    // Token: 0x4001654
    private int tempHairID;

    // Token: 0x4001655
    private int tempBeardID;

    // Token: 0x4001656
    private int tempOtherID;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600172D
    // RVA   : 0xEC5BD0   Offset: 0xEC43D0   Length: 0x36
    public static HeroDetailController get_Instance()
    {
        return **(uint64 **)(DAT_181d50f00 + 184);
    }

    // Token : 0x600172E
    // RVA   : 0xEB0670   Offset: 0xEAEE70   Length: 0xB6
    private void Awake()
    {
        ulong uVar1;
        bool cVar3;
        uVar1 = **(uint64 **)(DAT_181d50f00 + 184);
        cVar3 = Object.op_Equality(uVar1,0,0);
        if (cVar3) {
          plVar2 = *(int64 **)(DAT_181d50f00 + 184);
          *plVar2 = this;
          il2cpp_internal(plVar2,this);
        }
        this.mainShowHero = 0;
        this.nowShowHero = 0;
    }

    // Token : 0x600172F
    // RVA   : 0xEC48D0   Offset: 0xEC30D0   Length: 0x158
    private void Start()
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        if (**(int **)(DAT_181d4ef00 + 184) == 1) {
          cVar1 = RailManager.get_Initialized(0);
          if (!cVar1) {
            Debug.LogError("Rail sdk is not initialized!",0);
            return;
          }
          lVar2 = RailCallBackHelper.get_Instance(0);
          uVar3 = new OnTooltipCB(this,DAT_181d50290,0);
          if (lVar2 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          RailCallBackHelper.RegisterCallback(lVar2,0x1f45,uVar3,0);
        }
    }

    // Token : 0x6001730
    // RVA   : 0xEC5990   Offset: 0xEC4190   Length: 0x1D
    private void Update()
    {
        void FUN_180ec5990(int64 this)
        {
        int64 lVar1;
        lVar1 = this.nowShowHero;
        if ((lVar1 != null) && (lVar1.heroDetailDirty)) {
          HeroData.CheckHeroDetailDirty(lVar1,0,0);
          return;
        }
    }

    // Token : 0x6001731
    // RVA   : 0xEC3A40   Offset: 0xEC2240   Length: 0xF8
    public void SetHeroDetail(int id)
    {
        if ((id != null) && (id != this.mainShowHero)) {
          HeroDetailController.ShowHeroDetail(this,id,0,0);
          return;
        }
        HeroDetailController.UnshowHeroDetail(this,0);
    }

    // Token : 0x6001732
    // RVA   : 0xEC3B40   Offset: 0xEC2340   Length: 0x1D
    public void SetHeroDetail(HeroData targetHero)
    {
        if ((targetHero != null) && (targetHero != this.mainShowHero)) {
          HeroDetailController.ShowHeroDetail(this,targetHero,0,0);
          return;
        }
        HeroDetailController.UnshowHeroDetail(this,0);
    }

    // Token : 0x6001733
    // RVA   : 0xEC5780   Offset: 0xEC3F80   Length: 0x20F
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
        if ((plVar1 != (int64 *)0) && (*plVar1 == DAT_181d8a228)) {
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
              uVar3 = Component.GetComponent(lVar2,DAT_181d6bc40);
              uVar3 = DOTweenModuleUI.DOFade(uVar3,0,0x3e4ccccd,0);
              uVar3 = TweenSettingsExtensions.SetUpdate(uVar3,1,DAT_181d98958);
              TweenSettingsExtensions.SetEase(uVar3,9,DAT_181d97a00);
              if (this.heroDetailPanel != null) {
                uVar3 = GameObject.get_transform(this.heroDetailPanel,0);
                local_18 = 0;
                local_14 = 0x3f800000;
                local_10 = 0x3f800000;
                uVar3 = ShortcutExtensions.DOScale(uVar3,&local_18,0x3e4ccccd,0);
                uVar4 = new OnTooltipCB(this,DAT_181d50210,0);
                TweenSettingsExtensions.OnComplete(uVar3,uVar4,DAT_181d96ee8);
                return;
              }
            }
          }
        }
    }

    // Token : 0x6001734
    // RVA   : 0xEBA120   Offset: 0xEB8920   Length: 0x55E
    public void LoadSortTypeFromWorldData()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
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
          if (((*pStatics != 0) &&
              (lVar1 = *(int64 *)(*pStatics + 32)) != null) &&
             (lVar2 != null)) {
            Dropdown.set_value(lVar2,*(uint32 *)(lVar1 + 0x250),0);
            lVar2 = this.itemListController;
            if (((*pStatics != 0) &&
                (lVar1 = *(int64 *)(*pStatics + 32)) != null) &&
               (lVar2 != null)) {
              lVar2.reverseOrder = *(uint8 *)(lVar1 + 0x254);
              if ((((this.itemListController != null) &&
                   (lVar2 = this.itemListController.sortTypeDropDown) != null) &&
                  (lVar2 = Component.get_transform(lVar2,0)) != null) &&
                 ((lVar2 = FUN_180da0f00(lVar2,0), lVar2 != null &&
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
                        ((lVar2 = FUN_180da0f00(lVar2,0), lVar2 != null &&
                         (lVar2 = Transform.Find(lVar2,"ReverseType",0)) != null))))) {
                      lVar2 = Component.GetComponent(lVar2,DAT_181d6ccc0);
                      if (this.itemListController != null) {
                        uVar4 = "升序";
                        if (this.itemListController.reverseOrder) {
                          uVar4 = "降序";
                        }
                        if (lVar2 != null) {
                          lVar2.itemGrid = uVar4;
                          lVar2 = this.skillSortTypeDropDown;
                          if (((*pStatics != 0) &&
                              (lVar1 = *(int64 *)(*pStatics + 32),
                              lVar1 != null)) && (lVar2 != null)) {
                            Dropdown.set_value(lVar2,*(uint32 *)(lVar1 + 600),0);
                            if ((*pStatics != 0) &&
                               (lVar2 = *(int64 *)(*pStatics + 32),
                               lVar2 != null)) {
                              this.reverseOrder = *(uint8 *)(lVar2 + 0x25c);
                              if ((this.skillSortTypeDropDown != null) &&
                                 (((lVar2 = Component.get_transform(this.skillSortTypeDropDown,0),
                                   lVar2 != null && (lVar2 = FUN_180da0f00(lVar2,0)) != null) &&
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
                                     ((lVar2 = FUN_180da0f00(lVar2,0), lVar2 != null &&
                                      (lVar2 = Transform.Find(lVar2,"ReverseType",0)) != null))) {
                                    lVar2 = Component.GetComponent(lVar2,DAT_181d6ccc0);
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

    // Token : 0x6001735
    // RVA   : 0xEC4430   Offset: 0xEC2C30   Length: 0x330
    public void ShowHeroDetail(HeroData targetHero, bool _itemSpeControlable)
    {
        var pStatics = *(int64*)(DAT_181d65970 + 184);
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
                  plVar3 = (int64 *)Component.GetComponent(lVar2,DAT_181d6bc40);
                  puVar4 = (uint32 *)FUN_180d904c0(&local_18,0);
                  if (plVar3 != (int64 *)0) {
                    local_18 = *puVar4;
                    uStack_14 = puVar4[1];
                    uStack_10 = puVar4[2];
                    uStack_c = puVar4[3];
                    (**(code **)(*plVar3 + 0x2a8))(plVar3,&local_18,*(uint64 *)(*plVar3 + 0x2b0));
                    if (((this.heroDetailPanel != null) &&
                        (lVar2 = GameObject.get_transform(this.heroDetailPanel,0)) != null)
                       && (lVar2 = Transform.Find(lVar2,"BlackBackground",0)) != null) {
                      uVar5 = Component.GetComponent(lVar2,DAT_181d6bc40);
                      uVar5 = DOTweenModuleUI.DOFade(uVar5,0x3f000000,0x3e800000,0);
                      uVar5 = TweenSettingsExtensions.SetUpdate(uVar5,1,DAT_181d98958);
                      TweenSettingsExtensions.SetEase(uVar5,8,DAT_181d97a00);
                      if (this.heroDetailPanel != null) {
                        uVar5 = GameObject.get_transform(this.heroDetailPanel,0);
                        uVar5 = ShortcutExtensions.DOScale(uVar5,0x3f800000,0x3e800000,0);
                        uVar5 = TweenSettingsExtensions.SetUpdate(uVar5,1,DAT_181d98af0);
                        uVar6 = new OnTooltipCB(lVar1,DAT_181d7c7f8,0);
                        TweenSettingsExtensions.OnComplete(uVar5,uVar6,DAT_181d96ee8);
                        plVar3 = (int64 *)Resources.Load("Sound/SoundEffect/Paper",0);
                        plVar7 = (int64 *)0;
                        if ((plVar3 != (int64 *)0) && (*plVar3 == DAT_181d8a228)) {
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

    // Token : 0x6001736
    // RVA   : 0xEB9580   Offset: 0xEB7D80   Length: 0x935
    private void Init()
    {
        var pStatics_6270 = *(int64*)(DAT_181d86270 + 184);
        var pStatics_e188 = *(int64*)(DAT_181d4e188 + 184);
        bool cVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        long lVar6;
        long lVar7;
        int iVar8;
        int[] local_res8 = new int[2];
        int[] local_res18 = new int[4];
        ulong local_60;
        ulong uStack_58;
        long local_50;
        byte[] local_48 = new byte[16];
        long local_38;
        iVar8 = 0;
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
          if (*pStatics_e188 == 0) throw; // [null/range check failed]
          uVar4 = *(uint64 *)(*pStatics_e188 + 160);
          uVar3 = GlobalData.AddChild(uVar3,uVar4);
          this.temp = uVar3;
          if ((this.temp == null) ||
             (Object.set_name(), this.temp == null)) throw; // [null/range check failed]
          GameObject.SetActive();
          local_res8[0] = local_res8[0] + 1;
        } while (local_res8[0] < 8);
        while( true ) {
          lVar2 = this.heroDetailPanel;
          if (*(int *)(*(int64 *)(DAT_181d4ef00 + 184) + 140) + 3 <= iVar8) break;
          if ((lVar2 == null) || (lVar2 = GameObject.get_transform(lVar2,0)) == null)
          throw; // [null/range check failed]
          lVar2 = Transform.Find(lVar2,"Skill");
          uVar3 = Int32.ToString(local_res18,0);
          uVar3 = String.Concat("SkillSlot",uVar3);
          if ((lVar2 == null) || (lVar2 = Transform.Find(lVar2,uVar3)) == null) throw; // [null/range check failed]
          uVar3 = Component.get_gameObject(lVar2,0);
          if (*pStatics_e188 == 0) throw; // [null/range check failed]
          uVar4 = *(uint64 *)(*pStatics_e188 + 168);
          uVar3 = GlobalData.AddChild(uVar3,uVar4);
          this.temp = uVar3;
          if ((this.temp == null) ||
             (Object.set_name(), this.temp == null)) throw; // [null/range check failed]
          GameObject.SetActive();
          iVar8 = local_res18[0] + 1;
          local_res18[0] = iVar8;
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
              lVar2 = Component.GetComponent(lVar2,DAT_181d6bc40);
              if ((*pStatics_6270 != 0) &&
                 (uVar3 = TextureController.LoadAtlasSprite
                                    (*pStatics_6270,"UIAtlas","官府功绩",0),
                 lVar2 != null)) {
                Image.set_sprite(lVar2,uVar3,0);
                if ((this.temp != null) &&
                   (((lVar2 = GameObject.get_transform(this.temp,0), lVar2 != null &&
                     (lVar2 = Transform.Find(lVar2,"ForceName",0)) != null) &&
                    (plVar5 = (int64 *)Component.GetComponent(lVar2,DAT_181d6d8c0),
                    plVar5 != (int64 *)0)))) {
                  (**(code **)(*plVar5 + 0x5e8))(plVar5,"官府",*(uint64 *)(*plVar5 + 0x5f0));
                  lVar2 = FUN_18046c0a0(0);
                  if (((lVar2 != null) && (*(int64 *)(lVar2 + 32) != 0)) &&
                     (lVar2 = *(int64 *)(*(int64 *)(lVar2 + 32) + 72)) != null) {
                    FUN_1817ff240(local_48,lVar2,DAT_181d60878);
                    local_50 = local_38;
                    while( true ) {
                      cVar1 = FUN_180d197a0(&local_60,DAT_181d66148);
                      lVar2 = local_50;
                      if (!cVar1) {
                        ZhSegment.Initialize(&local_60,DAT_181d660c8);
                        return;
                      }
                      if (this.heroDetailPanel == null) {
                          // WARNING: Subroutine does not return
                        FUN_1800d6620();
                      }
                      lVar6 = GameObject.get_transform(this.heroDetailPanel,0);
                      if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                        FUN_1800d6620();
                      }
                      lVar6 = Transform.Find(lVar6,"ForceContribution",0);
                      if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                        FUN_1800d6620();
                      }
                      lVar6 = Transform.Find(lVar6,"Viewport",0);
                      if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                        FUN_1800d6620();
                      }
                      lVar6 = Transform.Find(lVar6,"Content",0);
                      if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                        FUN_1800d6620();
                      }
                      uVar4 = Component.get_gameObject(lVar6,0);
                      uVar3 = this.forceContributionInfoPrefab;
                      uVar3 = GlobalData.AddChild(uVar4,uVar3,0);
                      this.temp = uVar3;
                      lVar6 = this.temp;
                      if (lVar2 == null) {
                          // WARNING: Subroutine does not return
                        FUN_1800d6620();
                      }
                      uVar3 = Int32.ToString(lVar2 + 16,0);
                      if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                        FUN_1800d6620();
                      }
                      Object.set_name(lVar6,uVar3,0);
                      if (this.temp == null) {
                          // WARNING: Subroutine does not return
                        FUN_1800d6620();
                      }
                      lVar6 = GameObject.get_transform(this.temp,0);
                      if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                        FUN_1800d6620();
                      }
                      lVar6 = Transform.Find(lVar6,"ForceIcon",0);
                      if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                        FUN_1800d6620();
                      }
                      lVar6 = Component.GetComponent(lVar6,DAT_181d6bc40);
                      lVar7 = FUN_18046c6c0(0);
                      uVar3 = GlobalData.GetForceIconName(*(uint32 *)(lVar2 + 16),0);
                      if (lVar7 == null) {
                          // WARNING: Subroutine does not return
                        FUN_1800d6620();
                      }
                      uVar3 = TextureController.LoadAtlasSprite(lVar7,"UIAtlas",uVar3,0);
                      if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                        FUN_1800d6620();
                      }
                      Image.set_sprite(lVar6,uVar3,0);
                      if (this.temp == null) {
                          // WARNING: Subroutine does not return
                        FUN_1800d6620();
                      }
                      lVar6 = GameObject.get_transform(this.temp,0);
                      if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                        FUN_1800d6620();
                      }
                      lVar6 = Transform.Find(lVar6,"ForceName",0);
                      if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                        FUN_1800d6620();
                      }
                      plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181d6d8c0);
                      if (plVar5 == (int64 *)0) break;
                      (**(code **)(*plVar5 + 0x5e8))(plVar5,*(uint64 *)(lVar2 + 24));
                    }
                          // WARNING: Subroutine does not return
                    FUN_1800d6620(0);
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6001737
    // RVA   : 0xEB2140   Offset: 0xEB0940   Length: 0x1D7
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
              lVar3 = FUN_18046c0a0(0);
              if (lVar3 == null) break;
              lVar3 = lVar3.summonControlable;
              if (((this.mainShowHero == null) ||
                  (lVar1 = this.mainShowHero.teamMates) == null) ||
                 (uVar2 = FUN_1800d6750(lVar1,iVar5,DAT_181d68270), lVar3 == null)) break;
              uVar4 = WorldData.GetHero(lVar3,uVar2,0);
              HeroDetailController.CreateHeroDetailTab(this,uVar4,0);
              lVar3 = this.mainShowHero;
              iVar5 = iVar5 + 1;
              if (lVar3 == null) break;
            }
          }
        }
    }

    // Token : 0x6001738
    // RVA   : 0xEBA680   Offset: 0xEB8E80   Length: 0x37
    public bool NowShowHeroItemControlable()
    {
        bool cVar1;
        if (this.nowShowHero == null) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        cVar1 = HeroData.ItemControlable(this.nowShowHero,0);
        if (cVar1) {
          return true;
        }
        return this.itemSpeControlable;
    }

    // Token : 0x6001739
    // RVA   : 0xEB1170   Offset: 0xEAF970   Length: 0x193
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
                    uVar3 = Component.GetComponent(lVar1,DAT_181d6d8c0);
                    if (targetHero != null) {
                      uVar2 = HeroData.HeroName(targetHero,0,0);
                      LTLocalization.SetText(uVar3,uVar2,0);
                      if (this.temp != null) {
                        lVar1 = GameObject.GetComponent(this.temp,DAT_181d9fa10);
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

    // Token : 0x600173A
    // RVA   : 0xEBE810   Offset: 0xEBD010   Length: 0x87
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

    // Token : 0x600173B
    // RVA   : 0xEB2320   Offset: 0xEB0B20   Length: 0x2264
    public void FreshNowHeroDetail(HeroData targetHero, bool resetPos)
    {
        var pStatics_e188 = *(int64*)(DAT_181d4e188 + 184);
        var pStatics_ef00 = *(int64*)(DAT_181d4ef00 + 184);
        uint uVar1;
        uint uVar2;
        bool cVar3;
        bool cVar4;
        byte uVar6;
        bool cVar7;
        int iVar8;
        int iVar9;
        uint uVar10;
        long lVar11;
        ulong uVar12;
        ulong uVar13;
        ulong uVar14;
        long lVar15;
        long lVar18;
        ulong uVar19;
        ulong uVar20;
        ulong uVar21;
        uint uVar22;
        uint uVar23;
        uint uVar24;
        float fVar26;
        uint uVar27;
        byte[] auVar28 = new byte[16];
        byte[] auVar29 = new byte[16];
        float[] local_res8 = new float[2];
        uint[] local_res10 = new uint[2];
        byte local_res18;
        ulong uVar30;
        uint local_158;
        uint local_154;
        uint local_150;
        uint32 local_14c;
        int64 local_148;
        int64 lStack_140;
        uint32 local_138 [2];
        uint64 local_130;
        int local_128;
        uint32 local_124;
        uint32 local_120;
        int local_11c;
        uint32 local_118;
        int local_114;
        uint32 local_110;
        uint32 local_10c;
        int local_108;
        int local_104;
        uint32 local_100;
        uint32 local_fc;
        uint32 local_f8;
        uint32 local_f4;
        int local_f0;
        uint32 local_ec;
        uint32 local_e8;
        int local_e4;
        uint32 local_e0 [2];
        uint8 local_d8 [16];
        uint8 local_c8 [16];
        uint8 local_b8 [16];
        uint8 local_a8 [16];
        uint8 local_98 [16];
        uint8 local_88 [16];
        uint8 local_78 [64];
        uint64 extraout_XMM0_Qb;
        local_res18 = resetPos;
        uVar24 = 0;
        local_res8[0] = 0.0;
        cVar7 = false;
        local_14c = 0;
        local_154 = 0;
        local_res10[0] = 0;
        local_158 = 0;
        local_128 = 0;
        local_138[0] = 0;
        local_150 = 0;
        if ((this.nowShowHero != targetHero) && (this.nowShowHero != null)) {
          HeroDetailController.SetClothList(this,0,0);
        }
        this.nowShowHero = targetHero;
        if (((this.heroDetailPanel == null) ||
            (lVar11 = GameObject.get_transform(this.heroDetailPanel,0)) == null) ||
           (lVar11 = Transform.Find(lVar11,"ItemUncontrolableUI",0)) == null) goto LAB_180eb931a;
        lVar11 = Component.get_gameObject(lVar11,0);
        if (this.nowShowHero == null) goto LAB_180eb931a;
        cVar3 = HeroData.ItemControlable(this.nowShowHero,0);
        cVar4 = true;
        if (!cVar3) {
          cVar4 = this.itemSpeControlable;
        }
        if (lVar11 == null) goto LAB_180eb931a;
        GameObject.SetActive(lVar11,!cVar4,0);
        HeroDetailController.RefreshHeroSkeleton(this,0);
        if (((this.heroDetailPanel == null) ||
            (lVar11 = GameObject.get_transform(this.heroDetailPanel,0)) == null) ||
           (lVar11 = Transform.Find(lVar11,"TeamMateNum",0)) == null) goto LAB_180eb931a;
        uVar12 = Component.GetComponent(lVar11,DAT_181d6d8c0);
        lVar11 = this.mainShowHero;
        if (lVar11 == null) goto LAB_180eb931a;
        lVar15 = "";
        if (lVar11.heroID == null) {
          if (lVar11.teamMates == null) goto LAB_180eb931a;
          local_e0[0] = *(uint32 *)(lVar11.teamMates + 24);
          uVar13 = il2cpp_value_box(DAT_181d5b2f8,local_e0);
          if (this.mainShowHero == null) goto LAB_180eb931a;
          local_124 = HeroData.GetMaxStudent(this.mainShowHero,0);
          uVar14 = il2cpp_value_box(DAT_181d5b2f8,&local_124);
          lVar15 = String.Format("队友 {0}/{1}",uVar13,uVar14,0);
        }
        LTLocalization.SetText(uVar12,lVar15,0);
        if (((this.heroDetailPanel == null) ||
            (lVar11 = GameObject.get_transform(this.heroDetailPanel,0)) == null) ||
           (lVar11 = Transform.Find(lVar11,"TeamMateNum",0)) == null) goto LAB_180eb931a;
        plVar16 = (int64 *)Component.GetComponent(lVar11,DAT_181d6d8c0);
        lVar11 = this.mainShowHero;
        if ((lVar11 == null) || (lVar11.teamMates == null)) goto LAB_180eb931a;
        iVar9 = *(int *)(lVar11.teamMates + 24);
        iVar8 = HeroData.GetMaxStudent(lVar11,0);
        if (iVar9 < iVar8) {
          plVar17 = (int64 *)Color.get_black(local_78,0);
          lVar11 = *plVar17;
          lVar15 = plVar17[1];
        }
        else {
          lVar11 = *(int64 *)(pStatics_ef00 + 0x2e8);
          lVar15 = *(int64 *)(pStatics_ef00 + 0x2f0);
        }
        if (plVar16 == (int64 *)0) goto LAB_180eb931a;
        local_148 = lVar11;
        lStack_140 = lVar15;
        (**(code **)(*plVar16 + 0x2a8))(plVar16,&local_148,*(uint64 *)(*plVar16 + 0x2b0));
        if (((this.heroDetailPanel == null) ||
            (lVar11 = GameObject.get_transform(this.heroDetailPanel,0)) == null) ||
           (lVar11 = Transform.Find(lVar11,"NickName",0)) == null) goto LAB_180eb931a;
        uVar12 = Component.GetComponent(lVar11,DAT_181d6d8c0);
        if (this.nowShowHero == null) goto LAB_180eb931a;
        LTLocalization.SetText(uVar12,this.nowShowHero.heroNickName,0);
        if (((this.heroDetailPanel == null) ||
            (lVar11 = GameObject.get_transform(this.heroDetailPanel,0)) == null) ||
           (lVar11 = Transform.Find(lVar11,"SpeHero",0)) == null) goto LAB_180eb931a;
        uVar12 = Component.GetComponent(lVar11,DAT_181d6d8c0);
        if (this.nowShowHero == null) goto LAB_180eb931a;
        lVar11 = "";
        if (this.nowShowHero.heroID != null) {
          plVar16 = (int64 *)FUN_1800d60b0(DAT_181d80cc0,5);
          if (this.nowShowHero == null) goto LAB_180eb931a;
          lVar11 = "普通角色";
          if (this.nowShowHero.speHero) {
            lVar11 = "特殊角色";
          }
          if (plVar16 == (int64 *)0) goto LAB_180eb931a;
          if ((lVar11 != null) &&
             (lVar15 = il2cpp_internal(lVar11,*(uint64 *)(*plVar16 + 64))) == null) {
            uVar12 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar12,0);
          }
          if ((int)plVar16[3] == 0) {
            uVar12 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar12,0);
          }
          plVar16[4] = lVar11;
          il2cpp_internal(plVar16 + 4,lVar11);
          if (("\n" != 0) &&
             (lVar11 = il2cpp_internal("\n",*(uint64 *)(*plVar16 + 64))) == null)
          {
            uVar12 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar12,0);
          }
          lVar11 = "\n";
          if (*(uint32 *)(plVar16 + 3) < 2) {
            uVar12 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar12,0);
          }
          plVar16[5] = "\n";
          il2cpp_internal(plVar16 + 5,lVar11);
          if (this.nowShowHero == null) goto LAB_180eb931a;
          lVar11 = "不可招募";
          if (this.nowShowHero.recruitAble) {
            lVar11 = "可招募";
          }
          if ((lVar11 != null) &&
             (lVar15 = il2cpp_internal(lVar11,*(uint64 *)(*plVar16 + 64))) == null) {
            uVar12 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar12,0);
          }
          if (*(uint32 *)(plVar16 + 3) < 3) {
            uVar12 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar12,0);
          }
          plVar16[6] = lVar11;
          il2cpp_internal(plVar16 + 6,lVar11);
          if (("\n" != 0) &&
             (lVar11 = il2cpp_internal("\n",*(uint64 *)(*plVar16 + 64))) == null)
          {
            uVar12 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar12,0);
          }
          lVar11 = "\n";
          if (*(uint32 *)(plVar16 + 3) < 4) {
            uVar12 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar12,0);
          }
          plVar16[7] = "\n";
          il2cpp_internal(plVar16 + 7,lVar11);
          if (this.nowShowHero == null) goto LAB_180eb931a;
          lVar11 = "不可亲密";
          if (this.nowShowHero.loveAble) {
            lVar11 = "可亲密";
          }
          if ((lVar11 != null) &&
             (lVar15 = il2cpp_internal(lVar11,*(uint64 *)(*plVar16 + 64))) == null) {
            uVar12 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar12,0);
          }
          if (*(uint32 *)(plVar16 + 3) < 5) {
            uVar12 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar12,0);
          }
          plVar16[8] = lVar11;
          il2cpp_internal(plVar16 + 8,lVar11);
          lVar11 = String.Concat(plVar16,0);
        }
        LTLocalization.SetText(uVar12,lVar11,0);
        if ((this.heroDetailPanel == null) ||
           (lVar11 = GameObject.get_transform(this.heroDetailPanel,0)) == null)
        goto LAB_180eb931a;
        lVar11 = Transform.Find(lVar11,"LoveableLock",0);
        lVar15 = FUN_18046c0a0(0);
        if ((lVar15 == null) || (lVar15.itemListInteractType == null)) goto LAB_180eb931a;
        if (*(int *)(lVar15.itemListInteractType + 156) == 0) {
          lVar15 = this.nowShowHero;
          if (lVar15 == null) goto LAB_180eb931a;
          if ((!lVar15.reverseOrder) || (*(char *)(lVar15 + 95) != false))
          goto LAB_180eb3101;
          lVar15 = FUN_18046c100(0);
          if (lVar15 == null) goto LAB_180eb931a;
          if ((this.nowShowHero == null) || (*(int64 *)(lVar15 + 0x1d8) == 0))
          goto LAB_180eb931a;
          cVar4 = FUN_1818279a0(*(int64 *)(lVar15 + 0x1d8),
                                this.nowShowHero.heroName,DAT_181d7c4d0);
          if (!cVar4) goto LAB_180eb3101;
          plVar16 = (int64 *)Vector3.get_one(local_d8,0);
        }
        else {
        LAB_180eb3101:
          plVar16 = (int64 *)Vector3.get_zero(local_c8,0);
        }
        if (lVar11 == null) goto LAB_180eb931a;
        lStack_140 = CONCAT44(lStack_140._4_4_,(int)plVar16[1]);
        local_148 = *plVar16;
        Transform.set_localScale(lVar11,&local_148,0);
        lVar11 = FUN_18046c0a0(0);
        if ((lVar11 == null) || (lVar11.summonControlable == null)) goto LAB_180eb931a;
        if (*(int *)(lVar11.summonControlable + 156) == 1) {
          lVar11 = this.nowShowHero;
          if (lVar11 == null) goto LAB_180eb931a;
          if (((!lVar11.speHero) || (-1 < lVar11.belongForceID)) ||
             (lVar11.recruitAble)) goto LAB_180eb3701;
          if (((*(byte *)(DAT_181d4ef00 + 0x133) & 4) != 0) && (*(int *)(DAT_181d4ef00 + 224) == 0)) {
            il2cpp_runtime_class_init(DAT_181d4ef00);
            lVar11 = this.nowShowHero;
          }
          lVar15 = *(int64 *)(pStatics_ef00 + 0x198);
          if ((lVar11 == null) || (lVar15 == null)) goto LAB_180eb931a;
          cVar4 = FUN_1818279a0(lVar15,lVar11.heroName,DAT_181d7c4d0);
          if (cVar4) goto LAB_180eb3701;
          if ((this.heroDetailPanel == null) ||
             (lVar11 = GameObject.get_transform(this.heroDetailPanel,0)) == null)
          goto LAB_180eb931a;
          lVar11 = Transform.Find(lVar11,"RecruitLock",0);
          plVar16 = (int64 *)Vector3.get_one(local_b8,0);
          if (lVar11 == null) goto LAB_180eb931a;
          local_148 = *plVar16;
          lStack_140 = CONCAT44(lStack_140._4_4_,(int)plVar16[1]);
          Transform.set_localScale(lVar11,&local_148,0);
          if (((this.heroDetailPanel == null) ||
              (lVar11 = GameObject.get_transform(this.heroDetailPanel,0)) == null) ||
             (lVar11 = Transform.Find(lVar11,"RecruitLock",0)) == null) goto LAB_180eb931a;
          local_148 = Component.GetComponent(lVar11,DAT_181d6ccc0);
          plVar16 = (int64 *)FUN_1800d60b0(DAT_181d7f180,5);
          if ((this.nowShowHero == null) ||
             (lVar11 = HeroData.GetHeroForceLvDescribeSimplify(this.nowShowHero,0),
             plVar16 == (int64 *)0)) goto LAB_180eb931a;
          if ((lVar11 != null) &&
             (lVar15 = il2cpp_internal(lVar11,*(uint64 *)(*plVar16 + 64))) == null) {
            uVar12 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar12,0);
          }
          FUN_180002fd0(plVar16,0,lVar11);
          if (this.nowShowHero == null) goto LAB_180eb931a;
          local_120 = HeroData.GetRecruitUnlockCost(this.nowShowHero,0);
          lVar11 = il2cpp_value_box(DAT_181d5b2f8,&local_120);
          if ((lVar11 != null) &&
             (lVar15 = il2cpp_internal(lVar11,*(uint64 *)(*plVar16 + 64))) == null) {
            uVar12 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar12,0);
          }
          FUN_180002fd0(plVar16,1,lVar11);
          if (this.nowShowHero == null) goto LAB_180eb931a;
          local_res8[0] = (float)HeroData.GetRecruitUnlockRate(this.nowShowHero,0);
          local_res8[0] = local_res8[0] * 100.0;
          lVar11 = Single.ToString(local_res8,"f0",0);
          if ((lVar11 != null) &&
             (lVar15 = il2cpp_internal(lVar11,*(uint64 *)(*plVar16 + 64))) == null) {
            uVar12 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar12,0);
          }
          FUN_180002fd0(plVar16,2,lVar11);
          lVar11 = FUN_18046c0a0(0);
          if (((lVar11 == null) || (lVar11.summonControlable == null)) ||
             (lVar11 = WorldData.Player(lVar11.summonControlable,0), uVar12 = "{3}点击解锁{4}招募\n消耗{1}点门派威望({2}%)\n<color=grey>每解锁一名{0}角色招募，解锁{0}所需门派威望+10%</color>",
             lVar11 == null)) goto LAB_180eb931a;
          if (lVar11.belongForceID < 0) {
        LAB_180eb34a2:
            lVar11 = *(int64 *)(pStatics_ef00 + 0x3d0);
            if (lVar11 == null) goto LAB_180eb931a;
            uVar13 = FUN_180002f80(lVar11,5,DAT_181d7c9c0);
            uVar13 = GlobalData.GenerateRareLvColorText(uVar13,5);
            lVar15 = String.Format("需要 {0}\n",uVar13,0);
          }
          else {
            lVar11 = FUN_18046c0a0(0);
            if (((lVar11 == null) || (lVar11.summonControlable == null)) ||
               (lVar11 = WorldData.Player(lVar11.summonControlable,0)) == null)
            goto LAB_180eb931a;
            lVar15 = "";
            if (lVar11.heroForceLv < 5) goto LAB_180eb34a2;
          }
          if ((lVar15 != null) &&
             (lVar11 = il2cpp_internal(lVar15,*(uint64 *)(*plVar16 + 64))) == null) {
            uVar12 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar12,0);
          }
          FUN_180002fd0(plVar16,3,lVar15);
          lVar11 = this.nowShowHero;
          if (lVar11 == null) goto LAB_180eb931a;
          uVar13 = lVar11.heroName;
          uVar10 = lVar11.heroForceLv;
          local_130 = CONCAT44(local_130._4_4_,uVar10);
          if (((*(byte *)(DAT_181d4ef00 + 0x133) & 4) != 0) && (*(int *)(DAT_181d4ef00 + 224) == 0)) {
            il2cpp_runtime_class_init();
            uVar10 = (uint32)local_130;
          }
          lVar11 = GlobalData.GenerateRareLvColorText(uVar13,uVar10,0);
          if ((lVar11 != null) &&
             (lVar15 = il2cpp_internal(lVar11,*(uint64 *)(*plVar16 + 64))) == null) {
            uVar12 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar12,0);
          }
          FUN_180002fd0(plVar16,4,lVar11);
          uVar12 = String.Format(uVar12,plVar16,0);
          if (local_148 == 0) goto LAB_180eb931a;
          *(uint64 *)(local_148 + 24) = uVar12;
          if (((this.heroDetailPanel == null) ||
              (lVar11 = GameObject.get_transform(this.heroDetailPanel,0)) == null) ||
             (lVar11 = Transform.Find(lVar11,"RecruitLock",0)) == null) goto LAB_180eb931a;
          lVar11 = Component.GetComponent(lVar11,DAT_181d6af40);
          lVar15 = FUN_18046c0a0(0);
          if ((lVar15 == null) || (lVar15.itemListInteractType == null)) goto LAB_180eb931a;
          lVar15 = WorldData.Player(lVar15.itemListInteractType,0);
          if (lVar15 == null) goto LAB_180eb931a;
          bVar25 = (bool)cVar7;
          if (-1 < *(int *)(lVar15 + 132)) {
            lVar15 = FUN_18046c0a0(0);
            if ((lVar15 == null) || (lVar15.itemListInteractType == null)) goto LAB_180eb931a;
            lVar15 = WorldData.Player(lVar15.itemListInteractType,0);
            if (lVar15 == null) goto LAB_180eb931a;
            bVar25 = 4 < *(int *)(lVar15 + 184);
          }
          if (lVar11 == null) goto LAB_180eb931a;
          Selectable.set_interactable(lVar11,bVar25,0);
        }
        else {
        LAB_180eb3701:
          if ((this.heroDetailPanel == null) ||
             (lVar11 = GameObject.get_transform(this.heroDetailPanel,0)) == null)
          goto LAB_180eb931a;
          lVar11 = Transform.Find(lVar11,"RecruitLock",0);
          plVar16 = (int64 *)Vector3.get_zero(local_a8,0);
          if (lVar11 == null) goto LAB_180eb931a;
          local_148 = *plVar16;
          lStack_140 = CONCAT44(lStack_140._4_4_,(int)plVar16[1]);
          Transform.set_localScale(lVar11,&local_148,0);
        }
        if (((this.heroDetailPanel != null) &&
            (lVar11 = GameObject.get_transform(this.heroDetailPanel,0)) != null) &&
           (lVar11 = Transform.Find(lVar11,"Force",0)) != null) {
          uVar12 = Component.GetComponent(lVar11,DAT_181d6d8c0);
          if (this.nowShowHero != null) {
            uVar13 = HeroData.GetHeroForceLvDescribe(this.nowShowHero,1,0);
            LTLocalization.SetText(uVar12,uVar13,0);
            if (((this.heroDetailPanel != null) &&
                (lVar11 = GameObject.get_transform(this.heroDetailPanel,0)) != null) &&
               (lVar11 = Transform.Find(lVar11,"Force",0)) != null) {
              lVar15 = Component.GetComponent(lVar11,DAT_181d6ccc0);
              uVar12 = "月俸 {0}\n人口 {1}";
              lVar11 = this.nowShowHero;
              if (lVar11 != null) {
                lVar18 = "";
                if ((!lVar11.outsideForce) && (-1 < lVar11.belongForceID)) {
                  uVar13 = "-";
                  if (!lVar11.isLeader) {
                    uVar13 = Int32.ToString(lVar11 + 0x1f0,0);
                    lVar11 = this.nowShowHero;
                  }
                  if (lVar11 == null) goto LAB_180eb931a;
                  uVar14 = "-";
                  if (!lVar11.isLeader) {
                    uVar14 = Int32.ToString(lVar11 + 500,0);
                  }
                  lVar18 = String.Format(uVar12,uVar13,uVar14,0);
                }
                if (lVar15 != null) {
                  lVar15.itemGrid = lVar18;
                  if (((this.heroDetailPanel != null) &&
                      (lVar11 = GameObject.get_transform(this.heroDetailPanel,0)) != null)
                     && (lVar11 = Transform.Find(lVar11,"ForceJob",0)) != null) {
                    uVar12 = Component.GetComponent(lVar11,DAT_181d6d8c0);
                    lVar11 = this.nowShowHero;
                    if (lVar11 != null) {
                      if (lVar11.forceJobType == -1) {
                        lVar15 = "";
                        if (lVar11.branchLeaderAreaID != -1) {
                          lVar11 = FUN_18046c0a0(0);
                          if (lVar11 == null) goto LAB_180eb931a;
                          if (((this.nowShowHero == null) || (lVar11.summonControlable == null)
                              ) || (lVar11 = WorldData.GetArea(lVar11.summonControlable,
                                                                *(uint32 *)
                                                                 (this.nowShowHero + 156),0)
                                   , lVar11 == null)) goto LAB_180eb931a;
                          lVar15 = String.Concat(lVar11.summonLv,"舵主",0);
                        }
                      }
                      else {
                        lVar11 = FUN_18046c100(0);
                        if (lVar11 == null) goto LAB_180eb931a;
                        lVar11 = lVar11.hide;
                        if (this.nowShowHero == null) goto LAB_180eb931a;
                        uVar22 = this.nowShowHero.forceJobType;
                        if (lVar11 == null) goto LAB_180eb931a;
                        if (lVar11.summonLv <= uVar22) {
                          ThrowHelper.ThrowArgumentOutOfRangeException(0);
                        }
                        lVar11 = *(int64 *)
                                  (lVar11.isSummon + 32 + (int64)(int)uVar22 * 8);
                        if (lVar11 == null) goto LAB_180eb931a;
                        lVar11 = lVar11.summonLv;
                        if (this.nowShowHero == null) goto LAB_180eb931a;
                        uVar22 = this.nowShowHero.forceJobID;
                        if (lVar11 == null) goto LAB_180eb931a;
                        if (lVar11.summonLv <= uVar22) {
                          ThrowHelper.ThrowArgumentOutOfRangeException(0);
                        }
                        lVar11 = *(int64 *)
                                  (lVar11.isSummon + 32 + (int64)(int)uVar22 * 8);
                        if (lVar11 == null) goto LAB_180eb931a;
                        lVar15 = lVar11.isSummon;
                      }
                      LTLocalization.SetText(uVar12,lVar15,0);
                      if (((this.heroDetailPanel != null) &&
                          (lVar11 = GameObject.get_transform(this.heroDetailPanel,0),
                          lVar11 != null)) && (lVar11 = Transform.Find(lVar11,"Name",0)) != null
                         ) {
                        uVar12 = Component.GetComponent(lVar11,DAT_181d6d8c0);
                        if (this.nowShowHero != null) {
                          uVar13 = HeroData.HeroName(this.nowShowHero,1,0);
                          LTLocalization.SetText(uVar12,uVar13,0);
                          if (targetHero != null) {
                            lVar11 = this.heroDetailPanel;
                            if (*(char *)(targetHero + 0x1b8) == false) {
                              if ((((lVar11 == null) ||
                                   (lVar11 = GameObject.get_transform(lVar11,0)) == null) ||
                                  (lVar11 = Transform.Find(lVar11,"Hornor",0)) == null) ||
                                 (lVar11 = Component.get_gameObject(lVar11,0)) == null)
                              goto LAB_180eb931a;
                              cVar4 = GameObject.get_activeSelf(lVar11,0);
                              if (cVar4) {
                                if (((this.heroDetailPanel == null) ||
                                    (lVar11 = GameObject.get_transform(this.heroDetailPanel,0),
                                    lVar11 == null)) ||
                                   ((lVar11 = Transform.Find(lVar11,"Hornor",0), lVar11 == null ||
                                    (lVar11 = Component.get_gameObject(lVar11,0)) == null)))
                                goto LAB_180eb931a;
                                GameObject.SetActive(lVar11,0,0);
                              }
                            }
                            else {
                              if (((lVar11 == null) ||
                                  (lVar11 = GameObject.get_transform(lVar11,0)) == null) ||
                                 ((lVar11 = Transform.Find(lVar11,"Hornor",0), lVar11 == null ||
                                  (lVar11 = Component.get_gameObject(lVar11,0)) == null)))
                              goto LAB_180eb931a;
                              cVar4 = GameObject.get_activeSelf(lVar11,0);
                              if (!cVar4) {
                                if (((this.heroDetailPanel == null) ||
                                    (lVar11 = GameObject.get_transform(this.heroDetailPanel,0),
                                    lVar11 == null)) ||
                                   (lVar11 = Transform.Find(lVar11,"Hornor",0)) == null)
                                goto LAB_180eb931a;
                                lVar11 = Component.get_gameObject(lVar11,0);
                                if (lVar11 == null) goto LAB_180eb931a;
                                GameObject.SetActive(lVar11,1,0);
                              }
                              if (((this.heroDetailPanel == null) ||
                                  (lVar11 = GameObject.get_transform(this.heroDetailPanel,0),
                                  lVar11 == null)) ||
                                 ((lVar11 = Transform.Find(lVar11,"Hornor",0), lVar11 == null ||
                                  (lVar11 = Transform.Find(lVar11,"HornorLv",0)) == null)))
                              goto LAB_180eb931a;
                              uVar12 = Component.GetComponent(lVar11,DAT_181d6d8c0);
                              uVar22 = *(uint32 *)(targetHero + 0x1bc);
                              lVar11 = *(int64 *)(pStatics_ef00 + 1000);
                              if (lVar11 == null) goto LAB_180eb931a;
                              if (lVar11.summonLv <= uVar22) {
                                ThrowHelper.ThrowArgumentOutOfRangeException(0);
                              }
                              uVar13 = String.Concat("御赐勋阶\n",
                                                      *(uint64 *)
                                                       (lVar11.isSummon + 32 +
                                                       (int64)(int)uVar22 * 8),0);
                              LTLocalization.SetText(uVar12,uVar13,0);
                              if ((((this.heroDetailPanel == null) ||
                                   (lVar11 = GameObject.get_transform(this.heroDetailPanel,0),
                                   lVar11 == null)) ||
                                  (lVar11 = Transform.Find(lVar11,"Hornor",0)) == null) ||
                                 (lVar11 = Transform.Find(lVar11,"HornorLv",0)) == null)
                              goto LAB_180eb931a;
                              plVar16 = (int64 *)Component.GetComponent(lVar11,DAT_181d6d8c0);
                              lVar11 = FUN_18046c100(0);
                              if (lVar11 == null) goto LAB_180eb931a;
                              lVar11 = lVar11.dailyAIManaged;
                              lVar15 = FUN_18046c100(0);
                              if ((lVar15 == null) || (lVar15.showAllButton == null))
                              goto LAB_180eb931a;
                              uVar22 = Mathf.Min(*(int *)(lVar15.showAllButton + 24) + -1,
                                                  (int)((float)*(int *)(targetHero + 0x1bc) * 0.5),0);
                              if (lVar11 == null) goto LAB_180eb931a;
                              if (lVar11.summonLv <= uVar22) {
                                ThrowHelper.ThrowArgumentOutOfRangeException(0);
                              }
                              lVar11 = *(int64 *)
                                        (lVar11.isSummon + 32 + (int64)(int)uVar22 * 8);
                              if ((lVar11 == null) || (plVar16 == (int64 *)0)) goto LAB_180eb931a;
                              local_148 = lVar11.summonLv;
                              lStack_140 = lVar11.summonControlable;
                              (**(code **)(*plVar16 + 0x2a8))
                                        (plVar16,&local_148,*(uint64 *)(*plVar16 + 0x2b0));
                              if ((this.heroDetailPanel == null) ||
                                 (((lVar11 = GameObject.get_transform(this.heroDetailPanel,0),
                                   lVar11 == null ||
                                   (lVar11 = Transform.Find(lVar11,"Hornor",0)) == null) ||
                                  (lVar11 = Transform.Find(lVar11,"Back",0)) == null)))
                              goto LAB_180eb931a;
                              local_148 = Component.GetComponent(lVar11,DAT_181d6ccc0);
                              plVar16 = (int64 *)FUN_1800d60b0(DAT_181d7f180,4);
                              uVar12 = "{1}\n好感加成{2}%\n恶名减少{3}%\n{0}";
                              lVar11 = *(int64 *)(pStatics_ef00 + 1000);
                              if (lVar11 == null) goto LAB_180eb931a;
                              lVar15 = "登峰造极";
                              if (*(int *)(targetHero + 0x1bc) < lVar11.summonLv + -1) {
                                local_11c = (int)*(float *)(targetHero + 0x1b4);
                                uVar13 = il2cpp_value_box(DAT_181d5b2f8,&local_11c);
                                local_118 = HeroData.GetHornorUpgradeCost(targetHero,0);
                                uVar14 = il2cpp_value_box(DAT_181d7d0b8,&local_118);
                                lVar15 = String.Format("升级功绩{0}/{1}",uVar13,uVar14,0);
                              }
                              if (plVar16 == (int64 *)0) goto LAB_180eb931a;
                              if ((lVar15 != null) &&
                                 (lVar11 = il2cpp_internal(lVar15,*(uint64 *)(*plVar16 + 64)),
                                 lVar11 == null)) {
                                uVar12 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar12,0);
                              }
                              if ((int)plVar16[3] == 0) {
                                uVar12 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar12,0);
                              }
                              plVar16[4] = lVar15;
                              il2cpp_internal(plVar16 + 4,lVar15);
                              lVar11 = *(int64 *)(pStatics_ef00 + 0x3f0);
                              uVar22 = *(uint32 *)(targetHero + 0x1bc);
                              local_130 = CONCAT44(local_130._4_4_,uVar22);
                              if (lVar11 == null) goto LAB_180eb931a;
                              if (lVar11.summonLv <= uVar22) {
                                ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                uVar22 = (uint32)local_130;
                              }
                              lVar11 = *(int64 *)
                                        (lVar11.isSummon + 32 + (int64)(int)uVar22 * 8);
                              if ((lVar11 != null) &&
                                 (lVar15 = il2cpp_internal(lVar11,*(uint64 *)(*plVar16 + 64)),
                                 lVar15 == null)) {
                                uVar12 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar12,0);
                              }
                              if (*(uint32 *)(plVar16 + 3) < 2) {
                                uVar12 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar12,0);
                              }
                              plVar16[5] = lVar11;
                              il2cpp_internal(plVar16 + 5,lVar11);
                              local_res8[0] = (float)HeroData.GetHornorAddFavorRate(targetHero,0);
                              local_res8[0] = local_res8[0] * 100.0;
                              lVar11 = Single.ToString(local_res8,"f0",0);
                              if ((lVar11 != null) &&
                                 (lVar15 = il2cpp_internal(lVar11,*(uint64 *)(*plVar16 + 64)),
                                 lVar15 == null)) {
                                uVar12 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar12,0);
                              }
                              if (*(uint32 *)(plVar16 + 3) < 3) {
                                uVar12 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar12,0);
                              }
                              plVar16[6] = lVar11;
                              il2cpp_internal(plVar16 + 6,lVar11);
                              local_res8[0] = (float)HeroData.GetHornorAddFavorRate(targetHero,0);
                              local_res8[0] = local_res8[0] * 100.0;
                              lVar11 = Single.ToString(local_res8,"f0",0);
                              if ((lVar11 != null) &&
                                 (lVar15 = il2cpp_internal(lVar11,*(uint64 *)(*plVar16 + 64)),
                                 lVar15 == null)) {
                                uVar12 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar12,0);
                              }
                              if (*(uint32 *)(plVar16 + 3) < 4) {
                                uVar12 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar12,0);
                              }
                              plVar16[7] = lVar11;
                              il2cpp_internal(plVar16 + 7,lVar11);
                              uVar12 = String.Format(uVar12,plVar16,0);
                              if (local_148 == 0) goto LAB_180eb931a;
                              *(uint64 *)(local_148 + 24) = uVar12;
                            }
                            lVar11 = this.heroDetailPanel;
                            if (*(char *)(targetHero + 0x1ac) == false) {
                              if ((((lVar11 == null) ||
                                   (lVar11 = GameObject.get_transform(lVar11,0)) == null) ||
                                  (lVar11 = Transform.Find(lVar11,"Gov",0)) == null) ||
                                 (lVar11 = Component.get_gameObject(lVar11,0)) == null)
                              goto LAB_180eb931a;
                              cVar4 = GameObject.get_activeSelf(lVar11,0);
                              if (cVar4) {
                                if (((this.heroDetailPanel == null) ||
                                    (lVar11 = GameObject.get_transform(this.heroDetailPanel,0),
                                    lVar11 == null)) ||
                                   ((lVar11 = Transform.Find(lVar11,"Gov",0), lVar11 == null ||
                                    (lVar11 = Component.get_gameObject(lVar11,0)) == null)))
                                goto LAB_180eb931a;
                                GameObject.SetActive(lVar11,0,0);
                              }
                            }
                            else {
                              if (((lVar11 == null) ||
                                  (lVar11 = GameObject.get_transform(lVar11,0)) == null) ||
                                 ((lVar11 = Transform.Find(lVar11,"Gov",0), lVar11 == null ||
                                  (lVar11 = Component.get_gameObject(lVar11,0)) == null)))
                              goto LAB_180eb931a;
                              cVar4 = GameObject.get_activeSelf(lVar11,0);
                              if (!cVar4) {
                                if (((this.heroDetailPanel == null) ||
                                    (lVar11 = GameObject.get_transform(this.heroDetailPanel,0),
                                    lVar11 == null)) ||
                                   (lVar11 = Transform.Find(lVar11,"Gov",0)) == null)
                                goto LAB_180eb931a;
                                lVar11 = Component.get_gameObject(lVar11,0);
                                if (lVar11 == null) goto LAB_180eb931a;
                                GameObject.SetActive(lVar11,1,0);
                              }
                              if (((this.heroDetailPanel == null) ||
                                  (lVar11 = GameObject.get_transform(this.heroDetailPanel,0),
                                  lVar11 == null)) ||
                                 ((lVar11 = Transform.Find(lVar11,"Gov",0), lVar11 == null ||
                                  (lVar11 = Transform.Find(lVar11,"GovLv",0)) == null)))
                              goto LAB_180eb931a;
                              uVar12 = Component.GetComponent(lVar11,DAT_181d6d8c0);
                              uVar22 = *(uint32 *)(targetHero + 0x1b0);
                              lVar11 = *(int64 *)(pStatics_ef00 + 0x3e0);
                              if (lVar11 == null) goto LAB_180eb931a;
                              if (lVar11.summonLv <= uVar22) {
                                ThrowHelper.ThrowArgumentOutOfRangeException(0);
                              }
                              uVar13 = String.Concat("官府职位\n",
                                                      *(uint64 *)
                                                       (lVar11.isSummon + 32 +
                                                       (int64)(int)uVar22 * 8),0);
                              LTLocalization.SetText(uVar12,uVar13,0);
                              if ((((this.heroDetailPanel == null) ||
                                   (lVar11 = GameObject.get_transform(this.heroDetailPanel,0),
                                   lVar11 == null)) ||
                                  (lVar11 = Transform.Find(lVar11,"Gov",0)) == null) ||
                                 (lVar11 = Transform.Find(lVar11,"GovLv",0)) == null)
                              goto LAB_180eb931a;
                              plVar16 = (int64 *)Component.GetComponent(lVar11,DAT_181d6d8c0);
                              lVar11 = FUN_18046c100(0);
                              if (lVar11 == null) goto LAB_180eb931a;
                              lVar11 = lVar11.dailyAIManaged;
                              lVar15 = FUN_18046c100(0);
                              if ((lVar15 == null) || (lVar15.showAllButton == null))
                              goto LAB_180eb931a;
                              uVar22 = Mathf.Min(*(int *)(lVar15.showAllButton + 24) + -1,
                                                  (int)((float)*(int *)(targetHero + 0x1b0) * 0.5),0);
                              if (lVar11 == null) goto LAB_180eb931a;
                              if (lVar11.summonLv <= uVar22) {
                                ThrowHelper.ThrowArgumentOutOfRangeException(0);
                              }
                              lVar11 = *(int64 *)
                                        (lVar11.isSummon + 32 + (int64)(int)uVar22 * 8);
                              if ((lVar11 == null) || (plVar16 == (int64 *)0)) goto LAB_180eb931a;
                              local_148 = lVar11.summonLv;
                              lStack_140 = lVar11.summonControlable;
                              (**(code **)(*plVar16 + 0x2a8))
                                        (plVar16,&local_148,*(uint64 *)(*plVar16 + 0x2b0));
                              if ((this.heroDetailPanel == null) ||
                                 (((lVar11 = GameObject.get_transform(this.heroDetailPanel,0),
                                   lVar11 == null ||
                                   (lVar11 = Transform.Find(lVar11,"Gov",0)) == null) ||
                                  (lVar11 = Transform.Find(lVar11,"Back",0)) == null)))
                              goto LAB_180eb931a;
                              local_148 = Component.GetComponent(lVar11,DAT_181d6ccc0);
                              plVar16 = (int64 *)FUN_1800d60b0(DAT_181d7f180,4);
                              uVar12 = "{1}\n声望加成{2}%\n恶名减少{3}%\n{0}";
                              lVar11 = *(int64 *)(pStatics_ef00 + 0x3e0);
                              if (lVar11 == null) goto LAB_180eb931a;
                              lVar15 = "登峰造极";
                              if (*(int *)(targetHero + 0x1b0) < lVar11.summonLv + -1) {
                                local_114 = (int)*(float *)(targetHero + 0x1b4);
                                uVar13 = il2cpp_value_box(DAT_181d5b2f8,&local_114);
                                local_110 = HeroData.GetGovernUpgradeCost(targetHero,0);
                                uVar14 = il2cpp_value_box(DAT_181d7d0b8,&local_110);
                                lVar15 = String.Format("升级功绩{0}/{1}",uVar13,uVar14,0);
                              }
                              if (plVar16 == (int64 *)0) goto LAB_180eb931a;
                              if ((lVar15 != null) &&
                                 (lVar11 = il2cpp_internal(lVar15,*(uint64 *)(*plVar16 + 64)),
                                 lVar11 == null)) {
                                uVar12 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar12,0);
                              }
                              if ((int)plVar16[3] == 0) {
                                uVar12 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar12,0);
                              }
                              plVar16[4] = lVar15;
                              il2cpp_internal(plVar16 + 4,lVar15);
                              lVar11 = *(int64 *)(pStatics_ef00 + 0x3f0);
                              uVar22 = *(uint32 *)(targetHero + 0x1b0);
                              local_130 = CONCAT44(local_130._4_4_,uVar22);
                              if (lVar11 == null) goto LAB_180eb931a;
                              if (lVar11.summonLv <= uVar22) {
                                ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                uVar22 = (uint32)local_130;
                              }
                              lVar11 = *(int64 *)
                                        (lVar11.isSummon + 32 + (int64)(int)uVar22 * 8);
                              if ((lVar11 != null) &&
                                 (lVar15 = il2cpp_internal(lVar11,*(uint64 *)(*plVar16 + 64)),
                                 lVar15 == null)) {
                                uVar12 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar12,0);
                              }
                              if (*(uint32 *)(plVar16 + 3) < 2) {
                                uVar12 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar12,0);
                              }
                              plVar16[5] = lVar11;
                              il2cpp_internal(plVar16 + 5,lVar11);
                              local_res8[0] = (float)HeroData.GetGovernExtraFameRate(targetHero,0);
                              local_res8[0] = local_res8[0] * 100.0;
                              lVar11 = Single.ToString(local_res8,"f0",0);
                              if ((lVar11 != null) &&
                                 (lVar15 = il2cpp_internal(lVar11,*(uint64 *)(*plVar16 + 64)),
                                 lVar15 == null)) {
                                uVar12 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar12,0);
                              }
                              if (*(uint32 *)(plVar16 + 3) < 3) {
                                uVar12 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar12,0);
                              }
                              plVar16[6] = lVar11;
                              il2cpp_internal(plVar16 + 6,lVar11);
                              local_res8[0] = (float)HeroData.GetGovernReduceBadFameRate(targetHero,0);
                              local_res8[0] = local_res8[0] * 100.0;
                              lVar11 = Single.ToString(local_res8,"f0",0);
                              if ((lVar11 != null) &&
                                 (lVar15 = il2cpp_internal(lVar11,*(uint64 *)(*plVar16 + 64)),
                                 lVar15 == null)) {
                                uVar12 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar12,0);
                              }
                              if (*(uint32 *)(plVar16 + 3) < 4) {
                                uVar12 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar12,0);
                              }
                              plVar16[7] = lVar11;
                              il2cpp_internal(plVar16 + 7,lVar11);
                              uVar12 = String.Format(uVar12,plVar16,0);
                              if (local_148 == 0) goto LAB_180eb931a;
                              *(uint64 *)(local_148 + 24) = uVar12;
                            }
                            if (((this.heroDetailPanel != null) &&
                                (lVar11 = GameObject.get_transform(this.heroDetailPanel,0),
                                lVar11 != null)) &&
                               (lVar11 = Transform.Find(lVar11,"FightScore",0)) != null) {
                              uVar12 = Component.GetComponent(lVar11,DAT_181d6d8c0);
                              if (this.nowShowHero != null) {
                                uVar13 = Single.ToString(this.nowShowHero + 0x38c,
                                                          "f0",0);
                                LTLocalization.SetText(uVar12,uVar13,0);
                                if ((((this.heroDetailPanel != null) &&
                                     (lVar11 = GameObject.get_transform(this.heroDetailPanel,0),
                                     lVar11 != null)) &&
                                    (lVar11 = Transform.Find(lVar11,"Fame",0)) != null) &&
                                   (lVar11 = Transform.Find(lVar11,"Label",0)) != null) {
                                  uVar12 = Component.GetComponent(lVar11,DAT_181d6d8c0);
                                  if (this.nowShowHero != null) {
                                    uVar13 = Single.ToString(this.nowShowHero + 0x1c4,
                                                              "f0",0);
                                    LTLocalization.SetText(uVar12,uVar13,0);
                                    if (((this.heroDetailPanel != null) &&
                                        (lVar11 = GameObject.get_transform
                                                            (this.heroDetailPanel,0), lVar11 != null
                                        )) && ((lVar11 = Transform.Find(lVar11,"BadFame",0),
                                               lVar11 != null &&
                                               (lVar11 = Transform.Find(lVar11,"Label",0),
                                               lVar11 != null)))) {
                                      uVar12 = Component.GetComponent(lVar11,DAT_181d6d8c0);
                                      if (this.nowShowHero != null) {
                                        uVar13 = Single.ToString(this.nowShowHero + 0x1c8,
                                                                  "f0",0);
                                        LTLocalization.SetText(uVar12,uVar13,0);
                                        if (((this.heroDetailPanel != null) &&
                                            (lVar11 = GameObject.get_transform
                                                                (this.heroDetailPanel,0),
                                            lVar11 != null)) &&
                                           ((lVar11 = Transform.Find(lVar11,"BadFame",0), lVar11 != null
                                            && (lVar11 = Transform.Find(lVar11,"Bounty",0),
                                               lVar11 != null)))) {
                                          uVar12 = Component.GetComponent(lVar11,DAT_181d6d8c0);
                                          if (this.nowShowHero != null) {
                                            iVar9 = HeroData.GetBountyPirce
                                                              (this.nowShowHero,0);
                                            lVar11 = "";
                                            if (0 < iVar9) {
                                              if (this.nowShowHero == null) goto LAB_180eb931a;
                                              local_10c = HeroData.GetBountyPirce
                                                                    (this.nowShowHero,0);
                                              uVar13 = il2cpp_value_box(DAT_181d5b2f8,&local_10c);
                                              lVar11 = String.Format("悬赏{0}两",uVar13,0);
                                            }
                                            LTLocalization.SetText(uVar12,lVar11,0);
                                            if ((((this.heroDetailPanel != null) &&
                                                 (lVar11 = GameObject.get_transform
                                                                     (this.heroDetailPanel,0),
                                                 lVar11 != null)) &&
                                                (lVar11 = Transform.Find(lVar11,"Money",0),
                                                lVar11 != null)) &&
                                               (lVar11 = Transform.Find(lVar11,"Label",0),
                                               lVar11 != null)) {
                                              uVar12 = Component.GetComponent(lVar11,DAT_181d6d8c0);
                                              if ((this.nowShowHero != null) &&
                                                 (lVar11 = *(int64 *)
                                                            (this.nowShowHero + 0x220),
                                                 lVar11 != null)) {
                                                uVar13 = Int32.ToString(lVar11 + 24,"f0",0);
                                                LTLocalization.SetText(uVar12,uVar13,0);
                                                if (this.nowShowHero != null) {
                                                  cVar4 = HeroData.NoLoyal(this.nowShowHero,
                                                                            0);
                                                  lVar11 = this.heroDetailPanel;
                                                  if (!cVar4) {
                                                    if ((lVar11 == null) ||
                                                       (lVar11 = GameObject.get_transform(lVar11,0),
                                                       lVar11 == null)) goto LAB_180eb931a;
                                                    lVar11 = Transform.Find(lVar11,"Loyal",0);
                                                    plVar16 = (int64 *)Vector3.get_one(local_98,0);
                                                    if (lVar11 == null) goto LAB_180eb931a;
                                                    local_148 = *plVar16;
                                                    lStack_140 = CONCAT44(lStack_140._4_4_,(int)plVar16[1]
                                                                         );
                                                    Transform.set_localScale(lVar11,&local_148,0);
                                                    if ((((this.heroDetailPanel == null) ||
                                                         (lVar11 = GameObject.get_transform
                                                                             (*(int64 *)
                                                                               (this + 32),0),
                                                         lVar11 == null)) ||
                                                        (lVar11 = Transform.Find(lVar11,"Loyal",0),
                                                        lVar11 == null)) ||
                                                       (lVar11 = Transform.Find(lVar11,"Label",0),
                                                       lVar11 == null)) goto LAB_180eb931a;
                                                    uVar12 = Component.GetComponent(lVar11,DAT_181d6d8c0)
                                                    ;
                                                    if (this.nowShowHero == null)
                                                    goto LAB_180eb931a;
                                                    uVar13 = Single.ToString(*(int64 *)
                                                                               (this + 96) + 0x1cc,
                                                                              "f0",0);
                                                    LTLocalization.SetText(uVar12,uVar13,0);
                                                    if (this.nowShowHero == null)
                                                    goto LAB_180eb931a;
                                                    fVar26 = (float)HeroData.GetBetrayForceRate
                                                                              (*(int64 *)
                                                                                (this + 96),0);
                                                    if (((this.heroDetailPanel == null) ||
                                                        (lVar11 = GameObject.get_transform
                                                                            (this.heroDetailPanel
                                                                             ,0), lVar11 == null)) ||
                                                       (lVar11 = Transform.Find(lVar11,"Loyal",0),
                                                       lVar11 == null)) goto LAB_180eb931a;
                                                    lVar11 = Component.GetComponent(lVar11,DAT_181d6ccc0)
                                                    ;
                                                    uVar12 = "忠诚\n♦影响弟子工作效率，如习武练功/资源采集/物品制造等。\n♦每月自动向50点靠拢，可通过嘉奖/门派宴会快速提升。{0}";
                                                    if (this.nowShowHero == null)
                                                    goto LAB_180eb931a;
                                                    uVar13 = "\n♦特殊角色不会叛离门派。";
                                                    if (this.nowShowHero.speHero ==
                                                        false) {
                                                      local_res8[0] = fVar26 * 100.0;
                                                      local_130 = Single.ToString(local_res8,
                                                                                   "f0",0);
                                                      uVar13 = "\n♦忠诚小于50时，每月有概率叛离门派。\n{1}每月叛离概率:{0}%</color>";
                                                      if (this.nowShowHero == null)
                                                      goto LAB_180eb931a;
                                                      if (*(float *)(this.nowShowHero + 0x1cc
                                                                    ) < 50.0) {
                                                        if (fVar26 <= 0.05) {
                                                          if (((*(byte *)(DAT_181d4ef00 + 0x133) & 4) != 0
                                                              ) && (*(int *)(DAT_181d4ef00 + 224) == 0))
                                                          {
                                                            il2cpp_runtime_class_init
                                                                      (DAT_181d4ef00,local_130);
                                                          }
                                                          uVar14 = *(uint64 *)
                                                                    (pStatics_ef00 +
                                                                    0x230);
                                                        }
                                                        else {
                                                          if (((*(byte *)(DAT_181d4ef00 + 0x133) & 4) != 0
                                                              ) && (*(int *)(DAT_181d4ef00 + 224) == 0))
                                                          {
                                                            il2cpp_runtime_class_init
                                                                      (DAT_181d4ef00,local_130);
                                                          }
                                                          uVar14 = *(uint64 *)
                                                                    (pStatics_ef00 +
                                                                    0x2c8);
                                                        }
                                                      }
                                                      else {
                                                        if (((*(byte *)(DAT_181d4ef00 + 0x133) & 4) != 0)
                                                           && (*(int *)(DAT_181d4ef00 + 224) == 0)) {
                                                          il2cpp_runtime_class_init
                                                                    (DAT_181d4ef00,local_130);
                                                        }
                                                        uVar14 = *(uint64 *)
                                                                  (pStatics_ef00 +
                                                                  0x260);
                                                      }
                                                      uVar13 = String.Format(uVar13,local_130,uVar14,0);
                                                    }
                                                    uVar12 = String.Format(uVar12,uVar13,0);
                                                    if (lVar11 == null) goto LAB_180eb931a;
                                                    lVar11.summonLv = uVar12;
                                                    il2cpp_internal((uint64 *)(lVar11 + 24),
                                                                        uVar12);
                                                  }
                                                  else {
                                                    if ((lVar11 == null) ||
                                                       (lVar11 = GameObject.get_transform(lVar11,0),
                                                       lVar11 == null)) goto LAB_180eb931a;
                                                    lVar11 = Transform.Find(lVar11,"Loyal",0);
                                                    plVar16 = (int64 *)Vector3.get_zero(local_88,0);
                                                    if (lVar11 == null) goto LAB_180eb931a;
                                                    local_148 = *plVar16;
                                                    lStack_140 = CONCAT44(lStack_140._4_4_,(int)plVar16[1]
                                                                         );
                                                    Transform.set_localScale(lVar11,&local_148,0);
                                                  }
                                                  if ((((this.heroDetailPanel != null) &&
                                                       (lVar11 = GameObject.get_transform
                                                                           (this.heroDetailPanel,
                                                                            0), lVar11 != null)) &&
                                                      (lVar11 = Transform.Find(lVar11,"InfoTabs",0),
                                                      lVar11 != null)) &&
                                                     ((lVar11 = Transform.Find(lVar11,"LogTab",0),
                                                      lVar11 != null &&
                                                      (lVar11 = Component.get_gameObject(lVar11,0),
                                                      lVar11 != null)))) {
                                                    cVar4 = GameObject.get_activeSelf(lVar11,0);
                                                    if (this.nowShowHero != null) {
                                                      bVar25 = false;
                                                      if ((bool)cVar4 !=
                                                          (this.nowShowHero.heroID
                                                          != 0)) {
                                                        if (((this.heroDetailPanel == null) ||
                                                            (lVar11 = GameObject.get_transform
                                                                                (*(int64 *)
                                                                                  (this + 32),0),
                                                            lVar11 == null)) ||
                                                           ((lVar11 = Transform.Find(lVar11,"InfoTabs"
                                                                                      ,0), lVar11 == null ||
                                                            (lVar11 = Transform.Find(lVar11,"LogTab"
                                                                                      ,0), lVar11 == null))))
                                                        goto LAB_180eb931a;
                                                        lVar11 = Component.get_gameObject(lVar11,0);
                                                        if ((this.nowShowHero == null) ||
                                                           (lVar11 == null)) goto LAB_180eb931a;
                                                        GameObject.SetActive
                                                                  (lVar11,*(int *)(*(int64 *)
                                                                                    (this + 96) +
                                                                                  88) != 0,0);
                                                        if ((this.heroDetailPanel == null) ||
                                                           (((lVar11 = GameObject.get_transform
                                                                                 (*(int64 *)
                                                                                   (this + 32),0),
                                                             lVar11 == null ||
                                                             (lVar11 = Transform.Find(lVar11,
                                                        "InfoTabs",0), lVar11 == null)) ||
                                                        (lVar11 = Component.GetComponent
                                                                            (lVar11,DAT_181d6e0c0),
                                                        lVar11 == null)))) goto LAB_180eb931a;
                                                        UIGrid.set_repositionNow(lVar11,1,0);
                                                      }
                                                      if (((this.heroDetailPanel != null) &&
                                                          (lVar11 = GameObject.get_transform
                                                                              (*(int64 *)
                                                                                (this + 32),0),
                                                          lVar11 != null)) &&
                                                         ((lVar11 = Transform.Find(lVar11,"InfoTabs",0
                                                                                   ), lVar11 != null &&
                                                          ((lVar11 = Transform.Find(lVar11,"LogTab",
                                                                                     0), lVar11 != null &&
                                                           (lVar11 = Component.GetComponent
                                                                               (lVar11,DAT_181d6da40),
                                                           lVar11 != null)))))) {
                                                        if (lVar11.goodKungfuSkillName) {
                                                          if (this.nowShowHero == null)
                                                          goto LAB_180eb931a;
                                                          if (*(int *)(this.nowShowHero +
                                                                      88) == 0) {
                                                            if ((((this.heroDetailPanel == null) ||
                                                                 (lVar11 = GameObject.get_transform
                                                                                     (*(int64 *)
                                                                                       (this + 32),0)
                                                                 , lVar11 == null)) ||
                                                                (lVar11 = Transform.Find(lVar11,
                                                        "InfoTabs",0), lVar11 == null)) ||
                                                        ((lVar11 = Transform.Find(lVar11,"BaseInfoTab",0)
                                                         , lVar11 == null ||
                                                         (lVar11 = Component.GetComponent
                                                                             (lVar11,DAT_181d6da40),
                                                         lVar11 == null)))) goto LAB_180eb931a;
                                                        Toggle.set_isOn(lVar11,1,0);
                                                        if ((((this.heroDetailPanel == null) ||
                                                             ((lVar11 = GameObject.get_transform
                                                                                  (*(int64 *)
                                                                                    (this + 32),0),
                                                              lVar11 == null ||
                                                              (lVar11 = Transform.Find(lVar11,
                                                        "InfoTabs",0), lVar11 == null)))) ||
                                                        (lVar11 = Transform.Find(lVar11,"LogTab",0),
                                                        lVar11 == null)) ||
                                                        (lVar11 = Component.GetComponent
                                                                            (lVar11,DAT_181d6da40),
                                                        lVar11 == null)) goto LAB_180eb931a;
                                                        Toggle.set_isOn(lVar11,0,0);
                                                        }
                                                        }
                                                        if ((((this.heroDetailPanel != null) &&
                                                             (lVar11 = GameObject.get_transform
                                                                                 (*(int64 *)
                                                                                   (this + 32),0),
                                                             lVar11 != null)) &&
                                                            (lVar11 = Transform.Find(lVar11,"InfoTabs"
                                                                                      ,0), lVar11 != null))
                                                           && ((lVar11 = Transform.Find(lVar11,
                                                        "ForceContributionTab",0), lVar11 != null &&
                                                        (lVar11 = Component.get_gameObject(lVar11,0),
                                                        lVar11 != null)))) {
                                                          cVar4 = GameObject.get_activeSelf(lVar11,0);
                                                          if (this.nowShowHero != null) {
                                                            if ((bool)cVar4 !=
                                                                (*(int *)(this.nowShowHero +
                                                                         88) == 0)) {
                                                              if (((this.heroDetailPanel == null) ||
                                                                  (lVar11 = GameObject.get_transform
                                                                                      (*(int64 *)
                                                                                        (this + 32),0
                                                                                      ), lVar11 == null)) ||
                                                                 ((lVar11 = Transform.Find(lVar11,
                                                        "InfoTabs",0), lVar11 == null ||
                                                        (lVar11 = Transform.Find(lVar11,"ForceContributionTab",0),
                                                        lVar11 == null)))) goto LAB_180eb931a;
                                                        lVar11 = Component.get_gameObject(lVar11,0);
                                                        if ((this.nowShowHero == null) ||
                                                           (lVar11 == null)) goto LAB_180eb931a;
                                                        GameObject.SetActive
                                                                  (lVar11,*(int *)(*(int64 *)
                                                                                    (this + 96) +
                                                                                  88) == 0,0);
                                                        if ((this.heroDetailPanel == null) ||
                                                           (((lVar11 = GameObject.get_transform
                                                                                 (*(int64 *)
                                                                                   (this + 32),0),
                                                             lVar11 == null ||
                                                             (lVar11 = Transform.Find(lVar11,
                                                        "InfoTabs",0), lVar11 == null)) ||
                                                        (lVar11 = Component.GetComponent
                                                                            (lVar11,DAT_181d6e0c0),
                                                        lVar11 == null)))) goto LAB_180eb931a;
                                                        UIGrid.set_repositionNow(lVar11,1,0);
                                                        }
                                                        if (((this.heroDetailPanel != null) &&
                                                            (lVar11 = GameObject.get_transform
                                                                                (*(int64 *)
                                                                                  (this + 32),0),
                                                            lVar11 != null)) &&
                                                           ((lVar11 = Transform.Find(lVar11,"InfoTabs"
                                                                                      ,0), lVar11 != null &&
                                                            ((lVar11 = Transform.Find(lVar11,
                                                        "ForceContributionTab",0), lVar11 != null &&
                                                        (lVar11 = Component.GetComponent
                                                                            (lVar11,DAT_181d6da40),
                                                        lVar11 != null)))))) {
                                                          if (lVar11.goodKungfuSkillName) {
                                                            if (this.nowShowHero == null)
                                                            goto LAB_180eb931a;
                                                            if (*(int *)(this.nowShowHero +
                                                                        88) != 0) {
                                                              if ((((this.heroDetailPanel == null)
                                                                   || (lVar11 = GameObject.get_transform
                                                                                          (*(int64 *)
                                                                                            (this +
                                                                                            32),0),
                                                                      lVar11 == null)) ||
                                                                  (lVar11 = Transform.Find(lVar11,
                                                        "InfoTabs",0), lVar11 == null)) ||
                                                        ((lVar11 = Transform.Find(lVar11,"BaseInfoTab",0)
                                                         , lVar11 == null ||
                                                         (lVar11 = Component.GetComponent
                                                                             (lVar11,DAT_181d6da40),
                                                         lVar11 == null)))) goto LAB_180eb931a;
                                                        Toggle.set_isOn(lVar11,1,0);
                                                        if (((this.heroDetailPanel == null) ||
                                                            ((lVar11 = GameObject.get_transform
                                                                                 (*(int64 *)
                                                                                   (this + 32),0),
                                                             lVar11 == null ||
                                                             (lVar11 = Transform.Find(lVar11,
                                                        "InfoTabs",0), lVar11 == null)))) ||
                                                        ((lVar11 = Transform.Find(lVar11,"ForceContributionTab",0)
                                                         , lVar11 == null ||
                                                         (lVar11 = Component.GetComponent
                                                                             (lVar11,DAT_181d6da40),
                                                         lVar11 == null)))) goto LAB_180eb931a;
                                                        Toggle.set_isOn(lVar11,0,0);
                                                        }
                                                        }
                                                        if (this.nowShowHero != null) {
                                                          if (*(int *)(this.nowShowHero +
                                                                      88) == 0) {

                                                        HeroDetailController.RefreshForceContributionInfoData
                                                                  (this,0);
                                                        }
                                                        if ((((this.heroDetailPanel != null) &&
                                                             (lVar11 = GameObject.get_transform
                                                                                 (*(int64 *)
                                                                                   (this + 32),0),
                                                             lVar11 != null)) &&
                                                            (lVar11 = Transform.Find(lVar11,"BaseInfo"
                                                                                      ,0), lVar11 != null))
                                                           && (lVar11 = Transform.Find(lVar11,
                                                        "Sex",0), lVar11 != null)) {
                                                          uVar12 = Component.GetComponent
                                                                             (lVar11,DAT_181d6d8c0);
                                                          if (this.nowShowHero != null) {
                                                            uVar13 = "女";
                                                            if (*(char *)(this.nowShowHero +
                                                                         128) == false) {
                                                              uVar13 = "男";
                                                            }
                                                            uVar13 = String.Concat("性别 ",uVar13,0
                                                                                   );
                                                            LTLocalization.SetText(uVar12,uVar13,0);
                                                            if (((this.heroDetailPanel != null) &&
                                                                (lVar11 = GameObject.get_transform
                                                                                    (*(int64 *)
                                                                                      (this + 32),0),
                                                                lVar11 != null)) &&
                                                               ((lVar11 = Transform.Find(lVar11,
                                                        "BaseInfo",0), lVar11 != null &&
                                                        ((lVar11 = Transform.Find(lVar11,"GoodEvil",0)
                                                         , lVar11 != null &&
                                                         (uVar12 = Component.GetComponent
                                                                             (lVar11,DAT_181d6d8c0),
                                                         this.nowShowHero != null)))))) {
                                                          uVar13 = GlobalData.GetChaosText();
                                                          if (this.nowShowHero != null) {
                                                            uVar14 = GlobalData.GetEvilText
                                                                               (*(int64 *)
                                                                                 (this + 96),0);
                                                            uVar13 = String.Concat("立场 ",uVar13,
                                                                                    " ",uVar14,0
                                                                                   );
                                                            LTLocalization.SetText(uVar12,uVar13,0);
                                                            if ((((this.heroDetailPanel != null) &&
                                                                 (lVar11 = GameObject.get_transform
                                                                                     (*(int64 *)
                                                                                       (this + 32),0)
                                                                 , lVar11 != null)) &&
                                                                (lVar11 = Transform.Find(lVar11,
                                                        "BaseInfo",0), lVar11 != null)) &&
                                                        (lVar11 = Transform.Find(lVar11,"Nature",0),
                                                        lVar11 != null)) {
                                                          uVar12 = Component.GetComponent
                                                                             (lVar11,DAT_181d6d8c0);
                                                          lVar11 = this.nowShowHero;
                                                          lVar15 = *(int64 *)
                                                                    (pStatics_ef00 +
                                                                    0x5a0);
                                                          if (lVar11 != null) {
                                                            uVar22 = lVar11.nature;
                                                            if (lVar15 != null) {
                                                              if (lVar15.itemGrid <= uVar22) {

                                                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                                        lVar11 = this.nowShowHero;
                                                        }
                                                        uVar14 = "性格 {0}{1}";
                                                        uVar13 = *(uint64 *)
                                                                  (*(int64 *)(lVar15 + 16) + 32 +
                                                                  (int64)(int)uVar22 * 8);
                                                        if (lVar11 != null) {
                                                          lVar15 = "";
                                                          if (lVar11.heroID != null) {
                                                            local_res8[0] =
                                                                 (float)HeroData.GetNatureFavorRate
                                                                                  (lVar11,0);
                                                            local_res8[0] = local_res8[0] * 100.0;
                                                            uVar30 = Single.ToString(local_res8,
                                                                                      "f0",0);
                                                            lVar15 = String.Format("(好感加成{0}%)",uVar30,0
                                                                                   );
                                                          }
                                                          uVar13 = String.Format(uVar14,uVar13,lVar15,0);
                                                          LTLocalization.SetText(uVar12,uVar13,0);
                                                          if (((this.heroDetailPanel != null) &&
                                                              (lVar11 = GameObject.get_transform
                                                                                  (*(int64 *)
                                                                                    (this + 32),0),
                                                              lVar11 != null)) &&
                                                             ((lVar11 = Transform.Find(lVar11,
                                                        "BaseInfo",0), lVar11 != null &&
                                                        (lVar11 = Transform.Find(lVar11,"Hobby",0),
                                                        lVar11 != null)))) {
                                                          uVar12 = Component.GetComponent
                                                                             (lVar11,DAT_181d6d8c0);
                                                          lVar11 = this.nowShowHero;
                                                          if (lVar11 != null) {
                                                            lVar15 = "";
                                                            if (lVar11.heroID != null) {
                                                              uVar13 = HeroData.GetHobbyDescribe
                                                                                 (lVar11,0);
                                                              lVar15 = String.Concat("喜好 ",uVar13
                                                                                      ,0);
                                                            }
                                                            LTLocalization.SetText(uVar12,lVar15,0);
                                                            if (this.nowShowHero != null) {
                                                              lVar11 = this.heroDetailPanel;
                                                              if (*(int *)(this.nowShowHero +
                                                                          88) == 0) {
                                                                if (((lVar11 != null) &&
                                                                    (lVar11 = GameObject.get_transform
                                                                                        (lVar11,0),
                                                                    lVar11 != null)) &&
                                                                   ((lVar11 = Transform.Find(lVar11,
                                                        "BaseInfo",0), lVar11 != null &&
                                                        (lVar11 = Transform.Find(lVar11,"SkillFocus",0),
                                                        lVar11 != null)))) {
                                                          uVar12 = Component.GetComponent
                                                                             (lVar11,DAT_181d6d8c0);
                                                          LTLocalization.SetText(uVar12,"",0);
                                                          lVar11 = this.nowShowHero;
        LAB_180eb5be7:
                                                          if ((this.heroDetailPanel != null) &&
                                                             (lVar15 = GameObject.get_transform
                                                                                 (*(int64 *)
                                                                                   (this + 32),0),
                                                             lVar15 != null)) {
                                                            lVar15 = Transform.Find(lVar15,"Favor",
                                                                                     0);
                                                            if ((lVar15 != null) &&
                                                               (uVar12 = Component.get_gameObject
                                                                                   (lVar15,0), lVar11 != null
                                                               )) {
                                                              HeroData.SetHeroFavorUI(lVar11,uVar12,1,0);
                                                              lVar11 = this.nowShowHero;
                                                              if ((((this.heroDetailPanel != null)
                                                                   && (lVar15 = GameObject.get_transform
                                                                                          (*(int64 *)
                                                                                            (this +
                                                                                            32),0),
                                                                      lVar15 != null)) &&
                                                                  (lVar15 = Transform.Find(lVar15,
                                                        "Hp",0), lVar15 != null)) &&
                                                        (uVar12 = Component.get_gameObject(lVar15,0),
                                                        lVar11 != null)) {
                                                          HeroData.SetHpBar(lVar11,uVar12,0);
                                                          lVar11 = this.nowShowHero;
                                                          if ((((this.heroDetailPanel != null) &&
                                                               (lVar15 = GameObject.get_transform
                                                                                   (*(int64 *)
                                                                                     (this + 32),0),
                                                               lVar15 != null)) &&
                                                              (lVar15 = Transform.Find(lVar15,
                                                        "Mp",0), lVar15 != null)) &&
                                                        (uVar12 = Component.get_gameObject(lVar15,0),
                                                        lVar11 != null)) {
                                                          HeroData.SetMpBar(lVar11,uVar12,0);
                                                          lVar11 = this.nowShowHero;
                                                          if (((this.heroDetailPanel != null) &&
                                                              (lVar15 = GameObject.get_transform
                                                                                  (*(int64 *)
                                                                                    (this + 32),0),
                                                              lVar15 != null)) &&
                                                             ((lVar15 = Transform.Find(lVar15,
                                                        "Power",0), lVar15 != null &&
                                                        (uVar12 = Component.get_gameObject(lVar15,0),
                                                        lVar11 != null)))) {
                                                          HeroData.SetPowerBar(lVar11,uVar12,0);
                                                          if (((this.heroDetailPanel != null) &&
                                                              (lVar11 = GameObject.get_transform
                                                                                  (*(int64 *)
                                                                                    (this + 32),0),
                                                              lVar11 != null)) &&
                                                             (lVar11 = Transform.Find(lVar11,
                                                        "Poison",0), lVar11 != null)) {
                                                          uVar12 = Component.GetComponent
                                                                             (lVar11,DAT_181d6d8c0);
                                                          if (this.nowShowHero != null) {
                                                            local_14c = Mathf.CeilToInt(*(int64 *)
                                                                                          (this + 96)
                                                                                         ,0);
                                                            uVar13 = Int32.ToString(&local_14c,
                                                                                     "f0",0);
                                                            LTLocalization.SetText(uVar12,uVar13,0);
                                                            if (((this.heroDetailPanel != null) &&
                                                                (lVar11 = GameObject.get_transform
                                                                                    (*(int64 *)
                                                                                      (this + 32),0),
                                                                lVar11 != null)) &&
                                                               (lVar11 = Transform.Find(lVar11,
                                                        "InternalInjury",0), lVar11 != null)) {
                                                          uVar12 = Component.GetComponent
                                                                             (lVar11,DAT_181d6d8c0);
                                                          if (this.nowShowHero != null) {
                                                            local_14c = Mathf.CeilToInt(*(int64 *)
                                                                                          (this + 96)
                                                                                         ,0);
                                                            uVar13 = Int32.ToString(&local_14c,
                                                                                     "f0",0);
                                                            LTLocalization.SetText(uVar12,uVar13,0);
                                                            if (((this.heroDetailPanel != null) &&
                                                                (lVar11 = GameObject.get_transform
                                                                                    (*(int64 *)
                                                                                      (this + 32),0),
                                                                lVar11 != null)) &&
                                                               (lVar11 = Transform.Find(lVar11,
                                                        "ExternalInjury",0), lVar11 != null)) {
                                                          uVar12 = Component.GetComponent
                                                                             (lVar11,DAT_181d6d8c0);
                                                          if (this.nowShowHero != null) {
                                                            local_14c = Mathf.CeilToInt(*(int64 *)
                                                                                          (this + 96)
                                                                                         ,0);
                                                            uVar13 = Int32.ToString(&local_14c,
                                                                                     "f0",0);
                                                            LTLocalization.SetText(uVar12,uVar13,0);
                                                            if ((((this.heroDetailPanel != null) &&
                                                                 (lVar11 = GameObject.get_transform
                                                                                     (*(int64 *)
                                                                                       (this + 32),0)
                                                                 , lVar11 != null)) &&
                                                                (lVar11 = Transform.Find(lVar11,
                                                        "Item",0), lVar11 != null)) &&
                                                        (lVar11 = Transform.Find(lVar11,"Weight",0),
                                                        lVar11 != null)) {
                                                          uVar12 = Component.GetComponent
                                                                             (lVar11,DAT_181d6d8c0);
                                                          lVar11 = *(int64 *)(targetHero + 0x220);
                                                          if (lVar11 != null) {
                                                            fVar26 = lVar11.summonMoveRange;
                                                            uVar13 = "{0}/{1}";
                                                            if (lVar11.summonControlable <= fVar26 &&
                                                                fVar26 != lVar11.summonControlable) {
                                                              uVar13 = "{2}{0}/{1}</color>";
                                                            }
                                                            local_108 = (int)fVar26;
                                                            local_148 = il2cpp_value_box(DAT_181d5b2f8,
                                                                                         &local_108);
                                                            if (*(int64 *)(targetHero + 0x220) != 0) {
                                                              local_104 = (int)*(float *)(*(int64 *)
                                                                                           (targetHero +
                                                                                           0x220) + 32);
                                                              uVar14 = il2cpp_value_box(DAT_181d5b2f8,
                                                                                        &local_104);
                                                              if (((*(byte *)(DAT_181d4ef00 + 0x133) & 4)
                                                                   != 0) &&
                                                                 (*(int *)(DAT_181d4ef00 + 224) == 0)) {
                                                                il2cpp_runtime_class_init(DAT_181d4ef00);
                                                              }
                                                              uVar30 = 0;
                                                              uVar13 = String.Format(uVar13,local_148,
                                                                                      uVar14,*(uint64
                                                                                               *)(*(
                                                        int64 *)(DAT_181d4ef00 + 184) + 0x2c8),0);
                                                        LTLocalization.SetText(uVar12,uVar13,0);
                                                        local_154 = 0;
                                                        lVar11 = this.nowShowHero;
                                                        if (lVar11 != null) {
                                                          while( true ) {
                                                            uVar10 = (uint32)
                                                                     ((uint64)uVar30 >> 32);
                                                            if (lVar11.baseAttri == null) break;
                                                            if (*(int *)(lVar11.baseAttri +
                                                                        24) <= (int)local_154) {
                                                              local_res10[0] = 0;
                                                              lVar11 = this.nowShowHero;
                                                              if (lVar11 != null) goto LAB_180eb63f0;
                                                              break;
                                                            }
                                                            if (((this.heroDetailPanel == null) ||
                                                                (lVar11 = GameObject.get_transform
                                                                                    (*(int64 *)
                                                                                      (this + 32),0),
                                                                lVar11 == null)) ||
                                                               (lVar11 = Transform.Find(lVar11,
                                                        "Attri",0), lVar11 == null)) break;
                                                        lVar11 = Transform.Find(lVar11,"Attris",0);
                                                        uVar12 = Int32.ToString(&local_154,0);
                                                        if (lVar11 == null) break;
                                                        uVar12 = Transform.Find(lVar11,uVar12,0);
                                                        lVar11 = this.nowShowHero;
                                                        if (lVar11 == null) break;
                                                        lVar15 = lVar11.totalAttri;
                                                        uVar20 = (uint64)(int)local_154;
                                                        if (lVar15 == null) break;
                                                        uVar21 = uVar20;
                                                        if (lVar15.itemGrid <= local_154) {
                                                          ThrowHelper.ThrowArgumentOutOfRangeException(0)
                                                          ;
                                                          lVar11 = this.nowShowHero;
                                                          uVar21 = (uint64)local_154;
                                                        }
                                                        uVar1 = *(uint32 *)
                                                                 (*(int64 *)(lVar15 + 16) + 32 +
                                                                 uVar20 * 4);
                                                        if (lVar11 == null) break;
                                                        lVar15 = lVar11.baseAttri;
                                                        uVar22 = (uint32)uVar21;
                                                        if (lVar15 == null) break;
                                                        if (lVar15.itemGrid <= uVar22) {
                                                          ThrowHelper.ThrowArgumentOutOfRangeException(0)
                                                          ;
                                                          lVar11 = this.nowShowHero;
                                                          uVar21 = (uint64)local_154;
                                                        }
                                                        uVar2 = *(uint32 *)
                                                                 (*(int64 *)(lVar15 + 16) + 32 +
                                                                 (int64)(int)uVar22 * 4);
                                                        if (lVar11 == null) break;
                                                        uVar27 = HeroData.GetMaxAttri(lVar11,uVar21,0);
                                                        HeroDetailController.SetAttriDetail
                                                                  (this,uVar12,uVar1,uVar2,
                                                                   CONCAT44(uVar10,uVar27),0);
                                                        if (((this.heroDetailPanel == null) ||
                                                            (lVar11 = GameObject.get_transform
                                                                                (*(int64 *)
                                                                                  (this + 32),0),
                                                            lVar11 == null)) ||
                                                           (lVar11 = Transform.Find(lVar11,"Attri",
                                                                                     0), lVar11 == null))
                                                        break;
                                                        lVar11 = Transform.Find(lVar11,"Attris",0);
                                                        uVar12 = Int32.ToString(&local_154,0);
                                                        if (((lVar11 == null) ||
                                                            (lVar11 = Transform.Find(lVar11,uVar12,0),
                                                            lVar11 == null)) ||
                                                           (lVar11 = Transform.Find(lVar11,"Icon",
                                                                                     0), lVar11 == null))
                                                        break;
                                                        lVar11 = Component.GetComponent
                                                                           (lVar11,DAT_181d6ccc0);
                                                        lVar15 = *(int64 *)
                                                                  (pStatics_ef00 +
                                                                  0x490);
                                                        if (lVar15 == null) break;
                                                        local_148 = FUN_180002f80(lVar15,local_154,
                                                                                  DAT_181d7c9c0);
                                                        lVar15 = FUN_18046c100(0);
                                                        if (((lVar15 == null) ||
                                                            (*(int64 *)(lVar15 + 144) == 0)) ||
                                                           (lVar15 = FUN_180002f80(*(int64 *)
                                                                                    (lVar15 + 144),
                                                                                   local_154,DAT_181d64878
                                                                                  ), lVar15 == null)) break;
                                                        uVar12 = lVar15.itemGrid;
                                                        if (this.nowShowHero == null) break;
                                                        fVar26 = (float)HeroData.GetMaxAttri
                                                                                  (*(int64 *)
                                                                                    (this + 96),
                                                                                   local_154,0);
                                                        uVar13 = "<b>{0}</b>\n{1}{2}";
                                                        lVar15 = "";
                                                        if ((float)*(int *)(*(int64 *)
                                                                             (DAT_181d4ef00 + 184) + 252
                                                                           ) <= fVar26) {
                                                          if (this.nowShowHero == null) break;
                                                          local_100 = HeroData.GetUpgradeNeedMaxAttri
                                                                                (*(int64 *)
                                                                                  (this + 96),
                                                                                 local_154,0);
                                                          uVar14 = il2cpp_value_box(DAT_181d5b2f8,
                                                                                    &local_100);
                                                          if (this.nowShowHero == null) break;
                                                          local_fc = HeroData.GetUpgradeLeftMaxAttri
                                                                               (*(int64 *)
                                                                                 (this + 96),
                                                                                local_154,0);
                                                          uVar30 = il2cpp_value_box(DAT_181d5b2f8,
                                                                                    &local_fc);
                                                          lVar15 = String.Format("\n<color=#D2691E>✦{0}点潜力=1点上限({1}/{0})</color>",uVar14,
                                                                                  uVar30,0);
                                                        }
                                                        uVar30 = 0;
                                                        uVar12 = String.Format(uVar13,local_148,uVar12,
                                                                                lVar15,0);
                                                        if (lVar11 == null) break;
                                                        lVar11.summonLv = uVar12;
                                                        il2cpp_internal((uint64 *)(lVar11 + 24),
                                                                            uVar12);
                                                        local_154 = local_154 + 1;
                                                        lVar11 = this.nowShowHero;
                                                        if (lVar11 == null) break;
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
                                                        else if ((((lVar11 != null) &&
                                                                  (lVar11 = GameObject.get_transform
                                                                                      (lVar11,0),
                                                                  lVar11 != null)) &&
                                                                 (lVar11 = Transform.Find(lVar11,
                                                        "BaseInfo",0), lVar11 != null)) &&
                                                        (lVar11 = Transform.Find(lVar11,"SkillFocus",0),
                                                        lVar11 != null)) {
                                                          uVar12 = Component.GetComponent
                                                                             (lVar11,DAT_181d6d8c0);
                                                          LTLocalization.SetText(uVar12,"专长 ",0);
                                                          lVar11 = this.nowShowHero;
                                                          uVar22 = uVar24;
                                                          if (lVar11 != null) {
                                                            while (lVar11.kungfuSkillFocus != null) {
                                                              lVar15 = this.heroDetailPanel;
                                                              if (*(int *)(lVar11.kungfuSkillFocus +
                                                                          24) <= (int)uVar22) {
                                                                if (((lVar15 == null) ||
                                                                    (lVar11 = GameObject.get_transform
                                                                                        (lVar15,0),
                                                                    lVar11 == null)) ||
                                                                   ((lVar11 = Transform.Find(lVar11,
                                                        "BaseInfo",0), lVar11 == null ||
                                                        (lVar11 = Transform.Find(lVar11,"SkillFocus",0),
                                                        lVar11 == null)))) break;
                                                        uVar12 = Component.GetComponent
                                                                           (lVar11,DAT_181d6d8c0);
                                                        lVar11 = this.nowShowHero;
                                                        if ((lVar11 == null) ||
                                                           (lVar11.kungfuSkillFocus == null)) break;
                                                        if (*(int *)(lVar11.kungfuSkillFocus + 24)
                                                            < 1) {
        LAB_180eb5a00:
                                                          lVar15 = "";
                                                        }
                                                        else {
                                                          if (lVar11.livingSkillFocus == null) break;
                                                          lVar15 = "/";
                                                          if (*(int *)(lVar11.livingSkillFocus +
                                                                      24) < 1) goto LAB_180eb5a00;
                                                        }
                                                        LTLocalization.AddText(uVar12,lVar15,0);
                                                        lVar11 = this.nowShowHero;
                                                        uVar22 = uVar24;
                                                        if (lVar11 != null) goto LAB_180eb5a30;
                                                        break;
                                                        }
                                                        if (((lVar15 == null) ||
                                                            (lVar11 = GameObject.get_transform(lVar15,0),
                                                            lVar11 == null)) ||
                                                           ((lVar11 = Transform.Find(lVar11,"BaseInfo"
                                                                                      ,0), lVar11 == null ||
                                                            (lVar11 = Transform.Find(lVar11,"SkillFocus"
                                                                                      ,0), lVar11 == null))))
                                                        break;
                                                        local_148 = Component.GetComponent
                                                                              (lVar11,DAT_181d6d8c0);
                                                        lVar11 = "/";
                                                        if (uVar22 == 0) {
                                                          lVar11 = "";
                                                        }
                                                        lVar15 = *(int64 *)
                                                                  (pStatics_ef00 +
                                                                  0x498);
                                                        if (((this.nowShowHero == null) ||
                                                            (lVar18 = *(int64 *)
                                                                       (this.nowShowHero +
                                                                       0x108), lVar18 == null)) ||
                                                           (uVar10 = FUN_1800d6750(lVar18,uVar22,
                                                                                   DAT_181d68270),
                                                           lVar15 == null)) break;
                                                        uVar12 = FUN_180002f80(lVar15,uVar10,DAT_181d7c9c0
                                                                              );
                                                        uVar12 = String.Concat(lVar11,uVar12,0);
                                                        LTLocalization.AddText(local_148,uVar12,0);
                                                        lVar11 = this.nowShowHero;
                                                        uVar22 = uVar22 + 1;
                                                        if (lVar11 == null) break;
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
        LAB_180eb931a:
                          // WARNING: Subroutine does not return
        FUN_1800d6620();
        LAB_180eb5a30:
        if (lVar11.livingSkillFocus == null) goto LAB_180eb931a;
        if (*(int *)(lVar11.livingSkillFocus + 24) <= (int)uVar22) goto LAB_180eb5be7;
        if (((this.heroDetailPanel == null) ||
            (lVar11 = GameObject.get_transform(this.heroDetailPanel,0)) == null) ||
           ((lVar11 = Transform.Find(lVar11,"BaseInfo",0), lVar11 == null ||
            (lVar11 = Transform.Find(lVar11,"SkillFocus",0)) == null))) goto LAB_180eb931a;
        local_148 = Component.GetComponent(lVar11,DAT_181d6d8c0);
        lVar11 = "/";
        if (uVar22 == 0) {
          lVar11 = "";
        }
        lVar15 = *(int64 *)(pStatics_ef00 + 0x4a8);
        if (((this.nowShowHero == null) ||
            (lVar18 = this.nowShowHero.livingSkillFocus) == null) ||
           (uVar10 = FUN_1800d6750(lVar18,uVar22,DAT_181d68270), lVar15 == null)) goto LAB_180eb931a;
        uVar12 = FUN_180002f80(lVar15,uVar10);
        uVar12 = String.Concat(lVar11,uVar12);
        LTLocalization.AddText(local_148,uVar12);
        lVar11 = this.nowShowHero;
        uVar22 = uVar22 + 1;
        if (lVar11 == null) goto LAB_180eb931a;
        goto LAB_180eb5a30;
        LAB_180eb63f0:
        uVar10 = (uint32)((uint64)uVar30 >> 32);
        if (lVar11.baseFightSkill == null) goto LAB_180eb931a;
        if (*(int *)(lVar11.baseFightSkill + 24) <= (int)local_res10[0]) {
          local_158 = 0;
          lVar11 = this.nowShowHero;
          if (lVar11 != null) goto LAB_180eb6920;
          goto LAB_180eb931a;
        }
        if (((this.heroDetailPanel == null) ||
            (lVar11 = GameObject.get_transform(this.heroDetailPanel,0)) == null) ||
           (lVar11 = Transform.Find(lVar11,"Attri",0)) == null) goto LAB_180eb931a;
        lVar11 = Transform.Find(lVar11,"FightSkills",0);
        uVar12 = Int32.ToString(local_res10,0);
        if (lVar11 == null) goto LAB_180eb931a;
        uVar12 = Transform.Find(lVar11,uVar12,0);
        lVar11 = this.nowShowHero;
        if (lVar11 == null) goto LAB_180eb931a;
        lVar15 = lVar11.totalFightSkill;
        uVar20 = (uint64)(int)local_res10[0];
        if (lVar15 == null) goto LAB_180eb931a;
        uVar21 = uVar20;
        if (lVar15.itemGrid <= local_res10[0]) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
          lVar11 = this.nowShowHero;
          uVar21 = (uint64)local_res10[0];
        }
        uVar1 = *(uint32 *)(*(int64 *)(lVar15 + 16) + 32 + uVar20 * 4);
        if (lVar11 == null) goto LAB_180eb931a;
        lVar15 = lVar11.baseFightSkill;
        uVar22 = (uint32)uVar21;
        if (lVar15 == null) goto LAB_180eb931a;
        if (lVar15.itemGrid <= uVar22) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
          lVar11 = this.nowShowHero;
          uVar21 = (uint64)local_res10[0];
        }
        uVar2 = lVar15[uVar22];
        if (lVar11 == null) goto LAB_180eb931a;
        uVar27 = HeroData.GetMaxFightSkill(lVar11,uVar21,0);
        uVar30 = CONCAT44(uVar10,uVar27);
        HeroDetailController.SetAttriDetail(this,uVar12,uVar1,uVar2,uVar30,0);
        if (((this.heroDetailPanel == null) ||
            (lVar11 = GameObject.get_transform(this.heroDetailPanel,0)) == null) ||
           (lVar11 = Transform.Find(lVar11,"Attri",0)) == null) goto LAB_180eb931a;
        lVar11 = Transform.Find(lVar11,"FightSkills",0);
        uVar12 = Int32.ToString(local_res10,0);
        if (((lVar11 == null) || (lVar11 = Transform.Find(lVar11,uVar12,0)) == null) ||
           (lVar11 = Transform.Find(lVar11,"Icon",0)) == null) goto LAB_180eb931a;
        lVar11 = Component.GetComponent(lVar11,DAT_181d6ccc0);
        lVar15 = FUN_1800d60b0(DAT_181d7f180,4);
        lVar18 = *(int64 *)(pStatics_ef00 + 0x498);
        if ((lVar18 == null) || (uVar12 = FUN_180002f80(lVar18,local_res10[0],DAT_181d7c9c0), lVar15 == null))
        goto LAB_180eb931a;
        FUN_180002070(lVar15,uVar12);
        FUN_180002fd0(lVar15,0,uVar12);
        lVar18 = FUN_18046c100(0);
        if (((lVar18 == null) || (*(int64 *)(lVar18 + 144) == 0)) ||
           (lVar18 = FUN_180002f80(*(int64 *)(lVar18 + 144),local_res10[0] + 6,DAT_181d64878),
           lVar18 == null)) goto LAB_180eb931a;
        uVar12 = *(uint64 *)(lVar18 + 24);
        FUN_180002070(lVar15,uVar12);
        FUN_180002fd0(lVar15,1,uVar12);
        if (this.nowShowHero == null) goto LAB_180eb931a;
        fVar26 = (float)HeroData.GetMaxFightSkill(this.nowShowHero,local_res10[0],0);
        uVar12 = "<b>{0}</b>\n{1}{3}{2}";
        if ((float)*(int *)(pStatics_ef00 + 0x104) <= fVar26) {
          if (this.nowShowHero == null) goto LAB_180eb931a;
          local_f8 = HeroData.GetUpgradeNeedMaxFightSkill(this.nowShowHero,local_res10[0],0)
          ;
          uVar13 = il2cpp_value_box(DAT_181d5b2f8,&local_f8);
          if (this.nowShowHero == null) goto LAB_180eb931a;
          local_f4 = HeroData.GetUpgradeLeftMaxFightSkill(this.nowShowHero,local_res10[0],0)
          ;
          uVar14 = il2cpp_value_box(DAT_181d5b2f8,&local_f4);
          lVar18 = String.Format("\n<color=#D2691E>✦{0}点潜力=1点上限({1}/{0})</color>",uVar13,uVar14,0);
        }
        else {
          if (this.nowShowHero == null) goto LAB_180eb931a;
          lVar18 = "";
          if (this.nowShowHero.heroID == null) {
            lVar18 = *(int64 *)(pStatics_ef00 + 0x4a0);
            if (lVar18 == null) goto LAB_180eb931a;
            uVar13 = FUN_180002f80(lVar18,local_res10[0],DAT_181d7c9c0);
            lVar18 = String.Format("\n<color=grey><i>♦{0}</i></color>",uVar13,0);
          }
        }
        FUN_180002070(lVar15,lVar18);
        FUN_180002fd0(lVar15,2,lVar18);
        if (this.nowShowHero == null) goto LAB_180eb931a;
        lVar18 = "";
        if (this.nowShowHero.heroID == null) {
          lVar18 = *(int64 *)(pStatics_ef00 + 0x498);
          if (lVar18 == null) goto LAB_180eb931a;
          uVar13 = FUN_180002f80(lVar18,local_res10[0],DAT_181d7c9c0);
          lVar18 = String.Format("\n提升队友{0}战斗经验",uVar13,0);
        }
        FUN_180002070(lVar15,lVar18);
        FUN_180002fd0(lVar15,3);
        uVar12 = String.Format(uVar12,lVar15);
        if (lVar11 == null) goto LAB_180eb931a;
        lVar11.summonLv = uVar12;
        local_res10[0] = local_res10[0] + 1;
        lVar11 = this.nowShowHero;
        if (lVar11 == null) goto LAB_180eb931a;
        goto LAB_180eb63f0;
        LAB_180eb6920:
        uVar10 = (uint32)((uint64)uVar30 >> 32);
        if (lVar11.baseLivingSkill == null) goto LAB_180eb931a;
        if (*(int *)(lVar11.baseLivingSkill + 24) <= (int)local_158) {
          HeroDetailController.RefreshFightData(this,0);
          lVar11 = *(int64 *)(pStatics_ef00 + 0x498);
          if (lVar11 != null) {
            uVar12 = FUN_1800d60b0(DAT_181d7e600,lVar11.summonLv);
            lVar15 = il2cpp_internal(DAT_181d6f030);
            FUN_18182e120(lVar15,uVar12,DAT_181d67978);
            lVar11 = this.nowShowHero;
            uVar22 = uVar24;
            if (lVar11 != null) goto LAB_180eb6ee0;
          }
          goto LAB_180eb931a;
        }
        if (((this.heroDetailPanel == null) ||
            (lVar11 = GameObject.get_transform(this.heroDetailPanel,0)) == null) ||
           (lVar11 = Transform.Find(lVar11,"Attri",0)) == null) goto LAB_180eb931a;
        lVar11 = Transform.Find(lVar11,"LivingSkills",0);
        uVar12 = Int32.ToString(&local_158,0);
        if (lVar11 == null) goto LAB_180eb931a;
        uVar12 = Transform.Find(lVar11,uVar12,0);
        lVar11 = this.nowShowHero;
        if (lVar11 == null) goto LAB_180eb931a;
        lVar15 = lVar11.totalLivingSkill;
        uVar20 = (uint64)(int)local_158;
        if (lVar15 == null) goto LAB_180eb931a;
        uVar21 = uVar20;
        if (lVar15.itemGrid <= local_158) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
          lVar11 = this.nowShowHero;
          uVar21 = (uint64)local_158;
        }
        uVar1 = *(uint32 *)(*(int64 *)(lVar15 + 16) + 32 + uVar20 * 4);
        if (lVar11 == null) goto LAB_180eb931a;
        lVar15 = lVar11.baseLivingSkill;
        uVar22 = (uint32)uVar21;
        if (lVar15 == null) goto LAB_180eb931a;
        if (lVar15.itemGrid <= uVar22) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
          lVar11 = this.nowShowHero;
          uVar21 = (uint64)local_158;
        }
        uVar2 = lVar15[uVar22];
        if (lVar11 == null) goto LAB_180eb931a;
        uVar27 = HeroData.GetMaxLivingSkill(lVar11,uVar21,0);
        uVar30 = CONCAT44(uVar10,uVar27);
        HeroDetailController.SetAttriDetail(this,uVar12,uVar1,uVar2,uVar30,0);
        if (((this.heroDetailPanel == null) ||
            (lVar11 = GameObject.get_transform(this.heroDetailPanel,0)) == null) ||
           (lVar11 = Transform.Find(lVar11,"Attri",0)) == null) goto LAB_180eb931a;
        lVar11 = Transform.Find(lVar11,"LivingSkills",0);
        uVar12 = Int32.ToString(&local_158,0);
        if (((lVar11 == null) || (lVar11 = Transform.Find(lVar11,uVar12,0)) == null) ||
           (lVar11 = Transform.Find(lVar11,"Icon",0)) == null) goto LAB_180eb931a;
        lVar11 = Component.GetComponent(lVar11,DAT_181d6ccc0);
        lVar15 = FUN_1800d60b0(DAT_181d7f180,4);
        lVar18 = *(int64 *)(pStatics_ef00 + 0x4a8);
        if ((lVar18 == null) || (uVar12 = FUN_180002f80(lVar18,local_158,DAT_181d7c9c0), lVar15 == null))
        goto LAB_180eb931a;
        FUN_180002070(lVar15,uVar12);
        FUN_180002fd0(lVar15,0,uVar12);
        if ((this.nowShowHero == null) ||
           (lVar18 = this.nowShowHero.baseLivingSkill) == null)
        goto LAB_180eb931a;
        fVar26 = (float)FUN_1800d6780(lVar18,local_158,DAT_181d796d8);
        uVar12 = "<b>{0}</b>   [{1}]\n{2}{3}";
        lVar18 = "登峰造极";
        if (fVar26 < (float)*(int *)(pStatics_ef00 + 0x108)) {
          if ((this.nowShowHero == null) ||
             (lVar18 = this.nowShowHero.expLivingSkill) == null)
          goto LAB_180eb931a;
          local_res8[0] = (float)FUN_1800d6780(lVar18,local_158,DAT_181d796d8);
          uVar13 = Single.ToString(local_res8,"f0",0);
          if (this.nowShowHero == null) goto LAB_180eb931a;
          local_res8[0] = (float)HeroData.GetLivingSkillExpMax(this.nowShowHero,local_158,0)
          ;
          uVar14 = Single.ToString(local_res8,"f0",0);
          lVar18 = String.Format("经验{0}/{1}",uVar13,uVar14,0);
        }
        FUN_180002070(lVar15,lVar18);
        FUN_180002fd0(lVar15,1,lVar18);
        lVar18 = FUN_18046c100(0);
        if (((lVar18 == null) || (*(int64 *)(lVar18 + 144) == 0)) ||
           (lVar18 = FUN_180002f80(*(int64 *)(lVar18 + 144),local_158 + 24,DAT_181d64878),
           lVar18 == null)) goto LAB_180eb931a;
        uVar13 = *(uint64 *)(lVar18 + 24);
        FUN_180002070(lVar15,uVar13);
        FUN_180002fd0(lVar15,2,uVar13);
        if (this.nowShowHero == null) goto LAB_180eb931a;
        fVar26 = (float)HeroData.GetMaxLivingSkill(this.nowShowHero,local_158,0);
        lVar18 = "";
        if (fVar26 < (float)*(int *)(pStatics_ef00 + 0x108)) {
          if (this.nowShowHero == null) goto LAB_180eb931a;
          if (this.nowShowHero.heroID == null) {
            lVar18 = *(int64 *)(pStatics_ef00 + 0x4b0);
            if (lVar18 == null) goto LAB_180eb931a;
            uVar13 = FUN_180002f80(lVar18,local_158,DAT_181d7c9c0);
            lVar18 = String.Format("\n<color=grey><i>♦{0}</i></color>",uVar13,0);
          }
        }
        FUN_180002070(lVar15,lVar18);
        FUN_180002fd0(lVar15,3);
        uVar12 = String.Format(uVar12,lVar15);
        if (lVar11 == null) goto LAB_180eb931a;
        lVar11.summonLv = uVar12;
        local_158 = local_158 + 1;
        lVar11 = this.nowShowHero;
        if (lVar11 == null) goto LAB_180eb931a;
        goto LAB_180eb6920;
        LAB_180eb6ee0:
        if (lVar11.kungfuSkills == null) goto LAB_180eb931a;
        uVar23 = uVar24;
        if (*(int *)(lVar11.kungfuSkills + 24) <= (int)uVar22) goto LAB_180eb6fa5;
        if ((lVar11 = lVar11?.kungfuSkills) == null) goto LAB_180eb931a;
        if (lVar11.summonLv <= uVar22) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        lVar11 = lVar11.isSummon[uVar22];
        if ((lVar11 == null) || (lVar11 = KungfuSkillLvData.DataBase(lVar11,0)) == null)
        goto LAB_180eb931a;
        local_14c = lVar11.interestingStar;
        uVar20 = (uint64)(int)local_14c;
        if (lVar15 == null) goto LAB_180eb931a;
        uVar21 = uVar20;
        if (lVar15.itemGrid <= local_14c) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
          uVar21 = (uint64)local_14c;
        }
        local_128 = *(int *)(*(int64 *)(lVar15 + 16) + 32 + uVar20 * 4);
        FUN_18181e970(lVar15,uVar21,local_128 + 1,DAT_181d68370);
        lVar11 = this.nowShowHero;
        uVar22 = uVar22 + 1;
        if (lVar11 == null) goto LAB_180eb931a;
        goto LAB_180eb6ee0;
        LAB_180eb6fa5:
        local_138[0] = uVar23;
        lVar11 = *(int64 *)(pStatics_ef00 + 0x498);
        if (lVar11 == null) goto LAB_180eb931a;
        lVar18 = this.heroDetailPanel;
        if (lVar11.summonLv <= (int)uVar23) {
          if (((lVar18 == null) || (lVar11 = GameObject.get_transform(lVar18,0)) == null) ||
             (lVar11 = Transform.Find(lVar11,"ChangeClothButton",0)) == null) goto LAB_180eb931a;
          lVar11 = Component.GetComponent(lVar11,DAT_181d6af40);
          if (this.nowShowHero == null) goto LAB_180eb931a;
          cVar4 = HeroData.ItemControlable(this.nowShowHero,0);
          if ((cVar4) || (bVar5 = bVar25, this.itemSpeControlable)) {
            if (this.nowShowHero == null) goto LAB_180eb931a;
            bVar5 = this.nowShowHero.changeSkinCd < 1;
          }
          if (lVar11 == null) goto LAB_180eb931a;
          Selectable.set_interactable(lVar11,bVar5,0);
          if (((this.heroDetailPanel == null) ||
              (lVar11 = GameObject.get_transform(this.heroDetailPanel,0)) == null) ||
             (lVar11 = Transform.Find(lVar11,"ChangeClothButton",0)) == null) goto LAB_180eb931a;
          lVar11 = Component.GetComponent(lVar11,DAT_181d6ccc0);
          lVar15 = FUN_18046c100(0);
          if ((this.nowShowHero == null) || (lVar15 == null)) goto LAB_180eb931a;
          lVar15 = GameDataController.FindSkinDataBase
                             (lVar15,this.nowShowHero.skinID,0);
          if ((this.nowShowHero == null) || (lVar15 == null)) goto LAB_180eb931a;
          uVar20 = 0;
          uVar12 = SkinDataBase.GetSkinFullName
                             (lVar15,this.nowShowHero.skinLv,0,1,0);
          lVar15 = FUN_18046c100(0);
          if ((this.nowShowHero == null) || (lVar15 == null)) goto LAB_180eb931a;
          lVar15 = GameDataController.FindSkinDataBase
                             (lVar15,this.nowShowHero.skinID,0);
          if ((this.nowShowHero == null) ||
             ((lVar15 == null ||
              (lVar15 = SkinDataBase.GetSkinSpeAdd
                                  (lVar15,this.nowShowHero.skinLv,0),
              lVar15 == null)))) goto LAB_180eb931a;
          uVar13 = HeroSpeAddData.GetDescribe(lVar15,1,1,1,uVar20 & 0xffffffffffffff00,0);
          lVar15 = "\n";
          if (this.nowShowHero == null) goto LAB_180eb931a;
          iVar9 = this.nowShowHero.changeSkinCd;
          lVar18 = "";
          if (0 < iVar9) {
            local_f0 = iVar9;
            uVar14 = il2cpp_value_box(DAT_181d5b2f8,&local_f0);
            lVar18 = String.Format("\n<i>换装冷却 {0}日</i>",uVar14,0);
          }
          uVar12 = String.Concat(uVar12,lVar15,uVar13,lVar18,0);
          if (lVar11 == null) goto LAB_180eb931a;
          lVar11.summonLv = uVar12;
          if ((((this.heroDetailPanel == null) ||
               (lVar11 = GameObject.get_transform(this.heroDetailPanel,0)) == null) ||
              (lVar11 = Transform.Find(lVar11,"Item",0)) == null) ||
             ((lVar11 = Transform.Find(lVar11,"DiscardButton",0), lVar11 == null ||
              (lVar11 = Component.get_gameObject(lVar11,0)) == null))) goto LAB_180eb931a;
          cVar4 = GameObject.get_activeSelf(lVar11,0);
          if (this.nowShowHero == null) goto LAB_180eb931a;
          cVar3 = HeroData.ItemExchangeable(this.nowShowHero,0);
          if (cVar4 != cVar3) {
            if (((this.heroDetailPanel == null) ||
                (lVar11 = GameObject.get_transform(this.heroDetailPanel,0)) == null) ||
               ((lVar11 = Transform.Find(lVar11,"Item",0), lVar11 == null ||
                (lVar11 = Transform.Find(lVar11,"DiscardButton",0)) == null))) goto LAB_180eb931a;
            lVar11 = Component.get_gameObject(lVar11,0);
            if ((this.nowShowHero == null) ||
               (uVar6 = HeroData.ItemExchangeable(this.nowShowHero,0), lVar11 == null))
            goto LAB_180eb931a;
            GameObject.SetActive(lVar11,uVar6,0);
          }
          uVar6 = local_res18;
          HeroDetailController.RefreshEquipList(this,local_res18,0);
          lVar11 = this.nowShowHero;
          lVar15 = this.itemListController;
          if (lVar11 == null) goto LAB_180eb931a;
          uVar12 = lVar11.itemListData;
          cVar4 = HeroData.ItemControlable(lVar11,0);
          bVar5 = bVar25;
          if ((!cVar4) && (!this.itemSpeControlable)) {
            bVar5 = true;
          }
          if (lVar15 == null) goto LAB_180eb931a;
          ItemListController.RefreshItemList(lVar15,uVar12,bVar5,uVar6,0);
          lVar11 = this.nowShowHero;
          if (lVar11 == null) goto LAB_180eb931a;
          uVar22 = uVar24;
          if ((lVar11.heroID != null) && (lVar11.speHero)) {
            lVar11 = FUN_18046c100(0);
            if (lVar11 == null) goto LAB_180eb931a;
            if ((this.nowShowHero == null) || (lVar11.hobby == null))
            goto LAB_180eb931a;
            cVar4 = FUN_1808ab750(lVar11.hobby,
                                  this.nowShowHero.heroName,DAT_181da33f8);
            if (cVar4) {
              if (((this.heroDetailPanel == null) ||
                  (lVar11 = GameObject.get_transform(this.heroDetailPanel,0)) == null) ||
                 ((lVar11 = Transform.Find(lVar11,"UseSpeSkeleton",0), lVar11 == null ||
                  (lVar11 = Component.get_gameObject(lVar11,0)) == null))) goto LAB_180eb931a;
              cVar4 = GameObject.get_activeSelf(lVar11,0);
              if (!cVar4) {
                if (((this.heroDetailPanel == null) ||
                    (lVar11 = GameObject.get_transform(this.heroDetailPanel,0)) == null) ||
                   (lVar11 = Transform.Find(lVar11,"UseSpeSkeleton",0)) == null) goto LAB_180eb931a;
                lVar11 = Component.get_gameObject(lVar11,0);
                if (lVar11 == null) goto LAB_180eb931a;
                GameObject.SetActive(lVar11,1,0);
              }
              if (((this.heroDetailPanel != null) &&
                  (lVar11 = GameObject.get_transform(this.heroDetailPanel,0)) != null) &&
                 (lVar11 = Transform.Find(lVar11,"UseSpeSkeleton",0)) != null) {
                lVar11 = Component.GetComponent(lVar11,DAT_181d6da40);
                lVar15 = *(int64 *)(*(int64 *)(DAT_181d4e010 + 184) + 8);
                if (lVar15 != null) {
                  lVar15 = *(int64 *)(lVar15 + 16);
                  if (((this.nowShowHero != null) &&
                      (uVar12 = String.Concat(this.nowShowHero.heroName,
                                               "hideSpeSkeleton",0), lVar15 != null)) &&
                     (iVar9 = PlayerPrefDictionary.GetInt(lVar15,uVar12,0), lVar11 != null)) {
                    Toggle.set_isOn(lVar11,iVar9 == 0,0);
                    goto LAB_180eb779f;
                  }
                }
              }
              goto LAB_180eb931a;
            }
          }
          if ((((this.heroDetailPanel != null) &&
               (lVar11 = GameObject.get_transform(this.heroDetailPanel,0)) != null) &&
              (lVar11 = Transform.Find(lVar11,"UseSpeSkeleton",0)) != null) &&
             (lVar11 = Component.get_gameObject(lVar11,0)) != null) {
            cVar4 = GameObject.get_activeSelf(lVar11,0);
            if (!cVar4) goto LAB_180eb779f;
            if (((this.heroDetailPanel != null) &&
                (lVar11 = GameObject.get_transform(this.heroDetailPanel,0)) != null) &&
               ((lVar11 = Transform.Find(lVar11,"UseSpeSkeleton",0), lVar11 != null &&
                (lVar11 = Component.get_gameObject(lVar11,0)) != null))) {
              GameObject.SetActive(lVar11,0,0);
              goto LAB_180eb779f;
            }
          }
          goto LAB_180eb931a;
        }
        if (((lVar18 == null) || (lVar11 = GameObject.get_transform(lVar18,0)) == null) ||
           (lVar11 = Transform.Find(lVar11,"Skill")) == null) goto LAB_180eb931a;
        lVar11 = Transform.Find(lVar11,"SkillTabGrid");
        uVar12 = Int32.ToString(local_138,0);
        if (((lVar11 == null) || (lVar11 = Transform.Find(lVar11,uVar12)) == null) ||
           (lVar11 = Transform.Find(lVar11,"Num")) == null) goto LAB_180eb931a;
        uVar12 = Component.GetComponent(lVar11,DAT_181d6d8c0);
        lVar11 = (int64)(int)local_138[0];
        if (lVar15 == null) goto LAB_180eb931a;
        if (lVar15.itemGrid <= local_138[0]) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        local_128 = *(int *)(*(int64 *)(lVar15 + 16) + 32 + lVar11 * 4);
        uVar13 = Int32.ToString(&local_128,0);
        LTLocalization.SetText(uVar12,uVar13);
        uVar23 = local_138[0] + 1;
        goto LAB_180eb6fa5;
        LAB_180eb779f:
        local_150 = uVar22;
        uVar6 = local_res18;
        lVar11 = *(int64 *)(pStatics_ef00 + 0x4f0);
        if (lVar11 == null) goto LAB_180eb931a;
        if (lVar11.summonLv <= (int)uVar22) {
          HeroDetailController.RefreshSkillEquipList(this,local_res18,0);
          HeroDetailController.RefreshSkillList(this,uVar6,0);
          HeroDetailController.RefreshLifeList(this,uVar6,0);
          HeroDetailController.RefreshInterestingStar(this,0);
          if (((this.heroDetailPanel != null) &&
              (lVar11 = GameObject.get_transform(this.heroDetailPanel,0)) != null) &&
             ((lVar11 = Transform.Find(lVar11,"TagPointBack",0), lVar11 != null &&
              (lVar11 = Transform.Find(lVar11,"TagPoint",0)) != null))) {
            uVar12 = Component.GetComponent(lVar11,DAT_181d6d8c0);
            if (this.nowShowHero != null) {
              lVar15 = Single.ToString(this.nowShowHero + 0x364,"0.##",0);
              lVar11 = "";
              if (lVar15 != null) {
                lVar11 = lVar15;
              }
              LTLocalization.SetText(uVar12,lVar11,0);
              if ((((this.heroDetailPanel != null) &&
                   (lVar11 = GameObject.get_transform(this.heroDetailPanel,0)) != null) &&
                  (lVar11 = Transform.Find(lVar11,"TagList",0)) != null) &&
                 ((lVar11 = Transform.Find(lVar11,"Viewport",0), lVar11 != null &&
                  (lVar11 = Transform.Find(lVar11,"Content",0)) != null))) {
                uVar12 = Component.get_gameObject(lVar11,0);
                GlobalData.DeleteAllChild(uVar12,0);
                lVar11 = this.nowShowHero;
                if (lVar11 != null) goto LAB_180eb7cf0;
              }
            }
          }
          goto LAB_180eb931a;
        }
        if (((this.heroDetailPanel == null) ||
            (lVar11 = GameObject.get_transform(this.heroDetailPanel,0)) == null) ||
           (lVar11 = Transform.Find(lVar11,"Skill",0)) == null) goto LAB_180eb931a;
        lVar11 = Transform.Find(lVar11,"SkillNumText",0);
        uVar12 = Int32.ToString(&local_150,0);
        if ((lVar11 == null) || (lVar11 = Transform.Find(lVar11,uVar12,0)) == null) goto LAB_180eb931a;
        uVar12 = Component.GetComponent(lVar11,DAT_181d6d8c0);
        lVar11 = *(int64 *)(pStatics_ef00 + 0x4f0);
        if (lVar11 == null) goto LAB_180eb931a;
        uVar13 = FUN_180002f80(lVar11,local_150,DAT_181d7c9c0);
        if ((this.nowShowHero == null) ||
           (lVar11 = this.nowShowHero.skillCount) == null) goto LAB_180eb931a;
        local_ec = FUN_1800d6750(lVar11,local_150,DAT_181d68270);
        uVar14 = il2cpp_value_box(DAT_181d5b2f8,&local_ec);
        if (this.nowShowHero == null) goto LAB_180eb931a;
        fVar26 = (float)HeroData.GetMaxSkillNum(this.nowShowHero,local_150,0);
        uVar30 = "{0}武功 {1}/{2}";
        uVar19 = "∞";
        if (fVar26 < 99.0) {
          if (this.nowShowHero == null) goto LAB_180eb931a;
          local_res8[0] = (float)HeroData.GetMaxSkillNum(this.nowShowHero,local_150,0);
          uVar19 = Single.ToString(local_res8,0);
        }
        uVar13 = String.Format(uVar30,uVar13,uVar14,uVar19,0);
        uVar22 = local_150;
        uVar13 = GlobalData.GenerateRareLvColorText(uVar13,uVar22,0);
        LTLocalization.SetText(uVar12,uVar13,0);
        if (((this.heroDetailPanel == null) ||
            (lVar11 = GameObject.get_transform(this.heroDetailPanel,0)) == null) ||
           (lVar11 = Transform.Find(lVar11,"Skill",0)) == null) goto LAB_180eb931a;
        lVar11 = Transform.Find(lVar11,"SkillNumText",0);
        uVar12 = Int32.ToString(&local_150,0);
        if ((lVar11 == null) || (lVar11 = Transform.Find(lVar11,uVar12,0)) == null) goto LAB_180eb931a;
        lVar15 = Component.GetComponent(lVar11,DAT_181d6ccc0);
        lVar11 = *(int64 *)(pStatics_ef00 + 0x4f0);
        if (lVar11 == null) goto LAB_180eb931a;
        uVar12 = FUN_180002f80(lVar11,local_150,DAT_181d7c9c0);
        if (this.nowShowHero == null) goto LAB_180eb931a;
        auVar28._0_8_ = HeroData.GetSkillRareLvExpRate(this.nowShowHero,local_150,0);
        auVar28._8_8_ = extraout_XMM0_Qb;
        auVar29._4_12_ = auVar28._4_12_;
        auVar29._0_4_ = (float)auVar28._0_8_ * 100.0;
        local_e8 = Mathf.RoundToInt(auVar29._0_8_,0);
        uVar13 = il2cpp_value_box(DAT_181d5b2f8,&local_e8);
        uVar12 = String.Format("{0}武功经验获取 <b>{1}%</b>",uVar12,uVar13,0);
        uVar12 = GlobalData.GenerateRareLvColorText(uVar12,local_150);
        uVar12 = String.Concat(uVar12,"\n♦每一级别武功都有最佳修习数\n♦超出上限后，所有该级别武功获取的经验都会减少");
        if (lVar15 == null) goto LAB_180eb931a;
        lVar15.itemGrid = uVar12;
        uVar22 = local_150 + 1;
        goto LAB_180eb779f;
        LAB_180eb7cf0:
        if (lVar11.heroTagData == null) goto LAB_180eb931a;
        if (*(int *)(lVar11.heroTagData + 24) <= (int)uVar24) {
          if (this.mainShowHero == null) goto LAB_180eb931a;
          if (this.mainShowHero.heroID == null) {
            lVar11 = FUN_18046c0a0(0);
            if ((((lVar11 == null) || (lVar11.summonControlable == null)) ||
                (lVar11 = WorldData.Player(lVar11.summonControlable,0)) == null) ||
               (lVar11.teamMates == null)) goto LAB_180eb931a;
            if (*(int *)(lVar11.teamMates + 24) < 1) goto LAB_180eb800d;
            if ((((this.heroDetailPanel == null) ||
                 (lVar11 = GameObject.get_transform(this.heroDetailPanel,0)) == null) ||
                (lVar11 = Transform.Find(lVar11,"AllLeaveTeamButton",0)) == null) ||
               (lVar11 = Component.get_gameObject(lVar11,0)) == null) goto LAB_180eb931a;
            cVar4 = GameObject.get_activeSelf(lVar11,0);
            if (!cVar4) {
              if (((this.heroDetailPanel == null) ||
                  (lVar11 = GameObject.get_transform(this.heroDetailPanel,0)) == null) ||
                 (lVar11 = Transform.Find(lVar11,"AllLeaveTeamButton",0)) == null) goto LAB_180eb931a;
              lVar11 = Component.get_gameObject(lVar11,0);
              if (lVar11 == null) goto LAB_180eb931a;
              GameObject.SetActive(lVar11,1,0);
            }
            if (((this.heroDetailPanel == null) ||
                (lVar11 = GameObject.get_transform(this.heroDetailPanel,0)) == null) ||
               (lVar11 = Transform.Find(lVar11,"AllLeaveTeamButton",0)) == null) goto LAB_180eb931a;
            lVar11 = Component.GetComponent(lVar11,DAT_181d6af40);
            lVar15 = FUN_18046bb80(0);
            if (lVar15 == null) goto LAB_180eb931a;
            if (lVar15.forceItemListType == null) {
              lVar15 = FUN_18046c440(0);
              if (lVar15 == null) goto LAB_180eb931a;
              bVar25 = !lVar15.itemGrid;
            }
            if (lVar11 == null) goto LAB_180eb931a;
            Selectable.set_interactable(lVar11,bVar25,0);
          }
          else {
        LAB_180eb800d:
            if (((this.heroDetailPanel == null) ||
                (lVar11 = GameObject.get_transform(this.heroDetailPanel,0)) == null) ||
               ((lVar11 = Transform.Find(lVar11,"AllLeaveTeamButton",0), lVar11 == null ||
                (lVar11 = Component.get_gameObject(lVar11,0)) == null))) goto LAB_180eb931a;
            cVar4 = GameObject.get_activeSelf(lVar11,0);
            if (cVar4) {
              if (((this.heroDetailPanel == null) ||
                  (lVar11 = GameObject.get_transform(this.heroDetailPanel,0)) == null) ||
                 ((lVar11 = Transform.Find(lVar11,"AllLeaveTeamButton",0), lVar11 == null ||
                  (lVar11 = Component.get_gameObject(lVar11,0)) == null))) goto LAB_180eb931a;
              GameObject.SetActive(lVar11,0,0);
            }
          }
          if (this.mainShowHero == null) goto LAB_180eb931a;
          if (this.mainShowHero.heroID == null) {
            lVar11 = this.nowShowHero;
            if (lVar11 == null) goto LAB_180eb931a;
            if ((lVar11.heroID == null) || (lVar11.teamLeader != null)) goto LAB_180eb86ae;
            if ((((this.heroDetailPanel == null) ||
                 (lVar11 = GameObject.get_transform(this.heroDetailPanel,0)) == null) ||
                (lVar11 = Transform.Find(lVar11,"ExchangeTeamButton",0)) == null) ||
               (lVar11 = Component.get_gameObject(lVar11,0)) == null) goto LAB_180eb931a;
            cVar4 = GameObject.get_activeSelf(lVar11,0);
            if (!cVar4) {
              if (((this.heroDetailPanel == null) ||
                  (lVar11 = GameObject.get_transform(this.heroDetailPanel,0)) == null) ||
                 (lVar11 = Transform.Find(lVar11,"ExchangeTeamButton",0)) == null) goto LAB_180eb931a;
              lVar11 = Component.get_gameObject(lVar11,0);
              if (lVar11 == null) goto LAB_180eb931a;
              GameObject.SetActive(lVar11,1,0);
            }
            if (((this.heroDetailPanel == null) ||
                (lVar11 = GameObject.get_transform(this.heroDetailPanel,0)) == null) ||
               (lVar11 = Transform.Find(lVar11,"ExchangeTeamButton",0)) == null) goto LAB_180eb931a;
            lVar11 = Component.GetComponent(lVar11,DAT_181d6ccc0);
            if (this.nowShowHero == null) goto LAB_180eb931a;
            cVar4 = HeroData.ItemExchangeable(this.nowShowHero,0);
            uVar12 = "给予";
            if (cVar4) {
              uVar12 = "交换";
            }
            if (lVar11 == null) goto LAB_180eb931a;
            lVar11.summonLv = uVar12;
            if ((((this.heroDetailPanel == null) ||
                 (lVar11 = GameObject.get_transform(this.heroDetailPanel,0)) == null) ||
                (lVar11 = Transform.Find(lVar11,"LeaveTeamButton",0)) == null) ||
               (lVar11 = Component.get_gameObject(lVar11,0)) == null) goto LAB_180eb931a;
            cVar4 = GameObject.get_activeSelf(lVar11,0);
            if (!cVar4) {
              if (((this.heroDetailPanel == null) ||
                  (lVar11 = GameObject.get_transform(this.heroDetailPanel,0)) == null) ||
                 (lVar11 = Transform.Find(lVar11,"LeaveTeamButton",0)) == null) goto LAB_180eb931a;
              lVar11 = Component.get_gameObject(lVar11,0);
              if (lVar11 == null) goto LAB_180eb931a;
              GameObject.SetActive(lVar11,1,0);
            }
            if (((this.heroDetailPanel == null) ||
                (lVar11 = GameObject.get_transform(this.heroDetailPanel,0)) == null) ||
               ((lVar11 = Transform.Find(lVar11,"TalkButton",0), lVar11 == null ||
                (lVar11 = Component.get_gameObject(lVar11,0)) == null))) goto LAB_180eb931a;
            cVar4 = GameObject.get_activeSelf(lVar11,0);
            if (!cVar4) {
              if (((this.heroDetailPanel == null) ||
                  (lVar11 = GameObject.get_transform(this.heroDetailPanel,0)) == null) ||
                 (lVar11 = Transform.Find(lVar11,"TalkButton",0)) == null) goto LAB_180eb931a;
              lVar11 = Component.get_gameObject(lVar11,0);
              if (lVar11 == null) goto LAB_180eb931a;
              GameObject.SetActive(lVar11,1,0);
            }
            lVar11 = FUN_18046bb80(0);
            if (lVar11 == null) goto LAB_180eb931a;
            if (*(int *)(lVar11 + 36) == 0) {
              lVar11 = FUN_18046c440(0);
              if (lVar11 == null) goto LAB_180eb931a;
              if (lVar11.summonLv) goto LAB_180eb8592;
              if ((((this.heroDetailPanel == null) ||
                   (lVar11 = GameObject.get_transform(this.heroDetailPanel,0)) == null) ||
                  (lVar11 = Transform.Find(lVar11,"ExchangeTeamButton",0)) == null) ||
                 (lVar11 = Component.GetComponent(lVar11,DAT_181d6af40)) == null)
              goto LAB_180eb931a;
              Selectable.set_interactable(lVar11,1,0);
              if (((this.heroDetailPanel == null) ||
                  (lVar11 = GameObject.get_transform(this.heroDetailPanel,0)) == null) ||
                 (lVar11 = Transform.Find(lVar11,"LeaveTeamButton",0)) == null) goto LAB_180eb931a;
              lVar11 = Component.GetComponent(lVar11,DAT_181d6af40);
              if (this.nowShowHero == null) goto LAB_180eb931a;
              cVar4 = HeroData.MissionKeepInTeam(this.nowShowHero,0);
              if (lVar11 == null) goto LAB_180eb931a;
              Selectable.set_interactable(lVar11,!cVar4,0);
              if (((this.heroDetailPanel == null) ||
                  (lVar11 = GameObject.get_transform(this.heroDetailPanel,0)) == null) ||
                 (lVar11 = Transform.Find(lVar11,"TalkButton",0)) == null) goto LAB_180eb931a;
              lVar11 = Component.GetComponent(lVar11,DAT_181d6af40);
              if (this.nowShowHero == null) goto LAB_180eb931a;
              if (!this.nowShowHero.isTempHero) {
                lVar15 = FUN_18046c0a0(0);
                if (lVar15 == null) goto LAB_180eb931a;
                cVar7 = GameController.CanSaveLoad(lVar15,0,0);
              }
              if (lVar11 == null) goto LAB_180eb931a;
              Selectable.set_interactable(lVar11,cVar7,0);
            }
            else {
        LAB_180eb8592:
              if ((((this.heroDetailPanel == null) ||
                   (lVar11 = GameObject.get_transform(this.heroDetailPanel,0)) == null) ||
                  (lVar11 = Transform.Find(lVar11,"ExchangeTeamButton",0)) == null) ||
                 (lVar11 = Component.GetComponent(lVar11,DAT_181d6af40)) == null)
              goto LAB_180eb931a;
              Selectable.set_interactable(lVar11,0,0);
              if (((this.heroDetailPanel == null) ||
                  (lVar11 = GameObject.get_transform(this.heroDetailPanel,0)) == null) ||
                 ((lVar11 = Transform.Find(lVar11,"LeaveTeamButton",0), lVar11 == null ||
                  (lVar11 = Component.GetComponent(lVar11,DAT_181d6af40)) == null)))
              goto LAB_180eb931a;
              Selectable.set_interactable(lVar11,0,0);
              if (((this.heroDetailPanel == null) ||
                  (lVar11 = GameObject.get_transform(this.heroDetailPanel,0)) == null) ||
                 ((lVar11 = Transform.Find(lVar11,"TalkButton",0), lVar11 == null ||
                  (lVar11 = Component.GetComponent(lVar11,DAT_181d6af40)) == null)))
              goto LAB_180eb931a;
              Selectable.set_interactable(lVar11,0,0);
            }
          }
          else {
        LAB_180eb86ae:
            if ((this.heroDetailPanel == null) ||
               (((lVar11 = GameObject.get_transform(this.heroDetailPanel,0), lVar11 == null ||
                 (lVar11 = Transform.Find(lVar11,"ExchangeTeamButton",0)) == null) ||
                (lVar11 = Component.get_gameObject(lVar11,0)) == null))) goto LAB_180eb931a;
            cVar7 = GameObject.get_activeSelf(lVar11,0);
            if (cVar7) {
              if (((this.heroDetailPanel == null) ||
                  (lVar11 = GameObject.get_transform(this.heroDetailPanel,0)) == null) ||
                 ((lVar11 = Transform.Find(lVar11,"ExchangeTeamButton",0), lVar11 == null ||
                  (lVar11 = Component.get_gameObject(lVar11,0)) == null))) goto LAB_180eb931a;
              GameObject.SetActive(lVar11,0,0);
            }
            if (((this.heroDetailPanel == null) ||
                (lVar11 = GameObject.get_transform(this.heroDetailPanel,0)) == null) ||
               ((lVar11 = Transform.Find(lVar11,"LeaveTeamButton",0), lVar11 == null ||
                (lVar11 = Component.get_gameObject(lVar11,0)) == null))) goto LAB_180eb931a;
            cVar7 = GameObject.get_activeSelf(lVar11,0);
            if (cVar7) {
              if ((((this.heroDetailPanel == null) ||
                   (lVar11 = GameObject.get_transform(this.heroDetailPanel,0)) == null) ||
                  (lVar11 = Transform.Find(lVar11,"LeaveTeamButton",0)) == null) ||
                 (lVar11 = Component.get_gameObject(lVar11,0)) == null) goto LAB_180eb931a;
              GameObject.SetActive(lVar11,0,0);
            }
            if (((this.heroDetailPanel == null) ||
                (lVar11 = GameObject.get_transform(this.heroDetailPanel,0)) == null) ||
               ((lVar11 = Transform.Find(lVar11,"TalkButton",0), lVar11 == null ||
                (lVar11 = Component.get_gameObject(lVar11,0)) == null))) goto LAB_180eb931a;
            cVar7 = GameObject.get_activeSelf(lVar11,0);
            if (cVar7) {
              if (((this.heroDetailPanel == null) ||
                  (lVar11 = GameObject.get_transform(this.heroDetailPanel,0)) == null) ||
                 ((lVar11 = Transform.Find(lVar11,"TalkButton",0), lVar11 == null ||
                  (lVar11 = Component.get_gameObject(lVar11,0)) == null))) goto LAB_180eb931a;
              GameObject.SetActive(lVar11,0,0);
            }
          }
          if (((this.heroDetailPanel == null) ||
              (lVar11 = GameObject.get_transform(this.heroDetailPanel,0)) == null) ||
             (lVar11 = Transform.Find(lVar11,"TeamMateTimeLeft",0)) == null) goto LAB_180eb931a;
          uVar12 = Component.GetComponent(lVar11,DAT_181d6d8c0);
          if (this.nowShowHero == null) goto LAB_180eb931a;
          iVar9 = this.nowShowHero.autoLeaveTeamDay;
          lVar11 = "";
          if (-1 < iVar9) {
            local_e4 = iVar9;
            uVar13 = il2cpp_value_box(DAT_181d5b2f8,&local_e4);
            lVar11 = String.Format("离队时间\n{0}日",uVar13,0);
          }
          LTLocalization.SetText(uVar12,lVar11,0);
          if (((((this.heroDetailPanel == null) ||
                (lVar11 = GameObject.get_transform(this.heroDetailPanel,0)) == null) ||
               ((lVar11 = Transform.Find(lVar11,"Log",0), lVar11 == null ||
                ((lVar11 = Transform.Find(lVar11,"LogListScrollView",0), lVar11 == null ||
                 (lVar11 = Transform.Find(lVar11,"Viewport",0)) == null))))) ||
              (lVar11 = Transform.Find(lVar11,"Content",0)) == null) ||
             (lVar11 = Transform.Find(lVar11,"Text",0)) == null) goto LAB_180eb931a;
          uVar12 = Component.GetComponent(lVar11,DAT_181d6d8c0);
          lVar11 = this.nowShowHero;
          if (lVar11 == null) goto LAB_180eb931a;
          lVar15 = "";
          if (lVar11.heroID != null) {
            lVar15 = HeroData.GetRecordLog(lVar11,0);
          }
          LTLocalization.SetText(uVar12,lVar15,0);
          if (this.nowShowHero == null) goto LAB_180eb931a;
          cVar7 = HeroData.ItemLockable(this.nowShowHero,0);
          lVar11 = this.heroDetailPanel;
          if (!cVar7) {
            if ((((lVar11 == null) || (lVar11 = GameObject.get_transform(lVar11,0)) == null) ||
                (lVar11 = Transform.Find(lVar11,"Item",0)) == null) ||
               ((lVar11 = Transform.Find(lVar11,"EquipLock",0), lVar11 == null ||
                (lVar11 = Component.get_gameObject(lVar11,0)) == null))) goto LAB_180eb931a;
            cVar7 = GameObject.get_activeSelf(lVar11,0);
            if (cVar7) {
              if (((this.heroDetailPanel == null) ||
                  (lVar11 = GameObject.get_transform(this.heroDetailPanel,0)) == null) ||
                 ((lVar11 = Transform.Find(lVar11,"Item",0), lVar11 == null ||
                  ((lVar11 = Transform.Find(lVar11,"EquipLock",0), lVar11 == null ||
                   (lVar11 = Component.get_gameObject(lVar11,0)) == null))))) goto LAB_180eb931a;
              GameObject.SetActive(lVar11,0,0);
            }
            if ((((this.heroDetailPanel == null) ||
                 (lVar11 = GameObject.get_transform(this.heroDetailPanel,0)) == null) ||
                (lVar11 = Transform.Find(lVar11,"Skill",0)) == null) ||
               ((lVar11 = Transform.Find(lVar11,"SkillLock",0), lVar11 == null ||
                (lVar11 = Component.get_gameObject(lVar11,0)) == null))) goto LAB_180eb931a;
            cVar7 = GameObject.get_activeSelf(lVar11,0);
            if (cVar7) {
              if (((this.heroDetailPanel == null) ||
                  (lVar11 = GameObject.get_transform(this.heroDetailPanel,0)) == null) ||
                 ((lVar11 = Transform.Find(lVar11,"Skill",0), lVar11 == null ||
                  ((lVar11 = Transform.Find(lVar11,"SkillLock",0), lVar11 == null ||
                   (lVar11 = Component.get_gameObject(lVar11,0)) == null))))) goto LAB_180eb931a;
              GameObject.SetActive(lVar11,0,0);
            }
          }
          else {
            if ((((lVar11 == null) || (lVar11 = GameObject.get_transform(lVar11,0)) == null) ||
                (lVar11 = Transform.Find(lVar11,"Item",0)) == null) ||
               ((lVar11 = Transform.Find(lVar11,"EquipLock",0), lVar11 == null ||
                (lVar11 = Component.get_gameObject(lVar11,0)) == null))) goto LAB_180eb931a;
            cVar7 = GameObject.get_activeSelf(lVar11,0);
            if (!cVar7) {
              if (((this.heroDetailPanel == null) ||
                  (lVar11 = GameObject.get_transform(this.heroDetailPanel,0)) == null) ||
                 ((lVar11 = Transform.Find(lVar11,"Item",0), lVar11 == null ||
                  (lVar11 = Transform.Find(lVar11,"EquipLock",0)) == null))) goto LAB_180eb931a;
              lVar11 = Component.get_gameObject(lVar11,0);
              if (lVar11 == null) goto LAB_180eb931a;
              GameObject.SetActive(lVar11,1,0);
            }
            if ((((this.heroDetailPanel == null) ||
                 (lVar11 = GameObject.get_transform(this.heroDetailPanel,0)) == null) ||
                (lVar11 = Transform.Find(lVar11,"Item",0)) == null) ||
               (lVar11 = Transform.Find(lVar11,"EquipLock",0)) == null) goto LAB_180eb931a;
            lVar11 = Component.GetComponent(lVar11,DAT_181d6da40);
            if ((this.nowShowHero == null) || (lVar11 == null)) goto LAB_180eb931a;
            Toggle.set_isOn(lVar11,this.nowShowHero.equipLock,0);
            if ((((this.heroDetailPanel == null) ||
                 ((lVar11 = GameObject.get_transform(this.heroDetailPanel,0), lVar11 == null ||
                  (lVar11 = Transform.Find(lVar11,"Skill",0)) == null))) ||
                (lVar11 = Transform.Find(lVar11,"SkillLock",0)) == null) ||
               (lVar11 = Component.get_gameObject(lVar11,0)) == null) goto LAB_180eb931a;
            cVar7 = GameObject.get_activeSelf(lVar11,0);
            if (!cVar7) {
              if ((((this.heroDetailPanel == null) ||
                   (lVar11 = GameObject.get_transform(this.heroDetailPanel,0)) == null) ||
                  (lVar11 = Transform.Find(lVar11,"Skill",0)) == null) ||
                 (lVar11 = Transform.Find(lVar11,"SkillLock",0)) == null) goto LAB_180eb931a;
              lVar11 = Component.get_gameObject(lVar11,0);
              if (lVar11 == null) goto LAB_180eb931a;
              GameObject.SetActive(lVar11,1,0);
            }
            if (((this.heroDetailPanel == null) ||
                (lVar11 = GameObject.get_transform(this.heroDetailPanel,0)) == null) ||
               ((lVar11 = Transform.Find(lVar11,"Skill",0), lVar11 == null ||
                (lVar11 = Transform.Find(lVar11,"SkillLock",0)) == null))) goto LAB_180eb931a;
            lVar11 = Component.GetComponent(lVar11,DAT_181d6da40);
            if ((this.nowShowHero == null) || (lVar11 == null)) goto LAB_180eb931a;
            Toggle.set_isOn(lVar11,this.nowShowHero.skillLock,0);
          }
          if ((((this.heroDetailPanel == null) ||
               (lVar11 = GameObject.get_transform(this.heroDetailPanel,0)) == null) ||
              (lVar11 = Transform.Find(lVar11,"SetNameButton",0)) == null) ||
             (lVar11 = Component.get_gameObject(lVar11,0)) == null) goto LAB_180eb931a;
          cVar7 = GameObject.get_activeSelf(lVar11,0);
          if (this.nowShowHero == null) goto LAB_180eb931a;
          cVar4 = HeroData.CanSetName(this.nowShowHero,0);
          if (cVar7 != cVar4) {
            if (((this.heroDetailPanel == null) ||
                (lVar11 = GameObject.get_transform(this.heroDetailPanel,0)) == null) ||
               (lVar11 = Transform.Find(lVar11,"SetNameButton",0)) == null) goto LAB_180eb931a;
            lVar11 = Component.get_gameObject(lVar11,0);
            if ((this.nowShowHero == null) ||
               (uVar6 = HeroData.CanSetName(this.nowShowHero,0), lVar11 == null))
            goto LAB_180eb931a;
            GameObject.SetActive(lVar11,uVar6,0);
          }
          if (((this.heroDetailPanel != null) &&
              (lVar11 = GameObject.get_transform(this.heroDetailPanel,0)) != null) &&
             (lVar11 = Transform.Find(lVar11,"BuffGrid",0)) != null) {
            uVar12 = Component.get_gameObject(lVar11,0);
            HeroDetailController.RefreshBuffGrid(uVar12,this.nowShowHero,0);
            if (((this.heroDetailPanel != null) &&
                (lVar11 = GameObject.get_transform(this.heroDetailPanel,0)) != null) &&
               (lVar11 = Transform.Find(lVar11,"BuffGrid",0)) != null) {
              uVar12 = Component.get_gameObject(lVar11,0);
              lVar11 = new WarpText_d__8(0,0);
              if (lVar11 != null) {
                lVar11.summonControlable = uVar12;
                FUN_180d837c0(this,lVar11,0);
                return;
              }
            }
          }
          goto LAB_180eb931a;
        }
        if (*pStatics_e188 == 0) goto LAB_180eb931a;
        uVar13 = *(uint64 *)(*pStatics_e188 + 200);
        lVar11 = GlobalData.AddChild(uVar12,uVar13,0);
        if (lVar11 == null) goto LAB_180eb931a;
        lVar15 = GameObject.GetComponent(lVar11,DAT_181d9fcb8);
        if (((this.nowShowHero == null) ||
            (lVar18 = this.nowShowHero.heroTagData) == null) ||
           (uVar13 = FUN_180002f80(lVar18,uVar24), lVar15 == null)) goto LAB_180eb931a;
        lVar15.itemListInteractType = uVar13;
        lVar11 = GameObject.GetComponent(lVar11,DAT_181d9fcb8);
        if (lVar11 == null) goto LAB_180eb931a;
        uVar24 = uVar24 + 1;
        lVar11.summonSourceHero = 1;
        lVar11 = this.nowShowHero;
        if (lVar11 == null) goto LAB_180eb931a;
        goto LAB_180eb7cf0;
    }

    // Token : 0x600173C
    // RVA   : 0xEC59B0   Offset: 0xEC41B0   Length: 0x1C3
    public void UseSpeSkeletonButtonClicked()
    {
        long lVar1;
        ulong uVar2;
        long lVar3;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d4e010 + 184) + 8);
        if (lVar1 != null) {
          lVar1 = *(int64 *)(lVar1 + 16);
          if (this.nowShowHero != null) {
            uVar2 = String.Concat(this.nowShowHero.heroName,"hideSpeSkeleton",0);
            if (this.heroDetailPanel != null) {
              lVar3 = GameObject.get_transform(this.heroDetailPanel,0);
              if (lVar3 != null) {
                lVar3 = Transform.Find(lVar3,"UseSpeSkeleton",0);
                if (lVar3 != null) {
                  lVar3 = Component.GetComponent(lVar3,DAT_181d6da40);
                  if ((lVar3 != null) && (lVar1 != null)) {
                    PlayerPrefDictionary.SetKey(lVar1,uVar2,*(char *)(lVar3 + 0x118) == false,0);
                    HeroDetailController.RefreshHeroSkeleton(this,0);
                    plVar4 = (int64 *)Resources.Load("Sound/SoundEffect/Paper",0);
                    plVar5 = (int64 *)0;
                    if ((plVar4 != (int64 *)0) && (*plVar4 == DAT_181d8a228)) {
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

    // Token : 0x600173D
    // RVA   : 0xEC2FC0   Offset: 0xEC17C0   Length: 0x75D
    public void SetAttriDetail(Transform parent, float totalNum, float baseNum, float maxNum)
    {
        var pStatics = *(int64*)(DAT_181d4ef00 + 184);
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
          lVar3 = Component.GetComponent(lVar3,DAT_181d6c740);
          fVar9 = (float)FUN_1810a8ba0();
          lVar4 = Transform.Find(parent,"BarBack",0);
          if ((lVar4 != null) && (lVar4 = Component.GetComponent(lVar4,DAT_181d6c740)) != null) {
            local_58 = RectTransform.get_sizeDelta(lVar4,0);
            if (lVar3 != null) {
              RectTransform.set_sizeDelta(lVar3,fVar9 * 1.5,0);
              lVar3 = Transform.Find(parent,"Bar",0);
              if (lVar3 != null) {
                lVar3 = Component.GetComponent(lVar3,DAT_181d6c740);
                if ((((float)*(int *)(pStatics + 248) < maxNum) &&
                    ((*(byte *)(DAT_181d4ef00 + 0x133) & 4) != 0)) &&
                   (*(int *)(DAT_181d4ef00 + 224) == 0)) {
                  il2cpp_runtime_class_init(DAT_181d4ef00);
                }
                fVar9 = (float)FUN_1810a8ba0();
                lVar4 = Transform.Find(parent,"Bar",0);
                if ((lVar4 != null) && (lVar4 = Component.GetComponent(lVar4,DAT_181d6c740)) != null) {
                  local_58 = RectTransform.get_sizeDelta(lVar4,0);
                  if (lVar3 != null) {
                    RectTransform.set_sizeDelta(lVar3,fVar9 * 1.5,0);
                    lVar3 = Transform.Find(parent,"Total",0);
                    if (lVar3 != null) {
                      uVar5 = Component.GetComponent(lVar3,DAT_181d6d8c0);
                      uVar6 = Single.ToString(local_res18,"f0",0);
                      LTLocalization.SetText(uVar5,uVar6,0);
                      lVar3 = Transform.Find(parent,"Num",0);
                      if (lVar3 != null) {
                        uVar5 = Component.GetComponent(lVar3,DAT_181d6d8c0);
                        uVar6 = Single.ToString(local_res20,"f0",0);
                        uVar7 = Single.ToString(&maxNum,"f0",0);
                        uVar6 = String.Concat(uVar6,"/",uVar7,0);
                        LTLocalization.SetText(uVar5,uVar6,0);
                        if (local_res18[0] == local_res20[0]) {
                          lVar3 = Transform.Find(parent,"SpeAdd",0);
                          if (lVar3 == null) throw; // [null/range check failed]
                          uVar5 = Component.GetComponent(lVar3,DAT_181d6d8c0);
                          LTLocalization.SetText(uVar5,"",0);
                        }
                        else {
                          lVar3 = Transform.Find(parent,"SpeAdd",0);
                          if (lVar3 == null) throw; // [null/range check failed]
                          uVar5 = Component.GetComponent(lVar3,DAT_181d6d8c0);
                          local_res10[0] = local_res18[0] - local_res20[0];
                          uVar6 = Single.ToString(local_res10,"+0;-0;",0);
                          LTLocalization.SetText(uVar5,uVar6,0);
                          lVar3 = Transform.Find(parent,"SpeAdd",0);
                          if (lVar3 == null) throw; // [null/range check failed]
                          plVar8 = (int64 *)Component.GetComponent(lVar3,DAT_181d6d8c0);
                          if (local_res18[0] - local_res20[0] < 0.0) {
                            uVar5 = *(uint64 *)(pStatics + 0x2f8);
                            uVar6 = *(uint64 *)(pStatics + 0x300);
                          }
                          else {
                            uVar5 = *(uint64 *)(pStatics + 0x290);
                            uVar6 = *(uint64 *)(pStatics + 0x298);
                          }
                          if (plVar8 == (int64 *)0) throw; // [null/range check failed]
                          local_58 = uVar5;
                          uStack_50 = uVar6;
                          (**(code **)(*plVar8 + 0x2a8))
                                    (plVar8,&local_58,*(uint64 *)(*plVar8 + 0x2b0));
                        }
                        lVar3 = Transform.Find(parent,"Lv",0);
                        if (lVar3 != null) {
                          uVar5 = Component.GetComponent(lVar3,DAT_181d6d8c0);
                          lVar3 = *(int64 *)(pStatics + 0x558);
                          uVar1 = GlobalData.GetAttriLv(pStatics,0);
                          if (lVar3 != null) {
                            if (*(uint32 *)(lVar3 + 24) <= uVar1) {
                              ThrowHelper.ThrowArgumentOutOfRangeException(0);
                            }
                            LTLocalization.SetText
                                      (uVar5,*(uint64 *)
                                              (*(int64 *)(lVar3 + 16) + 32 +
                                              (int64)(int)uVar1 * 8),0);
                            lVar3 = Transform.Find(parent,"Lv",0);
                            if (lVar3 != null) {
                              plVar8 = (int64 *)Component.GetComponent(lVar3,DAT_181d6d8c0);
                              lVar3 = *(int64 *)(*(int64 *)(DAT_181d4e010 + 184) + 32);
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

    // Token : 0x600173E
    // RVA   : 0xEBE8A0   Offset: 0xEBD0A0   Length: 0x1C1
    public void RefreshHeroTagList(GameObject targetTagGrid)
    {
        var pStatics = *(int64*)(DAT_181d4e188 + 184);
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
            lVar3 = GameObject.GetComponent(lVar2,DAT_181d9fcb8);
            if (((this.nowShowHero == null) ||
                (lVar1 = this.nowShowHero.heroTagData) == null) ||
               (uVar4 = FUN_180002f80(lVar1,iVar5), lVar3 == null)) break;
            *(uint64 *)(lVar3 + 32) = uVar4;
            lVar2 = GameObject.GetComponent(lVar2,DAT_181d9fcb8);
            if (lVar2 == null) break;
            iVar5 = iVar5 + 1;
            lVar2.summonSourceHero = 1;
            lVar2 = this.nowShowHero;
            if (lVar2 == null) break;
          }
        }
    }

    // Token : 0x600173F
    // RVA   : 0xEBABC0   Offset: 0xEB93C0   Length: 0x80D
    public static void RefreshBuffGrid(GameObject targetBuffGrid, HeroData targetHero)
    {
        var pStatics = *(int64*)(DAT_181d4ef00 + 184);
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
          FUN_1800d6620();
        }
        FUN_181808140(&local_68,lVar3,DAT_181d67cf8);
        local_80 = local_68;
        uStack_7c = uStack_64;
        uStack_78 = uStack_60;
        uStack_74 = uStack_5c;
        local_70 = local_58;
        while( true ) {
          do {
            do {
              cVar2 = FUN_180d19a30(&local_80,DAT_181d675c8);
              uVar1 = local_70;
              if (!cVar2) {
                ZhSegment.Initialize(&local_80,DAT_181d67548);
                return;
              }
              lVar3 = FUN_18046c100(0);
              if (lVar3 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              if (*(int64 *)(lVar3 + 144) == 0) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              lVar3 = FUN_180002f80(*(int64 *)(lVar3 + 144),uVar1 & 0xffffffff,DAT_181d64878);
              if (lVar3 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
            } while (*(int *)(lVar3 + 60) == 0);
            if (*(int64 *)(targetHero + 0x2c0) == 0) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            fVar10 = (float)HeroSpeAddData.Get(*(int64 *)(targetHero + 0x2c0),uVar1 & 0xffffffff,0);
          } while (fVar10 <= 0.0);
          lVar3 = FUN_18046bb80(0);
          if (lVar3 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          uVar5 = *(uint64 *)(lVar3 + 0x158);
          lVar3 = GlobalData.AddChild(targetBuffGrid,uVar5,0);
          if (lVar3 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          lVar4 = GameObject.get_transform(lVar3,0);
          if (lVar4 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          lVar4 = Transform.Find(lVar4,"Text",0);
          if (lVar4 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          uVar5 = Component.GetComponent(lVar4,DAT_181d6d8c0);
          plVar6 = (int64 *)FUN_1800d60b0(DAT_181d80cc0,5);
          lVar4 = FUN_18046c100(0);
          if (lVar4 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          if (*(int64 *)(lVar4 + 144) == 0) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          lVar4 = FUN_180002f80(*(int64 *)(lVar4 + 144),uVar1 & 0xffffffff,DAT_181d64878);
          if (lVar4 == null) break;
          if (*(char *)(lVar4 + 64) == false) {
            lVar4 = *(int64 *)(pStatics + 0x2c8);
          }
          else {
            lVar4 = *(int64 *)(pStatics + 0x260);
          }
          if (plVar6 == (int64 *)0) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          if ((lVar4 != null) &&
             (lVar7 = il2cpp_internal(lVar4,*(uint64 *)(*plVar6 + 64))) == null) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar5,0);
          }
          FUN_180002fd0(plVar6,0,lVar4);
          lVar4 = FUN_18046c100(0);
          if (lVar4 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          if (*(int64 *)(lVar4 + 144) == 0) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          lVar4 = FUN_180002f80(*(int64 *)(lVar4 + 144),uVar1 & 0xffffffff,DAT_181d64878);
          if (lVar4 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          lVar4 = *(int64 *)(lVar4 + 16);
          if ((lVar4 != null) &&
             (lVar7 = il2cpp_internal(lVar4,*(uint64 *)(*plVar6 + 64))) == null) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar5,0);
          }
          if (*(uint32 *)(plVar6 + 3) < 2) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar5,0);
          }
          plVar6[5] = lVar4;
          il2cpp_internal(plVar6 + 5,lVar4);
          lVar4 = HeroData.GetBuffLevelString(targetHero,uVar1 & 0xffffffff,0);
          if ((lVar4 != null) &&
             (lVar7 = il2cpp_internal(lVar4,*(uint64 *)(*plVar6 + 64))) == null) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar5,0);
          }
          if (*(uint32 *)(plVar6 + 3) < 3) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar5,0);
          }
          plVar6[6] = lVar4;
          il2cpp_internal(plVar6 + 6,lVar4);
          if (*(int64 *)(targetHero + 0x2c0) == 0) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          fVar10 = (float)HeroSpeAddData.Get(*(int64 *)(targetHero + 0x2c0),uVar1 & 0xffffffff,0);
          lVar4 = "(永久)";
          if (fVar10 < 999.0) {
            lVar4 = FUN_18046c100(0);
            if (lVar4 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            if (*(int64 *)(lVar4 + 144) == 0) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar4 = FUN_180002f80(*(int64 *)(lVar4 + 144),uVar1 & 0xffffffff,DAT_181d64878);
            if (lVar4 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            uVar9 = "[{0}合]";
            if (*(int *)(lVar4 + 60) == -1) {
              uVar9 = "({0}秒)";
            }
            if (*(int64 *)(targetHero + 0x2c0) == 0) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            local_res8[0] = HeroSpeAddData.Get(*(int64 *)(targetHero + 0x2c0),uVar1 & 0xffffffff,0);
            uVar8 = Single.ToString(local_res8,"f0",0);
            lVar4 = String.Format(uVar9,uVar8,0);
          }
          if ((lVar4 != null) &&
             (lVar7 = il2cpp_internal(lVar4,*(uint64 *)(*plVar6 + 64))) == null) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar5,0);
          }
          FUN_180002fd0(plVar6,3,lVar4);
          if (("</color>" != 0) &&
             (lVar4 = il2cpp_internal("</color>",*(uint64 *)(*plVar6 + 64))) == null) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar5,0);
          }
          lVar4 = "</color>";
          if (*(uint32 *)(plVar6 + 3) < 5) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar5,0);
          }
          plVar6[8] = "</color>";
          il2cpp_internal(plVar6 + 8,lVar4);
          uVar9 = String.Concat(plVar6,0);
          LTLocalization.SetText(uVar5,uVar9,0);
          lVar3 = GameObject.GetComponent(lVar3,DAT_181da12b0);
          lVar4 = FUN_18046c100(0);
          if (lVar4 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          if (*(int64 *)(lVar4 + 144) == 0) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          lVar4 = FUN_180002f80(*(int64 *)(lVar4 + 144),uVar1 & 0xffffffff,DAT_181d64878);
          if (lVar4 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          if (lVar3 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          *(uint64 *)(lVar3 + 24) = *(uint64 *)(lVar4 + 24);
        }
    }

    // Token : 0x6001740
    // RVA   : 0xEBAB50   Offset: 0xEB9350   Length: 0x6C
    public static IEnumerator RefreshBuffGridPos(GameObject targetBuffGrid)
    {
        long lVar1;
        lVar1 = new WarpText_d__8(0,0);
        if (lVar1 != null) {
          *(uint64 *)(lVar1 + 32) = targetBuffGrid;
          return lVar1;
        }
    }

    // Token : 0x6001741
    // RVA   : 0xEBEBD0   Offset: 0xEBD3D0   Length: 0x1360
    public void RefreshLifeList(bool resetPos)
    {
        var pStatics = *(int64*)(DAT_181d4ef00 + 184);
        long lVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        ulong uVar5;
        long lVar6;
        uint uVar7;
        long lVar8;
        uint uVar9;
        uint[] local_res8 = new uint[2];
        uint[] local_res20 = new uint[2];
        if ((((this.heroDetailPanel != null) &&
             (lVar2 = GameObject.get_transform(this.heroDetailPanel,0)) != null) &&
            (lVar2 = Transform.Find(lVar2,"Life",0)) != null) &&
           ((lVar2 = Transform.Find(lVar2,"Teacher",0), lVar2 != null &&
            (lVar2 = Transform.Find(lVar2,"Content",0)) != null))) {
          uVar3 = Component.get_gameObject(lVar2,0);
          GlobalData.DeleteAllChild(uVar3,0);
          if (((this.heroDetailPanel != null) &&
              (lVar2 = GameObject.get_transform(this.heroDetailPanel,0)) != null) &&
             ((lVar2 = Transform.Find(lVar2,"Life",0), lVar2 != null &&
              ((lVar2 = Transform.Find(lVar2,"Teacher",0), lVar2 != null &&
               (lVar2 = Transform.Find(lVar2,"Content",0)) != null))))) {
            uVar3 = Component.get_gameObject(lVar2,0);
            if (this.nowShowHero != null) {
              HeroDetailController.CreateLifeHeroIcon
                        (this,uVar3,this.nowShowHero.Teacher,0);
              if ((((this.heroDetailPanel != null) &&
                   (lVar2 = GameObject.get_transform(this.heroDetailPanel,0)) != null) &&
                  (lVar2 = Transform.Find(lVar2,"Life",0)) != null) &&
                 ((lVar2 = Transform.Find(lVar2,"Student",0), lVar2 != null &&
                  (lVar2 = Transform.Find(lVar2,"Num",0)) != null))) {
                uVar3 = Component.GetComponent(lVar2,DAT_181d6d8c0);
                lVar2 = this.nowShowHero;
                if (lVar2 != null) {
                  uVar4 = "";
                  if (lVar2.belongForceID < 0) {
                    if (lVar2.Students == 0) {
        LAB_180ebff13:
                          // WARNING: Subroutine does not return
                      FUN_1800d6620();
                    }
                    local_res8[0] = *(uint32 *)(lVar2.Students + 24);
                    uVar4 = il2cpp_value_box(DAT_181d5b2f8,local_res8);
                    if (this.nowShowHero == null) goto LAB_180ebff13;
                    local_res20[0] = HeroData.GetMaxStudent(this.nowShowHero,0);
                    uVar5 = il2cpp_value_box(DAT_181d5b2f8,local_res20);
                    uVar4 = String.Format("{0}/{1}",uVar4,uVar5,0);
                  }
                  LTLocalization.SetText(uVar3,uVar4,0);
                  if (((this.heroDetailPanel != null) &&
                      (lVar2 = GameObject.get_transform(this.heroDetailPanel,0)) != null) &&
                     ((lVar2 = Transform.Find(lVar2,"Life",0), lVar2 != null &&
                      (((lVar2 = Transform.Find(lVar2,"Student",0), lVar2 != null &&
                        (lVar2 = Transform.Find(lVar2,"Viewport",0)) != null) &&
                       (lVar2 = Transform.Find(lVar2,"Content",0)) != null))))) {
                    uVar3 = Component.get_gameObject(lVar2,0);
                    GlobalData.DeleteAllChild(uVar3,0);
                    lVar2 = this.nowShowHero;
                    uVar9 = 0;
                    uVar7 = 0;
                    if (lVar2 != null) {
                      lVar8 = 32;
                      while (lVar2.Students != 0) {
                        lVar6 = this.heroDetailPanel;
                        if (*(int *)(lVar2.Students + 24) <= (int)uVar7) {
                          if (((lVar6 != null) && (lVar2 = GameObject.get_transform(lVar6,0)) != null)
                             && ((lVar2 = Transform.Find(lVar2,"Life",0), lVar2 != null &&
                                 ((lVar2 = Transform.Find(lVar2,"Lover",0), lVar2 != null &&
                                  (lVar2 = Transform.Find(lVar2,"Content",0)) != null))))) {
                            uVar3 = Component.get_gameObject(lVar2,0);
                            GlobalData.DeleteAllChild(uVar3,0);
                            if ((((this.heroDetailPanel != null) &&
                                 (lVar2 = GameObject.get_transform(this.heroDetailPanel,0),
                                 lVar2 != null)) &&
                                (lVar2 = Transform.Find(lVar2,"Life",0)) != null) &&
                               ((lVar2 = Transform.Find(lVar2,"Lover",0), lVar2 != null &&
                                (lVar2 = Transform.Find(lVar2,"Content",0)) != null))) {
                              uVar3 = Component.get_gameObject(lVar2,0);
                              if (this.nowShowHero != null) {
                                HeroDetailController.CreateLifeHeroIcon
                                          (this,uVar3,
                                           this.nowShowHero.Lover,0);
                                if (((this.heroDetailPanel != null) &&
                                    (lVar2 = GameObject.get_transform(this.heroDetailPanel,0),
                                    lVar2 != null)) &&
                                   ((lVar2 = Transform.Find(lVar2,"Life",0), lVar2 != null &&
                                    ((lVar2 = Transform.Find(lVar2,"Prelover",0), lVar2 != null &&
                                     (lVar2 = Transform.Find(lVar2,"Num",0)) != null))))) {
                                  uVar3 = Component.GetComponent(lVar2,DAT_181d6d8c0);
                                  if ((this.nowShowHero != null) &&
                                     (lVar2 = this.nowShowHero.PreLovers,
                                     lVar2 != null)) {
                                    local_res8[0] = lVar2.summonLv;
                                    uVar4 = il2cpp_value_box(DAT_181d5b2f8,local_res8);
                                    local_res20[0] =
                                         *(uint32 *)(pStatics + 148);
                                    uVar5 = il2cpp_value_box(DAT_181d5b2f8,local_res20);
                                    uVar4 = String.Format("{0}/{1}",uVar4,uVar5,0);
                                    LTLocalization.SetText(uVar3,uVar4,0);
                                    if ((((this.heroDetailPanel != null) &&
                                         (lVar2 = GameObject.get_transform
                                                            (this.heroDetailPanel,0), lVar2 != null)
                                         ) && (lVar2 = Transform.Find(lVar2,"Life",0)) != null
                                        ) && (((lVar2 = Transform.Find(lVar2,"Prelover",0), lVar2 != null
                                               && (lVar2 = Transform.Find(lVar2,"Viewport",0),
                                                  lVar2 != null)) &&
                                              (lVar2 = Transform.Find(lVar2,"Content",0)) != null
                                              ))) {
                                      uVar3 = Component.get_gameObject(lVar2,0);
                                      GlobalData.DeleteAllChild(uVar3,0);
                                      lVar2 = this.nowShowHero;
                                      uVar7 = 0;
                                      if (lVar2 != null) goto LAB_180ebf430;
                                      break;
                                    }
                                  }
                                }
                              }
                            }
                          }
                          // WARNING: Subroutine does not return
                          FUN_1800d6620();
                        }
                        if (((((lVar6 == null) || (lVar2 = GameObject.get_transform(lVar6,0)) == null)
                             || (lVar2 = Transform.Find(lVar2,"Life",0)) == null) ||
                            ((lVar2 = Transform.Find(lVar2,"Student",0), lVar2 == null ||
                             (lVar2 = Transform.Find(lVar2,"Viewport",0)) == null))) ||
                           (lVar2 = Transform.Find(lVar2,"Content",0)) == null) break;
                        uVar3 = Component.get_gameObject(lVar2,0);
                        if ((this.nowShowHero == null) ||
                           (lVar2 = this.nowShowHero.Students) == null)
                        break;
                        if (lVar2.summonLv <= uVar7) {
                          ThrowHelper.ThrowArgumentOutOfRangeException(0);
                        }
                        HeroDetailController.CreateLifeHeroIcon(this,uVar3);
                        lVar2 = this.nowShowHero;
                        uVar7 = uVar7 + 1;
                        if (lVar2 == null) break;
                      }
                    }
                  }
                }
              }
            }
          }
        }
        LAB_180ebff19:
                          // WARNING: Subroutine does not return
        FUN_1800d6620();
        LAB_180ebf430:
        if (lVar2.PreLovers == null) goto LAB_180ebff19;
        lVar6 = this.heroDetailPanel;
        if (*(int *)(lVar2.PreLovers + 24) <= (int)uVar7) {
          if (((lVar6 != null) && (lVar2 = GameObject.get_transform(lVar6,0)) != null) &&
             ((lVar2 = Transform.Find(lVar2,"Life",0), lVar2 != null &&
              ((lVar2 = Transform.Find(lVar2,"Brother",0), lVar2 != null &&
               (lVar2 = Transform.Find(lVar2,"Num",0)) != null))))) {
            uVar3 = Component.GetComponent(lVar2,DAT_181d6d8c0);
            if ((this.nowShowHero != null) &&
               (lVar2 = this.nowShowHero.Brothers) != null) {
              local_res8[0] = lVar2.summonLv;
              uVar4 = il2cpp_value_box(DAT_181d5b2f8,local_res8);
              local_res20[0] = *(uint32 *)(pStatics + 152);
              uVar5 = il2cpp_value_box(DAT_181d5b2f8,local_res20);
              uVar4 = String.Format("{0}/{1}",uVar4,uVar5,0);
              LTLocalization.SetText(uVar3,uVar4,0);
              if ((((this.heroDetailPanel != null) &&
                   (lVar2 = GameObject.get_transform(this.heroDetailPanel,0)) != null) &&
                  (lVar2 = Transform.Find(lVar2,"Life",0)) != null) &&
                 (((lVar2 = Transform.Find(lVar2,"Brother",0), lVar2 != null &&
                   (lVar2 = Transform.Find(lVar2,"Viewport",0)) != null) &&
                  (lVar2 = Transform.Find(lVar2,"Content",0)) != null))) {
                uVar3 = Component.get_gameObject(lVar2,0);
                GlobalData.DeleteAllChild(uVar3,0);
                lVar2 = this.nowShowHero;
                uVar7 = 0;
                if (lVar2 != null) goto LAB_180ebf710;
                goto LAB_180ebff19;
              }
            }
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        if ((((lVar6 == null) || (lVar2 = GameObject.get_transform(lVar6,0)) == null) ||
            (lVar2 = Transform.Find(lVar2,"Life",0)) == null) ||
           (((lVar2 = Transform.Find(lVar2,"Prelover",0), lVar2 == null ||
             (lVar2 = Transform.Find(lVar2,"Viewport",0)) == null) ||
            (lVar2 = Transform.Find(lVar2,"Content",0)) == null))) goto LAB_180ebff19;
        uVar3 = Component.get_gameObject(lVar2,0);
        if ((this.nowShowHero == null) ||
           (lVar2 = this.nowShowHero.PreLovers) == null) goto LAB_180ebff19;
        if (lVar2.summonLv <= uVar7) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        HeroDetailController.CreateLifeHeroIcon(this,uVar3);
        lVar2 = this.nowShowHero;
        uVar7 = uVar7 + 1;
        if (lVar2 == null) goto LAB_180ebff19;
        goto LAB_180ebf430;
        LAB_180ebf710:
        if (lVar2.Brothers == null) goto LAB_180ebff19;
        lVar6 = this.heroDetailPanel;
        if (*(int *)(lVar2.Brothers + 24) <= (int)uVar7) {
          if (((lVar6 != null) && (lVar2 = GameObject.get_transform(lVar6,0)) != null) &&
             ((lVar2 = Transform.Find(lVar2,"Life",0), lVar2 != null &&
              ((lVar2 = Transform.Find(lVar2,"Friend",0), lVar2 != null &&
               (lVar2 = Transform.Find(lVar2,"Num",0)) != null))))) {
            uVar3 = Component.GetComponent(lVar2,DAT_181d6d8c0);
            if ((this.nowShowHero != null) &&
               (lVar2 = this.nowShowHero.Friends) != null) {
              local_res8[0] = lVar2.summonLv;
              uVar4 = il2cpp_value_box(DAT_181d5b2f8,local_res8);
              local_res20[0] = *(uint32 *)(pStatics + 144);
              uVar5 = il2cpp_value_box(DAT_181d5b2f8,local_res20);
              uVar4 = String.Format("{0}/{1}",uVar4,uVar5,0);
              LTLocalization.SetText(uVar3,uVar4,0);
              if (((((this.heroDetailPanel != null) &&
                    (lVar2 = GameObject.get_transform(this.heroDetailPanel,0)) != null) &&
                   (lVar2 = Transform.Find(lVar2,"Life",0)) != null) &&
                  ((lVar2 = Transform.Find(lVar2,"Friend",0), lVar2 != null &&
                   (lVar2 = Transform.Find(lVar2,"Viewport",0)) != null))) &&
                 (lVar2 = Transform.Find(lVar2,"Content",0)) != null) {
                uVar3 = Component.get_gameObject(lVar2,0);
                GlobalData.DeleteAllChild(uVar3,0);
                lVar2 = this.nowShowHero;
                uVar7 = 0;
                if (lVar2 != null) {
                  lVar6 = 32;
                  goto LAB_180ebf9f0;
                }
                goto LAB_180ebff19;
              }
            }
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        if (((((lVar6 == null) || (lVar2 = GameObject.get_transform(lVar6,0)) == null) ||
             (lVar2 = Transform.Find(lVar2,"Life",0)) == null) ||
            ((lVar2 = Transform.Find(lVar2,"Brother",0), lVar2 == null ||
             (lVar2 = Transform.Find(lVar2,"Viewport",0)) == null))) ||
           (lVar2 = Transform.Find(lVar2,"Content",0)) == null) goto LAB_180ebff19;
        uVar3 = Component.get_gameObject(lVar2,0);
        if ((this.nowShowHero == null) ||
           (lVar2 = this.nowShowHero.Brothers) == null) goto LAB_180ebff19;
        if (lVar2.summonLv <= uVar7) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        HeroDetailController.CreateLifeHeroIcon(this,uVar3);
        lVar2 = this.nowShowHero;
        uVar7 = uVar7 + 1;
        if (lVar2 == null) goto LAB_180ebff19;
        goto LAB_180ebf710;
        LAB_180ebf9f0:
        if (lVar2.Friends == null) goto LAB_180ebff19;
        lVar1 = this.heroDetailPanel;
        if (*(int *)(lVar2.Friends + 24) <= (int)uVar7) {
          if (((lVar1 != null) && (lVar2 = GameObject.get_transform(lVar1,0)) != null) &&
             ((lVar2 = Transform.Find(lVar2,"Life",0), lVar2 != null &&
              (((lVar2 = Transform.Find(lVar2,"Hater",0), lVar2 != null &&
                (lVar2 = Transform.Find(lVar2,"Viewport",0)) != null) &&
               (lVar2 = Transform.Find(lVar2,"Content",0)) != null))))) {
            uVar3 = Component.get_gameObject(lVar2,0);
            GlobalData.DeleteAllChild(uVar3,0);
            lVar2 = this.nowShowHero;
            if (lVar2 != null) goto LAB_180ebfbd0;
          }
          goto LAB_180ebff19;
        }
        if ((((lVar1 == null) || (lVar2 = GameObject.get_transform(lVar1,0)) == null) ||
            (lVar2 = Transform.Find(lVar2,"Life",0)) == null) ||
           (((lVar2 = Transform.Find(lVar2,"Friend",0), lVar2 == null ||
             (lVar2 = Transform.Find(lVar2,"Viewport",0)) == null) ||
            (lVar2 = Transform.Find(lVar2,"Content",0)) == null))) goto LAB_180ebff19;
        uVar3 = Component.get_gameObject(lVar2,0);
        if ((this.nowShowHero == null) ||
           (lVar2 = this.nowShowHero.Friends) == null) goto LAB_180ebff19;
        if (lVar2.summonLv <= uVar7) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        HeroDetailController.CreateLifeHeroIcon
                  (this,uVar3,*(uint32 *)(lVar2.isSummon + lVar6),0);
        lVar2 = this.nowShowHero;
        uVar7 = uVar7 + 1;
        lVar6 = lVar6 + 4;
        if (lVar2 == null) goto LAB_180ebff19;
        goto LAB_180ebf9f0;
        LAB_180ebfbd0:
        if (lVar2.Haters == null) goto LAB_180ebff19;
        if (*(int *)(lVar2.Haters + 24) <= (int)uVar9) {
          if (resetPos) {
            if (((this.heroDetailPanel == null) ||
                (lVar2 = GameObject.get_transform(this.heroDetailPanel,0)) == null) ||
               ((lVar2 = Transform.Find(lVar2,"Life",0), lVar2 == null ||
                (((lVar2 = Transform.Find(lVar2,"Student",0), lVar2 == null ||
                  (lVar2 = Component.GetComponent(lVar2,DAT_181d6c940)) == null) ||
                 (lVar2.heroAIData == null)))))) goto LAB_180ebff19;
            Scrollbar.set_value(lVar2.heroAIData,0x3f800000,0);
            if (((this.heroDetailPanel == null) ||
                (lVar2 = GameObject.get_transform(this.heroDetailPanel,0)) == null) ||
               ((lVar2 = Transform.Find(lVar2,"Life",0), lVar2 == null ||
                (((lVar2 = Transform.Find(lVar2,"Brother",0), lVar2 == null ||
                  (lVar2 = Component.GetComponent(lVar2,DAT_181d6c940)) == null) ||
                 (lVar2.heroAIData == null)))))) goto LAB_180ebff19;
            Scrollbar.set_value(lVar2.heroAIData,0x3f800000,0);
            if (((((this.heroDetailPanel == null) ||
                  (lVar2 = GameObject.get_transform(this.heroDetailPanel,0)) == null) ||
                 (lVar2 = Transform.Find(lVar2,"Life",0)) == null) ||
                ((lVar2 = Transform.Find(lVar2,"Friend",0), lVar2 == null ||
                 (lVar2 = Component.GetComponent(lVar2,DAT_181d6c940)) == null))) ||
               (lVar2.heroAIData == null)) goto LAB_180ebff19;
            Scrollbar.set_value(lVar2.heroAIData,0x3f800000,0);
            if (((this.heroDetailPanel == null) ||
                (lVar2 = GameObject.get_transform(this.heroDetailPanel,0)) == null) ||
               ((lVar2 = Transform.Find(lVar2,"Life",0), lVar2 == null ||
                (((lVar2 = Transform.Find(lVar2,"Hater",0), lVar2 == null ||
                  (lVar2 = Component.GetComponent(lVar2,DAT_181d6c940)) == null) ||
                 (lVar2.heroAIData == null)))))) goto LAB_180ebff19;
            Scrollbar.set_value(lVar2.heroAIData,0x3f800000,0);
          }
          return;
        }
        if (((this.heroDetailPanel == null) ||
            (lVar2 = GameObject.get_transform(this.heroDetailPanel,0)) == null) ||
           (((lVar2 = Transform.Find(lVar2,"Life",0), lVar2 == null ||
             ((lVar2 = Transform.Find(lVar2,"Hater",0), lVar2 == null ||
              (lVar2 = Transform.Find(lVar2,"Viewport",0)) == null))) ||
            (lVar2 = Transform.Find(lVar2,"Content",0)) == null))) goto LAB_180ebff19;
        uVar3 = Component.get_gameObject(lVar2,0);
        if ((this.nowShowHero == null) ||
           (lVar2 = this.nowShowHero.Haters) == null) goto LAB_180ebff19;
        if (lVar2.summonLv <= uVar9) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        HeroDetailController.CreateLifeHeroIcon
                  (this,uVar3,*(uint32 *)(lVar2.isSummon + lVar8),0);
        lVar2 = this.nowShowHero;
        uVar9 = uVar9 + 1;
        lVar8 = lVar8 + 4;
        if (lVar2 == null) goto LAB_180ebff19;
        goto LAB_180ebfbd0;
    }

    // Token : 0x6001742
    // RVA   : 0xEB1310   Offset: 0xEAFB10   Length: 0x1F4
    public void CreateLifeHeroIcon(GameObject targetObj, int heroID)
    {
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        var pStatics_e188 = *(int64*)(DAT_181d4e188 + 184);
        long lVar1;
        ulong uVar2;
        long lVar3;
        if (heroID == -1) {
          return;
        }
        if (*pStatics_e188 != 0) {
          uVar2 = *(uint64 *)(*pStatics_e188 + 144);
          uVar2 = GlobalData.AddChild(targetObj,uVar2,0);
          this.temp = uVar2;
          if (this.temp != null) {
            lVar3 = GameObject.GetComponent(this.temp,DAT_181d9fb20);
            if (((*pStatics_df90 != 0) &&
                (lVar1 = *(int64 *)(*pStatics_df90 + 32)) != null) &&
               (uVar2 = WorldData.GetHero(lVar1,heroID,0), lVar3 != null)) {
              *(uint64 *)(lVar3 + 32) = uVar2;
              if ((this.temp != null) &&
                 (lVar3 = GameObject.GetComponent(this.temp,DAT_181d9fb20),
                 lVar3 != null)) {
                *(uint32 *)(lVar3 + 24) = 0;
                if ((this.temp != null) &&
                   (lVar3 = GameObject.GetComponent(this.temp,DAT_181d9fb20),
                   lVar3 != null)) {
                  HeroIconController.AutoSetName(lVar3,0);
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x6001743
    // RVA   : 0xEBE240   Offset: 0xEBCA40   Length: 0x5C3
    public void RefreshForceContributionInfoData()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
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
                      plVar3 = (int64 *)Component.GetComponent(lVar2,DAT_181d6d8c0);
                      if (this.nowShowHero != null) {
                        local_res8[0] = (int)this.nowShowHero.governContribution;
                        uVar4 = Int32.ToString(local_res8,0);
                        if (plVar3 != (int64 *)0) {
                          (**(code **)(*plVar3 + 0x5e8))(plVar3,uVar4,*(uint64 *)(*plVar3 + 0x5f0));
                          if (((*pStatics != 0) &&
                              (lVar2 = *(int64 *)(*pStatics + 32),
                              lVar2 != null)) && (lVar2 = *(int64 *)(lVar2 + 72)) != null) {
                            FUN_1817ff240(&local_48,lVar2,DAT_181d60878);
                            local_30 = local_48;
                            uStack_2c = uStack_44;
                            uStack_28 = uStack_40;
                            uStack_24 = uStack_3c;
                            local_20 = local_38;
                            while( true ) {
                              cVar1 = FUN_180d197a0(&local_30,DAT_181d66148);
                              lVar2 = local_20;
                              if (!cVar1) {
                                ZhSegment.Initialize(&local_30,DAT_181d660c8);
                                return;
                              }
                              if (this.heroDetailPanel == null) {
                          // WARNING: Subroutine does not return
                                FUN_1800d6620();
                              }
                              lVar5 = GameObject.get_transform(this.heroDetailPanel,0);
                              if (lVar5 == null) {
                          // WARNING: Subroutine does not return
                                FUN_1800d6620();
                              }
                              lVar5 = Transform.Find(lVar5,"ForceContribution",0);
                              if (lVar5 == null) {
                          // WARNING: Subroutine does not return
                                FUN_1800d6620();
                              }
                              lVar5 = Transform.Find(lVar5,"Viewport",0);
                              if (lVar5 == null) {
                          // WARNING: Subroutine does not return
                                FUN_1800d6620();
                              }
                              lVar5 = Transform.Find(lVar5,"Content",0);
                              if (lVar2 == null) {
                          // WARNING: Subroutine does not return
                                FUN_1800d6620();
                              }
                              uVar4 = Int32.ToString(lVar2 + 16,0);
                              if (lVar5 == null) {
                          // WARNING: Subroutine does not return
                                FUN_1800d6620();
                              }
                              lVar5 = Transform.Find(lVar5,uVar4,0);
                              if (lVar5 == null) {
                          // WARNING: Subroutine does not return
                                FUN_1800d6620();
                              }
                              lVar5 = Transform.Find(lVar5,"Num",0);
                              if (lVar5 == null) {
                          // WARNING: Subroutine does not return
                                FUN_1800d6620();
                              }
                              plVar3 = (int64 *)Component.GetComponent(lVar5,DAT_181d6d8c0);
                              lVar5 = this.nowShowHero;
                              if (lVar5 == null) {
                          // WARNING: Subroutine does not return
                                FUN_1800d6620();
                              }
                              if (lVar5.belongForceID == *(int *)(lVar2 + 16)) {
                                fVar7 = lVar5.forceContribution;
                              }
                              else {
                                fVar7 = *(float *)(lVar2 + 0x178);
                              }
                              local_res8[0] = (int)fVar7;
                              uVar4 = Int32.ToString(local_res8,0);
                              if (plVar3 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                                FUN_1800d6620();
                              }
                              (**(code **)(*plVar3 + 0x5e8))
                                        (plVar3,uVar4,*(uint64 *)(*plVar3 + 0x5f0));
                              if (this.heroDetailPanel == null) {
                          // WARNING: Subroutine does not return
                                FUN_1800d6620();
                              }
                              lVar5 = GameObject.get_transform(this.heroDetailPanel,0);
                              if (lVar5 == null) {
                          // WARNING: Subroutine does not return
                                FUN_1800d6620();
                              }
                              lVar5 = Transform.Find(lVar5,"ForceContribution",0);
                              if (lVar5 == null) {
                          // WARNING: Subroutine does not return
                                FUN_1800d6620();
                              }
                              lVar5 = Transform.Find(lVar5,"Viewport",0);
                              if (lVar5 == null) {
                          // WARNING: Subroutine does not return
                                FUN_1800d6620();
                              }
                              lVar5 = Transform.Find(lVar5,"Content",0);
                              uVar4 = Int32.ToString(lVar2 + 16,0);
                              if (lVar5 == null) {
                          // WARNING: Subroutine does not return
                                FUN_1800d6620();
                              }
                              lVar5 = Transform.Find(lVar5,uVar4,0);
                              if (lVar5 == null) break;
                              lVar5 = Transform.Find(lVar5,"ForceName",0);
                              if (lVar5 == null) {
                          // WARNING: Subroutine does not return
                                FUN_1800d6620();
                              }
                              plVar3 = (int64 *)Component.GetComponent(lVar5,DAT_181d6d8c0);
                              if (this.nowShowHero == null) {
                          // WARNING: Subroutine does not return
                                FUN_1800d6620();
                              }
                              if (this.nowShowHero.belongForceID == *(int *)(lVar2 + 16)
                                 ) {
                                lVar2 = *(int64 *)(DAT_181d4ef00 + 184);
                                uVar8 = *(uint32 *)(lVar2 + 0x290);
                                uVar9 = *(uint32 *)(lVar2 + 0x294);
                                uVar10 = *(uint32 *)(lVar2 + 0x298);
                                uVar11 = *(uint32 *)(lVar2 + 0x29c);
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
                                FUN_1800d6620();
                              }
                              local_58 = uVar8;
                              uStack_54 = uVar9;
                              uStack_50 = uVar10;
                              uStack_4c = uVar11;
                              (**(code **)(*plVar3 + 0x2a8))(plVar3,&local_58);
                            }
                          // WARNING: Subroutine does not return
                            FUN_1800d6620();
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

    // Token : 0x6001744
    // RVA   : 0xEBD2A0   Offset: 0xEBBAA0   Length: 0xF9C
    public void RefreshFightData()
    {
        var pStatics = *(int64*)(DAT_181d4ef00 + 184);
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
              uVar7 = DAT_181d95510;
              uVar7 = Type.GetTypeFromHandle(uVar7,0);
              lVar6 = Enum.GetNames(uVar7,0);
              if (lVar6 == null) break;
              if (*(int *)(lVar6 + 24) <= iVar5) goto LAB_180ebd641;
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
        LAB_180ebd641:
            uVar7 = DAT_181d95510;
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
              lVar6 = GameObject.GetComponent(this.temp,DAT_181d9f900);
              if (lVar6 == null) throw; // [null/range check failed]
              *(uint64 *)(lVar6 + 32) = this.nowShowHero;
              if ((this.temp == null) || (lVar6 = GameObject.GetComponent()) == null
                 ) throw; // [null/range check failed]
              HeroBaseFightDataController.RefreshData(lVar6);
              iVar11 = iVar11 + 1;
              goto LAB_180ebd641;
            }
            local_res20 = 0;
            if ((((this.nowShowHero == null) ||
                 (lVar6 = this.nowShowHero.totalAddData) == null) ||
                (lVar6 = *(int64 *)(lVar6 + 16)) == null) ||
               (lVar6 = Dictionary_2.get_Keys(lVar6,DAT_181d98b10)) == null) throw; // [null/range check failed]
            FUN_180ed4d30(&local_78,lVar6,DAT_181d9c570);
            local_90 = CONCAT44(uStack_74,local_78);
            uStack_88 = CONCAT44(uStack_6c,uStack_70);
            local_80 = local_68;
            while (cVar3 = FUN_1811d8280(&local_90,DAT_181d74c38), uVar2 = local_80, cVar3) {
              if (((int)local_80 - 0xfU < 9) || (77 < (int)local_80)) {
                if (this.heroDetailPanel == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                lVar6 = GameObject.get_transform(this.heroDetailPanel,0);
                if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                lVar6 = Transform.Find(lVar6,"DetailInfo",0);
                if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                lVar6 = Transform.Find(lVar6,"Viewport",0);
                if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                lVar6 = Transform.Find(lVar6,"Content",0);
                if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                lVar6 = Transform.Find(lVar6,"ExtraFightData",0);
                if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                iVar5 = Transform.get_childCount(lVar6,0);
                lVar6 = this.heroDetailPanel;
                if (iVar12 < iVar5) {
                  if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  lVar6 = GameObject.get_transform(lVar6,0);
                  if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  lVar6 = Transform.Find(lVar6,"DetailInfo",0);
                  if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  lVar6 = Transform.Find(lVar6,"Viewport",0);
                  if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  lVar6 = Transform.Find(lVar6,"Content",0);
                  if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  lVar6 = Transform.Find(lVar6,"ExtraFightData",0);
                  if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  lVar6 = Transform.GetChild(lVar6,iVar12,0);
                  if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  uVar7 = Component.get_gameObject(lVar6,0);
                  this.temp = uVar7;
                }
                else {
                  if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  lVar6 = GameObject.get_transform(lVar6,0);
                  if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  lVar6 = Transform.Find(lVar6,"DetailInfo",0);
                  if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  lVar6 = Transform.Find(lVar6,"Viewport",0);
                  if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  lVar6 = Transform.Find(lVar6,"Content",0);
                  if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  lVar6 = Transform.Find(lVar6,"ExtraFightData",0);
                  if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  uVar8 = Component.get_gameObject(lVar6,0);
                  uVar7 = this.heroExtraFightDataPrefab;
                  uVar7 = GlobalData.AddChild(uVar8,uVar7,0);
                  this.temp = uVar7;
                }
                if (this.temp == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                lVar6 = GameObject.get_transform(this.temp,0);
                if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                lVar6 = Transform.Find(lVar6,"Text",0);
                if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                uVar7 = Component.GetComponent(lVar6,DAT_181d6d8c0);
                if (this.nowShowHero == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                lVar6 = this.nowShowHero.totalAddData;
                if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                lVar6 = *(int64 *)(lVar6 + 16);
                if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                fVar13 = (float)FUN_1817cc640(lVar6,uVar2 & 0xffffffff,DAT_181d98a88);
                if (fVar13 <= 0.0) {
                  uVar8 = *(uint64 *)(pStatics + 0x2c8);
                }
                else {
                  uVar8 = *(uint64 *)(pStatics + 0x260);
                }
                lVar6 = *(int64 *)(*(int64 *)(DAT_181d4e010 + 184) + 32);
                if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                lVar6 = *(int64 *)(lVar6 + 144);
                if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                lVar6 = FUN_180002f80(lVar6,uVar2 & 0xffffffff,DAT_181d64878);
                if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                uVar1 = *(uint64 *)(lVar6 + 16);
                lVar6 = FUN_18046c100(0);
                if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                if (*(int64 *)(lVar6 + 144) == 0) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                lVar6 = FUN_180002f80(*(int64 *)(lVar6 + 144),uVar2 & 0xffffffff,DAT_181d64878);
                if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                lVar10 = this.nowShowHero;
                if (*(char *)(lVar6 + 56) == false) {
                  if (lVar10 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  if (lVar10.totalAddData == null) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  lVar6 = *(int64 *)(lVar10.totalAddData + 16);
                  if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  local_res18[0] = (float)FUN_1817cc640(lVar6,uVar2 & 0xffffffff,DAT_181d98a88);
                  uVar9 = Single.ToString(local_res18,"+0.##;-0.##;0",0);
                }
                else {
                  if (lVar10 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  if (lVar10.totalAddData == null) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  lVar6 = *(int64 *)(lVar10.totalAddData + 16);
                  if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  local_res18[0] = (float)FUN_1817cc640(lVar6,uVar2 & 0xffffffff,DAT_181d98a88);
                  local_res18[0] = local_res18[0] * 100.0;
                  uVar9 = Single.ToString(local_res18,"+0.##;-0.##;0",0);
                  uVar9 = String.Concat(uVar9,"%",0);
                }
                uVar8 = String.Concat(uVar8,uVar1,uVar9,"</color>",0);
                LTLocalization.SetText(uVar7,uVar8,0);
                lVar6 = FUN_18046c100(0);
                if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                if (*(int64 *)(lVar6 + 144) == 0) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                lVar6 = FUN_180002f80(*(int64 *)(lVar6 + 144),uVar2 & 0xffffffff);
                if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                lVar10 = this.temp;
                if (*(char *)(lVar6 + 89) == false) {
                  if (lVar10 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  lVar6 = GameObject.GetComponent(lVar10,DAT_181da12b0);
                  if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  *(uint64 *)(lVar6 + 24) = "";
                  local_res20 = iVar12 + 1;
                  iVar12 = local_res20;
                }
                else {
                  if (lVar10 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  lVar6 = GameObject.GetComponent(lVar10,DAT_181da12b0);
                  lVar10 = FUN_18046c100(0);
                  if (lVar10 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  if (lVar10.forceJobType == null) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  lVar10 = FUN_180002f80(lVar10.forceJobType,uVar2 & 0xffffffff);
                  if (lVar10 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  uVar7 = HeroSpeAddDataBase.GetDescribe(lVar10,0);
                  if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
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
            ZhSegment.Initialize(&local_90,DAT_181d74bb8);
            if ((iVar5 != 0) && (aiStack_ac[iVar5] == 0x414)) goto LAB_180ebe093;
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
        LAB_180ebe093:
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

    // Token : 0x6001745
    // RVA   : 0xEBFF40   Offset: 0xEBE740   Length: 0x208B
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
        if (this.nowShowHero == null) goto LAB_180ec1fc6;
        lVar4 = this.heroDetailPanel;
        if (this.nowShowHero.internalSkill == null) {
          if (((((lVar4 == null) ||
                (lVar4 = GameObject.get_transform(lVar4,0), fVar1 = local_60) == null) ||
               (lVar4 = Transform.Find(lVar4,"Skill",0), fVar1 = local_60) == null) ||
              ((lVar4 = Transform.Find(lVar4,"SkillSlot0",0), fVar1 = local_60, lVar4 == null ||
               (lVar4 = Transform.Find(lVar4,"NowEquipment",0), fVar1 = local_60) == null))) ||
             (lVar4 = Component.get_gameObject(lVar4,0), fVar1 = local_60) == null)
          goto LAB_180ec1fc6;
          cVar2 = GameObject.get_activeSelf(lVar4,0);
          if (cVar2) {
            fVar1 = local_60;
            if (((this.heroDetailPanel == null) ||
                (lVar4 = GameObject.get_transform(this.heroDetailPanel,0), fVar1 = local_60,
                lVar4 == null)) ||
               ((lVar4 = Transform.Find(lVar4,"Skill",0), fVar1 = local_60, lVar4 == null ||
                ((lVar4 = Transform.Find(lVar4,"SkillSlot0",0), fVar1 = local_60, lVar4 == null ||
                 (lVar4 = Transform.Find(lVar4,"NowEquipment",0), fVar1 = local_60) == null)))))
            goto LAB_180ec1fc6;
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
          goto LAB_180ec1fc6;
          cVar2 = GameObject.get_activeSelf(lVar4,0);
          if (!cVar2) {
            fVar1 = local_60;
            if (((this.heroDetailPanel == null) ||
                (lVar4 = GameObject.get_transform(this.heroDetailPanel,0), fVar1 = local_60,
                lVar4 == null)) ||
               ((lVar4 = Transform.Find(lVar4,"Skill",0), fVar1 = local_60, lVar4 == null ||
                ((lVar4 = Transform.Find(lVar4,"SkillSlot0",0), fVar1 = local_60, lVar4 == null ||
                 (lVar4 = Transform.Find(lVar4,"NowEquipment",0), fVar1 = local_60) == null)))))
            goto LAB_180ec1fc6;
            uVar5 = Component.get_gameObject(lVar4,0);
            HeroDetailController.ShowEquipIcon(this,uVar5,resetPos,0);
          }
          fVar1 = local_60;
          if ((((this.heroDetailPanel == null) ||
               (lVar4 = GameObject.get_transform(this.heroDetailPanel,0), fVar1 = local_60,
               lVar4 == null)) ||
              (lVar4 = Transform.Find(lVar4,"Skill",0), fVar1 = local_60) == null) ||
             (lVar4 = Transform.Find(lVar4,"SkillSlot0",0), fVar1 = local_60) == null)
          goto LAB_180ec1fc6;
          lVar4 = Transform.Find(lVar4,"NowEquipment",0);
          puVar6 = (uint64 *)Vector3.get_one(&local_48,0);
          local_68 = *puVar6;
          local_60 = *(float *)(puVar6 + 1) * 1.2;
          local_78 = CONCAT44((float)((uint64)local_68 >> 32) * 1.2,(float)local_68 * 1.2);
          fVar1 = *(float *)(puVar6 + 1);
          if (lVar4 == null) goto LAB_180ec1fc6;
          local_68 = local_78;
          Transform.set_localScale(lVar4,&local_68,0);
          fVar1 = local_60;
          if (((this.heroDetailPanel == null) ||
              (lVar4 = GameObject.get_transform(this.heroDetailPanel,0), fVar1 = local_60,
              lVar4 == null)) ||
             ((lVar4 = Transform.Find(lVar4,"Skill",0), fVar1 = local_60, lVar4 == null ||
              ((lVar4 = Transform.Find(lVar4,"SkillSlot0",0), fVar1 = local_60, lVar4 == null ||
               (lVar4 = Transform.Find(lVar4,"NowEquipment",0), fVar1 = local_60) == null)))))
          goto LAB_180ec1fc6;
          lVar4 = Component.GetComponent(lVar4,DAT_181d6d240);
          fVar1 = local_60;
          if ((this.nowShowHero == null) || (lVar4 == null)) goto LAB_180ec1fc6;
          lVar4.summonControlable = this.nowShowHero.internalSkill;
          fVar1 = local_60;
          if ((((this.heroDetailPanel == null) ||
               (lVar4 = GameObject.get_transform(this.heroDetailPanel,0), fVar1 = local_60,
               lVar4 == null)) ||
              (lVar4 = Transform.Find(lVar4,"Skill",0), fVar1 = local_60) == null) ||
             (((lVar4 = Transform.Find(lVar4,"SkillSlot0",0), fVar1 = local_60, lVar4 == null ||
               (lVar4 = Transform.Find(lVar4,"NowEquipment",0), fVar1 = local_60) == null) ||
              (lVar4 = Component.GetComponent(lVar4,DAT_181d6d240), fVar1 = local_60) == null)))
          goto LAB_180ec1fc6;
          *(uint8 *)(lVar4 + 44) = 0;
          if (((this.heroDetailPanel == null) ||
              (lVar4 = GameObject.get_transform(this.heroDetailPanel,0), fVar1 = local_60,
              lVar4 == null)) ||
             ((lVar4 = Transform.Find(lVar4,"Skill",0), fVar1 = local_60, lVar4 == null ||
              (((lVar4 = Transform.Find(lVar4,"SkillSlot0",0), fVar1 = local_60, lVar4 == null ||
                (lVar4 = Transform.Find(lVar4,"NowEquipment",0), fVar1 = local_60) == null) ||
               (lVar4 = Component.GetComponent(lVar4,DAT_181d6d240), fVar1 = local_60) == null)))))
          goto LAB_180ec1fc6;
          lVar4.summonSourceHero = 1;
          if ((((this.heroDetailPanel == null) ||
               (lVar4 = GameObject.get_transform(this.heroDetailPanel,0), fVar1 = local_60,
               lVar4 == null)) ||
              (lVar4 = Transform.Find(lVar4,"Skill",0), fVar1 = local_60) == null) ||
             ((lVar4 = Transform.Find(lVar4,"SkillSlot0",0), fVar1 = local_60, lVar4 == null ||
              (lVar4 = Transform.Find(lVar4,"NowEquipment",0), fVar1 = local_60) == null)))
          goto LAB_180ec1fc6;
          lVar4 = Component.GetComponent(lVar4,DAT_181d6af40);
          fVar1 = local_60;
          if (this.nowShowHero == null) goto LAB_180ec1fc6;
          cVar2 = HeroData.ItemControlable(this.nowShowHero,0);
          uVar3 = 1;
          if (!cVar2) {
            uVar3 = this.itemSpeControlable;
          }
          fVar1 = local_60;
          if (lVar4 == null) goto LAB_180ec1fc6;
          Selectable.set_interactable(lVar4,uVar3,0);
        }
        fVar1 = local_60;
        if (this.nowShowHero == null) goto LAB_180ec1fc6;
        lVar4 = this.heroDetailPanel;
        if (this.nowShowHero.dodgeSkill == null) {
          if ((((lVar4 == null) || (lVar4 = GameObject.get_transform(lVar4,0), fVar1 = local_60) == null
               ) || (lVar4 = Transform.Find(lVar4,"Skill",0), fVar1 = local_60) == null) ||
             (((lVar4 = Transform.Find(lVar4,"SkillSlot1",0), fVar1 = local_60, lVar4 == null ||
               (lVar4 = Transform.Find(lVar4,"NowEquipment",0), fVar1 = local_60) == null) ||
              (lVar4 = Component.get_gameObject(lVar4,0), fVar1 = local_60) == null)))
          goto LAB_180ec1fc6;
          cVar2 = GameObject.get_activeSelf(lVar4,0);
          if (cVar2) {
            fVar1 = local_60;
            if (((this.heroDetailPanel == null) ||
                (lVar4 = GameObject.get_transform(this.heroDetailPanel,0), fVar1 = local_60,
                lVar4 == null)) ||
               ((lVar4 = Transform.Find(lVar4,"Skill",0), fVar1 = local_60, lVar4 == null ||
                ((lVar4 = Transform.Find(lVar4,"SkillSlot1",0), fVar1 = local_60, lVar4 == null ||
                 (lVar4 = Transform.Find(lVar4,"NowEquipment",0), fVar1 = local_60) == null)))))
            goto LAB_180ec1fc6;
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
          goto LAB_180ec1fc6;
          cVar2 = GameObject.get_activeSelf(lVar4,0);
          if (!cVar2) {
            fVar1 = local_60;
            if (((this.heroDetailPanel == null) ||
                (lVar4 = GameObject.get_transform(this.heroDetailPanel,0), fVar1 = local_60,
                lVar4 == null)) ||
               ((lVar4 = Transform.Find(lVar4,"Skill",0), fVar1 = local_60, lVar4 == null ||
                ((lVar4 = Transform.Find(lVar4,"SkillSlot1",0), fVar1 = local_60, lVar4 == null ||
                 (lVar4 = Transform.Find(lVar4,"NowEquipment",0), fVar1 = local_60) == null)))))
            goto LAB_180ec1fc6;
            uVar5 = Component.get_gameObject(lVar4,0);
            HeroDetailController.ShowEquipIcon(this,uVar5,resetPos,0);
          }
          fVar1 = local_60;
          if ((((this.heroDetailPanel == null) ||
               (lVar4 = GameObject.get_transform(this.heroDetailPanel,0), fVar1 = local_60,
               lVar4 == null)) ||
              (lVar4 = Transform.Find(lVar4,"Skill",0), fVar1 = local_60) == null) ||
             (lVar4 = Transform.Find(lVar4,"SkillSlot1",0), fVar1 = local_60) == null)
          goto LAB_180ec1fc6;
          lVar4 = Transform.Find(lVar4,"NowEquipment",0);
          puVar6 = (uint64 *)Vector3.get_one(&local_48,0);
          local_68 = *puVar6;
          local_60 = *(float *)(puVar6 + 1) * 1.1;
          local_78 = CONCAT44((float)((uint64)local_68 >> 32) * 1.1,(float)local_68 * 1.1);
          fVar1 = *(float *)(puVar6 + 1);
          if (lVar4 == null) goto LAB_180ec1fc6;
          local_68 = local_78;
          Transform.set_localScale(lVar4,&local_68,0);
          fVar1 = local_60;
          if (((this.heroDetailPanel == null) ||
              (lVar4 = GameObject.get_transform(this.heroDetailPanel,0), fVar1 = local_60,
              lVar4 == null)) ||
             ((lVar4 = Transform.Find(lVar4,"Skill",0), fVar1 = local_60, lVar4 == null ||
              ((lVar4 = Transform.Find(lVar4,"SkillSlot1",0), fVar1 = local_60, lVar4 == null ||
               (lVar4 = Transform.Find(lVar4,"NowEquipment",0), fVar1 = local_60) == null)))))
          goto LAB_180ec1fc6;
          lVar4 = Component.GetComponent(lVar4,DAT_181d6d240);
          fVar1 = local_60;
          if ((this.nowShowHero == null) || (lVar4 == null)) goto LAB_180ec1fc6;
          lVar4.summonControlable = this.nowShowHero.dodgeSkill;
          fVar1 = local_60;
          if (((((this.heroDetailPanel == null) ||
                (lVar4 = GameObject.get_transform(this.heroDetailPanel,0), fVar1 = local_60,
                lVar4 == null)) ||
               (lVar4 = Transform.Find(lVar4,"Skill",0), fVar1 = local_60) == null) ||
              ((lVar4 = Transform.Find(lVar4,"SkillSlot1",0), fVar1 = local_60, lVar4 == null ||
               (lVar4 = Transform.Find(lVar4,"NowEquipment",0), fVar1 = local_60) == null))) ||
             (lVar4 = Component.GetComponent(lVar4,DAT_181d6d240), fVar1 = local_60) == null)
          goto LAB_180ec1fc6;
          *(uint8 *)(lVar4 + 44) = 0;
          if (((this.heroDetailPanel == null) ||
              (lVar4 = GameObject.get_transform(this.heroDetailPanel,0), fVar1 = local_60,
              lVar4 == null)) ||
             ((lVar4 = Transform.Find(lVar4,"Skill",0), fVar1 = local_60, lVar4 == null ||
              (((lVar4 = Transform.Find(lVar4,"SkillSlot1",0), fVar1 = local_60, lVar4 == null ||
                (lVar4 = Transform.Find(lVar4,"NowEquipment",0), fVar1 = local_60) == null) ||
               (lVar4 = Component.GetComponent(lVar4,DAT_181d6d240), fVar1 = local_60) == null)))))
          goto LAB_180ec1fc6;
          lVar4.summonSourceHero = 1;
          if (((this.heroDetailPanel == null) ||
              (lVar4 = GameObject.get_transform(this.heroDetailPanel,0), fVar1 = local_60,
              lVar4 == null)) ||
             ((lVar4 = Transform.Find(lVar4,"Skill",0), fVar1 = local_60, lVar4 == null ||
              ((lVar4 = Transform.Find(lVar4,"SkillSlot1",0), fVar1 = local_60, lVar4 == null ||
               (lVar4 = Transform.Find(lVar4,"NowEquipment",0), fVar1 = local_60) == null)))))
          goto LAB_180ec1fc6;
          lVar4 = Component.GetComponent(lVar4,DAT_181d6af40);
          fVar1 = local_60;
          if (this.nowShowHero == null) goto LAB_180ec1fc6;
          cVar2 = HeroData.ItemControlable(this.nowShowHero,0);
          uVar3 = 1;
          if (!cVar2) {
            uVar3 = this.itemSpeControlable;
          }
          fVar1 = local_60;
          if (lVar4 == null) goto LAB_180ec1fc6;
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
                goto LAB_180ec1fc6;
                uVar5 = Component.get_gameObject(lVar4,0);
                HeroDetailController.UnshowEquipIcon(this,uVar5,resetPos,0);
              }
        LAB_180ec1163:
              lVar4 = this.nowShowHero;
              if (lVar4 != null) {
                while (lVar4.attackSkills != null) {
                  if (*(int *)(lVar4.attackSkills + 24) <= iVar10) {
                    return;
                  }
                  fVar1 = local_60;
                  if (lVar4 == null) goto LAB_180ec1fc6;
                  cVar2 = HeroData.AttackSkillSlotUnlocked(lVar4,iVar10,0);
                  lVar4 = this.heroDetailPanel;
                  fVar1 = local_60;
                  if (!cVar2) {
                    if ((lVar4 == null) ||
                       (lVar4 = GameObject.get_transform(lVar4,0), fVar1 = local_60) == null)
                    goto LAB_180ec1fc6;
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
                    goto LAB_180ec1fc6;
                    cVar2 = GameObject.get_activeSelf(lVar4,0);
                    if (!cVar2) {
                      fVar1 = local_60;
                      if ((this.heroDetailPanel == null) ||
                         (lVar4 = GameObject.get_transform(this.heroDetailPanel,0),
                         fVar1 = local_60, lVar4 == null)) goto LAB_180ec1fc6;
                      lVar4 = Transform.Find(lVar4,"Skill",0);
                      local_res8[0] = iVar9;
                      uVar5 = Int32.ToString(local_res8,0);
                      uVar5 = String.Concat("SkillSlot",uVar5,0);
                      fVar1 = local_60;
                      if ((lVar4 == null) ||
                         ((lVar4 = Transform.Find(lVar4,uVar5,0), fVar1 = local_60, lVar4 == null ||
                          (lVar4 = Transform.Find(lVar4,"Lock",0), fVar1 = local_60) == null))
                         ) goto LAB_180ec1fc6;
                      lVar4 = Component.get_gameObject(lVar4,0);
                      fVar1 = local_60;
                      if (lVar4 == null) goto LAB_180ec1fc6;
                      GameObject.SetActive(lVar4,1,0);
                    }
                    fVar1 = local_60;
                    if ((this.heroDetailPanel == null) ||
                       (lVar4 = GameObject.get_transform(this.heroDetailPanel,0),
                       fVar1 = local_60, lVar4 == null)) goto LAB_180ec1fc6;
                    lVar4 = Transform.Find(lVar4,"Skill",0);
                    local_res8[0] = iVar9;
                    uVar5 = Int32.ToString(local_res8,0);
                    uVar5 = String.Concat("SkillSlot",uVar5,0);
                    fVar1 = local_60;
                    if ((lVar4 == null) ||
                       (((lVar4 = Transform.Find(lVar4,uVar5,0), fVar1 = local_60, lVar4 == null ||
                         (lVar4 = Transform.Find(lVar4,"Text",0), fVar1 = local_60) == null)
                        || (lVar4 = Component.get_gameObject(lVar4,0), fVar1 = local_60) == null)))
                    goto LAB_180ec1fc6;
                    cVar2 = GameObject.get_activeSelf(lVar4,0);
                    if (cVar2) {
                      fVar1 = local_60;
                      if ((this.heroDetailPanel == null) ||
                         (lVar4 = GameObject.get_transform(this.heroDetailPanel,0),
                         fVar1 = local_60, lVar4 == null)) goto LAB_180ec1fc6;
                      lVar4 = Transform.Find(lVar4,"Skill",0);
                      local_res8[0] = iVar9;
                      uVar5 = Int32.ToString(local_res8,0);
                      uVar5 = String.Concat("SkillSlot",uVar5,0);
                      fVar1 = local_60;
                      if (((lVar4 == null) ||
                          ((lVar4 = Transform.Find(lVar4,uVar5,0), fVar1 = local_60, lVar4 == null ||
                           (lVar4 = Transform.Find(lVar4,"Text",0), fVar1 = local_60) == null)
                          )) || (lVar4 = Component.get_gameObject(lVar4,0), fVar1 = local_60) == null
                         ) goto LAB_180ec1fc6;
                      GameObject.SetActive(lVar4,0,0);
                    }
                    fVar1 = local_60;
                    if ((this.heroDetailPanel == null) ||
                       (lVar4 = GameObject.get_transform(this.heroDetailPanel,0),
                       fVar1 = local_60, lVar4 == null)) goto LAB_180ec1fc6;
                    lVar4 = Transform.Find(lVar4,"Skill",0);
                    local_res8[0] = iVar9;
                    uVar5 = Int32.ToString(local_res8,0);
                    uVar5 = String.Concat("SkillSlot",uVar5,0);
                    fVar1 = local_60;
                    if ((lVar4 == null) ||
                       (((lVar4 = Transform.Find(lVar4,uVar5,0), fVar1 = local_60, lVar4 == null ||
                         (lVar4 = Transform.Find(lVar4,"Lock",0), fVar1 = local_60) == null)
                        || (lVar4 = Transform.Find(lVar4,"Light",0), fVar1 = local_60) == null)
                       )) goto LAB_180ec1fc6;
                    plVar7 = (int64 *)Component.GetComponent(lVar4,DAT_181d6bc40);
                    lVar4 = FUN_18046c100(0);
                    fVar1 = local_60;
                    if (((lVar4 == null) || (lVar4.dailyAIManaged == null)) ||
                       ((lVar4 = FUN_180002f80(lVar4.dailyAIManaged,iVar10 + -2,DAT_181d76758),
                        fVar1 = local_60, lVar4 == null || (plVar7 == (int64 *)0)))) goto LAB_180ec1fc6;
                    local_48 = lVar4.summonLv;
                    uStack_44 = lVar4.summonMoveRange;
                    uStack_40 = lVar4.summonControlable;
                    uStack_3c = *(uint32 *)(lVar4 + 36);
                    (**(code **)(*plVar7 + 0x2a8))(plVar7,&local_48,*(uint64 *)(*plVar7 + 0x2b0));
                    fVar1 = local_60;
                    if ((this.heroDetailPanel == null) ||
                       (lVar4 = GameObject.get_transform(this.heroDetailPanel,0),
                       fVar1 = local_60, lVar4 == null)) goto LAB_180ec1fc6;
                    lVar4 = Transform.Find(lVar4,"Skill",0);
                    local_res8[0] = iVar9;
                    uVar5 = Int32.ToString(local_res8,0);
                    uVar5 = String.Concat("SkillSlot",uVar5,0);
                    fVar1 = local_60;
                    if ((lVar4 == null) ||
                       ((lVar4 = Transform.Find(lVar4,uVar5,0), fVar1 = local_60, lVar4 == null ||
                        (lVar4 = Transform.Find(lVar4,"Lock",0), fVar1 = local_60) == null)))
                    goto LAB_180ec1fc6;
                    lVar4 = Component.GetComponent(lVar4,DAT_181d6ccc0);
                    lVar8 = *(int64 *)(*(int64 *)(DAT_181d4ef00 + 184) + 0x4f0);
                    if (lVar8 == null) break;
                    uVar5 = FUN_180002f80(lVar8,iVar10 + -2,DAT_181d7c9c0);
                    uVar5 = GlobalData.GenerateRareLvColorText(uVar5,iVar10 + -2,0);
                    uVar5 = String.Format("习得{0}武功后解锁",uVar5,0);
                    if (lVar4 == null) break;
                    lVar4.summonLv = uVar5;
                  }
                  else {
                    if ((lVar4 == null) ||
                       (lVar4 = GameObject.get_transform(lVar4,0), fVar1 = local_60) == null)
                    goto LAB_180ec1fc6;
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
                    goto LAB_180ec1fc6;
                    cVar2 = GameObject.get_activeSelf(lVar4,0);
                    if (cVar2) {
                      fVar1 = local_60;
                      if ((this.heroDetailPanel == null) ||
                         (lVar4 = GameObject.get_transform(this.heroDetailPanel,0),
                         fVar1 = local_60, lVar4 == null)) goto LAB_180ec1fc6;
                      lVar4 = Transform.Find(lVar4,"Skill",0);
                      local_res8[0] = iVar9;
                      uVar5 = Int32.ToString(local_res8,0);
                      uVar5 = String.Concat("SkillSlot",uVar5,0);
                      fVar1 = local_60;
                      if (((lVar4 == null) ||
                          ((lVar4 = Transform.Find(lVar4,uVar5,0), fVar1 = local_60, lVar4 == null ||
                           (lVar4 = Transform.Find(lVar4,"Lock",0), fVar1 = local_60) == null)
                          )) || (lVar4 = Component.get_gameObject(lVar4,0), fVar1 = local_60) == null
                         ) goto LAB_180ec1fc6;
                      GameObject.SetActive(lVar4,0,0);
                    }
                    fVar1 = local_60;
                    if ((this.heroDetailPanel == null) ||
                       (lVar4 = GameObject.get_transform(this.heroDetailPanel,0),
                       fVar1 = local_60, lVar4 == null)) goto LAB_180ec1fc6;
                    lVar4 = Transform.Find(lVar4,"Skill",0);
                    local_res8[0] = iVar9;
                    uVar5 = Int32.ToString(local_res8,0);
                    uVar5 = String.Concat("SkillSlot",uVar5,0);
                    fVar1 = local_60;
                    if ((lVar4 == null) ||
                       (((lVar4 = Transform.Find(lVar4,uVar5,0), fVar1 = local_60, lVar4 == null ||
                         (lVar4 = Transform.Find(lVar4,"Text",0), fVar1 = local_60) == null)
                        || (lVar4 = Component.get_gameObject(lVar4,0), fVar1 = local_60) == null)))
                    goto LAB_180ec1fc6;
                    cVar2 = GameObject.get_activeSelf(lVar4,0);
                    if (!cVar2) {
                      fVar1 = local_60;
                      if ((this.heroDetailPanel == null) ||
                         (lVar4 = GameObject.get_transform(this.heroDetailPanel,0),
                         fVar1 = local_60, lVar4 == null)) goto LAB_180ec1fc6;
                      lVar4 = Transform.Find(lVar4,"Skill",0);
                      local_res8[0] = iVar9;
                      uVar5 = Int32.ToString(local_res8,0);
                      uVar5 = String.Concat("SkillSlot",uVar5,0);
                      fVar1 = local_60;
                      if ((lVar4 == null) ||
                         ((lVar4 = Transform.Find(lVar4,uVar5,0), fVar1 = local_60, lVar4 == null ||
                          (lVar4 = Transform.Find(lVar4,"Text",0), fVar1 = local_60) == null))
                         ) goto LAB_180ec1fc6;
                      lVar4 = Component.get_gameObject(lVar4,0);
                      fVar1 = local_60;
                      if (lVar4 == null) goto LAB_180ec1fc6;
                      GameObject.SetActive(lVar4,1,0);
                    }
                  }
                  iVar9 = iVar10 + 3;
                  if ((this.nowShowHero == null) ||
                     (lVar4 = this.nowShowHero.attackSkills) == null) break;
                  lVar8 = FUN_180002f80(lVar4,iVar10,DAT_181d6ade8);
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
                    lVar4 = Component.GetComponent(lVar4,DAT_181d6d240);
                    if ((this.nowShowHero == null) ||
                       ((lVar8 = this.nowShowHero.attackSkills, lVar8 == null ||
                        (uVar5 = FUN_180002f80(lVar8,iVar10,DAT_181d6ade8), lVar4 == null)))) break;
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
                       (lVar4 = Component.GetComponent(lVar4,DAT_181d6d240)) == null) break;
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
                        (lVar4 = Component.GetComponent(lVar4,DAT_181d6d240)) == null))) break;
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
                    lVar4 = Component.GetComponent(lVar4,DAT_181d6af40);
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
              FUN_1800d6620();
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
              goto LAB_180ec1fc6;
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
                  lVar4 = Component.GetComponent(lVar4,DAT_181d6d240);
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
                       (lVar4 = Component.GetComponent(lVar4,DAT_181d6d240), fVar1 = local_60, lVar4 != null
                       )) {
                      *(uint8 *)(lVar4 + 44) = 0;
                      if (((this.heroDetailPanel != null) &&
                          (lVar4 = GameObject.get_transform(this.heroDetailPanel,0),
                          fVar1 = local_60, lVar4 != null)) &&
                         ((lVar4 = Transform.Find(lVar4,"Skill",0), fVar1 = local_60, lVar4 != null &&
                          (((lVar4 = Transform.Find(lVar4,"SkillSlot2",0), fVar1 = local_60, lVar4 != null
                            && (lVar4 = Transform.Find(lVar4,"NowEquipment",0), fVar1 = local_60,
                               lVar4 != null)) &&
                           (lVar4 = Component.GetComponent(lVar4,DAT_181d6d240), fVar1 = local_60,
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
                          lVar4 = Component.GetComponent(lVar4,DAT_181d6af40);
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
                              goto LAB_180ec1163;
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
        LAB_180ec1fc6:
        local_60 = fVar1;
    }

    // Token : 0x6001746
    // RVA   : 0xEBCC90   Offset: 0xEBB490   Length: 0x608
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
        LAB_180ebcfc9:
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
             (lVar4 = Component.GetComponent(lVar4,DAT_181d6bdc0)) == null) throw; // [null/range check failed]
          if (*(int64 *)(lVar4 + 32) != targetItem) goto LAB_180ebcfc9;
        }
        if ((this.heroDetailPanel != null) &&
           (lVar4 = GameObject.get_transform(this.heroDetailPanel,0)) != null) {
          lVar4 = Transform.Find(lVar4,"Item",0);
          uVar5 = Int32.ToString(local_res10,0);
          uVar5 = String.Concat("EquipSlot",uVar5,0);
          if ((lVar4 != null) &&
             (((lVar4 = Transform.Find(lVar4,uVar5,0), lVar4 != null &&
               (lVar4 = Transform.Find(lVar4,"NowEquipment",0)) != null) &&
              (lVar4 = Component.GetComponent(lVar4,DAT_181d6bdc0)) != null))) {
            *(int64 *)(lVar4 + 32) = targetItem;
            if ((this.heroDetailPanel != null) &&
               (lVar4 = GameObject.get_transform(this.heroDetailPanel,0)) != null) {
              lVar4 = Transform.Find(lVar4,"Item",0);
              uVar5 = Int32.ToString(local_res10,0);
              uVar5 = String.Concat("EquipSlot",uVar5,0);
              if ((lVar4 != null) &&
                 (((lVar4 = Transform.Find(lVar4,uVar5,0), lVar4 != null &&
                   (lVar4 = Transform.Find(lVar4,"NowEquipment",0)) != null) &&
                  (lVar4 = Component.GetComponent(lVar4,DAT_181d6bdc0)) != null))) {
                *(uint8 *)(lVar4 + 52) = 0;
                if ((this.heroDetailPanel != null) &&
                   (lVar4 = GameObject.get_transform(this.heroDetailPanel,0)) != null) {
                  lVar4 = Transform.Find(lVar4,"Item",0);
                  uVar5 = Int32.ToString(local_res10,0);
                  uVar5 = String.Concat("EquipSlot",uVar5,0);
                  if ((lVar4 != null) &&
                     ((lVar4 = Transform.Find(lVar4,uVar5,0), lVar4 != null &&
                      (lVar4 = Transform.Find(lVar4,"NowEquipment",0)) != null))) {
                    lVar4 = Component.GetComponent(lVar4,DAT_181d6bdc0);
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

    // Token : 0x6001747
    // RVA   : 0xEBBDE0   Offset: 0xEBA5E0   Length: 0xEA4
    public void RefreshEquipList(bool resetPos)
    {
        var pStatics_e010 = *(int64*)(DAT_181d4e010 + 184);
        var pStatics_ef00 = *(int64*)(DAT_181d4ef00 + 184);
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
            (lVar7 = Component.GetComponent(lVar7,DAT_181d6ccc0)) != null))) {
          lVar7.summonLv = "<b>装备负重</b>";
          iVar14 = 0;
          while( true ) {
            lVar7 = *(int64 *)(pStatics_ef00 + 0x5d8);
            if (lVar7 == null) throw; // [null/range check failed]
            lVar3 = this.heroDetailPanel;
            if (lVar7.summonLv <= iVar14) break;
            if ((((lVar3 == null) || (lVar7 = GameObject.get_transform(lVar3,0)) == null) ||
                (lVar7 = Transform.Find(lVar7,"Item",0)) == null) ||
               ((lVar7 = Transform.Find(lVar7,"EquipmentWeight",0), lVar7 == null ||
                (lVar7 = Component.GetComponent(lVar7,DAT_181d6ccc0)) == null))) throw; // [null/range check failed]
            uVar12 = lVar7.summonLv;
            uVar11 = "\n{0}{1} 速度x{2}%";
            lVar3 = *(int64 *)(pStatics_ef00 + 0x5d8);
            if (lVar3 == null) throw; // [null/range check failed]
            uVar8 = "超重";
            if (iVar14 != *(int *)(lVar3 + 24) + -1) {
              lVar3 = *(int64 *)(pStatics_ef00 + 0x5d8);
              if (lVar3 == null) throw; // [null/range check failed]
              uVar8 = FUN_180002f80(lVar3,iVar14,DAT_181d7c9c0);
              uVar8 = String.Concat(uVar8,"装",0);
            }
            lVar3 = *(int64 *)(pStatics_ef00 + 0x5d8);
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
            lVar3 = *(int64 *)(pStatics_ef00 + 0x5e0);
            if (lVar3 == null) throw; // [null/range check failed]
            local_res8[0] = (float)FUN_1800d6780(lVar3,iVar14,DAT_181d796d8);
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
              (lVar7 = Component.GetComponent(lVar7,DAT_181d6ccc0)) != null))) {
            uVar12 = lVar7.summonLv;
            uVar11 = FUN_180004500(DAT_181d63120);
            uVar11 = String.Format("\n每超重1点速度-1%/闪避-1%",uVar11,0);
            uVar12 = String.Concat(uVar12,uVar11,0);
            *puVar1 = uVar12;
            il2cpp_internal(puVar1,uVar12);
            if (((this.heroDetailPanel != null) &&
                ((lVar7 = GameObject.get_transform(this.heroDetailPanel,0), lVar7 != null &&
                 (lVar7 = Transform.Find(lVar7,"Item",0)) != null))) &&
               (lVar7 = Transform.Find(lVar7,"EquipmentWeight",0)) != null) {
              uVar12 = Component.GetComponent(lVar7,DAT_181d6d8c0);
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
                                              *(uint64 *)(pStatics_ef00 + 0x2c0)
                                              ,0);
                      LTLocalization.SetText(uVar12,uVar11,0);
                      if ((((this.heroDetailPanel != null) &&
                           (lVar7 = GameObject.get_transform(this.heroDetailPanel,0), lVar7 != null
                           )) && (lVar7 = Transform.Find(lVar7,"Item",0)) != null) &&
                         ((lVar7 = Transform.Find(lVar7,"EquipmentWeight",0), lVar7 != null &&
                          (lVar7 = Transform.Find(lVar7,"Lv",0)) != null))) {
                        uVar12 = Component.GetComponent(lVar7,DAT_181d6d8c0);
                        lVar7 = *(int64 *)(pStatics_ef00 + 0x5d8);
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
                              plVar13 = (int64 *)Component.GetComponent(lVar7,DAT_181d6d8c0);
                              lVar7 = *(int64 *)(pStatics_e010 + 32);
                              if (lVar7 != null) {
                                lVar7 = lVar7.dailyAIManaged;
                                lVar3 = *(int64 *)(pStatics_e010 + 32);
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
                                        lVar7 = Component.GetComponent(lVar7,DAT_181d6ccc0);
                                        if (this.nowShowHero != null) {
                                          iVar14 = HeroData.GetEquipmentWeightLv
                                                             (this.nowShowHero,0);
                                          uVar12 = "<b>{0}</b>\n速度x{1}%";
                                          lVar3 = *(int64 *)
                                                   (pStatics_ef00 + 0x5d8);
                                          if (lVar3 != null) {
                                            uVar11 = "超重";
                                            if (iVar14 != *(int *)(lVar3 + 24) + -1) {
                                              lVar3 = *(int64 *)
                                                       (pStatics_ef00 + 0x5d8);
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
                                                     (pStatics_ef00 + 0x5e0);
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

    // Token : 0x6001748
    // RVA   : 0xEC4130   Offset: 0xEC2930   Length: 0x2F0
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
                   (lVar2 = GameObject.GetComponent(*(int64 *)(lVar1 + 16),DAT_181d9f080),
                   lVar2 != null)) {
                  CanvasGroup.set_alpha(lVar2,0x3f800000,0);
                  lVar2 = *(int64 *)(lVar1 + 16);
                  if (!resetPos) {
                    if ((lVar2 != null) &&
                       (lVar2 = GameObject.GetComponent(lVar2,DAT_181d9ee60)) != null) {
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
                              uVar5 = TweenSettingsExtensions.SetEase(uVar5,9,DAT_181d97ca8);
                              uVar6 = new OnTooltipCB(lVar1,DAT_181d7c870,0);
                              TweenSettingsExtensions.OnComplete(uVar5,uVar6,DAT_181d96ee8);
                              return;
                            }
                          }
                        }
                      }
                    }
                  }
                  else if ((lVar2 != null) &&
                          (lVar1 = GameObject.GetComponent(lVar2,DAT_181d9ee60)) != null) {
                    Selectable.set_interactable(lVar1,1,0);
                    return;
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6001749
    // RVA   : 0xEC55A0   Offset: 0xEC3DA0   Length: 0x1DE
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
              uVar2 = GameObject.GetComponent(lVar3,DAT_181d9f080);
              uVar2 = DOTweenModuleUI.DOFade(uVar2,0,0x3e800000,0);
              TweenSettingsExtensions.SetEase(uVar2,8,DAT_181d97b10);
              if ((*(int64 *)(lVar1 + 16) != 0) &&
                 (lVar3 = GameObject.GetComponent(*(int64 *)(lVar1 + 16),DAT_181d9ee60)) != null
                 ) {
                Selectable.set_interactable(lVar3,0,0);
                if (*(int64 *)(lVar1 + 16) != 0) {
                  uVar2 = GameObject.get_transform(*(int64 *)(lVar1 + 16),0);
                  uVar2 = ShortcutExtensions.DOScale(uVar2,0x3fc00000,0x3e800000,0);
                  uVar2 = TweenSettingsExtensions.SetEase(uVar2,8,DAT_181d97ca8);
                  uVar4 = new OnTooltipCB(lVar1,DAT_181d7c8f0,0);
                  TweenSettingsExtensions.OnComplete(uVar2,uVar4,DAT_181d96ee8);
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

    // Token : 0x600174A
    // RVA   : 0xEC1FD0   Offset: 0xEC07D0   Length: 0x724
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
        LAB_180ec26ef:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        iVar3 = Transform.get_childCount(lVar5,0);
        joined_r0x000180ec2094:
        iVar3 = iVar3 + -1;
        if (-1 < iVar3) {
          if (((this.skillGrid != null) &&
              (lVar5 = GameObject.get_transform(this.skillGrid,0)) != null) &&
             (lVar5 = Transform.GetChild(lVar5,iVar3,0)) != null) {
            uVar6 = Component.GetComponent(lVar5,DAT_181d6d240);
            cVar2 = Object.op_Equality(uVar6,0);
            if (cVar2) goto LAB_180ec220b;
            if (this.nowShowHero != null) {
              lVar5 = this.nowShowHero.kungfuSkills;
              if (((this.skillGrid != null) &&
                  (lVar7 = GameObject.get_transform(this.skillGrid,0)) != null) &&
                 ((lVar7 = Transform.GetChild(lVar7,iVar3,0), lVar7 != null &&
                  ((lVar7 = Component.GetComponent(lVar7,DAT_181d6d240), lVar7 != null && (lVar5 != null))))))
              {
                cVar2 = FUN_1818279a0(lVar5,*(uint64 *)(lVar7 + 32));
                if (!cVar2) goto LAB_180ec220b;
                if (((((this.skillGrid != null) &&
                      (lVar5 = GameObject.get_transform(this.skillGrid,0)) != null) &&
                     (lVar5 = Transform.GetChild(lVar5,iVar3,0)) != null) &&
                    ((lVar5 = Component.GetComponent(lVar5), lVar5 != null &&
                     (lVar5.summonControlable != null)))) &&
                   (lVar5 = KungfuSkillLvData.DataBase()) != null) goto code_r0x000180ec21ff;
              }
            }
          }
          goto LAB_180ec26ef;
        }
        lVar5 = this.nowShowHero;
        uVar10 = 0;
        if (lVar5 == null) goto LAB_180ec26ef;
        lVar7 = 32;
        LAB_180ec22f0:
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
                    goto LAB_180ec26ef;
                    iVar4 = Transform.get_childCount(lVar5,0);
                    lVar5 = this.skillGrid;
                    if (iVar4 <= iVar3) {
                      lVar8 = FUN_18046c1a0(0);
                      if (lVar8 == null) goto LAB_180ec26ef;
                      uVar6 = *(uint64 *)(lVar8 + 168);
                      lVar5 = GlobalData.AddChild(lVar5,uVar6,0);
                      this.temp = lVar5;
                      if (*plVar1 == 0) goto LAB_180ec26ef;
                      lVar5 = GameObject.GetComponent(*plVar1,DAT_181da1630);
                      if (((this.nowShowHero == null) ||
                          (lVar8 = this.nowShowHero.kungfuSkills) == null) ||
                         (uVar6 = FUN_180002f80(lVar8,uVar10), lVar5 == null)) goto LAB_180ec26ef;
                      lVar5.summonControlable = uVar6;
                      goto LAB_180ec25e2;
                    }
                    if (((lVar5 == null) || (lVar5 = GameObject.get_transform(lVar5,0)) == null) ||
                       (lVar5 = Transform.GetChild(lVar5,iVar3)) == null) goto LAB_180ec26ef;
                    uVar6 = Component.GetComponent(lVar5);
                    cVar2 = Object.op_Inequality(uVar6);
                    if (cVar2) {
                      if ((((this.skillGrid == null) ||
                           (lVar5 = GameObject.get_transform(this.skillGrid,0), lVar5 == null
                           )) || (lVar5 = Transform.GetChild(lVar5,iVar3,0)) == null) ||
                         (lVar5 = Component.GetComponent(lVar5,DAT_181d6d240)) == null)
                      goto LAB_180ec26ef;
                      lVar5 = lVar5.summonControlable;
                      if ((this.nowShowHero == null) ||
                         (this.nowShowHero.kungfuSkills == null)) goto LAB_180ec26ef;
                      lVar8 = FUN_180002f80();
                      if (lVar5 == lVar8) goto LAB_180ec248c;
                    }
                    iVar3 = iVar3 + 1;
                  } while( true );
                }
                goto LAB_180ec2642;
              }
            }
            goto LAB_180ec26ef;
          }
          HeroDetailController.ResetSkillSortType(this,0);
          if (resetPos) {
            if (((this.skillGrid == null) ||
                (lVar5 = GameObject.get_transform(this.skillGrid,0)) == null) ||
               ((lVar5 = FUN_180da0f00(lVar5,0), lVar5 == null ||
                (((lVar5 = FUN_180da0f00(lVar5,0), lVar5 == null ||
                  (lVar5 = Component.GetComponent(lVar5,DAT_181d6c940)) == null) ||
                 (lVar5.heroAIDataArriveTargetRecord == null)))))) goto LAB_180ec26ef;
            Scrollbar.set_value(lVar5.heroAIDataArriveTargetRecord,0x3f800000,0);
          }
          return;
        }
        goto LAB_180ec26ef;
        code_r0x000180ec21ff:
        if (lVar5.interestingStar != this.nowSkillListType) {
        LAB_180ec220b:
          if (((this.skillGrid == null) ||
              (lVar5 = GameObject.get_transform(this.skillGrid,0)) == null) ||
             ((lVar5 = Transform.GetChild(lVar5,iVar3,0), lVar5 == null ||
              (lVar5 = Component.get_gameObject(lVar5,0)) == null))) goto LAB_180ec26ef;
          GameObject.SetActive(lVar5,0);
          if (((this.skillGrid == null) ||
              (lVar5 = GameObject.get_transform(this.skillGrid,0)) == null) ||
             (lVar5 = Transform.GetChild(lVar5,iVar3,0)) == null) goto LAB_180ec26ef;
          uVar6 = Component.get_gameObject(lVar5);
          Object.Destroy(uVar6);
        }
        goto joined_r0x000180ec2094;
        LAB_180ec248c:
        if (((this.skillGrid == null) ||
            (lVar5 = GameObject.get_transform(this.skillGrid,0)) == null) ||
           (lVar5 = Transform.GetChild(lVar5,iVar3)) == null) goto LAB_180ec26ef;
        uVar6 = Component.get_gameObject(lVar5,0);
        this.temp = uVar6;
        if ((((this.skillGrid == null) ||
             (lVar5 = GameObject.get_transform(this.skillGrid,0)) == null) ||
            (lVar5 = Transform.GetChild(lVar5,iVar3)) == null) ||
           (lVar5 = Component.GetComponent(lVar5,DAT_181d6d240)) == null) goto LAB_180ec26ef;
        *(uint8 *)(lVar5 + 44) = 0;
        LAB_180ec25e2:
        lVar5 = this.temp;
        if ((lVar5 == null) || (lVar5 = GameObject.GetComponent(lVar5,DAT_181da1630)) == null)
        goto LAB_180ec26ef;
        lVar5.summonLv = uVar10;
        lVar5 = this.temp;
        if (lVar5 == null) goto LAB_180ec26ef;
        lVar5 = GameObject.GetComponent(lVar5,DAT_181da1630);
        cVar2 = HeroDetailController.NowShowHeroItemControlable(this,0);
        uVar9 = 2;
        if (cVar2) {
          uVar9 = 0;
        }
        if (lVar5 == null) goto LAB_180ec26ef;
        lVar5.summonSourceHero = uVar9;
        LAB_180ec2642:
        lVar5 = this.nowShowHero;
        uVar10 = uVar10 + 1;
        lVar7 = lVar7 + 8;
        if (lVar5 == null) goto LAB_180ec26ef;
        goto LAB_180ec22f0;
    }

    // Token : 0x600174B
    // RVA   : 0xEB0B60   Offset: 0xEAF360   Length: 0x15D
    public void ChangeSkillSortType()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        long lVar1;
        if (this.skillSortTypeDropDown != null) {
          this.skillSortType = *(uint32 *)(this.skillSortTypeDropDown + 0x120);
          if ((*pStatics != 0) &&
             (lVar1 = *(int64 *)(*pStatics + 32)) != null) {
            *(uint32 *)(lVar1 + 600) = this.skillSortType;
            HeroDetailController.ResetSkillSortType(this,0);
            plVar2 = (int64 *)Resources.Load("Sound/SoundEffect/Armor",0);
            plVar3 = (int64 *)0;
            if ((plVar2 != (int64 *)0) && (*plVar2 == DAT_181d8a228)) {
              plVar3 = plVar2;
            }
            NGUITools.PlaySound(plVar3,0x3f19999a,0);
            return;
          }
        }
    }

    // Token : 0x600174C
    // RVA   : 0xEB0910   Offset: 0xEAF110   Length: 0x243
    public void ChangeSkillReverseType(GameObject buttonClicked)
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        long lVar1;
        ulong uVar2;
        int iVar4;
        uint local_18;
        float local_14;
        uint local_10;
        this.reverseOrder = !this.reverseOrder;
        if (((*pStatics != 0) &&
            (lVar1 = *(int64 *)(*pStatics + 32)) != null) &&
           (*(uint8 *)(lVar1 + 0x25c) = this.reverseOrder, buttonClicked != null)) {
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
            lVar1 = GameObject.GetComponent(buttonClicked,DAT_181da12b0);
            uVar2 = "升序";
            if (this.reverseOrder) {
              uVar2 = "降序";
            }
            if (lVar1 != null) {
              *(uint64 *)(lVar1 + 24) = uVar2;
              HeroDetailController.ResetSkillSortType(this,0);
              plVar3 = (int64 *)Resources.Load("Sound/SoundEffect/Armor",0);
              plVar5 = (int64 *)0;
              if ((plVar3 != (int64 *)0) && (*plVar3 == DAT_181d8a228)) {
                plVar5 = plVar3;
              }
              NGUITools.PlaySound(plVar5,0x3f19999a,0);
              return;
            }
          }
        }
    }

    // Token : 0x600174D
    // RVA   : 0xEC2E90   Offset: 0xEC1690   Length: 0x123
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
               (lVar2 = Component.GetComponent(lVar2,DAT_181d6d240)) == null) break;
            SkillIconController.AutoSetName
                      (lVar2,this.skillSortType,this.reverseOrder,0);
            lVar2 = this.skillGrid;
            iVar3 = iVar3 + 1;
            if (lVar2 == null) break;
          }
        }
    }

    // Token : 0x600174E
    // RVA   : 0xEB0830   Offset: 0xEAF030   Length: 0xDD
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
            if ((plVar4 != (int64 *)0) && (*plVar4 == DAT_181d8a228)) {
              plVar5 = plVar4;
            }
            NGUITools.PlaySound(plVar5,0);
          }
          return;
        }
    }

    // Token : 0x600174F
    // RVA   : 0xEB1830   Offset: 0xEB0030   Length: 0x2F6
    public void ExchangeTeamButtonClicked()
    {
        var pStatics_8158 = *(int64*)(DAT_181d88158 + 184);
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        long lVar1;
        bool cVar2;
        long lVar3;
        if (this.nowShowHero != null) {
          cVar2 = HeroData.ItemExchangeable(this.nowShowHero,0);
          if (!cVar2) {
            lVar1 = *(int64 *)(pStatics_8158 + 8);
            if ((*pStatics_df90 != 0) &&
               (lVar3 = *(int64 *)(*pStatics_df90 + 32)) != null) {
              lVar3 = WorldData.Player(lVar3,0);
              if ((lVar3 != null) && ((this.nowShowHero != null && (lVar1 != null)))) {
                TradeUIController.ShowTradeUI
                          (lVar1,3,*(uint64 *)(lVar3 + 0x220),
                           this.nowShowHero.itemListData,0,0);
                return;
              }
            }
          }
          else {
            lVar1 = *(int64 *)(pStatics_8158 + 8);
            if ((*pStatics_df90 != 0) &&
               (lVar3 = *(int64 *)(*pStatics_df90 + 32)) != null) {
              lVar3 = WorldData.Player(lVar3,0);
              if ((lVar3 != null) && ((this.nowShowHero != null && (lVar1 != null)))) {
                TradeUIController.ShowTradeUI
                          (lVar1,1,*(uint64 *)(lVar3 + 0x220),
                           this.nowShowHero.itemListData,0,0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x6001750
    // RVA   : 0xEB9F10   Offset: 0xEB8710   Length: 0x20D
    public void LeaveTeamButtonClicked()
    {
        var pStatics = *(int64*)(DAT_181d6c960 + 184);
        long lVar1;
        long lVar2;
        ulong uVar3;
        if (*pStatics != 0) {
          *(uint64 *)(*pStatics + 112) = this.nowShowHero;
          HeroDetailController.UnshowHeroDetail(this,0);
          lVar1 = *pStatics;
          lVar2 = il2cpp_internal(DAT_181d72a30);
          FUN_180f58a90(lVar2,DAT_181d7c250);
          if (lVar2 != null) {
            FUN_181827900(lVar2,"后会有期;SureHeroLeaveTeam",DAT_181d7c3d0);
            FUN_181827900(lVar2,"开个玩笑;HideInteractUITemp",DAT_181d7c3d0);
            uVar3 = new SinglePlotData("#PlayerName#已不需要我继续助阵了吗？",lVar2,0,0);
            if (lVar1 != null) {
              PlotController.ChangePlot(lVar1,uVar3,0);
              return;
            }
          }
        }
    }

    // Token : 0x6001751
    // RVA   : 0xEC5430   Offset: 0xEC3C30   Length: 0x11E
    public void TalkButtonClicked()
    {
        var pStatics = *(int64*)(DAT_181d6c960 + 184);
        if (*pStatics != 0) {
          *(uint64 *)(*pStatics + 112) = this.nowShowHero;
          HeroDetailController.UnshowHeroDetail(this,0);
          if (*pStatics != 0) {
            PlotController.ChangeNormalMeetNpcPlot(*pStatics,0);
            return;
          }
        }
    }

    // Token : 0x6001752
    // RVA   : 0xEB9EC0   Offset: 0xEB86C0   Length: 0x43
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

    // Token : 0x6001753
    // RVA   : 0xEBEA70   Offset: 0xEBD270   Length: 0x152
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
              lVar2 = Component.GetComponent(lVar2,DAT_181d6bc40);
              uVar4 = "UIAtlas";
              lVar1 = **(int64 **)(DAT_181d86270 + 184);
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

    // Token : 0x6001754
    // RVA   : 0xEB1510   Offset: 0xEAFD10   Length: 0x252
    public void DiscardButtonClicked()
    {
        var pStatics_8158 = *(int64*)(DAT_181d88158 + 184);
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        long lVar1;
        ulong uVar2;
        long lVar3;
        lVar1 = *(int64 *)(pStatics_8158 + 8);
        if ((*pStatics_df90 != 0) &&
           (lVar3 = *(int64 *)(*pStatics_df90 + 32)) != null) {
          lVar3 = WorldData.Player(lVar3,0);
          if (lVar3 != null) {
            uVar2 = *(uint64 *)(lVar3 + 0x220);
            lVar3 = *(int64 *)(pStatics_8158 + 8);
            if ((lVar3 != null) && (lVar1 != null)) {
              TradeUIController.ShowTradeUI(lVar1,1,uVar2,*(uint64 *)(lVar3 + 184),0,0);
              plVar4 = (int64 *)Resources.Load("Sound/SoundEffect/Armor",0);
              plVar5 = (int64 *)0;
              if ((plVar4 != (int64 *)0) && (*plVar4 == DAT_181d8a228)) {
                plVar5 = plVar4;
              }
              NGUITools.PlaySound(plVar5,0);
              return;
            }
          }
        }
    }

    // Token : 0x6001755
    // RVA   : 0xEB0730   Offset: 0xEAEF30   Length: 0xFB
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
                if ((plVar3 != (int64 *)0) && (*plVar3 == DAT_181d8a228)) {
                  plVar4 = plVar3;
                }
                NGUITools.PlaySound(plVar4,0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x6001756
    // RVA   : 0xEB0120   Offset: 0xEAE920   Length: 0x459
    public GameObject AddClothChoice(int skinID, int skinLv)
    {
        var pStatics = *(int64*)(DAT_181d4e010 + 184);
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
          lVar2 = GameObject.GetComponent(lVar1,DAT_181d9f218);
          if (lVar2 != null) {
            *(int *)(lVar2 + 24) = skinID;
            lVar2 = GameObject.GetComponent(lVar1,DAT_181d9f218);
            if (lVar2 != null) {
              *(uint32 *)(lVar2 + 28) = skinLv;
              lVar2 = GameObject.get_transform(lVar1,0);
              if (lVar2 != null) {
                lVar2 = Transform.Find(lVar2,"Icon",0);
                if (lVar2 != null) {
                  plVar3 = (int64 *)Component.GetComponent(lVar2,DAT_181d6bc40);
                  lVar2 = *(int64 *)(pStatics + 32);
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
                          uVar4 = Component.GetComponent(lVar2,DAT_181d6d8c0);
                          lVar2 = *(int64 *)(pStatics + 32);
                          if (lVar2 != null) {
                            lVar2 = GameDataController.FindSkinDataBase(lVar2,skinID,0);
                            if (lVar2 != null) {
                              uVar7 = 0;
                              uVar5 = SkinDataBase.GetSkinFullName(lVar2,skinLv,1,0,0);
                              LTLocalization.SetText(uVar4,uVar5,0);
                              lVar2 = GameObject.GetComponent(lVar1,DAT_181da12b0);
                              lVar6 = *(int64 *)(pStatics + 32);
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
                                      uVar5 = il2cpp_value_box(DAT_181d5b2f8,local_38);
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

    // Token : 0x6001757
    // RVA   : 0xEB9410   Offset: 0xEB7C10   Length: 0x160
    public void InitClothList()
    {
        long lVar1;
        int iVar2;
        int iVar3;
        this.clothListInited = 1;
        iVar3 = 0;
        while( true ) {
          lVar1 = *(int64 *)(*(int64 *)(DAT_181d4e010 + 184) + 32);
          if ((lVar1 == null) || (lVar1 = *(int64 *)(lVar1 + 0x1a8)) == null) break;
          if (*(int *)(lVar1 + 24) <= iVar3) {
            return;
          }
          iVar2 = 0;
          do {
            lVar1 = FUN_18046c100(0);
            if (((lVar1 == null) || (*(int64 *)(lVar1 + 0x1a8) == 0)) ||
               (lVar1 = FUN_180002f80(*(int64 *)(lVar1 + 0x1a8),iVar3,DAT_181d7b5d8)) == null)
            throw; // [null/range check failed]
            HeroDetailController.AddClothChoice(this,*(uint32 *)(lVar1 + 16),iVar2,0);
            iVar2 = iVar2 + 1;
          } while (iVar2 < 6);
          iVar3 = iVar3 + 1;
        }
    }

    // Token : 0x6001758
    // RVA   : 0xEC3720   Offset: 0xEC1F20   Length: 0x318
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
            lVar2 = *(int64 *)(*(int64 *)(DAT_181d4e010 + 184) + 32);
            if ((lVar2 == null) || (lVar2 = *(int64 *)(lVar2 + 0x1a8)) == null) break;
            if (*(int *)(lVar2 + 24) <= iVar4) goto LAB_180ec38d7;
            iVar3 = 0;
            do {
              lVar2 = FUN_18046c100(0);
              if (((lVar2 == null) || (*(int64 *)(lVar2 + 0x1a8) == 0)) ||
                 (lVar2 = FUN_180002f80(*(int64 *)(lVar2 + 0x1a8),iVar4,DAT_181d7b5d8)) == null)
              throw; // [null/range check failed]
              HeroDetailController.AddClothChoice(this,*(uint32 *)(lVar2 + 16),iVar3,0);
              iVar3 = iVar3 + 1;
            } while (iVar3 < 6);
            iVar4 = iVar4 + 1;
          }
        }
        else {
        LAB_180ec38d7:
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
                   (lVar2 = Component.GetComponent(lVar2,DAT_181d6af40)) == null)))))
              throw; // [null/range check failed]
              Selectable.set_interactable(lVar2,0,0);
            }
            return;
          }
        }
    }

    // Token : 0x6001759
    // RVA   : 0xEBB3D0   Offset: 0xEB9BD0   Length: 0xA0C
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
            lVar5 = FUN_18046c0a0(0);
            if (lVar5 == null) break;
            lVar5 = *(int64 *)(lVar5 + 32);
            if ((((this.clothGrid == null) ||
                 (lVar6 = GameObject.get_transform(this.clothGrid,0)) == null) ||
                (lVar6 = Transform.GetChild(lVar6,iVar10,0)) == null) ||
               (lVar6 = Component.GetComponent(lVar6,DAT_181d6b2c0)) == null) break;
            uVar1 = *(uint32 *)(lVar6 + 24);
            if (((this.clothGrid == null) ||
                (lVar6 = GameObject.get_transform(this.clothGrid,0)) == null) ||
               ((lVar6 = Transform.GetChild(lVar6,iVar10,0), lVar6 == null ||
                ((lVar6 = Component.GetComponent(lVar6,DAT_181d6b2c0), lVar6 == null || (lVar5 == null))))))
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
        LAB_180ebbd87:
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
              lVar5 = Component.GetComponent(lVar5,DAT_181d6af40);
              if (this.nowShowHero == null) break;
              iVar3 = this.nowShowHero.heroForceLv;
              if ((((this.clothGrid == null) ||
                   (lVar6 = GameObject.get_transform(this.clothGrid,0)) == null) ||
                  (lVar6 = Transform.GetChild(lVar6,iVar10,0)) == null) ||
                 ((lVar6 = Component.GetComponent(lVar6,DAT_181d6b2c0), lVar6 == null || (lVar5 == null))))
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
                 (lVar6 = Component.GetComponent(lVar6,DAT_181d6b2c0)) == null) break;
              if (iVar3 == *(int *)(lVar6 + 24)) {
                if (this.nowShowHero == null) break;
                iVar3 = this.nowShowHero.skinLv;
                if (((this.clothGrid == null) ||
                    (lVar6 = GameObject.get_transform(this.clothGrid,0)) == null) ||
                   ((lVar6 = Transform.GetChild(lVar6,iVar10,0), lVar6 == null ||
                    (lVar6 = Component.GetComponent(lVar6,DAT_181d6b2c0)) == null))) break;
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
                  (lVar5 = Component.GetComponent(lVar5,DAT_181d6b2c0)) == null))) break;
              if (iVar3 == *(int *)(lVar5 + 24)) {
                iVar3 = this.tempSkinLv;
                if (iVar3 == -99) {
                  if (this.nowShowHero == null) break;
                  iVar3 = this.nowShowHero.skinLv;
                }
                if ((((this.clothGrid == null) ||
                     (lVar5 = GameObject.get_transform(this.clothGrid,0)) == null) ||
                    (lVar5 = Transform.GetChild(lVar5,iVar10,0)) == null) ||
                   (lVar5 = Component.GetComponent(lVar5,DAT_181d6b2c0)) == null) break;
                if (iVar3 != *(int *)(lVar5 + 28)) goto LAB_180ebba58;
                if (((this.clothGrid == null) ||
                    (lVar5 = GameObject.get_transform(this.clothGrid,0)) == null) ||
                   (lVar5 = Transform.GetChild(lVar5,iVar10,0)) == null) break;
                plVar8 = (int64 *)Component.GetComponent(lVar5,DAT_181d6bc40);
                lVar5 = *(int64 *)(DAT_181d4ef00 + 184);
                if (plVar8 == (int64 *)0) break;
                local_28 = *(uint32 *)(lVar5 + 0x370);
                uStack_24 = *(uint32 *)(lVar5 + 0x374);
                uStack_20 = *(uint32 *)(lVar5 + 0x378);
                uStack_1c = *(uint32 *)(lVar5 + 0x37c);
                (**(code **)(*plVar8 + 0x2a8))(plVar8,&local_28);
              }
              else {
        LAB_180ebba58:
                if (((this.clothGrid == null) ||
                    (lVar5 = GameObject.get_transform(this.clothGrid,0)) == null) ||
                   (lVar5 = Transform.GetChild(lVar5,iVar10,0)) == null) break;
                plVar8 = (int64 *)Component.GetComponent(lVar5,DAT_181d6bc40);
                puVar9 = (uint32 *)FUN_181098a50(local_18,0);
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
                 (lVar5 = Component.GetComponent(lVar5,DAT_181d6b2c0)) == null) break;
              iVar3 = *(int *)(lVar5 + 24);
              if (this.nowShowHero == null) break;
              iVar4 = HeroData.GetDefaultSkinID(this.nowShowHero,0);
              if (iVar3 == iVar4) {
                if (((this.clothGrid == null) ||
                    (lVar5 = GameObject.get_transform(this.clothGrid,0)) == null) ||
                   ((lVar5 = Transform.GetChild(lVar5,iVar10,0), lVar5 == null ||
                    ((lVar5 = Component.GetComponent(lVar5,DAT_181d6b2c0), lVar5 == null ||
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
                    goto LAB_180ebbda8;
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
                  goto LAB_180ebbd87;
                }
                break;
              }
            }
        LAB_180ebbda8:
            lVar5 = this.clothGrid;
            iVar10 = iVar10 + 1;
            if (lVar5 == null) break;
          }
        }
    }

    // Token : 0x600175A
    // RVA   : 0xEB0CC0   Offset: 0xEAF4C0   Length: 0x4A8
    public void ClothChoiceButtonClicked(int skinID, int skinLv)
    {
        long lVar1;
        ulong uVar2;
        long lVar3;
        lVar1 = this.nowShowHero;
        if (lVar1 != null) {
          if (lVar1.heroForceLv < (int)skinLv) {
            lVar1 = **(int64 **)(DAT_181d4df90 + 184);
            lVar3 = *(int64 *)(*(int64 *)(DAT_181d4ef00 + 184) + 0x3d0);
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
              if ((plVar4 != (int64 *)0) && (plVar5 = (int64 *)0, *plVar4 == DAT_181d8a228)) {
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
                        (lVar1 = Component.GetComponent(lVar1,DAT_181d6af40)) != null))) {
                      Selectable.set_interactable(lVar1,0,0);
                      return;
                    }
                  }
                  else if ((((this.heroDetailPanel != null) &&
                            ((lVar1 = GameObject.get_transform(this.heroDetailPanel,0),
                             lVar1 != null && (lVar1 = Transform.Find(lVar1,"ClothList",0)) != null)))
                           && (lVar1 = Transform.Find(lVar1,"SureButton",0)) != null) &&
                          (lVar1 = Component.GetComponent(lVar1,DAT_181d6af40)) != null) {
                    Selectable.set_interactable(lVar1,1,0);
                    return;
                  }
                }
              }
              throw; // [null/range check failed]
            }
            lVar1 = FUN_18046c0a0(0);
            uVar2 = FUN_180004500(DAT_181d63120);
            uVar2 = String.Format("女性角色无法穿着！",uVar2,0);
          }
          if (lVar1 != null) {
            GameController.ShowTextOnMouse(lVar1,uVar2,0);
            plVar4 = (int64 *)Resources.Load("Sound/SoundEffect/WrongClick",0);
            plVar5 = (int64 *)0;
            if ((plVar4 != (int64 *)0) && (*plVar4 == DAT_181d8a228)) {
              plVar5 = plVar4;
            }
            NGUITools.PlaySound(plVar5,0);
            return;
          }
        }
    }

    // Token : 0x600175B
    // RVA   : 0xEC2700   Offset: 0xEC0F00   Length: 0x783
    public void ResetFaceSetting()
    {
        var pStatics = *(int64*)(DAT_181d4ef00 + 184);
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
                  lVar2 = *(int64 *)(pStatics + 0x1d8);
                  if (lVar2 == null) break;
                  uVar4 = FUN_180002f80(lVar2,local_res8[0],DAT_181d7c9c0);
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
        LAB_180ec2a73:
                        lVar2 = *(int64 *)(pStatics + 0x1d8);
                        if (lVar2 == null) break;
                        uVar4 = FUN_180002f80(lVar2,local_res8[0],DAT_181d7c9c0);
                        cVar1 = FUN_1816fd990(uVar4,"胡",0);
                        if (cVar1) {
                          lVar2 = GameObject.get_transform(lVar3,0);
                          uVar4 = Int32.ToString(local_res8,0);
                          if (((lVar2 == null) || (lVar2 = Transform.Find(lVar2,uVar4,0)) == null) ||
                             (lVar2 = Component.GetComponent(lVar2,DAT_181d6d2c0)) == null) break;
                          Selectable.set_interactable(lVar2,1,0);
                        }
                        lVar2 = GameObject.get_transform(lVar3,0);
                        uVar4 = Int32.ToString(local_res8,0);
                        if ((lVar2 == null) || (lVar2 = Transform.Find(lVar2,uVar4,0)) == null) break;
                        lVar2 = Component.GetComponent(lVar2,DAT_181d6d2c0);
                        if (this.nowShowHero == null) break;
                        if (!this.nowShowHero.isFemale) {
                          lVar5 = FUN_18046c100(0);
                          if (lVar5 == null) break;
                          lVar5 = *(int64 *)(lVar5 + 0x158);
                        }
                        else {
                          lVar5 = FUN_18046c100(0);
                          if (lVar5 == null) break;
                          lVar5 = *(int64 *)(lVar5 + 0x160);
                        }
                        if (((lVar5 == null) || (*(int64 *)(lVar5 + 16) == 0)) ||
                           (FUN_1800d6750(*(int64 *)(lVar5 + 16),local_res8[0],DAT_181d68270),
                           lVar2 == null)) break;
                        Slider.set_maxValue(lVar2);
                        lVar2 = *(int64 *)(pStatics + 0x1d8);
                        if (lVar2 == null) break;
                        uVar4 = FUN_180002f80(lVar2,local_res8[0],DAT_181d7c9c0);
                        cVar1 = FUN_1816fd990(uVar4,"胡",0);
                        if (!cVar1) {
                          lVar2 = *(int64 *)(pStatics + 0x1d8);
                          if (lVar2 == null) break;
                          uVar4 = FUN_180002f80(lVar2,local_res8[0],DAT_181d7c9c0);
                          cVar1 = FUN_1816fd990(uVar4,"发",0);
                          if (!cVar1) {
                            lVar2 = *(int64 *)(pStatics + 0x1d8);
                            if (lVar2 == null) break;
                            uVar4 = FUN_180002f80(lVar2,local_res8[0],DAT_181d7c9c0);
                            cVar1 = FUN_1816fd990(uVar4,"杂",0);
                            if (!cVar1) goto LAB_180ec2dd1;
                          }
                        }
                        lVar2 = GameObject.get_transform(lVar3,0);
                        uVar4 = Int32.ToString(local_res8,0);
                        if (((lVar2 == null) || (lVar2 = Transform.Find(lVar2,uVar4,0)) == null) ||
                           (lVar2 = Component.GetComponent(lVar2,DAT_181d6d2c0)) == null) break;
                        Slider.set_minValue(lVar2);
                      }
                      else {
                        lVar2 = *(int64 *)(pStatics + 0x1d8);
                        if (lVar2 == null) break;
                        uVar4 = FUN_180002f80(lVar2,local_res8[0],DAT_181d7c9c0);
                        cVar1 = FUN_1816fd990(uVar4,"胡",0);
                        if (!cVar1) goto LAB_180ec2a73;
                        lVar2 = GameObject.get_transform(lVar3,0);
                        uVar4 = Int32.ToString(local_res8,0);
                        if (((lVar2 == null) || (lVar2 = Transform.Find(lVar2,uVar4,0)) == null) ||
                           (lVar2 = Component.GetComponent(lVar2,DAT_181d6d2c0)) == null) break;
                        Selectable.set_interactable(lVar2,0,0);
                      }
        LAB_180ec2dd1:
                      lVar2 = GameObject.get_transform(lVar3,0);
                      uVar4 = Int32.ToString(local_res8,0);
                      if ((lVar2 == null) || (lVar2 = Transform.Find(lVar2,uVar4,0)) == null) break;
                      plVar6 = (int64 *)Component.GetComponent(lVar2,DAT_181d6d2c0);
                      if ((this.nowShowHero == null) ||
                         (((lVar2 = this.nowShowHero.faceData, lVar2 == null ||
                           (lVar2 = lVar2.isSummon) == null) ||
                          (FUN_1800d6750(lVar2,local_res8[0],DAT_181d68270), plVar6 == (int64 *)0))))
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

    // Token : 0x600175C
    // RVA   : 0xEB1B30   Offset: 0xEB0330   Length: 0x602
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
          plVar3 = (int64 *)GameObject.GetComponent(target,DAT_181da1730);
          if (plVar3 == (int64 *)0) throw; // [null/range check failed]
          fVar7 = (float)(**(code **)(*plVar3 + 0x418))(plVar3,*(uint64 *)(*plVar3 + 0x420));
          this.tempHairID = (int)fVar7;
        }
        else if (iVar1 == 7) {
          plVar3 = (int64 *)GameObject.GetComponent(target,DAT_181da1730);
          if (plVar3 == (int64 *)0) throw; // [null/range check failed]
          fVar7 = (float)(**(code **)(*plVar3 + 0x418))(plVar3,*(uint64 *)(*plVar3 + 0x420));
          this.tempBeardID = (int)fVar7;
        }
        else if (iVar1 == 8) {
          plVar3 = (int64 *)GameObject.GetComponent(target,DAT_181da1730);
          if (plVar3 == (int64 *)0) throw; // [null/range check failed]
          fVar7 = (float)(**(code **)(*plVar3 + 0x418))(plVar3,*(uint64 *)(*plVar3 + 0x420));
          this.tempOtherID = (int)fVar7;
        }
        lVar4 = GameObject.get_transform(target,0);
        if (lVar4 == null) {
        LAB_180eb212d:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        lVar4 = Transform.Find(lVar4,"Id",0);
        if (lVar4 == null) goto LAB_180eb212d;
        uVar2 = Component.GetComponent(lVar4,DAT_181d6d8c0);
        plVar3 = (int64 *)GameObject.GetComponent(target,DAT_181da1730);
        if (plVar3 == (int64 *)0) goto LAB_180eb212d;
        local_res10[0] = (**(code **)(*plVar3 + 0x418))(plVar3,*(uint64 *)(*plVar3 + 0x420));
        uVar5 = il2cpp_value_box(DAT_181d7d0b8,local_res10);
        uVar5 = String.Format("({0})",uVar5,0);
        LTLocalization.SetText(uVar2,uVar5,0);
        lVar4 = this.nowShowHero;
        if (this.heroDetailPanel == null) goto LAB_180eb212d;
        lVar6 = GameObject.get_transform(this.heroDetailPanel,0);
        if (lVar6 == null) goto LAB_180eb212d;
        uVar2 = Transform.Find(lVar6,"Face",0);
        if (lVar4 == null) goto LAB_180eb212d;
        uVar2 = HeroData.GetSkeletonGraphic(lVar4,uVar2,0);
        plVar3 = (int64 *)GameObject.GetComponent(target,DAT_181da1730);
        if (plVar3 == (int64 *)0) goto LAB_180eb212d;
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
          plVar3 = (int64 *)GameObject.GetComponent(target,DAT_181da1730);
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
          if (iVar1 != *(int *)(lVar4.isSummon + 56)) goto LAB_180eb1fe6;
          iVar1 = this.tempOtherID;
          if (((this.nowShowHero == null) ||
              (lVar4 = this.nowShowHero.faceData) == null) ||
             (lVar4 = lVar4.isSummon) == null) throw; // [null/range check failed]
          if (lVar4.summonLv < 8) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          if (iVar1 != *(int *)(lVar4.isSummon + 60)) goto LAB_180eb1fe6;
          if (this.heroDetailPanel == null) throw; // [null/range check failed]
          lVar4 = GameObject.get_transform(this.heroDetailPanel,0);
          if (lVar4 == null) throw; // [null/range check failed]
          lVar4 = Transform.Find(lVar4,"ClothList",0);
          if (lVar4 == null) throw; // [null/range check failed]
          lVar4 = Transform.Find(lVar4,"SureButton",0);
          if (lVar4 == null) throw; // [null/range check failed]
          lVar4 = Component.GetComponent(lVar4,DAT_181d6af40);
          if (lVar4 == null) throw; // [null/range check failed]
          uVar2 = 0;
        }
        else {
        LAB_180eb1fe6:
          if (this.heroDetailPanel == null) throw; // [null/range check failed]
          lVar4 = GameObject.get_transform(this.heroDetailPanel,0);
          if (lVar4 == null) throw; // [null/range check failed]
          lVar4 = Transform.Find(lVar4,"ClothList",0);
          if (lVar4 == null) throw; // [null/range check failed]
          lVar4 = Transform.Find(lVar4,"SureButton",0);
          if (lVar4 == null) throw; // [null/range check failed]
          lVar4 = Component.GetComponent(lVar4,DAT_181d6af40);
          if (lVar4 == null) throw; // [null/range check failed]
          uVar2 = 1;
        }
        Selectable.set_interactable(lVar4,uVar2,0);
        lVar4 = *(int64 *)(*(int64 *)(DAT_181d4e010 + 184) + 32);
        if (lVar4 != null) {
          uVar2 = lVar4.salary;
          NGUITools.PlaySound(uVar2,0x3e4ccccd,0);
          return;
        }
    }

    // Token : 0x600175D
    // RVA   : 0xEC4C60   Offset: 0xEC3460   Length: 0x3A2
    public void SureChangeNowShowHeroCloth()
    {
        var pStatics = *(int64*)(DAT_181d51d80 + 184);
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
          FUN_18181e970(lVar1,3,this.tempHairID,DAT_181d68370);
          if (((this.nowShowHero == null) ||
              (lVar1 = this.nowShowHero.faceData) == null) ||
             (lVar1 = lVar1.isSummon) == null) throw; // [null/range check failed]
          FUN_18181e970(lVar1,6,this.tempHairID,DAT_181d68370);
        }
        if (this.tempBeardID != -99) {
          if (((this.nowShowHero == null) ||
              (lVar1 = this.nowShowHero.faceData) == null) ||
             (lVar1 = lVar1.isSummon) == null) throw; // [null/range check failed]
          FUN_18181e970(lVar1,7,this.tempBeardID,DAT_181d68370);
        }
        if (this.tempOtherID != -99) {
          if (((this.nowShowHero == null) ||
              (lVar1 = this.nowShowHero.faceData) == null) ||
             (lVar1 = lVar1.isSummon) == null) throw; // [null/range check failed]
          FUN_18181e970(lVar1,8,this.tempOtherID,DAT_181d68370);
        }
        lVar1 = this.nowShowHero;
        lVar2 = *(int64 *)(*(int64 *)(DAT_181d4e010 + 184) + 8);
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
            if ((plVar6 != (int64 *)0) && (*plVar6 == DAT_181d8a228)) {
              plVar8 = plVar6;
            }
            NGUITools.PlaySound(plVar8,0);
            if (this.nowShowHero != null) {
              if (this.nowShowHero.heroID == null) {
                uVar3 = **(uint64 **)(DAT_181d51d80 + 184);
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

    // Token : 0x600175E
    // RVA   : 0xEB1770   Offset: 0xEAFF70   Length: 0xBE
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
                lVar2 = Component.GetComponent(lVar2,DAT_181d6da40);
                if ((lVar2 != null) && (lVar1 != null)) {
                  lVar1.equipLock = *(uint8 *)(lVar2 + 0x118);
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x600175F
    // RVA   : 0xEC4810   Offset: 0xEC3010   Length: 0xBE
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
                lVar2 = Component.GetComponent(lVar2,DAT_181d6da40);
                if ((lVar2 != null) && (lVar1 != null)) {
                  lVar1.skillLock = *(uint8 *)(lVar2 + 0x118);
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x6001760
    // RVA   : 0xEC3B60   Offset: 0xEC2360   Length: 0x153
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
                        if ((plVar4 != (int64 *)0) && (*plVar4 == DAT_181d8a228)) {
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

    // Token : 0x6001761
    // RVA   : 0xEC3CC0   Offset: 0xEC24C0   Length: 0x351
    public void SetNameEndEdit()
    {
        long lVar1;
        long lVar2;
        ulong uVar5;
        ushort uVar6;
        ushort uVar7;
        if (**(int **)(DAT_181d4ef00 + 184) == 1) {
          lVar1 = new c.DisplayClass9_0(0);
          if (this.heroDetailPanel != null) {
            lVar2 = GameObject.get_transform(this.heroDetailPanel,0);
            if (lVar2 != null) {
              lVar2 = Transform.Find(lVar2,"SetNameInput",0);
              if (lVar2 != null) {
                lVar2 = Component.GetComponent(lVar2,DAT_181d6bcc0);
                if ((lVar2 != null) && (lVar1 != null)) {
                  *(uint64 *)(lVar1 + 16) = *(uint64 *)(lVar2 + 0x170);
                  *(uint8 *)(lVar1 + 24) =
                       *(uint8 *)(*(int64 *)(DAT_181d4ef00 + 184) + 128);
                  plVar3 = (int64 *)rail_api.RailFactory(0);
                  if (plVar3 != (int64 *)0) {
                    lVar2 = *plVar3;
                    uVar7 = 0;
                    if (*(uint16 *)(lVar2 + 0x12a) != 0) {
                      uVar6 = uVar7;
                      do {
                        if (*(int64 *)(*(int64 *)(lVar2 + 176) + (uint64)uVar6 * 16) ==
                            DAT_181d56638) {
                          puVar4 = (uint64 *)
                                   ((int64)
                                    *(int *)(*(int64 *)(lVar2 + 176) + 8 + (uint64)uVar6 * 16) *
                                    16 + 0x248 + lVar2);
                          goto LAB_180ec3ebf;
                        }
                        uVar6 = uVar6 + 1;
                      } while (uVar6 < *(uint16 *)(lVar2 + 0x12a));
                    }
                    puVar4 = (uint64 *)FUN_1800914f0(plVar3,DAT_181d56638,17);
        LAB_180ec3ebf:
                    plVar3 = (int64 *)(*(code *)*puVar4)(plVar3,puVar4[1]);
                    uVar5 = "";
                    if (plVar3 != (int64 *)0) {
                      lVar2 = *plVar3;
                      if (*(uint16 *)(lVar2 + 0x12a) != 0) {
                        do {
                          if (*(int64 *)(*(int64 *)(lVar2 + 176) + (uint64)uVar7 * 16) ==
                              DAT_181d57ca8) {
                            puVar4 = (uint64 *)
                                     ((int64)
                                      *(int *)(*(int64 *)(lVar2 + 176) + 8 + (uint64)uVar7 * 16)
                                      * 16 + 0x1f8 + lVar2);
                            goto LAB_180ec3f27;
                          }
                          uVar7 = uVar7 + 1;
                        } while (uVar7 < *(uint16 *)(lVar2 + 0x12a));
                      }
                      puVar4 = (uint64 *)FUN_1800914f0(plVar3,DAT_181d57ca8,12);
        LAB_180ec3f27:
                      (*(code *)*puVar4)(plVar3,lVar1,uVar5,puVar4[1]);
                      goto LAB_180ec3fee;
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
                lVar2 = Component.GetComponent(lVar2,DAT_181d6bcc0);
                if ((lVar2 != null) && (lVar1 != null)) {
                  uVar5 = CISFilterWordsSDK.FilterReplaceWithChar
                                    (lVar1,*(uint64 *)(lVar2 + 0x170),42,0);
                  HeroDetailController.SetNowShowHeroSettingName(this,uVar5,0);
        LAB_180ec3fee:
                  HeroDetailController.HideNameInput(this,0);
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x6001762
    // RVA   : 0xEC4020   Offset: 0xEC2820   Length: 0x108
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
                if ((plVar2 != (int64 *)0) && (*plVar2 == DAT_181d8a228)) {
                  plVar4 = plVar2;
                }
                NGUITools.PlaySound(plVar4,0);
                return;
              }
            }
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
    }

    // Token : 0x6001763
    // RVA   : 0xEB9320   Offset: 0xEB7B20   Length: 0xE9
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
                      lVar1 = Component.GetComponent(lVar1,DAT_181d6bcc0);
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

    // Token : 0x6001764
    // RVA   : 0xEBA6C0   Offset: 0xEB8EC0   Length: 0x9A
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

    // Token : 0x6001765
    // RVA   : 0xEBA760   Offset: 0xEB8F60   Length: 0x3E5
    public void RecruitUnlockButtonClicked()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        bool cVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        uint[] local_res18 = new uint[4];
        if ((*pStatics != 0) &&
           (lVar2 = *(int64 *)(*pStatics + 32)) != null) {
          lVar2 = WorldData.Player(lVar2,0);
          if (lVar2 != null) {
            lVar2 = HeroData.GetForce(lVar2,0,0);
            if (lVar2 != null) {
              if ((*pStatics == 0) ||
                 (lVar2 = *(int64 *)(*pStatics + 32)) == null)
              throw; // [null/range check failed]
              lVar2 = WorldData.Player(lVar2,0);
              if (lVar2 == null) throw; // [null/range check failed]
              lVar2 = HeroData.GetForce(lVar2,0,0);
              if (this.nowShowHero == null) throw; // [null/range check failed]
              HeroData.GetRecruitUnlockCost(this.nowShowHero,0);
              if (lVar2 == null) throw; // [null/range check failed]
              cVar1 = ForceData.HaveResource(lVar2,5);
              if (cVar1) {
                lVar2 = **(int64 **)(DAT_181d834f0 + 184);
                if (this.nowShowHero != null) {
                  local_res18[0] = HeroData.GetRecruitUnlockCost(this.nowShowHero,0);
                  uVar3 = il2cpp_value_box(DAT_181d5b2f8,local_res18);
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
                FUN_1800d6620();
              }
            }
            if (*pStatics != 0) {
              GameController.ShowTextOnMouse(*pStatics,"门派威望不足！",0);
              plVar5 = (int64 *)Resources.Load("Sound/SoundEffect/WrongClick",0);
              plVar6 = (int64 *)0;
              if ((plVar5 != (int64 *)0) && (*plVar5 == DAT_181d8a228)) {
                plVar6 = plVar5;
              }
              NGUITools.PlaySound(plVar6,0);
              return;
            }
          }
        }
    }

    // Token : 0x6001766
    // RVA   : 0xEC5010   Offset: 0xEC3810   Length: 0x418
    public void SureUnlockRecruit()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        long lVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        uint[] local_res18 = new uint[2];
        uint[] local_res20 = new uint[2];
        int[] local_38 = new int[4];
        ulong local_28;
        ulong uStack_20;
        if ((*pStatics != 0) &&
           (lVar2 = *(int64 *)(*pStatics + 32)) != null) {
          lVar2 = WorldData.Player(lVar2,0);
          if (lVar2 != null) {
            lVar2 = HeroData.GetForce(lVar2,0,0);
            if (this.nowShowHero != null) {
              HeroData.GetRecruitUnlockCost(this.nowShowHero,0);
              if (lVar2 != null) {
                ForceData.CostResource(lVar2,5);
                if ((*pStatics != 0) &&
                   (lVar2 = *(int64 *)(*pStatics + 32)) != null) {
                  lVar2 = *(int64 *)(lVar2 + 232);
                  if (this.nowShowHero != null) {
                    local_res18[0] = this.nowShowHero.heroForceLv;
                    uVar3 = il2cpp_value_box(DAT_181d5b2f8,local_res18);
                    uVar3 = String.Format("RecruitUnlockNumLv{0}",uVar3,0);
                    if ((*pStatics != 0) &&
                       (lVar1 = *(int64 *)(*pStatics + 32)) != null)
                    {
                      lVar1 = *(int64 *)(lVar1 + 232);
                      if (this.nowShowHero != null) {
                        local_res20[0] = this.nowShowHero.heroForceLv;
                        uVar4 = il2cpp_value_box(DAT_181d5b2f8,local_res20);
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
                                lVar2 = **(int64 **)(DAT_181d5a578 + 184);
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

    // Token : 0x6001767
    // RVA   : 0xEB0580   Offset: 0xEAED80   Length: 0xEC
    public void AllLeaveTeamButtonClicked()
    {
        long lVar1;
        ulong uVar2;
        ulong uVar3;
        lVar1 = **(int64 **)(DAT_181d834f0 + 184);
        uVar2 = FUN_180004500(DAT_181d63120);
        uVar2 = String.Format("确认要解散全体队友吗？",uVar2,0);
        uVar3 = Component.get_gameObject(this,0);
        if (lVar1 != null) {
          SureMenu.CallSureMenu(lVar1,uVar2,"SureAllLeaveTeam",0,uVar3,1,0,0,0,0);
          return;
        }
    }

    // Token : 0x6001768
    // RVA   : 0xEC4A30   Offset: 0xEC3230   Length: 0x229
    public void SureAllLeaveTeam()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        bool cVar2;
        uint uVar3;
        long lVar4;
        long lVar5;
        int iVar6;
        bVar1 = false;
        if ((((*pStatics != 0) &&
             (lVar4 = *(int64 *)(*pStatics + 32)) != null) &&
            (lVar4 = WorldData.Player(lVar4,0)) != null) && (*(int64 *)(lVar4 + 0x2f8) != 0)) {
          iVar6 = *(int *)(*(int64 *)(lVar4 + 0x2f8) + 24) + -1;
          if (-1 < iVar6) {
            do {
              lVar4 = FUN_18046c0a0(0);
              if (lVar4 == null) throw; // [null/range check failed]
              lVar4 = *(int64 *)(lVar4 + 32);
              lVar5 = FUN_18046c0a0(0);
              if (((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) ||
                 ((lVar5 = WorldData.Player(*(int64 *)(lVar5 + 32),0), lVar5 == null ||
                  (((*(int64 *)(lVar5 + 0x2f8) == 0 ||
                    (uVar3 = FUN_1800d6750(*(int64 *)(lVar5 + 0x2f8),iVar6,DAT_181d68270), lVar4 == null))
                   || (lVar4 = WorldData.GetHero(lVar4,uVar3,0)) == null))))) throw; // [null/range check failed]
              cVar2 = HeroData.MissionKeepInTeam(lVar4);
              if (!cVar2) {
                lVar5 = FUN_18046c0a0(0);
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

    // Token : 0x6001769
    // RVA   : 0xEC5B80   Offset: 0xEC4380   Length: 0x47
    public void /*ctor*/()
    {
        void FUN_180ec5b80(int64 this)
        {
        this.originSkinID = 999999;
        this.originSkinLV = 999999;
        this.tempSkinID = 0xffffff9d;
        this.tempSkinLv = 0xffffff9d;
        this.tempHairID = 0xffffff9d;
        this.tempBeardID = 0xffffff9d;
        this.tempOtherID = 0xffffff9d;
        FUN_18044ef50(this,0);
    }

    // Token : 0x600176A
    // RVA   : 0xEC5550   Offset: 0xEC3D50   Length: 0x4B
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
