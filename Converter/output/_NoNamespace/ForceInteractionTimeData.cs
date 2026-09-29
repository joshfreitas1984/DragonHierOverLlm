// ============================================================
// Type  : ForceInteractionTimeData
// Token : 0x200021B
// ============================================================

public class ForceInteractionTimeData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000F71
    public int addFavorTime;

    // Token: 0x4000F72
    public int reduceFavorTime;

    // Token: 0x4000F73
    public int stealResourceTime;

    // Token: 0x4000F74
    public int giveGiftTime;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600107D
    // RVA   : 0x77B100   Offset: 0x77A500   Length: 0x1D
    public void ResetTime()
    {
        void FUN_18077b100(int64 this)
        {
        this.addFavorTime = 1;
        this.reduceFavorTime = 1;
        this.stealResourceTime = 1;
        this.giveGiftTime = 1;
    }

    // Token : 0x600107E
    // RVA   : 0x77B120   Offset: 0x77A520   Length: 0x32
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
        this.addFavorTime = 1;
        this.reduceFavorTime = 1;
        this.stealResourceTime = 1;
        this.giveGiftTime = 1;
    }

    // Token : 0x600107F
    // RVA   : 0x77AF80   Offset: 0x77A380   Length: 0x175
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
        plVar1 = (int64 *)il2cpp_internal(DAT_181d89228);
        plVar4 = plVar1;
        MemoryStream.ctor(plVar1,1000,0);
        local_38 = 0;
        uStack_30 = 0;
        StreamingContext.ctor(&local_38,64,0);
        lVar2 = il2cpp_internal(DAT_181db1748);
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
            FUN_180002970(0,DAT_181d78db8,plVar1);
            return uVar3;
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
    }

}
