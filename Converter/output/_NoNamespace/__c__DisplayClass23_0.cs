// ============================================================
// Type  : <>c__DisplayClass23_0
// Token : 0x200046E
// ============================================================

public class <>c__DisplayClass23_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4002122
    public RectTransform target;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600270A
    // RVA   : 0x210B70   Offset: 0x20FF70   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x600270B
    // RVA   : 0x938250   Offset: 0x937650   Length: 0x1D
    internal Vector2 <DOPivotX>b__0()
    {
        if (this.target != null) {
          RectTransform.get_pivot(this.target,0);
          return;
        }
    }

    // Token : 0x600270C
    // RVA   : 0x938270   Offset: 0x937670   Length: 0x1E
    internal void <DOPivotX>b__1(Vector2 x)
    {
        if (this.target != null) {
          RectTransform.set_pivot(this.target,x,0);
          return;
        }
    }

}
