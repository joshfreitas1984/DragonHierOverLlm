// ============================================================
// Type  : BreakThroughChoiceController
// Token : 0x20001A7
// ============================================================

public class BreakThroughChoiceController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000B8C
    public List<Sprite> iconSprites;

    // Token: 0x4000B8D
    public int rareLv;

    // Token: 0x4000B8E
    public HeroSpeAddData extraAddData;

    // Token: 0x4000B8F
    public int injuryType;

    // Token: 0x4000B90
    public int injuryCost;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000D95
    // RVA   : 0xC8FF00   Offset: 0xC8F300   Length: 0xB6
    public void OnClick()
    {
        long lVar1;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181db34e0 + 184) + 8);
        if (lVar1 != null) {
          BreakThroughController.BreakThroughChoiceClicked(lVar1,this,0);
          return;
        }
    }

    // Token : 0x6000D96
    // RVA   : 0xC8FFC0   Offset: 0xC8F3C0   Length: 0x65
    public void /*ctor*/()
    {
        ulong uVar1;
        this.extraAddData = new HeroSpeAddData(0);
        FUN_18044ef50(this,0);
    }

}
