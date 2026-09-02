// ============================================================
// Type  : BattleBackground
// Token : 0x200014E
// ============================================================

public class BattleBackground
{
    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000ACF
    // RVA   : 0x7FAA40   Offset: 0x7F9240   Length: 0xC1
    public void OnDrag(Vector2 delta)
    {
        long lVar1;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d8b128 + 184) + 80);
        if (lVar1 != null) {
          BattleController.OnDrag(lVar1,delta,0);
          return;
        }
    }

    // Token : 0x6000AD0
    // RVA   : 0x7FAB10   Offset: 0x7F9310   Length: 0x19F
    public void OnScroll(float delta)
    {
        long lVar1;
        bool cVar2;
        ulong uVar3;
        long lVar4;
        uint uVar5;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d8b128 + 184) + 80);
        if (lVar1 == null) {
        LAB_1807facaa:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        if (delta != null.0) {
          if (*(int64 *)(lVar1 + 200) == 0) goto LAB_1807facaa;
          uVar3 = Component.GetComponent(*(int64 *)(lVar1 + 200),DAT_181d6d4c0);
          cVar2 = Object.op_Equality(uVar3,0,0);
          if (!cVar2) {
            if ((*(int64 *)(lVar1 + 200) == 0) ||
               (lVar4 = Component.GetComponent(*(int64 *)(lVar1 + 200),DAT_181d6d4c0)) == null)
            goto LAB_1807facaa;
            cVar2 = Behaviour.get_isActiveAndEnabled(lVar4,0);
            if (cVar2) {
              return;
            }
          }
          uVar5 = FUN_1810a8ba0(*(float *)(lVar1 + 224) + delta,0x3f000000,0x3fc00000,0);
          *(uint32 *)(lVar1 + 224) = uVar5;
        }
    }

    // Token : 0x6000AD1
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
