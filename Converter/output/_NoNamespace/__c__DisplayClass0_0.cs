// ============================================================
// Type  : <>c__DisplayClass0_0
// Token : 0x2000451
// ============================================================

public class <>c__DisplayClass0_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4002001
    public CanvasGroup target;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002645
    // RVA   : 0x210B70   Offset: 0x20F370   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x6002646
    // RVA   : 0x8D4AD0   Offset: 0x8D32D0   Length: 0x1D
    internal float <DOFade>b__0()
    {
        if (this.target != null) {
          CanvasGroup.get_alpha(this.target,0);
          return;
        }
    }

    // Token : 0x6002647
    // RVA   : 0x8D4B10   Offset: 0x8D3310   Length: 0x1E
    internal void <DOFade>b__1(float x)
    {
        if (this.target != null) {
          CanvasGroup.set_alpha(this.target,x,0);
          return;
        }
    }

}
