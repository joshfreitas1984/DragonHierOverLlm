// ============================================================
// Type  : UIToggledObjects
// Token : 0x2000071
// ============================================================

public class UIToggledObjects
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40002B3
    public List<GameObject> activate;

    // Token: 0x40002B4
    public List<GameObject> deactivate;

    // Token: 0x40002B5
    private GameObject target;

    // Token: 0x40002B6
    private bool inverse;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000294
    // RVA   : 0x1699BA0   Offset: 0x16983A0   Length: 0x180
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
                FUN_181827900(lVar4,this.target,DAT_181d61bf8);
              }
              else {
                FUN_181827900(lVar2,this.target,DAT_181d61bf8);
              }
              goto LAB_181699ca4;
            }
          }
          this.target = 0;
        }
        LAB_181699ca4:
        lVar4 = Component.GetComponent(this,DAT_181d6e740);
        if (lVar4 != null) {
          uVar1 = *(uint64 *)(lVar4 + 80);
          uVar5 = new OnTooltipCB(this,DAT_181d9d730,0);
          EventDelegate.Add(uVar1,uVar5,0);
          return;
        }
    }

    // Token : 0x6000295
    // RVA   : 0x1699DD0   Offset: 0x16985D0   Length: 0x2AA
    public void Toggle()
    {
        ulong uVar1;
        bool cVar2;
        long lVar3;
        uint uVar4;
        uint uVar5;
        long lVar6;
        long lVar7;
        if (*(int64 *)(*(int64 *)(DAT_181d8b2d8 + 184) + 8) != 0) {
          cVar2 = Behaviour.get_enabled(this,0);
          if (!cVar2) {
            return;
          }
          lVar3 = this.activate;
          uVar4 = 0;
          uVar5 = 0;
          if (lVar3 != null) {
            lVar7 = 32;
            lVar6 = 32;
            do {
              if (lVar3.Count <= (int)uVar5) {
                lVar3 = this.deactivate;
                if (lVar3 != null) goto LAB_181699f87;
                break;
              }
              if (lVar3 == null) break;
              if (lVar3.Count <= uVar5) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              uVar1 = *(uint64 *)(lVar6 + lVar3._items);
              cVar2 = Object.op_Inequality(uVar1,0,0);
              if (cVar2) {
                NGUITools.SetActive(uVar1);
              }
              lVar3 = this.activate;
              uVar5 = uVar5 + 1;
              lVar6 = lVar6 + 8;
            } while (lVar3 != null);
          }
        }
        throw; // [null/range check failed]
        while( true ) {
          if (lVar3.Count <= uVar4) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          uVar1 = *(uint64 *)(lVar7 + lVar3._items);
          cVar2 = Object.op_Inequality(uVar1,0,0);
          if (cVar2) {
            NGUITools.SetActive(uVar1);
          }
          lVar3 = this.deactivate;
          uVar4 = uVar4 + 1;
          lVar7 = lVar7 + 8;
          if (lVar3 == null) break;
        LAB_181699f87:
          if (lVar3.Count <= (int)uVar4) {
            return;
          }
          if (lVar3 == null) break;
        }
    }

    // Token : 0x6000296
    // RVA   : 0x1699D30   Offset: 0x1698530   Length: 0xA0
    private void Set(GameObject go, bool state)
    {
        bool cVar1;
        cVar1 = Object.op_Inequality(go,0,0);
        if (cVar1) {
          NGUITools.SetActive(go,state,0);
        }
    }

    // Token : 0x6000297
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
