// ============================================================
// Type  : WaitForCompletion
// Token : 0x200048B
// ============================================================

public class WaitForCompletion
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400215E
    private readonly Tween t;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002769
    // RVA   : 0x93B5B0   Offset: 0x93A9B0   Length: 0x33
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

    // Token : 0x600276A
    // RVA   : 0x249490   Offset: 0x248890   Length: 0x30
    public void /*ctor*/(Tween tween)
    {
        c__DisplayClass9_0.ctor(this,0);
        this.t = tween;
    }

}
