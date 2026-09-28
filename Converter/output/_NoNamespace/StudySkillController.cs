// ============================================================
// Type  : StudySkillController
// Token : 0x200038E
// ============================================================

public class StudySkillController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001D1B
    public bool inStudy;

    // Token: 0x4001D1C
    public KungfuSkillLvData targetSkill;

    // Token: 0x4001D1D
    public AreaBuildingData targetBuilding;

    // Token: 0x4001D1E
    public int studySkillType;

    // Token: 0x4001D1F
    public GameObject studySkillRoot;

    // Token: 0x4001D20
    public GameObject studySkillUIPanel;

    // Token: 0x4001D21
    public bool useMoney;

    // Token: 0x4001D22
    public Text expText;

    // Token: 0x4001D23
    public Text comboText;

    // Token: 0x4001D24
    public GameObject hpBarRoot;

    // Token: 0x4001D25
    public GameObject studySkillStarPrefab;

    // Token: 0x4001D26
    public GameObject studySkillFoodPrefab;

    // Token: 0x4001D27
    public GameObject studySkillShieldPrefab;

    // Token: 0x4001D28
    public string finishCallFuc;

    // Token: 0x4001D29
    public List<GameObject> checkDisableObj;

    // Token: 0x4001D2A
    public List<GameObject> checkEnableObj;

    // Token: 0x4001D2B
    private SkillMaxPracticeExpData targetPracticeExpData;

    // Token: 0x4001D2C
    private static StudySkillController _instance;

    // Token: 0x4001D2D
    public static List<float> OverMaxLvMinusExpRate;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600229E
    // RVA   : 0xFE4FE0   Offset: 0xFE43E0   Length: 0x57
    public static StudySkillController get_Instance()
    {
        return **(uint64 **)(DAT_181da8190 + 184);
    }

    // Token : 0x600229F
    // RVA   : 0xFE2CC0   Offset: 0xFE20C0   Length: 0x61
    private void Awake()
    {
        puVar1 = *(uint64 **)(DAT_181da8190 + 184);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x60022A0
    // RVA   : 0xFE3500   Offset: 0xFE2900   Length: 0xF6
    public static float GetPracticeExpRate(KungfuSkillLvData targetSkill)
    {
        float fVar1;
        uint uVar2;
        int iVar3;
        long lVar4;
        int iVar5;
        long lVar6;
        lVar4 = *(int64 *)(*(int64 *)(DAT_181da8190 + 184) + 8);
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
            FUN_1810e36c0(1.0 - (float)(iVar3 - iVar5) * fVar1);
            return;
          }
        }
    }

    // Token : 0x60022A1
    // RVA   : 0xFE3450   Offset: 0xFE2850   Length: 0xAD
    public static int GetMaxSkillSelfStudyLv(KungfuSkillLvData targetSkill)
    {
        var pStatics = *(int64*)(DAT_181d73d40 + 184);
        int iVar1;
        if (targetSkill != null) {
          iVar1 = KungfuSkillLvData.Type(targetSkill,0);
          if (iVar1 < 3) {
            return *(uint32 *)(pStatics + 0x164);
          }
          return *(uint32 *)(pStatics + 0x168);
        }
    }

    // Token : 0x60022A2
    // RVA   : 0xFE42B0   Offset: 0xFE36B0   Length: 0x8AE
    public void StartStudySkill(StudySkillType studySkillType, KungfuSkillLvData target, string _finishCallFuc, AreaBuildingData _targetBuilding, bool _useMoney)
    {
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
        if ((GameController._instance != null) &&
           (lVar5 = GameController._instance.worldData) != null) {
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
            lVar5 = **(int64 **)(DAT_181da8710 + 184);
            plVar7 = (int64 *)FUN_1800d60b0(DAT_181da4120,5);
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
                lVar8 = il2cpp_value_box(DAT_181d80418,local_res18);
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
                    uVar6 = il2cpp_value_box(DAT_181d80418,local_58);
                    lVar8 = this.targetSkill;
                    lVar9 = *(int64 *)(*(int64 *)(DAT_181da8190 + 184) + 8);
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
                         (float)FUN_1810e36c0(1.0 - (float)(iVar3 - iVar4) * fVar12,0,0x3f800000,0);
                    local_res8[0] = local_res8[0] * 100.0;
                    uVar11 = Single.ToString(local_res8,"f0",0);
                    lVar8 = String.Format("\n<i>{2}(因超过{0}级，练习只获取{1}%经验！)</color></i>",uVar6,uVar11,
                                           *(uint64 *)(*(int64 *)(DAT_181d73d40 + 184) + 0x2d8),0)
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
                    uVar11 = il2cpp_value_box(DAT_181d80418,local_58);
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

    // Token : 0x60022A3
    // RVA   : 0xFE4B60   Offset: 0xFE3F60   Length: 0x35E
    public void SureStartStudySkill()
    {
        int iVar1;
        int iVar2;
        uint uVar3;
        long lVar4;
        ulong uVar5;
        if (this.useMoney) {
          if ((GameController._instance == null) ||
             (lVar4 = GameController._instance.worldData) == null)
          throw; // [null/range check failed]
          lVar4 = WorldData.Player(lVar4,0);
          if ((lVar4 == null) || (lVar4.speBookStorageSpeAdd == null)) throw; // [null/range check failed]
          iVar2 = *(int *)(lVar4.speBookStorageSpeAdd + 24);
          if (this.targetSkill == null) throw; // [null/range check failed]
          iVar1 = KungfuSkillLvData.StudyMoneyCost(this.targetSkill,0);
          if (iVar2 < iVar1) {
            lVar4 = FUN_18046c0a0(0);
            if (lVar4 != null) {
              GameController.ShowTextOnMouse(lVar4,"银钱不足！",0);
              plVar6 = (int64 *)Resources.Load("Sound/SoundEffect/WrongClick",0);
              plVar7 = (int64 *)0;
              if ((plVar6 != (int64 *)0) && (*plVar6 == DAT_181daf348)) {
                plVar7 = plVar6;
              }
              NGUITools.PlaySound(plVar7,0);
              return;
            }
            throw; // [null/range check failed]
          }
          lVar4 = FUN_18046c0a0(0);
          if ((lVar4 == null) || (lVar4.villageAreaID == null)) throw; // [null/range check failed]
          lVar4 = WorldData.Player(lVar4.villageAreaID,0);
          if (this.targetSkill == null) throw; // [null/range check failed]
          iVar2 = KungfuSkillLvData.StudyMoneyCost(this.targetSkill,0);
          if (lVar4 == null) throw; // [null/range check failed]
          HeroData.ChangeMoney(lVar4,-iVar2,1,0);
        }
        lVar4 = *(int64 *)(*(int64 *)(DAT_181db5de8 + 184) + 8);
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

    // Token : 0x60022A4
    // RVA   : 0xFE3D70   Offset: 0xFE3170   Length: 0x536
    public void RealStartStudySkill()
    {
        var pStatics = *(int64*)(DAT_181d73d40 + 184);
        long lVar1;
        ulong uVar2;
        long lVar4;
        long lVar5;
        ulong uVar6;
        ulong uVar7;
        float[] local_res18 = new float[2];
        float[] local_res20 = new float[2];
        uint[] local_28 = new uint[4];
        lVar1 = *(int64 *)(*(int64 *)(DAT_181db5de8 + 184) + 8);
        if (lVar1 == null) {
        LAB_180fe41fb:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        if (*(char *)(lVar1 + 96) != false) {
          if ((this.targetPracticeExpData != null) &&
             (0.0 < this.targetPracticeExpData.maxPracticeExp)) {
            lVar1 = **(int64 **)(DAT_181da8710 + 184);
            plVar3 = (int64 *)FUN_1800d60b0(DAT_181da4120,5);
            if ((this.targetSkill != null) &&
               (lVar4 = KungfuSkillLvData.Name(this.targetSkill,1,0),
               plVar3 != (int64 *)0)) {
              if ((lVar4 != null) &&
                 (lVar5 = il2cpp_internal(lVar4,*(uint64 *)(*plVar3 + 64))) == null) {
                uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar6,0);
              }
              if ((int)plVar3[3] == 0) {
                uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar6,0);
              }
              plVar3[4] = lVar4;
              il2cpp_internal(plVar3 + 4,lVar4);
              if (this.targetPracticeExpData != null) {
                lVar4 = Single.ToString(this.targetPracticeExpData + 20,"f0",0);
                if ((lVar4 != null) &&
                   (lVar5 = il2cpp_internal(lVar4,*(uint64 *)(*plVar3 + 64))) == null) {
                  uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar6,0);
                }
                if (*(uint32 *)(plVar3 + 3) < 2) {
                  uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar6,0);
                }
                plVar3[5] = lVar4;
                il2cpp_internal(plVar3 + 5,lVar4);
                local_res18[0] = *(float *)(pStatics + 0x160) * 100.0;
                lVar4 = il2cpp_value_box(DAT_181da22d8,local_res18);
                if ((lVar4 != null) &&
                   (lVar5 = il2cpp_internal(lVar4,*(uint64 *)(*plVar3 + 64))) == null) {
                  uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar6,0);
                }
                if (*(uint32 *)(plVar3 + 3) < 3) {
                  uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar6,0);
                }
                plVar3[6] = lVar4;
                il2cpp_internal(plVar3 + 6,lVar4);
                if (this.targetPracticeExpData != null) {
                  local_res20[0] =
                       *(float *)(pStatics + 0x160) *
                       this.targetPracticeExpData.maxPracticeExp;
                  lVar4 = Single.ToString(local_res20,"f0",0);
                  if ((lVar4 != null) &&
                     (lVar5 = il2cpp_internal(lVar4,*(uint64 *)(*plVar3 + 64))) == null) {
                    uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar6,0);
                  }
                  if (*(uint32 *)(plVar3 + 3) < 4) {
                    uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar6,0);
                  }
                  plVar3[7] = lVar4;
                  il2cpp_internal(plVar3 + 7,lVar4);
                  local_28[0] = StudySkillController.GetAutoPracticeCost(this,0);
                  uVar6 = Int32.ToString(local_28,0);
                  if ((this.targetSkill != null) &&
                     (lVar4 = KungfuSkillLvData.DataBase(this.targetSkill,0),
                     uVar2 = "当前最高纪录：{1}点经验\n是否消耗{4}自动练习{0}？\n可得{2}%({3}点)", lVar4 != null)) {
                    uVar7 = "内力";
                    if (*(int *)(lVar4 + 48) != 0) {
                      uVar7 = "生命";
                    }
                    lVar4 = String.Concat(uVar6,uVar7,0);
                    if ((lVar4 != null) &&
                       (lVar5 = il2cpp_internal(lVar4,*(uint64 *)(*plVar3 + 64))) == null) {
                      uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar6,0);
                    }
                    if (*(uint32 *)(plVar3 + 3) < 5) {
                      uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar6,0);
                    }
                    plVar3[8] = lVar4;
                    il2cpp_internal(plVar3 + 8,lVar4);
                    uVar6 = String.Format(uVar2,plVar3,0);
                    if (lVar1 != null) {
                      SureMenu.CallSureMenu
                                (lVar1,uVar6,"AutoStudySkill",0,"StudySkillController",1,0,"PlayerStudySkill",0,0);
                      return;
                    }
                    goto LAB_180fe41fb;
                  }
                }
              }
            }
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          StudySkillController.PlayerStudySkill(this,0);
        }
    }

    // Token : 0x60022A5
    // RVA   : 0xFE33A0   Offset: 0xFE27A0   Length: 0xA0
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

    // Token : 0x60022A6
    // RVA   : 0xFE2930   Offset: 0xFE1D30   Length: 0x381
    public void AutoStudySkill()
    {
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
            if (lVar4.Areas == null) {
              if ((GameController._instance == null) ||
                 (lVar4 = GameController._instance.worldData) == null)
              throw; // [null/range check failed]
              lVar4 = WorldData.Player(lVar4,0);
              StudySkillController.GetAutoPracticeCost(this,0);
              if (lVar4 == null) throw; // [null/range check failed]
              HeroData.ChangeMana(lVar4);
            }
            else {
              if ((GameController._instance == null) ||
                 (lVar4 = GameController._instance.worldData) == null)
              throw; // [null/range check failed]
              lVar4 = WorldData.Player(lVar4,0);
              StudySkillController.GetAutoPracticeCost(this,0);
              if (lVar4 == null) throw; // [null/range check failed]
              HeroData.ChangeHp(lVar4);
            }
            if (this.finishCallFuc != null) {
              cVar3 = String.op_Inequality(this.finishCallFuc,"",0);
              if (cVar3) {
                lVar4 = FUN_18046c400(0);
                uVar2 = this.finishCallFuc;
                if (this.targetPracticeExpData != null) {
                  fVar1 = this.targetPracticeExpData.maxPracticeExp;
                  local_res8[0] = fVar1 * *(float *)(*(int64 *)(DAT_181d73d40 + 184) + 0x160);
                  uVar5 = Single.ToString(local_res8,0);
                  if (lVar4 != null) {
                    Component.SendMessage(lVar4,uVar2,uVar5,0);
                    goto LAB_180fe2c4b;
                  }
                }
                throw; // [null/range check failed]
              }
            }
        LAB_180fe2c4b:
            plVar6 = (int64 *)Resources.Load("Sound/SoundEffect/SpeEffect/加速旋转",0);
            plVar7 = (int64 *)0;
            if ((plVar6 != (int64 *)0) && (*plVar6 == DAT_181daf348)) {
              plVar7 = plVar6;
            }
            NGUITools.PlaySound(plVar7,0);
            return;
          }
        }
    }

    // Token : 0x60022A7
    // RVA   : 0xFE3650   Offset: 0xFE2A50   Length: 0x713
    public void PlayerStudySkill()
    {
        var pStatics_7f90 = *(int64*)(DAT_181da7f90 + 184);
        var pStatics_8110 = *(int64*)(DAT_181da8110 + 184);
        var pStatics_8290 = *(int64*)(DAT_181da8290 + 184);
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
                 (lVar3 = FUN_180002f80(this.checkDisableObj,plVar4,DAT_181d89918)) == null)
              throw; // [null/range check failed]
              GameObject.SetActive(lVar3,0,0);
              lVar3 = this.checkEnableObj;
              if ((this.checkDisableObj == null) ||
                 (FUN_180002f80(this.checkDisableObj,plVar4,DAT_181d89918), lVar3 == null))
              throw; // [null/range check failed]
              FUN_18181e0a0(lVar3);
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
              if (CloudAnimController._instance != null) {
                CloudAnimController.PlayerCloudAnim(CloudAnimController._instance,0);
                plVar4 = (int64 *)Resources.Load("Sound/SoundEffect/紧张",0);
                if ((plVar4 != (int64 *)0) && (*plVar4 == DAT_181daf348)) {
                  plVar7 = plVar4;
                }
                NGUITools.PlaySound(plVar7,0);
                if (this.targetSkill != null) {
                  iVar2 = KungfuSkillLvData.Type(this.targetSkill,0);
                  if (iVar2 == 0) {
                    lVar3 = BattleController.AttackAreaTypeStartMovePower;
                    uVar5 = Component.get_gameObject(this,0);
                    if (lVar3 != null) {
                      WeatherController.SetWeatherSpeActive(lVar3,0,uVar5,0);
                      if (*pStatics_8110 != 0) {
                        StudyInternalSkillController.StartStudyInternalSkill
                                  (*pStatics_8110,this.targetSkill,0
                                  );
                        if ((((this.comboText == null) ||
                             (lVar3 = Component.get_transform(this.comboText,0),
                             lVar3 == null)) || (lVar3 = FUN_180da9a20(lVar3,0)) == null) ||
                           (lVar3 = Component.get_gameObject(lVar3,0)) == null) throw; // [null/range check failed]
                        GameObject.SetActive(lVar3,0,0);
                        if (((this.expText == null) ||
                            (lVar3 = Component.get_transform(this.expText,0), lVar3 == null
                            )) || ((lVar3 = FUN_180da9a20(lVar3,0), lVar3 == null ||
                                   (lVar3 = Component.get_gameObject(lVar3,0)) == null)))
                        throw; // [null/range check failed]
                        uVar5 = 0;
        LAB_180fe3be4:
                        GameObject.SetActive(lVar3,uVar5,0);
                        return;
                      }
                    }
                  }
                  else {
                    if (iVar2 == 1) {
                      lVar3 = BattleController.AttackAreaTypeStartMovePower;
                      uVar5 = Component.get_gameObject(this,0);
                      if (lVar3 == null) throw; // [null/range check failed]
                      WeatherController.SetWeatherSpeActive(lVar3,0,uVar5,0);
                      lVar3 = *(int64 *)(*(int64 *)(DAT_181da8090 + 184) + 8);
                      if (lVar3 == null) throw; // [null/range check failed]
                      StudyDodgeSkillController.StartStudyDodgeSkill
                                (lVar3,this.targetSkill,0);
                    }
                    else if (iVar2 == 2) {
                      lVar3 = BattleController.AttackAreaTypeStartMovePower;
                      uVar5 = Component.get_gameObject(this,0);
                      if (lVar3 == null) throw; // [null/range check failed]
                      WeatherController.SetWeatherSpeActive(lVar3,0,uVar5,0);
                      if (*pStatics_8290 == 0) throw; // [null/range check failed]
                      StudyUniqueSkillController.StartStudyUniqueSkill
                                (*pStatics_8290,this.targetSkill,0);
                    }
                    else {
                      if (*pStatics_7f90 == 0) throw; // [null/range check failed]
                      StudyAttackSkillController.StartStudyFightSkill
                                (*pStatics_7f90,this.targetSkill,0);
                    }
                    if (((this.comboText != null) &&
                        (lVar3 = Component.get_transform(this.comboText,0)) != null)
                       && (lVar3 = FUN_180da9a20(lVar3,0)) != null) {
                      lVar3 = Component.get_gameObject(lVar3,0);
                      if (lVar3 != null) {
                        GameObject.SetActive(lVar3,1,0);
                        if (((this.expText != null) &&
                            (lVar3 = Component.get_transform(this.expText,0), lVar3 != null
                            )) && (lVar3 = FUN_180da9a20(lVar3,0)) != null) {
                          lVar3 = Component.get_gameObject(lVar3,0);
                          if (lVar3 != null) {
                            uVar5 = 1;
                            goto LAB_180fe3be4;
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

    // Token : 0x60022A8
    // RVA   : 0xFE2D30   Offset: 0xFE2130   Length: 0x667
    public void FinishStudySkill(float expNum)
    {
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
              FUN_1812f9a10(lVar3,DAT_181d89418);
              lVar3 = *(int64 *)(*(int64 *)(DAT_181db4f18 + 184) + 8);
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
              if ((GameController._instance == null) ||
                 (lVar3 = GameController._instance.worldData) == null) break;
              lVar3 = WorldData.Player(lVar3,0);
              if ((GameController._instance == null) ||
                 (lVar6 = GameController._instance.worldData) == null) break;
              lVar6 = WorldData.Player(lVar6,0);
              if ((lVar6 == null) ||
                 (uVar7 = Mathf.Max(0x3f800000,lVar6.skinUnlockData,0), lVar3 == null)) break;
              lVar3.skinUnlockData = uVar7;
              lVar3 = this.targetPracticeExpData;
              if (lVar3 == null) {
                if (this.targetSkill == null) break;
                uVar7 = this.targetSkill.skillID;
                this.targetPracticeExpData = new SkillMaxPracticeExpData(uVar7,0);
                if (this.targetPracticeExpData == null) break;
                this.targetPracticeExpData.maxPracticeExp = local_res10[0];
                if (((GameController._instance == null) ||
                    (lVar3 = GameController._instance.worldData) == null) ||
                   (lVar3 = WorldData.Player(lVar3,0)) == null) break;
                HeroData.AddSkillMaxPracticeExp(lVar3,this.targetPracticeExpData,0);
        LAB_180fe31d4:
                lVar3 = **(int64 **)(DAT_181d7f6a8 + 184);
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
                goto LAB_180fe31d4;
              }
              if ((this.finishCallFuc != null) &&
                 (cVar1 = String.op_Inequality(this.finishCallFuc,"",0),
                 cVar1)) {
                uVar2 = this.finishCallFuc;
                lVar3 = *(int64 *)(*(int64 *)(DAT_181d91b88 + 184) + 24);
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

    // Token : 0x60022A9
    // RVA   : 0xFE3600   Offset: 0xFE2A00   Length: 0x48
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

    // Token : 0x60022AA
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

    // Token : 0x60022AB
    // RVA   : 0xFE4EC0   Offset: 0xFE42C0   Length: 0x11E
    private static void /*cctor*/()
    {
        long lVar1;
        lVar1 = il2cpp_internal(DAT_181d96ed0);
        FUN_18132faf0(lVar1,DAT_181da0cf8);
        if (lVar1 != null) {
          FUN_18181de10(lVar1,0x3d4ccccd,DAT_181da0df8);
          FUN_18181de10(lVar1,0x3dcccccd,DAT_181da0df8);
          FUN_18181de10(lVar1,0x3e4ccccd,DAT_181da0df8);
          FUN_18181de10(lVar1,0x3e99999a,DAT_181da0df8);
          FUN_18181de10(lVar1,0x3ecccccd,DAT_181da0df8);
          FUN_18181de10(lVar1,0x3f000000,DAT_181da0df8);
          plVar2 = (int64 *)(*(int64 *)(DAT_181da8190 + 184) + 8);
          *plVar2 = lVar1;
          il2cpp_internal(plVar2,lVar1);
          return;
        }
    }

}
