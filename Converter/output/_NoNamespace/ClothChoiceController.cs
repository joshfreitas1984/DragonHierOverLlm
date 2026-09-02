// ============================================================
// Type  : ClothChoiceController
// Token : 0x200024B
// ============================================================

public class ClothChoiceController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40011F2
    public int skinID;

    // Token: 0x40011F3
    public int skinLv;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60012E5
    // RVA   : 0x9FC2E0   Offset: 0x9FAAE0   Length: 0x54
    public void OnClick()
    {
        var pStatics = *(int64*)(DAT_181d50f00 + 184);
        if (*pStatics != 0) {
          HeroDetailController.ClothChoiceButtonClicked
                    (*pStatics,this.skinID,
                     this.skinLv,0);
          return;
        }
    }

    // Token : 0x60012E6
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
