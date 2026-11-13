// ============================================================
// Type  : WaitForCompletion
// Token : 0x2000498
// ============================================================

public class WaitForCompletion
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40021F1
    private readonly Tween t;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002813
    // RVA   : 0x680C60   Offset: 0x67FA60   Length: 0x33
    public override bool get_keepWaiting()
    {
        long lVar1;
        bool cVar2;
        lVar1 = this.t;
        if (lVar1 == null) {
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        if (*(char *)(lVar1 + 232) == false) {
          return false;
        }
        cVar2 = TweenExtensions.IsComplete(lVar1,0);
        return !cVar2;
    }

    // Token : 0x6002814
    // RVA   : 0x680C30   Offset: 0x67FA30   Length: 0x30
    public void /*ctor*/(Tween tween)
    {
        c__DisplayClass9_0.ctor(this,0);
        this.t = tween;
    }

}
