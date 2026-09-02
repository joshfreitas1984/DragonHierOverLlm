// ============================================================
// Type  : SpeEnhanceEquipChoiceController
// Token : 0x200035D
// ============================================================

public class SpeEnhanceEquipChoiceController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001ACA
    public HeroSpeAddData speAddData;

    // Token: 0x4001ACB
    public bool isBaseAdd;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60020D1
    // RVA   : 0x97BAC0   Offset: 0x97A2C0   Length: 0x66
    public void OnClick()
    {
        long lVar1;
        ulong uVar2;
        lVar1 = **(int64 **)(DAT_181d7f030 + 184);
        uVar2 = Component.get_gameObject(this,0);
        if (lVar1 != null) {
          SpeEnhanceEquipController.SetNowChoice(lVar1,uVar2,0);
          return;
        }
    }

    // Token : 0x60020D2
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
