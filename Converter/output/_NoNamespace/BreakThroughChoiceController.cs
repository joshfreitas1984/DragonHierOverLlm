// ============================================================
// Type  : BreakThroughChoiceController
// Token : 0x20001A9
// ============================================================

public class BreakThroughChoiceController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000B9D
    public List<Sprite> iconSprites;

    // Token: 0x4000B9E
    public int rareLv;

    // Token: 0x4000B9F
    public HeroSpeAddData extraAddData;

    // Token: 0x4000BA0
    public int injuryType;

    // Token: 0x4000BA1
    public int injuryCost;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000D98
    // RVA   : 0x9F9180   Offset: 0x9F7F80   Length: 0xB6
    public void OnClick()
    {
        long lVar1;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181e937b0 + 184) + 8);
        if (lVar1 != null) {
          BreakThroughController.BreakThroughChoiceClicked(lVar1,this,0);
          return;
        }
    }

    // Token : 0x6000D99
    // RVA   : 0x9F9240   Offset: 0x9F8040   Length: 0x65
    public void /*ctor*/()
    {
        ulong uVar1;
        this.extraAddData = new HeroSpeAddData(0);
        FUN_180ae8740(this,0);
    }

}
