// ============================================================
// Type  : HeroAISettingTabController
// Token : 0x20002C6
// ============================================================

public class HeroAISettingTabController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400171C
    public HeroData targetHero;

    // Token: 0x400171D
    public GameObject AISettingTabGrid;

    // Token: 0x400171E
    public GameObject AISettingTabPrefab;

    // Token: 0x400171F
    private GameObject temp;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60017E8
    // RVA   : 0x5AF3F0   Offset: 0x5AE1F0   Length: 0x373
    public void Generate()
    {
        int iVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        int iVar5;
        lVar2 = Component.get_transform(this,0);
        if ((lVar2 != null) && (lVar2 = Transform.Find(lVar2,"ForceLv",0)) != null) {
          uVar3 = Component.GetComponent(lVar2,DAT_181e79538);
          if (this.targetHero != null) {
            uVar4 = HeroData.GetHeroForceLvDescribeSimplify(this.targetHero,0);
            LTLocalization.SetText(uVar3,uVar4,0);
            lVar2 = Component.get_transform(this,0);
            if ((lVar2 != null) && (lVar2 = Transform.Find(lVar2,"Name",0)) != null) {
              uVar3 = Component.GetComponent(lVar2,DAT_181e79538);
              if (this.targetHero != null) {
                uVar4 = HeroData.HeroName(this.targetHero,1,0);
                LTLocalization.SetText(uVar3,uVar4,0);
                lVar2 = Component.get_transform(this,0);
                if ((lVar2 != null) && (lVar2 = Transform.Find(lVar2,"Name",0)) != null) {
                  lVar2 = Component.GetComponent(lVar2,DAT_181e773b8);
                  if ((this.targetHero != null) && (lVar2 != null)) {
                    lVar2.summonLv = this.targetHero.heroName;
                    lVar2 = this.targetHero;
                    iVar5 = 0;
                    if (lVar2 != null) {
                      while( true ) {
                        if ((lVar2.heroAISettingData == null) ||
                           (lVar2 = *(int64 *)(lVar2.heroAISettingData + 16)) == null)
                        throw; // [null/range check failed]
                        iVar1 = Dictionary_2.get_Count(lVar2,DAT_181e939a8);
                        if (iVar1 <= iVar5) break;
                        uVar3 = this.AISettingTabGrid;
                        uVar4 = this.AISettingTabPrefab;
                        uVar3 = GlobalData.AddChild(uVar3,uVar4);
                        this.temp = uVar3;
                        if ((this.temp == null) ||
                           (lVar2 = GameObject.GetComponent(this.temp,DAT_181e52f68),
                           lVar2 == null)) throw; // [null/range check failed]
                        lVar2.summonLv = this;
                        if ((this.temp == null) ||
                           (lVar2 = GameObject.GetComponent(this.temp,DAT_181e52f68),
                           lVar2 == null)) throw; // [null/range check failed]
                        lVar2.summonSourceHero = iVar5;
                        if ((this.temp == null) ||
                           (lVar2 = GameObject.GetComponent(this.temp,DAT_181e52f68),
                           lVar2 == null)) throw; // [null/range check failed]
                        AISettingTabController.Refresh(lVar2,0);
                        lVar2 = this.targetHero;
                        iVar5 = iVar5 + 1;
                        if (lVar2 == null) throw; // [null/range check failed]
                      }
                      lVar2 = Component.get_transform(this,0);
                      if ((lVar2 != null) && (lVar2 = Transform.Find(lVar2,"StudyNewSkill",0)) != null) {
                        lVar2 = Component.GetComponent(lVar2,DAT_181e770b8);
                        if ((this.targetHero != null) && (lVar2 != null)) {
                          Dropdown.set_value(lVar2,this.targetHero.studyNewSkillSetting
                                              ,0);
                          return;
                        }
                      }
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x60017E9
    // RVA   : 0x5AF770   Offset: 0x5AE570   Length: 0x17A
    public void StudyNewSkillTypeChanged()
    {
        int iVar1;
        long lVar2;
        long lVar3;
        if (this.targetHero != null) {
          iVar1 = this.targetHero.studyNewSkillSetting;
          lVar2 = Component.get_transform(this,0);
          if (((lVar2 != null) && (lVar2 = Transform.Find(lVar2,"StudyNewSkill",0)) != null) &&
             (lVar2 = Component.GetComponent(lVar2,DAT_181e770b8)) != null) {
            if (iVar1 == lVar2.haveMeet) {
              return;
            }
            lVar2 = this.targetHero;
            lVar3 = Component.get_transform(this,0);
            if (((lVar3 != null) && (lVar3 = Transform.Find(lVar3,"StudyNewSkill",0)) != null) &&
               ((lVar3 = Component.GetComponent(lVar3,DAT_181e770b8), lVar3 != null && (lVar2 != null)))) {
              lVar2.studyNewSkillSetting = *(uint32 *)(lVar3 + 0x120);
              plVar4 = (int64 *)Resources.Load("Sound/SoundEffect/Armor",0);
              plVar5 = (int64 *)0;
              if ((plVar4 != (int64 *)0) && (*plVar4 == DAT_181e8f4a0)) {
                plVar5 = plVar4;
              }
              NGUITools.PlaySound(plVar5,0x3f000000,0);
              return;
            }
          }
        }
    }

    // Token : 0x60017EA
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

}
