// ============================================================
// Type  : <RebuildTargetLayout>d__46
// Token : 0x2000325
// ============================================================

public class <RebuildTargetLayout>d__46
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001976
    private int <>1__state;

    // Token: 0x4001977
    private object <>2__current;

    // Token: 0x4001978
    public GameObject target;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001F8C
    // RVA   : 0x219070   Offset: 0x217870   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x6001F8D
    // RVA   : 0x245810   Offset: 0x244010   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x6001F8E
    // RVA   : 0x8CF8A0   Offset: 0x8CE0A0   Length: 0xDB
    private virtual bool MoveNext()
    {
        ulong uVar1;
        uint[] local_res8 = new uint[8];
        if (this.<>1__state == 0) {
          this.<>1__state = 0xffffffff;
          local_res8[0] = 1;
          uVar1 = il2cpp_value_box(DAT_181d5b2f8,local_res8);
          this.<>2__current = uVar1;
          this.<>1__state = 1;
          return true;
        }
        if (this.<>1__state == 1) {
          this.<>1__state = 0xffffffff;
          if (this.target == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          uVar1 = GameObject.GetComponent(this.target,DAT_181da0b98);
          LayoutRebuilder.MarkLayoutForRebuild(uVar1,0);
        }
        return false;
    }

    // Token : 0x6001F8F
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x6001F90
    // RVA   : 0x8CF980   Offset: 0x8CE180   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181d682e8);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181d81a28);
    }

    // Token : 0x6001F91
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
