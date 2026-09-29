// ============================================================
// Type  : SkillSpeEffectData
// Token : 0x200022C
// ============================================================

public class SkillSpeEffectData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400116B
    public string speName;

    // Token: 0x400116C
    public bool selfSpe;

    // Token: 0x400116D
    public SkillSpeEffectTargetType speEffectTargetType;

    // Token: 0x400116E
    public SkillSpeEffectTriggerType triggerType;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001296
    // RVA   : 0x989560   Offset: 0x988960   Length: 0x5A
    public void /*ctor*/(string _speName, bool _selfSpe, SkillSpeEffectTargetType _speEffectTargetType, SkillSpeEffectTriggerType _triggerType)
    {
        void SkillSpeEffectData.ctor
                     (int64 this,uint64 _speName,uint8 _selfSpe,uint32 _speEffectTargetType,
                     uint32 _triggerType)
        {
        ZhSegment.Initialize(this,0);
        this.speName = _speName;
        this.speEffectTargetType = _speEffectTargetType;
        this.triggerType = _triggerType;
        this.selfSpe = _selfSpe;
    }

    // Token : 0x6001297
    // RVA   : 0x9893E0   Offset: 0x9887E0   Length: 0x175
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
