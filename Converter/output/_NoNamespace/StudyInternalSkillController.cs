// ============================================================
// Type  : StudyInternalSkillController
// Token : 0x200038A
// ============================================================

public class StudyInternalSkillController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001CF1
    public bool inStudy;

    // Token: 0x4001CF2
    public float totalExp;

    // Token: 0x4001CF3
    public int internalPointFinished;

    // Token: 0x4001CF4
    public KungfuSkillLvData targetSkill;

    // Token: 0x4001CF5
    public GameObject pointUIPrefab;

    // Token: 0x4001CF6
    public GameObject pointHighLightPrefab;

    // Token: 0x4001CF7
    public GameObject lineRendererPrefab;

    // Token: 0x4001CF8
    public GameObject studyInternalSkillRoot;

    // Token: 0x4001CF9
    public GameObject studyInternalSkillObjRoot;

    // Token: 0x4001CFA
    public GameObject studyInternalSkillUIRoot;

    // Token: 0x4001CFB
    public GameObject internalUI;

    // Token: 0x4001CFC
    public GameObject internalPercentUI;

    // Token: 0x4001CFD
    public Button finishButton;

    // Token: 0x4001CFE
    public GameObject startPoint;

    // Token: 0x4001CFF
    public bool crashing;

    // Token: 0x4001D00
    public bool waitChoosing;

    // Token: 0x4001D01
    public GameObject crashingPoint;

    // Token: 0x4001D02
    public float nextCrashTime;

    // Token: 0x4001D03
    private float manaCost;

    // Token: 0x4001D04
    private float crashTimeSpan;

    // Token: 0x4001D05
    public GameObject studyInternalPointPrefab;

    // Token: 0x4001D06
    public int mapWidth;

    // Token: 0x4001D07
    public int mapHeight;

    // Token: 0x4001D08
    public GameObject[] gridUnits;

    // Token: 0x4001D09
    public List<GameObject> gridPool;

    // Token: 0x4001D0A
    public const int LittleSuccessPointNum;

    // Token: 0x4001D0B
    public const int BigSuccessPointNum;

    // Token: 0x4001D0C
    public int leftAutoCrashPoint;

    // Token: 0x4001D0D
    private GameObject newObj;

    // Token: 0x4001D0E
    private bool inited;

    // Token: 0x4001D0F
    private static StudyInternalSkillController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002286
    // RVA   : 0xFE28F0   Offset: 0xFE1CF0   Length: 0x36
    public static StudyInternalSkillController get_Instance()
    {
        return **(uint64 **)(DAT_181da8110 + 184);
    }

    // Token : 0x6002287
    // RVA   : 0xFDF250   Offset: 0xFDE650   Length: 0x43
    private void Awake()
    {
        puVar1 = *(uint64 **)(DAT_181da8110 + 184);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x6002288
    // RVA   : 0xFE1FF0   Offset: 0xFE13F0   Length: 0x8D9
    private void Update()
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        long lVar5;
        bool cVar9;
        uint uVar10;
        float fVar11;
        uint uVar12;
        uint uVar13;
        uint uVar14;
        float fVar15;
        ulong local_38;
        ulong uStack_30;
        cVar9 = false;
        if (this.inStudy) {
          if (this.studyInternalSkillUIRoot == null) throw; // [null/range check failed]
          lVar2 = GameObject.get_transform(this.studyInternalSkillUIRoot,0);
          if (lVar2 == null) throw; // [null/range check failed]
          lVar2 = Transform.Find(lVar2,"Exp",0);
          if (lVar2 == null) throw; // [null/range check failed]
          uVar3 = Component.GetComponent(lVar2,DAT_181d96160);
          uVar4 = Single.ToString(this + 28,"f0",0);
          uVar4 = String.Concat("经验 ",uVar4,0);
          LTLocalization.SetText(uVar3,uVar4,0);
          if (this.internalUI == null) throw; // [null/range check failed]
          lVar2 = GameObject.get_transform(this.internalUI,0);
          if (lVar2 == null) throw; // [null/range check failed]
          lVar2 = Transform.Find(lVar2,"InternalBar",0);
          if (lVar2 == null) throw; // [null/range check failed]
          lVar2 = Component.GetComponent(lVar2,DAT_181d94460);
          if ((GameController._instance == null) ||
             (lVar5 = GameController._instance.worldData) == null)
          throw; // [null/range check failed]
          lVar5 = WorldData.Player(lVar5,0);
          if (lVar5 == null) throw; // [null/range check failed]
          if ((GameController._instance == null) ||
             (lVar5 = GameController._instance.worldData) == null)
          throw; // [null/range check failed]
          lVar5 = WorldData.Player(lVar5,0);
          if ((lVar5 == null) || (lVar2 == null)) throw; // [null/range check failed]
          Image.set_fillAmount(lVar2);
          if (this.internalUI == null) throw; // [null/range check failed]
          lVar2 = GameObject.get_transform(this.internalUI,0);
          if (lVar2 == null) throw; // [null/range check failed]
          lVar2 = Transform.Find(lVar2,"InternalInjuryBar",0);
          if (lVar2 == null) throw; // [null/range check failed]
          lVar2 = Component.GetComponent(lVar2,DAT_181d94460);
          if ((GameController._instance == null) ||
             (lVar5 = GameController._instance.worldData) == null)
          throw; // [null/range check failed]
          lVar5 = WorldData.Player(lVar5,0);
          if (lVar5 == null) throw; // [null/range check failed]
          fVar15 = lVar5.totalBadFame;
          if ((GameController._instance == null) ||
             (lVar5 = GameController._instance.worldData) == null)
          throw; // [null/range check failed]
          lVar5 = WorldData.Player(lVar5,0);
          if ((lVar5 == null) || (lVar2 == null)) throw; // [null/range check failed]
          Image.set_fillAmount(lVar2,1.0 - fVar15 / lVar5.totalEnemyKilled,0);
          if (this.internalUI == null) throw; // [null/range check failed]
          lVar2 = GameObject.get_transform(this.internalUI,0);
          if (lVar2 == null) throw; // [null/range check failed]
          lVar2 = Transform.Find(lVar2,"InternalNum",0);
          if (lVar2 == null) throw; // [null/range check failed]
          uVar3 = Component.GetComponent(lVar2,DAT_181d96160);
          if ((GameController._instance == null) ||
             (lVar2 = GameController._instance.worldData) == null)
          throw; // [null/range check failed]
          lVar2 = WorldData.Player(lVar2,0);
          if (lVar2 == null) throw; // [null/range check failed]
          uVar4 = Single.ToString(lVar2 + 400,"f0",0);
          LTLocalization.SetText(uVar3,uVar4,0);
          if (this.internalPercentUI == null) throw; // [null/range check failed]
          lVar2 = GameObject.get_transform(this.internalPercentUI,0);
          if (lVar2 == null) throw; // [null/range check failed]
          lVar2 = Transform.Find(lVar2,"Bar",0);
          if (lVar2 == null) throw; // [null/range check failed]
          lVar2 = Component.GetComponent(lVar2,DAT_181d94460);
          if (lVar2 == null) throw; // [null/range check failed]
          Image.set_fillAmount(lVar2,(float)this.internalPointFinished / 18.0,0);
          if (this.internalPercentUI == null) throw; // [null/range check failed]
          lVar2 = GameObject.get_transform(this.internalPercentUI,0);
          if (lVar2 == null) throw; // [null/range check failed]
          lVar2 = Transform.Find(lVar2,"LittleSuccess",0);
          if (lVar2 == null) throw; // [null/range check failed]
          plVar6 = (int64 *)Component.GetComponent(lVar2,DAT_181d96160);
          if (this.internalPointFinished < 9) {
            puVar7 = (uint32 *)FUN_1810d33f0(&local_38,0);
            uVar10 = *puVar7;
            uVar12 = puVar7[1];
            uVar13 = puVar7[2];
            uVar14 = puVar7[3];
          }
          else {
            local_38 = 0;
            uStack_30 = 0;
            Color.ctor();
            uVar10 = (uint32)local_38;
            uVar12 = local_38._4_4_;
            uVar13 = (uint32)uStack_30;
            uVar14 = uStack_30._4_4_;
          }
          if (plVar6 == (int64 *)0) throw; // [null/range check failed]
          local_38 = CONCAT44(uVar12,uVar10);
          uStack_30 = CONCAT44(uVar14,uVar13);
          (**(code **)(*plVar6 + 0x2a8))(plVar6,&local_38,*(uint64 *)(*plVar6 + 0x2b0));
          if (this.internalPercentUI == null) throw; // [null/range check failed]
          lVar2 = GameObject.get_transform(this.internalPercentUI,0);
          if (lVar2 == null) throw; // [null/range check failed]
          lVar2 = Transform.Find(lVar2,"BigSuccess",0);
          if (lVar2 == null) throw; // [null/range check failed]
          plVar6 = (int64 *)Component.GetComponent(lVar2,DAT_181d96160);
          if (this.internalPointFinished < 18) {
            puVar8 = (uint64 *)FUN_1810d33f0(&local_38,0);
          }
          else {
            puVar8 = (uint64 *)Color.get_red();
          }
          if (plVar6 == (int64 *)0) throw; // [null/range check failed]
          local_38 = *puVar8;
          uStack_30 = puVar8[1];
          (**(code **)(*plVar6 + 0x2a8))(plVar6,&local_38,*(uint64 *)(*plVar6 + 0x2b0));
          if (this.crashing) {
            uVar3 = this.crashingPoint;
            cVar1 = Object.op_Inequality(uVar3,0,0);
            if (cVar1) {
              fVar15 = this.nextCrashTime;
              fVar11 = (float)Time.get_deltaTime(0);
              fVar15 = fVar15 - fVar11;
              this.nextCrashTime = fVar15;
              if (fVar15 <= 0.0) {
                this.nextCrashTime = this.crashTimeSpan;
                if (this.crashingPoint == null) throw; // [null/range check failed]
                lVar2 = GameObject.GetComponent(this.crashingPoint,DAT_181d73e60);
                if (lVar2 == null) throw; // [null/range check failed]
                if (1.0 <= lVar2.villageAreaID) {
                  if (this.crashingPoint == null) throw; // [null/range check failed]
                  lVar2 = GameObject.GetComponent(this.crashingPoint,DAT_181d73e60);
                  if (lVar2 == null) throw; // [null/range check failed]
                  StudyInternalPointController.FinishCrash(lVar2,0);
                }
                else {
                  lVar2 = FUN_18046c0a0(0);
                  if ((lVar2 == null) || (lVar2.villageAreaID == null)) throw; // [null/range check failed]
                  lVar2 = WorldData.Player(lVar2.villageAreaID,0);
                  if (lVar2 == null) throw; // [null/range check failed]
                  if (lVar2.totalWinFightCount <= 0.0) {
                    uVar3 = StudyInternalSkillController.FinishStudyInternalSkill(this,0,0);
                    FUN_180d8c2e0(this,uVar3,0);
                  }
                  else {
                    StudyInternalSkillController.ChangeMana();
                    if (this.crashingPoint == null) throw; // [null/range check failed]
                    lVar2 = GameObject.GetComponent(this.crashingPoint,DAT_181d73e60);
                    if (lVar2 == null) throw; // [null/range check failed]
                    StudyInternalPointController.TryCrash(lVar2,0);
                  }
                }
              }
            }
          }
        }
        if ((!this.crashing) && (this.inStudy)) {
          cVar9 = this.waitChoosing;
        }
        if (this.finishButton != null) {
          Selectable.set_interactable(this.finishButton,cVar9,0);
          return;
        }
    }

    // Token : 0x6002289
    // RVA   : 0xFDF2A0   Offset: 0xFDE6A0   Length: 0x261
    public void ChangeMana(float changeNum)
    {
        ulong uVar1;
        uint uVar2;
        long lVar3;
        ulong uVar4;
        long lVar5;
        uint[] local_res10 = new uint[2];
        ulong in_stack_ffffffffffffffa8;
        ulong local_48;
        uint local_40;
        ulong local_38;
        ulong uStack_30;
        uint local_28;
        uint uStack_24;
        uint uStack_20;
        uint32 uStack_1c;
        local_res10[0] = changeNum;
        if ((GameController._instance != null) &&
           (lVar3 = GameController._instance.worldData) != null) {
          lVar3 = WorldData.Player(lVar3,0);
          if (lVar3 != null) {
            HeroData.ChangeMana
                      (lVar3,local_res10[0],1,1,in_stack_ffffffffffffffa8 & 0xffffffffffffff00,0);
            lVar3 = GameController._instance;
            uVar4 = Single.ToString(local_res10,"+0.#;-0.#;0",0);
            if (this.internalUI != null) {
              lVar5 = GameObject.get_transform(this.internalUI,0);
              if (lVar5 != null) {
                lVar5 = Transform.Find(lVar5,"InternalBar",0);
                if (lVar5 != null) {
                  puVar6 = (uint64 *)Transform.get_localPosition(&local_48,lVar5,0);
                  uVar1 = *puVar6;
                  uVar2 = *(uint32 *)(puVar6 + 1);
                  local_38 = 0;
                  uStack_30 = 0;
                  Color.ctor(&local_38,0x3f000000,0x3f800000,0x3f800000,0);
                  if (lVar3 != null) {
                    local_28 = (uint32)local_38;
                    uStack_24 = local_38._4_4_;
                    uStack_20 = (uint32)uStack_30;
                    uStack_1c = uStack_30._4_4_;
                    local_48 = uVar1;
                    local_40 = uVar2;
                    GameController.ShowTextAtPos(lVar3,uVar4,&local_48,22,&local_28,0);
                    return;
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x600228A
    // RVA   : 0xFE1280   Offset: 0xFE0680   Length: 0x377
    public void Init()
    {
        long lVar2;
        ulong uVar3;
        ulong uVar5;
        int iVar6;
        long lVar7;
        long lVar8;
        int iVar9;
        int[] local_res8 = new int[2];
        int[] local_res18 = new int[4];
        float local_78;
        float local_74;
        uint local_70;
        ulong local_68;
        uint local_60;
        ulong local_58;
        ulong local_50;
        this.inited = 1;
        local_58 = 11;
        local_50 = 11;
        lVar2 = FUN_1800d6020(DAT_181da99e0,&local_58);
        this.gridUnits = lVar2;
        uVar3 = il2cpp_internal(DAT_181d92f58);
        FUN_18132faf0(uVar3,DAT_181d89298);
        this.gridPool = uVar3;
        iVar9 = 0;
        do {
          iVar6 = 0;
          do {
            lVar2 = *plVar1;
            uVar3 = this.studyInternalSkillObjRoot;
            uVar5 = this.studyInternalPointPrefab;
            uVar3 = GlobalData.AddChild(uVar3,uVar5,0);
            if (lVar2 == null) {
        LAB_180fe15f2:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar8 = (int64)iVar9;
            lVar7 = (int64)iVar6;
            FUN_180128020(lVar2,lVar7,lVar8,uVar3);
            if (*plVar1 == 0) goto LAB_180fe15f2;
            lVar2 = FUN_180127f90(*plVar1,lVar7,lVar8);
            if (lVar2 == null) goto LAB_180fe15f2;
            lVar2 = GameObject.get_transform(lVar2,0);
            puVar4 = (uint64 *)Vector3.get_one(&local_58,0);
            if (lVar2 == null) goto LAB_180fe15f2;
            local_60 = *(uint32 *)(puVar4 + 1);
            local_68 = *puVar4;
            Transform.set_localScale(lVar2,&local_68,0);
            if (*plVar1 == 0) goto LAB_180fe15f2;
            lVar2 = FUN_180127f90(*plVar1,lVar7,lVar8);
            if (lVar2 == null) goto LAB_180fe15f2;
            lVar2 = GameObject.get_transform(lVar2,0);
            if (lVar2 == null) goto LAB_180fe15f2;
            local_70 = 0;
            local_78 = (float)iVar6 * 0.85;
            local_74 = (float)iVar9 * 0.85;
            Transform.set_localPosition(lVar2,&local_78,0);
            if (*plVar1 == 0) goto LAB_180fe15f2;
            lVar2 = FUN_180127f90(*plVar1,lVar7,lVar8);
            local_res8[0] = iVar9;
            uVar3 = il2cpp_value_box(DAT_181d80418,local_res8);
            local_res18[0] = iVar6;
            uVar5 = il2cpp_value_box(DAT_181d80418,local_res18);
            uVar3 = String.Format("{0}_{1}",uVar3,uVar5,0);
            if (lVar2 == null) goto LAB_180fe15f2;
            Object.set_name(lVar2,uVar3,0);
            if (*plVar1 == 0) goto LAB_180fe15f2;
            lVar2 = FUN_180127f90(*plVar1,lVar7,lVar8);
            if (lVar2 == null) goto LAB_180fe15f2;
            GameObject.SetActive(lVar2,0,0);
            if (*plVar1 == 0) goto LAB_180fe15f2;
            lVar2 = FUN_180127f90(*plVar1,lVar7,lVar8);
            if (lVar2 == null) goto LAB_180fe15f2;
            lVar2 = GameObject.GetComponent(lVar2,DAT_181d73e60);
            if (lVar2 == null) goto LAB_180fe15f2;
            *(int *)(lVar2 + 60) = iVar6;
            if (*plVar1 == 0) goto LAB_180fe15f2;
            lVar2 = FUN_180127f90(*plVar1,lVar7);
            if (lVar2 == null) goto LAB_180fe15f2;
            lVar2 = GameObject.GetComponent(lVar2,DAT_181d73e60);
            if (lVar2 == null) goto LAB_180fe15f2;
            iVar6 = iVar6 + 1;
            *(int *)(lVar2 + 64) = iVar9;
          } while (iVar6 < 11);
          iVar9 = iVar9 + 1;
          if (10 < iVar9) {
            return;
          }
        } while( true );
    }

    // Token : 0x600228B
    // RVA   : 0xFE1130   Offset: 0xFE0530   Length: 0xF1
    public GameObject GetPointDirection(int row, int column, int direction)
    {
        uint64
        StudyInternalSkillController.GetPointDirection
                (int64 this,int row,int column,int direction)
        {
        uint64 uVar1;
        if (direction == null) {
          column = column + -1;
          if (row < 0) {
            return 0;
          }
          if (this.mapHeight <= row) {
            return 0;
          }
          if (column < 0) {
            return 0;
          }
          if (this.mapWidth <= column) {
            return 0;
          }
          if (this.gridUnits != null) {
            uVar1 = FUN_180127f90(this.gridUnits,(int64)column,(int64)row);
            return uVar1;
          }
        }
        else if (direction == 1) {
          column = column + 1;
          if (row < 0) {
            return 0;
          }
          if (this.mapHeight <= row) {
            return 0;
          }
          if (column < 0) {
            return 0;
          }
          if (this.mapWidth <= column) {
            return 0;
          }
          if (this.gridUnits != null) {
            uVar1 = FUN_180127f90(this.gridUnits,(int64)column,(int64)row);
            return uVar1;
          }
        }
        else {
          if (direction == 2) {
            row = row + -1;
          }
          else {
            if (direction != 3) {
              return 0;
            }
            row = row + 1;
          }
          if ((((row < 0) || (this.mapHeight <= row)) || (column < 0)) ||
             (this.mapWidth <= column)) {
            return 0;
          }
          if (this.gridUnits != null) {
            uVar1 = FUN_180127f90(this.gridUnits,(int64)column,(int64)row);
            return uVar1;
          }
        }
    }

    // Token : 0x600228C
    // RVA   : 0xFE1230   Offset: 0xFE0630   Length: 0x47
    public GameObject GetPoint(int row, int column)
    {
        ulong uVar1;
        if ((((-1 < row) && (row < this.mapHeight)) && (-1 < column)) &&
           (column < this.mapWidth)) {
          if (this.gridUnits != null) {
            uVar1 = FUN_180127f90(this.gridUnits,(int64)column,(int64)row);
            return uVar1;
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        return 0;
    }

    // Token : 0x600228D
    // RVA   : 0xFE1D80   Offset: 0xFE1180   Length: 0x261
    public void StartStudyInternalSkill(KungfuSkillLvData target)
    {
        int iVar1;
        long lVar2;
        ulong uVar4;
        ulong uVar5;
        uint uVar6;
        ulong local_38;
        uint local_30;
        byte[] local_28 = new byte[32];
        if (!this.inited) {
          StudyInternalSkillController.Init(this,0);
        }
        if (this.studyInternalSkillRoot != null) {
          GameObject.SetActive(this.studyInternalSkillRoot,1,0);
          this.inStudy = 1;
          this.targetSkill = target;
          if (this.studyInternalSkillObjRoot != null) {
            lVar2 = GameObject.get_transform(this.studyInternalSkillObjRoot,0);
            puVar3 = (uint64 *)Vector3.get_zero(local_28,0);
            if (lVar2 != null) {
              local_30 = *(uint32 *)(puVar3 + 1);
              local_38 = *puVar3;
              Transform.set_localScale(lVar2,&local_38,0);
              if (this.studyInternalSkillObjRoot != null) {
                uVar4 = GameObject.get_transform(this.studyInternalSkillObjRoot,0);
                uVar4 = ShortcutExtensions.DOScale(uVar4);
                uVar4 = TweenSettingsExtensions.SetEase(uVar4,8,DAT_181dc0f80);
                uVar5 = new OnTooltipCB(this,DAT_181db7090,0);
                uVar4 = TweenSettingsExtensions.OnComplete(uVar4,uVar5,DAT_181dc01d0);
                TweenSettingsExtensions.SetUpdate(uVar4,1,DAT_181dc1db0);
                this.totalExp = 0;
                if (this.targetSkill != null) {
                  lVar2 = KungfuSkillLvData.DataBase(this.targetSkill,0);
                  if (lVar2 != null) {
                    uVar6 = Mathf.Max();
                    this.manaCost = uVar6;
                    if (this.targetSkill != null) {
                      lVar2 = KungfuSkillLvData.DataBase(this.targetSkill,0);
                      if (lVar2 != null) {
                        iVar1 = Mathf.FloorToInt((float)*(int *)(lVar2 + 52) * 0.5,0);
                        this.mapWidth = iVar1 * 2 + 7;
                        if (this.targetSkill != null) {
                          lVar2 = KungfuSkillLvData.DataBase(this.targetSkill,0);
                          if (lVar2 != null) {
                            iVar1 = Mathf.FloorToInt((float)*(int *)(lVar2 + 52) * 0.5,0);
                            this.mapHeight = iVar1 * 2 + 7;
                            StudyInternalSkillController.GenerateStudyInternalPanel(this,0);
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

    // Token : 0x600228E
    // RVA   : 0xFDF760   Offset: 0xFDEB60   Length: 0x19CA
    public void GenerateStudyInternalPanel()
    {
        var pStatics = *(int64*)(DAT_181d73d40 + 184);
        uint uVar1;
        ulong uVar2;
        bool cVar3;
        uint uVar4;
        long lVar5;
        long lVar6;
        long lVar7;
        ulong uVar9;
        long lVar10;
        long lVar11;
        int iVar12;
        int iVar13;
        int iVar14;
        uint uVar15;
        float fVar17;
        int local_res8;
        ulong local_78;
        uint local_70;
        long local_68;
        long local_60;
        if (this.studyInternalSkillObjRoot != null) {
          lVar5 = GameObject.get_transform(this.studyInternalSkillObjRoot,0);
          if (lVar5 != null) {
            local_70 = 0;
            local_78 = CONCAT44((float)(this.mapHeight + -1) * -0.5 * 0.85,
                                (float)(this.mapWidth + -1) * -0.5 * 0.85);
            Transform.set_localPosition(lVar5,&local_78,0);
            lVar5 = il2cpp_internal(DAT_181d93cd0);
            FUN_18132faf0(lVar5,DAT_181d8f098);
            iVar12 = 0;
            while( true ) {
              lVar6 = *(int64 *)(pStatics + 0x550);
              if (lVar6 == null) throw; // [null/range check failed]
              if (*(int *)(lVar6 + 24) <= iVar12) break;
              if (lVar5 == null) throw; // [null/range check failed]
              FUN_18182a0b0(lVar5,iVar12);
              iVar12 = iVar12 + 1;
            }
            iVar12 = 0;
            if (0 < this.mapHeight) {
              do {
                iVar14 = 0;
                if (0 < this.mapWidth) {
                  do {
                    if (((this.gridUnits == null) ||
                        (lVar6 = FUN_180127f90(this.gridUnits,(int64)iVar14,
                                               (int64)iVar12), lVar6 == null)) ||
                       (lVar7 = FUN_180f92a00(lVar6,0)) == null) throw; // [null/range check failed]
                    GameObject.SetActive(lVar7,1,0);
                    lVar7 = GameObject.get_transform(lVar6,0);
                    puVar8 = (uint64 *)Vector3.get_zero(&local_68,0);
                    if (lVar7 == null) throw; // [null/range check failed]
                    local_70 = *(uint32 *)(puVar8 + 1);
                    local_78 = *puVar8;
                    Transform.set_localScale(lVar7,&local_78,0);
                    lVar7 = GameObject.GetComponent(lVar6,DAT_181d73e60);
                    if ((lVar7 == null) || (*(int64 *)(lVar7 + 104) == 0)) throw; // [null/range check failed]
                    FUN_1812f9a10(*(int64 *)(lVar7 + 104),DAT_181d89418);
                    lVar7 = GameObject.GetComponent(lVar6,DAT_181d73e60);
                    if (lVar7 == null) throw; // [null/range check failed]
                    StudyInternalPointController.ResetLineRenderer(lVar7,0);
                    lVar7 = GameObject.GetComponent(lVar6,DAT_181d73e60);
                    if (lVar7 == null) throw; // [null/range check failed]
                    *(uint32 *)(lVar7 + 52) = 0;
                    if (this.gridPool == null) throw; // [null/range check failed]
                    FUN_18181e0a0(this.gridPool,lVar6,DAT_181d89398);
                    lVar7 = GameObject.GetComponent(lVar6,DAT_181d73e60);
                    if ((this.gridPool == null) || (lVar7 == null)) throw; // [null/range check failed]
                    *(int *)(lVar7 + 68) = this.gridPool.Count + -1;
                    if (((float)iVar12 == (float)(this.mapHeight + -1) * 0.5) &&
                       ((float)iVar14 == (float)(this.mapWidth + -1) * 0.5)) {
                      this.startPoint = lVar6;
                      lVar6 = GameObject.GetComponent(lVar6,DAT_181d73e60);
                      if (lVar6 == null) throw; // [null/range check failed]
                      *(uint64 *)(lVar6 + 24) = "气海";
                    }
                    else {
                      if (lVar5 == null) throw; // [null/range check failed]
                      uVar4 = FUN_180d95a30(0,lVar5.Count,0);
                      uVar4 = FUN_1800d6760(lVar5,uVar4,DAT_181d8fa18);
                      lVar6 = GameObject.GetComponent(lVar6,DAT_181d73e60);
                      lVar7 = *(int64 *)(pStatics + 0x550);
                      if ((lVar7 == null) || (uVar9 = FUN_180002f80(lVar7,uVar4,DAT_181da4358), lVar6 == null))
                      throw; // [null/range check failed]
                      *(uint64 *)(lVar6 + 24) = uVar9;
                      FUN_1817eee00(lVar5,uVar4,DAT_181d8f618);
                    }
                    iVar14 = iVar14 + 1;
                  } while (iVar14 < this.mapWidth);
                }
                iVar12 = iVar12 + 1;
              } while (iVar12 < this.mapHeight);
              iVar12 = 0;
              if (0 < this.mapHeight) {
                do {
                  iVar14 = this.mapWidth;
                  iVar13 = 0;
                  if (0 < iVar14) {
                    do {
                      if (0 < iVar13) {
                        if (this.gridUnits == null) throw; // [null/range check failed]
                        lVar5 = FUN_180127f90(this.gridUnits,(int64)iVar13,
                                              (int64)iVar12);
                        if ((lVar5 == null) ||
                           (lVar5 = GameObject.GetComponent(lVar5,DAT_181d73e60)) == null)
                        throw; // [null/range check failed]
                        lVar5 = *(int64 *)(lVar5 + 104);
                        if ((this.gridUnits == null) ||
                           (uVar9 = FUN_180127f90(this.gridUnits,(int64)(iVar13 + -1),
                                                  (int64)iVar12), lVar5 == null)) throw; // [null/range check failed]
                        FUN_18181e0a0(lVar5,uVar9,DAT_181d89398);
                        iVar14 = this.mapWidth;
                      }
                      lVar5 = (int64)iVar12;
                      if (iVar13 < iVar14 + -1) {
                        if (((this.gridUnits == null) ||
                            (lVar6 = FUN_180127f90(this.gridUnits,(int64)iVar13,lVar5),
                            lVar6 == null)) ||
                           (lVar6 = GameObject.GetComponent(lVar6,DAT_181d73e60)) == null)
                        throw; // [null/range check failed]
                        lVar6 = *(int64 *)(lVar6 + 104);
                        if ((this.gridUnits == null) ||
                           (uVar9 = FUN_180127f90(this.gridUnits,(int64)(iVar13 + 1),
                                                  lVar5), lVar6 == null)) throw; // [null/range check failed]
                        FUN_18181e0a0(lVar6,uVar9,DAT_181d89398);
                      }
                      if (0 < iVar12) {
                        if (this.gridUnits == null) throw; // [null/range check failed]
                        lVar6 = FUN_180127f90(this.gridUnits,(int64)iVar13,lVar5);
                        if ((lVar6 == null) ||
                           (lVar6 = GameObject.GetComponent(lVar6,DAT_181d73e60)) == null)
                        throw; // [null/range check failed]
                        lVar6 = *(int64 *)(lVar6 + 104);
                        if ((this.gridUnits == null) ||
                           (uVar9 = FUN_180127f90(this.gridUnits,(int64)iVar13,
                                                  (int64)(iVar12 + -1)), lVar6 == null))
                        throw; // [null/range check failed]
                        FUN_18181e0a0(lVar6,uVar9,DAT_181d89398);
                      }
                      if (iVar12 < this.mapHeight + -1) {
                        if (((this.gridUnits == null) ||
                            (lVar5 = FUN_180127f90(this.gridUnits,(int64)iVar13,lVar5),
                            lVar5 == null)) ||
                           (lVar5 = GameObject.GetComponent(lVar5,DAT_181d73e60)) == null)
                        throw; // [null/range check failed]
                        lVar5 = *(int64 *)(lVar5 + 104);
                        if ((this.gridUnits == null) ||
                           (uVar9 = FUN_180127f90(this.gridUnits,(int64)iVar13,
                                                  (int64)(iVar12 + 1)), lVar5 == null))
                        throw; // [null/range check failed]
                        FUN_18181e0a0(lVar5,uVar9,DAT_181d89398);
                      }
                      iVar14 = this.mapWidth;
                      iVar13 = iVar13 + 1;
                    } while (iVar13 < iVar14);
                  }
                  iVar12 = iVar12 + 1;
                } while (iVar12 < this.mapHeight);
              }
            }
            lVar5 = this.startPoint;
            uVar15 = 0;
            if (lVar5 == null) throw; // [null/range check failed]
            lVar6 = 32;
            while( true ) {
              lVar5 = GameObject.GetComponent(lVar5,DAT_181d73e60);
              if ((lVar5 == null) || (*(int64 *)(lVar5 + 104) == 0)) throw; // [null/range check failed]
              if (*(int *)(*(int64 *)(lVar5 + 104) + 24) <= (int)uVar15) break;
              if (((this.startPoint == null) ||
                  (lVar5 = GameObject.GetComponent(this.startPoint,DAT_181d73e60),
                  lVar5 == null)) || (lVar5 = *(int64 *)(lVar5 + 104)) == null) throw; // [null/range check failed]
              if (lVar5.Count <= uVar15) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar5 = *(int64 *)(lVar6 + lVar5._items);
              if ((lVar5 == null) || (lVar7 = GameObject.GetComponent(lVar5,DAT_181d73e60)) == null)
              throw; // [null/range check failed]
              iVar12 = *(int *)(lVar7 + 60);
              if ((this.startPoint == null) ||
                 (lVar7 = GameObject.GetComponent(this.startPoint,DAT_181d73e60),
                 lVar7 == null)) throw; // [null/range check failed]
              if (iVar12 == *(int *)(lVar7 + 60)) {
                lVar10 = GameObject.GetComponent(lVar5,DAT_181d73e60);
                lVar7 = this.gridUnits;
                lVar11 = GameObject.GetComponent(lVar5,DAT_181d73e60);
                if (lVar11 == null) throw; // [null/range check failed]
                iVar12 = *(int *)(lVar11 + 60);
                lVar11 = GameObject.GetComponent(lVar5,DAT_181d73e60);
                if (((lVar11 == null) || (lVar7 == null)) ||
                   (uVar9 = FUN_180127f90(lVar7,(int64)(iVar12 + 1),(int64)*(int *)(lVar11 + 64)),
                   lVar10 == null)) throw; // [null/range check failed]
                StudyInternalPointController.RemoveConnect(lVar10,uVar9,0);
                lVar10 = GameObject.GetComponent(lVar5,DAT_181d73e60);
                lVar7 = this.gridUnits;
                lVar11 = GameObject.GetComponent(lVar5,DAT_181d73e60);
                if (lVar11 == null) throw; // [null/range check failed]
                iVar12 = *(int *)(lVar11 + 60);
                lVar5 = GameObject.GetComponent(lVar5,DAT_181d73e60);
                if ((lVar5 == null) || (lVar7 == null)) throw; // [null/range check failed]
                iVar12 = iVar12 + -1;
        LAB_180fe0234:
                uVar9 = FUN_180127f90(lVar7,(int64)iVar12);
                if (lVar10 == null) throw; // [null/range check failed]
                StudyInternalPointController.RemoveConnect(lVar10,uVar9);
              }
              else {
                lVar7 = GameObject.GetComponent(lVar5,DAT_181d73e60);
                if (lVar7 == null) throw; // [null/range check failed]
                iVar12 = *(int *)(lVar7 + 64);
                if ((this.startPoint == null) ||
                   (lVar7 = GameObject.GetComponent(this.startPoint,DAT_181d73e60),
                   lVar7 == null)) throw; // [null/range check failed]
                if (iVar12 == *(int *)(lVar7 + 64)) {
                  lVar10 = GameObject.GetComponent(lVar5,DAT_181d73e60);
                  lVar7 = this.gridUnits;
                  lVar11 = GameObject.GetComponent(lVar5,DAT_181d73e60);
                  if (lVar11 == null) throw; // [null/range check failed]
                  iVar12 = *(int *)(lVar11 + 60);
                  lVar11 = GameObject.GetComponent(lVar5,DAT_181d73e60);
                  if (((lVar11 == null) || (lVar7 == null)) ||
                     (uVar9 = FUN_180127f90(lVar7,(int64)iVar12,(int64)(*(int *)(lVar11 + 64) + 1)
                                           ), lVar10 == null)) throw; // [null/range check failed]
                  StudyInternalPointController.RemoveConnect(lVar10,uVar9,0);
                  lVar10 = GameObject.GetComponent(lVar5,DAT_181d73e60);
                  lVar7 = this.gridUnits;
                  lVar11 = GameObject.GetComponent(lVar5,DAT_181d73e60);
                  if (lVar11 == null) throw; // [null/range check failed]
                  iVar12 = *(int *)(lVar11 + 60);
                  lVar5 = GameObject.GetComponent(lVar5,DAT_181d73e60);
                  if ((lVar5 == null) || (lVar7 == null)) throw; // [null/range check failed]
                  goto LAB_180fe0234;
                }
              }
              lVar5 = this.startPoint;
              uVar15 = uVar15 + 1;
              lVar6 = lVar6 + 8;
              if (lVar5 == null) throw; // [null/range check failed]
            }
            Random.Range();
            iVar12 = Mathf.RoundToInt();
            lVar6 = il2cpp_internal(DAT_181d953d0);
            FUN_18132faf0(lVar6);
            lVar5 = this.gridPool;
            uVar15 = 0;
            if (lVar5 == null) throw; // [null/range check failed]
            lVar7 = 32;
            while( true ) {
              if (lVar5.Count <= (int)uVar15) goto joined_r0x000180fe068b;
              if (lVar5 == null) break;
              if (lVar5.Count <= uVar15) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              uVar9 = this.startPoint;
              uVar2 = *(uint64 *)(lVar7 + lVar5._items);
              cVar3 = Object.op_Inequality(uVar2,uVar9);
              if (cVar3) {
                if (((this.gridPool == null) ||
                    (lVar5 = FUN_180002f80(this.gridPool,uVar15)) == null) ||
                   ((lVar5 = GameObject.GetComponent(lVar5,DAT_181d73e60), lVar5 == null ||
                    (*(int64 *)(lVar5 + 104) == 0)))) break;
                if (2 < *(int *)(*(int64 *)(lVar5 + 104) + 24)) {
                  iVar14 = 0;
                  while( true ) {
                    if ((((this.gridPool == null) ||
                         (lVar5 = FUN_180002f80(this.gridPool,uVar15)) == null) ||
                        (lVar5 = GameObject.GetComponent(lVar5,DAT_181d73e60)) == null) ||
                       (*(int64 *)(lVar5 + 104) == 0)) throw; // [null/range check failed]
                    if (*(int *)(*(int64 *)(lVar5 + 104) + 24) <= iVar14) break;
                    if (((this.gridPool == null) ||
                        (lVar5 = FUN_180002f80(this.gridPool,uVar15,DAT_181d89918),
                        lVar5 == null)) ||
                       ((((lVar5 = GameObject.GetComponent(lVar5,DAT_181d73e60), lVar5 == null ||
                          ((*(int64 *)(lVar5 + 104) == 0 ||
                           (lVar5 = FUN_180002f80(*(int64 *)(lVar5 + 104),iVar14,DAT_181d89918),
                           lVar5 == null)))) ||
                         (lVar5 = GameObject.GetComponent(lVar5,DAT_181d73e60)) == null) ||
                        (*(int64 *)(lVar5 + 104) == 0)))) throw; // [null/range check failed]
                    if (2 < *(int *)(*(int64 *)(lVar5 + 104) + 24)) {
                      if (((this.gridPool == null) ||
                          (lVar5 = FUN_180002f80(this.gridPool,uVar15,DAT_181d89918),
                          lVar5 == null)) ||
                         (lVar5 = GameObject.GetComponent(lVar5,DAT_181d73e60)) == null)
                      throw; // [null/range check failed]
                      iVar13 = *(int *)(lVar5 + 68);
                      if ((((this.gridPool == null) ||
                           (lVar5 = FUN_180002f80(this.gridPool,uVar15,DAT_181d89918),
                           lVar5 == null)) ||
                          ((lVar5 = GameObject.GetComponent(lVar5,DAT_181d73e60), lVar5 == null ||
                           ((*(int64 *)(lVar5 + 104) == 0 ||
                            (lVar5 = FUN_180002f80(*(int64 *)(lVar5 + 104),iVar14,DAT_181d89918),
                            lVar5 == null)))))) ||
                         (lVar5 = GameObject.GetComponent(lVar5,DAT_181d73e60)) == null)
                      throw; // [null/range check failed]
                      if (iVar13 < *(int *)(lVar5 + 68)) {
                        if (((this.gridPool == null) ||
                            (lVar5 = FUN_180002f80(this.gridPool,uVar15,DAT_181d89918),
                            lVar5 == null)) ||
                           (lVar5 = GameObject.GetComponent(lVar5,DAT_181d73e60)) == null)
                        throw; // [null/range check failed]
                        uVar4 = *(uint32 *)(lVar5 + 68);
                        if (((this.gridPool == null) ||
                            (lVar5 = FUN_180002f80(this.gridPool,uVar15,DAT_181d89918),
                            lVar5 == null)) ||
                           (((lVar5 = GameObject.GetComponent(lVar5,DAT_181d73e60), lVar5 == null ||
                             ((*(int64 *)(lVar5 + 104) == 0 ||
                              (lVar5 = FUN_180002f80(*(int64 *)(lVar5 + 104),iVar14,DAT_181d89918),
                              lVar5 == null)))) ||
                            (lVar5 = GameObject.GetComponent(lVar5,DAT_181d73e60)) == null)))
                        throw; // [null/range check failed]
                        uVar1 = *(uint32 *)(lVar5 + 68);
                        uVar9 = new PointConnection(uVar4,uVar1);
                        if (lVar6 == null) throw; // [null/range check failed]
                        FUN_18181e0a0(lVar6,uVar9,DAT_181d97b08);
                      }
                    }
                    iVar14 = iVar14 + 1;
                  }
                }
              }
              lVar5 = this.gridPool;
              uVar15 = uVar15 + 1;
              lVar7 = lVar7 + 8;
              if (lVar5 == null) break;
            }
          }
        }
        throw; // [null/range check failed]
        LAB_180fe0f40:
        uVar9 = DAT_181dc2868;
        uVar9 = Type.GetTypeFromHandle(uVar9,0);
        lVar5 = Enum.GetNames(uVar9);
        if (lVar5 == null) throw; // [null/range check failed]
        if (lVar5.Count <= iVar12) {
          return;
        }
        if ((((this.targetSkill == null) || (lVar5 = KungfuSkillLvData.DataBase()) == null)
            || (iVar14 = *(int *)(lVar5 + 52), this.targetSkill == null)) ||
           (lVar5 = KungfuSkillLvData.DataBase()) == null) throw; // [null/range check failed]
        Random.Range((float)iVar14 * 0.1,(float)*(int *)(lVar5 + 52) * 0.5,0);
        iVar14 = Mathf.RoundToInt();
        iVar13 = 0;
        if (0 < iVar14 + 2) {
          do {
            if (lVar6 == null) throw; // [null/range check failed]
            uVar4 = FUN_180d95a30(0,*(uint32 *)(lVar6 + 24),0);
            lVar5 = FUN_180002f80(lVar6,uVar4,DAT_181d89918);
            if ((lVar5 == null) || (lVar5 = GameObject.GetComponent(lVar5,DAT_181d73e60)) == null)
            throw; // [null/range check failed]
            *(int *)(lVar5 + 52) = iVar12;
            lVar5 = FUN_180002f80(lVar6,uVar4,DAT_181d89918);
            if (lVar5 == null) throw; // [null/range check failed]
            lVar5 = GameObject.GetComponent(lVar5,DAT_181d73e60);
            if (iVar13 < 2) {
              bVar16 = iVar13 == 0;
            }
            else {
              fVar17 = (float)Random.get_value(0);
              bVar16 = fVar17 < 0.5;
            }
            if (lVar5 == null) throw; // [null/range check failed]
            *(bool *)(lVar5 + 56) = bVar16;
            FUN_181823590();
            iVar13 = iVar13 + 1;
          } while (iVar13 < iVar14 + 2);
        }
        iVar12 = iVar12 + 1;
        goto LAB_180fe0f40;
        joined_r0x000180fe068b:
        if (0 < iVar12) {
          if (lVar6 == null) throw; // [null/range check failed]
          if (*(int *)(lVar6 + 24) < 1) goto LAB_180fe09e8;
          uVar15 = FUN_180d95a30(0,*(int *)(lVar6 + 24),0);
          if (*(uint32 *)(lVar6 + 24) <= uVar15) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar5 = lVar6[uVar15];
          FUN_1817eee00(lVar6,lVar5,DAT_181d97b88);
          lVar7 = this.gridPool;
          if (lVar5 == null) {
        LAB_180fe1125:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          uVar15 = lVar5._items;
          if (lVar7 == null) goto LAB_180fe1125;
          if (lVar7.Count <= uVar15) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar7 = lVar7._items[uVar15];
          if (lVar7 == null) goto LAB_180fe1125;
          lVar10 = GameObject.GetComponent(lVar7,DAT_181d73e60);
          lVar7 = this.gridPool;
          uVar15 = *(uint32 *)(lVar5 + 20);
          if (lVar7 == null) goto LAB_180fe1125;
          if (lVar7.Count <= uVar15) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar7 = lVar7._items[uVar15];
          if (lVar10 == null) goto LAB_180fe1125;
          if (((*(int64 *)(lVar10 + 104) == 0) ||
              (FUN_1817eee00(*(int64 *)(lVar10 + 104),lVar7,DAT_181d89618), lVar7 == null)) ||
             (lVar7 = GameObject.GetComponent(lVar7,DAT_181d73e60)) == null) goto LAB_180fe1125;
          lVar7 = *(int64 *)(lVar7 + 104);
          uVar9 = Component.get_gameObject(lVar10,0);
          if (lVar7 == null) goto LAB_180fe1125;
          FUN_1817eee00(lVar7,uVar9,DAT_181d89618);
          local_68 = (int64)this.mapWidth;
          local_60 = (int64)this.mapHeight;
          lVar7 = FUN_1800d6020(DAT_181da9860,&local_68);
          if (this.startPoint == null) goto LAB_180fe1125;
          uVar9 = GameObject.GetComponent(this.startPoint,DAT_181d73e60);
          StudyInternalSkillController.FindConnectedPoint(this,lVar7,uVar9,0);
          iVar14 = 0;
          bVar16 = true;
          if (this.mapWidth < 1) {
        LAB_180fe0910:
            if (((this.gridPool == null) ||
                (lVar7 = FUN_180002f80(this.gridPool,lVar5._items,
                                       DAT_181d89918), lVar7 == null)) ||
               ((lVar7 = GameObject.GetComponent(lVar7,DAT_181d73e60), lVar7 == null ||
                (*(int64 *)(lVar7 + 104) == 0)))) throw; // [null/range check failed]
            if (*(int *)(*(int64 *)(lVar7 + 104) + 24) < 3) {
              StudyInternalSkillController.RemoveRandomRange(this,lVar6,lVar5._items)
              ;
            }
            if ((((this.gridPool == null) ||
                 (lVar5 = FUN_180002f80(this.gridPool,*(uint32 *)(lVar5 + 20)),
                 lVar5 == null)) || (lVar5 = GameObject.GetComponent(lVar5,DAT_181d73e60)) == null) ||
               (*(int64 *)(lVar5 + 104) == 0)) throw; // [null/range check failed]
            if (*(int *)(*(int64 *)(lVar5 + 104) + 24) < 3) {
              StudyInternalSkillController.RemoveRandomRange(this,lVar6);
            }
            iVar12 = iVar12 + -1;
          }
          else {
            do {
              iVar13 = 0;
              if (0 < this.mapHeight) {
                do {
                  if (lVar7 == null) throw; // [null/range check failed]
                  cVar3 = FUN_180132d10(lVar7,(int64)iVar14,(int64)iVar13);
                  if (!cVar3) {
                    bVar16 = false;
                    break;
                  }
                  iVar13 = iVar13 + 1;
                } while (iVar13 < this.mapHeight);
              }
              iVar14 = iVar14 + 1;
            } while (iVar14 < this.mapWidth);
            if (bVar16) goto LAB_180fe0910;
            if ((this.gridPool == null) ||
               (lVar7 = FUN_180002f80(this.gridPool,lVar5._items,
                                      DAT_181d89918), lVar7 == null)) throw; // [null/range check failed]
            lVar7 = GameObject.GetComponent(lVar7,DAT_181d73e60);
            if ((this.gridPool == null) ||
               (uVar9 = FUN_180002f80(this.gridPool,*(uint32 *)(lVar5 + 20)),
               lVar7 == null)) throw; // [null/range check failed]
            StudyInternalPointController.AddConnect(lVar7,uVar9);
          }
          goto joined_r0x000180fe068b;
        }
        LAB_180fe09e8:
        Random.Range();
        iVar12 = Mathf.RoundToInt();
        lVar5 = il2cpp_internal(DAT_181d953d0);
        FUN_18132faf0(lVar5,DAT_181d97a88);
        local_res8 = 0;
        if (0 < this.mapWidth) {
          do {
            iVar14 = 0;
            if (0 < this.mapHeight) {
              do {
                if (this.gridUnits == null) throw; // [null/range check failed]
                lVar6 = (int64)local_res8;
                lVar7 = (int64)iVar14;
                uVar9 = FUN_180127f90(this.gridUnits,lVar7,lVar6);
                cVar3 = StudyInternalSkillController.StartOrNearStartPoint(this,uVar9,0);
                if ((!cVar3) && (local_res8 < this.mapHeight + -1)) {
                  if (0 < iVar14) {
                    if (this.gridUnits == null) throw; // [null/range check failed]
                    uVar9 = FUN_180127f90(this.gridUnits,lVar7 + -1,lVar6 + 1);
                    cVar3 = StudyInternalSkillController.StartOrNearStartPoint(this,uVar9,0);
                    if (!cVar3) {
                      if (((this.gridUnits == null) ||
                          (lVar10 = FUN_180127f90(this.gridUnits,lVar7,lVar6)) == null
                          ) || (lVar10 = GameObject.GetComponent(lVar10,DAT_181d73e60)) == null)
                      throw; // [null/range check failed]
                      uVar4 = *(uint32 *)(lVar10 + 68);
                      if (((this.gridUnits == null) ||
                          (lVar10 = FUN_180127f90(this.gridUnits,lVar7 + -1,lVar6 + 1),
                          lVar10 == null)) ||
                         (lVar10 = GameObject.GetComponent(lVar10,DAT_181d73e60)) == null)
                      throw; // [null/range check failed]
                      uVar1 = *(uint32 *)(lVar10 + 68);
                      uVar9 = new PointConnection(uVar4,uVar1,0);
                      if (lVar5 == null) throw; // [null/range check failed]
                      FUN_18181e0a0(lVar5,uVar9,DAT_181d97b08);
                    }
                  }
                  if (iVar14 < this.mapWidth + -1) {
                    if (this.gridUnits == null) throw; // [null/range check failed]
                    uVar9 = FUN_180127f90(this.gridUnits,lVar7 + 1,lVar6 + 1);
                    cVar3 = StudyInternalSkillController.StartOrNearStartPoint(this,uVar9,0);
                    if (!cVar3) {
                      if (((this.gridUnits == null) ||
                          (lVar10 = FUN_180127f90(this.gridUnits,lVar7,lVar6)) == null
                          ) || (lVar10 = GameObject.GetComponent(lVar10,DAT_181d73e60)) == null)
                      throw; // [null/range check failed]
                      uVar4 = *(uint32 *)(lVar10 + 68);
                      if (((this.gridUnits == null) ||
                          (lVar6 = FUN_180127f90(this.gridUnits,lVar7 + 1,lVar6 + 1),
                          lVar6 == null)) ||
                         (lVar6 = GameObject.GetComponent(lVar6,DAT_181d73e60)) == null)
                      throw; // [null/range check failed]
                      uVar1 = *(uint32 *)(lVar6 + 68);
                      uVar9 = new PointConnection(uVar4,uVar1,0);
                      if (lVar5 == null) throw; // [null/range check failed]
                      FUN_18181e0a0(lVar5,uVar9,DAT_181d97b08);
                    }
                  }
                }
                iVar14 = iVar14 + 1;
              } while (iVar14 < this.mapHeight);
            }
            local_res8 = local_res8 + 1;
          } while (local_res8 < this.mapWidth);
        }
        for (; 0 < iVar12; iVar12 = iVar12 + -1) {
          if (lVar5 == null) throw; // [null/range check failed]
          if (lVar5.Count < 1) break;
          uVar15 = FUN_180d95a30(0,lVar5.Count,0);
          if (lVar5.Count <= uVar15) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar6 = lVar5._items[uVar15];
          lVar7 = this.gridPool;
          if (lVar6 == null) throw; // [null/range check failed]
          uVar15 = *(uint32 *)(lVar6 + 16);
          if (lVar7 == null) throw; // [null/range check failed]
          if (lVar7.Count <= uVar15) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar7 = lVar7._items[uVar15];
          if (lVar7 == null) throw; // [null/range check failed]
          lVar10 = GameObject.GetComponent(lVar7,DAT_181d73e60);
          lVar7 = this.gridPool;
          uVar15 = *(uint32 *)(lVar6 + 20);
          if (lVar7 == null) throw; // [null/range check failed]
          if (lVar7.Count <= uVar15) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar7 = lVar7._items[uVar15];
          if (lVar10 == null) throw; // [null/range check failed]
          if (((*(int64 *)(lVar10 + 104) == 0) ||
              (FUN_18181e0a0(*(int64 *)(lVar10 + 104),lVar7,DAT_181d89398), lVar7 == null)) ||
             (lVar7 = GameObject.GetComponent(lVar7,DAT_181d73e60)) == null) throw; // [null/range check failed]
          lVar7 = *(int64 *)(lVar7 + 104);
          uVar9 = Component.get_gameObject(lVar10,0);
          if (lVar7 == null) throw; // [null/range check failed]
          FUN_18181e0a0(lVar7,uVar9,DAT_181d89398);
          FUN_1817eee00(lVar5,lVar6);
        }
        lVar6 = il2cpp_internal(DAT_181d92f58);
        FUN_18132faf0(lVar6,DAT_181d89298);
        uVar15 = 0;
        lVar5 = this.gridPool;
        while (lVar5 != null) {
          if (lVar5.Count <= (int)uVar15) {
            iVar12 = 0;
            goto LAB_180fe0f40;
          }
          if (lVar5 == null) break;
          if (lVar5.Count <= uVar15) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          cVar3 = StudyInternalSkillController.StartOrNearStartPoint(this);
          if (!cVar3) {
            if ((this.gridPool == null) ||
               (FUN_180002f80(this.gridPool,uVar15,DAT_181d89918), lVar6 == null)) break;
            FUN_18181e0a0(lVar6);
          }
          uVar15 = uVar15 + 1;
          lVar5 = this.gridPool;
        }
    }

    // Token : 0x600228F
    // RVA   : 0xFE1CA0   Offset: 0xFE10A0   Length: 0xD5
    private bool StartOrNearStartPoint(GameObject targetPoint)
    {
        ulong uVar1;
        bool cVar2;
        byte uVar3;
        long lVar4;
        uVar1 = this.startPoint;
        cVar2 = Object.op_Equality(targetPoint,uVar1,0);
        if (cVar2) {
          return true;
        }
        if (this.startPoint != null) {
          lVar4 = GameObject.GetComponent(this.startPoint,DAT_181d73e60);
          if ((lVar4 != null) && (*(int64 *)(lVar4 + 104) != 0)) {
            uVar3 = FUN_18181e400(*(int64 *)(lVar4 + 104),targetPoint,DAT_181d89498);
            return uVar3;
          }
        }
    }

    // Token : 0x6002290
    // RVA   : 0xFE1600   Offset: 0xFE0A00   Length: 0xD3
    private void RemoveRandomRange(List<PointConnection> randomRange, int targetID)
    {
        void StudyInternalSkillController.RemoveRandomRange
                     (uint64 this,int64 randomRange,int targetID)
        {
        int64 lVar1;
        uint32 uVar2;
        int64 lVar3;
        if (randomRange != null) {
          uVar2 = *(int *)(randomRange + 24) - 1;
          if (-1 < (int)uVar2) {
            lVar3 = (int64)(int)uVar2 * 8 + 32;
            do {
              if (*(uint32 *)(randomRange + 24) <= uVar2) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar1 = *(int64 *)(lVar3 + *(int64 *)(randomRange + 16));
              if (lVar1 == null) throw; // [null/range check failed]
              if (*(int *)(lVar1 + 16) == targetID) {
        LAB_180fe169f:
                FUN_181823590(randomRange,uVar2,DAT_181d97c08);
              }
              else {
                lVar1 = FUN_180002f80(randomRange,uVar2,DAT_181d97d08);
                if (lVar1 == null) throw; // [null/range check failed]
                if (*(int *)(lVar1 + 20) == targetID) goto LAB_180fe169f;
              }
              lVar3 = lVar3 + -8;
              uVar2 = uVar2 - 1;
            } while (-1 < (int)uVar2);
          }
          return;
        }
    }

    // Token : 0x6002291
    // RVA   : 0xFDF510   Offset: 0xFDE910   Length: 0x195
    private void FindConnectedPoint(bool[] vis, StudyInternalPointController targetPoint)
    {
        void StudyInternalSkillController.FindConnectedPoint
                     (uint64 this,int64 vis,int64 targetPoint)
        {
        char cVar1;
        int64 lVar2;
        uint64 uVar3;
        int64 lVar4;
        uint32 uVar5;
        if ((targetPoint != null) && (vis != null)) {
          if (**(uint32 **)(vis + 16) <= *(uint32 *)(targetPoint + 60)) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          lVar4 = *(int64 *)(*(uint32 **)(vis + 16) + 4);
          if ((uint32)lVar4 <= *(uint32 *)(targetPoint + 64)) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          uVar5 = 0;
          *(uint8 *)
           ((int64)(int)*(uint32 *)(targetPoint + 64) + 32 +
           (int)*(uint32 *)(targetPoint + 60) * lVar4 + vis) = 1;
          lVar4 = 32;
          while (lVar2 = *(int64 *)(targetPoint + 104)) != null {
            if ((int)*(uint32 *)(lVar2 + 24) <= (int)uVar5) {
              return;
            }
            if (*(uint32 *)(lVar2 + 24) <= uVar5) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar2 = *(int64 *)(lVar4 + *(int64 *)(lVar2 + 16));
            if (lVar2 == null) break;
            lVar2 = GameObject.GetComponent(lVar2,DAT_181d73e60);
            cVar1 = Object.op_Inequality(lVar2,0,0);
            if (cVar1) {
              if (lVar2 == null) break;
              cVar1 = FUN_180132d10(vis,(int64)*(int *)(lVar2 + 60));
              if (!cVar1) {
                StudyInternalSkillController.FindConnectedPoint(this,vis,lVar2,0);
              }
            }
            uVar5 = uVar5 + 1;
            lVar4 = lVar4 + 8;
          }
        }
    }

    // Token : 0x6002292
    // RVA   : 0xFE1850   Offset: 0xFE0C50   Length: 0x38C
    public void ShowPoint()
    {
        uint uVar1;
        long lVar2;
        long lVar3;
        long lVar4;
        ulong uVar5;
        uint uVar6;
        long lVar7;
        if (this.studyInternalSkillUIRoot != null) {
          GameObject.SetActive(this.studyInternalSkillUIRoot,1,0);
          lVar2 = this.gridPool;
          uVar6 = 0;
          if (lVar2 != null) {
            lVar7 = 32;
            while( true ) {
              if (lVar2.Count <= (int)uVar6) {
                MonoBehaviour.Invoke(this,"ShowStartPoint",0x40000000,0);
                return;
              }
              if (lVar2 == null) break;
              if (lVar2.Count <= uVar6) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar2 = *(int64 *)(lVar7 + lVar2._items);
              if (lVar2 == null) break;
              lVar2 = GameObject.GetComponent(lVar2,DAT_181d73e60);
              lVar3 = FUN_18046c0a0(0);
              if ((((this.targetSkill == null) ||
                   (lVar4 = KungfuSkillLvData.DataBase(this.targetSkill,0)) == null) ||
                  (lVar3 == null)) ||
                 (uVar1 = GameController.RandomRareLvByBossLv
                                    (lVar3,(float)*(int *)(lVar4 + 52) * 0.3,0), lVar2 == null)) break;
              *(uint32 *)(lVar2 + 36) = uVar1;
              if ((this.gridPool == null) ||
                 (lVar2 = FUN_180002f80(this.gridPool,uVar6,DAT_181d89918)) == null)
              break;
              lVar2 = GameObject.GetComponent(lVar2,DAT_181d73e60);
              if (((this.gridPool == null) ||
                  ((lVar3 = FUN_180002f80(this.gridPool,uVar6,DAT_181d89918), lVar3 == null
                   || (lVar3 = GameObject.GetComponent(lVar3,DAT_181d73e60)) == null))) ||
                 (lVar2 == null)) break;
              *(float *)(lVar2 + 48) = (float)((*(int *)(lVar3 + 36) + 1) * 5);
              if (((this.gridPool == null) ||
                  (lVar2 = FUN_180002f80(this.gridPool,uVar6,DAT_181d89918)) == null)
                 || (lVar2 = GameObject.GetComponent(lVar2,DAT_181d73e60)) == null) break;
              StudyInternalPointController.Init(lVar2,0);
              if ((this.gridPool == null) ||
                 (lVar2 = FUN_180002f80(this.gridPool,uVar6,DAT_181d89918)) == null)
              break;
              uVar5 = GameObject.get_transform(lVar2,0);
              uVar5 = ShortcutExtensions.DOScale(uVar5);
              Random.Range();
              uVar5 = TweenSettingsExtensions.SetDelay(uVar5);
              uVar5 = TweenSettingsExtensions.SetEase(uVar5,8,DAT_181dc0f80);
              TweenSettingsExtensions.SetUpdate(uVar5,1);
              lVar2 = this.gridPool;
              uVar6 = uVar6 + 1;
              lVar7 = lVar7 + 8;
              if (lVar2 == null) break;
            }
          }
        }
    }

    // Token : 0x6002293
    // RVA   : 0xFE1BE0   Offset: 0xFE0FE0   Length: 0xB3
    public void ShowStartPoint()
    {
        var pStatics = *(int64*)(DAT_181dadcf8 + 184);
        long lVar1;
        this.crashingPoint = this.startPoint;
        if (this.startPoint != null) {
          lVar1 = GameObject.GetComponent(this.startPoint,DAT_181d73e60);
          if (lVar1 != null) {
            StudyInternalPointController.SetPointCrashed(lVar1,0);
            if (*pStatics != 0) {
              TutorialController.StartTutorial(*pStatics,"修炼内功",0);
              return;
            }
          }
        }
    }

    // Token : 0x6002294
    // RVA   : 0xFE16E0   Offset: 0xFE0AE0   Length: 0x16B
    public void SetCrashingPoint(GameObject targetPoint)
    {
        long lVar1;
        ulong uVar2;
        bool cVar3;
        ulong local_18;
        uint local_10;
        lVar1 = this.crashingPoint;
        cVar3 = Object.op_Inequality(lVar1,0,0);
        if (cVar3) {
          if (*plVar4 == 0) goto LAB_180fe1846;
          uVar2 = GameObject.get_transform(*plVar4,0);
          ShortcutExtensions.DOKill(uVar2,1,0);
        }
        *plVar4 = targetPoint;
        il2cpp_internal(plVar4,targetPoint);
        lVar1 = *plVar4;
        cVar3 = Object.op_Inequality(lVar1,0,0);
        if (cVar3) {
          if (*plVar4 == 0) {
        LAB_180fe1846:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          uVar2 = GameObject.get_transform(*plVar4,0);
          local_10 = 0xc3b40000;
          local_18 = 0;
          uVar2 = ShortcutExtensions.DOLocalRotate(uVar2,&local_18,0x40000000,1,0);
          uVar2 = TweenSettingsExtensions.SetLoops(uVar2,0xffffffff,0,DAT_181dc12a8);
          TweenSettingsExtensions.SetEase(uVar2,1,DAT_181dc0d70);
        }
    }

    // Token : 0x6002295
    // RVA   : 0xFDF6B0   Offset: 0xFDEAB0   Length: 0x28
    public void FinishButtonClicked()
    {
        ulong uVar1;
        uVar1 = StudyInternalSkillController.FinishStudyInternalSkill(this,1);
        FUN_180d8c2e0(this,uVar1,0);
    }

    // Token : 0x6002296
    // RVA   : 0xFDF6E0   Offset: 0xFDEAE0   Length: 0x7B
    public IEnumerator FinishStudyInternalSkill(StudyInternalResult studyInternalResult)
    {
        int64 StudyInternalSkillController.FinishStudyInternalSkill
                         (uint64 this,uint32 studyInternalResult)
        {
        int64 lVar1;
        var lVar1 = new WarpText_d__8(0,0);
        if (lVar1 != null) {
          *(uint64 *)(lVar1 + 40) = this;
          *(uint32 *)(lVar1 + 32) = studyInternalResult;
          return lVar1;
        }
    }

    // Token : 0x6002297
    // RVA   : 0xFE28D0   Offset: 0xFE1CD0   Length: 0x11
    public void /*ctor*/()
    {
        void FUN_180fe28d0(int64 this)
        {
        this.crashTimeSpan = 0x3e4ccccd;
        FUN_18044ef50(this,0);
    }

}
