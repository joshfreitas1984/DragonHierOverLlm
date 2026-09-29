// ============================================================
// Type  : SpeEnhanceEquipChoiceController
// Token : 0x2000364
// ============================================================

public class SpeEnhanceEquipChoiceController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001BCC
    public HeroSpeAddData speAddData;

    // Token: 0x4001BCD
    public bool isBaseAdd;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002152
    // RVA   : 0x98EEA0   Offset: 0x98E2A0   Length: 0x66
    public void OnClick()
    {
        long lVar1;
        ulong uVar2;
        lVar1 = **(int64 **)(DAT_181da4268 + 184);
        uVar2 = Component.get_gameObject(this,0);
        if (lVar1 != null) {
          SpeEnhanceEquipController.SetNowChoice(lVar1,uVar2,0);
          return;
        }
    }

    // Token : 0x6002153
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
