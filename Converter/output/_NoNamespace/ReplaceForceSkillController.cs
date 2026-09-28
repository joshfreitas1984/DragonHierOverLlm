// ============================================================
// Type  : ReplaceForceSkillController
// Token : 0x200012E
// ============================================================

public class ReplaceForceSkillController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000761
    public int skillID;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60009D0
    // RVA   : 0xD12CA0   Offset: 0xD120A0   Length: 0x66
    public void OnClick()
    {
        long lVar1;
        ulong uVar2;
        lVar1 = **(int64 **)(DAT_181d87998 + 184);
        uVar2 = Component.get_gameObject(this,0);
        if (lVar1 != null) {
          ManageReplaceForceController.RemoveForceSkill(lVar1,uVar2,0);
          return;
        }
    }

    // Token : 0x60009D1
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
