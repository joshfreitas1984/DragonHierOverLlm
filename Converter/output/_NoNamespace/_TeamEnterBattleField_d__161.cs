// ============================================================
// Type  : <TeamEnterBattleField>d__161
// Token : 0x2000160
// ============================================================

public class <TeamEnterBattleField>d__161
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400098A
    private int <>1__state;

    // Token: 0x400098B
    private object <>2__current;

    // Token: 0x400098C
    public BattleController <>4__this;

    // Token: 0x400098D
    public List<List<TeamMemPrepareData>> targetTeamMemPrepareData;

    // Token: 0x400098E
    public bool isSupport;

    // Token: 0x400098F
    private int <teamID>5__2;

    // Token: 0x4000990
    private int <heroID>5__3;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000B99
    // RVA   : 0x608BA0   Offset: 0x6079A0   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x6000B9A
    // RVA   : 0x51CF50   Offset: 0x51BD50   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x6000B9B
    // RVA   : 0x67C530   Offset: 0x67B330   Length: 0x479
    private virtual bool MoveNext()
    {
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
          goto LAB_18067c632;
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
            lVar3 = BattleController.upHeroLayerOffset;
            if (lVar3 == null) {
              uVar7 = **(uint64 **)(DAT_181ea3298 + 184);
              lVar3 = new OnTooltipCB(uVar7,DAT_181e7ab10,DAT_181e8c190);
              BattleController.upHeroLayerOffset = lVar3;
            }
            if (lVar4 == null) break;
            List_1.Sort(lVar4,lVar3,DAT_181e88df0);
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
                     (lVar4 = FUN_1800024b0(this.targetTeamMemPrepareData,this.<teamID>5__2,
                                            DAT_181e5b210), lVar4 == null)) ||
                    (lVar4 = FUN_1800024b0(lVar4,this.<heroID>5__3,DAT_181e88ef0),
                    lVar4 == null)) ||
                   ((uVar7 = lVar4.Count, lVar1 == null ||
                    (*(int64 *)(lVar1 + 112) == 0)))) throw; // [null/range check failed]
                uVar5 = FUN_1800024b0(*(int64 *)(lVar1 + 112),this.<teamID>5__2,
                                      DAT_181e61878);
                if (*(int64 *)(lVar1 + 24) == 0) throw; // [null/range check failed]
                uVar6 = BattleMapData.GetRandomBornGrid
                                  (*(int64 *)(lVar1 + 24),this.<teamID>5__2,0);
                if (!this.isSupport) {
                  fVar11 = (float)Random.get_value(0);
                  if ((this.targetTeamMemPrepareData == null) ||
                     (lVar4 = FUN_1800024b0(this.targetTeamMemPrepareData,this.<teamID>5__2,
                                            DAT_181e5b210), lVar4 == null)) throw; // [null/range check failed]
                  uVar8 = fVar11 <= 1.0 / (float)lVar4.Count;
                }
                else {
                  uVar8 = 2;
                }
                BattleController.HeroEnterBattleField(lVar1,uVar7,uVar5,uVar6,uVar8,0,0);
                if ((this.targetTeamMemPrepareData != null) &&
                   (lVar4 = FUN_1800024b0(this.targetTeamMemPrepareData,this.<teamID>5__2,
                                          DAT_181e5b210), lVar4 != null)) {
                  Mathf.Max();
                  BattleController.GetHalfBattleTimeScale(lVar1,0);
                  uVar7 = new WaitForSeconds();
                  this.<>2__current = uVar7;
                  this.<>1__state = 1;
                  return true;
                }
                throw; // [null/range check failed]
              }
        LAB_18067c632:
              this.<heroID>5__3 = this.<heroID>5__3 + 1;
              iVar10 = this.<heroID>5__3;
            }
            uVar2 = this.<teamID>5__2 + 1;
          }
        }
    }

    // Token : 0x6000B9C
    // RVA   : 0x608B50   Offset: 0x607950   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x6000B9D
    // RVA   : 0x67C9B0   Offset: 0x67B7B0   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181e6d8e8);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181e7b610);
    }

    // Token : 0x6000B9E
    // RVA   : 0x608B50   Offset: 0x607950   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
