// ============================================================
// Type  : <>c__DisplayClass327_0
// Token : 0x20002B3
// ============================================================

public class <>c__DisplayClass327_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001607
    public SkeletonAnimation targetSkeleton;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600171D
    // RVA   : 0x210B70   Offset: 0x20F370   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x600171E
    // RVA   : 0x8D6F70   Offset: 0x8D5770   Length: 0x35
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
