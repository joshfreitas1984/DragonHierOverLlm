// ============================================================
// Type  : GameStopQuitButtonController
// Token : 0x20002AB
// ============================================================

public class GameStopQuitButtonController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400158D
    public bool clickCloseMenu;

    // Token: 0x400158E
    public float autoClickTime;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60016B5
    // RVA   : 0xA5D300   Offset: 0xA5C700   Length: 0xA0
    public void Update()
    {
        long lVar1;
        float fVar2;
        float fVar3;
        fVar3 = this.autoClickTime;
        if (0.0 < fVar3) {
          fVar2 = (float)RealTime.get_deltaTime(0);
          fVar3 = fVar3 - fVar2;
          this.autoClickTime = fVar3;
          if (fVar3 <= 0.0) {
            if (this.clickCloseMenu) {
              lVar1 = Component.get_transform(this,0);
              if (lVar1 != null) {
                lVar1 = FUN_180daa030(lVar1,0);
                if (lVar1 != null) {
                  lVar1 = Component.get_gameObject(lVar1,0);
                  if (lVar1 != null) {
                    GameObject.SetActive(lVar1,0,0);
                    return;
                  }
                }
              }
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            Application.Quit(0);
          }
        }
    }

    // Token : 0x60016B6
    // RVA   : 0xA5D2A0   Offset: 0xA5C6A0   Length: 0x55
    public void OnClick()
    {
        long lVar1;
        if (!this.clickCloseMenu) {
          Application.Quit(0);
          return;
        }
        lVar1 = Component.get_transform(this,0);
        if (lVar1 != null) {
          lVar1 = FUN_180daa030(lVar1,0);
          if (lVar1 != null) {
            lVar1 = Component.get_gameObject(lVar1,0);
            if (lVar1 != null) {
              GameObject.SetActive(lVar1,0,0);
              return;
            }
          }
        }
    }

    // Token : 0x60016B7
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
