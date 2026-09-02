// ============================================================
// Type  : CFX_InspectorHelp
// Token : 0x20003C0
// ============================================================

public class CFX_InspectorHelp
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001D4A
    public bool Locked;

    // Token: 0x4001D4B
    public string Title;

    // Token: 0x4001D4C
    public string HelpText;

    // Token: 0x4001D4D
    public int MsgType;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002381
    // RVA   : 0xBD5650   Offset: 0xBD3E50   Length: 0x5
    private void Unlock()
    {
        void FUN_180bd5650(int64 this)
        {
        this.Locked = 0;
    }

    // Token : 0x6002382
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
