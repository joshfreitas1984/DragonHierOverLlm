// ============================================================
// Type  : WaitForCompletion
// Token : 0x2000484
// ============================================================

public class WaitForCompletion
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4002053
    private readonly Tween t;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60026E6
    // RVA   : 0x8D8E10   Offset: 0x8D7610   Length: 0x33
    public override bool get_keepWaiting()
    {
        long lVar1;
        bool cVar2;
        lVar1 = this.t;
        if (lVar1 == null) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        if (*(char *)(lVar1 + 232) == false) {
          return false;
        }
        cVar2 = TweenExtensions.IsComplete(lVar1,0);
        return !cVar2;
    }

    // Token : 0x60026E7
    // RVA   : 0x249490   Offset: 0x247C90   Length: 0x30
    public void /*ctor*/(Tween tween)
    {
        c__DisplayClass9_0.ctor(this,0);
        this.t = tween;
    }

}
