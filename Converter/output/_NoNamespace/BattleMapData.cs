// ============================================================
// Type  : BattleMapData
// Token : 0x2000171
// ============================================================

public class BattleMapData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000974
    public int mapID;

    // Token: 0x4000975
    public BattleMapTypeData battleMapTypeData;

    // Token: 0x4000976
    public int mapWidth;

    // Token: 0x4000977
    public int mapHeight;

    // Token: 0x4000978
    public int wallColumn;

    // Token: 0x4000979
    public GridUnitData[] mapGrids;

    // Token: 0x400097A
    public List<GridUnitData> mustEmptyGrids;

    // Token: 0x400097B
    public List<GridUnitData> normalGrids;

    // Token: 0x400097C
    public List<GridUnitData> obstacleGrids;

    // Token: 0x400097D
    private static List<int> DefenceTrapID;

    // Token: 0x400097E
    private static List<Vector2> DefenceGuardMapGridsOffset;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000BF1
    // RVA   : 0x8DF070   Offset: 0x8DD870   Length: 0x8
    public int get_GridCount()
    {
        return this.mapHeight * this.mapWidth;
    }

    // Token : 0x6000BF2
    // RVA   : 0x8DC4D0   Offset: 0x8DACD0   Length: 0x159
    public void Generate(BattleMapTypeData _battleMapTypeData)
    {
        uint uVar1;
        ulong uVar2;
        long lVar3;
        int iVar4;
        int iVar5;
        long local_28;
        long local_20;
        if (_battleMapTypeData == null) {
        LAB_1808dc624:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        if ((0 < *(int *)(_battleMapTypeData + 20)) && (0 < *(int *)(_battleMapTypeData + 24))) {
          this.battleMapTypeData = _battleMapTypeData;
          local_28 = (int64)*(int *)(_battleMapTypeData + 20);
          this.mapWidth = *(int *)(_battleMapTypeData + 20);
          local_20 = (int64)*(int *)(_battleMapTypeData + 24);
          this.mapHeight = *(int *)(_battleMapTypeData + 24);
          uVar2 = FUN_1800d6020(DAT_181d84940,&local_28);
          this.mapGrids = uVar2;
          iVar5 = 0;
          if (0 < this.mapHeight) {
            do {
              iVar4 = 0;
              if (0 < this.mapWidth) {
                do {
                  uVar1 = this.mapID;
                  lVar3 = new GridUnitData(uVar1,iVar5,iVar4,0);
                  if (lVar3 == null) goto LAB_1808dc624;
                  GridUnitData.set_GridType(lVar3,1);
                  if (this.mapGrids == null) goto LAB_1808dc624;
                  FUN_180127fe0(this.mapGrids,(int64)iVar4,(int64)iVar5,lVar3);
                  iVar4 = iVar4 + 1;
                } while (iVar4 < this.mapWidth);
              }
              iVar5 = iVar5 + 1;
            } while (iVar5 < this.mapHeight);
          }
        }
    }

    // Token : 0x6000BF3
    // RVA   : 0x8DB990   Offset: 0x8DA190   Length: 0x34D
    public void GenerateMapObjs()
    {
        long lVar1;
        uint uVar2;
        int iVar3;
        int iVar4;
        int iVar5;
        long lVar6;
        long lVar7;
        int iVar8;
        float fVar9;
        iVar8 = 0;
        uVar2 = 0;
        if (this.battleMapTypeData == null) throw; // [null/range check failed]
        iVar3 = this.battleMapTypeData.battleMapType;
        if (((iVar3 == 0) || (iVar3 == 1)) || (iVar3 == 2)) {
          fVar9 = (float)Random.Range();
          fVar9 = (float)this.mapWidth * fVar9 * (float)this.mapHeight;
        LAB_1808dbacf:
          iVar8 = (int)fVar9;
          Random.Range();
          uVar2 = Mathf.RoundToInt();
        }
        else if (iVar3 == 3) {
          fVar9 = (float)Random.Range();
          iVar8 = (int)((float)this.mapWidth * fVar9 * (float)this.mapHeight);
        }
        else if (iVar3 == 4) {
          fVar9 = (float)Random.Range();
          fVar9 = (float)this.mapWidth * fVar9 * (float)this.mapHeight;
          goto LAB_1808dbacf;
        }
        BattleMapData.GenerateBuildingObstacle(this,iVar8,0,0);
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d8b128 + 184) + 80);
        if (lVar1 != null) {
          if (*(int *)(lVar1 + 32) != 0) {
            BattleMapData.GenerateSpeGridObj(this,uVar2,0);
          }
          if (this.normalGrids != null) {
            FUN_180f56130(this.normalGrids,DAT_181d637f8);
            if (this.obstacleGrids != null) {
              FUN_180f56130(this.obstacleGrids,DAT_181d637f8);
              lVar1 = this.mapGrids;
              if (lVar1 != null) {
                iVar3 = Array.GetUpperBound(lVar1,0,0);
                iVar4 = Array.GetUpperBound(lVar1,1);
                iVar8 = Array.GetLowerBound(lVar1,0,0);
                do {
                  if (iVar3 < iVar8) {
                    return;
                  }
                  iVar5 = Array.GetLowerBound(lVar1,1);
                  if (iVar5 <= iVar4) {
                    do {
                      lVar6 = FUN_180127f50(lVar1,(int64)iVar8);
                      if (lVar6 == null) throw; // [null/range check failed]
                      if (*(int *)(lVar6 + 20) == 1) {
                        lVar7 = this.normalGrids;
        LAB_1808dbc9a:
                        if (lVar7 == null) throw; // [null/range check failed]
                        FUN_181827900(lVar7,lVar6);
                      }
                      else if (*(int *)(lVar6 + 20) == 2) {
                        lVar7 = this.obstacleGrids;
                        goto LAB_1808dbc9a;
                      }
                      iVar5 = iVar5 + 1;
                    } while (iVar5 <= iVar4);
                  }
                  iVar8 = iVar8 + 1;
                } while( true );
              }
            }
          }
        }
    }

    // Token : 0x6000BF4
    // RVA   : 0x8DBCE0   Offset: 0x8DA4E0   Length: 0x387
    private ObstacleData GenerateObstacleData(int obstacleID, bool bigObstacle)
    {
        var pStatics = *(int64*)(DAT_181d8b128 + 184);
        long lVar1;
        ulong uVar2;
        int iVar3;
        uint uVar4;
        long lVar5;
        ulong uVar6;
        long lVar7;
        byte uVar8;
        double dVar9;
        float fVar10;
        lVar5 = *(int64 *)(pStatics + 80);
        if ((lVar5 != null) && (lVar5 = *(int64 *)(lVar5 + 600)) != null) {
          if (*(uint32 *)(lVar5 + 24) <= obstacleID) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          uVar8 = 0;
          lVar5 = lVar5[obstacleID];
          lVar1 = *(int64 *)(pStatics + 80);
          if (lVar1 != null) {
            if (*(int *)(lVar1 + 32) != 0) {
              dVar9 = (double)GlobalData.RandomRangeDouble(0,0);
              if (!bigObstacle) {
                fVar10 = 0.05;
              }
              else {
                fVar10 = 0.075;
              }
              if (dVar9 < (double)fVar10) {
                uVar8 = 1;
                lVar5 = FUN_18046bb80(0);
                if ((lVar5 == null) || (*(int64 *)(lVar5 + 0x260) == 0)) throw; // [null/range check failed]
                uVar4 = *(uint32 *)(*(int64 *)(lVar5 + 0x260) + 24);
                obstacleID = GlobalData.RandomRange(0,uVar4,0,0);
                lVar5 = FUN_18046bb80(0);
                if ((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 0x260)) == null)
                throw; // [null/range check failed]
                if (*(uint32 *)(lVar5 + 24) <= obstacleID) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar5 = lVar5[obstacleID];
              }
            }
            if ((lVar5 != null) && (lVar1 = *(int64 *)(lVar5 + 40)) != null) {
              lVar7 = lVar1;
              if (*(int *)(lVar1 + 24) == 0) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
                lVar7 = *(int64 *)(lVar5 + 40);
              }
              uVar4 = *(uint32 *)(*(int64 *)(lVar1 + 16) + 32);
              if (lVar7 != null) {
                if (*(uint32 *)(lVar7 + 24) < 2) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                iVar3 = FUN_180d8cf10(uVar4,*(int *)(*(int64 *)(lVar7 + 16) + 36) + 1,0);
                if (bigObstacle) {
                  iVar3 = iVar3 * 2;
                }
                uVar2 = *(uint64 *)(lVar5 + 24);
                uVar4 = FUN_180d8cf10(0,*(uint32 *)(lVar5 + 32),0);
                uVar6 = il2cpp_internal(DAT_181d697e8);
                ObstacleData.ctor(uVar6,0,obstacleID,uVar2,uVar4,(float)iVar3,(float)iVar3,0xffffffff,
                                   bigObstacle,uVar8,0);
                return uVar6;
              }
            }
          }
        }
    }

    // Token : 0x6000BF5
    // RVA   : 0x8DC410   Offset: 0x8DAC10   Length: 0xB5
    private ObstacleData GenerateWallData(int hp, int maxhp, int teamID)
    {
        uint64
        BattleMapData.GenerateWallData(uint64 this,int hp,int maxhp,uint32 teamID)
        {
        uint64 uVar1;
        uVar1 = il2cpp_internal(DAT_181d697e8);
        ObstacleData.ctor(uVar1,1,0xffffffff,"城墙",0,(float)hp,(float)maxhp,teamID,0,0,0)
        ;
        return uVar1;
    }

    // Token : 0x6000BF6
    // RVA   : 0x8DB680   Offset: 0x8D9E80   Length: 0x304
    public void GenerateGuard(int homeBaseRow, float guardLv, int num)
    {
        var pStatics = *(int64*)(DAT_181d8b228 + 184);
        void BattleMapData.GenerateGuard
                     (int64 this,int homeBaseRow,uint32 guardLv,uint32 num)
        {
        int iVar1;
        int64 lVar2;
        uint64 uVar3;
        int iVar4;
        float fVar5;
        int64 lVar6;
        int64 lVar7;
        uint64 uVar8;
        float extraout_var;
        uint64 uVar9;
        int iVar10;
        uint16 local_res20 [4];
        uint32 in_stack_ffffffffffffff80;
        iVar10 = 0;
        local_res20[0] = 0;
        iVar4 = Mathf.Clamp(num,0,8,0);
        if (0 < iVar4) {
          do {
            lVar6 = FUN_18046bb80(0);
            lVar7 = FUN_18046c0a0(0);
            lVar2 = *(int64 *)(*(int64 *)(DAT_181d4ef00 + 184) + 216);
            if (lVar2 == null) {
        LAB_1808db97f:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            local_res20[0] = String.get_Chars(lVar2,iVar10,0);
            uVar8 = Char.ToString(local_res20,0);
            uVar8 = String.Concat("守卫",uVar8,0);
            if (lVar7 == null) goto LAB_1808db97f;
            uVar8 = GameController.GenerateHeroData
                              (lVar7,uVar8,0xffffffff,0xffffffff,guardLv,
                               in_stack_ffffffffffffff80 & 0xffffff00,0);
            lVar7 = FUN_18046bb80(0);
            if ((lVar7 == null) || (lVar7 = *(int64 *)(lVar7 + 112)) == null) goto LAB_1808db97f;
            if (*(uint32 *)(lVar7 + 24) < 2) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar2 = this.mapGrids;
            iVar1 = this.mapWidth;
            uVar3 = *(uint64 *)(*(int64 *)(lVar7 + 16) + 40);
            lVar7 = *(int64 *)(pStatics + 8);
            if (lVar7 == null) goto LAB_1808db97f;
            fVar5 = (float)FUN_180132c70(lVar7,iVar10,DAT_181d840f8);
            lVar7 = *(int64 *)(pStatics + 8);
            if (((lVar7 == null) || (FUN_180132c70(lVar7,iVar10,DAT_181d840f8), lVar2 == null)) ||
               (uVar9 = FUN_180127f50(lVar2,(int64)((int)fVar5 + iVar1),
                                      (int64)((int)extraout_var + homeBaseRow)), lVar6 == null))
            goto LAB_1808db97f;
            in_stack_ffffffffffffff80 = 0;
            BattleController.HeroEnterBattleField(lVar6,uVar8,uVar3,uVar9,0,0,0);
            iVar10 = iVar10 + 1;
          } while (iVar10 < iVar4);
        }
    }

    // Token : 0x6000BF7
    // RVA   : 0x8D9320   Offset: 0x8D7B20   Length: 0x235C
    private void GenerateBuildingObstacle(int obstacleCount, int gap)
    {
        var pStatics = *(int64*)(DAT_181d8b128 + 184);
        int iVar1;
        ulong uVar2;
        bool cVar3;
        uint uVar4;
        int iVar5;
        int iVar6;
        uint uVar7;
        long lVar8;
        ulong uVar9;
        long lVar10;
        long lVar11;
        long lVar12;
        ulong uVar13;
        long lVar14;
        long lVar16;
        long lVar17;
        long lVar18;
        long lVar19;
        int iVar21;
        int iVar22;
        float fVar23;
        float fVar24;
        byte[] auVar25 = new byte[16];
        byte[] auVar26 = new byte[16];
        byte[] auVar27 = new byte[16];
        byte[] auVar28 = new byte[16];
        float fVar29;
        ulong in_stack_fffffffffffffee8;
        ulong uVar30;
        long local_d8;
        long local_d0;
        long local_c8;
        long local_c0;
        uint64 extraout_XMM0_Qb;
        uint64 extraout_XMM0_Qb_00;
        lVar8 = il2cpp_internal(DAT_181d6e630);
        FUN_180f58a90(lVar8,DAT_181d63678);
        uVar9 = il2cpp_internal(DAT_181d6e630);
        FUN_180f58a90(uVar9,DAT_181d63678);
        lVar10 = il2cpp_internal(DAT_181d6e630);
        FUN_180f58a90(lVar10,DAT_181d63678);
        lVar11 = this.battleMapTypeData;
        if (lVar11 == null) goto LAB_1808db659;
        iVar22 = 0;
        if (lVar11.battleMapType == 4) {
          if ((lVar11.targetArea != null) &&
             (cVar3 = AreaData.BelongPlayer(lVar11.targetArea,0), cVar3)) {
            lVar11 = FUN_18046c0a0(0);
            if (((lVar11 == null) || (lVar11.targetArea == null)) ||
               (lVar11 = WorldData.Player(lVar11.targetArea,0)) == null)
            goto LAB_1808db659;
          }
          lVar11 = *(int64 *)(pStatics + 80);
          if (((lVar11 == null) || (this.battleMapTypeData == null)) ||
             (lVar11 = *(int64 *)(lVar11 + 0x250)) == null) goto LAB_1808db659;
          uVar7 = this.battleMapTypeData.attackAreaType;
          if (lVar11.row <= uVar7) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar11 = lVar11.battleMapType[uVar7];
          if (lVar11 == null) goto LAB_1808db659;
          fVar29 = *(float *)(lVar11 + 36);
          lVar11 = *(int64 *)(pStatics + 80);
          if ((lVar11 == null) || (lVar11 = *(int64 *)(lVar11 + 112)) == null) goto LAB_1808db659;
          if (lVar11.row < 2) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar11 = *(int64 *)(lVar11.battleMapType + 40);
          if ((lVar11 == null) || (lVar11 = *(int64 *)(lVar11 + 48)) == null) goto LAB_1808db659;
          fVar23 = (float)HeroSpeAddData.Get(lVar11,211,0);
          uVar4 = Mathf.RoundToInt(((float)this.mapWidth + (float)this.mapWidth) /
                                    3.0,0);
          this.wallColumn = uVar4;
          iVar5 = Mathf.RoundToInt((float)this.mapHeight * 0.5,0);
          if (this.battleMapTypeData == null) goto LAB_1808db659;
          uVar7 = this.battleMapTypeData.attackAreaType;
          if (uVar7 < 2) {
            fVar24 = (float)BattleMapData.GetAreaDefenceLv(this,0xffffffff);
            lVar11 = this.battleMapTypeData;
            if (((lVar11 == null) || (lVar11.targetArea == null)) ||
               (lVar12 = *(int64 *)(lVar11.targetArea + 208)) == null)
            goto LAB_1808db659;
            if (*(int *)(lVar12 + 24) == 0) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
              lVar11 = this.battleMapTypeData;
              if (lVar11 == null) goto LAB_1808db659;
            }
            if (lVar11.targetArea == null) goto LAB_1808db659;
            Mathf.RoundToInt(*(float *)(lVar11.targetArea + 84) * 0.04 +
                              ((float)*(int *)(*(int64 *)(lVar12 + 16) + 32) + fVar24) * 0.2,0);
            in_stack_fffffffffffffee8 = 0;
            BattleMapData.GenerateGuard(this,iVar5);
          }
          else if (uVar7 == 2) {
            lVar11 = FUN_18046bb80(0);
            lVar12 = FUN_18046c0a0(0);
            BattleMapData.GetAreaDefenceLv(this,2);
            if ((this.battleMapTypeData == null) || (lVar12 == null)) goto LAB_1808db659;
            uVar30 = 0;
            in_stack_fffffffffffffee8 = in_stack_fffffffffffffee8 & 0xffffffffffffff00;
            uVar9 = GameController.GenerateSummonData(lVar12,0);
            lVar12 = FUN_18046bb80(0);
            if ((lVar12 == null) || (lVar12 = *(int64 *)(lVar12 + 112)) == null) goto LAB_1808db659;
            if (*(uint32 *)(lVar12 + 24) < 2) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            uVar2 = *(uint64 *)(*(int64 *)(lVar12 + 16) + 40);
            if ((this.mapGrids == null) ||
               (uVar13 = FUN_180127f50(this.mapGrids,
                                       (int64)(this.mapWidth + -1),(int64)(iVar5 + 3)),
               lVar11 == null)) goto LAB_1808db659;
            in_stack_fffffffffffffee8 = in_stack_fffffffffffffee8 & 0xffffffff00000000;
            BattleController.HeroEnterBattleField
                      (lVar11,uVar9,uVar2,uVar13,in_stack_fffffffffffffee8,uVar30 & 0xffffffff00000000,0);
            lVar11 = FUN_18046bb80(0);
            lVar12 = FUN_18046c0a0(0);
            BattleMapData.GetAreaDefenceLv(this,2);
            if ((this.battleMapTypeData == null) || (lVar12 == null)) goto LAB_1808db659;
            uVar30 = 0;
            in_stack_fffffffffffffee8 = in_stack_fffffffffffffee8 & 0xffffffffffffff00;
            uVar9 = GameController.GenerateSummonData(lVar12,0);
            lVar12 = FUN_18046bb80(0);
            if ((lVar12 == null) || (lVar12 = *(int64 *)(lVar12 + 112)) == null) goto LAB_1808db659;
            if (*(uint32 *)(lVar12 + 24) < 2) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            uVar2 = *(uint64 *)(*(int64 *)(lVar12 + 16) + 40);
            if ((this.mapGrids == null) ||
               (uVar13 = FUN_180127f50(this.mapGrids,
                                       (int64)(this.mapWidth + -1),(int64)(iVar5 + -4)),
               lVar11 == null)) goto LAB_1808db659;
            BattleController.HeroEnterBattleField
                      (lVar11,uVar9,uVar2,uVar13,in_stack_fffffffffffffee8 & 0xffffffff00000000,
                       uVar30 & 0xffffffff00000000,0);
            if ((this.battleMapTypeData == null) ||
               ((lVar11 = this.battleMapTypeData.targetArea, lVar11 == null ||
                (lVar11 = AreaData.GetCenterBuilding(lVar11,0)) == null))) goto LAB_1808db659;
            in_stack_fffffffffffffee8 = 0;
            BattleMapData.GenerateGuard
                      (this,iVar5,(float)lVar11.column + (float)lVar11.column,4,0);
          }
          if (**(int **)(DAT_181d4ef00 + 184) != 2) {
            lVar11 = *(int64 *)(pStatics + 80);
            if (((lVar11 == null) || (this.battleMapTypeData == null)) ||
               (lVar11 = *(int64 *)(lVar11 + 0x250)) == null) goto LAB_1808db659;
            uVar7 = this.battleMapTypeData.attackAreaType;
            if (lVar11.row <= uVar7) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar11 = lVar11.battleMapType[uVar7];
            if ((lVar11 = lVar11?.row) == null) goto LAB_1808db659;
            for (; iVar22 < lVar11.row; iVar22 = iVar22 + 1) {
              lVar12 = FUN_18046bb80(0);
              lVar14 = FUN_18046c0a0(0);
              BattleMapData.GetAreaDefenceLv(this,2);
              if ((this.battleMapTypeData == null) || (lVar14 == null)) goto LAB_1808db659;
              uVar30 = 0;
              in_stack_fffffffffffffee8 = in_stack_fffffffffffffee8 & 0xffffffffffffff00;
              uVar9 = GameController.GenerateSummonData(lVar14,0);
              lVar14 = FUN_18046bb80(0);
              if ((lVar14 == null) || (lVar14 = *(int64 *)(lVar14 + 112)) == null)
              goto LAB_1808db659;
              if (*(uint32 *)(lVar14 + 24) < 2) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar16 = this.mapGrids;
              uVar2 = *(uint64 *)(*(int64 *)(lVar14 + 16) + 40);
              fVar24 = (float)lVar11.row * 0.5;
              if (((float)iVar22 == fVar24) || ((float)iVar22 == fVar24 - 1.0)) {
                iVar21 = this.wallColumn;
              }
              else {
                iVar21 = this.wallColumn + 1;
              }
              iVar6 = FUN_1800d6750(lVar11,iVar22,DAT_181d68270);
              if ((lVar16 == null) ||
                 (uVar13 = FUN_180127f50(lVar16,(int64)iVar21,(int64)iVar6), lVar12 == null))
              goto LAB_1808db659;
              in_stack_fffffffffffffee8 = in_stack_fffffffffffffee8 & 0xffffffff00000000;
              BattleController.HeroEnterBattleField
                        (lVar12,uVar9,uVar2,uVar13,in_stack_fffffffffffffee8,uVar30 & 0xffffffff00000000,0
                        );
            }
            lVar11 = FUN_18046bb80(0);
            if ((lVar11 == null) || (lVar11 = *(int64 *)(lVar11 + 112)) == null) goto LAB_1808db659;
            if (lVar11.row < 2) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar11 = *(int64 *)(lVar11.battleMapType + 40);
            lVar12 = FUN_18046bb80(0);
            lVar14 = FUN_18046c0a0(0);
            if (this.battleMapTypeData == null) goto LAB_1808db659;
            iVar22 = this.battleMapTypeData.attackAreaType;
            BattleMapData.GetAreaDefenceLv(this,0xffffffff);
            if ((this.battleMapTypeData == null) || (lVar14 == null)) goto LAB_1808db659;
            uVar9 = 9;
            if (iVar22 != 2) {
              uVar9 = 6;
            }
            uVar30 = 0;
            in_stack_fffffffffffffee8 = in_stack_fffffffffffffee8 & 0xffffffffffffff00;
            uVar9 = GameController.GenerateSummonData(lVar14,uVar9);
            lVar14 = FUN_18046bb80(0);
            if ((lVar14 == null) || (lVar14 = *(int64 *)(lVar14 + 112)) == null) goto LAB_1808db659;
            if (*(uint32 *)(lVar14 + 24) < 2) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            uVar2 = *(uint64 *)(*(int64 *)(lVar14 + 16) + 40);
            if ((this.mapGrids == null) ||
               (uVar13 = FUN_180127f50(this.mapGrids,
                                       (int64)(this.mapWidth + -1),(int64)iVar5),
               lVar12 == null)) goto LAB_1808db659;
            in_stack_fffffffffffffee8 = in_stack_fffffffffffffee8 & 0xffffffff00000000;
            lVar12 = BattleController.HeroEnterBattleField
                               (lVar12,uVar9,uVar2,uVar13,in_stack_fffffffffffffee8,
                                uVar30 & 0xffffffff00000000,0);
            if ((lVar12 == null) || (uVar9 = GameObject.GetComponent(lVar12,DAT_181d9e778), lVar11 == null))
            goto LAB_1808db659;
            BattleTeam.AddNeedProtectUnit(lVar11,uVar9,0);
            lVar11 = FUN_18046bb80(0);
            lVar12 = FUN_18046c0a0(0);
            BattleMapData.GetAreaDefenceLv(this,4);
            if ((this.battleMapTypeData == null) || (lVar12 == null)) goto LAB_1808db659;
            uVar30 = 0;
            in_stack_fffffffffffffee8 = in_stack_fffffffffffffee8 & 0xffffffffffffff00;
            uVar9 = GameController.GenerateSummonData(lVar12,7);
            lVar12 = FUN_18046bb80(0);
            if ((lVar12 == null) || (lVar12 = *(int64 *)(lVar12 + 112)) == null) goto LAB_1808db659;
            if (*(uint32 *)(lVar12 + 24) < 2) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            uVar2 = *(uint64 *)(*(int64 *)(lVar12 + 16) + 40);
            if ((this.mapGrids == null) ||
               (uVar13 = FUN_180127f50(this.mapGrids,
                                       (int64)(this.mapWidth + -1),(int64)(iVar5 + -1)),
               lVar11 == null)) goto LAB_1808db659;
            BattleController.HeroEnterBattleField
                      (lVar11,uVar9,uVar2,uVar13,in_stack_fffffffffffffee8 & 0xffffffff00000000,
                       uVar30 & 0xffffffff00000000,0);
          }
          auVar25._0_8_ = BattleMapData.GetAreaDefenceLv(this,3);
          auVar25._8_8_ = extraout_XMM0_Qb;
          if (this.battleMapTypeData == null) goto LAB_1808db659;
          auVar26._4_12_ = auVar25._4_12_;
          auVar26._0_4_ =
               ((float)auVar25._0_8_ * 100.0 + 100.0) * (fVar23 + 1.0) * fVar29 *
               this.battleMapTypeData.defenceHpRate;
          uVar4 = Mathf.RoundToInt(auVar26._0_8_,0);
          uVar4 = Mathf.Max(10,uVar4);
          iVar22 = this.mapHeight;
          plVar15 = (int64 *)0;
          if (0 < iVar22) {
            do {
              iVar5 = (int)plVar15;
              fVar23 = (float)iVar5;
              fVar29 = (float)iVar22 * 0.5;
              if ((fVar23 == fVar29) || (fVar23 == fVar29 - 1.0)) {
                if (this.mapGrids == null) goto LAB_1808db659;
                lVar12 = (int64)iVar5;
                lVar11 = FUN_180127f50(this.mapGrids,(int64)this.wallColumn,
                                       lVar12);
                lVar14 = FUN_18046bb80(0);
                if ((lVar14 == null) || (lVar14 = *(int64 *)(lVar14 + 0x248)) == null)
                goto LAB_1808db659;
                if (*(uint32 *)(lVar14 + 24) < 2) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar14 = *(int64 *)(*(int64 *)(lVar14 + 16) + 40);
                if ((lVar14 == null) || (plVar15 = (int64 *)SpeGridObjData.Clone(lVar14,0), lVar11 == null))
                goto LAB_1808db659;
                plVar20 = (int64 *)0;
                if (plVar15 != (int64 *)0) {
                }
                *(int64 **)(lVar11 + 56) = plVar20;
                if (((this.mapGrids == null) ||
                    (lVar11 = FUN_180127f50(this.mapGrids,
                                            (int64)this.wallColumn,lVar12), lVar11 == null)) ||
                   (*(int64 *)(lVar11 + 56) == 0)) goto LAB_1808db659;
                *(uint8 *)(*(int64 *)(lVar11 + 56) + 72) = 1;
                iVar22 = -2;
                do {
                  lVar11 = this.mustEmptyGrids;
                  if ((this.mapGrids == null) ||
                     (uVar9 = FUN_180127f50(this.mapGrids,
                                            (int64)(this.wallColumn + iVar22),lVar12),
                     lVar11 == null)) goto LAB_1808db659;
                  FUN_181827900(lVar11,uVar9,DAT_181d63778);
                  iVar22 = iVar22 + 1;
                } while (iVar22 < 2);
              }
              else {
                if ((fVar23 <= fVar29 + 3.0) && (fVar29 - 4.0 <= fVar23)) {
                  if (this.mapGrids == null) goto LAB_1808db659;
                  lVar12 = (int64)iVar5;
                  lVar11 = FUN_180127f50(this.mapGrids,
                                         (int64)(this.wallColumn + -1),lVar12);
                  if (lVar11 == null) goto LAB_1808db659;
                  GridUnitData.set_GridType(lVar11,2);
                  if (this.mapGrids == null) goto LAB_1808db659;
                  lVar11 = FUN_180127f50(this.mapGrids,
                                         (int64)this.wallColumn + -1,lVar12);
                  uVar9 = BattleMapData.GenerateWallData(this,uVar4,uVar4,1,0);
                  if (lVar11 == null) goto LAB_1808db659;
                  *(uint64 *)(lVar11 + 48) = uVar9;
                  if (((this.mapGrids == null) ||
                      (lVar11 = FUN_180127f50(this.mapGrids,
                                              (int64)this.wallColumn + -1,lVar12), lVar11 == null
                      )) || (*(int64 *)(lVar11 + 48) == 0)) goto LAB_1808db659;
                  lVar11 = *(int64 *)(*(int64 *)(lVar11 + 48) + 56);
                  if ((this.mapGrids == null) ||
                     (uVar9 = FUN_180127f50(this.mapGrids,
                                            (int64)(this.wallColumn + -1),lVar12), lVar11 == null
                     )) goto LAB_1808db659;
                  FUN_181827900(lVar11,uVar9,DAT_181d63778);
                }
                if (this.mapGrids == null) goto LAB_1808db659;
                lVar12 = (int64)iVar5;
                lVar11 = FUN_180127f50(this.mapGrids,(int64)this.wallColumn,
                                       lVar12);
                if (lVar11 == null) goto LAB_1808db659;
                cVar3 = GridUnitData.isEmpty(lVar11,0);
                if (cVar3) {
                  if ((this.mapGrids == null) ||
                     (lVar11 = FUN_180127f50(this.mapGrids,
                                             (int64)this.wallColumn,lVar12), lVar11 == null))
                  goto LAB_1808db659;
                  GridUnitData.set_GridType(lVar11,2);
                  if (this.mapGrids == null) goto LAB_1808db659;
                  lVar11 = FUN_180127f50(this.mapGrids,(int64)this.wallColumn,
                                         lVar12);
                  uVar9 = BattleMapData.GenerateWallData(this,uVar4,uVar4,1,0);
                  if (lVar11 == null) goto LAB_1808db659;
                  *(uint64 *)(lVar11 + 48) = uVar9;
                  if (((this.mapGrids == null) ||
                      (lVar11 = FUN_180127f50(this.mapGrids,
                                              (int64)this.wallColumn,lVar12), lVar11 == null)) ||
                     (*(int64 *)(lVar11 + 48) == 0)) goto LAB_1808db659;
                  lVar11 = *(int64 *)(*(int64 *)(lVar11 + 48) + 56);
                  if ((this.mapGrids == null) ||
                     (uVar9 = FUN_180127f50(this.mapGrids,
                                            (int64)this.wallColumn,lVar12), lVar11 == null))
                  goto LAB_1808db659;
                  FUN_181827900(lVar11,uVar9,DAT_181d63778);
                }
              }
              iVar22 = this.mapHeight;
              plVar15 = (int64 *)(uint64)(iVar5 + 1U);
            } while ((int)(iVar5 + 1U) < iVar22);
          }
          lVar12 = il2cpp_internal(DAT_181d6e630);
          FUN_180f58a90(lVar12,DAT_181d63678);
          lVar11 = this.mapGrids;
          if (lVar11 == null) goto LAB_1808db659;
          iVar5 = Array.GetUpperBound(lVar11,0,0);
          iVar21 = Array.GetUpperBound(lVar11,1);
          for (iVar22 = Array.GetLowerBound(lVar11,0,0); iVar22 <= iVar5; iVar22 = iVar22 + 1) {
            iVar6 = Array.GetLowerBound(lVar11,1);
            if (iVar6 <= iVar21) {
              do {
                lVar14 = FUN_180127f50(lVar11,(int64)iVar22);
                if (lVar14 == null) goto LAB_1808db659;
                cVar3 = GridUnitData.isEmpty(lVar14,1);
                if (cVar3) {
                  if (this.mustEmptyGrids == null) goto LAB_1808db659;
                  cVar3 = FUN_1818279a0(this.mustEmptyGrids,lVar14);
                  if (!cVar3) {
                    if (((this.wallColumn + -3 <= *(int *)(lVar14 + 40)) &&
                        (*(int *)(lVar14 + 40) <= this.wallColumn + 3)) &&
                       ((1 < *(int *)(lVar14 + 36) &&
                        (*(int *)(lVar14 + 36) <= this.mapHeight + -3)))) {
                      if (lVar12 == null) goto LAB_1808db659;
                      FUN_181827900(lVar12,lVar14);
                    }
                  }
                }
                iVar6 = iVar6 + 1;
              } while (iVar6 <= iVar21);
            }
          }
          auVar27._0_8_ = BattleMapData.GetAreaDefenceLv(this,1);
          auVar27._8_8_ = extraout_XMM0_Qb_00;
          if (lVar12 == null) goto LAB_1808db659;
          iVar22 = 0;
          auVar28._4_12_ = auVar27._4_12_;
          auVar28._0_4_ = (float)auVar27._0_8_ * 3.0 + 3.0;
          fVar29 = (float)Mathf.Min(auVar28._0_8_,(float)*(int *)(lVar12 + 24) * 0.33,0);
          if (0.0 < fVar29) {
            do {
              uVar7 = FUN_180d8cf10(0,*(uint32 *)(lVar12 + 24),0);
              if (*(uint32 *)(lVar12 + 24) <= uVar7) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar11 = lVar12[uVar7];
              FUN_181801c10(lVar12,lVar11,DAT_181d638f8);
              lVar14 = FUN_18046bb80(0);
              if (lVar14 == null) goto LAB_1808db659;
              lVar14 = *(int64 *)(lVar14 + 0x248);
              lVar16 = **(int64 **)(DAT_181d8b228 + 184);
              if (lVar16 == null) goto LAB_1808db659;
              uVar4 = FUN_180d8cf10(0,*(uint32 *)(lVar16 + 24),0);
              uVar4 = FUN_1800d6750(lVar16,uVar4,DAT_181d68270);
              if (((lVar14 == null) || (lVar14 = FUN_180002f80(lVar14,uVar4,DAT_181d7bf58)) == null) ||
                 (plVar15 = (int64 *)SpeGridObjData.Clone(lVar14,0), lVar11 == null)) goto LAB_1808db659;
              plVar20 = (int64 *)0;
              if (plVar15 != (int64 *)0) {
              }
              *(int64 **)(lVar11 + 56) = plVar20;
              if (*(int64 *)(lVar11 + 56) == 0) goto LAB_1808db659;
              iVar22 = iVar22 + 1;
              *(uint32 *)(*(int64 *)(lVar11 + 56) + 48) = 1;
            } while ((float)iVar22 < fVar29);
          }
        }
        lVar11 = this.mapGrids;
        if (lVar11 != null) {
          iVar5 = Array.GetUpperBound(lVar11,0,0);
          iVar21 = Array.GetUpperBound(lVar11,1);
          for (iVar22 = Array.GetLowerBound(lVar11,0,0); iVar22 <= iVar5; iVar22 = iVar22 + 1) {
            iVar6 = Array.GetLowerBound(lVar11,1);
            if (iVar6 <= iVar21) {
              do {
                lVar12 = FUN_180127f50(lVar11,(int64)iVar22);
                if (lVar12 == null) goto LAB_1808db659;
                cVar3 = GridUnitData.isEmpty(lVar12,1);
                if (cVar3) {
                  if (this.mustEmptyGrids == null) goto LAB_1808db659;
                  cVar3 = FUN_1818279a0(this.mustEmptyGrids,lVar12);
                  if (((!cVar3) && (iVar1 = *(int *)(lVar12 + 40), 0 < iVar1)) &&
                     (iVar1 < this.mapWidth + -1)) {
                    if (this.battleMapTypeData == null) goto LAB_1808db659;
                    if (this.battleMapTypeData.battleMapType == 4) {
                      fVar29 = (float)this.mapHeight * 0.5;
                      if ((((float)*(int *)(lVar12 + 36) == fVar29) ||
                          ((float)*(int *)(lVar12 + 36) == fVar29 - 1.0)) ||
                         (this.wallColumn <= iVar1)) goto LAB_1808da90b;
                    }
                    if ((lVar8 == null) || (FUN_181827900(lVar8,lVar12,DAT_181d63778), lVar10 == null))
                    goto LAB_1808db659;
                    FUN_181827900(lVar10,lVar12);
                  }
                }
        LAB_1808da90b:
                iVar6 = iVar6 + 1;
              } while (iVar6 <= iVar21);
            }
          }
          lVar11 = il2cpp_internal(DAT_181d6f030);
          FUN_180f58a90(lVar11,DAT_181d678f8);
          iVar22 = 0;
          while( true ) {
            lVar12 = *(int64 *)(pStatics + 80);
            if ((lVar12 == null) || (lVar12 = *(int64 *)(lVar12 + 600)) == null) break;
            if (*(int *)(lVar12 + 24) <= iVar22) goto joined_r0x0001808dac21;
            lVar12 = FUN_18046bb80(0);
            if ((((lVar12 == null) || (*(int64 *)(lVar12 + 600) == 0)) ||
                (lVar12 = FUN_180002f80(*(int64 *)(lVar12 + 600),iVar22,DAT_181d6e868)) == null)
               || ((this.battleMapTypeData == null || (*(int64 *)(lVar12 + 16) == 0)))) break;
            cVar3 = FUN_181815240(*(int64 *)(lVar12 + 16),
                                  this.battleMapTypeData.battleMapType);
            if (cVar3) {
              iVar5 = 0;
              iVar21 = 0;
              while( true ) {
                lVar12 = FUN_18046bb80(0);
                if ((((lVar12 == null) || (*(int64 *)(lVar12 + 600) == 0)) ||
                    (lVar12 = FUN_180002f80(*(int64 *)(lVar12 + 600),iVar22)) == null) ||
                   (*(int64 *)(lVar12 + 56) == 0)) goto LAB_1808db659;
                if (*(int *)(*(int64 *)(lVar12 + 56) + 24) <= iVar21) goto LAB_1808dabe9;
                lVar12 = FUN_18046bb80(0);
                if (((lVar12 == null) || (*(int64 *)(lVar12 + 600) == 0)) ||
                   ((lVar12 = FUN_180002f80(*(int64 *)(lVar12 + 600),iVar22,DAT_181d6e868), lVar12 == null
                    || (((*(int64 *)(lVar12 + 56) == 0 ||
                         (lVar12 = FUN_180002f80(*(int64 *)(lVar12 + 56),iVar21,DAT_181d6e968),
                         lVar12 == null)) || (this.battleMapTypeData == null)))))) goto LAB_1808db659;
                if (*(int *)(lVar12 + 16) == this.battleMapTypeData.battleMapType) break;
                iVar21 = iVar21 + 1;
              }
              lVar12 = FUN_18046bb80(0);
              if (((lVar12 == null) || (*(int64 *)(lVar12 + 600) == 0)) ||
                 ((lVar12 = FUN_180002f80(*(int64 *)(lVar12 + 600),iVar22,DAT_181d6e868), lVar12 == null
                  || ((*(int64 *)(lVar12 + 56) == 0 ||
                      (lVar12 = FUN_180002f80(*(int64 *)(lVar12 + 56),iVar21)) == null)))))
              break;
              iVar5 = *(int *)(lVar12 + 20);
        LAB_1808dabe9:
              iVar21 = 0;
              if (0 < iVar5 + 1) {
                do {
                  if (lVar11 == null) goto LAB_1808db659;
                  FUN_181814fa0(lVar11,iVar22);
                  iVar21 = iVar21 + 1;
                } while (iVar21 < iVar5 + 1);
              }
            }
            iVar22 = iVar22 + 1;
          }
        }
        LAB_1808db659:
                          // WARNING: Subroutine does not return
        FUN_1800d6620();
        joined_r0x0001808dac21:
        do {
          if (obstacleCount < 1) {
            return;
          }
          if (lVar8 == null) goto LAB_1808db659;
          if (*(int *)(lVar8 + 24) < 1) {
            return;
          }
          uVar7 = FUN_180d8cf10(0,*(int *)(lVar8 + 24),0);
          if (*(uint32 *)(lVar8 + 24) <= uVar7) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar12 = lVar8[uVar7];
          if ((lVar12 == null) || (GridUnitData.set_GridType(lVar12,2), lVar10 == null)) {
        LAB_1808db677:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          FUN_181801c10(lVar10,lVar12,DAT_181d638f8);
          local_d8 = (int64)this.mapWidth;
          local_d0 = (int64)this.mapHeight;
          lVar14 = FUN_1800d6020(DAT_181d84740,&local_d8);
          if (*(int *)(lVar10 + 24) == 0) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          BattleMapData.FindConnectedGrid
                    (this,lVar14,*(uint64 *)(*(int64 *)(lVar10 + 16) + 32),0);
          iVar22 = 0;
          if (0 < this.mapWidth) {
            do {
              iVar5 = 0;
              if (0 < this.mapHeight) {
                do {
                  if (this.mapGrids == null) goto LAB_1808db677;
                  lVar16 = FUN_180127f50(this.mapGrids,(int64)iVar22,(int64)iVar5);
                  if (lVar16 == null) goto LAB_1808db677;
                  if (*(int *)(lVar16 + 20) == 1) {
                    if (lVar14 == null) goto LAB_1808db677;
                    cVar3 = FUN_180132c20(lVar14,(int64)iVar22,(int64)iVar5);
                    if (!cVar3) {
                      GridUnitData.set_GridType(lVar12,1);
                      FUN_181827900(lVar10,lVar12,DAT_181d63778);
                      FUN_181801c10(lVar8,lVar12);
                      goto joined_r0x0001808dac21;
                    }
                  }
                  iVar5 = iVar5 + 1;
                } while (iVar5 < this.mapHeight);
              }
              iVar22 = iVar22 + 1;
            } while (iVar22 < this.mapWidth);
          }
          FUN_181801c10(lVar8,lVar12,DAT_181d638f8);
          fVar29 = (float)Random.get_value(0);
          if (fVar29 < 0.1) {
            lVar14 = il2cpp_internal(DAT_181d6f030);
            FUN_180f58a90(lVar14,DAT_181d678f8);
            if (lVar14 != null) {
              FUN_181814fa0(lVar14,0,DAT_181d67a78);
              FUN_181814fa0(lVar14,1,DAT_181d67a78);
              FUN_181814fa0(lVar14,2,DAT_181d67a78);
              FUN_181814fa0(lVar14,3,DAT_181d67a78);
              if (*(int *)(lVar12 + 40) == 0) {
                FUN_181801c10(lVar14,0,DAT_181d67e70);
                uVar9 = 1;
        LAB_1808daea3:
                FUN_181801c10(lVar14,uVar9,DAT_181d67e70);
              }
              else if (*(int *)(lVar12 + 40) == this.mapWidth + -1) {
                FUN_181801c10(lVar14,2,DAT_181d67e70);
                uVar9 = 3;
                goto LAB_1808daea3;
              }
              if (*(int *)(lVar12 + 36) == 0) {
                FUN_181801c10(lVar14,0,DAT_181d67e70);
                uVar9 = 2;
              }
              else {
                if (*(int *)(lVar12 + 36) == this.mapHeight + -1)
                {
                  FUN_181801c10(lVar14,1,DAT_181d67e70);
                  uVar9 = 3;
                  }
                  FUN_181801c10(lVar14,uVar9,DAT_181d67e70);
                }
              lVar16 = il2cpp_internal(DAT_181d6e630);
              FUN_180f58a90(lVar16,DAT_181d63678);
              lVar17 = il2cpp_internal(DAT_181d6e630);
              FUN_180f58a90(lVar17,DAT_181d63678);
        LAB_1808daf40:
              if (0 < *(int *)(lVar14 + 24)) {
                uVar4 = FUN_180d8cf10(0,*(int *)(lVar14 + 24),0);
                iVar22 = FUN_1800d6750(lVar14,uVar4,DAT_181d68270);
                FUN_181801c10(lVar14,iVar22,DAT_181d67e70);
                if ((lVar16 == null) || (FUN_180f56130(lVar16,DAT_181d637f8), lVar17 == null))
                goto LAB_1808db659;
                FUN_180f56130(lVar17,DAT_181d637f8);
                if (iVar22 == 0) {
                  uVar9 = BattleMapData.GetGridData
                                    (this,*(int *)(lVar12 + 36) + -1,*(uint32 *)(lVar12 + 40));
                  FUN_181827900(lVar16,uVar9,DAT_181d63778);
                  uVar9 = BattleMapData.GetGridData
                                    (this,*(uint32 *)(lVar12 + 36),*(int *)(lVar12 + 40) + -1);
                  FUN_181827900(lVar16,uVar9,DAT_181d63778);
                  iVar22 = *(int *)(lVar12 + 40) + -1;
        LAB_1808db14e:
                  iVar5 = *(int *)(lVar12 + 36) + -1;
        LAB_1808db155:
                  uVar9 = BattleMapData.GetGridData(this,iVar5,iVar22);
                  FUN_181827900(lVar16,uVar9,DAT_181d63778);
                }
                else {
                  if (iVar22 == 1) {
                    uVar9 = BattleMapData.GetGridData
                                      (this,*(int *)(lVar12 + 36) + 1,*(uint32 *)(lVar12 + 40))
                    ;
                    FUN_181827900(lVar16,uVar9,DAT_181d63778);
                    uVar9 = BattleMapData.GetGridData
                                      (this,*(uint32 *)(lVar12 + 36),*(int *)(lVar12 + 40) + -1
                                      );
                    FUN_181827900(lVar16,uVar9,DAT_181d63778);
                    iVar22 = *(int *)(lVar12 + 40) + -1;
                    iVar5 = *(int *)(lVar12 + 36) + 1;
                    goto LAB_1808db155;
                  }
                  if (iVar22 == 2) {
                    uVar9 = BattleMapData.GetGridData
                                      (this,*(int *)(lVar12 + 36) + -1,*(uint32 *)(lVar12 + 40)
                                      );
                    FUN_181827900(lVar16,uVar9,DAT_181d63778);
                    uVar9 = BattleMapData.GetGridData
                                      (this,*(uint32 *)(lVar12 + 36),*(int *)(lVar12 + 40) + 1)
                    ;
                    FUN_181827900(lVar16,uVar9,DAT_181d63778);
                    iVar22 = *(int *)(lVar12 + 40) + 1;
                    goto LAB_1808db14e;
                  }
                  if (iVar22 == 3) {
                    uVar9 = BattleMapData.GetGridData
                                      (this,*(int *)(lVar12 + 36) + 1,*(uint32 *)(lVar12 + 40))
                    ;
                    FUN_181827900(lVar16,uVar9,DAT_181d63778);
                    uVar9 = BattleMapData.GetGridData
                                      (this,*(uint32 *)(lVar12 + 36),*(int *)(lVar12 + 40) + 1)
                    ;
                    FUN_181827900(lVar16,uVar9,DAT_181d63778);
                    iVar22 = *(int *)(lVar12 + 40) + 1;
                    iVar5 = *(int *)(lVar12 + 36) + 1;
                    goto LAB_1808db155;
                  }
                }
                for (iVar22 = 0; iVar22 < *(int *)(lVar16 + 24); iVar22 = iVar22 + 1) {
                  uVar9 = FUN_180002f80(lVar16,iVar22,DAT_181d63bf8);
                  cVar3 = FUN_1818279a0(lVar8,uVar9,DAT_181d63878);
                  if (!cVar3) {
                    lVar18 = FUN_180002f80(lVar16,iVar22);
                    if (lVar18 == null) goto LAB_1808db659;
                    if (*(int *)(lVar18 + 20) != 2) goto LAB_1808daf40;
                    lVar18 = FUN_180002f80(lVar16,iVar22);
                    if ((lVar18 == null) || (*(int64 *)(lVar18 + 48) == 0)) goto LAB_1808db659;
                    if (*(int *)(*(int64 *)(lVar18 + 48) + 16) != 0) goto LAB_1808daf40;
                    lVar18 = FUN_180002f80(lVar16,iVar22);
                    if ((lVar18 == null) || (*(int64 *)(lVar18 + 48) == 0)) goto LAB_1808db659;
                    if (*(char *)(*(int64 *)(lVar18 + 48) + 48) != false) goto LAB_1808daf40;
                  }
                }
                for (iVar22 = 0; iVar22 < *(int *)(lVar16 + 24); iVar22 = iVar22 + 1) {
                  lVar18 = FUN_180002f80(lVar16,iVar22,DAT_181d63bf8);
                  if (lVar18 == null) goto LAB_1808db659;
                  if (*(int *)(lVar18 + 20) == 1) {
                    uVar9 = FUN_180002f80(lVar16,iVar22,DAT_181d63bf8);
                    FUN_181827900(lVar17,uVar9,DAT_181d63778);
                    lVar18 = FUN_180002f80(lVar16,iVar22,DAT_181d63bf8);
                    if (lVar18 == null) goto LAB_1808db659;
                    GridUnitData.set_GridType(lVar18,2);
                    uVar9 = FUN_180002f80(lVar16,iVar22,DAT_181d63bf8);
                    FUN_181801c10(lVar10,uVar9,DAT_181d638f8);
                  }
                }
                local_c8 = (int64)this.mapWidth;
                local_c0 = (int64)this.mapHeight;
                lVar18 = FUN_1800d6020(DAT_181d84740,&local_c8);
                if (*(int *)(lVar10 + 24) == 0) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                BattleMapData.FindConnectedGrid
                          (this,lVar18,*(uint64 *)(*(int64 *)(lVar10 + 16) + 32),0);
                iVar22 = 0;
                if (0 < this.mapWidth) {
                  do {
                    iVar5 = 0;
                    if (0 < this.mapHeight) {
                      do {
                        if (this.mapGrids == null) {
        LAB_1808db671:
                          // WARNING: Subroutine does not return
                          FUN_1800d6620();
                        }
                        lVar19 = FUN_180127f50(this.mapGrids,(int64)iVar22,
                                               (int64)iVar5);
                        if (lVar19 == null) goto LAB_1808db671;
                        if (*(int *)(lVar19 + 20) == 1) {
                          if (lVar18 == null) goto LAB_1808db671;
                          cVar3 = FUN_180132c20(lVar18,(int64)iVar22);
                          if (!cVar3) {
                            iVar22 = 0;
                            goto LAB_1808db4d0;
                          }
                        }
                        iVar5 = iVar5 + 1;
                      } while (iVar5 < this.mapHeight);
                    }
                    iVar22 = iVar22 + 1;
                  } while (iVar22 < this.mapWidth);
                }
                if (lVar11 == null) goto LAB_1808db659;
                uVar4 = FUN_180d8cf10(0,lVar11.row,0);
                uVar4 = FUN_1800d6750(lVar11,uVar4,DAT_181d68270);
                lVar14 = BattleMapData.GenerateObstacleData(this,uVar4,1);
                plVar15 = (int64 *)(lVar12 + 48);
                *plVar15 = lVar14;
                il2cpp_internal(plVar15,lVar14);
                if ((*plVar15 == 0) || (lVar14 = *(int64 *)(*plVar15 + 56)) == null)
                goto LAB_1808db659;
                FUN_181827900(lVar14,lVar12);
                iVar22 = 0;
                goto LAB_1808db430;
              }
              goto LAB_1808db554;
            }
            goto LAB_1808db659;
          }
        LAB_1808db554:
          if (lVar11 == null) goto LAB_1808db659;
          uVar4 = FUN_180d8cf10(0,lVar11.row,0);
          uVar4 = FUN_1800d6750(lVar11,uVar4,DAT_181d68270);
          uVar9 = BattleMapData.GenerateObstacleData(this,uVar4,0);
          *(uint64 *)(lVar12 + 48) = uVar9;
          if ((*(int64 *)(lVar12 + 48) == 0) ||
             (lVar14 = *(int64 *)(*(int64 *)(lVar12 + 48) + 56)) == null)
          goto LAB_1808db659;
          FUN_181827900(lVar14,lVar12);
          obstacleCount = obstacleCount + -1;
        } while( true );
        LAB_1808db4d0:
        if (*(int *)(lVar17 + 24) <= iVar22) goto LAB_1808daf40;
        lVar18 = FUN_180002f80(lVar17,iVar22,DAT_181d63bf8);
        if (lVar18 == null) goto LAB_1808db659;
        GridUnitData.set_GridType(lVar18,1);
        uVar9 = FUN_180002f80(lVar17,iVar22,DAT_181d63bf8);
        FUN_181827900(lVar10,uVar9);
        iVar22 = iVar22 + 1;
        goto LAB_1808db4d0;
        LAB_1808db430:
        if (*(int *)(lVar16 + 24) <= iVar22) goto LAB_1808db53d;
        lVar12 = FUN_180002f80(lVar16,iVar22,DAT_181d63bf8);
        if (lVar12 == null) goto LAB_1808db659;
        *(int64 *)(lVar12 + 48) = *plVar15;
        if (*plVar15 == 0) goto LAB_1808db659;
        lVar12 = *(int64 *)(*plVar15 + 56);
        uVar9 = FUN_180002f80(lVar16,iVar22,DAT_181d63bf8);
        if (lVar12 == null) goto LAB_1808db659;
        FUN_181827900(lVar12,uVar9,DAT_181d63778);
        uVar9 = FUN_180002f80(lVar16,iVar22,DAT_181d63bf8);
        FUN_181801c10(lVar8,uVar9);
        iVar22 = iVar22 + 1;
        goto LAB_1808db430;
        LAB_1808db53d:
        obstacleCount = obstacleCount + -2;
        goto joined_r0x0001808dac21;
    }

    // Token : 0x6000BF8
    // RVA   : 0x8DEB20   Offset: 0x8DD320   Length: 0xA0
    public bool NormalGridAllConnected(bool[] vis)
    {
        bool cVar1;
        long lVar2;
        int iVar3;
        int iVar4;
        iVar4 = 0;
        if (0 < this.mapWidth) {
          do {
            iVar3 = 0;
            if (0 < this.mapHeight) {
              do {
                if (this.mapGrids == null) {
        LAB_1808debbb:
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                lVar2 = FUN_180127f50(this.mapGrids,(int64)iVar4,(int64)iVar3);
                if (lVar2 == null) goto LAB_1808debbb;
                if (*(int *)(lVar2 + 20) == 1) {
                  if (vis == null) goto LAB_1808debbb;
                  cVar1 = FUN_180132c20(vis,(int64)iVar4,(int64)iVar3);
                  if (!cVar1) {
                    return false;
                  }
                }
                iVar3 = iVar3 + 1;
              } while (iVar3 < this.mapHeight);
            }
            iVar4 = iVar4 + 1;
          } while (iVar4 < this.mapWidth);
        }
        return true;
    }

    // Token : 0x6000BF9
    // RVA   : 0x8DC630   Offset: 0x8DAE30   Length: 0x120
    public float GetAreaDefenceLv(int defenceType)
    {
        long lVar1;
        lVar1 = this.battleMapTypeData;
        if (lVar1 != null) {
          if (lVar1.attackAreaType == 2) {
            if (lVar1.targetArea != null) {
              lVar1 = AreaData.GetCenterBuilding(lVar1.targetArea,0);
              if (lVar1 != null) {
                return (float)lVar1.column * 0.5 + 5.0;
              }
            }
          }
          else {
            if (lVar1.attackAreaType == 3) {
              return (float)lVar1.difficulty * 0.5;
            }
            if (defenceType == 0xffffffff) {
              if (lVar1.targetArea != null) {
                lVar1 = AreaData.FindBuilding(lVar1.targetArea,"分舵",0);
                if (lVar1 != null) {
                  return (float)lVar1.column;
                }
              }
            }
            else if ((lVar1.targetArea != null) &&
                    (lVar1 = *(int64 *)(lVar1.targetArea + 208)) != null) {
              if (lVar1.row <= defenceType) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              return (float)lVar1.battleMapType[defenceType];
            }
          }
        }
    }

    // Token : 0x6000BFA
    // RVA   : 0x8DC760   Offset: 0x8DAF60   Length: 0xAD
    public float GetAreaWallSkinLv()
    {
        long lVar1;
        lVar1 = this.battleMapTypeData;
        if (lVar1 != null) {
          if (lVar1.attackAreaType == 2) {
            if (lVar1.targetArea != null) {
              lVar1 = AreaData.GetCenterBuilding(lVar1.targetArea,0);
              if (lVar1 != null) {
                return (float)lVar1.column;
              }
            }
          }
          else {
            if (lVar1.attackAreaType == 3) {
              return (float)lVar1.difficulty * 0.5;
            }
            if ((lVar1.targetArea != null) &&
               (lVar1 = *(int64 *)(lVar1.targetArea + 208)) != null) {
              if (lVar1.row < 4) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              return (float)*(int *)(lVar1.battleMapType + 44);
            }
          }
        }
    }

    // Token : 0x6000BFB
    // RVA   : 0x8DC070   Offset: 0x8DA870   Length: 0x399
    private void GenerateSpeGridObj(int speGridObjNum)
    {
        long lVar1;
        bool cVar2;
        int iVar3;
        int iVar4;
        int iVar5;
        int iVar6;
        uint uVar7;
        uint uVar8;
        long lVar9;
        long lVar10;
        ulong uVar11;
        long lVar12;
        lVar9 = il2cpp_internal(DAT_181d6e630);
        FUN_180f58a90(lVar9,DAT_181d63678);
        lVar1 = this.mapGrids;
        if (lVar1 != null) {
          iVar3 = Array.GetUpperBound(lVar1,0,0);
          iVar4 = Array.GetUpperBound(lVar1,1);
          for (iVar5 = Array.GetLowerBound(lVar1,0,0); iVar5 <= iVar3; iVar5 = iVar5 + 1) {
            iVar6 = Array.GetLowerBound(lVar1,1);
            if (iVar6 <= iVar4) {
              do {
                lVar10 = FUN_180127f50(lVar1,(int64)iVar5);
                if (lVar10 == null) throw; // [null/range check failed]
                cVar2 = GridUnitData.isEmpty(lVar10,1);
                if (cVar2) {
                  if (this.mustEmptyGrids == null) throw; // [null/range check failed]
                  cVar2 = FUN_1818279a0(this.mustEmptyGrids,lVar10);
                  if (((!cVar2) && (0 < *(int *)(lVar10 + 40))) &&
                     (*(int *)(lVar10 + 40) < this.mapWidth + -1)) {
                    if (lVar9 == null) throw; // [null/range check failed]
                    FUN_181827900(lVar9,lVar10);
                  }
                }
                iVar6 = iVar6 + 1;
              } while (iVar6 <= iVar4);
            }
          }
          if (0 < speGridObjNum) {
            do {
              if (lVar9 == null) throw; // [null/range check failed]
              if (*(int *)(lVar9 + 24) < 1) {
                return;
              }
              speGridObjNum = speGridObjNum + -1;
              uVar7 = FUN_180d8cf10(0,*(int *)(lVar9 + 24),0);
              if (*(uint32 *)(lVar9 + 24) <= uVar7) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar1 = lVar9[uVar7];
              FUN_181801c10(lVar9,lVar1,DAT_181d638f8);
              lVar10 = FUN_18046bb80(0);
              uVar11 = DAT_181d9cf50;
              if (lVar10 == null) throw; // [null/range check failed]
              lVar10 = *(int64 *)(lVar10 + 0x248);
              uVar11 = Type.GetTypeFromHandle(uVar11,0);
              lVar12 = Enum.GetNames(uVar11,0);
              if ((((lVar12 == null) ||
                   (uVar8 = FUN_180d8cf10(1,*(uint32 *)(lVar12 + 24)), lVar10 == null)) ||
                  (lVar10 = FUN_180002f80(lVar10,uVar8,DAT_181d7bf58)) == null) ||
                 (plVar13 = (int64 *)SpeGridObjData.Clone(lVar10,0), lVar1 == null)) throw; // [null/range check failed]
              plVar14 = (int64 *)0;
              if (plVar13 != (int64 *)0) {
              }
              *(int64 **)(lVar1 + 56) = plVar14;
            } while (0 < speGridObjNum);
          }
          return;
        }
    }

    // Token : 0x6000BFC
    // RVA   : 0x8DEBD0   Offset: 0x8DD3D0   Length: 0x165
    private void TidyGridList()
    {
        long lVar1;
        int iVar2;
        int iVar3;
        int iVar4;
        int iVar5;
        long lVar6;
        long lVar7;
        if (this.normalGrids != null) {
          FUN_180f56130(this.normalGrids,DAT_181d637f8);
          if (this.obstacleGrids != null) {
            FUN_180f56130(this.obstacleGrids,DAT_181d637f8);
            lVar1 = this.mapGrids;
            if (lVar1 != null) {
              iVar2 = Array.GetUpperBound(lVar1,0,0);
              iVar3 = Array.GetUpperBound(lVar1,1);
              iVar4 = Array.GetLowerBound(lVar1,0,0);
              do {
                if (iVar2 < iVar4) {
                  return;
                }
                iVar5 = Array.GetLowerBound(lVar1,1);
                if (iVar5 <= iVar3) {
                  do {
                    lVar6 = FUN_180127f50(lVar1,(int64)iVar4);
                    if (lVar6 == null) throw; // [null/range check failed]
                    if (*(int *)(lVar6 + 20) == 1) {
                      lVar7 = this.normalGrids;
        LAB_1808decea:
                      if (lVar7 == null) throw; // [null/range check failed]
                      FUN_181827900(lVar7,lVar6);
                    }
                    else if (*(int *)(lVar6 + 20) == 2) {
                      lVar7 = this.obstacleGrids;
                      goto LAB_1808decea;
                    }
                    iVar5 = iVar5 + 1;
                  } while (iVar5 <= iVar3);
                }
                iVar4 = iVar4 + 1;
              } while( true );
            }
          }
        }
    }

    // Token : 0x6000BFD
    // RVA   : 0x8DD940   Offset: 0x8DC140   Length: 0x3E
    public GridUnitData GetGridData(int row, int column)
    {
        ulong uVar1;
        if ((((-1 < row) && (row < this.mapHeight)) && (-1 < column)) &&
           (column < this.mapWidth)) {
          if (this.mapGrids != null) {
            uVar1 = FUN_180127f50(this.mapGrids,(int64)column,(int64)row);
            return uVar1;
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        return 0;
    }

    // Token : 0x6000BFE
    // RVA   : 0x8DD870   Offset: 0x8DC070   Length: 0xCE
    public GridUnitData GetGridDataByDir(int row, int column, int dir)
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
          if (this.mapGrids != null) {
            uVar1 = FUN_180127f50(this.mapGrids,(int64)column,(int64)row);
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
          if (this.mapGrids != null) {
            uVar1 = FUN_180127f50(this.mapGrids,(int64)column,(int64)row);
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
          if (this.mapGrids != null) {
            uVar1 = FUN_180127f50(this.mapGrids,(int64)column,(int64)row);
            return uVar1;
          }
        }
    }

    // Token : 0x6000BFF
    // RVA   : 0x8D9010   Offset: 0x8D7810   Length: 0x154
    public bool AroundGridHaveEnemy(int row, int column, int selfTeamID)
    {
        uint64 BattleMapData.AroundGridHaveEnemy
                          (uint64 this,uint32 row,uint32 column,int selfTeamID)
        {
        uint64 uVar1;
        int64 lVar2;
        uint64 uVar3;
        int iVar4;
        iVar4 = 0;
        do {
          lVar2 = BattleMapData.GetGridDataByDir(this,row,column,iVar4,0);
          uVar3 = 0;
          if (lVar2 != null) {
            lVar2 = BattleMapData.GetGridDataByDir(this,row,column,iVar4,0);
            if (lVar2 == null) {
        LAB_1808d915f:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            uVar1 = *(uint64 *)(lVar2 + 24);
            uVar3 = Object.op_Inequality(uVar1,0,0);
            if ((char)uVar3) {
              lVar2 = BattleMapData.GetGridDataByDir(this,row,column,iVar4,0);
              if ((lVar2 == null) || (*(int64 *)(lVar2 + 24) == 0)) goto LAB_1808d915f;
              uVar3 = BattleUnit.get_IsAlive(*(int64 *)(lVar2 + 24),0);
              if ((char)uVar3) {
                lVar2 = BattleMapData.GetGridDataByDir(this,row,column,iVar4,0);
                if (((lVar2 == null) || (*(int64 *)(lVar2 + 24) == 0)) ||
                   (uVar3 = *(uint64 *)(*(int64 *)(lVar2 + 24) + 88)) == null)
                goto LAB_1808d915f;
                if (*(int *)(uVar3 + 16) != selfTeamID) {
                  return CONCAT71((int7)(uVar3 >> 8),1);
                }
              }
            }
          }
          iVar4 = iVar4 + 1;
          if (3 < iVar4) {
            return uVar3 & 0xffffffffffffff00;
          }
        } while( true );
    }

    // Token : 0x6000C00
    // RVA   : 0x8D9220   Offset: 0x8D7A20   Length: 0xFE
    private void FindConnectedGrid(bool[] vis, GridUnitData targetGrid)
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        int iVar4;
        if ((targetGrid == null) || (vis == null)) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        if (**(uint32 **)(vis + 16) <= *(uint32 *)(targetGrid + 40)) {
          uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar3,0);
        }
        lVar2 = *(int64 *)(*(uint32 **)(vis + 16) + 4);
        if (*(uint32 *)(targetGrid + 36) < (uint32)lVar2) {
          iVar4 = 0;
          *(uint8 *)
           ((int64)(int)*(uint32 *)(targetGrid + 36) + 32 +
           (int)*(uint32 *)(targetGrid + 40) * lVar2 + vis) = 1;
          do {
            lVar2 = BattleMapData.GetGridDataByDir
                              (this,*(uint32 *)(targetGrid + 36),*(uint32 *)(targetGrid + 40),
                               iVar4,0);
            if ((lVar2 != null) && (*(int *)(lVar2 + 20) == 1)) {
              cVar1 = FUN_180132c20(vis,(int64)*(int *)(lVar2 + 40),
                                    (int64)*(int *)(lVar2 + 36));
              if (!cVar1) {
                BattleMapData.FindConnectedGrid(this,vis,lVar2,0);
              }
            }
            iVar4 = iVar4 + 1;
          } while (iVar4 < 4);
          return;
        }
        uVar3 = il2cpp_internal();
    }

    // Token : 0x6000C01
    // RVA   : 0x8DD6C0   Offset: 0x8DBEC0   Length: 0x1A0
    public GridUnitData GetEmptyGrid(GridUnitData from, GridUnitData to, List<GridUnitData> path, int mobility)
    {
        uint64
        BattleMapData.GetEmptyGrid
                (uint64 this,uint64 from,uint64 to,int64 path,
                uint32 mobility)
        {
        uint32 uVar1;
        int64 *plVar2;
        char cVar3;
        int64 lVar4;
        if (path == null) {
          path = il2cpp_internal(DAT_181d6e630);
          FUN_180f58a90(path,DAT_181d63678);
          if (path == null) throw; // [null/range check failed]
        }
        FUN_180f56130(path);
        lVar4 = MapNavigator.get_Instance(0);
        if (lVar4 != null) {
          cVar3 = MapNavigator.Navigate(lVar4,this,from,to,path,0,mobility,0xffffffff,0);
          if (cVar3) {
            uVar1 = *(uint32 *)(path + 24);
            if (1 < (int)uVar1) {
              if (uVar1 <= uVar1 - 1) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              plVar2 = *(int64 **)(*(int64 *)(path + 16) + 24 + (int64)(int)uVar1 * 8);
              if (plVar2 != (int64 *)0) {
                cVar3 = (**(code **)(*plVar2 + 0x138))(plVar2,to,*(uint64 *)(*plVar2 + 0x140));
                if (cVar3) {
                  FUN_18182b220(path,*(int *)(path + 24) + -1,DAT_181d63978);
                }
                uVar1 = *(uint32 *)(path + 24);
                if (uVar1 <= uVar1 - 1) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                return *(uint64 *)(*(int64 *)(path + 16) + 24 + (int64)(int)uVar1 * 8);
              }
              throw; // [null/range check failed]
            }
            if (0 < (int)uVar1) {
              FUN_180f56130(path,DAT_181d637f8);
              return from;
            }
          }
          return 0;
        }
    }

    // Token : 0x6000C02
    // RVA   : 0x8DD980   Offset: 0x8DC180   Length: 0x639
    public void GetMoveRangeGrids(int row, int column, int minRange, int maxRange, List<GridUnitData> grids, int selfTeamID)
    {
        void BattleMapData.GetMoveRangeGrids
                     (int64 this,int row,int column,int minRange,int maxRange,int64 grids,
                     uint32 selfTeamID)
        {
        char cVar1;
        int iVar2;
        int iVar3;
        int64 lVar4;
        int64 lVar5;
        uint64 uVar6;
        uint64 uVar7;
        int iVar8;
        int64 lVar9;
        int64 lVar10;
        int local_48;
        lVar9 = (int64)row;
        if (grids != null) {
          FUN_180f56130(grids,DAT_181d637f8);
          lVar4 = il2cpp_internal(DAT_181d6e630);
          FUN_180f58a90(lVar4,DAT_181d63678);
          local_48 = 0;
          if (-1 < maxRange) {
            do {
              iVar2 = Mathf.Max(0,(local_48 - maxRange) + column,0);
              iVar3 = Mathf.Min(this.mapWidth + -1,(column - local_48) + maxRange);
              for (; iVar2 <= iVar3; iVar2 = iVar2 + 1) {
                if (local_48 == 0) {
                  if ((iVar2 == column) && (minRange < 1)) {
                    if (this.mapGrids == null) goto LAB_1808ddfb4;
                    uVar6 = FUN_180127f50(this.mapGrids,(int64)iVar2,lVar9);
                    FUN_181827900(grids,uVar6);
                  }
                  else {
                    if (this.mapGrids == null) goto LAB_1808ddfb4;
                    lVar10 = (int64)iVar2;
                    lVar5 = FUN_180127f50(this.mapGrids,lVar10);
                    if (lVar5 == null) goto LAB_1808ddfb4;
                    if (*(int *)(lVar5 + 20) != 2) {
                      if ((this.mapGrids == null) ||
                         (lVar5 = FUN_180127f50(this.mapGrids,lVar10)) == null)
                      goto LAB_1808ddfb4;
                      uVar6 = *(uint64 *)(lVar5 + 24);
                      cVar1 = Object.op_Equality(uVar6,0);
                      if (cVar1) {
                        lVar5 = MapNavigator.get_Instance(0);
                        if (this.mapGrids == null) goto LAB_1808ddfb4;
                        uVar6 = FUN_180127f50(this.mapGrids,(int64)column,lVar9);
                        if ((this.mapGrids == null) ||
                           (uVar7 = FUN_180127f50(this.mapGrids,lVar10,lVar9), lVar5 == null)
                           ) goto LAB_1808ddfb4;
                        cVar1 = MapNavigator.Navigate(lVar5,this,uVar6,uVar7,lVar4,0,999999,selfTeamID,0)
                        ;
                        if (cVar1) {
                          if (lVar4 == null) goto LAB_1808ddfb4;
                          if ((*(int *)(lVar4 + 24) <= maxRange) && (minRange <= *(int *)(lVar4 + 24)))
                          {
                            if (this.mapGrids == null) goto LAB_1808ddfb4;
                            uVar6 = FUN_180127f50(this.mapGrids,lVar10,lVar9);
                            FUN_181827900(grids,uVar6);
                          }
                        }
                      }
                    }
                  }
                }
                else {
                  iVar8 = row - local_48;
                  if (-1 < iVar8) {
                    if (this.mapGrids == null) goto LAB_1808ddfb4;
                    lVar10 = (int64)iVar2;
                    lVar5 = FUN_180127f50(this.mapGrids,lVar10);
                    if (lVar5 == null) goto LAB_1808ddfb4;
                    if (*(int *)(lVar5 + 20) != 2) {
                      if ((this.mapGrids == null) ||
                         (lVar5 = FUN_180127f50(this.mapGrids,lVar10)) == null)
                      goto LAB_1808ddfb4;
                      uVar6 = *(uint64 *)(lVar5 + 24);
                      cVar1 = Object.op_Equality(uVar6,0);
                      if (cVar1) {
                        lVar5 = MapNavigator.get_Instance(0);
                        if (this.mapGrids == null) goto LAB_1808ddfb4;
                        uVar6 = FUN_180127f50(this.mapGrids,(int64)column,lVar9);
                        if ((this.mapGrids == null) ||
                           (uVar7 = FUN_180127f50(this.mapGrids,lVar10,(int64)iVar8),
                           lVar5 == null)) goto LAB_1808ddfb4;
                        cVar1 = MapNavigator.Navigate(lVar5,this,uVar6,uVar7,lVar4,0,999999,selfTeamID,0)
                        ;
                        if (cVar1) {
                          if (lVar4 == null) goto LAB_1808ddfb4;
                          if ((*(int *)(lVar4 + 24) <= maxRange) && (minRange <= *(int *)(lVar4 + 24)))
                          {
                            if (this.mapGrids == null) goto LAB_1808ddfb4;
                            uVar6 = FUN_180127f50(this.mapGrids,lVar10,(int64)iVar8);
                            FUN_181827900(grids,uVar6);
                          }
                        }
                      }
                    }
                  }
                  iVar8 = local_48 + row;
                  if (iVar8 < this.mapHeight) {
                    if (this.mapGrids == null) {
        LAB_1808ddfb4:
                          // WARNING: Subroutine does not return
                      FUN_1800d6620();
                    }
                    lVar10 = (int64)iVar2;
                    lVar5 = FUN_180127f50(this.mapGrids,lVar10);
                    if (lVar5 == null) goto LAB_1808ddfb4;
                    if (*(int *)(lVar5 + 20) != 2) {
                      if ((this.mapGrids == null) ||
                         (lVar5 = FUN_180127f50(this.mapGrids,lVar10)) == null)
                      goto LAB_1808ddfb4;
                      uVar6 = *(uint64 *)(lVar5 + 24);
                      cVar1 = Object.op_Equality(uVar6,0);
                      if (cVar1) {
                        lVar5 = MapNavigator.get_Instance(0);
                        if (this.mapGrids == null) goto LAB_1808ddfb4;
                        uVar6 = FUN_180127f50(this.mapGrids,(int64)column,lVar9);
                        if ((this.mapGrids == null) ||
                           (uVar7 = FUN_180127f50(this.mapGrids,lVar10,(int64)iVar8),
                           lVar5 == null)) goto LAB_1808ddfb4;
                        cVar1 = MapNavigator.Navigate(lVar5,this,uVar6,uVar7,lVar4,0,999999,selfTeamID,0)
                        ;
                        if (cVar1) {
                          if (lVar4 == null) goto LAB_1808ddfb4;
                          if ((*(int *)(lVar4 + 24) <= maxRange) && (minRange <= *(int *)(lVar4 + 24)))
                          {
                            if (this.mapGrids == null) goto LAB_1808ddfb4;
                            uVar6 = FUN_180127f50(this.mapGrids,lVar10,(int64)iVar8);
                            FUN_181827900(grids,uVar6);
                          }
                        }
                      }
                    }
                  }
                }
              }
              local_48 = local_48 + 1;
            } while (local_48 <= maxRange);
          }
        }
    }

    // Token : 0x6000C03
    // RVA   : 0x8DCFE0   Offset: 0x8DB7E0   Length: 0x226
    public void GetDirectionObliqueGrids(int direction, int centerRow, int centerColumn, int innerRange, int outerRange, List<GridUnitData> grids)
    {
        void BattleMapData.GetDirectionObliqueGrids
                     (int64 this,int direction,int centerRow,int centerColumn,int innerRange,int outerRange,
                     int64 grids)
        {
        int iVar1;
        int iVar2;
        uint64 uVar3;
        if ((grids != null) && (-1 < outerRange)) {
          FUN_180f56130(grids,DAT_181d637f8);
          if (direction == null) {
            if (innerRange <= outerRange) {
              iVar2 = centerColumn - innerRange;
              do {
                if ((((-1 < iVar2) && (iVar2 < this.mapWidth)) &&
                    (iVar1 = iVar2 + (centerRow - centerColumn), -1 < iVar1)) &&
                   (iVar1 < this.mapHeight)) {
                  if (this.mapGrids == null) goto LAB_1808dd201;
                  uVar3 = FUN_180127f50(this.mapGrids,(int64)iVar2,(int64)iVar1);
                  FUN_181827900(grids,uVar3,DAT_181d63778);
                }
                innerRange = innerRange + 1;
                iVar2 = iVar2 + -1;
              } while (innerRange <= outerRange);
            }
          }
          else if (direction == 1) {
            if (innerRange <= outerRange) {
              iVar2 = centerRow + innerRange;
              centerColumn = centerColumn - innerRange;
              do {
                if (((-1 < centerColumn) && (centerColumn < this.mapWidth)) &&
                   ((-1 < iVar2 && (iVar2 < this.mapHeight)))) {
                  if (this.mapGrids == null) goto LAB_1808dd201;
                  uVar3 = FUN_180127f50(this.mapGrids,(int64)centerColumn,(int64)iVar2);
                  FUN_181827900(grids,uVar3,DAT_181d63778);
                }
                iVar2 = iVar2 + 1;
                centerColumn = centerColumn + -1;
              } while (iVar2 - centerRow <= outerRange);
            }
          }
          else if (direction == 2) {
            if (innerRange <= outerRange) {
              iVar2 = centerColumn + innerRange;
              centerRow = centerRow - innerRange;
              do {
                if (((-1 < iVar2) && (iVar2 < this.mapWidth)) &&
                   ((-1 < centerRow && (centerRow < this.mapHeight)))) {
                  if (this.mapGrids == null) goto LAB_1808dd201;
                  uVar3 = FUN_180127f50(this.mapGrids,(int64)iVar2,(int64)centerRow);
                  FUN_181827900(grids,uVar3,DAT_181d63778);
                }
                iVar2 = iVar2 + 1;
                centerRow = centerRow + -1;
              } while (iVar2 - centerColumn <= outerRange);
            }
          }
          else if ((direction == 3) && (innerRange <= outerRange)) {
            innerRange = centerColumn + innerRange;
            do {
              if ((((-1 < innerRange) && (innerRange < this.mapWidth)) &&
                  (iVar2 = (centerRow - centerColumn) + innerRange, -1 < iVar2)) &&
                 (iVar2 < this.mapHeight)) {
                if (this.mapGrids == null) {
        LAB_1808dd201:
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                uVar3 = FUN_180127f50(this.mapGrids,(int64)innerRange,(int64)iVar2);
                FUN_181827900(grids,uVar3,DAT_181d63778);
              }
              innerRange = innerRange + 1;
            } while (innerRange - centerColumn <= outerRange);
          }
        }
    }

    // Token : 0x6000C04
    // RVA   : 0x8DC810   Offset: 0x8DB010   Length: 0x4E8
    public void GetDirectionCrossGrids(int direction, int centerRow, int centerColumn, int innerRange, int outerRange, List<GridUnitData> grids)
    {
        void BattleMapData.GetDirectionCrossGrids
                     (int64 this,int direction,int centerRow,int centerColumn,int innerRange,int outerRange,
                     int64 grids)
        {
        int iVar1;
        int iVar2;
        int iVar3;
        int iVar4;
        int iVar5;
        int iVar6;
        uint64 uVar7;
        if ((grids != null) && (-1 < outerRange)) {
          FUN_180f56130(grids,DAT_181d637f8);
          iVar1 = Mathf.Clamp(centerColumn - outerRange,0,this.mapWidth + -1,0);
          iVar2 = Mathf.Clamp(centerColumn + outerRange,0,this.mapWidth + -1,0);
          iVar3 = Mathf.Clamp(centerRow - outerRange,0,this.mapHeight + -1,0);
          iVar4 = Mathf.Clamp(outerRange + centerRow,0,this.mapHeight + -1,0);
          if (direction == null) {
            for (; iVar1 <= centerColumn + -1; iVar1 = iVar1 + 1) {
              if ((-1 < centerRow) && (centerRow < this.mapHeight)) {
                iVar3 = Mathf.Abs(iVar1 - centerColumn,0);
                if ((innerRange <= iVar3) && (iVar3 = Mathf.Abs(iVar1 - centerColumn,0), iVar3 <= outerRange)) {
                  if ((iVar1 == centerColumn - outerRange) || (iVar1 == centerColumn + -1)) {
                    iVar3 = 0;
                  }
                  else {
                    iVar3 = 1;
                  }
                  iVar2 = Mathf.Clamp(centerRow - iVar3,0,this.mapHeight + -1,0);
                  iVar3 = Mathf.Clamp(iVar3 + centerRow,0,this.mapHeight + -1);
                  for (; iVar2 <= iVar3; iVar2 = iVar2 + 1) {
                    if (this.mapGrids == null) goto LAB_1808dccf3;
                    uVar7 = FUN_180127f50(this.mapGrids,(int64)iVar1,(int64)iVar2);
                    FUN_181827900(grids,uVar7,DAT_181d63778);
                  }
                }
              }
            }
          }
          else if (direction == 1) {
            iVar1 = centerColumn + 1;
            if (iVar1 <= iVar2) {
              iVar4 = 1;
              iVar3 = iVar1;
              do {
                if ((((-1 < centerRow) && (centerRow < this.mapHeight)) &&
                    (iVar5 = Mathf.Abs(iVar4,0), innerRange <= iVar5)) &&
                   (iVar5 = Mathf.Abs(iVar4,0), iVar5 <= outerRange)) {
                  if ((iVar3 == iVar1) || (iVar3 == centerColumn + outerRange)) {
                    iVar5 = 0;
                  }
                  else {
                    iVar5 = 1;
                  }
                  iVar6 = Mathf.Clamp(centerRow - iVar5,0,this.mapHeight + -1,0);
                  iVar5 = Mathf.Clamp(iVar5 + centerRow,0,this.mapHeight + -1);
                  for (; iVar6 <= iVar5; iVar6 = iVar6 + 1) {
                    if (this.mapGrids == null) goto LAB_1808dccf3;
                    uVar7 = FUN_180127f50(this.mapGrids,(int64)iVar3,(int64)iVar6);
                    FUN_181827900(grids,uVar7,DAT_181d63778);
                  }
                }
                iVar3 = iVar3 + 1;
                iVar4 = iVar4 + 1;
              } while (iVar3 <= iVar2);
            }
          }
          else if (direction == 2) {
            for (; iVar3 <= centerRow + -1; iVar3 = iVar3 + 1) {
              if ((-1 < centerColumn) && (centerColumn < this.mapWidth)) {
                iVar1 = Mathf.Abs(iVar3 - centerRow,0);
                if ((innerRange <= iVar1) && (iVar1 = Mathf.Abs(iVar3 - centerRow,0), iVar1 <= outerRange)) {
                  if ((iVar3 == centerRow - outerRange) || (iVar3 == centerRow + -1)) {
                    iVar1 = 0;
                  }
                  else {
                    iVar1 = 1;
                  }
                  iVar2 = Mathf.Clamp(centerColumn - iVar1,0,this.mapWidth + -1,0);
                  iVar1 = Mathf.Clamp(centerColumn + iVar1,0,this.mapWidth + -1);
                  for (; iVar2 <= iVar1; iVar2 = iVar2 + 1) {
                    if (this.mapGrids == null) goto LAB_1808dccf3;
                    uVar7 = FUN_180127f50(this.mapGrids,(int64)iVar2,(int64)iVar3);
                    FUN_181827900(grids,uVar7,DAT_181d63778);
                  }
                }
              }
            }
          }
          else if ((direction == 3) && (iVar1 = centerRow + 1, iVar1 <= iVar4)) {
            iVar2 = 1;
            iVar3 = iVar1;
            do {
              if ((((-1 < centerColumn) && (centerColumn < this.mapWidth)) &&
                  (iVar5 = Mathf.Abs(iVar2,0), innerRange <= iVar5)) &&
                 (iVar5 = Mathf.Abs(iVar2,0), iVar5 <= outerRange)) {
                if ((iVar3 == iVar1) || (iVar3 == outerRange + centerRow)) {
                  iVar5 = 0;
                }
                else {
                  iVar5 = 1;
                }
                iVar6 = Mathf.Clamp(centerColumn - iVar5,0,this.mapWidth + -1,0);
                iVar5 = Mathf.Clamp(iVar5 + centerColumn,0,this.mapWidth + -1);
                for (; iVar6 <= iVar5; iVar6 = iVar6 + 1) {
                  if (this.mapGrids == null) {
        LAB_1808dccf3:
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  uVar7 = FUN_180127f50(this.mapGrids,(int64)iVar6,(int64)iVar3);
                  FUN_181827900(grids,uVar7,DAT_181d63778);
                }
              }
              iVar3 = iVar3 + 1;
              iVar2 = iVar2 + 1;
            } while (iVar3 <= iVar4);
          }
        }
    }

    // Token : 0x6000C05
    // RVA   : 0x8DD210   Offset: 0x8DBA10   Length: 0x4AC
    public void GetDirectionSectorGrids(int direction, int centerRow, int centerColumn, int innerRange, int outerRange, List<GridUnitData> grids)
    {
        void BattleMapData.GetDirectionSectorGrids
                     (int64 this,int direction,int centerRow,int centerColumn,int innerRange,int outerRange,
                     int64 grids)
        {
        uint64 uVar1;
        int iVar2;
        int iVar3;
        int iVar4;
        int iVar5;
        if ((grids != null) && (-1 < outerRange)) {
          FUN_180f56130(grids,DAT_181d637f8);
          iVar2 = Mathf.Clamp(centerColumn - outerRange,0,this.mapWidth + -1,0);
          iVar3 = Mathf.Clamp(centerColumn + outerRange,0,this.mapWidth + -1,0);
          iVar4 = Mathf.Clamp(centerRow - outerRange,0,this.mapHeight + -1,0);
          iVar5 = Mathf.Clamp(outerRange + centerRow,0,this.mapHeight + -1,0);
          if (direction == null) {
            if (iVar2 <= centerColumn + -1) {
              iVar3 = iVar2 - centerColumn;
              do {
                if ((((-1 < centerRow) && (centerRow < this.mapHeight)) &&
                    (iVar4 = Mathf.Abs(iVar3,0), innerRange <= iVar4)) &&
                   (iVar4 = Mathf.Abs(iVar3,0), iVar4 <= outerRange)) {
                  iVar5 = Mathf.Abs(iVar3,0);
                  iVar4 = Mathf.Clamp(centerRow - (iVar5 + -1),0,this.mapHeight + -1,0);
                  iVar5 = Mathf.Clamp(iVar5 + -1 + centerRow,0,this.mapHeight + -1);
                  for (; iVar4 <= iVar5; iVar4 = iVar4 + 1) {
                    if (this.mapGrids == null) goto LAB_1808dd6b7;
                    uVar1 = FUN_180127f50(this.mapGrids,(int64)iVar2,(int64)iVar4);
                    FUN_181827900(grids,uVar1,DAT_181d63778);
                  }
                }
                iVar2 = iVar2 + 1;
                iVar3 = iVar3 + 1;
              } while (iVar2 <= centerColumn + -1);
            }
          }
          else if (direction == 1) {
            centerColumn = centerColumn + 1;
            if (centerColumn <= iVar3) {
              iVar2 = 1;
              do {
                if (((-1 < centerRow) && (centerRow < this.mapHeight)) &&
                   ((iVar4 = Mathf.Abs(iVar2,0), innerRange <= iVar4 &&
                    (iVar4 = Mathf.Abs(iVar2,0), iVar4 <= outerRange)))) {
                  iVar5 = Mathf.Abs(iVar2,0);
                  iVar4 = Mathf.Clamp(centerRow - (iVar5 + -1),0,this.mapHeight + -1,0);
                  iVar5 = Mathf.Clamp(iVar5 + -1 + centerRow,0,this.mapHeight + -1);
                  for (; iVar4 <= iVar5; iVar4 = iVar4 + 1) {
                    if (this.mapGrids == null) goto LAB_1808dd6b7;
                    uVar1 = FUN_180127f50(this.mapGrids,(int64)centerColumn,(int64)iVar4)
                    ;
                    FUN_181827900(grids,uVar1,DAT_181d63778);
                  }
                }
                centerColumn = centerColumn + 1;
                iVar2 = iVar2 + 1;
              } while (centerColumn <= iVar3);
            }
          }
          else if (direction == 2) {
            if (iVar4 <= centerRow + -1) {
              iVar2 = iVar4 - centerRow;
              do {
                if (((-1 < centerColumn) && (centerColumn < this.mapWidth)) &&
                   ((iVar3 = Mathf.Abs(iVar2,0), innerRange <= iVar3 &&
                    (iVar3 = Mathf.Abs(iVar2,0), iVar3 <= outerRange)))) {
                  iVar5 = Mathf.Abs(iVar2,0);
                  iVar3 = Mathf.Clamp(centerColumn - (iVar5 + -1),0,this.mapWidth + -1,0);
                  iVar5 = Mathf.Clamp(iVar5 + -1 + centerColumn,0,this.mapWidth + -1);
                  for (; iVar3 <= iVar5; iVar3 = iVar3 + 1) {
                    if (this.mapGrids == null) goto LAB_1808dd6b7;
                    uVar1 = FUN_180127f50(this.mapGrids,(int64)iVar3,(int64)iVar4);
                    FUN_181827900(grids,uVar1,DAT_181d63778);
                  }
                }
                iVar4 = iVar4 + 1;
                iVar2 = iVar2 + 1;
              } while (iVar4 <= centerRow + -1);
            }
          }
          else if ((direction == 3) && (centerRow = centerRow + 1, centerRow <= iVar5)) {
            iVar2 = 1;
            do {
              if ((((-1 < centerColumn) && (centerColumn < this.mapWidth)) &&
                  (iVar3 = Mathf.Abs(iVar2,0), innerRange <= iVar3)) &&
                 (iVar3 = Mathf.Abs(iVar2,0), iVar3 <= outerRange)) {
                iVar4 = Mathf.Abs(iVar2,0);
                iVar3 = Mathf.Clamp(centerColumn - (iVar4 + -1),0,this.mapWidth + -1,0);
                iVar4 = Mathf.Clamp(iVar4 + -1 + centerColumn,0,this.mapWidth + -1);
                for (; iVar3 <= iVar4; iVar3 = iVar3 + 1) {
                  if (this.mapGrids == null) {
        LAB_1808dd6b7:
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  uVar1 = FUN_180127f50(this.mapGrids,(int64)iVar3,(int64)centerRow);
                  FUN_181827900(grids,uVar1,DAT_181d63778);
                }
              }
              centerRow = centerRow + 1;
              iVar2 = iVar2 + 1;
            } while (centerRow <= iVar5);
          }
        }
    }

    // Token : 0x6000C06
    // RVA   : 0x8DCD00   Offset: 0x8DB500   Length: 0x2DF
    public void GetDirectionLineGrids(int direction, int centerRow, int centerColumn, int innerRange, int outerRange, List<GridUnitData> grids)
    {
        void BattleMapData.GetDirectionLineGrids
                     (int64 this,int direction,int centerRow,int centerColumn,int innerRange,int outerRange,
                     int64 grids)
        {
        uint64 uVar1;
        int iVar2;
        int iVar3;
        int iVar4;
        if ((grids != null) && (-1 < outerRange)) {
          FUN_180f56130(grids,DAT_181d637f8);
          if (direction == null) {
            iVar2 = Mathf.Clamp(centerColumn - outerRange,0,this.mapWidth + -1,0);
            for (; iVar2 <= centerColumn + -1; iVar2 = iVar2 + 1) {
              if ((-1 < centerRow) && (centerRow < this.mapHeight)) {
                iVar4 = Mathf.Abs(iVar2 - centerColumn,0);
                if ((innerRange <= iVar4) && (iVar4 = Mathf.Abs(iVar2 - centerColumn,0), iVar4 <= outerRange)) {
                  if (this.mapGrids == null) goto LAB_1808dcfda;
                  uVar1 = FUN_180127f50(this.mapGrids,(int64)iVar2,(int64)centerRow);
                  FUN_181827900(grids,uVar1,DAT_181d63778);
                }
              }
            }
          }
          else if (direction == 1) {
            iVar2 = Mathf.Clamp(centerColumn + outerRange,0,this.mapWidth + -1,0);
            centerColumn = centerColumn + 1;
            if (centerColumn <= iVar2) {
              iVar4 = 1;
              do {
                if ((((-1 < centerRow) && (centerRow < this.mapHeight)) &&
                    (iVar3 = Mathf.Abs(iVar4,0), innerRange <= iVar3)) &&
                   (iVar3 = Mathf.Abs(iVar4,0), iVar3 <= outerRange)) {
                  if (this.mapGrids == null) goto LAB_1808dcfda;
                  uVar1 = FUN_180127f50(this.mapGrids,(int64)centerColumn,(int64)centerRow)
                  ;
                  FUN_181827900(grids,uVar1,DAT_181d63778);
                }
                centerColumn = centerColumn + 1;
                iVar4 = iVar4 + 1;
              } while (centerColumn <= iVar2);
            }
          }
          else if (direction == 2) {
            iVar2 = Mathf.Clamp(centerRow - outerRange,0,this.mapHeight + -1,0);
            for (; iVar2 <= centerRow + -1; iVar2 = iVar2 + 1) {
              if ((-1 < centerColumn) && (centerColumn < this.mapWidth)) {
                iVar4 = Mathf.Abs(iVar2 - centerRow,0);
                if ((innerRange <= iVar4) && (iVar4 = Mathf.Abs(iVar2 - centerRow,0), iVar4 <= outerRange)) {
                  if (this.mapGrids == null) goto LAB_1808dcfda;
                  uVar1 = FUN_180127f50(this.mapGrids,(int64)centerColumn,(int64)iVar2);
                  FUN_181827900(grids,uVar1,DAT_181d63778);
                }
              }
            }
          }
          else if (direction == 3) {
            iVar2 = Mathf.Clamp(centerRow + outerRange,0,this.mapHeight + -1,0);
            centerRow = centerRow + 1;
            if (centerRow <= iVar2) {
              iVar4 = 1;
              do {
                if (((-1 < centerColumn) && (centerColumn < this.mapWidth)) &&
                   ((iVar3 = Mathf.Abs(iVar4,0), innerRange <= iVar3 &&
                    (iVar3 = Mathf.Abs(iVar4,0), iVar3 <= outerRange)))) {
                  if (this.mapGrids == null) {
        LAB_1808dcfda:
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  uVar1 = FUN_180127f50(this.mapGrids,(int64)centerColumn,(int64)centerRow)
                  ;
                  FUN_181827900(grids,uVar1,DAT_181d63778);
                }
                centerRow = centerRow + 1;
                iVar4 = iVar4 + 1;
              } while (centerRow <= iVar2);
            }
          }
        }
    }

    // Token : 0x6000C07
    // RVA   : 0x8DDFC0   Offset: 0x8DC7C0   Length: 0x1FA
    public void GetObliqueLineGrids(int centerRow, int centerColumn, int innerRange, int outerRange, bool containCenter, List<GridUnitData> grids)
    {
        void BattleMapData.GetObliqueLineGrids
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
        if ((grids != null) && (-1 < outerRange)) {
          FUN_180f56130(grids,DAT_181d637f8);
          iVar2 = Mathf.Clamp(centerColumn - outerRange,0,this.mapWidth + -1,0);
          iVar3 = Mathf.Clamp(centerColumn + outerRange,0,this.mapWidth + -1,0);
          if (iVar2 <= iVar3) {
            iVar7 = centerColumn - iVar2;
            do {
              iVar4 = Mathf.Abs(iVar7,0);
              iVar4 = centerRow - iVar4;
              if ((-1 < iVar4) && (iVar4 < this.mapHeight)) {
                cVar1 = containCenter;
                if (iVar2 != centerColumn) {
                  cVar1 = true;
                }
                if (cVar1) {
                  iVar8 = iVar2 + -centerColumn;
                  iVar5 = Mathf.Abs(iVar8,0);
                  if ((innerRange <= iVar5) && (iVar5 = Mathf.Abs(iVar8,0), iVar5 <= outerRange)) {
                    if (this.mapGrids == null) goto LAB_1808de1b5;
                    uVar6 = FUN_180127f50(this.mapGrids,(int64)iVar2,(int64)iVar4);
                    FUN_181827900(grids,uVar6,DAT_181d63778);
                  }
                }
              }
              iVar4 = Mathf.Abs(iVar7,0);
              iVar4 = iVar4 + centerRow;
              if (((-1 < iVar4) && (iVar4 <= this.mapHeight + -1)) && (iVar2 != centerColumn)) {
                iVar8 = iVar2 + -centerColumn;
                iVar5 = Mathf.Abs(iVar8,0);
                if ((innerRange <= iVar5) && (iVar5 = Mathf.Abs(iVar8,0), iVar5 <= outerRange)) {
                  if (this.mapGrids == null) {
        LAB_1808de1b5:
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  uVar6 = FUN_180127f50(this.mapGrids,(int64)iVar2,(int64)iVar4);
                  FUN_181827900(grids,uVar6,DAT_181d63778);
                }
              }
              iVar2 = iVar2 + 1;
              iVar7 = iVar7 + -1;
            } while (iVar2 <= iVar3);
          }
        }
    }

    // Token : 0x6000C08
    // RVA   : 0x8DE920   Offset: 0x8DD120   Length: 0x1F9
    public void GetStraightLineGrids(int centerRow, int centerColumn, int innerRange, int outerRange, bool containCenter, List<GridUnitData> grids)
    {
        void BattleMapData.GetStraightLineGrids
                     (int64 this,int centerRow,int centerColumn,int innerRange,int outerRange,char containCenter,
                     int64 grids)
        {
        int iVar1;
        int iVar2;
        int iVar3;
        uint64 uVar4;
        char cVar5;
        if ((grids != null) && (-1 < outerRange)) {
          FUN_180f56130(grids,DAT_181d637f8);
          iVar1 = Mathf.Clamp(centerColumn - outerRange,0,this.mapWidth + -1,0);
          iVar2 = Mathf.Clamp(centerColumn + outerRange,0,this.mapWidth + -1,0);
          for (; iVar1 <= iVar2; iVar1 = iVar1 + 1) {
            cVar5 = containCenter;
            if (iVar1 != centerColumn) {
              cVar5 = true;
            }
            if (((cVar5) && (-1 < centerRow)) && (centerRow < this.mapHeight)) {
              iVar3 = Mathf.Abs(iVar1 - centerColumn,0);
              if ((innerRange <= iVar3) && (iVar3 = Mathf.Abs(iVar1 - centerColumn,0), iVar3 <= outerRange)) {
                if (this.mapGrids == null) goto LAB_1808deb14;
                uVar4 = FUN_180127f50(this.mapGrids,(int64)iVar1,(int64)centerRow);
                FUN_181827900(grids,uVar4,DAT_181d63778);
              }
            }
          }
          iVar1 = Mathf.Clamp(centerRow - outerRange,0,this.mapHeight + -1,0);
          iVar2 = Mathf.Clamp(centerRow + outerRange,0,this.mapHeight + -1,0);
          for (; iVar1 <= iVar2; iVar1 = iVar1 + 1) {
            if (((iVar1 != centerRow) && (-1 < centerColumn)) && (centerColumn < this.mapWidth)) {
              iVar3 = Mathf.Abs(iVar1 - centerRow,0);
              if ((innerRange <= iVar3) && (iVar3 = Mathf.Abs(iVar1 - centerRow,0), iVar3 <= outerRange)) {
                if (this.mapGrids == null) {
        LAB_1808deb14:
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                uVar4 = FUN_180127f50(this.mapGrids,(int64)centerColumn,(int64)iVar1);
                FUN_181827900(grids,uVar4,DAT_181d63778);
              }
            }
          }
        }
    }

    // Token : 0x6000C09
    // RVA   : 0x8DE680   Offset: 0x8DCE80   Length: 0x294
    public void GetSquareGrids(int centerRow, int centerColumn, int innerRange, int outerRange, bool containCenter, List<GridUnitData> grids)
    {
        void BattleMapData.GetSquareGrids
                     (int64 this,int centerRow,int centerColumn,int innerRange,int outerRange,char containCenter,
                     int64 grids)
        {
        int64 lVar1;
        char cVar2;
        int iVar3;
        int iVar4;
        int iVar5;
        uint64 uVar6;
        int iVar7;
        int iVar8;
        int iVar9;
        if ((grids != null) && (-1 < outerRange)) {
          FUN_180f56130(grids,DAT_181d637f8);
          iVar9 = 0;
          do {
            iVar3 = Mathf.Clamp(centerColumn - outerRange,0,this.mapWidth + -1,0);
            iVar4 = Mathf.Clamp(centerColumn + outerRange,0,this.mapWidth + -1);
            if (iVar3 <= iVar4) {
              iVar3 = iVar3 - centerColumn;
              do {
                if (iVar9 == 0) {
                  cVar2 = containCenter;
                  if (iVar3 + centerColumn != centerColumn) {
                    cVar2 = true;
                  }
                  if ((((cVar2) && (-1 < centerRow)) && (centerRow < this.mapHeight)) &&
                     ((iVar7 = Mathf.Abs(iVar3,0), innerRange <= iVar7 &&
                      (iVar7 = Mathf.Abs(iVar3,0), iVar7 <= outerRange)))) {
                    lVar1 = this.mapGrids;
                    iVar7 = centerRow;
                    goto joined_r0x0001808de8e7;
                  }
                }
                else {
                  iVar8 = -iVar9;
                  iVar7 = iVar8 + centerRow;
                  if ((((-1 < iVar7) && (iVar7 < this.mapHeight)) &&
                      ((iVar5 = Mathf.Abs(iVar3,0), innerRange <= iVar5 ||
                       (iVar5 = Mathf.Abs(iVar8,0), innerRange <= iVar5)))) &&
                     ((iVar5 = Mathf.Abs(iVar3,0), iVar5 <= outerRange &&
                      (iVar8 = Mathf.Abs(iVar8,0), iVar8 <= outerRange)))) {
                    if (this.mapGrids == null) goto LAB_1808de90f;
                    uVar6 = FUN_180127f50(this.mapGrids,(int64)(centerColumn + iVar3),
                                          (int64)iVar7);
                    FUN_181827900(grids,uVar6,DAT_181d63778);
                  }
                  iVar7 = iVar9 + centerRow;
                  if ((((-1 < iVar7) && (iVar7 < this.mapHeight)) &&
                      ((iVar8 = Mathf.Abs(iVar3,0), innerRange <= iVar8 ||
                       (iVar8 = Mathf.Abs(iVar9,0), innerRange <= iVar8)))) &&
                     ((iVar8 = Mathf.Abs(iVar3,0), iVar8 <= outerRange &&
                      (iVar8 = Mathf.Abs(iVar9,0), iVar8 <= outerRange)))) {
                    lVar1 = this.mapGrids;
        joined_r0x0001808de8e7:
                    if (lVar1 == null) {
        LAB_1808de90f:
                          // WARNING: Subroutine does not return
                      FUN_1800d6620();
                    }
                    uVar6 = FUN_180127f50(lVar1,(int64)(centerColumn + iVar3),(int64)iVar7);
                    FUN_181827900(grids,uVar6,DAT_181d63778);
                  }
                }
                iVar3 = iVar3 + 1;
              } while (iVar3 + centerColumn <= iVar4);
            }
            iVar9 = iVar9 + 1;
          } while (iVar9 <= outerRange);
        }
    }

    // Token : 0x6000C0A
    // RVA   : 0x8DE3E0   Offset: 0x8DCBE0   Length: 0x29C
    public void GetRangeGrids(int centerRow, int centerColumn, int innerRange, int outerRange, bool containCenter, List<GridUnitData> grids)
    {
        void BattleMapData.GetRangeGrids
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
          FUN_180f56130(grids,DAT_181d637f8);
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
                    if (this.mapGrids == null) {
        LAB_1808de677:
                          // WARNING: Subroutine does not return
                      FUN_1800d6620();
                    }
                    uVar6 = FUN_180127f50(this.mapGrids,(int64)(iVar2 + centerColumn),
                                          (int64)centerRow);
                    FUN_181827900(grids,uVar6,DAT_181d63778);
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
                        if (this.mapGrids == null) goto LAB_1808de677;
                        uVar6 = FUN_180127f50(this.mapGrids,(int64)(iVar2 + centerColumn),
                                              (int64)iVar7);
                        FUN_181827900(grids,uVar6,DAT_181d63778);
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
                        if (this.mapGrids == null) goto LAB_1808de677;
                        uVar6 = FUN_180127f50(this.mapGrids,(int64)(iVar2 + centerColumn),
                                              (int64)iVar7);
                        FUN_181827900(grids,uVar6,DAT_181d63778);
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

    // Token : 0x6000C0B
    // RVA   : 0x8DE1C0   Offset: 0x8DC9C0   Length: 0x21C
    public GridUnitData GetRandomBornGrid(int teamID)
    {
        long lVar1;
        bool cVar2;
        long lVar3;
        long lVar4;
        ulong uVar5;
        uint uVar6;
        uint uVar7;
        lVar3 = il2cpp_internal(DAT_181d6e630);
        FUN_180f58a90(lVar3,DAT_181d63678);
        if ((teamID & 1) == 0) {
          uVar7 = 0;
        }
        else {
          uVar7 = this.mapWidth - 1;
        }
        while( true ) {
          uVar6 = 0;
          if (0 < this.mapHeight) {
            do {
              lVar4 = this.mapGrids;
              if (lVar4 == null) throw; // [null/range check failed]
              if (**(uint32 **)(lVar4 + 16) <= uVar7) {
                uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar5,0);
              }
              lVar1 = *(int64 *)(*(uint32 **)(lVar4 + 16) + 4);
              if ((uint32)lVar1 <= uVar6) {
                uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar5,0);
              }
              lVar4 = *(int64 *)(lVar4 + 32 + ((int)uVar7 * lVar1 + (int64)(int)uVar6) * 8);
              if (lVar4 == null) throw; // [null/range check failed]
              uVar5 = *(uint64 *)(lVar4 + 24);
              cVar2 = Object.op_Equality(uVar5,0,0);
              if (cVar2) {
                if ((this.mapGrids == null) || (lVar4 = FUN_180127f50()) == null)
                throw; // [null/range check failed]
                if (*(int *)(lVar4 + 20) != 2) {
                  if ((this.mapGrids == null) ||
                     (FUN_180127f50(this.mapGrids,(int64)(int)uVar7,
                                    (int64)(int)uVar6), lVar3 == null)) throw; // [null/range check failed]
                  FUN_181827900(lVar3);
                }
              }
              uVar6 = uVar6 + 1;
            } while ((int)uVar6 < this.mapHeight);
          }
          if (lVar3 == null) break;
          if (*(int *)(lVar3 + 24) != 0) {
            uVar7 = FUN_180d8cf10(0,*(int *)(lVar3 + 24),0);
            if (*(uint32 *)(lVar3 + 24) <= uVar7) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            return lVar3[uVar7];
          }
          uVar7 = (uVar7 + (teamID & 1 ^ 1) * 2) - 1;
        }
    }

    // Token : 0x6000C0C
    // RVA   : 0x8D9170   Offset: 0x8D7970   Length: 0xA6
    public override bool Equals(object obj)
    {
        long lVar1;
        ulong in_RAX;
        if (obj != (int64 *)0) {
          lVar1 = *obj;
          in_RAX = 0;
          if ((*(byte *)(DAT_181d8b228 + 300) <= *(byte *)(lVar1 + 300)) &&
             (in_RAX = *(uint64 *)(lVar1 + 200),
             *(int64 *)((in_RAX - 8) + (uint64)*(byte *)(DAT_181d8b228 + 300) * 8) == DAT_181d8b228)
             ) {
            if ((*(byte *)(DAT_181d8b228 + 300) <= *(byte *)(lVar1 + 300)) &&
               (*(int64 *)
                 (*(int64 *)(lVar1 + 200) + -8 + (uint64)*(byte *)(DAT_181d8b228 + 300) * 8) ==
                DAT_181d8b228)) {
              return CONCAT71((int7)((uint64)*(int64 *)(lVar1 + 200) >> 8),
                              this.mapID == (int)obj[2]);
            }
                          // WARNING: Subroutine does not return
            FUN_1800d6070(obj);
          }
        }
        return in_RAX & 0xffffffffffffff00;
    }

    // Token : 0x6000C0D
    // RVA   : 0x8DEFA0   Offset: 0x8DD7A0   Length: 0xD0
    public void /*ctor*/()
    {
        ulong uVar1;
        uVar1 = il2cpp_internal(DAT_181d6e630);
        FUN_180f58a90(uVar1,DAT_181d63678);
        this.mustEmptyGrids = uVar1;
        uVar1 = il2cpp_internal(DAT_181d6e630);
        FUN_180f58a90(uVar1,DAT_181d63678);
        this.normalGrids = uVar1;
        uVar1 = il2cpp_internal(DAT_181d6e630);
        FUN_180f58a90(uVar1,DAT_181d63678);
        this.obstacleGrids = uVar1;
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x6000C0E
    // RVA   : 0x8DED40   Offset: 0x8DD540   Length: 0x25B
    private static void /*cctor*/()
    {
        var pStatics = *(int64*)(DAT_181d8b228 + 184);
        long lVar1;
        lVar1 = il2cpp_internal(DAT_181d6f030);
        FUN_180f58a90(lVar1,DAT_181d678f8);
        if (lVar1 != null) {
          FUN_181814fa0(lVar1,9,DAT_181d67a78);
          FUN_181814fa0(lVar1,11,DAT_181d67a78);
          FUN_181814fa0(lVar1,13,DAT_181d67a78);
          plVar2 = pStatics;
          *plVar2 = lVar1;
          il2cpp_internal(plVar2,lVar1);
          lVar1 = il2cpp_internal(DAT_181d73e30);
          FUN_180f58a90(lVar1,DAT_181d83ef8);
          if (lVar1 != null) {
            FUN_181814e80(lVar1,0x3f800000bf800000,DAT_181d83f78);
            FUN_181814e80(lVar1,0xc0000000bf800000,DAT_181d83f78);
            FUN_181814e80(lVar1,0xc0000000,DAT_181d83f78);
            FUN_181814e80(lVar1,0xbf800000c0000000,DAT_181d83f78);
            FUN_181814e80(lVar1,0x40000000bf800000,DAT_181d83f78);
            FUN_181814e80(lVar1,0xc0400000bf800000,DAT_181d83f78);
            FUN_181814e80(lVar1,0x40800000bf800000,DAT_181d83f78);
            FUN_181814e80(lVar1,0xc0a00000bf800000,DAT_181d83f78);
            plVar2 = (int64 *)(pStatics + 8);
            *plVar2 = lVar1;
            il2cpp_internal(plVar2,lVar1);
            return;
          }
        }
    }

}
