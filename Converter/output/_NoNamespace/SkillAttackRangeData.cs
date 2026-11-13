// ============================================================
// Type  : SkillAttackRangeData
// Token : 0x2000236
// ============================================================

public class SkillAttackRangeData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40011C2
    public AttackRangeType rangeType;

    // Token: 0x40011C3
    public int minRange;

    // Token: 0x40011C4
    public int maxRange;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60012BF
    // RVA   : 0x6AC030   Offset: 0x6AAE30   Length: 0x44
    public void /*ctor*/(int type, int min, int max)
    {
        void SkillDamageRangeData.ctor
                     (int64 this,uint32 type,uint32 min,uint32 max)
        {
        ZhSegment.Initialize(this,0);
        this.rangeType = type;
        this.minRange = min;
        this.maxRange = max;
    }

    // Token : 0x60012C0
    // RVA   : 0x6ABEB0   Offset: 0x6AACB0   Length: 0x175
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
        plVar1 = (int64 *)il2cpp_internal(DAT_181e695f0);
        plVar4 = plVar1;
        MemoryStream.ctor(plVar1,1000,0);
        local_38 = 0;
        uStack_30 = 0;
        StreamingContext.ctor(&local_38,64,0);
        lVar2 = il2cpp_internal(DAT_181e91a00);
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
            FUN_180002280(0,DAT_181e58ab8,plVar1);
            return uVar3;
          }
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
    }

}
