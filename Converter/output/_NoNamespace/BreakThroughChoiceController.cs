// ============================================================
// Type  : BreakThroughChoiceController
// Token : 0x20001A1
// ============================================================

public class BreakThroughChoiceController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000B00
    public List<Sprite> iconSprites;

    // Token: 0x4000B01
    public int rareLv;

    // Token: 0x4000B02
    public HeroSpeAddData extraAddData;

    // Token: 0x4000B03
    public int injuryType;

    // Token: 0x4000B04
    public int injuryCost;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000D61
    // RVA   : 0xCE9C00   Offset: 0xCE8400   Length: 0xB6
    public void OnClick()
    {
        long lVar1;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d8e338 + 184) + 8);
        if (lVar1 != null) {
          BreakThroughController.BreakThroughChoiceClicked(lVar1,this,0);
          return;
        }
    }

    // Token : 0x6000D62
    // RVA   : 0xCE9CC0   Offset: 0xCE84C0   Length: 0x65
    public void /*ctor*/()
    {
        ulong uVar1;
        this.extraAddData = new HeroSpeAddData(0);
        FUN_18044ef50(this,0);
    }

}
