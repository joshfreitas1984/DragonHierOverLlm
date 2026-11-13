// ============================================================
// Type  : <>c__DisplayClass42_0
// Token : 0x200029F
// ============================================================

public class <>c__DisplayClass42_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001513
    public int rerollID;

    // Token: 0x4001514
    public GambleUIController <>4__this;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001582
    // RVA   : 0x42F150   Offset: 0x42DF50   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x6001583
    // RVA   : 0x67FA50   Offset: 0x67E850   Length: 0x37
    internal void <NextButtonClicked>b__6()
    {
        if (this.<>4__this != 0) {
          GambleUIController.RerollEnemyDice
                    (this.<>4__this,this.rerollID,0);
          if (this.<>4__this != 0) {
            GambleUIController.ShowBetUI(this.<>4__this,0);
            return;
          }
        }
    }

    // Token : 0x6001584
    // RVA   : 0x67FA90   Offset: 0x67E890   Length: 0x24
    internal void <NextButtonClicked>b__8()
    {
        if (this.<>4__this != 0) {
          GambleUIController.RerollEnemyDice
                    (this.<>4__this,this.rerollID,0);
          return;
        }
    }

}
