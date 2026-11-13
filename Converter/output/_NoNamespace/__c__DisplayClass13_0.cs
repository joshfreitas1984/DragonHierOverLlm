// ============================================================
// Type  : <>c__DisplayClass13_0
// Token : 0x2000471
// ============================================================

public class <>c__DisplayClass13_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40021AB
    public RectTransform target;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002796
    // RVA   : 0x42F150   Offset: 0x42DF50   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x6002797
    // RVA   : 0x67E8A0   Offset: 0x67D6A0   Length: 0x1D
    internal Vector2 <DOAnchorPos>b__0()
    {
        if (this.target != null) {
          RectTransform.get_anchoredPosition(this.target,0);
          return;
        }
    }

    // Token : 0x6002798
    // RVA   : 0x67E8C0   Offset: 0x67D6C0   Length: 0x1E
    internal void <DOAnchorPos>b__1(Vector2 x)
    {
        if (this.target != null) {
          RectTransform.set_anchoredPosition(this.target,x,0);
          return;
        }
    }

}
