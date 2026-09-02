// ============================================================
// Type  : SkillHandBookForceTab
// Token : 0x2000354
// ============================================================

public class SkillHandBookForceTab
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001A9C
    public int targetForceID;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60020A6
    // RVA   : 0x9723C0   Offset: 0x970BC0   Length: 0x50
    public void OnClick()
    {
        var pStatics = *(int64*)(DAT_181d50800 + 184);
        if (*pStatics != 0) {
          HandBookMenuController.ShowForceSkill
                    (*pStatics,this.targetForceID,0);
          return;
        }
    }

    // Token : 0x60020A7
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
