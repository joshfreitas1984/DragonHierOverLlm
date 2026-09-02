// ============================================================
// Type  : AttriPresetData
// Token : 0x200036A
// ============================================================

public class AttriPresetData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001B15
    public Sprite sprite;

    // Token: 0x4001B16
    public string name;

    // Token: 0x4001B17
    public string describe;

    // Token: 0x4001B18
    public bool recommend;

    // Token: 0x4001B19
    public int leftAttriPoint;

    // Token: 0x4001B1A
    public int leftFightSkillPoint;

    // Token: 0x4001B1B
    public int leftLivingSkillPoint;

    // Token: 0x4001B1C
    public List<float> maxAttri;

    // Token: 0x4001B1D
    public List<float> maxFightSkill;

    // Token: 0x4001B1E
    public List<float> maxLivingSkill;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002141
    // RVA   : 0x210B70   Offset: 0x20F370   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

}
