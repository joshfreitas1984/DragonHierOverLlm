// ============================================================
// Type  : <>c__DisplayClass300_0
// Token : 0x20002B1
// ============================================================

public class <>c__DisplayClass300_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001605
    public string unit;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001719
    // RVA   : 0x210B70   Offset: 0x20F370   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x600171A
    // RVA   : 0x8D6910   Offset: 0x8D5110   Length: 0x50A
    internal string <ConvertNumToChinese>b__1(List<List<int>> data)
    {
        ushort uVar1;
        int iVar3;
        uint uVar4;
        long lVar5;
        long lVar6;
        long lVar7;
        ulong uVar9;
        long lVar10;
        int iVar11;
        uint uVar12;
        long lVar13;
        int iVar14;
        lVar5 = il2cpp_internal(DAT_181d72ab0);
        FUN_180f58a90(lVar5,DAT_181d7cac0);
        iVar14 = 0;
        uVar12 = 0;
        if (data != null) {
          lVar13 = 32;
          for (; (int)uVar12 < (int)*(uint32 *)(data + 24); uVar12 = uVar12 + 1) {
            if (*(uint32 *)(data + 24) <= uVar12) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar10 = *(int64 *)(*(int64 *)(data + 16) + lVar13);
            lVar6 = new StringBuilder(0);
            iVar11 = 0;
            while( true ) {
              if (lVar10 == null) throw; // [null/range check failed]
              if (*(int *)(lVar10 + 24) <= iVar11) break;
              iVar3 = FUN_1800d6750(lVar10,iVar11);
              if (iVar3 == 0) {
                do {
                  iVar11 = iVar11 + 1;
                  if (*(int *)(lVar10 + 24) <= iVar11) break;
                  iVar3 = FUN_1800d6750(lVar10,iVar11);
                } while (iVar3 == 0);
                if (lVar6 == null) throw; // [null/range check failed]
                StringBuilder.Append(lVar6);
              }
              else {
                lVar7 = *(int64 *)(*(int64 *)(DAT_181d4ef00 + 184) + 208);
                uVar4 = FUN_1800d6750(lVar10,iVar11);
                if ((lVar7 == null) || (uVar1 = String.get_Chars(lVar7,uVar4), lVar6 == null))
                throw; // [null/range check failed]
                lVar7 = StringBuilder.Append(lVar6,uVar1);
                if ((this.unit == null) ||
                   (String.get_Chars(this.unit,
                                      (*(int *)(lVar10 + 24) - iVar11) + -1), lVar7 == null))
                throw; // [null/range check failed]
                StringBuilder.Append(lVar7);
                iVar11 = iVar11 + 1;
              }
            }
            if (lVar6 == null) throw; // [null/range check failed]
            iVar11 = FUN_18123bdd0(lVar6,0);
            sVar2 = StringBuilder.get_Chars(lVar6,iVar11 + -1,0);
            if ((sVar2 == -0x690a) && (iVar11 = FUN_18123bdd0(lVar6,0), 1 < iVar11)) {
        LAB_1808d6bc8:
              iVar11 = FUN_18123bdd0(lVar6,0);
              StringBuilder.Remove(lVar6,iVar11 + -1,1);
            }
            else {
              iVar11 = FUN_18123bdd0(lVar6,0);
              sVar2 = StringBuilder.get_Chars(lVar6,iVar11 + -1,0);
              if (sVar2 == 0x4e2a) goto LAB_1808d6bc8;
            }
            if ((((uVar12 == 0) && (iVar11 = FUN_18123bdd0(lVar6,0), 1 < iVar11)) &&
                (sVar2 = StringBuilder.get_Chars(lVar6,0,0), sVar2 == 0x4e00)) &&
               (sVar2 = StringBuilder.get_Chars(lVar6,1,0), sVar2 == 0x5341)) {
              StringBuilder.Remove(lVar6,0,1);
            }
            if (lVar5 == null) throw; // [null/range check failed]
            FUN_181827900(lVar5);
            lVar13 = lVar13 + 8;
          }
          plVar8 = (int64 *)il2cpp_internal(DAT_181d824f0);
          StringBuilder.ctor(plVar8,0);
          if (lVar5 != null) {
            while (iVar11 = *(int *)(lVar5 + 24), iVar14 < iVar11) {
              if (iVar11 == 1) {
        LAB_1808d6dba:
                uVar9 = FUN_180002f80(lVar5,iVar14,DAT_181d7cc40);
                if (plVar8 == (int64 *)0) throw; // [null/range check failed]
                StringBuilder.Append(plVar8,uVar9,0);
        LAB_1808d6dd2:
                iVar14 = iVar14 + 1;
              }
              else {
                if (iVar14 == iVar11 + -1) {
                  lVar13 = FUN_180002f80(lVar5,iVar14,DAT_181d7cc40);
                  lVar10 = FUN_180002f80(lVar5,iVar14,DAT_181d7cc40);
                  if ((lVar10 != null) && (iVar11 = FUN_18123bdd0(lVar10,0), lVar13 != null)) {
                    sVar2 = StringBuilder.get_Chars(lVar13,iVar11 + -1,0);
                    if (sVar2 != -0x690a) goto LAB_1808d6dba;
                    goto LAB_1808d6dd2;
                  }
                  throw; // [null/range check failed]
                }
                lVar13 = FUN_180002f80(lVar5,iVar14);
                if (lVar13 == null) throw; // [null/range check failed]
                sVar2 = StringBuilder.get_Chars(lVar13,0,0);
                if (sVar2 == -0x690a) goto LAB_1808d6dd2;
                uVar9 = FUN_180002f80(lVar5,iVar14,DAT_181d7cc40);
                if (plVar8 == (int64 *)0) throw; // [null/range check failed]
                lVar10 = StringBuilder.Append(plVar8,uVar9,0);
                lVar13 = this.unit;
                if (lVar13 == null) throw; // [null/range check failed]
                iVar11 = String.IndexOf(lVar13,0x5343,0);
                uVar1 = String.get_Chars(lVar13,iVar11 + -1 + (*(int *)(lVar5 + 24) - iVar14),0);
                if (lVar10 == null) throw; // [null/range check failed]
                StringBuilder.Append(lVar10,uVar1,0);
                iVar14 = iVar14 + 1;
              }
            }
            if (plVar8 != (int64 *)0) {
                          // WARNING: Could not recover jumptable at 0x0001808d6e0e. Too many branches
                          // WARNING: Treating indirect jump as call
              (**(code **)(*plVar8 + 0x168))(plVar8,*(uint64 *)(*plVar8 + 0x170));
              return;
            }
          }
        }
    }

}
