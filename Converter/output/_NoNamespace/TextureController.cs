// ============================================================
// Type  : TextureController
// Token : 0x20003A9
// ============================================================

public class TextureController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001E08
    private Dictionary<string, SpriteAtlas> AtlasData;

    // Token: 0x4001E09
    public int GrassTileNum;

    // Token: 0x4001E0A
    public int RoadTileNum;

    // Token: 0x4001E0B
    private static TextureController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002399
    // RVA   : 0x814890   Offset: 0x813690   Length: 0x36
    public static TextureController get_Instance()
    {
        return **(uint64 **)(DAT_181e8b8e8 + 184);
    }

    // Token : 0x600239A
    // RVA   : 0x8144B0   Offset: 0x8132B0   Length: 0x124
    private void Awake()
    {
        bool cVar2;
        ulong uVar3;
        uVar3 = **(uint64 **)(DAT_181e8b8e8 + 184);
        cVar2 = Object.op_Equality(uVar3,0,0);
        if (!cVar2) {
          uVar3 = Component.get_gameObject(this,0);
          Object.Destroy(uVar3,0);
        }
        else {
          plVar1 = *(int64 **)(DAT_181e8b8e8 + 184);
          *plVar1 = this;
          il2cpp_internal(plVar1,this);
        }
        uVar3 = il2cpp_internal(DAT_181e63140);
        FUN_1806e5bc0(uVar3,DAT_181e56890);
        this.AtlasData = uVar3;
    }

    // Token : 0x600239B
    // RVA   : 0x814690   Offset: 0x813490   Length: 0x6C
    private void Init()
    {
        ulong uVar1;
        uVar1 = il2cpp_internal(DAT_181e63140);
        FUN_1806e5bc0(uVar1,DAT_181e56890);
        this.AtlasData = uVar1;
    }

    // Token : 0x600239C
    // RVA   : 0x814700   Offset: 0x813500   Length: 0x18E
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
          cVar2 = FUN_1806da450(this.AtlasData,atlasPath,DAT_181e569a0);
          if (!cVar2) {
            plVar3 = (int64 *)Resources.Load(atlasPath,0);
            if (plVar3 == (int64 *)0) {
              plVar6 = (int64 *)0;
            }
            else {
              plVar6 = plVar3;
            }
            if ((this.AtlasData != null) &&
               (FUN_1806da2f0(this.AtlasData,atlasPath,plVar6,DAT_181e56918),
               plVar6 != (int64 *)0)) {
              uVar4 = SpriteAtlas.GetSprite(plVar6,spriteName,0);
              return uVar4;
            }
          }
          else {
            if (this.AtlasData != null) {
              cVar2 = FUN_1806da450(this.AtlasData,atlasPath,DAT_181e569a0);
              if (!cVar2) {
                return 0;
              }
              if ((this.AtlasData != null) &&
                 (lVar5 = FUN_1817072e0(this.AtlasData,atlasPath,DAT_181e56a28)) != null)
              {
                uVar4 = SpriteAtlas.GetSprite(lVar5,spriteName,0);
                return uVar4;
              }
            }
          }
        }
    }

    // Token : 0x600239D
    // RVA   : 0x8145E0   Offset: 0x8133E0   Length: 0xAD
    private Sprite FindSpriteFromBuffer(string atlasPath, string spriteName)
    {
        uint64
        TextureController.FindSpriteFromBuffer(int64 this,uint64 atlasPath,uint64 spriteName)
        {
        char cVar1;
        int64 lVar2;
        uint64 uVar3;
        if (this.AtlasData != null) {
          cVar1 = FUN_1806da450(this.AtlasData,atlasPath,DAT_181e569a0);
          if (!cVar1) {
            return 0;
          }
          if (this.AtlasData != null) {
            lVar2 = FUN_1817072e0(this.AtlasData,atlasPath,DAT_181e56a28);
            if (lVar2 != null) {
              uVar3 = SpriteAtlas.GetSprite(lVar2,spriteName,0);
              return uVar3;
            }
          }
        }
    }

    // Token : 0x600239E
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

}
