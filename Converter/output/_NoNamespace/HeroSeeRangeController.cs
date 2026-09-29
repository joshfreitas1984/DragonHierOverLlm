// ============================================================
// Type  : HeroSeeRangeController
// Token : 0x20002D4
// ============================================================

public class HeroSeeRangeController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001755
    public BigmapNpcController targetHero;

    // Token: 0x4001756
    public SpriteRenderer seeSprite;

    // Token: 0x4001757
    public SpriteRenderer seeRangeSprite;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600180A
    // RVA   : 0xAFAE10   Offset: 0xAFA210   Length: 0x166
    private void Update()
    {
        bool cVar1;
        long lVar2;
        cVar1 = FUN_1804625f0(0x130,0);
        lVar2 = this.seeSprite;
        if (!cVar1) {
          if ((lVar2 != null) && (lVar2 = Component.get_gameObject(lVar2,0)) != null) {
            cVar1 = GameObject.get_activeSelf(lVar2,0);
            if (cVar1) {
              if ((this.seeSprite == null) ||
                 (lVar2 = Component.get_gameObject(this.seeSprite,0)) == null)
              throw; // [null/range check failed]
              GameObject.SetActive(lVar2,0,0);
            }
            if ((this.seeRangeSprite != null) &&
               (lVar2 = Component.get_gameObject(this.seeRangeSprite,0)) != null) {
              cVar1 = GameObject.get_activeSelf(lVar2,0);
              if (!cVar1) {
                return;
              }
              if ((this.seeRangeSprite != null) &&
                 (lVar2 = Component.get_gameObject(this.seeRangeSprite,0)) != null) {
                GameObject.SetActive(lVar2,0,0);
                return;
              }
            }
          }
        }
        else if ((lVar2 != null) && (lVar2 = Component.get_gameObject(lVar2,0)) != null) {
          cVar1 = GameObject.get_activeSelf(lVar2,0);
          if (!cVar1) {
            if (this.seeSprite == null) throw; // [null/range check failed]
            lVar2 = Component.get_gameObject(this.seeSprite,0);
            if (lVar2 == null) throw; // [null/range check failed]
            GameObject.SetActive(lVar2,1,0);
          }
          if ((this.seeRangeSprite != null) &&
             (lVar2 = Component.get_gameObject(this.seeRangeSprite,0)) != null) {
            cVar1 = GameObject.get_activeSelf(lVar2,0);
            if (cVar1) {
              return;
            }
            if (this.seeRangeSprite != null) {
              lVar2 = Component.get_gameObject(this.seeRangeSprite,0);
              if (lVar2 != null) {
                GameObject.SetActive(lVar2,1,0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x600180B
    // RVA   : 0xAFADD0   Offset: 0xAFA1D0   Length: 0x39
    public void OnTriggerStay(Collider other)
    {
        long lVar1;
        ulong uVar2;
        lVar1 = this.targetHero;
        if (other != null) {
          uVar2 = Component.get_gameObject(other,0);
          if (lVar1 != null) {
            BigmapNpcController.SeeRangeObjStay(lVar1,uVar2,0);
            return;
          }
        }
    }

    // Token : 0x600180C
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
