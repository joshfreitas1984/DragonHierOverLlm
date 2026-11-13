// ============================================================
// Type  : BuildNewButtonController
// Token : 0x20001AF
// ============================================================

public class BuildNewButtonController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000BC5
    public int buildingID;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000DC9
    // RVA   : 0x918440   Offset: 0x917240   Length: 0xCC
    public void OnClick()
    {
        long lVar1;
        ulong uVar2;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181e8c5b8 + 184) + 16);
        uVar2 = Component.get_gameObject(this,0);
        if (lVar1 != null) {
          AreaBuildController.BuildNewButtonClicked(lVar1,uVar2,0);
          return;
        }
    }

    // Token : 0x6000DCA
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

}
