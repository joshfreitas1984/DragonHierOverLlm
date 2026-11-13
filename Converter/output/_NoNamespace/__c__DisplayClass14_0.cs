// ============================================================
// Type  : <>c__DisplayClass14_0
// Token : 0x2000472
// ============================================================

public class <>c__DisplayClass14_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40021AC
    public RectTransform target;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002799
    // RVA   : 0x42F150   Offset: 0x42DF50   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x600279A
    // RVA   : 0x67E8A0   Offset: 0x67D6A0   Length: 0x1D
    internal Vector2 <DOAnchorPosX>b__0()
    {
        if (this.target != null) {
          RectTransform.get_anchoredPosition(this.target,0);
          return;
        }
    }

    // Token : 0x600279B
    // RVA   : 0x67E8C0   Offset: 0x67D6C0   Length: 0x1E
    internal void <DOAnchorPosX>b__1(Vector2 x)
    {
        if (this.target != null) {
          RectTransform.set_anchoredPosition(this.target,x,0);
          return;
        }
    }

}
