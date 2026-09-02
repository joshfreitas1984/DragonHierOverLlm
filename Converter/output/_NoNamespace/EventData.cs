// ============================================================
// Type  : EventData
// Token : 0x20001F5
// ============================================================

public class EventData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000DB5
    public int id;

    // Token: 0x4000DB6
    public string eventName;

    // Token: 0x4000DB7
    public string eventDescribe;

    // Token: 0x4000DB8
    public List<EventAvailableAreaType> eventAvailableAreaType;

    // Token: 0x4000DB9
    public string spriteName;

    // Token: 0x4000DBA
    public bool isAreaEvent;

    // Token: 0x4000DBB
    public int resourcePointID;

    // Token: 0x4000DBC
    public List<int> areaID;

    // Token: 0x4000DBD
    public List<int> areaMapTileID;

    // Token: 0x4000DBE
    public BigMapPos bigMapPos;

    // Token: 0x4000DBF
    public int nearAreaID;

    // Token: 0x4000DC0
    public int nearAreaDirection;

    // Token: 0x4000DC1
    public bool seen;

    // Token: 0x4000DC2
    public bool happened;

    // Token: 0x4000DC3
    public bool noticed;

    // Token: 0x4000DC4
    public bool hovered;

    // Token: 0x4000DC5
    public bool plotTargetEvent;

    // Token: 0x4000DC6
    public bool missionTargetEvent;

    // Token: 0x4000DC7
    public bool autoDestroy;

    // Token: 0x4000DC8
    public int leftTime;

    // Token: 0x4000DC9
    public float difficulty;

    // Token: 0x4000DCA
    public float difficultyRate;

    // Token: 0x4000DCB
    public int speTargetID;

    // Token: 0x4000DCC
    public PlotData plotData;

    // Token: 0x4000DCD
    public ItemListData eventItemList;

    // Token: 0x4000DCE
    public LeaderLimit leaderLimit;

    // Token: 0x4000DCF
    public string eventOutTimeCallFuc;

    // Token: 0x4000DD0
    public float seeRange;

    // Token: 0x4000DD1
    public int randomSeed;

    // Token: 0x4000DD2
    public bool inaccuracyPosText;

    // Token: 0x4000DD3
    public bool notImportant;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000FAA
    // RVA   : 0x936540   Offset: 0x934D40   Length: 0xF4
    public void /*ctor*/()
    {
        ulong uVar1;
        this.resourcePointID = 0xffffffff;
        uVar1 = il2cpp_internal(DAT_181d6f030);
        FUN_180f58a90(uVar1,DAT_181d678f8);
        this.areaID = uVar1;
        uVar1 = il2cpp_internal(DAT_181d6f030);
        FUN_180f58a90(uVar1,DAT_181d678f8);
        this.areaMapTileID = uVar1;
        this.nearAreaID = 0xffffffffffffffff;
        this.difficultyRate = 0x3f800000;
        this.speTargetID = 0xffffffff;
        ZhSegment.Initialize(this,0);
        this.bigMapPos = new c.DisplayClass9_0(0);
    }

    // Token : 0x6000FAB
    // RVA   : 0x2A5CA0   Offset: 0x2A44A0   Length: 0xC
    public void SetPlotData(PlotData _plotData)
    {
        void FUN_1802a5ca0(int64 this,uint64 _plotData)
        {
        this.plotData = _plotData;
    }

    // Token : 0x6000FAC
    // RVA   : 0x935F70   Offset: 0x934770   Length: 0x28
    public int GetEventRareLv()
    {
        int iVar1;
        iVar1 = Mathf.RoundToInt(this,0);
        return (int)((float)iVar1 * 0.5);
    }

    // Token : 0x6000FAD
    // RVA   : 0x9364B0   Offset: 0x934CB0   Length: 0x81
    public string Name()
    {
        ulong uVar1;
        int iVar2;
        uVar1 = this.eventName;
        iVar2 = Mathf.RoundToInt();
        GlobalData.GenerateRareLvColorText(uVar1,(int)((float)iVar2 * 0.5),0);
    }

    // Token : 0x6000FAE
    // RVA   : 0x935A10   Offset: 0x934210   Length: 0x55E
    public string GetDescribe(bool showDifficulty)
    {
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        var pStatics_ef00 = *(int64*)(DAT_181d4ef00 + 184);
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
              if (*pStatics_df90 == 0) throw; // [null/range check failed]
              lVar5 = this.areaID;
              lVar1 = *(int64 *)(*pStatics_df90 + 32);
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
                lVar5 = FUN_18046c0a0(0);
                if (lVar5 == null) throw; // [null/range check failed]
                lVar1 = this.areaID;
                lVar5 = *(int64 *)(lVar5 + 32);
                if (lVar1 == null) throw; // [null/range check failed]
                if (lVar1.Count == null) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                if (((lVar5 == null) ||
                    (lVar5 = WorldData.GetArea(lVar5,*(uint32 *)(lVar1._items + 32),
                                                0), lVar5 == null)) ||
                   (lVar5 = AreaData.GetForce(lVar5,0)) == null) throw; // [null/range check failed]
                uVar6 = lVar5.Count;
              }
            }
            if (lVar3 != null) {
              lVar3 = String.Replace(lVar3,uVar4,uVar6,0);
              uVar4 = "#EnemyForceName#";
              uVar6 = "";
              if (-1 < this.speTargetID) {
                if (((*pStatics_df90 == 0) ||
                    (lVar5 = *(int64 *)(*pStatics_df90 + 32)) == null) ||
                   (lVar5 = WorldData.GetForce(lVar5,this.speTargetID,0)) == null)
                throw; // [null/range check failed]
                uVar6 = lVar5.Count;
              }
              if (lVar3 != null) {
                lVar3 = String.Replace(lVar3,uVar4,uVar6,0);
                lVar5 = *(int64 *)(pStatics_ef00 + 0x400);
                iVar2 = Mathf.RoundToInt(pStatics_ef00,0);
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
                    lVar3 = *(int64 *)(pStatics_ef00 + 0x500);
                    iVar2 = Mathf.RoundToInt(DAT_181d4ef00,0);
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

    // Token : 0x6000FAF
    // RVA   : 0x935FA0   Offset: 0x9347A0   Length: 0x50C
    public string GetPosText()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        uint uVar1;
        ulong uVar2;
        bool cVar3;
        uint uVar4;
        long lVar5;
        long lVar6;
        ulong uVar7;
        int iVar8;
        if (this.resourcePointID < 0) {
          if (this.nearAreaID == -1) {
            lVar6 = this.areaID;
            if (lVar6 != null) {
              if (lVar6.Count == 1) {
                lVar6 = FUN_18046c0a0(0);
                if (lVar6 != null) {
                  lVar5 = this.areaID;
                  lVar6 = *(int64 *)(lVar6 + 32);
                  if (lVar5 != null) {
                    if (lVar5.Count == null) {
                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                    }
                    if ((lVar6 != null) &&
                       (lVar6 = WorldData.GetArea(lVar6,*(uint32 *)
                                                          (lVar5._items + 32),0),
                       lVar6 != null)) {
                      return lVar6.Count;
                    }
                  }
                }
              }
              else {
                lVar5 = FUN_18046c0a0(0);
                if ((lVar5 != null) && (*(int64 *)(lVar5 + 32) != 0)) {
                  uVar7 = *(uint64 *)(*(int64 *)(lVar5 + 32) + 24);
                  cVar3 = GlobalData.ListEqual(lVar6,uVar7,0);
                  if (cVar3) {
                    return "所有城市";
                  }
                  uVar7 = this.areaID;
                  lVar6 = FUN_18046c0a0(0);
                  if ((lVar6 != null) && (*(int64 *)(lVar6 + 32) != 0)) {
                    uVar2 = *(uint64 *)(*(int64 *)(lVar6 + 32) + 32);
                    cVar3 = GlobalData.ListEqual(uVar7,uVar2,0);
                    if (cVar3) {
                      return "所有村镇";
                    }
                    uVar7 = this.areaID;
                    lVar6 = FUN_18046c0a0(0);
                    if ((lVar6 != null) && (*(int64 *)(lVar6 + 32) != 0)) {
                      uVar2 = *(uint64 *)(*(int64 *)(lVar6 + 32) + 40);
                      cVar3 = GlobalData.ListEqual(uVar7,uVar2,0);
                      if (cVar3) {
                        return "所有门派";
                      }
                      lVar6 = this.areaID;
                      iVar8 = 0;
                      uVar7 = "";
                      if (lVar6 != null) {
                        while( true ) {
                          if (lVar6.Count <= iVar8) {
                            return uVar7;
                          }
                          lVar6 = FUN_18046c0a0(0);
                          if (lVar6 == null) break;
                          lVar6 = *(int64 *)(lVar6 + 32);
                          if (((this.areaID == null) ||
                              (uVar4 = FUN_1800d6750(this.areaID,iVar8,DAT_181d68270),
                              lVar6 == null)) || (lVar6 = WorldData.GetArea(lVar6,uVar4,0)) == null)
                          break;
                          uVar7 = String.Concat(uVar7,lVar6.Count,0);
                          iVar8 = iVar8 + 1;
                          lVar6 = this.areaID;
                          if (lVar6 == null) break;
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
            lVar6 = FUN_18046c0a0(0);
            if (((lVar6 != null) && (*(int64 *)(lVar6 + 32) != 0)) &&
               (lVar6 = WorldData.GetArea(*(int64 *)(lVar6 + 32),this.nearAreaID,0),
               lVar6 != null)) {
              uVar2 = lVar6.Count;
              lVar6 = *(int64 *)(*(int64 *)(DAT_181d4ef00 + 184) + 0x3c0);
              if (lVar6 != null) {
                uVar1 = this.nearAreaDirection;
                if (lVar6.Count <= uVar1) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                uVar7 = String.Format(uVar7,uVar2,
                                       *(uint64 *)
                                        (lVar6._items + 32 + (int64)(int)uVar1 * 8),0)
                ;
                return uVar7;
              }
            }
          }
        }
        else {
          if (((*pStatics != 0) &&
              (lVar6 = *(int64 *)(*pStatics + 32)) != null) &&
             (lVar6 = WorldData.GetResourcePoint(lVar6,this.resourcePointID,0)) != null) {
            return *(uint64 *)(lVar6 + 32);
          }
        }
    }

    // Token : 0x6000FB0
    // RVA   : 0x935890   Offset: 0x934090   Length: 0x175
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

}
