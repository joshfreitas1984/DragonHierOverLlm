// ============================================================
// Type  : ToggleTargetScale
// Token : 0x20003A0
// ============================================================

public class ToggleTargetScale
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001D82
    public GameObject target;

    // Token: 0x4001D83
    public float onScale;

    // Token: 0x4001D84
    public float offscale;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60022FC
    // RVA   : 0xAA5A60   Offset: 0xAA4E60   Length: 0x15
    public void /*ctor*/()
    {
        void FUN_180aa5a60(int64 this)
        {
        this.onScale = 0x3f800000;
        this.offscale = 0x3f800000;
        ZhSegment.Initialize(this,0);
    }

}
