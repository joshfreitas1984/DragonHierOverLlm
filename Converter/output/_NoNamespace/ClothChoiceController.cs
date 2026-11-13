// ============================================================
// Type  : ClothChoiceController
// Token : 0x2000255
// ============================================================

public class ClothChoiceController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40012B3
    public int skinID;

    // Token: 0x40012B4
    public int skinLv;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600134A
    // RVA   : 0x6FDC50   Offset: 0x6FCA50   Length: 0x54
    public void OnClick()
    {
        var pStatics = *(int64*)(DAT_181e55ae8 + 184);
        if (*pStatics != 0) {
          HeroDetailController.ClothChoiceButtonClicked
                    (*pStatics,this.skinID,
                     this.skinLv,0);
          return;
        }
    }

    // Token : 0x600134B
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

}
