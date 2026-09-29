// ============================================================
// Type  : AreaData
// Token : 0x20001F9
// ============================================================

public class AreaData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000E0D
    public int areaID;

    // Token: 0x4000E0E
    public string areaName;

    // Token: 0x4000E0F
    public int areaStartLv;

    // Token: 0x4000E10
    public string spriteName;

    // Token: 0x4000E11
    public string backgroundType;

    // Token: 0x4000E12
    public int backgroundSkinID;

    // Token: 0x4000E13
    public float xScale;

    // Token: 0x4000E14
    public BigMapPos bigMapPos;

    // Token: 0x4000E15
    public int areaType;

    // Token: 0x4000E16
    public float maxPeople;

    // Token: 0x4000E17
    public float people;

    // Token: 0x4000E18
    public float safe;

    // Token: 0x4000E19
    public float support;

    // Token: 0x4000E1A
    public float defence;

    // Token: 0x4000E1B
    public List<float> changeAreaState;

    // Token: 0x4000E1C
    public List<float> changeAllAreaState;

    // Token: 0x4000E1D
    public int belongForceID;

    // Token: 0x4000E1E
    public List<int> insideHeros;

    // Token: 0x4000E1F
    public List<float> changeResource;

    // Token: 0x4000E20
    public List<float> resourceValueRateBase;

    // Token: 0x4000E21
    public List<float> resourceValueRateTemp;

    // Token: 0x4000E22
    public List<int> connectAreaID;

    // Token: 0x4000E23
    public List<int> nearAreaID;

    // Token: 0x4000E24
    public List<int> connectResourcePointID;

    // Token: 0x4000E25
    public ForceSpeAddData areaSpeAddData;

    // Token: 0x4000E26
    public int mapWidth;

    // Token: 0x4000E27
    public int mapHeight;

    // Token: 0x4000E28
    public List<AreaTileData> areaTiles;

    // Token: 0x4000E29
    public List<int> roadTiles;

    // Token: 0x4000E2A
    public List<int> areaBranchDefenceLv;

    // Token: 0x4000E2B
    public List<int> areaBranchDefenceUpgradeLeftTime;

    // Token: 0x4000E2C
    public List<AreaTreasurePriceData> areaTreasurePriceData;

    // Token: 0x4000E2D
    public List<string> recordLog;

    // Token: 0x4000E2E
    public bool areaDetailDirty;

    // Token: 0x4000E2F
    public bool areaInfoDirty;

    // Token: 0x4000E30
    public int thisMonthManaged;

    // Token: 0x4000E31
    public int missionNumCount;

    // Token: 0x4000E32
    public int plotNumCount;

    // Token: 0x4000E33
    public AreaInteractionTimeData areaInteractionTimeData;

    // Token: 0x4000E34
    public List<string> speProduct;

    // Token: 0x4000E35
    public List<float> speBoxColliderSize;

    // Token: 0x4000E36
    public int branchLeaderID;

    // Token: 0x4000E37
    public bool autoBuild;

    // Token: 0x4000E38
    public float autoBuildResourceRateLimit;

    // Token: 0x4000E39
    public int autoBuildPriority;

    // Token: 0x4000E3A
    public string setAreaName;

    // Token: 0x4000E3B
    public bool areaIconDirty;

    // Token: 0x4000E3C
    private static List<int> UpgradeDefenceLvResourceID;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000FAB
    // RVA   : 0x7EA0D0   Offset: 0x7E94D0   Length: 0x675
    public void /*ctor*/()
    {
        ulong uVar1;
        long lVar2;
        this.branchLeaderID = 0xffffffff;
        ZhSegment.Initialize(this,0);
        this.bigMapPos = new c.DisplayClass9_0(0);
        lVar2 = il2cpp_internal(DAT_181d96ee8);
        FUN_181330100(lVar2,DAT_181da0d10);
        if (lVar2 != null) {
          FUN_18181e420(lVar2,0,DAT_181da0e10);
          FUN_18181e420(lVar2,0,DAT_181da0e10);
          FUN_18181e420(lVar2,0,DAT_181da0e10);
          FUN_18181e420(lVar2,0,DAT_181da0e10);
          FUN_18181e420(lVar2,0,DAT_181da0e10);
          FUN_18181e420(lVar2,0,DAT_181da0e10);
          this.changeResource = lVar2;
          lVar2 = il2cpp_internal(DAT_181d96ee8);
          FUN_181330100(lVar2,DAT_181da0d10);
          if (lVar2 != null) {
            FUN_18181e420(lVar2,0x3f800000,DAT_181da0e10);
            FUN_18181e420(lVar2,0x3f800000,DAT_181da0e10);
            FUN_18181e420(lVar2,0x3f800000,DAT_181da0e10);
            FUN_18181e420(lVar2,0x3f800000,DAT_181da0e10);
            FUN_18181e420(lVar2,0x3f800000,DAT_181da0e10);
            FUN_18181e420(lVar2,0x3f800000,DAT_181da0e10);
            this.resourceValueRateBase = lVar2;
            lVar2 = il2cpp_internal(DAT_181d96ee8);
            FUN_181330100(lVar2,DAT_181da0d10);
            if (lVar2 != null) {
              FUN_18181e420(lVar2,0,DAT_181da0e10);
              FUN_18181e420(lVar2,0,DAT_181da0e10);
              FUN_18181e420(lVar2,0,DAT_181da0e10);
              FUN_18181e420(lVar2,0,DAT_181da0e10);
              FUN_18181e420(lVar2,0,DAT_181da0e10);
              FUN_18181e420(lVar2,0,DAT_181da0e10);
              this.resourceValueRateTemp = lVar2;
              lVar2 = il2cpp_internal(DAT_181d96ee8);
              FUN_181330100(lVar2,DAT_181da0d10);
              if (lVar2 != null) {
                FUN_18181e420(lVar2,0,DAT_181da0e10);
                FUN_18181e420(lVar2,0,DAT_181da0e10);
                FUN_18181e420(lVar2,0,DAT_181da0e10);
                FUN_18181e420(lVar2,0,DAT_181da0e10);
                this.changeAreaState = lVar2;
                lVar2 = il2cpp_internal(DAT_181d96ee8);
                FUN_181330100(lVar2,DAT_181da0d10);
                if (lVar2 != null) {
                  FUN_18181e420(lVar2,0,DAT_181da0e10);
                  FUN_18181e420(lVar2,0,DAT_181da0e10);
                  FUN_18181e420(lVar2,0,DAT_181da0e10);
                  FUN_18181e420(lVar2,0,DAT_181da0e10);
                  this.changeAllAreaState = lVar2;
                  uVar1 = il2cpp_internal(DAT_181d93ce8);
                  FUN_181330100(uVar1,DAT_181d8f0b0);
                  this.connectAreaID = uVar1;
                  uVar1 = il2cpp_internal(DAT_181d93ce8);
                  FUN_181330100(uVar1,DAT_181d8f0b0);
                  this.nearAreaID = uVar1;
                  uVar1 = il2cpp_internal(DAT_181d93ce8);
                  FUN_181330100(uVar1,DAT_181d8f0b0);
                  this.connectResourcePointID = uVar1;
                  this.areaSpeAddData = new ForceSpeAddData(0);
                  lVar2 = il2cpp_internal(DAT_181d93ce8);
                  FUN_181330100(lVar2,DAT_181d8f0b0);
                  if (lVar2 != null) {
                    FUN_18182a6c0(lVar2,0,DAT_181d8f230);
                    FUN_18182a6c0(lVar2,0,DAT_181d8f230);
                    FUN_18182a6c0(lVar2,0,DAT_181d8f230);
                    FUN_18182a6c0(lVar2,0,DAT_181d8f230);
                    FUN_18182a6c0(lVar2,0,DAT_181d8f230);
                    this.areaBranchDefenceLv = lVar2;
                    lVar2 = il2cpp_internal(DAT_181d93ce8);
                    FUN_181330100(lVar2,DAT_181d8f0b0);
                    if (lVar2 != null) {
                      FUN_18182a6c0(lVar2,0,DAT_181d8f230);
                      FUN_18182a6c0(lVar2,0,DAT_181d8f230);
                      FUN_18182a6c0(lVar2,0,DAT_181d8f230);
                      FUN_18182a6c0(lVar2,0,DAT_181d8f230);
                      FUN_18182a6c0(lVar2,0,DAT_181d8f230);
                      this.areaBranchDefenceUpgradeLeftTime = lVar2;
                      uVar1 = il2cpp_internal(DAT_181d90ef8);
                      FUN_181330100(uVar1,DAT_181d7caf8);
                      this.areaTreasurePriceData = uVar1;
                      lVar2 = new ZhSegment(0);
                      *(uint32 *)(lVar2 + 16) = 1;
                      *(uint32 *)(lVar2 + 20) = 1;
                      this.areaInteractionTimeData = lVar2;
                      uVar1 = il2cpp_internal(DAT_181d97768);
                      FUN_181330100(uVar1,DAT_181da3bf0);
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

    // Token : 0x6000FAC
    // RVA   : 0x7E7A50   Offset: 0x7E6E50   Length: 0xD2
    public AreaData DataBase()
    {
        long lVar1;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d72d50 + 184) + 32);
        if ((lVar1 != null) && (lVar1 = *(int64 *)(lVar1 + 200)) != null) {
          FUN_1817da420(lVar1,this.areaID,DAT_181db7e10);
          return;
        }
    }

    // Token : 0x6000FAD
    // RVA   : 0x7E9350   Offset: 0x7E8750   Length: 0x168
    public ResourceData GetUpgradeDefenceLvCost(int defenceType)
    {
        uint uVar1;
        int iVar2;
        long lVar3;
        long lVar4;
        ulong uVar5;
        float fVar6;
        lVar4 = **(int64 **)(DAT_181dac7f0 + 184);
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

    // Token : 0x6000FAE
    // RVA   : 0x7E94C0   Offset: 0x7E88C0   Length: 0x63
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

    // Token : 0x6000FAF
    // RVA   : 0x7E9950   Offset: 0x7E8D50   Length: 0x67B
    public void StartUpgradeDefenceLv(int defenceType)
    {
        uint uVar1;
        int iVar2;
        long lVar3;
        bool cVar4;
        long lVar5;
        long lVar6;
        ulong uVar7;
        long lVar9;
        float fVar11;
        lVar9 = (int64)(int)defenceType;
        lVar5 = AreaData.GetForce(this,0);
        if (lVar5 != null) {
          lVar5 = AreaData.GetForce(this,0);
          lVar6 = **(int64 **)(DAT_181dac7f0 + 184);
          if (lVar6 == null) throw; // [null/range check failed]
          if (lVar6.Count <= defenceType) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar3 = this.areaBranchDefenceLv;
          uVar1 = *(uint32 *)(lVar6._items + 32 + lVar9 * 4);
          if (lVar3 == null) throw; // [null/range check failed]
          if (lVar3.Count <= defenceType) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          iVar2 = *(int *)(lVar3._items + 32 + lVar9 * 4);
          lVar6 = AreaData.GetForce(this,0);
          if (lVar6 == null) {
            fVar11 = 1.0;
          }
          else {
            lVar6 = AreaData.GetForce(this,0);
            if (lVar6 == null) throw; // [null/range check failed]
            fVar11 = (float)ForceData.GetBuildCostRate(lVar6,0);
          }
          uVar7 = new PlotChoiceRequirement(uVar1,(float)(iVar2 + 1) * 200.0 * fVar11,0);
          iVar2 = this.belongForceID;
          if ((GameController._instance == null) ||
             (lVar6 = GameController._instance.worldData) == null)
          throw; // [null/range check failed]
          lVar6 = WorldData.Player(lVar6,0);
          if ((lVar6 == null) || (lVar5 == null)) throw; // [null/range check failed]
          ForceData.CostResource(lVar5,uVar7,iVar2 == *(int *)(lVar6 + 132),0);
        }
        lVar5 = this.areaBranchDefenceUpgradeLeftTime;
        lVar6 = this.areaBranchDefenceLv;
        if (lVar6 != null) {
          if (lVar6.Count <= defenceType) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          if (lVar5 != null) {
            FUN_181834350(lVar5,defenceType,*(int *)(lVar6._items + 32 + lVar9 * 4) * 2 + 5,
                          DAT_181d8fb30);
            plVar8 = (int64 *)FUN_1800d60b0(DAT_181da4138,4);
            lVar5 = AreaData.GetForce(this,0);
            if (lVar5 != null) {
              lVar5 = ForceData.GetForceName(lVar5,1,0);
              if (plVar8 != (int64 *)0) {
                if (lVar5 != null) {
                  lVar6 = il2cpp_internal(lVar5,*(uint64 *)(*plVar8 + 64));
                  if (lVar6 == null) {
                    uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar7,0);
                  }
                }
                if ((int)plVar8[3] == 0) {
                  uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar7,0);
                }
                plVar8[4] = lVar5;
                il2cpp_internal(plVar8 + 4,lVar5);
                cVar4 = FUN_180d75bc0(this.setAreaName,0);
                if (!cVar4) {
                  lVar5 = this.setAreaName;
                }
                else {
                  lVar5 = this.areaName;
                }
                if (lVar5 != null) {
                  lVar6 = il2cpp_internal(lVar5,*(uint64 *)(*plVar8 + 64));
                  if (lVar6 == null) {
                    uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar7,0);
                  }
                }
                if (*(uint32 *)(plVar8 + 3) < 2) {
                  uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar7,0);
                }
                plVar8[5] = lVar5;
                il2cpp_internal(plVar8 + 5,lVar5);
                lVar5 = *(int64 *)(*(int64 *)(DAT_181d73d40 + 184) + 0x5c8);
                if (lVar5 != null) {
                  if (lVar5.Count <= defenceType) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  lVar5 = *(int64 *)(lVar5._items + 32 + lVar9 * 8);
                  if (lVar5 != null) {
                    lVar6 = il2cpp_internal(lVar5,*(uint64 *)(*plVar8 + 64));
                    if (lVar6 == null) {
                      uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar7,0);
                    }
                  }
                  if (*(uint32 *)(plVar8 + 3) < 3) {
                    uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar7,0);
                  }
                  plVar8[6] = lVar5;
                  il2cpp_internal(plVar8 + 6,lVar5);
                  lVar5 = this.areaBranchDefenceLv;
                  if (lVar5 != null) {
                    if (lVar5.Count <= defenceType) {
                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                    }
                    lVar9 = GlobalData.GetNumText
                                      (*(uint32 *)(lVar5._items + 32 + lVar9 * 4),0);
                    if (lVar9 != null) {
                      lVar5 = il2cpp_internal(lVar9,*(uint64 *)(*plVar8 + 64));
                      if (lVar5 == null) {
                        uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar7,0);
                      }
                    }
                    if (*(uint32 *)(plVar8 + 3) < 4) {
                      uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar7,0);
                    }
                    plVar8[7] = lVar9;
                    il2cpp_internal(plVar8 + 7,lVar9);
                    uVar7 = String.Format("{0}近日开始加强{1}分舵之{2}防御等级({3}级)",plVar8,0);
                    AreaData.AddLog(this,uVar7,0);
                    lVar9 = **(int64 **)(DAT_181d7f6c0 + 184);
                    iVar2 = this.belongForceID;
                    if (iVar2 == -1) {
                      bVar10 = false;
                    }
                    else {
                      if ((GameController._instance == null) ||
                         (lVar5 = GameController._instance.worldData) == null
                         ) throw; // [null/range check failed]
                      lVar5 = WorldData.Player(lVar5,0);
                      if (lVar5 == null) throw; // [null/range check failed]
                      bVar10 = iVar2 == *(int *)(lVar5 + 132);
                    }
                    if (lVar9 != null) {
                      InfoController.AddInfo(lVar9,bVar10,uVar7,0);
                      return;
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6000FB0
    // RVA   : 0x7E69E0   Offset: 0x7E5DE0   Length: 0x162
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
            FUN_181834350(lVar4,uVar5,iVar1 - iVar3,DAT_181d8fb30);
            if (this.areaBranchDefenceUpgradeLeftTime == null) break;
            FUN_181834350(this.areaBranchDefenceUpgradeLeftTime,uVar5,0);
            lVar4 = this.areaBranchDefenceLv;
            uVar5 = uVar5 + 1;
            lVar7 = lVar7 + 4;
          } while (lVar4 != null);
        }
    }

    // Token : 0x6000FB1
    // RVA   : 0x7E8630   Offset: 0x7E7A30   Length: 0x462
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
                   (lVar2 = FUN_180002f80(this.areaTiles,uVar4,DAT_181d7ca78)) == null)
                break;
                if (*(int64 *)(lVar2 + 40) != 0) {
                  if (((this.areaTiles == null) ||
                      (lVar2 = FUN_180002f80(this.areaTiles,uVar4,DAT_181d7ca78),
                      lVar2 == null)) || (*(int64 *)(lVar2 + 40) == 0)) break;
                  if (-1 < *(int *)(*(int64 *)(lVar2 + 40) + 16)) {
                    if (((this.areaTiles == null) ||
                        (lVar2 = FUN_180002f80(this.areaTiles,uVar4,DAT_181d7ca78),
                        lVar2 == null)) ||
                       ((*(int64 *)(lVar2 + 40) == 0 ||
                        (lVar2 = AreaBuildingData.DataBase(*(int64 *)(lVar2 + 40),0)) == null)))
                    break;
                    if (*(char *)(lVar2 + 53) != false) {
                      if (((this.areaTiles != null) &&
                          (lVar2 = FUN_180002f80(this.areaTiles,uVar4,DAT_181d7ca78),
                          lVar2 != null)) && (*(int64 *)(lVar2 + 40) != 0)) goto LAB_1807e8925;
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
        LAB_1807e8925:
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
                    (uVar1 = FUN_1800d6760(this.connectResourcePointID,iVar5,DAT_181d8fa30), lVar2 == null)
                    ) || (lVar2 = WorldData.GetResourcePoint(lVar2,uVar1,0)) == null) break;
                if (*(int *)(lVar2 + 48) == this.belongForceID) {
                  lVar2 = FUN_18046c0a0(0);
                  if (lVar2 == null) break;
                  lVar2 = *(int64 *)(lVar2 + 32);
                  if (((this.connectResourcePointID == null) ||
                      (uVar1 = FUN_1800d6760(this.connectResourcePointID,iVar5,DAT_181d8fa30),
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

    // Token : 0x6000FB2
    // RVA   : 0x7E6E50   Offset: 0x7E6250   Length: 0xD9
    public bool BelongPlayer()
    {
        int iVar1;
        long lVar2;
        iVar1 = this.belongForceID;
        if (iVar1 == -1) {
          return false;
        }
        if ((GameController._instance != null) &&
           (lVar2 = GameController._instance.worldData) != null) {
          lVar2 = WorldData.Player(lVar2,0);
          if (lVar2 != null) {
            return iVar1 == *(int *)(lVar2 + 132);
          }
        }
    }

    // Token : 0x6000FB3
    // RVA   : 0x7E6B50   Offset: 0x7E5F50   Length: 0x2FF
    public bool BelongPlayerOrAlley()
    {
        int iVar1;
        bool cVar2;
        byte uVar3;
        long lVar4;
        if (((GameController._instance != null) &&
            (lVar4 = GameController._instance.worldData) != null) &&
           (lVar4 = WorldData.Player(lVar4,0)) != null) {
          cVar2 = HeroData.HaveForce(lVar4,0);
          if (!cVar2) {
            return false;
          }
          iVar1 = this.belongForceID;
          if (((GameController._instance != null) &&
              (lVar4 = GameController._instance.worldData) != null) &&
             (lVar4 = WorldData.Player(lVar4,0)) != null) {
            if (iVar1 == *(int *)(lVar4 + 132)) {
              return true;
            }
            iVar1 = this.belongForceID;
            lVar4 = FUN_18046c0a0(0);
            if (((lVar4 != null) && (lVar4.villageAreaID != null)) &&
               ((lVar4 = WorldData.Player(lVar4.villageAreaID,0), lVar4 != null &&
                (lVar4 = HeroData.GetForce(lVar4,0,0)) != null))) {
              if (iVar1 == *(int *)(lVar4 + 60)) {
                return true;
              }
              lVar4 = FUN_18046c0a0(0);
              if ((((lVar4 != null) && (lVar4.villageAreaID != null)) &&
                  (lVar4 = WorldData.Player(lVar4.villageAreaID,0)) != null) &&
                 ((lVar4 = HeroData.GetForce(lVar4,0,0), lVar4 != null && (lVar4.ResourcePoints != null)
                  ))) {
                cVar2 = FUN_18182a9b0(lVar4.ResourcePoints,this.belongForceID,
                                      DAT_181d8f3b0);
                if (cVar2) {
                  return true;
                }
                lVar4 = FUN_18046c0a0(0);
                if ((((lVar4 != null) && (lVar4.villageAreaID != null)) &&
                    (lVar4 = WorldData.Player(lVar4.villageAreaID,0)) != null) &&
                   (lVar4 = HeroData.GetForce(lVar4,0,0)) != null) {
                  uVar3 = ForceData.IsAllyForce(lVar4,this.belongForceID,0);
                  return uVar3;
                }
              }
            }
          }
        }
    }

    // Token : 0x6000FB4
    // RVA   : 0x7E7FF0   Offset: 0x7E73F0   Length: 0x32
    public string GetAreaName()
    {
        bool cVar1;
        cVar1 = FUN_180d75bc0(this.setAreaName,0);
        if (cVar1) {
          return this.areaName;
        }
        return this.setAreaName;
    }

    // Token : 0x6000FB5
    // RVA   : 0x7E7E70   Offset: 0x7E7270   Length: 0x17C
    public int GetAreaMapRandomEventCount()
    {
        bool cVar1;
        long lVar2;
        int iVar3;
        int iVar4;
        iVar4 = 0;
        iVar3 = 0;
        while( true ) {
          if (((GameController._instance == null) ||
              (lVar2 = GameController._instance.worldData) == null) ||
             (lVar2 = lVar2.AreaMapRandomEventDatas) == null) break;
          if (lVar2.cityAreaID <= iVar3) {
            return iVar4;
          }
          lVar2 = FUN_18046c0a0(0);
          if (((lVar2 == null) || (lVar2.villageAreaID == null)) ||
             (lVar2 = *(int64 *)(lVar2.villageAreaID + 104)) == null) break;
          lVar2 = FUN_180002f80(lVar2,iVar3,DAT_181d85e38);
          if ((lVar2 == null) || (lVar2.ResourcePoints == null)) break;
          cVar1 = FUN_18182a9b0(lVar2.ResourcePoints,this.areaID,DAT_181d8f3b0)
          ;
          if (cVar1) {
            iVar4 = iVar4 + 1;
          }
          iVar3 = iVar3 + 1;
        }
    }

    // Token : 0x6000FB6
    // RVA   : 0x7E9120   Offset: 0x7E8520   Length: 0x16B
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
                 (lVar1 = FUN_180002f80(this.areaTiles,uVar3,DAT_181d7ca78)) == null)
              break;
              if (*(int64 *)(lVar1 + 40) != 0) {
                if (((this.areaTiles == null) ||
                    (lVar1 = FUN_180002f80(this.areaTiles,uVar3,DAT_181d7ca78)) == null
                    ) || (*(int64 *)(lVar1 + 40) == 0)) break;
                if (-1 < *(int *)(*(int64 *)(lVar1 + 40) + 16)) {
                  if (((this.areaTiles == null) ||
                      (lVar1 = FUN_180002f80(this.areaTiles,uVar3,DAT_181d7ca78),
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

    // Token : 0x6000FB7
    // RVA   : 0x7E83D0   Offset: 0x7E77D0   Length: 0x190
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
                 (lVar1 = FUN_180002f80(this.areaTiles,uVar2,DAT_181d7ca78)) == null)
              break;
              if (*(int64 *)(lVar1 + 40) != 0) {
                if (((this.areaTiles == null) ||
                    (lVar1 = FUN_180002f80(this.areaTiles,uVar2,DAT_181d7ca78)) == null
                    ) || (*(int64 *)(lVar1 + 40) == 0)) break;
                if (-1 < *(int *)(*(int64 *)(lVar1 + 40) + 16)) {
                  if (((this.areaTiles == null) ||
                      (lVar1 = FUN_180002f80(this.areaTiles,uVar2,DAT_181d7ca78),
                      lVar1 == null)) ||
                     ((*(int64 *)(lVar1 + 40) == 0 ||
                      (lVar1 = AreaBuildingData.DataBase(*(int64 *)(lVar1 + 40),0)) == null)))
                  break;
                  if (*(char *)(lVar1 + 53) != false) {
                    if ((this.areaTiles != null) &&
                       (lVar1 = FUN_180002f80(this.areaTiles,uVar2,DAT_181d7ca78),
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

    // Token : 0x6000FB8
    // RVA   : 0x7E8DB0   Offset: 0x7E81B0   Length: 0x1BA
    public List<HeroData> GetInsideHeros()
    {
        long lVar1;
        long lVar2;
        ulong uVar3;
        long lVar4;
        uint uVar5;
        long lVar6;
        lVar2 = il2cpp_internal(DAT_181d93368);
        FUN_181330100(lVar2,DAT_181d8b430);
        lVar4 = this.insideHeros;
        uVar5 = 0;
        if (lVar4 != null) {
          lVar6 = 32;
          while( true ) {
            if (lVar4.Count <= (int)uVar5) {
              return lVar2;
            }
            if (GameController._instance == null) break;
            lVar4 = this.insideHeros;
            lVar1 = GameController._instance.worldData;
            if (lVar4 == null) break;
            if (lVar4.Count <= uVar5) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            if ((lVar1 == null) ||
               (uVar3 = WorldData.GetHero(lVar1,*(uint32 *)(lVar6 + lVar4._items),0),
               lVar2 == null)) break;
            FUN_18181e6b0(lVar2,uVar3);
            lVar4 = this.insideHeros;
            uVar5 = uVar5 + 1;
            lVar6 = lVar6 + 4;
            if (lVar4 == null) break;
          }
        }
    }

    // Token : 0x6000FB9
    // RVA   : 0x7E8CB0   Offset: 0x7E80B0   Length: 0xFD
    public HeroData GetInsideHero(int id)
    {
        long lVar1;
        long lVar2;
        if (GameController._instance != null) {
          lVar1 = this.insideHeros;
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

    // Token : 0x6000FBA
    // RVA   : 0x7E9820   Offset: 0x7E8C20   Length: 0x12E
    public void SetBranchLeader(HeroData targetHero)
    {
        long lVar1;
        if (-1 < this.branchLeaderID) {
          if ((GameController._instance != null) &&
             (lVar1 = GameController._instance.worldData) != null) {
            lVar1 = WorldData.GetHero(lVar1,this.branchLeaderID,0);
            if (lVar1 != null) {
              lVar1.gameMode = 0xffffffff;
              goto LAB_1807e98fa;
            }
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        LAB_1807e98fa:
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

    // Token : 0x6000FBB
    // RVA   : 0x7E9800   Offset: 0x7E8C00   Length: 0x11
    public void ResetAutoSetting()
    {
        this.autoBuild = 0;
        this.autoBuildResourceRateLimit = 0;
    }

    // Token : 0x6000FBC
    // RVA   : 0x7E6F30   Offset: 0x7E6330   Length: 0x32
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

    // Token : 0x6000FBD
    // RVA   : 0x7E6F70   Offset: 0x7E6370   Length: 0x42
    public bool CanReduceState()
    {
        if (((this.safe <= 15.0) && (this.support <= 15.0)) &&
           (this.defence <= 15.0)) {
          return this.maxPeople * 0.15 < this.people;
        }
        return true;
    }

    // Token : 0x6000FBE
    // RVA   : 0x7E8FF0   Offset: 0x7E83F0   Length: 0xFA
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

    // Token : 0x6000FBF
    // RVA   : 0x7E6530   Offset: 0x7E5930   Length: 0x4A5
    public void AddLog(string newLog)
    {
        int iVar1;
        long lVar2;
        long lVar4;
        long lVar5;
        ulong uVar6;
        uint[] local_res8 = new uint[2];
        uint[] local_res20 = new uint[2];
        uint[] local_28 = new uint[4];
        lVar2 = this.recordLog;
        plVar3 = (int64 *)FUN_1800d60b0(DAT_181da4138,4);
        if (((GameController._instance != null) &&
            (lVar4 = GameController._instance.worldData) != null) &&
           (lVar4 = lVar4.worldTime) != null) {
          local_res8[0] = lVar4.chapter;
          lVar4 = il2cpp_value_box(DAT_181d80430,local_res8);
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
            if (((GameController._instance != null) &&
                (lVar4 = GameController._instance.worldData) != null) &&
               (lVar4 = lVar4.worldTime) != null) {
              local_res20[0] = *(uint32 *)(lVar4 + 20);
              lVar4 = il2cpp_value_box(DAT_181d80430,local_res20);
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
              if (((GameController._instance != null) &&
                  (lVar4 = GameController._instance.worldData) != null) &&
                 (lVar4 = lVar4.worldTime) != null) {
                local_28[0] = lVar4.cityAreaID;
                lVar4 = il2cpp_value_box(DAT_181d80430,local_28);
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
                  FUN_18181e6b0(lVar2,uVar6,DAT_181da3d70);
                  lVar2 = this.recordLog;
                  while (lVar2 != null) {
                    iVar1 = lVar2.Count;
                    if (iVar1 <= *(int *)(*(int64 *)(DAT_181d73d40 + 184) + 232)) {
                      this.areaInfoDirty = 1;
                      return;
                    }
                    if (this.recordLog == null) break;
                    FUN_181823ba0(this.recordLog,0,DAT_181da4170);
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

    // Token : 0x6000FC0
    // RVA   : 0x7E6FC0   Offset: 0x7E63C0   Length: 0x44
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

    // Token : 0x6000FC1
    // RVA   : 0x7E8030   Offset: 0x7E7430   Length: 0x51
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

    // Token : 0x6000FC2
    // RVA   : 0x7E8180   Offset: 0x7E7580   Length: 0x34
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

    // Token : 0x6000FC3
    // RVA   : 0x7E8F70   Offset: 0x7E8370   Length: 0x14
    public float GetMaxAreaState(int areaStateType)
    {
        if (areaStateType != 3) {
          return 0x42c80000;
        }
        return this.maxPeople;
    }

    // Token : 0x6000FC4
    // RVA   : 0x7E9290   Offset: 0x7E8690   Length: 0x15
    public float GetSupport()
    {
        if (this.areaType != 2) {
          return this.support;
        }
        return 0x42480000;
    }

    // Token : 0x6000FC5
    // RVA   : 0x7E9100   Offset: 0x7E8500   Length: 0x15
    public float GetSafe()
    {
        if (this.areaType != 2) {
          return this.safe;
        }
        return 0x42480000;
    }

    // Token : 0x6000FC6
    // RVA   : 0x7E7CC0   Offset: 0x7E70C0   Length: 0x1AD
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
                 (lVar1 = FUN_180002f80(this.areaTiles,uVar2,DAT_181d7ca78)) == null)
              break;
              if (*(int64 *)(lVar1 + 40) != 0) {
                if (((this.areaTiles == null) ||
                    (lVar1 = FUN_180002f80(this.areaTiles,uVar2,DAT_181d7ca78)) == null
                    ) || (*(int64 *)(lVar1 + 40) == 0)) break;
                if (-1 < *(int *)(*(int64 *)(lVar1 + 40) + 16)) {
                  if (((this.areaTiles == null) ||
                      (lVar1 = FUN_180002f80(this.areaTiles,uVar2,DAT_181d7ca78),
                      lVar1 == null)) || (*(int64 *)(lVar1 + 40) == 0)) break;
                  if (*(int *)(*(int64 *)(lVar1 + 40) + 16) == buildingName) {
                    if ((this.areaTiles != null) &&
                       (lVar1 = FUN_180002f80(this.areaTiles,uVar2,DAT_181d7ca78),
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

    // Token : 0x6000FC7
    // RVA   : 0x7E7B30   Offset: 0x7E6F30   Length: 0x18C
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
                 (lVar1 = FUN_180002f80(this.areaTiles,uVar2,DAT_181d7ca78)) == null)
              break;
              if (*(int64 *)(lVar1 + 40) != 0) {
                if (((this.areaTiles == null) ||
                    (lVar1 = FUN_180002f80(this.areaTiles,uVar2,DAT_181d7ca78)) == null
                    ) || (*(int64 *)(lVar1 + 40) == 0)) break;
                if (-1 < *(int *)(*(int64 *)(lVar1 + 40) + 16)) {
                  if (((this.areaTiles == null) ||
                      (lVar1 = FUN_180002f80(this.areaTiles,uVar2,DAT_181d7ca78),
                      lVar1 == null)) || (*(int64 *)(lVar1 + 40) == 0)) break;
                  if (*(int *)(*(int64 *)(lVar1 + 40) + 16) == buildingID) {
                    if ((this.areaTiles != null) &&
                       (lVar1 = FUN_180002f80(this.areaTiles,uVar2,DAT_181d7ca78),
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

    // Token : 0x6000FC8
    // RVA   : 0x7E8570   Offset: 0x7E7970   Length: 0xA6
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

    // Token : 0x6000FC9
    // RVA   : 0x7E8570   Offset: 0x7E7970   Length: 0xA6
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

    // Token : 0x6000FCA
    // RVA   : 0x7E9530   Offset: 0x7E8930   Length: 0x8
    public bool HaveForce()
    {
        return this.belongForceID != -1;
    }

    // Token : 0x6000FCB
    // RVA   : 0x7E8AA0   Offset: 0x7E7EA0   Length: 0x133
    public Color GetForceColor()
    {
        long lVar2;
        long lVar3;
        ulong uVar4;
        ulong local_28;
        ulong uStack_20;
        byte[] local_18 = new byte[16];
        local_28 = 0;
        uStack_20 = 0;
        if (*(int *)(param_2 + 112) == -1) {
          puVar1 = (uint64 *)FUN_180d995f0(local_18);
          uVar4 = puVar1[1];
          *this = *puVar1;
          this[1] = uVar4;
          return this;
        }
        lVar2 = AreaData.GetForce(param_2,0);
        uVar4 = "#";
        if (lVar2 == null) throw; // [null/range check failed]
        if (*(int *)(lVar2 + 60) < 0) {
          lVar2 = AreaData.GetForce(param_2,0);
        }
        else {
          lVar2 = FUN_18046c0a0(0);
          if (lVar2 == null) throw; // [null/range check failed]
          lVar2 = *(int64 *)(lVar2 + 32);
          lVar3 = AreaData.GetForce(param_2,0);
          if ((lVar3 == null) || (lVar2 == null)) throw; // [null/range check failed]
          lVar2 = WorldData.GetForce(lVar2,*(uint32 *)(lVar3 + 60),0);
        }
        if (lVar2 != null) {
          uVar4 = String.Concat(uVar4,*(uint64 *)(lVar2 + 80),0);
          ColorUtility.TryParseHtmlString(uVar4,&local_28,0);
          *this = local_28;
          this[1] = uStack_20;
          return this;
        }
    }

    // Token : 0x6000FCC
    // RVA   : 0x7E8BE0   Offset: 0x7E7FE0   Length: 0xCC
    public ForceData GetForce()
    {
        long lVar1;
        ulong uVar2;
        if (this.belongForceID == -1) {
          return 0;
        }
        if ((GameController._instance != null) &&
           (lVar1 = GameController._instance.worldData) != null) {
          uVar2 = WorldData.GetForce(lVar1,this.belongForceID,0);
          return uVar2;
        }
    }

    // Token : 0x6000FCD
    // RVA   : 0x7E8FD0   Offset: 0x7E83D0   Length: 0x16
    public float GetMonthChangeSupport()
    {
        return (50.0 - this.support) * 0.2;
    }

    // Token : 0x6000FCE
    // RVA   : 0x7E8FB0   Offset: 0x7E83B0   Length: 0x16
    public float GetMonthChangeSafe()
    {
        return (50.0 - this.safe) * 0.2;
    }

    // Token : 0x6000FCF
    // RVA   : 0x7E8F90   Offset: 0x7E8390   Length: 0x16
    public float GetMonthChangeDefence()
    {
        return (50.0 - this.defence) * 0.2;
    }

    // Token : 0x6000FD0
    // RVA   : 0x7E7240   Offset: 0x7E6640   Length: 0x94
    public void ChangePeople(float num)
    {
        long lVar1;
        bool cVar2;
        ulong uVar3;
        ulong uVar4;
        uint uVar5;
        float[] local_res10 = new float[6];
        ulong local_18;
        ulong uStack_10;
        local_res10[0] = num;
        if (local_res10[0] != 0.0) {
          uVar5 = FUN_1810e3cd0(this.people + local_res10[0],0,
                                this.maxPeople,0);
          this.people = uVar5;
          this.areaDetailDirty = 1;
          if (param_3) {
            lVar1 = **(int64 **)(DAT_181d7f6c0 + 184);
            cVar2 = FUN_180d75bc0(this.setAreaName,0);
            if (!cVar2) {
              uVar4 = this.setAreaName;
            }
            else {
              uVar4 = this.areaName;
            }
            uVar3 = Single.ToString(local_res10,"+0;-0;0",0);
            uVar4 = String.Concat(uVar4,"人口",uVar3,0);
            if (lVar1 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            local_18 = 0;
            uStack_10 = 0;
            InfoController.AddInfoTab
                      (lVar1,uVar4,"UIAtlas","地区_人口","NoticeLittle",0x3f800000,0x40a00000,
                       &local_18,0);
          }
        }
    }

    // Token : 0x6000FD1
    // RVA   : 0x7E76A0   Offset: 0x7E6AA0   Length: 0x97
    public void ChangeSupport(float num)
    {
        long lVar1;
        bool cVar2;
        ulong uVar3;
        ulong uVar4;
        uint uVar5;
        float[] local_res10 = new float[6];
        ulong local_18;
        ulong uStack_10;
        local_res10[0] = num;
        if (local_res10[0] != 0.0) {
          uVar5 = FUN_1810e3cd0(this.support + local_res10[0],0,0x42c80000,0);
          this.support = uVar5;
          this.areaDetailDirty = 1;
          if (param_3) {
            lVar1 = **(int64 **)(DAT_181d7f6c0 + 184);
            cVar2 = FUN_180d75bc0(this.setAreaName,0);
            if (!cVar2) {
              uVar4 = this.setAreaName;
            }
            else {
              uVar4 = this.areaName;
            }
            uVar3 = Single.ToString(local_res10,"+0;-0;0",0);
            uVar4 = String.Concat(uVar4,"民心",uVar3,0);
            if (lVar1 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            local_18 = 0;
            uStack_10 = 0;
            InfoController.AddInfoTab
                      (lVar1,uVar4,"UIAtlas","地区_民心","NoticeLittle",0x3f800000,0x40a00000,
                       &local_18,0);
          }
        }
    }

    // Token : 0x6000FD2
    // RVA   : 0x7E7600   Offset: 0x7E6A00   Length: 0x97
    public void ChangeSafe(float num)
    {
        long lVar1;
        bool cVar2;
        ulong uVar3;
        ulong uVar4;
        uint uVar5;
        float[] local_res10 = new float[6];
        ulong local_18;
        ulong uStack_10;
        local_res10[0] = num;
        if (local_res10[0] != 0.0) {
          uVar5 = FUN_1810e3cd0(this.safe + local_res10[0],0,0x42c80000,0);
          this.safe = uVar5;
          this.areaDetailDirty = 1;
          if (param_3) {
            lVar1 = **(int64 **)(DAT_181d7f6c0 + 184);
            cVar2 = FUN_180d75bc0(this.setAreaName,0);
            if (!cVar2) {
              uVar4 = this.setAreaName;
            }
            else {
              uVar4 = this.areaName;
            }
            uVar3 = Single.ToString(local_res10,"+0;-0;0",0);
            uVar4 = String.Concat(uVar4,"治安",uVar3,0);
            if (lVar1 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            local_18 = 0;
            uStack_10 = 0;
            InfoController.AddInfoTab
                      (lVar1,uVar4,"UIAtlas","地区_治安","NoticeLittle",0x3f800000,0x40a00000,
                       &local_18,0);
          }
        }
    }

    // Token : 0x6000FD3
    // RVA   : 0x7E7010   Offset: 0x7E6410   Length: 0x97
    public void ChangeDefence(float num)
    {
        long lVar1;
        bool cVar2;
        ulong uVar3;
        ulong uVar4;
        uint uVar5;
        float[] local_res10 = new float[6];
        ulong local_18;
        ulong uStack_10;
        local_res10[0] = num;
        if (local_res10[0] != 0.0) {
          uVar5 = FUN_1810e3cd0(this.defence + local_res10[0],0,0x42c80000,0);
          this.defence = uVar5;
          this.areaDetailDirty = 1;
          if (param_3) {
            lVar1 = **(int64 **)(DAT_181d7f6c0 + 184);
            cVar2 = FUN_180d75bc0(this.setAreaName,0);
            if (!cVar2) {
              uVar4 = this.setAreaName;
            }
            else {
              uVar4 = this.areaName;
            }
            uVar3 = Single.ToString(local_res10,"+0;-0;0",0);
            uVar4 = String.Concat(uVar4,"防御",uVar3,0);
            if (lVar1 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            local_18 = 0;
            uStack_10 = 0;
            InfoController.AddInfoTab
                      (lVar1,uVar4,"UIAtlas","地区_防御","NoticeLittle",0x3f800000,0x40a00000,
                       &local_18,0);
          }
        }
    }

    // Token : 0x6000FD4
    // RVA   : 0x7E72E0   Offset: 0x7E66E0   Length: 0x18C
    public void ChangePeople(float num, bool showInfo)
    {
        long lVar1;
        bool cVar2;
        ulong uVar3;
        ulong uVar4;
        uint uVar5;
        float[] local_res10 = new float[6];
        ulong local_18;
        ulong uStack_10;
        local_res10[0] = num;
        if (local_res10[0] != 0.0) {
          uVar5 = FUN_1810e3cd0(this.people + local_res10[0],0,
                                this.maxPeople,0);
          this.people = uVar5;
          this.areaDetailDirty = 1;
          if (showInfo) {
            lVar1 = **(int64 **)(DAT_181d7f6c0 + 184);
            cVar2 = FUN_180d75bc0(this.setAreaName,0);
            if (!cVar2) {
              uVar4 = this.setAreaName;
            }
            else {
              uVar4 = this.areaName;
            }
            uVar3 = Single.ToString(local_res10,"+0;-0;0",0);
            uVar4 = String.Concat(uVar4,"人口",uVar3,0);
            if (lVar1 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            local_18 = 0;
            uStack_10 = 0;
            InfoController.AddInfoTab
                      (lVar1,uVar4,"UIAtlas","地区_人口","NoticeLittle",0x3f800000,0x40a00000,
                       &local_18,0);
          }
        }
    }

    // Token : 0x6000FD5
    // RVA   : 0x7E7740   Offset: 0x7E6B40   Length: 0x18F
    public void ChangeSupport(float num, bool showInfo)
    {
        long lVar1;
        bool cVar2;
        ulong uVar3;
        ulong uVar4;
        uint uVar5;
        float[] local_res10 = new float[6];
        ulong local_18;
        ulong uStack_10;
        local_res10[0] = num;
        if (local_res10[0] != 0.0) {
          uVar5 = FUN_1810e3cd0(this.support + local_res10[0],0,0x42c80000,0);
          this.support = uVar5;
          this.areaDetailDirty = 1;
          if (showInfo) {
            lVar1 = **(int64 **)(DAT_181d7f6c0 + 184);
            cVar2 = FUN_180d75bc0(this.setAreaName,0);
            if (!cVar2) {
              uVar4 = this.setAreaName;
            }
            else {
              uVar4 = this.areaName;
            }
            uVar3 = Single.ToString(local_res10,"+0;-0;0",0);
            uVar4 = String.Concat(uVar4,"民心",uVar3,0);
            if (lVar1 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            local_18 = 0;
            uStack_10 = 0;
            InfoController.AddInfoTab
                      (lVar1,uVar4,"UIAtlas","地区_民心","NoticeLittle",0x3f800000,0x40a00000,
                       &local_18,0);
          }
        }
    }

    // Token : 0x6000FD6
    // RVA   : 0x7E7470   Offset: 0x7E6870   Length: 0x18F
    public void ChangeSafe(float num, bool showInfo)
    {
        long lVar1;
        bool cVar2;
        ulong uVar3;
        ulong uVar4;
        uint uVar5;
        float[] local_res10 = new float[6];
        ulong local_18;
        ulong uStack_10;
        local_res10[0] = num;
        if (local_res10[0] != 0.0) {
          uVar5 = FUN_1810e3cd0(this.safe + local_res10[0],0,0x42c80000,0);
          this.safe = uVar5;
          this.areaDetailDirty = 1;
          if (showInfo) {
            lVar1 = **(int64 **)(DAT_181d7f6c0 + 184);
            cVar2 = FUN_180d75bc0(this.setAreaName,0);
            if (!cVar2) {
              uVar4 = this.setAreaName;
            }
            else {
              uVar4 = this.areaName;
            }
            uVar3 = Single.ToString(local_res10,"+0;-0;0",0);
            uVar4 = String.Concat(uVar4,"治安",uVar3,0);
            if (lVar1 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            local_18 = 0;
            uStack_10 = 0;
            InfoController.AddInfoTab
                      (lVar1,uVar4,"UIAtlas","地区_治安","NoticeLittle",0x3f800000,0x40a00000,
                       &local_18,0);
          }
        }
    }

    // Token : 0x6000FD7
    // RVA   : 0x7E70B0   Offset: 0x7E64B0   Length: 0x18F
    public void ChangeDefence(float num, bool showInfo)
    {
        long lVar1;
        bool cVar2;
        ulong uVar3;
        ulong uVar4;
        uint uVar5;
        float[] local_res10 = new float[6];
        ulong local_18;
        ulong uStack_10;
        local_res10[0] = num;
        if (local_res10[0] != 0.0) {
          uVar5 = FUN_1810e3cd0(this.defence + local_res10[0],0,0x42c80000,0);
          this.defence = uVar5;
          this.areaDetailDirty = 1;
          if (showInfo) {
            lVar1 = **(int64 **)(DAT_181d7f6c0 + 184);
            cVar2 = FUN_180d75bc0(this.setAreaName,0);
            if (!cVar2) {
              uVar4 = this.setAreaName;
            }
            else {
              uVar4 = this.areaName;
            }
            uVar3 = Single.ToString(local_res10,"+0;-0;0",0);
            uVar4 = String.Concat(uVar4,"防御",uVar3,0);
            if (lVar1 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            local_18 = 0;
            uStack_10 = 0;
            InfoController.AddInfoTab
                      (lVar1,uVar4,"UIAtlas","地区_防御","NoticeLittle",0x3f800000,0x40a00000,
                       &local_18,0);
          }
        }
    }

    // Token : 0x6000FD8
    // RVA   : 0x7E9FD0   Offset: 0x7E93D0   Length: 0x10
    public float TotalState()
    {
        return this.support + this.safe + this.defence;
    }

    // Token : 0x6000FD9
    // RVA   : 0x7E9700   Offset: 0x7E8B00   Length: 0xF5
    public void ResetAllState()
    {
        uint uVar1;
        uint uVar2;
        uVar2 = this.safe;
        GlobalData.RandomRange(25,36,0);
        uVar1 = FUN_1810e3cd0(uVar2);
        uVar2 = this.support;
        this.safe = uVar1;
        GlobalData.RandomRange(25,36,0);
        uVar1 = FUN_1810e3cd0(uVar2);
        uVar2 = this.defence;
        this.support = uVar1;
        GlobalData.RandomRange(25,36,0);
        uVar2 = FUN_1810e3cd0(uVar2);
        this.defence = uVar2;
    }

    // Token : 0x6000FDA
    // RVA   : 0x7E9540   Offset: 0x7E8940   Length: 0x1B2
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
              fVar5 = (float)FUN_1800d6790(lVar3,uVar2,DAT_181da1090);
              uVar6 = Mathf.Max(0,fVar5 * 0.8 - 0.1,0);
        LAB_1807e9690:
              FUN_18182a350(lVar3,uVar2,uVar6,DAT_181da1110);
            }
            else {
              if (lVar3 == null) break;
              fVar5 = (float)FUN_1800d6790(lVar3,uVar2,DAT_181da1090);
              if (fVar5 < 0.0) {
                lVar3 = this.resourceValueRateTemp;
                if (lVar3 != null) {
                  fVar5 = (float)FUN_1800d6790(lVar3,uVar2,DAT_181da1090);
                  uVar6 = Mathf.Min(0,fVar5 * 0.8 + 0.1,0);
                  goto LAB_1807e9690;
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

    // Token : 0x6000FDB
    // RVA   : 0x7E8090   Offset: 0x7E7490   Length: 0xE6
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

    // Token : 0x6000FDC
    // RVA   : 0x7E8620   Offset: 0x7E7A20   Length: 0xC
    public int GetColumn(int tileID)
    {
        uint64 FUN_1807e8620(int64 this,int tileID)
        {
        return (int64)tileID % (int64)this.mapWidth & 0xffffffff;
    }

    // Token : 0x6000FDD
    // RVA   : 0x7E90F0   Offset: 0x7E84F0   Length: 0xA
    public int GetRow(int tileID)
    {
        uint64 FUN_1807e90f0(int64 this,int tileID)
        {
        return (int64)tileID / (int64)this.mapWidth & 0xffffffff;
    }

    // Token : 0x6000FDE
    // RVA   : 0x7E81C0   Offset: 0x7E75C0   Length: 0x200
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
        lVar3 = il2cpp_internal(DAT_181d90e78);
        FUN_181330100(lVar3,DAT_181d7c7f8);
        iVar6 = this.mapWidth;
        uVar1 = (int64)tileID / (int64)iVar6;
        uVar2 = (int64)tileID % (int64)iVar6;
        iVar7 = (int)uVar2;
        iVar9 = (int)uVar1;
        if (-1 < iVar7 + -1) {
          uVar4 = AreaData.GetTile(this,iVar7 + -1,uVar1 & 0xffffffff,0);
          if (lVar3 == null) goto LAB_1807e83bb;
          FUN_18181e6b0(lVar3,uVar4,DAT_181d7c878);
          iVar6 = this.mapWidth;
        }
        iVar8 = iVar7 + 1;
        uVar4 = 0;
        if (iVar8 < iVar6) {
          uVar5 = uVar4;
          if ((((-1 < iVar8) && (iVar8 < this.mapWidth)) && (-1 < iVar9)) &&
             (iVar9 < this.mapHeight)) {
            if (this.areaTiles == null) goto LAB_1807e83bb;
            uVar5 = FUN_180002f80(this.areaTiles,this.mapWidth * iVar9 + iVar8,
                                  DAT_181d7ca78);
          }
          if (lVar3 == null) goto LAB_1807e83bb;
          FUN_18181e6b0(lVar3,uVar5,DAT_181d7c878);
        }
        if (-1 < iVar9 + -1) {
          uVar5 = AreaData.GetTile(this,uVar2 & 0xffffffff,iVar9 + -1,0);
          if (lVar3 == null) goto LAB_1807e83bb;
          FUN_18181e6b0(lVar3,uVar5,DAT_181d7c878);
        }
        iVar9 = iVar9 + 1;
        if (iVar9 < this.mapHeight) {
          if (((-1 < iVar7) && (iVar7 < this.mapWidth)) &&
             ((-1 < iVar9 && (uVar4 = 0, iVar9 < this.mapHeight)))) {
            if (this.areaTiles == null) goto LAB_1807e83bb;
            uVar4 = FUN_180002f80(this.areaTiles,this.mapWidth * iVar9 + iVar7,
                                  DAT_181d7ca78);
          }
          if (lVar3 == null) {
        LAB_1807e83bb:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          FUN_18181e6b0(lVar3,uVar4,DAT_181d7c878);
        }
        return lVar3;
    }

    // Token : 0x6000FDF
    // RVA   : 0x7E92B0   Offset: 0x7E86B0   Length: 0x90
    public AreaTileData GetTile(int column, int row)
    {
        ulong uVar1;
        if (-1 < column) {
          if (((column < this.mapWidth) && (-1 < row)) &&
             (row < this.mapHeight)) {
            if (this.areaTiles != null) {
              uVar1 = FUN_180002f80(this.areaTiles,
                                    this.mapWidth * row + column,DAT_181d7ca78);
              return uVar1;
            }
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
        }
        return 0;
    }

    // Token : 0x6000FE0
    // RVA   : 0x7E78D0   Offset: 0x7E6CD0   Length: 0x175
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
        plVar1 = (int64 *)il2cpp_internal(DAT_181d89228);
        plVar4 = plVar1;
        MemoryStream.ctor(plVar1,1000,0);
        local_38 = 0;
        uStack_30 = 0;
        StreamingContext.ctor(&local_38,64,0);
        lVar2 = il2cpp_internal(DAT_181db1748);
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
            FUN_180002970(0,DAT_181d78db8,plVar1);
            return uVar3;
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
    }

    // Token : 0x6000FE1
    // RVA   : 0x7E9FE0   Offset: 0x7E93E0   Length: 0xED
    private static void /*cctor*/()
    {
        long lVar2;
        lVar2 = il2cpp_internal(DAT_181d93ce8);
        FUN_181330100(lVar2,DAT_181d8f0b0);
        if (lVar2 != null) {
          FUN_18182a6c0(lVar2,0,DAT_181d8f230);
          FUN_18182a6c0(lVar2,1,DAT_181d8f230);
          FUN_18182a6c0(lVar2,2,DAT_181d8f230);
          FUN_18182a6c0(lVar2,3,DAT_181d8f230);
          FUN_18182a6c0(lVar2,4,DAT_181d8f230);
          plVar1 = *(int64 **)(DAT_181dac7f0 + 184);
          *plVar1 = lVar2;
          il2cpp_internal(plVar1,lVar2);
          return;
        }
    }

}
