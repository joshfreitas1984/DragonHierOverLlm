// ============================================================
// Type  : TextureController
// Token : 0x2000395
// ============================================================

public class TextureController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001C70
    private Dictionary<string, SpriteAtlas> AtlasData;

    // Token: 0x4001C71
    public int GrassTileNum;

    // Token: 0x4001C72
    public int RoadTileNum;

    // Token: 0x4001C73
    private static TextureController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600226D
    // RVA   : 0xAC57B0   Offset: 0xAC3FB0   Length: 0x36
    public static TextureController get_Instance()
    {
        return **(uint64 **)(DAT_181d86270 + 184);
    }

    // Token : 0x600226E
    // RVA   : 0xAC53D0   Offset: 0xAC3BD0   Length: 0x124
    private void Awake()
    {
        bool cVar2;
        ulong uVar3;
        uVar3 = **(uint64 **)(DAT_181d86270 + 184);
        cVar2 = Object.op_Equality(uVar3,0,0);
        if (!cVar2) {
          uVar3 = Component.get_gameObject(this,0);
          Object.Destroy(uVar3,0);
        }
        else {
          plVar1 = *(int64 **)(DAT_181d86270 + 184);
          *plVar1 = this;
          il2cpp_internal(plVar1,this);
        }
        uVar3 = il2cpp_internal(DAT_181d5e7c8);
        FUN_1808ae540(uVar3,DAT_181d4f3d8);
        this.AtlasData = uVar3;
    }

    // Token : 0x600226F
    // RVA   : 0xAC55B0   Offset: 0xAC3DB0   Length: 0x6C
    private void Init()
    {
        ulong uVar1;
        uVar1 = il2cpp_internal(DAT_181d5e7c8);
        FUN_1808ae540(uVar1,DAT_181d4f3d8);
        this.AtlasData = uVar1;
    }

    // Token : 0x6002270
    // RVA   : 0xAC5620   Offset: 0xAC3E20   Length: 0x18E
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
          cVar2 = FUN_1808ab750(this.AtlasData,atlasPath,DAT_181d4f4d8);
          if (!cVar2) {
            plVar3 = (int64 *)Resources.Load(atlasPath,0);
            if (plVar3 == (int64 *)0) {
              plVar6 = (int64 *)0;
            }
            else {
              plVar6 = plVar3;
            }
            if ((this.AtlasData != null) &&
               (FUN_1808ab680(this.AtlasData,atlasPath,plVar6,DAT_181d4f458),
               plVar6 != (int64 *)0)) {
              uVar4 = SpriteAtlas.GetSprite(plVar6,spriteName,0);
              return uVar4;
            }
          }
          else {
            if (this.AtlasData != null) {
              cVar2 = FUN_1808ab750(this.AtlasData,atlasPath,DAT_181d4f4d8);
              if (!cVar2) {
                return 0;
              }
              if ((this.AtlasData != null) &&
                 (lVar5 = FUN_1817897a0(this.AtlasData,atlasPath,DAT_181d4f558)) != null)
              {
                uVar4 = SpriteAtlas.GetSprite(lVar5,spriteName,0);
                return uVar4;
              }
            }
          }
        }
    }

    // Token : 0x6002271
    // RVA   : 0xAC5500   Offset: 0xAC3D00   Length: 0xAD
    private Sprite FindSpriteFromBuffer(string atlasPath, string spriteName)
    {
        uint64
        TextureController.FindSpriteFromBuffer(int64 this,uint64 atlasPath,uint64 spriteName)
        {
        char cVar1;
        int64 lVar2;
        uint64 uVar3;
        if (this.AtlasData != null) {
          cVar1 = FUN_1808ab750(this.AtlasData,atlasPath,DAT_181d4f4d8);
          if (!cVar1) {
            return 0;
          }
          if (this.AtlasData != null) {
            lVar2 = FUN_1817897a0(this.AtlasData,atlasPath,DAT_181d4f558);
            if (lVar2 != null) {
              uVar3 = SpriteAtlas.GetSprite(lVar2,spriteName,0);
              return uVar3;
            }
          }
        }
    }

    // Token : 0x6002272
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
