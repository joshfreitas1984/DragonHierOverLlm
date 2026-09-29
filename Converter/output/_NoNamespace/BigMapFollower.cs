// ============================================================
// Type  : BigMapFollower
// Token : 0x200019A
// ============================================================

public class BigMapFollower
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000B29
    public GameObject followerGameobj;

    // Token: 0x4000B2A
    public float range;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000D2B
    // RVA   : 0xA2C810   Offset: 0xA2BC10   Length: 0x43
    public void /*ctor*/(GameObject _targetObj, float _range)
    {
        ZhSegment.Initialize(this,0);
        this.followerGameobj = _targetObj;
        this.range = _range;
    }

}
