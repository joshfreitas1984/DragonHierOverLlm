// ============================================================
// Type  : AchievementData
// Token : 0x20001C3
// ============================================================

public class AchievementData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000C3E
    public string achName;

    // Token: 0x4000C3F
    public string achDescribe;

    // Token: 0x4000C40
    public AchDataType dataType;

    // Token: 0x4000C41
    public float goal;

    // Token: 0x4000C42
    public string tips;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000E94
    // RVA   : 0x210B70   Offset: 0x20FF70   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

}
