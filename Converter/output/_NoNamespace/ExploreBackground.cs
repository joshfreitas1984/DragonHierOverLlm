// ============================================================
// Type  : ExploreBackground
// Token : 0x2000272
// ============================================================

public class ExploreBackground
{
    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001462
    // RVA   : 0x68F210   Offset: 0x68E010   Length: 0xC1
    public void OnDrag(Vector2 delta)
    {
        long lVar1;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181ea6328 + 184) + 8);
        if (lVar1 != null) {
          ExploreController.OnDrag(lVar1,delta,0);
          return;
        }
    }

    // Token : 0x6001463
    // RVA   : 0x68F2E0   Offset: 0x68E0E0   Length: 0x199
    public void OnScroll(float delta)
    {
        long lVar1;
        bool cVar2;
        ulong uVar3;
        long lVar4;
        uint uVar5;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181ea6328 + 184) + 8);
        if (lVar1 == null) {
        LAB_18068f474:
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        if (delta != null.0) {
          if (*(int64 *)(lVar1 + 72) == 0) goto LAB_18068f474;
          uVar3 = GameObject.GetComponent(*(int64 *)(lVar1 + 72),DAT_181e56bf8);
          cVar2 = Object.op_Equality(uVar3,0,0);
          if (!cVar2) {
            if ((*(int64 *)(lVar1 + 72) == 0) ||
               (lVar4 = GameObject.GetComponent(*(int64 *)(lVar1 + 72),DAT_181e56bf8)) == null)
            goto LAB_18068f474;
            cVar2 = Behaviour.get_isActiveAndEnabled(lVar4,0);
            if (cVar2) {
              return;
            }
          }
          uVar5 = FUN_180f34e60(*(float *)(lVar1 + 0x104) + delta,0x3f19999a,0x3fb33333,0);
          *(uint32 *)(lVar1 + 0x104) = uVar5;
        }
    }

    // Token : 0x6001464
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

}
