// ============================================================
// Type  : ForceInteractionTimeData
// Token : 0x2000215
// ============================================================

public class ForceInteractionTimeData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000EDB
    public int addFavorTime;

    // Token: 0x4000EDC
    public int reduceFavorTime;

    // Token: 0x4000EDD
    public int stealResourceTime;

    // Token: 0x4000EDE
    public int giveGiftTime;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001041
    // RVA   : 0x77E7F0   Offset: 0x77CFF0   Length: 0x1D
    public void ResetTime()
    {
        void FUN_18077e7f0(int64 this)
        {
        this.addFavorTime = 1;
        this.reduceFavorTime = 1;
        this.stealResourceTime = 1;
        this.giveGiftTime = 1;
    }

    // Token : 0x6001042
    // RVA   : 0x77E810   Offset: 0x77D010   Length: 0x32
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
        this.addFavorTime = 1;
        this.reduceFavorTime = 1;
        this.stealResourceTime = 1;
        this.giveGiftTime = 1;
    }

    // Token : 0x6001043
    // RVA   : 0x77E670   Offset: 0x77CE70   Length: 0x175
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
