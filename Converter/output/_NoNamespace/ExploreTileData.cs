// ============================================================
// Type  : ExploreTileData
// Token : 0x2000270
// ============================================================

public class ExploreTileData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001318
    public string name;

    // Token: 0x4001319
    public string spriteName;

    // Token: 0x400131A
    public int row;

    // Token: 0x400131B
    public int column;

    // Token: 0x400131C
    public SpriteRotateType spriteRotateType;

    // Token: 0x400131D
    public bool spriteFlipX;

    // Token: 0x400131E
    public bool spriteFlipY;

    // Token: 0x400131F
    public ExploreTileWallType wallType;

    // Token: 0x4001320
    public bool doorOpen;

    // Token: 0x4001321
    public bool eventHappen;

    // Token: 0x4001322
    public int exploreTileEventType;

    // Token: 0x4001323
    public float enemyDifficulty;

    // Token: 0x4001324
    public int enemyNum;

    // Token: 0x4001325
    public int targetResource;

    // Token: 0x4001326
    public ExploreTileGroundType exploreTileGroundType;

    // Token: 0x4001327
    public ExploreTileObstacleData exploreTileObstacleData;

    // Token: 0x4001328
    public bool seen;

    // Token: 0x4001329
    public bool moveAble;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60013D0
    // RVA   : 0xB2A540   Offset: 0xB28D40   Length: 0xE
    public void /*ctor*/()
    {
        this.targetResource = 0xffffffff;
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x60013D1
    // RVA   : 0xB9E900   Offset: 0xB9D100   Length: 0x175
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
