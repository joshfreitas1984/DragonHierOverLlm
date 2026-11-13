// ============================================================
// Type  : WaitForElapsedLoops
// Token : 0x200049B
// ============================================================

public class WaitForElapsedLoops
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40021F4
    private readonly Tween t;

    // Token: 0x40021F5
    private readonly int elapsedLoops;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002819
    // RVA   : 0x680CF0   Offset: 0x67FAF0   Length: 0x3B
    public override bool get_keepWaiting()
    {
        long lVar1;
        int iVar2;
        lVar1 = this.t;
        if (lVar1 == null) {
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        if (*(char *)(lVar1 + 232) == false) {
          return false;
        }
        iVar2 = TweenExtensions.CompletedLoops(lVar1,0);
        return iVar2 < this.elapsedLoops;
    }

    // Token : 0x600281A
    // RVA   : 0x680CA0   Offset: 0x67FAA0   Length: 0x41
    public void /*ctor*/(Tween tween, int elapsedLoops)
    {
        c__DisplayClass9_0.ctor(this,0);
        this.t = tween;
        this.elapsedLoops = elapsedLoops;
    }

}
