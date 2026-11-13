// ============================================================
// Type  : <>c__DisplayClass23_0
// Token : 0x200047B
// ============================================================

public class <>c__DisplayClass23_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40021B5
    public RectTransform target;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60027B4
    // RVA   : 0x42F150   Offset: 0x42DF50   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x60027B5
    // RVA   : 0x67EB60   Offset: 0x67D960   Length: 0x1D
    internal Vector2 <DOPivotX>b__0()
    {
        if (this.target != null) {
          RectTransform.get_pivot(this.target,0);
          return;
        }
    }

    // Token : 0x60027B6
    // RVA   : 0x67EB80   Offset: 0x67D980   Length: 0x1E
    internal void <DOPivotX>b__1(Vector2 x)
    {
        if (this.target != null) {
          RectTransform.set_pivot(this.target,x,0);
          return;
        }
    }

}
