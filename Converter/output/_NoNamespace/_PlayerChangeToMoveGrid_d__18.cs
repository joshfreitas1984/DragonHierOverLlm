// ============================================================
// Type  : <PlayerChangeToMoveGrid>d__18
// Token : 0x200037D
// ============================================================

public class <PlayerChangeToMoveGrid>d__18
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001C8D
    private int <>1__state;

    // Token: 0x4001C8E
    private object <>2__current;

    // Token: 0x4001C8F
    public float delta;

    // Token: 0x4001C90
    public GameObject target;

    // Token: 0x4001C91
    public StudyDodgePlayer <>4__this;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600223A
    // RVA   : 0x219070   Offset: 0x218470   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x600223B
    // RVA   : 0x245810   Offset: 0x244C10   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x600223C
    // RVA   : 0x8F15A0   Offset: 0x8F09A0   Length: 0x106
    private virtual bool MoveNext()
    {
        uint uVar1;
        long lVar2;
        bool cVar3;
        ulong uVar4;
        lVar2 = this.<>4__this;
        if (this.<>1__state == 0) {
          uVar1 = this.delta;
          this.<>1__state = 0xffffffff;
          uVar4 = new WaitForSecondsRealtime(uVar1,0);
          this.<>2__current = uVar4;
          this.<>1__state = 1;
          return true;
        }
        if (this.<>1__state == 1) {
          uVar4 = this.target;
          this.<>1__state = 0xffffffff;
          cVar3 = Object.op_Inequality(uVar4,0,0);
          if (cVar3) {
            if (lVar2 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            *(uint64 *)(lVar2 + 24) = this.target;
          }
        }
        return false;
    }

    // Token : 0x600223D
    // RVA   : 0x20F140   Offset: 0x20E540   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x600223E
    // RVA   : 0x8F16B0   Offset: 0x8F0AB0   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181d8d510);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181db48f8);
    }

    // Token : 0x600223F
    // RVA   : 0x20F140   Offset: 0x20E540   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
