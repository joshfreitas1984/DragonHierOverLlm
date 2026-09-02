// ============================================================
// Type  : <>c__DisplayClass41_0
// Token : 0x2000479
// ============================================================

public class <>c__DisplayClass41_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4002034
    public RectTransform target;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60026C1
    // RVA   : 0x210B70   Offset: 0x20F370   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x60026C2
    // RVA   : 0x8D5330   Offset: 0x8D3B30   Length: 0x1D
    internal Vector2 <DOShapeCircle>b__0()
    {
        if (this.target != null) {
          RectTransform.get_anchoredPosition(this.target,0);
          return;
        }
    }

    // Token : 0x60026C3
    // RVA   : 0x8D5350   Offset: 0x8D3B50   Length: 0x1E
    internal void <DOShapeCircle>b__1(Vector2 x)
    {
        if (this.target != null) {
          RectTransform.set_anchoredPosition(this.target,x,0);
          return;
        }
    }

}
