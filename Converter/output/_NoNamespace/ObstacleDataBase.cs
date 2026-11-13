// ============================================================
// Type  : ObstacleDataBase
// Token : 0x200018C
// ============================================================

public class ObstacleDataBase
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000ABF
    public List<BattleMapType> availableMapType;

    // Token: 0x4000AC0
    public string obstacleName;

    // Token: 0x4000AC1
    public int obstacleSpriteIDNum;

    // Token: 0x4000AC2
    public List<int> obstacleHpRange;

    // Token: 0x4000AC3
    public int upOcclusionGrid;

    // Token: 0x4000AC4
    public List<ObstacleMapTypeRandomWeightDataBase> extraMapTypeRandomWeight;

    // Token: 0x4000AC5
    public string hitSound;

    // Token: 0x4000AC6
    public string destroySound;

    // Token: 0x4000AC7
    public string destroySpe;

    // Token: 0x4000AC8
    public float damageRate;

    // Token: 0x4000AC9
    public int injuryType;

    // Token: 0x4000ACA
    public float injuryNum;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000CA7
    // RVA   : 0x90D9A0   Offset: 0x90C7A0   Length: 0x175
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

    // Token : 0x6000CA8
    // RVA   : 0x90DB20   Offset: 0x90C920   Length: 0xB4
    public void /*ctor*/()
    {
        long lVar1;
        lVar1 = il2cpp_internal(DAT_181e73cb8);
        FUN_1810f3480(lVar1,DAT_181e71270);
        if (lVar1 != null) {
          FUN_181769fe0(lVar1,10,DAT_181e713f0);
          FUN_181769fe0(lVar1,50,DAT_181e713f0);
          this.obstacleHpRange = lVar1;
          ZhSegment.Initialize(this,0);
          return;
        }
    }

}
