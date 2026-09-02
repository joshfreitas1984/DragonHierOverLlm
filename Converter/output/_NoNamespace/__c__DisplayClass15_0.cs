// ============================================================
// Type  : <>c__DisplayClass15_0
// Token : 0x200045F
// ============================================================

public class <>c__DisplayClass15_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400200F
    public RectTransform target;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600266F
    // RVA   : 0x210B70   Offset: 0x20F370   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x6002670
    // RVA   : 0x8D5330   Offset: 0x8D3B30   Length: 0x1D
    internal Vector2 <DOAnchorPosY>b__0()
    {
        if (this.target != null) {
          RectTransform.get_anchoredPosition(this.target,0);
          return;
        }
    }

    // Token : 0x6002671
    // RVA   : 0x8D5350   Offset: 0x8D3B50   Length: 0x1E
    internal void <DOAnchorPosY>b__1(Vector2 x)
    {
        if (this.target != null) {
          RectTransform.set_anchoredPosition(this.target,x,0);
          return;
        }
    }

}
