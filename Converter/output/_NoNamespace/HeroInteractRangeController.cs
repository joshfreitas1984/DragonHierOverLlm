// ============================================================
// Type  : HeroInteractRangeController
// Token : 0x20002C7
// ============================================================

public class HeroInteractRangeController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001681
    public BigmapNpcController targetHero;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600179B
    // RVA   : 0xB35C50   Offset: 0xB34450   Length: 0x39
    public void OnTriggerStay(Collider other)
    {
        long lVar1;
        ulong uVar2;
        lVar1 = this.targetHero;
        if (other != null) {
          uVar2 = Component.get_gameObject(other,0);
          if (lVar1 != null) {
            BigmapNpcController.InteractRangeObjStay(lVar1,uVar2,0);
            return;
          }
        }
    }

    // Token : 0x600179C
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
