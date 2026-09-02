// ============================================================
// Type  : WorldEventController
// Token : 0x20003B0
// ============================================================

public class WorldEventController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001D12
    private List<WorldEventDataBase> worldEventDataBase;

    // Token: 0x4001D13
    private static WorldEventController _instance;

    // Token: 0x4001D14
    private static readonly List<string> tutorialWorldEventName;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002330
    // RVA   : 0xB2A360   Offset: 0xB28B60   Length: 0x57
    public static WorldEventController get_Instance()
    {
        return **(uint64 **)(DAT_181d90bb8 + 184);
    }

    // Token : 0x6002331
    // RVA   : 0xB289C0   Offset: 0xB271C0   Length: 0x11F
    private void Awake()
    {
        var pStatics = *(int64*)(DAT_181d744e0 + 184);
        ulong uVar1;
        bool cVar3;
        uVar1 = **(uint64 **)(DAT_181d90bb8 + 184);
        cVar3 = Object.op_Equality(uVar1,0,0);
        if (cVar3) {
          plVar2 = *(int64 **)(DAT_181d90bb8 + 184);
          *plVar2 = this;
          il2cpp_internal(plVar2,this);
          if (*pStatics == 0) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          this.worldEventDataBase = *(uint64 *)(*pStatics + 40);
        }
    }

    // Token : 0x6002332
    // RVA   : 0xB29CD0   Offset: 0xB284D0   Length: 0x56B
    public void ManageWorldEvent()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        int iVar2;
        uint uVar3;
        long lVar4;
        long lVar5;
        long lVar6;
        ulong uVar7;
        int iVar8;
        uint uVar9;
        float fVar10;
        double dVar11;
        lVar4 = il2cpp_internal(DAT_181d6f030);
        FUN_180f58a90(lVar4);
        lVar5 = this.worldEventDataBase;
        iVar8 = 0;
        if (lVar5 != null) {
          while (iVar8 < lVar5.Count) {
            lVar5 = FUN_18046c0a0(0);
            if ((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) throw; // [null/range check failed]
            lVar5 = *(int64 *)(*(int64 *)(lVar5 + 32) + 168);
            if ((this.worldEventDataBase == null) ||
               ((lVar6 = FUN_180002f80(this.worldEventDataBase,iVar8,DAT_181d84ff8), lVar6 == null ||
                (lVar5 == null)))) throw; // [null/range check failed]
            iVar2 = TimeData.DeltaDay(lVar5,*(uint64 *)(lVar6 + 32),0);
            if ((this.worldEventDataBase == null) ||
               (lVar5 = FUN_180002f80(this.worldEventDataBase,iVar8)) == null)
            throw; // [null/range check failed]
            if (*(int *)(lVar5 + 48) == 0) {
              if ((this.worldEventDataBase == null) ||
                 (lVar5 = FUN_180002f80(this.worldEventDataBase,iVar8)) == null)
              throw; // [null/range check failed]
              if ((*(int *)(lVar5 + 56) == 0) && (-1 < iVar2)) {
                if ((this.worldEventDataBase == null) ||
                   (lVar5 = FUN_180002f80(this.worldEventDataBase,iVar8)) == null)
                throw; // [null/range check failed]
                if (iVar2 % *(int *)(lVar5 + 52) == 0) {
                  if (this.worldEventDataBase == null) throw; // [null/range check failed]
                  uVar7 = FUN_180002f80(this.worldEventDataBase,iVar8);
                  WorldEventController.CreateWorldEvent(this,uVar7);
                }
              }
            }
            lVar5 = FUN_18046c0a0(0);
            if (((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) ||
               (lVar5 = *(int64 *)(*(int64 *)(lVar5 + 32) + 168)) == null)
            throw; // [null/range check failed]
            if (lVar5._items < 2) {
              lVar5 = FUN_18046c0a0(0);
              if (((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) ||
                 (lVar5 = *(int64 *)(*(int64 *)(lVar5 + 32) + 168)) == null)
              throw; // [null/range check failed]
              if (3 >= *(int *)(lVar5 + 20))
              {
                }
                else {
              }
              if ((this.worldEventDataBase == null) ||
                 (lVar5 = FUN_180002f80(this.worldEventDataBase,iVar8)) == null)
              throw; // [null/range check failed]
              if ((*(int *)(lVar5 + 48) == 1) && (-1 < iVar2)) {
                if (lVar4 == null) throw; // [null/range check failed]
                FUN_181814fa0(lVar4,iVar8);
              }
            }
            lVar5 = this.worldEventDataBase;
            iVar8 = iVar8 + 1;
            if (lVar5 == null) throw; // [null/range check failed]
          }
          if (lVar4 != null) {
            if (0 < *(int *)(lVar4 + 24)) {
              dVar11 = (double)GlobalData.RandomRangeDouble(0,0);
              lVar5 = FUN_18046c0a0(0);
              if ((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) throw; // [null/range check failed]
              iVar8 = *(int *)(*(int64 *)(lVar5 + 32) + 112);
              lVar5 = FUN_18046c0a0(0);
              if ((lVar5 == null) ||
                 ((*(int64 *)(lVar5 + 32) == 0 ||
                  (lVar5 = *(int64 *)(*(int64 *)(lVar5 + 32) + 168)) == null)))
              throw; // [null/range check failed]
              iVar2 = lVar5._items;
              uVar9 = GameController.GetGameMaxDifficulty(0);
              fVar10 = (float)FUN_1810a8ba0(((float)iVar2 - 1.0) * 0.5,0,uVar9,0);
              if (dVar11 <= (double)((fVar10 * 0.001 + 0.01) * (float)iVar8)) {
                lVar5 = FUN_18046c0a0(0);
                if ((lVar5 != null) && (*(int64 *)(lVar5 + 32) != 0)) {
                  *(uint32 *)(*(int64 *)(lVar5 + 32) + 112) = 0;
                  lVar5 = this.worldEventDataBase;
                  uVar9 = *(uint32 *)(lVar4 + 24);
                  uVar3 = GlobalData.RandomRange(0,uVar9,0,0);
                  if (*(uint32 *)(lVar4 + 24) <= uVar3) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  if (lVar5 != null) {
                    uVar3 = lVar4[uVar3];
                    if (lVar5.Count <= uVar3) {
                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                    }
                    WorldEventController.CreateWorldEvent
                              (this,*(uint64 *)
                                        (lVar5._items + 32 + (int64)(int)uVar3 * 8),0)
                    ;
                    return;
                  }
                }
                throw; // [null/range check failed]
              }
            }
            if ((*pStatics != 0) &&
               (lVar5 = *(int64 *)(*pStatics + 32)) != null) {
              piVar1 = (int *)(lVar5 + 112);
              *piVar1 = *piVar1 + 1;
              return;
            }
          }
        }
    }

    // Token : 0x6002333
    // RVA   : 0xB28AE0   Offset: 0xB272E0   Length: 0x27E
    public EventData CreateRandomWorldEvent(bool limitStartTime)
    {
        int iVar1;
        uint uVar2;
        long lVar3;
        long lVar4;
        long lVar5;
        ulong uVar6;
        ulong uVar7;
        long lVar8;
        uVar6 = 0;
        lVar3 = il2cpp_internal(DAT_181d6f030);
        FUN_180f58a90(lVar3,DAT_181d678f8);
        lVar4 = this.worldEventDataBase;
        if (lVar4 != null) {
          lVar8 = 32;
          uVar7 = uVar6;
          while (uVar2 = (uint32)uVar7, (int)uVar2 < lVar4.Count) {
            if (lVar4 == null) throw; // [null/range check failed]
            if (lVar4.Count <= uVar2) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar4 = *(int64 *)(lVar8 + lVar4._items);
            if (lVar4 == null) throw; // [null/range check failed]
            if (*(int *)(lVar4 + 48) == 1) {
              if (limitStartTime) {
                lVar4 = FUN_18046c0a0(0);
                if ((lVar4 == null) || (*(int64 *)(lVar4 + 32) == 0)) throw; // [null/range check failed]
                lVar4 = *(int64 *)(*(int64 *)(lVar4 + 32) + 168);
                if ((this.worldEventDataBase == null) ||
                   ((lVar5 = FUN_180002f80(this.worldEventDataBase,uVar7), lVar5 == null ||
                    (lVar4 == null)))) throw; // [null/range check failed]
                iVar1 = TimeData.DeltaDay(lVar4,*(uint64 *)(lVar5 + 32));
                if (iVar1 >= 0)
                {
                  }
                  if (lVar3 == null) throw; // [null/range check failed]
                  FUN_181814fa0(lVar3,uVar7);
                  }
                }
            lVar4 = this.worldEventDataBase;
            uVar7 = (uint64)(uVar2 + 1);
            lVar8 = lVar8 + 8;
            if (lVar4 == null) throw; // [null/range check failed]
          }
          if (lVar3 != null) {
            iVar1 = *(int *)(lVar3 + 24);
            if (0 < iVar1) {
              uVar2 = GlobalData.RandomRange(0,iVar1,0,0);
              if (*(uint32 *)(lVar3 + 24) <= uVar2) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              if (lVar4 == null) throw; // [null/range check failed]
              uVar2 = lVar3[uVar2];
              if (lVar4.Count <= uVar2) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              uVar6 = WorldEventController.CreateWorldEvent
                                (this,*(uint64 *)
                                          (lVar4._items + 32 + (int64)(int)uVar2 * 8),
                                 0);
            }
            return uVar6;
          }
        }
    }

    // Token : 0x6002334
    // RVA   : 0xB28D60   Offset: 0xB27560   Length: 0x6A7
    public EventData CreateWorldEvent(WorldEventDataBase targetWorldEventDataBase)
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        int64 *
        WorldEventController.CreateWorldEvent
                (uint64 this,int64 targetWorldEventDataBase,uint64 param_3,uint32 param_4,
                uint32 param_5,uint32 param_6,char param_7)
        {
        int64 *plVar1;
        if (targetWorldEventDataBase != null) {
          plVar1 = (int64 *)EventData.Clone(targetWorldEventDataBase,0);
          if (plVar1 != (int64 *)0) {
            *(uint32 *)((int64)plVar1 + 108) = param_5;
            *(uint32 *)(plVar1 + 13) = param_4;
            *(uint32 *)((int64)plVar1 + 116) = param_6;
            if (!param_7) {
              if (*pStatics == 0) throw; // [null/range check failed]
              GameController.CreateAreaMapRandomEvent
                        (*pStatics,plVar1,param_3,0);
            }
            else {
              if (*pStatics == 0) throw; // [null/range check failed]
              GameController.CreateBigMapRandomEvent
                        (*pStatics,plVar1,param_3,0);
            }
            WorldEventController.AddNewWorldEvent(this,plVar1,0);
            return plVar1;
          }
        }
    }

    // Token : 0x6002335
    // RVA   : 0xB29790   Offset: 0xB27F90   Length: 0x317
    public float GetWorldEventRandomDifficulty(WorldEventDataBase targetWorldEventDataBase)
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        float fVar1;
        int iVar2;
        long lVar3;
        float fVar4;
        if (targetWorldEventDataBase != null) {
          if ((*(char *)(targetWorldEventDataBase + 64) == false) || (*(int *)(targetWorldEventDataBase + 68) < 0)) {
            if (((*pStatics != 0) &&
                (lVar3 = *(int64 *)(*pStatics + 32)) != null) &&
               (lVar3 = *(int64 *)(lVar3 + 168)) != null) {
              if (*(int *)(lVar3 + 16) < 2) {
                if (((*pStatics == 0) ||
                    (lVar3 = *(int64 *)(*pStatics + 32)) == null) ||
                   (lVar3 = *(int64 *)(lVar3 + 168)) == null) throw; // [null/range check failed]
                iVar2 = *(int *)(lVar3 + 20);
                if ((*pStatics == 0) ||
                   (lVar3 = *(int64 *)(*pStatics + 32)) == null)
                throw; // [null/range check failed]
                if ((float)iVar2 <= 7.0 - (float)*(int *)(lVar3 + 160) * 0.5) {
                  return 0.0;
                }
              }
              if (*(int64 *)(targetWorldEventDataBase + 88) != 0) {
                fVar1 = *(float *)(*(int64 *)(targetWorldEventDataBase + 88) + 112);
                if (*(char *)(targetWorldEventDataBase + 64) == false) {
                  lVar3 = FUN_18046c0a0(0);
                  if (lVar3 != null) {
                    fVar4 = (float)GameController.GetTimeRandomDifficulty(lVar3);
                    return fVar1 * fVar4;
                  }
                }
                else {
                  if (*(int *)(targetWorldEventDataBase + 68) != -1) {
                    return fVar1 * (float)*(int *)(targetWorldEventDataBase + 68);
                  }
                  lVar3 = FUN_18046c0a0(0);
                  if (lVar3 != null) {
                    fVar4 = (float)GameController.GetTimeDifficulty(lVar3,0);
                    return fVar1 * fVar4;
                  }
                }
              }
            }
          }
          else if (*(int64 *)(targetWorldEventDataBase + 88) != 0) {
            return (float)*(int *)(targetWorldEventDataBase + 68) * *(float *)(*(int64 *)(targetWorldEventDataBase + 88) + 112);
          }
        }
    }

    // Token : 0x6002336
    // RVA   : 0xB29620   Offset: 0xB27E20   Length: 0x16A
    public EventData CreateWorldEvent(EventData targetEvent, ResourcePointData targetResourcePoint, int lastTime, float difficulty, int speTargetID)
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        int64 *
        WorldEventController.CreateWorldEvent
                (uint64 this,int64 targetEvent,uint64 targetResourcePoint,uint32 lastTime,
                uint32 difficulty,uint32 speTargetID,char param_7)
        {
        int64 *plVar1;
        if (targetEvent != null) {
          plVar1 = (int64 *)EventData.Clone(targetEvent,0);
          if (plVar1 != (int64 *)0) {
            *(uint32 *)((int64)plVar1 + 108) = difficulty;
            *(uint32 *)(plVar1 + 13) = lastTime;
            *(uint32 *)((int64)plVar1 + 116) = speTargetID;
            if (!param_7) {
              if (*pStatics == 0) throw; // [null/range check failed]
              GameController.CreateAreaMapRandomEvent
                        (*pStatics,plVar1,targetResourcePoint,0);
            }
            else {
              if (*pStatics == 0) throw; // [null/range check failed]
              GameController.CreateBigMapRandomEvent
                        (*pStatics,plVar1,targetResourcePoint,0);
            }
            WorldEventController.AddNewWorldEvent(this,plVar1,0);
            return plVar1;
          }
        }
    }

    // Token : 0x6002337
    // RVA   : 0xB29410   Offset: 0xB27C10   Length: 0x202
    public EventData CreateWorldEvent(EventData targetEvent, List<int> targetAreaIDList, int lastTime, float difficulty, int speTargetID, bool isBigMapEvent)
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        int64 *
        WorldEventController.CreateWorldEvent
                (uint64 this,int64 targetEvent,uint64 targetAreaIDList,uint32 lastTime,
                uint32 difficulty,uint32 speTargetID,char isBigMapEvent)
        {
        int64 *plVar1;
        if (targetEvent != null) {
          plVar1 = (int64 *)EventData.Clone(targetEvent,0);
          if (plVar1 != (int64 *)0) {
            *(uint32 *)((int64)plVar1 + 108) = difficulty;
            *(uint32 *)(plVar1 + 13) = lastTime;
            *(uint32 *)((int64)plVar1 + 116) = speTargetID;
            if (!isBigMapEvent) {
              if (*pStatics == 0) throw; // [null/range check failed]
              GameController.CreateAreaMapRandomEvent
                        (*pStatics,plVar1,targetAreaIDList,0);
            }
            else {
              if (*pStatics == 0) throw; // [null/range check failed]
              GameController.CreateBigMapRandomEvent
                        (*pStatics,plVar1,targetAreaIDList,0);
            }
            WorldEventController.AddNewWorldEvent(this,plVar1,0);
            return plVar1;
          }
        }
    }

    // Token : 0x6002338
    // RVA   : 0xB287A0   Offset: 0xB26FA0   Length: 0x212
    public void AddNewWorldEvent(EventData newRandomEvent)
    {
        var pStatics_5970 = *(int64*)(DAT_181d65970 + 184);
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        long lVar1;
        ulong uVar2;
        ulong local_18;
        ulong uStack_10;
        if (((*pStatics_df90 != 0) &&
            (lVar1 = *(int64 *)(*pStatics_df90 + 32)) != null) &&
           (lVar1 = *(int64 *)(lVar1 + 128)) != null) {
          FUN_181827900(lVar1,newRandomEvent,DAT_181d5e380);
          lVar1 = **(int64 **)(DAT_181d5a578 + 184);
          if (newRandomEvent != null) {
            uVar2 = EventData.Name(newRandomEvent,0);
            uVar2 = String.Format("新的江湖传闻：{0}",uVar2,0);
            if (lVar1 != null) {
              local_18 = 0;
              uStack_10 = 0;
              InfoController.AddInfoTab
                        (lVar1,uVar2,"UIAtlas","资源_占领地","PencilWriting",0x3f800000,0x40a00000,
                         &local_18,0);
              if (*pStatics_5970 != 0) {
                *(uint8 *)(*pStatics_5970 + 160) = 1;
                return;
              }
            }
          }
        }
    }

    // Token : 0x6002339
    // RVA   : 0xB29AB0   Offset: 0xB282B0   Length: 0x211
    public bool HaveTutorialWorldEvent()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        long lVar1;
        bool cVar2;
        long lVar3;
        int iVar4;
        iVar4 = 0;
        while( true ) {
          if (((*pStatics == 0) ||
              (lVar1 = *(int64 *)(*pStatics + 32)) == null) ||
             (lVar1 = *(int64 *)(lVar1 + 128)) == null) break;
          if (*(int *)(lVar1 + 24) <= iVar4) {
            return false;
          }
          lVar1 = *(int64 *)(*(int64 *)(DAT_181d90bb8 + 184) + 8);
          if (((*pStatics == 0) ||
              (lVar3 = *(int64 *)(*pStatics + 32)) == null) ||
             (lVar3 = *(int64 *)(lVar3 + 128)) == null) break;
          lVar3 = FUN_180002f80(lVar3,iVar4,DAT_181d5e680);
          if ((lVar3 == null) || (lVar1 == null)) break;
          cVar2 = FUN_1818279a0(lVar1,*(uint64 *)(lVar3 + 24),DAT_181d7c4d0);
          if (cVar2) {
            return true;
          }
          iVar4 = iVar4 + 1;
        }
    }

    // Token : 0x600233A
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

    // Token : 0x600233B
    // RVA   : 0xB2A240   Offset: 0xB28A40   Length: 0x118
    private static void /*cctor*/()
    {
        long lVar1;
        lVar1 = il2cpp_internal(DAT_181d72a30);
        FUN_180f58a90(lVar1,DAT_181d7c250);
        if (lVar1 != null) {
          FUN_181827900(lVar1,"异草奇花",DAT_181d7c3d0);
          FUN_181827900(lVar1,"仙木灵果",DAT_181d7c3d0);
          FUN_181827900(lVar1,"失落宝藏",DAT_181d7c3d0);
          FUN_181827900(lVar1,"神兵现世",DAT_181d7c3d0);
          plVar2 = (int64 *)(*(int64 *)(DAT_181d90bb8 + 184) + 8);
          *plVar2 = lVar1;
          il2cpp_internal(plVar2,lVar1);
          return;
        }
    }

}
