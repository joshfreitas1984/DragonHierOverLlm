// ============================================================
// Type  : ForceJobSettingIDDataBase
// Token : 0x2000214
// ============================================================

public class ForceJobSettingIDDataBase
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000EF3
    public string jobName;

    // Token: 0x4000EF4
    public string jobDescribe;

    // Token: 0x4000EF5
    public List<LivingSkillType> effectSkill;

    // Token: 0x4000EF6
    public List<ForceSpeAddDataType> effectForceSpeAdd;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600100B
    // RVA   : 0x77B540   Offset: 0x77A940   Length: 0x168
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
          cVar2 = FUN_18171e540(uVar5,"",0);
          uVar7 = "/";
          if (cVar2) {
            uVar7 = "";
          }
          lVar1 = *(int64 *)(*(int64 *)(DAT_181d73d40 + 184) + 0x4b0);
          if ((this.effectSkill == null) ||
             (uVar3 = FUN_1800d6760(this.effectSkill,iVar6,DAT_181d93190), lVar1 == null))
          break;
          uVar4 = FUN_180002f80(lVar1,uVar3,DAT_181da4358);
          uVar5 = String.Concat(uVar5,uVar7,uVar4,0);
          iVar6 = iVar6 + 1;
          lVar1 = this.effectSkill;
        }
    }

    // Token : 0x600100C
    // RVA   : 0x210B70   Offset: 0x20FF70   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

}
