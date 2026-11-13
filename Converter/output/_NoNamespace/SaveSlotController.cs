// ============================================================
// Type  : SaveSlotController
// Token : 0x2000359
// ============================================================

public class SaveSlotController
{
    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002185
    // RVA   : 0x6A2AC0   Offset: 0x6A18C0   Length: 0xE4
    public void OnClick()
    {
        long lVar1;
        uint uVar2;
        long lVar3;
        ulong uVar4;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181e7f158 + 184) + 8);
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

    // Token : 0x6002186
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

}
