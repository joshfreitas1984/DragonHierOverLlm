// ============================================================
// Type  : SaveSlotController
// Token : 0x200034C
// ============================================================

public class SaveSlotController
{
    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60020DD
    // RVA   : 0x97AE30   Offset: 0x97A230   Length: 0xE4
    public void OnClick()
    {
        long lVar1;
        uint uVar2;
        long lVar3;
        ulong uVar4;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d9ecf0 + 184) + 8);
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

    // Token : 0x60020DE
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
