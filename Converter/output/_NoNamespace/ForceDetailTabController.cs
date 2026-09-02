// ============================================================
// Type  : ForceDetailTabController
// Token : 0x2000284
// ============================================================

public class ForceDetailTabController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40013C2
    public int forceID;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600146B
    // RVA   : 0xBB3680   Offset: 0xBB1E80   Length: 0x50
    public void OnClick()
    {
        var pStatics = *(int64*)(DAT_181da29a0 + 184);
        if (*pStatics != 0) {
          ForceDetailController.ShowForceDetail
                    (*pStatics,this.forceID,0);
          return;
        }
    }

    // Token : 0x600146C
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
