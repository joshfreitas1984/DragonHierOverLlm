// ============================================================
// Type  : ItemIconController
// Token : 0x20002EF
// ============================================================

public class ItemIconController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001823
    public int itemListID;

    // Token: 0x4001824
    public ItemData itemData;

    // Token: 0x4001825
    public ItemIconType itemIconType;

    // Token: 0x4001826
    public TradeIconType tradeIconType;

    // Token: 0x4001827
    private float updateTime;

    // Token: 0x4001828
    private static Color PriceColor;

    // Token: 0x4001829
    private static Color ContributionColor;

    // Token: 0x400182A
    private static Color BookContributionColor;

    // Token: 0x400182B
    private static Color GovernContributionColor;

    // Token: 0x400182C
    public bool inited;

    // Token: 0x400182D
    public bool hideItemName;

    // Token: 0x400182E
    public bool hideItemBox;

    // Token: 0x400182F
    public bool needRefreshPriceIcon;

    // Token: 0x4001830
    public string fromStorage;

    // Token: 0x4001831
    private bool refsCached;

    // Token: 0x4001832
    private Transform tName;

    // Token: 0x4001833
    private Transform tBack;

    // Token: 0x4001834
    private Transform tItemLv;

    // Token: 0x4001835
    private Transform tCover;

    // Token: 0x4001836
    private Transform tRareLv;

    // Token: 0x4001837
    private Transform tIcon;

    // Token: 0x4001838
    private Transform tFromStorage;

    // Token: 0x4001839
    private Transform tForce;

    // Token: 0x400183A
    private Transform tBookType;

    // Token: 0x400183B
    private Transform tNew;

    // Token: 0x400183C
    private Transform tEquiped;

    // Token: 0x400183D
    private Transform tPrice;

    // Token: 0x400183E
    private Transform tPriceIcon;

    // Token: 0x400183F
    private Text nameText;

    // Token: 0x4001840
    private Text priceText;

    // Token: 0x4001841
    private Image backImage;

    // Token: 0x4001842
    private Image itemLvImage;

    // Token: 0x4001843
    private Image coverImage;

    // Token: 0x4001844
    private Image rareLvImage;

    // Token: 0x4001845
    private Image iconImage;

    // Token: 0x4001846
    private Image fromStorageImage;

    // Token: 0x4001847
    private Image forceImage;

    // Token: 0x4001848
    private Image bookTypeImage;

    // Token: 0x4001849
    private Image priceIconImage;

    // Token: 0x400184A
    private SimpleDetailText fromStorageDetail;

    // Token: 0x400184B
    private GameObject priceParentGameObject;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600187B
    // RVA   : 0xCA1080   Offset: 0xCA0480   Length: 0x7
    private void Awake()
    {
        void FUN_180ca1080(uint64 this)
        {
        ItemIconController.CacheRefs(this,0);
    }

    // Token : 0x600187C
    // RVA   : 0xCA1B10   Offset: 0xCA0F10   Length: 0x86F
    private void CacheRefs()
    {
        bool cVar2;
        long lVar3;
        ulong uVar4;
        if (this.refsCached) {
          return;
        }
        this.refsCached = 1;
        lVar3 = Component.get_transform(this,0);
        if (lVar3 != null) {
          uVar4 = Transform.Find(lVar3,"Name",0);
          this.tName = uVar4;
          lVar3 = Component.get_transform(this,0);
          if (lVar3 != null) {
            uVar4 = Transform.Find(lVar3,"Back",0);
            this.tBack = uVar4;
            lVar3 = Component.get_transform(this,0);
            if (lVar3 != null) {
              uVar4 = Transform.Find(lVar3,"ItemLv",0);
              this.tItemLv = uVar4;
              lVar3 = Component.get_transform(this,0);
              if (lVar3 != null) {
                uVar4 = Transform.Find(lVar3,"Cover",0);
                this.tCover = uVar4;
                lVar3 = Component.get_transform(this,0);
                if (lVar3 != null) {
                  uVar4 = Transform.Find(lVar3,"RareLv",0);
                  this.tRareLv = uVar4;
                  lVar3 = Component.get_transform(this,0);
                  if (lVar3 != null) {
                    uVar4 = Transform.Find(lVar3,"Icon",0);
                    this.tIcon = uVar4;
                    lVar3 = Component.get_transform(this,0);
                    if (lVar3 != null) {
                      uVar4 = Transform.Find(lVar3,"FromStorage",0);
                      this.tFromStorage = uVar4;
                      lVar3 = Component.get_transform(this,0);
                      if (lVar3 != null) {
                        uVar4 = Transform.Find(lVar3,"Force",0);
                        this.tForce = uVar4;
                        lVar3 = Component.get_transform(this,0);
                        if (lVar3 != null) {
                          uVar4 = Transform.Find(lVar3,"BookType",0);
                          this.tBookType = uVar4;
                          lVar3 = Component.get_transform(this,0);
                          if (lVar3 != null) {
                            uVar4 = Transform.Find(lVar3,"New",0);
                            this.tNew = uVar4;
                            lVar3 = Component.get_transform(this,0);
                            if (lVar3 != null) {
                              uVar4 = Transform.Find(lVar3,"Equiped",0);
                              this.tEquiped = uVar4;
                              lVar3 = Component.get_transform(this,0);
                              if (lVar3 != null) {
                                lVar3 = Transform.Find(lVar3,"Price",0);
                                this.tPrice = lVar3;
                                lVar3 = *plVar1;
                                cVar2 = Object.op_Inequality(lVar3,0,0);
                                if (cVar2) {
                                  if (*plVar1 == 0) throw; // [null/range check failed]
                                  uVar4 = Transform.Find(*plVar1,"PriceIcon",0);
                                  this.tPriceIcon = uVar4;
                                }
                                uVar4 = this.tName;
                                cVar2 = Object.op_Inequality(uVar4,0,0);
                                if (cVar2) {
                                  if (this.tName == null) throw; // [null/range check failed]
                                  uVar4 = Component.GetComponent
                                                    (this.tName,DAT_181d96178);
                                  this.nameText = uVar4;
                                }
                                lVar3 = *plVar1;
                                cVar2 = Object.op_Inequality(lVar3,0,0);
                                if (cVar2) {
                                  if (*plVar1 == 0) throw; // [null/range check failed]
                                  uVar4 = Component.GetComponent(*plVar1,DAT_181d96178);
                                  this.priceText = uVar4;
                                }
                                uVar4 = this.tBack;
                                cVar2 = Object.op_Inequality(uVar4,0,0);
                                if (cVar2) {
                                  if (this.tBack == null) throw; // [null/range check failed]
                                  uVar4 = Component.GetComponent
                                                    (this.tBack,DAT_181d94478);
                                  this.backImage = uVar4;
                                }
                                uVar4 = this.tItemLv;
                                cVar2 = Object.op_Inequality(uVar4,0,0);
                                if (cVar2) {
                                  if (this.tItemLv == null) throw; // [null/range check failed]
                                  uVar4 = Component.GetComponent
                                                    (this.tItemLv,DAT_181d94478);
                                  *(uint64 *)(this + 200) = uVar4;
                                }
                                uVar4 = this.tCover;
                                cVar2 = Object.op_Inequality(uVar4,0,0);
                                if (cVar2) {
                                  if (this.tCover == null) throw; // [null/range check failed]
                                  uVar4 = Component.GetComponent
                                                    (this.tCover,DAT_181d94478);
                                  this.coverImage = uVar4;
                                }
                                uVar4 = this.tRareLv;
                                cVar2 = Object.op_Inequality(uVar4,0,0);
                                if (cVar2) {
                                  if (this.tRareLv == null) throw; // [null/range check failed]
                                  uVar4 = Component.GetComponent
                                                    (this.tRareLv,DAT_181d94478);
                                  this.rareLvImage = uVar4;
                                }
                                uVar4 = this.tIcon;
                                cVar2 = Object.op_Inequality(uVar4,0,0);
                                if (cVar2) {
                                  if (this.tIcon == null) throw; // [null/range check failed]
                                  uVar4 = Component.GetComponent
                                                    (this.tIcon,DAT_181d94478);
                                  this.iconImage = uVar4;
                                }
                                uVar4 = this.tFromStorage;
                                cVar2 = Object.op_Inequality(uVar4,0,0);
                                if (cVar2) {
                                  if (this.tFromStorage == null) throw; // [null/range check failed]
                                  uVar4 = Component.GetComponent
                                                    (this.tFromStorage,DAT_181d94478);
                                  this.fromStorageImage = uVar4;
                                  if (this.tFromStorage == null) throw; // [null/range check failed]
                                  uVar4 = Component.GetComponent
                                                    (this.tFromStorage,DAT_181d95578);
                                  this.fromStorageDetail = uVar4;
                                }
                                uVar4 = this.tForce;
                                cVar2 = Object.op_Inequality(uVar4,0,0);
                                if (cVar2) {
                                  if (this.tForce == null) throw; // [null/range check failed]
                                  uVar4 = Component.GetComponent
                                                    (this.tForce,DAT_181d94478);
                                  this.forceImage = uVar4;
                                }
                                uVar4 = this.tBookType;
                                cVar2 = Object.op_Inequality(uVar4,0,0);
                                if (cVar2) {
                                  if (this.tBookType == null) throw; // [null/range check failed]
                                  uVar4 = Component.GetComponent
                                                    (this.tBookType,DAT_181d94478);
                                  this.bookTypeImage = uVar4;
                                }
                                uVar4 = this.tPriceIcon;
                                cVar2 = Object.op_Inequality(uVar4,0,0);
                                if (cVar2) {
                                  if (this.tPriceIcon == null) throw; // [null/range check failed]
                                  uVar4 = Component.GetComponent
                                                    (this.tPriceIcon,DAT_181d94478);
                                  this.priceIconImage = uVar4;
                                }
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

    // Token : 0x600187D
    // RVA   : 0xCA3860   Offset: 0xCA2C60   Length: 0x2510
    private void Update()
    {
        var pStatics_2130 = *(int64*)(DAT_181d82130 + 184);
        var pStatics_3d40 = *(int64*)(DAT_181d73d40 + 184);
        var pStatics_b4a8 = *(int64*)(DAT_181dab4a8 + 184);
        uint uVar1;
        bool cVar2;
        uint uVar3;
        int iVar4;
        ulong uVar6;
        long lVar7;
        long lVar8;
        ulong uVar9;
        long lVar10;
        long lVar11;
        ulong uVar14;
        float fVar15;
        float fVar16;
        ulong uVar17;
        ulong uVar18;
        uint uVar19;
        uint uVar20;
        uint uVar21;
        uint uVar22;
        uint[] local_res8 = new uint[2];
        uint[] local_res18 = new uint[2];
        ulong local_78;
        uint local_70;
        ulong local_68;
        ulong uStack_60;
        uVar3 = 0;
        local_res8[0] = 0;
        if (!this.refsCached) {
          ItemIconController.CacheRefs(this,0);
        }
        if (!this.inited) {
          uVar6 = this.nameText;
          this.inited = 1;
          this.updateTime = 0;
          cVar2 = Object.op_Inequality(uVar6,0,0);
          if (cVar2) {
            uVar6 = this.nameText;
            uVar9 = "";
            if (!this.hideItemName) {
              if (this.itemData == null) goto LAB_180ca5d6b;
              uVar9 = ItemData.Name(this.itemData,0,0);
            }
            LTLocalization.SetText(uVar6,uVar9,0);
          }
          uVar6 = this.backImage;
          if (!this.hideItemBox) {
            cVar2 = Object.op_Inequality(uVar6,0,0);
            if (cVar2) {
              plVar12 = this.backImage;
              puVar5 = (uint64 *)FUN_1810d3b80(&local_68,0);
              if (plVar12 == (int64 *)0) goto LAB_180ca5d6b;
              local_68 = *puVar5;
              uStack_60 = puVar5[1];
              (**(code **)(*plVar12 + 0x2a8))(plVar12,&local_68,*(uint64 *)(*plVar12 + 0x2b0));
            }
            uVar6 = *(uint64 *)(this + 200);
            cVar2 = Object.op_Inequality(uVar6,0,0);
            if (cVar2) {
              plVar12 = *(int64 **)(this + 200);
              if (**(int **)(DAT_181d73d40 + 184) == 2) {
                if (this.itemData == null) goto LAB_180ca5d6b;
                if (this.itemData.itemLv != 5) goto LAB_180ca3c0b;
                local_68 = 0;
                uStack_60 = 0;
                Color.ctor(&local_68,0x3f800000,0x3ed2d2d3,0x3f34b4b5,0);
                uVar19 = (uint32)local_68;
                uVar20 = local_68._4_4_;
                uVar21 = (uint32)uStack_60;
                uVar22 = uStack_60._4_4_;
              }
              else {
        LAB_180ca3c0b:
                lVar7 = FUN_18046c100(0);
                if (((lVar7 == null) || (this.itemData == null)) ||
                   (lVar7 = lVar7.value) == null) goto LAB_180ca5d6b;
                uVar1 = this.itemData.itemLv;
                if (lVar7.subType <= uVar1) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar7 = lVar7.itemID[uVar1];
                if (lVar7 == null) goto LAB_180ca5d6b;
                uVar19 = lVar7.subType;
                uVar20 = *(uint32 *)(lVar7 + 28);
                uVar21 = lVar7.name;
                uVar22 = *(uint32 *)(lVar7 + 36);
              }
              local_68 = CONCAT44(uVar20,uVar19);
              uStack_60 = CONCAT44(uVar22,uVar21);
              puVar5 = (uint64 *)GlobalData.SetColorAlpha(&local_78,&local_68,0x3f666666,0);
              if (plVar12 == (int64 *)0) goto LAB_180ca5d6b;
              local_68 = *puVar5;
              uStack_60 = puVar5[1];
              (**(code **)(*plVar12 + 0x2a8))(plVar12,&local_68,*(uint64 *)(*plVar12 + 0x2b0));
            }
            uVar6 = this.coverImage;
            cVar2 = Object.op_Inequality(uVar6,0,0);
            if (cVar2) {
              plVar12 = this.coverImage;
              puVar5 = (uint64 *)FUN_1810d3b80(&local_68,0);
        LAB_180ca3e48:
              if (plVar12 == (int64 *)0) goto LAB_180ca5d6b;
              local_68 = *puVar5;
              uStack_60 = puVar5[1];
              (**(code **)(*plVar12 + 0x2a8))(plVar12,&local_68,*(uint64 *)(*plVar12 + 0x2b0));
            }
          }
          else {
            cVar2 = Object.op_Inequality(uVar6,0,0);
            if (cVar2) {
              plVar12 = this.backImage;
              puVar5 = (uint64 *)FUN_180d995f0(&local_68,0);
              if (plVar12 == (int64 *)0) goto LAB_180ca5d6b;
              local_68 = *puVar5;
              uStack_60 = puVar5[1];
              (**(code **)(*plVar12 + 0x2a8))(plVar12,&local_68,*(uint64 *)(*plVar12 + 0x2b0));
            }
            uVar6 = *(uint64 *)(this + 200);
            cVar2 = Object.op_Inequality(uVar6,0,0);
            if (cVar2) {
              plVar12 = *(int64 **)(this + 200);
              puVar5 = (uint64 *)FUN_180d995f0(&local_68,0);
              if (plVar12 == (int64 *)0) goto LAB_180ca5d6b;
              local_68 = *puVar5;
              uStack_60 = puVar5[1];
              (**(code **)(*plVar12 + 0x2a8))(plVar12,&local_68,*(uint64 *)(*plVar12 + 0x2b0));
            }
            uVar6 = this.coverImage;
            cVar2 = Object.op_Inequality(uVar6,0,0);
            if (cVar2) {
              plVar12 = this.coverImage;
              puVar5 = (uint64 *)FUN_180d995f0(&local_68,0);
              goto LAB_180ca3e48;
            }
          }
          uVar6 = this.rareLvImage;
          cVar2 = Object.op_Inequality(uVar6,0,0);
          if (cVar2) {
            lVar7 = this.rareLvImage;
            lVar10 = *pStatics_b4a8;
            if (this.itemData == null) goto LAB_180ca5d6b;
            uVar6 = Int32.ToString(this.itemData + 64,0);
            uVar6 = String.Concat("RareLv",uVar6,0);
            if ((lVar10 == null) ||
               (uVar6 = TextureController.LoadAtlasSprite(lVar10,"IconAtlas",uVar6,0), lVar7 == null))
            goto LAB_180ca5d6b;
            Image.set_sprite(lVar7,uVar6,0);
          }
          uVar6 = this.rareLvImage;
          cVar2 = Object.op_Inequality(uVar6,0,0);
          if (cVar2) {
            lVar7 = this.itemData;
            plVar12 = this.rareLvImage;
            if (lVar7 == null) goto LAB_180ca5d6b;
            if (lVar7.type == 4) {
              if (lVar7.treasureData == null) goto LAB_180ca5d6b;
              if (*(char *)(lVar7.treasureData + 16) == false)
              {
                puVar5 = (uint64 *)FUN_180d995f0(&local_68,0);
                }
                else {
              }
              puVar5 = (uint64 *)FUN_1810d3b80(&local_68,0);
            }
            if (plVar12 == (int64 *)0) goto LAB_180ca5d6b;
            local_68 = *puVar5;
            uStack_60 = puVar5[1];
            (**(code **)(*plVar12 + 0x2a8))(plVar12,&local_68,*(uint64 *)(*plVar12 + 0x2b0));
          }
          uVar6 = this.iconImage;
          cVar2 = Object.op_Inequality(uVar6,0,0);
          if (cVar2) {
            lVar7 = this.iconImage;
            lVar10 = *pStatics_b4a8;
            if (((this.itemData == null) ||
                (uVar6 = ItemData.GetItemIconName(this.itemData,0), lVar10 == null)) ||
               (uVar6 = TextureController.LoadAtlasSprite(lVar10,"IconAtlas",uVar6,0), lVar7 == null))
            goto LAB_180ca5d6b;
            Image.set_sprite(lVar7,uVar6,0);
          }
          cVar2 = FUN_180d75bc0(this.fromStorage,0);
          uVar6 = this.tFromStorage;
          if (!cVar2) {
            cVar2 = Object.op_Inequality(uVar6,0,0);
            if (cVar2) {
              if ((this.tFromStorage == null) ||
                 (lVar7 = Component.get_gameObject(this.tFromStorage,0)) == null)
              goto LAB_180ca5d6b;
              cVar2 = GameObject.get_activeSelf(lVar7,0);
              if (!cVar2) {
                if ((this.tFromStorage == null) ||
                   (lVar7 = Component.get_gameObject(this.tFromStorage,0)) == null)
                goto LAB_180ca5d6b;
                GameObject.SetActive(lVar7,1,0);
              }
            }
            uVar6 = this.fromStorageDetail;
            cVar2 = Object.op_Inequality(uVar6,0,0);
            if (cVar2) {
              if (this.fromStorageDetail == null) goto LAB_180ca5d6b;
              this.fromStorageDetail.text = this.fromStorage;
            }
            uVar6 = this.fromStorageImage;
            cVar2 = Object.op_Inequality(uVar6,0,0);
            if (cVar2) {
              if (this.fromStorage == null) goto LAB_180ca5d6b;
              cVar2 = String.Contains(this.fromStorage,"藏经阁",0);
              if (cVar2) {
                lVar7 = this.fromStorageImage;
                lVar10 = FUN_18046c680(0);
                if ((lVar10 == null) ||
                   (uVar6 = TextureController.LoadAtlasSprite(lVar10,"UIAtlas","buildingicon_1",0),
                   lVar7 == null)) goto LAB_180ca5d6b;
                Image.set_sprite(lVar7,uVar6,0);
              }
            }
          }
          else {
            cVar2 = Object.op_Inequality(uVar6,0,0);
            if (cVar2) {
              if ((this.tFromStorage == null) ||
                 (lVar7 = Component.get_gameObject(this.tFromStorage,0)) == null)
              goto LAB_180ca5d6b;
              cVar2 = GameObject.get_activeSelf(lVar7,0);
              if (cVar2) {
                if ((this.tFromStorage == null) ||
                   (lVar7 = Component.get_gameObject(this.tFromStorage,0)) == null)
                goto LAB_180ca5d6b;
                GameObject.SetActive(lVar7,0,0);
              }
            }
          }
          lVar7 = this.itemData;
          if (lVar7 == null) goto LAB_180ca5d6b;
          if (lVar7.type == 3) {
            if ((lVar7.bookData == null) ||
               (lVar7 = BookData.DataBase(lVar7.bookData,0)) == null)
            goto LAB_180ca5d6b;
            if ((lVar7.subType == -1) || (this.hideItemBox)) {
              uVar6 = this.tForce;
              cVar2 = Object.op_Inequality(uVar6,0,0);
              if (cVar2) {
                if ((this.tForce == null) ||
                   (lVar7 = Component.get_gameObject(this.tForce,0)) == null)
                goto LAB_180ca5d6b;
                cVar2 = GameObject.get_activeSelf(lVar7,0);
                if (cVar2) {
                  if ((this.tForce == null) ||
                     (lVar7 = Component.get_gameObject(this.tForce,0)) == null)
                  goto LAB_180ca5d6b;
                  GameObject.SetActive(lVar7,0,0);
                }
              }
            }
            else {
              uVar6 = this.tForce;
              cVar2 = Object.op_Inequality(uVar6,0,0);
              if (cVar2) {
                if ((this.tForce == null) ||
                   (lVar7 = Component.get_gameObject(this.tForce,0)) == null)
                goto LAB_180ca5d6b;
                cVar2 = GameObject.get_activeSelf(lVar7,0);
                if (!cVar2) {
                  if ((this.tForce == null) ||
                     (lVar7 = Component.get_gameObject(this.tForce,0)) == null)
                  goto LAB_180ca5d6b;
                  GameObject.SetActive(lVar7,1,0);
                }
              }
              uVar6 = this.forceImage;
              cVar2 = Object.op_Inequality(uVar6,0,0);
              if (cVar2) {
                lVar7 = this.forceImage;
                lVar10 = FUN_18046c0a0(0);
                if (lVar10 == null) goto LAB_180ca5d6b;
                lVar10 = lVar10.villageAreaID;
                if (((((this.itemData == null) ||
                      (lVar11 = this.itemData.bookData) == null) ||
                     (lVar11 = BookData.DataBase(lVar11,0)) == null) ||
                    ((lVar10 == null ||
                     (lVar10 = WorldData.GetForce(lVar10,*(uint32 *)(lVar11 + 24),0)) == null)
                    )) || ((lVar10 = ForceData.DataBase(lVar10,0), lVar10 == null ||
                           (uVar6 = ForceData.GetForceIcon(lVar10,0), lVar7 == null)))) goto LAB_180ca5d6b;
                Image.set_sprite(lVar7,uVar6,0);
              }
            }
            uVar6 = this.tBookType;
            cVar2 = Object.op_Inequality(uVar6,0,0);
            if (cVar2) {
              if ((this.tBookType == null) ||
                 (lVar7 = Component.get_gameObject(this.tBookType,0)) == null)
              goto LAB_180ca5d6b;
              GameObject.SetActive(lVar7,1,0);
            }
            lVar7 = FUN_18046c100(0);
            if (lVar7 == null) goto LAB_180ca5d6b;
            lVar7 = GameDataController.FindBookTypeIconDataBase(lVar7,this.itemData,0);
            uVar6 = this.bookTypeImage;
            cVar2 = Object.op_Inequality(uVar6,0,0);
            if (cVar2) {
              lVar10 = this.bookTypeImage;
              lVar11 = *pStatics_b4a8;
              if (((this.itemData == null) ||
                  (lVar8 = this.itemData.bookData) == null) ||
                 (lVar8 = BookData.DataBase(lVar8,0)) == null) {
        LAB_180ca5d65:
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              local_res18[0] = *(uint32 *)(lVar8 + 48);
              uVar9 = il2cpp_value_box(DAT_181d80430,local_res18);
              uVar6 = "IconAtlas";
              if (lVar7 == null) goto LAB_180ca5d65;
              uVar14 = "d";
              if (!lVar7.name) {
                uVar14 = "";
              }
              uVar9 = String.Format("BookType_{0}{1}",uVar9,uVar14,0);
              if ((lVar11 == null) ||
                 (uVar6 = TextureController.LoadAtlasSprite(lVar11,uVar6,uVar9,0), lVar10 == null))
              goto LAB_180ca5d6b;
              Image.set_sprite(lVar10,uVar6,0);
              plVar12 = this.bookTypeImage;
              if (!lVar7.name) {
                uVar17 = *(uint64 *)(lVar7 + 36);
                uVar18 = *(uint64 *)(lVar7 + 44);
              }
              else {
                puVar5 = (uint64 *)FUN_1810d3b80(&local_68,0);
                uVar17 = *puVar5;
                uVar18 = puVar5[1];
              }
              if (plVar12 == (int64 *)0) goto LAB_180ca5d6b;
              local_68 = uVar17;
              uStack_60 = uVar18;
              (**(code **)(*plVar12 + 0x2a8))(plVar12,&local_68,*(uint64 *)(*plVar12 + 0x2b0));
            }
            uVar6 = this.tBookType;
            cVar2 = Object.op_Inequality(uVar6,0,0);
            if (cVar2) {
              if (lVar7 == null) goto LAB_180ca5d6b;
              local_78 = lVar7.subType;
              local_70 = 0;
              if (this.tBookType == null) goto LAB_180ca5d6b;
              uStack_60 = uStack_60 & 0xffffffff00000000;
              local_68 = local_78;
              Transform.set_localPosition(this.tBookType,&local_68,0);
            }
          }
          else {
            uVar6 = this.tForce;
            cVar2 = Object.op_Inequality(uVar6,0,0);
            if (cVar2) {
              if ((this.tForce == null) ||
                 (lVar7 = Component.get_gameObject(this.tForce,0)) == null)
              goto LAB_180ca5d6b;
              cVar2 = GameObject.get_activeSelf(lVar7,0);
              if (cVar2) {
                if ((this.tForce == null) ||
                   (lVar7 = Component.get_gameObject(this.tForce,0)) == null)
                goto LAB_180ca5d6b;
                GameObject.SetActive(lVar7,0,0);
              }
            }
            uVar6 = this.tBookType;
            cVar2 = Object.op_Inequality(uVar6,0,0);
            if (cVar2) {
              if ((this.tBookType == null) ||
                 (lVar7 = Component.get_gameObject(this.tBookType,0)) == null)
              goto LAB_180ca5d6b;
              cVar2 = GameObject.get_activeSelf(lVar7,0);
              if (cVar2) {
                if ((this.tBookType == null) ||
                   (lVar7 = Component.get_gameObject(this.tBookType,0)) == null)
                goto LAB_180ca5d6b;
                GameObject.SetActive(lVar7,0,0);
              }
            }
          }
        }
        uVar6 = *(uint64 *)(*(int64 *)(DAT_181d8b7a8 + 184) + 72);
        uVar9 = Component.get_gameObject(this,0);
        cVar2 = Object.op_Equality(uVar6,uVar9,0);
        if (cVar2) {
          if (this.itemData == null) goto LAB_180ca5d6b;
          this.itemData.isNew = 0;
        }
        uVar6 = this.tNew;
        cVar2 = Object.op_Inequality(uVar6,0,0);
        if (cVar2) {
          if ((this.tNew == null) ||
             (lVar7 = Component.get_gameObject(this.tNew,0)) == null)
          goto LAB_180ca5d6b;
          cVar2 = GameObject.get_activeSelf(lVar7,0);
          if (this.itemData == null) goto LAB_180ca5d6b;
          if (cVar2 != this.itemData.isNew) {
            if (this.tNew == null) goto LAB_180ca5d6b;
            lVar7 = Component.get_gameObject(this.tNew,0);
            if ((this.itemData == null) || (lVar7 == null)) goto LAB_180ca5d6b;
            GameObject.SetActive(lVar7,this.itemData.isNew,0);
          }
        }
        fVar15 = this.updateTime;
        if (0.0 < fVar15) {
          fVar16 = (float)Time.get_deltaTime(0);
          this.updateTime = fVar15 - fVar16;
          return;
        }
        uVar6 = this.tEquiped;
        this.updateTime = 0x3f000000;
        cVar2 = Object.op_Inequality(uVar6,0,0);
        if (cVar2) {
          if (this.tEquiped == null) goto LAB_180ca5d6b;
          lVar10 = Component.get_transform(this.tEquiped,0);
          lVar7 = this.itemData;
          if (lVar7 == null) goto LAB_180ca5d6b;
          if (lVar7.type == null) {
            if (lVar7.equipmentData == null) goto LAB_180ca5d6b;
            cVar2 = *(char *)(lVar7.equipmentData + 48);
        LAB_180ca4a94:
            if ((!cVar2) || (this.itemIconType == 4)) goto LAB_180ca4aa9;
            puVar5 = (uint64 *)Vector3.get_one(&local_68,0);
          }
          else {
            if (lVar7.type == 6) {
              if (lVar7.horseData == null) goto LAB_180ca5d6b;
              cVar2 = *(char *)(lVar7.horseData + 16);
              goto LAB_180ca4a94;
            }
        LAB_180ca4aa9:
            puVar5 = (uint64 *)Vector3.get_zero(&local_68,0);
          }
          if (lVar10 == null) goto LAB_180ca5d6b;
          uStack_60 = CONCAT44(uStack_60._4_4_,(int)puVar5[1]);
          local_68 = *puVar5;
          Transform.set_localScale(lVar10,&local_68,0);
        }
        if (this.itemIconType != 2) goto LAB_180ca5682;
        lVar7 = FUN_18046c6c0(0);
        if (lVar7 == null) goto LAB_180ca5d6b;
        if (lVar7.subType != null) {
          if (this.itemIconType != 2) goto LAB_180ca5682;
          if ((this.tradeIconType == 3) || (this.tradeIconType == 4)) {
            lVar7 = FUN_18046c6c0(0);
            if (lVar7 == null) goto LAB_180ca5d6b;
            if (lVar7.subType != 2) goto LAB_180ca53e5;
            uVar6 = this.tPrice;
            cVar2 = Object.op_Inequality(uVar6,0,0);
            if (cVar2) {
              if ((this.tPrice == null) ||
                 (lVar7 = Component.get_gameObject(this.tPrice,0)) == null)
              goto LAB_180ca5d6b;
              cVar2 = GameObject.get_activeSelf(lVar7,0);
              if (!cVar2) {
                if ((this.tPrice == null) ||
                   (lVar7 = Component.get_gameObject(this.tPrice,0)) == null)
                goto LAB_180ca5d6b;
                GameObject.SetActive(lVar7,1,0);
                this.needRefreshPriceIcon = 1;
              }
            }
            if (this.needRefreshPriceIcon) {
              uVar6 = this.priceIconImage;
              this.needRefreshPriceIcon = 0;
              cVar2 = Object.op_Inequality(uVar6,0,0);
              if (cVar2) {
                lVar7 = this.priceIconImage;
                lVar10 = FUN_18046c680(0);
                if ((lVar10 == null) ||
                   (uVar6 = TextureController.LoadAtlasSprite(lVar10,"UIAtlas","功绩",0),
                   lVar7 == null)) goto LAB_180ca5d6b;
                Image.set_sprite(lVar7,uVar6,0);
              }
            }
            uVar6 = this.priceText;
            cVar2 = Object.op_Inequality(uVar6,0,0);
            if (cVar2) {
              plVar12 = this.priceText;
              if (plVar12 == (int64 *)0) goto LAB_180ca5d6b;
              local_68 = ItemIconController.ContributionColor;
              uStack_60 = *(uint64 *)(pStatics_2130 + 24);
              (**(code **)(*plVar12 + 0x2a8))(plVar12,&local_68,*(uint64 *)(*plVar12 + 0x2b0));
            }
            uVar6 = this.priceText;
            cVar2 = Object.op_Inequality(uVar6,0,0);
            if (!cVar2) {
              return;
            }
            uVar6 = this.priceText;
            lVar7 = this.itemData;
            if (lVar7 == null) goto LAB_180ca5d6b;
            if (((GameController._instance == null) ||
                (lVar10 = GameController._instance.worldData) == null) ||
               (lVar10 = WorldData.GetHero(lVar10,0,0)) == null) goto LAB_180ca5d6b;
            if (!lVar10.hour) {
              uVar3 = Mathf.RoundToInt((float)lVar7.value * 0.1,0);
            }
            local_res8[0] = uVar3;
            uVar9 = Int32.ToString(local_res8,0);
            if ((*(byte *)(DAT_181d848b0 + 0x133) & 4) == 0) goto LAB_180ca53d2;
            iVar4 = *(int *)(DAT_181d848b0 + 224);
          }
          else {
        LAB_180ca53e5:
            if ((this.itemIconType == 2) &&
               ((this.tradeIconType == 3 || (this.tradeIconType == 4)))) {
              lVar7 = FUN_18046c6c0(0);
              if (lVar7 == null) goto LAB_180ca5d6b;
              if (lVar7.subType != 4) goto LAB_180ca5682;
              uVar6 = this.tPrice;
              cVar2 = Object.op_Inequality(uVar6,0,0);
              if (cVar2) {
                if ((this.tPrice == null) ||
                   (lVar7 = Component.get_gameObject(this.tPrice,0)) == null)
                goto LAB_180ca5d6b;
                cVar2 = GameObject.get_activeSelf(lVar7,0);
                if (!cVar2) {
                  if ((this.tPrice == null) ||
                     (lVar7 = Component.get_gameObject(this.tPrice,0)) == null)
                  goto LAB_180ca5d6b;
                  GameObject.SetActive(lVar7,1,0);
                  this.needRefreshPriceIcon = 1;
                }
              }
              if (this.needRefreshPriceIcon) {
                uVar6 = this.priceIconImage;
                this.needRefreshPriceIcon = 0;
                cVar2 = Object.op_Inequality(uVar6,0,0);
                if (cVar2) {
                  lVar7 = this.priceIconImage;
                  lVar10 = FUN_18046c680(0);
                  if ((lVar10 == null) ||
                     (uVar6 = TextureController.LoadAtlasSprite(lVar10,"UIAtlas","官府功绩",0),
                     lVar7 == null)) goto LAB_180ca5d6b;
                  Image.set_sprite(lVar7,uVar6,0);
                }
              }
              uVar6 = this.priceText;
              cVar2 = Object.op_Inequality(uVar6,0,0);
              if (cVar2) {
                plVar12 = this.priceText;
                if (plVar12 == (int64 *)0) goto LAB_180ca5d6b;
                local_68 = ItemIconController.GovernContributionColor;
                uStack_60 = *(uint64 *)(pStatics_2130 + 56);
                (**(code **)(*plVar12 + 0x2a8))(plVar12,&local_68,*(uint64 *)(*plVar12 + 0x2b0));
              }
              uVar6 = this.priceText;
              cVar2 = Object.op_Inequality(uVar6,0,0);
              if (!cVar2) {
                return;
              }
              uVar6 = this.priceText;
              if (this.itemData == null) goto LAB_180ca5d6b;
              local_res8[0] =
                   Mathf.RoundToInt((float)this.itemData.value * 0.1,0);
              uVar9 = Int32.ToString(local_res8,0);
            }
            else {
        LAB_180ca5682:
              uVar6 = this.tPrice;
              if (this.itemIconType != 5) {
                cVar2 = Object.op_Inequality(uVar6,0,0);
                if (!cVar2) {
                  return;
                }
                if ((this.tPrice != null) &&
                   (lVar7 = Component.get_gameObject(this.tPrice,0)) != null) {
                  cVar2 = GameObject.get_activeSelf(lVar7,0);
                  if (!cVar2) {
                    return;
                  }
                  if ((this.tPrice != null) &&
                     (lVar7 = Component.get_gameObject(this.tPrice,0)) != null) {
                    GameObject.SetActive(lVar7,0,0);
                    return;
                  }
                }
                goto LAB_180ca5d6b;
              }
              cVar2 = Object.op_Inequality(uVar6,0,0);
              if (cVar2) {
                if ((this.tPrice == null) ||
                   (lVar7 = Component.get_gameObject(this.tPrice,0)) == null)
                goto LAB_180ca5d6b;
                cVar2 = GameObject.get_activeSelf(lVar7,0);
                if (cVar2) {
                  if ((this.tPrice == null) ||
                     (lVar7 = Component.get_gameObject(this.tPrice,0)) == null)
                  goto LAB_180ca5d6b;
                  GameObject.SetActive(lVar7,0,0);
                }
              }
              lVar7 = Component.get_transform(this,0);
              if (((lVar7 == null) || (lVar7 = FUN_180daa030(lVar7,0)) == null) ||
                 (lVar7 = FUN_180daa030(lVar7,0)) == null) goto LAB_180ca5d6b;
              uVar6 = Transform.Find(lVar7,"PriceBack",0);
              cVar2 = Object.op_Inequality(uVar6,0,0);
              if (!cVar2) {
                return;
              }
              lVar7 = Component.get_transform(this,0);
              if (((lVar7 == null) || (lVar7 = FUN_180daa030(lVar7,0)) == null) ||
                 ((lVar7 = FUN_180daa030(lVar7,0), lVar7 == null ||
                  (((lVar7 = Transform.Find(lVar7,"PriceBack",0), lVar7 == null ||
                    (lVar7 = Transform.Find(lVar7,"Price",0)) == null) ||
                   (lVar10 = Component.get_gameObject(lVar7,0)) == null))))) goto LAB_180ca5d6b;
              cVar2 = GameObject.get_activeSelf(lVar10,0);
              if (!cVar2) {
                lVar10 = Component.get_gameObject(lVar7,0);
                if (lVar10 == null) goto LAB_180ca5d6b;
                GameObject.SetActive(lVar10,1,0);
                lVar10 = Transform.Find(lVar7,"PriceIcon",0);
                if (lVar10 == null) goto LAB_180ca5d6b;
                lVar10 = Component.GetComponent(lVar10,DAT_181d94478);
                lVar11 = FUN_18046c680(0);
                if ((lVar11 == null) ||
                   (uVar6 = TextureController.LoadAtlasSprite(lVar11,"UIAtlas","功绩",0),
                   lVar10 == null)) goto LAB_180ca5d6b;
                Image.set_sprite(lVar10,uVar6,0);
              }
              lVar10 = FUN_18046c0a0(0);
              if ((lVar10 == null) || (lVar10.villageAreaID == null)) goto LAB_180ca5d6b;
              lVar10 = WorldData.Player(lVar10.villageAreaID,0);
              if ((this.itemData == null) ||
                 ((lVar11 = this.itemData.bookData, lVar11 == null ||
                  (lVar10 == null)))) goto LAB_180ca5d6b;
              lVar10 = HeroData.FindSkill(lVar10,*(uint32 *)(lVar11 + 16),0);
              if (lVar10 != null) {
                plVar12 = (int64 *)Component.GetComponent(lVar7);
                puVar5 = (uint64 *)FUN_180d995f0(&local_68,0);
                if (plVar12 != (int64 *)0) {
                  local_68 = *puVar5;
                  uStack_60 = puVar5[1];
                  (**(code **)(*plVar12 + 0x2a8))(plVar12,&local_68,*(uint64 *)(*plVar12 + 0x2b0));
                  lVar10 = Transform.Find(lVar7,"PriceIcon",0);
                  if ((((lVar10 != null) &&
                       (lVar10 = Component.GetComponent(lVar10,DAT_181d94478)) != null) &&
                      (lVar10.plotHappened != null)) &&
                     (lVar10 = Object.get_name(lVar10.plotHappened,0)) != null) {
                    cVar2 = String.Contains(lVar10,"出战_出战",0);
                    if (cVar2) {
                      return;
                    }
                    lVar10 = Transform.Find(lVar7,"PriceIcon",0);
                    if (lVar10 != null) {
                      lVar10 = Component.GetComponent(lVar10,DAT_181d94478);
                      lVar11 = FUN_18046c680(0);
                      if ((lVar11 != null) &&
                         (uVar6 = TextureController.LoadAtlasSprite(lVar11,"UIAtlas","出战_出战",0)
                         , lVar10 != null)) {
                        Image.set_sprite(lVar10,uVar6,0);
                        puVar5 = (uint64 *)Transform.get_localPosition(&local_68,lVar7,0);
                        uVar17 = *puVar5;
                        local_70 = (uint32)puVar5[1];
                        lVar10 = Transform.get_localPosition(&local_78,lVar7,0);
                        local_70 = *(uint32 *)(lVar10 + 8);
                        uStack_60 = CONCAT44(uStack_60._4_4_,local_70);
                        local_68 = uVar17 & 0xffffffff00000000;
                        local_78 = uVar17;
                        Transform.set_localPosition(lVar7,&local_68,0);
                        lVar7 = Transform.Find(lVar7,"PriceIcon",0);
                        puVar13 = (uint64 *)Vector3.get_zero(&local_78,0);
                        if (lVar7 != null) {
                          local_68 = *puVar13;
                          uStack_60 = CONCAT44(uStack_60._4_4_,*(uint32 *)(puVar13 + 1));
                          Transform.set_localPosition(lVar7,&local_68,0);
                          return;
                        }
                      }
                    }
                  }
                }
                goto LAB_180ca5d6b;
              }
              plVar12 = (int64 *)Component.GetComponent(lVar7,DAT_181d96178);
              lVar10 = FUN_18046c0a0(0);
              if (((lVar10 == null) || (lVar10.villageAreaID == null)) ||
                 (lVar10 = WorldData.Player(lVar10.villageAreaID,0)) == null)
              goto LAB_180ca5d6b;
              fVar15 = lVar10.playerBookWriter;
              if (this.itemData == null) goto LAB_180ca5d6b;
              iVar4 = ItemData.GetReadBookContributionCost(this.itemData,0,0);
              if ((float)iVar4 <= fVar15) {
                uVar17 = ItemIconController.BookContributionColor;
                uVar18 = *(uint64 *)(pStatics_2130 + 40);
              }
              else {
                uVar17 = *(uint64 *)(pStatics_3d40 + 0x2e0);
                uVar18 = *(uint64 *)(pStatics_3d40 + 0x2e8);
              }
              if (plVar12 == (int64 *)0) goto LAB_180ca5d6b;
              local_68 = uVar17;
              uStack_60 = uVar18;
              (**(code **)(*plVar12 + 0x2a8))(plVar12,&local_68,*(uint64 *)(*plVar12 + 0x2b0));
              lVar10 = Component.GetComponent(lVar7,DAT_181d94af8);
              if (lVar10 == null) goto LAB_180ca5d6b;
              Behaviour.set_enabled(lVar10,0,0);
              uVar6 = Component.GetComponent(lVar7,DAT_181d96178);
              if (this.itemData == null) goto LAB_180ca5d6b;
              local_res8[0] = ItemData.GetReadBookContributionCost(this.itemData,0,0);
              uVar9 = Int32.ToString(local_res8,"f0",0);
            }
            if ((*(byte *)(DAT_181d848b0 + 0x133) & 4) == 0) goto LAB_180ca53d2;
            iVar4 = *(int *)(DAT_181d848b0 + 224);
          }
          if (iVar4 == 0) {
            il2cpp_runtime_class_init();
          }
        LAB_180ca53d2:
          LTLocalization.SetText(uVar6,uVar9,0);
          return;
        }
        uVar6 = this.tPrice;
        cVar2 = Object.op_Inequality(uVar6,0,0);
        if (cVar2) {
          if ((this.tPrice == null) ||
             (lVar7 = Component.get_gameObject(this.tPrice,0)) == null)
          goto LAB_180ca5d6b;
          cVar2 = GameObject.get_activeSelf(lVar7,0);
          if (!cVar2) {
            if ((this.tPrice == null) ||
               (lVar7 = Component.get_gameObject(this.tPrice,0)) == null)
            goto LAB_180ca5d6b;
            GameObject.SetActive(lVar7,1,0);
            this.needRefreshPriceIcon = 1;
          }
        }
        if (this.needRefreshPriceIcon) {
          uVar6 = this.priceIconImage;
          this.needRefreshPriceIcon = 0;
          cVar2 = Object.op_Inequality(uVar6,0,0);
          if (cVar2) {
            lVar7 = this.priceIconImage;
            lVar10 = FUN_18046c680(0);
            if ((lVar10 == null) ||
               (uVar6 = TextureController.LoadAtlasSprite(lVar10,"UIAtlas","银钱",0),
               lVar7 == null)) goto LAB_180ca5d6b;
            Image.set_sprite(lVar7,uVar6,0);
          }
        }
        uVar6 = this.priceText;
        cVar2 = Object.op_Inequality(uVar6,0,0);
        if (cVar2) {
          uVar6 = this.priceText;
          local_res8[0] =
               ItemIconController.GetItemPrice
                         (this,this.tradeIconType == 3 || this.tradeIconType == 4,0);
          uVar9 = Int32.ToString(local_res8,0);
          LTLocalization.SetText(uVar6,uVar9,0);
        }
        fVar15 = (float)ItemIconController.GetItemTreasureSpeRate(this,0);
        if (fVar15 != 1.0) {
          uVar6 = this.priceText;
          cVar2 = Object.op_Inequality(uVar6,0,0);
          if (!cVar2) {
            return;
          }
          plVar12 = this.priceText;
          fVar15 = (float)ItemIconController.GetItemTreasureSpeRate(this,0);
          if (fVar15 <= 1.0) {
            uVar6 = *(uint64 *)(pStatics_3d40 + 0x298);
            uVar9 = *(uint64 *)(pStatics_3d40 + 0x2a0);
          }
          else {
            uVar6 = *(uint64 *)(pStatics_3d40 + 0x300);
            uVar9 = *(uint64 *)(pStatics_3d40 + 0x308);
          }
          if (plVar12 == (int64 *)0) goto LAB_180ca5d6b;
          lVar7 = *plVar12;
          local_68 = uVar6;
          uStack_60 = uVar9;
          goto LAB_180ca4f89;
        }
        if ((this.tradeIconType == 3) || (this.tradeIconType == 4)) {
          lVar7 = FUN_18046c6c0(0);
          if (lVar7 == null) goto LAB_180ca5d6b;
          if (*(float *)(lVar7 + 180) == 1.0) goto LAB_180ca4d3f;
          uVar6 = this.priceText;
          cVar2 = Object.op_Inequality(uVar6,0,0);
          if (!cVar2) {
            return;
          }
          plVar12 = this.priceText;
          lVar7 = FUN_18046c6c0(0);
          if (lVar7 == null) goto LAB_180ca5d6b;
          fVar15 = *(float *)(lVar7 + 180);
        LAB_180ca4f09:
          if (fVar15 <= 1.0) {
            uVar6 = *(uint64 *)(pStatics_3d40 + 0x298);
            uVar9 = *(uint64 *)(pStatics_3d40 + 0x2a0);
          }
          else {
            uVar6 = *(uint64 *)(pStatics_3d40 + 0x300);
            uVar9 = *(uint64 *)(pStatics_3d40 + 0x308);
          }
          if (plVar12 == (int64 *)0) goto LAB_180ca5d6b;
        }
        else {
        LAB_180ca4d3f:
          if ((this.tradeIconType != 3) && (this.tradeIconType != 4)) {
            lVar7 = FUN_18046c6c0(0);
            if (lVar7 == null) goto LAB_180ca5d6b;
            if (*(float *)(lVar7 + 176) != 1.0) {
              uVar6 = this.priceText;
              cVar2 = Object.op_Inequality(uVar6,0,0);
              if (!cVar2) {
                return;
              }
              plVar12 = this.priceText;
              lVar7 = FUN_18046c6c0(0);
              if (lVar7 == null) goto LAB_180ca5d6b;
              fVar15 = *(float *)(lVar7 + 176);
              goto LAB_180ca4f09;
            }
          }
          uVar6 = this.priceText;
          cVar2 = Object.op_Inequality(uVar6,0,0);
          if (!cVar2) {
            return;
          }
          plVar12 = this.priceText;
          if (plVar12 == (int64 *)0) {
        LAB_180ca5d6b:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          uVar6 = **(uint64 **)(DAT_181d82130 + 184);
          uVar9 = (*(uint64 **)(DAT_181d82130 + 184))[1];
        }
        uStack_60 = uVar9;
        local_68 = uVar6;
        lVar7 = *plVar12;
        LAB_180ca4f89:
        (**(code **)(lVar7 + 0x2a8))(plVar12,&local_68,*(uint64 *)(lVar7 + 0x2b0));
    }

    // Token : 0x600187E
    // RVA   : 0xCA3840   Offset: 0xCA2C40   Length: 0x12
    public bool TradeIconTypeRight()
    {
        uint32 FUN_180ca3840(int64 this)
        {
        int iVar1;
        iVar1 = this.tradeIconType;
        if (iVar1 == 3) {
          return true;
        }
        return CONCAT31((int3)((uint32)iVar1 >> 8),iVar1 == 4);
    }

    // Token : 0x600187F
    // RVA   : 0xCA2590   Offset: 0xCA1990   Length: 0x14B
    public float GetItemAreaSpeRate()
    {
        long lVar1;
        ulong uVar2;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181dad390 + 184) + 8);
        if (lVar1 != null) {
          if (*(char *)(lVar1 + 32) == false) {
            return 0x3f800000;
          }
          lVar1 = *(int64 *)(*(int64 *)(DAT_181dac770 + 184) + 56);
          if (lVar1 != null) {
            uVar2 = AreaController.GetAreaSpePriceRate(lVar1,0);
            return uVar2;
          }
        }
    }

    // Token : 0x6001880
    // RVA   : 0xCA2AD0   Offset: 0xCA1ED0   Length: 0x31C
    public float GetItemTreasureSpeRate()
    {
        long lVar1;
        int iVar2;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181dad390 + 184) + 8);
        if (lVar1 != null) {
          if (*(char *)(lVar1 + 32) == false) {
            return 0x3f800000;
          }
          lVar1 = PlotController.SpringFestivelRewardLvTalkText;
          if (lVar1 != null) {
            if (*(int64 *)(lVar1 + 88) == 0) {
              return 0x3f800000;
            }
            if (this.itemData != null) {
              if (this.itemData.type != 4) {
                return 0x3f800000;
              }
              iVar2 = 0;
              while( true ) {
                lVar1 = PlotController.SpringFestivelRewardLvTalkText;
                if (((lVar1 == null) || (lVar1 = *(int64 *)(lVar1 + 88)) == null) ||
                   (lVar1 = *(int64 *)(lVar1 + 224)) == null) throw; // [null/range check failed]
                if (*(int *)(lVar1 + 24) <= iVar2) {
                  return 0x3f800000;
                }
                lVar1 = FUN_18046bac0(0);
                if (((lVar1 == null) || (*(int64 *)(lVar1 + 88) == 0)) ||
                   ((lVar1 = *(int64 *)(*(int64 *)(lVar1 + 88) + 224), lVar1 == null ||
                    ((lVar1 = FUN_180002f80(lVar1,iVar2,DAT_181d7ccf8), lVar1 == null ||
                     (this.itemData == null)))))) throw; // [null/range check failed]
                if (*(int *)(lVar1 + 16) == this.itemData.subType) break;
                iVar2 = iVar2 + 1;
              }
              lVar1 = FUN_18046bac0(0);
              if ((((lVar1 != null) && (*(int64 *)(lVar1 + 88) != 0)) &&
                  (lVar1 = *(int64 *)(*(int64 *)(lVar1 + 88) + 224)) != null) &&
                 (lVar1 = FUN_180002f80(lVar1,iVar2,DAT_181d7ccf8)) != null) {
                if (*(char *)(lVar1 + 20) == false) {
                  return 0x3f000000;
                }
                return 0x40000000;
              }
            }
          }
        }
    }

    // Token : 0x6001881
    // RVA   : 0xCA2380   Offset: 0xCA1780   Length: 0x208
    public float GetHeroFavorValueRate(bool buy)
    {
        long lVar1;
        long lVar2;
        ulong uVar3;
        lVar1 = PlotController.fightSkillIndexCache;
        if (lVar1 != null) {
          if (*(int *)(lVar1 + 24) != 0) {
            return 0x3f800000;
          }
          lVar1 = PlotController.fightSkillIndexCache;
          if (((lVar1 != null) && (lVar1 = *(int64 *)(lVar1 + 72)) != null) &&
             (lVar1 = *(int64 *)(lVar1 + 48)) != null) {
            if (*(int *)(lVar1 + 16) < 0) {
              return 0x3f800000;
            }
            lVar1 = FUN_18046c0a0(0);
            if (lVar1 != null) {
              lVar1 = *(int64 *)(lVar1 + 32);
              lVar2 = FUN_18046c6c0(0);
              if ((((lVar2 != null) && (*(int64 *)(lVar2 + 72) != 0)) &&
                  (lVar2 = *(int64 *)(*(int64 *)(lVar2 + 72) + 48)) != null) &&
                 ((lVar1 != null &&
                  (lVar1 = WorldData.GetHero(lVar1,*(uint32 *)(lVar2 + 16),0)) != null))) {
                uVar3 = HeroData.GetFavorValueRate(lVar1,buy,0);
                return uVar3;
              }
            }
          }
        }
    }

    // Token : 0x6001882
    // RVA   : 0xCA26E0   Offset: 0xCA1AE0   Length: 0x3EB
    public int GetItemPrice(bool buy)
    {
        int iVar1;
        long lVar2;
        float fVar3;
        float fVar4;
        float fVar5;
        float fVar6;
        float fVar7;
        if (this.itemData != null) {
          iVar1 = this.itemData.value;
          if ((GameController._instance != null) &&
             (lVar2 = GameController._instance.worldData) != null) {
            lVar2 = WorldData.Player(lVar2,0);
            if (lVar2 != null) {
              fVar3 = (float)HeroData.GetTradeValueRate(lVar2,buy,0);
              fVar4 = (float)ItemIconController.GetHeroFavorValueRate(this,buy,0);
              lVar2 = PlotController.fightSkillIndexCache;
              if (lVar2 != null) {
                if (!lVar2.villageAreaID) {
                  fVar7 = 1.0;
                }
                else {
                  lVar2 = *(int64 *)(*(int64 *)(DAT_181dac770 + 184) + 56);
                  if (lVar2 == null) throw; // [null/range check failed]
                  fVar7 = (float)AreaController.GetAreaSpePriceRate(lVar2,0);
                }
                fVar5 = (float)ItemIconController.GetItemTreasureSpeRate(this,0);
                if (!buy) {
                  lVar2 = PlotController.fightSkillIndexCache;
                  if (lVar2 == null) throw; // [null/range check failed]
                  fVar6 = lVar2.TimeDifficulty;
                }
                else {
                  lVar2 = PlotController.fightSkillIndexCache;
                  if (lVar2 == null) throw; // [null/range check failed]
                  fVar6 = lVar2.hour;
                }
                return (int)(fVar5 * (float)iVar1 * fVar3 * fVar4 * fVar7 * fVar6);
              }
            }
          }
        }
    }

    // Token : 0x6001883
    // RVA   : 0xCA1090   Offset: 0xCA0490   Length: 0xA44
    public static string BuildSortKey(ItemData itemData, int itemListID, ItemSortType sortType, bool reverseOrder)
    {
        uint64
        ItemIconController.BuildSortKey(int64 itemData,int itemListID,uint32 sortType,char reverseOrder)
        {
        uint64 uVar1;
        uint64 uVar2;
        uint64 uVar3;
        int64 *plVar4;
        int64 lVar5;
        int64 lVar6;
        uint64 uVar7;
        int64 *plVar8;
        float *pfVar9;
        int *piVar10;
        int local_res8 [2];
        int local_res10 [2];
        float local_48 [4];
        local_res10[0] = itemListID;
        local_48[0] = 0.0;
        local_res8[0] = 0;
        if (itemData == null) goto LAB_180ca18ce;
        uVar7 = "";
        switch(*(uint32 *)(itemData + 20)) {
        case 0:
          plVar4 = (int64 *)FUN_1800d60b0(DAT_181da5cf8,6);
          local_res8[0] = *(int *)(itemData + 20);
          lVar5 = Int32.ToString(local_res8,0);
          if (plVar4 == (int64 *)0) goto LAB_180ca18ce;
          if ((lVar5 != null) &&
             (lVar6 = il2cpp_internal(lVar5,*(uint64 *)(*plVar4 + 64))) == null) {
            uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar7,0);
          }
          if ((int)plVar4[3] == 0) {
            uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar7,0);
          }
          plVar4[4] = lVar5;
          il2cpp_internal(plVar4 + 4,lVar5);
          lVar5 = Int32.ToString(itemData + 24,0);
          if ((lVar5 != null) &&
             (lVar6 = il2cpp_internal(lVar5,*(uint64 *)(*plVar4 + 64))) == null) {
            uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar7,0);
          }
          if (*(uint32 *)(plVar4 + 3) < 2) {
            uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar7,0);
          }
          plVar4[5] = lVar5;
          il2cpp_internal(plVar4 + 5,lVar5);
          lVar5 = Int32.ToString(itemData + 60,0);
          if ((lVar5 != null) &&
             (lVar6 = il2cpp_internal(lVar5,*(uint64 *)(*plVar4 + 64))) == null) {
            uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar7,0);
          }
          if (*(uint32 *)(plVar4 + 3) < 3) {
            uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar7,0);
          }
          plVar4[6] = lVar5;
          il2cpp_internal(plVar4 + 6,lVar5);
          if (*(int64 *)(itemData + 96) == 0) goto LAB_180ca18ce;
          lVar5 = Int32.ToString(*(int64 *)(itemData + 96) + 20,0);
          if ((lVar5 != null) &&
             (lVar6 = il2cpp_internal(lVar5,*(uint64 *)(*plVar4 + 64))) == null) {
            uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar7,0);
          }
          if (*(uint32 *)(plVar4 + 3) < 4) {
            uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar7,0);
          }
          plVar4[7] = lVar5;
          il2cpp_internal(plVar4 + 7,lVar5);
          lVar5 = Int32.ToString(itemData + 16,"00",0);
          if ((lVar5 != null) &&
             (lVar6 = il2cpp_internal(lVar5,*(uint64 *)(*plVar4 + 64))) == null) {
            uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar7,0);
          }
          if (*(uint32 *)(plVar4 + 3) < 5) {
            uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar7,0);
          }
          plVar4[8] = lVar5;
          il2cpp_internal(plVar4 + 8,lVar5);
          lVar5 = Int32.ToString(itemData + 64,0);
          if ((lVar5 != null) &&
             (lVar6 = il2cpp_internal(lVar5,*(uint64 *)(*plVar4 + 64))) == null) {
            uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar7,0);
          }
          if (*(uint32 *)(plVar4 + 3) < 6) {
            uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar7,0);
          }
          plVar8 = plVar4 + 9;
          goto LAB_180ca1746;
        case 1:
          local_res8[0] = 1;
          break;
        case 2:
          local_res8[0] = 2;
          break;
        case 3:
          plVar4 = (int64 *)FUN_1800d60b0(DAT_181da5cf8,5);
          local_res8[0] = *(int *)(itemData + 20);
          lVar5 = Int32.ToString(local_res8,0);
          if (plVar4 == (int64 *)0) goto LAB_180ca18ce;
          if ((lVar5 != null) &&
             (lVar6 = il2cpp_internal(lVar5,*(uint64 *)(*plVar4 + 64))) == null) {
            uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar7,0);
          }
          if ((int)plVar4[3] == 0) {
            uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar7,0);
          }
          plVar4[4] = lVar5;
          il2cpp_internal(plVar4 + 4,lVar5);
          lVar5 = Int32.ToString(itemData + 60,0);
          if ((lVar5 != null) &&
             (lVar6 = il2cpp_internal(lVar5,*(uint64 *)(*plVar4 + 64))) == null) {
            uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar7,0);
          }
          if (*(uint32 *)(plVar4 + 3) < 2) {
            uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar7,0);
          }
          plVar4[5] = lVar5;
          il2cpp_internal(plVar4 + 5,lVar5);
          if ((*(int64 *)(itemData + 112) == 0) ||
             (lVar5 = BookData.DataBase(*(int64 *)(itemData + 112),0)) == null)
          goto LAB_180ca18ce;
          lVar5 = Int32.ToString(lVar5 + 48,0);
          if ((lVar5 != null) &&
             (lVar6 = il2cpp_internal(lVar5,*(uint64 *)(*plVar4 + 64))) == null) {
            uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar7,0);
          }
          if (*(uint32 *)(plVar4 + 3) < 3) {
            uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar7,0);
          }
          plVar4[6] = lVar5;
          il2cpp_internal(plVar4 + 6,lVar5);
          if (*(int64 *)(itemData + 112) == 0) goto LAB_180ca18ce;
          lVar5 = Int32.ToString(*(int64 *)(itemData + 112) + 16,"0000",0);
          if ((lVar5 != null) &&
             (lVar6 = il2cpp_internal(lVar5,*(uint64 *)(*plVar4 + 64))) == null) {
            uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar7,0);
          }
          if (*(uint32 *)(plVar4 + 3) < 4) {
            uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar7,0);
          }
          plVar4[7] = lVar5;
          il2cpp_internal(plVar4 + 7,lVar5);
          lVar5 = Int32.ToString(itemData + 64,0);
          if ((lVar5 != null) &&
             (lVar6 = il2cpp_internal(lVar5,*(uint64 *)(*plVar4 + 64))) == null) {
            uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar7,0);
          }
          if (*(uint32 *)(plVar4 + 3) < 5) {
            uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar7,0);
          }
          goto LAB_180ca1742;
        case 4:
          local_res8[0] = 4;
          uVar2 = Int32.ToString(local_res8,0);
          uVar3 = Int32.ToString(itemData + 24,0);
          uVar7 = Int32.ToString(itemData + 60,0);
          if (*(int64 *)(itemData + 120) == 0) goto LAB_180ca18ce;
          uVar1 = "99";
          if (*(char *)(*(int64 *)(itemData + 120) + 16) != false) {
            uVar1 = Int32.ToString(itemData + 64,0);
          }
          goto LAB_180ca1374;
        case 5:
          local_res8[0] = 5;
          uVar2 = Int32.ToString(local_res8,0);
          uVar3 = Int32.ToString(itemData + 24,0);
          uVar7 = Int32.ToString(itemData + 60,0);
          goto LAB_180ca1360;
        case 6:
          plVar4 = (int64 *)FUN_1800d60b0(DAT_181da5cf8,5);
          local_res8[0] = *(int *)(itemData + 20);
          lVar5 = Int32.ToString(local_res8,0);
          if (plVar4 == (int64 *)0) goto LAB_180ca18ce;
          if ((lVar5 != null) &&
             (lVar6 = il2cpp_internal(lVar5,*(uint64 *)(*plVar4 + 64))) == null) {
            uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar7,0);
          }
          if ((int)plVar4[3] == 0) {
            uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar7,0);
          }
          plVar4[4] = lVar5;
          il2cpp_internal(plVar4 + 4,lVar5);
          lVar5 = Int32.ToString(itemData + 24,0);
          if ((lVar5 != null) &&
             (lVar6 = il2cpp_internal(lVar5,*(uint64 *)(*plVar4 + 64))) == null) {
            uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar7,0);
          }
          if (*(uint32 *)(plVar4 + 3) < 2) {
            uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar7,0);
          }
          plVar4[5] = lVar5;
          il2cpp_internal(plVar4 + 5,lVar5);
          lVar5 = Int32.ToString(itemData + 60,0);
          if ((lVar5 != null) &&
             (lVar6 = il2cpp_internal(lVar5,*(uint64 *)(*plVar4 + 64))) == null) {
            uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar7,0);
          }
          if (*(uint32 *)(plVar4 + 3) < 3) {
            uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar7,0);
          }
          plVar4[6] = lVar5;
          il2cpp_internal(plVar4 + 6,lVar5);
          lVar5 = Int32.ToString(itemData + 16,"00",0);
          if ((lVar5 != null) &&
             (lVar6 = il2cpp_internal(lVar5,*(uint64 *)(*plVar4 + 64))) == null) {
            uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar7,0);
          }
          if (*(uint32 *)(plVar4 + 3) < 4) {
            uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar7,0);
          }
          plVar4[7] = lVar5;
          il2cpp_internal(plVar4 + 7,lVar5);
          lVar5 = Int32.ToString(itemData + 64,0);
          if ((lVar5 != null) &&
             (lVar6 = il2cpp_internal(lVar5,*(uint64 *)(*plVar4 + 64))) == null) {
            uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar7,0);
          }
          if (*(uint32 *)(plVar4 + 3) < 5) {
            uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar7,0);
          }
        LAB_180ca1742:
          plVar8 = plVar4 + 8;
        LAB_180ca1746:
          *plVar8 = lVar5;
          il2cpp_internal(plVar8,lVar5);
          uVar7 = String.Concat(plVar4,0);
        default:
          goto switchD_180ca115d_default;
        }
        uVar2 = Int32.ToString(local_res8,0);
        uVar3 = Int32.ToString(itemData + 60,0);
        uVar7 = Int32.ToString(itemData + 16,"00",0);
        LAB_180ca1360:
        uVar1 = Int32.ToString(itemData + 64,0);
        LAB_180ca1374:
        uVar7 = String.Concat(uVar2,uVar3,uVar7,uVar1,0);
        switchD_180ca115d_default:
        switch(sortType) {
        case 0:
          if (!reverseOrder) {
            uVar2 = Int32.ToString(local_res10,"00000",0);
          }
          else {
            local_res8[0] = 99999 - local_res10[0];
            uVar2 = Int32.ToString(local_res8,"00000",0);
          }
          break;
        case 1:
          local_res8[0] = 9 - *(int *)(itemData + 20);
          if (!reverseOrder) {
            local_res8[0] = *(int *)(itemData + 20);
          }
          uVar2 = Int32.ToString(local_res8,0);
          break;
        case 2:
          piVar10 = (int *)(itemData + 60);
          if (reverseOrder) {
            local_res8[0] = 9 - *piVar10;
            piVar10 = local_res8;
          }
          uVar2 = Int32.ToString(piVar10,0);
          break;
        case 3:
          if (*(int *)(itemData + 20) == 4) {
            if (*(int64 *)(itemData + 120) == 0) {
        LAB_180ca18ce:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            uVar2 = "99";
            if (*(char *)(*(int64 *)(itemData + 120) + 16) == false) break;
          }
          if (!reverseOrder) {
            uVar2 = Int32.ToString(itemData + 64,0);
          }
          else {
            local_res8[0] = 9 - *(int *)(itemData + 64);
            uVar2 = Int32.ToString(local_res8,0);
          }
          break;
        case 4:
          piVar10 = (int *)(itemData + 56);
          if (reverseOrder) {
            local_res8[0] = 99999 - *piVar10;
            piVar10 = local_res8;
          }
          uVar2 = Int32.ToString(piVar10,"00000",0);
          break;
        case 5:
          pfVar9 = (float *)(itemData + 68);
          if (reverseOrder) {
            local_48[0] = 999.0 - *pfVar9;
            pfVar9 = local_48;
          }
          uVar2 = Single.ToString(pfVar9,"000",0);
          break;
        default:
          goto switchD_180ca177a_default;
        }
        uVar7 = String.Concat(uVar2,uVar7,0);
        switchD_180ca177a_default:
        return uVar7;
    }

    // Token : 0x6001884
    // RVA   : 0xCA0FD0   Offset: 0xCA03D0   Length: 0xA7
    public void AutoSetName(ItemSortType sortType, bool reverseOrder)
    {
        uint uVar1;
        ulong uVar2;
        uVar2 = this.itemData;
        uVar1 = this.itemListID;
        uVar2 = ItemIconController.BuildSortKey(uVar2,uVar1,sortType,reverseOrder,0);
        Object.set_name(this,uVar2,0);
    }

    // Token : 0x6001885
    // RVA   : 0xCA2DF0   Offset: 0xCA21F0   Length: 0xF4
    public void OnClick()
    {
        var pStatics_5f40 = *(int64*)(DAT_181d75f40 + 184);
        var pStatics_b440 = *(int64*)(DAT_181dbb440 + 184);
        int iVar1;
        bool cVar2;
        ulong uVar3;
        ulong uVar4;
        long lVar5;
        long lVar6;
        uint uVar10;
        ulong in_stack_ffffffffffffffc8;
        ulong local_28;
        uint local_20;
        byte[] local_18 = new byte[16];
        if (this.itemData == null) goto LAB_180ca3758;
        ItemData.PlayItemSound(this.itemData,0);
        if (*pStatics_b440 == 0) goto LAB_180ca3758;
        if (*(int *)(*pStatics_b440 + 24) != 1) {
          switch(this.itemIconType) {
          case 0:
            if (this.itemData != null) {
              switch(this.itemData.type) {
              case 0:
              case 6:
                goto switchD_180ca2f0d_caseD_0;
              case 1:
              case 2:
                lVar6 = FUN_180af2380(0);
                lVar5 = FUN_1807789a0(0);
                if (lVar5 != null) {
                  uVar4 = lVar5.BigMapRandomEventDatas;
                  uVar3 = Component.get_gameObject(this,0);
                  if (lVar6 != null) {
                    ItemUseMenuController.Show(lVar6,uVar4,uVar3,0);
                    return;
                  }
                }
                break;
              default:
                return;
              }
            }
            break;
          default:
            return;
          case 2:
            lVar6 = FUN_18046c6c0(0);
            uVar4 = Component.get_gameObject(this,0);
            if (lVar6 != null) {
              TradeUIController.TradeIconClicked(lVar6,uVar4,0);
              return;
            }
            break;
          case 3:
            lVar6 = **(int64 **)(DAT_181db7530 + 184);
            uVar4 = Component.get_gameObject(this,0);
            if (lVar6 != null) {
              ChooseController.ChooseObj(lVar6,uVar4,0);
              return;
            }
            break;
          case 4:
            lVar6 = FUN_1807789a0(0);
            if ((lVar6 != null) && (lVar6.equipmentData != null)) {
              HeroData.UnequipItem(lVar6.equipmentData,this.itemData,1,0,0);
              return;
            }
            break;
          case 5:
            lVar6 = **(int64 **)(DAT_181d99c98 + 184);
            if (((GameController._instance != null) &&
                (lVar5 = GameController._instance.worldData) != null) &&
               (uVar4 = WorldData.Player(lVar5,0), lVar6 != null)) {
              ReadBookController.StartReadBook
                        (lVar6,uVar4,this.itemData,1,
                         in_stack_ffffffffffffffc8 & 0xffffffffffffff00,0);
              return;
            }
            break;
          case 6:
            lVar6 = **(int64 **)(DAT_181d7edc8 + 184);
            lVar5 = Component.get_gameObject(this,0);
            if (lVar6 != null) {
              if (lVar6.subType != 2) {
                return;
              }
              lVar6.rareLv = lVar5;
              if ((lVar6.describe != null) &&
                 (lVar5 = GameObject.GetComponent(lVar6.describe,DAT_181dc7c18)) != null
                 ) {
                Selectable.set_interactable(lVar5,1,0);
                if (lVar6.checkName != null) {
                  GameObject.SetActive(lVar6.checkName,1,0);
                  if (lVar6.checkName != null) {
                    lVar6 = GameObject.get_transform(lVar6.checkName,0);
                    if (((*plVar8 != 0) && (lVar5 = GameObject.get_transform(*plVar8,0)) != null) &&
                       (puVar7 = (uint64 *)Transform.get_position(local_18,lVar5,0), lVar6 != null)) {
                      local_28 = *puVar7;
                      local_20 = *(uint32 *)(puVar7 + 1);
                      Transform.set_position(lVar6,&local_28,0);
                      return;
                    }
                  }
                }
              }
            }
          }
          goto LAB_180ca3758;
        }
        if (this.itemIconType == null)
        {
          lVar6 = this.itemData;
          if (lVar6 == null) goto LAB_180ca3758;
          if (lVar6.type == null) {
          if (lVar6.equipmentData == null) goto LAB_180ca3758;
          cVar2 = *(char *)(lVar6.equipmentData + 48);
          joined_r0x000180ca368b:
          if (cVar2) {
        }
            plVar8 = (int64 *)Resources.Load("Sound/SoundEffect/WrongClick",0);
            plVar9 = (int64 *)0;
            if ((plVar8 != (int64 *)0) && (*plVar8 == DAT_181daf360)) {
              plVar9 = plVar8;
            }
            NGUITools.PlaySound(plVar9,0);
            return;
          }
        }
        else if (lVar6.type == 6) {
          if (lVar6.horseData == null) goto LAB_180ca3758;
          cVar2 = *(char *)(lVar6.horseData + 16);
          goto joined_r0x000180ca368b;
        }
        if ((*pStatics_5f40 != 0) &&
           (lVar6 = *(int64 *)(*pStatics_5f40 + 96)) != null) {
          HeroData.LoseItem(lVar6,this.itemData,1,0);
          lVar6 = *pStatics_5f40;
          if ((*pStatics_5f40 != 0) && (lVar6 != null)) {
            HeroDetailController.FreshNowHeroDetail
                      (lVar6,*(uint64 *)(*pStatics_5f40 + 96),0,0);
            return;
          }
        }
        LAB_180ca3758:
                          // WARNING: Subroutine does not return
        FUN_1800d6620();
        switchD_180ca2f0d_caseD_0:
        cVar2 = FUN_1804625f0(0x130,0);
        uVar10 = 0;
        if (cVar2) {
          if (this.itemData == null) goto LAB_180ca3758;
          cVar2 = ItemData.Equiped(this.itemData,0);
          if (!cVar2) {
            lVar6 = this.itemData;
            if (lVar6 == null) goto LAB_180ca3758;
            if (lVar6.type == null) {
              lVar6 = FUN_1807789a0(0);
              if (((lVar6 == null) || (lVar6.equipmentData == null)) ||
                 (lVar6 = *(int64 *)(lVar6.equipmentData + 0x1f8)) == null)
              goto LAB_180ca3758;
              lVar6 = lVar6.name;
              if (this.itemData == null) goto LAB_180ca3758;
              iVar1 = this.itemData.subType;
              if (iVar1 == 0) {
                lVar6 = FUN_1807789a0(0);
                if (((lVar6 == null) || (lVar6.equipmentData == null)) ||
                   (lVar6 = *(int64 *)(lVar6.equipmentData + 0x1f8)) == null)
                goto LAB_180ca3758;
                lVar6 = lVar6.name;
              }
              else if (iVar1 == 1) {
                lVar6 = FUN_1807789a0(0);
                if (((lVar6 == null) || (lVar6.equipmentData == null)) ||
                   (lVar6 = *(int64 *)(lVar6.equipmentData + 0x1f8)) == null)
                goto LAB_180ca3758;
                lVar6 = lVar6.value;
              }
              else if (iVar1 == 2) {
                lVar6 = FUN_1807789a0(0);
                if (((lVar6 == null) || (lVar6.equipmentData == null)) ||
                   (lVar6 = *(int64 *)(lVar6.equipmentData + 0x1f8)) == null)
                goto LAB_180ca3758;
                lVar6 = lVar6.poisonNumDetected;
              }
              else if (iVar1 == 3) {
                lVar6 = FUN_1807789a0(0);
                if (((lVar6 == null) || (lVar6.equipmentData == null)) ||
                   (lVar6 = *(int64 *)(lVar6.equipmentData + 0x1f8)) == null)
                goto LAB_180ca3758;
                lVar6 = lVar6.medFoodData;
              }
              else if (iVar1 == 4) {
                lVar6 = FUN_1807789a0(0);
                if (((lVar6 == null) || (lVar6.equipmentData == null)) ||
                   (lVar6 = *(int64 *)(lVar6.equipmentData + 0x1f8)) == null)
                goto LAB_180ca3758;
                lVar6 = lVar6.materialData;
              }
              if (lVar6 == null) goto LAB_180ca3758;
              lVar5 = 32;
              for (; (int)uVar10 < (int)lVar6.subType; uVar10 = uVar10 + 1) {
                if (lVar6.subType <= uVar10) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                if (*(int64 *)(lVar6.itemID + lVar5) == 0) goto LAB_180ca3291;
                lVar5 = lVar5 + 8;
              }
              lVar5 = FUN_1807789a0(0);
              if (lVar5 == null) goto LAB_180ca3758;
              lVar5 = lVar5.BigMapRandomEventDatas;
              if (lVar6.subType == null) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              if (lVar5 == null) goto LAB_180ca3758;
              uVar4 = *(uint64 *)(lVar6.itemID + 32);
        LAB_180ca3281:
              HeroData.UnequipItem(lVar5,uVar4,0,0,0);
            }
            else if (lVar6.subType == null) {
              lVar6 = FUN_1807789a0(0);
              if ((lVar6 == null) || (lVar6.equipmentData == null)) goto LAB_180ca3758;
              if (*(int64 *)(lVar6.equipmentData + 0x208) != 0) {
                lVar6 = FUN_1807789a0(0);
                if (lVar6 == null) goto LAB_180ca3758;
                lVar5 = lVar6.equipmentData;
                lVar6 = FUN_1807789a0(0);
                if (((lVar6 == null) || (lVar6.equipmentData == null)) || (lVar5 == null))
                goto LAB_180ca3758;
                uVar4 = *(uint64 *)(lVar6.equipmentData + 0x208);
                goto LAB_180ca3281;
              }
            }
            else if (lVar6.subType == 1) {
              lVar6 = FUN_1807789a0(0);
              if ((lVar6 == null) || (lVar6.equipmentData == null)) goto LAB_180ca3758;
              if (*(int64 *)(lVar6.equipmentData + 0x218) != 0) {
                lVar6 = FUN_1807789a0(0);
                if (lVar6 == null) goto LAB_180ca3758;
                lVar5 = lVar6.equipmentData;
                lVar6 = FUN_1807789a0(0);
                if (((lVar6 == null) || (lVar6.equipmentData == null)) || (lVar5 == null))
                goto LAB_180ca3758;
                uVar4 = *(uint64 *)(lVar6.equipmentData + 0x218);
                goto LAB_180ca3281;
              }
            }
        LAB_180ca3291:
            lVar6 = FUN_180c960b0(0);
            if (lVar6 == null) goto LAB_180ca3758;
            *(uint8 *)(lVar6 + 192) = 1;
          }
        }
        lVar6 = FUN_1807789a0(0);
        if ((lVar6 != null) && (lVar6.equipmentData != null)) {
          HeroData.EquipItem(lVar6.equipmentData,this.itemData,1,1,0);
          return;
        }
        goto LAB_180ca3758;
    }

    // Token : 0x6001886
    // RVA   : 0xCA37A0   Offset: 0xCA2BA0   Length: 0x90
    public void ResetForPool()
    {
        long lVar1;
        ulong local_28;
        uint local_20;
        byte[] local_18 = new byte[16];
        lVar1 = Component.get_transform(this,0);
        puVar2 = (uint64 *)Vector3.get_one(local_18,0);
        if (lVar1 != null) {
          local_20 = *(uint32 *)(puVar2 + 1);
          local_28 = *puVar2;
          Transform.set_localScale(lVar1,&local_28,0);
          this.itemData = 0;
          this.fromStorage = 0;
          this.itemListID = 0xffffffff;
          this.itemIconType = 1;
          this.inited = 0x1000000;
          this.updateTime = 0;
          return;
        }
    }

    // Token : 0x6001887
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

    // Token : 0x6001888
    // RVA   : 0xCA5D80   Offset: 0xCA5180   Length: 0x13C
    private static void /*cctor*/()
    {
        var pStatics = *(int64*)(DAT_181d82130 + 184);
        long lVar2;
        ulong local_48;
        ulong uStack_40;
        ulong local_38;
        ulong uStack_30;
        ulong local_28;
        ulong uStack_20;
        ulong local_18;
        ulong uStack_10;
        local_48 = 0;
        uStack_40 = 0;
        Color.ctor(&local_48,0x3ebebebf,0x3ecacacb,0x3edadadb,0);
        puVar1 = *(uint32 **)(DAT_181d82130 + 184);
        *puVar1 = (uint32)local_48;
        puVar1[1] = local_48._4_4_;
        puVar1[2] = (uint32)uStack_40;
        puVar1[3] = uStack_40._4_4_;
        local_38 = 0;
        uStack_30 = 0;
        Color.ctor(&local_38,0x3dc8c8c9,0x3ef6f6f7,0x3e9a9a9b,0);
        lVar2 = pStatics;
        *(uint32 *)(lVar2 + 16) = (uint32)local_38;
        *(uint32 *)(lVar2 + 20) = local_38._4_4_;
        *(uint32 *)(lVar2 + 24) = (uint32)uStack_30;
        *(uint32 *)(lVar2 + 28) = uStack_30._4_4_;
        local_28 = 0;
        uStack_20 = 0;
        Color.ctor(&local_28,0x3edcdcdd,0x3f47c7c8,0x3f1f9fa0,0);
        lVar2 = pStatics;
        *(uint32 *)(lVar2 + 32) = (uint32)local_28;
        *(uint32 *)(lVar2 + 36) = local_28._4_4_;
        *(uint32 *)(lVar2 + 40) = (uint32)uStack_20;
        *(uint32 *)(lVar2 + 44) = uStack_20._4_4_;
        local_18 = 0;
        uStack_10 = 0;
        Color.ctor(&local_18,0x3f2eaeaf,0x3eeaeaeb,0,0);
        lVar2 = pStatics;
        *(uint64 *)(lVar2 + 48) = local_18;
        *(uint64 *)(lVar2 + 56) = uStack_10;
    }

}
