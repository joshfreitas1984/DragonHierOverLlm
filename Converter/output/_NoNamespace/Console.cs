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
        // Decompilation failed
        // Type: Console
        // Member: Input
        // RVA: 0x9FDD80
        // Error: Exception while decompiling 1809fdd80: process: timeout
    }

    // Token : 0x60014F5
    // RVA   : 0x9FD8D0   Offset: 0x9FC0D0   Length: 0xD8
    public static AreaData GetAreaData(string areaName)
    {
        long lVar1;
        bool cVar2;
        ulong uVar3;
        cVar2 = FUN_180d6ca90(areaName,0);
        if (cVar2) {
          return 0;
        }
        if ((GameController._instance != null) &&
           (lVar1 = GameController._instance.worldData) != null)
        {
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
        lVar1 = GameController.lockObj;
        if (lVar1 != null) {
          uVar3 = GameDataController.GetSkillID(lVar1,skillName,0);
          return uVar3;
        }
    }

    // Token : 0x60014F7
    // RVA   : 0x9FDB30   Offset: 0x9FC330   Length: 0x161
    public static HeroData GetHeroData(string heroName)
    {
        long lVar1;
        bool cVar2;
        cVar2 = FUN_180d6ca90(heroName,0);
        if (!cVar2) {
          if ((GameController._instance != null) &&
             (lVar1 = GameController._instance.worldData) != null
             ) {
            WorldData.GetHero(lVar1,heroName,0);
            return;
          }
        }
        else {
          if ((GameController._instance != null) &&
             (lVar1 = GameController._instance.worldData) != null
             ) {
            WorldData.Player(lVar1,0);
            return;
          }
        }
    }

    // Token : 0x60014F8
    // RVA   : 0x9FD9B0   Offset: 0x9FC1B0   Length: 0x173
    public static ForceData GetForceData(string forceName)
    {
        bool cVar1;
        long lVar2;
        cVar1 = FUN_180d6ca90(forceName,0);
        if (!cVar1) {
          if ((GameController._instance != null) &&
             (lVar2 = GameController._instance.worldData) != null
             ) {
            WorldData.GetForce(lVar2,forceName,0);
            return;
          }
        }
        else {
          if ((GameController._instance != null) &&
             (lVar2 = GameController._instance.worldData) != null
             ) {
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
        uint uVar2;
        long lVar3;
        if (Console.position == -1) {
          return 0;
        }
        Console.position = *piVar1 + -1;
        if (Console.position < 0) {
          Console.position = 0;
        }
        lVar3 = Console.consoleHistory;
        uVar2 = Console.position;
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
        uint uVar2;
        long lVar3;
        if (Console.position == -1) {
          return 0;
        }
        Console.position = *piVar1 + 1;
        lVar3 = Console.consoleHistory;
        if (lVar3 != null) {
          if (*(int *)(lVar3 + 24) <= Console.position) {
            lVar3 = Console.consoleHistory;
            if (lVar3 == null) throw; // [null/range check failed]
            Console.position = *(int *)(lVar3 + 24) + -1;
          }
          lVar3 = Console.consoleHistory;
          uVar2 = Console.position;
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
        var pConsole = *(int64*)(Console_StaticsPtr + 184);
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
          if (Console.command == null) break;
          uVar7 = (uint32)uVar8;
          if (*(int *)(Console.command + 24) <= (int)uVar7) {
            return uVar5;
          }
          if (*(int *)(*(int64 *)(PlotController_StaticsPtr + 184) + 12) == 1) {
            lVar2 = Console.command;
            lVar3 = (pConsole)[1];
            if (lVar2 == null) break;
            if (*(uint32 *)(lVar2 + 24) <= uVar7) {
              uVar6 = il2cpp_internal(lVar3);
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar6,0);
            }
            lVar1 = (int64)(int)uVar7 * 8 + 32;
            cVar4 = FUN_18095def0(lVar3,*(uint64 *)(lVar1 + lVar2),DAT_181d89f38);
            if (!cVar4) {
              lVar2 = Console.command;
              if (lVar2 == null) break;
              if (*(uint32 *)(lVar2 + 24) <= uVar7) {
                uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar6,0);
              }
              cVar4 = FUN_18095def0((pConsole)[2],
                                    *(uint64 *)(lVar1 + lVar2),DAT_181d89f38);
              if (!(!cVar4))
              {
                }
                }
                else {
              }
            lVar2 = Console.command;
            if (lVar2 == null) break;
            if (*(uint32 *)(lVar2 + 24) <= uVar7) {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar6,0);
            }
            uVar5 = String.Concat(uVar5,lVar2[uVar7],0);
            if (Console.command == null) break;
            if (uVar7 != *(int *)(Console.command + 24) - 1U) {
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
        long lVar1;
        Console.position = 0xffffffff;
        lVar1 = Console.consoleHistory;
        if (lVar1 != null) {
          FUN_180f56130(lVar1,DAT_181d7c450);
          return "cls";
        }
    }

    // Token : 0x60014FD
    // RVA   : 0xA04E80   Offset: 0xA03680   Length: 0x30EC
    private static void /*cctor*/()
    {
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
          puVar4 = *(uint64 **)(Console_StaticsPtr + 184);
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
            Console.releaseHideCommand = plVar1;
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
            Console.developCommand = plVar1;
            Console.position = 0xffffffff;
            uVar3 = il2cpp_internal(DAT_181d72a30);
            FUN_180f58a90(uVar3,DAT_181d7c250);
            Console.consoleHistory = uVar3;
            Console.invincible = 0;
            return;
          }
        }
    }

}
