// ============================================================
// Type  : <>c__DisplayClass25_0
// Token : 0x2000470
// ============================================================

public class <>c__DisplayClass25_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4002124
    public RectTransform target;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002710
    // RVA   : 0x210B70   Offset: 0x20FF70   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x6002711
    // RVA   : 0x938320   Offset: 0x937720   Length: 0x1D
    internal Vector2 <DOSizeDelta>b__0()
    {
        if (this.target != null) {
          RectTransform.get_sizeDelta(this.target,0);
          return;
        }
    }

    // Token : 0x6002712
    // RVA   : 0x938340   Offset: 0x937740   Length: 0x1E
    internal void <DOSizeDelta>b__1(Vector2 x)
    {
        if (this.target != null) {
          RectTransform.set_sizeDelta(this.target,x,0);
          return;
        }
    }

}
