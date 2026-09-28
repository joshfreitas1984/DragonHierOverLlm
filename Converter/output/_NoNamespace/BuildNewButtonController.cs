// ============================================================
// Type  : BuildNewButtonController
// Token : 0x20001AD
// ============================================================

public class BuildNewButtonController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000BB4
    public int buildingID;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000DC6
    // RVA   : 0xB5EB60   Offset: 0xB5DF60   Length: 0xCC
    public void OnClick()
    {
        long lVar1;
        ulong uVar2;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181dac458 + 184) + 16);
        uVar2 = Component.get_gameObject(this,0);
        if (lVar1 != null) {
          AreaBuildController.BuildNewButtonClicked(lVar1,uVar2,0);
          return;
        }
    }

    // Token : 0x6000DC7
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
