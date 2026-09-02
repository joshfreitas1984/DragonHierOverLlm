// ============================================================
// Type  : <HeroEnterBattleFieldCoroutine>d__163
// Token : 0x2000160
// ============================================================

public class <HeroEnterBattleFieldCoroutine>d__163
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000933
    private int <>1__state;

    // Token: 0x4000934
    private object <>2__current;

    // Token: 0x4000935
    public BattleController <>4__this;

    // Token: 0x4000936
    public HeroData heroData;

    // Token: 0x4000937
    public BattleTeam targetTeam;

    // Token: 0x4000938
    public GridUnitData targetGrid;

    // Token: 0x4000939
    public int startTalkType;

    // Token: 0x400093A
    public float startMovePower;

    // Token: 0x400093B
    public float waitTime;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000B92
    // RVA   : 0x219070   Offset: 0x217870   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x6000B93
    // RVA   : 0x245810   Offset: 0x244010   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x6000B94
    // RVA   : 0xB238E0   Offset: 0xB220E0   Length: 0xDD
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
          FUN_1800d6620();
        }
        if (this.<>1__state == 1) {
          this.<>1__state = 0xffffffff;
        }
        return false;
    }

    // Token : 0x6000B95
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x6000B96
    // RVA   : 0xB239C0   Offset: 0xB221C0   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181d682e8);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181d6ea18);
    }

    // Token : 0x6000B97
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
