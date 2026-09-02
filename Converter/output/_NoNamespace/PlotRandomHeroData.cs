// ============================================================
// Type  : PlotRandomHeroData
// Token : 0x20001FC
// ============================================================

public class PlotRandomHeroData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000DF3
    public SpeHeroLimit speHeroLimit;

    // Token: 0x4000DF4
    public AreaLimit areaLimit;

    // Token: 0x4000DF5
    public List<int> areaID;

    // Token: 0x4000DF6
    public List<int> favorRange;

    // Token: 0x4000DF7
    public SexLimit sexLimit;

    // Token: 0x4000DF8
    public ForceLimit forceLimit;

    // Token: 0x4000DF9
    public List<int> forceID;

    // Token: 0x4000DFA
    public ForceLvLimit forceLvLimit;

    // Token: 0x4000DFB
    public float forceLv;

    // Token: 0x4000DFC
    public LeaderLimit leaderLimit;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000FB1
    // RVA   : 0xBD94C0   Offset: 0xBD7CC0   Length: 0x9C
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

    // Token : 0x6000FB2
    // RVA   : 0xBD9340   Offset: 0xBD7B40   Length: 0x175
    public virtual object Clone()
    {
        long lVar2;
        ulong uVar3;
        ulong local_38;
        ulong uStack_30;
        uint local_28;
        uint uStack_24;
        uint uStack_20;
        uint32 uStack_1c;
        plVar1 = (int64 *)il2cpp_internal(DAT_181d63ff0);
        plVar4 = plVar1;
        MemoryStream.ctor(plVar1,1000,0);
        local_38 = 0;
        uStack_30 = 0;
        StreamingContext.ctor(&local_38,64,0);
        lVar2 = il2cpp_internal(DAT_181d8c5a8);
        local_28 = (uint32)local_38;
        uStack_24 = local_38._4_4_;
        uStack_20 = (uint32)uStack_30;
        uStack_1c = uStack_30._4_4_;
        BinaryFormatter.ctor(lVar2,0,&local_28,0,plVar4);
        if (lVar2 != null) {
          BinaryFormatter.Serialize(lVar2,plVar1,this,0);
          if (plVar1 != (int64 *)0) {
            (**(code **)(*plVar1 + 0x2c8))(plVar1,0,0,*(uint64 *)(*plVar1 + 0x2d0));
            uVar3 = BinaryFormatter.Deserialize(lVar2,plVar1,0);
            (**(code **)(*plVar1 + 0x238))(plVar1,*(uint64 *)(*plVar1 + 0x240));
            FUN_180002970(0,DAT_181d53c70,plVar1);
            return uVar3;
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
    }

}
