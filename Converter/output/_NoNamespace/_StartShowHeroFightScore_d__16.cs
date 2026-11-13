// ============================================================
// Type  : <StartShowHeroFightScore>d__16
// Token : 0x20002D2
// ============================================================

public class <StartShowHeroFightScore>d__16
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001773
    private int <>1__state;

    // Token: 0x4001774
    private object <>2__current;

    // Token: 0x4001775
    public HeroFightScoreListController <>4__this;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001846
    // RVA   : 0x608BA0   Offset: 0x6079A0   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x6001847
    // RVA   : 0x51CF50   Offset: 0x51BD50   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x6001848
    // RVA   : 0x6149A0   Offset: 0x6137A0   Length: 0x1EC
    private virtual bool MoveNext()
    {
        long lVar1;
        long lVar2;
        ulong uVar3;
        long lVar4;
        uint[] local_res8 = new uint[2];
        local_res8[0] = this.<>1__state;
        lVar1 = this.<>4__this;
        if (local_res8[0] == 0) {
          this.<>1__state = 0xffffffff;
          uVar3 = il2cpp_value_box(DAT_181e60808,local_res8);
          this.<>2__current = uVar3;
          this.<>1__state = 1;
          return true;
        }
        if (local_res8[0] == 1) {
          this.<>1__state = 0xffffffff;
          if (lVar1 == null) goto LAB_180614b87;
          if (*(char *)(lVar1 + 66) == false) {
            *(uint8 *)(lVar1 + 66) = 1;
            lVar4 = FUN_180210740(0);
            lVar2 = *(int64 *)(*(int64 *)(DAT_181e8a5e8 + 184) + 8);
            uVar3 = new OnTooltipCB(lVar1,DAT_181e5c1d8,0);
            if (lVar2 == null) {
        LAB_180614b87:
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            uVar3 = TaskFactory.StartNew(lVar2,uVar3,2);
            if (lVar4 == null) goto LAB_180614b87;
            GameDataController.AddTask(lVar4,uVar3,0);
          }
          if (*(char *)(lVar1 + 64) == false) {
            HeroFightScoreListController.Init(lVar1,0);
          }
        }
        return false;
    }

    // Token : 0x6001849
    // RVA   : 0x608B50   Offset: 0x607950   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x600184A
    // RVA   : 0x614B90   Offset: 0x613990   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181e6d8e8);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181e89320);
    }

    // Token : 0x600184B
    // RVA   : 0x608B50   Offset: 0x607950   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
