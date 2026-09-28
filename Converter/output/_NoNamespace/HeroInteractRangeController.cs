// ============================================================
// Type  : HeroInteractRangeController
// Token : 0x20002CD
// ============================================================

public class HeroInteractRangeController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001735
    public BigmapNpcController targetHero;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60017DF
    // RVA   : 0xAF6AE0   Offset: 0xAF5EE0   Length: 0x39
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

    // Token : 0x60017E0
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
