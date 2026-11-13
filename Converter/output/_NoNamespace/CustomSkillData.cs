// ============================================================
// Type  : CustomSkillData
// Token : 0x2000235
// ============================================================

public class CustomSkillData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40011BF
    public KungfuSkillData skillData;

    // Token: 0x40011C0
    public string createHeroName;

    // Token: 0x40011C1
    public bool createByPlayer;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60012BE
    // RVA   : 0x42F150   Offset: 0x42DF50   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

}
