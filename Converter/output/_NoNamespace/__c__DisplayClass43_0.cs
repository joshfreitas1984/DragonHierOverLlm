// ============================================================
// Type  : <>c__DisplayClass43_0
// Token : 0x20002A1
// ============================================================

public class <>c__DisplayClass43_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400151C
    public GambleUIController <>4__this;

    // Token: 0x400151D
    public int rerollID;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600158D
    // RVA   : 0x42F150   Offset: 0x42DF50   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x600158E
    // RVA   : 0x67FAC0   Offset: 0x67E8C0   Length: 0x24
    internal void <RerollButtonClicked>b__1()
    {
        if (this.<>4__this != 0) {
          GambleUIController.RerollPlayerDice
                    (this.<>4__this,this.rerollID,0);
          return;
        }
    }

    // Token : 0x600158F
    // RVA   : 0x67FAF0   Offset: 0x67E8F0   Length: 0x1D
    internal void <RerollButtonClicked>b__2()
    {
        if (this.<>4__this != 0) {
          GambleUIController.NextButtonClicked(this.<>4__this,0);
          return;
        }
    }

    // Token : 0x6001590
    // RVA   : 0x67FAC0   Offset: 0x67E8C0   Length: 0x24
    internal void <RerollButtonClicked>b__4()
    {
        if (this.<>4__this != 0) {
          GambleUIController.RerollPlayerDice
                    (this.<>4__this,this.rerollID,0);
          return;
        }
    }

    // Token : 0x6001591
    // RVA   : 0x67FAF0   Offset: 0x67E8F0   Length: 0x1D
    internal void <RerollButtonClicked>b__5()
    {
        if (this.<>4__this != 0) {
          GambleUIController.NextButtonClicked(this.<>4__this,0);
          return;
        }
    }

}
