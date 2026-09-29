// ============================================================
// Type  : ShowHeroDetail
// Token : 0x2000353
// ============================================================

public class ShowHeroDetail
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001B6E
    public HeroData heroData;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002102
    // RVA   : 0x97EAA0   Offset: 0x97DEA0   Length: 0x11E
    public void OnClick()
    {
        var pStatics_5f40 = *(int64*)(DAT_181d75f40 + 184);
        var pStatics_b440 = *(int64*)(DAT_181dbb440 + 184);
        if (*pStatics_b440 != 0) {
          if (*(int *)(*pStatics_b440 + 24) != 0) {
            plVar1 = (int64 *)Resources.Load("Sound/SoundEffect/WrongClick",0);
            plVar2 = (int64 *)0;
            if ((plVar1 != (int64 *)0) && (*plVar1 == DAT_181daf360)) {
              plVar2 = plVar1;
            }
            NGUITools.PlaySound(plVar2,0);
            return;
          }
          if (this.heroData == null) {
            return;
          }
          if (*pStatics_5f40 != 0) {
            HeroDetailController.SetHeroDetail
                      (*pStatics_5f40,this.heroData,0);
            return;
          }
        }
    }

    // Token : 0x6002103
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
