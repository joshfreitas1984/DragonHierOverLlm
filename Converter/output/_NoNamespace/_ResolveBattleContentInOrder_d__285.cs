// ============================================================
// Type  : <ResolveBattleContentInOrder>d__285
// Token : 0x2000172
// ============================================================

public class <ResolveBattleContentInOrder>d__285
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40009D2
    private int <>1__state;

    // Token: 0x40009D3
    private object <>2__current;

    // Token: 0x40009D4
    public BattleController <>4__this;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000BFE
    // RVA   : 0x608BA0   Offset: 0x6079A0   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x6000BFF
    // RVA   : 0x51CF50   Offset: 0x51BD50   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x6000C00
    // RVA   : 0x678E10   Offset: 0x677C10   Length: 0x77E
    private virtual bool MoveNext()
    {
        int iVar1;
        uint uVar2;
        long lVar3;
        long lVar4;
        ulong uVar5;
        bool cVar6;
        long lVar7;
        long lVar8;
        ulong uVar9;
        ulong uVar10;
        uint uVar11;
        uint uVar12;
        uint uVar13;
        uint uVar14;
        float fVar15;
        float fVar16;
        float[] local_res8 = new float[2];
        iVar1 = this.<>1__state;
        lVar3 = this.<>4__this;
        local_res8[0] = 0.0;
        if (iVar1 == 0) {
          this.<>1__state = 0xffffffff;
          if (lVar3 == null) {
        LAB_180679589:
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          *(uint8 *)(lVar3 + 0x128) = 1;
        }
        else {
          if (iVar1 != 1) {
            if ((iVar1 != 2) && (iVar1 != 3)) {
              if (iVar1 == 4) {
                this.<>1__state = 0xffffffff;
                return false;
              }
              return false;
            }
            this.<>1__state = 0xffffffff;
            goto LAB_1806793c7;
          }
          this.<>1__state = 0xffffffff;
        }
        do {
          lVar7 = BuildingUIController.PartyLvName;
          if (lVar7 == null) goto LAB_180679589;
          if (*(char *)(lVar7 + 24) != false) {
            this.<>2__current = 0;
            this.<>1__state = 1;
            return true;
          }
          uVar14 = 0xffffffff;
          fVar15 = 3.4028235e+38;
          uVar13 = 0xffffffff;
          uVar12 = 0;
          while( true ) {
            if ((lVar3 == null) || (*(int64 *)(lVar3 + 104) == 0)) goto LAB_180679589;
            uVar11 = 0;
            if (*(int *)(*(int64 *)(lVar3 + 104) + 24) <= (int)uVar12) break;
            while( true ) {
              if ((*(int64 *)(lVar3 + 104) == 0) ||
                 (lVar7 = FUN_1800024b0(*(int64 *)(lVar3 + 104),uVar12,DAT_181e5b210)) == null)
              goto LAB_180679589;
              if (*(int *)(lVar7 + 24) <= (int)uVar11) break;
              if (((*(int64 *)(lVar3 + 104) == 0) ||
                  (lVar7 = FUN_1800024b0(*(int64 *)(lVar3 + 104),uVar12,DAT_181e5b210)) == null)
                 || (lVar7 = FUN_1800024b0(lVar7,uVar11,DAT_181e88ef0)) == null) goto LAB_180679589;
              if (*(char *)(lVar7 + 32) != false) {
                if (((*(int64 *)(lVar3 + 104) == 0) ||
                    (lVar7 = FUN_1800024b0(*(int64 *)(lVar3 + 104),uVar12,DAT_181e5b210)) == null)
                   || (lVar7 = FUN_1800024b0(lVar7,uVar11,DAT_181e88ef0)) == null) goto LAB_180679589;
                if (*(float *)(lVar7 + 36) <= fVar15 && fVar15 != *(float *)(lVar7 + 36)) {
                  if (((*(int64 *)(lVar3 + 104) == 0) ||
                      (lVar7 = FUN_1800024b0(*(int64 *)(lVar3 + 104),uVar12,DAT_181e5b210), lVar7 == null
                      )) || (lVar7 = FUN_1800024b0(lVar7,uVar11,DAT_181e88ef0)) == null)
                  goto LAB_180679589;
                  fVar15 = *(float *)(lVar7 + 36);
                  uVar13 = uVar11;
                  uVar14 = uVar12;
                }
              }
              uVar11 = uVar11 + 1;
            }
            uVar12 = uVar12 + 1;
          }
          uVar12 = 0xffffffff;
          fVar16 = 3.4028235e+38;
          lVar7 = 32;
          while( true ) {
            lVar8 = *(int64 *)(lVar3 + 128);
            if (lVar8 == null) goto LAB_180679589;
            uVar2 = *(uint32 *)(lVar8 + 24);
            if ((int)uVar2 <= (int)uVar11) break;
            if (uVar2 <= uVar11) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar8 = *(int64 *)(lVar7 + *(int64 *)(lVar8 + 16));
            if (lVar8 == null) goto LAB_180679589;
            if (*(int *)(lVar8 + 16) == 0) {
              if ((*(int64 *)(lVar3 + 128) == 0) ||
                 (lVar8 = FUN_1800024b0(*(int64 *)(lVar3 + 128),uVar11,DAT_181e614f8)) == null)
              goto LAB_180679589;
              cVar6 = Single.TryParse(*(uint64 *)(lVar8 + 24),local_res8,0);
              if ((cVar6) && (local_res8[0] < fVar16)) {
                fVar16 = local_res8[0];
                uVar12 = uVar11;
              }
            }
            uVar11 = uVar11 + 1;
            lVar7 = lVar7 + 8;
          }
          if ((int)uVar14 < 0) {
            if ((int)uVar12 < 0) {
              *(uint8 *)(lVar3 + 0x128) = 0;
              *(uint32 *)(lVar3 + 36) = 4;
              this.<>2__current = 0;
              this.<>1__state = 4;
              return true;
            }
        LAB_180679261:
            if (uVar2 <= uVar12) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            if ((lVar8[uVar12] == 0) ||
               (*(int64 *)(lVar3 + 128) == 0)) goto LAB_180679589;
            FUN_181763390(*(int64 *)(lVar3 + 128),uVar12);
            if (BuildingUIController.PartyLvName == null) goto LAB_180679589;
            PlotController.ChangePlotDataBase();
          }
          else {
            if ((-1 < (int)uVar12) && (fVar16 <= fVar15)) goto LAB_180679261;
            lVar7 = *(int64 *)(lVar3 + 104);
            if (lVar7 == null) goto LAB_180679589;
            if (*(uint32 *)(lVar7 + 24) <= uVar14) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar8 = (int64)(int)uVar14;
            lVar7 = *(int64 *)(*(int64 *)(lVar7 + 16) + 32 + lVar8 * 8);
            if (lVar7 == null) goto LAB_180679589;
            if (*(uint32 *)(lVar7 + 24) <= uVar13) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar4 = *(int64 *)(lVar3 + 104);
            lVar7 = lVar7[uVar13];
            if (lVar4 == null) goto LAB_180679589;
            if (*(uint32 *)(lVar4 + 24) <= uVar14) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            if ((*(int64 *)(*(int64 *)(lVar4 + 16) + 32 + lVar8 * 8) == 0) ||
               (FUN_181763390(), lVar7 == null)) goto LAB_180679589;
            if (*(char *)(lVar7 + 32) != false) {
              lVar4 = *(int64 *)(lVar3 + 112);
              uVar10 = *(uint64 *)(lVar7 + 24);
              if (lVar4 != null) {
                if (*(uint32 *)(lVar4 + 24) <= uVar14) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                uVar5 = *(uint64 *)(*(int64 *)(lVar4 + 16) + 32 + lVar8 * 8);
                uVar13 = *(uint32 *)(lVar7 + 44);
                if (uVar13 == 0xffffffff) {
                  uVar13 = uVar14;
                }
                if (*(int64 *)(lVar3 + 24) != 0) {
                  uVar9 = BattleMapData.GetRandomBornGrid(*(int64 *)(lVar3 + 24),uVar13,0);
                  BattleController.HeroEnterBattleField
                            (lVar3,uVar10,uVar5,uVar9,2,*(uint32 *)(lVar7 + 40),0);
                  fVar15 = (float)BattleController.GetHalfBattleTimeScale(lVar3,0);
                  uVar10 = new WaitForSeconds(0.25 / fVar15,0);
                  this.<>2__current = uVar10;
                  this.<>1__state = 2;
                  return true;
                }
              }
              goto LAB_180679589;
            }
          }
        LAB_1806793c7:
          lVar7 = BuildingUIController.PartyLvName;
          if (lVar7 == null) goto LAB_180679589;
          if (*(char *)(lVar7 + 24) != false) {
            this.<>2__current = 0;
            this.<>1__state = 3;
            return true;
          }
          if (lVar3 == null) goto LAB_180679589;
          cVar6 = BattleController.HasPendingEnemySupport(lVar3,*(uint32 *)(lVar3 + 48),0);
          if (cVar6) {
            *(uint8 *)(lVar3 + 0x128) = 0;
            return false;
          }
        } while( true );
    }

    // Token : 0x6000C01
    // RVA   : 0x608B50   Offset: 0x607950   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x6000C02
    // RVA   : 0x679590   Offset: 0x678390   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181e6d8e8);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181e7b510);
    }

    // Token : 0x6000C03
    // RVA   : 0x608B50   Offset: 0x607950   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
