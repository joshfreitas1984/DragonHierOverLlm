// ============================================================
// Type  : WorldData
// Token : 0x20001DE
// ============================================================

public class WorldData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000C4C
    public int chapter;

    // Token: 0x4000C4D
    public List<int> cityAreaID;

    // Token: 0x4000C4E
    public List<int> villageAreaID;

    // Token: 0x4000C4F
    public List<int> forceAreaID;

    // Token: 0x4000C50
    public List<AreaData> Areas;

    // Token: 0x4000C51
    public List<InnData> Inns;

    // Token: 0x4000C52
    public List<ResourcePointData> ResourcePoints;

    // Token: 0x4000C53
    public List<ForceData> Forces;

    // Token: 0x4000C54
    public List<HeroData> Heros;

    // Token: 0x4000C55
    public List<HeroData> TempHeros;

    // Token: 0x4000C56
    public List<EventData> BigMapRandomEventDatas;

    // Token: 0x4000C57
    public List<EventData> AreaMapRandomEventDatas;

    // Token: 0x4000C58
    public int lastRandomWorldEventDay;

    // Token: 0x4000C59
    public List<int> WorldEventDatasSaveRecord;

    // Token: 0x4000C5A
    public List<EventData> WorldEventDatas;

    // Token: 0x4000C5B
    public List<WorldNewsData> WorldNewsDatas;

    // Token: 0x4000C5C
    public List<MailData> MailDatas;

    // Token: 0x4000C5D
    public bool cheating;

    // Token: 0x4000C5E
    public bool cheated;

    // Token: 0x4000C5F
    public GameMode gameMode;

    // Token: 0x4000C60
    public int gameDifficulty;

    // Token: 0x4000C61
    public bool relaxMode;

    // Token: 0x4000C62
    public TimeData worldTime;

    // Token: 0x4000C63
    public float TimeDifficulty;

    // Token: 0x4000C64
    public float hour;

    // Token: 0x4000C65
    public bool forceMeetingStarted;

    // Token: 0x4000C66
    public bool forcePartyStarted;

    // Token: 0x4000C67
    public int forceMeetingMissedTime;

    // Token: 0x4000C68
    public int playerBetrayForceBadTime;

    // Token: 0x4000C69
    public int playerGetTeacherTime;

    // Token: 0x4000C6A
    public int playerServantForceTime;

    // Token: 0x4000C6B
    public List<InfoData> infos;

    // Token: 0x4000C6C
    public Dictionary<int, TimeData> plotHappened;

    // Token: 0x4000C6D
    public List<int> missionFinished;

    // Token: 0x4000C6E
    public PlotEventLogData PlotEventLog;

    // Token: 0x4000C6F
    public List<WorldPlotEventStartData> worldPlotEventStartData;

    // Token: 0x4000C70
    public Dictionary<int, TimeData> worldPlotEventStartTime;

    // Token: 0x4000C71
    public List<string> tutorialFinished;

    // Token: 0x4000C72
    public bool openLeaveForce;

    // Token: 0x4000C73
    public bool openForceBuilding;

    // Token: 0x4000C74
    public bool openForceAttackResource;

    // Token: 0x4000C75
    public bool openForceAttackArea;

    // Token: 0x4000C76
    public bool openForceAttackBasement;

    // Token: 0x4000C77
    public int monthCatchBadFamePlayerTime;

    // Token: 0x4000C78
    public int monthGambleTime;

    // Token: 0x4000C79
    public int monthPartyTime;

    // Token: 0x4000C7A
    public int monthForcePartyTime;

    // Token: 0x4000C7B
    public int monthDoctorTime;

    // Token: 0x4000C7C
    public int monthPerformForMoneyTime;

    // Token: 0x4000C7D
    public int monthCoachTime;

    // Token: 0x4000C7E
    public int monthAttackMartialClubTime;

    // Token: 0x4000C7F
    public int monthSpeReduceBadFameTime;

    // Token: 0x4000C80
    public int monthSpeAddFameTime;

    // Token: 0x4000C81
    public int monthSpeGetTalentPointTime;

    // Token: 0x4000C82
    public int monthChallengeTime;

    // Token: 0x4000C83
    public int monthBuyAreaInfoTime;

    // Token: 0x4000C84
    public int monthGiveMoneyToGovernTime;

    // Token: 0x4000C85
    public int monthBreakEquipTime;

    // Token: 0x4000C86
    public int monthKillTime;

    // Token: 0x4000C87
    public int monthFreshBountyTime;

    // Token: 0x4000C88
    public int monthFreshAuctionTime;

    // Token: 0x4000C89
    public int monthLeaderInteractOtherForceTime;

    // Token: 0x4000C8A
    public List<List<ItemData>> showRoomItems;

    // Token: 0x4000C8B
    public float showRoomChangeFame;

    // Token: 0x4000C8C
    public int nowWeather;

    // Token: 0x4000C8D
    public float weatherLastTime;

    // Token: 0x4000C8E
    public List<SkinUnlockData> skinUnlockData;

    // Token: 0x4000C8F
    public List<int> speBuildingUnlocked;

    // Token: 0x4000C90
    public int finishForceMissionCount;

    // Token: 0x4000C91
    public int totalFightCount;

    // Token: 0x4000C92
    public int totalWinFightCount;

    // Token: 0x4000C93
    public int totalEnemyKilled;

    // Token: 0x4000C94
    public float totalBadFame;

    // Token: 0x4000C95
    public int studyFightWithGreatHeroSingleWinNum;

    // Token: 0x4000C96
    public int studyFightWithGreatHeroMultiWinNum;

    // Token: 0x4000C97
    public int studyFightWithGreatHeroFinalWinNum;

    // Token: 0x4000C98
    public int totalHeroMeet;

    // Token: 0x4000C99
    public PrisonData prisonData;

    // Token: 0x4000C9A
    public List<int> gameResultTriggered;

    // Token: 0x4000C9B
    public List<BookWriterData> playerBookWriter;

    // Token: 0x4000C9C
    public int thisYearExploreSpeEventNum;

    // Token: 0x4000C9D
    public int thisYearExploreBigSpeEventNum;

    // Token: 0x4000C9E
    public ItemListData governStorage;

    // Token: 0x4000C9F
    public float battleTimeScale;

    // Token: 0x4000CA0
    public List<HeroTagDataBase> tempTagDataBase;

    // Token: 0x4000CA1
    public WeaponResearchData weaponResearchData;

    // Token: 0x4000CA2
    public MeditationData meditationData;

    // Token: 0x4000CA3
    public ForceSpeResearchData forceSpeResearchData;

    // Token: 0x4000CA4
    public HeroSpeAddData forceSpeFunctionAddData;

    // Token: 0x4000CA5
    public SpePoisonData getSpePoisonData;

    // Token: 0x4000CA6
    public SpePoisonData combineSpePoisonData;

    // Token: 0x4000CA7
    public ItemListData speBookStorage;

    // Token: 0x4000CA8
    public HeroSpeAddData speBookStorageSpeAdd;

    // Token: 0x4000CA9
    public SpeSummonResearchData speSummonResearchData;

    // Token: 0x4000CAA
    public int speEnhanceStone;

    // Token: 0x4000CAB
    public List<float> speSpellRate;

    // Token: 0x4000CAC
    public bool autoResearch;

    // Token: 0x4000CAD
    private ItemData playerAuctionItem;

    // Token: 0x4000CAE
    public ItemSortType itemSortType;

    // Token: 0x4000CAF
    public bool itemReverseOrder;

    // Token: 0x4000CB0
    public SkillSortType skillSortType;

    // Token: 0x4000CB1
    public bool skillReverseOrder;

    // Token: 0x4000CB2
    public CustomDifficultyData customDifficultyData;

    // Token: 0x4000CB3
    public Dictionary<int, HeroData> HerosDict;

    // Token: 0x4000CB4
    private readonly object herosDictLock;

    // Token: 0x4000CB5
    public Dictionary<int, HeroData> TempHerosDict;

    // Token: 0x4000CB6
    private readonly object tempHerosDictLock;

    // Token: 0x4000CB7
    public Dictionary<int, ForceData> ForcesDict;

    // Token: 0x4000CB8
    public Dictionary<int, AreaData> AreasDict;

    // Token: 0x4000CB9
    public Dictionary<int, ResourcePointData> resourcePointDict;

    // Token: 0x4000CBA
    public Dictionary<int, InnData> innDict;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000EC1
    // RVA   : 0x9EE100   Offset: 0x9EC900   Length: 0x8
    public ItemData get_PlayerAuctionItem()
    {
        uint64 FUN_1809ee100(int64 this)
        {
        return this.playerAuctionItem;
    }

    // Token : 0x6000EC2
    // RVA   : 0x9EE110   Offset: 0x9EC910   Length: 0x46
    public void set_PlayerAuctionItem(ItemData value)
    {
        void FUN_1809ee110(int64 this,uint64 value)
        {
        this.playerAuctionItem = value;
    }

    // Token : 0x6000EC3
    // RVA   : 0x9ED7A0   Offset: 0x9EBFA0   Length: 0x95C
    public void /*ctor*/()
    {
        ulong uVar1;
        long lVar2;
        long lVar3;
        this.battleTimeScale = 0x3f800000;
        uVar1 = il2cpp_internal(DAT_181d6e930);
        FUN_180f58a90(uVar1,DAT_181d64ff8);
        this.tempTagDataBase = uVar1;
        lVar2 = new ZhSegment(0);
        uVar1 = new HeroSpeAddData(0);
        *(uint64 *)(lVar2 + 32) = uVar1;
        this.weaponResearchData = lVar2;
        this.meditationData = new MeditationData(0);
        this.forceSpeResearchData = new ForceSpeResearchData(0);
        this.forceSpeFunctionAddData = new HeroSpeAddData(0);
        this.getSpePoisonData = new SpePoisonData(0);
        this.combineSpePoisonData = new SpePoisonData(0);
        this.speBookStorage = new ItemListData(0);
        this.speBookStorageSpeAdd = new HeroSpeAddData(0);
        this.speSummonResearchData = new SpeSummonResearchData(0);
        lVar2 = il2cpp_internal(DAT_181d721b0);
        FUN_180f58a90(lVar2,DAT_181d79358);
        if (lVar2 != null) {
          FUN_181805690(lVar2,0,DAT_181d79458);
          FUN_181805690(lVar2,0,DAT_181d79458);
          FUN_181805690(lVar2,0,DAT_181d79458);
          FUN_181805690(lVar2,0,DAT_181d79458);
          FUN_181805690(lVar2,0,DAT_181d79458);
          FUN_181805690(lVar2,0,DAT_181d79458);
          FUN_181805690(lVar2,0,DAT_181d79458);
          FUN_181805690(lVar2,0,DAT_181d79458);
          FUN_181805690(lVar2,0,DAT_181d79458);
          FUN_181805690(lVar2,0,DAT_181d79458);
          this.speSpellRate = lVar2;
          this.customDifficultyData = new CustomDifficultyData(0);
          this.herosDictLock = new ZhSegment(0);
          this.tempHerosDictLock = new ZhSegment(0);
          ZhSegment.Initialize(this,0);
          uVar1 = il2cpp_internal(DAT_181d6c1b0);
          FUN_180f58a90(uVar1,DAT_181d54fe0);
          this.Areas = uVar1;
          uVar1 = il2cpp_internal(DAT_181d6ef30);
          FUN_180f58a90(uVar1,DAT_181d672f8);
          this.Inns = uVar1;
          uVar1 = il2cpp_internal(DAT_181d71d30);
          FUN_180f58a90(uVar1,DAT_181d77fd8);
          this.ResourcePoints = uVar1;
          uVar1 = il2cpp_internal(DAT_181d6dfb0);
          FUN_180f58a90(uVar1,DAT_181d60778);
          this.Forces = uVar1;
          uVar1 = il2cpp_internal(DAT_181d6e6b0);
          FUN_180f58a90(uVar1,DAT_181d63c78);
          this.Heros = uVar1;
          uVar1 = il2cpp_internal(DAT_181d6ee30);
          FUN_180f58a90(uVar1,DAT_181d66d78);
          this.infos = uVar1;
          uVar1 = il2cpp_internal(DAT_181d6e6b0);
          FUN_180f58a90(uVar1,DAT_181d63c78);
          this.TempHeros = uVar1;
          lVar2 = il2cpp_internal(DAT_181d6b630);
          FUN_180f58a90(lVar2,DAT_181d51708);
          lVar3 = il2cpp_internal(DAT_181d6f430);
          FUN_180f58a90(lVar3,DAT_181d691f0);
          if (lVar3 != null) {
            FUN_181827900(lVar3,0,DAT_181d692f0);
            FUN_181827900(lVar3,0,DAT_181d692f0);
            FUN_181827900(lVar3,0,DAT_181d692f0);
            FUN_181827900(lVar3,0,DAT_181d692f0);
            FUN_181827900(lVar3,0,DAT_181d692f0);
            if (lVar2 != null) {
              FUN_181827900(lVar2,lVar3,DAT_181d51788);
              lVar3 = il2cpp_internal(DAT_181d6f430);
              FUN_180f58a90(lVar3,DAT_181d691f0);
              if (lVar3 != null) {
                FUN_181827900(lVar3,0,DAT_181d692f0);
                FUN_181827900(lVar3,0,DAT_181d692f0);
                FUN_181827900(lVar3,0,DAT_181d692f0);
                FUN_181827900(lVar3,0,DAT_181d692f0);
                FUN_181827900(lVar3,0,DAT_181d692f0);
                FUN_181827900(lVar2,lVar3,DAT_181d51788);
                lVar3 = il2cpp_internal(DAT_181d6f430);
                FUN_180f58a90(lVar3,DAT_181d691f0);
                if (lVar3 != null) {
                  FUN_181827900(lVar3,0,DAT_181d692f0);
                  FUN_181827900(lVar3,0,DAT_181d692f0);
                  FUN_181827900(lVar3,0,DAT_181d692f0);
                  FUN_181827900(lVar3,0,DAT_181d692f0);
                  FUN_181827900(lVar3,0,DAT_181d692f0);
                  FUN_181827900(lVar2,lVar3,DAT_181d51788);
                  this.showRoomItems = lVar2;
                  uVar1 = il2cpp_internal(DAT_181d5d0c8);
                  FUN_1808ae540(uVar1,DAT_181d99d20);
                  this.plotHappened = uVar1;
                  uVar1 = il2cpp_internal(DAT_181d5d0c8);
                  FUN_1808ae540(uVar1,DAT_181d99d20);
                  this.worldPlotEventStartTime = uVar1;
                  uVar1 = il2cpp_internal(DAT_181d72a30);
                  FUN_180f58a90(uVar1,DAT_181d7c250);
                  this.tutorialFinished = uVar1;
                  uVar1 = il2cpp_internal(DAT_181d6d930);
                  FUN_180f58a90(uVar1,DAT_181d5e300);
                  this.WorldEventDatas = uVar1;
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x6000EC4
    // RVA   : 0x9EB640   Offset: 0x9E9E40   Length: 0x2FF
    public int GetPlayerForceTotalArea()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
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
              FUN_1817ff240(&local_38,lVar3,DAT_181d550e0);
              local_50 = local_38;
              uStack_4c = uStack_34;
              uStack_48 = uStack_30;
              uStack_44 = uStack_2c;
              local_40 = local_28;
              while( true ) {
                cVar2 = FUN_180d197a0(&local_50,DAT_181d639c8);
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
                if (iVar1 == *(int *)(lVar4 + 132)) goto LAB_1809eb8ad;
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
                if (iVar1 == *(int *)(lVar4 + 132)) goto LAB_1809eb8ad;
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
        LAB_1809eb8ad:
                  iVar5 = iVar5 + 1;
                }
              }
              ZhSegment.Initialize(&local_50,DAT_181d63948);
            }
            return iVar5;
          }
        }
    }

    // Token : 0x6000EC5
    // RVA   : 0x9EB610   Offset: 0x9E9E10   Length: 0x2B
    public int GetPlayerForceMaxAttackTime()
    {
        int iVar1;
        iVar1 = WorldData.GetPlayerForceTotalArea(this,0);
        if (iVar1 < 35) {
          return (14 < iVar1) + true;
        }
        return '\x03';
    }

    // Token : 0x6000EC6
    // RVA   : 0x9EA370   Offset: 0x9E8B70   Length: 0x60
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

    // Token : 0x6000EC7
    // RVA   : 0x9EA800   Offset: 0x9E9000   Length: 0xBF
    public string GetDifficlutyName()
    {
        uint uVar1;
        long lVar2;
        if (this.relaxMode) {
          return "轻松休闲";
        }
        lVar2 = *(int64 *)(*(int64 *)(DAT_181d4ef00 + 184) + 192);
        if (lVar2 != null) {
          uVar1 = this.gameDifficulty;
          if (*(uint32 *)(lVar2 + 24) <= uVar1) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          return lVar2[uVar1];
        }
    }

    // Token : 0x6000EC8
    // RVA   : 0x9E9310   Offset: 0x9E7B10   Length: 0x15C
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
              FUN_181827900(lVar2,tempTag,DAT_181d65078);
              return true;
            }
            if (lVar2 == null) break;
            if (lVar2.Count <= uVar4) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar2 = *(int64 *)(lVar3 + lVar2._items);
            if ((lVar2 == null) || (tempTag == null)) break;
            cVar1 = FUN_1816fd990(lVar2.Count,*(uint64 *)(tempTag + 24),0);
            lVar2 = this.tempTagDataBase;
            if (cVar1) {
              if ((lVar2 != null) && (lVar2 = FUN_180002f80(lVar2,uVar4,DAT_181d65178)) != null) {
                if (*(int *)(tempTag + 32) < *(int *)(lVar2 + 32)) {
                  return false;
                }
                if (this.tempTagDataBase != null) {
                  FUN_18182f280(this.tempTagDataBase,uVar4,tempTag,DAT_181d651f8);
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

    // Token : 0x6000EC9
    // RVA   : 0x9EA010   Offset: 0x9E8810   Length: 0xE8
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
            cVar1 = FUN_1816fd990(lVar3.Count,tagName,0);
            lVar3 = this.tempTagDataBase;
            if (cVar1) {
              if (lVar3 != null) {
                uVar2 = FUN_180002f80(lVar3,uVar5,DAT_181d65178);
                return uVar2;
              }
              break;
            }
            uVar5 = uVar5 + 1;
            lVar4 = lVar4 + 8;
          } while (lVar3 != null);
        }
    }

    // Token : 0x6000ECA
    // RVA   : 0x9E9F30   Offset: 0x9E8730   Length: 0xDC
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
            cVar1 = FUN_1816fd990(lVar2.Count,tagName,0);
            if (cVar1) {
              return uVar4 + 10000;
            }
            lVar2 = this.tempTagDataBase;
            uVar4 = uVar4 + 1;
            lVar3 = lVar3 + 8;
          } while (lVar2 != null);
        }
    }

    // Token : 0x6000ECB
    // RVA   : 0x9E9790   Offset: 0x9E7F90   Length: 0x26A
    public void ClearTempTag(string tagName)
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
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
            cVar1 = FUN_1816fd990(lVar2.Count,tagName,0);
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

    // Token : 0x6000ECC
    // RVA   : 0x9E8E70   Offset: 0x9E7670   Length: 0xE1
    public void AddGameResultTriggered(int resultID)
    {
        bool cVar1;
        ulong uVar2;
        long lVar3;
        lVar3 = this.gameResultTriggered;
        if (lVar3 == null) {
          uVar2 = il2cpp_internal(DAT_181d6f030);
          FUN_180f58a90(uVar2,DAT_181d678f8);
          this.gameResultTriggered = uVar2;
          lVar3 = this.gameResultTriggered;
          if (lVar3 != null)
          {
            }
            cVar1 = FUN_181815240(lVar3,resultID,DAT_181d67bf8);
            if (!cVar1) {
            if (this.gameResultTriggered == null) {
          }
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          FUN_181814fa0(this.gameResultTriggered,resultID,DAT_181d67a78);
        }
    }

    // Token : 0x6000ECD
    // RVA   : 0x9EBE90   Offset: 0x9EA690   Length: 0x5C
    public bool HaveGameResultTriggered(int resultID)
    {
        long lVar1;
        lVar1 = this.gameResultTriggered;
        if (lVar1 == null) {
          return false;
        }
        return CONCAT71((int7)((uint64)lVar1 >> 8),0 < lVar1.Count);
    }

    // Token : 0x6000ECE
    // RVA   : 0x9EBE40   Offset: 0x9EA640   Length: 0x44
    public bool HaveGameResultTriggered()
    {
        long lVar1;
        lVar1 = this.gameResultTriggered;
        if (lVar1 == null) {
          return false;
        }
        return CONCAT71((int7)((uint64)lVar1 >> 8),0 < lVar1.Count);
    }

    // Token : 0x6000ECF
    // RVA   : 0x9EC470   Offset: 0x9EAC70   Length: 0x4E
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

    // Token : 0x6000ED0
    // RVA   : 0x9EA980   Offset: 0x9E9180   Length: 0xB9
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
              uVar4 = FUN_1817ff280(lVar2,targetEvent,DAT_181d5e480);
              return uVar4;
            }
          }
          else if (lVar2 != null) {
            iVar1 = lVar2.Count;
            if (this.AreaMapRandomEventDatas != null) {
              iVar3 = FUN_1817ff280(this.AreaMapRandomEventDatas,targetEvent,DAT_181d5e480);
              return (uint64)(uint32)(iVar3 + iVar1);
            }
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        return 0xffffffff;
    }

    // Token : 0x6000ED1
    // RVA   : 0x9EA8C0   Offset: 0x9E90C0   Length: 0xB8
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

    // Token : 0x6000ED2
    // RVA   : 0x9EC170   Offset: 0x9EA970   Length: 0x2F7
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
        uVar5 = il2cpp_internal(DAT_181d6f030);
        FUN_180f58a90(uVar5,DAT_181d678f8);
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
              if (lVar6 != null) goto LAB_1809ec350;
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
                iVar4 = FUN_1817ff280(lVar3,lVar6,DAT_181d5e480);
              }
              else {
                if (lVar3 == null) break;
                iVar1 = lVar3.Count;
                if (this.AreaMapRandomEventDatas == null) break;
                iVar4 = FUN_1817ff280(this.AreaMapRandomEventDatas,lVar6,DAT_181d5e480);
                iVar4 = iVar4 + iVar1;
              }
            }
            if (lVar2 == null) break;
            FUN_181814fa0(lVar2,iVar4,DAT_181d67a78);
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
              iVar4 = FUN_1817ff280(lVar2,lVar9,DAT_181d5e480);
            }
            else {
              if (lVar2 == null) break;
              iVar1 = lVar2.Count;
              if (this.AreaMapRandomEventDatas == null) break;
              iVar4 = FUN_1817ff280(this.AreaMapRandomEventDatas,lVar9,DAT_181d5e480);
              iVar4 = iVar4 + iVar1;
            }
          }
          if (lVar6 == null) break;
          uVar7 = uVar7 + 1;
          *(int *)(lVar6 + 52) = iVar4;
          lVar6 = this.worldPlotEventStartData;
          lVar8 = lVar8 + 8;
          if (lVar6 == null) break;
        LAB_1809ec350:
          if (lVar6.Count <= (int)uVar7) {
            return;
          }
          if (lVar6 == null) break;
        }
    }

    // Token : 0x6000ED3
    // RVA   : 0x9EBF70   Offset: 0x9EA770   Length: 0x1FF
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
              if (lVar3 != null) goto LAB_1809ec0a0;
              break;
            }
            if (lVar3 == null) break;
            if (lVar3.Count <= uVar4) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            if (-1 < *(int *)(lVar6 + lVar3._items)) {
              lVar3 = this.WorldEventDatas;
              if (this.WorldEventDatasSaveRecord == null) break;
              uVar1 = FUN_1800d6750(this.WorldEventDatasSaveRecord,uVar4,DAT_181d68270);
              uVar2 = WorldData.GetEventSaveIDEvent(this,uVar1,0);
              if (lVar3 == null) break;
              FUN_181827900(lVar3,uVar2,DAT_181d5e380);
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
        LAB_1809ec0a0:
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
            lVar3 = FUN_180002f80(this.worldPlotEventStartData,uVar5,DAT_181d855f8);
            if (((this.worldPlotEventStartData == null) ||
                (lVar6 = FUN_180002f80(this.worldPlotEventStartData,uVar5,DAT_181d855f8)) == null) ||
               (uVar2 = WorldData.GetEventSaveIDEvent(this,*(uint32 *)(lVar6 + 52),0),
               lVar3 == null)) break;
            *(uint64 *)(lVar3 + 56) = uVar2;
          }
        }
    }

    // Token : 0x6000ED4
    // RVA   : 0x9ECD10   Offset: 0x9EB510   Length: 0x419
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
                lVar2 = FUN_180002f80(*(int64 *)(lVar2 + 0x2e8),uVar4,DAT_181d6d4e8);
                if ((lVar2 == null) || (lVar2 = *(int64 *)(lVar2 + 120)) == null) break;
                if (lVar2.Count == null) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar2 = *(int64 *)(lVar2._items + 32);
                lVar3 = WorldData.Player(this,0);
                if ((lVar3 == null) || (*(int64 *)(lVar3 + 0x2e8) == 0)) break;
                lVar3 = FUN_180002f80(*(int64 *)(lVar3 + 0x2e8),uVar4,DAT_181d6d4e8);
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

    // Token : 0x6000ED5
    // RVA   : 0x9EC4C0   Offset: 0x9EACC0   Length: 0x53C
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
                lVar3 = FUN_180002f80(*(int64 *)(lVar3 + 0x2e8),uVar6,DAT_181d6d4e8);
                if ((lVar3 == null) || (*(int64 *)(lVar3 + 120) == 0)) break;
                if (0 < *(int *)(*(int64 *)(lVar3 + 120) + 24)) {
                  lVar3 = WorldData.Player(this,0);
                  if ((lVar3 == null) || (*(int64 *)(lVar3 + 0x2e8) == 0)) break;
                  lVar3 = FUN_180002f80(*(int64 *)(lVar3 + 0x2e8),uVar6,DAT_181d6d4e8);
                  if ((lVar3 == null) || (lVar3 = *(int64 *)(lVar3 + 120)) == null) break;
                  if (lVar3.Count == null) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  lVar3 = *(int64 *)(lVar3._items + 32);
                  if (lVar3 == null) break;
                  if (-1 < lVar3.Count) {
                    lVar3 = WorldData.Player(this,0);
                    if ((lVar3 == null) || (*(int64 *)(lVar3 + 0x2e8) == 0)) break;
                    lVar3 = FUN_180002f80(*(int64 *)(lVar3 + 0x2e8),uVar6,DAT_181d6d4e8);
                    if ((lVar3 == null) || (lVar3 = *(int64 *)(lVar3 + 120)) == null) break;
                    if (lVar3.Count == null) {
                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                    }
                    lVar3 = *(int64 *)(lVar3._items + 32);
                    lVar5 = WorldData.Player(this,0);
                    if ((lVar5 == null) || (*(int64 *)(lVar5 + 0x2e8) == 0)) break;
                    lVar5 = FUN_180002f80(*(int64 *)(lVar5 + 0x2e8),uVar6,DAT_181d6d4e8);
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

    // Token : 0x6000ED6
    // RVA   : 0x9EA7D0   Offset: 0x9E8FD0   Length: 0x27
    public float GetChapterBadFameRate()
    {
        Mathf.Min(0x3f800000,1.0 - (float)this.chapter * 0.1,0);
    }

    // Token : 0x6000ED7
    // RVA   : 0x9ED3E0   Offset: 0x9EBBE0   Length: 0x3BE
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
                FUN_181827900(lVar3,uVar4,DAT_181d7b658);
                lVar3 = this.skinUnlockData;
                if (lVar3 != null) {
                  uVar6 = lVar3.Count;
                  if (uVar6 <= uVar6 - 1) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  lVar3 = *(int64 *)(lVar3._items + 24 + (int64)(int)uVar6 * 8);
                  if (lVar3 != null) {
                    lVar3 = lVar3.Count;
        LAB_1809ed606:
                    if (lVar3 != null) {
                      FUN_181814bb0(lVar3,_skinLv,1,DAT_181d58f90);
                      if (!showInfo) {
                        return;
                      }
                      lVar3 = **(int64 **)(DAT_181d5a578 + 184);
                      lVar5 = *(int64 *)(*(int64 *)(DAT_181d4e010 + 184) + 32);
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
              if (((lVar3 != null) && (lVar3 = FUN_180002f80(lVar3,uVar6,DAT_181d7b758)) != null) &&
                 (lVar3.Count != null)) {
                cVar2 = FUN_180132d10(lVar3.Count,_skinLv,DAT_181d58f10);
                if (cVar2) {
                  return;
                }
                if ((this.skinUnlockData != null) &&
                   (lVar3 = FUN_180002f80(this.skinUnlockData,uVar6,DAT_181d7b758)) != null
                   ) {
                  lVar3 = lVar3.Count;
                  goto LAB_1809ed606;
                }
              }
              break;
            }
            uVar6 = uVar6 + 1;
            lVar5 = lVar5 + 8;
          } while (lVar3 != null);
        }
    }

    // Token : 0x6000ED8
    // RVA   : 0x9ED130   Offset: 0x9EB930   Length: 0x2AA
    public bool SkinUnlocked(int _skinID, int _skinLv)
    {
        var pStatics = *(int64*)(DAT_181d4e010 + 184);
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
                  if (((lVar4 != null) && (lVar4 = FUN_180002f80(lVar4,uVar7,DAT_181d7b758)) != null) &&
                     (lVar4.Count != null)) {
                    uVar2 = FUN_180132d10(lVar4.Count,_skinLv,DAT_181d58f10);
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

    // Token : 0x6000ED9
    // RVA   : 0x9E9510   Offset: 0x9E7D10   Length: 0x139
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

    // Token : 0x6000EDA
    // RVA   : 0x9E9650   Offset: 0x9E7E50   Length: 0x139
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
          lVar1 = **(int64 **)(DAT_181d5a578 + 184);
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

    // Token : 0x6000EDB
    // RVA   : 0x9E9470   Offset: 0x9E7C70   Length: 0x9C
    public void AddWorldNews(string text, int time)
    {
        long lVar1;
        ulong uVar2;
        lVar1 = this.WorldNewsDatas;
        uVar2 = new WorldNewsData(text,time,0);
        if (lVar1 != null) {
          FUN_181827900(lVar1,uVar2,DAT_181d85078);
          return;
        }
    }

    // Token : 0x6000EDC
    // RVA   : 0x9EBEF0   Offset: 0x9EA6F0   Length: 0x7F
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

    // Token : 0x6000EDD
    // RVA   : 0x9EBA50   Offset: 0x9EA250   Length: 0x15F
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

    // Token : 0x6000EDE
    // RVA   : 0x9EB940   Offset: 0x9EA140   Length: 0x10F
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
                 (lVar1 = FUN_180002f80(this.TempHeros,uVar3,DAT_181d643f8)) == null)
              break;
              if (*(char *)(lVar1 + 0x386) != false) {
                if ((this.TempHeros == null) ||
                   (lVar1 = FUN_180002f80(this.TempHeros,uVar3,DAT_181d643f8)) == null)
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

    // Token : 0x6000EDF
    // RVA   : 0x9E9BE0   Offset: 0x9E83E0   Length: 0x178
    public int FindAvailableHeroID()
    {
        bool cVar1;
        long lVar2;
        long lVar3;
        uint uVar4;
        uint uVar5;
        long lVar6;
        lVar2 = il2cpp_internal(DAT_181d6f030);
        FUN_180f58a90(lVar2,DAT_181d678f8);
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
                  (lVar3 = FUN_180002f80(this.Heros,uVar4,DAT_181d643f8)) == null)
                 || (lVar2 == null)) throw; // [null/range check failed]
              FUN_181814fa0(lVar2,*(uint32 *)(lVar3 + 88),DAT_181d67a78);
            }
            lVar3 = this.Heros;
            uVar4 = uVar4 + 1;
            lVar6 = lVar6 + 8;
            if (lVar3 == null) throw; // [null/range check failed]
          }
          if (lVar2 != null) {
            List_1.Sort(lVar2,DAT_181d67ff0);
            while (cVar1 = FUN_181815240(lVar2,uVar5,DAT_181d67bf8), cVar1) {
              uVar5 = uVar5 + 1;
            }
            return uVar5;
          }
        }
    }

    // Token : 0x6000EE0
    // RVA   : 0x9E9D60   Offset: 0x9E8560   Length: 0x1CB
    public int FindAvailableTempHeroID()
    {
        bool cVar1;
        long lVar2;
        long lVar3;
        int iVar4;
        long lVar5;
        uint uVar6;
        lVar2 = il2cpp_internal(DAT_181d6f030);
        FUN_180f58a90(lVar2,DAT_181d678f8);
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
                  (lVar3 = FUN_180002f80(this.TempHeros,uVar6,DAT_181d643f8)) == null)
                 || (lVar2 == null)) throw; // [null/range check failed]
              FUN_181814fa0(lVar2,*(uint32 *)(lVar3 + 88),DAT_181d67a78);
            }
            lVar3 = this.TempHeros;
            uVar6 = uVar6 + 1;
            lVar5 = lVar5 + 8;
            if (lVar3 == null) throw; // [null/range check failed]
          }
          if (lVar2 != null) {
            List_1.Sort(lVar2,DAT_181d67ff0);
            iVar4 = *(int *)(*(int64 *)(DAT_181d4ef00 + 184) + 0x118);
            while (cVar1 = FUN_181815240(lVar2,iVar4,DAT_181d67bf8), cVar1) {
              iVar4 = iVar4 + 1;
            }
            return iVar4;
          }
        }
    }

    // Token : 0x6000EE1
    // RVA   : 0x9E9120   Offset: 0x9E7920   Length: 0x1E9
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
            FUN_18182f280(this.TempHeros,uVar4,target,DAT_181d64478);
            if (this.TempHerosDict == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            FUN_1808ab680(this.TempHerosDict,*(uint32 *)(target + 88),target,
                          DAT_181d94860);
            goto LAB_1809e92b2;
          }
          uVar4 = uVar4 + 1;
        }
        uVar3 = WorldData.FindAvailableTempHeroID(this,0);
        if (target == null) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        HeroData.SetHeroID(target,uVar3,0);
        *(uint8 *)(target + 0x385) = 1;
        if (this.TempHeros == null) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        FUN_181827900(this.TempHeros,target,DAT_181d63d78);
        if (this.TempHerosDict == null) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        FUN_1808ab680(this.TempHerosDict,*(uint32 *)(target + 88),target,DAT_181d94860
                     );
        LAB_1809e92b2:
        if (local_res8[0] != false) {
          Monitor.Exit(uVar1,0);
        }
    }

    // Token : 0x6000EE2
    // RVA   : 0x9ECB90   Offset: 0x9EB390   Length: 0x176
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
        *(uint8 *)(target + 0x387) = 0;
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
            lVar3 = FUN_180002f80(this.TempHeros,uVar4,DAT_181d643f8);
            if (lVar3 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            if (lVar2 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            FUN_18173cb80(lVar2,*(uint32 *)(lVar3 + 88),DAT_181d94970);
            if (this.TempHeros == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            FUN_18182f280(this.TempHeros,uVar4,0,DAT_181d64478);
            break;
          }
          uVar4 = uVar4 + 1;
        }
        if (local_res8[0] != false) {
          Monitor.Exit(uVar1,0);
        }
    }

    // Token : 0x6000EE3
    // RVA   : 0x9EBD70   Offset: 0x9EA570   Length: 0xC5
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

    // Token : 0x6000EE4
    // RVA   : 0x9E8F60   Offset: 0x9E7760   Length: 0x1BD
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
            FUN_18182f280(this.Heros,uVar4,target,DAT_181d64478);
            goto LAB_1809e9096;
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
        FUN_181827900(this.Heros,target,DAT_181d63d78);
        LAB_1809e9096:
        if (this.HerosDict != null) {
          FUN_1808ab680(this.HerosDict,*(uint32 *)(target + 88),target,
                        DAT_181d94860);
          *(uint16 *)(target + 0x385) = 0;
          if (local_res8[0] != false) {
            Monitor.Exit(uVar1,0);
          }
          return;
        }
    }

    // Token : 0x6000EE5
    // RVA   : 0x9ECA00   Offset: 0x9EB200   Length: 0x186
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
        *(uint8 *)(target + 0x387) = 0;
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
            if ((int)lVar2.Count <= (int)uVar4) goto LAB_1809ecb34;
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
          lVar3 = FUN_180002f80(this.Heros,uVar4,DAT_181d643f8);
          if (lVar3 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          if (lVar2 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          FUN_18173cb80(lVar2,*(uint32 *)(lVar3 + 88),DAT_181d94970);
          if (this.Heros == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          FUN_18182f280(this.Heros,uVar4,0,DAT_181d64478);
        }
        LAB_1809ecb34:
        if (local_res8[0] != false) {
          Monitor.Exit(uVar1,0);
        }
    }

    // Token : 0x6000EE6
    // RVA   : 0x9EADA0   Offset: 0x9E95A0   Length: 0xC5
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

    // Token : 0x6000EE7
    // RVA   : 0x9EA5A0   Offset: 0x9E8DA0   Length: 0x224
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
        LAB_1809ea54b:
          if (areaName < 0) {
            uVar4 = 0;
          }
          else {
            if (this.AreasDict == null) throw; // [null/range check failed]
            uVar4 = FUN_1817cc780(this.AreasDict,areaName,DAT_181d92810);
          }
          return uVar4;
        }
        uVar4 = il2cpp_internal(DAT_181d5c0c8);
        FUN_1808ae540(uVar4,DAT_181d92700);
        this.AreasDict = uVar4;
        lVar5 = this.Areas;
        uVar6 = 0;
        if (lVar5 != null) {
          lVar7 = 32;
          do {
            if (lVar5.Count <= (int)uVar6) goto LAB_1809ea54b;
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
            FUN_1808ab680(lVar2,uVar1,*(uint64 *)(lVar3._items + lVar7),DAT_181d92788);
            lVar5 = this.Areas;
            uVar6 = uVar6 + 1;
            lVar7 = lVar7 + 8;
          } while (lVar5 != null);
        }
    }

    // Token : 0x6000EE8
    // RVA   : 0x9EAA40   Offset: 0x9E9240   Length: 0x19D
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
        LAB_1809ead4b:
          if (forceName < 0) {
            uVar4 = 0;
          }
          else {
            if (this.ForcesDict == null) throw; // [null/range check failed]
            uVar4 = FUN_1817cc780(this.ForcesDict,forceName,DAT_181d94178);
          }
          return uVar4;
        }
        uVar4 = il2cpp_internal(DAT_181d5c3c8);
        FUN_1808ae540(uVar4,DAT_181d94068);
        this.ForcesDict = uVar4;
        lVar5 = this.Forces;
        uVar6 = 0;
        if (lVar5 != null) {
          lVar7 = 32;
          do {
            if (lVar5.Count <= (int)uVar6) goto LAB_1809ead4b;
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
            FUN_1808ab680(lVar2,uVar1,*(uint64 *)(lVar3._items + lVar7),DAT_181d940f0);
            lVar5 = this.Forces;
            uVar6 = uVar6 + 1;
            lVar7 = lVar7 + 8;
          } while (lVar5 != null);
        }
    }

    // Token : 0x6000EE9
    // RVA   : 0x9EAE70   Offset: 0x9E9670   Length: 0x60
    public ForceData GetHeroForce(int heroID)
    {
        long lVar1;
        ulong uVar2;
        lVar1 = WorldData.GetHero(this,heroID,0);
        if (lVar1 != null) {
          if (*(int *)(lVar1 + 132) < 0) {
            return 0;
          }
          lVar1 = WorldData.GetHero(this,heroID & 0xffffffff,0);
          if (lVar1 != null) {
            uVar2 = HeroData.GetForce(lVar1,0,0);
            return uVar2;
          }
        }
    }

    // Token : 0x6000EEA
    // RVA   : 0x9EAFE0   Offset: 0x9E97E0   Length: 0x465
    public HeroData GetHero(string heroName)
    {
        bool cVar1;
        ulong uVar2;
        long lVar3;
        if (heroName < 0) {
          return 0;
        }
        if (heroName < *(int *)(*(int64 *)(DAT_181d4ef00 + 184) + 0x118)) {
          if (this.HerosDict == null) throw; // [null/range check failed]
          cVar1 = FUN_1808ab750(this.HerosDict,heroName,DAT_181d948e8);
          if (!cVar1) {
            return 0;
          }
          lVar3 = this.HerosDict;
        }
        else {
          if (this.TempHerosDict == null) throw; // [null/range check failed]
          cVar1 = FUN_1808ab750(this.TempHerosDict,heroName,DAT_181d948e8);
          if (!cVar1) {
            return 0;
          }
          lVar3 = this.TempHerosDict;
        }
        if (lVar3 != null) {
          uVar2 = FUN_1817cc780(lVar3,heroName,DAT_181d949f8);
          return uVar2;
        }
    }

    // Token : 0x6000EEB
    // RVA   : 0x9EA100   Offset: 0x9E8900   Length: 0x26A
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
        uVar2 = il2cpp_internal(DAT_181d5c548);
        FUN_1808ae540(uVar2,DAT_181d947d8);
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
                 (lVar3 = FUN_180002f80(this.Heros,uVar5,DAT_181d643f8)) == null)
              throw; // [null/range check failed]
              uVar1 = *(uint32 *)(lVar3 + 88);
              if ((this.Heros == null) ||
                 (uVar2 = FUN_180002f80(this.Heros,uVar5,DAT_181d643f8), lVar4 == null))
              throw; // [null/range check failed]
              FUN_1808ab680(lVar4,uVar1,uVar2,DAT_181d94860);
            }
            lVar4 = this.Heros;
            uVar5 = uVar5 + 1;
            lVar7 = lVar7 + 8;
            if (lVar4 == null) throw; // [null/range check failed]
          }
          uVar2 = il2cpp_internal(DAT_181d5c548);
          FUN_1808ae540(uVar2,DAT_181d947d8);
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
               (lVar7 = FUN_180002f80(this.TempHeros,uVar6,DAT_181d643f8)) == null)
            break;
            uVar1 = *(uint32 *)(lVar7 + 88);
            if ((this.TempHeros == null) ||
               (uVar2 = FUN_180002f80(this.TempHeros,uVar6,DAT_181d643f8), lVar4 == null))
            break;
            FUN_1808ab680(lVar4,uVar1,uVar2,DAT_181d94860);
          }
        }
    }

    // Token : 0x6000EEC
    // RVA   : 0x9EAEE0   Offset: 0x9E96E0   Length: 0xFD
    public HeroData GetHero(int heroID)
    {
        bool cVar1;
        ulong uVar2;
        long lVar3;
        if (heroID < 0) {
          return 0;
        }
        if (heroID < *(int *)(*(int64 *)(DAT_181d4ef00 + 184) + 0x118)) {
          if (this.HerosDict == null) throw; // [null/range check failed]
          cVar1 = FUN_1808ab750(this.HerosDict,heroID,DAT_181d948e8);
          if (!cVar1) {
            return 0;
          }
          lVar3 = this.HerosDict;
        }
        else {
          if (this.TempHerosDict == null) throw; // [null/range check failed]
          cVar1 = FUN_1808ab750(this.TempHerosDict,heroID,DAT_181d948e8);
          if (!cVar1) {
            return 0;
          }
          lVar3 = this.TempHerosDict;
        }
        if (lVar3 != null) {
          uVar2 = FUN_1817cc780(lVar3,heroID,DAT_181d949f8);
          return uVar2;
        }
    }

    // Token : 0x6000EED
    // RVA   : 0x9EABE0   Offset: 0x9E93E0   Length: 0x1B7
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
        LAB_1809ead4b:
          if (forceID < 0) {
            uVar4 = 0;
          }
          else {
            if (this.ForcesDict == null) throw; // [null/range check failed]
            uVar4 = FUN_1817cc780(this.ForcesDict,forceID,DAT_181d94178);
          }
          return uVar4;
        }
        uVar4 = il2cpp_internal(DAT_181d5c3c8);
        FUN_1808ae540(uVar4,DAT_181d94068);
        this.ForcesDict = uVar4;
        lVar5 = this.Forces;
        uVar6 = 0;
        if (lVar5 != null) {
          lVar7 = 32;
          do {
            if (lVar5.Count <= (int)uVar6) goto LAB_1809ead4b;
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
            FUN_1808ab680(lVar2,uVar1,*(uint64 *)(lVar3._items + lVar7),DAT_181d940f0);
            lVar5 = this.Forces;
            uVar6 = uVar6 + 1;
            lVar7 = lVar7 + 8;
          } while (lVar5 != null);
        }
    }

    // Token : 0x6000EEE
    // RVA   : 0x9EA3E0   Offset: 0x9E8BE0   Length: 0x1B7
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
        LAB_1809ea54b:
          if (areaID < 0) {
            uVar4 = 0;
          }
          else {
            if (this.AreasDict == null) throw; // [null/range check failed]
            uVar4 = FUN_1817cc780(this.AreasDict,areaID,DAT_181d92810);
          }
          return uVar4;
        }
        uVar4 = il2cpp_internal(DAT_181d5c0c8);
        FUN_1808ae540(uVar4,DAT_181d92700);
        this.AreasDict = uVar4;
        lVar5 = this.Areas;
        uVar6 = 0;
        if (lVar5 != null) {
          lVar7 = 32;
          do {
            if (lVar5.Count <= (int)uVar6) goto LAB_1809ea54b;
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
            FUN_1808ab680(lVar2,uVar1,*(uint64 *)(lVar3._items + lVar7),DAT_181d92788);
            lVar5 = this.Areas;
            uVar6 = uVar6 + 1;
            lVar7 = lVar7 + 8;
          } while (lVar5 != null);
        }
    }

    // Token : 0x6000EEF
    // RVA   : 0x9EBBB0   Offset: 0x9EA3B0   Length: 0x1B7
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
        LAB_1809ebd1b:
          if (resourcePointID < 0) {
            uVar4 = 0;
          }
          else {
            if (this.resourcePointDict == null) throw; // [null/range check failed]
            uVar4 = FUN_1817cc780(this.resourcePointDict,resourcePointID,DAT_181d97ee8);
          }
          return uVar4;
        }
        uVar4 = il2cpp_internal(DAT_181d5cb48);
        FUN_1808ae540(uVar4,DAT_181d97dd8);
        this.resourcePointDict = uVar4;
        lVar5 = this.ResourcePoints;
        uVar6 = 0;
        if (lVar5 != null) {
          lVar7 = 32;
          do {
            if (lVar5.Count <= (int)uVar6) goto LAB_1809ebd1b;
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
            FUN_1808ab680(lVar2,uVar1,*(uint64 *)(lVar3._items + lVar7),DAT_181d97e60);
            lVar5 = this.ResourcePoints;
            uVar6 = uVar6 + 1;
            lVar7 = lVar7 + 8;
          } while (lVar5 != null);
        }
    }

    // Token : 0x6000EF0
    // RVA   : 0x9EB450   Offset: 0x9E9C50   Length: 0x1B7
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
        LAB_1809eb5bb:
          if (innID < 0) {
            uVar4 = 0;
          }
          else {
            if (this.innDict == null) throw; // [null/range check failed]
            uVar4 = FUN_1817cc780(this.innDict,innID,DAT_181d94ec0);
          }
          return uVar4;
        }
        uVar4 = il2cpp_internal(DAT_181d5c648);
        FUN_1808ae540(uVar4,DAT_181d94db0);
        this.innDict = uVar4;
        lVar5 = this.Inns;
        uVar6 = 0;
        if (lVar5 != null) {
          lVar7 = 32;
          do {
            if (lVar5.Count <= (int)uVar6) goto LAB_1809eb5bb;
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
            FUN_1808ab680(lVar2,uVar1,*(uint64 *)(lVar3._items + lVar7),DAT_181d94e38);
            lVar5 = this.Inns;
            uVar6 = uVar6 + 1;
            lVar7 = lVar7 + 8;
          } while (lVar5 != null);
        }
    }

    // Token : 0x6000EF1
    // RVA   : 0x9E9A00   Offset: 0x9E8200   Length: 0x1DD
    public virtual object Clone()
    {
        long lVar2;
        ulong uVar3;
        ushort uVar5;
        ulong local_38;
        ulong uStack_30;
        uint local_28;
        uint uStack_24;
        uint uStack_20;
        uint32 uStack_1c;
        uint64 uVar6;
        uVar6 = 0;
        plVar1 = (int64 *)il2cpp_internal(DAT_181d63ff0);
        plVar7 = plVar1;
        MemoryStream.ctor(plVar1,1000,0);
        local_38 = 0;
        uStack_30 = 0;
        StreamingContext.ctor(&local_38,64,0);
        lVar2 = il2cpp_internal(DAT_181d8c5a8);
        local_28 = (uint32)local_38;
        uStack_24 = local_38._4_4_;
        uStack_20 = (uint32)uStack_30;
        uStack_1c = uStack_30._4_4_;
        BinaryFormatter.ctor(lVar2,0,&local_28,0,plVar7);
        if (lVar2 == null) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        BinaryFormatter.Serialize(lVar2,plVar1,this,0);
        if (plVar1 == (int64 *)0) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        (**(code **)(*plVar1 + 0x2c8))(plVar1,0,0,*(uint64 *)(*plVar1 + 0x2d0));
        uVar3 = BinaryFormatter.Deserialize(lVar2,plVar1,0);
        (**(code **)(*plVar1 + 0x238))(plVar1,*(uint64 *)(*plVar1 + 0x240));
        lVar2 = *plVar1;
        if (*(uint16 *)(lVar2 + 0x12a) != 0) {
          do {
            if (*(int64 *)(*(int64 *)(lVar2 + 176) + uVar6 * 16) == DAT_181d53c70) {
              puVar4 = (uint64 *)
                       ((int64)*(int *)(*(int64 *)(lVar2 + 176) + 8 + uVar6 * 16) * 16 + 0x138
                       + lVar2);
              goto LAB_1809e9b84;
            }
            uVar5 = (short)uVar6 + 1;
            uVar6 = (uint64)uVar5;
          } while (uVar5 < *(uint16 *)(lVar2 + 0x12a));
        }
        puVar4 = (uint64 *)FUN_1800914f0(plVar1,DAT_181d53c70,0);
        LAB_1809e9b84:
        (*(code *)*puVar4)(plVar1,puVar4[1]);
        return uVar3;
    }

}
