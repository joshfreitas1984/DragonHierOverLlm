// ============================================================
// Type  : SkillHandBookForceTab
// Token : 0x200035B
// ============================================================

public class SkillHandBookForceTab
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001B9D
    public int targetForceID;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002127
    // RVA   : 0x984F50   Offset: 0x984350   Length: 0x50
    public void OnClick()
    {
        var pStatics = *(int64*)(DAT_181d757d0 + 184);
        if (*pStatics != 0) {
          HandBookMenuController.ShowForceSkill
                    (*pStatics,this.targetForceID,0);
          return;
        }
    }

    // Token : 0x6002128
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
