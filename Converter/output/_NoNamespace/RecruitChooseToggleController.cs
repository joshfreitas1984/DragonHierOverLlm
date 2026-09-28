// ============================================================
// Type  : RecruitChooseToggleController
// Token : 0x200033F
// ============================================================

public class RecruitChooseToggleController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001B03
    public int heroID;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002097
    // RVA   : 0xD11B00   Offset: 0xD10F00   Length: 0x117
    public void RecruitChooseToggleClicked()
    {
        var pStatics = *(int64*)(DAT_181d9a200 + 184);
        long lVar1;
        lVar1 = Component.GetComponent(this,DAT_181d962e0);
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

    // Token : 0x6002098
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
