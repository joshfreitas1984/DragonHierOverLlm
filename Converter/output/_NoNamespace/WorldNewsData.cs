// ============================================================
// Type  : WorldNewsData
// Token : 0x20001D2
// ============================================================

public class WorldNewsData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000C09
    public string newsText;

    // Token: 0x4000C0A
    public int leftTime;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000E92
    // RVA   : 0x2562C0   Offset: 0x254AC0   Length: 0x41
    public void /*ctor*/(string _newsText, int _leftTime)
    {
        ZhSegment.Initialize(this,0);
        this.newsText = _newsText;
        this.leftTime = _leftTime;
    }

}
