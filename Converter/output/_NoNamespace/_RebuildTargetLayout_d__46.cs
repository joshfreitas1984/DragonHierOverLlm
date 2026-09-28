// ============================================================
// Type  : <RebuildTargetLayout>d__46
// Token : 0x200032C
// ============================================================

public class <RebuildTargetLayout>d__46
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001A6D
    private int <>1__state;

    // Token: 0x4001A6E
    private object <>2__current;

    // Token: 0x4001A6F
    public GameObject target;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600200C
    // RVA   : 0x219070   Offset: 0x218470   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x600200D
    // RVA   : 0x245810   Offset: 0x244C10   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x600200E
    // RVA   : 0x8F1820   Offset: 0x8F0C20   Length: 0xDB
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
          if (this.target == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          uVar1 = GameObject.GetComponent(this.target,DAT_181d72bc8);
          LayoutRebuilder.MarkLayoutForRebuild(uVar1,0);
        }
        return false;
    }

    // Token : 0x600200F
    // RVA   : 0x20F140   Offset: 0x20E540   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x6002010
    // RVA   : 0x8F1900   Offset: 0x8F0D00   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181d8d510);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181daa948);
    }

    // Token : 0x6002011
    // RVA   : 0x20F140   Offset: 0x20E540   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
