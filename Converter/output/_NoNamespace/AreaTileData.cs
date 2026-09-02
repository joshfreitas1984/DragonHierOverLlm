// ============================================================
// Type  : AreaTileData
// Token : 0x20001ED
// ============================================================

public class AreaTileData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000D56
    public string name;

    // Token: 0x4000D57
    public string spriteName;

    // Token: 0x4000D58
    public SpriteRotateType spriteRotateType;

    // Token: 0x4000D59
    public bool spriteFlipX;

    // Token: 0x4000D5A
    public bool spriteFlipY;

    // Token: 0x4000D5B
    public AreaBuildingData building;

    // Token: 0x4000D5C
    public AreaTileType tileType;

    // Token: 0x4000D5D
    public AreaRoadData areaRoadData;

    // Token: 0x4000D5E
    public int areaID;

    // Token: 0x4000D5F
    public int row;

    // Token: 0x4000D60
    public int column;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000F5B
    // RVA   : 0x7EFDA0   Offset: 0x7EE5A0   Length: 0x34
    public void /*ctor*/(int _areaID, AreaTileType _tileType)
    {
        ZhSegment.Initialize(this,0);
        this.areaID = _areaID;
        this.tileType = _tileType;
    }

    // Token : 0x6000F5C
    // RVA   : 0x7EFCE0   Offset: 0x7EE4E0   Length: 0xBE
    public AreaData GetArea()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        long lVar1;
        if ((*pStatics != 0) &&
           (lVar1 = *(int64 *)(*pStatics + 32)) != null) {
          WorldData.GetArea(lVar1,this.areaID,0);
          return;
        }
    }

    // Token : 0x6000F5D
    // RVA   : 0x7EFB60   Offset: 0x7EE360   Length: 0x175
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
