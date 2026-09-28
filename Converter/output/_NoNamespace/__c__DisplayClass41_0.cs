// ============================================================
// Type  : <>c__DisplayClass41_0
// Token : 0x2000480
// ============================================================

public class <>c__DisplayClass41_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400213E
    public RectTransform target;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002744
    // RVA   : 0x210B70   Offset: 0x20FF70   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x6002745
    // RVA   : 0x9378E0   Offset: 0x936CE0   Length: 0x1D
    internal Vector2 <DOShapeCircle>b__0()
    {
        if (this.target != null) {
          RectTransform.get_anchoredPosition(this.target,0);
          return;
        }
    }

    // Token : 0x6002746
    // RVA   : 0x937900   Offset: 0x936D00   Length: 0x1E
    internal void <DOShapeCircle>b__1(Vector2 x)
    {
        if (this.target != null) {
          RectTransform.set_anchoredPosition(this.target,x,0);
          return;
        }
    }

}
