// ============================================================
// Type  : <>c__DisplayClass12_0
// Token : 0x200045C
// ============================================================

public class <>c__DisplayClass12_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400200C
    public Outline target;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002666
    // RVA   : 0x210B70   Offset: 0x20F370   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x6002667
    // RVA   : 0x8D52E0   Offset: 0x8D3AE0   Length: 0x29
    internal Vector2 <DOScale>b__0()
    {
        if (this.target != null) {
          return *(uint64 *)(this.target + 48);
        }
    }

    // Token : 0x6002668
    // RVA   : 0x8D5310   Offset: 0x8D3B10   Length: 0x1E
    internal void <DOScale>b__1(Vector2 x)
    {
        if (this.target != null) {
          Shadow.set_effectDistance(this.target,x,0);
          return;
        }
    }

}
