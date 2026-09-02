// ============================================================
// Type  : ExploreBackground
// Token : 0x2000265
// ============================================================

public class ExploreBackground
{
    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60013B9
    // RVA   : 0x938E90   Offset: 0x937690   Length: 0xC1
    public void OnDrag(Vector2 delta)
    {
        long lVar1;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181da0c98 + 184) + 8);
        if (lVar1 != null) {
          ExploreController.OnDrag(lVar1,delta,0);
          return;
        }
    }

    // Token : 0x60013BA
    // RVA   : 0x938F60   Offset: 0x937760   Length: 0x199
    public void OnScroll(float delta)
    {
        long lVar1;
        bool cVar2;
        ulong uVar3;
        long lVar4;
        uint uVar5;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181da0c98 + 184) + 8);
        if (lVar1 == null) {
        LAB_1809390f4:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        if (delta != null.0) {
          if (*(int64 *)(lVar1 + 72) == 0) goto LAB_1809390f4;
          uVar3 = GameObject.GetComponent(*(int64 *)(lVar1 + 72),DAT_181da1930);
          cVar2 = Object.op_Equality(uVar3,0,0);
          if (!cVar2) {
            if ((*(int64 *)(lVar1 + 72) == 0) ||
               (lVar4 = GameObject.GetComponent(*(int64 *)(lVar1 + 72),DAT_181da1930)) == null)
            goto LAB_1809390f4;
            cVar2 = Behaviour.get_isActiveAndEnabled(lVar4,0);
            if (cVar2) {
              return;
            }
          }
          uVar5 = FUN_1810a8ba0(*(float *)(lVar1 + 0x104) + delta,0x3f19999a,0x3fb33333,0);
          *(uint32 *)(lVar1 + 0x104) = uVar5;
        }
    }

    // Token : 0x60013BB
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
