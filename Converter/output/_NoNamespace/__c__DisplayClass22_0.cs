// ============================================================
// Type  : <>c__DisplayClass22_0
// Token : 0x2000466
// ============================================================

public class <>c__DisplayClass22_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4002016
    public RectTransform target;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002684
    // RVA   : 0x210B70   Offset: 0x20F370   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x6002685
    // RVA   : 0x8D56D0   Offset: 0x8D3ED0   Length: 0x1D
    internal Vector2 <DOPivot>b__0()
    {
        if (this.target != null) {
          RectTransform.get_pivot(this.target,0);
          return;
        }
    }

    // Token : 0x6002686
    // RVA   : 0x8D56F0   Offset: 0x8D3EF0   Length: 0x1E
    internal void <DOPivot>b__1(Vector2 x)
    {
        if (this.target != null) {
          RectTransform.set_pivot(this.target,x,0);
          return;
        }
    }

}
