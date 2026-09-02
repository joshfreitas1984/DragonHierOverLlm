// ============================================================
// Type  : <>c__DisplayClass42_0
// Token : 0x2000291
// ============================================================

public class <>c__DisplayClass42_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400141F
    public int rerollID;

    // Token: 0x4001420
    public GambleUIController <>4__this;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60014D2
    // RVA   : 0x210B70   Offset: 0x20F370   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x60014D3
    // RVA   : 0x8D7340   Offset: 0x8D5B40   Length: 0x37
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

    // Token : 0x60014D4
    // RVA   : 0x8D7380   Offset: 0x8D5B80   Length: 0x24
    internal void <NextButtonClicked>b__8()
    {
        if (this.<>4__this != 0) {
          GambleUIController.RerollEnemyDice
                    (this.<>4__this,this.rerollID,0);
          return;
        }
    }

}
