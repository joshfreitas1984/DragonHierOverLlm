// ============================================================
// Type  : <HeroEnterGridDelay>d__255
// Token : 0x2000169
// ============================================================

public class <HeroEnterGridDelay>d__255
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40009B1
    private int <>1__state;

    // Token: 0x40009B2
    private object <>2__current;

    // Token: 0x40009B3
    public float delayTime;

    // Token: 0x40009B4
    public BattleUnit targetUnit;

    // Token: 0x40009B5
    public GridUnitData targetGrid;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000BCF
    // RVA   : 0x608BA0   Offset: 0x6079A0   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x6000BD0
    // RVA   : 0x51CF50   Offset: 0x51BD50   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x6000BD1
    // RVA   : 0x6757A0   Offset: 0x6745A0   Length: 0xC1
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
            FUN_1801e0300();
          }
          BattleUnit.EnterGrid(this.targetUnit,this.targetGrid,0,0,0);
        }
        return false;
    }

    // Token : 0x6000BD2
    // RVA   : 0x608B50   Offset: 0x607950   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x6000BD3
    // RVA   : 0x675870   Offset: 0x674670   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181e6d8e8);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181e7b190);
    }

    // Token : 0x6000BD4
    // RVA   : 0x608B50   Offset: 0x607950   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
