// ============================================================
// Type  : ReplaceForceSkillController
// Token : 0x200034F
// ============================================================

public class ReplaceForceSkillController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001B93
    public int skillID;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600214D
    // RVA   : 0xA6BF10   Offset: 0xA6AD10   Length: 0x66
    public void OnClick()
    {
        long lVar1;
        ulong uVar2;
        lVar1 = **(int64 **)(DAT_181e67d70 + 184);
        uVar2 = Component.get_gameObject(this,0);
        if (lVar1 != null) {
          ManageReplaceForceController.RemoveForceSkill(lVar1,uVar2,0);
          return;
        }
    }

    // Token : 0x600214E
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

}
