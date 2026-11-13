// ============================================================
// Type  : <>c__DisplayClass5_0
// Token : 0x200046A
// ============================================================

public class <>c__DisplayClass5_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40021A4
    public Image target;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002781
    // RVA   : 0x42F150   Offset: 0x42DF50   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x6002782
    // RVA   : 0x67FCB0   Offset: 0x67EAB0   Length: 0x1F
    internal float <DOFillAmount>b__0()
    {
        if (this.target != null) {
          return *(uint32 *)(this.target + 244);
        }
    }

    // Token : 0x6002783
    // RVA   : 0x67FCD0   Offset: 0x67EAD0   Length: 0x1E
    internal void <DOFillAmount>b__1(float x)
    {
        if (this.target != null) {
          Image.set_fillAmount(this.target,x,0);
          return;
        }
    }

}
