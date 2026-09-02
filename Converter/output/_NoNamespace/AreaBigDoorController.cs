// ============================================================
// Type  : AreaBigDoorController
// Token : 0x200013C
// ============================================================

public class AreaBigDoorController
{
    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000A11
    // RVA   : 0xA0D900   Offset: 0xA0C100   Length: 0x9A
    private void OnHover(bool isOver)
    {
        long lVar1;
        ulong uVar3;
        uint local_18;
        uint uStack_14;
        uint uStack_10;
        uint32 uStack_c;
        lVar1 = Component.GetComponent(this,DAT_181d6cd40);
        if (!isOver) {
          if (lVar1 == null) {
        LAB_180a0d995:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          uVar3 = *(uint64 *)(lVar1 + 192);
          puVar2 = (uint32 *)FUN_181098a50(&local_18,0);
        }
        else {
          if (lVar1 == null) goto LAB_180a0d995;
          uVar3 = *(uint64 *)(lVar1 + 192);
          puVar2 = (uint32 *)FUN_1810988d0(&local_18,0);
        }
        local_18 = *puVar2;
        uStack_14 = puVar2[1];
        uStack_10 = puVar2[2];
        uStack_c = puVar2[3];
        SkeletonExtensions.SetColor(uVar3,&local_18,0);
    }

    // Token : 0x6000A12
    // RVA   : 0xA0D850   Offset: 0xA0C050   Length: 0xAC
    private void OnClick()
    {
        long lVar1;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d87630 + 184) + 56);
        if (lVar1 != null) {
          AreaController.ReturnBigMapButtonClicked(lVar1,0);
          return;
        }
    }

    // Token : 0x6000A13
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
