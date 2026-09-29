// ============================================================
// Type  : OpenURLOnClick
// Token : 0x200001E
// ============================================================

public class OpenURLOnClick
{
    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000080
    // RVA   : 0xB913D0   Offset: 0xB907D0   Length: 0xFF
    private void OnClick()
    {
        var pStatics = *(int64*)(DAT_181daf690 + 184);
        bool cVar1;
        long lVar2;
        ulong uVar3;
        ulong local_18;
        uint local_10;
        lVar2 = Component.GetComponent(this,DAT_181d96af8);
        cVar1 = Object.op_Inequality(lVar2,0,0);
        if (cVar1) {
          if (lVar2 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          local_18 = UICamera.lastWorldPosition;
          local_10 = *(uint32 *)(pStatics + 108);
          uVar3 = UILabel.GetUrlAtPosition(lVar2,&local_18,0);
          cVar1 = FUN_180d75bc0(uVar3,0);
          if (!cVar1) {
            Application.OpenURL(uVar3,0);
            return;
          }
        }
    }

    // Token : 0x6000081
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
