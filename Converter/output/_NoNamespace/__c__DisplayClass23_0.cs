// ============================================================
// Type  : <>c__DisplayClass23_0
// Token : 0x2000467
// ============================================================

public class <>c__DisplayClass23_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4002017
    public RectTransform target;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002687
    // RVA   : 0x210B70   Offset: 0x20F370   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x6002688
    // RVA   : 0x8D56D0   Offset: 0x8D3ED0   Length: 0x1D
    internal Vector2 <DOPivotX>b__0()
    {
        if (this.target != null) {
          RectTransform.get_pivot(this.target,0);
          return;
        }
    }

    // Token : 0x6002689
    // RVA   : 0x8D56F0   Offset: 0x8D3EF0   Length: 0x1E
    internal void <DOPivotX>b__1(Vector2 x)
    {
        if (this.target != null) {
          RectTransform.set_pivot(this.target,x,0);
          return;
        }
    }

}
