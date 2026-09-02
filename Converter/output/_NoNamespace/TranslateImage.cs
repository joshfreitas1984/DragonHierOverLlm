// ============================================================
// Type  : TranslateImage
// Token : 0x200039E
// ============================================================

public class TranslateImage
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001CA9
    public List<Sprite> targetSprite;

    // Token: 0x4001CAA
    private bool inited;

    // Token: 0x4001CAB
    private string nowLanguage;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600228F
    // RVA   : 0x245810   Offset: 0x244010   Length: 0x3
    private void Start()
    {
    }

    // Token : 0x6002290
    // RVA   : 0xA654C0   Offset: 0xA63CC0   Length: 0x1A9
    private void Update()
    {
        var pStatics = *(int64*)(DAT_181d4e010 + 184);
        long lVar1;
        bool cVar2;
        ulong uVar3;
        ulong uVar4;
        uint[] local_res18 = new uint[4];
        local_res18[0] = SceneManager.GetActiveScene(0);
        uVar3 = Scene.get_name(local_res18,0);
        cVar2 = String.op_Inequality(uVar3,"TitleScene",0);
        if (!cVar2) {
          uVar3 = this.nowLanguage;
          lVar1 = *(int64 *)(pStatics + 8);
          if ((lVar1 == null) || (lVar1 = *(int64 *)(lVar1 + 16)) == null) {
        LAB_180a65664:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          uVar4 = PlayerPrefDictionary.GetString(lVar1,"Language",0);
          cVar2 = String.op_Inequality(uVar3,uVar4,0);
          if (cVar2) {
            lVar1 = *(int64 *)(pStatics + 8);
            if ((lVar1 == null) || (lVar1 = *(int64 *)(lVar1 + 16)) == null) goto LAB_180a65664;
            uVar3 = PlayerPrefDictionary.GetString(lVar1,"Language",0);
            this.nowLanguage = uVar3;
            TranslateImage.AutoTranslateImage(this,0);
          }
        }
        else if (!this.inited) {
          this.inited = 1;
          TranslateImage.AutoTranslateImage(this,0);
          return;
        }
    }

    // Token : 0x6002291
    // RVA   : 0xA65340   Offset: 0xA63B40   Length: 0x170
    private void AutoTranslateImage()
    {
        long lVar1;
        long lVar2;
        bool cVar3;
        ulong uVar4;
        long lVar5;
        uVar4 = Component.GetComponent(this,DAT_181d6bc40);
        cVar3 = Object.op_Inequality(uVar4,0,0);
        if (!cVar3) {
          return;
        }
        lVar5 = Component.GetComponent(this,DAT_181d6bc40);
        lVar1 = this.targetSprite;
        lVar2 = *(int64 *)(*(int64 *)(DAT_181d4e010 + 184) + 8);
        if ((lVar2 != null) && (lVar2 = *(int64 *)(lVar2 + 16)) != null) {
          uVar4 = PlayerPrefDictionary.GetString(lVar2,"Language",0);
          cVar3 = FUN_1816fd990(uVar4,"CN",0);
          if (lVar1 != null) {
            if (lVar1.Count <= (uint32)(!cVar3)) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            if (lVar5 != null) {
              Image.set_sprite(lVar5,*(uint64 *)
                                       (lVar1._items + 32 +
                                       (uint64)(!cVar3) * 8),0);
              return;
            }
          }
        }
    }

    // Token : 0x6002292
    // RVA   : 0xA65670   Offset: 0xA63E70   Length: 0x47
    public void /*ctor*/()
    {
        this.nowLanguage = "CN";
        FUN_18044ef50(this,0);
    }

}
