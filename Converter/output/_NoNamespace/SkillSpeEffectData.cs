// ============================================================
// Type  : SkillSpeEffectData
// Token : 0x200022E
// ============================================================

public class SkillSpeEffectData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001181
    public string speName;

    // Token: 0x4001182
    public bool selfSpe;

    // Token: 0x4001183
    public SkillSpeEffectTargetType speEffectTargetType;

    // Token: 0x4001184
    public SkillSpeEffectTriggerType triggerType;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60012A7
    // RVA   : 0x6B0CB0   Offset: 0x6AFAB0   Length: 0x5A
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

    // Token : 0x60012A8
    // RVA   : 0x6B0B30   Offset: 0x6AF930   Length: 0x175
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
