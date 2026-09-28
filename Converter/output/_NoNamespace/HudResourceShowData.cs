// ============================================================
// Type  : HudResourceShowData
// Token : 0x20002E1
// ============================================================

public class HudResourceShowData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40017AF
    public int id;

    // Token: 0x40017B0
    public float num;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001839
    // RVA   : 0x46E160   Offset: 0x46D560   Length: 0x36
    public void /*ctor*/(int _id, float _num)
    {
        ZhSegment.Initialize(this,0);
        this.num = _num;
        this.id = _id;
    }

}
