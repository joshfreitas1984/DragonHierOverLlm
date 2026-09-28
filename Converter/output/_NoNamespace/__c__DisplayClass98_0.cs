// ============================================================
// Type  : <>c__DisplayClass98_0
// Token : 0x20002A2
// ============================================================

public class <>c__DisplayClass98_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001514
    public GameController <>4__this;

    // Token: 0x4001515
    public bool considerAIHour;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001640
    // RVA   : 0x210B70   Offset: 0x20FF70   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x6001641
    // RVA   : 0x93A250   Offset: 0x939650   Length: 0x472
    internal void <ManageAllAI>b__0()
    {
        ulong uVar1;
        long lVar2;
        bool cVar3;
        uint uVar4;
        long lVar5;
        long lVar6;
        ulong uVar7;
        uint uVar8;
        uint uVar9;
        bool[] local_res18 = new bool[8];
        ulong local_res20;
        local_res18[0] = false;
        uVar9 = 0;
        uVar1 = *(uint64 *)(*(int64 *)(DAT_181d72cc8 + 184) + 32);
        local_res20 = uVar1;
        Monitor.Enter(uVar1,local_res18,0);
        if (this.<>4__this == 0) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        lVar5 = *(int64 *)(this.<>4__this + 32);
        if (lVar5 == null) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        lVar5 = WorldData.Player(lVar5,0);
        if (lVar5 == null) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        cVar3 = HeroData.HaveArea(lVar5,0);
        uVar8 = uVar9;
        if (cVar3) {
          while( true ) {
            if (this.<>4__this == 0) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar5 = *(int64 *)(this.<>4__this + 32);
            if (lVar5 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar5 = WorldData.Player(lVar5,0);
            if (lVar5 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar5 = HeroData.GetArea(lVar5);
            if (lVar5 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            if (*(int64 *)(lVar5 + 120) == 0) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            if (*(int *)(*(int64 *)(lVar5 + 120) + 24) <= (int)uVar8) break;
            if (this.<>4__this == 0) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            if (*(int64 *)(this.<>4__this + 32) == 0) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar5 = WorldData.Player();
            if (lVar5 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar5 = HeroData.GetArea(lVar5);
            if (lVar5 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar5 = *(int64 *)(lVar5 + 120);
            if (lVar5 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            if (*(uint32 *)(lVar5 + 24) <= uVar8) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            if (lVar5[uVar8] != 0) {
              lVar5 = this.<>4__this;
              if (lVar5 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              lVar2 = *(int64 *)(lVar5 + 32);
              if (lVar2 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              lVar6 = WorldData.Player(lVar2,0);
              if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              lVar6 = HeroData.GetArea(lVar6,0);
              if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              if (*(int64 *)(lVar6 + 120) == 0) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              uVar4 = FUN_1800d6760(*(int64 *)(lVar6 + 120),uVar8,DAT_181d8fa18);
              uVar7 = WorldData.GetHero(lVar2,uVar4,0);
              GameController.ManageOneAI(lVar5,uVar7,this.considerAIHour,0);
            }
            uVar8 = uVar8 + 1;
          }
        }
        uVar8 = 1;
        while( true ) {
          lVar5 = this.<>4__this;
          if (lVar5 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          if (*(int64 *)(lVar5 + 32) == 0) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          lVar2 = *(int64 *)(*(int64 *)(lVar5 + 32) + 80);
          if (lVar2 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          if ((int)*(uint32 *)(lVar2 + 24) <= (int)uVar8) break;
          if (*(uint32 *)(lVar2 + 24) <= uVar8) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          GameController.ManageOneAI
                    (lVar5,lVar2[uVar8],
                     this.considerAIHour,0);
          uVar8 = uVar8 + 1;
        }
        while( true ) {
          lVar5 = this.<>4__this;
          if (lVar5 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          if (*(int64 *)(lVar5 + 32) == 0) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          lVar2 = *(int64 *)(*(int64 *)(lVar5 + 32) + 88);
          if (lVar2 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          if ((int)*(uint32 *)(lVar2 + 24) <= (int)uVar9) break;
          if (*(uint32 *)(lVar2 + 24) <= uVar9) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          GameController.ManageOneAI
                    (lVar5,lVar2[uVar9],
                     this.considerAIHour,0);
          uVar9 = uVar9 + 1;
        }
        if (local_res18[0] != false) {
          Monitor.Exit(uVar1,0);
        }
    }

}
