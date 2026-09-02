// ============================================================
// Type  : AISettingData
// Token : 0x200012E
// ============================================================

public class AISettingData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400076A
    public int priorityLv;

    // Token: 0x400076B
    public int speFocusID;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60009B5
    // RVA   : 0xA07F70   Offset: 0xA06770   Length: 0x39
    public void /*ctor*/(int _priorityLv)
    {
        this.priorityLv = 1;
        this.speFocusID = 0xffffffff;
        ZhSegment.Initialize(this,0);
        this.priorityLv = _priorityLv;
        this.speFocusID = 0xffffffff;
    }

}
