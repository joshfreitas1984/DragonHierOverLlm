// ============================================================
// Type  : URLButtonController
// Token : 0x20003A7
// ============================================================

public class URLButtonController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001CD0
    public string targetURL;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60022E6
    // RVA   : 0x9DBF80   Offset: 0x9DA780   Length: 0xAD
    public void OpenURL()
    {
        bool cVar1;
        cVar1 = FUN_180d6ca90(this.targetURL,0);
        if (!cVar1) {
          Application.OpenURL(this.targetURL,0);
          plVar2 = (int64 *)Resources.Load("Sound/SoundEffect/Paper",0);
          plVar3 = (int64 *)0;
          if ((plVar2 != (int64 *)0) && (*plVar2 == DAT_181d8a228)) {
            plVar3 = plVar2;
          }
          NGUITools.PlaySound(plVar3,0);
          return;
        }
    }

    // Token : 0x60022E7
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
