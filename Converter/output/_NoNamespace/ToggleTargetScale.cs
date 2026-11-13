// ============================================================
// Type  : ToggleTargetScale
// Token : 0x20003AD
// ============================================================

public class ToggleTargetScale
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001E15
    public GameObject target;

    // Token: 0x4001E16
    public float onScale;

    // Token: 0x4001E17
    public float offscale;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60023A6
    // RVA   : 0x815360   Offset: 0x814160   Length: 0x15
    public void /*ctor*/()
    {
        void FUN_180815360(int64 this)
        {
        this.onScale = 0x3f800000;
        this.offscale = 0x3f800000;
        ZhSegment.Initialize(this,0);
    }

}
