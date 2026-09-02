// ============================================================
// Type  : <StartShowHeroFightScore>d__16
// Token : 0x20002C3
// ============================================================

public class <StartShowHeroFightScore>d__16
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400166B
    private int <>1__state;

    // Token: 0x400166C
    private object <>2__current;

    // Token: 0x400166D
    public HeroFightScoreListController <>4__this;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001786
    // RVA   : 0x219070   Offset: 0x217870   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x6001787
    // RVA   : 0x245810   Offset: 0x244010   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x6001788
    // RVA   : 0x8D1DC0   Offset: 0x8D05C0   Length: 0x19B
    private virtual bool MoveNext()
    {
        long lVar1;
        long lVar2;
        ulong uVar3;
        uint[] local_res8 = new uint[2];
        local_res8[0] = this.<>1__state;
        lVar1 = this.<>4__this;
        if (local_res8[0] == 0) {
          this.<>1__state = 0xffffffff;
          uVar3 = il2cpp_value_box(DAT_181d5b2f8,local_res8);
          this.<>2__current = uVar3;
          this.<>1__state = 1;
          return true;
        }
        if (local_res8[0] == 1) {
          this.<>1__state = 0xffffffff;
          if (lVar1 == null) {
        LAB_1808d1f56:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          if (*(char *)(lVar1 + 66) == false) {
            *(uint8 *)(lVar1 + 66) = 1;
            lVar2 = *(int64 *)(*(int64 *)(DAT_181d84f70 + 184) + 8);
            uVar3 = new OnTooltipCB(lVar1,DAT_181d50310,0);
            if (lVar2 == null) goto LAB_1808d1f56;
            TaskFactory.StartNew(lVar2,uVar3,2);
          }
          if (*(char *)(lVar1 + 64) == false) {
            HeroFightScoreListController.Init(lVar1,0);
          }
        }
        return false;
    }

    // Token : 0x6001789
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x600178A
    // RVA   : 0x8D1F60   Offset: 0x8D0760   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181d682e8);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181d7c9f0);
    }

    // Token : 0x600178B
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
