// ============================================================
// Type  : RecruitChooseToggleController
// Token : 0x2000338
// ============================================================

public class RecruitChooseToggleController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001A0C
    public int heroID;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002017
    // RVA   : 0xC60960   Offset: 0xC5F160   Length: 0x117
    public void RecruitChooseToggleClicked()
    {
        var pStatics = *(int64*)(DAT_181d74fe0 + 184);
        long lVar1;
        lVar1 = Component.GetComponent(this,DAT_181d6da40);
        if (lVar1 != null) {
          if (*(char *)(lVar1 + 0x118) == false) {
            if (*pStatics != 0) {
              if (*(int *)(*pStatics + 56) != this.heroID) {
                return;
              }
              if (*pStatics != 0) {
                RecruitUIController.SetRecruitHero(*pStatics,0xffffffff);
                return;
              }
            }
          }
          else {
            if (*pStatics != 0) {
              RecruitUIController.SetRecruitHero
                        (*pStatics,this.heroID,0);
              return;
            }
          }
        }
    }

    // Token : 0x6002018
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
