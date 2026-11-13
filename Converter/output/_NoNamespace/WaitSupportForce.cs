// ============================================================
// Type  : WaitSupportForce
// Token : 0x2000176
// ============================================================

public class WaitSupportForce
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40009EE
    public int teamID;

    // Token: 0x40009EF
    public int forceID;

    // Token: 0x40009F0
    public float time;

    // Token: 0x40009F1
    public int minLv;

    // Token: 0x40009F2
    public int maxLv;

    // Token: 0x40009F3
    public int maxNum;

    // Token: 0x40009F4
    public List<string> restrictHeroName;

    // Token: 0x40009F5
    public bool includeSpeHero;

    // Token: 0x40009F6
    public float randomChangeInjuryRate;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000C18
    // RVA   : 0x711DF0   Offset: 0x710BF0   Length: 0x20
    public void /*ctor*/()
    {
        this.minLv = 0xffffffff;
        this.maxLv = 99;
        this.maxNum = 999999;
        this.includeSpeHero = 1;
        ZhSegment.Initialize(this,0);
    }

}
