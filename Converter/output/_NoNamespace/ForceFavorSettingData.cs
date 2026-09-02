// ============================================================
// Type  : ForceFavorSettingData
// Token : 0x200020B
// ============================================================

public class ForceFavorSettingData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000E5C
    public int forceID;

    // Token: 0x4000E5D
    public float forceFavor;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000FCF
    // RVA   : 0x47A090   Offset: 0x478890   Length: 0x36
    public void /*ctor*/(int _forceID, float _forceFavor)
    {
        ZhSegment.Initialize(this,0);
        this.forceFavor = _forceFavor;
        this.forceID = _forceID;
    }

}
