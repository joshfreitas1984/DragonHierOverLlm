// ============================================================
// Type  : <>c__DisplayClass12_0
// Token : 0x2000463
// ============================================================

public class <>c__DisplayClass12_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4002117
    public Outline target;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60026E9
    // RVA   : 0x210B70   Offset: 0x20FF70   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x60026EA
    // RVA   : 0x937F20   Offset: 0x937320   Length: 0x29
    internal Vector2 <DOScale>b__0()
    {
        if (this.target != null) {
          return *(uint64 *)(this.target + 48);
        }
    }

    // Token : 0x60026EB
    // RVA   : 0x937F50   Offset: 0x937350   Length: 0x1E
    internal void <DOScale>b__1(Vector2 x)
    {
        if (this.target != null) {
          Shadow.set_effectDistance(this.target,x,0);
          return;
        }
    }

}
