// ============================================================
// Type  : HudResourceShowData
// Token : 0x20002EA
// ============================================================

public class HudResourceShowData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001804
    public int id;

    // Token: 0x4001805
    public float num;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60018B5
    // RVA   : 0x212850   Offset: 0x211650   Length: 0x36
    public void /*ctor*/(int _id, float _num)
    {
        ZhSegment.Initialize(this,0);
        this.num = _num;
        this.id = _id;
    }

}
