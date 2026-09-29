// ============================================================
// Type  : <>c__DisplayClass21_0
// Token : 0x200046C
// ============================================================

public class <>c__DisplayClass21_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4002120
    public RectTransform target;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002704
    // RVA   : 0x210B70   Offset: 0x20FF70   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x6002705
    // RVA   : 0x9381F0   Offset: 0x9375F0   Length: 0x1D
    internal Vector2 <DOAnchorMin>b__0()
    {
        if (this.target != null) {
          RectTransform.get_anchorMin(this.target,0);
          return;
        }
    }

    // Token : 0x6002706
    // RVA   : 0x938210   Offset: 0x937610   Length: 0x1E
    internal void <DOAnchorMin>b__1(Vector2 x)
    {
        if (this.target != null) {
          RectTransform.set_anchorMin(this.target,x,0);
          return;
        }
    }

}
