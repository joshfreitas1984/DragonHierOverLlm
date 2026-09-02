// ============================================================
// Type  : BookStoreController
// Token : 0x200019A
// ============================================================

public class BookStoreController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000ADB
    public List<Color> bookStoreCaseBackColor;

    // Token: 0x4000ADC
    public BookStoreUIType bookStoreUIType;

    // Token: 0x4000ADD
    public GameObject bookStoreUI;

    // Token: 0x4000ADE
    public GameObject bookStoreCasePrefab;

    // Token: 0x4000ADF
    private static BookStoreController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000D26
    // RVA   : 0xCDEF80   Offset: 0xCDD780   Length: 0x36
    public static BookStoreController get_Instance()
    {
        return **(uint64 **)(DAT_181d8d678 + 184);
    }

    // Token : 0x6000D27
    // RVA   : 0xCDD970   Offset: 0xCDC170   Length: 0x43
    private void Awake()
    {
        puVar1 = *(uint64 **)(DAT_181d8d678 + 184);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x6000D28
    // RVA   : 0xCDD9C0   Offset: 0xCDC1C0   Length: 0x1CB
    public void HideBookStoreUI()
    {
        long lVar1;
        ulong uVar2;
        int iVar3;
        int[] local_res8 = new int[2];
        if (this.bookStoreUI != null) {
          GameObject.SetActive(this.bookStoreUI,0,0);
          iVar3 = 0;
          while( true ) {
            local_res8[0] = iVar3;
            lVar1 = *(int64 *)(*(int64 *)(DAT_181d4ef00 + 184) + 0x4f0);
            if (lVar1 == null) break;
            if (*(int *)(lVar1 + 24) <= iVar3) {
              return;
            }
            if (this.bookStoreUI == null) break;
            lVar1 = GameObject.get_transform(this.bookStoreUI,0);
            if (lVar1 == null) break;
            lVar1 = Transform.Find(lVar1,"Grid",0);
            uVar2 = Int32.ToString(local_res8,0);
            if (lVar1 == null) break;
            lVar1 = Transform.Find(lVar1,uVar2,0);
            if (lVar1 == null) break;
            lVar1 = Transform.Find(lVar1,"Scroll View",0);
            if (lVar1 == null) break;
            lVar1 = Transform.Find(lVar1,"Viewport",0);
            if (lVar1 == null) break;
            lVar1 = Transform.Find(lVar1,"Content",0);
            if (lVar1 == null) break;
            uVar2 = Component.get_gameObject(lVar1);
            GlobalData.DeleteAllChild(uVar2);
            iVar3 = local_res8[0] + 1;
          }
        }
    }

    // Token : 0x6000D29
    // RVA   : 0xCDDB90   Offset: 0xCDC390   Length: 0x13EB
    public void ShowBookStoreUI(BookStoreUIType targetType, ForceData targetForce)
    {
        var pStatics = *(int64*)(DAT_181d4ef00 + 184);
        var ptargetForce = *(int64*)(targetForce + 184);
        uint uVar2;
        ulong uVar3;
        bool cVar4;
        uint uVar5;
        long lVar7;
        ulong uVar8;
        ulong uVar9;
        long lVar10;
        int iVar12;
        uint uVar13;
        long lVar15;
        int local_a8;
        int local_a4;
        float[] local_a0 = new float[2];
        long local_98;
        uint local_88;
        uint uStack_84;
        uint uStack_80;
        uint32 uStack_7c;
        uint64 local_78;
        uint64 local_68;
        uint64 uStack_60;
        uint64 local_58;
        plVar14 = (int64 *)0;
        local_a4 = 0;
        local_68 = 0;
        uStack_60 = 0;
        local_58 = 0;
        local_a0[0] = 0.0;
        local_a8 = 0;
        plVar6 = (int64 *)Resources.Load("Sound/SoundEffect/OpenBook",0);
        plVar11 = plVar14;
        if ((plVar6 != (int64 *)0) && (*plVar6 == DAT_181d8a228)) {
          plVar11 = plVar6;
        }
        NGUITools.PlaySound(plVar11,0);
        if (this.bookStoreUI != null) {
          GameObject.SetActive(this.bookStoreUI,1,0);
          this.bookStoreUIType = targetType;
          if (targetForce != null) {
            lVar15 = 32;
            while ((local_98 = lVar15, ptargetForce != 0 &&
                   (lVar7 = *(int64 *)(ptargetForce + 48)) != null)) {
              if (lVar7.Count < 4) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar7 = *(int64 *)(lVar7._items + 56);
              if (lVar7 == null) break;
              uVar13 = (uint32)plVar14;
              if (lVar7.Count <= (int)uVar13) {
                iVar12 = 0;
                goto LAB_180cde3b0;
              }
              if ((this.bookStoreUI == null) ||
                 (lVar7 = GameObject.get_transform(this.bookStoreUI,0)) == null) break;
              lVar7 = Transform.Find(lVar7,"Grid",0);
              if ((ptargetForce == 0) ||
                 (lVar10 = *(int64 *)(ptargetForce + 48)) == null) break;
              if (*(uint32 *)(lVar10 + 24) < 4) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar10 = *(int64 *)(*(int64 *)(lVar10 + 16) + 56);
              if (lVar10 == null) break;
              if (*(uint32 *)(lVar10 + 24) <= uVar13) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar15 = *(int64 *)(lVar15 + *(int64 *)(lVar10 + 16));
              if ((((lVar15 == null) || (lVar15 = *(int64 *)(lVar15 + 112)) == null) ||
                  (lVar15 = BookData.DataBase(lVar15,0)) == null) ||
                 (((uVar8 = Int32.ToString(lVar15 + 52,0), lVar7 == null ||
                   (lVar15 = Transform.Find(lVar7,uVar8,0)) == null) ||
                  ((lVar15 = Transform.Find(lVar15,"Scroll View",0), lVar15 == null ||
                   ((lVar15 = Transform.Find(lVar15,"Viewport",0), lVar15 == null ||
                    (lVar15 = Transform.Find(lVar15,"Content",0)) == null))))))) break;
              uVar9 = Component.get_gameObject(lVar15,0);
              uVar8 = this.bookStoreCasePrefab;
              lVar15 = GlobalData.AddChild(uVar9,uVar8,0);
              if (((lVar15 == null) || (lVar7 = GameObject.get_transform(lVar15,0)) == null) ||
                 (lVar7 = Transform.Find(lVar7,"Back",0)) == null) break;
              plVar6 = (int64 *)Component.GetComponent(lVar7,DAT_181d6bc40);
              lVar7 = this.bookStoreCaseBackColor;
              if ((ptargetForce == 0) ||
                 (lVar10 = *(int64 *)(ptargetForce + 48)) == null) break;
              if (*(uint32 *)(lVar10 + 24) < 4) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar10 = *(int64 *)(*(int64 *)(lVar10 + 16) + 56);
              if (((lVar10 == null) || (lVar10 = FUN_180002f80(lVar10,plVar14,DAT_181d69770)) == null)
                 || ((*(int64 *)(lVar10 + 112) == 0 ||
                     (lVar10 = BookData.DataBase(*(int64 *)(lVar10 + 112),0)) == null))) break;
              uVar2 = *(uint32 *)(lVar10 + 52);
              if (lVar7 == null) break;
              if (lVar7.Count <= uVar2) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              if (plVar6 == (int64 *)0) break;
              puVar1 = (uint32 *)(lVar7._items + ((int64)(int)uVar2 + 2) * 16);
              local_88 = *puVar1;
              uStack_84 = puVar1[1];
              uStack_80 = puVar1[2];
              uStack_7c = puVar1[3];
              (**(code **)(*plVar6 + 0x2a8))(plVar6,&local_88,*(uint64 *)(*plVar6 + 0x2b0));
              lVar7 = GameObject.get_transform(lVar15,0);
              if (((lVar7 == null) || (lVar7 = Transform.Find(lVar7,"BookName",0)) == null) ||
                 (lVar7 = Transform.Find(lVar7,"Text",0)) == null) break;
              uVar8 = Component.GetComponent(lVar7,DAT_181d6d8c0);
              if ((ptargetForce == 0) ||
                 (lVar7 = *(int64 *)(ptargetForce + 48)) == null) break;
              if (lVar7.Count < 4) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar7 = *(int64 *)(lVar7._items + 56);
              if ((lVar7 == null) || (lVar7 = FUN_180002f80(lVar7,plVar14,DAT_181d69770)) == null) break;
              uVar9 = ItemData.Name(lVar7,0,0);
              LTLocalization.SetText(uVar8,uVar9,0);
              lVar15 = GameObject.get_transform(lVar15,0);
              if ((lVar15 == null) || (lVar15 = Transform.Find(lVar15,"BookIcon",0)) == null) break;
              uVar8 = Component.get_gameObject(lVar15,0);
              lVar15 = FUN_18046c1a0(0);
              if ((lVar15 == null) ||
                 (lVar15 = GlobalData.AddChild(uVar8,*(uint64 *)(lVar15 + 160),0)) == null)
              break;
              lVar7 = GameObject.GetComponent(lVar15,DAT_181da0070);
              if ((ptargetForce == 0) ||
                 (lVar10 = *(int64 *)(ptargetForce + 48)) == null) break;
              if (*(uint32 *)(lVar10 + 24) < 4) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar10 = *(int64 *)(*(int64 *)(lVar10 + 16) + 56);
              if ((lVar10 == null) || (uVar8 = FUN_180002f80(lVar10,plVar14), lVar7 == null)) break;
              *(uint64 *)(lVar7 + 32) = uVar8;
              if (this.bookStoreUIType == null) {
                lVar7 = GameObject.GetComponent(lVar15,DAT_181da0070);
                if (lVar7 == null) break;
                *(uint32 *)(lVar7 + 40) = 5;
              }
              lVar7 = GameObject.GetComponent(lVar15,DAT_181da0070);
              if (lVar7 == null) break;
              ItemIconController.AutoSetName(lVar7,1);
              lVar7 = GameObject.GetComponent(lVar15,DAT_181da0070);
              if (lVar7 == null) break;
              *(uint8 *)(lVar7 + 53) = 1;
              lVar7 = GameObject.GetComponent(lVar15,DAT_181da0070);
              if (lVar7 == null) break;
              *(uint8 *)(lVar7 + 54) = 1;
              Object.get_name(lVar15,0);
              Object.set_name();
              plVar14 = (int64 *)(uint64)(uVar13 + 1);
              lVar15 = local_98 + 8;
            }
          }
        }
        throw; // [null/range check failed]
        LAB_180cde3b0:
        lVar7 = "";
        lVar15 = *(int64 *)(pStatics + 0x4f0);
        if (lVar15 == null) throw; // [null/range check failed]
        if (iVar12 < *(int *)(lVar15 + 24)) {
          if ((this.bookStoreUI == null) ||
             (lVar15 = GameObject.get_transform(this.bookStoreUI,0)) == null)
          throw; // [null/range check failed]
          lVar15 = Transform.Find(lVar15,"Grid",0);
          uVar8 = Int32.ToString(&local_a4,0);
          if ((lVar15 == null) ||
             ((((lVar15 = Transform.Find(lVar15,uVar8,0), lVar15 == null ||
                (lVar15 = Transform.Find(lVar15,"Scroll View",0)) == null) ||
               (lVar15 = Transform.Find(lVar15,"Viewport",0)) == null) ||
              (lVar15 = Transform.Find(lVar15,"Content",0)) == null))) throw; // [null/range check failed]
          uVar8 = Component.get_gameObject(lVar15);
          GlobalData.SortChild(uVar8);
          iVar12 = local_a4 + 1;
          local_a4 = iVar12;
          goto LAB_180cde3b0;
        }
        local_98 = "";
        if ((*(int64 *)(targetForce + 200) == 0) ||
           (lVar15 = Dictionary_2.get_Keys(*(int64 *)(targetForce + 200),DAT_181d95958)) == null)
        throw; // [null/range check failed]
        FUN_180ed4d30(&local_88,lVar15,DAT_181d9b7b0);
        local_68 = CONCAT44(uStack_84,local_88);
        uStack_60 = CONCAT44(uStack_7c,uStack_80);
        local_58 = local_78;
        while (cVar4 = FUN_1811d7770(&local_68,DAT_181d72a38), uVar3 = local_58, cVar4) {
          plVar6 = (int64 *)FUN_1800d60b0(DAT_181d80cc0,6);
          if (plVar6 == (int64 *)0) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          if ((lVar7 != null) &&
             (lVar15 = il2cpp_internal(lVar7,*(uint64 *)(*plVar6 + 64))) == null) {
            uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar8,0);
          }
          if ((int)plVar6[3] == 0) {
            uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar8,0);
          }
          plVar6[4] = lVar7;
          il2cpp_internal(plVar6 + 4,lVar7);
          cVar4 = FUN_1816fd990(lVar7,"",0);
          lVar15 = "\n";
          if (cVar4) {
            lVar15 = "";
          }
          if ((lVar15 != null) &&
             (lVar7 = il2cpp_internal(lVar15,*(uint64 *)(*plVar6 + 64))) == null) {
            uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar8,0);
          }
          FUN_180002fd0(plVar6,1,lVar15);
          lVar15 = FUN_18046c100(0);
          if (lVar15 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          lVar15 = GameDataController.GetSkillDataBase(lVar15,uVar3 & 0xffffffff,0);
          if (lVar15 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          lVar15 = KungfuSkillData.Name(lVar15,1,0);
          if ((lVar15 != null) &&
             (lVar7 = il2cpp_internal(lVar15,*(uint64 *)(*plVar6 + 64))) == null) {
            uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar8,0);
          }
          if (*(uint32 *)(plVar6 + 3) < 3) {
            uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar8,0);
          }
          plVar6[6] = lVar15;
          il2cpp_internal(plVar6 + 6,lVar15);
          if ((" " != 0) &&
             (lVar15 = il2cpp_internal(" ",*(uint64 *)(*plVar6 + 64))) == null) {
            uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar8,0);
          }
          lVar15 = " ";
          if (*(uint32 *)(plVar6 + 3) < 4) {
            uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar8,0);
          }
          plVar6[7] = " ";
          il2cpp_internal(plVar6 + 7,lVar15);
          lVar15 = *(int64 *)(pStatics + 0x628);
          if (*(int64 *)(targetForce + 200) == 0) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          uVar5 = FUN_181408420(*(int64 *)(targetForce + 200),uVar3 & 0xffffffff,DAT_181d958d0);
          if (lVar15 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          local_a0[0] = (float)FUN_1800d6780(lVar15,uVar5);
          local_a0[0] = local_a0[0] * 100.0;
          lVar15 = Single.ToString(local_a0,"+0");
          if ((lVar15 != null) &&
             (lVar7 = il2cpp_internal(lVar15,*(uint64 *)(*plVar6 + 64))) == null) {
            uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar8,0);
          }
          if (*(uint32 *)(plVar6 + 3) < 5) {
            uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar8,0);
          }
          plVar6[8] = lVar15;
          il2cpp_internal(plVar6 + 8,lVar15);
          if (("%" != 0) &&
             (lVar15 = il2cpp_internal("%",*(uint64 *)(*plVar6 + 64))) == null) {
            uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar8,0);
          }
          lVar15 = "%";
          if (*(uint32 *)(plVar6 + 3) < 6) {
            uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar8,0);
          }
          plVar6[9] = "%";
          il2cpp_internal(plVar6 + 9,lVar15);
          lVar7 = String.Concat(plVar6,0);
          local_98 = lVar7;
        }
        ZhSegment.Initialize(&local_68,DAT_181d729b8);
        if ((((this.bookStoreUI == null) ||
             (lVar15 = GameObject.get_transform(this.bookStoreUI,0)) == null) ||
            (lVar15 = Transform.Find(lVar15,"SpeAdd",0)) == null) ||
           (((lVar15 = Transform.Find(lVar15,"Viewport",0), lVar15 == null ||
             (lVar15 = Transform.Find(lVar15,"Content",0)) == null) ||
            (lVar15 = Transform.Find(lVar15,"Text",0)) == null))) throw; // [null/range check failed]
        uVar8 = Component.GetComponent(lVar15,DAT_181d6d8c0);
        LTLocalization.SetText(uVar8,lVar7,0);
        local_a8 = 0;
        while( true ) {
          iVar12 = local_a8;
          lVar15 = *(int64 *)(pStatics + 0x4f0);
          if (lVar15 == null) break;
          if (*(int *)(lVar15 + 24) <= iVar12) {
            return;
          }
          if ((this.bookStoreUI == null) ||
             (lVar15 = GameObject.get_transform(this.bookStoreUI,0)) == null) break;
          lVar15 = Transform.Find(lVar15,"Grid",0);
          uVar8 = Int32.ToString(&local_a8,0);
          if ((lVar15 == null) ||
             (((lVar15 = Transform.Find(lVar15,uVar8,0), lVar15 == null ||
               (lVar15 = Transform.Find(lVar15,"Label",0)) == null) ||
              (lVar15 = Transform.Find(lVar15,"Icon",0)) == null))) break;
          plVar6 = (int64 *)Component.GetComponent(lVar15,DAT_181d6bc40);
          lVar15 = FUN_18046c100(0);
          if (((lVar15 == null) || (*(int64 *)(lVar15 + 56) == 0)) ||
             ((lVar15 = FUN_180002f80(*(int64 *)(lVar15 + 56),local_a8,DAT_181d76758), lVar15 == null ||
              (plVar6 == (int64 *)0)))) break;
          local_88 = *(uint32 *)(lVar15 + 24);
          uStack_84 = *(uint32 *)(lVar15 + 28);
          uStack_80 = *(uint32 *)(lVar15 + 32);
          uStack_7c = *(uint32 *)(lVar15 + 36);
          (**(code **)(*plVar6 + 0x2a8))(plVar6,&local_88,*(uint64 *)(*plVar6 + 0x2b0));
          if ((this.bookStoreUI == null) ||
             (lVar15 = GameObject.get_transform(this.bookStoreUI,0)) == null) break;
          lVar15 = Transform.Find(lVar15,"Grid",0);
          uVar8 = Int32.ToString(&local_a8,0);
          if ((lVar15 == null) ||
             ((lVar15 = Transform.Find(lVar15,uVar8,0), lVar15 == null ||
              (lVar15 = Transform.Find(lVar15,"Label",0)) == null))) break;
          uVar8 = Component.GetComponent(lVar15,DAT_181d6d8c0);
          lVar15 = *(int64 *)(pStatics + 0x4f0);
          if (lVar15 == null) break;
          uVar9 = FUN_180002f80(lVar15,local_a8);
          uVar9 = String.Format("{0}武功",uVar9);
          LTLocalization.SetText(uVar8,uVar9);
          if ((this.bookStoreUI == null) ||
             (lVar15 = GameObject.get_transform(this.bookStoreUI,0)) == null) break;
          lVar15 = Transform.Find(lVar15,"Grid",0);
          uVar8 = Int32.ToString(&local_a8,0);
          if ((lVar15 == null) ||
             (((lVar15 = Transform.Find(lVar15,uVar8,0), lVar15 == null ||
               (lVar15 = Transform.Find(lVar15,"Label",0)) == null) ||
              (lVar15 = Transform.Find(lVar15,"Describe",0)) == null))) break;
          uVar8 = Component.GetComponent(lVar15,DAT_181d6d8c0);
          iVar12 = local_a8;
          lVar15 = FUN_18046c0a0(0);
          if (((lVar15 == null) || (*(int64 *)(lVar15 + 32) == 0)) ||
             (lVar15 = WorldData.Player(*(int64 *)(lVar15 + 32),0)) == null) break;
          lVar7 = "";
          if (*(int *)(lVar15 + 184) < iVar12) {
            lVar15 = *(int64 *)(pStatics + 0x3d0);
            if (lVar15 == null) break;
            uVar9 = FUN_180002f80(lVar15,local_a8);
            lVar7 = String.Format("({0}以上方可参阅)",uVar9);
          }
          LTLocalization.SetText(uVar8,lVar7);
          if ((this.bookStoreUI == null) ||
             (lVar15 = GameObject.get_transform(this.bookStoreUI,0)) == null) break;
          lVar15 = Transform.Find(lVar15,"Grid",0);
          uVar8 = Int32.ToString(&local_a8,0);
          if ((lVar15 == null) ||
             ((((lVar15 = Transform.Find(lVar15,uVar8,0), lVar15 == null ||
                (lVar15 = Transform.Find(lVar15,"Scroll View",0)) == null) ||
               (lVar15 = Component.GetComponent(lVar15,DAT_181d6c940)) == null) ||
              (*(int64 *)(lVar15 + 64) == 0)))) break;
          Scrollbar.set_value(*(int64 *)(lVar15 + 64),0);
          if ((this.bookStoreUI == null) ||
             (lVar15 = GameObject.get_transform(this.bookStoreUI,0)) == null) break;
          lVar15 = Transform.Find(lVar15,"Grid",0);
          uVar8 = Int32.ToString(&local_a8,0);
          if ((lVar15 == null) ||
             ((lVar15 = Transform.Find(lVar15,uVar8,0), lVar15 == null ||
              (lVar15 = Transform.Find(lVar15,"Lock",0)) == null))) break;
          lVar15 = Component.get_gameObject(lVar15,0);
          lVar7 = FUN_18046c0a0(0);
          if ((((lVar7 == null) || (*(int64 *)(lVar7 + 32) == 0)) ||
              (lVar7 = WorldData.Player(*(int64 *)(lVar7 + 32),0)) == null) || (lVar15 == null))
          break;
          GameObject.SetActive(lVar15);
          local_a8 = local_a8 + 1;
        }
    }

    // Token : 0x6000D2A
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
