// ============================================================
// Type  : BattlePrepareSpellData
// Token : 0x2000192
// ============================================================

public class BattlePrepareSpellData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000AE5
    public int id;

    // Token: 0x4000AE6
    public string spellName;

    // Token: 0x4000AE7
    public int targetSkillID;

    // Token: 0x4000AE8
    public int costSpellNum;

    // Token: 0x4000AE9
    public bool toEnemy;

    // Token: 0x4000AEA
    public string spellEffectString;

    // Token: 0x4000AEB
    public HeroSpeAddData spellSpeAddData;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000CD7
    // RVA   : 0x210B70   Offset: 0x20FF70   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

}
