// ============================================================
// Type  : MedFoodData
// Token : 0x2000239
// ============================================================

public class MedFoodData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001164
    public int enhanceLv;

    // Token: 0x4001165
    public ChangeHeroStateData changeHeroState;

    // Token: 0x4001166
    public int randomSpeAddValue;

    // Token: 0x4001167
    public HeroSpeAddData extraAddData;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60012AA
    // RVA   : 0xA8EA10   Offset: 0xA8D210   Length: 0x24
    public ChangeHeroStateData GetChangeHeroStateData()
    {
        ChangeHeroStateData.op_Multiply
                  (this.changeHeroState,(float)this.enhanceLv * 0.1 + 1.0,0);
    }

    // Token : 0x60012AB
    // RVA   : 0xA8EA40   Offset: 0xA8D240   Length: 0x99
    public void /*ctor*/()
    {
        ulong uVar1;
        ZhSegment.Initialize(this,0);
        this.changeHeroState = new ChangeHeroStateData(0);
        this.extraAddData = new HeroSpeAddData(0);
    }

}
