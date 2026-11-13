// ============================================================
// Type  : <>c__DisplayClass20_0
// Token : 0x2000478
// ============================================================

public class <>c__DisplayClass20_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40021B2
    public RectTransform target;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60027AB
    // RVA   : 0x42F150   Offset: 0x42DF50   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x60027AC
    // RVA   : 0x67EA20   Offset: 0x67D820   Length: 0x1D
    internal Vector2 <DOAnchorMax>b__0()
    {
        if (this.target != null) {
          RectTransform.get_anchorMax(this.target,0);
          return;
        }
    }

    // Token : 0x60027AD
    // RVA   : 0x67EA40   Offset: 0x67D840   Length: 0x1E
    internal void <DOAnchorMax>b__1(Vector2 x)
    {
        if (this.target != null) {
          RectTransform.set_anchorMax(this.target,x,0);
          return;
        }
    }

}
