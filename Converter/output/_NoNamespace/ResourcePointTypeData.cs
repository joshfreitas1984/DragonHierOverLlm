// ============================================================
// Type  : ResourcePointTypeData
// Token : 0x20001F4
// ============================================================

public class ResourcePointTypeData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000DEF
    public int resourcePointTypeID;

    // Token: 0x4000DF0
    public string resourcePointTypeName;

    // Token: 0x4000DF1
    public List<float> changeResource;

    // Token: 0x4000DF2
    public ForceSpeAddData resourceSpeAddData;

    // Token: 0x4000DF3
    public HeroSpeAddData defenceSpeAddData;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000F93
    // RVA   : 0xD179F0   Offset: 0xD16DF0   Length: 0x164
    public void /*ctor*/()
    {
        long lVar1;
        ulong uVar2;
        ZhSegment.Initialize(this,0);
        lVar1 = il2cpp_internal(DAT_181d96ed0);
        FUN_18132faf0(lVar1,DAT_181da0cf8);
        if (lVar1 != null) {
          FUN_18181de10(lVar1,0,DAT_181da0df8);
          FUN_18181de10(lVar1,0,DAT_181da0df8);
          FUN_18181de10(lVar1,0,DAT_181da0df8);
          FUN_18181de10(lVar1,0,DAT_181da0df8);
          FUN_18181de10(lVar1,0,DAT_181da0df8);
          FUN_18181de10(lVar1,0,DAT_181da0df8);
          this.changeResource = lVar1;
          this.resourceSpeAddData = new ForceSpeAddData(0);
          this.defenceSpeAddData = new HeroSpeAddData(0);
          return;
        }
    }

    // Token : 0x6000F94
    // RVA   : 0xD17870   Offset: 0xD16C70   Length: 0x175
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
