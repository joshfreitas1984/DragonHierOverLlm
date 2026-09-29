// ============================================================
// Type  : <>c__DisplayClass5_0
// Token : 0x200045D
// ============================================================

public class <>c__DisplayClass5_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4002111
    public Image target;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60026D7
    // RVA   : 0x210B70   Offset: 0x20FF70   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x60026D8
    // RVA   : 0x93A1B0   Offset: 0x9395B0   Length: 0x1F
    internal float <DOFillAmount>b__0()
    {
        if (this.target != null) {
          return *(uint32 *)(this.target + 244);
        }
    }

    // Token : 0x60026D9
    // RVA   : 0x93A1D0   Offset: 0x9395D0   Length: 0x1E
    internal void <DOFillAmount>b__1(float x)
    {
        if (this.target != null) {
          Image.set_fillAmount(this.target,x,0);
          return;
        }
    }

}
