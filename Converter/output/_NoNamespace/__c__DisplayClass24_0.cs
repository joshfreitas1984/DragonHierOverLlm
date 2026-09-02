// ============================================================
// Type  : <>c__DisplayClass24_0
// Token : 0x2000468
// ============================================================

public class <>c__DisplayClass24_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4002018
    public RectTransform target;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600268A
    // RVA   : 0x210B70   Offset: 0x20F370   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x600268B
    // RVA   : 0x8D56D0   Offset: 0x8D3ED0   Length: 0x1D
    internal Vector2 <DOPivotY>b__0()
    {
        if (this.target != null) {
          RectTransform.get_pivot(this.target,0);
          return;
        }
    }

    // Token : 0x600268C
    // RVA   : 0x8D56F0   Offset: 0x8D3EF0   Length: 0x1E
    internal void <DOPivotY>b__1(Vector2 x)
    {
        if (this.target != null) {
          RectTransform.set_pivot(this.target,x,0);
          return;
        }
    }

}
