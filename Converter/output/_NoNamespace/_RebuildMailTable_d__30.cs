// ============================================================
// Type  : <RebuildMailTable>d__30
// Token : 0x2000302
// ============================================================

public class <RebuildMailTable>d__30
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001820
    private int <>1__state;

    // Token: 0x4001821
    private object <>2__current;

    // Token: 0x4001822
    public MissionUIController <>4__this;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60018E3
    // RVA   : 0x219070   Offset: 0x217870   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x60018E4
    // RVA   : 0x245810   Offset: 0x244010   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x60018E5
    // RVA   : 0x8CF770   Offset: 0x8CDF70   Length: 0xE4
    private virtual bool MoveNext()
    {
        long lVar1;
        ulong uVar2;
        uint[] local_res8 = new uint[8];
        if (this.<>1__state == 0) {
          this.<>1__state = 0xffffffff;
          local_res8[0] = 1;
          uVar2 = il2cpp_value_box(DAT_181d5b2f8,local_res8);
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
          uVar2 = GameObject.GetComponent(lVar1,DAT_181da0b98);
          LayoutRebuilder.ForceRebuildLayoutImmediate(uVar2,0);
        }
        return false;
    }

    // Token : 0x60018E6
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x60018E7
    // RVA   : 0x8CF860   Offset: 0x8CE060   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181d682e8);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181d7ef68);
    }

    // Token : 0x60018E8
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
