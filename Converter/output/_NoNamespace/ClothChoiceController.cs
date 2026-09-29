// ============================================================
// Type  : ClothChoiceController
// Token : 0x2000251
// ============================================================

public class ClothChoiceController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001295
    public int skinID;

    // Token: 0x4001296
    public int skinLv;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001326
    // RVA   : 0x99F310   Offset: 0x99E710   Length: 0x54
    public void OnClick()
    {
        var pStatics = *(int64*)(DAT_181d75f40 + 184);
        if (*pStatics != 0) {
          HeroDetailController.ClothChoiceButtonClicked
                    (*pStatics,this.skinID,
                     this.skinLv,0);
          return;
        }
    }

    // Token : 0x6001327
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
