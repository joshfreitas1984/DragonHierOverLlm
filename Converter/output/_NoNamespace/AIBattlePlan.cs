// ============================================================
// Type  : AIBattlePlan
// Token : 0x2000245
// ============================================================

public class AIBattlePlan
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001227
    public AIBattlePlanType battlePlanType;

    // Token: 0x4001228
    public float bestPlanValue;

    // Token: 0x4001229
    public GridUnitData moveTarget;

    // Token: 0x400122A
    public ItemData useItem;

    // Token: 0x400122B
    public List<AIBattleAttackPlan> battleAttackPlan;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001304
    // RVA   : 0x13DA820   Offset: 0x13D9C20   Length: 0x7B
    public void /*ctor*/(AIBattlePlanType _battlePlanType)
    {
        ulong uVar1;
        ZhSegment.Initialize(this,0);
        this.battlePlanType = _battlePlanType;
        uVar1 = il2cpp_internal(DAT_181d907f8);
        FUN_181330100(uVar1,DAT_181d7a728);
        this.battleAttackPlan = uVar1;
    }

    // Token : 0x6001305
    // RVA   : 0x13DA6A0   Offset: 0x13D9AA0   Length: 0x175
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
