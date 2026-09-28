// ============================================================
// Type  : <RefreshBuffGridPos>d__40
// Token : 0x20002C3
// ============================================================

public class <RefreshBuffGridPos>d__40
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400170C
    private int <>1__state;

    // Token: 0x400170D
    private object <>2__current;

    // Token: 0x400170E
    public GameObject targetBuffGrid;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60017B1
    // RVA   : 0x219070   Offset: 0x218470   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x60017B2
    // RVA   : 0x245810   Offset: 0x244C10   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x60017B3
    // RVA   : 0x932EC0   Offset: 0x9322C0   Length: 0xDB
    private virtual bool MoveNext()
    {
        ulong uVar1;
        uint[] local_res8 = new uint[8];
        if (this.<>1__state == 0) {
          this.<>1__state = 0xffffffff;
          local_res8[0] = 1;
          uVar1 = il2cpp_value_box(DAT_181d80418,local_res8);
          this.<>2__current = uVar1;
          this.<>1__state = 1;
          return true;
        }
        if (this.<>1__state == 1) {
          this.<>1__state = 0xffffffff;
          if (this.targetBuffGrid == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          uVar1 = GameObject.GetComponent(this.targetBuffGrid,DAT_181d72bc8);
          LayoutRebuilder.MarkLayoutForRebuild(uVar1,0);
        }
        return false;
    }

    // Token : 0x60017B4
    // RVA   : 0x20F140   Offset: 0x20E540   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x60017B5
    // RVA   : 0x932FA0   Offset: 0x9323A0   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181d8d510);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181da57c8);
    }

    // Token : 0x60017B6
    // RVA   : 0x20F140   Offset: 0x20E540   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
