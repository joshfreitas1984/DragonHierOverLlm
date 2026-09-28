// ============================================================
// Type  : WaitForKill
// Token : 0x200048D
// ============================================================

public class WaitForKill
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400215F
    private readonly Tween t;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600276D
    // RVA   : 0x93AFA0   Offset: 0x93A3A0   Length: 0x1E
    public override bool get_keepWaiting()
    {
        if (this.t != null) {
          return *(uint8 *)(this.t + 232);
        }
    }

    // Token : 0x600276E
    // RVA   : 0x249490   Offset: 0x248890   Length: 0x30
    public void /*ctor*/(Tween tween)
    {
        c__DisplayClass9_0.ctor(this,0);
        this.t = tween;
    }

}
