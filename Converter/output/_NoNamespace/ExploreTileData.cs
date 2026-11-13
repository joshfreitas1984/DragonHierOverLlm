// ============================================================
// Type  : ExploreTileData
// Token : 0x200027D
// ============================================================

public class ExploreTileData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40013F9
    public string name;

    // Token: 0x40013FA
    public string spriteName;

    // Token: 0x40013FB
    public int row;

    // Token: 0x40013FC
    public int column;

    // Token: 0x40013FD
    public SpriteRotateType spriteRotateType;

    // Token: 0x40013FE
    public bool spriteFlipX;

    // Token: 0x40013FF
    public bool spriteFlipY;

    // Token: 0x4001400
    public ExploreTileWallType wallType;

    // Token: 0x4001401
    public bool doorOpen;

    // Token: 0x4001402
    public bool eventHappen;

    // Token: 0x4001403
    public int exploreTileEventType;

    // Token: 0x4001404
    public float enemyDifficulty;

    // Token: 0x4001405
    public int enemyNum;

    // Token: 0x4001406
    public int targetResource;

    // Token: 0x4001407
    public ExploreTileGroundType exploreTileGroundType;

    // Token: 0x4001408
    public ExploreTileObstacleData exploreTileObstacleData;

    // Token: 0x4001409
    public bool seen;

    // Token: 0x400140A
    public bool moveAble;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001479
    // RVA   : 0x71DE80   Offset: 0x71CC80   Length: 0xE
    public void /*ctor*/()
    {
        this.targetResource = 0xffffffff;
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x600147A
    // RVA   : 0x8E90C0   Offset: 0x8E7EC0   Length: 0x175
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

}
