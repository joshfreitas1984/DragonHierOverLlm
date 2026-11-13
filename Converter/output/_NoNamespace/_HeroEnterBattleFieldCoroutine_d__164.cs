// ============================================================
// Type  : <HeroEnterBattleFieldCoroutine>d__164
// Token : 0x2000161
// ============================================================

public class <HeroEnterBattleFieldCoroutine>d__164
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000991
    private int <>1__state;

    // Token: 0x4000992
    private object <>2__current;

    // Token: 0x4000993
    public BattleController <>4__this;

    // Token: 0x4000994
    public HeroData heroData;

    // Token: 0x4000995
    public BattleTeam targetTeam;

    // Token: 0x4000996
    public GridUnitData targetGrid;

    // Token: 0x4000997
    public int startTalkType;

    // Token: 0x4000998
    public float startMovePower;

    // Token: 0x4000999
    public float waitTime;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000B9F
    // RVA   : 0x608BA0   Offset: 0x6079A0   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x6000BA0
    // RVA   : 0x51CF50   Offset: 0x51BD50   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x6000BA1
    // RVA   : 0x675680   Offset: 0x674480   Length: 0xDD
    private virtual bool MoveNext()
    {
        uint uVar1;
        ulong uVar2;
        if (this.<>1__state == 0) {
          this.<>1__state = 0xffffffff;
          if (this.<>4__this != 0) {
            BattleController.HeroEnterBattleField
                      (this.<>4__this,this.heroData,
                       this.targetTeam,this.targetGrid,
                       this.startTalkType,this.startMovePower,0);
            uVar1 = this.waitTime;
            uVar2 = new WaitForSeconds(uVar1,0);
            this.<>2__current = uVar2;
            this.<>1__state = 1;
            return true;
          }
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        if (this.<>1__state == 1) {
          this.<>1__state = 0xffffffff;
        }
        return false;
    }

    // Token : 0x6000BA2
    // RVA   : 0x608B50   Offset: 0x607950   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x6000BA3
    // RVA   : 0x675760   Offset: 0x674560   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181e6d8e8);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181e7b110);
    }

    // Token : 0x6000BA4
    // RVA   : 0x608B50   Offset: 0x607950   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
