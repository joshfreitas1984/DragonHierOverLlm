// ============================================================
// Type  : <>c__DisplayClass32_0
// Token : 0x2000477
// ============================================================

public class <>c__DisplayClass32_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400212F
    public ScrollRect target;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002729
    // RVA   : 0x210B70   Offset: 0x20FF70   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x600272A
    // RVA   : 0x9394A0   Offset: 0x9388A0   Length: 0x1D
    internal float <DOVerticalNormalizedPos>b__0()
    {
        if (this.target != null) {
          ScrollRect.get_verticalNormalizedPosition(this.target,0);
          return;
        }
    }

    // Token : 0x600272B
    // RVA   : 0x9394C0   Offset: 0x9388C0   Length: 0x1E
    internal void <DOVerticalNormalizedPos>b__1(float x)
    {
        if (this.target != null) {
          FUN_1813bba50(this.target,x,0);
          return;
        }
    }

}
