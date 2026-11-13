// ============================================================
// Type  : SpeEnhanceEquipChoiceController
// Token : 0x2000371
// ============================================================

public class SpeEnhanceEquipChoiceController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001C5E
    public HeroSpeAddData speAddData;

    // Token: 0x4001C5F
    public bool isBaseAdd;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60021FC
    // RVA   : 0x6B6610   Offset: 0x6B5410   Length: 0x66
    public void OnClick()
    {
        long lVar1;
        ulong uVar2;
        lVar1 = **(int64 **)(DAT_181e846a8 + 184);
        uVar2 = Component.get_gameObject(this,0);
        if (lVar1 != null) {
          SpeEnhanceEquipController.SetNowChoice(lVar1,uVar2,0);
          return;
        }
    }

    // Token : 0x60021FD
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

}
