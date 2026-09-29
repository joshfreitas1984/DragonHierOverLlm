// ============================================================
// Type  : ToggleTargetScale
// Token : 0x20003A0
// ============================================================

public class ToggleTargetScale
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001D83
    public GameObject target;

    // Token: 0x4001D84
    public float onScale;

    // Token: 0x4001D85
    public float offscale;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60022FC
    // RVA   : 0xAA6120   Offset: 0xAA5520   Length: 0x15
    public void /*ctor*/()
    {
        void FUN_180aa6120(int64 this)
        {
        this.onScale = 0x3f800000;
        this.offscale = 0x3f800000;
        ZhSegment.Initialize(this,0);
    }

}
