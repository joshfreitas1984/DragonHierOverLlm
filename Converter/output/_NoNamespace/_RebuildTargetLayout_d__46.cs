// ============================================================
// Type  : <RebuildTargetLayout>d__46
// Token : 0x2000336
// ============================================================

public class <RebuildTargetLayout>d__46
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001AE8
    private int <>1__state;

    // Token: 0x4001AE9
    private object <>2__current;

    // Token: 0x4001AEA
    public GameObject target;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60020AB
    // RVA   : 0x608BA0   Offset: 0x6079A0   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x60020AC
    // RVA   : 0x51CF50   Offset: 0x51BD50   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x60020AD
    // RVA   : 0x611D30   Offset: 0x610B30   Length: 0xDB
    private virtual bool MoveNext()
    {
        ulong uVar1;
        uint[] local_res8 = new uint[8];
        if (this.<>1__state == 0) {
          this.<>1__state = 0xffffffff;
          local_res8[0] = 1;
          uVar1 = il2cpp_value_box(DAT_181e60808,local_res8);
          this.<>2__current = uVar1;
          this.<>1__state = 1;
          return true;
        }
        if (this.<>1__state == 1) {
          this.<>1__state = 0xffffffff;
          if (this.target == null) {
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          uVar1 = GameObject.GetComponent(this.target,DAT_181e55c90);
          LayoutRebuilder.MarkLayoutForRebuild(uVar1,0);
        }
        return false;
    }

    // Token : 0x60020AE
    // RVA   : 0x608B50   Offset: 0x607950   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x60020AF
    // RVA   : 0x611E10   Offset: 0x610C10   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181e6d8e8);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181e8e488);
    }

    // Token : 0x60020B0
    // RVA   : 0x608B50   Offset: 0x607950   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
