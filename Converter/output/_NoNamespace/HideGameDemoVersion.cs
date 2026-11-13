// ============================================================
// Type  : HideGameDemoVersion
// Token : 0x20002E0
// ============================================================

public class HideGameDemoVersion
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40017B7
    public DemoVersion targetDemoVersion;

    // Token: 0x40017B8
    public bool activeMode;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001891
    // RVA   : 0x8A2020   Offset: 0x8A0E20   Length: 0x87
    private void Awake()
    {
        long lVar1;
        if (*(int *)(*(int64 *)(DAT_181e538e8 + 184) + 8) == this.targetDemoVersion) {
          lVar1 = Component.get_gameObject(this,0);
          if (lVar1 != null) {
            GameObject.SetActive(lVar1,this.activeMode,0);
            return;
          }
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
    }

    // Token : 0x6001892
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

}
