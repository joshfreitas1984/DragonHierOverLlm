// ============================================================
// Type  : CFX_InspectorHelp
// Token : 0x20003C7
// ============================================================

public class CFX_InspectorHelp
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001E55
    public bool Locked;

    // Token: 0x4001E56
    public string Title;

    // Token: 0x4001E57
    public string HelpText;

    // Token: 0x4001E58
    public int MsgType;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002404
    // RVA   : 0xB805A0   Offset: 0xB7F9A0   Length: 0x5
    private void Unlock()
    {
        void FUN_180b805a0(int64 this)
        {
        this.Locked = 0;
    }

    // Token : 0x6002405
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
