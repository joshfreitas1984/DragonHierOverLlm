// ============================================================
// Type  : <AnimateVertexColors>d__3
// Token : 0x200041E
// ============================================================

public class <AnimateVertexColors>d__3
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4002098
    private int <>1__state;

    // Token: 0x4002099
    private object <>2__current;

    // Token: 0x400209A
    public VertexColorCycler <>4__this;

    // Token: 0x400209B
    private TMP_TextInfo <textInfo>5__2;

    // Token: 0x400209C
    private int <currentCharacter>5__3;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60025CD
    // RVA   : 0x608BA0   Offset: 0x6079A0   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x60025CE
    // RVA   : 0x51CF50   Offset: 0x51BD50   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x60025CF
    // RVA   : 0x1784660   Offset: 0x1783460   Length: 0x36A
    private virtual bool MoveNext()
    {
        int iVar1;
        uint uVar2;
        uint uVar3;
        long lVar4;
        long lVar5;
        long lVar6;
        byte uVar8;
        byte uVar9;
        byte uVar10;
        ulong uVar12;
        uint uVar13;
        long lVar14;
        long lVar15;
        uint[] local_res8 = new uint[2];
        uint local_38;
        uint uStack_34;
        uint uStack_30;
        uint32 uStack_2c;
        iVar1 = this.<>1__state;
        lVar4 = this.<>4__this;
        local_res8[0] = 0;
        if (iVar1 == 0) {
          this.<>1__state = 0xffffffff;
          if ((lVar4 == null) || (plVar7 = *(int64 **)(lVar4 + 24), plVar7 == (int64 *)0))
          throw; // [null/range check failed]
          (**(code **)(*plVar7 + 0x7d8))(plVar7,0,0,*(uint64 *)(*plVar7 + 0x7e0));
          if (*(int64 *)(lVar4 + 24) == 0) throw; // [null/range check failed]
          this.<textInfo>5__2 = *(uint64 *)(*(int64 *)(lVar4 + 24) + 0x368);
          this.<currentCharacter>5__3 = 0;
          plVar7 = *(int64 **)(lVar4 + 24);
          if (plVar7 == (int64 *)0) throw; // [null/range check failed]
          puVar11 = (uint32 *)
                    (**(code **)(*plVar7 + 0x298))(&local_38,plVar7,*(uint64 *)(*plVar7 + 0x2a0));
          local_38 = *puVar11;
          uStack_34 = puVar11[1];
          uStack_30 = puVar11[2];
          uStack_2c = puVar11[3];
          local_res8[0] = Color32.op_Implicit(&local_38,0);
        }
        else {
          if ((iVar1 != 1) && (iVar1 != 2)) {
            return false;
          }
          this.<>1__state = 0xffffffff;
        }
        lVar5 = this.<textInfo>5__2;
        if (lVar5 != null) {
          iVar1 = *(int *)(lVar5 + 24);
          if (iVar1 == 0) {
            uVar12 = new WaitForSeconds(0x3e800000,0);
            this.<>2__current = uVar12;
            this.<>1__state = 1;
            return true;
          }
          lVar6 = *(int64 *)(lVar5 + 56);
          if (lVar6 != null) {
            uVar13 = this.<currentCharacter>5__3;
            if (*(uint32 *)(lVar6 + 24) <= uVar13) {
              uVar12 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar12,0);
            }
            lVar5 = *(int64 *)(lVar5 + 96);
            if (lVar5 != null) {
              lVar14 = (int64)(int)uVar13 * 0x178;
              uVar2 = *(uint32 *)(lVar14 + 88 + lVar6);
              if (*(uint32 *)(lVar5 + 24) <= uVar2) {
                uVar12 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1801e02d0(uVar12,0);
              }
              uVar3 = *(uint32 *)(lVar14 + 108 + lVar6);
              lVar15 = (int64)(int)uVar3;
              lVar5 = *(int64 *)(lVar5 + 88 + (int64)(int)uVar2 * 80);
              if (*(char *)(lVar14 + 0x194 + lVar6) == false) {
        LAB_1817848c7:
                this.<currentCharacter>5__3 = (int)(uVar13 + 1) % iVar1;
                uVar12 = new WaitForSeconds(0x3d4ccccd,0);
                this.<>2__current = uVar12;
                this.<>1__state = 2;
                return true;
              }
              uVar8 = FUN_180af1860(0,255,0);
              uVar9 = FUN_180af1860(0,255,0);
              uVar10 = FUN_180af1860(0,255,0);
              Color32.ctor(local_res8,uVar8,uVar9,uVar10,255,0);
              if (lVar5 != null) {
                if (*(uint32 *)(lVar5 + 24) <= uVar3) {
                  uVar12 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1801e02d0(uVar12,0);
                }
                *(uint32 *)(lVar5 + 32 + lVar15 * 4) = local_res8[0];
                if (*(uint32 *)(lVar5 + 24) <= (uint32)(lVar15 + 1)) {
                  uVar12 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1801e02d0(uVar12,0);
                }
                *(uint32 *)(lVar5 + 32 + (lVar15 + 1) * 4) = local_res8[0];
                if (*(uint32 *)(lVar5 + 24) <= (uint32)(lVar15 + 2)) {
                  uVar12 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1801e02d0(uVar12,0);
                }
                *(uint32 *)(lVar5 + 32 + (lVar15 + 2) * 4) = local_res8[0];
                if (*(uint32 *)(lVar5 + 24) <= (uint32)(lVar15 + 3)) {
                  uVar12 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1801e02d0(uVar12,0);
                }
                *(uint32 *)(lVar5 + 32 + (lVar15 + 3) * 4) = local_res8[0];
                if ((lVar4 != null) && (plVar7 = *(int64 **)(lVar4 + 24), plVar7 != (int64 *)0)) {
                  (**(code **)(*plVar7 + 0x7f8))(plVar7,16,*(uint64 *)(*plVar7 + 0x800));
                  uVar13 = this.<currentCharacter>5__3;
                  goto LAB_1817848c7;
                }
              }
            }
          }
        }
    }

    // Token : 0x60025D0
    // RVA   : 0x608B50   Offset: 0x607950   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x60025D1
    // RVA   : 0x17849D0   Offset: 0x17837D0   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181e6d8e8);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181e9c188);
    }

    // Token : 0x60025D2
    // RVA   : 0x608B50   Offset: 0x607950   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
