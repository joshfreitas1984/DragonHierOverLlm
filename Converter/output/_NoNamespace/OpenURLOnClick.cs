// ============================================================
// Type  : OpenURLOnClick
// Token : 0x200001D
// ============================================================

public class OpenURLOnClick
{
    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000067
    // RVA   : 0x90E2C0   Offset: 0x90D0C0   Length: 0xFF
    private void OnClick()
    {
        var pStatics = *(int64*)(DAT_181e8fad0 + 184);
        bool cVar1;
        long lVar2;
        ulong uVar3;
        ulong local_18;
        uint local_10;
        lVar2 = Component.GetComponent(this,DAT_181e79eb8);
        cVar1 = Object.op_Inequality(lVar2,0,0);
        if (cVar1) {
          if (lVar2 == null) {
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          local_18 = UICamera.lastWorldPosition;
          local_10 = *(uint32 *)(pStatics + 108);
          uVar3 = UILabel.GetUrlAtPosition(lVar2,&local_18,0);
          cVar1 = FUN_180ad1200(uVar3,0);
          if (!cVar1) {
            Application.OpenURL(uVar3,0);
            return;
          }
        }
    }

    // Token : 0x6000068
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

}
