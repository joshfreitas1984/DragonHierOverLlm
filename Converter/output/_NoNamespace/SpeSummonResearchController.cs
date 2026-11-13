// ============================================================
// Type  : SpeSummonResearchController
// Token : 0x2000378
// ============================================================

public class SpeSummonResearchController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001C94
    public GameObject speSummonResearchUI;

    // Token: 0x4001C95
    public List<GameObject> researchItemIcon;

    // Token: 0x4001C96
    public bool needRefresh;

    // Token: 0x4001C97
    private List<int> researchIteamSubType;

    // Token: 0x4001C98
    private static SpeSummonResearchController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600224D
    // RVA   : 0xA05F60   Offset: 0xA04D60   Length: 0x36
    public static SpeSummonResearchController get_Instance()
    {
        return **(uint64 **)(DAT_181e84928 + 184);
    }

    // Token : 0x600224E
    // RVA   : 0xA03AF0   Offset: 0xA028F0   Length: 0x43
    private void Awake()
    {
        puVar1 = *(uint64 **)(DAT_181e84928 + 184);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x600224F
    // RVA   : 0xA05E50   Offset: 0xA04C50   Length: 0x3D
    private void Update()
    {
        bool cVar1;
        if (this.speSummonResearchUI == null) {
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        cVar1 = GameObject.get_activeSelf(this.speSummonResearchUI,0);
        if ((cVar1) && (this.needRefresh)) {
          SpeSummonResearchController.RefreshUI(this,0);
          return;
        }
    }

    // Token : 0x6002250
    // RVA   : 0xA03DA0   Offset: 0xA02BA0   Length: 0x147
    public void HideSpeSummonResearchUI()
    {
        long lVar1;
        ulong uVar2;
        bool cVar3;
        uint uVar4;
        long lVar5;
        uVar4 = 0;
        lVar5 = 32;
        do {
          lVar1 = this.researchItemIcon;
          if (lVar1 == null) throw; // [null/range check failed]
          if (lVar1.Count <= uVar4) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          uVar2 = *(uint64 *)(lVar5 + lVar1._items);
          cVar3 = Object.op_Inequality(uVar2,0,0);
          if (cVar3) {
            lVar1 = this.researchItemIcon;
            if (lVar1 == null) throw; // [null/range check failed]
            if (lVar1.Count <= uVar4) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            uVar2 = *(uint64 *)(lVar5 + lVar1._items);
            Object.Destroy(uVar2,0);
            if (this.researchItemIcon == null) throw; // [null/range check failed]
            FUN_181769c00();
            this.needRefresh = 1;
          }
          uVar4 = uVar4 + 1;
          lVar5 = lVar5 + 8;
        } while ((int)uVar4 < 3);
        if (this.speSummonResearchUI != null) {
          GameObject.SetActive(this.speSummonResearchUI,0,0);
          return;
        }
    }

    // Token : 0x6002251
    // RVA   : 0xA05290   Offset: 0xA04090   Length: 0xAF
    public void ShowSpeSummonResearchUI()
    {
        if (this.speSummonResearchUI != null) {
          GameObject.SetActive(this.speSummonResearchUI,1,0);
          SpeSummonResearchController.RefreshUI(this,0);
          plVar1 = (int64 *)Resources.Load("Sound/SoundEffect/OpenBook",0);
          plVar2 = (int64 *)0;
          if ((plVar1 != (int64 *)0) && (*plVar1 == DAT_181e8f4a0)) {
            plVar2 = plVar1;
          }
          NGUITools.PlaySound(plVar2,0);
          return;
        }
    }

    // Token : 0x6002252
    // RVA   : 0xA03EF0   Offset: 0xA02CF0   Length: 0xF74
    public void RefreshUI()
    {
        var pStatics_38e8 = *(int64*)(DAT_181e538e8 + 184);
        byte uVar1;
        bool cVar2;
        int iVar3;
        long lVar4;
        ulong uVar5;
        long lVar6;
        ulong uVar7;
        ulong uVar8;
        long lVar9;
        float fVar12;
        int[] local_res8 = new int[4];
        uint[] local_res18 = new uint[2];
        uint[] local_res20 = new uint[2];
        uint local_98;
        int local_94;
        uint local_90;
        uint32 local_8c;
        uint64 local_88;
        uint64 uStack_80;
        uint8 local_78 [64];
        lVar4 = this.researchItemIcon;
        local_res18[0] = 0;
        local_res20[0] = 0;
        this.needRefresh = 0;
        local_res8[0] = 0;
        while (lVar4 != null) {
          if (lVar4.Count <= local_res8[0]) {
            return;
          }
          if (this.speSummonResearchUI == null) {
        LAB_180a04e5f:
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          lVar4 = GameObject.get_transform(this.speSummonResearchUI,0);
          uVar5 = Int32.ToString(local_res8,0);
          if (((lVar4 == null) || (lVar4 = Transform.Find(lVar4,uVar5,0)) == null) ||
             (lVar6 = Transform.Find(lVar4,"Lv",0)) == null) goto LAB_180a04e5f;
          uVar5 = Component.GetComponent(lVar6,DAT_181e79538);
          if (GameController._instance == null) goto LAB_180a04e5f;
          uVar7 = FUN_1800024b0(GameController._instance,local_res8[0],DAT_181e86970);
          lVar6 = FUN_1802106e0(0);
          if ((((lVar6 == null) || (*(int64 *)(lVar6 + 32) == 0)) ||
              (lVar6 = *(int64 *)(*(int64 *)(lVar6 + 32) + 0x228)) == null) ||
             (lVar6 = lVar6._items) == null) goto LAB_180a04e5f;
          local_98 = FUN_180002480(lVar6,local_res8[0],DAT_181e71bf0);
          uVar8 = il2cpp_value_box(DAT_181e60808,&local_98);
          uVar7 = String.Format("{0}等级{1}",uVar7,uVar8,0);
          LTLocalization.SetText(uVar5,uVar7,0);
          lVar6 = Transform.Find(lVar4,"ResearchLvAdd",0);
          if (lVar6 == null) goto LAB_180a04e5f;
          uVar5 = Component.GetComponent(lVar6,DAT_181e79538);
          lVar6 = GameController.difficultyExtraPoint;
          if (lVar6 == null) goto LAB_180a04e5f;
          uVar7 = FUN_1800024b0(lVar6,local_res8[0],DAT_181e86970);
          lVar6 = FUN_1802106e0(0);
          if (((lVar6 == null) || (*(int64 *)(lVar6 + 32) == 0)) ||
             ((lVar6 = *(int64 *)(*(int64 *)(lVar6 + 32) + 0x228), lVar6 == null ||
              (lVar6 = lVar6._items) == null))) goto LAB_180a04e5f;
          local_94 = FUN_180002480(lVar6,local_res8[0],DAT_181e71bf0);
          local_94 = local_94 * 2;
          uVar8 = il2cpp_value_box(DAT_181e60808,&local_94);
          uVar7 = String.Format("{0}+{1}%",uVar7,uVar8,0);
          LTLocalization.SetText(uVar5,uVar7,0);
          lVar6 = Transform.Find(lVar4,"ExpBarBack",0);
          if ((lVar6 == null) || (lVar6 = Transform.Find(lVar6,"ExpBar",0)) == null)
          goto LAB_180a04e5f;
          lVar6 = Component.GetComponent(lVar6,DAT_181e777b8);
          lVar9 = FUN_1802106e0(0);
          if ((lVar9 == null) ||
             (((*(int64 *)(lVar9 + 32) == 0 ||
               (lVar9 = *(int64 *)(*(int64 *)(lVar9 + 32) + 0x228)) == null) ||
              (lVar9 = *(int64 *)(lVar9 + 24)) == null))) goto LAB_180a04e5f;
          FUN_1800024e0(lVar9,local_res8[0],DAT_181e83530);
          lVar9 = FUN_1802106e0(0);
          if (((lVar9 == null) || (*(int64 *)(lVar9 + 32) == 0)) ||
             ((lVar9 = *(int64 *)(*(int64 *)(lVar9 + 32) + 0x228), lVar9 == null ||
              (SpeSummonResearchData.GetMaxExp(lVar9,local_res8[0],0), lVar6 == null)))) goto LAB_180a04e5f;
          Image.set_fillAmount(lVar6);
          lVar6 = Transform.Find(lVar4,"ExpBarBack",0);
          if ((lVar6 == null) || (lVar6 = Transform.Find(lVar6,"ExpText",0)) == null)
          goto LAB_180a04e5f;
          uVar5 = Component.GetComponent(lVar6,DAT_181e79538);
          lVar6 = FUN_1802106e0(0);
          if ((lVar6 == null) ||
             (((*(int64 *)(lVar6 + 32) == 0 ||
               (lVar6 = *(int64 *)(*(int64 *)(lVar6 + 32) + 0x228)) == null) ||
              (lVar6 = lVar6.Count) == null))) goto LAB_180a04e5f;
          local_res18[0] = FUN_1800024e0(lVar6,local_res8[0],DAT_181e83530);
          uVar7 = Single.ToString(local_res18,"f0",0);
          lVar6 = FUN_1802106e0(0);
          if (((lVar6 == null) || (*(int64 *)(lVar6 + 32) == 0)) ||
             (lVar6 = *(int64 *)(*(int64 *)(lVar6 + 32) + 0x228)) == null) goto LAB_180a04e5f;
          local_90 = SpeSummonResearchData.GetMaxExp(lVar6,local_res8[0],0);
          uVar8 = il2cpp_value_box(DAT_181e82730,&local_90);
          uVar7 = String.Format("{0}/{1}",uVar7,uVar8,0);
          LTLocalization.SetText(uVar5,uVar7,0);
          lVar6 = FUN_1802106e0(0);
          if (((lVar6 == null) || (*(int64 *)(lVar6 + 32) == 0)) ||
             ((lVar6 = *(int64 *)(*(int64 *)(lVar6 + 32) + 0x228), lVar6 == null ||
              (lVar6 = *(int64 *)(lVar6 + 48)) == null))) goto LAB_180a04e5f;
          iVar3 = FUN_180002480(lVar6,local_res8[0],DAT_181e71bf0);
          if (iVar3 < 1) {
            lVar6 = Transform.Find(lVar4,"SureButton",0);
            if (lVar6 == null) break;
            lVar6 = Component.GetComponent(lVar6,DAT_181e76ab8);
            if (this.researchItemIcon == null) break;
            uVar5 = FUN_1800024b0(this.researchItemIcon,local_res8[0],DAT_181e6bc70);
            uVar1 = Object.op_Inequality(uVar5,0,0);
            if (lVar6 == null) break;
            Selectable.set_interactable(lVar6,uVar1,0);
            lVar6 = Transform.Find(lVar4,"SureButton",0);
            if ((lVar6 == null) || (lVar6 = Transform.Find(lVar6,"Text",0)) == null) break;
            uVar5 = Component.GetComponent(lVar6,DAT_181e79538);
            LTLocalization.SetText(uVar5,"改装",0);
            lVar6 = Transform.Find(lVar4,"SureButton",0);
            if ((lVar6 == null) || (lVar6 = Transform.Find(lVar6,"Text",0)) == null) break;
            plVar10 = (int64 *)Component.GetComponent(lVar6,DAT_181e79538);
            puVar11 = (uint64 *)Color.get_black(local_78,0);
            if (plVar10 == (int64 *)0) break;
            local_88 = *puVar11;
            uStack_80 = puVar11[1];
            (**(code **)(*plVar10 + 0x2a8))(plVar10,&local_88,*(uint64 *)(*plVar10 + 0x2b0));
            lVar6 = Transform.Find(lVar4,"ClearItemButton",0);
            if (lVar6 == null) break;
            lVar6 = Component.get_gameObject(lVar6,0);
            if (this.researchItemIcon == null) break;
            uVar5 = FUN_1800024b0(this.researchItemIcon,local_res8[0],DAT_181e6bc70);
            uVar1 = Object.op_Inequality(uVar5,0,0);
            if (lVar6 == null) break;
            GameObject.SetActive(lVar6,uVar1,0);
            if (this.researchItemIcon == null) break;
            uVar5 = FUN_1800024b0(this.researchItemIcon,local_res8[0]);
            cVar2 = Object.op_Inequality(uVar5,0);
            if (!cVar2) {
              lVar4 = Transform.Find(lVar4,"ResearchText",0);
              if (lVar4 == null) break;
              uVar5 = Component.GetComponent(lVar4,DAT_181e79538);
            }
            else {
              lVar4 = Transform.Find(lVar4,"ResearchText",0);
              if (lVar4 == null) {
        LAB_180a04e59:
                          // WARNING: Subroutine does not return
                FUN_1801e0300();
              }
              uVar5 = Component.GetComponent(lVar4,DAT_181e79538);
              if ((((this.researchItemIcon == null) ||
                   (lVar4 = FUN_1800024b0(this.researchItemIcon,local_res8[0],DAT_181e6bc70),
                   lVar4 == null)) || (lVar4 = GameObject.GetComponent(lVar4,DAT_181e55168)) == null) ||
                 (*(int64 *)(lVar4 + 32) == 0)) goto LAB_180a04e59;
              fVar12 = (float)*(int *)(*(int64 *)(lVar4 + 32) + 60);
              local_8c = Mathf.Max(fVar12 + fVar12);
              uVar7 = il2cpp_value_box(DAT_181e82730,&local_8c);
              lVar4 = FUN_1802106e0(0);
              if ((lVar4 == null) || (*(int64 *)(lVar4 + 32) == 0)) goto LAB_180a04e59;
              lVar4 = *(int64 *)(*(int64 *)(lVar4 + 32) + 0x228);
              if ((this.researchItemIcon == null) ||
                 (((lVar6 = FUN_1800024b0(this.researchItemIcon,local_res8[0],DAT_181e6bc70),
                   lVar6 == null || (lVar6 = GameObject.GetComponent(lVar6,DAT_181e55168)) == null) ||
                  (lVar4 == null)))) goto LAB_180a04e59;
              if (*(int64 *)(lVar6 + 32) == 0) {
                local_res18[0] = 0;
              }
              else {
                local_res18[0] = Mathf.Max();
              }
              Single.ToString(local_res18,"f0",0);
              String.Format("改装加成{0}%\n获取经验{1}",uVar7);
            }
          }
          else {
            if (this.researchItemIcon == null) break;
            uVar5 = FUN_1800024b0(this.researchItemIcon,local_res8[0],DAT_181e6bc70);
            cVar2 = Object.op_Equality(uVar5,0,0);
            iVar3 = local_res8[0];
            if (cVar2) {
              lVar6 = this.researchItemIcon;
              lVar9 = Transform.Find(lVar4,"ResearchItem",0);
              if (lVar9 == null) break;
              uVar5 = Component.get_gameObject(lVar9,0);
              lVar9 = FUN_1802106e0(0);
              if ((((lVar9 == null) || (*(int64 *)(lVar9 + 32) == 0)) ||
                  (lVar9 = *(int64 *)(*(int64 *)(lVar9 + 32) + 0x228)) == null) ||
                 (lVar9 = *(int64 *)(lVar9 + 32)) == null) break;
              uVar7 = FUN_1800024b0(lVar9,local_res8[0],DAT_181e73170);
              uVar5 = SpeSummonResearchController.CreateResearchItemIcon(this,uVar5,uVar7,0);
              if (lVar6 == null) break;
              FUN_181769c00(lVar6,iVar3,uVar5,DAT_181e6bd70);
            }
            lVar6 = Transform.Find(lVar4,"SureButton",0);
            if ((lVar6 == null) || (lVar6 = Component.GetComponent(lVar6,DAT_181e76ab8)) == null) break;
            Selectable.set_interactable(lVar6,0,0);
            lVar6 = Transform.Find(lVar4,"SureButton",0);
            if ((lVar6 == null) || (lVar6 = Transform.Find(lVar6,"Text",0)) == null) break;
            uVar5 = Component.GetComponent(lVar6,DAT_181e79538);
            lVar6 = FUN_1802106e0(0);
            if ((((lVar6 == null) || (*(int64 *)(lVar6 + 32) == 0)) ||
                (lVar6 = *(int64 *)(*(int64 *)(lVar6 + 32) + 0x228)) == null) ||
               (lVar6 = *(int64 *)(lVar6 + 48)) == null) break;
            local_res20[0] = FUN_180002480(lVar6,local_res8[0],DAT_181e71bf0);
            uVar7 = Int32.ToString(local_res20,0);
            uVar7 = String.Concat(uVar7,"日",0);
            LTLocalization.SetText(uVar5,uVar7,0);
            lVar6 = Transform.Find(lVar4,"SureButton",0);
            if ((lVar6 == null) || (lVar6 = Transform.Find(lVar6,"Text",0)) == null) break;
            plVar10 = (int64 *)Component.GetComponent(lVar6,DAT_181e79538);
            if (plVar10 == (int64 *)0) break;
            local_88 = *(uint64 *)(pStatics_38e8 + 0x380);
            uStack_80 = *(uint64 *)(pStatics_38e8 + 0x388);
            (**(code **)(*plVar10 + 0x2a8))(plVar10,&local_88,*(uint64 *)(*plVar10 + 0x2b0));
            lVar6 = Transform.Find(lVar4,"ClearItemButton",0);
            if ((lVar6 == null) || (lVar6 = Component.get_gameObject(lVar6,0)) == null) break;
            GameObject.SetActive(lVar6,0,0);
            lVar4 = Transform.Find(lVar4,"ResearchText",0);
            if (lVar4 == null) break;
            uVar5 = Component.GetComponent(lVar4,DAT_181e79538);
            lVar4 = FUN_1802106e0(0);
            if ((((lVar4 == null) || (*(int64 *)(lVar4 + 32) == 0)) ||
                (lVar4 = *(int64 *)(*(int64 *)(lVar4 + 32) + 0x228)) == null) ||
               ((lVar4 = *(int64 *)(lVar4 + 40), lVar4 == null ||
                (lVar4 = FUN_1800024b0(lVar4,local_res8[0],DAT_181e6dff0)) == null))) break;
            uVar7 = HeroSpeAddData.GetDescribe(lVar4,1,1,1,0,0);
            String.Concat("机关改装:\n",uVar7);
          }
          LTLocalization.SetText(uVar5);
          local_res8[0] = local_res8[0] + 1;
          lVar4 = this.researchItemIcon;
        }
    }

    // Token : 0x6002253
    // RVA   : 0xA03C70   Offset: 0xA02A70   Length: 0x12A
    public GameObject CreateResearchItemIcon(GameObject parent, ItemData targetItemData)
    {
        var pStatics = *(int64*)(DAT_181e52a90 + 184);
        int64 SpeSummonResearchController.CreateResearchItemIcon
                         (uint64 this,uint64 parent,uint64 targetItemData)
        {
        uint64 uVar1;
        int64 lVar2;
        int64 lVar3;
        if (*pStatics != 0) {
          uVar1 = *(uint64 *)(*pStatics + 160);
          lVar2 = GlobalData.AddChild(parent,uVar1,0);
          if (lVar2 != null) {
            lVar3 = GameObject.GetComponent(lVar2,DAT_181e55168);
            if (lVar3 != null) {
              *(uint64 *)(lVar3 + 32) = targetItemData;
              lVar3 = GameObject.GetComponent(lVar2,DAT_181e55168);
              if (lVar3 != null) {
                *(uint32 *)(lVar3 + 40) = 1;
                lVar3 = GameObject.GetComponent(lVar2,DAT_181e55168);
                if (lVar3 != null) {
                  ItemIconController.AutoSetName(lVar3,1,0);
                  return lVar2;
                }
              }
            }
          }
        }
    }

    // Token : 0x6002254
    // RVA   : 0xA04FC0   Offset: 0xA03DC0   Length: 0x2C9
    public void ResearchItemIconButtonClicked(int id)
    {
        long lVar1;
        long lVar2;
        uint uVar3;
        bool cVar4;
        long lVar5;
        ulong uVar6;
        ulong uVar7;
        long lVar8;
        uint[] local_res8 = new uint[2];
        uint[] local_res10 = new uint[2];
        uint[] local_res20 = new uint[2];
        uint local_38;
        uint local_34;
        uint[] local_30 = new uint[2];
        local_res10[0] = id;
        uVar3 = local_res10[0];
        lVar1 = this.researchItemIcon;
        if (lVar1 == null) {
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        if (lVar1.Count <= local_res10[0]) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        uVar6 = lVar1._items[uVar3];
        cVar4 = Object.op_Inequality(uVar6,0,0);
        if (cVar4) {
          return;
        }
        lVar1 = **(int64 **)(DAT_181e977e8 + 184);
        lVar5 = il2cpp_internal(DAT_181e74e38);
        FUN_1810f3480(lVar5,DAT_181e77ae0);
        local_res8[0] = 0;
        uVar6 = il2cpp_value_box(DAT_181e60808,local_res8);
        if (lVar5 != null) {
          FUN_18175de30(lVar5,uVar6,DAT_181e77be0);
          local_res20[0] = 0;
          uVar6 = il2cpp_value_box(DAT_181e60808,local_res20);
          FUN_18175de30(lVar5,uVar6,DAT_181e77be0);
          local_38 = 0xffffffff;
          uVar6 = il2cpp_value_box(DAT_181e60808,&local_38);
          FUN_18175de30(lVar5,uVar6,DAT_181e77be0);
          local_34 = 0xffffffff;
          uVar6 = il2cpp_value_box(DAT_181e60808,&local_34);
          FUN_18175de30(lVar5,uVar6,DAT_181e77be0);
          lVar2 = this.researchIteamSubType;
          lVar8 = (int64)(int)local_res10[0];
          if (lVar2 != null) {
            if (lVar2.Count <= local_res10[0]) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            local_30[0] = *(uint32 *)(lVar2._items + 32 + lVar8 * 4);
            uVar6 = il2cpp_value_box(DAT_181e60808,local_30);
            FUN_18175de30(lVar5,uVar6,DAT_181e77be0);
            uVar6 = Component.get_gameObject(this,0);
            uVar7 = Int32.ToString(local_res10,0);
            if (lVar1 != null) {
              ChooseController.ShowChoosePanel(lVar1,1,lVar5,uVar6,"ResearchItemChoosen",uVar7,0,0,0,0);
              return;
            }
          }
        }
    }

    // Token : 0x6002255
    // RVA   : 0xA04E70   Offset: 0xA03C70   Length: 0x14F
    public void ResearchItemChoosen(string id)
    {
        var pStatics = *(int64*)(DAT_181e977e8 + 184);
        long lVar1;
        ulong uVar2;
        uint uVar3;
        long lVar4;
        lVar1 = this.researchItemIcon;
        uVar3 = Int32.Parse(id,0);
        if (this.speSummonResearchUI != null) {
          lVar4 = GameObject.get_transform(this.speSummonResearchUI,0);
          if (lVar4 != null) {
            lVar4 = Transform.Find(lVar4,id,0);
            if (lVar4 != null) {
              lVar4 = Transform.Find(lVar4,"ResearchItem",0);
              if (lVar4 != null) {
                uVar2 = Component.get_gameObject(lVar4,0);
                if ((*pStatics != 0) &&
                   (lVar4 = *(int64 *)(*pStatics + 72)) != null) {
                  lVar4 = GameObject.GetComponent(lVar4,DAT_181e55168);
                  if (lVar4 != null) {
                    uVar2 = SpeSummonResearchController.CreateResearchItemIcon
                                      (this,uVar2,*(uint64 *)(lVar4 + 32),0);
                    if (lVar1 != null) {
                      FUN_181769c00(lVar1,uVar3,uVar2,DAT_181e6bd70);
                      this.needRefresh = 1;
                      return;
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6002256
    // RVA   : 0xA03B40   Offset: 0xA02940   Length: 0x123
    public void ClearItemIcon(int id)
    {
        long lVar1;
        long lVar2;
        ulong uVar3;
        bool cVar4;
        lVar2 = this.researchItemIcon;
        if (lVar2 != null) {
          if (lVar2.Count <= id) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar1 = (int64)(int)id * 8 + 32;
          uVar3 = *(uint64 *)(lVar1 + lVar2._items);
          cVar4 = Object.op_Inequality(uVar3,0,0);
          if (!cVar4) {
            return;
          }
          lVar2 = this.researchItemIcon;
          if (lVar2 != null) {
            if (lVar2.Count <= id) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            uVar3 = *(uint64 *)(lVar1 + lVar2._items);
            Object.Destroy(uVar3,0);
            if (this.researchItemIcon != null) {
              FUN_181769c00(this.researchItemIcon,id,0,DAT_181e6bd70);
              this.needRefresh = 1;
              return;
            }
          }
        }
    }

    // Token : 0x6002257
    // RVA   : 0xA05340   Offset: 0xA04140   Length: 0xB01
    public void SureButtonClicked(int id)
    {
        uint uVar1;
        long lVar2;
        long lVar3;
        long lVar4;
        long lVar5;
        long lVar7;
        ulong uVar8;
        ulong uVar9;
        int iVar10;
        uint uVar11;
        uint[] local_res8 = new uint[2];
        uint[] local_res10 = new uint[2];
        uint[] local_res20 = new uint[2];
        ulong uVar12;
        this.needRefresh = 1;
        lVar2 = this.researchItemIcon;
        if (lVar2 != null) {
          if (lVar2.Count <= id) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar2 = lVar2._items[id];
          if ((lVar2 != null) && (lVar2 = GameObject.GetComponent(lVar2,DAT_181e55168)) != null) {
            lVar2 = *(int64 *)(lVar2 + 32);
            if ((((GameController._instance != null) &&
                 (lVar3 = GameController._instance.worldData) != null) &&
                (lVar3 = lVar3.speSummonResearchData) != null) &&
               (lVar3 = lVar3.villageAreaID) != null) {
              FUN_181769c00(lVar3,id,lVar2,DAT_181e731f0);
              if (((GameController._instance != null) &&
                  (lVar3 = GameController._instance.worldData) != null) &&
                 ((lVar3 = lVar3.speSummonResearchData, lVar3 != null &&
                  (lVar3 = lVar3.Areas) != null))) {
                FUN_181774110(lVar3,id,30,DAT_181e71cf0);
                if (((GameController._instance != null) &&
                    (lVar3 = GameController._instance.worldData) != null) &&
                   (lVar3 = WorldData.Player(lVar3,0)) != null) {
                  HeroData.LoseItem(lVar3,lVar2,1,0);
                  if ((GameController._instance != null) &&
                     (lVar3 = GameController._instance.worldData) != null) {
                    lVar3 = lVar3.speSummonResearchData;
                    if (((GameController._instance != null) &&
                        (lVar4 = GameController._instance.worldData) != null)
                       && (lVar4.speSummonResearchData != null)) {
                      if (lVar2 == null) {
                        uVar11 = 0;
                      }
                      else {
                        uVar11 = Mathf.Max(0x3f800000,(float)*(int *)(lVar2 + 56) * 0.5,0);
                      }
                      if (lVar3 != null) {
                        iVar10 = 0;
                        uVar12 = 0;
                        SpeSummonResearchData.ChangeExp(lVar3,id,uVar11,1,0);
                        lVar3 = BuildingUIController.PartyLvName;
                        if (lVar3 != null) {
                          PlotController.SetPlotItem(lVar3,lVar2,1,0);
                          lVar3 = new HeroSpeAddData(0);
                          lVar4 = il2cpp_internal(DAT_181e77728);
                          FUN_1810f3480(lVar4,DAT_181e861f0);
                          do {
                            uVar11 = (uint32)(uVar12 >> 32);
                            if (lVar3 == null) {
        LAB_180a05e3c:
                          // WARNING: Subroutine does not return
                              FUN_1801e0300();
                            }
                            HeroSpeAddData.Reset(lVar3,0);
                            lVar5 = FUN_1802106e0(0);
                            if ((lVar2 == null) ||
                               (uVar1 = Mathf.Max(1,*(int *)(lVar2 + 60) * 2), lVar5 == null))
                            goto LAB_180a05e3c;
                            uVar12 = CONCAT44(uVar11,2);
                            GameController.GenerateSpeAddByValue(lVar5,uVar1,lVar3,1,uVar12,0);
                            lVar5 = HeroSpeAddData.GetKeys(lVar3,0);
                            if (lVar5 == null) goto LAB_180a05e3c;
                            if (*(int *)(lVar5 + 24) == 0) {
                              ThrowHelper.ThrowArgumentOutOfRangeException(0);
                            }
                            uVar11 = *(uint32 *)(*(int64 *)(lVar5 + 16) + 32);
                            plVar6 = (int64 *)FUN_1801dfd90(DAT_181e84278,5);
                            local_res10[0] = id;
                            lVar5 = il2cpp_value_box(DAT_181e60808,local_res10);
                            if (plVar6 == (int64 *)0) goto LAB_180a05e3c;
                            if ((lVar5 != null) &&
                               (lVar7 = il2cpp_internal(lVar5,*(uint64 *)(*plVar6 + 64)),
                               lVar7 == null)) {
                              uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                              FUN_1801e02d0(uVar8,0);
                            }
                            if ((int)plVar6[3] == 0) {
                              uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                              FUN_1801e02d0(uVar8,0);
                            }
                            plVar6[4] = lVar5;
                            il2cpp_internal(plVar6 + 4,lVar5);
                            local_res8[0] = uVar11;
                            lVar5 = il2cpp_value_box(DAT_181e60808,local_res8);
                            if ((lVar5 != null) &&
                               (lVar7 = il2cpp_internal(lVar5,*(uint64 *)(*plVar6 + 64)),
                               lVar7 == null)) {
                              uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                              FUN_1801e02d0(uVar8,0);
                            }
                            if (*(uint32 *)(plVar6 + 3) < 2) {
                              uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                              FUN_1801e02d0(uVar8,0);
                            }
                            plVar6[5] = lVar5;
                            il2cpp_internal(plVar6 + 5,lVar5);
                            local_res20[0] = HeroSpeAddData.Get(lVar3,uVar11,0);
                            lVar5 = il2cpp_value_box(DAT_181e82730,local_res20);
                            if ((lVar5 != null) &&
                               (lVar7 = il2cpp_internal(lVar5,*(uint64 *)(*plVar6 + 64)),
                               lVar7 == null)) {
                              uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                              FUN_1801e02d0(uVar8,0);
                            }
                            if (*(uint32 *)(plVar6 + 3) < 3) {
                              uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                              FUN_1801e02d0(uVar8,0);
                            }
                            plVar6[6] = lVar5;
                            il2cpp_internal(plVar6 + 6,lVar5);
                            uVar1 = 0;
                            uVar12 = uVar12 & 0xffffffffffffff00;
                            lVar5 = HeroSpeAddData.GetDescribe(lVar3,1,1,1,uVar12,0);
                            if ((lVar5 != null) &&
                               (lVar7 = il2cpp_internal(lVar5,*(uint64 *)(*plVar6 + 64)),
                               lVar7 == null)) {
                              uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                              FUN_1801e02d0(uVar8,0);
                            }
                            if (*(uint32 *)(plVar6 + 3) < 4) {
                              uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                              FUN_1801e02d0(uVar8,0);
                            }
                            plVar6[7] = lVar5;
                            il2cpp_internal(plVar6 + 7,lVar5);
                            lVar5 = FUN_180210740(0);
                            if (((lVar5 == null) || (*(int64 *)(lVar5 + 144) == 0)) ||
                               (lVar5 = FUN_1800024b0(*(int64 *)(lVar5 + 144),uVar11,DAT_181e6e1f0),
                               uVar8 = "{3};ChooseSummonResearchItemSpeAdd;{0}-{1}-{2};;{4}", lVar5 == null)) goto LAB_180a05e3c;
                            lVar7 = "";
                            if (*(char *)(lVar5 + 89) != false) {
                              lVar5 = FUN_180210740(0);
                              if (((lVar5 == null) || (*(int64 *)(lVar5 + 144) == 0)) ||
                                 (lVar5 = FUN_1800024b0(*(int64 *)(lVar5 + 144),uVar11,DAT_181e6e1f0),
                                 lVar5 == null)) throw; // [null/range check failed]
                              lVar7 = HeroSpeAddDataBase.GetDescribe(lVar5,0);
                            }
                            if ((lVar7 != null) &&
                               (lVar5 = il2cpp_internal(lVar7,*(uint64 *)(*plVar6 + 64)),
                               lVar5 == null)) {
                              uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                              FUN_1801e02d0(uVar8,0);
                            }
                            FUN_1800025b0(plVar6,4,lVar7);
                            String.Format(uVar8,plVar6,0);
                            if (lVar4 == null) throw; // [null/range check failed]
                            FUN_18175de30(lVar4);
                            iVar10 = iVar10 + 1;
                          } while (iVar10 < 5);
                          lVar5 = DAT_181e6dc98;
                          lVar2 = BuildingUIController.PartyLvName;
                          plVar6 = *(int64 **)(DAT_181e6dc98 + 48);
                          lVar3 = *plVar6;
                          if ((*(byte *)(lVar3 + 0x132) & 1) == 0) {
                            FUN_1801a41f0(lVar3);
                            plVar6 = *(int64 **)(lVar5 + 48);
                          }
                          if ((*(byte *)(lVar3 + 0x133) & 4) != 0) {
                            lVar3 = *plVar6;
                            if ((*(byte *)(lVar3 + 0x132) & 1) == 0) {
                              FUN_1801a41f0(lVar3);
                              plVar6 = *(int64 **)(lVar5 + 48);
                            }
                            if (lVar3.missionFinished == null) {
                              lVar3 = *plVar6;
                              if ((*(byte *)(lVar3 + 0x132) & 1) == 0) {
                                FUN_1801a41f0(lVar3);
                              }
                              il2cpp_runtime_class_init(lVar3);
                            }
                          }
                          lVar3 = **(int64 **)(lVar5 + 48);
                          if ((*(byte *)(lVar3 + 0x132) & 1) == 0) {
                            FUN_1801a41f0(lVar3);
                          }
                          uVar8 = String.Format("将这#PlotInteractItemName#改装到机关兽上，可以针对某些特效进行强化。\n此后30日内召唤的所有机关兽，便都能从中获益......",*lVar3.forceMeetingStarted,0);
                          uVar9 = il2cpp_internal(DAT_181e82930);
                          SinglePlotData.ctor
                                    (uVar9,uVar8,lVar4,1,0,CONCAT44(uVar1,3),"0",1,0,0);
                          if (lVar2 != null) {
                            PlotController.ChangePlot(lVar2,uVar9,0);
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

    // Token : 0x6002258
    // RVA   : 0xA05E90   Offset: 0xA04C90   Length: 0xC8
    public void /*ctor*/()
    {
        long lVar1;
        lVar1 = il2cpp_internal(DAT_181e73cb8);
        FUN_1810f3480(lVar1,DAT_181e71270);
        if (lVar1 != null) {
          FUN_181769fe0(lVar1,2,DAT_181e713f0);
          FUN_181769fe0(lVar1,1,DAT_181e713f0);
          FUN_181769fe0(lVar1,3,DAT_181e713f0);
          this.researchIteamSubType = lVar1;
          FUN_180ae8740(this,0);
          return;
        }
    }

}
