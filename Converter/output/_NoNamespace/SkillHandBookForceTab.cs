// ============================================================
// Type  : SkillHandBookForceTab
// Token : 0x2000368
// ============================================================

public class SkillHandBookForceTab
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001C1C
    public int targetForceID;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60021CF
    // RVA   : 0x6AD200   Offset: 0x6AC000   Length: 0x50
    public void OnClick()
    {
        var pStatics = *(int64*)(DAT_181e55378 + 184);
        if (*pStatics != 0) {
          HandBookMenuController.ShowForceSkill
                    (*pStatics,this.targetForceID,0);
          return;
        }
    }

    // Token : 0x60021D0
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

}
