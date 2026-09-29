// ============================================================
// Type  : <>c__DisplayClass22_0
// Token : 0x200046D
// ============================================================

public class <>c__DisplayClass22_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4002121
    public RectTransform target;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002707
    // RVA   : 0x210B70   Offset: 0x20FF70   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x6002708
    // RVA   : 0x938250   Offset: 0x937650   Length: 0x1D
    internal Vector2 <DOPivot>b__0()
    {
        if (this.target != null) {
          RectTransform.get_pivot(this.target,0);
          return;
        }
    }

    // Token : 0x6002709
    // RVA   : 0x938270   Offset: 0x937670   Length: 0x1E
    internal void <DOPivot>b__1(Vector2 x)
    {
        if (this.target != null) {
          RectTransform.set_pivot(this.target,x,0);
          return;
        }
    }

}
