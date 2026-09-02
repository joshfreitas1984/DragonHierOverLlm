// ============================================================
// Type  : HudResourceShowData
// Token : 0x20002DB
// ============================================================

public class HudResourceShowData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40016FB
    public int id;

    // Token: 0x40016FC
    public float num;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60017F5
    // RVA   : 0x47A090   Offset: 0x478890   Length: 0x36
    public void /*ctor*/(int _id, float _num)
    {
        ZhSegment.Initialize(this,0);
        this.num = _num;
        this.id = _id;
    }

}
