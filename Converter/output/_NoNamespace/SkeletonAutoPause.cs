// ============================================================
// Type  : SkeletonAutoPause
// Token : 0x2000359
// ============================================================

public class SkeletonAutoPause
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001B94
    public SkeletonAnimation skeletonAnimation;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600211E
    // RVA   : 0x983710   Offset: 0x982B10   Length: 0x4B
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

    // Token : 0x600211F
    // RVA   : 0x983760   Offset: 0x982B60   Length: 0x20
    private void OnBecameVisible()
    {
        if (this.skeletonAnimation != null) {
          Behaviour.set_enabled(this.skeletonAnimation,1,0);
          return;
        }
    }

    // Token : 0x6002120
    // RVA   : 0x983710   Offset: 0x982B10   Length: 0x4B
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

    // Token : 0x6002121
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
