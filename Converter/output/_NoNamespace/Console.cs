// ============================================================
// Type  : Console
// Token : 0x2000296
// ============================================================

public class Console
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001438
    private static readonly string[] command;

    // Token: 0x4001439
    private static readonly string[] releaseHideCommand;

    // Token: 0x400143A
    private static readonly string[] developCommand;

    // Token: 0x400143B
    private static int position;

    // Token: 0x400143C
    private static List<string> consoleHistory;

    // Token: 0x400143D
    public static bool invincible;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60014F4
    // RVA   : 0x9FDD80   Offset: 0x9FC580   Length: 0x6BCB
    public static string Input(string input)
    {
        var pStatics_0cc8 = *(int64*)(DAT_181d90cc8 + 184);
        var pStatics_42b0 = *(int64*)(DAT_181d942b0 + 184);
        var pStatics_e010 = *(int64*)(DAT_181d4e010 + 184);
        var pStatics_ef00 = *(int64*)(DAT_181d4ef00 + 184);
        var pStatics_fc60 = *(int64*)(DAT_181d8fc60 + 184);
        long lVar1;
        bool cVar3;
        uint uVar4;
        uint uVar5;
        long lVar6;
        ulong uVar7;
        long lVar8;
        ulong uVar9;
        ulong uVar10;
        long lVar11;
        int iVar12;
        ulong uVar13;
        float fVar14;
        float fVar15;
        float[] local_res8 = new float[4];
        float[] local_res18 = new float[2];
        uint[] local_res20 = new uint[2];
        ulong in_stack_ffffffffffffff08;
        ulong in_stack_ffffffffffffff10;
        uint uVar16;
        ulong in_stack_ffffffffffffff18;
        uint local_c8;
        uint local_c4;
        float local_c0;
        int aiStack_bc [4];
        int local_ac;
        int local_a8;
        int local_a4 [3];
        uint64 local_98;
        uint64 uStack_90;
        uint32 local_88;
        uint32 uStack_84;
        uint32 uStack_80;
        uint32 uStack_7c;
        int64 local_78;
        uint32 local_68;
        uint32 uStack_64;
        uint32 uStack_60;
        uint32 uStack_5c;
        int64 local_58;
        uVar5 = (uint32)((uint64)in_stack_ffffffffffffff18 >> 32);
        local_c0 = 0.0;
        uVar10 = 0;
        local_res20[0] = 0;
        local_c8 = 0;
        local_c4 = 0;
        aiStack_bc[2] = 0;
        lVar6 = FUN_1800d60b0(DAT_181d7c118,1);
        if (lVar6 == null) goto LAB_180a04923;
        if (*(int *)(lVar6 + 24) == 0) {
          uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar7,0);
        }
        *(uint16 *)(lVar6 + 32) = 32;
        if (input == null) goto LAB_180a04923;
        uVar7 = String.Split(input,lVar6,0);
        lVar6 = il2cpp_internal(DAT_181d72a30);
        FUN_18182cc20(lVar6,uVar7,DAT_181d7c2d0);
        local_res8[0] = 0.0;
        local_res18[0] = 0.0;
        lVar8 = *(int64 *)(pStatics_42b0 + 32);
        if (lVar8 == null) goto LAB_180a04923;
        FUN_181827900(lVar8,input,DAT_181d7c3d0);
        lVar8 = *(int64 *)(pStatics_42b0 + 32);
        if (lVar8 == null) goto LAB_180a04923;
        if (49 < *(int *)(lVar8 + 24)) {
          lVar8 = *(int64 *)(pStatics_42b0 + 32);
          if (lVar8 == null) goto LAB_180a04923;
          FUN_18182b220(lVar8,0,DAT_181d7c7c8);
        }
        lVar8 = *(int64 *)(pStatics_42b0 + 32);
        if ((lVar8 == null) ||
           (*(uint32 *)(pStatics_42b0 + 24) = *(uint32 *)(lVar8 + 24),
           lVar6 == null)) goto LAB_180a04923;
        if (*(int *)(lVar6 + 24) == 0) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        cVar3 = FUN_1816fd990(*(uint64 *)(*(int64 *)(lVar6 + 16) + 32),"cheat",0);
        if (cVar3) {
          lVar6 = FUN_18046c0a0(0);
          if (lVar6 != null) {
            lVar6 = *(int64 *)(lVar6 + 32);
            lVar8 = FUN_18046c0a0(0);
            if (((lVar8 != null) && (*(int64 *)(lVar8 + 32) != 0)) && (lVar6 != null)) {
              *(bool *)(lVar6 + 152) = *(char *)(*(int64 *)(lVar8 + 32) + 152) == false;
              lVar6 = FUN_18046c0a0(0);
              if ((lVar6 != null) && (*(int64 *)(lVar6 + 32) != 0)) {
                *(uint8 *)(*(int64 *)(lVar6 + 32) + 153) = 1;
                lVar6 = FUN_18046c0a0(0);
                if ((lVar6 != null) && (*(int64 *)(lVar6 + 32) != 0)) {
                  uVar7 = "on";
                  if (*(char *)(*(int64 *)(lVar6 + 32) + 152) == false) {
                    uVar7 = "off";
                  }
                  uVar10 = String.Format("Cheatmode {0}",uVar7,0);
                  return uVar10;
                }
              }
            }
          }
          goto LAB_180a04923;
        }
        lVar8 = FUN_18046c0a0(0);
        if ((lVar8 == null) || (*(int64 *)(lVar8 + 32) == 0)) goto LAB_180a04923;
        if (*(char *)(*(int64 *)(lVar8 + 32) + 152) == false) {
          return "Not in cheatmode";
        }
        local_98 = 0;
        if (*(int *)(pStatics_ef00 + 12) == 1) {
          uVar7 = *(uint64 *)(pStatics_42b0 + 16);
          uVar9 = FUN_180002f80(lVar6,0,DAT_181d7c9c0);
          cVar3 = FUN_18095def0(uVar7,uVar9,DAT_181d89f38);
          if (cVar3) {
            return "Wrong command";
          }
        }
        if (*(int *)(lVar6 + 24) == 0) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        lVar8 = *(int64 *)(*(int64 *)(lVar6 + 16) + 32);
        if (lVar8 == null) {
          return "Wrong command";
        }
        uVar4 = PrivateImplementationDetails.ComputeStringHash(lVar8,0);
        if (uVar4 < 0x8e54a39d) {
          if (uVar4 < 0x44d3978d) {
            if (0x1e6a4802 < uVar4) {
              if (0x32ae0843 < uVar4) {
                if (uVar4 < 0x3e244068) {
                  if (uVar4 == 0x3871a3fa) {
                    cVar3 = FUN_1816fd990(lVar8,"help",0);
                    if (!cVar3) {
                      return "Wrong command";
                    }
                    uVar10 = Console.Show(0);
                    return uVar10;
                  }
                  if (uVar4 != 0x3e244067) {
                    return "Wrong command";
                  }
                  cVar3 = FUN_1816fd990(lVar8,"seealltile",0);
                  if (!cVar3) {
                    return "Wrong command";
                  }
                  lVar6 = FUN_18046be80(0);
                  if (lVar6 != null) {
                    if (*(int64 *)(lVar6 + 112) == 0) {
                      return "Not in explore";
                    }
                    lVar6 = FUN_18046be80(0);
                    if (lVar6 != null) {
                      ExploreController.SeeAllTile(lVar6,0);
                      return 0;
                    }
                  }
                }
                else if (uVar4 == 0x3e8c0c59) {
                  cVar3 = FUN_1816fd990(lVar8,"starttutorial",0);
                  if (!cVar3) {
                    return "Wrong command";
                  }
                  if (*(int *)(lVar6 + 24) < 2) {
                    return "Command format error";
                  }
                  lVar8 = **(int64 **)(DAT_181d88ad8 + 184);
                  uVar7 = FUN_180002f80(lVar6,1,DAT_181d7c9c0);
                  if (lVar8 != null) {
                    TutorialController.StartTutorial(lVar8,uVar7,0);
                    return 0;
                  }
                }
                else {
                  if (uVar4 == 0x430b38f3) {
                    cVar3 = FUN_1816fd990(lVar8,"badfame",0);
                    if (!cVar3) {
                      return "Wrong command";
                    }
                    if (1 < *(int *)(lVar6 + 24)) {
                      if (*(int *)(lVar6 + 24) < 3) {
                        uVar7 = 0;
                      }
                      else {
                        uVar7 = FUN_180002f80(lVar6,1,DAT_181d7c9c0);
                      }
                      lVar8 = Console.GetHeroData(uVar7,0);
                      if (lVar8 != null) {
                        uVar7 = 2;
                        if (*(int *)(lVar6 + 24) < 3) {
                          uVar7 = 1;
                        }
                        uVar7 = FUN_180002f80(lVar6,uVar7,DAT_181d7c9c0);
                        cVar3 = Single.TryParse(uVar7,local_res8,0);
                        if (cVar3) {
                          HeroData.ChangeBadFame(lVar8);
                          return 0;
                        }
                        return "Command format error";
                      }
                      return "Hero not found";
                    }
                    return "Command format error";
                  }
                  if (uVar4 != 0x44d3978c) {
                    return "Wrong command";
                  }
                  cVar3 = FUN_1816fd990(lVar8,"governcontribution",0);
                  if (!cVar3) {
                    return "Wrong command";
                  }
                  if (*(int *)(lVar6 + 24) < 2) {
                    return "Command format error";
                  }
                  uVar7 = FUN_180002f80(lVar6,1,DAT_181d7c9c0);
                  cVar3 = Single.TryParse(uVar7,local_res8,0);
                  if (!cVar3) {
                    return "Command format error";
                  }
                  lVar6 = FUN_18046c0a0(0);
                  if (((lVar6 != null) && (*(int64 *)(lVar6 + 32) != 0)) &&
                     (lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0)) != null) {
                    HeroData.ChangeGovernContribution(lVar6);
                    return 0;
                  }
                }
                goto LAB_180a04923;
              }
              if (uVar4 < 0x29f4e853) {
                if (uVar4 != 0x255c8cce) {
                  if (uVar4 != 0x29f4e852) {
                    return "Wrong command";
                  }
                  cVar3 = FUN_1816fd990(lVar8,"chapter",0);
                  if (!cVar3) {
                    return "Wrong command";
                  }
                  if (*(int *)(lVar6 + 24) < 2) {
                    return "Command format error";
                  }
                  uVar7 = FUN_180002f80(lVar6,1,DAT_181d7c9c0);
                  cVar3 = Single.TryParse(uVar7,local_res8,0);
                  if (!cVar3) {
                    return "Command format error";
                  }
                  lVar6 = *(int64 *)(*(int64 *)(DAT_181d91c88 + 184) + 8);
                  if (lVar6 != null) {
                    ChapterController.ChangeChapter(lVar6,(int)local_res8[0],0);
                    return 0;
                  }
                  goto LAB_180a04923;
                }
                cVar3 = FUN_1816fd990(lVar8,"fame",0);
                if (!cVar3) {
                  return "Wrong command";
                }
                if (*(int *)(lVar6 + 24) < 2) {
                  return "Command format error";
                }
                if (*(int *)(lVar6 + 24) < 3) {
                  if ((*(byte *)(DAT_181d942b0 + 0x133) & 4) == 0) goto LAB_180a03b33;
                  iVar12 = *(int *)(DAT_181d942b0 + 224);
                }
                else {
                  uVar10 = FUN_180002f80(lVar6,1,DAT_181d7c9c0);
                  if ((*(byte *)(DAT_181d942b0 + 0x133) & 4) == 0) goto LAB_180a03b33;
                  iVar12 = *(int *)(DAT_181d942b0 + 224);
                }
                if (iVar12 == 0) {
                  il2cpp_runtime_class_init();
                }
        LAB_180a03b33:
                lVar8 = Console.GetHeroData(uVar10,0);
                if (lVar8 == null) {
                  return "Hero not found";
                }
                uVar7 = 2;
                if (*(int *)(lVar6 + 24) < 3) {
                  uVar7 = 1;
                }
                uVar7 = FUN_180002f80(lVar6,uVar7,DAT_181d7c9c0);
                cVar3 = Single.TryParse(uVar7,local_res8,0);
                if (cVar3) {
                  HeroData.ChangeFame(lVar8);
                  return 0;
                }
                return "Command format error";
              }
              if (uVar4 != 0x2eeab1dd) {
                if (uVar4 != 0x32ae0843) {
                  return "Wrong command";
                }
                cVar3 = FUN_1816fd990(lVar8,"upgradebuilding",0);
                if (!cVar3) {
                  return "Wrong command";
                }
                if (*(int *)(lVar6 + 24) < 4) {
                  return "Command format error";
                }
                uVar7 = FUN_180002f80(lVar6,1,DAT_181d7c9c0);
                lVar8 = Console.GetAreaData(uVar7,0);
                if (lVar8 == null) {
                  return "Area not found";
                }
                uVar7 = FUN_180002f80(lVar6,2,DAT_181d7c9c0);
                lVar11 = AreaData.FindBuilding(lVar8,uVar7,0);
                if (lVar11 == null) {
                  return "Building not found";
                }
                uVar7 = FUN_180002f80(lVar6,3,DAT_181d7c9c0);
                cVar3 = Single.TryParse(uVar7,local_res8,0);
                if (!cVar3) {
                  return "Command format error";
                }
                if (local_res8[0] <= 0.0) {
                  return 0;
                }
                while( true ) {
                  lVar6 = FUN_18046c0a0(0);
                  if (lVar6 == null) break;
                  GameController.UpgradeBuilding(lVar6,lVar8,lVar11,1,0);
                  uVar4 = (int)uVar10 + 1;
                  uVar10 = (uint64)uVar4;
                  if (local_res8[0] <= (float)(int)uVar4) {
                    return 0;
                  }
                }
                goto LAB_180a04923;
              }
              cVar3 = FUN_1816fd990(lVar8,"heromaxlivingskill",0);
              if (!cVar3) {
                return "Wrong command";
              }
        LAB_180a03420:
              if (*(int *)(lVar6 + 24) < 2) {
                return "Command format error";
              }
              lVar8 = il2cpp_internal(DAT_181d6f030);
              FUN_180f58a90(lVar8,DAT_181d678f8);
              if (*(int *)(lVar6 + 24) < 4) {
                if (*(int *)(lVar6 + 24) != 3) {
                  lVar11 = FUN_18046c0a0(0);
                  if ((lVar11 != null) && (*(int64 *)(lVar11 + 32) != 0)) {
                    lVar11 = WorldData.Player(*(int64 *)(lVar11 + 32),0);
                    uVar13 = uVar10;
                    while( true ) {
                      lVar1 = *(int64 *)(pStatics_ef00 + 0x4a8);
                      if (lVar1 == null) break;
                      if (*(int *)(lVar1 + 24) <= (int)uVar13) goto LAB_180a03863;
                      if (lVar8 == null) break;
                      FUN_181814fa0(lVar8,uVar13,DAT_181d67a78);
                      uVar13 = (uint64)((int)uVar13 + 1);
                    }
                  }
                  goto LAB_180a04923;
                }
                lVar11 = *(int64 *)(pStatics_ef00 + 0x4a8);
                uVar7 = FUN_180002f80(lVar6,1,DAT_181d7c9c0);
                if (lVar11 == null) goto LAB_180a04923;
                cVar3 = FUN_1818279a0(lVar11,uVar7,DAT_181d7c4d0);
                if (!cVar3) {
                  uVar7 = FUN_180002f80(lVar6,1,DAT_181d7c9c0);
                  lVar11 = Console.GetHeroData(uVar7,0);
                  uVar13 = uVar10;
                  while( true ) {
                    lVar1 = *(int64 *)(pStatics_ef00 + 0x4a8);
                    if (lVar1 == null) break;
                    if (*(int *)(lVar1 + 24) <= (int)uVar13) goto LAB_180a03863;
                    if (lVar8 == null) break;
                    FUN_181814fa0(lVar8,uVar13,DAT_181d67a78);
                    uVar13 = (uint64)((int)uVar13 + 1);
                  }
                  goto LAB_180a04923;
                }
                lVar11 = FUN_18046c0a0(0);
                if ((lVar11 == null) || (*(int64 *)(lVar11 + 32) == 0)) goto LAB_180a04923;
                lVar11 = WorldData.Player(*(int64 *)(lVar11 + 32),0);
                lVar1 = *(int64 *)(pStatics_ef00 + 0x4a8);
                uVar7 = FUN_180002f80(lVar6,1,DAT_181d7c9c0);
                if (lVar1 == null) goto LAB_180a04923;
                cVar3 = FUN_1818279a0(lVar1,uVar7,DAT_181d7c4d0);
                if (cVar3) {
                  lVar1 = *(int64 *)(pStatics_ef00 + 0x4a8);
                  uVar7 = FUN_180002f80(lVar6,1,DAT_181d7c9c0);
                  goto joined_r0x000180a03831;
                }
              }
              else {
                uVar7 = FUN_180002f80(lVar6,1,DAT_181d7c9c0);
                lVar11 = Console.GetHeroData(uVar7,0);
                lVar1 = *(int64 *)(pStatics_ef00 + 0x4a8);
                uVar7 = FUN_180002f80(lVar6,2,DAT_181d7c9c0);
                if (lVar1 == null) goto LAB_180a04923;
                cVar3 = FUN_1818279a0(lVar1,uVar7,DAT_181d7c4d0);
                if (cVar3) {
                  lVar1 = *(int64 *)(pStatics_ef00 + 0x4a8);
                  uVar7 = FUN_180002f80(lVar6,2,DAT_181d7c9c0);
        joined_r0x000180a03831:
                  if ((lVar1 == null) || (uVar5 = FUN_1817ff280(lVar1,uVar7,DAT_181d7c648), lVar8 == null))
                  goto LAB_180a04923;
                  FUN_181814fa0(lVar8,uVar5,DAT_181d67a78);
                }
              }
        LAB_180a03863:
              if (lVar11 == null) {
                return "Hero not found";
              }
              if (lVar8 != null) {
                if (*(int *)(lVar8 + 24) == 0) {
                  return "Livingskill not found";
                }
                uVar7 = FUN_180002f80(lVar6,*(int *)(lVar6 + 24) + -1,DAT_181d7c9c0);
                cVar3 = Single.TryParse(uVar7,local_res8,0);
                if (cVar3) {
                  while (iVar12 = (int)uVar10, iVar12 < *(int *)(lVar8 + 24)) {
                    if (*(int *)(lVar6 + 24) == 0) {
                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                    }
                    cVar3 = FUN_1816fd990(*(uint64 *)(*(int64 *)(lVar6 + 16) + 32),
                                          "herolivingskill",0);
                    if (!cVar3) {
                      uVar5 = FUN_1800d6750(lVar8,uVar10);
                      in_stack_ffffffffffffff08 = 0;
                      HeroData.ChangeMaxLivingSkill(lVar11,uVar5,(int)local_res8[0],1,0);
                      uVar10 = (uint64)(iVar12 + 1);
                    }
                    else {
                      uVar5 = FUN_1800d6750(lVar8,uVar10);
                      in_stack_ffffffffffffff08 = in_stack_ffffffffffffff08 & 0xffffffffffffff00;
                      HeroData.ChangeLivingSkill
                                (lVar11,uVar5,local_res8[0],1,in_stack_ffffffffffffff08,0);
                      uVar10 = (uint64)(iVar12 + 1);
                    }
                  }
                  return 0;
                }
                return "Command format error";
              }
              goto LAB_180a04923;
            }
            if (0xdab8e32 < uVar4) {
              if (uVar4 < 0x172c57d6) {
                if (uVar4 == 0xf0a2f84) {
                  cVar3 = FUN_1816fd990(lVar8,"changeyear",0);
                  if (!cVar3) {
                    return "Wrong command";
                  }
                  if (*(int *)(lVar6 + 24) < 2) {
                    return "Command format error";
                  }
                  uVar7 = FUN_180002f80(lVar6,1,DAT_181d7c9c0);
                  cVar3 = Single.TryParse(uVar7,local_res8,0);
                  if (!cVar3) {
                    return "Command format error";
                  }
                  lVar6 = FUN_18046c0a0(0);
                  if (lVar6 != null) {
                    GameController.ChangeYearDirect(lVar6,(int)local_res8[0],0);
                    return 0;
                  }
                }
                else {
                  if (uVar4 != 0x172c57d5) {
                    return "Wrong command";
                  }
                  cVar3 = FUN_1816fd990(lVar8,"changeday",0);
                  if (!cVar3) {
                    return "Wrong command";
                  }
                  if (*(int *)(lVar6 + 24) < 2) {
                    return "Command format error";
                  }
                  uVar7 = FUN_180002f80(lVar6,1,DAT_181d7c9c0);
                  cVar3 = Single.TryParse(uVar7,local_res8,0);
                  if (!cVar3) {
                    return "Command format error";
                  }
                  lVar6 = FUN_18046c0a0(0);
                  if (lVar6 != null) {
                    GameController.ChangeDayDirect(lVar6,(int)local_res8[0],0);
                    return 0;
                  }
                }
              }
              else if (uVar4 == 0x18c080ed) {
                cVar3 = FUN_1816fd990(lVar8,"changemonth",0);
                if (!cVar3) {
                  return "Wrong command";
                }
                if (*(int *)(lVar6 + 24) < 2) {
                  return "Command format error";
                }
                uVar7 = FUN_180002f80(lVar6,1,DAT_181d7c9c0);
                cVar3 = Single.TryParse(uVar7,local_res8,0);
                if (!cVar3) {
                  return "Command format error";
                }
                lVar6 = FUN_18046c0a0(0);
                if (lVar6 != null) {
                  GameController.ChangeMonthDirect(lVar6,(int)local_res8[0],0);
                  return 0;
                }
              }
              else {
                if (uVar4 != 0x1e6a4802) {
                  return "Wrong command";
                }
                cVar3 = FUN_1816fd990(lVar8,"creatworldevent",0);
                if (!cVar3) {
                  return "Wrong command";
                }
                if (*(int *)(lVar6 + 24) < 2) {
                  return "Command format error";
                }
                uVar7 = FUN_180002f80(lVar6,1,DAT_181d7c9c0);
                cVar3 = Single.TryParse(uVar7,local_res8,0);
                if (!cVar3) {
                  return "Command format error";
                }
                lVar6 = **(int64 **)(DAT_181d90bb8 + 184);
                lVar8 = FUN_18046c540(0);
                if ((lVar8 != null) &&
                   (uVar7 = RandomEventController.GetWorldEventDataBase(lVar8,(int)local_res8[0],0),
                   lVar6 != null)) {
                  WorldEventController.CreateWorldEvent(lVar6,uVar7,0);
                  return 0;
                }
              }
              goto LAB_180a04923;
            }
            if (0x4d8cebe < uVar4) {
              if (uVar4 == 0xb013d25) {
                cVar3 = FUN_1816fd990(lVar8,"stopwar",0);
                if (!cVar3) {
                  return "Wrong command";
                }
                if (*(int *)(lVar6 + 24) < 3) {
                  return "Command format error";
                }
                uVar7 = FUN_180002f80(lVar6,1,DAT_181d7c9c0);
                lVar8 = Console.GetForceData(uVar7,0);
                if (lVar8 == null) {
                  return "Force not found";
                }
                uVar7 = FUN_180002f80(lVar6,2,DAT_181d7c9c0);
                cVar3 = Single.TryParse(uVar7,local_res8,0);
                if (!cVar3) {
                  return "Command format error";
                }
                lVar6 = FUN_18046c0a0(0);
                if (((lVar6 != null) && (*(int64 *)(lVar6 + 32) != 0)) &&
                   (lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0)) != null) {
                  ForceData.SetForceStopWarTime
                            (lVar8,*(uint32 *)(lVar6 + 132),(int)local_res8[0],1,1,0);
                  return 0;
                }
                goto LAB_180a04923;
              }
              if (uVar4 != 0xdab8e32) {
                return "Wrong command";
              }
              cVar3 = FUN_1816fd990(lVar8,"loyal",0);
              if (!cVar3) {
                return "Wrong command";
              }
              if (*(int *)(lVar6 + 24) < 2) {
                return "Command format error";
              }
              if (*(int *)(lVar6 + 24) < 3) {
                if ((*(byte *)(DAT_181d942b0 + 0x133) & 4) == 0) goto LAB_180a04156;
                iVar12 = *(int *)(DAT_181d942b0 + 224);
              }
              else {
                uVar10 = FUN_180002f80(lVar6,1,DAT_181d7c9c0);
                if ((*(byte *)(DAT_181d942b0 + 0x133) & 4) == 0) goto LAB_180a04156;
                iVar12 = *(int *)(DAT_181d942b0 + 224);
              }
              if (iVar12 == 0) {
                il2cpp_runtime_class_init();
              }
        LAB_180a04156:
              lVar8 = Console.GetHeroData(uVar10,0);
              if (lVar8 == null) {
                return "Hero not found";
              }
              uVar7 = 2;
              if (*(int *)(lVar6 + 24) < 3) {
                uVar7 = 1;
              }
              uVar7 = FUN_180002f80(lVar6,uVar7,DAT_181d7c9c0);
              cVar3 = Single.TryParse(uVar7,local_res8,0);
              if (cVar3) {
                HeroData.ChangeLoyal(lVar8);
                return 0;
              }
              return "Command format error";
            }
            if (uVar4 != 0x45a193e) {
              if (uVar4 != 0x4d8cebe) {
                return "Wrong command";
              }
              cVar3 = FUN_1816fd990(lVar8,"herofightskill",0);
              if (!cVar3) {
                return "Wrong command";
              }
              goto LAB_180a04338;
            }
            cVar3 = FUN_1816fd990(lVar8,"heroforcelv",0);
            if (!cVar3) {
              return "Wrong command";
            }
            if (*(int *)(lVar6 + 24) < 2) {
              return "Command format error";
            }
            if (*(int *)(lVar6 + 24) < 3) {
              if ((*(byte *)(DAT_181d942b0 + 0x133) & 4) != 0) {
                iVar12 = *(int *)(DAT_181d942b0 + 224);
                goto LAB_180a0423e;
              }
            }
            else {
              uVar10 = FUN_180002f80(lVar6,1,DAT_181d7c9c0);
              if ((*(byte *)(DAT_181d942b0 + 0x133) & 4) != 0) {
                iVar12 = *(int *)(DAT_181d942b0 + 224);
        LAB_180a0423e:
                if (iVar12 == 0) {
                  il2cpp_runtime_class_init();
                }
              }
            }
            lVar8 = Console.GetHeroData(uVar10,0);
            if (lVar8 == null) {
              return "Hero not found";
            }
            uVar7 = 2;
            if (*(int *)(lVar6 + 24) < 3) {
              uVar7 = 1;
            }
            uVar7 = FUN_180002f80(lVar6,uVar7,DAT_181d7c9c0);
            cVar3 = Single.TryParse(uVar7,local_res8,0);
            if (!cVar3) {
              return "Command format error";
            }
            if (((local_res8[0] <= 5.0) || (lVar6 = HeroData.GetForce(lVar8,0,0)) == null) ||
               (*(char *)(lVar8 + 180) != false)) {
              HeroData.ChangeHeroForceLv(lVar8,(int)local_res8[0],1,0);
              return 0;
            }
            lVar6 = HeroData.GetForce(lVar8,0,0);
            if (lVar6 != null) {
              ForceData.SetLeader(lVar6,lVar8,0,0);
              return 0;
            }
            goto LAB_180a04923;
          }
          if (uVar4 < 0x6499e6b3) {
            if (uVar4 < 0x56692a6c) {
              if (0x4d24a2e2 < uVar4) {
                if (uVar4 == 0x52b454fb) {
                  cVar3 = FUN_1816fd990(lVar8,"clearallach",0);
                  uVar13 = uVar10;
                  if (!cVar3) {
                    return "Wrong command";
                  }
                  while( true ) {
                    lVar6 = FUN_18046c100(0);
                    if ((lVar6 == null) || (*(int64 *)(lVar6 + 0x1c0) == 0)) goto LAB_180a04923;
                    if (*(int *)(*(int64 *)(lVar6 + 0x1c0) + 24) <= (int)uVar13) break;
                    lVar6 = *(int64 *)(pStatics_e010 + 8);
                    if (lVar6 == null) goto LAB_180a04923;
                    lVar6 = *(int64 *)(lVar6 + 16);
                    uVar7 = Int32.ToString(local_res20,0);
                    uVar7 = String.Concat("AchData",uVar7,0);
                    if (lVar6 == null) goto LAB_180a04923;
                    PlayerPrefDictionary.SetKey(lVar6,uVar7,0,0);
                    lVar6 = *(int64 *)(pStatics_e010 + 8);
                    if (lVar6 == null) goto LAB_180a04923;
                    lVar6 = *(int64 *)(lVar6 + 16);
                    uVar7 = Int32.ToString(local_res20,0);
                    String.Concat("AchFinished",uVar7,0);
                    if (lVar6 == null) goto LAB_180a04923;
                    PlayerPrefDictionary.SetKey(lVar6);
                    local_res20[0] = local_res20[0] + 1;
                    uVar13 = (uint64)local_res20[0];
                  }
                  lVar6 = FUN_18046c100(0);
                  if (lVar6 != null) {
                    GameDataController.SavePlayerprefData(lVar6,0);
                    if (**(int **)(DAT_181d4ef00 + 184) == 0) {
                      SteamUserStats.ResetAllStats(1,0);
                      while( true ) {
                        lVar6 = FUN_18046c100(0);
                        if ((lVar6 == null) || (*(int64 *)(lVar6 + 0x1c0) == 0)) break;
                        if (*(int *)(*(int64 *)(lVar6 + 0x1c0) + 24) <= (int)uVar10) {
                          SteamUserStats.RequestCurrentStats(0);
                          return 0;
                        }
                        uVar7 = Int32.ToString(&local_c8,0);
                        uVar7 = String.Concat("Ach",uVar7,0);
                        SteamUserStats.ClearAchievement(uVar7);
                        local_c8 = local_c8 + 1;
                        uVar10 = (uint64)local_c8;
                      }
                    }
                    else {
                      if (**(int **)(DAT_181d4ef00 + 184) != 1) {
                        return 0;
                      }
                      lVar6 = WegameStatsAndAchievements.get_Instance(0);
                      if (lVar6 != null) {
                        WegameStatsAndAchievements.ResetPlayerAchievement(lVar6,0);
                        return 0;
                      }
                    }
                  }
                }
                else {
                  if (uVar4 != 0x56692a6b) {
                    return "Wrong command";
                  }
                  cVar3 = FUN_1816fd990(lVar8,"plothappened",0);
                  if (!cVar3) {
                    return "Wrong command";
                  }
                  if (*(int *)(lVar6 + 24) < 2) {
                    return "Command format error";
                  }
                  uVar7 = FUN_180002f80(lVar6,1,DAT_181d7c9c0);
                  cVar3 = Single.TryParse(uVar7,local_res8,0);
                  if (!cVar3) {
                    return "Command format error";
                  }
                  lVar6 = FUN_18046c0a0(0);
                  if (((lVar6 != null) && (*(int64 *)(lVar6 + 32) != 0)) &&
                     (lVar6 = *(int64 *)(*(int64 *)(lVar6 + 32) + 216)) != null) {
                    cVar3 = FUN_1808ab750(lVar6,(int)local_res8[0],DAT_181d99e30);
                    local_a8 = (int)local_res8[0];
                    if (!cVar3) {
                      uVar7 = il2cpp_value_box(DAT_181d5b2f8,&local_a8);
                      uVar10 = String.Format("Plot {0} not happened",uVar7,0);
                      return uVar10;
                    }
                    local_a4[0] = local_a8;
                    uVar7 = il2cpp_value_box(DAT_181d5b2f8,local_a4);
                    lVar6 = FUN_18046c0a0(0);
                    if (((lVar6 != null) && (*(int64 *)(lVar6 + 32) != 0)) &&
                       ((lVar6 = *(int64 *)(*(int64 *)(lVar6 + 32) + 216), lVar6 != null &&
                        (lVar6 = FUN_1817cc780(lVar6,(int)local_res8[0],DAT_181d99eb8)) != null))) {
                      uVar9 = TimeData.GetDescribe(lVar6,0);
                      uVar10 = String.Format("Plot {0} happened at {1}",uVar7,uVar9,0);
                      return uVar10;
                    }
                  }
                }
                goto LAB_180a04923;
              }
              if (uVar4 == 0x48e22e00) {
                cVar3 = FUN_1816fd990(lVar8,"changemp",0);
                if (!cVar3) {
                  return "Wrong command";
                }
                goto LAB_180a02df4;
              }
              if (uVar4 != 0x4d24a2e2) {
                return "Wrong command";
              }
              cVar3 = FUN_1816fd990(lVar8,"getbook",0);
              uVar5 = (uint32)(in_stack_ffffffffffffff08 >> 32);
              if (!cVar3) {
                return "Wrong command";
              }
              if (*(int *)(lVar6 + 24) < 3) {
                return "Command format error";
              }
              uVar7 = FUN_180002f80(lVar6,1,DAT_181d7c9c0);
              cVar3 = Single.TryParse(uVar7,local_res8,0);
              if (!cVar3) {
                return "Command format error";
              }
              uVar7 = FUN_180002f80(lVar6,2,DAT_181d7c9c0);
              cVar3 = Single.TryParse(uVar7,local_res18,0);
              if (!cVar3) {
                return "Command format error";
              }
              lVar6 = FUN_18046c0a0(0);
              if ((lVar6 == null) || (*(int64 *)(lVar6 + 32) == 0)) goto LAB_180a04923;
              lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0);
              lVar8 = new ItemData(3);
              if (lVar8 == null) goto LAB_180a04923;
              uVar7 = ItemData.SetBookData(lVar8,(int)local_res8[0],(int)local_res18[0],0);
            }
            else {
              if (uVar4 < 0x56fc8215) {
                if (uVar4 == 0x56f745ac) {
                  cVar3 = FUN_1816fd990(lVar8,"seeallrandomevent",0);
                  if (!cVar3) {
                    return "Wrong command";
                  }
                  while( true ) {
                    lVar6 = FUN_18046c0a0(0);
                    if (((lVar6 == null) || (*(int64 *)(lVar6 + 32) == 0)) ||
                       (lVar6 = *(int64 *)(*(int64 *)(lVar6 + 32) + 96)) == null) break;
                    if (*(int *)(lVar6 + 24) <= (int)uVar10) {
                      return 0;
                    }
                    lVar6 = FUN_18046c0a0(0);
                    if (((lVar6 == null) || (*(int64 *)(lVar6 + 32) == 0)) ||
                       ((lVar6 = *(int64 *)(*(int64 *)(lVar6 + 32) + 96), lVar6 == null ||
                        (lVar6 = FUN_180002f80(lVar6,uVar10,DAT_181d5e680)) == null))) break;
                    *(uint8 *)(lVar6 + 96) = 1;
                    uVar10 = (uint64)((int)uVar10 + 1);
                  }
                }
                else {
                  if (uVar4 != 0x56fc8214) {
                    return "Wrong command";
                  }
                  cVar3 = FUN_1816fd990(lVar8,"worldeventhappened",0);
                  if (!cVar3) {
                    return "Wrong command";
                  }
                  if (*(int *)(lVar6 + 24) < 2) {
                    return "Command format error";
                  }
                  uVar7 = FUN_180002f80(lVar6,1,DAT_181d7c9c0);
                  cVar3 = Single.TryParse(uVar7,local_res8,0);
                  if (!cVar3) {
                    return "Command format error";
                  }
                  lVar6 = FUN_18046c0a0(0);
                  if (((lVar6 != null) && (*(int64 *)(lVar6 + 32) != 0)) &&
                     (lVar6 = *(int64 *)(*(int64 *)(lVar6 + 32) + 248)) != null) {
                    cVar3 = FUN_1808ab750(lVar6,(int)local_res8[0],DAT_181d99e30);
                    aiStack_bc[3] = (int)local_res8[0];
                    if (!cVar3) {
                      uVar7 = il2cpp_value_box(DAT_181d5b2f8,aiStack_bc + 3);
                      uVar10 = String.Format("WorldEvent {0} not happened",uVar7,0);
                      return uVar10;
                    }
                    local_ac = aiStack_bc[3];
                    uVar7 = il2cpp_value_box(DAT_181d5b2f8,&local_ac);
                    lVar6 = FUN_18046c0a0(0);
                    if (((lVar6 != null) && (*(int64 *)(lVar6 + 32) != 0)) &&
                       ((lVar6 = *(int64 *)(*(int64 *)(lVar6 + 32) + 248), lVar6 != null &&
                        (lVar6 = FUN_1817cc780(lVar6,(int)local_res8[0],DAT_181d99eb8)) != null))) {
                      uVar9 = TimeData.GetDescribe(lVar6,0);
                      uVar10 = String.Format("WorldEvent {0} happened at {1}",uVar7,uVar9,0);
                      return uVar10;
                    }
                  }
                }
                goto LAB_180a04923;
              }
              if (uVar4 == 0x5983ad73) {
                cVar3 = FUN_1816fd990(lVar8,"upgradeallskill",0);
                if (!cVar3) {
                  return "Wrong command";
                }
                if (*(int *)(lVar6 + 24) < 2) {
                  return "Command format error";
                }
                if (*(int *)(lVar6 + 24) < 3) {
                  if ((*(byte *)(DAT_181d942b0 + 0x133) & 4) != 0) {
                    iVar12 = *(int *)(DAT_181d942b0 + 224);
                    goto LAB_180a02433;
                  }
                }
                else {
                  uVar10 = FUN_180002f80(lVar6,1,DAT_181d7c9c0);
                  if ((*(byte *)(DAT_181d942b0 + 0x133) & 4) != 0) {
                    iVar12 = *(int *)(DAT_181d942b0 + 224);
        LAB_180a02433:
                    if (iVar12 == 0) {
                      il2cpp_runtime_class_init();
                    }
                  }
                }
                lVar8 = Console.GetHeroData(uVar10,0);
                if (lVar8 == null) {
                  return "Hero not found";
                }
                uVar7 = 2;
                if (*(int *)(lVar6 + 24) < 3) {
                  uVar7 = 1;
                }
                uVar7 = FUN_180002f80(lVar6,uVar7,DAT_181d7c9c0);
                cVar3 = Single.TryParse(uVar7,local_res8,0);
                if (!cVar3) {
                  return "Command format error";
                }
                lVar6 = FUN_18046c440(0);
                uVar7 = *(uint64 *)(lVar8 + 104);
                uVar9 = Single.ToString(local_res8,0);
                uVar7 = String.Concat(uVar7,"-",uVar9,0);
                if (lVar6 != null) {
                  PlotController.ForceUpgradeAllHeroSkill(lVar6,uVar7,0);
                  return 0;
                }
                goto LAB_180a04923;
              }
              if (uVar4 == 0x5c6e1222) {
                cVar3 = FUN_1816fd990(lVar8,"clear",0);
                if (!cVar3) {
                  return "Wrong command";
                }
                *(uint32 *)(pStatics_42b0 + 24) = 0xffffffff;
                lVar6 = *(int64 *)(pStatics_42b0 + 32);
                if (lVar6 != null) {
                  FUN_180f56130(lVar6,DAT_181d7c450);
                  return "cls";
                }
                goto LAB_180a04923;
              }
              if (uVar4 != 0x6499e6b2) {
                return "Wrong command";
              }
              cVar3 = FUN_1816fd990(lVar8,"gethelmet",0);
              if (!cVar3) {
                return "Wrong command";
              }
              if (*(int *)(lVar6 + 24) < 3) {
                return "Command format error";
              }
              uVar7 = FUN_180002f80(lVar6,1,DAT_181d7c9c0);
              cVar3 = Single.TryParse(uVar7,local_res8,0);
              if (!cVar3) {
                return "Command format error";
              }
              uVar7 = FUN_180002f80(lVar6,2,DAT_181d7c9c0);
              cVar3 = Single.TryParse(uVar7,local_res18,0);
              if (!cVar3) {
                return "Command format error";
              }
              lVar6 = FUN_18046c0a0(0);
              if ((lVar6 == null) || (*(int64 *)(lVar6 + 32) == 0)) goto LAB_180a04923;
              lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0);
              lVar8 = FUN_18046c0a0(0);
              if (lVar8 == null) goto LAB_180a04923;
              in_stack_ffffffffffffff10 = 0;
              uVar5 = 0;
              uVar7 = GameController.GenerateHelmet(lVar8,(int)local_res18[0],(int)local_res8[0],0,0,0);
            }
          }
          else if (uVar4 < 0x72a6679b) {
            if (uVar4 < 0x6a4c8d2c) {
              uVar7 = "changehp";
              if (uVar4 != 0x66ef292d) {
                if (uVar4 != 0x6a4c8d2b) {
                  return "Wrong command";
                }
                cVar3 = FUN_1816fd990(lVar8,"herocontribution",0);
                if (!cVar3) {
                  return "Wrong command";
                }
                if (*(int *)(lVar6 + 24) < 2) {
                  return "Command format error";
                }
                if (*(int *)(lVar6 + 24) < 3) {
                  uVar7 = 0;
                }
                else {
                  uVar7 = FUN_180002f80(lVar6,1,DAT_181d7c9c0);
                }
                lVar8 = Console.GetHeroData(uVar7,0);
                if (lVar8 != null) {
                  uVar7 = 2;
                  if (*(int *)(lVar6 + 24) < 3) {
                    uVar7 = 1;
                  }
                  uVar7 = FUN_180002f80(lVar6,uVar7,DAT_181d7c9c0);
                  cVar3 = Single.TryParse(uVar7,local_res8,0);
                  if (cVar3) {
                    HeroData.ChangeForceContribution(lVar8);
                    return 0;
                  }
                  return "Command format error";
                }
                return "Hero not found";
              }
        LAB_180a02281:
              cVar3 = FUN_1816fd990(lVar8,uVar7,0);
              if (!cVar3) {
                return "Wrong command";
              }
        LAB_180a02df4:
              if (*(int *)(lVar6 + 24) < 2) {
                return "Command format error";
              }
              if (*(int *)(lVar6 + 24) < 3) {
                uVar7 = 0;
              }
              else {
                uVar7 = FUN_180002f80(lVar6,1,DAT_181d7c9c0);
              }
              lVar8 = Console.GetHeroData(uVar7,0);
              if (lVar8 == null) {
                return "Hero not found";
              }
              uVar7 = 2;
              if (*(int *)(lVar6 + 24) < 3) {
                uVar7 = 1;
              }
              uVar7 = FUN_180002f80(lVar6,uVar7,DAT_181d7c9c0);
              cVar3 = Single.TryParse(uVar7,local_res8,0);
              if (!cVar3) {
                return "Command format error";
              }
              uVar7 = FUN_180002f80(lVar6,0,DAT_181d7c9c0);
              cVar3 = FUN_1816fd990(uVar7,"changehp",0);
              if (cVar3) {
                HeroData.ChangeHp(lVar8);
                return 0;
              }
              uVar7 = FUN_180002f80(lVar6,0,DAT_181d7c9c0);
              cVar3 = FUN_1816fd990(uVar7,"changemp",0);
              if (cVar3) {
                HeroData.ChangeMana(lVar8);
                return 0;
              }
              HeroData.ChangePower();
              return 0;
            }
            if (uVar4 == 0x6dda4e1a) {
              cVar3 = FUN_1816fd990(lVar8,"conquer",0);
              if (!cVar3) {
                return "Wrong command";
              }
              if (*(int *)(lVar6 + 24) < 2) {
                return "Command format error";
              }
              if (*(int *)(lVar6 + 24) < 3) {
                uVar7 = 0;
              }
              else {
                uVar7 = FUN_180002f80(lVar6,1,DAT_181d7c9c0);
              }
              lVar8 = Console.GetForceData(uVar7,0);
              uVar7 = FUN_180002f80(lVar6,*(int *)(lVar6 + 24) + -1,DAT_181d7c9c0);
              lVar6 = Console.GetAreaData(uVar7,0);
              if (lVar8 == null) {
                return "Force not found";
              }
              if (lVar6 == null) {
                return "Area not found";
              }
              if (*(int *)(lVar6 + 72) != 2) {
                if (*(int *)(lVar6 + 112) != *(int *)(lVar8 + 16)) {
                  ForceData.ForceConquerArea(lVar8,lVar6,1,0);
                  return 0;
                }
                return "Area already belong to force";
              }
              lVar11 = AreaData.GetForce(lVar6,0);
              if (lVar11 != null) {
                if (*(int *)(lVar11 + 60) == *(int *)(lVar8 + 16)) {
                  return "Area already belong to force";
                }
                lVar11 = FUN_18046c0a0(0);
                uVar7 = AreaData.GetForce(lVar6,0);
                if (lVar11 != null) {
                  GameController.SetForceMaster(lVar11,lVar8,uVar7,1,0);
                  return 0;
                }
              }
              goto LAB_180a04923;
            }
            if (uVar4 != 0x72a6679a) {
              return "Wrong command";
            }
            cVar3 = FUN_1816fd990(lVar8,"gettreasure",0);
            if (!cVar3) {
              return "Wrong command";
            }
            if (*(int *)(lVar6 + 24) < 3) {
              return "Command format error";
            }
            uVar7 = FUN_180002f80(lVar6,1,DAT_181d7c9c0);
            cVar3 = Single.TryParse(uVar7,local_res8,0);
            if (!cVar3) {
              return "Command format error";
            }
            uVar7 = FUN_180002f80(lVar6,2,DAT_181d7c9c0);
            cVar3 = Single.TryParse(uVar7,local_res18,0);
            if (!cVar3) {
              return "Command format error";
            }
            lVar6 = FUN_18046c0a0(0);
            if ((lVar6 == null) || (*(int64 *)(lVar6 + 32) == 0)) goto LAB_180a04923;
            lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0);
            lVar8 = FUN_18046c0a0(0);
            if (lVar8 == null) goto LAB_180a04923;
            uVar5 = 0;
            uVar7 = GameController.GenerateTreasure(lVar8,(int)local_res8[0],(int)local_res18[0],0,0);
          }
          else {
            if (0x77a43627 < uVar4) {
              if (uVar4 == 0x800eacaf) {
                cVar3 = FUN_1816fd990(lVar8,"contribution",0);
                if (!cVar3) {
                  return "Wrong command";
                }
                if (*(int *)(lVar6 + 24) < 2) {
                  return "Command format error";
                }
                if (*(int *)(lVar6 + 24) < 3) {
                  uVar7 = 0;
                }
                else {
                  uVar7 = FUN_180002f80(lVar6,1,DAT_181d7c9c0);
                }
                lVar8 = Console.GetForceData(uVar7,0);
                if (lVar8 == null) {
                  return "Force not found";
                }
                uVar7 = 2;
                if (*(int *)(lVar6 + 24) < 3) {
                  uVar7 = 1;
                }
                uVar7 = FUN_180002f80(lVar6,uVar7,DAT_181d7c9c0);
                cVar3 = Single.TryParse(uVar7,local_res8,0);
                if (!cVar3) {
                  return "Command format error";
                }
                lVar6 = FUN_18046c0a0(0);
                if (((lVar6 != null) && (*(int64 *)(lVar6 + 32) != 0)) &&
                   (lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0)) != null) {
                  HeroData.ChangeForceContribution(lVar6);
                  return 0;
                }
                goto LAB_180a04923;
              }
              if (uVar4 != 0x83b1baad) {
                if (uVar4 != 0x8e54a39c) {
                  return "Wrong command";
                }
                cVar3 = FUN_1816fd990(lVar8,"upgradeskill",0);
                uVar5 = (uint32)(in_stack_ffffffffffffff08 >> 32);
                if (!cVar3) {
                  return "Wrong command";
                }
                if (*(int *)(lVar6 + 24) < 3) {
                  return "Command format error";
                }
                if (*(int *)(lVar6 + 24) < 4) {
                  uVar7 = 0;
                }
                else {
                  uVar7 = FUN_180002f80(lVar6,1,DAT_181d7c9c0);
                }
                lVar8 = Console.GetHeroData(uVar7,0);
                if (lVar8 == null) {
                  return "Hero not found";
                }
                uVar7 = 2;
                if (*(int *)(lVar6 + 24) < 4) {
                  uVar7 = 1;
                }
                uVar7 = FUN_180002f80(lVar6,uVar7,DAT_181d7c9c0);
                cVar3 = FUN_180d6ca90(uVar7,0);
                if (cVar3) {
                  return "Skill not found";
                }
                lVar11 = FUN_18046c100(0);
                if (lVar11 != null) {
                  iVar12 = GameDataController.GetSkillID(lVar11,uVar7,0);
                  if (iVar12 < 0) {
                    return "Skill not found";
                  }
                  uVar7 = 3;
                  if (*(int *)(lVar6 + 24) < 4) {
                    uVar7 = 2;
                  }
                  uVar7 = FUN_180002f80(lVar6,uVar7,DAT_181d7c9c0);
                  cVar3 = Single.TryParse(uVar7,local_res8,0);
                  if (!cVar3) {
                    return "Command format error";
                  }
                  lVar6 = FUN_18046c440(0);
                  if (lVar6 != null) {
                    PlotController.PlotUpgradeHeroSkill
                              (lVar6,lVar8,iVar12,0,CONCAT44(uVar5,(int)local_res8[0]),1,1,0);
                    return 0;
                  }
                }
                goto LAB_180a04923;
              }
              cVar3 = FUN_1816fd990(lVar8,"heroattri",0);
        joined_r0x000180a01713:
              if (!cVar3) {
                return "Wrong command";
              }
              if (*(int *)(lVar6 + 24) < 2) {
                return "Command format error";
              }
              lVar8 = il2cpp_internal(DAT_181d6f030);
              FUN_180f58a90(lVar8,DAT_181d678f8);
              if (*(int *)(lVar6 + 24) < 4) {
                if (*(int *)(lVar6 + 24) != 3) {
                  lVar11 = FUN_18046c0a0(0);
                  if ((lVar11 != null) && (*(int64 *)(lVar11 + 32) != 0)) {
                    lVar11 = WorldData.Player(*(int64 *)(lVar11 + 32),0);
                    uVar13 = uVar10;
                    while( true ) {
                      lVar1 = *(int64 *)(pStatics_ef00 + 0x490);
                      if (lVar1 == null) break;
                      if (*(int *)(lVar1 + 24) <= (int)uVar13) goto LAB_180a01b53;
                      if (lVar8 == null) break;
                      FUN_181814fa0(lVar8,uVar13,DAT_181d67a78);
                      uVar13 = (uint64)((int)uVar13 + 1);
                    }
                  }
                  goto LAB_180a04923;
                }
                lVar11 = *(int64 *)(pStatics_ef00 + 0x490);
                uVar7 = FUN_180002f80(lVar6,1,DAT_181d7c9c0);
                if (lVar11 == null) goto LAB_180a04923;
                cVar3 = FUN_1818279a0(lVar11,uVar7,DAT_181d7c4d0);
                if (!cVar3) {
                  uVar7 = FUN_180002f80(lVar6,1,DAT_181d7c9c0);
                  lVar11 = Console.GetHeroData(uVar7,0);
                  uVar13 = uVar10;
                  while( true ) {
                    lVar1 = *(int64 *)(pStatics_ef00 + 0x490);
                    if (lVar1 == null) break;
                    if (*(int *)(lVar1 + 24) <= (int)uVar13) goto LAB_180a01b53;
                    if (lVar8 == null) break;
                    FUN_181814fa0(lVar8,uVar13,DAT_181d67a78);
                    uVar13 = (uint64)((int)uVar13 + 1);
                  }
                  goto LAB_180a04923;
                }
                lVar11 = FUN_18046c0a0(0);
                if ((lVar11 == null) || (*(int64 *)(lVar11 + 32) == 0)) goto LAB_180a04923;
                lVar11 = WorldData.Player(*(int64 *)(lVar11 + 32),0);
                lVar1 = *(int64 *)(pStatics_ef00 + 0x490);
                uVar7 = FUN_180002f80(lVar6,1,DAT_181d7c9c0);
                if (lVar1 == null) goto LAB_180a04923;
                cVar3 = FUN_1818279a0(lVar1,uVar7,DAT_181d7c4d0);
                if (cVar3) {
                  lVar1 = *(int64 *)(pStatics_ef00 + 0x490);
                  uVar7 = FUN_180002f80(lVar6,1,DAT_181d7c9c0);
                  goto joined_r0x000180a01b21;
                }
              }
              else {
                uVar7 = FUN_180002f80(lVar6,1,DAT_181d7c9c0);
                lVar11 = Console.GetHeroData(uVar7,0);
                lVar1 = *(int64 *)(pStatics_ef00 + 0x490);
                uVar7 = FUN_180002f80(lVar6,2,DAT_181d7c9c0);
                if (lVar1 == null) goto LAB_180a04923;
                cVar3 = FUN_1818279a0(lVar1,uVar7,DAT_181d7c4d0);
                if (cVar3) {
                  lVar1 = *(int64 *)(pStatics_ef00 + 0x490);
                  uVar7 = FUN_180002f80(lVar6,2,DAT_181d7c9c0);
        joined_r0x000180a01b21:
                  if ((lVar1 == null) || (uVar5 = FUN_1817ff280(lVar1,uVar7,DAT_181d7c648), lVar8 == null))
                  goto LAB_180a04923;
                  FUN_181814fa0(lVar8,uVar5,DAT_181d67a78);
                }
              }
        LAB_180a01b53:
              if (lVar11 == null) {
                return "Hero not found";
              }
              if (lVar8 != null) {
                if (*(int *)(lVar8 + 24) == 0) {
                  return "Attri not found";
                }
                uVar7 = FUN_180002f80(lVar6,*(int *)(lVar6 + 24) + -1,DAT_181d7c9c0);
                cVar3 = Single.TryParse(uVar7,local_res8,0);
                if (cVar3) {
                  while (iVar12 = (int)uVar10, iVar12 < *(int *)(lVar8 + 24)) {
                    if (*(int *)(lVar6 + 24) == 0) {
                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                    }
                    cVar3 = FUN_1816fd990(*(uint64 *)(*(int64 *)(lVar6 + 16) + 32),
                                          "heroattri",0);
                    if (!cVar3) {
                      uVar5 = FUN_1800d6750(lVar8,uVar10);
                      in_stack_ffffffffffffff08 = 0;
                      HeroData.ChangeMaxAttri(lVar11,uVar5,(int)local_res8[0],1,0);
                      uVar10 = (uint64)(iVar12 + 1);
                    }
                    else {
                      uVar5 = FUN_1800d6750(lVar8,uVar10);
                      in_stack_ffffffffffffff08 = in_stack_ffffffffffffff08 & 0xffffffffffffff00;
                      HeroData.ChangeAttri(lVar11,uVar5,local_res8[0],1,in_stack_ffffffffffffff08,0);
                      uVar10 = (uint64)(iVar12 + 1);
                    }
                  }
                  return 0;
                }
                return "Command format error";
              }
              goto LAB_180a04923;
            }
            if (uVar4 != 0x75cd0ce8) {
              if (uVar4 != 0x77a43627) {
                return "Wrong command";
              }
              cVar3 = FUN_1816fd990(lVar8,"creatplotevent",0);
              if (!cVar3) {
                return "Wrong command";
              }
              if (*(int *)(lVar6 + 24) < 2) {
                return "Command format error";
              }
              uVar7 = FUN_180002f80(lVar6,1,DAT_181d7c9c0);
              cVar3 = Single.TryParse(uVar7,local_res8,0);
              if (!cVar3) {
                return "Command format error";
              }
              if (*pStatics_0cc8 != 0) {
                WorldPlotEventController.StartNewWorldPlotEventFromDataBase
                          (*pStatics_0cc8,(int)local_res8[0],0);
                return 0;
              }
              goto LAB_180a04923;
            }
            cVar3 = FUN_1816fd990(lVar8,"gethorse",0);
            uVar5 = (uint32)(in_stack_ffffffffffffff08 >> 32);
            if (!cVar3) {
              return "Wrong command";
            }
            if (*(int *)(lVar6 + 24) < 2) {
              return "Command format error";
            }
            uVar7 = FUN_180002f80(lVar6,1,DAT_181d7c9c0);
            cVar3 = Single.TryParse(uVar7,local_res8,0);
            if (!cVar3) {
              return "Command format error";
            }
            lVar6 = FUN_18046c0a0(0);
            if ((lVar6 == null) || (*(int64 *)(lVar6 + 32) == 0)) goto LAB_180a04923;
            lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0);
            lVar8 = FUN_18046c0a0(0);
            if (lVar8 == null) goto LAB_180a04923;
            uVar7 = GameController.GenerateHorseData(lVar8,(int)local_res8[0],0,0);
          }
        joined_r0x000180a03079:
          if (lVar6 != null) {
            HeroData.GetItem(lVar6,uVar7,1,1,CONCAT44(uVar5,0xffffffff),
                              in_stack_ffffffffffffff10 & 0xffffffffffffff00,0);
            return 0;
          }
        LAB_180a04923:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        if (uVar4 < 0xc2bf723c) {
          if (uVar4 < 0xa111a0ff) {
            if (uVar4 < 0x96196682) {
              if (0x91be9b05 < uVar4) {
                if (uVar4 == 0x95b6338f) {
                  cVar3 = FUN_1816fd990(lVar8,"hornorlv",0);
                  if (!cVar3) {
                    return "Wrong command";
                  }
                  if (*(int *)(lVar6 + 24) < 2) {
                    return "Command format error";
                  }
                  uVar7 = FUN_180002f80(lVar6,1,DAT_181d7c9c0);
                  cVar3 = Single.TryParse(uVar7,local_res8,0);
                  if (!cVar3) {
                    return "Command format error";
                  }
                  lVar6 = FUN_18046c0a0(0);
                  if (((lVar6 != null) && (*(int64 *)(lVar6 + 32) != 0)) &&
                     (lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0)) != null) {
                    HeroData.ChangeHornorLv(lVar6,(int)local_res8[0],0);
                    return 0;
                  }
                  goto LAB_180a04923;
                }
                if (uVar4 != 0x96196681) {
                  return "Wrong command";
                }
                cVar3 = FUN_1816fd990(lVar8,"herolivingskill",0);
                if (!cVar3) {
                  return "Wrong command";
                }
                goto LAB_180a03420;
              }
              if (uVar4 == 0x91b15418) {
                cVar3 = FUN_1816fd990(lVar8,"fullrecover",0);
                if (!cVar3) {
                  return "Wrong command";
                }
                if (*(int *)(lVar6 + 24) < 2) {
                  if ((*(byte *)(DAT_181d942b0 + 0x133) & 4) == 0) goto LAB_180a0141a;
                  iVar12 = *(int *)(DAT_181d942b0 + 224);
                }
                else {
                  uVar10 = FUN_180002f80(lVar6,1,DAT_181d7c9c0);
                  if ((*(byte *)(DAT_181d942b0 + 0x133) & 4) == 0) goto LAB_180a0141a;
                  iVar12 = *(int *)(DAT_181d942b0 + 224);
                }
                if (iVar12 == 0) {
                  il2cpp_runtime_class_init();
                }
        LAB_180a0141a:
                lVar6 = Console.GetHeroData(uVar10,0);
                if (lVar6 != null) {
                  HeroData.FullRecover(lVar6,1,0);
                  HeroData.set_HeroIconDirty(lVar6,1,0);
                  uVar10 = String.Concat(*(uint64 *)(lVar6 + 104)," fullrecovered",0);
                  return uVar10;
                }
                return "Hero not found";
              }
              if (uVar4 != 0x91be9b05) {
                return "Wrong command";
              }
              cVar3 = FUN_1816fd990(lVar8,"getshoes",0);
              if (!cVar3) {
                return "Wrong command";
              }
              if (*(int *)(lVar6 + 24) < 3) {
                return "Command format error";
              }
              uVar7 = FUN_180002f80(lVar6,1,DAT_181d7c9c0);
              cVar3 = Single.TryParse(uVar7,local_res8,0);
              if (!cVar3) {
                return "Command format error";
              }
              uVar7 = FUN_180002f80(lVar6,2,DAT_181d7c9c0);
              cVar3 = Single.TryParse(uVar7,local_res18,0);
              if (!cVar3) {
                return "Command format error";
              }
              lVar6 = FUN_18046c0a0(0);
              if ((lVar6 == null) || (*(int64 *)(lVar6 + 32) == 0)) goto LAB_180a04923;
              lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0);
              lVar8 = FUN_18046c0a0(0);
              if (lVar8 == null) goto LAB_180a04923;
              in_stack_ffffffffffffff10 = 0;
              uVar5 = 0;
              uVar7 = GameController.GenerateShoes(lVar8,(int)local_res18[0],(int)local_res8[0],0,0,0);
            }
            else {
              if (uVar4 < 0x9b21bc9b) {
                if (uVar4 == 0x96b6baf9) {
                  cVar3 = FUN_1816fd990(lVar8,"randomitem",0);
                  if (!cVar3) {
                    return "Wrong command";
                  }
                  if (*(int *)(lVar6 + 24) < 2) {
                    return "Command format error";
                  }
                  uVar7 = FUN_180002f80(lVar6,1,DAT_181d7c9c0);
                  cVar3 = Single.TryParse(uVar7,local_res8,0);
                  if (!cVar3) {
                    return "Command format error";
                  }
                  uVar7 = new ItemListData(0);
                  lVar6 = FUN_18046c0a0(0);
                  if (lVar6 != null) {
                    in_stack_ffffffffffffff08 = in_stack_ffffffffffffff08 & 0xffffffff00000000;
                    GameController.GenerateRandomItem
                              (lVar6,uVar7,(int)local_res8[0],0x40a00000,in_stack_ffffffffffffff08,
                               in_stack_ffffffffffffff10 & 0xffffffffffffff00,0,0);
                    uVar5 = (uint32)(in_stack_ffffffffffffff08 >> 32);
                    lVar6 = FUN_18046c0a0(0);
                    if (((lVar6 != null) && (*(int64 *)(lVar6 + 32) != 0)) &&
                       (lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0)) != null) {
                      HeroData.GetItem(lVar6,uVar7,1,1,CONCAT44(uVar5,3),0);
                      return 0;
                    }
                  }
                  goto LAB_180a04923;
                }
                if (uVar4 != 0x9b21bc9a) {
                  return "Wrong command";
                }
                cVar3 = FUN_1816fd990(lVar8,"heromaxfightskill",0);
                if (!cVar3) {
                  return "Wrong command";
                }
        LAB_180a04338:
                if (*(int *)(lVar6 + 24) < 2) {
                  return "Command format error";
                }
                lVar8 = il2cpp_internal(DAT_181d6f030);
                FUN_180f58a90(lVar8,DAT_181d678f8);
                if (*(int *)(lVar6 + 24) < 4) {
                  if (*(int *)(lVar6 + 24) != 3) {
                    lVar11 = FUN_18046c0a0(0);
                    if ((lVar11 != null) && (*(int64 *)(lVar11 + 32) != 0)) {
                      lVar11 = WorldData.Player(*(int64 *)(lVar11 + 32),0);
                      uVar13 = uVar10;
                      while( true ) {
                        lVar1 = *(int64 *)(pStatics_ef00 + 0x498);
                        if (lVar1 == null) break;
                        if (*(int *)(lVar1 + 24) <= (int)uVar13) goto LAB_180a04773;
                        if (lVar8 == null) break;
                        FUN_181814fa0(lVar8,uVar13,DAT_181d67a78);
                        uVar13 = (uint64)((int)uVar13 + 1);
                      }
                    }
                    goto LAB_180a04923;
                  }
                  lVar11 = *(int64 *)(pStatics_ef00 + 0x498);
                  uVar7 = FUN_180002f80(lVar6,1,DAT_181d7c9c0);
                  if (lVar11 == null) goto LAB_180a04923;
                  cVar3 = FUN_1818279a0(lVar11,uVar7,DAT_181d7c4d0);
                  if (!cVar3) {
                    uVar7 = FUN_180002f80(lVar6,1,DAT_181d7c9c0);
                    lVar11 = Console.GetHeroData(uVar7,0);
                    uVar13 = uVar10;
                    while( true ) {
                      lVar1 = *(int64 *)(pStatics_ef00 + 0x498);
                      if (lVar1 == null) break;
                      if (*(int *)(lVar1 + 24) <= (int)uVar13) goto LAB_180a04773;
                      if (lVar8 == null) break;
                      FUN_181814fa0(lVar8,uVar13,DAT_181d67a78);
                      uVar13 = (uint64)((int)uVar13 + 1);
                    }
                    goto LAB_180a04923;
                  }
                  lVar11 = FUN_18046c0a0(0);
                  if ((lVar11 == null) || (*(int64 *)(lVar11 + 32) == 0)) goto LAB_180a04923;
                  lVar11 = WorldData.Player(*(int64 *)(lVar11 + 32),0);
                  lVar1 = *(int64 *)(pStatics_ef00 + 0x498);
                  uVar7 = FUN_180002f80(lVar6,1,DAT_181d7c9c0);
                  if (lVar1 == null) goto LAB_180a04923;
                  cVar3 = FUN_1818279a0(lVar1,uVar7,DAT_181d7c4d0);
                  if (cVar3) {
                    lVar1 = *(int64 *)(pStatics_ef00 + 0x498);
                    uVar7 = FUN_180002f80(lVar6,1,DAT_181d7c9c0);
                    goto joined_r0x000180a04741;
                  }
                }
                else {
                  uVar7 = FUN_180002f80(lVar6,1,DAT_181d7c9c0);
                  lVar11 = Console.GetHeroData(uVar7,0);
                  lVar1 = *(int64 *)(pStatics_ef00 + 0x498);
                  uVar7 = FUN_180002f80(lVar6,2,DAT_181d7c9c0);
                  if (lVar1 == null) goto LAB_180a04923;
                  cVar3 = FUN_1818279a0(lVar1,uVar7,DAT_181d7c4d0);
                  if (cVar3) {
                    lVar1 = *(int64 *)(pStatics_ef00 + 0x498);
                    uVar7 = FUN_180002f80(lVar6,2,DAT_181d7c9c0);
        joined_r0x000180a04741:
                    if ((lVar1 == null) || (uVar5 = FUN_1817ff280(lVar1,uVar7,DAT_181d7c648), lVar8 == null))
                    goto LAB_180a04923;
                    FUN_181814fa0(lVar8,uVar5,DAT_181d67a78);
                  }
                }
        LAB_180a04773:
                if (lVar11 == null) {
                  return "Hero not found";
                }
                if (lVar8 != null) {
                  if (*(int *)(lVar8 + 24) == 0) {
                    return "Fightskill not found";
                  }
                  uVar7 = FUN_180002f80(lVar6,*(int *)(lVar6 + 24) + -1,DAT_181d7c9c0);
                  cVar3 = Single.TryParse(uVar7,local_res8,0);
                  if (cVar3) {
                    while (iVar12 = (int)uVar10, iVar12 < *(int *)(lVar8 + 24)) {
                      if (*(int *)(lVar6 + 24) == 0) {
                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                      }
                      cVar3 = FUN_1816fd990(*(uint64 *)(*(int64 *)(lVar6 + 16) + 32),
                                            "herofightskill",0);
                      if (!cVar3) {
                        uVar5 = FUN_1800d6750(lVar8,uVar10);
                        in_stack_ffffffffffffff08 = 0;
                        HeroData.ChangeMaxFightSkill(lVar11,uVar5,(int)local_res8[0],1,0);
                        uVar10 = (uint64)(iVar12 + 1);
                      }
                      else {
                        uVar5 = FUN_1800d6750(lVar8,uVar10);
                        in_stack_ffffffffffffff08 = in_stack_ffffffffffffff08 & 0xffffffffffffff00;
                        HeroData.ChangeFightSkill
                                  (lVar11,uVar5,local_res8[0],1,in_stack_ffffffffffffff08,0);
                        uVar10 = (uint64)(iVar12 + 1);
                      }
                    }
                    return 0;
                  }
                  return "Command format error";
                }
                goto LAB_180a04923;
              }
              if (uVar4 == 0x9f49799f) {
                cVar3 = FUN_1816fd990(lVar8,"movespeed",0);
                if (!cVar3) {
                  return "Wrong command";
                }
                if (*(int *)(lVar6 + 24) < 2) {
                  return "Command format error";
                }
                uVar7 = FUN_180002f80(lVar6,1,DAT_181d7c9c0);
                cVar3 = Single.TryParse(uVar7,local_res8,0);
                if (!cVar3) {
                  return "Command format error";
                }
                lVar6 = FUN_18046c0a0(0);
                if (((lVar6 != null) && (*(int64 *)(lVar6 + 32) != 0)) &&
                   (lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0)) != null) {
                  lVar6 = *(int64 *)(lVar6 + 0x2b0);
                  lVar8 = FUN_18046c0a0(0);
                  if (((lVar8 != null) && (*(int64 *)(lVar8 + 32) != 0)) &&
                     ((lVar8 = WorldData.Player(*(int64 *)(lVar8 + 32),0), lVar8 != null &&
                      ((*(int64 *)(lVar8 + 0x2b0) != 0 &&
                       (fVar15 = (float)HeroSpeAddData.Get(*(int64 *)(lVar8 + 0x2b0),174,0),
                       lVar6 != null)))))) {
                    HeroSpeAddData.Set(lVar6,174,fVar15 + local_res8[0],0);
                    lVar6 = FUN_18046c0a0(0);
                    if ((lVar6 != null) &&
                       ((*(int64 *)(lVar6 + 32) != 0 &&
                        (lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0)) != null))) {
                      *(uint8 *)(lVar6 + 0x2d8) = 1;
                      lVar6 = FUN_18046c0a0(0);
                      if ((lVar6 != null) &&
                         (((*(int64 *)(lVar6 + 32) != 0 &&
                           (lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0)) != null) &&
                          (*(int64 *)(lVar6 + 0x2b0) != 0)))) {
                        local_c0 = (float)HeroSpeAddData.Get(*(int64 *)(lVar6 + 0x2b0),174,0);
                        local_c0 = local_c0 + 1.0;
                        uVar7 = Single.ToString(&local_c0,0);
                        uVar10 = String.Concat("now speed: ",uVar7,0);
                        return uVar10;
                      }
                    }
                  }
                }
                goto LAB_180a04923;
              }
              if (uVar4 != 0xa111a0fe) {
                return "Wrong command";
              }
              cVar3 = FUN_1816fd990(lVar8,"getarmor",0);
              if (!cVar3) {
                return "Wrong command";
              }
              if (*(int *)(lVar6 + 24) < 3) {
                return "Command format error";
              }
              uVar7 = FUN_180002f80(lVar6,1,DAT_181d7c9c0);
              cVar3 = Single.TryParse(uVar7,local_res8,0);
              if (!cVar3) {
                return "Command format error";
              }
              uVar7 = FUN_180002f80(lVar6,2,DAT_181d7c9c0);
              cVar3 = Single.TryParse(uVar7,local_res18,0);
              if (!cVar3) {
                return "Command format error";
              }
              lVar6 = FUN_18046c0a0(0);
              if ((lVar6 == null) || (*(int64 *)(lVar6 + 32) == 0)) goto LAB_180a04923;
              lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0);
              lVar8 = FUN_18046c0a0(0);
              if (lVar8 == null) goto LAB_180a04923;
              in_stack_ffffffffffffff10 = 0;
              uVar5 = 0;
              uVar7 = GameController.GenerateArmor(lVar8,(int)local_res18[0],(int)local_res8[0],0,0,0);
            }
          }
          else if (uVar4 < 0xb0ca42c0) {
            if (uVar4 < 0xae8f4079) {
              if (uVar4 != 0xa3ac8fb7) {
                if (uVar4 != 0xae8f4078) {
                  return "Wrong command";
                }
                cVar3 = FUN_1816fd990(lVar8,"forceresource",0);
                if (!cVar3) {
                  return "Wrong command";
                }
                if (*(int *)(lVar6 + 24) < 2) {
                  return "Command format error";
                }
                lVar8 = il2cpp_internal(DAT_181d6f030);
                FUN_180f58a90(lVar8,DAT_181d678f8);
                if (*(int *)(lVar6 + 24) < 4) {
                  if (*(int *)(lVar6 + 24) != 3) {
                    lVar11 = Console.GetForceData(0,0);
                    uVar13 = uVar10;
                    while( true ) {
                      lVar1 = *(int64 *)(pStatics_ef00 + 0x430);
                      if (lVar1 == null) break;
                      if (*(int *)(lVar1 + 24) <= (int)uVar13) goto LAB_180a00db8;
                      if (lVar8 == null) break;
                      FUN_181814fa0(lVar8,uVar13,DAT_181d67a78);
                      uVar13 = (uint64)((int)uVar13 + 1);
                    }
                    goto LAB_180a04923;
                  }
                  lVar11 = *(int64 *)(pStatics_ef00 + 0x430);
                  uVar7 = FUN_180002f80(lVar6,1,DAT_181d7c9c0);
                  if (lVar11 == null) goto LAB_180a04923;
                  cVar3 = FUN_1818279a0(lVar11,uVar7,DAT_181d7c4d0);
                  if (!cVar3) {
                    uVar7 = FUN_180002f80(lVar6,1,DAT_181d7c9c0);
                    lVar11 = Console.GetForceData(uVar7,0);
                    uVar13 = uVar10;
                    while( true ) {
                      lVar1 = *(int64 *)(pStatics_ef00 + 0x430);
                      if (lVar1 == null) break;
                      if (*(int *)(lVar1 + 24) <= (int)uVar13) goto LAB_180a00db8;
                      if (lVar8 == null) break;
                      FUN_181814fa0(lVar8,uVar13,DAT_181d67a78);
                      uVar13 = (uint64)((int)uVar13 + 1);
                    }
                    goto LAB_180a04923;
                  }
                  lVar11 = Console.GetForceData(0,0);
                  lVar1 = *(int64 *)(pStatics_ef00 + 0x430);
                  uVar7 = FUN_180002f80(lVar6,1,DAT_181d7c9c0);
                  if (lVar1 == null) goto LAB_180a04923;
                  cVar3 = FUN_1818279a0(lVar1,uVar7,DAT_181d7c4d0);
                  if (cVar3) {
                    lVar1 = *(int64 *)(pStatics_ef00 + 0x430);
                    uVar7 = FUN_180002f80(lVar6,1,DAT_181d7c9c0);
                    goto joined_r0x000180a00d86;
                  }
                }
                else {
                  uVar7 = FUN_180002f80(lVar6,1,DAT_181d7c9c0);
                  lVar11 = Console.GetForceData(uVar7,0);
                  lVar1 = *(int64 *)(pStatics_ef00 + 0x430);
                  uVar7 = FUN_180002f80(lVar6,2,DAT_181d7c9c0);
                  if (lVar1 == null) goto LAB_180a04923;
                  cVar3 = FUN_1818279a0(lVar1,uVar7,DAT_181d7c4d0);
                  if (cVar3) {
                    lVar1 = *(int64 *)(pStatics_ef00 + 0x430);
                    uVar7 = FUN_180002f80(lVar6,2,DAT_181d7c9c0);
        joined_r0x000180a00d86:
                    if ((lVar1 == null) || (uVar5 = FUN_1817ff280(lVar1,uVar7,DAT_181d7c648), lVar8 == null))
                    goto LAB_180a04923;
                    FUN_181814fa0(lVar8,uVar5,DAT_181d67a78);
                  }
                }
        LAB_180a00db8:
                if (lVar11 == null) {
                  return "Force not found";
                }
                if (lVar8 != null) {
                  if (*(int *)(lVar8 + 24) == 0) {
                    return "Resource not found";
                  }
                  uVar7 = FUN_180002f80(lVar6,*(int *)(lVar6 + 24) + -1,DAT_181d7c9c0);
                  cVar3 = Single.TryParse(uVar7,local_res8,0);
                  if (cVar3) {
                    while( true ) {
                      uVar4 = (uint32)uVar10;
                      if ((int)*(uint32 *)(lVar8 + 24) <= (int)uVar4) break;
                      if (*(uint32 *)(lVar8 + 24) <= uVar4) {
                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                      }
                      ForceData.ChangeResource
                                (lVar11,*(uint32 *)
                                         (*(int64 *)(lVar8 + 16) + 32 + (int64)(int)uVar4 * 4),
                                 local_res8[0],1,1,0);
                      uVar10 = (uint64)(uVar4 + 1);
                    }
                    return 0;
                  }
                  return "Command format error";
                }
                goto LAB_180a04923;
              }
              cVar3 = FUN_1816fd990(lVar8,"getweapon",0);
              if (!cVar3) {
                return "Wrong command";
              }
              if (*(int *)(lVar6 + 24) < 3) {
                return "Command format error";
              }
              uVar7 = FUN_180002f80(lVar6,1,DAT_181d7c9c0);
              cVar3 = Single.TryParse(uVar7,local_res8,0);
              if (!cVar3) {
                return "Command format error";
              }
              uVar7 = FUN_180002f80(lVar6,2,DAT_181d7c9c0);
              cVar3 = Single.TryParse(uVar7,local_res18,0);
              if (!cVar3) {
                return "Command format error";
              }
              lVar6 = FUN_18046c0a0(0);
              if ((lVar6 == null) || (*(int64 *)(lVar6 + 32) == 0)) goto LAB_180a04923;
              lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0);
              lVar8 = FUN_18046c0a0(0);
              if (lVar8 == null) goto LAB_180a04923;
              in_stack_ffffffffffffff10 = 0;
              uVar5 = 0;
              uVar7 = GameController.GenerateWeapon(lVar8,(int)local_res18[0],(int)local_res8[0],0,0,0);
            }
            else {
              if (uVar4 == 0xafd071e5) {
                cVar3 = FUN_1816fd990(lVar8,"test",0);
                uVar16 = (uint32)(in_stack_ffffffffffffff10 >> 32);
                if (!cVar3) {
                  return "Wrong command";
                }
                lVar6 = *(int64 *)(pStatics_e010 + 8);
                if ((lVar6 != null) && (lVar6 = *(int64 *)(lVar6 + 16)) != null) {
                  iVar12 = PlayerPrefDictionary.GetInt(lVar6,"TestMode",0);
                  PlayerPrefDictionary.SetKey(lVar6,"TestMode",iVar12 != 1,0);
                  lVar6 = **(int64 **)(DAT_181d5a578 + 184);
                  lVar8 = *(int64 *)(pStatics_e010 + 8);
                  if ((lVar8 != null) && (lVar8 = *(int64 *)(lVar8 + 16)) != null) {
                    iVar12 = PlayerPrefDictionary.GetInt(lVar8,"TestMode",0);
                    uVar7 = "已开启！";
                    if (iVar12 != 1) {
                      uVar7 = "已关闭！";
                    }
                    uVar7 = String.Concat("测试模式",uVar7,0);
                    if (lVar6 != null) {
                      local_98 = 0;
                      uStack_90 = 0;
                      InfoController.AddInfoTab
                                (lVar6,uVar7,"UIAtlas","从事工作_降低恶名","Woosh",
                                 CONCAT44(uVar16,0x3f800000),CONCAT44(uVar5,0x40a00000),&local_98,0);
                      return 0;
                    }
                  }
                }
                goto LAB_180a04923;
              }
              if (uVar4 != 0xb0ca42bf) {
                return "Wrong command";
              }
              cVar3 = FUN_1816fd990(lVar8,"gethorsearmor",0);
              uVar5 = (uint32)(in_stack_ffffffffffffff08 >> 32);
              if (!cVar3) {
                return "Wrong command";
              }
              if (*(int *)(lVar6 + 24) < 2) {
                return "Command format error";
              }
              uVar7 = FUN_180002f80(lVar6,1,DAT_181d7c9c0);
              cVar3 = Single.TryParse(uVar7,local_res8,0);
              if (!cVar3) {
                return "Command format error";
              }
              lVar6 = FUN_18046c0a0(0);
              if ((lVar6 == null) || (*(int64 *)(lVar6 + 32) == 0)) goto LAB_180a04923;
              lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0);
              lVar8 = FUN_18046c0a0(0);
              if (lVar8 == null) goto LAB_180a04923;
              uVar7 = GameController.GenerateHorseArmorData(lVar8,(int)local_res8[0],0,0);
            }
          }
          else {
            if (0xb468084f < uVar4) {
              if (uVar4 == 0xb853b15f) {
                cVar3 = FUN_1816fd990(lVar8,"creatrandomevent",0);
                if (!cVar3) {
                  return "Wrong command";
                }
                if (*(int *)(lVar6 + 24) < 2) {
                  return "Command format error";
                }
                uVar7 = FUN_180002f80(lVar6,1,DAT_181d7c9c0);
                cVar3 = Single.TryParse(uVar7,local_res8,0);
                if (!cVar3) {
                  return "Command format error";
                }
                lVar6 = FUN_18046c540(0);
                if ((lVar6 != null) &&
                   (lVar6 = RandomEventController.GetRandomEventDataBase(lVar6,(int)local_res8[0],0),
                   lVar6 != null)) {
                  uVar7 = EventData.Clone(lVar6,0);
                  lVar6 = FUN_1800020c0(uVar7,DAT_181d9f648);
                  uVar5 = GlobalData.RandomRange(7,15,0);
                  if (lVar6 != null) {
                    *(uint32 *)(lVar6 + 104) = uVar5;
                    fVar15 = *(float *)(lVar6 + 112);
                    lVar8 = FUN_18046c0a0(0);
                    GlobalData.RandomRange(0x3e800000);
                    if (lVar8 != null) {
                      fVar14 = (float)GameController.GetTimeRandomDifficulty(lVar8);
                      *(float *)(lVar6 + 108) = fVar14 * fVar15;
                      *(uint8 *)(lVar6 + 96) = 1;
                      bVar2 = false;
                      uVar13 = uVar10;
                      while (lVar8 = *(int64 *)(lVar6 + 40)) != null {
                        uVar4 = (uint32)uVar10;
                        if ((int)*(uint32 *)(lVar8 + 24) <= (int)uVar4) {
                          return uVar13;
                        }
                        if (*(uint32 *)(lVar8 + 24) <= uVar4) {
                          ThrowHelper.ThrowArgumentOutOfRangeException(0);
                        }
                        iVar12 = lVar8[uVar4];
                        if (iVar12 == 1) {
                          lVar8 = FUN_18046c0a0(0);
                          lVar11 = FUN_18046c0a0(0);
                          if (((lVar11 == null) || (*(int64 *)(lVar11 + 32) == 0)) ||
                             (uVar7 = WorldData.GetArea(*(int64 *)(lVar11 + 32),0,0), lVar8 == null))
                          break;
                          GameController.CreateBigMapRandomEvent(lVar8,lVar6,uVar7,0x3e4ccccd,0);
        LAB_180a001c3:
                          uVar10 = (uint64)(uVar4 + 1);
                        }
                        else if ((iVar12 == 2) || (iVar12 == 3)) {
                          if (bVar2) goto LAB_180a001c3;
                          lVar8 = FUN_18046c0a0(0);
                          if (lVar8 == null) break;
                          GameController.CreateAreaMapRandomEvent(lVar8,lVar6,0,0);
                          bVar2 = true;
                          uVar10 = (uint64)(uVar4 + 1);
                        }
                        else {
                          if (iVar12 != 4) goto LAB_180a001c3;
                          lVar8 = FUN_18046c0a0(0);
                          if (((lVar8 == null) || (*(int64 *)(lVar8 + 32) == 0)) ||
                             (lVar8 = WorldData.Player(*(int64 *)(lVar8 + 32),0)) == null)
                          break;
                          if (*(int *)(lVar8 + 132) < 0) {
                            uVar10 = (uint64)(uVar4 + 1);
                            uVar13 = "玩家需要加入门派以触发该事件";
                          }
                          else {
                            lVar8 = FUN_18046c0a0(0);
                            lVar11 = FUN_18046c0a0(0);
                            if (((lVar11 == null) || (*(int64 *)(lVar11 + 32) == 0)) ||
                               ((lVar11 = WorldData.Player(*(int64 *)(lVar11 + 32),0), lVar11 == null
                                || ((lVar11 = HeroData.GetForce(lVar11,0,0), lVar11 == null || (lVar8 == null))
                                   )))) break;
                            GameController.CreateAreaMapRandomEvent
                                      (lVar8,lVar6,*(uint32 *)(lVar11 + 56),0);
                            uVar10 = (uint64)(uVar4 + 1);
                          }
                        }
                      }
                    }
                  }
                }
                goto LAB_180a04923;
              }
              if (uVar4 == 0xbab97a8d) {
                cVar3 = FUN_1816fd990(lVar8,"forcemeeting",0);
                if (!cVar3) {
                  return "Wrong command";
                }
                if (*(int *)(lVar6 + 24) < 2) {
                  return "Command format error";
                }
                uVar7 = FUN_180002f80(lVar6,1,DAT_181d7c9c0);
                cVar3 = FUN_1816fd990(uVar7,"0",0);
                if (!cVar3) {
                  uVar7 = FUN_180002f80(lVar6,1,DAT_181d7c9c0);
                  cVar3 = FUN_1816fd990(uVar7,"1",0);
                  if (!cVar3) {
                    return "Command format error";
                  }
                  lVar6 = FUN_18046c0a0(0);
                  if (lVar6 != null) {
                    GameController.SetForceMeetingStart(lVar6,0);
                    return 0;
                  }
                }
                else {
                  lVar6 = *(int64 *)(*(int64 *)(DAT_181d637f0 + 184) + 16);
                  if (lVar6 != null) {
                    MeetingController.SetMeetingEnd(lVar6,0);
                    return 0;
                  }
                }
                goto LAB_180a04923;
              }
              if (uVar4 != 0xc2bf723b) {
                return "Wrong command";
              }
              cVar3 = FUN_1816fd990(lVar8,"tagpoint",0);
              if (!cVar3) {
                return "Wrong command";
              }
              if (*(int *)(lVar6 + 24) < 2) {
                return "Command format error";
              }
              if (*(int *)(lVar6 + 24) < 3) {
                if ((*(byte *)(DAT_181d942b0 + 0x133) & 4) != 0) {
                  iVar12 = *(int *)(DAT_181d942b0 + 224);
                  goto LAB_180a00395;
                }
              }
              else {
                uVar10 = FUN_180002f80(lVar6,1,DAT_181d7c9c0);
                if ((*(byte *)(DAT_181d942b0 + 0x133) & 4) != 0) {
                  iVar12 = *(int *)(DAT_181d942b0 + 224);
        LAB_180a00395:
                  if (iVar12 == 0) {
                    il2cpp_runtime_class_init();
                  }
                }
              }
              lVar8 = Console.GetHeroData(uVar10,0);
              if (lVar8 == null) {
                return "Hero not found";
              }
              uVar7 = 2;
              if (*(int *)(lVar6 + 24) < 3) {
                uVar7 = 1;
              }
              uVar7 = FUN_180002f80(lVar6,uVar7,DAT_181d7c9c0);
              cVar3 = Single.TryParse(uVar7,local_res8,0);
              goto joined_r0x000180a003e4;
            }
            if (uVar4 == 0xb157c92e) {
              cVar3 = FUN_1816fd990(lVar8,"getmaterial",0);
              if (!cVar3) {
                return "Wrong command";
              }
              if (*(int *)(lVar6 + 24) < 3) {
                return "Command format error";
              }
              uVar7 = FUN_180002f80(lVar6,1,DAT_181d7c9c0);
              cVar3 = Single.TryParse(uVar7,local_res8,0);
              if (!cVar3) {
                return "Command format error";
              }
              uVar7 = FUN_180002f80(lVar6,2,DAT_181d7c9c0);
              cVar3 = Single.TryParse(uVar7,local_res18,0);
              if (!cVar3) {
                return "Command format error";
              }
              lVar6 = FUN_18046c0a0(0);
              if ((lVar6 == null) || (*(int64 *)(lVar6 + 32) == 0)) goto LAB_180a04923;
              lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0);
              lVar8 = FUN_18046c0a0(0);
              if (lVar8 == null) goto LAB_180a04923;
              uVar5 = 0;
              uVar7 = GameController.GenerateMaterial(lVar8,(int)local_res8[0],(int)local_res18[0],0,0);
            }
            else {
              if (uVar4 != 0xb468084f) {
                return "Wrong command";
              }
              cVar3 = FUN_1816fd990(lVar8,"getmed",0);
              uVar5 = (uint32)(in_stack_ffffffffffffff08 >> 32);
              if (!cVar3) {
                return "Wrong command";
              }
              if (*(int *)(lVar6 + 24) < 2) {
                return "Command format error";
              }
              uVar7 = FUN_180002f80(lVar6,1,DAT_181d7c9c0);
              cVar3 = Single.TryParse(uVar7,local_res8,0);
              if (!cVar3) {
                return "Command format error";
              }
              lVar6 = FUN_18046c0a0(0);
              if ((lVar6 == null) || (*(int64 *)(lVar6 + 32) == 0)) goto LAB_180a04923;
              lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0);
              lVar8 = FUN_18046c0a0(0);
              if (lVar8 == null) goto LAB_180a04923;
              uVar7 = GameController.GenerateMedData(lVar8,(int)local_res8[0],0,0);
            }
          }
          goto joined_r0x000180a03079;
        }
        if (uVar4 < 0xe150c950) {
          if (uVar4 < 0xc850d701) {
            if (uVar4 < 0xc501f171) {
              if (uVar4 == 0xc4899e10) {
                cVar3 = FUN_1816fd990(lVar8,"startplot",0);
                if (!cVar3) {
                  return "Wrong command";
                }
                if (*(int *)(lVar6 + 24) < 2) {
                  return "Command format error";
                }
                uVar7 = FUN_180002f80(lVar6,1,DAT_181d7c9c0);
                cVar3 = Single.TryParse(uVar7,local_res8,0);
                if (!cVar3) {
                  return "Command format error";
                }
                lVar6 = FUN_18046c440(0);
                if (lVar6 != null) {
                  PlotController.AddPlotDataBase(lVar6,(int)local_res8[0],0);
                  return 0;
                }
              }
              else {
                if (uVar4 != 0xc501f170) {
                  return "Wrong command";
                }
                cVar3 = FUN_1816fd990(lVar8,"triggerend",0);
                if (!cVar3) {
                  return "Wrong command";
                }
                if (*(int *)(lVar6 + 24) < 2) {
                  return "Command format error";
                }
                uVar7 = FUN_180002f80(lVar6,1,DAT_181d7c9c0);
                cVar3 = Single.TryParse(uVar7,local_res8,0);
                if (!cVar3) {
                  return "Command format error";
                }
                lVar6 = *(int64 *)(*(int64 *)(DAT_181d4e208 + 184) + 8);
                if (lVar6 != null) {
                  GameResultController.StartGameResult(lVar6,(int)local_res8[0],0);
                  return 0;
                }
              }
            }
            else {
              if (uVar4 != 0xc81ec79b) {
                if (uVar4 != 0xc850d700) {
                  return "Wrong command";
                }
                cVar3 = FUN_1816fd990(lVar8,"forcefavor",0);
                if (!cVar3) {
                  return "Wrong command";
                }
                if (*(int *)(lVar6 + 24) < 3) {
                  return "Command format error";
                }
                uVar7 = FUN_180002f80(lVar6,1,DAT_181d7c9c0);
                lVar8 = Console.GetForceData(uVar7,0);
                if (*(int *)(lVar6 + 24) < 4) {
                  uVar7 = 0;
                }
                else {
                  uVar7 = FUN_180002f80(lVar6,2,DAT_181d7c9c0);
                }
                lVar11 = Console.GetForceData(uVar7,0);
                if (lVar8 != null) {
                  if (lVar11 == null) {
                    return "Force not found";
                  }
                  if (lVar8 != lVar11) {
                    uVar7 = 3;
                    if (*(int *)(lVar6 + 24) < 4) {
                      uVar7 = 2;
                    }
                    uVar7 = FUN_180002f80(lVar6,uVar7,DAT_181d7c9c0);
                    cVar3 = Single.TryParse(uVar7,local_res8,0);
                    if (cVar3) {
                      ForceData.ChangeForceFavor(lVar11,*(uint32 *)(lVar8 + 16),local_res8[0],1,0);
                      return 0;
                    }
                    return "Command format error";
                  }
                  return "Force not found";
                }
                return "Force not found";
              }
              cVar3 = FUN_1816fd990(lVar8,"winbattle",0);
              if (!cVar3) {
                return "Wrong command";
              }
              lVar8 = FUN_18046bb80(0);
              if (lVar8 != null) {
                if (*(int *)(lVar8 + 36) != 3) {
                  return "Not in battle";
                }
                if (*(int *)(lVar6 + 24) < 2) {
                  return "Command format error";
                }
                uVar7 = FUN_180002f80(lVar6,1,DAT_181d7c9c0);
                cVar3 = FUN_1816fd990(uVar7,"0",0);
                if (!cVar3) {
                  uVar7 = FUN_180002f80(lVar6,1,DAT_181d7c9c0);
                  cVar3 = FUN_1816fd990(uVar7,"1",0);
                  if (!cVar3) {
                    return "Command format error";
                  }
                  lVar6 = FUN_18046bb80(0);
                  if (lVar6 != null) {
                    *(uint32 *)(lVar6 + 36) = 4;
                    lVar6 = FUN_18046bb80(0);
                    if (lVar6 != null) {
                      *(uint32 *)(lVar6 + 48) = 1;
                      return 0;
                    }
                  }
                }
                else {
                  lVar6 = FUN_18046bb80(0);
                  if (lVar6 != null) {
                    *(uint32 *)(lVar6 + 36) = 4;
                    lVar6 = FUN_18046bb80(0);
                    if (lVar6 != null) {
                      *(uint32 *)(lVar6 + 48) = 0;
                      return 0;
                    }
                  }
                }
              }
            }
            goto LAB_180a04923;
          }
          if (uVar4 < 0xda620c4c) {
            if (uVar4 == 0xccc441c1) {
              cVar3 = FUN_1816fd990(lVar8,"conquerall",0);
              if (!cVar3) {
                return "Wrong command";
              }
              lVar6 = FUN_18046c0a0(0);
              if (((lVar6 != null) && (*(int64 *)(lVar6 + 32) != 0)) &&
                 (lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0)) != null) {
                lVar6 = HeroData.GetForce(lVar6,0,0);
                if (lVar6 == null) {
                  return "Player need force";
                }
                lVar8 = FUN_18046c0a0(0);
                if (((lVar8 != null) && (*(int64 *)(lVar8 + 32) != 0)) &&
                   (lVar8 = *(int64 *)(*(int64 *)(lVar8 + 32) + 48)) != null) {
                  FUN_1817ff240(&local_68,lVar8,DAT_181d550e0);
                  local_88 = local_68;
                  uStack_84 = uStack_64;
                  uStack_80 = uStack_60;
                  uStack_7c = uStack_5c;
                  local_78 = local_58;
                  while (cVar3 = FUN_180d197a0(&local_88,DAT_181d639c8), lVar8 = local_78, cVar3)
                  {
                    if (local_78 == 0) {
                          // WARNING: Subroutine does not return
                      FUN_1800d6620();
                    }
                    if (*(int *)(local_78 + 72) == 2) {
                      lVar11 = FUN_18046c0a0(0);
                      uVar7 = AreaData.GetForce(lVar8,0);
                      if (lVar11 == null) {
                          // WARNING: Subroutine does not return
                        FUN_1800d6620();
                      }
                      GameController.SetForceMaster(lVar11,lVar6,uVar7,1,0);
                    }
                    else {
                      ForceData.ForceConquerArea(lVar6,local_78,1,0);
                    }
                  }
                  aiStack_bc[1] = 0x2f86;
                  iVar12 = aiStack_bc[2] + 1;
                  aiStack_bc[2] = iVar12;
                  ZhSegment.Initialize(&local_88,DAT_181d63948);
                  if (iVar12 == 0) {
                    return "Player need force";
                  }
                  if (aiStack_bc[iVar12] == 0x2f86) {
                    return 0;
                  }
                  return "Player need force";
                }
              }
            }
            else {
              if (uVar4 != 0xda620c4b) {
                return "Wrong command";
              }
              cVar3 = FUN_1816fd990(lVar8,"changeweather",0);
              if (!cVar3) {
                return "Wrong command";
              }
              if (*(int *)(lVar6 + 24) < 2) {
                return "Command format error";
              }
              while( true ) {
                if ((*pStatics_fc60 == 0) ||
                   (lVar8 = *(int64 *)(*pStatics_fc60 + 32)) == null)
                goto LAB_180a04923;
                uVar4 = (uint32)uVar10;
                if (*(int *)(lVar8 + 24) <= (int)uVar4) {
                  return "Weather not found";
                }
                if ((*pStatics_fc60 == 0) ||
                   (lVar8 = *(int64 *)(*pStatics_fc60 + 32)) == null)
                goto LAB_180a04923;
                if (*(uint32 *)(lVar8 + 24) <= uVar4) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar8 = lVar8[uVar4];
                if (lVar8 == null) goto LAB_180a04923;
                uVar7 = *(uint64 *)(lVar8 + 16);
                if (*(uint32 *)(lVar6 + 24) < 2) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                cVar3 = FUN_1816fd990(uVar7,*(uint64 *)(*(int64 *)(lVar6 + 16) + 40),0);
                if (cVar3) break;
                uVar10 = (uint64)(uVar4 + 1);
              }
              if (uVar4 == 0xffffffff) {
                return "Weather not found";
              }
              lVar6 = FUN_18046c800(0);
              if (lVar6 != null) {
                WeatherController.ChangeWeather(lVar6,uVar10,0);
                return 0;
              }
            }
            goto LAB_180a04923;
          }
          if (uVar4 == 0xdfaa3aab) {
            cVar3 = FUN_1816fd990(lVar8,"herofavor",0);
            if (!cVar3) {
              return "Wrong command";
            }
            if (1 < *(int *)(lVar6 + 24)) {
              if (*(int *)(lVar6 + 24) < 3) {
                uVar7 = 0;
              }
              else {
                uVar7 = FUN_180002f80(lVar6,1,DAT_181d7c9c0);
              }
              lVar8 = Console.GetHeroData(uVar7,0);
              if (lVar8 != null) {
                uVar7 = 2;
                if (*(int *)(lVar6 + 24) < 3) {
                  uVar7 = 1;
                }
                uVar7 = FUN_180002f80(lVar6,uVar7,DAT_181d7c9c0);
                cVar3 = Single.TryParse(uVar7,local_res8,0);
                if (cVar3) {
                  HeroData.ChangeFavor(lVar8);
                  return 0;
                }
                return "Command format error";
              }
              return "Hero not found";
            }
            return "Command format error";
          }
          if (uVar4 == 0xe0b63a87) {
            cVar3 = FUN_1816fd990(lVar8,"ally",0);
            if (!cVar3) {
              return "Wrong command";
            }
            if (*(int *)(lVar6 + 24) < 2) {
              return "Command format error";
            }
            uVar7 = FUN_180002f80(lVar6,1,DAT_181d7c9c0);
            lVar6 = Console.GetForceData(uVar7,0);
            if (lVar6 == null) {
              return "Force not found";
            }
            lVar8 = FUN_18046c0a0(0);
            if (((lVar8 != null) && (*(int64 *)(lVar8 + 32) != 0)) &&
               (lVar8 = WorldData.Player(*(int64 *)(lVar8 + 32),0)) != null) {
              ForceData.AddAllyForce(lVar6,*(uint32 *)(lVar8 + 132),1,1,0);
              return 0;
            }
            goto LAB_180a04923;
          }
          if (uVar4 != 0xe150c94f) {
            return "Wrong command";
          }
          cVar3 = FUN_1816fd990(lVar8,"money",0);
          if (!cVar3) {
            return "Wrong command";
          }
          if (*(int *)(lVar6 + 24) < 2) {
            return "Command format error";
          }
          if (*(int *)(lVar6 + 24) < 3) {
            if ((*(byte *)(DAT_181d942b0 + 0x133) & 4) == 0) goto LAB_1809ff5fb;
            iVar12 = *(int *)(DAT_181d942b0 + 224);
          }
          else {
            uVar10 = FUN_180002f80(lVar6,1,DAT_181d7c9c0);
            if ((*(byte *)(DAT_181d942b0 + 0x133) & 4) == 0) goto LAB_1809ff5fb;
            iVar12 = *(int *)(DAT_181d942b0 + 224);
          }
          if (iVar12 == 0) {
            il2cpp_runtime_class_init();
          }
        LAB_1809ff5fb:
          lVar8 = Console.GetHeroData(uVar10,0);
          if (lVar8 == null) {
            return "Hero not found";
          }
          uVar7 = 2;
          if (*(int *)(lVar6 + 24) < 3) {
            uVar7 = 1;
          }
          uVar7 = FUN_180002f80(lVar6,uVar7,DAT_181d7c9c0);
          cVar3 = Single.TryParse(uVar7,local_res8,0);
          if (cVar3) {
            HeroData.ChangeMoney(lVar8,(int)local_res8[0],1,0);
            return 0;
          }
          return "Command format error";
        }
        if (0xed2ad693 < uVar4) {
          if (uVar4 < 0xf443bc2d) {
            if (uVar4 != 0xf2baf708) {
              if (uVar4 != 0xf443bc2c) {
                return "Wrong command";
              }
              cVar3 = FUN_1816fd990(lVar8,"invincible",0);
              if (!cVar3) {
                return "Wrong command";
              }
              *(bool *)(pStatics_42b0 + 40) =
                   *(char *)(pStatics_42b0 + 40) == false;
              uVar7 = "on";
              if (*(char *)(pStatics_42b0 + 40) == false) {
                uVar7 = "off";
              }
              uVar10 = String.Concat("Invincible mode ",uVar7,0);
              return uVar10;
            }
            cVar3 = FUN_1816fd990(lVar8,"governlv",0);
            if (!cVar3) {
              return "Wrong command";
            }
            if (*(int *)(lVar6 + 24) < 2) {
              return "Command format error";
            }
            uVar7 = FUN_180002f80(lVar6,1,DAT_181d7c9c0);
            cVar3 = Single.TryParse(uVar7,local_res8,0);
            if (!cVar3) {
              return "Command format error";
            }
            lVar6 = FUN_18046c0a0(0);
            if (((lVar6 != null) && (*(int64 *)(lVar6 + 32) != 0)) &&
               (lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0)) != null) {
              HeroData.ChangeGovernLv(lVar6,(int)local_res8[0],0);
              return 0;
            }
            goto LAB_180a04923;
          }
          uVar7 = "changepower";
          if (uVar4 == 0xf9cae8de) goto LAB_180a02281;
          if (uVar4 == 0xffb74d81) {
            cVar3 = FUN_1816fd990(lVar8,"changeareastate",0);
            if (!cVar3) {
              return "Wrong command";
            }
            if (*(int *)(lVar6 + 24) < 4) {
              return "Command format error";
            }
            uVar7 = FUN_180002f80(lVar6,1,DAT_181d7c9c0);
            lVar8 = Console.GetAreaData(uVar7,0);
            if (lVar8 == null) {
              return "Area not found";
            }
            uVar7 = FUN_180002f80(lVar6,2,DAT_181d7c9c0);
            cVar3 = Int32.TryParse(uVar7,&local_c4,0);
            if (!cVar3) {
              return "Command format error";
            }
            uVar7 = FUN_180002f80(lVar6,3,DAT_181d7c9c0);
            cVar3 = Single.TryParse(uVar7,local_res8,0);
            if (cVar3) {
              AreaData.ChangeAreaState(lVar8,local_c4,local_res8[0],1,0);
              return 0;
            }
            return "Command format error";
          }
          if (uVar4 != 0xffbc23af) {
            return "Wrong command";
          }
          cVar3 = FUN_1816fd990(lVar8,"getfood",0);
          uVar5 = (uint32)(in_stack_ffffffffffffff08 >> 32);
          if (!cVar3) {
            return "Wrong command";
          }
          if (*(int *)(lVar6 + 24) < 2) {
            return "Command format error";
          }
          uVar7 = FUN_180002f80(lVar6,1,DAT_181d7c9c0);
          cVar3 = Single.TryParse(uVar7,local_res8,0);
          if (!cVar3) {
            return "Command format error";
          }
          lVar6 = FUN_18046c0a0(0);
          if ((lVar6 == null) || (*(int64 *)(lVar6 + 32) == 0)) goto LAB_180a04923;
          lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0);
          lVar8 = FUN_18046c0a0(0);
          if (lVar8 == null) goto LAB_180a04923;
          uVar7 = GameController.GenerateFoodData(lVar8,(int)local_res8[0],0,0);
          goto joined_r0x000180a03079;
        }
        if (uVar4 < 0xe989cdc7) {
          if (uVar4 != 0xe3299366) {
            if (uVar4 != 0xe989cdc6) {
              return "Wrong command";
            }
            cVar3 = FUN_1816fd990(lVar8,"gamedifficulty",0);
            if (!cVar3) {
              return "Wrong command";
            }
            if (*(int *)(lVar6 + 24) < 2) {
              return "Command format error";
            }
            uVar7 = FUN_180002f80(lVar6,1,DAT_181d7c9c0);
            cVar3 = Single.TryParse(uVar7,local_res8,0);
            if (!cVar3) {
              return "Command format error";
            }
            lVar6 = FUN_18046c0a0(0);
            if ((lVar6 != null) && (*(int64 *)(lVar6 + 32) != 0)) {
              *(bool *)(*(int64 *)(lVar6 + 32) + 164) = local_res8[0] < 0.0;
              lVar6 = FUN_18046c0a0(0);
              fVar15 = local_res8[0];
              if (lVar6 != null) {
                lVar6 = *(int64 *)(lVar6 + 32);
                lVar8 = *(int64 *)(pStatics_ef00 + 192);
                if ((lVar8 != null) &&
                   (uVar5 = Mathf.Clamp((int)fVar15,0,*(int *)(lVar8 + 24) + -1,0), lVar6 != null)) {
                  *(uint32 *)(lVar6 + 160) = uVar5;
                  lVar6 = FUN_18046c0a0(0);
                  if ((lVar6 != null) && (*(int64 *)(lVar6 + 32) != 0)) {
                    uVar7 = WorldData.GetDifficlutyName(*(int64 *)(lVar6 + 32),0);
                    uVar10 = String.Format("游戏难度设置为 {0}",uVar7,0);
                    return uVar10;
                  }
                }
              }
            }
            goto LAB_180a04923;
          }
          cVar3 = FUN_1816fd990(lVar8,"injury",0);
          if (!cVar3) {
            return "Wrong command";
          }
          iVar12 = *(int *)(lVar6 + 24);
          if (iVar12 == 1) {
            return "Command format error";
          }
          if (iVar12 == 2) {
            uVar7 = FUN_180002f80(lVar6,1,DAT_181d7c9c0);
            cVar3 = Single.TryParse(uVar7,local_res8,0);
            if (!cVar3) {
              return "Command format error";
            }
            lVar6 = FUN_18046c0a0(0);
            if (((lVar6 == null) || (*(int64 *)(lVar6 + 32) == 0)) ||
               (lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0)) == null) goto LAB_180a04923;
            HeroData.ChangeExternalInjury(lVar6);
            lVar6 = FUN_18046c0a0(0);
            if (((lVar6 == null) || (*(int64 *)(lVar6 + 32) == 0)) ||
               (lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0)) == null) goto LAB_180a04923;
            HeroData.ChangeInternalInjury(lVar6);
          }
          else {
            if (iVar12 != 3) {
              uVar7 = FUN_180002f80(lVar6,1);
              lVar8 = Console.GetHeroData(uVar7,0);
              if (lVar8 == null) {
                return "Hero not found";
              }
              uVar7 = FUN_180002f80(lVar6,3,DAT_181d7c9c0);
              cVar3 = Single.TryParse(uVar7,local_res8,0);
              if (!cVar3) {
                return "Command format error";
              }
              lVar6 = FUN_180002f80(lVar6,2,DAT_181d7c9c0);
              if (lVar6 == null) {
                return "InjuryType not found";
              }
              cVar3 = FUN_1816fd990(lVar6,"外伤",0);
              if (cVar3) {
                HeroData.ChangeExternalInjury(lVar8);
                return 0;
              }
              cVar3 = FUN_1816fd990(lVar6,"内伤",0);
              if (cVar3) {
                HeroData.ChangeInternalInjury(lVar8);
                return 0;
              }
              cVar3 = FUN_1816fd990(lVar6,"中毒",0);
              if (!cVar3) {
                return "InjuryType not found";
              }
              goto LAB_1809ff1e8;
            }
            uVar7 = FUN_180002f80(lVar6,2);
            cVar3 = Single.TryParse(uVar7,local_res8,0);
            if (!cVar3) {
              return "Command format error";
            }
            uVar7 = FUN_180002f80(lVar6,1,DAT_181d7c9c0);
            cVar3 = FUN_1816fd990(uVar7,"外伤",0);
            if (!cVar3) {
              uVar7 = FUN_180002f80(lVar6,1,DAT_181d7c9c0);
              cVar3 = FUN_1816fd990(uVar7,"内伤",0);
              if (!cVar3) {
                uVar7 = FUN_180002f80(lVar6,1,DAT_181d7c9c0);
                cVar3 = FUN_1816fd990(uVar7,"中毒",0);
                if (!cVar3) {
                  uVar7 = FUN_180002f80(lVar6,1,DAT_181d7c9c0);
                  lVar8 = Console.GetHeroData(uVar7,0);
                  if (lVar8 == null) {
                    return "Hero not found";
                  }
                  HeroData.ChangeExternalInjury(lVar8);
                  HeroData.ChangeInternalInjury(lVar8);
                  goto LAB_1809ff1e8;
                }
              }
            }
            lVar6 = FUN_180002f80(lVar6,1,DAT_181d7c9c0);
            if (lVar6 == null) {
              return "InjuryType not found";
            }
            cVar3 = FUN_1816fd990(lVar6,"外伤",0);
            if (cVar3) {
              lVar6 = FUN_18046c0a0(0);
              if (((lVar6 != null) && (*(int64 *)(lVar6 + 32) != 0)) &&
                 (lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0)) != null) {
                HeroData.ChangeExternalInjury(lVar6);
                return 0;
              }
              goto LAB_180a04923;
            }
            cVar3 = FUN_1816fd990(lVar6,"内伤",0);
            if (cVar3) {
              lVar6 = FUN_18046c0a0(0);
              if (((lVar6 != null) && (*(int64 *)(lVar6 + 32) != 0)) &&
                 (lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0)) != null) {
                HeroData.ChangeInternalInjury(lVar6);
                return 0;
              }
              goto LAB_180a04923;
            }
            cVar3 = FUN_1816fd990(lVar6,"中毒",0);
            if (!cVar3) {
              return "InjuryType not found";
            }
          }
          lVar6 = FUN_18046c0a0(0);
          if (((lVar6 != null) && (*(int64 *)(lVar6 + 32) != 0)) &&
             (lVar8 = WorldData.Player(*(int64 *)(lVar6 + 32),0)) != null) {
        LAB_1809ff1e8:
            HeroData.ChangePoisonInjury(lVar8);
            return 0;
          }
          goto LAB_180a04923;
        }
        if (uVar4 == 0xebc18dc9) {
          cVar3 = FUN_1816fd990(lVar8,"heromaxattri",0);
          goto joined_r0x000180a01713;
        }
        if (uVar4 != 0xed2ad693) {
          return "Wrong command";
        }
        cVar3 = FUN_1816fd990(lVar8,"talentpoint",0);
        if (!cVar3) {
          return "Wrong command";
        }
        if (*(int *)(lVar6 + 24) < 2) {
          return "Command format error";
        }
        if (*(int *)(lVar6 + 24) < 3) {
          if ((*(byte *)(DAT_181d942b0 + 0x133) & 4) != 0) {
            iVar12 = *(int *)(DAT_181d942b0 + 224);
            goto LAB_1809fec2b;
          }
        }
        else {
          uVar10 = FUN_180002f80(lVar6,1,DAT_181d7c9c0);
          if ((*(byte *)(DAT_181d942b0 + 0x133) & 4) != 0) {
            iVar12 = *(int *)(DAT_181d942b0 + 224);
        LAB_1809fec2b:
            if (iVar12 == 0) {
              il2cpp_runtime_class_init();
            }
          }
        }
        lVar8 = Console.GetHeroData(uVar10,0);
        if (lVar8 == null) {
          return "Hero not found";
        }
        uVar7 = 2;
        if (*(int *)(lVar6 + 24) < 3) {
          uVar7 = 1;
        }
        uVar7 = FUN_180002f80(lVar6,uVar7,DAT_181d7c9c0);
        cVar3 = Single.TryParse(uVar7,local_res8,0);
        joined_r0x000180a003e4:
        if (cVar3) {
          HeroData.ChangeTagPoint(lVar8);
          return 0;
        }
        return "Command format error";
    }

    // Token : 0x60014F5
    // RVA   : 0x9FD8D0   Offset: 0x9FC0D0   Length: 0xD8
    public static AreaData GetAreaData(string areaName)
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        long lVar1;
        bool cVar2;
        ulong uVar3;
        cVar2 = FUN_180d6ca90(areaName,0);
        if (cVar2) {
          return 0;
        }
        if ((*pStatics != 0) &&
           (lVar1 = *(int64 *)(*pStatics + 32)) != null) {
          uVar3 = WorldData.GetArea(lVar1,areaName,0);
          return uVar3;
        }
    }

    // Token : 0x60014F6
    // RVA   : 0x9FDCA0   Offset: 0x9FC4A0   Length: 0xD3
    public static int GetSkillID(string skillName)
    {
        long lVar1;
        bool cVar2;
        ulong uVar3;
        cVar2 = FUN_180d6ca90(skillName,0);
        if (cVar2) {
          return 0xffffffff;
        }
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d4e010 + 184) + 32);
        if (lVar1 != null) {
          uVar3 = GameDataController.GetSkillID(lVar1,skillName,0);
          return uVar3;
        }
    }

    // Token : 0x60014F7
    // RVA   : 0x9FDB30   Offset: 0x9FC330   Length: 0x161
    public static HeroData GetHeroData(string heroName)
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        long lVar1;
        bool cVar2;
        cVar2 = FUN_180d6ca90(heroName,0);
        if (!cVar2) {
          if ((*pStatics != 0) &&
             (lVar1 = *(int64 *)(*pStatics + 32)) != null) {
            WorldData.GetHero(lVar1,heroName,0);
            return;
          }
        }
        else {
          if ((*pStatics != 0) &&
             (lVar1 = *(int64 *)(*pStatics + 32)) != null) {
            WorldData.Player(lVar1,0);
            return;
          }
        }
    }

    // Token : 0x60014F8
    // RVA   : 0x9FD9B0   Offset: 0x9FC1B0   Length: 0x173
    public static ForceData GetForceData(string forceName)
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        bool cVar1;
        long lVar2;
        cVar1 = FUN_180d6ca90(forceName,0);
        if (!cVar1) {
          if ((*pStatics != 0) &&
             (lVar2 = *(int64 *)(*pStatics + 32)) != null) {
            WorldData.GetForce(lVar2,forceName,0);
            return;
          }
        }
        else {
          if ((*pStatics != 0) &&
             (lVar2 = *(int64 *)(*pStatics + 32)) != null) {
            lVar2 = WorldData.Player(lVar2,0);
            if (lVar2 != null) {
              HeroData.GetForce(lVar2,0,0);
              return;
            }
          }
        }
    }

    // Token : 0x60014F9
    // RVA   : 0xA04950   Offset: 0xA03150   Length: 0x13D
    public static string Last()
    {
        var pStatics = *(int64*)(DAT_181d942b0 + 184);
        uint uVar2;
        long lVar3;
        if (*(int *)(pStatics + 24) == -1) {
          return 0;
        }
        piVar1 = (int *)(pStatics + 24);
        *piVar1 = *piVar1 + -1;
        if (*(int *)(pStatics + 24) < 0) {
          *(uint32 *)(pStatics + 24) = 0;
        }
        lVar3 = *(int64 *)(pStatics + 32);
        uVar2 = *(uint32 *)(pStatics + 24);
        if (lVar3 != null) {
          if (*(uint32 *)(lVar3 + 24) <= uVar2) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          return lVar3[uVar2];
        }
    }

    // Token : 0x60014FA
    // RVA   : 0xA04A90   Offset: 0xA03290   Length: 0x162
    public static string Next()
    {
        var pStatics = *(int64*)(DAT_181d942b0 + 184);
        uint uVar2;
        long lVar3;
        if (*(int *)(pStatics + 24) == -1) {
          return 0;
        }
        piVar1 = (int *)(pStatics + 24);
        *piVar1 = *piVar1 + 1;
        lVar3 = *(int64 *)(pStatics + 32);
        if (lVar3 != null) {
          if (*(int *)(lVar3 + 24) <= *(int *)(pStatics + 24)) {
            lVar3 = *(int64 *)(pStatics + 32);
            if (lVar3 == null) throw; // [null/range check failed]
            *(int *)(pStatics + 24) = *(int *)(lVar3 + 24) + -1;
          }
          lVar3 = *(int64 *)(pStatics + 32);
          uVar2 = *(uint32 *)(pStatics + 24);
          if (lVar3 != null) {
            if (*(uint32 *)(lVar3 + 24) <= uVar2) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            return lVar3[uVar2];
          }
        }
    }

    // Token : 0x60014FB
    // RVA   : 0xA04C00   Offset: 0xA03400   Length: 0x278
    private static string Show()
    {
        var pStatics = *(int64*)(DAT_181d942b0 + 184);
        long lVar1;
        long lVar2;
        long lVar3;
        bool cVar4;
        ulong uVar5;
        ulong uVar6;
        uint uVar7;
        ulong uVar8;
        uVar8 = 0;
        uVar5 = uVar8;
        while( true ) {
          if (*pStatics == 0) break;
          uVar7 = (uint32)uVar8;
          if (*(int *)(*pStatics + 24) <= (int)uVar7) {
            return uVar5;
          }
          if (*(int *)(*(int64 *)(DAT_181d4ef00 + 184) + 12) == 1) {
            lVar2 = *pStatics;
            lVar3 = (pStatics)[1];
            if (lVar2 == null) break;
            if (*(uint32 *)(lVar2 + 24) <= uVar7) {
              uVar6 = il2cpp_internal(lVar3);
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar6,0);
            }
            lVar1 = (int64)(int)uVar7 * 8 + 32;
            cVar4 = FUN_18095def0(lVar3,*(uint64 *)(lVar1 + lVar2),DAT_181d89f38);
            if (!cVar4) {
              lVar2 = *pStatics;
              if (lVar2 == null) break;
              if (*(uint32 *)(lVar2 + 24) <= uVar7) {
                uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar6,0);
              }
              cVar4 = FUN_18095def0((pStatics)[2],
                                    *(uint64 *)(lVar1 + lVar2),DAT_181d89f38);
              if (!(!cVar4))
              {
                }
                }
                else {
              }
            lVar2 = *pStatics;
            if (lVar2 == null) break;
            if (*(uint32 *)(lVar2 + 24) <= uVar7) {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar6,0);
            }
            uVar5 = String.Concat(uVar5,lVar2[uVar7],0);
            if (*pStatics == 0) break;
            if (uVar7 != *(int *)(*pStatics + 24) - 1U) {
              uVar5 = String.Concat(uVar5,"\n",0);
            }
          }
          uVar8 = (uint64)(uVar7 + 1);
        }
    }

    // Token : 0x60014FC
    // RVA   : 0x9FD820   Offset: 0x9FC020   Length: 0xA2
    private static string Clear()
    {
        var pStatics = *(int64*)(DAT_181d942b0 + 184);
        long lVar1;
        *(uint32 *)(pStatics + 24) = 0xffffffff;
        lVar1 = *(int64 *)(pStatics + 32);
        if (lVar1 != null) {
          FUN_180f56130(lVar1,DAT_181d7c450);
          return "cls";
        }
    }

    // Token : 0x60014FD
    // RVA   : 0xA04E80   Offset: 0xA03680   Length: 0x30EC
    private static void /*cctor*/()
    {
        var pStatics = *(int64*)(DAT_181d942b0 + 184);
        long lVar2;
        ulong uVar3;
        plVar1 = (int64 *)FUN_1800d60b0(DAT_181d80cc0,70);
        if (plVar1 != (int64 *)0) {
          if (("help" != 0) &&
             (lVar2 = il2cpp_internal("help",*(uint64 *)(*plVar1 + 64))) == null) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          lVar2 = "help";
          if ((int)plVar1[3] == 0) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          plVar1[4] = "help";
          il2cpp_internal(plVar1 + 4,lVar2);
          if (("clear" != 0) &&
             (lVar2 = il2cpp_internal("clear",*(uint64 *)(*plVar1 + 64))) == null) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          lVar2 = "clear";
          if (*(uint32 *)(plVar1 + 3) < 2) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          plVar1[5] = "clear";
          il2cpp_internal(plVar1 + 5,lVar2);
          if (("test" != 0) &&
             (lVar2 = il2cpp_internal("test",*(uint64 *)(*plVar1 + 64))) == null) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          lVar2 = "test";
          if (*(uint32 *)(plVar1 + 3) < 3) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          plVar1[6] = "test";
          il2cpp_internal(plVar1 + 6,lVar2);
          if (("chapter" != 0) &&
             (lVar2 = il2cpp_internal("chapter",*(uint64 *)(*plVar1 + 64))) == null) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          lVar2 = "chapter";
          if (*(uint32 *)(plVar1 + 3) < 4) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          plVar1[7] = "chapter";
          il2cpp_internal(plVar1 + 7,lVar2);
          if (("money" != 0) &&
             (lVar2 = il2cpp_internal("money",*(uint64 *)(*plVar1 + 64))) == null) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          lVar2 = "money";
          if (*(uint32 *)(plVar1 + 3) < 5) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          plVar1[8] = "money";
          il2cpp_internal(plVar1 + 8,lVar2);
          if (("fame" != 0) &&
             (lVar2 = il2cpp_internal("fame",*(uint64 *)(*plVar1 + 64))) == null) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          lVar2 = "fame";
          if (*(uint32 *)(plVar1 + 3) < 6) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          plVar1[9] = "fame";
          il2cpp_internal(plVar1 + 9,lVar2);
          if (("badfame" != 0) &&
             (lVar2 = il2cpp_internal("badfame",*(uint64 *)(*plVar1 + 64))) == null) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          lVar2 = "badfame";
          if (*(uint32 *)(plVar1 + 3) < 7) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          plVar1[10] = "badfame";
          il2cpp_internal(plVar1 + 10,lVar2);
          if (("loyal" != 0) &&
             (lVar2 = il2cpp_internal("loyal",*(uint64 *)(*plVar1 + 64))) == null) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          lVar2 = "loyal";
          if (*(uint32 *)(plVar1 + 3) < 8) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          plVar1[11] = "loyal";
          il2cpp_internal(plVar1 + 11,lVar2);
          if (("contribution" != 0) &&
             (lVar2 = il2cpp_internal("contribution",*(uint64 *)(*plVar1 + 64))) == null) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          lVar2 = "contribution";
          if (*(uint32 *)(plVar1 + 3) < 9) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          plVar1[12] = "contribution";
          il2cpp_internal(plVar1 + 12,lVar2);
          if (("herocontribution" != 0) &&
             (lVar2 = il2cpp_internal("herocontribution",*(uint64 *)(*plVar1 + 64))) == null) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          lVar2 = "herocontribution";
          if (*(uint32 *)(plVar1 + 3) < 10) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          plVar1[13] = "herocontribution";
          il2cpp_internal(plVar1 + 13,lVar2);
          if (("governcontribution" != 0) &&
             (lVar2 = il2cpp_internal("governcontribution",*(uint64 *)(*plVar1 + 64))) == null) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          lVar2 = "governcontribution";
          if (*(uint32 *)(plVar1 + 3) < 11) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          plVar1[14] = "governcontribution";
          il2cpp_internal(plVar1 + 14,lVar2);
          if (("movespeed" != 0) &&
             (lVar2 = il2cpp_internal("movespeed",*(uint64 *)(*plVar1 + 64))) == null) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          lVar2 = "movespeed";
          if (*(uint32 *)(plVar1 + 3) < 12) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          plVar1[15] = "movespeed";
          il2cpp_internal(plVar1 + 15,lVar2);
          if (("herofavor" != 0) &&
             (lVar2 = il2cpp_internal("herofavor",*(uint64 *)(*plVar1 + 64))) == null) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          lVar2 = "herofavor";
          if (*(uint32 *)(plVar1 + 3) < 13) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          plVar1[16] = "herofavor";
          il2cpp_internal(plVar1 + 16,lVar2);
          if (("forcemeeting" != 0) &&
             (lVar2 = il2cpp_internal("forcemeeting",*(uint64 *)(*plVar1 + 64))) == null) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          lVar2 = "forcemeeting";
          if (*(uint32 *)(plVar1 + 3) < 14) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          plVar1[17] = "forcemeeting";
          il2cpp_internal(plVar1 + 17,lVar2);
          if (("winbattle" != 0) &&
             (lVar2 = il2cpp_internal("winbattle",*(uint64 *)(*plVar1 + 64))) == null) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          lVar2 = "winbattle";
          if (*(uint32 *)(plVar1 + 3) < 15) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          plVar1[18] = "winbattle";
          il2cpp_internal(plVar1 + 18,lVar2);
          if (("changeday" != 0) &&
             (lVar2 = il2cpp_internal("changeday",*(uint64 *)(*plVar1 + 64))) == null) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          lVar2 = "changeday";
          if (*(uint32 *)(plVar1 + 3) < 16) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          plVar1[19] = "changeday";
          il2cpp_internal(plVar1 + 19,lVar2);
          if (("changemonth" != 0) &&
             (lVar2 = il2cpp_internal("changemonth",*(uint64 *)(*plVar1 + 64))) == null) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          lVar2 = "changemonth";
          if (*(uint32 *)(plVar1 + 3) < 17) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          plVar1[20] = "changemonth";
          il2cpp_internal(plVar1 + 20,lVar2);
          if (("changeyear" != 0) &&
             (lVar2 = il2cpp_internal("changeyear",*(uint64 *)(*plVar1 + 64))) == null) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          lVar2 = "changeyear";
          if (*(uint32 *)(plVar1 + 3) < 18) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          plVar1[21] = "changeyear";
          il2cpp_internal(plVar1 + 21,lVar2);
          if (("heroforcelv" != 0) &&
             (lVar2 = il2cpp_internal("heroforcelv",*(uint64 *)(*plVar1 + 64))) == null) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          lVar2 = "heroforcelv";
          if (*(uint32 *)(plVar1 + 3) < 19) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          plVar1[22] = "heroforcelv";
          il2cpp_internal(plVar1 + 22,lVar2);
          if (("fullrecover" != 0) &&
             (lVar2 = il2cpp_internal("fullrecover",*(uint64 *)(*plVar1 + 64))) == null) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          lVar2 = "fullrecover";
          if (*(uint32 *)(plVar1 + 3) < 20) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          plVar1[23] = "fullrecover";
          il2cpp_internal(plVar1 + 23,lVar2);
          if (("injury" != 0) &&
             (lVar2 = il2cpp_internal("injury",*(uint64 *)(*plVar1 + 64))) == null) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          lVar2 = "injury";
          if (*(uint32 *)(plVar1 + 3) < 21) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          plVar1[24] = "injury";
          il2cpp_internal(plVar1 + 24,lVar2);
          if (("seealltile" != 0) &&
             (lVar2 = il2cpp_internal("seealltile",*(uint64 *)(*plVar1 + 64))) == null) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          lVar2 = "seealltile";
          if (*(uint32 *)(plVar1 + 3) < 22) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          plVar1[25] = "seealltile";
          il2cpp_internal(plVar1 + 25,lVar2);
          if (("seeallrandomevent" != 0) &&
             (lVar2 = il2cpp_internal("seeallrandomevent",*(uint64 *)(*plVar1 + 64))) == null) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          lVar2 = "seeallrandomevent";
          if (*(uint32 *)(plVar1 + 3) < 23) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          plVar1[26] = "seeallrandomevent";
          il2cpp_internal(plVar1 + 26,lVar2);
          if (("upgradeskill" != 0) &&
             (lVar2 = il2cpp_internal("upgradeskill",*(uint64 *)(*plVar1 + 64))) == null) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          lVar2 = "upgradeskill";
          if (*(uint32 *)(plVar1 + 3) < 24) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          plVar1[27] = "upgradeskill";
          il2cpp_internal(plVar1 + 27,lVar2);
          if (("upgradeallskill" != 0) &&
             (lVar2 = il2cpp_internal("upgradeallskill",*(uint64 *)(*plVar1 + 64))) == null) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          lVar2 = "upgradeallskill";
          if (*(uint32 *)(plVar1 + 3) < 25) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          plVar1[28] = "upgradeallskill";
          il2cpp_internal(plVar1 + 28,lVar2);
          if (("talentpoint" != 0) &&
             (lVar2 = il2cpp_internal("talentpoint",*(uint64 *)(*plVar1 + 64))) == null) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          lVar2 = "talentpoint";
          if (*(uint32 *)(plVar1 + 3) < 26) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          plVar1[29] = "talentpoint";
          il2cpp_internal(plVar1 + 29,lVar2);
          if (("forcefavor" != 0) &&
             (lVar2 = il2cpp_internal("forcefavor",*(uint64 *)(*plVar1 + 64))) == null) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          lVar2 = "forcefavor";
          if (*(uint32 *)(plVar1 + 3) < 27) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          plVar1[30] = "forcefavor";
          il2cpp_internal(plVar1 + 30,lVar2);
          if (("randomitem" != 0) &&
             (lVar2 = il2cpp_internal("randomitem",*(uint64 *)(*plVar1 + 64))) == null) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          lVar2 = "randomitem";
          if (*(uint32 *)(plVar1 + 3) < 28) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          plVar1[31] = "randomitem";
          il2cpp_internal(plVar1 + 31,lVar2);
          if (("forceresource" != 0) &&
             (lVar2 = il2cpp_internal("forceresource",*(uint64 *)(*plVar1 + 64))) == null) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          lVar2 = "forceresource";
          if (*(uint32 *)(plVar1 + 3) < 29) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          plVar1[32] = "forceresource";
          il2cpp_internal(plVar1 + 32,lVar2);
          if (("conquer" != 0) &&
             (lVar2 = il2cpp_internal("conquer",*(uint64 *)(*plVar1 + 64))) == null) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          lVar2 = "conquer";
          if (*(uint32 *)(plVar1 + 3) < 30) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          plVar1[33] = "conquer";
          il2cpp_internal(plVar1 + 33,lVar2);
          if (("conquerall" != 0) &&
             (lVar2 = il2cpp_internal("conquerall",*(uint64 *)(*plVar1 + 64))) == null) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          lVar2 = "conquerall";
          if (*(uint32 *)(plVar1 + 3) < 31) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          plVar1[34] = "conquerall";
          il2cpp_internal(plVar1 + 34,lVar2);
          if (("upgradebuilding" != 0) &&
             (lVar2 = il2cpp_internal("upgradebuilding",*(uint64 *)(*plVar1 + 64))) == null) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          lVar2 = "upgradebuilding";
          if (*(uint32 *)(plVar1 + 3) < 32) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          plVar1[35] = "upgradebuilding";
          il2cpp_internal(plVar1 + 35,lVar2);
          if (("invincible" != 0) &&
             (lVar2 = il2cpp_internal("invincible",*(uint64 *)(*plVar1 + 64))) == null) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          lVar2 = "invincible";
          if (*(uint32 *)(plVar1 + 3) < 33) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          plVar1[36] = "invincible";
          il2cpp_internal(plVar1 + 36,lVar2);
          if (("heroattri" != 0) &&
             (lVar2 = il2cpp_internal("heroattri",*(uint64 *)(*plVar1 + 64))) == null) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          lVar2 = "heroattri";
          if (*(uint32 *)(plVar1 + 3) < 34) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          plVar1[37] = "heroattri";
          il2cpp_internal(plVar1 + 37,lVar2);
          if (("heromaxattri" != 0) &&
             (lVar2 = il2cpp_internal("heromaxattri",*(uint64 *)(*plVar1 + 64))) == null) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          lVar2 = "heromaxattri";
          if (*(uint32 *)(plVar1 + 3) < 35) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          plVar1[38] = "heromaxattri";
          il2cpp_internal(plVar1 + 38,lVar2);
          if (("herofightskill" != 0) &&
             (lVar2 = il2cpp_internal("herofightskill",*(uint64 *)(*plVar1 + 64))) == null) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          lVar2 = "herofightskill";
          if (*(uint32 *)(plVar1 + 3) < 36) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          plVar1[39] = "herofightskill";
          il2cpp_internal(plVar1 + 39,lVar2);
          if (("heromaxfightskill" != 0) &&
             (lVar2 = il2cpp_internal("heromaxfightskill",*(uint64 *)(*plVar1 + 64))) == null) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          lVar2 = "heromaxfightskill";
          if (*(uint32 *)(plVar1 + 3) < 37) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          plVar1[40] = "heromaxfightskill";
          il2cpp_internal(plVar1 + 40,lVar2);
          if (("herolivingskill" != 0) &&
             (lVar2 = il2cpp_internal("herolivingskill",*(uint64 *)(*plVar1 + 64))) == null) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          lVar2 = "herolivingskill";
          if (*(uint32 *)(plVar1 + 3) < 38) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          plVar1[41] = "herolivingskill";
          il2cpp_internal(plVar1 + 41,lVar2);
          if (("heromaxlivingskill" != 0) &&
             (lVar2 = il2cpp_internal("heromaxlivingskill",*(uint64 *)(*plVar1 + 64))) == null) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          lVar2 = "heromaxlivingskill";
          if (*(uint32 *)(plVar1 + 3) < 39) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          plVar1[42] = "heromaxlivingskill";
          il2cpp_internal(plVar1 + 42,lVar2);
          if (("changehp" != 0) &&
             (lVar2 = il2cpp_internal("changehp",*(uint64 *)(*plVar1 + 64))) == null) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          lVar2 = "changehp";
          if (*(uint32 *)(plVar1 + 3) < 40) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          plVar1[43] = "changehp";
          il2cpp_internal(plVar1 + 43,lVar2);
          if (("changemp" != 0) &&
             (lVar2 = il2cpp_internal("changemp",*(uint64 *)(*plVar1 + 64))) == null) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          lVar2 = "changemp";
          if (*(uint32 *)(plVar1 + 3) < 41) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          plVar1[44] = "changemp";
          il2cpp_internal(plVar1 + 44,lVar2);
          if (("plothappened" != 0) &&
             (lVar2 = il2cpp_internal("plothappened",*(uint64 *)(*plVar1 + 64))) == null) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          lVar2 = "plothappened";
          if (*(uint32 *)(plVar1 + 3) < 42) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          plVar1[45] = "plothappened";
          il2cpp_internal(plVar1 + 45,lVar2);
          if (("worldeventhappened" != 0) &&
             (lVar2 = il2cpp_internal("worldeventhappened",*(uint64 *)(*plVar1 + 64))) == null) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          lVar2 = "worldeventhappened";
          if (*(uint32 *)(plVar1 + 3) < 43) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          plVar1[46] = "worldeventhappened";
          il2cpp_internal(plVar1 + 46,lVar2);
          if (("changeweather" != 0) &&
             (lVar2 = il2cpp_internal("changeweather",*(uint64 *)(*plVar1 + 64))) == null) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          lVar2 = "changeweather";
          if (*(uint32 *)(plVar1 + 3) < 44) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          plVar1[47] = "changeweather";
          il2cpp_internal(plVar1 + 47,lVar2);
          if (("governlv" != 0) &&
             (lVar2 = il2cpp_internal("governlv",*(uint64 *)(*plVar1 + 64))) == null) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          lVar2 = "governlv";
          if (*(uint32 *)(plVar1 + 3) < 45) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          plVar1[48] = "governlv";
          il2cpp_internal(plVar1 + 48,lVar2);
          if (("hornorlv" != 0) &&
             (lVar2 = il2cpp_internal("hornorlv",*(uint64 *)(*plVar1 + 64))) == null) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          lVar2 = "hornorlv";
          if (*(uint32 *)(plVar1 + 3) < 46) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          plVar1[49] = "hornorlv";
          il2cpp_internal(plVar1 + 49,lVar2);
          if (("startplot" != 0) &&
             (lVar2 = il2cpp_internal("startplot",*(uint64 *)(*plVar1 + 64))) == null) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          lVar2 = "startplot";
          if (*(uint32 *)(plVar1 + 3) < 47) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          plVar1[50] = "startplot";
          il2cpp_internal(plVar1 + 50,lVar2);
          if (("gamedifficulty" != 0) &&
             (lVar2 = il2cpp_internal("gamedifficulty",*(uint64 *)(*plVar1 + 64))) == null) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          lVar2 = "gamedifficulty";
          if (*(uint32 *)(plVar1 + 3) < 48) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          plVar1[51] = "gamedifficulty";
          il2cpp_internal(plVar1 + 51,lVar2);
          if (("ally" != 0) &&
             (lVar2 = il2cpp_internal("ally",*(uint64 *)(*plVar1 + 64))) == null) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          lVar2 = "ally";
          if (*(uint32 *)(plVar1 + 3) < 49) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          plVar1[52] = "ally";
          il2cpp_internal(plVar1 + 52,lVar2);
          if (("stopwar" != 0) &&
             (lVar2 = il2cpp_internal("stopwar",*(uint64 *)(*plVar1 + 64))) == null) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          lVar2 = "stopwar";
          if (*(uint32 *)(plVar1 + 3) < 50) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          plVar1[53] = "stopwar";
          il2cpp_internal(plVar1 + 53,lVar2);
          if (("starttutorial" != 0) &&
             (lVar2 = il2cpp_internal("starttutorial",*(uint64 *)(*plVar1 + 64))) == null) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          lVar2 = "starttutorial";
          if (*(uint32 *)(plVar1 + 3) < 51) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          plVar1[54] = "starttutorial";
          il2cpp_internal(plVar1 + 54,lVar2);
          if (("clearallach" != 0) &&
             (lVar2 = il2cpp_internal("clearallach",*(uint64 *)(*plVar1 + 64))) == null) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          lVar2 = "clearallach";
          if (*(uint32 *)(plVar1 + 3) < 52) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          plVar1[55] = "clearallach";
          il2cpp_internal(plVar1 + 55,lVar2);
          if (("tagpoint" != 0) &&
             (lVar2 = il2cpp_internal("tagpoint",*(uint64 *)(*plVar1 + 64))) == null) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          lVar2 = "tagpoint";
          if (*(uint32 *)(plVar1 + 3) < 53) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          plVar1[56] = "tagpoint";
          il2cpp_internal(plVar1 + 56,lVar2);
          if (("getweapon" != 0) &&
             (lVar2 = il2cpp_internal("getweapon",*(uint64 *)(*plVar1 + 64))) == null) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          lVar2 = "getweapon";
          if (*(uint32 *)(plVar1 + 3) < 54) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          plVar1[57] = "getweapon";
          il2cpp_internal(plVar1 + 57,lVar2);
          if (("getarmor" != 0) &&
             (lVar2 = il2cpp_internal("getarmor",*(uint64 *)(*plVar1 + 64))) == null) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          lVar2 = "getarmor";
          if (*(uint32 *)(plVar1 + 3) < 55) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          plVar1[58] = "getarmor";
          il2cpp_internal(plVar1 + 58,lVar2);
          if (("gethelmet" != 0) &&
             (lVar2 = il2cpp_internal("gethelmet",*(uint64 *)(*plVar1 + 64))) == null) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          lVar2 = "gethelmet";
          if (*(uint32 *)(plVar1 + 3) < 56) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          plVar1[59] = "gethelmet";
          il2cpp_internal(plVar1 + 59,lVar2);
          if (("getshoes" != 0) &&
             (lVar2 = il2cpp_internal("getshoes",*(uint64 *)(*plVar1 + 64))) == null) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          lVar2 = "getshoes";
          if (*(uint32 *)(plVar1 + 3) < 57) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          plVar1[60] = "getshoes";
          il2cpp_internal(plVar1 + 60,lVar2);
          if (("getmed" != 0) &&
             (lVar2 = il2cpp_internal("getmed",*(uint64 *)(*plVar1 + 64))) == null) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          lVar2 = "getmed";
          if (*(uint32 *)(plVar1 + 3) < 58) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          plVar1[61] = "getmed";
          il2cpp_internal(plVar1 + 61,lVar2);
          if (("getfood" != 0) &&
             (lVar2 = il2cpp_internal("getfood",*(uint64 *)(*plVar1 + 64))) == null) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          lVar2 = "getfood";
          if (*(uint32 *)(plVar1 + 3) < 59) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          plVar1[62] = "getfood";
          il2cpp_internal(plVar1 + 62,lVar2);
          if (("getbook" != 0) &&
             (lVar2 = il2cpp_internal("getbook",*(uint64 *)(*plVar1 + 64))) == null) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          lVar2 = "getbook";
          if (*(uint32 *)(plVar1 + 3) < 60) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          plVar1[63] = "getbook";
          il2cpp_internal(plVar1 + 63,lVar2);
          if (("gettreasure" != 0) &&
             (lVar2 = il2cpp_internal("gettreasure",*(uint64 *)(*plVar1 + 64))) == null) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          lVar2 = "gettreasure";
          if (*(uint32 *)(plVar1 + 3) < 61) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          plVar1[64] = "gettreasure";
          il2cpp_internal(plVar1 + 64,lVar2);
          if (("getmaterial" != 0) &&
             (lVar2 = il2cpp_internal("getmaterial",*(uint64 *)(*plVar1 + 64))) == null) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          lVar2 = "getmaterial";
          if (*(uint32 *)(plVar1 + 3) < 62) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          plVar1[65] = "getmaterial";
          il2cpp_internal(plVar1 + 65,lVar2);
          if (("gethorse" != 0) &&
             (lVar2 = il2cpp_internal("gethorse",*(uint64 *)(*plVar1 + 64))) == null) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          lVar2 = "gethorse";
          if (*(uint32 *)(plVar1 + 3) < 63) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          plVar1[66] = "gethorse";
          il2cpp_internal(plVar1 + 66,lVar2);
          if (("gethorsearmor" != 0) &&
             (lVar2 = il2cpp_internal("gethorsearmor",*(uint64 *)(*plVar1 + 64))) == null) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          lVar2 = "gethorsearmor";
          if (*(uint32 *)(plVar1 + 3) < 64) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          plVar1[67] = "gethorsearmor";
          il2cpp_internal(plVar1 + 67,lVar2);
          if (("creatrandomevent" != 0) &&
             (lVar2 = il2cpp_internal("creatrandomevent",*(uint64 *)(*plVar1 + 64))) == null) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          lVar2 = "creatrandomevent";
          if (*(uint32 *)(plVar1 + 3) < 65) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          plVar1[68] = "creatrandomevent";
          il2cpp_internal(plVar1 + 68,lVar2);
          if (("creatworldevent" != 0) &&
             (lVar2 = il2cpp_internal("creatworldevent",*(uint64 *)(*plVar1 + 64))) == null) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          lVar2 = "creatworldevent";
          if (*(uint32 *)(plVar1 + 3) < 66) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          plVar1[69] = "creatworldevent";
          il2cpp_internal(plVar1 + 69,lVar2);
          if (("creatplotevent" != 0) &&
             (lVar2 = il2cpp_internal("creatplotevent",*(uint64 *)(*plVar1 + 64))) == null) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          lVar2 = "creatplotevent";
          if (*(uint32 *)(plVar1 + 3) < 67) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          plVar1[70] = "creatplotevent";
          il2cpp_internal(plVar1 + 70,lVar2);
          if (("changeareastate" != 0) &&
             (lVar2 = il2cpp_internal("changeareastate",*(uint64 *)(*plVar1 + 64))) == null) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          lVar2 = "changeareastate";
          if (*(uint32 *)(plVar1 + 3) < 68) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          plVar1[71] = "changeareastate";
          il2cpp_internal(plVar1 + 71,lVar2);
          if (("triggerend" != 0) &&
             (lVar2 = il2cpp_internal("triggerend",*(uint64 *)(*plVar1 + 64))) == null) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          lVar2 = "triggerend";
          if (*(uint32 *)(plVar1 + 3) < 69) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          plVar1[72] = "triggerend";
          il2cpp_internal(plVar1 + 72,lVar2);
          if (("changepower" != 0) &&
             (lVar2 = il2cpp_internal("changepower",*(uint64 *)(*plVar1 + 64))) == null) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          lVar2 = "changepower";
          if (*(uint32 *)(plVar1 + 3) < 70) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          plVar1[73] = "changepower";
          il2cpp_internal(plVar1 + 73,lVar2);
          puVar4 = *(uint64 **)(DAT_181d942b0 + 184);
          *puVar4 = plVar1;
          il2cpp_internal(puVar4,plVar1);
          plVar1 = (int64 *)FUN_1800d60b0(DAT_181d80cc0,23);
          if (plVar1 != (int64 *)0) {
            if (("movespeed" != 0) &&
               (lVar2 = il2cpp_internal("movespeed",*(uint64 *)(*plVar1 + 64))) == null) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            lVar2 = "movespeed";
            if ((int)plVar1[3] == 0) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            plVar1[4] = "movespeed";
            il2cpp_internal(plVar1 + 4,lVar2);
            if (("winbattle" != 0) &&
               (lVar2 = il2cpp_internal("winbattle",*(uint64 *)(*plVar1 + 64))) == null) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            lVar2 = "winbattle";
            if (*(uint32 *)(plVar1 + 3) < 2) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            plVar1[5] = "winbattle";
            il2cpp_internal(plVar1 + 5,lVar2);
            if (("seealltile" != 0) &&
               (lVar2 = il2cpp_internal("seealltile",*(uint64 *)(*plVar1 + 64))) == null) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            lVar2 = "seealltile";
            if (*(uint32 *)(plVar1 + 3) < 3) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            plVar1[6] = "seealltile";
            il2cpp_internal(plVar1 + 6,lVar2);
            if (("seeallrandomevent" != 0) &&
               (lVar2 = il2cpp_internal("seeallrandomevent",*(uint64 *)(*plVar1 + 64))) == null) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            lVar2 = "seeallrandomevent";
            if (*(uint32 *)(plVar1 + 3) < 4) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            plVar1[7] = "seeallrandomevent";
            il2cpp_internal(plVar1 + 7,lVar2);
            if (("conquer" != 0) &&
               (lVar2 = il2cpp_internal("conquer",*(uint64 *)(*plVar1 + 64))) == null) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            lVar2 = "conquer";
            if (*(uint32 *)(plVar1 + 3) < 5) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            plVar1[8] = "conquer";
            il2cpp_internal(plVar1 + 8,lVar2);
            if (("invincible" != 0) &&
               (lVar2 = il2cpp_internal("invincible",*(uint64 *)(*plVar1 + 64))) == null) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            lVar2 = "invincible";
            if (*(uint32 *)(plVar1 + 3) < 6) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            plVar1[9] = "invincible";
            il2cpp_internal(plVar1 + 9,lVar2);
            if (("governlv" != 0) &&
               (lVar2 = il2cpp_internal("governlv",*(uint64 *)(*plVar1 + 64))) == null) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            lVar2 = "governlv";
            if (*(uint32 *)(plVar1 + 3) < 7) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            plVar1[10] = "governlv";
            il2cpp_internal(plVar1 + 10,lVar2);
            if (("hornorlv" != 0) &&
               (lVar2 = il2cpp_internal("hornorlv",*(uint64 *)(*plVar1 + 64))) == null) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            lVar2 = "hornorlv";
            if (*(uint32 *)(plVar1 + 3) < 8) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            plVar1[11] = "hornorlv";
            il2cpp_internal(plVar1 + 11,lVar2);
            if (("startplot" != 0) &&
               (lVar2 = il2cpp_internal("startplot",*(uint64 *)(*plVar1 + 64))) == null) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            lVar2 = "startplot";
            if (*(uint32 *)(plVar1 + 3) < 9) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            plVar1[12] = "startplot";
            il2cpp_internal(plVar1 + 12,lVar2);
            if (("gamedifficulty" != 0) &&
               (lVar2 = il2cpp_internal("gamedifficulty",*(uint64 *)(*plVar1 + 64))) == null) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            lVar2 = "gamedifficulty";
            if (*(uint32 *)(plVar1 + 3) < 10) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            plVar1[13] = "gamedifficulty";
            il2cpp_internal(plVar1 + 13,lVar2);
            if (("ally" != 0) &&
               (lVar2 = il2cpp_internal("ally",*(uint64 *)(*plVar1 + 64))) == null) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            lVar2 = "ally";
            if (*(uint32 *)(plVar1 + 3) < 11) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            plVar1[14] = "ally";
            il2cpp_internal(plVar1 + 14,lVar2);
            if (("stopwar" != 0) &&
               (lVar2 = il2cpp_internal("stopwar",*(uint64 *)(*plVar1 + 64))) == null) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            lVar2 = "stopwar";
            if (*(uint32 *)(plVar1 + 3) < 12) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            plVar1[15] = "stopwar";
            il2cpp_internal(plVar1 + 15,lVar2);
            if (("getweapon" != 0) &&
               (lVar2 = il2cpp_internal("getweapon",*(uint64 *)(*plVar1 + 64))) == null) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            lVar2 = "getweapon";
            if (*(uint32 *)(plVar1 + 3) < 13) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            plVar1[16] = "getweapon";
            il2cpp_internal(plVar1 + 16,lVar2);
            if (("getarmor" != 0) &&
               (lVar2 = il2cpp_internal("getarmor",*(uint64 *)(*plVar1 + 64))) == null) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            lVar2 = "getarmor";
            if (*(uint32 *)(plVar1 + 3) < 14) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            plVar1[17] = "getarmor";
            il2cpp_internal(plVar1 + 17,lVar2);
            if (("gethelmet" != 0) &&
               (lVar2 = il2cpp_internal("gethelmet",*(uint64 *)(*plVar1 + 64))) == null) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            lVar2 = "gethelmet";
            if (*(uint32 *)(plVar1 + 3) < 15) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            plVar1[18] = "gethelmet";
            il2cpp_internal(plVar1 + 18,lVar2);
            if (("getshoes" != 0) &&
               (lVar2 = il2cpp_internal("getshoes",*(uint64 *)(*plVar1 + 64))) == null) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            lVar2 = "getshoes";
            if (*(uint32 *)(plVar1 + 3) < 16) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            plVar1[19] = "getshoes";
            il2cpp_internal(plVar1 + 19,lVar2);
            if (("getmed" != 0) &&
               (lVar2 = il2cpp_internal("getmed",*(uint64 *)(*plVar1 + 64))) == null) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            lVar2 = "getmed";
            if (*(uint32 *)(plVar1 + 3) < 17) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            plVar1[20] = "getmed";
            il2cpp_internal(plVar1 + 20,lVar2);
            if (("getfood" != 0) &&
               (lVar2 = il2cpp_internal("getfood",*(uint64 *)(*plVar1 + 64))) == null) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            lVar2 = "getfood";
            if (*(uint32 *)(plVar1 + 3) < 18) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            plVar1[21] = "getfood";
            il2cpp_internal(plVar1 + 21,lVar2);
            if (("getbook" != 0) &&
               (lVar2 = il2cpp_internal("getbook",*(uint64 *)(*plVar1 + 64))) == null) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            lVar2 = "getbook";
            if (*(uint32 *)(plVar1 + 3) < 19) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            plVar1[22] = "getbook";
            il2cpp_internal(plVar1 + 22,lVar2);
            if (("gettreasure" != 0) &&
               (lVar2 = il2cpp_internal("gettreasure",*(uint64 *)(*plVar1 + 64))) == null) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            lVar2 = "gettreasure";
            if (*(uint32 *)(plVar1 + 3) < 20) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            plVar1[23] = "gettreasure";
            il2cpp_internal(plVar1 + 23,lVar2);
            if (("getmaterial" != 0) &&
               (lVar2 = il2cpp_internal("getmaterial",*(uint64 *)(*plVar1 + 64))) == null) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            lVar2 = "getmaterial";
            if (*(uint32 *)(plVar1 + 3) < 21) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            plVar1[24] = "getmaterial";
            il2cpp_internal(plVar1 + 24,lVar2);
            if (("gethorse" != 0) &&
               (lVar2 = il2cpp_internal("gethorse",*(uint64 *)(*plVar1 + 64))) == null) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            lVar2 = "gethorse";
            if (*(uint32 *)(plVar1 + 3) < 22) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            plVar1[25] = "gethorse";
            il2cpp_internal(plVar1 + 25,lVar2);
            if (("gethorsearmor" != 0) &&
               (lVar2 = il2cpp_internal("gethorsearmor",*(uint64 *)(*plVar1 + 64))) == null) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            lVar2 = "gethorsearmor";
            if (*(uint32 *)(plVar1 + 3) < 23) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            plVar1[26] = "gethorsearmor";
            il2cpp_internal(plVar1 + 26,lVar2);
            puVar4 = (uint64 *)(pStatics + 8);
            *puVar4 = plVar1;
            il2cpp_internal(puVar4,plVar1);
            plVar1 = (int64 *)FUN_1800d60b0(DAT_181d80cc0,18);
            if (plVar1 == (int64 *)0) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            if (("test" != 0) &&
               (lVar2 = il2cpp_internal("test",*(uint64 *)(*plVar1 + 64))) == null) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            lVar2 = "test";
            if ((int)plVar1[3] == 0) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            plVar1[4] = "test";
            il2cpp_internal(plVar1 + 4,lVar2);
            if (("chapter" != 0) &&
               (lVar2 = il2cpp_internal("chapter",*(uint64 *)(*plVar1 + 64))) == null) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            lVar2 = "chapter";
            if (*(uint32 *)(plVar1 + 3) < 2) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            plVar1[5] = "chapter";
            il2cpp_internal(plVar1 + 5,lVar2);
            if (("forcemeeting" != 0) &&
               (lVar2 = il2cpp_internal("forcemeeting",*(uint64 *)(*plVar1 + 64))) == null) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            lVar2 = "forcemeeting";
            if (*(uint32 *)(plVar1 + 3) < 3) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            plVar1[6] = "forcemeeting";
            il2cpp_internal(plVar1 + 6,lVar2);
            if (("changeday" != 0) &&
               (lVar2 = il2cpp_internal("changeday",*(uint64 *)(*plVar1 + 64))) == null) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            lVar2 = "changeday";
            if (*(uint32 *)(plVar1 + 3) < 4) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            plVar1[7] = "changeday";
            il2cpp_internal(plVar1 + 7,lVar2);
            if (("changemonth" != 0) &&
               (lVar2 = il2cpp_internal("changemonth",*(uint64 *)(*plVar1 + 64))) == null) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            lVar2 = "changemonth";
            if (*(uint32 *)(plVar1 + 3) < 5) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            plVar1[8] = "changemonth";
            il2cpp_internal(plVar1 + 8,lVar2);
            if (("changeyear" != 0) &&
               (lVar2 = il2cpp_internal("changeyear",*(uint64 *)(*plVar1 + 64))) == null) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            lVar2 = "changeyear";
            if (*(uint32 *)(plVar1 + 3) < 6) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            plVar1[9] = "changeyear";
            il2cpp_internal(plVar1 + 9,lVar2);
            if (("heroforcelv" != 0) &&
               (lVar2 = il2cpp_internal("heroforcelv",*(uint64 *)(*plVar1 + 64))) == null) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            lVar2 = "heroforcelv";
            if (*(uint32 *)(plVar1 + 3) < 7) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            plVar1[10] = "heroforcelv";
            il2cpp_internal(plVar1 + 10,lVar2);
            if (("randomitem" != 0) &&
               (lVar2 = il2cpp_internal("randomitem",*(uint64 *)(*plVar1 + 64))) == null) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            lVar2 = "randomitem";
            if (*(uint32 *)(plVar1 + 3) < 8) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            plVar1[11] = "randomitem";
            il2cpp_internal(plVar1 + 11,lVar2);
            if (("conquerall" != 0) &&
               (lVar2 = il2cpp_internal("conquerall",*(uint64 *)(*plVar1 + 64))) == null) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            lVar2 = "conquerall";
            if (*(uint32 *)(plVar1 + 3) < 9) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            plVar1[12] = "conquerall";
            il2cpp_internal(plVar1 + 12,lVar2);
            if (("plothappened" != 0) &&
               (lVar2 = il2cpp_internal("plothappened",*(uint64 *)(*plVar1 + 64))) == null) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            lVar2 = "plothappened";
            if (*(uint32 *)(plVar1 + 3) < 10) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            plVar1[13] = "plothappened";
            il2cpp_internal(plVar1 + 13,lVar2);
            if (("worldeventhappened" != 0) &&
               (lVar2 = il2cpp_internal("worldeventhappened",*(uint64 *)(*plVar1 + 64))) == null) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            lVar2 = "worldeventhappened";
            if (*(uint32 *)(plVar1 + 3) < 11) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            plVar1[14] = "worldeventhappened";
            il2cpp_internal(plVar1 + 14,lVar2);
            if (("changeweather" != 0) &&
               (lVar2 = il2cpp_internal("changeweather",*(uint64 *)(*plVar1 + 64))) == null) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            lVar2 = "changeweather";
            if (*(uint32 *)(plVar1 + 3) < 12) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            plVar1[15] = "changeweather";
            il2cpp_internal(plVar1 + 15,lVar2);
            if (("starttutorial" != 0) &&
               (lVar2 = il2cpp_internal("starttutorial",*(uint64 *)(*plVar1 + 64))) == null) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            lVar2 = "starttutorial";
            if (*(uint32 *)(plVar1 + 3) < 13) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            plVar1[16] = "starttutorial";
            il2cpp_internal(plVar1 + 16,lVar2);
            if (("clearallach" != 0) &&
               (lVar2 = il2cpp_internal("clearallach",*(uint64 *)(*plVar1 + 64))) == null) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            lVar2 = "clearallach";
            if (*(uint32 *)(plVar1 + 3) < 14) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            plVar1[17] = "clearallach";
            il2cpp_internal(plVar1 + 17,lVar2);
            if (("creatrandomevent" != 0) &&
               (lVar2 = il2cpp_internal("creatrandomevent",*(uint64 *)(*plVar1 + 64))) == null) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            lVar2 = "creatrandomevent";
            if (*(uint32 *)(plVar1 + 3) < 15) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            plVar1[18] = "creatrandomevent";
            il2cpp_internal(plVar1 + 18,lVar2);
            if (("creatworldevent" != 0) &&
               (lVar2 = il2cpp_internal("creatworldevent",*(uint64 *)(*plVar1 + 64))) == null) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            lVar2 = "creatworldevent";
            if (*(uint32 *)(plVar1 + 3) < 16) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            plVar1[19] = "creatworldevent";
            il2cpp_internal(plVar1 + 19,lVar2);
            if (("creatplotevent" != 0) &&
               (lVar2 = il2cpp_internal("creatplotevent",*(uint64 *)(*plVar1 + 64))) == null) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            lVar2 = "creatplotevent";
            if (*(uint32 *)(plVar1 + 3) < 17) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            plVar1[20] = "creatplotevent";
            il2cpp_internal(plVar1 + 20,lVar2);
            if (("triggerend" != 0) &&
               (lVar2 = il2cpp_internal("triggerend",*(uint64 *)(*plVar1 + 64))) == null) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            lVar2 = "triggerend";
            if (*(uint32 *)(plVar1 + 3) < 18) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            plVar1[21] = "triggerend";
            il2cpp_internal(plVar1 + 21,lVar2);
            puVar4 = (uint64 *)(pStatics + 16);
            *puVar4 = plVar1;
            il2cpp_internal(puVar4,plVar1);
            *(uint32 *)(pStatics + 24) = 0xffffffff;
            uVar3 = il2cpp_internal(DAT_181d72a30);
            FUN_180f58a90(uVar3,DAT_181d7c250);
            puVar4 = (uint64 *)(pStatics + 32);
            *puVar4 = uVar3;
            il2cpp_internal(puVar4,uVar3);
            *(uint8 *)(pStatics + 40) = 0;
            return;
          }
        }
    }

}
