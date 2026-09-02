// ============================================================
// Type  : RePlayerPrefData
// Token : 0x20001C5
// ============================================================

public class RePlayerPrefData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000BD4
    public PlayerPrefDictionary playerPrefData;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000E72
    // RVA   : 0xC58150   Offset: 0xC56950   Length: 0x65
    public void /*ctor*/()
    {
        ulong uVar1;
        ZhSegment.Initialize(this,0);
        this.playerPrefData = new PlayerPrefDictionary(0);
    }

}
