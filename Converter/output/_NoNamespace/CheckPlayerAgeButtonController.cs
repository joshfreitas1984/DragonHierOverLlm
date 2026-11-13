// ============================================================
// Type  : CheckPlayerAgeButtonController
// Token : 0x20001B9
// ============================================================

public class CheckPlayerAgeButtonController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000BEE
    public GameObject CheckPlayerAgeInfo;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000E85
    // RVA   : 0x6F5120   Offset: 0x6F3F20   Length: 0x33
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

    // Token : 0x6000E86
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

}
