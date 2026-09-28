// ============================================================
// Type  : SkillBulletData
// Token : 0x200022F
// ============================================================

public class SkillBulletData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001178
    public string bulletName;

    // Token: 0x4001179
    public SkillBulletMoveType bulletMoveType;

    // Token: 0x400117A
    public float bulletSpeed;

    // Token: 0x400117B
    public SkillBulletRotationType bulletRotationType;

    // Token: 0x400117C
    public float bulletRotateSpeed;

    // Token: 0x400117D
    public float bulletScale;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001298
    // RVA   : 0x983DD0   Offset: 0x9831D0   Length: 0x175
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

    // Token : 0x6001299
    // RVA   : 0x983F50   Offset: 0x983350   Length: 0x23
    public void /*ctor*/()
    {
        void FUN_180983f50(int64 this)
        {
        this.bulletSpeed = 0x41700000;
        this.bulletRotationType = 1;
        this.bulletRotateSpeed = 0x3f000000;
        this.bulletScale = 0x3f800000;
        ZhSegment.Initialize(this,0);
    }

}
