// ============================================================
// Type  : <>c__DisplayClass31_0
// Token : 0x200046F
// ============================================================

public class <>c__DisplayClass31_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4002024
    public ScrollRect target;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60026A3
    // RVA   : 0x210B70   Offset: 0x20F370   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x60026A4
    // RVA   : 0x8D6EC0   Offset: 0x8D56C0   Length: 0x1D
    internal float <DOHorizontalNormalizedPos>b__0()
    {
        if (this.target != null) {
          ScrollRect.get_horizontalNormalizedPosition(this.target,0);
          return;
        }
    }

    // Token : 0x60026A5
    // RVA   : 0x8D6EE0   Offset: 0x8D56E0   Length: 0x1E
    internal void <DOHorizontalNormalizedPos>b__1(float x)
    {
        if (this.target != null) {
          FUN_181369950(this.target,x,0);
          return;
        }
    }

}
