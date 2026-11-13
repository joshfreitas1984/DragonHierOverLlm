// ============================================================
// Type  : ContributionSkillUnlockButtonController
// Token : 0x2000258
// ============================================================

public class ContributionSkillUnlockButtonController
{
    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001356
    // RVA   : 0x64BA50   Offset: 0x64A850   Length: 0x101
    public void OnClick()
    {
        long lVar1;
        long lVar2;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181e6f868 + 184) + 16);
        lVar2 = Component.get_transform(this,0);
        if (lVar2 != null) {
          lVar2 = FUN_180b05920(lVar2,0);
          if (lVar2 != null) {
            lVar2 = Component.GetComponent(lVar2,DAT_181e78e38);
            if ((lVar2 != null) && (lVar1 != null)) {
              OtherForceContributionExchangeController.ExchangeSkillClicked
                        (lVar1,*(uint64 *)(lVar2 + 32),0);
              return;
            }
          }
        }
    }

    // Token : 0x6001357
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

}
