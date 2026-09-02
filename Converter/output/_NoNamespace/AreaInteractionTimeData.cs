// ============================================================
// Type  : AreaInteractionTimeData
// Token : 0x20001F1
// ============================================================

public class AreaInteractionTimeData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000D74
    public int exploreTime;

    // Token: 0x4000D75
    public int patrolTime;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000F6F
    // RVA   : 0x7EE8E0   Offset: 0x7ED0E0   Length: 0xF
    public void ResetTime()
    {
        this.exploreTime = 1;
        this.patrolTime = 1;
    }

    // Token : 0x6000F70
    // RVA   : 0x7EE8F0   Offset: 0x7ED0F0   Length: 0x24
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
        this.exploreTime = 1;
        this.patrolTime = 1;
    }

    // Token : 0x6000F71
    // RVA   : 0x7EE760   Offset: 0x7ECF60   Length: 0x175
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
