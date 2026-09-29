// ============================================================
// Type  : <>c__DisplayClass20_0
// Token : 0x200046B
// ============================================================

public class <>c__DisplayClass20_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400211F
    public RectTransform target;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002701
    // RVA   : 0x210B70   Offset: 0x20FF70   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x6002702
    // RVA   : 0x9381B0   Offset: 0x9375B0   Length: 0x1D
    internal Vector2 <DOAnchorMax>b__0()
    {
        if (this.target != null) {
          RectTransform.get_anchorMax(this.target,0);
          return;
        }
    }

    // Token : 0x6002703
    // RVA   : 0x9381D0   Offset: 0x9375D0   Length: 0x1E
    internal void <DOAnchorMax>b__1(Vector2 x)
    {
        if (this.target != null) {
          RectTransform.set_anchorMax(this.target,x,0);
          return;
        }
    }

}
