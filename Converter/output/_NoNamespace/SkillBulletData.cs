// ============================================================
// Type  : SkillBulletData
// Token : 0x2000229
// ============================================================

public class SkillBulletData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40010D5
    public string bulletName;

    // Token: 0x40010D6
    public SkillBulletMoveType bulletMoveType;

    // Token: 0x40010D7
    public float bulletSpeed;

    // Token: 0x40010D8
    public SkillBulletRotationType bulletRotationType;

    // Token: 0x40010D9
    public float bulletRotateSpeed;

    // Token: 0x40010DA
    public float bulletScale;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001258
    // RVA   : 0x9712C0   Offset: 0x96FAC0   Length: 0x175
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

    // Token : 0x6001259
    // RVA   : 0x971440   Offset: 0x96FC40   Length: 0x23
    public void /*ctor*/()
    {
        void FUN_180971440(int64 this)
        {
        this.bulletSpeed = 0x41700000;
        this.bulletRotationType = 1;
        this.bulletRotateSpeed = 0x3f000000;
        this.bulletScale = 0x3f800000;
        ZhSegment.Initialize(this,0);
    }

}
