// ============================================================
// Type  : <>c__DisplayClass21_0
// Token : 0x2000465
// ============================================================

public class <>c__DisplayClass21_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4002015
    public RectTransform target;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002681
    // RVA   : 0x210B70   Offset: 0x20F370   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x6002682
    // RVA   : 0x8D5670   Offset: 0x8D3E70   Length: 0x1D
    internal Vector2 <DOAnchorMin>b__0()
    {
        if (this.target != null) {
          RectTransform.get_anchorMin(this.target,0);
          return;
        }
    }

    // Token : 0x6002683
    // RVA   : 0x8D5690   Offset: 0x8D3E90   Length: 0x1E
    internal void <DOAnchorMin>b__1(Vector2 x)
    {
        if (this.target != null) {
          RectTransform.set_anchorMin(this.target,x,0);
          return;
        }
    }

}
