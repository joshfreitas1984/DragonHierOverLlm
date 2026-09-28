// ============================================================
// Type  : HorseMatchHeroInteractRange
// Token : 0x20002E0
// ============================================================

public class HorseMatchHeroInteractRange
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40017AE
    public HorseMatchHeroController targetHorseHero;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001837
    // RVA   : 0xB078E0   Offset: 0xB06CE0   Length: 0x39
    public void OnTriggerStay(Collider other)
    {
        long lVar1;
        ulong uVar2;
        lVar1 = this.targetHorseHero;
        if (other != null) {
          uVar2 = Component.get_gameObject(other,0);
          if (lVar1 != null) {
            HorseMatchHeroController.InteractRangeObjStay(lVar1,uVar2,0);
            return;
          }
        }
    }

    // Token : 0x6001838
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
