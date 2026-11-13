// ============================================================
// Type  : <SelfDestroy>d__5
// Token : 0x2000317
// ============================================================

public class <SelfDestroy>d__5
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40019AB
    private int <>1__state;

    // Token: 0x40019AC
    private object <>2__current;

    // Token: 0x40019AD
    public float delay;

    // Token: 0x40019AE
    public MoveTowardTarget <>4__this;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60019FA
    // RVA   : 0x608BA0   Offset: 0x6079A0   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x60019FB
    // RVA   : 0x51CF50   Offset: 0x51BD50   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x60019FC
    // RVA   : 0x612620   Offset: 0x611420   Length: 0xEC
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
            FUN_1801e0300();
          }
          uVar2 = Component.get_gameObject(this.<>4__this,0);
          Object.Destroy(uVar2,0);
        }
        return false;
    }

    // Token : 0x60019FD
    // RVA   : 0x608B50   Offset: 0x607950   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x60019FE
    // RVA   : 0x612710   Offset: 0x611510   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181e6d8e8);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181e8bea0);
    }

    // Token : 0x60019FF
    // RVA   : 0x608B50   Offset: 0x607950   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
