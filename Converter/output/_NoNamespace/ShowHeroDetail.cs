// ============================================================
// Type  : ShowHeroDetail
// Token : 0x200034C
// ============================================================

public class ShowHeroDetail
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001A6C
    public HeroData heroData;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002081
    // RVA   : 0x96BA70   Offset: 0x96A270   Length: 0x11E
    public void OnClick()
    {
        var pStatics_0f00 = *(int64*)(DAT_181d50f00 + 184);
        var pStatics_6278 = *(int64*)(DAT_181d96278 + 184);
        if (*pStatics_6278 != 0) {
          if (*(int *)(*pStatics_6278 + 24) != 0) {
            plVar1 = (int64 *)Resources.Load("Sound/SoundEffect/WrongClick",0);
            plVar2 = (int64 *)0;
            if ((plVar1 != (int64 *)0) && (*plVar1 == DAT_181d8a228)) {
              plVar2 = plVar1;
            }
            NGUITools.PlaySound(plVar2,0);
            return;
          }
          if (this.heroData == null) {
            return;
          }
          if (*pStatics_0f00 != 0) {
            HeroDetailController.SetHeroDetail
                      (*pStatics_0f00,this.heroData,0);
            return;
          }
        }
    }

    // Token : 0x6002082
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
