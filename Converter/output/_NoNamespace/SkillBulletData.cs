// ============================================================
// Type  : SkillBulletData
// Token : 0x2000231
// ============================================================

public class SkillBulletData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400118E
    public string bulletName;

    // Token: 0x400118F
    public SkillBulletMoveType bulletMoveType;

    // Token: 0x4001190
    public float bulletSpeed;

    // Token: 0x4001191
    public SkillBulletRotationType bulletRotationType;

    // Token: 0x4001192
    public float bulletRotateSpeed;

    // Token: 0x4001193
    public float bulletScale;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60012A9
    // RVA   : 0x6AC080   Offset: 0x6AAE80   Length: 0x175
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

    // Token : 0x60012AA
    // RVA   : 0x6AC200   Offset: 0x6AB000   Length: 0x23
    public void /*ctor*/()
    {
        void FUN_1806ac200(int64 this)
        {
        this.bulletSpeed = 0x41700000;
        this.bulletRotationType = 1;
        this.bulletRotateSpeed = 0x3f000000;
        this.bulletScale = 0x3f800000;
        ZhSegment.Initialize(this,0);
    }

}
