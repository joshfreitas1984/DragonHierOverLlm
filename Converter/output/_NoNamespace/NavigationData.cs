// ============================================================
// Type  : NavigationData
// Token : 0x2000188
// ============================================================

public class NavigationData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000A50
    public bool open;

    // Token: 0x4000A51
    public int F;

    // Token: 0x4000A52
    public int G;

    // Token: 0x4000A53
    public int H;

    // Token: 0x4000A54
    public GridUnitData thisGrid;

    // Token: 0x4000A55
    public NavigationData preGrid;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000C91
    // RVA   : 0x8C6B60   Offset: 0x8C5360   Length: 0x6D
    public void /*ctor*/()
    {
        this.open = 1;
        ZhSegment.Initialize(this,0);
        this.open = 1;
        this.F = 0;
        this.H = 0;
        if (this.thisGrid != null) {
          this.thisGrid.tempRef = 0;
          this.thisGrid = 0;
        }
        this.preGrid = 0;
    }

    // Token : 0x6000C92
    // RVA   : 0x8C6AF0   Offset: 0x8C52F0   Length: 0x62
    public void Reset()
    {
        this.open = 1;
        this.F = 0;
        this.H = 0;
        if (this.thisGrid != null) {
          this.thisGrid.tempRef = 0;
          this.thisGrid = 0;
        }
        this.preGrid = 0;
    }

}
