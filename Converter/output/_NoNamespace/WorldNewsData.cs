// ============================================================
// Type  : WorldNewsData
// Token : 0x20001DA
// ============================================================

public class WorldNewsData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000CA9
    public string newsText;

    // Token: 0x4000CAA
    public int leftTime;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000ECD
    // RVA   : 0x71E8F0   Offset: 0x71D6F0   Length: 0x41
    public void /*ctor*/(string _newsText, int _leftTime)
    {
        ZhSegment.Initialize(this,0);
        this.newsText = _newsText;
        this.leftTime = _leftTime;
    }

}
