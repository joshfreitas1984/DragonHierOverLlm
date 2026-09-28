// ============================================================
// Type  : TranslateImage
// Token : 0x20003A5
// ============================================================

public class TranslateImage
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001DAE
    public List<Sprite> targetSprite;

    // Token: 0x4001DAF
    private bool inited;

    // Token: 0x4001DB0
    private int nowLanguageVersion;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002311
    // RVA   : 0x245810   Offset: 0x244C10   Length: 0x3
    private void Start()
    {
    }

    // Token : 0x6002312
    // RVA   : 0xADF0F0   Offset: 0xADE4F0   Length: 0x1A5
    private void Update()
    {
        var pStatics = *(int64*)(DAT_181d84898 + 184);
        int iVar1;
        bool cVar2;
        ulong uVar3;
        uint[] local_res18 = new uint[4];
        local_res18[0] = SceneManager.GetActiveScene(0);
        uVar3 = Scene.get_name(local_res18,0);
        cVar2 = String.op_Inequality(uVar3,"TitleScene",0);
        if (!cVar2) {
          iVar1 = this.nowLanguageVersion;
          if (iVar1 != *(int *)(pStatics + 8)) {
            this.nowLanguageVersion = *(uint32 *)(pStatics + 8);
            TranslateImage.AutoTranslateImage(this,0);
            return;
          }
        }
        else if (!this.inited) {
          this.inited = 1;
          TranslateImage.AutoTranslateImage(this,0);
        }
    }

    // Token : 0x6002313
    // RVA   : 0xADEFD0   Offset: 0xADE3D0   Length: 0x116
    private void AutoTranslateImage()
    {
        long lVar1;
        bool cVar2;
        ulong uVar3;
        long lVar4;
        uVar3 = Component.GetComponent(this,DAT_181d94460);
        cVar2 = Object.op_Inequality(uVar3,0,0);
        if (!cVar2) {
          return;
        }
        lVar4 = Component.GetComponent(this,DAT_181d94460);
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

    // Token : 0x6002314
    // RVA   : 0xADF2A0   Offset: 0xADE6A0   Length: 0xE
    public void /*ctor*/()
    {
        void FUN_180adf2a0(int64 this)
        {
        this.nowLanguageVersion = 0xffffffff;
        FUN_18044ef50(this,0);
    }

}
