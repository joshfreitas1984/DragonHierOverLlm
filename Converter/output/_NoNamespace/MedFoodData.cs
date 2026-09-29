// ============================================================
// Type  : MedFoodData
// Token : 0x200023F
// ============================================================

public class MedFoodData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001207
    public int enhanceLv;

    // Token: 0x4001208
    public ChangeHeroStateData changeHeroState;

    // Token: 0x4001209
    public int randomSpeAddValue;

    // Token: 0x400120A
    public HeroSpeAddData extraAddData;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60012EB
    // RVA   : 0xA8E0F0   Offset: 0xA8D4F0   Length: 0x24
    public ChangeHeroStateData GetChangeHeroStateData()
    {
        ChangeHeroStateData.op_Multiply
                  (this.changeHeroState,(float)this.enhanceLv * 0.1 + 1.0,0);
    }

    // Token : 0x60012EC
    // RVA   : 0xA8E120   Offset: 0xA8D520   Length: 0x99
    public void /*ctor*/()
    {
        ulong uVar1;
        ZhSegment.Initialize(this,0);
        this.changeHeroState = new ChangeHeroStateData(0);
        this.extraAddData = new HeroSpeAddData(0);
    }

}
