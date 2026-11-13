// ============================================================
// Type  : WaitForStart
// Token : 0x200049D
// ============================================================

public class WaitForStart
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40021F8
    private readonly Tween t;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600281D
    // RVA   : 0x680E70   Offset: 0x67FC70   Length: 0x31
    public override bool get_keepWaiting()
    {
        long lVar1;
        lVar1 = this.t;
        if (lVar1 == null) {
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        uVar2 = (uint7)((uint64)lVar1 >> 8);
        if (*(char *)(lVar1 + 232) == false) {
          return (uint64)uVar2 << 8;
        }
        return CONCAT71(uVar2,*(char *)(lVar1 + 0x102) == false);
    }

    // Token : 0x600281E
    // RVA   : 0x680C30   Offset: 0x67FA30   Length: 0x30
    public void /*ctor*/(Tween tween)
    {
        c__DisplayClass9_0.ctor(this,0);
        this.t = tween;
    }

}
