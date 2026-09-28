// ============================================================
// Type  : CheckPlayerAgeButtonController
// Token : 0x20001B7
// ============================================================

public class CheckPlayerAgeButtonController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000BDD
    public GameObject CheckPlayerAgeInfo;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000E81
    // RVA   : 0x9961C0   Offset: 0x9955C0   Length: 0x33
    public void OnClick()
    {
        long lVar1;
        bool cVar2;
        lVar1 = this.CheckPlayerAgeInfo;
        if (lVar1 != null) {
          cVar2 = GameObject.get_activeSelf(lVar1,0);
          GameObject.SetActive(lVar1,!cVar2,0);
          return;
        }
    }

    // Token : 0x6000E82
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
