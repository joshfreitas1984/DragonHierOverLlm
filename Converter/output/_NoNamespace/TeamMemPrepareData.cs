// ============================================================
// Type  : TeamMemPrepareData
// Token : 0x2000158
// ============================================================

public class TeamMemPrepareData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40008B1
    public int teamID;

    // Token: 0x40008B2
    public HeroData heroData;

    // Token: 0x40008B3
    public bool enterBattle;

    // Token: 0x40008B4
    public float enterBattleTime;

    // Token: 0x40008B5
    public float startMovePower;

    // Token: 0x40008B6
    public int enterSide;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000AF6
    // RVA   : 0xA9DCD0   Offset: 0xA9D0D0   Length: 0x76
    public void /*ctor*/(int _teamID, HeroData _heroData, bool _enterBattle, float _enterBattleTime, float _startMovePower, int _enterSide)
    {
        void TeamMemPrepareData.ctor
                     (int64 this,uint32 _teamID,uint64 _heroData,uint8 _enterBattle,
                     uint32 _enterBattleTime,uint32 _startMovePower,uint32 _enterSide)
        {
        this.enterSide = 0xffffffff;
        ZhSegment.Initialize(this,0);
        this.heroData = _heroData;
        this.teamID = _teamID;
        this.enterBattle = _enterBattle;
        this.enterBattleTime = _enterBattleTime;
        this.startMovePower = _startMovePower;
        this.enterSide = _enterSide;
    }

    // Token : 0x6000AF7
    // RVA   : 0xA9D990   Offset: 0xA9CD90   Length: 0x336
    public bool PrepareControlable()
    {
        uint uVar1;
        int iVar2;
        bool cVar3;
        long lVar4;
        ulong uVar5;
        lVar4 = this.heroData;
        if (lVar4 == null) throw; // [null/range check failed]
        if ((!lVar4.inTeam) || (lVar4.teamLeader != null)) {
          cVar3 = HeroData.IsPlayerSameForce(lVar4,0);
          if (cVar3) {
            if (((GameController._instance == null) ||
                (lVar4 = GameController._instance.worldData) == null) ||
               (lVar4 = WorldData.Player(lVar4,0)) == null) throw; // [null/range check failed]
            if (lVar4.isLeader) goto LAB_180a9daad;
          }
        LAB_180a9db81:
          uVar5 = *(uint64 *)(DAT_181db0260 + 184);
          if (uVar5.heroAISettingData == null) throw; // [null/range check failed]
          if (*(int *)(uVar5.heroAISettingData + 140) < 0) goto LAB_180a9dcb4;
          iVar2 = this.teamID;
          uVar5 = *(uint64 *)(DAT_181db0260 + 184);
          if (uVar5.heroAISettingData == null) throw; // [null/range check failed]
          if (iVar2 != *(int *)(uVar5.heroAISettingData + 140)) goto LAB_180a9dcb4;
        }
        else {
        LAB_180a9daad:

          if ((lVar4 = *(int64 *)(*(int64 *)(DAT_181db0260 + 184) + 80)?.heroFamilyName) == null) throw; // [null/range check failed]
          uVar1 = this.teamID;
          if (lVar4.summonLv <= uVar1) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar4 = lVar4.isSummon[uVar1];
          if (lVar4 == null) throw; // [null/range check failed]
          if (!lVar4.summonID) goto LAB_180a9db81;
        }
        uVar5 = this.heroData;
        if (uVar5 != 0) {
          if ((uVar5.heroID != null) && (!uVar5.fightProtectTarget)) {
            return CONCAT71((int7)(uVar5 >> 8),!uVar5.fightForceEnter);
          }
        LAB_180a9dcb4:
          return uVar5 & 0xffffffffffffff00;
        }
    }

}
