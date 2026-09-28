// ============================================================
// Type  : MaterialData
// Token : 0x2000242
// ============================================================

public class MaterialData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001212
    public HeroSpeAddData extraAddData;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60012F2
    // RVA   : 0xA8D9C0   Offset: 0xA8CDC0   Length: 0x65
    public void /*ctor*/()
    {
        ulong uVar1;
        ZhSegment.Initialize(this,0);
        this.extraAddData = new HeroSpeAddData(0);
    }

}
