// ============================================================
// Type  : <>c__DisplayClass0_0
// Token : 0x2000465
// ============================================================

public class <>c__DisplayClass0_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400219F
    public CanvasGroup target;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002772
    // RVA   : 0x42F150   Offset: 0x42DF50   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x6002773
    // RVA   : 0x67D670   Offset: 0x67C470   Length: 0x1D
    internal float <DOFade>b__0()
    {
        if (this.target != null) {
          CanvasGroup.get_alpha(this.target,0);
          return;
        }
    }

    // Token : 0x6002774
    // RVA   : 0x67D6B0   Offset: 0x67C4B0   Length: 0x1E
    internal void <DOFade>b__1(float x)
    {
        if (this.target != null) {
          CanvasGroup.set_alpha(this.target,x,0);
          return;
        }
    }

}
