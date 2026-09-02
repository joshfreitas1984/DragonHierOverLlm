// ============================================================
// Type  : AreaController
// Token : 0x200013F
// ============================================================

public class AreaController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40007BD
    public GameObject areaObj;

    // Token: 0x40007BE
    public GameObject areaUnitPrefab;

    // Token: 0x40007BF
    public GameObject areaBuildingPrefab;

    // Token: 0x40007C0
    public GameObject areaDecorationPrefab;

    // Token: 0x40007C1
    public GameObject areaRandomEventPrefab;

    // Token: 0x40007C2
    public GameObject areaLittlePeoplePrefab;

    // Token: 0x40007C3
    public GameObject areaGrid;

    // Token: 0x40007C4
    public GameObject areaGridRoot;

    // Token: 0x40007C5
    public AreaData areaData;

    // Token: 0x40007C6
    public GameObject areaUIBelow;

    // Token: 0x40007C7
    public GameObject heroIconGrid;

    // Token: 0x40007C8
    public GameObject buildingIconPanel;

    // Token: 0x40007C9
    public GameObject buildingIconPrefab;

    // Token: 0x40007CA
    public GameObject buildingQuickButtonPanel;

    // Token: 0x40007CB
    public GameObject buildQuickButtonPrefab;

    // Token: 0x40007CC
    public GameObject areaEventQuickButtonPrefab;

    // Token: 0x40007CD
    public GameObject[] gridUnits;

    // Token: 0x40007CE
    public List<GameObject> gridPool;

    // Token: 0x40007CF
    public List<GameObject> areaBuilding;

    // Token: 0x40007D0
    private List<GameObject> decorations;

    // Token: 0x40007D1
    public List<GameObject> randomEvents;

    // Token: 0x40007D2
    public List<GameObject> littlePeoples;

    // Token: 0x40007D3
    public List<GameObject> outsideDecorationTiles;

    // Token: 0x40007D4
    public GameObject BackGround;

    // Token: 0x40007D5
    public static List<string> areaBackgroundLayerName;

    // Token: 0x40007D6
    public static List<int> areaTypeOutsideDecorationNum;

    // Token: 0x40007D7
    public static float areaMinScale;

    // Token: 0x40007D8
    public static float areaMaxScale;

    // Token: 0x40007D9
    public float nowScale;

    // Token: 0x40007DA
    public bool inited;

    // Token: 0x40007DB
    public bool startAniming;

    // Token: 0x40007DC
    public bool needRefreshHeroIcon;

    // Token: 0x40007DD
    public bool needRefreshAreaTreasurePriceGrid;

    // Token: 0x40007DE
    public bool needRefreshAreaBuildingChoice;

    // Token: 0x40007DF
    public bool needRefreshAreaEventGrid;

    // Token: 0x40007E0
    private GameObject newObj;

    // Token: 0x40007E1
    public static List<string> columnRoadDecorationAvailableName;

    // Token: 0x40007E2
    public static List<string> rowRoadUpDecorationAvailableName;

    // Token: 0x40007E3
    public static List<string> rowRoadDownDecorationAvailableName;

    // Token: 0x40007E4
    public static List<string> RoadDecorationName;

    // Token: 0x40007E5
    private static AreaController _instance;

    // Token: 0x40007E6
    private float checkPlotTime;

    // Token: 0x40007E7
    private float checkHeroIconFreezeTime;

    // Token: 0x40007E8
    private bool nowFreeze;

    // Token: 0x40007E9
    public GameObject keepFocusTarget;

    // Token: 0x40007EA
    public Vector2 tweenFocusTarget;

    // Token: 0x40007EB
    public float tweenFocusTargetScale;

    // Token: 0x40007EC
    public Transform areaInfo;

    // Token: 0x40007ED
    public Text areaLog;

    // Token: 0x40007EE
    public GameObject treasurePriceGrid;

    // Token: 0x40007EF
    public GameObject resourcePointUIGrid;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000A2E
    // RVA   : 0xA29950   Offset: 0xA28150   Length: 0x58
    public static AreaController get_Instance()
    {
        return *(uint64 *)(*(int64 *)(DAT_181d87630 + 184) + 56);
    }

    // Token : 0x6000A2F
    // RVA   : 0xA1B0D0   Offset: 0xA198D0   Length: 0x11E
    private void Awake()
    {
        var pStatics = *(int64*)(DAT_181d87630 + 184);
        bool cVar1;
        ulong uVar2;
        uVar2 = *(uint64 *)(pStatics + 56);
        cVar1 = Object.op_Equality(uVar2,0,0);
        if (!cVar1) {
          uVar2 = Component.get_gameObject(this,0);
          Object.Destroy(uVar2,0);
          return;
        }
        puVar3 = (uint64 *)(pStatics + 56);
        *puVar3 = this;
        il2cpp_internal(puVar3,this);
    }

    // Token : 0x6000A30
    // RVA   : 0x8E7DC0   Offset: 0x8E65C0   Length: 0x12
    private void Start()
    {
        void FUN_1808e7dc0(int64 this)
        {
        this.areaData = 0;
    }

    // Token : 0x6000A31
    // RVA   : 0xA26B20   Offset: 0xA25320   Length: 0x354
    private void Update()
    {
        var pStatics_0bb8 = *(int64*)(DAT_181d90bb8 + 184);
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        ulong uVar1;
        bool cVar2;
        int iVar3;
        int iVar4;
        long lVar5;
        ulong uVar6;
        long lVar10;
        int iVar12;
        float fVar13;
        float fVar14;
        float fVar15;
        float local_res8;
        float fStackX_c;
        uint64 local_88;
        float local_80;
        uint64 local_78;
        float local_70;
        uint8 local_68 [8];
        float local_60;
        uint8 local_58 [64];
        if (this.areaData == null) {
          return;
        }
        iVar4 = 0;
        if (this.needRefreshAreaBuildingChoice) {
          lVar5 = this.buildingQuickButtonPanel;
          this.needRefreshAreaBuildingChoice = 0;
          iVar12 = iVar4;
          if (lVar5 != null) {
            while ((lVar5 = GameObject.get_transform(lVar5,0), lVar5 != null &&
                   (lVar5 = Transform.Find(lVar5,"BuildQuickButtonGrid",0)) != null)) {
              iVar3 = Transform.get_childCount(lVar5,0);
              if (iVar3 <= iVar12) goto LAB_180a26e3c;
              if ((((this.buildingQuickButtonPanel == null) ||
                   (lVar5 = GameObject.get_transform(this.buildingQuickButtonPanel,0)) == null) ||
                  (lVar5 = Transform.Find(lVar5,"BuildQuickButtonGrid")) == null) ||
                 ((lVar5 = Transform.GetChild(lVar5,iVar12), lVar5 == null ||
                  (lVar5 = Component.GetComponent(lVar5)) == null))) break;
              BuildQuickButtonController.RefreshBuildingChoiceInfo(lVar5);
              lVar5 = this.buildingQuickButtonPanel;
              iVar12 = iVar12 + 1;
              if (lVar5 == null) break;
            }
          }
          throw; // [null/range check failed]
        }
        LAB_180a26e3c:
        uVar6 = this.keepFocusTarget;
        cVar2 = Object.op_Inequality(uVar6,0,0);
        if (!cVar2) {
          fVar14 = this.tweenFocusTarget;
          fVar15 = *(float *)(this + 0x10c);
          uVar6 = Vector2.get_one(0);
          local_res8 = (float)uVar6;
          fStackX_c = (float)((uint64)uVar6 >> 32);
          fVar14 = fVar14 - local_res8 * -99.0;
          fVar15 = fVar15 - fStackX_c * -99.0;
          if (9.9999994e-11 <= fVar15 * fVar15 + fVar14 * fVar14) {
            local_70 = 0.0;
            local_88 = this.tweenFocusTarget;
            local_80 = 0.0;
            AreaController.TweenFocusTarget(this,&local_88,this.tweenFocusTargetScale,0);
            AreaController.ClearFocusTarget(this,0);
          }
        }
        else {
          if ((this.keepFocusTarget == null) ||
             (lVar5 = GameObject.get_transform(this.keepFocusTarget,0)) == null)
          throw; // [null/range check failed]
          puVar8 = (uint64 *)Transform.get_localPosition(local_68,lVar5,0);
          local_88 = *puVar8;
          local_80 = *(float *)(puVar8 + 1);
          puVar9 = (uint64 *)GlobalData.SetZToZero(local_68,&local_88,0);
          local_78 = *puVar9;
          local_70 = *(float *)(puVar9 + 1);
          local_88 = local_78 ^ 0x8000000080000000;
          this.nowScale = 0x3f800000;
          local_80 = 0.0;
          puVar9 = (uint64 *)AreaController.LimitMapPos(local_68,this,&local_88,0x3f800000,0);
          local_88 = *puVar9;
          local_80 = *(float *)(puVar9 + 1);
          lVar5 = SpringPosition.Begin(this.areaGridRoot,&local_88,0x41200000,0);
          if (lVar5 == null) throw; // [null/range check failed]
          *(uint8 *)(lVar5 + 41) = 1;
        }
        if ((this.areaGrid == null) ||
           (lVar5 = GameObject.get_transform(this.areaGrid,0)) == null)
        throw; // [null/range check failed]
        pfVar7 = (float *)Transform.get_localScale(local_68,lVar5,0);
        lVar5 = this.areaGrid;
        if (*pfVar7 <= this.nowScale && this.nowScale != *pfVar7) {
          if ((lVar5 == null) || (lVar5 = GameObject.get_transform(lVar5,0)) == null)
          throw; // [null/range check failed]
          puVar9 = (uint64 *)Transform.get_localScale(local_58,lVar5,0);
          local_80 = *(float *)(puVar9 + 1);
          uVar1 = *puVar9;
          puVar8 = (uint64 *)Vector3.get_one(local_58,0);
          uVar6 = *puVar8;
          local_70 = *(float *)(puVar8 + 1);
          fVar14 = (float)RealTime.get_deltaTime(0);
          fVar15 = (float)((uint64)uVar6 >> 32) * fVar14;
          fVar13 = (float)uVar6 * fVar14;
          local_70 = local_70 * fVar14 + local_70 * fVar14 + local_80;
          local_78 = CONCAT44(fVar15 + fVar15 + (float)(uVar1 >> 32),fVar13 + fVar13 + (float)uVar1);
          local_88 = uVar1;
          local_60 = local_70;
          Transform.set_localScale(lVar5,&local_78,0);
          if ((this.areaGrid == null) ||
             (lVar5 = GameObject.get_transform(this.areaGrid,0)) == null)
          throw; // [null/range check failed]
          pfVar7 = (float *)Transform.get_localScale(local_58,lVar5,0);
          if (this.nowScale <= *pfVar7) {
            if (this.areaGrid == null) throw; // [null/range check failed]
            lVar5 = GameObject.get_transform(this.areaGrid,0);
            fVar14 = this.nowScale;
            puVar9 = (uint64 *)Vector3.get_one(local_58,0);
            local_78 = *puVar9;
            local_70 = *(float *)(puVar9 + 1);
        LAB_180a272fc:
            local_80 = local_70 * fVar14;
            local_88 = CONCAT44((float)(local_78 >> 32) * fVar14,(float)local_78 * fVar14);
            if (lVar5 == null) throw; // [null/range check failed]
            local_78 = local_88;
            local_70 = local_80;
            Transform.set_localScale(lVar5,&local_78,0);
          }
        LAB_180a27356:
          if (this.areaGridRoot == null) throw; // [null/range check failed]
          lVar5 = GameObject.get_transform(this.areaGridRoot,0);
          if ((this.areaGridRoot == null) ||
             (lVar10 = GameObject.get_transform(this.areaGridRoot,0)) == null)
          throw; // [null/range check failed]
          puVar9 = (uint64 *)Transform.get_localPosition(local_58,lVar10,0);
          fVar14 = *(float *)(puVar9 + 1);
          uVar1 = *puVar9;
          if ((this.areaGrid == null) ||
             (lVar10 = GameObject.get_transform(this.areaGrid,0)) == null)
          throw; // [null/range check failed]
          puVar11 = (uint32 *)Transform.get_localScale(local_58,lVar10,0);
          local_78 = uVar1;
          local_70 = fVar14;
          puVar9 = (uint64 *)AreaController.LimitMapPos(local_58,this,&local_78,*puVar11,0);
          if (lVar5 == null) throw; // [null/range check failed]
          local_78 = *puVar9;
          local_70 = *(float *)(puVar9 + 1);
          Transform.set_localPosition(lVar5,&local_78,0);
        }
        else {
          if ((lVar5 == null) || (lVar5 = GameObject.get_transform(lVar5,0)) == null)
          throw; // [null/range check failed]
          pfVar7 = (float *)Transform.get_localScale(local_68,lVar5,0);
          if (this.nowScale <= *pfVar7 && *pfVar7 != this.nowScale) {
            if ((this.areaGrid == null) ||
               (lVar5 = GameObject.get_transform(this.areaGrid,0)) == null)
            throw; // [null/range check failed]
            puVar8 = (uint64 *)Transform.get_localScale(local_68,lVar5,0);
            local_70 = *(float *)(puVar8 + 1);
            uVar6 = *puVar8;
            puVar9 = (uint64 *)Vector3.get_one(local_68,0);
            uVar1 = *puVar9;
            local_80 = *(float *)(puVar9 + 1);
            fVar14 = (float)RealTime.get_deltaTime(0);
            fVar13 = (float)(uVar1 >> 32) * fVar14;
            fVar15 = (float)uVar1 * fVar14;
            local_80 = local_70 - (local_80 * fVar14 + local_80 * fVar14);
            local_78 = CONCAT44((float)((uint64)uVar6 >> 32) - (fVar13 + fVar13),
                                (float)uVar6 - (fVar15 + fVar15));
            local_88 = uVar1;
            local_70 = local_80;
            Transform.set_localScale(lVar5,&local_78,0);
            if ((this.areaGrid == null) ||
               (lVar5 = GameObject.get_transform(this.areaGrid,0)) == null)
            throw; // [null/range check failed]
            pfVar7 = (float *)Transform.get_localScale(local_68,lVar5,0);
            if (*pfVar7 <= this.nowScale) {
              if (this.areaGrid == null) throw; // [null/range check failed]
              lVar5 = GameObject.get_transform(this.areaGrid,0);
              fVar14 = this.nowScale;
              puVar9 = (uint64 *)Vector3.get_one(local_58,0);
              local_78 = *puVar9;
              local_70 = *(float *)(puVar9 + 1);
              goto LAB_180a272fc;
            }
            goto LAB_180a27356;
          }
        }
        if (((*pStatics_df90 == 0) ||
            (lVar5 = *(int64 *)(*pStatics_df90 + 32)) == null) ||
           (lVar5 = WorldData.Player(lVar5,0)) == null) throw; // [null/range check failed]
        if (-1 < *(int *)(lVar5 + 192)) {
          lVar5 = FUN_18046c0a0(0);
          if (lVar5 == null) throw; // [null/range check failed]
          cVar2 = GameController.HaveSpeUI(lVar5,1,0);
          if (!cVar2) {
            lVar5 = FUN_18046c440(0);
            if (lVar5 == null) throw; // [null/range check failed]
            cVar2 = PlotController.HaveNoPlotWait(lVar5,0);
            if (cVar2) {
              lVar5 = FUN_18046c0a0(0);
              if (((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) ||
                 (lVar5 = *(int64 *)(*(int64 *)(lVar5 + 32) + 216)) == null)
              throw; // [null/range check failed]
              cVar2 = FUN_1808ab750(lVar5,46,DAT_181d99e30);
              if (!cVar2) {
                lVar5 = FUN_18046c0a0(0);
                if (((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) ||
                   (lVar5 = WorldData.Player(*(int64 *)(lVar5 + 32),0)) == null)
                throw; // [null/range check failed]
                lVar5 = HeroData.GetForce(lVar5,0,0);
                if (lVar5 != null) {
                  lVar5 = FUN_18046c0a0(0);
                  if ((((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) ||
                      (lVar5 = WorldData.Player(*(int64 *)(lVar5 + 32),0)) == null) ||
                     (lVar5 = HeroData.GetForce(lVar5,0,0)) == null) throw; // [null/range check failed]
                  iVar12 = *(int *)(lVar5 + 56);
                  lVar5 = FUN_18046c0a0(0);
                  if (((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) ||
                     (lVar5 = WorldData.Player(*(int64 *)(lVar5 + 32),0)) == null)
                  throw; // [null/range check failed]
                  if (iVar12 == *(int *)(lVar5 + 192)) {
                    lVar5 = FUN_18046c0a0(0);
                    if ((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) throw; // [null/range check failed]
                    if (*(char *)(*(int64 *)(lVar5 + 32) + 184) != false) {
                      lVar5 = FUN_18046c0a0(0);
                      if (((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) ||
                         (lVar5 = *(int64 *)(*(int64 *)(lVar5 + 32) + 168)) == null)
                      throw; // [null/range check failed]
                      if (*(int *)(lVar5 + 16) == 1) {
                        lVar5 = FUN_18046c0a0(0);
                        if ((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) throw; // [null/range check failed]
                        if (*(int *)(*(int64 *)(lVar5 + 32) + 156) == 0) {
                          lVar5 = FUN_18046c440(0);
                          if (lVar5 == null) throw; // [null/range check failed]
                          PlotController.AddPlotDataBase(lVar5,46);
                          goto LAB_180a2887f;
                        }
                      }
                    }
                  }
                }
              }
              fVar14 = this.checkPlotTime;
              fVar15 = (float)Time.get_deltaTime(0);
              fVar14 = fVar14 - fVar15;
              this.checkPlotTime = fVar14;
              if (fVar14 <= 0.0) {
                this.checkPlotTime = 0x3e4ccccd;
                lVar5 = FUN_18046c0a0(0);
                if ((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) throw; // [null/range check failed]
                if (*(int *)(*(int64 *)(lVar5 + 32) + 156) == 1) {
                  lVar5 = FUN_18046c0a0(0);
                  if (((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) ||
                     (lVar5 = WorldData.Player(*(int64 *)(lVar5 + 32),0)) == null)
                  throw; // [null/range check failed]
                  lVar5 = HeroData.GetForce(lVar5,0,0);
                  if (lVar5 == null) {
                    lVar5 = FUN_18046c0a0(0);
                    if (((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) ||
                       ((lVar5 = WorldData.Player(*(int64 *)(lVar5 + 32),0), lVar5 == null ||
                        (lVar5 = HeroData.GetArea(lVar5,0)) == null))) throw; // [null/range check failed]
                    if (*(int *)(lVar5 + 72) == 2) {
                      lVar5 = FUN_18046c760(0);
                      if (lVar5 == null) throw; // [null/range check failed]
                      TutorialController.StartTutorial(lVar5,"拜入门派",0);
                    }
                  }
                }
                lVar5 = FUN_18046c0a0(0);
                if ((((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) ||
                    (lVar5 = WorldData.Player(*(int64 *)(lVar5 + 32),0)) == null) ||
                   (*(int64 *)(lVar5 + 0x2e8) == 0)) throw; // [null/range check failed]
                if (0 < *(int *)(*(int64 *)(lVar5 + 0x2e8) + 24)) {
                  lVar5 = FUN_18046c760(0);
                  if (lVar5 == null) throw; // [null/range check failed]
                  TutorialController.StartTutorial(lVar5,"任务系统",0);
                }
                if (*pStatics_0bb8 == 0) throw; // [null/range check failed]
                cVar2 = WorldEventController.HaveTutorialWorldEvent
                                  (*pStatics_0bb8,0);
                if (cVar2) {
                  lVar5 = FUN_18046c760(0);
                  if (lVar5 == null) throw; // [null/range check failed]
                  TutorialController.StartTutorial(lVar5,"传闻系统",0);
                }
                lVar5 = FUN_18046c0a0(0);
                if ((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) throw; // [null/range check failed]
                if (7 < *(int *)(*(int64 *)(lVar5 + 32) + 0x1a8)) {
                  lVar5 = FUN_18046c760(0);
                  if (lVar5 == null) throw; // [null/range check failed]
                  TutorialController.StartTutorial(lVar5,"查看名录",0);
                }
                lVar5 = FUN_18046c0a0(0);
                if (((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) ||
                   (lVar5 = WorldData.Player(*(int64 *)(lVar5 + 32),0)) == null)
                throw; // [null/range check failed]
                lVar5 = HeroData.GetForce(lVar5,0,0);
                if (lVar5 == null) {
        LAB_180a28301:
                  lVar5 = FUN_18046c0a0(0);
                  if (((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) ||
                     (lVar5 = WorldData.Player(*(int64 *)(lVar5 + 32),0)) == null)
                  throw; // [null/range check failed]
                  lVar5 = HeroData.GetForce(lVar5,0,0);
                  if (lVar5 == null) goto LAB_180a2844d;
                  lVar5 = FUN_18046c0a0(0);
                  if (((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) ||
                     (lVar5 = WorldData.Player(*(int64 *)(lVar5 + 32),0)) == null)
                  throw; // [null/range check failed]
                  iVar4 = *(int *)(lVar5 + 132);
                  lVar5 = FUN_18046c0a0(0);
                  if (((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) ||
                     ((lVar5 = WorldData.Player(*(int64 *)(lVar5 + 32),0), lVar5 == null ||
                      (lVar5 = HeroData.GetArea(lVar5,0)) == null))) throw; // [null/range check failed]
                  if (iVar4 == *(int *)(lVar5 + 112)) {
                    cVar2 = GameController.MeetCondition("亲传弟子",0,0);
                    if (cVar2) {
                      lVar5 = FUN_18046c760(0);
                      uVar6 = "城镇建筑";
                      goto joined_r0x000180a28435;
                    }
                  }
                }
                else {
                  lVar5 = FUN_18046c0a0(0);
                  if (((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) ||
                     ((lVar5 = WorldData.Player(*(int64 *)(lVar5 + 32),0), lVar5 == null ||
                      (lVar5 = HeroData.GetForce(lVar5,0,0)) == null))) throw; // [null/range check failed]
                  iVar12 = *(int *)(lVar5 + 56);
                  lVar5 = FUN_18046c0a0(0);
                  if (((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) ||
                     (lVar5 = WorldData.Player(*(int64 *)(lVar5 + 32),0)) == null)
                  throw; // [null/range check failed]
                  if (iVar12 != *(int *)(lVar5 + 192)) goto LAB_180a28301;
                  lVar5 = FUN_18046c0a0(0);
                  if (((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) ||
                     (lVar5 = *(int64 *)(*(int64 *)(lVar5 + 32) + 0x100)) == null)
                  throw; // [null/range check failed]
                  cVar2 = FUN_1818279a0(lVar5,"内功修炼",DAT_181d7c4d0);
                  if (!cVar2) {
                    while( true ) {
                      if ((((*pStatics_df90 == 0) ||
                           (lVar5 = *(int64 *)(*pStatics_df90 + 32),
                           lVar5 == null)) || (lVar5 = WorldData.Player(lVar5,0)) == null) ||
                         (*(int64 *)(lVar5 + 0x260) == 0)) throw; // [null/range check failed]
                      if (*(int *)(*(int64 *)(lVar5 + 0x260) + 24) <= iVar4) goto LAB_180a27d7f;
                      lVar5 = FUN_18046c0a0(0);
                      if (((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) ||
                         ((lVar5 = WorldData.Player(*(int64 *)(lVar5 + 32),0), lVar5 == null ||
                          ((*(int64 *)(lVar5 + 0x260) == 0 ||
                           (lVar5 = FUN_180002f80(*(int64 *)(lVar5 + 0x260),iVar4,DAT_181d6ade8),
                           lVar5 == null)))))) throw; // [null/range check failed]
                      iVar12 = KungfuSkillLvData.Type(lVar5);
                      if (iVar12 < 3) break;
                      iVar4 = iVar4 + 1;
                    }
                    lVar5 = FUN_18046c760(0);
                    if (lVar5 == null) throw; // [null/range check failed]
                    TutorialController.StartTutorial(lVar5,"内功修炼",0);
                  }
        LAB_180a27d7f:
                  lVar5 = FUN_18046c0a0(0);
                  if (((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) ||
                     (lVar5 = WorldData.Player(*(int64 *)(lVar5 + 32),0)) == null)
                  throw; // [null/range check failed]
                  fVar14 = (float)HeroData.GetHpPercent(lVar5,0);
                  if (fVar14 <= 0.6) {
        LAB_180a27e3b:
                    lVar5 = FUN_18046c760(0);
                    if (lVar5 == null) throw; // [null/range check failed]
                    TutorialController.StartTutorial(lVar5,"恢复状态",0);
                  }
                  else {
                    lVar5 = FUN_18046c0a0(0);
                    if (((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) ||
                       (lVar5 = WorldData.Player(*(int64 *)(lVar5 + 32),0)) == null)
                    throw; // [null/range check failed]
                    fVar14 = (float)HeroData.GetManaPercent(lVar5,0);
                    if (fVar14 <= 0.6) goto LAB_180a27e3b;
                  }
                  lVar5 = FUN_18046c0a0(0);
                  if (((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) ||
                     (lVar5 = WorldData.Player(*(int64 *)(lVar5 + 32),0)) == null)
                  throw; // [null/range check failed]
                  fVar14 = (float)HeroData.GetTotalInjury(lVar5,0);
                  if (10.0 <= fVar14) {
                    lVar5 = FUN_18046c760(0);
                    if (lVar5 == null) throw; // [null/range check failed]
                    TutorialController.StartTutorial(lVar5,"治疗伤势",0);
                  }
                  lVar5 = FUN_18046c0a0(0);
                  if (((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) ||
                     ((lVar5 = WorldData.Player(*(int64 *)(lVar5 + 32),0), lVar5 == null ||
                      (*(int64 *)(lVar5 + 0x220) == 0)))) throw; // [null/range check failed]
                  fVar14 = *(float *)(*(int64 *)(lVar5 + 0x220) + 28);
                  lVar5 = FUN_18046c0a0(0);
                  if ((((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) ||
                      (lVar5 = WorldData.Player(*(int64 *)(lVar5 + 32),0)) == null) ||
                     (*(int64 *)(lVar5 + 0x220) == 0)) throw; // [null/range check failed]
                  if (0.8 <= fVar14 / *(float *)(*(int64 *)(lVar5 + 0x220) + 32)) {
                    lVar5 = FUN_18046c760(0);
                    if (lVar5 == null) throw; // [null/range check failed]
                    TutorialController.StartTutorial(lVar5,"私人仓库",0);
                  }
                  lVar5 = FUN_18046c0a0(0);
                  if (((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) ||
                     (lVar5 = WorldData.Player(*(int64 *)(lVar5 + 32),0)) == null)
                  throw; // [null/range check failed]
                  fVar14 = *(float *)(lVar5 + 0x1c0);
                  lVar5 = FUN_18046c0a0(0);
                  if (((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) ||
                     (lVar5 = WorldData.Player(*(int64 *)(lVar5 + 32),0)) == null)
                  throw; // [null/range check failed]
                  iVar4 = HeroData.GetUpgradeForceLvNeedContribution(lVar5,0x3f800000,0);
                  if ((float)iVar4 <= fVar14) {
                    lVar5 = FUN_18046c760(0);
                    if (lVar5 == null) throw; // [null/range check failed]
                    TutorialController.StartTutorial(lVar5,"晋升职位",0);
                  }
                  cVar2 = GameController.MeetCondition("入门弟子",0,0);
                  if (cVar2) {
                    lVar5 = FUN_18046c760(0);
                    if (lVar5 == null) throw; // [null/range check failed]
                    TutorialController.StartTutorial(lVar5,"进阶武学",0);
                  }
                  cVar2 = GameController.MeetCondition("正式弟子",0,0);
                  if (cVar2) {
                    lVar5 = FUN_18046c760(0);
                    if (lVar5 == null) throw; // [null/range check failed]
                    TutorialController.StartTutorial(lVar5,"编纂秘籍",0);
                  }
                  cVar2 = GameController.MeetCondition("亲传弟子",0,0);
                  if (cVar2) {
                    lVar5 = FUN_18046c760(0);
                    if (lVar5 == null) throw; // [null/range check failed]
                    TutorialController.StartTutorial(lVar5,"建筑系统",0);
                  }
                  cVar2 = GameController.MeetCondition("长老",0,0);
                  if (cVar2) {
                    lVar5 = FUN_18046c760(0);
                    if (lVar5 == null) throw; // [null/range check failed]
                    TutorialController.StartTutorial(lVar5,"门派管理",0);
                  }
                  cVar2 = GameController.MeetCondition("掌门",0,0);
                  if (!cVar2) goto LAB_180a2844d;
                  lVar5 = FUN_18046c760(0);
                  if (lVar5 == null) throw; // [null/range check failed]
                  TutorialController.StartTutorial(lVar5,"掌门教程",0);
                  lVar5 = FUN_18046c0a0(0);
                  if ((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) throw; // [null/range check failed]
                  if (*(int *)(*(int64 *)(lVar5 + 32) + 156) == 0) {
                    lVar5 = FUN_18046c0a0(0);
                    if ((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) throw; // [null/range check failed]
                    if (*(int *)(*(int64 *)(lVar5 + 32) + 16) >= 3)
                    {
                      }
                      else {
                    }
                    lVar5 = FUN_18046c0a0(0);
                    if ((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) throw; // [null/range check failed]
                    if (*(char *)(*(int64 *)(lVar5 + 32) + 0x10c) == false) goto LAB_180a2844d;
                  }
                  lVar5 = FUN_18046c760(0);
                  uVar6 = "攻城略地";
        joined_r0x000180a28435:
                  if (lVar5 == null) throw; // [null/range check failed]
                  TutorialController.StartTutorial(lVar5,uVar6,0);
                }
        LAB_180a2844d:
                lVar5 = FUN_18046c0a0(0);
                if (((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) ||
                   (lVar5 = WorldData.Player(*(int64 *)(lVar5 + 32),0)) == null)
                throw; // [null/range check failed]
                lVar5 = HeroData.GetForce(lVar5,0,0);
                if (lVar5 != null) {
                  cVar2 = GameController.MeetCondition("掌门",0,0);
                  if (cVar2) {
                    lVar5 = FUN_18046c0a0(0);
                    if ((((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) ||
                        (lVar5 = WorldData.Player(*(int64 *)(lVar5 + 32),0)) == null) ||
                       (lVar5 = HeroData.GetForce(lVar5,0,0)) == null) throw; // [null/range check failed]
                    iVar4 = *(int *)(lVar5 + 16);
                    lVar5 = FUN_18046c0a0(0);
                    if (((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) ||
                       ((lVar5 = WorldData.Player(*(int64 *)(lVar5 + 32),0), lVar5 == null ||
                        ((lVar5 = HeroData.GetArea(lVar5,0), lVar5 == null ||
                         (lVar5 = AreaData.GetForce(lVar5,0)) == null))))) throw; // [null/range check failed]
                    if (iVar4 == *(int *)(lVar5 + 60)) {
                      lVar5 = FUN_18046c760(0);
                      if (lVar5 == null) throw; // [null/range check failed]
                      TutorialController.StartTutorial(lVar5,"附庸门派",0);
                      lVar5 = FUN_18046c0a0(0);
                      if ((((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) ||
                          (lVar5 = WorldData.Player(*(int64 *)(lVar5 + 32),0)) == null) ||
                         ((lVar5 = HeroData.GetArea(lVar5,0), lVar5 == null ||
                          (lVar5 = AreaData.GetForce(lVar5,0)) == null))) throw; // [null/range check failed]
                      if (*(char *)(lVar5 + 36) != false) {
                        lVar5 = FUN_18046c0a0(0);
                        if ((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) throw; // [null/range check failed]
                        if (*(char *)(*(int64 *)(lVar5 + 32) + 0x10c) != false) {
                          lVar5 = FUN_18046c760(0);
                          if (lVar5 == null) throw; // [null/range check failed]
                          TutorialController.StartTutorial(lVar5,"附庸兑换",0);
                        }
                      }
                    }
                  }
                }
                lVar5 = FUN_18046c0a0(0);
                if ((((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) ||
                    (lVar5 = WorldData.Player(*(int64 *)(lVar5 + 32),0)) == null) ||
                   (lVar5 = HeroData.GetArea(lVar5,0)) == null) throw; // [null/range check failed]
                if (*(int *)(lVar5 + 72) != 2) {
                  lVar5 = FUN_18046c0a0(0);
                  if (((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) ||
                     (lVar5 = WorldData.Player(*(int64 *)(lVar5 + 32),0)) == null)
                  throw; // [null/range check failed]
                  if (100.0 <= *(float *)(lVar5 + 0x1c4)) {
                    lVar5 = FUN_18046c0a0(0);
                    if (((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) ||
                       (lVar5 = WorldData.Player(*(int64 *)(lVar5 + 32),0)) == null)
                    throw; // [null/range check failed]
                    if (*(char *)(lVar5 + 0x1ac) == false) {
                      lVar5 = FUN_18046c760(0);
                      if (lVar5 == null) throw; // [null/range check failed]
                      TutorialController.StartTutorial(lVar5,"谋求官职",0);
                    }
                  }
                }
                lVar5 = FUN_18046c760(0);
                if (lVar5 == null) throw; // [null/range check failed]
                if (*(char *)(lVar5 + 56) == false) {
                  lVar5 = FUN_18046c0a0(0);
                  lVar10 = FUN_18046c0a0(0);
                  if (((lVar10 == null) || (*(int64 *)(lVar10 + 32) == 0)) ||
                     ((lVar10 = WorldData.Player(*(int64 *)(lVar10 + 32),0), lVar10 == null ||
                      (uVar6 = Int32.ToString(lVar10 + 192,0), lVar5 == null)))) throw; // [null/range check failed]
                  GameController.CheckPlotTrigger(lVar5,8,uVar6,999999,0);
                }
              }
            }
          }
        }
        LAB_180a2887f:
        if (this.needRefreshHeroIcon) {
          AreaController.FreshAreaHeroIcon(this,0);
        }
        if (this.needRefreshAreaTreasurePriceGrid) {
          AreaController.FreshAreaTreasurePriceGrid(this,0);
        }
        if (this.needRefreshAreaEventGrid) {
          this.needRefreshAreaEventGrid = 0;
          if ((((this.buildingQuickButtonPanel == null) ||
               (lVar5 = GameObject.get_transform(this.buildingQuickButtonPanel,0)) == null) ||
              (lVar5 = Transform.Find(lVar5,"AreaEventQuickButtonGrid",0)) == null) ||
             (lVar5 = Component.GetComponent(lVar5,DAT_181d6e0c0)) == null) throw; // [null/range check failed]
          UIGrid.set_repositionNow(lVar5,1,0);
          lVar5 = new WarpText_d__8(0,0);
          if (lVar5 == null) throw; // [null/range check failed]
          *(int64 *)(lVar5 + 32) = this;
          FUN_180d837c0(this,lVar5,0);
        }
        AreaController.FreshAreaInfo(this,0,0);
        fVar14 = this.checkHeroIconFreezeTime;
        fVar15 = (float)Time.get_deltaTime(0);
        fVar14 = fVar14 - fVar15;
        this.checkHeroIconFreezeTime = fVar14;
        if (0.0 < fVar14) {
          return;
        }
        this.checkHeroIconFreezeTime = 0x3f000000;
        if (this.nowFreeze) {
          lVar5 = FUN_18046c0a0(0);
          if (lVar5 == null) throw; // [null/range check failed]
          cVar2 = GameController.HaveSpeUI(lVar5,1,0);
          if (!cVar2) {
            this.nowFreeze = 0;
            if ((this.heroIconGrid != null) &&
               (lVar5 = GameObject.get_transform(this.heroIconGrid,0)) != null) {
              iVar4 = Transform.get_childCount(lVar5,0);
              while( true ) {
                iVar4 = iVar4 + -1;
                if (iVar4 < 0) {
                  return;
                }
                if ((((this.heroIconGrid == null) ||
                     (lVar5 = GameObject.get_transform(this.heroIconGrid,0)) == null) ||
                    (lVar5 = Transform.GetChild(lVar5,iVar4,0)) == null) ||
                   (lVar5 = Component.GetComponent(lVar5,DAT_181d6b8c0)) == null) break;
                lVar5 = *(int64 *)(lVar5 + 32);
                if (((this.heroIconGrid == null) ||
                    (lVar10 = GameObject.get_transform(this.heroIconGrid,0)) == null) ||
                   ((lVar10 = Transform.GetChild(lVar10,iVar4,0), lVar10 == null ||
                    ((Transform.Find(lVar10,"Back"), lVar5 == null ||
                     (lVar5 = HeroData.GetSkeletonGraphic(lVar5)) == null))))) break;
                *(uint8 *)(lVar5 + 0x118) = 0;
              }
            }
            throw; // [null/range check failed]
          }
          if (this.nowFreeze) {
            return;
          }
        }
        lVar5 = FUN_18046c0a0(0);
        if (lVar5 != null) {
          cVar2 = GameController.HaveSpeUI(lVar5,1,0);
          if (cVar2) {
            this.nowFreeze = 1;
            if ((this.heroIconGrid == null) ||
               (lVar5 = GameObject.get_transform(this.heroIconGrid,0)) == null)
            throw; // [null/range check failed]
            iVar4 = Transform.get_childCount(lVar5,0);
            while (iVar4 = iVar4 + -1, -1 < iVar4) {
              if ((((this.heroIconGrid == null) ||
                   (lVar5 = GameObject.get_transform(this.heroIconGrid,0)) == null) ||
                  (lVar5 = Transform.GetChild(lVar5,iVar4,0)) == null) ||
                 (lVar5 = Component.GetComponent(lVar5,DAT_181d6b8c0)) == null) throw; // [null/range check failed]
              lVar5 = *(int64 *)(lVar5 + 32);
              if (((this.heroIconGrid == null) ||
                  (lVar10 = GameObject.get_transform(this.heroIconGrid,0)) == null) ||
                 ((lVar10 = Transform.GetChild(lVar10,iVar4,0), lVar10 == null ||
                  ((Transform.Find(lVar10,"Back"), lVar5 == null ||
                   (lVar5 = HeroData.GetSkeletonGraphic(lVar5)) == null))))) throw; // [null/range check failed]
              *(uint8 *)(lVar5 + 0x118) = 1;
            }
          }
          return;
        }
    }

    // Token : 0x6000A32
    // RVA   : 0xA1B6F0   Offset: 0xA19EF0   Length: 0x141
    public void FreezeAllAreaHero()
    {
        int iVar1;
        long lVar2;
        long lVar3;
        this.nowFreeze = 1;
        if ((this.heroIconGrid != null) &&
           (lVar2 = GameObject.get_transform(this.heroIconGrid,0)) != null) {
          iVar1 = Transform.get_childCount(lVar2,0);
          while( true ) {
            iVar1 = iVar1 + -1;
            if (iVar1 < 0) {
              return;
            }
            if ((((this.heroIconGrid == null) ||
                 (lVar2 = GameObject.get_transform(this.heroIconGrid,0)) == null) ||
                (lVar2 = Transform.GetChild(lVar2,iVar1,0)) == null) ||
               (lVar2 = Component.GetComponent(lVar2,DAT_181d6b8c0)) == null) break;
            lVar2 = *(int64 *)(lVar2 + 32);
            if (((this.heroIconGrid == null) ||
                (lVar3 = GameObject.get_transform(this.heroIconGrid,0)) == null) ||
               ((lVar3 = Transform.GetChild(lVar3,iVar1,0), lVar3 == null ||
                ((Transform.Find(lVar3,"Back"), lVar2 == null ||
                 (lVar2 = HeroData.GetSkeletonGraphic(lVar2)) == null))))) break;
            *(uint8 *)(lVar2 + 0x118) = 1;
          }
        }
    }

    // Token : 0x6000A33
    // RVA   : 0xA269D0   Offset: 0xA251D0   Length: 0x141
    public void UnfreezeAllAreaHero()
    {
        int iVar1;
        long lVar2;
        long lVar3;
        this.nowFreeze = 0;
        if ((this.heroIconGrid != null) &&
           (lVar2 = GameObject.get_transform(this.heroIconGrid,0)) != null) {
          iVar1 = Transform.get_childCount(lVar2,0);
          while( true ) {
            iVar1 = iVar1 + -1;
            if (iVar1 < 0) {
              return;
            }
            if ((((this.heroIconGrid == null) ||
                 (lVar2 = GameObject.get_transform(this.heroIconGrid,0)) == null) ||
                (lVar2 = Transform.GetChild(lVar2,iVar1,0)) == null) ||
               (lVar2 = Component.GetComponent(lVar2,DAT_181d6b8c0)) == null) break;
            lVar2 = *(int64 *)(lVar2 + 32);
            if (((this.heroIconGrid == null) ||
                (lVar3 = GameObject.get_transform(this.heroIconGrid,0)) == null) ||
               ((lVar3 = Transform.GetChild(lVar3,iVar1,0), lVar3 == null ||
                ((Transform.Find(lVar3,"Back"), lVar2 == null ||
                 (lVar2 = HeroData.GetSkeletonGraphic(lVar2)) == null))))) break;
            *(uint8 *)(lVar2 + 0x118) = 0;
          }
        }
    }

    // Token : 0x6000A34
    // RVA   : 0xA245D0   Offset: 0xA22DD0   Length: 0x44F
    public Vector3 LimitMapPos(Vector3 originPos, float scale)
    {
        var plVar7 = *(int64*)(lVar7 + 184);
        float * AreaController.LimitMapPos
                        (float *this,int64 originPos,uint64 *scale,float param_4)
        {
        float fVar1;
        uint64 uVar2;
        byte bVar3;
        int iVar4;
        int iVar5;
        int64 lVar6;
        int64 lVar7;
        float fVar8;
        float fVar9;
        float fVar10;
        float fVar11;
        float fStack_94;
        lVar6 = *(int64 *)(originPos + 88);
        this[0] = 0.0;
        this[1] = 0.0;
        this[2] = 0.0;
        lVar7 = DAT_181d4ef00;
        if (lVar6 != null) {
          iVar4 = *(int *)(lVar6 + 184);
          iVar5 = *(int *)(lVar6 + 188);
          *(uint64 *)this = *scale;
          bVar3 = *(byte *)(lVar7 + 0x133);
          fVar10 = (float)(iVar4 + -1) * -0.5;
          this[2] = *(float *)(scale + 1);
          fVar1 = *this;
          fVar11 = (float)(iVar5 + -1) * -0.5;
          fVar8 = fVar1;
          if (((bVar3 & 4) != 0) && (*(int *)(lVar7 + 224) == 0)) {
            il2cpp_runtime_class_init();
            fVar8 = *this;
            lVar7 = DAT_181d4ef00;
          }
          fVar9 = (param_4 + param_4) - 1.0;
          if ((*(float *)(plVar7 + 168) * 0.5 * fVar9) / param_4 + fVar10 < fVar1) {
            if (((*(byte *)(lVar7 + 0x133) & 4) != 0) && (*(int *)(lVar7 + 224) == 0)) {
              il2cpp_runtime_class_init();
              lVar7 = DAT_181d4ef00;
            }
            lVar6 = plVar7;
            this[1] = (float)((uint64)*(uint64 *)this >> 32);
            fVar1 = *(float *)(lVar6 + 168);
            this[2] = this[2];
            fVar8 = (fVar1 * 0.5 * fVar9) / param_4 + fVar10;
            *this = fVar8;
          }
          if (((*(byte *)(lVar7 + 0x133) & 4) != 0) && (*(int *)(lVar7 + 224) == 0)) {
            il2cpp_runtime_class_init();
            lVar7 = DAT_181d4ef00;
          }
          if (fVar8 < fVar10 - (*(float *)(plVar7 + 168) * 0.5 * fVar9) / param_4) {
            if (((*(byte *)(lVar7 + 0x133) & 4) != 0) && (*(int *)(lVar7 + 224) == 0)) {
              il2cpp_runtime_class_init();
              lVar7 = DAT_181d4ef00;
            }
            fVar1 = *(float *)(plVar7 + 168);
            this[1] = (float)((uint64)*(uint64 *)this >> 32);
            this[2] = this[2];
            *this = fVar10 - (fVar1 * 0.5 * fVar9) / param_4;
          }
          uVar2 = *(uint64 *)this;
          if (((*(byte *)(lVar7 + 0x133) & 4) != 0) && (*(int *)(lVar7 + 224) == 0)) {
            il2cpp_runtime_class_init();
            lVar7 = DAT_181d4ef00;
          }
          fStack_94 = (float)((uint64)uVar2 >> 32);
          fVar1 = *(float *)(plVar7 + 172);
          if ((((fVar1 + fVar1) * param_4 - 10.8) * 0.5) / param_4 + fVar11 < fStack_94) {
            fVar1 = *this;
            if (((*(byte *)(lVar7 + 0x133) & 4) != 0) && (*(int *)(lVar7 + 224) == 0)) {
              il2cpp_runtime_class_init();
              lVar7 = DAT_181d4ef00;
            }
            lVar6 = plVar7;
            *this = fVar1;
            fVar1 = *(float *)(lVar6 + 172);
            this[1] = (((fVar1 + fVar1) * param_4 - 10.8) * 0.5) / param_4 + fVar11;
            this[2] = this[2];
          }
          uVar2 = *(uint64 *)this;
          if (((*(byte *)(lVar7 + 0x133) & 4) != 0) && (*(int *)(lVar7 + 224) == 0)) {
            il2cpp_runtime_class_init();
            lVar7 = DAT_181d4ef00;
          }
          fVar1 = *(float *)(plVar7 + 172);
          fStack_94 = (float)((uint64)uVar2 >> 32);
          if (fStack_94 < fVar11 - (((fVar1 + fVar1) * param_4 - 10.8) * 0.5) / param_4) {
            fVar1 = *this;
            if (((*(byte *)(lVar7 + 0x133) & 4) != 0) && (*(int *)(lVar7 + 224) == 0)) {
              il2cpp_runtime_class_init();
              lVar7 = DAT_181d4ef00;
            }
            lVar6 = plVar7;
            *this = fVar1;
            fVar1 = *(float *)(lVar6 + 172);
            this[2] = this[2];
            this[1] = fVar11 - (((fVar1 + fVar1) * param_4 - 10.8) * 0.5) / param_4;
          }
          return this;
        }
    }

    // Token : 0x6000A35
    // RVA   : 0xA268F0   Offset: 0xA250F0   Length: 0xC6
    public void TweenFocusTarget(Vector3 targetPos, float targetScale)
    {
        uint uVar1;
        long lVar3;
        ulong local_28;
        uint local_20;
        ulong local_18;
        uint local_10;
        if (targetScale == null.0) {
          targetScale = 1.0;
        }
        if (this != 0) {
          local_18 = *targetPos;
          uVar1 = *(uint32 *)targetPos;
          local_10 = *(uint32 *)(targetPos + 1);
          this.nowScale = targetScale;
          local_28 = CONCAT44((int)((uint64)local_18 >> 32),uVar1) ^ 0x8000000080000000;
          local_20 = 0;
          puVar2 = (uint64 *)AreaController.LimitMapPos(&local_18,this,&local_28,targetScale,0);
          local_28 = *puVar2;
          local_20 = (uint32)puVar2[1];
          lVar3 = SpringPosition.Begin(this.areaGridRoot,&local_28,0x41200000,0);
          if (lVar3 != null) {
            *(uint8 *)(lVar3 + 41) = 1;
            return;
          }
        }
    }

    // Token : 0x6000A36
    // RVA   : 0xA1B680   Offset: 0xA19E80   Length: 0x68
    public void FocusOnTarget(GameObject target, float scale)
    {
        ulong uVar1;
        uVar1 = *target;
        this.tweenFocusTarget = (int)uVar1;
        *(int *)(this + 0x10c) = (int)((uint64)uVar1 >> 32);
        this.tweenFocusTargetScale = scale;
    }

    // Token : 0x6000A37
    // RVA   : 0xA1B650   Offset: 0xA19E50   Length: 0x29
    public void FocusOnTarget(Vector3 position, float scale)
    {
        ulong uVar1;
        uVar1 = *position;
        this.tweenFocusTarget = (int)uVar1;
        *(int *)(this + 0x10c) = (int)((uint64)uVar1 >> 32);
        this.tweenFocusTargetScale = scale;
    }

    // Token : 0x6000A38
    // RVA   : 0xA241E0   Offset: 0xA229E0   Length: 0x77
    public bool HaveFocusTarget()
    {
        ulong uVar1;
        float fVar2;
        float fVar3;
        float local_res8;
        float fStackX_c;
        fVar2 = this.tweenFocusTarget;
        fVar3 = *(float *)(this + 0x10c);
        uVar1 = Vector2.get_one(0);
        local_res8 = (float)uVar1;
        fStackX_c = (float)((uint64)uVar1 >> 32);
        fVar2 = fVar2 - local_res8 * -99.0;
        fVar3 = fVar3 - fStackX_c * -99.0;
        return 9.9999994e-11 <= fVar3 * fVar3 + fVar2 * fVar2;
    }

    // Token : 0x6000A39
    // RVA   : 0xA1B2C0   Offset: 0xA19AC0   Length: 0x51
    public void ClearFocusTarget()
    {
        ulong uVar1;
        uint local_res8;
        uint32 uStackX_c;
        uVar1 = Vector2.get_one(0);
        local_res8 = (float)uVar1;
        uStackX_c = (float)((uint64)uVar1 >> 32);
        this.tweenFocusTarget = local_res8 * -99.0;
        *(float *)(this + 0x10c) = uStackX_c * -99.0;
        this.tweenFocusTargetScale = 0;
    }

    // Token : 0x6000A3A
    // RVA   : 0xA1AF30   Offset: 0xA19730   Length: 0x37
    public float AreaMapNowScale()
    {
        long lVar1;
        byte[] local_18 = new byte[24];
        if (this.areaGrid != null) {
          lVar1 = GameObject.get_transform(this.areaGrid,0);
          if (lVar1 != null) {
            puVar2 = (uint32 *)Transform.get_localScale(local_18,lVar1,0);
            return *puVar2;
          }
        }
    }

    // Token : 0x6000A3B
    // RVA   : 0xA24260   Offset: 0xA22A60   Length: 0x36E
    private void InitAreaGround()
    {
        var plVar2 = *(int64*)(lVar2 + 184);
        var pStatics = *(int64*)(DAT_181d4ef00 + 184);
        long lVar2;
        ulong uVar3;
        long lVar4;
        ulong uVar6;
        long lVar7;
        int iVar8;
        int iVar9;
        int[] local_res8 = new int[2];
        int[] local_res18 = new int[4];
        float local_68;
        float local_64;
        uint local_60;
        ulong local_58;
        uint local_50;
        long local_48;
        long local_40;
        local_40 = (int64)*(int *)(pStatics + 0x20c);
        local_48 = (int64)*(int *)(pStatics + 0x208);
        lVar2 = FUN_1800d6020(DAT_181d848c0,&local_48);
        this.gridUnits = lVar2;
        uVar3 = il2cpp_internal(DAT_181d6e2b0);
        FUN_180f58a90(uVar3,DAT_181d61af8);
        this.gridPool = uVar3;
        iVar9 = 0;
        lVar2 = DAT_181d4ef00;
        do {
          if (((*(byte *)(lVar2 + 0x133) & 4) != 0) && (*(int *)(lVar2 + 224) == 0)) {
            il2cpp_runtime_class_init();
            lVar2 = DAT_181d4ef00;
          }
          if (*(int *)(plVar2 + 0x20c) <= iVar9) {
            return;
          }
          iVar8 = 0;
          while( true ) {
            if (((*(byte *)(lVar2 + 0x133) & 4) != 0) && (*(int *)(lVar2 + 224) == 0)) {
              il2cpp_runtime_class_init();
              lVar2 = DAT_181d4ef00;
            }
            if (*(int *)(plVar2 + 0x208) <= iVar8) break;
            lVar4 = *plVar1;
            uVar3 = this.areaGridRoot;
            uVar6 = this.areaUnitPrefab;
            if (((*(byte *)(lVar2 + 0x133) & 4) != 0) && (*(int *)(lVar2 + 224) == 0)) {
              il2cpp_runtime_class_init();
            }
            uVar3 = GlobalData.AddChild(uVar3,uVar6,0);
            if (lVar4 == null) {
        LAB_180a245c9:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar7 = (int64)iVar9;
            lVar2 = (int64)iVar8;
            FUN_180127fe0(lVar4,lVar2,lVar7,uVar3);
            if (*plVar1 == 0) goto LAB_180a245c9;
            lVar4 = FUN_180127f50(*plVar1,lVar2,lVar7);
            if (lVar4 == null) goto LAB_180a245c9;
            lVar4 = GameObject.get_transform(lVar4,0);
            puVar5 = (uint64 *)Vector3.get_one(&local_48,0);
            if (lVar4 == null) goto LAB_180a245c9;
            local_50 = *(uint32 *)(puVar5 + 1);
            local_58 = *puVar5;
            Transform.set_localScale(lVar4,&local_58,0);
            if (*plVar1 == 0) goto LAB_180a245c9;
            lVar4 = FUN_180127f50(*plVar1,lVar2,lVar7);
            if (lVar4 == null) goto LAB_180a245c9;
            lVar4 = GameObject.get_transform(lVar4,0);
            if (lVar4 == null) goto LAB_180a245c9;
            local_60 = 0;
            local_68 = (float)iVar8;
            local_64 = (float)iVar9;
            Transform.set_localPosition(lVar4,&local_68,0);
            if (*plVar1 == 0) goto LAB_180a245c9;
            lVar4 = FUN_180127f50(*plVar1,lVar2,lVar7);
            local_res8[0] = iVar9;
            uVar3 = il2cpp_value_box(DAT_181d5b2f8,local_res8);
            local_res18[0] = iVar8;
            uVar6 = il2cpp_value_box(DAT_181d5b2f8,local_res18);
            uVar3 = String.Format("{0}_{1}",uVar3,uVar6,0);
            if (lVar4 == null) goto LAB_180a245c9;
            Object.set_name(lVar4,uVar3,0);
            if (*plVar1 == 0) goto LAB_180a245c9;
            lVar2 = FUN_180127f50(*plVar1,lVar2);
            if (lVar2 == null) goto LAB_180a245c9;
            GameObject.SetActive(lVar2,0);
            iVar8 = iVar8 + 1;
            lVar2 = DAT_181d4ef00;
          }
          iVar9 = iVar9 + 1;
        } while( true );
    }

    // Token : 0x6000A3C
    // RVA   : 0xA25C00   Offset: 0xA24400   Length: 0x390
    public void ReturnBigMapButtonClicked()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        int iVar1;
        long lVar2;
        long lVar3;
        ulong uVar4;
        if ((*pStatics != 0) &&
           (lVar2 = *(int64 *)(*pStatics + 32)) != null) {
          if (*(char *)(lVar2 + 0x108) != false) {
        LAB_180a25f72:
            AreaController.PlayerLeaveArea(this,0);
            return;
          }
          if ((*pStatics != 0) &&
             (lVar2 = *(int64 *)(*pStatics + 32)) != null) {
            lVar2 = WorldData.Player(lVar2,0);
            if (lVar2 != null) {
              lVar2 = HeroData.GetForce(lVar2,0,0);
              if (lVar2 == null) goto LAB_180a25f72;
              lVar2 = FUN_18046c0a0(0);
              if ((lVar2 != null) && (*(int64 *)(lVar2 + 32) != 0)) {
                lVar2 = WorldData.Player(*(int64 *)(lVar2 + 32),0);
                if (lVar2 != null) {
                  iVar1 = *(int *)(lVar2 + 192);
                  lVar2 = FUN_18046c0a0(0);
                  if ((lVar2 != null) && (*(int64 *)(lVar2 + 32) != 0)) {
                    lVar2 = WorldData.Player(*(int64 *)(lVar2 + 32),0);
                    if (lVar2 != null) {
                      lVar2 = HeroData.GetForce(lVar2,0,0);
                      if (lVar2 != null) {
                        if (iVar1 != *(int *)(lVar2 + 56)) goto LAB_180a25f72;
                        lVar2 = FUN_18046c440(0);
                        lVar3 = il2cpp_internal(DAT_181d72a30);
                        FUN_180f58a90(lVar3,DAT_181d7c250);
                        if (lVar3 != null) {
                          FUN_181827900(lVar3,"好吧好吧;HideInteractUI",DAT_181d7c3d0);
                          FUN_181827900(lVar3,"一番恳求;AskJiangWanLeaveForce",DAT_181d7c3d0);
                          uVar4 = il2cpp_internal(DAT_181d7d2b0);
                          SinglePlotData.ctor
                                    (uVar4,"#PlayerName#不会又想偷溜下山吧？\n师傅吩咐，你这个月需好好练功，别成天想着乱跑！",lVar3,5,"姜婉",3,"0",0,0,0);
                          if (lVar2 != null) {
                            PlotController.ChangePlot(lVar2,uVar4,0);
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

    // Token : 0x6000A3D
    // RVA   : 0xA24CB0   Offset: 0xA234B0   Length: 0x7AC
    public void PlayerLeaveArea()
    {
        var pStatics_2bf0 = *(int64*)(DAT_181d92bf0 + 184);
        var pStatics_8ad8 = *(int64*)(DAT_181d88ad8 + 184);
        var pStatics_baa8 = *(int64*)(DAT_181d8baa8 + 184);
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        var pStatics_e188 = *(int64*)(DAT_181d4e188 + 184);
        bool cVar1;
        long lVar2;
        ulong uVar3;
        long lVar6;
        uint[] local_res18 = new uint[4];
        local_res18[0] = 0;
        if ((*pStatics_df90 != 0) &&
           (lVar2 = *(int64 *)(*pStatics_df90 + 32)) != null) {
          lVar2 = WorldData.Player(lVar2,0);
          if ((lVar2 != null) && (lVar6 = this.areaData) != null) {
            if (*(int *)(lVar2 + 192) == lVar6.areaID) {
              if (*pStatics_df90 == 0) throw; // [null/range check failed]
              GameController.PlayerLeaveArea(*pStatics_df90,0);
              local_res18[0] = FUN_180d8cf10(0,4);
              uVar3 = Int32.ToString(local_res18,0);
              uVar3 = String.Concat("Sound/SoundEffect/Door/BigDoor",uVar3,0);
              plVar4 = (int64 *)Resources.Load(uVar3,0);
              plVar5 = (int64 *)0;
              if ((plVar4 != (int64 *)0) && (*plVar4 == DAT_181d8a228)) {
                plVar5 = plVar4;
              }
              NGUITools.PlaySound(plVar5,0x3f000000,0);
              lVar6 = this.areaData;
              if (lVar6 == null) throw; // [null/range check failed]
            }
            cVar1 = FUN_1816fd990(lVar6.areaName,"巴陵村",0);
            if (cVar1) {
              if ((*pStatics_df90 == 0) ||
                 (lVar2 = *(int64 *)(*pStatics_df90 + 32)) == null)
              throw; // [null/range check failed]
              lVar2 = WorldData.Player(lVar2,0);
              if (lVar2 == null) throw; // [null/range check failed]
              cVar1 = HeroData.HaveMission(lVar2,"巴陵盗匪",0);
              if (cVar1) {
                if (*pStatics_8ad8 == 0) throw; // [null/range check failed]
                TutorialController.StartTutorial(*pStatics_8ad8,"视野系统",0);
              }
            }
            lVar2 = *(int64 *)(*(int64 *)(DAT_181d87338 + 184) + 16);
            if (lVar2 != null) {
              AreaBuildController.ChangeBuildMode(lVar2,0,0);
              AreaController.ResetAreaMap(this,0);
              if ((*pStatics_e188 != 0) &&
                 (lVar2 = *(int64 *)(*pStatics_e188 + 48)) != null) {
                GameObject.SetActive(lVar2,0,0);
                if ((*pStatics_e188 != 0) &&
                   (lVar2 = *(int64 *)(*pStatics_e188 + 32)) != null) {
                  GameObject.SetActive(lVar2,1,0);
                  if ((*pStatics_e188 != 0) &&
                     (lVar2 = *(int64 *)(*pStatics_e188 + 40)) != null) {
                    GameObject.SetActive(lVar2,1,0);
                    if (this.areaObj != null) {
                      GameObject.SetActive(this.areaObj,0,0);
                      this.areaData = 0;
                      lVar2 = *(int64 *)(pStatics_baa8 + 16);
                      if ((lVar2 != null) && (lVar2 = *(int64 *)(lVar2 + 88)) != null) {
                        GameObject.SetActive(lVar2,1,0);
                        lVar2 = *(int64 *)(pStatics_baa8 + 16);
                        if ((*pStatics_df90 != 0) &&
                           (lVar6 = *(int64 *)(*pStatics_df90 + 32),
                           lVar6 != null)) {
                          uVar3 = WorldData.Player(lVar6,0);
                          if (lVar2 != null) {
                            BigMapController.RefreshBigMapNPC(lVar2,uVar3,0);
                            lVar2 = *(int64 *)(pStatics_baa8 + 16);
                            if (lVar2 != null) {
                              BigMapController.PlayBigMapControlAnim(lVar2,0);
                              if (*pStatics_2bf0 != 0) {
                                CloudAnimController.PlayerCloudAnim
                                          (*pStatics_2bf0,0);
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
    }

    // Token : 0x6000A3E
    // RVA   : 0xA256E0   Offset: 0xA23EE0   Length: 0x51B
    public void ResetAreaMap()
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        uint uVar4;
        long lVar5;
        lVar2 = this.gridPool;
        uVar4 = 0;
        if (lVar2 != null) {
          lVar5 = 32;
          while ((int)uVar4 < lVar2.Count) {
            if (lVar2 == null) throw; // [null/range check failed]
            if (lVar2.Count <= uVar4) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar2 = *(int64 *)(lVar5 + lVar2._items);
            if ((lVar2 == null) || (lVar2 = GameObject.GetComponent(lVar2,DAT_181d9e4d0)) == null)
            throw; // [null/range check failed]
            uVar3 = *(uint64 *)(lVar2 + 32);
            cVar1 = Object.op_Inequality(uVar3,0,0);
            if (cVar1) {
              if ((((this.gridPool == null) ||
                   (lVar2 = FUN_180002f80(this.gridPool,uVar4,DAT_181d62178)) == null)
                  || (lVar2 = GameObject.GetComponent(lVar2,DAT_181d9e4d0)) == null) ||
                 (*(int64 *)(lVar2 + 32) == 0)) throw; // [null/range check failed]
              uVar3 = Component.get_gameObject(*(int64 *)(lVar2 + 32),0);
              Object.Destroy(uVar3,0);
              if (((this.gridPool == null) ||
                  (lVar2 = FUN_180002f80(this.gridPool,uVar4,DAT_181d62178)) == null)
                 || (lVar2 = GameObject.GetComponent(lVar2,DAT_181d9e4d0)) == null)
              throw; // [null/range check failed]
              *(uint64 *)(lVar2 + 32) = 0;
            }
            if (((this.gridPool == null) ||
                (lVar2 = FUN_180002f80(this.gridPool,uVar4,DAT_181d62178)) == null) ||
               (lVar2 = GameObject.GetComponent(lVar2,DAT_181d9e4d0)) == null) throw; // [null/range check failed]
            if (*(int64 *)(lVar2 + 40) != 0) {
              if (((this.gridPool == null) ||
                  (lVar2 = FUN_180002f80(this.gridPool,uVar4,DAT_181d62178)) == null)
                 || (lVar2 = GameObject.GetComponent(lVar2,DAT_181d9e4d0)) == null)
              throw; // [null/range check failed]
              uVar3 = *(uint64 *)(lVar2 + 40);
              GlobalData.DestroyAll(uVar3,0);
              if (((this.gridPool == null) ||
                  (lVar2 = FUN_180002f80(this.gridPool,uVar4,DAT_181d62178)) == null)
                 || (lVar2 = GameObject.GetComponent(lVar2,DAT_181d9e4d0)) == null)
              throw; // [null/range check failed]
              *(uint64 *)(lVar2 + 40) = 0;
            }
            if ((this.gridPool == null) ||
               (lVar2 = FUN_180002f80(this.gridPool,uVar4,DAT_181d62178)) == null)
            throw; // [null/range check failed]
            GameObject.SetActive(lVar2,0,0);
            if (((this.gridPool == null) ||
                ((lVar2 = FUN_180002f80(this.gridPool,uVar4), lVar2 == null ||
                 (lVar2 = GameObject.get_transform(lVar2,0)) == null))) ||
               (lVar2 = Transform.Find(lVar2,"CityWall")) == null) throw; // [null/range check failed]
            uVar3 = Component.get_gameObject(lVar2,0);
            GlobalData.DeleteAllChild(uVar3,0);
            lVar2 = this.gridPool;
            uVar4 = uVar4 + 1;
            lVar5 = lVar5 + 8;
            if (lVar2 == null) throw; // [null/range check failed]
          }
          FUN_180f56130(lVar2,DAT_181d61c78);
          if (this.areaBuilding != null) {
            FUN_180f56130(this.areaBuilding,DAT_181d61c78);
            uVar3 = this.decorations;
            GlobalData.DestroyAll(uVar3,0);
            GlobalData.DestroyAll(this.randomEvents,0);
            GlobalData.DestroyAll(this.littlePeoples,0);
            GlobalData.DestroyAll(*(uint64 *)(this + 200),0);
            GlobalData.DeleteAllChild(this.heroIconGrid,0);
            GlobalData.DeleteAllChild(this.buildingIconPanel,0);
            if (((this.buildingQuickButtonPanel != null) &&
                (lVar2 = GameObject.get_transform(this.buildingQuickButtonPanel,0)) != null) &&
               (lVar2 = Transform.Find(lVar2,"BuildQuickButtonGrid",0)) != null) {
              uVar3 = Component.get_gameObject(lVar2,0);
              GlobalData.DeleteAllChild(uVar3,0);
              if (((this.buildingQuickButtonPanel != null) &&
                  (lVar2 = GameObject.get_transform(this.buildingQuickButtonPanel,0)) != null) &&
                 (lVar2 = Transform.Find(lVar2,"AreaEventQuickButtonGrid",0)) != null) {
                uVar3 = Component.get_gameObject(lVar2,0);
                GlobalData.DeleteAllChild(uVar3,0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x6000A3F
    // RVA   : 0xA25460   Offset: 0xA23C60   Length: 0x151
    public void RefreshAllAreaUnitColor()
    {
        bool cVar1;
        ulong uVar2;
        long lVar3;
        long lVar4;
        uint uVar5;
        lVar3 = this.gridPool;
        uVar5 = 0;
        if (lVar3 != null) {
          lVar4 = 32;
          while( true ) {
            if (lVar3.Count <= (int)uVar5) {
              return;
            }
            if (lVar3 == null) break;
            if (lVar3.Count <= uVar5) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar3 = *(int64 *)(lVar4 + lVar3._items);
            if (lVar3 == null) break;
            uVar2 = GameObject.GetComponent(lVar3,DAT_181d9e4d0);
            cVar1 = Object.op_Inequality(uVar2,0,0);
            if (cVar1) {
              if (((this.gridPool == null) ||
                  (lVar3 = FUN_180002f80(this.gridPool,uVar5)) == null) ||
                 (lVar3 = GameObject.GetComponent(lVar3,DAT_181d9e4d0)) == null) break;
              AreaUnitController.RefreshUnitColor(lVar3,0);
            }
            lVar3 = this.gridPool;
            uVar5 = uVar5 + 1;
            lVar4 = lVar4 + 8;
            if (lVar3 == null) break;
          }
        }
    }

    // Token : 0x6000A40
    // RVA   : 0xA1EB80   Offset: 0xA1D380   Length: 0x386B
    public void GenerateAreaMap(AreaData targetAreaData)
    {
        var pStatics_2bf0 = *(int64*)(DAT_181d92bf0 + 184);
        var pStatics_7630 = *(int64*)(DAT_181d87630 + 184);
        var pStatics_e188 = *(int64*)(DAT_181d4e188 + 184);
        var pStatics_ef00 = *(int64*)(DAT_181d4ef00 + 184);
        uint uVar1;
        bool cVar2;
        int iVar3;
        int iVar4;
        uint uVar5;
        int iVar6;
        long lVar7;
        long lVar8;
        long lVar9;
        long lVar10;
        ulong uVar11;
        ulong uVar15;
        ulong uVar16;
        ulong uVar17;
        int iVar21;
        int iVar22;
        float fVar27;
        float fVar28;
        float fVar29;
        float fVar30;
        float fVar31;
        float fVar32;
        float fVar33;
        int local_res10;
        int[] local_res20 = new int[2];
        uint64 local_7b8;
        uint64 uStack_7b0;
        int local_7a8;
        uint64 local_798;
        float local_790;
        uint64 local_788;
        float local_780;
        uint64 local_778;
        uint64 uStack_770;
        float local_768;
        float local_764;
        uint32 local_760;
        uint64 local_758;
        float local_750;
        int64 *local_748;
        uint8 local_740 [16];
        uint64 local_730;
        float local_718;
        uint32 local_710;
        uint32 uStack_70c;
        uint32 local_708;
        uint32 local_700;
        uint32 uStack_6fc;
        uint32 local_6f8;
        float local_6f0;
        float fStack_6ec;
        float local_6e8;
        float local_6e0;
        float fStack_6dc;
        float local_6d8;
        float local_6d0;
        float fStack_6cc;
        float local_6c8;
        uint32 local_6c0;
        uint32 uStack_6bc;
        uint32 local_6b8;
        float local_6b0;
        float fStack_6ac;
        float local_6a8;
        uint32 local_6a0;
        uint32 uStack_69c;
        uint32 local_698;
        uint32 local_690;
        uint32 uStack_68c;
        uint32 local_688;
        uint64 local_680;
        float local_678;
        float local_670;
        float fStack_66c;
        float local_668;
        uint64 local_660;
        float local_658;
        float local_650;
        float fStack_64c;
        float local_648;
        uint64 local_638;
        uint32 local_630;
        uint64 local_628;
        uint32 local_620;
        uint64 local_618;
        float local_610;
        uint32 local_608;
        uint32 local_604;
        uint32 local_600;
        float local_5f8;
        float local_5f4;
        uint32 local_5f0;
        uint64 local_5e8;
        uint32 local_5e0;
        float local_5d8;
        float local_5d4;
        uint32 local_5d0;
        uint64 local_5c8;
        uint32 local_5c0;
        float local_5b8;
        float local_5b4;
        uint32 local_5b0;
        uint64 local_5a8;
        uint32 local_5a0;
        float local_590;
        uint64 local_588;
        float local_580;
        uint64 local_578;
        uint32 local_570;
        uint64 local_568;
        uint32 local_560;
        float local_550;
        float local_540;
        float local_530;
        float local_520;
        float local_510;
        float local_500;
        uint64 local_4f8;
        uint32 local_4f0;
        float local_4e8;
        float fStack_4e4;
        float local_4e0;
        float local_4d0;
        uint64 local_4c8;
        float local_4c0;
        uint64 local_4b8;
        uint32 local_4b0;
        float local_4a0;
        uint64 local_498;
        float local_490;
        uint64 local_488;
        uint32 local_470;
        uint64 local_468;
        uint32 local_460;
        uint64 local_458;
        uint32 local_450;
        uint64 local_448;
        uint32 local_440;
        uint64 local_438;
        float local_430;
        uint64 local_428;
        float local_420;
        uint64 local_418;
        float local_410;
        uint64 local_408;
        uint32 local_400;
        int64 local_3f8;
        uint64 local_3e8;
        uint32 local_3e0;
        uint64 local_3d8;
        uint32 local_3d0;
        uint64 local_3c8;
        uint32 local_3c0;
        uint64 local_3b8;
        float local_3b0;
        uint64 local_3a8;
        uint64 uStack_3a0;
        uint64 local_398;
        uint64 uStack_390;
        uint64 local_388;
        uint64 uStack_380;
        uint64 local_378;
        uint64 uStack_370;
        float local_360;
        float local_350;
        float local_340;
        float local_330;
        uint32 local_320;
        uint32 local_310;
        float local_300;
        uint8 local_2f8 [16];
        uint8 local_2e8 [16];
        uint8 local_2d8 [16];
        uint8 local_2c8 [16];
        uint8 local_2b8 [16];
        uint8 local_2a8 [16];
        uint8 local_298 [16];
        uint8 local_288 [16];
        uint8 local_278 [16];
        uint8 local_268 [16];
        uint8 local_258 [16];
        uint8 local_248 [16];
        uint8 local_238 [16];
        uint8 local_228 [16];
        uint8 local_218 [16];
        uint8 local_208 [16];
        uint8 local_1f8 [16];
        uint8 local_1e8 [16];
        uint8 local_1d8 [16];
        uint8 local_1c8 [16];
        uint8 local_1b8 [16];
        uint8 local_1a8 [16];
        uint8 local_198 [16];
        uint8 local_188 [16];
        uint8 local_178 [16];
        uint8 local_168 [16];
        uint8 local_158 [16];
        uint8 local_148 [16];
        uint8 local_138 [16];
        uint8 local_128 [16];
        uint8 local_118 [16];
        uint8 local_108 [16];
        uint8 local_f8 [16];
        uint8 local_e8 [176];
        local_778 = 0;
        uStack_770 = 0;
        local_res20[0] = 0;
        if (!this.inited) {
          AreaController.InitAreaGround(this,0);
          this.inited = 1;
        }
        this.areaData = targetAreaData;
        local_748 = plVar24;
        il2cpp_internal(plVar24,targetAreaData);
        if ((*pStatics_e188 != 0) &&
           (lVar8 = *(int64 *)(*pStatics_e188 + 32)) != null) {
          GameObject.SetActive(lVar8,0,0);
          if ((*pStatics_e188 != 0) &&
             (lVar8 = *(int64 *)(*pStatics_e188 + 40)) != null) {
            GameObject.SetActive(lVar8,0,0);
            if ((*pStatics_e188 != 0) &&
               (lVar8 = *(int64 *)(*pStatics_e188 + 48)) != null) {
              GameObject.SetActive(lVar8,1,0);
              lVar8 = *(int64 *)(*(int64 *)(DAT_181d8baa8 + 184) + 16);
              if ((lVar8 != null) && (lVar8 = *(int64 *)(lVar8 + 88)) != null) {
                GameObject.SetActive(lVar8,0,0);
                if (this.areaObj != null) {
                  GameObject.SetActive(this.areaObj,1,0);
                  if (*pStatics_2bf0 != 0) {
                    CloudAnimController.PlayerCloudAnim(*pStatics_2bf0,0);
                    if (this.areaGridRoot != null) {
                      lVar7 = GameObject.get_transform(this.areaGridRoot,0);
                      lVar8 = *plVar24;
                      if (lVar8 != null) {
                        if (lVar7 != null) {
                          local_798 = CONCAT44((float)(*(int *)(lVar8 + 188) + -1) * -0.5 + 0.1,
                                               (float)(*(int *)(lVar8 + 184) + -1) * -0.5);
                          local_790 = 0.0;
                          Transform.set_localPosition(lVar7,&local_798,0);
                          lVar8 = *plVar24;
                          local_res10 = 0;
                          if (lVar8 != null) {
        LAB_180a1f1b0:
                            if (local_res10 < *(int *)(lVar8 + 188)) {
                              iVar3 = 0;
        LAB_180a1f1be:
                              lVar8 = *plVar24;
                              local_7a8 = iVar3;
                              if (lVar8 == null) goto LAB_180a223e6;
                              if (*(int *)(lVar8 + 184) <= iVar3) goto LAB_180a21e5c;
                              iVar21 = *(int *)(lVar8 + 184) * local_res10 + iVar3;
                              if (*(int64 *)(lVar8 + 192) == 0) goto LAB_180a223c8;
                              lVar8 = FUN_180002f80();
                              if (lVar8 == null) {
        LAB_180a21e55:
                                iVar3 = iVar3 + 1;
                                goto LAB_180a1f1be;
                              }
                              if ((this.gridUnits == null) ||
                                 (lVar7 = FUN_180127f50(this.gridUnits,(int64)iVar3,
                                                        (int64)local_res10), local_3f8 = lVar7,
                                 this.gridPool == null)) goto LAB_180a223c8;
                              FUN_181827900();
                              cVar2 = Object.op_Inequality(lVar7);
                              if ((!cVar2) || (*(int *)(lVar8 + 48) == -3)) goto LAB_180a21e55;
                              if (lVar7 == null) goto LAB_180a223c8;
                              lVar9 = FUN_180fa1260(lVar7,0);
                              if (lVar9 == null) goto LAB_180a223c8;
                              GameObject.SetActive(lVar9,1);
                              lVar9 = GameObject.GetComponent(lVar7,DAT_181d9e4d0);
                              if (lVar9 == null) goto LAB_180a223c8;
                              *(int64 *)(lVar9 + 24) = lVar8;
                              if (*(int *)(lVar8 + 48) + 2U < 2) {
                                lVar9 = GameObject.GetComponent(lVar7,DAT_181da19b0);
                                if (lVar9 == null) goto LAB_180a223c8;
                                SpriteRenderer.set_sprite(lVar9,0);
                              }
                              else {
                                lVar9 = GameObject.GetComponent(lVar7);
                                lVar10 = FUN_18046c6c0(0);
                                if ((lVar10 == null) ||
                                   (uVar11 = TextureController.LoadAtlasSprite(lVar10,"TileAtlas"),
                                   lVar9 == null)) goto LAB_180a223c8;
                                SpriteRenderer.set_sprite(lVar9,uVar11);
                                if (lVar8.Count == null) goto LAB_180a223c8;
                                cVar2 = String.Contains(lVar8.Count,"Grass");
                                if (!cVar2) {
                                  if (lVar8.Count == null) goto LAB_180a223c8;
                                  cVar2 = String.Contains(lVar8.Count,"Road");
                                  if (cVar2) {
                                    lVar9 = GameObject.get_transform(lVar7,0);
                                    lVar10 = GameObject.get_transform(lVar7,0);
                                    if (lVar10 != null) {
                                      puVar12 = (uint32 *)
                                                Transform.get_localPosition(local_198,lVar10);
                                      uVar5 = *puVar12;
                                      lVar10 = GameObject.get_transform(lVar7,0);
                                      if (lVar10 != null) {
                                        puVar13 = (uint64 *)
                                                  Transform.get_localPosition(local_188,lVar10);
                                        local_708 = 0;
                                        local_7b8 = *puVar13;
                                        uStack_70c = (uint32)((uint64)local_7b8 >> 32);
                                        uStack_7b0 = CONCAT44(uStack_7b0._4_4_,
                                                              *(uint32 *)(puVar13 + 1));
                                        local_710 = uVar5;
                                        if (lVar9 != null) {
                                          local_3e8 = CONCAT44(uStack_70c,uVar5);
                                          puVar13 = &local_3e8;
                                          local_3e0 = 0;
                                          goto LAB_180a1f4dd;
                                        }
                                      }
                                    }
                                    goto LAB_180a223c8;
                                  }
                                }
                                else {
                                  lVar9 = GameObject.get_transform(lVar7,0);
                                  lVar10 = GameObject.get_transform(lVar7,0);
                                  if (lVar10 == null) goto LAB_180a223c8;
                                  puVar12 = (uint32 *)Transform.get_localPosition(local_178,lVar10);
                                  uVar5 = *puVar12;
                                  lVar10 = GameObject.get_transform(lVar7,0);
                                  if (lVar10 == null) goto LAB_180a223c8;
                                  puVar13 = (uint64 *)Transform.get_localPosition(local_168,lVar10);
                                  local_6f8 = 0xbc23d70a;
                                  local_7b8 = *puVar13;
                                  uStack_6fc = (uint32)((uint64)local_7b8 >> 32);
                                  uStack_7b0 = CONCAT44(uStack_7b0._4_4_,*(uint32 *)(puVar13 + 1));
                                  local_700 = uVar5;
                                  if (lVar9 == null) goto LAB_180a223c8;
                                  local_3d8 = CONCAT44(uStack_6fc,uVar5);
                                  puVar13 = &local_3d8;
                                  local_3d0 = 0xbc23d70a;
        LAB_180a1f4dd:
                                  Transform.set_localPosition(lVar9,puVar13,0);
                                }
                                iVar3 = *(int *)(lVar8 + 32);
                                if (iVar3 == 0) {
                                  lVar9 = GameObject.get_transform(lVar7,0);
                                  puVar14 = (uint64 *)Vector3.get_zero(local_158,0);
                                  puVar13 = &local_3c8;
                                  local_3c0 = *(uint32 *)(puVar14 + 1);
                                  local_3c8 = *puVar14;
                                  puVar20 = local_118;
        LAB_180a1f59f:
                                  puVar13 = (uint64 *)Quaternion.Euler(puVar20,puVar13);
                                  if (lVar9 == null) goto LAB_180a223c8;
                                  local_7b8 = *puVar13;
                                  uStack_7b0 = puVar13[1];
                                  Transform.set_localRotation(lVar9,&local_7b8);
                                }
                                else {
                                  if (iVar3 == 1) {
                                    lVar9 = GameObject.get_transform(lVar7,0);
                                    local_628 = 0;
                                    puVar13 = &local_628;
                                    local_620 = 0x42b40000;
                                    puVar20 = local_128;
                                    goto LAB_180a1f59f;
                                  }
                                  if (iVar3 == 2) {
                                    lVar9 = GameObject.get_transform(lVar7,0);
                                    local_638 = 0;
                                    puVar13 = &local_638;
                                    local_630 = 0x43340000;
                                    puVar20 = local_138;
                                    goto LAB_180a1f59f;
                                  }
                                }
                                lVar9 = GameObject.GetComponent(lVar7,DAT_181da19b0);
                                if (lVar9 == null) goto LAB_180a223c8;
                                SpriteRenderer.set_flipX(lVar9,*(uint8 *)(lVar8 + 36));
                                lVar9 = GameObject.GetComponent(lVar7,DAT_181da19b0);
                                if (lVar9 == null) goto LAB_180a223c8;
                                SpriteRenderer.set_flipY(lVar9,*(uint8 *)(lVar8 + 37));
                                iVar3 = local_7a8;
                              }
                              AreaController.GenerateTileBuilding(this,iVar21);
                              iVar21 = *(int *)(lVar8 + 48);
                              if (iVar21 == 1) {
                                if (*(int64 *)(lVar8 + 40) == 0) {
                                  lVar9 = GameObject.GetComponent(lVar7,DAT_181d9eaa8);
                                  if (lVar9 == null) goto LAB_180a223c8;
                                  Collider.set_enabled(lVar9,1,0);
                                  lVar7 = GameObject.get_transform(lVar7,0);
                                  if (((lVar7 == null) ||
                                      (lVar7 = Transform.Find(lVar7,"CityWall",0)) == null) ||
                                     (lVar7 = Component.get_gameObject(lVar7,0)) == null)
                                  goto LAB_180a223c8;
                                  GameObject.SetActive(lVar7,0,0);
                                  if (*plVar24 == 0) goto LAB_180a223c8;
                                  lVar7 = AreaData.GetTile(*plVar24,*(uint32 *)(lVar8 + 72),
                                                            *(int *)(lVar8 + 68) + -1);
                                  if (lVar7 == null) {
        LAB_180a1f728:
                                    if (*plVar24 == 0) goto LAB_180a223c8;
                                    lVar7 = AreaData.GetTile(*plVar24,*(uint32 *)(lVar8 + 72));
                                    if (lVar7 == null) {
                                      bVar26 = false;
                                    }
                                    else {
                                      if ((*plVar24 == 0) ||
                                         (lVar7 = AreaData.GetTile(*plVar24,*(uint32 *)(lVar8 + 72)
                                                                   ), lVar7 == null)) goto LAB_180a223c8;
                                      bVar26 = *(int *)(lVar7 + 48) == 1;
                                    }
                                  }
                                  else {
                                    if ((*plVar24 == 0) ||
                                       (lVar7 = AreaData.GetTile(*plVar24,*(uint32 *)(lVar8 + 72)),
                                       lVar7 == null)) goto LAB_180a223c8;
                                    if (*(int *)(lVar7 + 48) != 1) goto LAB_180a1f728;
                                    bVar26 = true;
                                  }
                                  fVar27 = (float)Random.Range();
                                  if (*(int64 *)(lVar8 + 56) == 0) goto LAB_180a223c8;
                                  iVar3 = Mathf.RoundToInt((float)*(int *)(*(int64 *)(lVar8 + 56) +
                                                                           20) * 0.5 + fVar27,0);
                                  fVar27 = (float)Random.get_value(0);
                                  if (0.5 <= fVar27) {
                                    iVar21 = Mathf.CeilToInt();
                                  }
                                  else {
                                    iVar21 = Mathf.FloorToInt();
                                  }
                                  iVar4 = FUN_180d8cf10(0xffffffff);
                                  iVar21 = Mathf.Clamp(iVar4 + iVar21);
                                  iVar4 = 0;
                                  if (0 < iVar3) {
                                    do {
                                      if (bVar26) {
                                        lVar8 = *(int64 *)(pStatics_7630 + 24);
                                      }
                                      else if (iVar4 < iVar21) {
                                        lVar8 = *(int64 *)(pStatics_7630 + 32);
                                      }
                                      else {
                                        lVar8 = *(int64 *)(pStatics_7630 + 40);
                                      }
                                      if (((this.areaGridRoot == null) ||
                                          (lVar7 = GameObject.get_transform
                                                             (this.areaGridRoot,0), lVar7 == null
                                          )) || (lVar7 = Transform.Find(lVar7,"RoadDecoration",0),
                                                lVar7 == null)) goto LAB_180a223c8;
                                      uVar11 = Component.get_gameObject(lVar7,0);
                                      lVar7 = FUN_18046c6c0(0);
                                      if (lVar8 == null) goto LAB_180a223c8;
                                      uVar5 = FUN_180d8cf10(0,lVar8.Count,0);
                                      uVar15 = FUN_180002f80(lVar8,uVar5,DAT_181d7c9c0);
                                      if (lVar7 == null) goto LAB_180a223c8;
                                      uVar15 = TextureController.LoadAtlasSprite
                                                         (lVar7,"TileAtlas",uVar15,0);
                                      local_7b8 = 0;
                                      uStack_7b0 = 0;
                                      local_778 = 0;
                                      uStack_770 = 0;
                                      lVar8 = GlobalData.AddSprite
                                                        (uVar11,"RoadDecoration",uVar15,&local_778,&local_7b8
                                                         ,0);
                                      this.newObj = lVar8;
                                      if (*plVar24 == 0) goto LAB_180a223c8;
                                      lVar8 = GameObject.get_transform(*plVar24,0);
                                      fVar27 = (float)Random.get_value(0);
                                      iVar6 = 1;
                                      if (0.5 <= fVar27) {
                                        iVar6 = -1;
                                      }
                                      fVar27 = (float)Random.Range();
                                      fStack_6ec = fVar27 / 1.5;
                                      local_6f0 = ((float)iVar6 * fVar27) / 1.5;
                                      local_6e8 = fStack_6ec;
                                      if (lVar8 == null) goto LAB_180a223c8;
                                      local_3b8 = CONCAT44(fStack_6ec,local_6f0);
                                      local_3b0 = fStack_6ec;
                                      Transform.set_localScale(lVar8,&local_3b8,0);
                                      iVar6 = iVar21;
                                      iVar22 = iVar4;
                                      if (iVar21 <= iVar4) {
                                        iVar6 = iVar3 - iVar21;
                                        iVar22 = iVar4 - iVar21;
                                      }
                                      fVar27 = (float)Random.Range();
                                      fVar27 = fVar27 + ((float)iVar22 * (1.0 / (float)iVar6) - 0.5);
                                      if (*plVar24 == 0) goto LAB_180a223c8;
                                      lVar8 = GameObject.get_transform(*plVar24,0);
                                      lVar7 = GameObject.get_transform(local_3f8,0);
                                      if (lVar7 == null) goto LAB_180a223c8;
                                      puVar13 = (uint64 *)
                                                Transform.get_localPosition(local_148,lVar7,0);
                                      if (bVar26) {
                                        if (iVar4 < iVar21) {
                                          uVar11 = CONCAT44(fVar27,0xbeb33333);
                                          local_320 = 0;
                                        }
                                        else {
                                          local_320 = 0;
                                          uVar11 = CONCAT44(fVar27,0x3eb33333);
                                        }
                                      }
                                      else {
                                        if (iVar4 < iVar21) {
                                          uVar5 = 0x3e800000;
                                        }
                                        else {
                                          uVar5 = 0xbee66666;
                                        }
                                        local_310 = 0;
                                        uVar11 = CONCAT44(uVar5,fVar27);
                                      }
                                      local_7b8 = *puVar13;
                                      local_590 = *(float *)(puVar13 + 1);
                                      local_730._0_4_ = (float)uVar11;
                                      local_730._4_4_ = (float)((uint64)uVar11 >> 32);
                                      local_6e0 = (float)local_730 + (float)local_7b8;
                                      fStack_6dc = local_730._4_4_ + (float)((uint64)local_7b8 >> 32)
                                      ;
                                      local_6d8 = local_590 + 0.0;
                                      uStack_7b0 = CONCAT44((int)((uint64)uStack_7b0 >> 32),local_590
                                                           );
                                      local_730 = uVar11;
                                      if (lVar8 == null) goto LAB_180a223c8;
                                      local_588 = CONCAT44(fStack_6dc,local_6e0);
                                      local_580 = local_6d8;
                                      Transform.set_localPosition(lVar8,&local_588,0);
                                      if (*plVar24 == 0) goto LAB_180a223c8;
                                      lVar8 = GameObject.get_transform(*plVar24,0);
                                      if ((*plVar24 == 0) ||
                                         (lVar7 = GameObject.get_transform(*plVar24,0)) == null)
                                      goto LAB_180a223c8;
                                      puVar13 = (uint64 *)
                                                Transform.get_localPosition(local_2f8,lVar7,0);
                                      uVar11 = *puVar13;
                                      uVar5 = *(uint32 *)(puVar13 + 1);
                                      if ((*plVar24 == 0) ||
                                         (lVar7 = GameObject.get_transform(*plVar24,0)) == null)
                                      goto LAB_180a223c8;
                                      puVar13 = (uint64 *)
                                                Transform.get_localPosition(local_2e8,lVar7,0);
                                      local_7b8 = *puVar13;
                                      uStack_7b0 = CONCAT44(uStack_7b0._4_4_,*(uint32 *)(puVar13 + 1))
                                      ;
                                      local_578 = uVar11;
                                      local_570 = uVar5;
                                      puVar13 = (uint64 *)GlobalData.SetZ(local_2d8,&local_578);
                                      if (lVar8 == null) goto LAB_180a223c8;
                                      local_568 = *puVar13;
                                      local_560 = *(uint32 *)(puVar13 + 1);
                                      Transform.set_localPosition(lVar8,&local_568,0);
                                      lVar8 = this.decorations;
                                      if ((*plVar24 == 0) || (FUN_180fa1260(*plVar24,0), lVar8 == null))
                                      goto LAB_180a223c8;
                                      FUN_181827900(lVar8);
                                      iVar4 = iVar4 + 1;
                                    } while (iVar4 < iVar3);
                                  }
        LAB_180a1fd2e:
                                  iVar3 = local_7a8 + 1;
                                  plVar24 = local_748;
                                }
                                else {
        LAB_180a1fd56:
                                  lVar8 = GameObject.GetComponent(lVar7,DAT_181d9eaa8);
                                  if (lVar8 == null) goto LAB_180a223e6;
                                  Collider.set_enabled(lVar8,1);
                                  lVar8 = GameObject.get_transform(lVar7,0);
                                  if (((lVar8 == null) || (lVar8 = Transform.Find(lVar8)) == null) ||
                                     (lVar8 = Component.get_gameObject(lVar8)) == null)
                                  goto LAB_180a223e6;
                                  GameObject.SetActive(lVar8);
                                  iVar3 = iVar3 + 1;
                                }
                                goto LAB_180a1f1be;
                              }
                              if ((iVar21 != -1) && (iVar21 != -2)) goto LAB_180a1fd56;
                              puVar13 = (uint64 *)Vector3.get_one(local_2c8,0);
                              local_550 = *(float *)(puVar13 + 1);
                              local_7b8 = *puVar13;
                              fVar27 = local_550 / 1.5;
                              uStack_7b0 = CONCAT44((int)((uint64)uStack_7b0 >> 32),local_550);
                              fVar31 = (float)local_7b8 / 1.5;
                              fVar30 = (float)((uint64)local_7b8 >> 32) / 1.5;
                              local_300 = fVar27;
                              lVar9 = GameObject.GetComponent(lVar7,DAT_181d9eaa8);
                              if (lVar9 == null) goto LAB_180a223c8;
                              Collider.set_enabled(lVar9,0,0);
                              lVar9 = GameObject.get_transform(lVar7,0);
                              if ((lVar9 == null) ||
                                 (lVar9 = Transform.Find(lVar9,"CityWall",0)) == null)
                              goto LAB_180a223c8;
                              lVar9 = Component.get_gameObject(lVar9,0);
                              if (lVar9 == null) goto LAB_180a223c8;
                              GameObject.SetActive(lVar9,1,0);
                              if (*plVar24 == 0) goto LAB_180a223c8;
                              uVar11 = Int32.ToString(*plVar24 + 72,0);
                              uVar11 = String.Concat("wall",uVar11,"_",0);
                              if (*plVar24 == 0) goto LAB_180a223c8;
                              lVar9 = AreaData.GetTile(*plVar24,*(int *)(lVar8 + 72) + -1,
                                                        *(uint32 *)(lVar8 + 68),0);
                              if (lVar9 == null) {
        LAB_180a20053:
                                if (*plVar24 == 0) goto LAB_180a223c8;
                                lVar9 = AreaData.GetTile(*plVar24,*(uint32 *)(lVar8 + 72),
                                                          *(int *)(lVar8 + 68) + -1,0);
                                if (lVar9 != null) {
                                  if ((*plVar24 == 0) ||
                                     (lVar9 = AreaData.GetTile(*plVar24,*(uint32 *)(lVar8 + 72),
                                                                *(int *)(lVar8 + 68) + -1,0), lVar9 == null
                                     )) goto LAB_180a223c8;
                                  if (*(int *)(lVar9 + 48) != -1) {
                                    if ((*plVar24 == 0) ||
                                       (lVar9 = AreaData.GetTile(*plVar24,*(uint32 *)(lVar8 + 72),
                                                                  *(int *)(lVar8 + 68) + -1,0),
                                       lVar9 == null)) goto LAB_180a223c8;
                                    if (*(int *)(lVar9 + 48) != -2) goto LAB_180a2025f;
                                  }
                                  if (*plVar24 == 0) goto LAB_180a223c8;
                                  lVar9 = AreaData.GetTile(*plVar24,*(uint32 *)(lVar8 + 72),
                                                            *(int *)(lVar8 + 68) + 1,0);
                                  if (lVar9 == null) goto LAB_180a2025f;
                                  if ((*plVar24 == 0) ||
                                     (lVar9 = AreaData.GetTile(*plVar24,*(uint32 *)(lVar8 + 72),
                                                                *(int *)(lVar8 + 68) + 1,0), lVar9 == null)
                                     ) goto LAB_180a223c8;
                                  if (*(int *)(lVar9 + 48) != -1) {
                                    if ((*plVar24 == 0) ||
                                       (lVar9 = AreaData.GetTile(*plVar24,*(uint32 *)(lVar8 + 72),
                                                                  *(int *)(lVar8 + 68) + 1,0),
                                       lVar9 == null)) goto LAB_180a223c8;
                                    if (*(int *)(lVar9 + 48) != -2) goto LAB_180a2025f;
                                  }
                                  uVar11 = String.Concat(uVar11,"1",0);
                                  if (*plVar24 == 0) goto LAB_180a223c8;
                                  lVar9 = AreaData.GetTile(*plVar24,*(int *)(lVar8 + 72) + 1,
                                                            *(uint32 *)(lVar8 + 68),0);
                                  if (lVar9 != null) {
                                    if ((*plVar24 == 0) ||
                                       (lVar9 = AreaData.GetTile(*plVar24,*(int *)(lVar8 + 72) + 1,
                                                                  *(uint32 *)(lVar8 + 68),0),
                                       lVar9 == null)) goto LAB_180a223c8;
                                    if (*(int *)(lVar9 + 48) != -3) {
                                      local_540 = *(float *)(pStatics_ef00 + 0x15c);
                                      local_7b8 = *(uint64 *)
                                                   (pStatics_ef00 + 0x154);
                                      fVar27 = local_540 / 1.5;
                                      uStack_7b0 = CONCAT44((int)((uint64)uStack_7b0 >> 32),local_540
                                                           );
                                      fVar31 = (float)local_7b8 / 1.5;
                                      fVar30 = (float)((uint64)local_7b8 >> 32) / 1.5;
                                      local_360 = fVar27;
                                    }
                                  }
                                  goto LAB_180a20819;
                                }
        LAB_180a2025f:
                                if (*plVar24 == 0) goto LAB_180a223c8;
                                lVar9 = AreaData.GetTile(*plVar24,*(uint32 *)(lVar8 + 72),
                                                          *(int *)(lVar8 + 68) + 1,0);
                                if (lVar9 == null) {
        LAB_180a20580:
                                  if (*plVar24 == 0) goto LAB_180a223c8;
                                  lVar9 = AreaData.GetTile(*plVar24,*(int *)(lVar8 + 72) + -1,
                                                            *(uint32 *)(lVar8 + 68),0);
                                  if (lVar9 != null) {
                                    if ((*plVar24 == 0) ||
                                       (lVar9 = AreaData.GetTile(*plVar24,*(int *)(lVar8 + 72) + -1,
                                                                  *(uint32 *)(lVar8 + 68),0),
                                       lVar9 == null)) goto LAB_180a223c8;
                                    if (*(int *)(lVar9 + 48) != -1) {
                                      if ((*plVar24 == 0) ||
                                         (lVar9 = AreaData.GetTile(*plVar24,*(int *)(lVar8 + 72) + -1,
                                                                    *(uint32 *)(lVar8 + 68),0),
                                         lVar9 == null)) goto LAB_180a223c8;
                                      if (*(int *)(lVar9 + 48) != -2) goto LAB_180a2070b;
                                    }
                                    if (*plVar24 == 0) goto LAB_180a223c8;
                                    lVar9 = AreaData.GetTile(*plVar24,*(int *)(lVar8 + 72) + -1,
                                                              *(int *)(lVar8 + 68) + -1,0);
                                    if (lVar9 != null) {
                                      if ((*plVar24 == 0) ||
                                         (lVar9 = AreaData.GetTile(*plVar24,*(int *)(lVar8 + 72) + -1,
                                                                    *(int *)(lVar8 + 68) + -1,0),
                                         lVar9 == null)) goto LAB_180a223c8;
                                      uVar15 = "2";
                                      if (*(int *)(lVar9 + 48) != -3) goto LAB_180a2080b;
                                    }
                                    uVar11 = String.Concat(uVar11,"5",0);
                                    local_510 = *(float *)(pStatics_ef00 + 0x15c);
                                    local_7b8 = *(uint64 *)
                                                 (pStatics_ef00 + 0x154);
                                    fVar27 = local_510 / 1.5;
                                    uStack_7b0 = CONCAT44((int)((uint64)uStack_7b0 >> 32),local_510);
                                    fVar31 = (float)local_7b8 / 1.5;
                                    fVar30 = (float)((uint64)local_7b8 >> 32) / 1.5;
                                    local_330 = fVar27;
                                    goto LAB_180a20819;
                                  }
        LAB_180a2070b:
                                  if (*plVar24 == 0) goto LAB_180a223c8;
                                  lVar9 = AreaData.GetTile(*plVar24,*(int *)(lVar8 + 72) + 1,
                                                            *(int *)(lVar8 + 68) + -1,0);
                                  uVar15 = "5";
                                  if (lVar9 == null) goto LAB_180a2080b;
                                  if ((*plVar24 == 0) ||
                                     (lVar9 = AreaData.GetTile(*plVar24,*(int *)(lVar8 + 72) + 1,
                                                                *(int *)(lVar8 + 68) + -1,0), lVar9 == null
                                     )) goto LAB_180a223c8;
                                  uVar15 = "5";
                                  if (*(int *)(lVar9 + 48) != -3) {
                                    uVar11 = String.Concat(uVar11,"2",0);
                                    local_500 = *(float *)(pStatics_ef00 + 0x15c);
                                    local_7b8 = *(uint64 *)
                                                 (pStatics_ef00 + 0x154);
                                    fVar27 = local_500 / 1.5;
                                    uStack_7b0 = CONCAT44((int)((uint64)uStack_7b0 >> 32),local_500);
                                    fVar31 = (float)local_7b8 / 1.5;
                                    fVar30 = (float)((uint64)local_7b8 >> 32) / 1.5;
                                    local_718 = fVar27;
                                    goto LAB_180a20819;
                                  }
                                }
                                else {
                                  if ((*plVar24 == 0) ||
                                     (lVar9 = AreaData.GetTile(*plVar24,*(uint32 *)(lVar8 + 72),
                                                                *(int *)(lVar8 + 68) + 1,0), lVar9 == null)
                                     ) goto LAB_180a223c8;
                                  if (*(int *)(lVar9 + 48) != -1) {
                                    if ((*plVar24 == 0) ||
                                       (lVar9 = AreaData.GetTile(*plVar24,*(uint32 *)(lVar8 + 72),
                                                                  *(int *)(lVar8 + 68) + 1,0),
                                       lVar9 == null)) goto LAB_180a223c8;
                                    if (*(int *)(lVar9 + 48) != -2) goto LAB_180a20580;
                                  }
                                  if (*plVar24 == 0) goto LAB_180a223c8;
                                  lVar9 = AreaData.GetTile(*plVar24,*(int *)(lVar8 + 72) + -1,
                                                            *(uint32 *)(lVar8 + 68),0);
                                  if (lVar9 != null) {
                                    if ((*plVar24 == 0) ||
                                       (lVar9 = AreaData.GetTile(*plVar24,*(int *)(lVar8 + 72) + -1,
                                                                  *(uint32 *)(lVar8 + 68),0),
                                       lVar9 == null)) goto LAB_180a223c8;
                                    if (*(int *)(lVar9 + 48) != -1) {
                                      if ((*plVar24 == 0) ||
                                         (lVar9 = AreaData.GetTile(*plVar24,*(int *)(lVar8 + 72) + -1,
                                                                    *(uint32 *)(lVar8 + 68),0),
                                         lVar9 == null)) goto LAB_180a223c8;
                                      if (*(int *)(lVar9 + 48) != -2) goto LAB_180a20472;
                                    }
                                    if (*plVar24 == 0) goto LAB_180a223c8;
                                    lVar9 = AreaData.GetTile(*plVar24,*(int *)(lVar8 + 72) + -1,
                                                              *(int *)(lVar8 + 68) + 1,0);
                                    if (lVar9 != null) {
                                      if ((*plVar24 == 0) ||
                                         (lVar9 = AreaData.GetTile(*plVar24,*(int *)(lVar8 + 72) + -1,
                                                                    *(int *)(lVar8 + 68) + 1,0),
                                         lVar9 == null)) goto LAB_180a223c8;
                                      uVar15 = "3";
                                      if (*(int *)(lVar9 + 48) != -3) goto LAB_180a2080b;
                                    }
                                    uVar11 = String.Concat(uVar11,"4",0);
                                    local_530 = *(float *)(pStatics_ef00 + 0x15c);
                                    local_7b8 = *(uint64 *)
                                                 (pStatics_ef00 + 0x154);
                                    fVar27 = local_530 / 1.5;
                                    uStack_7b0 = CONCAT44((int)((uint64)uStack_7b0 >> 32),local_530);
                                    fVar31 = (float)local_7b8 / 1.5;
                                    fVar30 = (float)((uint64)local_7b8 >> 32) / 1.5;
                                    local_350 = fVar27;
                                    goto LAB_180a20819;
                                  }
        LAB_180a20472:
                                  if (*plVar24 == 0) goto LAB_180a223c8;
                                  lVar9 = AreaData.GetTile(*plVar24,*(int *)(lVar8 + 72) + 1,
                                                            *(int *)(lVar8 + 68) + 1,0);
                                  uVar15 = "4";
                                  if (lVar9 != null) {
                                    if ((*plVar24 == 0) ||
                                       (lVar9 = AreaData.GetTile(*plVar24,*(int *)(lVar8 + 72) + 1,
                                                                  *(int *)(lVar8 + 68) + 1,0),
                                       lVar9 == null)) goto LAB_180a223c8;
                                    uVar15 = "4";
                                    if (*(int *)(lVar9 + 48) != -3) {
                                      uVar11 = String.Concat(uVar11,"3",0);
                                      local_520 = *(float *)(pStatics_ef00 + 0x15c);
                                      local_7b8 = *(uint64 *)
                                                   (pStatics_ef00 + 0x154);
                                      fVar27 = local_520 / 1.5;
                                      uStack_7b0 = CONCAT44((int)((uint64)uStack_7b0 >> 32),local_520
                                                           );
                                      fVar31 = (float)local_7b8 / 1.5;
                                      fVar30 = (float)((uint64)local_7b8 >> 32) / 1.5;
                                      local_340 = fVar27;
                                      goto LAB_180a20819;
                                    }
                                  }
                                }
                              }
                              else {
                                if ((*plVar24 == 0) ||
                                   (lVar9 = AreaData.GetTile(*plVar24,*(int *)(lVar8 + 72) + -1,
                                                              *(uint32 *)(lVar8 + 68),0), lVar9 == null
                                   )) goto LAB_180a223c8;
                                if (*(int *)(lVar9 + 48) != -1) {
                                  if ((*plVar24 == 0) ||
                                     (lVar9 = AreaData.GetTile(*plVar24,*(int *)(lVar8 + 72) + -1,
                                                                *(uint32 *)(lVar8 + 68),0),
                                     lVar9 == null)) goto LAB_180a223c8;
                                  if (*(int *)(lVar9 + 48) != -2) goto LAB_180a20053;
                                }
                                if (*plVar24 == 0) goto LAB_180a223c8;
                                lVar9 = AreaData.GetTile(*plVar24,*(int *)(lVar8 + 72) + 1,
                                                          *(uint32 *)(lVar8 + 68),0);
                                if (lVar9 == null) goto LAB_180a20053;
                                if ((*plVar24 == 0) ||
                                   (lVar9 = AreaData.GetTile(*plVar24,*(int *)(lVar8 + 72) + 1,
                                                              *(uint32 *)(lVar8 + 68),0), lVar9 == null
                                   )) goto LAB_180a223c8;
                                if (*(int *)(lVar9 + 48) != -1) {
                                  if ((*plVar24 == 0) ||
                                     (lVar9 = AreaData.GetTile(*plVar24,*(int *)(lVar8 + 72) + 1,
                                                                *(uint32 *)(lVar8 + 68),0),
                                     lVar9 == null)) goto LAB_180a223c8;
                                  if (*(int *)(lVar9 + 48) != -2) goto LAB_180a20053;
                                }
                                if (*plVar24 == 0) goto LAB_180a223c8;
                                lVar9 = AreaData.GetTile(*plVar24,*(uint32 *)(lVar8 + 72),
                                                          *(int *)(lVar8 + 68) + 1,0);
                                uVar15 = "-1";
                                if (lVar9 != null) {
                                  if ((*plVar24 != 0) &&
                                     (lVar9 = AreaData.GetTile(*plVar24,*(uint32 *)(lVar8 + 72),
                                                                *(int *)(lVar8 + 68) + 1,0), lVar9 != null)
                                     ) {
                                    uVar15 = "-1";
                                    if (*(int *)(lVar9 + 48) != -3) {
                                      uVar15 = "0";
                                    }
                                    goto LAB_180a2080b;
                                  }
                                  goto LAB_180a223c8;
                                }
                              }
        LAB_180a2080b:
                              uVar11 = String.Concat(uVar11,uVar15,0);
        LAB_180a20819:
                              if ((*plVar24 == 0) ||
                                 (lVar9 = AreaData.GetCenterBuilding(*plVar24,0)) == null) {
        LAB_180a223e0:
                          // WARNING: Subroutine does not return
                                FUN_1800d6620();
                              }
                              local_res20[0] = (int)((float)*(int *)(lVar9 + 20) / 3.0);
                              uVar15 = Int32.ToString(local_res20,0);
                              uVar11 = String.Concat(uVar11,"_",uVar15,0);
                              lVar9 = GameObject.get_transform(lVar7,0);
                              if ((lVar9 == null) ||
                                 (lVar9 = Transform.Find(lVar9,"CityWall",0)) == null)
                              goto LAB_180a223e0;
                              uVar15 = Component.get_gameObject(lVar9,0);
                              lVar9 = FUN_18046c6c0(0);
                              if (lVar9 == null) goto LAB_180a223e0;
                              uVar11 = TextureController.LoadAtlasSprite(lVar9,"TileAtlas",uVar11,0);
                              puVar13 = (uint64 *)Vector3.get_zero(local_2b8,0);
                              local_4f0 = *(uint32 *)(puVar13 + 1);
                              local_4f8 = *puVar13;
                              local_398 = 0;
                              uStack_390 = 0;
                              FUN_1815cf310(&local_398,&local_4f8,DAT_181d92dc0);
                              local_3a8 = 0;
                              uStack_3a0 = 0;
                              local_4e8 = fVar31;
                              fStack_4e4 = fVar30;
                              local_4e0 = fVar27;
                              FUN_1815cf310(&local_3a8,&local_4e8,DAT_181d92dc0);
                              local_778 = local_3a8;
                              uStack_770 = uStack_3a0;
                              local_7b8 = local_398;
                              uStack_7b0 = uStack_390;
                              lVar9 = GlobalData.AddSprite
                                                (uVar15,"CityWall",uVar11,&local_7b8,&local_778,0);
                              if (lVar9 == null) goto LAB_180a223e0;
                              lVar9 = GameObject.get_transform(lVar9,0);
                              lVar10 = GameObject.get_transform(lVar7,0);
                              if (lVar10 == null) goto LAB_180a223e0;
                              puVar13 = (uint64 *)Transform.get_localPosition(local_2a8,lVar10);
                              local_7b8 = *puVar13;
                              uStack_7b0 = CONCAT44(uStack_7b0._4_4_,*(uint32 *)(puVar13 + 1));
                              if (lVar9 == null) goto LAB_180a223e0;
                              local_618 = 0;
                              local_610 = (float)((uint64)local_7b8 >> 32) * 0.01 - 1.0;
                              Transform.set_localPosition(lVar9,&local_618,0);
                              iVar3 = local_7a8;
                              if (*(int *)(lVar8 + 48) != -2) goto LAB_180a21e55;
                              if (*plVar24 == 0) goto LAB_180a223c8;
                              uVar11 = Int32.ToString(*plVar24 + 72,0);
                              uVar11 = String.Concat("gate",uVar11,"_",0);
                              if (*plVar24 == 0) goto LAB_180a223c8;
                              lVar9 = AreaData.GetTile(*plVar24,*(int *)(lVar8 + 72) + -1,
                                                        *(uint32 *)(lVar8 + 68),0);
                              if (lVar9 == null) {
        LAB_180a20d95:
                                if (*plVar24 == 0) goto LAB_180a223c8;
                                bVar25 = ((float)*(int *)(*plVar24 + 184) * 0.5 <=
                                         (float)*(int *)(lVar8 + 72)) + 2;
                                uVar15 = String.Concat(uVar11,"2",0);
                                uVar11 = this.areaGridRoot;
                                uVar16 = String.Format("Skeleton/Wall/{0}/skeleton_SkeletonData",uVar15,0);
                                puVar13 = (uint64 *)Vector3.get_one(local_268,0);
                                local_7b8 = *puVar13;
                                local_4a0 = *(float *)(puVar13 + 1);
                                fStack_6ac = (float)((uint64)local_7b8 >> 32) / 1.5;
                                uStack_7b0 = CONCAT44((int)((uint64)uStack_7b0 >> 32),local_4a0);
                                local_6b0 = (float)local_7b8 / 1.5;
                                local_6a8 = local_4a0 / 1.5;
                                if ((*plVar24 == 0) ||
                                   (lVar9 = AreaData.GetCenterBuilding(*plVar24,0)) == null)
                                goto LAB_180a223c8;
                                local_res20[0] = (int)((float)*(int *)(lVar9 + 20) / 3.0);
                                uVar17 = Int32.ToString(local_res20,0);
                                uVar15 = String.Concat(uVar15,"_",uVar17,0);
                                local_498 = CONCAT44(fStack_6ac,local_6b0);
                                local_490 = local_6a8;
                                lVar9 = GlobalData.GenerateSkeletonAnimation
                                                  (uVar11,uVar16,&local_498,"idle",1,uVar15,0);
                                if (lVar9 == null) goto LAB_180a223c8;
                                lVar9 = Component.get_gameObject(lVar9,0);
                                this.newObj = lVar9;
                                if (*plVar24 == 0) goto LAB_180a223c8;
                                if ((float)*(int *)(lVar8 + 72) < (float)*(int *)(*plVar24 + 184) * 0.5
                                   ) {
                                  if (*plVar23 == 0) goto LAB_180a223c8;
                                  lVar9 = GameObject.get_transform(*plVar23,0);
                                  if ((*plVar23 == 0) ||
                                     (lVar10 = GameObject.get_transform(*plVar23,0)) == null)
                                  goto LAB_180a223c8;
                                  puVar18 = (uint32 *)Transform.get_localScale(local_258,lVar10,0);
                                  uVar1 = *puVar18;
                                  if ((*plVar23 == 0) ||
                                     (lVar10 = GameObject.get_transform(*plVar23,0)) == null)
                                  goto LAB_180a223c8;
                                  puVar13 = (uint64 *)Transform.get_localScale(local_248,lVar10,0);
                                  local_488 = *puVar13;
                                  if ((*plVar23 == 0) ||
                                     (lVar10 = GameObject.get_transform(*plVar23,0)) == null)
                                  goto LAB_180a223c8;
                                  lVar10 = Transform.get_localScale(local_238,lVar10,0);
                                  local_6a0 = uVar1 ^ 0x80000000;
                                  local_698 = *(uint32 *)(lVar10 + 8);
                                  uStack_69c = local_488._4_4_;
                                  local_470 = local_698;
                                  if (lVar9 == null) goto LAB_180a223c8;
                                  local_468 = CONCAT44(local_488._4_4_,uVar1) ^ 0x80000000;
                                  local_460 = local_698;
                                  Transform.set_localScale(lVar9,&local_468,0);
                                }
                                if (*plVar23 == 0) goto LAB_180a223c8;
                                lVar9 = GameObject.get_transform(*plVar23,0);
                                lVar10 = GameObject.get_transform(lVar7,0);
                                if (lVar10 == null) goto LAB_180a223c8;
                                puVar12 = (uint32 *)Transform.get_localPosition(local_228,lVar10,0);
                                uVar5 = *puVar12;
                                lVar7 = GameObject.get_transform(lVar7,0);
                                if (lVar7 == null) goto LAB_180a223c8;
                                puVar13 = (uint64 *)Transform.get_localPosition(local_218,lVar7,0);
                                local_688 = 0xc0000000;
                                local_7b8 = *puVar13;
                                uStack_68c = (uint32)((uint64)local_7b8 >> 32);
                                uStack_7b0 = CONCAT44(uStack_7b0._4_4_,*(uint32 *)(puVar13 + 1));
                                local_690 = uVar5;
                                if (lVar9 == null) goto LAB_180a223c8;
                                local_458 = CONCAT44(uStack_68c,uVar5);
                                puVar13 = &local_458;
                                local_450 = 0xc0000000;
                              }
                              else {
                                if ((*plVar24 == 0) ||
                                   (lVar9 = AreaData.GetTile(*plVar24,*(int *)(lVar8 + 72) + -1,
                                                              *(uint32 *)(lVar8 + 68),0), lVar9 == null
                                   )) goto LAB_180a223c8;
                                if (*(int *)(lVar9 + 48) != -1) goto LAB_180a20d95;
                                if (*plVar24 == 0) goto LAB_180a223c8;
                                lVar9 = AreaData.GetTile(*plVar24,*(int *)(lVar8 + 72) + 1,
                                                          *(uint32 *)(lVar8 + 68),0);
                                if (lVar9 == null) goto LAB_180a20d95;
                                if ((*plVar24 == 0) ||
                                   (lVar9 = AreaData.GetTile(*plVar24,*(int *)(lVar8 + 72) + 1,
                                                              *(uint32 *)(lVar8 + 68),0), lVar9 == null
                                   )) goto LAB_180a223c8;
                                if (*(int *)(lVar9 + 48) != -1) goto LAB_180a20d95;
                                if (*plVar24 == 0) goto LAB_180a223c8;
                                fVar27 = (float)*(int *)(*plVar24 + 188) * 0.5;
                                bVar25 = fVar27 <= (float)*(int *)(lVar8 + 68);
                                uVar15 = "1";
                                if ((float)*(int *)(lVar8 + 68) < fVar27) {
                                  uVar15 = "0";
                                }
                                uVar15 = String.Concat(uVar11,uVar15,0);
                                uVar11 = this.areaGridRoot;
                                uVar16 = String.Format("Skeleton/Wall/{0}/skeleton_SkeletonData",uVar15,0);
                                puVar13 = (uint64 *)Vector3.get_one(local_298,0);
                                local_7b8 = *puVar13;
                                local_4d0 = *(float *)(puVar13 + 1);
                                fStack_6cc = (float)((uint64)local_7b8 >> 32) / 1.5;
                                uStack_7b0 = CONCAT44((int)((uint64)uStack_7b0 >> 32),local_4d0);
                                local_6d0 = (float)local_7b8 / 1.5;
                                local_6c8 = local_4d0 / 1.5;
                                if ((*plVar24 == 0) ||
                                   (lVar9 = AreaData.GetCenterBuilding(*plVar24,0)) == null)
                                goto LAB_180a223c8;
                                local_res20[0] = (int)((float)*(int *)(lVar9 + 20) / 3.0);
                                uVar17 = Int32.ToString(local_res20,0);
                                uVar15 = String.Concat(uVar15,"_",uVar17,0);
                                local_4c8 = CONCAT44(fStack_6cc,local_6d0);
                                local_4c0 = local_6c8;
                                lVar9 = GlobalData.GenerateSkeletonAnimation
                                                  (uVar11,uVar16,&local_4c8,"idle",1,uVar15,0);
                                if (lVar9 == null) goto LAB_180a223c8;
                                lVar9 = Component.get_gameObject(lVar9,0);
                                this.newObj = lVar9;
                                if (*plVar23 == 0) goto LAB_180a223c8;
                                lVar9 = GameObject.get_transform(*plVar23,0);
                                lVar10 = GameObject.get_transform(lVar7,0);
                                if (lVar10 == null) goto LAB_180a223c8;
                                puVar12 = (uint32 *)Transform.get_localPosition(local_288,lVar10,0);
                                uVar5 = *puVar12;
                                lVar7 = GameObject.get_transform(lVar7,0);
                                if (lVar7 == null) goto LAB_180a223c8;
                                puVar13 = (uint64 *)Transform.get_localPosition(local_278,lVar7,0);
                                local_6b8 = 0xc0000000;
                                local_7b8 = *puVar13;
                                uStack_6bc = (uint32)((uint64)local_7b8 >> 32);
                                uStack_7b0 = CONCAT44(uStack_7b0._4_4_,*(uint32 *)(puVar13 + 1));
                                local_6c0 = uVar5;
                                if (lVar9 == null) goto LAB_180a223c8;
                                local_4b8 = CONCAT44(uStack_6bc,uVar5);
                                puVar13 = &local_4b8;
                                local_4b0 = 0xc0000000;
                              }
                              plVar23 = &this.newObj;
                              Transform.set_localPosition(lVar9,puVar13,0);
                              if (this.newObj == null) {
                          // WARNING: Subroutine does not return
                                FUN_1800d6620();
                              }
                              GameObject.AddComponent(this.newObj,DAT_181d9c028);
                              if (this.newObj == null) {
        LAB_180a223d4:
                          // WARNING: Subroutine does not return
                                FUN_1800d6620();
                              }
                              lVar7 = GameObject.GetComponent(this.newObj,DAT_181d9eaa8);
                              puVar13 = (uint64 *)Vector3.get_zero(local_208,0);
                              if (lVar7 == null) goto LAB_180a223d4;
                              local_440 = *(uint32 *)(puVar13 + 1);
                              local_448 = *puVar13;
                              BoxCollider.set_center(lVar7,&local_448,0);
                              if (this.newObj == null) goto LAB_180a223d4;
                              lVar7 = GameObject.GetComponent(this.newObj,DAT_181d9eaa8);
                              puVar13 = (uint64 *)Vector3.get_one(local_1f8,0);
                              local_678 = *(float *)(puVar13 + 1);
                              local_680 = *puVar13;
                              if ((this.newObj == null) ||
                                 (lVar9 = GameObject.get_transform(this.newObj,0)) == null)
                              goto LAB_180a223d4;
                              pfVar19 = (float *)Transform.get_localScale(local_1e8,lVar9,0);
                              local_648 = *pfVar19;
                              local_650 = (float)local_680 / local_648;
                              fStack_64c = local_680._4_4_ / local_648;
                              local_648 = local_678 / local_648;
                              if (lVar7 == null) goto LAB_180a223d4;
                              local_438 = CONCAT44(fStack_64c,local_650);
                              local_430 = local_648;
                              BoxCollider.set_size(lVar7,&local_438,0);
                              if (this.newObj == null) goto LAB_180a223d4;
                              GameObject.AddComponent(this.newObj,DAT_181d9be08);
                              if ((this.newObj == null) ||
                                 (lVar7 = GameObject.AddComponent(this.newObj,DAT_181d9cf90)) == null)
                              goto LAB_180a223d4;
                              *(uint64 *)(lVar7 + 24) = "离开";
                              if ((this.newObj == null) || (lVar7 = FUN_180fa1260(this.newObj,0)) == null)
                              goto LAB_180a223d4;
                              Object.set_name(lVar7,"CityGate",0);
                              if (this.decorations == null) goto LAB_180a223d4;
                              FUN_181827900(this.decorations,this.newObj,DAT_181d61bf8);
                              if (((this.areaGridRoot == null) ||
                                  (lVar7 = GameObject.get_transform(this.areaGridRoot,0),
                                  lVar7 == null)) ||
                                 (lVar7 = Transform.Find(lVar7,"OutsideDecoration",0)) == null)
                              goto LAB_180a223d4;
                              uVar11 = Component.get_gameObject(lVar7,0);
                              lVar7 = FUN_18046c6c0(0);
                              if (*plVar24 == 0) goto LAB_180a223d4;
                              uVar15 = *(uint64 *)(*plVar24 + 48);
                              local_res20[0] = FUN_180d8cf10(0,2);
                              uVar16 = Int32.ToString(local_res20,0);
                              uVar15 = String.Concat("road",uVar15,"_",uVar16,0);
                              if (lVar7 == null) goto LAB_180a223d4;
                              uVar15 = TextureController.LoadAtlasSprite(lVar7,"AreaMapAtlas",uVar15,0);
                              local_778 = 0;
                              uStack_770 = 0;
                              local_7b8 = 0;
                              uStack_7b0 = 0;
                              lVar7 = GlobalData.AddSprite
                                                (uVar11,"AroundRoad",uVar15,&local_7b8,&local_778,0);
                              this.newObj = lVar7;
                              il2cpp_internal(plVar23,lVar7);
                              if (this.newObj == null) goto LAB_180a223d4;
                              lVar7 = GameObject.GetComponent(this.newObj,DAT_181da19b0);
                              local_388 = 0;
                              uStack_380 = 0;
                              FUN_1809981e0(&local_388);
                              if (lVar7 == null) goto LAB_180a223d4;
                              local_778 = local_388;
                              uStack_770 = uStack_380;
                              SpriteRenderer.set_color(lVar7,&local_778,0);
                              if (this.newObj == null) goto LAB_180a223d4;
                              lVar7 = GameObject.get_transform(this.newObj,0);
                              if (bVar25 < 2) {
                                uVar5 = 0x40000000;
                              }
                              else {
                                uVar5 = 0x400ccccd;
                              }
                              if (lVar7 == null) goto LAB_180a223e6;
                              local_604 = 0x40000000;
                              local_600 = 0x40000000;
                              local_608 = uVar5;
                              Transform.set_localScale(lVar7,&local_608,0);
                              if (bVar25 == 0) {
                                if (this.newObj == null) goto LAB_180a223e6;
                                lVar7 = GameObject.get_transform(this.newObj,0);
                                local_5a8 = 0;
                                local_5a0 = 0xc2b40000;
                                puVar13 = (uint64 *)Quaternion.Euler(local_e8,&local_5a8,0);
                                if (lVar7 == null) goto LAB_180a223e6;
                                local_778 = *puVar13;
                                uStack_770 = puVar13[1];
                                Transform.set_localRotation(lVar7,&local_778,0);
                                if (this.newObj == null) goto LAB_180a223e6;
                                lVar7 = GameObject.get_transform(this.newObj,0);
                                if (lVar7 == null) goto LAB_180a223e6;
                                pfVar19 = &local_768;
                                local_760 = 0x41100000;
                                local_768 = (float)*(int *)(lVar8 + 72);
                                local_764 = (float)*(int *)(lVar8 + 68) + 0.5;
        LAB_180a21799:
                                Transform.set_localPosition(lVar7,pfVar19,0);
                              }
                              else {
                                if (bVar25 == 1) {
                                  if (this.newObj != null) {
                                    lVar7 = GameObject.get_transform(this.newObj,0);
                                    local_5c8 = 0;
                                    local_5c0 = 0x42b40000;
                                    puVar13 = (uint64 *)Quaternion.Euler(local_f8,&local_5c8,0);
                                    if (lVar7 != null) {
                                      local_778 = *puVar13;
                                      uStack_770 = puVar13[1];
                                      Transform.set_localRotation(lVar7,&local_778,0);
                                      if (this.newObj != null) {
                                        lVar7 = GameObject.get_transform(this.newObj,0);
                                        if (lVar7 != null) {
                                          pfVar19 = &local_5b8;
                                          local_5b0 = 0x41100000;
                                          local_5b8 = (float)*(int *)(lVar8 + 72);
                                          local_5b4 = (float)*(int *)(lVar8 + 68) - 0.5;
                                          goto LAB_180a21799;
                                        }
                                      }
                                    }
                                  }
                                  goto LAB_180a223e6;
                                }
                                if (bVar25 == 2) {
                                  if (this.newObj != null) {
                                    lVar7 = GameObject.get_transform(this.newObj,0);
                                    local_5e8 = 0;
                                    local_5e0 = 0x43340000;
                                    puVar13 = (uint64 *)Quaternion.Euler(local_108,&local_5e8,0);
                                    if (lVar7 != null) {
                                      local_778 = *puVar13;
                                      uStack_770 = puVar13[1];
                                      Transform.set_localRotation(lVar7,&local_778,0);
                                      if (this.newObj != null) {
                                        lVar7 = GameObject.get_transform(this.newObj,0);
                                        if (lVar7 != null) {
                                          pfVar19 = &local_5d8;
                                          local_5d0 = 0x41100000;
                                          local_5d8 = (float)*(int *)(lVar8 + 72) + 0.5;
                                          local_5d4 = (float)*(int *)(lVar8 + 68);
                                          goto LAB_180a21799;
                                        }
                                      }
                                    }
                                  }
                                  goto LAB_180a223e6;
                                }
                                if (bVar25 == 3) {
                                  if (this.newObj != null) {
                                    lVar7 = GameObject.get_transform(this.newObj,0);
                                    if (lVar7 != null) {
                                      pfVar19 = &local_5f8;
                                      local_5f0 = 0x41100000;
                                      local_5f8 = (float)*(int *)(lVar8 + 72) - 0.5;
                                      local_5f4 = (float)*(int *)(lVar8 + 68);
                                      goto LAB_180a21799;
                                    }
                                  }
                                  goto LAB_180a223e6;
                                }
                              }
                              if (*(int64 *)(this + 200) == 0) goto LAB_180a223e6;
                              FUN_181827900(*(int64 *)(this + 200),this.newObj);
                              iVar3 = FUN_180d8cf10(3);
                              if ((this.newObj == null) ||
                                 (lVar8 = GameObject.get_transform(this.newObj,0)) == null)
                              goto LAB_180a223e6;
                              puVar13 = (uint64 *)Transform.get_localPosition(local_1d8);
                              iVar21 = 0;
                              uVar11 = *puVar13;
                              fVar27 = *(float *)(puVar13 + 1);
                              local_660 = uVar11;
                              local_658 = fVar27;
                              if (iVar3 < 1) goto LAB_180a1fd2e;
                              local_660._4_4_ = (float)((uint64)uVar11 >> 32);
                              fVar31 = local_660._4_4_;
                              local_660._0_4_ = (float)uVar11;
                              fVar30 = (float)local_660;
                              do {
                                fVar33 = -1.0;
                                if (bVar25 < 2) {
                                  lVar8 = *(int64 *)(pStatics_7630 + 24);
                                }
                                else {
                                  fVar28 = (float)Random.get_value(0);
                                  if (0.5 <= fVar28) {
                                    lVar8 = *(int64 *)(pStatics_7630 + 40);
                                  }
                                  else {
                                    lVar8 = *(int64 *)(pStatics_7630 + 32);
                                  }
                                }
                                if (((this.areaGridRoot == null) ||
                                    (lVar7 = GameObject.get_transform(this.areaGridRoot,0),
                                    lVar7 == null)) ||
                                   (lVar7 = Transform.Find(lVar7,"RoadDecoration",0)) == null)
                                goto LAB_180a223e6;
                                uVar11 = Component.get_gameObject(lVar7,0);
                                lVar7 = FUN_18046c6c0(0);
                                if (lVar8 == null) goto LAB_180a223e6;
                                uVar5 = FUN_180d8cf10(0,lVar8.Count,0);
                                uVar15 = FUN_180002f80(lVar8,uVar5,DAT_181d7c9c0);
                                if (lVar7 == null) goto LAB_180a223e6;
                                uVar15 = TextureController.LoadAtlasSprite(lVar7,"TileAtlas",uVar15,0);
                                local_778 = 0;
                                uStack_770 = 0;
                                local_7b8 = 0;
                                uStack_7b0 = 0;
                                lVar8 = GlobalData.AddSprite
                                                  (uVar11,"RoadDecoration",uVar15,&local_7b8,&local_778,0);
                                this.newObj = lVar8;
                                il2cpp_internal(plVar23,lVar8);
                                if (this.newObj == null) goto LAB_180a223e6;
                                lVar8 = GameObject.get_transform(this.newObj,0);
                                fVar28 = (float)Random.get_value(0);
                                iVar4 = 1;
                                if (0.5 <= fVar28) {
                                  iVar4 = -1;
                                }
                                fVar28 = (float)Random.Range();
                                fStack_66c = fVar28 / 1.5;
                                local_670 = ((float)iVar4 * fVar28) / 1.5;
                                local_668 = fStack_66c;
                                if (lVar8 == null) goto LAB_180a223e6;
                                local_428 = CONCAT44(fStack_66c,local_670);
                                local_420 = fStack_66c;
                                Transform.set_localScale(lVar8,&local_428,0);
                                puVar13 = (uint64 *)Vector3.get_zero(local_1c8,0);
                                uVar11 = *puVar13;
                                fVar28 = *(float *)(puVar13 + 1);
                                local_758 = uVar11;
                                local_750 = fVar28;
                                if (bVar25 == 0) {
                                  fVar28 = (float)Random.get_value(0);
                                  if (fVar28 < 0.5) {
                                    fVar33 = 1.0;
                                  }
                                  fVar32 = (float)Random.Range();
                                  fVar32 = fVar32 * fVar33;
                                  iVar4 = FUN_180d8cf10(1);
                                  iVar4 = -iVar4;
        LAB_180a21bc6:
                                  fVar29 = (float)iVar4;
        LAB_180a21bcd:
                                  fVar28 = 0.0;
                                  uVar11 = local_758;
                                }
                                else {
                                  if (bVar25 == 1) {
                                    fVar28 = (float)Random.get_value(0);
                                    if (fVar28 < 0.5) {
                                      fVar33 = 1.0;
                                    }
                                    fVar32 = (float)Random.Range();
                                    fVar32 = fVar32 * fVar33;
                                    iVar4 = FUN_180d8cf10(1);
                                    goto LAB_180a21bc6;
                                  }
                                  if (bVar25 == 2) {
                                    iVar4 = FUN_180d8cf10(1);
                                    fVar28 = (float)Random.get_value(0);
                                    iVar4 = -iVar4;
        LAB_180a21adf:
                                    fVar32 = (float)iVar4;
                                    if (fVar28 < 0.5) {
                                      fVar33 = 1.0;
                                    }
                                    fVar29 = (float)Random.Range();
                                    fVar29 = fVar29 * fVar33;
                                    goto LAB_180a21bcd;
                                  }
                                  if (bVar25 == 3) {
                                    iVar4 = FUN_180d8cf10(1,12,0);
                                    fVar28 = (float)Random.get_value(0);
                                    goto LAB_180a21adf;
                                  }
                                  local_758._4_4_ = (float)((uint64)uVar11 >> 32);
                                  local_758._0_4_ = (float)uVar11;
                                  fVar32 = (float)local_758;
                                  fVar29 = local_758._4_4_;
                                }
                                local_758 = uVar11;
                                if (this.newObj == null) {
        LAB_180a223ce:
                          // WARNING: Subroutine does not return
                                  FUN_1800d6620();
                                }
                                lVar8 = GameObject.get_transform(this.newObj,0);
                                local_790 = fVar27 + fVar28;
                                local_798 = CONCAT44(fVar31 + fVar29,fVar30 + fVar32);
                                if (lVar8 == null) goto LAB_180a223ce;
                                local_418 = local_798;
                                local_410 = local_790;
                                Transform.set_localPosition(lVar8,&local_418,0);
                                if (this.newObj == null) goto LAB_180a223ce;
                                lVar8 = GameObject.get_transform(this.newObj,0);
                                if ((this.newObj == null) ||
                                   (lVar7 = GameObject.get_transform(this.newObj,0)) == null)
                                goto LAB_180a223ce;
                                puVar13 = (uint64 *)Transform.get_localPosition(local_1b8,lVar7,0);
                                uVar11 = *puVar13;
                                uVar5 = *(uint32 *)(puVar13 + 1);
                                if ((this.newObj == null) ||
                                   (lVar7 = GameObject.get_transform(this.newObj,0)) == null)
                                goto LAB_180a223ce;
                                puVar13 = (uint64 *)Transform.get_localPosition(local_1a8,lVar7,0);
                                local_7b8 = *puVar13;
                                uStack_7b0 = CONCAT44(uStack_7b0._4_4_,*(uint32 *)(puVar13 + 1));
                                local_408 = uVar11;
                                local_400 = uVar5;
                                puVar13 = (uint64 *)GlobalData.SetZ(local_740,&local_408);
                                if (lVar8 == null) goto LAB_180a223ce;
                                local_788 = *puVar13;
                                local_780 = *(float *)(puVar13 + 1);
                                Transform.set_localPosition(lVar8,&local_788,0);
                                if (this.newObj == null) goto LAB_180a223ce;
                                lVar8 = GameObject.GetComponent(this.newObj,DAT_181da19b0);
                                local_378 = 0;
                                uStack_370 = 0;
                                FUN_1809981e0(&local_378);
                                if (lVar8 == null) goto LAB_180a223ce;
                                local_778 = local_378;
                                uStack_770 = uStack_370;
                                SpriteRenderer.set_color(lVar8,&local_778,0);
                                if (this.decorations == null) goto LAB_180a223ce;
                                FUN_181827900();
                                iVar21 = iVar21 + 1;
                              } while (iVar21 < iVar3);
                              iVar3 = local_7a8 + 1;
                              plVar24 = local_748;
                              goto LAB_180a1f1be;
                            }
                            AreaController.GenerateLittlePeople(this,0);
                            AreaController.FreshAreaBuildingButton(this,0);
                            AreaController.FreshAreaHeroIcon(this,0);
                            this.nowFreeze = 0;
                            this.startAniming = 1;
                            if ((this.areaUIBelow != null) &&
                               (lVar8 = GameObject.get_transform(this.areaUIBelow,0),
                               lVar8 != null)) {
                              local_764 = -200.0;
                              local_768 = 0.0;
                              local_760 = 0;
                              Transform.set_localPosition(lVar8,&local_768,0);
                              if (this.areaUIBelow != null) {
                                uVar11 = GameObject.get_transform(this.areaUIBelow,0);
                                puVar13 = (uint64 *)Vector3.get_zero(local_740,0);
                                uVar5 = 0;
                                local_780 = *(float *)(puVar13 + 1);
                                local_788 = *puVar13;
                                uVar11 = ShortcutExtensions.DOLocalMove(uVar11,&local_788);
                                uVar11 = TweenSettingsExtensions.SetEase(uVar11,9,DAT_181d97ca8);
                                TweenSettingsExtensions.SetUpdate(uVar11,1,DAT_181d98af0);
                                AreaController.FreshAreaRandomEvent(this,0);
                                AreaController.GenerateOutsideDecorationTile(this,0);
                                if (this.areaGrid != null) {
                                  lVar8 = GameObject.get_transform(this.areaGrid,0);
                                  puVar13 = (uint64 *)Vector3.get_one(local_740,0);
                                  local_798 = *puVar13;
                                  local_790 = *(float *)(puVar13 + 1);
                                  fVar27 = *(float *)(pStatics_7630 + 16);
                                  local_750 = local_790 * fVar27;
                                  local_758 = CONCAT44(local_798._4_4_ * fVar27,(float)local_798 * fVar27)
                                  ;
                                  if (lVar8 != null) {
                                    local_788 = local_758;
                                    local_780 = local_750;
                                    Transform.set_localScale(lVar8,&local_788,0);
                                    if (this.areaGrid != null) {
                                      uVar11 = GameObject.get_transform(this.areaGrid,0);
                                      uVar11 = ShortcutExtensions.DOScale(uVar11);
                                      uVar11 = TweenSettingsExtensions.SetEase(uVar11,7,DAT_181d97ca8);
                                      uVar11 = TweenSettingsExtensions.SetUpdate(uVar11,1,DAT_181d98af0);
                                      uVar15 = new OnTooltipCB(this,DAT_181d61ea0,0);
                                      TweenSettingsExtensions.OnComplete(uVar11,uVar15,DAT_181d96ee8);
                                      this.nowScale = 0x3f800000;
                                      AreaController.ClearFocusTarget(this,0);
                                      AreaController.FreshAreaInfo(this,1,0);
                                      AreaController.FreshAreaTreasurePriceGrid(this,0);
                                      lVar8 = *plVar24;
                                      if (lVar8 != null) {
                                        AreaController.SetBackGroundSkeleton
                                                  (this,this.BackGround,
                                                   *(uint64 *)(lVar8 + 48),
                                                   *(uint32 *)(lVar8 + 56),
                                                   CONCAT44(uVar5,*(uint32 *)(lVar8 + 60)),0);
                                        if (this.BackGround != null) {
                                          lVar7 = GameObject.get_transform
                                                            (this.BackGround,0);
                                          lVar8 = *plVar24;
                                          if (lVar8 != null) {
                                            if (lVar7 != null) {
                                              local_760 = 0;
                                              local_768 = (float)(*(int *)(lVar8 + 184) + -1) * 0.5;
                                              local_764 = (float)(*(int *)(lVar8 + 188) + -1) * 0.5;
                                              Transform.set_localPosition(lVar7,&local_768,0);
                                              if ((this.areaGridRoot != null) &&
                                                 (lVar8 = GameObject.get_transform
                                                                    (this.areaGridRoot,0),
                                                 lVar8 != null)) {
                                                lVar8 = Transform.Find(lVar8,"Cloud",0);
                                                if ((this.BackGround != null) &&
                                                   (lVar7 = GameObject.get_transform
                                                                      (this.BackGround,0),
                                                   lVar7 != null)) {
                                                  puVar12 = (uint32 *)
                                                            Transform.get_localPosition
                                                                      (local_740,lVar7,0);
                                                  uVar5 = *puVar12;
                                                  if ((this.BackGround != null) &&
                                                     (lVar7 = GameObject.get_transform
                                                                        (this.BackGround,0),
                                                     lVar7 != null)) {
                                                    lVar7 = Transform.get_localPosition
                                                                      (local_740,lVar7,0);
                                                    local_790 = 0.0;
                                                    local_798 = CONCAT44(*(uint32 *)(lVar7 + 4),uVar5)
                                                    ;
                                                    if (lVar8 != null) {
                                                      local_788 = local_798;
                                                      local_780 = 0.0;
                                                      Transform.set_localPosition(lVar8,&local_788,0);
                                                      if ((this.areaGridRoot != null) &&
                                                         (lVar8 = GameObject.get_transform
                                                                            (this.areaGridRoot
                                                                             ,0), lVar8 != null)) {
                                                        lVar8 = Transform.Find(lVar8,"Bird",0);
                                                        if ((this.BackGround != null) &&
                                                           (lVar7 = GameObject.get_transform
                                                                              (*(int64 *)
                                                                                (this + 208),0),
                                                           lVar7 != null)) {
                                                          puVar12 = (uint32 *)
                                                                    Transform.get_localPosition
                                                                              (local_740,lVar7,0);
                                                          uVar5 = *puVar12;
                                                          if ((this.BackGround != null) &&
                                                             (lVar7 = GameObject.get_transform
                                                                                (*(int64 *)
                                                                                  (this + 208),0),
                                                             lVar7 != null)) {
                                                            lVar7 = Transform.get_localPosition
                                                                              (local_740,lVar7,0);
                                                            local_790 = 0.0;
                                                            local_798 = CONCAT44(*(uint32 *)
                                                                                  (lVar7 + 4),uVar5);
                                                            if (lVar8 != null) {
                                                              local_788 = local_798;
                                                              local_780 = 0.0;
                                                              Transform.set_localPosition
                                                                        (lVar8,&local_788,0);
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
                                    }
                                  }
                                }
                              }
                            }
                          }
        LAB_180a223e6:
                          // WARNING: Subroutine does not return
                          FUN_1800d6620();
                        }
                      }
                    }
                  }
                }
              }
            }
          }
        }
        LAB_180a223c8:
                          // WARNING: Subroutine does not return
        FUN_1800d6620();
        LAB_180a21e5c:
        local_res10 = local_res10 + 1;
        goto LAB_180a1f1b0;
    }

    // Token : 0x6000A41
    // RVA   : 0xA26730   Offset: 0xA24F30   Length: 0x1BA
    public void SetBuildModeUI(bool buildMode)
    {
        int iVar1;
        long lVar2;
        ulong uVar3;
        int iVar4;
        uint uVar5;
        if ((this.areaUIBelow != null) &&
           (lVar2 = GameObject.get_transform(this.areaUIBelow,0)) != null) {
          uVar3 = Transform.Find(lVar2,"AreaHeroScrollView",0);
          if (!buildMode) {
            uVar5 = 0xc3de8000;
          }
          else {
            uVar5 = 0xc42a0000;
          }
          iVar4 = 0;
          uVar3 = ShortcutExtensions.DOLocalMoveY(uVar3,uVar5,0x3e800000,0,0);
          TweenSettingsExtensions.SetUpdate(uVar3,1,DAT_181d98af0);
          lVar2 = this.buildingQuickButtonPanel;
          if (lVar2 != null) {
            while ((lVar2 = GameObject.get_transform(lVar2,0), lVar2 != null &&
                   (lVar2 = Transform.Find(lVar2,"BuildQuickButtonGrid",0)) != null)) {
              iVar1 = Transform.get_childCount(lVar2,0);
              if (iVar1 <= iVar4) {
                return;
              }
              if ((((this.buildingQuickButtonPanel == null) ||
                   (lVar2 = GameObject.get_transform(this.buildingQuickButtonPanel,0)) == null) ||
                  (lVar2 = Transform.Find(lVar2,"BuildQuickButtonGrid",0)) == null) ||
                 ((lVar2 = Transform.GetChild(lVar2,iVar4), lVar2 == null ||
                  (lVar2 = Component.GetComponent(lVar2,DAT_181d6af40)) == null))) break;
              Selectable.set_interactable(lVar2);
              lVar2 = this.buildingQuickButtonPanel;
              iVar4 = iVar4 + 1;
              if (lVar2 == null) break;
            }
          }
        }
    }

    // Token : 0x6000A42
    // RVA   : 0xA25FA0   Offset: 0xA247A0   Length: 0xBE
    public void SetAreaBackground()
    {
        long lVar1;
        long lVar2;
        float local_18;
        float local_14;
        uint local_10;
        lVar1 = this.areaData;
        if (lVar1 != null) {
          AreaController.SetBackGroundSkeleton
                    (lVar1.xScale,this.BackGround,
                     lVar1.backgroundType,lVar1.backgroundSkinID,
                     lVar1.xScale,0);
          if (this.BackGround != null) {
            lVar2 = GameObject.get_transform(this.BackGround,0);
            lVar1 = this.areaData;
            if (lVar1 != null) {
              local_18 = (float)(lVar1.mapWidth + -1) * 0.5;
              local_14 = (float)(lVar1.mapHeight + -1) * 0.5;
              if (lVar2 != null) {
                local_10 = 0;
                Transform.set_localPosition(lVar2,&local_18,0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x6000A43
    // RVA   : 0xA26110   Offset: 0xA24910   Length: 0x618
    public void SetBackGroundSkeleton(GameObject backgroundObj, string backgroundType, int backgroundSkinID, float xScale)
    {
        var pStatics = *(int64*)(DAT_181d87630 + 184);
        void AreaController.SetBackGroundSkeleton
                     (uint64 this,int64 backgroundObj,uint64 backgroundType,uint32 backgroundSkinID,
                     float xScale)
        {
        char cVar1;
        uint64 uVar2;
        int64 lVar3;
        int64 *plVar4;
        int64 *plVar5;
        int iVar6;
        int64 *plVar7;
        uint32 local_res20 [2];
        uint64 local_38;
        uint32 local_30;
        local_res20[0] = backgroundSkinID;
        plVar7 = (int64 *)0;
        while( true ) {
          while( true ) {
            if (*pStatics == 0) throw; // [null/range check failed]
            iVar6 = (int)plVar7;
            if (*(int *)(*pStatics + 24) <= iVar6) {
              return;
            }
            if (*pStatics == 0) throw; // [null/range check failed]
            uVar2 = FUN_180002f80(*pStatics,plVar7,DAT_181d7c9c0);
            uVar2 = String.Format("Skeleton/Background/{0}/{1}/skeleton_SkeletonData",backgroundType,uVar2,0);
            uVar2 = Resources.Load(uVar2,0);
            cVar1 = Object.op_Inequality(uVar2,0,0);
            if (backgroundObj == null) throw; // [null/range check failed]
            if (cVar1) break;
            lVar3 = GameObject.get_transform(backgroundObj,0);
            if ((((*pStatics == 0) ||
                 (uVar2 = FUN_180002f80(*pStatics,plVar7,DAT_181d7c9c0),
                 lVar3 == null)) || (lVar3 = Transform.Find(lVar3,uVar2,0)) == null) ||
               (lVar3 = Component.get_gameObject(lVar3,0)) == null) throw; // [null/range check failed]
            GameObject.SetActive(lVar3,0,0);
            plVar7 = (int64 *)(uint64)(iVar6 + 1);
          }
          lVar3 = GameObject.get_transform(backgroundObj,0);
          if (((*pStatics == 0) ||
              (uVar2 = FUN_180002f80(*pStatics,plVar7,DAT_181d7c9c0),
              lVar3 == null)) || (lVar3 = Transform.Find(lVar3,uVar2,0)) == null) break;
          lVar3 = Component.get_gameObject(lVar3,0);
          if (lVar3 == null) break;
          GameObject.SetActive(lVar3,1,0);
          lVar3 = GameObject.get_transform(backgroundObj,0);
          if (((*pStatics == 0) ||
              (uVar2 = FUN_180002f80(*pStatics,plVar7,DAT_181d7c9c0),
              lVar3 == null)) || (lVar3 = Transform.Find(lVar3,uVar2,0)) == null) break;
          lVar3 = Component.GetComponent(lVar3,DAT_181d6cd40);
          if (*pStatics == 0) break;
          uVar2 = FUN_180002f80(*pStatics,plVar7,DAT_181d7c9c0);
          uVar2 = String.Format("Skeleton/Background/{0}/{1}/skeleton_SkeletonData",backgroundType,uVar2,0);
          plVar4 = (int64 *)Resources.Load(uVar2,0);
          if (lVar3 == null) break;
          plVar5 = (int64 *)0;
          if (plVar4 != (int64 *)0) {
          }
          *(int64 **)(lVar3 + 24) = plVar5;
          lVar3 = GameObject.get_transform(backgroundObj,0);
          if (((*pStatics == 0) ||
              (uVar2 = FUN_180002f80(*pStatics,plVar7,DAT_181d7c9c0),
              lVar3 == null)) || (lVar3 = Transform.Find(lVar3,uVar2,0)) == null) break;
          lVar3 = Component.GetComponent(lVar3,DAT_181d6cd40);
          uVar2 = Int32.ToString(local_res20,0);
          uVar2 = String.Concat("skin",uVar2,0);
          if (lVar3 == null) break;
          *(uint64 *)(lVar3 + 32) = uVar2;
          lVar3 = GameObject.get_transform(backgroundObj,0);
          if (((*pStatics == 0) ||
              (uVar2 = FUN_180002f80(*pStatics,plVar7,DAT_181d7c9c0),
              lVar3 == null)) ||
             ((lVar3 = Transform.Find(lVar3,uVar2,0), lVar3 == null ||
              (plVar4 = (int64 *)Component.GetComponent(lVar3,DAT_181d6cd40),
              plVar4 == (int64 *)0)))) break;
          (**(code **)(*plVar4 + 0x1c8))(plVar4,1,0);
          lVar3 = GameObject.get_transform(backgroundObj,0);
          if ((((*pStatics == 0) ||
               (uVar2 = FUN_180002f80(*pStatics,plVar7,DAT_181d7c9c0),
               lVar3 == null)) || (lVar3 = Transform.Find(lVar3,uVar2,0)) == null) ||
             (lVar3 = Component.GetComponent(lVar3,DAT_181d6cd40)) == null) break;
          SkeletonAnimation.set_AnimationName(lVar3,"idle",0);
          lVar3 = GameObject.get_transform(backgroundObj,0);
          if ((*pStatics == 0) ||
             (uVar2 = FUN_180002f80(*pStatics,plVar7,DAT_181d7c9c0),
             lVar3 == null)) break;
          lVar3 = Transform.Find(lVar3,uVar2,0);
          if (lVar3 == null) break;
          local_38 = CONCAT44(0x40000000,xScale + xScale);
          local_30 = 0x40000000;
          Transform.set_localScale(lVar3,&local_38,0);
          plVar7 = (int64 *)(uint64)(iVar6 + 1);
        }
    }

    // Token : 0x6000A44
    // RVA   : 0xA23EE0   Offset: 0xA226E0   Length: 0x14
    public float GetAreaZPos(float yPos)
    {
        return yPos * 0.01 - 1.0;
    }

    // Token : 0x6000A45
    // RVA   : 0xA260D0   Offset: 0xA248D0   Length: 0x3B
    public Vector3 SetAreaZPos(Vector3 target)
    {
        float fVar1;
        fVar1 = (float)((uint64)*param_3 >> 32);
        *this = *(uint32 *)param_3;
        this[1] = fVar1;
        this[2] = fVar1 * 0.01 - 1.0;
        return this;
    }

    // Token : 0x6000A46
    // RVA   : 0xA23A00   Offset: 0xA22200   Length: 0x7B
    public void GenerateTileBuilding(AreaTileData targetTile)
    {
        bool cVar1;
        uint uVar2;
        long lVar3;
        ulong uVar4;
        long lVar5;
        long lVar7;
        ulong uVar8;
        ulong uVar9;
        long lVar10;
        uint[] local_res10 = new uint[2];
        ulong local_78;
        float local_70;
        ulong local_68;
        float local_60;
        byte[] local_58 = new byte[32];
        lVar10 = (int64)(int)targetTile;
        lVar3 = this.gridPool;
        local_res10[0] = 0;
        if (lVar3 != null) {
          if (lVar3.Count <= targetTile) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar3 = *(int64 *)(lVar3._items + 32 + lVar10 * 8);
          if ((lVar3 != null) && (lVar3 = GameObject.GetComponent(lVar3,DAT_181d9e4d0)) != null) {
            uVar8 = *(uint64 *)(lVar3 + 32);
            cVar1 = Object.op_Inequality(uVar8,0,0);
            if (cVar1) {
              lVar3 = this.gridPool;
              if (lVar3 == null) throw; // [null/range check failed]
              if (lVar3.Count <= targetTile) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar3 = *(int64 *)(lVar3._items + 32 + lVar10 * 8);
              if (((lVar3 == null) || (lVar3 = GameObject.GetComponent(lVar3,DAT_181d9e4d0)) == null) ||
                 (*(int64 *)(lVar3 + 32) == 0)) throw; // [null/range check failed]
              AreaBuildingIconController.SelfDestroy(*(int64 *)(lVar3 + 32),0);
            }
            if ((this.areaData != null) &&
               (lVar3 = this.areaData.areaTiles) != null) {
              if (lVar3.Count <= targetTile) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar3 = *(int64 *)(lVar3._items + 32 + lVar10 * 8);
              if (lVar3 != null) {
                if (*(int64 *)(lVar3 + 40) == 0) {
                  return;
                }
                if (((this.areaGridRoot != null) &&
                    (lVar3 = GameObject.get_transform(this.areaGridRoot,0)) != null) &&
                   (lVar3 = Transform.Find(lVar3,"Building",0)) != null) {
                  uVar4 = Component.get_gameObject(lVar3,0);
                  uVar8 = this.areaBuildingPrefab;
                  lVar3 = GlobalData.AddChild(uVar4,uVar8,0);
                  if (lVar3 != null) {
                    lVar5 = GameObject.get_transform(lVar3,0);
                    puVar6 = (uint64 *)Vector3.get_one(local_58,0);
                    if (lVar5 != null) {
                      local_60 = *(float *)(puVar6 + 1);
                      local_68 = *puVar6;
                      Transform.set_localScale(lVar5,&local_68,0);
                      lVar7 = GameObject.get_transform(lVar3,0);
                      lVar5 = this.gridPool;
                      if (lVar5 != null) {
                        if (lVar5.Count <= targetTile) {
                          ThrowHelper.ThrowArgumentOutOfRangeException(0);
                        }
                        lVar5 = *(int64 *)(lVar5._items + 32 + lVar10 * 8);
                        if ((lVar5 != null) && (lVar5 = GameObject.get_transform(lVar5,0)) != null) {
                          puVar6 = (uint64 *)Transform.get_localPosition(local_58,lVar5,0);
                          lVar5 = this.gridPool;
                          local_78 = *puVar6;
                          local_70 = *(float *)(puVar6 + 1);
                          if (lVar5 != null) {
                            if (lVar5.Count <= targetTile) {
                              ThrowHelper.ThrowArgumentOutOfRangeException(0);
                            }
                            lVar5 = *(int64 *)(lVar5._items + 32 + lVar10 * 8);
                            if ((lVar5 != null) && (lVar5 = GameObject.get_transform(lVar5,0)) != null)
                            {
                              lVar5 = Transform.get_localPosition(local_58,lVar5,0);
                              local_60 = (*(float *)(lVar5 + 4) * 0.01 - 1.0) + local_70;
                              local_68 = CONCAT44(local_78._4_4_ + 0.0,(float)local_78 + 0.0);
                              if (lVar7 != null) {
                                local_78 = local_68;
                                local_70 = local_60;
                                Transform.set_localPosition(lVar7,&local_78,0);
                                if ((this.areaData != null) &&
                                   (lVar5 = this.areaData.areaTiles,
                                   lVar5 != null)) {
                                  if (lVar5.Count <= targetTile) {
                                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                  }
                                  lVar5 = *(int64 *)(lVar5._items + 32 + lVar10 * 8);
                                  if ((lVar5 != null) && (lVar5 = *(int64 *)(lVar5 + 40)) != null) {
                                    if (lVar5._items == -1) {
                                      lVar5 = GameObject.GetComponent(lVar3,DAT_181d9e2b0);
                                      if ((this.areaData == null) ||
                                         (lVar7 = this.areaData.areaTiles,
                                         lVar7 == null)) throw; // [null/range check failed]
                                      if (*(uint32 *)(lVar7 + 24) <= targetTile) {
                                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                      }
                                      lVar7 = *(int64 *)
                                               (*(int64 *)(lVar7 + 16) + 32 + lVar10 * 8);
                                      if ((lVar7 == null) ||
                                         (lVar7 = *(int64 *)(lVar7 + 40)) == null)
                                      throw; // [null/range check failed]
                                      local_res10[0] =
                                           Mathf.CeilToInt((float)*(int *)(lVar7 + 20) * 0.5,0);
                                      uVar8 = Int32.ToString(local_res10,0);
                                      uVar8 = String.Concat("Skeleton/Obstacle/",uVar8,"/skeleton_SkeletonData",0);
                                      puVar6 = (uint64 *)Vector3.get_one(&local_68,0);
                                      local_78 = *puVar6;
                                      local_70 = *(float *)(puVar6 + 1);
                                      local_60 = local_70 * 0.5;
                                      local_68 = CONCAT44((float)((uint64)local_78 >> 32) * 0.5,
                                                          (float)local_78 * 0.5);
                                      uVar9 = 0;
                                      uVar4 = "idle";
                                    }
                                    else {
                                      lVar5 = GameObject.GetComponent();
                                      if ((this.areaData == null) ||
                                         (lVar7 = this.areaData.areaTiles,
                                         lVar7 == null)) throw; // [null/range check failed]
                                      if (*(uint32 *)(lVar7 + 24) <= targetTile) {
                                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                      }
                                      lVar7 = *(int64 *)
                                               (*(int64 *)(lVar7 + 16) + 32 + lVar10 * 8);
                                      if (((lVar7 == null) ||
                                          (lVar7 = *(int64 *)(lVar7 + 40)) == null) ||
                                         (lVar7 = AreaBuildingData.DataBase(lVar7,0)) == null)
                                      throw; // [null/range check failed]
                                      uVar8 = String.Concat("Skeleton/Building/",*(uint64 *)(lVar7 + 32),
                                                             "/skeleton_SkeletonData",0);
                                      puVar6 = (uint64 *)Vector3.get_one(&local_68,0);
                                      local_78 = *puVar6;
                                      local_70 = *(float *)(puVar6 + 1);
                                      local_60 = local_70 / 1.5;
                                      local_68 = CONCAT44((float)((uint64)local_78 >> 32) / 1.5,
                                                          (float)local_78 / 1.5);
                                      if ((this.areaData == null) ||
                                         (lVar7 = this.areaData.areaTiles,
                                         lVar7 == null)) throw; // [null/range check failed]
                                      if (*(uint32 *)(lVar7 + 24) <= targetTile) {
                                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                      }
                                      lVar7 = *(int64 *)
                                               (*(int64 *)(lVar7 + 16) + 32 + lVar10 * 8);
                                      if (((lVar7 == null) ||
                                          (lVar7 = *(int64 *)(lVar7 + 40)) == null) ||
                                         (lVar7 = AreaBuildingData.DataBase(lVar7,0),
                                         uVar4 = "idle", lVar7 == null)) throw; // [null/range check failed]
                                      if (*(int *)(lVar7 + 48) == 6) {
                                        uVar9 = 0;
                                      }
                                      else {
                                        if ((this.areaData == null) ||
                                           (lVar7 = this.areaData.areaTiles,
                                           lVar7 == null)) throw; // [null/range check failed]
                                        if (*(uint32 *)(lVar7 + 24) <= targetTile) {
                                          ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                        }
                                        lVar7 = *(int64 *)
                                                 (*(int64 *)(lVar7 + 16) + 32 + lVar10 * 8);
                                        if ((lVar7 == null) ||
                                           (lVar7 = *(int64 *)(lVar7 + 40)) == null)
                                        throw; // [null/range check failed]
                                        uVar2 = Mathf.FloorToInt((float)*(int *)(lVar7 + 20) * 0.5,0);
                                        local_res10[0] = Mathf.Clamp(uVar2,0,4);
                                        uVar9 = Int32.ToString(local_res10,0);
                                      }
                                    }
                                    local_78 = local_68;
                                    local_70 = local_60;
                                    uVar8 = GlobalData.GenerateSkeletonAnimation
                                                      (lVar3,uVar8,&local_78,uVar4,1,uVar9,0);
                                    if (lVar5 != null) {
                                      *(uint64 *)(lVar5 + 48) = uVar8;
                                      lVar5 = GameObject.GetComponent(lVar3,DAT_181d9e2b0);
                                      if ((this.areaData != null) &&
                                         (lVar7 = this.areaData.areaTiles,
                                         lVar7 != null)) {
                                        if (*(uint32 *)(lVar7 + 24) <= targetTile) {
                                          ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                        }
                                        lVar7 = *(int64 *)
                                                 (*(int64 *)(lVar7 + 16) + 32 + lVar10 * 8);
                                        if ((lVar7 != null) && (lVar5 != null)) {
                                          lVar5.Count = *(uint64 *)(lVar7 + 40);
                                          lVar7 = GameObject.GetComponent(lVar3,DAT_181d9e2b0);
                                          lVar5 = this.gridPool;
                                          if (lVar5 != null) {
                                            if (lVar5.Count <= targetTile) {
                                              ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                            }
                                            lVar5 = *(int64 *)
                                                     (lVar5._items + 32 + lVar10 * 8);
                                            if ((lVar5 != null) &&
                                               (uVar8 = GameObject.GetComponent(lVar5,DAT_181d9e4d0),
                                               lVar7 != null)) {
                                              *(uint64 *)(lVar7 + 32) = uVar8;
                                              lVar5 = this.gridPool;
                                              if (lVar5 != null) {
                                                if (lVar5.Count <= targetTile) {
                                                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                                }
                                                lVar10 = *(int64 *)
                                                          (lVar5._items + 32 + lVar10 * 8
                                                          );
                                                if (lVar10 != null) {
                                                  lVar10 = GameObject.GetComponent(lVar10,DAT_181d9e4d0);
                                                  uVar8 = GameObject.GetComponent(lVar3,DAT_181d9e2b0);
                                                  if (lVar10 != null) {
                                                    *(uint64 *)(lVar10 + 32) = uVar8;
                                                    il2cpp_internal((uint64 *)(lVar10 + 32),
                                                                        uVar8);
                                                    if (this.areaBuilding != null) {
                                                      FUN_181827900(this.areaBuilding,lVar3,
                                                                    DAT_181d61bf8);
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

    // Token : 0x6000A47
    // RVA   : 0xA23100   Offset: 0xA21900   Length: 0x8F4
    public void GenerateTileBuilding(int tileID)
    {
        bool cVar1;
        uint uVar2;
        long lVar3;
        ulong uVar4;
        long lVar5;
        long lVar7;
        ulong uVar8;
        ulong uVar9;
        long lVar10;
        uint[] local_res10 = new uint[2];
        ulong local_78;
        float local_70;
        ulong local_68;
        float local_60;
        byte[] local_58 = new byte[32];
        lVar10 = (int64)(int)tileID;
        lVar3 = this.gridPool;
        local_res10[0] = 0;
        if (lVar3 != null) {
          if (lVar3.Count <= tileID) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar3 = *(int64 *)(lVar3._items + 32 + lVar10 * 8);
          if ((lVar3 != null) && (lVar3 = GameObject.GetComponent(lVar3,DAT_181d9e4d0)) != null) {
            uVar8 = *(uint64 *)(lVar3 + 32);
            cVar1 = Object.op_Inequality(uVar8,0,0);
            if (cVar1) {
              lVar3 = this.gridPool;
              if (lVar3 == null) throw; // [null/range check failed]
              if (lVar3.Count <= tileID) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar3 = *(int64 *)(lVar3._items + 32 + lVar10 * 8);
              if (((lVar3 == null) || (lVar3 = GameObject.GetComponent(lVar3,DAT_181d9e4d0)) == null) ||
                 (*(int64 *)(lVar3 + 32) == 0)) throw; // [null/range check failed]
              AreaBuildingIconController.SelfDestroy(*(int64 *)(lVar3 + 32),0);
            }
            if ((this.areaData != null) &&
               (lVar3 = this.areaData.areaTiles) != null) {
              if (lVar3.Count <= tileID) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar3 = *(int64 *)(lVar3._items + 32 + lVar10 * 8);
              if (lVar3 != null) {
                if (*(int64 *)(lVar3 + 40) == 0) {
                  return;
                }
                if (((this.areaGridRoot != null) &&
                    (lVar3 = GameObject.get_transform(this.areaGridRoot,0)) != null) &&
                   (lVar3 = Transform.Find(lVar3,"Building",0)) != null) {
                  uVar4 = Component.get_gameObject(lVar3,0);
                  uVar8 = this.areaBuildingPrefab;
                  lVar3 = GlobalData.AddChild(uVar4,uVar8,0);
                  if (lVar3 != null) {
                    lVar5 = GameObject.get_transform(lVar3,0);
                    puVar6 = (uint64 *)Vector3.get_one(local_58,0);
                    if (lVar5 != null) {
                      local_60 = *(float *)(puVar6 + 1);
                      local_68 = *puVar6;
                      Transform.set_localScale(lVar5,&local_68,0);
                      lVar7 = GameObject.get_transform(lVar3,0);
                      lVar5 = this.gridPool;
                      if (lVar5 != null) {
                        if (lVar5.Count <= tileID) {
                          ThrowHelper.ThrowArgumentOutOfRangeException(0);
                        }
                        lVar5 = *(int64 *)(lVar5._items + 32 + lVar10 * 8);
                        if ((lVar5 != null) && (lVar5 = GameObject.get_transform(lVar5,0)) != null) {
                          puVar6 = (uint64 *)Transform.get_localPosition(local_58,lVar5,0);
                          lVar5 = this.gridPool;
                          local_78 = *puVar6;
                          local_70 = *(float *)(puVar6 + 1);
                          if (lVar5 != null) {
                            if (lVar5.Count <= tileID) {
                              ThrowHelper.ThrowArgumentOutOfRangeException(0);
                            }
                            lVar5 = *(int64 *)(lVar5._items + 32 + lVar10 * 8);
                            if ((lVar5 != null) && (lVar5 = GameObject.get_transform(lVar5,0)) != null)
                            {
                              lVar5 = Transform.get_localPosition(local_58,lVar5,0);
                              local_60 = (*(float *)(lVar5 + 4) * 0.01 - 1.0) + local_70;
                              local_68 = CONCAT44(local_78._4_4_ + 0.0,(float)local_78 + 0.0);
                              if (lVar7 != null) {
                                local_78 = local_68;
                                local_70 = local_60;
                                Transform.set_localPosition(lVar7,&local_78,0);
                                if ((this.areaData != null) &&
                                   (lVar5 = this.areaData.areaTiles,
                                   lVar5 != null)) {
                                  if (lVar5.Count <= tileID) {
                                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                  }
                                  lVar5 = *(int64 *)(lVar5._items + 32 + lVar10 * 8);
                                  if ((lVar5 != null) && (lVar5 = *(int64 *)(lVar5 + 40)) != null) {
                                    if (lVar5._items == -1) {
                                      lVar5 = GameObject.GetComponent(lVar3,DAT_181d9e2b0);
                                      if ((this.areaData == null) ||
                                         (lVar7 = this.areaData.areaTiles,
                                         lVar7 == null)) throw; // [null/range check failed]
                                      if (*(uint32 *)(lVar7 + 24) <= tileID) {
                                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                      }
                                      lVar7 = *(int64 *)
                                               (*(int64 *)(lVar7 + 16) + 32 + lVar10 * 8);
                                      if ((lVar7 == null) ||
                                         (lVar7 = *(int64 *)(lVar7 + 40)) == null)
                                      throw; // [null/range check failed]
                                      local_res10[0] =
                                           Mathf.CeilToInt((float)*(int *)(lVar7 + 20) * 0.5,0);
                                      uVar8 = Int32.ToString(local_res10,0);
                                      uVar8 = String.Concat("Skeleton/Obstacle/",uVar8,"/skeleton_SkeletonData",0);
                                      puVar6 = (uint64 *)Vector3.get_one(&local_68,0);
                                      local_78 = *puVar6;
                                      local_70 = *(float *)(puVar6 + 1);
                                      local_60 = local_70 * 0.5;
                                      local_68 = CONCAT44((float)((uint64)local_78 >> 32) * 0.5,
                                                          (float)local_78 * 0.5);
                                      uVar9 = 0;
                                      uVar4 = "idle";
                                    }
                                    else {
                                      lVar5 = GameObject.GetComponent();
                                      if ((this.areaData == null) ||
                                         (lVar7 = this.areaData.areaTiles,
                                         lVar7 == null)) throw; // [null/range check failed]
                                      if (*(uint32 *)(lVar7 + 24) <= tileID) {
                                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                      }
                                      lVar7 = *(int64 *)
                                               (*(int64 *)(lVar7 + 16) + 32 + lVar10 * 8);
                                      if (((lVar7 == null) ||
                                          (lVar7 = *(int64 *)(lVar7 + 40)) == null) ||
                                         (lVar7 = AreaBuildingData.DataBase(lVar7,0)) == null)
                                      throw; // [null/range check failed]
                                      uVar8 = String.Concat("Skeleton/Building/",*(uint64 *)(lVar7 + 32),
                                                             "/skeleton_SkeletonData",0);
                                      puVar6 = (uint64 *)Vector3.get_one(&local_68,0);
                                      local_78 = *puVar6;
                                      local_70 = *(float *)(puVar6 + 1);
                                      local_60 = local_70 / 1.5;
                                      local_68 = CONCAT44((float)((uint64)local_78 >> 32) / 1.5,
                                                          (float)local_78 / 1.5);
                                      if ((this.areaData == null) ||
                                         (lVar7 = this.areaData.areaTiles,
                                         lVar7 == null)) throw; // [null/range check failed]
                                      if (*(uint32 *)(lVar7 + 24) <= tileID) {
                                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                      }
                                      lVar7 = *(int64 *)
                                               (*(int64 *)(lVar7 + 16) + 32 + lVar10 * 8);
                                      if (((lVar7 == null) ||
                                          (lVar7 = *(int64 *)(lVar7 + 40)) == null) ||
                                         (lVar7 = AreaBuildingData.DataBase(lVar7,0),
                                         uVar4 = "idle", lVar7 == null)) throw; // [null/range check failed]
                                      if (*(int *)(lVar7 + 48) == 6) {
                                        uVar9 = 0;
                                      }
                                      else {
                                        if ((this.areaData == null) ||
                                           (lVar7 = this.areaData.areaTiles,
                                           lVar7 == null)) throw; // [null/range check failed]
                                        if (*(uint32 *)(lVar7 + 24) <= tileID) {
                                          ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                        }
                                        lVar7 = *(int64 *)
                                                 (*(int64 *)(lVar7 + 16) + 32 + lVar10 * 8);
                                        if ((lVar7 == null) ||
                                           (lVar7 = *(int64 *)(lVar7 + 40)) == null)
                                        throw; // [null/range check failed]
                                        uVar2 = Mathf.FloorToInt((float)*(int *)(lVar7 + 20) * 0.5,0);
                                        local_res10[0] = Mathf.Clamp(uVar2,0,4);
                                        uVar9 = Int32.ToString(local_res10,0);
                                      }
                                    }
                                    local_78 = local_68;
                                    local_70 = local_60;
                                    uVar8 = GlobalData.GenerateSkeletonAnimation
                                                      (lVar3,uVar8,&local_78,uVar4,1,uVar9,0);
                                    if (lVar5 != null) {
                                      *(uint64 *)(lVar5 + 48) = uVar8;
                                      lVar5 = GameObject.GetComponent(lVar3,DAT_181d9e2b0);
                                      if ((this.areaData != null) &&
                                         (lVar7 = this.areaData.areaTiles,
                                         lVar7 != null)) {
                                        if (*(uint32 *)(lVar7 + 24) <= tileID) {
                                          ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                        }
                                        lVar7 = *(int64 *)
                                                 (*(int64 *)(lVar7 + 16) + 32 + lVar10 * 8);
                                        if ((lVar7 != null) && (lVar5 != null)) {
                                          lVar5.Count = *(uint64 *)(lVar7 + 40);
                                          lVar7 = GameObject.GetComponent(lVar3,DAT_181d9e2b0);
                                          lVar5 = this.gridPool;
                                          if (lVar5 != null) {
                                            if (lVar5.Count <= tileID) {
                                              ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                            }
                                            lVar5 = *(int64 *)
                                                     (lVar5._items + 32 + lVar10 * 8);
                                            if ((lVar5 != null) &&
                                               (uVar8 = GameObject.GetComponent(lVar5,DAT_181d9e4d0),
                                               lVar7 != null)) {
                                              *(uint64 *)(lVar7 + 32) = uVar8;
                                              lVar5 = this.gridPool;
                                              if (lVar5 != null) {
                                                if (lVar5.Count <= tileID) {
                                                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                                }
                                                lVar10 = *(int64 *)
                                                          (lVar5._items + 32 + lVar10 * 8
                                                          );
                                                if (lVar10 != null) {
                                                  lVar10 = GameObject.GetComponent(lVar10,DAT_181d9e4d0);
                                                  uVar8 = GameObject.GetComponent(lVar3,DAT_181d9e2b0);
                                                  if (lVar10 != null) {
                                                    *(uint64 *)(lVar10 + 32) = uVar8;
                                                    il2cpp_internal((uint64 *)(lVar10 + 32),
                                                                        uVar8);
                                                    if (this.areaBuilding != null) {
                                                      FUN_181827900(this.areaBuilding,lVar3,
                                                                    DAT_181d61bf8);
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

    // Token : 0x6000A48
    // RVA   : 0xA22750   Offset: 0xA20F50   Length: 0x9A6
    public void GenerateOutsideDecorationTile()
    {
        long lVar2;
        bool cVar3;
        int iVar4;
        uint uVar5;
        long lVar6;
        ulong uVar7;
        long lVar8;
        ulong uVar9;
        ulong uVar10;
        uint8 (*pauVar11) [16];
        float *pfVar12;
        uint64 *puVar13;
        int iVar14;
        int iVar15;
        int iVar16;
        float fVar17;
        float fVar18;
        float fVar19;
        float fVar20;
        uint32 local_res8 [2];
        uint64 local_1c8;
        uint64 uStack_1c0;
        uint8 local_1b8 [16];
        uint64 local_1a8;
        float local_1a0;
        float fStack_19c;
        float local_198;
        uint32 local_190;
        float fStack_18c;
        float local_188;
        float local_178;
        float local_174;
        uint32 local_170;
        uint64 local_168;
        uint64 uStack_160;
        uint64 local_148;
        float local_140;
        uint64 local_138;
        float local_130;
        uint8 local_128 [16];
        uint8 local_118 [16];
        uint8 local_108 [16];
        uint8 local_f8 [16];
        uint8 local_e8 [176];
        lVar6 = this.areaData;
        local_1b8 = ZEXT816(0);
        iVar15 = -1;
        local_res8[0] = 0;
        local_1a8 = 0;
        local_168 = 0;
        uStack_160 = 0;
        if (lVar6 != null) {
          do {
            if (lVar6.mapWidth + 1 <= iVar15) {
              return;
            }
            iVar16 = -1;
            while( true ) {
              lVar6 = this.areaData;
              if (lVar6 == null) throw; // [null/range check failed]
              if (lVar6.mapHeight + 1 <= iVar16) break;
              lVar6 = AreaData.GetTile(lVar6,iVar15,iVar16,0);
              if (lVar6 == null) {
        LAB_180a22942:
                cVar3 = AreaController.AroundTileHaveType(this,iVar15,iVar16,0xffffffff,0);
                if (cVar3) {
                  iVar4 = FUN_180d8cf10(0xffffffff,5);
                  while (0 < iVar4) {
                    iVar4 = iVar4 + -1;
                    if (((this.areaGridRoot == null) ||
                        (lVar6 = GameObject.get_transform(this.areaGridRoot,0)) == null)
                       || (lVar6 = Transform.Find(lVar6,"OutsideDecoration",0)) == null)
                    throw; // [null/range check failed]
                    uVar7 = Component.get_gameObject(lVar6,0);
                    lVar8 = FUN_18046c6c0(0);
                    lVar6 = this.areaData;
                    if (lVar6 == null) throw; // [null/range check failed]
                    uVar10 = lVar6.backgroundType;
                    if (((*(byte *)(DAT_181d87630 + 0x133) & 4) != 0) &&
                       (*(int *)(DAT_181d87630 + 224) == 0)) {
                      il2cpp_runtime_class_init(DAT_181d87630);
                      lVar6 = this.areaData;
                    }
                    lVar2 = *(int64 *)(*(int64 *)(DAT_181d87630 + 184) + 8);
                    if ((lVar6 == null) ||
                       (uVar5 = Int32.Parse(lVar6.backgroundType,0), lVar2 == null))
                    throw; // [null/range check failed]
                    uVar5 = FUN_1800d6750(lVar2,uVar5,DAT_181d68270);
                    local_res8[0] = FUN_180d8cf10(0,uVar5,0);
                    uVar9 = Int32.ToString(local_res8,0);
                    uVar10 = String.Concat(uVar10,"_",uVar9,0);
                    if (lVar8 == null) throw; // [null/range check failed]
                    uVar10 = TextureController.LoadAtlasSprite(lVar8,"AreaMapAtlas",uVar10,0);
                    local_1c8 = 0;
                    uStack_1c0 = 0;
                    local_168 = 0;
                    uStack_160 = 0;
                    lVar6 = GlobalData.AddSprite(uVar7,"AroundDecoration",uVar10,&local_168,&local_1c8,0);
                    this.newObj = lVar6;
                    if (*plVar1 == 0) throw; // [null/range check failed]
                    lVar6 = GameObject.get_transform(*plVar1,0);
                    fVar17 = (float)Random.get_value(0);
                    iVar14 = 1;
                    if (0.5 <= fVar17) {
                      iVar14 = -1;
                    }
                    fVar17 = (float)Random.Range(0x3fcccccd);
                    fStack_19c = fVar17 / 1.5;
                    local_1a0 = ((float)iVar14 * fVar17) / 1.5;
                    local_198 = fStack_19c;
                    if (lVar6 == null) throw; // [null/range check failed]
                    local_148 = CONCAT44(fStack_19c,local_1a0);
                    local_140 = fStack_19c;
                    Transform.set_localScale(lVar6,&local_148,0);
                    fVar17 = 0.0;
                    fVar20 = 0.0;
                    fVar19 = 0.0;
                    fVar18 = 0.0;
                    if (this.areaData == null) throw; // [null/range check failed]
                    lVar6 = AreaData.GetTile(this.areaData,iVar15 + 1,iVar16);
                    if (lVar6 != null) {
                      if ((this.areaData == null) ||
                         (lVar6 = AreaData.GetTile(this.areaData,iVar15 + 1,iVar16),
                         lVar6 == null)) throw; // [null/range check failed]
                      if (lVar6.backgroundType == -1) {
                        if (((*plVar1 == 0) ||
                            (lVar6 = GameObject.GetComponent(*plVar1,DAT_181da19b0)) == null) ||
                           (lVar6 = SpriteRenderer.get_sprite(lVar6,0)) == null) throw; // [null/range check failed]
                        pauVar11 = (uint8 (*) [16])Sprite.get_bounds(&local_168,lVar6,0);
                        local_1b8 = *pauVar11;
                        local_1a8 = *(uint64 *)pauVar11[1];
                        pfVar12 = (float *)Bounds.get_size(local_128,local_1b8,0);
                        fVar20 = *pfVar12 * 0.5;
                      }
                    }
                    if (this.areaData == null) throw; // [null/range check failed]
                    lVar6 = AreaData.GetTile(this.areaData,iVar15 + -1,iVar16);
                    if (lVar6 != null) {
                      if ((this.areaData == null) ||
                         (lVar6 = AreaData.GetTile(this.areaData,iVar15 + -1,iVar16),
                         lVar6 == null)) throw; // [null/range check failed]
                      if (lVar6.backgroundType == -1) {
                        if (((*plVar1 == 0) ||
                            (lVar6 = GameObject.GetComponent(*plVar1,DAT_181da19b0)) == null) ||
                           (lVar6 = SpriteRenderer.get_sprite(lVar6,0)) == null) throw; // [null/range check failed]
                        pauVar11 = (uint8 (*) [16])Sprite.get_bounds(&local_168,lVar6,0);
                        local_1b8 = *pauVar11;
                        local_1a8 = *(uint64 *)pauVar11[1];
                        pfVar12 = (float *)Bounds.get_size(local_118,local_1b8,0);
                        fVar17 = *pfVar12 * 0.5;
                      }
                    }
                    if (this.areaData == null) throw; // [null/range check failed]
                    lVar6 = AreaData.GetTile(this.areaData,iVar15,iVar16 + 1);
                    if (lVar6 != null) {
                      if ((this.areaData == null) ||
                         (lVar6 = AreaData.GetTile(this.areaData,iVar15,iVar16 + 1),
                         lVar6 == null)) throw; // [null/range check failed]
                      if (lVar6.backgroundType == -1) {
                        if (((*plVar1 == 0) ||
                            (lVar6 = GameObject.GetComponent(*plVar1,DAT_181da19b0)) == null) ||
                           (lVar6 = SpriteRenderer.get_sprite(lVar6,0)) == null) throw; // [null/range check failed]
                        pauVar11 = (uint8 (*) [16])Sprite.get_bounds(&local_168,lVar6,0);
                        local_1b8 = *pauVar11;
                        local_1a8 = *(uint64 *)pauVar11[1];
                        puVar13 = (uint64 *)Bounds.get_size(local_108,local_1b8,0);
                        local_1c8 = *puVar13;
                        fVar19 = (float)((uint64)local_1c8 >> 32) * 0.5;
                        uStack_1c0 = CONCAT44(uStack_1c0._4_4_,*(uint32 *)(puVar13 + 1));
                      }
                    }
                    if (this.areaData == null) throw; // [null/range check failed]
                    lVar6 = AreaData.GetTile(this.areaData,iVar15,iVar16 + -1);
                    if (lVar6 != null) {
                      if ((this.areaData == null) ||
                         (lVar6 = AreaData.GetTile(this.areaData,iVar15,iVar16 + -1),
                         lVar6 == null)) throw; // [null/range check failed]
                      if (lVar6.backgroundType == -1) {
                        if (((*plVar1 == 0) ||
                            (lVar6 = GameObject.GetComponent(*plVar1,DAT_181da19b0)) == null) ||
                           (lVar6 = SpriteRenderer.get_sprite(lVar6,0)) == null) throw; // [null/range check failed]
                        pauVar11 = (uint8 (*) [16])Sprite.get_bounds(&local_168,lVar6,0);
                        local_1b8 = *pauVar11;
                        local_1a8 = *(uint64 *)pauVar11[1];
                        puVar13 = (uint64 *)Bounds.get_size(local_f8,local_1b8,0);
                        local_1c8 = *puVar13;
                        fVar18 = (float)((uint64)local_1c8 >> 32) * 0.5;
                        uStack_1c0 = CONCAT44(uStack_1c0._4_4_,*(uint32 *)(puVar13 + 1));
                      }
                    }
                    if (*plVar1 == 0) throw; // [null/range check failed]
                    lVar6 = GameObject.get_transform(*plVar1,0);
                    fVar17 = (float)Random.Range(fVar17 - 0.5,0.5 - fVar20,0);
                    fVar18 = (float)Random.Range(fVar18 - 0.5,0.5 - fVar19,0);
                    if (lVar6 == null) throw; // [null/range check failed]
                    local_170 = 0;
                    local_178 = fVar17 + (float)iVar15;
                    local_174 = fVar18 + (float)iVar16;
                    Transform.set_localPosition(lVar6,&local_178,0);
                    if (*plVar1 == 0) throw; // [null/range check failed]
                    lVar6 = GameObject.get_transform(*plVar1,0);
                    if ((*plVar1 == 0) || (lVar8 = GameObject.get_transform(*plVar1,0)) == null)
                    throw; // [null/range check failed]
                    puVar13 = (uint64 *)Transform.get_localPosition(local_e8,lVar8,0);
                    local_1c8 = *puVar13;
                    local_190 = (uint32)local_1c8;
                    fStack_18c = (float)((uint64)local_1c8 >> 32);
                    local_188 = fStack_18c * 0.01 - 1.0;
                    uStack_1c0 = CONCAT44((int)((uint64)uStack_1c0 >> 32),
                                          *(uint32 *)(puVar13 + 1));
                    if ((lVar6 == null) ||
                       (local_138 = local_1c8, local_130 = local_188,
                       Transform.set_localPosition(lVar6,&local_138,0), *(int64 *)(this + 200) == 0
                       )) throw; // [null/range check failed]
                    FUN_181827900();
                  }
                }
              }
              else {
                if ((this.areaData == null) ||
                   (lVar6 = AreaData.GetTile(this.areaData,iVar15,iVar16,0)) == null)
                throw; // [null/range check failed]
                if (lVar6.backgroundType == -3) goto LAB_180a22942;
              }
              iVar16 = iVar16 + 1;
            }
            iVar15 = iVar15 + 1;
          } while( true );
        }
    }

    // Token : 0x6000A49
    // RVA   : 0xA1AF70   Offset: 0xA19770   Length: 0x15C
    public bool AroundTileHaveType(int column, int row, AreaTileType tileType)
    {
        uint8
        AreaController.AroundTileHaveType(int64 this,int column,uint64 row,int tileType)
        {
        int iVar1;
        uint8 uVar2;
        int64 lVar3;
        uint64 uVar4;
        uVar4 = row & 0xffffffff;
        if (this.areaData == null) goto LAB_180a1b0c7;
        lVar3 = AreaData.GetTile(this.areaData,column + 1,row,0);
        if (lVar3 == null) {
        LAB_180a1afde:
          if (this.areaData == null) goto LAB_180a1b0c7;
          lVar3 = AreaData.GetTile(this.areaData,column + -1,uVar4,0);
          if (lVar3 != null) {
            if ((this.areaData == null) ||
               (lVar3 = AreaData.GetTile(this.areaData,column + -1,uVar4,0)) == null
               ) goto LAB_180a1b0c7;
            if (*(int *)(lVar3 + 48) == tileType) goto LAB_180a1b068;
          }
          if (this.areaData == null) goto LAB_180a1b0c7;
          iVar1 = (int)row;
          lVar3 = AreaData.GetTile(this.areaData,column,iVar1 + 1,0);
          if (lVar3 != null) {
            if ((this.areaData == null) ||
               (lVar3 = AreaData.GetTile(this.areaData,column,iVar1 + 1,0)) == null)
            goto LAB_180a1b0c7;
            if (*(int *)(lVar3 + 48) == tileType) goto LAB_180a1b068;
          }
          if (this.areaData == null) {
        LAB_180a1b0c7:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          lVar3 = AreaData.GetTile(this.areaData,column,iVar1 + -1,0);
          uVar2 = (uint8)lVar3;
          if (lVar3 != null) {
            if ((this.areaData == null) ||
               (lVar3 = AreaData.GetTile(this.areaData,column,iVar1 + -1,0)) == null
               ) goto LAB_180a1b0c7;
            uVar2 = *(int *)(lVar3 + 48) == tileType;
          }
        }
        else {
          if ((this.areaData == null) ||
             (lVar3 = AreaData.GetTile(this.areaData,column + 1,uVar4,0)) == null)
          goto LAB_180a1b0c7;
          if (*(int *)(lVar3 + 48) != tileType) goto LAB_180a1afde;
        LAB_180a1b068:
          uVar2 = 1;
        }
        return uVar2;
    }

    // Token : 0x6000A4A
    // RVA   : 0xA1B840   Offset: 0xA1A040   Length: 0xE84
    public void FreshAreaBuildingButton()
    {
        var pStatics = *(int64*)(DAT_181d86270 + 184);
        bool cVar2;
        int iVar3;
        long lVar4;
        ulong uVar5;
        ulong uVar6;
        long lVar7;
        long lVar9;
        uint uVar12;
        uint uVar13;
        long lVar14;
        uint[] local_res8 = new uint[2];
        ulong local_78;
        uint local_70;
        uint local_68;
        uint uStack_64;
        uint uStack_60;
        uint32 uStack_5c;
        uint64 local_58;
        uint64 uStack_50;
        if ((((this.areaUIBelow != null) &&
             (lVar4 = GameObject.get_transform(this.areaUIBelow,0)) != null) &&
            (lVar4 = Transform.Find(lVar4,"AreaTitle",0)) != null) &&
           (lVar4 = Transform.Find(lVar4,"Text",0)) != null) {
          uVar5 = Component.GetComponent(lVar4,DAT_181d6d8c0);
          if (this.areaData != null) {
            LTLocalization.SetText(uVar5,this.areaData.areaName,0);
            lVar4 = this.areaBuilding;
            uVar13 = 0;
            if (lVar4 != null) {
              lVar14 = 32;
              uVar12 = uVar13;
              while ((int)uVar12 < lVar4.Count) {
                if (lVar4 == null) goto LAB_180a1c6bf;
                if (lVar4.Count <= uVar12) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                uVar5 = *(uint64 *)(lVar14 + lVar4._items);
                cVar2 = Object.op_Inequality(uVar5);
                if (cVar2) {
                  if (((this.areaBuilding == null) ||
                      (lVar4 = FUN_180002f80(this.areaBuilding,uVar12)) == null) ||
                     ((lVar4 = GameObject.GetComponent(lVar4), lVar4 == null ||
                      (lVar4.Count == null)))) goto LAB_180a1c6bf;
                  if (-1 < *(int *)(lVar4.Count + 16)) {
                    if (((((this.areaBuilding == null) ||
                          (lVar4 = FUN_180002f80(this.areaBuilding,uVar12)) == null) ||
                         (lVar4 = GameObject.GetComponent(lVar4)) == null) ||
                        ((lVar4.Count == null ||
                         (lVar4 = AreaBuildingData.DataBase()) == null))) ||
                       (*(int64 *)(lVar4 + 64) == 0)) goto LAB_180a1c6bf;
                    if (0 < *(int *)(*(int64 *)(lVar4 + 64) + 24)) {
                      if (((this.buildingQuickButtonPanel == null) ||
                          (lVar4 = GameObject.get_transform(this.buildingQuickButtonPanel,0)) == null
                          ) || (lVar4 = Transform.Find(lVar4,"BuildQuickButtonGrid",0)) == null)
                      goto LAB_180a1c6bf;
                      uVar6 = Component.get_gameObject(lVar4,0);
                      uVar5 = this.buildQuickButtonPrefab;
                      lVar4 = GlobalData.AddChild(uVar6,uVar5,0);
                      this.newObj = lVar4;
                      if (*plVar1 == 0) goto LAB_180a1c6bf;
                      lVar4 = GameObject.GetComponent(*plVar1,DAT_181d9ed50);
                      if ((((this.areaBuilding == null) ||
                           (lVar7 = FUN_180002f80(this.areaBuilding,uVar12,DAT_181d62178),
                           lVar7 == null)) ||
                          (lVar7 = GameObject.GetComponent(lVar7,DAT_181d9e2b0)) == null) ||
                         (lVar4 == null)) goto LAB_180a1c6bf;
                      lVar4.Count = *(uint64 *)(lVar7 + 24);
                      if (((*plVar1 == 0) || (lVar4 = GameObject.get_transform(*plVar1,0)) == null)
                         || (lVar4 = Transform.Find(lVar4,"Text",0)) == null)
                      goto LAB_180a1c6bf;
                      uVar5 = Component.GetComponent(lVar4,DAT_181d6d8c0);
                      if (((this.areaBuilding == null) ||
                          (lVar4 = FUN_180002f80(this.areaBuilding,uVar12,DAT_181d62178),
                          lVar4 == null)) ||
                         ((lVar4 = GameObject.GetComponent(lVar4,DAT_181d9e2b0), lVar4 == null ||
                          ((lVar4.Count == null ||
                           (lVar4 = AreaBuildingData.DataBase(lVar4.Count,0)) == null
                           ))))) goto LAB_180a1c6bf;
                      LTLocalization.SetText(uVar5,lVar4.Count,0);
                      if ((this.areaBuilding == null) ||
                         (((lVar4 = FUN_180002f80(this.areaBuilding,uVar12,DAT_181d62178),
                           lVar4 == null ||
                           (lVar4 = GameObject.GetComponent(lVar4,DAT_181d9e2b0)) == null) ||
                          (lVar4.Count == null)))) goto LAB_180a1c6bf;
                      if (*(int *)(lVar4.Count + 16) == 73) {
                        lVar4 = *plVar1;
                        uVar5 = "9997";
                      }
                      else {
                        if (((this.areaBuilding == null) ||
                            (lVar4 = FUN_180002f80(this.areaBuilding,uVar12,DAT_181d62178),
                            lVar4 == null)) ||
                           ((lVar7 = GameObject.GetComponent(lVar4,DAT_181d9e2b0), lVar7 == null ||
                            (*(int64 *)(lVar7 + 24) == 0)))) goto LAB_180a1c6bf;
                        lVar4 = *plVar1;
                        uVar5 = "9998";
                        if (*(int *)(*(int64 *)(lVar7 + 24) + 16) != 21) {
                          if (((this.areaBuilding == null) ||
                              (lVar7 = FUN_180002f80(this.areaBuilding,uVar12,DAT_181d62178),
                              lVar7 == null)) ||
                             ((lVar7 = GameObject.GetComponent(lVar7,DAT_181d9e2b0), lVar7 == null ||
                              ((*(int64 *)(lVar7 + 24) == 0 ||
                               (lVar7 = AreaBuildingData.DataBase(*(int64 *)(lVar7 + 24),0),
                               lVar7 == null)))))) goto LAB_180a1c6bf;
                          uVar5 = Int32.ToString(lVar7 + 48,0);
                          if ((this.areaBuilding == null) ||
                             (((lVar7 = FUN_180002f80(this.areaBuilding,uVar12,DAT_181d62178),
                               lVar7 == null ||
                               (lVar7 = GameObject.GetComponent(lVar7,DAT_181d9e2b0)) == null) ||
                              (*(int64 *)(lVar7 + 24) == 0)))) goto LAB_180a1c6bf;
                          uVar6 = Int32.ToString(*(int64 *)(lVar7 + 24) + 16,"000",0);
                          uVar5 = String.Concat(uVar5,uVar6,0);
                        }
                      }
                      if (lVar4 == null) goto LAB_180a1c6bf;
                      Object.set_name(lVar4,uVar5,0);
                      if (*plVar1 == 0) goto LAB_180a1c6bf;
                      lVar4 = GameObject.get_transform(*plVar1,0);
                      puVar8 = (uint64 *)Vector3.get_zero(&local_68,0);
                      if (lVar4 == null) goto LAB_180a1c6bf;
                      local_70 = *(uint32 *)(puVar8 + 1);
                      local_78 = *puVar8;
                      Transform.set_localScale(lVar4,&local_78,0);
                      if (((*plVar1 == 0) || (lVar4 = GameObject.get_transform(*plVar1,0)) == null)
                         || (lVar4 = Transform.Find(lVar4,"Icon",0)) == null)
                      goto LAB_180a1c6bf;
                      lVar4 = Component.GetComponent(lVar4,DAT_181d6bc40);
                      lVar7 = FUN_18046c6c0(0);
                      if (((this.areaBuilding == null) ||
                          (lVar9 = FUN_180002f80(this.areaBuilding,uVar12,DAT_181d62178),
                          lVar9 == null)) ||
                         ((lVar9 = GameObject.GetComponent(lVar9,DAT_181d9e2b0), lVar9 == null ||
                          (*(int64 *)(lVar9 + 24) == 0)))) goto LAB_180a1c6bf;
                      uVar5 = Int32.ToString(*(int64 *)(lVar9 + 24) + 16,0);
                      uVar5 = String.Concat("buildingicon_",uVar5,0);
                      if ((((lVar7 == null) ||
                           (uVar5 = TextureController.LoadAtlasSprite(lVar7,"UIAtlas",uVar5,0),
                           lVar4 == null)) || (Image.set_sprite(lVar4,uVar5), *plVar1 == 0)) ||
                         (lVar4 = GameObject.GetComponent()) == null) goto LAB_180a1c6bf;
                      BuildQuickButtonController.RefreshBuildingChoiceInfo(lVar4);
                    }
                  }
                }
                lVar4 = this.areaBuilding;
                uVar12 = uVar12 + 1;
                lVar14 = lVar14 + 8;
                if (lVar4 == null) goto LAB_180a1c6bf;
              }
              if (((this.buildingQuickButtonPanel != null) &&
                  (lVar4 = GameObject.get_transform(this.buildingQuickButtonPanel,0)) != null) &&
                 (lVar4 = Transform.Find(lVar4,"BuildQuickButtonGrid",0)) != null) {
                uVar6 = Component.get_gameObject(lVar4,0);
                uVar5 = this.buildQuickButtonPrefab;
                lVar4 = GlobalData.AddChild(uVar6,uVar5,0);
                this.newObj = lVar4;
                if ((*plVar1 != 0) &&
                   (lVar4 = GameObject.GetComponent(*plVar1,DAT_181d9ed50)) != null) {
                  lVar4.Count = 0;
                  if (this.areaData != null) {
                    local_res8[0] = this.areaData.areaType;
                    uVar5 = il2cpp_value_box(DAT_181d5b2f8,local_res8);
                    String.Format("gate{0}_0",uVar5,0);
                    if (((*plVar1 != 0) && (lVar4 = GameObject.get_transform(*plVar1,0)) != null) &&
                       (lVar4 = Transform.Find(lVar4,"Text",0)) != null) {
                      uVar5 = Component.GetComponent(lVar4,DAT_181d6d8c0);
                      LTLocalization.SetText(uVar5,"离开",0);
                      if (((*plVar1 != 0) && (lVar4 = GameObject.get_transform(*plVar1,0)) != null)
                         && (lVar4 = Transform.Find(lVar4,"Icon",0)) != null) {
                        lVar4 = Component.GetComponent(lVar4,DAT_181d6bc40);
                        if ((*pStatics != 0) &&
                           (uVar5 = TextureController.LoadAtlasSprite
                                              (*pStatics,"UIAtlas",
                                               "离开城市",0), lVar4 != null)) {
                          Image.set_sprite(lVar4,uVar5,0);
                          if (*plVar1 != 0) {
                            Object.set_name(*plVar1,"9999",0);
                            if (*plVar1 != 0) {
                              lVar4 = GameObject.get_transform(*plVar1,0);
                              puVar8 = (uint64 *)Vector3.get_zero(&local_68,0);
                              if (lVar4 != null) {
                                local_70 = *(uint32 *)(puVar8 + 1);
                                local_78 = *puVar8;
                                Transform.set_localScale(lVar4,&local_78,0);
                                if (*plVar1 != 0) {
                                  plVar10 = (int64 *)GameObject.GetComponent(*plVar1,DAT_181d9fe50);
                                  local_58 = 0;
                                  uStack_50 = 0;
                                  uVar5 = 0;
                                  Color.ctor(&local_58);
                                  if (plVar10 != (int64 *)0) {
                                    lVar4 = *plVar10;
                                    local_68 = (uint32)local_58;
                                    uStack_64 = local_58._4_4_;
                                    uStack_60 = (uint32)uStack_50;
                                    uStack_5c = uStack_50._4_4_;
                                    (**(code **)(lVar4 + 0x2a8))
                                              (plVar10,&local_68,*(uint64 *)(lVar4 + 0x2b0),lVar4,
                                               uVar5);
                                    if (((*plVar1 != 0) &&
                                        (lVar4 = GameObject.get_transform(*plVar1,0)) != null) &&
                                       (lVar4 = Transform.Find(lVar4,"LvBack",0)) != null) {
                                      plVar10 = (int64 *)Component.GetComponent(lVar4,DAT_181d6bc40);
                                      puVar11 = (uint32 *)FUN_180d904c0(&local_68,0);
                                      if (plVar10 != (int64 *)0) {
                                        local_68 = *puVar11;
                                        uStack_64 = puVar11[1];
                                        uStack_60 = puVar11[2];
                                        uStack_5c = puVar11[3];
                                        (**(code **)(*plVar10 + 0x2a8))
                                                  (plVar10,&local_68,*(uint64 *)(*plVar10 + 0x2b0));
                                        if (((*plVar1 != 0) &&
                                            (lVar4 = GameObject.get_transform(*plVar1,0)) != null) &&
                                           ((lVar4 = Transform.Find(lVar4,"LvBack",0), lVar4 != null &&
                                            (lVar4 = Transform.Find(lVar4,"Lv",0)) != null))
                                           ) {
                                          uVar5 = Component.GetComponent(lVar4,DAT_181d6d8c0);
                                          LTLocalization.SetText(uVar5,"",0);
                                          if (((this.buildingQuickButtonPanel != null) &&
                                              (lVar4 = GameObject.get_transform
                                                                 (this.buildingQuickButtonPanel,0),
                                              lVar4 != null)) &&
                                             (lVar4 = Transform.Find(lVar4,"BuildQuickButtonGrid",0)) != null)
                                          {
                                            uVar5 = Component.get_gameObject(lVar4,0);
                                            GlobalData.SortChild(uVar5,0);
                                            lVar4 = this.buildingQuickButtonPanel;
                                            if (lVar4 != null) goto LAB_180a1c510;
                                            goto LAB_180a1c6bf;
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
                  }
                }
              }
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
          }
        }
        LAB_180a1c6bf:
                          // WARNING: Subroutine does not return
        FUN_1800d6620();
        LAB_180a1c510:
        lVar4 = GameObject.get_transform(lVar4,0);
        if ((lVar4 == null) || (lVar4 = Transform.Find(lVar4,"BuildQuickButtonGrid",0)) == null)
        goto LAB_180a1c6bf;
        iVar3 = Transform.get_childCount(lVar4,0);
        lVar4 = this.buildingQuickButtonPanel;
        if (iVar3 <= (int)uVar13) {
          if ((((lVar4 != null) && (lVar4 = GameObject.get_transform(lVar4,0)) != null) &&
              (lVar4 = Transform.Find(lVar4,"BuildQuickButtonGrid",0)) != null) &&
             (lVar4 = Component.GetComponent(lVar4,DAT_181d6e0c0)) != null) {
            UIGrid.set_repositionNow(lVar4,1,0);
            return;
          }
          goto LAB_180a1c6bf;
        }
        if (((lVar4 == null) || (lVar4 = GameObject.get_transform(lVar4,0)) == null) ||
           ((lVar4 = Transform.Find(lVar4,"BuildQuickButtonGrid",0), lVar4 == null ||
            (lVar4 = Transform.GetChild(lVar4,uVar13,0)) == null))) goto LAB_180a1c6bf;
        uVar5 = Component.get_transform(lVar4,0);
        puVar8 = (uint64 *)Vector3.get_one(&local_68,0);
        local_70 = *(uint32 *)(puVar8 + 1);
        local_78 = *puVar8;
        uVar5 = ShortcutExtensions.DOScale(uVar5,&local_78,0x3dcccccd,0);
        uVar5 = TweenSettingsExtensions.SetDelay(uVar5,(float)(int)uVar13 * 0.05,DAT_181d97978);
        TweenSettingsExtensions.SetUpdate(uVar5);
        lVar4 = this.buildingQuickButtonPanel;
        uVar13 = uVar13 + 1;
        if (lVar4 == null) goto LAB_180a1c6bf;
        goto LAB_180a1c510;
    }

    // Token : 0x6000A4B
    // RVA   : 0xA1C6D0   Offset: 0xA1AED0   Length: 0x5AD
    public void FreshAreaEventButton()
    {
        int iVar2;
        uint uVar3;
        long lVar4;
        long lVar5;
        ulong uVar6;
        ulong uVar7;
        int iVar10;
        int iVar11;
        int iVar12;
        ulong local_78;
        uint local_70;
        ulong local_68;
        uint local_60;
        byte[] local_58 = new byte[16];
        byte[] local_48 = new byte[16];
        uint local_38;
        uint uStack_34;
        uint uStack_30;
        uint32 uStack_2c;
        lVar4 = this.randomEvents;
        iVar12 = 0;
        iVar11 = 0;
        do {
          if (lVar4 == null) {
        LAB_180a1cc78:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          if (lVar4.Count <= iVar11) {
            this.needRefreshAreaEventGrid = 1;
            return;
          }
          iVar10 = 0;
          while( true ) {
            if (((this.buildingQuickButtonPanel == null) ||
                (lVar4 = GameObject.get_transform(this.buildingQuickButtonPanel,0)) == null) ||
               (lVar4 = Transform.Find(lVar4,"AreaEventQuickButtonGrid",0)) == null) goto LAB_180a1cc78;
            iVar2 = Transform.get_childCount(lVar4,0);
            lVar4 = this.buildingQuickButtonPanel;
            if (iVar2 <= iVar10) break;
            if (((lVar4 == null) || (lVar4 = GameObject.get_transform(lVar4,0)) == null) ||
               ((lVar4 = Transform.Find(lVar4,"AreaEventQuickButtonGrid",0), lVar4 == null ||
                ((lVar4 = Transform.GetChild(lVar4,iVar10,0), lVar4 == null ||
                 (lVar4 = Component.GetComponent(lVar4,DAT_181d6aa40)) == null)))))
            goto LAB_180a1cc78;
            lVar4 = lVar4.Count;
            if ((this.randomEvents == null) ||
               ((lVar5 = FUN_180002f80(this.randomEvents,iVar11), lVar5 == null ||
                (lVar5 = GameObject.GetComponent(lVar5)) == null))) goto LAB_180a1cc78;
            if (lVar4 == *(int64 *)(lVar5 + 24)) goto LAB_180a1cc30;
            iVar10 = iVar10 + 1;
          }
          if (((lVar4 == null) || (lVar4 = GameObject.get_transform(lVar4,0)) == null) ||
             (lVar4 = Transform.Find(lVar4,"AreaEventQuickButtonGrid",0)) == null) goto LAB_180a1cc78;
          uVar6 = Component.get_gameObject(lVar4,0);
          uVar7 = this.areaEventQuickButtonPrefab;
          lVar4 = GlobalData.AddChild(uVar6,uVar7,0);
          this.newObj = lVar4;
          if (*plVar1 == 0) goto LAB_180a1cc78;
          lVar4 = GameObject.GetComponent(*plVar1,DAT_181d9e338);
          if ((((this.randomEvents == null) ||
               (lVar5 = FUN_180002f80(this.randomEvents,iVar11,DAT_181d62178)) == null) ||
              (lVar5 = GameObject.GetComponent(lVar5,DAT_181d9e448)) == null) || (lVar4 == null))
          goto LAB_180a1cc78;
          lVar4.Count = *(uint64 *)(lVar5 + 24);
          if (((*plVar1 == 0) || (lVar4 = GameObject.get_transform(*plVar1,0)) == null) ||
             (lVar4 = Transform.Find(lVar4,"Text",0)) == null) goto LAB_180a1cc78;
          uVar7 = Component.GetComponent(lVar4,DAT_181d6d8c0);
          if (((*plVar1 == 0) || (lVar4 = GameObject.GetComponent(*plVar1,DAT_181d9e338)) == null) ||
             (lVar4.Count == null)) goto LAB_180a1cc78;
          LTLocalization.SetText(uVar7,*(uint64 *)(lVar4.Count + 24),0);
          if (((*plVar1 == 0) || (lVar4 = GameObject.get_transform(*plVar1,0)) == null) ||
             (lVar4 = Transform.Find(lVar4,"Icon",0)) == null) goto LAB_180a1cc78;
          plVar8 = (int64 *)Component.GetComponent(lVar4,DAT_181d6bc40);
          lVar4 = FUN_18046c100(0);
          if (lVar4 == null) goto LAB_180a1cc78;
          lVar4 = *(int64 *)(lVar4 + 56);
          if (((*plVar1 == 0) || (lVar5 = GameObject.GetComponent(*plVar1,DAT_181d9e338)) == null) ||
             ((*(int64 *)(lVar5 + 24) == 0 ||
              (((uVar3 = EventData.GetEventRareLv(*(int64 *)(lVar5 + 24),0), lVar4 == null ||
                (lVar4 = FUN_180002f80(lVar4,uVar3,DAT_181d76758)) == null) ||
               (plVar8 == (int64 *)0)))))) goto LAB_180a1cc78;
          local_38 = lVar4.Count;
          uStack_34 = lVar4._version;
          uStack_30 = *(uint32 *)(lVar4 + 32);
          uStack_2c = *(uint32 *)(lVar4 + 36);
          (**(code **)(*plVar8 + 0x2a8))(plVar8,&local_38,*(uint64 *)(*plVar8 + 0x2b0));
          if (*plVar1 == 0) goto LAB_180a1cc78;
          lVar4 = GameObject.get_transform(*plVar1,0);
          puVar9 = (uint64 *)Vector3.get_zero(local_58,0);
          if (lVar4 == null) goto LAB_180a1cc78;
          local_70 = *(uint32 *)(puVar9 + 1);
          local_78 = *puVar9;
          Transform.set_localScale(lVar4,&local_78,0);
          if (*plVar1 == 0) goto LAB_180a1cc78;
          uVar7 = GameObject.get_transform(*plVar1,0);
          puVar9 = (uint64 *)Vector3.get_one(local_48,0);
          local_60 = *(uint32 *)(puVar9 + 1);
          local_68 = *puVar9;
          uVar7 = ShortcutExtensions.DOScale(uVar7,&local_68,0x3e4ccccd,0);
          TweenSettingsExtensions.SetDelay(uVar7,(float)iVar12 * 0.2 + 0.2);
          iVar12 = iVar12 + 1;
        LAB_180a1cc30:
          lVar4 = this.randomEvents;
          iVar11 = iVar11 + 1;
        } while( true );
    }

    // Token : 0x6000A4C
    // RVA   : 0xA1CC80   Offset: 0xA1B480   Length: 0x102
    public void FreshAreaEventGrid()
    {
        long lVar1;
        this.needRefreshAreaEventGrid = 0;
        if (this.buildingQuickButtonPanel != null) {
          lVar1 = GameObject.get_transform(this.buildingQuickButtonPanel,0);
          if (lVar1 != null) {
            lVar1 = Transform.Find(lVar1,"AreaEventQuickButtonGrid",0);
            if (lVar1 != null) {
              lVar1 = Component.GetComponent(lVar1,DAT_181d6e0c0);
              if (lVar1 != null) {
                UIGrid.set_repositionNow(lVar1,1,0);
                lVar1 = new WarpText_d__8(0,0);
                if (lVar1 != null) {
                  *(int64 *)(lVar1 + 32) = this;
                  FUN_180d837c0(this,lVar1,0);
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x6000A4D
    // RVA   : 0xA26060   Offset: 0xA24860   Length: 0x6C
    public IEnumerator SetAreaEventTitlePos()
    {
        long lVar1;
        lVar1 = new WarpText_d__8(0,0);
        if (lVar1 != null) {
          *(uint64 *)(lVar1 + 32) = this;
          return lVar1;
        }
    }

    // Token : 0x6000A4E
    // RVA   : 0xA1B320   Offset: 0xA19B20   Length: 0x227
    public void DeleteEventButton(EventData targetEvent)
    {
        ulong uVar1;
        int iVar2;
        long lVar3;
        long lVar4;
        int iVar5;
        lVar3 = this.buildingQuickButtonPanel;
        iVar5 = 0;
        while( true ) {
          if (((lVar3 == null) || (lVar3 = GameObject.get_transform(lVar3,0)) == null) ||
             (lVar3 = Transform.Find(lVar3,"AreaEventQuickButtonGrid",0)) == null) throw; // [null/range check failed]
          iVar2 = Transform.get_childCount(lVar3,0);
          if (iVar2 <= iVar5) {
            this.needRefreshAreaEventGrid = 1;
            return;
          }
          if (((this.buildingQuickButtonPanel == null) ||
              (lVar3 = GameObject.get_transform(this.buildingQuickButtonPanel,0)) == null) ||
             ((lVar3 = Transform.Find(lVar3,"AreaEventQuickButtonGrid",0), lVar3 == null ||
              ((lVar3 = Transform.GetChild(lVar3,iVar5), lVar3 == null ||
               (lVar4 = Component.GetComponent(lVar3)) == null))))) throw; // [null/range check failed]
          lVar3 = this.buildingQuickButtonPanel;
          if (*(int64 *)(lVar4 + 24) == targetEvent) break;
          iVar5 = iVar5 + 1;
        }
        if ((((lVar3 != null) && (lVar3 = GameObject.get_transform(lVar3,0)) != null) &&
            (lVar3 = Transform.Find(lVar3,"AreaEventQuickButtonGrid",0)) != null) &&
           (lVar3 = Transform.GetChild(lVar3,iVar5,0)) != null) {
          uVar1 = Component.get_gameObject(lVar3,0);
          Object.Destroy(uVar1,0);
          if (((this.buildingQuickButtonPanel != null) &&
              (lVar3 = GameObject.get_transform(this.buildingQuickButtonPanel,0)) != null) &&
             ((lVar3 = Transform.Find(lVar3,"AreaEventQuickButtonGrid",0), lVar3 != null &&
              (lVar3 = Component.GetComponent(lVar3,DAT_181d6e0c0)) != null))) {
            UIGrid.set_repositionNow(lVar3,1,0);
            return;
          }
        }
    }

    // Token : 0x6000A4F
    // RVA   : 0xA1AA40   Offset: 0xA19240   Length: 0x227
    public void AddEventButton(EventData targetEvent)
    {
        long lVar1;
        ulong uVar2;
        ulong uVar3;
        ulong local_28;
        uint local_20;
        byte[] local_18 = new byte[16];
        if (this.buildingQuickButtonPanel != null) {
          lVar1 = GameObject.get_transform(this.buildingQuickButtonPanel,0);
          if (lVar1 != null) {
            lVar1 = Transform.Find(lVar1,"AreaEventQuickButtonGrid",0);
            if (lVar1 != null) {
              uVar2 = Component.get_gameObject(lVar1,0);
              uVar3 = this.areaEventQuickButtonPrefab;
              uVar3 = GlobalData.AddChild(uVar2,uVar3,0);
              this.newObj = uVar3;
              if (this.newObj != null) {
                lVar1 = GameObject.GetComponent(this.newObj,DAT_181d9e338);
                if (lVar1 != null) {
                  *(uint64 *)(lVar1 + 24) = targetEvent;
                  if (this.newObj != null) {
                    lVar1 = GameObject.get_transform(this.newObj,0);
                    puVar4 = (uint64 *)Vector3.get_zero(local_18,0);
                    if (lVar1 != null) {
                      local_20 = *(uint32 *)(puVar4 + 1);
                      local_28 = *puVar4;
                      Transform.set_localScale(lVar1,&local_28,0);
                      if (this.newObj != null) {
                        uVar3 = GameObject.get_transform(this.newObj,0);
                        puVar4 = (uint64 *)Vector3.get_one(local_18,0);
                        local_20 = *(uint32 *)(puVar4 + 1);
                        local_28 = *puVar4;
                        ShortcutExtensions.DOScale(uVar3,&local_28,0x3dcccccd,0);
                        if (this.buildingQuickButtonPanel != null) {
                          lVar1 = GameObject.get_transform(this.buildingQuickButtonPanel,0);
                          if (lVar1 != null) {
                            lVar1 = Transform.Find(lVar1,"AreaEventQuickButtonGrid",0);
                            if (lVar1 != null) {
                              lVar1 = Component.GetComponent(lVar1,DAT_181d6e0c0);
                              if (lVar1 != null) {
                                UIGrid.set_repositionNow(lVar1,1,0);
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
    }

    // Token : 0x6000A50
    // RVA   : 0xA23F00   Offset: 0xA22700   Length: 0x16B
    public GameObject GetBuildingObj(AreaBuildingData targetBuildingData)
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        uint uVar4;
        long lVar5;
        lVar2 = this.areaBuilding;
        uVar4 = 0;
        if (lVar2 != null) {
          lVar5 = 32;
          do {
            if (lVar2.Count <= (int)uVar4) {
              return 0;
            }
            if (lVar2 == null) break;
            if (lVar2.Count <= uVar4) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            uVar3 = *(uint64 *)(lVar5 + lVar2._items);
            cVar1 = Object.op_Inequality(uVar3,0,0);
            if (cVar1) {
              if (((this.areaBuilding == null) ||
                  (lVar2 = FUN_180002f80(this.areaBuilding,uVar4)) == null) ||
                 (lVar2 = GameObject.GetComponent(lVar2)) == null) break;
              if (lVar2.Count == targetBuildingData) {
                if (this.areaBuilding != null) {
                  uVar3 = FUN_180002f80(this.areaBuilding,uVar4,DAT_181d62178);
                  return uVar3;
                }
                break;
              }
            }
            lVar2 = this.areaBuilding;
            uVar4 = uVar4 + 1;
            lVar5 = lVar5 + 8;
          } while (lVar2 != null);
        }
    }

    // Token : 0x6000A51
    // RVA   : 0xA24070   Offset: 0xA22870   Length: 0x16B
    public GameObject GetEventObj(EventData targetEventData)
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        uint uVar4;
        long lVar5;
        lVar2 = this.randomEvents;
        uVar4 = 0;
        if (lVar2 != null) {
          lVar5 = 32;
          do {
            if (lVar2.Count <= (int)uVar4) {
              return 0;
            }
            if (lVar2 == null) break;
            if (lVar2.Count <= uVar4) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            uVar3 = *(uint64 *)(lVar5 + lVar2._items);
            cVar1 = Object.op_Inequality(uVar3,0,0);
            if (cVar1) {
              if (((this.randomEvents == null) ||
                  (lVar2 = FUN_180002f80(this.randomEvents,uVar4)) == null) ||
                 (lVar2 = GameObject.GetComponent(lVar2)) == null) break;
              if (lVar2.Count == targetEventData) {
                if (this.randomEvents != null) {
                  uVar3 = FUN_180002f80(this.randomEvents,uVar4,DAT_181d62178);
                  return uVar3;
                }
                break;
              }
            }
            lVar2 = this.randomEvents;
            uVar4 = uVar4 + 1;
            lVar5 = lVar5 + 8;
          } while (lVar2 != null);
        }
    }

    // Token : 0x6000A52
    // RVA   : 0xA1CD90   Offset: 0xA1B590   Length: 0x546
    public void FreshAreaHeroIcon()
    {
        int iVar2;
        ulong uVar3;
        bool cVar4;
        int iVar5;
        int iVar6;
        long lVar7;
        long lVar8;
        ulong uVar9;
        uint uVar10;
        this.needRefreshHeroIcon = 0;
        if ((this.heroIconGrid != null) &&
           (lVar7 = GameObject.get_transform(this.heroIconGrid,0)) != null) {
          iVar5 = Transform.get_childCount(lVar7,0);
        joined_r0x000180a1ce44:
          iVar5 = iVar5 + -1;
          if (-1 < iVar5) {
            if (this.areaData != null) {
              lVar7 = this.areaData.insideHeros;
              if ((((this.heroIconGrid != null) &&
                   (lVar8 = GameObject.get_transform(this.heroIconGrid,0)) != null) &&
                  (lVar8 = Transform.GetChild(lVar8,iVar5,0)) != null) &&
                 (((lVar8 = Component.GetComponent(lVar8,DAT_181d6b8c0), lVar8 != null &&
                   (*(int64 *)(lVar8 + 32) != 0)) && (lVar7 != null)))) {
                cVar4 = FUN_181815240(lVar7,*(uint32 *)(*(int64 *)(lVar8 + 32) + 88));
                if (!cVar4) goto LAB_180a1cf3a;
                if (((this.heroIconGrid != null) &&
                    (lVar7 = GameObject.get_transform(this.heroIconGrid,0)) != null) &&
                   ((lVar7 = Transform.GetChild(lVar7,iVar5,0), lVar7 != null &&
                    ((lVar7 = Component.GetComponent(lVar7), lVar7 != null &&
                     (lVar7.areaStartLv != null)))))) goto code_r0x000180a1cf30;
              }
            }
            goto LAB_180a1d2d1;
          }
          lVar7 = this.areaData;
          uVar10 = 0;
          if (lVar7 == null) goto LAB_180a1d2d1;
          lVar8 = 32;
          while (lVar7.insideHeros != null) {
            if (*(int *)(lVar7.insideHeros + 24) <= (int)uVar10) {
              uVar9 = this.heroIconGrid;
              GlobalData.SortChild(uVar9,0);
              return;
            }
            if ((lVar7 = lVar7?.insideHeros) == null) break;
            if (lVar7.areaName <= uVar10) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            if (*(int *)(lVar8 + lVar7.areaID) != 0) {
              if ((this.areaData == null) ||
                 (lVar7 = AreaData.GetInsideHero(this.areaData,uVar10,0)) == null)
              break;
              if (!lVar7.changeAreaState) {
                if ((this.heroIconGrid == null) ||
                   (lVar7 = GameObject.get_transform(this.heroIconGrid,0)) == null)
                break;
                iVar5 = Transform.get_childCount(lVar7,0);
                do {
                  iVar5 = iVar5 + -1;
                  if (iVar5 < 0) {
                    uVar9 = this.heroIconGrid;
                    lVar7 = FUN_18046c1a0(0);
                    if (lVar7 == null) goto LAB_180a1d2d1;
                    uVar3 = lVar7.resourceValueRateTemp;
                    lVar7 = GlobalData.AddChild(uVar9,uVar3);
                    this.newObj = lVar7;
                    if (*plVar1 == 0) goto LAB_180a1d2d1;
                    lVar7 = GameObject.GetComponent(*plVar1,DAT_181d9fb20);
                    if ((this.areaData == null) ||
                       (uVar9 = AreaData.GetInsideHero(this.areaData,uVar10), lVar7 == null)
                       ) goto LAB_180a1d2d1;
                    lVar7.areaStartLv = uVar9;
                    if ((*plVar1 == 0) ||
                       (lVar7 = GameObject.GetComponent(*plVar1,DAT_181d9fb20)) == null)
                    goto LAB_180a1d2d1;
                    lVar7.areaName = 1;
                    if ((*plVar1 == 0) ||
                       (lVar7 = GameObject.GetComponent(*plVar1,DAT_181d9fb20)) == null)
                    goto LAB_180a1d2d1;
                    HeroIconController.AutoSetName(lVar7,0);
                    if ((*plVar1 == 0) ||
                       (lVar7 = GameObject.GetComponent(*plVar1,DAT_181d9fb20)) == null)
                    goto LAB_180a1d2d1;
                    HeroIconController.Init(lVar7,0);
                    break;
                  }
                  if ((((this.heroIconGrid == null) ||
                       (lVar7 = GameObject.get_transform(this.heroIconGrid,0)) == null)
                      || (lVar7 = Transform.GetChild(lVar7,iVar5,0)) == null) ||
                     ((lVar7 = Component.GetComponent(lVar7,DAT_181d6b8c0), lVar7 == null ||
                      (lVar7.areaStartLv == null)))) goto LAB_180a1d2d1;
                  iVar2 = *(int *)(lVar7.areaStartLv + 88);
                  if ((this.areaData == null) ||
                     (this.areaData.insideHeros == null)) goto LAB_180a1d2d1;
                  iVar6 = FUN_1800d6750();
                } while (iVar2 != iVar6);
              }
            }
            lVar7 = this.areaData;
            uVar10 = uVar10 + 1;
            lVar8 = lVar8 + 4;
            if (lVar7 == null) break;
          }
        }
        LAB_180a1d2d1:
                          // WARNING: Subroutine does not return
        FUN_1800d6620();
        code_r0x000180a1cf30:
        if (*(char *)(lVar7.areaStartLv + 96) != false) {
        LAB_180a1cf3a:
          if ((((this.heroIconGrid == null) ||
               (lVar7 = GameObject.get_transform(this.heroIconGrid,0)) == null) ||
              (lVar7 = Transform.GetChild(lVar7,iVar5,0)) == null) ||
             (lVar7 = Component.get_gameObject(lVar7,0)) == null) goto LAB_180a1d2d1;
          GameObject.SetActive(lVar7,0);
          if (((this.heroIconGrid == null) ||
              (lVar7 = GameObject.get_transform(this.heroIconGrid,0)) == null) ||
             (lVar7 = Transform.GetChild(lVar7,iVar5,0)) == null) goto LAB_180a1d2d1;
          uVar9 = Component.get_gameObject(lVar7);
          Object.Destroy(uVar9);
        }
        goto joined_r0x000180a1ce44;
    }

    // Token : 0x6000A53
    // RVA   : 0xA1DE70   Offset: 0xA1C670   Length: 0x607
    public void FreshAreaRandomEvent()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        ulong uVar2;
        bool cVar3;
        uint uVar4;
        long lVar5;
        long lVar6;
        ulong uVar7;
        long lVar8;
        long lVar9;
        int iVar12;
        int iVar13;
        ulong local_88;
        uint local_80;
        ulong local_78;
        uint local_70;
        byte[] local_58 = new byte[16];
        byte[] local_48 = new byte[16];
        byte[] local_38 = new byte[32];
        iVar13 = 0;
        while( true ) {
          if (((*pStatics == 0) ||
              (lVar5 = *(int64 *)(*pStatics + 32)) == null) ||
             (lVar5 = *(int64 *)(lVar5 + 104)) == null) break;
          if (lVar5.Count <= iVar13) {
            AreaController.FreshAreaEventButton(this,0);
            return;
          }
          lVar5 = FUN_18046c0a0(0);
          if (((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) ||
             (lVar5 = *(int64 *)(*(int64 *)(lVar5 + 32) + 104)) == null) break;
          lVar5 = FUN_180002f80(lVar5,iVar13,DAT_181d5e680);
          if (((lVar5 == null) || (this.areaData == null)) || (*(int64 *)(lVar5 + 64) == 0)
             ) break;
          cVar3 = FUN_181815240(*(int64 *)(lVar5 + 64),
                                this.areaData.areaID,DAT_181d67bf8);
          if (cVar3) {
            iVar12 = 0;
            while( true ) {
              lVar5 = this.randomEvents;
              if (lVar5 == null) throw; // [null/range check failed]
              if (lVar5.Count <= iVar12) break;
              lVar5 = FUN_180002f80(lVar5,iVar12,DAT_181d62178);
              if (lVar5 == null) throw; // [null/range check failed]
              lVar5 = GameObject.GetComponent(lVar5,DAT_181d9e448);
              if (lVar5 == null) throw; // [null/range check failed]
              lVar5 = lVar5.Count;
              lVar6 = FUN_18046c0a0(0);
              if (((lVar6 == null) || (*(int64 *)(lVar6 + 32) == 0)) ||
                 (lVar6 = *(int64 *)(*(int64 *)(lVar6 + 32) + 104)) == null)
              throw; // [null/range check failed]
              lVar6 = FUN_180002f80(lVar6,iVar13);
              if (lVar5 == lVar6) goto LAB_180a1e437;
              iVar12 = iVar12 + 1;
            }
            uVar7 = this.areaGridRoot;
            uVar2 = this.areaRandomEventPrefab;
            lVar5 = GlobalData.AddChild(uVar7,uVar2,0);
            this.newObj = lVar5;
            if (*plVar1 == 0) break;
            lVar5 = GameObject.GetComponent(*plVar1,DAT_181d9e448);
            lVar6 = FUN_18046c0a0(0);
            if (((lVar6 == null) || (*(int64 *)(lVar6 + 32) == 0)) ||
               (lVar6 = *(int64 *)(*(int64 *)(lVar6 + 32) + 104)) == null) break;
            uVar7 = FUN_180002f80(lVar6,iVar13,DAT_181d5e680);
            if (lVar5 == null) break;
            lVar5.Count = uVar7;
            if (*plVar1 == 0) break;
            lVar5 = GameObject.get_transform(*plVar1,0);
            if (this.areaData == null) break;
            lVar6 = this.areaData.areaTiles;
            lVar8 = FUN_18046c0a0(0);
            if (((lVar8 == null) || (*(int64 *)(lVar8 + 32) == 0)) ||
               (lVar8 = *(int64 *)(*(int64 *)(lVar8 + 32) + 104)) == null) break;
            lVar8 = FUN_180002f80(lVar8,iVar13,DAT_181d5e680);
            if (lVar8 == null) break;
            lVar8 = *(int64 *)(lVar8 + 72);
            lVar9 = FUN_18046c0a0(0);
            if (((lVar9 == null) || (*(int64 *)(lVar9 + 32) == 0)) ||
               (lVar9 = *(int64 *)(*(int64 *)(lVar9 + 32) + 104)) == null) break;
            lVar9 = FUN_180002f80(lVar9,iVar13,DAT_181d5e680);
            if (((lVar9 == null) || (this.areaData == null)) ||
               (*(int64 *)(lVar9 + 64) == 0)) break;
            uVar4 = FUN_1817ff280(*(int64 *)(lVar9 + 64),
                                  this.areaData.areaID,DAT_181d67d78);
            if (lVar8 == null) break;
            uVar4 = FUN_1800d6750(lVar8,uVar4,DAT_181d68270);
            if (lVar6 == null) break;
            uVar7 = FUN_180002f80(lVar6,uVar4,DAT_181d554e0);
            lVar6 = AreaController.FindGrid(this,uVar7,0);
            if (lVar6 == null) break;
            lVar6 = GameObject.get_transform(lVar6,0);
            if (lVar6 == null) break;
            puVar10 = (uint64 *)Transform.get_localPosition(local_58,lVar6,0);
            if (lVar5 == null) break;
            local_88 = *puVar10;
            local_80 = *(uint32 *)(puVar10 + 1);
            Transform.set_localPosition(lVar5,&local_88,0);
            if (*plVar1 == 0) break;
            lVar5 = GameObject.get_transform(*plVar1,0);
            if (*plVar1 == 0) break;
            lVar6 = GameObject.get_transform(*plVar1,0);
            if (lVar6 == null) break;
            puVar11 = (uint32 *)Transform.get_localPosition(local_48,lVar6,0);
            uVar4 = *puVar11;
            if (*plVar1 == 0) break;
            lVar6 = GameObject.get_transform(*plVar1,0);
            if (lVar6 == null) break;
            lVar6 = Transform.get_localPosition(local_38,lVar6,0);
            if (lVar5 == null) break;
            local_78 = CONCAT44(*(uint32 *)(lVar6 + 4),uVar4);
            local_70 = 0xc0400000;
            Transform.set_localPosition(lVar5,&local_78,0);
            if (this.randomEvents == null) break;
            FUN_181827900(this.randomEvents,*plVar1,DAT_181d61bf8);
          }
        LAB_180a1e437:
          iVar13 = iVar13 + 1;
        }
    }

    // Token : 0x6000A54
    // RVA   : 0xA1B550   Offset: 0xA19D50   Length: 0xFA
    public GameObject FindGrid(AreaTileData targetTile)
    {
        long lVar1;
        ulong uVar2;
        long lVar3;
        long lVar4;
        uint uVar5;
        lVar3 = this.gridPool;
        uVar5 = 0;
        if (lVar3 != null) {
          lVar4 = 32;
          do {
            if (lVar3.Count <= (int)uVar5) {
              return 0;
            }
            if (lVar3 == null) break;
            if (lVar3.Count <= uVar5) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar3 = *(int64 *)(lVar4 + lVar3._items);
            if ((lVar3 == null) || (lVar1 = GameObject.GetComponent(lVar3,DAT_181d9e4d0)) == null)
            break;
            lVar3 = this.gridPool;
            if (*(int64 *)(lVar1 + 24) == targetTile) {
              if (lVar3 != null) {
                uVar2 = FUN_180002f80(lVar3,uVar5,DAT_181d62178);
                return uVar2;
              }
              break;
            }
            uVar5 = uVar5 + 1;
            lVar4 = lVar4 + 8;
          } while (lVar3 != null);
        }
    }

    // Token : 0x6000A55
    // RVA   : 0xA223F0   Offset: 0xA20BF0   Length: 0x355
    public void GenerateLittlePeople()
    {
        uint uVar3;
        long lVar4;
        ulong uVar5;
        ulong uVar6;
        long lVar7;
        int iVar9;
        int iVar10;
        int[] local_res8 = new int[2];
        ulong local_48;
        uint local_40;
        byte[] local_38 = new byte[16];
        lVar4 = this.areaData;
        if (lVar4 != null) {
          local_res8[0] = lVar4.areaType;
          if (local_res8[0] == 0) {
            lVar4 = AreaData.GetCenterBuilding(lVar4,0);
            if (lVar4 != null) {
              iVar10 = *(int *)(lVar4 + 20) * 8 + 80;
              goto LAB_180a224f0;
            }
          }
          else if (local_res8[0] == 1) {
            lVar4 = AreaData.GetCenterBuilding(lVar4,0);
            if (lVar4 != null) {
              iVar10 = *(int *)(lVar4 + 20) * 4 + 40;
              goto LAB_180a224f0;
            }
          }
          else {
            if (local_res8[0] != 2) {
              return;
            }
            lVar4 = AreaData.GetForce(lVar4,0);
            if (lVar4 != null) {
              iVar10 = (*(int *)(lVar4 + 52) + 10) * 3;
        LAB_180a224f0:
              iVar9 = 0;
              if (0 < iVar10) {
                do {
                  if (((this.areaGridRoot == null) ||
                      (lVar4 = GameObject.get_transform(this.areaGridRoot,0)) == null) ||
                     (lVar4 = Transform.Find(lVar4,"RoadDecoration",0)) == null) throw; // [null/range check failed]
                  uVar5 = Component.get_gameObject(lVar4,0);
                  uVar6 = this.areaLittlePeoplePrefab;
                  lVar4 = GlobalData.AddChild(uVar5,uVar6,0);
                  this.newObj = lVar4;
                  if ((*plVar1 == 0) ||
                     (lVar4 = GameObject.GetComponent(*plVar1,DAT_181da0290)) == null)
                  throw; // [null/range check failed]
                  lVar4 = lVar4.areaStartLv;
                  local_res8[0] = FUN_180d8cf10(0,36);
                  uVar6 = Int32.ToString(local_res8,0);
                  uVar6 = String.Concat("skin",uVar6,0);
                  if (lVar4 == null) throw; // [null/range check failed]
                  lVar4.areaStartLv = uVar6;
                  if (((*plVar1 == 0) ||
                      (lVar4 = GameObject.GetComponent(*plVar1,DAT_181da0290)) == null) ||
                     (plVar2 = lVar4.areaStartLv, plVar2 == (int64 *)0))
                  throw; // [null/range check failed]
                  (**(code **)(*plVar2 + 0x1c8))(plVar2,1,0,*(uint64 *)(*plVar2 + 0x1d0));
                  if (*plVar1 == 0) throw; // [null/range check failed]
                  lVar4 = GameObject.GetComponent(*plVar1,DAT_181da0290);
                  uVar3 = FUN_180d8cf10(0,4);
                  if (lVar4 == null) throw; // [null/range check failed]
                  lVar4.areaName = uVar3;
                  if (*plVar1 == 0) throw; // [null/range check failed]
                  lVar4 = GameObject.get_transform(*plVar1,0);
                  uVar6 = this.areaData;
                  if (((*plVar1 == 0) ||
                      (lVar7 = GameObject.GetComponent(*plVar1,DAT_181da0290)) == null) ||
                     (puVar8 = (uint64 *)
                               AreaController.GetAreaRandomRoadPos
                                         (local_38,this,uVar6,*(uint32 *)(lVar7 + 24),0),
                     lVar4 == null)) throw; // [null/range check failed]
                  local_48 = *puVar8;
                  local_40 = *(uint32 *)(puVar8 + 1);
                  Transform.set_localPosition(lVar4,&local_48,0);
                  if (this.littlePeoples == null) throw; // [null/range check failed]
                  FUN_181827900();
                  iVar9 = iVar9 + 1;
                } while (iVar9 < iVar10);
              }
              return;
            }
          }
        }
    }

    // Token : 0x6000A56
    // RVA   : 0xA24A20   Offset: 0xA23220   Length: 0x1DF
    public void OnDrag(Vector2 delta)
    {
        float fVar1;
        ulong uVar2;
        bool cVar3;
        ulong uVar4;
        long lVar5;
        long lVar6;
        float local_res20;
        float fStackX_24;
        float local_68;
        float fStack_64;
        ulong local_58;
        float local_50;
        byte[] local_48 = new byte[8];
        float local_40;
        byte[] local_38 = new byte[32];
        uVar4 = Vector2.get_zero(0);
        local_res20 = (float)delta;
        fStackX_24 = (float)((uint64)delta >> 32);
        local_68 = (float)uVar4;
        fStack_64 = (float)((uint64)uVar4 >> 32);
        if (((fStackX_24 - fStack_64) * (fStackX_24 - fStack_64) +
             (local_res20 - local_68) * (local_res20 - local_68) < 9.9999994e-11) ||
           (cVar3 = AreaController.CanDrag(this,0), !cVar3)) {
          return;
        }
        if (this.areaGridRoot != null) {
          lVar5 = GameObject.get_transform(this.areaGridRoot,0);
          if ((this.areaGridRoot != null) &&
             (lVar6 = GameObject.get_transform(this.areaGridRoot,0)) != null) {
            puVar7 = (uint64 *)Transform.get_localPosition(local_48,lVar6,0);
            uVar2 = this.areaGrid;
            uVar4 = *puVar7;
            fVar1 = *(float *)(puVar7 + 1);
            puVar7 = (uint64 *)GlobalData.TransformScreenDeltaToLocalDelta(local_38,delta,uVar2,0);
            local_68 = (float)uVar4;
            fStack_64 = (float)((uint64)uVar4 >> 32);
            local_50 = fVar1 + *(float *)(puVar7 + 1);
            local_58 = CONCAT44(fStack_64 + (float)((uint64)*puVar7 >> 32),local_68 + (float)*puVar7)
            ;
            local_40 = local_50;
            puVar7 = (uint64 *)
                     AreaController.LimitMapPos
                               (local_38,this,&local_58,this.nowScale,0);
            if (lVar5 != null) {
              local_58 = *puVar7;
              local_50 = *(float *)(puVar7 + 1);
              Transform.set_localPosition(lVar5,&local_58,0);
              return;
            }
          }
        }
    }

    // Token : 0x6000A57
    // RVA   : 0xA1B1F0   Offset: 0xA199F0   Length: 0xCB
    public bool CanDrag()
    {
        ulong uVar1;
        bool cVar2;
        long lVar3;
        if (this.areaGridRoot != null) {
          uVar1 = GameObject.GetComponent(this.areaGridRoot,DAT_181da1930);
          cVar2 = Object.op_Equality(uVar1,0,0);
          if (cVar2) {
        LAB_180a1b2a6:
            return !this.startAniming;
          }
          if (this.areaGridRoot != null) {
            lVar3 = GameObject.GetComponent(this.areaGridRoot,DAT_181da1930);
            if (lVar3 != null) {
              cVar2 = Behaviour.get_isActiveAndEnabled(lVar3,0);
              if (cVar2) {
                return false;
              }
              goto LAB_180a1b2a6;
            }
          }
        }
    }

    // Token : 0x6000A58
    // RVA   : 0xA24C00   Offset: 0xA23400   Length: 0xA3
    public void OnScroll(float delta)
    {
        var pStatics = *(int64*)(DAT_181d87630 + 184);
        float fVar1;
        uint uVar2;
        if (!this.startAniming) {
          fVar1 = this.nowScale;
          uVar2 = FUN_1810a8ba0(fVar1 + delta,
                                *(uint32 *)(pStatics + 16),
                                *(uint32 *)(pStatics + 20),0);
          this.nowScale = uVar2;
        }
    }

    // Token : 0x6000A59
    // RVA   : 0xA23A80   Offset: 0xA22280   Length: 0x40F
    public Vector3 GetAreaRandomRoadPos(AreaData targetArea, int direction)
    {
        float * AreaController.GetAreaRandomRoadPos
                        (float *this,uint64 targetArea,int64 direction,int param_4)
        {
        int iVar1;
        int iVar2;
        float fVar3;
        float fVar4;
        float fVar5;
        float fVar6;
        fVar4 = 0.0;
        fVar5 = 0.0;
        fVar3 = (float)Random.get_value(0);
        if (param_4 == 0) {
          if (direction == null) {
        LAB_180a23e8a:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          iVar1 = *(int *)(direction + 188);
          fVar5 = (float)Random.Range();
          fVar5 = fVar5 + (float)(iVar1 + -1) * 0.5;
          fVar6 = (float)(*(int *)(direction + 184) + -1) * 0.5;
          if (((fVar3 < 0.3) && ((*(byte *)(DAT_181d4ef00 + 0x133) & 4) != 0)) &&
             (*(int *)(DAT_181d4ef00 + 224) == 0)) {
            il2cpp_runtime_class_init(DAT_181d4ef00);
          }
        }
        else {
          if (param_4 != 1) {
            if (param_4 == 2) {
              if (direction == null) goto LAB_180a23e8a;
              iVar1 = *(int *)(direction + 184);
              fVar4 = (float)Random.Range();
              iVar2 = *(int *)(direction + 188);
              fVar4 = fVar4 + (float)(iVar1 + -1) * 0.5;
              if (((fVar3 < 0.3) && ((*(byte *)(DAT_181d4ef00 + 0x133) & 4) != 0)) &&
                 (*(int *)(DAT_181d4ef00 + 224) == 0)) {
                il2cpp_runtime_class_init(DAT_181d4ef00);
              }
              fVar5 = (float)Random.Range();
              fVar5 = fVar5 + (float)(iVar2 + -1) * 0.5;
            }
            else if (param_4 == 3) {
              if (direction == null) goto LAB_180a23e8a;
              iVar1 = *(int *)(direction + 184);
              fVar4 = (float)Random.Range();
              iVar2 = *(int *)(direction + 188);
              fVar4 = fVar4 + (float)(iVar1 + -1) * 0.5;
              if (((fVar3 < 0.3) && ((*(byte *)(DAT_181d4ef00 + 0x133) & 4) != 0)) &&
                 (*(int *)(DAT_181d4ef00 + 224) == 0)) {
                il2cpp_runtime_class_init(DAT_181d4ef00);
              }
              fVar5 = (float)Random.Range();
              fVar5 = fVar5 + (float)(iVar2 + -1) * 0.5;
            }
            goto LAB_180a23e52;
          }
          if (direction == null) goto LAB_180a23e8a;
          iVar1 = *(int *)(direction + 188);
          fVar5 = (float)Random.Range();
          fVar5 = fVar5 + (float)(iVar1 + -1) * 0.5;
          fVar6 = (float)(*(int *)(direction + 184) + -1) * 0.5;
          if (((fVar3 < 0.3) && ((*(byte *)(DAT_181d4ef00 + 0x133) & 4) != 0)) &&
             (*(int *)(DAT_181d4ef00 + 224) == 0)) {
            il2cpp_runtime_class_init(DAT_181d4ef00);
          }
        }
        fVar4 = (float)Random.Range();
        fVar4 = fVar4 + fVar6;
        LAB_180a23e52:
        *this = fVar4;
        this[1] = fVar5;
        this[2] = 0.0;
        return this;
    }

    // Token : 0x6000A5A
    // RVA   : 0xA1D2E0   Offset: 0xA1BAE0   Length: 0xB81
    public void FreshAreaInfo(bool forceRefresh)
    {
        bool cVar1;
        long lVar2;
        long lVar3;
        ulong uVar4;
        ulong uVar5;
        ulong uVar8;
        ulong uVar9;
        int iVar10;
        long lVar11;
        uint uVar12;
        float fVar13;
        int[] local_res8 = new int[2];
        uint[] local_res20 = new uint[2];
        uint[] local_b8 = new uint[4];
        uint local_a8;
        uint uStack_a4;
        uint uStack_a0;
        uint32 uStack_9c;
        uint8 local_98 [16];
        uint8 local_88 [16];
        uint8 local_78 [80];
        lVar2 = this.areaData;
        iVar10 = 0;
        local_res20[0] = 0;
        local_res8[0] = 0;
        if ((lVar2 == null) || (!forceRefresh && !lVar2.areaInfoDirty)) {
          return;
        }
        lVar2.areaInfoDirty = 0;
        if ((((this.areaUIBelow == null) ||
             (lVar2 = GameObject.get_transform(this.areaUIBelow,0)) == null) ||
            (lVar2 = Transform.Find(lVar2,"AreaTitle",0)) == null) ||
           (lVar2 = Transform.Find(lVar2,"Force",0)) == null) goto LAB_180a1de5c;
        lVar2 = Component.GetComponent(lVar2,DAT_181d6bc40);
        lVar11 = **(int64 **)(DAT_181d86270 + 184);
        if (this.areaData == null) goto LAB_180a1de5c;
        lVar3 = AreaData.GetForce(this.areaData,0);
        uVar5 = "UIAtlas";
        if (lVar3 == null) {
        LAB_180a1d535:
          if (this.areaData == null) goto LAB_180a1de5c;
          uVar12 = this.areaData.belongForceID;
        }
        else {
          if ((this.areaData == null) ||
             (lVar3 = AreaData.GetForce(this.areaData,0)) == null)
          goto LAB_180a1de5c;
          if (*(int *)(lVar3 + 60) < 0) goto LAB_180a1d535;
          if ((this.areaData == null) ||
             (lVar3 = AreaData.GetForce(this.areaData,0)) == null)
          goto LAB_180a1de5c;
          uVar12 = *(uint32 *)(lVar3 + 60);
        }
        uVar4 = GlobalData.GetForceIconName(uVar12,0);
        if ((lVar11 != null) &&
           (uVar5 = TextureController.LoadAtlasSprite(lVar11,uVar5,uVar4,0), lVar2 != null)) {
          Image.set_sprite(lVar2,uVar5,0);
          lVar2 = this.areaData;
          local_b8[0] = 0;
          if (lVar2 != null) {
            while (lVar2.changeResource != null) {
              if (*(int *)(lVar2.changeResource + 24) <= (int)local_b8[0]) goto LAB_180a1d790;
              lVar2 = this.areaInfo;
              uVar5 = Int32.ToString(local_b8,0);
              if (((lVar2 == null) || (lVar2 = Transform.Find(lVar2,uVar5,0)) == null) ||
                 (lVar2 = Transform.Find(lVar2,"Text",0)) == null) break;
              uVar5 = Component.GetComponent(lVar2,DAT_181d6d8c0);
              if (this.areaData == null) break;
              lVar2 = this.areaData.changeResource;
              lVar11 = (int64)(int)local_b8[0];
              if (lVar2 == null) break;
              if (lVar2.areaName <= local_b8[0]) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              local_res20[0] = *(uint32 *)(lVar2.areaID + 32 + lVar11 * 4);
              uVar4 = Single.ToString(local_res20,"+0;-0;+0",0);
              LTLocalization.SetText(uVar5,uVar4,0);
              lVar2 = this.areaInfo;
              uVar5 = Int32.ToString(local_b8,0);
              if (((lVar2 == null) || (lVar2 = Transform.Find(lVar2,uVar5,0)) == null) ||
                 (lVar2 = Transform.Find(lVar2,"Text",0)) == null) break;
              plVar6 = (int64 *)Component.GetComponent(lVar2,DAT_181d6d8c0);
              if (this.areaData == null) break;
              lVar2 = this.areaData.changeResource;
              lVar11 = (int64)(int)local_b8[0];
              if (lVar2 == null) break;
              if (lVar2.areaName <= local_b8[0]) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              if (*(float *)(lVar2.areaID + 32 + lVar11 * 4) < 0.0) {
                puVar7 = (uint32 *)Color.get_red(local_88,0);
              }
              else {
                puVar7 = (uint32 *)Color.get_green(local_98);
              }
              if (plVar6 == (int64 *)0) break;
              local_a8 = *puVar7;
              uStack_a4 = puVar7[1];
              uStack_a0 = puVar7[2];
              uStack_9c = puVar7[3];
              (**(code **)(*plVar6 + 0x2a8))(plVar6);
              lVar2 = this.areaData;
              local_b8[0] = local_b8[0] + 1;
              if (lVar2 == null) break;
            }
          }
        }
        LAB_180a1de5c:
                          // WARNING: Subroutine does not return
        FUN_1800d6620();
        LAB_180a1d790:
        lVar2 = *(int64 *)(*(int64 *)(DAT_181d4ef00 + 184) + 0x600);
        if (lVar2 == null) goto LAB_180a1de5c;
        if (iVar10 < lVar2.areaName) {
          if (this.areaData == null) goto LAB_180a1de5c;
          lVar2 = this.areaInfo;
          if (this.areaData.areaType == 2) {
            uVar5 = Int32.ToString(local_res8,0);
            String.Concat("State",uVar5);
            if (((lVar2 == null) || (lVar2 = Transform.Find(lVar2)) == null) ||
               (lVar2 = Component.get_gameObject(lVar2)) == null) goto LAB_180a1de5c;
            cVar1 = GameObject.get_activeSelf(lVar2);
            if (cVar1) {
              lVar2 = this.areaInfo;
              uVar5 = Int32.ToString(local_res8,0);
              String.Concat("State",uVar5);
              if (((lVar2 == null) || (lVar2 = Transform.Find(lVar2)) == null) ||
                 (lVar2 = Component.get_gameObject(lVar2)) == null) goto LAB_180a1de5c;
              GameObject.SetActive(lVar2);
            }
            iVar10 = local_res8[0] + 1;
            local_res8[0] = iVar10;
          }
          else {
            uVar5 = Int32.ToString(local_res8,0);
            uVar5 = String.Concat("State",uVar5,0);
            if (((lVar2 == null) || (lVar2 = Transform.Find(lVar2,uVar5,0)) == null) ||
               (lVar2 = Component.get_gameObject(lVar2,0)) == null) goto LAB_180a1de5c;
            cVar1 = GameObject.get_activeSelf(lVar2,0);
            if (!cVar1) {
              lVar2 = this.areaInfo;
              uVar5 = Int32.ToString(local_res8,0);
              uVar5 = String.Concat("State",uVar5,0);
              if (((lVar2 == null) || (lVar2 = Transform.Find(lVar2,uVar5,0)) == null) ||
                 (lVar2 = Component.get_gameObject(lVar2,0)) == null) goto LAB_180a1de5c;
              GameObject.SetActive(lVar2,1,0);
            }
            lVar2 = this.areaInfo;
            uVar5 = Int32.ToString(local_res8,0);
            uVar5 = String.Concat("State",uVar5,0);
            if (((lVar2 == null) || (lVar2 = Transform.Find(lVar2,uVar5,0)) == null) ||
               (lVar2 = Transform.Find(lVar2,"Bar",0)) == null) goto LAB_180a1de5c;
            lVar2 = Component.GetComponent(lVar2,DAT_181d6bc40);
            if ((this.areaData == null) ||
               (uVar12 = AreaData.GetAreaStatePercent(this.areaData,local_res8[0],0),
               lVar2 == null)) goto LAB_180a1de5c;
            Image.set_fillAmount(lVar2,uVar12,0);
            lVar2 = this.areaInfo;
            uVar5 = Int32.ToString(local_res8,0);
            uVar5 = String.Concat("State",uVar5,0);
            if ((lVar2 == null) ||
               ((lVar2 = Transform.Find(lVar2,uVar5,0), lVar2 == null ||
                (lVar2 = Transform.Find(lVar2,"Bar",0)) == null))) goto LAB_180a1de5c;
            plVar6 = (int64 *)Component.GetComponent(lVar2,DAT_181d6bc40);
            lVar2 = this.areaInfo;
            uVar5 = Int32.ToString(local_res8,0);
            uVar5 = String.Concat("State",uVar5,0);
            if ((lVar2 == null) ||
               (((lVar2 = Transform.Find(lVar2,uVar5,0), lVar2 == null ||
                 (lVar2 = Transform.Find(lVar2,"Bar",0)) == null) ||
                (lVar2 = Component.GetComponent(lVar2,DAT_181d6bc40)) == null))) goto LAB_180a1de5c;
            uVar12 = lVar2.thisMonthManaged;
            puVar7 = (uint32 *)GlobalData.GetAmountColor(local_88,uVar12,0x3f800000,0);
            if (plVar6 == (int64 *)0) goto LAB_180a1de5c;
            local_a8 = *puVar7;
            uStack_a4 = puVar7[1];
            uStack_a0 = puVar7[2];
            uStack_9c = puVar7[3];
            (**(code **)(*plVar6 + 0x2a8))(plVar6,&local_a8,*(uint64 *)(*plVar6 + 0x2b0));
            lVar2 = this.areaInfo;
            uVar5 = Int32.ToString(local_res8,0);
            uVar5 = String.Concat("State",uVar5,0);
            if (((lVar2 == null) || (lVar2 = Transform.Find(lVar2,uVar5,0)) == null) ||
               (lVar2 = Transform.Find(lVar2,"Num",0)) == null) goto LAB_180a1de5c;
            uVar5 = Component.GetComponent(lVar2,DAT_181d6d8c0);
            if (this.areaData == null) goto LAB_180a1de5c;
            local_res20[0] = AreaData.GetAreaState(this.areaData,local_res8[0],0);
            uVar8 = Single.ToString(local_res20,"f0",0);
            uVar4 = "/";
            if (local_res8[0] == 3) {
              if (this.areaData == null) goto LAB_180a1de5c;
              local_res20[0] = this.areaData.maxPeople;
            }
            else {
              local_res20[0] = 0x42c80000;
            }
            uVar9 = Single.ToString(local_res20,0);
            uVar4 = String.Concat(uVar8,uVar4,uVar9);
            LTLocalization.SetText(uVar5,uVar4,0);
            lVar2 = this.areaInfo;
            uVar5 = Int32.ToString(local_res8,0);
            uVar5 = String.Concat("State",uVar5,0);
            if (((lVar2 == null) || (lVar2 = Transform.Find(lVar2,uVar5,0)) == null) ||
               (lVar2 = Transform.Find(lVar2,"AddNum",0)) == null) goto LAB_180a1de5c;
            uVar5 = Component.GetComponent(lVar2,DAT_181d6d8c0);
            if (this.areaData == null) goto LAB_180a1de5c;
            local_res20[0] = AreaData.GetChangeAreaState(this.areaData,local_res8[0],0);
            uVar4 = Single.ToString(local_res20,"+0;-0;+0",0);
            LTLocalization.SetText(uVar5,uVar4,0);
            lVar2 = this.areaInfo;
            uVar5 = Int32.ToString(local_res8,0);
            uVar5 = String.Concat("State",uVar5,0);
            if (((lVar2 == null) || (lVar2 = Transform.Find(lVar2,uVar5,0)) == null) ||
               (lVar2 = Transform.Find(lVar2,"AddNum",0)) == null) goto LAB_180a1de5c;
            plVar6 = (int64 *)Component.GetComponent(lVar2,DAT_181d6d8c0);
            if (this.areaData == null) goto LAB_180a1de5c;
            fVar13 = (float)AreaData.GetChangeAreaState(this.areaData,local_res8[0],0);
            if (fVar13 < 0.0) {
              puVar7 = (uint32 *)Color.get_red(local_78,0);
            }
            else {
              puVar7 = (uint32 *)Color.get_green(local_98);
            }
            if (plVar6 == (int64 *)0) goto LAB_180a1de5c;
            local_a8 = *puVar7;
            uStack_a4 = puVar7[1];
            uStack_a0 = puVar7[2];
            uStack_9c = puVar7[3];
            (**(code **)(*plVar6 + 0x2a8))(plVar6);
            iVar10 = local_res8[0] + 1;
            local_res8[0] = iVar10;
          }
          goto LAB_180a1d790;
        }
        uVar5 = this.areaLog;
        if (this.areaData != null) {
          uVar4 = AreaData.GetRecordLog(this.areaData,0);
          LTLocalization.SetText(uVar5,uVar4,0);
          AreaController.FreshResourcePointUIGrid(this,0);
          return;
        }
        goto LAB_180a1de5c;
    }

    // Token : 0x6000A5B
    // RVA   : 0xA1E940   Offset: 0xA1D140   Length: 0x236
    public void FreshResourcePointUIGrid()
    {
        var pStatics = *(int64*)(DAT_181d4e188 + 184);
        long lVar1;
        uint uVar2;
        long lVar3;
        long lVar4;
        ulong uVar5;
        int iVar6;
        if (this.areaData == null) {
          return;
        }
        uVar5 = this.resourcePointUIGrid;
        GlobalData.DeleteAllChild(uVar5,0);
        lVar3 = this.areaData;
        iVar6 = 0;
        if (lVar3 != null) {
          while (lVar3.connectResourcePointID != null) {
            lVar4 = this.resourcePointUIGrid;
            if (*(int *)(lVar3.connectResourcePointID + 24) <= iVar6) {
              if ((lVar4 != null) && (lVar3 = GameObject.GetComponent(lVar4,DAT_181da2630)) != null) {
                UIGrid.set_repositionNow(lVar3,1,0);
                return;
              }
              break;
            }
            if (*pStatics == 0) break;
            uVar5 = *(uint64 *)(*pStatics + 104);
            lVar3 = GlobalData.AddChild(lVar4,uVar5,0);
            if (lVar3 == null) break;
            lVar3 = GameObject.GetComponent(lVar3,DAT_181da0e30);
            lVar4 = FUN_18046c0a0(0);
            if (lVar4 == null) break;
            lVar4 = *(int64 *)(lVar4 + 32);
            if ((((this.areaData == null) ||
                 (lVar1 = this.areaData.connectResourcePointID) == null) ||
                (uVar2 = FUN_1800d6750(lVar1,iVar6), lVar4 == null)) ||
               (uVar5 = WorldData.GetResourcePoint(lVar4,uVar2), lVar3 == null)) break;
            lVar3.areaName = uVar5;
            lVar3 = this.areaData;
            iVar6 = iVar6 + 1;
            if (lVar3 == null) break;
          }
        }
    }

    // Token : 0x6000A5C
    // RVA   : 0xA1E480   Offset: 0xA1CC80   Length: 0x4BE
    public void FreshAreaTreasurePriceGrid()
    {
        var pStatics = *(int64*)(DAT_181d4e188 + 184);
        long lVar1;
        long lVar2;
        ulong uVar3;
        long lVar4;
        ulong uVar5;
        int iVar8;
        int iVar9;
        uint local_58;
        float local_54;
        uint local_50;
        ulong local_48;
        ulong uStack_40;
        byte[] local_38 = new byte[16];
        byte[] local_28 = new byte[16];
        this.needRefreshAreaTreasurePriceGrid = 0;
        if (this.areaData == null) {
          return;
        }
        uVar3 = this.treasurePriceGrid;
        GlobalData.DeleteAllChild(uVar3,0);
        lVar1 = this.areaData;
        iVar9 = 0;
        if (lVar1 != null) {
          while (lVar1.areaTreasurePriceData != null) {
            lVar2 = this.treasurePriceGrid;
            if (*(int *)(lVar1.areaTreasurePriceData + 24) <= iVar9) {
              if ((lVar2 != null) && (lVar1 = GameObject.GetComponent(lVar2,DAT_181da2630)) != null) {
                UIGrid.set_repositionNow(lVar1,1,0);
                return;
              }
              break;
            }
            if (*pStatics == 0) break;
            uVar3 = *(uint64 *)(*pStatics + 192);
            lVar1 = GlobalData.AddChild(lVar2,uVar3,0);
            if (((lVar1 == null) || (lVar2 = GameObject.get_transform(lVar1,0)) == null) ||
               (lVar2 = Transform.Find(lVar2,"Text",0)) == null) break;
            uVar3 = Component.GetComponent(lVar2,DAT_181d6d8c0);
            lVar2 = *(int64 *)(*(int64 *)(DAT_181d4ef00 + 184) + 0x508);
            if (((this.areaData == null) ||
                (lVar4 = this.areaData.areaTreasurePriceData) == null) ||
               ((lVar4 = FUN_180002f80(lVar4,iVar9,DAT_181d55758), lVar4 == null || (lVar2 == null)))) break;
            uVar5 = FUN_180002f80(lVar2,*(uint32 *)(lVar4 + 16),DAT_181d7c9c0);
            LTLocalization.SetText(uVar3,uVar5,0);
            lVar2 = GameObject.get_transform(lVar1,0);
            if ((lVar2 == null) || (lVar2 = Transform.Find(lVar2,"Back",0)) == null) break;
            lVar2 = Component.GetComponent(lVar2,DAT_181d6ccc0);
            if ((this.areaData == null) ||
               (((lVar4 = this.areaData.areaTreasurePriceData, lVar4 == null ||
                 (lVar4 = FUN_180002f80(lVar4,iVar9,DAT_181d55758)) == null) ||
                (uVar3 = AreaTreasurePriceData.GetFullDescribe(lVar4,0), lVar2 == null)))) break;
            *(uint64 *)(lVar2 + 24) = uVar3;
            lVar2 = GameObject.get_transform(lVar1,0);
            if ((lVar2 == null) || (lVar2 = Transform.Find(lVar2,"Icon",0)) == null) break;
            plVar6 = (int64 *)Component.GetComponent(lVar2,DAT_181d6bc40);
            if ((this.areaData == null) ||
               ((lVar2 = this.areaData.areaTreasurePriceData, lVar2 == null ||
                (lVar2 = FUN_180002f80(lVar2,iVar9,DAT_181d55758)) == null))) break;
            if (*(char *)(lVar2 + 20) == false) {
              puVar7 = (uint64 *)Color.get_green(local_28);
            }
            else {
              puVar7 = (uint64 *)Color.get_red(local_38);
            }
            if (plVar6 == (int64 *)0) break;
            local_48 = *puVar7;
            uStack_40 = puVar7[1];
            (**(code **)(*plVar6 + 0x2a8))(plVar6,&local_48,*(uint64 *)(*plVar6 + 0x2b0));
            lVar1 = GameObject.get_transform(lVar1,0);
            if (lVar1 == null) break;
            lVar1 = Transform.Find(lVar1,"Icon",0);
            if (((this.areaData == null) ||
                (lVar2 = this.areaData.areaTreasurePriceData) == null) ||
               (lVar2 = FUN_180002f80(lVar2,iVar9)) == null) break;
            iVar8 = -1;
            if (*(char *)(lVar2 + 20) == false) {
              iVar8 = 1;
            }
            if (lVar1 == null) break;
            local_58 = 0x3f800000;
            local_50 = 0x3f800000;
            local_54 = (float)iVar8;
            Transform.set_localScale(lVar1,&local_58);
            lVar1 = this.areaData;
            iVar9 = iVar9 + 1;
            if (lVar1 == null) break;
          }
        }
    }

    // Token : 0x6000A5D
    // RVA   : 0xA255C0   Offset: 0xA23DC0   Length: 0x11A
    public void RefreshAreaBuildingChoiceInfo()
    {
        int iVar1;
        long lVar2;
        int iVar3;
        lVar2 = this.buildingQuickButtonPanel;
        this.needRefreshAreaBuildingChoice = 0;
        iVar3 = 0;
        if (lVar2 != null) {
          while ((lVar2 = GameObject.get_transform(lVar2,0), lVar2 != null &&
                 (lVar2 = Transform.Find(lVar2,"BuildQuickButtonGrid",0)) != null)) {
            iVar1 = Transform.get_childCount(lVar2,0);
            if (iVar1 <= iVar3) {
              return;
            }
            if ((((this.buildingQuickButtonPanel == null) ||
                 (lVar2 = GameObject.get_transform(this.buildingQuickButtonPanel,0)) == null) ||
                (lVar2 = Transform.Find(lVar2,"BuildQuickButtonGrid",0)) == null) ||
               ((lVar2 = Transform.GetChild(lVar2,iVar3), lVar2 == null ||
                (lVar2 = Component.GetComponent(lVar2)) == null))) break;
            BuildQuickButtonController.RefreshBuildingChoiceInfo(lVar2);
            lVar2 = this.buildingQuickButtonPanel;
            iVar3 = iVar3 + 1;
            if (lVar2 == null) break;
          }
        }
    }

    // Token : 0x6000A5E
    // RVA   : 0xA23E90   Offset: 0xA22690   Length: 0x45
    public float GetAreaSpePriceRate()
    {
        float fVar1;
        if (this.areaData != null) {
          fVar1 = (float)AreaData.GetSafe(this.areaData,0);
          return (50.0 - fVar1) * 0.005 + 1.0;
        }
        return 1.0;
    }

    // Token : 0x6000A5F
    // RVA   : 0xA1AC70   Offset: 0xA19470   Length: 0x1A2
    public void AreaHeroListButtonClicked()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        long lVar1;
        long lVar2;
        ulong uVar3;
        if (this.areaData != null) {
          lVar2 = AreaData.GetInsideHeros(this.areaData,0);
          if ((*pStatics != 0) &&
             (lVar1 = *(int64 *)(*pStatics + 32)) != null) {
            uVar3 = WorldData.Player(lVar1,0);
            if (lVar2 != null) {
              FUN_181801c10(lVar2,uVar3,DAT_181d640f8);
              lVar1 = **(int64 **)(DAT_181d92370 + 184);
              uVar3 = Component.get_gameObject(this,0);
              if (lVar1 != null) {
                ChooseController.ShowChoosePanel(lVar1,2,lVar2,uVar3,"AreaHeroListChoosen",0,0,"UnfreezeAllAreaHero",0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x6000A60
    // RVA   : 0xA1AE20   Offset: 0xA19620   Length: 0x10E
    public void AreaHeroListChoosen()
    {
        var pStatics = *(int64*)(DAT_181d92370 + 184);
        long lVar1;
        long lVar2;
        lVar1 = **(int64 **)(DAT_181d6c960 + 184);
        if ((*pStatics != 0) &&
           (lVar2 = *(int64 *)(*pStatics + 72)) != null) {
          lVar2 = GameObject.GetComponent(lVar2,DAT_181d9fb20);
          if ((lVar2 != null) && (lVar1 != null)) {
            PlotController.ShowHeroInteractUI(lVar1,*(uint64 *)(lVar2 + 32),0);
            return;
          }
        }
    }

    // Token : 0x6000A61
    // RVA   : 0xA29830   Offset: 0xA28030   Length: 0x11D
    public void /*ctor*/()
    {
        ulong uVar1;
        uVar1 = il2cpp_internal(DAT_181d6e2b0);
        FUN_180f58a90(uVar1,DAT_181d61af8);
        this.decorations = uVar1;
        uVar1 = il2cpp_internal(DAT_181d6e2b0);
        FUN_180f58a90(uVar1,DAT_181d61af8);
        this.randomEvents = uVar1;
        uVar1 = il2cpp_internal(DAT_181d6e2b0);
        FUN_180f58a90(uVar1,DAT_181d61af8);
        this.littlePeoples = uVar1;
        uVar1 = il2cpp_internal(DAT_181d6e2b0);
        FUN_180f58a90(uVar1,DAT_181d61af8);
        *(uint64 *)(this + 200) = uVar1;
        this.checkPlotTime = 0x3f000000;
        this.checkHeroIconFreezeTime = 0x3f000000;
        FUN_18044ef50(this,0);
    }

    // Token : 0x6000A62
    // RVA   : 0xA28D00   Offset: 0xA27500   Length: 0xB22
    private static void /*cctor*/()
    {
        var pStatics = *(int64*)(DAT_181d87630 + 184);
        long lVar1;
        lVar1 = il2cpp_internal(DAT_181d72a30);
        FUN_180f58a90(lVar1,DAT_181d7c250);
        if (lVar1 != null) {
          FUN_181827900(lVar1,"Base",DAT_181d7c3d0);
          FUN_181827900(lVar1,"Under",DAT_181d7c3d0);
          FUN_181827900(lVar1,"Above",DAT_181d7c3d0);
          FUN_181827900(lVar1,"Cover",DAT_181d7c3d0);
          plVar2 = pStatics;
          *plVar2 = lVar1;
          il2cpp_internal(plVar2,lVar1);
          lVar1 = il2cpp_internal(DAT_181d6f030);
          FUN_180f58a90(lVar1,DAT_181d678f8);
          if (lVar1 != null) {
            FUN_181814fa0(lVar1,10,DAT_181d67a78);
            FUN_181814fa0(lVar1,17,DAT_181d67a78);
            FUN_181814fa0(lVar1,16,DAT_181d67a78);
            FUN_181814fa0(lVar1,11,DAT_181d67a78);
            FUN_181814fa0(lVar1,15,DAT_181d67a78);
            FUN_181814fa0(lVar1,13,DAT_181d67a78);
            FUN_181814fa0(lVar1,10,DAT_181d67a78);
            plVar2 = (int64 *)(pStatics + 8);
            *plVar2 = lVar1;
            il2cpp_internal(plVar2,lVar1);
            *(uint32 *)(pStatics + 16) = 0x3f19999a;
            *(uint32 *)(pStatics + 20) = 0x3fc00000;
            lVar1 = il2cpp_internal(DAT_181d72a30);
            FUN_180f58a90(lVar1,DAT_181d7c250);
            if (lVar1 != null) {
              FUN_181827900(lVar1,"路边摊_0",DAT_181d7c3d0);
              FUN_181827900(lVar1,"路边摊_1",DAT_181d7c3d0);
              FUN_181827900(lVar1,"路边摊_2",DAT_181d7c3d0);
              FUN_181827900(lVar1,"路边摊_3",DAT_181d7c3d0);
              FUN_181827900(lVar1,"路边摊_4",DAT_181d7c3d0);
              FUN_181827900(lVar1,"路边摊_5",DAT_181d7c3d0);
              FUN_181827900(lVar1,"路边摊_6",DAT_181d7c3d0);
              FUN_181827900(lVar1,"路边摊_7",DAT_181d7c3d0);
              FUN_181827900(lVar1,"路边摊_8",DAT_181d7c3d0);
              FUN_181827900(lVar1,"路边摊_9",DAT_181d7c3d0);
              FUN_181827900(lVar1,"民宅竖排_0",DAT_181d7c3d0);
              FUN_181827900(lVar1,"民宅竖排_1",DAT_181d7c3d0);
              FUN_181827900(lVar1,"民宅竖排_2",DAT_181d7c3d0);
              FUN_181827900(lVar1,"民宅竖排_3",DAT_181d7c3d0);
              FUN_181827900(lVar1,"民宅竖排_4",DAT_181d7c3d0);
              FUN_181827900(lVar1,"民宅竖排_5",DAT_181d7c3d0);
              plVar2 = (int64 *)(pStatics + 24);
              *plVar2 = lVar1;
              il2cpp_internal(plVar2,lVar1);
              lVar1 = il2cpp_internal(DAT_181d72a30);
              FUN_180f58a90(lVar1,DAT_181d7c250);
              if (lVar1 != null) {
                FUN_181827900(lVar1,"路边摊_0",DAT_181d7c3d0);
                FUN_181827900(lVar1,"路边摊_1",DAT_181d7c3d0);
                FUN_181827900(lVar1,"路边摊_2",DAT_181d7c3d0);
                FUN_181827900(lVar1,"路边摊_3",DAT_181d7c3d0);
                FUN_181827900(lVar1,"路边摊_4",DAT_181d7c3d0);
                FUN_181827900(lVar1,"路边摊_5",DAT_181d7c3d0);
                FUN_181827900(lVar1,"路边摊_6",DAT_181d7c3d0);
                FUN_181827900(lVar1,"路边摊_7",DAT_181d7c3d0);
                FUN_181827900(lVar1,"路边摊_8",DAT_181d7c3d0);
                FUN_181827900(lVar1,"路边摊_9",DAT_181d7c3d0);
                FUN_181827900(lVar1,"民宅横排上_0",DAT_181d7c3d0);
                FUN_181827900(lVar1,"民宅横排上_1",DAT_181d7c3d0);
                FUN_181827900(lVar1,"民宅横排上_2",DAT_181d7c3d0);
                FUN_181827900(lVar1,"民宅横排上_3",DAT_181d7c3d0);
                FUN_181827900(lVar1,"民宅横排上_4",DAT_181d7c3d0);
                FUN_181827900(lVar1,"民宅横排上_5",DAT_181d7c3d0);
                plVar2 = (int64 *)(pStatics + 32);
                *plVar2 = lVar1;
                il2cpp_internal(plVar2,lVar1);
                lVar1 = il2cpp_internal(DAT_181d72a30);
                FUN_180f58a90(lVar1,DAT_181d7c250);
                if (lVar1 != null) {
                  FUN_181827900(lVar1,"路边摊_0",DAT_181d7c3d0);
                  FUN_181827900(lVar1,"路边摊_1",DAT_181d7c3d0);
                  FUN_181827900(lVar1,"路边摊_2",DAT_181d7c3d0);
                  FUN_181827900(lVar1,"路边摊_3",DAT_181d7c3d0);
                  FUN_181827900(lVar1,"路边摊_4",DAT_181d7c3d0);
                  FUN_181827900(lVar1,"路边摊_5",DAT_181d7c3d0);
                  FUN_181827900(lVar1,"路边摊_6",DAT_181d7c3d0);
                  FUN_181827900(lVar1,"路边摊_7",DAT_181d7c3d0);
                  FUN_181827900(lVar1,"路边摊_8",DAT_181d7c3d0);
                  FUN_181827900(lVar1,"路边摊_9",DAT_181d7c3d0);
                  FUN_181827900(lVar1,"民宅横排下_0",DAT_181d7c3d0);
                  FUN_181827900(lVar1,"民宅横排下_1",DAT_181d7c3d0);
                  FUN_181827900(lVar1,"民宅横排下_2",DAT_181d7c3d0);
                  FUN_181827900(lVar1,"民宅横排下_3",DAT_181d7c3d0);
                  FUN_181827900(lVar1,"民宅横排下_4",DAT_181d7c3d0);
                  FUN_181827900(lVar1,"民宅横排下_5",DAT_181d7c3d0);
                  plVar2 = (int64 *)(pStatics + 40);
                  *plVar2 = lVar1;
                  il2cpp_internal(plVar2,lVar1);
                  lVar1 = il2cpp_internal(DAT_181d72a30);
                  FUN_180f58a90(lVar1,DAT_181d7c250);
                  if (lVar1 != null) {
                    FUN_181827900(lVar1,"路边摊_0",DAT_181d7c3d0);
                    FUN_181827900(lVar1,"路边摊_1",DAT_181d7c3d0);
                    FUN_181827900(lVar1,"路边摊_2",DAT_181d7c3d0);
                    FUN_181827900(lVar1,"路边摊_3",DAT_181d7c3d0);
                    FUN_181827900(lVar1,"路边摊_4",DAT_181d7c3d0);
                    FUN_181827900(lVar1,"路边摊_5",DAT_181d7c3d0);
                    FUN_181827900(lVar1,"路边摊_6",DAT_181d7c3d0);
                    FUN_181827900(lVar1,"路边摊_7",DAT_181d7c3d0);
                    FUN_181827900(lVar1,"路边摊_8",DAT_181d7c3d0);
                    FUN_181827900(lVar1,"路边摊_9",DAT_181d7c3d0);
                    FUN_181827900(lVar1,"民宅竖排_0",DAT_181d7c3d0);
                    FUN_181827900(lVar1,"民宅竖排_1",DAT_181d7c3d0);
                    FUN_181827900(lVar1,"民宅竖排_2",DAT_181d7c3d0);
                    FUN_181827900(lVar1,"民宅竖排_3",DAT_181d7c3d0);
                    FUN_181827900(lVar1,"民宅竖排_4",DAT_181d7c3d0);
                    FUN_181827900(lVar1,"民宅竖排_5",DAT_181d7c3d0);
                    FUN_181827900(lVar1,"民宅横排上_0",DAT_181d7c3d0);
                    FUN_181827900(lVar1,"民宅横排上_1",DAT_181d7c3d0);
                    FUN_181827900(lVar1,"民宅横排上_2",DAT_181d7c3d0);
                    FUN_181827900(lVar1,"民宅横排上_3",DAT_181d7c3d0);
                    FUN_181827900(lVar1,"民宅横排上_4",DAT_181d7c3d0);
                    FUN_181827900(lVar1,"民宅横排上_5",DAT_181d7c3d0);
                    FUN_181827900(lVar1,"民宅横排下_0",DAT_181d7c3d0);
                    FUN_181827900(lVar1,"民宅横排下_1",DAT_181d7c3d0);
                    FUN_181827900(lVar1,"民宅横排下_2",DAT_181d7c3d0);
                    FUN_181827900(lVar1,"民宅横排下_3",DAT_181d7c3d0);
                    FUN_181827900(lVar1,"民宅横排下_4",DAT_181d7c3d0);
                    FUN_181827900(lVar1,"民宅横排下_5",DAT_181d7c3d0);
                    plVar2 = (int64 *)(pStatics + 48);
                    *plVar2 = lVar1;
                    il2cpp_internal(plVar2,lVar1);
                    return;
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6000A63
    // RVA   : 0xA269C0   Offset: 0xA251C0   Length: 0x8
    private void <GenerateAreaMap>b__66_0()
    {
        void FUN_180a269c0(int64 this)
        {
        this.startAniming = 0;
    }

}
