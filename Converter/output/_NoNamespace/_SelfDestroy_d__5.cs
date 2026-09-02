// ============================================================
// Type  : <SelfDestroy>d__5
// Token : 0x2000306
// ============================================================

public class <SelfDestroy>d__5
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001840
    private int <>1__state;

    // Token: 0x4001841
    private object <>2__current;

    // Token: 0x4001842
    public float delay;

    // Token: 0x4001843
    public MoveTowardTarget <>4__this;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001905
    // RVA   : 0x219070   Offset: 0x217870   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x6001906
    // RVA   : 0x245810   Offset: 0x244010   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x6001907
    // RVA   : 0x8CFD70   Offset: 0x8CE570   Length: 0xEC
    private virtual bool MoveNext()
    {
        uint uVar1;
        ulong uVar2;
        if (this.<>1__state == 0) {
          uVar1 = this.delay;
          this.<>1__state = 0xffffffff;
          uVar2 = new WaitForSeconds(uVar1,0);
          this.<>2__current = uVar2;
          this.<>1__state = 1;
          return true;
        }
        if (this.<>1__state == 1) {
          this.<>1__state = 0xffffffff;
          if (this.<>4__this == 0) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          uVar2 = Component.get_gameObject(this.<>4__this,0);
          Object.Destroy(uVar2,0);
        }
        return false;
    }

    // Token : 0x6001908
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x6001909
    // RVA   : 0x8CFE60   Offset: 0x8CE660   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181d682e8);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181d7f468);
    }

    // Token : 0x600190A
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
