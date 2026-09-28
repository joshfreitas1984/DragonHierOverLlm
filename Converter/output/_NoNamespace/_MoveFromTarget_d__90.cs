// ============================================================
// Type  : <MoveFromTarget>d__90
// Token : 0x2000180
// ============================================================

public class <MoveFromTarget>d__90
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000A58
    private int <>1__state;

    // Token: 0x4000A59
    private object <>2__current;

    // Token: 0x4000A5A
    public int num;

    // Token: 0x4000A5B
    public BattleUnit <>4__this;

    // Token: 0x4000A5C
    public GridUnitData targetGrid;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000C80
    // RVA   : 0x219070   Offset: 0x218470   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x6000C81
    // RVA   : 0x245810   Offset: 0x244C10   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x6000C82
    // RVA   : 0x930070   Offset: 0x92F470   Length: 0x60A
    private virtual bool MoveNext()
    {
        var pStatics = *(int64*)(DAT_181d72cc8 + 184);
        float fVar1;
        long lVar2;
        bool cVar4;
        int iVar5;
        int iVar6;
        long lVar7;
        long lVar8;
        long lVar9;
        ulong uVar10;
        long lVar11;
        int iVar12;
        int iVar13;
        float fVar14;
        lVar2 = this.<>4__this;
        if (this.<>1__state == 0) {
          this.<>1__state = 0xffffffff;
          if (this.num != null) {
            if (lVar2 != null) {
              lVar11 = *(int64 *)(lVar2 + 96);
              while( true ) {
                if ((lVar11 == null) || (lVar7 = this.targetGrid) == null)
                goto LAB_180930675;
                iVar12 = *(int *)(lVar11 + 40) - *(int *)(lVar7 + 40);
                iVar13 = *(int *)(lVar11 + 36) - *(int *)(lVar7 + 36);
                if ((iVar12 == 0) && (iVar13 == 0)) break;
                iVar5 = Mathf.Abs(iVar12,0);
                iVar6 = Mathf.Abs(iVar13,0);
                if (iVar5 < iVar6) {
                  if (this.num < 1) {
                    lVar7 = FUN_18046bb80(0);
                    if ((lVar7 == null) || (*(int64 *)(lVar7 + 24) == 0)) goto LAB_180930675;
                    lVar7 = BattleMapData.GetGridDataByDir
                                      (*(int64 *)(lVar7 + 24),*(uint32 *)(lVar11 + 36),
                                       *(uint32 *)(lVar11 + 40),(iVar13 < 1) + '\x02',0);
                    lVar8 = FUN_18046bb80(0);
                    if ((lVar8 == null) || (lVar8 = *(int64 *)(lVar8 + 24)) == null)
                    goto LAB_180930675;
                    cVar4 = iVar12 < 1;
                  }
                  else {
                    lVar7 = FUN_18046bb80(0);
                    if ((lVar7 == null) || (*(int64 *)(lVar7 + 24) == 0)) goto LAB_180930675;
                    lVar7 = BattleMapData.GetGridDataByDir
                                      (*(int64 *)(lVar7 + 24),*(uint32 *)(lVar11 + 36),
                                       *(uint32 *)(lVar11 + 40),(0 < iVar13) + '\x02',0);
                    lVar8 = FUN_18046bb80(0);
                    if ((lVar8 == null) || (lVar8 = *(int64 *)(lVar8 + 24)) == null)
                    goto LAB_180930675;
                    cVar4 = 0 < iVar12;
                  }
                }
                else {
                  if (this.num < 1) {
                    lVar7 = FUN_18046bb80(0);
                    if ((lVar7 == null) || (*(int64 *)(lVar7 + 24) == 0)) goto LAB_180930675;
                    lVar7 = BattleMapData.GetGridDataByDir
                                      (*(int64 *)(lVar7 + 24),*(uint32 *)(lVar11 + 36),
                                       *(uint32 *)(lVar11 + 40),iVar12 < 1,0);
                    lVar8 = FUN_18046bb80(0);
                    if ((lVar8 == null) || (lVar8 = *(int64 *)(lVar8 + 24)) == null)
                    goto LAB_180930675;
                    bVar3 = iVar13 < 1;
                  }
                  else {
                    lVar7 = FUN_18046bb80(0);
                    if ((lVar7 == null) || (*(int64 *)(lVar7 + 24) == 0)) goto LAB_180930675;
                    lVar7 = BattleMapData.GetGridDataByDir
                                      (*(int64 *)(lVar7 + 24),*(uint32 *)(lVar11 + 36),
                                       *(uint32 *)(lVar11 + 40),0 < iVar12,0);
                    lVar8 = FUN_18046bb80(0);
                    if ((lVar8 == null) || (lVar8 = *(int64 *)(lVar8 + 24)) == null)
                    goto LAB_180930675;
                    bVar3 = 0 < iVar13;
                  }
                  cVar4 = bVar3 + '\x02';
                }
                lVar9 = BattleMapData.GetGridDataByDir
                                  (lVar8,*(uint32 *)(lVar11 + 36),*(uint32 *)(lVar11 + 40),
                                   cVar4,0);
                iVar5 = Mathf.Abs(iVar12,0);
                iVar6 = Mathf.Abs(iVar13,0);
                lVar8 = lVar7;
                if ((iVar5 == iVar6) && (fVar14 = (float)Random.get_value(0), fVar14 < 0.5)) {
                  lVar8 = lVar9;
                  lVar9 = lVar7;
                }
                if (((lVar8 == null) || (cVar4 = GridUnitData.isEmpty(lVar8), !cVar4)) &&
                   ((lVar9 == null ||
                    (((cVar4 = GridUnitData.isEmpty(lVar9), !cVar4 || (iVar12 == 0)) ||
                     (lVar8 = lVar9, iVar13 == 0)))))) break;
                iVar12 = -1;
                if (this.num < 1) {
                  iVar12 = 1;
                }
                iVar12 = iVar12 + this.num;
                this.num = iVar12;
                lVar11 = lVar8;
                if (iVar12 == 0) break;
              }
              BattleUnit.EnterGrid(lVar2,lVar11,1,0,0);
              fVar14 = *(float *)(*(int64 *)(DAT_181db07c8 + 184) + 24);
              if ((*pStatics != 0) &&
                 (lVar2 = *(int64 *)(*pStatics + 32)) != null) {
                fVar1 = *(float *)(lVar2 + 0x1d8);
                uVar10 = new WaitForSeconds(fVar14 / fVar1 + fVar14,0);
                this.<>2__current = uVar10;
                this.<>1__state = 1;
                return true;
              }
            }
        LAB_180930675:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
        }
        else if (this.<>1__state == 1) {
          this.<>1__state = 0xffffffff;
          lVar11 = FUN_18046bb80(0);
          if (lVar11 == null) goto LAB_180930675;
          BattleController.ManageUnitStaySpeGrid(lVar11,lVar2,0);
        }
        return false;
    }

    // Token : 0x6000C83
    // RVA   : 0x20F140   Offset: 0x20E540   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x6000C84
    // RVA   : 0x930680   Offset: 0x92FA80   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181d8d510);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181d97e38);
    }

    // Token : 0x6000C85
    // RVA   : 0x20F140   Offset: 0x20E540   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
