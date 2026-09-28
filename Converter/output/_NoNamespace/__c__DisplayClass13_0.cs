// ============================================================
// Type  : <>c__DisplayClass13_0
// Token : 0x2000464
// ============================================================

public class <>c__DisplayClass13_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4002117
    public RectTransform target;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60026EC
    // RVA   : 0x210B70   Offset: 0x20FF70   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x60026ED
    // RVA   : 0x9378E0   Offset: 0x936CE0   Length: 0x1D
    internal Vector2 <DOAnchorPos>b__0()
    {
        if (this.target != null) {
          RectTransform.get_anchoredPosition(this.target,0);
          return;
        }
    }

    // Token : 0x60026EE
    // RVA   : 0x937900   Offset: 0x936D00   Length: 0x1E
    internal void <DOAnchorPos>b__1(Vector2 x)
    {
        if (this.target != null) {
          RectTransform.set_anchoredPosition(this.target,x,0);
          return;
        }
    }

}
