// ============================================================
// Type  : HideGameDemoVersion
// Token : 0x20002D1
// ============================================================

public class HideGameDemoVersion
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40016AE
    public DemoVersion targetDemoVersion;

    // Token: 0x40016AF
    public bool activeMode;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60017D1
    // RVA   : 0xB3E840   Offset: 0xB3D040   Length: 0x87
    private void Awake()
    {
        long lVar1;
        if (*(int *)(*(int64 *)(DAT_181d4ef00 + 184) + 8) == this.targetDemoVersion) {
          lVar1 = Component.get_gameObject(this,0);
          if (lVar1 != null) {
            GameObject.SetActive(lVar1,this.activeMode,0);
            return;
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
    }

    // Token : 0x60017D2
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
