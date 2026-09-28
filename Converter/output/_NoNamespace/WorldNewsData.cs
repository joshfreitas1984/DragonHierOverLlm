// ============================================================
// Type  : WorldNewsData
// Token : 0x20001D8
// ============================================================

public class WorldNewsData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000C96
    public string newsText;

    // Token: 0x4000C97
    public int leftTime;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000EC7
    // RVA   : 0x2562C0   Offset: 0x2556C0   Length: 0x41
    public void /*ctor*/(string _newsText, int _leftTime)
    {
        ZhSegment.Initialize(this,0);
        this.newsText = _newsText;
        this.leftTime = _leftTime;
    }

}
