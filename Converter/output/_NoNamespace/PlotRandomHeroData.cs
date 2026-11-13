// ============================================================
// Type  : PlotRandomHeroData
// Token : 0x2000204
// ============================================================

public class PlotRandomHeroData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000E97
    public SpeHeroLimit speHeroLimit;

    // Token: 0x4000E98
    public AreaLimit areaLimit;

    // Token: 0x4000E99
    public List<int> areaID;

    // Token: 0x4000E9A
    public List<int> favorRange;

    // Token: 0x4000E9B
    public SexLimit sexLimit;

    // Token: 0x4000E9C
    public ForceLimit forceLimit;

    // Token: 0x4000E9D
    public List<int> forceID;

    // Token: 0x4000E9E
    public ForceLvLimit forceLvLimit;

    // Token: 0x4000E9F
    public float forceLv;

    // Token: 0x4000EA0
    public LeaderLimit leaderLimit;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000FF2
    // RVA   : 0x8B04B0   Offset: 0x8AF2B0   Length: 0x9C
    public void /*ctor*/(SpeHeroLimit _speHeroLimit, AreaLimit _areaLimit, List<int> _areaID, List<int> _favorRange, SexLimit _sexLimit, ForceLimit _forceLimit, List<int> _forceID, ForceLvLimit _forceLvLimit, float _forceLv, LeaderLimit _leaderLimit)
    {
        void PlotRandomHeroData.ctor
                     (int64 this,uint32 _speHeroLimit,uint32 _areaLimit,uint64 _areaID,
                     uint64 _favorRange,uint32 _sexLimit,uint32 _forceLimit,uint64 _forceID,
                     uint32 _forceLvLimit,uint32 _forceLv,uint32 _leaderLimit)
        {
        ZhSegment.Initialize(this,0);
        this.areaID = _areaID;
        this.speHeroLimit = _speHeroLimit;
        this.areaLimit = _areaLimit;
        this.favorRange = _favorRange;
        this.sexLimit = _sexLimit;
        this.forceLimit = _forceLimit;
        this.forceID = _forceID;
        this.forceLvLimit = _forceLvLimit;
        this.leaderLimit = _leaderLimit;
        this.forceLv = _forceLv;
    }

    // Token : 0x6000FF3
    // RVA   : 0x8B0300   Offset: 0x8AF100   Length: 0x1AB
    public virtual object Clone()
    {
        long lVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        lVar2 = new ZhSegment(0);
        uVar4 = 0;
        *(uint64 *)(lVar2 + 16) = 0;
        *(uint64 *)(lVar2 + 24) = 0;
        *(uint64 *)(lVar2 + 32) = 0;
        *(uint64 *)(lVar2 + 40) = 0;
        *(uint64 *)(lVar2 + 48) = 0;
        *(uint64 *)(lVar2 + 56) = 0;
        *(uint32 *)(lVar2 + 64) = 0;
        *(uint32 *)(lVar2 + 16) = this.speHeroLimit;
        *(uint32 *)(lVar2 + 20) = this.areaLimit;
        lVar1 = this.areaID;
        uVar3 = uVar4;
        if (lVar1 != null) {
          uVar3 = il2cpp_internal(DAT_181e73cb8);
          FUN_18177a7d0(uVar3,lVar1,DAT_181e712f0);
        }
        *(uint64 *)(lVar2 + 24) = uVar3;
        lVar1 = this.favorRange;
        uVar3 = uVar4;
        if (lVar1 != null) {
          uVar3 = il2cpp_internal(DAT_181e73cb8);
          FUN_18177a7d0(uVar3,lVar1,DAT_181e712f0);
        }
        *(uint64 *)(lVar2 + 32) = uVar3;
        *(uint32 *)(lVar2 + 40) = this.sexLimit;
        *(uint32 *)(lVar2 + 44) = this.forceLimit;
        lVar1 = this.forceID;
        if (lVar1 != null) {
          uVar4 = il2cpp_internal(DAT_181e73cb8);
          FUN_18177a7d0(uVar4,lVar1,DAT_181e712f0);
        }
        *(uint64 *)(lVar2 + 48) = uVar4;
        *(uint32 *)(lVar2 + 56) = this.forceLvLimit;
        *(uint32 *)(lVar2 + 60) = this.forceLv;
        *(uint32 *)(lVar2 + 64) = this.leaderLimit;
        return lVar2;
    }

}
