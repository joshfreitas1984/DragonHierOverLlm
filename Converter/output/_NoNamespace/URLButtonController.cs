// ============================================================
// Type  : URLButtonController
// Token : 0x20003AE
// ============================================================

public class URLButtonController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001DD5
    public string targetURL;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002368
    // RVA   : 0xC0FF40   Offset: 0xC0F340   Length: 0xAD
    public void OpenURL()
    {
        bool cVar1;
        cVar1 = FUN_180d755b0(this.targetURL,0);
        if (!cVar1) {
          Application.OpenURL(this.targetURL,0);
          plVar2 = (int64 *)Resources.Load("Sound/SoundEffect/Paper",0);
          plVar3 = (int64 *)0;
          if ((plVar2 != (int64 *)0) && (*plVar2 == DAT_181daf348)) {
            plVar3 = plVar2;
          }
          NGUITools.PlaySound(plVar3,0);
          return;
        }
    }

    // Token : 0x6002369
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
