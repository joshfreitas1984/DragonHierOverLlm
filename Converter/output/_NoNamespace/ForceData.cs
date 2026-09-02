// ============================================================
// Type  : ForceData
// Token : 0x200020F
// ============================================================

public class ForceData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000E67
    public int forceID;

    // Token: 0x4000E68
    public string forceName;

    // Token: 0x4000E69
    public int defaultSkinID;

    // Token: 0x4000E6A
    public bool bigForce;

    // Token: 0x4000E6B
    public bool autoAddMember;

    // Token: 0x4000E6C
    public string forceStyle;

    // Token: 0x4000E6D
    public float forceMaleRate;

    // Token: 0x4000E6E
    public int forceLv;

    // Token: 0x4000E6F
    public int mainAreaID;

    // Token: 0x4000E70
    public int masterForce;

    // Token: 0x4000E71
    public List<int> servantForce;

    // Token: 0x4000E72
    public List<int> startSkillBookID;

    // Token: 0x4000E73
    public string color;

    // Token: 0x4000E74
    public int leader;

    // Token: 0x4000E75
    public List<int> ownAreasID;

    // Token: 0x4000E76
    public List<int> ownResourcePointsID;

    // Token: 0x4000E77
    public List<int> ownHeros;

    // Token: 0x4000E78
    public List<int> heroLvNum;

    // Token: 0x4000E79
    public int totalSalary;

    // Token: 0x4000E7A
    public int totalPopulation;

    // Token: 0x4000E7B
    public List<float> resourceStore;

    // Token: 0x4000E7C
    public List<float> resourceStoreMax;

    // Token: 0x4000E7D
    public List<float> resourceChange;

    // Token: 0x4000E7E
    public ItemListData forceStorage;

    // Token: 0x4000E7F
    public float forceStorageSelfDiscount;

    // Token: 0x4000E80
    public float forceStorageOtherDiscount;

    // Token: 0x4000E81
    public List<BookWriterData> bookWriterList;

    // Token: 0x4000E82
    public ItemListData bookStorage;

    // Token: 0x4000E83
    public bool bookStorageDirty;

    // Token: 0x4000E84
    public Dictionary<int, int> bookStorageMaxRareLv;

    // Token: 0x4000E85
    public List<float> forceFavor;

    // Token: 0x4000E86
    public Dictionary<int, float> forceFavorDict;

    // Token: 0x4000E87
    public List<int> allyForce;

    // Token: 0x4000E88
    public Dictionary<int, int> ForceStopWarTime;

    // Token: 0x4000E89
    public List<int> kungfuSkillFocus;

    // Token: 0x4000E8A
    public List<int> livingSkillFocus;

    // Token: 0x4000E8B
    public List<float> itemFocus;

    // Token: 0x4000E8C
    public ForceFocusType forceFocus;

    // Token: 0x4000E8D
    public bool forceDetailDirty;

    // Token: 0x4000E8E
    public bool forceHeroDetailDirty;

    // Token: 0x4000E8F
    public List<ForceFavorSettingData> forceFavorSetting;

    // Token: 0x4000E90
    public int thisMonthAttackArea;

    // Token: 0x4000E91
    public int thisMonthAttackResourcePoint;

    // Token: 0x4000E92
    public int thisMonthGetResource;

    // Token: 0x4000E93
    public int thisMonthAddOtherForceFavor;

    // Token: 0x4000E94
    public int thisMonthReduceOtherForceFavor;

    // Token: 0x4000E95
    public int randomAttackAreaDay;

    // Token: 0x4000E96
    public int thisMonthGetHero;

    // Token: 0x4000E97
    public int nowResearchTech;

    // Token: 0x4000E98
    public List<ForceTechLvData> techLvData;

    // Token: 0x4000E99
    public ForceSpeAddData techSpeAddData;

    // Token: 0x4000E9A
    public ForceSpeAddData forceSpeAddData;

    // Token: 0x4000E9B
    public List<List<ItemData>> showRoomItems;

    // Token: 0x4000E9C
    public float showRoomChangeFame;

    // Token: 0x4000E9D
    public ForceJobSettingData forceJobSettingData;

    // Token: 0x4000E9E
    public ForceInteractionTimeData forceInteractionTimeData;

    // Token: 0x4000E9F
    public bool thisMonthAttack;

    // Token: 0x4000EA0
    public int thisMonthManaged;

    // Token: 0x4000EA1
    public float playerOutForceContribution;

    // Token: 0x4000EA2
    public int speBuildingID;

    // Token: 0x4000EA3
    public string speFunctionDescribe;

    // Token: 0x4000EA4
    public List<int> reasearchTechList;

    // Token: 0x4000EA5
    private static readonly float JoinBigForceNeedSkill;

    // Token: 0x4000EA6
    private static readonly float JoinBigForceNeedFame;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000FD5
    // RVA   : 0xBAF3F0   Offset: 0xBADBF0   Length: 0xA42
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
        uVar1 = il2cpp_internal(DAT_181d6f030);
        FUN_180f58a90(uVar1,DAT_181d678f8);
        this.servantForce = uVar1;
        uVar1 = il2cpp_internal(DAT_181d6f030);
        FUN_180f58a90(uVar1,DAT_181d678f8);
        this.startSkillBookID = uVar1;
        uVar1 = il2cpp_internal(DAT_181d6f030);
        FUN_180f58a90(uVar1,DAT_181d678f8);
        this.ownAreasID = uVar1;
        uVar1 = il2cpp_internal(DAT_181d6f030);
        FUN_180f58a90(uVar1,DAT_181d678f8);
        this.ownResourcePointsID = uVar1;
        uVar1 = il2cpp_internal(DAT_181d6f030);
        FUN_180f58a90(uVar1,DAT_181d678f8);
        this.ownHeros = uVar1;
        lVar2 = il2cpp_internal(DAT_181d721b0);
        FUN_180f58a90(lVar2,DAT_181d79358);
        if (lVar2 != null) {
          FUN_181805690(lVar2,0,DAT_181d79458);
          FUN_181805690(lVar2,0,DAT_181d79458);
          FUN_181805690(lVar2,0,DAT_181d79458);
          FUN_181805690(lVar2,0,DAT_181d79458);
          FUN_181805690(lVar2,0,DAT_181d79458);
          FUN_181805690(lVar2,0,DAT_181d79458);
          this.resourceStore = lVar2;
          lVar2 = il2cpp_internal(DAT_181d721b0);
          FUN_180f58a90(lVar2,DAT_181d79358);
          if (lVar2 != null) {
            FUN_181805690(lVar2,0x447a0000,DAT_181d79458);
            FUN_181805690(lVar2,0x447a0000,DAT_181d79458);
            FUN_181805690(lVar2,0x447a0000,DAT_181d79458);
            FUN_181805690(lVar2,0x447a0000,DAT_181d79458);
            FUN_181805690(lVar2,0x447a0000,DAT_181d79458);
            FUN_181805690(lVar2,0x42c80000,DAT_181d79458);
            this.resourceStoreMax = lVar2;
            lVar2 = il2cpp_internal(DAT_181d721b0);
            FUN_180f58a90(lVar2,DAT_181d79358);
            if (lVar2 != null) {
              FUN_181805690(lVar2,0,DAT_181d79458);
              FUN_181805690(lVar2,0,DAT_181d79458);
              FUN_181805690(lVar2,0,DAT_181d79458);
              FUN_181805690(lVar2,0,DAT_181d79458);
              FUN_181805690(lVar2,0,DAT_181d79458);
              FUN_181805690(lVar2,0,DAT_181d79458);
              this.resourceChange = lVar2;
              this.forceStorage = new ItemListData(0);
              this.bookStorage = new ItemListData(0);
              uVar1 = il2cpp_internal(DAT_181d5c6c8);
              FUN_1808ae540(uVar1,DAT_181d94fd0);
              *(uint64 *)(this + 200) = uVar1;
              uVar1 = il2cpp_internal(DAT_181d721b0);
              FUN_180f58a90(uVar1,DAT_181d79358);
              this.forceFavor = uVar1;
              uVar1 = il2cpp_internal(DAT_181d5cc48);
              FUN_1808ae540(uVar1,DAT_181d98210);
              this.forceFavorDict = uVar1;
              uVar1 = il2cpp_internal(DAT_181d6f030);
              FUN_180f58a90(uVar1,DAT_181d678f8);
              this.kungfuSkillFocus = uVar1;
              uVar1 = il2cpp_internal(DAT_181d6f030);
              FUN_180f58a90(uVar1,DAT_181d678f8);
              this.livingSkillFocus = uVar1;
              uVar1 = il2cpp_internal(DAT_181d6e030);
              FUN_180f58a90(uVar1,DAT_181d609f8);
              this.forceFavorSetting = uVar1;
              this.forceSpeAddData = new ForceSpeAddData(0);
              this.techSpeAddData = new ForceSpeAddData(0);
              uVar1 = il2cpp_internal(DAT_181d6e130);
              FUN_180f58a90(uVar1,DAT_181d61278);
              this.techLvData = uVar1;
              this.forceInteractionTimeData = new ForceInteractionTimeData(0);
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
                      this.forceJobSettingData = new ForceJobSettingData(0);
                      lVar2 = il2cpp_internal(DAT_181d721b0);
                      FUN_180f58a90(lVar2,DAT_181d79358);
                      if (lVar2 != null) {
                        FUN_181805690(lVar2,0,DAT_181d79458);
                        FUN_181805690(lVar2,0,DAT_181d79458);
                        this.itemFocus = lVar2;
                        lVar2 = il2cpp_internal(DAT_181d6cab0);
                        FUN_180f58a90(lVar2,DAT_181d58b18);
                        uVar1 = new BookWriterData(0);
                        if (lVar2 != null) {
                          FUN_181827900(lVar2,uVar1,DAT_181d58b98);
                          uVar1 = new BookWriterData(0);
                          FUN_181827900(lVar2,uVar1,DAT_181d58b98);
                          uVar1 = new BookWriterData(0);
                          FUN_181827900(lVar2,uVar1,DAT_181d58b98);
                          uVar1 = new BookWriterData(0);
                          FUN_181827900(lVar2,uVar1,DAT_181d58b98);
                          this.bookWriterList = lVar2;
                          uVar1 = il2cpp_internal(DAT_181d6f030);
                          FUN_180f58a90(uVar1,DAT_181d678f8);
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

    // Token : 0x6000FD6
    // RVA   : 0xBA8A40   Offset: 0xBA7240   Length: 0x14C
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
                  (lVar1 = FUN_180002f80(lVar1,uVar3,DAT_181d69770)) == null) ||
                 (*(int64 *)(lVar1 + 112) == 0)) break;
              if (*(int *)(*(int64 *)(lVar1 + 112) + 16) == _skillID) {
                if ((this.bookStorage != null) &&
                   (lVar1 = this.bookStorage.allItem) != null) {
                  uVar2 = FUN_180002f80(lVar1,uVar3,DAT_181d69770);
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

    // Token : 0x6000FD7
    // RVA   : 0xBA8B90   Offset: 0xBA7390   Length: 0x18E
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
                  (lVar1 = FUN_180002f80(lVar1,uVar2,DAT_181d69770)) == null) ||
                 ((*(int64 *)(lVar1 + 112) == 0 ||
                  (lVar1 = BookData.DataBase(*(int64 *)(lVar1 + 112),0)) == null))) break;
              if (lVar1.itemTypeList == _skillType) {
                if (((this.bookStorage == null) ||
                    (lVar1 = this.bookStorage.allItem) == null) ||
                   ((lVar1 = FUN_180002f80(lVar1,uVar2,DAT_181d69770), lVar1 == null ||
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

    // Token : 0x6000FD8
    // RVA   : 0xBAC920   Offset: 0xBAB120   Length: 0x1AA
    public float GetResearchSpeedRate()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        int iVar1;
        long lVar2;
        float fVar3;
        float fVar4;
        if (this.forceSpeAddData != null) {
          fVar3 = (float)ForceSpeAddData.Get(this.forceSpeAddData,4);
          iVar1 = this.forceID;
          if ((*pStatics != 0) &&
             (lVar2 = *(int64 *)(*pStatics + 32)) != null) {
            lVar2 = WorldData.Player(lVar2,0);
            if (lVar2 != null) {
              if (iVar1 == *(int *)(lVar2 + 132)) {
                fVar4 = 0.0;
              }
              else {
                if ((*pStatics == 0) ||
                   (lVar2 = *(int64 *)(*pStatics + 32)) == null)
                throw; // [null/range check failed]
                fVar4 = (float)WorldData.GetAIForceDevelopSpeed(lVar2,0);
                fVar4 = fVar4 * 0.05;
              }
              return fVar3 + 1.0 + fVar4;
            }
          }
        }
    }

    // Token : 0x6000FD9
    // RVA   : 0xBAC790   Offset: 0xBAAF90   Length: 0x18C
    public float GetResearchCostRate()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        int iVar1;
        long lVar2;
        float fVar3;
        iVar1 = this.forceID;
        if ((*pStatics != 0) &&
           (lVar2 = *(int64 *)(*pStatics + 32)) != null) {
          lVar2 = WorldData.Player(lVar2,0);
          if (lVar2 != null) {
            if (iVar1 == *(int *)(lVar2 + 132)) {
              fVar3 = 0.0;
            }
            else {
              if ((*pStatics == 0) ||
                 (lVar2 = *(int64 *)(*pStatics + 32)) == null)
              throw; // [null/range check failed]
              fVar3 = (float)WorldData.GetAIForceDevelopSpeed(lVar2,0);
              fVar3 = fVar3 * -0.05;
            }
            Mathf.Max(0x3d4ccccd,fVar3 + 1.0,0);
            return;
          }
        }
    }

    // Token : 0x6000FDA
    // RVA   : 0xBAAB20   Offset: 0xBA9320   Length: 0x18C
    public float GetBuildCostRate()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        int iVar1;
        long lVar2;
        float fVar3;
        iVar1 = this.forceID;
        if ((*pStatics != 0) &&
           (lVar2 = *(int64 *)(*pStatics + 32)) != null) {
          lVar2 = WorldData.Player(lVar2,0);
          if (lVar2 != null) {
            if (iVar1 == *(int *)(lVar2 + 132)) {
              fVar3 = 0.0;
            }
            else {
              if ((*pStatics == 0) ||
                 (lVar2 = *(int64 *)(*pStatics + 32)) == null)
              throw; // [null/range check failed]
              fVar3 = (float)WorldData.GetAIForceDevelopSpeed(lVar2,0);
              fVar3 = fVar3 * -0.05;
            }
            Mathf.Max(0x3d4ccccd,fVar3 + 1.0,0);
            return;
          }
        }
    }

    // Token : 0x6000FDB
    // RVA   : 0xBACAD0   Offset: 0xBAB2D0   Length: 0xA1
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

    // Token : 0x6000FDC
    // RVA   : 0xBACB80   Offset: 0xBAB380   Length: 0x1B9
    public float GetSalaryRate()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
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
        if ((*pStatics != 0) &&
           (lVar2 = *(int64 *)(*pStatics + 32)) != null) {
          lVar2 = WorldData.Player(lVar2,0);
          if (lVar2 != null) {
            if (*(int *)(lVar2 + 132) != this.forceID) {
              if ((*pStatics == 0) ||
                 (lVar2 = *(int64 *)(*pStatics + 32)) == null)
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

    // Token : 0x6000FDD
    // RVA   : 0xBAC5B0   Offset: 0xBAADB0   Length: 0x1D6
    public int GetRealSalaryCost()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
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
        if ((*pStatics != 0) &&
           (lVar2 = *(int64 *)(*pStatics + 32)) != null) {
          lVar2 = WorldData.Player(lVar2,0);
          if (lVar2 != null) {
            if (*(int *)(lVar2 + 132) != this.forceID) {
              if ((*pStatics == 0) ||
                 (lVar2 = *(int64 *)(*pStatics + 32)) == null)
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

    // Token : 0x6000FDE
    // RVA   : 0xBAA0B0   Offset: 0xBA88B0   Length: 0xD2
    public ForceData DataBase()
    {
        long lVar1;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d4e010 + 184) + 32);
        if ((lVar1 != null) && (lVar1 = *(int64 *)(lVar1 + 208)) != null) {
          FUN_1817cc780(lVar1,this.forceID,DAT_181d94178);
          return;
        }
    }

    // Token : 0x6000FDF
    // RVA   : 0xBAE160   Offset: 0xBAC960   Length: 0x425
    public void SetForceStopWarTime(int targetForceID, int time, bool back, bool showInfo)
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        void ForceData.SetForceStopWarTime
                     (int64 this,uint32 targetForceID,uint32 time,char back,char showInfo)
        {
        uint32 uVar1;
        char cVar2;
        uint32 uVar3;
        uint64 uVar4;
        int64 lVar5;
        int64 lVar6;
        uint64 uVar7;
        uint64 uVar8;
        uint32 local_res10 [2];
        uint64 local_28;
        uint64 uStack_20;
        lVar5 = this.ForceStopWarTime;
        if (lVar5 == null) {
          uVar4 = il2cpp_internal(DAT_181d5c6c8);
          FUN_1808ae540(uVar4,DAT_181d94fd0);
          this.ForceStopWarTime = uVar4;
          lVar5 = this.ForceStopWarTime;
          if (lVar5 == null) throw; // [null/range check failed]
        }
        cVar2 = FUN_1808ab750(lVar5,targetForceID,DAT_181d95278);
        lVar5 = this.ForceStopWarTime;
        if (!cVar2) {
          if (lVar5 == null) throw; // [null/range check failed]
          FUN_1808ab680(lVar5,targetForceID,time,DAT_181d95168);
        }
        else {
          if (lVar5 == null) throw; // [null/range check failed]
          uVar3 = FUN_181408420(lVar5,targetForceID,DAT_181d958d0);
          uVar3 = Mathf.Max(time,uVar3,0);
          FUN_1808aec90(lVar5,targetForceID,uVar3,DAT_181d959e0);
        }
        if (!back) {
          return;
        }
        if (((*pStatics != 0) &&
            (lVar5 = *(int64 *)(*pStatics + 32)) != null) &&
           (lVar5 = WorldData.GetForce(lVar5,targetForceID,0)) != null) {
          uVar3 = 0;
          ForceData.SetForceStopWarTime(lVar5,this.forceID,time,0,1,0);
          if (!showInfo) {
            return;
          }
          uVar4 = this.forceName;
          lVar5 = **(int64 **)(DAT_181d5a578 + 184);
          if (((*pStatics != 0) &&
              (lVar6 = *(int64 *)(*pStatics + 32)) != null) &&
             (lVar6 = WorldData.GetForce(lVar6,targetForceID,0)) != null) {
            uVar8 = *(uint64 *)(lVar6 + 24);
            local_res10[0] = time;
            uVar7 = il2cpp_value_box(DAT_181d5b2f8,local_res10);
            uVar4 = String.Format("{0}与{1}缔结了为期{2}日的停战协定",uVar4,uVar8,uVar7,0);
            uVar1 = this.forceID;
            uVar8 = GlobalData.GetForceIconName(uVar1,0);
            if (lVar5 != null) {
              local_28 = 0;
              uStack_20 = 0;
              InfoController.AddInfoTab
                        (lVar5,uVar4,"UIAtlas",uVar8,"FameUp",CONCAT44(uVar3,0x3f800000),
                         0x40a00000,&local_28,0);
              return;
            }
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
    }

    // Token : 0x6000FE0
    // RVA   : 0xBAB750   Offset: 0xBA9F50   Length: 0xED
    public int GetForceStopWarTime(int targetForceID)
    {
        bool cVar1;
        ulong uVar2;
        long lVar3;
        lVar3 = this.ForceStopWarTime;
        if (lVar3 == null) {
          uVar2 = il2cpp_internal(DAT_181d5c6c8);
          FUN_1808ae540(uVar2,DAT_181d94fd0);
          this.ForceStopWarTime = uVar2;
          lVar3 = this.ForceStopWarTime;
          if (lVar3 == null) throw; // [null/range check failed]
        }
        cVar1 = FUN_1808ab750(lVar3,targetForceID,DAT_181d95278);
        if (!cVar1) {
          return 0;
        }
        if (this.ForceStopWarTime != null) {
          uVar2 = FUN_181408420(this.ForceStopWarTime,targetForceID,DAT_181d958d0);
          return uVar2;
        }
    }

    // Token : 0x6000FE1
    // RVA   : 0xBACF90   Offset: 0xBAB790   Length: 0xB7
    public bool IsAllyForce(int targetForceID)
    {
        ulong uVar1;
        long lVar2;
        lVar2 = this.allyForce;
        if (lVar2 == null) {
          uVar1 = il2cpp_internal(DAT_181d6f030);
          FUN_180f58a90(uVar1,DAT_181d678f8);
          this.allyForce = uVar1;
          lVar2 = this.allyForce;
        }
        if (lVar2 != null) {
          FUN_181815240(lVar2,targetForceID,DAT_181d67bf8);
          return;
        }
    }

    // Token : 0x6000FE2
    // RVA   : 0xBA83C0   Offset: 0xBA6BC0   Length: 0x359
    public void AddAllyForce(int targetForceID, bool back, bool showInfo)
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        uint uVar1;
        ulong uVar2;
        long lVar3;
        long lVar4;
        ulong uVar5;
        ulong local_28;
        ulong uStack_20;
        lVar3 = this.allyForce;
        if (lVar3 == null) {
          uVar2 = il2cpp_internal(DAT_181d6f030);
          FUN_180f58a90(uVar2,DAT_181d678f8);
          this.allyForce = uVar2;
          lVar3 = this.allyForce;
          if (lVar3 == null) throw; // [null/range check failed]
        }
        FUN_181814fa0(lVar3,targetForceID,DAT_181d67a78);
        if (!back) {
          return;
        }
        if (((*pStatics != 0) &&
            (lVar3 = *(int64 *)(*pStatics + 32)) != null) &&
           (lVar3 = WorldData.GetForce(lVar3,targetForceID,0)) != null) {
          ForceData.AddAllyForce(lVar3,this.forceID,0,1,0);
          if (!showInfo) {
            return;
          }
          uVar2 = this.forceName;
          lVar3 = **(int64 **)(DAT_181d5a578 + 184);
          if (((*pStatics != 0) &&
              (lVar4 = *(int64 *)(*pStatics + 32)) != null) &&
             (lVar4 = WorldData.GetForce(lVar4,targetForceID,0)) != null) {
            uVar2 = String.Format("{0}与{1}缔结了同盟协定",uVar2,*(uint64 *)(lVar4 + 24),0);
            uVar1 = this.forceID;
            uVar5 = GlobalData.GetForceIconName(uVar1,0);
            if (lVar3 != null) {
              local_28 = 0;
              uStack_20 = 0;
              InfoController.AddInfoTab
                        (lVar3,uVar2,"UIAtlas",uVar5,"NoticeImportant",0x3f800000,0x40a00000,&local_28,0);
              return;
            }
          }
        }
    }

    // Token : 0x6000FE3
    // RVA   : 0xBA8D20   Offset: 0xBA7520   Length: 0x37A
    public void BreakAllyForce(int targetForceID, bool back, bool showInfo)
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        uint uVar1;
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
          uVar2 = il2cpp_internal(DAT_181d6f030);
          FUN_180f58a90(uVar2,DAT_181d678f8);
          this.allyForce = uVar2;
          lVar3 = this.allyForce;
          if (lVar3 == null) throw; // [null/range check failed]
        }
        FUN_181801c10(lVar3,targetForceID,DAT_181d67e70);
        if (!back) {
          return;
        }
        if (((*pStatics != 0) &&
            (lVar3 = *(int64 *)(*pStatics + 32)) != null) &&
           (lVar3 = WorldData.GetForce(lVar3,targetForceID,0)) != null) {
          ForceData.BreakAllyForce(lVar3,this.forceID,0,1,0);
          if (!showInfo) {
        LAB_180ba9056:
            ForceData.SetForceStopWarTime(this,targetForceID,90,1,1,0);
            return;
          }
          uVar2 = this.forceName;
          lVar3 = **(int64 **)(DAT_181d5a578 + 184);
          if (((*pStatics != 0) &&
              (lVar4 = *(int64 *)(*pStatics + 32)) != null) &&
             (lVar4 = WorldData.GetForce(lVar4,targetForceID,0)) != null) {
            uVar2 = String.Format("{0}与{1}撕毁了同盟协定",uVar2,*(uint64 *)(lVar4 + 24),0);
            uVar1 = this.forceID;
            uVar5 = GlobalData.GetForceIconName(uVar1,0);
            if (lVar3 != null) {
              local_28 = 0;
              uStack_20 = 0;
              InfoController.AddInfoTab
                        (lVar3,uVar2,"UIAtlas",uVar5,"FameDown",CONCAT44(uVar6,0x3f800000),
                         0x40a00000,&local_28,0);
              goto LAB_180ba9056;
            }
          }
        }
    }

    // Token : 0x6000FE4
    // RVA   : 0xBA90A0   Offset: 0xBA78A0   Length: 0x90
    public bool CanAttack(int targetForceID)
    {
        bool cVar1;
        int iVar2;
        if ((this.forceID != targetForceID) && (this.masterForce != targetForceID)) {
          if (this.servantForce == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          cVar1 = FUN_181815240(this.servantForce,targetForceID,DAT_181d67bf8);
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

    // Token : 0x6000FE5
    // RVA   : 0xBAB150   Offset: 0xBA9950   Length: 0x2FD
    public string GetForceRelationshipText(int targetForceID, bool useDarkColor)
    {
        var pStatics = *(int64*)(DAT_181d4ef00 + 184);
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
              uVar4 = *(uint64 *)(pStatics + 0x2c0);
            }
            else {
              uVar4 = *(uint64 *)(pStatics + 0x2c8);
            }
            goto LAB_180bab42e;
          }
          if (this.servantForce == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          cVar1 = FUN_181815240(this.servantForce,targetForceID,DAT_181d67bf8);
          uVar4 = "{0}附庸</color>";
          if (!cVar1) {
            cVar1 = ForceData.IsAllyForce(this,targetForceID,0);
            uVar3 = "{0}同盟</color>";
            if (!cVar1) {
              iVar2 = ForceData.GetForceStopWarTime(this,targetForceID,0);
              if (0 < iVar2) {
                local_res10[0] = ForceData.GetForceStopWarTime(this,targetForceID,0);
                uVar3 = il2cpp_value_box(DAT_181d5b2f8,local_res10);
                uVar3 = String.Format("{1}休战{0}日</color>",uVar3,
                                       *(uint64 *)(pStatics + 0x230),0);
                return uVar3;
              }
              return false;
            }
            if (!useDarkColor) {
              uVar4 = *(uint64 *)(pStatics + 0x238);
            }
            else {
              uVar4 = *(uint64 *)(pStatics + 0x240);
            }
            goto LAB_180bab42e;
          }
        }
        uVar3 = uVar4;
        if (!useDarkColor) {
          uVar4 = *(uint64 *)(pStatics + 600);
        }
        else {
          uVar4 = *(uint64 *)(pStatics + 0x260);
        }
        LAB_180bab42e:
        uVar3 = String.Format(uVar3,uVar4,0);
        return uVar3;
    }

    // Token : 0x6000FE6
    // RVA   : 0xBAAAF0   Offset: 0xBA92F0   Length: 0x29
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

    // Token : 0x6000FE7
    // RVA   : 0xBAD290   Offset: 0xBABA90   Length: 0x4F
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

    // Token : 0x6000FE8
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    public string GetForceName()
    {
        return this.forceName;
    }

    // Token : 0x6000FE9
    // RVA   : 0xBA88E0   Offset: 0xBA70E0   Length: 0x157
    public void BookStorageAddBook(ItemData book, bool showInfo)
    {
        long lVar1;
        ulong uVar2;
        ulong uVar3;
        ulong local_18;
        ulong uStack_10;
        if (this.bookStorage != null) {
          ItemListData.GetItem(this.bookStorage,book,0,0);
          this.bookStorageDirty = 1;
          if (!showInfo) {
            return;
          }
          uVar3 = this.forceName;
          lVar1 = **(int64 **)(DAT_181d5a578 + 184);
          if (book != null) {
            uVar2 = ItemData.Name(book,1,0);
            uVar3 = String.Format("{0}藏经阁添加了藏书《{1}》。",uVar3,uVar2,0);
            uVar2 = ItemData.GetItemIconName(book,0);
            if (lVar1 != null) {
              local_18 = 0;
              uStack_10 = 0;
              InfoController.AddInfoTab
                        (lVar1,uVar3,"IconAtlas",uVar2,"Woosh",0x3f800000,0x40a00000,&local_18,0);
              return;
            }
          }
        }
    }

    // Token : 0x6000FEA
    // RVA   : 0xBADBB0   Offset: 0xBAC3B0   Length: 0x5AC
    public void SetForceJob(int jobType, int jobID, HeroData targetHero)
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
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
              if (*pStatics == 0) throw; // [null/range check failed]
              lVar5 = *(int64 *)(*pStatics + 32);
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
              *(uint32 *)(lVar5 + 144) = 0xffffffff;
              if (*pStatics == 0) throw; // [null/range check failed]
              lVar5 = *(int64 *)(*pStatics + 32);
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
              if (*pStatics == 0) throw; // [null/range check failed]
              lVar5 = *(int64 *)(*pStatics + 32);
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
              *(uint32 *)(lVar5 + 152) = 0;
              if (*pStatics == 0) throw; // [null/range check failed]
              lVar5 = *(int64 *)(*pStatics + 32);
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
                FUN_18181e970(lVar5,jobID,uVar6,DAT_181d68370);
                this.forceDetailDirty = 0x101;
                return;
              }
            }
          }
        }
    }

    // Token : 0x6000FEB
    // RVA   : 0xBAB130   Offset: 0xBA9930   Length: 0x19
    public float GetForceJobExtraExpRate()
    {
        return (float)this.forceLv * 0.1 + 0.5;
    }

    // Token : 0x6000FEC
    // RVA   : 0xBAB120   Offset: 0xBA9920   Length: 0x7
    public int GetForceJobExtraAttriNum()
    {
        return this.forceLv + 5;
    }

    // Token : 0x6000FED
    // RVA   : 0xBAC2F0   Offset: 0xBAAAF0   Length: 0xFD
    public HeroData GetOwnHero(int id)
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        long lVar1;
        long lVar2;
        if (*pStatics != 0) {
          lVar1 = this.ownHeros;
          lVar2 = *(int64 *)(*pStatics + 32);
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

    // Token : 0x6000FEE
    // RVA   : 0xBAC3F0   Offset: 0xBAABF0   Length: 0x1BA
    public List<HeroData> GetOwnHeros()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        long lVar1;
        long lVar2;
        ulong uVar3;
        long lVar4;
        uint uVar5;
        long lVar6;
        lVar2 = il2cpp_internal(DAT_181d6e6b0);
        FUN_180f58a90(lVar2,DAT_181d63c78);
        lVar4 = this.ownHeros;
        uVar5 = 0;
        if (lVar4 != null) {
          lVar6 = 32;
          while( true ) {
            if (lVar4.Count <= (int)uVar5) {
              return lVar2;
            }
            if (*pStatics == 0) break;
            lVar4 = this.ownHeros;
            lVar1 = *(int64 *)(*pStatics + 32);
            if (lVar4 == null) break;
            if (lVar4.Count <= uVar5) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            if ((lVar1 == null) ||
               (uVar3 = WorldData.GetHero(lVar1,*(uint32 *)(lVar6 + lVar4._items),0),
               lVar2 == null)) break;
            FUN_181827900(lVar2,uVar3);
            lVar4 = this.ownHeros;
            uVar5 = uVar5 + 1;
            lVar6 = lVar6 + 4;
            if (lVar4 == null) break;
          }
        }
    }

    // Token : 0x6000FEF
    // RVA   : 0xBAA190   Offset: 0xBA8990   Length: 0x28C
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
        lVar3 = il2cpp_internal(DAT_181d6e6b0);
        FUN_180f58a90(lVar3,DAT_181d63c78);
        iVar6 = 0;
        lVar4 = this.ownHeros;
        while (lVar4 != null) {
          if (lVar4.ForceJobs <= iVar6) {
            return lVar3;
          }
          if (minForceLv == -1) {
        LAB_180baa272:
            if (maxForceLv != -1) {
              lVar4 = ForceData.GetOwnHero(this,iVar6,0);
              if (lVar4 == null) break;
              if (maxForceLv < *(int *)(lVar4 + 184)) goto LAB_180baa3e6;
            }
            if (!noJob) {
        LAB_180baa2f6:
              if (noLeader) {
                lVar4 = ForceData.GetOwnHero(this,iVar6,0);
                if (lVar4 == null) break;
                if (*(char *)(lVar4 + 180) != false) goto LAB_180baa3e6;
              }
              if (noPlayer) {
                if (this.ownHeros == null) break;
                iVar2 = FUN_1800d6750(this.ownHeros,iVar6);
                if (iVar2 == 0) goto LAB_180baa3e6;
              }
              if (noPrison) {
                lVar4 = ForceData.GetOwnHero(this,iVar6,0);
                if (lVar4 == null) break;
                if (*(char *)(lVar4 + 209) != false) goto LAB_180baa3e6;
              }
              if (noSpe) {
                lVar4 = ForceData.GetOwnHero(this,iVar6,0);
                if (lVar4 == null) break;
                if (*(char *)(lVar4 + 92) != false) goto LAB_180baa3e6;
              }
              lVar4 = ForceData.GetOwnHero(this,iVar6,0);
              if (lVar4 == null) break;
              if (*(char *)(lVar4 + 96) == false) {
                lVar4 = ForceData.GetOwnHero(this,iVar6,0);
                if (lVar4 == null) break;
                if (*(char *)(lVar4 + 97) == false) {
                  uVar5 = ForceData.GetOwnHero(this,iVar6,0);
                  if (lVar3 == null) break;
                  FUN_181827900(lVar3,uVar5);
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
                if (*(int *)(lVar4 + 156) < 0) goto LAB_180baa2f6;
              }
            }
          }
          else {
            lVar4 = ForceData.GetOwnHero(this,iVar6,0);
            if (lVar4 == null) break;
            if (minForceLv <= *(int *)(lVar4 + 184)) goto LAB_180baa272;
          }
        LAB_180baa3e6:
          iVar6 = iVar6 + 1;
          lVar4 = this.ownHeros;
        }
    }

    // Token : 0x6000FF0
    // RVA   : 0xBAACB0   Offset: 0xBA94B0   Length: 0x13B
    public float GetChangeAllAreaState(AreaStateType areaStateType)
    {
        long lVar1;
        ulong uVar2;
        ulong uVar3;
        uint[] local_res10 = new uint[2];
        uVar2 = DAT_181d94308;
        lVar1 = this.forceSpeAddData;
        uVar2 = Type.GetTypeFromHandle(uVar2,0);
        local_res10[0] = areaStateType;
        uVar3 = Int32.ToString(local_res10,0);
        uVar3 = String.Concat("ChangeAllAreaState",uVar3,0);
        plVar4 = (int64 *)Enum.Parse(uVar2,uVar3,0);
        if ((lVar1 != null) && (plVar4 != (int64 *)0)) {
          if (*(int64 *)(*plVar4 + 64) == *(int64 *)(DAT_181d5b2f8 + 64)) {
            puVar5 = (uint32 *)il2cpp_object_unbox();
            ForceSpeAddData.Get(lVar1,*puVar5,0);
            return;
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6070(plVar4,DAT_181d5b2f8);
        }
    }

    // Token : 0x6000FF1
    // RVA   : 0xBAD1D0   Offset: 0xBAB9D0   Length: 0xBE
    public AreaData MainArea()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        long lVar1;
        if ((*pStatics != 0) &&
           (lVar1 = *(int64 *)(*pStatics + 32)) != null) {
          WorldData.GetArea(lVar1,this.mainAreaID,0);
          return;
        }
    }

    // Token : 0x6000FF2
    // RVA   : 0xBAC270   Offset: 0xBAAA70   Length: 0x73
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

    // Token : 0x6000FF3
    // RVA   : 0xBAEF30   Offset: 0xBAD730   Length: 0x460
    public void UpgradeNowResearch(bool showInfo)
    {
        var pStatics_a578 = *(int64*)(DAT_181d5a578 + 184);
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        float fVar1;
        uint uVar2;
        ulong uVar3;
        long lVar4;
        long lVar5;
        ulong uVar6;
        ulong uVar7;
        float fVar8;
        uint[] local_res20 = new uint[2];
        ulong local_48;
        ulong uStack_40;
        lVar4 = ForceData.GetNowResearchTech(this,0);
        if (lVar4 != null) {
          *(uint32 *)(lVar4 + 24) = 0;
          lVar4 = ForceData.GetNowResearchTech(this,0);
          if (lVar4 != null) {
            *(int *)(lVar4 + 20) = *(int *)(lVar4 + 20) + 1;
            lVar4 = this.techSpeAddData;
            lVar5 = ForceData.GetNowResearchTech(this,0);
            if (lVar5 != null) {
              lVar5 = ForceTechLvData.Database(lVar5,0);
              if (lVar5 != null) {
                uVar2 = *(uint32 *)(lVar5 + 44);
                lVar5 = ForceData.GetNowResearchTech(this,0);
                if (lVar5 != null) {
                  lVar5 = ForceTechLvData.Database(lVar5,0);
                  if (lVar5 != null) {
                    fVar1 = *(float *)(lVar5 + 48);
                    lVar5 = ForceData.GetNowResearchTech(this,0);
                    if (lVar5 != null) {
                      lVar5 = ForceTechLvData.Database(lVar5,0);
                      if (lVar5 != null) {
                        if (*(char *)(lVar5 + 52) == false) {
                          lVar5 = ForceData.GetNowResearchTech(this,0);
                          if (lVar5 == null) throw; // [null/range check failed]
                          fVar8 = (float)*(int *)(lVar5 + 20);
                        }
                        else {
                          fVar8 = 1.0;
                        }
                        if (lVar4 != null) {
                          ForceSpeAddData.Change(lVar4,uVar2,fVar1 * fVar8,0);
                          if (!showInfo) {
        LAB_180baf345:
                            this.forceDetailDirty = 0x101;
                            this.nowResearchTech = 0xffffffff;
                            return;
                          }
                          uVar7 = this.forceName;
                          lVar4 = ForceData.GetNowResearchTech(this,0);
                          if (lVar4 != null) {
                            lVar4 = ForceTechLvData.Database(lVar4,0);
                            if (lVar4 != null) {
                              uVar3 = *(uint64 *)(lVar4 + 24);
                              lVar4 = ForceData.GetNowResearchTech(this,0);
                              if (lVar4 != null) {
                                local_res20[0] = *(uint32 *)(lVar4 + 20);
                                uVar6 = il2cpp_value_box(DAT_181d5b2f8,local_res20);
                                uVar7 = String.Format("{0}完成研究[{1}Lv{2}]！",uVar7,uVar3,uVar6,0);
                                if ((*pStatics_df90 != 0) &&
                                   (lVar4 = *(int64 *)(*pStatics_df90 + 32),
                                   lVar4 != null)) {
                                  lVar4 = WorldData.Player(lVar4,0);
                                  if (lVar4 != null) {
                                    if (*(int *)(lVar4 + 132) == this.forceID) {
                                      if (*pStatics_a578 == 0) throw; // [null/range check failed]
                                      local_48 = 0;
                                      uStack_40 = 0;
                                      InfoController.AddInfoTab
                                                (*pStatics_a578,uVar7,"UIAtlas"
                                                 ,"从事工作_探索","NoticeLittle",0x3f800000,0x40a00000,
                                                 &local_48,0);
                                    }
                                    lVar4 = *pStatics_a578;
                                    if ((*pStatics_df90 != 0) &&
                                       (lVar5 = *(int64 *)
                                                 (*pStatics_df90 + 32),
                                       lVar5 != null)) {
                                      lVar5 = WorldData.Player(lVar5,0);
                                      if ((lVar5 != null) && (lVar4 != null)) {
                                        InfoController.AddInfo
                                                  (lVar4,*(int *)(lVar5 + 132) ==
                                                         this.forceID,uVar7,0);
                                        goto LAB_180baf345;
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

    // Token : 0x6000FF4
    // RVA   : 0xBAEA80   Offset: 0xBAD280   Length: 0x33D
    public void SetNowResearch(ForceTechLvData targetTech, bool showInfo)
    {
        var pStatics_a578 = *(int64*)(DAT_181d5a578 + 184);
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        ulong uVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        long lVar5;
        uint[] local_res10 = new uint[2];
        ulong local_18;
        ulong uStack_10;
        if (targetTech == null) {
        LAB_180baedb2:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        this.nowResearchTech = *(uint32 *)(targetTech + 16);
        if (!showInfo) {
          return;
        }
        uVar4 = this.forceName;
        lVar2 = ForceData.GetNowResearchTech(this,0);
        if ((lVar2 != null) && (lVar2 = ForceTechLvData.Database(lVar2,0)) != null) {
          uVar1 = *(uint64 *)(lVar2 + 24);
          lVar2 = ForceData.GetNowResearchTech(this,0);
          if (lVar2 != null) {
            local_res10[0] = *(uint32 *)(lVar2 + 20);
            uVar3 = il2cpp_value_box(DAT_181d5b2f8,local_res10);
            uVar4 = String.Format("{0}开始研究[{1}Lv{2}]！",uVar4,uVar1,uVar3,0);
            if (((*pStatics_df90 != 0) &&
                (lVar2 = *(int64 *)(*pStatics_df90 + 32)) != null) &&
               (lVar2 = WorldData.Player(lVar2,0)) != null) {
              if (*(int *)(lVar2 + 132) == this.forceID) {
                if (*pStatics_a578 == 0) goto LAB_180baedb2;
                local_18 = 0;
                uStack_10 = 0;
                InfoController.AddInfoTab
                          (*pStatics_a578,uVar4,"UIAtlas","从事工作_探索",
                           "NoticeLittle",0x3f800000,0x40a00000,&local_18,0);
              }
              lVar2 = *pStatics_a578;
              if ((((*pStatics_df90 != 0) &&
                   (lVar5 = *(int64 *)(*pStatics_df90 + 32)) != null) &&
                  (lVar5 = WorldData.Player(lVar5,0)) != null) && (lVar2 != null)) {
                InfoController.AddInfo(lVar2,*(int *)(lVar5 + 132) == this.forceID,uVar4,0);
                return;
              }
              goto LAB_180baedb2;
            }
          }
        }
    }

    // Token : 0x6000FF5
    // RVA   : 0xBA8870   Offset: 0xBA7070   Length: 0x67
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

    // Token : 0x6000FF6
    // RVA   : 0xBAC210   Offset: 0xBAAA10   Length: 0x23
    public float GetMaxAreaNum()
    {
        if (this.forceSpeAddData != null) {
          ForceSpeAddData.Get(this.forceSpeAddData,0,0);
          return;
        }
    }

    // Token : 0x6000FF7
    // RVA   : 0xBAD790   Offset: 0xBABF90   Length: 0x43
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

    // Token : 0x6000FF8
    // RVA   : 0xBAC240   Offset: 0xBAAA40   Length: 0x25
    public float GetMaxHeroNum()
    {
        if (this.forceSpeAddData != null) {
          ForceSpeAddData.Get(this.forceSpeAddData,1);
          return;
        }
    }

    // Token : 0x6000FF9
    // RVA   : 0xBAEDC0   Offset: 0xBAD5C0   Length: 0x163
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
            FUN_180f56130(lVar3,DAT_181d794d8);
            return;
          }
          if (this.forceFavorDict == null) break;
          cVar2 = FUN_1808ab750(this.forceFavorDict,iVar4,DAT_181d984b8);
          lVar3 = this.forceFavorDict;
          lVar1 = this.forceFavor;
          if (!cVar2) {
            if ((lVar1 == null) || (uVar5 = FUN_1800d6780(lVar1,iVar4,DAT_181d796d8), lVar3 == null)) break;
            FUN_181772130(lVar3,iVar4,uVar5,DAT_181d983a8);
          }
          else {
            if ((lVar1 == null) || (uVar5 = FUN_1800d6780(lVar1,iVar4,DAT_181d796d8), lVar3 == null)) break;
            FUN_181789b60(lVar3,iVar4,uVar5,DAT_181d98b98);
          }
          lVar3 = this.forceFavor;
          iVar4 = iVar4 + 1;
          if (lVar3 == null) break;
        }
    }

    // Token : 0x6000FFA
    // RVA   : 0xBADB80   Offset: 0xBAC380   Length: 0x22
    public void SetForceFavor(ForceFavorSettingData setting)
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        bool cVar1;
        long lVar2;
        ForceData.UpgradeForceFavorDict(this,0);
        if (this.forceFavorDict != null) {
          cVar1 = FUN_1808ab750(this.forceFavorDict,setting,DAT_181d984b8);
          lVar2 = this.forceFavorDict;
          if (!cVar1) {
            if (lVar2 == null) throw; // [null/range check failed]
            FUN_181772130(lVar2,setting,param_3,DAT_181d983a8);
          }
          else {
            if (lVar2 == null) throw; // [null/range check failed]
            FUN_181789b60(lVar2,setting,param_3,DAT_181d98b98);
          }
          if ((*pStatics != 0) &&
             (lVar2 = *(int64 *)(*pStatics + 32)) != null) {
            lVar2 = WorldData.GetForce(lVar2,setting,0);
            if ((lVar2 != null) && (*(int64 *)(lVar2 + 216) != 0)) {
              cVar1 = FUN_1808ab750(*(int64 *)(lVar2 + 216),this.forceID,
                                    DAT_181d984b8);
              if (!cVar1) {
                if ((*pStatics != 0) &&
                   (lVar2 = *(int64 *)(*pStatics + 32)) != null) {
                  lVar2 = WorldData.GetForce(lVar2,setting,0);
                  if ((lVar2 != null) && (*(int64 *)(lVar2 + 216) != 0)) {
                    FUN_181772130(*(int64 *)(lVar2 + 216),this.forceID,param_3,
                                  DAT_181d983a8);
                    return;
                  }
                }
              }
              else {
                if ((*pStatics != 0) &&
                   (lVar2 = *(int64 *)(*pStatics + 32)) != null) {
                  lVar2 = WorldData.GetForce(lVar2,setting,0);
                  if ((lVar2 != null) && (*(int64 *)(lVar2 + 216) != 0)) {
                    FUN_181789b60(*(int64 *)(lVar2 + 216),this.forceID,param_3,
                                  DAT_181d98b98);
                    return;
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6000FFB
    // RVA   : 0xBAD860   Offset: 0xBAC060   Length: 0x314
    public void SetForceFavor(int id, float favor)
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        bool cVar1;
        long lVar2;
        ForceData.UpgradeForceFavorDict(this,0);
        if (this.forceFavorDict != null) {
          cVar1 = FUN_1808ab750(this.forceFavorDict,id,DAT_181d984b8);
          lVar2 = this.forceFavorDict;
          if (!cVar1) {
            if (lVar2 == null) throw; // [null/range check failed]
            FUN_181772130(lVar2,id,favor,DAT_181d983a8);
          }
          else {
            if (lVar2 == null) throw; // [null/range check failed]
            FUN_181789b60(lVar2,id,favor,DAT_181d98b98);
          }
          if ((*pStatics != 0) &&
             (lVar2 = *(int64 *)(*pStatics + 32)) != null) {
            lVar2 = WorldData.GetForce(lVar2,id,0);
            if ((lVar2 != null) && (*(int64 *)(lVar2 + 216) != 0)) {
              cVar1 = FUN_1808ab750(*(int64 *)(lVar2 + 216),this.forceID,
                                    DAT_181d984b8);
              if (!cVar1) {
                if ((*pStatics != 0) &&
                   (lVar2 = *(int64 *)(*pStatics + 32)) != null) {
                  lVar2 = WorldData.GetForce(lVar2,id,0);
                  if ((lVar2 != null) && (*(int64 *)(lVar2 + 216) != 0)) {
                    FUN_181772130(*(int64 *)(lVar2 + 216),this.forceID,favor,
                                  DAT_181d983a8);
                    return;
                  }
                }
              }
              else {
                if ((*pStatics != 0) &&
                   (lVar2 = *(int64 *)(*pStatics + 32)) != null) {
                  lVar2 = WorldData.GetForce(lVar2,id,0);
                  if ((lVar2 != null) && (*(int64 *)(lVar2 + 216) != 0)) {
                    FUN_181789b60(*(int64 *)(lVar2 + 216),this.forceID,favor,
                                  DAT_181d98b98);
                    return;
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6000FFC
    // RVA   : 0xBA9140   Offset: 0xBA7940   Length: 0x51E
    public void ChangeForceFavor(int id, float favor, bool showInfo)
    {
        var pStatics = *(int64*)(DAT_181d4ef00 + 184);
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
          uVar11 = FUN_1810a8ba0(fVar10 + favor,0,0x42c80000,0);
          ForceData.SetForceFavor(this,id,uVar11,0);
          if (showInfo) {
            lVar1 = **(int64 **)(DAT_181d5a578 + 184);
            plVar4 = (int64 *)FUN_1800d60b0(DAT_181d80cc0,5);
            lVar6 = this.forceName;
            if (plVar4 == (int64 *)0) {
        LAB_180ba95b9:
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
            goto LAB_180ba95b9;
            lVar6 = *(int64 *)(lVar6 + 24);
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
              local_48 = *(uint32 *)(lVar6 + 0x2e8);
              uStack_44 = *(uint32 *)(lVar6 + 0x2ec);
              uStack_40 = *(uint32 *)(lVar6 + 0x2f0);
              uStack_3c = *(uint32 *)(lVar6 + 0x2f4);
            }
            else {
              lVar6 = pStatics;
              local_48 = *(uint32 *)(lVar6 + 0x280);
              uStack_44 = *(uint32 *)(lVar6 + 0x284);
              uStack_40 = *(uint32 *)(lVar6 + 0x288);
              uStack_3c = *(uint32 *)(lVar6 + 0x28c);
            }
            uVar8 = "FameDown";
            if (0.0 < favor) {
              uVar8 = "FameUp";
            }
            if (lVar1 == null) goto LAB_180ba95b9;
            InfoController.AddInfoTab(lVar1,uVar7,uVar2,uVar9,uVar8,0x3f800000,0x40a00000,&local_48,0);
          }
          cVar3 = ForceData.IsAllyForce(this,id,0);
          if ((cVar3) &&
             (fVar10 = (float)ForceData.GetForceFavor(this,id,0), fVar10 < 80.0)) {
            ForceData.BreakAllyForce(this,id,1,1,0);
          }
        }
    }

    // Token : 0x6000FFD
    // RVA   : 0xBAAFE0   Offset: 0xBA97E0   Length: 0x131
    public float GetForceFavor(int forceID)
    {
        long lVar1;
        bool cVar2;
        uint uVar3;
        ulong uVar4;
        ForceData.UpgradeForceFavorDict(this,0);
        if (forceID < 0) {
          return 0;
        }
        if (this.masterForce == forceID) {
          return 0x42c80000;
        }
        if (this.servantForce != null) {
          cVar2 = FUN_181815240(this.servantForce,forceID,DAT_181d67bf8);
          if (cVar2) {
            return 0x42c80000;
          }
          if (this.forceFavorDict != null) {
            cVar2 = FUN_1808ab750(this.forceFavorDict,forceID,DAT_181d984b8);
            if (!cVar2) {
              lVar1 = this.forceFavorDict;
              uVar3 = ForceData.GetForceStartFavor(this,forceID,0);
              if (lVar1 == null) throw; // [null/range check failed]
              FUN_181772130(lVar1,forceID,uVar3,DAT_181d983a8);
            }
            if (this.forceFavorDict != null) {
              uVar4 = FUN_1817cc640(this.forceFavorDict,forceID,DAT_181d98a88);
              return uVar4;
            }
          }
        }
    }

    // Token : 0x6000FFE
    // RVA   : 0xBAB450   Offset: 0xBA9C50   Length: 0x2FF
    public float GetForceStartFavor(int targetForceID)
    {
        bool cVar1;
        long lVar2;
        lVar2 = this.forceStyle;
        if (lVar2 == null) {
          return 0x42480000;
        }
        cVar1 = FUN_1816fd990(lVar2,"仁义",0);
        if (!cVar1) {
          cVar1 = FUN_1816fd990(lVar2,"中庸",0);
          if (!cVar1) {
            cVar1 = FUN_1816fd990(lVar2,"霸业",0);
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
              cVar1 = FUN_1816fd990(lVar2,"仁义",0);
              if (cVar1) {
                return 0x42200000;
              }
              cVar1 = FUN_1816fd990(lVar2,"中庸",0);
              if (cVar1) {
                return 0x42480000;
              }
              cVar1 = FUN_1816fd990(lVar2,"霸业",0);
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
              cVar1 = FUN_1816fd990(lVar2,"仁义",0);
              if (!cVar1) {
                cVar1 = FUN_1816fd990(lVar2,"中庸",0);
                if (cVar1) {
                  return 0x425c0000;
                }
                FUN_1816fd990(lVar2,"霸业",0);
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
            cVar1 = FUN_1816fd990(lVar2,"仁义",0);
            if (cVar1) {
              return 0x42700000;
            }
            cVar1 = FUN_1816fd990(lVar2,"中庸",0);
            if (cVar1) {
              return 0x42480000;
            }
            cVar1 = FUN_1816fd990(lVar2,"霸业",0);
            if (cVar1) {
              return 0x42200000;
            }
            return 0x42480000;
          }
        }
    }

    // Token : 0x6000FFF
    // RVA   : 0xBAAF20   Offset: 0xBA9720   Length: 0xB1
    public float GetForceFavorRate(ForceData targetForce)
    {
        bool cVar1;
        if (targetForce != null) {
          cVar1 = FUN_1816fd990(*(uint64 *)(targetForce + 40),"中庸",0);
          if (!cVar1) {
            cVar1 = FUN_1816fd990(this.forceStyle,"中庸",0);
            if (!cVar1) {
              cVar1 = FUN_1816fd990(*(uint64 *)(targetForce + 40),this.forceStyle,0);
              if (!cVar1) {
                return 0x3f000000;
              }
              return 0x3f800000;
            }
          }
          return 0x3f4ccccd;
        }
    }

    // Token : 0x6001000
    // RVA   : 0xBACF60   Offset: 0xBAB760   Length: 0x22
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

    // Token : 0x6001001
    // RVA   : 0xBACD40   Offset: 0xBAB540   Length: 0xA6
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

    // Token : 0x6001002
    // RVA   : 0xBACE80   Offset: 0xBAB680   Length: 0xD5
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

    // Token : 0x6001003
    // RVA   : 0xBACDF0   Offset: 0xBAB5F0   Length: 0x8B
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

    // Token : 0x6001004
    // RVA   : 0xBA9750   Offset: 0xBA7F50   Length: 0xC8
    public void ChangeResource(List<float> resourceList, bool showInfo, bool showHud)
    {
        var pStatics = *(int64*)(DAT_181d4ef00 + 184);
        void ForceData.ChangeResource
                     (int64 this,uint32 resourceList,float showInfo,char showHud,char param_5)
        {
        float fVar1;
        int64 lVar2;
        int64 lVar3;
        uint64 uVar4;
        float fVar5;
        uint64 uVar6;
        uint64 uVar7;
        int64 lVar8;
        uint32 uVar9;
        float local_res18 [2];
        uint64 local_58;
        uint64 uStack_50;
        lVar8 = (int64)(int)resourceList;
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
          fVar1 = *(float *)(lVar2._items + 32 + lVar8 * 4);
          if (lVar3 != null) {
            if (lVar3.Count <= resourceList) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            uVar9 = Mathf.Min(fVar5 + fVar1,
                               *(uint32 *)(lVar3._items + 32 + lVar8 * 4),0);
            FUN_181814d10(lVar2,resourceList,uVar9,DAT_181d79758);
            if (showHud) {
              uVar7 = this.forceName;
              lVar2 = **(int64 **)(DAT_181d5a578 + 184);
              lVar3 = *(int64 *)(pStatics + 0x430);
              if (lVar3 == null) throw; // [null/range check failed]
              if (lVar3.Count <= resourceList) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              uVar4 = *(uint64 *)(lVar3._items + 32 + lVar8 * 8);
              uVar6 = Single.ToString(local_res18,"+0;-0;0",0);
              uVar7 = String.Concat(uVar7,uVar4,uVar6,0);
              lVar3 = *(int64 *)(pStatics + 0x430);
              if (lVar3 == null) throw; // [null/range check failed]
              if (lVar3.Count <= resourceList) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              fVar1 = local_res18[0];
              uVar4 = *(uint64 *)(lVar3._items + 32 + lVar8 * 8);
              switch(resourceList) {
              case 0:
                uVar6 = "GetMoney";
                break;
              case 1:
                uVar6 = "GetFood";
                break;
              case 2:
                uVar6 = "Wood";
                break;
              case 3:
                uVar6 = "Rock";
                break;
              case 4:
                uVar6 = "Med";
                break;
              case 5:
                uVar6 = "FameDown";
                if (0.0 < fVar1) {
                  uVar6 = "FameUp";
                }
                break;
              default:
                uVar6 = 0;
              }
              if (lVar2 == null) throw; // [null/range check failed]
              local_58 = 0;
              uStack_50 = 0;
              InfoController.AddInfoTab
                        (lVar2,uVar7,"UIAtlas",uVar4,uVar6,0x3f800000,0x40a00000,&local_58,0);
            }
            if (param_5) {
              lVar8 = FUN_18046c0a0(0);
              if (((lVar8 == null) || (*(int64 *)(lVar8 + 32) == 0)) ||
                 (lVar8 = WorldData.Player(*(int64 *)(lVar8 + 32),0)) == null)
              throw; // [null/range check failed]
              if (*(int *)(lVar8 + 132) == this.forceID) {
                fVar1 = local_res18[0];
                lVar8 = **(int64 **)(DAT_181d51d80 + 184);
                var uVar7 = new PlotChoiceRequirement(resourceList,fVar1,0);
                if (lVar8 == null) throw; // [null/range check failed]
                HudController.AddHudResourceShowData(lVar8,uVar7,0);
              }
            }
            return;
          }
        }
    }

    // Token : 0x6001005
    // RVA   : 0xBA9660   Offset: 0xBA7E60   Length: 0xEC
    public void ChangeResource(List<ResourceData> resourceList, bool showInfo, bool showHud)
    {
        var pStatics = *(int64*)(DAT_181d4ef00 + 184);
        void ForceData.ChangeResource
                     (int64 this,uint32 resourceList,float showInfo,char showHud,char param_5)
        {
        float fVar1;
        int64 lVar2;
        int64 lVar3;
        uint64 uVar4;
        float fVar5;
        uint64 uVar6;
        uint64 uVar7;
        int64 lVar8;
        uint32 uVar9;
        float local_res18 [2];
        uint64 local_58;
        uint64 uStack_50;
        lVar8 = (int64)(int)resourceList;
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
          fVar1 = *(float *)(lVar2._items + 32 + lVar8 * 4);
          if (lVar3 != null) {
            if (lVar3.Count <= resourceList) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            uVar9 = Mathf.Min(fVar5 + fVar1,
                               *(uint32 *)(lVar3._items + 32 + lVar8 * 4),0);
            FUN_181814d10(lVar2,resourceList,uVar9,DAT_181d79758);
            if (showHud) {
              uVar7 = this.forceName;
              lVar2 = **(int64 **)(DAT_181d5a578 + 184);
              lVar3 = *(int64 *)(pStatics + 0x430);
              if (lVar3 == null) throw; // [null/range check failed]
              if (lVar3.Count <= resourceList) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              uVar4 = *(uint64 *)(lVar3._items + 32 + lVar8 * 8);
              uVar6 = Single.ToString(local_res18,"+0;-0;0",0);
              uVar7 = String.Concat(uVar7,uVar4,uVar6,0);
              lVar3 = *(int64 *)(pStatics + 0x430);
              if (lVar3 == null) throw; // [null/range check failed]
              if (lVar3.Count <= resourceList) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              fVar1 = local_res18[0];
              uVar4 = *(uint64 *)(lVar3._items + 32 + lVar8 * 8);
              switch(resourceList) {
              case 0:
                uVar6 = "GetMoney";
                break;
              case 1:
                uVar6 = "GetFood";
                break;
              case 2:
                uVar6 = "Wood";
                break;
              case 3:
                uVar6 = "Rock";
                break;
              case 4:
                uVar6 = "Med";
                break;
              case 5:
                uVar6 = "FameDown";
                if (0.0 < fVar1) {
                  uVar6 = "FameUp";
                }
                break;
              default:
                uVar6 = 0;
              }
              if (lVar2 == null) throw; // [null/range check failed]
              local_58 = 0;
              uStack_50 = 0;
              InfoController.AddInfoTab
                        (lVar2,uVar7,"UIAtlas",uVar4,uVar6,0x3f800000,0x40a00000,&local_58,0);
            }
            if (param_5) {
              lVar8 = FUN_18046c0a0(0);
              if (((lVar8 == null) || (*(int64 *)(lVar8 + 32) == 0)) ||
                 (lVar8 = WorldData.Player(*(int64 *)(lVar8 + 32),0)) == null)
              throw; // [null/range check failed]
              if (*(int *)(lVar8 + 132) == this.forceID) {
                fVar1 = local_res18[0];
                lVar8 = **(int64 **)(DAT_181d51d80 + 184);
                var uVar7 = new PlotChoiceRequirement(resourceList,fVar1,0);
                if (lVar8 == null) throw; // [null/range check failed]
                HudController.AddHudResourceShowData(lVar8,uVar7,0);
              }
            }
            return;
          }
        }
    }

    // Token : 0x6001006
    // RVA   : 0xBA9820   Offset: 0xBA8020   Length: 0x2DC
    public void ChangeResource(int id, float num, bool showInfo, bool showHud)
    {
        var pStatics = *(int64*)(DAT_181d4ef00 + 184);
        void ForceData.ChangeResource
                     (int64 this,uint32 id,float num,char showInfo,char showHud)
        {
        float fVar1;
        int64 lVar2;
        int64 lVar3;
        uint64 uVar4;
        float fVar5;
        uint64 uVar6;
        uint64 uVar7;
        int64 lVar8;
        uint32 uVar9;
        float local_res18 [2];
        uint64 local_58;
        uint64 uStack_50;
        lVar8 = (int64)(int)id;
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
          fVar1 = *(float *)(lVar2._items + 32 + lVar8 * 4);
          if (lVar3 != null) {
            if (lVar3.Count <= id) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            uVar9 = Mathf.Min(fVar5 + fVar1,
                               *(uint32 *)(lVar3._items + 32 + lVar8 * 4),0);
            FUN_181814d10(lVar2,id,uVar9,DAT_181d79758);
            if (showInfo) {
              uVar7 = this.forceName;
              lVar2 = **(int64 **)(DAT_181d5a578 + 184);
              lVar3 = *(int64 *)(pStatics + 0x430);
              if (lVar3 == null) throw; // [null/range check failed]
              if (lVar3.Count <= id) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              uVar4 = *(uint64 *)(lVar3._items + 32 + lVar8 * 8);
              uVar6 = Single.ToString(local_res18,"+0;-0;0",0);
              uVar7 = String.Concat(uVar7,uVar4,uVar6,0);
              lVar3 = *(int64 *)(pStatics + 0x430);
              if (lVar3 == null) throw; // [null/range check failed]
              if (lVar3.Count <= id) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              fVar1 = local_res18[0];
              uVar4 = *(uint64 *)(lVar3._items + 32 + lVar8 * 8);
              switch(id) {
              case 0:
                uVar6 = "GetMoney";
                break;
              case 1:
                uVar6 = "GetFood";
                break;
              case 2:
                uVar6 = "Wood";
                break;
              case 3:
                uVar6 = "Rock";
                break;
              case 4:
                uVar6 = "Med";
                break;
              case 5:
                uVar6 = "FameDown";
                if (0.0 < fVar1) {
                  uVar6 = "FameUp";
                }
                break;
              default:
                uVar6 = 0;
              }
              if (lVar2 == null) throw; // [null/range check failed]
              local_58 = 0;
              uStack_50 = 0;
              InfoController.AddInfoTab
                        (lVar2,uVar7,"UIAtlas",uVar4,uVar6,0x3f800000,0x40a00000,&local_58,0);
            }
            if (showHud) {
              lVar8 = FUN_18046c0a0(0);
              if (((lVar8 == null) || (*(int64 *)(lVar8 + 32) == 0)) ||
                 (lVar8 = WorldData.Player(*(int64 *)(lVar8 + 32),0)) == null)
              throw; // [null/range check failed]
              if (*(int *)(lVar8 + 132) == this.forceID) {
                fVar1 = local_res18[0];
                lVar8 = **(int64 **)(DAT_181d51d80 + 184);
                var uVar7 = new PlotChoiceRequirement(id,fVar1,0);
                if (lVar8 == null) throw; // [null/range check failed]
                HudController.AddHudResourceShowData(lVar8,uVar7,0);
              }
            }
            return;
          }
        }
    }

    // Token : 0x6001007
    // RVA   : 0xBAADF0   Offset: 0xBA95F0   Length: 0x88
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

    // Token : 0x6001008
    // RVA   : 0xBA9F90   Offset: 0xBA8790   Length: 0xD3
    public void CostResource(List<float> resourceList, bool showInfo)
    {
        ForceData.ChangeResource(this,resourceList,showInfo ^ 0x80000000,param_4,1,0);
    }

    // Token : 0x6001009
    // RVA   : 0xBA9E50   Offset: 0xBA8650   Length: 0x102
    public void CostResource(List<ResourceData> resourceList, bool showInfo)
    {
        ForceData.ChangeResource(this,resourceList,showInfo ^ 0x80000000,param_4,1,0);
    }

    // Token : 0x600100A
    // RVA   : 0xBAA070   Offset: 0xBA8870   Length: 0x39
    public void CostResource(ResourceData resource, bool showInfo)
    {
        ForceData.ChangeResource(this,resource,showInfo ^ 0x80000000,param_4,1,0);
    }

    // Token : 0x600100B
    // RVA   : 0xBA9F60   Offset: 0xBA8760   Length: 0x23
    public void CostResource(int id, float num, bool showInfo)
    {
        ForceData.ChangeResource(this,id,num ^ 0x80000000,showInfo,1,0);
    }

    // Token : 0x600100C
    // RVA   : 0xBAC150   Offset: 0xBAA950   Length: 0xBE
    public HeroData GetLeader()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        long lVar1;
        if ((*pStatics != 0) &&
           (lVar1 = *(int64 *)(*pStatics + 32)) != null) {
          WorldData.GetHero(lVar1,this.leader,0);
          return;
        }
    }

    // Token : 0x600100D
    // RVA   : 0xBAE590   Offset: 0xBACD90   Length: 0x4EB
    public void SetLeader(HeroData targetHero, bool showInfo)
    {
        int iVar1;
        uint uVar2;
        long lVar3;
        long lVar4;
        ulong uVar5;
        ulong uVar6;
        ulong local_28;
        ulong uStack_20;
        if (targetHero == null) goto LAB_180baea76;
        if (*(int *)(targetHero + 132) == this.forceID) {
          lVar3 = ForceData.GetLeader(this,0);
          if (lVar3 != null) {
            lVar3 = ForceData.GetLeader(this,0);
            if (lVar3 == null) goto LAB_180baea76;
            *(uint8 *)(lVar3 + 180) = 0;
            lVar3 = ForceData.GetLeader(this,0);
            if (lVar3 == null) goto LAB_180baea76;
            HeroData.set_HeroIconDirty(lVar3,1,0);
          }
          this.leader = *(uint32 *)(targetHero + 88);
          *(uint8 *)(targetHero + 180) = 1;
          HeroData.ChangeHeroForceLv(targetHero,5 - *(int *)(targetHero + 184),0,0);
          HeroData.ClearForceJob(targetHero,0);
          if (*(int *)(targetHero + 88) == 0) {
            lVar3 = FUN_18046c0a0(0);
            if ((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) goto LAB_180baea76;
            *(uint8 *)(*(int64 *)(lVar3 + 32) + 184) = 0;
            lVar3 = FUN_18046c0a0(0);
            if ((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) goto LAB_180baea76;
            *(uint8 *)(*(int64 *)(lVar3 + 32) + 185) = 0;
            if (*(int64 *)(targetHero + 0x2e0) != 0) {
              lVar3 = FUN_18046c0a0(0);
              if (lVar3 == null) goto LAB_180baea76;
              GameController.GiveUpForceMission(lVar3,0,1,0);
            }
            lVar3 = FUN_18046c0a0(0);
            if (((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) ||
               (lVar3 = *(int64 *)(*(int64 *)(lVar3 + 32) + 104)) == null)
            goto LAB_180baea76;
            iVar1 = *(int *)(lVar3 + 24);
            while (iVar1 = iVar1 + -1, -1 < iVar1) {
              lVar3 = FUN_18046c0a0(0);
              if (((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) ||
                 ((lVar3 = *(int64 *)(*(int64 *)(lVar3 + 32) + 104), lVar3 == null ||
                  (lVar3 = FUN_180002f80(lVar3,iVar1,DAT_181d5e680)) == null))) goto LAB_180baea76;
              if (*(int *)(lVar3 + 136) == 2) {
                lVar3 = FUN_18046c0a0(0);
                lVar4 = FUN_18046c0a0(0);
                if ((((lVar4 == null) || (*(int64 *)(lVar4 + 32) == 0)) ||
                    (lVar4 = *(int64 *)(*(int64 *)(lVar4 + 32) + 104)) == null) ||
                   (uVar5 = FUN_180002f80(lVar4,iVar1,DAT_181d5e680), lVar3 == null)) goto LAB_180baea76;
                GameController.RemoveEvent(lVar3,uVar5,0);
              }
            }
          }
          this.forceDetailDirty = 1;
          HeroData.set_HeroIconDirty(targetHero,1,0);
          if (showInfo) {
            lVar3 = **(int64 **)(DAT_181d5a578 + 184);
            uVar5 = String.Format("{0}接任了{1}掌门之位。",*(uint64 *)(targetHero + 104),
                                   this.forceName,0);
            uVar2 = this.forceID;
            uVar6 = GlobalData.GetForceIconName(uVar2,0);
            if (lVar3 == null) goto LAB_180baea76;
            local_28 = 0;
            uStack_20 = 0;
            InfoController.AddInfoTab
                      (lVar3,uVar5,"UIAtlas",uVar6,"NoticeImportant",0x3f800000,0x40a00000,&local_28,0);
          }
          if (*(int *)(targetHero + 88) == 0) {
            lVar3 = FUN_18046c100(0);
            if (lVar3 == null) {
        LAB_180baea76:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            GameDataController.ChangeAchStats(lVar3,21,0x3f800000);
          }
        }
        else {
          uVar5 = String.Format("无法将非门派{0}角色{1}设置为掌门！",this.forceName,
                                 *(uint64 *)(targetHero + 104),0);
          Debug.LogError(uVar5,0);
        }
    }

    // Token : 0x600100E
    // RVA   : 0xBA8720   Offset: 0xBA6F20   Length: 0xA9
    public void AddHero(HeroData targetHero)
    {
        if (targetHero != null) {
          *(uint32 *)(targetHero + 132) = this.forceID;
          *(uint32 *)(targetHero + 216) = param_4;
          if (this.ownHeros != null) {
            FUN_181814fa0(this.ownHeros,*(uint32 *)(targetHero + 88),DAT_181d67a78);
            HeroData.ChangeHeroForceLv(targetHero,param_3 - *(int *)(targetHero + 184),0,0);
            this.forceDetailDirty = 1;
            return;
          }
        }
    }

    // Token : 0x600100F
    // RVA   : 0xBA87D0   Offset: 0xBA6FD0   Length: 0x9F
    public void AddHero(HeroData targetHero, int _forceLv, int _generation)
    {
        if (targetHero != null) {
          *(uint32 *)(targetHero + 132) = this.forceID;
          *(uint32 *)(targetHero + 216) = _generation;
          if (this.ownHeros != null) {
            FUN_181814fa0(this.ownHeros,*(uint32 *)(targetHero + 88),DAT_181d67a78);
            HeroData.ChangeHeroForceLv(targetHero,_forceLv - *(int *)(targetHero + 184),0,0);
            this.forceDetailDirty = 1;
            return;
          }
        }
    }

    // Token : 0x6001010
    // RVA   : 0xBAD7E0   Offset: 0xBABFE0   Length: 0x74
    public void RemoveHero(HeroData targetHero)
    {
        if (targetHero != null) {
          *(uint32 *)(targetHero + 132) = 0xffffffff;
          *(uint32 *)(targetHero + 0x1c0) = 0;
          if (this.ownHeros != null) {
            FUN_181801c10(this.ownHeros,*(uint32 *)(targetHero + 88),DAT_181d67e70);
            this.forceDetailDirty = 1;
            return;
          }
        }
    }

    // Token : 0x6001011
    // RVA   : 0xBAA420   Offset: 0xBA8C20   Length: 0x2E7
    public void ForceConquerArea(AreaData targetArea, bool showInfo)
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        int iVar1;
        long lVar2;
        long lVar3;
        ulong uVar4;
        ulong uVar5;
        ulong local_18;
        ulong uStack_10;
        if (targetArea == null) throw; // [null/range check failed]
        iVar1 = *(int *)(targetArea + 112);
        AreaData.SetBranchLeader(targetArea,0,0);
        AreaData.ResetAutoSetting(targetArea,0);
        if (-1 < *(int *)(targetArea + 112)) {
          lVar2 = AreaData.GetForce(targetArea,0);
          if ((lVar2 == null) || (*(int64 *)(lVar2 + 96) == 0)) throw; // [null/range check failed]
          FUN_181801c10(*(int64 *)(lVar2 + 96),*(uint32 *)(targetArea + 16),DAT_181d67e70);
          lVar2 = AreaData.GetForce(targetArea,0);
          if (lVar2 == null) throw; // [null/range check failed]
          *(uint8 *)(lVar2 + 0x10c) = 1;
          lVar2 = AreaData.GetForce(targetArea,0);
          if (lVar2 == null) throw; // [null/range check failed]
          *(uint8 *)(lVar2 + 0x10d) = 1;
        }
        if (this.ownAreasID != null) {
          FUN_181814fa0(this.ownAreasID,*(uint32 *)(targetArea + 16),DAT_181d67a78);
          AreaData.ResetAllState(targetArea,0);
          AreaData.AreaConquerReduceDefenceLv(targetArea,0);
          this.forceDetailDirty = 0x101;
          *(uint32 *)(targetArea + 112) = this.forceID;
          if (showInfo) {
            uVar5 = this.forceName;
            lVar2 = **(int64 **)(DAT_181d5a578 + 184);
            uVar4 = "占据了";
            if (-1 < iVar1) {
              if (((*pStatics == 0) ||
                  (lVar3 = *(int64 *)(*pStatics + 32)) == null) ||
                 (lVar3 = WorldData.GetForce(lVar3,iVar1,0)) == null) throw; // [null/range check failed]
              uVar4 = String.Format("从{0}手中夺取了",*(uint64 *)(lVar3 + 24),0);
            }
            uVar5 = String.Concat(uVar5,uVar4,*(uint64 *)(targetArea + 24),0);
            if (lVar2 == null) throw; // [null/range check failed]
            local_18 = 0;
            uStack_10 = 0;
            InfoController.AddInfoTab
                      (lVar2,uVar5,"UIAtlas","资源_占领地","NoticeImportant",0x3f800000,0x40a00000,
                       &local_18,0);
          }
          return;
        }
    }

    // Token : 0x6001012
    // RVA   : 0xBAA710   Offset: 0xBA8F10   Length: 0x11A
    public void ForceConquerResourcePoint(AreaData targetArea, bool showInfo)
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        int iVar1;
        long lVar2;
        long lVar3;
        ulong uVar4;
        ulong uVar5;
        ulong local_18;
        ulong uStack_10;
        if (targetArea == null) throw; // [null/range check failed]
        iVar1 = *(int *)(targetArea + 56);
        if (-1 < iVar1) {
          lVar2 = ResourcePointData.GetForce(targetArea,0);
          if ((lVar2 == null) || (*(int64 *)(lVar2 + 104) == 0)) throw; // [null/range check failed]
          FUN_181801c10(*(int64 *)(lVar2 + 104),*(uint32 *)(targetArea + 16),DAT_181d67e70);
          lVar2 = ResourcePointData.GetForce(targetArea,0);
          if (lVar2 == null) throw; // [null/range check failed]
          *(uint8 *)(lVar2 + 0x10c) = 1;
          lVar2 = ResourcePointData.GetForce(targetArea,0);
          if (lVar2 == null) throw; // [null/range check failed]
          *(uint8 *)(lVar2 + 0x10d) = 1;
        }
        if (this.ownResourcePointsID != null) {
          FUN_181814fa0(this.ownResourcePointsID,*(uint32 *)(targetArea + 16),DAT_181d67a78);
          this.forceDetailDirty = 0x101;
          *(uint32 *)(targetArea + 56) = this.forceID;
          if (showInfo) {
            uVar5 = this.forceName;
            lVar2 = **(int64 **)(DAT_181d5a578 + 184);
            uVar4 = "占据了";
            if (-1 < iVar1) {
              if (((*pStatics == 0) ||
                  (lVar3 = *(int64 *)(*pStatics + 32)) == null) ||
                 (lVar3 = WorldData.GetForce(lVar3,iVar1,0)) == null) throw; // [null/range check failed]
              uVar4 = String.Format("从{0}手中夺取了",*(uint64 *)(lVar3 + 24),0);
            }
            uVar5 = String.Concat(uVar5,uVar4,*(uint64 *)(targetArea + 32),0);
            if (lVar2 == null) throw; // [null/range check failed]
            local_18 = 0;
            uStack_10 = 0;
            InfoController.AddInfoTab
                      (lVar2,uVar5,"UIAtlas","资源_占领地","NoticeImportant",0x3f800000,0x40a00000,
                       &local_18,0);
          }
          return;
        }
    }

    // Token : 0x6001013
    // RVA   : 0xBAA830   Offset: 0xBA9030   Length: 0x2BA
    public void ForceConquerResourcePoint(ResourcePointData targetResourcePoint, bool showInfo)
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        int iVar1;
        long lVar2;
        long lVar3;
        ulong uVar4;
        ulong uVar5;
        ulong local_18;
        ulong uStack_10;
        if (targetResourcePoint == null) throw; // [null/range check failed]
        iVar1 = *(int *)(targetResourcePoint + 56);
        if (-1 < iVar1) {
          lVar2 = ResourcePointData.GetForce(targetResourcePoint,0);
          if ((lVar2 == null) || (*(int64 *)(lVar2 + 104) == 0)) throw; // [null/range check failed]
          FUN_181801c10(*(int64 *)(lVar2 + 104),*(uint32 *)(targetResourcePoint + 16),DAT_181d67e70);
          lVar2 = ResourcePointData.GetForce(targetResourcePoint,0);
          if (lVar2 == null) throw; // [null/range check failed]
          *(uint8 *)(lVar2 + 0x10c) = 1;
          lVar2 = ResourcePointData.GetForce(targetResourcePoint,0);
          if (lVar2 == null) throw; // [null/range check failed]
          *(uint8 *)(lVar2 + 0x10d) = 1;
        }
        if (this.ownResourcePointsID != null) {
          FUN_181814fa0(this.ownResourcePointsID,*(uint32 *)(targetResourcePoint + 16),DAT_181d67a78);
          this.forceDetailDirty = 0x101;
          *(uint32 *)(targetResourcePoint + 56) = this.forceID;
          if (showInfo) {
            uVar5 = this.forceName;
            lVar2 = **(int64 **)(DAT_181d5a578 + 184);
            uVar4 = "占据了";
            if (-1 < iVar1) {
              if (((*pStatics == 0) ||
                  (lVar3 = *(int64 *)(*pStatics + 32)) == null) ||
                 (lVar3 = WorldData.GetForce(lVar3,iVar1,0)) == null) throw; // [null/range check failed]
              uVar4 = String.Format("从{0}手中夺取了",*(uint64 *)(lVar3 + 24),0);
            }
            uVar5 = String.Concat(uVar5,uVar4,*(uint64 *)(targetResourcePoint + 32),0);
            if (lVar2 == null) throw; // [null/range check failed]
            local_18 = 0;
            uStack_10 = 0;
            InfoController.AddInfoTab
                      (lVar2,uVar5,"UIAtlas","资源_占领地","NoticeImportant",0x3f800000,0x40a00000,
                       &local_18,0);
          }
          return;
        }
    }

    // Token : 0x6001014
    // RVA   : 0xBAD050   Offset: 0xBAB850   Length: 0x174
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
          if (((*(byte *)(DAT_181d4ef00 + 0x133) & 4) != 0) && (*(int *)(DAT_181d4ef00 + 224) == 0)) {
            il2cpp_runtime_class_init(DAT_181d4ef00);
            lVar5 = this.kungfuSkillFocus;
          }
          lVar1 = *(int64 *)(*(int64 *)(DAT_181d4ef00 + 184) + 0x498);
          if ((lVar5 == null) || (uVar2 = FUN_1800d6750(lVar5,iVar6,DAT_181d68270), lVar1 == null)) break;
          uVar3 = FUN_180002f80(lVar1,uVar2,DAT_181d7c9c0);
          uVar4 = String.Concat(uVar4,uVar7,uVar3,0);
          iVar6 = iVar6 + 1;
          lVar5 = this.kungfuSkillFocus;
        }
    }

    // Token : 0x6001015
    // RVA   : 0xBAB840   Offset: 0xBAA040   Length: 0x902
    public string GetJoinForceNeedDescribe()
    {
        var pStatics_2920 = *(int64*)(DAT_181da2920 + 184);
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        var pStatics_ef00 = *(int64*)(DAT_181d4ef00 + 184);
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
          if ((*pStatics_df90 == 0) ||
             (lVar5 = *(int64 *)(*pStatics_df90 + 32)) == null)
          goto LAB_180bac131;
          lVar5 = WorldData.Player(lVar5,0);
          if (this.forceMaleRate == 1.0) {
            if (lVar5 == null) goto LAB_180bac131;
            uVar12 = *(char *)(lVar5 + 128) == false;
          }
          else if (this.forceMaleRate == null.0) {
            if (lVar5 == null) goto LAB_180bac131;
            uVar12 = *(uint8 *)(lVar5 + 128);
          }
          else {
            uVar12 = 1;
          }
          uVar6 = GlobalData.GenerateChangeColorText(uVar6,uVar12,0);
        }
        cVar3 = FUN_1816fd990(uVar6,"",0);
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
        local_res8[0] = fVar13 * *(float *)(pStatics_2920 + 4);
        uVar7 = il2cpp_value_box(DAT_181d7d0b8,local_res8);
        uVar8 = String.Format(uVar8,uVar7,0);
        if (((*pStatics_df90 == 0) ||
            (lVar5 = *(int64 *)(*pStatics_df90 + 32)) == null) ||
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
        fVar1 = *(float *)(pStatics_2920 + 4);
        uVar8 = GlobalData.GenerateChangeColorText(uVar8,fVar1 * fVar14 <= fVar13,0);
        uVar6 = String.Concat(uVar6,uVar9,uVar8,0);
        iVar11 = 0;
        iVar10 = 0;
        lVar5 = this.kungfuSkillFocus;
        while (lVar5 != null) {
          if (lVar5.Count <= iVar10) {
            lVar5 = this.livingSkillFocus;
            goto joined_r0x000180babeb6;
          }
          if (((*(byte *)(DAT_181d4ef00 + 0x133) & 4) != 0) && (*(int *)(DAT_181d4ef00 + 224) == 0)) {
            il2cpp_runtime_class_init(DAT_181d4ef00);
            lVar5 = this.kungfuSkillFocus;
          }
          lVar2 = *(int64 *)(pStatics_ef00 + 0x498);
          if ((lVar5 == null) || (uVar4 = FUN_1800d6750(lVar5,iVar10,DAT_181d68270), lVar2 == null)) break;
          uVar9 = FUN_180002f80(lVar2,uVar4,DAT_181d7c9c0);
          uVar8 = "\n{0} {1}";
          if (!this.bigForce) {
            fVar13 = 0.5;
          }
          else {
            fVar13 = 1.0;
          }
          local_res8[0] = fVar13 * **(float **)(DAT_181da2920 + 184);
          uVar7 = il2cpp_value_box(DAT_181d7d0b8,local_res8);
          uVar8 = String.Format(uVar8,uVar9,uVar7,0);
          lVar5 = FUN_18046c0a0(0);
          if (((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) ||
             (lVar5 = WorldData.Player(*(int64 *)(lVar5 + 32),0)) == null) {
        LAB_180bac137:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          lVar5 = *(int64 *)(lVar5 + 0x150);
          if ((this.kungfuSkillFocus == null) ||
             (uVar4 = FUN_1800d6750(this.kungfuSkillFocus,iVar10,DAT_181d68270), lVar5 == null))
          goto LAB_180bac137;
          fVar13 = (float)FUN_1800d6780(lVar5,uVar4,DAT_181d796d8);
          if (!this.bigForce) {
            fVar14 = 0.5;
          }
          else {
            fVar14 = 1.0;
          }
          fVar1 = **(float **)(DAT_181da2920 + 184);
          uVar8 = GlobalData.GenerateChangeColorText(uVar8,fVar1 * fVar14 <= fVar13,0);
          uVar6 = String.Concat(uVar6,uVar8,0);
          iVar10 = iVar10 + 1;
          lVar5 = this.kungfuSkillFocus;
        }
        LAB_180bac131:
                          // WARNING: Subroutine does not return
        FUN_1800d6620();
        joined_r0x000180babeb6:
        if (lVar5 == null) goto LAB_180bac131;
        if (lVar5.Count <= iVar11) {
          return uVar6;
        }
        if (((*(byte *)(DAT_181d4ef00 + 0x133) & 4) != 0) && (*(int *)(DAT_181d4ef00 + 224) == 0)) {
          il2cpp_runtime_class_init(DAT_181d4ef00);
          lVar5 = this.livingSkillFocus;
        }
        lVar2 = *(int64 *)(pStatics_ef00 + 0x4a8);
        if ((lVar5 == null) || (uVar4 = FUN_1800d6750(lVar5,iVar11,DAT_181d68270), lVar2 == null))
        goto LAB_180bac131;
        uVar9 = FUN_180002f80(lVar2,uVar4,DAT_181d7c9c0);
        uVar8 = "\n{0} {1}";
        if (!this.bigForce) {
          fVar13 = 0.5;
        }
        else {
          fVar13 = 1.0;
        }
        local_res8[0] = fVar13 * **(float **)(DAT_181da2920 + 184);
        uVar7 = il2cpp_value_box(DAT_181d7d0b8,local_res8);
        uVar8 = String.Format(uVar8,uVar9,uVar7,0);
        lVar5 = FUN_18046c0a0(0);
        if (((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) ||
           (lVar5 = WorldData.Player(*(int64 *)(lVar5 + 32),0)) == null) {
        LAB_180bac13d:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        lVar5 = *(int64 *)(lVar5 + 0x168);
        if ((this.livingSkillFocus == null) ||
           (uVar4 = FUN_1800d6750(this.livingSkillFocus,iVar11,DAT_181d68270), lVar5 == null))
        goto LAB_180bac13d;
        fVar13 = (float)FUN_1800d6780(lVar5,uVar4,DAT_181d796d8);
        if (!this.bigForce) {
          fVar14 = 0.5;
        }
        else {
          fVar14 = 1.0;
        }
        fVar1 = **(float **)(DAT_181da2920 + 184);
        uVar8 = GlobalData.GenerateChangeColorText(uVar8,fVar1 * fVar14 <= fVar13,0);
        uVar6 = String.Concat(uVar6,uVar8,0);
        iVar11 = iVar11 + 1;
        lVar5 = this.livingSkillFocus;
        goto joined_r0x000180babeb6;
    }

    // Token : 0x6001016
    // RVA   : 0xBAD2E0   Offset: 0xBABAE0   Length: 0x4AD
    public bool PlayerMeetForceJoinRequire()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        uint uVar1;
        long lVar2;
        int iVar4;
        int iVar5;
        float fVar6;
        float fVar7;
        if ((*pStatics == 0) ||
           (lVar2 = *(int64 *)(*pStatics + 32)) == null)
        goto LAB_180bad788;
        lVar2 = WorldData.Player(lVar2,0);
        if (this.forceMaleRate == 1.0) {
          if (lVar2 == null) goto LAB_180bad788;
          pfVar3 = (float *)CONCAT71((int7)((uint64)lVar2 >> 8),*(char *)(lVar2 + 128) == false);
        LAB_180bad435:
          if ((char)!pfVar3) goto LAB_180bad784;
        }
        else if (this.forceMaleRate == null.0) {
          if (lVar2 == null) goto LAB_180bad788;
          pfVar3 = (float *)(uint64)*(byte *)(lVar2 + 128);
          goto LAB_180bad435;
        }
        if (((*pStatics != 0) &&
            (lVar2 = *(int64 *)(*pStatics + 32)) != null) &&
           (lVar2 = WorldData.Player(lVar2,0)) != null) {
          fVar6 = *(float *)(lVar2 + 0x1c4);
          if (!this.bigForce) {
            fVar7 = 0.5;
          }
          else {
            fVar7 = 1.0;
          }
          pfVar3 = *(float **)(DAT_181da2920 + 184);
          if (fVar6 < fVar7 * pfVar3[1]) {
        LAB_180bad784:
            return (uint64)pfVar3 & 0xffffffffffffff00;
          }
          lVar2 = this.kungfuSkillFocus;
          iVar4 = 0;
          iVar5 = 0;
          if (lVar2 != null) {
            while (iVar5 < lVar2.Count) {
              lVar2 = FUN_18046c0a0(0);
              if (((lVar2 == null) || (*(int64 *)(lVar2 + 32) == 0)) ||
                 (lVar2 = WorldData.Player(*(int64 *)(lVar2 + 32),0)) == null)
              goto LAB_180bad788;
              lVar2 = *(int64 *)(lVar2 + 0x150);
              if ((this.kungfuSkillFocus == null) ||
                 (uVar1 = FUN_1800d6750(this.kungfuSkillFocus,iVar5,DAT_181d68270), lVar2 == null))
              goto LAB_180bad788;
              fVar6 = (float)FUN_1800d6780(lVar2,uVar1,DAT_181d796d8);
              if (!this.bigForce) {
                fVar7 = 0.5;
              }
              else {
                fVar7 = 1.0;
              }
              pfVar3 = *(float **)(DAT_181da2920 + 184);
              if (fVar6 < fVar7 * *pfVar3) goto LAB_180bad784;
              lVar2 = this.kungfuSkillFocus;
              iVar5 = iVar5 + 1;
              if (lVar2 == null) goto LAB_180bad788;
            }
            lVar2 = this.livingSkillFocus;
            if (lVar2 != null) goto LAB_180bad660;
          }
        }
        LAB_180bad788:
                          // WARNING: Subroutine does not return
        FUN_1800d6620();
        LAB_180bad660:
        if (lVar2.Count <= iVar4) {
          return CONCAT71((int7)((uint64)lVar2 >> 8),1);
        }
        lVar2 = FUN_18046c0a0(0);
        if (((lVar2 == null) || (*(int64 *)(lVar2 + 32) == 0)) ||
           (lVar2 = WorldData.Player(*(int64 *)(lVar2 + 32),0)) == null) goto LAB_180bad788;
        lVar2 = *(int64 *)(lVar2 + 0x168);
        if ((this.livingSkillFocus == null) ||
           (uVar1 = FUN_1800d6750(this.livingSkillFocus,iVar4,DAT_181d68270), lVar2 == null))
        goto LAB_180bad788;
        fVar6 = (float)FUN_1800d6780(lVar2,uVar1,DAT_181d796d8);
        if (!this.bigForce) {
          fVar7 = 0.5;
        }
        else {
          fVar7 = 1.0;
        }
        pfVar3 = *(float **)(DAT_181da2920 + 184);
        if (fVar6 < fVar7 * *pfVar3) goto LAB_180bad784;
        lVar2 = this.livingSkillFocus;
        iVar4 = iVar4 + 1;
        if (lVar2 == null) goto LAB_180bad788;
        goto LAB_180bad660;
    }

    // Token : 0x6001017
    // RVA   : 0xBA9CD0   Offset: 0xBA84D0   Length: 0x175
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
        plVar1 = (int64 *)il2cpp_internal(DAT_181d63ff0);
        plVar4 = plVar1;
        MemoryStream.ctor(plVar1,1000,0);
        local_38 = 0;
        uStack_30 = 0;
        StreamingContext.ctor(&local_38,64,0);
        lVar2 = il2cpp_internal(DAT_181d8c5a8);
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
            FUN_180002970(0,DAT_181d53c70,plVar1);
            return uVar3;
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
    }

    // Token : 0x6001018
    // RVA   : 0xBAF3A0   Offset: 0xBADBA0   Length: 0x4E
    private static void /*cctor*/()
    {
        **(uint32 **)(DAT_181da2920 + 184) = 0x41a00000;
        *(uint32 *)(*(int64 *)(DAT_181da2920 + 184) + 4) = 0x42480000;
    }

}
