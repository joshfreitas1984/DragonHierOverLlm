// ============================================================
// Type  : <>c__DisplayClass31_0
// Token : 0x2000483
// ============================================================

public class <>c__DisplayClass31_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40021C2
    public ScrollRect target;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60027D0
    // RVA   : 0x42F150   Offset: 0x42DF50   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x60027D1
    // RVA   : 0x67F5C0   Offset: 0x67E3C0   Length: 0x1D
    internal float <DOHorizontalNormalizedPos>b__0()
    {
        if (this.target != null) {
          ScrollRect.get_horizontalNormalizedPosition(this.target,0);
          return;
        }
    }

    // Token : 0x60027D2
    // RVA   : 0x67F5E0   Offset: 0x67E3E0   Length: 0x1E
    internal void <DOHorizontalNormalizedPos>b__1(float x)
    {
        if (this.target != null) {
          FUN_181273960(this.target,x,0);
          return;
        }
    }

}
