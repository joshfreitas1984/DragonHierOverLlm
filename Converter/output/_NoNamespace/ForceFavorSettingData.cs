// ============================================================
// Type  : ForceFavorSettingData
// Token : 0x2000211
// ============================================================

public class ForceFavorSettingData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000EEC
    public int forceID;

    // Token: 0x4000EED
    public float forceFavor;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001007
    // RVA   : 0x46E160   Offset: 0x46D560   Length: 0x36
    public void /*ctor*/(int _forceID, float _forceFavor)
    {
        ZhSegment.Initialize(this,0);
        this.forceFavor = _forceFavor;
        this.forceID = _forceID;
    }

}
