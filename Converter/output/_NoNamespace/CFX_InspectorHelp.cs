// ============================================================
// Type  : CFX_InspectorHelp
// Token : 0x20003D4
// ============================================================

public class CFX_InspectorHelp
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001EE7
    public bool Locked;

    // Token: 0x4001EE8
    public string Title;

    // Token: 0x4001EE9
    public string HelpText;

    // Token: 0x4001EEA
    public int MsgType;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60024AE
    // RVA   : 0x939850   Offset: 0x938650   Length: 0x5
    private void Unlock()
    {
        void FUN_180939850(int64 this)
        {
        this.Locked = 0;
    }

    // Token : 0x60024AF
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

}
