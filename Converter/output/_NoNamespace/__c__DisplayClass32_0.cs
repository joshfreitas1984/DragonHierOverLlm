// ============================================================
// Type  : <>c__DisplayClass32_0
// Token : 0x2000470
// ============================================================

public class <>c__DisplayClass32_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4002025
    public ScrollRect target;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60026A6
    // RVA   : 0x210B70   Offset: 0x20F370   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x60026A7
    // RVA   : 0x8D6FB0   Offset: 0x8D57B0   Length: 0x1D
    internal float <DOVerticalNormalizedPos>b__0()
    {
        if (this.target != null) {
          ScrollRect.get_verticalNormalizedPosition(this.target,0);
          return;
        }
    }

    // Token : 0x60026A8
    // RVA   : 0x8D6FD0   Offset: 0x8D57D0   Length: 0x1E
    internal void <DOVerticalNormalizedPos>b__1(float x)
    {
        if (this.target != null) {
          FUN_18136a4a0(this.target,x,0);
          return;
        }
    }

}
