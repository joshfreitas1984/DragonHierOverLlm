// ============================================================
// Type  : NavigationData
// Token : 0x200018E
// ============================================================

public class NavigationData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000AD6
    public bool open;

    // Token: 0x4000AD7
    public int F;

    // Token: 0x4000AD8
    public int G;

    // Token: 0x4000AD9
    public int H;

    // Token: 0x4000ADA
    public GridUnitData thisGrid;

    // Token: 0x4000ADB
    public NavigationData preGrid;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000CC0
    // RVA   : 0x8E6C10   Offset: 0x8E6010   Length: 0x6D
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

    // Token : 0x6000CC1
    // RVA   : 0x8E6BA0   Offset: 0x8E5FA0   Length: 0x62
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
