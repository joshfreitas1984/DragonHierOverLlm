// ============================================================
// Type  : BattlePrepareSpellData
// Token : 0x200018C
// ============================================================

public class BattlePrepareSpellData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000A5F
    public int id;

    // Token: 0x4000A60
    public string spellName;

    // Token: 0x4000A61
    public int targetSkillID;

    // Token: 0x4000A62
    public int costSpellNum;

    // Token: 0x4000A63
    public bool toEnemy;

    // Token: 0x4000A64
    public string spellEffectString;

    // Token: 0x4000A65
    public HeroSpeAddData spellSpeAddData;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000CA8
    // RVA   : 0x210B70   Offset: 0x20F370   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

}
