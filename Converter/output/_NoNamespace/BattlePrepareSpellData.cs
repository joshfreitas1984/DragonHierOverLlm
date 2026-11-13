// ============================================================
// Type  : BattlePrepareSpellData
// Token : 0x2000194
// ============================================================

public class BattlePrepareSpellData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000AF2
    public int id;

    // Token: 0x4000AF3
    public string spellName;

    // Token: 0x4000AF4
    public int targetSkillID;

    // Token: 0x4000AF5
    public int costSpellNum;

    // Token: 0x4000AF6
    public bool toEnemy;

    // Token: 0x4000AF7
    public string spellEffectString;

    // Token: 0x4000AF8
    public HeroSpeAddData spellSpeAddData;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000CD6
    // RVA   : 0x42F150   Offset: 0x42DF50   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

}
