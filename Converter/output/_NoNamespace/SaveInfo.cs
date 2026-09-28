// ============================================================
// Type  : SaveInfo
// Token : 0x20001C8
// ============================================================

public class SaveInfo
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000C5B
    public string SaveVersion;

    // Token: 0x4000C5C
    public string SaveDetail;

    // Token: 0x4000C5D
    public string SaveTime;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000E99
    // RVA   : 0x210B70   Offset: 0x20FF70   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
        this.SaveVersion = param_2;
        this.SaveDetail = param_3;
        this.SaveTime = param_4;
    }

    // Token : 0x6000E9A
    // RVA   : 0x2469F0   Offset: 0x245DF0   Length: 0x68
    public void /*ctor*/(string _SaveVersion, string _SaveDetail, string _SaveTime)
    {
        ZhSegment.Initialize(this,0);
        this.SaveVersion = _SaveVersion;
        this.SaveDetail = _SaveDetail;
        this.SaveTime = _SaveTime;
    }

}
