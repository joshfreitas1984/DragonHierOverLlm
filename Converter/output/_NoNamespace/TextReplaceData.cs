// ============================================================
// Type  : TextReplaceData
// Token : 0x20002F1
// ============================================================

public class TextReplaceData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40017A2
    public static string[][] ForceReplaceTexts;

    // Token: 0x40017A3
    public static string[][] ReplaceTexts;

    // Token: 0x40017A4
    public static string[][] MustReplaceTexts;

    // Token: 0x40017A5
    public static string[][] SpecialReplaceTexts;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001866
    // RVA   : 0x210B70   Offset: 0x20F370   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x6001867
    // RVA   : 0xAC1950   Offset: 0xAC0150   Length: 0x3A70
    private static void /*cctor*/()
    {
        var pStatics = *(int64*)(DAT_181d85f70 + 184);
        long lVar3;
        ulong uVar4;
        plVar1 = (int64 *)FUN_1800d60b0(DAT_181d7b320,2);
        plVar2 = (int64 *)FUN_1800d60b0(DAT_181d80cc0,2);
        if (plVar2 != (int64 *)0) {
          if (("恶名" != 0) &&
             (lVar3 = il2cpp_internal("恶名",*(uint64 *)(*plVar2 + 64))) == null) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar4,0);
          }
          lVar3 = "恶名";
          if ((int)plVar2[3] == 0) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar4,0);
          }
          plVar2[4] = "恶名";
          il2cpp_internal(plVar2 + 4,lVar3);
          if (("威慑" != 0) &&
             (lVar3 = il2cpp_internal("威慑",*(uint64 *)(*plVar2 + 64))) == null) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar4,0);
          }
          lVar3 = "威慑";
          if (*(uint32 *)(plVar2 + 3) < 2) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar4,0);
          }
          plVar2[5] = "威慑";
          il2cpp_internal(plVar2 + 5,lVar3);
          if (plVar1 != (int64 *)0) {
            lVar3 = il2cpp_internal(plVar2,*(uint64 *)(*plVar1 + 64));
            if (lVar3 == null) {
              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar4,0);
            }
            if ((int)plVar1[3] == 0) {
              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar4,0);
            }
            plVar1[4] = (int64)plVar2;
            il2cpp_internal(plVar1 + 4,plVar2);
            plVar2 = (int64 *)FUN_1800d60b0(DAT_181d80cc0,2);
            if (plVar2 != (int64 *)0) {
              if (("行凶" != 0) &&
                 (lVar3 = il2cpp_internal("行凶",*(uint64 *)(*plVar2 + 64))) == null)
              {
                uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar4,0);
              }
              lVar3 = "行凶";
              if ((int)plVar2[3] == 0) {
                uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar4,0);
              }
              plVar2[4] = "行凶";
              il2cpp_internal(plVar2 + 4,lVar3);
              if (("挑战" != 0) &&
                 (lVar3 = il2cpp_internal("挑战",*(uint64 *)(*plVar2 + 64))) == null)
              {
                uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar4,0);
              }
              lVar3 = "挑战";
              if (*(uint32 *)(plVar2 + 3) < 2) {
                uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar4,0);
              }
              plVar2[5] = "挑战";
              il2cpp_internal(plVar2 + 5,lVar3);
              lVar3 = il2cpp_internal(plVar2,*(uint64 *)(*plVar1 + 64));
              if (lVar3 == null) {
                uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar4,0);
              }
              if (*(uint32 *)(plVar1 + 3) < 2) {
                uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar4,0);
              }
              plVar1[5] = (int64)plVar2;
              il2cpp_internal(plVar1 + 5,plVar2);
              puVar5 = *(uint64 **)(DAT_181d85f70 + 184);
              *puVar5 = plVar1;
              il2cpp_internal(puVar5,plVar1);
              plVar1 = (int64 *)FUN_1800d60b0(DAT_181d7b320,39);
              plVar2 = (int64 *)FUN_1800d60b0(DAT_181d80cc0,2);
              if (plVar2 != (int64 *)0) {
                if (("继续坐牢" != 0) &&
                   (lVar3 = il2cpp_internal("继续坐牢",*(uint64 *)(*plVar2 + 64)), lVar3 == null
                   )) {
                  uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar4,0);
                }
                lVar3 = "继续坐牢";
                if ((int)plVar2[3] == 0) {
                  uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar4,0);
                }
                plVar2[4] = "继续坐牢";
                il2cpp_internal(plVar2 + 4,lVar3);
                if (("继续思过" != 0) &&
                   (lVar3 = il2cpp_internal("继续思过",*(uint64 *)(*plVar2 + 64)), lVar3 == null
                   )) {
                  uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar4,0);
                }
                lVar3 = "继续思过";
                if (*(uint32 *)(plVar2 + 3) < 2) {
                  uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar4,0);
                }
                plVar2[5] = "继续思过";
                il2cpp_internal(plVar2 + 5,lVar3);
                if (plVar1 != (int64 *)0) {
                  lVar3 = il2cpp_internal(plVar2,*(uint64 *)(*plVar1 + 64));
                  if (lVar3 == null) {
                    uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar4,0);
                  }
                  if ((int)plVar1[3] == 0) {
                    uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar4,0);
                  }
                  plVar1[4] = (int64)plVar2;
                  il2cpp_internal(plVar1 + 4,plVar2);
                  plVar2 = (int64 *)FUN_1800d60b0(DAT_181d80cc0,2);
                  if (plVar2 != (int64 *)0) {
                    if (("盗窃藏书" != 0) &&
                       (lVar3 = il2cpp_internal("盗窃藏书",*(uint64 *)(*plVar2 + 64)),
                       lVar3 == null)) {
                      uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar4,0);
                    }
                    lVar3 = "盗窃藏书";
                    if ((int)plVar2[3] == 0) {
                      uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar4,0);
                    }
                    plVar2[4] = "盗窃藏书";
                    il2cpp_internal(plVar2 + 4,lVar3);
                    if (("挑战" != 0) &&
                       (lVar3 = il2cpp_internal("挑战",*(uint64 *)(*plVar2 + 64)),
                       lVar3 == null)) {
                      uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar4,0);
                    }
                    lVar3 = "挑战";
                    if (*(uint32 *)(plVar2 + 3) < 2) {
                      uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar4,0);
                    }
                    plVar2[5] = "挑战";
                    il2cpp_internal(plVar2 + 5,lVar3);
                    lVar3 = il2cpp_internal(plVar2,*(uint64 *)(*plVar1 + 64));
                    if (lVar3 == null) {
                      uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar4,0);
                    }
                    if (*(uint32 *)(plVar1 + 3) < 2) {
                      uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar4,0);
                    }
                    plVar1[5] = (int64)plVar2;
                    il2cpp_internal(plVar1 + 5,plVar2);
                    plVar2 = (int64 *)FUN_1800d60b0(DAT_181d80cc0,2);
                    if (plVar2 != (int64 *)0) {
                      if (("偷窃藏经阁内藏书" != 0) &&
                         (lVar3 = il2cpp_internal("偷窃藏经阁内藏书",*(uint64 *)(*plVar2 + 64)),
                         lVar3 == null)) {
                        uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar4,0);
                      }
                      lVar3 = "偷窃藏经阁内藏书";
                      if ((int)plVar2[3] == 0) {
                        uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar4,0);
                      }
                      plVar2[4] = "偷窃藏经阁内藏书";
                      il2cpp_internal(plVar2 + 4,lVar3);
                      if (("挑战赢取藏书" != 0) &&
                         (lVar3 = il2cpp_internal("挑战赢取藏书",*(uint64 *)(*plVar2 + 64)),
                         lVar3 == null)) {
                        uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar4,0);
                      }
                      lVar3 = "挑战赢取藏书";
                      if (*(uint32 *)(plVar2 + 3) < 2) {
                        uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar4,0);
                      }
                      plVar2[5] = "挑战赢取藏书";
                      il2cpp_internal(plVar2 + 5,lVar3);
                      lVar3 = il2cpp_internal(plVar2,*(uint64 *)(*plVar1 + 64));
                      if (lVar3 == null) {
                        uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar4,0);
                      }
                      if (*(uint32 *)(plVar1 + 3) < 3) {
                        uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar4,0);
                      }
                      plVar1[6] = (int64)plVar2;
                      il2cpp_internal(plVar1 + 6,plVar2);
                      plVar2 = (int64 *)FUN_1800d60b0(DAT_181d80cc0,2);
                      if (plVar2 != (int64 *)0) {
                        if (("盗窃库存" != 0) &&
                           (lVar3 = il2cpp_internal("盗窃库存",*(uint64 *)(*plVar2 + 64)),
                           lVar3 == null)) {
                          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1800d65f0(uVar4,0);
                        }
                        lVar3 = "盗窃库存";
                        if ((int)plVar2[3] == 0) {
                          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1800d65f0(uVar4,0);
                        }
                        plVar2[4] = "盗窃库存";
                        il2cpp_internal(plVar2 + 4,lVar3);
                        if (("挑战" != 0) &&
                           (lVar3 = il2cpp_internal("挑战",*(uint64 *)(*plVar2 + 64)),
                           lVar3 == null)) {
                          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1800d65f0(uVar4,0);
                        }
                        lVar3 = "挑战";
                        if (*(uint32 *)(plVar2 + 3) < 2) {
                          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1800d65f0(uVar4,0);
                        }
                        plVar2[5] = "挑战";
                        il2cpp_internal(plVar2 + 5,lVar3);
                        lVar3 = il2cpp_internal(plVar2,*(uint64 *)(*plVar1 + 64));
                        if (lVar3 == null) {
                          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1800d65f0(uVar4,0);
                        }
                        if (*(uint32 *)(plVar1 + 3) < 4) {
                          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1800d65f0(uVar4,0);
                        }
                        plVar1[7] = (int64)plVar2;
                        il2cpp_internal(plVar1 + 7,plVar2);
                        plVar2 = (int64 *)FUN_1800d60b0(DAT_181d80cc0,2);
                        if (plVar2 != (int64 *)0) {
                          if (("偷窃门派仓库内物品" != 0) &&
                             (lVar3 = il2cpp_internal("偷窃门派仓库内物品",*(uint64 *)(*plVar2 + 64)),
                             lVar3 == null)) {
                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                            FUN_1800d65f0(uVar4,0);
                          }
                          lVar3 = "偷窃门派仓库内物品";
                          if ((int)plVar2[3] == 0) {
                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                            FUN_1800d65f0(uVar4,0);
                          }
                          plVar2[4] = "偷窃门派仓库内物品";
                          il2cpp_internal(plVar2 + 4,lVar3);
                          if (("挑战赢取库存" != 0) &&
                             (lVar3 = il2cpp_internal("挑战赢取库存",*(uint64 *)(*plVar2 + 64)),
                             lVar3 == null)) {
                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                            FUN_1800d65f0(uVar4,0);
                          }
                          lVar3 = "挑战赢取库存";
                          if (*(uint32 *)(plVar2 + 3) < 2) {
                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                            FUN_1800d65f0(uVar4,0);
                          }
                          plVar2[5] = "挑战赢取库存";
                          il2cpp_internal(plVar2 + 5,lVar3);
                          lVar3 = il2cpp_internal(plVar2,*(uint64 *)(*plVar1 + 64));
                          if (lVar3 == null) {
                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                            FUN_1800d65f0(uVar4,0);
                          }
                          if (*(uint32 *)(plVar1 + 3) < 5) {
                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                            FUN_1800d65f0(uVar4,0);
                          }
                          plVar1[8] = (int64)plVar2;
                          il2cpp_internal(plVar1 + 8,plVar2);
                          plVar2 = (int64 *)FUN_1800d60b0(DAT_181d80cc0,2);
                          if (plVar2 != (int64 *)0) {
                            if (("贿赂狱卒" != 0) &&
                               (lVar3 = il2cpp_internal("贿赂狱卒",*(uint64 *)(*plVar2 + 64))
                               , lVar3 == null)) {
                              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                              FUN_1800d65f0(uVar4,0);
                            }
                            lVar3 = "贿赂狱卒";
                            if ((int)plVar2[3] == 0) {
                              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                              FUN_1800d65f0(uVar4,0);
                            }
                            plVar2[4] = "贿赂狱卒";
                            il2cpp_internal(plVar2 + 4,lVar3);
                            if (("赔礼道歉" != 0) &&
                               (lVar3 = il2cpp_internal("赔礼道歉",*(uint64 *)(*plVar2 + 64))
                               , lVar3 == null)) {
                              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                              FUN_1800d65f0(uVar4,0);
                            }
                            lVar3 = "赔礼道歉";
                            if (*(uint32 *)(plVar2 + 3) < 2) {
                              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                              FUN_1800d65f0(uVar4,0);
                            }
                            plVar2[5] = "赔礼道歉";
                            il2cpp_internal(plVar2 + 5,lVar3);
                            lVar3 = il2cpp_internal(plVar2,*(uint64 *)(*plVar1 + 64));
                            if (lVar3 == null) {
                              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                              FUN_1800d65f0(uVar4,0);
                            }
                            if (*(uint32 *)(plVar1 + 3) < 6) {
                              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                              FUN_1800d65f0(uVar4,0);
                            }
                            plVar1[9] = (int64)plVar2;
                            il2cpp_internal(plVar1 + 9,plVar2);
                            plVar2 = (int64 *)FUN_1800d60b0(DAT_181d80cc0,2);
                            if (plVar2 != (int64 *)0) {
                              if (("拦路抢劫" != 0) &&
                                 (lVar3 = il2cpp_internal("拦路抢劫",
                                                              *(uint64 *)(*plVar2 + 64)), lVar3 == null
                                 )) {
                                uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar4,0);
                              }
                              lVar3 = "拦路抢劫";
                              if ((int)plVar2[3] == 0) {
                                uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar4,0);
                              }
                              plVar2[4] = "拦路抢劫";
                              il2cpp_internal(plVar2 + 4,lVar3);
                              if (("发起挑战" != 0) &&
                                 (lVar3 = il2cpp_internal("发起挑战",
                                                              *(uint64 *)(*plVar2 + 64)), lVar3 == null
                                 )) {
                                uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar4,0);
                              }
                              lVar3 = "发起挑战";
                              if (*(uint32 *)(plVar2 + 3) < 2) {
                                uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar4,0);
                              }
                              plVar2[5] = "发起挑战";
                              il2cpp_internal(plVar2 + 5,lVar3);
                              lVar3 = il2cpp_internal(plVar2,*(uint64 *)(*plVar1 + 64));
                              if (lVar3 == null) {
                                uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar4,0);
                              }
                              if (*(uint32 *)(plVar1 + 3) < 7) {
                                uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar4,0);
                              }
                              plVar1[10] = (int64)plVar2;
                              il2cpp_internal(plVar1 + 10,plVar2);
                              plVar2 = (int64 *)FUN_1800d60b0(DAT_181d80cc0,2);
                              if (plVar2 != (int64 *)0) {
                                if (("越狱" != 0) &&
                                   (lVar3 = il2cpp_internal("越狱",
                                                                *(uint64 *)(*plVar2 + 64)),
                                   lVar3 == null)) {
                                  uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                  FUN_1800d65f0(uVar4,0);
                                }
                                lVar3 = "越狱";
                                if ((int)plVar2[3] == 0) {
                                  uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                  FUN_1800d65f0(uVar4,0);
                                }
                                plVar2[4] = "越狱";
                                il2cpp_internal(plVar2 + 4,lVar3);
                                if (("逃跑" != 0) &&
                                   (lVar3 = il2cpp_internal("逃跑",
                                                                *(uint64 *)(*plVar2 + 64)),
                                   lVar3 == null)) {
                                  uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                  FUN_1800d65f0(uVar4,0);
                                }
                                lVar3 = "逃跑";
                                if (*(uint32 *)(plVar2 + 3) < 2) {
                                  uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                  FUN_1800d65f0(uVar4,0);
                                }
                                plVar2[5] = "逃跑";
                                il2cpp_internal(plVar2 + 5,lVar3);
                                lVar3 = il2cpp_internal(plVar2,*(uint64 *)(*plVar1 + 64));
                                if (lVar3 == null) {
                                  uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                  FUN_1800d65f0(uVar4,0);
                                }
                                if (*(uint32 *)(plVar1 + 3) < 8) {
                                  uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                  FUN_1800d65f0(uVar4,0);
                                }
                                plVar1[11] = (int64)plVar2;
                                il2cpp_internal(plVar1 + 11,plVar2);
                                plVar2 = (int64 *)FUN_1800d60b0(DAT_181d80cc0,2);
                                if (plVar2 != (int64 *)0) {
                                  if (("畅饮" != 0) &&
                                     (lVar3 = il2cpp_internal("畅饮",
                                                                  *(uint64 *)(*plVar2 + 64)),
                                     lVar3 == null)) {
                                    uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                    FUN_1800d65f0(uVar4,0);
                                  }
                                  lVar3 = "畅饮";
                                  if ((int)plVar2[3] == 0) {
                                    uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                    FUN_1800d65f0(uVar4,0);
                                  }
                                  plVar2[4] = "畅饮";
                                  il2cpp_internal(plVar2 + 4,lVar3);
                                  if (("尽兴" != 0) &&
                                     (lVar3 = il2cpp_internal("尽兴",
                                                                  *(uint64 *)(*plVar2 + 64)),
                                     lVar3 == null)) {
                                    uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                    FUN_1800d65f0(uVar4,0);
                                  }
                                  lVar3 = "尽兴";
                                  if (*(uint32 *)(plVar2 + 3) < 2) {
                                    uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                    FUN_1800d65f0(uVar4,0);
                                  }
                                  plVar2[5] = "尽兴";
                                  il2cpp_internal(plVar2 + 5,lVar3);
                                  lVar3 = il2cpp_internal(plVar2,*(uint64 *)(*plVar1 + 64));
                                  if (lVar3 == null) {
                                    uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                    FUN_1800d65f0(uVar4,0);
                                  }
                                  if (*(uint32 *)(plVar1 + 3) < 9) {
                                    uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                    FUN_1800d65f0(uVar4,0);
                                  }
                                  plVar1[12] = (int64)plVar2;
                                  il2cpp_internal(plVar1 + 12,plVar2);
                                  plVar2 = (int64 *)FUN_1800d60b0(DAT_181d80cc0,2);
                                  if (plVar2 != (int64 *)0) {
                                    if (("小酌" != 0) &&
                                       (lVar3 = il2cpp_internal("小酌",
                                                                    *(uint64 *)(*plVar2 + 64)),
                                       lVar3 == null)) {
                                      uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                      FUN_1800d65f0(uVar4,0);
                                    }
                                    lVar3 = "小酌";
                                    if ((int)plVar2[3] == 0) {
                                      uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                      FUN_1800d65f0(uVar4,0);
                                    }
                                    plVar2[4] = "小酌";
                                    il2cpp_internal(plVar2 + 4,lVar3);
                                    if (("品茗" != 0) &&
                                       (lVar3 = il2cpp_internal("品茗",
                                                                    *(uint64 *)(*plVar2 + 64)),
                                       lVar3 == null)) {
                                      uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                      FUN_1800d65f0(uVar4,0);
                                    }
                                    lVar3 = "品茗";
                                    if (*(uint32 *)(plVar2 + 3) < 2) {
                                      uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                      FUN_1800d65f0(uVar4,0);
                                    }
                                    plVar2[5] = "品茗";
                                    il2cpp_internal(plVar2 + 5,lVar3);
                                    lVar3 = il2cpp_internal(plVar2,*(uint64 *)(*plVar1 + 64));
                                    if (lVar3 == null) {
                                      uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                      FUN_1800d65f0(uVar4,0);
                                    }
                                    if (*(uint32 *)(plVar1 + 3) < 10) {
                                      uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                      FUN_1800d65f0(uVar4,0);
                                    }
                                    plVar1[13] = (int64)plVar2;
                                    il2cpp_internal(plVar1 + 13,plVar2);
                                    plVar2 = (int64 *)FUN_1800d60b0(DAT_181d80cc0,2);
                                    if (plVar2 != (int64 *)0) {
                                      if (("把酒言欢" != 0) &&
                                         (lVar3 = il2cpp_internal("把酒言欢",
                                                                      *(uint64 *)(*plVar2 + 64)),
                                         lVar3 == null)) {
                                        uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                        FUN_1800d65f0(uVar4,0);
                                      }
                                      lVar3 = "把酒言欢";
                                      if ((int)plVar2[3] == 0) {
                                        uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                        FUN_1800d65f0(uVar4,0);
                                      }
                                      plVar2[4] = "把酒言欢";
                                      il2cpp_internal(plVar2 + 4,lVar3);
                                      if (("围炉煮茶" != 0) &&
                                         (lVar3 = il2cpp_internal("围炉煮茶",
                                                                      *(uint64 *)(*plVar2 + 64)),
                                         lVar3 == null)) {
                                        uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                        FUN_1800d65f0(uVar4,0);
                                      }
                                      lVar3 = "围炉煮茶";
                                      if (*(uint32 *)(plVar2 + 3) < 2) {
                                        uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                        FUN_1800d65f0(uVar4,0);
                                      }
                                      plVar2[5] = "围炉煮茶";
                                      il2cpp_internal(plVar2 + 5,lVar3);
                                      lVar3 = il2cpp_internal(plVar2,*(uint64 *)(*plVar1 + 64));
                                      if (lVar3 == null) {
                                        uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                        FUN_1800d65f0(uVar4,0);
                                      }
                                      if (*(uint32 *)(plVar1 + 3) < 11) {
                                        uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                        FUN_1800d65f0(uVar4,0);
                                      }
                                      plVar1[14] = (int64)plVar2;
                                      il2cpp_internal(plVar1 + 14,plVar2);
                                      plVar2 = (int64 *)FUN_1800d60b0(DAT_181d80cc0,2);
                                      if (plVar2 != (int64 *)0) {
                                        if (("美酒" != 0) &&
                                           (lVar3 = il2cpp_internal("美酒",
                                                                        *(uint64 *)(*plVar2 + 64)),
                                           lVar3 == null)) {
                                          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                          FUN_1800d65f0(uVar4,0);
                                        }
                                        lVar3 = "美酒";
                                        if ((int)plVar2[3] == 0) {
                                          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                          FUN_1800d65f0(uVar4,0);
                                        }
                                        plVar2[4] = "美酒";
                                        il2cpp_internal(plVar2 + 4,lVar3);
                                        if (("茶饮" != 0) &&
                                           (lVar3 = il2cpp_internal("茶饮",
                                                                        *(uint64 *)(*plVar2 + 64)),
                                           lVar3 == null)) {
                                          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                          FUN_1800d65f0(uVar4,0);
                                        }
                                        lVar3 = "茶饮";
                                        if (*(uint32 *)(plVar2 + 3) < 2) {
                                          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                          FUN_1800d65f0(uVar4,0);
                                        }
                                        plVar2[5] = "茶饮";
                                        il2cpp_internal(plVar2 + 5,lVar3);
                                        lVar3 = il2cpp_internal(plVar2,*(uint64 *)(*plVar1 + 64)
                                                                   );
                                        if (lVar3 == null) {
                                          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                          FUN_1800d65f0(uVar4,0);
                                        }
                                        if (*(uint32 *)(plVar1 + 3) < 12) {
                                          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                          FUN_1800d65f0(uVar4,0);
                                        }
                                        plVar1[15] = (int64)plVar2;
                                        il2cpp_internal(plVar1 + 15,plVar2);
                                        plVar2 = (int64 *)FUN_1800d60b0(DAT_181d80cc0,2);
                                        if (plVar2 != (int64 *)0) {
                                          if (("酒泉" != 0) &&
                                             (lVar3 = il2cpp_internal("酒泉",
                                                                          *(uint64 *)(*plVar2 + 64))
                                             , lVar3 == null)) {
                                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                            FUN_1800d65f0(uVar4,0);
                                          }
                                          lVar3 = "酒泉";
                                          if ((int)plVar2[3] == 0) {
                                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                            FUN_1800d65f0(uVar4,0);
                                          }
                                          plVar2[4] = "酒泉";
                                          il2cpp_internal(plVar2 + 4,lVar3);
                                          if (("甘泉" != 0) &&
                                             (lVar3 = il2cpp_internal("甘泉",
                                                                          *(uint64 *)(*plVar2 + 64))
                                             , lVar3 == null)) {
                                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                            FUN_1800d65f0(uVar4,0);
                                          }
                                          lVar3 = "甘泉";
                                          if (*(uint32 *)(plVar2 + 3) < 2) {
                                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                            FUN_1800d65f0(uVar4,0);
                                          }
                                          plVar2[5] = "甘泉";
                                          il2cpp_internal(plVar2 + 5,lVar3);
                                          lVar3 = il2cpp_internal(plVar2,*(uint64 *)
                                                                              (*plVar1 + 64));
                                          if (lVar3 == null) {
                                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                            FUN_1800d65f0(uVar4,0);
                                          }
                                          if (*(uint32 *)(plVar1 + 3) < 13) {
                                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                            FUN_1800d65f0(uVar4,0);
                                          }
                                          plVar1[16] = (int64)plVar2;
                                          il2cpp_internal(plVar1 + 16,plVar2);
                                          plVar2 = (int64 *)FUN_1800d60b0(DAT_181d80cc0,2);
                                          if (plVar2 != (int64 *)0) {
                                            if (("拼酒" != 0) &&
                                               (lVar3 = il2cpp_internal("拼酒",
                                                                            *(uint64 *)
                                                                             (*plVar2 + 64)), lVar3 == null
                                               )) {
                                              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                              FUN_1800d65f0(uVar4,0);
                                            }
                                            lVar3 = "拼酒";
                                            if ((int)plVar2[3] == 0) {
                                              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                              FUN_1800d65f0(uVar4,0);
                                            }
                                            plVar2[4] = "拼酒";
                                            il2cpp_internal(plVar2 + 4,lVar3);
                                            if (("斗茶" != 0) &&
                                               (lVar3 = il2cpp_internal("斗茶",
                                                                            *(uint64 *)
                                                                             (*plVar2 + 64)), lVar3 == null
                                               )) {
                                              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                              FUN_1800d65f0(uVar4,0);
                                            }
                                            lVar3 = "斗茶";
                                            if (*(uint32 *)(plVar2 + 3) < 2) {
                                              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                              FUN_1800d65f0(uVar4,0);
                                            }
                                            plVar2[5] = "斗茶";
                                            il2cpp_internal(plVar2 + 5,lVar3);
                                            lVar3 = il2cpp_internal(plVar2,*(uint64 *)
                                                                                (*plVar1 + 64));
                                            if (lVar3 == null) {
                                              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                              FUN_1800d65f0(uVar4,0);
                                            }
                                            if (*(uint32 *)(plVar1 + 3) < 14) {
                                              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                              FUN_1800d65f0(uVar4,0);
                                            }
                                            plVar1[17] = (int64)plVar2;
                                            il2cpp_internal(plVar1 + 17,plVar2);
                                            plVar2 = (int64 *)FUN_1800d60b0(DAT_181d80cc0,2);
                                            if (plVar2 != (int64 *)0) {
                                              if (("薄酒" != 0) &&
                                                 (lVar3 = il2cpp_internal("薄酒",
                                                                              *(uint64 *)
                                                                               (*plVar2 + 64)),
                                                 lVar3 == null)) {
                                                uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                FUN_1800d65f0(uVar4,0);
                                              }
                                              lVar3 = "薄酒";
                                              if ((int)plVar2[3] == 0) {
                                                uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                FUN_1800d65f0(uVar4,0);
                                              }
                                              plVar2[4] = "薄酒";
                                              il2cpp_internal(plVar2 + 4,lVar3);
                                              if (("淡茶" != 0) &&
                                                 (lVar3 = il2cpp_internal("淡茶",
                                                                              *(uint64 *)
                                                                               (*plVar2 + 64)),
                                                 lVar3 == null)) {
                                                uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                FUN_1800d65f0(uVar4,0);
                                              }
                                              lVar3 = "淡茶";
                                              if (*(uint32 *)(plVar2 + 3) < 2) {
                                                uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                FUN_1800d65f0(uVar4,0);
                                              }
                                              plVar2[5] = "淡茶";
                                              il2cpp_internal(plVar2 + 5,lVar3);
                                              lVar3 = il2cpp_internal(plVar2,*(uint64 *)
                                                                                  (*plVar1 + 64));
                                              if (lVar3 == null) {
                                                uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                FUN_1800d65f0(uVar4,0);
                                              }
                                              if (*(uint32 *)(plVar1 + 3) < 15) {
                                                uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                FUN_1800d65f0(uVar4,0);
                                              }
                                              plVar1[18] = (int64)plVar2;
                                              il2cpp_internal(plVar1 + 18,plVar2);
                                              plVar2 = (int64 *)FUN_1800d60b0(DAT_181d80cc0,2);
                                              if (plVar2 != (int64 *)0) {
                                                if (("痛饮" != 0) &&
                                                   (lVar3 = il2cpp_internal("痛饮",
                                                                                *(uint64 *)
                                                                                 (*plVar2 + 64)),
                                                   lVar3 == null)) {
                                                  uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                  FUN_1800d65f0(uVar4,0);
                                                }
                                                lVar3 = "痛饮";
                                                if ((int)plVar2[3] == 0) {
                                                  uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                  FUN_1800d65f0(uVar4,0);
                                                }
                                                plVar2[4] = "痛饮";
                                                il2cpp_internal(plVar2 + 4,lVar3);
                                                if (("饮茶" != 0) &&
                                                   (lVar3 = il2cpp_internal("饮茶",
                                                                                *(uint64 *)
                                                                                 (*plVar2 + 64)),
                                                   lVar3 == null)) {
                                                  uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                  FUN_1800d65f0(uVar4,0);
                                                }
                                                lVar3 = "饮茶";
                                                if (*(uint32 *)(plVar2 + 3) < 2) {
                                                  uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                  FUN_1800d65f0(uVar4,0);
                                                }
                                                plVar2[5] = "饮茶";
                                                il2cpp_internal(plVar2 + 5,lVar3);
                                                lVar3 = il2cpp_internal(plVar2,*(uint64 *)
                                                                                    (*plVar1 + 64));
                                                if (lVar3 == null) {
                                                  uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                  FUN_1800d65f0(uVar4,0);
                                                }
                                                if (*(uint32 *)(plVar1 + 3) < 16) {
                                                  uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                  FUN_1800d65f0(uVar4,0);
                                                }
                                                plVar1[19] = (int64)plVar2;
                                                il2cpp_internal(plVar1 + 19,plVar2);
                                                plVar2 = (int64 *)FUN_1800d60b0(DAT_181d80cc0,2);
                                                if (plVar2 != (int64 *)0) {
                                                  if (("共饮" != 0) &&
                                                     (lVar3 = il2cpp_internal("共饮",
                                                                                  *(uint64 *)
                                                                                   (*plVar2 + 64)),
                                                     lVar3 == null)) {
                                                    uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                    FUN_1800d65f0(uVar4,0);
                                                  }
                                                  lVar3 = "共饮";
                                                  if ((int)plVar2[3] == 0) {
                                                    uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                    FUN_1800d65f0(uVar4,0);
                                                  }
                                                  plVar2[4] = "共饮";
                                                  il2cpp_internal(plVar2 + 4,lVar3);
                                                  if (("饮茶" != 0) &&
                                                     (lVar3 = il2cpp_internal("饮茶",
                                                                                  *(uint64 *)
                                                                                   (*plVar2 + 64)),
                                                     lVar3 == null)) {
                                                    uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                    FUN_1800d65f0(uVar4,0);
                                                  }
                                                  lVar3 = "饮茶";
                                                  if (*(uint32 *)(plVar2 + 3) < 2) {
                                                    uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                    FUN_1800d65f0(uVar4,0);
                                                  }
                                                  plVar2[5] = "饮茶";
                                                  il2cpp_internal(plVar2 + 5,lVar3);
                                                  lVar3 = il2cpp_internal(plVar2,*(uint64 *)
                                                                                      (*plVar1 + 64));
                                                  if (lVar3 == null) {
                                                    uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                    FUN_1800d65f0(uVar4,0);
                                                  }
                                                  if (*(uint32 *)(plVar1 + 3) < 17) {
                                                    uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                    FUN_1800d65f0(uVar4,0);
                                                  }
                                                  plVar1[20] = (int64)plVar2;
                                                  il2cpp_internal(plVar1 + 20,plVar2);
                                                  plVar2 = (int64 *)FUN_1800d60b0(DAT_181d80cc0,2);
                                                  if (plVar2 != (int64 *)0) {
                                                    if (("浊酒" != 0) &&
                                                       (lVar3 = il2cpp_internal("浊酒",
                                                                                    *(uint64 *)
                                                                                     (*plVar2 + 64)),
                                                       lVar3 == null)) {
                                                      uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                      FUN_1800d65f0(uVar4,0);
                                                    }
                                                    lVar3 = "浊酒";
                                                    if ((int)plVar2[3] == 0) {
                                                      uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                      FUN_1800d65f0(uVar4,0);
                                                    }
                                                    plVar2[4] = "浊酒";
                                                    il2cpp_internal(plVar2 + 4,lVar3);
                                                    if (("淡茶" != 0) &&
                                                       (lVar3 = il2cpp_internal("淡茶",
                                                                                    *(uint64 *)
                                                                                     (*plVar2 + 64)),
                                                       lVar3 == null)) {
                                                      uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                      FUN_1800d65f0(uVar4,0);
                                                    }
                                                    lVar3 = "淡茶";
                                                    if (*(uint32 *)(plVar2 + 3) < 2) {
                                                      uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                      FUN_1800d65f0(uVar4,0);
                                                    }
                                                    plVar2[5] = "淡茶";
                                                    il2cpp_internal(plVar2 + 5,lVar3);
                                                    lVar3 = il2cpp_internal(plVar2,*(uint64 *)
                                                                                        (*plVar1 + 64));
                                                    if (lVar3 == null) {
                                                      uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                      FUN_1800d65f0(uVar4,0);
                                                    }
                                                    if (*(uint32 *)(plVar1 + 3) < 18) {
                                                      uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                      FUN_1800d65f0(uVar4,0);
                                                    }
                                                    plVar1[21] = (int64)plVar2;
                                                    il2cpp_internal(plVar1 + 21,plVar2);
                                                    plVar2 = (int64 *)FUN_1800d60b0(DAT_181d80cc0,2);
                                                    if (plVar2 != (int64 *)0) {
                                                      if (("勒索财物" != 0) &&
                                                         (lVar3 = il2cpp_internal("勒索财物",
                                                                                      *(uint64 *)
                                                                                       (*plVar2 + 64)),
                                                         lVar3 == null)) {
                                                        uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                        FUN_1800d65f0(uVar4,0);
                                                      }
                                                      lVar3 = "勒索财物";
                                                      if ((int)plVar2[3] == 0) {
                                                        uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                        FUN_1800d65f0(uVar4,0);
                                                      }
                                                      plVar2[4] = "勒索财物";
                                                      il2cpp_internal(plVar2 + 4,lVar3);
                                                      if (("接受赔偿" != 0) &&
                                                         (lVar3 = il2cpp_internal("接受赔偿",
                                                                                      *(uint64 *)
                                                                                       (*plVar2 + 64)),
                                                         lVar3 == null)) {
                                                        uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                        FUN_1800d65f0(uVar4,0);
                                                      }
                                                      lVar3 = "接受赔偿";
                                                      if (*(uint32 *)(plVar2 + 3) < 2) {
                                                        uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                        FUN_1800d65f0(uVar4,0);
                                                      }
                                                      plVar2[5] = "接受赔偿";
                                                      il2cpp_internal(plVar2 + 5,lVar3);
                                                      lVar3 = il2cpp_internal(plVar2,*(uint64 *)
                                                                                          (*plVar1 + 64)
                                                                                 );
                                                      if (lVar3 == null) {
                                                        uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                        FUN_1800d65f0(uVar4,0);
                                                      }
                                                      if (*(uint32 *)(plVar1 + 3) < 19) {
                                                        uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                        FUN_1800d65f0(uVar4,0);
                                                      }
                                                      plVar1[22] = (int64)plVar2;
                                                      il2cpp_internal(plVar1 + 22,plVar2);
                                                      plVar2 = (int64 *)FUN_1800d60b0(DAT_181d80cc0,2);
                                                      if (plVar2 != (int64 *)0) {
                                                        if (("勒索" != 0) &&
                                                           (lVar3 = il2cpp_internal("勒索",
                                                                                        *(uint64 *)
                                                                                         (*plVar2 + 64))
                                                           , lVar3 == null)) {
                                                          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                          FUN_1800d65f0(uVar4,0);
                                                        }
                                                        lVar3 = "勒索";
                                                        if ((int)plVar2[3] == 0) {
                                                          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                          FUN_1800d65f0(uVar4,0);
                                                        }
                                                        plVar2[4] = "勒索";
                                                        il2cpp_internal(plVar2 + 4,lVar3);
                                                        if (("索取" != 0) &&
                                                           (lVar3 = il2cpp_internal("索取",
                                                                                        *(uint64 *)
                                                                                         (*plVar2 + 64))
                                                           , lVar3 == null)) {
                                                          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                          FUN_1800d65f0(uVar4,0);
                                                        }
                                                        lVar3 = "索取";
                                                        if (*(uint32 *)(plVar2 + 3) < 2) {
                                                          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                          FUN_1800d65f0(uVar4,0);
                                                        }
                                                        plVar2[5] = "索取";
                                                        il2cpp_internal(plVar2 + 5,lVar3);
                                                        lVar3 = il2cpp_internal(plVar2,*(uint64 *)
                                                                                            (*plVar1 +
                                                                                            64));
                                                        if (lVar3 == null) {
                                                          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                          FUN_1800d65f0(uVar4,0);
                                                        }
                                                        if (*(uint32 *)(plVar1 + 3) < 20) {
                                                          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                          FUN_1800d65f0(uVar4,0);
                                                        }
                                                        plVar1[23] = (int64)plVar2;
                                                        il2cpp_internal(plVar1 + 23,plVar2);
                                                        plVar2 = (int64 *)
                                                                 FUN_1800d60b0(DAT_181d80cc0,2);
                                                        if (plVar2 != (int64 *)0) {
                                                          if (("不醉不归" != 0) &&
                                                             (lVar3 = il2cpp_internal("不醉不归",
                                                                                          *(uint64 *)
                                                                                           (*plVar2 + 64
                                                                                           )), lVar3 == null)
                                                             ) {
                                                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                            FUN_1800d65f0(uVar4,0);
                                                          }
                                                          lVar3 = "不醉不归";
                                                          if ((int)plVar2[3] == 0) {
                                                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                            FUN_1800d65f0(uVar4,0);
                                                          }
                                                          plVar2[4] = "不醉不归";
                                                          il2cpp_internal(plVar2 + 4,lVar3);
                                                          if (("尽兴而归" != 0) &&
                                                             (lVar3 = il2cpp_internal("尽兴而归",
                                                                                          *(uint64 *)
                                                                                           (*plVar2 + 64
                                                                                           )), lVar3 == null)
                                                             ) {
                                                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                            FUN_1800d65f0(uVar4,0);
                                                          }
                                                          lVar3 = "尽兴而归";
                                                          if (*(uint32 *)(plVar2 + 3) < 2) {
                                                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                            FUN_1800d65f0(uVar4,0);
                                                          }
                                                          plVar2[5] = "尽兴而归";
                                                          il2cpp_internal(plVar2 + 5,lVar3);
                                                          lVar3 = il2cpp_internal(plVar2,*(uint64
                                                                                               *)(*plVar1 
                                                        + 64));
                                                        if (lVar3 == null) {
                                                          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                          FUN_1800d65f0(uVar4,0);
                                                        }
                                                        if (*(uint32 *)(plVar1 + 3) < 21) {
                                                          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                          FUN_1800d65f0(uVar4,0);
                                                        }
                                                        plVar1[24] = (int64)plVar2;
                                                        il2cpp_internal(plVar1 + 24,plVar2);
                                                        plVar2 = (int64 *)
                                                                 FUN_1800d60b0(DAT_181d80cc0,2);
                                                        if (plVar2 != (int64 *)0) {
                                                          if (("对饮" != 0) &&
                                                             (lVar3 = il2cpp_internal("对饮",
                                                                                          *(uint64 *)
                                                                                           (*plVar2 + 64
                                                                                           )), lVar3 == null)
                                                             ) {
                                                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                            FUN_1800d65f0(uVar4,0);
                                                          }
                                                          lVar3 = "对饮";
                                                          if ((int)plVar2[3] == 0) {
                                                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                            FUN_1800d65f0(uVar4,0);
                                                          }
                                                          plVar2[4] = "对饮";
                                                          il2cpp_internal(plVar2 + 4,lVar3);
                                                          if (("饮茶" != 0) &&
                                                             (lVar3 = il2cpp_internal("饮茶",
                                                                                          *(uint64 *)
                                                                                           (*plVar2 + 64
                                                                                           )), lVar3 == null)
                                                             ) {
                                                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                            FUN_1800d65f0(uVar4,0);
                                                          }
                                                          lVar3 = "饮茶";
                                                          if (*(uint32 *)(plVar2 + 3) < 2) {
                                                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                            FUN_1800d65f0(uVar4,0);
                                                          }
                                                          plVar2[5] = "饮茶";
                                                          il2cpp_internal(plVar2 + 5,lVar3);
                                                          lVar3 = il2cpp_internal(plVar2,*(uint64
                                                                                               *)(*plVar1 
                                                        + 64));
                                                        if (lVar3 == null) {
                                                          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                          FUN_1800d65f0(uVar4,0);
                                                        }
                                                        if (*(uint32 *)(plVar1 + 3) < 22) {
                                                          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                          FUN_1800d65f0(uVar4,0);
                                                        }
                                                        plVar1[25] = (int64)plVar2;
                                                        il2cpp_internal(plVar1 + 25,plVar2);
                                                        plVar2 = (int64 *)
                                                                 FUN_1800d60b0(DAT_181d80cc0,2);
                                                        if (plVar2 != (int64 *)0) {
                                                          if (("行凶作恶" != 0) &&
                                                             (lVar3 = il2cpp_internal("行凶作恶",
                                                                                          *(uint64 *)
                                                                                           (*plVar2 + 64
                                                                                           )), lVar3 == null)
                                                             ) {
                                                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                            FUN_1800d65f0(uVar4,0);
                                                          }
                                                          lVar3 = "行凶作恶";
                                                          if ((int)plVar2[3] == 0) {
                                                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                            FUN_1800d65f0(uVar4,0);
                                                          }
                                                          plVar2[4] = "行凶作恶";
                                                          il2cpp_internal(plVar2 + 4,lVar3);
                                                          if (("挑战他人" != 0) &&
                                                             (lVar3 = il2cpp_internal("挑战他人",
                                                                                          *(uint64 *)
                                                                                           (*plVar2 + 64
                                                                                           )), lVar3 == null)
                                                             ) {
                                                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                            FUN_1800d65f0(uVar4,0);
                                                          }
                                                          lVar3 = "挑战他人";
                                                          if (*(uint32 *)(plVar2 + 3) < 2) {
                                                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                            FUN_1800d65f0(uVar4,0);
                                                          }
                                                          plVar2[5] = "挑战他人";
                                                          il2cpp_internal(plVar2 + 5,lVar3);
                                                          lVar3 = il2cpp_internal(plVar2,*(uint64
                                                                                               *)(*plVar1 
                                                        + 64));
                                                        if (lVar3 == null) {
                                                          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                          FUN_1800d65f0(uVar4,0);
                                                        }
                                                        if (*(uint32 *)(plVar1 + 3) < 23) {
                                                          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                          FUN_1800d65f0(uVar4,0);
                                                        }
                                                        plVar1[26] = (int64)plVar2;
                                                        il2cpp_internal(plVar1 + 26,plVar2);
                                                        plVar2 = (int64 *)
                                                                 FUN_1800d60b0(DAT_181d80cc0,2);
                                                        if (plVar2 != (int64 *)0) {
                                                          if (("敌对" != 0) &&
                                                             (lVar3 = il2cpp_internal("敌对",
                                                                                          *(uint64 *)
                                                                                           (*plVar2 + 64
                                                                                           )), lVar3 == null)
                                                             ) {
                                                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                            FUN_1800d65f0(uVar4,0);
                                                          }
                                                          lVar3 = "敌对";
                                                          if ((int)plVar2[3] == 0) {
                                                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                            FUN_1800d65f0(uVar4,0);
                                                          }
                                                          plVar2[4] = "敌对";
                                                          il2cpp_internal(plVar2 + 4,lVar3);
                                                          if (("挑战" != 0) &&
                                                             (lVar3 = il2cpp_internal("挑战",
                                                                                          *(uint64 *)
                                                                                           (*plVar2 + 64
                                                                                           )), lVar3 == null)
                                                             ) {
                                                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                            FUN_1800d65f0(uVar4,0);
                                                          }
                                                          lVar3 = "挑战";
                                                          if (*(uint32 *)(plVar2 + 3) < 2) {
                                                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                            FUN_1800d65f0(uVar4,0);
                                                          }
                                                          plVar2[5] = "挑战";
                                                          il2cpp_internal(plVar2 + 5,lVar3);
                                                          lVar3 = il2cpp_internal(plVar2,*(uint64
                                                                                               *)(*plVar1 
                                                        + 64));
                                                        if (lVar3 == null) {
                                                          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                          FUN_1800d65f0(uVar4,0);
                                                        }
                                                        if (*(uint32 *)(plVar1 + 3) < 24) {
                                                          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                          FUN_1800d65f0(uVar4,0);
                                                        }
                                                        plVar1[27] = (int64)plVar2;
                                                        il2cpp_internal(plVar1 + 27,plVar2);
                                                        plVar2 = (int64 *)
                                                                 FUN_1800d60b0(DAT_181d80cc0,2);
                                                        if (plVar2 != (int64 *)0) {
                                                          if (("羞辱" != 0) &&
                                                             (lVar3 = il2cpp_internal("羞辱",
                                                                                          *(uint64 *)
                                                                                           (*plVar2 + 64
                                                                                           )), lVar3 == null)
                                                             ) {
                                                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                            FUN_1800d65f0(uVar4,0);
                                                          }
                                                          lVar3 = "羞辱";
                                                          if ((int)plVar2[3] == 0) {
                                                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                            FUN_1800d65f0(uVar4,0);
                                                          }
                                                          plVar2[4] = "羞辱";
                                                          il2cpp_internal(plVar2 + 4,lVar3);
                                                          if (("责备" != 0) &&
                                                             (lVar3 = il2cpp_internal("责备",
                                                                                          *(uint64 *)
                                                                                           (*plVar2 + 64
                                                                                           )), lVar3 == null)
                                                             ) {
                                                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                            FUN_1800d65f0(uVar4,0);
                                                          }
                                                          lVar3 = "责备";
                                                          if (*(uint32 *)(plVar2 + 3) < 2) {
                                                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                            FUN_1800d65f0(uVar4,0);
                                                          }
                                                          plVar2[5] = "责备";
                                                          il2cpp_internal(plVar2 + 5,lVar3);
                                                          lVar3 = il2cpp_internal(plVar2,*(uint64
                                                                                               *)(*plVar1 
                                                        + 64));
                                                        if (lVar3 == null) {
                                                          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                          FUN_1800d65f0(uVar4,0);
                                                        }
                                                        if (*(uint32 *)(plVar1 + 3) < 25) {
                                                          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                          FUN_1800d65f0(uVar4,0);
                                                        }
                                                        plVar1[28] = (int64)plVar2;
                                                        il2cpp_internal(plVar1 + 28,plVar2);
                                                        plVar2 = (int64 *)
                                                                 FUN_1800d60b0(DAT_181d80cc0,2);
                                                        if (plVar2 != (int64 *)0) {
                                                          if (("抢夺对方" != 0) &&
                                                             (lVar3 = il2cpp_internal("抢夺对方",
                                                                                          *(uint64 *)
                                                                                           (*plVar2 + 64
                                                                                           )), lVar3 == null)
                                                             ) {
                                                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                            FUN_1800d65f0(uVar4,0);
                                                          }
                                                          lVar3 = "抢夺对方";
                                                          if ((int)plVar2[3] == 0) {
                                                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                            FUN_1800d65f0(uVar4,0);
                                                          }
                                                          plVar2[4] = "抢夺对方";
                                                          il2cpp_internal(plVar2 + 4,lVar3);
                                                          if (("获取对方" != 0) &&
                                                             (lVar3 = il2cpp_internal("获取对方",
                                                                                          *(uint64 *)
                                                                                           (*plVar2 + 64
                                                                                           )), lVar3 == null)
                                                             ) {
                                                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                            FUN_1800d65f0(uVar4,0);
                                                          }
                                                          lVar3 = "获取对方";
                                                          if (*(uint32 *)(plVar2 + 3) < 2) {
                                                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                            FUN_1800d65f0(uVar4,0);
                                                          }
                                                          plVar2[5] = "获取对方";
                                                          il2cpp_internal(plVar2 + 5,lVar3);
                                                          lVar3 = il2cpp_internal(plVar2,*(uint64
                                                                                               *)(*plVar1 
                                                        + 64));
                                                        if (lVar3 == null) {
                                                          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                          FUN_1800d65f0(uVar4,0);
                                                        }
                                                        if (*(uint32 *)(plVar1 + 3) < 26) {
                                                          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                          FUN_1800d65f0(uVar4,0);
                                                        }
                                                        plVar1[29] = (int64)plVar2;
                                                        il2cpp_internal(plVar1 + 29,plVar2);
                                                        plVar2 = (int64 *)
                                                                 FUN_1800d60b0(DAT_181d80cc0,2);
                                                        if (plVar2 != (int64 *)0) {
                                                          if (("抢夺银两" != 0) &&
                                                             (lVar3 = il2cpp_internal("抢夺银两",
                                                                                          *(uint64 *)
                                                                                           (*plVar2 + 64
                                                                                           )), lVar3 == null)
                                                             ) {
                                                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                            FUN_1800d65f0(uVar4,0);
                                                          }
                                                          lVar3 = "抢夺银两";
                                                          if ((int)plVar2[3] == 0) {
                                                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                            FUN_1800d65f0(uVar4,0);
                                                          }
                                                          plVar2[4] = "抢夺银两";
                                                          il2cpp_internal(plVar2 + 4,lVar3);
                                                          if (("获取银两" != 0) &&
                                                             (lVar3 = il2cpp_internal("获取银两",
                                                                                          *(uint64 *)
                                                                                           (*plVar2 + 64
                                                                                           )), lVar3 == null)
                                                             ) {
                                                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                            FUN_1800d65f0(uVar4,0);
                                                          }
                                                          lVar3 = "获取银两";
                                                          if (*(uint32 *)(plVar2 + 3) < 2) {
                                                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                            FUN_1800d65f0(uVar4,0);
                                                          }
                                                          plVar2[5] = "获取银两";
                                                          il2cpp_internal(plVar2 + 5,lVar3);
                                                          lVar3 = il2cpp_internal(plVar2,*(uint64
                                                                                               *)(*plVar1 
                                                        + 64));
                                                        if (lVar3 == null) {
                                                          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                          FUN_1800d65f0(uVar4,0);
                                                        }
                                                        if (*(uint32 *)(plVar1 + 3) < 27) {
                                                          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                          FUN_1800d65f0(uVar4,0);
                                                        }
                                                        plVar1[30] = (int64)plVar2;
                                                        il2cpp_internal(plVar1 + 30,plVar2);
                                                        plVar2 = (int64 *)
                                                                 FUN_1800d60b0(DAT_181d80cc0,2);
                                                        if (plVar2 != (int64 *)0) {
                                                          if (("抢夺财物" != 0) &&
                                                             (lVar3 = il2cpp_internal("抢夺财物",
                                                                                          *(uint64 *)
                                                                                           (*plVar2 + 64
                                                                                           )), lVar3 == null)
                                                             ) {
                                                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                            FUN_1800d65f0(uVar4,0);
                                                          }
                                                          lVar3 = "抢夺财物";
                                                          if ((int)plVar2[3] == 0) {
                                                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                            FUN_1800d65f0(uVar4,0);
                                                          }
                                                          plVar2[4] = "抢夺财物";
                                                          il2cpp_internal(plVar2 + 4,lVar3);
                                                          if (("获取财物" != 0) &&
                                                             (lVar3 = il2cpp_internal("获取财物",
                                                                                          *(uint64 *)
                                                                                           (*plVar2 + 64
                                                                                           )), lVar3 == null)
                                                             ) {
                                                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                            FUN_1800d65f0(uVar4,0);
                                                          }
                                                          lVar3 = "获取财物";
                                                          if (*(uint32 *)(plVar2 + 3) < 2) {
                                                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                            FUN_1800d65f0(uVar4,0);
                                                          }
                                                          plVar2[5] = "获取财物";
                                                          il2cpp_internal(plVar2 + 5,lVar3);
                                                          lVar3 = il2cpp_internal(plVar2,*(uint64
                                                                                               *)(*plVar1 
                                                        + 64));
                                                        if (lVar3 == null) {
                                                          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                          FUN_1800d65f0(uVar4,0);
                                                        }
                                                        if (*(uint32 *)(plVar1 + 3) < 28) {
                                                          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                          FUN_1800d65f0(uVar4,0);
                                                        }
                                                        plVar1[31] = (int64)plVar2;
                                                        il2cpp_internal(plVar1 + 31,plVar2);
                                                        plVar2 = (int64 *)
                                                                 FUN_1800d60b0(DAT_181d80cc0,2);
                                                        if (plVar2 != (int64 *)0) {
                                                          if (("偷窃对方" != 0) &&
                                                             (lVar3 = il2cpp_internal("偷窃对方",
                                                                                          *(uint64 *)
                                                                                           (*plVar2 + 64
                                                                                           )), lVar3 == null)
                                                             ) {
                                                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                            FUN_1800d65f0(uVar4,0);
                                                          }
                                                          lVar3 = "偷窃对方";
                                                          if ((int)plVar2[3] == 0) {
                                                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                            FUN_1800d65f0(uVar4,0);
                                                          }
                                                          plVar2[4] = "偷窃对方";
                                                          il2cpp_internal(plVar2 + 4,lVar3);
                                                          if (("获取对方" != 0) &&
                                                             (lVar3 = il2cpp_internal("获取对方",
                                                                                          *(uint64 *)
                                                                                           (*plVar2 + 64
                                                                                           )), lVar3 == null)
                                                             ) {
                                                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                            FUN_1800d65f0(uVar4,0);
                                                          }
                                                          lVar3 = "获取对方";
                                                          if (*(uint32 *)(plVar2 + 3) < 2) {
                                                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                            FUN_1800d65f0(uVar4,0);
                                                          }
                                                          plVar2[5] = "获取对方";
                                                          il2cpp_internal(plVar2 + 5,lVar3);
                                                          lVar3 = il2cpp_internal(plVar2,*(uint64
                                                                                               *)(*plVar1 
                                                        + 64));
                                                        if (lVar3 == null) {
                                                          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                          FUN_1800d65f0(uVar4,0);
                                                        }
                                                        if (*(uint32 *)(plVar1 + 3) < 29) {
                                                          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                          FUN_1800d65f0(uVar4,0);
                                                        }
                                                        plVar1[32] = (int64)plVar2;
                                                        il2cpp_internal(plVar1 + 32,plVar2);
                                                        plVar2 = (int64 *)
                                                                 FUN_1800d60b0(DAT_181d80cc0,2);
                                                        if (plVar2 != (int64 *)0) {
                                                          if (("偷师对方" != 0) &&
                                                             (lVar3 = il2cpp_internal("偷师对方",
                                                                                          *(uint64 *)
                                                                                           (*plVar2 + 64
                                                                                           )), lVar3 == null)
                                                             ) {
                                                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                            FUN_1800d65f0(uVar4,0);
                                                          }
                                                          lVar3 = "偷师对方";
                                                          if ((int)plVar2[3] == 0) {
                                                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                            FUN_1800d65f0(uVar4,0);
                                                          }
                                                          plVar2[4] = "偷师对方";
                                                          il2cpp_internal(plVar2 + 4,lVar3);
                                                          if (("学习对方" != 0) &&
                                                             (lVar3 = il2cpp_internal("学习对方",
                                                                                          *(uint64 *)
                                                                                           (*plVar2 + 64
                                                                                           )), lVar3 == null)
                                                             ) {
                                                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                            FUN_1800d65f0(uVar4,0);
                                                          }
                                                          lVar3 = "学习对方";
                                                          if (*(uint32 *)(plVar2 + 3) < 2) {
                                                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                            FUN_1800d65f0(uVar4,0);
                                                          }
                                                          plVar2[5] = "学习对方";
                                                          il2cpp_internal(plVar2 + 5,lVar3);
                                                          lVar3 = il2cpp_internal(plVar2,*(uint64
                                                                                               *)(*plVar1 
                                                        + 64));
                                                        if (lVar3 == null) {
                                                          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                          FUN_1800d65f0(uVar4,0);
                                                        }
                                                        if (*(uint32 *)(plVar1 + 3) < 30) {
                                                          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                          FUN_1800d65f0(uVar4,0);
                                                        }
                                                        plVar1[33] = (int64)plVar2;
                                                        il2cpp_internal(plVar1 + 33,plVar2);
                                                        plVar2 = (int64 *)
                                                                 FUN_1800d60b0(DAT_181d80cc0,2);
                                                        if (plVar2 != (int64 *)0) {
                                                          if (("抢夺" != 0) &&
                                                             (lVar3 = il2cpp_internal("抢夺",
                                                                                          *(uint64 *)
                                                                                           (*plVar2 + 64
                                                                                           )), lVar3 == null)
                                                             ) {
                                                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                            FUN_1800d65f0(uVar4,0);
                                                          }
                                                          lVar3 = "抢夺";
                                                          if ((int)plVar2[3] == 0) {
                                                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                            FUN_1800d65f0(uVar4,0);
                                                          }
                                                          plVar2[4] = "抢夺";
                                                          il2cpp_internal(plVar2 + 4,lVar3);
                                                          if (("角力" != 0) &&
                                                             (lVar3 = il2cpp_internal("角力",
                                                                                          *(uint64 *)
                                                                                           (*plVar2 + 64
                                                                                           )), lVar3 == null)
                                                             ) {
                                                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                            FUN_1800d65f0(uVar4,0);
                                                          }
                                                          lVar3 = "角力";
                                                          if (*(uint32 *)(plVar2 + 3) < 2) {
                                                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                            FUN_1800d65f0(uVar4,0);
                                                          }
                                                          plVar2[5] = "角力";
                                                          il2cpp_internal(plVar2 + 5,lVar3);
                                                          lVar3 = il2cpp_internal(plVar2,*(uint64
                                                                                               *)(*plVar1 
                                                        + 64));
                                                        if (lVar3 == null) {
                                                          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                          FUN_1800d65f0(uVar4,0);
                                                        }
                                                        if (*(uint32 *)(plVar1 + 3) < 31) {
                                                          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                          FUN_1800d65f0(uVar4,0);
                                                        }
                                                        plVar1[34] = (int64)plVar2;
                                                        il2cpp_internal(plVar1 + 34,plVar2);
                                                        plVar2 = (int64 *)
                                                                 FUN_1800d60b0(DAT_181d80cc0,2);
                                                        if (plVar2 != (int64 *)0) {
                                                          if (("偷窃" != 0) &&
                                                             (lVar3 = il2cpp_internal("偷窃",
                                                                                          *(uint64 *)
                                                                                           (*plVar2 + 64
                                                                                           )), lVar3 == null)
                                                             ) {
                                                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                            FUN_1800d65f0(uVar4,0);
                                                          }
                                                          lVar3 = "偷窃";
                                                          if ((int)plVar2[3] == 0) {
                                                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                            FUN_1800d65f0(uVar4,0);
                                                          }
                                                          plVar2[4] = "偷窃";
                                                          il2cpp_internal(plVar2 + 4,lVar3);
                                                          if (("斗技" != 0) &&
                                                             (lVar3 = il2cpp_internal("斗技",
                                                                                          *(uint64 *)
                                                                                           (*plVar2 + 64
                                                                                           )), lVar3 == null)
                                                             ) {
                                                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                            FUN_1800d65f0(uVar4,0);
                                                          }
                                                          lVar3 = "斗技";
                                                          if (*(uint32 *)(plVar2 + 3) < 2) {
                                                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                            FUN_1800d65f0(uVar4,0);
                                                          }
                                                          plVar2[5] = "斗技";
                                                          il2cpp_internal(plVar2 + 5,lVar3);
                                                          lVar3 = il2cpp_internal(plVar2,*(uint64
                                                                                               *)(*plVar1 
                                                        + 64));
                                                        if (lVar3 == null) {
                                                          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                          FUN_1800d65f0(uVar4,0);
                                                        }
                                                        if (*(uint32 *)(plVar1 + 3) < 32) {
                                                          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                          FUN_1800d65f0(uVar4,0);
                                                        }
                                                        plVar1[35] = (int64)plVar2;
                                                        il2cpp_internal(plVar1 + 35,plVar2);
                                                        plVar2 = (int64 *)
                                                                 FUN_1800d60b0(DAT_181d80cc0,2);
                                                        if (plVar2 != (int64 *)0) {
                                                          if (("偷师" != 0) &&
                                                             (lVar3 = il2cpp_internal("偷师",
                                                                                          *(uint64 *)
                                                                                           (*plVar2 + 64
                                                                                           )), lVar3 == null)
                                                             ) {
                                                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                            FUN_1800d65f0(uVar4,0);
                                                          }
                                                          lVar3 = "偷师";
                                                          if ((int)plVar2[3] == 0) {
                                                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                            FUN_1800d65f0(uVar4,0);
                                                          }
                                                          plVar2[4] = "偷师";
                                                          il2cpp_internal(plVar2 + 4,lVar3);
                                                          if (("斗智" != 0) &&
                                                             (lVar3 = il2cpp_internal("斗智",
                                                                                          *(uint64 *)
                                                                                           (*plVar2 + 64
                                                                                           )), lVar3 == null)
                                                             ) {
                                                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                            FUN_1800d65f0(uVar4,0);
                                                          }
                                                          lVar3 = "斗智";
                                                          if (*(uint32 *)(plVar2 + 3) < 2) {
                                                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                            FUN_1800d65f0(uVar4,0);
                                                          }
                                                          plVar2[5] = "斗智";
                                                          il2cpp_internal(plVar2 + 5,lVar3);
                                                          lVar3 = il2cpp_internal(plVar2,*(uint64
                                                                                               *)(*plVar1 
                                                        + 64));
                                                        if (lVar3 == null) {
                                                          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                          FUN_1800d65f0(uVar4,0);
                                                        }
                                                        if (*(uint32 *)(plVar1 + 3) < 33) {
                                                          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                          FUN_1800d65f0(uVar4,0);
                                                        }
                                                        plVar1[36] = (int64)plVar2;
                                                        il2cpp_internal(plVar1 + 36,plVar2);
                                                        plVar2 = (int64 *)
                                                                 FUN_1800d60b0(DAT_181d80cc0,2);
                                                        if (plVar2 != (int64 *)0) {
                                                          if (("袭击" != 0) &&
                                                             (lVar3 = il2cpp_internal("袭击",
                                                                                          *(uint64 *)
                                                                                           (*plVar2 + 64
                                                                                           )), lVar3 == null)
                                                             ) {
                                                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                            FUN_1800d65f0(uVar4,0);
                                                          }
                                                          lVar3 = "袭击";
                                                          if ((int)plVar2[3] == 0) {
                                                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                            FUN_1800d65f0(uVar4,0);
                                                          }
                                                          plVar2[4] = "袭击";
                                                          il2cpp_internal(plVar2 + 4,lVar3);
                                                          if (("挑战" != 0) &&
                                                             (lVar3 = il2cpp_internal("挑战",
                                                                                          *(uint64 *)
                                                                                           (*plVar2 + 64
                                                                                           )), lVar3 == null)
                                                             ) {
                                                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                            FUN_1800d65f0(uVar4,0);
                                                          }
                                                          lVar3 = "挑战";
                                                          if (*(uint32 *)(plVar2 + 3) < 2) {
                                                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                            FUN_1800d65f0(uVar4,0);
                                                          }
                                                          plVar2[5] = "挑战";
                                                          il2cpp_internal(plVar2 + 5,lVar3);
                                                          lVar3 = il2cpp_internal(plVar2,*(uint64
                                                                                               *)(*plVar1 
                                                        + 64));
                                                        if (lVar3 == null) {
                                                          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                          FUN_1800d65f0(uVar4,0);
                                                        }
                                                        if (*(uint32 *)(plVar1 + 3) < 34) {
                                                          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                          FUN_1800d65f0(uVar4,0);
                                                        }
                                                        plVar1[37] = (int64)plVar2;
                                                        il2cpp_internal(plVar1 + 37,plVar2);
                                                        plVar2 = (int64 *)
                                                                 FUN_1800d60b0(DAT_181d80cc0,2);
                                                        if (plVar2 != (int64 *)0) {
                                                          if (("窃取" != 0) &&
                                                             (lVar3 = il2cpp_internal("窃取",
                                                                                          *(uint64 *)
                                                                                           (*plVar2 + 64
                                                                                           )), lVar3 == null)
                                                             ) {
                                                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                            FUN_1800d65f0(uVar4,0);
                                                          }
                                                          lVar3 = "窃取";
                                                          if ((int)plVar2[3] == 0) {
                                                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                            FUN_1800d65f0(uVar4,0);
                                                          }
                                                          plVar2[4] = "窃取";
                                                          il2cpp_internal(plVar2 + 4,lVar3);
                                                          if (("获取" != 0) &&
                                                             (lVar3 = il2cpp_internal("获取",
                                                                                          *(uint64 *)
                                                                                           (*plVar2 + 64
                                                                                           )), lVar3 == null)
                                                             ) {
                                                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                            FUN_1800d65f0(uVar4,0);
                                                          }
                                                          lVar3 = "获取";
                                                          if (*(uint32 *)(plVar2 + 3) < 2) {
                                                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                            FUN_1800d65f0(uVar4,0);
                                                          }
                                                          plVar2[5] = "获取";
                                                          il2cpp_internal(plVar2 + 5,lVar3);
                                                          lVar3 = il2cpp_internal(plVar2,*(uint64
                                                                                               *)(*plVar1 
                                                        + 64));
                                                        if (lVar3 == null) {
                                                          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                          FUN_1800d65f0(uVar4,0);
                                                        }
                                                        if (*(uint32 *)(plVar1 + 3) < 35) {
                                                          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                          FUN_1800d65f0(uVar4,0);
                                                        }
                                                        plVar1[38] = (int64)plVar2;
                                                        il2cpp_internal(plVar1 + 38,plVar2);
                                                        plVar2 = (int64 *)
                                                                 FUN_1800d60b0(DAT_181d80cc0,2);
                                                        if (plVar2 != (int64 *)0) {
                                                          if (("被通缉" != 0) &&
                                                             (lVar3 = il2cpp_internal("被通缉",
                                                                                          *(uint64 *)
                                                                                           (*plVar2 + 64
                                                                                           )), lVar3 == null)
                                                             ) {
                                                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                            FUN_1800d65f0(uVar4,0);
                                                          }
                                                          lVar3 = "被通缉";
                                                          if ((int)plVar2[3] == 0) {
                                                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                            FUN_1800d65f0(uVar4,0);
                                                          }
                                                          plVar2[4] = "被通缉";
                                                          il2cpp_internal(plVar2 + 4,lVar3);
                                                          if (("被他人挑战" != 0) &&
                                                             (lVar3 = il2cpp_internal("被他人挑战",
                                                                                          *(uint64 *)
                                                                                           (*plVar2 + 64
                                                                                           )), lVar3 == null)
                                                             ) {
                                                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                            FUN_1800d65f0(uVar4,0);
                                                          }
                                                          lVar3 = "被他人挑战";
                                                          if (*(uint32 *)(plVar2 + 3) < 2) {
                                                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                            FUN_1800d65f0(uVar4,0);
                                                          }
                                                          plVar2[5] = "被他人挑战";
                                                          il2cpp_internal(plVar2 + 5,lVar3);
                                                          lVar3 = il2cpp_internal(plVar2,*(uint64
                                                                                               *)(*plVar1 
                                                        + 64));
                                                        if (lVar3 == null) {
                                                          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                          FUN_1800d65f0(uVar4,0);
                                                        }
                                                        if (*(uint32 *)(plVar1 + 3) < 36) {
                                                          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                          FUN_1800d65f0(uVar4,0);
                                                        }
                                                        plVar1[39] = (int64)plVar2;
                                                        il2cpp_internal(plVar1 + 39,plVar2);
                                                        plVar2 = (int64 *)
                                                                 FUN_1800d60b0(DAT_181d80cc0,2);
                                                        if (plVar2 != (int64 *)0) {
                                                          if (("监牢" != 0) &&
                                                             (lVar3 = il2cpp_internal("监牢",
                                                                                          *(uint64 *)
                                                                                           (*plVar2 + 64
                                                                                           )), lVar3 == null)
                                                             ) {
                                                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                            FUN_1800d65f0(uVar4,0);
                                                          }
                                                          lVar3 = "监牢";
                                                          if ((int)plVar2[3] == 0) {
                                                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                            FUN_1800d65f0(uVar4,0);
                                                          }
                                                          plVar2[4] = "监牢";
                                                          il2cpp_internal(plVar2 + 4,lVar3);
                                                          if (("思过室" != 0) &&
                                                             (lVar3 = il2cpp_internal("思过室",
                                                                                          *(uint64 *)
                                                                                           (*plVar2 + 64
                                                                                           )), lVar3 == null)
                                                             ) {
                                                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                            FUN_1800d65f0(uVar4,0);
                                                          }
                                                          lVar3 = "思过室";
                                                          if (*(uint32 *)(plVar2 + 3) < 2) {
                                                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                            FUN_1800d65f0(uVar4,0);
                                                          }
                                                          plVar2[5] = "思过室";
                                                          il2cpp_internal(plVar2 + 5,lVar3);
                                                          lVar3 = il2cpp_internal(plVar2,*(uint64
                                                                                               *)(*plVar1 
                                                        + 64));
                                                        if (lVar3 == null) {
                                                          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                          FUN_1800d65f0(uVar4,0);
                                                        }
                                                        if (*(uint32 *)(plVar1 + 3) < 37) {
                                                          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                          FUN_1800d65f0(uVar4,0);
                                                        }
                                                        plVar1[40] = (int64)plVar2;
                                                        il2cpp_internal(plVar1 + 40,plVar2);
                                                        plVar2 = (int64 *)
                                                                 FUN_1800d60b0(DAT_181d80cc0,2);
                                                        if (plVar2 != (int64 *)0) {
                                                          if (("监狱" != 0) &&
                                                             (lVar3 = il2cpp_internal("监狱",
                                                                                          *(uint64 *)
                                                                                           (*plVar2 + 64
                                                                                           )), lVar3 == null)
                                                             ) {
                                                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                            FUN_1800d65f0(uVar4,0);
                                                          }
                                                          lVar3 = "监狱";
                                                          if ((int)plVar2[3] == 0) {
                                                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                            FUN_1800d65f0(uVar4,0);
                                                          }
                                                          plVar2[4] = "监狱";
                                                          il2cpp_internal(plVar2 + 4,lVar3);
                                                          if (("思过室" != 0) &&
                                                             (lVar3 = il2cpp_internal("思过室",
                                                                                          *(uint64 *)
                                                                                           (*plVar2 + 64
                                                                                           )), lVar3 == null)
                                                             ) {
                                                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                            FUN_1800d65f0(uVar4,0);
                                                          }
                                                          lVar3 = "思过室";
                                                          if (*(uint32 *)(plVar2 + 3) < 2) {
                                                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                            FUN_1800d65f0(uVar4,0);
                                                          }
                                                          plVar2[5] = "思过室";
                                                          il2cpp_internal(plVar2 + 5,lVar3);
                                                          lVar3 = il2cpp_internal(plVar2,*(uint64
                                                                                               *)(*plVar1 
                                                        + 64));
                                                        if (lVar3 == null) {
                                                          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                          FUN_1800d65f0(uVar4,0);
                                                        }
                                                        if (*(uint32 *)(plVar1 + 3) < 38) {
                                                          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                          FUN_1800d65f0(uVar4,0);
                                                        }
                                                        plVar1[41] = (int64)plVar2;
                                                        il2cpp_internal(plVar1 + 41,plVar2);
                                                        plVar2 = (int64 *)
                                                                 FUN_1800d60b0(DAT_181d80cc0,2);
                                                        if (plVar2 != (int64 *)0) {
                                                          if (("狱卒" != 0) &&
                                                             (lVar3 = il2cpp_internal("狱卒",
                                                                                          *(uint64 *)
                                                                                           (*plVar2 + 64
                                                                                           )), lVar3 == null)
                                                             ) {
                                                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                            FUN_1800d65f0(uVar4,0);
                                                          }
                                                          lVar3 = "狱卒";
                                                          if ((int)plVar2[3] == 0) {
                                                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                            FUN_1800d65f0(uVar4,0);
                                                          }
                                                          plVar2[4] = "狱卒";
                                                          il2cpp_internal(plVar2 + 4,lVar3);
                                                          if (("看守" != 0) &&
                                                             (lVar3 = il2cpp_internal("看守",
                                                                                          *(uint64 *)
                                                                                           (*plVar2 + 64
                                                                                           )), lVar3 == null)
                                                             ) {
                                                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                            FUN_1800d65f0(uVar4,0);
                                                          }
                                                          lVar3 = "看守";
                                                          if (*(uint32 *)(plVar2 + 3) < 2) {
                                                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                            FUN_1800d65f0(uVar4,0);
                                                          }
                                                          plVar2[5] = "看守";
                                                          il2cpp_internal(plVar2 + 5,lVar3);
                                                          lVar3 = il2cpp_internal(plVar2,*(uint64
                                                                                               *)(*plVar1 
                                                        + 64));
                                                        if (lVar3 == null) {
                                                          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                          FUN_1800d65f0(uVar4,0);
                                                        }
                                                        if (*(uint32 *)(plVar1 + 3) < 39) {
                                                          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                          FUN_1800d65f0(uVar4,0);
                                                        }
                                                        plVar1[42] = (int64)plVar2;
                                                        il2cpp_internal(plVar1 + 42,plVar2);
                                                        puVar5 = (uint64 *)
                                                                 (pStatics + 8)
                                                        ;
                                                        *puVar5 = plVar1;
                                                        il2cpp_internal(puVar5,plVar1);
                                                        plVar1 = (int64 *)
                                                                 FUN_1800d60b0(DAT_181d7b320,1);
                                                        plVar2 = (int64 *)
                                                                 FUN_1800d60b0(DAT_181d80cc0,2);
                                                        if (plVar2 != (int64 *)0) {
                                                          if (("动词" != 0) &&
                                                             (lVar3 = il2cpp_internal("动词",
                                                                                          *(uint64 *)
                                                                                           (*plVar2 + 64
                                                                                           )), lVar3 == null)
                                                             ) {
                                                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                            FUN_1800d65f0(uVar4,0);
                                                          }
                                                          lVar3 = "动词";
                                                          if ((int)plVar2[3] == 0) {
                                                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                            FUN_1800d65f0(uVar4,0);
                                                          }
                                                          plVar2[4] = "动词";
                                                          il2cpp_internal(plVar2 + 4,lVar3);
                                                          if (("" != 0) &&
                                                             (lVar3 = il2cpp_internal("",
                                                                                          *(uint64 *)
                                                                                           (*plVar2 + 64
                                                                                           )), lVar3 == null)
                                                             ) {
                                                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                            FUN_1800d65f0(uVar4,0);
                                                          }
                                                          lVar3 = "";
                                                          if (*(uint32 *)(plVar2 + 3) < 2) {
                                                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                            FUN_1800d65f0(uVar4,0);
                                                          }
                                                          plVar2[5] = "";
                                                          il2cpp_internal(plVar2 + 5,lVar3);
                                                          if (plVar1 != (int64 *)0) {
                                                            lVar3 = il2cpp_internal(plVar2,*(
                                                        uint64 *)(*plVar1 + 64));
                                                        if (lVar3 == null) {
                                                          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                          FUN_1800d65f0(uVar4,0);
                                                        }
                                                        if ((int)plVar1[3] == 0) {
                                                          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                          FUN_1800d65f0(uVar4,0);
                                                        }
                                                        plVar1[4] = (int64)plVar2;
                                                        il2cpp_internal(plVar1 + 4,plVar2);
                                                        puVar5 = (uint64 *)
                                                                 (pStatics +
                                                                 16);
                                                        *puVar5 = plVar1;
                                                        il2cpp_internal(puVar5,plVar1);
                                                        plVar1 = (int64 *)
                                                                 FUN_1800d60b0(DAT_181d7b320,2);
                                                        plVar2 = (int64 *)
                                                                 FUN_1800d60b0(DAT_181d80cc0,2);
                                                        if (plVar2 != (int64 *)0) {
                                                          if (("\"" != 0) &&
                                                             (lVar3 = il2cpp_internal("\"",
                                                                                          *(uint64 *)
                                                                                           (*plVar2 + 64
                                                                                           )), lVar3 == null)
                                                             ) {
                                                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                            FUN_1800d65f0(uVar4,0);
                                                          }
                                                          lVar3 = "\"";
                                                          if ((int)plVar2[3] == 0) {
                                                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                            FUN_1800d65f0(uVar4,0);
                                                          }
                                                          plVar2[4] = "\"";
                                                          il2cpp_internal(plVar2 + 4,lVar3);
                                                          if (("" != 0) &&
                                                             (lVar3 = il2cpp_internal("",
                                                                                          *(uint64 *)
                                                                                           (*plVar2 + 64
                                                                                           )), lVar3 == null)
                                                             ) {
                                                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                            FUN_1800d65f0(uVar4,0);
                                                          }
                                                          lVar3 = "";
                                                          if (*(uint32 *)(plVar2 + 3) < 2) {
                                                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                            FUN_1800d65f0(uVar4,0);
                                                          }
                                                          plVar2[5] = "";
                                                          il2cpp_internal(plVar2 + 5,lVar3);
                                                          if (plVar1 != (int64 *)0) {
                                                            lVar3 = il2cpp_internal(plVar2,*(
                                                        uint64 *)(*plVar1 + 64));
                                                        if (lVar3 == null) {
                                                          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                          FUN_1800d65f0(uVar4,0);
                                                        }
                                                        if ((int)plVar1[3] == 0) {
                                                          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                          FUN_1800d65f0(uVar4,0);
                                                        }
                                                        plVar1[4] = (int64)plVar2;
                                                        il2cpp_internal(plVar1 + 4,plVar2);
                                                        plVar2 = (int64 *)
                                                                 FUN_1800d60b0(DAT_181d80cc0,2);
                                                        if (plVar2 != (int64 *)0) {
                                                          if (("#英文双引号#" != 0) &&
                                                             (lVar3 = il2cpp_internal("#英文双引号#",
                                                                                          *(uint64 *)
                                                                                           (*plVar2 + 64
                                                                                           )), lVar3 == null)
                                                             ) {
                                                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                            FUN_1800d65f0(uVar4,0);
                                                          }
                                                          lVar3 = "#英文双引号#";
                                                          if ((int)plVar2[3] == 0) {
                                                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                            FUN_1800d65f0(uVar4,0);
                                                          }
                                                          plVar2[4] = "#英文双引号#";
                                                          il2cpp_internal(plVar2 + 4,lVar3);
                                                          if (("\"" != 0) &&
                                                             (lVar3 = il2cpp_internal("\"",
                                                                                          *(uint64 *)
                                                                                           (*plVar2 + 64
                                                                                           )), lVar3 == null)
                                                             ) {
                                                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                            FUN_1800d65f0(uVar4,0);
                                                          }
                                                          lVar3 = "\"";
                                                          if (*(uint32 *)(plVar2 + 3) < 2) {
                                                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                            FUN_1800d65f0(uVar4,0);
                                                          }
                                                          plVar2[5] = "\"";
                                                          il2cpp_internal(plVar2 + 5,lVar3);
                                                          lVar3 = il2cpp_internal(plVar2,*(uint64
                                                                                               *)(*plVar1 
                                                        + 64));
                                                        if (lVar3 != null) {
                                                          if (*(uint32 *)(plVar1 + 3) < 2) {
                                                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                            FUN_1800d65f0(uVar4,0);
                                                          }
                                                          plVar1[5] = (int64)plVar2;
                                                          il2cpp_internal(plVar1 + 5,plVar2);
                                                          puVar5 = (uint64 *)
                                                                   (pStatics +
                                                                   24);
                                                          *puVar5 = plVar1;
                                                          il2cpp_internal(puVar5,plVar1);
                                                          return;
                                                        }
                                                        uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                        FUN_1800d65f0(uVar4,0);
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
                          // WARNING: Subroutine does not return
                                                        FUN_1800d6620();
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
