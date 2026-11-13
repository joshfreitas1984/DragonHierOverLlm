// ============================================================
// Type  : StudyAttackSkillController
// Token : 0x2000386
// ============================================================

public class StudyAttackSkillController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001CF7
    public bool inStudy;

    // Token: 0x4001CF8
    public bool finishing;

    // Token: 0x4001CF9
    public float totalExp;

    // Token: 0x4001CFA
    public int combo;

    // Token: 0x4001CFB
    public int hit;

    // Token: 0x4001CFC
    public int leftBulletCount;

    // Token: 0x4001CFD
    public int attackRangeType;

    // Token: 0x4001CFE
    public float flyTime;

    // Token: 0x4001CFF
    public KungfuSkillLvData targetSkill;

    // Token: 0x4001D00
    public GameObject studyAttackSkillRoot;

    // Token: 0x4001D01
    public GameObject bulletObjs;

    // Token: 0x4001D02
    public GameObject player;

    // Token: 0x4001D03
    public GameObject dartPrefab;

    // Token: 0x4001D04
    public GameObject arrowPrefab;

    // Token: 0x4001D05
    public GameObject bombPrefab;

    // Token: 0x4001D06
    public List<Vector3> attackRangeTypePos;

    // Token: 0x4001D07
    private static StudyAttackSkillController _instance;

    // Token: 0x4001D08
    private float generateTime;

    // Token: 0x4001D09
    private GameObject newBullet;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60022C4
    // RVA   : 0xDA60C0   Offset: 0xDA4EC0   Length: 0x36
    public static StudyAttackSkillController get_Instance()
    {
        return **(uint64 **)(DAT_181e883e8 + 184);
    }

    // Token : 0x60022C5
    // RVA   : 0xDA4920   Offset: 0xDA3720   Length: 0x12C
    private void Awake()
    {
        long lVar2;
        long lVar3;
        ulong uVar4;
        int[] local_res8 = new int[2];
        byte[] local_18 = new byte[16];
        plVar1 = *(int64 **)(DAT_181e883e8 + 184);
        *plVar1 = this;
        il2cpp_internal(plVar1,this);
        local_res8[0] = 3;
        while( true ) {
          lVar2 = this.attackRangeTypePos;
          if (this.player == null) break;
          lVar3 = GameObject.get_transform(this.player,0);
          if (lVar3 == null) break;
          lVar3 = Transform.Find(lVar3,"AttackRange",0);
          uVar4 = Int32.ToString(local_res8,0);
          if (lVar3 == null) break;
          lVar3 = Transform.Find(lVar3,uVar4,0);
          if (lVar3 == null) break;
          Transform.get_localPosition(local_18,lVar3,0);
          if (lVar2 == null) break;
          FUN_181756920(lVar2);
          local_res8[0] = local_res8[0] + 1;
          if (8 < local_res8[0]) {
            return;
          }
        }
    }

    // Token : 0x60022C6
    // RVA   : 0xDA5DB0   Offset: 0xDA4BB0   Length: 0x30B
    private void Update()
    {
        int iVar1;
        ulong uVar2;
        long lVar3;
        ulong uVar4;
        if (!this.inStudy) {
          return;
        }
        if (StudySkillController._instance != null) {
          uVar4 = StudySkillController._instance.expText;
          uVar2 = Single.ToString(this + 28,0);
          uVar2 = String.Concat("经验 ",uVar2,0);
          LTLocalization.SetText(uVar4,uVar2,0);
          if (StudySkillController._instance != null) {
            uVar4 = StudySkillController._instance.comboText;
            uVar2 = Int32.ToString(this + 32,0);
            LTLocalization.SetText(uVar4,uVar2,0);
            if ((GameController._instance != null) &&
               (lVar3 = GameController._instance.worldData) != null) {
              lVar3 = WorldData.Player(lVar3,0);
              if ((StudySkillController._instance != null) && (lVar3 != null)) {
                HeroData.SetHpBar(lVar3,StudySkillController._instance.hpBarRoot,0,0
                                  );
                if ((!this.finishing) &&
                   (StudyAttackSkillController.ManageBulletGenerate(this,0),
                   this.leftBulletCount < 1)) {
                  if ((this.bulletObjs == null) ||
                     (lVar3 = GameObject.get_transform(this.bulletObjs,0)) == null)
                  throw; // [null/range check failed]
                  iVar1 = Transform.get_childCount(lVar3,0);
                  if (iVar1 < 1) {
                    uVar4 = StudyAttackSkillController.FinishStudyFightSkill(this,2);
                    FUN_180ae80b0(this,uVar4,0);
                  }
                }
                return;
              }
            }
          }
        }
    }

    // Token : 0x60022C7
    // RVA   : 0xDA50F0   Offset: 0xDA3EF0   Length: 0x3CD
    public void ManageBulletGenerate()
    {
        uint uVar1;
        int iVar2;
        long lVar3;
        ulong uVar4;
        ulong uVar6;
        float fVar7;
        float fVar8;
        ulong local_res8;
        float local_res18;
        float fStackX_1c;
        float local_48;
        float fStack_44;
        uint32 local_40;
        uint64 local_38;
        uint32 local_30;
        local_res8 = 0;
        if (this.leftBulletCount < 1) {
          return;
        }
        fVar8 = this.generateTime;
        fVar7 = (float)Time.get_deltaTime(0);
        fVar8 = fVar8 - fVar7;
        this.generateTime = fVar8;
        if (0.0 < fVar8) {
          return;
        }
        fVar8 = (float)Random.get_value(0);
        if (fVar8 < 0.125) {
          uVar4 = this.bulletObjs;
          lVar3 = FUN_180210ca0(0);
          if (lVar3 == null) throw; // [null/range check failed]
          fVar8 = (float)Random.get_value(0);
          if (fVar8 < 0.6) {
            uVar6 = *(uint64 *)(lVar3 + 104);
          }
          else if (fVar8 < 0.8) {
            uVar6 = *(uint64 *)(lVar3 + 112);
          }
          else {
            uVar6 = *(uint64 *)(lVar3 + 120);
          }
          uVar4 = GlobalData.AddChild(uVar4,uVar6,0);
          this.newBullet = uVar4;
          if (this.newBullet == null) throw; // [null/range check failed]
          lVar3 = GameObject.get_transform(this.newBullet,0);
          local_res8 = Random.get_insideUnitCircle(0);
          uVar4 = Vector2.get_normalized(&local_res8,0);
          local_res18 = (float)uVar4;
          fStackX_1c = (float)((uint64)uVar4 >> 32);
          local_48 = local_res18 * 10.0;
          fStack_44 = fStackX_1c * 10.0;
          local_40 = 0;
          if (lVar3 == null) throw; // [null/range check failed]
          local_38 = CONCAT44(fStack_44,local_48);
          local_30 = 0;
          Transform.set_localPosition(lVar3,&local_38,0);
          if (this.newBullet == null) throw; // [null/range check failed]
          uVar4 = GameObject.get_transform(this.newBullet,0);
          uVar1 = this.flyTime;
          puVar5 = (uint64 *)Vector3.get_zero(&local_48,0);
          local_30 = *(uint32 *)(puVar5 + 1);
          local_38 = *puVar5;
          uVar4 = ShortcutExtensions.DOMove(uVar4,&local_38,uVar1,0,0);
          TweenSettingsExtensions.SetEase(uVar4,1,DAT_181ea4b88);
        }
        else {
          this.leftBulletCount = this.leftBulletCount + -1;
          fVar8 = (float)Random.get_value(0);
          if ((this.targetSkill == null) ||
             (lVar3 = KungfuSkillLvData.DataBase(this.targetSkill,0)) == null)
          throw; // [null/range check failed]
          if (fVar8 < (float)*(int *)(lVar3 + 52) * 0.1 + 0.15) {
            fVar8 = (float)Random.get_value(0);
            if (fVar8 < 0.5) {
              uVar4 = this.arrowPrefab;
            }
            else {
              uVar4 = this.bombPrefab;
            }
          }
          else {
            uVar4 = this.dartPrefab;
          }
          uVar4 = StudyAttackSkillController.CreateStudyAttackBullet(this,uVar4,0);
          this.newBullet = uVar4;
        }
        if ((this.targetSkill != null) &&
           (lVar3 = KungfuSkillLvData.DataBase(this.targetSkill,0)) != null) {
          iVar2 = *(int *)(lVar3 + 52);
          if ((this.targetSkill != null) &&
             (lVar3 = KungfuSkillLvData.DataBase(this.targetSkill,0)) != null) {
            fVar8 = (float)Random.Range(0.5 - (float)iVar2 * 0.05,
                                         1.0 - (float)*(int *)(lVar3 + 52) * 0.1,0);
            fVar7 = (float)Mathf.Max(0x3f800000,2.0 - (float)this.combo * 0.1,0);
            this.generateTime = fVar7 * fVar8;
            return;
          }
        }
    }

    // Token : 0x60022C8
    // RVA   : 0xDA4C30   Offset: 0xDA3A30   Length: 0x439
    public GameObject CreateStudyAttackBullet(GameObject targetPrefab)
    {
        float fVar1;
        bool cVar2;
        long lVar3;
        long lVar4;
        ulong uVar5;
        ulong uVar6;
        long lVar8;
        float fVar9;
        float local_res8;
        float fStackX_c;
        uint64 local_res10;
        uint64 local_98;
        uint64 local_88;
        float local_80;
        uint64 local_78;
        float local_70;
        uint8 local_68 [16];
        uint8 local_58 [64];
        uVar5 = this.bulletObjs;
        lVar3 = GlobalData.AddChild(uVar5,targetPrefab,0);
        if (lVar3 != null) {
          lVar4 = GameObject.get_transform(lVar3,0);
          local_res10 = Random.get_insideUnitCircle(0);
          uVar5 = Vector2.get_normalized(&local_res10,0);
          local_res8 = (float)uVar5;
          fStackX_c = (float)((uint64)uVar5 >> 32);
          local_98 = CONCAT44(fStackX_c * 10.0,local_res8 * 10.0);
          if (lVar4 != null) {
            local_88 = local_98;
            local_80 = 0.0;
            Transform.set_localPosition(lVar4,&local_88,0);
            uVar6 = GameObject.get_transform(lVar3,0);
            puVar7 = (uint64 *)Vector3.get_zero(local_68,0);
            fVar9 = this.flyTime;
            uVar5 = *puVar7;
            fVar1 = *(float *)(puVar7 + 1);
            lVar4 = GameObject.GetComponent(lVar3,DAT_181e56d08);
            if (lVar4 != null) {
              local_88 = uVar5;
              local_80 = fVar1;
              uVar5 = ShortcutExtensions.DOMove(uVar6,&local_88,fVar9 / *(float *)(lVar4 + 28),0,0);
              TweenSettingsExtensions.SetEase(uVar5,1,DAT_181ea4b88);
              lVar4 = GameObject.GetComponent(lVar3,DAT_181e56d08);
              if (lVar4 != null) {
                if (0.0 < *(float *)(lVar4 + 32)) {
                  uVar5 = GameObject.get_transform(lVar3,0);
                  lVar4 = GameObject.GetComponent(lVar3,DAT_181e56d08);
                  if (lVar4 == null) throw; // [null/range check failed]
                  local_80 = 360.0;
                  local_88 = 0;
                  uVar5 = ShortcutExtensions.DORotate(uVar5,&local_88,*(uint32 *)(lVar4 + 32),1,0);
                  uVar5 = TweenSettingsExtensions.SetLoops(uVar5,0xffffffff,0,DAT_181ea4eb8);
                  TweenSettingsExtensions.SetEase(uVar5,1,DAT_181ea4968);
                }
                lVar4 = GameObject.GetComponent(lVar3,DAT_181e56d08);
                if (lVar4 != null) {
                  if (*(char *)(lVar4 + 36) != false) {
                    lVar4 = GameObject.get_transform(lVar3,0);
                    puVar7 = (uint64 *)Vector3.get_zero(local_68,0);
                    fVar9 = *(float *)(puVar7 + 1);
                    uVar5 = *puVar7;
                    lVar8 = GameObject.get_transform(lVar3,0);
                    if (lVar8 == null) throw; // [null/range check failed]
                    puVar7 = (uint64 *)Transform.get_localPosition(local_58,lVar8,0);
                    local_98._0_4_ = (float)uVar5;
                    local_98._4_4_ = (float)((uint64)uVar5 >> 32);
                    local_78 = *puVar7;
                    local_70 = *(float *)(puVar7 + 1);
                    local_80 = fVar9 - local_70;
                    local_88 = CONCAT44(local_98._4_4_ - (float)((uint64)local_78 >> 32),
                                        (float)local_98 - (float)local_78);
                    if (lVar4 == null) throw; // [null/range check failed]
                    local_78 = local_88;
                    local_70 = local_80;
                    Transform.set_right(lVar4,&local_78,0);
                  }
                  uVar5 = GameObject.GetComponent(lVar3,DAT_181e533a8);
                  cVar2 = Object.op_Inequality(uVar5,0,0);
                  if (cVar2) {
                    lVar4 = GameObject.GetComponent(lVar3,DAT_181e533a8);
                    if (lVar4 == null) throw; // [null/range check failed]
                    fVar9 = (float)AudioSource.get_volume(lVar4,0);
                    AudioSource.set_volume
                              (lVar4,fVar9 * *(float *)(*(int64 *)(DAT_181e528f8 + 184) + 16),0);
                  }
                  return lVar3;
                }
              }
            }
          }
        }
    }

    // Token : 0x60022C9
    // RVA   : 0xDA55D0   Offset: 0xDA43D0   Length: 0x7DE
    public void StartStudyFightSkill(KungfuSkillLvData target)
    {
        var pStatics_e150 = *(int64*)(DAT_181e8e150 + 184);
        int iVar1;
        bool cVar2;
        uint uVar3;
        long lVar4;
        long lVar5;
        ulong uVar7;
        int[] local_res8 = new int[2];
        ulong local_68;
        float local_60;
        ulong local_58;
        float local_50;
        byte[] local_38 = new byte[16];
        if (this.studyAttackSkillRoot != null) {
          GameObject.SetActive(this.studyAttackSkillRoot,1,0);
          if ((StudySkillController._instance != null) &&
             (lVar4 = StudySkillController._instance.hpBarRoot) != null) {
            GameObject.SetActive(lVar4,1,0);
            this.inStudy = 1;
            this.targetSkill = target;
            if (this.targetSkill != null) {
              uVar3 = KungfuSkillLvData.Type(this.targetSkill,0);
              this.attackRangeType = uVar3;
              if ((this.player != null) &&
                 (lVar4 = GameObject.GetComponent(this.player,DAT_181e56d90),
                 lVar4 != null)) {
                uVar7 = lVar4.cityAreaID;
                cVar2 = Object.op_Equality(uVar7,0,0);
                if (!cVar2) {
                  if ((GameController._instance == null) ||
                     (lVar4 = GameController._instance.worldData) == null)
                  throw; // [null/range check failed]
                  lVar4 = WorldData.Player(lVar4,0);
                  if ((this.player == null) ||
                     ((lVar5 = GameObject.GetComponent(this.player,DAT_181e56d90),
                      lVar5 == null || (lVar4 == null)))) throw; // [null/range check failed]
                  HeroData.RefreshHeroSkeleton(lVar4,lVar5.cityAreaID,0);
                }
                else {
                  if (this.player == null) throw; // [null/range check failed]
                  lVar4 = GameObject.GetComponent(this.player,DAT_181e56d90);
                  if ((GameController._instance == null) ||
                     (lVar5 = GameController._instance.worldData) == null)
                  throw; // [null/range check failed]
                  lVar5 = WorldData.Player(lVar5,0);
                  uVar7 = this.player;
                  puVar6 = (uint64 *)Vector3.get_one(local_38,0);
                  local_58 = *puVar6;
                  local_50 = *(float *)(puVar6 + 1);
                  local_60 = local_50 * 0.5;
                  local_68 = CONCAT44((float)((uint64)local_58 >> 32) * 0.5,(float)local_58 * 0.5);
                  if (lVar5 == null) throw; // [null/range check failed]
                  local_58 = local_68;
                  local_50 = local_60;
                  uVar7 = HeroData.GenerateHeroSkeleton(lVar5,uVar7,&local_58,0);
                  if (lVar4 == null) throw; // [null/range check failed]
                  lVar4.cityAreaID = uVar7;
                  if ((((this.player == null) ||
                       (lVar4 = GameObject.GetComponent(this.player,DAT_181e56d90),
                       lVar4 == null)) || (lVar4.cityAreaID == null)) ||
                     (lVar4 = Component.get_transform(lVar4.cityAreaID,0)) == null)
                  throw; // [null/range check failed]
                  local_60 = 0.1;
                  local_68 = 0;
                  Transform.set_localPosition(lVar4,&local_68,0);
                }
                if ((GameController._instance != null) &&
                   (lVar4 = GameController._instance.worldData) != null) {
                  lVar4 = WorldData.Player(lVar4,0);
                  if (((this.player != null) &&
                      (((lVar5 = GameObject.GetComponent(this.player,DAT_181e56d90),
                        lVar5 != null && (uVar7 = lVar5.cityAreaID, target != null)) &&
                       (lVar5 = KungfuSkillLvData.DataBase(target,0)) != null))) && (lVar4 != null)) {
                    HeroData.SetSkillWeapon(lVar4,uVar7,lVar5.cheating,0);
                    if (((this.player != null) &&
                        (lVar4 = GameObject.GetComponent(this.player,DAT_181e56d90),
                        lVar4 != null)) &&
                       ((lVar4.cityAreaID != null &&
                        (lVar4 = SkeletonAnimation.get_AnimationState(lVar4.cityAreaID,0),
                        lVar4 != null)))) {
                      AnimationState.SetAnimation(lVar4,0,"idle",1,0);
                      local_res8[0] = 3;
                      do {
                        lVar4 = this.player;
                        if (this.attackRangeType == local_res8[0]) {
                          if ((lVar4 == null) || (lVar4 = GameObject.get_transform(lVar4,0)) == null)
                          throw; // [null/range check failed]
                          lVar4 = Transform.Find(lVar4,"AttackRange",0);
                          uVar7 = Int32.ToString(local_res8,0);
                          if ((lVar4 == null) || (lVar4 = Transform.Find(lVar4,uVar7,0)) == null)
                          throw; // [null/range check failed]
                          lVar4 = Component.get_gameObject(lVar4,0);
                        }
                        else {
                          if ((lVar4 == null) || (lVar4 = GameObject.get_transform(lVar4,0)) == null)
                          throw; // [null/range check failed]
                          lVar4 = Transform.Find(lVar4,"AttackRange",0);
                          uVar7 = Int32.ToString(local_res8,0);
                          if ((lVar4 == null) || (lVar4 = Transform.Find(lVar4,uVar7,0)) == null)
                          throw; // [null/range check failed]
                          lVar4 = Component.get_gameObject(lVar4);
                        }
                        if (lVar4 == null) throw; // [null/range check failed]
                        GameObject.SetActive(lVar4);
                        local_res8[0] = local_res8[0] + 1;
                      } while (local_res8[0] < 9);
                      if ((this.targetSkill != null) &&
                         (lVar4 = KungfuSkillLvData.DataBase(this.targetSkill,0), lVar4 != null
                         )) {
                        iVar1 = *(int *)(lVar4 + 52);
                        this.totalExp = 0;
                        this.flyTime = 5.0 / ((float)iVar1 * 0.2 + 1.0);
                        StudyAttackSkillController.ResetCombo(this,0);
                        this.hit = 0;
                        if ((this.targetSkill != null) &&
                           (lVar4 = KungfuSkillLvData.DataBase(this.targetSkill,0),
                           lVar4 != null)) {
                          this.leftBulletCount = *(int *)(lVar4 + 52) * 3 + 20;
                          if (*pStatics_e150 != 0) {
                            TutorialController.StartTutorial
                                      (*pStatics_e150,"练习外功",0);
                            if (*pStatics_e150 != 0) {
                              TutorialController.StartTutorial
                                        (*pStatics_e150,"外功连击",0);
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
        }
    }

    // Token : 0x60022CA
    // RVA   : 0xDA4A50   Offset: 0xDA3850   Length: 0x1DB
    public void ChangeCombo(int num)
    {
        long lVar1;
        ulong uVar3;
        uint uVar4;
        ulong local_28;
        uint local_20;
        byte[] local_18 = new byte[16];
        this.combo = this.combo + num;
        if ((StudySkillController._instance != null) &&
           (lVar1 = StudySkillController._instance.comboText) != null) {
          lVar1 = Component.get_transform(lVar1,0);
          if (lVar1 != null) {
            lVar1 = FUN_180b05920(lVar1,0);
            puVar2 = (uint64 *)Vector3.get_one(local_18,0);
            if (lVar1 != null) {
              local_20 = *(uint32 *)(puVar2 + 1);
              local_28 = *puVar2;
              Transform.set_localScale(lVar1,&local_28,0);
              if ((StudySkillController._instance != null) &&
                 (lVar1 = StudySkillController._instance.comboText) != null) {
                lVar1 = Component.get_transform(lVar1,0);
                if (lVar1 != null) {
                  uVar3 = FUN_180b05920(lVar1,0);
                  if (num < 1) {
                    uVar4 = 0x3f333333;
                  }
                  else {
                    uVar4 = 0x3fa66666;
                  }
                  uVar3 = ShortcutExtensions.DOScale(uVar3,uVar4,0x3dcccccd,0);
                  TweenSettingsExtensions.SetLoops(uVar3,2,1,DAT_181ea4f40);
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x60022CB
    // RVA   : 0xDA54C0   Offset: 0xDA42C0   Length: 0x106
    public void ResetCombo()
    {
        long lVar1;
        ulong local_28;
        uint local_20;
        byte[] local_18 = new byte[16];
        this.combo = 0;
        if ((StudySkillController._instance != null) &&
           (lVar1 = StudySkillController._instance.comboText) != null) {
          lVar1 = Component.get_transform(lVar1,0);
          if (lVar1 != null) {
            lVar1 = FUN_180b05920(lVar1,0);
            puVar2 = (uint64 *)Vector3.get_zero(local_18,0);
            if (lVar1 != null) {
              local_20 = *(uint32 *)(puVar2 + 1);
              local_28 = *puVar2;
              Transform.set_localScale(lVar1,&local_28,0);
              return;
            }
          }
        }
    }

    // Token : 0x60022CC
    // RVA   : 0xDA5070   Offset: 0xDA3E70   Length: 0x7B
    public IEnumerator FinishStudyFightSkill(StudySkillResult studyDodgeResult)
    {
        long lVar1;
        lVar1 = new WarpText_d__8(0,0);
        if (lVar1 != null) {
          *(uint64 *)(lVar1 + 32) = this;
          *(uint32 *)(lVar1 + 40) = studyDodgeResult;
          return lVar1;
        }
    }

    // Token : 0x60022CD
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

}
