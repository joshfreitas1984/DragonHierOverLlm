// ============================================================
// Type  : BattleData
// Token : 0x2000173
// ============================================================

public class BattleData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40009D5
    public int fightID;

    // Token: 0x40009D6
    public string describe;

    // Token: 0x40009D7
    public BattleType battleType;

    // Token: 0x40009D8
    public string mapTypeStr;

    // Token: 0x40009D9
    public string playerHeroStr;

    // Token: 0x40009DA
    public string playerSupportStr;

    // Token: 0x40009DB
    public string enemyHeroStr;

    // Token: 0x40009DC
    public string enemySupportStr;

    // Token: 0x40009DD
    public float supportEnterTime;

    // Token: 0x40009DE
    public int maxHeroNum;

    // Token: 0x40009DF
    public float timeLimit;

    // Token: 0x40009E0
    public bool includeTeamMate;

    // Token: 0x40009E1
    public bool randomTrophy;

    // Token: 0x40009E2
    public string trophyStr;

    // Token: 0x40009E3
    public string battlePlotStr;

    // Token: 0x40009E4
    public string fightEndCall;

    // Token: 0x40009E5
    public bool noSkip;

    // Token: 0x40009E6
    public bool forceSupportAndPlotEnter;

    // Token: 0x40009E7
    public int speControlTeamID;

    // Token: 0x40009E8
    public string preBattleActionStr;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000C04
    // RVA   : 0x5E3EF0   Offset: 0x5E2CF0   Length: 0xB
    public void /*ctor*/()
    {
        this.forceSupportAndPlotEnter = 1;
        ZhSegment.Initialize(this,0);
    }

}
