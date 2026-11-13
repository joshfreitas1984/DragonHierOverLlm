// ============================================================
// Type  : EventData
// Token : 0x20001FD
// ============================================================

public class EventData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000E59
    public int id;

    // Token: 0x4000E5A
    public string eventName;

    // Token: 0x4000E5B
    public string eventDescribe;

    // Token: 0x4000E5C
    public List<EventAvailableAreaType> eventAvailableAreaType;

    // Token: 0x4000E5D
    public string spriteName;

    // Token: 0x4000E5E
    public bool isAreaEvent;

    // Token: 0x4000E5F
    public int resourcePointID;

    // Token: 0x4000E60
    public List<int> areaID;

    // Token: 0x4000E61
    public List<int> areaMapTileID;

    // Token: 0x4000E62
    public BigMapPos bigMapPos;

    // Token: 0x4000E63
    public int nearAreaID;

    // Token: 0x4000E64
    public int nearAreaDirection;

    // Token: 0x4000E65
    public bool seen;

    // Token: 0x4000E66
    public bool happened;

    // Token: 0x4000E67
    public bool noticed;

    // Token: 0x4000E68
    public bool hovered;

    // Token: 0x4000E69
    public bool plotTargetEvent;

    // Token: 0x4000E6A
    public bool missionTargetEvent;

    // Token: 0x4000E6B
    public bool autoDestroy;

    // Token: 0x4000E6C
    public int leftTime;

    // Token: 0x4000E6D
    public float difficulty;

    // Token: 0x4000E6E
    public float difficultyRate;

    // Token: 0x4000E6F
    public int speTargetID;

    // Token: 0x4000E70
    public PlotData plotData;

    // Token: 0x4000E71
    public ItemListData eventItemList;

    // Token: 0x4000E72
    public LeaderLimit leaderLimit;

    // Token: 0x4000E73
    public string eventOutTimeCallFuc;

    // Token: 0x4000E74
    public float seeRange;

    // Token: 0x4000E75
    public int randomSeed;

    // Token: 0x4000E76
    public bool inaccuracyPosText;

    // Token: 0x4000E77
    public bool notImportant;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000FEB
    // RVA   : 0x68C8B0   Offset: 0x68B6B0   Length: 0xF4
    public void /*ctor*/()
    {
        ulong uVar1;
        this.resourcePointID = 0xffffffff;
        uVar1 = il2cpp_internal(DAT_181e73cb8);
        FUN_1810f3480(uVar1,DAT_181e71270);
        this.areaID = uVar1;
        uVar1 = il2cpp_internal(DAT_181e73cb8);
        FUN_1810f3480(uVar1,DAT_181e71270);
        this.areaMapTileID = uVar1;
        this.nearAreaID = 0xffffffffffffffff;
        this.difficultyRate = 0x3f800000;
        this.speTargetID = 0xffffffff;
        ZhSegment.Initialize(this,0);
        this.bigMapPos = new c.DisplayClass9_0(0);
    }

    // Token : 0x6000FEC
    // RVA   : 0x68C8A0   Offset: 0x68B6A0   Length: 0xC
    public void SetPlotData(PlotData _plotData)
    {
        void FUN_18068c8a0(int64 this,uint64 _plotData)
        {
        this.plotData = _plotData;
    }

    // Token : 0x6000FED
    // RVA   : 0x68C2B0   Offset: 0x68B0B0   Length: 0x28
    public int GetEventRareLv()
    {
        int iVar1;
        iVar1 = Mathf.RoundToInt(this,0);
        return (int)((float)iVar1 * 0.5);
    }

    // Token : 0x6000FEE
    // RVA   : 0x68C810   Offset: 0x68B610   Length: 0x81
    public string Name()
    {
        ulong uVar1;
        int iVar2;
        uVar1 = this.eventName;
        iVar2 = Mathf.RoundToInt();
        GlobalData.GenerateRareLvColorText(uVar1,(int)((float)iVar2 * 0.5),0);
    }

    // Token : 0x6000FEF
    // RVA   : 0x68BD30   Offset: 0x68AB30   Length: 0x576
    public string GetDescribe(bool showDifficulty)
    {
        var pStatics_38e8 = *(int64*)(DAT_181e538e8 + 184);
        long lVar1;
        int iVar2;
        long lVar3;
        ulong uVar4;
        long lVar5;
        ulong uVar6;
        uint uVar7;
        uVar4 = this.eventDescribe;
        lVar3 = GlobalData.ReplaceSpeString(uVar4,0,0);
        uVar4 = EventData.GetPosText(this,0);
        if (lVar3 != null) {
          lVar3 = String.Replace(lVar3,"#PosText#",uVar4,0);
          uVar4 = "#PosForceName#";
          if (this.areaID != null) {
            uVar6 = "";
            if (0 < this.areaID.Count) {
              if (GameController._instance == null) throw; // [null/range check failed]
              lVar5 = this.areaID;
              lVar1 = GameController._instance.worldData;
              if (lVar5 == null) throw; // [null/range check failed]
              if (lVar5.Count == null) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              if ((lVar1 == null) ||
                 (lVar5 = WorldData.GetArea(lVar1,*(uint32 *)(lVar5._items + 32),0),
                 lVar5 == null)) throw; // [null/range check failed]
              lVar5 = AreaData.GetForce(lVar5,0);
              uVar6 = "";
              if (lVar5 != null) {
                lVar5 = FUN_1802106e0(0);
                if (lVar5 == null) throw; // [null/range check failed]
                lVar1 = this.areaID;
                lVar5 = lVar5.villageAreaID;
                if (lVar1 == null) throw; // [null/range check failed]
                if (lVar1.Count == null) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                if ((lVar5 == null) ||
                   (lVar5 = WorldData.GetArea(lVar5,*(uint32 *)(lVar1._items + 32),0
                                              ), lVar5 == null)) throw; // [null/range check failed]
                lVar5 = AreaData.GetForce(lVar5,0);
                if (lVar5 == null) throw; // [null/range check failed]
                uVar6 = ForceData.GetForceName(lVar5,1,0);
              }
            }
            if (lVar3 != null) {
              lVar3 = String.Replace(lVar3,uVar4,uVar6,0);
              uVar4 = "#EnemyForceName#";
              uVar6 = "";
              if (-1 < this.speTargetID) {
                if ((GameController._instance == null) ||
                   (lVar5 = GameController._instance.worldData) == null)
                throw; // [null/range check failed]
                lVar5 = WorldData.GetForce(lVar5,this.speTargetID,0);
                if (lVar5 == null) throw; // [null/range check failed]
                uVar6 = ForceData.GetForceName(lVar5,1,0);
              }
              if (lVar3 != null) {
                lVar3 = String.Replace(lVar3,uVar4,uVar6,0);
                lVar5 = *(int64 *)(pStatics_38e8 + 0x410);
                iVar2 = Mathf.RoundToInt(pStatics_38e8,0);
                uVar7 = (uint32)((float)iVar2 * 0.5);
                if (lVar5 != null) {
                  if (lVar5.Count <= uVar7) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  uVar4 = lVar5._items[uVar7];
                  iVar2 = Mathf.RoundToInt((int64)(int)uVar7,0);
                  uVar4 = GlobalData.GenerateRareLvColorText(uVar4,(int)((float)iVar2 * 0.5),0);
                  if (lVar3 != null) {
                    lVar5 = String.Replace(lVar3,"#DifficultyRateText#",uVar4,0);
                    lVar3 = *(int64 *)(pStatics_38e8 + 0x528);
                    iVar2 = Mathf.RoundToInt(DAT_181e538e8,0);
                    uVar7 = (uint32)((float)iVar2 * 0.5);
                    if (lVar3 != null) {
                      if (*(uint32 *)(lVar3 + 24) <= uVar7) {
                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                      }
                      uVar4 = *(uint64 *)
                               (*(int64 *)(lVar3 + 16) + 32 + (int64)(int)uVar7 * 8);
                      iVar2 = Mathf.RoundToInt((int64)(int)uVar7,0);
                      uVar4 = GlobalData.GenerateRareLvColorText(uVar4,(int)((float)iVar2 * 0.5),0);
                      if (lVar5 != null) {
                        uVar4 = String.Replace(lVar5,"#DifficultyItemText#",uVar4,0);
                        if (showDifficulty) {
                          uVar6 = GlobalData.GetDifficultyStarString();
                          uVar4 = String.Concat(uVar4,"\n",uVar6,0);
                        }
                        return uVar4;
                      }
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6000FF0
    // RVA   : 0x68C2E0   Offset: 0x68B0E0   Length: 0x527
    public string GetPosText()
    {
        uint uVar1;
        bool cVar2;
        uint uVar3;
        long lVar4;
        long lVar5;
        ulong uVar6;
        ulong uVar7;
        int iVar8;
        if (this.resourcePointID < 0) {
          if (this.nearAreaID == -1) {
            lVar5 = this.areaID;
            if (lVar5 != null) {
              if (lVar5.Count == 1) {
                lVar5 = FUN_1802106e0(0);
                if (lVar5 != null) {
                  lVar4 = this.areaID;
                  lVar5 = lVar5.villageAreaID;
                  if (lVar4 != null) {
                    if (lVar4.Count == null) {
                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                    }
                    if ((lVar5 != null) &&
                       (lVar5 = WorldData.GetArea(lVar5,*(uint32 *)
                                                          (lVar4._items + 32),0),
                       lVar5 != null)) {
                      uVar7 = AreaData.GetAreaName(lVar5,0);
                      return uVar7;
                    }
                  }
                }
              }
              else {
                lVar4 = FUN_1802106e0(0);
                if ((lVar4 != null) && (*(int64 *)(lVar4 + 32) != 0)) {
                  uVar7 = *(uint64 *)(*(int64 *)(lVar4 + 32) + 24);
                  cVar2 = GlobalData.ListEqual(lVar5,uVar7,0);
                  if (cVar2) {
                    return "所有城市";
                  }
                  uVar7 = this.areaID;
                  lVar5 = FUN_1802106e0(0);
                  if ((lVar5 != null) && (lVar5.villageAreaID != null)) {
                    uVar6 = *(uint64 *)(lVar5.villageAreaID + 32);
                    cVar2 = GlobalData.ListEqual(uVar7,uVar6,0);
                    if (cVar2) {
                      return "所有村镇";
                    }
                    uVar7 = this.areaID;
                    lVar5 = FUN_1802106e0(0);
                    if ((lVar5 != null) && (lVar5.villageAreaID != null)) {
                      uVar6 = *(uint64 *)(lVar5.villageAreaID + 40);
                      cVar2 = GlobalData.ListEqual(uVar7,uVar6,0);
                      if (cVar2) {
                        return "所有门派";
                      }
                      lVar5 = this.areaID;
                      iVar8 = 0;
                      uVar7 = "";
                      if (lVar5 != null) {
                        while( true ) {
                          if (lVar5.Count <= iVar8) {
                            return uVar7;
                          }
                          lVar5 = FUN_1802106e0(0);
                          if (lVar5 == null) break;
                          lVar5 = lVar5.villageAreaID;
                          if (((this.areaID == null) ||
                              (uVar3 = FUN_180002480(this.areaID,iVar8,DAT_181e71bf0),
                              lVar5 == null)) || (lVar5 = WorldData.GetArea(lVar5,uVar3,0)) == null)
                          break;
                          uVar6 = AreaData.GetAreaName(lVar5,0);
                          uVar7 = String.Concat(uVar7,uVar6,0);
                          iVar8 = iVar8 + 1;
                          lVar5 = this.areaID;
                          if (lVar5 == null) break;
                        }
                      }
                    }
                  }
                }
              }
            }
          }
          else {
            uVar7 = "{0}{1}方";
            if (this.inaccuracyPosText) {
              uVar7 = "{0}周边";
            }
            lVar5 = FUN_1802106e0(0);
            if (((lVar5 != null) && (lVar5.villageAreaID != null)) &&
               (lVar5 = WorldData.GetArea(lVar5.villageAreaID,this.nearAreaID,0),
               lVar5 != null)) {
              uVar6 = AreaData.GetAreaName(lVar5,0);
              lVar5 = *(int64 *)(*(int64 *)(DAT_181e538e8 + 184) + 0x3d0);
              if (lVar5 != null) {
                uVar1 = this.nearAreaDirection;
                if (lVar5.Count <= uVar1) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                uVar7 = String.Format(uVar7,uVar6,
                                       *(uint64 *)
                                        (lVar5._items + 32 + (int64)(int)uVar1 * 8),0)
                ;
                return uVar7;
              }
            }
          }
        }
        else {
          if (((GameController._instance != null) &&
              (lVar5 = GameController._instance.worldData) != null) &&
             (lVar5 = WorldData.GetResourcePoint(lVar5,this.resourcePointID,0)) != null) {
            uVar7 = ResourcePointData.GetResourcePointFullName(lVar5,0);
            return uVar7;
          }
        }
    }

    // Token : 0x6000FF1
    // RVA   : 0x68B8A0   Offset: 0x68A6A0   Length: 0x480
    public virtual object Clone()
    {
        long lVar1;
        long lVar2;
        ulong uVar3;
        lVar2 = il2cpp_internal(DAT_181ea4ce0);
        *(uint32 *)(lVar2 + 60) = 0xffffffff;
        uVar3 = il2cpp_internal(DAT_181e73cb8);
        FUN_1810f3480(uVar3,DAT_181e71270);
        *(uint64 *)(lVar2 + 64) = uVar3;
        uVar3 = il2cpp_internal(DAT_181e73cb8);
        FUN_1810f3480(uVar3,DAT_181e71270);
        *(uint64 *)(lVar2 + 72) = uVar3;
        *(uint64 *)(lVar2 + 88) = 0xffffffffffffffff;
        *(uint32 *)(lVar2 + 112) = 0x3f800000;
        *(uint32 *)(lVar2 + 116) = 0xffffffff;
        ZhSegment.Initialize(lVar2,0);
        uVar3 = new c.DisplayClass9_0(0);
        *(uint64 *)(lVar2 + 80) = uVar3;
        *(uint32 *)(lVar2 + 16) = this.id;
        *(uint64 *)(lVar2 + 24) = this.eventName;
        *(uint64 *)(lVar2 + 32) = this.eventDescribe;
        lVar1 = this.eventAvailableAreaType;
        plVar6 = (int64 *)0;
        plVar5 = plVar6;
        if (lVar1 != null) {
          plVar5 = (int64 *)il2cpp_internal(DAT_181e72538);
          FUN_181779b60(plVar5,lVar1,DAT_181e67b78);
        }
        *(uint64 *)(lVar2 + 40) = plVar5;
        *(uint64 *)(lVar2 + 48) = this.spriteName;
        *(uint8 *)(lVar2 + 56) = this.isAreaEvent;
        *(uint32 *)(lVar2 + 60) = this.resourcePointID;
        lVar1 = this.areaID;
        plVar5 = plVar6;
        if (lVar1 != null) {
          plVar5 = (int64 *)il2cpp_internal(DAT_181e73cb8);
          FUN_18177a7d0(plVar5,lVar1,DAT_181e712f0);
        }
        *(int64 **)(lVar2 + 64) = plVar5;
        lVar1 = this.areaMapTileID;
        plVar5 = plVar6;
        if (lVar1 != null) {
          plVar5 = (int64 *)il2cpp_internal(DAT_181e73cb8);
          FUN_18177a7d0(plVar5,lVar1,DAT_181e712f0);
        }
        *(int64 **)(lVar2 + 72) = plVar5;
        plVar5 = plVar6;
        if (this.bigMapPos != null) {
          plVar5 = (int64 *)il2cpp_internal(DAT_181e90f60);
          c__DisplayClass9_0.ctor(plVar5,0);
          if ((this.bigMapPos != null) && (plVar5 != (int64 *)0)) {
            *(uint32 *)(plVar5 + 2) = this.bigMapPos.x;
            if (this.bigMapPos != null) {
              *(uint32 *)((int64)plVar5 + 20) =
                   this.bigMapPos.y;
              goto LAB_18068bb71;
            }
          }
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        LAB_18068bb71:
        *(int64 **)(lVar2 + 80) = plVar5;
        *(uint32 *)(lVar2 + 88) = this.nearAreaID;
        *(uint32 *)(lVar2 + 92) = this.nearAreaDirection;
        *(uint8 *)(lVar2 + 96) = this.seen;
        *(uint8 *)(lVar2 + 97) = this.happened;
        *(uint8 *)(lVar2 + 98) = this.noticed;
        *(uint8 *)(lVar2 + 99) = *(uint8 *)(this + 99);
        *(uint8 *)(lVar2 + 100) = *(uint8 *)(this + 100);
        *(uint8 *)(lVar2 + 101) = this.missionTargetEvent;
        *(uint8 *)(lVar2 + 102) = this.autoDestroy;
        *(uint32 *)(lVar2 + 104) = this.leftTime;
        *(uint32 *)(lVar2 + 108) = this.difficulty;
        *(uint32 *)(lVar2 + 112) = this.difficultyRate;
        *(uint32 *)(lVar2 + 116) = this.speTargetID;
        plVar5 = plVar6;
        if ((this.plotData != null) &&
           (plVar4 = (int64 *)PlotData.Clone(this.plotData,0),
           plVar4 != (int64 *)0)) {
        }
        *(int64 **)(lVar2 + 120) = plVar5;
        if ((this.eventItemList != null) &&
           (plVar5 = (int64 *)ItemListData.Clone(this.eventItemList,0),
           plVar5 != (int64 *)0)) {
        }
        *(uint64 *)(lVar2 + 128) = plVar6;
        *(uint32 *)(lVar2 + 136) = this.leaderLimit;
        *(uint64 *)(lVar2 + 144) = this.eventOutTimeCallFuc;
        *(uint32 *)(lVar2 + 152) = this.seeRange;
        *(uint32 *)(lVar2 + 156) = this.randomSeed;
        *(uint8 *)(lVar2 + 160) = this.inaccuracyPosText;
        *(uint8 *)(lVar2 + 161) = this.notImportant;
        return lVar2;
    }

}
