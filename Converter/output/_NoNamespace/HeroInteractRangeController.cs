// ============================================================
// Type  : HeroInteractRangeController
// Token : 0x20002D6
// ============================================================

public class HeroInteractRangeController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400178A
    public BigmapNpcController targetHero;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600185B
    // RVA   : 0x899140   Offset: 0x897F40   Length: 0x39
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

    // Token : 0x600185C
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

}
