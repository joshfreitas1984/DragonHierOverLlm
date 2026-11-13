// ============================================================
// Type  : URLButtonController
// Token : 0x20003BB
// ============================================================

public class URLButtonController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001E68
    public string targetURL;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002412
    // RVA   : 0x969860   Offset: 0x968660   Length: 0xAD
    public void OpenURL()
    {
        bool cVar1;
        cVar1 = FUN_180ad1200(this.targetURL,0);
        if (!cVar1) {
          Application.OpenURL(this.targetURL,0);
          plVar2 = (int64 *)Resources.Load("Sound/SoundEffect/Paper",0);
          plVar3 = (int64 *)0;
          if ((plVar2 != (int64 *)0) && (*plVar2 == DAT_181e8f4a0)) {
            plVar3 = plVar2;
          }
          NGUITools.PlaySound(plVar3,0);
          return;
        }
    }

    // Token : 0x6002413
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

}
