// ============================================================
// Type  : WorldData
// Token : 0x20001E4
// ============================================================

public class WorldData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000CD9
    public int chapter;

    // Token: 0x4000CDA
    public List<int> cityAreaID;

    // Token: 0x4000CDB
    public List<int> villageAreaID;

    // Token: 0x4000CDC
    public List<int> forceAreaID;

    // Token: 0x4000CDD
    public List<AreaData> Areas;

    // Token: 0x4000CDE
    public List<InnData> Inns;

    // Token: 0x4000CDF
    public List<ResourcePointData> ResourcePoints;

    // Token: 0x4000CE0
    public List<ForceData> Forces;

    // Token: 0x4000CE1
    public List<HeroData> Heros;

    // Token: 0x4000CE2
    public List<HeroData> TempHeros;

    // Token: 0x4000CE3
    public List<EventData> BigMapRandomEventDatas;

    // Token: 0x4000CE4
    public List<EventData> AreaMapRandomEventDatas;

    // Token: 0x4000CE5
    public int lastRandomWorldEventDay;

    // Token: 0x4000CE6
    public List<int> WorldEventDatasSaveRecord;

    // Token: 0x4000CE7
    public List<EventData> WorldEventDatas;

    // Token: 0x4000CE8
    public List<WorldNewsData> WorldNewsDatas;

    // Token: 0x4000CE9
    public List<MailData> MailDatas;

    // Token: 0x4000CEA
    public bool cheating;

    // Token: 0x4000CEB
    public bool cheated;

    // Token: 0x4000CEC
    public GameMode gameMode;

    // Token: 0x4000CED
    public int gameDifficulty;

    // Token: 0x4000CEE
    public bool relaxMode;

    // Token: 0x4000CEF
    public TimeData worldTime;

    // Token: 0x4000CF0
    public float TimeDifficulty;

    // Token: 0x4000CF1
    public float hour;

    // Token: 0x4000CF2
    public bool forceMeetingStarted;

    // Token: 0x4000CF3
    public bool forcePartyStarted;

    // Token: 0x4000CF4
    public int forceMeetingMissedTime;

    // Token: 0x4000CF5
    public int playerBetrayForceBadTime;

    // Token: 0x4000CF6
    public int playerGetTeacherTime;

    // Token: 0x4000CF7
    public int playerServantForceTime;

    // Token: 0x4000CF8
    public int playerReplaceForceTime;

    // Token: 0x4000CF9
    public List<InfoData> infos;

    // Token: 0x4000CFA
    public Dictionary<int, TimeData> plotHappened;

    // Token: 0x4000CFB
    public List<int> missionFinished;

    // Token: 0x4000CFC
    public PlotEventLogData PlotEventLog;

    // Token: 0x4000CFD
    public List<WorldPlotEventStartData> worldPlotEventStartData;

    // Token: 0x4000CFE
    public Dictionary<int, TimeData> worldPlotEventStartTime;

    // Token: 0x4000CFF
    public List<string> tutorialFinished;

    // Token: 0x4000D00
    public bool openLeaveForce;

    // Token: 0x4000D01
    public bool openForceBuilding;

    // Token: 0x4000D02
    public bool openForceAttackResource;

    // Token: 0x4000D03
    public bool openForceAttackArea;

    // Token: 0x4000D04
    public bool openForceAttackBasement;

    // Token: 0x4000D05
    public int monthCatchBadFamePlayerTime;

    // Token: 0x4000D06
    public int monthGambleTime;

    // Token: 0x4000D07
    public int monthPartyTime;

    // Token: 0x4000D08
    public int monthForcePartyTime;

    // Token: 0x4000D09
    public int monthDoctorTime;

    // Token: 0x4000D0A
    public int monthPerformForMoneyTime;

    // Token: 0x4000D0B
    public int monthCoachTime;

    // Token: 0x4000D0C
    public int monthAttackMartialClubTime;

    // Token: 0x4000D0D
    public int monthSpeReduceBadFameTime;

    // Token: 0x4000D0E
    public int monthSpeAddFameTime;

    // Token: 0x4000D0F
    public int monthSpeGetTalentPointTime;

    // Token: 0x4000D10
    public int monthChallengeTime;

    // Token: 0x4000D11
    public int monthBuyAreaInfoTime;

    // Token: 0x4000D12
    public int monthGiveMoneyToGovernTime;

    // Token: 0x4000D13
    public int monthBreakEquipTime;

    // Token: 0x4000D14
    public int monthKillTime;

    // Token: 0x4000D15
    public int monthFreshBountyTime;

    // Token: 0x4000D16
    public int monthFreshAuctionTime;

    // Token: 0x4000D17
    public int monthLeaderInteractOtherForceTime;

    // Token: 0x4000D18
    public List<List<ItemData>> showRoomItems;

    // Token: 0x4000D19
    public float showRoomChangeFame;

    // Token: 0x4000D1A
    public int nowWeather;

    // Token: 0x4000D1B
    public float weatherLastTime;

    // Token: 0x4000D1C
    public List<SkinUnlockData> skinUnlockData;

    // Token: 0x4000D1D
    public List<int> speBuildingUnlocked;

    // Token: 0x4000D1E
    public int finishForceMissionCount;

    // Token: 0x4000D1F
    public int totalFightCount;

    // Token: 0x4000D20
    public int totalWinFightCount;

    // Token: 0x4000D21
    public int totalEnemyKilled;

    // Token: 0x4000D22
    public float totalBadFame;

    // Token: 0x4000D23
    public int studyFightWithGreatHeroSingleWinNum;

    // Token: 0x4000D24
    public int studyFightWithGreatHeroMultiWinNum;

    // Token: 0x4000D25
    public int studyFightWithGreatHeroFinalWinNum;

    // Token: 0x4000D26
    public int totalHeroMeet;

    // Token: 0x4000D27
    public PrisonData prisonData;

    // Token: 0x4000D28
    public List<int> gameResultTriggered;

    // Token: 0x4000D29
    public List<BookWriterData> playerBookWriter;

    // Token: 0x4000D2A
    public int thisYearExploreSpeEventNum;

    // Token: 0x4000D2B
    public int thisYearExploreBigSpeEventNum;

    // Token: 0x4000D2C
    public ItemListData governStorage;

    // Token: 0x4000D2D
    public float battleTimeScale;

    // Token: 0x4000D2E
    public List<HeroTagDataBase> tempTagDataBase;

    // Token: 0x4000D2F
    public WeaponResearchData weaponResearchData;

    // Token: 0x4000D30
    public MeditationData meditationData;

    // Token: 0x4000D31
    public ForceSpeResearchData forceSpeResearchData;

    // Token: 0x4000D32
    public HeroSpeAddData forceSpeFunctionAddData;

    // Token: 0x4000D33
    public SpePoisonData getSpePoisonData;

    // Token: 0x4000D34
    public SpePoisonData combineSpePoisonData;

    // Token: 0x4000D35
    public ItemListData speBookStorage;

    // Token: 0x4000D36
    public HeroSpeAddData speBookStorageSpeAdd;

    // Token: 0x4000D37
    public SpeSummonResearchData speSummonResearchData;

    // Token: 0x4000D38
    public int speEnhanceStone;

    // Token: 0x4000D39
    public List<float> speSpellRate;

    // Token: 0x4000D3A
    public bool autoResearch;

    // Token: 0x4000D3B
    private ItemData playerAuctionItem;

    // Token: 0x4000D3C
    public ItemSortType itemSortType;

    // Token: 0x4000D3D
    public bool itemReverseOrder;

    // Token: 0x4000D3E
    public SkillSortType skillSortType;

    // Token: 0x4000D3F
    public bool skillReverseOrder;

    // Token: 0x4000D40
    public CustomDifficultyData customDifficultyData;

    // Token: 0x4000D41
    public Dictionary<int, HeroData> HerosDict;

    // Token: 0x4000D42
    private readonly object herosDictLock;

    // Token: 0x4000D43
    public Dictionary<int, HeroData> TempHerosDict;

    // Token: 0x4000D44
    private readonly object tempHerosDictLock;

    // Token: 0x4000D45
    public Dictionary<int, ForceData> ForcesDict;

    // Token: 0x4000D46
    public Dictionary<int, AreaData> AreasDict;

    // Token: 0x4000D47
    public Dictionary<int, ResourcePointData> resourcePointDict;

    // Token: 0x4000D48
    public Dictionary<int, InnData> innDict;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000EF6
    // RVA   : 0x9D06D0   Offset: 0x9CFAD0   Length: 0x8
    public ItemData get_PlayerAuctionItem()
    {
        uint64 FUN_1809d06d0(int64 this)
        {
        return this.playerAuctionItem;
    }

    // Token : 0x6000EF7
    // RVA   : 0x9D06E0   Offset: 0x9CFAE0   Length: 0xF
    public void set_PlayerAuctionItem(ItemData value)
    {
        void FUN_1809d06e0(int64 this,uint64 value)
        {
        this.playerAuctionItem = value;
    }

    // Token : 0x6000EF8
    // RVA   : 0x9CFDB0   Offset: 0x9CF1B0   Length: 0x918
    public void /*ctor*/()
    {
        ulong uVar1;
        long lVar2;
        long lVar3;
        this.battleTimeScale = 0x3f800000;
        uVar1 = il2cpp_internal(DAT_181d935d0);
        FUN_18132faf0(uVar1,DAT_181d8c798);
        this.tempTagDataBase = uVar1;
        this.weaponResearchData = new WeaponResearchData(0);
        this.meditationData = new MeditationData(0);
        this.forceSpeResearchData = new ForceSpeResearchData(0);
        this.forceSpeFunctionAddData = new HeroSpeAddData(0);
        this.getSpePoisonData = new SpePoisonData(0);
        this.combineSpePoisonData = new SpePoisonData(0);
        this.speBookStorage = new ItemListData(0);
        this.speBookStorageSpeAdd = new HeroSpeAddData(0);
        this.speSummonResearchData = new SpeSummonResearchData(0);
        lVar2 = il2cpp_internal(DAT_181d96ed0);
        FUN_18132faf0(lVar2,DAT_181da0cf8);
        if (lVar2 != null) {
          FUN_18181de10(lVar2,0,DAT_181da0df8);
          FUN_18181de10(lVar2,0,DAT_181da0df8);
          FUN_18181de10(lVar2,0,DAT_181da0df8);
          FUN_18181de10(lVar2,0,DAT_181da0df8);
          FUN_18181de10(lVar2,0,DAT_181da0df8);
          FUN_18181de10(lVar2,0,DAT_181da0df8);
          FUN_18181de10(lVar2,0,DAT_181da0df8);
          FUN_18181de10(lVar2,0,DAT_181da0df8);
          FUN_18181de10(lVar2,0,DAT_181da0df8);
          FUN_18181de10(lVar2,0,DAT_181da0df8);
          this.speSpellRate = lVar2;
          this.customDifficultyData = new CustomDifficultyData(0);
          this.herosDictLock = new ZhSegment(0);
          this.tempHerosDictLock = new ZhSegment(0);
          ZhSegment.Initialize(this,0);
          uVar1 = il2cpp_internal(DAT_181d90de0);
          FUN_18132faf0(uVar1,DAT_181d7c560);
          this.Areas = uVar1;
          uVar1 = il2cpp_internal(DAT_181d93bd0);
          FUN_18132faf0(uVar1,DAT_181d8ea98);
          this.Inns = uVar1;
          uVar1 = il2cpp_internal(DAT_181d96a50);
          FUN_18132faf0(uVar1,DAT_181d9f978);
          this.ResourcePoints = uVar1;
          uVar1 = il2cpp_internal(DAT_181d92c58);
          FUN_18132faf0(uVar1,DAT_181d87f20);
          this.Forces = uVar1;
          uVar1 = il2cpp_internal(DAT_181d93350);
          FUN_18132faf0(uVar1,DAT_181d8b418);
          this.Heros = uVar1;
          uVar1 = il2cpp_internal(DAT_181d93ad0);
          FUN_18132faf0(uVar1,DAT_181d8e518);
          this.infos = uVar1;
          uVar1 = il2cpp_internal(DAT_181d93350);
          FUN_18132faf0(uVar1,DAT_181d8b418);
          this.TempHeros = uVar1;
          lVar2 = il2cpp_internal(DAT_181d901e0);
          FUN_18132faf0(lVar2,DAT_181d78a28);
          lVar3 = il2cpp_internal(DAT_181d940d0);
          FUN_18132faf0(lVar3,DAT_181d90998);
          if (lVar3 != null) {
            FUN_18181e0a0(lVar3,0,DAT_181d90a98);
            FUN_18181e0a0(lVar3,0,DAT_181d90a98);
            FUN_18181e0a0(lVar3,0,DAT_181d90a98);
            FUN_18181e0a0(lVar3,0,DAT_181d90a98);
            FUN_18181e0a0(lVar3,0,DAT_181d90a98);
            if (lVar2 != null) {
              FUN_18181e0a0(lVar2,lVar3,DAT_181d78aa8);
              lVar3 = il2cpp_internal(DAT_181d940d0);
              FUN_18132faf0(lVar3,DAT_181d90998);
              if (lVar3 != null) {
                FUN_18181e0a0(lVar3,0,DAT_181d90a98);
                FUN_18181e0a0(lVar3,0,DAT_181d90a98);
                FUN_18181e0a0(lVar3,0,DAT_181d90a98);
                FUN_18181e0a0(lVar3,0,DAT_181d90a98);
                FUN_18181e0a0(lVar3,0,DAT_181d90a98);
                FUN_18181e0a0(lVar2,lVar3,DAT_181d78aa8);
                lVar3 = il2cpp_internal(DAT_181d940d0);
                FUN_18132faf0(lVar3,DAT_181d90998);
                if (lVar3 != null) {
                  FUN_18181e0a0(lVar3,0,DAT_181d90a98);
                  FUN_18181e0a0(lVar3,0,DAT_181d90a98);
                  FUN_18181e0a0(lVar3,0,DAT_181d90a98);
                  FUN_18181e0a0(lVar3,0,DAT_181d90a98);
                  FUN_18181e0a0(lVar3,0,DAT_181d90a98);
                  FUN_18181e0a0(lVar2,lVar3,DAT_181d78aa8);
                  this.showRoomItems = lVar2;
                  uVar1 = il2cpp_internal(DAT_181d81a68);
                  FUN_1808b1370(uVar1,DAT_181dbf6c8);
                  this.plotHappened = uVar1;
                  uVar1 = il2cpp_internal(DAT_181d81a68);
                  FUN_1808b1370(uVar1,DAT_181dbf6c8);
                  this.worldPlotEventStartTime = uVar1;
                  uVar1 = il2cpp_internal(DAT_181d97750);
                  FUN_18132faf0(uVar1,DAT_181da3bd8);
                  this.tutorialFinished = uVar1;
                  uVar1 = il2cpp_internal(DAT_181d925d8);
                  FUN_18132faf0(uVar1,DAT_181d85aa0);
                  this.WorldEventDatas = uVar1;
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x6000EF9
    // RVA   : 0x9CDC50   Offset: 0x9CD050   Length: 0x2FF
    public int GetPlayerForceTotalArea()
    {
        var pStatics = *(int64*)(DAT_181d72cc8 + 184);
        int iVar1;
        bool cVar2;
        long lVar3;
        long lVar4;
        int iVar5;
        uint local_50;
        uint32 uStack_4c;
        uint32 uStack_48;
        uint32 uStack_44;
        int64 local_40;
        uint32 local_38;
        uint32 uStack_34;
        uint32 uStack_30;
        uint32 uStack_2c;
        int64 local_28;
        lVar3 = this.Heros;
        if (lVar3 != null) {
          if (lVar3.Count == null) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar3 = *(int64 *)(lVar3._items + 32);
          if (lVar3 != null) {
            lVar3 = HeroData.GetForce(lVar3,0,0);
            iVar5 = 0;
            if (lVar3 != null) {
              iVar5 = 0;
              if (((*pStatics == 0) ||
                  (lVar3 = *(int64 *)(*pStatics + 32)) == null) ||
                 (lVar3 = *(int64 *)(lVar3 + 48)) == null) throw; // [null/range check failed]
              FUN_1817eb420(&local_38,lVar3,DAT_181d7c660);
              local_50 = local_38;
              uStack_4c = uStack_34;
              uStack_48 = uStack_30;
              uStack_44 = uStack_2c;
              local_40 = local_28;
              while( true ) {
                cVar2 = FUN_180c74f00(&local_50,DAT_181d89e68);
                lVar3 = local_40;
                if (!cVar2) break;
                if (local_40 == 0) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                iVar1 = *(int *)(local_40 + 112);
                lVar4 = this.Heros;
                if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                if (lVar4.Count == null) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar4 = *(int64 *)(lVar4._items + 32);
                if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                if (iVar1 == *(int *)(lVar4 + 132)) goto LAB_1809cdebd;
                lVar4 = AreaData.GetForce(lVar3,0);
                if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                iVar1 = *(int *)(lVar4 + 60);
                lVar4 = WorldData.Player(this,0);
                if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                if (iVar1 == *(int *)(lVar4 + 132)) goto LAB_1809cdebd;
                lVar3 = AreaData.GetForce(lVar3,0);
                lVar4 = WorldData.Player(this,0);
                if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                if (lVar3 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                cVar2 = ForceData.IsAllyForce(lVar3,*(uint32 *)(lVar4 + 132),0);
                if (cVar2) {
        LAB_1809cdebd:
                  iVar5 = iVar5 + 1;
                }
              }
              ZhSegment.Initialize(&local_50,DAT_181d89de8);
            }
            return iVar5;
          }
        }
    }

    // Token : 0x6000EFA
    // RVA   : 0x9CDC20   Offset: 0x9CD020   Length: 0x2B
    public int GetPlayerForceMaxAttackTime()
    {
        int iVar1;
        iVar1 = WorldData.GetPlayerForceTotalArea(this,0);
        if (iVar1 < 35) {
          return (14 < iVar1) + true;
        }
        return '\x03';
    }

    // Token : 0x6000EFB
    // RVA   : 0x9CC960   Offset: 0x9CBD60   Length: 0x60
    public float GetAIForceDevelopSpeed()
    {
        float fVar1;
        int iVar2;
        float fVar3;
        iVar2 = this.gameDifficulty;
        fVar1 = this.TimeDifficulty;
        if (this.customDifficultyData != null) {
          fVar3 = (float)CustomDifficultyData.GetDifficultyRate(this.customDifficultyData,10);
          return fVar3 + ((float)iVar2 - 1.0) + fVar1 * 0.5;
        }
    }

    // Token : 0x6000EFC
    // RVA   : 0x9CCDF0   Offset: 0x9CC1F0   Length: 0xBF
    public string GetDifficlutyName()
    {
        uint uVar1;
        long lVar2;
        if (this.relaxMode) {
          return "轻松休闲";
        }
        lVar2 = *(int64 *)(*(int64 *)(DAT_181d73d40 + 184) + 192);
        if (lVar2 != null) {
          uVar1 = this.gameDifficulty;
          if (*(uint32 *)(lVar2 + 24) <= uVar1) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          return lVar2[uVar1];
        }
    }

    // Token : 0x6000EFD
    // RVA   : 0x9CB950   Offset: 0x9CAD50   Length: 0x15C
    public bool AddTempTag(HeroTagDataBase tempTag)
    {
        bool cVar1;
        long lVar2;
        long lVar3;
        uint uVar4;
        lVar2 = this.tempTagDataBase;
        uVar4 = 0;
        if (lVar2 != null) {
          lVar3 = 32;
          do {
            if (lVar2.Count <= (int)uVar4) {
              FUN_18181e0a0(lVar2,tempTag,DAT_181d8c818);
              return true;
            }
            if (lVar2 == null) break;
            if (lVar2.Count <= uVar4) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar2 = *(int64 *)(lVar3 + lVar2._items);
            if ((lVar2 == null) || (tempTag == null)) break;
            cVar1 = FUN_18171e540(lVar2.Count,*(uint64 *)(tempTag + 24),0);
            lVar2 = this.tempTagDataBase;
            if (cVar1) {
              if ((lVar2 != null) && (lVar2 = FUN_180002f80(lVar2,uVar4,DAT_181d8c918)) != null) {
                if (*(int *)(tempTag + 32) < *(int *)(lVar2 + 32)) {
                  return false;
                }
                if (this.tempTagDataBase != null) {
                  FUN_181829cd0(this.tempTagDataBase,uVar4,tempTag,DAT_181d8c998);
                  return true;
                }
              }
              break;
            }
            uVar4 = uVar4 + 1;
            lVar3 = lVar3 + 8;
          } while (lVar2 != null);
        }
    }

    // Token : 0x6000EFE
    // RVA   : 0x9CC600   Offset: 0x9CBA00   Length: 0xE8
    public HeroTagDataBase FindTempTag(string tagName)
    {
        bool cVar1;
        ulong uVar2;
        long lVar3;
        long lVar4;
        uint uVar5;
        lVar3 = this.tempTagDataBase;
        uVar5 = 0;
        if (lVar3 != null) {
          lVar4 = 32;
          do {
            if (lVar3.Count <= (int)uVar5) {
              return 0;
            }
            if (lVar3 == null) break;
            if (lVar3.Count <= uVar5) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar3 = *(int64 *)(lVar4 + lVar3._items);
            if (lVar3 == null) break;
            cVar1 = FUN_18171e540(lVar3.Count,tagName,0);
            lVar3 = this.tempTagDataBase;
            if (cVar1) {
              if (lVar3 != null) {
                uVar2 = FUN_180002f80(lVar3,uVar5,DAT_181d8c918);
                return uVar2;
              }
              break;
            }
            uVar5 = uVar5 + 1;
            lVar4 = lVar4 + 8;
          } while (lVar3 != null);
        }
    }

    // Token : 0x6000EFF
    // RVA   : 0x9CC520   Offset: 0x9CB920   Length: 0xDC
    public int FindTempTagID(string tagName)
    {
        bool cVar1;
        long lVar2;
        long lVar3;
        uint uVar4;
        lVar2 = this.tempTagDataBase;
        uVar4 = 0;
        if (lVar2 != null) {
          lVar3 = 32;
          do {
            if (lVar2.Count <= (int)uVar4) {
              return -1;
            }
            if (lVar2 == null) break;
            if (lVar2.Count <= uVar4) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar2 = *(int64 *)(lVar3 + lVar2._items);
            if (lVar2 == null) break;
            cVar1 = FUN_18171e540(lVar2.Count,tagName,0);
            if (cVar1) {
              return uVar4 + 10000;
            }
            lVar2 = this.tempTagDataBase;
            uVar4 = uVar4 + 1;
            lVar3 = lVar3 + 8;
          } while (lVar2 != null);
        }
    }

    // Token : 0x6000F00
    // RVA   : 0x9CBDE0   Offset: 0x9CB1E0   Length: 0x26A
    public void ClearTempTag(string tagName)
    {
        var pStatics = *(int64*)(DAT_181d72cc8 + 184);
        bool cVar1;
        long lVar2;
        uint uVar3;
        long lVar4;
        lVar2 = this.tempTagDataBase;
        uVar3 = 0;
        if (lVar2 != null) {
          lVar4 = 32;
          do {
            if (lVar2.Count <= (int)uVar3) {
              return;
            }
            if (lVar2 == null) break;
            if (lVar2.Count <= uVar3) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar2 = *(int64 *)(lVar4 + lVar2._items);
            if (lVar2 == null) break;
            cVar1 = FUN_18171e540(lVar2.Count,tagName,0);
            if (cVar1) {
              if (uVar3 + 10000 == -1) {
                return;
              }
              if ((*pStatics != 0) &&
                 (lVar2 = *(int64 *)(*pStatics + 32)) != null) {
                lVar2 = *(int64 *)(lVar2 + 80);
                if (lVar2 != null) {
                  if (lVar2.Count == null) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  lVar2 = *(int64 *)(lVar2._items + 32);
                  if (lVar2 != null) {
                    HeroData.RemoveTag(lVar2,uVar3 + 10000,1,0);
                    lVar2 = this.tempTagDataBase;
                    if (lVar2 != null) {
                      if (lVar2.Count <= uVar3) {
                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                      }
                      lVar4 = (int64)(int)uVar3 * 8 + 32;
                      lVar2 = *(int64 *)(lVar4 + lVar2._items);
                      if (lVar2 != null) {
                        *(uint32 *)(lVar2 + 32) = 0;
                        lVar2 = this.tempTagDataBase;
                        if (lVar2 != null) {
                          if (lVar2.Count <= uVar3) {
                            ThrowHelper.ThrowArgumentOutOfRangeException(0);
                          }
                          lVar2 = *(int64 *)(lVar4 + lVar2._items);
                          if ((lVar2 != null) && (lVar2 = *(int64 *)(lVar2 + 88)) != null) {
                            HeroSpeAddData.Reset(lVar2,0);
                            return;
                          }
                        }
                      }
                    }
                  }
                }
              }
              break;
            }
            lVar2 = this.tempTagDataBase;
            uVar3 = uVar3 + 1;
            lVar4 = lVar4 + 8;
          } while (lVar2 != null);
        }
    }

    // Token : 0x6000F01
    // RVA   : 0x9CB4B0   Offset: 0x9CA8B0   Length: 0xE1
    public void AddGameResultTriggered(int resultID)
    {
        bool cVar1;
        ulong uVar2;
        long lVar3;
        lVar3 = this.gameResultTriggered;
        if (lVar3 == null) {
          uVar2 = il2cpp_internal(DAT_181d93cd0);
          FUN_18132faf0(uVar2,DAT_181d8f098);
          this.gameResultTriggered = uVar2;
          lVar3 = this.gameResultTriggered;
          if (lVar3 != null)
          {
            }
            cVar1 = FUN_18182a3a0(lVar3,resultID,DAT_181d8f398);
            if (!cVar1) {
            if (this.gameResultTriggered == null) {
          }
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          FUN_18182a0b0(this.gameResultTriggered,resultID,DAT_181d8f218);
        }
    }

    // Token : 0x6000F02
    // RVA   : 0x9CE4A0   Offset: 0x9CD8A0   Length: 0x5C
    public bool HaveGameResultTriggered(int resultID)
    {
        long lVar1;
        lVar1 = this.gameResultTriggered;
        if (lVar1 == null) {
          return false;
        }
        return CONCAT71((int7)((uint64)lVar1 >> 8),0 < lVar1.Count);
    }

    // Token : 0x6000F03
    // RVA   : 0x9CE450   Offset: 0x9CD850   Length: 0x44
    public bool HaveGameResultTriggered()
    {
        long lVar1;
        lVar1 = this.gameResultTriggered;
        if (lVar1 == null) {
          return false;
        }
        return CONCAT71((int7)((uint64)lVar1 >> 8),0 < lVar1.Count);
    }

    // Token : 0x6000F04
    // RVA   : 0x9CEA80   Offset: 0x9CDE80   Length: 0x4E
    public HeroData Player()
    {
        long lVar1;
        lVar1 = this.Heros;
        if (lVar1 != null) {
          if (lVar1.Count == null) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          return *(uint64 *)(lVar1._items + 32);
        }
    }

    // Token : 0x6000F05
    // RVA   : 0x9CCF70   Offset: 0x9CC370   Length: 0xB9
    public int GetEventSaveID(EventData targetEvent)
    {
        int iVar1;
        long lVar2;
        int iVar3;
        ulong uVar4;
        if (targetEvent != null) {
          lVar2 = this.BigMapRandomEventDatas;
          if (*(char *)(targetEvent + 56) == false) {
            if (lVar2 != null) {
              uVar4 = FUN_1817eb4e0(lVar2,targetEvent,DAT_181d85c20);
              return uVar4;
            }
          }
          else if (lVar2 != null) {
            iVar1 = lVar2.Count;
            if (this.AreaMapRandomEventDatas != null) {
              iVar3 = FUN_1817eb4e0(this.AreaMapRandomEventDatas,targetEvent,DAT_181d85c20);
              return (uint64)(uint32)(iVar3 + iVar1);
            }
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        return 0xffffffff;
    }

    // Token : 0x6000F06
    // RVA   : 0x9CCEB0   Offset: 0x9CC2B0   Length: 0xB8
    public EventData GetEventSaveIDEvent(int eventSaveID)
    {
        uint uVar1;
        long lVar2;
        if ((int)eventSaveID < 0) {
          return 0;
        }
        lVar2 = this.BigMapRandomEventDatas;
        if (lVar2 != null) {
          uVar1 = lVar2.Count;
          if ((int)eventSaveID < (int)uVar1) {
            if (uVar1 <= eventSaveID) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            return lVar2._items[eventSaveID];
          }
          lVar2 = this.AreaMapRandomEventDatas;
          if (lVar2 != null) {
            if (lVar2.Count <= eventSaveID - uVar1) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            return *(uint64 *)
                    (lVar2._items + 32 + (int64)(int)(eventSaveID - uVar1) * 8);
          }
        }
    }

    // Token : 0x6000F07
    // RVA   : 0x9CE780   Offset: 0x9CDB80   Length: 0x2F7
    internal void OnSerializingMethod(StreamingContext context)
    {
        int iVar1;
        long lVar2;
        long lVar3;
        int iVar4;
        ulong uVar5;
        long lVar6;
        uint uVar7;
        long lVar8;
        long lVar9;
        uint uVar10;
        uVar5 = il2cpp_internal(DAT_181d93cd0);
        FUN_18132faf0(uVar5,DAT_181d8f098);
        this.WorldEventDatasSaveRecord = uVar5;
        lVar6 = this.WorldEventDatas;
        uVar7 = 0;
        uVar10 = 0;
        if (lVar6 != null) {
          lVar8 = 32;
          lVar9 = 32;
          do {
            if (lVar6.Count <= (int)uVar10) {
              lVar6 = this.worldPlotEventStartData;
              if (lVar6 != null) goto LAB_1809ce960;
              break;
            }
            lVar2 = this.WorldEventDatasSaveRecord;
            if (lVar6 == null) break;
            if (lVar6.Count <= uVar10) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar6 = *(int64 *)(lVar6._items + lVar9);
            if (lVar6 == null) {
              iVar4 = -1;
            }
            else {
              lVar3 = this.BigMapRandomEventDatas;
              if (*(char *)(lVar6 + 56) == false) {
                if (lVar3 == null) break;
                iVar4 = FUN_1817eb4e0(lVar3,lVar6,DAT_181d85c20);
              }
              else {
                if (lVar3 == null) break;
                iVar1 = lVar3.Count;
                if (this.AreaMapRandomEventDatas == null) break;
                iVar4 = FUN_1817eb4e0(this.AreaMapRandomEventDatas,lVar6,DAT_181d85c20);
                iVar4 = iVar4 + iVar1;
              }
            }
            if (lVar2 == null) break;
            FUN_18182a0b0(lVar2,iVar4,DAT_181d8f218);
            lVar6 = this.WorldEventDatas;
            uVar10 = uVar10 + 1;
            lVar9 = lVar9 + 8;
          } while (lVar6 != null);
        }
        throw; // [null/range check failed]
        while( true ) {
          lVar9 = lVar6;
          if (lVar6.Count <= uVar7) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
            lVar9 = this.worldPlotEventStartData;
          }
          lVar6 = *(int64 *)(lVar8 + lVar6._items);
          if (lVar9 == null) break;
          if (lVar9.Count <= uVar7) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar9 = *(int64 *)(lVar8 + lVar9._items);
          if (lVar9 == null) break;
          lVar9 = *(int64 *)(lVar9 + 56);
          if (lVar9 == null) {
            iVar4 = -1;
          }
          else {
            lVar2 = this.BigMapRandomEventDatas;
            if (*(char *)(lVar9 + 56) == false) {
              if (lVar2 == null) break;
              iVar4 = FUN_1817eb4e0(lVar2,lVar9,DAT_181d85c20);
            }
            else {
              if (lVar2 == null) break;
              iVar1 = lVar2.Count;
              if (this.AreaMapRandomEventDatas == null) break;
              iVar4 = FUN_1817eb4e0(this.AreaMapRandomEventDatas,lVar9,DAT_181d85c20);
              iVar4 = iVar4 + iVar1;
            }
          }
          if (lVar6 == null) break;
          uVar7 = uVar7 + 1;
          *(int *)(lVar6 + 52) = iVar4;
          lVar6 = this.worldPlotEventStartData;
          lVar8 = lVar8 + 8;
          if (lVar6 == null) break;
        LAB_1809ce960:
          if (lVar6.Count <= (int)uVar7) {
            return;
          }
          if (lVar6 == null) break;
        }
    }

    // Token : 0x6000F08
    // RVA   : 0x9CE580   Offset: 0x9CD980   Length: 0x1FF
    internal void OnDeserializedMethod(StreamingContext context)
    {
        uint uVar1;
        ulong uVar2;
        long lVar3;
        uint uVar4;
        uint uVar5;
        long lVar6;
        long lVar7;
        lVar3 = this.WorldEventDatasSaveRecord;
        uVar5 = 0;
        uVar4 = 0;
        if (lVar3 != null) {
          lVar7 = 32;
          lVar6 = 32;
          do {
            if (lVar3.Count <= (int)uVar4) {
              lVar3 = this.worldPlotEventStartData;
              if (lVar3 != null) goto LAB_1809ce6b0;
              break;
            }
            if (lVar3 == null) break;
            if (lVar3.Count <= uVar4) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            if (-1 < *(int *)(lVar6 + lVar3._items)) {
              lVar3 = this.WorldEventDatas;
              if (this.WorldEventDatasSaveRecord == null) break;
              uVar1 = FUN_1800d6760(this.WorldEventDatasSaveRecord,uVar4,DAT_181d8fa18);
              uVar2 = WorldData.GetEventSaveIDEvent(this,uVar1,0);
              if (lVar3 == null) break;
              FUN_18181e0a0(lVar3,uVar2,DAT_181d85b20);
            }
            lVar3 = this.WorldEventDatasSaveRecord;
            uVar4 = uVar4 + 1;
            lVar6 = lVar6 + 4;
          } while (lVar3 != null);
        }
        throw; // [null/range check failed]
        while( true ) {
          lVar3 = this.worldPlotEventStartData;
          uVar5 = uVar5 + 1;
          lVar7 = lVar7 + 8;
          if (lVar3 == null) break;
        LAB_1809ce6b0:
          if (lVar3.Count <= (int)uVar5) {
            return;
          }
          if (lVar3 == null) break;
          if (lVar3.Count <= uVar5) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar3 = *(int64 *)(lVar7 + lVar3._items);
          if (lVar3 == null) break;
          if (-1 < *(int *)(lVar3 + 52)) {
            if (this.worldPlotEventStartData == null) break;
            lVar3 = FUN_180002f80(this.worldPlotEventStartData,uVar5,DAT_181dacf88);
            if (((this.worldPlotEventStartData == null) ||
                (lVar6 = FUN_180002f80(this.worldPlotEventStartData,uVar5,DAT_181dacf88)) == null) ||
               (uVar2 = WorldData.GetEventSaveIDEvent(this,*(uint32 *)(lVar6 + 52),0),
               lVar3 == null)) break;
            *(uint64 *)(lVar3 + 56) = uVar2;
          }
        }
    }

    // Token : 0x6000F09
    // RVA   : 0x9CF320   Offset: 0x9CE720   Length: 0x419
    public void SetPlayerMissionEventData()
    {
        uint uVar1;
        long lVar2;
        long lVar3;
        uint uVar4;
        long lVar5;
        lVar5 = this.Heros;
        if (lVar5 != null) {
          if (lVar5.Count == null) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar5 = *(int64 *)(lVar5._items + 32);
          if (lVar5 != null) {
            if (*(int64 *)(lVar5 + 0x2e0) != 0) {
              lVar5 = this.Heros;
              if (lVar5 == null) throw; // [null/range check failed]
              if (lVar5.Count == null) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar5 = *(int64 *)(lVar5._items + 32);
              if (((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 0x2e0)) == null) ||
                 (lVar5 = *(int64 *)(lVar5 + 120)) == null) throw; // [null/range check failed]
              if (0 < lVar5.Count) {
                lVar5 = this.Heros;
                if (lVar5 == null) throw; // [null/range check failed]
                if (lVar5.Count == null) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar5 = *(int64 *)(lVar5._items + 32);
                if (((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 0x2e0)) == null) ||
                   (lVar5 = *(int64 *)(lVar5 + 120)) == null) throw; // [null/range check failed]
                if (lVar5.Count == null) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar5 = *(int64 *)(lVar5._items + 32);
                lVar2 = this.Heros;
                if (lVar2 == null) throw; // [null/range check failed]
                if (lVar2.Count == null) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar2 = *(int64 *)(lVar2._items + 32);
                if (((lVar2 == null) || (lVar2 = *(int64 *)(lVar2 + 0x2e0)) == null) ||
                   (lVar2 = *(int64 *)(lVar2 + 120)) == null) throw; // [null/range check failed]
                if (lVar2.Count == null) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar2 = *(int64 *)(lVar2._items + 32);
                if (lVar2 == null) throw; // [null/range check failed]
                uVar1 = WorldData.GetEventSaveID(this,*(uint64 *)(lVar2 + 32),0);
                if (lVar5 == null) throw; // [null/range check failed]
                lVar5.Count = uVar1;
              }
            }
            uVar4 = 0;
            lVar5 = 32;
            while( true ) {
              lVar2 = this.Heros;
              if (lVar2 == null) break;
              if (lVar2.Count == null) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar2 = *(int64 *)(lVar2._items + 32);
              if ((lVar2 == null) || (lVar2 = *(int64 *)(lVar2 + 0x2e8)) == null) break;
              if (lVar2.Count <= (int)uVar4) {
                return;
              }
              lVar2 = this.Heros;
              if (lVar2 == null) break;
              if (lVar2.Count == null) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar2 = *(int64 *)(lVar2._items + 32);
              if ((lVar2 == null) || (lVar2 = *(int64 *)(lVar2 + 0x2e8)) == null) break;
              if (lVar2.Count <= uVar4) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar2 = *(int64 *)(lVar5 + lVar2._items);
              if ((lVar2 == null) || (lVar2 = *(int64 *)(lVar2 + 120)) == null) break;
              if (0 < lVar2.Count) {
                lVar2 = WorldData.Player(this,0);
                if ((lVar2 == null) || (*(int64 *)(lVar2 + 0x2e8) == 0)) break;
                lVar2 = FUN_180002f80(*(int64 *)(lVar2 + 0x2e8),uVar4,DAT_181d94c88);
                if ((lVar2 == null) || (lVar2 = *(int64 *)(lVar2 + 120)) == null) break;
                if (lVar2.Count == null) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar2 = *(int64 *)(lVar2._items + 32);
                lVar3 = WorldData.Player(this,0);
                if ((lVar3 == null) || (*(int64 *)(lVar3 + 0x2e8) == 0)) break;
                lVar3 = FUN_180002f80(*(int64 *)(lVar3 + 0x2e8),uVar4,DAT_181d94c88);
                if ((lVar3 == null) || (lVar3 = *(int64 *)(lVar3 + 120)) == null) break;
                if (*(int *)(lVar3 + 24) == 0) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar3 = *(int64 *)(*(int64 *)(lVar3 + 16) + 32);
                if (lVar3 == null) break;
                uVar1 = WorldData.GetEventSaveID(this,*(uint64 *)(lVar3 + 32),0);
                if (lVar2 == null) break;
                lVar2.Count = uVar1;
              }
              uVar4 = uVar4 + 1;
              lVar5 = lVar5 + 8;
            }
          }
        }
    }

    // Token : 0x6000F0A
    // RVA   : 0x9CEAD0   Offset: 0x9CDED0   Length: 0x53C
    public void RecoverPlayerMissionEventData()
    {
        long lVar2;
        long lVar3;
        ulong uVar4;
        long lVar5;
        uint uVar6;
        lVar2 = this.Heros;
        if (lVar2 != null) {
          if (lVar2.Count == null) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar2 = *(int64 *)(lVar2._items + 32);
          if (lVar2 != null) {
            if (*(int64 *)(lVar2 + 0x2e0) != 0) {
              lVar2 = this.Heros;
              if (lVar2 == null) throw; // [null/range check failed]
              if (lVar2.Count == null) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar2 = *(int64 *)(lVar2._items + 32);
              if ((lVar2 == null) || (lVar2 = *(int64 *)(lVar2 + 0x2e0)) == null) throw; // [null/range check failed]
              if (*(int64 *)(lVar2 + 120) != 0) {
                lVar2 = this.Heros;
                if (lVar2 == null) throw; // [null/range check failed]
                if (lVar2.Count == null) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar2 = *(int64 *)(lVar2._items + 32);
                if (((lVar2 == null) || (lVar2 = *(int64 *)(lVar2 + 0x2e0)) == null) ||
                   (lVar2 = *(int64 *)(lVar2 + 120)) == null) throw; // [null/range check failed]
                if (0 < lVar2.Count) {
                  lVar2 = WorldData.Player(this,0);
                  if (((lVar2 == null) || (*(int64 *)(lVar2 + 0x2e0) == 0)) ||
                     (lVar2 = *(int64 *)(*(int64 *)(lVar2 + 0x2e0) + 120)) == null)
                  throw; // [null/range check failed]
                  if (lVar2.Count == null) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  lVar2 = *(int64 *)(lVar2._items + 32);
                  if (lVar2 == null) throw; // [null/range check failed]
                  if (-1 < lVar2.Count) {
                    lVar2 = WorldData.Player(this,0);
                    if (((lVar2 == null) || (*(int64 *)(lVar2 + 0x2e0) == 0)) ||
                       (lVar2 = *(int64 *)(*(int64 *)(lVar2 + 0x2e0) + 120)) == null)
                    throw; // [null/range check failed]
                    if (lVar2.Count == null) {
                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                    }
                    lVar2 = *(int64 *)(lVar2._items + 32);
                    lVar3 = WorldData.Player(this,0);
                    if (((lVar3 == null) || (*(int64 *)(lVar3 + 0x2e0) == 0)) ||
                       (lVar3 = *(int64 *)(*(int64 *)(lVar3 + 0x2e0) + 120)) == null)
                    throw; // [null/range check failed]
                    if (lVar3.Count == null) {
                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                    }
                    lVar3 = *(int64 *)(lVar3._items + 32);
                    if (lVar3 == null) throw; // [null/range check failed]
                    uVar4 = WorldData.GetEventSaveIDEvent(this,lVar3.Count,0);
                    if (lVar2 == null) throw; // [null/range check failed]
                    puVar1 = (uint64 *)(lVar2 + 32);
                    *puVar1 = uVar4;
                    il2cpp_internal(puVar1,uVar4);
                  }
                }
              }
            }
            uVar6 = 0;
            lVar2 = 32;
            while( true ) {
              lVar3 = this.Heros;
              if (lVar3 == null) break;
              if (lVar3.Count == null) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar3 = *(int64 *)(lVar3._items + 32);
              if ((lVar3 == null) || (lVar3 = *(int64 *)(lVar3 + 0x2e8)) == null) break;
              if (lVar3.Count <= (int)uVar6) {
                return;
              }
              lVar3 = this.Heros;
              if (lVar3 == null) break;
              if (lVar3.Count == null) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar3 = *(int64 *)(lVar3._items + 32);
              if ((lVar3 == null) || (lVar3 = *(int64 *)(lVar3 + 0x2e8)) == null) break;
              if (lVar3.Count <= uVar6) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar3 = *(int64 *)(lVar2 + lVar3._items);
              if (lVar3 == null) break;
              if (*(int64 *)(lVar3 + 120) != 0) {
                lVar3 = WorldData.Player(this,0);
                if ((lVar3 == null) || (*(int64 *)(lVar3 + 0x2e8) == 0)) break;
                lVar3 = FUN_180002f80(*(int64 *)(lVar3 + 0x2e8),uVar6,DAT_181d94c88);
                if ((lVar3 == null) || (*(int64 *)(lVar3 + 120) == 0)) break;
                if (0 < *(int *)(*(int64 *)(lVar3 + 120) + 24)) {
                  lVar3 = WorldData.Player(this,0);
                  if ((lVar3 == null) || (*(int64 *)(lVar3 + 0x2e8) == 0)) break;
                  lVar3 = FUN_180002f80(*(int64 *)(lVar3 + 0x2e8),uVar6,DAT_181d94c88);
                  if ((lVar3 == null) || (lVar3 = *(int64 *)(lVar3 + 120)) == null) break;
                  if (lVar3.Count == null) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  lVar3 = *(int64 *)(lVar3._items + 32);
                  if (lVar3 == null) break;
                  if (-1 < lVar3.Count) {
                    lVar3 = WorldData.Player(this,0);
                    if ((lVar3 == null) || (*(int64 *)(lVar3 + 0x2e8) == 0)) break;
                    lVar3 = FUN_180002f80(*(int64 *)(lVar3 + 0x2e8),uVar6,DAT_181d94c88);
                    if ((lVar3 == null) || (lVar3 = *(int64 *)(lVar3 + 120)) == null) break;
                    if (lVar3.Count == null) {
                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                    }
                    lVar3 = *(int64 *)(lVar3._items + 32);
                    lVar5 = WorldData.Player(this,0);
                    if ((lVar5 == null) || (*(int64 *)(lVar5 + 0x2e8) == 0)) break;
                    lVar5 = FUN_180002f80(*(int64 *)(lVar5 + 0x2e8),uVar6,DAT_181d94c88);
                    if ((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 120)) == null) break;
                    if (*(int *)(lVar5 + 24) == 0) {
                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                    }
                    lVar5 = *(int64 *)(*(int64 *)(lVar5 + 16) + 32);
                    if (lVar5 == null) break;
                    uVar4 = WorldData.GetEventSaveIDEvent(this,*(uint32 *)(lVar5 + 24),0);
                    if (lVar3 == null) break;
                    *(uint64 *)(lVar3 + 32) = uVar4;
                  }
                }
              }
              uVar6 = uVar6 + 1;
              lVar2 = lVar2 + 8;
            }
          }
        }
    }

    // Token : 0x6000F0B
    // RVA   : 0x9CCDC0   Offset: 0x9CC1C0   Length: 0x27
    public float GetChapterBadFameRate()
    {
        Mathf.Min(0x3f800000,1.0 - (float)this.chapter * 0.1,0);
    }

    // Token : 0x6000F0C
    // RVA   : 0x9CF9F0   Offset: 0x9CEDF0   Length: 0x3BE
    public void UnlockSkin(int _skinID, int _skinLv, bool showInfo)
    {
        long lVar1;
        bool cVar2;
        long lVar3;
        ulong uVar4;
        long lVar5;
        uint uVar6;
        ulong local_38;
        ulong uStack_30;
        lVar3 = this.skinUnlockData;
        uVar6 = 0;
        if (lVar3 != null) {
          lVar5 = 32;
          do {
            if (lVar3.Count <= (int)uVar6) {
              uVar4 = new SkinUnlockData(_skinID,0);
              if (lVar3 != null) {
                FUN_18181e0a0(lVar3,uVar4,DAT_181da2fd8);
                lVar3 = this.skinUnlockData;
                if (lVar3 != null) {
                  uVar6 = lVar3.Count;
                  if (uVar6 <= uVar6 - 1) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  lVar3 = *(int64 *)(lVar3._items + 24 + (int64)(int)uVar6 * 8);
                  if (lVar3 != null) {
                    lVar3 = lVar3.Count;
        LAB_1809cfc16:
                    if (lVar3 != null) {
                      FUN_1817f42f0(lVar3,_skinLv,1,DAT_181d80720);
                      if (!showInfo) {
                        return;
                      }
                      lVar3 = **(int64 **)(DAT_181d7f6a8 + 184);
                      lVar5 = *(int64 *)(*(int64 *)(DAT_181d72d50 + 184) + 32);
                      if ((lVar5 != null) &&
                         (lVar5 = GameDataController.FindSkinDataBase(lVar5,_skinID,0)) != null) {
                        uVar4 = SkinDataBase.GetSkinFullName(lVar5,_skinLv,0,1,0);
                        uVar4 = String.Concat("解锁了新服装：",uVar4,0);
                        if (lVar3 != null) {
                          local_38 = 0;
                          uStack_30 = 0;
                          InfoController.AddInfoTab
                                    (lVar3,uVar4,"UIAtlas","角色操作_换装_悬停高亮","Woosh",0x3f800000,
                                     0x40a00000,&local_38,0);
                          return;
                        }
                      }
                    }
                  }
                }
              }
              break;
            }
            if (lVar3 == null) break;
            if (lVar3.Count <= uVar6) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar1 = *(int64 *)(lVar5 + lVar3._items);
            if (lVar1 == null) break;
            lVar3 = this.skinUnlockData;
            if (*(int *)(lVar1 + 16) == _skinID) {
              if (((lVar3 != null) && (lVar3 = FUN_180002f80(lVar3,uVar6,DAT_181da30d8)) != null) &&
                 (lVar3.Count != null)) {
                cVar2 = FUN_180133a50(lVar3.Count,_skinLv,DAT_181d806a0);
                if (cVar2) {
                  return;
                }
                if ((this.skinUnlockData != null) &&
                   (lVar3 = FUN_180002f80(this.skinUnlockData,uVar6,DAT_181da30d8)) != null
                   ) {
                  lVar3 = lVar3.Count;
                  goto LAB_1809cfc16;
                }
              }
              break;
            }
            uVar6 = uVar6 + 1;
            lVar5 = lVar5 + 8;
          } while (lVar3 != null);
        }
    }

    // Token : 0x6000F0D
    // RVA   : 0x9CF740   Offset: 0x9CEB40   Length: 0x2AA
    public bool SkinUnlocked(int _skinID, int _skinLv)
    {
        var pStatics = *(int64*)(DAT_181d72d50 + 184);
        long lVar1;
        byte uVar2;
        int iVar3;
        long lVar4;
        ulong uVar5;
        long lVar6;
        uint uVar7;
        lVar4 = *(int64 *)(pStatics + 32);
        if ((lVar4 != null) && (lVar4 = GameDataController.FindSkinDataBase(lVar4,_skinID,0)) != null) {
          if (*(int *)(lVar4 + 40) < 0) {
            lVar4 = this.skinUnlockData;
            uVar7 = 0;
            if (lVar4 != null) {
              lVar6 = 32;
              do {
                if (lVar4.Count <= (int)uVar7) {
                  return false;
                }
                if (lVar4 == null) break;
                if (lVar4.Count <= uVar7) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar1 = *(int64 *)(lVar6 + lVar4._items);
                if (lVar1 == null) break;
                lVar4 = this.skinUnlockData;
                if (*(int *)(lVar1 + 16) == _skinID) {
                  if (((lVar4 != null) && (lVar4 = FUN_180002f80(lVar4,uVar7,DAT_181da30d8)) != null) &&
                     (lVar4.Count != null)) {
                    uVar2 = FUN_180133a50(lVar4.Count,_skinLv,DAT_181d806a0);
                    return (bool)uVar2;
                  }
                  break;
                }
                uVar7 = uVar7 + 1;
                lVar6 = lVar6 + 8;
              } while (lVar4 != null);
            }
          }
          else {
            lVar4 = *(int64 *)(pStatics + 8);
            if (lVar4 != null) {
              lVar4 = lVar4._items;
              lVar6 = *(int64 *)(pStatics + 32);
              if ((lVar6 != null) &&
                 (lVar6 = GameDataController.FindSkinDataBase(lVar6,_skinID,0)) != null) {
                uVar5 = Int32.ToString(lVar6 + 40,0);
                uVar5 = String.Concat("DLC",uVar5,0);
                if (lVar4 != null) {
                  iVar3 = PlayerPrefDictionary.GetInt(lVar4,uVar5,0);
                  return 0 < iVar3;
                }
              }
            }
          }
        }
    }

    // Token : 0x6000F0E
    // RVA   : 0x9CBB60   Offset: 0x9CAF60   Length: 0x139
    public bool CanQuickTravel()
    {
        long lVar1;
        long lVar2;
        long lVar3;
        uint uVar4;
        uVar4 = 0;
        lVar3 = 32;
        while( true ) {
          lVar1 = this.Heros;
          if (lVar1 == null) break;
          if (lVar1.Count == null) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar1 = *(int64 *)(lVar1._items + 32);
          if ((lVar1 == null) || (lVar1 = *(int64 *)(lVar1 + 0x2e8)) == null) break;
          if (lVar1.Count <= (int)uVar4) {
            return CONCAT71((int7)((uint64)lVar1 >> 8),1);
          }
          lVar1 = this.Heros;
          if (lVar1 == null) break;
          if (lVar1.Count == null) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar1 = *(int64 *)(lVar1._items + 32);
          if ((lVar1 == null) || (lVar1 = *(int64 *)(lVar1 + 0x2e8)) == null) break;
          if (lVar1.Count <= uVar4) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar2 = *(int64 *)(lVar3 + lVar1._items);
          if (lVar2 == null) break;
          if (*(char *)(lVar2 + 96) != false) {
            return lVar1._items & 0xffffffffffffff00;
          }
          uVar4 = uVar4 + 1;
          lVar3 = lVar3 + 8;
        }
    }

    // Token : 0x6000F0F
    // RVA   : 0x9CBCA0   Offset: 0x9CB0A0   Length: 0x139
    public void ChangeSpeEnhanceStoneNum(int num, bool showInfo)
    {
        long lVar1;
        ulong uVar2;
        int[] local_res10 = new int[6];
        ulong local_18;
        ulong uStack_10;
        local_res10[0] = num;
        this.speEnhanceStone = this.speEnhanceStone + local_res10[0];
        if (showInfo) {
          lVar1 = **(int64 **)(DAT_181d7f6a8 + 184);
          uVar2 = Int32.ToString(local_res10,"+0;-0;0",0);
          uVar2 = String.Format("陨铁{0}",uVar2,0);
          if (lVar1 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          local_18 = 0;
          uStack_10 = 0;
          InfoController.AddInfoTab
                    (lVar1,uVar2,"UIAtlas","陨铁","WeaponSharp",0x3f800000,0x40a00000,&local_18
                     ,0);
        }
    }

    // Token : 0x6000F10
    // RVA   : 0x9CBAB0   Offset: 0x9CAEB0   Length: 0xA7
    public void AddWorldNews(string text, int time)
    {
        long lVar1;
        long lVar2;
        lVar1 = this.WorldNewsDatas;
        lVar2 = new ZhSegment(0);
        *(uint64 *)(lVar2 + 16) = text;
        *(uint32 *)(lVar2 + 24) = time;
        if (lVar1 != null) {
          FUN_18181e0a0(lVar1,lVar2,DAT_181daca08);
          return;
        }
    }

    // Token : 0x6000F11
    // RVA   : 0x9CE500   Offset: 0x9CD900   Length: 0x7F
    public bool HaveWorldNews(bool includeWorldNews)
    {
        long lVar1;
        if (includeWorldNews) {
          lVar1 = this.WorldNewsDatas;
          if (lVar1 == null) throw; // [null/range check failed]
          if (0 < lVar1.Count) {
            return CONCAT71((int7)((uint64)lVar1 >> 8),1);
          }
        }
        lVar1 = this.WorldEventDatas;
        if (lVar1 != null) {
          return CONCAT71((int7)((uint64)lVar1 >> 8),0 < lVar1.Count);
        }
    }

    // Token : 0x6000F12
    // RVA   : 0x9CE060   Offset: 0x9CD460   Length: 0x15F
    public string GetRandomWorldNews(bool includeWorldNews)
    {
        int iVar1;
        int iVar2;
        uint uVar3;
        long lVar4;
        uint uVar5;
        ulong uVar6;
        uint uVar7;
        lVar4 = this.WorldNewsDatas;
        if (!includeWorldNews) {
          if (lVar4 == null) throw; // [null/range check failed]
          uVar7 = lVar4.Count;
        }
        else {
          uVar7 = 0;
          if (lVar4 == null) throw; // [null/range check failed]
        }
        iVar1 = lVar4.Count;
        if (this.WorldEventDatas != null) {
          iVar2 = this.WorldEventDatas.Count;
          uVar5 = GlobalData.RandomRange(uVar7,iVar2 + iVar1,0,0);
          lVar4 = this.WorldNewsDatas;
          if (lVar4 != null) {
            uVar3 = lVar4.Count;
            if ((int)uVar5 < (int)uVar3) {
              if (uVar3 <= uVar5) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar4 = lVar4._items[uVar5];
              if (lVar4 != null) {
                return lVar4._items;
              }
            }
            else {
              lVar4 = this.WorldEventDatas;
              if (lVar4 != null) {
                if (lVar4.Count <= uVar5 - uVar3) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar4 = *(int64 *)
                         (lVar4._items + 32 + (int64)(int)(uVar5 - uVar3) * 8);
                if (lVar4 != null) {
                  uVar6 = EventData.GetDescribe(lVar4,0,0);
                  return uVar6;
                }
              }
            }
          }
        }
    }

    // Token : 0x6000F13
    // RVA   : 0x9CDF50   Offset: 0x9CD350   Length: 0x10F
    public int GetRandomEnemyCount()
    {
        long lVar1;
        int iVar2;
        uint uVar3;
        long lVar4;
        lVar1 = this.TempHeros;
        iVar2 = 0;
        uVar3 = 0;
        if (lVar1 != null) {
          lVar4 = 32;
          do {
            if (lVar1.Count <= (int)uVar3) {
              return iVar2;
            }
            if (lVar1 == null) break;
            if (lVar1.Count <= uVar3) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            if (*(int64 *)(lVar4 + lVar1._items) != 0) {
              if ((this.TempHeros == null) ||
                 (lVar1 = FUN_180002f80(this.TempHeros,uVar3,DAT_181d8bb98)) == null)
              break;
              if (*(char *)(lVar1 + 0x3cd) != false) {
                if ((this.TempHeros == null) ||
                   (lVar1 = FUN_180002f80(this.TempHeros,uVar3,DAT_181d8bb98)) == null)
                break;
                if (*(char *)(lVar1 + 0x2f0) == false) {
                  iVar2 = iVar2 + 1;
                }
              }
            }
            lVar1 = this.TempHeros;
            uVar3 = uVar3 + 1;
            lVar4 = lVar4 + 8;
          } while (lVar1 != null);
        }
    }

    // Token : 0x6000F14
    // RVA   : 0x9CC1D0   Offset: 0x9CB5D0   Length: 0x178
    public int FindAvailableHeroID()
    {
        bool cVar1;
        long lVar2;
        long lVar3;
        uint uVar4;
        uint uVar5;
        long lVar6;
        lVar2 = il2cpp_internal(DAT_181d93cd0);
        FUN_18132faf0(lVar2,DAT_181d8f098);
        lVar3 = this.Heros;
        uVar5 = 0;
        if (lVar3 != null) {
          lVar6 = 32;
          uVar4 = uVar5;
          while ((int)uVar4 < lVar3.Count) {
            if (lVar3 == null) throw; // [null/range check failed]
            if (lVar3.Count <= uVar4) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            if (*(int64 *)(lVar6 + lVar3._items) != 0) {
              if (((this.Heros == null) ||
                  (lVar3 = FUN_180002f80(this.Heros,uVar4,DAT_181d8bb98)) == null)
                 || (lVar2 == null)) throw; // [null/range check failed]
              FUN_18182a0b0(lVar2,*(uint32 *)(lVar3 + 88),DAT_181d8f218);
            }
            lVar3 = this.Heros;
            uVar4 = uVar4 + 1;
            lVar6 = lVar6 + 8;
            if (lVar3 == null) throw; // [null/range check failed]
          }
          if (lVar2 != null) {
            List_1.Sort(lVar2,DAT_181d8f798);
            while (cVar1 = FUN_18182a3a0(lVar2,uVar5,DAT_181d8f398), cVar1) {
              uVar5 = uVar5 + 1;
            }
            return uVar5;
          }
        }
    }

    // Token : 0x6000F15
    // RVA   : 0x9CC350   Offset: 0x9CB750   Length: 0x1CB
    public int FindAvailableTempHeroID()
    {
        bool cVar1;
        long lVar2;
        long lVar3;
        int iVar4;
        long lVar5;
        uint uVar6;
        lVar2 = il2cpp_internal(DAT_181d93cd0);
        FUN_18132faf0(lVar2,DAT_181d8f098);
        lVar3 = this.TempHeros;
        uVar6 = 0;
        if (lVar3 != null) {
          lVar5 = 32;
          while ((int)uVar6 < lVar3.Count) {
            if (lVar3 == null) throw; // [null/range check failed]
            if (lVar3.Count <= uVar6) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            if (*(int64 *)(lVar3._items + lVar5) != 0) {
              if (((this.TempHeros == null) ||
                  (lVar3 = FUN_180002f80(this.TempHeros,uVar6,DAT_181d8bb98)) == null)
                 || (lVar2 == null)) throw; // [null/range check failed]
              FUN_18182a0b0(lVar2,*(uint32 *)(lVar3 + 88),DAT_181d8f218);
            }
            lVar3 = this.TempHeros;
            uVar6 = uVar6 + 1;
            lVar5 = lVar5 + 8;
            if (lVar3 == null) throw; // [null/range check failed]
          }
          if (lVar2 != null) {
            List_1.Sort(lVar2,DAT_181d8f798);
            iVar4 = *(int *)(*(int64 *)(DAT_181d73d40 + 184) + 0x118);
            while (cVar1 = FUN_18182a3a0(lVar2,iVar4,DAT_181d8f398), cVar1) {
              iVar4 = iVar4 + 1;
            }
            return iVar4;
          }
        }
    }

    // Token : 0x6000F16
    // RVA   : 0x9CB760   Offset: 0x9CAB60   Length: 0x1E9
    public void AddTempHero(HeroData target)
    {
        ulong uVar1;
        long lVar2;
        uint uVar3;
        uint uVar4;
        bool[] local_res8 = new bool[8];
        uVar4 = 0;
        uVar1 = this.tempHerosDictLock;
        local_res8[0] = false;
        Monitor.Enter(uVar1,local_res8,0);
        while( true ) {
          lVar2 = this.TempHeros;
          if (lVar2 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          if ((int)lVar2.Count <= (int)uVar4) break;
          if (lVar2.Count <= uVar4) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          if (lVar2._items[uVar4] == 0) {
            uVar3 = WorldData.FindAvailableTempHeroID(this,0);
            if (target == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            HeroData.SetHeroID(target,uVar3,0);
            if (this.TempHeros == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            FUN_181829cd0(this.TempHeros,uVar4,target,DAT_181d8bc18);
            if (this.TempHerosDict == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            FUN_1808ab370(this.TempHerosDict,*(uint32 *)(target + 88),target,
                          DAT_181db9fe0);
            goto LAB_1809cb8f2;
          }
          uVar4 = uVar4 + 1;
        }
        uVar3 = WorldData.FindAvailableTempHeroID(this,0);
        if (target == null) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        HeroData.SetHeroID(target,uVar3,0);
        *(uint8 *)(target + 0x3cc) = 1;
        if (this.TempHeros == null) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        FUN_18181e0a0(this.TempHeros,target,DAT_181d8b518);
        if (this.TempHerosDict == null) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        FUN_1808ab370(this.TempHerosDict,*(uint32 *)(target + 88),target,DAT_181db9fe0
                     );
        LAB_1809cb8f2:
        if (local_res8[0] != false) {
          Monitor.Exit(uVar1,0);
        }
    }

    // Token : 0x6000F17
    // RVA   : 0x9CF1A0   Offset: 0x9CE5A0   Length: 0x176
    public void RemoveTempHero(HeroData target)
    {
        ulong uVar1;
        long lVar2;
        long lVar3;
        uint uVar4;
        bool[] local_res8 = new bool[8];
        uVar4 = 0;
        uVar1 = this.tempHerosDictLock;
        local_res8[0] = false;
        Monitor.Enter(uVar1,local_res8,0);
        if (target == null) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        *(uint8 *)(target + 0x3ce) = 0;
        while( true ) {
          lVar2 = this.TempHeros;
          if (lVar2 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          if ((int)lVar2.Count <= (int)uVar4) break;
          if (lVar2.Count <= uVar4) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          if (lVar2._items[uVar4] == target) {
            lVar2 = this.TempHerosDict;
            if (this.TempHeros == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar3 = FUN_180002f80(this.TempHeros,uVar4,DAT_181d8bb98);
            if (lVar3 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            if (lVar2 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            FUN_18175d7a0(lVar2,*(uint32 *)(lVar3 + 88),DAT_181dba0f0);
            if (this.TempHeros == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            FUN_181829cd0(this.TempHeros,uVar4,0,DAT_181d8bc18);
            break;
          }
          uVar4 = uVar4 + 1;
        }
        if (local_res8[0] != false) {
          Monitor.Exit(uVar1,0);
        }
    }

    // Token : 0x6000F18
    // RVA   : 0x9CE380   Offset: 0x9CD780   Length: 0xC5
    public int GetTempHeroCount()
    {
        int iVar1;
        long lVar2;
        long lVar3;
        int iVar5;
        uint uVar6;
        long lVar7;
        iVar5 = 0;
        uVar6 = 0;
        if (this.TempHeros != null) {
          lVar7 = 32;
          lVar2 = this.TempHeros;
          do {
            if (lVar2.Count <= (int)uVar6) {
              return iVar5;
            }
            if (lVar2 == null) break;
            lVar3 = lVar2;
            if (lVar2.Count <= uVar6) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
              lVar3 = this.TempHeros;
            }
            plVar4 = (int64 *)(lVar2._items + lVar7);
            uVar6 = uVar6 + 1;
            lVar7 = lVar7 + 8;
            iVar1 = iVar5 + 1;
            if (*plVar4 == 0) {
              iVar1 = iVar5;
            }
            iVar5 = iVar1;
            lVar2 = lVar3;
          } while (lVar3 != null);
        }
    }

    // Token : 0x6000F19
    // RVA   : 0x9CB5A0   Offset: 0x9CA9A0   Length: 0x1BD
    public void AddNewHero(HeroData target)
    {
        ulong uVar1;
        long lVar2;
        uint uVar3;
        uint uVar4;
        bool[] local_res8 = new bool[8];
        uVar4 = 0;
        uVar1 = this.herosDictLock;
        local_res8[0] = false;
        Monitor.Enter(uVar1,local_res8,0);
        while( true ) {
          lVar2 = this.Heros;
          if (lVar2 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          if ((int)lVar2.Count <= (int)uVar4) break;
          if (lVar2.Count <= uVar4) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          if (lVar2._items[uVar4] == 0) {
            uVar3 = WorldData.FindAvailableHeroID(this,0);
            if (target == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            HeroData.SetHeroID(target,uVar3,0);
            if (this.Heros == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            FUN_181829cd0(this.Heros,uVar4,target,DAT_181d8bc18);
            goto LAB_1809cb6d6;
          }
          uVar4 = uVar4 + 1;
        }
        uVar3 = WorldData.FindAvailableHeroID(this,0);
        if (target == null) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        HeroData.SetHeroID(target,uVar3,0);
        if (this.Heros == null) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        FUN_18181e0a0(this.Heros,target,DAT_181d8b518);
        LAB_1809cb6d6:
        if (this.HerosDict != null) {
          FUN_1808ab370(this.HerosDict,*(uint32 *)(target + 88),target,
                        DAT_181db9fe0);
          *(uint16 *)(target + 0x3cc) = 0;
          if (local_res8[0] != false) {
            Monitor.Exit(uVar1,0);
          }
          return;
        }
    }

    // Token : 0x6000F1A
    // RVA   : 0x9CF010   Offset: 0x9CE410   Length: 0x186
    public void RemoveHero(HeroData target)
    {
        ulong uVar1;
        long lVar2;
        long lVar3;
        uint uVar4;
        bool[] local_res8 = new bool[8];
        uVar1 = this.herosDictLock;
        local_res8[0] = false;
        Monitor.Enter(uVar1,local_res8,0);
        if (target == null) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        *(uint8 *)(target + 0x3ce) = 0;
        *(uint8 *)(target + 96) = 1;
        if (*(char *)(target + 92) == false) {
          uVar4 = 0;
          do {
            uVar4 = uVar4 + 1;
            lVar2 = this.Heros;
            if (lVar2 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            if ((int)lVar2.Count <= (int)uVar4) goto LAB_1809cf144;
            if (lVar2.Count <= uVar4) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
          } while (lVar2._items[uVar4] != target
                  );
          lVar2 = this.HerosDict;
          if (this.Heros == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          lVar3 = FUN_180002f80(this.Heros,uVar4,DAT_181d8bb98);
          if (lVar3 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          if (lVar2 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          FUN_18175d7a0(lVar2,*(uint32 *)(lVar3 + 88),DAT_181dba0f0);
          if (this.Heros == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          FUN_181829cd0(this.Heros,uVar4,0,DAT_181d8bc18);
        }
        LAB_1809cf144:
        if (local_res8[0] != false) {
          Monitor.Exit(uVar1,0);
        }
    }

    // Token : 0x6000F1B
    // RVA   : 0x9CD3B0   Offset: 0x9CC7B0   Length: 0xC5
    public int GetHeroCount()
    {
        int iVar1;
        long lVar2;
        long lVar3;
        int iVar5;
        uint uVar6;
        long lVar7;
        iVar5 = 0;
        uVar6 = 0;
        if (this.Heros != null) {
          lVar7 = 32;
          lVar2 = this.Heros;
          do {
            if (lVar2.Count <= (int)uVar6) {
              return iVar5;
            }
            if (lVar2 == null) break;
            lVar3 = lVar2;
            if (lVar2.Count <= uVar6) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
              lVar3 = this.Heros;
            }
            plVar4 = (int64 *)(lVar2._items + lVar7);
            uVar6 = uVar6 + 1;
            lVar7 = lVar7 + 8;
            iVar1 = iVar5 + 1;
            if (*plVar4 == 0) {
              iVar1 = iVar5;
            }
            iVar5 = iVar1;
            lVar2 = lVar3;
          } while (lVar3 != null);
        }
    }

    // Token : 0x6000F1C
    // RVA   : 0x9CCB90   Offset: 0x9CBF90   Length: 0x224
    public AreaData GetArea(string areaName)
    {
        uint uVar1;
        long lVar2;
        long lVar3;
        ulong uVar4;
        long lVar5;
        uint uVar6;
        long lVar7;
        if (this.AreasDict != null) {
        LAB_1809ccb3b:
          if (areaName == -1) {
            uVar4 = 0;
          }
          else {
            if (this.AreasDict == null) throw; // [null/range check failed]
            uVar4 = FUN_1817d9e10(this.AreasDict,areaName,DAT_181db7df8);
          }
          return uVar4;
        }
        uVar4 = il2cpp_internal(DAT_181d809e8);
        FUN_1808b1370(uVar4,DAT_181db7ce8);
        this.AreasDict = uVar4;
        lVar5 = this.Areas;
        uVar6 = 0;
        if (lVar5 != null) {
          lVar7 = 32;
          do {
            if (lVar5.Count <= (int)uVar6) goto LAB_1809ccb3b;
            lVar2 = this.AreasDict;
            if (lVar5 == null) break;
            if (lVar5.Count <= uVar6) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar5 = *(int64 *)(lVar7 + lVar5._items);
            if (lVar5 == null) break;
            lVar3 = this.Areas;
            uVar1 = lVar5._items;
            if (lVar3 == null) break;
            if (lVar3.Count <= uVar6) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            if (lVar2 == null) break;
            FUN_1808ab370(lVar2,uVar1,*(uint64 *)(lVar3._items + lVar7),DAT_181db7d70);
            lVar5 = this.Areas;
            uVar6 = uVar6 + 1;
            lVar7 = lVar7 + 8;
          } while (lVar5 != null);
        }
    }

    // Token : 0x6000F1D
    // RVA   : 0x9CD030   Offset: 0x9CC430   Length: 0x1A9
    public ForceData GetForce(string forceName)
    {
        uint uVar1;
        long lVar2;
        long lVar3;
        ulong uVar4;
        long lVar5;
        uint uVar6;
        long lVar7;
        if (this.ForcesDict != null) {
        LAB_1809cd34f:
          if ((forceName == -1) || (forceName == -2)) {
            uVar4 = 0;
          }
          else {
            if (this.ForcesDict == null) throw; // [null/range check failed]
            uVar4 = FUN_1817d9e10(this.ForcesDict,forceName,DAT_181db9760);
          }
          return uVar4;
        }
        uVar4 = il2cpp_internal(DAT_181d80ce8);
        FUN_1808b1370(uVar4,DAT_181db9650);
        this.ForcesDict = uVar4;
        lVar5 = this.Forces;
        uVar6 = 0;
        if (lVar5 != null) {
          lVar7 = 32;
          do {
            if (lVar5.Count <= (int)uVar6) goto LAB_1809cd34f;
            lVar2 = this.ForcesDict;
            if (lVar5 == null) break;
            if (lVar5.Count <= uVar6) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar5 = *(int64 *)(lVar7 + lVar5._items);
            if (lVar5 == null) break;
            lVar3 = this.Forces;
            uVar1 = lVar5._items;
            if (lVar3 == null) break;
            if (lVar3.Count <= uVar6) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            if (lVar2 == null) break;
            FUN_1808ab370(lVar2,uVar1,*(uint64 *)(lVar3._items + lVar7),DAT_181db96d8);
            lVar5 = this.Forces;
            uVar6 = uVar6 + 1;
            lVar7 = lVar7 + 8;
          } while (lVar5 != null);
        }
    }

    // Token : 0x6000F1E
    // RVA   : 0x9CD480   Offset: 0x9CC880   Length: 0x65
    public ForceData GetHeroForce(int heroID)
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        lVar2 = WorldData.GetHero(this,heroID,0);
        if (lVar2 != null) {
          cVar1 = HeroData.HaveForce(lVar2,0);
          if (!cVar1) {
            return 0;
          }
          lVar2 = WorldData.GetHero(this,heroID & 0xffffffff,0);
          if (lVar2 != null) {
            uVar3 = HeroData.GetForce(lVar2,0,0);
            return uVar3;
          }
        }
    }

    // Token : 0x6000F1F
    // RVA   : 0x9CD5F0   Offset: 0x9CC9F0   Length: 0x466
    public HeroData GetHero(string heroName)
    {
        bool cVar1;
        ulong uVar2;
        long lVar3;
        if (heroName < 0) {
          return 0;
        }
        if (heroName < *(int *)(*(int64 *)(DAT_181d73d40 + 184) + 0x118)) {
          if (this.HerosDict == null) throw; // [null/range check failed]
          cVar1 = FUN_1808ab490(this.HerosDict,heroName,DAT_181dba068);
          if (!cVar1) {
            return 0;
          }
          lVar3 = this.HerosDict;
        }
        else {
          if (this.TempHerosDict == null) throw; // [null/range check failed]
          cVar1 = FUN_1808ab490(this.TempHerosDict,heroName,DAT_181dba068);
          if (!cVar1) {
            return 0;
          }
          lVar3 = this.TempHerosDict;
        }
        if (lVar3 != null) {
          uVar2 = FUN_1817d9e10(lVar3,heroName,DAT_181dba178);
          return uVar2;
        }
    }

    // Token : 0x6000F20
    // RVA   : 0x9CC6F0   Offset: 0x9CBAF0   Length: 0x26A
    public void GenerateHeroDict()
    {
        uint uVar1;
        ulong uVar2;
        long lVar3;
        long lVar4;
        uint uVar5;
        uint uVar6;
        long lVar7;
        long lVar8;
        uVar2 = il2cpp_internal(DAT_181d80e68);
        FUN_1808b1370(uVar2,DAT_181db9f58);
        this.HerosDict = uVar2;
        lVar4 = this.Heros;
        uVar6 = 0;
        if (lVar4 != null) {
          lVar8 = 32;
          lVar7 = 32;
          uVar5 = uVar6;
          while ((int)uVar5 < lVar4.Count) {
            if (lVar4 == null) throw; // [null/range check failed]
            if (lVar4.Count <= uVar5) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            if (*(int64 *)(lVar7 + lVar4._items) != 0) {
              lVar4 = this.HerosDict;
              if ((this.Heros == null) ||
                 (lVar3 = FUN_180002f80(this.Heros,uVar5,DAT_181d8bb98)) == null)
              throw; // [null/range check failed]
              uVar1 = *(uint32 *)(lVar3 + 88);
              if ((this.Heros == null) ||
                 (uVar2 = FUN_180002f80(this.Heros,uVar5,DAT_181d8bb98), lVar4 == null))
              throw; // [null/range check failed]
              FUN_1808ab370(lVar4,uVar1,uVar2,DAT_181db9fe0);
            }
            lVar4 = this.Heros;
            uVar5 = uVar5 + 1;
            lVar7 = lVar7 + 8;
            if (lVar4 == null) throw; // [null/range check failed]
          }
          uVar2 = il2cpp_internal(DAT_181d80e68);
          FUN_1808b1370(uVar2,DAT_181db9f58);
          this.TempHerosDict = uVar2;
          lVar4 = this.TempHeros;
          if (lVar4 == null)
          {
            }
            throw; // [null/range check failed]
            while( true ) {
            lVar4 = this.TempHeros;
            uVar6 = uVar6 + 1;
            lVar8 = lVar8 + 8;
            if (lVar4 == null) break;
          }
          if (lVar4.Count <= (int)uVar6) {
            return;
          }
          if (lVar4 == null) break;
          if (lVar4.Count <= uVar6) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          if (*(int64 *)(lVar8 + lVar4._items) != 0) {
            lVar4 = this.TempHerosDict;
            if ((this.TempHeros == null) ||
               (lVar7 = FUN_180002f80(this.TempHeros,uVar6,DAT_181d8bb98)) == null)
            break;
            uVar1 = *(uint32 *)(lVar7 + 88);
            if ((this.TempHeros == null) ||
               (uVar2 = FUN_180002f80(this.TempHeros,uVar6,DAT_181d8bb98), lVar4 == null))
            break;
            FUN_1808ab370(lVar4,uVar1,uVar2,DAT_181db9fe0);
          }
        }
    }

    // Token : 0x6000F21
    // RVA   : 0x9CD4F0   Offset: 0x9CC8F0   Length: 0xFD
    public HeroData GetHero(int heroID)
    {
        bool cVar1;
        ulong uVar2;
        long lVar3;
        if (heroID < 0) {
          return 0;
        }
        if (heroID < *(int *)(*(int64 *)(DAT_181d73d40 + 184) + 0x118)) {
          if (this.HerosDict == null) throw; // [null/range check failed]
          cVar1 = FUN_1808ab490(this.HerosDict,heroID,DAT_181dba068);
          if (!cVar1) {
            return 0;
          }
          lVar3 = this.HerosDict;
        }
        else {
          if (this.TempHerosDict == null) throw; // [null/range check failed]
          cVar1 = FUN_1808ab490(this.TempHerosDict,heroID,DAT_181dba068);
          if (!cVar1) {
            return 0;
          }
          lVar3 = this.TempHerosDict;
        }
        if (lVar3 != null) {
          uVar2 = FUN_1817d9e10(lVar3,heroID,DAT_181dba178);
          return uVar2;
        }
    }

    // Token : 0x6000F22
    // RVA   : 0x9CD1E0   Offset: 0x9CC5E0   Length: 0x1C2
    public ForceData GetForce(int forceID)
    {
        uint uVar1;
        long lVar2;
        long lVar3;
        ulong uVar4;
        long lVar5;
        uint uVar6;
        long lVar7;
        if (this.ForcesDict != null) {
        LAB_1809cd34f:
          if ((forceID == -1) || (forceID == -2)) {
            uVar4 = 0;
          }
          else {
            if (this.ForcesDict == null) throw; // [null/range check failed]
            uVar4 = FUN_1817d9e10(this.ForcesDict,forceID,DAT_181db9760);
          }
          return uVar4;
        }
        uVar4 = il2cpp_internal(DAT_181d80ce8);
        FUN_1808b1370(uVar4,DAT_181db9650);
        this.ForcesDict = uVar4;
        lVar5 = this.Forces;
        uVar6 = 0;
        if (lVar5 != null) {
          lVar7 = 32;
          do {
            if (lVar5.Count <= (int)uVar6) goto LAB_1809cd34f;
            lVar2 = this.ForcesDict;
            if (lVar5 == null) break;
            if (lVar5.Count <= uVar6) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar5 = *(int64 *)(lVar7 + lVar5._items);
            if (lVar5 == null) break;
            lVar3 = this.Forces;
            uVar1 = lVar5._items;
            if (lVar3 == null) break;
            if (lVar3.Count <= uVar6) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            if (lVar2 == null) break;
            FUN_1808ab370(lVar2,uVar1,*(uint64 *)(lVar3._items + lVar7),DAT_181db96d8);
            lVar5 = this.Forces;
            uVar6 = uVar6 + 1;
            lVar7 = lVar7 + 8;
          } while (lVar5 != null);
        }
    }

    // Token : 0x6000F23
    // RVA   : 0x9CC9D0   Offset: 0x9CBDD0   Length: 0x1B8
    public AreaData GetArea(int areaID)
    {
        uint uVar1;
        long lVar2;
        long lVar3;
        ulong uVar4;
        long lVar5;
        uint uVar6;
        long lVar7;
        if (this.AreasDict != null) {
        LAB_1809ccb3b:
          if (areaID == -1) {
            uVar4 = 0;
          }
          else {
            if (this.AreasDict == null) throw; // [null/range check failed]
            uVar4 = FUN_1817d9e10(this.AreasDict,areaID,DAT_181db7df8);
          }
          return uVar4;
        }
        uVar4 = il2cpp_internal(DAT_181d809e8);
        FUN_1808b1370(uVar4,DAT_181db7ce8);
        this.AreasDict = uVar4;
        lVar5 = this.Areas;
        uVar6 = 0;
        if (lVar5 != null) {
          lVar7 = 32;
          do {
            if (lVar5.Count <= (int)uVar6) goto LAB_1809ccb3b;
            lVar2 = this.AreasDict;
            if (lVar5 == null) break;
            if (lVar5.Count <= uVar6) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar5 = *(int64 *)(lVar7 + lVar5._items);
            if (lVar5 == null) break;
            lVar3 = this.Areas;
            uVar1 = lVar5._items;
            if (lVar3 == null) break;
            if (lVar3.Count <= uVar6) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            if (lVar2 == null) break;
            FUN_1808ab370(lVar2,uVar1,*(uint64 *)(lVar3._items + lVar7),DAT_181db7d70);
            lVar5 = this.Areas;
            uVar6 = uVar6 + 1;
            lVar7 = lVar7 + 8;
          } while (lVar5 != null);
        }
    }

    // Token : 0x6000F24
    // RVA   : 0x9CE1C0   Offset: 0x9CD5C0   Length: 0x1B7
    public ResourcePointData GetResourcePoint(int resourcePointID)
    {
        uint uVar1;
        long lVar2;
        long lVar3;
        ulong uVar4;
        long lVar5;
        uint uVar6;
        long lVar7;
        if (this.resourcePointDict != null) {
        LAB_1809ce32b:
          if (resourcePointID < 0) {
            uVar4 = 0;
          }
          else {
            if (this.resourcePointDict == null) throw; // [null/range check failed]
            uVar4 = FUN_1817d9e10(this.resourcePointDict,resourcePointID,DAT_181dbd888);
          }
          return uVar4;
        }
        uVar4 = il2cpp_internal(DAT_181d814e8);
        FUN_1808b1370(uVar4,DAT_181dbd778);
        this.resourcePointDict = uVar4;
        lVar5 = this.ResourcePoints;
        uVar6 = 0;
        if (lVar5 != null) {
          lVar7 = 32;
          do {
            if (lVar5.Count <= (int)uVar6) goto LAB_1809ce32b;
            lVar2 = this.resourcePointDict;
            if (lVar5 == null) break;
            if (lVar5.Count <= uVar6) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar5 = *(int64 *)(lVar7 + lVar5._items);
            if (lVar5 == null) break;
            lVar3 = this.ResourcePoints;
            uVar1 = lVar5._items;
            if (lVar3 == null) break;
            if (lVar3.Count <= uVar6) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            if (lVar2 == null) break;
            FUN_1808ab370(lVar2,uVar1,*(uint64 *)(lVar3._items + lVar7),DAT_181dbd800);
            lVar5 = this.ResourcePoints;
            uVar6 = uVar6 + 1;
            lVar7 = lVar7 + 8;
          } while (lVar5 != null);
        }
    }

    // Token : 0x6000F25
    // RVA   : 0x9CDA60   Offset: 0x9CCE60   Length: 0x1B7
    public InnData GetInn(int innID)
    {
        uint uVar1;
        long lVar2;
        long lVar3;
        ulong uVar4;
        long lVar5;
        uint uVar6;
        long lVar7;
        if (this.innDict != null) {
        LAB_1809cdbcb:
          if (innID < 0) {
            uVar4 = 0;
          }
          else {
            if (this.innDict == null) throw; // [null/range check failed]
            uVar4 = FUN_1817d9e10(this.innDict,innID,DAT_181dba640);
          }
          return uVar4;
        }
        uVar4 = il2cpp_internal(DAT_181d80f68);
        FUN_1808b1370(uVar4,DAT_181dba530);
        this.innDict = uVar4;
        lVar5 = this.Inns;
        uVar6 = 0;
        if (lVar5 != null) {
          lVar7 = 32;
          do {
            if (lVar5.Count <= (int)uVar6) goto LAB_1809cdbcb;
            lVar2 = this.innDict;
            if (lVar5 == null) break;
            if (lVar5.Count <= uVar6) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar5 = *(int64 *)(lVar7 + lVar5._items);
            if (lVar5 == null) break;
            lVar3 = this.Inns;
            uVar1 = lVar5._items;
            if (lVar3 == null) break;
            if (lVar3.Count <= uVar6) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            if (lVar2 == null) break;
            FUN_1808ab370(lVar2,uVar1,*(uint64 *)(lVar3._items + lVar7),DAT_181dba5b8);
            lVar5 = this.Inns;
            uVar6 = uVar6 + 1;
            lVar7 = lVar7 + 8;
          } while (lVar5 != null);
        }
    }

    // Token : 0x6000F26
    // RVA   : 0x9CC050   Offset: 0x9CB450   Length: 0x175
    public virtual object Clone()
    {
        long lVar2;
        ulong uVar3;
        ulong local_38;
        ulong uStack_30;
        uint local_28;
        uint uStack_24;
        uint uStack_20;
        uint32 uStack_1c;
        plVar1 = (int64 *)il2cpp_internal(DAT_181d89210);
        plVar4 = plVar1;
        MemoryStream.ctor(plVar1,1000,0);
        local_38 = 0;
        uStack_30 = 0;
        StreamingContext.ctor(&local_38,64,0);
        lVar2 = il2cpp_internal(DAT_181db1730);
        local_28 = (uint32)local_38;
        uStack_24 = local_38._4_4_;
        uStack_20 = (uint32)uStack_30;
        uStack_1c = uStack_30._4_4_;
        BinaryFormatter.ctor(lVar2,0,&local_28,0,plVar4);
        if (lVar2 != null) {
          BinaryFormatter.Serialize(lVar2,plVar1,this,0);
          if (plVar1 != (int64 *)0) {
            (**(code **)(*plVar1 + 0x2c8))(plVar1,0,0,*(uint64 *)(*plVar1 + 0x2d0));
            uVar3 = BinaryFormatter.Deserialize(lVar2,plVar1,0);
            (**(code **)(*plVar1 + 0x238))(plVar1,*(uint64 *)(*plVar1 + 0x240));
            FUN_180002970(0,DAT_181d78da0,plVar1);
            return uVar3;
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
    }

}
