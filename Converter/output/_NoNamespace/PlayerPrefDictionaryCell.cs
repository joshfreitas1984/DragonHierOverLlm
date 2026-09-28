// ============================================================
// Type  : PlayerPrefDictionaryCell
// Token : 0x20001C9
// ============================================================

public class PlayerPrefDictionaryCell
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000C5E
    public string key;

    // Token: 0x4000C5F
    public string value;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000E9B
    // RVA   : 0x46D690   Offset: 0x46CA90   Length: 0x5A
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
        this.key = param_2;
        this.value = param_3;
    }

    // Token : 0x6000E9C
    // RVA   : 0x20FA30   Offset: 0x20EE30   Length: 0x4C
    public void /*ctor*/(string setKey, string setValue)
    {
        ZhSegment.Initialize(this,0);
        this.key = setKey;
        this.value = setValue;
    }

}
