// ============================================================
// Type  : BuildChoiceButtonController
// Token : 0x20001AC
// ============================================================

public class BuildChoiceButtonController
{
    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000DC4
    // RVA   : 0xB5F150   Offset: 0xB5E550   Length: 0xCC
    public void OnClick()
    {
        long lVar1;
        ulong uVar2;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181dac470 + 184) + 16);
        uVar2 = Component.get_gameObject(this,0);
        if (lVar1 != null) {
          AreaBuildController.BuildChoiceButtonClicked(lVar1,uVar2,0);
          return;
        }
    }

    // Token : 0x6000DC5
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
