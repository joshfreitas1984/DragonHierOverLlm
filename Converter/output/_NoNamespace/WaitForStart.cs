// ============================================================
// Type  : WaitForStart
// Token : 0x2000489
// ============================================================

public class WaitForStart
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400205A
    private readonly Tween t;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60026F0
    // RVA   : 0x8D8FD0   Offset: 0x8D77D0   Length: 0x31
    public override bool get_keepWaiting()
    {
        long lVar1;
        lVar1 = this.t;
        if (lVar1 == null) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        uVar2 = (uint7)((uint64)lVar1 >> 8);
        if (*(char *)(lVar1 + 232) == false) {
          return (uint64)uVar2 << 8;
        }
        return CONCAT71(uVar2,*(char *)(lVar1 + 0x102) == false);
    }

    // Token : 0x60026F1
    // RVA   : 0x249490   Offset: 0x247C90   Length: 0x30
    public void /*ctor*/(Tween tween)
    {
        c__DisplayClass9_0.ctor(this,0);
        this.t = tween;
    }

}
