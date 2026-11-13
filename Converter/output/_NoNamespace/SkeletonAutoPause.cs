// ============================================================
// Type  : SkeletonAutoPause
// Token : 0x2000366
// ============================================================

public class SkeletonAutoPause
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001C13
    public SkeletonAnimation skeletonAnimation;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60021C6
    // RVA   : 0x6AB9C0   Offset: 0x6AA7C0   Length: 0x4B
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

    // Token : 0x60021C7
    // RVA   : 0x6ABA10   Offset: 0x6AA810   Length: 0x20
    private void OnBecameVisible()
    {
        if (this.skeletonAnimation != null) {
          Behaviour.set_enabled(this.skeletonAnimation,1,0);
          return;
        }
    }

    // Token : 0x60021C8
    // RVA   : 0x6AB9C0   Offset: 0x6AA7C0   Length: 0x4B
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

    // Token : 0x60021C9
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

}
