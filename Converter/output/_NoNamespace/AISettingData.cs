// ============================================================
// Type  : AISettingData
// Token : 0x2000132
// ============================================================

public class AISettingData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000789
    public int priorityLv;

    // Token: 0x400078A
    public int speFocusID;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60009D5
    // RVA   : 0xA19710   Offset: 0xA18B10   Length: 0x39
    public void /*ctor*/(int _priorityLv)
    {
        this.priorityLv = 1;
        this.speFocusID = 0xffffffff;
        ZhSegment.Initialize(this,0);
        this.priorityLv = _priorityLv;
        this.speFocusID = 0xffffffff;
    }

}
