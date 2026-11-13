// ============================================================
// Type  : RealTime
// Token : 0x2000091
// ============================================================

public class RealTime
{
    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000441
    // RVA   : 0xA6AD60   Offset: 0xA69B60   Length: 0x7
    public static float get_time()
    {
        Time.get_unscaledTime(0);
    }

    // Token : 0x6000442
    // RVA   : 0xA6AD50   Offset: 0xA69B50   Length: 0x7
    public static float get_deltaTime()
    {
        Time.get_unscaledDeltaTime(0);
    }

    // Token : 0x6000443
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

}
