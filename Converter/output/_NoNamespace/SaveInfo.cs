// ============================================================
// Type  : SaveInfo
// Token : 0x20001C2
// ============================================================

public class SaveInfo
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000BCE
    public string SaveVersion;

    // Token: 0x4000BCF
    public string SaveDetail;

    // Token: 0x4000BD0
    public string SaveTime;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000E64
    // RVA   : 0x210B70   Offset: 0x20F370   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
        this.SaveVersion = param_2;
        this.SaveDetail = param_3;
        this.SaveTime = param_4;
    }

    // Token : 0x6000E65
    // RVA   : 0x2469F0   Offset: 0x2451F0   Length: 0x68
    public void /*ctor*/(string _SaveVersion, string _SaveDetail, string _SaveTime)
    {
        ZhSegment.Initialize(this,0);
        this.SaveVersion = _SaveVersion;
        this.SaveDetail = _SaveDetail;
        this.SaveTime = _SaveTime;
    }

}
