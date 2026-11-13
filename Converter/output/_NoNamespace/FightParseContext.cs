// ============================================================
// Type  : FightParseContext
// Token : 0x2000177
// ============================================================

public class FightParseContext
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40009F7
    public int teamID;

    // Token: 0x40009F8
    public bool isSupport;

    // Token: 0x40009F9
    public List<HeroData> heroList;

    // Token: 0x40009FA
    public List<WaitSupportHero> waitHeros;

    // Token: 0x40009FB
    public List<WaitSupportForce> waitForces;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000C19
    // RVA   : 0x42F150   Offset: 0x42DF50   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

}
