// ============================================================
// Type  : <>c__DisplayClass41_0
// Token : 0x2000480
// ============================================================

public class <>c__DisplayClass41_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400213F
    public RectTransform target;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002744
    // RVA   : 0x210B70   Offset: 0x20FF70   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x6002745
    // RVA   : 0x937F70   Offset: 0x937370   Length: 0x1D
    internal Vector2 <DOShapeCircle>b__0()
    {
        if (this.target != null) {
          RectTransform.get_anchoredPosition(this.target,0);
          return;
        }
    }

    // Token : 0x6002746
    // RVA   : 0x937F90   Offset: 0x937390   Length: 0x1E
    internal void <DOShapeCircle>b__1(Vector2 x)
    {
        if (this.target != null) {
          RectTransform.set_anchoredPosition(this.target,x,0);
          return;
        }
    }

}
