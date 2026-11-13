// ============================================================
// Type  : GameStopQuitButtonController
// Token : 0x20002B4
// ============================================================

public class GameStopQuitButtonController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40015DD
    public bool clickCloseMenu;

    // Token: 0x40015DE
    public float autoClickTime;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001731
    // RVA   : 0x6BF0A0   Offset: 0x6BDEA0   Length: 0xA0
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
                lVar1 = FUN_180b05920(lVar1,0);
                if (lVar1 != null) {
                  lVar1 = Component.get_gameObject(lVar1,0);
                  if (lVar1 != null) {
                    GameObject.SetActive(lVar1,0,0);
                    return;
                  }
                }
              }
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            Application.Quit(0);
          }
        }
    }

    // Token : 0x6001732
    // RVA   : 0x6BF040   Offset: 0x6BDE40   Length: 0x55
    public void OnClick()
    {
        long lVar1;
        if (!this.clickCloseMenu) {
          Application.Quit(0);
          return;
        }
        lVar1 = Component.get_transform(this,0);
        if (lVar1 != null) {
          lVar1 = FUN_180b05920(lVar1,0);
          if (lVar1 != null) {
            lVar1 = Component.get_gameObject(lVar1,0);
            if (lVar1 != null) {
              GameObject.SetActive(lVar1,0,0);
              return;
            }
          }
        }
    }

    // Token : 0x6001733
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

}
