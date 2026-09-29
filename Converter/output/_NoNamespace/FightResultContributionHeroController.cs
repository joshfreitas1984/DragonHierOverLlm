// ============================================================
// Type  : FightResultContributionHeroController
// Token : 0x2000285
// ============================================================

public class FightResultContributionHeroController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400144F
    public HeroData targetHero;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600148E
    // RVA   : 0xB2E780   Offset: 0xB2DB80   Length: 0x234
    public void Init(string extraAddText)
    {
        var pStatics = *(int64*)(DAT_181d72ee8 + 184);
        long lVar1;
        ulong uVar2;
        long lVar3;
        ulong uVar4;
        int[] local_res20 = new int[2];
        lVar1 = Component.get_transform(this,0);
        if (lVar1 != null) {
          lVar1 = Transform.Find(lVar1,"HeroIconPos",0);
          if (lVar1 != null) {
            uVar2 = Component.get_gameObject(lVar1,0);
            if (*pStatics != 0) {
              uVar4 = *(uint64 *)(*pStatics + 144);
              lVar1 = GlobalData.AddChild(uVar2,uVar4,0);
              if (lVar1 != null) {
                lVar3 = GameObject.GetComponent(lVar1,DAT_181d71b50);
                if (lVar3 != null) {
                  *(uint64 *)(lVar3 + 32) = this.targetHero;
                  lVar1 = GameObject.GetComponent(lVar1,DAT_181d71b50);
                  if (lVar1 != null) {
                    *(uint32 *)(lVar1 + 24) = 0;
                    lVar1 = Component.get_transform(this,0);
                    if (lVar1 != null) {
                      lVar1 = Transform.Find(lVar1,"Text",0);
                      if (lVar1 != null) {
                        uVar2 = Component.GetComponent(lVar1,DAT_181d96178);
                        if (this.targetHero != null) {
                          local_res20[0] = (int)this.targetHero.lastFightContribution;
                          uVar4 = Int32.ToString(local_res20,0);
                          uVar4 = String.Concat(uVar4," ",extraAddText,0);
                          LTLocalization.SetText(uVar2,uVar4,0);
                          return;
                        }
                      }
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x600148F
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
