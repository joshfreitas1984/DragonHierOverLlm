// ============================================================
// Type  : BigMapFollower
// Token : 0x2000194
// ============================================================

public class BigMapFollower
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000AA2
    public GameObject followerGameobj;

    // Token: 0x4000AA3
    public float range;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000CFC
    // RVA   : 0xA1A590   Offset: 0xA18D90   Length: 0x43
    public void /*ctor*/(GameObject _targetObj, float _range)
    {
        ZhSegment.Initialize(this,0);
        this.followerGameobj = _targetObj;
        this.range = _range;
    }

}
