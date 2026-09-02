// ============================================================
// Type  : BuildNewButtonController
// Token : 0x20001A7
// ============================================================

public class BuildNewButtonController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000B28
    public int buildingID;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000D92
    // RVA   : 0xBB5000   Offset: 0xBB3800   Length: 0xCC
    public void OnClick()
    {
        long lVar1;
        ulong uVar2;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d87338 + 184) + 16);
        uVar2 = Component.get_gameObject(this,0);
        if (lVar1 != null) {
          AreaBuildController.BuildNewButtonClicked(lVar1,uVar2,0);
          return;
        }
    }

    // Token : 0x6000D93
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
