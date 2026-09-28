// ============================================================
// Type  : RealTime
// Token : 0x2000092
// ============================================================

public class RealTime
{
    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600045A
    // RVA   : 0xD11AF0   Offset: 0xD10EF0   Length: 0x7
    public static float get_time()
    {
        Time.get_unscaledTime(0);
    }

    // Token : 0x600045B
    // RVA   : 0xD11AE0   Offset: 0xD10EE0   Length: 0x7
    public static float get_deltaTime()
    {
        Time.get_unscaledDeltaTime(0);
    }

    // Token : 0x600045C
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
