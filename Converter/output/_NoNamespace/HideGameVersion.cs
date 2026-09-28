// ============================================================
// Type  : HideGameVersion
// Token : 0x20002D8
// ============================================================

public class HideGameVersion
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001764
    public Version targetVersion;

    // Token: 0x4001765
    public bool activeMode;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001817
    // RVA   : 0xAFF880   Offset: 0xAFEC80   Length: 0x86
    private void Awake()
    {
        long lVar1;
        if (**(int **)(DAT_181d73d40 + 184) == this.targetVersion) {
          lVar1 = Component.get_gameObject(this,0);
          if (lVar1 != null) {
            GameObject.SetActive(lVar1,this.activeMode,0);
            return;
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
    }

    // Token : 0x6001818
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
