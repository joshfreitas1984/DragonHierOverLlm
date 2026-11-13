// ============================================================
// Type  : HideGameVersion
// Token : 0x20002E1
// ============================================================

public class HideGameVersion
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40017B9
    public Version targetVersion;

    // Token: 0x40017BA
    public bool activeMode;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001893
    // RVA   : 0x8A20B0   Offset: 0x8A0EB0   Length: 0x86
    private void Awake()
    {
        long lVar1;
        if (**(int **)(DAT_181e538e8 + 184) == this.targetVersion) {
          lVar1 = Component.get_gameObject(this,0);
          if (lVar1 != null) {
            GameObject.SetActive(lVar1,this.activeMode,0);
            return;
          }
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
    }

    // Token : 0x6001894
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

}
