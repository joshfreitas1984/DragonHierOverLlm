// ============================================================
// Type  : RealTime
// Token : 0x2000091
// ============================================================

public class RealTime
{
    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000442
    // RVA   : 0xC60950   Offset: 0xC5F150   Length: 0x7
    public static float get_time()
    {
        Time.get_unscaledTime(0);
    }

    // Token : 0x6000443
    // RVA   : 0xC60940   Offset: 0xC5F140   Length: 0x7
    public static float get_deltaTime()
    {
        Time.get_unscaledDeltaTime(0);
    }

    // Token : 0x6000444
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
