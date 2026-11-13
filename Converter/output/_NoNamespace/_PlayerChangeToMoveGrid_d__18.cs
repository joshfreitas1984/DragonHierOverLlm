// ============================================================
// Type  : <PlayerChangeToMoveGrid>d__18
// Token : 0x200038A
// ============================================================

public class <PlayerChangeToMoveGrid>d__18
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001D20
    private int <>1__state;

    // Token: 0x4001D21
    private object <>2__current;

    // Token: 0x4001D22
    public float delta;

    // Token: 0x4001D23
    public GameObject target;

    // Token: 0x4001D24
    public StudyDodgePlayer <>4__this;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60022E4
    // RVA   : 0x608BA0   Offset: 0x6079A0   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x60022E5
    // RVA   : 0x51CF50   Offset: 0x51BD50   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x60022E6
    // RVA   : 0x611AB0   Offset: 0x6108B0   Length: 0x106
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
              FUN_1801e0300();
            }
            *(uint64 *)(lVar2 + 24) = this.target;
          }
        }
        return false;
    }

    // Token : 0x60022E7
    // RVA   : 0x608B50   Offset: 0x607950   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x60022E8
    // RVA   : 0x611BC0   Offset: 0x6109C0   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181e6d8e8);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181e98848);
    }

    // Token : 0x60022E9
    // RVA   : 0x608B50   Offset: 0x607950   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
