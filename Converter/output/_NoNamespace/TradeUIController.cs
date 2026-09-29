// ============================================================
// Type  : TradeUIController
// Token : 0x20003A4
// ============================================================

public class TradeUIController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001D92
    public static List<string> TradeRightLabel;

    // Token: 0x4001D93
    public TradeUIType tradeUIType;

    // Token: 0x4001D94
    public ItemListType forceItemListType;

    // Token: 0x4001D95
    public bool useAreaItemPrice;

    // Token: 0x4001D96
    public bool noSell;

    // Token: 0x4001D97
    public GameObject tradeUI;

    // Token: 0x4001D98
    public int deltaMoney;

    // Token: 0x4001D99
    public float deltaWeight;

    // Token: 0x4001D9A
    public ItemListController leftList;

    // Token: 0x4001D9B
    public ItemListController leftOutList;

    // Token: 0x4001D9C
    public ItemListController rightList;

    // Token: 0x4001D9D
    public ItemListController rightOutList;

    // Token: 0x4001D9E
    public Text leftResourceLabel;

    // Token: 0x4001D9F
    public Text rightResourceLabel;

    // Token: 0x4001DA0
    public Text deltaResourceLabel;

    // Token: 0x4001DA1
    public Text leftWeightLabel;

    // Token: 0x4001DA2
    public Text rightWeightLabel;

    // Token: 0x4001DA3
    public Text deltaWeightLabel;

    // Token: 0x4001DA4
    public GameObject leftDiscount;

    // Token: 0x4001DA5
    public GameObject rightDiscount;

    // Token: 0x4001DA6
    public GameObject areaDiscount;

    // Token: 0x4001DA7
    public GameObject speDiscount;

    // Token: 0x4001DA8
    public int minItemLv;

    // Token: 0x4001DA9
    public int maxItemLv;

    // Token: 0x4001DAA
    public float speSellValueRate;

    // Token: 0x4001DAB
    public float speBuyValueRate;

    // Token: 0x4001DAC
    public ItemListData discardItemList;

    // Token: 0x4001DAD
    public bool discard;

    // Token: 0x4001DAE
    private static TradeUIController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002301
    // RVA   : 0xAAB1C0   Offset: 0xAAA5C0   Length: 0x58
    public static TradeUIController get_Instance()
    {
        return *(uint64 *)(*(int64 *)(DAT_181dad390 + 184) + 8);
    }

    // Token : 0x6002302
    // RVA   : 0xAA6300   Offset: 0xAA5700   Length: 0x68
    private void Awake()
    {
        puVar1 = (uint64 *)(*(int64 *)(DAT_181dad390 + 184) + 8);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x6002303
    // RVA   : 0xAA65D0   Offset: 0xAA59D0   Length: 0x1F58
    public void FreshResourceLabel()
    {
        var pStatics_3d40 = *(int64*)(DAT_181d73d40 + 184);
        var pStatics_b4a8 = *(int64*)(DAT_181dab4a8 + 184);
        long lVar3;
        byte uVar4;
        bool cVar5;
        long lVar6;
        ulong uVar9;
        ulong uVar10;
        ulong uVar11;
        long lVar12;
        int iVar13;
        uint uVar15;
        uint uVar16;
        uint uVar17;
        uint uVar18;
        float[] local_res8 = new float[4];
        int[] local_res18 = new int[2];
        int[] local_res20 = new int[2];
        uint local_58;
        uint uStack_54;
        uint uStack_50;
        uint32 uStack_4c;
        iVar13 = this.tradeUIType;
        local_res8[0] = 0.0;
        if (iVar13 == 0) {
          if (((this.leftResourceLabel == null) ||
              (lVar6 = Component.get_transform(this.leftResourceLabel,0)) == null) ||
             (lVar6 = Transform.Find(lVar6,"Icon",0)) == null) throw; // [null/range check failed]
          plVar7 = (int64 *)Component.GetComponent(lVar6,DAT_181d94478);
          puVar8 = (uint32 *)FUN_1810d3b80(&local_58,0);
          if (plVar7 == (int64 *)0) throw; // [null/range check failed]
          local_58 = *puVar8;
          uStack_54 = puVar8[1];
          uStack_50 = puVar8[2];
          uStack_4c = puVar8[3];
          (**(code **)(*plVar7 + 0x2a8))(plVar7,&local_58,*(uint64 *)(*plVar7 + 0x2b0));
          if (((this.leftResourceLabel == null) ||
              (lVar6 = Component.get_transform(this.leftResourceLabel,0)) == null) ||
             (lVar6 = Transform.Find(lVar6,"Icon",0)) == null) throw; // [null/range check failed]
          lVar6 = Component.GetComponent(lVar6,DAT_181d94478);
          if ((*pStatics_b4a8 == 0) ||
             (uVar9 = TextureController.LoadAtlasSprite
                                (*pStatics_b4a8,"UIAtlas","银钱",0),
             lVar6 == null)) throw; // [null/range check failed]
          Image.set_sprite(lVar6,uVar9,0);
          plVar7 = this.leftResourceLabel;
          if ((this.leftList == null) ||
             ((lVar6 = this.leftList.targetItemList, lVar6 == null ||
              (uVar9 = Int32.ToString(lVar6 + 24,0), plVar7 == (int64 *)0)))) throw; // [null/range check failed]
          (**(code **)(*plVar7 + 0x5e8))(plVar7,uVar9,*(uint64 *)(*plVar7 + 0x5f0));
          if ((this.rightResourceLabel == null) ||
             ((lVar6 = Component.get_transform(this.rightResourceLabel,0), lVar6 == null ||
              (lVar6 = Transform.Find(lVar6,"Icon",0)) == null))) throw; // [null/range check failed]
          plVar7 = (int64 *)Component.GetComponent(lVar6,DAT_181d94478);
          puVar8 = (uint32 *)FUN_1810d3b80(&local_58,0);
          if (plVar7 == (int64 *)0) throw; // [null/range check failed]
          local_58 = *puVar8;
          uStack_54 = puVar8[1];
          uStack_50 = puVar8[2];
          uStack_4c = puVar8[3];
          (**(code **)(*plVar7 + 0x2a8))(plVar7,&local_58,*(uint64 *)(*plVar7 + 0x2b0));
          if (((this.rightResourceLabel == null) ||
              (lVar6 = Component.get_transform(this.rightResourceLabel,0)) == null) ||
             (lVar6 = Transform.Find(lVar6,"Icon",0)) == null) throw; // [null/range check failed]
          lVar6 = Component.GetComponent(lVar6,DAT_181d94478);
          if ((*pStatics_b4a8 == 0) ||
             (uVar9 = TextureController.LoadAtlasSprite
                                (*pStatics_b4a8,"UIAtlas","银钱",0),
             lVar6 == null)) throw; // [null/range check failed]
          Image.set_sprite(lVar6,uVar9,0);
          plVar7 = this.rightResourceLabel;
          if ((this.rightList == null) ||
             ((lVar6 = this.rightList.targetItemList, lVar6 == null ||
              (uVar9 = Int32.ToString(lVar6 + 24,0), plVar7 == (int64 *)0)))) throw; // [null/range check failed]
          (**(code **)(*plVar7 + 0x5e8))(plVar7,uVar9,*(uint64 *)(*plVar7 + 0x5f0));
          if ((this.deltaResourceLabel == null) ||
             ((lVar6 = Component.get_transform(this.deltaResourceLabel,0), lVar6 == null ||
              (lVar6 = Transform.Find(lVar6,"Icon",0)) == null))) throw; // [null/range check failed]
          plVar7 = (int64 *)Component.GetComponent(lVar6,DAT_181d94478);
          puVar8 = (uint32 *)FUN_1810d3b80(&local_58,0);
          if (plVar7 == (int64 *)0) throw; // [null/range check failed]
          local_58 = *puVar8;
          uStack_54 = puVar8[1];
          uStack_50 = puVar8[2];
          uStack_4c = puVar8[3];
          (**(code **)(*plVar7 + 0x2a8))(plVar7,&local_58,*(uint64 *)(*plVar7 + 0x2b0));
          if (((this.deltaResourceLabel == null) ||
              (lVar6 = Component.get_transform(this.deltaResourceLabel,0)) == null) ||
             (lVar6 = Transform.Find(lVar6,"Icon",0)) == null) throw; // [null/range check failed]
          lVar6 = Component.GetComponent(lVar6,DAT_181d94478);
          lVar12 = *pStatics_b4a8;
          uVar9 = "银钱";
        joined_r0x000180aa7422:
          if ((lVar12 == null) ||
             (uVar9 = TextureController.LoadAtlasSprite(lVar12,"UIAtlas",uVar9,0), lVar6 == null))
          throw; // [null/range check failed]
          Image.set_sprite(lVar6,uVar9,0);
          plVar7 = this.deltaResourceLabel;
          uVar9 = Int32.ToString(this + 48,"+0;-0;0",0);
          if (plVar7 == (int64 *)0) throw; // [null/range check failed]
          (**(code **)(*plVar7 + 0x5e8))(plVar7,uVar9,*(uint64 *)(*plVar7 + 0x5f0));
        }
        else {
          if (iVar13 != 1) {
            if (iVar13 == 2) {
              if (((this.leftResourceLabel == null) ||
                  (lVar6 = Component.get_transform(this.leftResourceLabel,0)) == null) ||
                 (lVar6 = Transform.Find(lVar6,"Icon",0)) == null) throw; // [null/range check failed]
              plVar7 = (int64 *)Component.GetComponent(lVar6,DAT_181d94478);
              puVar8 = (uint32 *)FUN_1810d3b80(&local_58,0);
              if (plVar7 == (int64 *)0) throw; // [null/range check failed]
              local_58 = *puVar8;
              uStack_54 = puVar8[1];
              uStack_50 = puVar8[2];
              uStack_4c = puVar8[3];
              (**(code **)(*plVar7 + 0x2a8))(plVar7,&local_58,*(uint64 *)(*plVar7 + 0x2b0));
              if (((this.leftResourceLabel == null) ||
                  (lVar6 = Component.get_transform(this.leftResourceLabel,0)) == null) ||
                 (lVar6 = Transform.Find(lVar6,"Icon",0)) == null) throw; // [null/range check failed]
              lVar6 = Component.GetComponent(lVar6,DAT_181d94478);
              if ((*pStatics_b4a8 == 0) ||
                 (uVar9 = TextureController.LoadAtlasSprite
                                    (*pStatics_b4a8,"UIAtlas","功绩",0),
                 lVar6 == null)) throw; // [null/range check failed]
              Image.set_sprite(lVar6,uVar9,0);
              plVar7 = this.leftResourceLabel;
              lVar6 = FUN_18046c0a0(0);
              if (((lVar6 == null) || (*(int64 *)(lVar6 + 32) == 0)) ||
                 (lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0)) == null)
              throw; // [null/range check failed]
              local_res8[0] = (float)HeroData.SelfForceContrituion(lVar6,0);
              uVar9 = Single.ToString(local_res8,"f0",0);
              if (plVar7 == (int64 *)0) throw; // [null/range check failed]
              (**(code **)(*plVar7 + 0x5e8))(plVar7,uVar9,*(uint64 *)(*plVar7 + 0x5f0));
              if (((this.rightResourceLabel == null) ||
                  (lVar6 = Component.get_transform(this.rightResourceLabel,0)) == null) ||
                 (lVar6 = Transform.Find(lVar6,"Icon",0)) == null) throw; // [null/range check failed]
              plVar7 = (int64 *)Component.GetComponent(lVar6,DAT_181d94478);
              puVar8 = (uint32 *)FUN_180d995f0(&local_58,0);
              if (plVar7 == (int64 *)0) throw; // [null/range check failed]
              local_58 = *puVar8;
              uStack_54 = puVar8[1];
              uStack_50 = puVar8[2];
              uStack_4c = puVar8[3];
              (**(code **)(*plVar7 + 0x2a8))(plVar7,&local_58,*(uint64 *)(*plVar7 + 0x2b0));
              plVar7 = this.rightResourceLabel;
              if (plVar7 == (int64 *)0) throw; // [null/range check failed]
              (**(code **)(*plVar7 + 0x5e8))(plVar7,"",*(uint64 *)(*plVar7 + 0x5f0));
              if (((this.deltaResourceLabel == null) ||
                  (lVar6 = Component.get_transform(this.deltaResourceLabel,0)) == null) ||
                 (lVar6 = Transform.Find(lVar6,"Icon",0)) == null) throw; // [null/range check failed]
              plVar7 = (int64 *)Component.GetComponent(lVar6,DAT_181d94478);
              puVar8 = (uint32 *)FUN_1810d3b80(&local_58,0);
              if (plVar7 == (int64 *)0) throw; // [null/range check failed]
              local_58 = *puVar8;
              uStack_54 = puVar8[1];
              uStack_50 = puVar8[2];
              uStack_4c = puVar8[3];
              (**(code **)(*plVar7 + 0x2a8))(plVar7,&local_58,*(uint64 *)(*plVar7 + 0x2b0));
              if (((this.deltaResourceLabel == null) ||
                  (lVar6 = Component.get_transform(this.deltaResourceLabel,0)) == null) ||
                 (lVar6 = Transform.Find(lVar6,"Icon",0)) == null) throw; // [null/range check failed]
              lVar6 = Component.GetComponent(lVar6,DAT_181d94478);
              lVar12 = *pStatics_b4a8;
              uVar9 = "功绩";
            }
            else {
              if ((iVar13 == 3) || (iVar13 != 4)) goto LAB_180aa6e5d;
              if ((this.leftResourceLabel == null) ||
                 ((lVar6 = Component.get_transform(this.leftResourceLabel,0), lVar6 == null ||
                  (lVar6 = Transform.Find(lVar6,"Icon",0)) == null))) throw; // [null/range check failed]
              plVar7 = (int64 *)Component.GetComponent(lVar6,DAT_181d94478);
              puVar8 = (uint32 *)FUN_1810d3b80(&local_58,0);
              if (plVar7 == (int64 *)0) throw; // [null/range check failed]
              local_58 = *puVar8;
              uStack_54 = puVar8[1];
              uStack_50 = puVar8[2];
              uStack_4c = puVar8[3];
              (**(code **)(*plVar7 + 0x2a8))(plVar7,&local_58,*(uint64 *)(*plVar7 + 0x2b0));
              if (((this.leftResourceLabel == null) ||
                  (lVar6 = Component.get_transform(this.leftResourceLabel,0)) == null) ||
                 (lVar6 = Transform.Find(lVar6,"Icon",0)) == null) throw; // [null/range check failed]
              lVar6 = Component.GetComponent(lVar6,DAT_181d94478);
              if ((*pStatics_b4a8 == 0) ||
                 (uVar9 = TextureController.LoadAtlasSprite
                                    (*pStatics_b4a8,"UIAtlas","官府功绩",0),
                 lVar6 == null)) throw; // [null/range check failed]
              Image.set_sprite(lVar6,uVar9,0);
              plVar7 = this.leftResourceLabel;
              lVar6 = FUN_18046c0a0(0);
              if (((lVar6 == null) || (*(int64 *)(lVar6 + 32) == 0)) ||
                 ((lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0), lVar6 == null ||
                  (uVar9 = Single.ToString(lVar6 + 0x1b4,"f0",0), plVar7 == (int64 *)0))))
              throw; // [null/range check failed]
              (**(code **)(*plVar7 + 0x5e8))(plVar7,uVar9,*(uint64 *)(*plVar7 + 0x5f0));
              if (((this.rightResourceLabel == null) ||
                  (lVar6 = Component.get_transform(this.rightResourceLabel,0)) == null) ||
                 (lVar6 = Transform.Find(lVar6,"Icon",0)) == null) throw; // [null/range check failed]
              plVar7 = (int64 *)Component.GetComponent(lVar6,DAT_181d94478);
              puVar8 = (uint32 *)FUN_180d995f0(&local_58,0);
              if (plVar7 == (int64 *)0) throw; // [null/range check failed]
              local_58 = *puVar8;
              uStack_54 = puVar8[1];
              uStack_50 = puVar8[2];
              uStack_4c = puVar8[3];
              (**(code **)(*plVar7 + 0x2a8))(plVar7,&local_58,*(uint64 *)(*plVar7 + 0x2b0));
              plVar7 = this.rightResourceLabel;
              if (plVar7 == (int64 *)0) throw; // [null/range check failed]
              (**(code **)(*plVar7 + 0x5e8))(plVar7,"",*(uint64 *)(*plVar7 + 0x5f0));
              if (((this.deltaResourceLabel == null) ||
                  (lVar6 = Component.get_transform(this.deltaResourceLabel,0)) == null) ||
                 (lVar6 = Transform.Find(lVar6,"Icon",0)) == null) throw; // [null/range check failed]
              plVar7 = (int64 *)Component.GetComponent(lVar6,DAT_181d94478);
              puVar8 = (uint32 *)FUN_1810d3b80(&local_58,0);
              if (plVar7 == (int64 *)0) throw; // [null/range check failed]
              local_58 = *puVar8;
              uStack_54 = puVar8[1];
              uStack_50 = puVar8[2];
              uStack_4c = puVar8[3];
              (**(code **)(*plVar7 + 0x2a8))(plVar7,&local_58,*(uint64 *)(*plVar7 + 0x2b0));
              if (((this.deltaResourceLabel == null) ||
                  (lVar6 = Component.get_transform(this.deltaResourceLabel,0)) == null) ||
                 (lVar6 = Transform.Find(lVar6,"Icon",0)) == null) throw; // [null/range check failed]
              lVar6 = Component.GetComponent(lVar6,DAT_181d94478);
              lVar12 = *pStatics_b4a8;
              uVar9 = "官府功绩";
            }
            goto joined_r0x000180aa7422;
          }
        LAB_180aa6e5d:
          if (((this.leftResourceLabel == null) ||
              (lVar6 = Component.get_transform(this.leftResourceLabel,0)) == null) ||
             (lVar6 = Transform.Find(lVar6,"Icon",0)) == null) throw; // [null/range check failed]
          plVar7 = (int64 *)Component.GetComponent(lVar6,DAT_181d94478);
          puVar8 = (uint32 *)FUN_180d995f0(&local_58,0);
          if (plVar7 == (int64 *)0) throw; // [null/range check failed]
          local_58 = *puVar8;
          uStack_54 = puVar8[1];
          uStack_50 = puVar8[2];
          uStack_4c = puVar8[3];
          (**(code **)(*plVar7 + 0x2a8))(plVar7,&local_58,*(uint64 *)(*plVar7 + 0x2b0));
          plVar7 = this.leftResourceLabel;
          if (plVar7 == (int64 *)0) throw; // [null/range check failed]
          (**(code **)(*plVar7 + 0x5e8))(plVar7,"",*(uint64 *)(*plVar7 + 0x5f0));
          if (((this.rightResourceLabel == null) ||
              (lVar6 = Component.get_transform(this.rightResourceLabel,0)) == null) ||
             (lVar6 = Transform.Find(lVar6,"Icon",0)) == null) throw; // [null/range check failed]
          plVar7 = (int64 *)Component.GetComponent(lVar6,DAT_181d94478);
          puVar8 = (uint32 *)FUN_180d995f0(&local_58,0);
          if (plVar7 == (int64 *)0) throw; // [null/range check failed]
          local_58 = *puVar8;
          uStack_54 = puVar8[1];
          uStack_50 = puVar8[2];
          uStack_4c = puVar8[3];
          (**(code **)(*plVar7 + 0x2a8))(plVar7,&local_58,*(uint64 *)(*plVar7 + 0x2b0));
          plVar7 = this.rightResourceLabel;
          if (plVar7 == (int64 *)0) throw; // [null/range check failed]
          (**(code **)(*plVar7 + 0x5e8))(plVar7,"",*(uint64 *)(*plVar7 + 0x5f0));
          if (((this.deltaResourceLabel == null) ||
              (lVar6 = Component.get_transform(this.deltaResourceLabel,0)) == null) ||
             (lVar6 = Transform.Find(lVar6,"Icon",0)) == null) throw; // [null/range check failed]
          plVar7 = (int64 *)Component.GetComponent(lVar6,DAT_181d94478);
          puVar8 = (uint32 *)FUN_180d995f0(&local_58,0);
          if (plVar7 == (int64 *)0) throw; // [null/range check failed]
          local_58 = *puVar8;
          uStack_54 = puVar8[1];
          uStack_50 = puVar8[2];
          uStack_4c = puVar8[3];
          (**(code **)(*plVar7 + 0x2a8))(plVar7,&local_58,*(uint64 *)(*plVar7 + 0x2b0));
          plVar7 = this.deltaResourceLabel;
          if (plVar7 == (int64 *)0) throw; // [null/range check failed]
          (**(code **)(*plVar7 + 0x5e8))(plVar7,"",*(uint64 *)(*plVar7 + 0x5f0));
        }
        if (((this.leftWeightLabel != null) &&
            (lVar6 = Component.get_transform(this.leftWeightLabel,0)) != null) &&
           (lVar6 = Transform.Find(lVar6,"Icon",0)) != null) {
          plVar7 = (int64 *)Component.GetComponent(lVar6,DAT_181d94478);
          if ((this.leftList != null) &&
             (lVar6 = this.leftList.targetItemList) != null) {
            pfVar1 = (float *)(lVar6 + 32);
            if (0.0 < *pfVar1 || *pfVar1 == 0.0) {
              puVar8 = (uint32 *)FUN_1810d3b80(&local_58,0);
            }
            else {
              puVar8 = (uint32 *)FUN_180d995f0();
            }
            if (plVar7 != (int64 *)0) {
              local_58 = *puVar8;
              uStack_54 = puVar8[1];
              uStack_50 = puVar8[2];
              uStack_4c = puVar8[3];
              (**(code **)(*plVar7 + 0x2a8))(plVar7,&local_58,*(uint64 *)(*plVar7 + 0x2b0));
              plVar7 = this.leftWeightLabel;
              if ((this.leftList != null) &&
                 (lVar6 = this.leftList.targetItemList) != null) {
                uVar9 = "";
                if (0.0 < *(float *)(lVar6 + 32) || *(float *)(lVar6 + 32) == 0.0) {
                  local_res18[0] = (int)*(float *)(lVar6 + 28);
                  uVar9 = il2cpp_value_box(DAT_181d80430,local_res18);
                  if ((this.leftList == null) ||
                     (lVar6 = this.leftList.targetItemList) == null) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  local_res20[0] = (int)*(float *)(lVar6 + 32);
                  uVar11 = il2cpp_value_box(DAT_181d80430,local_res20);
                  uVar9 = String.Format("{0}/{1}",uVar9,uVar11,0);
                }
                if (plVar7 != (int64 *)0) {
                  (**(code **)(*plVar7 + 0x5e8))(plVar7,uVar9,*(uint64 *)(*plVar7 + 0x5f0));
                  plVar7 = this.leftWeightLabel;
                  if ((this.leftList != null) &&
                     (lVar6 = this.leftList.targetItemList) != null) {
                    if (0.0 <= *(float *)(lVar6 + 32)) {
                      if (*(float *)(lVar6 + 32) < *(float *)(lVar6 + 28)) {
                        lVar6 = pStatics_3d40;
                        uVar15 = *(uint32 *)(lVar6 + 0x300);
                        uVar16 = *(uint32 *)(lVar6 + 0x304);
                        uVar17 = *(uint32 *)(lVar6 + 0x308);
                        uVar18 = *(uint32 *)(lVar6 + 0x30c);
                      }
                      else {
                        puVar8 = (uint32 *)Color.get_black(&local_58,0);
                        uVar15 = *puVar8;
                        uVar16 = puVar8[1];
                        uVar17 = puVar8[2];
                        uVar18 = puVar8[3];
                      }
                    }
                    else {
                      puVar8 = (uint32 *)Color.get_black(&local_58,0);
                      uVar15 = *puVar8;
                      uVar16 = puVar8[1];
                      uVar17 = puVar8[2];
                      uVar18 = puVar8[3];
                    }
                    if (plVar7 != (int64 *)0) {
                      local_58 = uVar15;
                      uStack_54 = uVar16;
                      uStack_50 = uVar17;
                      uStack_4c = uVar18;
                      (**(code **)(*plVar7 + 0x2a8))(plVar7,&local_58,*(uint64 *)(*plVar7 + 0x2b0));
                      if (((this.rightWeightLabel != null) &&
                          (lVar6 = Component.get_transform(this.rightWeightLabel,0)) != null)
                         && (lVar6 = Transform.Find(lVar6,"Icon",0)) != null) {
                        plVar7 = (int64 *)Component.GetComponent(lVar6,DAT_181d94478);
                        if ((this.rightList != null) &&
                           (lVar6 = this.rightList.targetItemList) != null) {
                          pfVar1 = (float *)(lVar6 + 32);
                          if (0.0 < *pfVar1 || *pfVar1 == 0.0) {
                            puVar8 = (uint32 *)FUN_1810d3b80(&local_58,0);
                          }
                          else {
                            puVar8 = (uint32 *)FUN_180d995f0();
                          }
                          if (plVar7 != (int64 *)0) {
                            local_58 = *puVar8;
                            uStack_54 = puVar8[1];
                            uStack_50 = puVar8[2];
                            uStack_4c = puVar8[3];
                            (**(code **)(*plVar7 + 0x2a8))
                                      (plVar7,&local_58,*(uint64 *)(*plVar7 + 0x2b0));
                            plVar7 = this.rightWeightLabel;
                            if ((this.rightList != null) &&
                               (lVar6 = this.rightList.targetItemList) != null)
                            {
                              uVar9 = "";
                              if (0.0 < *(float *)(lVar6 + 32) || *(float *)(lVar6 + 32) == 0.0) {
                                local_res18[0] = (int)*(float *)(lVar6 + 28);
                                uVar9 = il2cpp_value_box(DAT_181d80430,local_res18);
                                if ((this.rightList == null) ||
                                   (lVar6 = this.rightList.targetItemList,
                                   lVar6 == null)) {
                          // WARNING: Subroutine does not return
                                  FUN_1800d6620();
                                }
                                local_res20[0] = (int)*(float *)(lVar6 + 32);
                                uVar11 = il2cpp_value_box(DAT_181d80430,local_res20);
                                uVar9 = String.Format("{0}/{1}",uVar9,uVar11,0);
                              }
                              if (plVar7 != (int64 *)0) {
                                (**(code **)(*plVar7 + 0x5e8))
                                          (plVar7,uVar9,*(uint64 *)(*plVar7 + 0x5f0));
                                plVar7 = this.rightWeightLabel;
                                if ((this.rightList != null) &&
                                   (lVar6 = this.rightList.targetItemList,
                                   lVar6 != null)) {
                                  if (0.0 <= *(float *)(lVar6 + 32)) {
                                    if (*(float *)(lVar6 + 32) < *(float *)(lVar6 + 28)) {
                                      lVar6 = pStatics_3d40;
                                      uVar15 = *(uint32 *)(lVar6 + 0x300);
                                      uVar16 = *(uint32 *)(lVar6 + 0x304);
                                      uVar17 = *(uint32 *)(lVar6 + 0x308);
                                      uVar18 = *(uint32 *)(lVar6 + 0x30c);
                                    }
                                    else {
                                      puVar8 = (uint32 *)Color.get_black(&local_58,0);
                                      uVar15 = *puVar8;
                                      uVar16 = puVar8[1];
                                      uVar17 = puVar8[2];
                                      uVar18 = puVar8[3];
                                    }
                                  }
                                  else {
                                    puVar8 = (uint32 *)Color.get_black(&local_58,0);
                                    uVar15 = *puVar8;
                                    uVar16 = puVar8[1];
                                    uVar17 = puVar8[2];
                                    uVar18 = puVar8[3];
                                  }
                                  if (plVar7 != (int64 *)0) {
                                    local_58 = uVar15;
                                    uStack_54 = uVar16;
                                    uStack_50 = uVar17;
                                    uStack_4c = uVar18;
                                    (**(code **)(*plVar7 + 0x2a8))
                                              (plVar7,&local_58,*(uint64 *)(*plVar7 + 0x2b0));
                                    if (((this.deltaWeightLabel != null) &&
                                        (lVar6 = Component.get_transform(this.deltaWeightLabel,0)
                                        , lVar6 != null)) &&
                                       (lVar6 = Transform.Find(lVar6,"Icon",0)) != null) {
                                      plVar7 = (int64 *)Component.GetComponent(lVar6,DAT_181d94478);
                                      if (this.deltaWeight == null.0) {
                                        puVar8 = (uint32 *)FUN_180d995f0(&local_58,0);
                                      }
                                      else {
                                        puVar8 = (uint32 *)FUN_1810d3b80(&local_58,0);
                                      }
                                      if (plVar7 != (int64 *)0) {
                                        local_58 = *puVar8;
                                        uStack_54 = puVar8[1];
                                        uStack_50 = puVar8[2];
                                        uStack_4c = puVar8[3];
                                        (**(code **)(*plVar7 + 0x2a8))
                                                  (plVar7,&local_58,*(uint64 *)(*plVar7 + 0x2b0));
                                        plVar7 = this.deltaWeightLabel;
                                        uVar9 = "";
                                        if (this.deltaWeight != null.0) {
                                          uVar9 = Single.ToString(this + 52,"+0;-0;0",0);
                                        }
                                        if (plVar7 != (int64 *)0) {
                                          (**(code **)(*plVar7 + 0x5e8))
                                                    (plVar7,uVar9,*(uint64 *)(*plVar7 + 0x5f0));
                                          lVar6 = this.leftDiscount;
                                          if (this.tradeUIType == null) {
                                            if (lVar6 != null) {
                                              GameObject.SetActive(lVar6,1,0);
                                              if (((this.leftDiscount != null) &&
                                                  (lVar6 = GameObject.get_transform
                                                                     (this.leftDiscount,0),
                                                  lVar6 != null)) &&
                                                 (lVar6 = Transform.Find(lVar6,"Text",0),
                                                 lVar6 != null)) {
                                                uVar9 = Component.GetComponent(lVar6,DAT_181d96178);
                                                lVar6 = *(int64 *)
                                                         (pStatics_3d40 + 0x4b0);
                                                if (lVar6 != null) {
                                                  if (*(uint32 *)(lVar6 + 24) < 4) {
                                                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                                  }
                                                  uVar11 = *(uint64 *)
                                                            (*(int64 *)(lVar6 + 16) + 56);
                                                  if ((((GameController._instance != null) &&
                                                       (lVar6 = *(int64 *)
                                                                 (GameController._instance +
                                                                 32), lVar6 != null)) &&
                                                      (lVar6 = WorldData.Player(lVar6,0)) != null) &&
                                                     (lVar6 = *(int64 *)(lVar6 + 0x168)) != null) {
                                                    if (*(uint32 *)(lVar6 + 24) < 4) {
                                                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                                    }
                                                    local_res8[0] =
                                                         *(float *)(*(int64 *)(lVar6 + 16) + 44);
                                                    uVar10 = Single.ToString(local_res8,"f0",0);
                                                    uVar11 = String.Concat(uVar11,uVar10,0);
                                                    LTLocalization.SetText(uVar9,uVar11,0);
                                                    if (this.leftDiscount != null) {
                                                      lVar6 = GameObject.GetComponent
                                                                        (this.leftDiscount,
                                                                         DAT_181d73448);
                                                      if (((GameController._instance != null) &&
                                                          (lVar12 = *(int64 *)
                                                                     (**(int64 **)
                                                                        (DAT_181d72cc8 + 184) + 32),
                                                          lVar12 != null)) &&
                                                         (lVar12 = WorldData.Player(lVar12,0),
                                                         lVar12 != null)) {
                                                        local_res8[0] =
                                                             (float)HeroData.GetTradeValueRate
                                                                              (lVar12,1,0);
                                                        local_res8[0] = local_res8[0] * 100.0;
                                                        uVar9 = Single.ToString(local_res8,"f0",
                                                                                 0);
                                                        if (((GameController._instance != null)
                                                            && (lVar12 = *(int64 *)
                                                                          (**(int64 **)
                                                                             (DAT_181d72cc8 + 184) + 32
                                                                          ), lVar12 != null)) &&
                                                           (lVar12 = WorldData.Player(lVar12,0),
                                                           lVar12 != null)) {
                                                          local_res8[0] =
                                                               (float)HeroData.GetTradeValueRate
                                                                                (lVar12,0,0);
                                                          local_res8[0] = local_res8[0] * 100.0;
                                                          uVar11 = Single.ToString(local_res8,
                                                                                    "f0",0);
                                                          uVar9 = String.Format("购买价格{0}%\n出售价格{1}%",uVar9,
                                                                                 uVar11,0);
                                                          if (lVar6 != null) {
                                                            *(uint64 *)(lVar6 + 24) = uVar9;
                                                            il2cpp_internal((uint64 *)
                                                                                (lVar6 + 24),uVar9);
                                                            lVar6 = this.rightDiscount;
                                                            if (((this.rightList != null) &&
                                                                (lVar12 = *(int64 *)
                                                                           (this.rightList
                                                                           + 48), lVar12 != null)) &&
                                                               (uVar4 = ItemListData.BelongHero(lVar12,0)
                                                               , lVar6 != null)) {
                                                              GameObject.SetActive(lVar6,uVar4,0);
                                                              if ((this.rightList != null) &&
                                                                 (lVar6 = *(int64 *)
                                                                           (this.rightList
                                                                           + 48), lVar6 != null)) {
                                                                cVar5 = ItemListData.BelongHero(lVar6,0);
                                                                if (cVar5) {
                                                                  if (((this.rightDiscount == null
                                                                       ) || (lVar6 = 
                                                        GameObject.get_transform
                                                                  (this.rightDiscount,0),
                                                        lVar6 == null)) ||
                                                        (lVar6 = Transform.Find(lVar6,"Text",0),
                                                        lVar6 == null)) throw; // [null/range check failed]
                                                        uVar9 = Component.GetComponent
                                                                          (lVar6,DAT_181d96178);
                                                        lVar6 = FUN_18046c0a0(0);
                                                        if (lVar6 == null) throw; // [null/range check failed]
                                                        if ((((this.rightList == null) ||
                                                             (lVar12 = *(int64 *)
                                                                        (this.rightList +
                                                                        48), lVar12 == null)) ||
                                                            (*(int64 *)(lVar6 + 32) == 0)) ||
                                                           (lVar6 = WorldData.GetHero(*(int64 *)
                                                                                        (lVar6 + 32),
                                                                                       *(uint32 *)
                                                                                        (lVar12 + 16),0)
                                                           , lVar6 == null)) throw; // [null/range check failed]
                                                        local_res8[0] = (float)HeroData.Favor(lVar6,0,0);
                                                        uVar11 = Single.ToString(local_res8,"f0"
                                                                                  ,0);
                                                        uVar11 = String.Concat("好感",uVar11,0);
                                                        LTLocalization.SetText(uVar9,uVar11,0);
                                                        if (this.rightDiscount == null)
                                                        throw; // [null/range check failed]
                                                        lVar6 = GameObject.GetComponent
                                                                          (this.rightDiscount,
                                                                           DAT_181d73448);
                                                        lVar12 = FUN_18046c0a0(0);
                                                        if (lVar12 == null) throw; // [null/range check failed]
                                                        if (((this.rightList == null) ||
                                                            (lVar3 = *(int64 *)
                                                                      (this.rightList +
                                                                      48), lVar3 == null)) ||
                                                           ((*(int64 *)(lVar12 + 32) == 0 ||
                                                            (lVar12 = WorldData.GetHero(*(int64 *)
                                                                                          (lVar12 + 32),
                                                                                         *(uint32 *)
                                                                                          (lVar3 + 16),0
                                                                                        ), lVar12 == null))))
                                                        throw; // [null/range check failed]
                                                        local_res8[0] =
                                                             (float)HeroData.GetFavorValueRate
                                                                              (lVar12,1,0);
                                                        local_res8[0] = local_res8[0] * 100.0;
                                                        uVar9 = Single.ToString(local_res8,"f0",
                                                                                 0);
                                                        lVar12 = FUN_18046c0a0(0);
                                                        if (lVar12 == null) throw; // [null/range check failed]
                                                        if ((((this.rightList == null) ||
                                                             (lVar3 = *(int64 *)
                                                                       (this.rightList +
                                                                       48), lVar3 == null)) ||
                                                            (*(int64 *)(lVar12 + 32) == 0)) ||
                                                           (lVar12 = WorldData.GetHero(*(int64 *)
                                                                                         (lVar12 + 32),
                                                                                        *(uint32 *)
                                                                                         (lVar3 + 16),0)
                                                           , lVar12 == null)) throw; // [null/range check failed]
                                                        local_res8[0] =
                                                             (float)HeroData.GetFavorValueRate
                                                                              (lVar12,0,0);
                                                        local_res8[0] = local_res8[0] * 100.0;
                                                        uVar11 = Single.ToString(local_res8,"f0"
                                                                                  ,0);
                                                        uVar9 = String.Format("购买折扣x{0}%\n出售折扣x{1}%",uVar9,uVar11,
                                                                               0);
                                                        if (lVar6 == null) throw; // [null/range check failed]
                                                        *(uint64 *)(lVar6 + 24) = uVar9;
                                                        il2cpp_internal((uint64 *)(lVar6 + 24),
                                                                            uVar9);
                                                        }
                                                        lVar6 = this.areaDiscount;
                                                        if (!this.useAreaItemPrice) {
                                                          bVar14 = false;
                                                        }
                                                        else {
                                                          lVar12 = FUN_18046bac0(0);
                                                          if (lVar12 == null) throw; // [null/range check failed]
                                                          bVar14 = *(int64 *)(lVar12 + 88) != 0;
                                                        }
                                                        iVar13 = 0;
                                                        if (lVar6 != null) {
                                                          GameObject.SetActive(lVar6,bVar14,0);
                                                          if (this.useAreaItemPrice) {
                                                            lVar6 = FUN_18046bac0(0);
                                                            if (lVar6 == null) throw; // [null/range check failed]
                                                            if (*(int64 *)(lVar6 + 88) != 0) {
                                                              if (((this.areaDiscount != null) &&
                                                                  (lVar6 = GameObject.get_transform
                                                                                     (*(int64 *)
                                                                                       (this + 152),0)
                                                                  , lVar6 != null)) &&
                                                                 (lVar6 = Transform.Find(lVar6,
                                                        "Text",0), lVar6 != null)) {
                                                          uVar9 = Component.GetComponent
                                                                            (lVar6,DAT_181d96178);
                                                          lVar6 = FUN_18046bac0(0);
                                                          if ((lVar6 != null) &&
                                                             (*(int64 *)(lVar6 + 88) != 0)) {
                                                            local_res8[0] =
                                                                 (float)AreaData.GetSafe(*(int64 *)
                                                                                           (lVar6 + 88),
                                                                                          0);
                                                            uVar11 = Single.ToString(local_res8,
                                                                                      "f0",0);
                                                            uVar11 = String.Concat("治安",uVar11,0
                                                                                   );
                                                            LTLocalization.SetText(uVar9,uVar11,0);
                                                            if (this.areaDiscount != null) {
                                                              lVar6 = GameObject.GetComponent
                                                                                (*(int64 *)
                                                                                  (this + 152),
                                                                                 DAT_181d73448);
                                                              lVar12 = FUN_18046bac0(0);
                                                              if (lVar12 != null) {
                                                                local_res8[0] =
                                                                     (float)
                                                        AreaController.GetAreaSpePriceRate(lVar12,0);
                                                        local_res8[0] = local_res8[0] * 100.0;
                                                        uVar9 = Single.ToString(local_res8,"f0",
                                                                                 0);
                                                        uVar9 = String.Format("买卖价格x{0}%",uVar9,0);
                                                        if (lVar6 != null) {
                                                          *(uint64 *)(lVar6 + 24) = uVar9;
                                                          il2cpp_internal((uint64 *)(lVar6 + 24)
                                                                              ,uVar9);
                                                          while( true ) {
                                                            lVar6 = *(int64 *)
                                                                     (*(int64 *)(DAT_181dac770 + 184)
                                                                     + 56);
                                                            if (((lVar6 == null) ||
                                                                (lVar6 = *(int64 *)(lVar6 + 88),
                                                                lVar6 == null)) ||
                                                               (lVar6 = *(int64 *)(lVar6 + 224),
                                                               lVar6 == null)) break;
                                                            if (*(int *)(lVar6 + 24) <= iVar13)
                                                            goto LAB_180aa8388;
                                                            if ((this.areaDiscount == null) ||
                                                               (lVar6 = GameObject.GetComponent
                                                                                  (*(int64 *)
                                                                                    (this + 152),
                                                                                   DAT_181d73448),
                                                               lVar6 == null)) break;
                                                            puVar2 = (uint64 *)(lVar6 + 24);
                                                            uVar9 = *puVar2;
                                                            lVar6 = FUN_18046bac0(0);
                                                            if (((lVar6 == null) ||
                                                                (*(int64 *)(lVar6 + 88) == 0)) ||
                                                               ((lVar6 = *(int64 *)
                                                                          (*(int64 *)(lVar6 + 88) +
                                                                          224), lVar6 == null ||
                                                                (lVar6 = FUN_180002f80(lVar6,iVar13,
                                                                                       DAT_181d7ccf8),
                                                                lVar6 == null)))) break;
                                                            uVar11 = AreaTreasurePriceData.GetDescribe
                                                                               (lVar6,0);
                                                            uVar9 = String.Concat(uVar9,"\n",
                                                                                   uVar11,0);
                                                            *puVar2 = uVar9;
                                                            il2cpp_internal(puVar2);
                                                            iVar13 = iVar13 + 1;
                                                          }
                                                        }
                                                        }
                                                        }
                                                        }
                                                        }
                                                        throw; // [null/range check failed]
                                                        }
                                                        }
        LAB_180aa8388:
                                                        if (this.speDiscount != null) {
                                                          GameObject.SetActive
                                                                    (this.speDiscount,
                                                                     this.speBuyValueRate != 1.0,0);
                                                          if (this.speDiscount != null) {
                                                            cVar5 = GameObject.get_activeSelf
                                                                              (*(int64 *)
                                                                                (this + 160),0);
                                                            if (!cVar5) {
                                                              return;
                                                            }
                                                            if (((this.speDiscount != null) &&
                                                                (lVar6 = GameObject.get_transform
                                                                                   (*(int64 *)
                                                                                     (this + 160),0),
                                                                lVar6 != null)) &&
                                                               (lVar6 = Transform.Find(lVar6,
                                                        "Text",0), lVar6 != null)) {
                                                          uVar9 = Component.GetComponent
                                                                            (lVar6,DAT_181d96178);
                                                          local_res8[0] =
                                                               this.speBuyValueRate * 100.0;
                                                          uVar11 = Single.ToString(local_res8,
                                                                                    "f0",0);
                                                          uVar11 = String.Format("折扣{0}%",uVar11,0);
                                                          LTLocalization.SetText(uVar9,uVar11,0);
                                                          if (((this.speDiscount != null) &&
                                                              (lVar6 = GameObject.get_transform
                                                                                 (*(int64 *)
                                                                                   (this + 160),0),
                                                              lVar6 != null)) &&
                                                             (lVar6 = Transform.Find(lVar6,"Text",
                                                                                      0), lVar6 != null)) {
                                                            plVar7 = (int64 *)
                                                                     Component.GetComponent
                                                                               (lVar6,DAT_181d96178);
                                                            if (this.speBuyValueRate <= 1.0) {
                                                              puVar8 = (uint32 *)
                                                                       Color.get_green(&local_58,0);
                                                            }
                                                            else {
                                                              puVar8 = (uint32 *)Color.get_red();
                                                            }
                                                            if (plVar7 != (int64 *)0) {
                                                              local_58 = *puVar8;
                                                              uStack_54 = puVar8[1];
                                                              uStack_50 = puVar8[2];
                                                              uStack_4c = puVar8[3];
                                                              (**(code **)(*plVar7 + 0x2a8))
                                                                        (plVar7,&local_58,
                                                                         *(uint64 *)(*plVar7 + 0x2b0))
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
                                                        }
                                                        }
                                                      }
                                                    }
                                                  }
                                                }
                                              }
                                            }
                                          }
                                          else if (lVar6 != null) {
                                            GameObject.SetActive(lVar6,0,0);
                                            if (this.rightDiscount != null) {
                                              GameObject.SetActive(this.rightDiscount,0,0);
                                              if (this.areaDiscount != null) {
                                                GameObject.SetActive(this.areaDiscount,0,0);
                                                if (this.speDiscount != null) {
                                                  GameObject.SetActive(this.speDiscount,0,0)
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
                                }
                              }
                            }
                          }
                        }
                      }
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6002304
    // RVA   : 0xAA8530   Offset: 0xAA7930   Length: 0x43C
    public void HideTradeUI()
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        long lVar6;
        ulong local_18;
        ulong uStack_10;
        if (this.discard) {
          if (((this.rightList == null) ||
              (lVar6 = this.rightList.targetItemList) == null) ||
             (lVar6 = *(int64 *)(lVar6 + 40)) == null) throw; // [null/range check failed]
          if (0 < *(int *)(lVar6 + 24)) {
            lVar6 = **(int64 **)(DAT_181d7f6c0 + 184);
            if ((this.leftList == null) ||
               (lVar2 = this.leftList.targetItemList) == null)
            throw; // [null/range check failed]
            lVar2 = ItemListData.GetHero(lVar2,0);
            if (lVar2 == null) throw; // [null/range check failed]
            uVar3 = HeroData.HeroName(lVar2,0,0);
            if ((this.rightList == null) ||
               (lVar2 = this.rightList.targetItemList) == null)
            throw; // [null/range check failed]
            uVar4 = ItemListData.GetItemName(lVar2,0);
            uVar3 = String.Format("{0}丢弃了 {1}",uVar3,uVar4,0);
            if ((this.rightList == null) ||
               ((lVar2 = this.rightList.targetItemList, lVar2 == null ||
                (lVar2 = *(int64 *)(lVar2 + 40)) == null))) throw; // [null/range check failed]
            if (*(int *)(lVar2 + 24) == 0) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar2 = *(int64 *)(*(int64 *)(lVar2 + 16) + 32);
            if (lVar2 == null) throw; // [null/range check failed]
            uVar4 = ItemData.GetItemIconName(lVar2,0);
            puVar5 = (uint64 *)Color.get_red(&local_18,0);
            if (lVar6 == null) throw; // [null/range check failed]
            local_18 = *puVar5;
            uStack_10 = puVar5[1];
            InfoController.AddInfoTab
                      (lVar6,uVar3,"IconAtlas",uVar4,"ItemLose",0x3f800000,0x40a00000,&local_18,0);
          }
        }
        lVar6 = PlotController.SpringFestivelRewardLvTalkText;
        if (lVar6 == null) throw; // [null/range check failed]
        if (*(int64 *)(lVar6 + 88) != 0) {
          lVar6 = PlotController.SpringFestivelRewardLvTalkText;
          if ((lVar6 == null) || (lVar6 = *(int64 *)(lVar6 + 88)) == null) throw; // [null/range check failed]
          cVar1 = AreaData.HaveForce(lVar6,0);
          if (cVar1) {
            if (this.rightList == null) throw; // [null/range check failed]
            lVar6 = this.rightList.targetItemList;
            lVar2 = FUN_18046bac0(0);
            if ((lVar2 == null) || (*(int64 *)(lVar2 + 88) == 0)) throw; // [null/range check failed]
            lVar2 = AreaData.GetForce(*(int64 *)(lVar2 + 88),0);
            if (lVar2 == null) throw; // [null/range check failed]
            if (lVar6 == *(int64 *)(lVar2 + 184)) {
              lVar6 = FUN_18046bac0(0);
              if ((lVar6 == null) || (*(int64 *)(lVar6 + 88) == 0)) throw; // [null/range check failed]
              lVar6 = AreaData.GetForce(*(int64 *)(lVar6 + 88),0);
              if (lVar6 == null) throw; // [null/range check failed]
              *(uint8 *)(lVar6 + 192) = 1;
            }
          }
        }
        TradeUIController.CancelButtonClicked(this,0);
        if (this.discardItemList != null) {
          ItemListData.ClearAllItem(this.discardItemList,0);
          if (this.leftList != null) {
            ItemListController.ResetListType(this.leftList,0);
            if (this.rightList != null) {
              ItemListController.ResetListType(this.rightList,0);
              if (this.tradeUI != null) {
                GameObject.SetActive(this.tradeUI,0,0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x6002305
    // RVA   : 0xAAA450   Offset: 0xAA9850   Length: 0x5A
    public void ShowTradeUI(TradeUIType targetType, ItemListData leftItemList, ItemListData rightItemList, bool _useAreaItemPrice)
    {
        void TradeUIController.ShowTradeUI
                     (int64 this,uint32 targetType,uint32 leftItemList,int64 rightItemList,int64 _useAreaItemPrice,
                     uint32 param_6,uint32 param_7,uint8 param_8,uint8 param_9,
                     uint32 param_10,uint32 param_11)
        {
        char cVar1;
        bool bVar2;
        int64 lVar3;
        uint64 uVar4;
        uint64 uVar5;
        int64 *plVar6;
        int64 *plVar7;
        bool bVar8;
        if (this.tradeUI == null) throw; // [null/range check failed]
        GameObject.SetActive(this.tradeUI,1,0);
        this.deltaMoney = 0;
        this.tradeUIType = targetType;
        this.forceItemListType = leftItemList;
        if (this.leftList == null) throw; // [null/range check failed]
        this.leftList.forceItemListType = leftItemList;
        if (this.rightList == null) throw; // [null/range check failed]
        this.rightList.forceItemListType = leftItemList;
        this.minItemLv = param_6;
        this.maxItemLv = param_7;
        this.useAreaItemPrice = param_8;
        this.noSell = param_9;
        this.speSellValueRate = param_10;
        this.speBuyValueRate = param_11;
        bVar8 = false;
        if (targetType == null) {
          lVar3 = this.leftList;
          if (rightItemList == null) throw; // [null/range check failed]
          cVar1 = ItemListData.BelongHero(rightItemList,0);
          bVar2 = bVar8;
          if (cVar1) {
            bVar2 = *(int *)(rightItemList + 16) != 0;
          }
          if (lVar3 == null) throw; // [null/range check failed]
          lVar3.noEquipedItem = bVar2;
          lVar3 = this.rightList;
          if (_useAreaItemPrice == null) throw; // [null/range check failed]
          cVar1 = ItemListData.BelongHero(_useAreaItemPrice,0);
          if (cVar1) {
            bVar8 = *(int *)(_useAreaItemPrice + 16) != 0;
          }
          if (lVar3 == null) throw; // [null/range check failed]
          lVar3.noEquipedItem = bVar8;
        }
        bVar8 = _useAreaItemPrice == this.discardItemList;
        this.discard = bVar8;
        lVar3 = this.tradeUI;
        if (bVar8) {
          if (((lVar3 == null) || (lVar3 = GameObject.get_transform(lVar3,0)) == null) ||
             (lVar3 = Transform.Find(lVar3,"RightLabel",0)) == null) throw; // [null/range check failed]
          uVar4 = Component.GetComponent(lVar3,DAT_181d96178);
          uVar5 = "丢弃";
          if (((*(byte *)(DAT_181d848b0 + 0x133) & 4) != 0) && (*(int *)(DAT_181d848b0 + 224) == 0)) {
            il2cpp_runtime_class_init();
            uVar5 = "丢弃";
          }
        }
        else {
          if (((lVar3 == null) || (lVar3 = GameObject.get_transform(lVar3,0)) == null) ||
             (lVar3 = Transform.Find(lVar3,"RightLabel",0)) == null) throw; // [null/range check failed]
          uVar4 = Component.GetComponent(lVar3,DAT_181d96178);
          lVar3 = PlotController.attriIndexCache;
          if (lVar3 == null) throw; // [null/range check failed]
          if (lVar3.itemGrid <= targetType) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          uVar5 = lVar3[targetType];
        }
        LTLocalization.SetText(uVar4,uVar5,0);
        if (!this.discard) {
          if (targetType == 1) {
            if (((this.tradeUI == null) ||
                (lVar3 = GameObject.get_transform(this.tradeUI,0)) == null) ||
               ((lVar3 = Transform.Find(lVar3,"LeftOutList",0), lVar3 == null ||
                (lVar3 = Transform.Find(lVar3,"SellLabel",0)) == null))) throw; // [null/range check failed]
            uVar5 = Component.GetComponent(lVar3,DAT_181d96178);
            LTLocalization.SetText(uVar5,"存\n入",0);
            if ((((this.tradeUI == null) ||
                 (lVar3 = GameObject.get_transform(this.tradeUI,0)) == null) ||
                (lVar3 = Transform.Find(lVar3,"RightOutList",0)) == null) ||
               (lVar3 = Transform.Find(lVar3,"BuyLabel",0)) == null) throw; // [null/range check failed]
            uVar4 = Component.GetComponent(lVar3,DAT_181d96178);
            uVar5 = "取\n出";
          }
          else {
            if (targetType == 3) {
              if (((this.tradeUI == null) ||
                  (lVar3 = GameObject.get_transform(this.tradeUI,0)) == null) ||
                 ((lVar3 = Transform.Find(lVar3,"LeftOutList",0), lVar3 == null ||
                  (lVar3 = Transform.Find(lVar3,"SellLabel",0)) == null))) throw; // [null/range check failed]
              uVar4 = Component.GetComponent(lVar3,DAT_181d96178);
              uVar5 = "给\n予";
              if (((*(byte *)(DAT_181d848b0 + 0x133) & 4) != 0) && (*(int *)(DAT_181d848b0 + 224) == 0))
              {
                il2cpp_runtime_class_init();
                uVar5 = "给\n予";
              }
              goto LAB_180aaa1c0;
            }
            if ((targetType == 2) || (targetType == 4)) {
              if (((this.tradeUI == null) ||
                  ((lVar3 = GameObject.get_transform(this.tradeUI,0), lVar3 == null ||
                   (lVar3 = Transform.Find(lVar3,"LeftOutList",0)) == null))) ||
                 (lVar3 = Transform.Find(lVar3,"SellLabel",0)) == null) throw; // [null/range check failed]
              uVar5 = Component.GetComponent(lVar3,DAT_181d96178);
              LTLocalization.SetText(uVar5,"出\n售",0);
              if ((((this.tradeUI == null) ||
                   (lVar3 = GameObject.get_transform(this.tradeUI,0)) == null) ||
                  (lVar3 = Transform.Find(lVar3,"RightOutList",0)) == null) ||
                 (lVar3 = Transform.Find(lVar3,"BuyLabel",0)) == null) throw; // [null/range check failed]
              uVar4 = Component.GetComponent(lVar3,DAT_181d96178);
              uVar5 = "兑\n换";
            }
            else {
              if (((this.tradeUI == null) ||
                  (lVar3 = GameObject.get_transform(this.tradeUI,0)) == null) ||
                 ((lVar3 = Transform.Find(lVar3,"LeftOutList",0), lVar3 == null ||
                  (lVar3 = Transform.Find(lVar3,"SellLabel",0)) == null))) throw; // [null/range check failed]
              uVar5 = Component.GetComponent(lVar3,DAT_181d96178);
              LTLocalization.SetText(uVar5,"出\n售",0);
              if ((((this.tradeUI == null) ||
                   (lVar3 = GameObject.get_transform(this.tradeUI,0)) == null) ||
                  (lVar3 = Transform.Find(lVar3,"RightOutList",0)) == null) ||
                 (lVar3 = Transform.Find(lVar3,"BuyLabel",0)) == null) throw; // [null/range check failed]
              uVar4 = Component.GetComponent(lVar3,DAT_181d96178);
              uVar5 = "购\n买";
            }
          }
        }
        else {
          if ((((this.tradeUI == null) ||
               (lVar3 = GameObject.get_transform(this.tradeUI,0)) == null) ||
              (lVar3 = Transform.Find(lVar3,"LeftOutList",0)) == null) ||
             (lVar3 = Transform.Find(lVar3,"SellLabel",0)) == null) throw; // [null/range check failed]
          uVar4 = Component.GetComponent(lVar3,DAT_181d96178);
          uVar5 = "丢\n弃";
          if (((*(byte *)(DAT_181d848b0 + 0x133) & 4) != 0) && (*(int *)(DAT_181d848b0 + 224) == 0)) {
            il2cpp_runtime_class_init();
            uVar5 = "丢\n弃";
          }
        LAB_180aaa1c0:
          LTLocalization.SetText(uVar4,uVar5,0);
          if ((((this.tradeUI == null) ||
               (lVar3 = GameObject.get_transform(this.tradeUI,0)) == null) ||
              (lVar3 = Transform.Find(lVar3,"RightOutList",0)) == null) ||
             (lVar3 = Transform.Find(lVar3,"BuyLabel",0)) == null) throw; // [null/range check failed]
          uVar4 = Component.GetComponent(lVar3,DAT_181d96178);
          uVar5 = "取\n回";
        }
        LTLocalization.SetText(uVar4,uVar5,0);
        if (((this.tradeUI != null) &&
            (lVar3 = GameObject.get_transform(this.tradeUI,0)) != null) &&
           (lVar3 = Transform.Find(lVar3,"LeftOutList",0)) != null) {
          lVar3 = Component.get_gameObject(lVar3,0);
          if ((this.tradeUIType - 2U & 0xfffffffd) == 0) {
            bVar8 = false;
          }
          else {
            bVar8 = !this.noSell;
          }
          if (lVar3 != null) {
            GameObject.SetActive(lVar3,bVar8,0);
            if (((this.tradeUI != null) &&
                (lVar3 = GameObject.get_transform(this.tradeUI,0)) != null) &&
               (lVar3 = Transform.Find(lVar3,"RightOutList",0)) != null) {
              lVar3 = Component.get_gameObject(lVar3,0);
              if (lVar3 != null) {
                GameObject.SetActive(lVar3,this.tradeUIType != 3,0);
                if (this.leftList != null) {
                  ItemListController.RefreshItemList(this.leftList,rightItemList,1,0);
                  if (this.rightList != null) {
                    ItemListController.RefreshItemList(this.rightList,_useAreaItemPrice,1,0);
                    lVar3 = this.leftOutList;
                    var uVar5 = new ItemListData(0);
                    if (lVar3 != null) {
                      ItemListController.RefreshItemList(lVar3,uVar5,1,0);
                      lVar3 = this.rightOutList;
                      var uVar5 = new ItemListData(0);
                      if (lVar3 != null) {
                        ItemListController.RefreshItemList(lVar3,uVar5,1,0);
                        TradeUIController.FreshResourceLabel(this,0);
                        if ((targetType == null) ||
                           ((uVar5 = "Sound/SoundEffect/OpenBox", targetType != 1 &&
                            ((targetType == 2 ||
                             ((uVar5 = "Sound/SoundEffect/Bag", targetType != 3 &&
                              (uVar5 = "Sound/SoundEffect/OpenBox", targetType == 4)))))))) {
                          uVar5 = "Sound/SoundEffect/Deal";
                        }
                        plVar6 = (int64 *)Resources.Load(uVar5,0);
                        plVar7 = (int64 *)0;
                        if ((plVar6 != (int64 *)0) && (*plVar6 == DAT_181daf360)) {
                          plVar7 = plVar6;
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

    // Token : 0x6002306
    // RVA   : 0xAAA4B0   Offset: 0xAA98B0   Length: 0x4E
    public void ShowTradeUI(TradeUIType targetType, ItemListType targetItemListType, ItemListData leftItemList, ItemListData rightItemList)
    {
        void TradeUIController.ShowTradeUI
                     (int64 this,uint32 targetType,uint32 targetItemListType,int64 leftItemList,int64 rightItemList,
                     uint32 param_6,uint32 param_7,uint8 param_8,uint8 param_9,
                     uint32 param_10,uint32 param_11)
        {
        char cVar1;
        bool bVar2;
        int64 lVar3;
        uint64 uVar4;
        uint64 uVar5;
        int64 *plVar6;
        int64 *plVar7;
        bool bVar8;
        if (this.tradeUI == null) throw; // [null/range check failed]
        GameObject.SetActive(this.tradeUI,1,0);
        this.deltaMoney = 0;
        this.tradeUIType = targetType;
        this.forceItemListType = targetItemListType;
        if (this.leftList == null) throw; // [null/range check failed]
        this.leftList.forceItemListType = targetItemListType;
        if (this.rightList == null) throw; // [null/range check failed]
        this.rightList.forceItemListType = targetItemListType;
        this.minItemLv = param_6;
        this.maxItemLv = param_7;
        this.useAreaItemPrice = param_8;
        this.noSell = param_9;
        this.speSellValueRate = param_10;
        this.speBuyValueRate = param_11;
        bVar8 = false;
        if (targetType == null) {
          lVar3 = this.leftList;
          if (leftItemList == null) throw; // [null/range check failed]
          cVar1 = ItemListData.BelongHero(leftItemList,0);
          bVar2 = bVar8;
          if (cVar1) {
            bVar2 = *(int *)(leftItemList + 16) != 0;
          }
          if (lVar3 == null) throw; // [null/range check failed]
          lVar3.noEquipedItem = bVar2;
          lVar3 = this.rightList;
          if (rightItemList == null) throw; // [null/range check failed]
          cVar1 = ItemListData.BelongHero(rightItemList,0);
          if (cVar1) {
            bVar8 = *(int *)(rightItemList + 16) != 0;
          }
          if (lVar3 == null) throw; // [null/range check failed]
          lVar3.noEquipedItem = bVar8;
        }
        bVar8 = rightItemList == this.discardItemList;
        this.discard = bVar8;
        lVar3 = this.tradeUI;
        if (bVar8) {
          if (((lVar3 == null) || (lVar3 = GameObject.get_transform(lVar3,0)) == null) ||
             (lVar3 = Transform.Find(lVar3,"RightLabel",0)) == null) throw; // [null/range check failed]
          uVar4 = Component.GetComponent(lVar3,DAT_181d96178);
          uVar5 = "丢弃";
          if (((*(byte *)(DAT_181d848b0 + 0x133) & 4) != 0) && (*(int *)(DAT_181d848b0 + 224) == 0)) {
            il2cpp_runtime_class_init();
            uVar5 = "丢弃";
          }
        }
        else {
          if (((lVar3 == null) || (lVar3 = GameObject.get_transform(lVar3,0)) == null) ||
             (lVar3 = Transform.Find(lVar3,"RightLabel",0)) == null) throw; // [null/range check failed]
          uVar4 = Component.GetComponent(lVar3,DAT_181d96178);
          lVar3 = PlotController.attriIndexCache;
          if (lVar3 == null) throw; // [null/range check failed]
          if (lVar3.itemGrid <= targetType) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          uVar5 = lVar3[targetType];
        }
        LTLocalization.SetText(uVar4,uVar5,0);
        if (!this.discard) {
          if (targetType == 1) {
            if (((this.tradeUI == null) ||
                (lVar3 = GameObject.get_transform(this.tradeUI,0)) == null) ||
               ((lVar3 = Transform.Find(lVar3,"LeftOutList",0), lVar3 == null ||
                (lVar3 = Transform.Find(lVar3,"SellLabel",0)) == null))) throw; // [null/range check failed]
            uVar5 = Component.GetComponent(lVar3,DAT_181d96178);
            LTLocalization.SetText(uVar5,"存\n入",0);
            if ((((this.tradeUI == null) ||
                 (lVar3 = GameObject.get_transform(this.tradeUI,0)) == null) ||
                (lVar3 = Transform.Find(lVar3,"RightOutList",0)) == null) ||
               (lVar3 = Transform.Find(lVar3,"BuyLabel",0)) == null) throw; // [null/range check failed]
            uVar4 = Component.GetComponent(lVar3,DAT_181d96178);
            uVar5 = "取\n出";
          }
          else {
            if (targetType == 3) {
              if (((this.tradeUI == null) ||
                  (lVar3 = GameObject.get_transform(this.tradeUI,0)) == null) ||
                 ((lVar3 = Transform.Find(lVar3,"LeftOutList",0), lVar3 == null ||
                  (lVar3 = Transform.Find(lVar3,"SellLabel",0)) == null))) throw; // [null/range check failed]
              uVar4 = Component.GetComponent(lVar3,DAT_181d96178);
              uVar5 = "给\n予";
              if (((*(byte *)(DAT_181d848b0 + 0x133) & 4) != 0) && (*(int *)(DAT_181d848b0 + 224) == 0))
              {
                il2cpp_runtime_class_init();
                uVar5 = "给\n予";
              }
              goto LAB_180aaa1c0;
            }
            if ((targetType == 2) || (targetType == 4)) {
              if (((this.tradeUI == null) ||
                  ((lVar3 = GameObject.get_transform(this.tradeUI,0), lVar3 == null ||
                   (lVar3 = Transform.Find(lVar3,"LeftOutList",0)) == null))) ||
                 (lVar3 = Transform.Find(lVar3,"SellLabel",0)) == null) throw; // [null/range check failed]
              uVar5 = Component.GetComponent(lVar3,DAT_181d96178);
              LTLocalization.SetText(uVar5,"出\n售",0);
              if ((((this.tradeUI == null) ||
                   (lVar3 = GameObject.get_transform(this.tradeUI,0)) == null) ||
                  (lVar3 = Transform.Find(lVar3,"RightOutList",0)) == null) ||
                 (lVar3 = Transform.Find(lVar3,"BuyLabel",0)) == null) throw; // [null/range check failed]
              uVar4 = Component.GetComponent(lVar3,DAT_181d96178);
              uVar5 = "兑\n换";
            }
            else {
              if (((this.tradeUI == null) ||
                  (lVar3 = GameObject.get_transform(this.tradeUI,0)) == null) ||
                 ((lVar3 = Transform.Find(lVar3,"LeftOutList",0), lVar3 == null ||
                  (lVar3 = Transform.Find(lVar3,"SellLabel",0)) == null))) throw; // [null/range check failed]
              uVar5 = Component.GetComponent(lVar3,DAT_181d96178);
              LTLocalization.SetText(uVar5,"出\n售",0);
              if ((((this.tradeUI == null) ||
                   (lVar3 = GameObject.get_transform(this.tradeUI,0)) == null) ||
                  (lVar3 = Transform.Find(lVar3,"RightOutList",0)) == null) ||
                 (lVar3 = Transform.Find(lVar3,"BuyLabel",0)) == null) throw; // [null/range check failed]
              uVar4 = Component.GetComponent(lVar3,DAT_181d96178);
              uVar5 = "购\n买";
            }
          }
        }
        else {
          if ((((this.tradeUI == null) ||
               (lVar3 = GameObject.get_transform(this.tradeUI,0)) == null) ||
              (lVar3 = Transform.Find(lVar3,"LeftOutList",0)) == null) ||
             (lVar3 = Transform.Find(lVar3,"SellLabel",0)) == null) throw; // [null/range check failed]
          uVar4 = Component.GetComponent(lVar3,DAT_181d96178);
          uVar5 = "丢\n弃";
          if (((*(byte *)(DAT_181d848b0 + 0x133) & 4) != 0) && (*(int *)(DAT_181d848b0 + 224) == 0)) {
            il2cpp_runtime_class_init();
            uVar5 = "丢\n弃";
          }
        LAB_180aaa1c0:
          LTLocalization.SetText(uVar4,uVar5,0);
          if ((((this.tradeUI == null) ||
               (lVar3 = GameObject.get_transform(this.tradeUI,0)) == null) ||
              (lVar3 = Transform.Find(lVar3,"RightOutList",0)) == null) ||
             (lVar3 = Transform.Find(lVar3,"BuyLabel",0)) == null) throw; // [null/range check failed]
          uVar4 = Component.GetComponent(lVar3,DAT_181d96178);
          uVar5 = "取\n回";
        }
        LTLocalization.SetText(uVar4,uVar5,0);
        if (((this.tradeUI != null) &&
            (lVar3 = GameObject.get_transform(this.tradeUI,0)) != null) &&
           (lVar3 = Transform.Find(lVar3,"LeftOutList",0)) != null) {
          lVar3 = Component.get_gameObject(lVar3,0);
          if ((this.tradeUIType - 2U & 0xfffffffd) == 0) {
            bVar8 = false;
          }
          else {
            bVar8 = !this.noSell;
          }
          if (lVar3 != null) {
            GameObject.SetActive(lVar3,bVar8,0);
            if (((this.tradeUI != null) &&
                (lVar3 = GameObject.get_transform(this.tradeUI,0)) != null) &&
               (lVar3 = Transform.Find(lVar3,"RightOutList",0)) != null) {
              lVar3 = Component.get_gameObject(lVar3,0);
              if (lVar3 != null) {
                GameObject.SetActive(lVar3,this.tradeUIType != 3,0);
                if (this.leftList != null) {
                  ItemListController.RefreshItemList(this.leftList,leftItemList,1,0);
                  if (this.rightList != null) {
                    ItemListController.RefreshItemList(this.rightList,rightItemList,1,0);
                    lVar3 = this.leftOutList;
                    var uVar5 = new ItemListData(0);
                    if (lVar3 != null) {
                      ItemListController.RefreshItemList(lVar3,uVar5,1,0);
                      lVar3 = this.rightOutList;
                      var uVar5 = new ItemListData(0);
                      if (lVar3 != null) {
                        ItemListController.RefreshItemList(lVar3,uVar5,1,0);
                        TradeUIController.FreshResourceLabel(this,0);
                        if ((targetType == null) ||
                           ((uVar5 = "Sound/SoundEffect/OpenBox", targetType != 1 &&
                            ((targetType == 2 ||
                             ((uVar5 = "Sound/SoundEffect/Bag", targetType != 3 &&
                              (uVar5 = "Sound/SoundEffect/OpenBox", targetType == 4)))))))) {
                          uVar5 = "Sound/SoundEffect/Deal";
                        }
                        plVar6 = (int64 *)Resources.Load(uVar5,0);
                        plVar7 = (int64 *)0;
                        if ((plVar6 != (int64 *)0) && (*plVar6 == DAT_181daf360)) {
                          plVar7 = plVar6;
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

    // Token : 0x6002307
    // RVA   : 0xAA9970   Offset: 0xAA8D70   Length: 0x59
    public void ShowTradeUI(TradeUIType targetType, ItemListData leftItemList, ItemListData rightItemList, int _minItemLv, int _maxItemLv)
    {
        void TradeUIController.ShowTradeUI
                     (int64 this,uint32 targetType,uint32 leftItemList,int64 rightItemList,int64 _minItemLv,
                     uint32 _maxItemLv,uint32 param_7,uint8 param_8,uint8 param_9,
                     uint32 param_10,uint32 param_11)
        {
        char cVar1;
        bool bVar2;
        int64 lVar3;
        uint64 uVar4;
        uint64 uVar5;
        int64 *plVar6;
        int64 *plVar7;
        bool bVar8;
        if (this.tradeUI == null) throw; // [null/range check failed]
        GameObject.SetActive(this.tradeUI,1,0);
        this.deltaMoney = 0;
        this.tradeUIType = targetType;
        this.forceItemListType = leftItemList;
        if (this.leftList == null) throw; // [null/range check failed]
        this.leftList.forceItemListType = leftItemList;
        if (this.rightList == null) throw; // [null/range check failed]
        this.rightList.forceItemListType = leftItemList;
        this.minItemLv = _maxItemLv;
        this.maxItemLv = param_7;
        this.useAreaItemPrice = param_8;
        this.noSell = param_9;
        this.speSellValueRate = param_10;
        this.speBuyValueRate = param_11;
        bVar8 = false;
        if (targetType == null) {
          lVar3 = this.leftList;
          if (rightItemList == null) throw; // [null/range check failed]
          cVar1 = ItemListData.BelongHero(rightItemList,0);
          bVar2 = bVar8;
          if (cVar1) {
            bVar2 = *(int *)(rightItemList + 16) != 0;
          }
          if (lVar3 == null) throw; // [null/range check failed]
          lVar3.noEquipedItem = bVar2;
          lVar3 = this.rightList;
          if (_minItemLv == null) throw; // [null/range check failed]
          cVar1 = ItemListData.BelongHero(_minItemLv,0);
          if (cVar1) {
            bVar8 = *(int *)(_minItemLv + 16) != 0;
          }
          if (lVar3 == null) throw; // [null/range check failed]
          lVar3.noEquipedItem = bVar8;
        }
        bVar8 = _minItemLv == this.discardItemList;
        this.discard = bVar8;
        lVar3 = this.tradeUI;
        if (bVar8) {
          if (((lVar3 == null) || (lVar3 = GameObject.get_transform(lVar3,0)) == null) ||
             (lVar3 = Transform.Find(lVar3,"RightLabel",0)) == null) throw; // [null/range check failed]
          uVar4 = Component.GetComponent(lVar3,DAT_181d96178);
          uVar5 = "丢弃";
          if (((*(byte *)(DAT_181d848b0 + 0x133) & 4) != 0) && (*(int *)(DAT_181d848b0 + 224) == 0)) {
            il2cpp_runtime_class_init();
            uVar5 = "丢弃";
          }
        }
        else {
          if (((lVar3 == null) || (lVar3 = GameObject.get_transform(lVar3,0)) == null) ||
             (lVar3 = Transform.Find(lVar3,"RightLabel",0)) == null) throw; // [null/range check failed]
          uVar4 = Component.GetComponent(lVar3,DAT_181d96178);
          lVar3 = PlotController.attriIndexCache;
          if (lVar3 == null) throw; // [null/range check failed]
          if (lVar3.itemGrid <= targetType) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          uVar5 = lVar3[targetType];
        }
        LTLocalization.SetText(uVar4,uVar5,0);
        if (!this.discard) {
          if (targetType == 1) {
            if (((this.tradeUI == null) ||
                (lVar3 = GameObject.get_transform(this.tradeUI,0)) == null) ||
               ((lVar3 = Transform.Find(lVar3,"LeftOutList",0), lVar3 == null ||
                (lVar3 = Transform.Find(lVar3,"SellLabel",0)) == null))) throw; // [null/range check failed]
            uVar5 = Component.GetComponent(lVar3,DAT_181d96178);
            LTLocalization.SetText(uVar5,"存\n入",0);
            if ((((this.tradeUI == null) ||
                 (lVar3 = GameObject.get_transform(this.tradeUI,0)) == null) ||
                (lVar3 = Transform.Find(lVar3,"RightOutList",0)) == null) ||
               (lVar3 = Transform.Find(lVar3,"BuyLabel",0)) == null) throw; // [null/range check failed]
            uVar4 = Component.GetComponent(lVar3,DAT_181d96178);
            uVar5 = "取\n出";
          }
          else {
            if (targetType == 3) {
              if (((this.tradeUI == null) ||
                  (lVar3 = GameObject.get_transform(this.tradeUI,0)) == null) ||
                 ((lVar3 = Transform.Find(lVar3,"LeftOutList",0), lVar3 == null ||
                  (lVar3 = Transform.Find(lVar3,"SellLabel",0)) == null))) throw; // [null/range check failed]
              uVar4 = Component.GetComponent(lVar3,DAT_181d96178);
              uVar5 = "给\n予";
              if (((*(byte *)(DAT_181d848b0 + 0x133) & 4) != 0) && (*(int *)(DAT_181d848b0 + 224) == 0))
              {
                il2cpp_runtime_class_init();
                uVar5 = "给\n予";
              }
              goto LAB_180aaa1c0;
            }
            if ((targetType == 2) || (targetType == 4)) {
              if (((this.tradeUI == null) ||
                  ((lVar3 = GameObject.get_transform(this.tradeUI,0), lVar3 == null ||
                   (lVar3 = Transform.Find(lVar3,"LeftOutList",0)) == null))) ||
                 (lVar3 = Transform.Find(lVar3,"SellLabel",0)) == null) throw; // [null/range check failed]
              uVar5 = Component.GetComponent(lVar3,DAT_181d96178);
              LTLocalization.SetText(uVar5,"出\n售",0);
              if ((((this.tradeUI == null) ||
                   (lVar3 = GameObject.get_transform(this.tradeUI,0)) == null) ||
                  (lVar3 = Transform.Find(lVar3,"RightOutList",0)) == null) ||
                 (lVar3 = Transform.Find(lVar3,"BuyLabel",0)) == null) throw; // [null/range check failed]
              uVar4 = Component.GetComponent(lVar3,DAT_181d96178);
              uVar5 = "兑\n换";
            }
            else {
              if (((this.tradeUI == null) ||
                  (lVar3 = GameObject.get_transform(this.tradeUI,0)) == null) ||
                 ((lVar3 = Transform.Find(lVar3,"LeftOutList",0), lVar3 == null ||
                  (lVar3 = Transform.Find(lVar3,"SellLabel",0)) == null))) throw; // [null/range check failed]
              uVar5 = Component.GetComponent(lVar3,DAT_181d96178);
              LTLocalization.SetText(uVar5,"出\n售",0);
              if ((((this.tradeUI == null) ||
                   (lVar3 = GameObject.get_transform(this.tradeUI,0)) == null) ||
                  (lVar3 = Transform.Find(lVar3,"RightOutList",0)) == null) ||
                 (lVar3 = Transform.Find(lVar3,"BuyLabel",0)) == null) throw; // [null/range check failed]
              uVar4 = Component.GetComponent(lVar3,DAT_181d96178);
              uVar5 = "购\n买";
            }
          }
        }
        else {
          if ((((this.tradeUI == null) ||
               (lVar3 = GameObject.get_transform(this.tradeUI,0)) == null) ||
              (lVar3 = Transform.Find(lVar3,"LeftOutList",0)) == null) ||
             (lVar3 = Transform.Find(lVar3,"SellLabel",0)) == null) throw; // [null/range check failed]
          uVar4 = Component.GetComponent(lVar3,DAT_181d96178);
          uVar5 = "丢\n弃";
          if (((*(byte *)(DAT_181d848b0 + 0x133) & 4) != 0) && (*(int *)(DAT_181d848b0 + 224) == 0)) {
            il2cpp_runtime_class_init();
            uVar5 = "丢\n弃";
          }
        LAB_180aaa1c0:
          LTLocalization.SetText(uVar4,uVar5,0);
          if ((((this.tradeUI == null) ||
               (lVar3 = GameObject.get_transform(this.tradeUI,0)) == null) ||
              (lVar3 = Transform.Find(lVar3,"RightOutList",0)) == null) ||
             (lVar3 = Transform.Find(lVar3,"BuyLabel",0)) == null) throw; // [null/range check failed]
          uVar4 = Component.GetComponent(lVar3,DAT_181d96178);
          uVar5 = "取\n回";
        }
        LTLocalization.SetText(uVar4,uVar5,0);
        if (((this.tradeUI != null) &&
            (lVar3 = GameObject.get_transform(this.tradeUI,0)) != null) &&
           (lVar3 = Transform.Find(lVar3,"LeftOutList",0)) != null) {
          lVar3 = Component.get_gameObject(lVar3,0);
          if ((this.tradeUIType - 2U & 0xfffffffd) == 0) {
            bVar8 = false;
          }
          else {
            bVar8 = !this.noSell;
          }
          if (lVar3 != null) {
            GameObject.SetActive(lVar3,bVar8,0);
            if (((this.tradeUI != null) &&
                (lVar3 = GameObject.get_transform(this.tradeUI,0)) != null) &&
               (lVar3 = Transform.Find(lVar3,"RightOutList",0)) != null) {
              lVar3 = Component.get_gameObject(lVar3,0);
              if (lVar3 != null) {
                GameObject.SetActive(lVar3,this.tradeUIType != 3,0);
                if (this.leftList != null) {
                  ItemListController.RefreshItemList(this.leftList,rightItemList,1,0);
                  if (this.rightList != null) {
                    ItemListController.RefreshItemList(this.rightList,_minItemLv,1,0);
                    lVar3 = this.leftOutList;
                    var uVar5 = new ItemListData(0);
                    if (lVar3 != null) {
                      ItemListController.RefreshItemList(lVar3,uVar5,1,0);
                      lVar3 = this.rightOutList;
                      var uVar5 = new ItemListData(0);
                      if (lVar3 != null) {
                        ItemListController.RefreshItemList(lVar3,uVar5,1,0);
                        TradeUIController.FreshResourceLabel(this,0);
                        if ((targetType == null) ||
                           ((uVar5 = "Sound/SoundEffect/OpenBox", targetType != 1 &&
                            ((targetType == 2 ||
                             ((uVar5 = "Sound/SoundEffect/Bag", targetType != 3 &&
                              (uVar5 = "Sound/SoundEffect/OpenBox", targetType == 4)))))))) {
                          uVar5 = "Sound/SoundEffect/Deal";
                        }
                        plVar6 = (int64 *)Resources.Load(uVar5,0);
                        plVar7 = (int64 *)0;
                        if ((plVar6 != (int64 *)0) && (*plVar6 == DAT_181daf360)) {
                          plVar7 = plVar6;
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

    // Token : 0x6002308
    // RVA   : 0xAA99D0   Offset: 0xAA8DD0   Length: 0xA7F
    public void ShowTradeUI(TradeUIType targetType, ItemListType targetItemListType, ItemListData leftItemList, ItemListData rightItemList, int _minItemLv, int _maxItemLv, bool _useAreaItemPrice, bool _noSell, float _speSellValueRate, float _speBuyValueRate)
    {
        void TradeUIController.ShowTradeUI
                     (int64 this,uint32 targetType,uint32 targetItemListType,int64 leftItemList,int64 rightItemList,
                     uint32 _minItemLv,uint32 _maxItemLv,uint8 _useAreaItemPrice,uint8 _noSell,
                     uint32 _speSellValueRate,uint32 _speBuyValueRate)
        {
        char cVar1;
        bool bVar2;
        int64 lVar3;
        uint64 uVar4;
        uint64 uVar5;
        int64 *plVar6;
        int64 *plVar7;
        bool bVar8;
        if (this.tradeUI == null) throw; // [null/range check failed]
        GameObject.SetActive(this.tradeUI,1,0);
        this.deltaMoney = 0;
        this.tradeUIType = targetType;
        this.forceItemListType = targetItemListType;
        if (this.leftList == null) throw; // [null/range check failed]
        this.leftList.forceItemListType = targetItemListType;
        if (this.rightList == null) throw; // [null/range check failed]
        this.rightList.forceItemListType = targetItemListType;
        this.minItemLv = _minItemLv;
        this.maxItemLv = _maxItemLv;
        this.useAreaItemPrice = _useAreaItemPrice;
        this.noSell = _noSell;
        this.speSellValueRate = _speSellValueRate;
        this.speBuyValueRate = _speBuyValueRate;
        bVar8 = false;
        if (targetType == null) {
          lVar3 = this.leftList;
          if (leftItemList == null) throw; // [null/range check failed]
          cVar1 = ItemListData.BelongHero(leftItemList,0);
          bVar2 = bVar8;
          if (cVar1) {
            bVar2 = *(int *)(leftItemList + 16) != 0;
          }
          if (lVar3 == null) throw; // [null/range check failed]
          lVar3.noEquipedItem = bVar2;
          lVar3 = this.rightList;
          if (rightItemList == null) throw; // [null/range check failed]
          cVar1 = ItemListData.BelongHero(rightItemList,0);
          if (cVar1) {
            bVar8 = *(int *)(rightItemList + 16) != 0;
          }
          if (lVar3 == null) throw; // [null/range check failed]
          lVar3.noEquipedItem = bVar8;
        }
        bVar8 = rightItemList == this.discardItemList;
        this.discard = bVar8;
        lVar3 = this.tradeUI;
        if (bVar8) {
          if (((lVar3 == null) || (lVar3 = GameObject.get_transform(lVar3,0)) == null) ||
             (lVar3 = Transform.Find(lVar3,"RightLabel",0)) == null) throw; // [null/range check failed]
          uVar4 = Component.GetComponent(lVar3,DAT_181d96178);
          uVar5 = "丢弃";
          if (((*(byte *)(DAT_181d848b0 + 0x133) & 4) != 0) && (*(int *)(DAT_181d848b0 + 224) == 0)) {
            il2cpp_runtime_class_init();
            uVar5 = "丢弃";
          }
        }
        else {
          if (((lVar3 == null) || (lVar3 = GameObject.get_transform(lVar3,0)) == null) ||
             (lVar3 = Transform.Find(lVar3,"RightLabel",0)) == null) throw; // [null/range check failed]
          uVar4 = Component.GetComponent(lVar3,DAT_181d96178);
          lVar3 = PlotController.attriIndexCache;
          if (lVar3 == null) throw; // [null/range check failed]
          if (lVar3.itemGrid <= targetType) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          uVar5 = lVar3[targetType];
        }
        LTLocalization.SetText(uVar4,uVar5,0);
        if (!this.discard) {
          if (targetType == 1) {
            if (((this.tradeUI == null) ||
                (lVar3 = GameObject.get_transform(this.tradeUI,0)) == null) ||
               ((lVar3 = Transform.Find(lVar3,"LeftOutList",0), lVar3 == null ||
                (lVar3 = Transform.Find(lVar3,"SellLabel",0)) == null))) throw; // [null/range check failed]
            uVar5 = Component.GetComponent(lVar3,DAT_181d96178);
            LTLocalization.SetText(uVar5,"存\n入",0);
            if ((((this.tradeUI == null) ||
                 (lVar3 = GameObject.get_transform(this.tradeUI,0)) == null) ||
                (lVar3 = Transform.Find(lVar3,"RightOutList",0)) == null) ||
               (lVar3 = Transform.Find(lVar3,"BuyLabel",0)) == null) throw; // [null/range check failed]
            uVar4 = Component.GetComponent(lVar3,DAT_181d96178);
            uVar5 = "取\n出";
          }
          else {
            if (targetType == 3) {
              if (((this.tradeUI == null) ||
                  (lVar3 = GameObject.get_transform(this.tradeUI,0)) == null) ||
                 ((lVar3 = Transform.Find(lVar3,"LeftOutList",0), lVar3 == null ||
                  (lVar3 = Transform.Find(lVar3,"SellLabel",0)) == null))) throw; // [null/range check failed]
              uVar4 = Component.GetComponent(lVar3,DAT_181d96178);
              uVar5 = "给\n予";
              if (((*(byte *)(DAT_181d848b0 + 0x133) & 4) != 0) && (*(int *)(DAT_181d848b0 + 224) == 0))
              {
                il2cpp_runtime_class_init();
                uVar5 = "给\n予";
              }
              goto LAB_180aaa1c0;
            }
            if ((targetType == 2) || (targetType == 4)) {
              if (((this.tradeUI == null) ||
                  ((lVar3 = GameObject.get_transform(this.tradeUI,0), lVar3 == null ||
                   (lVar3 = Transform.Find(lVar3,"LeftOutList",0)) == null))) ||
                 (lVar3 = Transform.Find(lVar3,"SellLabel",0)) == null) throw; // [null/range check failed]
              uVar5 = Component.GetComponent(lVar3,DAT_181d96178);
              LTLocalization.SetText(uVar5,"出\n售",0);
              if ((((this.tradeUI == null) ||
                   (lVar3 = GameObject.get_transform(this.tradeUI,0)) == null) ||
                  (lVar3 = Transform.Find(lVar3,"RightOutList",0)) == null) ||
                 (lVar3 = Transform.Find(lVar3,"BuyLabel",0)) == null) throw; // [null/range check failed]
              uVar4 = Component.GetComponent(lVar3,DAT_181d96178);
              uVar5 = "兑\n换";
            }
            else {
              if (((this.tradeUI == null) ||
                  (lVar3 = GameObject.get_transform(this.tradeUI,0)) == null) ||
                 ((lVar3 = Transform.Find(lVar3,"LeftOutList",0), lVar3 == null ||
                  (lVar3 = Transform.Find(lVar3,"SellLabel",0)) == null))) throw; // [null/range check failed]
              uVar5 = Component.GetComponent(lVar3,DAT_181d96178);
              LTLocalization.SetText(uVar5,"出\n售",0);
              if ((((this.tradeUI == null) ||
                   (lVar3 = GameObject.get_transform(this.tradeUI,0)) == null) ||
                  (lVar3 = Transform.Find(lVar3,"RightOutList",0)) == null) ||
                 (lVar3 = Transform.Find(lVar3,"BuyLabel",0)) == null) throw; // [null/range check failed]
              uVar4 = Component.GetComponent(lVar3,DAT_181d96178);
              uVar5 = "购\n买";
            }
          }
        }
        else {
          if ((((this.tradeUI == null) ||
               (lVar3 = GameObject.get_transform(this.tradeUI,0)) == null) ||
              (lVar3 = Transform.Find(lVar3,"LeftOutList",0)) == null) ||
             (lVar3 = Transform.Find(lVar3,"SellLabel",0)) == null) throw; // [null/range check failed]
          uVar4 = Component.GetComponent(lVar3,DAT_181d96178);
          uVar5 = "丢\n弃";
          if (((*(byte *)(DAT_181d848b0 + 0x133) & 4) != 0) && (*(int *)(DAT_181d848b0 + 224) == 0)) {
            il2cpp_runtime_class_init();
            uVar5 = "丢\n弃";
          }
        LAB_180aaa1c0:
          LTLocalization.SetText(uVar4,uVar5,0);
          if ((((this.tradeUI == null) ||
               (lVar3 = GameObject.get_transform(this.tradeUI,0)) == null) ||
              (lVar3 = Transform.Find(lVar3,"RightOutList",0)) == null) ||
             (lVar3 = Transform.Find(lVar3,"BuyLabel",0)) == null) throw; // [null/range check failed]
          uVar4 = Component.GetComponent(lVar3,DAT_181d96178);
          uVar5 = "取\n回";
        }
        LTLocalization.SetText(uVar4,uVar5,0);
        if (((this.tradeUI != null) &&
            (lVar3 = GameObject.get_transform(this.tradeUI,0)) != null) &&
           (lVar3 = Transform.Find(lVar3,"LeftOutList",0)) != null) {
          lVar3 = Component.get_gameObject(lVar3,0);
          if ((this.tradeUIType - 2U & 0xfffffffd) == 0) {
            bVar8 = false;
          }
          else {
            bVar8 = !this.noSell;
          }
          if (lVar3 != null) {
            GameObject.SetActive(lVar3,bVar8,0);
            if (((this.tradeUI != null) &&
                (lVar3 = GameObject.get_transform(this.tradeUI,0)) != null) &&
               (lVar3 = Transform.Find(lVar3,"RightOutList",0)) != null) {
              lVar3 = Component.get_gameObject(lVar3,0);
              if (lVar3 != null) {
                GameObject.SetActive(lVar3,this.tradeUIType != 3,0);
                if (this.leftList != null) {
                  ItemListController.RefreshItemList(this.leftList,leftItemList,1,0);
                  if (this.rightList != null) {
                    ItemListController.RefreshItemList(this.rightList,rightItemList,1,0);
                    lVar3 = this.leftOutList;
                    var uVar5 = new ItemListData(0);
                    if (lVar3 != null) {
                      ItemListController.RefreshItemList(lVar3,uVar5,1,0);
                      lVar3 = this.rightOutList;
                      var uVar5 = new ItemListData(0);
                      if (lVar3 != null) {
                        ItemListController.RefreshItemList(lVar3,uVar5,1,0);
                        TradeUIController.FreshResourceLabel(this,0);
                        if ((targetType == null) ||
                           ((uVar5 = "Sound/SoundEffect/OpenBox", targetType != 1 &&
                            ((targetType == 2 ||
                             ((uVar5 = "Sound/SoundEffect/Bag", targetType != 3 &&
                              (uVar5 = "Sound/SoundEffect/OpenBox", targetType == 4)))))))) {
                          uVar5 = "Sound/SoundEffect/Deal";
                        }
                        plVar6 = (int64 *)Resources.Load(uVar5,0);
                        plVar7 = (int64 *)0;
                        if ((plVar6 != (int64 *)0) && (*plVar6 == DAT_181daf360)) {
                          plVar7 = plVar6;
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

    // Token : 0x6002309
    // RVA   : 0xAA6380   Offset: 0xAA5780   Length: 0x18
    public bool CanSell()
    {
        int FUN_180aa6380(int64 this)
        {
        uint3 uVar1;
        uint32 uVar2;
        uVar2 = this.tradeUIType - 2;
        uVar1 = (uint3)(uVar2 >> 8);
        if ((uVar2 & 0xfffffffd) == 0) {
          return (uint32)uVar1 << 8;
        }
        return CONCAT31(uVar1,!this.noSell);
    }

    // Token : 0x600230A
    // RVA   : 0xAA6370   Offset: 0xAA5770   Length: 0x8
    public bool CanBuy()
    {
        bool FUN_180aa6370(int64 this)
        {
        return this.tradeUIType != 3;
    }

    // Token : 0x600230B
    // RVA   : 0xAAA500   Offset: 0xAA9900   Length: 0x53D
    public void SureButtonClicked()
    {
        var pStatics = *(int64*)(DAT_181da8728 + 184);
        ulong uVar1;
        int iVar2;
        long lVar3;
        float fVar6;
        if (((this.leftOutList == null) ||
            (lVar3 = this.leftOutList.targetItemList) == null) ||
           (lVar3 = *(int64 *)(lVar3 + 40)) == null) throw; // [null/range check failed]
        if (*(int *)(lVar3 + 24) == 0) {
          if (((this.rightOutList == null) ||
              (lVar3 = this.rightOutList.targetItemList) == null) ||
             (lVar3 = *(int64 *)(lVar3 + 40)) == null) throw; // [null/range check failed]
          if (*(int *)(lVar3 + 24) == 0) {
            return;
          }
        }
        if (!this.discard) {
          fVar6 = this.deltaWeight;
          if (fVar6 <= 0.0) {
        LAB_180aaa70c:
            if (fVar6 < 0.0) {
              if ((this.rightList == null) ||
                 (lVar3 = this.rightList.targetItemList) == null)
              throw; // [null/range check failed]
              if ((0.0 < *(float *)(lVar3 + 32)) &&
                 (*(float *)(lVar3 + 32) < *(float *)(lVar3 + 28) - fVar6)) {
                lVar3 = FUN_18046c0a0(0);
                uVar1 = "对方负重不足！";
                goto joined_r0x000180aaa76b;
              }
            }
            goto LAB_180aaa77d;
          }
          if ((this.leftList == null) ||
             (lVar3 = this.leftList.targetItemList) == null)
          throw; // [null/range check failed]
          if ((*(float *)(lVar3 + 32) <= 0.0) ||
             (fVar6 + *(float *)(lVar3 + 28) <= *(float *)(lVar3 + 32))) goto LAB_180aaa70c;
          lVar3 = FUN_18046c0a0(0);
          uVar1 = "己方负重不足！";
        }
        else {
        LAB_180aaa77d:
          iVar2 = this.tradeUIType;
          if (iVar2 == 0) {
            iVar2 = this.deltaMoney;
            if (0 < iVar2) {
              if ((this.rightList == null) ||
                 (lVar3 = this.rightList.targetItemList) == null)
              throw; // [null/range check failed]
              if (*(int *)(lVar3 + 24) < iVar2) {
                if (*pStatics == 0) throw; // [null/range check failed]
                SureMenu.CallSureMenu
                          (*pStatics,"对方银钱不足，确认交易吗？","RealManageTrade",0,
                           "UIController",0);
                plVar4 = (int64 *)Resources.Load("Sound/SoundEffect/WrongClick",0);
                goto LAB_180aaa6e4;
              }
            }
            if (-1 < iVar2) {
        LAB_180aaaa24:
              TradeUIController.RealManageTrade(this,0);
              return;
            }
            iVar2 = Mathf.Abs(iVar2,0);
            if ((this.leftList == null) ||
               (lVar3 = this.leftList.targetItemList) == null)
            throw; // [null/range check failed]
            if (iVar2 <= *(int *)(lVar3 + 24)) goto LAB_180aaaa24;
            lVar3 = FUN_18046c0a0(0);
            uVar1 = "己方银钱不足！";
          }
          else if (iVar2 == 2) {
            if (-1 < this.deltaMoney) goto LAB_180aaaa24;
            iVar2 = Mathf.Abs(this.deltaMoney,0);
            lVar3 = FUN_18046c0a0(0);
            if (((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) ||
               (lVar3 = WorldData.Player(*(int64 *)(lVar3 + 32),0)) == null) throw; // [null/range check failed]
            fVar6 = (float)HeroData.SelfForceContrituion(lVar3,0);
            if ((float)iVar2 <= fVar6) goto LAB_180aaaa24;
            lVar3 = FUN_18046c0a0(0);
            uVar1 = "己方功绩不足！";
          }
          else {
            if ((iVar2 != 4) || (-1 < this.deltaMoney)) goto LAB_180aaaa24;
            iVar2 = Mathf.Abs(this.deltaMoney,0);
            lVar3 = FUN_18046c0a0(0);
            if (((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) ||
               (lVar3 = WorldData.Player(*(int64 *)(lVar3 + 32),0)) == null) throw; // [null/range check failed]
            if ((float)iVar2 < *(float *)(lVar3 + 0x1b4) || (float)iVar2 == *(float *)(lVar3 + 0x1b4))
            goto LAB_180aaaa24;
            lVar3 = FUN_18046c0a0(0);
            uVar1 = "官府功绩不足！";
          }
        }
        joined_r0x000180aaa76b:
        if (lVar3 != null) {
          GameController.ShowTextOnMouse(lVar3,uVar1,0);
          plVar4 = (int64 *)Resources.Load("Sound/SoundEffect/WrongClick",0);
        LAB_180aaa6e4:
          plVar5 = (int64 *)0;
          if ((plVar4 != (int64 *)0) && (*plVar4 == DAT_181daf360)) {
            plVar5 = plVar4;
          }
          NGUITools.PlaySound(plVar5,0);
          return;
        }
    }

    // Token : 0x600230C
    // RVA   : 0xAA8970   Offset: 0xAA7D70   Length: 0xFFC
    public void RealManageTrade()
    {
        int iVar2;
        long lVar3;
        bool cVar4;
        uint uVar5;
        long lVar6;
        long lVar7;
        ulong uVar8;
        uint uVar10;
        long lVar12;
        float fVar13;
        ulong in_stack_ffffffffffffffc8;
        iVar2 = this.tradeUIType;
        plVar11 = (int64 *)0;
        if (iVar2 == 0) {
          iVar2 = this.deltaMoney;
          if (iVar2 < 1) {
            if (iVar2 < 0) {
              if ((this.leftList == null) ||
                 (lVar6 = this.leftList.targetItemList) == null)
              goto LAB_180aa9967;
              uVar5 = Mathf.Max(iVar2,-lVar6.itemGrid,0);
              goto LAB_180aa8b3a;
            }
          }
          else {
            if ((this.rightList == null) ||
               (lVar6 = this.rightList.targetItemList) == null)
            goto LAB_180aa9967;
            uVar5 = Mathf.Min(iVar2,lVar6.itemGrid,0);
        LAB_180aa8b3a:
            this.deltaMoney = uVar5;
          }
          if ((this.leftList == null) ||
             (lVar6 = this.leftList.targetItemList) == null)
          goto LAB_180aa9967;
          cVar4 = ItemListData.BelongForce(lVar6,0);
          lVar6 = this.leftList;
          if (!cVar4) {
            if ((lVar6 == null) || (lVar6.targetItemList == null)) goto LAB_180aa9967;
            cVar4 = ItemListData.BelongHero(lVar6.targetItemList,0);
            if (!cVar4) {
              if ((this.leftList == null) ||
                 (lVar6 = this.leftList.targetItemList) == null)
              goto LAB_180aa9967;
              lVar6.itemGrid = *piVar1 + this.deltaMoney;
            }
            else {
              lVar6 = FUN_18046c0a0(0);
              if ((((lVar6 == null) || (this.leftList == null)) ||
                  (lVar7 = this.leftList.targetItemList) == null) ||
                 (lVar6.itemListInteractType == null)) goto LAB_180aa9967;
              lVar6 = WorldData.GetHero(lVar6.itemListInteractType,lVar7.chapter,0);
              if (lVar6 == null) goto LAB_180aa9967;
              HeroData.ChangeMoney(lVar6,this.deltaMoney,1,0);
            }
          }
          else {
            if (((lVar6 == null) || (lVar6.targetItemList == null)) ||
               (lVar6 = ItemListData.GetForce(lVar6.targetItemList,0)) == null)
            goto LAB_180aa9967;
            in_stack_ffffffffffffffc8 = CONCAT71((int7)((uint64)in_stack_ffffffffffffffc8 >> 8),1);
            ForceData.ChangeResource(lVar6,0);
          }
          if ((this.rightList == null) ||
             (lVar6 = this.rightList.targetItemList) == null)
          goto LAB_180aa9967;
          cVar4 = ItemListData.BelongForce(lVar6,0);
          lVar6 = this.rightList;
          if (!cVar4) {
            if ((lVar6 == null) || (lVar6.targetItemList == null)) goto LAB_180aa9967;
            cVar4 = ItemListData.BelongHero(lVar6.targetItemList,0);
            if (!cVar4) {
              if ((this.rightList == null) ||
                 (lVar6 = this.rightList.targetItemList) == null)
              goto LAB_180aa9967;
              lVar6.itemGrid = *piVar1 - this.deltaMoney;
            }
            else {
              lVar6 = FUN_18046c0a0(0);
              if ((((lVar6 == null) || (this.rightList == null)) ||
                  (lVar7 = this.rightList.targetItemList) == null) ||
                 (lVar6.itemListInteractType == null)) goto LAB_180aa9967;
              lVar6 = WorldData.GetHero(lVar6.itemListInteractType,lVar7.chapter,0);
              if (lVar6 == null) goto LAB_180aa9967;
              HeroData.ChangeMoney(lVar6,-this.deltaMoney,1,0);
            }
          }
          else {
            if (((lVar6 == null) || (lVar6.targetItemList == null)) ||
               (lVar6 = ItemListData.GetForce(lVar6.targetItemList,0)) == null)
            goto LAB_180aa9967;
            in_stack_ffffffffffffffc8 = CONCAT71((int7)((uint64)in_stack_ffffffffffffffc8 >> 8),1);
            ForceData.ChangeResource(lVar6,0);
          }
        LAB_180aa8da9:
          this.deltaMoney = 0;
        }
        else {
          if (iVar2 == 2) {
            lVar6 = FUN_18046c0a0(0);
            if (((lVar6 == null) || (lVar6.itemListInteractType == null)) ||
               (lVar6 = WorldData.Player(lVar6.itemListInteractType,0)) == null) goto LAB_180aa9967;
            in_stack_ffffffffffffffc8 = 0;
            HeroData.ChangeForceContribution(lVar6);
            goto LAB_180aa8da9;
          }
          if (iVar2 == 4) {
            lVar6 = FUN_18046c0a0(0);
            if (((lVar6 == null) || (lVar6.itemListInteractType == null)) ||
               (lVar6 = WorldData.Player(lVar6.itemListInteractType,0)) == null) goto LAB_180aa9967;
            HeroData.ChangeGovernContribution(lVar6);
            goto LAB_180aa8da9;
          }
        }
        if ((this.rightList != null) &&
           (lVar6 = this.rightList.targetItemList) != null) {
          cVar4 = ItemListData.BelongHero(lVar6,0);
          lVar6 = 32;
          if (!cVar4) {
        LAB_180aa8f37:
            if ((this.leftList != null) &&
               (lVar7 = this.leftList.targetItemList) != null) {
              cVar4 = ItemListData.BelongHero(lVar7,0);
              if (!cVar4) {
        LAB_180aa90c5:
                uVar5 = (uint32)((uint64)in_stack_ffffffffffffffc8 >> 32);
                if (this.tradeUIType == null) {
                  lVar7 = this.rightOutList;
                  fVar13 = 0.0;
                  if (lVar7 != null) {
                    lVar12 = 32;
                    plVar9 = plVar11;
                    while( true ) {
                      if ((lVar7.targetItemList == null) ||
                         (lVar3 = *(int64 *)(lVar7.targetItemList + 40)) == null)
                      goto LAB_180aa9967;
                      uVar10 = (uint32)plVar9;
                      if (*(int *)(lVar3 + 24) <= (int)uVar10) break;
                      if (((lVar7 == null) || (lVar7.targetItemList == null)) ||
                         (lVar7 = *(int64 *)(lVar7.targetItemList + 40)) == null)
                      goto LAB_180aa9967;
                      if (lVar7.itemGrid <= uVar10) {
                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                      }
                      lVar3 = *(int64 *)(lVar12 + lVar7.chapter);
                      if (lVar3 == null) goto LAB_180aa9967;
                      plVar9 = (int64 *)(uint64)(uVar10 + 1);
                      lVar7 = this.rightOutList;
                      lVar12 = lVar12 + 8;
                      fVar13 = fVar13 + (float)*(int *)(lVar3 + 56);
                      if (lVar7 == null) goto LAB_180aa9967;
                    }
                    lVar7 = this.leftOutList;
                    plVar9 = plVar11;
                    if (lVar7 != null) goto LAB_180aa9190;
                  }
                }
                else {
        LAB_180aa9415:
                  plVar9 = (int64 *)Resources.Load("Sound/SoundEffect/Deal",0);
                  if ((plVar9 != (int64 *)0) && (*plVar9 == DAT_181daf360)) {
                    plVar11 = plVar9;
                  }
                  NGUITools.PlaySound(plVar11,0);
                  this.deltaWeight = 0;
                  if ((this.leftList != null) &&
                     (lVar6 = this.leftList.targetItemList) != null) {
                    cVar4 = ItemListData.BelongHero(lVar6,0);
                    if (!cVar4) {
                      if (((this.leftList == null) || (this.rightOutList == null))
                         || (lVar6 = this.leftList.targetItemList) == null)
                      goto LAB_180aa9967;
                      ItemListData.GetItem(lVar6,this.rightOutList.targetItemList,0)
                      ;
                    }
                    else {
                      if ((((GameController._instance == null) ||
                           (this.leftList == null)) ||
                          (lVar6 = this.leftList.targetItemList) == null) ||
                         (lVar7 = GameController._instance.worldData) == null
                         ) goto LAB_180aa9967;
                      lVar6 = WorldData.GetHero(lVar7,*(uint32 *)(lVar6 + 16),0);
                      if ((this.rightOutList == null) || (lVar6 == null)) goto LAB_180aa9967;
                      uVar8 = CONCAT44(uVar5,0xffffffff);
                      HeroData.GetItem(lVar6,this.rightOutList.targetItemList,1,0,
                                        uVar8,0);
                      uVar5 = (uint32)((uint64)uVar8 >> 32);
                    }
                    if ((this.rightList != null) &&
                       (lVar6 = this.rightList.targetItemList) != null) {
                      cVar4 = ItemListData.BelongHero(lVar6,0);
                      if (!cVar4) {
                        if (((this.rightList == null) || (this.leftOutList == null))
                           || (lVar6 = this.rightList.targetItemList) == null)
                        goto LAB_180aa9967;
                        ItemListData.GetItem
                                  (lVar6,this.leftOutList.targetItemList,0);
                      }
                      else {
                        if ((((GameController._instance == null) ||
                             (this.rightList == null)) ||
                            (lVar6 = this.rightList.targetItemList) == null) ||
                           (lVar7 = GameController._instance.worldData,
                           lVar7 == null)) goto LAB_180aa9967;
                        lVar6 = WorldData.GetHero(lVar7,*(uint32 *)(lVar6 + 16),0);
                        if ((this.leftOutList == null) || (lVar6 == null)) goto LAB_180aa9967;
                        HeroData.GetItem(lVar6,this.leftOutList.targetItemList,1,0,
                                          CONCAT44(uVar5,0xffffffff),0);
                      }
                      if (this.leftList != null) {
                        ItemListController.RefreshItemList(this.leftList,1,0);
                        if (this.rightList != null) {
                          ItemListController.RefreshItemList(this.rightList,1,0);
                          lVar6 = this.leftOutList;
                          uVar8 = new ItemListData(0);
                          if (lVar6 != null) {
                            ItemListController.RefreshItemList(lVar6,uVar8,1,0);
                            lVar6 = this.rightOutList;
                            uVar8 = new ItemListData(0);
                            if (lVar6 != null) {
                              ItemListController.RefreshItemList(lVar6,uVar8,1,0);
                              TradeUIController.FreshResourceLabel(this,0);
                              if ((this.rightList != null) &&
                                 (lVar6 = this.rightList.targetItemList) != null
                                 ) {
                                cVar4 = ItemListData.BelongHero(lVar6,0);
                                if (cVar4) {
                                  if ((((GameController._instance == null) ||
                                       (this.rightList == null)) ||
                                      (lVar6 = this.rightList.targetItemList,
                                      lVar6 == null)) ||
                                     ((lVar7 = GameController._instance.worldData
                                      , lVar7 == null ||
                                      (lVar6 = WorldData.GetHero(lVar7,*(uint32 *)(lVar6 + 16),0),
                                      lVar6 == null)))) goto LAB_180aa9967;
                                  *(uint8 *)(lVar6 + 0x2d8) = 1;
                                }
                                if ((this.leftList != null) &&
                                   (lVar6 = this.leftList.targetItemList,
                                   lVar6 != null)) {
                                  cVar4 = ItemListData.BelongHero(lVar6,0);
                                  if (cVar4) {
                                    if ((((GameController._instance == null) ||
                                         (this.leftList == null)) ||
                                        (lVar6 = this.leftList.targetItemList,
                                        lVar6 == null)) ||
                                       ((lVar7 = *(int64 *)
                                                  (GameController._instance + 32),
                                        lVar7 == null ||
                                        (lVar6 = WorldData.GetHero(lVar7,*(uint32 *)(lVar6 + 16),0)
                                        , lVar6 == null)))) goto LAB_180aa9967;
                                    *(uint8 *)(lVar6 + 0x2d8) = 1;
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
              else {
                lVar7 = this.leftOutList;
                if (lVar7 != null) {
                  lVar12 = 32;
                  plVar9 = plVar11;
                  while ((lVar7.targetItemList != null &&
                         (lVar3 = *(int64 *)(lVar7.targetItemList + 40)) != null)) {
                    uVar10 = (uint32)plVar9;
                    if (*(int *)(lVar3 + 24) <= (int)uVar10) goto LAB_180aa90c5;
                    if (((lVar7 == null) || (lVar7.targetItemList == null)) ||
                       (lVar7 = *(int64 *)(lVar7.targetItemList + 40)) == null) break;
                    if (lVar7.itemGrid <= uVar10) {
                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                    }
                    if (*(int64 *)(lVar12 + lVar7.chapter) == 0) break;
                    cVar4 = ItemData.Equiped();
                    if (cVar4) {
                      lVar7 = FUN_18046c0a0(0);
                      if ((((lVar7 == null) || (this.leftList == null)) ||
                          (lVar3 = this.leftList.targetItemList) == null) ||
                         (lVar7.itemListInteractType == null)) break;
                      lVar7 = WorldData.GetHero(lVar7.itemListInteractType,*(uint32 *)(lVar3 + 16)
                                                 ,0);
                      if (((this.leftOutList == null) ||
                          (lVar3 = this.leftOutList.targetItemList) == null) ||
                         ((lVar3 = *(int64 *)(lVar3 + 40), lVar3 == null ||
                          (uVar8 = FUN_180002f80(lVar3,plVar9), lVar7 == null)))) break;
                      in_stack_ffffffffffffffc8 = 0;
                      HeroData.UnequipItem(lVar7,uVar8,0,1,0);
                    }
                    lVar7 = this.leftOutList;
                    plVar9 = (int64 *)(uint64)(uVar10 + 1);
                    lVar12 = lVar12 + 8;
                    if (lVar7 == null) break;
                  }
                }
              }
            }
          }
          else {
            lVar7 = this.rightOutList;
            if (lVar7 != null) {
              lVar12 = 32;
              plVar9 = plVar11;
              while ((lVar7.targetItemList != null &&
                     (lVar3 = *(int64 *)(lVar7.targetItemList + 40)) != null)) {
                uVar10 = (uint32)plVar9;
                if (*(int *)(lVar3 + 24) <= (int)uVar10) goto LAB_180aa8f37;
                if (((lVar7 == null) || (lVar7.targetItemList == null)) ||
                   (lVar7 = *(int64 *)(lVar7.targetItemList + 40)) == null) break;
                if (lVar7.itemGrid <= uVar10) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                if (*(int64 *)(lVar12 + lVar7.chapter) == 0) break;
                cVar4 = ItemData.Equiped();
                if (cVar4) {
                  lVar7 = FUN_18046c0a0(0);
                  if ((((lVar7 == null) || (this.rightList == null)) ||
                      (lVar3 = this.rightList.targetItemList) == null) ||
                     (lVar7.itemListInteractType == null)) break;
                  lVar7 = WorldData.GetHero(lVar7.itemListInteractType,*(uint32 *)(lVar3 + 16),0);
                  if (((this.rightOutList == null) ||
                      (lVar3 = this.rightOutList.targetItemList) == null) ||
                     ((lVar3 = *(int64 *)(lVar3 + 40), lVar3 == null ||
                      (uVar8 = FUN_180002f80(lVar3,plVar9), lVar7 == null)))) break;
                  in_stack_ffffffffffffffc8 = 0;
                  HeroData.UnequipItem(lVar7,uVar8,0,1,0);
                }
                lVar7 = this.rightOutList;
                plVar9 = (int64 *)(uint64)(uVar10 + 1);
                lVar12 = lVar12 + 8;
                if (lVar7 == null) break;
              }
            }
          }
        }
        LAB_180aa9967:
                          // WARNING: Subroutine does not return
        FUN_1800d6620();
        LAB_180aa9190:
        uVar5 = (uint32)((uint64)in_stack_ffffffffffffffc8 >> 32);
        if ((lVar7.targetItemList == null) ||
           (lVar12 = *(int64 *)(lVar7.targetItemList + 40)) == null) goto LAB_180aa9967;
        uVar10 = (uint32)plVar9;
        if (*(int *)(lVar12 + 24) <= (int)uVar10) {
          if ((this.rightList == null) ||
             (lVar6 = this.rightList.targetItemList) == null)
          goto LAB_180aa9967;
          cVar4 = ItemListData.BelongHero(lVar6,0);
          if (cVar4) {
            if ((((GameController._instance == null) || (this.rightList == null)) ||
                (lVar6 = this.rightList.targetItemList) == null) ||
               ((lVar7 = GameController._instance.worldData, lVar7 == null ||
                (lVar6 = WorldData.GetHero(lVar7,*(uint32 *)(lVar6 + 16),0)) == null)))
            goto LAB_180aa9967;
            uVar5 = 0;
            HeroData.ChangeLivingSkillExp(lVar6,3,fVar13 * 0.1,0,0);
          }
          if ((this.leftList != null) &&
             (lVar6 = this.leftList.targetItemList) != null) {
            cVar4 = ItemListData.BelongHero(lVar6,0);
            if (!cVar4) goto LAB_180aa9415;
            if ((((GameController._instance != null) && (this.leftList != null)) &&
                (lVar6 = this.leftList.targetItemList) != null) &&
               ((lVar7 = GameController._instance.worldData, lVar7 != null &&
                (lVar6 = WorldData.GetHero(lVar7,*(uint32 *)(lVar6 + 16),0)) != null))) {
              uVar5 = 0;
              HeroData.ChangeLivingSkillExp(lVar6,3);
              goto LAB_180aa9415;
            }
          }
          goto LAB_180aa9967;
        }
        if (((lVar7 == null) || (lVar7.targetItemList == null)) ||
           (lVar7 = *(int64 *)(lVar7.targetItemList + 40)) == null) goto LAB_180aa9967;
        if (lVar7.itemGrid <= uVar10) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        lVar12 = *(int64 *)(lVar6 + lVar7.chapter);
        if (lVar12 == null) goto LAB_180aa9967;
        lVar7 = this.leftOutList;
        lVar6 = lVar6 + 8;
        fVar13 = fVar13 + (float)*(int *)(lVar12 + 56);
        plVar9 = (int64 *)(uint64)(uVar10 + 1);
        if (lVar7 == null) goto LAB_180aa9967;
        goto LAB_180aa9190;
    }

    // Token : 0x600230D
    // RVA   : 0xAA63A0   Offset: 0xAA57A0   Length: 0x229
    public void CancelButtonClicked()
    {
        long lVar1;
        ulong uVar3;
        if (((this.leftOutList != null) &&
            (lVar1 = this.leftOutList.targetItemList) != null) &&
           (lVar1 = lVar1.nowItemListType) != null) {
          if (lVar1.itemGrid == null) {
            if (((this.rightOutList == null) ||
                (lVar1 = this.rightOutList.targetItemList) == null) ||
               (lVar1 = lVar1.nowItemListType) == null) throw; // [null/range check failed]
            if (lVar1.itemGrid == null) {
              return;
            }
          }
          plVar2 = (int64 *)Resources.Load("Sound/SoundEffect/WrongClick",0);
          plVar4 = (int64 *)0;
          if ((plVar2 != (int64 *)0) && (*plVar2 == DAT_181daf360)) {
            plVar4 = plVar2;
          }
          NGUITools.PlaySound(plVar4,0);
          this.deltaMoney = 0;
          if (((this.leftList != null) && (this.leftOutList != null)) &&
             (lVar1 = this.leftList.targetItemList) != null) {
            ItemListData.GetItem(lVar1,this.leftOutList.targetItemList,0);
            if (((this.rightList != null) && (this.rightOutList != null)) &&
               (lVar1 = this.rightList.targetItemList) != null) {
              ItemListData.GetItem(lVar1,this.rightOutList.targetItemList,0);
              if (this.leftList != null) {
                ItemListController.RefreshItemList(this.leftList,1,0);
                if (this.rightList != null) {
                  ItemListController.RefreshItemList(this.rightList,1,0);
                  lVar1 = this.leftOutList;
                  uVar3 = new ItemListData(0);
                  if (lVar1 != null) {
                    ItemListController.RefreshItemList(lVar1,uVar3,1,0);
                    lVar1 = this.rightOutList;
                    uVar3 = new ItemListData(0);
                    if (lVar1 != null) {
                      ItemListController.RefreshItemList(lVar1,uVar3,1,0);
                      TradeUIController.FreshResourceLabel(this,0);
                      return;
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x600230E
    // RVA   : 0xAAAA40   Offset: 0xAA9E40   Length: 0x638
    public void TradeIconClicked(GameObject iconClicked)
    {
        float fVar1;
        bool cVar2;
        int iVar3;
        int iVar4;
        ulong uVar5;
        long lVar6;
        long lVar7;
        if (iconClicked == null) throw; // [null/range check failed]
        uVar5 = GameObject.GetComponent(iconClicked,DAT_181d720a0);
        cVar2 = Object.op_Inequality(uVar5,0,0);
        if (!cVar2) goto LAB_180aaaca2;
        lVar6 = GameObject.GetComponent(iconClicked,DAT_181d720a0);
        if (lVar6 == null) throw; // [null/range check failed]
        iVar4 = *(int *)(lVar6 + 44);
        if (iVar4 == 1) {
          if (((this.tradeUIType - 2U & 0xfffffffd) == 0) || (this.noSell))
          {
        LAB_180aab01a:
            plVar8 = (int64 *)Resources.Load("Sound/SoundEffect/WrongClick",0);
            plVar9 = (int64 *)0;
            if ((plVar8 != (int64 *)0) && (*plVar8 == DAT_181daf360)) {
              plVar9 = plVar8;
            }
            NGUITools.PlaySound(plVar9,0x3f800000,0);
            return;
          }
          iVar4 = this.deltaMoney;
          lVar6 = GameObject.GetComponent(iconClicked,DAT_181d720a0);
          if (lVar6 == null) throw; // [null/range check failed]
          iVar3 = ItemIconController.GetItemPrice(lVar6,0,0);
          fVar1 = this.deltaWeight;
          this.deltaMoney = iVar3 + iVar4;
          lVar6 = GameObject.GetComponent(iconClicked,DAT_181d720a0);
          if ((lVar6 == null) || (lVar6.itemListInteractType == null)) throw; // [null/range check failed]
          this.deltaWeight = fVar1 - *(float *)(lVar6.itemListInteractType + 68);
          if (this.leftList == null) throw; // [null/range check failed]
          lVar6 = this.leftList.targetItemList;
          lVar7 = GameObject.GetComponent(iconClicked,DAT_181d720a0);
          if ((lVar7 == null) || (lVar6 == null)) throw; // [null/range check failed]
          ItemListData.LoseItem(lVar6,*(uint64 *)(lVar7 + 32),0,0);
          if (this.leftOutList == null) throw; // [null/range check failed]
          lVar6 = this.leftOutList.targetItemList;
          lVar7 = GameObject.GetComponent(iconClicked,DAT_181d720a0);
          if ((lVar7 == null) || (lVar6 == null)) throw; // [null/range check failed]
          ItemListData.GetItem(lVar6,*(uint64 *)(lVar7 + 32),0,0);
        LAB_180aaaef9:
          if (this.leftList == null) throw; // [null/range check failed]
          ItemListController.RefreshItemList(this.leftList,0,0);
          lVar6 = this.leftOutList;
        }
        else {
          if (iVar4 == 2) {
            iVar4 = this.deltaMoney;
            lVar6 = GameObject.GetComponent(iconClicked,DAT_181d720a0);
            if (lVar6 == null) throw; // [null/range check failed]
            iVar3 = ItemIconController.GetItemPrice(lVar6,0,0);
            fVar1 = this.deltaWeight;
            this.deltaMoney = iVar4 - iVar3;
            lVar6 = GameObject.GetComponent(iconClicked,DAT_181d720a0);
            if ((lVar6 == null) || (lVar6.itemListInteractType == null)) throw; // [null/range check failed]
            this.deltaWeight = fVar1 + *(float *)(lVar6.itemListInteractType + 68);
            if (this.leftList == null) throw; // [null/range check failed]
            lVar6 = this.leftList.targetItemList;
            lVar7 = GameObject.GetComponent(iconClicked,DAT_181d720a0);
            if ((lVar7 == null) || (lVar6 == null)) throw; // [null/range check failed]
            ItemListData.GetItem(lVar6,*(uint64 *)(lVar7 + 32),0,0);
            if (this.leftOutList == null) throw; // [null/range check failed]
            lVar6 = this.leftOutList.targetItemList;
            lVar7 = GameObject.GetComponent(iconClicked,DAT_181d720a0);
            if ((lVar7 == null) || (lVar6 == null)) throw; // [null/range check failed]
            ItemListData.LoseItem(lVar6,*(uint64 *)(lVar7 + 32),0,0);
            goto LAB_180aaaef9;
          }
          if (iVar4 == 3) {
            iVar4 = this.tradeUIType;
            if (iVar4 == 3) goto LAB_180aab01a;
            iVar3 = this.deltaMoney;
            if (iVar4 == 2) {
              lVar6 = GameObject.GetComponent(iconClicked);
              if ((lVar6 == null) || (lVar6.itemListInteractType == null)) throw; // [null/range check failed]
              iVar4 = ItemData.GetContributionCost(lVar6.itemListInteractType,0,0);
            }
            else if (iVar4 == 4) {
              lVar6 = GameObject.GetComponent(iconClicked,DAT_181d720a0);
              if ((lVar6 == null) || (lVar6.itemListInteractType == null)) throw; // [null/range check failed]
              iVar4 = ItemData.GetGovernContributionCost(lVar6.itemListInteractType,0);
            }
            else {
              lVar6 = GameObject.GetComponent(iconClicked,DAT_181d720a0);
              if (lVar6 == null) throw; // [null/range check failed]
              iVar4 = ItemIconController.GetItemPrice(lVar6,1,0);
            }
            fVar1 = this.deltaWeight;
            this.deltaMoney = iVar3 - iVar4;
            lVar6 = GameObject.GetComponent(iconClicked,DAT_181d720a0);
            if ((lVar6 == null) || (lVar6.itemListInteractType == null)) throw; // [null/range check failed]
            this.deltaWeight = fVar1 + *(float *)(lVar6.itemListInteractType + 68);
            if (this.rightList == null) throw; // [null/range check failed]
            lVar6 = this.rightList.targetItemList;
            lVar7 = GameObject.GetComponent(iconClicked,DAT_181d720a0);
            if ((lVar7 == null) || (lVar6 == null)) throw; // [null/range check failed]
            ItemListData.LoseItem(lVar6,*(uint64 *)(lVar7 + 32),0,0);
            if (this.rightOutList == null) throw; // [null/range check failed]
            lVar6 = this.rightOutList.targetItemList;
            lVar7 = GameObject.GetComponent(iconClicked,DAT_181d720a0);
            if ((lVar7 == null) || (lVar6 == null)) throw; // [null/range check failed]
            ItemListData.GetItem(lVar6,*(uint64 *)(lVar7 + 32),0,0);
          }
          else {
            if (iVar4 != 4) goto LAB_180aaaca2;
            iVar4 = this.deltaMoney;
            if (this.tradeUIType == 2) {
              lVar6 = GameObject.GetComponent(iconClicked);
              if ((lVar6 == null) || (lVar6.itemListInteractType == null)) throw; // [null/range check failed]
              iVar3 = ItemData.GetContributionCost(lVar6.itemListInteractType,0,0);
            }
            else if (this.tradeUIType == 4) {
              lVar6 = GameObject.GetComponent(iconClicked,DAT_181d720a0);
              if ((lVar6 == null) || (lVar6.itemListInteractType == null)) throw; // [null/range check failed]
              iVar3 = ItemData.GetGovernContributionCost(lVar6.itemListInteractType,0);
            }
            else {
              lVar6 = GameObject.GetComponent(iconClicked,DAT_181d720a0);
              if (lVar6 == null) throw; // [null/range check failed]
              iVar3 = ItemIconController.GetItemPrice(lVar6,1,0);
            }
            fVar1 = this.deltaWeight;
            this.deltaMoney = iVar3 + iVar4;
            lVar6 = GameObject.GetComponent(iconClicked,DAT_181d720a0);
            if ((lVar6 == null) || (lVar6.itemListInteractType == null)) throw; // [null/range check failed]
            this.deltaWeight = fVar1 - *(float *)(lVar6.itemListInteractType + 68);
            if (this.rightList == null) throw; // [null/range check failed]
            lVar6 = this.rightList.targetItemList;
            lVar7 = GameObject.GetComponent(iconClicked,DAT_181d720a0);
            if ((lVar7 == null) || (lVar6 == null)) throw; // [null/range check failed]
            ItemListData.GetItem(lVar6,*(uint64 *)(lVar7 + 32),0,0);
            if (this.rightOutList == null) throw; // [null/range check failed]
            lVar6 = this.rightOutList.targetItemList;
            lVar7 = GameObject.GetComponent(iconClicked,DAT_181d720a0);
            if ((lVar7 == null) || (lVar6 == null)) throw; // [null/range check failed]
            ItemListData.LoseItem(lVar6,*(uint64 *)(lVar7 + 32),0,0);
          }
          if (this.rightList == null) throw; // [null/range check failed]
          ItemListController.RefreshItemList(this.rightList,0,0);
          lVar6 = this.rightOutList;
        }
        if (lVar6 != null) {
          ItemListController.RefreshItemList(lVar6,0,0);
        LAB_180aaaca2:
          TradeUIController.FreshResourceLabel(this,0);
          return;
        }
    }

    // Token : 0x600230F
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

    // Token : 0x6002310
    // RVA   : 0xAAB080   Offset: 0xAAA480   Length: 0x13A
    private static void /*cctor*/()
    {
        long lVar2;
        lVar2 = il2cpp_internal(DAT_181d97768);
        FUN_181330100(lVar2,DAT_181da3bf0);
        if (lVar2 != null) {
          FUN_18181e6b0(lVar2,"贩售",DAT_181da3d70);
          FUN_18181e6b0(lVar2,"交换",DAT_181da3d70);
          FUN_18181e6b0(lVar2,"门派仓库",DAT_181da3d70);
          FUN_18181e6b0(lVar2,"给予",DAT_181da3d70);
          FUN_18181e6b0(lVar2,"官府仓库",DAT_181da3d70);
          plVar1 = *(int64 **)(DAT_181dad390 + 184);
          *plVar1 = lVar2;
          il2cpp_internal(plVar1,lVar2);
          return;
        }
    }

}
