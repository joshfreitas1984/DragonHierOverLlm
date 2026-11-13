// ============================================================
// Type  : BattleBackground
// Token : 0x200014E
// ============================================================

public class BattleBackground
{
    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000AD1
    // RVA   : 0x52B350   Offset: 0x52A150   Length: 0xC1
    public void OnDrag(Vector2 delta)
    {
        long lVar1;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181e90420 + 184) + 80);
        if (lVar1 != null) {
          BattleController.OnDrag(lVar1,delta,0);
          return;
        }
    }

    // Token : 0x6000AD2
    // RVA   : 0x52B420   Offset: 0x52A220   Length: 0x19F
    public void OnScroll(float delta)
    {
        long lVar1;
        bool cVar2;
        ulong uVar3;
        long lVar4;
        uint uVar5;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181e90420 + 184) + 80);
        if (lVar1 == null) {
        LAB_18052b5ba:
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        if (delta != null.0) {
          if (*(int64 *)(lVar1 + 200) == 0) goto LAB_18052b5ba;
          uVar3 = Component.GetComponent(*(int64 *)(lVar1 + 200),DAT_181e79138);
          cVar2 = Object.op_Equality(uVar3,0,0);
          if (!cVar2) {
            if ((*(int64 *)(lVar1 + 200) == 0) ||
               (lVar4 = Component.GetComponent(*(int64 *)(lVar1 + 200),DAT_181e79138)) == null)
            goto LAB_18052b5ba;
            cVar2 = Behaviour.get_isActiveAndEnabled(lVar4,0);
            if (cVar2) {
              return;
            }
          }
          uVar5 = FUN_180f34e60(*(float *)(lVar1 + 224) + delta,0x3f000000,0x3fc00000,0);
          *(uint32 *)(lVar1 + 224) = uVar5;
        }
    }

    // Token : 0x6000AD3
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

}
