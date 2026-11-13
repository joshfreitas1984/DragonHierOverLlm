// ============================================================
// Type  : <RebuildMailTable>d__39
// Token : 0x2000313
// ============================================================

public class <RebuildMailTable>d__39
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001988
    private int <>1__state;

    // Token: 0x4001989
    private object <>2__current;

    // Token: 0x400198A
    public MissionUIController <>4__this;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60019D6
    // RVA   : 0x608BA0   Offset: 0x6079A0   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x60019D7
    // RVA   : 0x51CF50   Offset: 0x51BD50   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x60019D8
    // RVA   : 0x611C00   Offset: 0x610A00   Length: 0xE4
    private virtual bool MoveNext()
    {
        long lVar1;
        ulong uVar2;
        uint[] local_res8 = new uint[8];
        if (this.<>1__state == 0) {
          this.<>1__state = 0xffffffff;
          local_res8[0] = 1;
          uVar2 = il2cpp_value_box(DAT_181e60808,local_res8);
          this.<>2__current = uVar2;
          this.<>1__state = 1;
          return true;
        }
        if (this.<>1__state == 1) {
          this.<>1__state = 0xffffffff;
          if ((this.<>4__this == 0) ||
             (lVar1 = *(int64 *)(this.<>4__this + 88)) == null) {
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          uVar2 = GameObject.GetComponent(lVar1,DAT_181e55c90);
          LayoutRebuilder.ForceRebuildLayoutImmediate(uVar2,0);
        }
        return false;
    }

    // Token : 0x60019D9
    // RVA   : 0x608B50   Offset: 0x607950   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x60019DA
    // RVA   : 0x611CF0   Offset: 0x610AF0   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181e6d8e8);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181e8b9a0);
    }

    // Token : 0x60019DB
    // RVA   : 0x608B50   Offset: 0x607950   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
