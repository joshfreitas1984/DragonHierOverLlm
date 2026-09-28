// ============================================================
// Type  : <>c__DisplayClass0_0
// Token : 0x2000458
// ============================================================

public class <>c__DisplayClass0_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400210B
    public CanvasGroup target;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60026C8
    // RVA   : 0x210B70   Offset: 0x20FF70   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x60026C9
    // RVA   : 0x937080   Offset: 0x936480   Length: 0x1D
    internal float <DOFade>b__0()
    {
        if (this.target != null) {
          CanvasGroup.get_alpha(this.target,0);
          return;
        }
    }

    // Token : 0x60026CA
    // RVA   : 0x9370C0   Offset: 0x9364C0   Length: 0x1E
    internal void <DOFade>b__1(float x)
    {
        if (this.target != null) {
          CanvasGroup.set_alpha(this.target,x,0);
          return;
        }
    }

}
