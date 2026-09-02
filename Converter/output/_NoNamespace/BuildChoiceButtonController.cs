// ============================================================
// Type  : BuildChoiceButtonController
// Token : 0x20001A6
// ============================================================

public class BuildChoiceButtonController
{
    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000D90
    // RVA   : 0xBB4F30   Offset: 0xBB3730   Length: 0xCC
    public void OnClick()
    {
        long lVar1;
        ulong uVar2;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d87338 + 184) + 16);
        uVar2 = Component.get_gameObject(this,0);
        if (lVar1 != null) {
          AreaBuildController.BuildChoiceButtonClicked(lVar1,uVar2,0);
          return;
        }
    }

    // Token : 0x6000D91
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
