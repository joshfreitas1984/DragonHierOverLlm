// ============================================================
// Type  : <GetEnumerator>d__2
// Token : 0x200007B
// ============================================================

public class <GetEnumerator>d__2
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40002EB
    private int <>1__state;

    // Token: 0x40002EC
    private T <>2__current;

    // Token: 0x40002ED
    public BetterList<T> <>4__this;

    // Token: 0x40002EE
    private int <i>5__2;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60002E8
    // RVA   : 0xCCE020   Offset: 0xCCC820   Length: 0x2E
    public void /*ctor*/(int <>1__state)
    {
        if (this != 0) {
          ZhSegment.Initialize(this,0);
          *(uint32 *)(this + 16) = <>1__state;
          return;
        }
    }

    // Token : 0x60002E9
    // RVA   : 0x245810   Offset: 0x244010   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x60002EA
    // RVA   : 0xCCE400   Offset: 0xCCCC00   Length: 0x8F
    private virtual bool MoveNext()
    {
        ulong uVar2;
        long lVar3;
        ulong uVar4;
        ulong uVar5;
        uint uVar6;
        uVar2 = *(uint64 *)(this + 40);
        if (*(int *)(this + 16) == 0) {
          *(uint32 *)(this + 16) = 0xffffffff;
          if (uVar2 == 0) throw; // [null/range check failed]
          if (*(int64 *)(uVar2 + 16) == 0) goto LAB_180cce473;
          *(uint32 *)(this + 48) = 0;
          uVar6 = 0;
        }
        else {
          if (*(int *)(this + 16) != 1) goto LAB_180cce473;
          *(int *)(this + 48) = *(int *)(this + 48) + 1;
          uVar6 = *(uint32 *)(this + 48);
          *(uint32 *)(this + 16) = 0xffffffff;
          if (uVar2 == 0) throw; // [null/range check failed]
        }
        if (*(int *)(uVar2 + 24) <= (int)uVar6) {
        LAB_180cce473:
          return uVar2 & 0xffffffffffffff00;
        }
        lVar3 = *(int64 *)(uVar2 + 16);
        if (lVar3 != null) {
          if (uVar6 < *(uint32 *)(lVar3 + 24)) {
            puVar1 = (uint64 *)(lVar3 + ((int64)(int)uVar6 + 2) * 16);
            uVar5 = *puVar1;
            uVar4 = puVar1[1];
            *(uint32 *)(this + 16) = 1;
            *(uint64 *)(this + 20) = uVar5;
            *(uint64 *)(this + 28) = uVar4;
            return CONCAT71((int7)((uint64)(((int64)(int)uVar6 + 2) * 2) >> 8),1);
          }
          uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar5,0);
        }
    }

    // Token : 0x60002EB
    // RVA   : 0xCCE920   Offset: 0xCCD120   Length: 0xB
    private virtual T System.Collections.Generic.IEnumerator<T>.get_Current()
    {
        uint64 * FUN_180cce920(uint64 *this,int64 param_2)
        {
        uint64 uVar1;
        uVar1 = *(uint64 *)(param_2 + 28);
        *this = *(uint64 *)(param_2 + 20);
        this[1] = uVar1;
        return this;
    }

    // Token : 0x60002EC
    // RVA   : 0xCCEAD0   Offset: 0xCCD2D0   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181d682e8);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181d6e888);
    }

    // Token : 0x60002ED
    // RVA   : 0xCCEC70   Offset: 0xCCD470   Length: 0x41
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        void GetEnumerator_d__2.System_Collections_IEnumerator_get_Current
                     (int64 this,int64 param_2)
        {
        int64 lVar1;
        uint32 local_18;
        uint32 uStack_14;
        uint32 uStack_10;
        uint32 uStack_c;
        local_18 = *(uint32 *)(this + 20);
        uStack_14 = *(uint32 *)(this + 24);
        uStack_10 = *(uint32 *)(this + 28);
        uStack_c = *(uint32 *)(this + 32);
        lVar1 = **(int64 **)(*(int64 *)(param_2 + 24) + 192);
        if ((*(byte *)(lVar1 + 0x132) & 1) == 0) {
          FUN_18009a510(lVar1);
        }
        il2cpp_value_box(lVar1,&local_18);
    }

}
