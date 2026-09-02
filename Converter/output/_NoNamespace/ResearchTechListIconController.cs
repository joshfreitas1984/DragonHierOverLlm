// ============================================================
// Type  : ResearchTechListIconController
// Token : 0x200033E
// ============================================================

public class ResearchTechListIconController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001A21
    public int techListID;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600202F
    // RVA   : 0xC623C0   Offset: 0xC60BC0   Length: 0x173
    public void OnClick()
    {
        uint uVar1;
        long lVar2;
        long lVar3;
        uVar1 = this.techListID;
        lVar2 = *(int64 *)(*(int64 *)(DAT_181d77350 + 184) + 8);
        if (lVar2 != null) {
          if ((*(int64 *)(lVar2 + 48) != 0) &&
             (lVar3 = *(int64 *)(*(int64 *)(lVar2 + 48) + 0x188)) != null) {
            FUN_18180c7d0(lVar3,uVar1,DAT_181d67f70);
            plVar4 = (int64 *)Resources.Load("Sound/SoundEffect/PaperQuick",0);
            plVar5 = (int64 *)0;
            if ((plVar4 != (int64 *)0) && (*plVar4 == DAT_181d8a228)) {
              plVar5 = plVar4;
            }
            NGUITools.PlaySound(plVar5,0);
            ResearchUIController.RefreshResearchTechList(lVar2,0);
            return;
          }
        }
    }

    // Token : 0x6002030
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
