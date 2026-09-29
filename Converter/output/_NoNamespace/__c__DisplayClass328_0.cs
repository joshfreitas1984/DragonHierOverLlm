// ============================================================
// Type  : <>c__DisplayClass328_0
// Token : 0x20002B9
// ============================================================

public class <>c__DisplayClass328_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40016BB
    public SkeletonAnimation targetSkeleton;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001761
    // RVA   : 0x210B70   Offset: 0x20FF70   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x6001762
    // RVA   : 0x939AF0   Offset: 0x938EF0   Length: 0x35
    internal void <DoTweenSkeletonAlpha>b__0(float value)
    {
        long lVar1;
        if (this.targetSkeleton != null) {
          lVar1 = SkeletonRenderer.get_Skeleton(this.targetSkeleton,0);
          if (lVar1 != null) {
            *(uint32 *)(lVar1 + 108) = value;
            return;
          }
        }
    }

}
