// ============================================================
// Type  : <>c__DisplayClass12_0
// Token : 0x2000470
// ============================================================

public class <>c__DisplayClass12_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40021AA
    public Outline target;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002793
    // RVA   : 0x42F150   Offset: 0x42DF50   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x6002794
    // RVA   : 0x67E850   Offset: 0x67D650   Length: 0x29
    internal Vector2 <DOScale>b__0()
    {
        if (this.target != null) {
          return *(uint64 *)(this.target + 48);
        }
    }

    // Token : 0x6002795
    // RVA   : 0x67E880   Offset: 0x67D680   Length: 0x1E
    internal void <DOScale>b__1(Vector2 x)
    {
        if (this.target != null) {
          Shadow.set_effectDistance(this.target,x,0);
          return;
        }
    }

}
