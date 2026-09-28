// ============================================================
// Type  : ItemUseChoiceButtonController
// Token : 0x20002F4
// ============================================================

public class ItemUseChoiceButtonController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001882
    public HeroData targetHero;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60018A1
    // RVA   : 0xCAA7E0   Offset: 0xCA9BE0   Length: 0x18B
    public void OnClick()
    {
        var pStatics = *(int64*)(DAT_181d82398 + 184);
        long lVar1;
        ulong uVar2;
        lVar1 = this.targetHero;
        if (*pStatics != 0) {
          uVar2 = *(uint64 *)(*pStatics + 48);
          if ((*pStatics != 0) && (lVar1 != null)) {
            HeroData.UseMedFood
                      (lVar1,uVar2,1,1,*(uint64 *)(*pStatics + 40),0);
            lVar1 = *pStatics;
            if (lVar1 != null) {
              if (lVar1.summonLv != null) {
                GameObject.SetActive(lVar1.summonLv,0,0);
                if (lVar1.summonLv != null) {
                  lVar1 = GameObject.get_transform(lVar1.summonLv,0);
                  if (lVar1 != null) {
                    lVar1 = Transform.Find(lVar1,"ItemUseMenu",0);
                    if (lVar1 != null) {
                      uVar2 = Component.get_gameObject(lVar1,0);
                      GlobalData.DeleteAllChild(uVar2,0);
                      return;
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x60018A2
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
