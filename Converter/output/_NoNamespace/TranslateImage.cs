// ============================================================
// Type  : TranslateImage
// Token : 0x20003B2
// ============================================================

public class TranslateImage
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001E41
    public List<Sprite> targetSprite;

    // Token: 0x4001E42
    private bool inited;

    // Token: 0x4001E43
    private int nowLanguageVersion;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60023BB
    // RVA   : 0x51CF50   Offset: 0x51BD50   Length: 0x3
    private void Start()
    {
    }

    // Token : 0x60023BC
    // RVA   : 0x834230   Offset: 0x833030   Length: 0x1A5
    private void Update()
    {
        int iVar1;
        bool cVar2;
        ulong uVar3;
        uint[] local_res18 = new uint[4];
        local_res18[0] = SceneManager.GetActiveScene(0);
        uVar3 = Scene.get_name(local_res18,0);
        cVar2 = String.op_Inequality(uVar3,"TitleScene",0);
        if (!cVar2) {
          iVar1 = this.nowLanguageVersion;
          if (iVar1 != LTLocalization.languageVersion) {
            this.nowLanguageVersion = LTLocalization.languageVersion;
            TranslateImage.AutoTranslateImage(this,0);
            return;
          }
        }
        else if (!this.inited) {
          this.inited = 1;
          TranslateImage.AutoTranslateImage(this,0);
        }
    }

    // Token : 0x60023BD
    // RVA   : 0x834110   Offset: 0x832F10   Length: 0x116
    private void AutoTranslateImage()
    {
        long lVar1;
        bool cVar2;
        ulong uVar3;
        long lVar4;
        uVar3 = Component.GetComponent(this,DAT_181e777b8);
        cVar2 = Object.op_Inequality(uVar3,0,0);
        if (!cVar2) {
          return;
        }
        lVar4 = Component.GetComponent(this,DAT_181e777b8);
        lVar1 = this.targetSprite;
        cVar2 = LTLocalization.get_IsChinese(0);
        if (lVar1 != null) {
          if (lVar1.Count <= (uint32)(!cVar2)) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          if (lVar4 != null) {
            Image.set_sprite(lVar4,*(uint64 *)
                                     (lVar1._items + 32 + (uint64)(!cVar2) * 8)
                              ,0);
            return;
          }
        }
    }

    // Token : 0x60023BE
    // RVA   : 0x8343E0   Offset: 0x8331E0   Length: 0xE
    public void /*ctor*/()
    {
        void FUN_1808343e0(int64 this)
        {
        this.nowLanguageVersion = 0xffffffff;
        FUN_180ae8740(this,0);
    }

}
