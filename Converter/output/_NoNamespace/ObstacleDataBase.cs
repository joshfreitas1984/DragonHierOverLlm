// ============================================================
// Type  : ObstacleDataBase
// Token : 0x200018A
// ============================================================

public class ObstacleDataBase
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000AB2
    public List<BattleMapType> availableMapType;

    // Token: 0x4000AB3
    public string obstacleName;

    // Token: 0x4000AB4
    public int obstacleSpriteIDNum;

    // Token: 0x4000AB5
    public List<int> obstacleHpRange;

    // Token: 0x4000AB6
    public int upOcclusionGrid;

    // Token: 0x4000AB7
    public List<ObstacleMapTypeRandomWeightDataBase> extraMapTypeRandomWeight;

    // Token: 0x4000AB8
    public string hitSound;

    // Token: 0x4000AB9
    public string destroySound;

    // Token: 0x4000ABA
    public string destroySpe;

    // Token: 0x4000ABB
    public float damageRate;

    // Token: 0x4000ABC
    public int injuryType;

    // Token: 0x4000ABD
    public float injuryNum;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000CA8
    // RVA   : 0xB90AB0   Offset: 0xB8FEB0   Length: 0x175
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

    // Token : 0x6000CA9
    // RVA   : 0xB90C30   Offset: 0xB90030   Length: 0xB4
    public void /*ctor*/()
    {
        long lVar1;
        lVar1 = il2cpp_internal(DAT_181d93ce8);
        FUN_181330100(lVar1,DAT_181d8f0b0);
        if (lVar1 != null) {
          FUN_18182a6c0(lVar1,10,DAT_181d8f230);
          FUN_18182a6c0(lVar1,50,DAT_181d8f230);
          this.obstacleHpRange = lVar1;
          ZhSegment.Initialize(this,0);
          return;
        }
    }

}
