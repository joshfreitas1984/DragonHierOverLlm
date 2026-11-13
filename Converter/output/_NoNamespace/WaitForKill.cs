// ============================================================
// Type  : WaitForKill
// Token : 0x200049A
// ============================================================

public class WaitForKill
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40021F3
    private readonly Tween t;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002817
    // RVA   : 0x680D30   Offset: 0x67FB30   Length: 0x1E
    public override bool get_keepWaiting()
    {
        if (this.t != null) {
          return *(uint8 *)(this.t + 232);
        }
    }

    // Token : 0x6002818
    // RVA   : 0x680C30   Offset: 0x67FA30   Length: 0x30
    public void /*ctor*/(Tween tween)
    {
        c__DisplayClass9_0.ctor(this,0);
        this.t = tween;
    }

}
