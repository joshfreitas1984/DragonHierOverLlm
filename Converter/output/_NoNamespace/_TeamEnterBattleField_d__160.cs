// ============================================================
// Type  : <TeamEnterBattleField>d__160
// Token : 0x200015F
// ============================================================

public class <TeamEnterBattleField>d__160
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400092C
    private int <>1__state;

    // Token: 0x400092D
    private object <>2__current;

    // Token: 0x400092E
    public BattleController <>4__this;

    // Token: 0x400092F
    public List<List<TeamMemPrepareData>> targetTeamMemPrepareData;

    // Token: 0x4000930
    public bool isSupport;

    // Token: 0x4000931
    private int <teamID>5__2;

    // Token: 0x4000932
    private int <heroID>5__3;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000B8C
    // RVA   : 0x219070   Offset: 0x217870   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x6000B8D
    // RVA   : 0x245810   Offset: 0x244010   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x6000B8E
    // RVA   : 0x8D3530   Offset: 0x8D1D30   Length: 0x479
    private virtual bool MoveNext()
    {
        var pStatics = *(int64*)(DAT_181d9d940 + 184);
        long lVar1;
        uint uVar2;
        long lVar3;
        long lVar4;
        ulong uVar5;
        ulong uVar6;
        ulong uVar7;
        byte uVar8;
        int iVar10;
        float fVar11;
        uVar2 = 0;
        lVar1 = this.<>4__this;
        if (this.<>1__state != 0) {
          if (this.<>1__state != 1) {
            return false;
          }
          this.<>1__state = 0xffffffff;
          goto LAB_1808d3632;
        }
        this.<>1__state = 0xffffffff;
        if (lVar1 != null) {
          *(uint8 *)(lVar1 + 0x128) = 1;
          while( true ) {
            this.<teamID>5__2 = uVar2;
            lVar4 = this.targetTeamMemPrepareData;
            if (lVar4 == null) break;
            if ((int)lVar4.Count <= (int)uVar2) {
              if (lVar1 != null) {
                *(uint8 *)(lVar1 + 0x128) = 0;
                return false;
              }
              break;
            }
            if (lVar4.Count <= uVar2) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar4 = lVar4._items[uVar2];
            lVar3 = *(int64 *)(pStatics + 16);
            if (lVar3 == null) {
              uVar7 = **(uint64 **)(DAT_181d9d940 + 184);
              lVar3 = new OnTooltipCB(uVar7,DAT_181d6e418,DAT_181d86418);
              plVar9 = (int64 *)(pStatics + 16);
              *plVar9 = lVar3;
              il2cpp_internal(plVar9,lVar3);
            }
            if (lVar4 == null) break;
            List_1.Sort(lVar4,lVar3,DAT_181d7ee38);
            this.<heroID>5__3 = 0;
            iVar10 = 0;
            while( true ) {
              lVar4 = this.targetTeamMemPrepareData;
              if (lVar4 == null) throw; // [null/range check failed]
              uVar2 = this.<teamID>5__2;
              if (lVar4.Count <= uVar2) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar4 = lVar4._items[uVar2];
              if (lVar4 == null) throw; // [null/range check failed]
              if (lVar4.Count <= iVar10) break;
              lVar4 = this.targetTeamMemPrepareData;
              if (lVar4 == null) throw; // [null/range check failed]
              uVar2 = this.<teamID>5__2;
              if (lVar4.Count <= uVar2) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar4 = lVar4._items[uVar2];
              if (lVar4 == null) throw; // [null/range check failed]
              uVar2 = this.<heroID>5__3;
              if (lVar4.Count <= uVar2) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar4 = lVar4._items[uVar2];
              if (lVar4 == null) throw; // [null/range check failed]
              if (*(char *)(lVar4 + 32) != false) {
                if ((((this.targetTeamMemPrepareData == null) ||
                     (lVar4 = FUN_180002f80(this.targetTeamMemPrepareData,this.<teamID>5__2,
                                            DAT_181d52088), lVar4 == null)) ||
                    (lVar4 = FUN_180002f80(lVar4,this.<heroID>5__3,DAT_181d7ef38),
                    lVar4 == null)) ||
                   ((uVar7 = lVar4.Count, lVar1 == null ||
                    (*(int64 *)(lVar1 + 112) == 0)))) throw; // [null/range check failed]
                uVar5 = FUN_180002f80(*(int64 *)(lVar1 + 112),this.<teamID>5__2,
                                      DAT_181d580a8);
                if (*(int64 *)(lVar1 + 24) == 0) throw; // [null/range check failed]
                uVar6 = BattleMapData.GetRandomBornGrid
                                  (*(int64 *)(lVar1 + 24),this.<teamID>5__2,0);
                if (!this.isSupport) {
                  fVar11 = (float)Random.get_value(0);
                  if ((this.targetTeamMemPrepareData == null) ||
                     (lVar4 = FUN_180002f80(this.targetTeamMemPrepareData,this.<teamID>5__2,
                                            DAT_181d52088), lVar4 == null)) throw; // [null/range check failed]
                  uVar8 = fVar11 <= 1.0 / (float)lVar4.Count;
                }
                else {
                  uVar8 = 2;
                }
                BattleController.HeroEnterBattleField(lVar1,uVar7,uVar5,uVar6,uVar8,0,0);
                if ((this.targetTeamMemPrepareData != null) &&
                   (lVar4 = FUN_180002f80(this.targetTeamMemPrepareData,this.<teamID>5__2,
                                          DAT_181d52088), lVar4 != null)) {
                  Mathf.Max();
                  BattleController.GetHalfBattleTimeScale(lVar1,0);
                  uVar7 = new WaitForSeconds();
                  this.<>2__current = uVar7;
                  this.<>1__state = 1;
                  return true;
                }
                throw; // [null/range check failed]
              }
        LAB_1808d3632:
              this.<heroID>5__3 = this.<heroID>5__3 + 1;
              iVar10 = this.<heroID>5__3;
            }
            uVar2 = this.<teamID>5__2 + 1;
          }
        }
    }

    // Token : 0x6000B8F
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x6000B90
    // RVA   : 0x8D39B0   Offset: 0x8D21B0   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181d682e8);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181d6ee98);
    }

    // Token : 0x6000B91
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
