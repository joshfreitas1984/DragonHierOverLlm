// ============================================================
// Type  : RePlayerPrefData
// Token : 0x20001CB
// ============================================================

public class RePlayerPrefData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000C61
    public PlayerPrefDictionary playerPrefData;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000EA7
    // RVA   : 0xD091E0   Offset: 0xD085E0   Length: 0x65
    public void /*ctor*/()
    {
        ulong uVar1;
        ZhSegment.Initialize(this,0);
        this.playerPrefData = new PlayerPrefDictionary(0);
    }

}
