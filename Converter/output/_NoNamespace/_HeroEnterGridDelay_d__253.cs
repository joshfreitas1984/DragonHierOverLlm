// ============================================================
// Type  : <HeroEnterGridDelay>d__253
// Token : 0x200016D
// ============================================================

public class <HeroEnterGridDelay>d__253
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40009CE
    private int <>1__state;

    // Token: 0x40009CF
    private object <>2__current;

    // Token: 0x40009D0
    public float delayTime;

    // Token: 0x40009D1
    public BattleUnit targetUnit;

    // Token: 0x40009D2
    public GridUnitData targetGrid;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000BEC
    // RVA   : 0x219070   Offset: 0x218470   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x6000BED
    // RVA   : 0x245810   Offset: 0x244C10   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x6000BEE
    // RVA   : 0x92FEB0   Offset: 0x92F2B0   Length: 0xC1
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

    // Token : 0x6000BEF
    // RVA   : 0x20F140   Offset: 0x20E540   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x6000BF0
    // RVA   : 0x92FF80   Offset: 0x92F380   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181d8d528);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181d97ad0);
    }

    // Token : 0x6000BF1
    // RVA   : 0x20F140   Offset: 0x20E540   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
