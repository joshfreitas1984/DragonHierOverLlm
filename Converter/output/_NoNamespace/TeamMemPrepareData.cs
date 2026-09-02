// ============================================================
// Type  : TeamMemPrepareData
// Token : 0x2000154
// ============================================================

public class TeamMemPrepareData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400088A
    public int teamID;

    // Token: 0x400088B
    public HeroData heroData;

    // Token: 0x400088C
    public bool enterBattle;

    // Token: 0x400088D
    public float enterBattleTime;

    // Token: 0x400088E
    public float startMovePower;

    // Token: 0x400088F
    public int enterSide;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000AD3
    // RVA   : 0xABDF30   Offset: 0xABC730   Length: 0x76
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

    // Token : 0x6000AD4
    // RVA   : 0xABDBF0   Offset: 0xABC3F0   Length: 0x336
    public bool PrepareControlable()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
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
            if (((*pStatics == 0) ||
                (lVar4 = *(int64 *)(*pStatics + 32)) == null) ||
               (lVar4 = WorldData.Player(lVar4,0)) == null) throw; // [null/range check failed]
            if (lVar4.isLeader) goto LAB_180abdd0d;
          }
        LAB_180abdde1:
          uVar5 = *(uint64 *)(DAT_181d8b128 + 184);
          if (uVar5.heroAISettingData == null) throw; // [null/range check failed]
          if (*(int *)(uVar5.heroAISettingData + 140) < 0) goto LAB_180abdf14;
          iVar2 = this.teamID;
          uVar5 = *(uint64 *)(DAT_181d8b128 + 184);
          if (uVar5.heroAISettingData == null) throw; // [null/range check failed]
          if (iVar2 != *(int *)(uVar5.heroAISettingData + 140)) goto LAB_180abdf14;
        }
        else {
        LAB_180abdd0d:

          if ((lVar4 = *(int64 *)(*(int64 *)(DAT_181d8b128 + 184) + 80)?.heroFamilyName) == null) throw; // [null/range check failed]
          uVar1 = this.teamID;
          if (lVar4.summonLv <= uVar1) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar4 = lVar4.isSummon[uVar1];
          if (lVar4 == null) throw; // [null/range check failed]
          if (!lVar4.summonID) goto LAB_180abdde1;
        }
        uVar5 = this.heroData;
        if (uVar5 != 0) {
          if ((uVar5.heroID != null) && (!uVar5.fightProtectTarget)) {
            return CONCAT71((int7)(uVar5 >> 8),!uVar5.fightForceEnter);
          }
        LAB_180abdf14:
          return uVar5 & 0xffffffffffffff00;
        }
    }

}
