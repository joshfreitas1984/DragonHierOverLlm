// ============================================================
// Type  : TextureController
// Token : 0x200039C
// ============================================================

public class TextureController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001D76
    private Dictionary<string, SpriteAtlas> AtlasData;

    // Token: 0x4001D77
    public int GrassTileNum;

    // Token: 0x4001D78
    public int RoadTileNum;

    // Token: 0x4001D79
    private static TextureController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60022EF
    // RVA   : 0xAA5550   Offset: 0xAA4950   Length: 0x36
    public static TextureController get_Instance()
    {
        return **(uint64 **)(DAT_181dab4a8 + 184);
    }

    // Token : 0x60022F0
    // RVA   : 0xAA5170   Offset: 0xAA4570   Length: 0x124
    private void Awake()
    {
        bool cVar2;
        ulong uVar3;
        uVar3 = **(uint64 **)(DAT_181dab4a8 + 184);
        cVar2 = Object.op_Equality(uVar3,0,0);
        if (!cVar2) {
          uVar3 = Component.get_gameObject(this,0);
          Object.Destroy(uVar3,0);
        }
        else {
          plVar1 = *(int64 **)(DAT_181dab4a8 + 184);
          *plVar1 = this;
          il2cpp_internal(plVar1,this);
        }
        uVar3 = il2cpp_internal(DAT_181d83300);
        FUN_1808b1370(uVar3,DAT_181d75610);
        this.AtlasData = uVar3;
    }

    // Token : 0x60022F1
    // RVA   : 0xAA5350   Offset: 0xAA4750   Length: 0x6C
    private void Init()
    {
        ulong uVar1;
        uVar1 = il2cpp_internal(DAT_181d83300);
        FUN_1808b1370(uVar1,DAT_181d75610);
        this.AtlasData = uVar1;
    }

    // Token : 0x60022F2
    // RVA   : 0xAA53C0   Offset: 0xAA47C0   Length: 0x18E
    public Sprite LoadAtlasSprite(string atlasPath, string spriteName)
    {
        uint64
        TextureController.LoadAtlasSprite(int64 this,uint64 atlasPath,uint64 spriteName)
        {
        bool bVar1;
        char cVar2;
        int64 *plVar3;
        uint64 uVar4;
        int64 lVar5;
        int64 *plVar6;
        if (this.AtlasData != null) {
          cVar2 = FUN_1808ab490(this.AtlasData,atlasPath,DAT_181d75720);
          if (!cVar2) {
            plVar3 = (int64 *)Resources.Load(atlasPath,0);
            if (plVar3 == (int64 *)0) {
              plVar6 = (int64 *)0;
            }
            else {
              plVar6 = plVar3;
            }
            if ((this.AtlasData != null) &&
               (FUN_1808ab370(this.AtlasData,atlasPath,plVar6,DAT_181d75698),
               plVar6 != (int64 *)0)) {
              uVar4 = SpriteAtlas.GetSprite(plVar6,spriteName,0);
              return uVar4;
            }
          }
          else {
            if (this.AtlasData != null) {
              cVar2 = FUN_1808ab490(this.AtlasData,atlasPath,DAT_181d75720);
              if (!cVar2) {
                return 0;
              }
              if ((this.AtlasData != null) &&
                 (lVar5 = FUN_1817c69b0(this.AtlasData,atlasPath,DAT_181d757a8)) != null)
              {
                uVar4 = SpriteAtlas.GetSprite(lVar5,spriteName,0);
                return uVar4;
              }
            }
          }
        }
    }

    // Token : 0x60022F3
    // RVA   : 0xAA52A0   Offset: 0xAA46A0   Length: 0xAD
    private Sprite FindSpriteFromBuffer(string atlasPath, string spriteName)
    {
        uint64
        TextureController.FindSpriteFromBuffer(int64 this,uint64 atlasPath,uint64 spriteName)
        {
        char cVar1;
        int64 lVar2;
        uint64 uVar3;
        if (this.AtlasData != null) {
          cVar1 = FUN_1808ab490(this.AtlasData,atlasPath,DAT_181d75720);
          if (!cVar1) {
            return 0;
          }
          if (this.AtlasData != null) {
            lVar2 = FUN_1817c69b0(this.AtlasData,atlasPath,DAT_181d757a8);
            if (lVar2 != null) {
              uVar3 = SpriteAtlas.GetSprite(lVar2,spriteName,0);
              return uVar3;
            }
          }
        }
    }

    // Token : 0x60022F4
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
