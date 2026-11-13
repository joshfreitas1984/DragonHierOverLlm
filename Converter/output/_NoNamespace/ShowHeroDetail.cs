// ============================================================
// Type  : ShowHeroDetail
// Token : 0x2000360
// ============================================================

public class ShowHeroDetail
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001BEC
    public HeroData heroData;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60021AA
    // RVA   : 0x6A60A0   Offset: 0x6A4EA0   Length: 0x11E
    public void OnClick()
    {
        var pStatics_5ae8 = *(int64*)(DAT_181e55ae8 + 184);
        var pStatics_b708 = *(int64*)(DAT_181e9b708 + 184);
        if (*pStatics_b708 != 0) {
          if (*(int *)(*pStatics_b708 + 24) != 0) {
            plVar1 = (int64 *)Resources.Load("Sound/SoundEffect/WrongClick",0);
            plVar2 = (int64 *)0;
            if ((plVar1 != (int64 *)0) && (*plVar1 == DAT_181e8f4a0)) {
              plVar2 = plVar1;
            }
            NGUITools.PlaySound(plVar2,0);
            return;
          }
          if (this.heroData == null) {
            return;
          }
          if (*pStatics_5ae8 != 0) {
            HeroDetailController.SetHeroDetail
                      (*pStatics_5ae8,this.heroData,0);
            return;
          }
        }
    }

    // Token : 0x60021AB
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

}
