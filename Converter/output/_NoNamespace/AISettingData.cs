// ============================================================
// Type  : AISettingData
// Token : 0x200012E
// ============================================================

public class AISettingData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000766
    public int priorityLv;

    // Token: 0x4000767
    public int speFocusID;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60009B4
    // RVA   : 0x7817D0   Offset: 0x7805D0   Length: 0x39
    public void /*ctor*/(int _priorityLv)
    {
        this.priorityLv = 1;
        this.speFocusID = 0xffffffff;
        ZhSegment.Initialize(this,0);
        this.priorityLv = _priorityLv;
        this.speFocusID = 0xffffffff;
    }

}
