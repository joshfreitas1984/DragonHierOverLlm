// ============================================================
// Type  : WaitForKill
// Token : 0x2000486
// ============================================================

public class WaitForKill
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4002055
    private readonly Tween t;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60026EA
    // RVA   : 0x8D8E90   Offset: 0x8D7690   Length: 0x1E
    public override bool get_keepWaiting()
    {
        if (this.t != null) {
          return *(uint8 *)(this.t + 232);
        }
    }

    // Token : 0x60026EB
    // RVA   : 0x249490   Offset: 0x247C90   Length: 0x30
    public void /*ctor*/(Tween tween)
    {
        c__DisplayClass9_0.ctor(this,0);
        this.t = tween;
    }

}
