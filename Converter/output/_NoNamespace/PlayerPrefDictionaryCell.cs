// ============================================================
// Type  : PlayerPrefDictionaryCell
// Token : 0x20001CB
// ============================================================

public class PlayerPrefDictionaryCell
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000C70
    public string key;

    // Token: 0x4000C71
    public string value;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000E9F
    // RVA   : 0x211D70   Offset: 0x210B70   Length: 0x5A
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
        this.key = param_2;
        this.value = param_3;
    }

    // Token : 0x6000EA0
    // RVA   : 0x211D20   Offset: 0x210B20   Length: 0x4C
    public void /*ctor*/(string setKey, string setValue)
    {
        ZhSegment.Initialize(this,0);
        this.key = setKey;
        this.value = setValue;
    }

}
