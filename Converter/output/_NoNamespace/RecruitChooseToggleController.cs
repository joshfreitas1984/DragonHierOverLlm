// ============================================================
// Type  : RecruitChooseToggleController
// Token : 0x2000349
// ============================================================

public class RecruitChooseToggleController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001B7E
    public int heroID;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002136
    // RVA   : 0xA6AD70   Offset: 0xA69B70   Length: 0x117
    public void RecruitChooseToggleClicked()
    {
        var pStatics = *(int64*)(DAT_181e7a5d8 + 184);
        long lVar1;
        lVar1 = Component.GetComponent(this,DAT_181e796b8);
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

    // Token : 0x6002137
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

}
