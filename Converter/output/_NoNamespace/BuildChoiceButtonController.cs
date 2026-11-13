// ============================================================
// Type  : BuildChoiceButtonController
// Token : 0x20001AE
// ============================================================

public class BuildChoiceButtonController
{
    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000DC7
    // RVA   : 0x918370   Offset: 0x917170   Length: 0xCC
    public void OnClick()
    {
        long lVar1;
        ulong uVar2;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181e8c5b8 + 184) + 16);
        uVar2 = Component.get_gameObject(this,0);
        if (lVar1 != null) {
          AreaBuildController.BuildChoiceButtonClicked(lVar1,uVar2,0);
          return;
        }
    }

    // Token : 0x6000DC8
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

}
