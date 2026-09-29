// ============================================================
// Type  : WaitForPosition
// Token : 0x200048F
// ============================================================

public class WaitForPosition
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4002163
    private readonly Tween t;

    // Token: 0x4002164
    private readonly float position;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002771
    // RVA   : 0x93B6A0   Offset: 0x93AAA0   Length: 0x5F
    public override bool get_keepWaiting()
    {
        float fVar1;
        long lVar2;
        int iVar3;
        ulong in_RAX;
        lVar2 = this.t;
        if (lVar2 == null) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
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

    // Token : 0x6002772
    // RVA   : 0x93B650   Offset: 0x93AA50   Length: 0x43
    public void /*ctor*/(Tween tween, float position)
    {
        c__DisplayClass9_0.ctor(this,0);
        this.t = tween;
        this.position = position;
    }

}
