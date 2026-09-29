// ============================================================
// Type  : <RebuildMailTable>d__30
// Token : 0x2000309
// ============================================================

public class <RebuildMailTable>d__30
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400190F
    private int <>1__state;

    // Token: 0x4001910
    private object <>2__current;

    // Token: 0x4001911
    public MissionUIController <>4__this;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001940
    // RVA   : 0x219070   Offset: 0x218470   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x6001941
    // RVA   : 0x245810   Offset: 0x244C10   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x6001942
    // RVA   : 0x924570   Offset: 0x923970   Length: 0xE4
    private virtual bool MoveNext()
    {
        long lVar1;
        ulong uVar2;
        uint[] local_res8 = new uint[8];
        if (this.<>1__state == 0) {
          this.<>1__state = 0xffffffff;
          local_res8[0] = 1;
          uVar2 = il2cpp_value_box(DAT_181d80430,local_res8);
          this.<>2__current = uVar2;
          this.<>1__state = 1;
          return true;
        }
        if (this.<>1__state == 1) {
          this.<>1__state = 0xffffffff;
          if ((this.<>4__this == 0) ||
             (lVar1 = *(int64 *)(this.<>4__this + 88)) == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          uVar2 = GameObject.GetComponent(lVar1,DAT_181d72bc8);
          LayoutRebuilder.ForceRebuildLayoutImmediate(uVar2,0);
        }
        return false;
    }

    // Token : 0x6001943
    // RVA   : 0x20F140   Offset: 0x20E540   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x6001944
    // RVA   : 0x924660   Offset: 0x923A60   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181d8d528);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181da7fe0);
    }

    // Token : 0x6001945
    // RVA   : 0x20F140   Offset: 0x20E540   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
