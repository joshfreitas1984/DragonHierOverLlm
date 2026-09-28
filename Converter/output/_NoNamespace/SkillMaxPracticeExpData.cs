// ============================================================
// Type  : SkillMaxPracticeExpData
// Token : 0x200021D
// ============================================================

public class SkillMaxPracticeExpData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000F7E
    public int skillID;

    // Token: 0x4000F7F
    public float maxPracticeExp;

    // Token: 0x4000F80
    public List<float> maxReadExp;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001082
    // RVA   : 0x987240   Offset: 0x986640   Length: 0x101
    public void /*ctor*/(int _skillID)
    {
        long lVar1;
        ZhSegment.Initialize(this,0);
        this.skillID = _skillID;
        lVar1 = il2cpp_internal(DAT_181d96ed0);
        FUN_18132faf0(lVar1,DAT_181da0cf8);
        if (lVar1 != null) {
          FUN_18181de10(lVar1,0,DAT_181da0df8);
          FUN_18181de10(lVar1,0,DAT_181da0df8);
          FUN_18181de10(lVar1,0,DAT_181da0df8);
          FUN_18181de10(lVar1,0,DAT_181da0df8);
          FUN_18181de10(lVar1,0,DAT_181da0df8);
          FUN_18181de10(lVar1,0,DAT_181da0df8);
          this.maxReadExp = lVar1;
          return;
        }
    }

    // Token : 0x6001083
    // RVA   : 0x9870C0   Offset: 0x9864C0   Length: 0x175
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
        plVar1 = (int64 *)il2cpp_internal(DAT_181d89210);
        plVar4 = plVar1;
        MemoryStream.ctor(plVar1,1000,0);
        local_38 = 0;
        uStack_30 = 0;
        StreamingContext.ctor(&local_38,64,0);
        lVar2 = il2cpp_internal(DAT_181db1730);
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
            FUN_180002970(0,DAT_181d78da0,plVar1);
            return uVar3;
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
    }

}
