// ============================================================
// Type  : ForceDetailTabController
// Token : 0x200028A
// ============================================================

public class ForceDetailTabController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001473
    public int forceID;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60014AF
    // RVA   : 0xB3C9C0   Offset: 0xB3BDC0   Length: 0x50
    public void OnClick()
    {
        var pStatics = *(int64*)(DAT_181dc7d18 + 184);
        if (*pStatics != 0) {
          ForceDetailController.ShowForceDetail
                    (*pStatics,this.forceID,0);
          return;
        }
    }

    // Token : 0x60014B0
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
