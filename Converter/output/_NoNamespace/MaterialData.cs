// ============================================================
// Type  : MaterialData
// Token : 0x200023C
// ============================================================

public class MaterialData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400116F
    public HeroSpeAddData extraAddData;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60012B1
    // RVA   : 0xA8E9A0   Offset: 0xA8D1A0   Length: 0x65
    public void /*ctor*/()
    {
        ulong uVar1;
        ZhSegment.Initialize(this,0);
        this.extraAddData = new HeroSpeAddData(0);
    }

}
