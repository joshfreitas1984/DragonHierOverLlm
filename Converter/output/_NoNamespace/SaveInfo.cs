// ============================================================
// Type  : SaveInfo
// Token : 0x20001CA
// ============================================================

public class SaveInfo
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000C6D
    public string SaveVersion;

    // Token: 0x4000C6E
    public string SaveDetail;

    // Token: 0x4000C6F
    public string SaveTime;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000E9D
    // RVA   : 0x42F150   Offset: 0x42DF50   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
        this.SaveVersion = param_2;
        this.SaveDetail = param_3;
        this.SaveTime = param_4;
    }

    // Token : 0x6000E9E
    // RVA   : 0x6A01B0   Offset: 0x69EFB0   Length: 0x68
    public void /*ctor*/(string _SaveVersion, string _SaveDetail, string _SaveTime)
    {
        ZhSegment.Initialize(this,0);
        this.SaveVersion = _SaveVersion;
        this.SaveDetail = _SaveDetail;
        this.SaveTime = _SaveTime;
    }

}
