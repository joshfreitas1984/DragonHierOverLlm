// ============================================================
// Type  : BigMapFollower
// Token : 0x200019C
// ============================================================

public class BigMapFollower
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000B3A
    public GameObject followerGameobj;

    // Token: 0x4000B3B
    public float range;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000D2C
    // RVA   : 0x794380   Offset: 0x793180   Length: 0x43
    public void /*ctor*/(GameObject _targetObj, float _range)
    {
        ZhSegment.Initialize(this,0);
        this.followerGameobj = _targetObj;
        this.range = _range;
    }

}
