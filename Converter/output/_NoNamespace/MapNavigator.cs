// ============================================================
// Type  : MapNavigator
// Token : 0x2000187
// ============================================================

public class MapNavigator
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000A4D
    private static MapNavigator instance;

    // Token: 0x4000A4E
    private int curUsedIdx;

    // Token: 0x4000A4F
    private List<NavigationData> navigationDataPool;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000C8B
    // RVA   : 0x210B70   Offset: 0x20F370   Length: 0x7
    private void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x6000C8C
    // RVA   : 0xA8E5F0   Offset: 0xA8CDF0   Length: 0x17A
    public static MapNavigator get_Instance()
    {
        var pStatics = *(int64*)(DAT_181d62af0 + 184);
        long lVar2;
        long lVar3;
        ulong uVar4;
        int iVar5;
        if (*pStatics == 0) {
          uVar4 = il2cpp_internal();
          ZhSegment.Initialize(uVar4,0);
          puVar1 = *(uint64 **)(DAT_181d62af0 + 184);
          *puVar1 = uVar4;
          il2cpp_internal(puVar1,uVar4);
          lVar2 = *pStatics;
          if (lVar2 == null) {
        LAB_180a8e765:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          uVar4 = new List_1(99,DAT_181d88760);
          *(uint64 *)(lVar2 + 24) = uVar4;
          iVar5 = 0;
          do {
            lVar3 = *(int64 *)(lVar2 + 24);
            uVar4 = new NavigationData(0);
            if (lVar3 == null) goto LAB_180a8e765;
            FUN_181827900(lVar3,uVar4,DAT_181d887e0);
            iVar5 = iVar5 + 1;
          } while (iVar5 < 99);
        }
        return **(uint64 **)(DAT_181d62af0 + 184);
    }

    // Token : 0x6000C8D
    // RVA   : 0xA8DC90   Offset: 0xA8C490   Length: 0x138
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
            FUN_181827900(this.navigationDataPool,lVar2,DAT_181d887e0);
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

    // Token : 0x6000C8E
    // RVA   : 0xA8E550   Offset: 0xA8CD50   Length: 0x95
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
        LAB_180a8e5e0:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            if (lVar1.Count <= uVar2) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar1 = *(int64 *)(lVar3 + lVar1._items);
            if (lVar1 == null) goto LAB_180a8e5e0;
            NavigationData.Reset(lVar1,0);
            uVar2 = uVar2 + 1;
            lVar3 = lVar3 + 8;
          } while ((int)uVar2 < this.curUsedIdx);
        }
        this.curUsedIdx = 0;
    }

    // Token : 0x6000C8F
    // RVA   : 0xA8DDD0   Offset: 0xA8C5D0   Length: 0xE6
    private void Init()
    {
        long lVar1;
        ulong uVar2;
        int iVar3;
        this.navigationDataPool = new List_1(99,DAT_181d88760);
        iVar3 = 0;
        do {
          lVar1 = this.navigationDataPool;
          uVar2 = new NavigationData(0);
          if (lVar1 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          FUN_181827900(lVar1,uVar2,DAT_181d887e0);
          iVar3 = iVar3 + 1;
        } while (iVar3 < 99);
    }

    // Token : 0x6000C90
    // RVA   : 0xA8DEC0   Offset: 0xA8C6C0   Length: 0x689
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
          FUN_180f56130(path,DAT_181d637f8);
        }
        if (searched != null) {
          FUN_180f56130(searched,DAT_181d637f8);
        }
        iVar2 = BattleMapData.get_GridCount(battleMap,0);
        lVar6 = il2cpp_internal(DAT_181d74cb0);
        FUN_180f58a90(lVar6,DAT_181d886e0);
        if (from != null) {
          uVar3 = GridUnitData.Distance(from,to,0);
          uVar7 = MapNavigator.GetEmptyNavigationData(this,from,0,0,CONCAT44(uVar17,uVar3),0);
          if (lVar6 != null) {
            FUN_181827900(lVar6,uVar7,DAT_181d887e0);
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
                    lVar8 = FUN_180002f80(lVar6,iVar16,DAT_181d889e0);
                    if (lVar8 == null) throw; // [null/range check failed]
                    if (!lVar8._items) {
                      FUN_18182b220(lVar6,iVar16,DAT_181d888e0);
                    }
                    else {
                      lVar8 = FUN_180002f80(lVar6,iVar16,DAT_181d889e0);
                      if (lVar8 == null) throw; // [null/range check failed]
                      if (*(int *)(lVar8 + 20) < iVar4) {
                        plVar9 = (int64 *)FUN_180002f80(lVar6,iVar16,DAT_181d889e0);
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
                  FUN_181827900(searched,plVar9[4],DAT_181d63778);
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
                          FUN_181827900(path,plVar10,DAT_181d63778);
                          plVar10 = plVar9;
                          if (plVar9 == (int64 *)0) throw; // [null/range check failed]
                          do {
                            if (plVar10[4] != from) {
                              FUN_181827900(path,plVar10[4],DAT_181d63778);
                            }
                            plVar10 = (int64 *)plVar10[5];
                          } while (plVar10 != (int64 *)0);
                          List_1.Reverse(path,DAT_181d63a78);
                        }
                        break;
                      }
                      lVar8 = plVar10[3];
                      cVar1 = Object.op_Inequality(lVar8,0,0);
                      if (cVar1) {
                        if (plVar10[3] == 0) throw; // [null/range check failed]
                        cVar1 = BattleUnit.get_IsAlive(plVar10[3],0);
                        if (cVar1) goto LAB_180a8e38b;
                      }
                      if (selfTeamID != -1) {
                        uVar17 = 0;
                        cVar1 = BattleMapData.AroundGridHaveEnemy
                                          (battleMap,*(uint32 *)((int64)plVar10 + 36),
                                           (int)plVar10[5],selfTeamID,0);
                        if (cVar1) goto LAB_180a8e38b;
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
                          FUN_181827900(lVar6,plVar11,DAT_181d887e0);
                        }
                        else {
        LAB_180a8e387:
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
                             (plVar15 == (int64 *)0)) goto LAB_180a8e387;
                        }
                      }
                    }
                  }
        LAB_180a8e38b:
                  uVar5 = uVar13 + 1;
                  uVar13 = 0;
                  if ((int)uVar5 < 4) {
                    uVar13 = uVar5;
                  }
                  iVar16 = iVar16 + -1;
                } while (0 < iVar16);
              } while (iVar12 <= iVar2);
            }
            FUN_180f56130(lVar6,DAT_181d88860);
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
              List_1.RemoveRange(path,stepLimit,*(int *)(path + 24) - stepLimit,DAT_181d639f8);
            }
            return (uint64)local_68;
          }
        }
    }

}
