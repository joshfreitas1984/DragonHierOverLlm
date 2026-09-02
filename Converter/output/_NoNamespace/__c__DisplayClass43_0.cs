// ============================================================
// Type  : <>c__DisplayClass43_0
// Token : 0x2000293
// ============================================================

public class <>c__DisplayClass43_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001428
    public GambleUIController <>4__this;

    // Token: 0x4001429
    public int rerollID;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60014DD
    // RVA   : 0x210B70   Offset: 0x20F370   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x60014DE
    // RVA   : 0x8D73B0   Offset: 0x8D5BB0   Length: 0x24
    internal void <RerollButtonClicked>b__1()
    {
        if (this.<>4__this != 0) {
          GambleUIController.RerollPlayerDice
                    (this.<>4__this,this.rerollID,0);
          return;
        }
    }

    // Token : 0x60014DF
    // RVA   : 0x8D73E0   Offset: 0x8D5BE0   Length: 0x1D
    internal void <RerollButtonClicked>b__2()
    {
        if (this.<>4__this != 0) {
          GambleUIController.NextButtonClicked(this.<>4__this,0);
          return;
        }
    }

    // Token : 0x60014E0
    // RVA   : 0x8D73B0   Offset: 0x8D5BB0   Length: 0x24
    internal void <RerollButtonClicked>b__4()
    {
        if (this.<>4__this != 0) {
          GambleUIController.RerollPlayerDice
                    (this.<>4__this,this.rerollID,0);
          return;
        }
    }

    // Token : 0x60014E1
    // RVA   : 0x8D73E0   Offset: 0x8D5BE0   Length: 0x1D
    internal void <RerollButtonClicked>b__5()
    {
        if (this.<>4__this != 0) {
          GambleUIController.NextButtonClicked(this.<>4__this,0);
          return;
        }
    }

}
