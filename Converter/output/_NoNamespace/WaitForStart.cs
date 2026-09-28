// ============================================================
// Type  : WaitForStart
// Token : 0x2000490
// ============================================================

public class WaitForStart
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4002164
    private readonly Tween t;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002773
    // RVA   : 0x93B0E0   Offset: 0x93A4E0   Length: 0x31
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

    // Token : 0x6002774
    // RVA   : 0x249490   Offset: 0x248890   Length: 0x30
    public void /*ctor*/(Tween tween)
    {
        c__DisplayClass9_0.ctor(this,0);
        this.t = tween;
    }

}
