// ============================================================
// Type  : WorldPlotEventController
// Token : 0x20003B2
// ============================================================

public class WorldPlotEventController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001D17
    public List<WorldPlotEventData> WorldPlotEventDataBase;

    // Token: 0x4001D18
    private static WorldPlotEventController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600233F
    // RVA   : 0xB2D8A0   Offset: 0xB2C0A0   Length: 0x36
    public static WorldPlotEventController get_Instance()
    {
        return **(uint64 **)(DAT_181d90cc8 + 184);
    }

    // Token : 0x6002340
    // RVA   : 0xB2AF60   Offset: 0xB29760   Length: 0xD7
    private void Awake()
    {
        bool cVar2;
        ulong uVar3;
        uVar3 = **(uint64 **)(DAT_181d90cc8 + 184);
        cVar2 = Object.op_Equality(uVar3,0,0);
        if (!cVar2) {
          uVar3 = Component.get_gameObject(this,0);
          Object.Destroy(uVar3,0);
          return;
        }
        puVar1 = *(uint64 **)(DAT_181d90cc8 + 184);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x6002341
    // RVA   : 0xB2D190   Offset: 0xB2B990   Length: 0x70A
    public void StartNewWorldPlotEvent(WorldPlotEventStartData targetWorldPlotEventStartData)
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        bool cVar2;
        int iVar3;
        long lVar4;
        uint uVar5;
        long lVar6;
        long lVar7;
        ulong uVar9;
        long lVar10;
        float fVar11;
        if (((*pStatics != 0) &&
            (lVar6 = *(int64 *)(*pStatics + 32)) != null) &&
           (lVar6 = *(int64 *)(lVar6 + 240)) != null) {
          FUN_181827900(lVar6,targetWorldPlotEventStartData,DAT_181d85478);
          if ((*pStatics != 0) &&
             (GameController.ChangePlotTargetNumCount(*pStatics,targetWorldPlotEventStartData,1,0),
             targetWorldPlotEventStartData != null)) {
            if ((*(int *)(targetWorldPlotEventStartData + 32) - 1U & 0xfffffff6) != 0) {
              return;
            }
            if (*(int *)(targetWorldPlotEventStartData + 32) == 9) {
              return;
            }
            lVar6 = new EventData(0);
            if (lVar6 != null) {
              *(uint64 *)(lVar6 + 24) = *(uint64 *)(targetWorldPlotEventStartData + 16);
              fVar11 = *(float *)(targetWorldPlotEventStartData + 24);
              if (fVar11 == -1.0) {
                if (*pStatics == 0) throw; // [null/range check failed]
                fVar11 = (float)GameController.GetTimeDifficulty(*pStatics,0)
                ;
              }
              *(float *)(lVar6 + 108) = fVar11;
              plVar1 = (int64 *)(targetWorldPlotEventStartData + 56);
              *(uint32 *)(lVar6 + 104) = *(uint32 *)(targetWorldPlotEventStartData + 48);
              cVar2 = *(char *)(targetWorldPlotEventStartData + 64);
              *(uint8 *)(lVar6 + 100) = 1;
              *(bool *)(lVar6 + 102) = !cVar2;
              *(uint8 *)(lVar6 + 161) = *(uint8 *)(targetWorldPlotEventStartData + 80);
              *plVar1 = lVar6;
              il2cpp_internal(plVar1,lVar6);
              lVar6 = *plVar1;
              lVar7 = *(int64 *)(*(int64 *)(DAT_181d4e010 + 184) + 32);
              if ((((lVar7 != null) && (lVar7 = *(int64 *)(lVar7 + 0x178)) != null) &&
                  (lVar7 = FUN_1817cc780(lVar7,*(uint32 *)(targetWorldPlotEventStartData + 28),DAT_181d97800)) != null
                  ) && (plVar8 = (int64 *)PlotData.Clone(lVar7,0), lVar6 != null)) {
                *(int64 **)(lVar6 + 120) = plVar8;
                iVar3 = *(int *)(targetWorldPlotEventStartData + 32);
                if (iVar3 == 1) {
                  lVar6 = *(int64 *)(targetWorldPlotEventStartData + 40);
                  lVar7 = FUN_1800d60b0(DAT_181d7c118,1);
                  if (lVar7 != null) {
                    if (*(int *)(lVar7 + 24) == 0) {
                      uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar9,0);
                    }
                    *(uint16 *)(lVar7 + 32) = 58;
                    if (lVar6 != null) {
                      lVar6 = String.Split(lVar6,lVar7,0);
                      lVar7 = *plVar1;
                      lVar10 = *pStatics;
                      if ((*pStatics != 0) &&
                         (lVar4 = *(int64 *)(*pStatics + 32), lVar6 != null)
                         ) {
                        if (*(int *)(lVar6 + 24) == 0) {
                          uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1800d65f0(uVar9,0);
                        }
                        uVar5 = Int32.Parse(*(uint64 *)(lVar6 + 32),0);
                        if (lVar4 != null) {
                          uVar9 = WorldData.GetArea(lVar4,uVar5,0);
                          if ((int)*(uint32 *)(lVar6 + 24) < 2) {
                            uVar5 = 0xffffffff;
                          }
                          else {
                            if (*(uint32 *)(lVar6 + 24) < 2) {
                              uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                              FUN_1800d65f0(uVar9,0);
                            }
                            uVar5 = Int32.Parse(*(uint64 *)(lVar6 + 40),0);
                          }
                          if (lVar10 != null) {
                            GameController.CreateBigMapRandomEvent(lVar10,lVar7,uVar9,uVar5,0x3e4ccccd,0)
                            ;
                            return;
                          }
                        }
                      }
                    }
                  }
                }
                else if (iVar3 == 2) {
                  lVar7 = FUN_18046c0a0(0);
                  lVar6 = *plVar1;
                  lVar10 = il2cpp_internal(DAT_181d6f030);
                  FUN_180f58a90(lVar10,DAT_181d678f8);
                  uVar5 = Int32.Parse(*(uint64 *)(targetWorldPlotEventStartData + 40),0);
                  if ((lVar10 != null) && (FUN_181814fa0(lVar10,uVar5,DAT_181d67a78), lVar7 != null)) {
                    GameController.CreateAreaMapRandomEvent(lVar7,lVar6,lVar10,0);
                    return;
                  }
                }
                else {
                  if (iVar3 != 10) {
                    return;
                  }
                  if (*plVar1 != 0) {
                    *(uint8 *)(*plVar1 + 96) = 1;
                    lVar7 = FUN_18046c0a0(0);
                    lVar6 = *plVar1;
                    lVar10 = FUN_18046c0a0(0);
                    if (lVar10 != null) {
                      lVar10 = *(int64 *)(lVar10 + 32);
                      uVar5 = Int32.Parse(*(uint64 *)(targetWorldPlotEventStartData + 40),0);
                      if ((lVar10 != null) &&
                         (uVar9 = WorldData.GetResourcePoint(lVar10,uVar5,0), lVar7 != null)) {
                        GameController.CreateBigMapRandomEvent(lVar7,lVar6,uVar9,0);
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

    // Token : 0x6002342
    // RVA   : 0xB2C390   Offset: 0xB2AB90   Length: 0x31D
    public void RemoveWorldPlotEvent(string plotEventName)
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        int iVar1;
        bool cVar2;
        long lVar3;
        long lVar4;
        ulong uVar5;
        if (((*pStatics != 0) &&
            (lVar3 = *(int64 *)(*pStatics + 32)) != null) &&
           (lVar3 = *(int64 *)(lVar3 + 240)) != null) {
          iVar1 = *(int *)(lVar3 + 24);
          while( true ) {
            while( true ) {
              do {
                iVar1 = iVar1 + -1;
                if (iVar1 < 0) {
                  return;
                }
                lVar3 = FUN_18046c0a0(0);
                if (((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) ||
                   ((lVar3 = *(int64 *)(*(int64 *)(lVar3 + 32) + 240), lVar3 == null ||
                    (lVar3 = FUN_180002f80(lVar3,iVar1,DAT_181d855f8)) == null))) throw; // [null/range check failed]
                cVar2 = FUN_1816fd990(*(uint64 *)(lVar3 + 16),plotEventName,0);
              } while (!cVar2);
              lVar3 = FUN_18046c0a0(0);
              if ((((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) ||
                  (lVar3 = *(int64 *)(*(int64 *)(lVar3 + 32) + 240)) == null) ||
                 (lVar3 = FUN_180002f80(lVar3,iVar1,DAT_181d855f8)) == null) throw; // [null/range check failed]
              if (*(int64 *)(lVar3 + 56) == 0) break;
              lVar3 = FUN_18046c0a0(0);
              lVar4 = FUN_18046c0a0(0);
              if (((lVar4 == null) || (*(int64 *)(lVar4 + 32) == 0)) ||
                 ((lVar4 = *(int64 *)(*(int64 *)(lVar4 + 32) + 240), lVar4 == null ||
                  ((lVar4 = FUN_180002f80(lVar4,iVar1,DAT_181d855f8), lVar4 == null || (lVar3 == null))))))
              throw; // [null/range check failed]
              GameController.RemoveEvent(lVar3,*(uint64 *)(lVar4 + 56),0);
            }
            lVar3 = FUN_18046c0a0(0);
            lVar4 = FUN_18046c0a0(0);
            if ((((lVar4 == null) || (*(int64 *)(lVar4 + 32) == 0)) ||
                (lVar4 = *(int64 *)(*(int64 *)(lVar4 + 32) + 240)) == null) ||
               (uVar5 = FUN_180002f80(lVar4,iVar1,DAT_181d855f8), lVar3 == null)) break;
            GameController.ChangePlotTargetNumCount(lVar3,uVar5,0,0);
            lVar3 = FUN_18046c0a0(0);
            if (((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) ||
               (lVar3 = *(int64 *)(*(int64 *)(lVar3 + 32) + 240)) == null) break;
            FUN_18182b220(lVar3,iVar1,DAT_181d854f8);
          }
        }
    }

    // Token : 0x6002343
    // RVA   : 0xB2BAF0   Offset: 0xB2A2F0   Length: 0x898
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
        LAB_180b2bc39:
              lVar5 = FUN_18046c0a0(0);
              if ((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) break;
              lVar5 = *(int64 *)(*(int64 *)(lVar5 + 32) + 168);
              if ((this.WorldPlotEventDataBase == null) ||
                 ((lVar6 = FUN_180002f80(this.WorldPlotEventDataBase,uVar9,DAT_181d852f8), lVar6 == null ||
                  (lVar5 == null)))) break;
              iVar3 = TimeData.DeltaDay(lVar5,*(uint64 *)(lVar6 + 56),0);
              if (-1 < iVar3) {
                if (((this.WorldPlotEventDataBase == null) ||
                    (lVar5 = FUN_180002f80(this.WorldPlotEventDataBase,uVar9,DAT_181d852f8)) == null
                    ) || (*(int64 *)(lVar5 + 80) == 0)) break;
                if (*(int *)(*(int64 *)(lVar5 + 80) + 16) != 0) {
                  lVar5 = FUN_18046c0a0(0);
                  if ((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) break;
                  lVar5 = *(int64 *)(*(int64 *)(lVar5 + 32) + 168);
                  if ((this.WorldPlotEventDataBase == null) ||
                     ((lVar6 = FUN_180002f80(this.WorldPlotEventDataBase,uVar9,DAT_181d852f8),
                      lVar6 == null || (lVar5 == null)))) break;
                  iVar3 = TimeData.DeltaDay(lVar5,*(uint64 *)(lVar6 + 80),0);
                  if (0 < iVar3) goto LAB_180b2c33d;
                }
                if ((this.WorldPlotEventDataBase == null) ||
                   (lVar5 = FUN_180002f80(this.WorldPlotEventDataBase,uVar9,DAT_181d852f8)) == null)
                break;
                if (*(int *)(lVar5 + 64) != 0) {
                  if ((((this.WorldPlotEventDataBase == null) ||
                       (lVar5 = FUN_180002f80(this.WorldPlotEventDataBase,uVar9,DAT_181d852f8),
                       lVar5 == null)) || (*(int64 *)(lVar5 + 56) == 0)) ||
                     (plVar7 = (int64 *)TimeData.Clone(*(int64 *)(lVar5 + 56),0),
                     plVar7 == (int64 *)0)) break;
                  lVar5 = plVar7[3];
                  lVar6 = FUN_18046c0a0(0);
                  if (((lVar6 == null) || (*(int64 *)(lVar6 + 32) == 0)) ||
                     (lVar6 = *(int64 *)(*(int64 *)(lVar6 + 32) + 168)) == null) break;
                  uVar4 = TimeData.DeltaDay(lVar6,plVar7,0);
                  if ((this.WorldPlotEventDataBase == null) ||
                     (lVar6 = FUN_180002f80(this.WorldPlotEventDataBase,uVar9,DAT_181d852f8), lVar6 == null
                     )) break;
                  uVar4 = Mathf.Clamp(uVar4,0,*(uint32 *)(lVar6 + 64),0);
                  if ((this.WorldPlotEventDataBase == null) ||
                     (lVar6 = FUN_180002f80(this.WorldPlotEventDataBase,uVar9,DAT_181d852f8), lVar6 == null
                     )) break;
                  uVar1 = *(uint32 *)(lVar6 + 64);
                  iVar3 = GlobalData.RandomRange(uVar4,uVar1,0);
                  *(int *)(plVar7 + 3) = iVar3 + (int)lVar5;
                  lVar5 = FUN_18046c0a0(0);
                  if (((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) ||
                     (lVar5 = *(int64 *)(*(int64 *)(lVar5 + 32) + 168)) == null) break;
                  iVar3 = TimeData.DeltaDay(lVar5,plVar7,0);
                  if (iVar3 < 0) goto LAB_180b2c33d;
                }
                if ((this.WorldPlotEventDataBase == null) ||
                   (lVar5 = FUN_180002f80(this.WorldPlotEventDataBase,uVar9,DAT_181d852f8)) == null)
                break;
                if (*(int *)(lVar5 + 72) == 0) {
                  lVar5 = FUN_18046c0a0(0);
                  if (((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) ||
                     (lVar5 = *(int64 *)(*(int64 *)(lVar5 + 32) + 248)) == null) break;
                  cVar2 = FUN_1808ab750(lVar5,uVar9,DAT_181d99e30);
                  if (cVar2) goto LAB_180b2c33d;
                }
                if ((this.WorldPlotEventDataBase == null) ||
                   (lVar5 = FUN_180002f80(this.WorldPlotEventDataBase,uVar9,DAT_181d852f8)) == null)
                break;
                if (*(int *)(lVar5 + 72) == 1) {
                  lVar5 = FUN_18046c0a0(0);
                  if ((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) break;
                  lVar5 = *(int64 *)(*(int64 *)(lVar5 + 32) + 216);
                  if ((this.WorldPlotEventDataBase == null) ||
                     ((lVar6 = FUN_180002f80(this.WorldPlotEventDataBase,uVar9,DAT_181d852f8),
                      lVar6 == null || (lVar5 == null)))) break;
                  cVar2 = FUN_1808ab750(lVar5,*(uint32 *)(lVar6 + 32),DAT_181d99e30);
                  if (cVar2) goto LAB_180b2c33d;
                  lVar5 = FUN_18046c0a0(0);
                  if (((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) ||
                     (lVar5 = *(int64 *)(*(int64 *)(lVar5 + 32) + 248)) == null) break;
                  cVar2 = FUN_1808ab750(lVar5,uVar9,DAT_181d99e30);
                  if (cVar2) {
                    lVar5 = FUN_18046c0a0(0);
                    if ((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) break;
                    lVar5 = *(int64 *)(*(int64 *)(lVar5 + 32) + 168);
                    lVar6 = FUN_18046c0a0(0);
                    if ((lVar6 == null) ||
                       (((*(int64 *)(lVar6 + 32) == 0 ||
                         (lVar6 = *(int64 *)(*(int64 *)(lVar6 + 32) + 248)) == null) ||
                        (uVar8 = FUN_1817cc780(lVar6,uVar9,DAT_181d99eb8), lVar5 == null)))) break;
                    iVar3 = TimeData.DeltaDay(lVar5,uVar8,0);
                    if ((this.WorldPlotEventDataBase == null) ||
                       (lVar5 = FUN_180002f80(this.WorldPlotEventDataBase,uVar9,DAT_181d852f8),
                       lVar5 == null)) break;
                    if (iVar3 < *(int *)(lVar5 + 76)) goto LAB_180b2c33d;
                  }
                }
                if ((this.WorldPlotEventDataBase == null) ||
                   (lVar5 = FUN_180002f80(this.WorldPlotEventDataBase,uVar9,DAT_181d852f8)) == null)
                break;
                if (*(int *)(lVar5 + 72) == 2) {
                  lVar5 = FUN_18046c0a0(0);
                  if (((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) ||
                     (lVar5 = *(int64 *)(*(int64 *)(lVar5 + 32) + 248)) == null) break;
                  cVar2 = FUN_1808ab750(lVar5,uVar9,DAT_181d99e30);
                  if (cVar2) {
                    lVar5 = FUN_18046c0a0(0);
                    if ((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) break;
                    lVar5 = *(int64 *)(*(int64 *)(lVar5 + 32) + 168);
                    lVar6 = FUN_18046c0a0(0);
                    if ((lVar6 == null) ||
                       (((*(int64 *)(lVar6 + 32) == 0 ||
                         (lVar6 = *(int64 *)(*(int64 *)(lVar6 + 32) + 248)) == null) ||
                        (uVar8 = FUN_1817cc780(lVar6,uVar9,DAT_181d99eb8), lVar5 == null)))) break;
                    iVar3 = TimeData.DeltaDay(lVar5,uVar8,0);
                    if ((this.WorldPlotEventDataBase == null) ||
                       (lVar5 = FUN_180002f80(this.WorldPlotEventDataBase,uVar9,DAT_181d852f8),
                       lVar5 == null)) break;
                    if (iVar3 < *(int *)(lVar5 + 76)) goto LAB_180b2c33d;
                  }
                }
                if ((this.WorldPlotEventDataBase == null) ||
                   (lVar5 = FUN_180002f80(this.WorldPlotEventDataBase,uVar9,DAT_181d852f8)) == null)
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
                 (lVar5 = FUN_180002f80(this.WorldPlotEventDataBase,uVar9,DAT_181d852f8)) == null)
              break;
              iVar3 = lVar5.Count;
              lVar5 = FUN_18046c0a0(0);
              if ((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) break;
              if (iVar3 == *(int *)(*(int64 *)(lVar5 + 32) + 156)) goto LAB_180b2bc39;
            }
        LAB_180b2c33d:
            lVar5 = this.WorldPlotEventDataBase;
            uVar9 = uVar9 + 1;
            lVar10 = lVar10 + 1;
          } while (lVar5 != null);
        }
    }

    // Token : 0x6002344
    // RVA   : 0xB2C6B0   Offset: 0xB2AEB0   Length: 0xAD5
    public void StartNewWorldPlotEventFromDataBase(int i)
    {
        var pStatics_0bb8 = *(int64*)(DAT_181d90bb8 + 184);
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
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
            *(uint32 *)(lVar7 + 28) = *(uint32 *)(lVar10 + 32);
            *(uint32 *)(lVar7 + 32) = *(uint32 *)(lVar10 + 36);
            *(uint64 *)(lVar7 + 40) = *(uint64 *)(lVar10 + 40);
            *(uint32 *)(lVar7 + 48) = *(uint32 *)(lVar10 + 68);
            *(uint8 *)(lVar7 + 64) = *(uint8 *)(lVar10 + 128);
            *(uint64 *)(lVar7 + 72) = *(uint64 *)(lVar10 + 120);
            *(uint8 *)(lVar7 + 80) = *(uint8 *)(lVar10 + 129);
            lVar10 = this.WorldPlotEventDataBase;
            if (lVar10 != null) {
              if (lVar10.Count <= i) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar10 = *(int64 *)(lVar10._items + 32 + lVar12 * 8);
              if ((lVar10 != null) && (lVar10 = *(int64 *)(lVar10 + 80)) != null) {
                if (lVar10._items != null) {
                  lVar10 = this.WorldPlotEventDataBase;
                  if (lVar10 == null) throw; // [null/range check failed]
                  if (lVar10.Count <= i) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  lVar10 = *(int64 *)(lVar10._items + 32 + lVar12 * 8);
                  if (lVar10 == null) throw; // [null/range check failed]
                  lVar10 = *(int64 *)(lVar10 + 80);
                  if (((*pStatics_df90 == 0) ||
                      (lVar3 = *(int64 *)(*pStatics_df90 + 32)) == null)
                     || (lVar10 == null)) throw; // [null/range check failed]
                  uVar6 = TimeData.DeltaDay(lVar10,*(uint64 *)(lVar3 + 168),0);
                  uVar6 = Mathf.Max(1,uVar6);
                  if (0 < *(int *)(lVar7 + 48)) {
                    uVar6 = Mathf.Min(*(int *)(lVar7 + 48),uVar6,0);
                  }
                  *(uint32 *)(lVar7 + 48) = uVar6;
                }
                WorldPlotEventController.StartNewWorldPlotEvent(this,lVar7,0);
                if (((*pStatics_df90 != 0) &&
                    (lVar10 = *(int64 *)(*pStatics_df90 + 32)) != null)
                   && (lVar10 = *(int64 *)(lVar10 + 248)) != null) {
                  cVar5 = FUN_1808ab750(lVar10,i,DAT_181d99e30);
                  if (!cVar5) {
                    if ((*pStatics_df90 == 0) ||
                       (lVar10 = *(int64 *)(*pStatics_df90 + 32)) == null
                       ) throw; // [null/range check failed]
                    lVar10 = *(int64 *)(lVar10 + 248);
                    if ((((*pStatics_df90 == 0) ||
                         (lVar3 = *(int64 *)(*pStatics_df90 + 32)) == null
                         ) || (lVar3 = *(int64 *)(lVar3 + 168)) == null) ||
                       (plVar8 = (int64 *)TimeData.Clone(lVar3,0), lVar10 == null)) throw; // [null/range check failed]
                    FUN_1808ab680(lVar10,i,plVar8,DAT_181d99da8);
                  }
                  else {
                    if ((*pStatics_df90 == 0) ||
                       (lVar10 = *(int64 *)(*pStatics_df90 + 32)) == null
                       ) throw; // [null/range check failed]
                    lVar10 = *(int64 *)(lVar10 + 248);
                    if ((((*pStatics_df90 == 0) ||
                         (lVar3 = *(int64 *)(*pStatics_df90 + 32)) == null
                         ) || (lVar3 = *(int64 *)(lVar3 + 168)) == null) ||
                       (plVar8 = (int64 *)TimeData.Clone(lVar3,0), lVar10 == null)) throw; // [null/range check failed]
                    FUN_1808aec90(lVar10,i,plVar8,DAT_181d99f40);
                  }
                  lVar10 = this.WorldPlotEventDataBase;
                  if (lVar10 != null) {
                    if (lVar10.Count <= i) {
                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                    }
                    lVar10 = *(int64 *)(lVar10._items + 32 + lVar12 * 8);
                    if (lVar10 != null) {
                      iVar2 = *(int *)(lVar10 + 88);
                      if (iVar2 == 1) {
                        lVar10 = this.WorldPlotEventDataBase;
                        lVar7 = **(int64 **)(DAT_181d5a578 + 184);
                        if (lVar10 == null) throw; // [null/range check failed]
                        if (lVar10.Count <= i) {
                          ThrowHelper.ThrowArgumentOutOfRangeException(0);
                        }
                        lVar10 = *(int64 *)(lVar10._items + 32 + lVar12 * 8);
                        if (lVar10 == null) throw; // [null/range check failed]
                        lVar3 = this.WorldPlotEventDataBase;
                        uVar11 = *(uint64 *)(lVar10 + 96);
                        if (lVar3 == null) throw; // [null/range check failed]
                        if (lVar3.Count <= i) {
                          ThrowHelper.ThrowArgumentOutOfRangeException(0);
                        }
                        lVar10 = *(int64 *)(lVar3._items + 32 + lVar12 * 8);
                        if (lVar10 == null) throw; // [null/range check failed]
                        lVar3 = this.WorldPlotEventDataBase;
                        uVar4 = *(uint64 *)(lVar10 + 104);
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
                        *(uint64 *)(lVar3 + 32) = *(uint64 *)(lVar10 + 104);
                        if (*pStatics_0bb8 == 0) throw; // [null/range check failed]
                        WorldEventController.AddNewWorldEvent
                                  (*pStatics_0bb8,*(uint64 *)(lVar7 + 56),0);
                      }
                      lVar10 = this.WorldPlotEventDataBase;
                      if (lVar10 != null) {
                        if (lVar10.Count <= i) {
                          ThrowHelper.ThrowArgumentOutOfRangeException(0);
                        }
                        lVar10 = *(int64 *)(lVar10._items + 32 + lVar12 * 8);
                        if (lVar10 != null) {
                          if (*(int64 *)(lVar10 + 112) == 0) {
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
                                                (*(uint64 *)(lVar10 + 112),"",0);
                              if (!cVar5) {
                                return;
                              }
                              lVar10 = this.WorldPlotEventDataBase;
                              if (lVar10 != null) {
                                if (lVar10.Count <= i) {
                                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                }
                                lVar10 = *(int64 *)(lVar10._items + 32 + lVar12 * 8);
                                if ((lVar10 != null) && (lVar10 = *(int64 *)(lVar10 + 112)) != null)
                                {
                                  cVar5 = String.Contains(lVar10,";",0);
                                  if (!cVar5) {
                                    lVar7 = FUN_18046c440(0);
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
                                        lVar10 = FUN_1800d60b0(DAT_181d7c118,1);
                                        if (lVar10 != null) {
                                          if (lVar10.Count == null) {
                                            uVar11 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                            FUN_1800d65f0(uVar11,0);
                                          }
                                          *(uint16 *)(lVar10 + 32) = 59;
                                          if (lVar12 != null) {
                                            lVar12 = String.Split(lVar12,lVar10,0);
                                            lVar10 = FUN_18046c440(0);
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

    // Token : 0x6002345
    // RVA   : 0xB2B040   Offset: 0xB29840   Length: 0xA3
    public bool CheckMeetWorldEventNeed(List<WorldPlotEventNeedData> needDatas)
    {
        bool cVar1;
        uint uVar2;
        int iVar3;
        long lVar4;
        long lVar8;
        ulong uVar9;
        float fVar10;
        float extraout_XMM0_Da;
        float extraout_XMM0_Da_00;
        float extraout_XMM0_Da_01;
        if (needDatas == null) throw; // [null/range check failed]
        iVar3 = *(int *)(needDatas + 16);
        if (iVar3 != 0) {
          if (iVar3 == 1) {
            lVar4 = FUN_18046c0a0(0);
            if (((lVar4 != null) && (*(int64 *)(lVar4 + 32) != 0)) &&
               (lVar4 = *(int64 *)(*(int64 *)(lVar4 + 32) + 232)) != null) {
              fVar10 = (float)PlotEventLogData.GetFloat(lVar4,*(uint64 *)(needDatas + 24),0);
              if (*(int64 *)(needDatas + 32) != 0) {
                cVar1 = String.Contains(*(int64 *)(needDatas + 32),">",0);
                lVar4 = *(int64 *)(needDatas + 32);
                if (!cVar1) {
                  if (lVar4 != null) {
                    cVar1 = String.Contains(lVar4,"<",0);
                    lVar4 = *(int64 *)(needDatas + 32);
                    if (!cVar1) {
                      Single.Parse(lVar4,0);
                      if (fVar10 == extraout_XMM0_Da) {
                        return true;
                      }
                      return false;
                    }
                    if (lVar4 != null) {
                      uVar9 = String.Replace(lVar4,"<","",0);
                      Single.Parse(uVar9,0);
                      return (uint32)(fVar10 < extraout_XMM0_Da_00);
                    }
                  }
                }
                else if (lVar4 != null) {
                  uVar9 = String.Replace(lVar4,">","",0);
                  Single.Parse(uVar9,0);
                  return (uint32)(extraout_XMM0_Da_01 < fVar10);
                }
              }
            }
            throw; // [null/range check failed]
          }
          if (iVar3 == 2) {
            lVar4 = *(int64 *)(needDatas + 32);
            if (lVar4 != null) {
              cVar1 = FUN_1816fd990(lVar4,"alive",0);
              if (cVar1) {
                lVar4 = FUN_18046c0a0(0);
                if (((lVar4 != null) && (*(int64 *)(lVar4 + 32) != 0)) &&
                   (lVar4 = WorldData.GetHero(*(int64 *)(lVar4 + 32),*(uint64 *)(needDatas + 24)
                                               ,0), lVar4 != null)) {
                  return (uint32)(*(char *)(lVar4 + 97) == false);
                }
                throw; // [null/range check failed]
              }
              cVar1 = FUN_1816fd990(lVar4,"dead",0);
              if (cVar1) {
                lVar4 = FUN_18046c0a0(0);
                if (((lVar4 != null) && (*(int64 *)(lVar4 + 32) != 0)) &&
                   (lVar4 = WorldData.GetHero(*(int64 *)(lVar4 + 32),*(uint64 *)(needDatas + 24)
                                               ,0), lVar4 != null)) {
                  return (uint32)*(byte *)(lVar4 + 97);
                }
                throw; // [null/range check failed]
              }
              cVar1 = FUN_1816fd990(lVar4,"sameforce",0);
              if (cVar1) {
                lVar4 = FUN_18046c0a0(0);
                if (((lVar4 != null) && (*(int64 *)(lVar4 + 32) != 0)) &&
                   (lVar4 = WorldData.GetHero(*(int64 *)(lVar4 + 32),*(uint64 *)(needDatas + 24)
                                               ,0), lVar4 != null)) {
                  iVar3 = *(int *)(lVar4 + 132);
                  lVar4 = FUN_18046c0a0(0);
                  if (((lVar4 != null) && (*(int64 *)(lVar4 + 32) != 0)) &&
                     (lVar4 = WorldData.Player(*(int64 *)(lVar4 + 32),0)) != null) {
                    if (iVar3 != *(int *)(lVar4 + 132)) {
                      return false;
                    }
                    lVar4 = FUN_18046c0a0(0);
                    if (((lVar4 != null) && (*(int64 *)(lVar4 + 32) != 0)) &&
                       (lVar4 = WorldData.Player(*(int64 *)(lVar4 + 32),0)) != null) {
                      return *(uint32 *)(lVar4 + 132) >> 31 ^ 1;
                    }
                  }
                }
                throw; // [null/range check failed]
              }
            }
          }
          else if (iVar3 == 3) {
            cVar1 = FUN_1816fd990(*(uint64 *)(needDatas + 32),"0",0);
            if (cVar1) {
              lVar4 = FUN_18046c0a0(0);
              if ((lVar4 == null) || (*(int64 *)(lVar4 + 32) == 0)) throw; // [null/range check failed]
              lVar4 = *(int64 *)(*(int64 *)(lVar4 + 32) + 224);
              uVar2 = Int32.Parse(*(uint64 *)(needDatas + 24),0);
              if (lVar4 == null) throw; // [null/range check failed]
              cVar1 = FUN_181815240(lVar4,uVar2,DAT_181d67bf8);
              if (cVar1) {
                return false;
              }
            }
            cVar1 = FUN_1816fd990(*(uint64 *)(needDatas + 32),"1",0);
            if (!cVar1) {
              return true;
            }
            lVar4 = FUN_18046c0a0(0);
            if ((lVar4 != null) && (*(int64 *)(lVar4 + 32) != 0)) {
              lVar4 = *(int64 *)(*(int64 *)(lVar4 + 32) + 224);
              uVar2 = Int32.Parse(*(uint64 *)(needDatas + 24),0);
              if (lVar4 != null) {
                cVar1 = FUN_181815240(lVar4,uVar2,DAT_181d67bf8);
                if (!cVar1) {
                  return false;
                }
                return true;
              }
            }
            throw; // [null/range check failed]
          }
          plVar5 = (int64 *)FUN_1800d60b0(DAT_181d80cc0,6);
          if (plVar5 != (int64 *)0) {
            if (("Unknown WorldEventNeedData! " != 0) &&
               (lVar4 = il2cpp_internal("Unknown WorldEventNeedData! ",*(uint64 *)(*plVar5 + 64))) == null) {
              uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar9,0);
            }
            lVar4 = "Unknown WorldEventNeedData! ";
            if ((int)plVar5[3] == 0) {
              uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar9,0);
            }
            plVar5[4] = "Unknown WorldEventNeedData! ";
            il2cpp_internal(plVar5 + 4,lVar4);
            plVar6 = (int64 *)il2cpp_value_box(DAT_181d90d50,needDatas + 16);
            if (plVar6 != (int64 *)0) {
              lVar4 = (**(code **)(*plVar6 + 0x168))(plVar6,*(uint64 *)(*plVar6 + 0x170));
              puVar7 = (uint32 *)il2cpp_object_unbox(plVar6);
              *(uint32 *)(needDatas + 16) = *puVar7;
              if ((lVar4 != null) &&
                 (lVar8 = il2cpp_internal(lVar4,*(uint64 *)(*plVar5 + 64))) == null) {
                uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar9,0);
              }
              if (*(uint32 *)(plVar5 + 3) < 2) {
                uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar9,0);
              }
              plVar5[5] = lVar4;
              il2cpp_internal(plVar5 + 5,lVar4);
              if ((":" != 0) &&
                 (lVar4 = il2cpp_internal(":",*(uint64 *)(*plVar5 + 64))) == null)
              {
                uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar9,0);
              }
              lVar4 = ":";
              if (*(uint32 *)(plVar5 + 3) < 3) {
                uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar9,0);
              }
              plVar5[6] = ":";
              il2cpp_internal(plVar5 + 6,lVar4);
              lVar4 = *(int64 *)(needDatas + 24);
              if ((lVar4 != null) &&
                 (lVar8 = il2cpp_internal(lVar4,*(uint64 *)(*plVar5 + 64))) == null) {
                uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar9,0);
              }
              if (*(uint32 *)(plVar5 + 3) < 4) {
                uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar9,0);
              }
              plVar5[7] = lVar4;
              il2cpp_internal(plVar5 + 7,lVar4);
              if ((":" != 0) &&
                 (lVar4 = il2cpp_internal(":",*(uint64 *)(*plVar5 + 64))) == null)
              {
                uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar9,0);
              }
              lVar4 = ":";
              if (*(uint32 *)(plVar5 + 3) < 5) {
                uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar9,0);
              }
              plVar5[8] = ":";
              il2cpp_internal(plVar5 + 8,lVar4);
              lVar4 = *(int64 *)(needDatas + 32);
              if ((lVar4 != null) &&
                 (lVar8 = il2cpp_internal(lVar4,*(uint64 *)(*plVar5 + 64))) == null) {
                uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar9,0);
              }
              if (*(uint32 *)(plVar5 + 3) < 6) {
                uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar9,0);
              }
              plVar5[9] = lVar4;
              il2cpp_internal(plVar5 + 9,lVar4);
              uVar9 = String.Concat(plVar5,0);
              Debug.Log(uVar9,0);
              return true;
            }
          }
          throw; // [null/range check failed]
        }
        cVar1 = FUN_1816fd990(*(uint64 *)(needDatas + 32),"0",0);
        if (cVar1) {
          lVar4 = FUN_18046c0a0(0);
          if ((lVar4 == null) || (*(int64 *)(lVar4 + 32) == 0)) throw; // [null/range check failed]
          lVar4 = *(int64 *)(*(int64 *)(lVar4 + 32) + 216);
          uVar2 = Int32.Parse(*(uint64 *)(needDatas + 24),0);
          if (lVar4 == null) throw; // [null/range check failed]
          cVar1 = FUN_1808ab750(lVar4,uVar2,DAT_181d99e30);
          if (cVar1) {
            return false;
          }
        }
        cVar1 = FUN_1816fd990(*(uint64 *)(needDatas + 32),"1",0);
        if (!cVar1) {
          return true;
        }
        lVar4 = FUN_18046c0a0(0);
        if ((lVar4 != null) && (*(int64 *)(lVar4 + 32) != 0)) {
          lVar4 = *(int64 *)(*(int64 *)(lVar4 + 32) + 216);
          uVar2 = Int32.Parse(*(uint64 *)(needDatas + 24),0);
          if (lVar4 != null) {
            cVar1 = FUN_1808ab750(lVar4,uVar2,DAT_181d99e30);
            if (!cVar1) {
              return false;
            }
            lVar4 = FUN_18046c0a0(0);
            if ((lVar4 != null) && (*(int64 *)(lVar4 + 32) != 0)) {
              lVar4 = *(int64 *)(*(int64 *)(lVar4 + 32) + 168);
              lVar8 = FUN_18046c0a0(0);
              if ((lVar8 != null) && (*(int64 *)(lVar8 + 32) != 0)) {
                lVar8 = *(int64 *)(*(int64 *)(lVar8 + 32) + 216);
                uVar2 = Int32.Parse(*(uint64 *)(needDatas + 24),0);
                if ((lVar8 != null) && (uVar9 = FUN_1817cc780(lVar8,uVar2,DAT_181d99eb8), lVar4 != null)) {
                  iVar3 = TimeData.DeltaDay(lVar4,uVar9,0);
                  if (iVar3 < 10) {
                    return false;
                  }
                  return true;
                }
              }
            }
          }
        }
    }

    // Token : 0x6002346
    // RVA   : 0xB2B0F0   Offset: 0xB298F0   Length: 0x9F5
    public bool CheckMeetWorldEventNeed(WorldPlotEventNeedData needData)
    {
        bool cVar1;
        uint uVar2;
        int iVar3;
        long lVar4;
        long lVar8;
        ulong uVar9;
        float fVar10;
        float extraout_XMM0_Da;
        float extraout_XMM0_Da_00;
        float extraout_XMM0_Da_01;
        if (needData == null) throw; // [null/range check failed]
        iVar3 = *(int *)(needData + 16);
        if (iVar3 != 0) {
          if (iVar3 == 1) {
            lVar4 = FUN_18046c0a0(0);
            if (((lVar4 != null) && (*(int64 *)(lVar4 + 32) != 0)) &&
               (lVar4 = *(int64 *)(*(int64 *)(lVar4 + 32) + 232)) != null) {
              fVar10 = (float)PlotEventLogData.GetFloat(lVar4,*(uint64 *)(needData + 24),0);
              if (*(int64 *)(needData + 32) != 0) {
                cVar1 = String.Contains(*(int64 *)(needData + 32),">",0);
                lVar4 = *(int64 *)(needData + 32);
                if (!cVar1) {
                  if (lVar4 != null) {
                    cVar1 = String.Contains(lVar4,"<",0);
                    lVar4 = *(int64 *)(needData + 32);
                    if (!cVar1) {
                      Single.Parse(lVar4,0);
                      if (fVar10 == extraout_XMM0_Da) {
                        return true;
                      }
                      return false;
                    }
                    if (lVar4 != null) {
                      uVar9 = String.Replace(lVar4,"<","",0);
                      Single.Parse(uVar9,0);
                      return (uint32)(fVar10 < extraout_XMM0_Da_00);
                    }
                  }
                }
                else if (lVar4 != null) {
                  uVar9 = String.Replace(lVar4,">","",0);
                  Single.Parse(uVar9,0);
                  return (uint32)(extraout_XMM0_Da_01 < fVar10);
                }
              }
            }
            throw; // [null/range check failed]
          }
          if (iVar3 == 2) {
            lVar4 = *(int64 *)(needData + 32);
            if (lVar4 != null) {
              cVar1 = FUN_1816fd990(lVar4,"alive",0);
              if (cVar1) {
                lVar4 = FUN_18046c0a0(0);
                if (((lVar4 != null) && (*(int64 *)(lVar4 + 32) != 0)) &&
                   (lVar4 = WorldData.GetHero(*(int64 *)(lVar4 + 32),*(uint64 *)(needData + 24)
                                               ,0), lVar4 != null)) {
                  return (uint32)(*(char *)(lVar4 + 97) == false);
                }
                throw; // [null/range check failed]
              }
              cVar1 = FUN_1816fd990(lVar4,"dead",0);
              if (cVar1) {
                lVar4 = FUN_18046c0a0(0);
                if (((lVar4 != null) && (*(int64 *)(lVar4 + 32) != 0)) &&
                   (lVar4 = WorldData.GetHero(*(int64 *)(lVar4 + 32),*(uint64 *)(needData + 24)
                                               ,0), lVar4 != null)) {
                  return (uint32)*(byte *)(lVar4 + 97);
                }
                throw; // [null/range check failed]
              }
              cVar1 = FUN_1816fd990(lVar4,"sameforce",0);
              if (cVar1) {
                lVar4 = FUN_18046c0a0(0);
                if (((lVar4 != null) && (*(int64 *)(lVar4 + 32) != 0)) &&
                   (lVar4 = WorldData.GetHero(*(int64 *)(lVar4 + 32),*(uint64 *)(needData + 24)
                                               ,0), lVar4 != null)) {
                  iVar3 = *(int *)(lVar4 + 132);
                  lVar4 = FUN_18046c0a0(0);
                  if (((lVar4 != null) && (*(int64 *)(lVar4 + 32) != 0)) &&
                     (lVar4 = WorldData.Player(*(int64 *)(lVar4 + 32),0)) != null) {
                    if (iVar3 != *(int *)(lVar4 + 132)) {
                      return false;
                    }
                    lVar4 = FUN_18046c0a0(0);
                    if (((lVar4 != null) && (*(int64 *)(lVar4 + 32) != 0)) &&
                       (lVar4 = WorldData.Player(*(int64 *)(lVar4 + 32),0)) != null) {
                      return *(uint32 *)(lVar4 + 132) >> 31 ^ 1;
                    }
                  }
                }
                throw; // [null/range check failed]
              }
            }
          }
          else if (iVar3 == 3) {
            cVar1 = FUN_1816fd990(*(uint64 *)(needData + 32),"0",0);
            if (cVar1) {
              lVar4 = FUN_18046c0a0(0);
              if ((lVar4 == null) || (*(int64 *)(lVar4 + 32) == 0)) throw; // [null/range check failed]
              lVar4 = *(int64 *)(*(int64 *)(lVar4 + 32) + 224);
              uVar2 = Int32.Parse(*(uint64 *)(needData + 24),0);
              if (lVar4 == null) throw; // [null/range check failed]
              cVar1 = FUN_181815240(lVar4,uVar2,DAT_181d67bf8);
              if (cVar1) {
                return false;
              }
            }
            cVar1 = FUN_1816fd990(*(uint64 *)(needData + 32),"1",0);
            if (!cVar1) {
              return true;
            }
            lVar4 = FUN_18046c0a0(0);
            if ((lVar4 != null) && (*(int64 *)(lVar4 + 32) != 0)) {
              lVar4 = *(int64 *)(*(int64 *)(lVar4 + 32) + 224);
              uVar2 = Int32.Parse(*(uint64 *)(needData + 24),0);
              if (lVar4 != null) {
                cVar1 = FUN_181815240(lVar4,uVar2,DAT_181d67bf8);
                if (!cVar1) {
                  return false;
                }
                return true;
              }
            }
            throw; // [null/range check failed]
          }
          plVar5 = (int64 *)FUN_1800d60b0(DAT_181d80cc0,6);
          if (plVar5 != (int64 *)0) {
            if (("Unknown WorldEventNeedData! " != 0) &&
               (lVar4 = il2cpp_internal("Unknown WorldEventNeedData! ",*(uint64 *)(*plVar5 + 64))) == null) {
              uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar9,0);
            }
            lVar4 = "Unknown WorldEventNeedData! ";
            if ((int)plVar5[3] == 0) {
              uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar9,0);
            }
            plVar5[4] = "Unknown WorldEventNeedData! ";
            il2cpp_internal(plVar5 + 4,lVar4);
            plVar6 = (int64 *)il2cpp_value_box(DAT_181d90d50,needData + 16);
            if (plVar6 != (int64 *)0) {
              lVar4 = (**(code **)(*plVar6 + 0x168))(plVar6,*(uint64 *)(*plVar6 + 0x170));
              puVar7 = (uint32 *)il2cpp_object_unbox(plVar6);
              *(uint32 *)(needData + 16) = *puVar7;
              if ((lVar4 != null) &&
                 (lVar8 = il2cpp_internal(lVar4,*(uint64 *)(*plVar5 + 64))) == null) {
                uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar9,0);
              }
              if (*(uint32 *)(plVar5 + 3) < 2) {
                uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar9,0);
              }
              plVar5[5] = lVar4;
              il2cpp_internal(plVar5 + 5,lVar4);
              if ((":" != 0) &&
                 (lVar4 = il2cpp_internal(":",*(uint64 *)(*plVar5 + 64))) == null)
              {
                uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar9,0);
              }
              lVar4 = ":";
              if (*(uint32 *)(plVar5 + 3) < 3) {
                uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar9,0);
              }
              plVar5[6] = ":";
              il2cpp_internal(plVar5 + 6,lVar4);
              lVar4 = *(int64 *)(needData + 24);
              if ((lVar4 != null) &&
                 (lVar8 = il2cpp_internal(lVar4,*(uint64 *)(*plVar5 + 64))) == null) {
                uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar9,0);
              }
              if (*(uint32 *)(plVar5 + 3) < 4) {
                uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar9,0);
              }
              plVar5[7] = lVar4;
              il2cpp_internal(plVar5 + 7,lVar4);
              if ((":" != 0) &&
                 (lVar4 = il2cpp_internal(":",*(uint64 *)(*plVar5 + 64))) == null)
              {
                uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar9,0);
              }
              lVar4 = ":";
              if (*(uint32 *)(plVar5 + 3) < 5) {
                uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar9,0);
              }
              plVar5[8] = ":";
              il2cpp_internal(plVar5 + 8,lVar4);
              lVar4 = *(int64 *)(needData + 32);
              if ((lVar4 != null) &&
                 (lVar8 = il2cpp_internal(lVar4,*(uint64 *)(*plVar5 + 64))) == null) {
                uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar9,0);
              }
              if (*(uint32 *)(plVar5 + 3) < 6) {
                uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar9,0);
              }
              plVar5[9] = lVar4;
              il2cpp_internal(plVar5 + 9,lVar4);
              uVar9 = String.Concat(plVar5,0);
              Debug.Log(uVar9,0);
              return true;
            }
          }
          throw; // [null/range check failed]
        }
        cVar1 = FUN_1816fd990(*(uint64 *)(needData + 32),"0",0);
        if (cVar1) {
          lVar4 = FUN_18046c0a0(0);
          if ((lVar4 == null) || (*(int64 *)(lVar4 + 32) == 0)) throw; // [null/range check failed]
          lVar4 = *(int64 *)(*(int64 *)(lVar4 + 32) + 216);
          uVar2 = Int32.Parse(*(uint64 *)(needData + 24),0);
          if (lVar4 == null) throw; // [null/range check failed]
          cVar1 = FUN_1808ab750(lVar4,uVar2,DAT_181d99e30);
          if (cVar1) {
            return false;
          }
        }
        cVar1 = FUN_1816fd990(*(uint64 *)(needData + 32),"1",0);
        if (!cVar1) {
          return true;
        }
        lVar4 = FUN_18046c0a0(0);
        if ((lVar4 != null) && (*(int64 *)(lVar4 + 32) != 0)) {
          lVar4 = *(int64 *)(*(int64 *)(lVar4 + 32) + 216);
          uVar2 = Int32.Parse(*(uint64 *)(needData + 24),0);
          if (lVar4 != null) {
            cVar1 = FUN_1808ab750(lVar4,uVar2,DAT_181d99e30);
            if (!cVar1) {
              return false;
            }
            lVar4 = FUN_18046c0a0(0);
            if ((lVar4 != null) && (*(int64 *)(lVar4 + 32) != 0)) {
              lVar4 = *(int64 *)(*(int64 *)(lVar4 + 32) + 168);
              lVar8 = FUN_18046c0a0(0);
              if ((lVar8 != null) && (*(int64 *)(lVar8 + 32) != 0)) {
                lVar8 = *(int64 *)(*(int64 *)(lVar8 + 32) + 216);
                uVar2 = Int32.Parse(*(uint64 *)(needData + 24),0);
                if ((lVar8 != null) && (uVar9 = FUN_1817cc780(lVar8,uVar2,DAT_181d99eb8), lVar4 != null)) {
                  iVar3 = TimeData.DeltaDay(lVar4,uVar9,0);
                  if (iVar3 < 10) {
                    return false;
                  }
                  return true;
                }
              }
            }
          }
        }
    }

    // Token : 0x6002347
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
