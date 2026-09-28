// ============================================================
// Type  : HideGameDemoVersion
// Token : 0x20002D7
// ============================================================

public class HideGameDemoVersion
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001762
    public DemoVersion targetDemoVersion;

    // Token: 0x4001763
    public bool activeMode;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001815
    // RVA   : 0xAFF7F0   Offset: 0xAFEBF0   Length: 0x87
    private void Awake()
    {
        long lVar1;
        if (*(int *)(*(int64 *)(DAT_181d73d40 + 184) + 8) == this.targetDemoVersion) {
          lVar1 = Component.get_gameObject(this,0);
          if (lVar1 != null) {
            GameObject.SetActive(lVar1,this.activeMode,0);
            return;
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
    }

    // Token : 0x6001816
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
