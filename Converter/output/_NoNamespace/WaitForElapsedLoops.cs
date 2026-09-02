// ============================================================
// Type  : WaitForElapsedLoops
// Token : 0x2000487
// ============================================================

public class WaitForElapsedLoops
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4002056
    private readonly Tween t;

    // Token: 0x4002057
    private readonly int elapsedLoops;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60026EC
    // RVA   : 0x8D8E50   Offset: 0x8D7650   Length: 0x3B
    public override bool get_keepWaiting()
    {
        long lVar1;
        int iVar2;
        lVar1 = this.t;
        if (lVar1 == null) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        if (*(char *)(lVar1 + 232) == false) {
          return false;
        }
        iVar2 = TweenExtensions.CompletedLoops(lVar1,0);
        return iVar2 < this.elapsedLoops;
    }

    // Token : 0x60026ED
    // RVA   : 0x30BD50   Offset: 0x30A550   Length: 0x41
    public void /*ctor*/(Tween tween, int elapsedLoops)
    {
        c__DisplayClass9_0.ctor(this,0);
        this.t = tween;
        this.elapsedLoops = elapsedLoops;
    }

}
