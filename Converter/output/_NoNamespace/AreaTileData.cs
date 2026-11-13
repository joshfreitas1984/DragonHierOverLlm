// ============================================================
// Type  : AreaTileData
// Token : 0x20001F5
// ============================================================

public class AreaTileData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000DF8
    public string name;

    // Token: 0x4000DF9
    public string spriteName;

    // Token: 0x4000DFA
    public SpriteRotateType spriteRotateType;

    // Token: 0x4000DFB
    public bool spriteFlipX;

    // Token: 0x4000DFC
    public bool spriteFlipY;

    // Token: 0x4000DFD
    public AreaBuildingData building;

    // Token: 0x4000DFE
    public AreaTileType tileType;

    // Token: 0x4000DFF
    public AreaRoadData areaRoadData;

    // Token: 0x4000E00
    public int areaID;

    // Token: 0x4000E01
    public int row;

    // Token: 0x4000E02
    public int column;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000F99
    // RVA   : 0x5204B0   Offset: 0x51F2B0   Length: 0x34
    public void /*ctor*/(int _areaID, AreaTileType _tileType)
    {
        ZhSegment.Initialize(this,0);
        this.areaID = _areaID;
        this.tileType = _tileType;
    }

    // Token : 0x6000F9A
    // RVA   : 0x5203F0   Offset: 0x51F1F0   Length: 0xBE
    public AreaData GetArea()
    {
        long lVar1;
        if ((GameController._instance != null) &&
           (lVar1 = GameController._instance.worldData) != null) {
          WorldData.GetArea(lVar1,this.areaID,0);
          return;
        }
    }

    // Token : 0x6000F9B
    // RVA   : 0x520270   Offset: 0x51F070   Length: 0x175
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
