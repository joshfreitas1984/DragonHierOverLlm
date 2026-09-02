// ============================================================
// Type  : ObstacleData
// Token : 0x2000185
// ============================================================

public class ObstacleData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000A38
    public ObstacleType obstalceType;

    // Token: 0x4000A39
    public int obstacleID;

    // Token: 0x4000A3A
    public string obstacleName;

    // Token: 0x4000A3B
    public int obstacleSpriteID;

    // Token: 0x4000A3C
    public float obstacleHp;

    // Token: 0x4000A3D
    public float obstacleMaxHp;

    // Token: 0x4000A3E
    public int teamID;

    // Token: 0x4000A3F
    public bool bigObstacle;

    // Token: 0x4000A40
    public List<GridUnitData> targetGridUnit;

    // Token: 0x4000A41
    public bool needRefreshOcclusion;

    // Token: 0x4000A42
    public bool occlusionState;

    // Token: 0x4000A43
    public bool explodeObstacle;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000C7B
    // RVA   : 0x46E750   Offset: 0x46CF50   Length: 0x173
    public ObstacleDataBase GetObstacleDataBase()
    {
        var pStatics = *(int64*)(DAT_181d8b128 + 184);
        uint uVar1;
        long lVar2;
        if (!this.explodeObstacle) {
          lVar2 = *(int64 *)(pStatics + 80);
          if (lVar2 == null) throw; // [null/range check failed]
          lVar2 = *(int64 *)(lVar2 + 600);
        }
        else {
          lVar2 = *(int64 *)(pStatics + 80);
          if (lVar2 == null) throw; // [null/range check failed]
          lVar2 = *(int64 *)(lVar2 + 0x260);
        }
        if (lVar2 != null) {
          uVar1 = this.obstacleID;
          if (*(uint32 *)(lVar2 + 24) <= uVar1) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          return lVar2[uVar1];
        }
    }

    // Token : 0x6000C7C
    // RVA   : 0x46E5E0   Offset: 0x46CDE0   Length: 0x146
    public GridUnitData GetBaseGridUnitData()
    {
        int iVar1;
        long lVar2;
        long lVar3;
        long lVar4;
        uint uVar5;
        long lVar6;
        lVar3 = this.targetGridUnit;
        if (lVar3 != null) {
          lVar4 = lVar3;
          if (lVar3.Count == null) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
            lVar4 = this.targetGridUnit;
          }
          uVar5 = 1;
          lVar3 = *(int64 *)(lVar3._items + 32);
          if (lVar4 != null) {
            lVar6 = 40;
            while( true ) {
              if (lVar4.Count <= (int)uVar5) {
                return lVar3;
              }
              if (lVar4 == null) break;
              if (lVar4.Count <= uVar5) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar4 = *(int64 *)(lVar6 + lVar4._items);
              if (lVar4 == null) break;
              lVar2 = this.targetGridUnit;
              iVar1 = *(int *)(lVar4 + 40);
              if (lVar2 == null) break;
              if (lVar2.Count <= uVar5) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar4 = *(int64 *)(lVar6 + lVar2._items);
              if ((lVar4 == null) || (lVar3 == null)) break;
              if (*(int *)(lVar4 + 36) + iVar1 < *(int *)(lVar3 + 40) + *(int *)(lVar3 + 36)) {
                if (this.targetGridUnit == null) break;
                lVar3 = FUN_180002f80(this.targetGridUnit,uVar5,DAT_181d63bf8);
              }
              lVar4 = this.targetGridUnit;
              uVar5 = uVar5 + 1;
              lVar6 = lVar6 + 8;
              if (lVar4 == null) break;
            }
          }
        }
    }

    // Token : 0x6000C7D
    // RVA   : 0x46E730   Offset: 0x46CF30   Length: 0x18
    public float GetExtraExplodeRate()
    {
        if (this.bigObstacle) {
          return 0x3fc00000;
        }
        return 0x3f800000;
    }

    // Token : 0x6000C7E
    // RVA   : 0x46E8D0   Offset: 0x46D0D0   Length: 0xE7
    public void /*ctor*/(ObstacleType _obstalceType, int _obstacleID, string _name, int _obstacleSpriteID, float _hp, float _maxhp, int _teamID, bool _bigObstacle, bool _explodeObstacle)
    {
                             uint32 _obstacleSpriteID,uint32 _hp,uint32 _maxhp,uint32 _teamID,
                             uint8 _bigObstacle,uint8 _explodeObstacle)
        {
        uint64 uVar1;
        this.teamID = 0xffffffff;
        ZhSegment.Initialize(this,0);
        this.obstacleName = _name;
        this.obstalceType = _obstalceType;
        this.obstacleID = _obstacleID;
        this.obstacleSpriteID = _obstacleSpriteID;
        this.teamID = _teamID;
        this.bigObstacle = _bigObstacle;
        this.obstacleHp = _hp;
        this.obstacleMaxHp = _maxhp;
        uVar1 = il2cpp_internal(DAT_181d6e630);
        FUN_180f58a90(uVar1,DAT_181d63678);
        this.targetGridUnit = uVar1;
        this.explodeObstacle = _explodeObstacle;
        this.needRefreshOcclusion = 1;
    }

    // Token : 0x6000C7F
    // RVA   : 0x46E460   Offset: 0x46CC60   Length: 0x175
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
