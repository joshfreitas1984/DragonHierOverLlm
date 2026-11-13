// ============================================================
// Type  : WaitForPosition
// Token : 0x200049C
// ============================================================

public class WaitForPosition
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40021F6
    private readonly Tween t;

    // Token: 0x40021F7
    private readonly float position;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600281B
    // RVA   : 0x680DA0   Offset: 0x67FBA0   Length: 0x5F
    public override bool get_keepWaiting()
    {
        float fVar1;
        long lVar2;
        int iVar3;
        ulong in_RAX;
        lVar2 = this.t;
        if (lVar2 == null) {
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        if (*(char *)(lVar2 + 232) == false) {
          return in_RAX & 0xffffffffffffff00;
        }
        fVar1 = *(float *)(lVar2 + 0x104);
        iVar3 = TweenExtensions.CompletedLoops(lVar2,0);
        return (uint64)
               CONCAT31((int3)((uint32)(iVar3 + 1) >> 8),
                        (float)(iVar3 + 1) * fVar1 < this.position);
    }

    // Token : 0x600281C
    // RVA   : 0x680D50   Offset: 0x67FB50   Length: 0x43
    public void /*ctor*/(Tween tween, float position)
    {
        c__DisplayClass9_0.ctor(this,0);
        this.t = tween;
        this.position = position;
    }

}
