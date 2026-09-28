// ============================================================
// Type  : <TeamEnterBattleField>d__160
// Token : 0x2000164
// ============================================================

public class <TeamEnterBattleField>d__160
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40009A7
    private int <>1__state;

    // Token: 0x40009A8
    private object <>2__current;

    // Token: 0x40009A9
    public BattleController <>4__this;

    // Token: 0x40009AA
    public List<List<TeamMemPrepareData>> targetTeamMemPrepareData;

    // Token: 0x40009AB
    public bool isSupport;

    // Token: 0x40009AC
    private int <teamID>5__2;

    // Token: 0x40009AD
    private int <heroID>5__3;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000BB6
    // RVA   : 0x219070   Offset: 0x218470   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x6000BB7
    // RVA   : 0x245810   Offset: 0x244C10   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x6000BB8
    // RVA   : 0x935F40   Offset: 0x935340   Length: 0x479
    private virtual bool MoveNext()
    {
        var pStatics = *(int64*)(DAT_181dc2bf8 + 184);
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
          goto LAB_180936042;
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
              uVar7 = **(uint64 **)(DAT_181dc2bf8 + 184);
              lVar3 = new OnTooltipCB(uVar7,DAT_181d972b8,DAT_181dab7b8);
              plVar9 = (int64 *)(pStatics + 16);
              *plVar9 = lVar3;
              il2cpp_internal(plVar9,lVar3);
            }
            if (lVar4 == null) break;
            List_1.Sort(lVar4,lVar3,DAT_181da6798);
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
                                            DAT_181d79628), lVar4 == null)) ||
                    (lVar4 = FUN_180002f80(lVar4,this.<heroID>5__3,DAT_181da6898),
                    lVar4 == null)) ||
                   ((uVar7 = lVar4.Count, lVar1 == null ||
                    (*(int64 *)(lVar1 + 112) == 0)))) throw; // [null/range check failed]
                uVar5 = FUN_180002f80(*(int64 *)(lVar1 + 112),this.<teamID>5__2,
                                      DAT_181d7f830);
                if (*(int64 *)(lVar1 + 24) == 0) throw; // [null/range check failed]
                uVar6 = BattleMapData.GetRandomBornGrid
                                  (*(int64 *)(lVar1 + 24),this.<teamID>5__2,0);
                if (!this.isSupport) {
                  fVar11 = (float)Random.get_value(0);
                  if ((this.targetTeamMemPrepareData == null) ||
                     (lVar4 = FUN_180002f80(this.targetTeamMemPrepareData,this.<teamID>5__2,
                                            DAT_181d79628), lVar4 == null)) throw; // [null/range check failed]
                  uVar8 = fVar11 <= 1.0 / (float)lVar4.Count;
                }
                else {
                  uVar8 = 2;
                }
                BattleController.HeroEnterBattleField(lVar1,uVar7,uVar5,uVar6,uVar8,0,0);
                if ((this.targetTeamMemPrepareData != null) &&
                   (lVar4 = FUN_180002f80(this.targetTeamMemPrepareData,this.<teamID>5__2,
                                          DAT_181d79628), lVar4 != null)) {
                  Mathf.Max();
                  BattleController.GetHalfBattleTimeScale(lVar1,0);
                  uVar7 = new WaitForSeconds();
                  this.<>2__current = uVar7;
                  this.<>1__state = 1;
                  return true;
                }
                throw; // [null/range check failed]
              }
        LAB_180936042:
              this.<heroID>5__3 = this.<heroID>5__3 + 1;
              iVar10 = this.<heroID>5__3;
            }
            uVar2 = this.<teamID>5__2 + 1;
          }
        }
    }

    // Token : 0x6000BB9
    // RVA   : 0x20F140   Offset: 0x20E540   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x6000BBA
    // RVA   : 0x9363C0   Offset: 0x9357C0   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181d8d510);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181d97d38);
    }

    // Token : 0x6000BBB
    // RVA   : 0x20F140   Offset: 0x20E540   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
