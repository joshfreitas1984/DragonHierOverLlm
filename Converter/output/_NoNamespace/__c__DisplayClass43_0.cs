// ============================================================
// Type  : <>c__DisplayClass43_0
// Token : 0x2000299
// ============================================================

public class <>c__DisplayClass43_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40014D9
    public GambleUIController <>4__this;

    // Token: 0x40014DA
    public int rerollID;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001521
    // RVA   : 0x210B70   Offset: 0x20FF70   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x6001522
    // RVA   : 0x939F30   Offset: 0x939330   Length: 0x24
    internal void <RerollButtonClicked>b__1()
    {
        if (this.<>4__this != 0) {
          GambleUIController.RerollPlayerDice
                    (this.<>4__this,this.rerollID,0);
          return;
        }
    }

    // Token : 0x6001523
    // RVA   : 0x939F60   Offset: 0x939360   Length: 0x1D
    internal void <RerollButtonClicked>b__2()
    {
        if (this.<>4__this != 0) {
          GambleUIController.NextButtonClicked(this.<>4__this,0);
          return;
        }
    }

    // Token : 0x6001524
    // RVA   : 0x939F30   Offset: 0x939330   Length: 0x24
    internal void <RerollButtonClicked>b__4()
    {
        if (this.<>4__this != 0) {
          GambleUIController.RerollPlayerDice
                    (this.<>4__this,this.rerollID,0);
          return;
        }
    }

    // Token : 0x6001525
    // RVA   : 0x939F60   Offset: 0x939360   Length: 0x1D
    internal void <RerollButtonClicked>b__5()
    {
        if (this.<>4__this != 0) {
          GambleUIController.NextButtonClicked(this.<>4__this,0);
          return;
        }
    }

}
