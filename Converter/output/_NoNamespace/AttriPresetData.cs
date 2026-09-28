// ============================================================
// Type  : AttriPresetData
// Token : 0x2000371
// ============================================================

public class AttriPresetData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001C16
    public Sprite sprite;

    // Token: 0x4001C17
    public string name;

    // Token: 0x4001C18
    public string describe;

    // Token: 0x4001C19
    public bool recommend;

    // Token: 0x4001C1A
    public int leftAttriPoint;

    // Token: 0x4001C1B
    public int leftFightSkillPoint;

    // Token: 0x4001C1C
    public int leftLivingSkillPoint;

    // Token: 0x4001C1D
    public List<float> maxAttri;

    // Token: 0x4001C1E
    public List<float> maxFightSkill;

    // Token: 0x4001C1F
    public List<float> maxLivingSkill;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60021C2
    // RVA   : 0x210B70   Offset: 0x20FF70   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

}
