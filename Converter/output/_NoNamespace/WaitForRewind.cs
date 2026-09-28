// ============================================================
// Type  : WaitForRewind
// Token : 0x200048C
// ============================================================

public class WaitForRewind
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400215E
    private readonly Tween t;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600276B
    // RVA   : 0x93B070   Offset: 0x93A470   Length: 0x66
    public override bool get_keepWaiting()
    {
        float fVar1;
        long lVar2;
        int iVar3;
        lVar2 = this.t;
        if (lVar2 == null) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        if (*(char *)(lVar2 + 232) == false) {
          return false;
        }
        if (*(char *)(lVar2 + 0x102) == false) {
          return true;
        }
        fVar1 = *(float *)(lVar2 + 0x104);
        iVar3 = TweenExtensions.CompletedLoops(lVar2,0);
        return 0.0 < (float)(iVar3 + 1) * fVar1;
    }

    // Token : 0x600276C
    // RVA   : 0x249490   Offset: 0x248890   Length: 0x30
    public void /*ctor*/(Tween tween)
    {
        c__DisplayClass9_0.ctor(this,0);
        this.t = tween;
    }

}
