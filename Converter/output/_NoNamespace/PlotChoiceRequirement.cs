// ============================================================
// Type  : PlotChoiceRequirement
// Token : 0x200032A
// ============================================================

public class PlotChoiceRequirement
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001A3D
    public ChoiceRequirementType requireType;

    // Token: 0x4001A3E
    public float requireNum;

    // Token: 0x4001A3F
    public bool autoChangeReuqireByDifficulty;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001A5B
    // RVA   : 0x212850   Offset: 0x211650   Length: 0x36
    public void /*ctor*/(ChoiceRequirementType _requireType, float _requireNum)
    {
        ZhSegment.Initialize(this,0);
        this.requireNum = _requireNum;
        this.requireType = _requireType;
    }

    // Token : 0x6001A5C
    // RVA   : 0x2127D0   Offset: 0x2115D0   Length: 0x7B
    public virtual object Clone()
    {
        uint uVar1;
        uint uVar2;
        long lVar3;
        uVar2 = this.requireType;
        uVar1 = this.requireNum;
        lVar3 = new ZhSegment(0);
        *(uint32 *)(lVar3 + 20) = uVar1;
        *(uint32 *)(lVar3 + 16) = uVar2;
        *(uint8 *)(lVar3 + 24) = this.autoChangeReuqireByDifficulty;
        return lVar3;
    }

}
