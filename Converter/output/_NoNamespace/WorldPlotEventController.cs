// ============================================================
// Type  : WorldPlotEventController
// Token : 0x20003B9
// ============================================================

public class WorldPlotEventController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001E21
    public List<WorldPlotEventData> WorldPlotEventDataBase;

    // Token: 0x4001E22
    private static WorldPlotEventController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60023C2
    // RVA   : 0x9D59D0   Offset: 0x9D4DD0   Length: 0x36
    public static WorldPlotEventController get_Instance()
    {
        return **(uint64 **)(DAT_181db5f80 + 184);
    }

    // Token : 0x60023C3
    // RVA   : 0x9D2F70   Offset: 0x9D2370   Length: 0xD7
    private void Awake()
    {
        bool cVar2;
        ulong uVar3;
        uVar3 = **(uint64 **)(DAT_181db5f80 + 184);
        cVar2 = Object.op_Equality(uVar3,0,0);
        if (!cVar2) {
          uVar3 = Component.get_gameObject(this,0);
          Object.Destroy(uVar3,0);
          return;
        }
        puVar1 = *(uint64 **)(DAT_181db5f80 + 184);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x60023C4
    // RVA   : 0x9D5110   Offset: 0x9D4510   Length: 0x8BE
    public void StartNewWorldPlotEvent(WorldPlotEventStartData targetWorldPlotEventStartData)
    {
        bool cVar2;
        long lVar3;
        long lVar4;
        uint uVar5;
        int iVar6;
        long lVar7;
        long lVar8;
        ulong uVar10;
        long lVar11;
        long lVar12;
        ulong uVar13;
        uint uVar14;
        ulong uVar15;
        long lVar16;
        float fVar17;
        if (((GameController._instance != null) &&
            (lVar7 = GameController._instance.worldData) != null) &&
           (lVar7 = lVar7.worldPlotEventStartData) != null) {
          FUN_18181e0a0(lVar7,targetWorldPlotEventStartData,DAT_181dace08);
          if ((GameController._instance != null) &&
             (GameController.ChangePlotTargetNumCount(GameController._instance,targetWorldPlotEventStartData,1,0),
             targetWorldPlotEventStartData != null)) {
            if ((*(int *)(targetWorldPlotEventStartData + 32) - 1U & 0xfffffff6) != 0) {
              return;
            }
            if (*(int *)(targetWorldPlotEventStartData + 32) == 9) {
              return;
            }
            lVar7 = new EventData(0);
            if (lVar7 != null) {
              lVar7.cityAreaID = *(uint64 *)(targetWorldPlotEventStartData + 16);
              fVar17 = *(float *)(targetWorldPlotEventStartData + 24);
              if (fVar17 == -1.0) {
                if (GameController._instance == null) throw; // [null/range check failed]
                fVar17 = (float)GameController.GetTimeDifficulty(GameController._instance,0)
                ;
              }
              *(float *)(lVar7 + 108) = fVar17;
              plVar1 = (int64 *)(targetWorldPlotEventStartData + 56);
              lVar7.AreaMapRandomEventDatas = *(uint32 *)(targetWorldPlotEventStartData + 48);
              cVar2 = *(char *)(targetWorldPlotEventStartData + 64);
              *(uint8 *)(lVar7 + 100) = 1;
              *(bool *)(lVar7 + 102) = !cVar2;
              *(uint8 *)(lVar7 + 161) = *(uint8 *)(targetWorldPlotEventStartData + 80);
              *plVar1 = lVar7;
              il2cpp_internal(plVar1,lVar7);
              lVar7 = *plVar1;
              lVar8 = *(int64 *)(*(int64 *)(DAT_181d72d50 + 184) + 32);
              if ((((lVar8 != null) && (lVar8 = *(int64 *)(lVar8 + 0x178)) != null) &&
                  (lVar8 = FUN_1817d9e10(lVar8,*(uint32 *)(targetWorldPlotEventStartData + 28),DAT_181dbcf80)) != null
                  ) && (plVar9 = (int64 *)PlotData.Clone(lVar8,0), lVar7 != null)) {
                uVar13 = 0;
                lVar7.WorldEventDatasSaveRecord = plVar9;
                iVar6 = *(int *)(targetWorldPlotEventStartData + 32);
                if (iVar6 == 1) {
                  lVar7 = *(int64 *)(targetWorldPlotEventStartData + 40);
                  lVar8 = FUN_1800d60b0(DAT_181da1040,1);
                  if (lVar8 != null) {
                    if (*(int *)(lVar8 + 24) == 0) {
                      uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar10,0);
                    }
                    *(uint16 *)(lVar8 + 32) = 58;
                    if (lVar7 != null) {
                      lVar7 = String.Split(lVar7,lVar8,0);
                      lVar8 = *plVar1;
                      lVar11 = GameController._instance;
                      if ((GameController._instance != null) &&
                         (lVar12 = GameController._instance.worldData, lVar7 != null
                         )) {
                        if (lVar7.cityAreaID == null) {
                          uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1800d65f0(uVar10,0);
                        }
                        uVar5 = Int32.Parse(lVar7.villageAreaID,0);
                        if (lVar12 != null) {
                          uVar10 = WorldData.GetArea(lVar12,uVar5,0);
                          if ((int)lVar7.cityAreaID < 2) {
                            uVar5 = 0xffffffff;
                          }
                          else {
                            if (lVar7.cityAreaID < 2) {
                              uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                              FUN_1800d65f0(uVar10,0);
                            }
                            uVar5 = Int32.Parse(lVar7.forceAreaID,0);
                          }
                          if (lVar11 != null) {
                            GameController.CreateBigMapRandomEvent
                                      (lVar11,lVar8,uVar10,uVar5,0x3e4ccccd,0);
                            return;
                          }
                        }
                      }
                    }
                  }
                }
                else if (iVar6 == 2) {
                  lVar8 = FUN_18046c0a0(0);
                  lVar7 = *plVar1;
                  lVar11 = il2cpp_internal(DAT_181d93cd0);
                  FUN_18132faf0(lVar11,DAT_181d8f098);
                  uVar5 = Int32.Parse(*(uint64 *)(targetWorldPlotEventStartData + 40),0);
                  if ((lVar11 != null) && (FUN_18182a0b0(lVar11,uVar5,DAT_181d8f218), lVar8 != null)) {
                    GameController.CreateAreaMapRandomEvent(lVar8,lVar7,lVar11,0);
                    return;
                  }
                }
                else {
                  if (iVar6 != 10) {
                    return;
                  }
                  if (*plVar1 != 0) {
                    *(uint8 *)(*plVar1 + 96) = 1;
                    lVar8 = FUN_18046c0a0(0);
                    lVar7 = *plVar1;
                    lVar11 = FUN_18046c0a0(0);
                    if (lVar11 != null) {
                      lVar11 = lVar11.worldData;
                      iVar6 = Int32.Parse(*(uint64 *)(targetWorldPlotEventStartData + 40),0);
                      if (lVar11 != null) {
                        if (*(int64 *)(lVar11 + 0x298) == 0) {
                          uVar10 = il2cpp_internal(DAT_181d814e8);
                          FUN_1808b1370(uVar10,DAT_181dbd778);
                          *(uint64 *)(lVar11 + 0x298) = uVar10;
                          lVar12 = lVar11.enterAreaEnemyForceAttackHero;
                          if (lVar12 != null) {
                            lVar16 = 32;
                            uVar15 = uVar13;
                            do {
                              uVar14 = (uint32)uVar15;
                              if (lVar12.cityAreaID <= (int)uVar14) goto LAB_1809d5954;
                              lVar3 = *(int64 *)(lVar11 + 0x298);
                              if (lVar12 == null) break;
                              if (lVar12.cityAreaID <= uVar14) {
                                ThrowHelper.ThrowArgumentOutOfRangeException(0);
                              }
                              lVar12 = *(int64 *)(lVar16 + lVar12.chapter);
                              if (lVar12 == null) break;
                              lVar4 = lVar11.enterAreaEnemyForceAttackHero;
                              uVar5 = lVar12.chapter;
                              if (lVar4 == null) break;
                              if (*(uint32 *)(lVar4 + 24) <= uVar14) {
                                ThrowHelper.ThrowArgumentOutOfRangeException(0);
                              }
                              if (lVar3 == null) break;
                              FUN_1808ab370(lVar3,uVar5,
                                            *(uint64 *)(*(int64 *)(lVar4 + 16) + lVar16));
                              lVar12 = lVar11.enterAreaEnemyForceAttackHero;
                              uVar15 = (uint64)(uVar14 + 1);
                              lVar16 = lVar16 + 8;
                            } while (lVar12 != null);
                          }
                        }
                        else {
        LAB_1809d5954:
                          if (-1 < iVar6) {
                            if (*(int64 *)(lVar11 + 0x298) == 0) throw; // [null/range check failed]
                            uVar13 = FUN_1817d9e10(*(int64 *)(lVar11 + 0x298),iVar6,DAT_181dbd888);
                          }
                          if (lVar8 != null) {
                            GameController.CreateBigMapRandomEvent(lVar8,lVar7,uVar13,0);
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

    // Token : 0x60023C5
    // RVA   : 0x9D4310   Offset: 0x9D3710   Length: 0x31D
    public void RemoveWorldPlotEvent(string plotEventName)
    {
        int iVar1;
        bool cVar2;
        long lVar3;
        long lVar4;
        ulong uVar5;
        if (((GameController._instance != null) &&
            (lVar3 = GameController._instance.worldData) != null) &&
           (lVar3 = lVar3.worldPlotEventStartData) != null) {
          iVar1 = lVar3.cityAreaID;
          while( true ) {
            while( true ) {
              do {
                iVar1 = iVar1 + -1;
                if (iVar1 < 0) {
                  return;
                }
                lVar3 = FUN_18046c0a0(0);
                if (((lVar3 == null) || (lVar3.villageAreaID == null)) ||
                   ((lVar3 = *(int64 *)(lVar3.villageAreaID + 240), lVar3 == null ||
                    (lVar3 = FUN_180002f80(lVar3,iVar1,DAT_181dacf88)) == null))) throw; // [null/range check failed]
                cVar2 = FUN_18171e540(lVar3.chapter,plotEventName,0);
              } while (!cVar2);
              lVar3 = FUN_18046c0a0(0);
              if ((((lVar3 == null) || (lVar3.villageAreaID == null)) ||
                  (lVar3 = *(int64 *)(lVar3.villageAreaID + 240)) == null) ||
                 (lVar3 = FUN_180002f80(lVar3,iVar1,DAT_181dacf88)) == null) throw; // [null/range check failed]
              if (lVar3.Inns == null) break;
              lVar3 = FUN_18046c0a0(0);
              lVar4 = FUN_18046c0a0(0);
              if (((lVar4 == null) || (*(int64 *)(lVar4 + 32) == 0)) ||
                 ((lVar4 = *(int64 *)(*(int64 *)(lVar4 + 32) + 240), lVar4 == null ||
                  ((lVar4 = FUN_180002f80(lVar4,iVar1,DAT_181dacf88), lVar4 == null || (lVar3 == null))))))
              throw; // [null/range check failed]
              GameController.RemoveEvent(lVar3,*(uint64 *)(lVar4 + 56),0);
            }
            lVar3 = FUN_18046c0a0(0);
            lVar4 = FUN_18046c0a0(0);
            if ((((lVar4 == null) || (*(int64 *)(lVar4 + 32) == 0)) ||
                (lVar4 = *(int64 *)(*(int64 *)(lVar4 + 32) + 240)) == null) ||
               (uVar5 = FUN_180002f80(lVar4,iVar1,DAT_181dacf88), lVar3 == null)) break;
            GameController.ChangePlotTargetNumCount(lVar3,uVar5,0,0);
            lVar3 = FUN_18046c0a0(0);
            if (((lVar3 == null) || (lVar3.villageAreaID == null)) ||
               (lVar3 = *(int64 *)(lVar3.villageAreaID + 240)) == null) break;
            FUN_181823590(lVar3,iVar1,DAT_181dace88);
          }
        }
    }

    // Token : 0x60023C6
    // RVA   : 0x9D3A70   Offset: 0x9D2E70   Length: 0x898
    public void CheckWorldPlotEventDataBase()
    {
        uint uVar1;
        bool cVar2;
        int iVar3;
        uint uVar4;
        long lVar5;
        long lVar6;
        ulong uVar8;
        uint uVar9;
        long lVar10;
        lVar5 = this.WorldPlotEventDataBase;
        uVar9 = 0;
        if (lVar5 != null) {
          lVar10 = 0;
          do {
            if (lVar5.Count <= (int)uVar9) {
              return;
            }
            if (lVar5 == null) break;
            if (lVar5.Count <= uVar9) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar5 = *(int64 *)(lVar5._items + 32 + lVar10 * 8);
            if (lVar5 == null) break;
            if (lVar5.Count == 2) {
        LAB_1809d3bb9:
              lVar5 = FUN_18046c0a0(0);
              if ((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) break;
              lVar5 = *(int64 *)(*(int64 *)(lVar5 + 32) + 168);
              if ((this.WorldPlotEventDataBase == null) ||
                 ((lVar6 = FUN_180002f80(this.WorldPlotEventDataBase,uVar9,DAT_181dacc88), lVar6 == null ||
                  (lVar5 == null)))) break;
              iVar3 = TimeData.DeltaDay(lVar5,*(uint64 *)(lVar6 + 56),0);
              if (-1 < iVar3) {
                if (((this.WorldPlotEventDataBase == null) ||
                    (lVar5 = FUN_180002f80(this.WorldPlotEventDataBase,uVar9,DAT_181dacc88)) == null
                    ) || (*(int64 *)(lVar5 + 80) == 0)) break;
                if (*(int *)(*(int64 *)(lVar5 + 80) + 16) != 0) {
                  lVar5 = FUN_18046c0a0(0);
                  if ((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) break;
                  lVar5 = *(int64 *)(*(int64 *)(lVar5 + 32) + 168);
                  if ((this.WorldPlotEventDataBase == null) ||
                     ((lVar6 = FUN_180002f80(this.WorldPlotEventDataBase,uVar9,DAT_181dacc88),
                      lVar6 == null || (lVar5 == null)))) break;
                  iVar3 = TimeData.DeltaDay(lVar5,*(uint64 *)(lVar6 + 80),0);
                  if (0 < iVar3) goto LAB_1809d42bd;
                }
                if ((this.WorldPlotEventDataBase == null) ||
                   (lVar5 = FUN_180002f80(this.WorldPlotEventDataBase,uVar9,DAT_181dacc88)) == null)
                break;
                if (*(int *)(lVar5 + 64) != 0) {
                  if ((((this.WorldPlotEventDataBase == null) ||
                       (lVar5 = FUN_180002f80(this.WorldPlotEventDataBase,uVar9,DAT_181dacc88),
                       lVar5 == null)) || (*(int64 *)(lVar5 + 56) == 0)) ||
                     (plVar7 = (int64 *)TimeData.Clone(*(int64 *)(lVar5 + 56),0),
                     plVar7 == (int64 *)0)) break;
                  lVar5 = plVar7[3];
                  lVar6 = FUN_18046c0a0(0);
                  if (((lVar6 == null) || (*(int64 *)(lVar6 + 32) == 0)) ||
                     (lVar6 = *(int64 *)(*(int64 *)(lVar6 + 32) + 168)) == null) break;
                  uVar4 = TimeData.DeltaDay(lVar6,plVar7,0);
                  if ((this.WorldPlotEventDataBase == null) ||
                     (lVar6 = FUN_180002f80(this.WorldPlotEventDataBase,uVar9,DAT_181dacc88), lVar6 == null
                     )) break;
                  uVar4 = Mathf.Clamp(uVar4,0,*(uint32 *)(lVar6 + 64),0);
                  if ((this.WorldPlotEventDataBase == null) ||
                     (lVar6 = FUN_180002f80(this.WorldPlotEventDataBase,uVar9,DAT_181dacc88), lVar6 == null
                     )) break;
                  uVar1 = *(uint32 *)(lVar6 + 64);
                  iVar3 = GlobalData.RandomRange(uVar4,uVar1,0);
                  *(int *)(plVar7 + 3) = iVar3 + (int)lVar5;
                  lVar5 = FUN_18046c0a0(0);
                  if (((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) ||
                     (lVar5 = *(int64 *)(*(int64 *)(lVar5 + 32) + 168)) == null) break;
                  iVar3 = TimeData.DeltaDay(lVar5,plVar7,0);
                  if (iVar3 < 0) goto LAB_1809d42bd;
                }
                if ((this.WorldPlotEventDataBase == null) ||
                   (lVar5 = FUN_180002f80(this.WorldPlotEventDataBase,uVar9,DAT_181dacc88)) == null)
                break;
                if (*(int *)(lVar5 + 72) == 0) {
                  lVar5 = FUN_18046c0a0(0);
                  if (((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) ||
                     (lVar5 = *(int64 *)(*(int64 *)(lVar5 + 32) + 248)) == null) break;
                  cVar2 = FUN_1808ab490(lVar5,uVar9,DAT_181dbf7d8);
                  if (cVar2) goto LAB_1809d42bd;
                }
                if ((this.WorldPlotEventDataBase == null) ||
                   (lVar5 = FUN_180002f80(this.WorldPlotEventDataBase,uVar9,DAT_181dacc88)) == null)
                break;
                if (*(int *)(lVar5 + 72) == 1) {
                  lVar5 = FUN_18046c0a0(0);
                  if ((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) break;
                  lVar5 = *(int64 *)(*(int64 *)(lVar5 + 32) + 216);
                  if ((this.WorldPlotEventDataBase == null) ||
                     ((lVar6 = FUN_180002f80(this.WorldPlotEventDataBase,uVar9,DAT_181dacc88),
                      lVar6 == null || (lVar5 == null)))) break;
                  cVar2 = FUN_1808ab490(lVar5,*(uint32 *)(lVar6 + 32),DAT_181dbf7d8);
                  if (cVar2) goto LAB_1809d42bd;
                  lVar5 = FUN_18046c0a0(0);
                  if (((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) ||
                     (lVar5 = *(int64 *)(*(int64 *)(lVar5 + 32) + 248)) == null) break;
                  cVar2 = FUN_1808ab490(lVar5,uVar9,DAT_181dbf7d8);
                  if (cVar2) {
                    lVar5 = FUN_18046c0a0(0);
                    if ((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) break;
                    lVar5 = *(int64 *)(*(int64 *)(lVar5 + 32) + 168);
                    lVar6 = FUN_18046c0a0(0);
                    if ((lVar6 == null) ||
                       (((*(int64 *)(lVar6 + 32) == 0 ||
                         (lVar6 = *(int64 *)(*(int64 *)(lVar6 + 32) + 248)) == null) ||
                        (uVar8 = FUN_1817d9e10(lVar6,uVar9,DAT_181dbf860), lVar5 == null)))) break;
                    iVar3 = TimeData.DeltaDay(lVar5,uVar8,0);
                    if ((this.WorldPlotEventDataBase == null) ||
                       (lVar5 = FUN_180002f80(this.WorldPlotEventDataBase,uVar9,DAT_181dacc88),
                       lVar5 == null)) break;
                    if (iVar3 < *(int *)(lVar5 + 76)) goto LAB_1809d42bd;
                  }
                }
                if ((this.WorldPlotEventDataBase == null) ||
                   (lVar5 = FUN_180002f80(this.WorldPlotEventDataBase,uVar9,DAT_181dacc88)) == null)
                break;
                if (*(int *)(lVar5 + 72) == 2) {
                  lVar5 = FUN_18046c0a0(0);
                  if (((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) ||
                     (lVar5 = *(int64 *)(*(int64 *)(lVar5 + 32) + 248)) == null) break;
                  cVar2 = FUN_1808ab490(lVar5,uVar9,DAT_181dbf7d8);
                  if (cVar2) {
                    lVar5 = FUN_18046c0a0(0);
                    if ((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) break;
                    lVar5 = *(int64 *)(*(int64 *)(lVar5 + 32) + 168);
                    lVar6 = FUN_18046c0a0(0);
                    if ((lVar6 == null) ||
                       (((*(int64 *)(lVar6 + 32) == 0 ||
                         (lVar6 = *(int64 *)(*(int64 *)(lVar6 + 32) + 248)) == null) ||
                        (uVar8 = FUN_1817d9e10(lVar6,uVar9,DAT_181dbf860), lVar5 == null)))) break;
                    iVar3 = TimeData.DeltaDay(lVar5,uVar8,0);
                    if ((this.WorldPlotEventDataBase == null) ||
                       (lVar5 = FUN_180002f80(this.WorldPlotEventDataBase,uVar9,DAT_181dacc88),
                       lVar5 == null)) break;
                    if (iVar3 < *(int *)(lVar5 + 76)) goto LAB_1809d42bd;
                  }
                }
                if ((this.WorldPlotEventDataBase == null) ||
                   (lVar5 = FUN_180002f80(this.WorldPlotEventDataBase,uVar9,DAT_181dacc88)) == null)
                break;
                cVar2 = WorldPlotEventController.CheckMeetWorldEventNeed
                                  (this,*(uint64 *)(lVar5 + 48),0);
                if (cVar2) {
                  WorldPlotEventController.StartNewWorldPlotEventFromDataBase(this,uVar9,0);
                }
              }
            }
            else {
              if ((this.WorldPlotEventDataBase == null) ||
                 (lVar5 = FUN_180002f80(this.WorldPlotEventDataBase,uVar9,DAT_181dacc88)) == null)
              break;
              iVar3 = lVar5.Count;
              lVar5 = FUN_18046c0a0(0);
              if ((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) break;
              if (iVar3 == *(int *)(*(int64 *)(lVar5 + 32) + 156)) goto LAB_1809d3bb9;
            }
        LAB_1809d42bd:
            lVar5 = this.WorldPlotEventDataBase;
            uVar9 = uVar9 + 1;
            lVar10 = lVar10 + 1;
          } while (lVar5 != null);
        }
    }

    // Token : 0x60023C7
    // RVA   : 0x9D4630   Offset: 0x9D3A30   Length: 0xAD5
    public void StartNewWorldPlotEventFromDataBase(int i)
    {
        byte uVar1;
        int iVar2;
        long lVar3;
        ulong uVar4;
        bool cVar5;
        uint uVar6;
        long lVar7;
        ulong uVar9;
        long lVar10;
        ulong uVar11;
        long lVar12;
        lVar12 = (int64)(int)i;
        lVar10 = this.WorldPlotEventDataBase;
        if (lVar10 != null) {
          if (lVar10.Count <= i) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar10 = *(int64 *)(lVar10._items + 32 + lVar12 * 8);
          lVar7 = new ZhSegment(0);
          if (lVar10 != null) {
            *(uint64 *)(lVar7 + 16) = lVar10._items;
            *(uint32 *)(lVar7 + 24) = lVar10._version;
            *(uint32 *)(lVar7 + 28) = lVar10.villageAreaID;
            *(uint32 *)(lVar7 + 32) = *(uint32 *)(lVar10 + 36);
            *(uint64 *)(lVar7 + 40) = lVar10.forceAreaID;
            *(uint32 *)(lVar7 + 48) = *(uint32 *)(lVar10 + 68);
            *(uint8 *)(lVar7 + 64) = lVar10.WorldEventDatas;
            *(uint64 *)(lVar7 + 72) = lVar10.WorldEventDatasSaveRecord;
            *(uint8 *)(lVar7 + 80) = *(uint8 *)(lVar10 + 129);
            lVar10 = this.WorldPlotEventDataBase;
            if (lVar10 != null) {
              if (lVar10.Count <= i) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar10 = *(int64 *)(lVar10._items + 32 + lVar12 * 8);
              if ((lVar10 = lVar10?.Heros) != null) {
                if (lVar10._items != null) {
                  lVar10 = this.WorldPlotEventDataBase;
                  if (lVar10 == null) throw; // [null/range check failed]
                  if (lVar10.Count <= i) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  lVar10 = *(int64 *)(lVar10._items + 32 + lVar12 * 8);
                  if (lVar10 == null) throw; // [null/range check failed]
                  lVar10 = lVar10.Heros;
                  if (((GameController._instance == null) ||
                      (lVar3 = GameController._instance.worldData) == null)
                     || (lVar10 == null)) throw; // [null/range check failed]
                  uVar6 = TimeData.DeltaDay(lVar10,lVar3.worldTime,0);
                  uVar6 = Mathf.Max(1,uVar6);
                  if (0 < *(int *)(lVar7 + 48)) {
                    uVar6 = Mathf.Min(*(int *)(lVar7 + 48),uVar6,0);
                  }
                  *(uint32 *)(lVar7 + 48) = uVar6;
                }
                WorldPlotEventController.StartNewWorldPlotEvent(this,lVar7,0);
                if (((GameController._instance != null) &&
                    (lVar10 = GameController._instance.worldData) != null)
                   && (lVar10 = lVar10.worldPlotEventStartTime) != null) {
                  cVar5 = FUN_1808ab490(lVar10,i,DAT_181dbf7d8);
                  if (!cVar5) {
                    if ((GameController._instance == null) ||
                       (lVar10 = GameController._instance.worldData) == null
                       ) throw; // [null/range check failed]
                    lVar10 = lVar10.worldPlotEventStartTime;
                    if ((((GameController._instance == null) ||
                         (lVar3 = GameController._instance.worldData) == null
                         ) || (lVar3 = lVar3.worldTime) == null) ||
                       (plVar8 = (int64 *)TimeData.Clone(lVar3,0), lVar10 == null)) throw; // [null/range check failed]
                    FUN_1808ab370(lVar10,i,plVar8,DAT_181dbf750);
                  }
                  else {
                    if ((GameController._instance == null) ||
                       (lVar10 = GameController._instance.worldData) == null
                       ) throw; // [null/range check failed]
                    lVar10 = lVar10.worldPlotEventStartTime;
                    if ((((GameController._instance == null) ||
                         (lVar3 = GameController._instance.worldData) == null
                         ) || (lVar3 = lVar3.worldTime) == null) ||
                       (plVar8 = (int64 *)TimeData.Clone(lVar3,0), lVar10 == null)) throw; // [null/range check failed]
                    FUN_1808b2160(lVar10,i,plVar8,DAT_181dbf8e8);
                  }
                  lVar10 = this.WorldPlotEventDataBase;
                  if (lVar10 != null) {
                    if (lVar10.Count <= i) {
                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                    }
                    lVar10 = *(int64 *)(lVar10._items + 32 + lVar12 * 8);
                    if (lVar10 != null) {
                      iVar2 = lVar10.TempHeros;
                      if (iVar2 == 1) {
                        lVar10 = this.WorldPlotEventDataBase;
                        lVar7 = **(int64 **)(DAT_181d7f6a8 + 184);
                        if (lVar10 == null) throw; // [null/range check failed]
                        if (lVar10.Count <= i) {
                          ThrowHelper.ThrowArgumentOutOfRangeException(0);
                        }
                        lVar10 = *(int64 *)(lVar10._items + 32 + lVar12 * 8);
                        if (lVar10 == null) throw; // [null/range check failed]
                        lVar3 = this.WorldPlotEventDataBase;
                        uVar11 = lVar10.BigMapRandomEventDatas;
                        if (lVar3 == null) throw; // [null/range check failed]
                        if (lVar3.Count <= i) {
                          ThrowHelper.ThrowArgumentOutOfRangeException(0);
                        }
                        lVar10 = *(int64 *)(lVar3._items + 32 + lVar12 * 8);
                        if (lVar10 == null) throw; // [null/range check failed]
                        lVar3 = this.WorldPlotEventDataBase;
                        uVar4 = lVar10.AreaMapRandomEventDatas;
                        if (lVar3 == null) throw; // [null/range check failed]
                        if (lVar3.Count <= i) {
                          ThrowHelper.ThrowArgumentOutOfRangeException(0);
                        }
                        lVar10 = *(int64 *)(lVar3._items + 32 + lVar12 * 8);
                        if (lVar10 == null) throw; // [null/range check failed]
                        uVar1 = *(uint8 *)(lVar10 + 129);
                        uVar9 = new MailData(uVar11,uVar4,0,1,uVar1,0);
                        if (lVar7 == null) throw; // [null/range check failed]
                        InfoController.AddMail(lVar7,uVar9,0);
                      }
                      else if (iVar2 == 2) {
                        lVar10 = this.WorldPlotEventDataBase;
                        lVar3 = *(int64 *)(lVar7 + 56);
                        if (lVar10 == null) throw; // [null/range check failed]
                        if (lVar10.Count <= i) {
                          ThrowHelper.ThrowArgumentOutOfRangeException(0);
                        }
                        lVar10 = *(int64 *)(lVar10._items + 32 + lVar12 * 8);
                        if ((lVar10 == null) || (lVar3 == null)) throw; // [null/range check failed]
                        lVar3.villageAreaID = lVar10.AreaMapRandomEventDatas;
                        if (WorldEventController._instance == null) throw; // [null/range check failed]
                        WorldEventController.AddNewWorldEvent
                                  (WorldEventController._instance,*(uint64 *)(lVar7 + 56),0);
                      }
                      lVar10 = this.WorldPlotEventDataBase;
                      if (lVar10 != null) {
                        if (lVar10.Count <= i) {
                          ThrowHelper.ThrowArgumentOutOfRangeException(0);
                        }
                        lVar10 = *(int64 *)(lVar10._items + 32 + lVar12 * 8);
                        if (lVar10 != null) {
                          if (lVar10.lastRandomWorldEventDay == null) {
                            return;
                          }
                          lVar10 = this.WorldPlotEventDataBase;
                          if (lVar10 != null) {
                            if (lVar10.Count <= i) {
                              ThrowHelper.ThrowArgumentOutOfRangeException(0);
                            }
                            lVar10 = *(int64 *)(lVar10._items + 32 + lVar12 * 8);
                            if (lVar10 != null) {
                              cVar5 = String.op_Inequality
                                                (lVar10.lastRandomWorldEventDay,"",0);
                              if (!cVar5) {
                                return;
                              }
                              lVar10 = this.WorldPlotEventDataBase;
                              if (lVar10 != null) {
                                if (lVar10.Count <= i) {
                                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                }
                                lVar10 = *(int64 *)(lVar10._items + 32 + lVar12 * 8);
                                if ((lVar10 = lVar10?.lastRandomWorldEventDay) != null)
                                {
                                  cVar5 = String.Contains(lVar10,";",0);
                                  if (!cVar5) {
                                    lVar7 = FUN_18046c400(0);
                                    lVar10 = this.WorldPlotEventDataBase;
                                    if (lVar10 != null) {
                                      if (lVar10.Count <= i) {
                                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                      }
                                      lVar12 = *(int64 *)
                                                (lVar10._items + 32 + lVar12 * 8);
                                      if ((lVar12 != null) && (lVar7 != null)) {
                                        Component.SendMessage(lVar7,*(uint64 *)(lVar12 + 112),0);
                                        return;
                                      }
                                    }
                                  }
                                  else {
                                    lVar10 = this.WorldPlotEventDataBase;
                                    if (lVar10 != null) {
                                      if (lVar10.Count <= i) {
                                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                      }
                                      lVar12 = *(int64 *)
                                                (lVar10._items + 32 + lVar12 * 8);
                                      if (lVar12 != null) {
                                        lVar12 = *(int64 *)(lVar12 + 112);
                                        lVar10 = FUN_1800d60b0(DAT_181da1040,1);
                                        if (lVar10 != null) {
                                          if (lVar10.Count == null) {
                                            uVar11 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                            FUN_1800d65f0(uVar11,0);
                                          }
                                          lVar10.villageAreaID = 59;
                                          if (lVar12 != null) {
                                            lVar12 = String.Split(lVar12,lVar10,0);
                                            lVar10 = FUN_18046c400(0);
                                            if (lVar12 != null) {
                                              if (*(uint32 *)(lVar12 + 24) == 0) {
                                                uVar11 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                FUN_1800d65f0(uVar11,0);
                                              }
                                              if (*(uint32 *)(lVar12 + 24) < 2) {
                                                uVar11 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                FUN_1800d65f0(uVar11,0);
                                              }
                                              if (lVar10 != null) {
                                                Component.SendMessage
                                                          (lVar10,*(uint64 *)(lVar12 + 32),
                                                           *(uint64 *)(lVar12 + 40),0);
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

    // Token : 0x60023C8
    // RVA   : 0x9D3050   Offset: 0x9D2450   Length: 0xA3
    public bool CheckMeetWorldEventNeed(List<WorldPlotEventNeedData> needDatas)
    {
        bool cVar1;
        byte uVar2;
        uint uVar3;
        int iVar4;
        long lVar5;
        long lVar9;
        ulong uVar10;
        float fVar11;
        float extraout_XMM0_Da;
        float extraout_XMM0_Da_00;
        float extraout_XMM0_Da_01;
        if (needDatas == null) throw; // [null/range check failed]
        iVar4 = *(int *)(needDatas + 16);
        if (iVar4 != 0) {
          if (iVar4 == 1) {
            lVar5 = FUN_18046c0a0(0);
            if (((lVar5 != null) && (*(int64 *)(lVar5 + 32) != 0)) &&
               (lVar5 = *(int64 *)(*(int64 *)(lVar5 + 32) + 232)) != null) {
              fVar11 = (float)PlotEventLogData.GetFloat(lVar5,*(uint64 *)(needDatas + 24),0);
              if (*(int64 *)(needDatas + 32) != 0) {
                cVar1 = String.Contains(*(int64 *)(needDatas + 32),">",0);
                lVar5 = *(int64 *)(needDatas + 32);
                if (!cVar1) {
                  if (lVar5 != null) {
                    cVar1 = String.Contains(lVar5,"<",0);
                    lVar5 = *(int64 *)(needDatas + 32);
                    if (!cVar1) {
                      Single.Parse(lVar5,0);
                      if (fVar11 == extraout_XMM0_Da) {
                        return true;
                      }
                      return false;
                    }
                    if (lVar5 != null) {
                      uVar10 = String.Replace(lVar5,"<","",0);
                      Single.Parse(uVar10,0);
                      return fVar11 < extraout_XMM0_Da_00;
                    }
                  }
                }
                else if (lVar5 != null) {
                  uVar10 = String.Replace(lVar5,">","",0);
                  Single.Parse(uVar10,0);
                  return extraout_XMM0_Da_01 < fVar11;
                }
              }
            }
            throw; // [null/range check failed]
          }
          if (iVar4 == 2) {
            lVar5 = *(int64 *)(needDatas + 32);
            if (lVar5 != null) {
              cVar1 = FUN_18171e540(lVar5,"alive",0);
              if (cVar1) {
                lVar5 = FUN_18046c0a0(0);
                if (((lVar5 != null) && (*(int64 *)(lVar5 + 32) != 0)) &&
                   (lVar5 = WorldData.GetHero(*(int64 *)(lVar5 + 32),*(uint64 *)(needDatas + 24)
                                               ,0), lVar5 != null)) {
                  return *(char *)(lVar5 + 97) == false;
                }
                throw; // [null/range check failed]
              }
              cVar1 = FUN_18171e540(lVar5,"dead",0);
              if (cVar1) {
                lVar5 = FUN_18046c0a0(0);
                if (((lVar5 != null) && (*(int64 *)(lVar5 + 32) != 0)) &&
                   (lVar5 = WorldData.GetHero(*(int64 *)(lVar5 + 32),*(uint64 *)(needDatas + 24)
                                               ,0), lVar5 != null)) {
                  return (bool)*(uint8 *)(lVar5 + 97);
                }
                throw; // [null/range check failed]
              }
              cVar1 = FUN_18171e540(lVar5,"sameforce",0);
              if (cVar1) {
                lVar5 = FUN_18046c0a0(0);
                if (((lVar5 != null) && (*(int64 *)(lVar5 + 32) != 0)) &&
                   (lVar5 = WorldData.GetHero(*(int64 *)(lVar5 + 32),*(uint64 *)(needDatas + 24)
                                               ,0), lVar5 != null)) {
                  uVar2 = HeroData.IsPlayerSameForce(lVar5,0);
                  return (bool)uVar2;
                }
                throw; // [null/range check failed]
              }
            }
          }
          else if (iVar4 == 3) {
            cVar1 = FUN_18171e540(*(uint64 *)(needDatas + 32),"0",0);
            if (cVar1) {
              lVar5 = FUN_18046c0a0(0);
              if ((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) throw; // [null/range check failed]
              lVar5 = *(int64 *)(*(int64 *)(lVar5 + 32) + 224);
              uVar3 = Int32.Parse(*(uint64 *)(needDatas + 24),0);
              if (lVar5 == null) throw; // [null/range check failed]
              cVar1 = FUN_18182a3a0(lVar5,uVar3,DAT_181d8f398);
              if (cVar1) {
                return false;
              }
            }
            cVar1 = FUN_18171e540(*(uint64 *)(needDatas + 32),"1",0);
            if (!cVar1) {
              return true;
            }
            lVar5 = FUN_18046c0a0(0);
            if ((lVar5 != null) && (*(int64 *)(lVar5 + 32) != 0)) {
              lVar5 = *(int64 *)(*(int64 *)(lVar5 + 32) + 224);
              uVar3 = Int32.Parse(*(uint64 *)(needDatas + 24),0);
              if (lVar5 != null) {
                cVar1 = FUN_18182a3a0(lVar5,uVar3,DAT_181d8f398);
                if (!cVar1) {
                  return false;
                }
                return true;
              }
            }
            throw; // [null/range check failed]
          }
          plVar6 = (int64 *)FUN_1800d60b0(DAT_181da5ce0,6);
          if (plVar6 != (int64 *)0) {
            if (("Unknown WorldEventNeedData! " != 0) &&
               (lVar5 = il2cpp_internal("Unknown WorldEventNeedData! ",*(uint64 *)(*plVar6 + 64))) == null) {
              uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar10,0);
            }
            lVar5 = "Unknown WorldEventNeedData! ";
            if ((int)plVar6[3] == 0) {
              uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar10,0);
            }
            plVar6[4] = "Unknown WorldEventNeedData! ";
            il2cpp_internal(plVar6 + 4,lVar5);
            plVar7 = (int64 *)il2cpp_value_box(DAT_181db6008,needDatas + 16);
            if (plVar7 != (int64 *)0) {
              lVar5 = (**(code **)(*plVar7 + 0x168))(plVar7,*(uint64 *)(*plVar7 + 0x170));
              puVar8 = (uint32 *)il2cpp_object_unbox(plVar7);
              *(uint32 *)(needDatas + 16) = *puVar8;
              if ((lVar5 != null) &&
                 (lVar9 = il2cpp_internal(lVar5,*(uint64 *)(*plVar6 + 64))) == null) {
                uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar10,0);
              }
              if (*(uint32 *)(plVar6 + 3) < 2) {
                uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar10,0);
              }
              plVar6[5] = lVar5;
              il2cpp_internal(plVar6 + 5,lVar5);
              if ((":" != 0) &&
                 (lVar5 = il2cpp_internal(":",*(uint64 *)(*plVar6 + 64))) == null)
              {
                uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar10,0);
              }
              lVar5 = ":";
              if (*(uint32 *)(plVar6 + 3) < 3) {
                uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar10,0);
              }
              plVar6[6] = ":";
              il2cpp_internal(plVar6 + 6,lVar5);
              lVar5 = *(int64 *)(needDatas + 24);
              if ((lVar5 != null) &&
                 (lVar9 = il2cpp_internal(lVar5,*(uint64 *)(*plVar6 + 64))) == null) {
                uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar10,0);
              }
              if (*(uint32 *)(plVar6 + 3) < 4) {
                uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar10,0);
              }
              plVar6[7] = lVar5;
              il2cpp_internal(plVar6 + 7,lVar5);
              if ((":" != 0) &&
                 (lVar5 = il2cpp_internal(":",*(uint64 *)(*plVar6 + 64))) == null)
              {
                uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar10,0);
              }
              lVar5 = ":";
              if (*(uint32 *)(plVar6 + 3) < 5) {
                uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar10,0);
              }
              plVar6[8] = ":";
              il2cpp_internal(plVar6 + 8,lVar5);
              lVar5 = *(int64 *)(needDatas + 32);
              if ((lVar5 != null) &&
                 (lVar9 = il2cpp_internal(lVar5,*(uint64 *)(*plVar6 + 64))) == null) {
                uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar10,0);
              }
              if (*(uint32 *)(plVar6 + 3) < 6) {
                uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar10,0);
              }
              plVar6[9] = lVar5;
              il2cpp_internal(plVar6 + 9,lVar5);
              uVar10 = String.Concat(plVar6,0);
              Debug.Log(uVar10,0);
              return true;
            }
          }
          throw; // [null/range check failed]
        }
        cVar1 = FUN_18171e540(*(uint64 *)(needDatas + 32),"0",0);
        if (cVar1) {
          lVar5 = FUN_18046c0a0(0);
          if ((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) throw; // [null/range check failed]
          lVar5 = *(int64 *)(*(int64 *)(lVar5 + 32) + 216);
          uVar3 = Int32.Parse(*(uint64 *)(needDatas + 24),0);
          if (lVar5 == null) throw; // [null/range check failed]
          cVar1 = FUN_1808ab490(lVar5,uVar3,DAT_181dbf7d8);
          if (cVar1) {
            return false;
          }
        }
        cVar1 = FUN_18171e540(*(uint64 *)(needDatas + 32),"1",0);
        if (!cVar1) {
          return true;
        }
        lVar5 = FUN_18046c0a0(0);
        if ((lVar5 != null) && (*(int64 *)(lVar5 + 32) != 0)) {
          lVar5 = *(int64 *)(*(int64 *)(lVar5 + 32) + 216);
          uVar3 = Int32.Parse(*(uint64 *)(needDatas + 24),0);
          if (lVar5 != null) {
            cVar1 = FUN_1808ab490(lVar5,uVar3,DAT_181dbf7d8);
            if (!cVar1) {
              return false;
            }
            lVar5 = FUN_18046c0a0(0);
            if ((lVar5 != null) && (*(int64 *)(lVar5 + 32) != 0)) {
              lVar5 = *(int64 *)(*(int64 *)(lVar5 + 32) + 168);
              lVar9 = FUN_18046c0a0(0);
              if ((lVar9 != null) && (*(int64 *)(lVar9 + 32) != 0)) {
                lVar9 = *(int64 *)(*(int64 *)(lVar9 + 32) + 216);
                uVar3 = Int32.Parse(*(uint64 *)(needDatas + 24),0);
                if ((lVar9 != null) && (uVar10 = FUN_1817d9e10(lVar9,uVar3,DAT_181dbf860), lVar5 != null)) {
                  iVar4 = TimeData.DeltaDay(lVar5,uVar10,0);
                  if (iVar4 < 10) {
                    return false;
                  }
                  return true;
                }
              }
            }
          }
        }
    }

    // Token : 0x60023C9
    // RVA   : 0x9D3100   Offset: 0x9D2500   Length: 0x966
    public bool CheckMeetWorldEventNeed(WorldPlotEventNeedData needData)
    {
        bool cVar1;
        byte uVar2;
        uint uVar3;
        int iVar4;
        long lVar5;
        long lVar9;
        ulong uVar10;
        float fVar11;
        float extraout_XMM0_Da;
        float extraout_XMM0_Da_00;
        float extraout_XMM0_Da_01;
        if (needData == null) throw; // [null/range check failed]
        iVar4 = *(int *)(needData + 16);
        if (iVar4 != 0) {
          if (iVar4 == 1) {
            lVar5 = FUN_18046c0a0(0);
            if (((lVar5 != null) && (*(int64 *)(lVar5 + 32) != 0)) &&
               (lVar5 = *(int64 *)(*(int64 *)(lVar5 + 32) + 232)) != null) {
              fVar11 = (float)PlotEventLogData.GetFloat(lVar5,*(uint64 *)(needData + 24),0);
              if (*(int64 *)(needData + 32) != 0) {
                cVar1 = String.Contains(*(int64 *)(needData + 32),">",0);
                lVar5 = *(int64 *)(needData + 32);
                if (!cVar1) {
                  if (lVar5 != null) {
                    cVar1 = String.Contains(lVar5,"<",0);
                    lVar5 = *(int64 *)(needData + 32);
                    if (!cVar1) {
                      Single.Parse(lVar5,0);
                      if (fVar11 == extraout_XMM0_Da) {
                        return true;
                      }
                      return false;
                    }
                    if (lVar5 != null) {
                      uVar10 = String.Replace(lVar5,"<","",0);
                      Single.Parse(uVar10,0);
                      return fVar11 < extraout_XMM0_Da_00;
                    }
                  }
                }
                else if (lVar5 != null) {
                  uVar10 = String.Replace(lVar5,">","",0);
                  Single.Parse(uVar10,0);
                  return extraout_XMM0_Da_01 < fVar11;
                }
              }
            }
            throw; // [null/range check failed]
          }
          if (iVar4 == 2) {
            lVar5 = *(int64 *)(needData + 32);
            if (lVar5 != null) {
              cVar1 = FUN_18171e540(lVar5,"alive",0);
              if (cVar1) {
                lVar5 = FUN_18046c0a0(0);
                if (((lVar5 != null) && (*(int64 *)(lVar5 + 32) != 0)) &&
                   (lVar5 = WorldData.GetHero(*(int64 *)(lVar5 + 32),*(uint64 *)(needData + 24)
                                               ,0), lVar5 != null)) {
                  return *(char *)(lVar5 + 97) == false;
                }
                throw; // [null/range check failed]
              }
              cVar1 = FUN_18171e540(lVar5,"dead",0);
              if (cVar1) {
                lVar5 = FUN_18046c0a0(0);
                if (((lVar5 != null) && (*(int64 *)(lVar5 + 32) != 0)) &&
                   (lVar5 = WorldData.GetHero(*(int64 *)(lVar5 + 32),*(uint64 *)(needData + 24)
                                               ,0), lVar5 != null)) {
                  return (bool)*(uint8 *)(lVar5 + 97);
                }
                throw; // [null/range check failed]
              }
              cVar1 = FUN_18171e540(lVar5,"sameforce",0);
              if (cVar1) {
                lVar5 = FUN_18046c0a0(0);
                if (((lVar5 != null) && (*(int64 *)(lVar5 + 32) != 0)) &&
                   (lVar5 = WorldData.GetHero(*(int64 *)(lVar5 + 32),*(uint64 *)(needData + 24)
                                               ,0), lVar5 != null)) {
                  uVar2 = HeroData.IsPlayerSameForce(lVar5,0);
                  return (bool)uVar2;
                }
                throw; // [null/range check failed]
              }
            }
          }
          else if (iVar4 == 3) {
            cVar1 = FUN_18171e540(*(uint64 *)(needData + 32),"0",0);
            if (cVar1) {
              lVar5 = FUN_18046c0a0(0);
              if ((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) throw; // [null/range check failed]
              lVar5 = *(int64 *)(*(int64 *)(lVar5 + 32) + 224);
              uVar3 = Int32.Parse(*(uint64 *)(needData + 24),0);
              if (lVar5 == null) throw; // [null/range check failed]
              cVar1 = FUN_18182a3a0(lVar5,uVar3,DAT_181d8f398);
              if (cVar1) {
                return false;
              }
            }
            cVar1 = FUN_18171e540(*(uint64 *)(needData + 32),"1",0);
            if (!cVar1) {
              return true;
            }
            lVar5 = FUN_18046c0a0(0);
            if ((lVar5 != null) && (*(int64 *)(lVar5 + 32) != 0)) {
              lVar5 = *(int64 *)(*(int64 *)(lVar5 + 32) + 224);
              uVar3 = Int32.Parse(*(uint64 *)(needData + 24),0);
              if (lVar5 != null) {
                cVar1 = FUN_18182a3a0(lVar5,uVar3,DAT_181d8f398);
                if (!cVar1) {
                  return false;
                }
                return true;
              }
            }
            throw; // [null/range check failed]
          }
          plVar6 = (int64 *)FUN_1800d60b0(DAT_181da5ce0,6);
          if (plVar6 != (int64 *)0) {
            if (("Unknown WorldEventNeedData! " != 0) &&
               (lVar5 = il2cpp_internal("Unknown WorldEventNeedData! ",*(uint64 *)(*plVar6 + 64))) == null) {
              uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar10,0);
            }
            lVar5 = "Unknown WorldEventNeedData! ";
            if ((int)plVar6[3] == 0) {
              uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar10,0);
            }
            plVar6[4] = "Unknown WorldEventNeedData! ";
            il2cpp_internal(plVar6 + 4,lVar5);
            plVar7 = (int64 *)il2cpp_value_box(DAT_181db6008,needData + 16);
            if (plVar7 != (int64 *)0) {
              lVar5 = (**(code **)(*plVar7 + 0x168))(plVar7,*(uint64 *)(*plVar7 + 0x170));
              puVar8 = (uint32 *)il2cpp_object_unbox(plVar7);
              *(uint32 *)(needData + 16) = *puVar8;
              if ((lVar5 != null) &&
                 (lVar9 = il2cpp_internal(lVar5,*(uint64 *)(*plVar6 + 64))) == null) {
                uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar10,0);
              }
              if (*(uint32 *)(plVar6 + 3) < 2) {
                uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar10,0);
              }
              plVar6[5] = lVar5;
              il2cpp_internal(plVar6 + 5,lVar5);
              if ((":" != 0) &&
                 (lVar5 = il2cpp_internal(":",*(uint64 *)(*plVar6 + 64))) == null)
              {
                uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar10,0);
              }
              lVar5 = ":";
              if (*(uint32 *)(plVar6 + 3) < 3) {
                uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar10,0);
              }
              plVar6[6] = ":";
              il2cpp_internal(plVar6 + 6,lVar5);
              lVar5 = *(int64 *)(needData + 24);
              if ((lVar5 != null) &&
                 (lVar9 = il2cpp_internal(lVar5,*(uint64 *)(*plVar6 + 64))) == null) {
                uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar10,0);
              }
              if (*(uint32 *)(plVar6 + 3) < 4) {
                uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar10,0);
              }
              plVar6[7] = lVar5;
              il2cpp_internal(plVar6 + 7,lVar5);
              if ((":" != 0) &&
                 (lVar5 = il2cpp_internal(":",*(uint64 *)(*plVar6 + 64))) == null)
              {
                uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar10,0);
              }
              lVar5 = ":";
              if (*(uint32 *)(plVar6 + 3) < 5) {
                uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar10,0);
              }
              plVar6[8] = ":";
              il2cpp_internal(plVar6 + 8,lVar5);
              lVar5 = *(int64 *)(needData + 32);
              if ((lVar5 != null) &&
                 (lVar9 = il2cpp_internal(lVar5,*(uint64 *)(*plVar6 + 64))) == null) {
                uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar10,0);
              }
              if (*(uint32 *)(plVar6 + 3) < 6) {
                uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar10,0);
              }
              plVar6[9] = lVar5;
              il2cpp_internal(plVar6 + 9,lVar5);
              uVar10 = String.Concat(plVar6,0);
              Debug.Log(uVar10,0);
              return true;
            }
          }
          throw; // [null/range check failed]
        }
        cVar1 = FUN_18171e540(*(uint64 *)(needData + 32),"0",0);
        if (cVar1) {
          lVar5 = FUN_18046c0a0(0);
          if ((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) throw; // [null/range check failed]
          lVar5 = *(int64 *)(*(int64 *)(lVar5 + 32) + 216);
          uVar3 = Int32.Parse(*(uint64 *)(needData + 24),0);
          if (lVar5 == null) throw; // [null/range check failed]
          cVar1 = FUN_1808ab490(lVar5,uVar3,DAT_181dbf7d8);
          if (cVar1) {
            return false;
          }
        }
        cVar1 = FUN_18171e540(*(uint64 *)(needData + 32),"1",0);
        if (!cVar1) {
          return true;
        }
        lVar5 = FUN_18046c0a0(0);
        if ((lVar5 != null) && (*(int64 *)(lVar5 + 32) != 0)) {
          lVar5 = *(int64 *)(*(int64 *)(lVar5 + 32) + 216);
          uVar3 = Int32.Parse(*(uint64 *)(needData + 24),0);
          if (lVar5 != null) {
            cVar1 = FUN_1808ab490(lVar5,uVar3,DAT_181dbf7d8);
            if (!cVar1) {
              return false;
            }
            lVar5 = FUN_18046c0a0(0);
            if ((lVar5 != null) && (*(int64 *)(lVar5 + 32) != 0)) {
              lVar5 = *(int64 *)(*(int64 *)(lVar5 + 32) + 168);
              lVar9 = FUN_18046c0a0(0);
              if ((lVar9 != null) && (*(int64 *)(lVar9 + 32) != 0)) {
                lVar9 = *(int64 *)(*(int64 *)(lVar9 + 32) + 216);
                uVar3 = Int32.Parse(*(uint64 *)(needData + 24),0);
                if ((lVar9 != null) && (uVar10 = FUN_1817d9e10(lVar9,uVar3,DAT_181dbf860), lVar5 != null)) {
                  iVar4 = TimeData.DeltaDay(lVar5,uVar10,0);
                  if (iVar4 < 10) {
                    return false;
                  }
                  return true;
                }
              }
            }
          }
        }
    }

    // Token : 0x60023CA
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
