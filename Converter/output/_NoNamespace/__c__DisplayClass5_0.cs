// ============================================================
// Type  : <>c__DisplayClass5_0
// Token : 0x2000456
// ============================================================

public class <>c__DisplayClass5_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4002006
    public Image target;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002654
    // RVA   : 0x210B70   Offset: 0x20F370   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x6002655
    // RVA   : 0x8D7630   Offset: 0x8D5E30   Length: 0x1F
    internal float <DOFillAmount>b__0()
    {
        if (this.target != null) {
          return *(uint32 *)(this.target + 244);
        }
    }

    // Token : 0x6002656
    // RVA   : 0x8D7650   Offset: 0x8D5E50   Length: 0x1E
    internal void <DOFillAmount>b__1(float x)
    {
        if (this.target != null) {
          Image.set_fillAmount(this.target,x,0);
          return;
        }
    }

}
