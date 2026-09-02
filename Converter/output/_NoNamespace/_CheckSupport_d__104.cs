// ============================================================
// Type  : <CheckSupport>d__104
// Token : 0x200015C
// ============================================================

public class <CheckSupport>d__104
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000920
    private int <>1__state;

    // Token: 0x4000921
    private object <>2__current;

    // Token: 0x4000922
    public BattleController <>4__this;

    // Token: 0x4000923
    private int <teamID>5__2;

    // Token: 0x4000924
    private int <heroID>5__3;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000B7B
    // RVA   : 0x219070   Offset: 0x217870   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x6000B7C
    // RVA   : 0x245810   Offset: 0x244010   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x6000B7D
    // RVA   : 0xB22FD0   Offset: 0xB217D0   Length: 0x3E5
    private virtual bool MoveNext()
    {
        uint uVar1;
        uint uVar2;
        long lVar3;
        long lVar4;
        long lVar5;
        ulong uVar6;
        ulong uVar7;
        ulong uVar8;
        uint uVar9;
        float fVar10;
        lVar3 = this.<>4__this;
        if (this.<>1__state == 0) {
          this.<>1__state = 0xffffffff;
          if (lVar3 != null) {
            *(uint8 *)(lVar3 + 0x128) = 1;
            uVar9 = 0;
            this.<teamID>5__2 = 0;
            while (lVar5 = *(int64 *)(lVar3 + 104)) != null {
              if ((int)*(uint32 *)(lVar5 + 24) <= (int)uVar9) {
                *(uint8 *)(lVar3 + 0x128) = 0;
                return false;
              }
              if (*(uint32 *)(lVar5 + 24) <= uVar9) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar5 = lVar5[uVar9];
              if (lVar5 == null) break;
              uVar9 = *(int *)(lVar5 + 24) - 1;
              this.<heroID>5__3 = uVar9;
              while (-1 < (int)uVar9) {
                lVar5 = *(int64 *)(lVar3 + 104);
                if (lVar5 == null) throw; // [null/range check failed]
                uVar1 = this.<teamID>5__2;
                if (*(uint32 *)(lVar5 + 24) <= uVar1) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  uVar9 = this.<heroID>5__3;
                }
                lVar5 = lVar5[uVar1];
                if (lVar5 == null) throw; // [null/range check failed]
                if (*(uint32 *)(lVar5 + 24) <= uVar9) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar5 = lVar5[uVar9];
                if (lVar5 == null) throw; // [null/range check failed]
                if (*(char *)(lVar5 + 32) != false) {
                  fVar10 = *(float *)(lVar3 + 0x1c8);
                  if (((*(int64 *)(lVar3 + 104) == 0) ||
                      (lVar5 = FUN_180002f80(*(int64 *)(lVar3 + 104),this.<teamID>5__2,
                                             DAT_181d52088), lVar5 == null)) ||
                     (lVar5 = FUN_180002f80(lVar5,this.<heroID>5__3,DAT_181d7ef38),
                     lVar5 == null)) throw; // [null/range check failed]
                  if (*(float *)(lVar5 + 36) <= fVar10) {
                    if (((*(int64 *)(lVar3 + 104) == 0) ||
                        (lVar5 = FUN_180002f80(*(int64 *)(lVar3 + 104),this.<teamID>5__2
                                               ,DAT_181d52088), lVar5 == null)) ||
                       (lVar5 = FUN_180002f80(lVar5,this.<heroID>5__3,DAT_181d7ef38),
                       lVar5 == null)) throw; // [null/range check failed]
                    uVar8 = *(uint64 *)(lVar5 + 24);
                    if (*(int64 *)(lVar3 + 112) == 0) throw; // [null/range check failed]
                    uVar6 = FUN_180002f80(*(int64 *)(lVar3 + 112),this.<teamID>5__2,
                                          DAT_181d580a8);
                    if (((*(int64 *)(lVar3 + 104) == 0) ||
                        (lVar5 = FUN_180002f80(*(int64 *)(lVar3 + 104),this.<teamID>5__2
                                               ,DAT_181d52088), lVar5 == null)) ||
                       (lVar5 = FUN_180002f80(lVar5,this.<heroID>5__3,DAT_181d7ef38),
                       lVar5 == null)) throw; // [null/range check failed]
                    lVar4 = *(int64 *)(lVar3 + 24);
                    if (*(int *)(lVar5 + 44) == -1) {
                      if (lVar4 == null) throw; // [null/range check failed]
                      uVar2 = this.<teamID>5__2;
                    }
                    else {
                      if ((((*(int64 *)(lVar3 + 104) == 0) ||
                           (lVar5 = FUN_180002f80(*(int64 *)(lVar3 + 104),
                                                  this.<teamID>5__2,DAT_181d52088),
                           lVar5 == null)) ||
                          (lVar5 = FUN_180002f80(lVar5,this.<heroID>5__3,DAT_181d7ef38),
                          lVar5 == null)) || (lVar4 == null)) throw; // [null/range check failed]
                      uVar2 = *(uint32 *)(lVar5 + 44);
                    }
                    uVar7 = BattleMapData.GetRandomBornGrid(lVar4,uVar2,0);
                    if (((*(int64 *)(lVar3 + 104) != 0) &&
                        (lVar5 = FUN_180002f80(*(int64 *)(lVar3 + 104),this.<teamID>5__2
                                               ,DAT_181d52088), lVar5 != null)) &&
                       (lVar5 = FUN_180002f80(lVar5,this.<heroID>5__3,DAT_181d7ef38),
                       lVar5 != null)) {
                      uVar2 = *(uint32 *)(lVar5 + 40);
                      fVar10 = (float)BattleController.GetHalfBattleTimeScale(lVar3,0);
                      if ((lVar3 != null) &&
                         (uVar8 = BattleController.HeroEnterBattleFieldCoroutine
                                            (lVar3,uVar8,uVar6,uVar7,2,uVar2,1.0 / fVar10,0), this != 0
                         )) {
                        this.<>2__current = uVar8;
                        this.<>1__state = 1;
                        return true;
                      }
                    }
                    throw; // [null/range check failed]
                  }
                }
        LAB_180b230c9:
                this.<heroID>5__3 = this.<heroID>5__3 + -1;
                uVar9 = this.<heroID>5__3;
              }
              this.<teamID>5__2 = this.<teamID>5__2 + 1;
              uVar9 = this.<teamID>5__2;
            }
          }
        }
        else {
          if (this.<>1__state != 1) {
            return false;
          }
          this.<>1__state = 0xffffffff;
          if ((lVar3 != null) && (lVar5 = *(int64 *)(lVar3 + 104)) != null) {
            uVar9 = this.<teamID>5__2;
            if (*(uint32 *)(lVar5 + 24) <= uVar9) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar5 = lVar5[uVar9];
            if (lVar5 != null) {
              FUN_18182b220(lVar5,this.<heroID>5__3,DAT_181d7edb8);
              goto LAB_180b230c9;
            }
          }
        }
    }

    // Token : 0x6000B7E
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x6000B7F
    // RVA   : 0xB233C0   Offset: 0xB21BC0   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181d682e8);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181d6e918);
    }

    // Token : 0x6000B80
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
