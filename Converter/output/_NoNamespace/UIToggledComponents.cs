// ============================================================
// Type  : UIToggledComponents
// Token : 0x2000071
// ============================================================

public class UIToggledComponents
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40002CB
    public List<MonoBehaviour> activate;

    // Token: 0x40002CC
    public List<MonoBehaviour> deactivate;

    // Token: 0x40002CD
    private MonoBehaviour target;

    // Token: 0x40002CE
    private bool inverse;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60002A9
    // RVA   : 0xC07870   Offset: 0xC06C70   Length: 0x180
    private void Awake()
    {
        ulong uVar1;
        long lVar2;
        bool cVar3;
        long lVar4;
        ulong uVar5;
        uVar1 = this.target;
        cVar3 = Object.op_Inequality(uVar1,0,0);
        if (cVar3) {
          lVar4 = this.activate;
          if (lVar4 == null) throw; // [null/range check failed]
          if (lVar4.Count == null) {
            lVar2 = this.deactivate;
            if (lVar2 == null) throw; // [null/range check failed]
            if (lVar2.Count == null) {
              if (!this.inverse) {
                FUN_18181e6b0(lVar4,this.target,DAT_181d95620);
              }
              else {
                FUN_18181e6b0(lVar2,this.target,DAT_181d95620);
              }
              goto LAB_180c07974;
            }
          }
          this.target = 0;
        }
        LAB_180c07974:
        lVar4 = Component.GetComponent(this,DAT_181d96ff8);
        if (lVar4 != null) {
          uVar1 = *(uint64 *)(lVar4 + 80);
          uVar5 = new OnTooltipCB(this,DAT_181dc6b48,0);
          EventDelegate.Add(uVar1,uVar5,0);
          return;
        }
    }

    // Token : 0x60002AA
    // RVA   : 0xC07A00   Offset: 0xC06E00   Length: 0x207
    public void Toggle()
    {
        var pStatics = *(int64*)(DAT_181db0510 + 184);
        byte uVar1;
        long lVar2;
        bool cVar3;
        long lVar4;
        uint uVar5;
        uint uVar6;
        long lVar7;
        long lVar8;
        cVar3 = Behaviour.get_enabled(this,0);
        if (!cVar3) {
          return;
        }
        lVar4 = this.activate;
        uVar6 = 0;
        uVar5 = 0;
        if (lVar4 != null) {
          lVar8 = 32;
          lVar7 = 32;
          do {
            if (lVar4.Count <= (int)uVar5) {
              lVar4 = this.deactivate;
              if (lVar4 != null) goto LAB_180c07b41;
              break;
            }
            if (lVar4 == null) break;
            if (lVar4.Count <= uVar5) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar4 = *(int64 *)(lVar7 + lVar4._items);
            lVar2 = *(int64 *)(pStatics + 8);
            if (lVar2 == null) break;
            if (*(char *)(lVar2 + 130) == false) {
              uVar1 = *(uint8 *)(lVar2 + 72);
            }
            else {
              uVar1 = *(uint8 *)(lVar2 + 129);
            }
            if (lVar4 == null) break;
            Behaviour.set_enabled(lVar4,uVar1,0);
            lVar4 = this.activate;
            uVar5 = uVar5 + 1;
            lVar7 = lVar7 + 8;
          } while (lVar4 != null);
        }
        throw; // [null/range check failed]
        while( true ) {
          if (lVar4.Count <= uVar6) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar4 = *(int64 *)(lVar8 + lVar4._items);
          lVar7 = *(int64 *)(pStatics + 8);
          if (lVar7 == null) break;
          if (*(char *)(lVar7 + 130) == false) {
            cVar3 = *(char *)(lVar7 + 72);
          }
          else {
            cVar3 = *(char *)(lVar7 + 129);
          }
          if (lVar4 == null) break;
          Behaviour.set_enabled(lVar4,!cVar3,0);
          lVar4 = this.deactivate;
          uVar6 = uVar6 + 1;
          lVar8 = lVar8 + 8;
          if (lVar4 == null) break;
        LAB_180c07b41:
          if (lVar4.Count <= (int)uVar6) {
            return;
          }
          if (lVar4 == null) break;
        }
    }

    // Token : 0x60002AB
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
