// ============================================================
// Type  : GameDataController
// Token : 0x20002A5
// ============================================================

public class GameDataController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001518
    public List<Task> Tasks;

    // Token: 0x4001519
    public string saveDataPath;

    // Token: 0x400151A
    public string backupDataPath;

    // Token: 0x400151B
    public static List<string> saveDataFileName;

    // Token: 0x400151C
    public GameSaveData gameSaveData;

    // Token: 0x400151D
    public const string playerprefDataFileName;

    // Token: 0x400151E
    public static RePlayerPrefData playerPrefData;

    // Token: 0x400151F
    public static float soundEffectVolume;

    // Token: 0x4001520
    public const string ExternalStorageDataFileName;

    // Token: 0x4001521
    public static ItemListData ExternalStorage;

    // Token: 0x4001522
    public List<RareLvData> rareLvData;

    // Token: 0x4001523
    public List<ForceLevelData> forceLevelData;

    // Token: 0x4001524
    public EventData AiForceAttackPlayerAreaEvent;

    // Token: 0x4001525
    public EventData AiForceAttackPlayerResourcePointEvent;

    // Token: 0x4001526
    public EventData AiForceAttackFriendAreaEvent;

    // Token: 0x4001527
    public List<ForceJobSettingDataBase> forceJobSettingDataBase;

    // Token: 0x4001528
    public List<SkillBulletData> SkillBulletDataBase;

    // Token: 0x4001529
    public List<string> familyNameDataBase;

    // Token: 0x400152A
    public List<string> givenNameDataBase;

    // Token: 0x400152B
    public List<string> maleGivenNameDataBase;

    // Token: 0x400152C
    public List<string> femaleGivenNameDataBase;

    // Token: 0x400152D
    public List<HeroSpeAddDataBase> speAddDataBase;

    // Token: 0x400152E
    public List<ForceSpeAddDataBase> forceSpeAddDataBase;

    // Token: 0x400152F
    public Dictionary<int, ForceTechDataBase> forceTechDataBase;

    // Token: 0x4001530
    public List<int> randomSpeAddAvailableID;

    // Token: 0x4001531
    public List<int> randomSpeAddNegativeAvailableID;

    // Token: 0x4001532
    public List<int> randomSpeAddSelfBuffID;

    // Token: 0x4001533
    public List<int> randomSpeAddEnemyBuffID;

    // Token: 0x4001534
    public Dictionary<int, AreaData> areaDataBase;

    // Token: 0x4001535
    public Dictionary<int, ForceData> forceDataBase;

    // Token: 0x4001536
    public List<int> bigForceIDList;

    // Token: 0x4001537
    public Dictionary<int, AreaBuildingDataBase> buildingDataBase;

    // Token: 0x4001538
    public List<List<int>> buildingDataBaseTypeIDList;

    // Token: 0x4001539
    public Dictionary<int, ItemData> weaponDataBase;

    // Token: 0x400153A
    public Dictionary<int, ItemData> armorDataBase;

    // Token: 0x400153B
    public Dictionary<int, ItemData> helmetDataBase;

    // Token: 0x400153C
    public Dictionary<int, ItemData> shoesDataBase;

    // Token: 0x400153D
    public Dictionary<int, ItemData> medDataBase;

    // Token: 0x400153E
    public Dictionary<int, ItemData> foodDataBase;

    // Token: 0x400153F
    public Dictionary<int, ItemData> horseDataBase;

    // Token: 0x4001540
    public Dictionary<int, KungfuSkillData> kungfuSkillDataBase;

    // Token: 0x4001541
    public Dictionary<int, KungfuSkillData> summonSkillDataBase;

    // Token: 0x4001542
    public Dictionary<int, List<List<KungfuSkillData>>> kungfuSkillDataList;

    // Token: 0x4001543
    public List<List<string>> HeroNatureTalkTextDataBase;

    // Token: 0x4001544
    public List<HeroSpeTalkTextDataBase> HeroSpeTalkTextDataBase;

    // Token: 0x4001545
    public Dictionary<int, HeroData> SpeHeroDataBase;

    // Token: 0x4001546
    public HeroFaceData MaleFaceTotalNum;

    // Token: 0x4001547
    public HeroFaceData FemaleFaceTotalNum;

    // Token: 0x4001548
    public List<List<int>> MaleFaceRandomID;

    // Token: 0x4001549
    public List<List<int>> FemaleFaceRandomID;

    // Token: 0x400154A
    public Dictionary<int, PlotData> PlotDataBase;

    // Token: 0x400154B
    public Dictionary<int, SummonData> SummonDataBase;

    // Token: 0x400154C
    public Dictionary<int, ResourcePointTypeData> resourcePointTypeDataBase;

    // Token: 0x400154D
    public Dictionary<int, ResourcePointData> resourcePointDataBase;

    // Token: 0x400154E
    public Dictionary<int, HeroTagDataBase> heroTagDataBase;

    // Token: 0x400154F
    public Dictionary<int, InnData> innDataBase;

    // Token: 0x4001550
    public List<SkinDataBase> skinDataBase;

    // Token: 0x4001551
    public List<List<int>> CheckReplaceSkillIconList;

    // Token: 0x4001552
    public List<BookTypeIconData> bookTypeIconDataBase;

    // Token: 0x4001553
    public List<AchievementData> AchievementData;

    // Token: 0x4001554
    public List<string> tipsData;

    // Token: 0x4001555
    public List<MartialClubDataBase> martialclubDataBase;

    // Token: 0x4001556
    public List<string> loveableSpeHeroList;

    // Token: 0x4001557
    public Dictionary<string, bool> SpeSkeletonName;

    // Token: 0x4001558
    public List<PoetryData> poetryDataBase;

    // Token: 0x4001559
    public AudioClip dingSound;

    // Token: 0x400155A
    private static GameDataController _instance;

    // Token: 0x400155B
    private bool CISFilterWordsSDKInited;

    // Token: 0x400155C
    private bool NameCensorWordsChecked;

    // Token: 0x400155D
    private float keepTaskTime;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001646
    // RVA   : 0xC2CCE0   Offset: 0xC2C0E0   Length: 0x58
    public static GameDataController get_Instance()
    {
        return *(uint64 *)(*(int64 *)(DAT_181d72d50 + 184) + 32);
    }

    // Token : 0x6001647
    // RVA   : 0xC1D3B0   Offset: 0xC1C7B0   Length: 0x20B
    public bool HaveTask()
    {
        bool cVar1;
        int iVar2;
        long lVar3;
        long lVar4;
        uint uVar5;
        if (this.Tasks == null) {
        LAB_180c1d5b6:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        uVar5 = this.Tasks.Count - 1;
        if (-1 < (int)uVar5) {
          lVar4 = (int64)(int)uVar5 * 8 + 32;
          do {
            lVar3 = this.Tasks;
            if (lVar3 == null) goto LAB_180c1d5b6;
            if (lVar3.Count <= uVar5) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            if (*(int64 *)(lVar3._items + lVar4) != 0) {
              if ((this.Tasks == null) ||
                 (lVar3 = FUN_180002f80(this.Tasks,uVar5,DAT_181da6598)) == null)
              goto LAB_180c1d5b6;
              iVar2 = Task.get_Status(lVar3,0);
              if (iVar2 != 5) {
                if ((this.Tasks == null) ||
                   (lVar3 = FUN_180002f80(this.Tasks,uVar5,DAT_181da6598)) == null)
                goto LAB_180c1d5b6;
                iVar2 = Task.get_Status(lVar3,0);
                if (iVar2 != 6) {
                  if ((this.Tasks == null) ||
                     (lVar3 = FUN_180002f80(this.Tasks,uVar5,DAT_181da6598), lVar3 == null
                     )) goto LAB_180c1d5b6;
                  iVar2 = Task.get_Status(lVar3,0);
                  if (iVar2 != 7) {
                    if ((this.Tasks == null) ||
                       (lVar3 = FUN_180002f80(this.Tasks,uVar5,DAT_181da6598),
                       lVar3 == null)) goto LAB_180c1d5b6;
                    cVar1 = Task.get_IsCanceled(lVar3,0);
                    if (!cVar1) {
                      if ((this.Tasks == null) ||
                         (lVar3 = FUN_180002f80(this.Tasks,uVar5,DAT_181da6598),
                         lVar3 == null)) goto LAB_180c1d5b6;
                      cVar1 = Task.get_IsCompleted(lVar3,0);
                      if (!cVar1) {
                        if ((this.Tasks == null) ||
                           (lVar3 = FUN_180002f80(this.Tasks,uVar5,DAT_181da6598),
                           lVar3 == null)) goto LAB_180c1d5b6;
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
            if (this.Tasks == null) goto LAB_180c1d5b6;
            FUN_181823590(this.Tasks,uVar5,DAT_181da6498);
            lVar4 = lVar4 + -8;
            uVar5 = uVar5 - 1;
          } while (-1 < (int)uVar5);
        }
        return false;
    }

    // Token : 0x6001648
    // RVA   : 0xC187A0   Offset: 0xC17BA0   Length: 0x5E
    public void AddTask(Task task)
    {
        if (this.Tasks != null) {
          FUN_18181e0a0(this.Tasks,task,DAT_181da6298);
          this.keepTaskTime = 0;
          return;
        }
    }

    // Token : 0x6001649
    // RVA   : 0xC194B0   Offset: 0xC188B0   Length: 0x36
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

    // Token : 0x600164A
    // RVA   : 0xC19490   Offset: 0xC18890   Length: 0x1D
    public bool CanLoad()
    {
        if (this.gameSaveData != null) {
          GameSaveData.CheckAllFinished(this.gameSaveData,0);
          return;
        }
    }

    // Token : 0x600164B
    // RVA   : 0xC18800   Offset: 0xC17C00   Length: 0xC81
    private void Awake()
    {
        var pStatics = *(int64*)(DAT_181d72d50 + 184);
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
        uVar3 = *(uint64 *)(pStatics + 32);
        cVar1 = Object.op_Equality(uVar3,0,0);
        if (!cVar1) {
          uVar3 = Component.get_gameObject(this,0);
          Object.Destroy(uVar3,0);
          return;
        }
        plVar8 = (int64 *)(pStatics + 32);
        *plVar8 = this;
        il2cpp_internal(plVar8,this);
        uVar3 = Component.get_gameObject(this,0);
        Object.DontDestroyOnLoad(uVar3,0);
        uVar3 = new CultureInfo("en-US",0);
        CultureInfo.set_DefaultThreadCurrentCulture(uVar3,0);
        this.gameSaveData = new GameSaveData(0);
        lVar6 = this.gameSaveData;
        uVar3 = FUN_180da44a0(0);
        if (lVar6 == null) throw; // [null/range check failed]
        lVar6.key = uVar3;
        iVar2 = Application.get_platform(0);
        if (iVar2 == 8) {
        LAB_180c18b16:
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
          if (iVar2 == 11) goto LAB_180c18b16;
          uVar3 = Application.get_dataPath(0);
          uVar3 = String.Concat(uVar3,"/Save",0);
          this.saveDataPath = uVar3;
          uVar3 = Application.get_persistentDataPath(0);
          uVar3 = String.Concat(uVar3,"/Save_backup",0);
          this.backupDataPath = uVar3;
        }
        GameDataController.LoadPlayerprefData(this,0);
        GameDataController.LoadExternalStorageData(this,0);

        if ((lVar6 = *(int64 *)(pStatics + 8)?.key) != null) {
          cVar1 = PlayerPrefDictionary.ContainsKey(lVar6,"Volume",0);
          if (!cVar1) {

            if ((lVar6 = *(int64 *)(pStatics + 8)?.key) == null) throw; // [null/range check failed]
            PlayerPrefDictionary.SetKey(lVar6,"Volume",0x3f800000,0);
          }

          if ((lVar6 = *(int64 *)(pStatics + 8)?.key) != null) {
            cVar1 = PlayerPrefDictionary.ContainsKey(lVar6,"BgmVolume",0);
            if (!cVar1) {

              if ((lVar6 = *(int64 *)(pStatics + 8)?.key) == null) throw; // [null/range check failed]
              PlayerPrefDictionary.SetKey(lVar6,"BgmVolume",0x3f333333,0);
            }

            if ((lVar6 = *(int64 *)(pStatics + 8)?.key) != null) {
              cVar1 = PlayerPrefDictionary.ContainsKey(lVar6,"SoundEffectVolume",0);
              if (!cVar1) {

                if ((lVar6 = *(int64 *)(pStatics + 8)?.key) == null) throw; // [null/range check failed]
                PlayerPrefDictionary.SetKey(lVar6,"SoundEffectVolume",0x3f800000,0);
              }

              if ((lVar6 = *(int64 *)(pStatics + 8)?.key) != null) {
                uVar10 = PlayerPrefDictionary.GetFloat(lVar6,"Volume",0);
                AudioListener.set_volume(uVar10,0);

                if ((lVar6 = *(int64 *)(pStatics + 8)?.key) != null) {
                  uVar10 = PlayerPrefDictionary.GetFloat(lVar6,"SoundEffectVolume",0);
                  *(uint32 *)(pStatics + 16) = uVar10;

                  if ((lVar6 = *(int64 *)(pStatics + 8)?.key) != null) {
                    cVar1 = PlayerPrefDictionary.ContainsKey(lVar6,"AutoSave",0);
                    if (!cVar1) {

                      if ((lVar6 = *(int64 *)(pStatics + 8)?.key) == null)
                      throw; // [null/range check failed]
                      PlayerPrefDictionary.SetKey(lVar6,"AutoSave",1);
                    }

                    if ((lVar6 = *(int64 *)(pStatics + 8)?.key) != null) {
                      cVar1 = PlayerPrefDictionary.ContainsKey(lVar6,"FightViewFollow",0);
                      if (!cVar1) {

                        if ((lVar6 = *(int64 *)(pStatics + 8)?.key) == null)
                        throw; // [null/range check failed]
                        PlayerPrefDictionary.SetKey(lVar6,"FightViewFollow",1);
                      }

                      if ((lVar6 = *(int64 *)(pStatics + 8)?.key) != null) {
                        cVar1 = PlayerPrefDictionary.ContainsKey(lVar6,"FightScreenShake",0);
                        if (!cVar1) {

                          if ((lVar6 = *(int64 *)(pStatics + 8)?.key) == null)
                          throw; // [null/range check failed]
                          PlayerPrefDictionary.SetKey(lVar6,"FightScreenShake",1);
                        }
                        if (**(int **)(DAT_181d73d40 + 184) == 2) {

                          if ((lVar6 = *(int64 *)(pStatics + 8)?.key) == null)
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
                        uVar4 = String.Concat(**(uint64 **)(DAT_181db5328 + 184),".txt",0);
                        uVar3 = Path.Combine(uVar3,uVar4,0);
                        uVar4 = Application.get_persistentDataPath(0);
                        uVar5 = String.Concat(**(uint64 **)(DAT_181db5328 + 184),".txt",0);
                        uVar4 = Path.Combine(uVar4,uVar5,0);
                        lVar6 = new WWW(uVar3,0);
                        do {
                          if (lVar6 == null) throw; // [null/range check failed]
                          cVar1 = WWW.get_isDone(lVar6,0);
                        } while (!cVar1);
                        uVar3 = WWW.get_bytes(lVar6,0);
                        File.WriteAllBytes(uVar4,uVar3,0);
                        if (**(int **)(DAT_181d73d40 + 184) == 2) {
                          lVar6 = CISFilterWordsSDK.get_Instance(0);
                          uVar3 = new OnTooltipCB(this,DAT_181dc4a10,DAT_181d98128);
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

                        if ((lVar6 = *(int64 *)(pStatics + 8)?.key) != null) {
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

    // Token : 0x600164C
    // RVA   : 0xC1A170   Offset: 0xC19570   Length: 0x2B8
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
                FUN_181823590(this.familyNameDataBase,uVar4);
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
                  FUN_181823590(this.givenNameDataBase,uVar4);
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
                    FUN_181823590(this.maleGivenNameDataBase,uVar4);
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
                      FUN_181823590(this.femaleGivenNameDataBase,uVar4);
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

    // Token : 0x600164D
    // RVA   : 0xC1D5C0   Offset: 0xC1C9C0   Length: 0x150
    public void InitWithEtag()
    {
        long lVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        if (**(int **)(DAT_181d73d40 + 184) == 2) {
          lVar1 = CISFilterWordsSDK.get_Instance(0);
          uVar3 = new OnTooltipCB(this,DAT_181dc4a10,DAT_181d98128);
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

    // Token : 0x600164E
    // RVA   : 0xC1D720   Offset: 0xC1CB20   Length: 0x46
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

    // Token : 0x600164F
    // RVA   : 0xC1A4B0   Offset: 0xC198B0   Length: 0x160
    public void CopyLocalCensorWordsFile()
    {
        ulong uVar1;
        ulong uVar2;
        ulong uVar3;
        bool cVar4;
        long lVar5;
        uVar1 = Application.get_streamingAssetsPath(0);
        uVar2 = String.Concat(**(uint64 **)(DAT_181db5328 + 184),".txt",0);
        uVar1 = Path.Combine(uVar1,uVar2,0);
        uVar2 = Application.get_persistentDataPath(0);
        uVar3 = String.Concat(**(uint64 **)(DAT_181db5328 + 184),".txt",0);
        uVar2 = Path.Combine(uVar2,uVar3,0);
        lVar5 = new WWW(uVar1,0);
        do {
          if (lVar5 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          cVar4 = WWW.get_isDone(lVar5,0);
        } while (!cVar4);
        uVar1 = WWW.get_bytes(lVar5,0);
        File.WriteAllBytes(uVar2,uVar1,0);
    }

    // Token : 0x6001650
    // RVA   : 0xC1A620   Offset: 0xC19A20   Length: 0x26E
    public void CopyTestSave(string sourcePath, string destPath)
    {
        var pStatics = *(int64*)(DAT_181d72d50 + 184);
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
          if (*pStatics == 0) break;
          if (*(int *)(*pStatics + 24) <= iVar5) {
            return;
          }
          if (*pStatics == 0) break;
          uVar2 = FUN_180002f80(*pStatics,iVar5,DAT_181da4358);
          uVar2 = String.Concat(sourcePath,"/",uVar2,0);
          if (*pStatics == 0) break;
          uVar3 = FUN_180002f80(*pStatics,iVar5,DAT_181da4358);
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

    // Token : 0x6001651
    // RVA   : 0xC2B110   Offset: 0xC2A510   Length: 0x8B
    private void Start()
    {
        GameDataController.LoadAllGameData(this,0);
        if (*(int64 *)(*(int64 *)(DAT_181d84898 + 184) + 16) == 0) {
          LTLocalization.Init(0);
          return;
        }
    }

    // Token : 0x6001652
    // RVA   : 0xC2BFC0   Offset: 0xC2B3C0   Length: 0x20F
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
                  FUN_1812f9a10(lVar3,DAT_181da6318);
                  goto LAB_180c2c147;
                }
                if (lVar3 == null) {
        LAB_180c2c1ca:
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                if (lVar3.worldDataFinished <= uVar5) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar3 = *(int64 *)(lVar6 + lVar3.key);
                if (lVar3 == null) goto LAB_180c2c1ca;
                local_res18[0] = Task.get_Status(lVar3,0);
                uVar4 = il2cpp_value_box(DAT_181daa590,local_res18);
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
        LAB_180c2c147:
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

    // Token : 0x6001653
    // RVA   : 0xC1C730   Offset: 0xC1BB30   Length: 0x57
    public string GetPlayerPrefFilePath()
    {
        bool cVar1;
        cVar1 = Directory.Exists(this.saveDataPath,0);
        if (!cVar1) {
          Directory.CreateDirectory(this.saveDataPath,0);
        }
        String.Concat(this.saveDataPath,"/PlayerprefData.dat",0);
    }

    // Token : 0x6001654
    // RVA   : 0xC1C6D0   Offset: 0xC1BAD0   Length: 0x57
    public string GetPlayerPrefFileBackupPath()
    {
        bool cVar1;
        cVar1 = Directory.Exists(this.saveDataPath,0);
        if (!cVar1) {
          Directory.CreateDirectory(this.saveDataPath,0);
        }
        String.Concat(this.saveDataPath,"/PlayerprefData.dat_backup",0);
    }

    // Token : 0x6001655
    // RVA   : 0xC2A940   Offset: 0xC29D40   Length: 0xF1
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
        uVar1 = *(uint64 *)(*(int64 *)(DAT_181d72d50 + 184) + 8);
        uVar1 = JsonConvert.SerializeObject(uVar1,0);
        File.WriteAllText(uVar2,uVar1,0);
    }

    // Token : 0x6001656
    // RVA   : 0xC28660   Offset: 0xC27A60   Length: 0x3A0
    public void LoadPlayerprefData()
    {
        var pStatics = *(int64*)(DAT_181d72d50 + 184);
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
            FUN_1800d6620();
          }
          JsonSerializerSettings.set_ObjectCreationHandling(lVar3,2);
          uVar2 = JsonConvert.DeserializeObject(uVar2,lVar3,DAT_181d802a8);
          puVar4 = (uint64 *)(pStatics + 8);
          *puVar4 = uVar2;
          il2cpp_internal(puVar4,uVar2);
          if (*(int64 *)(pStatics + 8) == 0) {
            uVar2 = new RePlayerPrefData(0);
            puVar4 = (uint64 *)(pStatics + 8);
            *puVar4 = uVar2;
            il2cpp_internal(puVar4,uVar2);
          }
        }
    }

    // Token : 0x6001657
    // RVA   : 0xC1BE90   Offset: 0xC1B290   Length: 0x18F
    public int GetAchFinishedCount()
    {
        var pStatics = *(int64*)(DAT_181d72d50 + 184);
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
          lVar1 = *(int64 *)(pStatics + 32);
          if ((lVar1 == null) || (lVar1 = *(int64 *)(lVar1 + 0x1c0)) == null) break;
          if (*(int *)(lVar1 + 24) <= iVar2) {
            return iVar5;
          }
          lVar1 = *(int64 *)(pStatics + 8);
          if (lVar1 == null) break;
          lVar1 = *(int64 *)(lVar1 + 16);
          uVar4 = Int32.ToString(local_res18,0);
          uVar4 = String.Concat("AchFinished",uVar4,0);
          if (lVar1 == null) break;
          uVar4 = PlayerPrefDictionary.GetString(lVar1,uVar4);
          cVar3 = FUN_18171e540(uVar4);
          if (cVar3) {
            iVar5 = iVar5 + 1;
          }
          local_res18[0] = local_res18[0] + 1;
        }
    }

    // Token : 0x6001658
    // RVA   : 0xC1C1E0   Offset: 0xC1B5E0   Length: 0x196
    public int GetExternalStorageMaxValue()
    {
        var pStatics = *(int64*)(DAT_181d72d50 + 184);
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
          lVar1 = *(int64 *)(pStatics + 32);
          if ((lVar1 == null) || (lVar1 = *(int64 *)(lVar1 + 0x1c0)) == null) break;
          if (*(int *)(lVar1 + 24) <= iVar2) {
            return (iVar5 + 8) * 500;
          }
          lVar1 = *(int64 *)(pStatics + 8);
          if (lVar1 == null) break;
          lVar1 = *(int64 *)(lVar1 + 16);
          uVar4 = Int32.ToString(local_res18,0);
          uVar4 = String.Concat("AchFinished",uVar4,0);
          if (lVar1 == null) break;
          uVar4 = PlayerPrefDictionary.GetString(lVar1,uVar4);
          cVar3 = FUN_18171e540(uVar4);
          if (cVar3) {
            iVar5 = iVar5 + 1;
          }
          local_res18[0] = local_res18[0] + 1;
        }
    }

    // Token : 0x6001659
    // RVA   : 0xC1C180   Offset: 0xC1B580   Length: 0x57
    public string GetExternalStorageFilePath()
    {
        bool cVar1;
        cVar1 = Directory.Exists(this.saveDataPath,0);
        if (!cVar1) {
          Directory.CreateDirectory(this.saveDataPath,0);
        }
        String.Concat(this.saveDataPath,"/ExternalStorateData.dat",0);
    }

    // Token : 0x600165A
    // RVA   : 0xC2A840   Offset: 0xC29C40   Length: 0xF1
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
        uVar1 = *(uint64 *)(*(int64 *)(DAT_181d72d50 + 184) + 24);
        uVar1 = JsonConvert.SerializeObject(uVar1,0);
        File.WriteAllText(uVar2,uVar1,0);
    }

    // Token : 0x600165B
    // RVA   : 0xC279C0   Offset: 0xC26DC0   Length: 0x1AE
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
            FUN_1800d6620();
          }
          JsonSerializerSettings.set_ObjectCreationHandling(lVar3,2);
          uVar1 = JsonConvert.DeserializeObject(uVar1,lVar3,DAT_181d80228);
          puVar4 = (uint64 *)(*(int64 *)(DAT_181d72d50 + 184) + 24);
          *puVar4 = uVar1;
          il2cpp_internal(puVar4,uVar1);
        }
    }

    // Token : 0x600165C
    // RVA   : 0xC1D770   Offset: 0xC1CB70   Length: 0x8B
    public void ItemIntoExternalStorage(ItemData targetItem)
    {
        long lVar1;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d72d50 + 184) + 24);
        if (lVar1 != null) {
          ItemListData.GetItem(lVar1,targetItem,0,0);
          GameDataController.SaveExternalStorageData(this,0);
          return;
        }
    }

    // Token : 0x600165D
    // RVA   : 0xC1D800   Offset: 0xC1CC00   Length: 0x8B
    public void ItemOutExternalStorage(ItemData targetItem)
    {
        long lVar1;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d72d50 + 184) + 24);
        if (lVar1 != null) {
          ItemListData.LoseItem(lVar1,targetItem,0,0);
          GameDataController.SaveExternalStorageData(this,0);
          return;
        }
    }

    // Token : 0x600165E
    // RVA   : 0xC1A430   Offset: 0xC19830   Length: 0x78
    public void ClearExternalStorage()
    {
        long lVar1;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d72d50 + 184) + 24);
        if (lVar1 != null) {
          ItemListData.ClearAllItem(lVar1,0);
          GameDataController.SaveExternalStorageData(this,0);
          return;
        }
    }

    // Token : 0x600165F
    // RVA   : 0xC1AED0   Offset: 0xC1A2D0   Length: 0x236
    public void GameIntoGameData()
    {
        var pStatics = *(int64*)(DAT_181d72cc8 + 184);
        long lVar1;
        long lVar2;
        if ((*pStatics != 0) &&
           (lVar1 = *(int64 *)(*pStatics + 32)) != null) {
          WorldData.SetPlayerMissionEventData(lVar1,0);
          lVar1 = this.gameSaveData;
          if ((*pStatics != 0) && (lVar1 != null)) {
            lVar1.WorldData = *(uint64 *)(*pStatics + 32);
            lVar1 = this.gameSaveData;
            if (((*pStatics != 0) &&
                (lVar2 = *(int64 *)(*pStatics + 32)) != null) &&
               (lVar1 != null)) {
              lVar1.HeroList = *(uint64 *)(lVar2 + 80);
              lVar1 = this.gameSaveData;
              if (((*pStatics != 0) &&
                  (lVar2 = *(int64 *)(*pStatics + 32)) != null) &&
                 (lVar1 != null)) {
                lVar1.TempHeroList = *(uint64 *)(lVar2 + 88);
                return;
              }
            }
          }
        }
    }

    // Token : 0x6001660
    // RVA   : 0xC1ACA0   Offset: 0xC1A0A0   Length: 0x22C
    public void GameDataIntoGame()
    {
        var pStatics = *(int64*)(DAT_181d72cc8 + 184);
        long lVar1;
        if ((this.gameSaveData != null) && (*pStatics != 0)) {
          *(uint64 *)(*pStatics + 32) =
               this.gameSaveData.WorldData;
          il2cpp_internal();
          if ((*pStatics != 0) && (this.gameSaveData != null)) {
            lVar1 = *(int64 *)(*pStatics + 32);
            if (lVar1 != null) {
              *(uint64 *)(lVar1 + 80) = this.gameSaveData.HeroList;
              if ((*pStatics != 0) && (this.gameSaveData != null)) {
                lVar1 = *(int64 *)(*pStatics + 32);
                if (lVar1 != null) {
                  *(uint64 *)(lVar1 + 88) = this.gameSaveData.TempHeroList;
                  if ((*pStatics != 0) &&
                     (lVar1 = *(int64 *)(*pStatics + 32)) != null) {
                    WorldData.RecoverPlayerMissionEventData(lVar1,0);
                    return;
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6001661
    // RVA   : 0xC1C9D0   Offset: 0xC1BDD0   Length: 0x126
    public string GetSaveDataPath(int saveID, int saveType)
    {
        bool cVar1;
        cVar1 = Directory.Exists(this.saveDataPath,0);
        if (!cVar1) {
          Directory.CreateDirectory(this.saveDataPath,0);
        }
        return this.saveDataPath;
    }

    // Token : 0x6001662
    // RVA   : 0xC1C5A0   Offset: 0xC1B9A0   Length: 0x126
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
        lVar1 = **(int64 **)(DAT_181d72d50 + 184);
        if (lVar1 != null) {
          if (*(uint32 *)(lVar1 + 24) <= saveType) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          String.Concat(uVar4,"/",
                         lVar1[saveType],
                         0);
          return;
        }
    }

    // Token : 0x6001663
    // RVA   : 0xC1C020   Offset: 0xC1B420   Length: 0x126
    public string GetBackupDataPath(int saveID, int saveType)
    {
        bool cVar1;
        cVar1 = Directory.Exists(this.backupDataPath,0);
        if (!cVar1) {
          Directory.CreateDirectory(this.backupDataPath,0);
        }
        return this.backupDataPath;
    }

    // Token : 0x6001664
    // RVA   : 0xC1C890   Offset: 0xC1BC90   Length: 0x13F
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
        lVar1 = **(int64 **)(DAT_181d72d50 + 184);
        if (lVar1 != null) {
          if (*(uint32 *)(lVar1 + 24) <= saveType) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          String.Concat(uVar4,"/",
                         lVar1[saveType],
                         0);
          return;
        }
    }

    // Token : 0x6001665
    // RVA   : 0xC2C1D0   Offset: 0xC2B5D0   Length: 0x172
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
        lVar4 = DAT_181d72d50;
        do {
          if (((*(byte *)(DAT_181d9ecf0 + 0x133) & 4) != 0) && (*(int *)(DAT_181d9ecf0 + 224) == 0)) {
            il2cpp_runtime_class_init(DAT_181d9ecf0);
            lVar4 = DAT_181d72d50;
          }
          if (**(int **)(DAT_181d9ecf0 + 184) <= iVar6) {
            return;
          }
          iVar5 = 0;
          while( true ) {
            if (((*(byte *)(lVar4 + 0x133) & 4) != 0) && (*(int *)(lVar4 + 224) == 0)) {
              il2cpp_runtime_class_init();
              lVar4 = DAT_181d72d50;
            }
            if (*plVar4 == 0) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
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
            lVar4 = DAT_181d72d50;
          }
          iVar6 = iVar6 + 1;
        } while( true );
    }

    // Token : 0x6001666
    // RVA   : 0xC1D390   Offset: 0xC1C790   Length: 0x1D
    public bool HaveSave(int saveID)
    {
        ulong uVar1;
        uVar1 = GameDataController.GetSaveDataPath(this,saveID,0,0);
        File.Exists(uVar1,0);
    }

    // Token : 0x6001667
    // RVA   : 0xC1A890   Offset: 0xC19C90   Length: 0x1C9
    public void DeleteSave(int saveID)
    {
        var pStatics = *(int64*)(DAT_181d72d50 + 184);
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
          if (*pStatics == 0) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          if (*(int *)(*pStatics + 24) <= (int)uVar5) {
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
          lVar1 = *pStatics;
          if (lVar1 == null) break;
          if (*(uint32 *)(lVar1 + 24) <= uVar5) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          uVar4 = String.Concat(uVar4,"/",*(uint64 *)(lVar6 + *(int64 *)(lVar1 + 16)),
                                 0);
          File.Delete(uVar4);
          uVar5 = uVar5 + 1;
          lVar6 = lVar6 + 8;
        }
    }

    // Token : 0x6001668
    // RVA   : 0xC1B710   Offset: 0xC1AB10   Length: 0x77C
    public SaveInfo GenerateSaveInfo()
    {
        var pStatics_2cc8 = *(int64*)(DAT_181d72cc8 + 184);
        var pStatics_3d40 = *(int64*)(DAT_181d73d40 + 184);
        uint uVar1;
        ulong uVar2;
        long lVar4;
        long lVar5;
        ulong uVar6;
        ulong uVar7;
        ulong uVar8;
        ulong local_res18;
        uVar2 = String.Concat(*(uint64 *)(pStatics_3d40 + 112)," ",
                               *(uint64 *)(pStatics_3d40 + 120),0);
        plVar3 = (int64 *)FUN_1800d60b0(DAT_181da5ce0,9);
        if ((((*pStatics_2cc8 != 0) &&
             (lVar4 = *(int64 *)(*pStatics_2cc8 + 32)) != null) &&
            (lVar4 = WorldData.Player(lVar4,0)) != null) &&
           (lVar4 = *(int64 *)(lVar4 + 104), plVar3 != (int64 *)0)) {
          if ((lVar4 != null) &&
             (lVar5 = il2cpp_internal(lVar4,*(uint64 *)(*plVar3 + 64))) == null) {
            uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar2,0);
          }
          if ((int)plVar3[3] == 0) {
            uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar2,0);
          }
          plVar3[4] = lVar4;
          il2cpp_internal(plVar3 + 4,lVar4);
          if (("\n" != 0) &&
             (lVar4 = il2cpp_internal("\n",*(uint64 *)(*plVar3 + 64))) == null) {
            uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar2,0);
          }
          lVar4 = "\n";
          if (*(uint32 *)(plVar3 + 3) < 2) {
            uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar2,0);
          }
          plVar3[5] = "\n";
          il2cpp_internal(plVar3 + 5,lVar4);
          if (((*pStatics_2cc8 != 0) &&
              (lVar4 = *(int64 *)(*pStatics_2cc8 + 32)) != null) &&
             (lVar4 = *(int64 *)(lVar4 + 168)) != null) {
            lVar4 = TimeData.GetDescribe(lVar4,0);
            if ((lVar4 != null) &&
               (lVar5 = il2cpp_internal(lVar4,*(uint64 *)(*plVar3 + 64))) == null) {
              uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar2,0);
            }
            if (*(uint32 *)(plVar3 + 3) < 3) {
              uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar2,0);
            }
            plVar3[6] = lVar4;
            il2cpp_internal(plVar3 + 6,lVar4);
            if (("\n" != 0) &&
               (lVar4 = il2cpp_internal("\n",*(uint64 *)(*plVar3 + 64))) == null) {
              uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar2,0);
            }
            lVar4 = "\n";
            if (*(uint32 *)(plVar3 + 3) < 4) {
              uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar2,0);
            }
            plVar3[7] = "\n";
            il2cpp_internal(plVar3 + 7,lVar4);
            lVar4 = *(int64 *)(pStatics_3d40 + 184);
            if (((*pStatics_2cc8 != 0) &&
                (lVar5 = *(int64 *)(*pStatics_2cc8 + 32)) != null) &&
               (lVar4 != null)) {
              uVar1 = *(uint32 *)(lVar5 + 156);
              if (*(uint32 *)(lVar4 + 24) <= uVar1) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar4 = lVar4[uVar1];
              if (lVar4 != null) {
                lVar4 = String.Substring(lVar4,0,2);
                if ((lVar4 != null) &&
                   (lVar5 = il2cpp_internal(lVar4,*(uint64 *)(*plVar3 + 64))) == null) {
                  uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar2,0);
                }
                if (*(uint32 *)(plVar3 + 3) < 5) {
                  uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar2,0);
                }
                plVar3[8] = lVar4;
                il2cpp_internal(plVar3 + 8,lVar4);
                if (("\n" != 0) &&
                   (lVar4 = il2cpp_internal("\n",*(uint64 *)(*plVar3 + 64)), lVar4 == null
                   )) {
                  uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar2,0);
                }
                lVar4 = "\n";
                if (*(uint32 *)(plVar3 + 3) < 6) {
                  uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar2,0);
                }
                plVar3[9] = "\n";
                il2cpp_internal(plVar3 + 9,lVar4);
                if ((*pStatics_2cc8 != 0) &&
                   (lVar4 = *(int64 *)(*pStatics_2cc8 + 32)) != null) {
                  lVar4 = WorldData.Player(lVar4,0);
                  if (lVar4 != null) {
                    lVar4 = HeroData.GetHeroForceLvDescribe(lVar4,1,0);
                    if ((lVar4 != null) &&
                       (lVar5 = il2cpp_internal(lVar4,*(uint64 *)(*plVar3 + 64))) == null) {
                      uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar2,0);
                    }
                    if (*(uint32 *)(plVar3 + 3) < 7) {
                      uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar2,0);
                    }
                    plVar3[10] = lVar4;
                    il2cpp_internal(plVar3 + 10,lVar4);
                    if (("\n" != 0) &&
                       (lVar4 = il2cpp_internal("\n",*(uint64 *)(*plVar3 + 64)),
                       lVar4 == null)) {
                      uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar2,0);
                    }
                    lVar4 = "\n";
                    if (*(uint32 *)(plVar3 + 3) < 8) {
                      uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar2,0);
                    }
                    plVar3[11] = "\n";
                    il2cpp_internal(plVar3 + 11,lVar4);
                    if ((*pStatics_2cc8 != 0) &&
                       (lVar4 = *(int64 *)(*pStatics_2cc8 + 32)) != null)
                    {
                      lVar4 = WorldData.GetDifficlutyName(lVar4,0);
                      if ((lVar4 != null) &&
                         (lVar5 = il2cpp_internal(lVar4,*(uint64 *)(*plVar3 + 64))) == null)
                      {
                        uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar2,0);
                      }
                      if (*(uint32 *)(plVar3 + 3) < 9) {
                        uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar2,0);
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

    // Token : 0x6001669
    // RVA   : 0xC1CB30   Offset: 0xC1BF30   Length: 0xCD
    public SaveInfo GetSaveInfo(int saveID)
    {
        ulong uVar1;
        long lVar2;
        uVar1 = GameDataController.GetSaveDataPath(this,saveID,3);
        uVar1 = File.ReadAllText(uVar1,0);
        lVar2 = new JsonSerializerSettings(0);
        if (lVar2 != null) {
          JsonSerializerSettings.set_ObjectCreationHandling(lVar2,2);
          JsonConvert.DeserializeObject(uVar1,lVar2,DAT_181d80328);
          return;
        }
    }

    // Token : 0x600166A
    // RVA   : 0xC2A5E0   Offset: 0xC299E0   Length: 0x13C
    public void MoveSaveToBackUp(int saveID)
    {
        var pStatics = *(int64*)(DAT_181d72d50 + 184);
        bool cVar1;
        ulong uVar2;
        ulong uVar3;
        int iVar4;
        iVar4 = 0;
        while( true ) {
          if (*pStatics == 0) break;
          if (*(int *)(*pStatics + 24) <= iVar4) {
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

    // Token : 0x600166B
    // RVA   : 0xC2A4A0   Offset: 0xC298A0   Length: 0x13C
    public void MoveBackUpToSafe(int saveID)
    {
        var pStatics = *(int64*)(DAT_181d72d50 + 184);
        bool cVar1;
        ulong uVar2;
        ulong uVar3;
        int iVar4;
        iVar4 = 0;
        while( true ) {
          if (*pStatics == 0) break;
          if (*(int *)(*pStatics + 24) <= iVar4) {
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

    // Token : 0x600166C
    // RVA   : 0xC2AA40   Offset: 0xC29E40   Length: 0x6C7
    public void Save(int saveID)
    {
        var pStatics = *(int64*)(DAT_181d72d50 + 184);
        long lVar1;
        bool cVar2;
        ulong uVar3;
        ulong uVar4;
        ulong uVar5;
        ulong uVar6;
        ulong uVar7;
        ulong local_38;
        ulong uStack_30;
        plVar10 = (int64 *)0;
        if (this.gameSaveData == null) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        cVar2 = GameSaveData.CheckAllFinished(this.gameSaveData,0);
        if (cVar2) {
          GameDataController.GameIntoGameData(this,0);
          if (this.gameSaveData == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          GameSaveData.SetAllUnfinish(this.gameSaveData,0,0);
          if (this.gameSaveData == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          uVar3 = this.gameSaveData.WorldData;
          uVar3 = JsonConvert.SerializeObject(uVar3,0);
          if (this.gameSaveData == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          uVar4 = JsonConvert.SerializeObject(this.gameSaveData.HeroList,0);
          if (this.gameSaveData == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          uVar5 = JsonConvert.SerializeObject(this.gameSaveData.TempHeroList,0);
          uVar6 = GameDataController.GetSaveDataPath(this,saveID,3);
          uVar7 = GameDataController.GenerateSaveInfo(this,0);
          uVar7 = JsonConvert.SerializeObject(uVar7,0);
          File.WriteAllText(uVar6,uVar7,0);
          uVar6 = GameDataController.GetSaveDataPath(this,saveID,0,0);
          File.WriteAllText(uVar6,uVar3,0);
          uVar3 = GameDataController.GetSaveDataPath(this,saveID,1);
          File.WriteAllText(uVar3,uVar4,0);
          uVar3 = GameDataController.GetSaveDataPath(this,saveID,2);
          File.WriteAllText(uVar3,uVar5,0);
          GameDataController.SavePlayerprefData(this,0);
          plVar9 = plVar10;
          while( true ) {
            if (*pStatics == 0) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            if (*(int *)(*pStatics + 24) <= (int)plVar9) break;
            uVar3 = GameDataController.GetSaveDataPath(this,saveID,plVar9,0);
            cVar2 = File.Exists(uVar3,0);
            if (cVar2) {
              uVar3 = GameDataController.GetBackupDataPath(this,saveID,plVar9);
              cVar2 = File.Exists(uVar3,0);
              if (cVar2) {
                uVar3 = GameDataController.GetBackupDataPath(this,saveID,plVar9);
                File.Delete(uVar3,0);
              }
              uVar3 = GameDataController.GetSaveDataPath(this,saveID,plVar9,0);
              uVar4 = GameDataController.GetBackupDataPath(this,saveID);
              File.Copy(uVar3,uVar4);
            }
            plVar9 = (int64 *)(uint64)((int)plVar9 + 1);
          }
          lVar1 = **(int64 **)(DAT_181d7f6a8 + 184);
          uVar3 = "自动";
          if ((saveID != null) && (uVar3 = "", saveID == 10)) {
            uVar3 = "快速";
          }
          uVar3 = String.Format("{0}存档成功！",uVar3,0);
          puVar8 = (uint64 *)Color.get_green(&local_38,0);
          if (lVar1 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          local_38 = *puVar8;
          uStack_30 = puVar8[1];
          InfoController.AddInfoTab
                    (lVar1,uVar3,"UIAtlas","从事工作_学习","Woosh",0x3f800000,0x40a00000,&local_38
                     ,0);
          plVar9 = (int64 *)Resources.Load("Sound/SoundEffect/NoticeLittle",0);
          if ((plVar9 != (int64 *)0) && (*plVar9 == DAT_181daf348)) {
            plVar10 = plVar9;
          }
          NGUITools.PlaySound(plVar10,0);
          if (this.gameSaveData == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          this.gameSaveData.worldDataFinished = 1;
          if (this.gameSaveData == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          this.gameSaveData.heroListFinished = 1;
          if (this.gameSaveData == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          this.gameSaveData.tempHeroListFinished = 1;
        }
    }

    // Token : 0x600166D
    // RVA   : 0xC2A2A0   Offset: 0xC296A0   Length: 0x1FC
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
                  lVar1 = FUN_18020f0e0(0);
                  uVar4 = new OnTooltipCB(lVar3,DAT_181da4708,0);
                  if (lVar1 != null) {
                    TaskFactory.StartNew(lVar1,uVar4,2);
                    lVar1 = FUN_18020f0e0(0);
                    uVar4 = new OnTooltipCB(lVar3,DAT_181da4788,0);
                    if (lVar1 != null) {
                      TaskFactory.StartNew(lVar1,uVar4,2);
                      lVar1 = FUN_18020f0e0(0);
                      uVar4 = new OnTooltipCB(lVar3,DAT_181da4808,0);
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

    // Token : 0x600166E
    // RVA   : 0xC1CB00   Offset: 0xC1BF00   Length: 0x2D
    public string GetSaveDataPath()
    {
        bool cVar1;
        cVar1 = Directory.Exists(this.saveDataPath,0);
        if (!cVar1) {
          Directory.CreateDirectory(this.saveDataPath,0);
        }
        return this.saveDataPath;
    }

    // Token : 0x600166F
    // RVA   : 0xC1C150   Offset: 0xC1B550   Length: 0x2D
    public string GetBackupDataPath()
    {
        bool cVar1;
        cVar1 = Directory.Exists(this.backupDataPath,0);
        if (!cVar1) {
          Directory.CreateDirectory(this.backupDataPath,0);
        }
        return this.backupDataPath;
    }

    // Token : 0x6001670
    // RVA   : 0xC1D890   Offset: 0xC1CC90   Length: 0xA120
    private void LoadAllGameData()
    {
        var plVar12 = *(int64*)(lVar12 + 184);
        var pStatics = *(int64*)(DAT_181d73d40 + 184);
        bool cVar3;
        byte uVar4;
        int iVar5;
        int iVar6;
        uint uVar7;
        ulong uVar8;
        long lVar10;
        long lVar11;
        long lVar12;
        long lVar13;
        ulong uVar14;
        long lVar15;
        long lVar16;
        long lVar19;
        long lVar20;
        int iVar21;
        int iVar22;
        int iVar23;
        uint uVar24;
        uint uVar25;
        float fVar26;
        int local_res18;
        uint32 uStackX_1c;
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
        uVar8 = DAT_181dc2db8;
        local_d0 = 0;
        uStack_c8 = 0;
        local_c0 = 0;
        local_e8 = 0;
        uStack_e0 = 0;
        local_d8 = 0;
        uVar8 = Type.GetTypeFromHandle(uVar8,0);
        plVar9 = (int64 *)Resources.Load("GameData/NameData",uVar8,0);
        if (plVar9 != (int64 *)0) {
          plVar17 = plVar9;
          plVar17 = plVar9;
          uVar8 = FUN_180da4db0(plVar17,0);
          lVar10 = new c.DisplayClass9_0(0);
          if (lVar10 != null) {
            LTCSVLoader.ReadMultiLine(lVar10,uVar8,0);
            iVar5 = LTCSVLoader.GetRow(lVar10,0);
            iVar21 = 1;
            if (1 < iVar5) {
              do {
                lVar11 = LTCSVLoader.GetValueAt(lVar10,0,iVar21,0);
                if (lVar11 != null) {
                  cVar3 = FUN_18171e540(lVar11,"姓",0);
                  if (!cVar3) {
                    cVar3 = FUN_18171e540(lVar11,"名",0);
                    if (!cVar3) {
                      cVar3 = FUN_18171e540(lVar11,"男名",0);
                      if (!cVar3) {
                        cVar3 = FUN_18171e540(lVar11,"女名",0);
                        if (cVar3) {
                          iVar23 = 1;
                          do {
                            lVar11 = LTCSVLoader.GetValueAt(lVar10,iVar23,iVar21,0);
                            if (lVar11 != null) {
                              uVar8 = LTCSVLoader.GetValueAt(lVar10,iVar23,iVar21,0);
                              cVar3 = String.op_Inequality(uVar8,"",0);
                              if (cVar3) {
                                lVar11 = this.femaleGivenNameDataBase;
                                uVar8 = LTCSVLoader.GetValueAt(lVar10,iVar23,iVar21,0);
                                if (lVar11 == null) goto LAB_180c27762;
                                FUN_18181e0a0(lVar11,uVar8,DAT_181da3d58);
                              }
                            }
                            iVar23 = iVar23 + 1;
                          } while (iVar23 < 6);
                        }
                      }
                      else {
                        iVar23 = 1;
                        do {
                          lVar11 = LTCSVLoader.GetValueAt(lVar10,iVar23,iVar21,0);
                          if (lVar11 != null) {
                            uVar8 = LTCSVLoader.GetValueAt(lVar10,iVar23,iVar21,0);
                            cVar3 = String.op_Inequality(uVar8,"",0);
                            if (cVar3) {
                              lVar11 = this.maleGivenNameDataBase;
                              uVar8 = LTCSVLoader.GetValueAt(lVar10,iVar23,iVar21,0);
                              if (lVar11 == null) goto LAB_180c27762;
                              FUN_18181e0a0(lVar11,uVar8,DAT_181da3d58);
                            }
                          }
                          iVar23 = iVar23 + 1;
                        } while (iVar23 < 6);
                      }
                    }
                    else {
                      iVar23 = 1;
                      do {
                        lVar11 = LTCSVLoader.GetValueAt(lVar10,iVar23,iVar21,0);
                        if (lVar11 != null) {
                          uVar8 = LTCSVLoader.GetValueAt(lVar10,iVar23,iVar21,0);
                          cVar3 = String.op_Inequality(uVar8,"",0);
                          if (cVar3) {
                            lVar11 = this.givenNameDataBase;
                            uVar8 = LTCSVLoader.GetValueAt(lVar10,iVar23,iVar21,0);
                            if (lVar11 == null) goto LAB_180c27762;
                            FUN_18181e0a0(lVar11,uVar8,DAT_181da3d58);
                          }
                        }
                        iVar23 = iVar23 + 1;
                      } while (iVar23 < 6);
                    }
                  }
                  else {
                    iVar23 = 1;
                    do {
                      lVar11 = LTCSVLoader.GetValueAt(lVar10,iVar23,iVar21,0);
                      if (lVar11 != null) {
                        uVar8 = LTCSVLoader.GetValueAt(lVar10,iVar23,iVar21,0);
                        cVar3 = String.op_Inequality(uVar8,"",0);
                        if (cVar3) {
                          lVar11 = this.familyNameDataBase;
                          uVar8 = LTCSVLoader.GetValueAt(lVar10,iVar23,iVar21,0);
                          if (lVar11 == null) goto LAB_180c27762;
                          FUN_18181e0a0(lVar11,uVar8,DAT_181da3d58);
                        }
                      }
                      iVar23 = iVar23 + 1;
                    } while (iVar23 < 6);
                  }
                }
                iVar21 = iVar21 + 1;
              } while (iVar21 < iVar5);
            }
            uVar8 = DAT_181dc2db8;
            uVar8 = Type.GetTypeFromHandle(uVar8,0);
            plVar9 = (int64 *)Resources.Load("GameData/SpeAddDataBase",uVar8,0);
            if (plVar9 != (int64 *)0) {
              plVar17 = plVar9;
              plVar17 = plVar9;
              uVar8 = FUN_180da4db0(plVar17,0);
              lVar10 = new c.DisplayClass9_0(0);
              if (lVar10 != null) {
                LTCSVLoader.ReadMultiLine(lVar10,uVar8,0);
                iVar5 = LTCSVLoader.GetRow(lVar10,0);
                iVar21 = 1;
                if (1 < iVar5) {
                  do {
                    lVar11 = new c.DisplayClass9_0(0);
                    uVar8 = LTCSVLoader.GetValueAt(lVar10,1,iVar21);
                    if (lVar11 == null) goto LAB_180c27762;
                    lVar11._items = uVar8;
                    uVar8 = LTCSVLoader.GetValueAt(lVar10,2,iVar21);
                    uVar24 = Single.Parse(uVar8,0);
                    *(uint32 *)(lVar11 + 32) = uVar24;
                    uVar8 = LTCSVLoader.GetValueAt(lVar10,3,iVar21);
                    *(uint64 *)(lVar11 + 40) = uVar8;
                    uVar8 = LTCSVLoader.GetValueAt(lVar10,4,iVar21);
                    *(uint64 *)(lVar11 + 48) = uVar8;
                    uVar8 = LTCSVLoader.GetValueAt(lVar10,5,iVar21);
                    uVar4 = FUN_18171e540(uVar8,"1",0);
                    *(uint8 *)(lVar11 + 56) = uVar4;
                    uVar8 = LTCSVLoader.GetValueAt(lVar10,6,iVar21);
                    uVar4 = FUN_18171e540(uVar8,"1",0);
                    *(uint8 *)(lVar11 + 57) = uVar4;
                    uVar8 = LTCSVLoader.GetValueAt(lVar10,7,iVar21);
                    uVar4 = FUN_18171e540(uVar8,"0",0);
                    *(uint8 *)(lVar11 + 58) = uVar4;
                    uVar8 = LTCSVLoader.GetValueAt(lVar10,8,iVar21);
                    uVar24 = Int32.Parse(uVar8,0);
                    *(uint32 *)(lVar11 + 60) = uVar24;
                    uVar8 = LTCSVLoader.GetValueAt(lVar10,9,iVar21);
                    uVar4 = FUN_18171e540(uVar8,"1",0);
                    *(uint8 *)(lVar11 + 64) = uVar4;
                    uVar8 = LTCSVLoader.GetValueAt(lVar10,10,iVar21);
                    lVar11.Count = uVar8;
                    uVar8 = LTCSVLoader.GetValueAt(lVar10,11,iVar21);
                    *(uint64 *)(lVar11 + 72) = uVar8;
                    uVar8 = LTCSVLoader.GetValueAt(lVar10,12,iVar21);
                    uVar4 = FUN_18171e540(uVar8,"1",0);
                    *(uint8 *)(lVar11 + 80) = uVar4;
                    uVar8 = LTCSVLoader.GetValueAt(lVar10,13,iVar21);
                    uVar24 = Int32.Parse(uVar8,0);
                    *(uint32 *)(lVar11 + 84) = uVar24;
                    uVar8 = LTCSVLoader.GetValueAt(lVar10,14,iVar21);
                    uVar4 = FUN_18171e540(uVar8,"1",0);
                    *(uint8 *)(lVar11 + 88) = uVar4;
                    uVar8 = LTCSVLoader.GetValueAt(lVar10,15,iVar21);
                    uVar4 = FUN_18171e540(uVar8,"1",0);
                    *(uint8 *)(lVar11 + 89) = uVar4;
                    uVar8 = LTCSVLoader.GetValueAt(lVar10,16,iVar21);
                    uVar4 = FUN_18171e540(uVar8,"1",0);
                    *(uint8 *)(lVar11 + 90) = uVar4;
                    if (this.speAddDataBase == null) goto LAB_180c27762;
                    FUN_18181e0a0(this.speAddDataBase,lVar11,DAT_181d8bf18);
                    if (*(char *)(lVar11 + 57) == false) {
                      if ((this.speAddDataBase == null) || (this.randomSpeAddAvailableID == null))
                      goto LAB_180c27762;
                      FUN_18182a0b0(this.randomSpeAddAvailableID,
                                    this.speAddDataBase.Count + -1,DAT_181d8f218);
                      if (*(char *)(lVar11 + 58) != false) {
                        if ((this.speAddDataBase == null) || (this.randomSpeAddNegativeAvailableID == null))
                        goto LAB_180c27762;
                        FUN_18182a0b0(this.randomSpeAddNegativeAvailableID,
                                      this.speAddDataBase.Count + -1,DAT_181d8f218);
                      }
                      if (*(char *)(lVar11 + 64) != false) {
                        if ((this.speAddDataBase == null) || (this.randomSpeAddSelfBuffID == null))
                        goto LAB_180c27762;
                        FUN_18182a0b0(this.randomSpeAddSelfBuffID,
                                      this.speAddDataBase.Count + -1,DAT_181d8f218);
                      }
                      if ((0 < *(int *)(lVar11 + 60)) && (*(char *)(lVar11 + 64) == false)) {
                        if ((this.speAddDataBase == null) || (this.randomSpeAddEnemyBuffID == null))
                        goto LAB_180c27762;
                        FUN_18182a0b0(this.randomSpeAddEnemyBuffID,
                                      this.speAddDataBase.Count + -1,DAT_181d8f218);
                      }
                    }
                    iVar21 = iVar21 + 1;
                  } while (iVar21 < iVar5);
                }
                uVar8 = DAT_181dc2db8;
                uVar8 = Type.GetTypeFromHandle(uVar8,0);
                plVar9 = (int64 *)Resources.Load("GameData/ForceSpeAddDataBase",uVar8,0);
                if (plVar9 != (int64 *)0) {
                  plVar17 = plVar9;
                  plVar17 = plVar9;
                  uVar8 = FUN_180da4db0(plVar17,0);
                  lVar10 = new c.DisplayClass9_0(0);
                  if (lVar10 != null) {
                    LTCSVLoader.ReadMultiLine(lVar10,uVar8,0);
                    iVar5 = LTCSVLoader.GetRow(lVar10,0);
                    iVar21 = 1;
                    if (1 < iVar5) {
                      do {
                        lVar11 = new c.DisplayClass9_0(0);
                        uVar8 = LTCSVLoader.GetValueAt(lVar10,1,iVar21);
                        if (lVar11 == null) goto LAB_180c27762;
                        lVar11._items = uVar8;
                        uVar8 = LTCSVLoader.GetValueAt(lVar10,2,iVar21);
                        lVar11.Count = uVar8;
                        uVar8 = LTCSVLoader.GetValueAt(lVar10,3,iVar21);
                        uVar4 = FUN_18171e540(uVar8,"TRUE",0);
                        *(uint8 *)(lVar11 + 32) = uVar4;
                        uVar8 = LTCSVLoader.GetValueAt(lVar10,4,iVar21);
                        uVar24 = Single.Parse(uVar8,0);
                        *(uint32 *)(lVar11 + 36) = uVar24;
                        if (this.forceSpeAddDataBase == null) goto LAB_180c27762;
                        FUN_18181e0a0(this.forceSpeAddDataBase,lVar11,DAT_181d88798);
                        iVar21 = iVar21 + 1;
                      } while (iVar21 < iVar5);
                    }
                    uVar8 = DAT_181dc2db8;
                    uVar8 = Type.GetTypeFromHandle(uVar8,0);
                    plVar9 = (int64 *)Resources.Load("GameData/TechDataBase",uVar8,0);
                    if (plVar9 != (int64 *)0) {
                      plVar17 = plVar9;
                      plVar17 = plVar9;
                      uVar8 = FUN_180da4db0(plVar17,0);
                      lVar10 = new c.DisplayClass9_0(0);
                      if (lVar10 != null) {
                        LTCSVLoader.ReadMultiLine(lVar10,uVar8,0);
                        iVar5 = LTCSVLoader.GetRow(lVar10,0);
                        uVar8 = il2cpp_internal(DAT_181d80d68);
                        FUN_1808b1370(uVar8,DAT_181db9870);
                        this.forceTechDataBase = uVar8;
                        iVar21 = 1;
                        if (1 < iVar5) {
                          do {
                            lVar11 = new c.DisplayClass9_0(0);
                            uVar8 = LTCSVLoader.GetValueAt(lVar10,0,iVar21,0);
                            uVar24 = Int32.Parse(uVar8,0);
                            if (lVar11 == null) goto LAB_180c27762;
                            lVar11._items = uVar24;
                            uVar8 = LTCSVLoader.GetValueAt(lVar10,1,iVar21);
                            lVar11.Count = uVar8;
                            uVar8 = LTCSVLoader.GetValueAt(lVar10,2,iVar21);
                            *(uint64 *)(lVar11 + 32) = uVar8;
                            uVar8 = LTCSVLoader.GetValueAt(lVar10,3,iVar21);
                            uVar24 = Int32.Parse(uVar8,0);
                            *(uint32 *)(lVar11 + 40) = uVar24;
                            iVar23 = 0;
                            while( true ) {
                              if (this.forceSpeAddDataBase == null) goto LAB_180c27762;
                              if (this.forceSpeAddDataBase.Count <= iVar23) break;
                              uVar8 = LTCSVLoader.GetValueAt(lVar10,4,iVar21);
                              if ((this.forceSpeAddDataBase == null) ||
                                 (lVar12 = FUN_180002f80(this.forceSpeAddDataBase,iVar23,
                                                         DAT_181d88898), lVar12 == null)) goto LAB_180c27762;
                              cVar3 = FUN_18171e540(uVar8,lVar12.buckets,0);
                              if (cVar3) {
                                *(int *)(lVar11 + 44) = iVar23;
                              }
                              iVar23 = iVar23 + 1;
                            }
                            uVar8 = LTCSVLoader.GetValueAt(lVar10,5,iVar21);
                            uVar24 = Single.Parse(uVar8,0);
                            *(uint32 *)(lVar11 + 48) = uVar24;
                            uVar8 = LTCSVLoader.GetValueAt(lVar10,6,iVar21);
                            uVar4 = FUN_18171e540(uVar8,"TRUE",0);
                            *(uint8 *)(lVar11 + 52) = uVar4;
                            uVar8 = LTCSVLoader.GetValueAt(lVar10,7,iVar21);
                            uVar24 = Single.Parse(uVar8,0);
                            *(uint32 *)(lVar11 + 56) = uVar24;
                            lVar12 = *(int64 *)(pStatics + 0x438);
                            uVar8 = LTCSVLoader.GetValueAt(lVar10,8,iVar21);
                            if (lVar12 == null) goto LAB_180c27762;
                            uVar24 = FUN_1817eb4e0(lVar12,uVar8,DAT_181da3fd8);
                            *(uint32 *)(lVar11 + 60) = uVar24;
                            if (this.forceTechDataBase == null) goto LAB_180c27762;
                            FUN_1808ab370(this.forceTechDataBase,lVar11._items,
                                          lVar11);
                            iVar21 = iVar21 + 1;
                          } while (iVar21 < iVar5);
                        }
                        uVar8 = DAT_181dc2db8;
                        uVar8 = Type.GetTypeFromHandle(uVar8,0);
                        plVar9 = (int64 *)Resources.Load("GameData/AreaData",uVar8,0);
                        if (plVar9 != (int64 *)0) {
                          plVar17 = plVar9;
                          plVar17 = plVar9;
                          uVar8 = FUN_180da4db0(plVar17,0);
                          lVar10 = new c.DisplayClass9_0(0);
                          if (lVar10 != null) {
                            LTCSVLoader.ReadMultiLine(lVar10,uVar8,0);
                            iVar5 = LTCSVLoader.GetRow(lVar10,0);
                            uVar8 = il2cpp_internal(DAT_181d809e8);
                            FUN_1808b1370(uVar8,DAT_181db7ce8);
                            *(uint64 *)(this + 200) = uVar8;
                            iVar21 = 1;
                            if (1 < iVar5) {
                              do {
                                lVar11 = new AreaData(0);
                                uVar8 = LTCSVLoader.GetValueAt(lVar10,0,iVar21,0);
                                uVar24 = Int32.Parse(uVar8,0);
                                if (lVar11 == null) goto LAB_180c27762;
                                lVar11._items = uVar24;
                                uVar8 = LTCSVLoader.GetValueAt(lVar10,1,iVar21);
                                lVar11.Count = uVar8;
                                lVar12 = LTCSVLoader.GetValueAt(lVar10,2,iVar21);
                                if (lVar12 != null) {
                                  cVar3 = FUN_18171e540(lVar12,"城市",0);
                                  if (!cVar3) {
                                    cVar3 = FUN_18171e540(lVar12,"村镇",0);
                                    if (!cVar3) {
                                      cVar3 = FUN_18171e540(lVar12,"门派",0);
                                      if (cVar3) {
                                        *(uint32 *)(lVar11 + 72) = 2;
                                      }
                                    }
                                    else {
                                      *(uint32 *)(lVar11 + 72) = 1;
                                    }
                                  }
                                  else {
                                    *(uint32 *)(lVar11 + 72) = 0;
                                  }
                                }
                                uVar8 = LTCSVLoader.GetValueAt(lVar10,3,iVar21);
                                *(uint64 *)(lVar11 + 40) = uVar8;
                                uVar8 = LTCSVLoader.GetValueAt(lVar10,4,iVar21);
                                uVar24 = Int32.Parse(uVar8,0);
                                *(uint32 *)(lVar11 + 112) = uVar24;
                                lVar12 = LTCSVLoader.GetValueAt(lVar10,5,iVar21);
                                lVar13 = FUN_1800d60b0(DAT_181da1040,1);
                                if ((lVar13 == null) || (FUN_1800048e0(lVar13,0,44), lVar12 == null))
                                goto LAB_180c27762;
                                lVar12 = String.Split(lVar12,lVar13,0);
                                iVar23 = 0;
                                while( true ) {
                                  if (lVar12 == null) goto LAB_180c27762;
                                  if (lVar12.entries <= iVar23) break;
                                  lVar13 = *(int64 *)(lVar11 + 152);
                                  uVar8 = FUN_1800021a0(lVar12,(int64)iVar23);
                                  uVar24 = Int32.Parse(uVar8,0);
                                  if (lVar13 == null) goto LAB_180c27762;
                                  FUN_18182a0b0(lVar13,uVar24,DAT_181d8f218);
                                  iVar23 = iVar23 + 1;
                                }
                                uVar8 = LTCSVLoader.GetValueAt(lVar10,6,iVar21);
                                uVar24 = Int32.Parse(uVar8,0);
                                *(uint32 *)(lVar11 + 32) = uVar24;
                                uVar8 = LTCSVLoader.GetValueAt(lVar10,7,iVar21);
                                *(uint64 *)(lVar11 + 48) = uVar8;
                                uVar8 = LTCSVLoader.GetValueAt(lVar10,8,iVar21);
                                cVar3 = FUN_18171e540(uVar8,"-1",0);
                                if (!cVar3) {
                                  uVar8 = LTCSVLoader.GetValueAt(lVar10,8,iVar21);
                                  uVar24 = Int32.Parse(uVar8,0);
                                }
                                else {
                                  uVar24 = GlobalData.RandomRange(0,4,0);
                                }
                                *(uint32 *)(lVar11 + 56) = uVar24;
                                uVar8 = LTCSVLoader.GetValueAt(lVar10,9,iVar21);
                                uVar24 = Single.Parse(uVar8,0);
                                *(uint32 *)(lVar11 + 60) = uVar24;
                                uVar8 = LTCSVLoader.GetValueAt(lVar10,10,iVar21);
                                cVar3 = FUN_180d755b0(uVar8,0);
                                if (!cVar3) {
                                  uVar8 = LTCSVLoader.GetValueAt(lVar10,10,iVar21);
                                  cVar3 = String.op_Inequality(uVar8,"无",0);
                                  if (!cVar3) goto LAB_180c1f62e;
                                  lVar12 = LTCSVLoader.GetValueAt(lVar10,10,iVar21);
                                  lVar13 = FUN_1800d60b0(DAT_181da1040,1);
                                  if ((lVar13 == null) || (FUN_1800048e0(lVar13,0,32), lVar12 == null))
                                  goto LAB_180c27762;
                                  uVar14 = String.Split(lVar12,lVar13,0);
                                  uVar8 = il2cpp_internal(DAT_181d97750);
                                  FUN_181827480(uVar8,uVar14,DAT_181da3c58);
                                  *(uint64 *)(lVar11 + 0x108) = uVar8;
                                }
                                else {
        LAB_180c1f62e:
                                  uVar8 = il2cpp_internal(DAT_181d97750);
                                  FUN_18132faf0(uVar8,DAT_181da3bd8);
                                  *(uint64 *)(lVar11 + 0x108) = uVar8;
                                }
                                il2cpp_internal(lVar11 + 0x108,uVar8);
                                lVar12 = LTCSVLoader.GetValueAt(lVar10,11,iVar21);
                                lVar13 = FUN_1800d60b0(DAT_181da1040,1);
                                if ((lVar13 == null) || (FUN_1800048e0(lVar13,0,59), lVar12 == null))
                                goto LAB_180c27762;
                                lVar13 = String.Split(lVar12,lVar13,0);
                                lVar12 = *(int64 *)(lVar11 + 64);
                                if (lVar13 == null) goto LAB_180c27762;
                                uVar8 = FUN_1800021a0(lVar13,0);
                                uVar24 = Single.Parse(uVar8,0);
                                uVar8 = FUN_1800021a0(lVar13,1);
                                uVar25 = Single.Parse(uVar8,0);
                                local_110 = CONCAT44(uVar25,uVar24);
                                if (lVar12 == null) goto LAB_180c27762;
                                local_f8 = local_110;
                                local_f0 = 0;
                                BigMapPos.SetByVector3(lVar12,&local_f8,0);
                                uVar8 = LTCSVLoader.GetValueAt(lVar10,12,iVar21);
                                cVar3 = FUN_18171e540(uVar8,"0",0);
                                if (!cVar3) {
                                  lVar12 = LTCSVLoader.GetValueAt(lVar10,12,iVar21);
                                  lVar13 = FUN_1800d60b0(DAT_181da1040,1);
                                  if ((lVar13 == null) || (FUN_1800048e0(lVar13,0,59), lVar12 == null))
                                  goto LAB_180c27762;
                                  lVar13 = String.Split(lVar12,lVar13,0);
                                  lVar12 = il2cpp_internal(DAT_181d96ed0);
                                  FUN_18132faf0(lVar12,DAT_181da0cf8);
                                  if (lVar13 == null) goto LAB_180c27762;
                                  uVar8 = FUN_1800021a0(lVar13,0);
                                  uVar24 = Single.Parse(uVar8,0);
                                  if (lVar12 == null) goto LAB_180c27762;
                                  FUN_18181de10(lVar12,uVar24,DAT_181da0df8);
                                  uVar8 = FUN_1800021a0(lVar13,1);
                                  uVar24 = Single.Parse(uVar8,0);
                                  FUN_18181de10(lVar12,uVar24,DAT_181da0df8);
                                  *(int64 *)(lVar11 + 0x110) = lVar12;
                                }
                                else {
                                  *(uint64 *)(lVar11 + 0x110) = 0;
                                  lVar12 = 0;
                                }
                                il2cpp_internal(lVar11 + 0x110,lVar12);
                                cVar3 = FUN_18171e540(*(uint64 *)(lVar11 + 40),"村镇",0);
                                if (cVar3) {
                                  uVar8 = String.Concat(*(uint64 *)(lVar11 + 40),"_",
                                                         *(uint64 *)(lVar11 + 48),0);
                                  *(uint64 *)(lVar11 + 40) = uVar8;
                                }
                                if (*(int64 *)(this + 200) == 0) goto LAB_180c27762;
                                FUN_1808ab370(*(int64 *)(this + 200),lVar11._items,
                                              lVar11);
                                iVar21 = iVar21 + 1;
                              } while (iVar21 < iVar5);
                            }
                            uVar8 = DAT_181dc2db8;
                            uVar8 = Type.GetTypeFromHandle(uVar8,0);
                            plVar9 = (int64 *)Resources.Load("GameData/ResourcePointTypeData",uVar8,0);
                            if (plVar9 != (int64 *)0) {
                              plVar17 = plVar9;
                              plVar17 = plVar9;
                              uVar8 = FUN_180da4db0(plVar17,0);
                              lVar10 = new c.DisplayClass9_0(0);
                              if (lVar10 != null) {
                                LTCSVLoader.ReadMultiLine(lVar10,uVar8,0);
                                iVar5 = LTCSVLoader.GetRow(lVar10,0);
                                lVar11 = il2cpp_internal(DAT_181d81568);
                                FUN_1808b1370(lVar11,DAT_181dbd998);
                                this.resourcePointTypeDataBase = lVar11;
                                iVar21 = 1;
                                if (1 < iVar5) {
                                  do {
                                    lVar11 = new ResourcePointTypeData(0);
                                    uVar8 = LTCSVLoader.GetValueAt(lVar10,0,iVar21,0);
                                    uVar24 = Int32.Parse(uVar8,0);
                                    if (lVar11 == null) goto LAB_180c27762;
                                    lVar11._items = uVar24;
                                    uVar8 = LTCSVLoader.GetValueAt(lVar10,1,iVar21);
                                    lVar11.Count = uVar8;
                                    uVar8 = LTCSVLoader.GetValueAt(lVar10,2,iVar21);
                                    cVar3 = String.op_Inequality(uVar8,"",0);
                                    if (cVar3) {
                                      lVar12 = LTCSVLoader.GetValueAt(lVar10,2,iVar21);
                                      lVar13 = FUN_1800d60b0(DAT_181da1040,1);
                                      if ((lVar13 == null) || (FUN_1800048e0(lVar13,0,44), lVar12 == null))
                                      goto LAB_180c27762;
                                      lVar12 = String.Split(lVar12,lVar13,0);
                                      iVar23 = 0;
                                      while( true ) {
                                        if (lVar12 == null) goto LAB_180c27762;
                                        if (lVar12.entries <= iVar23) break;
                                        lVar13 = FUN_1800021a0(lVar12,(int64)iVar23);
                                        lVar15 = FUN_1800d60b0(DAT_181da1040,1);
                                        if ((lVar15 == null) || (FUN_1800048e0(lVar15,0,43), lVar13 == null))
                                        goto LAB_180c27762;
                                        lVar13 = String.Split(lVar13,lVar15,0);
                                        lVar15 = *(int64 *)
                                                  (pStatics + 0x438);
                                        if ((lVar13 == null) ||
                                           (uVar8 = FUN_1800021a0(lVar13,0), lVar15 == null))
                                        goto LAB_180c27762;
                                        uVar24 = FUN_1817eb4e0(lVar15,uVar8,DAT_181da3fd8);
                                        lVar15 = *(int64 *)(lVar11 + 32);
                                        uVar8 = FUN_1800021a0(lVar13,1);
                                        iVar6 = Int32.Parse(uVar8,0);
                                        lVar13 = *(int64 *)
                                                  (pStatics + 0x448);
                                        if ((lVar13 == null) ||
                                           (fVar26 = (float)FUN_1800d6790(lVar13,uVar24,DAT_181da1078),
                                           lVar15 == null)) goto LAB_180c27762;
                                        FUN_181829d40(lVar15,uVar24,(float)(iVar6 * 50) / fVar26);
                                        iVar23 = iVar23 + 1;
                                      }
                                    }
                                    uVar8 = LTCSVLoader.GetValueAt(lVar10,3,iVar21);
                                    cVar3 = String.op_Inequality(uVar8,"",0);
                                    if (cVar3) {
                                      lVar12 = LTCSVLoader.GetValueAt(lVar10,3,iVar21);
                                      lVar13 = FUN_1800d60b0(DAT_181da1040,1);
                                      if ((lVar13 == null) || (FUN_1800048e0(lVar13,0,59), lVar12 == null))
                                      goto LAB_180c27762;
                                      lVar12 = String.Split(lVar12,lVar13,0);
                                      iVar23 = 0;
                                      while( true ) {
                                        if (lVar12 == null) goto LAB_180c27762;
                                        if (lVar12.entries <= iVar23) break;
                                        iVar6 = 0;
                                        while( true ) {
                                          if (this.forceSpeAddDataBase == null) goto LAB_180c27762;
                                          if (this.forceSpeAddDataBase.Count <= iVar6)
                                          break;
                                          uVar8 = FUN_1800021a0(lVar12,(int64)iVar23);
                                          uVar8 = GlobalData.GetChinese(uVar8,0);
                                          if ((this.forceSpeAddDataBase == null) ||
                                             (lVar13 = FUN_180002f80(this.forceSpeAddDataBase,iVar6,
                                                                     DAT_181d88898), lVar13 == null))
                                          goto LAB_180c27762;
                                          cVar3 = FUN_18171e540(uVar8,*(uint64 *)(lVar13 + 16),0);
                                          if (cVar3) {
                                            lVar13 = *(int64 *)(lVar11 + 40);
                                            lVar15 = FUN_1800021a0(lVar12,(int64)iVar23);
                                            if (((this.forceSpeAddDataBase == null) ||
                                                (lVar16 = FUN_180002f80(this.forceSpeAddDataBase,
                                                                        iVar6,DAT_181d88898), lVar16 == null)
                                                ) || (lVar15 == null)) goto LAB_180c27762;
                                            uVar8 = String.Replace(lVar15,*(uint64 *)(lVar16 + 16),
                                                                    "");
                                            Single.Parse(uVar8,0);
                                            if (lVar13 == null) goto LAB_180c27762;
                                            ForceSpeAddData.Set(lVar13,iVar6);
                                          }
                                          iVar6 = iVar6 + 1;
                                        }
                                        iVar23 = iVar23 + 1;
                                      }
                                    }
                                    uVar8 = LTCSVLoader.GetValueAt(lVar10,4,iVar21);
                                    cVar3 = String.op_Inequality(uVar8,"",0);
                                    if (cVar3) {
                                      uVar8 = LTCSVLoader.GetValueAt(lVar10,4,iVar21);
                                      uVar8 = GameDataController.StringToSpeAddData(this,uVar8,0);
                                      *(uint64 *)(lVar11 + 48) = uVar8;
                                    }
                                    if (*plVar9 == 0) goto LAB_180c27762;
                                    FUN_1808ab370(*plVar9,lVar11._items,lVar11);
                                    iVar21 = iVar21 + 1;
                                  } while (iVar21 < iVar5);
                                }
                                uVar8 = DAT_181dc2db8;
                                uVar8 = Type.GetTypeFromHandle(uVar8,0);
                                plVar9 = (int64 *)Resources.Load("GameData/ResourcePointData",uVar8,0);
                                if (plVar9 != (int64 *)0) {
                                  plVar17 = plVar9;
                                  plVar17 = plVar9;
                                  uVar8 = FUN_180da4db0(plVar17,0);
                                  lVar10 = new c.DisplayClass9_0(0);
                                  if (lVar10 != null) {
                                    LTCSVLoader.ReadMultiLine(lVar10,uVar8,0);
                                    iVar5 = LTCSVLoader.GetRow(lVar10,0);
                                    uVar8 = il2cpp_internal(DAT_181d814e8);
                                    FUN_1808b1370(uVar8,DAT_181dbd778);
                                    *(uint64 *)(this + 400) = uVar8;
                                    for (iVar21 = 1; uVar8 = DAT_181dc2db8, iVar21 < iVar5;
                                        iVar21 = iVar21 + 1) {
                                      lVar11 = new ResourcePointData(0);
                                      uVar8 = LTCSVLoader.GetValueAt(lVar10,0,iVar21,0);
                                      uVar24 = Int32.Parse(uVar8,0);
                                      if (lVar11 == null) goto LAB_180c27762;
                                      lVar11._items = uVar24;
                                      uVar8 = LTCSVLoader.GetValueAt(lVar10,1,iVar21);
                                      lVar11.Count = uVar8;
                                      if ((this.resourcePointTypeDataBase == null) ||
                                         (lVar12 = FUN_1808ae5b0(this.resourcePointTypeDataBase,
                                                                 DAT_181dbdb30), lVar12 == null))
                                      goto LAB_180c27762;
                                      ValueCollection.GetEnumerator(&local_a0,lVar12,DAT_181d7f758);
                                      local_d0 = local_a0;
                                      uStack_c8 = uStack_98;
                                      local_c0 = local_90;
                                      do {
                                        cVar3 = FUN_1811c3f80(&local_d0,DAT_181d9add8);
                                        lVar12 = local_c0;
                                        if (!cVar3) goto LAB_180c201bb;
                                        if (local_c0 == 0) {
                          // WARNING: Subroutine does not return
                                          FUN_1800d6620();
                                        }
                                        cVar3 = FUN_18171e540(*(uint64 *)(local_c0 + 24),
                                                              lVar11.Count,0);
                                      } while (!cVar3);
                                      if (lVar12 == null) {
                          // WARNING: Subroutine does not return
                                        FUN_1800d6620();
                                      }
                                      *(uint32 *)(lVar11 + 20) = lVar12.buckets;
        LAB_180c201bb:
                                      ZhSegment.Initialize(&local_d0,DAT_181d9ad58);
                                      if (lVar11 == null) goto LAB_180c27762;
                                      *(uint64 *)(lVar11 + 32) = lVar11.Count;
                                      if (lVar10 == null) goto LAB_180c27762;
                                      uVar8 = LTCSVLoader.GetValueAt(lVar10,4,iVar21);
                                      uVar24 = Int32.Parse(uVar8,0);
                                      *(uint32 *)(lVar11 + 48) = uVar24;
                                      uVar8 = LTCSVLoader.GetValueAt(lVar10,5,iVar21);
                                      uVar24 = Int32.Parse(uVar8,0);
                                      *(uint32 *)(lVar11 + 52) = uVar24;
                                      if (*(int64 *)(this + 400) == 0) goto LAB_180c27762;
                                      FUN_1808ab370();
                                    }
                                    uVar8 = Type.GetTypeFromHandle(uVar8,0);
                                    plVar9 = (int64 *)Resources.Load("GameData/HeroTagData",uVar8,0);
                                    if (plVar9 != (int64 *)0) {
                                      plVar17 = plVar9;
                                      plVar17 = plVar9;
                                      uVar8 = FUN_180da4db0(plVar17,0);
                                      lVar10 = new c.DisplayClass9_0(0);
                                      if (lVar10 != null) {
                                        LTCSVLoader.ReadMultiLine(lVar10,uVar8,0);
                                        iVar5 = LTCSVLoader.GetRow(lVar10,0);
                                        lVar11 = il2cpp_internal(DAT_181d80ee8);
                                        FUN_1808b1370(lVar11,DAT_181dba310);
                                        this.heroTagDataBase = lVar11;
                                        iVar21 = 1;
                                        if (1 < iVar5) {
                                          do {
                                            lVar11 = new HeroTagDataBase(0);
                                            uVar8 = LTCSVLoader.GetValueAt(lVar10,0,iVar21,0);
                                            uVar24 = Int32.Parse(uVar8,0);
                                            if (lVar11 == null) goto LAB_180c27762;
                                            lVar11._items = uVar24;
                                            uVar8 = LTCSVLoader.GetValueAt(lVar10,1,iVar21);
                                            lVar11.Count = uVar8;
                                            uVar8 = LTCSVLoader.GetValueAt(lVar10,2,iVar21);
                                            uVar24 = Int32.Parse(uVar8,0);
                                            *(uint32 *)(lVar11 + 32) = uVar24;
                                            uVar8 = DAT_181dc14d8;
                                            uVar8 = Type.GetTypeFromHandle(uVar8,0);
                                            uVar14 = LTCSVLoader.GetValueAt(lVar10,3,iVar21);
                                            plVar17 = (int64 *)Enum.Parse(uVar8,uVar14,0);
                                            if (plVar17 == (int64 *)0) goto LAB_180c27762;
                                            if (*(int64 *)(*plVar17 + 64) !=
                                                *(int64 *)(DAT_181da33d0 + 64)) {
                          // WARNING: Subroutine does not return
                                              FUN_1800d6070(plVar17,DAT_181da33d0);
                                            }
                                            puVar18 = (uint32 *)il2cpp_object_unbox();
                                            *(uint32 *)(lVar11 + 36) = *puVar18;
                                            uVar8 = LTCSVLoader.GetValueAt(lVar10,4,iVar21);
                                            uVar8 = GameDataController.StringToSpeAddData
                                                              (this,uVar8,0);
                                            *(uint64 *)(lVar11 + 88) = uVar8;
                                            uVar8 = LTCSVLoader.GetValueAt(lVar10,5,iVar21);
                                            *(uint64 *)(lVar11 + 40) = uVar8;
                                            uVar8 = LTCSVLoader.GetValueAt(lVar10,6,iVar21);
                                            *(uint64 *)(lVar11 + 48) = uVar8;
                                            uVar8 = LTCSVLoader.GetValueAt(lVar10,7,iVar21);
                                            uVar4 = FUN_18171e540(uVar8,"1",0);
                                            *(uint8 *)(lVar11 + 56) = uVar4;
                                            uVar8 = LTCSVLoader.GetValueAt(lVar10,8,iVar21);
                                            uVar24 = Int32.Parse(uVar8,0);
                                            *(uint32 *)(lVar11 + 100) = uVar24;
                                            uVar8 = LTCSVLoader.GetValueAt(lVar10,9,iVar21);
                                            cVar3 = String.op_Inequality(uVar8,"",0);
                                            if (cVar3) {
                                              lVar12 = LTCSVLoader.GetValueAt(lVar10,9,iVar21);
                                              lVar13 = FUN_1800d60b0(DAT_181da1040,1);
                                              if ((lVar13 == null) ||
                                                 (FUN_1800048e0(lVar13,0,43), lVar12 == null))
                                              goto LAB_180c27762;
                                              uVar8 = String.Split(lVar12,lVar13,0);
                                              uVar8 = Enumerable.ToList(uVar8,DAT_181db5778);
                                              *(uint64 *)(lVar11 + 64) = uVar8;
                                            }
                                            uVar8 = LTCSVLoader.GetValueAt(lVar10,10,iVar21);
                                            cVar3 = String.op_Inequality(uVar8,"",0);
                                            if (cVar3) {
                                              lVar12 = LTCSVLoader.GetValueAt(lVar10,10,iVar21);
                                              lVar13 = FUN_1800d60b0(DAT_181da1040,1);
                                              if ((lVar13 == null) ||
                                                 (FUN_1800048e0(lVar13,0,59), lVar12 == null))
                                              goto LAB_180c27762;
                                              uVar8 = String.Split(lVar12,lVar13,0);
                                              uVar8 = Enumerable.ToList(uVar8,DAT_181db5778);
                                              *(uint64 *)(lVar11 + 72) = uVar8;
                                            }
                                            uVar8 = LTCSVLoader.GetValueAt(lVar10,11,iVar21);
                                            *(uint64 *)(lVar11 + 80) = uVar8;
                                            uVar8 = LTCSVLoader.GetValueAt(lVar10,12,iVar21);
                                            uVar4 = FUN_18171e540(uVar8,"TRUE",0);
                                            *(uint8 *)(lVar11 + 96) = uVar4;
                                            if (*plVar9 == 0) goto LAB_180c27762;
                                            FUN_1808ab370(*plVar9,lVar11._items,lVar11);
                                            iVar21 = iVar21 + 1;
                                          } while (iVar21 < iVar5);
                                        }
                                        uVar8 = DAT_181dc2db8;
                                        uVar8 = Type.GetTypeFromHandle(uVar8,0);
                                        plVar9 = (int64 *)Resources.Load("GameData/InnData",uVar8,0);
                                        if (plVar9 != (int64 *)0) {
                                          plVar17 = plVar9;
                                          plVar17 = plVar9;
                                          uVar8 = FUN_180da4db0(plVar17,0);
                                          lVar10 = new c.DisplayClass9_0(0);
                                          if (lVar10 != null) {
                                            LTCSVLoader.ReadMultiLine(lVar10,uVar8,0);
                                            iVar5 = LTCSVLoader.GetRow(lVar10,0);
                                            lVar11 = il2cpp_internal(DAT_181d80f68);
                                            FUN_1808b1370(lVar11,DAT_181dba530);
                                            this.innDataBase = lVar11;
                                            iVar21 = 1;
                                            if (1 < iVar5) {
                                              do {
                                                uVar8 = LTCSVLoader.GetValueAt(lVar10,0,iVar21,0);
                                                uVar24 = Int32.Parse(uVar8,0);
                                                uVar8 = LTCSVLoader.GetValueAt(lVar10,1,iVar21);
                                                lVar11 = new InnData(uVar24,uVar8,0);
                                                uVar8 = LTCSVLoader.GetValueAt(lVar10,2,iVar21);
                                                if (lVar11 == null) goto LAB_180c27762;
                                                *(uint64 *)(lVar11 + 32) = uVar8;
                                                lVar12 = LTCSVLoader.GetValueAt(lVar10,3,iVar21);
                                                lVar13 = FUN_1800d60b0(DAT_181da1040,1);
                                                if (lVar13 == null) goto LAB_180c27762;
                                                if (*(int *)(lVar13 + 24) == 0) {
                                                  uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                  FUN_1800d65f0(uVar8,0);
                                                }
                                                *(uint16 *)(lVar13 + 32) = 59;
                                                if (lVar12 == null) goto LAB_180c27762;
                                                lVar13 = String.Split(lVar12,lVar13,0);
                                                lVar12 = *(int64 *)(lVar11 + 48);
                                                if (lVar13 == null) goto LAB_180c27762;
                                                if (*(int *)(lVar13 + 24) == 0) {
                                                  uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                  FUN_1800d65f0(uVar8,0);
                                                }
                                                uVar24 = Single.Parse(*(uint64 *)(lVar13 + 32),0);
                                                if (*(uint32 *)(lVar13 + 24) < 2) {
                                                  uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                  FUN_1800d65f0(uVar8,0);
                                                }
                                                uVar25 = Single.Parse(*(uint64 *)(lVar13 + 40),0);
                                                local_110 = CONCAT44(uVar25,uVar24);
                                                if (lVar12 == null) goto LAB_180c27762;
                                                local_f8 = local_110;
                                                local_f0 = 0;
                                                BigMapPos.SetByVector3(lVar12,&local_f8,0);
                                                if (*plVar9 == 0) goto LAB_180c27762;
                                                FUN_1808ab370(*plVar9,lVar11._items,
                                                              lVar11);
                                                iVar21 = iVar21 + 1;
                                              } while (iVar21 < iVar5);
                                            }
                                            uVar8 = DAT_181dc2db8;
                                            uVar8 = Type.GetTypeFromHandle(uVar8,0);
                                            plVar9 = (int64 *)Resources.Load("GameData/SkinDataBase",uVar8,0);
                                            if (plVar9 != (int64 *)0) {
                                              plVar17 = plVar9;
                                              plVar17 = plVar9;
                                              uVar8 = FUN_180da4db0(plVar17,0);
                                              lVar10 = new c.DisplayClass9_0(0);
                                              if (lVar10 != null) {
                                                LTCSVLoader.ReadMultiLine(lVar10,uVar8,0);
                                                iVar5 = LTCSVLoader.GetRow(lVar10,0);
                                                iVar21 = 1;
                                                if (1 < iVar5) {
                                                  do {
                                                    lVar11 = new SkinDataBase(0);
                                                    uVar8 = LTCSVLoader.GetValueAt(lVar10,0,iVar21,0);
                                                    uVar24 = Int32.Parse(uVar8,0);
                                                    if (lVar11 == null) goto LAB_180c27762;
                                                    lVar11._items = uVar24;
                                                    uVar8 = LTCSVLoader.GetValueAt(lVar10,1,iVar21);
                                                    lVar11.Count = uVar8;
                                                    il2cpp_internal((uint64 *)(lVar11 + 24),
                                                                        uVar8);
                                                    uVar8 = LTCSVLoader.GetValueAt(lVar10,2,iVar21);
                                                    uVar8 = GameDataController.StringToSpeAddData
                                                                      (this,uVar8,0);
                                                    *(uint64 *)(lVar11 + 32) = uVar8;
                                                    il2cpp_internal((uint64 *)(lVar11 + 32),
                                                                        uVar8);
                                                    uVar8 = LTCSVLoader.GetValueAt(lVar10,3,iVar21);
                                                    uVar24 = Int32.Parse(uVar8,0);
                                                    *(uint32 *)(lVar11 + 40) = uVar24;
                                                    if (this.skinDataBase == null)
                                                    goto LAB_180c27762;
                                                    FUN_18181e0a0(this.skinDataBase,lVar11,
                                                                  DAT_181da2e58);
                                                    iVar21 = iVar21 + 1;
                                                  } while (iVar21 < iVar5);
                                                }
                                                uVar8 = DAT_181dc2db8;
                                                uVar8 = Type.GetTypeFromHandle(uVar8,0);
                                                plVar9 = (int64 *)
                                                         Resources.Load("GameData/ForceData",uVar8,0);
                                                if (plVar9 != (int64 *)0) {
                                                  plVar17 = plVar9;
                                                  plVar17 = plVar9;
                                                  uVar8 = FUN_180da4db0(plVar17,0);
                                                  lVar10 = new c.DisplayClass9_0(0);
                                                  if (lVar10 != null) {
                                                    LTCSVLoader.ReadMultiLine(lVar10,uVar8,0);
                                                    iVar5 = LTCSVLoader.GetRow(lVar10,0);
                                                    uVar8 = il2cpp_internal(DAT_181d80ce8);
                                                    FUN_1808b1370(uVar8,DAT_181db9650);
                                                    this.forceDataBase = uVar8;
                                                    iVar21 = 1;
                                                    if (1 < iVar5) {
                                                      do {
                                                        lVar11 = new ForceData(0);
                                                        uVar8 = LTCSVLoader.GetValueAt(lVar10,0,iVar21,0)
                                                        ;
                                                        uVar24 = Int32.Parse(uVar8,0);
                                                        if (lVar11 == null) goto LAB_180c27762;
                                                        lVar11._items = uVar24;
                                                        uVar8 = LTCSVLoader.GetValueAt(lVar10,1,iVar21);
                                                        lVar11.Count = uVar8;
                                                        il2cpp_internal((uint64 *)(lVar11 + 24),
                                                                            uVar8);
                                                        uVar8 = LTCSVLoader.GetValueAt(lVar10,2,iVar21);
                                                        *(uint64 *)(lVar11 + 40) = uVar8;
                                                        il2cpp_internal((uint64 *)(lVar11 + 40),
                                                                            uVar8);
                                                        uVar8 = LTCSVLoader.GetValueAt(lVar10,3,iVar21);
                                                        uVar24 = Int32.Parse(uVar8,0);
                                                        *(uint32 *)(lVar11 + 52) = uVar24;
                                                        uVar8 = LTCSVLoader.GetValueAt(lVar10,4,iVar21);
                                                        uVar24 = Int32.Parse(uVar8,0);
                                                        *(uint32 *)(lVar11 + 56) = uVar24;
                                                        uVar8 = LTCSVLoader.GetValueAt(lVar10,5,iVar21);
                                                        *(uint64 *)(lVar11 + 80) = uVar8;
                                                        il2cpp_internal((uint64 *)(lVar11 + 80),
                                                                            uVar8);
                                                        lVar12 = LTCSVLoader.GetValueAt(lVar10,6,iVar21);
                                                        cVar3 = String.op_Inequality
                                                                          (lVar12,"",0);
                                                        if ((cVar3) &&
                                                           (cVar3 = String.op_Inequality
                                                                              (lVar12,"#",0),
                                                           cVar3)) {
                                                          lVar13 = FUN_1800d60b0(DAT_181da1040,1);
                                                          if ((lVar13 == null) ||
                                                             (FUN_1800048e0(lVar13,0,47), lVar12 == null))
                                                          goto LAB_180c27762;
                                                          lVar12 = String.Split(lVar12,lVar13,0);
                                                          iVar23 = 0;
                                                          while( true ) {
                                                            if (lVar12 == null) goto LAB_180c27762;
                                                            if (lVar12.entries <= iVar23) break;
                                                            lVar13 = *(int64 *)(lVar11 + 72);
                                                            uVar8 = FUN_1800021a0(lVar12,(int64)iVar23)
                                                            ;
                                                            uVar24 = Int32.Parse(uVar8,0);
                                                            if (lVar13 == null) goto LAB_180c27762;
                                                            FUN_18182a0b0(lVar13,uVar24,DAT_181d8f218);
                                                            iVar23 = iVar23 + 1;
                                                          }
                                                        }
                                                        uVar8 = LTCSVLoader.GetValueAt(lVar10,7,iVar21);
                                                        cVar3 = String.op_Inequality
                                                                          (uVar8,"",0);
                                                        if (cVar3) {
                                                          lVar12 = LTCSVLoader.GetValueAt
                                                                             (lVar10,7,iVar21);
                                                          lVar13 = FUN_1800d60b0(DAT_181da1040,1);
                                                          if ((lVar13 == null) ||
                                                             (FUN_1800048e0(lVar13,0,59), lVar12 == null))
                                                          goto LAB_180c27762;
                                                          lVar12 = String.Split(lVar12,lVar13,0);
                                                          iVar23 = 0;
                                                          while( true ) {
                                                            if (lVar12 == null) goto LAB_180c27762;
                                                            if (lVar12.entries <= iVar23) break;
                                                            lVar13 = FUN_1800021a0(lVar12,(int64)iVar23
                                                                                  );
                                                            lVar15 = FUN_1800d60b0(DAT_181da1040,1);
                                                            if ((lVar15 == null) ||
                                                               (FUN_1800048e0(lVar15,0,45), lVar13 == null)
                                                               ) goto LAB_180c27762;
                                                            lVar15 = String.Split(lVar13,lVar15,0);
                                                            lVar13 = *(int64 *)(lVar11 + 0x110);
                                                            if (lVar15 == null) goto LAB_180c27762;
                                                            uVar8 = FUN_1800021a0(lVar15,0);
                                                            uVar24 = Int32.Parse(uVar8,0);
                                                            uVar8 = FUN_1800021a0(lVar15,1);
                                                            Single.Parse(uVar8,0);
                                                            uVar8 = new PlotChoiceRequirement(uVar24);
                                                            if (lVar13 == null) goto LAB_180c27762;
                                                            FUN_18181e0a0(lVar13,uVar8,DAT_181d88220);
                                                            iVar23 = iVar23 + 1;
                                                          }
                                                        }
                                                        uVar8 = LTCSVLoader.GetValueAt(lVar10,8,iVar21);
                                                        uVar24 = Single.Parse(uVar8,0);
                                                        *(uint32 *)(lVar11 + 48) = uVar24;
                                                        lVar12 = LTCSVLoader.GetValueAt(lVar10,9,iVar21);
                                                        lVar13 = FUN_1800d60b0(DAT_181da1040,1);
                                                        if ((lVar13 == null) ||
                                                           (FUN_1800048e0(lVar13,0,59), lVar12 == null))
                                                        goto LAB_180c27762;
                                                        lVar12 = String.Split(lVar12,lVar13,0);
                                                        iVar23 = 0;
                                                        while( true ) {
                                                          if (lVar12 == null) goto LAB_180c27762;
                                                          if (lVar12.entries <= iVar23) break;
                                                          lVar13 = *(int64 *)(lVar11 + 240);
                                                          lVar15 = *(int64 *)
                                                                    (pStatics +
                                                                    0x4a0);
                                                          uVar8 = FUN_1800021a0(lVar12,(int64)iVar23);
                                                          if ((lVar15 == null) ||
                                                             (uVar24 = FUN_1817eb4e0(lVar15,uVar8,
                                                                                     DAT_181da3fd8),
                                                             lVar13 == null)) goto LAB_180c27762;
                                                          FUN_18182a0b0(lVar13,uVar24,DAT_181d8f218);
                                                          iVar23 = iVar23 + 1;
                                                        }
                                                        uVar8 = LTCSVLoader.GetValueAt(lVar10,10,iVar21);
                                                        cVar3 = String.op_Inequality
                                                                          (uVar8,"无",0);
                                                        if (cVar3) {
                                                          lVar12 = LTCSVLoader.GetValueAt
                                                                             (lVar10,10,iVar21);
                                                          lVar13 = FUN_1800d60b0(DAT_181da1040,1);
                                                          if ((lVar13 == null) ||
                                                             (FUN_1800048e0(lVar13,0,59), lVar12 == null))
                                                          goto LAB_180c27762;
                                                          lVar12 = String.Split(lVar12,lVar13,0);
                                                          iVar23 = 0;
                                                          while( true ) {
                                                            if (lVar12 == null) goto LAB_180c27762;
                                                            if (lVar12.entries <= iVar23) break;
                                                            lVar13 = *(int64 *)(lVar11 + 248);
                                                            lVar15 = *(int64 *)
                                                                      (pStatics
                                                                      + 0x4b0);
                                                            uVar8 = FUN_1800021a0(lVar12,(int64)iVar23)
                                                            ;
                                                            if ((lVar15 == null) ||
                                                               (uVar24 = FUN_1817eb4e0(lVar15,uVar8,
                                                                                       DAT_181da3fd8),
                                                               lVar13 == null)) goto LAB_180c27762;
                                                            FUN_18182a0b0(lVar13,uVar24,DAT_181d8f218);
                                                            iVar23 = iVar23 + 1;
                                                          }
                                                        }
                                                        uVar8 = LTCSVLoader.GetValueAt(lVar10,11,iVar21)
                                                        ;
                                                        cVar3 = String.op_Inequality
                                                                          (uVar8,"无",0);
                                                        if (cVar3) {
                                                          lVar12 = LTCSVLoader.GetValueAt
                                                                             (lVar10,11,iVar21);
                                                          lVar13 = FUN_1800d60b0(DAT_181da1040,1);
                                                          if ((lVar13 == null) ||
                                                             (FUN_1800048e0(lVar13,0,58), lVar12 == null))
                                                          goto LAB_180c27762;
                                                          lVar13 = String.Split(lVar12,lVar13,0);
                                                          lVar12 = *(int64 *)(lVar11 + 0x100);
                                                          lVar15 = *(int64 *)
                                                                    (pStatics +
                                                                    0x4d0);
                                                          if (((lVar13 == null) ||
                                                              (uVar8 = FUN_1800021a0(lVar13,0),
                                                              lVar15 == null)) ||
                                                             (FUN_1817eb4e0(lVar15,uVar8,DAT_181da3fd8),
                                                             lVar12 == null)) goto LAB_180c27762;
                                                          FUN_181829d40(lVar12,0);
                                                          lVar12 = *(int64 *)(lVar11 + 0x100);
                                                          uVar8 = FUN_1800021a0(lVar13,1);
                                                          Single.Parse(uVar8,0);
                                                          if (lVar12 == null) goto LAB_180c27762;
                                                          FUN_181829d40(lVar12,1);
                                                        }
                                                        uVar8 = LTCSVLoader.GetValueAt(lVar10,12,iVar21)
                                                        ;
                                                        cVar3 = FUN_18171e540(uVar8,"1",0);
                                                        *(char *)(lVar11 + 36) = cVar3;
                                                        if (cVar3) {
                                                          if (*(int *)(pStatics
                                                                      + 8) != 0) {
                                                            lVar12 = *(int64 *)
                                                                      (pStatics
                                                                      + 32);
                                                            if (lVar12 == null) goto LAB_180c27762;
                                                            cVar3 = FUN_18182a3a0(lVar12,*(uint32 *)
                                                                                          (lVar11 + 16),
                                                                                  DAT_181d8f398);
                                                            if (!cVar3) goto LAB_180c2152f;
                                                          }
                                                          if (this.bigForceIDList == null)
                                                          goto LAB_180c27762;
                                                          FUN_18182a0b0(this.bigForceIDList,
                                                                        lVar11._items,
                                                                        DAT_181d8f218);
                                                        }
        LAB_180c2152f:
                                                        uVar8 = LTCSVLoader.GetValueAt(lVar10,13,iVar21)
                                                        ;
                                                        uVar4 = FUN_18171e540(uVar8,"1",0);
                                                        *(uint8 *)(lVar11 + 37) = uVar4;
                                                        uVar8 = LTCSVLoader.GetValueAt(lVar10,14,iVar21)
                                                        ;
                                                        uVar24 = Int32.Parse(uVar8,0);
                                                        *(uint32 *)(lVar11 + 32) = uVar24;
                                                        lVar12 = LTCSVLoader.GetValueAt
                                                                           (lVar10,15,iVar21);
                                                        if (lVar12 == null) goto LAB_180c27762;
                                                        uVar8 = String.Replace(lVar12,"\\n",
                                                                                "\n",0);
                                                        *(uint64 *)(lVar11 + 0x180) = uVar8;
                                                        il2cpp_internal((uint64 *)(lVar11 + 0x180)
                                                                            ,uVar8);
                                                        if (this.forceDataBase == null)
                                                        goto LAB_180c27762;
                                                        FUN_1808ab370(this.forceDataBase,
                                                                      lVar11._items,
                                                                      lVar11);
                                                        iVar21 = iVar21 + 1;
                                                      } while (iVar21 < iVar5);
                                                    }
                                                    uVar8 = DAT_181dc2db8;
                                                    uVar8 = Type.GetTypeFromHandle(uVar8,0);
                                                    plVar9 = (int64 *)
                                                             Resources.Load("GameData/BuildingData",uVar8,0);
                                                    if (plVar9 != (int64 *)0) {
                                                      plVar17 = plVar9;
                                                      plVar17 = plVar9;
                                                      uVar8 = FUN_180da4db0(plVar17,0);
                                                      lVar10 = new c.DisplayClass9_0(0);
                                                      if (lVar10 != null) {
                                                        LTCSVLoader.ReadMultiLine(lVar10,uVar8,0);
                                                        iVar5 = LTCSVLoader.GetRow(lVar10,0);
                                                        uVar8 = il2cpp_internal(DAT_181d90160);
                                                        FUN_18132faf0(uVar8,DAT_181d787a8);
                                                        this.buildingDataBaseTypeIDList = uVar8;
                                                        il2cpp_internal((uint64 *)(this + 232)
                                                                            ,uVar8);
                                                        iVar21 = 0;
                                                        do {
                                                          lVar11 = this.buildingDataBaseTypeIDList;
                                                          uVar8 = il2cpp_internal(DAT_181d93cd0);
                                                          FUN_18132faf0(uVar8,DAT_181d8f098);
                                                          if (lVar11 == null) goto LAB_180c27762;
                                                          FUN_18181e0a0(lVar11,uVar8,DAT_181d78828);
                                                          iVar21 = iVar21 + 1;
                                                        } while (iVar21 < 7);
                                                        uVar8 = il2cpp_internal(DAT_181d80968);
                                                        FUN_1808b1370(uVar8,DAT_181db7ac8);
                                                        this.buildingDataBase = uVar8;
                                                        lVar11 = il2cpp_internal(DAT_181d97750);
                                                        local_f8 = lVar11;
                                                        FUN_18132faf0(lVar11,DAT_181da3bd8);
                                                        if (lVar11 != null) {
                                                          FUN_18181e0a0(lVar11,"我",DAT_181da3d58
                                                                       );
                                                          FUN_18181e0a0(lVar11,"非我",DAT_181da3d58
                                                                       );
                                                          FUN_18181e0a0(lVar11,"敌",DAT_181da3d58
                                                                       );
                                                          FUN_18181e0a0(lVar11,"有门派",DAT_181da3d58
                                                                       );
                                                          FUN_18181e0a0(lVar11,"无门派",DAT_181da3d58
                                                                       );
                                                          FUN_18181e0a0(lVar11,"附庸",DAT_181da3d58
                                                                       );
                                                          FUN_18181e0a0(lVar11,"未购买",DAT_181da3d58
                                                                       );
                                                          FUN_18181e0a0(lVar11,"门客",DAT_181da3d58
                                                                       );
                                                          iVar21 = 1;
                                                          if (1 < iVar5) {
                                                            do {
                                                              lVar11 = new AreaBuildingDataBase(0);
                                                              uVar8 = LTCSVLoader.GetValueAt
                                                                                (lVar10,0,iVar21,0);
                                                              uVar24 = Int32.Parse(uVar8,0);
                                                              if (lVar11 == null) goto LAB_180c27762;
                                                              lVar11._items = uVar24;
                                                              uVar8 = LTCSVLoader.GetValueAt
                                                                                (lVar10,1,iVar21);
                                                              lVar11.Count = uVar8;
                                                              il2cpp_internal((uint64 *)
                                                                                  (lVar11 + 24),uVar8);
                                                              uVar8 = LTCSVLoader.GetValueAt
                                                                                (lVar10,2,iVar21);
                                                              *(uint64 *)(lVar11 + 32) = uVar8;
                                                              il2cpp_internal((uint64 *)
                                                                                  (lVar11 + 32),uVar8);
                                                              uVar8 = LTCSVLoader.GetValueAt
                                                                                (lVar10,3,iVar21);
                                                              uVar24 = Int32.Parse(uVar8,0);
                                                              *(uint32 *)(lVar11 + 48) = uVar24;
                                                              uVar8 = LTCSVLoader.GetValueAt
                                                                                (lVar10,4,iVar21);
                                                              uVar4 = FUN_18171e540(uVar8,"1",0)
                                                              ;
                                                              *(uint8 *)(lVar11 + 52) = uVar4;
                                                              uVar8 = LTCSVLoader.GetValueAt
                                                                                (lVar10,5,iVar21);
                                                              uVar4 = FUN_18171e540(uVar8,"1",0)
                                                              ;
                                                              *(uint8 *)(lVar11 + 53) = uVar4;
                                                              uVar8 = LTCSVLoader.GetValueAt
                                                                                (lVar10,6,iVar21);
                                                              uVar24 = Int32.Parse(uVar8,0);
                                                              *(uint32 *)(lVar11 + 56) = uVar24;
                                                              uVar8 = LTCSVLoader.GetValueAt
                                                                                (lVar10,7,iVar21);
                                                              cVar3 = String.op_Inequality
                                                                                (uVar8,"",0);
                                                              if (cVar3) {
                                                                lVar12 = LTCSVLoader.GetValueAt
                                                                                   (lVar10,7,iVar21);
                                                                lVar13 = FUN_1800d60b0(DAT_181da1040,1);
                                                                if ((lVar13 == null) ||
                                                                   (FUN_1800048e0(lVar13,0,59),
                                                                   lVar12 == null)) goto LAB_180c27762;
                                                                lVar12 = String.Split(lVar12,lVar13,0);
                                                                iVar23 = 0;
                                                                while( true ) {
                                                                  if (lVar12 == null) goto LAB_180c27762;
                                                                  if (lVar12.entries <= iVar23)
                                                                  break;
                                                                  lVar13 = FUN_1800021a0(lVar12,(int64)
                                                                                                iVar23);
                                                                  lVar15 = FUN_1800d60b0(DAT_181da1040,1);
                                                                  if ((lVar15 == null) ||
                                                                     (FUN_1800048e0(lVar15,0,45),
                                                                     lVar13 == null)) goto LAB_180c27762;
                                                                  lVar13 = String.Split(lVar13,lVar15,0);
                                                                  lVar15 = il2cpp_internal(
                                                        DAT_181dac4d8);
                                                        c__DisplayClass9_0.ctor(lVar15,0);
                                                        if (lVar13 == null) goto LAB_180c27762;
                                                        lVar16 = FUN_1800021a0(lVar13,0);
                                                        lVar19 = FUN_1800d60b0(DAT_181da1040,1);
                                                        if ((((lVar19 == null) ||
                                                             (FUN_1800048e0(lVar19,0,63), lVar16 == null))
                                                            || (lVar16 = String.Split(lVar16,lVar19,0),
                                                               lVar16 == null)) ||
                                                           (uVar8 = FUN_1800021a0(lVar16,0), lVar15 == null))
                                                        goto LAB_180c27762;
                                                        *(uint64 *)(lVar15 + 16) = uVar8;
                                                        il2cpp_internal((uint64 *)(lVar15 + 16),
                                                                            uVar8);
                                                        if (1 < *(int *)(lVar16 + 24)) {
                                                          uVar8 = FUN_1800021a0(lVar16,1);
                                                          *(uint64 *)(lVar15 + 24) = uVar8;
                                                          il2cpp_internal((uint64 *)
                                                                              (lVar15 + 24),uVar8);
                                                        }
                                                        if (1 < *(int *)(lVar13 + 24)) {
                                                          uVar8 = FUN_1800021a0(lVar13,1);
                                                          uVar4 = Enumerable.Contains
                                                                            (uVar8,124,DAT_181db29c8);
                                                          *(uint8 *)(lVar15 + 32) = uVar4;
                                                          lVar16 = FUN_1800021a0(lVar13,1);
                                                          lVar19 = FUN_1800d60b0(DAT_181da1040,2);
                                                          if (lVar19 == null) goto LAB_180c27762;
                                                          FUN_1800048e0(lVar19,0,38);
                                                          FUN_1800048e0(lVar19,1,124);
                                                          if (lVar16 == null) goto LAB_180c27762;
                                                          lVar16 = String.Split(lVar16,lVar19,0);
                                                          uVar8 = il2cpp_internal(DAT_181d97750);
                                                          FUN_18132faf0(uVar8,DAT_181da3bd8);
                                                          *(uint64 *)(lVar15 + 40) = uVar8;
                                                          il2cpp_internal((uint64 *)
                                                                              (lVar15 + 40),uVar8);
                                                          uVar8 = il2cpp_internal(DAT_181d97750);
                                                          FUN_18132faf0(uVar8,DAT_181da3bd8);
                                                          *(uint64 *)(lVar15 + 48) = uVar8;
                                                          iVar6 = 0;
                                                          while( true ) {
                                                            if (lVar16 == null) goto LAB_180c27762;
                                                            if (*(int *)(lVar16 + 24) <= iVar6) break;
                                                            lVar19 = (int64)iVar6;
                                                            uVar8 = FUN_1800021a0(lVar16,lVar19);
                                                            cVar3 = FUN_18181e400(local_f8,uVar8,
                                                                                  DAT_181da3e58);
                                                            if (!cVar3) {
                                                              lVar20 = FUN_1800021a0(lVar16,lVar19);
                                                              if (lVar20 == null) goto LAB_180c27762;
                                                              cVar3 = String.Contains(lVar20,
                                                        "门派功能",0);
                                                        if (!(cVar3))
                                                        {
                                                          lVar20 = *(int64 *)(lVar15 + 48);
                                                          }
                                                          else {
                                                        }
                                                          lVar20 = *(int64 *)(lVar15 + 40);
                                                        }
                                                        uVar8 = FUN_1800021a0(lVar16,lVar19);
                                                        if (lVar20 == null) goto LAB_180c27762;
                                                        FUN_18181e0a0(lVar20,uVar8,DAT_181da3d58);
                                                        iVar6 = iVar6 + 1;
                                                        }
                                                        }
                                                        if (2 < *(int *)(lVar13 + 24)) {
                                                          uVar8 = FUN_1800021a0(lVar13,2);
                                                          *(uint64 *)(lVar15 + 56) = uVar8;
                                                          il2cpp_internal((uint64 *)
                                                                              (lVar15 + 56),uVar8);
                                                        }
                                                        if (3 < *(int *)(lVar13 + 24)) {
                                                          uVar8 = FUN_1800021a0(lVar13,3);
                                                          *(uint64 *)(lVar15 + 64) = uVar8;
                                                          il2cpp_internal((uint64 *)
                                                                              (lVar15 + 64),uVar8);
                                                        }
                                                        if (*(int64 *)(lVar11 + 64) == 0)
                                                        goto LAB_180c27762;
                                                        FUN_18181e0a0(*(int64 *)(lVar11 + 64),lVar15,
                                                                      DAT_181d7bef0);
                                                        iVar23 = iVar23 + 1;
                                                        }
                                                        }
                                                        uVar8 = LTCSVLoader.GetValueAt(lVar10,8,iVar21);
                                                        cVar3 = String.op_Inequality
                                                                          (uVar8,"",0);
                                                        if (cVar3) {
                                                          lVar12 = LTCSVLoader.GetValueAt
                                                                             (lVar10,8,iVar21);
                                                          lVar13 = FUN_1800d60b0(DAT_181da1040);
                                                          if ((lVar13 == null) ||
                                                             (FUN_1800048e0(lVar13), lVar12 == null))
                                                          goto LAB_180c27762;
                                                          lVar13 = String.Split(lVar12,lVar13);
                                                          iVar23 = 0;
                                                          lVar12 = DAT_181d73d40;
                                                          while( true ) {
                                                            if (lVar13 == null) goto LAB_180c27762;
                                                            if (*(int *)(lVar13 + 24) <= iVar23) break;
                                                            iVar6 = 0;
                                                            while( true ) {
                                                              if (((*(byte *)(lVar12 + 0x133) & 4) != 0)
                                                                 && (*(int *)(lVar12 + 224) == 0)) {
                                                                il2cpp_runtime_class_init();
                                                                lVar12 = DAT_181d73d40;
                                                              }
                                                              lVar15 = *(int64 *)
                                                                        (plVar12 +
                                                                        0x438);
                                                              if (lVar15 == null) goto LAB_180c27762;
                                                              if (*(int *)(lVar15 + 24) <= iVar6) break;
                                                              lVar15 = (int64)iVar23;
                                                              lVar12 = FUN_1800021a0(lVar13,lVar15);
                                                              if (((*(byte *)(DAT_181d73d40 + 0x133) & 4)
                                                                   != 0) &&
                                                                 (*(int *)(DAT_181d73d40 + 224) == 0)) {
                                                                il2cpp_runtime_class_init();
                                                              }
                                                              lVar16 = *(int64 *)
                                                                        (*(int64 *)
                                                                          (DAT_181d73d40 + 184) + 0x438);
                                                              if ((lVar16 == null) ||
                                                                 (uVar8 = FUN_180002f80(lVar16,iVar6,
                                                                                        DAT_181da4358),
                                                                 lVar12 == null)) goto LAB_180c27762;
                                                              cVar3 = String.Contains(lVar12,uVar8,0);
                                                              if (!cVar3) {
                                                                iVar22 = 0;
                                                                while( true ) {
                                                                  if (((*(byte *)(DAT_181d73d40 + 0x133) &
                                                                       4) != 0) &&
                                                                     (*(int *)(DAT_181d73d40 + 224) == 0)
                                                                     ) {
                                                                    il2cpp_runtime_class_init();
                                                                  }
                                                                  lVar12 = *(int64 *)
                                                                            (*(int64 *)
                                                                              (DAT_181d73d40 + 184) +
                                                                            0x608);
                                                                  if (lVar12 == null) goto LAB_180c27762;
                                                                  if (lVar12.entries <= iVar22)
                                                                  break;
                                                                  lVar12 = FUN_1800021a0(lVar13,lVar15);
                                                                  if (((*(byte *)(DAT_181d73d40 + 0x133) &
                                                                       4) != 0) &&
                                                                     (*(int *)(DAT_181d73d40 + 224) == 0)
                                                                     ) {
                                                                    il2cpp_runtime_class_init();
                                                                  }
                                                                  lVar16 = *(int64 *)
                                                                            (*(int64 *)
                                                                              (DAT_181d73d40 + 184) +
                                                                            0x608);
                                                                  if (lVar16 == null) goto LAB_180c27762;
                                                                  uVar8 = FUN_180002f80(lVar16,iVar22,
                                                                                        DAT_181da4358);
                                                                  uVar8 = String.Concat("全域",
                                                                                         uVar8,0);
                                                                  if (lVar12 == null) goto LAB_180c27762;
                                                                  cVar3 = String.Contains(lVar12,uVar8,0)
                                                                  ;
                                                                  if (!cVar3) {
                                                                    lVar12 = FUN_1800021a0(lVar13,lVar15);
                                                                    if (((*(byte *)(DAT_181d73d40 + 0x133)
                                                                         & 4) != 0) &&
                                                                       (*(int *)(DAT_181d73d40 + 224) ==
                                                                        0)) {
                                                                      il2cpp_runtime_class_init();
                                                                    }
                                                                    lVar16 = *(int64 *)
                                                                              (*(int64 *)
                                                                                (DAT_181d73d40 + 184) +
                                                                              0x608);
                                                                    if ((lVar16 == null) ||
                                                                       (uVar8 = FUN_180002f80(lVar16,
                                                        iVar22,DAT_181da4358), lVar12 == null))
                                                        goto LAB_180c27762;
                                                        cVar3 = String.Contains(lVar12,uVar8,0);
                                                        if (cVar3) {
                                                          lVar12 = *(int64 *)(lVar11 + 96);
                                                          lVar16 = FUN_1800021a0(lVar13,lVar15);
                                                          lVar19 = *(int64 *)
                                                                    (pStatics +
                                                                    0x608);
                                                          if ((lVar19 != null) &&
                                                             (uVar8 = FUN_180002f80(lVar19,iVar22,
                                                                                    DAT_181da4358),
                                                             lVar16 != null)) {
                                                            uVar8 = String.Replace(lVar16,uVar8,
                                                                                    "",0);
                                                            Single.Parse(uVar8,0);
                                                            if (lVar12 != null) goto LAB_180c221a6;
                                                          }
                                                          goto LAB_180c27762;
                                                        }
                                                        }
                                                        else {
                                                          lVar12 = *(int64 *)(lVar11 + 104);
                                                          lVar16 = FUN_1800021a0(lVar13,lVar15);
                                                          lVar19 = *(int64 *)
                                                                    (pStatics +
                                                                    0x608);
                                                          if (lVar19 == null) goto LAB_180c27762;
                                                          uVar8 = FUN_180002f80(lVar19,iVar22,
                                                                                DAT_181da4358);
                                                          uVar8 = String.Concat("全域",uVar8,0);
                                                          if (lVar16 == null) goto LAB_180c27762;
                                                          uVar8 = String.Replace(lVar16,uVar8,
                                                                                  "",0);
                                                          Single.Parse(uVar8,0);
                                                          if (lVar12 == null) goto LAB_180c27762;
        LAB_180c221a6:
                                                          FUN_181829d40(lVar12,iVar22);
                                                        }
                                                        iVar22 = iVar22 + 1;
                                                        }
                                                        }
                                                        else {
                                                          lVar12 = *(int64 *)(lVar11 + 72);
                                                          lVar15 = FUN_1800021a0(lVar13,lVar15);
                                                          lVar16 = *(int64 *)
                                                                    (pStatics +
                                                                    0x438);
                                                          if ((lVar16 == null) ||
                                                             (uVar8 = FUN_180002f80(lVar16,iVar6,
                                                                                    DAT_181da4358),
                                                             lVar15 == null)) goto LAB_180c27762;
                                                          uVar8 = String.Replace(lVar15,uVar8,
                                                                                  "",0);
                                                          Single.Parse(uVar8,0);
                                                          if (lVar12 == null) goto LAB_180c27762;
                                                          FUN_181829d40(lVar12,iVar6);
                                                        }
                                                        iVar6 = iVar6 + 1;
                                                        lVar12 = DAT_181d73d40;
                                                        }
                                                        iVar23 = iVar23 + 1;
                                                        }
                                                        }
                                                        uVar8 = LTCSVLoader.GetValueAt(lVar10,9,iVar21);
                                                        cVar3 = String.op_Inequality
                                                                          (uVar8,"",0);
                                                        if (cVar3) {
                                                          lVar12 = LTCSVLoader.GetValueAt
                                                                             (lVar10,9,iVar21);
                                                          lVar13 = FUN_1800d60b0(DAT_181da1040);
                                                          if ((lVar13 == null) ||
                                                             (FUN_1800048e0(lVar13), lVar12 == null))
                                                          goto LAB_180c27762;
                                                          lVar13 = String.Split(lVar12,lVar13);
                                                          iVar23 = 0;
                                                          lVar12 = DAT_181d73d40;
                                                          while( true ) {
                                                            if (lVar13 == null) goto LAB_180c27762;
                                                            if (*(int *)(lVar13 + 24) <= iVar23) break;
                                                            iVar6 = 0;
                                                            while( true ) {
                                                              if (((*(byte *)(lVar12 + 0x133) & 4) != 0)
                                                                 && (*(int *)(lVar12 + 224) == 0)) {
                                                                il2cpp_runtime_class_init();
                                                                lVar12 = DAT_181d73d40;
                                                              }
                                                              lVar15 = *(int64 *)
                                                                        (plVar12 +
                                                                        0x438);
                                                              if (lVar15 == null) goto LAB_180c27762;
                                                              if (*(int *)(lVar15 + 24) <= iVar6) break;
                                                              lVar15 = (int64)iVar23;
                                                              lVar12 = FUN_1800021a0(lVar13,lVar15);
                                                              if (((*(byte *)(DAT_181d73d40 + 0x133) & 4)
                                                                   != 0) &&
                                                                 (*(int *)(DAT_181d73d40 + 224) == 0)) {
                                                                il2cpp_runtime_class_init();
                                                              }
                                                              lVar16 = *(int64 *)
                                                                        (*(int64 *)
                                                                          (DAT_181d73d40 + 184) + 0x438);
                                                              if ((lVar16 == null) ||
                                                                 (uVar8 = FUN_180002f80(lVar16,iVar6,
                                                                                        DAT_181da4358),
                                                                 lVar12 == null)) goto LAB_180c27762;
                                                              cVar3 = String.Contains(lVar12,uVar8,0);
                                                              if (!cVar3) {
                                                                iVar22 = 0;
                                                                while( true ) {
                                                                  if (((*(byte *)(DAT_181d73d40 + 0x133) &
                                                                       4) != 0) &&
                                                                     (*(int *)(DAT_181d73d40 + 224) == 0)
                                                                     ) {
                                                                    il2cpp_runtime_class_init();
                                                                  }
                                                                  lVar12 = *(int64 *)
                                                                            (*(int64 *)
                                                                              (DAT_181d73d40 + 184) +
                                                                            0x608);
                                                                  if (lVar12 == null) goto LAB_180c27762;
                                                                  if (lVar12.entries <= iVar22)
                                                                  break;
                                                                  lVar12 = FUN_1800021a0(lVar13,lVar15);
                                                                  if (((*(byte *)(DAT_181d73d40 + 0x133) &
                                                                       4) != 0) &&
                                                                     (*(int *)(DAT_181d73d40 + 224) == 0)
                                                                     ) {
                                                                    il2cpp_runtime_class_init();
                                                                  }
                                                                  lVar16 = *(int64 *)
                                                                            (*(int64 *)
                                                                              (DAT_181d73d40 + 184) +
                                                                            0x608);
                                                                  if (lVar16 == null) goto LAB_180c27762;
                                                                  uVar8 = FUN_180002f80(lVar16,iVar22,
                                                                                        DAT_181da4358);
                                                                  uVar8 = String.Concat("全域",
                                                                                         uVar8,0);
                                                                  if (lVar12 == null) goto LAB_180c27762;
                                                                  cVar3 = String.Contains(lVar12,uVar8,0)
                                                                  ;
                                                                  if (!cVar3) {
                                                                    lVar12 = FUN_1800021a0(lVar13,lVar15);
                                                                    if (((*(byte *)(DAT_181d73d40 + 0x133)
                                                                         & 4) != 0) &&
                                                                       (*(int *)(DAT_181d73d40 + 224) ==
                                                                        0)) {
                                                                      il2cpp_runtime_class_init();
                                                                    }
                                                                    lVar16 = *(int64 *)
                                                                              (*(int64 *)
                                                                                (DAT_181d73d40 + 184) +
                                                                              0x608);
                                                                    if ((lVar16 == null) ||
                                                                       (uVar8 = FUN_180002f80(lVar16,
                                                        iVar22,DAT_181da4358), lVar12 == null))
                                                        goto LAB_180c27762;
                                                        cVar3 = String.Contains(lVar12,uVar8,0);
                                                        if (cVar3) {
                                                          lVar12 = *(int64 *)(lVar11 + 96);
                                                          lVar16 = FUN_1800021a0(lVar13,lVar15);
                                                          lVar19 = *(int64 *)
                                                                    (pStatics +
                                                                    0x608);
                                                          if ((lVar19 != null) &&
                                                             (uVar8 = FUN_180002f80(lVar19,iVar22,
                                                                                    DAT_181da4358),
                                                             lVar16 != null)) {
                                                            uVar8 = String.Replace(lVar16,uVar8,
                                                                                    "",0);
                                                            Single.Parse(uVar8,0);
                                                            if (lVar12 != null) goto LAB_180c22686;
                                                          }
                                                          goto LAB_180c27762;
                                                        }
                                                        }
                                                        else {
                                                          lVar12 = *(int64 *)(lVar11 + 104);
                                                          lVar16 = FUN_1800021a0(lVar13,lVar15);
                                                          lVar19 = *(int64 *)
                                                                    (pStatics +
                                                                    0x608);
                                                          if (lVar19 == null) goto LAB_180c27762;
                                                          uVar8 = FUN_180002f80(lVar19,iVar22,
                                                                                DAT_181da4358);
                                                          uVar8 = String.Concat("全域",uVar8,0);
                                                          if (lVar16 == null) goto LAB_180c27762;
                                                          uVar8 = String.Replace(lVar16,uVar8,
                                                                                  "",0);
                                                          Single.Parse(uVar8,0);
                                                          if (lVar12 == null) goto LAB_180c27762;
        LAB_180c22686:
                                                          FUN_181829d40(lVar12,iVar22);
                                                        }
                                                        iVar22 = iVar22 + 1;
                                                        }
                                                        }
                                                        else {
                                                          lVar12 = *(int64 *)(lVar11 + 72);
                                                          lVar15 = FUN_1800021a0(lVar13,lVar15);
                                                          lVar16 = *(int64 *)
                                                                    (pStatics +
                                                                    0x438);
                                                          if ((lVar16 == null) ||
                                                             (uVar8 = FUN_180002f80(lVar16,iVar6,
                                                                                    DAT_181da4358),
                                                             lVar15 == null)) goto LAB_180c27762;
                                                          uVar8 = String.Replace(lVar15,uVar8,
                                                                                  "",0);
                                                          Single.Parse(uVar8,0);
                                                          if (lVar12 == null) goto LAB_180c27762;
                                                          FUN_181829d40(lVar12,iVar6);
                                                        }
                                                        iVar6 = iVar6 + 1;
                                                        lVar12 = DAT_181d73d40;
                                                        }
                                                        iVar23 = iVar23 + 1;
                                                        }
                                                        }
                                                        uVar8 = LTCSVLoader.GetValueAt(lVar10,10,iVar21);
                                                        cVar3 = String.op_Inequality
                                                                          (uVar8,"",0);
                                                        if (cVar3) {
                                                          lVar12 = LTCSVLoader.GetValueAt
                                                                             (lVar10,10,iVar21);
                                                          lVar13 = FUN_1800d60b0(DAT_181da1040,1);
                                                          if ((lVar13 == null) ||
                                                             (FUN_1800048e0(lVar13,0,59), lVar12 == null))
                                                          goto LAB_180c27762;
                                                          lVar12 = String.Split(lVar12,lVar13,0);
                                                          iVar23 = 0;
                                                          while( true ) {
                                                            if (lVar12 == null) goto LAB_180c27762;
                                                            if (lVar12.entries <= iVar23) break;
                                                            lVar13 = FUN_1800021a0(lVar12,(int64)iVar23
                                                                                  );
                                                            if (lVar13 == null) goto LAB_180c27762;
                                                            cVar3 = String.Contains(lVar13,"人口上限",
                                                                                     0);
                                                            if (!cVar3) {
                                                              iVar6 = 0;
                                                              while( true ) {
                                                                if (this.forceSpeAddDataBase == null)
                                                                goto LAB_180c27762;
                                                                if (*(int *)(this.forceSpeAddDataBase
                                                                            + 24) <= iVar6) break;
                                                                uVar8 = FUN_1800021a0(lVar12,(int64)
                                                                                             iVar23);
                                                                if (((*(byte *)(DAT_181d73d40 + 0x133) & 4
                                                                     ) != 0) &&
                                                                   (*(int *)(DAT_181d73d40 + 224) == 0))
                                                                {
                                                                  il2cpp_runtime_class_init();
                                                                }
                                                                uVar8 = GlobalData.GetChinese(uVar8,0);
                                                                if ((this.forceSpeAddDataBase == null)
                                                                   || (lVar13 = FUN_180002f80(*(int64 *
                                                                                               )(this +
                                                                                                152),
                                                        iVar6), lVar13 == null)) goto LAB_180c27762;
                                                        cVar3 = FUN_18171e540(uVar8,*(uint64 *)
                                                                                     (lVar13 + 16));
                                                        if (cVar3) {
                                                          lVar13 = *(int64 *)(lVar11 + 128);
                                                          lVar15 = FUN_1800021a0(lVar12,(int64)iVar23);
                                                          if (((this.forceSpeAddDataBase == null) ||
                                                              (lVar16 = FUN_180002f80(*(int64 *)
                                                                                       (this + 152),
                                                                                      iVar6,DAT_181d88898)
                                                              , lVar16 == null)) || (lVar15 == null))
                                                          goto LAB_180c27762;
                                                          uVar8 = String.Replace(lVar15,*(uint64 *)
                                                                                          (lVar16 + 16))
                                                          ;
                                                          Single.Parse(uVar8,0);
                                                          if (lVar13 == null) goto LAB_180c27762;
                                                          ForceSpeAddData.Set(lVar13,iVar6);
                                                        }
                                                        iVar6 = iVar6 + 1;
                                                        }
                                                        }
                                                        else {
                                                          lVar13 = FUN_1800021a0(lVar12,(int64)iVar23);
                                                          if (lVar13 == null) goto LAB_180c27762;
                                                          uVar8 = String.Replace(lVar13,"人口上限");
                                                          uVar24 = Single.Parse(uVar8,0);
                                                          *(uint32 *)(lVar11 + 92) = uVar24;
                                                        }
                                                        iVar23 = iVar23 + 1;
                                                        }
                                                        }
                                                        uVar8 = LTCSVLoader.GetValueAt(lVar10,11,iVar21)
                                                        ;
                                                        cVar3 = String.op_Inequality
                                                                          (uVar8,"",0);
                                                        if (cVar3) {
                                                          lVar12 = LTCSVLoader.GetValueAt
                                                                             (lVar10,11,iVar21);
                                                          lVar13 = FUN_1800d60b0(DAT_181da1040,1);
                                                          if ((lVar13 == null) ||
                                                             (FUN_1800048e0(lVar13,0,59), lVar12 == null))
                                                          goto LAB_180c27762;
                                                          lVar12 = String.Split(lVar12,lVar13,0);
                                                          iVar23 = 0;
                                                          while( true ) {
                                                            if (lVar12 == null) goto LAB_180c27762;
                                                            if (lVar12.entries <= iVar23) break;
                                                            lVar13 = FUN_1800021a0(lVar12,(int64)iVar23
                                                                                  );
                                                            lVar15 = FUN_1800d60b0(DAT_181da1040,1);
                                                            if ((lVar15 == null) ||
                                                               (FUN_1800048e0(lVar15,0,45), lVar13 == null)
                                                               ) goto LAB_180c27762;
                                                            lVar15 = String.Split(lVar13,lVar15,0);
                                                            lVar13 = *(int64 *)(lVar11 + 112);
                                                            if (lVar15 == null) goto LAB_180c27762;
                                                            uVar8 = FUN_1800021a0(lVar15,0);
                                                            uVar14 = FUN_1800021a0(lVar15,1);
                                                            Single.Parse(uVar14,0);
                                                            uVar14 = new AreaBuildingRateChange(uVar8);
                                                            if (lVar13 == null) goto LAB_180c27762;
                                                            FUN_18181e0a0(lVar13,uVar14,DAT_181d7c3e8);
                                                            iVar23 = iVar23 + 1;
                                                          }
                                                        }
                                                        uVar8 = LTCSVLoader.GetValueAt(lVar10,12,iVar21)
                                                        ;
                                                        cVar3 = String.op_Inequality
                                                                          (uVar8,"",0);
                                                        if (cVar3) {
                                                          lVar12 = LTCSVLoader.GetValueAt
                                                                             (lVar10,12,iVar21);
                                                          lVar13 = FUN_1800d60b0(DAT_181da1040,1);
                                                          if ((lVar13 == null) ||
                                                             (FUN_1800048e0(lVar13,0,59), lVar12 == null))
                                                          goto LAB_180c27762;
                                                          lVar13 = String.Split(lVar12,lVar13,0);
                                                          iVar23 = 0;
                                                          lVar12 = DAT_181d73d40;
                                                          while( true ) {
                                                            if (lVar13 == null) goto LAB_180c27762;
                                                            if (*(int *)(lVar13 + 24) <= iVar23) break;
                                                            iVar6 = 0;
                                                            while( true ) {
                                                              if (((*(byte *)(lVar12 + 0x133) & 4) != 0)
                                                                 && (*(int *)(lVar12 + 224) == 0)) {
                                                                il2cpp_runtime_class_init();
                                                                lVar12 = DAT_181d73d40;
                                                              }
                                                              lVar15 = *(int64 *)
                                                                        (plVar12 +
                                                                        0x438);
                                                              if (lVar15 == null) goto LAB_180c27762;
                                                              if (*(int *)(lVar15 + 24) <= iVar6) break;
                                                              lVar12 = FUN_1800021a0(lVar13,(int64)
                                                                                            iVar23);
                                                              if (((*(byte *)(DAT_181d73d40 + 0x133) & 4)
                                                                   != 0) &&
                                                                 (*(int *)(DAT_181d73d40 + 224) == 0)) {
                                                                il2cpp_runtime_class_init();
                                                              }
                                                              lVar15 = *(int64 *)
                                                                        (*(int64 *)
                                                                          (DAT_181d73d40 + 184) + 0x438);
                                                              if ((lVar15 == null) ||
                                                                 (uVar8 = FUN_180002f80(lVar15,iVar6,
                                                                                        DAT_181da4358),
                                                                 lVar12 == null)) goto LAB_180c27762;
                                                              cVar3 = String.Contains(lVar12,uVar8,0);
                                                              if (cVar3) {
                                                                lVar12 = *(int64 *)(lVar11 + 80);
                                                                lVar15 = FUN_1800021a0(lVar13,(int64)
                                                                                              iVar23);
                                                                if (((*(byte *)(DAT_181d73d40 + 0x133) & 4
                                                                     ) != 0) &&
                                                                   (*(int *)(DAT_181d73d40 + 224) == 0))
                                                                {
                                                                  il2cpp_runtime_class_init();
                                                                }
                                                                lVar16 = *(int64 *)
                                                                          (*(int64 *)
                                                                            (DAT_181d73d40 + 184) + 0x438
                                                                          );
                                                                if ((lVar16 == null) ||
                                                                   (uVar8 = FUN_180002f80(lVar16,iVar6,
                                                                                          DAT_181da4358),
                                                                   lVar15 == null)) goto LAB_180c27762;
                                                                uVar8 = String.Replace(lVar15,uVar8,
                                                                                        "",0);
                                                                Single.Parse(uVar8,0);
                                                                if (lVar12 == null) goto LAB_180c27762;
                                                                FUN_181829d40(lVar12,iVar6);
                                                              }
                                                              iVar6 = iVar6 + 1;
                                                              lVar12 = DAT_181d73d40;
                                                            }
                                                            iVar23 = iVar23 + 1;
                                                          }
                                                        }
                                                        uVar8 = LTCSVLoader.GetValueAt(lVar10,13,iVar21)
                                                        ;
                                                        uVar24 = Single.Parse(uVar8,0);
                                                        *(uint32 *)(lVar11 + 88) = uVar24;
                                                        uVar8 = LTCSVLoader.GetValueAt(lVar10,14,iVar21)
                                                        ;
                                                        uVar24 = Int32.Parse(uVar8,0);
                                                        *(uint32 *)(lVar11 + 120) = uVar24;
                                                        lVar12 = LTCSVLoader.GetValueAt
                                                                           (lVar10,15,iVar21);
                                                        if (lVar12 == null) {
        LAB_180c22e2e:
                                                          *(uint64 *)(lVar11 + 136) = 0;
                                                          uVar8 = 0;
                                                        }
                                                        else {
                                                          uVar8 = LTCSVLoader.GetValueAt
                                                                            (lVar10,15,iVar21);
                                                          cVar3 = String.op_Inequality
                                                                            (uVar8,"",0);
                                                          if (!cVar3) goto LAB_180c22e2e;
                                                          uVar14 = LTCSVLoader.GetValueAt
                                                                             (lVar10,15,iVar21);
                                                          uVar8 = new AreaBuildingShopData(uVar14,0);
                                                          *(uint64 *)(lVar11 + 136) = uVar8;
                                                        }
                                                        il2cpp_internal(lVar11 + 136,uVar8);
                                                        uVar8 = LTCSVLoader.GetValueAt
                                                                          (lVar10,16,iVar21);
                                                        uVar24 = Int32.Parse(uVar8,0);
                                                        *(uint32 *)(lVar11 + 144) = uVar24;
                                                        uVar8 = LTCSVLoader.GetValueAt
                                                                          (lVar10,17,iVar21);
                                                        *(uint64 *)(lVar11 + 152) = uVar8;
                                                        il2cpp_internal((uint64 *)(lVar11 + 152),
                                                                            uVar8);
                                                        lVar12 = LTCSVLoader.GetValueAt
                                                                           (lVar10,18,iVar21);
                                                        lVar13 = FUN_1800d60b0(DAT_181da1040,1);
                                                        if (((lVar13 == null) ||
                                                            (FUN_1800048e0(lVar13,0,59), lVar12 == null))
                                                           || (lVar12 = String.Split(lVar12,lVar13,0),
                                                              lVar12 == null)) goto LAB_180c27762;
                                                        uVar8 = FUN_1800021a0(lVar12,0);
                                                        uVar4 = FUN_18171e540(uVar8,"1",0);
                                                        *(uint8 *)(lVar11 + 160) = uVar4;
                                                        uVar8 = FUN_1800021a0(lVar12,1);
                                                        uVar4 = FUN_18171e540(uVar8,"1",0);
                                                        *(uint8 *)(lVar11 + 161) = uVar4;
                                                        uVar8 = LTCSVLoader.GetValueAt
                                                                          (lVar10,19,iVar21,0);
                                                        *(uint64 *)(lVar11 + 40) = uVar8;
                                                        il2cpp_internal((uint64 *)(lVar11 + 40),
                                                                            uVar8);
                                                        if ((this.buildingDataBaseTypeIDList == null) ||
                                                           (lVar12 = FUN_180002f80(*(int64 *)
                                                                                    (this + 232),
                                                                                   *(uint32 *)
                                                                                    (lVar11 + 48),
                                                                                   DAT_181d789a8),
                                                           lVar12 == null)) goto LAB_180c27762;
                                                        FUN_18182a0b0(lVar12,*(uint32 *)
                                                                              (lVar11 + 16),
                                                                      DAT_181d8f218);
                                                        if (this.buildingDataBase == null)
                                                        goto LAB_180c27762;
                                                        FUN_1808ab370(this.buildingDataBase,
                                                                      lVar11._items,
                                                                      lVar11);
                                                        iVar21 = iVar21 + 1;
                                                        } while (iVar21 < iVar5);
                                                        }
                                                        uVar8 = DAT_181dc2db8;
                                                        uVar8 = Type.GetTypeFromHandle(uVar8,0);
                                                        plVar9 = (int64 *)
                                                                 Resources.Load("GameData/WeaponData",uVar8,0);
                                                        if (plVar9 != (int64 *)0) {
                                                          plVar17 = plVar9;
                                                          plVar17 = plVar9;
                                                          uVar8 = FUN_180da4db0(plVar17,0);
                                                          lVar10 = new c.DisplayClass9_0(0);
                                                          if (lVar10 != null) {
                                                            LTCSVLoader.ReadMultiLine(lVar10,uVar8,0);
                                                            iVar5 = LTCSVLoader.GetRow(lVar10,0);
                                                            uVar8 = il2cpp_internal(DAT_181d810e8);
                                                            FUN_1808b1370(uVar8,DAT_181dbc028);
                                                            this.weaponDataBase = uVar8;
                                                            iVar21 = 1;
                                                            if (1 < iVar5) {
                                                              do {
                                                                lVar11 = il2cpp_internal(DAT_181d82098
                                                                                            );
                                                                ItemData.ctor(lVar11,0,0);
                                                                uVar8 = LTCSVLoader.GetValueAt
                                                                                  (lVar10,0,iVar21,0);
                                                                uVar24 = Int32.Parse(uVar8,0);
                                                                if (lVar11 == null) goto LAB_180c27762;
                                                                lVar11._items = uVar24;
                                                                uVar8 = LTCSVLoader.GetValueAt
                                                                                  (lVar10,1,iVar21);
                                                                *(uint64 *)(lVar11 + 32) = uVar8;
                                                                il2cpp_internal((uint64 *)
                                                                                    (lVar11 + 32),uVar8)
                                                                ;
                                                                lVar12 = *(int64 *)(lVar11 + 96);
                                                                uVar8 = LTCSVLoader.GetValueAt
                                                                                  (lVar10,2,iVar21);
                                                                uVar24 = Int32.Parse(uVar8,0);
                                                                if (lVar12 == null) goto LAB_180c27762;
                                                                *(uint32 *)(lVar12 + 20) = uVar24;
                                                                lVar12 = *(int64 *)(lVar11 + 96);
                                                                uVar8 = LTCSVLoader.GetValueAt
                                                                                  (lVar10,3,iVar21);
                                                                uVar24 = Int32.Parse(uVar8,0);
                                                                if (lVar12 == null) goto LAB_180c27762;
                                                                lVar12.entries = uVar24;
                                                                lVar12 = *(int64 *)(lVar11 + 96);
                                                                if ((lVar12 == null) ||
                                                                   (lVar12.count == null))
                                                                goto LAB_180c27762;
                                                                HeroSpeAddData.Set(*(int64 *)
                                                                                     (lVar12 + 32),
                                                                                    *(uint32 *)
                                                                                     (lVar12 + 24));
                                                                lVar12 = *(int64 *)(lVar11 + 96);
                                                                uVar8 = LTCSVLoader.GetValueAt
                                                                                  (lVar10,4,iVar21);
                                                                if (lVar12 == null) goto LAB_180c27762;
                                                                puVar1 = (uint64 *)(lVar12 + 56);
                                                                *puVar1 = uVar8;
                                                                il2cpp_internal(puVar1,uVar8);
                                                                lVar12 = *(int64 *)(lVar11 + 96);
                                                                if (lVar12 == null) goto LAB_180c27762;
                                                                if (lVar12.count == null)
                                                                goto LAB_180c27762;
                                                                HeroSpeAddData.Set(*(int64 *)
                                                                                     (lVar12 + 32),
                                                                                    *(int *)(lVar12 + 20
                                                                                            ) + 9);
                                                                lVar11 = *(int64 *)(lVar11 + 96);
                                                                if (lVar11 == null) goto LAB_180c27762;
                                                                if ((*(int64 *)(lVar11 + 32) == 0) ||
                                                                   (HeroSpeAddData.Set(*(int64 *)
                                                                                         (lVar11 + 32),
                                                                                        *(int *)(lVar11 + 
                                                        20) + 18), this.weaponDataBase == null)
                                                        ) goto LAB_180c27762;
                                                        FUN_1808ab370();
                                                        iVar21 = iVar21 + 1;
                                                        } while (iVar21 < iVar5);
                                                        }
                                                        uVar8 = DAT_181dc2db8;
                                                        uVar8 = Type.GetTypeFromHandle(uVar8,0);
                                                        plVar9 = (int64 *)
                                                                 Resources.Load("GameData/ArmorData",uVar8,0);
                                                        if (plVar9 != (int64 *)0) {
                                                          plVar17 = plVar9;
                                                          plVar17 = plVar9;
                                                          uVar8 = FUN_180da4db0(plVar17,0);
                                                          lVar10 = new c.DisplayClass9_0(0);
                                                          if (lVar10 != null) {
                                                            LTCSVLoader.ReadMultiLine(lVar10,uVar8,0);
                                                            iVar5 = LTCSVLoader.GetRow(lVar10,0);
                                                            uVar8 = il2cpp_internal(DAT_181d810e8);
                                                            FUN_1808b1370(uVar8,DAT_181dbc028);
                                                            this.armorDataBase = uVar8;
                                                            uVar8 = il2cpp_internal(DAT_181d810e8);
                                                            FUN_1808b1370(uVar8,DAT_181dbc028);
                                                            this.helmetDataBase = uVar8;
                                                            uVar8 = il2cpp_internal(DAT_181d810e8);
                                                            FUN_1808b1370(uVar8,DAT_181dbc028);
                                                            this.shoesDataBase = uVar8;
                                                            iVar21 = 1;
                                                            if (1 < iVar5) {
                                                              do {
                                                                lVar11 = il2cpp_internal(DAT_181d82098
                                                                                            );
                                                                ItemData.ctor(lVar11,0,0);
                                                                uVar8 = LTCSVLoader.GetValueAt
                                                                                  (lVar10,0,iVar21);
                                                                uVar24 = Int32.Parse(uVar8,0);
                                                                if (lVar11 == null) goto LAB_180c27762;
                                                                lVar11._items = uVar24;
                                                                uVar8 = LTCSVLoader.GetValueAt
                                                                                  (lVar10,1,iVar21);
                                                                *(uint64 *)(lVar11 + 32) = uVar8;
                                                                il2cpp_internal((uint64 *)
                                                                                    (lVar11 + 32),uVar8)
                                                                ;
                                                                uVar8 = LTCSVLoader.GetValueAt
                                                                                  (lVar10,2,iVar21);
                                                                uVar24 = Int32.Parse(uVar8,0);
                                                                lVar11.Count = uVar24;
                                                                if (*(int64 *)(lVar11 + 96) == 0)
                                                                goto LAB_180c27762;
                                                                lVar12 = *(int64 *)
                                                                          (*(int64 *)(lVar11 + 96) +
                                                                          32);
                                                                uVar8 = LTCSVLoader.GetValueAt
                                                                                  (lVar10,3,iVar21);
                                                                Single.Parse(uVar8,0);
                                                                if (lVar12 == null) goto LAB_180c27762;
                                                                HeroSpeAddData.Set(lVar12,61);
                                                                if (*(int64 *)(lVar11 + 96) == 0)
                                                                goto LAB_180c27762;
                                                                lVar12 = *(int64 *)
                                                                          (*(int64 *)(lVar11 + 96) +
                                                                          32);
                                                                uVar8 = LTCSVLoader.GetValueAt
                                                                                  (lVar10,4,iVar21);
                                                                Single.Parse(uVar8,0);
                                                                if (lVar12 == null) goto LAB_180c27762;
                                                                HeroSpeAddData.Set(lVar12,7);
                                                                lVar12 = *(int64 *)(lVar11 + 96);
                                                                uVar8 = LTCSVLoader.GetValueAt(lVar10);
                                                                uVar24 = Int32.Parse(uVar8);
                                                                if (lVar12 == null) goto LAB_180c27762;
                                                                *(uint32 *)(lVar12 + 20) = uVar24;
                                                                iVar23 = lVar11.Count;
                                                                if (iVar23 == 1) {
                                                                  lVar11 = this.armorDataBase;
        LAB_180c2360a:
                                                                  if (lVar11 == null) goto LAB_180c27762;
                                                                  FUN_1808ab370();
                                                                }
                                                                else {
                                                                  if (iVar23 == 2) {
                                                                    lVar11 = *(int64 *)
                                                                              (this + 0x100);
                                                                    goto LAB_180c2360a;
                                                                  }
                                                                  if (iVar23 == 3) {
                                                                    lVar11 = *(int64 *)
                                                                              (this + 0x108);
                                                                    goto LAB_180c2360a;
                                                                  }
                                                                }
                                                                iVar21 = iVar21 + 1;
                                                              } while (iVar21 < iVar5);
                                                            }
                                                            uVar8 = DAT_181dc2db8;
                                                            uVar8 = Type.GetTypeFromHandle(uVar8,0);
                                                            uVar8 = Resources.Load("GameData/MedData",uVar8,0)
                                                            ;
                                                            lVar10 = FUN_1800020c0(uVar8,DAT_181daab10);
                                                            if (lVar10 != null) {
                                                              uVar8 = FUN_1800020c0(uVar8,DAT_181daab10);
                                                              uVar8 = FUN_180da4db0(uVar8,0);
                                                              lVar10 = new c.DisplayClass9_0(0);
                                                              if (lVar10 != null) {
                                                                LTCSVLoader.ReadMultiLine(lVar10,uVar8,0)
                                                                ;
                                                                iVar5 = LTCSVLoader.GetRow(lVar10,0);
                                                                uVar8 = il2cpp_internal(DAT_181d810e8)
                                                                ;
                                                                FUN_1808b1370(uVar8,DAT_181dbc028);
                                                                this.medDataBase = uVar8;
                                                                il2cpp_internal(this + 0x110,uVar8)
                                                                ;
                                                                iVar21 = 1;
                                                                if (1 < iVar5) {
                                                                  do {
                                                                    lVar11 = il2cpp_internal(
                                                        DAT_181d82098);
                                                        ItemData.ctor(lVar11,1);
                                                        GameDataController.LoadMedFoodData
                                                                  (this,lVar11,lVar10,iVar21,0);
                                                        if ((lVar11 == null) ||
                                                           (this.medDataBase == null))
                                                        goto LAB_180c27762;
                                                        FUN_1808ab370(this.medDataBase,
                                                                      lVar11._items,
                                                                      lVar11,DAT_181dbc0b0);
                                                        iVar21 = iVar21 + 1;
                                                        } while (iVar21 < iVar5);
                                                        }
                                                        uVar8 = DAT_181dc2db8;
                                                        uVar8 = Type.GetTypeFromHandle(uVar8,0);
                                                        uVar8 = Resources.Load("GameData/FoodData",uVar8,0);
                                                        lVar10 = FUN_1800020c0(uVar8,DAT_181daab10);
                                                        if (lVar10 != null) {
                                                          uVar8 = FUN_1800020c0(uVar8,DAT_181daab10);
                                                          uVar8 = FUN_180da4db0(uVar8,0);
                                                          lVar10 = new c.DisplayClass9_0(0);
                                                          if (lVar10 != null) {
                                                            LTCSVLoader.ReadMultiLine(lVar10,uVar8,0);
                                                            iVar5 = LTCSVLoader.GetRow(lVar10,0);
                                                            uVar8 = il2cpp_internal(DAT_181d810e8);
                                                            FUN_1808b1370(uVar8,DAT_181dbc028);
                                                            this.foodDataBase = uVar8;
                                                            iVar21 = 1;
                                                            if (1 < iVar5) {
                                                              do {
                                                                lVar11 = il2cpp_internal(DAT_181d82098
                                                                                            );
                                                                ItemData.ctor(lVar11,2);
                                                                GameDataController.LoadMedFoodData
                                                                          (this,lVar11,lVar10,iVar21,0)
                                                                ;
                                                                uVar8 = LTCSVLoader.GetValueAt
                                                                                  (lVar10,14,iVar21);
                                                                uVar24 = Int32.Parse(uVar8,0);
                                                                if (lVar11 == null) goto LAB_180c27762;
                                                                lVar11.Count = uVar24;
                                                                if (this.foodDataBase == null)
                                                                goto LAB_180c27762;
                                                                FUN_1808ab370(*(int64 *)
                                                                               (this + 0x118),
                                                                              *(uint32 *)
                                                                               (lVar11 + 16),lVar11,
                                                                              DAT_181dbc0b0);
                                                                iVar21 = iVar21 + 1;
                                                              } while (iVar21 < iVar5);
                                                            }
                                                            uVar8 = DAT_181dc2db8;
                                                            uVar8 = Type.GetTypeFromHandle(uVar8,0);
                                                            uVar8 = Resources.Load("GameData/HorseData",uVar8,0)
                                                            ;
                                                            lVar10 = FUN_1800020c0(uVar8,DAT_181daab10);
                                                            if (lVar10 != null) {
                                                              uVar8 = FUN_1800020c0(uVar8,DAT_181daab10);
                                                              uVar8 = FUN_180da4db0(uVar8,0);
                                                              lVar10 = new c.DisplayClass9_0(0);
                                                              if (lVar10 != null) {
                                                                LTCSVLoader.ReadMultiLine(lVar10,uVar8,0)
                                                                ;
                                                                iVar5 = LTCSVLoader.GetRow(lVar10,0);
                                                                uVar8 = il2cpp_internal(DAT_181d810e8)
                                                                ;
                                                                FUN_1808b1370(uVar8,DAT_181dbc028);
                                                                this.horseDataBase = uVar8;
                                                                il2cpp_internal(this + 0x120,uVar8)
                                                                ;
                                                                iVar21 = 1;
                                                                if (1 < iVar5) {
                                                                  do {
                                                                    lVar11 = il2cpp_internal(
                                                        DAT_181d82098);
                                                        ItemData.ctor(lVar11,6);
                                                        GameDataController.LoadHorseData
                                                                  (this,lVar11,lVar10,iVar21,0);
                                                        if ((lVar11 == null) ||
                                                           (this.horseDataBase == null))
                                                        goto LAB_180c27762;
                                                        FUN_1808ab370(this.horseDataBase,
                                                                      lVar11._items,
                                                                      lVar11,DAT_181dbc0b0);
                                                        iVar21 = iVar21 + 1;
                                                        } while (iVar21 < iVar5);
                                                        }
                                                        uVar8 = DAT_181dc2db8;
                                                        uVar8 = Type.GetTypeFromHandle(uVar8,0);
                                                        uVar8 = Resources.Load("GameData/HeroNatureTalkText",uVar8,0);
                                                        lVar10 = FUN_1800020c0(uVar8,DAT_181daab10);
                                                        if (lVar10 != null) {
                                                          uVar8 = FUN_1800020c0(uVar8,DAT_181daab10);
                                                          uVar8 = FUN_180da4db0(uVar8,0);
                                                          lVar10 = new c.DisplayClass9_0(0);
                                                          if (lVar10 != null) {
                                                            LTCSVLoader.ReadMultiLine(lVar10,uVar8,0);
                                                            iVar5 = LTCSVLoader.GetRow(lVar10,0);
                                                            iVar21 = LTCSVLoader.GetCol(lVar10,0);
                                                            iVar23 = 1;
                                                            if (1 < iVar21) {
                                                              do {
                                                                lVar11 = this.HeroNatureTalkTextDataBase;
                                                                uVar8 = il2cpp_internal(DAT_181d97750)
                                                                ;
                                                                FUN_18132faf0(uVar8,DAT_181da3bd8);
                                                                if (lVar11 == null) goto LAB_180c27762;
                                                                FUN_18181e0a0(lVar11,uVar8,DAT_181d792a8);
                                                                iVar6 = 2;
                                                                if (2 < iVar5) {
                                                                  do {
                                                                    if (this.HeroNatureTalkTextDataBase ==
                                                                        0) goto LAB_180c27762;
                                                                    lVar11 = FUN_180002f80(*(int64 *)
                                                                                            (this +
                                                                                            0x140),iVar23 
                                                        + -1,DAT_181d793a8);
                                                        uVar8 = LTCSVLoader.GetValueAt
                                                                          (lVar10,iVar23,iVar6,0);
                                                        if (lVar11 == null) goto LAB_180c27762;
                                                        FUN_18181e0a0(lVar11,uVar8,DAT_181da3d58);
                                                        iVar6 = iVar6 + 1;
                                                        } while (iVar6 < iVar5);
                                                        }
                                                        iVar23 = iVar23 + 1;
                                                        } while (iVar23 < iVar21);
                                                        }
                                                        uVar8 = DAT_181dc2db8;
                                                        uVar8 = Type.GetTypeFromHandle(uVar8,0);
                                                        uVar8 = Resources.Load("GameData/HeroSpeTalkText",uVar8,0);
                                                        lVar10 = FUN_1800020c0(uVar8,DAT_181daab10);
                                                        if (lVar10 != null) {
                                                          uVar8 = FUN_1800020c0(uVar8,DAT_181daab10);
                                                          uVar8 = FUN_180da4db0(uVar8,0);
                                                          lVar10 = new c.DisplayClass9_0(0);
                                                          if (lVar10 != null) {
                                                            LTCSVLoader.ReadMultiLine(lVar10,uVar8,0);
                                                            iVar5 = LTCSVLoader.GetRow(lVar10,0);
                                                            iVar21 = LTCSVLoader.GetCol(lVar10,0);
                                                            iVar23 = 1;
                                                            if (1 < iVar21) {
                                                              do {
                                                                lVar11 = this.HeroSpeTalkTextDataBase;
                                                                uVar8 = il2cpp_internal(DAT_181d76490)
                                                                ;
                                                                HeroSpeTalkTextDataBase.ctor(uVar8,0);
                                                                if (lVar11 == null) goto LAB_180c27762;
                                                                FUN_18181e0a0(lVar11,uVar8,DAT_181d8c318);
                                                                if (this.HeroSpeTalkTextDataBase == null)
                                                                goto LAB_180c27762;
                                                                lVar11 = FUN_18020f010(*(int64 *)
                                                                                        (this + 0x148),
                                                                                       iVar23 + -1,
                                                                                       DAT_181d8c418);
                                                                lVar12 = LTCSVLoader.GetValueAt
                                                                                   (lVar10,iVar23,0,0);
                                                                lVar13 = FUN_1800d60b0(DAT_181da1040,1);
                                                                if (lVar13 == null) goto LAB_180c27762;
                                                                if (*(int *)(lVar13 + 24) == 0) {
                                                                  uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                                  FUN_1800d65f0(uVar8,0);
                                                                }
                                                                *(uint16 *)(lVar13 + 32) = 124;
                                                                if (lVar12 == null) goto LAB_180c27762;
                                                                uVar8 = String.Split(lVar12,lVar13,0);
                                                                uVar14 = il2cpp_internal(DAT_181d97750
                                                                                            );
                                                                FUN_181827480(uVar14,uVar8,DAT_181da3c58);
                                                                if (lVar11 == null) goto LAB_180c27762;
                                                                lVar11._items = uVar14;
                                                                iVar6 = 1;
                                                                if (1 < iVar5) {
                                                                  do {
                                                                    if ((this.HeroSpeTalkTextDataBase ==
                                                                         0) || (lVar11 = FUN_180002f80(*(
                                                        int64 *)(this + 0x148),iVar23 + -1,
                                                        DAT_181d8c418), lVar11 == null)) goto LAB_180c27762;
                                                        lVar11 = lVar11.Count;
                                                        uVar8 = LTCSVLoader.GetValueAt
                                                                          (lVar10,iVar23,iVar6,0);
                                                        if (lVar11 == null) goto LAB_180c27762;
                                                        FUN_18181e0a0(lVar11,uVar8,DAT_181da3d58);
                                                        iVar6 = iVar6 + 1;
                                                        } while (iVar6 < iVar5);
                                                        }
                                                        iVar23 = iVar23 + 1;
                                                        } while (iVar23 < iVar21);
                                                        }
                                                        uVar8 = DAT_181dc2db8;
                                                        uVar8 = Type.GetTypeFromHandle(uVar8,0);
                                                        uVar8 = Resources.Load("GameData/PlotData",uVar8,0);
                                                        lVar10 = FUN_1800020c0(uVar8,DAT_181daab10);
                                                        if (lVar10 != null) {
                                                          uVar8 = FUN_1800020c0(uVar8,DAT_181daab10);
                                                          uVar8 = FUN_180da4db0(uVar8,0);
                                                          lVar10 = new c.DisplayClass9_0(0);
                                                          if (lVar10 != null) {
                                                            LTCSVLoader.ReadMultiLine(lVar10,uVar8,0);
                                                            iVar21 = LTCSVLoader.GetRow(lVar10,0);
                                                            uVar8 = il2cpp_internal(DAT_181d812e8);
                                                            FUN_1808b1370(uVar8,DAT_181dbce70);
                                                            this.PlotDataBase = uVar8;
                                                            iVar5 = 1;
                                                            if (1 < iVar21) {
                                                              do {
                                                                lVar11 = il2cpp_internal(DAT_181d91c08
                                                                                            );
                                                                PlotData.ctor(lVar11,0);
                                                                if (lVar11 == null) goto LAB_180c27762;
                                                                lVar11.Count = 1;
                                                                uVar8 = LTCSVLoader.GetValueAt
                                                                                  (lVar10,0,iVar5,0);
                                                                uVar24 = Int32.Parse(uVar8,0);
                                                                lVar11._version = uVar24;
                                                                for (iVar23 = iVar5; iVar23 < iVar21;
                                                                    iVar23 = iVar23 + 1) {
                                                                  if (iVar23 != iVar5) {
                                                                    uVar8 = LTCSVLoader.GetValueAt
                                                                                      (lVar10,0,iVar23,0);
                                                                    cVar3 = FUN_18171e540(uVar8,
                                                        "",0);
                                                        if (!cVar3) break;
                                                        }
                                                        lVar12 = new SinglePlotData(0);
                                                        uVar8 = LTCSVLoader.GetValueAt(lVar10,1,iVar23);
                                                        cVar3 = FUN_18171e540(uVar8,"",0);
                                                        if (!cVar3) {
                                                          uVar8 = LTCSVLoader.GetValueAt(lVar10,1,iVar23)
                                                          ;
                                                          cVar3 = FUN_18171e540(uVar8,"玩家",0);
                                                          if (!cVar3) {
                                                            if (lVar12 == null) goto LAB_180c27762;
                                                            *(uint32 *)(lVar12 + 28) = 5;
                                                            uVar8 = LTCSVLoader.GetValueAt
                                                                              (lVar10,1,iVar23);
                                                            lVar12.count = uVar8;
                                                            il2cpp_internal((uint64 *)
                                                                                (lVar12 + 32),uVar8);
                                                          }
                                                          else {
                                                            if (lVar12 == null) goto LAB_180c27762;
                                                            *(uint32 *)(lVar12 + 28) = 3;
                                                            lVar12.count = "0"
                                                            ;
                                                            il2cpp_internal();
                                                          }
                                                        }
                                                        else {
                                                          if (lVar12 == null) goto LAB_180c27762;
                                                          *(uint32 *)(lVar12 + 28) =
                                                               (uint32)(iVar23 == iVar5);
                                                        }
                                                        uVar8 = LTCSVLoader.GetValueAt(lVar10,2,iVar23);
                                                        cVar3 = FUN_18171e540(uVar8,"",0);
                                                        if (!cVar3) {
                                                          uVar8 = LTCSVLoader.GetValueAt(lVar10,2,iVar23)
                                                          ;
                                                          cVar3 = FUN_18171e540(uVar8,"玩家",0);
                                                          if (!cVar3) {
                                                            lVar12.version = 5;
                                                            uVar8 = LTCSVLoader.GetValueAt
                                                                              (lVar10,2,iVar23);
                                                            *(uint64 *)(lVar12 + 48) = uVar8;
                                                            il2cpp_internal((uint64 *)
                                                                                (lVar12 + 48),uVar8);
                                                          }
                                                          else {
                                                            lVar12.version = 3;
                                                            *(uint64 *)(lVar12 + 48) = "0"
                                                            ;
                                                            il2cpp_internal();
                                                          }
                                                        }
                                                        else {
                                                          lVar12.version =
                                                               (uint32)(iVar23 == iVar5);
                                                        }
                                                        lVar13 = LTCSVLoader.GetValueAt(lVar10,3,iVar23);
                                                        if (lVar13 != null) {
                                                          cVar3 = FUN_18171e540(lVar13,"左",0);
                                                          if (!cVar3) {
                                                            cVar3 = FUN_18171e540(lVar13,"右",0);
                                                            if (!cVar3) {
                                                              cVar3 = FUN_18171e540(lVar13,"无",0
                                                                                   );
                                                              if (!cVar3) {
                                                                cVar3 = FUN_18171e540(lVar13,"皆"
                                                                                      ,0);
                                                                if (cVar3) {
                                                                  lVar12.entries = 2;
                                                                }
                                                              }
                                                              else {
                                                                lVar12.entries = 3;
                                                              }
                                                            }
                                                            else {
                                                              lVar12.entries = 0;
                                                            }
                                                          }
                                                          else {
                                                            lVar12.entries = 1;
                                                          }
                                                        }
                                                        uVar8 = LTCSVLoader.GetValueAt(lVar10,4,iVar23);
                                                        *(uint64 *)(lVar12 + 80) = uVar8;
                                                        il2cpp_internal((uint64 *)(lVar12 + 80),
                                                                            uVar8);
                                                        uVar8 = LTCSVLoader.GetValueAt(lVar10,5,iVar23);
                                                        *(uint64 *)(lVar12 + 88) = uVar8;
                                                        il2cpp_internal((uint64 *)(lVar12 + 88),
                                                                            uVar8);
                                                        uVar8 = LTCSVLoader.GetValueAt(lVar10,6,iVar23);
                                                        *(uint64 *)(lVar12 + 96) = uVar8;
                                                        il2cpp_internal((uint64 *)(lVar12 + 96),
                                                                            uVar8);
                                                        uVar8 = LTCSVLoader.GetValueAt(lVar10,7,iVar23);
                                                        cVar3 = FUN_18171e540(uVar8,"true",0);
                                                        if (!cVar3) {
                                                          uVar8 = LTCSVLoader.GetValueAt(lVar10,7,iVar23)
                                                          ;
                                                          cVar3 = FUN_18171e540(uVar8,"TRUE",0);
                                                        }
                                                        else {
                                                          cVar3 = true;
                                                        }
                                                        *(bool *)(lVar12 + 104) = cVar3;
                                                        uVar8 = LTCSVLoader.GetValueAt(lVar10,8,iVar23);
                                                        *(uint64 *)(lVar12 + 64) = uVar8;
                                                        il2cpp_internal((uint64 *)(lVar12 + 64),
                                                                            uVar8);
                                                        uVar8 = LTCSVLoader.GetValueAt(lVar10,9,iVar23);
                                                        cVar3 = String.op_Inequality
                                                                          (uVar8,"",0);
                                                        if (cVar3) {
                                                          lVar13 = LTCSVLoader.GetValueAt
                                                                             (lVar10,9,iVar23);
                                                          lVar15 = FUN_1800d60b0(DAT_181da1040,1);
                                                          if ((lVar15 == null) ||
                                                             (FUN_1800048e0(lVar15,0,124), lVar13 == null))
                                                          goto LAB_180c27762;
                                                          uVar8 = String.Split(lVar13,lVar15,0);
                                                          uVar14 = il2cpp_internal(DAT_181d97750);
                                                          FUN_181827480(uVar14,uVar8,DAT_181da3c58);
                                                          SinglePlotData.SetChoiceDataTexts
                                                                    (lVar12,uVar14,0);
                                                        }
                                                        uVar8 = LTCSVLoader.GetValueAt(lVar10,10,iVar23);
                                                        lVar12.buckets = uVar8;
                                                        il2cpp_internal((uint64 *)(lVar12 + 16),
                                                                            uVar8);
                                                        if (*(int64 *)(lVar11 + 64) == 0)
                                                        goto LAB_180c27762;
                                                        FUN_18181e0a0(*(int64 *)(lVar11 + 64),lVar12,
                                                                      DAT_181da13f0);
                                                        }
                                                        if (this.PlotDataBase == null)
                                                        goto LAB_180c27762;
                                                        FUN_1808ab370(this.PlotDataBase,
                                                                      lVar11._version,
                                                                      lVar11);
                                                        iVar5 = iVar23;
                                                        } while (iVar23 < iVar21);
                                                        }
                                                        uVar8 = DAT_181dc2db8;
                                                        uVar8 = Type.GetTypeFromHandle(uVar8,0);
                                                        uVar8 = Resources.Load("GameData/SummonData",uVar8,0);
                                                        lVar10 = FUN_1800020c0(uVar8,DAT_181daab10);
                                                        if (lVar10 != null) {
                                                          uVar8 = FUN_1800020c0(uVar8,DAT_181daab10);
                                                          uVar8 = FUN_180da4db0(uVar8,0);
                                                          lVar10 = new c.DisplayClass9_0(0);
                                                          if (lVar10 != null) {
                                                            LTCSVLoader.ReadMultiLine(lVar10,uVar8,0);
                                                            iVar5 = LTCSVLoader.GetRow(lVar10,0);
                                                            uVar8 = il2cpp_internal(DAT_181d816e8);
                                                            FUN_1808b1370(uVar8,DAT_181dbe8f8);
                                                            this.SummonDataBase = uVar8;
                                                            iVar21 = 1;
                                                            if (1 < iVar5) {
                                                              do {
                                                                lVar11 = il2cpp_internal(DAT_181da8590
                                                                                            );
                                                                c__DisplayClass9_0.ctor(lVar11,0);
                                                                uVar8 = LTCSVLoader.GetValueAt
                                                                                  (lVar10,0,iVar21,0);
                                                                uVar24 = Int32.Parse(uVar8,0);
                                                                if (lVar11 == null) goto LAB_180c27762;
                                                                lVar11._items = uVar24;
                                                                uVar8 = LTCSVLoader.GetValueAt
                                                                                  (lVar10,1,iVar21);
                                                                lVar11.Count = uVar8;
                                                                il2cpp_internal((uint64 *)
                                                                                    (lVar11 + 24),uVar8)
                                                                ;
                                                                uVar8 = LTCSVLoader.GetValueAt
                                                                                  (lVar10,2,iVar21);
                                                                uVar24 = Int32.Parse(uVar8,0);
                                                                *(uint32 *)(lVar11 + 20) = uVar24;
                                                                uVar8 = LTCSVLoader.GetValueAt
                                                                                  (lVar10,3,iVar21);
                                                                uVar24 = Single.Parse(uVar8,0);
                                                                *(uint32 *)(lVar11 + 32) = uVar24;
                                                                uVar8 = LTCSVLoader.GetValueAt
                                                                                  (lVar10,4,iVar21);
                                                                uVar24 = Single.Parse(uVar8,0);
                                                                *(uint32 *)(lVar11 + 36) = uVar24;
                                                                uVar8 = LTCSVLoader.GetValueAt
                                                                                  (lVar10,5,iVar21);
                                                                uVar24 = Single.Parse(uVar8,0);
                                                                *(uint32 *)(lVar11 + 40) = uVar24;
                                                                uVar8 = il2cpp_internal(DAT_181d93cd0)
                                                                ;
                                                                FUN_18132faf0(uVar8,DAT_181d8f098);
                                                                *(uint64 *)(lVar11 + 48) = uVar8;
                                                                lVar12 = LTCSVLoader.GetValueAt
                                                                                   (lVar10,6,iVar21);
                                                                lVar13 = FUN_1800d60b0(DAT_181da1040,1);
                                                                if (lVar13 == null) goto LAB_180c27762;
                                                                if (*(int *)(lVar13 + 24) == 0) {
                                                                  uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                                  FUN_1800d65f0(uVar8,0);
                                                                }
                                                                *(uint16 *)(lVar13 + 32) = 59;
                                                                if (lVar12 == null) goto LAB_180c27762;
                                                                lVar12 = String.Split(lVar12,lVar13,0);
                                                                iVar23 = 0;
                                                                while( true ) {
                                                                  if (lVar12 == null) goto LAB_180c27762;
                                                                  if (lVar12.entries <= iVar23)
                                                                  break;
                                                                  lVar13 = *(int64 *)(lVar11 + 48);
                                                                  uVar8 = FUN_1800021a0(lVar12,(int64)
                                                                                               iVar23);
                                                                  uVar24 = Int32.Parse(uVar8,0);
                                                                  if (lVar13 == null) goto LAB_180c27762;
                                                                  FUN_18182a0b0(lVar13,uVar24,
                                                                                DAT_181d8f218);
                                                                  iVar23 = iVar23 + 1;
                                                                }
                                                                uVar8 = LTCSVLoader.GetValueAt
                                                                                  (lVar10,7,iVar21);
                                                                *(uint64 *)(lVar11 + 56) = uVar8;
                                                                il2cpp_internal((uint64 *)
                                                                                    (lVar11 + 56),uVar8)
                                                                ;
                                                                uVar8 = LTCSVLoader.GetValueAt
                                                                                  (lVar10,8,iVar21);
                                                                uVar4 = FUN_18171e540(uVar8,"TRUE",
                                                                                      0);
                                                                *(uint8 *)(lVar11 + 64) = uVar4;
                                                                if (this.SummonDataBase == null)
                                                                goto LAB_180c27762;
                                                                FUN_1808ab370(*(int64 *)
                                                                               (this + 0x180),
                                                                              *(uint32 *)
                                                                               (lVar11 + 16),lVar11);
                                                                iVar21 = iVar21 + 1;
                                                              } while (iVar21 < iVar5);
                                                            }
                                                            uVar8 = DAT_181dc2db8;
                                                            uVar8 = Type.GetTypeFromHandle(uVar8,0);
                                                            uVar8 = Resources.Load("GameData/SummonKungFuData",uVar8,0)
                                                            ;
                                                            lVar10 = FUN_1800020c0(uVar8,DAT_181daab10);
                                                            if (lVar10 != null) {
                                                              uVar8 = FUN_1800020c0(uVar8,DAT_181daab10);
                                                              uVar8 = FUN_180da4db0(uVar8,0);
                                                              lVar10 = new c.DisplayClass9_0(0);
                                                              if (lVar10 != null) {
                                                                LTCSVLoader.ReadMultiLine(lVar10,uVar8,0)
                                                                ;
                                                                iVar5 = LTCSVLoader.GetRow(lVar10,0);
                                                                uVar8 = il2cpp_internal(DAT_181d81168)
                                                                ;
                                                                FUN_1808b1370(uVar8,DAT_181dbc2d0);
                                                                this.summonSkillDataBase = uVar8;
                                                                il2cpp_internal(this + 0x130,uVar8)
                                                                ;
                                                                iVar21 = 1;
                                                                if (1 < iVar5) {
                                                                  do {
                                                                    lVar11 = 
                                                        GameDataController.LoadSkillData
                                                                  (this,lVar10,iVar21,1,0);
                                                        if ((lVar11 == null) ||
                                                           (this.summonSkillDataBase == null))
                                                        goto LAB_180c27762;
                                                        FUN_1808ab370(this.summonSkillDataBase,
                                                                      *(uint32 *)(lVar11 + 20),
                                                                      lVar11,DAT_181dbc358);
                                                        iVar21 = iVar21 + 1;
                                                        } while (iVar21 < iVar5);
                                                        }
                                                        uVar8 = DAT_181dc2db8;
                                                        uVar8 = Type.GetTypeFromHandle(uVar8,0);
                                                        uVar8 = Resources.Load("GameData/KungFuData",uVar8,0);
                                                        lVar10 = FUN_1800020c0(uVar8,DAT_181daab10);
                                                        if (lVar10 != null) {
                                                          uVar8 = FUN_1800020c0(uVar8,DAT_181daab10);
                                                          uVar8 = FUN_180da4db0(uVar8,0);
                                                          lVar10 = new c.DisplayClass9_0(0);
                                                          if (lVar10 != null) {
                                                            LTCSVLoader.ReadMultiLine(lVar10,uVar8,0);
                                                            iVar5 = LTCSVLoader.GetRow(lVar10,0);
                                                            uVar8 = il2cpp_internal(DAT_181d80568);
                                                            FUN_1808b1370(uVar8,DAT_181db6830);
                                                            this.kungfuSkillDataList = uVar8;
                                                            uVar8 = il2cpp_internal(DAT_181d81168);
                                                            FUN_1808b1370(uVar8,DAT_181dbc2d0);
                                                            this.kungfuSkillDataBase = uVar8;
                                                            il2cpp_internal((uint64 *)
                                                                                (this + 0x128),uVar8);
                                                            lVar11 = il2cpp_internal(DAT_181d90260);
                                                            FUN_18132faf0(lVar11,DAT_181d78c28);
                                                            iVar21 = 0;
                                                            do {
                                                              uVar8 = il2cpp_internal(DAT_181d94550);
                                                              FUN_18132faf0(uVar8,DAT_181d91f10);
                                                              if (lVar11 == null) goto LAB_180c27762;
                                                              FUN_18181e0a0(lVar11,uVar8,DAT_181d78ca8);
                                                              iVar21 = iVar21 + 1;
                                                            } while (iVar21 < 6);
                                                            if (this.kungfuSkillDataList != null) {
                                                              FUN_1808ab370(this.kungfuSkillDataList
                                                                            ,0xffffffff,lVar11,
                                                                            DAT_181db68b8);
                                                              if ((this.forceDataBase != null) &&
                                                                 (lVar11 = FUN_1808ae5b0(*(int64 *)
                                                                                          (this + 208)
                                                                                         ,DAT_181db97e8),
                                                                 lVar11 != null)) {
                                                                ValueCollection.GetEnumerator
                                                                          (&local_88,lVar11,DAT_181d7e670)
                                                                ;
                                                                local_e8 = local_88;
                                                                uStack_e0 = uStack_80;
                                                                local_d8 = local_78;
                                                                while (cVar3 = FUN_1811c3f80(&local_e8,
                                                                                             DAT_181d98158
                                                                                            ),
                                                                      lVar11 = local_d8, cVar3) {
                                                                  lVar12 = il2cpp_internal(
                                                        DAT_181d90260);
                                                        FUN_18132faf0(lVar12,DAT_181d78c28);
                                                        for (iVar21 = 0; iVar21 < 6; iVar21 = iVar21 + 1)
                                                        {
                                                          uVar8 = il2cpp_internal(DAT_181d94550);
                                                          FUN_18132faf0(uVar8,DAT_181d91f10);
                                                          if (lVar12 == null) {
                          // WARNING: Subroutine does not return
                                                            FUN_1800d6620();
                                                          }
                                                          FUN_18181e0a0(lVar12,uVar8,DAT_181d78ca8);
                                                        }
                                                        if (lVar11 == null) {
                          // WARNING: Subroutine does not return
                                                          FUN_1800d6620();
                                                        }
                                                        if (this.kungfuSkillDataList == null) {
                          // WARNING: Subroutine does not return
                                                          FUN_1800d6620();
                                                        }
                                                        FUN_1808ab370(this.kungfuSkillDataList,
                                                                      lVar11._items,
                                                                      lVar12);
                                                        }
                                                        ZhSegment.Initialize(&local_e8,DAT_181d980d8);
                                                        iVar21 = 1;
                                                        if (1 < iVar5) {
                                                          do {
                                                            lVar11 = GameDataController.LoadSkillData
                                                                               (this,lVar10,iVar21,0,0)
                                                            ;
                                                            if ((lVar11 == null) ||
                                                               (this.kungfuSkillDataBase == null))
                                                            goto LAB_180c27762;
                                                            FUN_1808ab370(this.kungfuSkillDataBase,
                                                                          *(uint32 *)(lVar11 + 20),
                                                                          lVar11);
                                                            if ((*(int *)(*(int64 *)
                                                                           (DAT_181d73d40 + 184) + 8) ==
                                                                 1) && (cVar3 = FUN_18171e540(*(uint64
                                                                                                *)(lVar11 
                                                        + 32),"???",0), cVar3)) {
                                                          *(uint8 *)(lVar11 + 200) = 1;
                                                        }
                                                        if (*(char *)(lVar11 + 200) == false) {
                                                          if (((this.kungfuSkillDataList == null) ||
                                                              (lVar12 = FUN_1817d9e10(*(int64 *)
                                                                                       (this + 0x138),
                                                                                      *(uint32 *)
                                                                                       (lVar11 + 24),
                                                                                      DAT_181db6940),
                                                              lVar12 == null)) ||
                                                             (lVar12 = FUN_180002f80(lVar12,*(uint32 *
                                                                                             )(lVar11 + 
                                                        52),DAT_181d78da8), lVar12 == null))
                                                        goto LAB_180c27762;
                                                        FUN_18181e0a0(lVar12,lVar11,DAT_181d91f90);
                                                        }
                                                        iVar21 = iVar21 + 1;
                                                        } while (iVar21 < iVar5);
                                                        }
                                                        if ((this.forceDataBase != null) &&
                                                           (lVar10 = FUN_1808ae5b0(*(int64 *)
                                                                                    (this + 208),
                                                                                   DAT_181db97e8),
                                                           lVar10 != null)) {
                                                          ValueCollection.GetEnumerator
                                                                    (&local_70,lVar10,DAT_181d7e670);
                                                          local_e8 = local_70;
                                                          uStack_e0 = uStack_68;
                                                          local_d8 = local_60;
                                                          while (cVar3 = FUN_1811c3f80(&local_e8,
                                                                                       DAT_181d98158),
                                                                lVar10 = local_d8, cVar3) {
                                                            iVar5 = 0;
                                                            while( true ) {
                                                              if (lVar10 == null) {
                          // WARNING: Subroutine does not return
                                                                FUN_1800d6620();
                                                              }
                                                              if (*(int64 *)(lVar10 + 72) == 0) {
                          // WARNING: Subroutine does not return
                                                                FUN_1800d6620();
                                                              }
                                                              if (*(int *)(*(int64 *)(lVar10 + 72) +
                                                                          24) <= iVar5) break;
                                                              if (this.kungfuSkillDataList == null) {
                          // WARNING: Subroutine does not return
                                                                FUN_1800d6620();
                                                              }
                                                              lVar12 = FUN_1817d9e10(*(int64 *)
                                                                                      (this + 0x138),
                                                                                     *(uint32 *)
                                                                                      (lVar10 + 16),
                                                                                     DAT_181db6940);
                                                              lVar11 = this.kungfuSkillDataBase;
                                                              if (*(int64 *)(lVar10 + 72) == 0) {
                          // WARNING: Subroutine does not return
                                                                FUN_1800d6620();
                                                              }
                                                              uVar24 = FUN_1800d6760(*(int64 *)
                                                                                      (lVar10 + 72),
                                                                                     iVar5,DAT_181d8fa18);
                                                              if (lVar11 == null) {
                          // WARNING: Subroutine does not return
                                                                FUN_1800d6620();
                                                              }
                                                              lVar11 = FUN_1817d9e10(lVar11,uVar24,
                                                                                     DAT_181dbc3e0);
                                                              if (lVar11 == null) {
                          // WARNING: Subroutine does not return
                                                                FUN_1800d6620();
                                                              }
                                                              if (lVar12 == null) {
                          // WARNING: Subroutine does not return
                                                                FUN_1800d6620();
                                                              }
                                                              lVar12 = FUN_180002f80(lVar12,*(uint32 *
                                                                                             )(lVar11 + 
                                                        52),DAT_181d78da8);
                                                        lVar11 = this.kungfuSkillDataBase;
                                                        if (*(int64 *)(lVar10 + 72) == 0) {
                          // WARNING: Subroutine does not return
                                                          FUN_1800d6620();
                                                        }
                                                        uVar24 = FUN_1800d6760(*(int64 *)
                                                                                (lVar10 + 72),iVar5,
                                                                               DAT_181d8fa18);
                                                        if (lVar11 == null) {
                          // WARNING: Subroutine does not return
                                                          FUN_1800d6620();
                                                        }
                                                        uVar8 = FUN_1817d9e10(lVar11,uVar24,DAT_181dbc3e0)
                                                        ;
                                                        if (lVar12 == null) {
                          // WARNING: Subroutine does not return
                                                          FUN_1800d6620();
                                                        }
                                                        FUN_18181e0a0(lVar12,uVar8);
                                                        iVar5 = iVar5 + 1;
                                                        }
                                                        }
                                                        ZhSegment.Initialize(&local_e8,DAT_181d980d8);
                                                        uVar8 = DAT_181dc2db8;
                                                        uVar8 = Type.GetTypeFromHandle(uVar8,0);
                                                        uVar8 = Resources.Load("GameData/SpeHeroData",uVar8,0);
                                                        lVar10 = FUN_1800020c0(uVar8,DAT_181daab10);
                                                        if (lVar10 != null) {
                                                          uVar8 = FUN_1800020c0(uVar8,DAT_181daab10);
                                                          uVar8 = FUN_180da4db0(uVar8,0);
                                                          lVar10 = new c.DisplayClass9_0(0);
                                                          if (lVar10 != null) {
                                                            LTCSVLoader.ReadMultiLine(lVar10,uVar8,0);
                                                            iVar5 = LTCSVLoader.GetRow(lVar10,0);
                                                            lVar11 = il2cpp_internal(DAT_181d80e68);
                                                            FUN_1808b1370(lVar11,DAT_181db9f58);
                                                            this.SpeHeroDataBase = lVar11;
                                                            iVar21 = 1;
                                                            if (1 < iVar5) {
                                                              do {
                                                                lVar11 = il2cpp_internal(DAT_181d75eb8
                                                                                            );
                                                                HeroData.ctor(lVar11,0);
                                                                uVar8 = LTCSVLoader.GetValueAt
                                                                                  (lVar10,0,iVar21,0);
                                                                uVar24 = Int32.Parse(uVar8,0);
                                                                if (lVar11 == null) goto LAB_180c27762;
                                                                HeroData.SetHeroID(lVar11,uVar24,0);
                                                                *(uint8 *)(lVar11 + 92) = 1;
                                                                lVar12 = LTCSVLoader.GetValueAt
                                                                                   (lVar10,1,iVar21,0);
                                                                lVar13 = FUN_1800d60b0(DAT_181da1040,1);
                                                                if (lVar13 == null) goto LAB_180c27762;
                                                                if (*(int *)(lVar13 + 24) == 0) {
                                                                  uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                                  FUN_1800d65f0(uVar8,0);
                                                                }
                                                                *(uint16 *)(lVar13 + 32) = 46;
                                                                if ((lVar12 == null) ||
                                                                   (lVar12 = String.Split(lVar12,lVar13,0
                                                                                          ), lVar12 == null))
                                                                goto LAB_180c27762;
                                                                if (lVar12.entries == null) {
                                                                  uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                                  FUN_1800d65f0(uVar8,0);
                                                                }
                                                                *(uint64 *)(lVar11 + 112) =
                                                                     lVar12.count;
                                                                il2cpp_internal();
                                                                if (lVar12.entries < 2) {
                                                                  uVar8 = FUN_1800021a0(lVar12,0);
                                                                }
                                                                else {
                                                                  uVar8 = FUN_1800021a0(lVar12,0);
                                                                  uVar14 = FUN_1800021a0(lVar12,1);
                                                                  uVar8 = String.Concat(uVar8,uVar14,0);
                                                                }
                                                                *(uint64 *)(lVar11 + 104) = uVar8;
                                                                il2cpp_internal((uint64 *)
                                                                                    (lVar11 + 104),uVar8)
                                                                ;
                                                                uVar8 = LTCSVLoader.GetValueAt
                                                                                  (lVar10,2,iVar21);
                                                                uVar4 = FUN_18171e540(uVar8,"女",
                                                                                      0);
                                                                *(uint8 *)(lVar11 + 128) = uVar4;
                                                                uVar8 = LTCSVLoader.GetValueAt
                                                                                  (lVar10,3,iVar21);
                                                                uVar24 = GameDataController.GetForceID
                                                                                   (this,uVar8,0);
                                                                *(uint32 *)(lVar11 + 132) = uVar24;
                                                                uVar8 = LTCSVLoader.GetValueAt
                                                                                  (lVar10,4,iVar21);
                                                                cVar3 = FUN_18171e540(uVar8,"默认",
                                                                                      0);
                                                                if (!cVar3) {
                                                                  uVar8 = LTCSVLoader.GetValueAt
                                                                                    (lVar10,4,iVar21);
                                                                  uVar24 = GameDataController.GetForceID
                                                                                     (this,uVar8,0);
                                                                }
                                                                else {
                                                                  uVar24 = *(uint32 *)(lVar11 + 132);
                                                                }
                                                                *(uint32 *)(lVar11 + 136) = uVar24;
                                                                if (((*(byte *)(DAT_181d73d40 + 0x133) & 4
                                                                     ) != 0) &&
                                                                   (*(int *)(DAT_181d73d40 + 224) == 0))
                                                                {
                                                                  il2cpp_runtime_class_init(DAT_181d73d40)
                                                                  ;
                                                                }
                                                                lVar12 = *(int64 *)
                                                                          (*(int64 *)
                                                                            (DAT_181d73d40 + 184) + 0x3d8
                                                                          );
                                                                uVar8 = LTCSVLoader.GetValueAt
                                                                                  (lVar10,5,iVar21);
                                                                if (lVar12 == null) goto LAB_180c27762;
                                                                iVar23 = FUN_1817eb4e0(lVar12,uVar8,
                                                                                       DAT_181da3fd8);
                                                                *(int *)(lVar11 + 184) = iVar23;
                                                                if (iVar23 == 6) {
                                                                  *(uint32 *)(lVar11 + 184) = 5;
                                                                  *(uint8 *)(lVar11 + 180) = 1;
                                                                }
                                                                uVar8 = LTCSVLoader.GetValueAt
                                                                                  (lVar10,6,iVar21);
                                                                cVar3 = FUN_18171e540(uVar8,"-1",
                                                                                      0);
                                                                if (!cVar3) {
                                                                  uVar8 = LTCSVLoader.GetValueAt
                                                                                    (lVar10,6,iVar21);
                                                                  fVar26 = (float)Single.Parse(uVar8,0);
                                                                }
                                                                else {
                                                                  fVar26 = (float)*(int *)(lVar11 + 184);
                                                                }
                                                                *(float *)(lVar11 + 188) = fVar26;
                                                                if (((*(byte *)(DAT_181d73d40 + 0x133) & 4
                                                                     ) != 0) &&
                                                                   (*(int *)(DAT_181d73d40 + 224) == 0))
                                                                {
                                                                  il2cpp_runtime_class_init(DAT_181d73d40)
                                                                  ;
                                                                }
                                                                lVar12 = *(int64 *)
                                                                          (*(int64 *)
                                                                            (DAT_181d73d40 + 184) + 0x5a8
                                                                          );
                                                                uVar8 = LTCSVLoader.GetValueAt
                                                                                  (lVar10,7,iVar21);
                                                                if (lVar12 == null) goto LAB_180c27762;
                                                                uVar24 = FUN_1817eb4e0(lVar12,uVar8,
                                                                                       DAT_181da3fd8);
                                                                *(uint32 *)(lVar11 + 0x1d8) = uVar24;
                                                                lVar12 = *(int64 *)
                                                                          (*(int64 *)
                                                                            (DAT_181d73d40 + 184) + 0x5b0
                                                                          );
                                                                uVar8 = LTCSVLoader.GetValueAt
                                                                                  (lVar10,8,iVar21);
                                                                if (lVar12 == null) goto LAB_180c27762;
                                                                uVar24 = FUN_1817eb4e0(lVar12,uVar8,
                                                                                       DAT_181da3fd8);
                                                                *(uint32 *)(lVar11 + 0x1dc) = uVar24;
                                                                uVar8 = LTCSVLoader.GetValueAt
                                                                                  (lVar10,9,iVar21);
                                                                uVar24 = Int32.Parse(uVar8,0);
                                                                *(uint32 *)(lVar11 + 212) = uVar24;
                                                                lVar12 = LTCSVLoader.GetValueAt
                                                                                   (lVar10,10,iVar21);
                                                                lVar13 = FUN_1800d60b0(DAT_181da1040,1);
                                                                if ((lVar13 == null) ||
                                                                   (FUN_1800048e0(lVar13,0,47),
                                                                   lVar12 == null)) goto LAB_180c27762;
                                                                lVar13 = String.Split(lVar12,lVar13,0);
                                                                lVar12 = *(int64 *)
                                                                          (*(int64 *)
                                                                            (DAT_181d73d40 + 184) + 0x598
                                                                          );
                                                                if ((lVar13 == null) ||
                                                                   (uVar8 = FUN_1800021a0(lVar13,0),
                                                                   lVar12 == null)) goto LAB_180c27762;
                                                                iVar23 = FUN_1817eb4e0(lVar12,uVar8,
                                                                                       DAT_181da3fd8);
                                                                *(float *)(lVar11 + 0x1d4) =
                                                                     (float)iVar23 * 25.0;
                                                                lVar12 = *(int64 *)
                                                                          (*(int64 *)
                                                                            (DAT_181d73d40 + 184) + 0x5a0
                                                                          );
                                                                uVar8 = FUN_1800021a0(lVar13,1);
                                                                if (lVar12 == null) goto LAB_180c27762;
                                                                iVar23 = FUN_1817eb4e0(lVar12,uVar8,
                                                                                       DAT_181da3fd8);
                                                                *(float *)(lVar11 + 0x1d0) =
                                                                     (float)iVar23 * 25.0;
                                                                uVar8 = LTCSVLoader.GetValueAt
                                                                                  (lVar10,11,iVar21);
                                                                cVar3 = String.op_Inequality
                                                                                  (uVar8,"",0);
                                                                if (cVar3) {
                                                                  lVar12 = LTCSVLoader.GetValueAt
                                                                                     (lVar10,11,iVar21);
                                                                  lVar13 = FUN_1800d60b0(DAT_181da1040,1);
                                                                  if ((lVar13 == null) ||
                                                                     (FUN_1800048e0(lVar13,0,47),
                                                                     lVar12 == null)) goto LAB_180c27762;
                                                                  lVar12 = String.Split(lVar12,lVar13,0);
                                                                  iVar23 = 0;
                                                                  while( true ) {
                                                                    if (lVar12 == null) goto LAB_180c27762;
                                                                    if (lVar12.entries <= iVar23)
                                                                    break;
                                                                    lVar13 = *(int64 *)(lVar11 + 0x108)
                                                                    ;
                                                                    if (((*(byte *)(DAT_181d73d40 + 0x133)
                                                                         & 4) != 0) &&
                                                                       (*(int *)(DAT_181d73d40 + 224) ==
                                                                        0)) {
                                                                      il2cpp_runtime_class_init
                                                                                (DAT_181d73d40);
                                                                    }
                                                                    lVar15 = *(int64 *)
                                                                              (*(int64 *)
                                                                                (DAT_181d73d40 + 184) +
                                                                              0x4a0);
                                                                    uVar8 = FUN_1800021a0(lVar12,(int64
                                                        )iVar23);
                                                        if ((lVar15 == null) ||
                                                           (uVar24 = FUN_1817eb4e0(lVar15,uVar8,
                                                                                   DAT_181da3fd8),
                                                           lVar13 == null)) goto LAB_180c27762;
                                                        FUN_18182a0b0(lVar13,uVar24,DAT_181d8f218);
                                                        iVar23 = iVar23 + 1;
                                                        }
                                                        }
                                                        uVar8 = LTCSVLoader.GetValueAt(lVar10,12,iVar21)
                                                        ;
                                                        cVar3 = String.op_Inequality
                                                                          (uVar8,"",0);
                                                        if (cVar3) {
                                                          lVar12 = LTCSVLoader.GetValueAt
                                                                             (lVar10,12,iVar21);
                                                          lVar13 = FUN_1800d60b0(DAT_181da1040,1);
                                                          if ((lVar13 == null) ||
                                                             (FUN_1800048e0(lVar13,0,47), lVar12 == null))
                                                          goto LAB_180c27762;
                                                          lVar12 = String.Split(lVar12,lVar13,0);
                                                          iVar23 = 0;
                                                          while( true ) {
                                                            if (lVar12 == null) goto LAB_180c27762;
                                                            if (lVar12.entries <= iVar23) break;
                                                            lVar13 = *(int64 *)(lVar11 + 0x110);
                                                            lVar15 = *(int64 *)
                                                                      (pStatics
                                                                      + 0x4b0);
                                                            uVar8 = FUN_1800021a0(lVar12,(int64)iVar23)
                                                            ;
                                                            if ((lVar15 == null) ||
                                                               (uVar24 = FUN_1817eb4e0(lVar15,uVar8,
                                                                                       DAT_181da3fd8),
                                                               lVar13 == null)) goto LAB_180c27762;
                                                            FUN_18182a0b0(lVar13,uVar24,DAT_181d8f218);
                                                            iVar23 = iVar23 + 1;
                                                          }
                                                        }
                                                        uVar8 = LTCSVLoader.GetValueAt(lVar10,13,iVar21)
                                                        ;
                                                        cVar3 = String.op_Inequality
                                                                          (uVar8,"",0);
                                                        if (cVar3) {
                                                          lVar12 = LTCSVLoader.GetValueAt
                                                                             (lVar10,13,iVar21);
                                                          lVar13 = FUN_1800d60b0(DAT_181da1040,1);
                                                          if ((lVar13 == null) ||
                                                             (FUN_1800048e0(lVar13,0,59), lVar12 == null))
                                                          goto LAB_180c27762;
                                                          lVar12 = String.Split(lVar12,lVar13,0);
                                                          iVar23 = 0;
                                                          while( true ) {
                                                            if (lVar12 == null) goto LAB_180c27762;
                                                            if (lVar12.entries <= iVar23) break;
                                                            lVar13 = *(int64 *)(lVar11 + 0x118);
                                                            uVar8 = FUN_1800021a0(lVar12,(int64)iVar23)
                                                            ;
                                                            if (lVar13 == null) goto LAB_180c27762;
                                                            FUN_18181e0a0(lVar13,uVar8,DAT_181da3d58);
                                                            iVar23 = iVar23 + 1;
                                                          }
                                                        }
                                                        uVar8 = LTCSVLoader.GetValueAt(lVar10,14,iVar21)
                                                        ;
                                                        cVar3 = String.op_Inequality
                                                                          (uVar8,"",0);
                                                        if (cVar3) {
                                                          lVar12 = LTCSVLoader.GetValueAt
                                                                             (lVar10,14,iVar21);
                                                          lVar13 = FUN_1800d60b0(DAT_181da1040,1);
                                                          if ((lVar13 == null) ||
                                                             (FUN_1800048e0(lVar13,0,59), lVar12 == null))
                                                          goto LAB_180c27762;
                                                          lVar12 = String.Split(lVar12,lVar13,0);
                                                          iVar23 = 0;
                                                          while( true ) {
                                                            if (lVar12 == null) goto LAB_180c27762;
                                                            if (lVar12.entries <= iVar23) break;
                                                            uVar8 = FUN_1800021a0(lVar12,(int64)iVar23)
                                                            ;
                                                            iVar6 = GameDataController.GetTagID
                                                                              (this,uVar8,0);
                                                            if (iVar6 < 0) {
                                                              uVar8 = FUN_1800021a0(lVar12,(int64)
                                                                                           iVar23);
                                                              uVar8 = String.Concat("Load Spe Hero Tag Error! ",uVar8);
                                                              if (((*(byte *)(DAT_181dbfcc8 + 0x133) & 4)
                                                                   != 0) &&
                                                                 (*(int *)(DAT_181dbfcc8 + 224) == 0)) {
                                                                il2cpp_runtime_class_init();
                                                              }
                                                              Debug.Log(uVar8,0);
                                                              iVar23 = iVar23 + 1;
                                                            }
                                                            else {
                                                              HeroData.AddTag(lVar11,iVar6);
                                                              iVar23 = iVar23 + 1;
                                                            }
                                                          }
                                                        }
                                                        uVar8 = LTCSVLoader.GetValueAt(lVar10,15,iVar21)
                                                        ;
                                                        cVar3 = String.op_Inequality
                                                                          (uVar8,"",0);
                                                        if (cVar3) {
                                                          uVar8 = LTCSVLoader.GetValueAt
                                                                            (lVar10,15,iVar21);
                                                          *(uint64 *)(lVar11 + 120) = uVar8;
                                                          il2cpp_internal((uint64 *)
                                                                              (lVar11 + 120),uVar8);
                                                        }
                                                        uVar8 = LTCSVLoader.GetValueAt
                                                                          (lVar10,16,iVar21);
                                                        uVar4 = FUN_18171e540(uVar8,"1",0);
                                                        *(uint8 *)(lVar11 + 96) = uVar4;
                                                        uVar8 = LTCSVLoader.GetValueAt
                                                                          (lVar10,17,iVar21);
                                                        uVar4 = FUN_18171e540(uVar8,"1",0);
                                                        *(uint8 *)(lVar11 + 140) = uVar4;
                                                        uVar8 = LTCSVLoader.GetValueAt
                                                                          (lVar10,19,iVar21);
                                                        iVar23 = Int32.Parse(uVar8,0);
                                                        *(int *)(lVar11 + 236) = iVar23;
                                                        if (iVar23 == -99) {
                                                          cVar3 = HeroData.HaveForce(lVar11,0);
                                                          if (!cVar3) {
                                                            cVar3 = HeroData.HaveSkillForce(lVar11,0);
                                                            if (cVar3) {
                                                              lVar12 = this.forceDataBase;
                                                              if (lVar12 != null) {
                                                                uVar24 = *(uint32 *)(lVar11 + 136);
                                                                goto LAB_180c25994;
                                                              }
                                                              goto LAB_180c27762;
                                                            }
                                                          }
                                                          else {
                                                            lVar12 = this.forceDataBase;
                                                            if (lVar12 == null) goto LAB_180c27762;
                                                            uVar24 = *(uint32 *)(lVar11 + 132);
        LAB_180c25994:
                                                            lVar12 = FUN_1817d9e10(lVar12,uVar24,
                                                                                   DAT_181db9760);
                                                            if (lVar12 == null) goto LAB_180c27762;
                                                            *(uint32 *)(lVar11 + 236) =
                                                                 lVar12.count;
                                                          }
                                                          if (*(int *)(lVar11 + 236) == -99) {
                                                            *(uint32 *)(lVar11 + 236) = 0xffffffff;
                                                          }
                                                        }
                                                        uVar8 = LTCSVLoader.GetValueAt
                                                                          (lVar10,20,iVar21);
                                                        cVar3 = FUN_18171e540(uVar8,"1",0);
                                                        if (cVar3) {
                                                          if (this.SpeSkeletonName == null)
                                                          goto LAB_180c27762;
                                                          FUN_1808ab370(this.SpeSkeletonName,
                                                                        *(uint64 *)(lVar11 + 104),1,
                                                                        DAT_181d72b08);
                                                        }
                                                        if (*plVar9 == 0) goto LAB_180c27762;
                                                        FUN_1808ab370(*plVar9,*(uint32 *)
                                                                               (lVar11 + 88),lVar11);
                                                        iVar21 = iVar21 + 1;
                                                        } while (iVar21 < iVar5);
                                                        }
                                                        iVar21 = 1;
                                                        if (1 < iVar5) {
                                                          do {
                                                            lVar11 = LTCSVLoader.GetValueAt
                                                                               (lVar10,18,iVar21);
                                                            if (lVar11 != null) {
                                                              uVar8 = LTCSVLoader.GetValueAt
                                                                                (lVar10,18,iVar21);
                                                              cVar3 = String.op_Inequality
                                                                                (uVar8,"",0);
                                                              if (cVar3) {
                                                                lVar11 = LTCSVLoader.GetValueAt
                                                                                   (lVar10,18,iVar21);
                                                                lVar12 = FUN_1800d60b0(DAT_181da1040,1);
                                                                if ((lVar12 != null) &&
                                                                   (FUN_1800048e0(lVar12,0,59),
                                                                   lVar11 != null)) {
                                                                  lVar11 = String.Split(lVar11,lVar12,0);
                                                                  local_f8 = lVar11;
                                                                  uVar8 = LTCSVLoader.GetValueAt
                                                                                    (lVar10,0,iVar21);
                                                                  uVar24 = Int32.Parse(uVar8,0);
                                                                  local_res18 = 0;
        LAB_180c25b30:
                                                                  if (lVar11 == null) goto LAB_180c27762;
                                                                  if (local_res18 <
                                                                      lVar11.Count) {
                                                                    lVar11 = FUN_1800021a0(lVar11,(
                                                        int64)local_res18);
                                                        lVar12 = FUN_1800d60b0(DAT_181da1040,1);
                                                        if (((lVar12 != null) &&
                                                            (FUN_1800048e0(lVar12,0,58), lVar11 != null))
                                                           && (lVar11 = String.Split(lVar11,lVar12,0),
                                                              lVar11 != null)) {
                                                          lVar12 = FUN_1800021a0(lVar11,1);
                                                          lVar13 = FUN_1800d60b0(DAT_181da1040);
                                                          if ((lVar13 != null) &&
                                                             (FUN_1800048e0(lVar13), lVar12 != null)) {
                                                            lVar12 = String.Split(lVar12);
                                                            iVar23 = 0;
        LAB_180c25c00:
                                                            if (lVar12 == null) goto LAB_180c27762;
                                                            if (lVar12.entries <= iVar23)
                                                            goto LAB_180c266cf;
                                                            lVar13 = FUN_1800021a0(lVar11,0);
                                                            if (lVar13 != null) {
                                                              uVar7 = 
                                                        PrivateImplementationDetails.ComputeStringHash
                                                                  (lVar13,0);
                                                        if (uVar7 < 0x1b00bfb7) {
                                                          if (uVar7 == 0xbcfe0f1) {
                                                            cVar3 = FUN_18171e540(lVar13,"结义",0);
                                                            if (!cVar3) goto LAB_180c26676;
                                                            if ((*plVar9 == 0) ||
                                                               (lVar13 = FUN_1817d9e10(*plVar9,uVar24,
                                                                                       DAT_181dba178),
                                                               lVar13 == null)) goto LAB_180c27762;
                                                            lVar13 = *(int64 *)(lVar13 + 0x340);
                                                            lVar15 = (int64)iVar23;
                                                            uVar8 = FUN_1800021a0(lVar12,lVar15);
                                                            uVar25 = Int32.Parse(uVar8,0);
                                                            if (lVar13 == null) goto LAB_180c27762;
                                                            cVar3 = FUN_18182a3a0(lVar13,uVar25,
                                                                                  DAT_181d8f398);
                                                            if (!cVar3) {
                                                              if ((*plVar9 == 0) ||
                                                                 (lVar13 = FUN_1817d9e10(*plVar9,uVar24,
                                                                                         DAT_181dba178),
                                                                 lVar13 == null)) goto LAB_180c27762;
                                                              lVar13 = *(int64 *)(lVar13 + 0x340);
                                                              uVar8 = FUN_1800021a0(lVar12,lVar15);
                                                              uVar25 = Int32.Parse(uVar8,0);
                                                              if (lVar13 == null) goto LAB_180c27762;
                                                              FUN_18182a0b0(lVar13,uVar25,DAT_181d8f218);
                                                            }
                                                            lVar13 = *plVar9;
                                                            uVar8 = FUN_1800021a0(lVar12,lVar15);
                                                            uVar25 = Int32.Parse(uVar8,0);
                                                            if (((lVar13 != null) &&
                                                                (lVar13 = FUN_1817d9e10(lVar13,uVar25,
                                                                                        DAT_181dba178),
                                                                lVar13 != null)) &&
                                                               (*(int64 *)(lVar13 + 0x340) != 0)) {
                                                              cVar3 = FUN_18182a3a0();
                                                              if (cVar3) goto LAB_180c25dde;
                                                              lVar13 = *plVar9;
                                                              uVar8 = FUN_1800021a0(lVar12,lVar15);
                                                              uVar25 = Int32.Parse(uVar8,0);
                                                              if ((lVar13 != null) &&
                                                                 (lVar13 = FUN_1817d9e10(lVar13,uVar25,
                                                                                         DAT_181dba178),
                                                                 lVar13 != null)) {
                                                                lVar13 = *(int64 *)(lVar13 + 0x340);
                                                                goto LAB_180c25dc7;
                                                              }
                                                            }
                                                            goto LAB_180c27762;
                                                          }
                                                          if (uVar7 == 0x19bb3b94) {
                                                            cVar3 = FUN_18171e540(lVar13,"仇人",0);
                                                            if (!cVar3) goto LAB_180c26676;
                                                            if ((*plVar9 == 0) ||
                                                               (lVar13 = FUN_1817d9e10(*plVar9,uVar24,
                                                                                       DAT_181dba178),
                                                               lVar13 == null)) goto LAB_180c27762;
                                                            lVar13 = *(int64 *)(lVar13 + 0x350);
                                                            lVar15 = (int64)iVar23;
                                                            uVar8 = FUN_1800021a0(lVar12,lVar15);
                                                            uVar25 = Int32.Parse(uVar8,0);
                                                            if (lVar13 == null) goto LAB_180c27762;
                                                            cVar3 = FUN_18182a3a0(lVar13,uVar25,
                                                                                  DAT_181d8f398);
                                                            if (!cVar3) {
                                                              if ((*plVar9 == 0) ||
                                                                 (lVar13 = FUN_1817d9e10(*plVar9,uVar24,
                                                                                         DAT_181dba178),
                                                                 lVar13 == null)) goto LAB_180c27762;
                                                              lVar13 = *(int64 *)(lVar13 + 0x350);
                                                              uVar8 = FUN_1800021a0(lVar12,lVar15);
                                                              uVar25 = Int32.Parse(uVar8,0);
                                                              if (lVar13 == null) goto LAB_180c27762;
                                                              FUN_18182a0b0(lVar13,uVar25,DAT_181d8f218);
                                                            }
                                                            lVar13 = *plVar9;
                                                            uVar8 = FUN_1800021a0(lVar12,lVar15);
                                                            uVar25 = Int32.Parse(uVar8,0);
                                                            if (((lVar13 != null) &&
                                                                (lVar13 = FUN_1817d9e10(lVar13,uVar25,
                                                                                        DAT_181dba178),
                                                                lVar13 != null)) &&
                                                               (*(int64 *)(lVar13 + 0x350) != 0)) {
                                                              cVar3 = FUN_18182a3a0();
                                                              if (cVar3) goto LAB_180c25dde;
                                                              lVar13 = *plVar9;
                                                              uVar8 = FUN_1800021a0(lVar12,lVar15);
                                                              uVar25 = Int32.Parse(uVar8,0);
                                                              if ((lVar13 != null) &&
                                                                 (lVar13 = FUN_1817d9e10(lVar13,uVar25,
                                                                                         DAT_181dba178),
                                                                 lVar13 != null)) {
                                                                lVar13 = *(int64 *)(lVar13 + 0x350);
                                                                goto LAB_180c25dc7;
                                                              }
                                                            }
                                                            goto LAB_180c27762;
                                                          }
                                                          if ((uVar7 != 0x1b00bfb6) ||
                                                             (cVar3 = FUN_18171e540(lVar13,"师傅",0
                                                                                   ), !cVar3))
                                                          goto LAB_180c26676;
                                                          if (*plVar9 == 0) goto LAB_180c27762;
                                                          lVar13 = FUN_1817d9e10(*plVar9,uVar24,
                                                                                 DAT_181dba178);
                                                          lVar15 = (int64)iVar23;
                                                          uVar8 = FUN_1800021a0(lVar12,lVar15);
                                                          uVar25 = Int32.Parse(uVar8,0);
                                                          if (lVar13 == null) goto LAB_180c27762;
                                                          *(uint32 *)(lVar13 + 0x31c) = uVar25;
                                                          lVar13 = *plVar9;
                                                          uVar8 = FUN_1800021a0(lVar12,lVar15);
                                                          uVar25 = Int32.Parse(uVar8,0);
                                                          if (((lVar13 == null) ||
                                                              (lVar13 = FUN_1817d9e10(lVar13,uVar25,
                                                                                      DAT_181dba178),
                                                              lVar13 == null)) ||
                                                             (*(int64 *)(lVar13 + 800) == 0))
                                                          goto LAB_180c27762;
                                                          cVar3 = FUN_18182a3a0(*(int64 *)
                                                                                 (lVar13 + 800),iVar21,
                                                                                DAT_181d8f398);
                                                          if (!cVar3) {
                                                            lVar13 = *plVar9;
                                                            uVar8 = FUN_1800021a0(lVar12,lVar15);
                                                            uVar25 = Int32.Parse(uVar8,0);
                                                            if (((lVar13 == null) ||
                                                                (lVar13 = FUN_1817d9e10(lVar13,uVar25,
                                                                                        DAT_181dba178),
                                                                lVar13 == null)) ||
                                                               (*(int64 *)(lVar13 + 800) == 0))
                                                            goto LAB_180c27762;
                                                            FUN_18182a0b0(*(int64 *)(lVar13 + 800),
                                                                          iVar21,DAT_181d8f218);
                                                          }
                                                          if (*plVar9 == 0) goto LAB_180c27762;
                                                          lVar16 = FUN_1817d9e10(*plVar9,uVar24,
                                                                                 DAT_181dba178);
                                                          lVar13 = *plVar9;
                                                          uVar8 = FUN_1800021a0(lVar12,lVar15);
                                                          Int32.Parse(uVar8,0);
                                                          if (((lVar13 == null) ||
                                                              (lVar13 = FUN_1817d9e10(lVar13), lVar13 == null
                                                              )) || (lVar16 == null)) goto LAB_180c27762;
                                                          *(int *)(lVar16 + 216) =
                                                               *(int *)(lVar13 + 216) + 1;
                                                          iVar23 = iVar23 + 1;
                                                          goto LAB_180c25c00;
                                                        }
                                                        if (uVar7 < 0x8485de14) {
                                                          if (uVar7 == 0x62139899) {
                                                            cVar3 = FUN_18171e540(lVar13,"情侣",0);
                                                            if (cVar3) {
                                                              if ((*plVar9 == 0) ||
                                                                 (lVar13 = FUN_1817d9e10(*plVar9,uVar24,
                                                                                         DAT_181dba178),
                                                                 lVar13 == null)) goto LAB_180c27762;
                                                              lVar13 = *(int64 *)(lVar13 + 0x330);
                                                              lVar15 = (int64)iVar23;
                                                              uVar8 = FUN_1800021a0(lVar12,lVar15);
                                                              uVar25 = Int32.Parse(uVar8,0);
                                                              if (lVar13 == null) goto LAB_180c27762;
                                                              cVar3 = FUN_18182a3a0(lVar13,uVar25,
                                                                                    DAT_181d8f398);
                                                              if (!cVar3) {
                                                                if ((*plVar9 == 0) ||
                                                                   (lVar13 = FUN_1817d9e10(*plVar9,uVar24,
                                                                                           DAT_181dba178),
                                                                   lVar13 == null)) goto LAB_180c27762;
                                                                lVar13 = *(int64 *)(lVar13 + 0x330);
                                                                uVar8 = FUN_1800021a0(lVar12,lVar15);
                                                                uVar25 = Int32.Parse(uVar8,0);
                                                                if (lVar13 == null) goto LAB_180c27762;
                                                                FUN_18182a0b0(lVar13,uVar25,DAT_181d8f218)
                                                                ;
                                                              }
                                                              lVar13 = *plVar9;
                                                              uVar8 = FUN_1800021a0(lVar12,lVar15);
                                                              uVar25 = Int32.Parse(uVar8,0);
                                                              if (((lVar13 == null) ||
                                                                  (lVar13 = FUN_1817d9e10(lVar13,uVar25,
                                                                                          DAT_181dba178),
                                                                  lVar13 == null)) ||
                                                                 (*(int64 *)(lVar13 + 0x330) == 0))
                                                              goto LAB_180c27762;
                                                              cVar3 = FUN_18182a3a0();
                                                              if (!cVar3) {
                                                                lVar13 = *plVar9;
                                                                uVar8 = FUN_1800021a0(lVar12,lVar15);
                                                                uVar25 = Int32.Parse(uVar8,0);
                                                                if ((lVar13 == null) ||
                                                                   (lVar13 = FUN_1817d9e10(lVar13,uVar25,
                                                                                           DAT_181dba178),
                                                                   lVar13 == null)) goto LAB_180c27762;
                                                                lVar13 = *(int64 *)(lVar13 + 0x330);
        LAB_180c25dc7:
                                                                if (lVar13 == null) goto LAB_180c27762;
                                                                FUN_18182a0b0();
                                                              }
        LAB_180c25dde:
                                                              iVar23 = iVar23 + 1;
                                                              goto LAB_180c25c00;
                                                            }
                                                          }
                                                          else if ((uVar7 == 0x8485de13) &&
                                                                  (cVar3 = FUN_18171e540(lVar13,
                                                        "朋友",0), cVar3)) {
                                                          if ((*plVar9 == 0) ||
                                                             (lVar13 = FUN_1817d9e10(*plVar9,uVar24,
                                                                                     DAT_181dba178),
                                                             lVar13 == null)) goto LAB_180c27762;
                                                          lVar13 = *(int64 *)(lVar13 + 0x348);
                                                          lVar15 = (int64)iVar23;
                                                          uVar8 = FUN_1800021a0(lVar12,lVar15);
                                                          uVar25 = Int32.Parse(uVar8,0);
                                                          if (lVar13 == null) goto LAB_180c27762;
                                                          cVar3 = FUN_18182a3a0(lVar13,uVar25,
                                                                                DAT_181d8f398);
                                                          if (!cVar3) {
                                                            if ((*plVar9 == 0) ||
                                                               (lVar13 = FUN_1817d9e10(*plVar9,uVar24,
                                                                                       DAT_181dba178),
                                                               lVar13 == null)) goto LAB_180c27762;
                                                            lVar13 = *(int64 *)(lVar13 + 0x348);
                                                            uVar8 = FUN_1800021a0(lVar12,lVar15);
                                                            uVar25 = Int32.Parse(uVar8,0);
                                                            if (lVar13 == null) goto LAB_180c27762;
                                                            FUN_18182a0b0(lVar13,uVar25,DAT_181d8f218);
                                                          }
                                                          lVar13 = *plVar9;
                                                          uVar8 = FUN_1800021a0(lVar12,lVar15);
                                                          uVar25 = Int32.Parse(uVar8,0);
                                                          if (((lVar13 != null) &&
                                                              (lVar13 = FUN_1817d9e10(lVar13,uVar25,
                                                                                      DAT_181dba178),
                                                              lVar13 != null)) &&
                                                             (*(int64 *)(lVar13 + 0x348) != 0)) {
                                                            cVar3 = FUN_18182a3a0();
                                                            if (cVar3) goto LAB_180c25dde;
                                                            lVar13 = *plVar9;
                                                            uVar8 = FUN_1800021a0(lVar12,lVar15);
                                                            uVar25 = Int32.Parse(uVar8,0);
                                                            if ((lVar13 != null) &&
                                                               (lVar13 = FUN_1817d9e10(lVar13,uVar25,
                                                                                       DAT_181dba178),
                                                               lVar13 != null)) {
                                                              lVar13 = *(int64 *)(lVar13 + 0x348);
                                                              goto LAB_180c25dc7;
                                                            }
                                                          }
                                                          goto LAB_180c27762;
                                                        }
                                                        }
                                                        else {
                                                          if (uVar7 != 0xb841b951) {
                                                            if ((uVar7 != 0xf1d60b2a) ||
                                                               (cVar3 = FUN_18171e540(lVar13,"配偶"
                                                                                      ,0), !cVar3))
                                                            goto LAB_180c26676;
                                                            if (*plVar9 == 0) goto LAB_180c27762;
                                                            lVar13 = FUN_1817d9e10(*plVar9,uVar24,
                                                                                   DAT_181dba178);
                                                            uVar8 = FUN_1800021a0(lVar12,(int64)iVar23)
                                                            ;
                                                            uVar25 = Int32.Parse(uVar8,0);
                                                            if (lVar13 == null) goto LAB_180c27762;
                                                            *(uint32 *)(lVar13 + 0x328) = uVar25;
                                                            lVar13 = *plVar9;
                                                            uVar8 = FUN_1800021a0(lVar12,(int64)iVar23)
                                                            ;
                                                            Int32.Parse(uVar8,0);
                                                            if ((lVar13 == null) ||
                                                               (lVar13 = FUN_1817d9e10(lVar13),
                                                               lVar13 == null)) goto LAB_180c27762;
                                                            *(int *)(lVar13 + 0x328) = iVar21;
                                                            iVar23 = iVar23 + 1;
                                                            goto LAB_180c25c00;
                                                          }
                                                          cVar3 = FUN_18171e540(lVar13,"亲属",0);
                                                          if (cVar3) {
                                                            if ((*plVar9 == 0) ||
                                                               (lVar13 = FUN_1817d9e10(*plVar9,uVar24,
                                                                                       DAT_181dba178),
                                                               lVar13 == null)) goto LAB_180c27762;
                                                            lVar13 = *(int64 *)(lVar13 + 0x338);
                                                            lVar15 = (int64)iVar23;
                                                            uVar8 = FUN_1800021a0(lVar12,lVar15);
                                                            uVar25 = Int32.Parse(uVar8,0);
                                                            if (lVar13 == null) goto LAB_180c27762;
                                                            cVar3 = FUN_18182a3a0(lVar13,uVar25,
                                                                                  DAT_181d8f398);
                                                            if (!cVar3) {
                                                              if ((*plVar9 == 0) ||
                                                                 (lVar13 = FUN_1817d9e10(*plVar9,uVar24,
                                                                                         DAT_181dba178),
                                                                 lVar13 == null)) goto LAB_180c27762;
                                                              lVar13 = *(int64 *)(lVar13 + 0x338);
                                                              uVar8 = FUN_1800021a0(lVar12,lVar15);
                                                              uVar25 = Int32.Parse(uVar8,0);
                                                              if (lVar13 == null) goto LAB_180c27762;
                                                              FUN_18182a0b0(lVar13,uVar25,DAT_181d8f218);
                                                            }
                                                            lVar13 = *plVar9;
                                                            uVar8 = FUN_1800021a0(lVar12,lVar15);
                                                            uVar25 = Int32.Parse(uVar8,0);
                                                            if (((lVar13 != null) &&
                                                                (lVar13 = FUN_1817d9e10(lVar13,uVar25,
                                                                                        DAT_181dba178),
                                                                lVar13 != null)) &&
                                                               (*(int64 *)(lVar13 + 0x338) != 0)) {
                                                              cVar3 = FUN_18182a3a0();
                                                              if (cVar3) goto LAB_180c25dde;
                                                              lVar13 = *plVar9;
                                                              uVar8 = FUN_1800021a0(lVar12,lVar15);
                                                              uVar25 = Int32.Parse(uVar8,0);
                                                              if ((lVar13 != null) &&
                                                                 (lVar13 = FUN_1817d9e10(lVar13,uVar25,
                                                                                         DAT_181dba178),
                                                                 lVar13 != null)) {
                                                                lVar13 = *(int64 *)(lVar13 + 0x338);
                                                                goto LAB_180c25dc7;
                                                              }
                                                            }
                                                            goto LAB_180c27762;
                                                          }
                                                        }
                                                        }
        LAB_180c26676:
                                                        FUN_1800021a0(lVar11,0);
                                                        uVar8 = String.Concat("角色关系");
                                                        Debug.Log(uVar8);
                                                        iVar23 = iVar23 + 1;
                                                        goto LAB_180c25c00;
                                                        }
                                                        }
                                                        goto LAB_180c27762;
                                                        }
                                                        goto LAB_180c266f8;
                                                        }
                                                        goto LAB_180c27762;
                                                        }
                                                        }
        LAB_180c266f8:
                                                        iVar21 = iVar21 + 1;
                                                        } while (iVar21 < iVar5);
                                                        }
                                                        uVar8 = DAT_181dc2db8;
                                                        uVar8 = Type.GetTypeFromHandle(uVar8,0);
                                                        uVar8 = Resources.Load("GameData/SpeHeroFaceData",uVar8,0);
                                                        lVar10 = FUN_1800020c0(uVar8,DAT_181daab10);
                                                        if (lVar10 != null) {
                                                          uVar8 = FUN_1800020c0(uVar8,DAT_181daab10);
                                                          uVar8 = FUN_180da4db0(uVar8,0);
                                                          lVar10 = new c.DisplayClass9_0(0);
                                                          if (lVar10 != null) {
                                                            LTCSVLoader.ReadMultiLine(lVar10,uVar8,0);
                                                            iVar5 = LTCSVLoader.GetRow(lVar10,0);
                                                            iVar21 = 1;
                                                            if (1 < iVar5) {
                                                              do {
                                                                lVar11 = il2cpp_internal(DAT_181d76050
                                                                                            );
                                                                HeroFaceData.ctor(lVar11,0);
                                                                uVar8 = LTCSVLoader.GetValueAt
                                                                                  (lVar10,0,iVar21,0);
                                                                uVar24 = Int32.Parse(uVar8,0);
                                                                iVar23 = 0;
                                                                while( true ) {
                                                                  if ((lVar11 == null) ||
                                                                     (lVar12 = *(int64 *)
                                                                                (lVar11 + 16),
                                                                     lVar12 == null)) goto LAB_180c27762;
                                                                  if (lVar12.entries <= iVar23)
                                                                  break;
                                                                  uVar8 = LTCSVLoader.GetValueAt
                                                                                    (lVar10,iVar23 + 2,
                                                                                     iVar21,0);
                                                                  uVar25 = Int32.Parse(uVar8,0);
                                                                  if (lVar12 == null) goto LAB_180c27762;
                                                                  FUN_181833d40(lVar12,iVar23,uVar25);
                                                                  iVar23 = iVar23 + 1;
                                                                }
                                                                if (iVar21 == 1) {
                                                                  plVar17 = &this.MaleFaceTotalNum;
                                                                }
                                                                else if (iVar21 == 2) {
                                                                  plVar17 = &this.FemaleFaceTotalNum;
                                                                }
                                                                else {
                                                                  if ((*plVar9 == 0) ||
                                                                     (lVar12 = FUN_1817d9e10(*plVar9,
                                                        uVar24,DAT_181dba178), lVar12 == null))
                                                        goto LAB_180c27762;
                                                        plVar17 = (int64 *)(lVar12 + 224);
                                                        }
                                                        *plVar17 = lVar11;
                                                        il2cpp_internal();
                                                        iVar21 = iVar21 + 1;
                                                        } while (iVar21 < iVar5);
                                                        }
                                                        uVar8 = il2cpp_internal(DAT_181d90160);
                                                        FUN_18132faf0(uVar8,DAT_181d787a8);
                                                        this.MaleFaceRandomID = uVar8;
                                                        uVar8 = il2cpp_internal(DAT_181d90160);
                                                        FUN_18132faf0(uVar8,DAT_181d787a8);
                                                        this.FemaleFaceRandomID = uVar8;
                                                        iVar5 = 0;
                                                        do {
                                                          lVar10 = this.MaleFaceRandomID;
                                                          uVar8 = il2cpp_internal(DAT_181d93cd0);
                                                          FUN_18132faf0(uVar8,DAT_181d8f098);
                                                          if (lVar10 == null) goto LAB_180c27762;
                                                          FUN_18181e0a0(lVar10,uVar8,DAT_181d78828);
                                                          iVar21 = 0;
                                                          while( true ) {
                                                            if ((this.MaleFaceTotalNum == null) ||
                                                               (lVar10 = *(int64 *)
                                                                          (this.MaleFaceTotalNum
                                                                          + 16), lVar10 == null))
                                                            goto LAB_180c27762;
                                                            iVar23 = FUN_1800d6760(lVar10,iVar5,
                                                                                   DAT_181d8fa18);
                                                            if (iVar23 <= iVar21) break;
                                                            lVar10 = *(int64 *)
                                                                      (pStatics
                                                                      + 0x650);
                                                            if ((lVar10 == null) ||
                                                               (lVar10 = FUN_180002f80(lVar10,iVar5,
                                                                                       DAT_181d789a8),
                                                               lVar10 == null)) goto LAB_180c27762;
                                                            cVar3 = FUN_18182a3a0(lVar10,iVar21,
                                                                                  DAT_181d8f398);
                                                            if (!cVar3) {
                                                              if ((this.MaleFaceRandomID == null) ||
                                                                 (lVar10 = FUN_180002f80(*(int64 *)
                                                                                          (this + 0x168
                                                                                          ),iVar5,
                                                        DAT_181d789a8), lVar10 == null)) goto LAB_180c27762;
                                                        FUN_18182a0b0(lVar10,iVar21,DAT_181d8f218);
                                                        }
                                                        iVar21 = iVar21 + 1;
                                                        }
                                                        lVar10 = this.FemaleFaceRandomID;
                                                        uVar8 = il2cpp_internal(DAT_181d93cd0);
                                                        FUN_18132faf0(uVar8,DAT_181d8f098);
                                                        if (lVar10 == null) goto LAB_180c27762;
                                                        FUN_18181e0a0(lVar10,uVar8,DAT_181d78828);
                                                        iVar21 = 0;
                                                        while( true ) {
                                                          if ((this.FemaleFaceTotalNum == null) ||
                                                             (lVar10 = *(int64 *)
                                                                        (this.FemaleFaceTotalNum +
                                                                        16), lVar10 == null))
                                                          goto LAB_180c27762;
                                                          iVar23 = FUN_1800d6760(lVar10,iVar5,
                                                                                 DAT_181d8fa18);
                                                          uVar8 = DAT_181dc2db8;
                                                          if (iVar23 <= iVar21) break;
                                                          lVar10 = *(int64 *)
                                                                    (pStatics +
                                                                    0x658);
                                                          if ((lVar10 == null) ||
                                                             (lVar10 = FUN_180002f80(lVar10,iVar5,
                                                                                     DAT_181d789a8),
                                                             lVar10 == null)) goto LAB_180c27762;
                                                          cVar3 = FUN_18182a3a0(lVar10,iVar21,
                                                                                DAT_181d8f398);
                                                          if (!cVar3) {
                                                            if ((this.FemaleFaceRandomID == null) ||
                                                               (lVar10 = FUN_180002f80(*(int64 *)
                                                                                        (this + 0x170),
                                                                                       iVar5,DAT_181d789a8
                                                                                      ), lVar10 == null))
                                                            goto LAB_180c27762;
                                                            FUN_18182a0b0(lVar10,iVar21,DAT_181d8f218);
                                                          }
                                                          iVar21 = iVar21 + 1;
                                                        }
                                                        iVar5 = iVar5 + 1;
                                                        } while (iVar5 < 6);
                                                        uVar8 = Type.GetTypeFromHandle(uVar8,0);
                                                        uVar8 = Resources.Load("GameData/BookTypeIconData",uVar8,0);
                                                        lVar10 = FUN_1800020c0(uVar8,DAT_181daab10);
                                                        if (lVar10 != null) {
                                                          uVar8 = FUN_1800020c0(uVar8,DAT_181daab10);
                                                          uVar8 = FUN_180da4db0(uVar8,0);
                                                          lVar10 = new c.DisplayClass9_0(0);
                                                          if (lVar10 != null) {
                                                            LTCSVLoader.ReadMultiLine(lVar10,uVar8,0);
                                                            iVar5 = LTCSVLoader.GetRow(lVar10,0);
                                                            iVar21 = 1;
                                                            if (1 < iVar5) {
                                                              do {
                                                                lVar11 = il2cpp_internal(DAT_181db28a8
                                                                                            );
                                                                c__DisplayClass9_0.ctor(lVar11,0);
                                                                lVar12 = LTCSVLoader.GetValueAt
                                                                                   (lVar10,0,iVar21,0);
                                                                if (lVar12 == null) goto LAB_180c27762;
                                                                cVar3 = String.Contains(lVar12,
                                                        "_",0);
                                                        if (!cVar3) {
                                                          uVar8 = LTCSVLoader.GetValueAt
                                                                            (lVar10,0,iVar21,0);
                                                          uVar24 = Int32.Parse(uVar8,0);
                                                          if (lVar11 == null) goto LAB_180c27762;
                                                          lVar11._items = uVar24;
                                                        }
                                                        else {
                                                          lVar12 = LTCSVLoader.GetValueAt
                                                                             (lVar10,0,iVar21,0);
                                                          lVar13 = FUN_1800d60b0(DAT_181da1040,1);
                                                          if (((lVar13 == null) ||
                                                              (FUN_1800048e0(lVar13,0,95), lVar12 == null))
                                                             || (lVar12 = String.Split(lVar12,lVar13,0),
                                                                lVar12 == null)) goto LAB_180c27762;
                                                          uVar8 = FUN_1800021a0(lVar12,0);
                                                          uVar24 = Int32.Parse(uVar8,0);
                                                          if (lVar11 == null) goto LAB_180c27762;
                                                          lVar11._items = uVar24;
                                                          uVar8 = FUN_1800021a0(lVar12,1);
                                                          uVar24 = Int32.Parse(uVar8,0);
                                                          *(uint32 *)(lVar11 + 20) = uVar24;
                                                        }
                                                        uVar8 = LTCSVLoader.GetValueAt(lVar10,1,iVar21);
                                                        cVar3 = FUN_18171e540(uVar8,"黑",0);
                                                        if (!cVar3) {
                                                          uVar8 = LTCSVLoader.GetValueAt(lVar10,1,iVar21)
                                                          ;
                                                          uVar8 = String.Concat("#",uVar8,0);
                                                          ColorUtility.TryParseHtmlString
                                                                    (uVar8,lVar11 + 36,0);
                                                        }
                                                        else {
                                                          *(uint8 *)(lVar11 + 32) = 1;
                                                        }
                                                        uVar8 = LTCSVLoader.GetValueAt(lVar10,2,iVar21);
                                                        uVar8 = GlobalData.LoadVector2(uVar8,0);
                                                        local_res18 = (int)uVar8;
                                                        lVar11.Count = local_res18;
                                                        uStackX_1c = (uint32)
                                                                     ((uint64)uVar8 >> 32);
                                                        lVar11._version = uStackX_1c;
                                                        if (this.bookTypeIconDataBase == null)
                                                        goto LAB_180c27762;
                                                        FUN_18181e0a0(this.bookTypeIconDataBase,
                                                                      lVar11,DAT_181d801a0);
                                                        iVar21 = iVar21 + 1;
                                                        } while (iVar21 < iVar5);
                                                        }
                                                        uVar8 = DAT_181dc2db8;
                                                        if (**(int **)(DAT_181d73d40 + 184) == 2) {
                                                          uVar8 = Type.GetTypeFromHandle(uVar8,0);
                                                          uVar8 = Resources.Load("GameData/CheckReplaceSkillIconList",uVar8,0);
                                                          lVar10 = FUN_1800020c0(uVar8,DAT_181daab10);
                                                          if (lVar10 == null) goto LAB_180c27762;
                                                          uVar8 = FUN_1800020c0(uVar8,DAT_181daab10);
                                                          uVar8 = FUN_180da4db0(uVar8,0);
                                                          lVar10 = new c.DisplayClass9_0(0);
                                                          if (lVar10 == null) goto LAB_180c27762;
                                                          LTCSVLoader.ReadMultiLine(lVar10,uVar8,0);
                                                          iVar5 = LTCSVLoader.GetRow(lVar10,0);
                                                          uVar8 = il2cpp_internal(DAT_181d90160);
                                                          FUN_18132faf0(uVar8,DAT_181d787a8);
                                                          this.CheckReplaceSkillIconList = uVar8;
                                                          iVar21 = 1;
                                                          if (1 < iVar5) {
                                                            do {
                                                              lVar11 = this.CheckReplaceSkillIconList;
                                                              uVar8 = il2cpp_internal(DAT_181d93cd0);
                                                              FUN_18132faf0(uVar8,DAT_181d8f098);
                                                              if (lVar11 == null) goto LAB_180c27762;
                                                              FUN_18181e0a0(lVar11,uVar8,DAT_181d78828);
                                                              lVar11 = this.CheckReplaceSkillIconList;
                                                              if (lVar11 == null) goto LAB_180c27762;
                                                              lVar11 = FUN_18020f010(lVar11,*(int *)(
                                                        lVar11 + 24) + -1,DAT_181d789a8);
                                                        uVar8 = LTCSVLoader.GetValueAt(lVar10,0,iVar21,0)
                                                        ;
                                                        uVar24 = GameDataController.GetSkillID
                                                                           (this,uVar8,0);
                                                        if (lVar11 == null) goto LAB_180c27762;
                                                        FUN_18182a0b0(lVar11,uVar24,DAT_181d8f218);
                                                        lVar11 = this.CheckReplaceSkillIconList;
                                                        if (lVar11 == null) goto LAB_180c27762;
                                                        lVar11 = FUN_18020f010(lVar11,*(int *)(lVar11 + 
                                                        24) + -1,DAT_181d789a8);
                                                        uVar8 = LTCSVLoader.GetValueAt(lVar10,1,iVar21);
                                                        uVar24 = GameDataController.GetSkillID
                                                                           (this,uVar8,0);
                                                        if (lVar11 == null) goto LAB_180c27762;
                                                        FUN_18182a0b0(lVar11,uVar24,DAT_181d8f218);
                                                        iVar21 = iVar21 + 1;
                                                        } while (iVar21 < iVar5);
                                                        }
                                                        }
                                                        uVar8 = DAT_181dc2db8;
                                                        uVar8 = Type.GetTypeFromHandle(uVar8,0);
                                                        uVar8 = Resources.Load("GameData/AchievementData",uVar8,0);
                                                        lVar10 = FUN_1800020c0(uVar8,DAT_181daab10);
                                                        if (lVar10 != null) {
                                                          uVar8 = FUN_1800020c0(uVar8,DAT_181daab10);
                                                          uVar8 = FUN_180da4db0(uVar8,0);
                                                          lVar10 = new c.DisplayClass9_0(0);
                                                          if (lVar10 != null) {
                                                            LTCSVLoader.ReadMultiLine(lVar10,uVar8,0);
                                                            iVar5 = LTCSVLoader.GetRow(lVar10,0);
                                                            iVar21 = 1;
                                                            if (1 < iVar5) {
                                                              do {
                                                                lVar11 = il2cpp_internal(DAT_181daa6e0
                                                                                            );
                                                                c__DisplayClass9_0.ctor(lVar11,0);
                                                                uVar8 = LTCSVLoader.GetValueAt
                                                                                  (lVar10,1,iVar21);
                                                                if (lVar11 == null) goto LAB_180c27762;
                                                                lVar11._items = uVar8;
                                                                il2cpp_internal((uint64 *)
                                                                                    (lVar11 + 16),uVar8)
                                                                ;
                                                                uVar8 = LTCSVLoader.GetValueAt
                                                                                  (lVar10,2,iVar21);
                                                                lVar11.Count = uVar8;
                                                                il2cpp_internal((uint64 *)
                                                                                    (lVar11 + 24),uVar8)
                                                                ;
                                                                lVar12 = LTCSVLoader.GetValueAt
                                                                                   (lVar10,3,iVar21);
                                                                if (lVar12 != null) {
                                                                  cVar3 = FUN_18171e540(lVar12,
                                                        "int",0);
                                                        if (!cVar3) {
                                                          cVar3 = FUN_18171e540(lVar12,"float",0);
                                                          if (!cVar3) {
                                                            cVar3 = FUN_18171e540(lVar12,"bool",0);
                                                            if (cVar3) {
                                                              *(uint32 *)(lVar11 + 32) = 2;
                                                            }
                                                          }
                                                          else {
                                                            *(uint32 *)(lVar11 + 32) = 0;
                                                          }
                                                        }
                                                        else {
                                                          *(uint32 *)(lVar11 + 32) = 1;
                                                        }
                                                        }
                                                        uVar8 = LTCSVLoader.GetValueAt(lVar10,4,iVar21);
                                                        uVar14 = CultureInfo.get_InvariantCulture(0);
                                                        uVar24 = Single.Parse(uVar8,uVar14,0);
                                                        *(uint32 *)(lVar11 + 36) = uVar24;
                                                        uVar8 = LTCSVLoader.GetValueAt(lVar10,5,iVar21);
                                                        cVar3 = FUN_18171e540(uVar8,"无",0);
                                                        uVar8 = "";
                                                        if (!cVar3) {
                                                          uVar8 = LTCSVLoader.GetValueAt(lVar10,5,iVar21)
                                                          ;
                                                        }
                                                        *(uint64 *)(lVar11 + 40) = uVar8;
                                                        il2cpp_internal((uint64 *)(lVar11 + 40),
                                                                            uVar8);
                                                        if (this.AchievementData == null)
                                                        goto LAB_180c27762;
                                                        FUN_18181e0a0(this.AchievementData,
                                                                      lVar11,DAT_181d7b088);
                                                        iVar21 = iVar21 + 1;
                                                        } while (iVar21 < iVar5);
                                                        }
                                                        uVar8 = DAT_181dc2db8;
                                                        uVar8 = Type.GetTypeFromHandle(uVar8,0);
                                                        uVar8 = Resources.Load("GameData/TipsData",uVar8,0);
                                                        lVar10 = FUN_1800020c0(uVar8,DAT_181daab10);
                                                        if (lVar10 != null) {
                                                          uVar8 = FUN_1800020c0(uVar8,DAT_181daab10);
                                                          uVar8 = FUN_180da4db0(uVar8,0);
                                                          lVar10 = new c.DisplayClass9_0(0);
                                                          if (lVar10 != null) {
                                                            LTCSVLoader.ReadMultiLine(lVar10,uVar8,0);
                                                            iVar5 = LTCSVLoader.GetRow(lVar10,0);
                                                            iVar21 = 1;
                                                            if (1 < iVar5) {
                                                              do {
                                                                lVar11 = this.tipsData;
                                                                lVar12 = LTCSVLoader.GetValueAt
                                                                                   (lVar10,0,iVar21,0);
                                                                if ((lVar12 == null) ||
                                                                   (uVar8 = String.Replace(lVar12,
                                                        "\\n","\n"), lVar11 == null))
                                                        goto LAB_180c27762;
                                                        FUN_18181e0a0(lVar11,uVar8,DAT_181da3d58);
                                                        iVar21 = iVar21 + 1;
                                                        } while (iVar21 < iVar5);
                                                        }
                                                        uVar8 = DAT_181dc2db8;
                                                        uVar8 = Type.GetTypeFromHandle(uVar8,0);
                                                        uVar8 = Resources.Load("GameData/LoveableSpeHero",uVar8,0);
                                                        lVar10 = FUN_1800020c0(uVar8,DAT_181daab10);
                                                        if (lVar10 != null) {
                                                          uVar8 = FUN_1800020c0(uVar8,DAT_181daab10);
                                                          uVar8 = FUN_180da4db0(uVar8,0);
                                                          lVar10 = new c.DisplayClass9_0(0);
                                                          if (lVar10 != null) {
                                                            LTCSVLoader.ReadMultiLine(lVar10,uVar8,0);
                                                            iVar5 = LTCSVLoader.GetRow(lVar10,0);
                                                            iVar21 = 1;
                                                            if (1 < iVar5) {
                                                              do {
                                                                lVar11 = this.loveableSpeHeroList;
                                                                uVar8 = LTCSVLoader.GetValueAt
                                                                                  (lVar10,0,iVar21,0);
                                                                if (lVar11 == null) goto LAB_180c27762;
                                                                FUN_18181e0a0(lVar11,uVar8,DAT_181da3d58);
                                                                iVar21 = iVar21 + 1;
                                                              } while (iVar21 < iVar5);
                                                            }
                                                            uVar8 = DAT_181dc2db8;
                                                            uVar8 = Type.GetTypeFromHandle(uVar8,0);
                                                            uVar8 = Resources.Load("GameData/MartialClubData",uVar8,0)
                                                            ;
                                                            lVar10 = FUN_1800020c0(uVar8,DAT_181daab10);
                                                            if (lVar10 != null) {
                                                              uVar8 = FUN_1800020c0(uVar8,DAT_181daab10);
                                                              uVar8 = FUN_180da4db0(uVar8,0);
                                                              lVar10 = new c.DisplayClass9_0(0);
                                                              if (lVar10 != null) {
                                                                LTCSVLoader.ReadMultiLine(lVar10,uVar8,0)
                                                                ;
                                                                iVar5 = LTCSVLoader.GetRow(lVar10,0);
                                                                iVar21 = 1;
                                                                if (1 < iVar5) {
                                                                  do {
                                                                    lVar11 = il2cpp_internal(
                                                        DAT_181d88098);
                                                        MartialClubDataBase.ctor(lVar11,0);
                                                        uVar8 = LTCSVLoader.GetValueAt(lVar10,0,iVar21,0)
                                                        ;
                                                        if (lVar11 == null) goto LAB_180c27762;
                                                        lVar11.Count = uVar8;
                                                        il2cpp_internal((uint64 *)(lVar11 + 24),
                                                                            uVar8);
                                                        uVar8 = LTCSVLoader.GetValueAt(lVar10,1,iVar21);
                                                        *(uint64 *)(lVar11 + 32) = uVar8;
                                                        il2cpp_internal((uint64 *)(lVar11 + 32),
                                                                            uVar8);
                                                        lVar12 = LTCSVLoader.GetValueAt(lVar10,2,iVar21);
                                                        lVar13 = FUN_1800d60b0(DAT_181da1040,1);
                                                        if (lVar13 == null) goto LAB_180c27762;
                                                        if (*(int *)(lVar13 + 24) == 0) {
                                                          uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                          FUN_1800d65f0(uVar8,0);
                                                        }
                                                        *(uint16 *)(lVar13 + 32) = 59;
                                                        if (lVar12 == null) goto LAB_180c27762;
                                                        lVar12 = String.Split(lVar12,lVar13,0);
                                                        iVar23 = 0;
                                                        while( true ) {
                                                          if (lVar12 == null) goto LAB_180c27762;
                                                          if (lVar12.entries <= iVar23) break;
                                                          lVar13 = *(int64 *)(lVar11 + 40);
                                                          uVar8 = FUN_1800021a0(lVar12,(int64)iVar23);
                                                          uVar24 = Int32.Parse(uVar8,0);
                                                          if (lVar13 == null) goto LAB_180c27762;
                                                          FUN_18182a0b0(lVar13,uVar24,DAT_181d8f218);
                                                          iVar23 = iVar23 + 1;
                                                        }
                                                        if (this.martialclubDataBase == null)
                                                        goto LAB_180c27762;
                                                        FUN_18181e0a0(this.martialclubDataBase,
                                                                      lVar11,DAT_181d93888);
                                                        iVar21 = iVar21 + 1;
                                                        } while (iVar21 < iVar5);
                                                        }
                                                        GameDataController.LoadPeotryData(this,0);
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
        LAB_180c27762:
                          // WARNING: Subroutine does not return
        FUN_1800d6620();
        LAB_180c266cf:
        local_res18 = local_res18 + 1;
        lVar11 = local_f8;
        goto LAB_180c25b30;
    }

    // Token : 0x6001671
    // RVA   : 0xC194F0   Offset: 0xC188F0   Length: 0x486
    public void ChangeAchStats(int achID, float changeNum)
    {
        var pStatics_2cc8 = *(int64*)(DAT_181d72cc8 + 184);
        var pStatics_2d50 = *(int64*)(DAT_181d72d50 + 184);
        long lVar1;
        bool cVar2;
        int iVar3;
        ulong uVar4;
        ulong uVar5;
        long lVar6;
        float fVar7;
        uint[] local_res10 = new uint[2];
        local_res10[0] = achID;
        if ((*pStatics_2cc8 != 0) &&
           (lVar1 = *(int64 *)(*pStatics_2cc8 + 32)) != null) {
          if (*(char *)(lVar1 + 164) != false) {
            return;
          }
          if (*(int *)(*(int64 *)(DAT_181d73d40 + 184) + 12) != 0) {
            if ((*pStatics_2cc8 == 0) ||
               (lVar1 = *(int64 *)(*pStatics_2cc8 + 32)) == null)
            throw; // [null/range check failed]
            if (*(char *)(lVar1 + 153) != false) {
              return;
            }
          }
          if (((*pStatics_2cc8 != 0) &&
              (lVar1 = *(int64 *)(*pStatics_2cc8 + 32)) != null) &&
             (lVar1 = *(int64 *)(lVar1 + 0x260)) != null) {
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
                if (*(int *)(lVar1 + 32) == 0) {
                  lVar1 = *(int64 *)(pStatics_2d50 + 8);
                  if (lVar1 != null) {
                    lVar1 = lVar1._items;
                    uVar4 = Int32.ToString(local_res10,0);
                    uVar4 = String.Concat("AchData",uVar4,0);
                    lVar6 = *(int64 *)(pStatics_2d50 + 8);
                    if (lVar6 != null) {
                      lVar6 = *(int64 *)(lVar6 + 16);
                      uVar5 = Int32.ToString(local_res10,0);
                      uVar5 = String.Concat("AchData",uVar5,0);
                      if ((lVar6 != null) &&
                         (fVar7 = (float)PlayerPrefDictionary.GetFloat(lVar6,uVar5,0), lVar1 != null)) {
                        PlayerPrefDictionary.SetKey(lVar1,uVar4,fVar7 + changeNum,0);
                        goto LAB_180c19948;
                      }
                    }
                  }
                }
                else {
                  lVar1 = *(int64 *)(pStatics_2d50 + 8);
                  if (lVar1 != null) {
                    lVar1 = lVar1._items;
                    uVar4 = Int32.ToString(local_res10,0);
                    uVar4 = String.Concat("AchData",uVar4,0);
                    lVar6 = *(int64 *)(pStatics_2d50 + 8);
                    if (lVar6 != null) {
                      lVar6 = *(int64 *)(lVar6 + 16);
                      uVar5 = Int32.ToString(local_res10,0);
                      uVar5 = String.Concat("AchData",uVar5,0);
                      if ((lVar6 != null) &&
                         (iVar3 = PlayerPrefDictionary.GetInt(lVar6,uVar5,0), lVar1 != null)) {
                        PlayerPrefDictionary.SetKey(lVar1,uVar4,(int)((float)iVar3 + changeNum),0);
        LAB_180c19948:
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

    // Token : 0x6001672
    // RVA   : 0xC19980   Offset: 0xC18D80   Length: 0x43C
    public void CheckAch(int achID)
    {
        var pStatics = *(int64*)(DAT_181d72d50 + 184);
        bool cVar1;
        int iVar2;
        ulong uVar3;
        long lVar4;
        long lVar5;
        float fVar6;
        uint[] local_res10 = new uint[2];
        local_res10[0] = achID;
        if (**(int **)(DAT_181d73d40 + 184) == 0) {
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
        if (**(int **)(DAT_181d73d40 + 184) == 1) {
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
        if (**(int **)(DAT_181d73d40 + 184) == 1) {
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
              lVar4 = *(int64 *)(pStatics + 8);
              if (lVar4 != null) {
                lVar4 = lVar4._items;
                uVar3 = Int32.ToString(local_res10,0);
                uVar3 = String.Concat("AchData",uVar3,0);
                if (lVar4 != null) {
                  iVar2 = PlayerPrefDictionary.GetInt(lVar4,uVar3,0);
                  if ((float)iVar2 == 0.0) {
                    return;
                  }
        LAB_180c19d0b:
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
                    lVar4 = *(int64 *)(pStatics + 8);
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
                      lVar4 = *(int64 *)(pStatics + 8);
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
                      goto LAB_180c19d0b;
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6001673
    // RVA   : 0xC2BE90   Offset: 0xC2B290   Length: 0x129
    public void UnlockAchievement(int achID)
    {
        ulong uVar1;
        long lVar2;
        uint[] local_res10 = new uint[6];
        local_res10[0] = achID;
        if (**(int **)(DAT_181d73d40 + 184) == 0) {
          lVar2 = SteamStatsAndAchievements.get_Instance(0);
          if (lVar2 != null) {
            SteamStatsAndAchievements.UnlockAchievement(lVar2,local_res10[0],0);
            return;
          }
        }
        else {
          lVar2 = *(int64 *)(*(int64 *)(DAT_181d72d50 + 184) + 8);
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

    // Token : 0x6001674
    // RVA   : 0xC19DC0   Offset: 0xC191C0   Length: 0x3AD
    public void CheckAllAch()
    {
        var pStatics = *(int64*)(DAT_181d72d50 + 184);
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
          lVar1 = *(int64 *)(pStatics + 8);
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
          lVar1 = *(int64 *)(pStatics + 8);
          if (lVar1 == null) break;
          lVar1 = lVar1._items;
          uVar4 = Int32.ToString(local_res8,0);
          uVar4 = String.Concat("AchFinished",uVar4,0);
          if (lVar1 == null) break;
          uVar4 = PlayerPrefDictionary.GetString(lVar1,uVar4);
          cVar2 = FUN_18171e540(uVar4);
          if (cVar2) {
            lVar1 = *(int64 *)(pStatics + 8);
            if (lVar1 == null) break;
            lVar1 = lVar1._items;
            uVar4 = Int32.ToString(local_res8,0);
            uVar4 = String.Concat("AchRewarded",uVar4,0);
            if (lVar1 == null) break;
            cVar2 = PlayerPrefDictionary.ContainsKey(lVar1,uVar4);
            if (cVar2) {
              lVar1 = *(int64 *)(pStatics + 8);
              if (lVar1 == null) break;
              lVar1 = lVar1._items;
              uVar4 = Int32.ToString(local_res8,0);
              uVar4 = String.Concat("AchRewarded",uVar4,0);
              if (lVar1 == null) break;
              uVar4 = PlayerPrefDictionary.GetString(lVar1,uVar4);
              cVar2 = String.op_Inequality(uVar4);
              if (!cVar2) goto LAB_180c1a142;
            }

            if ((lVar1 = *(int64 *)(pStatics + 8)?._items) == null) break;
            iVar3 = PlayerPrefDictionary.GetInt(lVar1,"AchTagPoint",0);
            PlayerPrefDictionary.SetKey(lVar1,"AchTagPoint",iVar3 + 2,0);
            lVar1 = *(int64 *)(pStatics + 8);
            if (lVar1 == null) break;
            lVar1 = lVar1._items;
            uVar4 = Int32.ToString(local_res8,0);
            String.Concat("AchRewarded",uVar4,0);
            if (lVar1 == null) break;
            PlayerPrefDictionary.SetKey(lVar1);
          }
        LAB_180c1a142:
          local_res8[0] = local_res8[0] + 1;
          lVar1 = this.AchievementData;
        }
    }

    // Token : 0x6001675
    // RVA   : 0xC2C350   Offset: 0xC2B750   Length: 0x699
    public void WriteGameDataCsv()
    {
        var pStatics = *(int64*)(DAT_181d72cc8 + 184);
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
          plVar4 = (int64 *)il2cpp_internal(DAT_181dc73f8);
          FileStream.ctor(plVar4,uVar2,2,2,0);
          uVar2 = Encoding.get_UTF8(0);
          plVar5 = (int64 *)il2cpp_internal(DAT_181da7590);
          StreamWriter.ctor(plVar5,plVar4,uVar2,0);
          while( true ) {
            if (*pStatics == 0) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar3 = *(int64 *)(*pStatics + 32);
            if (lVar3 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar3 = *(int64 *)(lVar3 + 56);
            if (lVar3 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            if (*(int *)(lVar3 + 24) <= iVar10) {
              if (plVar5 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              (**(code **)(*plVar5 + 0x1b8))(plVar5,*(uint64 *)(*plVar5 + 0x1c0));
              if (plVar4 != (int64 *)0) {
                (**(code **)(*plVar4 + 0x238))(plVar4,*(uint64 *)(*plVar4 + 0x240));
                FUN_180002970(0,DAT_181d78da0,plVar5);
                if (plVar4 != (int64 *)0) {
                  FUN_180002970(0,DAT_181d78da0,plVar4);
                }
                return;
              }
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar3 = FUN_18046c0a0(0);
            if (lVar3 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            if (*(int64 *)(lVar3 + 32) == 0) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar3 = *(int64 *)(*(int64 *)(lVar3 + 32) + 56);
            if (lVar3 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar3 = FUN_180002f80(lVar3,iVar10,DAT_181d8ec98);
            if (lVar3 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            uVar2 = *(uint64 *)(lVar3 + 24);
            lVar3 = FUN_18046bbe0(0);
            if (lVar3 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            if (*(int64 *)(lVar3 + 64) == 0) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar3 = GameObject.get_transform(*(int64 *)(lVar3 + 64),0);
            if (lVar3 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar3 = Transform.Find(lVar3,"Inn",0);
            lVar6 = FUN_18046c0a0(0);
            if (lVar6 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            if (*(int64 *)(lVar6 + 32) == 0) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar6 = *(int64 *)(*(int64 *)(lVar6 + 32) + 56);
            if (lVar6 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar6 = FUN_180002f80(lVar6,iVar10,DAT_181d8ec98);
            if (lVar6 == null) break;
            uVar7 = Int32.ToString(lVar6 + 16,0);
            uVar7 = String.Concat("InnIcon",uVar7,0);
            if (lVar3 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar3 = Transform.Find(lVar3,uVar7,0);
            if (lVar3 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            puVar8 = (uint32 *)Transform.get_localPosition(local_50,lVar3,0);
            local_res18[0] = *puVar8;
            uVar7 = il2cpp_value_box(DAT_181da22d8,local_res18);
            lVar3 = FUN_18046bbe0(0);
            if (lVar3 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            if (*(int64 *)(lVar3 + 64) == 0) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar3 = GameObject.get_transform(*(int64 *)(lVar3 + 64),0);
            if (lVar3 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar3 = Transform.Find(lVar3,"Inn",0);
            lVar6 = FUN_18046c0a0(0);
            if (lVar6 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            if (*(int64 *)(lVar6 + 32) == 0) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar6 = *(int64 *)(*(int64 *)(lVar6 + 32) + 56);
            if (lVar6 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar6 = FUN_180002f80(lVar6,iVar10,DAT_181d8ec98);
            if (lVar6 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            uVar9 = Int32.ToString(lVar6 + 16,0);
            uVar9 = String.Concat("InnIcon",uVar9,0);
            if (lVar3 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar3 = Transform.Find(lVar3,uVar9,0);
            if (lVar3 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar3 = Transform.get_localPosition(local_40,lVar3,0);
            local_res20[0] = *(uint32 *)(lVar3 + 4);
            uVar9 = il2cpp_value_box(DAT_181da22d8,local_res20);
            uVar2 = String.Format("{0},{1};{2}",uVar2,uVar7,uVar9,0);
            if (plVar5 == (int64 *)0) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            (**(code **)(*plVar5 + 0x278))(plVar5,uVar2,*(uint64 *)(*plVar5 + 0x280));
            iVar10 = iVar10 + 1;
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
    }

    // Token : 0x6001676
    // RVA   : 0xC1D060   Offset: 0xC1C460   Length: 0x320
    public int GetTagID(string tagName)
    {
        var pStatics = *(int64*)(DAT_181d72cc8 + 184);
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
          lVar2 = FUN_1808ae5b0(this.heroTagDataBase,DAT_181dba4a8);
          if (lVar2 != null) {
            ValueCollection.GetEnumerator(&local_38,lVar2,DAT_181d7e7e8);
            local_50 = local_38;
            uStack_4c = uStack_34;
            uStack_48 = uStack_30;
            uStack_44 = uStack_2c;
            local_40 = local_28;
            do {
              cVar1 = FUN_1811c3f80(&local_50,DAT_181d988d8);
              lVar2 = local_40;
              if (!cVar1) {
                aiStack_64[1] = 75;
                iVar5 = aiStack_64[3] + 1;
                aiStack_64[3] = iVar5;
                ZhSegment.Initialize(&local_50,DAT_181d98858);
                goto LAB_180c1d217;
              }
              if (local_40 == 0) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              cVar1 = FUN_18171e540(*(uint64 *)(local_40 + 24),tagName,0);
            } while (!cVar1);
            iVar4 = *(int *)(lVar2 + 16);
            aiStack_64[1] = 150;
            iVar5 = aiStack_64[3] + 1;
            aiStack_64[3] = iVar5;
            ZhSegment.Initialize(&local_50,DAT_181d98858);
        LAB_180c1d217:
            iVar3 = 0;
            if ((iVar5 != 0) && (iVar3 = 0, aiStack_64[iVar5] == 150)) {
              return iVar4;
            }
            while( true ) {
              if (((*pStatics == 0) ||
                  (lVar2 = *(int64 *)(*pStatics + 32)) == null) ||
                 (lVar2 = *(int64 *)(lVar2 + 0x1e0)) == null) break;
              if (*(int *)(lVar2 + 24) <= iVar3) {
                return -1;
              }
              lVar2 = FUN_18046c0a0(0);
              if (((lVar2 == null) || (*(int64 *)(lVar2 + 32) == 0)) ||
                 (lVar2 = *(int64 *)(*(int64 *)(lVar2 + 32) + 0x1e0)) == null) break;
              lVar2 = FUN_180002f80(lVar2,iVar3,DAT_181d8c918);
              if (lVar2 == null) break;
              cVar1 = FUN_18171e540(*(uint64 *)(lVar2 + 24),tagName,0);
              if (cVar1) {
                return iVar3 + 10000;
              }
              iVar3 = iVar3 + 1;
            }
          }
        }
    }

    // Token : 0x6001677
    // RVA   : 0xC28A10   Offset: 0xC27E10   Length: 0x186C
    public KungfuSkillData LoadSkillData(LTCSVLoader loader, int i, bool _summonSkill)
    {
        var pStatics = *(int64*)(DAT_181d73d40 + 184);
        int64 GameDataController.LoadSkillData
                         (int64 this,int64 loader,uint32 i,uint8 _summonSkill)
        {
        uint64 uVar1;
        char cVar2;
        uint8 uVar3;
        uint32 uVar4;
        uint32 uVar5;
        uint32 uVar6;
        int iVar7;
        int64 lVar8;
        uint64 uVar9;
        uint64 uVar10;
        int64 lVar11;
        int64 *plVar12;
        uint32 *puVar13;
        int64 lVar14;
        int64 *plVar15;
        uint32 *puVar16;
        uint32 uVar17;
        int64 lVar18;
        float fVar19;
        uint64 in_stack_ffffffffffffffa8;
        uint64 uVar20;
        var lVar8 = new KungfuSkillData(0);
        if ((lVar8 == null) || (*(uint8 *)(lVar8 + 16) = _summonSkill, loader == null)) goto LAB_180c2a112;
        uVar9 = LTCSVLoader.GetValueAt(loader,0,i,0);
        uVar4 = Int32.Parse(uVar9,0);
        *(uint32 *)(lVar8 + 20) = uVar4;
        lVar18 = *(int64 *)(pStatics + 0x4a0);
        uVar9 = LTCSVLoader.GetValueAt(loader,1,i);
        if (lVar18 == null) goto LAB_180c2a112;
        uVar4 = FUN_1817eb4e0(lVar18,uVar9,DAT_181da3fd8);
        *(uint32 *)(lVar8 + 48) = uVar4;
        uVar9 = LTCSVLoader.GetValueAt(loader,2,i);
        uVar4 = Int32.Parse(uVar9,0);
        *(uint32 *)(lVar8 + 52) = uVar4;
        uVar9 = LTCSVLoader.GetValueAt(loader,3,i);
        *(uint64 *)(lVar8 + 32) = uVar9;
        uVar9 = LTCSVLoader.GetValueAt(loader,4,i);
        *(uint64 *)(lVar8 + 40) = uVar9;
        uVar9 = LTCSVLoader.GetValueAt(loader,5,i);
        Single.TryParse(uVar9,lVar8 + 60,0);
        uVar9 = LTCSVLoader.GetValueAt(loader,6,i);
        uVar4 = Single.Parse(uVar9,0);
        *(uint32 *)(lVar8 + 64) = uVar4;
        uVar9 = LTCSVLoader.GetValueAt(loader,7,i);
        cVar2 = String.op_Inequality(uVar9,"",0);
        if (!cVar2) {
          var uVar9 = new HeroSpeAddData(0);
        }
        else {
          uVar9 = LTCSVLoader.GetValueAt(loader,7,i);
          uVar9 = GameDataController.StringToSpeAddData(this,uVar9,0);
        }
        *(uint64 *)(lVar8 + 88) = uVar9;
        uVar9 = LTCSVLoader.GetValueAt(loader,8,i);
        cVar2 = String.op_Inequality(uVar9,"",0);
        if (!cVar2) {
          var uVar9 = new HeroSpeAddData(0);
          *(uint64 *)(lVar8 + 96) = uVar9;
        }
        else {
          uVar9 = LTCSVLoader.GetValueAt(loader,8,i);
          uVar9 = GameDataController.StringToSpeAddData(this,uVar9,0);
          *(uint64 *)(lVar8 + 96) = uVar9;
          if (*(int64 *)(lVar8 + 96) == 0) goto LAB_180c2a112;
          fVar19 = (float)HeroSpeAddData.Get(*(int64 *)(lVar8 + 96),59,0);
          if (fVar19 != 0.0) {
            lVar18 = *(int64 *)(lVar8 + 96);
            if (lVar18 == null) goto LAB_180c2a112;
            HeroSpeAddData.Get(lVar18,59,0);
            HeroSpeAddData.Set(lVar18,59);
          }
        }
        uVar9 = LTCSVLoader.GetValueAt(loader,9,i);
        cVar2 = String.op_Inequality(uVar9,"",0);
        uVar9 = 0;
        if (cVar2) {
          uVar9 = LTCSVLoader.GetValueAt(loader,9,i);
          uVar9 = GameDataController.StringToAttriRatio(this,uVar9,0);
        }
        *(uint64 *)(lVar8 + 72) = uVar9;
        uVar9 = LTCSVLoader.GetValueAt(loader,10,i);
        cVar2 = String.op_Inequality(uVar9,"",0);
        if (!cVar2) {
          *(uint64 *)(lVar8 + 80) = 0;
        }
        else {
          uVar9 = LTCSVLoader.GetValueAt(loader,10,i);
          cVar2 = FUN_18171e540(uVar9,"auto",0);
          if (!cVar2) {
            uVar9 = LTCSVLoader.GetValueAt(loader,10,i);
            uVar9 = GameDataController.StringToAttriRatio(this,uVar9,0);
            *(uint64 *)(lVar8 + 80) = uVar9;
          }
          else {
            var uVar9 = new AttriNumData(0);
            *(uint64 *)(lVar8 + 80) = uVar9;
            if (*(int64 *)(lVar8 + 80) == 0) goto LAB_180c2a112;
            lVar18 = *(int64 *)(*(int64 *)(lVar8 + 80) + 24);
            uVar4 = *(uint32 *)(lVar8 + 48);
            lVar11 = *(int64 *)(pStatics + 0x138);
            if (lVar11 == null) goto LAB_180c2a112;
            if (*(uint32 *)(lVar11 + 24) <= *(uint32 *)(lVar8 + 52)) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            if (lVar18 == null) goto LAB_180c2a112;
            FUN_181829d40(lVar18,uVar4);
          }
        }
        uVar9 = 0;
        if (*(int *)(lVar8 + 48) < 3) goto switchD_180c29361_caseD_7;
        uVar10 = LTCSVLoader.GetValueAt(loader,11,i);
        cVar2 = String.op_Inequality(uVar10,"",0);
        uVar10 = uVar9;
        if (cVar2) {
          uVar10 = LTCSVLoader.GetValueAt(loader,11,i);
          uVar10 = GameDataController.StringToAttackRange(this,uVar10,0);
        }
        *(uint64 *)(lVar8 + 112) = uVar10;
        uVar10 = LTCSVLoader.GetValueAt(loader,12,i);
        cVar2 = String.op_Inequality(uVar10,"",0);
        if (cVar2) {
          lVar18 = LTCSVLoader.GetValueAt(loader,12,i);
          lVar11 = FUN_1800d60b0(DAT_181da1040,1);
          if (lVar11 == null) goto LAB_180c2a112;
          if (*(int *)(lVar11 + 24) == 0) {
            uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar9,0);
          }
          *(uint16 *)(lVar11 + 32) = 44;
          if ((lVar18 == null) || (lVar18 = String.Split(lVar18,lVar11,0)) == null) goto LAB_180c2a112;
          if (lVar18.Count == null) {
            uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar9,0);
          }
          uVar4 = Int32.Parse(*(uint64 *)(lVar18 + 32),0);
          if (lVar18.Count < 2) {
            uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar9,0);
          }
          uVar5 = Int32.Parse(*(uint64 *)(lVar18 + 40),0);
          if (lVar18.Count < 3) {
            uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar9,0);
          }
          uVar6 = Int32.Parse(*(uint64 *)(lVar18 + 48),0);
          uVar9 = il2cpp_internal(DAT_181da3050);
          in_stack_ffffffffffffffa8 = 0;
          SkillDamageRangeData.ctor(uVar9,uVar4,uVar5,uVar6,0);
        }
        uVar17 = 0;
        *(uint64 *)(lVar8 + 120) = uVar9;
        if (*(int64 *)(lVar8 + 112) != 0) {
          lVar18 = 32;
          while (lVar11 = *(int64 *)(lVar8 + 112)) != null {
            if ((int)*(uint32 *)(lVar11 + 24) <= (int)uVar17) goto LAB_180c2933d;
            if (*(uint32 *)(lVar11 + 24) <= uVar17) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar11 = *(int64 *)(lVar18 + *(int64 *)(lVar11 + 16));
            if (lVar11 == null) break;
            iVar7 = *(int *)(lVar11 + 16);
            if (iVar7 == 0) {
        LAB_180c292c2:
              uVar4 = *(uint32 *)(lVar8 + 196);
              if ((*(int64 *)(lVar8 + 112) == 0) ||
                 (lVar11 = FUN_180002f80(*(int64 *)(lVar8 + 112),uVar17,DAT_181da2958)) == null)
              break;
              iVar7 = *(int *)(lVar11 + 24);
        LAB_180c292ef:
              uVar4 = Mathf.Max(uVar4,iVar7,0);
              *(uint32 *)(lVar8 + 196) = uVar4;
            }
            else {
              if (iVar7 == 1) {
        LAB_180c2930c:
                uVar4 = *(uint32 *)(lVar8 + 196);
                if ((*(int64 *)(lVar8 + 112) != 0) &&
                   (lVar11 = FUN_180002f80(*(int64 *)(lVar8 + 112),uVar17,DAT_181da2958)) != null
                   ) {
                  iVar7 = *(int *)(lVar11 + 24) * 2;
                  goto LAB_180c292ef;
                }
                break;
              }
              if (iVar7 == 2) goto LAB_180c292c2;
              if (iVar7 == 3) goto LAB_180c2930c;
              if (iVar7 == 4) goto LAB_180c292c2;
            }
            uVar17 = uVar17 + 1;
            lVar18 = lVar18 + 8;
          }
          goto LAB_180c2a112;
        }
        LAB_180c2933d:
        lVar18 = *(int64 *)(lVar8 + 120);
        if (lVar18 != null) {
          switch(lVar18._items) {
          case 0:
          case 2:
          case 4:
          case 5:
          case 8:
            iVar7 = lVar18.Count;
            break;
          case 1:
          case 3:
          case 6:
            iVar7 = lVar18.Count * 2;
            break;
          default:
            goto switchD_180c29361_caseD_7;
          }
          *(int *)(lVar8 + 196) = *(int *)(lVar8 + 196) + iVar7;
        }
        switchD_180c29361_caseD_7:
        uVar9 = LTCSVLoader.GetValueAt(loader,13,i);
        cVar2 = String.op_Inequality(uVar9,"",0);
        if (cVar2) {
          uVar9 = LTCSVLoader.GetValueAt(loader,13,i);
          uVar9 = GameDataController.StringToSpeAddData(this,uVar9,0);
          *(uint64 *)(lVar8 + 104) = uVar9;
        }
        uVar9 = LTCSVLoader.GetValueAt(loader,14,i);
        cVar2 = String.op_Inequality(uVar9,"",0);
        if (cVar2) {
          uVar9 = LTCSVLoader.GetValueAt(loader,14,i);
          uVar4 = Single.Parse(uVar9,0);
          *(uint32 *)(lVar8 + 56) = uVar4;
        }
        uVar9 = LTCSVLoader.GetValueAt(loader,15,i);
        uVar4 = Int32.Parse(uVar9,0);
        *(uint32 *)(lVar8 + 24) = uVar4;
        if (2 < *(int *)(lVar8 + 48)) {
          uVar9 = LTCSVLoader.GetValueAt(loader,16,i);
          uVar4 = Int32.Parse(uVar9,0);
          *(uint32 *)(lVar8 + 28) = uVar4;
          lVar18 = LTCSVLoader.GetValueAt(loader,17,i);
          if (lVar18 != null) {
            uVar9 = LTCSVLoader.GetValueAt(loader,17,i);
            cVar2 = String.op_Inequality(uVar9,"",0);
            if (cVar2) {
              uVar9 = LTCSVLoader.GetValueAt(loader,17,i);
              var uVar10 = new PartPostureData(uVar9,0);
              *(uint64 *)(lVar8 + 136) = uVar10;
            }
          }
          lVar18 = LTCSVLoader.GetValueAt(loader,18,i);
          if (lVar18 != null) {
            uVar9 = LTCSVLoader.GetValueAt(loader,18,i);
            cVar2 = String.op_Inequality(uVar9,"",0);
            if (cVar2) {
              uVar9 = LTCSVLoader.GetValueAt(loader,18,i);
              var uVar10 = new PartPostureData(uVar9,0);
              *(uint64 *)(lVar8 + 144) = uVar10;
            }
          }
          lVar18 = LTCSVLoader.GetValueAt(loader,19,i);
          if (lVar18 != null) {
            uVar9 = LTCSVLoader.GetValueAt(loader,19,i);
            cVar2 = String.op_Inequality(uVar9,"",0);
            if (cVar2) {
              uVar9 = LTCSVLoader.GetValueAt(loader,19,i);
              uVar4 = Int32.Parse(uVar9,0);
              *(uint32 *)(lVar8 + 128) = uVar4;
            }
          }
          lVar18 = LTCSVLoader.GetValueAt(loader,20,i);
          if (lVar18 != null) {
            uVar9 = LTCSVLoader.GetValueAt(loader,20,i);
            cVar2 = String.op_Inequality(uVar9,"",0);
            if (cVar2) {
              uVar9 = LTCSVLoader.GetValueAt(loader,20,i);
              uVar4 = Int32.Parse(uVar9,0);
              *(uint32 *)(lVar8 + 132) = uVar4;
            }
          }
          uVar9 = LTCSVLoader.GetValueAt(loader,21,i);
          *(uint64 *)(lVar8 + 160) = uVar9;
          lVar18 = LTCSVLoader.GetValueAt(loader,22,i);
          if (lVar18 == null) {
        LAB_180c299e8:
            *(uint64 *)(lVar8 + 168) = 0;
          }
          else {
            uVar9 = LTCSVLoader.GetValueAt(loader,22,i,0);
            cVar2 = String.op_Inequality(uVar9,"",0);
            if (!cVar2) goto LAB_180c299e8;
            lVar18 = LTCSVLoader.GetValueAt(loader,22,i,0);
            lVar11 = FUN_1800d60b0(DAT_181da1040,1);
            if (lVar11 == null) goto LAB_180c2a112;
            if (*(int *)(lVar11 + 24) == 0) {
              uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar9,0);
            }
            *(uint16 *)(lVar11 + 32) = 45;
            if (lVar18 == null) goto LAB_180c2a112;
            lVar11 = String.Split(lVar18,lVar11,0);
            lVar18 = this.SkillBulletDataBase;
            if (lVar11 == null) goto LAB_180c2a112;
            if (*(int *)(lVar11 + 24) == 0) {
              uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar9,0);
            }
            uVar17 = Int32.Parse(*(uint64 *)(lVar11 + 32),0);
            if (lVar18 == null) goto LAB_180c2a112;
            if (lVar18.Count <= uVar17) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar18 = lVar18._items[uVar17];
            if (lVar18 == null) goto LAB_180c2a112;
            plVar12 = (int64 *)SkillBulletData.Clone(lVar18,0);
            if (plVar12 != (int64 *)0) {
            }
            plVar15 = (int64 *)(lVar8 + 168);
            *plVar15 = (int64)plVar12;
            il2cpp_internal(plVar15);
            uVar17 = 1;
            while ((int)uVar17 < (int)*(uint32 *)(lVar11 + 24)) {
              if (*(uint32 *)(lVar11 + 24) <= uVar17) {
                uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar9,0);
              }
              cVar2 = FUN_180d755b0(lVar11[uVar17]);
              uVar10 = DAT_181dc12c0;
              uVar9 = DAT_181dc1238;
              if (!cVar2) {
                if (uVar17 == 1) {
                  lVar18 = *plVar15;
                  uVar9 = Type.GetTypeFromHandle(uVar9,0);
                  if (*(uint32 *)(lVar11 + 24) < 2) {
                    uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar9,0);
                  }
                  uVar10 = *(uint64 *)(lVar11 + 40);
                  plVar12 = (int64 *)Enum.Parse(uVar9,uVar10,0);
                  if ((lVar18 != null) && (plVar12 != (int64 *)0)) {
                    if (*(int64 *)(*plVar12 + 64) != *(int64 *)(DAT_181da2ed0 + 64)) {
                          // WARNING: Subroutine does not return
                      FUN_1800d6070(plVar12,DAT_181da2ed0);
                    }
                    puVar13 = (uint32 *)il2cpp_object_unbox();
                    lVar18.Count = *puVar13;
                    goto LAB_180c299e1;
                  }
                  goto LAB_180c2a112;
                }
                if (uVar17 == 2) {
                  lVar18 = *plVar15;
                  if (*(uint32 *)(lVar11 + 24) < 3) {
                    uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar9,0);
                  }
                  uVar4 = Single.Parse(*(uint64 *)(lVar11 + 48));
                  if (lVar18 == null) goto LAB_180c2a112;
                  lVar18._version = uVar4;
                  uVar17 = 3;
                }
                else if (uVar17 == 3) {
                  lVar18 = *plVar15;
                  uVar9 = Type.GetTypeFromHandle(uVar10,0);
                  if (*(uint32 *)(lVar11 + 24) < 4) {
                    uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar9,0);
                  }
                  uVar10 = *(uint64 *)(lVar11 + 56);
                  plVar12 = (int64 *)Enum.Parse(uVar9,uVar10,0);
                  if ((lVar18 == null) || (plVar12 == (int64 *)0)) goto LAB_180c2a112;
                  if (*(int64 *)(*plVar12 + 64) != *(int64 *)(DAT_181da2f50 + 64)) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6070(plVar12,DAT_181da2f50);
                  }
                  puVar13 = (uint32 *)il2cpp_object_unbox();
                  uVar17 = 4;
                  *(uint32 *)(lVar18 + 32) = *puVar13;
                }
                else if (uVar17 == 4) {
                  lVar18 = *plVar15;
                  if (*(uint32 *)(lVar11 + 24) < 5) {
                    uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar9,0);
                  }
                  uVar4 = Single.Parse(*(uint64 *)(lVar11 + 64));
                  if (lVar18 == null) goto LAB_180c2a112;
                  *(uint32 *)(lVar18 + 36) = uVar4;
                  uVar17 = 5;
                }
                else {
                  if (uVar17 != 5) goto LAB_180c299e1;
                  lVar18 = *plVar15;
                  if (*(uint32 *)(lVar11 + 24) < 6) {
                    uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar9,0);
                  }
                  uVar4 = Single.Parse(*(uint64 *)(lVar11 + 72));
                  if (lVar18 == null) goto LAB_180c2a112;
                  *(uint32 *)(lVar18 + 40) = uVar4;
                  uVar17 = 6;
                }
              }
              else {
        LAB_180c299e1:
                uVar17 = uVar17 + 1;
              }
            }
          }
          uVar17 = 0;
          lVar18 = LTCSVLoader.GetValueAt(loader,23,i);
          lVar11 = FUN_1800d60b0(DAT_181da1040,1);
          if (lVar11 == null) goto LAB_180c2a112;
          if (*(int *)(lVar11 + 24) == 0) {
            uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar9,0);
          }
          *(uint16 *)(lVar11 + 32) = 59;
          if ((lVar18 == null) || (lVar18 = String.Split(lVar18,lVar11,0)) == null) goto LAB_180c2a112;
          while( true ) {
            uVar4 = (uint32)((uint64)in_stack_ffffffffffffffa8 >> 32);
            if ((int)lVar18.Count <= (int)uVar17) break;
            if (lVar18.Count <= uVar17) {
              uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar9,0);
            }
            lVar11 = lVar18[uVar17];
            lVar14 = FUN_1800d60b0(DAT_181da1040,1);
            if (lVar14 == null) goto LAB_180c2a112;
            if (*(int *)(lVar14 + 24) == 0) {
              uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar9,0);
            }
            *(uint16 *)(lVar14 + 32) = 45;
            if (lVar11 == null) goto LAB_180c2a112;
            lVar14 = String.Split(lVar11,lVar14,0);
            lVar11 = *(int64 *)(lVar8 + 176);
            if (lVar14 == null) goto LAB_180c2a112;
            if (*(uint32 *)(lVar14 + 24) == 0) {
              uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar9,0);
            }
            uVar9 = *(uint64 *)(lVar14 + 32);
            if (*(uint32 *)(lVar14 + 24) < 2) {
              uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar9,0);
            }
            uVar3 = FUN_18171e540(*(uint64 *)(lVar14 + 40),"Self",0);
            uVar10 = DAT_181dc13d0;
            uVar10 = Type.GetTypeFromHandle(uVar10,0);
            if (*(uint32 *)(lVar14 + 24) < 3) {
              uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar9,0);
            }
            uVar1 = *(uint64 *)(lVar14 + 48);
            plVar12 = (int64 *)Enum.Parse(uVar10,uVar1,0);
            uVar10 = Type.GetTypeFromHandle(DAT_181dc1458,0);
            if (*(uint32 *)(lVar14 + 24) < 4) {
              uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar9,0);
            }
            plVar15 = (int64 *)Enum.Parse(uVar10,*(uint64 *)(lVar14 + 56),0);
            uVar10 = il2cpp_internal(DAT_181da3250);
            if (plVar15 == (int64 *)0) goto LAB_180c2a112;
            if (*(int64 *)(*plVar15 + 64) != *(int64 *)(DAT_181da3350 + 64)) {
                          // WARNING: Subroutine does not return
              FUN_1800d6070(plVar15,DAT_181da3350);
            }
            puVar13 = (uint32 *)il2cpp_object_unbox();
            if (plVar12 == (int64 *)0) goto LAB_180c2a112;
            if (*(int64 *)(*plVar12 + 64) != *(int64 *)(DAT_181da32d0 + 64)) {
                          // WARNING: Subroutine does not return
              FUN_1800d6070(plVar12);
            }
            puVar16 = (uint32 *)il2cpp_object_unbox();
            in_stack_ffffffffffffffa8 = CONCAT44(uVar4,*puVar13);
            SkillSpeEffectData.ctor(uVar10,uVar9,uVar3,*puVar16,in_stack_ffffffffffffffa8,0);
            if (lVar11 == null) goto LAB_180c2a112;
            FUN_18181e0a0(lVar11,uVar10,DAT_181da2cd8);
            uVar17 = uVar17 + 1;
          }
          uVar9 = LTCSVLoader.GetValueAt(loader,24,i);
          *(uint64 *)(lVar8 + 152) = uVar9;
          uVar9 = DAT_181dc1348;
          uVar9 = Type.GetTypeFromHandle(uVar9,0);
          uVar10 = LTCSVLoader.GetValueAt(loader,25,i);
          plVar12 = (int64 *)Enum.Parse(uVar9,uVar10,0);
          if (plVar12 == (int64 *)0) goto LAB_180c2a112;
          if (*(int64 *)(*plVar12 + 64) != *(int64 *)(DAT_181da2fd0 + 64)) {
                          // WARNING: Subroutine does not return
            FUN_1800d6070(plVar12,DAT_181da2fd0);
          }
          puVar13 = (uint32 *)il2cpp_object_unbox();
          *(uint32 *)(lVar8 + 184) = *puVar13;
          uVar9 = LTCSVLoader.GetValueAt(loader,26,i);
          uVar3 = FUN_18171e540(uVar9,"TRUE",0);
          *(uint8 *)(lVar8 + 188) = uVar3;
          uVar9 = LTCSVLoader.GetValueAt(loader,27,i);
          iVar7 = Int32.Parse(uVar9,0);
          *(int *)(lVar8 + 192) = iVar7;
          if (iVar7 == 0) {
            uVar4 = GlobalData.RandomRange(1,4,0);
            *(uint32 *)(lVar8 + 192) = uVar4;
          }
        }
        iVar7 = *(int *)(lVar8 + 48);
        if (iVar7 < 3) {
          if (iVar7 == 0) {
            *(uint32 *)(lVar8 + 28) = 2;
            lVar18 = il2cpp_internal(DAT_181d973d0);
            FUN_18132faf0(lVar18,DAT_181da27d8);
            var uVar9 = new SkillDamageRangeData(0,0,0,0);
            if (lVar18 == null) goto LAB_180c2a112;
            FUN_18181e0a0(lVar18,uVar9,DAT_181da2858);
            *(int64 *)(lVar8 + 112) = lVar18;
            uVar9 = il2cpp_internal(DAT_181da3050);
            uVar20 = 0;
            SkillDamageRangeData.ctor(uVar9,0,0,0,0);
            *(uint64 *)(lVar8 + 120) = uVar9;
            *(uint64 *)(lVar8 + 160) = "cure";
            lVar18 = *(int64 *)(lVar8 + 176);
            uVar10 = il2cpp_internal(DAT_181da3250);
            uVar9 = "真气喷";
          }
          else if (iVar7 == 1) {
            *(uint32 *)(lVar8 + 28) = 5;
            lVar18 = il2cpp_internal(DAT_181d973d0);
            FUN_18132faf0(lVar18,DAT_181da27d8);
            uVar17 = *(uint32 *)(lVar8 + 52);
            uVar4 = KungfuSkillData.GetDodgeRange(lVar8,0);
            var uVar9 = new SkillDamageRangeData(uVar17 & 1,0,uVar4,0);
            if (lVar18 == null) goto LAB_180c2a112;
            FUN_18181e0a0(lVar18,uVar9,DAT_181da2858);
            *(int64 *)(lVar8 + 112) = lVar18;
            uVar9 = il2cpp_internal(DAT_181da3050);
            uVar20 = 0;
            SkillDamageRangeData.ctor(uVar9,0,0,0,0);
            *(uint64 *)(lVar8 + 120) = uVar9;
            *(uint64 *)(lVar8 + 160) = "jump_big";
            lVar18 = *(int64 *)(lVar8 + 176);
            uVar10 = il2cpp_internal(DAT_181da3250);
            uVar9 = "紫圈";
          }
          else {
            if (iVar7 != 2) goto LAB_180c2a0c6;
            *(uint32 *)(lVar8 + 28) = 2;
            lVar18 = il2cpp_internal(DAT_181d973d0);
            FUN_18132faf0(lVar18,DAT_181da27d8);
            var uVar9 = new SkillDamageRangeData(0,0,0,0);
            if (lVar18 == null) goto LAB_180c2a112;
            FUN_18181e0a0(lVar18,uVar9,DAT_181da2858);
            *(int64 *)(lVar8 + 112) = lVar18;
            uVar9 = il2cpp_internal(DAT_181da3050);
            uVar20 = 0;
            SkillDamageRangeData.ctor(uVar9,0,0,0,0);
            *(uint64 *)(lVar8 + 120) = uVar9;
            *(uint64 *)(lVar8 + 160) = "skill0_2";
            lVar18 = *(int64 *)(lVar8 + 176);
            uVar10 = il2cpp_internal(DAT_181da3250);
            uVar9 = "护盾";
          }
          SkillSpeEffectData.ctor(uVar10,uVar9,1,0,uVar20 & 0xffffffff00000000,0);
          if (lVar18 == null) {
        LAB_180c2a112:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          FUN_18181e0a0(lVar18,uVar10,DAT_181da2cd8);
        }
        LAB_180c2a0c6:
        uVar9 = LTCSVLoader.GetValueAt(loader,28,i);
        uVar3 = FUN_18171e540(uVar9,"1",0);
        *(uint8 *)(lVar8 + 200) = uVar3;
        return lVar8;
    }

    // Token : 0x6001678
    // RVA   : 0xC1C380   Offset: 0xC1B780   Length: 0x213
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
        if (((forceName == null) || (cVar1 = FUN_18171e540(forceName,"",0), cVar1)) ||
           (cVar1 = FUN_18171e540(forceName,"无",0), cVar1)) {
          return 0xffffffff;
        }
        if ((this.forceDataBase == null) ||
           (lVar2 = FUN_1808ae5b0(this.forceDataBase,DAT_181db97e8)) == null) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        ValueCollection.GetEnumerator(&local_38,lVar2,DAT_181d7e670);
        local_50 = local_38;
        uStack_4c = uStack_34;
        uStack_48 = uStack_30;
        uStack_44 = uStack_2c;
        local_40 = local_28;
        do {
          cVar1 = FUN_1811c3f80(&local_50,DAT_181d98158);
          lVar2 = local_40;
          if (!cVar1) {
            aiStack_64[1] = 106;
            iVar3 = aiStack_64[3] + 1;
            aiStack_64[3] = iVar3;
            ZhSegment.Initialize(&local_50,DAT_181d980d8);
            goto LAB_180c1c549;
          }
          if (local_40 == 0) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          cVar1 = FUN_18171e540(*(uint64 *)(local_40 + 24),forceName,0);
        } while (!cVar1);
        uVar4 = *(uint32 *)(lVar2 + 16);
        aiStack_64[1] = 108;
        iVar3 = aiStack_64[3] + 1;
        aiStack_64[3] = iVar3;
        ZhSegment.Initialize(&local_50,DAT_181d980d8);
        LAB_180c1c549:
        if (iVar3 == 0) {
          return 0xffffffff;
        }
        if (aiStack_64[iVar3] != 108) {
          return 0xffffffff;
        }
        return uVar4;
    }

    // Token : 0x6001679
    // RVA   : 0xC2B420   Offset: 0xC2A820   Length: 0x4F3
    public AttriNumData StringToAttriRatio(string resource)
    {
        var pStatics = *(int64*)(DAT_181d73d40 + 184);
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
        lVar4 = FUN_1800d60b0(DAT_181da1040,1);
        if (lVar4 != null) {
          if (*(int *)(lVar4 + 24) == 0) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar5,0);
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
                  FUN_1800d65f0(uVar5,0);
                }
                uVar5 = lVar4[uVar9];
                uVar5 = Regex.Replace(uVar5,"[^\\u4e00-\\u9fa5]","",0);
                if (*(uint32 *)(lVar4 + 24) <= uVar9) {
                  uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar5,0);
                }
                uVar6 = Regex.Replace(lVar4[uVar9],
                                       "[\\u4e00-\\u9fa5]","",0);
                uVar10 = Single.Parse(uVar6,0);
                lVar8 = *(int64 *)(pStatics + 0x498);
                if (lVar8 == null) break;
                cVar1 = FUN_18181e400(lVar8,uVar5,DAT_181da3e58);
                if (!cVar1) {
                  lVar8 = *(int64 *)(pStatics + 0x4a0);
                  if (lVar8 == null) break;
                  cVar1 = FUN_18181e400(lVar8,uVar5,DAT_181da3e58);
                  if (cVar1) {
                    if (lVar3 != null) {
                      lVar8 = *(int64 *)(lVar3 + 24);
                      lVar7 = *(int64 *)(pStatics + 0x4a0);
                      goto LAB_180c2b886;
                    }
                    break;
                  }
                  lVar8 = *(int64 *)(pStatics + 0x4b0);
                  if (lVar8 == null) break;
                  cVar1 = FUN_18181e400(lVar8,uVar5,DAT_181da3e58);
                  if (cVar1) {
                    if (lVar3 != null) {
                      lVar8 = *(int64 *)(lVar3 + 32);
                      lVar7 = *(int64 *)(pStatics + 0x4b0);
                      goto LAB_180c2b886;
                    }
                    break;
                  }
                  cVar1 = FUN_18171e540(uVar5,"生命",0);
                  if (!cVar1) {
                    cVar1 = FUN_18171e540(uVar5,"体力",0);
                    if (!cVar1) {
                      cVar1 = FUN_18171e540(uVar5,"内力",0);
                      if (!cVar1) {
                        cVar1 = FUN_18171e540(uVar5,"魅力",0);
                        if (!cVar1) goto LAB_180c2b8b3;
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
                  lVar7 = *(int64 *)(pStatics + 0x498);
        LAB_180c2b886:
                  if ((lVar7 == null) || (uVar2 = FUN_1817eb4e0(lVar7,uVar5,DAT_181da3fd8), lVar8 == null))
                  break;
                  FUN_181829d40(lVar8,uVar2,uVar10);
        LAB_180c2b8b3:
                  uVar9 = uVar9 + 1;
                }
              }
            }
          }
        }
    }

    // Token : 0x600167A
    // RVA   : 0xC2B1A0   Offset: 0xC2A5A0   Length: 0x275
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
        lVar4 = il2cpp_internal(DAT_181d973d0);
        FUN_18132faf0(lVar4,DAT_181da27d8);
        lVar5 = FUN_1800d60b0(DAT_181da1040,1);
        if (lVar5 != null) {
          if (*(int *)(lVar5 + 24) == 0) {
            uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar8,0);
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
                  FUN_1800d65f0(uVar8,0);
                }
                lVar7 = lVar5[uVar9];
                lVar6 = FUN_1800d60b0(DAT_181da1040,1);
                if (lVar6 == null) break;
                if (*(int *)(lVar6 + 24) == 0) {
                  uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar8,0);
                }
                *(uint16 *)(lVar6 + 32) = 44;
                if ((lVar7 == null) || (lVar7 = String.Split(lVar7,lVar6,0)) == null) break;
                if (*(int *)(lVar7 + 24) == 0) {
                  uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar8,0);
                }
                uVar1 = Int32.Parse(*(uint64 *)(lVar7 + 32),0);
                if (*(uint32 *)(lVar7 + 24) < 2) {
                  uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar8,0);
                }
                uVar2 = Int32.Parse(*(uint64 *)(lVar7 + 40),0);
                if (*(uint32 *)(lVar7 + 24) < 3) {
                  uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar8,0);
                }
                uVar3 = Int32.Parse(*(uint64 *)(lVar7 + 48),0);
                uVar8 = new SkillDamageRangeData(uVar1,uVar2,uVar3,0);
                if (lVar4 == null) break;
                FUN_18181e0a0(lVar4,uVar8);
                uVar9 = uVar9 + 1;
              }
            }
          }
        }
    }

    // Token : 0x600167B
    // RVA   : 0xC2B920   Offset: 0xC2AD20   Length: 0x15A
    public SkillDamageRangeData StringToDamageRange(string resource)
    {
        uint uVar1;
        uint uVar2;
        uint uVar3;
        long lVar4;
        ulong uVar5;
        lVar4 = FUN_1800d60b0(DAT_181da1040,1);
        if (lVar4 != null) {
          if (*(int *)(lVar4 + 24) == 0) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar5,0);
          }
          *(uint16 *)(lVar4 + 32) = 44;
          if (resource != null) {
            lVar4 = String.Split(resource,lVar4,0);
            if (lVar4 != null) {
              if (*(int *)(lVar4 + 24) == 0) {
                uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar5,0);
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
                FUN_1800d65f0(uVar5,0);
              }
              uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar5,0);
            }
          }
        }
    }

    // Token : 0x600167C
    // RVA   : 0xC2BA80   Offset: 0xC2AE80   Length: 0x2DB
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
        lVar3 = FUN_1800d60b0(DAT_181da1040,1);
        if (lVar3 != null) {
          if (*(int *)(lVar3 + 24) == 0) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar4,0);
          }
          *(uint16 *)(lVar3 + 32) = 59;
          if (resource != null) {
            lVar3 = String.Split(resource,lVar3,0);
            uVar8 = 0;
            if (lVar3 != null) {
        LAB_180c2bba0:
              do {
                if ((int)*(uint32 *)(lVar3 + 24) <= (int)uVar8) {
                  return lVar2;
                }
                lVar9 = (int64)(int)uVar8;
                if (*(uint32 *)(lVar3 + 24) <= uVar8) {
                  uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar4,0);
                }
                uVar4 = *(uint64 *)(lVar3 + 32 + lVar9 * 8);
                uVar4 = Regex.Replace(uVar4,"[^\\u4e00-\\u9fa5]","",0);
                if (*(uint32 *)(lVar3 + 24) <= uVar8) {
                  uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar4,0);
                }
                lVar6 = *(int64 *)(lVar3 + 32 + lVar9 * 8);
                if (lVar6 == null) break;
                uVar5 = String.Replace(lVar6,uVar4,**(uint64 **)(DAT_181da7690 + 184));
                iVar7 = 0;
                while( true ) {
                  lVar6 = this.speAddDataBase;
                  if (lVar6 == null) throw; // [null/range check failed]
                  if (lVar6.Count <= iVar7) {
                    if (*(uint32 *)(lVar3 + 24) <= uVar8) {
                      uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar4,0);
                    }
                    uVar4 = String.Concat("StringToSpeAddData Error: ",*(uint64 *)(lVar3 + 32 + lVar9 * 8),0);
                    Debug.LogError(uVar4,0);
                    uVar8 = uVar8 + 1;
                    goto LAB_180c2bba0;
                  }
                  lVar6 = FUN_180002f80(lVar6,iVar7);
                  if (lVar6 == null) throw; // [null/range check failed]
                  cVar1 = FUN_18171e540(uVar4);
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

    // Token : 0x600167D
    // RVA   : 0xC27D30   Offset: 0xC27130   Length: 0x33E
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

    // Token : 0x600167E
    // RVA   : 0xC27B70   Offset: 0xC26F70   Length: 0x1BE
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

    // Token : 0x600167F
    // RVA   : 0xC1B110   Offset: 0xC1A510   Length: 0xAE
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

    // Token : 0x6001680
    // RVA   : 0xC1B1C0   Offset: 0xC1A5C0   Length: 0x260
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
            fVar9 = (float)FUN_1801f8ab0(0x3f000000);
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
            uVar3 = FUN_180002f80(lVar5,uVar2);
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

    // Token : 0x6001681
    // RVA   : 0xC1B430   Offset: 0xC1A830   Length: 0x2DA
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
        LAB_180c1b4c0:
        do {
          uVar2 = GameDataController.GenerateRandomHeroGivenName(this,isFemale,useCensorWords,0);
          uVar2 = String.Concat(familyName,uVar2,0);
          lVar3 = *(int64 *)(*(int64 *)(DAT_181d73d40 + 184) + 0x188);
          if (lVar3 == null) goto LAB_180c1b705;
          cVar1 = FUN_18181e400(lVar3,uVar2,DAT_181da3e58);
        } while (cVar1);
        if ((useCensorWords) && (this.CISFilterWordsSDKInited)) {
          lVar3 = CISFilterWordsSDK.get_Instance(0);
          if (lVar3 == null) {
        LAB_180c1b705:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          cVar1 = CISFilterWordsSDK.IsContainCensorWords(lVar3,uVar2,0);
          if (cVar1) goto LAB_180c1b4c0;
        }
        uVar4 = FUN_18046c0a0(0);
        cVar1 = Object.op_Inequality(uVar4,0,0);
        if (!cVar1) {
          return uVar2;
        }
        iVar5 = 0;
        do {
          lVar3 = FUN_18046c0a0(0);
          if (((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) ||
             (lVar3 = *(int64 *)(*(int64 *)(lVar3 + 32) + 80)) == null) goto LAB_180c1b705;
          if (*(int *)(lVar3 + 24) <= iVar5) {
            return uVar2;
          }
          lVar3 = FUN_18046c0a0(0);
          if (((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) ||
             (lVar3 = *(int64 *)(*(int64 *)(lVar3 + 32) + 80)) == null) goto LAB_180c1b705;
          lVar3 = FUN_180002f80(lVar3,iVar5,DAT_181d8bb98);
          if (lVar3 != null) {
            lVar3 = FUN_18046c0a0(0);
            if ((((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) ||
                (lVar3 = *(int64 *)(*(int64 *)(lVar3 + 32) + 80)) == null) ||
               (lVar3 = FUN_180002f80(lVar3,iVar5,DAT_181d8bb98)) == null) goto LAB_180c1b705;
            cVar1 = FUN_18171e540(*(uint64 *)(lVar3 + 104),uVar2,0);
            if (cVar1) goto LAB_180c1b4c0;
          }
          iVar5 = iVar5 + 1;
        } while( true );
    }

    // Token : 0x6001682
    // RVA   : 0xC1CC00   Offset: 0xC1C000   Length: 0xE6
    public KungfuSkillData GetSkillDataBase(int skillID)
    {
        var pStatics = *(int64*)(DAT_181d73d40 + 184);
        long lVar1;
        if (skillID < *(int *)(pStatics + 0x11c)) {
          if (this.kungfuSkillDataBase != null) {
            FUN_1817d9e10(this.kungfuSkillDataBase,skillID,DAT_181dbc3e0);
            return;
          }
        }
        else {
          lVar1 = this.summonSkillDataBase;
          if (lVar1 != null) {
            FUN_1817d9e10(lVar1,skillID - *(int *)(pStatics + 0x11c),
                          DAT_181dbc3e0);
            return;
          }
        }
    }

    // Token : 0x6001683
    // RVA   : 0xC1CCF0   Offset: 0xC1C0F0   Length: 0x228
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
          lVar2 = FUN_1808ae5b0(this.kungfuSkillDataBase,DAT_181dbc468);
          if (lVar2 != null) {
            ValueCollection.GetEnumerator(&local_38,lVar2,DAT_181d7f258);
            local_50 = local_38;
            uStack_4c = uStack_34;
            uStack_48 = uStack_30;
            uStack_44 = uStack_2c;
            local_40 = local_28;
            do {
              cVar1 = FUN_1811c3f80(&local_50,DAT_181d9a058);
              lVar2 = local_40;
              if (!cVar1) {
                aiStack_64[1] = 75;
                iVar4 = aiStack_64[3] + 1;
                aiStack_64[3] = iVar4;
                ZhSegment.Initialize(&local_50,DAT_181d99fd8);
                goto LAB_180c1ce91;
              }
              if (local_40 == 0) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              cVar1 = FUN_18171e540(*(uint64 *)(local_40 + 32),skillName,0);
            } while (!cVar1);
            uVar5 = *(uint32 *)(lVar2 + 20);
            aiStack_64[1] = 93;
            iVar4 = aiStack_64[3] + 1;
            aiStack_64[3] = iVar4;
            ZhSegment.Initialize(&local_50,DAT_181d99fd8);
        LAB_180c1ce91:
            if ((iVar4 != 0) && (aiStack_64[iVar4] == 93)) {
              return uVar5;
            }
            uVar3 = String.Concat("SkillID Not Found: ",skillName,0);
            Debug.Log(uVar3,0);
            return 0xffffffff;
          }
        }
    }

    // Token : 0x6001684
    // RVA   : 0xC28070   Offset: 0xC27470   Length: 0x5E8
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
          uVar4 = FUN_180da4db0(plVar3,0);
          lVar5 = JArray.Parse(uVar4,0);
          if (lVar5 != null) {
            while( true ) {
              iVar10 = 0;
              iVar2 = JContainer.get_Count(lVar5,0);
              if (iVar2 <= iVar11) {
                return;
              }
              lVar6 = new PoetryData(0);
              plVar3 = (int64 *)FUN_1802c0ff0(lVar5,iVar11,0);
              if (plVar3 == (int64 *)0) break;
              plVar3 = (int64 *)
                       (**(code **)(*plVar3 + 0x218))
                                 (plVar3,"title",*(uint64 *)(*plVar3 + 0x220));
              if (plVar3 == (int64 *)0) break;
              uVar4 = (**(code **)(*plVar3 + 0x168))(plVar3,*(uint64 *)(*plVar3 + 0x170));
              if (lVar6 == null) break;
              *(uint64 *)(lVar6 + 16) = uVar4;
              plVar3 = (int64 *)FUN_1802c0ff0(lVar5,iVar11,0);
              if (plVar3 == (int64 *)0) break;
              plVar3 = (int64 *)
                       (**(code **)(*plVar3 + 0x218))
                                 (plVar3,"author",*(uint64 *)(*plVar3 + 0x220));
              if (plVar3 == (int64 *)0) break;
              uVar4 = (**(code **)(*plVar3 + 0x168))(plVar3,*(uint64 *)(*plVar3 + 0x170));
              *(uint64 *)(lVar6 + 24) = uVar4;
              while( true ) {
                plVar3 = (int64 *)FUN_1802c0ff0(lVar5,iVar11,0);
                if (plVar3 == (int64 *)0) throw; // [null/range check failed]
                uVar4 = (**(code **)(*plVar3 + 0x218))
                                  (plVar3,"paragraphs",*(uint64 *)(*plVar3 + 0x220));
                iVar2 = Enumerable.Count(uVar4,DAT_181db2be8);
                if (iVar2 <= iVar10) break;
                lVar8 = *(int64 *)(lVar6 + 32);
                plVar3 = (int64 *)FUN_1802c0ff0(lVar5,iVar11,0);
                if (plVar3 == (int64 *)0) {
        LAB_180c28641:
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                plVar3 = (int64 *)
                         (**(code **)(*plVar3 + 0x218))
                                   (plVar3,"paragraphs",*(uint64 *)(*plVar3 + 0x220));
                local_res18[0] = iVar10;
                uVar4 = il2cpp_value_box(DAT_181d80418,local_res18);
                if (plVar3 == (int64 *)0) goto LAB_180c28641;
                plVar3 = (int64 *)
                         (**(code **)(*plVar3 + 0x218))(plVar3,uVar4,*(uint64 *)(*plVar3 + 0x220));
                if (plVar3 == (int64 *)0) goto LAB_180c28641;
                uVar4 = (**(code **)(*plVar3 + 0x168))(plVar3,*(uint64 *)(*plVar3 + 0x170));
                uVar7 = new PoetryParagraphData(uVar4,0);
                if (lVar8 == null) goto LAB_180c28641;
                FUN_18181e0a0(lVar8,uVar7,DAT_181d97908);
                if (*(int64 *)(lVar6 + 32) == 0) goto LAB_180c28641;
                lVar8 = FUN_180002f80(*(int64 *)(lVar6 + 32),iVar10);
                if ((lVar8 == null) || (*(int64 *)(lVar8 + 24) == 0)) goto LAB_180c28641;
                if (*(int *)(*(int64 *)(lVar8 + 24) + 24) == 2) {
                  lVar8 = *(int64 *)(lVar6 + 40);
                  if (*(int64 *)(lVar6 + 32) == 0) throw; // [null/range check failed]
                  lVar9 = FUN_180002f80(*(int64 *)(lVar6 + 32),iVar10,DAT_181d97a08);
                  if ((lVar9 == null) || (lVar9 = *(int64 *)(lVar9 + 24)) == null)
                  throw; // [null/range check failed]
                  if (*(int *)(lVar9 + 24) == 0) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  if (lVar8 == null) throw; // [null/range check failed]
                  cVar1 = FUN_18182a3a0(lVar8,*(uint32 *)(*(int64 *)(lVar9 + 16) + 32),
                                        DAT_181d8f398);
                  if (!cVar1) {
                    lVar8 = *(int64 *)(lVar6 + 40);
                    if (*(int64 *)(lVar6 + 32) == 0) throw; // [null/range check failed]
                    lVar9 = FUN_180002f80(*(int64 *)(lVar6 + 32),iVar10,DAT_181d97a08);
                    if ((lVar9 == null) || (lVar9 = *(int64 *)(lVar9 + 24)) == null)
                    throw; // [null/range check failed]
                    if (*(int *)(lVar9 + 24) == 0) {
                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                    }
                    if (lVar8 == null) throw; // [null/range check failed]
                    FUN_18182a0b0(lVar8,*(uint32 *)(*(int64 *)(lVar9 + 16) + 32),DAT_181d8f218)
                    ;
                  }
                  lVar8 = *(int64 *)(lVar6 + 40);
                  if (*(int64 *)(lVar6 + 32) == 0) throw; // [null/range check failed]
                  lVar9 = FUN_180002f80(*(int64 *)(lVar6 + 32),iVar10,DAT_181d97a08);
                  if ((lVar9 == null) || (lVar9 = *(int64 *)(lVar9 + 24)) == null)
                  throw; // [null/range check failed]
                  if (*(uint32 *)(lVar9 + 24) < 2) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  if (lVar8 == null) throw; // [null/range check failed]
                  cVar1 = FUN_18182a3a0(lVar8,*(uint32 *)(*(int64 *)(lVar9 + 16) + 36));
                  if (!cVar1) {
                    lVar8 = *(int64 *)(lVar6 + 40);
                    if (*(int64 *)(lVar6 + 32) == 0) throw; // [null/range check failed]
                    lVar9 = FUN_180002f80(*(int64 *)(lVar6 + 32),iVar10,DAT_181d97a08);
                    if ((lVar9 == null) || (lVar9 = *(int64 *)(lVar9 + 24)) == null)
                    throw; // [null/range check failed]
                    if (*(uint32 *)(lVar9 + 24) < 2) {
                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                    }
                    if (lVar8 == null) throw; // [null/range check failed]
                    FUN_18182a0b0(lVar8,*(uint32 *)(*(int64 *)(lVar9 + 16) + 36));
                  }
                }
                iVar10 = iVar10 + 1;
              }
              if (*(int64 *)(lVar6 + 40) == 0) break;
              cVar1 = FUN_18182a3a0(*(int64 *)(lVar6 + 40),5,DAT_181d8f398);
              if (!cVar1) {
                if (*(int64 *)(lVar6 + 40) == 0) break;
                cVar1 = FUN_18182a3a0();
                if (!(cVar1))
                {
                  }
                  else {
                }
                if (this.poetryDataBase == null) break;
                FUN_18181e0a0();
              }
              iVar11 = iVar11 + 1;
            }
          }
        }
    }

    // Token : 0x6001685
    // RVA   : 0xC1C790   Offset: 0xC1BB90   Length: 0xFB
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

    // Token : 0x6001686
    // RVA   : 0xC1ABC0   Offset: 0xC19FC0   Length: 0xD9
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
                uVar2 = FUN_180002f80(lVar3,uVar5,DAT_181da2f58);
                return uVar2;
              }
              break;
            }
            uVar5 = uVar5 + 1;
            lVar4 = lVar4 + 8;
          } while (lVar3 != null);
        }
    }

    // Token : 0x6001687
    // RVA   : 0xC1AA60   Offset: 0xC19E60   Length: 0x15D
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
              lVar4 = *(int64 *)(*(int64 *)(DAT_181d73d40 + 184) + 0x4a0);
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

    // Token : 0x6001688
    // RVA   : 0xC1CF20   Offset: 0xC1C320   Length: 0x132
    public HeroTagDataBase GetTagDataBase(int tagID)
    {
        var pStatics = *(int64*)(DAT_181d72cc8 + 184);
        long lVar1;
        ulong uVar2;
        if (tagID < 10000) {
          if (this.heroTagDataBase != null) {
            uVar2 = FUN_1817d9e10(this.heroTagDataBase,tagID,DAT_181dba420);
            return uVar2;
          }
        }
        else {
          if (((*pStatics != 0) &&
              (lVar1 = *(int64 *)(*pStatics + 32)) != null) &&
             (lVar1 = *(int64 *)(lVar1 + 0x1e0)) != null) {
            if (*(uint32 *)(lVar1 + 24) <= tagID - 10000U) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            return *(uint64 *)(*(int64 *)(lVar1 + 16) + -0x13860 + (int64)tagID * 8);
          }
        }
    }

    // Token : 0x6001689
    // RVA   : 0xC2A720   Offset: 0xC29B20   Length: 0x117
    public void ResetDlcState()
    {
        long lVar1;
        ulong uVar2;
        int iVar3;
        int[] local_res18 = new int[4];
        iVar3 = 0;
        while( true ) {
          local_res18[0] = iVar3;
          lVar1 = *(int64 *)(*(int64 *)(DAT_181d73d40 + 184) + 64);
          if (lVar1 == null) break;
          if (*(int *)(lVar1 + 24) <= iVar3) {
            return;
          }
          lVar1 = *(int64 *)(*(int64 *)(DAT_181d72d50 + 184) + 8);
          if (lVar1 == null) break;
          lVar1 = *(int64 *)(lVar1 + 16);
          uVar2 = Int32.ToString(local_res18,0);
          uVar2 = String.Concat("DLC",uVar2,0);
          if (lVar1 == null) break;
          PlayerPrefDictionary.SetKey(lVar1,uVar2,0,0);
          iVar3 = local_res18[0] + 1;
        }
    }

    // Token : 0x600168A
    // RVA   : 0xC2CB90   Offset: 0xC2BF90   Length: 0x14E
    public void /*ctor*/()
    {
        ulong uVar1;
        uVar1 = il2cpp_internal(DAT_181d97e50);
        FUN_18132faf0(uVar1,DAT_181da6218);
        this.Tasks = uVar1;
        uVar1 = il2cpp_internal(DAT_181d903e0);
        FUN_18132faf0(uVar1,DAT_181d79228);
        this.HeroNatureTalkTextDataBase = uVar1;
        uVar1 = il2cpp_internal(DAT_181d934d0);
        FUN_18132faf0(uVar1,DAT_181d8c298);
        this.HeroSpeTalkTextDataBase = uVar1;
        uVar1 = il2cpp_internal(DAT_181d82ae8);
        FUN_1808b1370(uVar1,DAT_181d72a80);
        this.SpeSkeletonName = uVar1;
        FUN_18044ef50(this,0);
    }

    // Token : 0x600168B
    // RVA   : 0xC2C9F0   Offset: 0xC2BDF0   Length: 0x19C
    private static void /*cctor*/()
    {
        var pStatics = *(int64*)(DAT_181d72d50 + 184);
        long lVar2;
        ulong uVar3;
        lVar2 = il2cpp_internal(DAT_181d97750);
        FUN_18132faf0(lVar2,DAT_181da3bd8);
        if (lVar2 != null) {
          FUN_18181e0a0(lVar2,"Save",DAT_181da3d58);
          FUN_18181e0a0(lVar2,"Hero",DAT_181da3d58);
          FUN_18181e0a0(lVar2,"TempHero",DAT_181da3d58);
          FUN_18181e0a0(lVar2,"Info",DAT_181da3d58);
          plVar1 = pStatics;
          *plVar1 = lVar2;
          il2cpp_internal(plVar1,lVar2);
          uVar3 = new RePlayerPrefData(0);
          puVar4 = (uint64 *)(pStatics + 8);
          *puVar4 = uVar3;
          il2cpp_internal(puVar4,uVar3);
          uVar3 = new ItemListData(0);
          puVar4 = (uint64 *)(pStatics + 24);
          *puVar4 = uVar3;
          il2cpp_internal(puVar4,uVar3);
          return;
        }
    }

    // Token : 0x600168C
    // RVA   : 0xC2BD60   Offset: 0xC2B160   Length: 0x125
    private void <InitWithEtag>b__77_0(OnlineCensorFileResult result)
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
