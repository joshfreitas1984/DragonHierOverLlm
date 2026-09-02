// ============================================================
// Type  : SpeSummonResearchController
// Token : 0x2000364
// ============================================================

public class SpeSummonResearchController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001B00
    public GameObject speSummonResearchUI;

    // Token: 0x4001B01
    public List<GameObject> researchItemIcon;

    // Token: 0x4001B02
    public bool needRefresh;

    // Token: 0x4001B03
    private List<int> researchIteamSubType;

    // Token: 0x4001B04
    private static SpeSummonResearchController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002122
    // RVA   : 0xC6D0D0   Offset: 0xC6B8D0   Length: 0x36
    public static SpeSummonResearchController get_Instance()
    {
        return **(uint64 **)(DAT_181d7f2b0 + 184);
    }

    // Token : 0x6002123
    // RVA   : 0xC6AD20   Offset: 0xC69520   Length: 0x43
    private void Awake()
    {
        puVar1 = *(uint64 **)(DAT_181d7f2b0 + 184);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x6002124
    // RVA   : 0xC6CFC0   Offset: 0xC6B7C0   Length: 0x3D
    private void Update()
    {
        bool cVar1;
        if (this.speSummonResearchUI == null) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        cVar1 = GameObject.get_activeSelf(this.speSummonResearchUI,0);
        if ((cVar1) && (this.needRefresh)) {
          SpeSummonResearchController.RefreshUI(this,0);
          return;
        }
    }

    // Token : 0x6002125
    // RVA   : 0xC6AFD0   Offset: 0xC697D0   Length: 0x147
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
            FUN_18182f280();
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

    // Token : 0x6002126
    // RVA   : 0xC6C400   Offset: 0xC6AC00   Length: 0xAF
    public void ShowSpeSummonResearchUI()
    {
        if (this.speSummonResearchUI != null) {
          GameObject.SetActive(this.speSummonResearchUI,1,0);
          SpeSummonResearchController.RefreshUI(this,0);
          plVar1 = (int64 *)Resources.Load("Sound/SoundEffect/OpenBook",0);
          plVar2 = (int64 *)0;
          if ((plVar1 != (int64 *)0) && (*plVar1 == DAT_181d8a228)) {
            plVar2 = plVar1;
          }
          NGUITools.PlaySound(plVar2,0);
          return;
        }
    }

    // Token : 0x6002127
    // RVA   : 0xC6B120   Offset: 0xC69920   Length: 0xEBF
    public void RefreshUI()
    {
        var pStatics_ef00 = *(int64*)(DAT_181d4ef00 + 184);
        var pStatics_f330 = *(int64*)(DAT_181d7f330 + 184);
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
        LAB_180c6bfda:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          lVar4 = GameObject.get_transform(this.speSummonResearchUI,0);
          uVar5 = Int32.ToString(local_res8,0);
          if (((lVar4 == null) || (lVar4 = Transform.Find(lVar4,uVar5,0)) == null) ||
             (lVar6 = Transform.Find(lVar4,"Lv",0)) == null) goto LAB_180c6bfda;
          uVar5 = Component.GetComponent(lVar6,DAT_181d6d8c0);
          if (*pStatics_f330 == 0) goto LAB_180c6bfda;
          uVar7 = FUN_180002f80(*pStatics_f330,local_res8[0],DAT_181d7c9c0);
          lVar6 = FUN_18046c0a0(0);
          if ((((lVar6 == null) || (*(int64 *)(lVar6 + 32) == 0)) ||
              (lVar6 = *(int64 *)(*(int64 *)(lVar6 + 32) + 0x228)) == null) ||
             (lVar6 = lVar6._items) == null) goto LAB_180c6bfda;
          local_98 = FUN_1800d6750(lVar6,local_res8[0],DAT_181d68270);
          uVar8 = il2cpp_value_box(DAT_181d5b2f8,&local_98);
          uVar7 = String.Format("{0}等级{1}",uVar7,uVar8,0);
          LTLocalization.SetText(uVar5,uVar7,0);
          lVar6 = Transform.Find(lVar4,"ResearchLvAdd",0);
          if (lVar6 == null) goto LAB_180c6bfda;
          uVar5 = Component.GetComponent(lVar6,DAT_181d6d8c0);
          lVar6 = *(int64 *)(pStatics_f330 + 8);
          if (lVar6 == null) goto LAB_180c6bfda;
          uVar7 = FUN_180002f80(lVar6,local_res8[0],DAT_181d7c9c0);
          lVar6 = FUN_18046c0a0(0);
          if (((lVar6 == null) || (*(int64 *)(lVar6 + 32) == 0)) ||
             ((lVar6 = *(int64 *)(*(int64 *)(lVar6 + 32) + 0x228), lVar6 == null ||
              (lVar6 = lVar6._items) == null))) goto LAB_180c6bfda;
          local_94 = FUN_1800d6750(lVar6,local_res8[0],DAT_181d68270);
          local_94 = local_94 * 2;
          uVar8 = il2cpp_value_box(DAT_181d5b2f8,&local_94);
          uVar7 = String.Format("{0}+{1}%",uVar7,uVar8,0);
          LTLocalization.SetText(uVar5,uVar7,0);
          lVar6 = Transform.Find(lVar4,"ExpBarBack",0);
          if ((lVar6 == null) || (lVar6 = Transform.Find(lVar6,"ExpBar",0)) == null)
          goto LAB_180c6bfda;
          lVar6 = Component.GetComponent(lVar6,DAT_181d6bc40);
          lVar9 = FUN_18046c0a0(0);
          if ((lVar9 == null) ||
             (((*(int64 *)(lVar9 + 32) == 0 ||
               (lVar9 = *(int64 *)(*(int64 *)(lVar9 + 32) + 0x228)) == null) ||
              (lVar9 = *(int64 *)(lVar9 + 24)) == null))) goto LAB_180c6bfda;
          FUN_1800d6780(lVar9,local_res8[0],DAT_181d796d8);
          lVar9 = FUN_18046c0a0(0);
          if (((lVar9 == null) || (*(int64 *)(lVar9 + 32) == 0)) ||
             ((lVar9 = *(int64 *)(*(int64 *)(lVar9 + 32) + 0x228), lVar9 == null ||
              (SpeSummonResearchData.GetMaxExp(lVar9,local_res8[0],0), lVar6 == null)))) goto LAB_180c6bfda;
          Image.set_fillAmount(lVar6);
          lVar6 = Transform.Find(lVar4,"ExpBarBack",0);
          if ((lVar6 == null) || (lVar6 = Transform.Find(lVar6,"ExpText",0)) == null)
          goto LAB_180c6bfda;
          uVar5 = Component.GetComponent(lVar6,DAT_181d6d8c0);
          lVar6 = FUN_18046c0a0(0);
          if ((lVar6 == null) ||
             (((*(int64 *)(lVar6 + 32) == 0 ||
               (lVar6 = *(int64 *)(*(int64 *)(lVar6 + 32) + 0x228)) == null) ||
              (lVar6 = lVar6.Count) == null))) goto LAB_180c6bfda;
          local_res18[0] = FUN_1800d6780(lVar6,local_res8[0],DAT_181d796d8);
          uVar7 = Single.ToString(local_res18,"f0",0);
          lVar6 = FUN_18046c0a0(0);
          if (((lVar6 == null) || (*(int64 *)(lVar6 + 32) == 0)) ||
             (lVar6 = *(int64 *)(*(int64 *)(lVar6 + 32) + 0x228)) == null) goto LAB_180c6bfda;
          local_90 = SpeSummonResearchData.GetMaxExp(lVar6,local_res8[0],0);
          uVar8 = il2cpp_value_box(DAT_181d7d0b8,&local_90);
          uVar7 = String.Format("{0}/{1}",uVar7,uVar8,0);
          LTLocalization.SetText(uVar5,uVar7,0);
          lVar6 = FUN_18046c0a0(0);
          if (((lVar6 == null) || (*(int64 *)(lVar6 + 32) == 0)) ||
             ((lVar6 = *(int64 *)(*(int64 *)(lVar6 + 32) + 0x228), lVar6 == null ||
              (lVar6 = *(int64 *)(lVar6 + 48)) == null))) goto LAB_180c6bfda;
          iVar3 = FUN_1800d6750(lVar6,local_res8[0],DAT_181d68270);
          if (iVar3 < 1) {
            lVar6 = Transform.Find(lVar4,"SureButton",0);
            if (lVar6 == null) break;
            lVar6 = Component.GetComponent(lVar6,DAT_181d6af40);
            if (this.researchItemIcon == null) break;
            uVar5 = FUN_180002f80(this.researchItemIcon,local_res8[0],DAT_181d62178);
            uVar1 = Object.op_Inequality(uVar5,0,0);
            if (lVar6 == null) break;
            Selectable.set_interactable(lVar6,uVar1,0);
            lVar6 = Transform.Find(lVar4,"SureButton",0);
            if ((lVar6 == null) || (lVar6 = Transform.Find(lVar6,"Text",0)) == null) break;
            uVar5 = Component.GetComponent(lVar6,DAT_181d6d8c0);
            LTLocalization.SetText(uVar5,"改装",0);
            lVar6 = Transform.Find(lVar4,"SureButton",0);
            if ((lVar6 == null) || (lVar6 = Transform.Find(lVar6,"Text",0)) == null) break;
            plVar10 = (int64 *)Component.GetComponent(lVar6,DAT_181d6d8c0);
            puVar11 = (uint64 *)Color.get_black(local_78,0);
            if (plVar10 == (int64 *)0) break;
            local_88 = *puVar11;
            uStack_80 = puVar11[1];
            (**(code **)(*plVar10 + 0x2a8))(plVar10,&local_88,*(uint64 *)(*plVar10 + 0x2b0));
            lVar6 = Transform.Find(lVar4,"ClearItemButton",0);
            if (lVar6 == null) break;
            lVar6 = Component.get_gameObject(lVar6,0);
            if (this.researchItemIcon == null) break;
            uVar5 = FUN_180002f80(this.researchItemIcon,local_res8[0],DAT_181d62178);
            uVar1 = Object.op_Inequality(uVar5,0,0);
            if (lVar6 == null) break;
            GameObject.SetActive(lVar6,uVar1,0);
            if (this.researchItemIcon == null) break;
            uVar5 = FUN_180002f80(this.researchItemIcon,local_res8[0]);
            cVar2 = Object.op_Inequality(uVar5,0);
            if (!cVar2) {
              lVar4 = Transform.Find(lVar4,"ResearchText",0);
              if (lVar4 == null) break;
              uVar5 = Component.GetComponent(lVar4,DAT_181d6d8c0);
            }
            else {
              lVar4 = Transform.Find(lVar4,"ResearchText",0);
              if (lVar4 == null) {
        LAB_180c6bfd4:
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              uVar5 = Component.GetComponent(lVar4,DAT_181d6d8c0);
              if ((((this.researchItemIcon == null) ||
                   (lVar4 = FUN_180002f80(this.researchItemIcon,local_res8[0],DAT_181d62178),
                   lVar4 == null)) || (lVar4 = GameObject.GetComponent(lVar4,DAT_181da0070)) == null) ||
                 (*(int64 *)(lVar4 + 32) == 0)) goto LAB_180c6bfd4;
              fVar12 = (float)*(int *)(*(int64 *)(lVar4 + 32) + 60);
              local_8c = Mathf.Max(fVar12 + fVar12);
              uVar7 = il2cpp_value_box(DAT_181d7d0b8,&local_8c);
              lVar4 = FUN_18046c0a0(0);
              if ((lVar4 == null) || (*(int64 *)(lVar4 + 32) == 0)) goto LAB_180c6bfd4;
              lVar4 = *(int64 *)(*(int64 *)(lVar4 + 32) + 0x228);
              if ((this.researchItemIcon == null) ||
                 (((lVar6 = FUN_180002f80(this.researchItemIcon,local_res8[0],DAT_181d62178),
                   lVar6 == null || (lVar6 = GameObject.GetComponent(lVar6,DAT_181da0070)) == null) ||
                  (lVar4 == null)))) goto LAB_180c6bfd4;
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
            uVar5 = FUN_180002f80(this.researchItemIcon,local_res8[0],DAT_181d62178);
            cVar2 = Object.op_Equality(uVar5,0,0);
            iVar3 = local_res8[0];
            if (cVar2) {
              lVar6 = this.researchItemIcon;
              lVar9 = Transform.Find(lVar4,"ResearchItem",0);
              if (lVar9 == null) break;
              uVar5 = Component.get_gameObject(lVar9,0);
              lVar9 = FUN_18046c0a0(0);
              if ((((lVar9 == null) || (*(int64 *)(lVar9 + 32) == 0)) ||
                  (lVar9 = *(int64 *)(*(int64 *)(lVar9 + 32) + 0x228)) == null) ||
                 (lVar9 = *(int64 *)(lVar9 + 32)) == null) break;
              uVar7 = FUN_180002f80(lVar9,local_res8[0],DAT_181d69770);
              uVar5 = SpeSummonResearchController.CreateResearchItemIcon(this,uVar5,uVar7,0);
              if (lVar6 == null) break;
              FUN_18182f280(lVar6,iVar3,uVar5,DAT_181d62278);
            }
            lVar6 = Transform.Find(lVar4,"SureButton",0);
            if ((lVar6 == null) || (lVar6 = Component.GetComponent(lVar6,DAT_181d6af40)) == null) break;
            Selectable.set_interactable(lVar6,0,0);
            lVar6 = Transform.Find(lVar4,"SureButton",0);
            if ((lVar6 == null) || (lVar6 = Transform.Find(lVar6,"Text",0)) == null) break;
            uVar5 = Component.GetComponent(lVar6,DAT_181d6d8c0);
            lVar6 = FUN_18046c0a0(0);
            if ((((lVar6 == null) || (*(int64 *)(lVar6 + 32) == 0)) ||
                (lVar6 = *(int64 *)(*(int64 *)(lVar6 + 32) + 0x228)) == null) ||
               (lVar6 = *(int64 *)(lVar6 + 48)) == null) break;
            local_res20[0] = FUN_1800d6750(lVar6,local_res8[0],DAT_181d68270);
            uVar7 = Int32.ToString(local_res20,0);
            uVar7 = String.Concat(uVar7,"日",0);
            LTLocalization.SetText(uVar5,uVar7,0);
            lVar6 = Transform.Find(lVar4,"SureButton",0);
            if ((lVar6 == null) || (lVar6 = Transform.Find(lVar6,"Text",0)) == null) break;
            plVar10 = (int64 *)Component.GetComponent(lVar6,DAT_181d6d8c0);
            if (plVar10 == (int64 *)0) break;
            local_88 = *(uint64 *)(pStatics_ef00 + 0x370);
            uStack_80 = *(uint64 *)(pStatics_ef00 + 0x378);
            (**(code **)(*plVar10 + 0x2a8))(plVar10,&local_88,*(uint64 *)(*plVar10 + 0x2b0));
            lVar6 = Transform.Find(lVar4,"ClearItemButton",0);
            if ((lVar6 == null) || (lVar6 = Component.get_gameObject(lVar6,0)) == null) break;
            GameObject.SetActive(lVar6,0,0);
            lVar4 = Transform.Find(lVar4,"ResearchText",0);
            if (lVar4 == null) break;
            uVar5 = Component.GetComponent(lVar4,DAT_181d6d8c0);
            lVar4 = FUN_18046c0a0(0);
            if ((((lVar4 == null) || (*(int64 *)(lVar4 + 32) == 0)) ||
                (lVar4 = *(int64 *)(*(int64 *)(lVar4 + 32) + 0x228)) == null) ||
               ((lVar4 = *(int64 *)(lVar4 + 40), lVar4 == null ||
                (lVar4 = FUN_180002f80(lVar4,local_res8[0],DAT_181d64678)) == null))) break;
            uVar7 = HeroSpeAddData.GetDescribe(lVar4,1,1,1,0,0);
            String.Concat("机关改装:\n",uVar7);
          }
          LTLocalization.SetText(uVar5);
          local_res8[0] = local_res8[0] + 1;
          lVar4 = this.researchItemIcon;
        }
    }

    // Token : 0x6002128
    // RVA   : 0xC6AEA0   Offset: 0xC696A0   Length: 0x12A
    public GameObject CreateResearchItemIcon(GameObject parent, ItemData targetItemData)
    {
        var pStatics = *(int64*)(DAT_181d4e188 + 184);
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
            lVar3 = GameObject.GetComponent(lVar2,DAT_181da0070);
            if (lVar3 != null) {
              *(uint64 *)(lVar3 + 32) = targetItemData;
              lVar3 = GameObject.GetComponent(lVar2,DAT_181da0070);
              if (lVar3 != null) {
                *(uint32 *)(lVar3 + 40) = 1;
                lVar3 = GameObject.GetComponent(lVar2,DAT_181da0070);
                if (lVar3 != null) {
                  ItemIconController.AutoSetName(lVar3,1,0);
                  return lVar2;
                }
              }
            }
          }
        }
    }

    // Token : 0x6002129
    // RVA   : 0xC6C130   Offset: 0xC6A930   Length: 0x2C9
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
          FUN_1800d6620();
        }
        if (lVar1.Count <= local_res10[0]) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        uVar6 = lVar1._items[uVar3];
        cVar4 = Object.op_Inequality(uVar6,0,0);
        if (cVar4) {
          return;
        }
        lVar1 = **(int64 **)(DAT_181d92370 + 184);
        lVar5 = il2cpp_internal(DAT_181d701b0);
        FUN_180f58a90(lVar5,DAT_181d6dfe8);
        local_res8[0] = 0;
        uVar6 = il2cpp_value_box(DAT_181d5b2f8,local_res8);
        if (lVar5 != null) {
          FUN_181827900(lVar5,uVar6,DAT_181d6e0e8);
          local_res20[0] = 0;
          uVar6 = il2cpp_value_box(DAT_181d5b2f8,local_res20);
          FUN_181827900(lVar5,uVar6,DAT_181d6e0e8);
          local_38 = 0xffffffff;
          uVar6 = il2cpp_value_box(DAT_181d5b2f8,&local_38);
          FUN_181827900(lVar5,uVar6,DAT_181d6e0e8);
          local_34 = 0xffffffff;
          uVar6 = il2cpp_value_box(DAT_181d5b2f8,&local_34);
          FUN_181827900(lVar5,uVar6,DAT_181d6e0e8);
          lVar2 = this.researchIteamSubType;
          lVar8 = (int64)(int)local_res10[0];
          if (lVar2 != null) {
            if (lVar2.Count <= local_res10[0]) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            local_30[0] = *(uint32 *)(lVar2._items + 32 + lVar8 * 4);
            uVar6 = il2cpp_value_box(DAT_181d5b2f8,local_30);
            FUN_181827900(lVar5,uVar6,DAT_181d6e0e8);
            uVar6 = Component.get_gameObject(this,0);
            uVar7 = Int32.ToString(local_res10,0);
            if (lVar1 != null) {
              ChooseController.ShowChoosePanel(lVar1,1,lVar5,uVar6,"ResearchItemChoosen",uVar7,0,0,0,0);
              return;
            }
          }
        }
    }

    // Token : 0x600212A
    // RVA   : 0xC6BFE0   Offset: 0xC6A7E0   Length: 0x14F
    public void ResearchItemChoosen(string id)
    {
        var pStatics = *(int64*)(DAT_181d92370 + 184);
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
                  lVar4 = GameObject.GetComponent(lVar4,DAT_181da0070);
                  if (lVar4 != null) {
                    uVar2 = SpeSummonResearchController.CreateResearchItemIcon
                                      (this,uVar2,*(uint64 *)(lVar4 + 32),0);
                    if (lVar1 != null) {
                      FUN_18182f280(lVar1,uVar3,uVar2,DAT_181d62278);
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

    // Token : 0x600212B
    // RVA   : 0xC6AD70   Offset: 0xC69570   Length: 0x123
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
              FUN_18182f280(this.researchItemIcon,id,0,DAT_181d62278);
              this.needRefresh = 1;
              return;
            }
          }
        }
    }

    // Token : 0x600212C
    // RVA   : 0xC6C4B0   Offset: 0xC6ACB0   Length: 0xB00
    public void SureButtonClicked(int id)
    {
        var pStatics_c960 = *(int64*)(DAT_181d6c960 + 184);
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
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
          if ((lVar2 != null) && (lVar2 = GameObject.GetComponent(lVar2,DAT_181da0070)) != null) {
            lVar2 = *(int64 *)(lVar2 + 32);
            if ((((*pStatics_df90 != 0) &&
                 (lVar3 = *(int64 *)(*pStatics_df90 + 32)) != null) &&
                (lVar3 = *(int64 *)(lVar3 + 0x228)) != null) &&
               (lVar3 = *(int64 *)(lVar3 + 32)) != null) {
              FUN_18182f280(lVar3,id,lVar2,DAT_181d697f0);
              if (((*pStatics_df90 != 0) &&
                  (lVar3 = *(int64 *)(*pStatics_df90 + 32)) != null) &&
                 ((lVar3 = *(int64 *)(lVar3 + 0x228), lVar3 != null &&
                  (lVar3 = *(int64 *)(lVar3 + 48)) != null))) {
                FUN_18181e970(lVar3,id,30,DAT_181d68370);
                if (((*pStatics_df90 != 0) &&
                    (lVar3 = *(int64 *)(*pStatics_df90 + 32)) != null) &&
                   (lVar3 = WorldData.Player(lVar3,0)) != null) {
                  HeroData.LoseItem(lVar3,lVar2,1,0);
                  if ((*pStatics_df90 != 0) &&
                     (lVar3 = *(int64 *)(*pStatics_df90 + 32)) != null) {
                    lVar3 = *(int64 *)(lVar3 + 0x228);
                    if (((*pStatics_df90 != 0) &&
                        (lVar4 = *(int64 *)(*pStatics_df90 + 32)) != null)
                       && (*(int64 *)(lVar4 + 0x228) != 0)) {
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
                        if (*pStatics_c960 != 0) {
                          PlotController.SetPlotItem(*pStatics_c960,lVar2,1,0);
                          lVar3 = new HeroSpeAddData(0);
                          lVar4 = il2cpp_internal(DAT_181d72a30);
                          FUN_180f58a90(lVar4,DAT_181d7c250);
                          do {
                            uVar11 = (uint32)(uVar12 >> 32);
                            if (lVar3 == null) {
        LAB_180c6cfab:
                          // WARNING: Subroutine does not return
                              FUN_1800d6620();
                            }
                            HeroSpeAddData.Reset(lVar3,0);
                            lVar5 = FUN_18046c0a0(0);
                            if ((lVar2 == null) ||
                               (uVar1 = Mathf.Max(1,*(int *)(lVar2 + 60) * 2), lVar5 == null))
                            goto LAB_180c6cfab;
                            uVar12 = CONCAT44(uVar11,2);
                            GameController.GenerateSpeAddByValue(lVar5,uVar1,lVar3,1,uVar12,0);
                            lVar5 = HeroSpeAddData.GetKeys(lVar3,0);
                            if (lVar5 == null) goto LAB_180c6cfab;
                            if (*(int *)(lVar5 + 24) == 0) {
                              ThrowHelper.ThrowArgumentOutOfRangeException(0);
                            }
                            uVar11 = *(uint32 *)(*(int64 *)(lVar5 + 16) + 32);
                            plVar6 = (int64 *)FUN_1800d60b0(DAT_181d7f180,5);
                            local_res10[0] = id;
                            lVar5 = il2cpp_value_box(DAT_181d5b2f8,local_res10);
                            if (plVar6 == (int64 *)0) goto LAB_180c6cfab;
                            if ((lVar5 != null) &&
                               (lVar7 = il2cpp_internal(lVar5,*(uint64 *)(*plVar6 + 64)),
                               lVar7 == null)) {
                              uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                              FUN_1800d65f0(uVar8,0);
                            }
                            if ((int)plVar6[3] == 0) {
                              uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                              FUN_1800d65f0(uVar8,0);
                            }
                            plVar6[4] = lVar5;
                            il2cpp_internal(plVar6 + 4,lVar5);
                            local_res8[0] = uVar11;
                            lVar5 = il2cpp_value_box(DAT_181d5b2f8,local_res8);
                            if ((lVar5 != null) &&
                               (lVar7 = il2cpp_internal(lVar5,*(uint64 *)(*plVar6 + 64)),
                               lVar7 == null)) {
                              uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                              FUN_1800d65f0(uVar8,0);
                            }
                            if (*(uint32 *)(plVar6 + 3) < 2) {
                              uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                              FUN_1800d65f0(uVar8,0);
                            }
                            plVar6[5] = lVar5;
                            il2cpp_internal(plVar6 + 5,lVar5);
                            local_res20[0] = HeroSpeAddData.Get(lVar3,uVar11,0);
                            lVar5 = il2cpp_value_box(DAT_181d7d0b8,local_res20);
                            if ((lVar5 != null) &&
                               (lVar7 = il2cpp_internal(lVar5,*(uint64 *)(*plVar6 + 64)),
                               lVar7 == null)) {
                              uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                              FUN_1800d65f0(uVar8,0);
                            }
                            if (*(uint32 *)(plVar6 + 3) < 3) {
                              uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                              FUN_1800d65f0(uVar8,0);
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
                              FUN_1800d65f0(uVar8,0);
                            }
                            if (*(uint32 *)(plVar6 + 3) < 4) {
                              uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                              FUN_1800d65f0(uVar8,0);
                            }
                            plVar6[7] = lVar5;
                            il2cpp_internal(plVar6 + 7,lVar5);
                            lVar5 = FUN_18046c100(0);
                            if (((lVar5 == null) || (*(int64 *)(lVar5 + 144) == 0)) ||
                               (lVar5 = FUN_180002f80(*(int64 *)(lVar5 + 144),uVar11,DAT_181d64878),
                               uVar8 = "{3};ChooseSummonResearchItemSpeAdd;{0}-{1}-{2};;{4}", lVar5 == null)) goto LAB_180c6cfab;
                            lVar7 = "";
                            if (*(char *)(lVar5 + 89) != false) {
                              lVar5 = FUN_18046c100(0);
                              if (((lVar5 == null) || (*(int64 *)(lVar5 + 144) == 0)) ||
                                 (lVar5 = FUN_180002f80(*(int64 *)(lVar5 + 144),uVar11,DAT_181d64878),
                                 lVar5 == null)) throw; // [null/range check failed]
                              lVar7 = HeroSpeAddDataBase.GetDescribe(lVar5,0);
                            }
                            if ((lVar7 != null) &&
                               (lVar5 = il2cpp_internal(lVar7,*(uint64 *)(*plVar6 + 64)),
                               lVar5 == null)) {
                              uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                              FUN_1800d65f0(uVar8,0);
                            }
                            FUN_180002fd0(plVar6,4,lVar7);
                            String.Format(uVar8,plVar6,0);
                            if (lVar4 == null) throw; // [null/range check failed]
                            FUN_181827900(lVar4);
                            iVar10 = iVar10 + 1;
                          } while (iVar10 < 5);
                          lVar5 = DAT_181d63120;
                          lVar2 = *pStatics_c960;
                          plVar6 = *(int64 **)(DAT_181d63120 + 48);
                          lVar3 = *plVar6;
                          if ((*(byte *)(lVar3 + 0x132) & 1) == 0) {
                            FUN_18009a510(lVar3);
                            plVar6 = *(int64 **)(lVar5 + 48);
                          }
                          if ((*(byte *)(lVar3 + 0x133) & 4) != 0) {
                            lVar3 = *plVar6;
                            if ((*(byte *)(lVar3 + 0x132) & 1) == 0) {
                              FUN_18009a510(lVar3);
                              plVar6 = *(int64 **)(lVar5 + 48);
                            }
                            if (*(int *)(lVar3 + 224) == 0) {
                              lVar3 = *plVar6;
                              if ((*(byte *)(lVar3 + 0x132) & 1) == 0) {
                                FUN_18009a510(lVar3);
                              }
                              il2cpp_runtime_class_init(lVar3);
                            }
                          }
                          lVar3 = **(int64 **)(lVar5 + 48);
                          if ((*(byte *)(lVar3 + 0x132) & 1) == 0) {
                            FUN_18009a510(lVar3);
                          }
                          uVar8 = String.Format("将这#PlotInteractItemName#改装到机关兽上，可以针对某些特效进行强化。\n此后30日内召唤的所有机关兽，便都能从中获益......",**(uint64 **)(lVar3 + 184),0);
                          uVar9 = il2cpp_internal(DAT_181d7d2b0);
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

    // Token : 0x600212D
    // RVA   : 0xC6D000   Offset: 0xC6B800   Length: 0xC8
    public void /*ctor*/()
    {
        long lVar1;
        lVar1 = il2cpp_internal(DAT_181d6f030);
        FUN_180f58a90(lVar1,DAT_181d678f8);
        if (lVar1 != null) {
          FUN_181814fa0(lVar1,2,DAT_181d67a78);
          FUN_181814fa0(lVar1,1,DAT_181d67a78);
          FUN_181814fa0(lVar1,3,DAT_181d67a78);
          this.researchIteamSubType = lVar1;
          FUN_18044ef50(this,0);
          return;
        }
    }

}
