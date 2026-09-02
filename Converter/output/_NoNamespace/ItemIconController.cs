// ============================================================
// Type  : ItemIconController
// Token : 0x20002E9
// ============================================================

public class ItemIconController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400176B
    public int itemListID;

    // Token: 0x400176C
    public ItemData itemData;

    // Token: 0x400176D
    public ItemIconType itemIconType;

    // Token: 0x400176E
    public TradeIconType tradeIconType;

    // Token: 0x400176F
    private float updateTime;

    // Token: 0x4001770
    private static Color PriceColor;

    // Token: 0x4001771
    private static Color ContributionColor;

    // Token: 0x4001772
    private static Color BookContributionColor;

    // Token: 0x4001773
    private static Color GovernContributionColor;

    // Token: 0x4001774
    public bool inited;

    // Token: 0x4001775
    public bool hideItemName;

    // Token: 0x4001776
    public bool hideItemBox;

    // Token: 0x4001777
    public bool needRefreshPriceIcon;

    // Token: 0x4001778
    public string fromStorage;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001836
    // RVA   : 0xB78B20   Offset: 0xB77320   Length: 0x2578
    private void Update()
    {
        var pStatics_6270 = *(int64*)(DAT_181d86270 + 184);
        var pStatics_cff8 = *(int64*)(DAT_181d5cff8 + 184);
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        var pStatics_ef00 = *(int64*)(DAT_181d4ef00 + 184);
        ulong uVar1;
        uint uVar2;
        bool cVar3;
        byte uVar4;
        int iVar5;
        long lVar6;
        ulong uVar7;
        ulong uVar10;
        long lVar11;
        long lVar12;
        long lVar13;
        ulong uVar16;
        float fVar17;
        float fVar18;
        uint uVar19;
        uint uVar20;
        uint uVar21;
        uint uVar22;
        uint[] local_res8 = new uint[2];
        uint[] local_res18 = new uint[2];
        ulong local_88;
        uint local_80;
        byte[] local_78 = new byte[16];
        ulong local_68;
        ulong uStack_60;
        if (!this.inited) {
          this.inited = 1;
          lVar6 = Component.get_transform(this,0);
          if ((lVar6 == null) || (lVar6 = Transform.Find(lVar6,"Name",0)) == null)
          throw; // [null/range check failed]
          uVar7 = Component.GetComponent(lVar6,DAT_181d6d8c0);
          uVar10 = "";
          if (!this.hideItemName) {
            if (this.itemData == null) throw; // [null/range check failed]
            uVar10 = ItemData.Name(this.itemData,0,0);
          }
          LTLocalization.SetText(uVar7,uVar10,0);
          if (!this.hideItemBox) {
            lVar6 = Component.get_transform(this,0);
            if ((lVar6 == null) || (lVar6 = Transform.Find(lVar6,"Back",0)) == null)
            throw; // [null/range check failed]
            plVar8 = (int64 *)Component.GetComponent(lVar6,DAT_181d6bc40);
            puVar9 = (uint64 *)FUN_181098a50(&local_68,0);
            if (plVar8 == (int64 *)0) throw; // [null/range check failed]
            local_68 = *puVar9;
            uStack_60 = puVar9[1];
            (**(code **)(*plVar8 + 0x2a8))(plVar8,&local_68,*(uint64 *)(*plVar8 + 0x2b0));
            lVar6 = Component.get_transform(this,0);
            if ((lVar6 == null) || (lVar6 = Transform.Find(lVar6,"ItemLv",0)) == null)
            throw; // [null/range check failed]
            plVar8 = (int64 *)Component.GetComponent(lVar6,DAT_181d6bc40);
            if (**(int **)(DAT_181d4ef00 + 184) == 2) {
              if (this.itemData == null) throw; // [null/range check failed]
              if (this.itemData.itemLv != 5) goto LAB_180b78f2f;
              local_68 = 0;
              uStack_60 = 0;
              Color.ctor(&local_68,0x3f800000,0x3ed2d2d3,0x3f34b4b5,0);
              uVar19 = (uint32)local_68;
              uVar20 = local_68._4_4_;
              uVar21 = (uint32)uStack_60;
              uVar22 = uStack_60._4_4_;
            }
            else {
        LAB_180b78f2f:
              lVar6 = FUN_18046c100(0);
              if (((lVar6 == null) || (this.itemData == null)) ||
                 (lVar6 = lVar6.value) == null) throw; // [null/range check failed]
              uVar2 = this.itemData.itemLv;
              if (lVar6.subType <= uVar2) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar6 = lVar6.itemID[uVar2];
              if (lVar6 == null) throw; // [null/range check failed]
              uVar19 = lVar6.subType;
              uVar20 = *(uint32 *)(lVar6 + 28);
              uVar21 = lVar6.name;
              uVar22 = *(uint32 *)(lVar6 + 36);
            }
            local_68 = CONCAT44(uVar20,uVar19);
            uStack_60 = CONCAT44(uVar22,uVar21);
            puVar9 = (uint64 *)GlobalData.SetColorAlpha(local_78,&local_68,0x3f666666,0);
            if (plVar8 == (int64 *)0) throw; // [null/range check failed]
            local_68 = *puVar9;
            uStack_60 = puVar9[1];
            (**(code **)(*plVar8 + 0x2a8))(plVar8,&local_68,*(uint64 *)(*plVar8 + 0x2b0));
            lVar6 = Component.get_transform(this,0);
            if ((lVar6 == null) || (lVar6 = Transform.Find(lVar6,"Cover",0)) == null)
            throw; // [null/range check failed]
            plVar8 = (int64 *)Component.GetComponent(lVar6,DAT_181d6bc40);
            puVar9 = (uint64 *)FUN_181098a50(&local_68,0);
          }
          else {
            lVar6 = Component.get_transform(this,0);
            if ((lVar6 == null) || (lVar6 = Transform.Find(lVar6,"Back",0)) == null)
            throw; // [null/range check failed]
            plVar8 = (int64 *)Component.GetComponent(lVar6,DAT_181d6bc40);
            puVar9 = (uint64 *)FUN_180d904c0(&local_68,0);
            if (plVar8 == (int64 *)0) throw; // [null/range check failed]
            local_68 = *puVar9;
            uStack_60 = puVar9[1];
            (**(code **)(*plVar8 + 0x2a8))(plVar8,&local_68,*(uint64 *)(*plVar8 + 0x2b0));
            lVar6 = Component.get_transform(this,0);
            if ((lVar6 == null) || (lVar6 = Transform.Find(lVar6,"ItemLv",0)) == null)
            throw; // [null/range check failed]
            plVar8 = (int64 *)Component.GetComponent(lVar6,DAT_181d6bc40);
            puVar9 = (uint64 *)FUN_180d904c0(&local_68,0);
            if (plVar8 == (int64 *)0) throw; // [null/range check failed]
            local_68 = *puVar9;
            uStack_60 = puVar9[1];
            (**(code **)(*plVar8 + 0x2a8))(plVar8,&local_68,*(uint64 *)(*plVar8 + 0x2b0));
            lVar6 = Component.get_transform(this,0);
            if ((lVar6 == null) || (lVar6 = Transform.Find(lVar6,"Cover",0)) == null)
            throw; // [null/range check failed]
            plVar8 = (int64 *)Component.GetComponent(lVar6,DAT_181d6bc40);
            puVar9 = (uint64 *)FUN_180d904c0(&local_68,0);
          }
          if (plVar8 == (int64 *)0) throw; // [null/range check failed]
          local_68 = *puVar9;
          uStack_60 = puVar9[1];
          (**(code **)(*plVar8 + 0x2a8))(plVar8,&local_68,*(uint64 *)(*plVar8 + 0x2b0));
          lVar6 = Component.get_transform(this,0);
          if ((lVar6 == null) || (lVar6 = Transform.Find(lVar6,"RareLv",0)) == null)
          throw; // [null/range check failed]
          lVar6 = Component.GetComponent(lVar6,DAT_181d6bc40);
          lVar11 = *pStatics_6270;
          if (this.itemData == null) throw; // [null/range check failed]
          uVar10 = Int32.ToString(this.itemData + 64,0);
          uVar10 = String.Concat("RareLv",uVar10,0);
          if ((lVar11 == null) ||
             (uVar10 = TextureController.LoadAtlasSprite(lVar11,"IconAtlas",uVar10,0), lVar6 == null))
          throw; // [null/range check failed]
          Image.set_sprite(lVar6,uVar10,0);
          lVar6 = Component.get_transform(this,0);
          if ((lVar6 == null) || (lVar6 = Transform.Find(lVar6,"RareLv",0)) == null)
          throw; // [null/range check failed]
          plVar8 = (int64 *)Component.GetComponent(lVar6,DAT_181d6bc40);
          lVar6 = this.itemData;
          if (lVar6 == null) throw; // [null/range check failed]
          if (lVar6.type == 4) {
            if (lVar6.treasureData == null) throw; // [null/range check failed]
            if (*(char *)(lVar6.treasureData + 16) == false)
            {
              puVar9 = (uint64 *)FUN_180d904c0(&local_68,0);
              }
              else {
            }
            puVar9 = (uint64 *)FUN_181098a50(&local_68,0);
          }
          if (plVar8 == (int64 *)0) throw; // [null/range check failed]
          local_68 = *puVar9;
          uStack_60 = puVar9[1];
          (**(code **)(*plVar8 + 0x2a8))(plVar8,&local_68,*(uint64 *)(*plVar8 + 0x2b0));
          lVar6 = Component.get_transform(this,0);
          if ((lVar6 == null) || (lVar6 = Transform.Find(lVar6,"Icon",0)) == null)
          throw; // [null/range check failed]
          lVar6 = Component.GetComponent(lVar6,DAT_181d6bc40);
          lVar11 = *pStatics_6270;
          if (((this.itemData == null) ||
              (uVar10 = ItemData.GetItemIconName(this.itemData,0), lVar11 == null)) ||
             (uVar10 = TextureController.LoadAtlasSprite(lVar11,"IconAtlas",uVar10,0), lVar6 == null))
          throw; // [null/range check failed]
          Image.set_sprite(lVar6,uVar10,0);
          cVar3 = FUN_180d6ca90(this.fromStorage,0);
          if (!cVar3) {
            lVar6 = Component.get_transform(this,0);
            if (((lVar6 == null) || (lVar6 = Transform.Find(lVar6,"FromStorage",0)) == null) ||
               (lVar6 = Component.get_gameObject(lVar6,0)) == null) throw; // [null/range check failed]
            GameObject.SetActive(lVar6,1,0);
            lVar6 = Component.get_transform(this,0);
            if ((lVar6 == null) || (lVar6 = Transform.Find(lVar6,"FromStorage",0)) == null)
            throw; // [null/range check failed]
            lVar6 = Component.GetComponent(lVar6,DAT_181d6ccc0);
            if (lVar6 == null) throw; // [null/range check failed]
            lVar6.subType = this.fromStorage;
            if (this.fromStorage == null) throw; // [null/range check failed]
            cVar3 = String.Contains(this.fromStorage,"藏经阁",0);
            if (cVar3) {
              lVar6 = Component.get_transform(this,0);
              if ((lVar6 == null) || (lVar6 = Transform.Find(lVar6,"FromStorage",0)) == null)
              throw; // [null/range check failed]
              lVar6 = Component.GetComponent(lVar6,DAT_181d6bc40);
              if ((*pStatics_6270 == 0) ||
                 (uVar10 = TextureController.LoadAtlasSprite
                                     (*pStatics_6270,"UIAtlas","buildingicon_1",0)
                 , lVar6 == null)) throw; // [null/range check failed]
              Image.set_sprite(lVar6,uVar10,0);
            }
          }
          lVar6 = this.itemData;
          if (lVar6 == null) throw; // [null/range check failed]
          if (lVar6.type == 3) {
            if ((lVar6.bookData == null) ||
               (lVar6 = BookData.DataBase(lVar6.bookData,0)) == null)
            throw; // [null/range check failed]
            if ((lVar6.subType < 0) || (this.hideItemBox)) {
              lVar6 = Component.get_transform(this,0);
              if (((lVar6 == null) || (lVar6 = Transform.Find(lVar6,"Force",0)) == null) ||
                 (lVar6 = Component.get_gameObject(lVar6,0)) == null) throw; // [null/range check failed]
              cVar3 = GameObject.get_activeSelf(lVar6,0);
              if (cVar3) {
                lVar6 = Component.get_transform(this,0);
                if (((lVar6 == null) || (lVar6 = Transform.Find(lVar6,"Force",0)) == null) ||
                   (lVar6 = Component.get_gameObject(lVar6,0)) == null) throw; // [null/range check failed]
                GameObject.SetActive(lVar6,0,0);
              }
            }
            else {
              lVar6 = Component.get_transform(this,0);
              if (((lVar6 == null) || (lVar6 = Transform.Find(lVar6,"Force",0)) == null) ||
                 (lVar6 = Component.get_gameObject(lVar6,0)) == null) throw; // [null/range check failed]
              cVar3 = GameObject.get_activeSelf(lVar6,0);
              if (!cVar3) {
                lVar6 = Component.get_transform(this,0);
                if (((lVar6 == null) || (lVar6 = Transform.Find(lVar6,"Force",0)) == null) ||
                   (lVar6 = Component.get_gameObject(lVar6,0)) == null) throw; // [null/range check failed]
                GameObject.SetActive(lVar6,1,0);
              }
              lVar6 = Component.get_transform(this,0);
              if ((lVar6 == null) || (lVar6 = Transform.Find(lVar6,"Force",0)) == null)
              throw; // [null/range check failed]
              lVar6 = Component.GetComponent(lVar6,DAT_181d6bc40);
              lVar11 = FUN_18046c6c0(0);
              if ((this.itemData == null) ||
                 ((lVar12 = this.itemData.bookData, lVar12 == null ||
                  (lVar12 = BookData.DataBase(lVar12,0)) == null))) throw; // [null/range check failed]
              uVar19 = *(uint32 *)(lVar12 + 24);
              uVar10 = GlobalData.GetForceIconName(uVar19,0);
              if ((lVar11 == null) ||
                 (uVar10 = TextureController.LoadAtlasSprite(lVar11,"UIAtlas",uVar10,0), lVar6 == null))
              throw; // [null/range check failed]
              Image.set_sprite(lVar6,uVar10,0);
            }
            lVar6 = Component.get_transform(this,0);
            if (((lVar6 == null) || (lVar6 = Transform.Find(lVar6,"BookType",0)) == null) ||
               (lVar6 = Component.get_gameObject(lVar6,0)) == null) {
        LAB_180b7b08d:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            GameObject.SetActive(lVar6,1,0);
            lVar6 = FUN_18046c100(0);
            if (lVar6 == null) goto LAB_180b7b08d;
            lVar6 = GameDataController.FindBookTypeIconDataBase(lVar6,this.itemData,0);
            lVar11 = Component.get_transform(this,0);
            if ((lVar11 == null) || (lVar11 = Transform.Find(lVar11,"BookType",0)) == null)
            goto LAB_180b7b08d;
            lVar11 = Component.GetComponent(lVar11,DAT_181d6bc40);
            lVar12 = *pStatics_6270;
            if (((this.itemData == null) ||
                (lVar13 = this.itemData.bookData) == null) ||
               (lVar13 = BookData.DataBase(lVar13,0)) == null) goto LAB_180b7b08d;
            local_res18[0] = *(uint32 *)(lVar13 + 48);
            uVar7 = il2cpp_value_box(DAT_181d5b2f8,local_res18);
            uVar10 = "IconAtlas";
            if (lVar6 == null) goto LAB_180b7b08d;
            uVar16 = "d";
            if (!lVar6.name) {
              uVar16 = "";
            }
            uVar7 = String.Format("BookType_{0}{1}",uVar7,uVar16,0);
            if ((lVar12 == null) ||
               (uVar10 = TextureController.LoadAtlasSprite(lVar12,uVar10,uVar7,0), lVar11 == null))
            throw; // [null/range check failed]
            Image.set_sprite(lVar11,uVar10,0);
            if (!lVar6.name) {
              lVar11 = Component.get_transform(this,0);
              if (((lVar11 == null) || (lVar11 = Transform.Find(lVar11,"BookType",0)) == null) ||
                 (plVar8 = (int64 *)Component.GetComponent(lVar11,DAT_181d6bc40),
                 plVar8 == (int64 *)0)) throw; // [null/range check failed]
              local_68 = *(uint64 *)(lVar6 + 36);
              uStack_60 = *(uint64 *)(lVar6 + 44);
              (**(code **)(*plVar8 + 0x2a8))(plVar8,&local_68,*(uint64 *)(*plVar8 + 0x2b0));
            }
            lVar11 = Component.get_transform(this,0);
            if (lVar11 == null) throw; // [null/range check failed]
            lVar11 = Transform.Find(lVar11,"BookType",0);
            if (lVar11 == null) throw; // [null/range check failed]
            local_80 = 0;
            local_88 = lVar6.subType;
            Transform.set_localPosition(lVar11,&local_88,0);
          }
        }
        uVar10 = *(uint64 *)(*(int64 *)(DAT_181d66570 + 184) + 72);
        uVar7 = Component.get_gameObject(this,0);
        cVar3 = Object.op_Equality(uVar10,uVar7,0);
        if (cVar3) {
          if (this.itemData == null) throw; // [null/range check failed]
          this.itemData.isNew = 0;
        }
        lVar6 = Component.get_transform(this,0);
        if (((lVar6 == null) || (lVar6 = Transform.Find(lVar6,"New",0)) == null) ||
           (lVar6 = Component.get_gameObject(lVar6,0)) == null) throw; // [null/range check failed]
        cVar3 = GameObject.get_activeSelf(lVar6,0);
        if (this.itemData == null) throw; // [null/range check failed]
        if (cVar3 != this.itemData.isNew) {
          lVar6 = Component.get_transform(this,0);
          if ((lVar6 == null) || (lVar6 = Transform.Find(lVar6,"New",0)) == null)
          throw; // [null/range check failed]
          lVar6 = Component.get_gameObject(lVar6,0);
          if ((this.itemData == null) || (lVar6 == null)) throw; // [null/range check failed]
          GameObject.SetActive(lVar6,this.itemData.isNew,0);
        }
        fVar17 = this.updateTime;
        if (0.0 < fVar17) {
          fVar18 = (float)Time.get_deltaTime(0);
          this.updateTime = fVar17 - fVar18;
          return;
        }
        this.updateTime = 0x3f000000;
        lVar6 = Component.get_transform(this,0);
        if ((lVar6 == null) || (lVar6 = Transform.Find(lVar6,"Equiped",0)) == null)
        throw; // [null/range check failed]
        lVar11 = Component.get_transform(lVar6,0);
        lVar6 = this.itemData;
        if (lVar6 == null) throw; // [null/range check failed]
        if (lVar6.type == null) {
          if (lVar6.equipmentData == null) throw; // [null/range check failed]
          cVar3 = *(char *)(lVar6.equipmentData + 48);
        LAB_180b79bef:
          if ((!cVar3) || (this.itemIconType == 4)) goto LAB_180b79c04;
          puVar14 = (uint64 *)Vector3.get_one(&local_88,0);
        }
        else {
          if (lVar6.type == 6) {
            if (lVar6.horseData == null) throw; // [null/range check failed]
            cVar3 = *(char *)(lVar6.horseData + 16);
            goto LAB_180b79bef;
          }
        LAB_180b79c04:
          puVar14 = (uint64 *)Vector3.get_zero(&local_88,0);
        }
        if (lVar11 == null) throw; // [null/range check failed]
        local_88 = *puVar14;
        local_80 = (int)puVar14[1];
        Transform.set_localScale(lVar11,&local_88,0);
        if (this.itemIconType == 2) {
          lVar6 = FUN_18046c700(0);
          if (lVar6 == null) throw; // [null/range check failed]
          if (lVar6.subType == null) {
            lVar6 = Component.get_transform(this,0);
            if (((lVar6 == null) || (lVar6 = Transform.Find(lVar6,"Price",0)) == null) ||
               (lVar6 = Component.get_gameObject(lVar6,0)) == null) throw; // [null/range check failed]
            cVar3 = GameObject.get_activeSelf(lVar6,0);
            if (!cVar3) {
              lVar6 = Component.get_transform(this,0);
              if (((lVar6 == null) || (lVar6 = Transform.Find(lVar6,"Price",0)) == null) ||
                 (lVar6 = Component.get_gameObject(lVar6,0)) == null) throw; // [null/range check failed]
              GameObject.SetActive(lVar6,1,0);
              this.needRefreshPriceIcon = 1;
            }
            if (this.needRefreshPriceIcon) {
              this.needRefreshPriceIcon = 0;
              lVar6 = Component.get_transform(this,0);
              if (((lVar6 == null) || (lVar6 = Transform.Find(lVar6,"Price",0)) == null) ||
                 (lVar6 = Transform.Find(lVar6,"PriceIcon",0)) == null) throw; // [null/range check failed]
              lVar6 = Component.GetComponent(lVar6,DAT_181d6bc40);
              lVar11 = FUN_18046c6c0(0);
              if ((lVar11 == null) ||
                 (uVar10 = TextureController.LoadAtlasSprite(lVar11,"UIAtlas","银钱",0),
                 lVar6 == null)) throw; // [null/range check failed]
              Image.set_sprite(lVar6,uVar10,0);
            }
            lVar6 = Component.get_transform(this,0);
            if ((lVar6 == null) || (lVar6 = Transform.Find(lVar6,"Price",0)) == null)
            throw; // [null/range check failed]
            uVar10 = Component.GetComponent(lVar6,DAT_181d6d8c0);
            plVar8 = (int64 *)il2cpp_value_box(DAT_181d880d8,this + 44);
            if (plVar8 == (int64 *)0) throw; // [null/range check failed]
            lVar6 = (**(code **)(*plVar8 + 0x168))(plVar8,*(uint64 *)(*plVar8 + 0x170));
            puVar15 = (uint32 *)il2cpp_object_unbox(plVar8);
            this.tradeIconType = *puVar15;
            if (lVar6 == null) throw; // [null/range check failed]
            uVar4 = String.Contains(lVar6,"Right",0);
            local_res8[0] = ItemIconController.GetItemPrice(this,uVar4,0);
            uVar7 = Int32.ToString(local_res8,0);
            LTLocalization.SetText(uVar10,uVar7,0);
            fVar17 = (float)ItemIconController.GetItemTreasureSpeRate(this,0);
            if (fVar17 != 1.0) {
              lVar6 = Component.get_transform(this,0);
              if ((lVar6 == null) || (lVar6 = Transform.Find(lVar6,"Price",0)) == null)
              throw; // [null/range check failed]
              plVar8 = (int64 *)Component.GetComponent(lVar6,DAT_181d6d8c0);
              fVar17 = (float)ItemIconController.GetItemTreasureSpeRate(this,0);
              if (fVar17 <= 1.0) {
                uVar10 = *(uint64 *)(pStatics_ef00 + 0x290);
                uVar7 = *(uint64 *)(pStatics_ef00 + 0x298);
              }
              else {
                uVar10 = *(uint64 *)(pStatics_ef00 + 0x2f8);
                uVar7 = *(uint64 *)(pStatics_ef00 + 0x300);
              }
              if (plVar8 == (int64 *)0) throw; // [null/range check failed]
              lVar6 = *plVar8;
              local_68 = uVar10;
              uStack_60 = uVar7;
              goto LAB_180b7a038;
            }
            plVar8 = (int64 *)il2cpp_value_box(DAT_181d880d8,this + 44);
            if (plVar8 == (int64 *)0) throw; // [null/range check failed]
            lVar6 = (**(code **)(*plVar8 + 0x168))(plVar8,*(uint64 *)(*plVar8 + 0x170));
            puVar15 = (uint32 *)il2cpp_object_unbox(plVar8);
            this.tradeIconType = *puVar15;
            if (lVar6 == null) throw; // [null/range check failed]
            cVar3 = String.Contains(lVar6,"Right",0);
            if (!cVar3) {
        LAB_180b7a08b:
              plVar8 = (int64 *)il2cpp_value_box(DAT_181d880d8,this + 44);
              if (plVar8 == (int64 *)0) throw; // [null/range check failed]
              lVar6 = (**(code **)(*plVar8 + 0x168))(plVar8,*(uint64 *)(*plVar8 + 0x170));
              puVar15 = (uint32 *)il2cpp_object_unbox(plVar8);
              this.tradeIconType = *puVar15;
              if (lVar6 == null) throw; // [null/range check failed]
              cVar3 = String.Contains(lVar6,"Right",0);
              if (!cVar3) {
                lVar6 = FUN_18046c700(0);
                if (lVar6 == null) throw; // [null/range check failed]
                if (*(float *)(lVar6 + 176) != 1.0) {
                  lVar6 = Component.get_transform(this,0);
                  if ((lVar6 == null) || (lVar6 = Transform.Find(lVar6,"Price",0)) == null)
                  throw; // [null/range check failed]
                  plVar8 = (int64 *)Component.GetComponent(lVar6,DAT_181d6d8c0);
                  lVar6 = FUN_18046c700(0);
                  if (lVar6 == null) throw; // [null/range check failed]
                  fVar17 = *(float *)(lVar6 + 176);
                  goto LAB_180b79fb8;
                }
              }
              lVar6 = Component.get_transform(this,0);
              if ((lVar6 == null) || (lVar6 = Transform.Find(lVar6,"Price",0)) == null)
              throw; // [null/range check failed]
              plVar8 = (int64 *)Component.GetComponent(lVar6,DAT_181d6d8c0);
              if (plVar8 == (int64 *)0) throw; // [null/range check failed]
              uVar10 = **(uint64 **)(DAT_181d5cff8 + 184);
              uVar7 = (*(uint64 **)(DAT_181d5cff8 + 184))[1];
            }
            else {
              lVar6 = FUN_18046c700(0);
              if (lVar6 == null) throw; // [null/range check failed]
              if (*(float *)(lVar6 + 180) == 1.0) goto LAB_180b7a08b;
              lVar6 = Component.get_transform(this,0);
              if ((lVar6 == null) || (lVar6 = Transform.Find(lVar6,"Price",0)) == null)
              throw; // [null/range check failed]
              plVar8 = (int64 *)Component.GetComponent(lVar6,DAT_181d6d8c0);
              lVar6 = FUN_18046c700(0);
              if (lVar6 == null) throw; // [null/range check failed]
              fVar17 = *(float *)(lVar6 + 180);
        LAB_180b79fb8:
              if (fVar17 <= 1.0) {
                uVar10 = *(uint64 *)(pStatics_ef00 + 0x290);
                uVar7 = *(uint64 *)(pStatics_ef00 + 0x298);
              }
              else {
                uVar10 = *(uint64 *)(pStatics_ef00 + 0x2f8);
                uVar7 = *(uint64 *)(pStatics_ef00 + 0x300);
              }
              if (plVar8 == (int64 *)0) throw; // [null/range check failed]
            }
            uStack_60 = uVar7;
            local_68 = uVar10;
            lVar6 = *plVar8;
        LAB_180b7a038:
            (**(code **)(lVar6 + 0x2a8))(plVar8,&local_68,*(uint64 *)(lVar6 + 0x2b0));
            return;
          }
          if (this.itemIconType == 2) {
            plVar8 = (int64 *)il2cpp_value_box(DAT_181d880d8,this + 44);
            if (plVar8 == (int64 *)0) throw; // [null/range check failed]
            lVar6 = (**(code **)(*plVar8 + 0x168))(plVar8,*(uint64 *)(*plVar8 + 0x170));
            puVar15 = (uint32 *)il2cpp_object_unbox(plVar8);
            this.tradeIconType = *puVar15;
            if (lVar6 == null) throw; // [null/range check failed]
            cVar3 = String.Contains(lVar6,"Right",0);
            if (cVar3) {
              lVar6 = FUN_18046c700(0);
              if (lVar6 == null) throw; // [null/range check failed]
              if (lVar6.subType == 2) {
                lVar6 = Component.get_transform(this,0);
                if (((lVar6 == null) || (lVar6 = Transform.Find(lVar6,"Price",0)) == null) ||
                   (lVar6 = Component.get_gameObject(lVar6,0)) == null) throw; // [null/range check failed]
                cVar3 = GameObject.get_activeSelf(lVar6,0);
                if (!cVar3) {
                  lVar6 = Component.get_transform(this,0);
                  if (((lVar6 == null) || (lVar6 = Transform.Find(lVar6,"Price",0)) == null) ||
                     (lVar6 = Component.get_gameObject(lVar6,0)) == null) throw; // [null/range check failed]
                  GameObject.SetActive(lVar6,1,0);
                  this.needRefreshPriceIcon = 1;
                }
                if (this.needRefreshPriceIcon) {
                  this.needRefreshPriceIcon = 0;
                  lVar6 = Component.get_transform(this,0);
                  if (((lVar6 == null) || (lVar6 = Transform.Find(lVar6,"Price",0)) == null) ||
                     (lVar6 = Transform.Find(lVar6,"PriceIcon",0)) == null) throw; // [null/range check failed]
                  lVar6 = Component.GetComponent(lVar6,DAT_181d6bc40);
                  lVar11 = FUN_18046c6c0(0);
                  if ((lVar11 == null) ||
                     (uVar10 = TextureController.LoadAtlasSprite(lVar11,"UIAtlas","功绩",0),
                     lVar6 == null)) throw; // [null/range check failed]
                  Image.set_sprite(lVar6,uVar10,0);
                }
                lVar6 = Component.get_transform(this,0);
                if ((lVar6 == null) || (lVar6 = Transform.Find(lVar6,"Price",0)) == null)
                throw; // [null/range check failed]
                plVar8 = (int64 *)Component.GetComponent(lVar6,DAT_181d6d8c0);
                if (plVar8 == (int64 *)0) throw; // [null/range check failed]
                local_68 = *(uint64 *)(pStatics_cff8 + 16);
                uStack_60 = *(uint64 *)(pStatics_cff8 + 24);
                (**(code **)(*plVar8 + 0x2a8))(plVar8,&local_68,*(uint64 *)(*plVar8 + 0x2b0));
                lVar6 = Component.get_transform(this,0);
                if ((lVar6 == null) || (lVar6 = Transform.Find(lVar6,"Price",0)) == null)
                throw; // [null/range check failed]
                uVar10 = Component.GetComponent(lVar6,DAT_181d6d8c0);
                lVar6 = this.itemData;
                if (lVar6 == null) throw; // [null/range check failed]
                if (((*pStatics_df90 == 0) ||
                    (lVar11 = *(int64 *)(*pStatics_df90 + 32)) == null)
                   || (lVar11 = WorldData.GetHero(lVar11,0,0)) == null) throw; // [null/range check failed]
                local_res8[0] = 0;
                if (*(char *)(lVar11 + 180) == false) {
                  local_res8[0] = Mathf.RoundToInt((float)lVar6.value * 0.1,0);
                }
                goto LAB_180b7a6ac;
              }
            }
            if (this.itemIconType == 2) {
              plVar8 = (int64 *)il2cpp_value_box(DAT_181d880d8,this + 44);
              if (plVar8 == (int64 *)0) throw; // [null/range check failed]
              lVar6 = (**(code **)(*plVar8 + 0x168))(plVar8,*(uint64 *)(*plVar8 + 0x170));
              puVar15 = (uint32 *)il2cpp_object_unbox(plVar8);
              this.tradeIconType = *puVar15;
              if (lVar6 == null) throw; // [null/range check failed]
              cVar3 = String.Contains(lVar6,"Right",0);
              if (cVar3) {
                lVar6 = FUN_18046c700(0);
                if (lVar6 == null) throw; // [null/range check failed]
                if (lVar6.subType == 4) {
                  lVar6 = Component.get_transform(this,0);
                  if (((lVar6 == null) || (lVar6 = Transform.Find(lVar6,"Price",0)) == null) ||
                     (lVar6 = Component.get_gameObject(lVar6,0)) == null) throw; // [null/range check failed]
                  cVar3 = GameObject.get_activeSelf(lVar6,0);
                  if (!cVar3) {
                    lVar6 = Component.get_transform(this,0);
                    if (((lVar6 == null) || (lVar6 = Transform.Find(lVar6,"Price",0)) == null) ||
                       (lVar6 = Component.get_gameObject(lVar6,0)) == null) throw; // [null/range check failed]
                    GameObject.SetActive(lVar6,1,0);
                    this.needRefreshPriceIcon = 1;
                  }
                  if (this.needRefreshPriceIcon) {
                    this.needRefreshPriceIcon = 0;
                    lVar6 = Component.get_transform(this,0);
                    if (((lVar6 == null) || (lVar6 = Transform.Find(lVar6,"Price",0)) == null) ||
                       (lVar6 = Transform.Find(lVar6,"PriceIcon",0)) == null) throw; // [null/range check failed]
                    lVar6 = Component.GetComponent(lVar6,DAT_181d6bc40);
                    lVar11 = FUN_18046c6c0(0);
                    if ((lVar11 == null) ||
                       (uVar10 = TextureController.LoadAtlasSprite(lVar11,"UIAtlas","官府功绩",0),
                       lVar6 == null)) throw; // [null/range check failed]
                    Image.set_sprite(lVar6,uVar10,0);
                  }
                  lVar6 = Component.get_transform(this,0);
                  if ((lVar6 != null) && (lVar6 = Transform.Find(lVar6,"Price",0)) != null) {
                    plVar8 = (int64 *)Component.GetComponent(lVar6,DAT_181d6d8c0);
                    if (plVar8 != (int64 *)0) {
                      local_68 = *(uint64 *)(pStatics_cff8 + 48);
                      uStack_60 = *(uint64 *)(pStatics_cff8 + 56);
                      (**(code **)(*plVar8 + 0x2a8))(plVar8,&local_68,*(uint64 *)(*plVar8 + 0x2b0));
                      lVar6 = Component.get_transform(this,0);
                      if ((lVar6 != null) && (lVar6 = Transform.Find(lVar6,"Price",0)) != null) {
                        uVar10 = Component.GetComponent(lVar6,DAT_181d6d8c0);
                        if (this.itemData != null) {
                          local_res8[0] =
                               Mathf.RoundToInt((float)this.itemData.value *
                                                 0.1,0);
        LAB_180b7a6ac:
                          uVar7 = Int32.ToString(local_res8,0);
                          LTLocalization.SetText(uVar10,uVar7,0);
                          return;
                        }
                      }
                    }
                  }
                  throw; // [null/range check failed]
                }
              }
            }
          }
        }
        if (this.itemIconType != 5) {
          lVar6 = Component.get_transform(this,0);
          if (((lVar6 != null) && (lVar6 = Transform.Find(lVar6,"Price",0)) != null) &&
             (lVar6 = Component.get_gameObject(lVar6,0)) != null) {
            cVar3 = GameObject.get_activeSelf(lVar6,0);
            if (!cVar3) {
              return;
            }
            lVar6 = Component.get_transform(this,0);
            if (((lVar6 != null) && (lVar6 = Transform.Find(lVar6,"Price",0)) != null) &&
               (lVar6 = Component.get_gameObject(lVar6,0)) != null) {
              GameObject.SetActive(lVar6,0,0);
              return;
            }
          }
          goto LAB_180b7b093;
        }
        lVar6 = Component.get_transform(this,0);
        if (((lVar6 != null) && (lVar6 = Transform.Find(lVar6,"Price",0)) != null) &&
           (lVar6 = Component.get_gameObject(lVar6,0)) != null) {
          cVar3 = GameObject.get_activeSelf(lVar6,0);
          if (cVar3) {
            lVar6 = Component.get_transform(this,0);
            if (((lVar6 == null) || (lVar6 = Transform.Find(lVar6,"Price",0)) == null) ||
               (lVar6 = Component.get_gameObject(lVar6,0)) == null) throw; // [null/range check failed]
            GameObject.SetActive(lVar6,0,0);
          }
          lVar6 = Component.get_transform(this,0);
          if (((lVar6 != null) && (lVar6 = FUN_180da0f00(lVar6,0)) != null) &&
             (lVar6 = FUN_180da0f00(lVar6,0)) != null) {
            uVar10 = Transform.Find(lVar6,"PriceBack",0);
            cVar3 = Object.op_Inequality(uVar10,0,0);
            if (!cVar3) {
              return;
            }
            lVar6 = Component.get_transform(this,0);
            if (((((lVar6 != null) && (lVar6 = FUN_180da0f00(lVar6,0)) != null) &&
                 (lVar6 = FUN_180da0f00(lVar6,0)) != null) &&
                ((lVar6 = Transform.Find(lVar6,"PriceBack",0), lVar6 != null &&
                 (lVar6 = Transform.Find(lVar6,"Price",0)) != null))) &&
               (lVar11 = Component.get_gameObject(lVar6,0)) != null) {
              cVar3 = GameObject.get_activeSelf(lVar11,0);
              if (!cVar3) {
                lVar11 = Component.get_gameObject(lVar6,0);
                if (lVar11 == null) throw; // [null/range check failed]
                GameObject.SetActive(lVar11,1,0);
                lVar11 = Transform.Find(lVar6,"PriceIcon",0);
                if (lVar11 == null) throw; // [null/range check failed]
                lVar11 = Component.GetComponent(lVar11,DAT_181d6bc40);
                lVar12 = FUN_18046c6c0(0);
                if ((lVar12 == null) ||
                   (uVar10 = TextureController.LoadAtlasSprite(lVar12,"UIAtlas","功绩",0),
                   lVar11 == null)) throw; // [null/range check failed]
                Image.set_sprite(lVar11,uVar10,0);
              }
              lVar11 = FUN_18046c0a0(0);
              if ((lVar11 != null) && (*(int64 *)(lVar11 + 32) != 0)) {
                lVar11 = WorldData.Player(*(int64 *)(lVar11 + 32),0);
                if ((this.itemData != null) &&
                   ((lVar12 = this.itemData.bookData, lVar12 != null &&
                    (lVar11 != null)))) {
                  lVar11 = HeroData.FindSkill(lVar11,*(uint32 *)(lVar12 + 16),0);
                  if (lVar11 != null) {
                    plVar8 = (int64 *)Component.GetComponent(lVar6);
                    puVar9 = (uint64 *)FUN_180d904c0(&local_68,0);
                    if (plVar8 != (int64 *)0) {
                      local_68 = *puVar9;
                      uStack_60 = puVar9[1];
                      (**(code **)(*plVar8 + 0x2a8))(plVar8,&local_68,*(uint64 *)(*plVar8 + 0x2b0));
                      lVar11 = Transform.Find(lVar6,"PriceIcon",0);
                      if ((((lVar11 != null) &&
                           (lVar11 = Component.GetComponent(lVar11,DAT_181d6bc40)) != null) &&
                          (*(int64 *)(lVar11 + 216) != 0)) &&
                         (lVar11 = Object.get_name(*(int64 *)(lVar11 + 216),0)) != null) {
                        cVar3 = String.Contains(lVar11,"出战_出战",0);
                        if (cVar3) {
                          return;
                        }
                        lVar11 = Transform.Find(lVar6,"PriceIcon",0);
                        if (lVar11 != null) {
                          lVar11 = Component.GetComponent(lVar11,DAT_181d6bc40);
                          lVar12 = FUN_18046c6c0(0);
                          if ((lVar12 != null) &&
                             (uVar10 = TextureController.LoadAtlasSprite
                                                 (lVar12,"UIAtlas","出战_出战",0), lVar11 != null)) {
                            Image.set_sprite(lVar11,uVar10,0);
                            puVar14 = (uint64 *)Transform.get_localPosition(&local_88,lVar6,0);
                            uVar1 = *puVar14;
                            lVar11 = Transform.get_localPosition(local_78,lVar6,0);
                            local_80 = *(uint32 *)(lVar11 + 8);
                            local_88 = uVar1 & 0xffffffff00000000;
                            Transform.set_localPosition(lVar6,&local_88,0);
                            lVar6 = Transform.Find(lVar6,"PriceIcon",0);
                            puVar14 = (uint64 *)Vector3.get_zero(&local_68,0);
                            if (lVar6 != null) {
                              local_80 = (uint32)puVar14[1];
                              local_88 = *puVar14;
                              Transform.set_localPosition(lVar6,&local_88,0);
                              return;
                            }
                          }
                        }
                      }
                    }
        LAB_180b7b093:
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  plVar8 = (int64 *)Component.GetComponent(lVar6,DAT_181d6d8c0);
                  lVar11 = FUN_18046c0a0(0);
                  if (((lVar11 != null) && (*(int64 *)(lVar11 + 32) != 0)) &&
                     (lVar11 = WorldData.Player(*(int64 *)(lVar11 + 32),0)) != null) {
                    fVar17 = *(float *)(lVar11 + 0x1c0);
                    if (this.itemData != null) {
                      iVar5 = ItemData.GetReadBookContributionCost(this.itemData,0,0);
                      if ((float)iVar5 <= fVar17) {
                        uVar10 = *(uint64 *)(pStatics_cff8 + 32);
                        uVar7 = *(uint64 *)(pStatics_cff8 + 40);
                      }
                      else {
                        uVar10 = *(uint64 *)(pStatics_ef00 + 0x2d8);
                        uVar7 = *(uint64 *)(pStatics_ef00 + 0x2e0);
                      }
                      if (plVar8 != (int64 *)0) {
                        local_68 = uVar10;
                        uStack_60 = uVar7;
                        (**(code **)(*plVar8 + 0x2a8))(plVar8,&local_68,*(uint64 *)(*plVar8 + 0x2b0));
                        lVar11 = Component.GetComponent(lVar6,DAT_181d6c2c0);
                        if (lVar11 != null) {
                          Behaviour.set_enabled(lVar11,0,0);
                          uVar10 = Component.GetComponent(lVar6,DAT_181d6d8c0);
                          if (this.itemData != null) {
                            local_res8[0] =
                                 ItemData.GetReadBookContributionCost(this.itemData,0,0);
                            uVar7 = Int32.ToString(local_res8,"f0",0);
                            LTLocalization.SetText(uVar10,uVar7,0);
                            return;
                          }
                        }
                        goto LAB_180b7b093;
                      }
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6001837
    // RVA   : 0xB778C0   Offset: 0xB760C0   Length: 0x14B
    public float GetItemAreaSpeRate()
    {
        long lVar1;
        ulong uVar2;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d88158 + 184) + 8);
        if (lVar1 != null) {
          if (*(char *)(lVar1 + 32) == false) {
            return 0x3f800000;
          }
          lVar1 = *(int64 *)(*(int64 *)(DAT_181d87630 + 184) + 56);
          if (lVar1 != null) {
            uVar2 = AreaController.GetAreaSpePriceRate(lVar1,0);
            return uVar2;
          }
        }
    }

    // Token : 0x6001838
    // RVA   : 0xB77E00   Offset: 0xB76600   Length: 0x31C
    public float GetItemTreasureSpeRate()
    {
        var pStatics = *(int64*)(DAT_181d87630 + 184);
        long lVar1;
        int iVar2;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d88158 + 184) + 8);
        if (lVar1 != null) {
          if (*(char *)(lVar1 + 32) == false) {
            return 0x3f800000;
          }
          lVar1 = *(int64 *)(pStatics + 56);
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
                lVar1 = *(int64 *)(pStatics + 56);
                if (((lVar1 == null) || (lVar1 = *(int64 *)(lVar1 + 88)) == null) ||
                   (lVar1 = *(int64 *)(lVar1 + 224)) == null) throw; // [null/range check failed]
                if (*(int *)(lVar1 + 24) <= iVar2) {
                  return 0x3f800000;
                }
                lVar1 = FUN_18046bac0(0);
                if (((lVar1 == null) || (*(int64 *)(lVar1 + 88) == 0)) ||
                   ((lVar1 = *(int64 *)(*(int64 *)(lVar1 + 88) + 224), lVar1 == null ||
                    ((lVar1 = FUN_180002f80(lVar1,iVar2,DAT_181d55758), lVar1 == null ||
                     (this.itemData == null)))))) throw; // [null/range check failed]
                if (*(int *)(lVar1 + 16) == this.itemData.subType) break;
                iVar2 = iVar2 + 1;
              }
              lVar1 = FUN_18046bac0(0);
              if ((((lVar1 != null) && (*(int64 *)(lVar1 + 88) != 0)) &&
                  (lVar1 = *(int64 *)(*(int64 *)(lVar1 + 88) + 224)) != null) &&
                 (lVar1 = FUN_180002f80(lVar1,iVar2,DAT_181d55758)) != null) {
                if (*(char *)(lVar1 + 20) == false) {
                  return 0x3f000000;
                }
                return 0x40000000;
              }
            }
          }
        }
    }

    // Token : 0x6001839
    // RVA   : 0xB776B0   Offset: 0xB75EB0   Length: 0x208
    public float GetHeroFavorValueRate(bool buy)
    {
        var pStatics = *(int64*)(DAT_181d88158 + 184);
        long lVar1;
        long lVar2;
        ulong uVar3;
        lVar1 = *(int64 *)(pStatics + 8);
        if (lVar1 != null) {
          if (*(int *)(lVar1 + 24) != 0) {
            return 0x3f800000;
          }
          lVar1 = *(int64 *)(pStatics + 8);
          if (((lVar1 != null) && (lVar1 = *(int64 *)(lVar1 + 72)) != null) &&
             (lVar1 = *(int64 *)(lVar1 + 48)) != null) {
            if (*(int *)(lVar1 + 16) < 0) {
              return 0x3f800000;
            }
            lVar1 = FUN_18046c0a0(0);
            if (lVar1 != null) {
              lVar1 = *(int64 *)(lVar1 + 32);
              lVar2 = FUN_18046c700(0);
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

    // Token : 0x600183A
    // RVA   : 0xB77A10   Offset: 0xB76210   Length: 0x3EB
    public int GetItemPrice(bool buy)
    {
        var pStatics_8158 = *(int64*)(DAT_181d88158 + 184);
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        int iVar1;
        long lVar2;
        float fVar3;
        float fVar4;
        float fVar5;
        float fVar6;
        float fVar7;
        if (this.itemData != null) {
          iVar1 = this.itemData.value;
          if ((*pStatics_df90 != 0) &&
             (lVar2 = *(int64 *)(*pStatics_df90 + 32)) != null) {
            lVar2 = WorldData.Player(lVar2,0);
            if (lVar2 != null) {
              fVar3 = (float)HeroData.GetTradeValueRate(lVar2,buy,0);
              fVar4 = (float)ItemIconController.GetHeroFavorValueRate(this,buy,0);
              lVar2 = *(int64 *)(pStatics_8158 + 8);
              if (lVar2 != null) {
                if (*(char *)(lVar2 + 32) == false) {
                  fVar7 = 1.0;
                }
                else {
                  lVar2 = *(int64 *)(*(int64 *)(DAT_181d87630 + 184) + 56);
                  if (lVar2 == null) throw; // [null/range check failed]
                  fVar7 = (float)AreaController.GetAreaSpePriceRate(lVar2,0);
                }
                fVar5 = (float)ItemIconController.GetItemTreasureSpeRate(this,0);
                if (!buy) {
                  lVar2 = *(int64 *)(pStatics_8158 + 8);
                  if (lVar2 == null) throw; // [null/range check failed]
                  fVar6 = *(float *)(lVar2 + 176);
                }
                else {
                  lVar2 = *(int64 *)(pStatics_8158 + 8);
                  if (lVar2 == null) throw; // [null/range check failed]
                  fVar6 = *(float *)(lVar2 + 180);
                }
                return (int)(fVar5 * (float)iVar1 * fVar3 * fVar4 * fVar7 * fVar6);
              }
            }
          }
        }
    }

    // Token : 0x600183B
    // RVA   : 0xB76A60   Offset: 0xB75260   Length: 0xC18
    public void AutoSetName(ItemSortType sortType, bool reverseOrder)
    {
        ulong uVar1;
        ulong uVar2;
        ulong uVar3;
        long lVar5;
        long lVar6;
        ulong uVar7;
        int[] local_res8 = new int[2];
        float[] local_38 = new float[4];
        local_38[0] = 0.0;
        local_res8[0] = 0;
        if (this.itemData == null) goto LAB_180b77472;
        switch(this.itemData.type) {
        case 0:
          plVar4 = (int64 *)FUN_1800d60b0(DAT_181d80cc0,6);
          if (this.itemData == null) goto LAB_180b77472;
          local_res8[0] = this.itemData.type;
          lVar5 = Int32.ToString(local_res8,0);
          if (plVar4 == (int64 *)0) goto LAB_180b77472;
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
          if (this.itemData == null) goto LAB_180b77472;
          lVar5 = Int32.ToString(this.itemData + 24,0);
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
          if (this.itemData == null) goto LAB_180b77472;
          lVar5 = Int32.ToString(this.itemData + 60,0);
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
          if ((this.itemData == null) ||
             (lVar5 = this.itemData.equipmentData) == null)
          goto LAB_180b77472;
          lVar5 = Int32.ToString(lVar5 + 20,0);
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
          if (this.itemData == null) goto LAB_180b77472;
          lVar5 = Int32.ToString(this.itemData + 16,"00",0);
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
          if (this.itemData == null) goto LAB_180b77472;
          lVar5 = Int32.ToString(this.itemData + 64,0);
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
          goto LAB_180b7724b;
        case 1:
          local_res8[0] = 1;
          break;
        case 2:
          local_res8[0] = 2;
          break;
        case 3:
          plVar4 = (int64 *)FUN_1800d60b0(DAT_181d80cc0,5);
          if (this.itemData == null) goto LAB_180b77472;
          local_res8[0] = this.itemData.type;
          lVar5 = Int32.ToString(local_res8,0);
          if (plVar4 == (int64 *)0) goto LAB_180b77472;
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
          if (this.itemData == null) goto LAB_180b77472;
          lVar5 = Int32.ToString(this.itemData + 60,0);
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
          if (((this.itemData == null) ||
              (lVar5 = this.itemData.bookData) == null) ||
             (lVar5 = BookData.DataBase(lVar5,0)) == null) goto LAB_180b77472;
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
          if ((this.itemData == null) ||
             (lVar5 = this.itemData.bookData) == null)
          goto LAB_180b77472;
          lVar5 = Int32.ToString(lVar5 + 16,"0000",0);
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
          if (this.itemData == null) goto LAB_180b77472;
          lVar5 = Int32.ToString(this.itemData + 64,0);
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
          goto LAB_180b77247;
        case 4:
          local_res8[0] = 4;
          uVar7 = Int32.ToString(local_res8,0);
          if (this.itemData == null) goto LAB_180b77472;
          uVar1 = Int32.ToString(this.itemData + 24,0);
          if (this.itemData == null) goto LAB_180b77472;
          uVar2 = Int32.ToString(this.itemData + 60,0);
          lVar5 = this.itemData;
          if ((lVar5 == null) || (lVar5.treasureData == null)) goto LAB_180b77472;
          uVar3 = "99";
          if (*(char *)(lVar5.treasureData + 16) == false) goto LAB_180b76dac;
          goto LAB_180b76d9b;
        case 5:
          local_res8[0] = 5;
          uVar7 = Int32.ToString(local_res8,0);
          if (this.itemData == null) goto LAB_180b77472;
          uVar1 = Int32.ToString(this.itemData + 24,0);
          if (this.itemData == null) goto LAB_180b77472;
          uVar2 = Int32.ToString(this.itemData + 60,0);
          if (this.itemData == null) goto LAB_180b77472;
          uVar3 = Int32.ToString(this.itemData + 64,0);
          goto LAB_180b76dac;
        case 6:
          plVar4 = (int64 *)FUN_1800d60b0(DAT_181d80cc0,5);
          if (this.itemData == null) goto LAB_180b77472;
          local_res8[0] = this.itemData.type;
          lVar5 = Int32.ToString(local_res8,0);
          if (plVar4 == (int64 *)0) goto LAB_180b77472;
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
          if (this.itemData == null) goto LAB_180b77472;
          lVar5 = Int32.ToString(this.itemData + 24,0);
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
          if (this.itemData == null) goto LAB_180b77472;
          lVar5 = Int32.ToString(this.itemData + 60,0);
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
          if (this.itemData == null) goto LAB_180b77472;
          lVar5 = Int32.ToString(this.itemData + 16,"00",0);
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
          if (this.itemData == null) goto LAB_180b77472;
          lVar5 = Int32.ToString(this.itemData + 64,0);
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
        LAB_180b77247:
          plVar8 = plVar4 + 8;
        LAB_180b7724b:
          *plVar8 = lVar5;
          il2cpp_internal(plVar8,lVar5);
          uVar7 = String.Concat(plVar4,0);
          goto LAB_180b77260;
        default:
          goto switchD_180b76b21_default;
        }
        uVar7 = Int32.ToString(local_res8,0);
        if (this.itemData == null) {
        LAB_180b77472:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        uVar1 = Int32.ToString(this.itemData + 60,0);
        if (this.itemData == null) goto LAB_180b77472;
        uVar2 = Int32.ToString(this.itemData + 16,"00",0);
        lVar5 = this.itemData;
        if (lVar5 == null) goto LAB_180b77472;
        LAB_180b76d9b:
        uVar3 = Int32.ToString(lVar5 + 64,0);
        LAB_180b76dac:
        uVar7 = String.Concat(uVar7,uVar1,uVar2,uVar3,0);
        LAB_180b77260:
        Object.set_name(this,uVar7,0);
        switchD_180b76b21_default:
        switch(sortType) {
        case 0:
          piVar9 = &this.itemListID;
          uVar7 = "000";
          if (reverseOrder) {
            local_res8[0] = 999 - *piVar9;
            piVar9 = local_res8;
          }
          goto LAB_180b772a9;
        case 1:
          lVar5 = this.itemData;
          if (!reverseOrder) {
            if (lVar5 == null) goto LAB_180b77472;
            local_res8[0] = lVar5.type;
          }
          else {
            if (lVar5 == null) goto LAB_180b77472;
            local_res8[0] = 9 - lVar5.type;
          }
        LAB_180b77321:
          uVar7 = Int32.ToString(local_res8,0);
          break;
        case 2:
          lVar5 = this.itemData;
          if (reverseOrder) {
            if (lVar5 == null) goto LAB_180b77472;
            local_res8[0] = 9 - lVar5.itemLv;
            goto LAB_180b77321;
          }
          if (lVar5 == null) goto LAB_180b77472;
          uVar7 = Int32.ToString(lVar5 + 60,0);
          break;
        case 3:
          lVar5 = this.itemData;
          if (lVar5 == null) goto LAB_180b77472;
          if (lVar5.type == 4) {
            if (lVar5.treasureData == null) goto LAB_180b77472;
            uVar7 = "99";
            if (*(char *)(lVar5.treasureData + 16) == false) break;
          }
          if (!reverseOrder) {
            uVar7 = Int32.ToString(lVar5 + 64,0);
          }
          else {
            local_res8[0] = 9 - lVar5.rareLv;
            uVar7 = Int32.ToString(local_res8,0);
          }
          break;
        case 4:
          lVar5 = this.itemData;
          uVar7 = "00000";
          if (!reverseOrder) {
            if (lVar5 == null) goto LAB_180b77472;
            piVar9 = &lVar5.value;
          }
          else {
            if (lVar5 == null) goto LAB_180b77472;
            local_res8[0] = 99999 - lVar5.value;
            piVar9 = local_res8;
          }
        LAB_180b772a9:
          uVar7 = Int32.ToString(piVar9,uVar7,0);
          break;
        case 5:
          lVar5 = this.itemData;
          if (!reverseOrder) {
            if (lVar5 == null) goto LAB_180b77472;
            uVar7 = Single.ToString(lVar5 + 68,"000",0);
          }
          else {
            if (lVar5 == null) goto LAB_180b77472;
            local_38[0] = 999.0 - lVar5.weight;
            uVar7 = Single.ToString(local_38,"000",0);
          }
          break;
        default:
          goto switchD_180b77286_default;
        }
        uVar1 = Object.get_name(this,0);
        uVar7 = String.Concat(uVar7,uVar1,0);
        Object.set_name(this,uVar7,0);
        switchD_180b77286_default:
    }

    // Token : 0x600183C
    // RVA   : 0xB78120   Offset: 0xB76920   Length: 0xF4
    public void OnClick()
    {
        var pStatics_0f00 = *(int64*)(DAT_181d50f00 + 184);
        var pStatics_6278 = *(int64*)(DAT_181d96278 + 184);
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        var pStatics_ece0 = *(int64*)(DAT_181d6ece0 + 184);
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
        if (this.itemData == null) goto LAB_180b78ad8;
        ItemData.PlayItemSound(this.itemData,0);
        if (*pStatics_6278 == 0) goto LAB_180b78ad8;
        if (*(int *)(*pStatics_6278 + 24) != 1) {
          switch(this.itemIconType) {
          case 0:
            if (this.itemData != null) {
              switch(this.itemData.type) {
              case 0:
              case 6:
                goto switchD_180b7823d_caseD_0;
              case 1:
              case 2:
                lVar6 = FUN_180b30e20(0);
                lVar5 = FUN_18077c1c0(0);
                if (lVar5 != null) {
                  uVar4 = *(uint64 *)(lVar5 + 96);
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
            lVar6 = FUN_18046c700(0);
            uVar4 = Component.get_gameObject(this,0);
            if (lVar6 != null) {
              TradeUIController.TradeIconClicked(lVar6,uVar4,0);
              return;
            }
            break;
          case 3:
            lVar6 = **(int64 **)(DAT_181d92370 + 184);
            uVar4 = Component.get_gameObject(this,0);
            if (lVar6 != null) {
              ChooseController.ChooseObj(lVar6,uVar4,0);
              return;
            }
            break;
          case 4:
            lVar6 = FUN_18077c1c0(0);
            if ((lVar6 != null) && (lVar6.equipmentData != null)) {
              HeroData.UnequipItem(lVar6.equipmentData,this.itemData,1,0,0);
              return;
            }
            break;
          case 5:
            lVar6 = **(int64 **)(DAT_181d74a60 + 184);
            if (((*pStatics_df90 != 0) &&
                (lVar5 = *(int64 *)(*pStatics_df90 + 32)) != null) &&
               (uVar4 = WorldData.Player(lVar5,0), lVar6 != null)) {
              ReadBookController.StartReadBook
                        (lVar6,uVar4,this.itemData,1,
                         in_stack_ffffffffffffffc8 & 0xffffffffffffff00,0);
              return;
            }
            break;
          case 6:
            lVar6 = **(int64 **)(DAT_181d59c78 + 184);
            lVar5 = Component.get_gameObject(this,0);
            if (lVar6 != null) {
              if (lVar6.subType != 2) {
                return;
              }
              lVar6.rareLv = lVar5;
              if ((lVar6.describe != null) &&
                 (lVar5 = GameObject.GetComponent(lVar6.describe,DAT_181d9ee60)) != null
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
          goto LAB_180b78ad8;
        }
        if (this.itemIconType == null)
        {
          lVar6 = this.itemData;
          if (lVar6 == null) goto LAB_180b78ad8;
          if (lVar6.type == null) {
          if (lVar6.equipmentData == null) goto LAB_180b78ad8;
          cVar2 = *(char *)(lVar6.equipmentData + 48);
          joined_r0x000180b78a0b:
          if (cVar2) {
        }
            plVar8 = (int64 *)Resources.Load("Sound/SoundEffect/WrongClick",0);
            plVar9 = (int64 *)0;
            if ((plVar8 != (int64 *)0) && (*plVar8 == DAT_181d8a228)) {
              plVar9 = plVar8;
            }
            NGUITools.PlaySound(plVar9,0);
            return;
          }
        }
        else if (lVar6.type == 6) {
          if (lVar6.horseData == null) goto LAB_180b78ad8;
          cVar2 = *(char *)(lVar6.horseData + 16);
          goto joined_r0x000180b78a0b;
        }
        if ((*pStatics_0f00 != 0) &&
           (lVar6 = *(int64 *)(*pStatics_0f00 + 96)) != null) {
          HeroData.LoseItem(lVar6,this.itemData,1,0);
          lVar6 = *pStatics_0f00;
          if ((*pStatics_0f00 != 0) && (lVar6 != null)) {
            HeroDetailController.FreshNowHeroDetail
                      (lVar6,*(uint64 *)(*pStatics_0f00 + 96),0,0);
            return;
          }
        }
        LAB_180b78ad8:
                          // WARNING: Subroutine does not return
        FUN_1800d6620();
        switchD_180b7823d_caseD_0:
        cVar2 = FUN_1804625f0(0x130,0);
        uVar10 = 0;
        if (cVar2) {
          if (this.itemData == null) goto LAB_180b78ad8;
          cVar2 = ItemData.Equiped(this.itemData,0);
          if (!cVar2) {
            lVar6 = this.itemData;
            if (lVar6 == null) goto LAB_180b78ad8;
            if (lVar6.type == null) {
              lVar6 = FUN_18077c1c0(0);
              if (((lVar6 == null) || (lVar6.equipmentData == null)) ||
                 (lVar6 = *(int64 *)(lVar6.equipmentData + 0x1f8)) == null)
              goto LAB_180b78ad8;
              lVar6 = lVar6.name;
              if (this.itemData == null) goto LAB_180b78ad8;
              iVar1 = this.itemData.subType;
              if (iVar1 == 0) {
                lVar6 = FUN_18077c1c0(0);
                if (((lVar6 == null) || (lVar6.equipmentData == null)) ||
                   (lVar6 = *(int64 *)(lVar6.equipmentData + 0x1f8)) == null)
                goto LAB_180b78ad8;
                lVar6 = lVar6.name;
              }
              else if (iVar1 == 1) {
                lVar6 = FUN_18077c1c0(0);
                if (((lVar6 == null) || (lVar6.equipmentData == null)) ||
                   (lVar6 = *(int64 *)(lVar6.equipmentData + 0x1f8)) == null)
                goto LAB_180b78ad8;
                lVar6 = lVar6.value;
              }
              else if (iVar1 == 2) {
                lVar6 = FUN_18077c1c0(0);
                if (((lVar6 == null) || (lVar6.equipmentData == null)) ||
                   (lVar6 = *(int64 *)(lVar6.equipmentData + 0x1f8)) == null)
                goto LAB_180b78ad8;
                lVar6 = lVar6.poisonNumDetected;
              }
              else if (iVar1 == 3) {
                lVar6 = FUN_18077c1c0(0);
                if (((lVar6 == null) || (lVar6.equipmentData == null)) ||
                   (lVar6 = *(int64 *)(lVar6.equipmentData + 0x1f8)) == null)
                goto LAB_180b78ad8;
                lVar6 = lVar6.medFoodData;
              }
              else if (iVar1 == 4) {
                lVar6 = FUN_18077c1c0(0);
                if (((lVar6 == null) || (lVar6.equipmentData == null)) ||
                   (lVar6 = *(int64 *)(lVar6.equipmentData + 0x1f8)) == null)
                goto LAB_180b78ad8;
                lVar6 = lVar6.materialData;
              }
              if (lVar6 == null) goto LAB_180b78ad8;
              lVar5 = 32;
              for (; (int)uVar10 < (int)lVar6.subType; uVar10 = uVar10 + 1) {
                if (lVar6.subType <= uVar10) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                if (*(int64 *)(lVar6.itemID + lVar5) == 0) goto LAB_180b785c1;
                lVar5 = lVar5 + 8;
              }
              lVar5 = FUN_18077c1c0(0);
              if (lVar5 == null) goto LAB_180b78ad8;
              lVar5 = *(int64 *)(lVar5 + 96);
              if (lVar6.subType == null) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              if (lVar5 == null) goto LAB_180b78ad8;
              uVar4 = *(uint64 *)(lVar6.itemID + 32);
        LAB_180b785b1:
              HeroData.UnequipItem(lVar5,uVar4,0,0,0);
            }
            else if (lVar6.subType == null) {
              lVar6 = FUN_18077c1c0(0);
              if ((lVar6 == null) || (lVar6.equipmentData == null)) goto LAB_180b78ad8;
              if (*(int64 *)(lVar6.equipmentData + 0x208) != 0) {
                lVar6 = FUN_18077c1c0(0);
                if (lVar6 == null) goto LAB_180b78ad8;
                lVar5 = lVar6.equipmentData;
                lVar6 = FUN_18077c1c0(0);
                if (((lVar6 == null) || (lVar6.equipmentData == null)) || (lVar5 == null))
                goto LAB_180b78ad8;
                uVar4 = *(uint64 *)(lVar6.equipmentData + 0x208);
                goto LAB_180b785b1;
              }
            }
            else if (lVar6.subType == 1) {
              lVar6 = FUN_18077c1c0(0);
              if ((lVar6 == null) || (lVar6.equipmentData == null)) goto LAB_180b78ad8;
              if (*(int64 *)(lVar6.equipmentData + 0x218) != 0) {
                lVar6 = FUN_18077c1c0(0);
                if (lVar6 == null) goto LAB_180b78ad8;
                lVar5 = lVar6.equipmentData;
                lVar6 = FUN_18077c1c0(0);
                if (((lVar6 == null) || (lVar6.equipmentData == null)) || (lVar5 == null))
                goto LAB_180b78ad8;
                uVar4 = *(uint64 *)(lVar6.equipmentData + 0x218);
                goto LAB_180b785b1;
              }
            }
        LAB_180b785c1:
            if (*pStatics_ece0 == 0) goto LAB_180b78ad8;
            *(uint8 *)(*pStatics_ece0 + 192) = 1;
          }
        }
        lVar6 = FUN_18077c1c0(0);
        if ((lVar6 != null) && (lVar6.equipmentData != null)) {
          HeroData.EquipItem(lVar6.equipmentData,this.itemData,1,1,0);
          return;
        }
        goto LAB_180b78ad8;
    }

    // Token : 0x600183D
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

    // Token : 0x600183E
    // RVA   : 0xB7B0A0   Offset: 0xB798A0   Length: 0x13C
    private static void /*cctor*/()
    {
        var pStatics = *(int64*)(DAT_181d5cff8 + 184);
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
        puVar1 = *(uint32 **)(DAT_181d5cff8 + 184);
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
