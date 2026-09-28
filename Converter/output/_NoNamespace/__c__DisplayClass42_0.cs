// ============================================================
// Type  : <>c__DisplayClass42_0
// Token : 0x2000297
// ============================================================

public class <>c__DisplayClass42_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40014D0
    public int rerollID;

    // Token: 0x40014D1
    public GambleUIController <>4__this;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001516
    // RVA   : 0x210B70   Offset: 0x20FF70   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x6001517
    // RVA   : 0x939830   Offset: 0x938C30   Length: 0x37
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

    // Token : 0x6001518
    // RVA   : 0x939870   Offset: 0x938C70   Length: 0x24
    internal void <NextButtonClicked>b__8()
    {
        if (this.<>4__this != 0) {
          GambleUIController.RerollEnemyDice
                    (this.<>4__this,this.rerollID,0);
          return;
        }
    }

}
