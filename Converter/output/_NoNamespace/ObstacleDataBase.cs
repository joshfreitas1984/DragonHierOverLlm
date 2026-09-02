// ============================================================
// Type  : ObstacleDataBase
// Token : 0x2000184
// ============================================================

public class ObstacleDataBase
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000A2C
    public List<BattleMapType> availableMapType;

    // Token: 0x4000A2D
    public string obstacleName;

    // Token: 0x4000A2E
    public int obstacleSpriteIDNum;

    // Token: 0x4000A2F
    public List<int> obstacleHpRange;

    // Token: 0x4000A30
    public int upOcclusionGrid;

    // Token: 0x4000A31
    public List<ObstacleMapTypeRandomWeightDataBase> extraMapTypeRandomWeight;

    // Token: 0x4000A32
    public string hitSound;

    // Token: 0x4000A33
    public string destroySound;

    // Token: 0x4000A34
    public string destroySpe;

    // Token: 0x4000A35
    public float damageRate;

    // Token: 0x4000A36
    public int injuryType;

    // Token: 0x4000A37
    public float injuryNum;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000C79
    // RVA   : 0x46E220   Offset: 0x46CA20   Length: 0x175
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

    // Token : 0x6000C7A
    // RVA   : 0x46E3A0   Offset: 0x46CBA0   Length: 0xB4
    public void /*ctor*/()
    {
        long lVar1;
        lVar1 = il2cpp_internal(DAT_181d6f030);
        FUN_180f58a90(lVar1,DAT_181d678f8);
        if (lVar1 != null) {
          FUN_181814fa0(lVar1,10,DAT_181d67a78);
          FUN_181814fa0(lVar1,50,DAT_181d67a78);
          this.obstacleHpRange = lVar1;
          ZhSegment.Initialize(this,0);
          return;
        }
    }

}
