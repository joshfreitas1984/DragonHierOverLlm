// ============================================================
// Type  : <>c__DisplayClass41_0
// Token : 0x200048D
// ============================================================

public class <>c__DisplayClass41_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40021D2
    public RectTransform target;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60027EE
    // RVA   : 0x42F150   Offset: 0x42DF50   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x60027EF
    // RVA   : 0x67E8A0   Offset: 0x67D6A0   Length: 0x1D
    internal Vector2 <DOShapeCircle>b__0()
    {
        if (this.target != null) {
          RectTransform.get_anchoredPosition(this.target,0);
          return;
        }
    }

    // Token : 0x60027F0
    // RVA   : 0x67E8C0   Offset: 0x67D6C0   Length: 0x1E
    internal void <DOShapeCircle>b__1(Vector2 x)
    {
        if (this.target != null) {
          RectTransform.set_anchoredPosition(this.target,x,0);
          return;
        }
    }

}
