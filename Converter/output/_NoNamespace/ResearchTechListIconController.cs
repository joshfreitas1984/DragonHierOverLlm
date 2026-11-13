// ============================================================
// Type  : ResearchTechListIconController
// Token : 0x2000351
// ============================================================

public class ResearchTechListIconController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001B95
    public int techListID;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002153
    // RVA   : 0xA6CB50   Offset: 0xA6B950   Length: 0x173
    public void OnClick()
    {
        uint uVar1;
        long lVar2;
        long lVar3;
        uVar1 = this.techListID;
        lVar2 = *(int64 *)(*(int64 *)(DAT_181e7c958 + 184) + 8);
        if (lVar2 != null) {
          if ((*(int64 *)(lVar2 + 48) != 0) &&
             (lVar3 = *(int64 *)(*(int64 *)(lVar2 + 48) + 0x188)) != null) {
            FUN_1817634d0(lVar3,uVar1,DAT_181e718f0);
            plVar4 = (int64 *)Resources.Load("Sound/SoundEffect/PaperQuick",0);
            plVar5 = (int64 *)0;
            if ((plVar4 != (int64 *)0) && (*plVar4 == DAT_181e8f4a0)) {
              plVar5 = plVar4;
            }
            NGUITools.PlaySound(plVar5,0);
            ResearchUIController.RefreshResearchTechList(lVar2,0);
            return;
          }
        }
    }

    // Token : 0x6002154
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

}
