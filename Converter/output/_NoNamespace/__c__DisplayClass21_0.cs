// ============================================================
// Type  : <>c__DisplayClass21_0
// Token : 0x2000479
// ============================================================

public class <>c__DisplayClass21_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40021B3
    public RectTransform target;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60027AE
    // RVA   : 0x42F150   Offset: 0x42DF50   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x60027AF
    // RVA   : 0x67EA60   Offset: 0x67D860   Length: 0x1D
    internal Vector2 <DOAnchorMin>b__0()
    {
        if (this.target != null) {
          RectTransform.get_anchorMin(this.target,0);
          return;
        }
    }

    // Token : 0x60027B0
    // RVA   : 0x67EA80   Offset: 0x67D880   Length: 0x1E
    internal void <DOAnchorMin>b__1(Vector2 x)
    {
        if (this.target != null) {
          RectTransform.set_anchorMin(this.target,x,0);
          return;
        }
    }

}
