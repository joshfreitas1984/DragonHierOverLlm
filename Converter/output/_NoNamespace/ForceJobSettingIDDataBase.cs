// ============================================================
// Type  : ForceJobSettingIDDataBase
// Token : 0x200020E
// ============================================================

public class ForceJobSettingIDDataBase
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000E63
    public string jobName;

    // Token: 0x4000E64
    public string jobDescribe;

    // Token: 0x4000E65
    public List<LivingSkillType> effectSkill;

    // Token: 0x4000E66
    public List<ForceSpeAddDataType> effectForceSpeAdd;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000FD3
    // RVA   : 0x77EC30   Offset: 0x77D430   Length: 0x168
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
          cVar2 = FUN_1816fd990(uVar5,"",0);
          uVar7 = "/";
          if (cVar2) {
            uVar7 = "";
          }
          lVar1 = *(int64 *)(*(int64 *)(DAT_181d4ef00 + 184) + 0x4a8);
          if ((this.effectSkill == null) ||
             (uVar3 = FUN_1800d6750(this.effectSkill,iVar6,DAT_181d6b9e8), lVar1 == null))
          break;
          uVar4 = FUN_180002f80(lVar1,uVar3,DAT_181d7c9c0);
          uVar5 = String.Concat(uVar5,uVar7,uVar4,0);
          iVar6 = iVar6 + 1;
          lVar1 = this.effectSkill;
        }
    }

    // Token : 0x6000FD4
    // RVA   : 0x210B70   Offset: 0x20F370   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

}
