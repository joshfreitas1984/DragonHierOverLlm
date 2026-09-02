// ============================================================
// Type  : <PlayerChangeToMoveGrid>d__15
// Token : 0x2000376
// ============================================================

public class <PlayerChangeToMoveGrid>d__15
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001B89
    private int <>1__state;

    // Token: 0x4001B8A
    private object <>2__current;

    // Token: 0x4001B8B
    public float delta;

    // Token: 0x4001B8C
    public StudyDodgePlayer <>4__this;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60021B8
    // RVA   : 0x219070   Offset: 0x217870   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x60021B9
    // RVA   : 0x245810   Offset: 0x244010   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x60021BA
    // RVA   : 0xB13090   Offset: 0xB11890   Length: 0xB9
    private virtual bool MoveNext()
    {
        uint uVar1;
        long lVar2;
        ulong uVar3;
        lVar2 = this.<>4__this;
        if (this.<>1__state == 0) {
          uVar1 = this.delta;
          this.<>1__state = 0xffffffff;
          uVar3 = new WaitForSecondsRealtime(uVar1,0);
          this.<>2__current = uVar3;
          this.<>1__state = 1;
          return true;
        }
        if (this.<>1__state == 1) {
          this.<>1__state = 0xffffffff;
          if (lVar2 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          *(uint64 *)(lVar2 + 24) = *(uint64 *)(lVar2 + 72);
        }
        return false;
    }

    // Token : 0x60021BB
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x60021BC
    // RVA   : 0xB13150   Offset: 0xB11950   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181d682e8);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181d8b690);
    }

    // Token : 0x60021BD
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
