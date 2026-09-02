// ============================================================
// Type  : <HeroEnterGridDelay>d__227
// Token : 0x2000168
// ============================================================

public class <HeroEnterGridDelay>d__227
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000953
    private int <>1__state;

    // Token: 0x4000954
    private object <>2__current;

    // Token: 0x4000955
    public float delayTime;

    // Token: 0x4000956
    public BattleUnit targetUnit;

    // Token: 0x4000957
    public GridUnitData targetGrid;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000BC2
    // RVA   : 0x219070   Offset: 0x217870   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x6000BC3
    // RVA   : 0x245810   Offset: 0x244010   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x6000BC4
    // RVA   : 0xB23A00   Offset: 0xB22200   Length: 0xC1
    private virtual bool MoveNext()
    {
        uint uVar1;
        ulong uVar2;
        if (this.<>1__state == 0) {
          uVar1 = this.delayTime;
          this.<>1__state = 0xffffffff;
          uVar2 = new WaitForSeconds(uVar1,0);
          this.<>2__current = uVar2;
          this.<>1__state = 1;
          return true;
        }
        if (this.<>1__state == 1) {
          this.<>1__state = 0xffffffff;
          if (this.targetUnit == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          BattleUnit.EnterGrid(this.targetUnit,this.targetGrid,0,0,0);
        }
        return false;
    }

    // Token : 0x6000BC5
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x6000BC6
    // RVA   : 0xB23AD0   Offset: 0xB222D0   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181d682e8);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181d6ea98);
    }

    // Token : 0x6000BC7
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
