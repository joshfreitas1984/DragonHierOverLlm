// ============================================================
// Type  : ToggleTargetScale
// Token : 0x2000399
// ============================================================

public class ToggleTargetScale
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001C7D
    public GameObject target;

    // Token: 0x4001C7E
    public float onScale;

    // Token: 0x4001C7F
    public float offscale;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600227A
    // RVA   : 0xAC63E0   Offset: 0xAC4BE0   Length: 0x15
    public void /*ctor*/()
    {
        void FUN_180ac63e0(int64 this)
        {
        this.onScale = 0x3f800000;
        this.offscale = 0x3f800000;
        ZhSegment.Initialize(this,0);
    }

}
