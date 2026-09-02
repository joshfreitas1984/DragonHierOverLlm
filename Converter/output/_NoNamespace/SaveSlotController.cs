// ============================================================
// Type  : SaveSlotController
// Token : 0x2000345
// ============================================================

public class SaveSlotController
{
    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600205C
    // RVA   : 0x9684E0   Offset: 0x966CE0   Length: 0xE4
    public void OnClick()
    {
        long lVar1;
        uint uVar2;
        long lVar3;
        ulong uVar4;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d79ad0 + 184) + 8);
        lVar3 = Component.get_gameObject(this,0);
        if (lVar3 != null) {
          uVar4 = Object.get_name(lVar3,0);
          uVar2 = Int32.Parse(uVar4,0);
          if (lVar1 != null) {
            SaveLoadMenuController.SaveSlotButtonClicked(lVar1,uVar2,0);
            return;
          }
        }
    }

    // Token : 0x600205D
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
