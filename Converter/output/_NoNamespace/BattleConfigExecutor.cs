// ============================================================
// Type  : BattleConfigExecutor
// Token : 0x2000174
// ============================================================

public class BattleConfigExecutor
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40009E9
    private static readonly char BattleFieldSplit;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000C05
    // RVA   : 0x52D8A0   Offset: 0x52C6A0   Length: 0xA32
    public static void Execute(BattleData data, string param)
    {
        uint uVar1;
        uint uVar2;
        uint uVar3;
        byte uVar4;
        byte uVar5;
        uint uVar6;
        uint uVar7;
        uint uVar8;
        ulong uVar9;
        ulong uVar10;
        ulong uVar11;
        ulong uVar12;
        ulong uVar13;
        long lVar14;
        long lVar15;
        long lVar16;
        long lVar17;
        ulong uVar18;
        long lVar19;
        int iVar20;
        int iVar21;
        ulong uVar22;
        uint uVar23;
        ulong in_stack_ffffffffffffff38;
        uint uVar24;
        uVar24 = (uint32)((uint64)in_stack_ffffffffffffff38 >> 32);
        uVar10 = il2cpp_internal(DAT_181e73338);
        FUN_1810f3480(uVar10,DAT_181e6d6f0);
        uVar11 = il2cpp_internal(DAT_181e73338);
        FUN_1810f3480(uVar11,DAT_181e6d6f0);
        uVar12 = il2cpp_internal(DAT_181e73338);
        FUN_1810f3480(uVar12,DAT_181e6d6f0);
        uVar13 = il2cpp_internal(DAT_181e73338);
        FUN_1810f3480(uVar13,DAT_181e6d6f0);
        lVar14 = il2cpp_internal(DAT_181e79228);
        FUN_1810f3480(lVar14,DAT_181e90a58);
        lVar15 = il2cpp_internal(DAT_181e79228);
        FUN_1810f3480(lVar15,DAT_181e90a58);
        lVar16 = il2cpp_internal(DAT_181e791a8);
        FUN_1810f3480(lVar16,DAT_181e90858);
        lVar17 = *(int64 *)(*(int64 *)(DAT_181e71f68 + 184) + 24);
        if (lVar17 != null) {
          PlotController.SetPlotFightHeroLists(lVar17,uVar10,uVar11,uVar12,uVar13,0);
          if (data != null) {
            uVar9 = *(uint64 *)(data + 48);
            lVar17 = new c.DisplayClass9_0(0);
            if (lVar17 != null) {
              *(uint32 *)(lVar17 + 16) = 0;
              *(uint8 *)(lVar17 + 20) = 0;
              *(uint64 *)(lVar17 + 24) = uVar10;
              BattleConfigExecutor.ParseBattleHeroStr(uVar9,lVar17,0);
              uVar9 = *(uint64 *)(data + 56);
              lVar17 = new c.DisplayClass9_0(0);
              if (lVar17 != null) {
                *(uint64 *)(lVar17 + 24) = uVar11;
                *(uint32 *)(lVar17 + 16) = 0;
                *(uint8 *)(lVar17 + 20) = 1;
                *(int64 *)(lVar17 + 32) = lVar14;
                *(int64 *)(lVar17 + 40) = lVar16;
                BattleConfigExecutor.ParseBattleHeroStr(uVar9,lVar17,0);
                uVar9 = *(uint64 *)(data + 64);
                lVar17 = new c.DisplayClass9_0(0);
                if (lVar17 != null) {
                  *(uint32 *)(lVar17 + 16) = 1;
                  *(uint8 *)(lVar17 + 20) = 0;
                  *(uint64 *)(lVar17 + 24) = uVar12;
                  BattleConfigExecutor.ParseBattleHeroStr(uVar9,lVar17,0);
                  uVar9 = *(uint64 *)(data + 72);
                  lVar17 = new c.DisplayClass9_0(0);
                  if (lVar17 != null) {
                    *(uint64 *)(lVar17 + 24) = uVar13;
                    *(uint32 *)(lVar17 + 16) = 1;
                    *(uint8 *)(lVar17 + 20) = 1;
                    *(int64 *)(lVar17 + 32) = lVar15;
                    *(int64 *)(lVar17 + 40) = lVar16;
                    BattleConfigExecutor.ParseBattleHeroStr(uVar9,lVar17,0);
                    lVar17 = PlotController.LaBaFestivelResultTalkText;
                    if (lVar17 != null) {
                      *(uint8 *)(lVar17 + 0x1d1) = *(uint8 *)(data + 120);
                      lVar17 = PlotController.LaBaFestivelResultTalkText;
                      if (lVar17 != null) {
                        *(uint32 *)(lVar17 + 140) = *(uint32 *)(data + 124);
                        uVar6 = *(uint32 *)(data + 32);
                        uVar23 = *(uint32 *)(data + 80);
                        lVar17 = PlotController.LaBaFestivelResultTalkText;
                        uVar4 = *(uint8 *)(data + 93);
                        uVar9 = *(uint64 *)(data + 112);
                        uVar5 = *(uint8 *)(data + 92);
                        uVar18 = BattleConfigExecutor.ParseBattleMapTypeData
                                           (*(uint64 *)(data + 40),0);
                        if (lVar17 != null) {
                          uVar22 = uVar12;
                          BattleController.PrepareBattleMap
                                    (lVar17,uVar6,uVar10,uVar11,uVar12,uVar13,CONCAT44(uVar24,uVar23),
                                     uVar9,uVar5,uVar4,uVar18,*(uint32 *)(data + 84),
                                     *(uint32 *)(data + 88),*(uint8 *)(data + 121),0);
                          iVar21 = 0;
                          iVar20 = iVar21;
                          if (lVar14 != null) {
                            for (; uVar24 = (uint32)((uint64)uVar22 >> 32),
                                uVar23 = (uint32)((uint64)uVar13 >> 32),
                                iVar20 < *(int *)(lVar14 + 24); iVar20 = iVar20 + 1) {
                              lVar17 = FUN_180210a70(0);
                              lVar19 = FUN_1800024b0(lVar14,iVar20,DAT_181e90be0);
                              if (lVar19 == null) throw; // [null/range check failed]
                              uVar11 = *(uint64 *)(lVar19 + 16);
                              lVar19 = FUN_1800024b0(lVar14,iVar20,DAT_181e90be0);
                              if (lVar19 == null) throw; // [null/range check failed]
                              uVar6 = *(uint32 *)(lVar19 + 24);
                              lVar19 = FUN_1800024b0(lVar14,iVar20,DAT_181e90be0);
                              if (lVar19 == null) throw; // [null/range check failed]
                              uVar1 = *(uint32 *)(lVar19 + 28);
                              lVar19 = FUN_1800024b0(lVar14,iVar20,DAT_181e90be0);
                              if ((lVar19 == null) || (lVar17 == null)) throw; // [null/range check failed]
                              uVar13 = CONCAT44(uVar23,*(uint32 *)(lVar19 + 32));
                              uVar22 = CONCAT44(uVar24,uVar1);
                              PlotController.PlotFightAddTeamSupport
                                        (lVar17,0,uVar11,uVar6,uVar22,uVar13,0);
                            }
                            iVar20 = iVar21;
                            if (lVar15 != null) {
                              for (; uVar24 = (uint32)((uint64)uVar22 >> 32),
                                  uVar23 = (uint32)((uint64)uVar13 >> 32),
                                  iVar20 < *(int *)(lVar15 + 24); iVar20 = iVar20 + 1) {
                                lVar14 = FUN_180210a70(0);
                                lVar17 = FUN_1800024b0(lVar15,iVar20,DAT_181e90be0);
                                if (lVar17 == null) throw; // [null/range check failed]
                                uVar11 = *(uint64 *)(lVar17 + 16);
                                lVar17 = FUN_1800024b0(lVar15,iVar20,DAT_181e90be0);
                                if (lVar17 == null) throw; // [null/range check failed]
                                uVar6 = *(uint32 *)(lVar17 + 24);
                                lVar17 = FUN_1800024b0(lVar15,iVar20,DAT_181e90be0);
                                if (lVar17 == null) throw; // [null/range check failed]
                                uVar1 = *(uint32 *)(lVar17 + 28);
                                lVar17 = FUN_1800024b0(lVar15,iVar20,DAT_181e90be0);
                                if ((lVar17 == null) || (lVar14 == null)) throw; // [null/range check failed]
                                uVar13 = CONCAT44(uVar23,*(uint32 *)(lVar17 + 32));
                                uVar22 = CONCAT44(uVar24,uVar1);
                                PlotController.PlotFightAddTeamSupport
                                          (lVar14,1,uVar11,uVar6,uVar22,uVar13,0);
                              }
                              if (lVar16 != null) {
                                while( true ) {
                                  uVar24 = (uint32)((uint64)uVar22 >> 32);
                                  uVar23 = (uint32)((uint64)uVar13 >> 32);
                                  if (*(int *)(lVar16 + 24) <= iVar21) {
                                    uVar11 = *(uint64 *)(data + 104);
                                    BattleConfigExecutor.ApplyBattlePlotStr(uVar11,0);
                                    BattleConfigExecutor.ApplyBattleTrophy(data,0);
                                    BattleConfigExecutor.RunBattlePreAction
                                              (*(uint64 *)(data + 128),param,uVar10,uVar12,0);
                                    return;
                                  }
                                  lVar14 = FUN_180210a70(0);
                                  lVar15 = FUN_1800024b0(lVar16,iVar21,DAT_181e909d8);
                                  if (lVar15 == null) break;
                                  uVar6 = *(uint32 *)(lVar15 + 16);
                                  lVar15 = FUN_1800024b0(lVar16,iVar21,DAT_181e909d8);
                                  if (lVar15 == null) break;
                                  uVar1 = *(uint32 *)(lVar15 + 20);
                                  lVar15 = FUN_1800024b0(lVar16,iVar21,DAT_181e909d8);
                                  if (lVar15 == null) break;
                                  uVar2 = *(uint32 *)(lVar15 + 24);
                                  lVar15 = FUN_1800024b0(lVar16,iVar21,DAT_181e909d8);
                                  if (lVar15 == null) break;
                                  uVar7 = *(uint32 *)(lVar15 + 28);
                                  lVar15 = FUN_1800024b0(lVar16,iVar21,DAT_181e909d8);
                                  if (lVar15 == null) break;
                                  uVar8 = *(uint32 *)(lVar15 + 32);
                                  lVar15 = FUN_1800024b0(lVar16,iVar21,DAT_181e909d8);
                                  if (lVar15 == null) break;
                                  uVar11 = *(uint64 *)(lVar15 + 40);
                                  lVar15 = FUN_1800024b0(lVar16,iVar21,DAT_181e909d8);
                                  if (lVar15 == null) break;
                                  uVar4 = *(uint8 *)(lVar15 + 48);
                                  lVar15 = FUN_1800024b0(lVar16,iVar21,DAT_181e909d8);
                                  if (lVar15 == null) break;
                                  uVar3 = *(uint32 *)(lVar15 + 52);
                                  lVar15 = FUN_1800024b0(lVar16,iVar21,DAT_181e909d8);
                                  if ((lVar15 == null) || (lVar14 == null)) break;
                                  uVar13 = CONCAT44(uVar23,uVar8);
                                  uVar22 = CONCAT44(uVar24,uVar7);
                                  PlotController.AddForceHeroToTeamSupportPrepareData
                                            (lVar14,uVar6,uVar1,uVar2,uVar22,uVar13,uVar11,uVar4,uVar3,
                                             *(uint32 *)(lVar15 + 36),0);
                                  iVar21 = iVar21 + 1;
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

    // Token : 0x6000C06
    // RVA   : 0x52ED90   Offset: 0x52DB90   Length: 0x94F
    private static void ParseBattleHeroStr(string str, FightParseContext context)
    {
        uint uVar1;
        bool cVar2;
        uint uVar3;
        long lVar4;
        long lVar5;
        long lVar6;
        ulong uVar7;
        ulong uVar8;
        uint uVar9;
        byte uVar10;
        uint uVar11;
        byte uVar12;
        uint uVar13;
        uint uVar14;
        ulong in_stack_ffffffffffffff70;
        uint uVar15;
        cVar2 = FUN_180ad1200(str,0);
        if ((cVar2) || (cVar2 = FUN_1816387f0(str,"无",0), cVar2)) {
          return;
        }
        lVar4 = FUN_1801dfd90(DAT_181e81128,1);
        if (lVar4 != null) {
          if (*(int *)(lVar4 + 24) == 0) {
            uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar8,0);
          }
          *(uint16 *)(lVar4 + 32) = 59;
          if (str != null) {
            lVar4 = String.Split(str,lVar4,0);
            uVar11 = 0;
            if (lVar4 != null) {
              do {
                while( true ) {
                  if ((int)*(uint32 *)(lVar4 + 24) <= (int)uVar11) {
                    return;
                  }
                  if (*(uint32 *)(lVar4 + 24) <= uVar11) {
                    uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1801e02d0(uVar8,0);
                  }
                  cVar2 = FUN_180ad1200(lVar4[uVar11]);
                  if (!cVar2) break;
        LAB_18052f54e:
                  uVar11 = uVar11 + 1;
                }
                uVar12 = 0;
                uVar8 = 1;
                uVar10 = 1;
                if (*(uint32 *)(lVar4 + 24) <= uVar11) {
                  uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1801e02d0(uVar8,0);
                }
                lVar6 = lVar4[uVar11];
                lVar5 = FUN_1801dfd90(DAT_181e81128,1);
                if (lVar5 == null) break;
                if (*(int *)(lVar5 + 24) == 0) {
                  uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1801e02d0(uVar8,0);
                }
                *(uint16 *)(lVar5 + 32) = 64;
                if (lVar6 == null) break;
                lVar6 = String.Split(lVar6,lVar5,0);
                uVar9 = 1;
                while( true ) {
                  if (lVar6 == null) throw; // [null/range check failed]
                  uVar1 = *(uint32 *)(lVar6 + 24);
                  if ((int)uVar1 <= (int)uVar9) break;
                  if (uVar1 <= uVar9) {
                    uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1801e02d0(uVar8,0);
                  }
                  lVar5 = lVar6[uVar9];
                  if (lVar5 == null) {
        LAB_18052f05d:
                    uVar9 = uVar9 + 1;
                  }
                  else {
                    cVar2 = FUN_1816387f0(lVar5);
                    if (!cVar2) {
                      cVar2 = FUN_1816387f0(lVar5);
                      if (!cVar2) {
                        cVar2 = FUN_1816387f0(lVar5);
                        if (cVar2) {
                          uVar10 = 0;
                        }
                        goto LAB_18052f05d;
                      }
                      uVar8 = 0;
                      uVar9 = uVar9 + 1;
                    }
                    else {
                      uVar12 = 1;
                      uVar9 = uVar9 + 1;
                    }
                  }
                }
                if (uVar1 == 0) {
                  uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1801e02d0(uVar8,0);
                }
                lVar6 = *(int64 *)(lVar6 + 32);
                lVar5 = FUN_1801dfd90(DAT_181e81128,1);
                if (lVar5 == null) break;
                if (*(int *)(lVar5 + 24) == 0) {
                  uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1801e02d0(uVar8,0);
                }
                *(uint16 *)(lVar5 + 32) = 35;
                if ((lVar6 == null) || (lVar6 = String.Split(lVar6,lVar5,0)) == null) break;
                if ((int)*(uint32 *)(lVar6 + 24) < 2) {
        LAB_18052f116:
                  uVar13 = 0xbf800000;
                }
                else {
                  if (*(uint32 *)(lVar6 + 24) < 2) {
                    uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1801e02d0(uVar8,0);
                  }
                  cVar2 = FUN_180ad1200(*(uint64 *)(lVar6 + 40),0);
                  if (cVar2) goto LAB_18052f116;
                  if (*(uint32 *)(lVar6 + 24) < 2) {
                    uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1801e02d0(uVar8,0);
                  }
                  uVar7 = *(uint64 *)(lVar6 + 40);
                  uVar13 = BattleConfigExecutor.ParseCellFloat(uVar7,0);
                }
                if ((int)*(uint32 *)(lVar6 + 24) < 3) {
        LAB_18052f170:
                  uVar14 = 0;
                }
                else {
                  if (*(uint32 *)(lVar6 + 24) < 3) {
                    uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1801e02d0(uVar8,0);
                  }
                  cVar2 = FUN_180ad1200(*(uint64 *)(lVar6 + 48),0);
                  if (cVar2) goto LAB_18052f170;
                  if (*(uint32 *)(lVar6 + 24) < 3) {
                    uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1801e02d0(uVar8,0);
                  }
                  uVar7 = *(uint64 *)(lVar6 + 48);
                  uVar14 = BattleConfigExecutor.ParseCellFloat(uVar7,0);
                }
                if ((int)*(uint32 *)(lVar6 + 24) < 4) {
        LAB_18052f1c8:
                  uVar3 = 0xffffffff;
                }
                else {
                  if (*(uint32 *)(lVar6 + 24) < 4) {
                    uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1801e02d0(uVar8,0);
                  }
                  cVar2 = FUN_180ad1200(*(uint64 *)(lVar6 + 56),0);
                  if (cVar2) goto LAB_18052f1c8;
                  if (*(uint32 *)(lVar6 + 24) < 4) {
                    uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1801e02d0(uVar8,0);
                  }
                  uVar7 = *(uint64 *)(lVar6 + 56);
                  uVar3 = BattleConfigExecutor.ParseCellInt(uVar7,0);
                }
                if (*(int *)(lVar6 + 24) == 0) {
                  uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1801e02d0(uVar8,0);
                }
                lVar6 = *(int64 *)(lVar6 + 32);
                lVar5 = FUN_1801dfd90(DAT_181e81128,1);
                if (lVar5 == null) break;
                if (*(int *)(lVar5 + 24) == 0) {
                  uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1801e02d0(uVar8,0);
                }
                *(uint16 *)(lVar5 + 32) = **(uint16 **)(DAT_181e903a0 + 184);
                if ((lVar6 == null) || (lVar6 = String.Split(lVar6,lVar5,0)) == null) break;
                if (*(int *)(lVar6 + 24) == 0) {
                  uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1801e02d0(uVar8,0);
                }
                lVar5 = *(int64 *)(lVar6 + 32);
                if (lVar5 == null) {
        LAB_18052f4f8:
                  if (*(uint32 *)(lVar4 + 24) <= uVar11) {
                    uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1801e02d0(uVar8,0);
                  }
                  uVar8 = String.Format("BattleData解析错误,未知条目类型: {0}");
                  Debug.LogError(uVar8);
                  goto LAB_18052f54e;
                }
                cVar2 = FUN_1816387f0(lVar5,"玩家");
                uVar15 = (uint32)((uint64)in_stack_ffffffffffffff70 >> 32);
                if (!cVar2) {
                  cVar2 = FUN_1816387f0(lVar5,"英雄");
                  uVar15 = (uint32)((uint64)in_stack_ffffffffffffff70 >> 32);
                  if (cVar2) {
                    lVar5 = FUN_1802106e0(0);
                    if (lVar5 != null) {
                      if (*(uint32 *)(lVar6 + 24) < 2) {
                        uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1801e02d0(uVar8,0);
                      }
                      if (*(int64 *)(lVar5 + 32) != 0) {
                        uVar7 = WorldData.GetHero(*(int64 *)(lVar5 + 32),
                                                   *(uint64 *)(lVar6 + 40),0);
                        goto LAB_18052f2ce;
                      }
                    }
                    break;
                  }
                  cVar2 = FUN_1816387f0(lVar5,"临时");
                  uVar15 = (uint32)((uint64)in_stack_ffffffffffffff70 >> 32);
                  if (cVar2) {
                    lVar5 = FUN_180210a70(0);
                    if (*(uint32 *)(lVar6 + 24) < 2) {
                      uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1801e02d0(uVar8,0);
                    }
                    if ((*(int64 *)(lVar6 + 40) != 0) &&
                       (uVar7 = String.Replace(*(int64 *)(lVar6 + 40),124,59,0), lVar5 != null)) {
                      uVar7 = PlotController.GetTempPlotHeroData(lVar5,uVar7,0);
                      goto LAB_18052f2ce;
                    }
                    break;
                  }
                  cVar2 = FUN_1816387f0(lVar5,"生成");
                  if (!cVar2) {
                    cVar2 = FUN_1816387f0(lVar5,"门派");
                    if (!cVar2) goto LAB_18052f4f8;
                    BattleConfigExecutor.AddForceBattleHeros(context,lVar6,uVar13,0);
                    uVar11 = uVar11 + 1;
                  }
                  else {
                    in_stack_ffffffffffffff70 = 0;
                    BattleConfigExecutor.GenerateBattleHeros(context,lVar6,uVar13,uVar14,uVar3,0);
                    uVar11 = uVar11 + 1;
                  }
                }
                else {
                  lVar6 = FUN_1802106e0(0);
                  if ((lVar6 == null) || (*(int64 *)(lVar6 + 32) == 0)) break;
                  uVar7 = WorldData.Player(*(int64 *)(lVar6 + 32),0);
        LAB_18052f2ce:
                  in_stack_ffffffffffffff70 = CONCAT44(uVar15,uVar13);
                  BattleConfigExecutor.AddBattleHero
                            (context,uVar7,uVar10,uVar8,uVar12,in_stack_ffffffffffffff70,uVar14,uVar3,0);
                  uVar11 = uVar11 + 1;
                }
              } while( true );
            }
          }
        }
    }

    // Token : 0x6000C07
    // RVA   : 0x52B5C0   Offset: 0x52A3C0   Length: 0x16D
    private static void AddBattleHero(FightParseContext context, HeroData hero, bool forceLeaveTeam, bool forceEnterFight, bool fightSpeControl, float supportTime, float startMovePower, int enterSide)
    {
        void BattleConfigExecutor.AddBattleHero
                     (int64 context,int64 hero,uint8 forceLeaveTeam,uint8 forceEnterFight,char fightSpeControl
                     ,float supportTime,uint32 startMovePower,uint32 enterSide)
        {
        int64 lVar1;
        uint64 uVar2;
        int64 lVar3;
        if ((hero == null) || (*(char *)(hero + 97) != false)) {
          return;
        }
        BattleConfigExecutor.PrepareFightHeroState(hero,forceLeaveTeam,forceEnterFight,0);
        if (fightSpeControl) {
          *(uint8 *)(hero + 0x246) = 1;
        }
        if (context != null) {
          if ((*(char *)(context + 20) == false) || (supportTime < 0.0)) {
            lVar1 = *(int64 *)(context + 24);
            lVar3 = hero;
            uVar2 = DAT_181e6d770;
          }
          else {
            lVar1 = *(int64 *)(context + 32);
            var lVar3 = new c.DisplayClass9_0(0);
            if (lVar3 == null) throw; // [null/range check failed]
            *(int64 *)(lVar3 + 16) = hero;
            *(uint32 *)(lVar3 + 28) = startMovePower;
            *(float *)(lVar3 + 24) = supportTime;
            *(uint32 *)(lVar3 + 32) = enterSide;
            uVar2 = DAT_181e90ad8;
          }
          if (lVar1 != null) {
            FUN_18175de30(lVar1,lVar3,uVar2);
            return;
          }
        }
    }

    // Token : 0x6000C08
    // RVA   : 0x52FE00   Offset: 0x52EC00   Length: 0x24E
    private static void PrepareFightHeroState(HeroData hero, bool forceLeaveTeam, bool forceEnterFight)
    {
        bool cVar1;
        long lVar2;
        if ((GameController._instance != null) &&
           (GameController.CountHeroData(GameController._instance,hero,1,0), hero != null
           )) {
          HeroData.RecoverState(hero,0);
          *(uint8 *)(hero + 0x245) = forceEnterFight;
          if (!forceLeaveTeam) {
            return;
          }
          if ((GameController._instance != null) &&
             (lVar2 = GameController._instance.worldData) != null) {
            lVar2 = WorldData.Player(lVar2,0);
            if (hero == lVar2) {
              return;
            }
            lVar2 = FUN_1802106e0(0);
            if ((((lVar2 != null) && (lVar2.villageAreaID != null)) &&
                (lVar2 = WorldData.Player(lVar2.villageAreaID,0)) != null) &&
               (*(int64 *)(lVar2 + 0x2f8) != 0)) {
              cVar1 = FUN_18176a2d0(*(int64 *)(lVar2 + 0x2f8),*(uint32 *)(hero + 88),
                                    DAT_181e71570);
              if (!cVar1) {
                return;
              }
              cVar1 = HeroData.MissionKeepInTeam(hero,0);
              if (cVar1) {
                return;
              }
              lVar2 = FUN_1802106e0(0);
              if (lVar2 != null) {
                GameController.HeroLeaveTeam(lVar2,hero,0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x6000C09
    // RVA   : 0x52E2E0   Offset: 0x52D0E0   Length: 0x4D5
    private static void GenerateBattleHeros(FightParseContext context, string[] paramList, float supportTime, float startMovePower, int enterSide)
    {
        void BattleConfigExecutor.GenerateBattleHeros
                     (uint64 context,int64 paramList,uint32 supportTime,uint32 startMovePower,
                     uint32 enterSide)
        {
        char cVar1;
        uint8 uVar2;
        int iVar3;
        uint32 uVar4;
        int64 lVar5;
        int64 lVar6;
        uint64 uVar7;
        uint64 uVar8;
        int iVar9;
        uint32 uVar10;
        uint32 uVar11;
        uint32 uVar12;
        if (paramList == null) goto LAB_18052e740;
        uVar10 = *(uint32 *)(paramList + 24);
        if (uVar10 < 2) {
          uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1801e02d0(uVar8,0);
        }
        uVar8 = *(uint64 *)(paramList + 40);
        if ((int)uVar10 < 3) {
        LAB_18052e412:
          iVar3 = 1;
        }
        else {
          if (uVar10 < 3) {
            uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar8,0);
          }
          cVar1 = FUN_180ad1200(*(uint64 *)(paramList + 48),0);
          if (cVar1) goto LAB_18052e412;
          if (*(uint32 *)(paramList + 24) < 3) {
            uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar8,0);
          }
          cVar1 = String.op_Inequality(*(uint64 *)(paramList + 48),"无",0);
          if (!cVar1) goto LAB_18052e412;
          if (*(uint32 *)(paramList + 24) < 3) {
            uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar8,0);
          }
          uVar7 = *(uint64 *)(paramList + 48);
          iVar3 = BattleConfigExecutor.ParseCellInt(uVar7,0);
        }
        if ((int)*(uint32 *)(paramList + 24) < 4) {
          uVar4 = 0xffffffff;
        }
        else {
          if (*(uint32 *)(paramList + 24) < 4) {
            uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar8,0);
          }
          lVar6 = *(int64 *)(paramList + 56);
          cVar1 = FUN_180ad1200(lVar6,0);
          if ((!cVar1) && (cVar1 = FUN_1816387f0(lVar6,"无",0), !cVar1)) {
            if (lVar6 == null) {
        LAB_18052e740:
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            cVar1 = String.StartsWith(lVar6,"随机",0);
            if (!cVar1) {
              uVar4 = BattleConfigExecutor.ParseCellInt(lVar6,0);
            }
            else {
              lVar5 = FUN_180210740(0);
              uVar7 = String.Replace(lVar6,"随机","",0);
              uVar4 = Single.Parse(uVar7,0);
              if (lVar5 == null) goto LAB_18052e740;
              uVar4 = GameDataController.GetRandomBigForceID(lVar5,uVar4,0xfffffffe);
            }
          }
          else {
            uVar4 = 0xffffffff;
          }
          if (4 < (int)*(uint32 *)(paramList + 24)) {
            if (*(uint32 *)(paramList + 24) < 5) {
              uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar8,0);
            }
            uVar7 = *(uint64 *)(paramList + 64);
            uVar10 = BattleConfigExecutor.GetBattleHeroLv(uVar7,0);
            goto LAB_18052e5c0;
          }
        }
        uVar10 = 0;
        LAB_18052e5c0:
        if ((int)*(uint32 *)(paramList + 24) < 6) {
          uVar2 = 0;
        }
        else {
          if (*(uint32 *)(paramList + 24) < 6) {
            uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar8,0);
          }
          uVar2 = FUN_1816387f0(*(uint64 *)(paramList + 72),"随机",0);
        }
        iVar9 = 0;
        if (0 < iVar3) {
          do {
            lVar6 = FUN_1802106e0(0);
            uVar7 = uVar8;
            if (1 < iVar3) {
              uVar7 = GlobalData.GetChineseNumText(iVar9,0);
              uVar7 = String.Concat(uVar8,uVar7,0);
            }
            if (lVar6 == null) goto LAB_18052e740;
            uVar12 = 0;
            uVar11 = uVar10;
            uVar7 = GameController.GenerateHeroData(lVar6,uVar7,0xffffffff,uVar4,uVar10,uVar2,0);
            BattleConfigExecutor.AddBattleHero
                      (context,uVar7,1,1,uVar11 & 0xffffff00,supportTime,CONCAT44(uVar12,startMovePower),enterSide,0);
            iVar9 = iVar9 + 1;
          } while (iVar9 < iVar3);
        }
    }

    // Token : 0x6000C0A
    // RVA   : 0x52B730   Offset: 0x52A530   Length: 0x7B9
    private static void AddForceBattleHeros(FightParseContext context, string[] paramList, float supportTime)
    {
        bool cVar1;
        byte uVar2;
        byte uVar3;
        uint uVar4;
        uint uVar5;
        uint uVar6;
        ulong uVar7;
        long lVar8;
        long lVar9;
        ulong uVar10;
        uint uVar11;
        uint[] local_res10 = new uint[2];
        if (paramList == null) throw; // [null/range check failed]
        if (*(uint32 *)(paramList + 24) < 2) {
          uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1801e02d0(uVar7,0);
        }
        uVar7 = *(uint64 *)(paramList + 40);
        uVar7 = BattleConfigExecutor.BattleCellText(uVar7,0);
        local_res10[0] = Int32.Parse(uVar7,0);
        if ((GameController._instance == null) ||
           (lVar8 = GameController._instance.worldData) == null)
        throw; // [null/range check failed]
        lVar8 = WorldData.GetForce(lVar8,local_res10[0],0);
        if (lVar8 == null) {
          uVar7 = Int32.ToString(local_res10,0);
          uVar7 = String.Concat("BattleData解析错误,门派ID不存在: ",uVar7,0);
          Debug.LogError(uVar7,0);
          return;
        }
        if ((int)*(uint32 *)(paramList + 24) < 3) {
        LAB_18052b9c6:
          uVar4 = 0xffffffff;
        }
        else {
          if (*(uint32 *)(paramList + 24) < 3) {
            uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar7,0);
          }
          cVar1 = String.op_Inequality(*(uint64 *)(paramList + 48),"无",0);
          if (!cVar1) goto LAB_18052b9c6;
          if (*(uint32 *)(paramList + 24) < 3) {
            uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar7,0);
          }
          uVar7 = *(uint64 *)(paramList + 48);
          uVar4 = BattleConfigExecutor.ParseCellInt(uVar7,0);
        }
        if ((int)*(uint32 *)(paramList + 24) < 4) {
        LAB_18052ba2a:
          uVar5 = 99;
        }
        else {
          if (*(uint32 *)(paramList + 24) < 4) {
            uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar7,0);
          }
          cVar1 = String.op_Inequality(*(uint64 *)(paramList + 56),"无",0);
          if (!cVar1) goto LAB_18052ba2a;
          if (*(uint32 *)(paramList + 24) < 4) {
            uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar7,0);
          }
          uVar7 = *(uint64 *)(paramList + 56);
          uVar5 = BattleConfigExecutor.ParseCellInt(uVar7,0);
        }
        if ((int)*(uint32 *)(paramList + 24) < 5) {
        LAB_18052ba8e:
          uVar6 = 999999;
        }
        else {
          if (*(uint32 *)(paramList + 24) < 5) {
            uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar7,0);
          }
          cVar1 = String.op_Inequality(*(uint64 *)(paramList + 64),"无",0);
          if (!cVar1) goto LAB_18052ba8e;
          if (*(uint32 *)(paramList + 24) < 5) {
            uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar7,0);
          }
          uVar7 = *(uint64 *)(paramList + 64);
          uVar6 = BattleConfigExecutor.ParseCellInt(uVar7,0);
        }
        if ((int)*(uint32 *)(paramList + 24) < 6) {
          uVar2 = 1;
        LAB_18052baa4:
          uVar11 = 0;
        }
        else {
          if (*(uint32 *)(paramList + 24) < 6) {
            uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar7,0);
          }
          uVar2 = FUN_1816387f0(*(uint64 *)(paramList + 72),"是",0);
          if ((int)*(uint32 *)(paramList + 24) < 7) goto LAB_18052baa4;
          if (*(uint32 *)(paramList + 24) < 7) {
            uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar7,0);
          }
          cVar1 = String.op_Inequality(*(uint64 *)(paramList + 80),"无",0);
          if (!cVar1) goto LAB_18052baa4;
          if (*(uint32 *)(paramList + 24) < 7) {
            uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar7,0);
          }
          uVar7 = *(uint64 *)(paramList + 80);
          uVar11 = BattleConfigExecutor.ParseCellFloat(uVar7,0);
        }
        if ((int)*(uint32 *)(paramList + 24) < 8) {
          uVar3 = 1;
        LAB_18052bab4:
          uVar10 = 0;
        }
        else {
          if (*(uint32 *)(paramList + 24) < 8) {
            uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar7,0);
          }
          uVar3 = FUN_1816387f0(*(uint64 *)(paramList + 88),"是",0);
          if ((int)*(uint32 *)(paramList + 24) < 9) goto LAB_18052bab4;
          if (*(uint32 *)(paramList + 24) < 9) {
            uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar7,0);
          }
          cVar1 = FUN_180ad1200(*(uint64 *)(paramList + 96),0);
          if (cVar1) goto LAB_18052bab4;
          if (*(uint32 *)(paramList + 24) < 9) {
            uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar7,0);
          }
          lVar8 = *(int64 *)(paramList + 96);
          lVar9 = FUN_1801dfd90(DAT_181e81128,1);
          if (lVar9 == null) throw; // [null/range check failed]
          if (*(int *)(lVar9 + 24) == 0) {
            uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar7,0);
          }
          *(uint16 *)(lVar9 + 32) = 47;
          if (lVar8 == null) throw; // [null/range check failed]
          uVar7 = String.Split(lVar8,lVar9,0);
          uVar10 = il2cpp_internal(DAT_181e77728);
          FUN_1817673a0(uVar10,uVar7,DAT_181e86270);
        }
        if (context != null) {
          if ((*(char *)(context + 20) == false) || (supportTime < 0.0)) {
            lVar8 = *(int64 *)(*(int64 *)(DAT_181e71f68 + 184) + 24);
            if (lVar8 != null) {
              PlotController.AddForceHeroToList
                        (lVar8,*(uint64 *)(context + 24),local_res10[0],uVar4,uVar5,uVar10,uVar2,
                         uVar11,uVar6,uVar3,0);
              return;
            }
          }
          else {
            lVar8 = *(int64 *)(context + 40);
            lVar9 = new WaitSupportForce(0);
            if (lVar9 != null) {
              *(uint32 *)(lVar9 + 16) = *(uint32 *)(context + 16);
              *(uint32 *)(lVar9 + 20) = local_res10[0];
              *(uint64 *)(lVar9 + 40) = uVar10;
              *(float *)(lVar9 + 24) = supportTime;
              *(uint32 *)(lVar9 + 28) = uVar4;
              *(uint32 *)(lVar9 + 32) = uVar5;
              *(uint32 *)(lVar9 + 36) = uVar6;
              *(uint32 *)(lVar9 + 52) = uVar11;
              *(uint8 *)(lVar9 + 48) = uVar2;
              if (lVar8 != null) {
                FUN_18175de30(lVar8,lVar9,DAT_181e908d8);
                return;
              }
            }
          }
        }
    }

    // Token : 0x6000C0B
    // RVA   : 0x52E7C0   Offset: 0x52D5C0   Length: 0x153
    private static int GetBattleHeroForceID(string str)
    {
        bool cVar1;
        ulong uVar2;
        long lVar3;
        uint uVar4;
        cVar1 = FUN_180ad1200(str,0);
        if (!cVar1) {
          cVar1 = FUN_1816387f0(str,"无",0);
          if (!cVar1) {
            if (str != null) {
              cVar1 = String.StartsWith(str,"随机",0);
              if (!cVar1) {
                uVar2 = BattleConfigExecutor.ParseCellInt(str,0);
                return uVar2;
              }
              lVar3 = FUN_180210740(0);
              uVar2 = String.Replace(str,"随机","",0);
              uVar4 = Single.Parse(uVar2,0);
              if (lVar3 != null) {
                uVar2 = GameDataController.GetRandomBigForceID(lVar3,uVar4,0xfffffffe);
                return uVar2;
              }
            }
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
        }
        return 0xffffffff;
    }

    // Token : 0x6000C0C
    // RVA   : 0x52E920   Offset: 0x52D720   Length: 0x2A6
    private static float GetBattleHeroLv(string str)
    {
        bool cVar1;
        long lVar3;
        ulong uVar4;
        int iVar5;
        uint64 extraout_XMM0_Qb;
        uint8 auVar6 [16];
        uint64 extraout_XMM0_Qb_00;
        uint64 extraout_XMM0_Qb_01;
        uint8 auVar7 [16];
        float fVar8;
        cVar1 = FUN_180ad1200(str,0);
        if ((cVar1) || (cVar1 = FUN_1816387f0(str,"无",0), cVar1)) {
          return 0;
        }
        iVar5 = 1;
        fVar8 = 0.0;
        if (str == null) {
        LAB_18052ebc1:
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        for (; iVar5 < *(int *)(str + 16); iVar5 = iVar5 + 1) {
          sVar2 = String.get_Chars(str,iVar5,0);
          if ((sVar2 == 43) || (sVar2 = String.get_Chars(str,iVar5,0), sVar2 == 45)) {
            if (iVar5 != -1) {
              lVar3 = String.Substring(str,0,iVar5,0);
              uVar4 = String.Substring(str,iVar5,0);
              fVar8 = (float)BattleConfigExecutor.ParseCellFloat(uVar4,0);
              str = lVar3;
              if (lVar3 == null) goto LAB_18052ea78;
            }
            break;
          }
        }
        cVar1 = FUN_1816387f0(str,"建筑等级",0);
        if (!cVar1) {
          cVar1 = FUN_1816387f0(str,"事件难度",0);
          if (!cVar1) {
            cVar1 = FUN_1816387f0(str,"游戏难度",0);
            if (!cVar1) {
        LAB_18052ea78:
              auVar7._0_8_ = BattleConfigExecutor.ParseCellFloat(str,0);
              auVar7._8_8_ = extraout_XMM0_Qb;
            }
            else {
              lVar3 = FUN_1802106e0(0);
              if ((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) goto LAB_18052ebc1;
              auVar7 = ZEXT416((uint32)(float)*(int *)(*(int64 *)(lVar3 + 32) + 160));
            }
          }
          else {
            lVar3 = FUN_180210a70(0);
            if (lVar3 == null) goto LAB_18052ebc1;
            auVar7._0_8_ = PlotController.GetNowEventDifficulty(lVar3,0);
            auVar7._8_8_ = extraout_XMM0_Qb_01;
          }
        }
        else {
          lVar3 = FUN_1802102e0(0);
          if (lVar3 == null) goto LAB_18052ebc1;
          auVar7._0_8_ = BuildingUIController.GetBuildingHeroLv(lVar3,0);
          auVar7._8_8_ = extraout_XMM0_Qb_00;
        }
        auVar6._4_12_ = auVar7._4_12_;
        auVar6._0_4_ = auVar7._0_4_ + fVar8;
        return auVar6._0_8_;
    }

    // Token : 0x6000C0D
    // RVA   : 0x52F6E0   Offset: 0x52E4E0   Length: 0x523
    private static BattleMapTypeData ParseBattleMapTypeData(string str)
    {
        bool cVar1;
        uint uVar2;
        long lVar3;
        ulong uVar4;
        long lVar5;
        cVar1 = FUN_180ad1200(str,0);
        if (cVar1) {
          return 0;
        }
        cVar1 = FUN_1816387f0(str,"自动",0);
        if (cVar1) {
          return 0;
        }
        uVar2 = 1;
        lVar3 = FUN_1801dfd90(DAT_181e81128,1);
        if (lVar3 == null) {
        LAB_18052fbbe:
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        if (*(int *)(lVar3 + 24) == 0) {
          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1801e02d0(uVar4,0);
        }
        *(uint16 *)(lVar3 + 32) = **(uint16 **)(DAT_181e903a0 + 184);
        if ((str == null) || (lVar3 = String.Split(str,lVar3,0)) == null) goto LAB_18052fbbe;
        if (*(int *)(lVar3 + 24) == 0) {
          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1801e02d0(uVar4,0);
        }
        lVar5 = *(int64 *)(lVar3 + 32);
        if (lVar5 == null) {
          return 0;
        }
        cVar1 = FUN_1816387f0(lVar5,"野外",0);
        if (cVar1) {
          uVar4 = new BattleMapTypeData(0,0);
          return uVar4;
        }
        cVar1 = FUN_1816387f0(lVar5,"城镇",0);
        if (cVar1) {
          uVar4 = new BattleMapTypeData(1,0);
          return uVar4;
        }
        cVar1 = FUN_1816387f0(lVar5,"室内",0);
        if (cVar1) {
          uVar4 = new BattleMapTypeData(2);
          return uVar4;
        }
        cVar1 = FUN_1816387f0(lVar5,"擂台",0);
        if (cVar1) {
          uVar4 = new BattleMapTypeData(3);
          return uVar4;
        }
        cVar1 = FUN_1816387f0(lVar5,"攻城战",0);
        if (!cVar1) {
          return 0;
        }
        lVar5 = "";
        if (1 < (int)*(uint32 *)(lVar3 + 24)) {
          if (*(uint32 *)(lVar3 + 24) < 2) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar4,0);
          }
          lVar5 = *(int64 *)(lVar3 + 40);
        }
        if (lVar5 != null) {
          cVar1 = FUN_1816387f0(lVar5,"当前区域",0);
          if (cVar1) {
            uVar4 = FUN_180210060(0);
            cVar1 = Object.op_Equality(uVar4,0,0);
            if (!cVar1) {
              lVar3 = FUN_180210060(0);
              if (lVar3 == null) goto LAB_18052fbbe;
              if (*(int64 *)(lVar3 + 88) != 0) {
                uVar4 = new BattleMapTypeData(4);
                return uVar4;
              }
            }
            uVar4 = "战斗配置:攻城战_当前区域 需要在目标区域内触发,已退化为自动地图";
            if (((*(byte *)(DAT_181ea01b8 + 0x133) & 4) != 0) && (*(int *)(DAT_181ea01b8 + 224) == 0)) {
              il2cpp_runtime_class_init();
              uVar4 = "战斗配置:攻城战_当前区域 需要在目标区域内触发,已退化为自动地图";
            }
            goto LAB_18052fae6;
          }
          cVar1 = FUN_1816387f0(lVar5,"营地",0);
          if (cVar1) {
            if (2 < (int)*(uint32 *)(lVar3 + 24)) {
              if (*(uint32 *)(lVar3 + 24) < 3) {
                uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1801e02d0(uVar4,0);
              }
              uVar4 = *(uint64 *)(lVar3 + 48);
              uVar2 = BattleConfigExecutor.ParseCellInt(uVar4,0);
            }
            uVar4 = new BattleMapTypeData(3,uVar2);
            return uVar4;
          }
        }
        uVar4 = String.Concat("战斗配置:未知攻城战类型 ",lVar5,0);
        LAB_18052fae6:
        Debug.LogError(uVar4,0);
        return 0;
    }

    // Token : 0x6000C0E
    // RVA   : 0x52BEF0   Offset: 0x52ACF0   Length: 0x4FF
    private static void ApplyBattlePlotStr(string str)
    {
        bool cVar2;
        int iVar3;
        uint uVar4;
        long lVar5;
        long lVar6;
        long lVar7;
        ulong uVar8;
        ulong uVar9;
        uint uVar10;
        uint uVar11;
        cVar2 = FUN_180ad1200(str,0);
        if (cVar2) {
          return;
        }
        lVar5 = FUN_1801dfd90(DAT_181e81128,1);
        if (lVar5 != null) {
          if (*(int *)(lVar5 + 24) == 0) {
            uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar9,0);
          }
          *(uint16 *)(lVar5 + 32) = 59;
          if (str != null) {
            lVar5 = String.Split(str,lVar5,0);
            uVar10 = 0;
            if (lVar5 != null) {
        LAB_18052c043:
              do {
                if ((int)*(uint32 *)(lVar5 + 24) <= (int)uVar10) {
                  return;
                }
                if (*(uint32 *)(lVar5 + 24) <= uVar10) {
                  uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1801e02d0(uVar9,0);
                }
                lVar7 = *(int64 *)((int64)(int)uVar10 * 8 + lVar5 + 32);
                lVar6 = FUN_1801dfd90(DAT_181e81128,1);
                if (lVar6 == null) break;
                if (*(int *)(lVar6 + 24) == 0) {
                  uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1801e02d0(uVar9,0);
                }
                *(uint16 *)(lVar6 + 32) = **(uint16 **)(DAT_181e903a0 + 184);
                if ((lVar7 == null) || (lVar7 = String.Split(lVar7,lVar6,0)) == null) break;
                if (*(int *)(lVar7 + 24) < 3) {
                  uVar9 = "战斗剧情配置缺字段: ";
                  if (*(uint32 *)(lVar5 + 24) <= uVar10) {
                    uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1801e02d0(uVar9,0);
                  }
        LAB_18052c2e1:
                  uVar9 = String.Concat(uVar9);
                  bVar1 = *(byte *)(DAT_181ea01b8 + 0x133);
                }
                else {
                  if (*(int *)(lVar7 + 24) == 0) {
                    uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1801e02d0(uVar9,0);
                  }
                  lVar6 = *(int64 *)(lVar7 + 32);
                  if (lVar6 == null) {
        LAB_18052c2bd:
                    uVar9 = "未知战斗剧情触发器: ";
                    if (*(uint32 *)(lVar5 + 24) <= uVar10) {
                      uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1801e02d0(uVar9,0);
                    }
                    goto LAB_18052c2e1;
                  }
                  cVar2 = FUN_1816387f0(lVar6,"时间");
                  uVar11 = 0;
                  if (cVar2) {
        LAB_18052c1cc:
                    lVar6 = FUN_1802101c0(0);
                    if (lVar6 == null) break;
                    lVar6 = *(int64 *)(lVar6 + 128);
                    if (*(uint32 *)(lVar7 + 24) < 2) {
                      uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1801e02d0(uVar9,0);
                    }
                    uVar9 = *(uint64 *)(lVar7 + 40);
                    if (*(uint32 *)(lVar7 + 24) < 3) {
                      uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1801e02d0(uVar9,0);
                    }
                    uVar8 = *(uint64 *)(lVar7 + 48);
                    uVar4 = BattleConfigExecutor.ParseCellInt(uVar8,0);
                    uVar8 = new BattlePlotData(uVar11,uVar9,uVar4,0);
                    if (lVar6 == null) break;
                    FUN_18175de30(lVar6);
                    uVar10 = uVar10 + 1;
                    goto LAB_18052c043;
                  }
                  cVar2 = FUN_1816387f0(lVar6,"入场");
                  if (cVar2) {
                    uVar11 = 1;
                    goto LAB_18052c1cc;
                  }
                  cVar2 = FUN_1816387f0(lVar6,"行动");
                  if (cVar2) {
                    uVar11 = 2;
                    goto LAB_18052c1cc;
                  }
                  cVar2 = FUN_1816387f0(lVar6,"死亡");
                  if (cVar2) {
                    uVar11 = 3;
                    goto LAB_18052c1cc;
                  }
                  cVar2 = FUN_1816387f0(lVar6,"循环");
                  if (!cVar2) goto LAB_18052c2bd;
                  if (*(uint32 *)(lVar7 + 24) < 2) {
                    uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1801e02d0(uVar9,0);
                  }
                  if (*(int64 *)(lVar7 + 40) == 0) break;
                  iVar3 = String.IndexOf(*(int64 *)(lVar7 + 40),58);
                  uVar11 = 4;
                  if (iVar3 != -1) goto LAB_18052c1cc;
                  if (*(uint32 *)(lVar5 + 24) <= uVar10) {
                    uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1801e02d0(uVar9,0);
                  }
                  uVar9 = String.Concat("循环剧情应写 起始:间隔: ");
                  bVar1 = *(byte *)(DAT_181ea01b8 + 0x133);
                }
                if (((bVar1 & 4) != 0) && (*(int *)(DAT_181ea01b8 + 224) == 0)) {
                  il2cpp_runtime_class_init();
                }
                Debug.LogError(uVar9);
                uVar10 = uVar10 + 1;
              } while( true );
            }
          }
        }
    }

    // Token : 0x6000C0F
    // RVA   : 0x52C3F0   Offset: 0x52B1F0   Length: 0x13E4
    private static void ApplyBattleTrophy(BattleData data)
    {
        var pStatics_38e8 = *(int64*)(DAT_181e538e8 + 184);
        long lVar1;
        ulong uVar2;
        bool cVar3;
        uint uVar4;
        int iVar5;
        uint uVar6;
        int iVar7;
        uint uVar8;
        long lVar9;
        long lVar10;
        long lVar11;
        ulong uVar12;
        uint uVar13;
        uint uVar14;
        uint[] local_res8 = new uint[2];
        uint[] local_res18 = new uint[2];
        uint[] local_res20 = new uint[2];
        ulong in_stack_ffffffffffffff98;
        uint uVar15;
        uVar13 = 0;
        local_res8[0] = 0;
        local_res20[0] = 0;
        local_res18[0] = 0;
        if (data == null) {
        LAB_18052d7cf:
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        cVar3 = FUN_180ad1200(*(uint64 *)(data + 96),0);
        if (cVar3) {
          return;
        }
        lVar1 = PlotController.LaBaFestivelResultTalkText;
        if ((lVar1 == null) || (*(int64 *)(lVar1 + 0x1c0) == 0)) goto LAB_18052d7cf;
        *(uint32 *)(*(int64 *)(lVar1 + 0x1c0) + 24) = 0;
        if (*(int64 *)(lVar1 + 0x1c0) == 0) goto LAB_18052d7cf;
        ItemListData.ClearAllItem(*(int64 *)(lVar1 + 0x1c0),0);
        lVar1 = PlotController.LaBaFestivelResultTalkText;
        if (lVar1 == null) goto LAB_18052d7cf;
        lVar1 = *(int64 *)(lVar1 + 0x1c0);
        lVar10 = *(int64 *)(data + 96);
        lVar9 = FUN_1801dfd90(DAT_181e81128,1);
        if (lVar9 == null) goto LAB_18052d7cf;
        if (*(int *)(lVar9 + 24) == 0) {
          uVar12 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1801e02d0(uVar12,0);
        }
        *(uint16 *)(lVar9 + 32) = 59;
        if ((lVar10 == null) || (lVar10 = String.Split(lVar10,lVar9,0)) == null) goto LAB_18052d7cf;
        LAB_18052c710:
        if ((int)*(uint32 *)(lVar10 + 24) <= (int)uVar13) {
          return;
        }
        if (*(uint32 *)(lVar10 + 24) <= uVar13) {
          uVar12 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1801e02d0(uVar12,0);
        }
        cVar3 = FUN_180ad1200(lVar10[uVar13]);
        if (cVar3) goto LAB_18052d1b9;
        if (*(uint32 *)(lVar10 + 24) <= uVar13) {
          uVar12 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1801e02d0(uVar12,0);
        }
        lVar9 = lVar10[uVar13];
        lVar11 = FUN_1801dfd90(DAT_181e81128,1);
        if (lVar11 == null) goto LAB_18052d7cf;
        if (*(int *)(lVar11 + 24) == 0) {
          uVar12 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1801e02d0(uVar12,0);
        }
        *(uint16 *)(lVar11 + 32) = **(uint16 **)(DAT_181e903a0 + 184);
        if ((lVar9 == null) || (lVar9 = String.Split(lVar9,lVar11,0)) == null) goto LAB_18052d7cf;
        if (*(int *)(lVar9 + 24) == 0) {
          uVar12 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1801e02d0(uVar12,0);
        }
        lVar11 = *(int64 *)(lVar9 + 32);
        if (lVar11 == null) goto LAB_18052d5e6;
        uVar4 = PrivateImplementationDetails.ComputeStringHash(lVar11,0);
        if (uVar4 < 0x77b249ab) {
          if (uVar4 < 0x37b31ee0) {
            if (uVar4 == 0x13416f5e) {
              cVar3 = FUN_1816387f0(lVar11);
              if (cVar3) {
                if (*(int *)(lVar9 + 24) < 2) goto LAB_18052d1b9;
                lVar11 = new ItemData(3);
                if (*(uint32 *)(lVar9 + 24) < 2) {
                  uVar12 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1801e02d0(uVar12,0);
                }
                uVar12 = *(uint64 *)(lVar9 + 40);
                uVar6 = BattleConfigExecutor.ParseCellInt(uVar12,0);
                if (2 < (int)*(uint32 *)(lVar9 + 24)) {
                  if (*(uint32 *)(lVar9 + 24) < 3) {
                    uVar12 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1801e02d0(uVar12,0);
                  }
                  uVar12 = *(uint64 *)(lVar9 + 48);
                  BattleConfigExecutor.ParseCellInt(uVar12,0);
                }
                if (lVar11 != null) {
                  ItemData.SetBookData(lVar11,uVar6);
                  goto LAB_18052d401;
                }
                goto LAB_18052d7cf;
              }
            }
            else if ((uVar4 == 0x37b31edf) && (cVar3 = FUN_1816387f0(lVar11), cVar3)) {
              if ((int)*(uint32 *)(lVar9 + 24) < 3) goto LAB_18052d1b9;
              if (*(uint32 *)(lVar9 + 24) < 2) {
                uVar12 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1801e02d0(uVar12,0);
              }
              uVar12 = *(uint64 *)(lVar9 + 40);
              uVar2 = *(uint64 *)(pStatics_38e8 + 0x530);
              iVar7 = BattleConfigExecutor.ParseCellIndex(uVar12,uVar2,"珍宝种类",0);
              if (-1 < iVar7) {
                lVar11 = *(int64 *)(pStatics_38e8 + 0x530);
                if (lVar11 == null) goto LAB_18052d7cf;
                if (iVar7 < *(int *)(lVar11 + 24)) {
                  lVar11 = FUN_1802106e0(0);
                  if (*(uint32 *)(lVar9 + 24) < 3) {
                    uVar12 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1801e02d0(uVar12,0);
                  }
                  uVar12 = *(uint64 *)(lVar9 + 48);
                  uVar6 = BattleConfigExecutor.ParseCellInt(uVar12,0);
                  if ((int)*(uint32 *)(lVar9 + 24) < 4) {
                    uVar14 = 0;
                  }
                  else {
                    if (*(uint32 *)(lVar9 + 24) < 4) {
                      uVar12 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1801e02d0(uVar12,0);
                    }
                    uVar12 = *(uint64 *)(lVar9 + 56);
                    uVar14 = BattleConfigExecutor.ParseCellFloat(uVar12,0);
                  }
                  if (lVar11 != null) {
                    in_stack_ffffffffffffff98 = 0;
                    GameController.GenerateTreasure(lVar11,iVar7,uVar6,uVar14,0);
                    goto LAB_18052d19c;
                  }
                  goto LAB_18052d7cf;
                }
              }
              goto LAB_18052d1b9;
            }
          }
          else {
            if (uVar4 == 0x5de7c9a2) {
              cVar3 = FUN_1816387f0(lVar11);
              if (!cVar3) goto LAB_18052d5e6;
              if (2 < (int)*(uint32 *)(lVar9 + 24)) {
                if (*(uint32 *)(lVar9 + 24) < 2) {
                  uVar12 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1801e02d0(uVar12,0);
                }
                uVar12 = *(uint64 *)(lVar9 + 40);
                uVar2 = *(uint64 *)(pStatics_38e8 + 0x558);
                iVar7 = BattleConfigExecutor.ParseCellIndex(uVar12,uVar2,"材料种类",0);
                if (-1 < iVar7) {
                  lVar11 = *(int64 *)(pStatics_38e8 + 0x558);
                  if (lVar11 == null) goto LAB_18052d7cf;
                  if (iVar7 < *(int *)(lVar11 + 24)) {
                    lVar11 = FUN_1802106e0(0);
                    if (*(uint32 *)(lVar9 + 24) < 3) {
                      uVar12 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1801e02d0(uVar12,0);
                    }
                    uVar12 = *(uint64 *)(lVar9 + 48);
                    uVar6 = BattleConfigExecutor.ParseCellInt(uVar12,0);
                    if ((int)*(uint32 *)(lVar9 + 24) < 4) {
                      uVar14 = 0;
                    }
                    else {
                      if (*(uint32 *)(lVar9 + 24) < 4) {
                        uVar12 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1801e02d0(uVar12,0);
                      }
                      uVar12 = *(uint64 *)(lVar9 + 56);
                      uVar14 = BattleConfigExecutor.ParseCellFloat(uVar12,0);
                    }
                    if (lVar11 == null) goto LAB_18052d7cf;
                    in_stack_ffffffffffffff98 = 0;
                    GameController.GenerateMaterial(lVar11,iVar7,uVar6,uVar14,0);
        LAB_18052d19c:
                    if (lVar1 == null) goto LAB_18052d7cf;
                    ItemListData.GetItem(lVar1);
                  }
                }
              }
        LAB_18052d1b9:
              uVar13 = uVar13 + 1;
              goto LAB_18052c710;
            }
            if ((uVar4 == 0x77b249aa) && (cVar3 = FUN_1816387f0(lVar11), cVar3)) {
              if ((int)*(uint32 *)(lVar9 + 24) < 2) goto LAB_18052d1b9;
              if (*(uint32 *)(lVar9 + 24) < 2) {
                uVar12 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1801e02d0(uVar12,0);
              }
              uVar12 = *(uint64 *)(lVar9 + 40);
              local_res20[0] = BattleConfigExecutor.ParseCellInt(uVar12,0);
              lVar11 = FUN_180210740(0);
              if ((lVar11 != null) && (*(int64 *)(lVar11 + 0x128) != 0)) {
                cVar3 = FUN_1806da450(*(int64 *)(lVar11 + 0x128),local_res20[0]);
                if (!cVar3) {
                  Int32.ToString(local_res20,0);
                  uVar12 = "战斗配置:饮食ID不存在: ";
                  goto LAB_18052c9e7;
                }
                lVar11 = FUN_1802106e0(0);
                uVar6 = local_res20[0];
                if ((int)*(uint32 *)(lVar9 + 24) < 3) {
                  uVar14 = 0;
                }
                else {
                  if (*(uint32 *)(lVar9 + 24) < 3) {
                    uVar12 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1801e02d0(uVar12,0);
                  }
                  uVar12 = *(uint64 *)(lVar9 + 48);
                  uVar14 = BattleConfigExecutor.ParseCellFloat(uVar12,0);
                }
                if (lVar11 != null) {
                  GameController.GenerateFoodData(lVar11,uVar6,uVar14);
                  goto LAB_18052d401;
                }
              }
              goto LAB_18052d7cf;
            }
          }
        }
        else if (uVar4 < 0x9cf122b7) {
          if (uVar4 != 0x87f66d05) {
            if ((uVar4 != 0x9cf122b6) || (cVar3 = FUN_1816387f0(lVar11), !cVar3))
            goto LAB_18052d5e6;
            if ((int)*(uint32 *)(lVar9 + 24) < 2) goto LAB_18052d1b9;
            if (*(uint32 *)(lVar9 + 24) < 2) {
              uVar12 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar12,0);
            }
            uVar12 = *(uint64 *)(lVar9 + 40);
            local_res18[0] = BattleConfigExecutor.ParseCellInt(uVar12,0);
            lVar11 = FUN_180210740(0);
            if ((lVar11 == null) || (*(int64 *)(lVar11 + 0x130) == 0)) goto LAB_18052d7cf;
            cVar3 = FUN_1806da450(*(int64 *)(lVar11 + 0x130),local_res18[0]);
            if (cVar3) {
              lVar11 = FUN_1802106e0(0);
              uVar6 = local_res18[0];
              if ((int)*(uint32 *)(lVar9 + 24) < 3) {
                uVar14 = 0;
              }
              else {
                if (*(uint32 *)(lVar9 + 24) < 3) {
                  uVar12 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1801e02d0(uVar12,0);
                }
                uVar12 = *(uint64 *)(lVar9 + 48);
                uVar14 = BattleConfigExecutor.ParseCellFloat(uVar12,0);
              }
              if (lVar11 != null) {
                GameController.GenerateHorseData(lVar11,uVar6,uVar14);
                goto LAB_18052d401;
              }
              goto LAB_18052d7cf;
            }
            Int32.ToString(local_res18,0);
            uVar12 = "战斗配置:马匹ID不存在: ";
            goto LAB_18052c9e7;
          }
          cVar3 = FUN_1816387f0(lVar11);
          if (cVar3) {
            if (2 < (int)*(uint32 *)(lVar9 + 24)) {
              if (*(uint32 *)(lVar9 + 24) < 2) {
                uVar12 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1801e02d0(uVar12,0);
              }
              uVar12 = *(uint64 *)(lVar9 + 40);
              uVar2 = *(uint64 *)(pStatics_38e8 + 0x4e0);
              iVar7 = BattleConfigExecutor.ParseCellIndex(uVar12,uVar2,"装备部位",0);
              if (iVar7 < 0) goto LAB_18052d1b9;
              lVar11 = *(int64 *)(pStatics_38e8 + 0x4e0);
              if (lVar11 == null) goto LAB_18052d7cf;
              if (iVar7 < *(int *)(lVar11 + 24)) {
                if (*(uint32 *)(lVar9 + 24) < 3) {
                  uVar12 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1801e02d0(uVar12,0);
                }
                uVar12 = *(uint64 *)(lVar9 + 48);
                uVar6 = BattleConfigExecutor.ParseCellInt(uVar12);
                if ((int)*(uint32 *)(lVar9 + 24) < 4) {
                  uVar14 = 0;
                }
                else {
                  if (*(uint32 *)(lVar9 + 24) < 4) {
                    uVar12 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1801e02d0(uVar12,0);
                  }
                  uVar12 = *(uint64 *)(lVar9 + 56);
                  uVar14 = BattleConfigExecutor.ParseCellFloat(uVar12);
                }
                uVar15 = (uint32)((uint64)in_stack_ffffffffffffff98 >> 32);
                if (iVar7 == 0) {
                  lVar9 = FUN_1802106e0(0);
                  uVar8 = GlobalData.RandomRange(0,6,0);
                  if (lVar9 == null) goto LAB_18052d7cf;
                  in_stack_ffffffffffffff98 = CONCAT44(uVar15,uVar14);
                  GameController.GenerateWeapon
                            (lVar9,uVar6,0xffffffff,uVar8,in_stack_ffffffffffffff98,0,0);
                }
                else if (iVar7 == 1) {
                  lVar9 = FUN_1802106e0(0);
                  if (lVar9 == null) goto LAB_18052d7cf;
                  in_stack_ffffffffffffff98 = 0;
                  GameController.GenerateArmor(lVar9,uVar6,0xffffffff,uVar14,0,0);
                }
                else if (iVar7 == 2) {
                  lVar9 = FUN_1802106e0(0);
                  if (lVar9 == null) goto LAB_18052d7cf;
                  in_stack_ffffffffffffff98 = 0;
                  GameController.GenerateHelmet(lVar9,uVar6,0xffffffff,uVar14,0,0);
                }
                else {
                  if (iVar7 == 3) {
                    lVar9 = FUN_1802106e0(0);
                    if (lVar9 != null) {
                      in_stack_ffffffffffffff98 = 0;
                      GameController.GenerateShoes(lVar9,uVar6,0xffffffff,uVar14,0,0);
                      goto LAB_18052d401;
                    }
                    goto LAB_18052d7cf;
                  }
                  if (iVar7 != 4) goto LAB_18052d1b9;
                  lVar9 = FUN_1802106e0(0);
                  if (lVar9 == null) goto LAB_18052d7cf;
                  in_stack_ffffffffffffff98 = 0;
                  GameController.GenerateDecoration(lVar9,uVar6,0xffffffff,uVar14,0,0);
                }
                goto LAB_18052d401;
              }
            }
            goto LAB_18052d1b9;
          }
        }
        else {
          if (uVar4 == 0xa4ffc368) {
            cVar3 = FUN_1816387f0(lVar11);
            if (!cVar3) goto LAB_18052d5e6;
            if ((int)*(uint32 *)(lVar9 + 24) < 2) goto LAB_18052d1b9;
            if (lVar1 == null) goto LAB_18052d7cf;
            iVar7 = *(int *)(lVar1 + 24);
            if (*(uint32 *)(lVar9 + 24) < 2) {
              uVar12 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar12,0);
            }
            uVar12 = *(uint64 *)(lVar9 + 40);
            iVar5 = BattleConfigExecutor.ParseCellInt(uVar12);
            uVar13 = uVar13 + 1;
            *(int *)(lVar1 + 24) = iVar5 + iVar7;
            goto LAB_18052c710;
          }
          if (uVar4 == 0xe8095ac1) {
            cVar3 = FUN_1816387f0(lVar11);
            if (!cVar3) goto LAB_18052d5e6;
            if ((int)*(uint32 *)(lVar9 + 24) < 2) goto LAB_18052d1b9;
            if (*(uint32 *)(lVar9 + 24) < 2) {
              uVar12 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar12,0);
            }
            uVar12 = *(uint64 *)(lVar9 + 40);
            local_res8[0] = BattleConfigExecutor.ParseCellInt(uVar12,0);
            lVar11 = FUN_180210740(0);
            if ((lVar11 == null) || (*(int64 *)(lVar11 + 0x120) == 0)) goto LAB_18052d7cf;
            cVar3 = FUN_1806da450(*(int64 *)(lVar11 + 0x120),local_res8[0]);
            if (!cVar3) {
              Int32.ToString(local_res8,0);
              uVar12 = "战斗配置:丹药ID不存在: ";
              goto LAB_18052c9e7;
            }
            lVar11 = FUN_1802106e0(0);
            uVar6 = local_res8[0];
            if ((int)*(uint32 *)(lVar9 + 24) < 3) {
              uVar14 = 0;
            }
            else {
              if (*(uint32 *)(lVar9 + 24) < 3) {
                uVar12 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1801e02d0(uVar12,0);
              }
              uVar12 = *(uint64 *)(lVar9 + 48);
              uVar14 = BattleConfigExecutor.ParseCellFloat(uVar12,0);
            }
            if (lVar11 == null) goto LAB_18052d7cf;
            GameController.GenerateMedData(lVar11,uVar6,uVar14);
        LAB_18052d401:
            if (lVar1 == null) goto LAB_18052d7cf;
            ItemListData.GetItem(lVar1);
            uVar13 = uVar13 + 1;
            goto LAB_18052c710;
          }
          if ((uVar4 == 0xed72a3fd) && (cVar3 = FUN_1816387f0(lVar11), cVar3)) {
            if (*(int *)(lVar9 + 24) < 2) goto LAB_18052d1b9;
            lVar11 = FUN_1802106e0(0);
            if (*(uint32 *)(lVar9 + 24) < 2) {
              uVar12 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar12,0);
            }
            uVar12 = *(uint64 *)(lVar9 + 40);
            uVar6 = BattleConfigExecutor.ParseCellInt(uVar12,0);
            if ((int)*(uint32 *)(lVar9 + 24) < 3) {
              uVar14 = 0;
            }
            else {
              if (*(uint32 *)(lVar9 + 24) < 3) {
                uVar12 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1801e02d0(uVar12,0);
              }
              uVar12 = *(uint64 *)(lVar9 + 48);
              uVar14 = BattleConfigExecutor.ParseCellFloat(uVar12,0);
            }
            if (lVar11 != null) {
              GameController.GenerateHorseArmorData(lVar11,uVar6,uVar14);
              goto LAB_18052d401;
            }
            goto LAB_18052d7cf;
          }
        }
        LAB_18052d5e6:
        uVar12 = "战斗配置:未知战利品类型: ";
        if (*(uint32 *)(lVar10 + 24) <= uVar13) {
          uVar12 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1801e02d0(uVar12,0);
        }
        LAB_18052c9e7:
        uVar12 = String.Concat(uVar12);
        Debug.LogError(uVar12);
        uVar13 = uVar13 + 1;
        goto LAB_18052c710;
    }

    // Token : 0x6000C10
    // RVA   : 0x530050   Offset: 0x52EE50   Length: 0x65B
    private static void RunBattlePreAction(string str, string fightParam, List<HeroData> playerList, List<HeroData> enemyList)
    {
        void BattleConfigExecutor.RunBattlePreAction
                     (int64 str,uint64 fightParam,int64 playerList,int64 enemyList)
        {
        char cVar1;
        int iVar2;
        int64 lVar3;
        int64 lVar4;
        int64 lVar5;
        uint64 uVar6;
        int64 lVar7;
        int iVar8;
        uint32 uVar9;
        uint32 uVar10;
        cVar1 = FUN_180ad1200(str,0);
        if (cVar1) {
          return;
        }
        lVar3 = FUN_1801dfd90(DAT_181e81128,1);
        if (lVar3 != null) {
          if (*(int *)(lVar3 + 24) == 0) {
            uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar6,0);
          }
          *(uint16 *)(lVar3 + 32) = 59;
          if (str != null) {
            lVar3 = String.Split(str,lVar3,0);
            uVar9 = 0;
            if (lVar3 != null) {
        LAB_180530172:
              while( true ) {
                if ((int)*(uint32 *)(lVar3 + 24) <= (int)uVar9) {
                  return;
                }
                lVar7 = (int64)(int)uVar9;
                if (*(uint32 *)(lVar3 + 24) <= uVar9) {
                  uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1801e02d0(uVar6,0);
                }
                lVar4 = *(int64 *)(lVar3 + 32 + lVar7 * 8);
                if (lVar4 == null) throw; // [null/range check failed]
                cVar1 = String.StartsWith(lVar4,"自定义_",0);
                if (cVar1) break;
                if (*(uint32 *)(lVar3 + 24) <= uVar9) {
                  uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1801e02d0(uVar6,0);
                }
                lVar7 = *(int64 *)(lVar3 + 32 + lVar7 * 8);
                lVar4 = FUN_1801dfd90(DAT_181e81128,1);
                if (lVar4 == null) throw; // [null/range check failed]
                if (*(int *)(lVar4 + 24) == 0) {
                  uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1801e02d0(uVar6,0);
                }
                *(uint16 *)(lVar4 + 32) = **(uint16 **)(DAT_181e903a0 + 184);
                if ((lVar7 == null) || (lVar7 = String.Split(lVar7,lVar4)) == null) throw; // [null/range check failed]
                if (*(int *)(lVar7 + 24) == 0) {
                  uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1801e02d0(uVar6,0);
                }
                lVar4 = *(int64 *)(lVar7 + 32);
                if (lVar4 == null) {
        LAB_1805305ba:
                  uVar9 = uVar9 + 1;
                }
                else {
                  cVar1 = FUN_1816387f0(lVar4,"加Buff");
                  if (!cVar1) {
                    cVar1 = FUN_1816387f0(lVar4,"全员Buff");
                    if (cVar1) {
                      if (*(uint32 *)(lVar7 + 24) < 3) {
                        uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1801e02d0(uVar6,0);
                      }
                      uVar6 = *(uint64 *)(lVar7 + 48);
                      iVar2 = BattleConfigExecutor.GetSpeAddIDByName(uVar6,0);
                      if (-1 < iVar2) {
                        if (*(uint32 *)(lVar7 + 24) < 2) {
                          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1801e02d0(uVar6,0);
                        }
                        cVar1 = FUN_1816387f0(*(uint64 *)(lVar7 + 40),"我方");
                        lVar4 = enemyList;
                        if (cVar1) {
                          lVar4 = playerList;
                        }
                        iVar8 = 0;
                        while( true ) {
                          if (lVar4 == null) throw; // [null/range check failed]
                          if (*(int *)(lVar4 + 24) <= iVar8) break;
                          lVar5 = FUN_1800024b0(lVar4,iVar8);
                          if (*(uint32 *)(lVar7 + 24) < 4) {
                            uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                            FUN_1801e02d0(uVar6,0);
                          }
                          uVar6 = *(uint64 *)(lVar7 + 56);
                          uVar10 = BattleConfigExecutor.ParseCellFloat(uVar6,0);
                          if (lVar5 == null) throw; // [null/range check failed]
                          HeroData.AddBuff(lVar5,iVar2,uVar10);
                          iVar8 = iVar8 + 1;
                        }
                      }
                    }
                    goto LAB_1805305ba;
                  }
                  lVar4 = FUN_1802106e0(0);
                  if (lVar4 == null) throw; // [null/range check failed]
                  if (*(uint32 *)(lVar7 + 24) < 2) {
                    uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1801e02d0(uVar6,0);
                  }
                  if (*(int64 *)(lVar4 + 32) == 0) throw; // [null/range check failed]
                  lVar4 = WorldData.GetHero(*(int64 *)(lVar4 + 32),*(uint64 *)(lVar7 + 40));
                  if (*(uint32 *)(lVar7 + 24) < 3) {
                    uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1801e02d0(uVar6,0);
                  }
                  uVar6 = *(uint64 *)(lVar7 + 48);
                  iVar2 = BattleConfigExecutor.GetSpeAddIDByName(uVar6,0);
                  if ((lVar4 == null) || (iVar2 < 0)) goto LAB_1805305ba;
                  if (*(uint32 *)(lVar7 + 24) < 4) {
                    uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1801e02d0(uVar6,0);
                  }
                  uVar6 = *(uint64 *)(lVar7 + 56);
                  uVar10 = BattleConfigExecutor.ParseCellFloat(uVar6,0);
                  HeroData.AddBuff(lVar4,iVar2,uVar10);
                  uVar9 = uVar9 + 1;
                }
              }
              if (*(uint32 *)(lVar3 + 24) <= uVar9) {
                uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1801e02d0(uVar6,0);
              }
              if (("自定义_" == 0) || (lVar7 = *(int64 *)(lVar3 + 32 + lVar7 * 8)) == null)
              throw; // [null/range check failed]
              lVar7 = String.Substring(lVar7,*(uint32 *)("自定义_" + 16));
              if (lVar7 == null) throw; // [null/range check failed]
              iVar2 = String.IndexOf(lVar7,**(uint16 **)(DAT_181e903a0 + 184));
              if (iVar2 != -1) {
                lVar4 = String.Substring(lVar7,0,iVar2,0);
                lVar5 = String.Substring(lVar7,iVar2 + 1);
                lVar7 = lVar4;
                if (lVar5 != null) {
                  lVar7 = FUN_180210a70(0);
                  if (lVar7 == null) throw; // [null/range check failed]
                  Component.SendMessage(lVar7,lVar4);
                  uVar9 = uVar9 + 1;
                  goto LAB_180530172;
                }
              }
              lVar4 = FUN_180210a70(0);
              if (lVar4 == null) throw; // [null/range check failed]
              Component.SendMessage(lVar4,lVar7);
              uVar9 = uVar9 + 1;
              goto LAB_180530172;
            }
          }
        }
    }

    // Token : 0x6000C11
    // RVA   : 0x52EBD0   Offset: 0x52D9D0   Length: 0x1B2
    private static int GetSpeAddIDByName(string speName)
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        int iVar4;
        iVar4 = 0;
        while( true ) {
          lVar2 = *(int64 *)(*(int64 *)(DAT_181e528f8 + 184) + 32);
          if ((lVar2 == null) || (lVar2 = *(int64 *)(lVar2 + 144)) == null) break;
          if (*(int *)(lVar2 + 24) <= iVar4) {
            uVar3 = String.Concat("战斗配置:未找到特效 ",speName,0);
            Debug.LogError(uVar3,0);
            return -1;
          }
          lVar2 = FUN_180210740(0);
          if ((lVar2 == null) || (*(int64 *)(lVar2 + 144) == 0)) break;
          lVar2 = FUN_1800024b0(*(int64 *)(lVar2 + 144),iVar4);
          if (lVar2 == null) break;
          cVar1 = FUN_1816387f0(*(uint64 *)(lVar2 + 16),speName);
          if (cVar1) {
            return iVar4;
          }
          iVar4 = iVar4 + 1;
        }
    }

    // Token : 0x6000C12
    // RVA   : 0x52D7E0   Offset: 0x52C5E0   Length: 0xBC
    private static string BattleCellText(string str)
    {
        long lVar1;
        if (str != null) {
          lVar1 = String.Trim(str,0);
          if (lVar1 != null) {
            lVar1 = String.Replace(lVar1,"－","-",0);
            if (lVar1 != null) {
              lVar1 = String.Replace(lVar1,"—","-",0);
              if (lVar1 != null) {
                String.Replace(lVar1,"–","-",0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x6000C13
    // RVA   : 0x52FDA0   Offset: 0x52EBA0   Length: 0x5C
    public static int ParseCellInt(string str)
    {
        ulong uVar1;
        uVar1 = BattleConfigExecutor.BattleCellText(str,0);
        Int32.Parse(uVar1,0);
    }

    // Token : 0x6000C14
    // RVA   : 0x52FC10   Offset: 0x52EA10   Length: 0x5C
    public static float ParseCellFloat(string str)
    {
        ulong uVar1;
        uVar1 = BattleConfigExecutor.BattleCellText(str,0);
        Single.Parse(uVar1,0);
    }

    // Token : 0x6000C15
    // RVA   : 0x52FC70   Offset: 0x52EA70   Length: 0x124
    public static int ParseCellIndex(string str, List<string> nameList, string tag)
    {
        bool cVar1;
        ulong uVar2;
        ulong uVar3;
        uint[] local_res8 = new uint[2];
        local_res8[0] = 0;
        uVar2 = BattleConfigExecutor.BattleCellText(str,0);
        cVar1 = Int32.TryParse(uVar2,local_res8,0);
        if (!cVar1) {
          if ((str == null) || (uVar2 = String.Trim(str,0), nameList == null)) {
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          uVar3 = FUN_181662a20(nameList,uVar2,DAT_181e865f0);
          local_res8[0] = (uint32)uVar3;
          if (local_res8[0] != 0xffffffff) {
            return uVar3;
          }
          uVar2 = String.Format("战斗配置:{0}无效: {1}",tag,str,0);
          Debug.LogError(uVar2,0);
        }
        return (uint64)local_res8[0];
    }

    // Token : 0x6000C16
    // RVA   : 0x5306B0   Offset: 0x52F4B0   Length: 0x3B
    private static void /*cctor*/()
    {
        **(uint16 **)(DAT_181e903a0 + 184) = 95;
    }

}
