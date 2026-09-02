// ============================================================
// Type  : <>c__DisplayClass25_0
// Token : 0x2000469
// ============================================================

public class <>c__DisplayClass25_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4002019
    public RectTransform target;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600268D
    // RVA   : 0x210B70   Offset: 0x20F370   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x600268E
    // RVA   : 0x8D57A0   Offset: 0x8D3FA0   Length: 0x1D
    internal Vector2 <DOSizeDelta>b__0()
    {
        if (this.target != null) {
          RectTransform.get_sizeDelta(this.target,0);
          return;
        }
    }

    // Token : 0x600268F
    // RVA   : 0x8D57C0   Offset: 0x8D3FC0   Length: 0x1E
    internal void <DOSizeDelta>b__1(Vector2 x)
    {
        if (this.target != null) {
          RectTransform.set_sizeDelta(this.target,x,0);
          return;
        }
    }

}
