// ============================================================
// Type  : ResearchTechListIconController
// Token : 0x2000345
// ============================================================

public class ResearchTechListIconController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001B18
    public int techListID;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60020AF
    // RVA   : 0xD138E0   Offset: 0xD12CE0   Length: 0x173
    public void OnClick()
    {
        uint uVar1;
        long lVar2;
        long lVar3;
        uVar1 = this.techListID;
        lVar2 = *(int64 *)(*(int64 *)(DAT_181d9c580 + 184) + 8);
        if (lVar2 != null) {
          if ((*(int64 *)(lVar2 + 48) != 0) &&
             (lVar3 = *(int64 *)(*(int64 *)(lVar2 + 48) + 0x188)) != null) {
            FUN_1817eed70(lVar3,uVar1,DAT_181d8f718);
            plVar4 = (int64 *)Resources.Load("Sound/SoundEffect/PaperQuick",0);
            plVar5 = (int64 *)0;
            if ((plVar4 != (int64 *)0) && (*plVar4 == DAT_181daf348)) {
              plVar5 = plVar4;
            }
            NGUITools.PlaySound(plVar5,0);
            ResearchUIController.RefreshResearchTechList(lVar2,0);
            return;
          }
        }
    }

    // Token : 0x60020B0
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
