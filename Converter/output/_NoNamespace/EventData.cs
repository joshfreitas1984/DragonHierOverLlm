// ============================================================
// Type  : EventData
// Token : 0x20001FB
// ============================================================

public class EventData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000E45
    public int id;

    // Token: 0x4000E46
    public string eventName;

    // Token: 0x4000E47
    public string eventDescribe;

    // Token: 0x4000E48
    public List<EventAvailableAreaType> eventAvailableAreaType;

    // Token: 0x4000E49
    public string spriteName;

    // Token: 0x4000E4A
    public bool isAreaEvent;

    // Token: 0x4000E4B
    public int resourcePointID;

    // Token: 0x4000E4C
    public List<int> areaID;

    // Token: 0x4000E4D
    public List<int> areaMapTileID;

    // Token: 0x4000E4E
    public BigMapPos bigMapPos;

    // Token: 0x4000E4F
    public int nearAreaID;

    // Token: 0x4000E50
    public int nearAreaDirection;

    // Token: 0x4000E51
    public bool seen;

    // Token: 0x4000E52
    public bool happened;

    // Token: 0x4000E53
    public bool noticed;

    // Token: 0x4000E54
    public bool hovered;

    // Token: 0x4000E55
    public bool plotTargetEvent;

    // Token: 0x4000E56
    public bool missionTargetEvent;

    // Token: 0x4000E57
    public bool autoDestroy;

    // Token: 0x4000E58
    public int leftTime;

    // Token: 0x4000E59
    public float difficulty;

    // Token: 0x4000E5A
    public float difficultyRate;

    // Token: 0x4000E5B
    public int speTargetID;

    // Token: 0x4000E5C
    public PlotData plotData;

    // Token: 0x4000E5D
    public ItemListData eventItemList;

    // Token: 0x4000E5E
    public LeaderLimit leaderLimit;

    // Token: 0x4000E5F
    public string eventOutTimeCallFuc;

    // Token: 0x4000E60
    public float seeRange;

    // Token: 0x4000E61
    public int randomSeed;

    // Token: 0x4000E62
    public bool inaccuracyPosText;

    // Token: 0x4000E63
    public bool notImportant;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000FE2
    // RVA   : 0x946000   Offset: 0x945400   Length: 0xF4
    public void /*ctor*/()
    {
        ulong uVar1;
        this.resourcePointID = 0xffffffff;
        uVar1 = il2cpp_internal(DAT_181d93cd0);
        FUN_18132faf0(uVar1,DAT_181d8f098);
        this.areaID = uVar1;
        uVar1 = il2cpp_internal(DAT_181d93cd0);
        FUN_18132faf0(uVar1,DAT_181d8f098);
        this.areaMapTileID = uVar1;
        this.nearAreaID = 0xffffffffffffffff;
        this.difficultyRate = 0x3f800000;
        this.speTargetID = 0xffffffff;
        ZhSegment.Initialize(this,0);
        this.bigMapPos = new c.DisplayClass9_0(0);
    }

    // Token : 0x6000FE3
    // RVA   : 0x2A5CA0   Offset: 0x2A50A0   Length: 0xC
    public void SetPlotData(PlotData _plotData)
    {
        void FUN_1802a5ca0(int64 this,uint64 _plotData)
        {
        this.plotData = _plotData;
    }

    // Token : 0x6000FE4
    // RVA   : 0x945A10   Offset: 0x944E10   Length: 0x28
    public int GetEventRareLv()
    {
        int iVar1;
        iVar1 = Mathf.RoundToInt(this,0);
        return (int)((float)iVar1 * 0.5);
    }

    // Token : 0x6000FE5
    // RVA   : 0x945F70   Offset: 0x945370   Length: 0x81
    public string Name()
    {
        ulong uVar1;
        int iVar2;
        uVar1 = this.eventName;
        iVar2 = Mathf.RoundToInt();
        GlobalData.GenerateRareLvColorText(uVar1,(int)((float)iVar2 * 0.5),0);
    }

    // Token : 0x6000FE6
    // RVA   : 0x945490   Offset: 0x944890   Length: 0x576
    public string GetDescribe(bool showDifficulty)
    {
        var pStatics_2cc8 = *(int64*)(DAT_181d72cc8 + 184);
        var pStatics_3d40 = *(int64*)(DAT_181d73d40 + 184);
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
              if (*pStatics_2cc8 == 0) throw; // [null/range check failed]
              lVar5 = this.areaID;
              lVar1 = *(int64 *)(*pStatics_2cc8 + 32);
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
                if ((*pStatics_2cc8 == 0) ||
                   (lVar5 = *(int64 *)(*pStatics_2cc8 + 32)) == null)
                throw; // [null/range check failed]
                lVar5 = WorldData.GetForce(lVar5,this.speTargetID,0);
                if (lVar5 == null) throw; // [null/range check failed]
                uVar6 = ForceData.GetForceName(lVar5,1,0);
              }
              if (lVar3 != null) {
                lVar3 = String.Replace(lVar3,uVar4,uVar6,0);
                lVar5 = *(int64 *)(pStatics_3d40 + 0x408);
                iVar2 = Mathf.RoundToInt(pStatics_3d40,0);
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
                    lVar3 = *(int64 *)(pStatics_3d40 + 0x508);
                    iVar2 = Mathf.RoundToInt(DAT_181d73d40,0);
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

    // Token : 0x6000FE7
    // RVA   : 0x945A40   Offset: 0x944E40   Length: 0x527
    public string GetPosText()
    {
        var pStatics = *(int64*)(DAT_181d72cc8 + 184);
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
                lVar5 = FUN_18046c0a0(0);
                if (lVar5 != null) {
                  lVar4 = this.areaID;
                  lVar5 = *(int64 *)(lVar5 + 32);
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
                lVar4 = FUN_18046c0a0(0);
                if ((lVar4 != null) && (*(int64 *)(lVar4 + 32) != 0)) {
                  uVar7 = *(uint64 *)(*(int64 *)(lVar4 + 32) + 24);
                  cVar2 = GlobalData.ListEqual(lVar5,uVar7,0);
                  if (cVar2) {
                    return "所有城市";
                  }
                  uVar7 = this.areaID;
                  lVar5 = FUN_18046c0a0(0);
                  if ((lVar5 != null) && (*(int64 *)(lVar5 + 32) != 0)) {
                    uVar6 = *(uint64 *)(*(int64 *)(lVar5 + 32) + 32);
                    cVar2 = GlobalData.ListEqual(uVar7,uVar6,0);
                    if (cVar2) {
                      return "所有村镇";
                    }
                    uVar7 = this.areaID;
                    lVar5 = FUN_18046c0a0(0);
                    if ((lVar5 != null) && (*(int64 *)(lVar5 + 32) != 0)) {
                      uVar6 = *(uint64 *)(*(int64 *)(lVar5 + 32) + 40);
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
                          lVar5 = FUN_18046c0a0(0);
                          if (lVar5 == null) break;
                          lVar5 = *(int64 *)(lVar5 + 32);
                          if (((this.areaID == null) ||
                              (uVar3 = FUN_1800d6760(this.areaID,iVar8,DAT_181d8fa18),
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
            lVar5 = FUN_18046c0a0(0);
            if (((lVar5 != null) && (*(int64 *)(lVar5 + 32) != 0)) &&
               (lVar5 = WorldData.GetArea(*(int64 *)(lVar5 + 32),this.nearAreaID,0),
               lVar5 != null)) {
              uVar6 = AreaData.GetAreaName(lVar5,0);
              lVar5 = *(int64 *)(*(int64 *)(DAT_181d73d40 + 184) + 0x3c8);
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
          if (((*pStatics != 0) &&
              (lVar5 = *(int64 *)(*pStatics + 32)) != null) &&
             (lVar5 = WorldData.GetResourcePoint(lVar5,this.resourcePointID,0)) != null) {
            uVar7 = ResourcePointData.GetResourcePointFullName(lVar5,0);
            return uVar7;
          }
        }
    }

    // Token : 0x6000FE8
    // RVA   : 0x945310   Offset: 0x944710   Length: 0x175
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
