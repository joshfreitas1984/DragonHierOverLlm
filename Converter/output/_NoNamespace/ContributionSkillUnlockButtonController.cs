// ============================================================
// Type  : ContributionSkillUnlockButtonController
// Token : 0x200024E
// ============================================================

public class ContributionSkillUnlockButtonController
{
    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60012F1
    // RVA   : 0xA489D0   Offset: 0xA471D0   Length: 0x101
    public void OnClick()
    {
        long lVar1;
        long lVar2;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d6a268 + 184) + 16);
        lVar2 = Component.get_transform(this,0);
        if (lVar2 != null) {
          lVar2 = FUN_180da0f00(lVar2,0);
          if (lVar2 != null) {
            lVar2 = Component.GetComponent(lVar2,DAT_181d6d240);
            if ((lVar2 != null) && (lVar1 != null)) {
              OtherForceContributionExchangeController.ExchangeSkillClicked
                        (lVar1,*(uint64 *)(lVar2 + 32),0);
              return;
            }
          }
        }
    }

    // Token : 0x60012F2
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
