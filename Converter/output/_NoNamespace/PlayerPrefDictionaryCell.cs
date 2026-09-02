// ============================================================
// Type  : PlayerPrefDictionaryCell
// Token : 0x20001C3
// ============================================================

public class PlayerPrefDictionaryCell
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000BD1
    public string key;

    // Token: 0x4000BD2
    public string value;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000E66
    // RVA   : 0x4795C0   Offset: 0x477DC0   Length: 0x5A
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
        this.key = param_2;
        this.value = param_3;
    }

    // Token : 0x6000E67
    // RVA   : 0x20FA30   Offset: 0x20E230   Length: 0x4C
    public void /*ctor*/(string setKey, string setValue)
    {
        ZhSegment.Initialize(this,0);
        this.key = setKey;
        this.value = setValue;
    }

}
