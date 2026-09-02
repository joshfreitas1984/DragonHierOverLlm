// ============================================================
// Type  : SkeletonAutoPause
// Token : 0x2000352
// ============================================================

public class SkeletonAutoPause
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001A93
    public SkeletonAnimation skeletonAnimation;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600209D
    // RVA   : 0x970C00   Offset: 0x96F400   Length: 0x4B
    private void Start()
    {
        long lVar1;
        if (this.skeletonAnimation != null) {
          lVar1 = SkeletonAnimation.get_AnimationState(this.skeletonAnimation,0);
          if (lVar1 != null) {
            AnimationState.SetEmptyAnimation(lVar1,0,0,0);
            if (this.skeletonAnimation != null) {
              Behaviour.set_enabled(this.skeletonAnimation,0,0);
              return;
            }
          }
        }
    }

    // Token : 0x600209E
    // RVA   : 0x970C50   Offset: 0x96F450   Length: 0x20
    private void OnBecameVisible()
    {
        if (this.skeletonAnimation != null) {
          Behaviour.set_enabled(this.skeletonAnimation,1,0);
          return;
        }
    }

    // Token : 0x600209F
    // RVA   : 0x970C00   Offset: 0x96F400   Length: 0x4B
    private void OnBecameInvisible()
    {
        long lVar1;
        if (this.skeletonAnimation != null) {
          lVar1 = SkeletonAnimation.get_AnimationState(this.skeletonAnimation,0);
          if (lVar1 != null) {
            AnimationState.SetEmptyAnimation(lVar1,0,0,0);
            if (this.skeletonAnimation != null) {
              Behaviour.set_enabled(this.skeletonAnimation,0,0);
              return;
            }
          }
        }
    }

    // Token : 0x60020A0
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
