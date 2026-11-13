// ============================================================
// Type  : AreaBigDoorController
// Token : 0x200013C
// ============================================================

public class AreaBigDoorController
{
    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000A12
    // RVA   : 0x787290   Offset: 0x786090   Length: 0x9A
    private void OnHover(bool isOver)
    {
        long lVar1;
        ulong uVar3;
        uint local_18;
        uint uStack_14;
        uint uStack_10;
        uint32 uStack_c;
        lVar1 = Component.GetComponent(this,DAT_181e78938);
        if (!isOver) {
          if (lVar1 == null) {
        LAB_180787325:
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          uVar3 = *(uint64 *)(lVar1 + 192);
          puVar2 = (uint32 *)FUN_180f24d00(&local_18,0);
        }
        else {
          if (lVar1 == null) goto LAB_180787325;
          uVar3 = *(uint64 *)(lVar1 + 192);
          puVar2 = (uint32 *)FUN_180f24b80(&local_18,0);
        }
        local_18 = *puVar2;
        uStack_14 = puVar2[1];
        uStack_10 = puVar2[2];
        uStack_c = puVar2[3];
        SkeletonExtensions.SetColor(uVar3,&local_18,0);
    }

    // Token : 0x6000A13
    // RVA   : 0x7871E0   Offset: 0x785FE0   Length: 0xAC
    private void OnClick()
    {
        long lVar1;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181e8c8b0 + 184) + 56);
        if (lVar1 != null) {
          AreaController.ReturnBigMapButtonClicked(lVar1,0);
          return;
        }
    }

    // Token : 0x6000A14
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

}
