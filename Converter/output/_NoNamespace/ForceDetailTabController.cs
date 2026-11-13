// ============================================================
// Type  : ForceDetailTabController
// Token : 0x2000292
// ============================================================

public class ForceDetailTabController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40014B6
    public int forceID;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600151B
    // RVA   : 0x8FE3A0   Offset: 0x8FD1A0   Length: 0x50
    public void OnClick()
    {
        var pStatics = *(int64*)(DAT_181e50a28 + 184);
        if (*pStatics != 0) {
          ForceDetailController.ShowForceDetail
                    (*pStatics,this.forceID,0);
          return;
        }
    }

    // Token : 0x600151C
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

}
