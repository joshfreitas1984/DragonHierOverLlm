// ============================================================
// Type  : HorseMatchHeroInteractRange
// Token : 0x20002E9
// ============================================================

public class HorseMatchHeroInteractRange
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001803
    public HorseMatchHeroController targetHorseHero;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60018B3
    // RVA   : 0x8AA1C0   Offset: 0x8A8FC0   Length: 0x39
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

    // Token : 0x60018B4
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

}
