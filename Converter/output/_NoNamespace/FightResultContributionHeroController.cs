// ============================================================
// Type  : FightResultContributionHeroController
// Token : 0x200027F
// ============================================================

public class FightResultContributionHeroController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400139E
    public HeroData targetHero;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600144A
    // RVA   : 0xBA56C0   Offset: 0xBA3EC0   Length: 0x203
    public void Init(string extraAddText)
    {
        var pStatics = *(int64*)(DAT_181d4e188 + 184);
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
                lVar3 = GameObject.GetComponent(lVar1,DAT_181d9fb20);
                if (lVar3 != null) {
                  *(uint64 *)(lVar3 + 32) = this.targetHero;
                  lVar1 = GameObject.GetComponent(lVar1,DAT_181d9fb20);
                  if (lVar1 != null) {
                    *(uint32 *)(lVar1 + 24) = 0;
                    lVar1 = Component.get_transform(this,0);
                    if (lVar1 != null) {
                      lVar1 = Transform.Find(lVar1,"Text",0);
                      if (lVar1 != null) {
                        uVar2 = Component.GetComponent(lVar1,DAT_181d6d8c0);
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

    // Token : 0x600144B
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
