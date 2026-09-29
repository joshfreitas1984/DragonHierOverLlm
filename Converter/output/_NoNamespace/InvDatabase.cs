// ============================================================
// Type  : InvDatabase
// Token : 0x200000E
// ============================================================

public class InvDatabase
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000057
    private static InvDatabase[] mList;

    // Token: 0x4000058
    private static bool mIsDirty;

    // Token: 0x4000059
    public int databaseID;

    // Token: 0x400005A
    public List<InvBaseItem> items;

    // Token: 0x400005B
    public object iconAtlas;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600003F
    // RVA   : 0xC9C430   Offset: 0xC9B830   Length: 0x119
    public static InvDatabase[] get_list()
    {
        ulong uVar2;
        if (InvDatabase.mIsDirty) {
          InvDatabase.mIsDirty = 0;
          uVar2 = NGUITools.FindActive(DAT_181d8ef38);
          puVar1 = *(uint64 **)(DAT_181d81530 + 184);
          *puVar1 = uVar2;
          il2cpp_internal(puVar1,uVar2);
        }
        if (((*(byte *)(DAT_181d81530 + 0x133) & 4) != 0) && (*(int *)(DAT_181d81530 + 224) == 0)) {
          il2cpp_runtime_class_init();
          return **(uint64 **)(DAT_181d81530 + 184);
        }
        return **(uint64 **)(DAT_181d81530 + 184);
    }

    // Token : 0x6000040
    // RVA   : 0xC9C310   Offset: 0xC9B710   Length: 0x58
    private void OnEnable()
    {
        *(uint8 *)(*(int64 *)(DAT_181d81530 + 184) + 8) = 1;
    }

    // Token : 0x6000041
    // RVA   : 0xC9C2B0   Offset: 0xC9B6B0   Length: 0x58
    private void OnDisable()
    {
        *(uint8 *)(*(int64 *)(DAT_181d81530 + 184) + 8) = 1;
    }

    // Token : 0x6000042
    // RVA   : 0xC9C1E0   Offset: 0xC9B5E0   Length: 0xC1
    private InvBaseItem GetItem(int id16)
    {
        long lVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        long lVar5;
        uVar3 = 0;
        if (this.items == null) {
        LAB_180c9c29c:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        lVar2 = (int64)this.items.Count;
        if (0 < lVar2) {
          lVar5 = 32;
          uVar4 = uVar3;
          do {
            lVar1 = this.items;
            if (lVar1 == null) goto LAB_180c9c29c;
            if (lVar1.Count <= (uint32)uVar4) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar1 = *(int64 *)(lVar5 + lVar1._items);
            if (lVar1 == null) goto LAB_180c9c29c;
            if (lVar1._items == id16) {
              return lVar1;
            }
            uVar4 = (uint64)((uint32)uVar4 + 1);
            uVar3 = uVar3 + 1;
            lVar5 = lVar5 + 8;
          } while ((int64)uVar3 < lVar2);
        }
        return 0;
    }

    // Token : 0x6000043
    // RVA   : 0xC9C110   Offset: 0xC9B510   Length: 0xCE
    private static InvDatabase GetDatabase(int dbID)
    {
        int iVar1;
        long lVar2;
        ulong uVar3;
        uint uVar4;
        uVar4 = 0;
        lVar2 = InvDatabase.get_list(0);
        if (lVar2 == null) {
        LAB_180c9c1c9:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        iVar1 = *(int *)(lVar2 + 24);
        if (0 < iVar1) {
          do {
            lVar2 = InvDatabase.get_list(0);
            if (lVar2 == null) goto LAB_180c9c1c9;
            if (*(uint32 *)(lVar2 + 24) <= uVar4) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            lVar2 = lVar2[uVar4];
            if (lVar2 == null) goto LAB_180c9c1c9;
            if (*(int *)(lVar2 + 24) == dbID) {
              return lVar2;
            }
            uVar4 = uVar4 + 1;
          } while ((int)uVar4 < iVar1);
        }
        return 0;
    }

    // Token : 0x6000044
    // RVA   : 0xC9BC40   Offset: 0xC9B040   Length: 0x228
    public static InvBaseItem FindByID(int id32)
    {
        int iVar1;
        long lVar2;
        bool cVar3;
        long lVar4;
        ulong uVar5;
        uint uVar6;
        long lVar7;
        long lVar8;
        long lVar9;
        uVar6 = 0;
        lVar4 = InvDatabase.get_list(0);
        if (lVar4 != null) {
          iVar1 = *(int *)(lVar4 + 24);
          if (0 < iVar1) {
            do {
              lVar4 = InvDatabase.get_list(0);
              if (lVar4 == null) throw; // [null/range check failed]
              if (*(uint32 *)(lVar4 + 24) <= uVar6) {
                uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar5,0);
              }
              lVar4 = lVar4[uVar6];
              if (lVar4 == null) throw; // [null/range check failed]
              if (*(int *)(lVar4 + 24) != (int)id32 >> 16)
              {
                uVar6 = uVar6 + 1;
                } while ((int)uVar6 < iVar1);
                }
                lVar4 = 0;
              }
          cVar3 = Object.op_Inequality(lVar4,0,0);
          if (!cVar3) {
            return 0;
          }
          if (lVar4 != null) {
            uVar6 = 0;
            if (*(int64 *)(lVar4 + 32) != 0) {
              lVar9 = (int64)*(int *)(*(int64 *)(lVar4 + 32) + 24);
              if (0 < lVar9) {
                lVar7 = 0;
                lVar8 = 32;
                do {
                  lVar2 = *(int64 *)(lVar4 + 32);
                  if (lVar2 == null) throw; // [null/range check failed]
                  if (*(uint32 *)(lVar2 + 24) <= uVar6) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  lVar2 = *(int64 *)(lVar8 + *(int64 *)(lVar2 + 16));
                  if (lVar2 == null) throw; // [null/range check failed]
                  if (*(uint32 *)(lVar2 + 16) == (id32 & 0xffff)) {
                    return lVar2;
                  }
                  uVar6 = uVar6 + 1;
                  lVar7 = lVar7 + 1;
                  lVar8 = lVar8 + 8;
                } while (lVar7 < lVar9);
              }
              return 0;
            }
          }
        }
    }

    // Token : 0x6000045
    // RVA   : 0xC9BE70   Offset: 0xC9B270   Length: 0x179
    public static InvBaseItem FindByName(string exact)
    {
        int iVar1;
        int iVar2;
        bool cVar3;
        long lVar4;
        long lVar5;
        ulong uVar6;
        int iVar7;
        uint uVar8;
        uVar8 = 0;
        lVar4 = InvDatabase.get_list(0);
        if (lVar4 == null) {
        LAB_180c9bfd4:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        iVar1 = *(int *)(lVar4 + 24);
        if (0 < iVar1) {
          do {
            lVar4 = InvDatabase.get_list(0);
            if (lVar4 == null) goto LAB_180c9bfd4;
            if (*(uint32 *)(lVar4 + 24) <= uVar8) {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar6,0);
            }
            iVar7 = 0;
            lVar4 = lVar4[uVar8];
            if ((lVar4 == null) || (*(int64 *)(lVar4 + 32) == 0)) goto LAB_180c9bfd4;
            iVar2 = *(int *)(*(int64 *)(lVar4 + 32) + 24);
            if (0 < iVar2) {
              do {
                if ((*(int64 *)(lVar4 + 32) == 0) ||
                   (lVar5 = FUN_180002f80(*(int64 *)(lVar4 + 32),iVar7,DAT_181d90430)) == null)
                goto LAB_180c9bfd4;
                cVar3 = FUN_18171eb50(*(uint64 *)(lVar5 + 24),exact,0);
                if (cVar3) {
                  return lVar5;
                }
                iVar7 = iVar7 + 1;
              } while (iVar7 < iVar2);
            }
            uVar8 = uVar8 + 1;
          } while ((int)uVar8 < iVar1);
        }
        return 0;
    }

    // Token : 0x6000046
    // RVA   : 0xC9BFF0   Offset: 0xC9B3F0   Length: 0x11D
    public static int FindItemID(InvBaseItem item)
    {
        int iVar1;
        bool cVar2;
        long lVar3;
        ulong uVar4;
        uint uVar5;
        uVar5 = 0;
        lVar3 = InvDatabase.get_list(0);
        if (lVar3 == null) {
        LAB_180c9c0f8:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        iVar1 = *(int *)(lVar3 + 24);
        if (0 < iVar1) {
          do {
            lVar3 = InvDatabase.get_list(0);
            if (lVar3 == null) goto LAB_180c9c0f8;
            if (*(uint32 *)(lVar3 + 24) <= uVar5) {
              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar4,0);
            }
            lVar3 = lVar3[uVar5];
            if ((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) goto LAB_180c9c0f8;
            cVar2 = FUN_18181ea10(*(int64 *)(lVar3 + 32),item,DAT_181d90330);
            if (cVar2) {
              if (item != null) {
                return *(int *)(lVar3 + 24) << 16 | *(uint32 *)(item + 16);
              }
              goto LAB_180c9c0f8;
            }
            uVar5 = uVar5 + 1;
          } while ((int)uVar5 < iVar1);
        }
        return 0xffffffff;
    }

    // Token : 0x6000047
    // RVA   : 0xC9C3B0   Offset: 0xC9B7B0   Length: 0x76
    public void /*ctor*/()
    {
        ulong uVar1;
        uVar1 = il2cpp_internal(DAT_181d93f68);
        FUN_181330100(uVar1,DAT_181d902b0);
        this.items = uVar1;
        FUN_18044ef50(this,0);
    }

    // Token : 0x6000048
    // RVA   : 0xC9C370   Offset: 0xC9B770   Length: 0x37
    private static void /*cctor*/()
    {
        *(uint8 *)(*(int64 *)(DAT_181d81530 + 184) + 8) = 1;
    }

}
