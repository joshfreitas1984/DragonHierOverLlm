// ============================================================
// Type  : <>c__DisplayClass32_0
// Token : 0x2000484
// ============================================================

public class <>c__DisplayClass32_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40021C3
    public ScrollRect target;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60027D3
    // RVA   : 0x42F150   Offset: 0x42DF50   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x60027D4
    // RVA   : 0x67F600   Offset: 0x67E400   Length: 0x1D
    internal float <DOVerticalNormalizedPos>b__0()
    {
        if (this.target != null) {
          ScrollRect.get_verticalNormalizedPosition(this.target,0);
          return;
        }
    }

    // Token : 0x60027D5
    // RVA   : 0x67F620   Offset: 0x67E420   Length: 0x1E
    internal void <DOVerticalNormalizedPos>b__1(float x)
    {
        if (this.target != null) {
          FUN_1812744b0(this.target,x,0);
          return;
        }
    }

}
