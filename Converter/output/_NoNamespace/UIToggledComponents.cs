// ============================================================
// Type  : UIToggledComponents
// Token : 0x2000070
// ============================================================

public class UIToggledComponents
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40002AF
    public List<MonoBehaviour> activate;

    // Token: 0x40002B0
    public List<MonoBehaviour> deactivate;

    // Token: 0x40002B1
    private MonoBehaviour target;

    // Token: 0x40002B2
    private bool inverse;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000291
    // RVA   : 0x1699800   Offset: 0x1698000   Length: 0x180
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
                FUN_181827900(lVar4,this.target,DAT_181d6de68);
              }
              else {
                FUN_181827900(lVar2,this.target,DAT_181d6de68);
              }
              goto LAB_181699904;
            }
          }
          this.target = 0;
        }
        LAB_181699904:
        lVar4 = Component.GetComponent(this,DAT_181d6e740);
        if (lVar4 != null) {
          uVar1 = *(uint64 *)(lVar4 + 80);
          uVar5 = new OnTooltipCB(this,DAT_181d9d6a8,0);
          EventDelegate.Add(uVar1,uVar5,0);
          return;
        }
    }

    // Token : 0x6000292
    // RVA   : 0x1699990   Offset: 0x1698190   Length: 0x207
    public void Toggle()
    {
        var pStatics = *(int64*)(DAT_181d8b2d8 + 184);
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
              if (lVar4 != null) goto LAB_181699ad1;
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
        LAB_181699ad1:
          if (lVar4.Count <= (int)uVar6) {
            return;
          }
          if (lVar4 == null) break;
        }
    }

    // Token : 0x6000293
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
