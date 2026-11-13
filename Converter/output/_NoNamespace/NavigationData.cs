// ============================================================
// Type  : NavigationData
// Token : 0x2000190
// ============================================================

public class NavigationData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000AE3
    public bool open;

    // Token: 0x4000AE4
    public int F;

    // Token: 0x4000AE5
    public int G;

    // Token: 0x4000AE6
    public int H;

    // Token: 0x4000AE7
    public GridUnitData thisGrid;

    // Token: 0x4000AE8
    public NavigationData preGrid;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000CBF
    // RVA   : 0x6066B0   Offset: 0x6054B0   Length: 0x6D
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

    // Token : 0x6000CC0
    // RVA   : 0x606640   Offset: 0x605440   Length: 0x62
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
