// ============================================================
// Type  : ForceFavorSettingData
// Token : 0x2000213
// ============================================================

public class ForceFavorSettingData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000F00
    public int forceID;

    // Token: 0x4000F01
    public float forceFavor;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001010
    // RVA   : 0x212850   Offset: 0x211650   Length: 0x36
    public void /*ctor*/(int _forceID, float _forceFavor)
    {
        ZhSegment.Initialize(this,0);
        this.forceFavor = _forceFavor;
        this.forceID = _forceID;
    }

}
