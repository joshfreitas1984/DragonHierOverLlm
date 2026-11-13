// ============================================================
// Type  : ForceJobSettingIDDataBase
// Token : 0x2000216
// ============================================================

public class ForceJobSettingIDDataBase
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000F07
    public string jobName;

    // Token: 0x4000F08
    public string jobDescribe;

    // Token: 0x4000F09
    public List<LivingSkillType> effectSkill;

    // Token: 0x4000F0A
    public List<ForceSpeAddDataType> effectForceSpeAdd;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001014
    // RVA   : 0x1850A20   Offset: 0x184F820   Length: 0x168
    public string GetEffectSkillText()
    {
        long lVar1;
        bool cVar2;
        uint uVar3;
        ulong uVar4;
        ulong uVar5;
        int iVar6;
        ulong uVar7;
        iVar6 = 0;
        lVar1 = this.effectSkill;
        uVar5 = "";
        while (lVar1 != null) {
          if (lVar1.Count <= iVar6) {
            return uVar5;
          }
          cVar2 = FUN_1816387f0(uVar5,"",0);
          uVar7 = "/";
          if (cVar2) {
            uVar7 = "";
          }
          lVar1 = *(int64 *)(*(int64 *)(DAT_181e538e8 + 184) + 0x4b8);
          if ((this.effectSkill == null) ||
             (uVar3 = FUN_180002480(this.effectSkill,iVar6,DAT_181e753f0), lVar1 == null))
          break;
          uVar4 = FUN_1800024b0(lVar1,uVar3,DAT_181e86970);
          uVar5 = String.Concat(uVar5,uVar7,uVar4,0);
          iVar6 = iVar6 + 1;
          lVar1 = this.effectSkill;
        }
    }

    // Token : 0x6001015
    // RVA   : 0x42F150   Offset: 0x42DF50   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

}
