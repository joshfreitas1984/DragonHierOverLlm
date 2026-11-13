// ============================================================
// Type  : GameDataController
// Token : 0x20002AD
// ============================================================

public class GameDataController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400155D
    public List<Task> Tasks;

    // Token: 0x400155E
    public string saveDataPath;

    // Token: 0x400155F
    public string backupDataPath;

    // Token: 0x4001560
    public static List<string> saveDataFileName;

    // Token: 0x4001561
    public GameSaveData gameSaveData;

    // Token: 0x4001562
    public const string playerprefDataFileName;

    // Token: 0x4001563
    public static RePlayerPrefData playerPrefData;

    // Token: 0x4001564
    public static float soundEffectVolume;

    // Token: 0x4001565
    public const string ExternalStorageDataFileName;

    // Token: 0x4001566
    public static ItemListData ExternalStorage;

    // Token: 0x4001567
    public List<RareLvData> rareLvData;

    // Token: 0x4001568
    public List<ForceLevelData> forceLevelData;

    // Token: 0x4001569
    public EventData AiForceAttackPlayerAreaEvent;

    // Token: 0x400156A
    public EventData AiForceAttackPlayerResourcePointEvent;

    // Token: 0x400156B
    public EventData AiForceAttackFriendAreaEvent;

    // Token: 0x400156C
    public List<ForceJobSettingDataBase> forceJobSettingDataBase;

    // Token: 0x400156D
    public List<SkillBulletData> SkillBulletDataBase;

    // Token: 0x400156E
    public List<string> familyNameDataBase;

    // Token: 0x400156F
    public List<string> givenNameDataBase;

    // Token: 0x4001570
    public List<string> maleGivenNameDataBase;

    // Token: 0x4001571
    public List<string> femaleGivenNameDataBase;

    // Token: 0x4001572
    public List<HeroSpeAddDataBase> speAddDataBase;

    // Token: 0x4001573
    public List<ForceSpeAddDataBase> forceSpeAddDataBase;

    // Token: 0x4001574
    public Dictionary<int, ForceTechDataBase> forceTechDataBase;

    // Token: 0x4001575
    public List<int> randomSpeAddAvailableID;

    // Token: 0x4001576
    public List<int> randomSpeAddNegativeAvailableID;

    // Token: 0x4001577
    public List<int> randomSpeAddSelfBuffID;

    // Token: 0x4001578
    public List<int> randomSpeAddEnemyBuffID;

    // Token: 0x4001579
    public Dictionary<int, AreaData> areaDataBase;

    // Token: 0x400157A
    public Dictionary<int, ForceData> forceDataBase;

    // Token: 0x400157B
    public List<int> bigForceIDList;

    // Token: 0x400157C
    public Dictionary<int, AreaBuildingDataBase> buildingDataBase;

    // Token: 0x400157D
    public List<List<int>> buildingDataBaseTypeIDList;

    // Token: 0x400157E
    public Dictionary<int, ItemData> weaponDataBase;

    // Token: 0x400157F
    public Dictionary<int, string> weaponSingleNameDataBase;

    // Token: 0x4001580
    public Dictionary<int, ItemData> armorDataBase;

    // Token: 0x4001581
    public Dictionary<int, ItemData> helmetDataBase;

    // Token: 0x4001582
    public Dictionary<int, ItemData> shoesDataBase;

    // Token: 0x4001583
    public Dictionary<int, string> equipmentSingleNameDataBase;

    // Token: 0x4001584
    public Dictionary<int, ItemData> medDataBase;

    // Token: 0x4001585
    public Dictionary<int, ItemData> foodDataBase;

    // Token: 0x4001586
    public Dictionary<int, ItemData> horseDataBase;

    // Token: 0x4001587
    public Dictionary<int, KungfuSkillData> kungfuSkillDataBase;

    // Token: 0x4001588
    public Dictionary<int, KungfuSkillData> summonSkillDataBase;

    // Token: 0x4001589
    public Dictionary<int, List<List<KungfuSkillData>>> kungfuSkillDataList;

    // Token: 0x400158A
    public List<List<string>> HeroNatureTalkTextDataBase;

    // Token: 0x400158B
    public List<HeroSpeTalkTextDataBase> HeroSpeTalkTextDataBase;

    // Token: 0x400158C
    public Dictionary<int, HeroData> SpeHeroDataBase;

    // Token: 0x400158D
    public HeroFaceData MaleFaceTotalNum;

    // Token: 0x400158E
    public HeroFaceData FemaleFaceTotalNum;

    // Token: 0x400158F
    public List<List<int>> MaleFaceRandomID;

    // Token: 0x4001590
    public List<List<int>> FemaleFaceRandomID;

    // Token: 0x4001591
    public Dictionary<int, PlotData> PlotDataBase;

    // Token: 0x4001592
    public Dictionary<int, SummonData> SummonDataBase;

    // Token: 0x4001593
    public Dictionary<int, ResourcePointTypeData> resourcePointTypeDataBase;

    // Token: 0x4001594
    public Dictionary<int, ResourcePointData> resourcePointDataBase;

    // Token: 0x4001595
    public Dictionary<int, HeroTagDataBase> heroTagDataBase;

    // Token: 0x4001596
    public Dictionary<int, InnData> innDataBase;

    // Token: 0x4001597
    public List<SkinDataBase> skinDataBase;

    // Token: 0x4001598
    public List<List<int>> CheckReplaceSkillIconList;

    // Token: 0x4001599
    public List<BookTypeIconData> bookTypeIconDataBase;

    // Token: 0x400159A
    public List<AchievementData> AchievementData;

    // Token: 0x400159B
    public List<string> tipsData;

    // Token: 0x400159C
    public List<MartialClubDataBase> martialclubDataBase;

    // Token: 0x400159D
    public List<string> loveableSpeHeroList;

    // Token: 0x400159E
    public Dictionary<string, bool> SpeSkeletonName;

    // Token: 0x400159F
    public Dictionary<int, BattleData> BattleDataBase;

    // Token: 0x40015A0
    public List<PoetryData> poetryDataBase;

    // Token: 0x40015A1
    public AudioClip dingSound;

    // Token: 0x40015A2
    private static GameDataController _instance;

    // Token: 0x40015A3
    private bool CISFilterWordsSDKInited;

    // Token: 0x40015A4
    private bool NameCensorWordsChecked;

    // Token: 0x40015A5
    private float keepTaskTime;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60016B8
    // RVA   : 0xBCA6D0   Offset: 0xBC94D0   Length: 0x58
    public static GameDataController get_Instance()
    {
        return *(uint64 *)(*(int64 *)(DAT_181e528f8 + 184) + 32);
    }

    // Token : 0x60016B9
    // RVA   : 0xBB9870   Offset: 0xBB8670   Length: 0x20B
    public bool HaveTask()
    {
        bool cVar1;
        int iVar2;
        long lVar3;
        long lVar4;
        uint uVar5;
        if (this.Tasks == null) {
        LAB_180bb9a76:
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        uVar5 = this.Tasks.Count - 1;
        if (-1 < (int)uVar5) {
          lVar4 = (int64)(int)uVar5 * 8 + 32;
          do {
            lVar3 = this.Tasks;
            if (lVar3 == null) goto LAB_180bb9a76;
            if (lVar3.Count <= uVar5) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            if (*(int64 *)(lVar3._items + lVar4) != 0) {
              if ((this.Tasks == null) ||
                 (lVar3 = FUN_1800024b0(this.Tasks,uVar5,DAT_181e88bf0)) == null)
              goto LAB_180bb9a76;
              iVar2 = Task.get_Status(lVar3,0);
              if (iVar2 != 5) {
                if ((this.Tasks == null) ||
                   (lVar3 = FUN_1800024b0(this.Tasks,uVar5,DAT_181e88bf0)) == null)
                goto LAB_180bb9a76;
                iVar2 = Task.get_Status(lVar3,0);
                if (iVar2 != 6) {
                  if ((this.Tasks == null) ||
                     (lVar3 = FUN_1800024b0(this.Tasks,uVar5,DAT_181e88bf0), lVar3 == null
                     )) goto LAB_180bb9a76;
                  iVar2 = Task.get_Status(lVar3,0);
                  if (iVar2 != 7) {
                    if ((this.Tasks == null) ||
                       (lVar3 = FUN_1800024b0(this.Tasks,uVar5,DAT_181e88bf0),
                       lVar3 == null)) goto LAB_180bb9a76;
                    cVar1 = Task.get_IsCanceled(lVar3,0);
                    if (!cVar1) {
                      if ((this.Tasks == null) ||
                         (lVar3 = FUN_1800024b0(this.Tasks,uVar5,DAT_181e88bf0),
                         lVar3 == null)) goto LAB_180bb9a76;
                      cVar1 = Task.get_IsCompleted(lVar3,0);
                      if (!cVar1) {
                        if ((this.Tasks == null) ||
                           (lVar3 = FUN_1800024b0(this.Tasks,uVar5,DAT_181e88bf0),
                           lVar3 == null)) goto LAB_180bb9a76;
                        cVar1 = Task.get_IsFaulted(lVar3,0);
                        if (!cVar1) {
                          return true;
                        }
                      }
                    }
                  }
                }
              }
            }
            if (this.Tasks == null) goto LAB_180bb9a76;
            FUN_181763390(this.Tasks,uVar5,DAT_181e88af0);
            lVar4 = lVar4 + -8;
            uVar5 = uVar5 - 1;
          } while (-1 < (int)uVar5);
        }
        return false;
    }

    // Token : 0x60016BA
    // RVA   : 0xBB4820   Offset: 0xBB3620   Length: 0x5E
    public void AddTask(Task task)
    {
        if (this.Tasks != null) {
          FUN_18175de30(this.Tasks,task,DAT_181e888f0);
          this.keepTaskTime = 0;
          return;
        }
    }

    // Token : 0x60016BB
    // RVA   : 0xBB5530   Offset: 0xBB4330   Length: 0x36
    public bool CanSaveLoad()
    {
        bool cVar1;
        byte uVar2;
        cVar1 = GameDataController.HaveTask(this,0);
        if (cVar1) {
          return false;
        }
        if (this.gameSaveData != null) {
          uVar2 = GameSaveData.CheckAllFinished(this.gameSaveData,0);
          return uVar2;
        }
    }

    // Token : 0x60016BC
    // RVA   : 0xBB5510   Offset: 0xBB4310   Length: 0x1D
    public bool CanLoad()
    {
        if (this.gameSaveData != null) {
          GameSaveData.CheckAllFinished(this.gameSaveData,0);
          return;
        }
    }

    // Token : 0x60016BD
    // RVA   : 0xBB4880   Offset: 0xBB3680   Length: 0xC81
    private void Awake()
    {
        bool cVar1;
        int iVar2;
        ulong uVar3;
        ulong uVar4;
        ulong uVar5;
        long lVar6;
        long lVar7;
        uint uVar10;
        int[] local_res18 = new int[2];
        local_res18[0] = 0;
        uVar3 = GameController.ChangeAllAreaStateIDs;
        cVar1 = Object.op_Equality(uVar3,0,0);
        if (!cVar1) {
          uVar3 = Component.get_gameObject(this,0);
          Object.Destroy(uVar3,0);
          return;
        }
        GameController.ChangeAllAreaStateIDs = this;
        uVar3 = Component.get_gameObject(this,0);
        Object.DontDestroyOnLoad(uVar3,0);
        uVar3 = new CultureInfo("en-US",0);
        CultureInfo.set_DefaultThreadCurrentCulture(uVar3,0);
        this.gameSaveData = new GameSaveData(0);
        lVar6 = this.gameSaveData;
        uVar3 = FUN_180b003a0(0);
        if (lVar6 == null) throw; // [null/range check failed]
        lVar6.key = uVar3;
        iVar2 = Application.get_platform(0);
        if (iVar2 == 8) {
        LAB_180bb4b96:
          uVar3 = Application.get_persistentDataPath(0);
          uVar3 = String.Concat(uVar3,"/Save",0);
          this.saveDataPath = uVar3;
          uVar3 = Application.get_persistentDataPath(0);
          uVar3 = String.Concat(uVar3,"/Save_backup",0);
          this.backupDataPath = uVar3;
          Application.set_targetFrameRate(30);
        }
        else {
          iVar2 = Application.get_platform(0);
          if (iVar2 == 11) goto LAB_180bb4b96;
          uVar3 = Application.get_dataPath(0);
          uVar3 = String.Concat(uVar3,"/Save",0);
          this.saveDataPath = uVar3;
          uVar3 = Application.get_persistentDataPath(0);
          uVar3 = String.Concat(uVar3,"/Save_backup",0);
          this.backupDataPath = uVar3;
        }
        GameDataController.LoadPlayerprefData(this,0);
        GameDataController.LoadExternalStorageData(this,0);

        if ((lVar6 = GameController.difficultyExtraPoint?.key) != null) {
          cVar1 = PlayerPrefDictionary.ContainsKey(lVar6,"Volume",0);
          if (!cVar1) {

            if ((lVar6 = GameController.difficultyExtraPoint?.key) == null) throw; // [null/range check failed]
            PlayerPrefDictionary.SetKey(lVar6,"Volume",0x3f800000,0);
          }

          if ((lVar6 = GameController.difficultyExtraPoint?.key) != null) {
            cVar1 = PlayerPrefDictionary.ContainsKey(lVar6,"BgmVolume",0);
            if (!cVar1) {

              if ((lVar6 = GameController.difficultyExtraPoint?.key) == null) throw; // [null/range check failed]
              PlayerPrefDictionary.SetKey(lVar6,"BgmVolume",0x3f333333,0);
            }

            if ((lVar6 = GameController.difficultyExtraPoint?.key) != null) {
              cVar1 = PlayerPrefDictionary.ContainsKey(lVar6,"SoundEffectVolume",0);
              if (!cVar1) {

                if ((lVar6 = GameController.difficultyExtraPoint?.key) == null) throw; // [null/range check failed]
                PlayerPrefDictionary.SetKey(lVar6,"SoundEffectVolume",0x3f800000,0);
              }

              if ((lVar6 = GameController.difficultyExtraPoint?.key) != null) {
                uVar10 = PlayerPrefDictionary.GetFloat(lVar6,"Volume",0);
                AudioListener.set_volume(uVar10,0);

                if ((lVar6 = GameController.difficultyExtraPoint?.key) != null) {
                  uVar10 = PlayerPrefDictionary.GetFloat(lVar6,"SoundEffectVolume",0);
                  GameController.CheckShowSpeHero = uVar10;

                  if ((lVar6 = GameController.difficultyExtraPoint?.key) != null) {
                    cVar1 = PlayerPrefDictionary.ContainsKey(lVar6,"AutoSave",0);
                    if (!cVar1) {

                      if ((lVar6 = GameController.difficultyExtraPoint?.key) == null)
                      throw; // [null/range check failed]
                      PlayerPrefDictionary.SetKey(lVar6,"AutoSave",1);
                    }

                    if ((lVar6 = GameController.difficultyExtraPoint?.key) != null) {
                      cVar1 = PlayerPrefDictionary.ContainsKey(lVar6,"FightViewFollow",0);
                      if (!cVar1) {

                        if ((lVar6 = GameController.difficultyExtraPoint?.key) == null)
                        throw; // [null/range check failed]
                        PlayerPrefDictionary.SetKey(lVar6,"FightViewFollow",1);
                      }

                      if ((lVar6 = GameController.difficultyExtraPoint?.key) != null) {
                        cVar1 = PlayerPrefDictionary.ContainsKey(lVar6,"FightScreenShake",0);
                        if (!cVar1) {

                          if ((lVar6 = GameController.difficultyExtraPoint?.key) == null)
                          throw; // [null/range check failed]
                          PlayerPrefDictionary.SetKey(lVar6,"FightScreenShake",1);
                        }
                        if (**(int **)(DAT_181e538e8 + 184) == 2) {

                          if ((lVar6 = GameController.difficultyExtraPoint?.key) == null)
                          throw; // [null/range check failed]
                          iVar2 = PlayerPrefDictionary.GetInt(lVar6,"GameStartTime",0);
                          if (iVar2 < 1) {
                            local_res18[0] = 1;
                            do {
                              uVar3 = Application.get_streamingAssetsPath(0);
                              uVar4 = Int32.ToString(local_res18,0);
                              uVar3 = String.Concat(uVar3,"/TestSave/SaveSlot",uVar4,0);
                              cVar1 = Directory.Exists(this.saveDataPath,0);
                              if (!cVar1) {
                                Directory.CreateDirectory(this.saveDataPath,0);
                              }
                              uVar4 = this.saveDataPath;
                              uVar5 = Int32.ToString(local_res18,0);
                              uVar4 = String.Concat(uVar4,"/SaveSlot",uVar5,0);
                              GameDataController.CopyTestSave(this,uVar3,uVar4);
                              local_res18[0] = local_res18[0] + 1;
                            } while (local_res18[0] < 4);
                          }
                        }
                        uVar3 = Application.get_streamingAssetsPath(0);
                        uVar4 = String.Concat(**(uint64 **)(DAT_181e955f8 + 184),".txt",0);
                        uVar3 = Path.Combine(uVar3,uVar4,0);
                        uVar4 = Application.get_persistentDataPath(0);
                        uVar5 = String.Concat(**(uint64 **)(DAT_181e955f8 + 184),".txt",0);
                        uVar4 = Path.Combine(uVar4,uVar5,0);
                        lVar6 = new WWW(uVar3,0);
                        do {
                          if (lVar6 == null) throw; // [null/range check failed]
                          cVar1 = WWW.get_isDone(lVar6,0);
                        } while (!cVar1);
                        uVar3 = WWW.get_bytes(lVar6,0);
                        File.WriteAllBytes(uVar4,uVar3,0);
                        if (**(int **)(DAT_181e538e8 + 184) == 2) {
                          lVar6 = CISFilterWordsSDK.get_Instance(0);
                          uVar3 = new OnTooltipCB(this,DAT_181e50a38,DAT_181e78a00);
                          uVar4 = PlayerPrefs.GetString("CensorWordsEtag",0);
                          if (lVar6 == null) throw; // [null/range check failed]
                          CISFilterWordsSDK.LoadOnlineCensorWordsSet(lVar6,uVar3,uVar4,0);
                        }
                        else {
                          lVar6 = CISFilterWordsSDK.get_Instance(0);
                          lVar7 = CISFilterWordsSDK.get_Instance(0);
                          if (lVar7 == null) throw; // [null/range check failed]
                          uVar3 = CISFilterWordsSDK.LoadLocalCensorWordsSet(lVar7,0);
                          if (lVar6 == null) throw; // [null/range check failed]
                          CISFilterWordsSDK.Init(lVar6,uVar3,0,0);
                          this.CISFilterWordsSDKInited = 1;
                        }

                        if ((lVar6 = GameController.difficultyExtraPoint?.key) != null) {
                          iVar2 = PlayerPrefDictionary.GetInt(lVar6,"GameStartTime",0);
                          PlayerPrefDictionary.SetKey(lVar6,"GameStartTime",iVar2 + 1,0);
                          return;
                        }
                      }
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x60016BE
    // RVA   : 0xBB61F0   Offset: 0xBB4FF0   Length: 0x2B8
    public void CheckNameCensorWords()
    {
        long lVar1;
        bool cVar2;
        long lVar3;
        uint uVar4;
        long lVar5;
        if ((!this.CISFilterWordsSDKInited) || (this.NameCensorWordsChecked)) {
          return;
        }
        if (this.familyNameDataBase != null) {
          uVar4 = this.familyNameDataBase.Count - 1;
          if (-1 < (int)uVar4) {
            lVar5 = (int64)(int)uVar4 * 8 + 32;
            do {
              lVar3 = CISFilterWordsSDK.get_Instance(0);
              lVar1 = this.familyNameDataBase;
              if (lVar1 == null) throw; // [null/range check failed]
              if (lVar1.Count <= uVar4) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              if (lVar3 == null) throw; // [null/range check failed]
              cVar2 = CISFilterWordsSDK.IsContainCensorWords
                                (lVar3,*(uint64 *)(lVar5 + lVar1._items),0);
              if (cVar2) {
                if (this.familyNameDataBase == null) throw; // [null/range check failed]
                FUN_181763390(this.familyNameDataBase,uVar4);
              }
              lVar5 = lVar5 + -8;
              uVar4 = uVar4 - 1;
            } while (-1 < (int)uVar4);
          }
          if (this.givenNameDataBase != null) {
            uVar4 = this.givenNameDataBase.Count - 1;
            if (-1 < (int)uVar4) {
              lVar5 = (int64)(int)uVar4 * 8 + 32;
              do {
                lVar3 = CISFilterWordsSDK.get_Instance(0);
                lVar1 = this.givenNameDataBase;
                if (lVar1 == null) throw; // [null/range check failed]
                if (lVar1.Count <= uVar4) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                if (lVar3 == null) throw; // [null/range check failed]
                cVar2 = CISFilterWordsSDK.IsContainCensorWords
                                  (lVar3,*(uint64 *)(lVar5 + lVar1._items),0);
                if (cVar2) {
                  if (this.givenNameDataBase == null) throw; // [null/range check failed]
                  FUN_181763390(this.givenNameDataBase,uVar4);
                }
                lVar5 = lVar5 + -8;
                uVar4 = uVar4 - 1;
              } while (-1 < (int)uVar4);
            }
            if (this.maleGivenNameDataBase != null) {
              uVar4 = this.maleGivenNameDataBase.Count - 1;
              if (-1 < (int)uVar4) {
                lVar5 = (int64)(int)uVar4 * 8 + 32;
                do {
                  lVar3 = CISFilterWordsSDK.get_Instance(0);
                  lVar1 = this.maleGivenNameDataBase;
                  if (lVar1 == null) throw; // [null/range check failed]
                  if (lVar1.Count <= uVar4) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  if (lVar3 == null) throw; // [null/range check failed]
                  cVar2 = CISFilterWordsSDK.IsContainCensorWords
                                    (lVar3,*(uint64 *)(lVar5 + lVar1._items),0);
                  if (cVar2) {
                    if (this.maleGivenNameDataBase == null) throw; // [null/range check failed]
                    FUN_181763390(this.maleGivenNameDataBase,uVar4);
                  }
                  lVar5 = lVar5 + -8;
                  uVar4 = uVar4 - 1;
                } while (-1 < (int)uVar4);
              }
              if (this.femaleGivenNameDataBase != null) {
                uVar4 = this.femaleGivenNameDataBase.Count - 1;
                if (-1 < (int)uVar4) {
                  lVar5 = (int64)(int)uVar4 * 8 + 32;
                  do {
                    lVar3 = CISFilterWordsSDK.get_Instance(0);
                    lVar1 = this.femaleGivenNameDataBase;
                    if (lVar1 == null) throw; // [null/range check failed]
                    if (lVar1.Count <= uVar4) {
                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                    }
                    if (lVar3 == null) throw; // [null/range check failed]
                    cVar2 = CISFilterWordsSDK.IsContainCensorWords
                                      (lVar3,*(uint64 *)(lVar5 + lVar1._items),0);
                    if (cVar2) {
                      if (this.femaleGivenNameDataBase == null) throw; // [null/range check failed]
                      FUN_181763390(this.femaleGivenNameDataBase,uVar4);
                    }
                    lVar5 = lVar5 + -8;
                    uVar4 = uVar4 - 1;
                  } while (-1 < (int)uVar4);
                }
                this.NameCensorWordsChecked = 1;
                return;
              }
            }
          }
        }
    }

    // Token : 0x60016BF
    // RVA   : 0xBB9A80   Offset: 0xBB8880   Length: 0x150
    public void InitWithEtag()
    {
        long lVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        if (**(int **)(DAT_181e538e8 + 184) == 2) {
          lVar1 = CISFilterWordsSDK.get_Instance(0);
          uVar3 = new OnTooltipCB(this,DAT_181e50a38,DAT_181e78a00);
          uVar4 = PlayerPrefs.GetString("CensorWordsEtag",0);
          if (lVar1 != null) {
            CISFilterWordsSDK.LoadOnlineCensorWordsSet(lVar1,uVar3,uVar4,0);
            return;
          }
        }
        else {
          lVar1 = CISFilterWordsSDK.get_Instance(0);
          lVar2 = CISFilterWordsSDK.get_Instance(0);
          if (lVar2 != null) {
            uVar3 = CISFilterWordsSDK.LoadLocalCensorWordsSet(lVar2,0);
            if (lVar1 != null) {
              CISFilterWordsSDK.Init(lVar1,uVar3,0,0);
              this.CISFilterWordsSDKInited = 1;
              return;
            }
          }
        }
    }

    // Token : 0x60016C0
    // RVA   : 0xBB9BE0   Offset: 0xBB89E0   Length: 0x46
    public void InitWithLocalFile()
    {
        long lVar1;
        ulong uVar2;
        lVar1 = CISFilterWordsSDK.get_Instance(0);
        if (lVar1 != null) {
          uVar2 = CISFilterWordsSDK.LoadLocalCensorWordsSet(lVar1,0);
          lVar1 = CISFilterWordsSDK.get_Instance(0);
          if (lVar1 != null) {
            CISFilterWordsSDK.Init(lVar1,uVar2,0,0);
            return;
          }
        }
    }

    // Token : 0x60016C1
    // RVA   : 0xBB6530   Offset: 0xBB5330   Length: 0x160
    public void CopyLocalCensorWordsFile()
    {
        ulong uVar1;
        ulong uVar2;
        ulong uVar3;
        bool cVar4;
        long lVar5;
        uVar1 = Application.get_streamingAssetsPath(0);
        uVar2 = String.Concat(**(uint64 **)(DAT_181e955f8 + 184),".txt",0);
        uVar1 = Path.Combine(uVar1,uVar2,0);
        uVar2 = Application.get_persistentDataPath(0);
        uVar3 = String.Concat(**(uint64 **)(DAT_181e955f8 + 184),".txt",0);
        uVar2 = Path.Combine(uVar2,uVar3,0);
        lVar5 = new WWW(uVar1,0);
        do {
          if (lVar5 == null) {
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          cVar4 = WWW.get_isDone(lVar5,0);
        } while (!cVar4);
        uVar1 = WWW.get_bytes(lVar5,0);
        File.WriteAllBytes(uVar2,uVar1,0);
    }

    // Token : 0x60016C2
    // RVA   : 0xBB66A0   Offset: 0xBB54A0   Length: 0x26E
    public void CopyTestSave(string sourcePath, string destPath)
    {
        bool cVar1;
        ulong uVar2;
        ulong uVar3;
        long lVar4;
        int iVar5;
        cVar1 = Directory.Exists(destPath,0);
        if (!cVar1) {
          Directory.CreateDirectory(destPath,0);
        }
        iVar5 = 0;
        while( true ) {
          if (GameController._instance == null) break;
          if (GameController._instance.TestBuildPlayer <= iVar5) {
            return;
          }
          if (GameController._instance == null) break;
          uVar2 = FUN_1800024b0(GameController._instance,iVar5,DAT_181e86970);
          uVar2 = String.Concat(sourcePath,"/",uVar2,0);
          if (GameController._instance == null) break;
          uVar3 = FUN_1800024b0(GameController._instance,iVar5,DAT_181e86970);
          uVar3 = String.Concat(destPath,"/",uVar3,0);
          lVar4 = new WWW(uVar2,0);
          do {
            if (lVar4 == null) throw; // [null/range check failed]
            cVar1 = WWW.get_isDone(lVar4,0);
          } while (!cVar1);
          uVar2 = WWW.get_bytes(lVar4,0);
          File.WriteAllBytes(uVar3,uVar2,0);
          iVar5 = iVar5 + 1;
        }
    }

    // Token : 0x60016C3
    // RVA   : 0xBC88B0   Offset: 0xBC76B0   Length: 0x1CF
    private void Start()
    {
        long lVar1;
        int iVar2;
        GameDataController.LoadAllGameData(this,0);
        iVar2 = 0;
        while( true ) {
          lVar1 = GameController.CheckShowSpeHeroSkinID;
          if ((lVar1 == null) || (lVar1 = *(int64 *)(lVar1 + 40)) == null) break;
          if (*(int *)(lVar1 + 24) <= iVar2) {
            if (*(int64 *)(*(int64 *)(DAT_181e64c70 + 184) + 16) == 0) {
              LTLocalization.Init(0);
              return;
            }
            return;
          }
          lVar1 = GameController.CheckShowSpeHeroSkinID;
          if ((lVar1 == null) || (lVar1 = *(int64 *)(lVar1 + 40)) == null) break;
          lVar1 = FUN_1800024b0(lVar1,iVar2,DAT_181e73170);
          if (lVar1 != null) {
            lVar1 = GameController.CheckShowSpeHeroSkinID;
            if ((lVar1 == null) || (lVar1 = *(int64 *)(lVar1 + 40)) == null) break;
            lVar1 = FUN_1800024b0(lVar1,iVar2,DAT_181e73170);
            if (lVar1 == null) break;
            ItemData.RecountStaticData(lVar1,0);
          }
          iVar2 = iVar2 + 1;
        }
    }

    // Token : 0x60016C4
    // RVA   : 0xBC99B0   Offset: 0xBC87B0   Length: 0x20F
    private void Update()
    {
        float fVar1;
        bool cVar2;
        long lVar3;
        ulong uVar4;
        uint uVar5;
        long lVar6;
        float fVar7;
        uint[] local_res18 = new uint[2];
        cVar2 = GameDataController.HaveTask(this,0);
        if (!cVar2) {
          this.keepTaskTime = 0;
        }
        else {
          fVar1 = this.keepTaskTime;
          fVar7 = (float)Time.get_deltaTime();
          fVar7 = fVar7 + fVar1;
          this.keepTaskTime = fVar7;
          if (10.0 < fVar7) {
            lVar3 = this.Tasks;
            uVar5 = 0;
            if (lVar3 != null) {
              lVar6 = 32;
              do {
                if (lVar3.worldDataFinished <= (int)uVar5) {
                  FUN_18115d8f0(lVar3,DAT_181e88970);
                  goto LAB_180bc9b37;
                }
                if (lVar3 == null) {
        LAB_180bc9bba:
                          // WARNING: Subroutine does not return
                  FUN_1801e0300();
                }
                if (lVar3.worldDataFinished <= uVar5) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar3 = *(int64 *)(lVar6 + lVar3.key);
                if (lVar3 == null) goto LAB_180bc9bba;
                local_res18[0] = Task.get_Status(lVar3,0);
                uVar4 = il2cpp_value_box(DAT_181e8a9e8,local_res18);
                uVar4 = String.Format("Task Unfinished: {0}",uVar4,0);
                Debug.Log(uVar4);
                lVar3 = this.Tasks;
                uVar5 = uVar5 + 1;
                lVar6 = lVar6 + 8;
              } while (lVar3 != null);
            }
            throw; // [null/range check failed]
          }
        }
        LAB_180bc9b37:
        if (this.gameSaveData != null) {
          cVar2 = GameSaveData.CheckAllFinished(this.gameSaveData,0);
          lVar3 = this.gameSaveData;
          if (!cVar2) {
            if (lVar3 != null) {
              if (!lVar3.loading) {
                fVar1 = lVar3.saveTimeCount;
                fVar7 = (float)Time.get_deltaTime(0);
                lVar3.saveTimeCount = fVar7 + fVar1;
                lVar3 = this.gameSaveData;
                if (lVar3 == null) throw; // [null/range check failed]
                if (10.0 < lVar3.saveTimeCount) {
                  GameSaveData.SetSaveFailed(lVar3,0);
                }
              }
              return;
            }
          }
          else if (lVar3 != null) {
            lVar3.saveTimeCount = 0;
            return;
          }
        }
    }

    // Token : 0x60016C5
    // RVA   : 0xBB8AA0   Offset: 0xBB78A0   Length: 0x57
    public string GetPlayerPrefFilePath()
    {
        bool cVar1;
        cVar1 = Directory.Exists(this.saveDataPath,0);
        if (!cVar1) {
          Directory.CreateDirectory(this.saveDataPath,0);
        }
        String.Concat(this.saveDataPath,"/PlayerprefData.dat",0);
    }

    // Token : 0x60016C6
    // RVA   : 0xBB8A40   Offset: 0xBB7840   Length: 0x57
    public string GetPlayerPrefFileBackupPath()
    {
        bool cVar1;
        cVar1 = Directory.Exists(this.saveDataPath,0);
        if (!cVar1) {
          Directory.CreateDirectory(this.saveDataPath,0);
        }
        String.Concat(this.saveDataPath,"/PlayerprefData.dat_backup",0);
    }

    // Token : 0x60016C7
    // RVA   : 0xBC7A50   Offset: 0xBC6850   Length: 0xF1
    public void SavePlayerprefData()
    {
        ulong uVar1;
        ulong uVar2;
        bool cVar3;
        cVar3 = Directory.Exists(this.saveDataPath,0);
        if (!cVar3) {
          Directory.CreateDirectory(this.saveDataPath,0);
        }
        uVar2 = String.Concat(this.saveDataPath,"/PlayerprefData.dat",0);
        uVar1 = *(uint64 *)(*(int64 *)(DAT_181e528f8 + 184) + 8);
        uVar1 = JsonConvert.SerializeObject(uVar1,0);
        File.WriteAllText(uVar2,uVar1,0);
    }

    // Token : 0x60016C8
    // RVA   : 0xBC57D0   Offset: 0xBC45D0   Length: 0x3A0
    public void LoadPlayerprefData()
    {
        bool cVar1;
        ulong uVar2;
        long lVar3;
        cVar1 = Directory.Exists(this.saveDataPath,0);
        if (!cVar1) {
          Directory.CreateDirectory(this.saveDataPath,0);
        }
        uVar2 = String.Concat(this.saveDataPath,"/PlayerprefData.dat",0);
        cVar1 = File.Exists(uVar2,0);
        if (cVar1) {
          cVar1 = Directory.Exists(this.saveDataPath,0);
          if (!cVar1) {
            Directory.CreateDirectory(this.saveDataPath,0);
          }
          uVar2 = String.Concat(this.saveDataPath,"/PlayerprefData.dat",0);
          uVar2 = File.ReadAllText(uVar2,0);
          lVar3 = new JsonSerializerSettings(0);
          if (lVar3 == null) {
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          JsonSerializerSettings.set_ObjectCreationHandling(lVar3,2);
          uVar2 = JsonConvert.DeserializeObject(uVar2,lVar3,DAT_181e63880);
          GameController.difficultyExtraPoint = uVar2;
          if (GameController.difficultyExtraPoint == null) {
            uVar2 = new RePlayerPrefData(0);
            GameController.difficultyExtraPoint = uVar2;
          }
        }
    }

    // Token : 0x60016C9
    // RVA   : 0xBB7F10   Offset: 0xBB6D10   Length: 0x18F
    public int GetAchFinishedCount()
    {
        long lVar1;
        int iVar2;
        bool cVar3;
        ulong uVar4;
        int iVar5;
        int[] local_res18 = new int[4];
        iVar5 = 0;
        local_res18[0] = 0;
        while( true ) {
          iVar2 = local_res18[0];
          lVar1 = GameController.ChangeAllAreaStateIDs;
          if ((lVar1 == null) || (lVar1 = *(int64 *)(lVar1 + 0x1d0)) == null) break;
          if (*(int *)(lVar1 + 24) <= iVar2) {
            return iVar5;
          }
          lVar1 = GameController.difficultyExtraPoint;
          if (lVar1 == null) break;
          lVar1 = *(int64 *)(lVar1 + 16);
          uVar4 = Int32.ToString(local_res18,0);
          uVar4 = String.Concat("AchFinished",uVar4,0);
          if (lVar1 == null) break;
          uVar4 = PlayerPrefDictionary.GetString(lVar1,uVar4);
          cVar3 = FUN_1816387f0(uVar4);
          if (cVar3) {
            iVar5 = iVar5 + 1;
          }
          local_res18[0] = local_res18[0] + 1;
        }
    }

    // Token : 0x60016CA
    // RVA   : 0xBB8550   Offset: 0xBB7350   Length: 0x196
    public int GetExternalStorageMaxValue()
    {
        long lVar1;
        int iVar2;
        bool cVar3;
        ulong uVar4;
        int iVar5;
        int[] local_res18 = new int[4];
        iVar5 = 0;
        local_res18[0] = 0;
        while( true ) {
          iVar2 = local_res18[0];
          lVar1 = GameController.ChangeAllAreaStateIDs;
          if ((lVar1 == null) || (lVar1 = *(int64 *)(lVar1 + 0x1d0)) == null) break;
          if (*(int *)(lVar1 + 24) <= iVar2) {
            return (iVar5 + 8) * 500;
          }
          lVar1 = GameController.difficultyExtraPoint;
          if (lVar1 == null) break;
          lVar1 = *(int64 *)(lVar1 + 16);
          uVar4 = Int32.ToString(local_res18,0);
          uVar4 = String.Concat("AchFinished",uVar4,0);
          if (lVar1 == null) break;
          uVar4 = PlayerPrefDictionary.GetString(lVar1,uVar4);
          cVar3 = FUN_1816387f0(uVar4);
          if (cVar3) {
            iVar5 = iVar5 + 1;
          }
          local_res18[0] = local_res18[0] + 1;
        }
    }

    // Token : 0x60016CB
    // RVA   : 0xBB84F0   Offset: 0xBB72F0   Length: 0x57
    public string GetExternalStorageFilePath()
    {
        bool cVar1;
        cVar1 = Directory.Exists(this.saveDataPath,0);
        if (!cVar1) {
          Directory.CreateDirectory(this.saveDataPath,0);
        }
        String.Concat(this.saveDataPath,"/ExternalStorateData.dat",0);
    }

    // Token : 0x60016CC
    // RVA   : 0xBC7950   Offset: 0xBC6750   Length: 0xF1
    public void SaveExternalStorageData()
    {
        ulong uVar1;
        ulong uVar2;
        bool cVar3;
        cVar3 = Directory.Exists(this.saveDataPath,0);
        if (!cVar3) {
          Directory.CreateDirectory(this.saveDataPath,0);
        }
        uVar2 = String.Concat(this.saveDataPath,"/ExternalStorateData.dat",0);
        uVar1 = *(uint64 *)(*(int64 *)(DAT_181e528f8 + 184) + 24);
        uVar1 = JsonConvert.SerializeObject(uVar1,0);
        File.WriteAllText(uVar2,uVar1,0);
    }

    // Token : 0x60016CD
    // RVA   : 0xBC4B30   Offset: 0xBC3930   Length: 0x1AE
    public void LoadExternalStorageData()
    {
        ulong uVar1;
        bool cVar2;
        long lVar3;
        cVar2 = Directory.Exists(this.saveDataPath,0);
        if (!cVar2) {
          Directory.CreateDirectory(this.saveDataPath,0);
        }
        uVar1 = String.Concat(this.saveDataPath,"/ExternalStorateData.dat",0);
        cVar2 = File.Exists(uVar1,0);
        if (cVar2) {
          cVar2 = Directory.Exists(this.saveDataPath,0);
          if (!cVar2) {
            Directory.CreateDirectory(this.saveDataPath,0);
          }
          uVar1 = String.Concat(this.saveDataPath,"/ExternalStorateData.dat",0);
          uVar1 = File.ReadAllText(uVar1,0);
          lVar3 = new JsonSerializerSettings(0);
          if (lVar3 == null) {
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          JsonSerializerSettings.set_ObjectCreationHandling(lVar3,2);
          uVar1 = JsonConvert.DeserializeObject(uVar1,lVar3,DAT_181e63800);
          puVar4 = (uint64 *)(*(int64 *)(DAT_181e528f8 + 184) + 24);
          *puVar4 = uVar1;
          il2cpp_internal(puVar4,uVar1);
        }
    }

    // Token : 0x60016CE
    // RVA   : 0xBB9C30   Offset: 0xBB8A30   Length: 0x172
    public void ItemIntoExternalStorage(ItemData targetItem)
    {
        int iVar1;
        long lVar2;
        ulong uVar3;
        if (targetItem == null) throw; // [null/range check failed]
        if (*(int *)(targetItem + 20) == 3) {
          if (*(int64 *)(targetItem + 112) == 0) throw; // [null/range check failed]
          iVar1 = *(int *)(*(int64 *)(targetItem + 112) + 16);
          if (*(int *)(*(int64 *)(DAT_181e538e8 + 184) + 0x120) <= iVar1) {
            if (*(int64 *)(targetItem + 112) != 0) {
              uVar3 = Int32.ToString(*(int64 *)(targetItem + 112) + 16,0);
              uVar3 = String.Concat("自创武学秘籍不可放入藏宝阁: skillID=",uVar3,0);
              Debug.Log(uVar3,0);
              return;
            }
            throw; // [null/range check failed]
          }
        }
        lVar2 = *(int64 *)(*(int64 *)(DAT_181e528f8 + 184) + 24);
        if (lVar2 != null) {
          ItemListData.GetItem(lVar2,targetItem,0,0);
          GameDataController.SaveExternalStorageData(this,0);
          return;
        }
    }

    // Token : 0x60016CF
    // RVA   : 0xBB9DB0   Offset: 0xBB8BB0   Length: 0x8B
    public void ItemOutExternalStorage(ItemData targetItem)
    {
        long lVar1;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181e528f8 + 184) + 24);
        if (lVar1 != null) {
          ItemListData.LoseItem(lVar1,targetItem,0,0);
          GameDataController.SaveExternalStorageData(this,0);
          return;
        }
    }

    // Token : 0x60016D0
    // RVA   : 0xBB64B0   Offset: 0xBB52B0   Length: 0x78
    public void ClearExternalStorage()
    {
        long lVar1;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181e528f8 + 184) + 24);
        if (lVar1 != null) {
          ItemListData.ClearAllItem(lVar1,0);
          GameDataController.SaveExternalStorageData(this,0);
          return;
        }
    }

    // Token : 0x60016D1
    // RVA   : 0xBB6F50   Offset: 0xBB5D50   Length: 0x236
    public void GameIntoGameData()
    {
        long lVar1;
        long lVar2;
        if ((GameController._instance != null) &&
           (lVar1 = GameController._instance.worldData) != null) {
          WorldData.SetPlayerMissionEventData(lVar1,0);
          lVar1 = this.gameSaveData;
          if ((GameController._instance != null) && (lVar1 != null)) {
            lVar1.WorldData = GameController._instance.worldData;
            lVar1 = this.gameSaveData;
            if (((GameController._instance != null) &&
                (lVar2 = GameController._instance.worldData) != null) &&
               (lVar1 != null)) {
              lVar1.HeroList = lVar2.Heros;
              lVar1 = this.gameSaveData;
              if (((GameController._instance != null) &&
                  (lVar2 = GameController._instance.worldData) != null) &&
                 (lVar1 != null)) {
                lVar1.TempHeroList = lVar2.TempHeros;
                return;
              }
            }
          }
        }
    }

    // Token : 0x60016D2
    // RVA   : 0xBB6D20   Offset: 0xBB5B20   Length: 0x22C
    public void GameDataIntoGame()
    {
        long lVar1;
        if ((this.gameSaveData != null) && (GameController._instance != null)) {
          GameController._instance.worldData =
               this.gameSaveData.WorldData;
          il2cpp_internal();
          if ((GameController._instance != null) && (this.gameSaveData != null)) {
            lVar1 = GameController._instance.worldData;
            if (lVar1 != null) {
              lVar1.Heros = this.gameSaveData.HeroList;
              if ((GameController._instance != null) && (this.gameSaveData != null)) {
                lVar1 = GameController._instance.worldData;
                if (lVar1 != null) {
                  lVar1.TempHeros = this.gameSaveData.TempHeroList;
                  if ((GameController._instance != null) &&
                     (lVar1 = GameController._instance.worldData) != null) {
                    WorldData.RecoverPlayerMissionEventData(lVar1,0);
                    return;
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x60016D3
    // RVA   : 0xBB8D40   Offset: 0xBB7B40   Length: 0x126
    public string GetSaveDataPath(int saveID, int saveType)
    {
        bool cVar1;
        cVar1 = Directory.Exists(this.saveDataPath,0);
        if (!cVar1) {
          Directory.CreateDirectory(this.saveDataPath,0);
        }
        return this.saveDataPath;
    }

    // Token : 0x60016D4
    // RVA   : 0xBB8910   Offset: 0xBB7710   Length: 0x126
    public string GetOldSaveDataPath(int saveID, int saveType)
    {
        long lVar1;
        bool cVar2;
        ulong uVar3;
        ulong uVar4;
        uint[] local_res10 = new uint[2];
        local_res10[0] = saveID;
        cVar2 = Directory.Exists(this.saveDataPath,0);
        if (!cVar2) {
          Directory.CreateDirectory(this.saveDataPath,0);
        }
        uVar4 = this.saveDataPath;
        uVar3 = Int32.ToString(local_res10,0);
        uVar4 = String.Concat(uVar4,"/SaveSlot",uVar3,0);
        cVar2 = Directory.Exists(uVar4,0);
        if (!cVar2) {
          Directory.CreateDirectory(uVar4,0);
        }
        lVar1 = GameController._instance;
        if (lVar1 != null) {
          if (lVar1.TestBuildPlayer <= saveType) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          String.Concat(uVar4,"/",
                         lVar1[saveType],
                         0);
          return;
        }
    }

    // Token : 0x60016D5
    // RVA   : 0xBB80A0   Offset: 0xBB6EA0   Length: 0x126
    public string GetBackupDataPath(int saveID, int saveType)
    {
        bool cVar1;
        cVar1 = Directory.Exists(this.backupDataPath,0);
        if (!cVar1) {
          Directory.CreateDirectory(this.backupDataPath,0);
        }
        return this.backupDataPath;
    }

    // Token : 0x60016D6
    // RVA   : 0xBB8C00   Offset: 0xBB7A00   Length: 0x13F
    public string GetSafeDataPath(int saveID, int saveType)
    {
        long lVar1;
        bool cVar2;
        ulong uVar3;
        ulong uVar4;
        uint[] local_res10 = new uint[2];
        local_res10[0] = saveID;
        cVar2 = Directory.Exists(this.backupDataPath,0);
        if (!cVar2) {
          Directory.CreateDirectory(this.backupDataPath,0);
        }
        uVar4 = this.backupDataPath;
        uVar3 = Int32.ToString(local_res10,0);
        uVar4 = String.Concat(uVar4,"/SaveSlot",uVar3,"_safe",0);
        cVar2 = Directory.Exists(uVar4,0);
        if (!cVar2) {
          Directory.CreateDirectory(uVar4,0);
        }
        lVar1 = GameController._instance;
        if (lVar1 != null) {
          if (lVar1.TestBuildPlayer <= saveType) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          String.Concat(uVar4,"/",
                         lVar1[saveType],
                         0);
          return;
        }
    }

    // Token : 0x60016D7
    // RVA   : 0xBC9BC0   Offset: 0xBC89C0   Length: 0x172
    public void UpgradeSaveFileName()
    {
        var plVar4 = *(int64*)(lVar4 + 184);
        bool cVar1;
        ulong uVar2;
        ulong uVar3;
        long lVar4;
        int iVar5;
        int iVar6;
        iVar6 = 0;
        lVar4 = DAT_181e528f8;
        do {
          if (((*(byte *)(DAT_181e7f158 + 0x133) & 4) != 0) && (*(int *)(DAT_181e7f158 + 224) == 0)) {
            il2cpp_runtime_class_init(DAT_181e7f158);
            lVar4 = DAT_181e528f8;
          }
          if (**(int **)(DAT_181e7f158 + 184) <= iVar6) {
            return;
          }
          iVar5 = 0;
          while( true ) {
            if (((*(byte *)(lVar4 + 0x133) & 4) != 0) && (*(int *)(lVar4 + 224) == 0)) {
              il2cpp_runtime_class_init();
              lVar4 = DAT_181e528f8;
            }
            if (*plVar4 == 0) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            if (*(int *)(*plVar4 + 24) <= iVar5) break;
            uVar2 = GameDataController.GetOldSaveDataPath(this,iVar6,iVar5,0);
            cVar1 = File.Exists(uVar2,0);
            if (cVar1) {
              uVar2 = GameDataController.GetSaveDataPath(this,iVar6,iVar5);
              cVar1 = File.Exists(uVar2,0);
              if (!cVar1) {
                uVar2 = GameDataController.GetOldSaveDataPath(this,iVar6,iVar5,0);
                uVar3 = GameDataController.GetSaveDataPath(this,iVar6,iVar5);
                File.Move(uVar2,uVar3,0);
              }
            }
            iVar5 = iVar5 + 1;
            lVar4 = DAT_181e528f8;
          }
          iVar6 = iVar6 + 1;
        } while( true );
    }

    // Token : 0x60016D8
    // RVA   : 0xBB9850   Offset: 0xBB8650   Length: 0x1D
    public bool HaveSave(int saveID)
    {
        ulong uVar1;
        uVar1 = GameDataController.GetSaveDataPath(this,saveID,0,0);
        File.Exists(uVar1,0);
    }

    // Token : 0x60016D9
    // RVA   : 0xBB6910   Offset: 0xBB5710   Length: 0x1C9
    public void DeleteSave(int saveID)
    {
        long lVar1;
        bool cVar2;
        ulong uVar3;
        ulong uVar4;
        uint uVar5;
        long lVar6;
        uint[] local_res20 = new uint[2];
        uVar5 = 0;
        lVar6 = 32;
        while( true ) {
          if (GameController._instance == null) {
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          if (GameController._instance.TestBuildPlayer <= (int)uVar5) {
            return;
          }
          local_res20[0] = saveID;
          cVar2 = Directory.Exists(this.saveDataPath,0);
          if (!cVar2) {
            Directory.CreateDirectory(this.saveDataPath,0);
          }
          uVar4 = this.saveDataPath;
          uVar3 = Int32.ToString(local_res20,0);
          uVar4 = String.Concat(uVar4,"/SaveSlot",uVar3,0);
          cVar2 = Directory.Exists(uVar4,0);
          if (!cVar2) {
            Directory.CreateDirectory(uVar4,0);
          }
          lVar1 = GameController._instance;
          if (lVar1 == null) break;
          if (lVar1.TestBuildPlayer <= uVar5) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          uVar4 = String.Concat(uVar4,"/",*(uint64 *)(lVar6 + *(int64 *)(lVar1 + 16)),
                                 0);
          File.Delete(uVar4);
          uVar5 = uVar5 + 1;
          lVar6 = lVar6 + 8;
        }
    }

    // Token : 0x60016DA
    // RVA   : 0xBB7790   Offset: 0xBB6590   Length: 0x77C
    public SaveInfo GenerateSaveInfo()
    {
        var pStatics_38e8 = *(int64*)(DAT_181e538e8 + 184);
        uint uVar1;
        ulong uVar2;
        long lVar4;
        long lVar5;
        ulong uVar6;
        ulong uVar7;
        ulong uVar8;
        ulong local_res18;
        uVar2 = String.Concat(PlotController.FirstMeetTalkText," ",
                               PlotController.YoungHeroFightMatchResultString,0);
        plVar3 = (int64 *)FUN_1801dfd90(DAT_181e85e38,9);
        if ((((GameController._instance != null) &&
             (lVar4 = GameController._instance.worldData) != null) &&
            (lVar4 = WorldData.Player(lVar4,0)) != null) &&
           (lVar4 = lVar4.AreaMapRandomEventDatas, plVar3 != (int64 *)0)) {
          if ((lVar4 != null) &&
             (lVar5 = il2cpp_internal(lVar4,*(uint64 *)(*plVar3 + 64))) == null) {
            uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar2,0);
          }
          if ((int)plVar3[3] == 0) {
            uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar2,0);
          }
          plVar3[4] = lVar4;
          il2cpp_internal(plVar3 + 4,lVar4);
          if (("\n" != 0) &&
             (lVar4 = il2cpp_internal("\n",*(uint64 *)(*plVar3 + 64))) == null) {
            uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar2,0);
          }
          lVar4 = "\n";
          if (*(uint32 *)(plVar3 + 3) < 2) {
            uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar2,0);
          }
          plVar3[5] = "\n";
          il2cpp_internal(plVar3 + 5,lVar4);
          if (((GameController._instance != null) &&
              (lVar4 = GameController._instance.worldData) != null) &&
             (lVar4 = lVar4.worldTime) != null) {
            lVar4 = TimeData.GetDescribe(lVar4,0);
            if ((lVar4 != null) &&
               (lVar5 = il2cpp_internal(lVar4,*(uint64 *)(*plVar3 + 64))) == null) {
              uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar2,0);
            }
            if (*(uint32 *)(plVar3 + 3) < 3) {
              uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar2,0);
            }
            plVar3[6] = lVar4;
            il2cpp_internal(plVar3 + 6,lVar4);
            if (("\n" != 0) &&
               (lVar4 = il2cpp_internal("\n",*(uint64 *)(*plVar3 + 64))) == null) {
              uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar2,0);
            }
            lVar4 = "\n";
            if (*(uint32 *)(plVar3 + 3) < 4) {
              uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar2,0);
            }
            plVar3[7] = "\n";
            il2cpp_internal(plVar3 + 7,lVar4);
            lVar4 = *(int64 *)(pStatics_38e8 + 184);
            if (((GameController._instance != null) &&
                (lVar5 = GameController._instance.worldData) != null) &&
               (lVar4 != null)) {
              uVar1 = lVar5.gameMode;
              if (lVar4.cityAreaID <= uVar1) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar4 = lVar4.chapter[uVar1];
              if (lVar4 != null) {
                lVar4 = String.Substring(lVar4,0,2);
                if ((lVar4 != null) &&
                   (lVar5 = il2cpp_internal(lVar4,*(uint64 *)(*plVar3 + 64))) == null) {
                  uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1801e02d0(uVar2,0);
                }
                if (*(uint32 *)(plVar3 + 3) < 5) {
                  uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1801e02d0(uVar2,0);
                }
                plVar3[8] = lVar4;
                il2cpp_internal(plVar3 + 8,lVar4);
                if (("\n" != 0) &&
                   (lVar4 = il2cpp_internal("\n",*(uint64 *)(*plVar3 + 64)), lVar4 == null
                   )) {
                  uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1801e02d0(uVar2,0);
                }
                lVar4 = "\n";
                if (*(uint32 *)(plVar3 + 3) < 6) {
                  uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1801e02d0(uVar2,0);
                }
                plVar3[9] = "\n";
                il2cpp_internal(plVar3 + 9,lVar4);
                if ((GameController._instance != null) &&
                   (lVar4 = GameController._instance.worldData) != null) {
                  lVar4 = WorldData.Player(lVar4,0);
                  if (lVar4 != null) {
                    lVar4 = HeroData.GetHeroForceLvDescribe(lVar4,1,0);
                    if ((lVar4 != null) &&
                       (lVar5 = il2cpp_internal(lVar4,*(uint64 *)(*plVar3 + 64))) == null) {
                      uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1801e02d0(uVar2,0);
                    }
                    if (*(uint32 *)(plVar3 + 3) < 7) {
                      uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1801e02d0(uVar2,0);
                    }
                    plVar3[10] = lVar4;
                    il2cpp_internal(plVar3 + 10,lVar4);
                    if (("\n" != 0) &&
                       (lVar4 = il2cpp_internal("\n",*(uint64 *)(*plVar3 + 64)),
                       lVar4 == null)) {
                      uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1801e02d0(uVar2,0);
                    }
                    lVar4 = "\n";
                    if (*(uint32 *)(plVar3 + 3) < 8) {
                      uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1801e02d0(uVar2,0);
                    }
                    plVar3[11] = "\n";
                    il2cpp_internal(plVar3 + 11,lVar4);
                    if ((GameController._instance != null) &&
                       (lVar4 = GameController._instance.worldData) != null)
                    {
                      lVar4 = WorldData.GetDifficlutyName(lVar4,0);
                      if ((lVar4 != null) &&
                         (lVar5 = il2cpp_internal(lVar4,*(uint64 *)(*plVar3 + 64))) == null)
                      {
                        uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1801e02d0(uVar2,0);
                      }
                      if (*(uint32 *)(plVar3 + 3) < 9) {
                        uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1801e02d0(uVar2,0);
                      }
                      plVar3[12] = lVar4;
                      il2cpp_internal(plVar3 + 12,lVar4);
                      uVar6 = String.Concat(plVar3,0);
                      local_res18 = DateTime.get_Now(0);
                      uVar7 = DateTime.ToString(&local_res18,0);
                      uVar8 = new SaveInfo(uVar2,uVar6,uVar7,0);
                      return uVar8;
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x60016DB
    // RVA   : 0xBB8EA0   Offset: 0xBB7CA0   Length: 0x82
    public SaveInfo GetSaveInfo(int saveID)
    {
        ulong uVar1;
        uVar1 = GameDataController.GetSaveDataPath(this,saveID,3);
        SaveFileIO.ReadJson(uVar1,DAT_181e87778);
    }

    // Token : 0x60016DC
    // RVA   : 0xBC76F0   Offset: 0xBC64F0   Length: 0x13C
    public void MoveSaveToBackUp(int saveID)
    {
        bool cVar1;
        ulong uVar2;
        ulong uVar3;
        int iVar4;
        iVar4 = 0;
        while( true ) {
          if (GameController._instance == null) break;
          if (GameController._instance.TestBuildPlayer <= iVar4) {
            return;
          }
          uVar2 = GameDataController.GetSaveDataPath(this,saveID,iVar4,0);
          cVar1 = File.Exists(uVar2,0);
          if (cVar1) {
            uVar2 = GameDataController.GetBackupDataPath(this,saveID,iVar4);
            cVar1 = File.Exists(uVar2,0);
            if (cVar1) {
              uVar2 = GameDataController.GetBackupDataPath(this,saveID,iVar4);
              File.Delete(uVar2,0);
            }
            uVar2 = GameDataController.GetSaveDataPath(this,saveID,iVar4,0);
            uVar3 = GameDataController.GetBackupDataPath(this,saveID,iVar4);
            File.Copy(uVar2,uVar3,0);
          }
          iVar4 = iVar4 + 1;
        }
    }

    // Token : 0x60016DD
    // RVA   : 0xBC75B0   Offset: 0xBC63B0   Length: 0x13C
    public void MoveBackUpToSafe(int saveID)
    {
        bool cVar1;
        ulong uVar2;
        ulong uVar3;
        int iVar4;
        iVar4 = 0;
        while( true ) {
          if (GameController._instance == null) break;
          if (GameController._instance.TestBuildPlayer <= iVar4) {
            return;
          }
          uVar2 = GameDataController.GetBackupDataPath(this,saveID,iVar4,0);
          cVar1 = File.Exists(uVar2,0);
          if (cVar1) {
            uVar2 = GameDataController.GetSafeDataPath(this,saveID,iVar4);
            cVar1 = File.Exists(uVar2,0);
            if (cVar1) {
              uVar2 = GameDataController.GetSafeDataPath(this,saveID,iVar4);
              File.Delete(uVar2,0);
            }
            uVar2 = GameDataController.GetBackupDataPath(this,saveID,iVar4,0);
            uVar3 = GameDataController.GetSafeDataPath(this,saveID,iVar4);
            File.Copy(uVar2,uVar3,0);
          }
          iVar4 = iVar4 + 1;
        }
    }

    // Token : 0x60016DE
    // RVA   : 0xBC7B50   Offset: 0xBC6950   Length: 0xD5E
    public void Save(int saveID)
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        long lVar5;
        long lVar6;
        long lVar8;
        long local_88;
        long[] local_80 = new long[5];
        uint local_58;
        ulong local_48;
        ulong uStack_40;
        plVar10 = (int64 *)0;
        local_58 = 0;
        lVar2 = new c.DisplayClass9_0(0);
        if (lVar2 != null) {
          *(int64 *)(lVar2 + 16) = this;
          cVar1 = GameDataController.HaveTask(this,0);
          if (cVar1) {
        LAB_180bc87a6:
            Debug.LogWarning("[Save] 被闸门拦下",0);
            return;
          }
          if (this.gameSaveData != null) {
            cVar1 = GameSaveData.CheckAllFinished(this.gameSaveData,0);
            if (!cVar1) goto LAB_180bc87a6;
            GameDataController.GameIntoGameData(this,0);
            if (this.gameSaveData == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            GameSaveData.SetAllUnfinish(this.gameSaveData,0,0);
            local_80[0] = Stopwatch.StartNew(0);
            uVar3 = GameDataController.GetSaveDataPath(this,saveID,0,0);
            *(uint64 *)(lVar2 + 48) = uVar3;
            uVar3 = GameDataController.GetSaveDataPath(this,saveID,1);
            *(uint64 *)(lVar2 + 56) = uVar3;
            uVar3 = GameDataController.GetSaveDataPath(this,saveID,2);
            *(uint64 *)(lVar2 + 64) = uVar3;
            uVar3 = GameDataController.GetSaveDataPath(this,saveID,3);
            uVar4 = new ZhSegment(0);
            *(uint64 *)(lVar2 + 24) = uVar4;
            *(uint64 *)(lVar2 + 32) = 0;
            uVar4 = new OnTooltipCB(lVar2,DAT_181e87fa0,DAT_181e79980);
            *(uint64 *)(lVar2 + 40) = uVar4;
            uVar4 = GameDataController.GenerateSaveInfo(this,0);
            SaveFileIO.WriteJson(uVar3,uVar4,1,DAT_181e878f8);
            lVar5 = GameDataController.playerPrefData;
            uVar3 = new OnTooltipCB(lVar2,DAT_181e88020,0);
            if (lVar5 == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            local_88 = TaskFactory.StartNew(lVar5,uVar3,2);
            lVar5 = GameDataController.playerPrefData;
            uVar3 = new OnTooltipCB(lVar2,DAT_181e880a0,0);
            if (lVar5 == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            lVar5 = TaskFactory.StartNew(lVar5,uVar3,2);
            lVar6 = GameDataController.playerPrefData;
            uVar3 = new OnTooltipCB(lVar2,DAT_181e88120,0);
            if (lVar6 == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            lVar6 = TaskFactory.StartNew(lVar6,uVar3,2);
            plVar7 = (int64 *)FUN_1801dfd90(DAT_181e86438,3);
            if (plVar7 == (int64 *)0) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            if ((local_88 != 0) &&
               (lVar8 = il2cpp_internal(local_88,*(uint64 *)(*plVar7 + 64))) == null) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar3,0);
            }
            if ((int)plVar7[3] == 0) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar3,0);
            }
            plVar7[4] = local_88;
            il2cpp_internal(plVar7 + 4,local_88);
            if ((lVar5 != null) &&
               (lVar8 = il2cpp_internal(lVar5,*(uint64 *)(*plVar7 + 64))) == null) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar3,0);
            }
            if (*(uint32 *)(plVar7 + 3) < 2) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar3,0);
            }
            plVar7[5] = lVar5;
            il2cpp_internal(plVar7 + 5,lVar5);
            if ((lVar6 != null) &&
               (lVar5 = il2cpp_internal(lVar6,*(uint64 *)(*plVar7 + 64))) == null) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar3,0);
            }
            if (*(uint32 *)(plVar7 + 3) < 3) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar3,0);
            }
            plVar7[6] = lVar6;
            il2cpp_internal(plVar7 + 6,lVar6);
            Task.WaitAll(plVar7,0);
            lVar5 = local_80[0];
            if (*(int64 *)(lVar2 + 32) != 0) {
              FUN_180002530(lVar2);
              uVar3 = FUN_180002820(lVar2);
              uVar4 = il2cpp_runtime_class_init(&DAT_181e50ac0);
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar3,uVar4);
            }
            if (local_80[0] == 0) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            local_80[0] = Stopwatch.get_ElapsedMilliseconds(local_80[0],0);
            uVar3 = il2cpp_value_box(DAT_181e60a80,local_80);
            uVar3 = String.Format("[Save] 存档四文件写完 {0}ms",uVar3,0);
            Debug.Log(uVar3,0);
            cVar1 = Directory.Exists(this.saveDataPath,0);
            if (!cVar1) {
              Directory.CreateDirectory(this.saveDataPath,0);
            }
            uVar3 = String.Concat(this.saveDataPath,"/PlayerprefData.dat",0);
            uVar4 = GameController.difficultyExtraPoint;
            uVar4 = JsonConvert.SerializeObject(uVar4,0);
            File.WriteAllText(uVar3,uVar4,0);
            plVar7 = plVar10;
            while( true ) {
              if (GameController._instance == null) {
                          // WARNING: Subroutine does not return
                FUN_1801e0300();
              }
              if (GameController._instance.TestBuildPlayer <= (int)plVar7) break;
              uVar3 = GameDataController.GetSaveDataPath(this,saveID,plVar7,0);
              cVar1 = File.Exists(uVar3);
              if (cVar1) {
                uVar3 = GameDataController.GetBackupDataPath(this,saveID,plVar7);
                cVar1 = File.Exists(uVar3,0);
                if (cVar1) {
                  uVar3 = GameDataController.GetBackupDataPath(this,saveID,plVar7);
                  File.Delete(uVar3,0);
                }
                uVar3 = GameDataController.GetSaveDataPath(this,saveID,plVar7,0);
                GameDataController.GetBackupDataPath(this,saveID);
                File.Copy(uVar3);
              }
              plVar7 = (int64 *)(uint64)((int)plVar7 + 1);
            }
            local_88 = Stopwatch.get_ElapsedMilliseconds(lVar5,0);
            uVar3 = il2cpp_value_box(DAT_181e60a80,&local_88);
            uVar3 = String.Format("[Save] 全部完成 {0}ms",uVar3,0);
            Debug.Log(uVar3,0);
            lVar2 = **(int64 **)(DAT_181e5fa68 + 184);
            uVar3 = "自动";
            if ((saveID != null) && (uVar3 = "", saveID == 10)) {
              uVar3 = "快速";
            }
            uVar3 = String.Format("{0}存档成功！",uVar3,0);
            puVar9 = (uint64 *)Color.get_green(&local_48,0);
            if (lVar2 == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            local_48 = *puVar9;
            uStack_40 = puVar9[1];
            InfoController.AddInfoTab
                      (lVar2,uVar3,"UIAtlas","从事工作_学习","Woosh",0x3f800000,0x40a00000,
                       &local_48,0);
            plVar7 = (int64 *)Resources.Load("Sound/SoundEffect/NoticeLittle",0);
            if ((plVar7 != (int64 *)0) && (*plVar7 == DAT_181e8f4a0)) {
              plVar10 = plVar7;
            }
            NGUITools.PlaySound(plVar10,0);
            if (this.gameSaveData != null) {
              this.gameSaveData.worldDataFinished = 1;
              if (this.gameSaveData != null) {
                this.gameSaveData.heroListFinished = 1;
                if (this.gameSaveData != null) {
                  this.gameSaveData.tempHeroListFinished = 1;
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x60016DF
    // RVA   : 0xBC7370   Offset: 0xBC6170   Length: 0x23C
    public void Load(int saveID)
    {
        long lVar1;
        bool cVar2;
        long lVar3;
        ulong uVar4;
        lVar3 = new c.DisplayClass9_0(0);
        if (lVar3 != null) {
          *(int64 *)(lVar3 + 16) = this;
          *(uint32 *)(lVar3 + 24) = saveID;
          if (this.gameSaveData != null) {
            cVar2 = GameSaveData.CheckAllFinished(this.gameSaveData,0);
            if (cVar2) {
              uVar4 = GameDataController.GetSaveDataPath(this,*(uint32 *)(lVar3 + 24),0,0);
              cVar2 = File.Exists(uVar4,0);
              if (cVar2) {
                if (this.gameSaveData != null) {
                  GameSaveData.SetAllUnfinish(this.gameSaveData,1,0);
                  uVar4 = Stopwatch.StartNew(0);
                  *(uint64 *)(lVar3 + 32) = uVar4;
                  lVar1 = FUN_180603c30(0);
                  uVar4 = new OnTooltipCB(lVar3,DAT_181e881a0,0);
                  if (lVar1 != null) {
                    TaskFactory.StartNew(lVar1,uVar4,2);
                    lVar1 = FUN_180603c30(0);
                    uVar4 = new OnTooltipCB(lVar3,DAT_181e88220,0);
                    if (lVar1 != null) {
                      TaskFactory.StartNew(lVar1,uVar4,2);
                      lVar1 = FUN_180603c30(0);
                      uVar4 = new OnTooltipCB(lVar3,DAT_181e882a0,0);
                      if (lVar1 != null) {
                        TaskFactory.StartNew(lVar1,uVar4,2);
                        return;
                      }
                    }
                  }
                }
                throw; // [null/range check failed]
              }
            }
            return;
          }
        }
    }

    // Token : 0x60016E0
    // RVA   : 0xBB8E70   Offset: 0xBB7C70   Length: 0x2D
    public string GetSaveDataPath()
    {
        bool cVar1;
        cVar1 = Directory.Exists(this.saveDataPath,0);
        if (!cVar1) {
          Directory.CreateDirectory(this.saveDataPath,0);
        }
        return this.saveDataPath;
    }

    // Token : 0x60016E1
    // RVA   : 0xBB81D0   Offset: 0xBB6FD0   Length: 0x2D
    public string GetBackupDataPath()
    {
        bool cVar1;
        cVar1 = Directory.Exists(this.backupDataPath,0);
        if (!cVar1) {
          Directory.CreateDirectory(this.backupDataPath,0);
        }
        return this.backupDataPath;
    }

    // Token : 0x60016E2
    // RVA   : 0xBB9E40   Offset: 0xBB8C40   Length: 0xA27B
    private void LoadAllGameData()
    {
        var plVar13 = *(int64*)(lVar13 + 184);
        var pStatics = *(int64*)(DAT_181e538e8 + 184);
        bool cVar4;
        byte uVar5;
        int iVar6;
        int iVar7;
        uint uVar8;
        uint32 extraout_EAX;
        uint64 uVar9;
        int64 *plVar10;
        int64 lVar11;
        int64 lVar12;
        int64 lVar13;
        int64 lVar14;
        uint64 uVar15;
        int64 lVar16;
        int64 lVar17;
        int64 *plVar18;
        uint32 *puVar19;
        int64 lVar20;
        int64 lVar21;
        uint32 extraout_var;
        int iVar22;
        int iVar23;
        int iVar24;
        uint32 uVar25;
        uint32 uVar26;
        float fVar27;
        int local_res18;
        uint64 local_110;
        int64 local_f8;
        uint32 local_f0;
        uint64 local_e8;
        uint64 uStack_e0;
        int64 local_d8;
        uint64 local_d0;
        uint64 uStack_c8;
        int64 local_c0;
        uint64 local_a0;
        uint64 uStack_98;
        int64 local_90;
        uint64 local_88;
        uint64 uStack_80;
        int64 local_78;
        uint64 local_70;
        uint64 uStack_68;
        int64 local_60;
        uVar9 = DAT_181ea28c0;
        local_d0 = 0;
        uStack_c8 = 0;
        local_c0 = 0;
        local_e8 = 0;
        uStack_e0 = 0;
        local_d8 = 0;
        uVar9 = Type.GetTypeFromHandle(uVar9,0);
        plVar10 = (int64 *)Resources.Load("GameData/NameData",uVar9,0);
        if (plVar10 != (int64 *)0) {
          plVar18 = plVar10;
          plVar18 = plVar10;
          uVar9 = FUN_180b00cb0(plVar18,0);
          var lVar11 = new c.DisplayClass9_0(0);
          if (lVar11 != null) {
            LTCSVLoader.ReadMultiLine(lVar11,uVar9,0);
            iVar6 = LTCSVLoader.GetRow(lVar11,0);
            iVar22 = 1;
            if (1 < iVar6) {
              do {
                lVar12 = LTCSVLoader.GetValueAt(lVar11,0,iVar22,0);
                if (lVar12 != null) {
                  cVar4 = FUN_1816387f0(lVar12,"姓",0);
                  if (!cVar4) {
                    cVar4 = FUN_1816387f0(lVar12,"名",0);
                    if (!cVar4) {
                      cVar4 = FUN_1816387f0(lVar12,"男名",0);
                      if (!cVar4) {
                        cVar4 = FUN_1816387f0(lVar12,"女名",0);
                        if (cVar4) {
                          iVar24 = 1;
                          do {
                            lVar12 = LTCSVLoader.GetValueAt(lVar11,iVar24,iVar22,0);
                            if (lVar12 != null) {
                              uVar9 = LTCSVLoader.GetValueAt(lVar11,iVar24,iVar22,0);
                              cVar4 = String.op_Inequality(uVar9,"",0);
                              if (cVar4) {
                                lVar12 = this.femaleGivenNameDataBase;
                                uVar9 = LTCSVLoader.GetValueAt(lVar11,iVar24,iVar22,0);
                                if (lVar12 == null) goto LAB_180bc3e85;
                                FUN_18175de30(lVar12,uVar9,DAT_181e86370);
                              }
                            }
                            iVar24 = iVar24 + 1;
                          } while (iVar24 < 6);
                        }
                      }
                      else {
                        iVar24 = 1;
                        do {
                          lVar12 = LTCSVLoader.GetValueAt(lVar11,iVar24,iVar22,0);
                          if (lVar12 != null) {
                            uVar9 = LTCSVLoader.GetValueAt(lVar11,iVar24,iVar22,0);
                            cVar4 = String.op_Inequality(uVar9,"",0);
                            if (cVar4) {
                              lVar12 = this.maleGivenNameDataBase;
                              uVar9 = LTCSVLoader.GetValueAt(lVar11,iVar24,iVar22,0);
                              if (lVar12 == null) goto LAB_180bc3e85;
                              FUN_18175de30(lVar12,uVar9,DAT_181e86370);
                            }
                          }
                          iVar24 = iVar24 + 1;
                        } while (iVar24 < 6);
                      }
                    }
                    else {
                      iVar24 = 1;
                      do {
                        lVar12 = LTCSVLoader.GetValueAt(lVar11,iVar24,iVar22,0);
                        if (lVar12 != null) {
                          uVar9 = LTCSVLoader.GetValueAt(lVar11,iVar24,iVar22,0);
                          cVar4 = String.op_Inequality(uVar9,"",0);
                          if (cVar4) {
                            lVar12 = this.givenNameDataBase;
                            uVar9 = LTCSVLoader.GetValueAt(lVar11,iVar24,iVar22,0);
                            if (lVar12 == null) goto LAB_180bc3e85;
                            FUN_18175de30(lVar12,uVar9,DAT_181e86370);
                          }
                        }
                        iVar24 = iVar24 + 1;
                      } while (iVar24 < 6);
                    }
                  }
                  else {
                    iVar24 = 1;
                    do {
                      lVar12 = LTCSVLoader.GetValueAt(lVar11,iVar24,iVar22,0);
                      if (lVar12 != null) {
                        uVar9 = LTCSVLoader.GetValueAt(lVar11,iVar24,iVar22,0);
                        cVar4 = String.op_Inequality(uVar9,"",0);
                        if (cVar4) {
                          lVar12 = this.familyNameDataBase;
                          uVar9 = LTCSVLoader.GetValueAt(lVar11,iVar24,iVar22,0);
                          if (lVar12 == null) goto LAB_180bc3e85;
                          FUN_18175de30(lVar12,uVar9,DAT_181e86370);
                        }
                      }
                      iVar24 = iVar24 + 1;
                    } while (iVar24 < 6);
                  }
                }
                iVar22 = iVar22 + 1;
              } while (iVar22 < iVar6);
            }
            uVar9 = DAT_181ea28c0;
            uVar9 = Type.GetTypeFromHandle(uVar9,0);
            plVar10 = (int64 *)Resources.Load("GameData/SpeAddDataBase",uVar9,0);
            if (plVar10 != (int64 *)0) {
              plVar18 = plVar10;
              plVar18 = plVar10;
              uVar9 = FUN_180b00cb0(plVar18,0);
              var lVar11 = new c.DisplayClass9_0(0);
              if (lVar11 != null) {
                LTCSVLoader.ReadMultiLine(lVar11,uVar9,0);
                iVar6 = LTCSVLoader.GetRow(lVar11,0);
                iVar22 = 1;
                if (1 < iVar6) {
                  do {
                    var lVar12 = new c.DisplayClass9_0(0);
                    uVar9 = LTCSVLoader.GetValueAt(lVar11,1,iVar22);
                    if (lVar12 == null) goto LAB_180bc3e85;
                    lVar12._items = uVar9;
                    uVar9 = LTCSVLoader.GetValueAt(lVar11,2,iVar22);
                    uVar25 = Single.Parse(uVar9,0);
                    *(uint32 *)(lVar12 + 32) = uVar25;
                    uVar9 = LTCSVLoader.GetValueAt(lVar11,3,iVar22);
                    *(uint64 *)(lVar12 + 40) = uVar9;
                    uVar9 = LTCSVLoader.GetValueAt(lVar11,4,iVar22);
                    *(uint64 *)(lVar12 + 48) = uVar9;
                    uVar9 = LTCSVLoader.GetValueAt(lVar11,5,iVar22);
                    uVar5 = FUN_1816387f0(uVar9,"1",0);
                    *(uint8 *)(lVar12 + 56) = uVar5;
                    uVar9 = LTCSVLoader.GetValueAt(lVar11,6,iVar22);
                    uVar5 = FUN_1816387f0(uVar9,"1",0);
                    *(uint8 *)(lVar12 + 57) = uVar5;
                    uVar9 = LTCSVLoader.GetValueAt(lVar11,7,iVar22);
                    uVar5 = FUN_1816387f0(uVar9,"0",0);
                    *(uint8 *)(lVar12 + 58) = uVar5;
                    uVar9 = LTCSVLoader.GetValueAt(lVar11,8,iVar22);
                    uVar25 = Int32.Parse(uVar9,0);
                    *(uint32 *)(lVar12 + 60) = uVar25;
                    uVar9 = LTCSVLoader.GetValueAt(lVar11,9,iVar22);
                    uVar5 = FUN_1816387f0(uVar9,"1",0);
                    *(uint8 *)(lVar12 + 64) = uVar5;
                    uVar9 = LTCSVLoader.GetValueAt(lVar11,10,iVar22);
                    lVar12.Count = uVar9;
                    uVar9 = LTCSVLoader.GetValueAt(lVar11,11,iVar22);
                    *(uint64 *)(lVar12 + 72) = uVar9;
                    uVar9 = LTCSVLoader.GetValueAt(lVar11,12,iVar22);
                    uVar5 = FUN_1816387f0(uVar9,"1",0);
                    *(uint8 *)(lVar12 + 80) = uVar5;
                    uVar9 = LTCSVLoader.GetValueAt(lVar11,13,iVar22);
                    uVar25 = Int32.Parse(uVar9,0);
                    *(uint32 *)(lVar12 + 84) = uVar25;
                    uVar9 = LTCSVLoader.GetValueAt(lVar11,14,iVar22);
                    uVar5 = FUN_1816387f0(uVar9,"1",0);
                    *(uint8 *)(lVar12 + 88) = uVar5;
                    uVar9 = LTCSVLoader.GetValueAt(lVar11,15,iVar22);
                    uVar5 = FUN_1816387f0(uVar9,"1",0);
                    *(uint8 *)(lVar12 + 89) = uVar5;
                    uVar9 = LTCSVLoader.GetValueAt(lVar11,16,iVar22);
                    uVar5 = FUN_1816387f0(uVar9,"1",0);
                    *(uint8 *)(lVar12 + 90) = uVar5;
                    if (this.speAddDataBase == null) goto LAB_180bc3e85;
                    FUN_18175de30(this.speAddDataBase,lVar12,DAT_181e6e0f0);
                    if (*(char *)(lVar12 + 57) == false) {
                      if ((this.speAddDataBase == null) || (this.randomSpeAddAvailableID == null))
                      goto LAB_180bc3e85;
                      FUN_181769fe0(this.randomSpeAddAvailableID,
                                    this.speAddDataBase.Count + -1,DAT_181e713f0);
                      if (*(char *)(lVar12 + 58) != false) {
                        if ((this.speAddDataBase == null) || (this.randomSpeAddNegativeAvailableID == null))
                        goto LAB_180bc3e85;
                        FUN_181769fe0(this.randomSpeAddNegativeAvailableID,
                                      this.speAddDataBase.Count + -1,DAT_181e713f0);
                      }
                      if (*(char *)(lVar12 + 64) != false) {
                        if ((this.speAddDataBase == null) || (this.randomSpeAddSelfBuffID == null))
                        goto LAB_180bc3e85;
                        FUN_181769fe0(this.randomSpeAddSelfBuffID,
                                      this.speAddDataBase.Count + -1,DAT_181e713f0);
                      }
                      if ((0 < *(int *)(lVar12 + 60)) && (*(char *)(lVar12 + 64) == false)) {
                        if ((this.speAddDataBase == null) || (this.randomSpeAddEnemyBuffID == null))
                        goto LAB_180bc3e85;
                        FUN_181769fe0(this.randomSpeAddEnemyBuffID,
                                      this.speAddDataBase.Count + -1,DAT_181e713f0);
                      }
                    }
                    iVar22 = iVar22 + 1;
                  } while (iVar22 < iVar6);
                }
                uVar9 = DAT_181ea28c0;
                uVar9 = Type.GetTypeFromHandle(uVar9,0);
                plVar10 = (int64 *)Resources.Load("GameData/ForceSpeAddDataBase",uVar9,0);
                if (plVar10 != (int64 *)0) {
                  plVar18 = plVar10;
                  plVar18 = plVar10;
                  uVar9 = FUN_180b00cb0(plVar18,0);
                  var lVar11 = new c.DisplayClass9_0(0);
                  if (lVar11 != null) {
                    LTCSVLoader.ReadMultiLine(lVar11,uVar9,0);
                    iVar6 = LTCSVLoader.GetRow(lVar11,0);
                    iVar22 = 1;
                    if (1 < iVar6) {
                      do {
                        var lVar12 = new c.DisplayClass9_0(0);
                        uVar9 = LTCSVLoader.GetValueAt(lVar11,1,iVar22);
                        if (lVar12 == null) goto LAB_180bc3e85;
                        lVar12._items = uVar9;
                        uVar9 = LTCSVLoader.GetValueAt(lVar11,2,iVar22);
                        lVar12.Count = uVar9;
                        uVar9 = LTCSVLoader.GetValueAt(lVar11,3,iVar22);
                        uVar5 = FUN_1816387f0(uVar9,"TRUE",0);
                        *(uint8 *)(lVar12 + 32) = uVar5;
                        uVar9 = LTCSVLoader.GetValueAt(lVar11,4,iVar22);
                        uVar25 = Single.Parse(uVar9,0);
                        *(uint32 *)(lVar12 + 36) = uVar25;
                        if (this.forceSpeAddDataBase == null) goto LAB_180bc3e85;
                        FUN_18175de30(this.forceSpeAddDataBase,lVar12,DAT_181e6aaf8);
                        iVar22 = iVar22 + 1;
                      } while (iVar22 < iVar6);
                    }
                    uVar9 = DAT_181ea28c0;
                    uVar9 = Type.GetTypeFromHandle(uVar9,0);
                    plVar10 = (int64 *)Resources.Load("GameData/TechDataBase",uVar9,0);
                    if (plVar10 != (int64 *)0) {
                      plVar18 = plVar10;
                      plVar18 = plVar10;
                      uVar9 = FUN_180b00cb0(plVar18,0);
                      var lVar11 = new c.DisplayClass9_0(0);
                      if (lVar11 != null) {
                        LTCSVLoader.ReadMultiLine(lVar11,uVar9,0);
                        iVar6 = LTCSVLoader.GetRow(lVar11,0);
                        uVar9 = il2cpp_internal(DAT_181e60b50);
                        FUN_1806e5bc0(uVar9,DAT_181e9ae60);
                        this.forceTechDataBase = uVar9;
                        iVar22 = 1;
                        if (1 < iVar6) {
                          do {
                            var lVar12 = new c.DisplayClass9_0(0);
                            uVar9 = LTCSVLoader.GetValueAt(lVar11,0,iVar22,0);
                            uVar25 = Int32.Parse(uVar9,0);
                            if (lVar12 == null) goto LAB_180bc3e85;
                            lVar12._items = uVar25;
                            uVar9 = LTCSVLoader.GetValueAt(lVar11,1,iVar22);
                            lVar12.Count = uVar9;
                            uVar9 = LTCSVLoader.GetValueAt(lVar11,2,iVar22);
                            *(uint64 *)(lVar12 + 32) = uVar9;
                            uVar9 = LTCSVLoader.GetValueAt(lVar11,3,iVar22);
                            uVar25 = Int32.Parse(uVar9,0);
                            *(uint32 *)(lVar12 + 40) = uVar25;
                            iVar24 = 0;
                            while( true ) {
                              if (this.forceSpeAddDataBase == null) goto LAB_180bc3e85;
                              if (this.forceSpeAddDataBase.Count <= iVar24) break;
                              uVar9 = LTCSVLoader.GetValueAt(lVar11,4,iVar22);
                              if ((this.forceSpeAddDataBase == null) ||
                                 (lVar13 = FUN_1800024b0(this.forceSpeAddDataBase,iVar24,
                                                         DAT_181e6abf8), lVar13 == null)) goto LAB_180bc3e85;
                              cVar4 = FUN_1816387f0(uVar9,lVar13.buckets,0);
                              if (cVar4) {
                                *(int *)(lVar12 + 44) = iVar24;
                              }
                              iVar24 = iVar24 + 1;
                            }
                            uVar9 = LTCSVLoader.GetValueAt(lVar11,5,iVar22);
                            uVar25 = Single.Parse(uVar9,0);
                            *(uint32 *)(lVar12 + 48) = uVar25;
                            uVar9 = LTCSVLoader.GetValueAt(lVar11,6,iVar22);
                            uVar5 = FUN_1816387f0(uVar9,"TRUE",0);
                            *(uint8 *)(lVar12 + 52) = uVar5;
                            uVar9 = LTCSVLoader.GetValueAt(lVar11,7,iVar22);
                            uVar25 = Single.Parse(uVar9,0);
                            *(uint32 *)(lVar12 + 56) = uVar25;
                            lVar13 = *(int64 *)(pStatics + 0x440);
                            uVar9 = LTCSVLoader.GetValueAt(lVar11,8,iVar22);
                            if (lVar13 == null) goto LAB_180bc3e85;
                            uVar25 = FUN_181662a20(lVar13,uVar9,DAT_181e865f0);
                            *(uint32 *)(lVar12 + 60) = uVar25;
                            if (this.forceTechDataBase == null) goto LAB_180bc3e85;
                            FUN_1806da2f0(this.forceTechDataBase,lVar12._items,
                                          lVar12);
                            iVar22 = iVar22 + 1;
                          } while (iVar22 < iVar6);
                        }
                        uVar9 = DAT_181ea28c0;
                        uVar9 = Type.GetTypeFromHandle(uVar9,0);
                        plVar10 = (int64 *)Resources.Load("GameData/AreaData",uVar9,0);
                        if (plVar10 != (int64 *)0) {
                          plVar18 = plVar10;
                          plVar18 = plVar10;
                          uVar9 = FUN_180b00cb0(plVar18,0);
                          var lVar11 = new c.DisplayClass9_0(0);
                          if (lVar11 != null) {
                            LTCSVLoader.ReadMultiLine(lVar11,uVar9,0);
                            iVar6 = LTCSVLoader.GetRow(lVar11,0);
                            uVar9 = il2cpp_internal(DAT_181e606d8);
                            FUN_1806e5bc0(uVar9,DAT_181e98d88);
                            *(uint64 *)(this + 200) = uVar9;
                            iVar22 = 1;
                            if (1 < iVar6) {
                              do {
                                var lVar12 = new AreaData(0);
                                uVar9 = LTCSVLoader.GetValueAt(lVar11,0,iVar22,0);
                                uVar25 = Int32.Parse(uVar9,0);
                                if (lVar12 == null) goto LAB_180bc3e85;
                                lVar12._items = uVar25;
                                uVar9 = LTCSVLoader.GetValueAt(lVar11,1,iVar22);
                                lVar12.Count = uVar9;
                                lVar13 = LTCSVLoader.GetValueAt(lVar11,2,iVar22);
                                if (lVar13 != null) {
                                  cVar4 = FUN_1816387f0(lVar13,"城市",0);
                                  if (!cVar4) {
                                    cVar4 = FUN_1816387f0(lVar13,"村镇",0);
                                    if (!cVar4) {
                                      cVar4 = FUN_1816387f0(lVar13,"门派",0);
                                      if (cVar4) {
                                        *(uint32 *)(lVar12 + 72) = 2;
                                      }
                                    }
                                    else {
                                      *(uint32 *)(lVar12 + 72) = 1;
                                    }
                                  }
                                  else {
                                    *(uint32 *)(lVar12 + 72) = 0;
                                  }
                                }
                                uVar9 = LTCSVLoader.GetValueAt(lVar11,3,iVar22);
                                *(uint64 *)(lVar12 + 40) = uVar9;
                                uVar9 = LTCSVLoader.GetValueAt(lVar11,4,iVar22);
                                uVar25 = Int32.Parse(uVar9,0);
                                *(uint32 *)(lVar12 + 112) = uVar25;
                                lVar13 = LTCSVLoader.GetValueAt(lVar11,5,iVar22);
                                lVar14 = FUN_1801dfd90(DAT_181e81128,1);
                                if ((lVar14 == null) || (FUN_180002550(lVar14,0,44), lVar13 == null))
                                goto LAB_180bc3e85;
                                lVar13 = String.Split(lVar13,lVar14,0);
                                iVar24 = 0;
                                while( true ) {
                                  if (lVar13 == null) goto LAB_180bc3e85;
                                  if (lVar13.entries <= iVar24) break;
                                  lVar14 = *(int64 *)(lVar12 + 152);
                                  uVar9 = FUN_180002230(lVar13,(int64)iVar24);
                                  uVar25 = Int32.Parse(uVar9,0);
                                  if (lVar14 == null) goto LAB_180bc3e85;
                                  FUN_181769fe0(lVar14,uVar25,DAT_181e713f0);
                                  iVar24 = iVar24 + 1;
                                }
                                uVar9 = LTCSVLoader.GetValueAt(lVar11,6,iVar22);
                                uVar25 = Int32.Parse(uVar9,0);
                                *(uint32 *)(lVar12 + 32) = uVar25;
                                uVar9 = LTCSVLoader.GetValueAt(lVar11,7,iVar22);
                                *(uint64 *)(lVar12 + 48) = uVar9;
                                uVar9 = LTCSVLoader.GetValueAt(lVar11,8,iVar22);
                                cVar4 = FUN_1816387f0(uVar9,"-1",0);
                                if (!cVar4) {
                                  uVar9 = LTCSVLoader.GetValueAt(lVar11,8,iVar22);
                                  uVar25 = Int32.Parse(uVar9,0);
                                }
                                else {
                                  uVar25 = GlobalData.RandomRange(0,4,0);
                                }
                                *(uint32 *)(lVar12 + 56) = uVar25;
                                uVar9 = LTCSVLoader.GetValueAt(lVar11,9,iVar22);
                                uVar25 = Single.Parse(uVar9,0);
                                *(uint32 *)(lVar12 + 60) = uVar25;
                                uVar9 = LTCSVLoader.GetValueAt(lVar11,10,iVar22);
                                cVar4 = FUN_180ad1200(uVar9,0);
                                if (!cVar4) {
                                  uVar9 = LTCSVLoader.GetValueAt(lVar11,10,iVar22);
                                  cVar4 = String.op_Inequality(uVar9,"无",0);
                                  if (!cVar4) goto LAB_180bbbc0e;
                                  lVar13 = LTCSVLoader.GetValueAt(lVar11,10,iVar22);
                                  lVar14 = FUN_1801dfd90(DAT_181e81128,1);
                                  if ((lVar14 == null) || (FUN_180002550(lVar14,0,32), lVar13 == null))
                                  goto LAB_180bc3e85;
                                  uVar15 = String.Split(lVar13,lVar14,0);
                                  uVar9 = il2cpp_internal(DAT_181e77728);
                                  FUN_1817673a0(uVar9,uVar15,DAT_181e86270);
                                  *(uint64 *)(lVar12 + 0x108) = uVar9;
                                }
                                else {
        LAB_180bbbc0e:
                                  uVar9 = il2cpp_internal(DAT_181e77728);
                                  FUN_1810f3480(uVar9,DAT_181e861f0);
                                  *(uint64 *)(lVar12 + 0x108) = uVar9;
                                }
                                il2cpp_internal(lVar12 + 0x108,uVar9);
                                lVar13 = LTCSVLoader.GetValueAt(lVar11,11,iVar22);
                                lVar14 = FUN_1801dfd90(DAT_181e81128,1);
                                if ((lVar14 == null) || (FUN_180002550(lVar14,0,59), lVar13 == null))
                                goto LAB_180bc3e85;
                                lVar14 = String.Split(lVar13,lVar14,0);
                                lVar13 = *(int64 *)(lVar12 + 64);
                                if (lVar14 == null) goto LAB_180bc3e85;
                                uVar9 = FUN_180002230(lVar14,0);
                                uVar25 = Single.Parse(uVar9,0);
                                uVar9 = FUN_180002230(lVar14,1);
                                uVar26 = Single.Parse(uVar9,0);
                                local_110 = CONCAT44(uVar26,uVar25);
                                if (lVar13 == null) goto LAB_180bc3e85;
                                local_f8 = local_110;
                                local_f0 = 0;
                                BigMapPos.SetByVector3(lVar13,&local_f8,0);
                                uVar9 = LTCSVLoader.GetValueAt(lVar11,12,iVar22);
                                cVar4 = FUN_1816387f0(uVar9,"0",0);
                                if (!cVar4) {
                                  lVar13 = LTCSVLoader.GetValueAt(lVar11,12,iVar22);
                                  lVar14 = FUN_1801dfd90(DAT_181e81128,1);
                                  if ((lVar14 == null) || (FUN_180002550(lVar14,0,59), lVar13 == null))
                                  goto LAB_180bc3e85;
                                  lVar14 = String.Split(lVar13,lVar14,0);
                                  lVar13 = il2cpp_internal(DAT_181e76ea8);
                                  FUN_1810f3480(lVar13,DAT_181e83230);
                                  if (lVar14 == null) goto LAB_180bc3e85;
                                  uVar9 = FUN_180002230(lVar14,0);
                                  uVar25 = Single.Parse(uVar9,0);
                                  if (lVar13 == null) goto LAB_180bc3e85;
                                  FUN_18175dba0(lVar13,uVar25,DAT_181e83330);
                                  uVar9 = FUN_180002230(lVar14,1);
                                  uVar25 = Single.Parse(uVar9,0);
                                  FUN_18175dba0(lVar13,uVar25,DAT_181e83330);
                                  *(int64 *)(lVar12 + 0x110) = lVar13;
                                }
                                else {
                                  *(uint64 *)(lVar12 + 0x110) = 0;
                                  lVar13 = 0;
                                }
                                il2cpp_internal(lVar12 + 0x110,lVar13);
                                cVar4 = FUN_1816387f0(*(uint64 *)(lVar12 + 40),"村镇",0);
                                if (cVar4) {
                                  uVar9 = String.Concat(*(uint64 *)(lVar12 + 40),"_",
                                                         *(uint64 *)(lVar12 + 48),0);
                                  *(uint64 *)(lVar12 + 40) = uVar9;
                                }
                                if (*(int64 *)(this + 200) == 0) goto LAB_180bc3e85;
                                FUN_1806da2f0(*(int64 *)(this + 200),lVar12._items,
                                              lVar12);
                                iVar22 = iVar22 + 1;
                              } while (iVar22 < iVar6);
                            }
                            uVar9 = DAT_181ea28c0;
                            uVar9 = Type.GetTypeFromHandle(uVar9,0);
                            plVar10 = (int64 *)Resources.Load("GameData/ResourcePointTypeData",uVar9,0);
                            if (plVar10 != (int64 *)0) {
                              plVar18 = plVar10;
                              plVar18 = plVar10;
                              uVar9 = FUN_180b00cb0(plVar18,0);
                              var lVar11 = new c.DisplayClass9_0(0);
                              if (lVar11 != null) {
                                LTCSVLoader.ReadMultiLine(lVar11,uVar9,0);
                                iVar6 = LTCSVLoader.GetRow(lVar11,0);
                                lVar12 = il2cpp_internal(DAT_181e61348);
                                FUN_1806e5bc0(lVar12,DAT_181e9f098);
                                this.resourcePointTypeDataBase = lVar12;
                                iVar22 = 1;
                                if (1 < iVar6) {
                                  do {
                                    var lVar12 = new ResourcePointTypeData(0);
                                    uVar9 = LTCSVLoader.GetValueAt(lVar11,0,iVar22,0);
                                    uVar25 = Int32.Parse(uVar9,0);
                                    if (lVar12 == null) goto LAB_180bc3e85;
                                    lVar12._items = uVar25;
                                    uVar9 = LTCSVLoader.GetValueAt(lVar11,1,iVar22);
                                    lVar12.Count = uVar9;
                                    uVar9 = LTCSVLoader.GetValueAt(lVar11,2,iVar22);
                                    cVar4 = String.op_Inequality(uVar9,"",0);
                                    if (cVar4) {
                                      lVar13 = LTCSVLoader.GetValueAt(lVar11,2,iVar22);
                                      lVar14 = FUN_1801dfd90(DAT_181e81128,1);
                                      if ((lVar14 == null) || (FUN_180002550(lVar14,0,44), lVar13 == null))
                                      goto LAB_180bc3e85;
                                      lVar13 = String.Split(lVar13,lVar14,0);
                                      iVar24 = 0;
                                      while( true ) {
                                        if (lVar13 == null) goto LAB_180bc3e85;
                                        if (lVar13.entries <= iVar24) break;
                                        lVar14 = FUN_180002230(lVar13,(int64)iVar24);
                                        lVar16 = FUN_1801dfd90(DAT_181e81128,1);
                                        if ((lVar16 == null) || (FUN_180002550(lVar16,0,43), lVar14 == null))
                                        goto LAB_180bc3e85;
                                        lVar14 = String.Split(lVar14,lVar16,0);
                                        lVar16 = *(int64 *)
                                                  (pStatics + 0x440);
                                        if ((lVar14 == null) ||
                                           (uVar9 = FUN_180002230(lVar14,0), lVar16 == null))
                                        goto LAB_180bc3e85;
                                        uVar25 = FUN_181662a20(lVar16,uVar9,DAT_181e865f0);
                                        lVar16 = *(int64 *)(lVar12 + 32);
                                        uVar9 = FUN_180002230(lVar14,1);
                                        iVar7 = Int32.Parse(uVar9,0);
                                        lVar14 = *(int64 *)
                                                  (pStatics + 0x450);
                                        if ((lVar14 == null) ||
                                           (fVar27 = (float)FUN_1800024e0(lVar14,uVar25,DAT_181e83530),
                                           lVar16 == null)) goto LAB_180bc3e85;
                                        FUN_181769c70(lVar16,uVar25,(float)(iVar7 * 50) / fVar27);
                                        iVar24 = iVar24 + 1;
                                      }
                                    }
                                    uVar9 = LTCSVLoader.GetValueAt(lVar11,3,iVar22);
                                    cVar4 = String.op_Inequality(uVar9,"",0);
                                    if (cVar4) {
                                      lVar13 = LTCSVLoader.GetValueAt(lVar11,3,iVar22);
                                      lVar14 = FUN_1801dfd90(DAT_181e81128,1);
                                      if ((lVar14 == null) || (FUN_180002550(lVar14,0,59), lVar13 == null))
                                      goto LAB_180bc3e85;
                                      lVar13 = String.Split(lVar13,lVar14,0);
                                      iVar24 = 0;
                                      while( true ) {
                                        if (lVar13 == null) goto LAB_180bc3e85;
                                        if (lVar13.entries <= iVar24) break;
                                        iVar7 = 0;
                                        while( true ) {
                                          if (this.forceSpeAddDataBase == null) goto LAB_180bc3e85;
                                          if (this.forceSpeAddDataBase.Count <= iVar7)
                                          break;
                                          uVar9 = FUN_180002230(lVar13,(int64)iVar24);
                                          uVar9 = GlobalData.GetChinese(uVar9,0);
                                          if ((this.forceSpeAddDataBase == null) ||
                                             (lVar14 = FUN_1800024b0(this.forceSpeAddDataBase,iVar7,
                                                                     DAT_181e6abf8), lVar14 == null))
                                          goto LAB_180bc3e85;
                                          cVar4 = FUN_1816387f0(uVar9,*(uint64 *)(lVar14 + 16),0);
                                          if (cVar4) {
                                            lVar14 = *(int64 *)(lVar12 + 40);
                                            lVar16 = FUN_180002230(lVar13,(int64)iVar24);
                                            if (((this.forceSpeAddDataBase == null) ||
                                                (lVar17 = FUN_1800024b0(this.forceSpeAddDataBase,
                                                                        iVar7,DAT_181e6abf8), lVar17 == null)
                                                ) || (lVar16 == null)) goto LAB_180bc3e85;
                                            uVar9 = String.Replace(lVar16,*(uint64 *)(lVar17 + 16),
                                                                    "");
                                            Single.Parse(uVar9,0);
                                            if (lVar14 == null) goto LAB_180bc3e85;
                                            ForceSpeAddData.Set(lVar14,iVar7);
                                          }
                                          iVar7 = iVar7 + 1;
                                        }
                                        iVar24 = iVar24 + 1;
                                      }
                                    }
                                    uVar9 = LTCSVLoader.GetValueAt(lVar11,4,iVar22);
                                    cVar4 = String.op_Inequality(uVar9,"",0);
                                    if (cVar4) {
                                      uVar9 = LTCSVLoader.GetValueAt(lVar11,4,iVar22);
                                      uVar9 = GameDataController.StringToSpeAddData(this,uVar9,0);
                                      *(uint64 *)(lVar12 + 48) = uVar9;
                                    }
                                    if (*plVar10 == 0) goto LAB_180bc3e85;
                                    FUN_1806da2f0(*plVar10,lVar12._items,lVar12);
                                    iVar22 = iVar22 + 1;
                                  } while (iVar22 < iVar6);
                                }
                                uVar9 = DAT_181ea28c0;
                                uVar9 = Type.GetTypeFromHandle(uVar9,0);
                                plVar10 = (int64 *)Resources.Load("GameData/ResourcePointData",uVar9,0);
                                if (plVar10 != (int64 *)0) {
                                  plVar18 = plVar10;
                                  plVar18 = plVar10;
                                  uVar9 = FUN_180b00cb0(plVar18,0);
                                  var lVar11 = new c.DisplayClass9_0(0);
                                  if (lVar11 != null) {
                                    LTCSVLoader.ReadMultiLine(lVar11,uVar9,0);
                                    iVar6 = LTCSVLoader.GetRow(lVar11,0);
                                    uVar9 = il2cpp_internal(DAT_181e612c8);
                                    FUN_1806e5bc0(uVar9,DAT_181e9ee78);
                                    this.resourcePointDataBase = uVar9;
                                    for (iVar22 = 1; uVar9 = DAT_181ea28c0, iVar22 < iVar6;
                                        iVar22 = iVar22 + 1) {
                                      var lVar12 = new ResourcePointData(0);
                                      uVar9 = LTCSVLoader.GetValueAt(lVar11,0,iVar22,0);
                                      uVar25 = Int32.Parse(uVar9,0);
                                      if (lVar12 == null) goto LAB_180bc3e85;
                                      lVar12._items = uVar25;
                                      uVar9 = LTCSVLoader.GetValueAt(lVar11,1,iVar22);
                                      lVar12.Count = uVar9;
                                      if ((this.resourcePointTypeDataBase == null) ||
                                         (lVar13 = FUN_1806e0520(this.resourcePointTypeDataBase,
                                                                 DAT_181e9f230), lVar13 == null))
                                      goto LAB_180bc3e85;
                                      ValueCollection.GetEnumerator(&local_a0,lVar13,DAT_181e622a0);
                                      local_d0 = local_a0;
                                      uStack_c8 = uStack_98;
                                      local_c0 = local_90;
                                      do {
                                        cVar4 = FUN_180dd6250(&local_d0,DAT_181e7cbb0);
                                        lVar13 = local_c0;
                                        if (!cVar4) goto LAB_180bbc79b;
                                        if (local_c0 == 0) {
                          // WARNING: Subroutine does not return
                                          FUN_1801e0300();
                                        }
                                        cVar4 = FUN_1816387f0(*(uint64 *)(local_c0 + 24),
                                                              lVar12.Count,0);
                                      } while (!cVar4);
                                      if (lVar13 == null) {
                          // WARNING: Subroutine does not return
                                        FUN_1801e0300();
                                      }
                                      *(uint32 *)(lVar12 + 20) = lVar13.buckets;
        LAB_180bbc79b:
                                      ZhSegment.Initialize(&local_d0,DAT_181e7cb30);
                                      if (lVar12 == null) goto LAB_180bc3e85;
                                      *(uint64 *)(lVar12 + 32) = lVar12.Count;
                                      if (lVar11 == null) goto LAB_180bc3e85;
                                      uVar9 = LTCSVLoader.GetValueAt(lVar11,4,iVar22);
                                      uVar25 = Int32.Parse(uVar9,0);
                                      *(uint32 *)(lVar12 + 48) = uVar25;
                                      uVar9 = LTCSVLoader.GetValueAt(lVar11,5,iVar22);
                                      uVar25 = Int32.Parse(uVar9,0);
                                      *(uint32 *)(lVar12 + 52) = uVar25;
                                      if (this.resourcePointDataBase == null) goto LAB_180bc3e85;
                                      FUN_1806da2f0();
                                    }
                                    uVar9 = Type.GetTypeFromHandle(uVar9,0);
                                    plVar10 = (int64 *)Resources.Load("GameData/HeroTagData",uVar9,0);
                                    if (plVar10 != (int64 *)0) {
                                      plVar18 = plVar10;
                                      plVar18 = plVar10;
                                      uVar9 = FUN_180b00cb0(plVar18,0);
                                      var lVar11 = new c.DisplayClass9_0(0);
                                      if (lVar11 != null) {
                                        LTCSVLoader.ReadMultiLine(lVar11,uVar9,0);
                                        iVar6 = LTCSVLoader.GetRow(lVar11,0);
                                        lVar12 = il2cpp_internal(DAT_181e60cd0);
                                        FUN_1806e5bc0(lVar12,DAT_181e9b900);
                                        this.heroTagDataBase = lVar12;
                                        iVar22 = 1;
                                        if (1 < iVar6) {
                                          do {
                                            var lVar12 = new HeroTagDataBase(0);
                                            uVar9 = LTCSVLoader.GetValueAt(lVar11,0,iVar22,0);
                                            uVar25 = Int32.Parse(uVar9,0);
                                            if (lVar12 == null) goto LAB_180bc3e85;
                                            lVar12._items = uVar25;
                                            uVar9 = LTCSVLoader.GetValueAt(lVar11,1,iVar22);
                                            lVar12.Count = uVar9;
                                            uVar9 = LTCSVLoader.GetValueAt(lVar11,2,iVar22);
                                            uVar25 = Int32.Parse(uVar9,0);
                                            *(uint32 *)(lVar12 + 32) = uVar25;
                                            uVar9 = DAT_181ea0fe0;
                                            uVar9 = Type.GetTypeFromHandle(uVar9,0);
                                            uVar15 = LTCSVLoader.GetValueAt(lVar11,3,iVar22);
                                            plVar18 = (int64 *)Enum.Parse(uVar9,uVar15,0);
                                            if (plVar18 == (int64 *)0) goto LAB_180bc3e85;
                                            if (*(int64 *)(*plVar18 + 64) !=
                                                *(int64 *)(DAT_181e83828 + 64)) {
                          // WARNING: Subroutine does not return
                                              FUN_1801dfd50(plVar18,DAT_181e83828);
                                            }
                                            puVar19 = (uint32 *)il2cpp_object_unbox();
                                            *(uint32 *)(lVar12 + 36) = *puVar19;
                                            uVar9 = LTCSVLoader.GetValueAt(lVar11,4,iVar22);
                                            uVar9 = GameDataController.StringToSpeAddData
                                                              (this,uVar9,0);
                                            *(uint64 *)(lVar12 + 88) = uVar9;
                                            uVar9 = LTCSVLoader.GetValueAt(lVar11,5,iVar22);
                                            *(uint64 *)(lVar12 + 40) = uVar9;
                                            uVar9 = LTCSVLoader.GetValueAt(lVar11,6,iVar22);
                                            *(uint64 *)(lVar12 + 48) = uVar9;
                                            uVar9 = LTCSVLoader.GetValueAt(lVar11,7,iVar22);
                                            uVar5 = FUN_1816387f0(uVar9,"1",0);
                                            *(uint8 *)(lVar12 + 56) = uVar5;
                                            uVar9 = LTCSVLoader.GetValueAt(lVar11,8,iVar22);
                                            uVar25 = Int32.Parse(uVar9,0);
                                            *(uint32 *)(lVar12 + 100) = uVar25;
                                            uVar9 = LTCSVLoader.GetValueAt(lVar11,9,iVar22);
                                            cVar4 = String.op_Inequality(uVar9,"",0);
                                            if (cVar4) {
                                              lVar13 = LTCSVLoader.GetValueAt(lVar11,9,iVar22);
                                              lVar14 = FUN_1801dfd90(DAT_181e81128,1);
                                              if ((lVar14 == null) ||
                                                 (FUN_180002550(lVar14,0,43), lVar13 == null))
                                              goto LAB_180bc3e85;
                                              uVar9 = String.Split(lVar13,lVar14,0);
                                              uVar9 = Enumerable.ToList(uVar9,DAT_181e98f58);
                                              *(uint64 *)(lVar12 + 64) = uVar9;
                                            }
                                            uVar9 = LTCSVLoader.GetValueAt(lVar11,10,iVar22);
                                            cVar4 = String.op_Inequality(uVar9,"",0);
                                            if (cVar4) {
                                              lVar13 = LTCSVLoader.GetValueAt(lVar11,10,iVar22);
                                              lVar14 = FUN_1801dfd90(DAT_181e81128,1);
                                              if ((lVar14 == null) ||
                                                 (FUN_180002550(lVar14,0,59), lVar13 == null))
                                              goto LAB_180bc3e85;
                                              uVar9 = String.Split(lVar13,lVar14,0);
                                              uVar9 = Enumerable.ToList(uVar9,DAT_181e98f58);
                                              *(uint64 *)(lVar12 + 72) = uVar9;
                                            }
                                            uVar9 = LTCSVLoader.GetValueAt(lVar11,11,iVar22);
                                            *(uint64 *)(lVar12 + 80) = uVar9;
                                            uVar9 = LTCSVLoader.GetValueAt(lVar11,12,iVar22);
                                            uVar5 = FUN_1816387f0(uVar9,"TRUE",0);
                                            *(uint8 *)(lVar12 + 96) = uVar5;
                                            if (*plVar10 == 0) goto LAB_180bc3e85;
                                            FUN_1806da2f0(*plVar10,lVar12._items,lVar12);
                                            iVar22 = iVar22 + 1;
                                          } while (iVar22 < iVar6);
                                        }
                                        uVar9 = DAT_181ea28c0;
                                        uVar9 = Type.GetTypeFromHandle(uVar9,0);
                                        plVar10 = (int64 *)Resources.Load("GameData/InnData",uVar9,0);
                                        if (plVar10 != (int64 *)0) {
                                          plVar18 = plVar10;
                                          plVar18 = plVar10;
                                          uVar9 = FUN_180b00cb0(plVar18,0);
                                          var lVar11 = new c.DisplayClass9_0(0);
                                          if (lVar11 != null) {
                                            LTCSVLoader.ReadMultiLine(lVar11,uVar9,0);
                                            iVar6 = LTCSVLoader.GetRow(lVar11,0);
                                            lVar12 = il2cpp_internal(DAT_181e60d50);
                                            FUN_1806e5bc0(lVar12,DAT_181e9bb20);
                                            this.innDataBase = lVar12;
                                            iVar22 = 1;
                                            if (1 < iVar6) {
                                              do {
                                                uVar9 = LTCSVLoader.GetValueAt(lVar11,0,iVar22,0);
                                                uVar25 = Int32.Parse(uVar9,0);
                                                uVar9 = LTCSVLoader.GetValueAt(lVar11,1,iVar22);
                                                var lVar12 = new InnData(uVar25,uVar9,0);
                                                uVar9 = LTCSVLoader.GetValueAt(lVar11,2,iVar22);
                                                if (lVar12 == null) goto LAB_180bc3e85;
                                                *(uint64 *)(lVar12 + 32) = uVar9;
                                                lVar13 = LTCSVLoader.GetValueAt(lVar11,3,iVar22);
                                                lVar14 = FUN_1801dfd90(DAT_181e81128,1);
                                                if (lVar14 == null) goto LAB_180bc3e85;
                                                if (*(int *)(lVar14 + 24) == 0) {
                                                  uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                  FUN_1801e02d0(uVar9,0);
                                                }
                                                *(uint16 *)(lVar14 + 32) = 59;
                                                if (lVar13 == null) goto LAB_180bc3e85;
                                                lVar14 = String.Split(lVar13,lVar14,0);
                                                lVar13 = *(int64 *)(lVar12 + 48);
                                                if (lVar14 == null) goto LAB_180bc3e85;
                                                if (*(int *)(lVar14 + 24) == 0) {
                                                  uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                  FUN_1801e02d0(uVar9,0);
                                                }
                                                uVar25 = Single.Parse(*(uint64 *)(lVar14 + 32),0);
                                                if (*(uint32 *)(lVar14 + 24) < 2) {
                                                  uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                  FUN_1801e02d0(uVar9,0);
                                                }
                                                uVar26 = Single.Parse(*(uint64 *)(lVar14 + 40),0);
                                                local_110 = CONCAT44(uVar26,uVar25);
                                                if (lVar13 == null) goto LAB_180bc3e85;
                                                local_f8 = local_110;
                                                local_f0 = 0;
                                                BigMapPos.SetByVector3(lVar13,&local_f8,0);
                                                if (*plVar10 == 0) goto LAB_180bc3e85;
                                                FUN_1806da2f0(*plVar10,lVar12._items,
                                                              lVar12);
                                                iVar22 = iVar22 + 1;
                                              } while (iVar22 < iVar6);
                                            }
                                            uVar9 = DAT_181ea28c0;
                                            uVar9 = Type.GetTypeFromHandle(uVar9,0);
                                            plVar10 = (int64 *)Resources.Load("GameData/SkinDataBase",uVar9,0);
                                            if (plVar10 != (int64 *)0) {
                                              plVar18 = plVar10;
                                              plVar18 = plVar10;
                                              uVar9 = FUN_180b00cb0(plVar18,0);
                                              var lVar11 = new c.DisplayClass9_0(0);
                                              if (lVar11 != null) {
                                                LTCSVLoader.ReadMultiLine(lVar11,uVar9,0);
                                                iVar6 = LTCSVLoader.GetRow(lVar11,0);
                                                iVar22 = 1;
                                                if (1 < iVar6) {
                                                  do {
                                                    var lVar12 = new SkinDataBase(0);
                                                    uVar9 = LTCSVLoader.GetValueAt(lVar11,0,iVar22,0);
                                                    uVar25 = Int32.Parse(uVar9,0);
                                                    if (lVar12 == null) goto LAB_180bc3e85;
                                                    lVar12._items = uVar25;
                                                    uVar9 = LTCSVLoader.GetValueAt(lVar11,1,iVar22);
                                                    lVar12.Count = uVar9;
                                                    il2cpp_internal((uint64 *)(lVar12 + 24),
                                                                        uVar9);
                                                    uVar9 = LTCSVLoader.GetValueAt(lVar11,2,iVar22);
                                                    uVar9 = GameDataController.StringToSpeAddData
                                                                      (this,uVar9,0);
                                                    *(uint64 *)(lVar12 + 32) = uVar9;
                                                    il2cpp_internal((uint64 *)(lVar12 + 32),
                                                                        uVar9);
                                                    uVar9 = LTCSVLoader.GetValueAt(lVar11,3,iVar22);
                                                    uVar25 = Int32.Parse(uVar9,0);
                                                    *(uint32 *)(lVar12 + 40) = uVar25;
                                                    if (this.skinDataBase == null)
                                                    goto LAB_180bc3e85;
                                                    FUN_18175de30(this.skinDataBase,lVar12,
                                                                  DAT_181e854b0);
                                                    iVar22 = iVar22 + 1;
                                                  } while (iVar22 < iVar6);
                                                }
                                                uVar9 = DAT_181ea28c0;
                                                uVar9 = Type.GetTypeFromHandle(uVar9,0);
                                                plVar10 = (int64 *)
                                                          Resources.Load("GameData/ForceData",uVar9,0);
                                                if (plVar10 != (int64 *)0) {
                                                  plVar18 = plVar10;
                                                  plVar18 = plVar10;
                                                  uVar9 = FUN_180b00cb0(plVar18,0);
                                                  var lVar11 = new c.DisplayClass9_0(0);
                                                  if (lVar11 != null) {
                                                    LTCSVLoader.ReadMultiLine(lVar11,uVar9,0);
                                                    iVar6 = LTCSVLoader.GetRow(lVar11,0);
                                                    uVar9 = il2cpp_internal(DAT_181e60ad0);
                                                    FUN_1806e5bc0(uVar9,DAT_181e9ac40);
                                                    this.forceDataBase = uVar9;
                                                    iVar22 = 1;
                                                    if (1 < iVar6) {
                                                      do {
                                                        var lVar12 = new ForceData(0);
                                                        uVar9 = LTCSVLoader.GetValueAt(lVar11,0,iVar22,0)
                                                        ;
                                                        uVar25 = Int32.Parse(uVar9,0);
                                                        if (lVar12 == null) goto LAB_180bc3e85;
                                                        lVar12._items = uVar25;
                                                        uVar9 = LTCSVLoader.GetValueAt(lVar11,1,iVar22);
                                                        lVar12.Count = uVar9;
                                                        il2cpp_internal((uint64 *)(lVar12 + 24),
                                                                            uVar9);
                                                        uVar9 = LTCSVLoader.GetValueAt(lVar11,2,iVar22);
                                                        *(uint64 *)(lVar12 + 40) = uVar9;
                                                        il2cpp_internal((uint64 *)(lVar12 + 40),
                                                                            uVar9);
                                                        uVar9 = LTCSVLoader.GetValueAt(lVar11,3,iVar22);
                                                        uVar25 = Int32.Parse(uVar9,0);
                                                        *(uint32 *)(lVar12 + 52) = uVar25;
                                                        uVar9 = LTCSVLoader.GetValueAt(lVar11,4,iVar22);
                                                        uVar25 = Int32.Parse(uVar9,0);
                                                        *(uint32 *)(lVar12 + 56) = uVar25;
                                                        uVar9 = LTCSVLoader.GetValueAt(lVar11,5,iVar22);
                                                        *(uint64 *)(lVar12 + 80) = uVar9;
                                                        il2cpp_internal((uint64 *)(lVar12 + 80),
                                                                            uVar9);
                                                        lVar13 = LTCSVLoader.GetValueAt(lVar11,6,iVar22);
                                                        cVar4 = String.op_Inequality
                                                                          (lVar13,"",0);
                                                        if ((cVar4) &&
                                                           (cVar4 = String.op_Inequality
                                                                              (lVar13,"#",0),
                                                           cVar4)) {
                                                          lVar14 = FUN_1801dfd90(DAT_181e81128,1);
                                                          if ((lVar14 == null) ||
                                                             (FUN_180002550(lVar14,0,47), lVar13 == null))
                                                          goto LAB_180bc3e85;
                                                          lVar13 = String.Split(lVar13,lVar14,0);
                                                          iVar24 = 0;
                                                          while( true ) {
                                                            if (lVar13 == null) goto LAB_180bc3e85;
                                                            if (lVar13.entries <= iVar24) break;
                                                            lVar14 = *(int64 *)(lVar12 + 72);
                                                            uVar9 = FUN_180002230(lVar13,(int64)iVar24)
                                                            ;
                                                            uVar25 = Int32.Parse(uVar9,0);
                                                            if (lVar14 == null) goto LAB_180bc3e85;
                                                            FUN_181769fe0(lVar14,uVar25,DAT_181e713f0);
                                                            iVar24 = iVar24 + 1;
                                                          }
                                                        }
                                                        uVar9 = LTCSVLoader.GetValueAt(lVar11,7,iVar22);
                                                        cVar4 = String.op_Inequality
                                                                          (uVar9,"",0);
                                                        if (cVar4) {
                                                          lVar13 = LTCSVLoader.GetValueAt
                                                                             (lVar11,7,iVar22);
                                                          lVar14 = FUN_1801dfd90(DAT_181e81128,1);
                                                          if ((lVar14 == null) ||
                                                             (FUN_180002550(lVar14,0,59), lVar13 == null))
                                                          goto LAB_180bc3e85;
                                                          lVar13 = String.Split(lVar13,lVar14,0);
                                                          iVar24 = 0;
                                                          while( true ) {
                                                            if (lVar13 == null) goto LAB_180bc3e85;
                                                            if (lVar13.entries <= iVar24) break;
                                                            lVar14 = FUN_180002230(lVar13,(int64)iVar24
                                                                                  );
                                                            lVar16 = FUN_1801dfd90(DAT_181e81128,1);
                                                            if ((lVar16 == null) ||
                                                               (FUN_180002550(lVar16,0,45), lVar14 == null)
                                                               ) goto LAB_180bc3e85;
                                                            lVar16 = String.Split(lVar14,lVar16,0);
                                                            lVar14 = *(int64 *)(lVar12 + 0x110);
                                                            if (lVar16 == null) goto LAB_180bc3e85;
                                                            uVar9 = FUN_180002230(lVar16,0);
                                                            uVar25 = Int32.Parse(uVar9,0);
                                                            uVar9 = FUN_180002230(lVar16,1);
                                                            Single.Parse(uVar9,0);
                                                            var uVar9 = new PlotChoiceRequirement(uVar25);
                                                            if (lVar14 == null) goto LAB_180bc3e85;
                                                            FUN_18175de30(lVar14,uVar9,DAT_181e6a578);
                                                            iVar24 = iVar24 + 1;
                                                          }
                                                        }
                                                        uVar9 = LTCSVLoader.GetValueAt(lVar11,8,iVar22);
                                                        uVar25 = Single.Parse(uVar9,0);
                                                        *(uint32 *)(lVar12 + 48) = uVar25;
                                                        lVar13 = LTCSVLoader.GetValueAt(lVar11,9,iVar22);
                                                        lVar14 = FUN_1801dfd90(DAT_181e81128,1);
                                                        if ((lVar14 == null) ||
                                                           (FUN_180002550(lVar14,0,59), lVar13 == null))
                                                        goto LAB_180bc3e85;
                                                        lVar13 = String.Split(lVar13,lVar14,0);
                                                        iVar24 = 0;
                                                        while( true ) {
                                                          if (lVar13 == null) goto LAB_180bc3e85;
                                                          if (lVar13.entries <= iVar24) break;
                                                          lVar14 = *(int64 *)(lVar12 + 240);
                                                          lVar16 = *(int64 *)
                                                                    (pStatics +
                                                                    0x4a8);
                                                          uVar9 = FUN_180002230(lVar13,(int64)iVar24);
                                                          if ((lVar16 == null) ||
                                                             (uVar25 = FUN_181662a20(lVar16,uVar9,
                                                                                     DAT_181e865f0),
                                                             lVar14 == null)) goto LAB_180bc3e85;
                                                          FUN_181769fe0(lVar14,uVar25,DAT_181e713f0);
                                                          iVar24 = iVar24 + 1;
                                                        }
                                                        uVar9 = LTCSVLoader.GetValueAt(lVar11,10,iVar22);
                                                        cVar4 = String.op_Inequality
                                                                          (uVar9,"无",0);
                                                        if (cVar4) {
                                                          lVar13 = LTCSVLoader.GetValueAt
                                                                             (lVar11,10,iVar22);
                                                          lVar14 = FUN_1801dfd90(DAT_181e81128,1);
                                                          if ((lVar14 == null) ||
                                                             (FUN_180002550(lVar14,0,59), lVar13 == null))
                                                          goto LAB_180bc3e85;
                                                          lVar13 = String.Split(lVar13,lVar14,0);
                                                          iVar24 = 0;
                                                          while( true ) {
                                                            if (lVar13 == null) goto LAB_180bc3e85;
                                                            if (lVar13.entries <= iVar24) break;
                                                            lVar14 = *(int64 *)(lVar12 + 248);
                                                            lVar16 = *(int64 *)
                                                                      (pStatics
                                                                      + 0x4b8);
                                                            uVar9 = FUN_180002230(lVar13,(int64)iVar24)
                                                            ;
                                                            if ((lVar16 == null) ||
                                                               (uVar25 = FUN_181662a20(lVar16,uVar9,
                                                                                       DAT_181e865f0),
                                                               lVar14 == null)) goto LAB_180bc3e85;
                                                            FUN_181769fe0(lVar14,uVar25,DAT_181e713f0);
                                                            iVar24 = iVar24 + 1;
                                                          }
                                                        }
                                                        uVar9 = LTCSVLoader.GetValueAt(lVar11,11,iVar22)
                                                        ;
                                                        cVar4 = String.op_Inequality
                                                                          (uVar9,"无",0);
                                                        if (cVar4) {
                                                          lVar13 = LTCSVLoader.GetValueAt
                                                                             (lVar11,11,iVar22);
                                                          lVar14 = FUN_1801dfd90(DAT_181e81128,1);
                                                          if ((lVar14 == null) ||
                                                             (FUN_180002550(lVar14,0,58), lVar13 == null))
                                                          goto LAB_180bc3e85;
                                                          lVar14 = String.Split(lVar13,lVar14,0);
                                                          lVar13 = *(int64 *)(lVar12 + 0x100);
                                                          lVar16 = *(int64 *)
                                                                    (pStatics +
                                                                    0x4d8);
                                                          if (((lVar14 == null) ||
                                                              (uVar9 = FUN_180002230(lVar14,0),
                                                              lVar16 == null)) ||
                                                             (FUN_181662a20(lVar16,uVar9,DAT_181e865f0),
                                                             lVar13 == null)) goto LAB_180bc3e85;
                                                          FUN_181769c70(lVar13,0);
                                                          lVar13 = *(int64 *)(lVar12 + 0x100);
                                                          uVar9 = FUN_180002230(lVar14,1);
                                                          Single.Parse(uVar9,0);
                                                          if (lVar13 == null) goto LAB_180bc3e85;
                                                          FUN_181769c70(lVar13,1);
                                                        }
                                                        uVar9 = LTCSVLoader.GetValueAt(lVar11,12,iVar22)
                                                        ;
                                                        cVar4 = FUN_1816387f0(uVar9,"1",0);
                                                        *(char *)(lVar12 + 36) = cVar4;
                                                        if (cVar4) {
                                                          if (*(int *)(pStatics
                                                                      + 8) != 0) {
                                                            lVar13 = *(int64 *)
                                                                      (pStatics
                                                                      + 32);
                                                            if (lVar13 == null) goto LAB_180bc3e85;
                                                            cVar4 = FUN_18176a2d0(lVar13,*(uint32 *)
                                                                                          (lVar12 + 16),
                                                                                  DAT_181e71570);
                                                            if (!cVar4) goto LAB_180bbdb0f;
                                                          }
                                                          if (this.bigForceIDList == null)
                                                          goto LAB_180bc3e85;
                                                          FUN_181769fe0(this.bigForceIDList,
                                                                        lVar12._items,
                                                                        DAT_181e713f0);
                                                        }
        LAB_180bbdb0f:
                                                        uVar9 = LTCSVLoader.GetValueAt(lVar11,13,iVar22)
                                                        ;
                                                        uVar5 = FUN_1816387f0(uVar9,"1",0);
                                                        *(uint8 *)(lVar12 + 37) = uVar5;
                                                        uVar9 = LTCSVLoader.GetValueAt(lVar11,14,iVar22)
                                                        ;
                                                        uVar25 = Int32.Parse(uVar9,0);
                                                        *(uint32 *)(lVar12 + 32) = uVar25;
                                                        lVar13 = LTCSVLoader.GetValueAt
                                                                           (lVar11,15,iVar22);
                                                        if (lVar13 == null) goto LAB_180bc3e85;
                                                        uVar9 = String.Replace(lVar13,"\\n",
                                                                                "\n",0);
                                                        *(uint64 *)(lVar12 + 0x180) = uVar9;
                                                        il2cpp_internal((uint64 *)(lVar12 + 0x180)
                                                                            ,uVar9);
                                                        if (this.forceDataBase == null)
                                                        goto LAB_180bc3e85;
                                                        FUN_1806da2f0(this.forceDataBase,
                                                                      lVar12._items,
                                                                      lVar12);
                                                        iVar22 = iVar22 + 1;
                                                      } while (iVar22 < iVar6);
                                                    }
                                                    uVar9 = DAT_181ea28c0;
                                                    uVar9 = Type.GetTypeFromHandle(uVar9,0);
                                                    plVar10 = (int64 *)
                                                              Resources.Load("GameData/BuildingData",uVar9,0);
                                                    if (plVar10 != (int64 *)0) {
                                                      plVar18 = plVar10;
                                                      plVar18 = plVar10;
                                                      uVar9 = FUN_180b00cb0(plVar18,0);
                                                      var lVar11 = new c.DisplayClass9_0(0);
                                                      if (lVar11 != null) {
                                                        LTCSVLoader.ReadMultiLine(lVar11,uVar9,0);
                                                        iVar6 = LTCSVLoader.GetRow(lVar11,0);
                                                        uVar9 = il2cpp_internal(DAT_181e6ffb8);
                                                        FUN_1810f3480(uVar9,DAT_181e5a220);
                                                        this.buildingDataBaseTypeIDList = uVar9;
                                                        il2cpp_internal((uint64 *)(this + 232)
                                                                            ,uVar9);
                                                        iVar22 = 0;
                                                        do {
                                                          lVar12 = this.buildingDataBaseTypeIDList;
                                                          uVar9 = il2cpp_internal(DAT_181e73cb8);
                                                          FUN_1810f3480(uVar9,DAT_181e71270);
                                                          if (lVar12 == null) goto LAB_180bc3e85;
                                                          FUN_18175de30(lVar12,uVar9,DAT_181e5a330);
                                                          iVar22 = iVar22 + 1;
                                                        } while (iVar22 < 7);
                                                        uVar9 = il2cpp_internal(DAT_181e60658);
                                                        FUN_1806e5bc0(uVar9,DAT_181e98b68);
                                                        this.buildingDataBase = uVar9;
                                                        lVar12 = il2cpp_internal(DAT_181e77728);
                                                        local_f8 = lVar12;
                                                        FUN_1810f3480(lVar12,DAT_181e861f0);
                                                        if (lVar12 != null) {
                                                          FUN_18175de30(lVar12,"我",DAT_181e86370
                                                                       );
                                                          FUN_18175de30(lVar12,"非我",DAT_181e86370
                                                                       );
                                                          FUN_18175de30(lVar12,"敌",DAT_181e86370
                                                                       );
                                                          FUN_18175de30(lVar12,"有门派",DAT_181e86370
                                                                       );
                                                          FUN_18175de30(lVar12,"无门派",DAT_181e86370
                                                                       );
                                                          FUN_18175de30(lVar12,"附庸",DAT_181e86370
                                                                       );
                                                          FUN_18175de30(lVar12,"未购买",DAT_181e86370
                                                                       );
                                                          FUN_18175de30(lVar12,"门客",DAT_181e86370
                                                                       );
                                                          iVar22 = 1;
                                                          if (1 < iVar6) {
                                                            do {
                                                              var lVar12 = new AreaBuildingDataBase(0);
                                                              uVar9 = LTCSVLoader.GetValueAt
                                                                                (lVar11,0,iVar22,0);
                                                              uVar25 = Int32.Parse(uVar9,0);
                                                              if (lVar12 == null) goto LAB_180bc3e85;
                                                              lVar12._items = uVar25;
                                                              uVar9 = LTCSVLoader.GetValueAt
                                                                                (lVar11,1,iVar22);
                                                              lVar12.Count = uVar9;
                                                              il2cpp_internal((uint64 *)
                                                                                  (lVar12 + 24),uVar9);
                                                              uVar9 = LTCSVLoader.GetValueAt
                                                                                (lVar11,2,iVar22);
                                                              *(uint64 *)(lVar12 + 32) = uVar9;
                                                              il2cpp_internal((uint64 *)
                                                                                  (lVar12 + 32),uVar9);
                                                              uVar9 = LTCSVLoader.GetValueAt
                                                                                (lVar11,3,iVar22);
                                                              uVar25 = Int32.Parse(uVar9,0);
                                                              *(uint32 *)(lVar12 + 48) = uVar25;
                                                              uVar9 = LTCSVLoader.GetValueAt
                                                                                (lVar11,4,iVar22);
                                                              uVar5 = FUN_1816387f0(uVar9,"1",0)
                                                              ;
                                                              *(uint8 *)(lVar12 + 52) = uVar5;
                                                              uVar9 = LTCSVLoader.GetValueAt
                                                                                (lVar11,5,iVar22);
                                                              uVar5 = FUN_1816387f0(uVar9,"1",0)
                                                              ;
                                                              *(uint8 *)(lVar12 + 53) = uVar5;
                                                              uVar9 = LTCSVLoader.GetValueAt
                                                                                (lVar11,6,iVar22);
                                                              uVar25 = Int32.Parse(uVar9,0);
                                                              *(uint32 *)(lVar12 + 56) = uVar25;
                                                              uVar9 = LTCSVLoader.GetValueAt
                                                                                (lVar11,7,iVar22);
                                                              cVar4 = String.op_Inequality
                                                                                (uVar9,"",0);
                                                              if (cVar4) {
                                                                lVar13 = LTCSVLoader.GetValueAt
                                                                                   (lVar11,7,iVar22);
                                                                lVar14 = FUN_1801dfd90(DAT_181e81128,1);
                                                                if ((lVar14 == null) ||
                                                                   (FUN_180002550(lVar14,0,59),
                                                                   lVar13 == null)) goto LAB_180bc3e85;
                                                                lVar13 = String.Split(lVar13,lVar14,0);
                                                                iVar24 = 0;
                                                                while( true ) {
                                                                  if (lVar13 == null) goto LAB_180bc3e85;
                                                                  if (lVar13.entries <= iVar24)
                                                                  break;
                                                                  lVar14 = FUN_180002230(lVar13,(int64)
                                                                                                iVar24);
                                                                  lVar16 = FUN_1801dfd90(DAT_181e81128,1);
                                                                  if ((lVar16 == null) ||
                                                                     (FUN_180002550(lVar16,0,45),
                                                                     lVar14 == null)) goto LAB_180bc3e85;
                                                                  lVar14 = String.Split(lVar14,lVar16,0);
                                                                  lVar16 = il2cpp_internal(
                                                        DAT_181e8c638);
                                                        c__DisplayClass9_0.ctor(lVar16,0);
                                                        if (lVar14 == null) goto LAB_180bc3e85;
                                                        lVar17 = FUN_180002230(lVar14,0);
                                                        lVar20 = FUN_1801dfd90(DAT_181e81128,1);
                                                        if ((((lVar20 == null) ||
                                                             (FUN_180002550(lVar20,0,63), lVar17 == null))
                                                            || (lVar17 = String.Split(lVar17,lVar20,0),
                                                               lVar17 == null)) ||
                                                           (uVar9 = FUN_180002230(lVar17,0), lVar16 == null))
                                                        goto LAB_180bc3e85;
                                                        *(uint64 *)(lVar16 + 16) = uVar9;
                                                        il2cpp_internal((uint64 *)(lVar16 + 16),
                                                                            uVar9);
                                                        if (1 < *(int *)(lVar17 + 24)) {
                                                          uVar9 = FUN_180002230(lVar17,1);
                                                          *(uint64 *)(lVar16 + 24) = uVar9;
                                                          il2cpp_internal((uint64 *)
                                                                              (lVar16 + 24),uVar9);
                                                        }
                                                        if (1 < *(int *)(lVar14 + 24)) {
                                                          uVar9 = FUN_180002230(lVar14,1);
                                                          uVar5 = Enumerable.Contains
                                                                            (uVar9,124,DAT_181e961b8);
                                                          *(uint8 *)(lVar16 + 32) = uVar5;
                                                          lVar17 = FUN_180002230(lVar14,1);
                                                          lVar20 = FUN_1801dfd90(DAT_181e81128,2);
                                                          if (lVar20 == null) goto LAB_180bc3e85;
                                                          FUN_180002550(lVar20,0,38);
                                                          FUN_180002550(lVar20,1,124);
                                                          if (lVar17 == null) goto LAB_180bc3e85;
                                                          lVar17 = String.Split(lVar17,lVar20,0);
                                                          uVar9 = il2cpp_internal(DAT_181e77728);
                                                          FUN_1810f3480(uVar9,DAT_181e861f0);
                                                          *(uint64 *)(lVar16 + 40) = uVar9;
                                                          il2cpp_internal((uint64 *)
                                                                              (lVar16 + 40),uVar9);
                                                          uVar9 = il2cpp_internal(DAT_181e77728);
                                                          FUN_1810f3480(uVar9,DAT_181e861f0);
                                                          *(uint64 *)(lVar16 + 48) = uVar9;
                                                          iVar7 = 0;
                                                          while( true ) {
                                                            if (lVar17 == null) goto LAB_180bc3e85;
                                                            if (*(int *)(lVar17 + 24) <= iVar7) break;
                                                            lVar20 = (int64)iVar7;
                                                            uVar9 = FUN_180002230(lVar17,lVar20);
                                                            cVar4 = FUN_18175e190(local_f8,uVar9,
                                                                                  DAT_181e86470);
                                                            if (!cVar4) {
                                                              lVar21 = FUN_180002230(lVar17,lVar20);
                                                              if (lVar21 == null) goto LAB_180bc3e85;
                                                              cVar4 = String.Contains(lVar21,
                                                        "门派功能",0);
                                                        if (!(cVar4))
                                                        {
                                                          lVar21 = *(int64 *)(lVar16 + 48);
                                                          }
                                                          else {
                                                        }
                                                          lVar21 = *(int64 *)(lVar16 + 40);
                                                        }
                                                        uVar9 = FUN_180002230(lVar17,lVar20);
                                                        if (lVar21 == null) goto LAB_180bc3e85;
                                                        FUN_18175de30(lVar21,uVar9,DAT_181e86370);
                                                        iVar7 = iVar7 + 1;
                                                        }
                                                        }
                                                        if (2 < *(int *)(lVar14 + 24)) {
                                                          uVar9 = FUN_180002230(lVar14,2);
                                                          *(uint64 *)(lVar16 + 56) = uVar9;
                                                          il2cpp_internal((uint64 *)
                                                                              (lVar16 + 56),uVar9);
                                                        }
                                                        if (3 < *(int *)(lVar14 + 24)) {
                                                          uVar9 = FUN_180002230(lVar14,3);
                                                          *(uint64 *)(lVar16 + 64) = uVar9;
                                                          il2cpp_internal((uint64 *)
                                                                              (lVar16 + 64),uVar9);
                                                        }
                                                        if (*(int64 *)(lVar12 + 64) == 0)
                                                        goto LAB_180bc3e85;
                                                        FUN_18175de30(*(int64 *)(lVar12 + 64),lVar16,
                                                                      DAT_181e5dd50);
                                                        iVar24 = iVar24 + 1;
                                                        }
                                                        }
                                                        uVar9 = LTCSVLoader.GetValueAt(lVar11,8,iVar22);
                                                        cVar4 = String.op_Inequality
                                                                          (uVar9,"",0);
                                                        if (cVar4) {
                                                          lVar13 = LTCSVLoader.GetValueAt
                                                                             (lVar11,8,iVar22);
                                                          lVar14 = FUN_1801dfd90(DAT_181e81128);
                                                          if ((lVar14 == null) ||
                                                             (FUN_180002550(lVar14), lVar13 == null))
                                                          goto LAB_180bc3e85;
                                                          lVar14 = String.Split(lVar13,lVar14);
                                                          iVar24 = 0;
                                                          lVar13 = DAT_181e538e8;
                                                          while( true ) {
                                                            if (lVar14 == null) goto LAB_180bc3e85;
                                                            if (*(int *)(lVar14 + 24) <= iVar24) break;
                                                            iVar7 = 0;
                                                            while( true ) {
                                                              if (((*(byte *)(lVar13 + 0x133) & 4) != 0)
                                                                 && (*(int *)(lVar13 + 224) == 0)) {
                                                                il2cpp_runtime_class_init();
                                                                lVar13 = DAT_181e538e8;
                                                              }
                                                              lVar16 = *(int64 *)
                                                                        (plVar13 +
                                                                        0x440);
                                                              if (lVar16 == null) goto LAB_180bc3e85;
                                                              if (*(int *)(lVar16 + 24) <= iVar7) break;
                                                              lVar16 = (int64)iVar24;
                                                              lVar13 = FUN_180002230(lVar14,lVar16);
                                                              if (((*(byte *)(DAT_181e538e8 + 0x133) & 4)
                                                                   != 0) &&
                                                                 (*(int *)(DAT_181e538e8 + 224) == 0)) {
                                                                il2cpp_runtime_class_init();
                                                              }
                                                              lVar17 = *(int64 *)
                                                                        (*(int64 *)
                                                                          (DAT_181e538e8 + 184) + 0x440);
                                                              if ((lVar17 == null) ||
                                                                 (uVar9 = FUN_1800024b0(lVar17,iVar7,
                                                                                        DAT_181e86970),
                                                                 lVar13 == null)) goto LAB_180bc3e85;
                                                              cVar4 = String.Contains(lVar13,uVar9,0);
                                                              if (!cVar4) {
                                                                iVar23 = 0;
                                                                while( true ) {
                                                                  if (((*(byte *)(DAT_181e538e8 + 0x133) &
                                                                       4) != 0) &&
                                                                     (*(int *)(DAT_181e538e8 + 224) == 0)
                                                                     ) {
                                                                    il2cpp_runtime_class_init();
                                                                  }
                                                                  lVar13 = *(int64 *)
                                                                            (*(int64 *)
                                                                              (DAT_181e538e8 + 184) +
                                                                            0x628);
                                                                  if (lVar13 == null) goto LAB_180bc3e85;
                                                                  if (lVar13.entries <= iVar23)
                                                                  break;
                                                                  lVar13 = FUN_180002230(lVar14,lVar16);
                                                                  if (((*(byte *)(DAT_181e538e8 + 0x133) &
                                                                       4) != 0) &&
                                                                     (*(int *)(DAT_181e538e8 + 224) == 0)
                                                                     ) {
                                                                    il2cpp_runtime_class_init();
                                                                  }
                                                                  lVar17 = *(int64 *)
                                                                            (*(int64 *)
                                                                              (DAT_181e538e8 + 184) +
                                                                            0x628);
                                                                  if (lVar17 == null) goto LAB_180bc3e85;
                                                                  uVar9 = FUN_1800024b0(lVar17,iVar23,
                                                                                        DAT_181e86970);
                                                                  uVar9 = String.Concat("全域",
                                                                                         uVar9,0);
                                                                  if (lVar13 == null) goto LAB_180bc3e85;
                                                                  cVar4 = String.Contains(lVar13,uVar9,0)
                                                                  ;
                                                                  if (!cVar4) {
                                                                    lVar13 = FUN_180002230(lVar14,lVar16);
                                                                    if (((*(byte *)(DAT_181e538e8 + 0x133)
                                                                         & 4) != 0) &&
                                                                       (*(int *)(DAT_181e538e8 + 224) ==
                                                                        0)) {
                                                                      il2cpp_runtime_class_init();
                                                                    }
                                                                    lVar17 = *(int64 *)
                                                                              (*(int64 *)
                                                                                (DAT_181e538e8 + 184) +
                                                                              0x628);
                                                                    if ((lVar17 == null) ||
                                                                       (uVar9 = FUN_1800024b0(lVar17,
                                                        iVar23,DAT_181e86970), lVar13 == null))
                                                        goto LAB_180bc3e85;
                                                        cVar4 = String.Contains(lVar13,uVar9,0);
                                                        if (cVar4) {
                                                          lVar13 = *(int64 *)(lVar12 + 96);
                                                          lVar17 = FUN_180002230(lVar14,lVar16);
                                                          lVar20 = *(int64 *)
                                                                    (pStatics +
                                                                    0x628);
                                                          if ((lVar20 != null) &&
                                                             (uVar9 = FUN_1800024b0(lVar20,iVar23,
                                                                                    DAT_181e86970),
                                                             lVar17 != null)) {
                                                            uVar9 = String.Replace(lVar17,uVar9,
                                                                                    "",0);
                                                            Single.Parse(uVar9,0);
                                                            if (lVar13 != null) goto LAB_180bbe786;
                                                          }
                                                          goto LAB_180bc3e85;
                                                        }
                                                        }
                                                        else {
                                                          lVar13 = *(int64 *)(lVar12 + 104);
                                                          lVar17 = FUN_180002230(lVar14,lVar16);
                                                          lVar20 = *(int64 *)
                                                                    (pStatics +
                                                                    0x628);
                                                          if (lVar20 == null) goto LAB_180bc3e85;
                                                          uVar9 = FUN_1800024b0(lVar20,iVar23,
                                                                                DAT_181e86970);
                                                          uVar9 = String.Concat("全域",uVar9,0);
                                                          if (lVar17 == null) goto LAB_180bc3e85;
                                                          uVar9 = String.Replace(lVar17,uVar9,
                                                                                  "",0);
                                                          Single.Parse(uVar9,0);
                                                          if (lVar13 == null) goto LAB_180bc3e85;
        LAB_180bbe786:
                                                          FUN_181769c70(lVar13,iVar23);
                                                        }
                                                        iVar23 = iVar23 + 1;
                                                        }
                                                        }
                                                        else {
                                                          lVar13 = *(int64 *)(lVar12 + 72);
                                                          lVar16 = FUN_180002230(lVar14,lVar16);
                                                          lVar17 = *(int64 *)
                                                                    (pStatics +
                                                                    0x440);
                                                          if ((lVar17 == null) ||
                                                             (uVar9 = FUN_1800024b0(lVar17,iVar7,
                                                                                    DAT_181e86970),
                                                             lVar16 == null)) goto LAB_180bc3e85;
                                                          uVar9 = String.Replace(lVar16,uVar9,
                                                                                  "",0);
                                                          Single.Parse(uVar9,0);
                                                          if (lVar13 == null) goto LAB_180bc3e85;
                                                          FUN_181769c70(lVar13,iVar7);
                                                        }
                                                        iVar7 = iVar7 + 1;
                                                        lVar13 = DAT_181e538e8;
                                                        }
                                                        iVar24 = iVar24 + 1;
                                                        }
                                                        }
                                                        uVar9 = LTCSVLoader.GetValueAt(lVar11,9,iVar22);
                                                        cVar4 = String.op_Inequality
                                                                          (uVar9,"",0);
                                                        if (cVar4) {
                                                          lVar13 = LTCSVLoader.GetValueAt
                                                                             (lVar11,9,iVar22);
                                                          lVar14 = FUN_1801dfd90(DAT_181e81128);
                                                          if ((lVar14 == null) ||
                                                             (FUN_180002550(lVar14), lVar13 == null))
                                                          goto LAB_180bc3e85;
                                                          lVar14 = String.Split(lVar13,lVar14);
                                                          iVar24 = 0;
                                                          lVar13 = DAT_181e538e8;
                                                          while( true ) {
                                                            if (lVar14 == null) goto LAB_180bc3e85;
                                                            if (*(int *)(lVar14 + 24) <= iVar24) break;
                                                            iVar7 = 0;
                                                            while( true ) {
                                                              if (((*(byte *)(lVar13 + 0x133) & 4) != 0)
                                                                 && (*(int *)(lVar13 + 224) == 0)) {
                                                                il2cpp_runtime_class_init();
                                                                lVar13 = DAT_181e538e8;
                                                              }
                                                              lVar16 = *(int64 *)
                                                                        (plVar13 +
                                                                        0x440);
                                                              if (lVar16 == null) goto LAB_180bc3e85;
                                                              if (*(int *)(lVar16 + 24) <= iVar7) break;
                                                              lVar16 = (int64)iVar24;
                                                              lVar13 = FUN_180002230(lVar14,lVar16);
                                                              if (((*(byte *)(DAT_181e538e8 + 0x133) & 4)
                                                                   != 0) &&
                                                                 (*(int *)(DAT_181e538e8 + 224) == 0)) {
                                                                il2cpp_runtime_class_init();
                                                              }
                                                              lVar17 = *(int64 *)
                                                                        (*(int64 *)
                                                                          (DAT_181e538e8 + 184) + 0x440);
                                                              if ((lVar17 == null) ||
                                                                 (uVar9 = FUN_1800024b0(lVar17,iVar7,
                                                                                        DAT_181e86970),
                                                                 lVar13 == null)) goto LAB_180bc3e85;
                                                              cVar4 = String.Contains(lVar13,uVar9,0);
                                                              if (!cVar4) {
                                                                iVar23 = 0;
                                                                while( true ) {
                                                                  if (((*(byte *)(DAT_181e538e8 + 0x133) &
                                                                       4) != 0) &&
                                                                     (*(int *)(DAT_181e538e8 + 224) == 0)
                                                                     ) {
                                                                    il2cpp_runtime_class_init();
                                                                  }
                                                                  lVar13 = *(int64 *)
                                                                            (*(int64 *)
                                                                              (DAT_181e538e8 + 184) +
                                                                            0x628);
                                                                  if (lVar13 == null) goto LAB_180bc3e85;
                                                                  if (lVar13.entries <= iVar23)
                                                                  break;
                                                                  lVar13 = FUN_180002230(lVar14,lVar16);
                                                                  if (((*(byte *)(DAT_181e538e8 + 0x133) &
                                                                       4) != 0) &&
                                                                     (*(int *)(DAT_181e538e8 + 224) == 0)
                                                                     ) {
                                                                    il2cpp_runtime_class_init();
                                                                  }
                                                                  lVar17 = *(int64 *)
                                                                            (*(int64 *)
                                                                              (DAT_181e538e8 + 184) +
                                                                            0x628);
                                                                  if (lVar17 == null) goto LAB_180bc3e85;
                                                                  uVar9 = FUN_1800024b0(lVar17,iVar23,
                                                                                        DAT_181e86970);
                                                                  uVar9 = String.Concat("全域",
                                                                                         uVar9,0);
                                                                  if (lVar13 == null) goto LAB_180bc3e85;
                                                                  cVar4 = String.Contains(lVar13,uVar9,0)
                                                                  ;
                                                                  if (!cVar4) {
                                                                    lVar13 = FUN_180002230(lVar14,lVar16);
                                                                    if (((*(byte *)(DAT_181e538e8 + 0x133)
                                                                         & 4) != 0) &&
                                                                       (*(int *)(DAT_181e538e8 + 224) ==
                                                                        0)) {
                                                                      il2cpp_runtime_class_init();
                                                                    }
                                                                    lVar17 = *(int64 *)
                                                                              (*(int64 *)
                                                                                (DAT_181e538e8 + 184) +
                                                                              0x628);
                                                                    if ((lVar17 == null) ||
                                                                       (uVar9 = FUN_1800024b0(lVar17,
                                                        iVar23,DAT_181e86970), lVar13 == null))
                                                        goto LAB_180bc3e85;
                                                        cVar4 = String.Contains(lVar13,uVar9,0);
                                                        if (cVar4) {
                                                          lVar13 = *(int64 *)(lVar12 + 96);
                                                          lVar17 = FUN_180002230(lVar14,lVar16);
                                                          lVar20 = *(int64 *)
                                                                    (pStatics +
                                                                    0x628);
                                                          if ((lVar20 != null) &&
                                                             (uVar9 = FUN_1800024b0(lVar20,iVar23,
                                                                                    DAT_181e86970),
                                                             lVar17 != null)) {
                                                            uVar9 = String.Replace(lVar17,uVar9,
                                                                                    "",0);
                                                            Single.Parse(uVar9,0);
                                                            if (lVar13 != null) goto LAB_180bbec66;
                                                          }
                                                          goto LAB_180bc3e85;
                                                        }
                                                        }
                                                        else {
                                                          lVar13 = *(int64 *)(lVar12 + 104);
                                                          lVar17 = FUN_180002230(lVar14,lVar16);
                                                          lVar20 = *(int64 *)
                                                                    (pStatics +
                                                                    0x628);
                                                          if (lVar20 == null) goto LAB_180bc3e85;
                                                          uVar9 = FUN_1800024b0(lVar20,iVar23,
                                                                                DAT_181e86970);
                                                          uVar9 = String.Concat("全域",uVar9,0);
                                                          if (lVar17 == null) goto LAB_180bc3e85;
                                                          uVar9 = String.Replace(lVar17,uVar9,
                                                                                  "",0);
                                                          Single.Parse(uVar9,0);
                                                          if (lVar13 == null) goto LAB_180bc3e85;
        LAB_180bbec66:
                                                          FUN_181769c70(lVar13,iVar23);
                                                        }
                                                        iVar23 = iVar23 + 1;
                                                        }
                                                        }
                                                        else {
                                                          lVar13 = *(int64 *)(lVar12 + 72);
                                                          lVar16 = FUN_180002230(lVar14,lVar16);
                                                          lVar17 = *(int64 *)
                                                                    (pStatics +
                                                                    0x440);
                                                          if ((lVar17 == null) ||
                                                             (uVar9 = FUN_1800024b0(lVar17,iVar7,
                                                                                    DAT_181e86970),
                                                             lVar16 == null)) goto LAB_180bc3e85;
                                                          uVar9 = String.Replace(lVar16,uVar9,
                                                                                  "",0);
                                                          Single.Parse(uVar9,0);
                                                          if (lVar13 == null) goto LAB_180bc3e85;
                                                          FUN_181769c70(lVar13,iVar7);
                                                        }
                                                        iVar7 = iVar7 + 1;
                                                        lVar13 = DAT_181e538e8;
                                                        }
                                                        iVar24 = iVar24 + 1;
                                                        }
                                                        }
                                                        uVar9 = LTCSVLoader.GetValueAt(lVar11,10,iVar22);
                                                        cVar4 = String.op_Inequality
                                                                          (uVar9,"",0);
                                                        if (cVar4) {
                                                          lVar13 = LTCSVLoader.GetValueAt
                                                                             (lVar11,10,iVar22);
                                                          lVar14 = FUN_1801dfd90(DAT_181e81128,1);
                                                          if ((lVar14 == null) ||
                                                             (FUN_180002550(lVar14,0,59), lVar13 == null))
                                                          goto LAB_180bc3e85;
                                                          lVar13 = String.Split(lVar13,lVar14,0);
                                                          iVar24 = 0;
                                                          while( true ) {
                                                            if (lVar13 == null) goto LAB_180bc3e85;
                                                            if (lVar13.entries <= iVar24) break;
                                                            lVar14 = FUN_180002230(lVar13,(int64)iVar24
                                                                                  );
                                                            if (lVar14 == null) goto LAB_180bc3e85;
                                                            cVar4 = String.Contains(lVar14,"人口上限",
                                                                                     0);
                                                            if (!cVar4) {
                                                              iVar7 = 0;
                                                              while( true ) {
                                                                if (this.forceSpeAddDataBase == null)
                                                                goto LAB_180bc3e85;
                                                                if (*(int *)(this.forceSpeAddDataBase
                                                                            + 24) <= iVar7) break;
                                                                uVar9 = FUN_180002230(lVar13,(int64)
                                                                                             iVar24);
                                                                if (((*(byte *)(DAT_181e538e8 + 0x133) & 4
                                                                     ) != 0) &&
                                                                   (*(int *)(DAT_181e538e8 + 224) == 0))
                                                                {
                                                                  il2cpp_runtime_class_init();
                                                                }
                                                                uVar9 = GlobalData.GetChinese(uVar9,0);
                                                                if ((this.forceSpeAddDataBase == null)
                                                                   || (lVar14 = FUN_1800024b0(*(int64 *
                                                                                               )(this +
                                                                                                152),
                                                        iVar7), lVar14 == null)) goto LAB_180bc3e85;
                                                        cVar4 = FUN_1816387f0(uVar9,*(uint64 *)
                                                                                     (lVar14 + 16));
                                                        if (cVar4) {
                                                          lVar14 = *(int64 *)(lVar12 + 128);
                                                          lVar16 = FUN_180002230(lVar13,(int64)iVar24);
                                                          if (((this.forceSpeAddDataBase == null) ||
                                                              (lVar17 = FUN_1800024b0(*(int64 *)
                                                                                       (this + 152),
                                                                                      iVar7,DAT_181e6abf8)
                                                              , lVar17 == null)) || (lVar16 == null))
                                                          goto LAB_180bc3e85;
                                                          uVar9 = String.Replace(lVar16,*(uint64 *)
                                                                                          (lVar17 + 16))
                                                          ;
                                                          Single.Parse(uVar9,0);
                                                          if (lVar14 == null) goto LAB_180bc3e85;
                                                          ForceSpeAddData.Set(lVar14,iVar7);
                                                        }
                                                        iVar7 = iVar7 + 1;
                                                        }
                                                        }
                                                        else {
                                                          lVar14 = FUN_180002230(lVar13,(int64)iVar24);
                                                          if (lVar14 == null) goto LAB_180bc3e85;
                                                          uVar9 = String.Replace(lVar14,"人口上限");
                                                          uVar25 = Single.Parse(uVar9,0);
                                                          *(uint32 *)(lVar12 + 92) = uVar25;
                                                        }
                                                        iVar24 = iVar24 + 1;
                                                        }
                                                        }
                                                        uVar9 = LTCSVLoader.GetValueAt(lVar11,11,iVar22)
                                                        ;
                                                        cVar4 = String.op_Inequality
                                                                          (uVar9,"",0);
                                                        if (cVar4) {
                                                          lVar13 = LTCSVLoader.GetValueAt
                                                                             (lVar11,11,iVar22);
                                                          lVar14 = FUN_1801dfd90(DAT_181e81128,1);
                                                          if ((lVar14 == null) ||
                                                             (FUN_180002550(lVar14,0,59), lVar13 == null))
                                                          goto LAB_180bc3e85;
                                                          lVar13 = String.Split(lVar13,lVar14,0);
                                                          iVar24 = 0;
                                                          while( true ) {
                                                            if (lVar13 == null) goto LAB_180bc3e85;
                                                            if (lVar13.entries <= iVar24) break;
                                                            lVar14 = FUN_180002230(lVar13,(int64)iVar24
                                                                                  );
                                                            lVar16 = FUN_1801dfd90(DAT_181e81128,1);
                                                            if ((lVar16 == null) ||
                                                               (FUN_180002550(lVar16,0,45), lVar14 == null)
                                                               ) goto LAB_180bc3e85;
                                                            lVar16 = String.Split(lVar14,lVar16,0);
                                                            lVar14 = *(int64 *)(lVar12 + 112);
                                                            if (lVar16 == null) goto LAB_180bc3e85;
                                                            uVar9 = FUN_180002230(lVar16,0);
                                                            uVar15 = FUN_180002230(lVar16,1);
                                                            Single.Parse(uVar15,0);
                                                            var uVar15 = new AreaBuildingRateChange(uVar9);
                                                            if (lVar14 == null) goto LAB_180bc3e85;
                                                            FUN_18175de30(lVar14,uVar15,DAT_181e5e2a0);
                                                            iVar24 = iVar24 + 1;
                                                          }
                                                        }
                                                        uVar9 = LTCSVLoader.GetValueAt(lVar11,12,iVar22)
                                                        ;
                                                        cVar4 = String.op_Inequality
                                                                          (uVar9,"",0);
                                                        if (cVar4) {
                                                          lVar13 = LTCSVLoader.GetValueAt
                                                                             (lVar11,12,iVar22);
                                                          lVar14 = FUN_1801dfd90(DAT_181e81128,1);
                                                          if ((lVar14 == null) ||
                                                             (FUN_180002550(lVar14,0,59), lVar13 == null))
                                                          goto LAB_180bc3e85;
                                                          lVar14 = String.Split(lVar13,lVar14,0);
                                                          iVar24 = 0;
                                                          lVar13 = DAT_181e538e8;
                                                          while( true ) {
                                                            if (lVar14 == null) goto LAB_180bc3e85;
                                                            if (*(int *)(lVar14 + 24) <= iVar24) break;
                                                            iVar7 = 0;
                                                            while( true ) {
                                                              if (((*(byte *)(lVar13 + 0x133) & 4) != 0)
                                                                 && (*(int *)(lVar13 + 224) == 0)) {
                                                                il2cpp_runtime_class_init();
                                                                lVar13 = DAT_181e538e8;
                                                              }
                                                              lVar16 = *(int64 *)
                                                                        (plVar13 +
                                                                        0x440);
                                                              if (lVar16 == null) goto LAB_180bc3e85;
                                                              if (*(int *)(lVar16 + 24) <= iVar7) break;
                                                              lVar13 = FUN_180002230(lVar14,(int64)
                                                                                            iVar24);
                                                              if (((*(byte *)(DAT_181e538e8 + 0x133) & 4)
                                                                   != 0) &&
                                                                 (*(int *)(DAT_181e538e8 + 224) == 0)) {
                                                                il2cpp_runtime_class_init();
                                                              }
                                                              lVar16 = *(int64 *)
                                                                        (*(int64 *)
                                                                          (DAT_181e538e8 + 184) + 0x440);
                                                              if ((lVar16 == null) ||
                                                                 (uVar9 = FUN_1800024b0(lVar16,iVar7,
                                                                                        DAT_181e86970),
                                                                 lVar13 == null)) goto LAB_180bc3e85;
                                                              cVar4 = String.Contains(lVar13,uVar9,0);
                                                              if (cVar4) {
                                                                lVar13 = *(int64 *)(lVar12 + 80);
                                                                lVar16 = FUN_180002230(lVar14,(int64)
                                                                                              iVar24);
                                                                if (((*(byte *)(DAT_181e538e8 + 0x133) & 4
                                                                     ) != 0) &&
                                                                   (*(int *)(DAT_181e538e8 + 224) == 0))
                                                                {
                                                                  il2cpp_runtime_class_init();
                                                                }
                                                                lVar17 = *(int64 *)
                                                                          (*(int64 *)
                                                                            (DAT_181e538e8 + 184) + 0x440
                                                                          );
                                                                if ((lVar17 == null) ||
                                                                   (uVar9 = FUN_1800024b0(lVar17,iVar7,
                                                                                          DAT_181e86970),
                                                                   lVar16 == null)) goto LAB_180bc3e85;
                                                                uVar9 = String.Replace(lVar16,uVar9,
                                                                                        "",0);
                                                                Single.Parse(uVar9,0);
                                                                if (lVar13 == null) goto LAB_180bc3e85;
                                                                FUN_181769c70(lVar13,iVar7);
                                                              }
                                                              iVar7 = iVar7 + 1;
                                                              lVar13 = DAT_181e538e8;
                                                            }
                                                            iVar24 = iVar24 + 1;
                                                          }
                                                        }
                                                        uVar9 = LTCSVLoader.GetValueAt(lVar11,13,iVar22)
                                                        ;
                                                        uVar25 = Single.Parse(uVar9,0);
                                                        *(uint32 *)(lVar12 + 88) = uVar25;
                                                        uVar9 = LTCSVLoader.GetValueAt(lVar11,14,iVar22)
                                                        ;
                                                        uVar25 = Int32.Parse(uVar9,0);
                                                        *(uint32 *)(lVar12 + 120) = uVar25;
                                                        lVar13 = LTCSVLoader.GetValueAt
                                                                           (lVar11,15,iVar22);
                                                        if (lVar13 == null) {
        LAB_180bbf40e:
                                                          *(uint64 *)(lVar12 + 136) = 0;
                                                          uVar9 = 0;
                                                        }
                                                        else {
                                                          uVar9 = LTCSVLoader.GetValueAt
                                                                            (lVar11,15,iVar22);
                                                          cVar4 = String.op_Inequality
                                                                            (uVar9,"",0);
                                                          if (!cVar4) goto LAB_180bbf40e;
                                                          uVar15 = LTCSVLoader.GetValueAt
                                                                             (lVar11,15,iVar22);
                                                          var uVar9 = new AreaBuildingShopData(uVar15,0);
                                                          *(uint64 *)(lVar12 + 136) = uVar9;
                                                        }
                                                        il2cpp_internal(lVar12 + 136,uVar9);
                                                        uVar9 = LTCSVLoader.GetValueAt
                                                                          (lVar11,16,iVar22);
                                                        uVar25 = Int32.Parse(uVar9,0);
                                                        *(uint32 *)(lVar12 + 144) = uVar25;
                                                        uVar9 = LTCSVLoader.GetValueAt
                                                                          (lVar11,17,iVar22);
                                                        *(uint64 *)(lVar12 + 152) = uVar9;
                                                        il2cpp_internal((uint64 *)(lVar12 + 152),
                                                                            uVar9);
                                                        lVar13 = LTCSVLoader.GetValueAt
                                                                           (lVar11,18,iVar22);
                                                        lVar14 = FUN_1801dfd90(DAT_181e81128,1);
                                                        if (((lVar14 == null) ||
                                                            (FUN_180002550(lVar14,0,59), lVar13 == null))
                                                           || (lVar13 = String.Split(lVar13,lVar14,0),
                                                              lVar13 == null)) goto LAB_180bc3e85;
                                                        uVar9 = FUN_180002230(lVar13,0);
                                                        uVar5 = FUN_1816387f0(uVar9,"1",0);
                                                        *(uint8 *)(lVar12 + 160) = uVar5;
                                                        uVar9 = FUN_180002230(lVar13,1);
                                                        uVar5 = FUN_1816387f0(uVar9,"1",0);
                                                        *(uint8 *)(lVar12 + 161) = uVar5;
                                                        uVar9 = LTCSVLoader.GetValueAt
                                                                          (lVar11,19,iVar22,0);
                                                        *(uint64 *)(lVar12 + 40) = uVar9;
                                                        il2cpp_internal((uint64 *)(lVar12 + 40),
                                                                            uVar9);
                                                        if ((this.buildingDataBaseTypeIDList == null) ||
                                                           (lVar13 = FUN_1800024b0(*(int64 *)
                                                                                    (this + 232),
                                                                                   *(uint32 *)
                                                                                    (lVar12 + 48),
                                                                                   DAT_181e5a4c8),
                                                           lVar13 == null)) goto LAB_180bc3e85;
                                                        FUN_181769fe0(lVar13,*(uint32 *)
                                                                              (lVar12 + 16),
                                                                      DAT_181e713f0);
                                                        if (this.buildingDataBase == null)
                                                        goto LAB_180bc3e85;
                                                        FUN_1806da2f0(this.buildingDataBase,
                                                                      lVar12._items,
                                                                      lVar12);
                                                        iVar22 = iVar22 + 1;
                                                        } while (iVar22 < iVar6);
                                                        }
                                                        uVar9 = DAT_181ea28c0;
                                                        uVar9 = Type.GetTypeFromHandle(uVar9,0);
                                                        plVar10 = (int64 *)
                                                                  Resources.Load("GameData/WeaponData",uVar9,0);
                                                        if (plVar10 != (int64 *)0) {
                                                          plVar18 = plVar10;
                                                          plVar18 = plVar10;
                                                          uVar9 = FUN_180b00cb0(plVar18,0);
                                                          var lVar11 = new c.DisplayClass9_0(0);
                                                          if (lVar11 != null) {
                                                            LTCSVLoader.ReadMultiLine(lVar11,uVar9,0);
                                                            iVar6 = LTCSVLoader.GetRow(lVar11,0);
                                                            uVar9 = il2cpp_internal(DAT_181e60ed0);
                                                            FUN_1806e5bc0(uVar9,DAT_181e9d618);
                                                            this.weaponDataBase = uVar9;
                                                            uVar9 = il2cpp_internal(DAT_181e61448);
                                                            FUN_1806e5bc0(uVar9,DAT_181e9fe60);
                                                            this.weaponSingleNameDataBase = uVar9;
                                                            iVar22 = LTCSVLoader.GetCol(lVar11,0);
                                                            iVar24 = 1;
                                                            if (1 < iVar6) {
                                                              do {
                                                                lVar12 = il2cpp_internal(DAT_181e62470
                                                                                            );
                                                                ItemData.ctor(lVar12,0,0);
                                                                uVar9 = LTCSVLoader.GetValueAt
                                                                                  (lVar11,0,iVar24,0);
                                                                uVar25 = Int32.Parse(uVar9,0);
                                                                if (lVar12 == null) goto LAB_180bc3e85;
                                                                lVar12._items = uVar25;
                                                                uVar9 = LTCSVLoader.GetValueAt
                                                                                  (lVar11,1,iVar24);
                                                                *(uint64 *)(lVar12 + 32) = uVar9;
                                                                il2cpp_internal((uint64 *)
                                                                                    (lVar12 + 32),uVar9)
                                                                ;
                                                                lVar13 = *(int64 *)(lVar12 + 96);
                                                                uVar9 = LTCSVLoader.GetValueAt
                                                                                  (lVar11,2,iVar24);
                                                                uVar25 = Int32.Parse(uVar9,0);
                                                                if (lVar13 == null) goto LAB_180bc3e85;
                                                                *(uint32 *)(lVar13 + 20) = uVar25;
                                                                lVar13 = *(int64 *)(lVar12 + 96);
                                                                uVar9 = LTCSVLoader.GetValueAt
                                                                                  (lVar11,3,iVar24);
                                                                uVar25 = Int32.Parse(uVar9,0);
                                                                if (lVar13 == null) goto LAB_180bc3e85;
                                                                lVar13.entries = uVar25;
                                                                lVar13 = *(int64 *)(lVar12 + 96);
                                                                if ((lVar13 == null) ||
                                                                   (lVar13.count == null))
                                                                goto LAB_180bc3e85;
                                                                HeroSpeAddData.Set(*(int64 *)
                                                                                     (lVar13 + 32),
                                                                                    *(uint32 *)
                                                                                     (lVar13 + 24));
                                                                lVar13 = *(int64 *)(lVar12 + 96);
                                                                uVar9 = LTCSVLoader.GetValueAt
                                                                                  (lVar11,4,iVar24);
                                                                if (lVar13 == null) goto LAB_180bc3e85;
                                                                puVar1 = (uint64 *)(lVar13 + 56);
                                                                *puVar1 = uVar9;
                                                                il2cpp_internal(puVar1,uVar9);
                                                                lVar13 = *(int64 *)(lVar12 + 96);
                                                                if (lVar13 == null) goto LAB_180bc3e85;
                                                                if (lVar13.count == null)
                                                                goto LAB_180bc3e85;
                                                                HeroSpeAddData.Set(*(int64 *)
                                                                                     (lVar13 + 32),
                                                                                    *(int *)(lVar13 + 20
                                                                                            ) + 9);
                                                                lVar13 = *(int64 *)(lVar12 + 96);
                                                                if (lVar13 == null) goto LAB_180bc3e85;
                                                                if (lVar13.count == null)
                                                                goto LAB_180bc3e85;
                                                                HeroSpeAddData.Set(*(int64 *)
                                                                                     (lVar13 + 32),
                                                                                    *(int *)(lVar13 + 20
                                                                                            ) + 18);
                                                                if ((this.weaponDataBase == null)
                                                                   || (FUN_1806da2f0(*(int64 *)
                                                                                      (this + 240),
                                                                                     *(uint32 *)
                                                                                      (lVar12 + 16),
                                                                                     lVar12,DAT_181e9d6a0)
                                                                      , *(int64 *)(lVar12 + 96) == 0)
                                                                   ) goto LAB_180bc3e85;
                                                                uVar9 = "";
                                                                if (5 < iVar22) {
                                                                  uVar9 = LTCSVLoader.GetValueAt
                                                                                    (lVar11,5,iVar24);
                                                                }
                                                                lVar12 = this.weaponSingleNameDataBase;
                                                                FUN_180ad1200(uVar9,0);
                                                                if (lVar12 == null) goto LAB_180bc3e85;
                                                                FUN_1806e7630(lVar12);
                                                                iVar24 = iVar24 + 1;
                                                              } while (iVar24 < iVar6);
                                                            }
                                                            uVar9 = DAT_181ea28c0;
                                                            uVar9 = Type.GetTypeFromHandle(uVar9,0);
                                                            uVar9 = Resources.Load("GameData/ArmorData",uVar9,0)
                                                            ;
                                                            lVar11 = FUN_180002180(uVar9,DAT_181e8af68);
                                                            if (lVar11 != null) {
                                                              uVar9 = FUN_180002180(uVar9,DAT_181e8af68);
                                                              uVar9 = FUN_180b00cb0(uVar9,0);
                                                              var lVar11 = new c.DisplayClass9_0(0);
                                                              if (lVar11 != null) {
                                                                LTCSVLoader.ReadMultiLine(lVar11,uVar9,0)
                                                                ;
                                                                iVar6 = LTCSVLoader.GetRow(lVar11,0);
                                                                lVar12 = il2cpp_internal(DAT_181e60ed0
                                                                                            );
                                                                FUN_1806e5bc0(lVar12,DAT_181e9d618);
                                                                this.armorDataBase = lVar12;
                                                                lVar12 = il2cpp_internal(DAT_181e60ed0
                                                                                            );
                                                                FUN_1806e5bc0(lVar12,DAT_181e9d618);
                                                                this.helmetDataBase = lVar12;
                                                                lVar12 = il2cpp_internal(DAT_181e60ed0
                                                                                            );
                                                                FUN_1806e5bc0(lVar12,DAT_181e9d618);
                                                                this.shoesDataBase = lVar12;
                                                                uVar9 = il2cpp_internal(DAT_181e61448)
                                                                ;
                                                                FUN_1806e5bc0(uVar9,DAT_181e9fe60);
                                                                this.equipmentSingleNameDataBase = uVar9;
                                                                il2cpp_internal(this + 0x118,uVar9)
                                                                ;
                                                                iVar22 = LTCSVLoader.GetCol(lVar11,0);
                                                                iVar24 = 1;
                                                                if (1 < iVar6) {
                                                                  do {
                                                                    lVar12 = il2cpp_internal(
                                                        DAT_181e62470);
                                                        ItemData.ctor(lVar12,0,0);
                                                        uVar9 = LTCSVLoader.GetValueAt(lVar11,0,iVar24,0)
                                                        ;
                                                        uVar25 = Int32.Parse(uVar9,0);
                                                        if (lVar12 == null) goto LAB_180bc3e85;
                                                        lVar12._items = uVar25;
                                                        uVar9 = LTCSVLoader.GetValueAt(lVar11,1,iVar24);
                                                        *(uint64 *)(lVar12 + 32) = uVar9;
                                                        il2cpp_internal((uint64 *)(lVar12 + 32),
                                                                            uVar9);
                                                        uVar9 = LTCSVLoader.GetValueAt(lVar11,2,iVar24);
                                                        uVar25 = Int32.Parse(uVar9,0);
                                                        lVar12.Count = uVar25;
                                                        if (*(int64 *)(lVar12 + 96) == 0)
                                                        goto LAB_180bc3e85;
                                                        lVar13 = *(int64 *)
                                                                  (*(int64 *)(lVar12 + 96) + 32);
                                                        uVar9 = LTCSVLoader.GetValueAt(lVar11,3,iVar24);
                                                        Single.Parse(uVar9,0);
                                                        if (lVar13 == null) goto LAB_180bc3e85;
                                                        HeroSpeAddData.Set(lVar13,61);
                                                        if (*(int64 *)(lVar12 + 96) == 0)
                                                        goto LAB_180bc3e85;
                                                        lVar13 = *(int64 *)
                                                                  (*(int64 *)(lVar12 + 96) + 32);
                                                        uVar9 = LTCSVLoader.GetValueAt(lVar11,4,iVar24);
                                                        Single.Parse(uVar9,0);
                                                        if (lVar13 == null) goto LAB_180bc3e85;
                                                        HeroSpeAddData.Set(lVar13,7);
                                                        lVar13 = *(int64 *)(lVar12 + 96);
                                                        uVar9 = LTCSVLoader.GetValueAt(lVar11,5,iVar24);
                                                        uVar25 = Int32.Parse(uVar9,0);
                                                        if (lVar13 == null) goto LAB_180bc3e85;
                                                        *(uint32 *)(lVar13 + 20) = uVar25;
                                                        iVar7 = lVar12.Count;
                                                        if (iVar7 == 1) {
                                                          lVar13 = *plVar10;
        LAB_180bbfc91:
                                                          if (lVar13 == null) goto LAB_180bc3e85;
                                                          FUN_1806da2f0(lVar13,*(uint32 *)
                                                                                (lVar12 + 16),lVar12,
                                                                        DAT_181e9d6a0);
                                                        }
                                                        else {
                                                          if (iVar7 == 2) {
                                                            lVar13 = *plVar18;
                                                            goto LAB_180bbfc91;
                                                          }
                                                          if (iVar7 == 3) {
                                                            lVar13 = *plVar2;
                                                            goto LAB_180bbfc91;
                                                          }
                                                        }
                                                        if (*(int64 *)(lVar12 + 96) == 0)
                                                        goto LAB_180bc3e85;
                                                        uVar9 = "";
                                                        if (6 < iVar22) {
                                                          uVar9 = LTCSVLoader.GetValueAt(lVar11,6,iVar24)
                                                          ;
                                                        }
                                                        lVar12 = this.equipmentSingleNameDataBase;
                                                        FUN_180ad1200(uVar9,0);
                                                        if (lVar12 == null) goto LAB_180bc3e85;
                                                        FUN_1806e7630(lVar12);
                                                        iVar24 = iVar24 + 1;
                                                        } while (iVar24 < iVar6);
                                                        }
                                                        uVar9 = DAT_181ea28c0;
                                                        uVar9 = Type.GetTypeFromHandle(uVar9,0);
                                                        uVar9 = Resources.Load("GameData/MedData",uVar9,0);
                                                        lVar11 = FUN_180002180(uVar9,DAT_181e8af68);
                                                        if (lVar11 != null) {
                                                          uVar9 = FUN_180002180(uVar9,DAT_181e8af68);
                                                          uVar9 = FUN_180b00cb0(uVar9,0);
                                                          var lVar11 = new c.DisplayClass9_0(0);
                                                          if (lVar11 != null) {
                                                            LTCSVLoader.ReadMultiLine(lVar11,uVar9,0);
                                                            iVar6 = LTCSVLoader.GetRow(lVar11,0);
                                                            uVar9 = il2cpp_internal(DAT_181e60ed0);
                                                            FUN_1806e5bc0(uVar9,DAT_181e9d618);
                                                            this.medDataBase = uVar9;
                                                            iVar22 = 1;
                                                            if (1 < iVar6) {
                                                              do {
                                                                lVar12 = il2cpp_internal(DAT_181e62470
                                                                                            );
                                                                ItemData.ctor(lVar12,1);
                                                                GameDataController.LoadMedFoodData
                                                                          (this,lVar12,lVar11,iVar22,0)
                                                                ;
                                                                if ((lVar12 == null) ||
                                                                   (this.medDataBase == null))
                                                                goto LAB_180bc3e85;
                                                                FUN_1806da2f0(*(int64 *)
                                                                               (this + 0x120),
                                                                              *(uint32 *)
                                                                               (lVar12 + 16),lVar12,
                                                                              DAT_181e9d6a0);
                                                                iVar22 = iVar22 + 1;
                                                              } while (iVar22 < iVar6);
                                                            }
                                                            uVar9 = DAT_181ea28c0;
                                                            uVar9 = Type.GetTypeFromHandle(uVar9,0);
                                                            uVar9 = Resources.Load("GameData/FoodData",uVar9,0)
                                                            ;
                                                            lVar11 = FUN_180002180(uVar9,DAT_181e8af68);
                                                            if (lVar11 != null) {
                                                              uVar9 = FUN_180002180(uVar9,DAT_181e8af68);
                                                              uVar9 = FUN_180b00cb0(uVar9,0);
                                                              var lVar11 = new c.DisplayClass9_0(0);
                                                              if (lVar11 != null) {
                                                                LTCSVLoader.ReadMultiLine(lVar11,uVar9,0)
                                                                ;
                                                                iVar6 = LTCSVLoader.GetRow(lVar11,0);
                                                                uVar9 = il2cpp_internal(DAT_181e60ed0)
                                                                ;
                                                                FUN_1806e5bc0(uVar9,DAT_181e9d618);
                                                                this.foodDataBase = uVar9;
                                                                il2cpp_internal(this + 0x128,uVar9)
                                                                ;
                                                                iVar22 = 1;
                                                                if (1 < iVar6) {
                                                                  do {
                                                                    lVar12 = il2cpp_internal(
                                                        DAT_181e62470);
                                                        ItemData.ctor(lVar12,2);
                                                        GameDataController.LoadMedFoodData
                                                                  (this,lVar12,lVar11,iVar22,0);
                                                        uVar9 = LTCSVLoader.GetValueAt(lVar11,14,iVar22)
                                                        ;
                                                        uVar25 = Int32.Parse(uVar9,0);
                                                        if (lVar12 == null) goto LAB_180bc3e85;
                                                        lVar12.Count = uVar25;
                                                        if (this.foodDataBase == null)
                                                        goto LAB_180bc3e85;
                                                        FUN_1806da2f0(this.foodDataBase,
                                                                      lVar12._items,
                                                                      lVar12,DAT_181e9d6a0);
                                                        iVar22 = iVar22 + 1;
                                                        } while (iVar22 < iVar6);
                                                        }
                                                        uVar9 = DAT_181ea28c0;
                                                        uVar9 = Type.GetTypeFromHandle(uVar9,0);
                                                        uVar9 = Resources.Load("GameData/HorseData",uVar9,0);
                                                        lVar11 = FUN_180002180(uVar9,DAT_181e8af68);
                                                        if (lVar11 != null) {
                                                          uVar9 = FUN_180002180(uVar9,DAT_181e8af68);
                                                          uVar9 = FUN_180b00cb0(uVar9,0);
                                                          var lVar11 = new c.DisplayClass9_0(0);
                                                          if (lVar11 != null) {
                                                            LTCSVLoader.ReadMultiLine(lVar11,uVar9,0);
                                                            iVar6 = LTCSVLoader.GetRow(lVar11,0);
                                                            uVar9 = il2cpp_internal(DAT_181e60ed0);
                                                            FUN_1806e5bc0(uVar9,DAT_181e9d618);
                                                            this.horseDataBase = uVar9;
                                                            iVar22 = 1;
                                                            if (1 < iVar6) {
                                                              do {
                                                                lVar12 = il2cpp_internal(DAT_181e62470
                                                                                            );
                                                                ItemData.ctor(lVar12,6);
                                                                GameDataController.LoadHorseData
                                                                          (this,lVar12,lVar11,iVar22,0)
                                                                ;
                                                                if ((lVar12 == null) ||
                                                                   (this.horseDataBase == null))
                                                                goto LAB_180bc3e85;
                                                                FUN_1806da2f0(*(int64 *)
                                                                               (this + 0x130),
                                                                              *(uint32 *)
                                                                               (lVar12 + 16),lVar12,
                                                                              DAT_181e9d6a0);
                                                                iVar22 = iVar22 + 1;
                                                              } while (iVar22 < iVar6);
                                                            }
                                                            uVar9 = DAT_181ea28c0;
                                                            uVar9 = Type.GetTypeFromHandle(uVar9,0);
                                                            uVar9 = Resources.Load("GameData/HeroNatureTalkText",uVar9,0)
                                                            ;
                                                            lVar11 = FUN_180002180(uVar9,DAT_181e8af68);
                                                            if (lVar11 != null) {
                                                              uVar9 = FUN_180002180(uVar9,DAT_181e8af68);
                                                              uVar9 = FUN_180b00cb0(uVar9,0);
                                                              var lVar11 = new c.DisplayClass9_0(0);
                                                              if (lVar11 != null) {
                                                                LTCSVLoader.ReadMultiLine(lVar11,uVar9,0)
                                                                ;
                                                                iVar6 = LTCSVLoader.GetRow(lVar11,0);
                                                                iVar22 = LTCSVLoader.GetCol(lVar11,0);
                                                                iVar24 = 1;
                                                                if (1 < iVar22) {
                                                                  do {
                                                                    lVar12 = *(int64 *)
                                                                              (this + 0x150);
                                                                    uVar9 = il2cpp_internal(
                                                        DAT_181e77728);
                                                        FUN_1810f3480(uVar9,DAT_181e861f0);
                                                        if (lVar12 == null) goto LAB_180bc3e85;
                                                        FUN_18175de30(lVar12,uVar9,DAT_181e5ae58);
                                                        iVar7 = 2;
                                                        if (2 < iVar6) {
                                                          do {
                                                            if (this.HeroNatureTalkTextDataBase == null)
                                                            goto LAB_180bc3e85;
                                                            lVar12 = FUN_1800024b0(*(int64 *)
                                                                                    (this + 0x150),
                                                                                   iVar24 + -1,
                                                                                   DAT_181e5af68);
                                                            uVar9 = LTCSVLoader.GetValueAt
                                                                              (lVar11,iVar24,iVar7,0);
                                                            if (lVar12 == null) goto LAB_180bc3e85;
                                                            FUN_18175de30(lVar12,uVar9,DAT_181e86370);
                                                            iVar7 = iVar7 + 1;
                                                          } while (iVar7 < iVar6);
                                                        }
                                                        iVar24 = iVar24 + 1;
                                                        } while (iVar24 < iVar22);
                                                        }
                                                        uVar9 = DAT_181ea28c0;
                                                        uVar9 = Type.GetTypeFromHandle(uVar9,0);
                                                        uVar9 = Resources.Load("GameData/HeroSpeTalkText",uVar9,0);
                                                        lVar11 = FUN_180002180(uVar9,DAT_181e8af68);
                                                        if (lVar11 != null) {
                                                          uVar9 = FUN_180002180(uVar9,DAT_181e8af68);
                                                          uVar9 = FUN_180b00cb0(uVar9,0);
                                                          var lVar11 = new c.DisplayClass9_0(0);
                                                          if (lVar11 != null) {
                                                            LTCSVLoader.ReadMultiLine(lVar11,uVar9,0);
                                                            iVar6 = LTCSVLoader.GetRow(lVar11,0);
                                                            iVar22 = LTCSVLoader.GetCol(lVar11,0);
                                                            iVar24 = 1;
                                                            if (1 < iVar22) {
                                                              do {
                                                                lVar12 = this.HeroSpeTalkTextDataBase;
                                                                uVar9 = il2cpp_internal(DAT_181e55fb0)
                                                                ;
                                                                HeroSpeTalkTextDataBase.ctor(uVar9,0);
                                                                if (lVar12 == null) goto LAB_180bc3e85;
                                                                FUN_18175de30(lVar12,uVar9,DAT_181e6e4f0);
                                                                if (this.HeroSpeTalkTextDataBase == null)
                                                                goto LAB_180bc3e85;
                                                                lVar12 = FUN_180210940(*(int64 *)
                                                                                        (this + 0x158),
                                                                                       iVar24 + -1,
                                                                                       DAT_181e6e5f0);
                                                                lVar13 = LTCSVLoader.GetValueAt
                                                                                   (lVar11,iVar24,0,0);
                                                                lVar14 = FUN_1801dfd90(DAT_181e81128,1);
                                                                if (lVar14 == null) goto LAB_180bc3e85;
                                                                if (*(int *)(lVar14 + 24) == 0) {
                                                                  uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                                  FUN_1801e02d0(uVar9,0);
                                                                }
                                                                *(uint16 *)(lVar14 + 32) = 124;
                                                                if (lVar13 == null) goto LAB_180bc3e85;
                                                                uVar9 = String.Split(lVar13,lVar14,0);
                                                                uVar15 = il2cpp_internal(DAT_181e77728
                                                                                            );
                                                                FUN_1817673a0(uVar15,uVar9,DAT_181e86270);
                                                                if (lVar12 == null) goto LAB_180bc3e85;
                                                                lVar12._items = uVar15;
                                                                iVar7 = 1;
                                                                if (1 < iVar6) {
                                                                  do {
                                                                    if ((this.HeroSpeTalkTextDataBase ==
                                                                         0) || (lVar12 = FUN_1800024b0(*(
                                                        int64 *)(this + 0x158),iVar24 + -1,
                                                        DAT_181e6e5f0), lVar12 == null)) goto LAB_180bc3e85;
                                                        lVar12 = lVar12.Count;
                                                        uVar9 = LTCSVLoader.GetValueAt
                                                                          (lVar11,iVar24,iVar7,0);
                                                        if (lVar12 == null) goto LAB_180bc3e85;
                                                        FUN_18175de30(lVar12,uVar9,DAT_181e86370);
                                                        iVar7 = iVar7 + 1;
                                                        } while (iVar7 < iVar6);
                                                        }
                                                        iVar24 = iVar24 + 1;
                                                        } while (iVar24 < iVar22);
                                                        }
                                                        uVar9 = DAT_181ea28c0;
                                                        uVar9 = Type.GetTypeFromHandle(uVar9,0);
                                                        uVar9 = Resources.Load("GameData/PlotData",uVar9,0);
                                                        lVar11 = FUN_180002180(uVar9,DAT_181e8af68);
                                                        if (lVar11 != null) {
                                                          uVar9 = FUN_180002180(uVar9,DAT_181e8af68);
                                                          uVar9 = FUN_180b00cb0(uVar9,0);
                                                          var lVar11 = new c.DisplayClass9_0(0);
                                                          if (lVar11 != null) {
                                                            LTCSVLoader.ReadMultiLine(lVar11,uVar9,0);
                                                            iVar22 = LTCSVLoader.GetRow(lVar11,0);
                                                            uVar9 = il2cpp_internal(DAT_181e610d0);
                                                            FUN_1806e5bc0(uVar9,DAT_181e9e570);
                                                            this.PlotDataBase = uVar9;
                                                            iVar6 = 1;
                                                            if (1 < iVar22) {
                                                              do {
                                                                lVar12 = il2cpp_internal(DAT_181e71fe8
                                                                                            );
                                                                PlotData.ctor(lVar12,0);
                                                                if (lVar12 == null) goto LAB_180bc3e85;
                                                                lVar12.Count = 1;
                                                                uVar9 = LTCSVLoader.GetValueAt
                                                                                  (lVar11,0,iVar6,0);
                                                                uVar25 = Int32.Parse(uVar9,0);
                                                                lVar12._version = uVar25;
                                                                for (iVar24 = iVar6; iVar24 < iVar22;
                                                                    iVar24 = iVar24 + 1) {
                                                                  if (iVar24 != iVar6) {
                                                                    uVar9 = LTCSVLoader.GetValueAt
                                                                                      (lVar11,0,iVar24,0);
                                                                    cVar4 = FUN_1816387f0(uVar9,
                                                        "",0);
                                                        if (!cVar4) break;
                                                        }
                                                        var lVar13 = new SinglePlotData(0);
                                                        uVar9 = LTCSVLoader.GetValueAt(lVar11,1,iVar24);
                                                        cVar4 = FUN_1816387f0(uVar9,"",0);
                                                        if (!cVar4) {
                                                          uVar9 = LTCSVLoader.GetValueAt(lVar11,1,iVar24)
                                                          ;
                                                          cVar4 = FUN_1816387f0(uVar9,"玩家",0);
                                                          if (!cVar4) {
                                                            if (lVar13 == null) goto LAB_180bc3e85;
                                                            *(uint32 *)(lVar13 + 28) = 5;
                                                            uVar9 = LTCSVLoader.GetValueAt
                                                                              (lVar11,1,iVar24);
                                                            lVar13.count = uVar9;
                                                            il2cpp_internal((uint64 *)
                                                                                (lVar13 + 32),uVar9);
                                                          }
                                                          else {
                                                            if (lVar13 == null) goto LAB_180bc3e85;
                                                            *(uint32 *)(lVar13 + 28) = 3;
                                                            lVar13.count = "0"
                                                            ;
                                                            il2cpp_internal();
                                                          }
                                                        }
                                                        else {
                                                          if (lVar13 == null) goto LAB_180bc3e85;
                                                          *(uint32 *)(lVar13 + 28) =
                                                               (uint32)(iVar24 == iVar6);
                                                        }
                                                        uVar9 = LTCSVLoader.GetValueAt(lVar11,2,iVar24);
                                                        cVar4 = FUN_1816387f0(uVar9,"",0);
                                                        if (!cVar4) {
                                                          uVar9 = LTCSVLoader.GetValueAt(lVar11,2,iVar24)
                                                          ;
                                                          cVar4 = FUN_1816387f0(uVar9,"玩家",0);
                                                          if (!cVar4) {
                                                            lVar13.version = 5;
                                                            uVar9 = LTCSVLoader.GetValueAt
                                                                              (lVar11,2,iVar24);
                                                            *(uint64 *)(lVar13 + 48) = uVar9;
                                                            il2cpp_internal((uint64 *)
                                                                                (lVar13 + 48),uVar9);
                                                          }
                                                          else {
                                                            lVar13.version = 3;
                                                            *(uint64 *)(lVar13 + 48) = "0"
                                                            ;
                                                            il2cpp_internal();
                                                          }
                                                        }
                                                        else {
                                                          lVar13.version =
                                                               (uint32)(iVar24 == iVar6);
                                                        }
                                                        lVar14 = LTCSVLoader.GetValueAt(lVar11,3,iVar24);
                                                        if (lVar14 != null) {
                                                          cVar4 = FUN_1816387f0(lVar14,"左",0);
                                                          if (!cVar4) {
                                                            cVar4 = FUN_1816387f0(lVar14,"右",0);
                                                            if (!cVar4) {
                                                              cVar4 = FUN_1816387f0(lVar14,"无",0
                                                                                   );
                                                              if (!cVar4) {
                                                                cVar4 = FUN_1816387f0(lVar14,"皆"
                                                                                      ,0);
                                                                if (cVar4) {
                                                                  lVar13.entries = 2;
                                                                }
                                                              }
                                                              else {
                                                                lVar13.entries = 3;
                                                              }
                                                            }
                                                            else {
                                                              lVar13.entries = 0;
                                                            }
                                                          }
                                                          else {
                                                            lVar13.entries = 1;
                                                          }
                                                        }
                                                        uVar9 = LTCSVLoader.GetValueAt(lVar11,4,iVar24);
                                                        *(uint64 *)(lVar13 + 80) = uVar9;
                                                        il2cpp_internal((uint64 *)(lVar13 + 80),
                                                                            uVar9);
                                                        uVar9 = LTCSVLoader.GetValueAt(lVar11,5,iVar24);
                                                        *(uint64 *)(lVar13 + 88) = uVar9;
                                                        il2cpp_internal((uint64 *)(lVar13 + 88),
                                                                            uVar9);
                                                        uVar9 = LTCSVLoader.GetValueAt(lVar11,6,iVar24);
                                                        *(uint64 *)(lVar13 + 96) = uVar9;
                                                        il2cpp_internal((uint64 *)(lVar13 + 96),
                                                                            uVar9);
                                                        uVar9 = LTCSVLoader.GetValueAt(lVar11,7,iVar24);
                                                        cVar4 = FUN_1816387f0(uVar9,"true",0);
                                                        if (!cVar4) {
                                                          uVar9 = LTCSVLoader.GetValueAt(lVar11,7,iVar24)
                                                          ;
                                                          cVar4 = FUN_1816387f0(uVar9,"TRUE",0);
                                                        }
                                                        else {
                                                          cVar4 = true;
                                                        }
                                                        *(bool *)(lVar13 + 104) = cVar4;
                                                        uVar9 = LTCSVLoader.GetValueAt(lVar11,8,iVar24);
                                                        *(uint64 *)(lVar13 + 64) = uVar9;
                                                        il2cpp_internal((uint64 *)(lVar13 + 64),
                                                                            uVar9);
                                                        uVar9 = LTCSVLoader.GetValueAt(lVar11,9,iVar24);
                                                        cVar4 = String.op_Inequality
                                                                          (uVar9,"",0);
                                                        if (cVar4) {
                                                          lVar14 = LTCSVLoader.GetValueAt
                                                                             (lVar11,9,iVar24);
                                                          lVar16 = FUN_1801dfd90(DAT_181e81128,1);
                                                          if ((lVar16 == null) ||
                                                             (FUN_180002550(lVar16,0,124), lVar14 == null))
                                                          goto LAB_180bc3e85;
                                                          uVar9 = String.Split(lVar14,lVar16,0);
                                                          uVar15 = il2cpp_internal(DAT_181e77728);
                                                          FUN_1817673a0(uVar15,uVar9,DAT_181e86270);
                                                          SinglePlotData.SetChoiceDataTexts
                                                                    (lVar13,uVar15,0);
                                                        }
                                                        uVar9 = LTCSVLoader.GetValueAt(lVar11,10,iVar24);
                                                        lVar13.buckets = uVar9;
                                                        il2cpp_internal((uint64 *)(lVar13 + 16),
                                                                            uVar9);
                                                        if (*(int64 *)(lVar12 + 64) == 0)
                                                        goto LAB_180bc3e85;
                                                        FUN_18175de30(*(int64 *)(lVar12 + 64),lVar13,
                                                                      DAT_181e839b0);
                                                        }
                                                        if (this.PlotDataBase == null)
                                                        goto LAB_180bc3e85;
                                                        FUN_1806da2f0(this.PlotDataBase,
                                                                      lVar12._version,
                                                                      lVar12);
                                                        iVar6 = iVar24;
                                                        } while (iVar24 < iVar22);
                                                        }
                                                        uVar9 = DAT_181ea28c0;
                                                        uVar9 = Type.GetTypeFromHandle(uVar9,0);
                                                        uVar9 = Resources.Load("GameData/SummonData",uVar9,0);
                                                        lVar11 = FUN_180002180(uVar9,DAT_181e8af68);
                                                        if (lVar11 != null) {
                                                          uVar9 = FUN_180002180(uVar9,DAT_181e8af68);
                                                          uVar9 = FUN_180b00cb0(uVar9,0);
                                                          var lVar11 = new c.DisplayClass9_0(0);
                                                          if (lVar11 != null) {
                                                            LTCSVLoader.ReadMultiLine(lVar11,uVar9,0);
                                                            iVar6 = LTCSVLoader.GetRow(lVar11,0);
                                                            uVar9 = il2cpp_internal(DAT_181e614c0);
                                                            FUN_1806e5bc0(uVar9,DAT_181ea0190);
                                                            *(uint64 *)(this + 400) = uVar9;
                                                            iVar22 = 1;
                                                            if (1 < iVar6) {
                                                              do {
                                                                lVar12 = il2cpp_internal(DAT_181e889e8
                                                                                            );
                                                                c__DisplayClass9_0.ctor(lVar12,0);
                                                                uVar9 = LTCSVLoader.GetValueAt
                                                                                  (lVar11,0,iVar22,0);
                                                                uVar25 = Int32.Parse(uVar9,0);
                                                                if (lVar12 == null) goto LAB_180bc3e85;
                                                                lVar12._items = uVar25;
                                                                uVar9 = LTCSVLoader.GetValueAt
                                                                                  (lVar11,1,iVar22);
                                                                lVar12.Count = uVar9;
                                                                il2cpp_internal((uint64 *)
                                                                                    (lVar12 + 24),uVar9)
                                                                ;
                                                                uVar9 = LTCSVLoader.GetValueAt
                                                                                  (lVar11,2,iVar22);
                                                                uVar25 = Int32.Parse(uVar9,0);
                                                                *(uint32 *)(lVar12 + 20) = uVar25;
                                                                uVar9 = LTCSVLoader.GetValueAt
                                                                                  (lVar11,3,iVar22);
                                                                uVar25 = Single.Parse(uVar9,0);
                                                                *(uint32 *)(lVar12 + 32) = uVar25;
                                                                uVar9 = LTCSVLoader.GetValueAt
                                                                                  (lVar11,4,iVar22);
                                                                uVar25 = Single.Parse(uVar9,0);
                                                                *(uint32 *)(lVar12 + 36) = uVar25;
                                                                uVar9 = LTCSVLoader.GetValueAt
                                                                                  (lVar11,5,iVar22);
                                                                uVar25 = Single.Parse(uVar9,0);
                                                                *(uint32 *)(lVar12 + 40) = uVar25;
                                                                uVar9 = il2cpp_internal(DAT_181e73cb8)
                                                                ;
                                                                FUN_1810f3480(uVar9,DAT_181e71270);
                                                                *(uint64 *)(lVar12 + 48) = uVar9;
                                                                lVar13 = LTCSVLoader.GetValueAt
                                                                                   (lVar11,6,iVar22);
                                                                lVar14 = FUN_1801dfd90(DAT_181e81128,1);
                                                                if (lVar14 == null) goto LAB_180bc3e85;
                                                                if (*(int *)(lVar14 + 24) == 0) {
                                                                  uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                                  FUN_1801e02d0(uVar9,0);
                                                                }
                                                                *(uint16 *)(lVar14 + 32) = 59;
                                                                if (lVar13 == null) goto LAB_180bc3e85;
                                                                lVar13 = String.Split(lVar13,lVar14,0);
                                                                iVar24 = 0;
                                                                while( true ) {
                                                                  if (lVar13 == null) goto LAB_180bc3e85;
                                                                  if (lVar13.entries <= iVar24)
                                                                  break;
                                                                  lVar14 = *(int64 *)(lVar12 + 48);
                                                                  uVar9 = FUN_180002230(lVar13,(int64)
                                                                                               iVar24);
                                                                  uVar25 = Int32.Parse(uVar9,0);
                                                                  if (lVar14 == null) goto LAB_180bc3e85;
                                                                  FUN_181769fe0(lVar14,uVar25,
                                                                                DAT_181e713f0);
                                                                  iVar24 = iVar24 + 1;
                                                                }
                                                                uVar9 = LTCSVLoader.GetValueAt
                                                                                  (lVar11,7,iVar22);
                                                                *(uint64 *)(lVar12 + 56) = uVar9;
                                                                il2cpp_internal((uint64 *)
                                                                                    (lVar12 + 56),uVar9)
                                                                ;
                                                                uVar9 = LTCSVLoader.GetValueAt
                                                                                  (lVar11,8,iVar22);
                                                                uVar5 = FUN_1816387f0(uVar9,"TRUE",
                                                                                      0);
                                                                *(uint8 *)(lVar12 + 64) = uVar5;
                                                                if (*(int64 *)(this + 400) == 0)
                                                                goto LAB_180bc3e85;
                                                                FUN_1806da2f0(*(int64 *)(this + 400)
                                                                              ,*(uint32 *)
                                                                                (lVar12 + 16),lVar12);
                                                                iVar22 = iVar22 + 1;
                                                              } while (iVar22 < iVar6);
                                                            }
                                                            uVar9 = DAT_181ea28c0;
                                                            uVar9 = Type.GetTypeFromHandle(uVar9,0);
                                                            uVar9 = Resources.Load("GameData/SummonKungFuData",uVar9,0)
                                                            ;
                                                            lVar11 = FUN_180002180(uVar9,DAT_181e8af68);
                                                            if (lVar11 != null) {
                                                              uVar9 = FUN_180002180(uVar9,DAT_181e8af68);
                                                              uVar9 = FUN_180b00cb0(uVar9,0);
                                                              var lVar11 = new c.DisplayClass9_0(0);
                                                              if (lVar11 != null) {
                                                                LTCSVLoader.ReadMultiLine(lVar11,uVar9,0)
                                                                ;
                                                                iVar6 = LTCSVLoader.GetRow(lVar11,0);
                                                                uVar9 = il2cpp_internal(DAT_181e60f50)
                                                                ;
                                                                FUN_1806e5bc0(uVar9,DAT_181e9d9d0);
                                                                this.summonSkillDataBase = uVar9;
                                                                il2cpp_internal(this + 0x140,uVar9)
                                                                ;
                                                                iVar22 = 1;
                                                                if (1 < iVar6) {
                                                                  do {
                                                                    lVar12 = 
                                                        GameDataController.LoadSkillData
                                                                  (this,lVar11,iVar22,1,0);
                                                        if ((lVar12 == null) ||
                                                           (this.summonSkillDataBase == null))
                                                        goto LAB_180bc3e85;
                                                        FUN_1806da2f0(this.summonSkillDataBase,
                                                                      *(uint32 *)(lVar12 + 20),
                                                                      lVar12,DAT_181e9da58);
                                                        iVar22 = iVar22 + 1;
                                                        } while (iVar22 < iVar6);
                                                        }
                                                        uVar9 = DAT_181ea28c0;
                                                        uVar9 = Type.GetTypeFromHandle(uVar9,0);
                                                        uVar9 = Resources.Load("GameData/KungFuData",uVar9,0);
                                                        lVar11 = FUN_180002180(uVar9,DAT_181e8af68);
                                                        if (lVar11 != null) {
                                                          uVar9 = FUN_180002180(uVar9,DAT_181e8af68);
                                                          uVar9 = FUN_180b00cb0(uVar9,0);
                                                          var lVar11 = new c.DisplayClass9_0(0);
                                                          if (lVar11 != null) {
                                                            LTCSVLoader.ReadMultiLine(lVar11,uVar9,0);
                                                            iVar6 = LTCSVLoader.GetRow(lVar11,0);
                                                            uVar9 = il2cpp_internal(DAT_181e60260);
                                                            FUN_1806e5bc0(uVar9,DAT_181e978d0);
                                                            this.kungfuSkillDataList = uVar9;
                                                            uVar9 = il2cpp_internal(DAT_181e60f50);
                                                            FUN_1806e5bc0(uVar9,DAT_181e9d9d0);
                                                            this.kungfuSkillDataBase = uVar9;
                                                            il2cpp_internal((uint64 *)
                                                                                (this + 0x138),uVar9);
                                                            lVar12 = il2cpp_internal(DAT_181e700b8);
                                                            FUN_1810f3480(lVar12,DAT_181e5a770);
                                                            iVar22 = 0;
                                                            do {
                                                              uVar9 = il2cpp_internal(DAT_181e74538);
                                                              FUN_1810f3480(uVar9,DAT_181e74170);
                                                              if (lVar12 == null) goto LAB_180bc3e85;
                                                              FUN_18175de30(lVar12,uVar9,DAT_181e5a7f8);
                                                              iVar22 = iVar22 + 1;
                                                            } while (iVar22 < 6);
                                                            if (this.kungfuSkillDataList != null) {
                                                              FUN_1806da2f0(this.kungfuSkillDataList
                                                                            ,0xffffffff,lVar12,
                                                                            DAT_181e97958);
                                                              if ((this.forceDataBase != null) &&
                                                                 (lVar12 = FUN_1806e0520(*(int64 *)
                                                                                          (this + 208)
                                                                                         ,DAT_181e9add8),
                                                                 lVar12 != null)) {
                                                                ValueCollection.GetEnumerator
                                                                          (&local_88,lVar12,DAT_181e611b0)
                                                                ;
                                                                local_e8 = local_88;
                                                                uStack_e0 = uStack_80;
                                                                local_d8 = local_78;
                                                                while (cVar4 = FUN_180dd6250(&local_e8,
                                                                                             DAT_181e79f30
                                                                                            ),
                                                                      lVar12 = local_d8, cVar4) {
                                                                  lVar13 = il2cpp_internal(
                                                        DAT_181e700b8);
                                                        FUN_1810f3480(lVar13,DAT_181e5a770);
                                                        for (iVar22 = 0; iVar22 < 6; iVar22 = iVar22 + 1)
                                                        {
                                                          uVar9 = il2cpp_internal(DAT_181e74538);
                                                          FUN_1810f3480(uVar9,DAT_181e74170);
                                                          if (lVar13 == null) {
                          // WARNING: Subroutine does not return
                                                            FUN_1801e0300();
                                                          }
                                                          FUN_18175de30(lVar13,uVar9,DAT_181e5a7f8);
                                                        }
                                                        if (lVar12 == null) {
                          // WARNING: Subroutine does not return
                                                          FUN_1801e0300();
                                                        }
                                                        if (this.kungfuSkillDataList == null) {
                          // WARNING: Subroutine does not return
                                                          FUN_1801e0300();
                                                        }
                                                        FUN_1806da2f0(this.kungfuSkillDataList,
                                                                      lVar12._items,
                                                                      lVar13);
                                                        }
                                                        ZhSegment.Initialize(&local_e8,DAT_181e79eb0);
                                                        iVar22 = 1;
                                                        if (1 < iVar6) {
                                                          do {
                                                            lVar12 = GameDataController.LoadSkillData
                                                                               (this,lVar11,iVar22,0,0)
                                                            ;
                                                            if ((lVar12 == null) ||
                                                               (this.kungfuSkillDataBase == null))
                                                            goto LAB_180bc3e85;
                                                            FUN_1806da2f0(this.kungfuSkillDataBase,
                                                                          *(uint32 *)(lVar12 + 20),
                                                                          lVar12);
                                                            if ((*(int *)(*(int64 *)
                                                                           (DAT_181e538e8 + 184) + 8) ==
                                                                 1) && (cVar4 = FUN_1816387f0(*(uint64
                                                                                                *)(lVar12 
                                                        + 32),"???",0), cVar4)) {
                                                          *(uint8 *)(lVar12 + 200) = 1;
                                                        }
                                                        if (*(char *)(lVar12 + 200) == false) {
                                                          if (((this.kungfuSkillDataList == null) ||
                                                              (lVar13 = FUN_18171b450(*(int64 *)
                                                                                       (this + 0x148),
                                                                                      *(uint32 *)
                                                                                       (lVar12 + 24),
                                                                                      DAT_181e979e0),
                                                              lVar13 == null)) ||
                                                             (lVar13 = FUN_1800024b0(lVar13,*(uint32 *
                                                                                             )(lVar12 + 
                                                        52),DAT_181e5a908), lVar13 == null))
                                                        goto LAB_180bc3e85;
                                                        FUN_18175de30(lVar13,lVar12,DAT_181e741f0);
                                                        }
                                                        iVar22 = iVar22 + 1;
                                                        } while (iVar22 < iVar6);
                                                        }
                                                        if ((this.forceDataBase != null) &&
                                                           (lVar11 = FUN_1806e0520(*(int64 *)
                                                                                    (this + 208),
                                                                                   DAT_181e9add8),
                                                           lVar11 != null)) {
                                                          ValueCollection.GetEnumerator
                                                                    (&local_70,lVar11,DAT_181e611b0);
                                                          local_e8 = local_70;
                                                          uStack_e0 = uStack_68;
                                                          local_d8 = local_60;
                                                          while (cVar4 = FUN_180dd6250(&local_e8,
                                                                                       DAT_181e79f30),
                                                                lVar11 = local_d8, cVar4) {
                                                            iVar6 = 0;
                                                            while( true ) {
                                                              if (lVar11 == null) {
                          // WARNING: Subroutine does not return
                                                                FUN_1801e0300();
                                                              }
                                                              if (*(int64 *)(lVar11 + 72) == 0) {
                          // WARNING: Subroutine does not return
                                                                FUN_1801e0300();
                                                              }
                                                              if (*(int *)(*(int64 *)(lVar11 + 72) +
                                                                          24) <= iVar6) break;
                                                              if (this.kungfuSkillDataList == null) {
                          // WARNING: Subroutine does not return
                                                                FUN_1801e0300();
                                                              }
                                                              lVar13 = FUN_18171b450(*(int64 *)
                                                                                      (this + 0x148),
                                                                                     *(uint32 *)
                                                                                      (lVar11 + 16),
                                                                                     DAT_181e979e0);
                                                              lVar12 = this.kungfuSkillDataBase;
                                                              if (*(int64 *)(lVar11 + 72) == 0) {
                          // WARNING: Subroutine does not return
                                                                FUN_1801e0300();
                                                              }
                                                              uVar25 = FUN_180002480(*(int64 *)
                                                                                      (lVar11 + 72),
                                                                                     iVar6,DAT_181e71bf0);
                                                              if (lVar12 == null) {
                          // WARNING: Subroutine does not return
                                                                FUN_1801e0300();
                                                              }
                                                              lVar12 = FUN_18171b450(lVar12,uVar25,
                                                                                     DAT_181e9dae0);
                                                              if (lVar12 == null) {
                          // WARNING: Subroutine does not return
                                                                FUN_1801e0300();
                                                              }
                                                              if (lVar13 == null) {
                          // WARNING: Subroutine does not return
                                                                FUN_1801e0300();
                                                              }
                                                              lVar13 = FUN_1800024b0(lVar13,*(uint32 *
                                                                                             )(lVar12 + 
                                                        52),DAT_181e5a908);
                                                        lVar12 = this.kungfuSkillDataBase;
                                                        if (*(int64 *)(lVar11 + 72) == 0) {
                          // WARNING: Subroutine does not return
                                                          FUN_1801e0300();
                                                        }
                                                        uVar25 = FUN_180002480(*(int64 *)
                                                                                (lVar11 + 72),iVar6,
                                                                               DAT_181e71bf0);
                                                        if (lVar12 == null) {
                          // WARNING: Subroutine does not return
                                                          FUN_1801e0300();
                                                        }
                                                        uVar9 = FUN_18171b450(lVar12,uVar25,DAT_181e9dae0)
                                                        ;
                                                        if (lVar13 == null) {
                          // WARNING: Subroutine does not return
                                                          FUN_1801e0300();
                                                        }
                                                        FUN_18175de30(lVar13,uVar9);
                                                        iVar6 = iVar6 + 1;
                                                        }
                                                        }
                                                        ZhSegment.Initialize(&local_e8,DAT_181e79eb0);
                                                        uVar9 = DAT_181ea28c0;
                                                        uVar9 = Type.GetTypeFromHandle(uVar9,0);
                                                        uVar9 = Resources.Load("GameData/SpeHeroData",uVar9,0);
                                                        lVar11 = FUN_180002180(uVar9,DAT_181e8af68);
                                                        if (lVar11 != null) {
                                                          uVar9 = FUN_180002180(uVar9,DAT_181e8af68);
                                                          uVar9 = FUN_180b00cb0(uVar9,0);
                                                          var lVar11 = new c.DisplayClass9_0(0);
                                                          if (lVar11 != null) {
                                                            LTCSVLoader.ReadMultiLine(lVar11,uVar9,0);
                                                            iVar6 = LTCSVLoader.GetRow(lVar11,0);
                                                            lVar12 = il2cpp_internal(DAT_181e60c50);
                                                            FUN_1806e5bc0(lVar12,DAT_181e9b548);
                                                            this.SpeHeroDataBase = lVar12;
                                                            iVar22 = 1;
                                                            if (1 < iVar6) {
                                                              do {
                                                                lVar12 = il2cpp_internal(DAT_181e55a60
                                                                                            );
                                                                HeroData.ctor(lVar12,0);
                                                                uVar9 = LTCSVLoader.GetValueAt
                                                                                  (lVar11,0,iVar22,0);
                                                                uVar25 = Int32.Parse(uVar9,0);
                                                                if (lVar12 == null) goto LAB_180bc3e85;
                                                                HeroData.SetHeroID(lVar12,uVar25,0);
                                                                *(uint8 *)(lVar12 + 92) = 1;
                                                                lVar13 = LTCSVLoader.GetValueAt
                                                                                   (lVar11,1,iVar22,0);
                                                                lVar14 = FUN_1801dfd90(DAT_181e81128,1);
                                                                if (lVar14 == null) goto LAB_180bc3e85;
                                                                if (*(int *)(lVar14 + 24) == 0) {
                                                                  uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                                  FUN_1801e02d0(uVar9,0);
                                                                }
                                                                *(uint16 *)(lVar14 + 32) = 46;
                                                                if ((lVar13 == null) ||
                                                                   (lVar13 = String.Split(lVar13,lVar14,0
                                                                                          ), lVar13 == null))
                                                                goto LAB_180bc3e85;
                                                                if (lVar13.entries == null) {
                                                                  uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                                  FUN_1801e02d0(uVar9,0);
                                                                }
                                                                *(uint64 *)(lVar12 + 112) =
                                                                     lVar13.count;
                                                                il2cpp_internal();
                                                                if (lVar13.entries < 2) {
                                                                  uVar9 = FUN_180002230(lVar13,0);
                                                                }
                                                                else {
                                                                  uVar9 = FUN_180002230(lVar13,0);
                                                                  uVar15 = FUN_180002230(lVar13,1);
                                                                  uVar9 = String.Concat(uVar9,uVar15,0);
                                                                }
                                                                *(uint64 *)(lVar12 + 104) = uVar9;
                                                                il2cpp_internal((uint64 *)
                                                                                    (lVar12 + 104),uVar9)
                                                                ;
                                                                uVar9 = LTCSVLoader.GetValueAt
                                                                                  (lVar11,2,iVar22);
                                                                uVar5 = FUN_1816387f0(uVar9,"女",
                                                                                      0);
                                                                *(uint8 *)(lVar12 + 128) = uVar5;
                                                                uVar9 = LTCSVLoader.GetValueAt
                                                                                  (lVar11,3,iVar22);
                                                                uVar25 = GameDataController.GetForceID
                                                                                   (this,uVar9,0);
                                                                *(uint32 *)(lVar12 + 132) = uVar25;
                                                                uVar9 = LTCSVLoader.GetValueAt
                                                                                  (lVar11,4,iVar22);
                                                                cVar4 = FUN_1816387f0(uVar9,"默认",
                                                                                      0);
                                                                if (!cVar4) {
                                                                  uVar9 = LTCSVLoader.GetValueAt
                                                                                    (lVar11,4,iVar22);
                                                                  uVar25 = GameDataController.GetForceID
                                                                                     (this,uVar9,0);
                                                                }
                                                                else {
                                                                  uVar25 = *(uint32 *)(lVar12 + 132);
                                                                }
                                                                *(uint32 *)(lVar12 + 136) = uVar25;
                                                                if (((*(byte *)(DAT_181e538e8 + 0x133) & 4
                                                                     ) != 0) &&
                                                                   (*(int *)(DAT_181e538e8 + 224) == 0))
                                                                {
                                                                  il2cpp_runtime_class_init(DAT_181e538e8)
                                                                  ;
                                                                }
                                                                lVar13 = *(int64 *)
                                                                          (*(int64 *)
                                                                            (DAT_181e538e8 + 184) + 0x3e0
                                                                          );
                                                                uVar9 = LTCSVLoader.GetValueAt
                                                                                  (lVar11,5,iVar22);
                                                                if (lVar13 == null) goto LAB_180bc3e85;
                                                                iVar24 = FUN_181662a20(lVar13,uVar9,
                                                                                       DAT_181e865f0);
                                                                *(int *)(lVar12 + 184) = iVar24;
                                                                if (iVar24 == 6) {
                                                                  *(uint32 *)(lVar12 + 184) = 5;
                                                                  *(uint8 *)(lVar12 + 180) = 1;
                                                                }
                                                                uVar9 = LTCSVLoader.GetValueAt
                                                                                  (lVar11,6,iVar22);
                                                                cVar4 = FUN_1816387f0(uVar9,"-1",
                                                                                      0);
                                                                if (!cVar4) {
                                                                  uVar9 = LTCSVLoader.GetValueAt
                                                                                    (lVar11,6,iVar22);
                                                                  fVar27 = (float)Single.Parse(uVar9,0);
                                                                }
                                                                else {
                                                                  fVar27 = (float)*(int *)(lVar12 + 184);
                                                                }
                                                                *(float *)(lVar12 + 188) = fVar27;
                                                                if (((*(byte *)(DAT_181e538e8 + 0x133) & 4
                                                                     ) != 0) &&
                                                                   (*(int *)(DAT_181e538e8 + 224) == 0))
                                                                {
                                                                  il2cpp_runtime_class_init(DAT_181e538e8)
                                                                  ;
                                                                }
                                                                lVar13 = *(int64 *)
                                                                          (*(int64 *)
                                                                            (DAT_181e538e8 + 184) + 0x5c8
                                                                          );
                                                                uVar9 = LTCSVLoader.GetValueAt
                                                                                  (lVar11,7,iVar22);
                                                                if (lVar13 == null) goto LAB_180bc3e85;
                                                                uVar25 = FUN_181662a20(lVar13,uVar9,
                                                                                       DAT_181e865f0);
                                                                *(uint32 *)(lVar12 + 0x1d8) = uVar25;
                                                                lVar13 = *(int64 *)
                                                                          (*(int64 *)
                                                                            (DAT_181e538e8 + 184) + 0x5d0
                                                                          );
                                                                uVar9 = LTCSVLoader.GetValueAt
                                                                                  (lVar11,8,iVar22);
                                                                if (lVar13 == null) goto LAB_180bc3e85;
                                                                uVar25 = FUN_181662a20(lVar13,uVar9,
                                                                                       DAT_181e865f0);
                                                                *(uint32 *)(lVar12 + 0x1dc) = uVar25;
                                                                uVar9 = LTCSVLoader.GetValueAt
                                                                                  (lVar11,9,iVar22);
                                                                uVar25 = Int32.Parse(uVar9,0);
                                                                *(uint32 *)(lVar12 + 212) = uVar25;
                                                                lVar13 = LTCSVLoader.GetValueAt
                                                                                   (lVar11,10,iVar22);
                                                                lVar14 = FUN_1801dfd90(DAT_181e81128,1);
                                                                if ((lVar14 == null) ||
                                                                   (FUN_180002550(lVar14,0,47),
                                                                   lVar13 == null)) goto LAB_180bc3e85;
                                                                lVar14 = String.Split(lVar13,lVar14,0);
                                                                lVar13 = *(int64 *)
                                                                          (*(int64 *)
                                                                            (DAT_181e538e8 + 184) + 0x5b8
                                                                          );
                                                                if ((lVar14 == null) ||
                                                                   (uVar9 = FUN_180002230(lVar14,0),
                                                                   lVar13 == null)) goto LAB_180bc3e85;
                                                                iVar24 = FUN_181662a20(lVar13,uVar9,
                                                                                       DAT_181e865f0);
                                                                *(float *)(lVar12 + 0x1d4) =
                                                                     (float)iVar24 * 25.0;
                                                                lVar13 = *(int64 *)
                                                                          (*(int64 *)
                                                                            (DAT_181e538e8 + 184) + 0x5c0
                                                                          );
                                                                uVar9 = FUN_180002230(lVar14,1);
                                                                if (lVar13 == null) goto LAB_180bc3e85;
                                                                iVar24 = FUN_181662a20(lVar13,uVar9,
                                                                                       DAT_181e865f0);
                                                                *(float *)(lVar12 + 0x1d0) =
                                                                     (float)iVar24 * 25.0;
                                                                uVar9 = LTCSVLoader.GetValueAt
                                                                                  (lVar11,11,iVar22);
                                                                cVar4 = String.op_Inequality
                                                                                  (uVar9,"",0);
                                                                if (cVar4) {
                                                                  lVar13 = LTCSVLoader.GetValueAt
                                                                                     (lVar11,11,iVar22);
                                                                  lVar14 = FUN_1801dfd90(DAT_181e81128,1);
                                                                  if ((lVar14 == null) ||
                                                                     (FUN_180002550(lVar14,0,47),
                                                                     lVar13 == null)) goto LAB_180bc3e85;
                                                                  lVar13 = String.Split(lVar13,lVar14,0);
                                                                  iVar24 = 0;
                                                                  while( true ) {
                                                                    if (lVar13 == null) goto LAB_180bc3e85;
                                                                    if (lVar13.entries <= iVar24)
                                                                    break;
                                                                    lVar14 = *(int64 *)(lVar12 + 0x108)
                                                                    ;
                                                                    if (((*(byte *)(DAT_181e538e8 + 0x133)
                                                                         & 4) != 0) &&
                                                                       (*(int *)(DAT_181e538e8 + 224) ==
                                                                        0)) {
                                                                      il2cpp_runtime_class_init
                                                                                (DAT_181e538e8);
                                                                    }
                                                                    lVar16 = *(int64 *)
                                                                              (*(int64 *)
                                                                                (DAT_181e538e8 + 184) +
                                                                              0x4a8);
                                                                    uVar9 = FUN_180002230(lVar13,(int64
                                                        )iVar24);
                                                        if ((lVar16 == null) ||
                                                           (uVar25 = FUN_181662a20(lVar16,uVar9,
                                                                                   DAT_181e865f0),
                                                           lVar14 == null)) goto LAB_180bc3e85;
                                                        FUN_181769fe0(lVar14,uVar25,DAT_181e713f0);
                                                        iVar24 = iVar24 + 1;
                                                        }
                                                        }
                                                        uVar9 = LTCSVLoader.GetValueAt(lVar11,12,iVar22)
                                                        ;
                                                        cVar4 = String.op_Inequality
                                                                          (uVar9,"",0);
                                                        if (cVar4) {
                                                          lVar13 = LTCSVLoader.GetValueAt
                                                                             (lVar11,12,iVar22);
                                                          lVar14 = FUN_1801dfd90(DAT_181e81128,1);
                                                          if ((lVar14 == null) ||
                                                             (FUN_180002550(lVar14,0,47), lVar13 == null))
                                                          goto LAB_180bc3e85;
                                                          lVar13 = String.Split(lVar13,lVar14,0);
                                                          iVar24 = 0;
                                                          while( true ) {
                                                            if (lVar13 == null) goto LAB_180bc3e85;
                                                            if (lVar13.entries <= iVar24) break;
                                                            lVar14 = *(int64 *)(lVar12 + 0x110);
                                                            lVar16 = *(int64 *)
                                                                      (pStatics
                                                                      + 0x4b8);
                                                            uVar9 = FUN_180002230(lVar13,(int64)iVar24)
                                                            ;
                                                            if ((lVar16 == null) ||
                                                               (uVar25 = FUN_181662a20(lVar16,uVar9,
                                                                                       DAT_181e865f0),
                                                               lVar14 == null)) goto LAB_180bc3e85;
                                                            FUN_181769fe0(lVar14,uVar25,DAT_181e713f0);
                                                            iVar24 = iVar24 + 1;
                                                          }
                                                        }
                                                        uVar9 = LTCSVLoader.GetValueAt(lVar11,13,iVar22)
                                                        ;
                                                        cVar4 = String.op_Inequality
                                                                          (uVar9,"",0);
                                                        if (cVar4) {
                                                          lVar13 = LTCSVLoader.GetValueAt
                                                                             (lVar11,13,iVar22);
                                                          lVar14 = FUN_1801dfd90(DAT_181e81128,1);
                                                          if ((lVar14 == null) ||
                                                             (FUN_180002550(lVar14,0,59), lVar13 == null))
                                                          goto LAB_180bc3e85;
                                                          lVar13 = String.Split(lVar13,lVar14,0);
                                                          iVar24 = 0;
                                                          while( true ) {
                                                            if (lVar13 == null) goto LAB_180bc3e85;
                                                            if (lVar13.entries <= iVar24) break;
                                                            lVar14 = *(int64 *)(lVar12 + 0x118);
                                                            uVar9 = FUN_180002230(lVar13,(int64)iVar24)
                                                            ;
                                                            if (lVar14 == null) goto LAB_180bc3e85;
                                                            FUN_18175de30(lVar14,uVar9,DAT_181e86370);
                                                            iVar24 = iVar24 + 1;
                                                          }
                                                        }
                                                        uVar9 = LTCSVLoader.GetValueAt(lVar11,14,iVar22)
                                                        ;
                                                        cVar4 = String.op_Inequality
                                                                          (uVar9,"",0);
                                                        if (cVar4) {
                                                          lVar13 = LTCSVLoader.GetValueAt
                                                                             (lVar11,14,iVar22);
                                                          lVar14 = FUN_1801dfd90(DAT_181e81128,1);
                                                          if ((lVar14 == null) ||
                                                             (FUN_180002550(lVar14,0,59), lVar13 == null))
                                                          goto LAB_180bc3e85;
                                                          lVar13 = String.Split(lVar13,lVar14,0);
                                                          iVar24 = 0;
                                                          while( true ) {
                                                            if (lVar13 == null) goto LAB_180bc3e85;
                                                            if (lVar13.entries <= iVar24) break;
                                                            uVar9 = FUN_180002230(lVar13,(int64)iVar24)
                                                            ;
                                                            iVar7 = GameDataController.GetTagID
                                                                              (this,uVar9,0);
                                                            if (iVar7 < 0) {
                                                              uVar9 = FUN_180002230(lVar13,(int64)
                                                                                           iVar24);
                                                              uVar9 = String.Concat("Load Spe Hero Tag Error! ",uVar9);
                                                              if (((*(byte *)(DAT_181ea01b8 + 0x133) & 4)
                                                                   != 0) &&
                                                                 (*(int *)(DAT_181ea01b8 + 224) == 0)) {
                                                                il2cpp_runtime_class_init();
                                                              }
                                                              Debug.Log(uVar9,0);
                                                              iVar24 = iVar24 + 1;
                                                            }
                                                            else {
                                                              HeroData.AddTag(lVar12,iVar7);
                                                              iVar24 = iVar24 + 1;
                                                            }
                                                          }
                                                        }
                                                        uVar9 = LTCSVLoader.GetValueAt(lVar11,15,iVar22)
                                                        ;
                                                        cVar4 = String.op_Inequality
                                                                          (uVar9,"",0);
                                                        if (cVar4) {
                                                          uVar9 = LTCSVLoader.GetValueAt
                                                                            (lVar11,15,iVar22);
                                                          *(uint64 *)(lVar12 + 120) = uVar9;
                                                          il2cpp_internal((uint64 *)
                                                                              (lVar12 + 120),uVar9);
                                                        }
                                                        uVar9 = LTCSVLoader.GetValueAt
                                                                          (lVar11,16,iVar22);
                                                        uVar5 = FUN_1816387f0(uVar9,"1",0);
                                                        *(uint8 *)(lVar12 + 96) = uVar5;
                                                        uVar9 = LTCSVLoader.GetValueAt
                                                                          (lVar11,17,iVar22);
                                                        uVar5 = FUN_1816387f0(uVar9,"1",0);
                                                        *(uint8 *)(lVar12 + 140) = uVar5;
                                                        uVar9 = LTCSVLoader.GetValueAt
                                                                          (lVar11,19,iVar22);
                                                        iVar24 = Int32.Parse(uVar9,0);
                                                        *(int *)(lVar12 + 236) = iVar24;
                                                        if (iVar24 == -99) {
                                                          cVar4 = HeroData.HaveForce(lVar12,0);
                                                          if (!cVar4) {
                                                            cVar4 = HeroData.HaveSkillForce(lVar12,0);
                                                            if (cVar4) {
                                                              lVar13 = this.forceDataBase;
                                                              if (lVar13 != null) {
                                                                uVar25 = *(uint32 *)(lVar12 + 136);
                                                                goto LAB_180bc20a4;
                                                              }
                                                              goto LAB_180bc3e85;
                                                            }
                                                          }
                                                          else {
                                                            lVar13 = this.forceDataBase;
                                                            if (lVar13 == null) goto LAB_180bc3e85;
                                                            uVar25 = *(uint32 *)(lVar12 + 132);
        LAB_180bc20a4:
                                                            lVar13 = FUN_18171b450(lVar13,uVar25,
                                                                                   DAT_181e9ad50);
                                                            if (lVar13 == null) goto LAB_180bc3e85;
                                                            *(uint32 *)(lVar12 + 236) =
                                                                 lVar13.count;
                                                          }
                                                          if (*(int *)(lVar12 + 236) == -99) {
                                                            *(uint32 *)(lVar12 + 236) = 0xffffffff;
                                                          }
                                                        }
                                                        uVar9 = LTCSVLoader.GetValueAt
                                                                          (lVar11,20,iVar22);
                                                        cVar4 = FUN_1816387f0(uVar9,"1",0);
                                                        if (cVar4) {
                                                          if (this.SpeSkeletonName == null)
                                                          goto LAB_180bc3e85;
                                                          FUN_1806da2f0(this.SpeSkeletonName,
                                                                        *(uint64 *)(lVar12 + 104),1,
                                                                        DAT_181e53a58);
                                                        }
                                                        if (*plVar10 == 0) goto LAB_180bc3e85;
                                                        FUN_1806da2f0(*plVar10,*(uint32 *)
                                                                                (lVar12 + 88),lVar12);
                                                        iVar22 = iVar22 + 1;
                                                        } while (iVar22 < iVar6);
                                                        }
                                                        iVar22 = 1;
                                                        if (1 < iVar6) {
                                                          do {
                                                            lVar12 = LTCSVLoader.GetValueAt
                                                                               (lVar11,18,iVar22);
                                                            if (lVar12 != null) {
                                                              uVar9 = LTCSVLoader.GetValueAt
                                                                                (lVar11,18,iVar22);
                                                              cVar4 = String.op_Inequality
                                                                                (uVar9,"",0);
                                                              if (cVar4) {
                                                                lVar12 = LTCSVLoader.GetValueAt
                                                                                   (lVar11,18,iVar22);
                                                                lVar13 = FUN_1801dfd90(DAT_181e81128,1);
                                                                if ((lVar13 != null) &&
                                                                   (FUN_180002550(lVar13,0,59),
                                                                   lVar12 != null)) {
                                                                  lVar12 = String.Split(lVar12,lVar13,0);
                                                                  local_f8 = lVar12;
                                                                  uVar9 = LTCSVLoader.GetValueAt
                                                                                    (lVar11,0,iVar22);
                                                                  uVar25 = Int32.Parse(uVar9,0);
                                                                  local_res18 = 0;
        LAB_180bc2240:
                                                                  if (lVar12 == null) goto LAB_180bc3e85;
                                                                  if (local_res18 <
                                                                      lVar12.Count) {
                                                                    lVar12 = FUN_180002230(lVar12,(
                                                        int64)local_res18);
                                                        lVar13 = FUN_1801dfd90(DAT_181e81128,1);
                                                        if (((lVar13 != null) &&
                                                            (FUN_180002550(lVar13,0,58), lVar12 != null))
                                                           && (lVar12 = String.Split(lVar12,lVar13,0),
                                                              lVar12 != null)) {
                                                          lVar13 = FUN_180002230(lVar12,1);
                                                          lVar14 = FUN_1801dfd90(DAT_181e81128);
                                                          if ((lVar14 != null) &&
                                                             (FUN_180002550(lVar14), lVar13 != null)) {
                                                            lVar13 = String.Split(lVar13);
                                                            iVar24 = 0;
        LAB_180bc2310:
                                                            if (lVar13 == null) goto LAB_180bc3e85;
                                                            if (lVar13.entries <= iVar24)
                                                            goto LAB_180bc2ddf;
                                                            lVar14 = FUN_180002230(lVar12,0);
                                                            if (lVar14 != null) {
                                                              uVar8 = 
                                                        PrivateImplementationDetails.ComputeStringHash
                                                                  (lVar14,0);
                                                        if (uVar8 < 0x1b00bfb7) {
                                                          if (uVar8 == 0xbcfe0f1) {
                                                            cVar4 = FUN_1816387f0(lVar14,"结义",0);
                                                            if (!cVar4) goto LAB_180bc2d86;
                                                            if ((*plVar10 == 0) ||
                                                               (lVar14 = FUN_18171b450(*plVar10,uVar25,
                                                                                       DAT_181e9b768),
                                                               lVar14 == null)) goto LAB_180bc3e85;
                                                            lVar14 = *(int64 *)(lVar14 + 0x340);
                                                            lVar16 = (int64)iVar24;
                                                            uVar9 = FUN_180002230(lVar13,lVar16);
                                                            uVar26 = Int32.Parse(uVar9,0);
                                                            if (lVar14 == null) goto LAB_180bc3e85;
                                                            cVar4 = FUN_18176a2d0(lVar14,uVar26,
                                                                                  DAT_181e71570);
                                                            if (!cVar4) {
                                                              if ((*plVar10 == 0) ||
                                                                 (lVar14 = FUN_18171b450(*plVar10,uVar25,
                                                                                         DAT_181e9b768),
                                                                 lVar14 == null)) goto LAB_180bc3e85;
                                                              lVar14 = *(int64 *)(lVar14 + 0x340);
                                                              uVar9 = FUN_180002230(lVar13,lVar16);
                                                              uVar26 = Int32.Parse(uVar9,0);
                                                              if (lVar14 == null) goto LAB_180bc3e85;
                                                              FUN_181769fe0(lVar14,uVar26,DAT_181e713f0);
                                                            }
                                                            lVar14 = *plVar10;
                                                            uVar9 = FUN_180002230(lVar13,lVar16);
                                                            uVar26 = Int32.Parse(uVar9,0);
                                                            if (((lVar14 != null) &&
                                                                (lVar14 = FUN_18171b450(lVar14,uVar26,
                                                                                        DAT_181e9b768),
                                                                lVar14 != null)) &&
                                                               (*(int64 *)(lVar14 + 0x340) != 0)) {
                                                              cVar4 = FUN_18176a2d0();
                                                              if (cVar4) goto LAB_180bc24ee;
                                                              lVar14 = *plVar10;
                                                              uVar9 = FUN_180002230(lVar13,lVar16);
                                                              uVar26 = Int32.Parse(uVar9,0);
                                                              if ((lVar14 != null) &&
                                                                 (lVar14 = FUN_18171b450(lVar14,uVar26,
                                                                                         DAT_181e9b768),
                                                                 lVar14 != null)) {
                                                                lVar14 = *(int64 *)(lVar14 + 0x340);
                                                                goto LAB_180bc24d7;
                                                              }
                                                            }
                                                            goto LAB_180bc3e85;
                                                          }
                                                          if (uVar8 == 0x19bb3b94) {
                                                            cVar4 = FUN_1816387f0(lVar14,"仇人",0);
                                                            if (!cVar4) goto LAB_180bc2d86;
                                                            if ((*plVar10 == 0) ||
                                                               (lVar14 = FUN_18171b450(*plVar10,uVar25,
                                                                                       DAT_181e9b768),
                                                               lVar14 == null)) goto LAB_180bc3e85;
                                                            lVar14 = *(int64 *)(lVar14 + 0x350);
                                                            lVar16 = (int64)iVar24;
                                                            uVar9 = FUN_180002230(lVar13,lVar16);
                                                            uVar26 = Int32.Parse(uVar9,0);
                                                            if (lVar14 == null) goto LAB_180bc3e85;
                                                            cVar4 = FUN_18176a2d0(lVar14,uVar26,
                                                                                  DAT_181e71570);
                                                            if (!cVar4) {
                                                              if ((*plVar10 == 0) ||
                                                                 (lVar14 = FUN_18171b450(*plVar10,uVar25,
                                                                                         DAT_181e9b768),
                                                                 lVar14 == null)) goto LAB_180bc3e85;
                                                              lVar14 = *(int64 *)(lVar14 + 0x350);
                                                              uVar9 = FUN_180002230(lVar13,lVar16);
                                                              uVar26 = Int32.Parse(uVar9,0);
                                                              if (lVar14 == null) goto LAB_180bc3e85;
                                                              FUN_181769fe0(lVar14,uVar26,DAT_181e713f0);
                                                            }
                                                            lVar14 = *plVar10;
                                                            uVar9 = FUN_180002230(lVar13,lVar16);
                                                            uVar26 = Int32.Parse(uVar9,0);
                                                            if (((lVar14 != null) &&
                                                                (lVar14 = FUN_18171b450(lVar14,uVar26,
                                                                                        DAT_181e9b768),
                                                                lVar14 != null)) &&
                                                               (*(int64 *)(lVar14 + 0x350) != 0)) {
                                                              cVar4 = FUN_18176a2d0();
                                                              if (cVar4) goto LAB_180bc24ee;
                                                              lVar14 = *plVar10;
                                                              uVar9 = FUN_180002230(lVar13,lVar16);
                                                              uVar26 = Int32.Parse(uVar9,0);
                                                              if ((lVar14 != null) &&
                                                                 (lVar14 = FUN_18171b450(lVar14,uVar26,
                                                                                         DAT_181e9b768),
                                                                 lVar14 != null)) {
                                                                lVar14 = *(int64 *)(lVar14 + 0x350);
                                                                goto LAB_180bc24d7;
                                                              }
                                                            }
                                                            goto LAB_180bc3e85;
                                                          }
                                                          if ((uVar8 != 0x1b00bfb6) ||
                                                             (cVar4 = FUN_1816387f0(lVar14,"师傅",0
                                                                                   ), !cVar4))
                                                          goto LAB_180bc2d86;
                                                          if (*plVar10 == 0) goto LAB_180bc3e85;
                                                          lVar14 = FUN_18171b450(*plVar10,uVar25,
                                                                                 DAT_181e9b768);
                                                          lVar16 = (int64)iVar24;
                                                          uVar9 = FUN_180002230(lVar13,lVar16);
                                                          uVar26 = Int32.Parse(uVar9,0);
                                                          if (lVar14 == null) goto LAB_180bc3e85;
                                                          *(uint32 *)(lVar14 + 0x31c) = uVar26;
                                                          lVar14 = *plVar10;
                                                          uVar9 = FUN_180002230(lVar13,lVar16);
                                                          uVar26 = Int32.Parse(uVar9,0);
                                                          if (((lVar14 == null) ||
                                                              (lVar14 = FUN_18171b450(lVar14,uVar26,
                                                                                      DAT_181e9b768),
                                                              lVar14 == null)) ||
                                                             (*(int64 *)(lVar14 + 800) == 0))
                                                          goto LAB_180bc3e85;
                                                          cVar4 = FUN_18176a2d0(*(int64 *)
                                                                                 (lVar14 + 800),iVar22,
                                                                                DAT_181e71570);
                                                          if (!cVar4) {
                                                            lVar14 = *plVar10;
                                                            uVar9 = FUN_180002230(lVar13,lVar16);
                                                            uVar26 = Int32.Parse(uVar9,0);
                                                            if (((lVar14 == null) ||
                                                                (lVar14 = FUN_18171b450(lVar14,uVar26,
                                                                                        DAT_181e9b768),
                                                                lVar14 == null)) ||
                                                               (*(int64 *)(lVar14 + 800) == 0))
                                                            goto LAB_180bc3e85;
                                                            FUN_181769fe0(*(int64 *)(lVar14 + 800),
                                                                          iVar22,DAT_181e713f0);
                                                          }
                                                          if (*plVar10 == 0) goto LAB_180bc3e85;
                                                          lVar17 = FUN_18171b450(*plVar10,uVar25,
                                                                                 DAT_181e9b768);
                                                          lVar14 = *plVar10;
                                                          uVar9 = FUN_180002230(lVar13,lVar16);
                                                          Int32.Parse(uVar9,0);
                                                          if (((lVar14 == null) ||
                                                              (lVar14 = FUN_18171b450(lVar14), lVar14 == null
                                                              )) || (lVar17 == null)) goto LAB_180bc3e85;
                                                          *(int *)(lVar17 + 216) =
                                                               *(int *)(lVar14 + 216) + 1;
                                                          iVar24 = iVar24 + 1;
                                                          goto LAB_180bc2310;
                                                        }
                                                        if (uVar8 < 0x8485de14) {
                                                          if (uVar8 == 0x62139899) {
                                                            cVar4 = FUN_1816387f0(lVar14,"情侣",0);
                                                            if (cVar4) {
                                                              if ((*plVar10 == 0) ||
                                                                 (lVar14 = FUN_18171b450(*plVar10,uVar25,
                                                                                         DAT_181e9b768),
                                                                 lVar14 == null)) goto LAB_180bc3e85;
                                                              lVar14 = *(int64 *)(lVar14 + 0x330);
                                                              lVar16 = (int64)iVar24;
                                                              uVar9 = FUN_180002230(lVar13,lVar16);
                                                              uVar26 = Int32.Parse(uVar9,0);
                                                              if (lVar14 == null) goto LAB_180bc3e85;
                                                              cVar4 = FUN_18176a2d0(lVar14,uVar26,
                                                                                    DAT_181e71570);
                                                              if (!cVar4) {
                                                                if ((*plVar10 == 0) ||
                                                                   (lVar14 = FUN_18171b450(*plVar10,uVar25
                                                                                           ,DAT_181e9b768)
                                                                   , lVar14 == null)) goto LAB_180bc3e85;
                                                                lVar14 = *(int64 *)(lVar14 + 0x330);
                                                                uVar9 = FUN_180002230(lVar13,lVar16);
                                                                uVar26 = Int32.Parse(uVar9,0);
                                                                if (lVar14 == null) goto LAB_180bc3e85;
                                                                FUN_181769fe0(lVar14,uVar26,DAT_181e713f0)
                                                                ;
                                                              }
                                                              lVar14 = *plVar10;
                                                              uVar9 = FUN_180002230(lVar13,lVar16);
                                                              uVar26 = Int32.Parse(uVar9,0);
                                                              if (((lVar14 == null) ||
                                                                  (lVar14 = FUN_18171b450(lVar14,uVar26,
                                                                                          DAT_181e9b768),
                                                                  lVar14 == null)) ||
                                                                 (*(int64 *)(lVar14 + 0x330) == 0))
                                                              goto LAB_180bc3e85;
                                                              cVar4 = FUN_18176a2d0();
                                                              if (!cVar4) {
                                                                lVar14 = *plVar10;
                                                                uVar9 = FUN_180002230(lVar13,lVar16);
                                                                uVar26 = Int32.Parse(uVar9,0);
                                                                if ((lVar14 == null) ||
                                                                   (lVar14 = FUN_18171b450(lVar14,uVar26,
                                                                                           DAT_181e9b768),
                                                                   lVar14 == null)) goto LAB_180bc3e85;
                                                                lVar14 = *(int64 *)(lVar14 + 0x330);
        LAB_180bc24d7:
                                                                if (lVar14 == null) goto LAB_180bc3e85;
                                                                FUN_181769fe0();
                                                              }
        LAB_180bc24ee:
                                                              iVar24 = iVar24 + 1;
                                                              goto LAB_180bc2310;
                                                            }
                                                          }
                                                          else if ((uVar8 == 0x8485de13) &&
                                                                  (cVar4 = FUN_1816387f0(lVar14,
                                                        "朋友",0), cVar4)) {
                                                          if ((*plVar10 == 0) ||
                                                             (lVar14 = FUN_18171b450(*plVar10,uVar25,
                                                                                     DAT_181e9b768),
                                                             lVar14 == null)) goto LAB_180bc3e85;
                                                          lVar14 = *(int64 *)(lVar14 + 0x348);
                                                          lVar16 = (int64)iVar24;
                                                          uVar9 = FUN_180002230(lVar13,lVar16);
                                                          uVar26 = Int32.Parse(uVar9,0);
                                                          if (lVar14 == null) goto LAB_180bc3e85;
                                                          cVar4 = FUN_18176a2d0(lVar14,uVar26,
                                                                                DAT_181e71570);
                                                          if (!cVar4) {
                                                            if ((*plVar10 == 0) ||
                                                               (lVar14 = FUN_18171b450(*plVar10,uVar25,
                                                                                       DAT_181e9b768),
                                                               lVar14 == null)) goto LAB_180bc3e85;
                                                            lVar14 = *(int64 *)(lVar14 + 0x348);
                                                            uVar9 = FUN_180002230(lVar13,lVar16);
                                                            uVar26 = Int32.Parse(uVar9,0);
                                                            if (lVar14 == null) goto LAB_180bc3e85;
                                                            FUN_181769fe0(lVar14,uVar26,DAT_181e713f0);
                                                          }
                                                          lVar14 = *plVar10;
                                                          uVar9 = FUN_180002230(lVar13,lVar16);
                                                          uVar26 = Int32.Parse(uVar9,0);
                                                          if (((lVar14 != null) &&
                                                              (lVar14 = FUN_18171b450(lVar14,uVar26,
                                                                                      DAT_181e9b768),
                                                              lVar14 != null)) &&
                                                             (*(int64 *)(lVar14 + 0x348) != 0)) {
                                                            cVar4 = FUN_18176a2d0();
                                                            if (cVar4) goto LAB_180bc24ee;
                                                            lVar14 = *plVar10;
                                                            uVar9 = FUN_180002230(lVar13,lVar16);
                                                            uVar26 = Int32.Parse(uVar9,0);
                                                            if ((lVar14 != null) &&
                                                               (lVar14 = FUN_18171b450(lVar14,uVar26,
                                                                                       DAT_181e9b768),
                                                               lVar14 != null)) {
                                                              lVar14 = *(int64 *)(lVar14 + 0x348);
                                                              goto LAB_180bc24d7;
                                                            }
                                                          }
                                                          goto LAB_180bc3e85;
                                                        }
                                                        }
                                                        else {
                                                          if (uVar8 == 0xb841b951) {
                                                            cVar4 = FUN_1816387f0(lVar14,"亲属",0);
                                                            if (!cVar4) goto LAB_180bc2d86;
                                                            if ((*plVar10 == 0) ||
                                                               (lVar14 = FUN_18171b450(*plVar10,uVar25,
                                                                                       DAT_181e9b768),
                                                               lVar14 == null)) goto LAB_180bc3e85;
                                                            lVar14 = *(int64 *)(lVar14 + 0x338);
                                                            lVar16 = (int64)iVar24;
                                                            uVar9 = FUN_180002230(lVar13,lVar16);
                                                            uVar26 = Int32.Parse(uVar9,0);
                                                            if (lVar14 == null) goto LAB_180bc3e85;
                                                            cVar4 = FUN_18176a2d0(lVar14,uVar26,
                                                                                  DAT_181e71570);
                                                            if (!cVar4) {
                                                              if ((*plVar10 == 0) ||
                                                                 (lVar14 = FUN_18171b450(*plVar10,uVar25,
                                                                                         DAT_181e9b768),
                                                                 lVar14 == null)) goto LAB_180bc3e85;
                                                              lVar14 = *(int64 *)(lVar14 + 0x338);
                                                              uVar9 = FUN_180002230(lVar13,lVar16);
                                                              uVar26 = Int32.Parse(uVar9,0);
                                                              if (lVar14 == null) goto LAB_180bc3e85;
                                                              FUN_181769fe0(lVar14,uVar26,DAT_181e713f0);
                                                            }
                                                            lVar14 = *plVar10;
                                                            uVar9 = FUN_180002230(lVar13,lVar16);
                                                            uVar26 = Int32.Parse(uVar9,0);
                                                            if (((lVar14 != null) &&
                                                                (lVar14 = FUN_18171b450(lVar14,uVar26,
                                                                                        DAT_181e9b768),
                                                                lVar14 != null)) &&
                                                               (*(int64 *)(lVar14 + 0x338) != 0)) {
                                                              cVar4 = FUN_18176a2d0();
                                                              if (cVar4) goto LAB_180bc24ee;
                                                              lVar14 = *plVar10;
                                                              uVar9 = FUN_180002230(lVar13,lVar16);
                                                              uVar26 = Int32.Parse(uVar9,0);
                                                              if ((lVar14 != null) &&
                                                                 (lVar14 = FUN_18171b450(lVar14,uVar26,
                                                                                         DAT_181e9b768),
                                                                 lVar14 != null)) {
                                                                lVar14 = *(int64 *)(lVar14 + 0x338);
                                                                goto LAB_180bc24d7;
                                                              }
                                                            }
                                                            goto LAB_180bc3e85;
                                                          }
                                                          if ((uVar8 == 0xf1d60b2a) &&
                                                             (cVar4 = FUN_1816387f0(lVar14,"配偶",0
                                                                                   ), cVar4)) {
                                                            if (*plVar10 == 0) goto LAB_180bc3e85;
                                                            lVar14 = FUN_18171b450(*plVar10,uVar25,
                                                                                   DAT_181e9b768);
                                                            uVar9 = FUN_180002230(lVar13,(int64)iVar24)
                                                            ;
                                                            uVar26 = Int32.Parse(uVar9,0);
                                                            if (lVar14 == null) goto LAB_180bc3e85;
                                                            *(uint32 *)(lVar14 + 0x328) = uVar26;
                                                            lVar14 = *plVar10;
                                                            uVar9 = FUN_180002230(lVar13,(int64)iVar24)
                                                            ;
                                                            Int32.Parse(uVar9,0);
                                                            if ((lVar14 == null) ||
                                                               (lVar14 = FUN_18171b450(lVar14),
                                                               lVar14 == null)) goto LAB_180bc3e85;
                                                            *(int *)(lVar14 + 0x328) = iVar22;
                                                            iVar24 = iVar24 + 1;
                                                            goto LAB_180bc2310;
                                                          }
                                                        }
                                                        }
        LAB_180bc2d86:
                                                        FUN_180002230(lVar12,0);
                                                        uVar9 = String.Concat("角色关系");
                                                        Debug.Log(uVar9);
                                                        iVar24 = iVar24 + 1;
                                                        goto LAB_180bc2310;
                                                        }
                                                        }
                                                        goto LAB_180bc3e85;
                                                        }
                                                        goto LAB_180bc2e08;
                                                        }
                                                        goto LAB_180bc3e85;
                                                        }
                                                        }
        LAB_180bc2e08:
                                                        iVar22 = iVar22 + 1;
                                                        } while (iVar22 < iVar6);
                                                        }
                                                        uVar9 = DAT_181ea28c0;
                                                        uVar9 = Type.GetTypeFromHandle(uVar9,0);
                                                        uVar9 = Resources.Load("GameData/SpeHeroFaceData",uVar9,0);
                                                        lVar11 = FUN_180002180(uVar9,DAT_181e8af68);
                                                        if (lVar11 != null) {
                                                          uVar9 = FUN_180002180(uVar9,DAT_181e8af68);
                                                          uVar9 = FUN_180b00cb0(uVar9,0);
                                                          var lVar11 = new c.DisplayClass9_0(0);
                                                          if (lVar11 != null) {
                                                            LTCSVLoader.ReadMultiLine(lVar11,uVar9,0);
                                                            iVar6 = LTCSVLoader.GetRow(lVar11,0);
                                                            iVar22 = 1;
                                                            if (1 < iVar6) {
                                                              do {
                                                                lVar12 = il2cpp_internal(DAT_181e55bf8
                                                                                            );
                                                                HeroFaceData.ctor(lVar12,0);
                                                                uVar9 = LTCSVLoader.GetValueAt
                                                                                  (lVar11,0,iVar22,0);
                                                                uVar25 = Int32.Parse(uVar9,0);
                                                                iVar24 = 0;
                                                                while( true ) {
                                                                  if ((lVar12 == null) ||
                                                                     (lVar13 = *(int64 *)
                                                                                (lVar12 + 16),
                                                                     lVar13 == null)) goto LAB_180bc3e85;
                                                                  if (lVar13.entries <= iVar24)
                                                                  break;
                                                                  uVar9 = LTCSVLoader.GetValueAt
                                                                                    (lVar11,iVar24 + 2,
                                                                                     iVar22,0);
                                                                  uVar26 = Int32.Parse(uVar9,0);
                                                                  if (lVar13 == null) goto LAB_180bc3e85;
                                                                  FUN_181774110(lVar13,iVar24,uVar26);
                                                                  iVar24 = iVar24 + 1;
                                                                }
                                                                if (iVar22 == 1) {
                                                                  plVar18 = &this.MaleFaceTotalNum;
                                                                }
                                                                else if (iVar22 == 2) {
                                                                  plVar18 = &this.FemaleFaceTotalNum;
                                                                }
                                                                else {
                                                                  if ((*plVar10 == 0) ||
                                                                     (lVar13 = FUN_18171b450(*plVar10,
                                                        uVar25,DAT_181e9b768), lVar13 == null))
                                                        goto LAB_180bc3e85;
                                                        plVar18 = (int64 *)(lVar13 + 224);
                                                        }
                                                        *plVar18 = lVar12;
                                                        il2cpp_internal();
                                                        iVar22 = iVar22 + 1;
                                                        } while (iVar22 < iVar6);
                                                        }
                                                        uVar9 = il2cpp_internal(DAT_181e6ffb8);
                                                        FUN_1810f3480(uVar9,DAT_181e5a220);
                                                        this.MaleFaceRandomID = uVar9;
                                                        uVar9 = il2cpp_internal(DAT_181e6ffb8);
                                                        FUN_1810f3480(uVar9,DAT_181e5a220);
                                                        this.FemaleFaceRandomID = uVar9;
                                                        iVar6 = 0;
                                                        do {
                                                          lVar11 = this.MaleFaceRandomID;
                                                          uVar9 = il2cpp_internal(DAT_181e73cb8);
                                                          FUN_1810f3480(uVar9,DAT_181e71270);
                                                          if (lVar11 == null) goto LAB_180bc3e85;
                                                          FUN_18175de30(lVar11,uVar9,DAT_181e5a330);
                                                          iVar22 = 0;
                                                          while( true ) {
                                                            if ((this.MaleFaceTotalNum == null) ||
                                                               (lVar11 = *(int64 *)
                                                                          (this.MaleFaceTotalNum
                                                                          + 16), lVar11 == null))
                                                            goto LAB_180bc3e85;
                                                            iVar24 = FUN_180002480(lVar11,iVar6,
                                                                                   DAT_181e71bf0);
                                                            if (iVar24 <= iVar22) break;
                                                            lVar11 = *(int64 *)
                                                                      (pStatics
                                                                      + 0x670);
                                                            if ((lVar11 == null) ||
                                                               (lVar11 = FUN_1800024b0(lVar11,iVar6,
                                                                                       DAT_181e5a4c8),
                                                               lVar11 == null)) goto LAB_180bc3e85;
                                                            cVar4 = FUN_18176a2d0(lVar11,iVar22,
                                                                                  DAT_181e71570);
                                                            if (!cVar4) {
                                                              if ((this.MaleFaceRandomID == null) ||
                                                                 (lVar11 = FUN_1800024b0(*(int64 *)
                                                                                          (this + 0x178
                                                                                          ),iVar6,
                                                        DAT_181e5a4c8), lVar11 == null)) goto LAB_180bc3e85;
                                                        FUN_181769fe0(lVar11,iVar22,DAT_181e713f0);
                                                        }
                                                        iVar22 = iVar22 + 1;
                                                        }
                                                        lVar11 = this.FemaleFaceRandomID;
                                                        uVar9 = il2cpp_internal(DAT_181e73cb8);
                                                        FUN_1810f3480(uVar9,DAT_181e71270);
                                                        if (lVar11 == null) goto LAB_180bc3e85;
                                                        FUN_18175de30(lVar11,uVar9,DAT_181e5a330);
                                                        iVar22 = 0;
                                                        while( true ) {
                                                          if ((this.FemaleFaceTotalNum == null) ||
                                                             (lVar11 = *(int64 *)
                                                                        (this.FemaleFaceTotalNum +
                                                                        16), lVar11 == null))
                                                          goto LAB_180bc3e85;
                                                          iVar24 = FUN_180002480(lVar11,iVar6,
                                                                                 DAT_181e71bf0);
                                                          uVar9 = DAT_181ea28c0;
                                                          if (iVar24 <= iVar22) break;
                                                          lVar11 = *(int64 *)
                                                                    (pStatics +
                                                                    0x678);
                                                          if ((lVar11 == null) ||
                                                             (lVar11 = FUN_1800024b0(lVar11,iVar6,
                                                                                     DAT_181e5a4c8),
                                                             lVar11 == null)) goto LAB_180bc3e85;
                                                          cVar4 = FUN_18176a2d0(lVar11,iVar22,
                                                                                DAT_181e71570);
                                                          if (!cVar4) {
                                                            if ((this.FemaleFaceRandomID == null) ||
                                                               (lVar11 = FUN_1800024b0(*(int64 *)
                                                                                        (this + 0x180),
                                                                                       iVar6,DAT_181e5a4c8
                                                                                      ), lVar11 == null))
                                                            goto LAB_180bc3e85;
                                                            FUN_181769fe0(lVar11,iVar22,DAT_181e713f0);
                                                          }
                                                          iVar22 = iVar22 + 1;
                                                        }
                                                        iVar6 = iVar6 + 1;
                                                        } while (iVar6 < 6);
                                                        uVar9 = Type.GetTypeFromHandle(uVar9,0);
                                                        uVar9 = Resources.Load("GameData/BookTypeIconData",uVar9,0);
                                                        lVar11 = FUN_180002180(uVar9,DAT_181e8af68);
                                                        if (lVar11 != null) {
                                                          uVar9 = FUN_180002180(uVar9,DAT_181e8af68);
                                                          uVar9 = FUN_180b00cb0(uVar9,0);
                                                          var lVar11 = new c.DisplayClass9_0(0);
                                                          if (lVar11 != null) {
                                                            LTCSVLoader.ReadMultiLine(lVar11,uVar9,0);
                                                            iVar6 = LTCSVLoader.GetRow(lVar11,0);
                                                            iVar22 = 1;
                                                            if (1 < iVar6) {
                                                              do {
                                                                lVar12 = il2cpp_internal(DAT_181e92b88
                                                                                            );
                                                                c__DisplayClass9_0.ctor(lVar12,0);
                                                                lVar13 = LTCSVLoader.GetValueAt
                                                                                   (lVar11,0,iVar22,0);
                                                                if (lVar13 == null) goto LAB_180bc3e85;
                                                                cVar4 = String.Contains(lVar13,
                                                        "_",0);
                                                        if (!cVar4) {
                                                          uVar9 = LTCSVLoader.GetValueAt
                                                                            (lVar11,0,iVar22,0);
                                                          uVar25 = Int32.Parse(uVar9,0);
                                                          if (lVar12 == null) goto LAB_180bc3e85;
                                                          lVar12._items = uVar25;
                                                        }
                                                        else {
                                                          lVar13 = LTCSVLoader.GetValueAt
                                                                             (lVar11,0,iVar22,0);
                                                          lVar14 = FUN_1801dfd90(DAT_181e81128,1);
                                                          if (((lVar14 == null) ||
                                                              (FUN_180002550(lVar14,0,95), lVar13 == null))
                                                             || (lVar13 = String.Split(lVar13,lVar14,0),
                                                                lVar13 == null)) goto LAB_180bc3e85;
                                                          uVar9 = FUN_180002230(lVar13,0);
                                                          uVar25 = Int32.Parse(uVar9,0);
                                                          if (lVar12 == null) goto LAB_180bc3e85;
                                                          lVar12._items = uVar25;
                                                          uVar9 = FUN_180002230(lVar13,1);
                                                          uVar25 = Int32.Parse(uVar9,0);
                                                          *(uint32 *)(lVar12 + 20) = uVar25;
                                                        }
                                                        uVar9 = LTCSVLoader.GetValueAt(lVar11,1,iVar22);
                                                        cVar4 = FUN_1816387f0(uVar9,"黑",0);
                                                        if (!cVar4) {
                                                          uVar9 = LTCSVLoader.GetValueAt(lVar11,1,iVar22)
                                                          ;
                                                          uVar9 = String.Concat("#",uVar9,0);
                                                          ColorUtility.TryParseHtmlString
                                                                    (uVar9,lVar12 + 36,0);
                                                        }
                                                        else {
                                                          *(uint8 *)(lVar12 + 32) = 1;
                                                        }
                                                        uVar9 = LTCSVLoader.GetValueAt(lVar11,2,iVar22);
                                                        GlobalData.LoadVector2(uVar9,0);
                                                        lVar12.Count = extraout_EAX;
                                                        lVar12._version = extraout_var;
                                                        if (this.bookTypeIconDataBase == null)
                                                        goto LAB_180bc3e85;
                                                        FUN_18175de30(this.bookTypeIconDataBase,
                                                                      lVar12,DAT_181e621f8);
                                                        iVar22 = iVar22 + 1;
                                                        } while (iVar22 < iVar6);
                                                        }
                                                        uVar9 = DAT_181ea28c0;
                                                        if (**(int **)(DAT_181e538e8 + 184) == 2) {
                                                          uVar9 = Type.GetTypeFromHandle(uVar9,0);
                                                          uVar9 = Resources.Load("GameData/CheckReplaceSkillIconList",uVar9,0);
                                                          lVar11 = FUN_180002180(uVar9,DAT_181e8af68);
                                                          if (lVar11 == null) goto LAB_180bc3e85;
                                                          uVar9 = FUN_180002180(uVar9,DAT_181e8af68);
                                                          uVar9 = FUN_180b00cb0(uVar9,0);
                                                          var lVar11 = new c.DisplayClass9_0(0);
                                                          if (lVar11 == null) goto LAB_180bc3e85;
                                                          LTCSVLoader.ReadMultiLine(lVar11,uVar9,0);
                                                          iVar6 = LTCSVLoader.GetRow(lVar11,0);
                                                          uVar9 = il2cpp_internal(DAT_181e6ffb8);
                                                          FUN_1810f3480(uVar9,DAT_181e5a220);
                                                          this.CheckReplaceSkillIconList = uVar9;
                                                          iVar22 = 1;
                                                          if (1 < iVar6) {
                                                            do {
                                                              lVar12 = this.CheckReplaceSkillIconList;
                                                              uVar9 = il2cpp_internal(DAT_181e73cb8);
                                                              FUN_1810f3480(uVar9,DAT_181e71270);
                                                              if (lVar12 == null) goto LAB_180bc3e85;
                                                              FUN_18175de30(lVar12,uVar9,DAT_181e5a330);
                                                              lVar12 = this.CheckReplaceSkillIconList;
                                                              if (lVar12 == null) goto LAB_180bc3e85;
                                                              lVar12 = FUN_180210940(lVar12,*(int *)(
                                                        lVar12 + 24) + -1,DAT_181e5a4c8);
                                                        uVar9 = LTCSVLoader.GetValueAt(lVar11,0,iVar22,0)
                                                        ;
                                                        uVar25 = GameDataController.GetSkillID
                                                                           (this,uVar9,0);
                                                        if (lVar12 == null) goto LAB_180bc3e85;
                                                        FUN_181769fe0(lVar12,uVar25,DAT_181e713f0);
                                                        lVar12 = this.CheckReplaceSkillIconList;
                                                        if (lVar12 == null) goto LAB_180bc3e85;
                                                        lVar12 = FUN_180210940(lVar12,*(int *)(lVar12 + 
                                                        24) + -1,DAT_181e5a4c8);
                                                        uVar9 = LTCSVLoader.GetValueAt(lVar11,1,iVar22);
                                                        uVar25 = GameDataController.GetSkillID
                                                                           (this,uVar9,0);
                                                        if (lVar12 == null) goto LAB_180bc3e85;
                                                        FUN_181769fe0(lVar12,uVar25,DAT_181e713f0);
                                                        iVar22 = iVar22 + 1;
                                                        } while (iVar22 < iVar6);
                                                        }
                                                        }
                                                        uVar9 = DAT_181ea28c0;
                                                        uVar9 = Type.GetTypeFromHandle(uVar9,0);
                                                        uVar9 = Resources.Load("GameData/AchievementData",uVar9,0);
                                                        lVar11 = FUN_180002180(uVar9,DAT_181e8af68);
                                                        if (lVar11 != null) {
                                                          uVar9 = FUN_180002180(uVar9,DAT_181e8af68);
                                                          uVar9 = FUN_180b00cb0(uVar9,0);
                                                          var lVar11 = new c.DisplayClass9_0(0);
                                                          if (lVar11 != null) {
                                                            LTCSVLoader.ReadMultiLine(lVar11,uVar9,0);
                                                            iVar6 = LTCSVLoader.GetRow(lVar11,0);
                                                            iVar22 = 1;
                                                            if (1 < iVar6) {
                                                              do {
                                                                lVar12 = il2cpp_internal(DAT_181e8a838
                                                                                            );
                                                                c__DisplayClass9_0.ctor(lVar12,0);
                                                                uVar9 = LTCSVLoader.GetValueAt
                                                                                  (lVar11,1,iVar22);
                                                                if (lVar12 == null) goto LAB_180bc3e85;
                                                                lVar12._items = uVar9;
                                                                il2cpp_internal((uint64 *)
                                                                                    (lVar12 + 16),uVar9)
                                                                ;
                                                                uVar9 = LTCSVLoader.GetValueAt
                                                                                  (lVar11,2,iVar22);
                                                                lVar12.Count = uVar9;
                                                                il2cpp_internal((uint64 *)
                                                                                    (lVar12 + 24),uVar9)
                                                                ;
                                                                lVar13 = LTCSVLoader.GetValueAt
                                                                                   (lVar11,3,iVar22);
                                                                if (lVar13 != null) {
                                                                  cVar4 = FUN_1816387f0(lVar13,
                                                        "int",0);
                                                        if (!cVar4) {
                                                          cVar4 = FUN_1816387f0(lVar13,"float",0);
                                                          if (!cVar4) {
                                                            cVar4 = FUN_1816387f0(lVar13,"bool",0);
                                                            if (cVar4) {
                                                              *(uint32 *)(lVar12 + 32) = 2;
                                                            }
                                                          }
                                                          else {
                                                            *(uint32 *)(lVar12 + 32) = 0;
                                                          }
                                                        }
                                                        else {
                                                          *(uint32 *)(lVar12 + 32) = 1;
                                                        }
                                                        }
                                                        uVar9 = LTCSVLoader.GetValueAt(lVar11,4,iVar22);
                                                        uVar15 = CultureInfo.get_InvariantCulture(0);
                                                        uVar25 = Single.Parse(uVar9,uVar15,0);
                                                        *(uint32 *)(lVar12 + 36) = uVar25;
                                                        uVar9 = LTCSVLoader.GetValueAt(lVar11,5,iVar22);
                                                        cVar4 = FUN_1816387f0(uVar9,"无",0);
                                                        uVar9 = "";
                                                        if (!cVar4) {
                                                          uVar9 = LTCSVLoader.GetValueAt(lVar11,5,iVar22)
                                                          ;
                                                        }
                                                        *(uint64 *)(lVar12 + 40) = uVar9;
                                                        il2cpp_internal((uint64 *)(lVar12 + 40),
                                                                            uVar9);
                                                        if (this.AchievementData == null)
                                                        goto LAB_180bc3e85;
                                                        FUN_18175de30(this.AchievementData,
                                                                      lVar12,DAT_181e5ce08);
                                                        iVar22 = iVar22 + 1;
                                                        } while (iVar22 < iVar6);
                                                        }
                                                        uVar9 = DAT_181ea28c0;
                                                        uVar9 = Type.GetTypeFromHandle(uVar9,0);
                                                        uVar9 = Resources.Load("GameData/TipsData",uVar9,0);
                                                        lVar11 = FUN_180002180(uVar9,DAT_181e8af68);
                                                        if (lVar11 != null) {
                                                          uVar9 = FUN_180002180(uVar9,DAT_181e8af68);
                                                          uVar9 = FUN_180b00cb0(uVar9,0);
                                                          var lVar11 = new c.DisplayClass9_0(0);
                                                          if (lVar11 != null) {
                                                            LTCSVLoader.ReadMultiLine(lVar11,uVar9,0);
                                                            iVar6 = LTCSVLoader.GetRow(lVar11,0);
                                                            iVar22 = 1;
                                                            if (1 < iVar6) {
                                                              do {
                                                                lVar12 = this.tipsData;
                                                                lVar13 = LTCSVLoader.GetValueAt
                                                                                   (lVar11,0,iVar22,0);
                                                                if ((lVar13 == null) ||
                                                                   (uVar9 = String.Replace(lVar13,
                                                        "\\n","\n"), lVar12 == null))
                                                        goto LAB_180bc3e85;
                                                        FUN_18175de30(lVar12,uVar9,DAT_181e86370);
                                                        iVar22 = iVar22 + 1;
                                                        } while (iVar22 < iVar6);
                                                        }
                                                        uVar9 = DAT_181ea28c0;
                                                        uVar9 = Type.GetTypeFromHandle(uVar9,0);
                                                        uVar9 = Resources.Load("GameData/LoveableSpeHero",uVar9,0);
                                                        lVar11 = FUN_180002180(uVar9,DAT_181e8af68);
                                                        if (lVar11 != null) {
                                                          uVar9 = FUN_180002180(uVar9,DAT_181e8af68);
                                                          uVar9 = FUN_180b00cb0(uVar9,0);
                                                          var lVar11 = new c.DisplayClass9_0(0);
                                                          if (lVar11 != null) {
                                                            LTCSVLoader.ReadMultiLine(lVar11,uVar9,0);
                                                            iVar6 = LTCSVLoader.GetRow(lVar11,0);
                                                            iVar22 = 1;
                                                            if (1 < iVar6) {
                                                              do {
                                                                lVar12 = this.loveableSpeHeroList;
                                                                uVar9 = LTCSVLoader.GetValueAt
                                                                                  (lVar11,0,iVar22,0);
                                                                if (lVar12 == null) goto LAB_180bc3e85;
                                                                FUN_18175de30(lVar12,uVar9,DAT_181e86370);
                                                                iVar22 = iVar22 + 1;
                                                              } while (iVar22 < iVar6);
                                                            }
                                                            uVar9 = DAT_181ea28c0;
                                                            uVar9 = Type.GetTypeFromHandle(uVar9,0);
                                                            uVar9 = Resources.Load("GameData/MartialClubData",uVar9,0)
                                                            ;
                                                            lVar11 = FUN_180002180(uVar9,DAT_181e8af68);
                                                            if (lVar11 != null) {
                                                              uVar9 = FUN_180002180(uVar9,DAT_181e8af68);
                                                              uVar9 = FUN_180b00cb0(uVar9,0);
                                                              var lVar11 = new c.DisplayClass9_0(0);
                                                              if (lVar11 != null) {
                                                                LTCSVLoader.ReadMultiLine(lVar11,uVar9,0)
                                                                ;
                                                                iVar6 = LTCSVLoader.GetRow(lVar11,0);
                                                                iVar22 = 1;
                                                                if (1 < iVar6) {
                                                                  do {
                                                                    lVar12 = il2cpp_internal(
                                                        DAT_181e68470);
                                                        MartialClubDataBase.ctor(lVar12,0);
                                                        uVar9 = LTCSVLoader.GetValueAt(lVar11,0,iVar22,0)
                                                        ;
                                                        if (lVar12 == null) goto LAB_180bc3e85;
                                                        lVar12.Count = uVar9;
                                                        il2cpp_internal((uint64 *)(lVar12 + 24),
                                                                            uVar9);
                                                        uVar9 = LTCSVLoader.GetValueAt(lVar11,1,iVar22);
                                                        *(uint64 *)(lVar12 + 32) = uVar9;
                                                        il2cpp_internal((uint64 *)(lVar12 + 32),
                                                                            uVar9);
                                                        lVar13 = LTCSVLoader.GetValueAt(lVar11,2,iVar22);
                                                        lVar14 = FUN_1801dfd90(DAT_181e81128,1);
                                                        if (lVar14 == null) goto LAB_180bc3e85;
                                                        if (*(int *)(lVar14 + 24) == 0) {
                                                          uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                          FUN_1801e02d0(uVar9,0);
                                                        }
                                                        *(uint16 *)(lVar14 + 32) = 59;
                                                        if (lVar13 == null) goto LAB_180bc3e85;
                                                        lVar13 = String.Split(lVar13,lVar14,0);
                                                        iVar24 = 0;
                                                        while( true ) {
                                                          if (lVar13 == null) goto LAB_180bc3e85;
                                                          if (lVar13.entries <= iVar24) break;
                                                          lVar14 = *(int64 *)(lVar12 + 40);
                                                          uVar9 = FUN_180002230(lVar13,(int64)iVar24);
                                                          uVar25 = Int32.Parse(uVar9,0);
                                                          if (lVar14 == null) goto LAB_180bc3e85;
                                                          FUN_181769fe0(lVar14,uVar25,DAT_181e713f0);
                                                          iVar24 = iVar24 + 1;
                                                        }
                                                        if (this.martialclubDataBase == null)
                                                        goto LAB_180bc3e85;
                                                        FUN_18175de30(this.martialclubDataBase,
                                                                      lVar12,DAT_181e75af0);
                                                        iVar22 = iVar22 + 1;
                                                        } while (iVar22 < iVar6);
                                                        }
                                                        GameDataController.LoadPeotryData(this,0);
                                                        GameDataController.LoadBattleData(this,0);
                                                        return;
                                                        }
                                                        }
                                                        }
                                                        }
                                                        }
                                                        }
                                                        }
                                                        }
                                                        }
                                                        }
                                                        }
                                                        }
                                                        }
                                                        }
                                                        }
                                                        }
                                                        }
                                                        }
                                                        }
                                                        }
                                                        }
                                                        }
                                                        }
                                                        }
                                                        }
                                                        }
                                                        }
                                                        }
                                                        }
                                                        }
                                                        }
                                                        }
                                                        }
                                                        }
                                                        }
                                                        }
                                                        }
                                                        }
                                                        }
                                                        }
                                                      }
                                                    }
                                                  }
                                                }
                                              }
                                            }
                                          }
                                        }
                                      }
                                    }
                                  }
                                }
                              }
                            }
                          }
                        }
                      }
                    }
                  }
                }
              }
            }
          }
        }
        LAB_180bc3e85:
                          // WARNING: Subroutine does not return
        FUN_1801e0300();
        LAB_180bc2ddf:
        local_res18 = local_res18 + 1;
        lVar12 = local_f8;
        goto LAB_180bc2240;
    }

    // Token : 0x60016E3
    // RVA   : 0xBC40C0   Offset: 0xBC2EC0   Length: 0xA6B
    private void LoadBattleData()
    {
        bool cVar1;
        byte uVar2;
        int iVar3;
        ulong uVar4;
        long lVar6;
        long lVar7;
        long lVar8;
        ulong uVar9;
        int iVar11;
        uint uVar13;
        int[] local_res18 = new int[2];
        uint[] local_res20 = new uint[2];
        uVar4 = DAT_181ea28c0;
        plVar10 = (int64 *)0;
        local_res20[0] = 0;
        local_res18[0] = 0;
        uVar4 = Type.GetTypeFromHandle(uVar4,0);
        plVar5 = (int64 *)Resources.Load("GameData/BattleData",uVar4,0);
        if (plVar5 != (int64 *)0) {
        }
        cVar1 = Object.op_Equality(plVar10,0,0);
        if (cVar1) {
          Debug.LogError("缺少战斗配置表 Resources/GameData/BattleData.csv",0);
          uVar4 = il2cpp_internal(DAT_181e607d8);
          FUN_1806e5bc0(uVar4,DAT_181e99250);
          this.BattleDataBase = uVar4;
          return;
        }
        if (plVar10 != (int64 *)0) {
          uVar4 = FUN_180b00cb0(plVar10,0);
          lVar6 = new c.DisplayClass9_0(0);
          if (lVar6 != null) {
            LTCSVLoader.ReadMultiLine(lVar6,uVar4,0);
            iVar3 = LTCSVLoader.GetRow(lVar6,0);
            uVar4 = il2cpp_internal(DAT_181e607d8);
            FUN_1806e5bc0(uVar4,DAT_181e99250);
            this.BattleDataBase = uVar4;
            iVar11 = 1;
            do {
              if (iVar3 <= iVar11) {
                return;
              }
              lVar7 = GameDataController.GetBattleCsvValue(this,lVar6,0,iVar11,0);
              if (lVar7 == null) {
                          // WARNING: Subroutine does not return
                FUN_1801e0300();
              }
              uVar4 = String.Trim(lVar7,0);
              cVar1 = FUN_180ad1200(uVar4,0);
              if (!cVar1) {
                local_res20[0] = Int32.Parse(uVar4,0);
                if (this.BattleDataBase == null) {
                          // WARNING: Subroutine does not return
                  FUN_1801e0300();
                }
                cVar1 = FUN_1806da450(this.BattleDataBase,local_res20[0],DAT_181e99360);
                if (!cVar1) {
                  lVar7 = new BattleData(0);
                  if (lVar7 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1801e0300();
                  }
                  *(uint32 *)(lVar7 + 16) = local_res20[0];
                  uVar4 = GameDataController.GetBattleCsvValue(this,lVar6,1,iVar11,0);
                  *(uint64 *)(lVar7 + 24) = uVar4;
                  lVar8 = GameDataController.GetBattleCsvValue(this,lVar6,2,iVar11,0);
                  if (lVar8 == null) {
        LAB_180bc44b7:
                    local_res18[0] = iVar11 + 1;
                    uVar4 = Int32.ToString(local_res18,0);
                    uVar9 = GameDataController.GetBattleCsvValue(this,lVar6,2,iVar11,0);
                    uVar4 = String.Concat("BattleData 第",uVar4,"行战斗类型错误: ",uVar9,0);
                    Debug.LogError(uVar4,0);
                  }
                  else {
                    cVar1 = FUN_1816387f0(lVar8,"切磋",0);
                    if (!cVar1) {
                      cVar1 = FUN_1816387f0(lVar8,"恶斗",0);
                      if (!cVar1) {
                        cVar1 = FUN_1816387f0(lVar8,"决战",0);
                        if (!cVar1) goto LAB_180bc44b7;
                        *(uint32 *)(lVar7 + 32) = 2;
                      }
                      else {
                        *(uint32 *)(lVar7 + 32) = 1;
                      }
                    }
                    else {
                      *(uint32 *)(lVar7 + 32) = 0;
                    }
                  }
                  uVar4 = GameDataController.GetBattleCsvValue(this,lVar6,3,iVar11,0);
                  *(uint64 *)(lVar7 + 40) = uVar4;
                  uVar4 = GameDataController.GetBattleCsvValue(this,lVar6,4,iVar11,0);
                  *(uint64 *)(lVar7 + 48) = uVar4;
                  uVar4 = GameDataController.GetBattleCsvValue(this,lVar6,5,iVar11,0);
                  *(uint64 *)(lVar7 + 56) = uVar4;
                  uVar4 = GameDataController.GetBattleCsvValue(this,lVar6,6,iVar11,0);
                  *(uint64 *)(lVar7 + 64) = uVar4;
                  uVar4 = GameDataController.GetBattleCsvValue(this,lVar6,7,iVar11,0);
                  *(uint64 *)(lVar7 + 72) = uVar4;
                  uVar4 = GameDataController.GetBattleCsvValue(this,lVar6,8,iVar11,0);
                  cVar1 = FUN_180ad1200(uVar4,0);
                  if (!cVar1) {
                    uVar13 = BattleConfigExecutor.ParseCellFloat(uVar4,0);
                  }
                  else {
                    uVar13 = 0x40a00000;
                  }
                  *(uint32 *)(lVar7 + 80) = uVar13;
                  uVar4 = GameDataController.GetBattleCsvValue(this,lVar6,9,iVar11,0);
                  cVar1 = FUN_180ad1200(uVar4,0);
                  if (!cVar1) {
                    uVar13 = BattleConfigExecutor.ParseCellInt(uVar4,0);
                  }
                  else {
                    uVar13 = 0xffffffff;
                  }
                  *(uint32 *)(lVar7 + 84) = uVar13;
                  uVar4 = GameDataController.GetBattleCsvValue(this,lVar6,10,iVar11,0);
                  cVar1 = FUN_180ad1200(uVar4,0);
                  if (!cVar1) {
                    uVar13 = BattleConfigExecutor.ParseCellFloat(uVar4,0);
                  }
                  else {
                    uVar13 = 0;
                  }
                  *(uint32 *)(lVar7 + 88) = uVar13;
                  uVar4 = GameDataController.GetBattleCsvValue(this,lVar6,11,iVar11,0);
                  uVar2 = FUN_1816387f0(uVar4,"1",0);
                  *(uint8 *)(lVar7 + 92) = uVar2;
                  uVar4 = GameDataController.GetBattleCsvValue(this,lVar6,12,iVar11,0);
                  uVar2 = FUN_1816387f0(uVar4,"1",0);
                  *(uint8 *)(lVar7 + 93) = uVar2;
                  uVar4 = GameDataController.GetBattleCsvValue(this,lVar6,13,iVar11,0);
                  *(uint64 *)(lVar7 + 96) = uVar4;
                  uVar4 = GameDataController.GetBattleCsvValue(this,lVar6,14,iVar11,0);
                  *(uint64 *)(lVar7 + 104) = uVar4;
                  uVar4 = GameDataController.GetBattleCsvValue(this,lVar6,15,iVar11,0);
                  *(uint64 *)(lVar7 + 112) = uVar4;
                  uVar4 = GameDataController.GetBattleCsvValue(this,lVar6,16,iVar11,0);
                  uVar2 = FUN_1816387f0(uVar4,"1",0);
                  *(uint8 *)(lVar7 + 120) = uVar2;
                  uVar4 = GameDataController.GetBattleCsvValue(this,lVar6,17,iVar11,0);
                  cVar1 = FUN_180ad1200(uVar4,0);
                  if (!cVar1) {
                    uVar13 = BattleConfigExecutor.ParseCellInt(uVar4,0);
                  }
                  else {
                    uVar13 = 0xffffffff;
                  }
                  *(uint32 *)(lVar7 + 124) = uVar13;
                  uVar4 = GameDataController.GetBattleCsvValue(this,lVar6,18,iVar11,0);
                  *(uint64 *)(lVar7 + 128) = uVar4;
                  lVar8 = GameDataController.GetBattleCsvValue(this,lVar6,19,iVar11,0);
                  cVar1 = FUN_1816387f0(lVar8,"0",0);
                  if (!cVar1) {
                    if (lVar8 == null) {
                          // WARNING: Subroutine does not return
                      FUN_1801e0300();
                    }
                    uVar4 = String.ToLower(lVar8,0);
                    cVar1 = FUN_1816387f0(uVar4,"false",0);
                    bVar12 = !cVar1;
                  }
                  else {
                    bVar12 = false;
                  }
                  *(bool *)(lVar7 + 121) = bVar12;
                  if (this.BattleDataBase == null) {
                          // WARNING: Subroutine does not return
                    FUN_1801e0300();
                  }
                  FUN_1806da2f0(this.BattleDataBase,*(uint32 *)(lVar7 + 16),lVar7,
                                DAT_181e992d8);
                }
                else {
                  local_res18[0] = iVar11 + 1;
                  uVar4 = Int32.ToString(local_res18,0);
                  uVar9 = Int32.ToString(local_res20,0);
                  uVar4 = String.Concat("BattleData 第",uVar4,"行战斗ID重复: ",uVar9,0);
                  Debug.LogError(uVar4,0);
                }
              }
              iVar11 = iVar11 + 1;
            } while( true );
          }
        }
    }

    // Token : 0x60016E4
    // RVA   : 0xBB8200   Offset: 0xBB7000   Length: 0x86
    private string GetBattleCsvValue(LTCSVLoader loader, int col, int row)
    {
        uint64
        GameDataController.GetBattleCsvValue
                (uint64 this,int64 loader,uint32 col,uint32 row)
        {
        int64 lVar1;
        uint64 uVar2;
        if (loader == null) {
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        lVar1 = LTCSVLoader.GetValueAt(loader,col,row,0);
        uVar2 = "";
        if (lVar1 != null) {
          uVar2 = String.Trim(lVar1,0);
        }
        return uVar2;
    }

    // Token : 0x60016E5
    // RVA   : 0xBB5570   Offset: 0xBB4370   Length: 0x486
    public void ChangeAchStats(int achID, float changeNum)
    {
        long lVar1;
        bool cVar2;
        int iVar3;
        ulong uVar4;
        ulong uVar5;
        long lVar6;
        float fVar7;
        uint[] local_res10 = new uint[2];
        local_res10[0] = achID;
        if ((GameController._instance != null) &&
           (lVar1 = GameController._instance.worldData) != null) {
          if (lVar1.relaxMode) {
            return;
          }
          if (*(int *)(*(int64 *)(DAT_181e538e8 + 184) + 12) != 0) {
            if ((GameController._instance == null) ||
               (lVar1 = GameController._instance.worldData) == null)
            throw; // [null/range check failed]
            if (lVar1.cheated) {
              return;
            }
          }
          if (((GameController._instance != null) &&
              (lVar1 = GameController._instance.worldData) != null) &&
             (lVar1 = lVar1.customDifficultyData) != null) {
            cVar2 = CustomDifficultyData.CanUnlockAchievement(lVar1,0);
            if (!cVar2) {
              return;
            }
            if (changeNum == null.0) {
              return;
            }
            lVar1 = this.AchievementData;
            lVar6 = (int64)(int)local_res10[0];
            if (lVar1 != null) {
              if (lVar1.Count <= local_res10[0]) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar1 = *(int64 *)(lVar1._items + 32 + lVar6 * 8);
              if (lVar1 != null) {
                if (lVar1.villageAreaID == null) {
                  lVar1 = GameController.difficultyExtraPoint;
                  if (lVar1 != null) {
                    lVar1 = lVar1._items;
                    uVar4 = Int32.ToString(local_res10,0);
                    uVar4 = String.Concat("AchData",uVar4,0);
                    lVar6 = GameController.difficultyExtraPoint;
                    if (lVar6 != null) {
                      lVar6 = *(int64 *)(lVar6 + 16);
                      uVar5 = Int32.ToString(local_res10,0);
                      uVar5 = String.Concat("AchData",uVar5,0);
                      if ((lVar6 != null) &&
                         (fVar7 = (float)PlayerPrefDictionary.GetFloat(lVar6,uVar5,0), lVar1 != null)) {
                        PlayerPrefDictionary.SetKey(lVar1,uVar4,fVar7 + changeNum,0);
                        goto LAB_180bb59c8;
                      }
                    }
                  }
                }
                else {
                  lVar1 = GameController.difficultyExtraPoint;
                  if (lVar1 != null) {
                    lVar1 = lVar1._items;
                    uVar4 = Int32.ToString(local_res10,0);
                    uVar4 = String.Concat("AchData",uVar4,0);
                    lVar6 = GameController.difficultyExtraPoint;
                    if (lVar6 != null) {
                      lVar6 = *(int64 *)(lVar6 + 16);
                      uVar5 = Int32.ToString(local_res10,0);
                      uVar5 = String.Concat("AchData",uVar5,0);
                      if ((lVar6 != null) &&
                         (iVar3 = PlayerPrefDictionary.GetInt(lVar6,uVar5,0), lVar1 != null)) {
                        PlayerPrefDictionary.SetKey(lVar1,uVar4,(int)((float)iVar3 + changeNum),0);
        LAB_180bb59c8:
                        GameDataController.CheckAch(this,local_res10[0],0);
                        return;
                      }
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x60016E6
    // RVA   : 0xBB5A00   Offset: 0xBB4800   Length: 0x43C
    public void CheckAch(int achID)
    {
        bool cVar1;
        int iVar2;
        ulong uVar3;
        long lVar4;
        long lVar5;
        float fVar6;
        uint[] local_res10 = new uint[2];
        local_res10[0] = achID;
        if (**(int **)(DAT_181e538e8 + 184) == 0) {
          uVar3 = SteamStatsAndAchievements.get_Instance(0);
          cVar1 = Object.op_Equality(uVar3,0,0);
          if (cVar1) {
            return;
          }
          lVar4 = SteamStatsAndAchievements.get_Instance(0);
          if (lVar4 == null) throw; // [null/range check failed]
          cVar1 = SteamStatsAndAchievements.SteamStatsReady(lVar4,0);
          if (!cVar1) {
            return;
          }
        }
        if (**(int **)(DAT_181e538e8 + 184) == 1) {
          cVar1 = RailManager.get_Initialized(0);
          if (!cVar1) {
            return;
          }
          lVar4 = WegameStatsAndAchievements.get_Instance(0);
          if (lVar4 == null) throw; // [null/range check failed]
          if (*(int64 *)(lVar4 + 40) == 0) {
            return;
          }
        }
        if (**(int **)(DAT_181e538e8 + 184) == 1) {
          lVar4 = WegameStatsAndAchievements.get_Instance(0);
          if (lVar4 == null) throw; // [null/range check failed]
          WegameStatsAndAchievements.AsyncTriggerAchievementProgress(lVar4,local_res10[0],0);
        }
        lVar4 = this.AchievementData;
        fVar6 = 0.0;
        lVar5 = (int64)(int)local_res10[0];
        if (lVar4 != null) {
          if (lVar4.Count <= local_res10[0]) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar4 = *(int64 *)(lVar4._items + 32 + lVar5 * 8);
          if (lVar4 != null) {
            if (*(int *)(lVar4 + 32) == 2) {
              lVar4 = GameController.difficultyExtraPoint;
              if (lVar4 != null) {
                lVar4 = lVar4._items;
                uVar3 = Int32.ToString(local_res10,0);
                uVar3 = String.Concat("AchData",uVar3,0);
                if (lVar4 != null) {
                  iVar2 = PlayerPrefDictionary.GetInt(lVar4,uVar3,0);
                  if ((float)iVar2 == 0.0) {
                    return;
                  }
        LAB_180bb5d8b:
                  GameDataController.UnlockAchievement(this,local_res10[0],0);
                  return;
                }
              }
            }
            else {
              lVar4 = this.AchievementData;
              lVar5 = (int64)(int)local_res10[0];
              if (lVar4 != null) {
                if (lVar4.Count <= local_res10[0]) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar4 = *(int64 *)(lVar4._items + 32 + lVar5 * 8);
                if (lVar4 != null) {
                  if (*(int *)(lVar4 + 32) == 0) {
                    lVar4 = GameController.difficultyExtraPoint;
                    if (lVar4 == null) throw; // [null/range check failed]
                    lVar4 = lVar4._items;
                    uVar3 = Int32.ToString(local_res10,0);
                    uVar3 = String.Concat("AchData",uVar3,0);
                    if (lVar4 == null) throw; // [null/range check failed]
                    fVar6 = (float)PlayerPrefDictionary.GetFloat(lVar4,uVar3,0);
                  }
                  else {
                    lVar4 = this.AchievementData;
                    lVar5 = (int64)(int)local_res10[0];
                    if (lVar4 == null) throw; // [null/range check failed]
                    if (lVar4.Count <= local_res10[0]) {
                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                    }
                    lVar4 = *(int64 *)(lVar4._items + 32 + lVar5 * 8);
                    if (lVar4 == null) throw; // [null/range check failed]
                    if (*(int *)(lVar4 + 32) == 1) {
                      lVar4 = GameController.difficultyExtraPoint;
                      if (lVar4 == null) throw; // [null/range check failed]
                      lVar4 = lVar4._items;
                      uVar3 = Int32.ToString(local_res10,0);
                      uVar3 = String.Concat("AchData",uVar3,0);
                      if (lVar4 == null) throw; // [null/range check failed]
                      iVar2 = PlayerPrefDictionary.GetInt(lVar4,uVar3,0);
                      fVar6 = (float)iVar2;
                    }
                  }
                  lVar4 = this.AchievementData;
                  lVar5 = (int64)(int)local_res10[0];
                  if (lVar4 != null) {
                    if (lVar4.Count <= local_res10[0]) {
                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                    }
                    lVar4 = *(int64 *)(lVar4._items + 32 + lVar5 * 8);
                    if (lVar4 != null) {
                      if (fVar6 < *(float *)(lVar4 + 36)) {
                        return;
                      }
                      goto LAB_180bb5d8b;
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x60016E7
    // RVA   : 0xBC9770   Offset: 0xBC8570   Length: 0x129
    public void UnlockAchievement(int achID)
    {
        ulong uVar1;
        long lVar2;
        uint[] local_res10 = new uint[6];
        local_res10[0] = achID;
        if (**(int **)(DAT_181e538e8 + 184) == 0) {
          lVar2 = SteamStatsAndAchievements.get_Instance(0);
          if (lVar2 != null) {
            SteamStatsAndAchievements.UnlockAchievement(lVar2,local_res10[0],0);
            return;
          }
        }
        else {
          lVar2 = *(int64 *)(*(int64 *)(DAT_181e528f8 + 184) + 8);
          if (lVar2 != null) {
            lVar2 = *(int64 *)(lVar2 + 16);
            uVar1 = Int32.ToString(local_res10,0);
            uVar1 = String.Concat("AchFinished",uVar1,0);
            if (lVar2 != null) {
              PlayerPrefDictionary.SetKey(lVar2,uVar1,"true",0);
              return;
            }
          }
        }
    }

    // Token : 0x60016E8
    // RVA   : 0xBB5E40   Offset: 0xBB4C40   Length: 0x3AD
    public void CheckAllAch()
    {
        long lVar1;
        bool cVar2;
        int iVar3;
        ulong uVar4;
        int[] local_res8 = new int[2];
        lVar1 = this.AchievementData;
        local_res8[0] = 0;
        while (lVar1 != null) {
          if (lVar1.Count <= local_res8[0]) {
            return;
          }
          lVar1 = GameController.difficultyExtraPoint;
          if (lVar1 == null) break;
          lVar1 = lVar1._items;
          uVar4 = Int32.ToString(local_res8,0);
          uVar4 = String.Concat("AchFinished",uVar4,0);
          if (lVar1 == null) break;
          uVar4 = PlayerPrefDictionary.GetString(lVar1,uVar4);
          cVar2 = String.op_Inequality(uVar4,"true");
          if (cVar2) {
            GameDataController.CheckAch(this,local_res8[0]);
          }
          lVar1 = GameController.difficultyExtraPoint;
          if (lVar1 == null) break;
          lVar1 = lVar1._items;
          uVar4 = Int32.ToString(local_res8,0);
          uVar4 = String.Concat("AchFinished",uVar4,0);
          if (lVar1 == null) break;
          uVar4 = PlayerPrefDictionary.GetString(lVar1,uVar4);
          cVar2 = FUN_1816387f0(uVar4);
          if (cVar2) {
            lVar1 = GameController.difficultyExtraPoint;
            if (lVar1 == null) break;
            lVar1 = lVar1._items;
            uVar4 = Int32.ToString(local_res8,0);
            uVar4 = String.Concat("AchRewarded",uVar4,0);
            if (lVar1 == null) break;
            cVar2 = PlayerPrefDictionary.ContainsKey(lVar1,uVar4);
            if (cVar2) {
              lVar1 = GameController.difficultyExtraPoint;
              if (lVar1 == null) break;
              lVar1 = lVar1._items;
              uVar4 = Int32.ToString(local_res8,0);
              uVar4 = String.Concat("AchRewarded",uVar4,0);
              if (lVar1 == null) break;
              uVar4 = PlayerPrefDictionary.GetString(lVar1,uVar4);
              cVar2 = String.op_Inequality(uVar4);
              if (!cVar2) goto LAB_180bb61c2;
            }

            if ((lVar1 = GameController.difficultyExtraPoint?._items) == null) break;
            iVar3 = PlayerPrefDictionary.GetInt(lVar1,"AchTagPoint",0);
            PlayerPrefDictionary.SetKey(lVar1,"AchTagPoint",iVar3 + 2,0);
            lVar1 = GameController.difficultyExtraPoint;
            if (lVar1 == null) break;
            lVar1 = lVar1._items;
            uVar4 = Int32.ToString(local_res8,0);
            String.Concat("AchRewarded",uVar4,0);
            if (lVar1 == null) break;
            PlayerPrefDictionary.SetKey(lVar1);
          }
        LAB_180bb61c2:
          local_res8[0] = local_res8[0] + 1;
          lVar1 = this.AchievementData;
        }
    }

    // Token : 0x60016E9
    // RVA   : 0xBC9D40   Offset: 0xBC8B40   Length: 0x699
    public void WriteGameDataCsv()
    {
        bool cVar1;
        ulong uVar2;
        long lVar3;
        long lVar6;
        ulong uVar7;
        ulong uVar9;
        int iVar10;
        uint[] local_res18 = new uint[2];
        uint[] local_res20 = new uint[2];
        byte[] local_50 = new byte[16];
        byte[] local_40 = new byte[24];
        iVar10 = 0;
        uVar2 = Application.get_streamingAssetsPath(0);
        uVar2 = String.Concat(uVar2,"/GameDataCsv.csv",0);
        lVar3 = new FileInfo(uVar2,0);
        if ((lVar3 != null) &&
           (plVar4 = (int64 *)FileInfo.get_Directory(lVar3,0), plVar4 != (int64 *)0)) {
          cVar1 = (**(code **)(*plVar4 + 0x1c8))(plVar4,*(uint64 *)(*plVar4 + 0x1d0));
          if (!cVar1) {
            lVar3 = FileInfo.get_Directory(lVar3,0);
            if (lVar3 == null) throw; // [null/range check failed]
            DirectoryInfo.Create(lVar3,0);
          }
          plVar4 = (int64 *)il2cpp_internal(DAT_181ea78f0);
          FileStream.ctor(plVar4,uVar2,2,2,0);
          uVar2 = Encoding.get_UTF8(0);
          plVar5 = (int64 *)il2cpp_internal(DAT_181e879e8);
          StreamWriter.ctor(plVar5,plVar4,uVar2,0);
          while( true ) {
            if (GameController._instance == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            lVar3 = GameController._instance.worldData;
            if (lVar3 == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            lVar3 = lVar3.Inns;
            if (lVar3 == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            if (lVar3.cityAreaID <= iVar10) {
              if (plVar5 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                FUN_1801e0300();
              }
              (**(code **)(*plVar5 + 0x1b8))(plVar5,*(uint64 *)(*plVar5 + 0x1c0));
              if (plVar4 != (int64 *)0) {
                (**(code **)(*plVar4 + 0x238))(plVar4,*(uint64 *)(*plVar4 + 0x240));
                FUN_180002280(0,DAT_181e58ab8,plVar5);
                if (plVar4 != (int64 *)0) {
                  FUN_180002280(0,DAT_181e58ab8,plVar4);
                }
                return;
              }
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            lVar3 = FUN_1802106e0(0);
            if (lVar3 == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            if (lVar3.villageAreaID == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            lVar3 = *(int64 *)(lVar3.villageAreaID + 56);
            if (lVar3 == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            lVar3 = FUN_1800024b0(lVar3,iVar10,DAT_181e70e70);
            if (lVar3 == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            uVar2 = lVar3.cityAreaID;
            lVar3 = FUN_180210220(0);
            if (lVar3 == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            if (lVar3.ResourcePoints == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            lVar3 = GameObject.get_transform(lVar3.ResourcePoints,0);
            if (lVar3 == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            lVar3 = Transform.Find(lVar3,"Inn",0);
            lVar6 = FUN_1802106e0(0);
            if (lVar6 == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            if (*(int64 *)(lVar6 + 32) == 0) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            lVar6 = *(int64 *)(*(int64 *)(lVar6 + 32) + 56);
            if (lVar6 == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            lVar6 = FUN_1800024b0(lVar6,iVar10,DAT_181e70e70);
            if (lVar6 == null) break;
            uVar7 = Int32.ToString(lVar6 + 16,0);
            uVar7 = String.Concat("InnIcon",uVar7,0);
            if (lVar3 == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            lVar3 = Transform.Find(lVar3,uVar7,0);
            if (lVar3 == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            puVar8 = (uint32 *)Transform.get_localPosition(local_50,lVar3,0);
            local_res18[0] = *puVar8;
            uVar7 = il2cpp_value_box(DAT_181e82730,local_res18);
            lVar3 = FUN_180210220(0);
            if (lVar3 == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            if (lVar3.ResourcePoints == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            lVar3 = GameObject.get_transform(lVar3.ResourcePoints,0);
            if (lVar3 == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            lVar3 = Transform.Find(lVar3,"Inn",0);
            lVar6 = FUN_1802106e0(0);
            if (lVar6 == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            if (*(int64 *)(lVar6 + 32) == 0) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            lVar6 = *(int64 *)(*(int64 *)(lVar6 + 32) + 56);
            if (lVar6 == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            lVar6 = FUN_1800024b0(lVar6,iVar10,DAT_181e70e70);
            if (lVar6 == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            uVar9 = Int32.ToString(lVar6 + 16,0);
            uVar9 = String.Concat("InnIcon",uVar9,0);
            if (lVar3 == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            lVar3 = Transform.Find(lVar3,uVar9,0);
            if (lVar3 == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            lVar3 = Transform.get_localPosition(local_40,lVar3,0);
            local_res20[0] = *(uint32 *)(lVar3 + 4);
            uVar9 = il2cpp_value_box(DAT_181e82730,local_res20);
            uVar2 = String.Format("{0},{1};{2}",uVar2,uVar7,uVar9,0);
            if (plVar5 == (int64 *)0) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            (**(code **)(*plVar5 + 0x278))(plVar5,uVar2,*(uint64 *)(*plVar5 + 0x280));
            iVar10 = iVar10 + 1;
          }
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
    }

    // Token : 0x60016EA
    // RVA   : 0xBB9490   Offset: 0xBB8290   Length: 0x320
    public int GetTagID(string tagName)
    {
        bool cVar1;
        long lVar2;
        int iVar3;
        int iVar4;
        int iVar5;
        int[] aiStack_64 = new int[5];
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
        iVar4 = 0;
        aiStack_64[3] = 0;
        if (this.heroTagDataBase != null) {
          lVar2 = FUN_1806e0520(this.heroTagDataBase,DAT_181e9ba98);
          if (lVar2 != null) {
            ValueCollection.GetEnumerator(&local_38,lVar2,DAT_181e61328);
            local_50 = local_38;
            uStack_4c = uStack_34;
            uStack_48 = uStack_30;
            uStack_44 = uStack_2c;
            local_40 = local_28;
            do {
              cVar1 = FUN_180dd6250(&local_50,DAT_181e7a6b0);
              lVar2 = local_40;
              if (!cVar1) {
                aiStack_64[1] = 75;
                iVar5 = aiStack_64[3] + 1;
                aiStack_64[3] = iVar5;
                ZhSegment.Initialize(&local_50,DAT_181e7a630);
                goto LAB_180bb9647;
              }
              if (local_40 == 0) {
                          // WARNING: Subroutine does not return
                FUN_1801e0300();
              }
              cVar1 = FUN_1816387f0(*(uint64 *)(local_40 + 24),tagName,0);
            } while (!cVar1);
            iVar4 = lVar2.chapter;
            aiStack_64[1] = 150;
            iVar5 = aiStack_64[3] + 1;
            aiStack_64[3] = iVar5;
            ZhSegment.Initialize(&local_50,DAT_181e7a630);
        LAB_180bb9647:
            iVar3 = 0;
            if ((iVar5 != 0) && (iVar3 = 0, aiStack_64[iVar5] == 150)) {
              return iVar4;
            }
            while( true ) {
              if (((GameController._instance == null) ||
                  (lVar2 = GameController._instance.worldData) == null) ||
                 (lVar2 = lVar2.tempTagDataBase) == null) break;
              if (lVar2.cityAreaID <= iVar3) {
                return -1;
              }
              lVar2 = FUN_1802106e0(0);
              if (((lVar2 == null) || (lVar2.villageAreaID == null)) ||
                 (lVar2 = *(int64 *)(lVar2.villageAreaID + 0x1e0)) == null) break;
              lVar2 = FUN_1800024b0(lVar2,iVar3,DAT_181e6eaf0);
              if (lVar2 == null) break;
              cVar1 = FUN_1816387f0(lVar2.cityAreaID,tagName,0);
              if (cVar1) {
                return iVar3 + 10000;
              }
              iVar3 = iVar3 + 1;
            }
          }
        }
    }

    // Token : 0x60016EB
    // RVA   : 0xBC5B80   Offset: 0xBC4980   Length: 0x17E2
    public KungfuSkillData LoadSkillData(LTCSVLoader loader, int i, bool _summonSkill)
    {
        var pStatics = *(int64*)(DAT_181e538e8 + 184);
        int64 GameDataController.LoadSkillData
                         (int64 this,int64 loader,uint32 i,uint8 _summonSkill)
        {
        char cVar1;
        uint8 uVar2;
        uint32 uVar3;
        uint32 uVar4;
        uint32 uVar5;
        uint32 uVar6;
        int iVar7;
        int64 lVar8;
        uint64 uVar9;
        uint64 uVar10;
        int64 lVar11;
        uint64 uVar12;
        int64 lVar13;
        int64 *plVar14;
        int64 *plVar15;
        uint32 *puVar16;
        int64 lVar17;
        uint32 *puVar18;
        float fVar19;
        uint64 in_stack_ffffffffffffffb8;
        uint64 uVar20;
        var lVar8 = new KungfuSkillData(0);
        if ((lVar8 == null) || (*(uint8 *)(lVar8 + 16) = _summonSkill, loader == null)) goto LAB_180bc71fa;
        uVar9 = LTCSVLoader.GetValueAt(loader,0,i,0);
        uVar3 = Int32.Parse(uVar9,0);
        *(uint32 *)(lVar8 + 20) = uVar3;
        lVar11 = *(int64 *)(pStatics + 0x4a8);
        uVar9 = LTCSVLoader.GetValueAt(loader,1,i);
        if (lVar11 == null) goto LAB_180bc71fa;
        uVar3 = FUN_181662a20(lVar11,uVar9,DAT_181e865f0);
        *(uint32 *)(lVar8 + 48) = uVar3;
        uVar9 = LTCSVLoader.GetValueAt(loader,2,i);
        uVar3 = Int32.Parse(uVar9,0);
        *(uint32 *)(lVar8 + 52) = uVar3;
        uVar9 = LTCSVLoader.GetValueAt(loader,3,i);
        *(uint64 *)(lVar8 + 32) = uVar9;
        uVar9 = LTCSVLoader.GetValueAt(loader,4,i);
        *(uint64 *)(lVar8 + 40) = uVar9;
        uVar9 = LTCSVLoader.GetValueAt(loader,5,i);
        Single.TryParse(uVar9,lVar8 + 60,0);
        uVar9 = LTCSVLoader.GetValueAt(loader,6,i);
        uVar3 = Single.Parse(uVar9,0);
        *(uint32 *)(lVar8 + 64) = uVar3;
        uVar9 = LTCSVLoader.GetValueAt(loader,7,i);
        cVar1 = String.op_Inequality(uVar9,"",0);
        if (!cVar1) {
          var uVar9 = new HeroSpeAddData(0);
        }
        else {
          uVar9 = LTCSVLoader.GetValueAt(loader,7,i);
          uVar9 = GameDataController.StringToSpeAddData(this,uVar9,0);
        }
        *(uint64 *)(lVar8 + 88) = uVar9;
        uVar9 = LTCSVLoader.GetValueAt(loader,8,i);
        cVar1 = String.op_Inequality(uVar9,"",0);
        if (!cVar1) {
          var uVar9 = new HeroSpeAddData(0);
          *(uint64 *)(lVar8 + 96) = uVar9;
        }
        else {
          uVar9 = LTCSVLoader.GetValueAt(loader,8,i);
          uVar9 = GameDataController.StringToSpeAddData(this,uVar9,0);
          *(uint64 *)(lVar8 + 96) = uVar9;
          if (*(int64 *)(lVar8 + 96) == 0) goto LAB_180bc71fa;
          fVar19 = (float)HeroSpeAddData.Get(*(int64 *)(lVar8 + 96),59,0);
          if (fVar19 != 0.0) {
            lVar11 = *(int64 *)(lVar8 + 96);
            if (lVar11 == null) goto LAB_180bc71fa;
            HeroSpeAddData.Get(lVar11,59,0);
            HeroSpeAddData.Set(lVar11,59);
          }
        }
        uVar9 = LTCSVLoader.GetValueAt(loader,9,i);
        cVar1 = String.op_Inequality(uVar9,"",0);
        uVar9 = 0;
        if (cVar1) {
          uVar9 = LTCSVLoader.GetValueAt(loader,9,i);
          uVar9 = GameDataController.StringToAttriRatio(this,uVar9,0);
        }
        *(uint64 *)(lVar8 + 72) = uVar9;
        uVar9 = LTCSVLoader.GetValueAt(loader,10,i);
        cVar1 = String.op_Inequality(uVar9,"",0);
        if (!cVar1) {
          *(uint64 *)(lVar8 + 80) = 0;
        }
        else {
          uVar9 = LTCSVLoader.GetValueAt(loader,10,i);
          cVar1 = FUN_1816387f0(uVar9,"auto",0);
          if (!cVar1) {
            uVar9 = LTCSVLoader.GetValueAt(loader,10,i);
            uVar9 = GameDataController.StringToAttriRatio(this,uVar9,0);
            *(uint64 *)(lVar8 + 80) = uVar9;
          }
          else {
            var uVar9 = new AttriNumData(0);
            *(uint64 *)(lVar8 + 80) = uVar9;
            if (*(int64 *)(lVar8 + 80) == 0) goto LAB_180bc71fa;
            lVar11 = *(int64 *)(*(int64 *)(lVar8 + 80) + 24);
            uVar3 = *(uint32 *)(lVar8 + 48);
            lVar13 = *(int64 *)(pStatics + 0x140);
            if (lVar13 == null) goto LAB_180bc71fa;
            if (*(uint32 *)(lVar13 + 24) <= *(uint32 *)(lVar8 + 52)) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            if (lVar11 == null) goto LAB_180bc71fa;
            FUN_181769c70(lVar11,uVar3);
          }
        }
        uVar9 = 0;
        if (2 < *(int *)(lVar8 + 48)) {
          uVar10 = LTCSVLoader.GetValueAt(loader,11,i);
          cVar1 = String.op_Inequality(uVar10,"",0);
          uVar10 = uVar9;
          if (cVar1) {
            uVar10 = LTCSVLoader.GetValueAt(loader,11,i);
            uVar10 = GameDataController.StringToAttackRange(this,uVar10,0);
          }
          *(uint64 *)(lVar8 + 112) = uVar10;
          uVar10 = LTCSVLoader.GetValueAt(loader,12,i);
          cVar1 = String.op_Inequality(uVar10,"",0);
          if (cVar1) {
            lVar11 = LTCSVLoader.GetValueAt(loader,12,i);
            lVar13 = FUN_1801dfd90(DAT_181e81128,1);
            if (lVar13 == null) goto LAB_180bc71fa;
            if (*(int *)(lVar13 + 24) == 0) {
              uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar9,0);
            }
            *(uint16 *)(lVar13 + 32) = 44;
            if ((lVar11 == null) || (lVar11 = String.Split(lVar11,lVar13,0)) == null)
            goto LAB_180bc71fa;
            if (lVar11.Count == null) {
              uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar9,0);
            }
            uVar3 = Int32.Parse(*(uint64 *)(lVar11 + 32),0);
            if (lVar11.Count < 2) {
              uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar9,0);
            }
            uVar4 = Int32.Parse(*(uint64 *)(lVar11 + 40),0);
            if (lVar11.Count < 3) {
              uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar9,0);
            }
            uVar5 = Int32.Parse(*(uint64 *)(lVar11 + 48),0);
            uVar9 = il2cpp_internal(DAT_181e834a8);
            in_stack_ffffffffffffffb8 = 0;
            SkillDamageRangeData.ctor(uVar9,uVar3,uVar4,uVar5,0);
          }
          *(uint64 *)(lVar8 + 120) = uVar9;
          KungfuSkillData.RefreshMaxAttackRange(lVar8,0);
        }
        uVar9 = LTCSVLoader.GetValueAt(loader,13,i);
        cVar1 = String.op_Inequality(uVar9,"",0);
        if (cVar1) {
          uVar9 = LTCSVLoader.GetValueAt(loader,13,i);
          uVar9 = GameDataController.StringToSpeAddData(this,uVar9,0);
          *(uint64 *)(lVar8 + 104) = uVar9;
        }
        uVar9 = LTCSVLoader.GetValueAt(loader,14,i);
        cVar1 = String.op_Inequality(uVar9,"",0);
        if (cVar1) {
          uVar9 = LTCSVLoader.GetValueAt(loader,14,i);
          uVar3 = Single.Parse(uVar9,0);
          *(uint32 *)(lVar8 + 56) = uVar3;
        }
        uVar9 = LTCSVLoader.GetValueAt(loader,15,i);
        uVar3 = Int32.Parse(uVar9,0);
        *(uint32 *)(lVar8 + 24) = uVar3;
        if (2 < *(int *)(lVar8 + 48)) {
          uVar9 = LTCSVLoader.GetValueAt(loader,16,i);
          uVar3 = Int32.Parse(uVar9,0);
          *(uint32 *)(lVar8 + 28) = uVar3;
          lVar11 = LTCSVLoader.GetValueAt(loader,17,i);
          if (lVar11 != null) {
            uVar9 = LTCSVLoader.GetValueAt(loader,17,i);
            cVar1 = String.op_Inequality(uVar9,"",0);
            if (cVar1) {
              uVar9 = LTCSVLoader.GetValueAt(loader,17,i);
              uVar10 = Int32.ToString(lVar8 + 20,0);
              in_stack_ffffffffffffffb8 = 0;
              uVar10 = String.Concat(uVar10,"《",*(uint64 *)(lVar8 + 32),"》进攻",0);
              var uVar12 = new PartPostureData(uVar9,uVar10,0);
              *(uint64 *)(lVar8 + 136) = uVar12;
            }
          }
          lVar11 = LTCSVLoader.GetValueAt(loader,18,i);
          if (lVar11 != null) {
            uVar9 = LTCSVLoader.GetValueAt(loader,18,i);
            cVar1 = String.op_Inequality(uVar9,"",0);
            if (cVar1) {
              uVar9 = LTCSVLoader.GetValueAt(loader,18,i);
              uVar10 = Int32.ToString(lVar8 + 20,0);
              in_stack_ffffffffffffffb8 = 0;
              uVar10 = String.Concat(uVar10,"《",*(uint64 *)(lVar8 + 32),"》防御",0);
              var uVar12 = new PartPostureData(uVar9,uVar10,0);
              *(uint64 *)(lVar8 + 144) = uVar12;
            }
          }
          plVar15 = (int64 *)0;
          lVar11 = LTCSVLoader.GetValueAt(loader,19,i);
          if (lVar11 != null) {
            uVar9 = LTCSVLoader.GetValueAt(loader,19,i);
            cVar1 = String.op_Inequality(uVar9,"",0);
            if (cVar1) {
              uVar9 = LTCSVLoader.GetValueAt(loader,19,i);
              uVar3 = Int32.Parse(uVar9,0);
              *(uint32 *)(lVar8 + 128) = uVar3;
            }
          }
          lVar11 = LTCSVLoader.GetValueAt(loader,20,i);
          if (lVar11 != null) {
            uVar9 = LTCSVLoader.GetValueAt(loader,20,i);
            cVar1 = String.op_Inequality(uVar9,"",0);
            if (cVar1) {
              uVar9 = LTCSVLoader.GetValueAt(loader,20,i);
              uVar3 = Int32.Parse(uVar9,0);
              *(uint32 *)(lVar8 + 132) = uVar3;
            }
          }
          uVar9 = LTCSVLoader.GetValueAt(loader,21,i);
          *(uint64 *)(lVar8 + 160) = uVar9;
          lVar11 = LTCSVLoader.GetValueAt(loader,22,i);
          if (lVar11 == null) {
        LAB_180bc6ad9:
            *(uint64 *)(lVar8 + 168) = 0;
          }
          else {
            uVar9 = LTCSVLoader.GetValueAt(loader,22,i,0);
            cVar1 = String.op_Inequality(uVar9,"",0);
            if (!cVar1) goto LAB_180bc6ad9;
            lVar11 = LTCSVLoader.GetValueAt(loader,22,i,0);
            lVar13 = FUN_1801dfd90(DAT_181e81128,1);
            if (lVar13 == null) goto LAB_180bc71fa;
            if (*(int *)(lVar13 + 24) == 0) {
              uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar9,0);
            }
            *(uint16 *)(lVar13 + 32) = 45;
            if (lVar11 == null) goto LAB_180bc71fa;
            lVar13 = String.Split(lVar11,lVar13,0);
            lVar11 = this.SkillBulletDataBase;
            if (lVar13 == null) goto LAB_180bc71fa;
            if (*(int *)(lVar13 + 24) == 0) {
              uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar9,0);
            }
            uVar6 = Int32.Parse(*(uint64 *)(lVar13 + 32),0);
            if (lVar11 == null) goto LAB_180bc71fa;
            if (lVar11.Count <= uVar6) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar11 = lVar11._items[uVar6];
            if (lVar11 == null) goto LAB_180bc71fa;
            plVar14 = (int64 *)SkillBulletData.Clone(lVar11,0);
            if (plVar14 != (int64 *)0) {
            }
            plVar14 = (int64 *)(lVar8 + 168);
            *plVar14 = (int64)plVar15;
            il2cpp_internal(plVar14);
            uVar6 = 1;
            while ((int)uVar6 < (int)*(uint32 *)(lVar13 + 24)) {
              if (*(uint32 *)(lVar13 + 24) <= uVar6) {
                uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1801e02d0(uVar9,0);
              }
              cVar1 = FUN_180ad1200(lVar13[uVar6]);
              uVar10 = DAT_181ea0dc0;
              uVar9 = DAT_181ea0d38;
              if (!cVar1) {
                if (uVar6 == 1) {
                  lVar11 = *plVar14;
                  uVar9 = Type.GetTypeFromHandle(uVar9,0);
                  if (*(uint32 *)(lVar13 + 24) < 2) {
                    uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1801e02d0(uVar9,0);
                  }
                  uVar10 = *(uint64 *)(lVar13 + 40);
                  plVar15 = (int64 *)Enum.Parse(uVar9,uVar10,0);
                  if ((lVar11 != null) && (plVar15 != (int64 *)0)) {
                    if (*(int64 *)(*plVar15 + 64) != *(int64 *)(DAT_181e83328 + 64)) {
                          // WARNING: Subroutine does not return
                      FUN_1801dfd50(plVar15,DAT_181e83328);
                    }
                    puVar16 = (uint32 *)il2cpp_object_unbox();
                    lVar11.Count = *puVar16;
                    goto LAB_180bc6ad2;
                  }
                  goto LAB_180bc71fa;
                }
                if (uVar6 == 2) {
                  lVar11 = *plVar14;
                  if (*(uint32 *)(lVar13 + 24) < 3) {
                    uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1801e02d0(uVar9,0);
                  }
                  uVar3 = Single.Parse(*(uint64 *)(lVar13 + 48));
                  if (lVar11 == null) goto LAB_180bc71fa;
                  lVar11._version = uVar3;
                  uVar6 = 3;
                }
                else if (uVar6 == 3) {
                  lVar11 = *plVar14;
                  uVar9 = Type.GetTypeFromHandle(uVar10,0);
                  if (*(uint32 *)(lVar13 + 24) < 4) {
                    uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1801e02d0(uVar9,0);
                  }
                  uVar10 = *(uint64 *)(lVar13 + 56);
                  plVar15 = (int64 *)Enum.Parse(uVar9,uVar10,0);
                  if ((lVar11 == null) || (plVar15 == (int64 *)0)) goto LAB_180bc71fa;
                  if (*(int64 *)(*plVar15 + 64) != *(int64 *)(DAT_181e833a8 + 64)) {
                          // WARNING: Subroutine does not return
                    FUN_1801dfd50(plVar15,DAT_181e833a8);
                  }
                  puVar16 = (uint32 *)il2cpp_object_unbox();
                  uVar6 = 4;
                  *(uint32 *)(lVar11 + 32) = *puVar16;
                }
                else if (uVar6 == 4) {
                  lVar11 = *plVar14;
                  if (*(uint32 *)(lVar13 + 24) < 5) {
                    uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1801e02d0(uVar9,0);
                  }
                  uVar3 = Single.Parse(*(uint64 *)(lVar13 + 64));
                  if (lVar11 == null) goto LAB_180bc71fa;
                  *(uint32 *)(lVar11 + 36) = uVar3;
                  uVar6 = 5;
                }
                else {
                  if (uVar6 != 5) goto LAB_180bc6ad2;
                  lVar11 = *plVar14;
                  if (*(uint32 *)(lVar13 + 24) < 6) {
                    uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1801e02d0(uVar9,0);
                  }
                  uVar3 = Single.Parse(*(uint64 *)(lVar13 + 72));
                  if (lVar11 == null) goto LAB_180bc71fa;
                  *(uint32 *)(lVar11 + 40) = uVar3;
                  uVar6 = 6;
                }
              }
              else {
        LAB_180bc6ad2:
                uVar6 = uVar6 + 1;
              }
            }
          }
          lVar11 = LTCSVLoader.GetValueAt(loader,23,i);
          lVar13 = FUN_1801dfd90(DAT_181e81128,1);
          if (lVar13 == null) goto LAB_180bc71fa;
          if (*(int *)(lVar13 + 24) == 0) {
            uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar9,0);
          }
          *(uint16 *)(lVar13 + 32) = 59;
          if (lVar11 == null) goto LAB_180bc71fa;
          lVar11 = String.Split(lVar11,lVar13,0);
          uVar6 = 0;
          if (lVar11 == null) goto LAB_180bc71fa;
          while( true ) {
            uVar3 = (uint32)((uint64)in_stack_ffffffffffffffb8 >> 32);
            if ((int)lVar11.Count <= (int)uVar6) break;
            if (lVar11.Count <= uVar6) {
              uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar9,0);
            }
            lVar13 = lVar11[uVar6];
            lVar17 = FUN_1801dfd90(DAT_181e81128,1);
            if (lVar17 == null) goto LAB_180bc71fa;
            if (*(int *)(lVar17 + 24) == 0) {
              uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar9,0);
            }
            *(uint16 *)(lVar17 + 32) = 45;
            if (lVar13 == null) goto LAB_180bc71fa;
            lVar17 = String.Split(lVar13,lVar17,0);
            lVar13 = *(int64 *)(lVar8 + 176);
            if (lVar17 == null) goto LAB_180bc71fa;
            if (*(uint32 *)(lVar17 + 24) == 0) {
              uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar9,0);
            }
            uVar9 = *(uint64 *)(lVar17 + 32);
            if (*(uint32 *)(lVar17 + 24) < 2) {
              uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar9,0);
            }
            uVar2 = FUN_1816387f0(*(uint64 *)(lVar17 + 40),"Self",0);
            uVar10 = DAT_181ea0ed0;
            uVar10 = Type.GetTypeFromHandle(uVar10,0);
            if (*(uint32 *)(lVar17 + 24) < 3) {
              uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar9,0);
            }
            uVar12 = *(uint64 *)(lVar17 + 48);
            plVar15 = (int64 *)Enum.Parse(uVar10,uVar12,0);
            uVar10 = Type.GetTypeFromHandle(DAT_181ea0f58,0);
            if (*(uint32 *)(lVar17 + 24) < 4) {
              uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar9,0);
            }
            plVar14 = (int64 *)Enum.Parse(uVar10,*(uint64 *)(lVar17 + 56),0);
            uVar10 = il2cpp_internal(DAT_181e836a8);
            if (plVar14 == (int64 *)0) goto LAB_180bc71fa;
            if (*(int64 *)(*plVar14 + 64) != *(int64 *)(DAT_181e837a8 + 64)) {
                          // WARNING: Subroutine does not return
              FUN_1801dfd50(plVar14,DAT_181e837a8);
            }
            puVar16 = (uint32 *)il2cpp_object_unbox();
            if (plVar15 == (int64 *)0) goto LAB_180bc71fa;
            if (*(int64 *)(*plVar15 + 64) != *(int64 *)(DAT_181e83728 + 64)) {
                          // WARNING: Subroutine does not return
              FUN_1801dfd50(plVar15);
            }
            puVar18 = (uint32 *)il2cpp_object_unbox();
            in_stack_ffffffffffffffb8 = CONCAT44(uVar3,*puVar16);
            SkillSpeEffectData.ctor(uVar10,uVar9,uVar2,*puVar18,in_stack_ffffffffffffffb8,0);
            if (lVar13 == null) goto LAB_180bc71fa;
            FUN_18175de30(lVar13,uVar10,DAT_181e85330);
            uVar6 = uVar6 + 1;
          }
          uVar9 = LTCSVLoader.GetValueAt(loader,24,i);
          *(uint64 *)(lVar8 + 152) = uVar9;
          uVar9 = DAT_181ea0e48;
          uVar9 = Type.GetTypeFromHandle(uVar9,0);
          uVar10 = LTCSVLoader.GetValueAt(loader,25,i);
          plVar15 = (int64 *)Enum.Parse(uVar9,uVar10,0);
          if (plVar15 == (int64 *)0) goto LAB_180bc71fa;
          if (*(int64 *)(*plVar15 + 64) != *(int64 *)(DAT_181e83428 + 64)) {
                          // WARNING: Subroutine does not return
            FUN_1801dfd50(plVar15,DAT_181e83428);
          }
          puVar16 = (uint32 *)il2cpp_object_unbox();
          *(uint32 *)(lVar8 + 184) = *puVar16;
          uVar9 = LTCSVLoader.GetValueAt(loader,26,i);
          uVar2 = FUN_1816387f0(uVar9,"TRUE",0);
          *(uint8 *)(lVar8 + 188) = uVar2;
          uVar9 = LTCSVLoader.GetValueAt(loader,27,i);
          iVar7 = Int32.Parse(uVar9,0);
          *(int *)(lVar8 + 192) = iVar7;
          if (iVar7 == 0) {
            uVar3 = GlobalData.RandomRange(1,4,0);
            *(uint32 *)(lVar8 + 192) = uVar3;
          }
        }
        iVar7 = *(int *)(lVar8 + 48);
        if (iVar7 < 3) {
          if (iVar7 == 0) {
            *(uint32 *)(lVar8 + 28) = 2;
            lVar11 = il2cpp_internal(DAT_181e773a8);
            FUN_1810f3480(lVar11,DAT_181e84db0);
            var uVar9 = new SkillDamageRangeData(0,0,0,0);
            if (lVar11 == null) goto LAB_180bc71fa;
            FUN_18175de30(lVar11,uVar9,DAT_181e84e30);
            *(int64 *)(lVar8 + 112) = lVar11;
            uVar9 = il2cpp_internal(DAT_181e834a8);
            uVar20 = 0;
            SkillDamageRangeData.ctor(uVar9,0,0,0,0);
            *(uint64 *)(lVar8 + 120) = uVar9;
            *(uint64 *)(lVar8 + 160) = "cure";
            lVar11 = *(int64 *)(lVar8 + 176);
            uVar10 = il2cpp_internal(DAT_181e836a8);
            uVar9 = "真气喷";
          }
          else if (iVar7 == 1) {
            *(uint32 *)(lVar8 + 28) = 5;
            lVar11 = il2cpp_internal(DAT_181e773a8);
            FUN_1810f3480(lVar11,DAT_181e84db0);
            uVar6 = *(uint32 *)(lVar8 + 52);
            uVar3 = KungfuSkillData.GetDodgeRange(lVar8,0);
            var uVar9 = new SkillDamageRangeData(uVar6 & 1,0,uVar3,0);
            if (lVar11 == null) goto LAB_180bc71fa;
            FUN_18175de30(lVar11,uVar9,DAT_181e84e30);
            *(int64 *)(lVar8 + 112) = lVar11;
            uVar9 = il2cpp_internal(DAT_181e834a8);
            uVar20 = 0;
            SkillDamageRangeData.ctor(uVar9,0,0,0,0);
            *(uint64 *)(lVar8 + 120) = uVar9;
            *(uint64 *)(lVar8 + 160) = "jump_big";
            lVar11 = *(int64 *)(lVar8 + 176);
            uVar10 = il2cpp_internal(DAT_181e836a8);
            uVar9 = "紫圈";
          }
          else {
            if (iVar7 != 2) goto LAB_180bc71ae;
            *(uint32 *)(lVar8 + 28) = 2;
            lVar11 = il2cpp_internal(DAT_181e773a8);
            FUN_1810f3480(lVar11,DAT_181e84db0);
            var uVar9 = new SkillDamageRangeData(0,0,0,0);
            if (lVar11 == null) goto LAB_180bc71fa;
            FUN_18175de30(lVar11,uVar9,DAT_181e84e30);
            *(int64 *)(lVar8 + 112) = lVar11;
            uVar9 = il2cpp_internal(DAT_181e834a8);
            uVar20 = 0;
            SkillDamageRangeData.ctor(uVar9,0,0,0,0);
            *(uint64 *)(lVar8 + 120) = uVar9;
            *(uint64 *)(lVar8 + 160) = "skill0_2";
            lVar11 = *(int64 *)(lVar8 + 176);
            uVar10 = il2cpp_internal(DAT_181e836a8);
            uVar9 = "护盾";
          }
          SkillSpeEffectData.ctor(uVar10,uVar9,1,0,uVar20 & 0xffffffff00000000,0);
          if (lVar11 == null) {
        LAB_180bc71fa:
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          FUN_18175de30(lVar11,uVar10,DAT_181e85330);
        }
        LAB_180bc71ae:
        uVar9 = LTCSVLoader.GetValueAt(loader,28,i);
        uVar2 = FUN_1816387f0(uVar9,"1",0);
        *(uint8 *)(lVar8 + 200) = uVar2;
        return lVar8;
    }

    // Token : 0x60016EC
    // RVA   : 0xBB86F0   Offset: 0xBB74F0   Length: 0x213
    public int GetForceID(string forceName)
    {
        bool cVar1;
        long lVar2;
        int iVar3;
        uint uVar4;
        int[] aiStack_64 = new int[5];
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
        uVar4 = 0;
        aiStack_64[3] = 0;
        if (((forceName == null) || (cVar1 = FUN_1816387f0(forceName,"",0), cVar1)) ||
           (cVar1 = FUN_1816387f0(forceName,"无",0), cVar1)) {
          return 0xffffffff;
        }
        if ((this.forceDataBase == null) ||
           (lVar2 = FUN_1806e0520(this.forceDataBase,DAT_181e9add8)) == null) {
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        ValueCollection.GetEnumerator(&local_38,lVar2,DAT_181e611b0);
        local_50 = local_38;
        uStack_4c = uStack_34;
        uStack_48 = uStack_30;
        uStack_44 = uStack_2c;
        local_40 = local_28;
        do {
          cVar1 = FUN_180dd6250(&local_50,DAT_181e79f30);
          lVar2 = local_40;
          if (!cVar1) {
            aiStack_64[1] = 106;
            iVar3 = aiStack_64[3] + 1;
            aiStack_64[3] = iVar3;
            ZhSegment.Initialize(&local_50,DAT_181e79eb0);
            goto LAB_180bb88b9;
          }
          if (local_40 == 0) {
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          cVar1 = FUN_1816387f0(*(uint64 *)(local_40 + 24),forceName,0);
        } while (!cVar1);
        uVar4 = *(uint32 *)(lVar2 + 16);
        aiStack_64[1] = 108;
        iVar3 = aiStack_64[3] + 1;
        aiStack_64[3] = iVar3;
        ZhSegment.Initialize(&local_50,DAT_181e79eb0);
        LAB_180bb88b9:
        if (iVar3 == 0) {
          return 0xffffffff;
        }
        if (aiStack_64[iVar3] != 108) {
          return 0xffffffff;
        }
        return uVar4;
    }

    // Token : 0x60016ED
    // RVA   : 0xBC8D00   Offset: 0xBC7B00   Length: 0x4F3
    public AttriNumData StringToAttriRatio(string resource)
    {
        var pStatics = *(int64*)(DAT_181e538e8 + 184);
        bool cVar1;
        uint uVar2;
        long lVar3;
        long lVar4;
        ulong uVar5;
        ulong uVar6;
        long lVar7;
        long lVar8;
        uint uVar9;
        uint uVar10;
        lVar3 = new AttriNumData(0);
        lVar4 = FUN_1801dfd90(DAT_181e81128,1);
        if (lVar4 != null) {
          if (*(int *)(lVar4 + 24) == 0) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar5,0);
          }
          *(uint16 *)(lVar4 + 32) = 59;
          if (resource != null) {
            lVar4 = String.Split(resource,lVar4,0);
            uVar9 = 0;
            if (lVar4 != null) {
              while( true ) {
                if ((int)*(uint32 *)(lVar4 + 24) <= (int)uVar9) {
                  return lVar3;
                }
                if (*(uint32 *)(lVar4 + 24) <= uVar9) {
                  uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1801e02d0(uVar5,0);
                }
                uVar5 = lVar4[uVar9];
                uVar5 = Regex.Replace(uVar5,"[^\\u4e00-\\u9fa5]","",0);
                if (*(uint32 *)(lVar4 + 24) <= uVar9) {
                  uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1801e02d0(uVar5,0);
                }
                uVar6 = Regex.Replace(lVar4[uVar9],
                                       "[\\u4e00-\\u9fa5]","",0);
                uVar10 = Single.Parse(uVar6,0);
                lVar8 = *(int64 *)(pStatics + 0x4a0);
                if (lVar8 == null) break;
                cVar1 = FUN_18175e190(lVar8,uVar5,DAT_181e86470);
                if (!cVar1) {
                  lVar8 = *(int64 *)(pStatics + 0x4a8);
                  if (lVar8 == null) break;
                  cVar1 = FUN_18175e190(lVar8,uVar5,DAT_181e86470);
                  if (cVar1) {
                    if (lVar3 != null) {
                      lVar8 = *(int64 *)(lVar3 + 24);
                      lVar7 = *(int64 *)(pStatics + 0x4a8);
                      goto LAB_180bc9166;
                    }
                    break;
                  }
                  lVar8 = *(int64 *)(pStatics + 0x4b8);
                  if (lVar8 == null) break;
                  cVar1 = FUN_18175e190(lVar8,uVar5,DAT_181e86470);
                  if (cVar1) {
                    if (lVar3 != null) {
                      lVar8 = *(int64 *)(lVar3 + 32);
                      lVar7 = *(int64 *)(pStatics + 0x4b8);
                      goto LAB_180bc9166;
                    }
                    break;
                  }
                  cVar1 = FUN_1816387f0(uVar5,"生命",0);
                  if (!cVar1) {
                    cVar1 = FUN_1816387f0(uVar5,"体力",0);
                    if (!cVar1) {
                      cVar1 = FUN_1816387f0(uVar5,"内力",0);
                      if (!cVar1) {
                        cVar1 = FUN_1816387f0(uVar5,"魅力",0);
                        if (!cVar1) goto LAB_180bc9193;
                        if (lVar3 == null) break;
                        uVar9 = uVar9 + 1;
                        *(uint32 *)(lVar3 + 52) = uVar10;
                      }
                      else {
                        if (lVar3 == null) break;
                        uVar9 = uVar9 + 1;
                        *(uint32 *)(lVar3 + 48) = uVar10;
                      }
                    }
                    else {
                      if (lVar3 == null) break;
                      uVar9 = uVar9 + 1;
                      *(uint32 *)(lVar3 + 44) = uVar10;
                    }
                  }
                  else {
                    if (lVar3 == null) break;
                    uVar9 = uVar9 + 1;
                    *(uint32 *)(lVar3 + 40) = uVar10;
                  }
                }
                else {
                  if (lVar3 == null) break;
                  lVar8 = *(int64 *)(lVar3 + 16);
                  lVar7 = *(int64 *)(pStatics + 0x4a0);
        LAB_180bc9166:
                  if ((lVar7 == null) || (uVar2 = FUN_181662a20(lVar7,uVar5,DAT_181e865f0), lVar8 == null))
                  break;
                  FUN_181769c70(lVar8,uVar2,uVar10);
        LAB_180bc9193:
                  uVar9 = uVar9 + 1;
                }
              }
            }
          }
        }
    }

    // Token : 0x60016EE
    // RVA   : 0xBC8A80   Offset: 0xBC7880   Length: 0x275
    public List<SkillAttackRangeData> StringToAttackRange(string resource)
    {
        uint uVar1;
        uint uVar2;
        uint uVar3;
        long lVar4;
        long lVar5;
        long lVar6;
        long lVar7;
        ulong uVar8;
        uint uVar9;
        lVar4 = il2cpp_internal(DAT_181e773a8);
        FUN_1810f3480(lVar4,DAT_181e84db0);
        lVar5 = FUN_1801dfd90(DAT_181e81128,1);
        if (lVar5 != null) {
          if (*(int *)(lVar5 + 24) == 0) {
            uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar8,0);
          }
          *(uint16 *)(lVar5 + 32) = 59;
          if (resource != null) {
            lVar5 = String.Split(resource,lVar5,0);
            uVar9 = 0;
            if (lVar5 != null) {
              while( true ) {
                if ((int)*(uint32 *)(lVar5 + 24) <= (int)uVar9) {
                  return lVar4;
                }
                if (*(uint32 *)(lVar5 + 24) <= uVar9) {
                  uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1801e02d0(uVar8,0);
                }
                lVar7 = lVar5[uVar9];
                lVar6 = FUN_1801dfd90(DAT_181e81128,1);
                if (lVar6 == null) break;
                if (*(int *)(lVar6 + 24) == 0) {
                  uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1801e02d0(uVar8,0);
                }
                *(uint16 *)(lVar6 + 32) = 44;
                if ((lVar7 == null) || (lVar7 = String.Split(lVar7,lVar6,0)) == null) break;
                if (*(int *)(lVar7 + 24) == 0) {
                  uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1801e02d0(uVar8,0);
                }
                uVar1 = Int32.Parse(*(uint64 *)(lVar7 + 32),0);
                if (*(uint32 *)(lVar7 + 24) < 2) {
                  uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1801e02d0(uVar8,0);
                }
                uVar2 = Int32.Parse(*(uint64 *)(lVar7 + 40),0);
                if (*(uint32 *)(lVar7 + 24) < 3) {
                  uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1801e02d0(uVar8,0);
                }
                uVar3 = Int32.Parse(*(uint64 *)(lVar7 + 48),0);
                uVar8 = new SkillDamageRangeData(uVar1,uVar2,uVar3,0);
                if (lVar4 == null) break;
                FUN_18175de30(lVar4,uVar8);
                uVar9 = uVar9 + 1;
              }
            }
          }
        }
    }

    // Token : 0x60016EF
    // RVA   : 0xBC9200   Offset: 0xBC8000   Length: 0x15A
    public SkillDamageRangeData StringToDamageRange(string resource)
    {
        uint uVar1;
        uint uVar2;
        uint uVar3;
        long lVar4;
        ulong uVar5;
        lVar4 = FUN_1801dfd90(DAT_181e81128,1);
        if (lVar4 != null) {
          if (*(int *)(lVar4 + 24) == 0) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar5,0);
          }
          *(uint16 *)(lVar4 + 32) = 44;
          if (resource != null) {
            lVar4 = String.Split(resource,lVar4,0);
            if (lVar4 != null) {
              if (*(int *)(lVar4 + 24) == 0) {
                uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1801e02d0(uVar5,0);
              }
              uVar1 = Int32.Parse(*(uint64 *)(lVar4 + 32),0);
              if (1 < *(uint32 *)(lVar4 + 24)) {
                uVar2 = Int32.Parse(*(uint64 *)(lVar4 + 40),0);
                if (2 < *(uint32 *)(lVar4 + 24)) {
                  uVar3 = Int32.Parse(*(uint64 *)(lVar4 + 48),0);
                  uVar5 = new SkillDamageRangeData(uVar1,uVar2,uVar3,0);
                  return uVar5;
                }
                uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1801e02d0(uVar5,0);
              }
              uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar5,0);
            }
          }
        }
    }

    // Token : 0x60016F0
    // RVA   : 0xBC9360   Offset: 0xBC8160   Length: 0x2DB
    public HeroSpeAddData StringToSpeAddData(string resource)
    {
        bool cVar1;
        long lVar2;
        long lVar3;
        ulong uVar4;
        ulong uVar5;
        long lVar6;
        int iVar7;
        uint uVar8;
        long lVar9;
        uint uVar10;
        lVar2 = new HeroSpeAddData(0);
        lVar3 = FUN_1801dfd90(DAT_181e81128,1);
        if (lVar3 != null) {
          if (*(int *)(lVar3 + 24) == 0) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar4,0);
          }
          *(uint16 *)(lVar3 + 32) = 59;
          if (resource != null) {
            lVar3 = String.Split(resource,lVar3,0);
            uVar8 = 0;
            if (lVar3 != null) {
        LAB_180bc9480:
              do {
                if ((int)*(uint32 *)(lVar3 + 24) <= (int)uVar8) {
                  return lVar2;
                }
                lVar9 = (int64)(int)uVar8;
                if (*(uint32 *)(lVar3 + 24) <= uVar8) {
                  uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1801e02d0(uVar4,0);
                }
                uVar4 = *(uint64 *)(lVar3 + 32 + lVar9 * 8);
                uVar4 = Regex.Replace(uVar4,"[^\\u4e00-\\u9fa5]","",0);
                if (*(uint32 *)(lVar3 + 24) <= uVar8) {
                  uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1801e02d0(uVar4,0);
                }
                lVar6 = *(int64 *)(lVar3 + 32 + lVar9 * 8);
                if (lVar6 == null) break;
                uVar5 = String.Replace(lVar6,uVar4,**(uint64 **)(DAT_181e87ae8 + 184));
                iVar7 = 0;
                while( true ) {
                  lVar6 = this.speAddDataBase;
                  if (lVar6 == null) throw; // [null/range check failed]
                  if (lVar6.Count <= iVar7) {
                    if (*(uint32 *)(lVar3 + 24) <= uVar8) {
                      uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1801e02d0(uVar4,0);
                    }
                    uVar4 = String.Concat("StringToSpeAddData Error: ",*(uint64 *)(lVar3 + 32 + lVar9 * 8),0);
                    Debug.LogError(uVar4,0);
                    uVar8 = uVar8 + 1;
                    goto LAB_180bc9480;
                  }
                  lVar6 = FUN_1800024b0(lVar6,iVar7);
                  if (lVar6 == null) throw; // [null/range check failed]
                  cVar1 = FUN_1816387f0(uVar4);
                  if (cVar1) break;
                  iVar7 = iVar7 + 1;
                }
                uVar10 = Single.Parse(uVar5,0);
                if (lVar2 == null) break;
                HeroSpeAddData.Set(lVar2,iVar7,uVar10);
                uVar8 = uVar8 + 1;
              } while( true );
            }
          }
        }
    }

    // Token : 0x60016F1
    // RVA   : 0xBC4EA0   Offset: 0xBC3CA0   Length: 0x33E
    public void LoadMedFoodData(ItemData newMedData, LTCSVLoader loader, int i)
    {
        void GameDataController.LoadMedFoodData
                     (uint64 this,int64 newMedData,int64 loader,uint32 i)
        {
        int64 lVar1;
        uint32 uVar2;
        int iVar3;
        uint64 uVar4;
        if (loader != null) {
          uVar4 = LTCSVLoader.GetValueAt(loader,0,i,0);
          uVar2 = Int32.Parse(uVar4,0);
          if (newMedData != null) {
            *(uint32 *)(newMedData + 16) = uVar2;
            uVar4 = LTCSVLoader.GetValueAt(loader,1,i);
            *(uint64 *)(newMedData + 32) = uVar4;
            uVar4 = LTCSVLoader.GetValueAt(loader,2,i);
            *(uint64 *)(newMedData + 48) = uVar4;
            uVar4 = LTCSVLoader.GetValueAt(loader,3,i);
            uVar2 = Int32.Parse(uVar4,0);
            *(uint32 *)(newMedData + 60) = uVar2;
            if (*(int64 *)(newMedData + 104) != 0) {
              lVar1 = *(int64 *)(*(int64 *)(newMedData + 104) + 24);
              uVar4 = LTCSVLoader.GetValueAt(loader,4,i);
              iVar3 = Int32.Parse(uVar4,0);
              if (lVar1 != null) {
                *(float *)(lVar1 + 16) = (float)iVar3;
                if (*(int64 *)(newMedData + 104) != 0) {
                  lVar1 = *(int64 *)(*(int64 *)(newMedData + 104) + 24);
                  uVar4 = LTCSVLoader.GetValueAt(loader,5,i);
                  iVar3 = Int32.Parse(uVar4,0);
                  if (lVar1 != null) {
                    *(float *)(lVar1 + 20) = (float)iVar3;
                    if (*(int64 *)(newMedData + 104) != 0) {
                      lVar1 = *(int64 *)(*(int64 *)(newMedData + 104) + 24);
                      uVar4 = LTCSVLoader.GetValueAt(loader,6,i);
                      iVar3 = Int32.Parse(uVar4,0);
                      if (lVar1 != null) {
                        *(float *)(lVar1 + 24) = (float)iVar3;
                        if (*(int64 *)(newMedData + 104) != 0) {
                          lVar1 = *(int64 *)(*(int64 *)(newMedData + 104) + 24);
                          uVar4 = LTCSVLoader.GetValueAt(loader,7,i);
                          iVar3 = Int32.Parse(uVar4,0);
                          if (lVar1 != null) {
                            *(float *)(lVar1 + 28) = (float)iVar3;
                            if (*(int64 *)(newMedData + 104) != 0) {
                              lVar1 = *(int64 *)(*(int64 *)(newMedData + 104) + 24);
                              uVar4 = LTCSVLoader.GetValueAt(loader,8,i);
                              iVar3 = Int32.Parse(uVar4,0);
                              if (lVar1 != null) {
                                *(float *)(lVar1 + 32) = (float)iVar3;
                                if (*(int64 *)(newMedData + 104) != 0) {
                                  lVar1 = *(int64 *)(*(int64 *)(newMedData + 104) + 24);
                                  uVar4 = LTCSVLoader.GetValueAt(loader,9,i);
                                  iVar3 = Int32.Parse(uVar4,0);
                                  if (lVar1 != null) {
                                    *(float *)(lVar1 + 40) = (float)iVar3;
                                    if (*(int64 *)(newMedData + 104) != 0) {
                                      lVar1 = *(int64 *)(*(int64 *)(newMedData + 104) + 24);
                                      uVar4 = LTCSVLoader.GetValueAt(loader,10,i);
                                      iVar3 = Int32.Parse(uVar4,0);
                                      if (lVar1 != null) {
                                        *(float *)(lVar1 + 44) = (float)iVar3;
                                        if (*(int64 *)(newMedData + 104) != 0) {
                                          lVar1 = *(int64 *)(*(int64 *)(newMedData + 104) + 24);
                                          uVar4 = LTCSVLoader.GetValueAt(loader,11,i);
                                          iVar3 = Int32.Parse(uVar4,0);
                                          if (lVar1 != null) {
                                            *(float *)(lVar1 + 48) = (float)iVar3;
                                            lVar1 = *(int64 *)(newMedData + 104);
                                            uVar4 = LTCSVLoader.GetValueAt(loader,12,i);
                                            uVar2 = Int32.Parse(uVar4,0);
                                            if (lVar1 != null) {
                                              *(uint32 *)(lVar1 + 32) = uVar2;
                                              uVar4 = LTCSVLoader.GetValueAt(loader,13,i);
                                              uVar2 = Int32.Parse(uVar4,0);
                                              *(uint32 *)(newMedData + 56) = uVar2;
                                              uVar4 = LTCSVLoader.GetValueAt(loader,15,i);
                                              *(uint64 *)(newMedData + 40) = uVar4;
                                              return;
                                            }
                                          }
                                        }
                                      }
                                    }
                                  }
                                }
                              }
                            }
                          }
                        }
                      }
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x60016F2
    // RVA   : 0xBC4CE0   Offset: 0xBC3AE0   Length: 0x1BE
    public void LoadHorseData(ItemData newHorseData, LTCSVLoader loader, int i)
    {
        void GameDataController.LoadHorseData
                     (uint64 this,int64 newHorseData,int64 loader,uint32 i)
        {
        int64 lVar1;
        uint32 uVar2;
        int iVar3;
        uint64 uVar4;
        if (loader != null) {
          uVar4 = LTCSVLoader.GetValueAt(loader,0,i,0);
          uVar2 = Int32.Parse(uVar4,0);
          if (newHorseData != null) {
            *(uint32 *)(newHorseData + 16) = uVar2;
            uVar4 = LTCSVLoader.GetValueAt(loader,1,i);
            *(uint64 *)(newHorseData + 32) = uVar4;
            uVar4 = LTCSVLoader.GetValueAt(loader,2,i);
            *(uint64 *)(newHorseData + 48) = uVar4;
            uVar4 = LTCSVLoader.GetValueAt(loader,3,i);
            uVar2 = Int32.Parse(uVar4,0);
            lVar1 = *(int64 *)(newHorseData + 136);
            *(uint32 *)(newHorseData + 60) = uVar2;
            uVar4 = LTCSVLoader.GetValueAt(loader,4,i);
            iVar3 = Int32.Parse(uVar4,0);
            if (lVar1 != null) {
              *(float *)(lVar1 + 20) = (float)iVar3;
              lVar1 = *(int64 *)(newHorseData + 136);
              uVar4 = LTCSVLoader.GetValueAt(loader,5,i);
              iVar3 = Int32.Parse(uVar4,0);
              if (lVar1 != null) {
                *(float *)(lVar1 + 24) = (float)iVar3;
                lVar1 = *(int64 *)(newHorseData + 136);
                uVar4 = LTCSVLoader.GetValueAt(loader,6,i);
                iVar3 = Int32.Parse(uVar4,0);
                if (lVar1 != null) {
                  *(float *)(lVar1 + 28) = (float)iVar3;
                  lVar1 = *(int64 *)(newHorseData + 136);
                  uVar4 = LTCSVLoader.GetValueAt(loader,7,i);
                  iVar3 = Int32.Parse(uVar4,0);
                  if (lVar1 != null) {
                    *(float *)(lVar1 + 32) = (float)iVar3;
                    uVar4 = LTCSVLoader.GetValueAt(loader,8,i);
                    uVar2 = Int32.Parse(uVar4,0);
                    *(uint32 *)(newHorseData + 56) = uVar2;
                    return;
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x60016F3
    // RVA   : 0xBB7190   Offset: 0xBB5F90   Length: 0xAE
    public string GenerateRandomHeroFamilyName()
    {
        uint uVar1;
        long lVar2;
        uint uVar3;
        GameDataController.CheckNameCensorWords(this,0);
        lVar2 = this.familyNameDataBase;
        if (lVar2 != null) {
          uVar1 = lVar2.Count;
          uVar3 = GlobalData.RandomRange(0,uVar1,0);
          if (lVar2.Count <= uVar3) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          return lVar2._items[uVar3];
        }
    }

    // Token : 0x60016F4
    // RVA   : 0xBB7240   Offset: 0xBB6040   Length: 0x260
    public string GenerateRandomHeroGivenName(bool isFemale, bool useCensorWords)
    {
        uint64
        GameDataController.GenerateRandomHeroGivenName(int64 this,char isFemale,char useCensorWords)
        {
        char cVar1;
        uint32 uVar2;
        uint64 uVar3;
        uint64 uVar4;
        int64 lVar5;
        int iVar6;
        int iVar7;
        float fVar8;
        float fVar9;
        GameDataController.CheckNameCensorWords(this,0);
        while( true ) {
          uVar4 = "";
          fVar8 = (float)Random.get_value(0);
          if (0.3 <= fVar8) {
            iVar7 = 2;
          }
          else {
            iVar7 = 1;
          }
          iVar6 = 0;
          do {
            fVar8 = (float)Random.get_value(0);
            fVar9 = (float)FUN_1801e6830(0x3f000000);
            if (fVar8 < fVar9 * 0.4) {
              lVar5 = this.givenNameDataBase;
              if (lVar5 == null) throw; // [null/range check failed]
              uVar2 = lVar5.Count;
              uVar2 = GlobalData.RandomRange(0,uVar2,0,0);
            }
            else if (!isFemale) {
              lVar5 = this.maleGivenNameDataBase;
              if (lVar5 == null) throw; // [null/range check failed]
              uVar2 = lVar5.Count;
              uVar2 = GlobalData.RandomRange(0,uVar2,0,0);
            }
            else {
              lVar5 = this.femaleGivenNameDataBase;
              if (lVar5 == null) throw; // [null/range check failed]
              uVar2 = lVar5.Count;
              uVar2 = GlobalData.RandomRange(0,uVar2,0,0);
            }
            uVar3 = FUN_1800024b0(lVar5,uVar2);
            iVar6 = iVar6 + 1;
            uVar4 = String.Concat(uVar4,uVar3);
          } while (iVar6 < iVar7);
          if (!useCensorWords) {
            return uVar4;
          }
          if (!this.CISFilterWordsSDKInited) {
            return uVar4;
          }
          lVar5 = CISFilterWordsSDK.get_Instance(0);
          if (lVar5 == null) break;
          cVar1 = CISFilterWordsSDK.IsContainCensorWords(lVar5,uVar4);
          if (!cVar1) {
            return uVar4;
          }
        }
    }

    // Token : 0x60016F5
    // RVA   : 0xBB74B0   Offset: 0xBB62B0   Length: 0x2DA
    public string GenerateRandomHeroName(bool isFemale, string familyName, bool useCensorWords)
    {
        uint64
        GameDataController.GenerateRandomHeroName
                (int64 this,uint8 isFemale,uint64 familyName,char useCensorWords)
        {
        char cVar1;
        uint64 uVar2;
        int64 lVar3;
        uint64 uVar4;
        int iVar5;
        LAB_180bb7540:
        do {
          uVar2 = GameDataController.GenerateRandomHeroGivenName(this,isFemale,useCensorWords,0);
          uVar2 = String.Concat(familyName,uVar2,0);
          lVar3 = *(int64 *)(*(int64 *)(DAT_181e538e8 + 184) + 400);
          if (lVar3 == null) goto LAB_180bb7785;
          cVar1 = FUN_18175e190(lVar3,uVar2,DAT_181e86470);
        } while (cVar1);
        if ((useCensorWords) && (this.CISFilterWordsSDKInited)) {
          lVar3 = CISFilterWordsSDK.get_Instance(0);
          if (lVar3 == null) {
        LAB_180bb7785:
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          cVar1 = CISFilterWordsSDK.IsContainCensorWords(lVar3,uVar2,0);
          if (cVar1) goto LAB_180bb7540;
        }
        uVar4 = FUN_1802106e0(0);
        cVar1 = Object.op_Inequality(uVar4,0,0);
        if (!cVar1) {
          return uVar2;
        }
        iVar5 = 0;
        do {
          lVar3 = FUN_1802106e0(0);
          if (((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) ||
             (lVar3 = *(int64 *)(*(int64 *)(lVar3 + 32) + 80)) == null) goto LAB_180bb7785;
          if (*(int *)(lVar3 + 24) <= iVar5) {
            return uVar2;
          }
          lVar3 = FUN_1802106e0(0);
          if (((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) ||
             (lVar3 = *(int64 *)(*(int64 *)(lVar3 + 32) + 80)) == null) goto LAB_180bb7785;
          lVar3 = FUN_1800024b0(lVar3,iVar5,DAT_181e6dd70);
          if (lVar3 != null) {
            lVar3 = FUN_1802106e0(0);
            if ((((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) ||
                (lVar3 = *(int64 *)(*(int64 *)(lVar3 + 32) + 80)) == null) ||
               (lVar3 = FUN_1800024b0(lVar3,iVar5,DAT_181e6dd70)) == null) goto LAB_180bb7785;
            cVar1 = FUN_1816387f0(*(uint64 *)(lVar3 + 104),uVar2,0);
            if (cVar1) goto LAB_180bb7540;
          }
          iVar5 = iVar5 + 1;
        } while( true );
    }

    // Token : 0x60016F6
    // RVA   : 0xBC98A0   Offset: 0xBC86A0   Length: 0x105
    public static void UnlockSkillHandBook(int skillID)
    {
        long lVar1;
        int iVar2;
        ulong uVar3;
        int[] local_res8 = new int[8];
        local_res8[0] = skillID;
        iVar2 = local_res8[0];
        if (*(int *)(*(int64 *)(DAT_181e538e8 + 184) + 0x120) <= iVar2) {
          return;
        }
        lVar1 = *(int64 *)(*(int64 *)(DAT_181e528f8 + 184) + 8);
        if (lVar1 != null) {
          lVar1 = *(int64 *)(lVar1 + 16);
          uVar3 = Int32.ToString(local_res8,0);
          uVar3 = String.Concat("HandBookSkill_",uVar3,0);
          if (lVar1 != null) {
            PlayerPrefDictionary.SetKey(lVar1,uVar3,"1",0);
            return;
          }
        }
    }

    // Token : 0x60016F7
    // RVA   : 0xBB8F30   Offset: 0xBB7D30   Length: 0x1E9
    public KungfuSkillData GetSkillDataBase(int skillID)
    {
        var pStatics_38e8 = *(int64*)(DAT_181e538e8 + 184);
        ulong uVar1;
        long lVar2;
        if (skillID < *(int *)(pStatics_38e8 + 0x120)) {
          if (skillID < *(int *)(pStatics_38e8 + 0x11c)) {
            if (this.kungfuSkillDataBase != null) {
              uVar1 = FUN_18171b450(this.kungfuSkillDataBase,skillID,DAT_181e9dae0);
              return uVar1;
            }
          }
          else {
            lVar2 = this.summonSkillDataBase;
            if (lVar2 != null) {
              uVar1 = FUN_18171b450(lVar2,skillID - *(int *)(pStatics_38e8 + 0x11c),
                                    DAT_181e9dae0);
              return uVar1;
            }
          }
        }
        else {
          if (((GameController._instance != null) &&
              (lVar2 = GameController._instance.worldData) != null) &&
             (lVar2 = lVar2.customSkills) != null) {
            lVar2 = FUN_18171b450(lVar2,skillID,DAT_181e9a910);
            if (lVar2 != null) {
              return lVar2.buckets;
            }
          }
        }
    }

    // Token : 0x60016F8
    // RVA   : 0xBB9120   Offset: 0xBB7F20   Length: 0x228
    public int GetSkillID(string skillName)
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        int iVar4;
        uint uVar5;
        int[] aiStack_64 = new int[5];
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
        uVar5 = 0;
        aiStack_64[3] = 0;
        if (this.kungfuSkillDataBase != null) {
          lVar2 = FUN_1806e0520(this.kungfuSkillDataBase,DAT_181e9db68);
          if (lVar2 != null) {
            ValueCollection.GetEnumerator(&local_38,lVar2,DAT_181e61da0);
            local_50 = local_38;
            uStack_4c = uStack_34;
            uStack_48 = uStack_30;
            uStack_44 = uStack_2c;
            local_40 = local_28;
            do {
              cVar1 = FUN_180dd6250(&local_50,DAT_181e7be30);
              lVar2 = local_40;
              if (!cVar1) {
                aiStack_64[1] = 75;
                iVar4 = aiStack_64[3] + 1;
                aiStack_64[3] = iVar4;
                ZhSegment.Initialize(&local_50,DAT_181e7bdb0);
                goto LAB_180bb92c1;
              }
              if (local_40 == 0) {
                          // WARNING: Subroutine does not return
                FUN_1801e0300();
              }
              cVar1 = FUN_1816387f0(*(uint64 *)(local_40 + 32),skillName,0);
            } while (!cVar1);
            uVar5 = *(uint32 *)(lVar2 + 20);
            aiStack_64[1] = 93;
            iVar4 = aiStack_64[3] + 1;
            aiStack_64[3] = iVar4;
            ZhSegment.Initialize(&local_50,DAT_181e7bdb0);
        LAB_180bb92c1:
            if ((iVar4 != 0) && (aiStack_64[iVar4] == 93)) {
              return uVar5;
            }
            uVar3 = String.Concat("SkillID Not Found: ",skillName,0);
            Debug.Log(uVar3,0);
            return 0xffffffff;
          }
        }
    }

    // Token : 0x60016F9
    // RVA   : 0xBC51E0   Offset: 0xBC3FE0   Length: 0x5E8
    private void LoadPeotryData()
    {
        bool cVar1;
        int iVar2;
        ulong uVar4;
        long lVar5;
        long lVar6;
        ulong uVar7;
        long lVar8;
        long lVar9;
        int iVar10;
        int iVar11;
        int[] local_res18 = new int[2];
        plVar3 = (int64 *)Resources.Load("GameData/PoetryData",0);
        if (plVar3 != (int64 *)0) {
          iVar11 = 0;
          uVar4 = FUN_180b00cb0(plVar3,0);
          lVar5 = JArray.Parse(uVar4,0);
          if (lVar5 != null) {
            while( true ) {
              iVar10 = 0;
              iVar2 = JContainer.get_Count(lVar5,0);
              if (iVar2 <= iVar11) {
                return;
              }
              lVar6 = new PoetryData(0);
              plVar3 = (int64 *)FUN_180efe970(lVar5,iVar11,0);
              if (plVar3 == (int64 *)0) break;
              plVar3 = (int64 *)
                       (**(code **)(*plVar3 + 0x218))
                                 (plVar3,"title",*(uint64 *)(*plVar3 + 0x220));
              if (plVar3 == (int64 *)0) break;
              uVar4 = (**(code **)(*plVar3 + 0x168))(plVar3,*(uint64 *)(*plVar3 + 0x170));
              if (lVar6 == null) break;
              *(uint64 *)(lVar6 + 16) = uVar4;
              plVar3 = (int64 *)FUN_180efe970(lVar5,iVar11,0);
              if (plVar3 == (int64 *)0) break;
              plVar3 = (int64 *)
                       (**(code **)(*plVar3 + 0x218))
                                 (plVar3,"author",*(uint64 *)(*plVar3 + 0x220));
              if (plVar3 == (int64 *)0) break;
              uVar4 = (**(code **)(*plVar3 + 0x168))(plVar3,*(uint64 *)(*plVar3 + 0x170));
              *(uint64 *)(lVar6 + 24) = uVar4;
              while( true ) {
                plVar3 = (int64 *)FUN_180efe970(lVar5,iVar11,0);
                if (plVar3 == (int64 *)0) throw; // [null/range check failed]
                uVar4 = (**(code **)(*plVar3 + 0x218))
                                  (plVar3,"paragraphs",*(uint64 *)(*plVar3 + 0x220));
                iVar2 = Enumerable.Count(uVar4,DAT_181e963d8);
                if (iVar2 <= iVar10) break;
                lVar8 = *(int64 *)(lVar6 + 32);
                plVar3 = (int64 *)FUN_180efe970(lVar5,iVar11,0);
                if (plVar3 == (int64 *)0) {
        LAB_180bc57b1:
                          // WARNING: Subroutine does not return
                  FUN_1801e0300();
                }
                plVar3 = (int64 *)
                         (**(code **)(*plVar3 + 0x218))
                                   (plVar3,"paragraphs",*(uint64 *)(*plVar3 + 0x220));
                local_res18[0] = iVar10;
                uVar4 = il2cpp_value_box(DAT_181e60808,local_res18);
                if (plVar3 == (int64 *)0) goto LAB_180bc57b1;
                plVar3 = (int64 *)
                         (**(code **)(*plVar3 + 0x218))(plVar3,uVar4,*(uint64 *)(*plVar3 + 0x220));
                if (plVar3 == (int64 *)0) goto LAB_180bc57b1;
                uVar4 = (**(code **)(*plVar3 + 0x168))(plVar3,*(uint64 *)(*plVar3 + 0x170));
                uVar7 = new PoetryParagraphData(uVar4,0);
                if (lVar8 == null) goto LAB_180bc57b1;
                FUN_18175de30(lVar8,uVar7,DAT_181e79d60);
                if (*(int64 *)(lVar6 + 32) == 0) goto LAB_180bc57b1;
                lVar8 = FUN_1800024b0(*(int64 *)(lVar6 + 32),iVar10);
                if ((lVar8 == null) || (*(int64 *)(lVar8 + 24) == 0)) goto LAB_180bc57b1;
                if (*(int *)(*(int64 *)(lVar8 + 24) + 24) == 2) {
                  lVar8 = *(int64 *)(lVar6 + 40);
                  if (*(int64 *)(lVar6 + 32) == 0) throw; // [null/range check failed]
                  lVar9 = FUN_1800024b0(*(int64 *)(lVar6 + 32),iVar10,DAT_181e79e60);
                  if ((lVar9 == null) || (lVar9 = *(int64 *)(lVar9 + 24)) == null)
                  throw; // [null/range check failed]
                  if (*(int *)(lVar9 + 24) == 0) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  if (lVar8 == null) throw; // [null/range check failed]
                  cVar1 = FUN_18176a2d0(lVar8,*(uint32 *)(*(int64 *)(lVar9 + 16) + 32),
                                        DAT_181e71570);
                  if (!cVar1) {
                    lVar8 = *(int64 *)(lVar6 + 40);
                    if (*(int64 *)(lVar6 + 32) == 0) throw; // [null/range check failed]
                    lVar9 = FUN_1800024b0(*(int64 *)(lVar6 + 32),iVar10,DAT_181e79e60);
                    if ((lVar9 == null) || (lVar9 = *(int64 *)(lVar9 + 24)) == null)
                    throw; // [null/range check failed]
                    if (*(int *)(lVar9 + 24) == 0) {
                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                    }
                    if (lVar8 == null) throw; // [null/range check failed]
                    FUN_181769fe0(lVar8,*(uint32 *)(*(int64 *)(lVar9 + 16) + 32),DAT_181e713f0)
                    ;
                  }
                  lVar8 = *(int64 *)(lVar6 + 40);
                  if (*(int64 *)(lVar6 + 32) == 0) throw; // [null/range check failed]
                  lVar9 = FUN_1800024b0(*(int64 *)(lVar6 + 32),iVar10,DAT_181e79e60);
                  if ((lVar9 == null) || (lVar9 = *(int64 *)(lVar9 + 24)) == null)
                  throw; // [null/range check failed]
                  if (*(uint32 *)(lVar9 + 24) < 2) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  if (lVar8 == null) throw; // [null/range check failed]
                  cVar1 = FUN_18176a2d0(lVar8,*(uint32 *)(*(int64 *)(lVar9 + 16) + 36));
                  if (!cVar1) {
                    lVar8 = *(int64 *)(lVar6 + 40);
                    if (*(int64 *)(lVar6 + 32) == 0) throw; // [null/range check failed]
                    lVar9 = FUN_1800024b0(*(int64 *)(lVar6 + 32),iVar10,DAT_181e79e60);
                    if ((lVar9 == null) || (lVar9 = *(int64 *)(lVar9 + 24)) == null)
                    throw; // [null/range check failed]
                    if (*(uint32 *)(lVar9 + 24) < 2) {
                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                    }
                    if (lVar8 == null) throw; // [null/range check failed]
                    FUN_181769fe0(lVar8,*(uint32 *)(*(int64 *)(lVar9 + 16) + 36));
                  }
                }
                iVar10 = iVar10 + 1;
              }
              if (*(int64 *)(lVar6 + 40) == 0) break;
              cVar1 = FUN_18176a2d0(*(int64 *)(lVar6 + 40),5,DAT_181e71570);
              if (!cVar1) {
                if (*(int64 *)(lVar6 + 40) == 0) break;
                cVar1 = FUN_18176a2d0();
                if (!(cVar1))
                {
                  }
                  else {
                }
                if (this.poetryDataBase == null) break;
                FUN_18175de30();
              }
              iVar11 = iVar11 + 1;
            }
          }
        }
    }

    // Token : 0x60016FA
    // RVA   : 0xBB8B00   Offset: 0xBB7900   Length: 0xFB
    public int GetRandomBigForceID(float noBigForceRate, int noBigForceResult)
    {
        uint32
        GameDataController.GetRandomBigForceID(int64 this,float noBigForceRate,uint32 noBigForceResult)
        {
        uint32 uVar1;
        int64 lVar2;
        uint32 uVar3;
        double dVar4;
        dVar4 = (double)GlobalData.RandomRangeDouble(0,0);
        if (dVar4 < (double)noBigForceRate) {
          return noBigForceResult;
        }
        lVar2 = this.bigForceIDList;
        if (lVar2 != null) {
          uVar1 = lVar2.Count;
          uVar3 = GlobalData.RandomRange(0,uVar1,0);
          if (lVar2.Count <= uVar3) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          return lVar2._items[uVar3];
        }
    }

    // Token : 0x60016FB
    // RVA   : 0xBB6C40   Offset: 0xBB5A40   Length: 0xD9
    public SkinDataBase FindSkinDataBase(int targetSkinID)
    {
        long lVar1;
        ulong uVar2;
        long lVar3;
        long lVar4;
        uint uVar5;
        lVar3 = this.skinDataBase;
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
            lVar1 = *(int64 *)(lVar4 + lVar3._items);
            if (lVar1 == null) break;
            lVar3 = this.skinDataBase;
            if (*(int *)(lVar1 + 16) == targetSkinID) {
              if (lVar3 != null) {
                uVar2 = FUN_1800024b0(lVar3,uVar5,DAT_181e855b0);
                return uVar2;
              }
              break;
            }
            uVar5 = uVar5 + 1;
            lVar4 = lVar4 + 8;
          } while (lVar3 != null);
        }
    }

    // Token : 0x60016FC
    // RVA   : 0xBB6AE0   Offset: 0xBB58E0   Length: 0x15D
    public BookTypeIconData FindBookTypeIconDataBase(ItemData targetItem)
    {
        int iVar1;
        bool cVar2;
        long lVar3;
        long lVar4;
        uint uVar5;
        if ((targetItem != null) && (*(int64 *)(targetItem + 112) != 0)) {
          lVar3 = BookData.DataBase(*(int64 *)(targetItem + 112),0);
          if (lVar3 != null) {
            cVar2 = KungfuSkillData.HaveForce(lVar3,0);
            lVar3 = this.bookTypeIconDataBase;
            if (!cVar2) {
              if (*(int64 *)(targetItem + 112) != 0) {
                lVar4 = BookData.DataBase(*(int64 *)(targetItem + 112),0);
                if ((lVar4 != null) && (lVar3 != null)) {
                  uVar5 = *(uint32 *)(lVar4 + 48);
                  if (lVar3.Count <= uVar5) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  return lVar3._items[uVar5];
                }
              }
            }
            else {
              lVar4 = *(int64 *)(*(int64 *)(DAT_181e538e8 + 184) + 0x4a8);
              if (lVar4 != null) {
                iVar1 = *(int *)(lVar4 + 24);
                if (*(int64 *)(targetItem + 112) != 0) {
                  lVar4 = BookData.DataBase(*(int64 *)(targetItem + 112),0);
                  if ((lVar4 != null) && (lVar3 != null)) {
                    uVar5 = *(int *)(lVar4 + 24) + iVar1;
                    if (lVar3.Count <= uVar5) {
                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                    }
                    return lVar3._items[uVar5];
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x60016FD
    // RVA   : 0xBB9350   Offset: 0xBB8150   Length: 0x132
    public HeroTagDataBase GetTagDataBase(int tagID)
    {
        long lVar1;
        ulong uVar2;
        if (tagID < 10000) {
          if (this.heroTagDataBase != null) {
            uVar2 = FUN_18171b450(this.heroTagDataBase,tagID,DAT_181e9ba10);
            return uVar2;
          }
        }
        else {
          if (((GameController._instance != null) &&
              (lVar1 = GameController._instance.worldData) != null) &&
             (lVar1 = lVar1.tempTagDataBase) != null) {
            if (lVar1.cityAreaID <= tagID - 10000U) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            return *(uint64 *)(lVar1.chapter + -0x13860 + (int64)tagID * 8);
          }
        }
    }

    // Token : 0x60016FE
    // RVA   : 0xBC7830   Offset: 0xBC6630   Length: 0x117
    public void ResetDlcState()
    {
        long lVar1;
        ulong uVar2;
        int iVar3;
        int[] local_res18 = new int[4];
        iVar3 = 0;
        while( true ) {
          local_res18[0] = iVar3;
          lVar1 = *(int64 *)(*(int64 *)(DAT_181e538e8 + 184) + 64);
          if (lVar1 == null) break;
          if (*(int *)(lVar1 + 24) <= iVar3) {
            return;
          }
          lVar1 = *(int64 *)(*(int64 *)(DAT_181e528f8 + 184) + 8);
          if (lVar1 == null) break;
          lVar1 = *(int64 *)(lVar1 + 16);
          uVar2 = Int32.ToString(local_res18,0);
          uVar2 = String.Concat("DLC",uVar2,0);
          if (lVar1 == null) break;
          PlayerPrefDictionary.SetKey(lVar1,uVar2,0,0);
          iVar3 = local_res18[0] + 1;
        }
    }

    // Token : 0x60016FF
    // RVA   : 0xBB97C0   Offset: 0xBB85C0   Length: 0x8A
    public string GetWeaponSingleName(int weaponID)
    {
        bool cVar1;
        ulong local_res8;
        local_res8 = 0;
        if (((this.weaponSingleNameDataBase != null) &&
            (cVar1 = FUN_1806e3f90(this.weaponSingleNameDataBase,weaponID,&local_res8,DAT_181e9ff70),
            cVar1)) && (cVar1 = FUN_180ad1200(local_res8,0), !cVar1)) {
          return local_res8;
        }
        return "";
    }

    // Token : 0x6001700
    // RVA   : 0xBB8290   Offset: 0xBB7090   Length: 0x254
    public string GetEquipmentSingleName(ItemData item)
    {
        var pStatics = *(int64*)(DAT_181e538e8 + 184);
        int iVar1;
        int iVar2;
        long lVar3;
        bool cVar4;
        ulong uVar5;
        ulong local_res10;
        ulong local_res20;
        local_res10 = 0;
        if (((item == null) || (*(int *)(item + 20) != 0)) ||
           (lVar3 = *(int64 *)(item + 96)) == null) {
          return "";
        }
        iVar1 = *(int *)(item + 24);
        if (iVar1 == 0) {
          iVar1 = *(int *)(lVar3 + 20);
          iVar2 = *(int *)(lVar3 + 24);
          local_res20 = 0;
          if (((this.weaponSingleNameDataBase != null) &&
              (cVar4 = FUN_1806e3f90(this.weaponSingleNameDataBase,iVar2 + iVar1 * 6,&local_res20,
                                     DAT_181e9ff70), cVar4)) &&
             (cVar4 = FUN_180ad1200(local_res20,0), !cVar4)) {
            return local_res20;
          }
          return "";
        }
        if (((iVar1 == 1) || (iVar1 == 2)) || (iVar1 == 3)) {
          if (this.equipmentSingleNameDataBase == null) {
            return "";
          }
          cVar4 = FUN_1806e3f90(this.equipmentSingleNameDataBase,*(int *)(lVar3 + 20) + iVar1 * 10,
                                &local_res10,DAT_181e9ff70);
          if (!cVar4) {
            return "";
          }
          cVar4 = FUN_180ad1200(local_res10,0);
          if (cVar4) {
            return "";
          }
          return local_res10;
        }
        if (iVar1 != 4) {
          return "";
        }
        iVar1 = *(int *)(lVar3 + 20);
        if (iVar1 < 0) {
          return "";
        }
        lVar3 = *(int64 *)(pStatics + 0x4f0);
        if (lVar3 != null) {
          if (*(int *)(lVar3 + 24) <= iVar1) {
            return "";
          }
          lVar3 = *(int64 *)(pStatics + 0x4f0);
          if (lVar3 != null) {
            uVar5 = FUN_1800024b0(lVar3,iVar1,DAT_181e86970);
            return uVar5;
          }
        }
    }

    // Token : 0x6001701
    // RVA   : 0xBCA580   Offset: 0xBC9380   Length: 0x14E
    public void /*ctor*/()
    {
        ulong uVar1;
        uVar1 = il2cpp_internal(DAT_181e77e28);
        FUN_1810f3480(uVar1,DAT_181e88870);
        this.Tasks = uVar1;
        uVar1 = il2cpp_internal(DAT_181e70238);
        FUN_1810f3480(uVar1,DAT_181e5add0);
        this.HeroNatureTalkTextDataBase = uVar1;
        uVar1 = il2cpp_internal(DAT_181e734b8);
        FUN_1810f3480(uVar1,DAT_181e6e470);
        this.HeroSpeTalkTextDataBase = uVar1;
        uVar1 = il2cpp_internal(DAT_181e628c0);
        FUN_1806e5bc0(uVar1,DAT_181e539d0);
        this.SpeSkeletonName = uVar1;
        FUN_180ae8740(this,0);
    }

    // Token : 0x6001702
    // RVA   : 0xBCA3E0   Offset: 0xBC91E0   Length: 0x19C
    private static void /*cctor*/()
    {
        var pStatics = *(int64*)(DAT_181e528f8 + 184);
        long lVar2;
        ulong uVar3;
        lVar2 = il2cpp_internal(DAT_181e77728);
        FUN_1810f3480(lVar2,DAT_181e861f0);
        if (lVar2 != null) {
          FUN_18175de30(lVar2,"Save",DAT_181e86370);
          FUN_18175de30(lVar2,"Hero",DAT_181e86370);
          FUN_18175de30(lVar2,"TempHero",DAT_181e86370);
          FUN_18175de30(lVar2,"Info",DAT_181e86370);
          plVar1 = pStatics;
          *plVar1 = lVar2;
          il2cpp_internal(plVar1,lVar2);
          uVar3 = new RePlayerPrefData(0);
          GameController.difficultyExtraPoint = uVar3;
          uVar3 = new ItemListData(0);
          GameController.CheckShowSpeHeroSkinID = uVar3;
          return;
        }
    }

    // Token : 0x6001703
    // RVA   : 0xBC9640   Offset: 0xBC8440   Length: 0x125
    private void <InitWithEtag>b__80_0(OnlineCensorFileResult result)
    {
        long lVar1;
        ulong uVar2;
        long lVar3;
        if (result == null) throw; // [null/range check failed]
        if (*(char *)(result + 16) == false) {
          lVar1 = CISFilterWordsSDK.get_Instance();
          lVar3 = CISFilterWordsSDK.get_Instance(0);
          if (lVar3 == null) throw; // [null/range check failed]
          uVar2 = CISFilterWordsSDK.LoadLocalCensorWordsSet(lVar3,0);
        }
        else {
          if (*(char *)(result + 17) == false) {
            lVar1 = CISFilterWordsSDK.get_Instance();
            if (lVar1 != null) {
              CISFilterWordsSDK.Init(lVar1,*(uint64 *)(result + 24),0,0);
              lVar1 = CISFilterWordsSDK.get_Instance(0);
              if (lVar1 != null) {
                CISFilterWordsSDK.WriteCacheCensorFile(lVar1,*(uint64 *)(result + 40),0);
                PlayerPrefs.SetString("CensorWordsEtag",*(uint64 *)(result + 32),0);
                this.CISFilterWordsSDKInited = 1;
                return;
              }
            }
            throw; // [null/range check failed]
          }
          lVar1 = CISFilterWordsSDK.get_Instance();
          if (lVar1 == null) throw; // [null/range check failed]
          uVar2 = CISFilterWordsSDK.ReadCacheCensorFile(lVar1,0);
          lVar1 = CISFilterWordsSDK.get_Instance(0);
        }
        if (lVar1 != null) {
          CISFilterWordsSDK.Init(lVar1,uVar2,0,0);
          this.CISFilterWordsSDKInited = 1;
          return;
        }
    }

}
