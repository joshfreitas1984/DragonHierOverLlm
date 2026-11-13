// ============================================================
// Type  : <>c__DisplayClass332_0
// Token : 0x20002C2
// ============================================================

public class <>c__DisplayClass332_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400170F
    public SkeletonAnimation targetSkeleton;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60017DD
    // RVA   : 0x42F150   Offset: 0x42DF50   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x60017DE
    // RVA   : 0x67F6B0   Offset: 0x67E4B0   Length: 0x35
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
