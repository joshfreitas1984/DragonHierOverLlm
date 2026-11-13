// ============================================================
// Type  : PlotData
// Token : 0x2000205
// ============================================================

public class PlotData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000EA1
    public string plotName;

    // Token: 0x4000EA2
    public bool spePlot;

    // Token: 0x4000EA3
    public int plotID;

    // Token: 0x4000EA4
    public List<PlotRandomHeroData> plotRandomHero;

    // Token: 0x4000EA5
    public bool differentForce;

    // Token: 0x4000EA6
    public int targetHeroID;

    // Token: 0x4000EA7
    public string plotCallFuc;

    // Token: 0x4000EA8
    public bool randomStartPlot;

    // Token: 0x4000EA9
    public List<SinglePlotData> plotDatas;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000FF4
    // RVA   : 0x8AEEE0   Offset: 0x8ADCE0   Length: 0xBB
    public void /*ctor*/()
    {
        ulong uVar1;
        ZhSegment.Initialize(this,0);
        uVar1 = il2cpp_internal(DAT_181e752b8);
        FUN_1810f3480(uVar1,DAT_181e798e0);
        this.plotRandomHero = uVar1;
        uVar1 = il2cpp_internal(DAT_181e76fa8);
        FUN_1810f3480(uVar1,DAT_181e838b0);
        this.plotDatas = uVar1;
    }

    // Token : 0x6000FF5
    // RVA   : 0x8AEAC0   Offset: 0x8AD8C0   Length: 0x41A
    public virtual object Clone()
    {
        uint uVar2;
        long lVar3;
        long lVar4;
        long lVar5;
        uint uVar7;
        long lVar10;
        long lVar11;
        lVar4 = new PlotData(0);
        if (lVar4 != null) {
          *(uint64 *)(lVar4 + 16) = this.plotName;
          plVar1 = (int64 *)(lVar4 + 32);
          *(uint8 *)(lVar4 + 24) = this.spePlot;
          lVar10 = 32;
          *(uint32 *)(lVar4 + 28) = this.plotID;
          if (this.plotRandomHero == null) {
            *plVar1 = 0;
            il2cpp_internal(plVar1,0);
        LAB_1808aed2b:
            plVar9 = (int64 *)0;
            *(uint8 *)(lVar4 + 40) = this.differentForce;
            *(uint32 *)(lVar4 + 44) = this.targetHeroID;
            *(uint64 *)(lVar4 + 48) = this.plotCallFuc;
            plVar1 = (int64 *)(lVar4 + 64);
            *(uint8 *)(lVar4 + 56) = this.randomStartPlot;
            if (this.plotDatas == null) {
              *plVar1 = 0;
              il2cpp_internal(plVar1,0);
              return lVar4;
            }
            uVar2 = this.plotDatas.Count;
            lVar5 = new List_1(uVar2,DAT_181e83930);
            *plVar1 = lVar5;
            il2cpp_internal(plVar1,lVar5);
            lVar5 = this.plotDatas;
            plVar6 = plVar9;
            if (lVar5 != null) {
              while( true ) {
                uVar7 = (uint32)plVar6;
                if (lVar5.Count <= (int)uVar7) {
                  return lVar4;
                }
                lVar11 = *plVar1;
                if (lVar5 == null) break;
                if (lVar5.Count <= uVar7) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                plVar8 = plVar9;
                if (*(int64 *)(lVar5._items + lVar10) != 0) {
                  if ((this.plotDatas == null) ||
                     (lVar5 = FUN_1800024b0(this.plotDatas,plVar6,DAT_181e83c30),
                     lVar5 == null)) break;
                  plVar6 = (int64 *)SinglePlotData.Clone(lVar5,0);
                  if (plVar6 != (int64 *)0) {
                  }
                }
                if (lVar11 == null) break;
                FUN_18175de30(lVar11,plVar8,DAT_181e839b0);
                lVar5 = this.plotDatas;
                lVar10 = lVar10 + 8;
                plVar6 = (int64 *)(uint64)(uVar7 + 1);
                if (lVar5 == null) break;
              }
            }
          }
          else {
            uVar2 = this.plotRandomHero.Count;
            lVar5 = new List_1(uVar2,DAT_181e79960);
            *plVar1 = lVar5;
            il2cpp_internal(plVar1,lVar5);
            lVar5 = this.plotRandomHero;
            plVar9 = (int64 *)0;
            if (lVar5 != null) {
              lVar11 = 32;
              plVar6 = plVar9;
              while( true ) {
                uVar7 = (uint32)plVar6;
                if (lVar5.Count <= (int)uVar7) goto LAB_1808aed2b;
                lVar3 = *plVar1;
                if (lVar5 == null) break;
                if (lVar5.Count <= uVar7) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                plVar8 = plVar9;
                if (*(int64 *)(lVar11 + lVar5._items) != 0) {
                  if ((this.plotRandomHero == null) ||
                     (lVar5 = FUN_1800024b0(this.plotRandomHero,plVar6,DAT_181e79ae0),
                     lVar5 == null)) break;
                  plVar6 = (int64 *)PlotRandomHeroData.Clone(lVar5,0);
                  if (plVar6 != (int64 *)0) {
                  }
                }
                if (lVar3 == null) break;
                FUN_18175de30(lVar3,plVar8,DAT_181e799e0);
                lVar5 = this.plotRandomHero;
                plVar6 = (int64 *)(uint64)(uVar7 + 1);
                lVar11 = lVar11 + 8;
                if (lVar5 == null) break;
              }
            }
          }
        }
    }

}
