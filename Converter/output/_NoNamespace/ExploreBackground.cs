// ============================================================
// Type  : ExploreBackground
// Token : 0x200026B
// ============================================================

public class ExploreBackground
{
    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60013FA
    // RVA   : 0x948950   Offset: 0x947D50   Length: 0xC1
    public void OnDrag(Vector2 delta)
    {
        long lVar1;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181dc5e30 + 184) + 8);
        if (lVar1 != null) {
          ExploreController.OnDrag(lVar1,delta,0);
          return;
        }
    }

    // Token : 0x60013FB
    // RVA   : 0x948A20   Offset: 0x947E20   Length: 0x199
    public void OnScroll(float delta)
    {
        long lVar1;
        bool cVar2;
        ulong uVar3;
        long lVar4;
        uint uVar5;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181dc5e30 + 184) + 8);
        if (lVar1 == null) {
        LAB_180948bb4:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        if (delta != null.0) {
          if (*(int64 *)(lVar1 + 72) == 0) goto LAB_180948bb4;
          uVar3 = GameObject.GetComponent(*(int64 *)(lVar1 + 72),DAT_181d73b30);
          cVar2 = Object.op_Equality(uVar3,0,0);
          if (!cVar2) {
            if ((*(int64 *)(lVar1 + 72) == 0) ||
               (lVar4 = GameObject.GetComponent(*(int64 *)(lVar1 + 72),DAT_181d73b30)) == null)
            goto LAB_180948bb4;
            cVar2 = Behaviour.get_isActiveAndEnabled(lVar4,0);
            if (cVar2) {
              return;
            }
          }
          uVar5 = FUN_1810e36c0(*(float *)(lVar1 + 0x104) + delta,0x3f19999a,0x3fb33333,0);
          *(uint32 *)(lVar1 + 0x104) = uVar5;
        }
    }

    // Token : 0x60013FC
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
