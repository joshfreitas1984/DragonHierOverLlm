// ============================================================
// Type  : ForceData
// Token : 0x2000215
// ============================================================

public class ForceData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000EF7
    public int forceID;

    // Token: 0x4000EF8
    public string forceName;

    // Token: 0x4000EF9
    public int defaultSkinID;

    // Token: 0x4000EFA
    public bool bigForce;

    // Token: 0x4000EFB
    public bool autoAddMember;

    // Token: 0x4000EFC
    public string forceStyle;

    // Token: 0x4000EFD
    public float forceMaleRate;

    // Token: 0x4000EFE
    public int forceLv;

    // Token: 0x4000EFF
    public int mainAreaID;

    // Token: 0x4000F00
    public int masterForce;

    // Token: 0x4000F01
    public List<int> servantForce;

    // Token: 0x4000F02
    public List<int> startSkillBookID;

    // Token: 0x4000F03
    public string color;

    // Token: 0x4000F04
    public int leader;

    // Token: 0x4000F05
    public List<int> ownAreasID;

    // Token: 0x4000F06
    public List<int> ownResourcePointsID;

    // Token: 0x4000F07
    public List<int> ownHeros;

    // Token: 0x4000F08
    public List<int> heroLvNum;

    // Token: 0x4000F09
    public int totalSalary;

    // Token: 0x4000F0A
    public int totalPopulation;

    // Token: 0x4000F0B
    public List<float> resourceStore;

    // Token: 0x4000F0C
    public List<float> resourceStoreMax;

    // Token: 0x4000F0D
    public List<float> resourceChange;

    // Token: 0x4000F0E
    public ItemListData forceStorage;

    // Token: 0x4000F0F
    public float forceStorageSelfDiscount;

    // Token: 0x4000F10
    public float forceStorageOtherDiscount;

    // Token: 0x4000F11
    public List<BookWriterData> bookWriterList;

    // Token: 0x4000F12
    public ItemListData bookStorage;

    // Token: 0x4000F13
    public bool bookStorageDirty;

    // Token: 0x4000F14
    public Dictionary<int, int> bookStorageMaxRareLv;

    // Token: 0x4000F15
    public List<float> forceFavor;

    // Token: 0x4000F16
    public Dictionary<int, float> forceFavorDict;

    // Token: 0x4000F17
    public List<int> allyForce;

    // Token: 0x4000F18
    public Dictionary<int, int> ForceStopWarTime;

    // Token: 0x4000F19
    public List<int> kungfuSkillFocus;

    // Token: 0x4000F1A
    public List<int> livingSkillFocus;

    // Token: 0x4000F1B
    public List<float> itemFocus;

    // Token: 0x4000F1C
    public ForceFocusType forceFocus;

    // Token: 0x4000F1D
    public bool forceDetailDirty;

    // Token: 0x4000F1E
    public bool forceHeroDetailDirty;

    // Token: 0x4000F1F
    public List<ForceFavorSettingData> forceFavorSetting;

    // Token: 0x4000F20
    public int thisMonthAttackArea;

    // Token: 0x4000F21
    public int thisMonthAttackResourcePoint;

    // Token: 0x4000F22
    public int thisMonthGetResource;

    // Token: 0x4000F23
    public int thisMonthAddOtherForceFavor;

    // Token: 0x4000F24
    public int thisMonthReduceOtherForceFavor;

    // Token: 0x4000F25
    public int randomAttackAreaDay;

    // Token: 0x4000F26
    public int thisMonthGetHero;

    // Token: 0x4000F27
    public int nowResearchTech;

    // Token: 0x4000F28
    public List<ForceTechLvData> techLvData;

    // Token: 0x4000F29
    public ForceSpeAddData techSpeAddData;

    // Token: 0x4000F2A
    public ForceSpeAddData forceSpeAddData;

    // Token: 0x4000F2B
    public List<List<ItemData>> showRoomItems;

    // Token: 0x4000F2C
    public float showRoomChangeFame;

    // Token: 0x4000F2D
    public ForceJobSettingData forceJobSettingData;

    // Token: 0x4000F2E
    public ForceInteractionTimeData forceInteractionTimeData;

    // Token: 0x4000F2F
    public bool thisMonthAttack;

    // Token: 0x4000F30
    public int thisMonthManaged;

    // Token: 0x4000F31
    public float playerOutForceContribution;

    // Token: 0x4000F32
    public int speBuildingID;

    // Token: 0x4000F33
    public string speFunctionDescribe;

    // Token: 0x4000F34
    public List<int> reasearchTechList;

    // Token: 0x4000F35
    public bool replacedForce;

    // Token: 0x4000F36
    public string forceSetName;

    // Token: 0x4000F37
    public int forceSetIcon;

    // Token: 0x4000F38
    private static readonly float JoinBigForceNeedSkill;

    // Token: 0x4000F39
    private static readonly float JoinBigForceNeedFame;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600100D
    // RVA   : 0xB381E0   Offset: 0xB375E0   Length: 0xA42
    public void /*ctor*/()
    {
        ulong uVar1;
        long lVar2;
        long lVar3;
        this.masterForce = 0xffffffff;
        this.leader = 0xffffffff;
        this.forceStorageSelfDiscount = 0x3f800000;
        this.forceStorageOtherDiscount = 0x3f800000;
        this.nowResearchTech = 0xffffffff;
        ZhSegment.Initialize(this,0);
        uVar1 = il2cpp_internal(DAT_181d93cd0);
        FUN_18132faf0(uVar1,DAT_181d8f098);
        this.servantForce = uVar1;
        uVar1 = il2cpp_internal(DAT_181d93cd0);
        FUN_18132faf0(uVar1,DAT_181d8f098);
        this.startSkillBookID = uVar1;
        uVar1 = il2cpp_internal(DAT_181d93cd0);
        FUN_18132faf0(uVar1,DAT_181d8f098);
        this.ownAreasID = uVar1;
        uVar1 = il2cpp_internal(DAT_181d93cd0);
        FUN_18132faf0(uVar1,DAT_181d8f098);
        this.ownResourcePointsID = uVar1;
        uVar1 = il2cpp_internal(DAT_181d93cd0);
        FUN_18132faf0(uVar1,DAT_181d8f098);
        this.ownHeros = uVar1;
        lVar2 = il2cpp_internal(DAT_181d96ed0);
        FUN_18132faf0(lVar2,DAT_181da0cf8);
        if (lVar2 != null) {
          FUN_18181de10(lVar2,0,DAT_181da0df8);
          FUN_18181de10(lVar2,0,DAT_181da0df8);
          FUN_18181de10(lVar2,0,DAT_181da0df8);
          FUN_18181de10(lVar2,0,DAT_181da0df8);
          FUN_18181de10(lVar2,0,DAT_181da0df8);
          FUN_18181de10(lVar2,0,DAT_181da0df8);
          this.resourceStore = lVar2;
          lVar2 = il2cpp_internal(DAT_181d96ed0);
          FUN_18132faf0(lVar2,DAT_181da0cf8);
          if (lVar2 != null) {
            FUN_18181de10(lVar2,0x447a0000,DAT_181da0df8);
            FUN_18181de10(lVar2,0x447a0000,DAT_181da0df8);
            FUN_18181de10(lVar2,0x447a0000,DAT_181da0df8);
            FUN_18181de10(lVar2,0x447a0000,DAT_181da0df8);
            FUN_18181de10(lVar2,0x447a0000,DAT_181da0df8);
            FUN_18181de10(lVar2,0x42c80000,DAT_181da0df8);
            this.resourceStoreMax = lVar2;
            lVar2 = il2cpp_internal(DAT_181d96ed0);
            FUN_18132faf0(lVar2,DAT_181da0cf8);
            if (lVar2 != null) {
              FUN_18181de10(lVar2,0,DAT_181da0df8);
              FUN_18181de10(lVar2,0,DAT_181da0df8);
              FUN_18181de10(lVar2,0,DAT_181da0df8);
              FUN_18181de10(lVar2,0,DAT_181da0df8);
              FUN_18181de10(lVar2,0,DAT_181da0df8);
              FUN_18181de10(lVar2,0,DAT_181da0df8);
              this.resourceChange = lVar2;
              this.forceStorage = new ItemListData(0);
              this.bookStorage = new ItemListData(0);
              uVar1 = il2cpp_internal(DAT_181d80fe8);
              FUN_1808b1370(uVar1,DAT_181dba750);
              *(uint64 *)(this + 200) = uVar1;
              uVar1 = il2cpp_internal(DAT_181d96ed0);
              FUN_18132faf0(uVar1,DAT_181da0cf8);
              this.forceFavor = uVar1;
              uVar1 = il2cpp_internal(DAT_181d815e8);
              FUN_1808b1370(uVar1,DAT_181dbdbb8);
              this.forceFavorDict = uVar1;
              uVar1 = il2cpp_internal(DAT_181d93cd0);
              FUN_18132faf0(uVar1,DAT_181d8f098);
              this.kungfuSkillFocus = uVar1;
              uVar1 = il2cpp_internal(DAT_181d93cd0);
              FUN_18132faf0(uVar1,DAT_181d8f098);
              this.livingSkillFocus = uVar1;
              uVar1 = il2cpp_internal(DAT_181d92cd8);
              FUN_18132faf0(uVar1,DAT_181d881a0);
              this.forceFavorSetting = uVar1;
              this.forceSpeAddData = new ForceSpeAddData(0);
              this.techSpeAddData = new ForceSpeAddData(0);
              uVar1 = il2cpp_internal(DAT_181d92dd8);
              FUN_18132faf0(uVar1,DAT_181d88a18);
              this.techLvData = uVar1;
              this.forceInteractionTimeData = new ForceInteractionTimeData(0);
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
                      this.forceJobSettingData = new ForceJobSettingData(0);
                      lVar2 = il2cpp_internal(DAT_181d96ed0);
                      FUN_18132faf0(lVar2,DAT_181da0cf8);
                      if (lVar2 != null) {
                        FUN_18181de10(lVar2,0,DAT_181da0df8);
                        FUN_18181de10(lVar2,0,DAT_181da0df8);
                        this.itemFocus = lVar2;
                        lVar2 = il2cpp_internal(DAT_181d91758);
                        FUN_18132faf0(lVar2,DAT_181d802a0);
                        uVar1 = new BookWriterData(0);
                        if (lVar2 != null) {
                          FUN_18181e0a0(lVar2,uVar1,DAT_181d80320);
                          uVar1 = new BookWriterData(0);
                          FUN_18181e0a0(lVar2,uVar1,DAT_181d80320);
                          uVar1 = new BookWriterData(0);
                          FUN_18181e0a0(lVar2,uVar1,DAT_181d80320);
                          uVar1 = new BookWriterData(0);
                          FUN_18181e0a0(lVar2,uVar1,DAT_181d80320);
                          this.bookWriterList = lVar2;
                          uVar1 = il2cpp_internal(DAT_181d93cd0);
                          FUN_18132faf0(uVar1,DAT_181d8f098);
                          this.reasearchTechList = uVar1;
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

    // Token : 0x600100E
    // RVA   : 0xB34EC0   Offset: 0xB342C0   Length: 0xBE
    public ForceData GetMasterForce()
    {
        long lVar1;
        if ((GameController._instance != null) &&
           (lVar1 = GameController._instance.worldData) != null) {
          WorldData.GetForce(lVar1,this.masterForce,0);
          return;
        }
    }

    // Token : 0x600100F
    // RVA   : 0xB33D00   Offset: 0xB33100   Length: 0x89
    public Sprite GetForceIcon()
    {
        long lVar1;
        ulong uVar2;
        lVar1 = **(int64 **)(DAT_181dab490 + 184);
        uVar2 = ForceData.GetForceIconName(this,0);
        if (lVar1 != null) {
          TextureController.LoadAtlasSprite(lVar1,"UIAtlas",uVar2,0);
          return;
        }
    }

    // Token : 0x6001010
    // RVA   : 0xB33BF0   Offset: 0xB32FF0   Length: 0x101
    public string GetForceIconName()
    {
        int iVar1;
        ulong uVar2;
        ulong uVar3;
        int[] local_res8 = new int[2];
        iVar1 = this.forceSetIcon;
        if (iVar1 < 1) {
          iVar1 = this.forceID;
          local_res8[0] = iVar1;
          uVar2 = Int32.ToString(local_res8,0);
          uVar3 = "门派标志";
        }
        else {
          local_res8[0] = iVar1;
          uVar2 = Int32.ToString(local_res8,0);
          uVar3 = "自选标志";
        }
        String.Concat(uVar3,uVar2,0);
    }

    // Token : 0x6001011
    // RVA   : 0xB33580   Offset: 0xB32980   Length: 0x62
    public static string GenerateForceIconName(int id, int type)
    {
        ulong uVar1;
        ulong uVar2;
        uint[] local_res8 = new uint[8];
        local_res8[0] = id;
        uVar1 = Int32.ToString(local_res8,0);
        uVar2 = "门派标志";
        if (type != null) {
          uVar2 = "自选标志";
        }
        String.Concat(uVar2,uVar1,0);
    }

    // Token : 0x6001012
    // RVA   : 0xB31450   Offset: 0xB30850   Length: 0x14C
    public ItemData BookStorageFindSkill(int _skillID)
    {
        long lVar1;
        ulong uVar2;
        uint uVar3;
        long lVar4;
        lVar1 = this.bookStorage;
        uVar3 = 0;
        if (lVar1 != null) {
          lVar4 = 32;
          while (lVar1.allItem != null) {
            if (*(int *)(lVar1.allItem + 24) <= (int)uVar3) {
              return 0;
            }
            if ((lVar1 = lVar1?.allItem) == null) break;
            if (lVar1.money <= uVar3) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar1 = *(int64 *)(lVar4 + lVar1.heroID);
            if (lVar1 == null) break;
            if (lVar1.forceID == 3) {
              if ((((this.bookStorage == null) ||
                   (lVar1 = this.bookStorage.allItem) == null) ||
                  (lVar1 = FUN_180002f80(lVar1,uVar3,DAT_181d90f18)) == null) ||
                 (*(int64 *)(lVar1 + 112) == 0)) break;
              if (*(int *)(*(int64 *)(lVar1 + 112) + 16) == _skillID) {
                if ((this.bookStorage != null) &&
                   (lVar1 = this.bookStorage.allItem) != null) {
                  uVar2 = FUN_180002f80(lVar1,uVar3,DAT_181d90f18);
                  return uVar2;
                }
                break;
              }
            }
            lVar1 = this.bookStorage;
            uVar3 = uVar3 + 1;
            lVar4 = lVar4 + 8;
            if (lVar1 == null) break;
          }
        }
    }

    // Token : 0x6001013
    // RVA   : 0xB315A0   Offset: 0xB309A0   Length: 0x18E
    public bool BookStorageHaveSkillTypeLv(int _skillType, int _skillLv)
    {
        long lVar1;
        uint uVar2;
        long lVar3;
        lVar1 = this.bookStorage;
        uVar2 = 0;
        if (lVar1 != null) {
          lVar3 = 32;
          while (lVar1.allItem != null) {
            if (*(int *)(lVar1.allItem + 24) <= (int)uVar2) {
              return false;
            }
            if ((lVar1 = lVar1?.allItem) == null) break;
            if (lVar1.money <= uVar2) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar1 = *(int64 *)(lVar3 + lVar1.heroID);
            if (lVar1 == null) break;
            if (lVar1.forceID == 3) {
              if ((((this.bookStorage == null) ||
                   (lVar1 = this.bookStorage.allItem) == null) ||
                  (lVar1 = FUN_180002f80(lVar1,uVar2,DAT_181d90f18)) == null) ||
                 ((*(int64 *)(lVar1 + 112) == 0 ||
                  (lVar1 = BookData.DataBase(*(int64 *)(lVar1 + 112),0)) == null))) break;
              if (lVar1.itemTypeList == _skillType) {
                if (((this.bookStorage == null) ||
                    (lVar1 = this.bookStorage.allItem) == null) ||
                   ((lVar1 = FUN_180002f80(lVar1,uVar2,DAT_181d90f18), lVar1 == null ||
                    ((*(int64 *)(lVar1 + 112) == 0 ||
                     (lVar1 = BookData.DataBase(*(int64 *)(lVar1 + 112),0)) == null))))) break;
                if (*(int *)(lVar1 + 52) == _skillLv) {
                  return true;
                }
              }
            }
            lVar1 = this.bookStorage;
            uVar2 = uVar2 + 1;
            lVar3 = lVar3 + 8;
            if (lVar1 == null) break;
          }
        }
    }

    // Token : 0x6001014
    // RVA   : 0xB35690   Offset: 0xB34A90   Length: 0x1AA
    public float GetResearchSpeedRate()
    {
        int iVar1;
        long lVar2;
        float fVar3;
        float fVar4;
        if (this.forceSpeAddData != null) {
          fVar3 = (float)ForceSpeAddData.Get(this.forceSpeAddData,4);
          iVar1 = this.forceID;
          if ((GameController._instance != null) &&
             (lVar2 = GameController._instance.worldData) != null) {
            lVar2 = WorldData.Player(lVar2,0);
            if (lVar2 != null) {
              if (iVar1 == *(int *)(lVar2 + 132)) {
                fVar4 = 0.0;
              }
              else {
                if ((GameController._instance == null) ||
                   (lVar2 = GameController._instance.worldData) == null)
                throw; // [null/range check failed]
                fVar4 = (float)WorldData.GetAIForceDevelopSpeed(lVar2,0);
                fVar4 = fVar4 * 0.05;
              }
              return fVar3 + 1.0 + fVar4;
            }
          }
        }
    }

    // Token : 0x6001015
    // RVA   : 0xB35500   Offset: 0xB34900   Length: 0x18C
    public float GetResearchCostRate()
    {
        int iVar1;
        long lVar2;
        float fVar3;
        iVar1 = this.forceID;
        if ((GameController._instance != null) &&
           (lVar2 = GameController._instance.worldData) != null) {
          lVar2 = WorldData.Player(lVar2,0);
          if (lVar2 != null) {
            if (iVar1 == *(int *)(lVar2 + 132)) {
              fVar3 = 0.0;
            }
            else {
              if ((GameController._instance == null) ||
                 (lVar2 = GameController._instance.worldData) == null)
              throw; // [null/range check failed]
              fVar3 = (float)WorldData.GetAIForceDevelopSpeed(lVar2,0);
              fVar3 = fVar3 * -0.05;
            }
            Mathf.Max(0x3d4ccccd,fVar3 + 1.0,0);
            return;
          }
        }
    }

    // Token : 0x6001016
    // RVA   : 0xB335F0   Offset: 0xB329F0   Length: 0x18C
    public float GetBuildCostRate()
    {
        int iVar1;
        long lVar2;
        float fVar3;
        iVar1 = this.forceID;
        if ((GameController._instance != null) &&
           (lVar2 = GameController._instance.worldData) != null) {
          lVar2 = WorldData.Player(lVar2,0);
          if (lVar2 != null) {
            if (iVar1 == *(int *)(lVar2 + 132)) {
              fVar3 = 0.0;
            }
            else {
              if ((GameController._instance == null) ||
                 (lVar2 = GameController._instance.worldData) == null)
              throw; // [null/range check failed]
              fVar3 = (float)WorldData.GetAIForceDevelopSpeed(lVar2,0);
              fVar3 = fVar3 * -0.05;
            }
            Mathf.Max(0x3d4ccccd,fVar3 + 1.0,0);
            return;
          }
        }
    }

    // Token : 0x6001017
    // RVA   : 0xB35840   Offset: 0xB34C40   Length: 0xA1
    public float GetResourcePercent(int resourceID)
    {
        float fVar1;
        long lVar2;
        long lVar3;
        lVar2 = this.resourceStore;
        if (lVar2 != null) {
          if (lVar2.Count <= resourceID) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar3 = this.resourceStoreMax;
          fVar1 = lVar2._items[resourceID];
          if (lVar3 != null) {
            if (lVar3.Count <= resourceID) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            return fVar1 / lVar3._items[resourceID];
          }
        }
    }

    // Token : 0x6001018
    // RVA   : 0xB358F0   Offset: 0xB34CF0   Length: 0x1B9
    public float GetSalaryRate()
    {
        byte[] auVar1 = new byte[12];
        long lVar2;
        float fVar3;
        ulong uVar4;
        byte[] auVar5 = new byte[12];
        auVar5 = ZEXT812(0x3f800000);
        if (100 < this.totalPopulation) {
          auVar5._4_8_ = 0;
          auVar5._0_4_ = (float)(this.totalPopulation + -100) * 0.01 + 1.0;
        }
        uVar4 = auVar5._0_8_;
        if ((GameController._instance != null) &&
           (lVar2 = GameController._instance.worldData) != null) {
          lVar2 = WorldData.Player(lVar2,0);
          if (lVar2 != null) {
            if (*(int *)(lVar2 + 132) != this.forceID) {
              if ((GameController._instance == null) ||
                 (lVar2 = GameController._instance.worldData) == null)
              throw; // [null/range check failed]
              fVar3 = (float)WorldData.GetAIForceDevelopSpeed(lVar2,0);
              auVar1._4_8_ = auVar5._4_8_;
              auVar1._0_4_ = auVar5._0_4_ * (1.0 - fVar3 * 0.025);
              uVar4 = auVar1._0_8_;
            }
            return uVar4;
          }
        }
    }

    // Token : 0x6001019
    // RVA   : 0xB35320   Offset: 0xB34720   Length: 0x1D6
    public int GetRealSalaryCost()
    {
        int iVar1;
        long lVar2;
        float fVar3;
        byte[] auVar4 = new byte[12];
        iVar1 = this.totalSalary;
        auVar4 = ZEXT812(0x3f800000);
        if (100 < this.totalPopulation) {
          auVar4._4_8_ = 0;
          auVar4._0_4_ = (float)(this.totalPopulation + -100) * 0.01 + 1.0;
        }
        if ((GameController._instance != null) &&
           (lVar2 = GameController._instance.worldData) != null) {
          lVar2 = WorldData.Player(lVar2,0);
          if (lVar2 != null) {
            if (*(int *)(lVar2 + 132) != this.forceID) {
              if ((GameController._instance == null) ||
                 (lVar2 = GameController._instance.worldData) == null)
              throw; // [null/range check failed]
              fVar3 = (float)WorldData.GetAIForceDevelopSpeed(lVar2,0);
              auVar4._4_8_ = auVar4._4_8_;
              auVar4._0_4_ = auVar4._0_4_ * (1.0 - fVar3 * 0.025);
            }
            Mathf.RoundToInt((float)iVar1 * auVar4._0_4_,0);
            return;
          }
        }
    }

    // Token : 0x600101A
    // RVA   : 0xB32B00   Offset: 0xB31F00   Length: 0xD2
    public ForceData DataBase()
    {
        long lVar1;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d72d50 + 184) + 32);
        if ((lVar1 != null) && (lVar1 = *(int64 *)(lVar1 + 208)) != null) {
          FUN_1817d9e10(lVar1,this.forceID,DAT_181db9760);
          return;
        }
    }

    // Token : 0x600101B
    // RVA   : 0xB36ED0   Offset: 0xB362D0   Length: 0x412
    public void SetForceStopWarTime(int targetForceID, int time, bool back, bool showInfo)
    {
        void ForceData.SetForceStopWarTime
                     (int64 this,uint32 targetForceID,uint32 time,char back,char showInfo)
        {
        char cVar1;
        uint32 uVar2;
        uint64 uVar3;
        int64 lVar4;
        int64 lVar5;
        uint64 uVar6;
        uint64 uVar7;
        uint32 local_res10 [2];
        uint64 local_28;
        uint64 uStack_20;
        lVar4 = this.ForceStopWarTime;
        if (lVar4 == null) {
          uVar3 = il2cpp_internal(DAT_181d80fe8);
          FUN_1808b1370(uVar3,DAT_181dba750);
          this.ForceStopWarTime = uVar3;
          lVar4 = this.ForceStopWarTime;
          if (lVar4 == null) throw; // [null/range check failed]
        }
        cVar1 = FUN_1808ab490(lVar4,targetForceID,DAT_181dba9f8);
        lVar4 = this.ForceStopWarTime;
        if (!cVar1) {
          if (lVar4 == null) throw; // [null/range check failed]
          FUN_1808ab370(lVar4,targetForceID,time,DAT_181dba8e8);
        }
        else {
          if (lVar4 == null) throw; // [null/range check failed]
          uVar2 = FUN_181467530(lVar4,targetForceID,DAT_181dbb050);
          uVar2 = Mathf.Max(time,uVar2,0);
          FUN_1808b2160(lVar4,targetForceID,uVar2,DAT_181dbb160);
        }
        if (!back) {
          return;
        }
        if (((GameController._instance != null) &&
            (lVar4 = GameController._instance.worldData) != null) &&
           (lVar4 = WorldData.GetForce(lVar4,targetForceID,0)) != null) {
          uVar2 = 0;
          ForceData.SetForceStopWarTime(lVar4,this.forceID,time,0,1,0);
          if (!showInfo) {
            return;
          }
          lVar4 = **(int64 **)(DAT_181d7f6a8 + 184);
          cVar1 = FUN_180d755b0(this.forceSetName,0);
          if (!cVar1) {
            uVar3 = this.forceSetName;
          }
          else {
            uVar3 = this.forceName;
          }
          lVar5 = FUN_18046c0a0(0);
          if (((lVar5 != null) && (*(int64 *)(lVar5 + 32) != 0)) &&
             (lVar5 = WorldData.GetForce(*(int64 *)(lVar5 + 32),targetForceID,0)) != null) {
            cVar1 = FUN_180d755b0(*(uint64 *)(lVar5 + 0x198),0);
            if (!cVar1) {
              uVar7 = *(uint64 *)(lVar5 + 0x198);
            }
            else {
              uVar7 = *(uint64 *)(lVar5 + 24);
            }
            local_res10[0] = time;
            uVar6 = il2cpp_value_box(DAT_181d80418,local_res10);
            uVar3 = String.Format("{0}与{1}缔结了为期{2}日的停战协定",uVar3,uVar7,uVar6,0);
            lVar5 = FUN_18046c0a0(0);
            if ((((lVar5 != null) && (*(int64 *)(lVar5 + 32) != 0)) &&
                (lVar5 = WorldData.GetForce(*(int64 *)(lVar5 + 32),this.forceID,0
                                            ), lVar5 != null)) &&
               (uVar7 = ForceData.GetForceIconName(lVar5,0), lVar4 != null)) {
              local_28 = 0;
              uStack_20 = 0;
              InfoController.AddInfoTab
                        (lVar4,uVar3,"UIAtlas",uVar7,"FameUp",CONCAT44(uVar2,0x3f800000),
                         0x40a00000,&local_28,0);
              return;
            }
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
    }

    // Token : 0x600101C
    // RVA   : 0xB34400   Offset: 0xB33800   Length: 0xED
    public int GetForceStopWarTime(int targetForceID)
    {
        bool cVar1;
        ulong uVar2;
        long lVar3;
        lVar3 = this.ForceStopWarTime;
        if (lVar3 == null) {
          uVar2 = il2cpp_internal(DAT_181d80fe8);
          FUN_1808b1370(uVar2,DAT_181dba750);
          this.ForceStopWarTime = uVar2;
          lVar3 = this.ForceStopWarTime;
          if (lVar3 == null) throw; // [null/range check failed]
        }
        cVar1 = FUN_1808ab490(lVar3,targetForceID,DAT_181dba9f8);
        if (!cVar1) {
          return 0;
        }
        if (this.ForceStopWarTime != null) {
          uVar2 = FUN_181467530(this.ForceStopWarTime,targetForceID,DAT_181dbb050);
          return uVar2;
        }
    }

    // Token : 0x600101D
    // RVA   : 0xB35D00   Offset: 0xB35100   Length: 0xB7
    public bool IsAllyForce(int targetForceID)
    {
        ulong uVar1;
        long lVar2;
        lVar2 = this.allyForce;
        if (lVar2 == null) {
          uVar1 = il2cpp_internal(DAT_181d93cd0);
          FUN_18132faf0(uVar1,DAT_181d8f098);
          this.allyForce = uVar1;
          lVar2 = this.allyForce;
        }
        if (lVar2 != null) {
          FUN_18182a3a0(lVar2,targetForceID,DAT_181d8f398);
          return;
        }
    }

    // Token : 0x600101E
    // RVA   : 0xB30DC0   Offset: 0xB301C0   Length: 0x346
    public void AddAllyForce(int targetForceID, bool back, bool showInfo)
    {
        bool cVar1;
        ulong uVar2;
        long lVar3;
        long lVar4;
        ulong uVar5;
        ulong local_28;
        ulong uStack_20;
        lVar3 = this.allyForce;
        if (lVar3 == null) {
          uVar2 = il2cpp_internal(DAT_181d93cd0);
          FUN_18132faf0(uVar2,DAT_181d8f098);
          this.allyForce = uVar2;
          lVar3 = this.allyForce;
          if (lVar3 == null) throw; // [null/range check failed]
        }
        FUN_18182a0b0(lVar3,targetForceID,DAT_181d8f218);
        if (!back) {
          return;
        }
        if (((GameController._instance != null) &&
            (lVar3 = GameController._instance.worldData) != null) &&
           (lVar3 = WorldData.GetForce(lVar3,targetForceID,0)) != null) {
          ForceData.AddAllyForce(lVar3,this.forceID,0,1,0);
          if (!showInfo) {
            return;
          }
          lVar3 = **(int64 **)(DAT_181d7f6a8 + 184);
          cVar1 = FUN_180d755b0(this.forceSetName,0);
          if (!cVar1) {
            uVar2 = this.forceSetName;
          }
          else {
            uVar2 = this.forceName;
          }
          lVar4 = FUN_18046c0a0(0);
          if (((lVar4 != null) && (*(int64 *)(lVar4 + 32) != 0)) &&
             (lVar4 = WorldData.GetForce(*(int64 *)(lVar4 + 32),targetForceID,0)) != null) {
            cVar1 = FUN_180d755b0(*(uint64 *)(lVar4 + 0x198),0);
            if (!cVar1) {
              uVar5 = *(uint64 *)(lVar4 + 0x198);
            }
            else {
              uVar5 = *(uint64 *)(lVar4 + 24);
            }
            uVar2 = String.Format("{0}与{1}缔结了同盟协定",uVar2,uVar5,0);
            lVar4 = FUN_18046c0a0(0);
            if ((((lVar4 != null) && (*(int64 *)(lVar4 + 32) != 0)) &&
                (lVar4 = WorldData.GetForce(*(int64 *)(lVar4 + 32),this.forceID,0
                                            ), lVar4 != null)) &&
               (uVar5 = ForceData.GetForceIconName(lVar4,0), lVar3 != null)) {
              local_28 = 0;
              uStack_20 = 0;
              InfoController.AddInfoTab
                        (lVar3,uVar2,"UIAtlas",uVar5,"NoticeImportant",0x3f800000,0x40a00000,&local_28,0);
              return;
            }
          }
        }
    }

    // Token : 0x600101F
    // RVA   : 0xB31730   Offset: 0xB30B30   Length: 0x367
    public void BreakAllyForce(int targetForceID, bool back, bool showInfo)
    {
        bool cVar1;
        ulong uVar2;
        long lVar3;
        long lVar4;
        ulong uVar5;
        ulong in_stack_ffffffffffffffb0;
        uint uVar6;
        ulong local_28;
        ulong uStack_20;
        uVar6 = (uint32)((uint64)in_stack_ffffffffffffffb0 >> 32);
        lVar3 = this.allyForce;
        if (lVar3 == null) {
          uVar2 = il2cpp_internal(DAT_181d93cd0);
          FUN_18132faf0(uVar2,DAT_181d8f098);
          this.allyForce = uVar2;
          lVar3 = this.allyForce;
          if (lVar3 == null) throw; // [null/range check failed]
        }
        FUN_1817eee00(lVar3,targetForceID,DAT_181d8f618);
        if (!back) {
          return;
        }
        if (((GameController._instance != null) &&
            (lVar3 = GameController._instance.worldData) != null) &&
           (lVar3 = WorldData.GetForce(lVar3,targetForceID,0)) != null) {
          ForceData.BreakAllyForce(lVar3,this.forceID,0,1,0);
          if (!showInfo) {
        LAB_180b31a53:
            ForceData.SetForceStopWarTime(this,targetForceID,90,1,1,0);
            return;
          }
          lVar3 = **(int64 **)(DAT_181d7f6a8 + 184);
          cVar1 = FUN_180d755b0(this.forceSetName,0);
          if (!cVar1) {
            uVar2 = this.forceSetName;
          }
          else {
            uVar2 = this.forceName;
          }
          lVar4 = FUN_18046c0a0(0);
          if (((lVar4 != null) && (*(int64 *)(lVar4 + 32) != 0)) &&
             (lVar4 = WorldData.GetForce(*(int64 *)(lVar4 + 32),targetForceID,0)) != null) {
            cVar1 = FUN_180d755b0(*(uint64 *)(lVar4 + 0x198),0);
            if (!cVar1) {
              uVar5 = *(uint64 *)(lVar4 + 0x198);
            }
            else {
              uVar5 = *(uint64 *)(lVar4 + 24);
            }
            uVar2 = String.Format("{0}与{1}撕毁了同盟协定",uVar2,uVar5,0);
            lVar4 = FUN_18046c0a0(0);
            if ((((lVar4 != null) && (*(int64 *)(lVar4 + 32) != 0)) &&
                (lVar4 = WorldData.GetForce(*(int64 *)(lVar4 + 32),this.forceID,0
                                            ), lVar4 != null)) &&
               (uVar5 = ForceData.GetForceIconName(lVar4,0), lVar3 != null)) {
              local_28 = 0;
              uStack_20 = 0;
              InfoController.AddInfoTab
                        (lVar3,uVar2,"UIAtlas",uVar5,"FameDown",CONCAT44(uVar6,0x3f800000),
                         0x40a00000,&local_28,0);
              goto LAB_180b31a53;
            }
          }
        }
    }

    // Token : 0x6001020
    // RVA   : 0xB31AA0   Offset: 0xB30EA0   Length: 0x90
    public bool CanAttack(int targetForceID)
    {
        bool cVar1;
        int iVar2;
        if ((this.forceID != targetForceID) && (this.masterForce != targetForceID)) {
          if (this.servantForce == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          cVar1 = FUN_18182a3a0(this.servantForce,targetForceID,DAT_181d8f398);
          if (!cVar1) {
            cVar1 = ForceData.IsAllyForce(this,targetForceID,0);
            if (!cVar1) {
              iVar2 = ForceData.GetForceStopWarTime(this,targetForceID,0);
              return iVar2 < 1;
            }
          }
        }
        return false;
    }

    // Token : 0x6001021
    // RVA   : 0xB33E00   Offset: 0xB33200   Length: 0x2FD
    public string GetForceRelationshipText(int targetForceID, bool useDarkColor)
    {
        var pStatics = *(int64*)(DAT_181d73d40 + 184);
        bool cVar1;
        int iVar2;
        ulong uVar3;
        ulong uVar4;
        uint[] local_res10 = new uint[2];
        uVar3 = "{0}宗主</color>";
        uVar4 = "{0}本门</color>";
        if (this.forceID != targetForceID) {
          if (this.masterForce == targetForceID) {
            if (!useDarkColor) {
              uVar4 = *(uint64 *)(pStatics + 0x2c8);
            }
            else {
              uVar4 = *(uint64 *)(pStatics + 0x2d0);
            }
            goto LAB_180b340de;
          }
          if (this.servantForce == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          cVar1 = FUN_18182a3a0(this.servantForce,targetForceID,DAT_181d8f398);
          uVar4 = "{0}附庸</color>";
          if (!cVar1) {
            cVar1 = ForceData.IsAllyForce(this,targetForceID,0);
            uVar3 = "{0}同盟</color>";
            if (!cVar1) {
              iVar2 = ForceData.GetForceStopWarTime(this,targetForceID,0);
              if (0 < iVar2) {
                local_res10[0] = ForceData.GetForceStopWarTime(this,targetForceID,0);
                uVar3 = il2cpp_value_box(DAT_181d80418,local_res10);
                uVar3 = String.Format("{1}休战{0}日</color>",uVar3,
                                       *(uint64 *)(pStatics + 0x238),0);
                return uVar3;
              }
              return false;
            }
            if (!useDarkColor) {
              uVar4 = *(uint64 *)(pStatics + 0x240);
            }
            else {
              uVar4 = *(uint64 *)(pStatics + 0x248);
            }
            goto LAB_180b340de;
          }
        }
        uVar3 = uVar4;
        if (!useDarkColor) {
          uVar4 = *(uint64 *)(pStatics + 0x260);
        }
        else {
          uVar4 = *(uint64 *)(pStatics + 0x268);
        }
        LAB_180b340de:
        uVar3 = String.Format(uVar3,uVar4,0);
        return uVar3;
    }

    // Token : 0x6001022
    // RVA   : 0xB33550   Offset: 0xB32950   Length: 0x29
    public SexLimit ForceSexLimit()
    {
        if (this.forceMaleRate == 1.0) {
          return 1;
        }
        if (this.forceMaleRate != null.0) {
          return 0;
        }
        return 2;
    }

    // Token : 0x6001023
    // RVA   : 0xB36000   Offset: 0xB35400   Length: 0x4F
    public bool MeetForceSexLimit(HeroData targetHero)
    {
        if (this.forceMaleRate == 1.0) {
          if (targetHero != null) {
            return *(char *)(targetHero + 128) == false;
          }
        }
        else {
          if (this.forceMaleRate != null.0) {
            return true;
          }
          if (targetHero != null) {
            return (bool)*(uint8 *)(targetHero + 128);
          }
        }
    }

    // Token : 0x6001024
    // RVA   : 0xB33DC0   Offset: 0xB331C0   Length: 0x36
    public string GetForceName(bool replacedForce)
    {
        bool cVar1;
        if (replacedForce) {
          cVar1 = FUN_180d755b0(this.forceSetName,0);
          if (!cVar1) {
            return this.forceSetName;
          }
        }
        return this.forceName;
    }

    // Token : 0x6001025
    // RVA   : 0xB312D0   Offset: 0xB306D0   Length: 0x172
    public void BookStorageAddBook(ItemData book, bool showInfo)
    {
        long lVar1;
        bool cVar2;
        ulong uVar3;
        ulong uVar4;
        ulong local_18;
        ulong uStack_10;
        if (this.bookStorage != null) {
          ItemListData.GetItem(this.bookStorage,book,0,0);
          this.bookStorageDirty = 1;
          if (!showInfo) {
            return;
          }
          lVar1 = **(int64 **)(DAT_181d7f6a8 + 184);
          cVar2 = FUN_180d755b0(this.forceSetName,0);
          if (!cVar2) {
            uVar4 = this.forceSetName;
          }
          else {
            uVar4 = this.forceName;
          }
          if (book != null) {
            uVar3 = ItemData.Name(book,1,0);
            uVar4 = String.Format("{0}藏经阁添加了藏书《{1}》。",uVar4,uVar3,0);
            uVar3 = ItemData.GetItemIconName(book,0);
            if (lVar1 != null) {
              local_18 = 0;
              uStack_10 = 0;
              InfoController.AddInfoTab
                        (lVar1,uVar4,"IconAtlas",uVar3,"Woosh",0x3f800000,0x40a00000,&local_18,0);
              return;
            }
          }
        }
    }

    // Token : 0x6001026
    // RVA   : 0xB36920   Offset: 0xB35D20   Length: 0x5AC
    public void SetForceJob(int jobType, int jobID, HeroData targetHero)
    {
        long lVar1;
        long lVar3;
        long lVar4;
        long lVar5;
        uint uVar6;
        if (targetHero != null) {
          *(uint32 *)(targetHero + 144) = jobType;
          *(uint32 *)(targetHero + 148) = jobID;
          *(uint32 *)(targetHero + 152) = 60;
          *(uint8 *)(targetHero + 0x2d8) = 1;
        }
        if ((this.forceJobSettingData != null) &&
           (lVar5 = this.forceJobSettingData.ForceJobs) != null) {
          if (lVar5.ForceJobs <= jobType) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar1 = (int64)(int)jobType + 4;
          lVar5 = *(int64 *)(lVar5.emptyNum + lVar1 * 8);
          if (lVar5 != null) {
            if (lVar5.ForceJobs <= jobID) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar3 = (int64)(int)jobID * 4 + 32;
            uVar6 = 0xffffffff;
            if (*(int *)(lVar3 + lVar5.emptyNum) != -1) {
              if (GameController._instance == null) throw; // [null/range check failed]
              lVar5 = GameController._instance.worldData;
              if ((this.forceJobSettingData == null) ||
                 (lVar4 = this.forceJobSettingData.ForceJobs) == null)
              throw; // [null/range check failed]
              if (*(uint32 *)(lVar4 + 24) <= jobType) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar4 = *(int64 *)(*(int64 *)(lVar4 + 16) + lVar1 * 8);
              if (lVar4 == null) throw; // [null/range check failed]
              if (*(uint32 *)(lVar4 + 24) <= jobID) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              if (lVar5 == null) throw; // [null/range check failed]
              lVar5 = WorldData.GetHero(lVar5,*(uint32 *)(lVar3 + *(int64 *)(lVar4 + 16)),0);
              if (lVar5 == null) throw; // [null/range check failed]
              lVar5.MailDatas = 0xffffffff;
              if (GameController._instance == null) throw; // [null/range check failed]
              lVar5 = GameController._instance.worldData;
              if ((this.forceJobSettingData == null) ||
                 (lVar4 = this.forceJobSettingData.ForceJobs) == null)
              throw; // [null/range check failed]
              if (*(uint32 *)(lVar4 + 24) <= jobType) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar4 = *(int64 *)(*(int64 *)(lVar4 + 16) + lVar1 * 8);
              if (lVar4 == null) throw; // [null/range check failed]
              if (*(uint32 *)(lVar4 + 24) <= jobID) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              if (lVar5 == null) throw; // [null/range check failed]
              lVar5 = WorldData.GetHero(lVar5,*(uint32 *)(lVar3 + *(int64 *)(lVar4 + 16)),0);
              if (lVar5 == null) throw; // [null/range check failed]
              *(uint32 *)(lVar5 + 148) = 0xffffffff;
              if (GameController._instance == null) throw; // [null/range check failed]
              lVar5 = GameController._instance.worldData;
              if ((this.forceJobSettingData == null) ||
                 (lVar4 = this.forceJobSettingData.ForceJobs) == null)
              throw; // [null/range check failed]
              if (*(uint32 *)(lVar4 + 24) <= jobType) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar4 = *(int64 *)(*(int64 *)(lVar4 + 16) + lVar1 * 8);
              if (lVar4 == null) throw; // [null/range check failed]
              if (*(uint32 *)(lVar4 + 24) <= jobID) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              if (lVar5 == null) throw; // [null/range check failed]
              lVar5 = WorldData.GetHero(lVar5,*(uint32 *)(lVar3 + *(int64 *)(lVar4 + 16)),0);
              if (lVar5 == null) throw; // [null/range check failed]
              lVar5.cheating = 0;
              if (GameController._instance == null) throw; // [null/range check failed]
              lVar5 = GameController._instance.worldData;
              if ((this.forceJobSettingData == null) ||
                 (lVar4 = this.forceJobSettingData.ForceJobs) == null)
              throw; // [null/range check failed]
              if (*(uint32 *)(lVar4 + 24) <= jobType) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar4 = *(int64 *)(*(int64 *)(lVar4 + 16) + lVar1 * 8);
              if (lVar4 == null) throw; // [null/range check failed]
              if (*(uint32 *)(lVar4 + 24) <= jobID) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              if (lVar5 == null) throw; // [null/range check failed]
              lVar5 = WorldData.GetHero(lVar5,*(uint32 *)(lVar3 + *(int64 *)(lVar4 + 16)),0);
              if (lVar5 == null) throw; // [null/range check failed]
              *(uint8 *)(lVar5 + 0x2d8) = 1;
            }
            lVar5 = this.forceJobSettingData;
            if (targetHero == null) {
              if ((lVar5 = lVar5?.ForceJobs) == null) throw; // [null/range check failed]
              if (lVar5.ForceJobs <= jobType) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar5 = *(int64 *)(lVar5.emptyNum + lVar1 * 8);
              if (lVar5 == null) throw; // [null/range check failed]
              if (lVar5.ForceJobs <= jobID) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              if (*(int *)(lVar3 + lVar5.emptyNum) != -1) {
                if (this.forceJobSettingData == null) throw; // [null/range check failed]
                this.forceJobSettingData.emptyNum = *piVar2 + 1;
              }
            }
            else {
              if ((lVar5 = lVar5?.ForceJobs) == null) throw; // [null/range check failed]
              if (lVar5.ForceJobs <= jobType) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar5 = *(int64 *)(lVar5.emptyNum + lVar1 * 8);
              if (lVar5 == null) throw; // [null/range check failed]
              if (lVar5.ForceJobs <= jobID) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              if (*(int *)(lVar3 + lVar5.emptyNum) == -1) {
                if (this.forceJobSettingData == null) throw; // [null/range check failed]
                this.forceJobSettingData.emptyNum = *piVar2 + -1;
              }
            }
            if ((this.forceJobSettingData != null) &&
               (lVar5 = this.forceJobSettingData.ForceJobs) != null) {
              if (lVar5.ForceJobs <= jobType) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar5 = *(int64 *)(lVar5.emptyNum + lVar1 * 8);
              if (targetHero != null) {
                uVar6 = *(uint32 *)(targetHero + 88);
              }
              if (lVar5 != null) {
                FUN_181833d40(lVar5,jobID,uVar6,DAT_181d8fb18);
                this.forceDetailDirty = 0x101;
                return;
              }
            }
          }
        }
    }

    // Token : 0x6001027
    // RVA   : 0xB33DA0   Offset: 0xB331A0   Length: 0x19
    public float GetForceJobExtraExpRate()
    {
        return (float)this.forceLv * 0.1 + 0.5;
    }

    // Token : 0x6001028
    // RVA   : 0xB33D90   Offset: 0xB33190   Length: 0x7
    public int GetForceJobExtraAttriNum()
    {
        return this.forceLv + 5;
    }

    // Token : 0x6001029
    // RVA   : 0xB35060   Offset: 0xB34460   Length: 0xFD
    public HeroData GetOwnHero(int id)
    {
        long lVar1;
        long lVar2;
        if (GameController._instance != null) {
          lVar1 = this.ownHeros;
          lVar2 = GameController._instance.worldData;
          if (lVar1 != null) {
            if (lVar1.Count <= id) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            if (lVar2 != null) {
              WorldData.GetHero(lVar2,*(uint32 *)
                                        (lVar1._items + 32 + (int64)(int)id * 4),
                                 0);
              return;
            }
          }
        }
    }

    // Token : 0x600102A
    // RVA   : 0xB35160   Offset: 0xB34560   Length: 0x1BA
    public List<HeroData> GetOwnHeros()
    {
        long lVar1;
        long lVar2;
        ulong uVar3;
        long lVar4;
        uint uVar5;
        long lVar6;
        lVar2 = il2cpp_internal(DAT_181d93350);
        FUN_18132faf0(lVar2,DAT_181d8b418);
        lVar4 = this.ownHeros;
        uVar5 = 0;
        if (lVar4 != null) {
          lVar6 = 32;
          while( true ) {
            if (lVar4.Count <= (int)uVar5) {
              return lVar2;
            }
            if (GameController._instance == null) break;
            lVar4 = this.ownHeros;
            lVar1 = GameController._instance.worldData;
            if (lVar4 == null) break;
            if (lVar4.Count <= uVar5) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            if ((lVar1 == null) ||
               (uVar3 = WorldData.GetHero(lVar1,*(uint32 *)(lVar6 + lVar4._items),0),
               lVar2 == null)) break;
            FUN_18181e0a0(lVar2,uVar3);
            lVar4 = this.ownHeros;
            uVar5 = uVar5 + 1;
            lVar6 = lVar6 + 4;
            if (lVar4 == null) break;
          }
        }
    }

    // Token : 0x600102B
    // RVA   : 0xB32BE0   Offset: 0xB31FE0   Length: 0x28C
    public List<HeroData> FindAllHero(int minForceLv, int maxForceLv, bool noLeader, bool noJob, bool noPlayer, bool noPrison, bool noSpe)
    {
        int64 ForceData.FindAllHero
                         (int64 this,int minForceLv,int maxForceLv,char noLeader,char noJob,char noPlayer,
                         char noPrison,char noSpe)
        {
        char cVar1;
        int iVar2;
        int64 lVar3;
        int64 lVar4;
        uint64 uVar5;
        int iVar6;
        lVar3 = il2cpp_internal(DAT_181d93350);
        FUN_18132faf0(lVar3,DAT_181d8b418);
        iVar6 = 0;
        lVar4 = this.ownHeros;
        while (lVar4 != null) {
          if (lVar4.ForceJobs <= iVar6) {
            return lVar3;
          }
          if (minForceLv == -1) {
        LAB_180b32cc2:
            if (maxForceLv != -1) {
              lVar4 = ForceData.GetOwnHero(this,iVar6,0);
              if (lVar4 == null) break;
              if (maxForceLv < *(int *)(lVar4 + 184)) goto LAB_180b32e36;
            }
            if (!noJob) {
        LAB_180b32d46:
              if (noLeader) {
                lVar4 = ForceData.GetOwnHero(this,iVar6,0);
                if (lVar4 == null) break;
                if (*(char *)(lVar4 + 180) != false) goto LAB_180b32e36;
              }
              if (noPlayer) {
                if (this.ownHeros == null) break;
                iVar2 = FUN_1800d6760(this.ownHeros,iVar6);
                if (iVar2 == 0) goto LAB_180b32e36;
              }
              if (noPrison) {
                lVar4 = ForceData.GetOwnHero(this,iVar6,0);
                if (lVar4 == null) break;
                if (*(char *)(lVar4 + 209) != false) goto LAB_180b32e36;
              }
              if (noSpe) {
                lVar4 = ForceData.GetOwnHero(this,iVar6,0);
                if (lVar4 == null) break;
                if (*(char *)(lVar4 + 92) != false) goto LAB_180b32e36;
              }
              lVar4 = ForceData.GetOwnHero(this,iVar6,0);
              if (lVar4 == null) break;
              if (*(char *)(lVar4 + 96) == false) {
                lVar4 = ForceData.GetOwnHero(this,iVar6,0);
                if (lVar4 == null) break;
                if (*(char *)(lVar4 + 97) == false) {
                  uVar5 = ForceData.GetOwnHero(this,iVar6,0);
                  if (lVar3 == null) break;
                  FUN_18181e0a0(lVar3,uVar5);
                }
              }
            }
            else {
              lVar4 = this.forceJobSettingData;
              uVar5 = ForceData.GetOwnHero(this,iVar6,0);
              if (lVar4 == null) break;
              cVar1 = ForceJobSettingData.HaveHero(lVar4,uVar5);
              if (!cVar1) {
                lVar4 = ForceData.GetOwnHero(this,iVar6,0);
                if (lVar4 == null) break;
                if (*(int *)(lVar4 + 156) == -1) goto LAB_180b32d46;
              }
            }
          }
          else {
            lVar4 = ForceData.GetOwnHero(this,iVar6,0);
            if (lVar4 == null) break;
            if (minForceLv <= *(int *)(lVar4 + 184)) goto LAB_180b32cc2;
          }
        LAB_180b32e36:
          iVar6 = iVar6 + 1;
          lVar4 = this.ownHeros;
        }
    }

    // Token : 0x600102C
    // RVA   : 0xB33780   Offset: 0xB32B80   Length: 0x13B
    public float GetChangeAllAreaState(AreaStateType areaStateType)
    {
        long lVar1;
        ulong uVar2;
        ulong uVar3;
        uint[] local_res10 = new uint[2];
        uVar2 = DAT_181db8bb8;
        lVar1 = this.forceSpeAddData;
        uVar2 = Type.GetTypeFromHandle(uVar2,0);
        local_res10[0] = areaStateType;
        uVar3 = Int32.ToString(local_res10,0);
        uVar3 = String.Concat("ChangeAllAreaState",uVar3,0);
        plVar4 = (int64 *)Enum.Parse(uVar2,uVar3,0);
        if ((lVar1 != null) && (plVar4 != (int64 *)0)) {
          if (*(int64 *)(*plVar4 + 64) == *(int64 *)(DAT_181d80418 + 64)) {
            puVar5 = (uint32 *)il2cpp_object_unbox();
            ForceSpeAddData.Get(lVar1,*puVar5,0);
            return;
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6070(plVar4,DAT_181d80418);
        }
    }

    // Token : 0x600102D
    // RVA   : 0xB35F40   Offset: 0xB35340   Length: 0xBE
    public AreaData MainArea()
    {
        long lVar1;
        if ((GameController._instance != null) &&
           (lVar1 = GameController._instance.worldData) != null) {
          WorldData.GetArea(lVar1,this.mainAreaID,0);
          return;
        }
    }

    // Token : 0x600102E
    // RVA   : 0xB34FE0   Offset: 0xB343E0   Length: 0x73
    public ForceTechLvData GetNowResearchTech()
    {
        uint uVar1;
        long lVar2;
        uVar1 = this.nowResearchTech;
        if (uVar1 == 0xffffffff) {
          return 0;
        }
        lVar2 = this.techLvData;
        if (lVar2 != null) {
          if (lVar2.Count <= uVar1) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          return lVar2._items[uVar1];
        }
    }

    // Token : 0x600102F
    // RVA   : 0xB37D10   Offset: 0xB37110   Length: 0x47B
    public void UpgradeNowResearch(bool showInfo)
    {
        var pStatics_f6a8 = *(int64*)(DAT_181d7f6a8 + 184);
        float fVar1;
        uint uVar2;
        ulong uVar3;
        bool cVar4;
        long lVar5;
        long lVar6;
        ulong uVar7;
        ulong uVar8;
        float fVar9;
        uint[] local_res20 = new uint[2];
        ulong local_48;
        ulong uStack_40;
        lVar5 = ForceData.GetNowResearchTech(this,0);
        if (lVar5 != null) {
          lVar5.cityAreaID = 0;
          lVar5 = ForceData.GetNowResearchTech(this,0);
          if (lVar5 != null) {
            *(int *)(lVar5 + 20) = *(int *)(lVar5 + 20) + 1;
            lVar5 = this.techSpeAddData;
            lVar6 = ForceData.GetNowResearchTech(this,0);
            if (lVar6 != null) {
              lVar6 = ForceTechLvData.Database(lVar6,0);
              if (lVar6 != null) {
                uVar2 = *(uint32 *)(lVar6 + 44);
                lVar6 = ForceData.GetNowResearchTech(this,0);
                if (lVar6 != null) {
                  lVar6 = ForceTechLvData.Database(lVar6,0);
                  if (lVar6 != null) {
                    fVar1 = *(float *)(lVar6 + 48);
                    lVar6 = ForceData.GetNowResearchTech(this,0);
                    if (lVar6 != null) {
                      lVar6 = ForceTechLvData.Database(lVar6,0);
                      if (lVar6 != null) {
                        if (*(char *)(lVar6 + 52) == false) {
                          lVar6 = ForceData.GetNowResearchTech(this,0);
                          if (lVar6 == null) throw; // [null/range check failed]
                          fVar9 = (float)*(int *)(lVar6 + 20);
                        }
                        else {
                          fVar9 = 1.0;
                        }
                        if (lVar5 != null) {
                          ForceSpeAddData.Change(lVar5,uVar2,fVar1 * fVar9,0);
                          if (!showInfo) {
        LAB_180b38140:
                            this.forceDetailDirty = 0x101;
                            this.nowResearchTech = 0xffffffff;
                            return;
                          }
                          cVar4 = FUN_180d755b0(this.forceSetName,0);
                          if (!cVar4) {
                            uVar8 = this.forceSetName;
                          }
                          else {
                            uVar8 = this.forceName;
                          }
                          lVar5 = ForceData.GetNowResearchTech(this,0);
                          if (lVar5 != null) {
                            lVar5 = ForceTechLvData.Database(lVar5,0);
                            if (lVar5 != null) {
                              uVar3 = lVar5.cityAreaID;
                              lVar5 = ForceData.GetNowResearchTech(this,0);
                              if (lVar5 != null) {
                                local_res20[0] = *(uint32 *)(lVar5 + 20);
                                uVar7 = il2cpp_value_box(DAT_181d80418,local_res20);
                                uVar8 = String.Format("{0}完成研究[{1}Lv{2}]！",uVar8,uVar3,uVar7,0);
                                if ((GameController._instance != null) &&
                                   (lVar5 = GameController._instance.worldData,
                                   lVar5 != null)) {
                                  lVar5 = WorldData.Player(lVar5,0);
                                  if (lVar5 != null) {
                                    if (*(int *)(lVar5 + 132) == this.forceID) {
                                      if (*pStatics_f6a8 == 0) throw; // [null/range check failed]
                                      local_48 = 0;
                                      uStack_40 = 0;
                                      InfoController.AddInfoTab
                                                (*pStatics_f6a8,uVar8,"UIAtlas"
                                                 ,"从事工作_探索","NoticeLittle",0x3f800000,0x40a00000,
                                                 &local_48,0);
                                    }
                                    lVar5 = *pStatics_f6a8;
                                    if ((GameController._instance != null) &&
                                       (lVar6 = *(int64 *)
                                                 (GameController._instance + 32),
                                       lVar6 != null)) {
                                      lVar6 = WorldData.Player(lVar6,0);
                                      if ((lVar6 != null) && (lVar5 != null)) {
                                        InfoController.AddInfo
                                                  (lVar5,*(int *)(lVar6 + 132) ==
                                                         this.forceID,uVar8,0);
                                        goto LAB_180b38140;
                                      }
                                    }
                                    throw; // [null/range check failed]
                                  }
                                }
                              }
                            }
                          }
                          // WARNING: Subroutine does not return
                          FUN_1800d6620();
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

    // Token : 0x6001030
    // RVA   : 0xB37840   Offset: 0xB36C40   Length: 0x358
    public void SetNowResearch(ForceTechLvData targetTech, bool showInfo)
    {
        var pStatics_f6a8 = *(int64*)(DAT_181d7f6a8 + 184);
        ulong uVar1;
        bool cVar2;
        long lVar3;
        ulong uVar4;
        ulong uVar5;
        long lVar6;
        uint[] local_res10 = new uint[2];
        ulong local_18;
        ulong uStack_10;
        if (targetTech == null) {
        LAB_180b37b8d:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        this.nowResearchTech = *(uint32 *)(targetTech + 16);
        if (!showInfo) {
          return;
        }
        cVar2 = FUN_180d755b0(this.forceSetName,0);
        if (!cVar2) {
          uVar5 = this.forceSetName;
        }
        else {
          uVar5 = this.forceName;
        }
        lVar3 = ForceData.GetNowResearchTech(this,0);
        if ((lVar3 != null) && (lVar3 = ForceTechLvData.Database(lVar3,0)) != null) {
          uVar1 = lVar3.cityAreaID;
          lVar3 = ForceData.GetNowResearchTech(this,0);
          if (lVar3 != null) {
            local_res10[0] = *(uint32 *)(lVar3 + 20);
            uVar4 = il2cpp_value_box(DAT_181d80418,local_res10);
            uVar5 = String.Format("{0}开始研究[{1}Lv{2}]！",uVar5,uVar1,uVar4,0);
            if (((GameController._instance != null) &&
                (lVar3 = GameController._instance.worldData) != null) &&
               (lVar3 = WorldData.Player(lVar3,0)) != null) {
              if (*(int *)(lVar3 + 132) == this.forceID) {
                if (*pStatics_f6a8 == 0) goto LAB_180b37b8d;
                local_18 = 0;
                uStack_10 = 0;
                InfoController.AddInfoTab
                          (*pStatics_f6a8,uVar5,"UIAtlas","从事工作_探索",
                           "NoticeLittle",0x3f800000,0x40a00000,&local_18,0);
              }
              lVar3 = *pStatics_f6a8;
              if ((((GameController._instance != null) &&
                   (lVar6 = GameController._instance.worldData) != null) &&
                  (lVar6 = WorldData.Player(lVar6,0)) != null) && (lVar3 != null)) {
                InfoController.AddInfo(lVar3,*(int *)(lVar6 + 132) == this.forceID,uVar5,0);
                return;
              }
              goto LAB_180b37b8d;
            }
          }
        }
    }

    // Token : 0x6001031
    // RVA   : 0xB31260   Offset: 0xB30660   Length: 0x67
    public bool AreaNotFull()
    {
        int iVar1;
        float extraout_XMM0_Da;
        if ((this.ownAreasID != null) && (this.forceSpeAddData != null)) {
          iVar1 = this.ownAreasID.Count;
          ForceSpeAddData.Get(this.forceSpeAddData,0,0);
          return (float)iVar1 < extraout_XMM0_Da;
        }
    }

    // Token : 0x6001032
    // RVA   : 0xB34F80   Offset: 0xB34380   Length: 0x23
    public float GetMaxAreaNum()
    {
        if (this.forceSpeAddData != null) {
          ForceSpeAddData.Get(this.forceSpeAddData,0,0);
          return;
        }
    }

    // Token : 0x6001033
    // RVA   : 0xB36500   Offset: 0xB35900   Length: 0x43
    public bool PopulationNotFull()
    {
        int iVar1;
        float extraout_XMM0_Da;
        iVar1 = this.totalPopulation;
        if (this.forceSpeAddData != null) {
          ForceSpeAddData.Get(this.forceSpeAddData,1);
          return (float)iVar1 < extraout_XMM0_Da;
        }
    }

    // Token : 0x6001034
    // RVA   : 0xB34FB0   Offset: 0xB343B0   Length: 0x25
    public float GetMaxHeroNum()
    {
        if (this.forceSpeAddData != null) {
          ForceSpeAddData.Get(this.forceSpeAddData,1);
          return;
        }
    }

    // Token : 0x6001035
    // RVA   : 0xB37BA0   Offset: 0xB36FA0   Length: 0x163
    public void UpgradeForceFavorDict()
    {
        long lVar1;
        bool cVar2;
        long lVar3;
        int iVar4;
        uint uVar5;
        lVar3 = this.forceFavor;
        if ((lVar3 == null) || (lVar3.Count < 1)) {
          return;
        }
        iVar4 = 0;
        while( true ) {
          if (lVar3.Count <= iVar4) {
            FUN_1812f9a10(lVar3,DAT_181da0e78);
            return;
          }
          if (this.forceFavorDict == null) break;
          cVar2 = FUN_1808ab490(this.forceFavorDict,iVar4,DAT_181dbde60);
          lVar3 = this.forceFavorDict;
          lVar1 = this.forceFavor;
          if (!cVar2) {
            if ((lVar1 == null) || (uVar5 = FUN_1800d6790(lVar1,iVar4,DAT_181da1078), lVar3 == null)) break;
            FUN_1817af4f0(lVar3,iVar4,uVar5,DAT_181dbdd50);
          }
          else {
            if ((lVar1 == null) || (uVar5 = FUN_1800d6790(lVar1,iVar4,DAT_181da1078), lVar3 == null)) break;
            FUN_1817c6620(lVar3,iVar4,uVar5,DAT_181dbe540);
          }
          lVar3 = this.forceFavor;
          iVar4 = iVar4 + 1;
          if (lVar3 == null) break;
        }
    }

    // Token : 0x6001036
    // RVA   : 0xB368F0   Offset: 0xB35CF0   Length: 0x22
    public void SetForceFavor(ForceFavorSettingData setting)
    {
        bool cVar1;
        long lVar2;
        ForceData.UpgradeForceFavorDict(this,0);
        if (this.forceFavorDict != null) {
          cVar1 = FUN_1808ab490(this.forceFavorDict,setting,DAT_181dbde60);
          lVar2 = this.forceFavorDict;
          if (!cVar1) {
            if (lVar2 == null) throw; // [null/range check failed]
            FUN_1817af4f0(lVar2,setting,param_3,DAT_181dbdd50);
          }
          else {
            if (lVar2 == null) throw; // [null/range check failed]
            FUN_1817c6620(lVar2,setting,param_3,DAT_181dbe540);
          }
          if ((GameController._instance != null) &&
             (lVar2 = GameController._instance.worldData) != null) {
            lVar2 = WorldData.GetForce(lVar2,setting,0);
            if ((lVar2 != null) && (lVar2.plotHappened != null)) {
              cVar1 = FUN_1808ab490(lVar2.plotHappened,this.forceID,
                                    DAT_181dbde60);
              if (!cVar1) {
                if ((GameController._instance != null) &&
                   (lVar2 = GameController._instance.worldData) != null) {
                  lVar2 = WorldData.GetForce(lVar2,setting,0);
                  if ((lVar2 != null) && (lVar2.plotHappened != null)) {
                    FUN_1817af4f0(lVar2.plotHappened,this.forceID,param_3,
                                  DAT_181dbdd50);
                    return;
                  }
                }
              }
              else {
                if ((GameController._instance != null) &&
                   (lVar2 = GameController._instance.worldData) != null) {
                  lVar2 = WorldData.GetForce(lVar2,setting,0);
                  if ((lVar2 != null) && (lVar2.plotHappened != null)) {
                    FUN_1817c6620(lVar2.plotHappened,this.forceID,param_3,
                                  DAT_181dbe540);
                    return;
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6001037
    // RVA   : 0xB365D0   Offset: 0xB359D0   Length: 0x314
    public void SetForceFavor(int id, float favor)
    {
        bool cVar1;
        long lVar2;
        ForceData.UpgradeForceFavorDict(this,0);
        if (this.forceFavorDict != null) {
          cVar1 = FUN_1808ab490(this.forceFavorDict,id,DAT_181dbde60);
          lVar2 = this.forceFavorDict;
          if (!cVar1) {
            if (lVar2 == null) throw; // [null/range check failed]
            FUN_1817af4f0(lVar2,id,favor,DAT_181dbdd50);
          }
          else {
            if (lVar2 == null) throw; // [null/range check failed]
            FUN_1817c6620(lVar2,id,favor,DAT_181dbe540);
          }
          if ((GameController._instance != null) &&
             (lVar2 = GameController._instance.worldData) != null) {
            lVar2 = WorldData.GetForce(lVar2,id,0);
            if ((lVar2 != null) && (lVar2.plotHappened != null)) {
              cVar1 = FUN_1808ab490(lVar2.plotHappened,this.forceID,
                                    DAT_181dbde60);
              if (!cVar1) {
                if ((GameController._instance != null) &&
                   (lVar2 = GameController._instance.worldData) != null) {
                  lVar2 = WorldData.GetForce(lVar2,id,0);
                  if ((lVar2 != null) && (lVar2.plotHappened != null)) {
                    FUN_1817af4f0(lVar2.plotHappened,this.forceID,favor,
                                  DAT_181dbdd50);
                    return;
                  }
                }
              }
              else {
                if ((GameController._instance != null) &&
                   (lVar2 = GameController._instance.worldData) != null) {
                  lVar2 = WorldData.GetForce(lVar2,id,0);
                  if ((lVar2 != null) && (lVar2.plotHappened != null)) {
                    FUN_1817c6620(lVar2.plotHappened,this.forceID,favor,
                                  DAT_181dbe540);
                    return;
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6001038
    // RVA   : 0xB31B40   Offset: 0xB30F40   Length: 0x557
    public void ChangeForceFavor(int id, float favor, bool showInfo)
    {
        var pStatics = *(int64*)(DAT_181d73d40 + 184);
        long lVar1;
        ulong uVar2;
        bool cVar3;
        long lVar5;
        long lVar6;
        ulong uVar7;
        ulong uVar8;
        ulong uVar9;
        float fVar10;
        uint uVar11;
        uint local_48;
        uint uStack_44;
        uint uStack_40;
        uint32 uStack_3c;
        if ((-1 < id) && (favor != null.0)) {
          ForceData.UpgradeForceFavorDict(this,0);
          fVar10 = (float)ForceData.GetForceFavor(this,id,0);
          uVar11 = FUN_1810e36c0(fVar10 + favor,0,0x42c80000,0);
          ForceData.SetForceFavor(this,id,uVar11,0);
          if (showInfo) {
            lVar1 = **(int64 **)(DAT_181d7f6a8 + 184);
            plVar4 = (int64 *)FUN_1800d60b0(DAT_181da5ce0,5);
            cVar3 = FUN_180d755b0(this.forceSetName,0);
            if (!cVar3) {
              lVar6 = this.forceSetName;
            }
            else {
              lVar6 = this.forceName;
            }
            if (plVar4 == (int64 *)0) {
        LAB_180b31ff2:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            if ((lVar6 != null) &&
               (lVar5 = il2cpp_internal(lVar6,*(uint64 *)(*plVar4 + 64))) == null) {
              uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar9,0);
            }
            if ((int)plVar4[3] == 0) {
              uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar9,0);
            }
            plVar4[4] = lVar6;
            il2cpp_internal(plVar4 + 4,lVar6);
            if (("与" != 0) &&
               (lVar6 = il2cpp_internal("与",*(uint64 *)(*plVar4 + 64))) == null) {
              uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar9,0);
            }
            lVar6 = "与";
            if (*(uint32 *)(plVar4 + 3) < 2) {
              uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar9,0);
            }
            plVar4[5] = "与";
            il2cpp_internal(plVar4 + 5,lVar6);
            lVar6 = FUN_18046c0a0(0);
            if (((lVar6 == null) || (*(int64 *)(lVar6 + 32) == 0)) ||
               (lVar6 = WorldData.GetForce(*(int64 *)(lVar6 + 32),id,0)) == null)
            goto LAB_180b31ff2;
            cVar3 = FUN_180d755b0(*(uint64 *)(lVar6 + 0x198),0);
            if (!cVar3) {
              lVar6 = *(int64 *)(lVar6 + 0x198);
            }
            else {
              lVar6 = *(int64 *)(lVar6 + 24);
            }
            if ((lVar6 != null) &&
               (lVar5 = il2cpp_internal(lVar6,*(uint64 *)(*plVar4 + 64))) == null) {
              uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar9,0);
            }
            if (*(uint32 *)(plVar4 + 3) < 3) {
              uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar9,0);
            }
            plVar4[6] = lVar6;
            il2cpp_internal(plVar4 + 6,lVar6);
            if (("的" != 0) &&
               (lVar6 = il2cpp_internal("的",*(uint64 *)(*plVar4 + 64))) == null) {
              uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar9,0);
            }
            lVar6 = "的";
            if (*(uint32 *)(plVar4 + 3) < 4) {
              uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar9,0);
            }
            plVar4[7] = "的";
            il2cpp_internal(plVar4 + 7,lVar6);
            lVar6 = GlobalData.GenerateChangeColorText("关系",favor,0);
            if ((lVar6 != null) &&
               (lVar5 = il2cpp_internal(lVar6,*(uint64 *)(*plVar4 + 64))) == null) {
              uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar9,0);
            }
            if (*(uint32 *)(plVar4 + 3) < 5) {
              uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar9,0);
            }
            plVar4[8] = lVar6;
            il2cpp_internal(plVar4 + 8,lVar6);
            uVar7 = String.Concat(plVar4,0);
            uVar2 = "UIAtlas";
            uVar9 = "友善度";
            if (favor <= 0.0) {
              lVar6 = pStatics;
              local_48 = *(uint32 *)(lVar6 + 0x2f0);
              uStack_44 = *(uint32 *)(lVar6 + 0x2f4);
              uStack_40 = *(uint32 *)(lVar6 + 0x2f8);
              uStack_3c = *(uint32 *)(lVar6 + 0x2fc);
            }
            else {
              lVar6 = pStatics;
              local_48 = *(uint32 *)(lVar6 + 0x288);
              uStack_44 = *(uint32 *)(lVar6 + 0x28c);
              uStack_40 = *(uint32 *)(lVar6 + 0x290);
              uStack_3c = *(uint32 *)(lVar6 + 0x294);
            }
            uVar8 = "FameDown";
            if (0.0 < favor) {
              uVar8 = "FameUp";
            }
            if (lVar1 == null) goto LAB_180b31ff2;
            InfoController.AddInfoTab(lVar1,uVar7,uVar2,uVar9,uVar8,0x3f800000,0x40a00000,&local_48,0);
          }
          cVar3 = ForceData.IsAllyForce(this,id,0);
          if ((cVar3) &&
             (fVar10 = (float)ForceData.GetForceFavor(this,id,0), fVar10 < 80.0)) {
            ForceData.BreakAllyForce(this,id,1,1,0);
          }
        }
    }

    // Token : 0x6001039
    // RVA   : 0xB33AB0   Offset: 0xB32EB0   Length: 0x13B
    public float GetForceFavor(int forceID)
    {
        long lVar1;
        bool cVar2;
        uint uVar3;
        ulong uVar4;
        ForceData.UpgradeForceFavorDict(this,0);
        if ((forceID == -1) || (forceID == -2)) {
          return 0;
        }
        if (this.masterForce == forceID) {
          return 0x42c80000;
        }
        if (this.servantForce != null) {
          cVar2 = FUN_18182a3a0(this.servantForce,forceID,DAT_181d8f398);
          if (cVar2) {
            return 0x42c80000;
          }
          if (this.forceFavorDict != null) {
            cVar2 = FUN_1808ab490(this.forceFavorDict,forceID,DAT_181dbde60);
            if (!cVar2) {
              lVar1 = this.forceFavorDict;
              uVar3 = ForceData.GetForceStartFavor(this,forceID,0);
              if (lVar1 == null) throw; // [null/range check failed]
              FUN_1817af4f0(lVar1,forceID,uVar3,DAT_181dbdd50);
            }
            if (this.forceFavorDict != null) {
              uVar4 = FUN_1817d9cd0(this.forceFavorDict,forceID,DAT_181dbe430);
              return uVar4;
            }
          }
        }
    }

    // Token : 0x600103A
    // RVA   : 0xB34100   Offset: 0xB33500   Length: 0x2FF
    public float GetForceStartFavor(int targetForceID)
    {
        bool cVar1;
        long lVar2;
        lVar2 = this.forceStyle;
        if (lVar2 == null) {
          return 0x42480000;
        }
        cVar1 = FUN_18171e540(lVar2,"仁义",0);
        if (!cVar1) {
          cVar1 = FUN_18171e540(lVar2,"中庸",0);
          if (!cVar1) {
            cVar1 = FUN_18171e540(lVar2,"霸业",0);
            if (!cVar1) {
              return 0x42480000;
            }
            lVar2 = FUN_18046c0a0(0);
            if (((lVar2 != null) && (*(int64 *)(lVar2 + 32) != 0)) &&
               (lVar2 = WorldData.GetForce(*(int64 *)(lVar2 + 32),targetForceID,0)) != null) {
              lVar2 = *(int64 *)(lVar2 + 40);
              if (lVar2 == null) {
                return 0x42480000;
              }
              cVar1 = FUN_18171e540(lVar2,"仁义",0);
              if (cVar1) {
                return 0x42200000;
              }
              cVar1 = FUN_18171e540(lVar2,"中庸",0);
              if (cVar1) {
                return 0x42480000;
              }
              cVar1 = FUN_18171e540(lVar2,"霸业",0);
              if (cVar1) {
                return 0x42700000;
              }
              return 0x42480000;
            }
          }
          else {
            lVar2 = FUN_18046c0a0(0);
            if (((lVar2 != null) && (*(int64 *)(lVar2 + 32) != 0)) &&
               (lVar2 = WorldData.GetForce(*(int64 *)(lVar2 + 32),targetForceID,0)) != null) {
              lVar2 = *(int64 *)(lVar2 + 40);
              if (lVar2 == null) {
                return 0x42480000;
              }
              cVar1 = FUN_18171e540(lVar2,"仁义",0);
              if (!cVar1) {
                cVar1 = FUN_18171e540(lVar2,"中庸",0);
                if (cVar1) {
                  return 0x425c0000;
                }
                FUN_18171e540(lVar2,"霸业",0);
                return 0x42480000;
              }
              return 0x42480000;
            }
          }
        }
        else {
          lVar2 = FUN_18046c0a0(0);
          if (((lVar2 != null) && (*(int64 *)(lVar2 + 32) != 0)) &&
             (lVar2 = WorldData.GetForce(*(int64 *)(lVar2 + 32),targetForceID,0)) != null) {
            lVar2 = *(int64 *)(lVar2 + 40);
            if (lVar2 == null) {
              return 0x42480000;
            }
            cVar1 = FUN_18171e540(lVar2,"仁义",0);
            if (cVar1) {
              return 0x42700000;
            }
            cVar1 = FUN_18171e540(lVar2,"中庸",0);
            if (cVar1) {
              return 0x42480000;
            }
            cVar1 = FUN_18171e540(lVar2,"霸业",0);
            if (cVar1) {
              return 0x42200000;
            }
            return 0x42480000;
          }
        }
    }

    // Token : 0x600103B
    // RVA   : 0xB339F0   Offset: 0xB32DF0   Length: 0xB1
    public float GetForceFavorRate(ForceData targetForce)
    {
        bool cVar1;
        if (targetForce != null) {
          cVar1 = FUN_18171e540(*(uint64 *)(targetForce + 40),"中庸",0);
          if (!cVar1) {
            cVar1 = FUN_18171e540(this.forceStyle,"中庸",0);
            if (!cVar1) {
              cVar1 = FUN_18171e540(*(uint64 *)(targetForce + 40),this.forceStyle,0);
              if (!cVar1) {
                return 0x3f000000;
              }
              return 0x3f800000;
            }
          }
          return 0x3f4ccccd;
        }
    }

    // Token : 0x600103C
    // RVA   : 0xB35CD0   Offset: 0xB350D0   Length: 0x22
    public bool HaveResource(ResourceData resource)
    {
        long lVar1;
        if (param_3 <= 0.0) {
          return true;
        }
        lVar1 = this.resourceStore;
        if (lVar1 != null) {
          if (lVar1.Count <= resource) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          return param_3 <= lVar1._items[resource];
        }
    }

    // Token : 0x600103D
    // RVA   : 0xB35AB0   Offset: 0xB34EB0   Length: 0xA6
    public bool HaveResource(List<float> resourceList)
    {
        long lVar1;
        if (param_3 <= 0.0) {
          return true;
        }
        lVar1 = this.resourceStore;
        if (lVar1 != null) {
          if (lVar1.Count <= resourceList) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          return param_3 <= lVar1._items[resourceList];
        }
    }

    // Token : 0x600103E
    // RVA   : 0xB35BF0   Offset: 0xB34FF0   Length: 0xD5
    public bool HaveResource(List<ResourceData> resourceList)
    {
        long lVar1;
        if (param_3 <= 0.0) {
          return true;
        }
        lVar1 = this.resourceStore;
        if (lVar1 != null) {
          if (lVar1.Count <= resourceList) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          return param_3 <= lVar1._items[resourceList];
        }
    }

    // Token : 0x600103F
    // RVA   : 0xB35B60   Offset: 0xB34F60   Length: 0x8B
    public bool HaveResource(int id, float num)
    {
        long lVar1;
        if (num <= 0.0) {
          return true;
        }
        lVar1 = this.resourceStore;
        if (lVar1 != null) {
          if (lVar1.Count <= id) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          return num <= lVar1._items[id];
        }
    }

    // Token : 0x6001040
    // RVA   : 0xB32190   Offset: 0xB31590   Length: 0xC8
    public void ChangeResource(List<float> resourceList, bool showInfo, bool showHud)
    {
        var pStatics = *(int64*)(DAT_181d73d40 + 184);
        void ForceData.ChangeResource
                     (int64 this,uint32 resourceList,float showInfo,char showHud,char param_5)
        {
        float fVar1;
        int64 lVar2;
        int64 lVar3;
        uint64 uVar4;
        float fVar5;
        char cVar6;
        uint64 uVar7;
        uint64 uVar8;
        int64 lVar9;
        uint32 uVar10;
        float local_res18 [2];
        uint64 local_58;
        uint64 uStack_50;
        lVar9 = (int64)(int)resourceList;
        local_res18[0] = showInfo;
        if (local_res18[0] == 0.0) {
          return;
        }
        lVar2 = this.resourceStore;
        if (lVar2 != null) {
          if (lVar2.Count <= resourceList) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          fVar5 = local_res18[0];
          lVar3 = this.resourceStoreMax;
          fVar1 = *(float *)(lVar2._items + 32 + lVar9 * 4);
          if (lVar3 != null) {
            if (lVar3.Count <= resourceList) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            uVar10 = Mathf.Min(fVar5 + fVar1,
                                *(uint32 *)(lVar3._items + 32 + lVar9 * 4),0);
            FUN_181829d40(lVar2,resourceList,uVar10,DAT_181da10f8);
            if (showHud) {
              lVar2 = **(int64 **)(DAT_181d7f6a8 + 184);
              cVar6 = FUN_180d755b0(this.forceSetName,0);
              if (!cVar6) {
                uVar8 = this.forceSetName;
              }
              else {
                uVar8 = this.forceName;
              }
              lVar3 = *(int64 *)(pStatics + 0x438);
              if (lVar3 == null) throw; // [null/range check failed]
              if (lVar3.Count <= resourceList) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              uVar4 = *(uint64 *)(lVar3._items + 32 + lVar9 * 8);
              uVar7 = Single.ToString(local_res18,"+0;-0;0",0);
              uVar8 = String.Concat(uVar8,uVar4,uVar7,0);
              lVar3 = *(int64 *)(pStatics + 0x438);
              if (lVar3 == null) throw; // [null/range check failed]
              if (lVar3.Count <= resourceList) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              fVar1 = local_res18[0];
              uVar4 = *(uint64 *)(lVar3._items + 32 + lVar9 * 8);
              switch(resourceList) {
              case 0:
                uVar7 = "GetMoney";
                break;
              case 1:
                uVar7 = "GetFood";
                break;
              case 2:
                uVar7 = "Wood";
                break;
              case 3:
                uVar7 = "Rock";
                break;
              case 4:
                uVar7 = "Med";
                break;
              case 5:
                uVar7 = "FameDown";
                if (0.0 < fVar1) {
                  uVar7 = "FameUp";
                }
                break;
              default:
                uVar7 = 0;
              }
              if (lVar2 == null) throw; // [null/range check failed]
              local_58 = 0;
              uStack_50 = 0;
              InfoController.AddInfoTab
                        (lVar2,uVar8,"UIAtlas",uVar4,uVar7,0x3f800000,0x40a00000,&local_58,0);
            }
            if (param_5) {
              lVar9 = FUN_18046c0a0(0);
              if (((lVar9 == null) || (*(int64 *)(lVar9 + 32) == 0)) ||
                 (lVar9 = WorldData.Player(*(int64 *)(lVar9 + 32),0)) == null)
              throw; // [null/range check failed]
              if (*(int *)(lVar9 + 132) == this.forceID) {
                fVar1 = local_res18[0];
                lVar9 = **(int64 **)(DAT_181d76ea8 + 184);
                var uVar8 = new PlotChoiceRequirement(resourceList,fVar1,0);
                if (lVar9 == null) throw; // [null/range check failed]
                HudController.AddHudResourceShowData(lVar9,uVar8,0);
              }
            }
            return;
          }
        }
    }

    // Token : 0x6001041
    // RVA   : 0xB320A0   Offset: 0xB314A0   Length: 0xEC
    public void ChangeResource(List<ResourceData> resourceList, bool showInfo, bool showHud)
    {
        var pStatics = *(int64*)(DAT_181d73d40 + 184);
        void ForceData.ChangeResource
                     (int64 this,uint32 resourceList,float showInfo,char showHud,char param_5)
        {
        float fVar1;
        int64 lVar2;
        int64 lVar3;
        uint64 uVar4;
        float fVar5;
        char cVar6;
        uint64 uVar7;
        uint64 uVar8;
        int64 lVar9;
        uint32 uVar10;
        float local_res18 [2];
        uint64 local_58;
        uint64 uStack_50;
        lVar9 = (int64)(int)resourceList;
        local_res18[0] = showInfo;
        if (local_res18[0] == 0.0) {
          return;
        }
        lVar2 = this.resourceStore;
        if (lVar2 != null) {
          if (lVar2.Count <= resourceList) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          fVar5 = local_res18[0];
          lVar3 = this.resourceStoreMax;
          fVar1 = *(float *)(lVar2._items + 32 + lVar9 * 4);
          if (lVar3 != null) {
            if (lVar3.Count <= resourceList) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            uVar10 = Mathf.Min(fVar5 + fVar1,
                                *(uint32 *)(lVar3._items + 32 + lVar9 * 4),0);
            FUN_181829d40(lVar2,resourceList,uVar10,DAT_181da10f8);
            if (showHud) {
              lVar2 = **(int64 **)(DAT_181d7f6a8 + 184);
              cVar6 = FUN_180d755b0(this.forceSetName,0);
              if (!cVar6) {
                uVar8 = this.forceSetName;
              }
              else {
                uVar8 = this.forceName;
              }
              lVar3 = *(int64 *)(pStatics + 0x438);
              if (lVar3 == null) throw; // [null/range check failed]
              if (lVar3.Count <= resourceList) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              uVar4 = *(uint64 *)(lVar3._items + 32 + lVar9 * 8);
              uVar7 = Single.ToString(local_res18,"+0;-0;0",0);
              uVar8 = String.Concat(uVar8,uVar4,uVar7,0);
              lVar3 = *(int64 *)(pStatics + 0x438);
              if (lVar3 == null) throw; // [null/range check failed]
              if (lVar3.Count <= resourceList) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              fVar1 = local_res18[0];
              uVar4 = *(uint64 *)(lVar3._items + 32 + lVar9 * 8);
              switch(resourceList) {
              case 0:
                uVar7 = "GetMoney";
                break;
              case 1:
                uVar7 = "GetFood";
                break;
              case 2:
                uVar7 = "Wood";
                break;
              case 3:
                uVar7 = "Rock";
                break;
              case 4:
                uVar7 = "Med";
                break;
              case 5:
                uVar7 = "FameDown";
                if (0.0 < fVar1) {
                  uVar7 = "FameUp";
                }
                break;
              default:
                uVar7 = 0;
              }
              if (lVar2 == null) throw; // [null/range check failed]
              local_58 = 0;
              uStack_50 = 0;
              InfoController.AddInfoTab
                        (lVar2,uVar8,"UIAtlas",uVar4,uVar7,0x3f800000,0x40a00000,&local_58,0);
            }
            if (param_5) {
              lVar9 = FUN_18046c0a0(0);
              if (((lVar9 == null) || (*(int64 *)(lVar9 + 32) == 0)) ||
                 (lVar9 = WorldData.Player(*(int64 *)(lVar9 + 32),0)) == null)
              throw; // [null/range check failed]
              if (*(int *)(lVar9 + 132) == this.forceID) {
                fVar1 = local_res18[0];
                lVar9 = **(int64 **)(DAT_181d76ea8 + 184);
                var uVar8 = new PlotChoiceRequirement(resourceList,fVar1,0);
                if (lVar9 == null) throw; // [null/range check failed]
                HudController.AddHudResourceShowData(lVar9,uVar8,0);
              }
            }
            return;
          }
        }
    }

    // Token : 0x6001042
    // RVA   : 0xB32260   Offset: 0xB31660   Length: 0x4A8
    public void ChangeResource(int id, float num, bool showInfo, bool showHud)
    {
        var pStatics = *(int64*)(DAT_181d73d40 + 184);
        void ForceData.ChangeResource
                     (int64 this,uint32 id,float num,char showInfo,char showHud)
        {
        float fVar1;
        int64 lVar2;
        int64 lVar3;
        uint64 uVar4;
        float fVar5;
        char cVar6;
        uint64 uVar7;
        uint64 uVar8;
        int64 lVar9;
        uint32 uVar10;
        float local_res18 [2];
        uint64 local_58;
        uint64 uStack_50;
        lVar9 = (int64)(int)id;
        local_res18[0] = num;
        if (local_res18[0] == 0.0) {
          return;
        }
        lVar2 = this.resourceStore;
        if (lVar2 != null) {
          if (lVar2.Count <= id) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          fVar5 = local_res18[0];
          lVar3 = this.resourceStoreMax;
          fVar1 = *(float *)(lVar2._items + 32 + lVar9 * 4);
          if (lVar3 != null) {
            if (lVar3.Count <= id) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            uVar10 = Mathf.Min(fVar5 + fVar1,
                                *(uint32 *)(lVar3._items + 32 + lVar9 * 4),0);
            FUN_181829d40(lVar2,id,uVar10,DAT_181da10f8);
            if (showInfo) {
              lVar2 = **(int64 **)(DAT_181d7f6a8 + 184);
              cVar6 = FUN_180d755b0(this.forceSetName,0);
              if (!cVar6) {
                uVar8 = this.forceSetName;
              }
              else {
                uVar8 = this.forceName;
              }
              lVar3 = *(int64 *)(pStatics + 0x438);
              if (lVar3 == null) throw; // [null/range check failed]
              if (lVar3.Count <= id) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              uVar4 = *(uint64 *)(lVar3._items + 32 + lVar9 * 8);
              uVar7 = Single.ToString(local_res18,"+0;-0;0",0);
              uVar8 = String.Concat(uVar8,uVar4,uVar7,0);
              lVar3 = *(int64 *)(pStatics + 0x438);
              if (lVar3 == null) throw; // [null/range check failed]
              if (lVar3.Count <= id) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              fVar1 = local_res18[0];
              uVar4 = *(uint64 *)(lVar3._items + 32 + lVar9 * 8);
              switch(id) {
              case 0:
                uVar7 = "GetMoney";
                break;
              case 1:
                uVar7 = "GetFood";
                break;
              case 2:
                uVar7 = "Wood";
                break;
              case 3:
                uVar7 = "Rock";
                break;
              case 4:
                uVar7 = "Med";
                break;
              case 5:
                uVar7 = "FameDown";
                if (0.0 < fVar1) {
                  uVar7 = "FameUp";
                }
                break;
              default:
                uVar7 = 0;
              }
              if (lVar2 == null) throw; // [null/range check failed]
              local_58 = 0;
              uStack_50 = 0;
              InfoController.AddInfoTab
                        (lVar2,uVar8,"UIAtlas",uVar4,uVar7,0x3f800000,0x40a00000,&local_58,0);
            }
            if (showHud) {
              lVar9 = FUN_18046c0a0(0);
              if (((lVar9 == null) || (*(int64 *)(lVar9 + 32) == 0)) ||
                 (lVar9 = WorldData.Player(*(int64 *)(lVar9 + 32),0)) == null)
              throw; // [null/range check failed]
              if (*(int *)(lVar9 + 132) == this.forceID) {
                fVar1 = local_res18[0];
                lVar9 = **(int64 **)(DAT_181d76ea8 + 184);
                var uVar8 = new PlotChoiceRequirement(id,fVar1,0);
                if (lVar9 == null) throw; // [null/range check failed]
                HudController.AddHudResourceShowData(lVar9,uVar8,0);
              }
            }
            return;
          }
        }
    }

    // Token : 0x6001043
    // RVA   : 0xB338C0   Offset: 0xB32CC0   Length: 0x88
    public static string GetChangeResourceSound(int id, float num)
    {
        ulong uVar1;
        switch(id) {
        case 0:
          return "GetMoney";
        case 1:
          return "GetFood";
        case 2:
          return "Wood";
        case 3:
          return "Rock";
        case 4:
          return "Med";
        case 5:
          uVar1 = "FameDown";
          if (0.0 < num) {
            uVar1 = "FameUp";
          }
          return uVar1;
        default:
          return 0;
        }
    }

    // Token : 0x6001044
    // RVA   : 0xB329E0   Offset: 0xB31DE0   Length: 0xD3
    public void CostResource(List<float> resourceList, bool showInfo)
    {
        ForceData.ChangeResource(this,resourceList,showInfo ^ 0x80000000,param_4,1,0);
    }

    // Token : 0x6001045
    // RVA   : 0xB328A0   Offset: 0xB31CA0   Length: 0x102
    public void CostResource(List<ResourceData> resourceList, bool showInfo)
    {
        ForceData.ChangeResource(this,resourceList,showInfo ^ 0x80000000,param_4,1,0);
    }

    // Token : 0x6001046
    // RVA   : 0xB32AC0   Offset: 0xB31EC0   Length: 0x39
    public void CostResource(ResourceData resource, bool showInfo)
    {
        ForceData.ChangeResource(this,resource,showInfo ^ 0x80000000,param_4,1,0);
    }

    // Token : 0x6001047
    // RVA   : 0xB329B0   Offset: 0xB31DB0   Length: 0x23
    public void CostResource(int id, float num, bool showInfo)
    {
        ForceData.ChangeResource(this,id,num ^ 0x80000000,showInfo,1,0);
    }

    // Token : 0x6001048
    // RVA   : 0xB34E00   Offset: 0xB34200   Length: 0xBE
    public HeroData GetLeader()
    {
        long lVar1;
        if ((GameController._instance != null) &&
           (lVar1 = GameController._instance.worldData) != null) {
          WorldData.GetHero(lVar1,this.leader,0);
          return;
        }
    }

    // Token : 0x6001049
    // RVA   : 0xB372F0   Offset: 0xB366F0   Length: 0x548
    public void SetLeader(HeroData targetHero, bool showInfo)
    {
        int iVar1;
        bool cVar2;
        long lVar3;
        long lVar4;
        ulong uVar5;
        ulong uVar6;
        ulong local_28;
        ulong uStack_20;
        if (targetHero == null) goto LAB_180b37833;
        if (*(int *)(targetHero + 132) == this.forceID) {
          lVar3 = ForceData.GetLeader(this);
          if (lVar3 != null) {
            lVar3 = ForceData.GetLeader(this,0);
            if (lVar3 == null) goto LAB_180b37833;
            *(uint8 *)(lVar3 + 180) = 0;
            lVar3 = ForceData.GetLeader(this,0);
            if (lVar3 == null) goto LAB_180b37833;
            HeroData.set_HeroIconDirty(lVar3,1,0);
          }
          this.leader = *(uint32 *)(targetHero + 88);
          *(uint8 *)(targetHero + 180) = 1;
          HeroData.ChangeHeroForceLv(targetHero,5 - *(int *)(targetHero + 184),0,0);
          HeroData.ClearForceJob(targetHero,0);
          if (*(int *)(targetHero + 88) == 0) {
            lVar3 = FUN_18046c0a0(0);
            if ((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) goto LAB_180b37833;
            *(uint8 *)(*(int64 *)(lVar3 + 32) + 184) = 0;
            lVar3 = FUN_18046c0a0(0);
            if ((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) goto LAB_180b37833;
            *(uint8 *)(*(int64 *)(lVar3 + 32) + 185) = 0;
            if (*(int64 *)(targetHero + 0x2e0) != 0) {
              lVar3 = FUN_18046c0a0(0);
              if (lVar3 == null) goto LAB_180b37833;
              GameController.GiveUpForceMission(lVar3,0,1,0);
            }
            lVar3 = FUN_18046c0a0(0);
            if (((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) ||
               (lVar3 = *(int64 *)(*(int64 *)(lVar3 + 32) + 104)) == null)
            goto LAB_180b37833;
            iVar1 = *(int *)(lVar3 + 24);
            while (iVar1 = iVar1 + -1, -1 < iVar1) {
              lVar3 = FUN_18046c0a0(0);
              if (((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) ||
                 ((lVar3 = *(int64 *)(*(int64 *)(lVar3 + 32) + 104), lVar3 == null ||
                  (lVar3 = FUN_180002f80(lVar3,iVar1,DAT_181d85e20)) == null))) goto LAB_180b37833;
              if (*(int *)(lVar3 + 136) == 2) {
                lVar3 = FUN_18046c0a0(0);
                lVar4 = FUN_18046c0a0(0);
                if ((((lVar4 == null) || (*(int64 *)(lVar4 + 32) == 0)) ||
                    (lVar4 = *(int64 *)(*(int64 *)(lVar4 + 32) + 104)) == null) ||
                   (uVar5 = FUN_180002f80(lVar4,iVar1,DAT_181d85e20), lVar3 == null)) goto LAB_180b37833;
                GameController.RemoveEvent(lVar3,uVar5,0);
              }
            }
          }
          this.forceDetailDirty = 1;
          HeroData.set_HeroIconDirty(targetHero,1,0);
          if (showInfo) {
            uVar5 = *(uint64 *)(targetHero + 104);
            lVar3 = **(int64 **)(DAT_181d7f6a8 + 184);
            cVar2 = FUN_180d755b0(this.forceSetName,0);
            if (!cVar2) {
              uVar6 = this.forceSetName;
            }
            else {
              uVar6 = this.forceName;
            }
            uVar5 = String.Format("{0}接任了{1}掌门之位。",uVar5,uVar6,0);
            lVar4 = FUN_18046c0a0(0);
            if (((lVar4 == null) || (*(int64 *)(lVar4 + 32) == 0)) ||
               ((lVar4 = WorldData.GetForce(*(int64 *)(lVar4 + 32),this.forceID,0
                                            ), lVar4 == null ||
                (uVar6 = ForceData.GetForceIconName(lVar4,0), lVar3 == null)))) goto LAB_180b37833;
            local_28 = 0;
            uStack_20 = 0;
            InfoController.AddInfoTab
                      (lVar3,uVar5,"UIAtlas",uVar6,"NoticeImportant",0x3f800000,0x40a00000,&local_28,0);
          }
          if (*(int *)(targetHero + 88) == 0) {
            lVar3 = FUN_18046c100(0);
            if (lVar3 == null) {
        LAB_180b37833:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            GameDataController.ChangeAchStats(lVar3,21,0x3f800000);
          }
        }
        else {
          cVar2 = FUN_180d755b0(this.forceSetName,0);
          if (!cVar2) {
            uVar5 = this.forceSetName;
          }
          else {
            uVar5 = this.forceName;
          }
          uVar5 = String.Format("无法将非门派{0}角色{1}设置为掌门！",uVar5,*(uint64 *)(targetHero + 104),0);
          Debug.LogError(uVar5,0);
        }
    }

    // Token : 0x600104A
    // RVA   : 0xB31110   Offset: 0xB30510   Length: 0xA9
    public void AddHero(HeroData targetHero)
    {
        if (targetHero != null) {
          *(uint32 *)(targetHero + 132) = this.forceID;
          *(uint32 *)(targetHero + 216) = param_4;
          if (this.ownHeros != null) {
            FUN_18182a0b0(this.ownHeros,*(uint32 *)(targetHero + 88),DAT_181d8f218);
            HeroData.ChangeHeroForceLv(targetHero,param_3 - *(int *)(targetHero + 184),0,0);
            this.forceDetailDirty = 1;
            return;
          }
        }
    }

    // Token : 0x600104B
    // RVA   : 0xB311C0   Offset: 0xB305C0   Length: 0x9F
    public void AddHero(HeroData targetHero, int _forceLv, int _generation)
    {
        if (targetHero != null) {
          *(uint32 *)(targetHero + 132) = this.forceID;
          *(uint32 *)(targetHero + 216) = _generation;
          if (this.ownHeros != null) {
            FUN_18182a0b0(this.ownHeros,*(uint32 *)(targetHero + 88),DAT_181d8f218);
            HeroData.ChangeHeroForceLv(targetHero,_forceLv - *(int *)(targetHero + 184),0,0);
            this.forceDetailDirty = 1;
            return;
          }
        }
    }

    // Token : 0x600104C
    // RVA   : 0xB36550   Offset: 0xB35950   Length: 0x74
    public void RemoveHero(HeroData targetHero)
    {
        if (targetHero != null) {
          *(uint32 *)(targetHero + 132) = 0xffffffff;
          *(uint32 *)(targetHero + 0x1c0) = 0;
          if (this.ownHeros != null) {
            FUN_1817eee00(this.ownHeros,*(uint32 *)(targetHero + 88),DAT_181d8f618);
            this.forceDetailDirty = 1;
            return;
          }
        }
    }

    // Token : 0x600104D
    // RVA   : 0xB32E70   Offset: 0xB32270   Length: 0x2ED
    public void ForceConquerArea(AreaData targetArea, bool showInfo)
    {
        int iVar1;
        bool cVar2;
        long lVar3;
        long lVar4;
        ulong uVar5;
        ulong uVar6;
        ulong uVar7;
        ulong local_18;
        ulong uStack_10;
        if (targetArea == null) throw; // [null/range check failed]
        iVar1 = *(int *)(targetArea + 112);
        AreaData.SetBranchLeader(targetArea,0,0);
        AreaData.ResetAutoSetting(targetArea,0);
        cVar2 = AreaData.HaveForce(targetArea,0);
        if (cVar2) {
          lVar3 = AreaData.GetForce(targetArea,0);
          if ((lVar3 == null) || (*(int64 *)(lVar3 + 96) == 0)) throw; // [null/range check failed]
          FUN_1817eee00(*(int64 *)(lVar3 + 96),*(uint32 *)(targetArea + 16),DAT_181d8f618);
          lVar3 = AreaData.GetForce(targetArea,0);
          if (lVar3 == null) throw; // [null/range check failed]
          *(uint8 *)(lVar3 + 0x10c) = 1;
          lVar3 = AreaData.GetForce(targetArea,0);
          if (lVar3 == null) throw; // [null/range check failed]
          *(uint8 *)(lVar3 + 0x10d) = 1;
        }
        if (this.ownAreasID != null) {
          FUN_18182a0b0(this.ownAreasID,*(uint32 *)(targetArea + 16),DAT_181d8f218);
          AreaData.ResetAllState(targetArea,0);
          AreaData.AreaConquerReduceDefenceLv(targetArea,0);
          this.forceDetailDirty = 0x101;
          *(uint32 *)(targetArea + 112) = this.forceID;
          if (showInfo) {
            lVar3 = **(int64 **)(DAT_181d7f6a8 + 184);
            cVar2 = FUN_180d755b0(this.forceSetName,0);
            if (!cVar2) {
              uVar7 = this.forceSetName;
            }
            else {
              uVar7 = this.forceName;
            }
            uVar5 = "占据了";
            if (iVar1 != -1) {
              lVar4 = FUN_18046c0a0(0);
              if (((lVar4 == null) || (*(int64 *)(lVar4 + 32) == 0)) ||
                 (lVar4 = WorldData.GetForce(*(int64 *)(lVar4 + 32),iVar1,0)) == null)
              throw; // [null/range check failed]
              cVar2 = FUN_180d755b0(*(uint64 *)(lVar4 + 0x198),0);
              if (!cVar2) {
                uVar5 = *(uint64 *)(lVar4 + 0x198);
              }
              else {
                uVar5 = *(uint64 *)(lVar4 + 24);
              }
              uVar5 = String.Format("从{0}手中夺取了",uVar5,0);
            }
            uVar6 = AreaData.GetAreaName(targetArea,0);
            uVar7 = String.Concat(uVar7,uVar5,uVar6,0);
            if (lVar3 == null) throw; // [null/range check failed]
            local_18 = 0;
            uStack_10 = 0;
            InfoController.AddInfoTab
                      (lVar3,uVar7,"UIAtlas","资源_占领地","NoticeImportant",0x3f800000,0x40a00000,
                       &local_18,0);
          }
          return;
        }
    }

    // Token : 0x600104E
    // RVA   : 0xB33160   Offset: 0xB32560   Length: 0x11A
    public void ForceConquerResourcePoint(AreaData targetArea, bool showInfo)
    {
        int iVar1;
        bool cVar2;
        long lVar3;
        long lVar4;
        ulong uVar5;
        ulong uVar6;
        ulong uVar7;
        ulong local_18;
        ulong uStack_10;
        if (targetArea == null) throw; // [null/range check failed]
        iVar1 = *(int *)(targetArea + 48);
        cVar2 = ResourcePointData.HaveForce(targetArea,0);
        if (cVar2) {
          lVar3 = ResourcePointData.GetForce(targetArea,0);
          if ((lVar3 == null) || (*(int64 *)(lVar3 + 104) == 0)) throw; // [null/range check failed]
          FUN_1817eee00(*(int64 *)(lVar3 + 104),*(uint32 *)(targetArea + 16),DAT_181d8f618);
          lVar3 = ResourcePointData.GetForce(targetArea,0);
          if (lVar3 == null) throw; // [null/range check failed]
          *(uint8 *)(lVar3 + 0x10c) = 1;
          lVar3 = ResourcePointData.GetForce(targetArea,0);
          if (lVar3 == null) throw; // [null/range check failed]
          *(uint8 *)(lVar3 + 0x10d) = 1;
        }
        if (this.ownResourcePointsID != null) {
          FUN_18182a0b0(this.ownResourcePointsID,*(uint32 *)(targetArea + 16),DAT_181d8f218);
          this.forceDetailDirty = 0x101;
          *(uint32 *)(targetArea + 48) = this.forceID;
          if (showInfo) {
            lVar3 = **(int64 **)(DAT_181d7f6a8 + 184);
            cVar2 = FUN_180d755b0(this.forceSetName,0);
            if (!cVar2) {
              uVar7 = this.forceSetName;
            }
            else {
              uVar7 = this.forceName;
            }
            uVar5 = "占据了";
            if (iVar1 != -1) {
              lVar4 = FUN_18046c0a0(0);
              if (((lVar4 == null) || (*(int64 *)(lVar4 + 32) == 0)) ||
                 (lVar4 = WorldData.GetForce(*(int64 *)(lVar4 + 32),iVar1,0)) == null)
              throw; // [null/range check failed]
              cVar2 = FUN_180d755b0(*(uint64 *)(lVar4 + 0x198),0);
              if (!cVar2) {
                uVar5 = *(uint64 *)(lVar4 + 0x198);
              }
              else {
                uVar5 = *(uint64 *)(lVar4 + 24);
              }
              uVar5 = String.Format("从{0}手中夺取了",uVar5,0);
            }
            uVar6 = ResourcePointData.GetResourcePointFullName(targetArea,0);
            uVar7 = String.Concat(uVar7,uVar5,uVar6,0);
            if (lVar3 == null) throw; // [null/range check failed]
            local_18 = 0;
            uStack_10 = 0;
            InfoController.AddInfoTab
                      (lVar3,uVar7,"UIAtlas","资源_占领地","NoticeImportant",0x3f800000,0x40a00000,
                       &local_18,0);
          }
          return;
        }
    }

    // Token : 0x600104F
    // RVA   : 0xB33280   Offset: 0xB32680   Length: 0x2C2
    public void ForceConquerResourcePoint(ResourcePointData targetResourcePoint, bool showInfo)
    {
        int iVar1;
        bool cVar2;
        long lVar3;
        long lVar4;
        ulong uVar5;
        ulong uVar6;
        ulong uVar7;
        ulong local_18;
        ulong uStack_10;
        if (targetResourcePoint == null) throw; // [null/range check failed]
        iVar1 = *(int *)(targetResourcePoint + 48);
        cVar2 = ResourcePointData.HaveForce(targetResourcePoint,0);
        if (cVar2) {
          lVar3 = ResourcePointData.GetForce(targetResourcePoint,0);
          if ((lVar3 == null) || (*(int64 *)(lVar3 + 104) == 0)) throw; // [null/range check failed]
          FUN_1817eee00(*(int64 *)(lVar3 + 104),*(uint32 *)(targetResourcePoint + 16),DAT_181d8f618);
          lVar3 = ResourcePointData.GetForce(targetResourcePoint,0);
          if (lVar3 == null) throw; // [null/range check failed]
          *(uint8 *)(lVar3 + 0x10c) = 1;
          lVar3 = ResourcePointData.GetForce(targetResourcePoint,0);
          if (lVar3 == null) throw; // [null/range check failed]
          *(uint8 *)(lVar3 + 0x10d) = 1;
        }
        if (this.ownResourcePointsID != null) {
          FUN_18182a0b0(this.ownResourcePointsID,*(uint32 *)(targetResourcePoint + 16),DAT_181d8f218);
          this.forceDetailDirty = 0x101;
          *(uint32 *)(targetResourcePoint + 48) = this.forceID;
          if (showInfo) {
            lVar3 = **(int64 **)(DAT_181d7f6a8 + 184);
            cVar2 = FUN_180d755b0(this.forceSetName,0);
            if (!cVar2) {
              uVar7 = this.forceSetName;
            }
            else {
              uVar7 = this.forceName;
            }
            uVar5 = "占据了";
            if (iVar1 != -1) {
              lVar4 = FUN_18046c0a0(0);
              if (((lVar4 == null) || (*(int64 *)(lVar4 + 32) == 0)) ||
                 (lVar4 = WorldData.GetForce(*(int64 *)(lVar4 + 32),iVar1,0)) == null)
              throw; // [null/range check failed]
              cVar2 = FUN_180d755b0(*(uint64 *)(lVar4 + 0x198),0);
              if (!cVar2) {
                uVar5 = *(uint64 *)(lVar4 + 0x198);
              }
              else {
                uVar5 = *(uint64 *)(lVar4 + 24);
              }
              uVar5 = String.Format("从{0}手中夺取了",uVar5,0);
            }
            uVar6 = ResourcePointData.GetResourcePointFullName(targetResourcePoint,0);
            uVar7 = String.Concat(uVar7,uVar5,uVar6,0);
            if (lVar3 == null) throw; // [null/range check failed]
            local_18 = 0;
            uStack_10 = 0;
            InfoController.AddInfoTab
                      (lVar3,uVar7,"UIAtlas","资源_占领地","NoticeImportant",0x3f800000,0x40a00000,
                       &local_18,0);
          }
          return;
        }
    }

    // Token : 0x6001050
    // RVA   : 0xB35DC0   Offset: 0xB351C0   Length: 0x174
    public string KungfuSkillFocusDescribe()
    {
        long lVar1;
        uint uVar2;
        ulong uVar3;
        ulong uVar4;
        long lVar5;
        int iVar6;
        ulong uVar7;
        iVar6 = 0;
        lVar5 = this.kungfuSkillFocus;
        uVar4 = "";
        while (lVar5 != null) {
          if (lVar5.Count <= iVar6) {
            return uVar4;
          }
          uVar7 = "/";
          if (iVar6 == 0) {
            uVar7 = "";
          }
          if (((*(byte *)(DAT_181d73d40 + 0x133) & 4) != 0) && (*(int *)(DAT_181d73d40 + 224) == 0)) {
            il2cpp_runtime_class_init(DAT_181d73d40);
            lVar5 = this.kungfuSkillFocus;
          }
          lVar1 = *(int64 *)(*(int64 *)(DAT_181d73d40 + 184) + 0x4a0);
          if ((lVar5 == null) || (uVar2 = FUN_1800d6760(lVar5,iVar6,DAT_181d8fa18), lVar1 == null)) break;
          uVar3 = FUN_180002f80(lVar1,uVar2,DAT_181da4358);
          uVar4 = String.Concat(uVar4,uVar7,uVar3,0);
          iVar6 = iVar6 + 1;
          lVar5 = this.kungfuSkillFocus;
        }
    }

    // Token : 0x6001051
    // RVA   : 0xB344F0   Offset: 0xB338F0   Length: 0x902
    public string GetJoinForceNeedDescribe()
    {
        var pStatics_3d40 = *(int64*)(DAT_181d73d40 + 184);
        float fVar1;
        long lVar2;
        bool cVar3;
        uint uVar4;
        long lVar5;
        ulong uVar6;
        ulong uVar7;
        ulong uVar8;
        ulong uVar9;
        int iVar10;
        int iVar11;
        byte uVar12;
        float fVar13;
        float fVar14;
        float[] local_res8 = new float[2];
        fVar13 = this.forceMaleRate;
        if ((fVar13 == 1.0) || (uVar6 = "", fVar13 == 0.0)) {
          uVar6 = "仅限男性";
          if (fVar13 != 1.0) {
            uVar6 = "仅限女性";
          }
          if ((GameController._instance == null) ||
             (lVar5 = GameController._instance.worldData) == null)
          goto LAB_180b34de1;
          lVar5 = WorldData.Player(lVar5,0);
          if (this.forceMaleRate == 1.0) {
            if (lVar5 == null) goto LAB_180b34de1;
            uVar12 = !lVar5.WorldEventDatas;
          }
          else if (this.forceMaleRate == null.0) {
            if (lVar5 == null) goto LAB_180b34de1;
            uVar12 = lVar5.WorldEventDatas;
          }
          else {
            uVar12 = 1;
          }
          uVar6 = GlobalData.GenerateChangeColorText(uVar6,uVar12,0);
        }
        cVar3 = FUN_18171e540(uVar6,"",0);
        uVar8 = "声望 {0}";
        uVar9 = "\n";
        if (cVar3) {
          uVar9 = "";
        }
        if (!this.bigForce) {
          fVar13 = 0.5;
        }
        else {
          fVar13 = 1.0;
        }
        local_res8[0] = fVar13 * ForceData.JoinBigForceNeedFame;
        uVar7 = il2cpp_value_box(DAT_181da22d8,local_res8);
        uVar8 = String.Format(uVar8,uVar7,0);
        if (((GameController._instance == null) ||
            (lVar5 = GameController._instance.worldData) == null) ||
           (lVar5 = WorldData.Player(lVar5,0)) == null) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        fVar13 = *(float *)(lVar5 + 0x1c4);
        if (!this.bigForce) {
          fVar14 = 0.5;
        }
        else {
          fVar14 = 1.0;
        }
        fVar1 = ForceData.JoinBigForceNeedFame;
        uVar8 = GlobalData.GenerateChangeColorText(uVar8,fVar1 * fVar14 <= fVar13,0);
        uVar6 = String.Concat(uVar6,uVar9,uVar8,0);
        iVar11 = 0;
        iVar10 = 0;
        lVar5 = this.kungfuSkillFocus;
        while (lVar5 != null) {
          if (lVar5.Count <= iVar10) {
            lVar5 = this.livingSkillFocus;
            goto joined_r0x000180b34b66;
          }
          if (((*(byte *)(DAT_181d73d40 + 0x133) & 4) != 0) && (*(int *)(DAT_181d73d40 + 224) == 0)) {
            il2cpp_runtime_class_init(DAT_181d73d40);
            lVar5 = this.kungfuSkillFocus;
          }
          lVar2 = *(int64 *)(pStatics_3d40 + 0x4a0);
          if ((lVar5 == null) || (uVar4 = FUN_1800d6760(lVar5,iVar10,DAT_181d8fa18), lVar2 == null)) break;
          uVar9 = FUN_180002f80(lVar2,uVar4,DAT_181da4358);
          uVar8 = "\n{0} {1}";
          if (!this.bigForce) {
            fVar13 = 0.5;
          }
          else {
            fVar13 = 1.0;
          }
          local_res8[0] = fVar13 * **(float **)(DAT_181dc7c78 + 184);
          uVar7 = il2cpp_value_box(DAT_181da22d8,local_res8);
          uVar8 = String.Format(uVar8,uVar9,uVar7,0);
          lVar5 = FUN_18046c0a0(0);
          if (((lVar5 == null) || (lVar5.villageAreaID == null)) ||
             (lVar5 = WorldData.Player(lVar5.villageAreaID,0)) == null) {
        LAB_180b34de7:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          lVar5 = lVar5.monthFreshBountyTime;
          if ((this.kungfuSkillFocus == null) ||
             (uVar4 = FUN_1800d6760(this.kungfuSkillFocus,iVar10,DAT_181d8fa18), lVar5 == null))
          goto LAB_180b34de7;
          fVar13 = (float)FUN_1800d6790(lVar5,uVar4,DAT_181da1078);
          if (!this.bigForce) {
            fVar14 = 0.5;
          }
          else {
            fVar14 = 1.0;
          }
          fVar1 = **(float **)(DAT_181dc7c78 + 184);
          uVar8 = GlobalData.GenerateChangeColorText(uVar8,fVar1 * fVar14 <= fVar13,0);
          uVar6 = String.Concat(uVar6,uVar8,0);
          iVar10 = iVar10 + 1;
          lVar5 = this.kungfuSkillFocus;
        }
        LAB_180b34de1:
                          // WARNING: Subroutine does not return
        FUN_1800d6620();
        joined_r0x000180b34b66:
        if (lVar5 == null) goto LAB_180b34de1;
        if (lVar5.Count <= iVar11) {
          return uVar6;
        }
        if (((*(byte *)(DAT_181d73d40 + 0x133) & 4) != 0) && (*(int *)(DAT_181d73d40 + 224) == 0)) {
          il2cpp_runtime_class_init(DAT_181d73d40);
          lVar5 = this.livingSkillFocus;
        }
        lVar2 = *(int64 *)(pStatics_3d40 + 0x4b0);
        if ((lVar5 == null) || (uVar4 = FUN_1800d6760(lVar5,iVar11,DAT_181d8fa18), lVar2 == null))
        goto LAB_180b34de1;
        uVar9 = FUN_180002f80(lVar2,uVar4,DAT_181da4358);
        uVar8 = "\n{0} {1}";
        if (!this.bigForce) {
          fVar13 = 0.5;
        }
        else {
          fVar13 = 1.0;
        }
        local_res8[0] = fVar13 * **(float **)(DAT_181dc7c78 + 184);
        uVar7 = il2cpp_value_box(DAT_181da22d8,local_res8);
        uVar8 = String.Format(uVar8,uVar9,uVar7,0);
        lVar5 = FUN_18046c0a0(0);
        if (((lVar5 == null) || (lVar5.villageAreaID == null)) ||
           (lVar5 = WorldData.Player(lVar5.villageAreaID,0)) == null) {
        LAB_180b34ded:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        lVar5 = lVar5.showRoomChangeFame;
        if ((this.livingSkillFocus == null) ||
           (uVar4 = FUN_1800d6760(this.livingSkillFocus,iVar11,DAT_181d8fa18), lVar5 == null))
        goto LAB_180b34ded;
        fVar13 = (float)FUN_1800d6790(lVar5,uVar4,DAT_181da1078);
        if (!this.bigForce) {
          fVar14 = 0.5;
        }
        else {
          fVar14 = 1.0;
        }
        fVar1 = **(float **)(DAT_181dc7c78 + 184);
        uVar8 = GlobalData.GenerateChangeColorText(uVar8,fVar1 * fVar14 <= fVar13,0);
        uVar6 = String.Concat(uVar6,uVar8,0);
        iVar11 = iVar11 + 1;
        lVar5 = this.livingSkillFocus;
        goto joined_r0x000180b34b66;
    }

    // Token : 0x6001052
    // RVA   : 0xB36050   Offset: 0xB35450   Length: 0x4AD
    public bool PlayerMeetForceJoinRequire()
    {
        uint uVar1;
        long lVar2;
        int iVar4;
        int iVar5;
        float fVar6;
        float fVar7;
        if ((GameController._instance == null) ||
           (lVar2 = GameController._instance.worldData) == null)
        goto LAB_180b364f8;
        lVar2 = WorldData.Player(lVar2,0);
        if (this.forceMaleRate == 1.0) {
          if (lVar2 == null) goto LAB_180b364f8;
          pfVar3 = (float *)CONCAT71((int7)((uint64)lVar2 >> 8),!lVar2.WorldEventDatas);
        LAB_180b361a5:
          if ((char)!pfVar3) goto LAB_180b364f4;
        }
        else if (this.forceMaleRate == null.0) {
          if (lVar2 == null) goto LAB_180b364f8;
          pfVar3 = (float *)(uint64)lVar2.WorldEventDatas;
          goto LAB_180b361a5;
        }
        if (((GameController._instance != null) &&
            (lVar2 = GameController._instance.worldData) != null) &&
           (lVar2 = WorldData.Player(lVar2,0)) != null) {
          fVar6 = *(float *)(lVar2 + 0x1c4);
          if (!this.bigForce) {
            fVar7 = 0.5;
          }
          else {
            fVar7 = 1.0;
          }
          pfVar3 = *(float **)(DAT_181dc7c78 + 184);
          if (fVar6 < fVar7 * pfVar3[1]) {
        LAB_180b364f4:
            return (uint64)pfVar3 & 0xffffffffffffff00;
          }
          lVar2 = this.kungfuSkillFocus;
          iVar4 = 0;
          iVar5 = 0;
          if (lVar2 != null) {
            while (iVar5 < lVar2.Count) {
              lVar2 = FUN_18046c0a0(0);
              if (((lVar2 == null) || (lVar2.villageAreaID == null)) ||
                 (lVar2 = WorldData.Player(lVar2.villageAreaID,0)) == null)
              goto LAB_180b364f8;
              lVar2 = lVar2.monthFreshBountyTime;
              if ((this.kungfuSkillFocus == null) ||
                 (uVar1 = FUN_1800d6760(this.kungfuSkillFocus,iVar5,DAT_181d8fa18), lVar2 == null))
              goto LAB_180b364f8;
              fVar6 = (float)FUN_1800d6790(lVar2,uVar1,DAT_181da1078);
              if (!this.bigForce) {
                fVar7 = 0.5;
              }
              else {
                fVar7 = 1.0;
              }
              pfVar3 = *(float **)(DAT_181dc7c78 + 184);
              if (fVar6 < fVar7 * *pfVar3) goto LAB_180b364f4;
              lVar2 = this.kungfuSkillFocus;
              iVar5 = iVar5 + 1;
              if (lVar2 == null) goto LAB_180b364f8;
            }
            lVar2 = this.livingSkillFocus;
            if (lVar2 != null) goto LAB_180b363d0;
          }
        }
        LAB_180b364f8:
                          // WARNING: Subroutine does not return
        FUN_1800d6620();
        LAB_180b363d0:
        if (lVar2.Count <= iVar4) {
          return CONCAT71((int7)((uint64)lVar2 >> 8),1);
        }
        lVar2 = FUN_18046c0a0(0);
        if (((lVar2 == null) || (lVar2.villageAreaID == null)) ||
           (lVar2 = WorldData.Player(lVar2.villageAreaID,0)) == null) goto LAB_180b364f8;
        lVar2 = lVar2.showRoomChangeFame;
        if ((this.livingSkillFocus == null) ||
           (uVar1 = FUN_1800d6760(this.livingSkillFocus,iVar4,DAT_181d8fa18), lVar2 == null))
        goto LAB_180b364f8;
        fVar6 = (float)FUN_1800d6790(lVar2,uVar1,DAT_181da1078);
        if (!this.bigForce) {
          fVar7 = 0.5;
        }
        else {
          fVar7 = 1.0;
        }
        pfVar3 = *(float **)(DAT_181dc7c78 + 184);
        if (fVar6 < fVar7 * *pfVar3) goto LAB_180b364f4;
        lVar2 = this.livingSkillFocus;
        iVar4 = iVar4 + 1;
        if (lVar2 == null) goto LAB_180b364f8;
        goto LAB_180b363d0;
    }

    // Token : 0x6001053
    // RVA   : 0xB32720   Offset: 0xB31B20   Length: 0x175
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

    // Token : 0x6001054
    // RVA   : 0xB38190   Offset: 0xB37590   Length: 0x4E
    private static void /*cctor*/()
    {
        **(uint32 **)(DAT_181dc7c78 + 184) = 0x41a00000;
        *(uint32 *)(*(int64 *)(DAT_181dc7c78 + 184) + 4) = 0x42480000;
    }

}
