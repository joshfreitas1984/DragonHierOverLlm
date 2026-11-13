// ============================================================
// Type  : RePlayerPrefData
// Token : 0x20001CD
// ============================================================

public class RePlayerPrefData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000C74
    public PlayerPrefDictionary playerPrefData;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000EAD
    // RVA   : 0xA62450   Offset: 0xA61250   Length: 0x65
    public void /*ctor*/()
    {
        ulong uVar1;
        ZhSegment.Initialize(this,0);
        this.playerPrefData = new PlayerPrefDictionary(0);
    }

}
