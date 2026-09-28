// ============================================================
// Type  : <>c__DisplayClass31_0
// Token : 0x2000476
// ============================================================

public class <>c__DisplayClass31_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400212E
    public ScrollRect target;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002726
    // RVA   : 0x210B70   Offset: 0x20FF70   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x6002727
    // RVA   : 0x9393B0   Offset: 0x9387B0   Length: 0x1D
    internal float <DOHorizontalNormalizedPos>b__0()
    {
        if (this.target != null) {
          ScrollRect.get_horizontalNormalizedPosition(this.target,0);
          return;
        }
    }

    // Token : 0x6002728
    // RVA   : 0x9393D0   Offset: 0x9387D0   Length: 0x1E
    internal void <DOHorizontalNormalizedPos>b__1(float x)
    {
        if (this.target != null) {
          FUN_1813baf00(this.target,x,0);
          return;
        }
    }

}
