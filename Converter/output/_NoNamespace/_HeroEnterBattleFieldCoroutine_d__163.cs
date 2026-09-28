// ============================================================
// Type  : <HeroEnterBattleFieldCoroutine>d__163
// Token : 0x2000165
// ============================================================

public class <HeroEnterBattleFieldCoroutine>d__163
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40009AE
    private int <>1__state;

    // Token: 0x40009AF
    private object <>2__current;

    // Token: 0x40009B0
    public BattleController <>4__this;

    // Token: 0x40009B1
    public HeroData heroData;

    // Token: 0x40009B2
    public BattleTeam targetTeam;

    // Token: 0x40009B3
    public GridUnitData targetGrid;

    // Token: 0x40009B4
    public int startTalkType;

    // Token: 0x40009B5
    public float startMovePower;

    // Token: 0x40009B6
    public float waitTime;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000BBC
    // RVA   : 0x219070   Offset: 0x218470   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x6000BBD
    // RVA   : 0x245810   Offset: 0x244C10   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x6000BBE
    // RVA   : 0x92F730   Offset: 0x92EB30   Length: 0xDD
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

    // Token : 0x6000BBF
    // RVA   : 0x20F140   Offset: 0x20E540   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x6000BC0
    // RVA   : 0x92F810   Offset: 0x92EC10   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181d8d510);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181d978b8);
    }

    // Token : 0x6000BC1
    // RVA   : 0x20F140   Offset: 0x20E540   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
