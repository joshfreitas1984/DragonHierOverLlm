// ============================================================
// Type  : StudySkillController
// Token : 0x2000387
// ============================================================

public class StudySkillController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001C16
    public bool inStudy;

    // Token: 0x4001C17
    public KungfuSkillLvData targetSkill;

    // Token: 0x4001C18
    public AreaBuildingData targetBuilding;

    // Token: 0x4001C19
    public int studySkillType;

    // Token: 0x4001C1A
    public GameObject studySkillRoot;

    // Token: 0x4001C1B
    public GameObject studySkillUIPanel;

    // Token: 0x4001C1C
    public bool useMoney;

    // Token: 0x4001C1D
    public Text expText;

    // Token: 0x4001C1E
    public Text comboText;

    // Token: 0x4001C1F
    public GameObject hpBarRoot;

    // Token: 0x4001C20
    public GameObject studySkillStarPrefab;

    // Token: 0x4001C21
    public GameObject studySkillFoodPrefab;

    // Token: 0x4001C22
    public GameObject studySkillShieldPrefab;

    // Token: 0x4001C23
    public string finishCallFuc;

    // Token: 0x4001C24
    public List<GameObject> checkDisableObj;

    // Token: 0x4001C25
    public List<GameObject> checkEnableObj;

    // Token: 0x4001C26
    private SkillMaxPracticeExpData targetPracticeExpData;

    // Token: 0x4001C27
    private static StudySkillController _instance;

    // Token: 0x4001C28
    public static List<float> OverMaxLvMinusExpRate;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600221C
    // RVA   : 0xB960A0   Offset: 0xB948A0   Length: 0x57
    public static StudySkillController get_Instance()
    {
        return **(uint64 **)(DAT_181d82f70 + 184);
    }

    // Token : 0x600221D
    // RVA   : 0xB93E50   Offset: 0xB92650   Length: 0x61
    private void Awake()
    {
        puVar1 = *(uint64 **)(DAT_181d82f70 + 184);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x600221E
    // RVA   : 0xB94640   Offset: 0xB92E40   Length: 0xF6
    public static float GetPracticeExpRate(KungfuSkillLvData targetSkill)
    {
        float fVar1;
        uint uVar2;
        int iVar3;
        long lVar4;
        int iVar5;
        long lVar6;
        lVar4 = *(int64 *)(*(int64 *)(DAT_181d82f70 + 184) + 8);
        if (targetSkill != null) {
          lVar6 = KungfuSkillLvData.DataBase(targetSkill,0);
          if ((lVar6 != null) && (lVar4 != null)) {
            uVar2 = *(uint32 *)(lVar6 + 52);
            if (*(uint32 *)(lVar4 + 24) <= uVar2) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            iVar3 = *(int *)(targetSkill + 20);
            fVar1 = lVar4[uVar2];
            iVar5 = StudySkillController.GetMaxSkillSelfStudyLv(targetSkill,0);
            FUN_1810a8ba0(1.0 - (float)(iVar3 - iVar5) * fVar1);
            return;
          }
        }
    }

    // Token : 0x600221F
    // RVA   : 0xB94590   Offset: 0xB92D90   Length: 0xAD
    public static int GetMaxSkillSelfStudyLv(KungfuSkillLvData targetSkill)
    {
        var pStatics = *(int64*)(DAT_181d4ef00 + 184);
        int iVar1;
        if (targetSkill != null) {
          iVar1 = KungfuSkillLvData.Type(targetSkill,0);
          if (iVar1 < 3) {
            return *(uint32 *)(pStatics + 0x164);
          }
          return *(uint32 *)(pStatics + 0x168);
        }
    }

    // Token : 0x6002220
    // RVA   : 0xB95370   Offset: 0xB93B70   Length: 0x8AE
    public void StartStudySkill(StudySkillType studySkillType, KungfuSkillLvData target, string _finishCallFuc, AreaBuildingData _targetBuilding, bool _useMoney)
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        void StudySkillController.StartStudySkill
                     (int64 this,int studySkillType,uint64 target,uint64 _finishCallFuc,
                     uint64 _targetBuilding,uint8 _useMoney)
        {
        uint32 uVar1;
        char cVar2;
        int iVar3;
        int iVar4;
        int64 lVar5;
        uint64 uVar6;
        int64 *plVar7;
        int64 lVar8;
        int64 lVar9;
        int64 lVar10;
        uint64 uVar11;
        float fVar12;
        float local_res8 [2];
        uint32 local_res18 [4];
        int local_58 [2];
        uint64 local_50;
        local_res8[0] = 0.0;
        this.targetSkill = target;
        if ((*pStatics != 0) &&
           (lVar5 = *(int64 *)(*pStatics + 32)) != null) {
          lVar5 = WorldData.Player(lVar5,0);
          if ((this.targetSkill != null) && (lVar5 != null)) {
            uVar6 = HeroData.GetSkillMaxPracticeExp
                              (lVar5,this.targetSkill.skillID,0);
            this.targetPracticeExpData = uVar6;
            this.finishCallFuc = _finishCallFuc;
            this.targetBuilding = _targetBuilding;
            this.useMoney = _useMoney;
            if (studySkillType != null) {
              if (studySkillType == 1) {
                StudySkillController.PlayerStudySkill(this,0);
              }
              return;
            }
            uVar6 = this.targetSkill;
            iVar3 = StudySkillController.GetMaxSkillSelfStudyLv(uVar6,0);
            lVar5 = **(int64 **)(DAT_181d834f0 + 184);
            plVar7 = (int64 *)FUN_1800d60b0(DAT_181d7f180,5);
            if ((this.targetSkill != null) &&
               (lVar8 = KungfuSkillLvData.Name(this.targetSkill,1,0),
               plVar7 != (int64 *)0)) {
              if ((lVar8 != null) &&
                 (lVar9 = il2cpp_internal(lVar8,*(uint64 *)(*plVar7 + 64))) == null) {
                uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar6,0);
              }
              if ((int)plVar7[3] == 0) {
                uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar6,0);
              }
              plVar7[4] = lVar8;
              il2cpp_internal(plVar7 + 4,lVar8);
              if (this.targetSkill != null) {
                local_res18[0] = KungfuSkillLvData.StudyDayCost(this.targetSkill,0);
                lVar8 = il2cpp_value_box(DAT_181d5b2f8,local_res18);
                if ((lVar8 != null) &&
                   (lVar9 = il2cpp_internal(lVar8,*(uint64 *)(*plVar7 + 64))) == null) {
                  uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar6,0);
                }
                if (*(uint32 *)(plVar7 + 3) < 2) {
                  uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar6,0);
                }
                plVar7[5] = lVar8;
                il2cpp_internal(plVar7 + 5,lVar8);
                uVar6 = "确认消耗{1}天{4}练习{0}？{3}{2}";
                local_50 = "确认消耗{1}天{4}练习{0}？{3}{2}";
                if ((this.targetSkill == null) ||
                   (cVar2 = KungfuSkillLvData.FightExpFull(this.targetSkill,0),
                   !cVar2)) {
                  if (this.targetSkill == null) throw; // [null/range check failed]
                  lVar8 = "";
                  if (iVar3 < this.targetSkill.lv) {
                    local_58[0] = iVar3;
                    uVar6 = il2cpp_value_box(DAT_181d5b2f8,local_58);
                    lVar8 = this.targetSkill;
                    lVar9 = *(int64 *)(*(int64 *)(DAT_181d82f70 + 184) + 8);
                    if (((lVar8 == null) || (lVar10 = KungfuSkillLvData.DataBase(lVar8,0)) == null) ||
                       (lVar9 == null)) {
                          // WARNING: Subroutine does not return
                      FUN_1800d6620();
                    }
                    uVar1 = *(uint32 *)(lVar10 + 52);
                    if (*(uint32 *)(lVar9 + 24) <= uVar1) {
                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                    }
                    iVar3 = lVar8.lv;
                    fVar12 = lVar9[uVar1];
                    iVar4 = StudySkillController.GetMaxSkillSelfStudyLv(lVar8,0);
                    local_res8[0] =
                         (float)FUN_1810a8ba0(1.0 - (float)(iVar3 - iVar4) * fVar12,0,0x3f800000,0);
                    local_res8[0] = local_res8[0] * 100.0;
                    uVar11 = Single.ToString(local_res8,"f0",0);
                    lVar8 = String.Format("\n<i>{2}(因超过{0}级，练习只获取{1}%经验！)</color></i>",uVar6,uVar11,
                                           *(uint64 *)(*(int64 *)(DAT_181d4ef00 + 184) + 0x2d0),0)
                    ;
                    uVar6 = local_50;
                  }
                }
                else {
                  if (this.targetSkill == null) throw; // [null/range check failed]
                  cVar2 = KungfuSkillLvData.BookExpFull(this.targetSkill,0);
                  lVar8 = "\n<i>(武功经验已满，需在闭关室进行突破！)</i>";
                  if (!cVar2) {
                    if (this.targetSkill == null) throw; // [null/range check failed]
                    local_res8[0] =
                         (float)KungfuSkillLvData.GetSkillExpExchangeRate
                                          (this.targetSkill,0);
                    local_res8[0] = local_res8[0] * 100.0;
                    uVar11 = Single.ToString(local_res8,"f0",0);
                    lVar8 = String.Format("\n<i>(实战经验已满，将以{0}%比例转化为理论经验！)</i>",uVar11,0);
                  }
                }
                if ((lVar8 != null) &&
                   (lVar9 = il2cpp_internal(lVar8,*(uint64 *)(*plVar7 + 64))) == null) {
                  uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar6,0);
                }
                if (*(uint32 *)(plVar7 + 3) < 3) {
                  uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar6,0);
                }
                plVar7[6] = lVar8;
                il2cpp_internal(plVar7 + 6,lVar8);
                if (this.targetSkill != null) {
                  iVar3 = KungfuSkillLvData.Type(this.targetSkill,0);
                  if (iVar3 == 0) {
                    lVar8 = FUN_18046c0a0(0);
                    if (((lVar8 == null) || (lVar8.equiped == null)) ||
                       (lVar8 = WorldData.Player(lVar8.equiped,0)) == null)
                    throw; // [null/range check failed]
                    fVar12 = (float)HeroData.GetManaPercent(lVar8,0);
                    lVar8 = "";
                    if (fVar12 < 0.5) {
                      lVar8 = "\n<i>(当前内力值较低)</i>";
                    }
                  }
                  else {
                    lVar8 = FUN_18046c0a0(0);
                    if (((lVar8 == null) || (lVar8.equiped == null)) ||
                       (lVar8 = WorldData.Player(lVar8.equiped,0)) == null)
                    throw; // [null/range check failed]
                    fVar12 = (float)HeroData.GetHpPercent(lVar8,0);
                    lVar8 = "";
                    if (fVar12 < 0.5) {
                      lVar8 = "\n<i>(当前生命值较低)</i>";
                    }
                  }
                  if ((lVar8 != null) &&
                     (lVar9 = il2cpp_internal(lVar8,*(uint64 *)(*plVar7 + 64))) == null) {
                    uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar6,0);
                  }
                  if (*(uint32 *)(plVar7 + 3) < 4) {
                    uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar6,0);
                  }
                  plVar7[7] = lVar8;
                  il2cpp_internal(plVar7 + 7,lVar8);
                  lVar8 = "";
                  if (this.useMoney) {
                    if (this.targetSkill == null) {
                          // WARNING: Subroutine does not return
                      FUN_1800d6620();
                    }
                    local_58[0] = KungfuSkillLvData.StudyMoneyCost(this.targetSkill,0);
                    uVar11 = il2cpp_value_box(DAT_181d5b2f8,local_58);
                    lVar8 = String.Format("和{0}银两",uVar11,0);
                  }
                  if ((lVar8 != null) &&
                     (lVar9 = il2cpp_internal(lVar8,*(uint64 *)(*plVar7 + 64))) == null) {
                    uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar6,0);
                  }
                  if (*(uint32 *)(plVar7 + 3) < 5) {
                    uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar6,0);
                  }
                  plVar7[8] = lVar8;
                  il2cpp_internal(plVar7 + 8,lVar8);
                  uVar6 = String.Format(uVar6,plVar7,0);
                  if (lVar5 != null) {
                    SureMenu.CallSureMenu(lVar5,uVar6,"SureStartStudySkill",0,"StudySkillController",1,0);
                    return;
                  }
                }
                throw; // [null/range check failed]
              }
            }
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
        }
    }

    // Token : 0x6002221
    // RVA   : 0xB95C20   Offset: 0xB94420   Length: 0x35E
    public void SureStartStudySkill()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        int iVar1;
        int iVar2;
        uint uVar3;
        long lVar4;
        ulong uVar5;
        if (this.useMoney) {
          if ((*pStatics == 0) ||
             (lVar4 = *(int64 *)(*pStatics + 32)) == null)
          throw; // [null/range check failed]
          lVar4 = WorldData.Player(lVar4,0);
          if ((lVar4 == null) || (*(int64 *)(lVar4 + 0x220) == 0)) throw; // [null/range check failed]
          iVar2 = *(int *)(*(int64 *)(lVar4 + 0x220) + 24);
          if (this.targetSkill == null) throw; // [null/range check failed]
          iVar1 = KungfuSkillLvData.StudyMoneyCost(this.targetSkill,0);
          if (iVar2 < iVar1) {
            lVar4 = FUN_18046c0a0(0);
            if (lVar4 != null) {
              GameController.ShowTextOnMouse(lVar4,"银钱不足！",0);
              plVar6 = (int64 *)Resources.Load("Sound/SoundEffect/WrongClick",0);
              plVar7 = (int64 *)0;
              if ((plVar6 != (int64 *)0) && (*plVar6 == DAT_181d8a228)) {
                plVar7 = plVar6;
              }
              NGUITools.PlaySound(plVar7,0);
              return;
            }
            throw; // [null/range check failed]
          }
          lVar4 = FUN_18046c0a0(0);
          if ((lVar4 == null) || (*(int64 *)(lVar4 + 32) == 0)) throw; // [null/range check failed]
          lVar4 = WorldData.Player(*(int64 *)(lVar4 + 32),0);
          if (this.targetSkill == null) throw; // [null/range check failed]
          iVar2 = KungfuSkillLvData.StudyMoneyCost(this.targetSkill,0);
          if (lVar4 == null) throw; // [null/range check failed]
          HeroData.ChangeMoney(lVar4,-iVar2,1,0);
        }
        lVar4 = *(int64 *)(*(int64 *)(DAT_181d90b30 + 184) + 8);
        if (this.targetSkill != null) {
          uVar5 = KungfuSkillLvData.Name(this.targetSkill,1,0);
          uVar5 = String.Format("练习{0}",uVar5,0);
          if (this.targetSkill != null) {
            uVar3 = KungfuSkillLvData.StudyDayCost(this.targetSkill,0);
            if (lVar4 != null) {
              WorkingUIController.StartWorking(lVar4,uVar5,uVar3,0,0,"RealStartStudySkill",0,0);
              return;
            }
          }
        }
    }

    // Token : 0x6002222
    // RVA   : 0xB94DD0   Offset: 0xB935D0   Length: 0x59B
    public void RealStartStudySkill()
    {
        var pStatics = *(int64*)(DAT_181d4ef00 + 184);
        long lVar1;
        ulong uVar2;
        bool cVar3;
        long lVar5;
        long lVar6;
        ulong uVar7;
        ulong uVar8;
        ulong uVar9;
        float[] local_res18 = new float[2];
        float[] local_res20 = new float[2];
        uint[] local_28 = new uint[4];
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d90b30 + 184) + 8);
        if (lVar1 == null) {
        LAB_180b952c0:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        if (*(char *)(lVar1 + 96) == false) {
          return;
        }
        if ((this.targetPracticeExpData == null) ||
           (this.targetPracticeExpData.maxPracticeExp <= 0.0)) {
          StudySkillController.PlayerStudySkill(this,0);
          return;
        }
        lVar1 = **(int64 **)(DAT_181d834f0 + 184);
        plVar4 = (int64 *)FUN_1800d60b0(DAT_181d7f180,5);
        if ((this.targetSkill != null) &&
           (lVar5 = KungfuSkillLvData.Name(this.targetSkill,1,0), plVar4 != (int64 *)0)
           ) {
          if ((lVar5 != null) &&
             (lVar6 = il2cpp_internal(lVar5,*(uint64 *)(*plVar4 + 64))) == null) {
            uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar7,0);
          }
          if ((int)plVar4[3] == 0) {
            uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar7,0);
          }
          plVar4[4] = lVar5;
          il2cpp_internal(plVar4 + 4,lVar5);
          if (this.targetPracticeExpData != null) {
            lVar5 = Single.ToString(this.targetPracticeExpData + 20,"f0",0);
            if ((lVar5 != null) &&
               (lVar6 = il2cpp_internal(lVar5,*(uint64 *)(*plVar4 + 64))) == null) {
              uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar7,0);
            }
            if (*(uint32 *)(plVar4 + 3) < 2) {
              uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar7,0);
            }
            plVar4[5] = lVar5;
            il2cpp_internal(plVar4 + 5,lVar5);
            local_res18[0] = *(float *)(pStatics + 0x160) * 100.0;
            lVar5 = il2cpp_value_box(DAT_181d7d0b8,local_res18);
            if ((lVar5 != null) &&
               (lVar6 = il2cpp_internal(lVar5,*(uint64 *)(*plVar4 + 64))) == null) {
              uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar7,0);
            }
            if (*(uint32 *)(plVar4 + 3) < 3) {
              uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar7,0);
            }
            plVar4[6] = lVar5;
            il2cpp_internal(plVar4 + 6,lVar5);
            if (this.targetPracticeExpData != null) {
              local_res20[0] =
                   *(float *)(pStatics + 0x160) *
                   this.targetPracticeExpData.maxPracticeExp;
              lVar5 = Single.ToString(local_res20,"f0",0);
              if ((lVar5 != null) &&
                 (lVar6 = il2cpp_internal(lVar5,*(uint64 *)(*plVar4 + 64))) == null) {
                uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar7,0);
              }
              if (*(uint32 *)(plVar4 + 3) < 4) {
                uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar7,0);
              }
              plVar4[7] = lVar5;
              il2cpp_internal(plVar4 + 7,lVar5);
              local_28[0] = StudySkillController.GetAutoPracticeCost(this,0);
              uVar7 = Int32.ToString(local_28,0);
              if ((this.targetSkill != null) &&
                 (lVar5 = KungfuSkillLvData.DataBase(this.targetSkill,0),
                 uVar2 = "当前最高纪录：{1}点经验\n是否消耗{4}自动练习{0}？\n可得{2}%({3}点)", lVar5 != null)) {
                uVar8 = "内力";
                if (*(int *)(lVar5 + 48) != 0) {
                  uVar8 = "生命";
                }
                lVar5 = String.Concat(uVar7,uVar8,0);
                if ((lVar5 != null) &&
                   (lVar6 = il2cpp_internal(lVar5,*(uint64 *)(*plVar4 + 64))) == null) {
                  uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar7,0);
                }
                if (*(uint32 *)(plVar4 + 3) < 5) {
                  uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar7,0);
                }
                plVar4[8] = lVar5;
                il2cpp_internal(plVar4 + 8,lVar5);
                uVar8 = String.Format(uVar2,plVar4,0);
                uVar2 = "AutoStudySkill";
                lVar5 = "StudySkillController";
                uVar7 = "PlayerStudySkill";
                if (lVar1 != null) {
                  if ((lVar5 == null) || (cVar3 = FUN_1816fd990(lVar5,"",0), cVar3)) {
                    lVar5 = "GameController";
                  }
                  uVar9 = GameObject.FindGameObjectWithTag(lVar5,0);
                  SureMenu.CallSureMenu(lVar1,uVar8,uVar2,0,uVar9,1,0,uVar7,0,0);
                  return;
                }
                goto LAB_180b952c0;
              }
            }
          }
        }
    }

    // Token : 0x6002223
    // RVA   : 0xB944E0   Offset: 0xB92CE0   Length: 0xA0
    public int GetAutoPracticeCost()
    {
        long lVar1;
        float fVar2;
        if (this.targetSkill != null) {
          lVar1 = KungfuSkillLvData.DataBase(this.targetSkill,0);
          if (lVar1 != null) {
            fVar2 = (float)Mathf.Max(0x3f000000);
            if (this.targetSkill != null) {
              lVar1 = KungfuSkillLvData.DataBase(this.targetSkill,0);
              if (lVar1 != null) {
                if (*(int *)(lVar1 + 48) == 0) {
                  return (int)(fVar2 * 50.0 * 2.0);
                }
                return (int)(fVar2 * 50.0 * 1.0);
              }
            }
          }
        }
    }

    // Token : 0x6002224
    // RVA   : 0xB93AC0   Offset: 0xB922C0   Length: 0x381
    public void AutoStudySkill()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        float fVar1;
        ulong uVar2;
        bool cVar3;
        long lVar4;
        ulong uVar5;
        float[] local_res8 = new float[2];
        local_res8[0] = 0.0;
        if (this.targetSkill != null) {
          lVar4 = KungfuSkillLvData.DataBase(this.targetSkill,0);
          if (lVar4 != null) {
            if (*(int *)(lVar4 + 48) == 0) {
              if ((*pStatics == 0) ||
                 (lVar4 = *(int64 *)(*pStatics + 32)) == null)
              throw; // [null/range check failed]
              lVar4 = WorldData.Player(lVar4,0);
              StudySkillController.GetAutoPracticeCost(this,0);
              if (lVar4 == null) throw; // [null/range check failed]
              HeroData.ChangeMana(lVar4);
            }
            else {
              if ((*pStatics == 0) ||
                 (lVar4 = *(int64 *)(*pStatics + 32)) == null)
              throw; // [null/range check failed]
              lVar4 = WorldData.Player(lVar4,0);
              StudySkillController.GetAutoPracticeCost(this,0);
              if (lVar4 == null) throw; // [null/range check failed]
              HeroData.ChangeHp(lVar4);
            }
            if (this.finishCallFuc != null) {
              cVar3 = String.op_Inequality(this.finishCallFuc,"",0);
              if (cVar3) {
                lVar4 = FUN_18046c440(0);
                uVar2 = this.finishCallFuc;
                if (this.targetPracticeExpData != null) {
                  fVar1 = this.targetPracticeExpData.maxPracticeExp;
                  local_res8[0] = fVar1 * *(float *)(*(int64 *)(DAT_181d4ef00 + 184) + 0x160);
                  uVar5 = Single.ToString(local_res8,0);
                  if (lVar4 != null) {
                    Component.SendMessage(lVar4,uVar2,uVar5,0);
                    goto LAB_180b93ddb;
                  }
                }
                throw; // [null/range check failed]
              }
            }
        LAB_180b93ddb:
            plVar6 = (int64 *)Resources.Load("Sound/SoundEffect/SpeEffect/加速旋转",0);
            plVar7 = (int64 *)0;
            if ((plVar6 != (int64 *)0) && (*plVar6 == DAT_181d8a228)) {
              plVar7 = plVar6;
            }
            NGUITools.PlaySound(plVar7,0);
            return;
          }
        }
    }

    // Token : 0x6002225
    // RVA   : 0xB94790   Offset: 0xB92F90   Length: 0x630
    public void PlayerStudySkill()
    {
        var pStatics_2bf0 = *(int64*)(DAT_181d92bf0 + 184);
        var pStatics_2d70 = *(int64*)(DAT_181d82d70 + 184);
        var pStatics_2ef0 = *(int64*)(DAT_181d82ef0 + 184);
        var pStatics_3070 = *(int64*)(DAT_181d83070 + 184);
        var pStatics_fc60 = *(int64*)(DAT_181d8fc60 + 184);
        bool cVar1;
        int iVar2;
        long lVar3;
        ulong uVar5;
        uint uVar6;
        long lVar8;
        lVar3 = this.checkDisableObj;
        plVar7 = (int64 *)0;
        if (lVar3 != null) {
          lVar8 = 32;
          plVar4 = plVar7;
          while (uVar6 = (uint32)plVar4, (int)uVar6 < lVar3.Count) {
            if (lVar3 == null) throw; // [null/range check failed]
            if (lVar3.Count <= uVar6) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar3 = *(int64 *)(lVar8 + lVar3._items);
            if (lVar3 == null) throw; // [null/range check failed]
            cVar1 = GameObject.get_activeSelf(lVar3,0);
            if (cVar1) {
              if ((this.checkDisableObj == null) ||
                 (lVar3 = FUN_180002f80(this.checkDisableObj,plVar4,DAT_181d62178)) == null)
              throw; // [null/range check failed]
              GameObject.SetActive(lVar3,0,0);
              lVar3 = this.checkEnableObj;
              if ((this.checkDisableObj == null) ||
                 (FUN_180002f80(this.checkDisableObj,plVar4,DAT_181d62178), lVar3 == null))
              throw; // [null/range check failed]
              FUN_181827900(lVar3);
            }
            lVar3 = this.checkDisableObj;
            plVar4 = (int64 *)(uint64)(uVar6 + 1);
            lVar8 = lVar8 + 8;
            if (lVar3 == null) throw; // [null/range check failed]
          }
          if (this.studySkillRoot != null) {
            GameObject.SetActive(this.studySkillRoot,1,0);
            if (this.studySkillUIPanel != null) {
              GameObject.SetActive(this.studySkillUIPanel,1,0);
              this.inStudy = 1;
              if (*pStatics_2bf0 != 0) {
                CloudAnimController.PlayerCloudAnim(*pStatics_2bf0,0);
                plVar4 = (int64 *)Resources.Load("Sound/SoundEffect/紧张",0);
                if ((plVar4 != (int64 *)0) && (*plVar4 == DAT_181d8a228)) {
                  plVar7 = plVar4;
                }
                NGUITools.PlaySound(plVar7,0);
                if (this.targetSkill != null) {
                  iVar2 = KungfuSkillLvData.Type(this.targetSkill,0);
                  if (iVar2 == 0) {
                    lVar3 = *pStatics_fc60;
                    uVar5 = Component.get_gameObject(this,0);
                    if (lVar3 != null) {
                      WeatherController.SetWeatherSpeActive(lVar3,0,uVar5,0);
                      if (*pStatics_2ef0 != 0) {
                        StudyInternalSkillController.StartStudyInternalSkill
                                  (*pStatics_2ef0,this.targetSkill,0
                                  );
                        if ((((this.comboText == null) ||
                             (lVar3 = Component.get_transform(this.comboText,0),
                             lVar3 == null)) || (lVar3 = FUN_180da0f00(lVar3,0)) == null) ||
                           (lVar3 = Component.get_gameObject(lVar3,0)) == null) throw; // [null/range check failed]
                        GameObject.SetActive(lVar3,0,0);
                        if (((this.expText == null) ||
                            (lVar3 = Component.get_transform(this.expText,0), lVar3 == null
                            )) || ((lVar3 = FUN_180da0f00(lVar3,0), lVar3 == null ||
                                   (lVar3 = Component.get_gameObject(lVar3,0)) == null)))
                        throw; // [null/range check failed]
                        uVar5 = 0;
        LAB_180b94c8b:
                        GameObject.SetActive(lVar3,uVar5,0);
                        return;
                      }
                    }
                  }
                  else {
                    if (iVar2 == 1) {
                      lVar3 = *pStatics_fc60;
                      uVar5 = Component.get_gameObject(this,0);
                      if (lVar3 == null) throw; // [null/range check failed]
                      WeatherController.SetWeatherSpeActive(lVar3,0,uVar5,0);
                      lVar3 = *(int64 *)(*(int64 *)(DAT_181d82e70 + 184) + 8);
                      if (lVar3 == null) throw; // [null/range check failed]
                      StudyDodgeSkillController.StartStudyDodgeSkill
                                (lVar3,this.targetSkill,0);
                    }
                    else if (iVar2 == 2) {
                      lVar3 = *pStatics_fc60;
                      uVar5 = Component.get_gameObject(this,0);
                      if (lVar3 == null) throw; // [null/range check failed]
                      WeatherController.SetWeatherSpeActive(lVar3,0,uVar5,0);
                      if (*pStatics_3070 == 0) throw; // [null/range check failed]
                      StudyUniqueSkillController.StartStudyUniqueSkill
                                (*pStatics_3070,this.targetSkill,0);
                    }
                    else {
                      if (*pStatics_2d70 == 0) throw; // [null/range check failed]
                      StudyAttackSkillController.StartStudyFightSkill
                                (*pStatics_2d70,this.targetSkill,0);
                    }
                    if (((this.comboText != null) &&
                        (lVar3 = Component.get_transform(this.comboText,0)) != null)
                       && (lVar3 = FUN_180da0f00(lVar3,0)) != null) {
                      lVar3 = Component.get_gameObject(lVar3,0);
                      if (lVar3 != null) {
                        GameObject.SetActive(lVar3,1,0);
                        if (((this.expText != null) &&
                            (lVar3 = Component.get_transform(this.expText,0), lVar3 != null
                            )) && (lVar3 = FUN_180da0f00(lVar3,0)) != null) {
                          lVar3 = Component.get_gameObject(lVar3,0);
                          if (lVar3 != null) {
                            uVar5 = 1;
                            goto LAB_180b94c8b;
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

    // Token : 0x6002226
    // RVA   : 0xB93EC0   Offset: 0xB926C0   Length: 0x610
    public void FinishStudySkill(float expNum)
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        bool cVar1;
        ulong uVar2;
        long lVar3;
        ulong uVar4;
        uint uVar5;
        long lVar6;
        uint uVar7;
        float[] local_res10 = new float[2];
        ulong local_28;
        ulong uStack_20;
        local_res10[0] = expNum;
        lVar3 = this.checkEnableObj;
        uVar5 = 0;
        if (lVar3 != null) {
          lVar6 = 32;
          do {
            if (lVar3.maxReadExp <= (int)uVar5) {
              FUN_180f56130(lVar3,DAT_181d61c78);
              lVar3 = **(int64 **)(DAT_181d8fc60 + 184);
              uVar2 = Component.get_gameObject(this,0);
              if (lVar3 == null) break;
              WeatherController.SetWeatherSpeActive(lVar3,1,uVar2,0);
              if (this.studySkillRoot == null) break;
              GameObject.SetActive(this.studySkillRoot,0,0);
              if (this.studySkillUIPanel == null) break;
              GameObject.SetActive(this.studySkillUIPanel,0,0);
              if (this.hpBarRoot == null) break;
              GameObject.SetActive(this.hpBarRoot,0,0);
              this.inStudy = 0;
              if ((*pStatics == 0) ||
                 (lVar3 = *(int64 *)(*pStatics + 32)) == null) break;
              lVar3 = WorldData.Player(lVar3,0);
              if ((*pStatics == 0) ||
                 (lVar6 = *(int64 *)(*pStatics + 32)) == null) break;
              lVar6 = WorldData.Player(lVar6,0);
              if ((lVar6 == null) ||
                 (uVar7 = Mathf.Max(0x3f800000,*(uint32 *)(lVar6 + 0x178),0), lVar3 == null)) break;
              *(uint32 *)(lVar3 + 0x178) = uVar7;
              lVar3 = this.targetPracticeExpData;
              if (lVar3 == null) {
                if (this.targetSkill == null) break;
                uVar7 = this.targetSkill.skillID;
                this.targetPracticeExpData = new SkillMaxPracticeExpData(uVar7,0);
                if (this.targetPracticeExpData == null) break;
                this.targetPracticeExpData.maxPracticeExp = local_res10[0];
                if (((*pStatics == 0) ||
                    (lVar3 = *(int64 *)(*pStatics + 32)) == null) ||
                   (lVar3 = WorldData.Player(lVar3,0)) == null) break;
                HeroData.AddSkillMaxPracticeExp(lVar3,this.targetPracticeExpData,0);
        LAB_180b9430e:
                lVar3 = **(int64 **)(DAT_181d5a578 + 184);
                if (this.targetSkill == null) break;
                uVar2 = KungfuSkillLvData.Name(this.targetSkill,1,0);
                uVar4 = Single.ToString(local_res10,"f0",0);
                uVar2 = String.Format("{0}新的练习最高纪录：{1}点",uVar2,uVar4,0);
                if (lVar3 == null) break;
                local_28 = 0;
                uStack_20 = 0;
                InfoController.AddInfoTab
                          (lVar3,uVar2,"UIAtlas","从事工作_修炼","PencilWriting",0x3f800000,0x40a00000,
                           &local_28,0);
              }
              else if (lVar3.maxPracticeExp <= local_res10[0] &&
                       local_res10[0] != lVar3.maxPracticeExp) {
                lVar3.maxPracticeExp = local_res10[0];
                goto LAB_180b9430e;
              }
              if ((this.finishCallFuc != null) &&
                 (cVar1 = String.op_Inequality(this.finishCallFuc,"",0),
                 cVar1)) {
                uVar2 = this.finishCallFuc;
                lVar3 = **(int64 **)(DAT_181d6c960 + 184);
                uVar4 = Single.ToString(local_res10,0);
                if (lVar3 == null) break;
                Component.SendMessage(lVar3,uVar2,uVar4,0);
              }
              return;
            }
            if (lVar3 == null) break;
            if (lVar3.maxReadExp <= uVar5) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar3 = *(int64 *)(lVar6 + lVar3.skillID);
            if (lVar3 == null) break;
            GameObject.SetActive(lVar3,1,0);
            lVar3 = this.checkEnableObj;
            uVar5 = uVar5 + 1;
            lVar6 = lVar6 + 8;
          } while (lVar3 != null);
        }
    }

    // Token : 0x6002227
    // RVA   : 0xB94740   Offset: 0xB92F40   Length: 0x48
    public GameObject GetRandomStarPrefab()
    {
        float fVar1;
        fVar1 = (float)Random.get_value(0);
        if (fVar1 < 0.6) {
          return this.studySkillStarPrefab;
        }
        if (0.8 <= fVar1) {
          return this.studySkillShieldPrefab;
        }
        return this.studySkillFoodPrefab;
    }

    // Token : 0x6002228
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

    // Token : 0x6002229
    // RVA   : 0xB95F80   Offset: 0xB94780   Length: 0x11E
    private static void /*cctor*/()
    {
        long lVar1;
        lVar1 = il2cpp_internal(DAT_181d721b0);
        FUN_180f58a90(lVar1,DAT_181d79358);
        if (lVar1 != null) {
          FUN_181805690(lVar1,0x3d4ccccd,DAT_181d79458);
          FUN_181805690(lVar1,0x3dcccccd,DAT_181d79458);
          FUN_181805690(lVar1,0x3e4ccccd,DAT_181d79458);
          FUN_181805690(lVar1,0x3e99999a,DAT_181d79458);
          FUN_181805690(lVar1,0x3ecccccd,DAT_181d79458);
          FUN_181805690(lVar1,0x3f000000,DAT_181d79458);
          plVar2 = (int64 *)(*(int64 *)(DAT_181d82f70 + 184) + 8);
          *plVar2 = lVar1;
          il2cpp_internal(plVar2,lVar1);
          return;
        }
    }

}
