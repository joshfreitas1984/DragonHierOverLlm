// ============================================================
// Type  : MapNavigator
// Token : 0x200018D
// ============================================================

public class MapNavigator
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000AD3
    private static MapNavigator instance;

    // Token: 0x4000AD4
    private int curUsedIdx;

    // Token: 0x4000AD5
    private List<NavigationData> navigationDataPool;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000CBA
    // RVA   : 0x210B70   Offset: 0x20FF70   Length: 0x7
    private void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x6000CBB
    // RVA   : 0xA8DCD0   Offset: 0xA8D0D0   Length: 0x17A
    public static MapNavigator get_Instance()
    {
        var pStatics = *(int64*)(DAT_181d87d30 + 184);
        long lVar2;
        long lVar3;
        ulong uVar4;
        int iVar5;
        if (*pStatics == 0) {
          uVar4 = il2cpp_internal();
          ZhSegment.Initialize(uVar4,0);
          puVar1 = *(uint64 **)(DAT_181d87d30 + 184);
          *puVar1 = uVar4;
          il2cpp_internal(puVar1,uVar4);
          lVar2 = *pStatics;
          if (lVar2 == null) {
        LAB_180a8de45:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          uVar4 = new List_1(99,DAT_181db0118);
          *(uint64 *)(lVar2 + 24) = uVar4;
          iVar5 = 0;
          do {
            lVar3 = *(int64 *)(lVar2 + 24);
            uVar4 = new NavigationData(0);
            if (lVar3 == null) goto LAB_180a8de45;
            FUN_18181e6b0(lVar3,uVar4,DAT_181db0198);
            iVar5 = iVar5 + 1;
          } while (iVar5 < 99);
        }
        return **(uint64 **)(DAT_181d87d30 + 184);
    }

    // Token : 0x6000CBC
    // RVA   : 0xA8D370   Offset: 0xA8C770   Length: 0x138
    private NavigationData GetEmptyNavigationData(GridUnitData _thisGrid, NavigationData _preGrid, int _G, int _H)
    {
        int64 MapNavigator.GetEmptyNavigationData
                         (int64 this,uint64 _thisGrid,uint64 _preGrid,int _G,int _H)
        {
        uint32 uVar1;
        int64 lVar2;
        int64 *plVar3;
        lVar2 = this.navigationDataPool;
        if (lVar2 != null) {
          uVar1 = this.curUsedIdx;
          if ((int)uVar1 < (int)lVar2.Count) {
            if (lVar2.Count <= uVar1) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar2 = lVar2._items[uVar1];
          }
          else {
            var lVar2 = new NavigationData(0);
            if (this.navigationDataPool == null) throw; // [null/range check failed]
            FUN_18181e6b0(this.navigationDataPool,lVar2,DAT_181db0198);
          }
          this.curUsedIdx = this.curUsedIdx + 1;
          if (lVar2 != null) {
            *(uint64 *)(lVar2 + 32) = _thisGrid;
            *(uint64 *)(lVar2 + 40) = _preGrid;
            lVar2._version = _H;
            *(int *)(lVar2 + 20) = _H + _G;
            lVar2.Count = _G;
            lVar2._items = 1;
            if (*(int64 *)(lVar2 + 32) != 0) {
              plVar3 = (int64 *)(*(int64 *)(lVar2 + 32) + 64);
              *plVar3 = lVar2;
              il2cpp_internal(plVar3,lVar2);
              return lVar2;
            }
          }
        }
    }

    // Token : 0x6000CBD
    // RVA   : 0xA8DC30   Offset: 0xA8D030   Length: 0x95
    private void ResetPool()
    {
        long lVar1;
        uint uVar2;
        long lVar3;
        uVar2 = 0;
        if (0 < this.curUsedIdx) {
          lVar3 = 32;
          do {
            lVar1 = this.navigationDataPool;
            if (lVar1 == null) {
        LAB_180a8dcc0:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            if (lVar1.Count <= uVar2) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar1 = *(int64 *)(lVar3 + lVar1._items);
            if (lVar1 == null) goto LAB_180a8dcc0;
            NavigationData.Reset(lVar1,0);
            uVar2 = uVar2 + 1;
            lVar3 = lVar3 + 8;
          } while ((int)uVar2 < this.curUsedIdx);
        }
        this.curUsedIdx = 0;
    }

    // Token : 0x6000CBE
    // RVA   : 0xA8D4B0   Offset: 0xA8C8B0   Length: 0xE6
    private void Init()
    {
        long lVar1;
        ulong uVar2;
        int iVar3;
        this.navigationDataPool = new List_1(99,DAT_181db0118);
        iVar3 = 0;
        do {
          lVar1 = this.navigationDataPool;
          uVar2 = new NavigationData(0);
          if (lVar1 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          FUN_18181e6b0(lVar1,uVar2,DAT_181db0198);
          iVar3 = iVar3 + 1;
        } while (iVar3 < 99);
    }

    // Token : 0x6000CBF
    // RVA   : 0xA8D5A0   Offset: 0xA8C9A0   Length: 0x689
    public bool Navigate(BattleMapData battleMap, GridUnitData from, GridUnitData to, List<GridUnitData> path, List<GridUnitData> searched, int stepLimit, int selfTeamID)
    {
        uint64 MapNavigator.Navigate
                          (int64 this,int64 battleMap,int64 from,uint64 to,
                          int64 path,int64 searched,int stepLimit,int selfTeamID)
        {
        char cVar1;
        int iVar2;
        uint32 uVar3;
        int iVar4;
        uint32 uVar5;
        uint64 in_RAX;
        int64 lVar6;
        uint64 uVar7;
        int64 lVar8;
        int64 *plVar9;
        int64 *plVar10;
        int64 *plVar11;
        int iVar12;
        uint32 uVar13;
        uint32 uVar14;
        int64 *plVar15;
        int iVar16;
        uint64 in_stack_ffffffffffffff88;
        uint32 uVar17;
        byte local_68;
        uint32 local_64;
        uVar17 = (uint32)((uint64)in_stack_ffffffffffffff88 >> 32);
        if (battleMap == null) {
          return in_RAX & 0xffffffffffffff00;
        }
        if (path != null) {
          FUN_1812fa020(path,DAT_181d8afb0);
        }
        if (searched != null) {
          FUN_1812fa020(searched,DAT_181d8afb0);
        }
        iVar2 = BattleMapData.get_GridCount(battleMap,0);
        lVar6 = il2cpp_internal(DAT_181d999e8);
        FUN_181330100(lVar6,DAT_181db0098);
        if (from != null) {
          uVar3 = GridUnitData.Distance(from,to,0);
          uVar7 = MapNavigator.GetEmptyNavigationData(this,from,0,0,CONCAT44(uVar17,uVar3),0);
          if (lVar6 != null) {
            FUN_18181e6b0(lVar6,uVar7,DAT_181db0198);
            iVar12 = 0;
            local_68 = 0;
            plVar15 = (int64 *)0;
            local_64 = 0;
            plVar9 = (int64 *)0;
            if (-1 < iVar2) {
              do {
                if (local_68 != 0) break;
                iVar12 = iVar12 + 1;
                if (plVar15 == (int64 *)0) {
                  iVar16 = *(int *)(lVar6 + 24);
                  iVar4 = 999999;
                  while (iVar16 = iVar16 + -1, -1 < iVar16) {
                    lVar8 = FUN_180002f80(lVar6,iVar16,DAT_181db0398);
                    if (lVar8 == null) throw; // [null/range check failed]
                    if (!lVar8._items) {
                      FUN_181823ba0(lVar6,iVar16,DAT_181db0298);
                    }
                    else {
                      lVar8 = FUN_180002f80(lVar6,iVar16,DAT_181db0398);
                      if (lVar8 == null) throw; // [null/range check failed]
                      if (*(int *)(lVar8 + 20) < iVar4) {
                        plVar9 = (int64 *)FUN_180002f80(lVar6,iVar16,DAT_181db0398);
                        if (plVar9 == (int64 *)0) throw; // [null/range check failed]
                        iVar4 = *(int *)((int64)plVar9 + 20);
                      }
                    }
                  }
                  if (plVar9 == (int64 *)0) throw; // [null/range check failed]
                }
                else {
                  plVar9 = plVar15;
                  plVar15 = (int64 *)0;
                }
                *(uint8 *)(plVar9 + 2) = 0;
                if (searched != null) {
                  FUN_18181e6b0(searched,plVar9[4],DAT_181d8af30);
                }
                iVar16 = 4;
                if (plVar9[4] == 0) throw; // [null/range check failed]
                uVar14 = *(uint32 *)(plVar9[4] + 32);
                uVar13 = local_64;
                do {
                  if ((uVar14 >> (uVar13 & 31) & 1) != 0) {
                    lVar8 = plVar9[4];
                    if (lVar8 == null) throw; // [null/range check failed]
                    uVar17 = 0;
                    plVar10 = (int64 *)
                              BattleMapData.GetGridDataByDir
                                        (battleMap,*(uint32 *)(lVar8 + 36),
                                         *(uint32 *)(lVar8 + 40),uVar13,0);
                    if ((plVar10 != (int64 *)0) && (*(int *)((int64)plVar10 + 20) != 2)) {
                      cVar1 = (**(code **)(*plVar10 + 0x138))
                                        (plVar10,to,*(uint64 *)(*plVar10 + 0x140));
                      if (cVar1) {
                        local_68 = 1;
                        if (path != null) {
                          FUN_18181e6b0(path,plVar10,DAT_181d8af30);
                          plVar10 = plVar9;
                          if (plVar9 == (int64 *)0) throw; // [null/range check failed]
                          do {
                            if (plVar10[4] != from) {
                              FUN_18181e6b0(path,plVar10[4],DAT_181d8af30);
                            }
                            plVar10 = (int64 *)plVar10[5];
                          } while (plVar10 != (int64 *)0);
                          List_1.Reverse(path,DAT_181d8b230);
                        }
                        break;
                      }
                      lVar8 = plVar10[3];
                      cVar1 = Object.op_Inequality(lVar8,0,0);
                      if (cVar1) {
                        if (plVar10[3] == 0) throw; // [null/range check failed]
                        cVar1 = BattleUnit.get_IsAlive(plVar10[3],0);
                        if (cVar1) goto LAB_180a8da6b;
                      }
                      if (selfTeamID != -1) {
                        uVar17 = 0;
                        cVar1 = BattleMapData.AroundGridHaveEnemy
                                          (battleMap,*(uint32 *)((int64)plVar10 + 36),
                                           (int)plVar10[5],selfTeamID,0);
                        if (cVar1) goto LAB_180a8da6b;
                      }
                      plVar11 = (int64 *)plVar10[8];
                      if (plVar11 == (int64 *)0) {
                        lVar8 = plVar9[3];
                        uVar3 = GridUnitData.Distance(plVar10,to,0);
                        plVar11 = (int64 *)
                                  MapNavigator.GetEmptyNavigationData
                                            (this,plVar10,plVar9,(int)lVar8 + 1,CONCAT44(uVar17,uVar3),
                                             0);
                        if (plVar11 == (int64 *)0) throw; // [null/range check failed]
                        if ((*(int *)((int64)plVar9 + 20) < *(int *)((int64)plVar11 + 20)) ||
                           (plVar15 != (int64 *)0)) {
                          FUN_18181e6b0(lVar6,plVar11,DAT_181db0198);
                        }
                        else {
        LAB_180a8da67:
                          plVar15 = plVar11;
                          local_64 = uVar13;
                        }
                      }
                      else {
                        if ((char)plVar11[2] != false) {
                          iVar4 = (int)plVar9[3] + 1;
                          if (iVar4 < (int)plVar11[3]) {
                            *(int *)(plVar11 + 3) = iVar4;
                            iVar4 = GridUnitData.Distance(plVar10,to,0);
                            *(int *)((int64)plVar11 + 28) = iVar4;
                            *(int *)((int64)plVar11 + 20) = iVar4 + (int)plVar11[3];
                            plVar11[5] = (int64)plVar9;
                            il2cpp_internal(plVar11 + 5,plVar9);
                            plVar11[4] = (int64)plVar10;
                            il2cpp_internal(plVar11 + 4,plVar10);
                          }
                          if ((*(int *)((int64)plVar11 + 20) <= *(int *)((int64)plVar9 + 20)) &&
                             (plVar15 == (int64 *)0)) goto LAB_180a8da67;
                        }
                      }
                    }
                  }
        LAB_180a8da6b:
                  uVar5 = uVar13 + 1;
                  uVar13 = 0;
                  if ((int)uVar5 < 4) {
                    uVar13 = uVar5;
                  }
                  iVar16 = iVar16 + -1;
                } while (0 < iVar16);
              } while (iVar12 <= iVar2);
            }
            FUN_1812fa020(lVar6,DAT_181db0218);
            uVar14 = 0;
            if (0 < this.curUsedIdx) {
              lVar6 = 32;
              do {
                lVar8 = this.navigationDataPool;
                if (lVar8 == null) throw; // [null/range check failed]
                if (lVar8.Count <= uVar14) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar8 = *(int64 *)(lVar6 + lVar8._items);
                if (lVar8 == null) throw; // [null/range check failed]
                NavigationData.Reset(lVar8,0);
                uVar14 = uVar14 + 1;
                lVar6 = lVar6 + 8;
              } while ((int)uVar14 < this.curUsedIdx);
            }
            this.curUsedIdx = 0;
            if ((((local_68 != 0) && (path != null)) && (0 < stepLimit)) &&
               (stepLimit < *(int *)(path + 24))) {
              List_1.RemoveRange(path,stepLimit,*(int *)(path + 24) - stepLimit,DAT_181d8b1b0);
            }
            return (uint64)local_68;
          }
        }
    }

}
