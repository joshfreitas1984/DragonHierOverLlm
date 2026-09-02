// ============================================================
// Type  : <>c__DisplayClass98_0
// Token : 0x200029C
// ============================================================

public class <>c__DisplayClass98_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001462
    public GameController <>4__this;

    // Token: 0x4001463
    public bool considerAIHour;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60015FC
    // RVA   : 0x210B70   Offset: 0x20F370   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x60015FD
    // RVA   : 0x8D7E40   Offset: 0x8D6640   Length: 0x472
    internal void <ManageAllAI>b__0()
    {
        ulong uVar1;
        long lVar2;
        uint uVar3;
        long lVar4;
        long lVar5;
        ulong uVar6;
        uint uVar7;
        uint uVar8;
        bool[] local_res18 = new bool[8];
        ulong local_res20;
        local_res18[0] = false;
        uVar8 = 0;
        uVar1 = *(uint64 *)(*(int64 *)(DAT_181d4df90 + 184) + 32);
        local_res20 = uVar1;
        Monitor.Enter(uVar1,local_res18,0);
        if (this.<>4__this == 0) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        lVar4 = *(int64 *)(this.<>4__this + 32);
        if (lVar4 == null) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        lVar4 = WorldData.Player(lVar4,0);
        if (lVar4 == null) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        uVar7 = uVar8;
        if (-1 < *(int *)(lVar4 + 192)) {
          while( true ) {
            if (this.<>4__this == 0) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar4 = *(int64 *)(this.<>4__this + 32);
            if (lVar4 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar4 = WorldData.Player(lVar4,0);
            if (lVar4 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar4 = HeroData.GetArea(lVar4);
            if (lVar4 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            if (*(int64 *)(lVar4 + 120) == 0) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            if (*(int *)(*(int64 *)(lVar4 + 120) + 24) <= (int)uVar7) break;
            if (this.<>4__this == 0) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            if (*(int64 *)(this.<>4__this + 32) == 0) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar4 = WorldData.Player();
            if (lVar4 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar4 = HeroData.GetArea(lVar4);
            if (lVar4 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar4 = *(int64 *)(lVar4 + 120);
            if (lVar4 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            if (*(uint32 *)(lVar4 + 24) <= uVar7) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            if (lVar4[uVar7] != 0) {
              lVar4 = this.<>4__this;
              if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              lVar2 = *(int64 *)(lVar4 + 32);
              if (lVar2 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              lVar5 = WorldData.Player(lVar2,0);
              if (lVar5 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              lVar5 = HeroData.GetArea(lVar5,0);
              if (lVar5 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              if (*(int64 *)(lVar5 + 120) == 0) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              uVar3 = FUN_1800d6750(*(int64 *)(lVar5 + 120),uVar7,DAT_181d68270);
              uVar6 = WorldData.GetHero(lVar2,uVar3,0);
              GameController.ManageOneAI(lVar4,uVar6,this.considerAIHour,0);
            }
            uVar7 = uVar7 + 1;
          }
        }
        uVar7 = 1;
        while( true ) {
          lVar4 = this.<>4__this;
          if (lVar4 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          if (*(int64 *)(lVar4 + 32) == 0) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          lVar2 = *(int64 *)(*(int64 *)(lVar4 + 32) + 80);
          if (lVar2 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          if ((int)*(uint32 *)(lVar2 + 24) <= (int)uVar7) break;
          if (*(uint32 *)(lVar2 + 24) <= uVar7) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          GameController.ManageOneAI
                    (lVar4,lVar2[uVar7],
                     this.considerAIHour,0);
          uVar7 = uVar7 + 1;
        }
        while( true ) {
          lVar4 = this.<>4__this;
          if (lVar4 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          if (*(int64 *)(lVar4 + 32) == 0) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          lVar2 = *(int64 *)(*(int64 *)(lVar4 + 32) + 88);
          if (lVar2 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          if ((int)*(uint32 *)(lVar2 + 24) <= (int)uVar8) break;
          if (*(uint32 *)(lVar2 + 24) <= uVar8) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          GameController.ManageOneAI
                    (lVar4,lVar2[uVar8],
                     this.considerAIHour,0);
          uVar8 = uVar8 + 1;
        }
        if (local_res18[0] != false) {
          Monitor.Exit(uVar1,0);
        }
    }

}
