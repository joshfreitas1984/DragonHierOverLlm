// ============================================================
// Type  : <>c__DisplayClass20_0
// Token : 0x2000464
// ============================================================

public class <>c__DisplayClass20_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4002014
    public RectTransform target;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600267E
    // RVA   : 0x210B70   Offset: 0x20F370   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x600267F
    // RVA   : 0x8D5570   Offset: 0x8D3D70   Length: 0x1D
    internal Vector2 <DOAnchorMax>b__0()
    {
        if (this.target != null) {
          RectTransform.get_anchorMax(this.target,0);
          return;
        }
    }

    // Token : 0x6002680
    // RVA   : 0x8D5590   Offset: 0x8D3D90   Length: 0x1E
    internal void <DOAnchorMax>b__1(Vector2 x)
    {
        if (this.target != null) {
          RectTransform.set_anchorMax(this.target,x,0);
          return;
        }
    }

}
