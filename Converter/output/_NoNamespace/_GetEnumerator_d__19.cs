// ============================================================
// Type  : <GetEnumerator>d__19
// Token : 0x2000421
// ============================================================

public class <GetEnumerator>d__19
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4002061
    private int <>1__state;

    // Token: 0x4002062
    private T <>2__current;

    // Token: 0x4002063
    public CircularBuffer<T> <>4__this;

    // Token: 0x4002064
    private long <version>5__2;

    // Token: 0x4002065
    private int <i>5__3;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002588
    // RVA   : 0xCBCA80   Offset: 0xCBBE80   Length: 0x2E
    public void /*ctor*/(int <>1__state)
    {
        if (this != 0) {
          ZhSegment.Initialize(this,0);
          *(uint32 *)(this + 16) = <>1__state;
          return;
        }
    }

    // Token : 0x6002589
    // RVA   : 0x245810   Offset: 0x244C10   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x600258A
    // RVA   : 0xCBCAB0   Offset: 0xCBBEB0   Length: 0x11C
    private virtual bool MoveNext()
    {
        long lVar1;
        int iVar3;
        ulong uVar4;
        ulong uVar5;
        int iVar6;
        lVar1 = *(int64 *)(this + 32);
        if (*(int *)(this + 16) == 0) {
          *(uint32 *)(this + 16) = 0xffffffff;
          if (lVar1 == null) {
        LAB_180cbcbc7:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          iVar6 = 0;
          *(uint64 *)(this + 40) = *(uint64 *)(lVar1 + 32);
          *(uint32 *)(this + 48) = 0;
        }
        else {
          if (*(int *)(this + 16) != 1) {
            return false;
          }
          *(int *)(this + 48) = *(int *)(this + 48) + 1;
          iVar6 = *(int *)(this + 48);
          *(uint32 *)(this + 16) = 0xffffffff;
          if (lVar1 == null) goto LAB_180cbcbc7;
        }
        puVar2 = *(uint64 **)(*(int64 *)(*(int64 *)(param_2 + 24) + 192) + 8);
        iVar3 = (*(code *)*puVar2)(lVar1,puVar2);
        if (iVar3 <= iVar6) {
          return false;
        }
        if (*(int64 *)(this + 40) != *(int64 *)(lVar1 + 32)) {
          uVar4 = il2cpp_runtime_class_init(&DAT_181d819b0);
          uVar4 = il2cpp_internal(uVar4);
          uVar5 = il2cpp_internal(&"Collection changed");
          InvalidOperationException.ctor(uVar4,uVar5,0);
          uVar5 = il2cpp_runtime_class_init(&DAT_181d93b40);
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar4,uVar5);
        }
        puVar2 = (uint64 *)**(uint64 **)(*(int64 *)(param_2 + 24) + 192);
        uVar4 = (*(code *)*puVar2)(lVar1,*(uint32 *)(this + 48),puVar2);
        *(uint64 *)(this + 24) = uVar4;
        *(uint32 *)(this + 16) = 1;
        return true;
    }

    // Token : 0x600258B
    // RVA   : 0x20F140   Offset: 0x20E540   Length: 0x5
    private virtual T System.Collections.Generic.IEnumerator<T>.get_Current()
    {
        return *(uint64 *)(this + 24);
    }

    // Token : 0x600258C
    // RVA   : 0xCBCBD0   Offset: 0xCBBFD0   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181d8d528);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181d93bc0);
    }

    // Token : 0x600258D
    // RVA   : 0x20F140   Offset: 0x20E540   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return *(uint64 *)(this + 24);
    }

}
