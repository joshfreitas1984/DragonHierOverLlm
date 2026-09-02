// ============================================================
// Type  : HideGameVersion
// Token : 0x20002D2
// ============================================================

public class HideGameVersion
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40016B0
    public Version targetVersion;

    // Token: 0x40016B1
    public bool activeMode;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60017D3
    // RVA   : 0xB3E8D0   Offset: 0xB3D0D0   Length: 0x86
    private void Awake()
    {
        long lVar1;
        if (**(int **)(DAT_181d4ef00 + 184) == this.targetVersion) {
          lVar1 = Component.get_gameObject(this,0);
          if (lVar1 != null) {
            GameObject.SetActive(lVar1,this.activeMode,0);
            return;
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
    }

    // Token : 0x60017D4
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
