// ============================================================
// Type  : ExplorePanelData
// Token : 0x200026E
// ============================================================

public class ExplorePanelData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001380
    public ExploreType exploreType;

    // Token: 0x4001381
    public int exploreMapType;

    // Token: 0x4001382
    public int mapWidth;

    // Token: 0x4001383
    public int mapHeight;

    // Token: 0x4001384
    public List<ExploreTileData> exploreTiles;

    // Token: 0x4001385
    public ExploreTileData[] exploreTileMap;

    // Token: 0x4001386
    public int maxPower;

    // Token: 0x4001387
    public ExploreTileData startTile;

    // Token: 0x4001388
    public string finishFuc;

    // Token: 0x4001389
    public string finishParam;

    // Token: 0x400138A
    public int keyNum;

    // Token: 0x400138B
    public bool showFinal;

    // Token: 0x400138C
    public int[] startDistance;

    // Token: 0x400138D
    public int[] endDistance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60013FF
    // RVA   : 0xB27690   Offset: 0xB26A90   Length: 0x7D
    public void /*ctor*/()
    {
        ulong uVar1;
        this.exploreMapType = 0xffffffff;
        ZhSegment.Initialize(this,0);
        uVar1 = il2cpp_internal(DAT_181d92970);
        FUN_181330100(uVar1,DAT_181d86fb8);
        this.exploreTiles = uVar1;
    }

    // Token : 0x6001400
    // RVA   : 0xB271F0   Offset: 0xB265F0   Length: 0xA
    public int GetTileID(int c, int r)
    {
        return c + r * this.mapWidth;
    }

    // Token : 0x6001401
    // RVA   : 0xB265D0   Offset: 0xB259D0   Length: 0x865
    public void GenerateWildGround(int roadNum, float difficulty)
    {
        uint uVar2;
        uint uVar3;
        int iVar4;
        int iVar5;
        uint uVar6;
        long lVar7;
        long lVar8;
        long lVar9;
        ulong uVar10;
        uint uVar11;
        long lVar12;
        float fVar13;
        int local_res8;
        lVar7 = il2cpp_internal(DAT_181d92970);
        FUN_181330100(lVar7,DAT_181d86fb8);
        lVar8 = il2cpp_internal(DAT_181dc5fe0);
        *(uint32 *)(lVar8 + 68) = 0xffffffff;
        ZhSegment.Initialize(lVar8,0);
        uVar11 = 1;
        if (1 < this.mapHeight + -1) {
          do {
            lVar8 = this.exploreTileMap;
            if (lVar8 == null) throw; // [null/range check failed]
            if (*lVar8._items == null) {
              uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar10,0);
            }
            if ((uint32)(lVar8._items)[4] <= uVar11) {
              uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar10,0);
            }
            if (lVar7 == null) throw; // [null/range check failed]
            FUN_18181e6b0(lVar7,lVar8[uVar11],DAT_181d87038);
            uVar11 = uVar11 + 1;
          } while ((int)uVar11 < this.mapHeight + -1);
        }
        uVar11 = 1;
        if (1 < this.mapWidth + -1) {
          do {
            lVar8 = this.exploreTileMap;
            if (lVar8 == null) throw; // [null/range check failed]
            if (*lVar8._items <= uVar11) {
              uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar10,0);
            }
            lVar9 = *(int64 *)(lVar8._items + 4);
            if ((int)lVar9 == null) {
              uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar10,0);
            }
            if (lVar7 == null) throw; // [null/range check failed]
            FUN_18181e6b0(lVar7,*(uint64 *)(lVar8 + 32 + (int)uVar11 * lVar9 * 8),DAT_181d87038);
            uVar11 = uVar11 + 1;
          } while ((int)uVar11 < this.mapWidth + -1);
        }
        uVar11 = 0;
        local_res8 = 0;
        if (0 < roadNum) {
          do {
            if (lVar7 == null) throw; // [null/range check failed]
            uVar2 = FUN_180d96040(0,*(uint32 *)(lVar7 + 24),0);
            if (*(uint32 *)(lVar7 + 24) <= uVar2) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            plVar1 = &this.startTile;
            lVar8 = lVar7[uVar2];
            if (this.startTile == null) {
              this.startTile = lVar8;
              il2cpp_internal(plVar1,lVar8);
            }
            FUN_1817ef410(lVar7,lVar8);
            if (lVar8 == null) throw; // [null/range check failed]
            if (*(int *)(lVar8 + 36) == 0) {
              while( true ) {
                if (lVar8 == null) throw; // [null/range check failed]
                if ((this.mapWidth + -1 < *(int *)(lVar8 + 36)) ||
                   (*(uint32 *)(lVar8 + 72) = 0,
                   this.mapWidth + -1 <= *(int *)(lVar8 + 36))) break;
                fVar13 = (float)Random.get_value(0);
                if (fVar13 < 0.75) {
                  lVar9 = this.exploreTileMap;
                  if (lVar9 == null) throw; // [null/range check failed]
                  iVar5 = *(int *)(lVar8 + 36) + 1;
                }
                else {
                  lVar12 = il2cpp_internal(DAT_181d93ce8);
                  FUN_181330100(lVar12,DAT_181d8f0b0);
                  iVar5 = *(int *)(lVar8 + 32);
                  if (0 < iVar5) {
                    if (lVar12 == null) throw; // [null/range check failed]
                    FUN_18182a6c0(lVar12,0xffffffff,DAT_181d8f230);
                    iVar5 = *(int *)(lVar8 + 32);
                  }
                  if (iVar5 < this.mapHeight + -1) {
                    if (lVar12 == null) throw; // [null/range check failed]
                    FUN_18182a6c0(lVar12,1,DAT_181d8f230);
                    lVar9 = this.exploreTileMap;
                    iVar5 = *(int *)(lVar8 + 36);
                  }
                  else {
                    lVar9 = this.exploreTileMap;
                    iVar5 = *(int *)(lVar8 + 36);
                    if (lVar12 == null) throw; // [null/range check failed]
                  }
                  uVar3 = FUN_180d96040(0,*(uint32 *)(lVar12 + 24),0);
                  FUN_1800d6760(lVar12,uVar3,DAT_181d8fa30);
                  if (lVar9 == null) throw; // [null/range check failed]
                }
                lVar8 = FUN_180127f90(lVar9,(int64)iVar5);
              }
            }
            else if (*(int *)(lVar8 + 32) == 0) {
              while( true ) {
                if (lVar8 == null) throw; // [null/range check failed]
                if ((this.mapHeight + -1 < *(int *)(lVar8 + 32)) ||
                   (*(uint32 *)(lVar8 + 72) = 0,
                   this.mapHeight + -1 <= *(int *)(lVar8 + 32))) break;
                fVar13 = (float)Random.get_value(0);
                if (fVar13 < 0.75) {
                  if (this.exploreTileMap == null) throw; // [null/range check failed]
                  lVar8 = FUN_180127f90(this.exploreTileMap,(int64)*(int *)(lVar8 + 36));
                }
                else {
                  lVar9 = il2cpp_internal(DAT_181d93ce8);
                  FUN_181330100(lVar9,DAT_181d8f0b0);
                  iVar5 = *(int *)(lVar8 + 36);
                  if (0 < iVar5) {
                    if (lVar9 == null) throw; // [null/range check failed]
                    FUN_18182a6c0(lVar9,0xffffffff,DAT_181d8f230);
                    iVar5 = *(int *)(lVar8 + 36);
                  }
                  if (iVar5 < this.mapWidth + -1) {
                    if (lVar9 == null) throw; // [null/range check failed]
                    FUN_18182a6c0(lVar9,1,DAT_181d8f230);
                    lVar12 = this.exploreTileMap;
                    iVar5 = *(int *)(lVar8 + 36);
                  }
                  else {
                    lVar12 = this.exploreTileMap;
                    if (lVar9 == null) throw; // [null/range check failed]
                  }
                  uVar3 = FUN_180d96040(0,*(uint32 *)(lVar9 + 24),0);
                  iVar4 = FUN_1800d6760(lVar9,uVar3,DAT_181d8fa30);
                  if (lVar12 == null) throw; // [null/range check failed]
                  lVar8 = FUN_180127f90(lVar12,(int64)(iVar4 + iVar5));
                }
              }
            }
            local_res8 = local_res8 + 1;
          } while (local_res8 < roadNum);
        }
        lVar7 = il2cpp_internal(DAT_181d929f0);
        FUN_181330100(lVar7,DAT_181d874b8);
        if (lVar7 != null) {
          FUN_18182a6c0(lVar7,1,DAT_181d87538);
          FUN_18182a6c0(lVar7,1,DAT_181d87538);
          FUN_18182a6c0(lVar7,1,DAT_181d87538);
          FUN_18182a6c0(lVar7,1,DAT_181d87538);
          FUN_18182a6c0(lVar7,2,DAT_181d87538);
          FUN_18182a6c0(lVar7,2,DAT_181d87538);
          FUN_18182a6c0(lVar7,2,DAT_181d87538);
          FUN_18182a6c0(lVar7,3,DAT_181d87538);
          FUN_18182a6c0(lVar7,3,DAT_181d87538);
          FUN_18182a6c0(lVar7,4,DAT_181d87538);
          lVar8 = this.exploreTiles;
          if (lVar8 != null) {
            lVar12 = 32;
            lVar9 = 32;
            uVar2 = uVar11;
            do {
              if (lVar8.Count <= (int)uVar2) {
                if (lVar8 != null) goto LAB_180b26cc7;
                break;
              }
              if (lVar8 == null) break;
              if (lVar8.Count <= uVar2) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar8 = *(int64 *)(lVar9 + lVar8._items);
              if (lVar8 == null) break;
              if (*(int *)(lVar8 + 72) == 1) {
                if (this.exploreTiles == null) break;
                lVar8 = FUN_180002f80(this.exploreTiles,uVar2,DAT_181d872b8);
                uVar3 = FUN_180d96040(0,*(uint32 *)(lVar7 + 24),0);
                uVar3 = FUN_1800d6760(lVar7,uVar3,DAT_181d87638);
                if (lVar8 == null) break;
                *(uint32 *)(lVar8 + 72) = uVar3;
              }
              lVar8 = this.exploreTiles;
              uVar2 = uVar2 + 1;
              lVar9 = lVar9 + 8;
            } while (lVar8 != null);
          }
        }
        throw; // [null/range check failed]
        while( true ) {
          if (lVar8.Count <= uVar11) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar7 = *(int64 *)(lVar12 + lVar8._items);
          if (lVar7 == null) break;
          if ((*(int *)(lVar7 + 72) != 0) && (fVar13 = (float)Random.get_value(), fVar13 < 0.05)) {
            if (this.exploreTiles == null) break;
            lVar7 = FUN_180002f80(this.exploreTiles,uVar11,DAT_181d872b8);
            uVar3 = FUN_180d96040(0,3);
            fVar13 = (float)Random.Range(0x41200000,0x41a00000,0);
            uVar6 = Mathf.RoundToInt(difficulty * 10.0 + fVar13,0);
            lVar8 = new ZhSegment(0);
            lVar8._items = uVar3;
            *(uint32 *)(lVar8 + 20) = uVar6;
            if (lVar7 == null) break;
            *(int64 *)(lVar7 + 80) = lVar8;
          }
          lVar8 = this.exploreTiles;
          uVar11 = uVar11 + 1;
          lVar12 = lVar12 + 8;
          if (lVar8 == null) break;
        LAB_180b26cc7:
          if (lVar8.Count <= (int)uVar11) {
            return;
          }
          if (lVar8 == null) break;
        }
    }

    // Token : 0x6001402
    // RVA   : 0xB25A60   Offset: 0xB24E60   Length: 0xB61
    public void GenerateMazeGround(int obstacleCount, int gap, float difficulty)
    {
        void ExplorePanelData.GenerateMazeGround
                     (int64 this,int obstacleCount,uint32 gap,float difficulty)
        {
        char cVar1;
        uint32 uVar2;
        int iVar3;
        int iVar4;
        int iVar5;
        int iVar6;
        uint32 uVar7;
        uint32 uVar8;
        int64 lVar9;
        int64 lVar10;
        int64 lVar11;
        uint64 uVar12;
        int64 lVar13;
        int64 lVar14;
        uint64 uVar15;
        int iVar16;
        uint32 uVar17;
        int iVar18;
        bool bVar19;
        float fVar20;
        int64 local_res8;
        int local_138;
        uint32 local_100;
        uint32 uStack_fc;
        uint32 uStack_f8;
        uint32 uStack_f4;
        int64 local_f0;
        int64 local_e8;
        int64 local_e0;
        int64 local_d8;
        int64 local_d0;
        uint64 local_c8;
        uint64 uStack_c0;
        int64 local_b8;
        int64 local_b0;
        int64 local_a8;
        int64 local_a0;
        int64 local_98;
        uint32 local_80;
        uint32 uStack_7c;
        uint32 uStack_78;
        uint32 uStack_74;
        int64 local_70;
        lVar9 = il2cpp_internal(DAT_181d92970);
        FUN_181330100(lVar9,DAT_181d86fb8);
        local_e0 = lVar9;
        lVar10 = il2cpp_internal(DAT_181d92970);
        FUN_181330100(lVar10,DAT_181d86fb8);
        local_d8 = lVar10;
        lVar11 = il2cpp_internal(DAT_181d92970);
        FUN_181330100(lVar11,DAT_181d86fb8);
        local_b0 = (int64)this.mapWidth;
        local_a8 = (int64)this.mapHeight;
        local_d0 = lVar11;
        uVar12 = FUN_1800d6020(DAT_181da9af8,&local_b0);
        this.startDistance = uVar12;
        local_a0 = (int64)this.mapWidth;
        local_98 = (int64)this.mapHeight;
        uVar12 = FUN_1800d6020(DAT_181da9af8,&local_a0);
        this.endDistance = uVar12;
        lVar13 = this.exploreTiles;
        if (lVar13 != null) {
          if (lVar13.Count == null) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          this.startTile = *(uint64 *)(lVar13._items + 32);
          if (this.exploreTiles != null) {
            FUN_1817eba30(&local_c8,this.exploreTiles,DAT_181d87138);
            local_100 = (uint32)local_c8;
            uStack_fc = local_c8._4_4_;
            uStack_f8 = (uint32)uStack_c0;
            uStack_f4 = uStack_c0._4_4_;
            local_f0 = local_b8;
            while (cVar1 = FUN_180c75510(&local_100,DAT_181d8c300), lVar13 = local_f0, cVar1) {
              if (local_f0 == 0) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              if ((-1 < *(int *)(local_f0 + 56)) && (this.startTile != local_f0)) {
                if (lVar9 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                FUN_18181e6b0(lVar9,local_f0,DAT_181d87038);
                if (lVar11 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                FUN_18181e6b0(lVar11,lVar13);
              }
            }
            ZhSegment.Initialize(&local_100,DAT_181d8c280);
            local_138 = obstacleCount;
            while (uVar17 = 0, 0 < local_138) {
              if (lVar9 == null) goto LAB_180b265b6;
              if (*(int *)(lVar9 + 24) < 1) break;
              uVar2 = FUN_180d96040(0,*(int *)(lVar9 + 24),0);
              if (*(uint32 *)(lVar9 + 24) <= uVar2) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              local_e8 = lVar9[uVar2];
              if ((local_e8 == 0) || (*(uint32 *)(local_e8 + 48) = 1, lVar11 == null)) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              FUN_1817ef410(lVar11,local_e8,DAT_181d871b8);
              local_c8 = (int64)this.mapWidth;
              uStack_c0 = (int64)this.mapHeight;
              lVar13 = FUN_1800d6020(DAT_181da9878,&local_c8);
              if (*(int *)(lVar11 + 24) == 0) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              ExplorePanelData.FindConnectedGrid
                        (this,lVar13,*(uint64 *)(*(int64 *)(lVar11 + 16) + 32),0);
              bVar19 = true;
              iVar16 = this.mapWidth;
              if (iVar16 < 1) {
        LAB_180b25eeb:
                iVar18 = 0;
                if (0 < iVar16) {
                  do {
                    iVar16 = 0;
                    if (0 < this.mapHeight) {
                      do {
                        if (this.startDistance == null) goto LAB_180b265b6;
                        FUN_18014ad60(this.startDistance,(int64)iVar18,(int64)iVar16,0);
                        if (this.endDistance == null) goto LAB_180b265b6;
                        FUN_18014ad60(this.endDistance,(int64)iVar18,(int64)iVar16,0);
                        iVar16 = iVar16 + 1;
                      } while (iVar16 < this.mapHeight);
                    }
                    iVar18 = iVar18 + 1;
                  } while (iVar18 < this.mapWidth);
                }
                uVar12 = this.endDistance;
                lVar13 = this.exploreTiles;
                if (lVar13 == null) goto LAB_180b265b6;
                uVar15 = FUN_180002f80(lVar13,lVar13.Count + -1,DAT_181d872b8);
                ExplorePanelData.FindConnectedGridDistance(this,uVar12,1,uVar15,0);
                lVar13 = this.endDistance;
                if (lVar13 == null) goto LAB_180b265b6;
                iVar18 = Array.GetUpperBound(lVar13,0,0);
                iVar3 = Array.GetUpperBound(lVar13,1);
                for (iVar16 = Array.GetLowerBound(lVar13,0,0); iVar16 <= iVar18; iVar16 = iVar16 + 1) {
                  iVar4 = Array.GetLowerBound(lVar13,1);
                  if (iVar4 <= iVar3) {
                    do {
                      iVar5 = FUN_18014ad10(lVar13,(int64)iVar16);
                      if (this.endDistance == null) goto LAB_180b265b6;
                      iVar6 = FUN_18014ad10(this.endDistance,0);
                      if (iVar6 < iVar5) goto LAB_180b2612b;
                      iVar4 = iVar4 + 1;
                    } while (iVar4 <= iVar3);
                  }
                }
                uVar12 = this.startDistance;
                lVar13 = this.exploreTiles;
                if (lVar13 == null) goto LAB_180b265b6;
                if (lVar13.Count == null) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                ExplorePanelData.FindConnectedGridDistance
                          (this,uVar12,1,*(uint64 *)(lVar13._items + 32),0);
                lVar13 = this.startDistance;
                if (lVar13 == null) goto LAB_180b265b6;
                iVar3 = Array.GetUpperBound(lVar13,0,0);
                iVar4 = Array.GetUpperBound(lVar13,1);
                iVar18 = Array.GetLowerBound(lVar13,0,0);
                iVar16 = iVar18 - iVar3;
                bVar19 = iVar18 == iVar3;
                while (bVar19 || SBORROW4(iVar18,iVar3) != iVar16 < 0) {
                  iVar16 = Array.GetLowerBound(lVar13,1);
                  if (iVar16 <= iVar4) {
                    do {
                      iVar5 = FUN_18014ad10(lVar13,(int64)iVar18,(int64)iVar16);
                      if (this.startDistance == null) goto LAB_180b265b6;
                      iVar6 = FUN_18014ad10(this.startDistance,
                                            (int64)(this.mapWidth + -1));
                      if (iVar6 < iVar5) goto LAB_180b2612b;
                      iVar16 = iVar16 + 1;
                    } while (iVar16 <= iVar4);
                  }
                  iVar18 = iVar18 + 1;
                  iVar16 = iVar18 - iVar3;
                  bVar19 = iVar16 == 0;
                }
                ExplorePanelData.GetRangeGrids
                          (this,*(uint32 *)(local_e8 + 32),*(uint32 *)(local_e8 + 36),0,
                           gap,1,lVar10,0);
                if (lVar10 == null) goto LAB_180b265b6;
                if (0 < *(int *)(lVar10 + 24)) {
                  FUN_1817eba30(&local_80,lVar10);
                  local_100 = local_80;
                  uStack_fc = uStack_7c;
                  uStack_f8 = uStack_78;
                  uStack_f4 = uStack_74;
                  local_f0 = local_70;
                  while (cVar1 = FUN_180c75510(&local_100,DAT_181d8c300), cVar1) {
                    FUN_1817ef410(lVar9,local_f0);
                  }
                  ZhSegment.Initialize(&local_100,DAT_181d8c280);
                }
                local_138 = local_138 + -1;
              }
              else {
                do {
                  iVar16 = 0;
                  if (0 < this.mapHeight) {
                    do {
                      if (this.exploreTileMap == null) goto LAB_180b265b6;
                      lVar14 = FUN_180127f90(this.exploreTileMap,(int64)(int)uVar17,
                                             (int64)iVar16);
                      if (lVar14 == null) goto LAB_180b265b6;
                      if (*(int *)(lVar14 + 48) == 0) {
                        if (lVar13 == null) goto LAB_180b265b6;
                        cVar1 = FUN_180132d10(lVar13,(int64)(int)uVar17,(int64)iVar16);
                        if (!cVar1) {
                          bVar19 = false;
                          break;
                        }
                      }
                      iVar16 = iVar16 + 1;
                    } while (iVar16 < this.mapHeight);
                  }
                  uVar17 = uVar17 + 1;
                  iVar16 = this.mapWidth;
                } while ((int)uVar17 < iVar16);
                if (bVar19) goto LAB_180b25eeb;
        LAB_180b2612b:
                lVar13 = local_e8;
                *(uint32 *)(local_e8 + 48) = 0;
                FUN_18181e6b0(lVar11,local_e8,DAT_181d87038);
                FUN_1817ef410(lVar9,lVar13);
              }
            }
            lVar13 = this.exploreTiles;
            if (lVar13 != null) {
              lVar9 = 32;
              local_res8 = 32;
              do {
                uVar2 = 0;
                if (lVar13.Count <= (int)uVar17) {
                  if (lVar13 != null) goto LAB_180b264b0;
                  break;
                }
                if (lVar13 == null) break;
                if (lVar13.Count <= uVar17) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar13 = *(int64 *)(lVar13._items + local_res8);
                if (lVar13 == null) break;
                if (*(int *)(lVar13 + 48) == 1) {
                  if (this.exploreTiles == null) break;
                  lVar13 = FUN_180002f80(this.exploreTiles,uVar17,DAT_181d872b8);
                  iVar16 = 0;
                  do {
                    if (lVar13 == null) goto LAB_180b265b6;
                    lVar10 = ExplorePanelData.GetGridDataByDir
                                       (this,*(uint32 *)(lVar13 + 32),
                                        *(uint32 *)(lVar13 + 36),iVar16,0);
                    if ((lVar10 != null) && (*(int *)(lVar10 + 48) == 0)) {
                      uVar2 = uVar2 + 1;
                    }
                    iVar16 = iVar16 + 1;
                  } while (iVar16 < 4);
                  if ((1 < (int)uVar2) && (fVar20 = (float)Random.get_value(0), fVar20 < 0.05)) {
                    if ((this.exploreTiles == null) ||
                       (lVar13 = FUN_180002f80(this.exploreTiles,uVar17,DAT_181d872b8),
                       lVar13 == null)) break;
                    *(uint32 *)(lVar13 + 48) = 0;
                    if (this.exploreTiles == null) break;
                    lVar13 = FUN_180002f80(this.exploreTiles,uVar17,DAT_181d872b8);
                    uVar7 = FUN_180d96040(0,3);
                    fVar20 = (float)Random.Range(0x41200000,0x41a00000,0);
                    uVar8 = Mathf.RoundToInt(difficulty * 10.0 + fVar20,0);
                    var lVar10 = new ZhSegment(0);
                    *(uint32 *)(lVar10 + 16) = uVar7;
                    *(uint32 *)(lVar10 + 20) = uVar8;
                    if (lVar13 == null) break;
                    *(int64 *)(lVar13 + 80) = lVar10;
                  }
                }
                uVar17 = uVar17 + 1;
                local_res8 = local_res8 + 8;
                lVar13 = this.exploreTiles;
              } while (lVar13 != null);
            }
        LAB_180b265b6:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
        }
                          // WARNING: Subroutine does not return
        FUN_1800d6620();
        LAB_180b264b0:
        if (lVar13.Count <= (int)uVar2) {
          return;
        }
        if (lVar13 == null) goto LAB_180b265b6;
        if (lVar13.Count <= uVar2) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        lVar13 = *(int64 *)(lVar9 + lVar13._items);
        if (lVar13 == null) goto LAB_180b265b6;
        if (*(int *)(lVar13 + 48) == 1) {
          if (this.exploreTiles == null) goto LAB_180b265b6;
          uVar12 = FUN_180002f80(this.exploreTiles,uVar2,DAT_181d872b8);
          cVar1 = ExplorePanelData.TileCanBecomeDoor(this,uVar12,0);
          if ((cVar1) && (fVar20 = (float)Random.get_value(), fVar20 < 0.4)) {
            if ((this.exploreTiles == null) ||
               (lVar13 = FUN_180002f80(this.exploreTiles,uVar2,DAT_181d872b8)) == null)
            goto LAB_180b265b6;
            *(uint32 *)(lVar13 + 48) = 2;
          }
        }
        uVar2 = uVar2 + 1;
        lVar9 = lVar9 + 8;
        lVar13 = this.exploreTiles;
        if (lVar13 == null) goto LAB_180b265b6;
        goto LAB_180b264b0;
    }

    // Token : 0x6001403
    // RVA   : 0xB27600   Offset: 0xB26A00   Length: 0x86
    public bool TileCanBecomeObstacle(ExploreTileData targetTile)
    {
        long lVar1;
        int iVar2;
        int iVar3;
        iVar2 = 0;
        iVar3 = iVar2;
        do {
          if (targetTile == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          lVar1 = ExplorePanelData.GetGridDataByDir
                            (this,*(uint32 *)(targetTile + 32),*(uint32 *)(targetTile + 36),iVar2
                             ,0);
          if ((lVar1 != null) && (*(int *)(lVar1 + 48) == 0)) {
            iVar3 = iVar3 + 1;
          }
          iVar2 = iVar2 + 1;
        } while (iVar2 < 4);
        return 1 < iVar3;
    }

    // Token : 0x6001404
    // RVA   : 0xB27200   Offset: 0xB26600   Length: 0x3FA
    public bool TileCanBecomeDoor(ExploreTileData targetTile)
    {
        int iVar1;
        long lVar2;
        long lVar3;
        ulong uVar4;
        ulong uVar5;
        ulong uVar6;
        uint uVar7;
        int iVar8;
        ulong uVar9;
        int iVar10;
        lVar2 = il2cpp_internal(DAT_181d917f0);
        FUN_181330100(lVar2,DAT_181d804b8);
        if (lVar2 == null) {
        LAB_180b275f5:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        FUN_1817e9ef0(lVar2,0,DAT_181d80538);
        FUN_1817e9ef0(lVar2,0,DAT_181d80538);
        FUN_1817e9ef0(lVar2,0,DAT_181d80538);
        FUN_1817e9ef0(lVar2,0,DAT_181d80538);
        uVar6 = 0;
        uVar4 = uVar6;
        do {
          if (targetTile == null) goto LAB_180b275f5;
          lVar3 = ExplorePanelData.GetGridDataByDir
                            (this,*(uint32 *)(targetTile + 32),*(uint32 *)(targetTile + 36),uVar4
                             ,0);
          if (lVar3 != null) {
            uVar7 = *(uint32 *)(lVar3 + 48);
            uVar5 = (uint64)uVar7;
            if (uVar7 == 2) goto LAB_180b273a9;
            if (uVar7 == 0) {
              FUN_1817f4900(lVar2,uVar4,1,DAT_181d80738);
            }
          }
          uVar7 = (int)uVar4 + 1;
          uVar4 = (uint64)uVar7;
        } while ((int)uVar7 < 4);
        if (*(int *)(lVar2 + 24) == 0) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        uVar5 = *(uint64 *)(lVar2 + 16);
        if (*(char *)(uVar5 + 32) != false) {
          if (*(uint32 *)(lVar2 + 24) < 2) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
            uVar5 = *(uint64 *)(lVar2 + 16);
          }
          if (*(char *)(uVar5 + 33) != false) {
            iVar10 = *(int *)(targetTile + 32);
            iVar1 = *(int *)(targetTile + 36);
            iVar8 = iVar10 + 1;
            uVar4 = uVar6;
            if ((((-1 < iVar8) && (iVar8 < this.mapHeight)) && (-1 < iVar1)) &&
               (iVar1 < this.mapWidth)) {
              if (this.exploreTileMap == null) goto LAB_180b275f5;
              uVar4 = FUN_180127f90(this.exploreTileMap,(int64)iVar1,(int64)iVar8);
              iVar10 = *(int *)(targetTile + 32);
              iVar1 = *(int *)(targetTile + 36);
            }
            iVar10 = iVar10 + -1;
            uVar5 = uVar6;
            if (((-1 < iVar10) && (iVar10 < this.mapHeight)) &&
               ((-1 < iVar1 && (iVar1 < this.mapWidth)))) {
              if (this.exploreTileMap == null) goto LAB_180b275f5;
              uVar5 = FUN_180127f90(this.exploreTileMap,(int64)iVar1,(int64)iVar10);
            }
            bVar11 = 0;
            if ((uVar4 == 0) || (uVar9 = uVar6, *(int *)(uVar4 + 48) != 0)) {
        LAB_180b27450:
              bVar11 = 1;
            }
            else {
              do {
                lVar2 = ExplorePanelData.GetGridDataByDir
                                  (this,*(uint32 *)(uVar4 + 32),*(uint32 *)(uVar4 + 36),
                                   uVar9,0);
                if (lVar2 == null) goto LAB_180b275f5;
                if (*(int *)(lVar2 + 48) != 0) goto LAB_180b27450;
                uVar7 = (int)uVar9 + 1;
                uVar9 = (uint64)uVar7;
              } while ((int)uVar7 < 2);
            }
            if ((uVar5 == 0) || (*(int *)(uVar5 + 48) != 0)) {
        LAB_180b2749a:
              return (uint64)bVar11;
            }
            while( true ) {
              lVar2 = ExplorePanelData.GetGridDataByDir
                                (this,*(uint32 *)(uVar5 + 32),*(uint32 *)(uVar5 + 36),uVar6
                                 ,0);
              if (lVar2 == null) break;
              if (*(int *)(lVar2 + 48) != 0) goto LAB_180b2749a;
              uVar7 = (int)uVar6 + 1;
              uVar6 = (uint64)uVar7;
              if (1 < (int)uVar7) {
                return false;
              }
            }
            goto LAB_180b275f5;
          }
        }
        if (*(uint32 *)(lVar2 + 24) < 3) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
          uVar5 = *(uint64 *)(lVar2 + 16);
        }
        if (*(char *)(uVar5 + 34) != false) {
          if (*(uint32 *)(lVar2 + 24) < 4) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
            uVar5 = *(uint64 *)(lVar2 + 16);
          }
          if (*(char *)(uVar5 + 35) != false) {
            iVar10 = *(int *)(targetTile + 36);
            iVar1 = *(int *)(targetTile + 32);
            iVar8 = iVar10 + -1;
            uVar4 = uVar6;
            if ((((-1 < iVar1) && (iVar1 < this.mapHeight)) && (-1 < iVar8)) &&
               (iVar8 < this.mapWidth)) {
              if (this.exploreTileMap == null) goto LAB_180b275f5;
              uVar4 = FUN_180127f90(this.exploreTileMap,(int64)iVar8,(int64)iVar1);
              iVar10 = *(int *)(targetTile + 36);
              iVar1 = *(int *)(targetTile + 32);
            }
            iVar10 = iVar10 + 1;
            if (((-1 < iVar1) && (iVar1 < this.mapHeight)) &&
               ((-1 < iVar10 && (iVar10 < this.mapWidth)))) {
              if (this.exploreTileMap == null) goto LAB_180b275f5;
              uVar6 = FUN_180127f90(this.exploreTileMap,(int64)iVar10,(int64)iVar1);
            }
            bVar11 = 0;
            iVar8 = 2;
            if ((uVar4 == 0) || (*(int *)(uVar4 + 48) != 0)) {
        LAB_180b2759c:
              bVar11 = 1;
            }
            else {
              iVar10 = 2;
              do {
                lVar2 = ExplorePanelData.GetGridDataByDir
                                  (this,*(uint32 *)(uVar4 + 32),*(uint32 *)(uVar4 + 36),
                                   iVar10,0);
                if (lVar2 == null) goto LAB_180b275f5;
                if (*(int *)(lVar2 + 48) != 0) goto LAB_180b2759c;
                iVar10 = iVar10 + 1;
              } while (iVar10 < 4);
            }
            if ((uVar6 == 0) || (*(int *)(uVar6 + 48) != 0)) {
        LAB_180b275e6:
              return (uint64)bVar11;
            }
            while (lVar2 = ExplorePanelData.GetGridDataByDir
                                     (this,*(uint32 *)(uVar6 + 32),*(uint32 *)(uVar6 + 36),
                                      iVar8,0), lVar2 != null) {
              if (*(int *)(lVar2 + 48) != 0) goto LAB_180b275e6;
              iVar8 = iVar8 + 1;
              if (3 < iVar8) {
                return false;
              }
            }
            goto LAB_180b275f5;
          }
        }
        LAB_180b273a9:
        return uVar5 & 0xffffffffffffff00;
    }

    // Token : 0x6001405
    // RVA   : 0xB26F50   Offset: 0xB26350   Length: 0x29C
    public void GetRangeGrids(int centerRow, int centerColumn, int innerRange, int outerRange, bool containCenter, List<ExploreTileData> grids)
    {
        void ExplorePanelData.GetRangeGrids
                     (int64 this,int centerRow,int centerColumn,int innerRange,int outerRange,char containCenter,
                     int64 grids)
        {
        char cVar1;
        int iVar2;
        int iVar3;
        int iVar4;
        int iVar5;
        uint64 uVar6;
        int iVar7;
        int iVar8;
        int iVar9;
        if ((grids != null) && (-1 < outerRange)) {
          FUN_1812fa020(grids,DAT_181d870b8);
          iVar9 = 0;
          do {
            iVar2 = Mathf.Clamp((iVar9 - outerRange) + centerColumn,0,this.mapWidth + -1,0);
            iVar8 = -iVar9;
            iVar3 = Mathf.Clamp(iVar8 + centerColumn + outerRange,0,this.mapWidth + -1);
            if (iVar2 <= iVar3) {
              iVar2 = iVar2 - centerColumn;
              do {
                if (iVar9 == 0) {
                  cVar1 = containCenter;
                  if (iVar2 + centerColumn != centerColumn) {
                    cVar1 = true;
                  }
                  if ((((cVar1) && (-1 < centerRow)) && (centerRow < this.mapHeight)) &&
                     ((iVar7 = Mathf.Abs(iVar2), innerRange <= iVar7 &&
                      (iVar7 = Mathf.Abs(iVar2), iVar7 <= outerRange)))) {
                    if (this.exploreTileMap == null) {
        LAB_180b271e7:
                          // WARNING: Subroutine does not return
                      FUN_1800d6620();
                    }
                    uVar6 = FUN_180127f90(this.exploreTileMap,(int64)(iVar2 + centerColumn),
                                          (int64)centerRow);
                    FUN_18181e6b0(grids,uVar6,DAT_181d87038);
                  }
                }
                else {
                  iVar7 = iVar8 + centerRow;
                  if ((-1 < iVar7) && (iVar7 < this.mapHeight)) {
                    iVar4 = Mathf.Abs(iVar2);
                    iVar5 = Mathf.Abs(iVar8);
                    if (innerRange <= iVar5 + iVar4) {
                      iVar4 = Mathf.Abs(iVar2);
                      iVar5 = Mathf.Abs(iVar8);
                      if (iVar5 + iVar4 <= outerRange) {
                        if (this.exploreTileMap == null) goto LAB_180b271e7;
                        uVar6 = FUN_180127f90(this.exploreTileMap,(int64)(iVar2 + centerColumn),
                                              (int64)iVar7);
                        FUN_18181e6b0(grids,uVar6,DAT_181d87038);
                      }
                    }
                  }
                  iVar7 = iVar9 + centerRow;
                  if ((-1 < iVar7) && (iVar7 < this.mapHeight)) {
                    iVar4 = Mathf.Abs(iVar2);
                    iVar5 = Mathf.Abs(iVar9);
                    if (innerRange <= iVar5 + iVar4) {
                      iVar4 = Mathf.Abs(iVar2);
                      iVar5 = Mathf.Abs(iVar9);
                      if (iVar5 + iVar4 <= outerRange) {
                        if (this.exploreTileMap == null) goto LAB_180b271e7;
                        uVar6 = FUN_180127f90(this.exploreTileMap,(int64)(iVar2 + centerColumn),
                                              (int64)iVar7);
                        FUN_18181e6b0(grids,uVar6,DAT_181d87038);
                      }
                    }
                  }
                }
                iVar2 = iVar2 + 1;
              } while (iVar2 + centerColumn <= iVar3);
            }
            iVar9 = iVar9 + 1;
          } while (iVar9 <= outerRange);
        }
    }

    // Token : 0x6001406
    // RVA   : 0xB25960   Offset: 0xB24D60   Length: 0xFE
    private void FindConnectedGrid(bool[] vis, ExploreTileData targetGrid)
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        int iVar4;
        if ((targetGrid == null) || (vis == null)) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        if (**(uint32 **)(vis + 16) <= *(uint32 *)(targetGrid + 36)) {
          uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar3,0);
        }
        lVar2 = *(int64 *)(*(uint32 **)(vis + 16) + 4);
        if ((uint32)lVar2 <= *(uint32 *)(targetGrid + 32)) {
          uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar3,0);
        }
        *(uint8 *)
         ((int64)(int)*(uint32 *)(targetGrid + 32) + 32 +
         (int)*(uint32 *)(targetGrid + 36) * lVar2 + vis) = 1;
        if (*(int *)(targetGrid + 56) != -1) {
          iVar4 = 0;
          do {
            lVar2 = ExplorePanelData.GetGridDataByDir
                              (this,*(uint32 *)(targetGrid + 32),*(uint32 *)(targetGrid + 36),
                               iVar4,0);
            if (((lVar2 != null) && (*(int *)(lVar2 + 48) == 0)) &&
               (cVar1 = FUN_180132d10(vis,(int64)*(int *)(lVar2 + 36),
                                      (int64)*(int *)(lVar2 + 32)), !cVar1)) {
              ExplorePanelData.FindConnectedGrid(this,vis,lVar2,0);
            }
            iVar4 = iVar4 + 1;
          } while (iVar4 < 4);
        }
    }

    // Token : 0x6001407
    // RVA   : 0xB25830   Offset: 0xB24C30   Length: 0x123
    private void FindConnectedGridDistance(int[] distance, int targetDistance, ExploreTileData targetGrid)
    {
        void ExplorePanelData.FindConnectedGridDistance
                     (uint64 this,int64 distance,int targetDistance,int64 targetGrid)
        {
        int iVar1;
        int64 lVar2;
        uint64 uVar3;
        int iVar4;
        if ((targetGrid == null) || (distance == null)) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        if (**(uint32 **)(distance + 16) <= *(uint32 *)(targetGrid + 36)) {
          uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar3,0);
        }
        lVar2 = *(int64 *)(*(uint32 **)(distance + 16) + 4);
        if ((uint32)lVar2 <= *(uint32 *)(targetGrid + 32)) {
          uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar3,0);
        }
        iVar4 = 0;
        *(int *)(distance + 32 +
                ((int)*(uint32 *)(targetGrid + 36) * lVar2 + (int64)(int)*(uint32 *)(targetGrid + 32)) * 4) =
             targetDistance;
        do {
          lVar2 = ExplorePanelData.GetGridDataByDir
                            (this,*(uint32 *)(targetGrid + 32),*(uint32 *)(targetGrid + 36),iVar4
                             ,0);
          if ((lVar2 != null) && (*(int *)(lVar2 + 48) == 0)) {
            iVar1 = FUN_18014ad10(distance,(int64)*(int *)(lVar2 + 36),
                                  (int64)*(int *)(lVar2 + 32));
            if (iVar1 != 0) {
              iVar1 = FUN_18014ad10(distance,(int64)*(int *)(lVar2 + 36),
                                    (int64)*(int *)(lVar2 + 32));
              if (iVar1 > targetDistance + 1)
              {
                }
                ExplorePanelData.FindConnectedGridDistance(this,distance,targetDistance + 1,lVar2,0);
                }
              }
          iVar4 = iVar4 + 1;
          if (3 < iVar4) {
            return;
          }
        } while( true );
    }

    // Token : 0x6001408
    // RVA   : 0xB26E40   Offset: 0xB26240   Length: 0xCE
    public ExploreTileData GetGridDataByDir(int row, int column, int dir)
    {
        ulong uVar1;
        if (dir == null) {
          column = column + -1;
          if (row < 0) {
            return 0;
          }
          if (this.mapHeight <= row) {
            return 0;
          }
          if (column < 0) {
            return 0;
          }
          if (this.mapWidth <= column) {
            return 0;
          }
          if (this.exploreTileMap != null) {
            uVar1 = FUN_180127f90(this.exploreTileMap,(int64)column,(int64)row);
            return uVar1;
          }
        }
        else if (dir == 1) {
          column = column + 1;
          if (row < 0) {
            return 0;
          }
          if (this.mapHeight <= row) {
            return 0;
          }
          if (column < 0) {
            return 0;
          }
          if (this.mapWidth <= column) {
            return 0;
          }
          if (this.exploreTileMap != null) {
            uVar1 = FUN_180127f90(this.exploreTileMap,(int64)column,(int64)row);
            return uVar1;
          }
        }
        else {
          if (dir == 2) {
            row = row + -1;
          }
          else {
            if (dir != 3) {
              return 0;
            }
            row = row + 1;
          }
          if ((((row < 0) || (this.mapHeight <= row)) || (column < 0)) ||
             (this.mapWidth <= column)) {
            return 0;
          }
          if (this.exploreTileMap != null) {
            uVar1 = FUN_180127f90(this.exploreTileMap,(int64)column,(int64)row);
            return uVar1;
          }
        }
    }

    // Token : 0x6001409
    // RVA   : 0xB26F10   Offset: 0xB26310   Length: 0x3E
    public ExploreTileData GetGridData(int row, int column)
    {
        ulong uVar1;
        if ((((-1 < row) && (row < this.mapHeight)) && (-1 < column)) &&
           (column < this.mapWidth)) {
          if (this.exploreTileMap != null) {
            uVar1 = FUN_180127f90(this.exploreTileMap,(int64)column,(int64)row);
            return uVar1;
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        return 0;
    }

    // Token : 0x600140A
    // RVA   : 0xB256B0   Offset: 0xB24AB0   Length: 0x175
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

}
