// ============================================================
// Type  : AreaData
// Token : 0x20001F3
// ============================================================

public class AreaData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000D7F
    public int areaID;

    // Token: 0x4000D80
    public string areaName;

    // Token: 0x4000D81
    public int areaStartLv;

    // Token: 0x4000D82
    public string spriteName;

    // Token: 0x4000D83
    public string backgroundType;

    // Token: 0x4000D84
    public int backgroundSkinID;

    // Token: 0x4000D85
    public float xScale;

    // Token: 0x4000D86
    public BigMapPos bigMapPos;

    // Token: 0x4000D87
    public int areaType;

    // Token: 0x4000D88
    public float maxPeople;

    // Token: 0x4000D89
    public float people;

    // Token: 0x4000D8A
    public float safe;

    // Token: 0x4000D8B
    public float support;

    // Token: 0x4000D8C
    public float defence;

    // Token: 0x4000D8D
    public List<float> changeAreaState;

    // Token: 0x4000D8E
    public List<float> changeAllAreaState;

    // Token: 0x4000D8F
    public int belongForceID;

    // Token: 0x4000D90
    public List<int> insideHeros;

    // Token: 0x4000D91
    public List<float> changeResource;

    // Token: 0x4000D92
    public List<float> resourceValueRateBase;

    // Token: 0x4000D93
    public List<float> resourceValueRateTemp;

    // Token: 0x4000D94
    public List<int> connectAreaID;

    // Token: 0x4000D95
    public List<int> nearAreaID;

    // Token: 0x4000D96
    public List<int> connectResourcePointID;

    // Token: 0x4000D97
    public ForceSpeAddData areaSpeAddData;

    // Token: 0x4000D98
    public int mapWidth;

    // Token: 0x4000D99
    public int mapHeight;

    // Token: 0x4000D9A
    public List<AreaTileData> areaTiles;

    // Token: 0x4000D9B
    public List<int> roadTiles;

    // Token: 0x4000D9C
    public List<int> areaBranchDefenceLv;

    // Token: 0x4000D9D
    public List<int> areaBranchDefenceUpgradeLeftTime;

    // Token: 0x4000D9E
    public List<AreaTreasurePriceData> areaTreasurePriceData;

    // Token: 0x4000D9F
    public List<string> recordLog;

    // Token: 0x4000DA0
    public bool areaDetailDirty;

    // Token: 0x4000DA1
    public bool areaInfoDirty;

    // Token: 0x4000DA2
    public int thisMonthManaged;

    // Token: 0x4000DA3
    public int missionNumCount;

    // Token: 0x4000DA4
    public int plotNumCount;

    // Token: 0x4000DA5
    public AreaInteractionTimeData areaInteractionTimeData;

    // Token: 0x4000DA6
    public List<string> speProduct;

    // Token: 0x4000DA7
    public List<float> speBoxColliderSize;

    // Token: 0x4000DA8
    public int branchLeaderID;

    // Token: 0x4000DA9
    public bool autoBuild;

    // Token: 0x4000DAA
    public float autoBuildResourceRateLimit;

    // Token: 0x4000DAB
    public int autoBuildPriority;

    // Token: 0x4000DAC
    private static List<int> UpgradeDefenceLvResourceID;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000F74
    // RVA   : 0x7EC220   Offset: 0x7EAA20   Length: 0x675
    public void /*ctor*/()
    {
        ulong uVar1;
        long lVar2;
        this.branchLeaderID = 0xffffffff;
        ZhSegment.Initialize(this,0);
        this.bigMapPos = new c.DisplayClass9_0(0);
        lVar2 = il2cpp_internal(DAT_181d721b0);
        FUN_180f58a90(lVar2,DAT_181d79358);
        if (lVar2 != null) {
          FUN_181805690(lVar2,0,DAT_181d79458);
          FUN_181805690(lVar2,0,DAT_181d79458);
          FUN_181805690(lVar2,0,DAT_181d79458);
          FUN_181805690(lVar2,0,DAT_181d79458);
          FUN_181805690(lVar2,0,DAT_181d79458);
          FUN_181805690(lVar2,0,DAT_181d79458);
          this.changeResource = lVar2;
          lVar2 = il2cpp_internal(DAT_181d721b0);
          FUN_180f58a90(lVar2,DAT_181d79358);
          if (lVar2 != null) {
            FUN_181805690(lVar2,0x3f800000,DAT_181d79458);
            FUN_181805690(lVar2,0x3f800000,DAT_181d79458);
            FUN_181805690(lVar2,0x3f800000,DAT_181d79458);
            FUN_181805690(lVar2,0x3f800000,DAT_181d79458);
            FUN_181805690(lVar2,0x3f800000,DAT_181d79458);
            FUN_181805690(lVar2,0x3f800000,DAT_181d79458);
            this.resourceValueRateBase = lVar2;
            lVar2 = il2cpp_internal(DAT_181d721b0);
            FUN_180f58a90(lVar2,DAT_181d79358);
            if (lVar2 != null) {
              FUN_181805690(lVar2,0,DAT_181d79458);
              FUN_181805690(lVar2,0,DAT_181d79458);
              FUN_181805690(lVar2,0,DAT_181d79458);
              FUN_181805690(lVar2,0,DAT_181d79458);
              FUN_181805690(lVar2,0,DAT_181d79458);
              FUN_181805690(lVar2,0,DAT_181d79458);
              this.resourceValueRateTemp = lVar2;
              lVar2 = il2cpp_internal(DAT_181d721b0);
              FUN_180f58a90(lVar2,DAT_181d79358);
              if (lVar2 != null) {
                FUN_181805690(lVar2,0,DAT_181d79458);
                FUN_181805690(lVar2,0,DAT_181d79458);
                FUN_181805690(lVar2,0,DAT_181d79458);
                FUN_181805690(lVar2,0,DAT_181d79458);
                this.changeAreaState = lVar2;
                lVar2 = il2cpp_internal(DAT_181d721b0);
                FUN_180f58a90(lVar2,DAT_181d79358);
                if (lVar2 != null) {
                  FUN_181805690(lVar2,0,DAT_181d79458);
                  FUN_181805690(lVar2,0,DAT_181d79458);
                  FUN_181805690(lVar2,0,DAT_181d79458);
                  FUN_181805690(lVar2,0,DAT_181d79458);
                  this.changeAllAreaState = lVar2;
                  uVar1 = il2cpp_internal(DAT_181d6f030);
                  FUN_180f58a90(uVar1,DAT_181d678f8);
                  this.connectAreaID = uVar1;
                  uVar1 = il2cpp_internal(DAT_181d6f030);
                  FUN_180f58a90(uVar1,DAT_181d678f8);
                  this.nearAreaID = uVar1;
                  uVar1 = il2cpp_internal(DAT_181d6f030);
                  FUN_180f58a90(uVar1,DAT_181d678f8);
                  this.connectResourcePointID = uVar1;
                  this.areaSpeAddData = new ForceSpeAddData(0);
                  lVar2 = il2cpp_internal(DAT_181d6f030);
                  FUN_180f58a90(lVar2,DAT_181d678f8);
                  if (lVar2 != null) {
                    FUN_181814fa0(lVar2,0,DAT_181d67a78);
                    FUN_181814fa0(lVar2,0,DAT_181d67a78);
                    FUN_181814fa0(lVar2,0,DAT_181d67a78);
                    FUN_181814fa0(lVar2,0,DAT_181d67a78);
                    FUN_181814fa0(lVar2,0,DAT_181d67a78);
                    this.areaBranchDefenceLv = lVar2;
                    lVar2 = il2cpp_internal(DAT_181d6f030);
                    FUN_180f58a90(lVar2,DAT_181d678f8);
                    if (lVar2 != null) {
                      FUN_181814fa0(lVar2,0,DAT_181d67a78);
                      FUN_181814fa0(lVar2,0,DAT_181d67a78);
                      FUN_181814fa0(lVar2,0,DAT_181d67a78);
                      FUN_181814fa0(lVar2,0,DAT_181d67a78);
                      FUN_181814fa0(lVar2,0,DAT_181d67a78);
                      this.areaBranchDefenceUpgradeLeftTime = lVar2;
                      uVar1 = il2cpp_internal(DAT_181d6c2b0);
                      FUN_180f58a90(uVar1,DAT_181d55560);
                      this.areaTreasurePriceData = uVar1;
                      lVar2 = new ZhSegment(0);
                      *(uint32 *)(lVar2 + 16) = 1;
                      *(uint32 *)(lVar2 + 20) = 1;
                      this.areaInteractionTimeData = lVar2;
                      uVar1 = il2cpp_internal(DAT_181d72a30);
                      FUN_180f58a90(uVar1,DAT_181d7c250);
                      this.recordLog = uVar1;
                      return;
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6000F75
    // RVA   : 0x7E9C20   Offset: 0x7E8420   Length: 0xD2
    public AreaData DataBase()
    {
        long lVar1;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d4e010 + 184) + 32);
        if ((lVar1 != null) && (lVar1 = *(int64 *)(lVar1 + 200)) != null) {
          FUN_1817cc780(lVar1,this.areaID,DAT_181d92810);
          return;
        }
    }

    // Token : 0x6000F76
    // RVA   : 0x7EB4F0   Offset: 0x7E9CF0   Length: 0x168
    public ResourceData GetUpgradeDefenceLvCost(int defenceType)
    {
        uint uVar1;
        int iVar2;
        long lVar3;
        long lVar4;
        ulong uVar5;
        float fVar6;
        lVar4 = **(int64 **)(DAT_181d876b0 + 184);
        if (lVar4 != null) {
          if (*(uint32 *)(lVar4 + 24) <= defenceType) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar3 = this.areaBranchDefenceLv;
          uVar1 = lVar4[defenceType];
          if (lVar3 != null) {
            if (lVar3.Count <= defenceType) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            iVar2 = lVar3._items[defenceType];
            lVar4 = AreaData.GetForce(this,0);
            if (lVar4 == null) {
              fVar6 = 1.0;
            }
            else {
              lVar4 = AreaData.GetForce(this,0);
              if (lVar4 == null) throw; // [null/range check failed]
              fVar6 = (float)ForceData.GetBuildCostRate(lVar4,0);
            }
            uVar5 = new PlotChoiceRequirement(uVar1,(float)(iVar2 + 1) * 200.0 * fVar6,0);
            return uVar5;
          }
        }
    }

    // Token : 0x6000F77
    // RVA   : 0x7EB660   Offset: 0x7E9E60   Length: 0x63
    public int GetUpgradeDefenceLvDay(int defenceType)
    {
        long lVar1;
        lVar1 = this.areaBranchDefenceLv;
        if (lVar1 != null) {
          if (lVar1.Count <= defenceType) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          return lVar1._items[defenceType] * 2 + 5;
        }
    }

    // Token : 0x6000F78
    // RVA   : 0x7EBAE0   Offset: 0x7EA2E0   Length: 0x63A
    public void StartUpgradeDefenceLv(int defenceType)
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        uint uVar1;
        int iVar2;
        long lVar3;
        long lVar4;
        long lVar5;
        ulong uVar6;
        ulong uVar8;
        long lVar9;
        float fVar10;
        lVar9 = (int64)(int)defenceType;
        lVar4 = AreaData.GetForce(this,0);
        if (lVar4 != null) {
          lVar4 = AreaData.GetForce(this,0);
          lVar5 = **(int64 **)(DAT_181d876b0 + 184);
          if (lVar5 == null) throw; // [null/range check failed]
          if (lVar5.Count <= defenceType) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar3 = this.areaBranchDefenceLv;
          uVar1 = *(uint32 *)(lVar5._items + 32 + lVar9 * 4);
          if (lVar3 == null) throw; // [null/range check failed]
          if (lVar3.Count <= defenceType) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          iVar2 = *(int *)(lVar3._items + 32 + lVar9 * 4);
          lVar5 = AreaData.GetForce(this,0);
          if (lVar5 == null) {
            fVar10 = 1.0;
          }
          else {
            lVar5 = AreaData.GetForce(this,0);
            if (lVar5 == null) throw; // [null/range check failed]
            fVar10 = (float)ForceData.GetBuildCostRate(lVar5,0);
          }
          uVar6 = new PlotChoiceRequirement(uVar1,(float)(iVar2 + 1) * 200.0 * fVar10,0);
          iVar2 = this.belongForceID;
          if ((*pStatics == 0) ||
             (lVar5 = *(int64 *)(*pStatics + 32)) == null)
          throw; // [null/range check failed]
          lVar5 = WorldData.Player(lVar5,0);
          if ((lVar5 == null) || (lVar4 == null)) throw; // [null/range check failed]
          ForceData.CostResource(lVar4,uVar6,iVar2 == *(int *)(lVar5 + 132),0);
        }
        lVar4 = this.areaBranchDefenceUpgradeLeftTime;
        lVar5 = this.areaBranchDefenceLv;
        if (lVar5 == null) throw; // [null/range check failed]
        if (lVar5.Count <= defenceType) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        if (lVar4 == null) throw; // [null/range check failed]
        FUN_18181e970(lVar4,defenceType,*(int *)(lVar5._items + 32 + lVar9 * 4) * 2 + 5,
                      DAT_181d68370);
        plVar7 = (int64 *)FUN_1800d60b0(DAT_181d7f180,4);
        lVar4 = AreaData.GetForce(this,0);
        if ((lVar4 == null) || (lVar4 = lVar4.Count, plVar7 == (int64 *)0))
        throw; // [null/range check failed]
        if (lVar4 != null) {
          lVar5 = il2cpp_internal(lVar4,*(uint64 *)(*plVar7 + 64));
          if (lVar5 == null) {
            uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar6,0);
          }
        }
        if ((int)plVar7[3] == 0) {
          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar6,0);
        }
        plVar7[4] = lVar4;
        il2cpp_internal(plVar7 + 4,lVar4);
        lVar4 = this.areaName;
        if (lVar4 != null) {
          lVar5 = il2cpp_internal(lVar4,*(uint64 *)(*plVar7 + 64));
          if (lVar5 == null) {
            uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar6,0);
          }
        }
        if (*(uint32 *)(plVar7 + 3) < 2) {
          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar6,0);
        }
        plVar7[5] = lVar4;
        il2cpp_internal(plVar7 + 5,lVar4);
        lVar4 = *(int64 *)(*(int64 *)(DAT_181d4ef00 + 184) + 0x5c0);
        if (lVar4 == null) throw; // [null/range check failed]
        if (lVar4.Count <= defenceType) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        lVar4 = *(int64 *)(lVar4._items + 32 + lVar9 * 8);
        if (lVar4 != null) {
          lVar5 = il2cpp_internal(lVar4,*(uint64 *)(*plVar7 + 64));
          if (lVar5 == null) {
            uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar6,0);
          }
        }
        if (*(uint32 *)(plVar7 + 3) < 3) {
          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar6,0);
        }
        plVar7[6] = lVar4;
        il2cpp_internal(plVar7 + 6,lVar4);
        lVar4 = this.areaBranchDefenceLv;
        if (lVar4 == null) throw; // [null/range check failed]
        if (lVar4.Count <= defenceType) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        lVar9 = GlobalData.GetNumText(*(uint32 *)(lVar4._items + 32 + lVar9 * 4),0);
        if (lVar9 != null) {
          lVar4 = il2cpp_internal(lVar9,*(uint64 *)(*plVar7 + 64));
          if (lVar4 == null) {
            uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar6,0);
          }
        }
        if (*(uint32 *)(plVar7 + 3) < 4) {
          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar6,0);
        }
        plVar7[7] = lVar9;
        il2cpp_internal(plVar7 + 7,lVar9);
        uVar6 = String.Format("{0}近日开始加强{1}分舵之{2}防御等级({3}级)",plVar7,0);
        AreaData.AddLog(this,uVar6,0);
        iVar2 = this.belongForceID;
        lVar9 = **(int64 **)(DAT_181d5a578 + 184);
        if (iVar2 < 0) {
        LAB_1807ec05c:
          uVar8 = 0;
        }
        else {
          if ((*pStatics == 0) ||
             (lVar4 = *(int64 *)(*pStatics + 32)) == null)
          throw; // [null/range check failed]
          lVar4 = WorldData.Player(lVar4,0);
          if (lVar4 == null) throw; // [null/range check failed]
          if (iVar2 != *(int *)(lVar4 + 132)) goto LAB_1807ec05c;
          uVar8 = 1;
        }
        if (lVar9 != null) {
          InfoController.AddInfo(lVar9,uVar8,uVar6,0);
          return;
        }
    }

    // Token : 0x6000F79
    // RVA   : 0x7E8BF0   Offset: 0x7E73F0   Length: 0x162
    public void AreaConquerReduceDefenceLv()
    {
        int iVar1;
        uint uVar2;
        int iVar3;
        long lVar4;
        uint uVar5;
        long lVar6;
        long lVar7;
        lVar4 = this.areaBranchDefenceLv;
        uVar5 = 0;
        if (lVar4 != null) {
          lVar7 = 32;
          do {
            if (lVar4.Count <= (int)uVar5) {
              return;
            }
            if (lVar4 == null) break;
            lVar6 = lVar4;
            if (lVar4.Count <= uVar5) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
              lVar6 = this.areaBranchDefenceLv;
            }
            iVar1 = *(int *)(lVar7 + lVar4._items);
            if (lVar6 == null) break;
            if (lVar6.Count <= uVar5) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            uVar2 = Mathf.CeilToInt((float)*(int *)(lVar7 + lVar6._items) / 5.0,0);
            iVar3 = Mathf.Clamp(uVar2,0,3);
            FUN_18181e970(lVar4,uVar5,iVar1 - iVar3,DAT_181d68370);
            if (this.areaBranchDefenceUpgradeLeftTime == null) break;
            FUN_18181e970(this.areaBranchDefenceUpgradeLeftTime,uVar5,0);
            lVar4 = this.areaBranchDefenceLv;
            uVar5 = uVar5 + 1;
            lVar7 = lVar7 + 4;
          } while (lVar4 != null);
        }
    }

    // Token : 0x6000F7A
    // RVA   : 0x7EA7C0   Offset: 0x7E8FC0   Length: 0x462
    public float GetDefenceFightScoreRate()
    {
        uint uVar1;
        long lVar2;
        long lVar3;
        uint uVar4;
        int iVar5;
        if (this.areaType == 2) {
          lVar2 = this.areaTiles;
          uVar4 = 0;
          if (lVar2 != null) {
            lVar3 = 32;
            do {
              if ((lVar2.Count <= (int)uVar4) || (lVar2 == null)) break;
              if (lVar2.Count <= uVar4) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              if (*(int64 *)(lVar2._items + lVar3) != 0) {
                if ((this.areaTiles == null) ||
                   (lVar2 = FUN_180002f80(this.areaTiles,uVar4,DAT_181d554e0)) == null)
                break;
                if (*(int64 *)(lVar2 + 40) != 0) {
                  if (((this.areaTiles == null) ||
                      (lVar2 = FUN_180002f80(this.areaTiles,uVar4,DAT_181d554e0),
                      lVar2 == null)) || (*(int64 *)(lVar2 + 40) == 0)) break;
                  if (-1 < *(int *)(*(int64 *)(lVar2 + 40) + 16)) {
                    if (((this.areaTiles == null) ||
                        (lVar2 = FUN_180002f80(this.areaTiles,uVar4,DAT_181d554e0),
                        lVar2 == null)) ||
                       ((*(int64 *)(lVar2 + 40) == 0 ||
                        (lVar2 = AreaBuildingData.DataBase(*(int64 *)(lVar2 + 40),0)) == null)))
                    break;
                    if (*(char *)(lVar2 + 53) != false) {
                      if (((this.areaTiles != null) &&
                          (lVar2 = FUN_180002f80(this.areaTiles,uVar4,DAT_181d554e0),
                          lVar2 != null)) && (*(int64 *)(lVar2 + 40) != 0)) goto LAB_1807eaab5;
                      break;
                    }
                  }
                }
              }
              lVar2 = this.areaTiles;
              uVar4 = uVar4 + 1;
              lVar3 = lVar3 + 8;
            } while (lVar2 != null);
          }
        }
        else {
          lVar2 = AreaData.FindBuilding(this,"分舵",0);
          if (lVar2 != null) {
            uVar4 = 0;
            lVar2 = this.areaBranchDefenceLv;
            if (lVar2 != null) {
              while ((int)uVar4 < lVar2.Count) {
                if (lVar2 == null) throw; // [null/range check failed]
                if (lVar2.Count <= uVar4) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  lVar2 = this.areaBranchDefenceLv;
                }
                uVar4 = uVar4 + 1;
                if (lVar2 == null) throw; // [null/range check failed]
              }
              Mathf.Max(lVar2,this.defence / 100.0,0);
        LAB_1807eaab5:
              iVar5 = 0;
              lVar2 = this.connectResourcePointID;
              while (lVar2 != null) {
                if (lVar2.Count <= iVar5) {
                  return;
                }
                lVar2 = FUN_18046c0a0(0);
                if (lVar2 == null) break;
                lVar2 = *(int64 *)(lVar2 + 32);
                if (((this.connectResourcePointID == null) ||
                    (uVar1 = FUN_1800d6750(this.connectResourcePointID,iVar5,DAT_181d68270), lVar2 == null)
                    ) || (lVar2 = WorldData.GetResourcePoint(lVar2,uVar1,0)) == null) break;
                if (*(int *)(lVar2 + 56) == this.belongForceID) {
                  lVar2 = FUN_18046c0a0(0);
                  if (lVar2 == null) break;
                  lVar2 = *(int64 *)(lVar2 + 32);
                  if (((this.connectResourcePointID == null) ||
                      (uVar1 = FUN_1800d6750(this.connectResourcePointID,iVar5,DAT_181d68270),
                      lVar2 == null)) ||
                     ((lVar2 = WorldData.GetResourcePoint(lVar2,uVar1,0), lVar2 == null ||
                      (lVar2 = ResourcePointData.GetDefenceSpeAddData(lVar2,0)) == null))) break;
                  HeroSpeAddData.GetValue(lVar2,0);
                }
                iVar5 = iVar5 + 1;
                lVar2 = this.connectResourcePointID;
              }
            }
          }
        }
    }

    // Token : 0x6000F7B
    // RVA   : 0x7E9060   Offset: 0x7E7860   Length: 0xD8
    public bool BelongPlayer()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        int iVar1;
        long lVar2;
        iVar1 = this.belongForceID;
        if (iVar1 < 0) {
          return false;
        }
        if ((*pStatics != 0) &&
           (lVar2 = *(int64 *)(*pStatics + 32)) != null) {
          lVar2 = WorldData.Player(lVar2,0);
          if (lVar2 != null) {
            return iVar1 == *(int *)(lVar2 + 132);
          }
        }
    }

    // Token : 0x6000F7C
    // RVA   : 0x7E8D60   Offset: 0x7E7560   Length: 0x2FC
    public bool BelongPlayerOrAlley()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        int iVar1;
        bool cVar2;
        long lVar3;
        ulong uVar4;
        if (((*pStatics != 0) &&
            (lVar3 = *(int64 *)(*pStatics + 32)) != null) &&
           (lVar3 = WorldData.Player(lVar3,0)) != null) {
          if (*(int *)(lVar3 + 132) < 0) {
            return false;
          }
          iVar1 = this.belongForceID;
          if (((*pStatics != 0) &&
              (lVar3 = *(int64 *)(*pStatics + 32)) != null) &&
             (lVar3 = WorldData.Player(lVar3,0)) != null) {
            if (iVar1 == *(int *)(lVar3 + 132)) {
              return true;
            }
            iVar1 = this.belongForceID;
            lVar3 = FUN_18046c0a0(0);
            if (((lVar3 != null) && (*(int64 *)(lVar3 + 32) != 0)) &&
               ((lVar3 = WorldData.Player(*(int64 *)(lVar3 + 32),0), lVar3 != null &&
                (lVar3 = HeroData.GetForce(lVar3,0,0)) != null))) {
              if (iVar1 == *(int *)(lVar3 + 60)) {
                return true;
              }
              lVar3 = FUN_18046c0a0(0);
              if ((((lVar3 != null) && (*(int64 *)(lVar3 + 32) != 0)) &&
                  (lVar3 = WorldData.Player(*(int64 *)(lVar3 + 32),0)) != null) &&
                 ((lVar3 = HeroData.GetForce(lVar3,0,0), lVar3 != null && (*(int64 *)(lVar3 + 64) != 0)
                  ))) {
                cVar2 = FUN_181815240(*(int64 *)(lVar3 + 64),this.belongForceID,
                                      DAT_181d67bf8);
                if (cVar2) {
                  return true;
                }
                lVar3 = FUN_18046c0a0(0);
                if ((((lVar3 != null) && (*(int64 *)(lVar3 + 32) != 0)) &&
                    (lVar3 = WorldData.Player(*(int64 *)(lVar3 + 32),0)) != null) &&
                   (lVar3 = HeroData.GetForce(lVar3,0,0)) != null) {
                  uVar4 = ForceData.IsAllyForce(lVar3,this.belongForceID,0);
                  return uVar4;
                }
              }
            }
          }
        }
    }

    // Token : 0x6000F7D
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    public string GetAreaName()
    {
        return this.areaName;
    }

    // Token : 0x6000F7E
    // RVA   : 0x7EA040   Offset: 0x7E8840   Length: 0x17C
    public int GetAreaMapRandomEventCount()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        bool cVar1;
        long lVar2;
        int iVar3;
        int iVar4;
        iVar4 = 0;
        iVar3 = 0;
        while( true ) {
          if (((*pStatics == 0) ||
              (lVar2 = *(int64 *)(*pStatics + 32)) == null) ||
             (lVar2 = *(int64 *)(lVar2 + 104)) == null) break;
          if (*(int *)(lVar2 + 24) <= iVar3) {
            return iVar4;
          }
          lVar2 = FUN_18046c0a0(0);
          if (((lVar2 == null) || (*(int64 *)(lVar2 + 32) == 0)) ||
             (lVar2 = *(int64 *)(*(int64 *)(lVar2 + 32) + 104)) == null) break;
          lVar2 = FUN_180002f80(lVar2,iVar3,DAT_181d5e680);
          if ((lVar2 == null) || (*(int64 *)(lVar2 + 64) == 0)) break;
          cVar1 = FUN_181815240(*(int64 *)(lVar2 + 64),this.areaID,DAT_181d67bf8)
          ;
          if (cVar1) {
            iVar4 = iVar4 + 1;
          }
          iVar3 = iVar3 + 1;
        }
    }

    // Token : 0x6000F7F
    // RVA   : 0x7EB2C0   Offset: 0x7E9AC0   Length: 0x16B
    public int GetSpeBuildingNum()
    {
        long lVar1;
        int iVar2;
        uint uVar3;
        long lVar4;
        lVar1 = this.areaTiles;
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
              if ((this.areaTiles == null) ||
                 (lVar1 = FUN_180002f80(this.areaTiles,uVar3,DAT_181d554e0)) == null)
              break;
              if (*(int64 *)(lVar1 + 40) != 0) {
                if (((this.areaTiles == null) ||
                    (lVar1 = FUN_180002f80(this.areaTiles,uVar3,DAT_181d554e0)) == null
                    ) || (*(int64 *)(lVar1 + 40) == 0)) break;
                if (-1 < *(int *)(*(int64 *)(lVar1 + 40) + 16)) {
                  if (((this.areaTiles == null) ||
                      (lVar1 = FUN_180002f80(this.areaTiles,uVar3,DAT_181d554e0),
                      lVar1 == null)) ||
                     ((*(int64 *)(lVar1 + 40) == 0 ||
                      (lVar1 = AreaBuildingData.DataBase(*(int64 *)(lVar1 + 40),0)) == null)))
                  break;
                  if (*(int *)(lVar1 + 48) == 6) {
                    iVar2 = iVar2 + 1;
                  }
                }
              }
            }
            lVar1 = this.areaTiles;
            uVar3 = uVar3 + 1;
            lVar4 = lVar4 + 8;
          } while (lVar1 != null);
        }
    }

    // Token : 0x6000F80
    // RVA   : 0x7EA560   Offset: 0x7E8D60   Length: 0x190
    public AreaBuildingData GetCenterBuilding()
    {
        long lVar1;
        uint uVar2;
        long lVar3;
        lVar1 = this.areaTiles;
        uVar2 = 0;
        if (lVar1 != null) {
          lVar3 = 32;
          do {
            if (lVar1.Count <= (int)uVar2) {
              return 0;
            }
            if (lVar1 == null) break;
            if (lVar1.Count <= uVar2) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            if (*(int64 *)(lVar1._items + lVar3) != 0) {
              if ((this.areaTiles == null) ||
                 (lVar1 = FUN_180002f80(this.areaTiles,uVar2,DAT_181d554e0)) == null)
              break;
              if (*(int64 *)(lVar1 + 40) != 0) {
                if (((this.areaTiles == null) ||
                    (lVar1 = FUN_180002f80(this.areaTiles,uVar2,DAT_181d554e0)) == null
                    ) || (*(int64 *)(lVar1 + 40) == 0)) break;
                if (-1 < *(int *)(*(int64 *)(lVar1 + 40) + 16)) {
                  if (((this.areaTiles == null) ||
                      (lVar1 = FUN_180002f80(this.areaTiles,uVar2,DAT_181d554e0),
                      lVar1 == null)) ||
                     ((*(int64 *)(lVar1 + 40) == 0 ||
                      (lVar1 = AreaBuildingData.DataBase(*(int64 *)(lVar1 + 40),0)) == null)))
                  break;
                  if (*(char *)(lVar1 + 53) != false) {
                    if ((this.areaTiles != null) &&
                       (lVar1 = FUN_180002f80(this.areaTiles,uVar2,DAT_181d554e0),
                       lVar1 != null)) {
                      return *(uint64 *)(lVar1 + 40);
                    }
                    break;
                  }
                }
              }
            }
            lVar1 = this.areaTiles;
            uVar2 = uVar2 + 1;
            lVar3 = lVar3 + 8;
          } while (lVar1 != null);
        }
    }

    // Token : 0x6000F81
    // RVA   : 0x7EAF50   Offset: 0x7E9750   Length: 0x1BA
    public List<HeroData> GetInsideHeros()
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
        lVar4 = this.insideHeros;
        uVar5 = 0;
        if (lVar4 != null) {
          lVar6 = 32;
          while( true ) {
            if (lVar4.Count <= (int)uVar5) {
              return lVar2;
            }
            if (*pStatics == 0) break;
            lVar4 = this.insideHeros;
            lVar1 = *(int64 *)(*pStatics + 32);
            if (lVar4 == null) break;
            if (lVar4.Count <= uVar5) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            if ((lVar1 == null) ||
               (uVar3 = WorldData.GetHero(lVar1,*(uint32 *)(lVar6 + lVar4._items),0),
               lVar2 == null)) break;
            FUN_181827900(lVar2,uVar3);
            lVar4 = this.insideHeros;
            uVar5 = uVar5 + 1;
            lVar6 = lVar6 + 4;
            if (lVar4 == null) break;
          }
        }
    }

    // Token : 0x6000F82
    // RVA   : 0x7EAE50   Offset: 0x7E9650   Length: 0xFD
    public HeroData GetInsideHero(int id)
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        long lVar1;
        long lVar2;
        if (*pStatics != 0) {
          lVar1 = this.insideHeros;
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

    // Token : 0x6000F83
    // RVA   : 0x7EB9B0   Offset: 0x7EA1B0   Length: 0x12E
    public void SetBranchLeader(HeroData targetHero)
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        long lVar1;
        if (-1 < this.branchLeaderID) {
          if ((*pStatics != 0) &&
             (lVar1 = *(int64 *)(*pStatics + 32)) != null) {
            lVar1 = WorldData.GetHero(lVar1,this.branchLeaderID,0);
            if (lVar1 != null) {
              *(uint32 *)(lVar1 + 156) = 0xffffffff;
              goto LAB_1807eba8a;
            }
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        LAB_1807eba8a:
        if (targetHero != null) {
          this.branchLeaderID = *(uint32 *)(targetHero + 88);
          *(uint32 *)(targetHero + 156) = this.areaID;
          *(uint32 *)(targetHero + 152) = 30;
          this.areaDetailDirty = 1;
          return;
        }
        this.branchLeaderID = 0xffffffff;
        this.areaDetailDirty = 1;
    }

    // Token : 0x6000F84
    // RVA   : 0x7EB990   Offset: 0x7EA190   Length: 0x11
    public void ResetAutoSetting()
    {
        this.autoBuild = 0;
        this.autoBuildResourceRateLimit = 0;
    }

    // Token : 0x6000F85
    // RVA   : 0x7E9140   Offset: 0x7E7940   Length: 0x32
    public bool CanAddState()
    {
        float fVar1;
        if (((85.0 < this.safe || this.safe == 85.0) &&
            (85.0 < this.support || this.support == 85.0)) &&
           (85.0 < this.defence || this.defence == 85.0)) {
          fVar1 = this.maxPeople * 0.85;
          return this.people <= fVar1 && fVar1 != this.people;
        }
        return true;
    }

    // Token : 0x6000F86
    // RVA   : 0x7E9180   Offset: 0x7E7980   Length: 0x42
    public bool CanReduceState()
    {
        if (((this.safe <= 15.0) && (this.support <= 15.0)) &&
           (this.defence <= 15.0)) {
          return this.maxPeople * 0.15 < this.people;
        }
        return true;
    }

    // Token : 0x6000F87
    // RVA   : 0x7EB190   Offset: 0x7E9990   Length: 0xFA
    public string GetRecordLog()
    {
        long lVar1;
        ulong uVar2;
        uint uVar3;
        ulong uVar4;
        long lVar5;
        if (this.recordLog != null) {
          uVar3 = this.recordLog.Count - 1;
          uVar2 = "";
          if (-1 < (int)uVar3) {
            lVar5 = (int64)(int)uVar3 * 8 + 32;
            do {
              lVar1 = this.recordLog;
              if (lVar1 == null) throw; // [null/range check failed]
              if (lVar1.Count <= uVar3) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              uVar4 = "\n......";
              if (0 < (int)uVar3) {
                uVar4 = "\n";
              }
              uVar2 = String.Concat(uVar2,*(uint64 *)(lVar5 + lVar1._items),uVar4,0);
              lVar5 = lVar5 + -8;
              uVar3 = uVar3 - 1;
            } while (-1 < (int)uVar3);
          }
          return uVar2;
        }
    }

    // Token : 0x6000F88
    // RVA   : 0x7E8740   Offset: 0x7E6F40   Length: 0x4A5
    public void AddLog(string newLog)
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        int iVar1;
        long lVar2;
        long lVar4;
        long lVar5;
        ulong uVar6;
        uint[] local_res8 = new uint[2];
        uint[] local_res20 = new uint[2];
        uint[] local_28 = new uint[4];
        lVar2 = this.recordLog;
        plVar3 = (int64 *)FUN_1800d60b0(DAT_181d7f180,4);
        if (((*pStatics != 0) &&
            (lVar4 = *(int64 *)(*pStatics + 32)) != null) &&
           (lVar4 = *(int64 *)(lVar4 + 168)) != null) {
          local_res8[0] = *(uint32 *)(lVar4 + 16);
          lVar4 = il2cpp_value_box(DAT_181d5b2f8,local_res8);
          if (plVar3 != (int64 *)0) {
            if ((lVar4 != null) &&
               (lVar5 = il2cpp_internal(lVar4,*(uint64 *)(*plVar3 + 64))) == null) {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar6,0);
            }
            if ((int)plVar3[3] == 0) {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar6,0);
            }
            plVar3[4] = lVar4;
            il2cpp_internal(plVar3 + 4,lVar4);
            if (((*pStatics != 0) &&
                (lVar4 = *(int64 *)(*pStatics + 32)) != null) &&
               (lVar4 = *(int64 *)(lVar4 + 168)) != null) {
              local_res20[0] = *(uint32 *)(lVar4 + 20);
              lVar4 = il2cpp_value_box(DAT_181d5b2f8,local_res20);
              if ((lVar4 != null) &&
                 (lVar5 = il2cpp_internal(lVar4,*(uint64 *)(*plVar3 + 64))) == null) {
                uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar6,0);
              }
              if (*(uint32 *)(plVar3 + 3) < 2) {
                uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar6,0);
              }
              plVar3[5] = lVar4;
              il2cpp_internal(plVar3 + 5,lVar4);
              if (((*pStatics != 0) &&
                  (lVar4 = *(int64 *)(*pStatics + 32)) != null) &&
                 (lVar4 = *(int64 *)(lVar4 + 168)) != null) {
                local_28[0] = *(uint32 *)(lVar4 + 24);
                lVar4 = il2cpp_value_box(DAT_181d5b2f8,local_28);
                if ((lVar4 != null) &&
                   (lVar5 = il2cpp_internal(lVar4,*(uint64 *)(*plVar3 + 64))) == null) {
                  uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar6,0);
                }
                if (*(uint32 *)(plVar3 + 3) < 3) {
                  uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar6,0);
                }
                plVar3[6] = lVar4;
                il2cpp_internal(plVar3 + 6,lVar4);
                if ((newLog != null) &&
                   (lVar4 = il2cpp_internal(newLog,*(uint64 *)(*plVar3 + 64))) == null) {
                  uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar6,0);
                }
                if (*(uint32 *)(plVar3 + 3) < 4) {
                  uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar6,0);
                }
                plVar3[7] = newLog;
                il2cpp_internal(plVar3 + 7,newLog);
                uVar6 = String.Format("[{0}.{1}.{2}]{3}",plVar3,0);
                if (lVar2 != null) {
                  FUN_181827900(lVar2,uVar6,DAT_181d7c3d0);
                  lVar2 = this.recordLog;
                  while (lVar2 != null) {
                    iVar1 = lVar2.Count;
                    if (iVar1 <= *(int *)(*(int64 *)(DAT_181d4ef00 + 184) + 232)) {
                      this.areaInfoDirty = 1;
                      return;
                    }
                    if (this.recordLog == null) break;
                    FUN_18182b220(this.recordLog,0,DAT_181d7c7c8);
                    lVar2 = this.recordLog;
                  }
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
              }
            }
          }
        }
    }

    // Token : 0x6000F89
    // RVA   : 0x7E91D0   Offset: 0x7E79D0   Length: 0x44
    public void ChangeAreaState(int areaStateType, float result, bool showInfo)
    {
        if (areaStateType == null) {
          AreaData.ChangeSafe(this,result,showInfo,0);
          return;
        }
        if (areaStateType == 1) {
          AreaData.ChangeSupport(this,result,showInfo,0);
          return;
        }
        if (areaStateType == 2) {
          AreaData.ChangeDefence(this,result,showInfo,0);
          return;
        }
        if (areaStateType == 3) {
          AreaData.ChangePeople(this,result,showInfo,0);
          return;
        }
    }

    // Token : 0x6000F8A
    // RVA   : 0x7EA1C0   Offset: 0x7E89C0   Length: 0x51
    public float GetAreaStatePercent(int areaStateType)
    {
        if (areaStateType == null) {
          return this.safe / 100.0;
        }
        if (areaStateType == 1) {
          return this.support / 100.0;
        }
        if (areaStateType == 2) {
          return this.defence / 100.0;
        }
        if (areaStateType != 3) {
          return -1.0;
        }
        return this.people / this.maxPeople;
    }

    // Token : 0x6000F8B
    // RVA   : 0x7EA310   Offset: 0x7E8B10   Length: 0x34
    public float GetAreaState(int areaStateType)
    {
        if (areaStateType == null) {
          return this.safe;
        }
        if (areaStateType == 1) {
          return this.support;
        }
        if (areaStateType == 2) {
          return this.defence;
        }
        if (areaStateType != 3) {
          return 0xbf800000;
        }
        return this.people;
    }

    // Token : 0x6000F8C
    // RVA   : 0x7EB110   Offset: 0x7E9910   Length: 0x14
    public float GetMaxAreaState(int areaStateType)
    {
        if (areaStateType != 3) {
          return 0x42c80000;
        }
        return this.maxPeople;
    }

    // Token : 0x6000F8D
    // RVA   : 0x7EB430   Offset: 0x7E9C30   Length: 0x15
    public float GetSupport()
    {
        if (this.areaType != 2) {
          return this.support;
        }
        return 0x42480000;
    }

    // Token : 0x6000F8E
    // RVA   : 0x7EB2A0   Offset: 0x7E9AA0   Length: 0x15
    public float GetSafe()
    {
        if (this.areaType != 2) {
          return this.safe;
        }
        return 0x42480000;
    }

    // Token : 0x6000F8F
    // RVA   : 0x7E9E90   Offset: 0x7E8690   Length: 0x1AD
    public AreaBuildingData FindBuilding(string buildingName)
    {
        long lVar1;
        uint uVar2;
        long lVar3;
        lVar1 = this.areaTiles;
        uVar2 = 0;
        if (lVar1 != null) {
          lVar3 = 32;
          do {
            if (lVar1.Count <= (int)uVar2) {
              return 0;
            }
            if (lVar1 == null) break;
            if (lVar1.Count <= uVar2) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            if (*(int64 *)(lVar1._items + lVar3) != 0) {
              if ((this.areaTiles == null) ||
                 (lVar1 = FUN_180002f80(this.areaTiles,uVar2,DAT_181d554e0)) == null)
              break;
              if (*(int64 *)(lVar1 + 40) != 0) {
                if (((this.areaTiles == null) ||
                    (lVar1 = FUN_180002f80(this.areaTiles,uVar2,DAT_181d554e0)) == null
                    ) || (*(int64 *)(lVar1 + 40) == 0)) break;
                if (-1 < *(int *)(*(int64 *)(lVar1 + 40) + 16)) {
                  if (((this.areaTiles == null) ||
                      (lVar1 = FUN_180002f80(this.areaTiles,uVar2,DAT_181d554e0),
                      lVar1 == null)) || (*(int64 *)(lVar1 + 40) == 0)) break;
                  if (*(int *)(*(int64 *)(lVar1 + 40) + 16) == buildingName) {
                    if ((this.areaTiles != null) &&
                       (lVar1 = FUN_180002f80(this.areaTiles,uVar2,DAT_181d554e0),
                       lVar1 != null)) {
                      return *(uint64 *)(lVar1 + 40);
                    }
                    break;
                  }
                }
              }
            }
            lVar1 = this.areaTiles;
            uVar2 = uVar2 + 1;
            lVar3 = lVar3 + 8;
          } while (lVar1 != null);
        }
    }

    // Token : 0x6000F90
    // RVA   : 0x7E9D00   Offset: 0x7E8500   Length: 0x18C
    public AreaBuildingData FindBuilding(int buildingID)
    {
        long lVar1;
        uint uVar2;
        long lVar3;
        lVar1 = this.areaTiles;
        uVar2 = 0;
        if (lVar1 != null) {
          lVar3 = 32;
          do {
            if (lVar1.Count <= (int)uVar2) {
              return 0;
            }
            if (lVar1 == null) break;
            if (lVar1.Count <= uVar2) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            if (*(int64 *)(lVar1._items + lVar3) != 0) {
              if ((this.areaTiles == null) ||
                 (lVar1 = FUN_180002f80(this.areaTiles,uVar2,DAT_181d554e0)) == null)
              break;
              if (*(int64 *)(lVar1 + 40) != 0) {
                if (((this.areaTiles == null) ||
                    (lVar1 = FUN_180002f80(this.areaTiles,uVar2,DAT_181d554e0)) == null
                    ) || (*(int64 *)(lVar1 + 40) == 0)) break;
                if (-1 < *(int *)(*(int64 *)(lVar1 + 40) + 16)) {
                  if (((this.areaTiles == null) ||
                      (lVar1 = FUN_180002f80(this.areaTiles,uVar2,DAT_181d554e0),
                      lVar1 == null)) || (*(int64 *)(lVar1 + 40) == 0)) break;
                  if (*(int *)(*(int64 *)(lVar1 + 40) + 16) == buildingID) {
                    if ((this.areaTiles != null) &&
                       (lVar1 = FUN_180002f80(this.areaTiles,uVar2,DAT_181d554e0),
                       lVar1 != null)) {
                      return *(uint64 *)(lVar1 + 40);
                    }
                    break;
                  }
                }
              }
            }
            lVar1 = this.areaTiles;
            uVar2 = uVar2 + 1;
            lVar3 = lVar3 + 8;
          } while (lVar1 != null);
        }
    }

    // Token : 0x6000F91
    // RVA   : 0x7EA700   Offset: 0x7E8F00   Length: 0xA6
    public float GetChangeAreaState(AreaStateType areaStateType)
    {
        float fVar1;
        long lVar2;
        float fVar3;
        lVar2 = this.changeAreaState;
        if (lVar2 != null) {
          if (lVar2.Count <= areaStateType) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          fVar1 = lVar2._items[areaStateType];
          lVar2 = AreaData.GetForce(this,0);
          if (lVar2 == null) {
            fVar3 = 0.0;
          }
          else {
            lVar2 = AreaData.GetForce(this,0);
            if (lVar2 == null) throw; // [null/range check failed]
            fVar3 = (float)ForceData.GetChangeAllAreaState(lVar2,areaStateType,0);
          }
          return fVar1 + fVar3;
        }
    }

    // Token : 0x6000F92
    // RVA   : 0x7EA700   Offset: 0x7E8F00   Length: 0xA6
    public float GetChangeAreaState(int id)
    {
        float fVar1;
        long lVar2;
        float fVar3;
        lVar2 = this.changeAreaState;
        if (lVar2 != null) {
          if (lVar2.Count <= id) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          fVar1 = lVar2._items[id];
          lVar2 = AreaData.GetForce(this,0);
          if (lVar2 == null) {
            fVar3 = 0.0;
          }
          else {
            lVar2 = AreaData.GetForce(this,0);
            if (lVar2 == null) throw; // [null/range check failed]
            fVar3 = (float)ForceData.GetChangeAllAreaState(lVar2,id,0);
          }
          return fVar1 + fVar3;
        }
    }

    // Token : 0x6000F93
    // RVA   : 0x7EAC30   Offset: 0x7E9430   Length: 0x13E
    public Color GetForceColor()
    {
        long lVar1;
        long lVar2;
        ulong uVar3;
        ulong local_28;
        ulong uStack_20;
        byte[] local_18 = new byte[16];
        local_28 = 0;
        uStack_20 = 0;
        if (*(int *)(param_2 + 112) < 0) {
          puVar4 = (uint64 *)FUN_180d904c0(local_18);
          uVar3 = puVar4[1];
          *this = *puVar4;
          this[1] = uVar3;
          return this;
        }
        lVar1 = AreaData.GetForce(param_2);
        uVar3 = "#";
        if (lVar1 == null) throw; // [null/range check failed]
        if (*(int *)(lVar1 + 60) < 0) {
          lVar1 = AreaData.GetForce(param_2,0);
        }
        else {
          lVar1 = FUN_18046c0a0(0);
          if (lVar1 == null) throw; // [null/range check failed]
          lVar1 = *(int64 *)(lVar1 + 32);
          lVar2 = AreaData.GetForce(param_2,0);
          if ((lVar2 == null) || (lVar1 == null)) throw; // [null/range check failed]
          lVar1 = WorldData.GetForce(lVar1,*(uint32 *)(lVar2 + 60),0);
        }
        if (lVar1 != null) {
          uVar3 = String.Concat(uVar3,*(uint64 *)(lVar1 + 80),0);
          ColorUtility.TryParseHtmlString(uVar3,&local_28,0);
          *this = local_28;
          this[1] = uStack_20;
          return this;
        }
    }

    // Token : 0x6000F94
    // RVA   : 0x7EAD70   Offset: 0x7E9570   Length: 0xD0
    public ForceData GetForce()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        long lVar1;
        ulong uVar2;
        if (this.belongForceID < 0) {
          return 0;
        }
        if ((*pStatics != 0) &&
           (lVar1 = *(int64 *)(*pStatics + 32)) != null) {
          uVar2 = WorldData.GetForce(lVar1,this.belongForceID,0);
          return uVar2;
        }
    }

    // Token : 0x6000F95
    // RVA   : 0x7EB170   Offset: 0x7E9970   Length: 0x16
    public float GetMonthChangeSupport()
    {
        return (50.0 - this.support) * 0.2;
    }

    // Token : 0x6000F96
    // RVA   : 0x7EB150   Offset: 0x7E9950   Length: 0x16
    public float GetMonthChangeSafe()
    {
        return (50.0 - this.safe) * 0.2;
    }

    // Token : 0x6000F97
    // RVA   : 0x7EB130   Offset: 0x7E9930   Length: 0x16
    public float GetMonthChangeDefence()
    {
        return (50.0 - this.defence) * 0.2;
    }

    // Token : 0x6000F98
    // RVA   : 0x7E9440   Offset: 0x7E7C40   Length: 0x94
    public void ChangePeople(float num)
    {
        long lVar1;
        ulong uVar2;
        ulong uVar3;
        uint uVar4;
        float[] local_res10 = new float[6];
        ulong local_18;
        ulong uStack_10;
        local_res10[0] = num;
        if (local_res10[0] != 0.0) {
          uVar4 = FUN_1810a8ba0(this.people + local_res10[0],0,
                                this.maxPeople,0);
          this.people = uVar4;
          this.areaDetailDirty = 1;
          if (param_3) {
            uVar3 = this.areaName;
            lVar1 = **(int64 **)(DAT_181d5a578 + 184);
            uVar2 = Single.ToString(local_res10,"+0;-0;0",0);
            uVar3 = String.Concat(uVar3,"人口",uVar2,0);
            if (lVar1 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            local_18 = 0;
            uStack_10 = 0;
            InfoController.AddInfoTab
                      (lVar1,uVar3,"UIAtlas","地区_人口","NoticeLittle",0x3f800000,0x40a00000,
                       &local_18,0);
          }
        }
    }

    // Token : 0x6000F99
    // RVA   : 0x7E9880   Offset: 0x7E8080   Length: 0x97
    public void ChangeSupport(float num)
    {
        long lVar1;
        ulong uVar2;
        ulong uVar3;
        uint uVar4;
        float[] local_res10 = new float[6];
        ulong local_18;
        ulong uStack_10;
        local_res10[0] = num;
        if (local_res10[0] != 0.0) {
          uVar4 = FUN_1810a8ba0(this.support + local_res10[0],0,0x42c80000,0);
          this.support = uVar4;
          this.areaDetailDirty = 1;
          if (param_3) {
            uVar3 = this.areaName;
            lVar1 = **(int64 **)(DAT_181d5a578 + 184);
            uVar2 = Single.ToString(local_res10,"+0;-0;0",0);
            uVar3 = String.Concat(uVar3,"民心",uVar2,0);
            if (lVar1 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            local_18 = 0;
            uStack_10 = 0;
            InfoController.AddInfoTab
                      (lVar1,uVar3,"UIAtlas","地区_民心","NoticeLittle",0x3f800000,0x40a00000,
                       &local_18,0);
          }
        }
    }

    // Token : 0x6000F9A
    // RVA   : 0x7E97E0   Offset: 0x7E7FE0   Length: 0x97
    public void ChangeSafe(float num)
    {
        long lVar1;
        ulong uVar2;
        ulong uVar3;
        uint uVar4;
        float[] local_res10 = new float[6];
        ulong local_18;
        ulong uStack_10;
        local_res10[0] = num;
        if (local_res10[0] != 0.0) {
          uVar4 = FUN_1810a8ba0(this.safe + local_res10[0],0,0x42c80000,0);
          this.safe = uVar4;
          this.areaDetailDirty = 1;
          if (param_3) {
            uVar3 = this.areaName;
            lVar1 = **(int64 **)(DAT_181d5a578 + 184);
            uVar2 = Single.ToString(local_res10,"+0;-0;0",0);
            uVar3 = String.Concat(uVar3,"治安",uVar2,0);
            if (lVar1 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            local_18 = 0;
            uStack_10 = 0;
            InfoController.AddInfoTab
                      (lVar1,uVar3,"UIAtlas","地区_治安","NoticeLittle",0x3f800000,0x40a00000,
                       &local_18,0);
          }
        }
    }

    // Token : 0x6000F9B
    // RVA   : 0x7E9220   Offset: 0x7E7A20   Length: 0x97
    public void ChangeDefence(float num)
    {
        long lVar1;
        ulong uVar2;
        ulong uVar3;
        uint uVar4;
        float[] local_res10 = new float[6];
        ulong local_18;
        ulong uStack_10;
        local_res10[0] = num;
        if (local_res10[0] != 0.0) {
          uVar4 = FUN_1810a8ba0(this.defence + local_res10[0],0,0x42c80000,0);
          this.defence = uVar4;
          this.areaDetailDirty = 1;
          if (param_3) {
            uVar3 = this.areaName;
            lVar1 = **(int64 **)(DAT_181d5a578 + 184);
            uVar2 = Single.ToString(local_res10,"+0;-0;0",0);
            uVar3 = String.Concat(uVar3,"防御",uVar2,0);
            if (lVar1 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            local_18 = 0;
            uStack_10 = 0;
            InfoController.AddInfoTab
                      (lVar1,uVar3,"UIAtlas","地区_防御","NoticeLittle",0x3f800000,0x40a00000,
                       &local_18,0);
          }
        }
    }

    // Token : 0x6000F9C
    // RVA   : 0x7E94E0   Offset: 0x7E7CE0   Length: 0x171
    public void ChangePeople(float num, bool showInfo)
    {
        long lVar1;
        ulong uVar2;
        ulong uVar3;
        uint uVar4;
        float[] local_res10 = new float[6];
        ulong local_18;
        ulong uStack_10;
        local_res10[0] = num;
        if (local_res10[0] != 0.0) {
          uVar4 = FUN_1810a8ba0(this.people + local_res10[0],0,
                                this.maxPeople,0);
          this.people = uVar4;
          this.areaDetailDirty = 1;
          if (showInfo) {
            uVar3 = this.areaName;
            lVar1 = **(int64 **)(DAT_181d5a578 + 184);
            uVar2 = Single.ToString(local_res10,"+0;-0;0",0);
            uVar3 = String.Concat(uVar3,"人口",uVar2,0);
            if (lVar1 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            local_18 = 0;
            uStack_10 = 0;
            InfoController.AddInfoTab
                      (lVar1,uVar3,"UIAtlas","地区_人口","NoticeLittle",0x3f800000,0x40a00000,
                       &local_18,0);
          }
        }
    }

    // Token : 0x6000F9D
    // RVA   : 0x7E9920   Offset: 0x7E8120   Length: 0x174
    public void ChangeSupport(float num, bool showInfo)
    {
        long lVar1;
        ulong uVar2;
        ulong uVar3;
        uint uVar4;
        float[] local_res10 = new float[6];
        ulong local_18;
        ulong uStack_10;
        local_res10[0] = num;
        if (local_res10[0] != 0.0) {
          uVar4 = FUN_1810a8ba0(this.support + local_res10[0],0,0x42c80000,0);
          this.support = uVar4;
          this.areaDetailDirty = 1;
          if (showInfo) {
            uVar3 = this.areaName;
            lVar1 = **(int64 **)(DAT_181d5a578 + 184);
            uVar2 = Single.ToString(local_res10,"+0;-0;0",0);
            uVar3 = String.Concat(uVar3,"民心",uVar2,0);
            if (lVar1 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            local_18 = 0;
            uStack_10 = 0;
            InfoController.AddInfoTab
                      (lVar1,uVar3,"UIAtlas","地区_民心","NoticeLittle",0x3f800000,0x40a00000,
                       &local_18,0);
          }
        }
    }

    // Token : 0x6000F9E
    // RVA   : 0x7E9660   Offset: 0x7E7E60   Length: 0x174
    public void ChangeSafe(float num, bool showInfo)
    {
        long lVar1;
        ulong uVar2;
        ulong uVar3;
        uint uVar4;
        float[] local_res10 = new float[6];
        ulong local_18;
        ulong uStack_10;
        local_res10[0] = num;
        if (local_res10[0] != 0.0) {
          uVar4 = FUN_1810a8ba0(this.safe + local_res10[0],0,0x42c80000,0);
          this.safe = uVar4;
          this.areaDetailDirty = 1;
          if (showInfo) {
            uVar3 = this.areaName;
            lVar1 = **(int64 **)(DAT_181d5a578 + 184);
            uVar2 = Single.ToString(local_res10,"+0;-0;0",0);
            uVar3 = String.Concat(uVar3,"治安",uVar2,0);
            if (lVar1 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            local_18 = 0;
            uStack_10 = 0;
            InfoController.AddInfoTab
                      (lVar1,uVar3,"UIAtlas","地区_治安","NoticeLittle",0x3f800000,0x40a00000,
                       &local_18,0);
          }
        }
    }

    // Token : 0x6000F9F
    // RVA   : 0x7E92C0   Offset: 0x7E7AC0   Length: 0x174
    public void ChangeDefence(float num, bool showInfo)
    {
        long lVar1;
        ulong uVar2;
        ulong uVar3;
        uint uVar4;
        float[] local_res10 = new float[6];
        ulong local_18;
        ulong uStack_10;
        local_res10[0] = num;
        if (local_res10[0] != 0.0) {
          uVar4 = FUN_1810a8ba0(this.defence + local_res10[0],0,0x42c80000,0);
          this.defence = uVar4;
          this.areaDetailDirty = 1;
          if (showInfo) {
            uVar3 = this.areaName;
            lVar1 = **(int64 **)(DAT_181d5a578 + 184);
            uVar2 = Single.ToString(local_res10,"+0;-0;0",0);
            uVar3 = String.Concat(uVar3,"防御",uVar2,0);
            if (lVar1 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            local_18 = 0;
            uStack_10 = 0;
            InfoController.AddInfoTab
                      (lVar1,uVar3,"UIAtlas","地区_防御","NoticeLittle",0x3f800000,0x40a00000,
                       &local_18,0);
          }
        }
    }

    // Token : 0x6000FA0
    // RVA   : 0x7EC120   Offset: 0x7EA920   Length: 0x10
    public float TotalState()
    {
        return this.support + this.safe + this.defence;
    }

    // Token : 0x6000FA1
    // RVA   : 0x7EB890   Offset: 0x7EA090   Length: 0xF5
    public void ResetAllState()
    {
        uint uVar1;
        uint uVar2;
        uVar2 = this.safe;
        GlobalData.RandomRange(25,36,0);
        uVar1 = FUN_1810a8ba0(uVar2);
        uVar2 = this.support;
        this.safe = uVar1;
        GlobalData.RandomRange(25,36,0);
        uVar1 = FUN_1810a8ba0(uVar2);
        uVar2 = this.defence;
        this.support = uVar1;
        GlobalData.RandomRange(25,36,0);
        uVar2 = FUN_1810a8ba0(uVar2);
        this.defence = uVar2;
    }

    // Token : 0x6000FA2
    // RVA   : 0x7EB6D0   Offset: 0x7E9ED0   Length: 0x1B2
    public void ManageTempResourceValueRate()
    {
        long lVar1;
        uint uVar2;
        long lVar3;
        long lVar4;
        float fVar5;
        uint uVar6;
        lVar1 = this.resourceValueRateTemp;
        uVar2 = 0;
        if (lVar1 != null) {
          lVar4 = 32;
          do {
            if (lVar1.Count <= (int)uVar2) {
              return;
            }
            if (lVar1 == null) break;
            lVar3 = lVar1;
            if (lVar1.Count <= uVar2) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
              lVar3 = this.resourceValueRateTemp;
            }
            if (0.0 < *(float *)(lVar4 + lVar1._items)) {
              if (lVar3 == null) break;
              fVar5 = (float)FUN_1800d6780(lVar3,uVar2,DAT_181d796d8);
              uVar6 = Mathf.Max(0,fVar5 * 0.8 - 0.1,0);
        LAB_1807eb820:
              FUN_181814d10(lVar3,uVar2,uVar6,DAT_181d79758);
            }
            else {
              if (lVar3 == null) break;
              fVar5 = (float)FUN_1800d6780(lVar3,uVar2,DAT_181d796d8);
              if (fVar5 < 0.0) {
                lVar3 = this.resourceValueRateTemp;
                if (lVar3 != null) {
                  fVar5 = (float)FUN_1800d6780(lVar3,uVar2,DAT_181d796d8);
                  uVar6 = Mathf.Min(0,fVar5 * 0.8 + 0.1,0);
                  goto LAB_1807eb820;
                }
                break;
              }
            }
            lVar1 = this.resourceValueRateTemp;
            uVar2 = uVar2 + 1;
            lVar4 = lVar4 + 4;
          } while (lVar1 != null);
        }
    }

    // Token : 0x6000FA3
    // RVA   : 0x7EA220   Offset: 0x7E8A20   Length: 0xE6
    public float GetAreaStateProduceRate()
    {
        float fVar1;
        fVar1 = this.support;
        if (fVar1 < 90.0) {
          if (80.0 <= fVar1) {
            return;
          }
          if (70.0 <= fVar1) {
            return;
          }
        }
    }

    // Token : 0x6000FA4
    // RVA   : 0x7EA7B0   Offset: 0x7E8FB0   Length: 0xC
    public int GetColumn(int tileID)
    {
        uint64 FUN_1807ea7b0(int64 this,int tileID)
        {
        return (int64)tileID % (int64)this.mapWidth & 0xffffffff;
    }

    // Token : 0x6000FA5
    // RVA   : 0x7EB290   Offset: 0x7E9A90   Length: 0xA
    public int GetRow(int tileID)
    {
        uint64 FUN_1807eb290(int64 this,int tileID)
        {
        return (int64)tileID / (int64)this.mapWidth & 0xffffffff;
    }

    // Token : 0x6000FA6
    // RVA   : 0x7EA350   Offset: 0x7E8B50   Length: 0x200
    public List<AreaTileData> GetAroundTiles(int tileID)
    {
        ulong uVar1;
        ulong uVar2;
        long lVar3;
        ulong uVar4;
        ulong uVar5;
        int iVar6;
        int iVar7;
        int iVar8;
        int iVar9;
        lVar3 = il2cpp_internal(DAT_181d6c230);
        FUN_180f58a90(lVar3,DAT_181d55260);
        iVar6 = this.mapWidth;
        uVar1 = (int64)tileID / (int64)iVar6;
        uVar2 = (int64)tileID % (int64)iVar6;
        iVar7 = (int)uVar2;
        iVar9 = (int)uVar1;
        if (-1 < iVar7 + -1) {
          uVar4 = AreaData.GetTile(this,iVar7 + -1,uVar1 & 0xffffffff,0);
          if (lVar3 == null) goto LAB_1807ea54b;
          FUN_181827900(lVar3,uVar4,DAT_181d552e0);
          iVar6 = this.mapWidth;
        }
        iVar8 = iVar7 + 1;
        uVar4 = 0;
        if (iVar8 < iVar6) {
          uVar5 = uVar4;
          if ((((-1 < iVar8) && (iVar8 < this.mapWidth)) && (-1 < iVar9)) &&
             (iVar9 < this.mapHeight)) {
            if (this.areaTiles == null) goto LAB_1807ea54b;
            uVar5 = FUN_180002f80(this.areaTiles,this.mapWidth * iVar9 + iVar8,
                                  DAT_181d554e0);
          }
          if (lVar3 == null) goto LAB_1807ea54b;
          FUN_181827900(lVar3,uVar5,DAT_181d552e0);
        }
        if (-1 < iVar9 + -1) {
          uVar5 = AreaData.GetTile(this,uVar2 & 0xffffffff,iVar9 + -1,0);
          if (lVar3 == null) goto LAB_1807ea54b;
          FUN_181827900(lVar3,uVar5,DAT_181d552e0);
        }
        iVar9 = iVar9 + 1;
        if (iVar9 < this.mapHeight) {
          if (((-1 < iVar7) && (iVar7 < this.mapWidth)) &&
             ((-1 < iVar9 && (uVar4 = 0, iVar9 < this.mapHeight)))) {
            if (this.areaTiles == null) goto LAB_1807ea54b;
            uVar4 = FUN_180002f80(this.areaTiles,this.mapWidth * iVar9 + iVar7,
                                  DAT_181d554e0);
          }
          if (lVar3 == null) {
        LAB_1807ea54b:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          FUN_181827900(lVar3,uVar4,DAT_181d552e0);
        }
        return lVar3;
    }

    // Token : 0x6000FA7
    // RVA   : 0x7EB450   Offset: 0x7E9C50   Length: 0x90
    public AreaTileData GetTile(int column, int row)
    {
        ulong uVar1;
        if (-1 < column) {
          if (((column < this.mapWidth) && (-1 < row)) &&
             (row < this.mapHeight)) {
            if (this.areaTiles != null) {
              uVar1 = FUN_180002f80(this.areaTiles,
                                    this.mapWidth * row + column,DAT_181d554e0);
              return uVar1;
            }
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
        }
        return 0;
    }

    // Token : 0x6000FA8
    // RVA   : 0x7E9AA0   Offset: 0x7E82A0   Length: 0x175
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

    // Token : 0x6000FA9
    // RVA   : 0x7EC130   Offset: 0x7EA930   Length: 0xED
    private static void /*cctor*/()
    {
        long lVar2;
        lVar2 = il2cpp_internal(DAT_181d6f030);
        FUN_180f58a90(lVar2,DAT_181d678f8);
        if (lVar2 != null) {
          FUN_181814fa0(lVar2,0,DAT_181d67a78);
          FUN_181814fa0(lVar2,1,DAT_181d67a78);
          FUN_181814fa0(lVar2,2,DAT_181d67a78);
          FUN_181814fa0(lVar2,3,DAT_181d67a78);
          FUN_181814fa0(lVar2,4,DAT_181d67a78);
          plVar1 = *(int64 **)(DAT_181d876b0 + 184);
          *plVar1 = lVar2;
          il2cpp_internal(plVar1,lVar2);
          return;
        }
    }

}
