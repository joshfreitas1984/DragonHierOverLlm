// ============================================================
// Type  : ExploreController
// Token : 0x2000273
// ============================================================

public class ExploreController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001330
    public List<ExploreMapTypeData> ExploreMapTypeDataBase;

    // Token: 0x4001331
    public List<ExploreTileGroundDataBase> ExploreTileGroundDataBase;

    // Token: 0x4001332
    public List<ExploreTileTypeData> ExploreTileTypeDataBase;

    // Token: 0x4001333
    public static List<string> ExploreObstacleName;

    // Token: 0x4001334
    public GameObject exploreObj;

    // Token: 0x4001335
    public GameObject exploreUnitPrefab;

    // Token: 0x4001336
    public GameObject exploreGrid;

    // Token: 0x4001337
    public GameObject exploreGridRoot;

    // Token: 0x4001338
    public GameObject exploreUIPanel;

    // Token: 0x4001339
    public string backgroundType;

    // Token: 0x400133A
    public GameObject playerIcon;

    // Token: 0x400133B
    public SkeletonAnimation playerSkeleton;

    // Token: 0x400133C
    public ExploreMapData exploreMapData;

    // Token: 0x400133D
    public ExplorePanelData explorePanelData;

    // Token: 0x400133E
    public GameObject[] gridUnits;

    // Token: 0x400133F
    private List<GameObject> gridPool;

    // Token: 0x4001340
    public GameObject playerGrid;

    // Token: 0x4001341
    public int leftPower;

    // Token: 0x4001342
    public GameObject finalGrid;

    // Token: 0x4001343
    public string successCallPlot;

    // Token: 0x4001344
    public string failCallPlot;

    // Token: 0x4001345
    public List<GameObject> checkDisableObj;

    // Token: 0x4001346
    public List<GameObject> checkEnableObj;

    // Token: 0x4001347
    public GameObject BackGround;

    // Token: 0x4001348
    public bool inited;

    // Token: 0x4001349
    private GameObject newObj;

    // Token: 0x400134A
    public Random seedRandomSpe;

    // Token: 0x400134B
    public int nowSeedSpe;

    // Token: 0x400134C
    public Random seedRandomBase;

    // Token: 0x400134D
    public int nowSeedBase;

    // Token: 0x400134E
    public Vector2 tweenFocusTarget;

    // Token: 0x400134F
    public float nowScale;

    // Token: 0x4001350
    public bool needRefreshExploreRate;

    // Token: 0x4001351
    public List<bool> exploreRateRewarded;

    // Token: 0x4001352
    private static ExploreController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60013D6
    // RVA   : 0x949710   Offset: 0x947F10   Length: 0x58
    public static ExploreController get_Instance()
    {
        return *(uint64 *)(*(int64 *)(DAT_181da0c98 + 184) + 8);
    }

    // Token : 0x60013D7
    // RVA   : 0x939100   Offset: 0x937900   Length: 0x11E
    private void Awake()
    {
        var pStatics = *(int64*)(DAT_181da0c98 + 184);
        bool cVar1;
        ulong uVar2;
        uVar2 = *(uint64 *)(pStatics + 8);
        cVar1 = Object.op_Equality(uVar2,0,0);
        if (!cVar1) {
          uVar2 = Component.get_gameObject(this,0);
          Object.Destroy(uVar2,0);
          return;
        }
        puVar3 = (uint64 *)(pStatics + 8);
        *puVar3 = this;
        il2cpp_internal(puVar3,this);
    }

    // Token : 0x60013D8
    // RVA   : 0x947380   Offset: 0x945B80   Length: 0x12
    private void Start()
    {
        void FUN_180947380(int64 this)
        {
        this.exploreMapData = 0;
    }

    // Token : 0x60013D9
    // RVA   : 0x9473A0   Offset: 0x945BA0   Length: 0x1AB9
    private void Update()
    {
        bool cVar1;
        uint uVar2;
        int iVar3;
        ulong uVar4;
        long lVar6;
        long lVar9;
        ulong uVar12;
        uint uVar13;
        ulong uVar14;
        long lVar15;
        ulong uVar16;
        ulong uVar17;
        long lVar18;
        byte[] auVar20 = new byte[16];
        byte[] auVar21 = new byte[16];
        float fVar22;
        float fVar23;
        float fVar24;
        float fVar25;
        uint[] local_res8 = new uint[4];
        ulong local_res18;
        uint[] local_res20 = new uint[2];
        ulong local_c8;
        float local_c0;
        ulong local_b8;
        float local_b0;
        byte[] local_a8 = new byte[8];
        float local_a0;
        ulong local_98;
        ulong uStack_90;
        uint64 extraout_XMM0_Qb;
        uVar16 = 0;
        local_98 = 0;
        uStack_90 = 0;
        local_res8[0] = 0;
        if (this.exploreMapData == null) {
          return;
        }
        if (this.explorePanelData == null) {
          return;
        }
        fVar23 = this.tweenFocusTarget;
        fVar24 = *(float *)(this + 0x100);
        uVar4 = Vector2.get_one(0);
        local_res18._0_4_ = (float)uVar4;
        local_res18._4_4_ = (float)((uint64)uVar4 >> 32);
        fVar23 = fVar23 - (float)local_res18 * -99.0;
        fVar24 = fVar24 - local_res18._4_4_ * -99.0;
        fVar25 = 0.0;
        local_res18 = uVar4;
        if (9.9999994e-11 <= fVar24 * fVar24 + fVar23 * fVar23) {
          this.nowScale = 0x3f800000;
          local_c8 = this.tweenFocusTarget ^ 0x8000000080000000;
          local_c0 = 0.0;
          puVar5 = (uint64 *)ExploreController.LimitMapPos(local_a8,this,&local_c8,0x3f800000,0);
          uVar14 = *puVar5;
          fVar23 = *(float *)(puVar5 + 1);
          if (this.exploreGridRoot == null) goto LAB_180948dc8;
          uVar4 = FUN_180fa1260(this.exploreGridRoot,0);
          local_c8 = uVar14;
          local_c0 = fVar23;
          lVar6 = SpringPosition.Begin(uVar4,&local_c8,0x41200000,0);
          if (lVar6 == null) goto LAB_180948dc8;
          *(uint8 *)(lVar6 + 41) = 1;
          uVar4 = Vector2.get_one(0);
          local_res18._0_4_ = (float)uVar4;
          local_res18._4_4_ = (float)((uint64)uVar4 >> 32);
          this.tweenFocusTarget = (float)local_res18 * -99.0;
          *(float *)(this + 0x100) = local_res18._4_4_ * -99.0;
          local_res18 = uVar4;
        }
        if ((this.exploreGrid == null) ||
           (lVar6 = GameObject.get_transform(this.exploreGrid,0)) == null)
        goto LAB_180948dc8;
        pfVar7 = (float *)Transform.get_localScale(local_a8,lVar6,0);
        lVar6 = this.exploreGrid;
        if (*pfVar7 <= this.nowScale && this.nowScale != *pfVar7) {
          if ((lVar6 == null) || (lVar6 = GameObject.get_transform(lVar6,0)) == null)
          goto LAB_180948dc8;
          puVar5 = (uint64 *)Transform.get_localScale(&local_98,lVar6,0);
          local_c0 = *(float *)(puVar5 + 1);
          uVar14 = *puVar5;
          puVar8 = (uint64 *)Vector3.get_one(&local_98,0);
          uVar4 = *puVar8;
          local_b0 = *(float *)(puVar8 + 1);
          fVar23 = (float)RealTime.get_deltaTime(0);
          fVar24 = (float)((uint64)uVar4 >> 32) * fVar23;
          fVar22 = (float)uVar4 * fVar23;
          local_b0 = local_b0 * fVar23 + local_b0 * fVar23 + local_c0;
          local_b8 = CONCAT44(fVar24 + fVar24 + (float)(uVar14 >> 32),fVar22 + fVar22 + (float)uVar14);
          local_c8 = uVar14;
          local_a0 = local_b0;
          Transform.set_localScale(lVar6,&local_b8,0);
          if ((this.exploreGrid == null) ||
             (lVar6 = GameObject.get_transform(this.exploreGrid,0)) == null)
          goto LAB_180948dc8;
          pfVar7 = (float *)Transform.get_localScale(&local_98,lVar6,0);
          if (this.nowScale <= *pfVar7) {
            if (this.exploreGrid == null) goto LAB_180948dc8;
            lVar6 = GameObject.get_transform(this.exploreGrid,0);
            fVar23 = this.nowScale;
            puVar5 = (uint64 *)Vector3.get_one(&local_98,0);
            local_b8 = *puVar5;
            local_b0 = *(float *)(puVar5 + 1);
        LAB_1809479d4:
            local_c0 = local_b0 * fVar23;
            local_c8 = CONCAT44((float)(local_b8 >> 32) * fVar23,(float)local_b8 * fVar23);
            if (lVar6 == null) goto LAB_180948dc8;
            local_b8 = local_c8;
            local_b0 = local_c0;
            Transform.set_localScale(lVar6,&local_b8,0);
          }
        LAB_180947a2e:
          if (this.exploreGridRoot == null) goto LAB_180948dc8;
          lVar6 = GameObject.get_transform(this.exploreGridRoot,0);
          if ((this.exploreGridRoot == null) ||
             (lVar9 = GameObject.get_transform(this.exploreGridRoot,0)) == null)
          goto LAB_180948dc8;
          puVar5 = (uint64 *)Transform.get_localPosition(&local_98,lVar9,0);
          fVar23 = *(float *)(puVar5 + 1);
          uVar14 = *puVar5;
          if ((this.exploreGrid == null) ||
             (lVar9 = GameObject.get_transform(this.exploreGrid,0)) == null)
          goto LAB_180948dc8;
          puVar10 = (uint32 *)Transform.get_localScale(&local_98,lVar9,0);
          local_b8 = uVar14;
          local_b0 = fVar23;
          puVar5 = (uint64 *)ExploreController.LimitMapPos(&local_98,this,&local_b8,*puVar10,0);
          if (lVar6 == null) goto LAB_180948dc8;
          local_b8 = *puVar5;
          local_b0 = *(float *)(puVar5 + 1);
          Transform.set_localPosition(lVar6,&local_b8,0);
        }
        else {
          if ((lVar6 == null) || (lVar6 = GameObject.get_transform(lVar6,0)) == null)
          goto LAB_180948dc8;
          pfVar7 = (float *)Transform.get_localScale(local_a8,lVar6,0);
          if (this.nowScale <= *pfVar7 && *pfVar7 != this.nowScale) {
            if ((this.exploreGrid == null) ||
               (lVar6 = GameObject.get_transform(this.exploreGrid,0)) == null)
            goto LAB_180948dc8;
            puVar8 = (uint64 *)Transform.get_localScale(local_a8,lVar6,0);
            local_b0 = *(float *)(puVar8 + 1);
            uVar4 = *puVar8;
            puVar5 = (uint64 *)Vector3.get_one(local_a8,0);
            uVar14 = *puVar5;
            local_c0 = *(float *)(puVar5 + 1);
            fVar23 = (float)RealTime.get_deltaTime(0);
            fVar22 = (float)(uVar14 >> 32) * fVar23;
            fVar24 = (float)uVar14 * fVar23;
            local_c0 = local_b0 - (local_c0 * fVar23 + local_c0 * fVar23);
            local_b8 = CONCAT44((float)((uint64)uVar4 >> 32) - (fVar22 + fVar22),
                                (float)uVar4 - (fVar24 + fVar24));
            local_c8 = uVar14;
            local_b0 = local_c0;
            Transform.set_localScale(lVar6,&local_b8,0);
            if ((this.exploreGrid == null) ||
               (lVar6 = GameObject.get_transform(this.exploreGrid,0)) == null)
            goto LAB_180948dc8;
            pfVar7 = (float *)Transform.get_localScale(local_a8,lVar6,0);
            if (*pfVar7 <= this.nowScale) {
              if (this.exploreGrid == null) goto LAB_180948dc8;
              lVar6 = GameObject.get_transform(this.exploreGrid,0);
              fVar23 = this.nowScale;
              puVar5 = (uint64 *)Vector3.get_one(&local_98,0);
              local_b8 = *puVar5;
              local_b0 = *(float *)(puVar5 + 1);
              goto LAB_1809479d4;
            }
            goto LAB_180947a2e;
          }
        }
        lVar6 = FUN_18046c0a0(0);
        if (lVar6 == null) goto LAB_180948dc8;
        cVar1 = GameController.HaveSpeUI(lVar6,1,0);
        if (!cVar1) {
          cVar1 = GlobalData.GetKeyDown(119);
          if (cVar1) {
            if ((((this.playerGrid == null) ||
                 (lVar6 = GameObject.GetComponent(this.playerGrid,DAT_181d9f5d0),
                 lVar6 == null)) || (lVar6.mapWidth == null)) ||
               (lVar9 = this.explorePanelData) == null) goto LAB_180948dc8;
            if (*(int *)(lVar6.mapWidth + 32) < lVar9._version + -1) {
              lVar6 = *(int64 *)(lVar9 + 40);
              if (((this.playerGrid == null) ||
                  (lVar9 = GameObject.GetComponent(this.playerGrid,DAT_181d9f5d0),
                  lVar9 == null)) || (lVar9.Count == null)) goto LAB_180948dc8;
              iVar3 = *(int *)(lVar9.Count + 36);
              if (((this.playerGrid == null) ||
                  (lVar9 = GameObject.GetComponent(this.playerGrid,DAT_181d9f5d0),
                  lVar9 == null)) || ((lVar9.Count == null || (lVar6 == null))))
              goto LAB_180948dc8;
              uVar4 = FUN_180127f50(lVar6,(int64)iVar3,
                                    (int64)(*(int *)(lVar9.Count + 32) + 1));
              ExploreController.ExploreTileClicked(this,uVar4,0);
            }
          }
          cVar1 = GlobalData.GetKeyDown(115);
          if (cVar1) {
            if (((this.playerGrid == null) ||
                (lVar6 = GameObject.GetComponent(this.playerGrid,DAT_181d9f5d0), lVar6 == null
                )) || (lVar6.mapWidth == null)) goto LAB_180948dc8;
            if (0 < *(int *)(lVar6.mapWidth + 32)) {
              if (this.explorePanelData == null) goto LAB_180948dc8;
              lVar6 = this.explorePanelData.exploreTileMap;
              if (((this.playerGrid == null) ||
                  (lVar9 = GameObject.GetComponent(this.playerGrid,DAT_181d9f5d0),
                  lVar9 == null)) || (lVar9.Count == null)) goto LAB_180948dc8;
              iVar3 = *(int *)(lVar9.Count + 36);
              if (((this.playerGrid == null) ||
                  (lVar9 = GameObject.GetComponent(this.playerGrid,DAT_181d9f5d0),
                  lVar9 == null)) || ((lVar9.Count == null || (lVar6 == null))))
              goto LAB_180948dc8;
              uVar4 = FUN_180127f50(lVar6,(int64)iVar3,
                                    (int64)(*(int *)(lVar9.Count + 32) + -1));
              ExploreController.ExploreTileClicked(this,uVar4,0);
            }
          }
          cVar1 = GlobalData.GetKeyDown(97);
          if (cVar1) {
            if (((this.playerGrid == null) ||
                (lVar6 = GameObject.GetComponent(this.playerGrid,DAT_181d9f5d0), lVar6 == null
                )) || (lVar6.mapWidth == null)) goto LAB_180948dc8;
            if (0 < *(int *)(lVar6.mapWidth + 36)) {
              if (this.explorePanelData == null) goto LAB_180948dc8;
              lVar6 = this.explorePanelData.exploreTileMap;
              if (((this.playerGrid == null) ||
                  (lVar9 = GameObject.GetComponent(this.playerGrid,DAT_181d9f5d0),
                  lVar9 == null)) || (lVar9.Count == null)) goto LAB_180948dc8;
              iVar3 = *(int *)(lVar9.Count + 36);
              if (((this.playerGrid == null) ||
                  (lVar9 = GameObject.GetComponent(this.playerGrid,DAT_181d9f5d0),
                  lVar9 == null)) || ((lVar9.Count == null || (lVar6 == null))))
              goto LAB_180948dc8;
              uVar4 = FUN_180127f50(lVar6,(int64)(iVar3 + -1),
                                    (int64)*(int *)(lVar9.Count + 32));
              ExploreController.ExploreTileClicked(this,uVar4,0);
            }
          }
          cVar1 = GlobalData.GetKeyDown(100);
          if (cVar1) {
            if ((((this.playerGrid == null) ||
                 (lVar6 = GameObject.GetComponent(this.playerGrid,DAT_181d9f5d0),
                 lVar6 == null)) || (lVar6.mapWidth == null)) ||
               (lVar9 = this.explorePanelData) == null) goto LAB_180948dc8;
            if (*(int *)(lVar6.mapWidth + 36) < lVar9.Count + -1) {
              lVar6 = *(int64 *)(lVar9 + 40);
              if (((this.playerGrid == null) ||
                  (lVar9 = GameObject.GetComponent(this.playerGrid,DAT_181d9f5d0),
                  lVar9 == null)) || (lVar9.Count == null)) goto LAB_180948dc8;
              iVar3 = *(int *)(lVar9.Count + 36);
              if (((this.playerGrid == null) ||
                  (lVar9 = GameObject.GetComponent(this.playerGrid,DAT_181d9f5d0),
                  lVar9 == null)) || ((lVar9.Count == null || (lVar6 == null))))
              goto LAB_180948dc8;
              uVar4 = FUN_180127f50(lVar6,(int64)(iVar3 + 1),
                                    (int64)*(int *)(lVar9.Count + 32));
              ExploreController.ExploreTileClicked(this,uVar4,0);
            }
          }
        }
        lVar6 = this.exploreUIPanel;
        if (this.leftPower == 999) {
          if ((lVar6 == null) || (lVar6 = GameObject.get_transform(lVar6,0)) == null)
          goto LAB_180948dc8;
          lVar6 = Transform.Find(lVar6,"LeftStep",0);
          puVar5 = (uint64 *)Vector3.get_zero(&local_98,0);
          if (lVar6 == null) goto LAB_180948dc8;
          local_b0 = *(float *)(puVar5 + 1);
          local_b8 = *puVar5;
          Transform.set_localScale(lVar6,&local_b8,0);
        }
        else {
          if ((lVar6 == null) || (lVar6 = GameObject.get_transform(lVar6,0)) == null)
          goto LAB_180948dc8;
          lVar6 = Transform.Find(lVar6,"LeftStep",0);
          puVar5 = (uint64 *)Vector3.get_one(&local_98,0);
          if (lVar6 == null) goto LAB_180948dc8;
          local_b0 = *(float *)(puVar5 + 1);
          local_b8 = *puVar5;
          Transform.set_localScale(lVar6,&local_b8,0);
          if ((((this.exploreUIPanel == null) ||
               (lVar6 = GameObject.get_transform(this.exploreUIPanel,0)) == null) ||
              (lVar6 = Transform.Find(lVar6,"LeftStep",0)) == null) ||
             (lVar6 = Transform.Find(lVar6,"Text",0)) == null) goto LAB_180948dc8;
          uVar12 = Component.GetComponent(lVar6,DAT_181d6d8c0);
          plVar11 = (int64 *)FUN_1800d60b0(DAT_181d7f180,4);
          uVar4 = "{0}耐力 {1}/{2}{3}";
          lVar6 = "";
          if (this.leftPower < 1) {
            lVar6 = *(int64 *)(*(int64 *)(DAT_181d4ef00 + 184) + 0x2c8);
          }
          if (plVar11 == (int64 *)0) {
        LAB_180948e54:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          if ((lVar6 != null) &&
             (lVar9 = il2cpp_internal(lVar6,*(uint64 *)(*plVar11 + 64))) == null) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar4,0);
          }
          if ((int)plVar11[3] == 0) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar4,0);
          }
          plVar11[4] = lVar6;
          il2cpp_internal(plVar11 + 4,lVar6);
          local_res18 = CONCAT44(local_res18._4_4_,this.leftPower);
          lVar6 = il2cpp_value_box(DAT_181d5b2f8,&local_res18);
          if ((lVar6 != null) &&
             (lVar9 = il2cpp_internal(lVar6,*(uint64 *)(*plVar11 + 64))) == null) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar4,0);
          }
          if (*(uint32 *)(plVar11 + 3) < 2) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar4,0);
          }
          plVar11[5] = lVar6;
          il2cpp_internal(plVar11 + 5,lVar6);
          if (this.explorePanelData == null) goto LAB_180948e54;
          local_res20[0] = this.explorePanelData.maxPower;
          lVar6 = il2cpp_value_box(DAT_181d5b2f8,local_res20);
          if ((lVar6 != null) &&
             (lVar9 = il2cpp_internal(lVar6,*(uint64 *)(*plVar11 + 64))) == null) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar4,0);
          }
          if (*(uint32 *)(plVar11 + 3) < 3) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar4,0);
          }
          plVar11[6] = lVar6;
          il2cpp_internal(plVar11 + 6,lVar6);
          lVar6 = "";
          if (this.leftPower < 1) {
            lVar6 = "</color>";
          }
          if ((lVar6 != null) &&
             (lVar9 = il2cpp_internal(lVar6,*(uint64 *)(*plVar11 + 64))) == null) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar4,0);
          }
          if (*(uint32 *)(plVar11 + 3) < 4) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar4,0);
          }
          plVar11[7] = lVar6;
          il2cpp_internal(plVar11 + 7,lVar6);
          uVar4 = String.Format(uVar4,plVar11,0);
          LTLocalization.SetText(uVar12,uVar4,0);
          if ((((this.exploreUIPanel == null) ||
               (lVar6 = GameObject.get_transform(this.exploreUIPanel,0)) == null) ||
              (lVar6 = Transform.Find(lVar6,"LeftStep",0)) == null) ||
             ((lVar6 = Transform.Find(lVar6,"BarBack",0), lVar6 == null ||
              (lVar6 = Transform.Find(lVar6,"Bar",0)) == null))) goto LAB_180948dc8;
          lVar6 = Component.GetComponent(lVar6,DAT_181d6bc40);
          if ((this.explorePanelData == null) || (lVar6 == null)) goto LAB_180948dc8;
          Image.set_fillAmount
                    (lVar6,(float)this.leftPower /
                           (float)this.explorePanelData.maxPower,0);
        }
        if ((((this.exploreUIPanel != null) &&
             (lVar6 = GameObject.get_transform(this.exploreUIPanel,0)) != null) &&
            (lVar6 = Transform.Find(lVar6,"ExploreRate",0)) != null) &&
           (lVar6 = Component.get_gameObject(lVar6,0)) != null) {
          cVar1 = GameObject.get_activeSelf(lVar6,0);
          lVar6 = this.explorePanelData;
          if (lVar6 != null) {
            if ((bool)cVar1 == (lVar6.exploreType == null)) {
        LAB_180948400:
              if ((lVar6.exploreType != null) || (!this.needRefreshExploreRate)) {
                return;
              }
              bVar19 = !DAT_181e78070;
              this.needRefreshExploreRate = 0;
              if (bVar19) {
                il2cpp_runtime_class_init(&DAT_181d5fa78);
                il2cpp_runtime_class_init(&DAT_181d5faf8);
                lVar6 = this.explorePanelData;
                DAT_181e78070 = true;
              }
              fVar23 = 0.0;
              if (lVar6 != null) {
                lVar18 = 32;
                lVar9 = 32;
                uVar14 = uVar16;
                while (lVar6.exploreTiles != null) {
                  uVar13 = (uint32)uVar14;
                  if (*(int *)(lVar6.exploreTiles + 24) <= (int)uVar13) {
                    if (!DAT_181e78071) {
                      il2cpp_runtime_class_init(&DAT_181d5fa78);
                      il2cpp_runtime_class_init(&DAT_181d5faf8);
                      lVar6 = this.explorePanelData;
                      DAT_181e78071 = true;
                    }
                    uVar14 = uVar16;
                    if (lVar6 != null) goto LAB_180948560;
                    break;
                  }
                  if ((lVar6 = lVar6?.exploreTiles) == null) break;
                  if (lVar6.mapWidth <= uVar13) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  lVar6 = *(int64 *)(lVar9 + lVar6.exploreType);
                  if (lVar6 == null) break;
                  if (lVar6.startDistance) {
                    if (((this.explorePanelData == null) ||
                        (lVar6 = this.explorePanelData.exploreTiles) == null) ||
                       (lVar6 = FUN_180002f80(lVar6,uVar14,DAT_181d5faf8)) == null) break;
                    if (lVar6.finishParam != null) {
                      fVar23 = fVar23 + 1.0;
                    }
                  }
                  lVar6 = this.explorePanelData;
                  lVar9 = lVar9 + 8;
                  uVar14 = (uint64)(uVar13 + 1);
                  if (lVar6 == null) break;
                }
              }
        LAB_180948e4e:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            if (((this.exploreUIPanel != null) &&
                (lVar6 = GameObject.get_transform(this.exploreUIPanel,0)) != null) &&
               (lVar6 = Transform.Find(lVar6,"ExploreRate",0)) != null) {
              lVar6 = Component.get_gameObject(lVar6,0);
              if ((this.explorePanelData != null) && (lVar6 != null)) {
                GameObject.SetActive(lVar6,this.explorePanelData.exploreType == null,0);
                lVar6 = this.explorePanelData;
                if (lVar6 != null) goto LAB_180948400;
              }
            }
          }
        }
        LAB_180948dc8:
                          // WARNING: Subroutine does not return
        FUN_1800d6620();
        LAB_180948560:
        if (lVar6.exploreTiles == null) goto LAB_180948e4e;
        uVar13 = (uint32)uVar14;
        if (*(int *)(lVar6.exploreTiles + 24) <= (int)uVar13) {
          if ((((this.exploreUIPanel != null) &&
               (lVar6 = GameObject.get_transform(this.exploreUIPanel,0)) != null) &&
              (lVar6 = Transform.Find(lVar6,"ExploreRate",0)) != null) &&
             (lVar6 = Transform.Find(lVar6,"Text",0)) != null) {
            uVar4 = Component.GetComponent(lVar6,DAT_181d6d8c0);
            uVar2 = Mathf.FloorToInt((fVar23 / fVar25) * 100.0,0);
            local_res18 = CONCAT44(local_res18._4_4_,uVar2);
            uVar12 = il2cpp_value_box(DAT_181d5b2f8,&local_res18);
            uVar12 = String.Format("探索度 {0}%",uVar12,0);
            LTLocalization.SetText(uVar4,uVar12,0);
            if ((((this.exploreUIPanel != null) &&
                 (lVar6 = GameObject.get_transform(this.exploreUIPanel,0)) != null) &&
                ((lVar6 = Transform.Find(lVar6,"ExploreRate",0), lVar6 != null &&
                 ((lVar6 = Transform.Find(lVar6,"BarBack",0), lVar6 != null &&
                  (lVar6 = Transform.Find(lVar6,"Bar",0)) != null))))) &&
               (lVar6 = Component.GetComponent(lVar6,DAT_181d6bc40)) != null) {
              Image.set_fillAmount(lVar6);
              iVar3 = Mathf.FloorToInt();
              uVar14 = uVar16;
              uVar17 = uVar16;
              if (iVar3 + -1 < 0) goto LAB_1809488d0;
              goto LAB_180948750;
            }
          }
          goto LAB_180948e4e;
        }
        if ((lVar6 = lVar6?.exploreTiles) == null) goto LAB_180948e4e;
        if (lVar6.mapWidth <= uVar13) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        lVar6 = *(int64 *)(lVar18 + lVar6.exploreType);
        if (lVar6 == null) goto LAB_180948e4e;
        if (lVar6.finishParam != null) {
          fVar25 = fVar25 + 1.0;
        }
        lVar6 = this.explorePanelData;
        lVar18 = lVar18 + 8;
        uVar14 = (uint64)(uVar13 + 1);
        if (lVar6 == null) goto LAB_180948e4e;
        goto LAB_180948560;
        LAB_180948750:
        do {
          lVar6 = this.exploreRateRewarded;
          if (lVar6 == null) goto LAB_180948dc8;
          uVar13 = (uint32)uVar14;
          if (lVar6.mapWidth <= uVar13) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          if (*(char *)(lVar6.exploreType + 32 + uVar17) == false) {
            if (this.exploreRateRewarded == null) goto LAB_180948dc8;
            FUN_181814bb0(this.exploreRateRewarded,uVar14,1,DAT_181d58f90);
            if (uVar13 == 0) {
              lVar6 = FUN_18046c300(0);
              if (lVar6 == null) goto LAB_180948dc8;
              local_98 = 0;
              uStack_90 = 0;
              InfoController.AddInfoTab
                        (lVar6,"20%探索奖励：揭示所有塔楼","TileAtlas","探索_地图","Success",0x3f800000,
                         0x40a00000,&local_98,0);
              uVar14 = uVar16;
              while( true ) {
                if ((this.explorePanelData == null) ||
                   (lVar6 = this.explorePanelData.exploreTiles) == null)
                goto LAB_180948dc8;
                if (lVar6.mapWidth <= (int)uVar14) break;
                lVar6 = FUN_180002f80(lVar6,uVar14,DAT_181d5faf8);
                if (lVar6 == null) goto LAB_180948dc8;
                if (lVar6.startTile == 3) {
                  if (((this.gridPool == null) ||
                      (lVar6 = FUN_180002f80(this.gridPool,uVar14,DAT_181d62178),
                      lVar6 == null)) || (lVar6 = GameObject.GetComponent(lVar6,DAT_181d9f5d0)) == null)
                  goto LAB_180948dc8;
                  ExploreTileUnitController.set_Seen(lVar6,1,0);
                }
                uVar14 = (uint64)((int)uVar14 + 1);
              }
            }
            else if (uVar13 == 1) {
              lVar6 = FUN_18046c300(0);
              if (lVar6 == null) goto LAB_180948dc8;
              local_98 = 0;
              uStack_90 = 0;
              InfoController.AddInfoTab
                        (lVar6,"40%探索奖励：揭示所有地图和营地","TileAtlas","探索_地图","Success",0x3f800000,
                         0x40a00000,&local_98,0);
              uVar14 = uVar16;
              while( true ) {
                if ((this.explorePanelData == null) ||
                   (lVar6 = this.explorePanelData.exploreTiles) == null)
                goto LAB_180948dc8;
                if (lVar6.mapWidth <= (int)uVar14) break;
                lVar6 = FUN_180002f80(lVar6,uVar14,DAT_181d5faf8);
                if (lVar6 == null) goto LAB_180948dc8;
                if (lVar6.startTile == 1) {
        LAB_180948c97:
                  if (((this.gridPool == null) ||
                      (lVar6 = FUN_180002f80(this.gridPool,uVar14,DAT_181d62178),
                      lVar6 == null)) || (lVar6 = GameObject.GetComponent(lVar6,DAT_181d9f5d0)) == null)
                  goto LAB_180948dc8;
                  ExploreTileUnitController.set_Seen(lVar6,1,0);
                }
                else {
                  if (((this.explorePanelData == null) ||
                      (lVar6 = this.explorePanelData.exploreTiles) == null) ||
                     (lVar6 = FUN_180002f80(lVar6,uVar14,DAT_181d5faf8)) == null) goto LAB_180948dc8;
                  if (lVar6.startTile == 2) goto LAB_180948c97;
                }
                uVar14 = (uint64)((int)uVar14 + 1);
              }
            }
            else if (uVar13 == 2) {
              lVar6 = FUN_18046c300(0);
              if (lVar6 == null) goto LAB_180948dc8;
              local_98 = 0;
              uStack_90 = 0;
              InfoController.AddInfoTab
                        (lVar6,"60%探索奖励：恢复15%已消耗耐力","TileAtlas","探索_地图","Success",0x3f800000,
                         0x40a00000,&local_98,0);
              if (this.explorePanelData == null) goto LAB_180948dc8;
              uVar2 = Mathf.CeilToInt((float)(this.explorePanelData.maxPower -
                                              this.leftPower) * 0.15,0);
              ExploreController.ChangeMoveStep(this,uVar2,1,0);
            }
            else if (uVar13 == 3) {
              lVar6 = FUN_18046c300(0);
              if (lVar6 == null) goto LAB_180948dc8;
              local_98 = 0;
              uStack_90 = 0;
              InfoController.AddInfoTab
                        (lVar6,"80%探索奖励：恢复10%已消耗耐力并揭示终点","TileAtlas","探索_地图","Success",0x3f800000,
                         0x40a00000,&local_98,0);
              if (this.explorePanelData == null) goto LAB_180948dc8;
              uVar2 = Mathf.CeilToInt((float)(this.explorePanelData.maxPower -
                                              this.leftPower) * 0.1,0);
              ExploreController.ChangeMoveStep(this,uVar2,1,0);
              if ((this.finalGrid == null) ||
                 (lVar6 = GameObject.GetComponent(this.finalGrid,DAT_181d9f5d0),
                 lVar6 == null)) goto LAB_180948dc8;
              ExploreTileUnitController.set_Seen(lVar6,1,0);
            }
            else if (uVar13 == 4) {
              lVar6 = FUN_18046c300(0);
              if (lVar6 == null) goto LAB_180948dc8;
              local_98 = 0;
              uStack_90 = 0;
              InfoController.AddInfoTab
                        (lVar6,"100%探索奖励：额外获得声望","TileAtlas","探索_地图","Success",0x3f800000,
                         0x40a00000,&local_98,0);
              lVar6 = FUN_18046c0a0(0);
              if (((lVar6 == null) || (lVar6.exploreTiles == null)) ||
                 (lVar6 = WorldData.Player(lVar6.exploreTiles,0),
                 this.exploreMapData == null)) goto LAB_180948dc8;
              auVar20._0_8_ = Mathf.Max();
              auVar20._8_8_ = extraout_XMM0_Qb;
              auVar21._4_12_ = auVar20._4_12_;
              auVar21._0_4_ = (float)auVar20._0_8_ * 5.0;
              Mathf.RoundToInt(auVar21._0_8_,0);
              if (lVar6 == null) goto LAB_180948dc8;
              HeroData.ChangeFame();
            }
          }
          iVar3 = Mathf.FloorToInt();
          uVar14 = (uint64)(uVar13 + 1);
          uVar17 = uVar17 + 1;
        } while ((int)(uVar13 + 1) <= iVar3 + -1);
        LAB_1809488d0:
        do {
          if ((this.exploreUIPanel == null) ||
             (lVar6 = GameObject.get_transform(this.exploreUIPanel,0)) == null)
          goto LAB_180948dc8;
          lVar6 = Transform.Find(lVar6,"ExploreRate",0);
          uVar4 = Int32.ToString(local_res8,0);
          uVar4 = String.Concat("Star",uVar4,0);
          if ((lVar6 == null) || (lVar6 = Transform.Find(lVar6,uVar4,0)) == null) goto LAB_180948dc8;
          lVar6 = Component.GetComponent(lVar6,DAT_181d6bc40);
          lVar9 = this.exploreRateRewarded;
          lVar15 = (int64)(int)local_res8[0];
          lVar18 = **(int64 **)(DAT_181d86270 + 184);
          if (lVar9 == null) goto LAB_180948dc8;
          if (lVar9.Count <= local_res8[0]) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          uVar4 = "收藏-已收藏";
          if (*(char *)(lVar9._items + 32 + lVar15) == false) {
            uVar4 = "收藏-未收藏";
          }
          if ((lVar18 == null) ||
             (TextureController.LoadAtlasSprite(lVar18,"UIAtlas",uVar4,0), lVar6 == null))
          goto LAB_180948dc8;
          Image.set_sprite(lVar6);
          local_res8[0] = local_res8[0] + 1;
          if (4 < (int)local_res8[0]) {
            return;
          }
        } while( true );
    }

    // Token : 0x60013DA
    // RVA   : 0x93F880   Offset: 0x93E080   Length: 0x126
    public float GetSeenTileNum()
    {
        long lVar1;
        long lVar2;
        uint uVar3;
        float fVar4;
        lVar1 = this.explorePanelData;
        uVar3 = 0;
        fVar4 = 0.0;
        if (lVar1 != null) {
          lVar2 = 32;
          while (lVar1.exploreTiles != null) {
            if (*(int *)(lVar1.exploreTiles + 24) <= (int)uVar3) {
              return fVar4;
            }
            if ((lVar1 = lVar1?.exploreTiles) == null) break;
            if (lVar1.mapWidth <= uVar3) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar1 = *(int64 *)(lVar2 + lVar1.exploreType);
            if (lVar1 == null) break;
            if (lVar1.startDistance) {
              if (((this.explorePanelData == null) ||
                  (lVar1 = this.explorePanelData.exploreTiles) == null) ||
                 (lVar1 = FUN_180002f80(lVar1,uVar3,DAT_181d5faf8)) == null) break;
              if (lVar1.finishParam != null) {
                fVar4 = fVar4 + 1.0;
              }
            }
            lVar1 = this.explorePanelData;
            uVar3 = uVar3 + 1;
            lVar2 = lVar2 + 8;
            if (lVar1 == null) break;
          }
        }
    }

    // Token : 0x60013DB
    // RVA   : 0x93F9B0   Offset: 0x93E1B0   Length: 0xEC
    public float GetTotalNoRoadTileNum()
    {
        long lVar1;
        long lVar2;
        uint uVar3;
        float fVar4;
        lVar1 = this.explorePanelData;
        uVar3 = 0;
        fVar4 = 0.0;
        if (lVar1 != null) {
          lVar2 = 32;
          while (lVar1.exploreTiles != null) {
            if (*(int *)(lVar1.exploreTiles + 24) <= (int)uVar3) {
              return fVar4;
            }
            if ((lVar1 = lVar1?.exploreTiles) == null) break;
            if (lVar1.mapWidth <= uVar3) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar1 = *(int64 *)(lVar2 + lVar1.exploreType);
            if (lVar1 == null) break;
            if (lVar1.finishParam != null) {
              fVar4 = fVar4 + 1.0;
            }
            lVar1 = this.explorePanelData;
            uVar3 = uVar3 + 1;
            lVar2 = lVar2 + 8;
            if (lVar1 == null) break;
          }
        }
    }

    // Token : 0x60013DC
    // RVA   : 0x946F00   Offset: 0x945700   Length: 0x88
    public void ResetExploreRateReward()
    {
        long lVar1;
        int iVar2;
        iVar2 = 0;
        lVar1 = this.exploreRateRewarded;
        while (lVar1 != null) {
          if (lVar1.Count <= iVar2) {
            return;
          }
          if (lVar1 == null) break;
          FUN_181814bb0(lVar1,iVar2,0,DAT_181d58f90);
          iVar2 = iVar2 + 1;
          lVar1 = this.exploreRateRewarded;
        }
    }

    // Token : 0x60013DD
    // RVA   : 0x940010   Offset: 0x93E810   Length: 0x449
    public Vector3 LimitMapPos(Vector3 originPos, float scale)
    {
        var plVar7 = *(int64*)(lVar7 + 184);
        float * ExploreController.LimitMapPos
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
        lVar6 = *(int64 *)(originPos + 120);
        this[0] = 0.0;
        this[1] = 0.0;
        this[2] = 0.0;
        lVar7 = DAT_181d4ef00;
        if (lVar6 != null) {
          iVar4 = *(int *)(lVar6 + 24);
          iVar5 = *(int *)(lVar6 + 28);
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

    // Token : 0x60013DE
    // RVA   : 0x93FC80   Offset: 0x93E480   Length: 0x37F
    private void InitExploreGround()
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
        float local_78;
        float local_74;
        float local_70;
        ulong local_68;
        uint local_60;
        long local_58;
        long local_50;
        local_50 = (int64)*(int *)(pStatics + 0x214);
        local_58 = (int64)*(int *)(pStatics + 0x210);
        lVar2 = FUN_1800d6020(DAT_181d848c0,&local_58);
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
          if (*(int *)(plVar2 + 0x214) <= iVar9) {
            return;
          }
          iVar8 = 0;
          while( true ) {
            if (((*(byte *)(lVar2 + 0x133) & 4) != 0) && (*(int *)(lVar2 + 224) == 0)) {
              il2cpp_runtime_class_init();
              lVar2 = DAT_181d4ef00;
            }
            if (*(int *)(plVar2 + 0x210) <= iVar8) break;
            lVar4 = *plVar1;
            uVar3 = this.exploreGridRoot;
            uVar6 = this.exploreUnitPrefab;
            if (((*(byte *)(lVar2 + 0x133) & 4) != 0) && (*(int *)(lVar2 + 224) == 0)) {
              il2cpp_runtime_class_init();
            }
            uVar3 = GlobalData.AddChild(uVar3,uVar6,0);
            if (lVar4 == null) {
        LAB_18093fffa:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar7 = (int64)iVar9;
            lVar2 = (int64)iVar8;
            FUN_180127fe0(lVar4,lVar2,lVar7,uVar3);
            if (*plVar1 == 0) goto LAB_18093fffa;
            lVar4 = FUN_180127f50(*plVar1,lVar2,lVar7);
            if (lVar4 == null) goto LAB_18093fffa;
            lVar4 = GameObject.get_transform(lVar4,0);
            puVar5 = (uint64 *)Vector3.get_one(&local_58,0);
            if (lVar4 == null) goto LAB_18093fffa;
            local_60 = *(uint32 *)(puVar5 + 1);
            local_68 = *puVar5;
            Transform.set_localScale(lVar4,&local_68,0);
            if (*plVar1 == 0) goto LAB_18093fffa;
            lVar4 = FUN_180127f50(*plVar1,lVar2,lVar7);
            if (lVar4 == null) goto LAB_18093fffa;
            lVar4 = GameObject.get_transform(lVar4,0);
            if (lVar4 == null) goto LAB_18093fffa;
            local_78 = (float)iVar8;
            local_74 = (float)iVar9;
            local_70 = (float)iVar9 * 0.01;
            Transform.set_localPosition(lVar4,&local_78,0);
            if (*plVar1 == 0) goto LAB_18093fffa;
            lVar4 = FUN_180127f50(*plVar1,lVar2,lVar7);
            local_res8[0] = iVar9;
            uVar3 = il2cpp_value_box(DAT_181d5b2f8,local_res8);
            local_res18[0] = iVar8;
            uVar6 = il2cpp_value_box(DAT_181d5b2f8,local_res18);
            uVar3 = String.Format("{0}_{1}",uVar3,uVar6,0);
            if (lVar4 == null) goto LAB_18093fffa;
            Object.set_name(lVar4,uVar3,0);
            if (*plVar1 == 0) goto LAB_18093fffa;
            lVar2 = FUN_180127f50(*plVar1,lVar2);
            if (lVar2 == null) goto LAB_18093fffa;
            GameObject.SetActive(lVar2,0);
            iVar8 = iVar8 + 1;
            lVar2 = DAT_181d4ef00;
          }
          iVar9 = iVar9 + 1;
        } while( true );
    }

    // Token : 0x60013DF
    // RVA   : 0x947290   Offset: 0x945A90   Length: 0xE4
    public void ShowExploreAnimFinished()
    {
        var pStatics = *(int64*)(DAT_181d88ad8 + 184);
        long lVar1;
        ulong uVar3;
        byte[] local_18 = new byte[16];
        if ((this.exploreObj != null) &&
           (lVar1 = GameObject.get_transform(this.exploreObj,0)) != null) {
          pfVar2 = (float *)Transform.get_localScale(local_18,lVar1,0);
          if (*pfVar2 == 0.0) {
            if (this.exploreObj != null) {
              GameObject.SetActive(this.exploreObj,0,0);
              return;
            }
          }
          else {
            if (this.explorePanelData != null) {
              uVar3 = "迷宫探索";
              if (this.explorePanelData.exploreType == null) {
                uVar3 = "野外探索";
              }
              if (*pStatics != 0) {
                TutorialController.StartTutorial(*pStatics,uVar3,0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x60013E0
    // RVA   : 0x940000   Offset: 0x93E800   Length: 0x9
    public bool IsExploring()
    {
        return this.exploreMapData != null;
    }

    // Token : 0x60013E1
    // RVA   : 0x93FAA0   Offset: 0x93E2A0   Length: 0x1DB
    public void HideExploreMap()
    {
        var pStatics = *(int64*)(DAT_181d92bf0 + 184);
        long lVar1;
        long lVar2;
        uint uVar3;
        if (*pStatics != 0) {
          CloudAnimController.PlayerCloudAnim(*pStatics,0);
          if ((this.exploreObj != null) &&
             (lVar1 = GameObject.GetComponent(this.exploreObj,DAT_181da2330)) != null)
          {
            UITweener.PlayReverse(lVar1,0);
            uVar3 = 0;
            this.exploreMapData = 0;
            this.explorePanelData = 0;
            lVar1 = this.checkEnableObj;
            if (lVar1 != null) {
              lVar2 = 32;
              do {
                if (lVar1.Count <= (int)uVar3) {
                  FUN_180f56130(lVar1,DAT_181d61c78);
                  if (this.exploreUIPanel != null) {
                    GameObject.SetActive(this.exploreUIPanel,0,0);
                    ExploreController.ResetExploreMap(this,0);
                    return;
                  }
                  break;
                }
                if (lVar1 == null) break;
                if (lVar1.Count <= uVar3) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar1 = *(int64 *)(lVar2 + lVar1._items);
                if (lVar1 == null) break;
                GameObject.SetActive(lVar1,1,0);
                lVar1 = this.checkEnableObj;
                uVar3 = uVar3 + 1;
                lVar2 = lVar2 + 8;
              } while (lVar1 != null);
            }
          }
        }
    }

    // Token : 0x60013E2
    // RVA   : 0x946D20   Offset: 0x945520   Length: 0x1D5
    public void ResetExploreMap()
    {
        ulong uVar1;
        bool cVar2;
        long lVar3;
        long lVar4;
        uint uVar5;
        lVar3 = this.gridPool;
        uVar5 = 0;
        if (lVar3 != null) {
          lVar4 = 32;
          while( true ) {
            if (lVar3.Count <= (int)uVar5) {
              FUN_180f56130(lVar3,DAT_181d61c78);
              return;
            }
            if (lVar3 == null) break;
            if (lVar3.Count <= uVar5) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar3 = *(int64 *)(lVar4 + lVar3._items);
            if (lVar3 == null) break;
            GameObject.SetActive(lVar3,0,0);
            lVar3 = this.gridPool;
            if (lVar3 == null) break;
            if (lVar3.Count <= uVar5) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            if ((*(int64 *)(lVar4 + lVar3._items) == 0) ||
               (lVar3 = GameObject.GetComponent()) == null) break;
            uVar1 = *(uint64 *)(lVar3 + 32);
            cVar2 = Object.op_Inequality(uVar1);
            if (cVar2) {
              if (((this.gridPool == null) ||
                  (lVar3 = FUN_180002f80(this.gridPool,uVar5)) == null) ||
                 (lVar3 = GameObject.GetComponent(lVar3)) == null) break;
              uVar1 = *(uint64 *)(lVar3 + 32);
              Object.Destroy(uVar1);
            }
            lVar3 = this.gridPool;
            uVar5 = uVar5 + 1;
            lVar4 = lVar4 + 8;
            if (lVar3 == null) break;
          }
        }
    }

    // Token : 0x60013E3
    // RVA   : 0x947070   Offset: 0x945870   Length: 0x21B
    public void SetExploreBackground()
    {
        ulong uVar1;
        ulong uVar2;
        uint uVar3;
        long lVar4;
        long lVar5;
        float fVar6;
        uint uVar7;
        float local_28;
        float local_24;
        uint local_20;
        uVar1 = *(uint64 *)(this + 200);
        uVar2 = this.backgroundType;
        lVar5 = *(int64 *)(*(int64 *)(DAT_181d87630 + 184) + 56);
        uVar3 = FUN_180d8cf10(0,4);
        fVar6 = (float)Random.get_value(0);
        if (0.5 <= fVar6) {
          uVar7 = 0xbf800000;
        }
        else {
          uVar7 = 0x3f800000;
        }
        if (lVar5 != null) {
          AreaController.SetBackGroundSkeleton(lVar5,uVar1,uVar2,uVar3,uVar7,0);
          if (*(int64 *)(this + 200) != 0) {
            lVar4 = GameObject.get_transform(*(int64 *)(this + 200),0);
            lVar5 = this.explorePanelData;
            if (lVar5 != null) {
              if (lVar4 != null) {
                local_20 = 0;
                local_28 = (float)(lVar5.mapWidth + -1) * 0.5;
                local_24 = (float)(lVar5.mapHeight + -1) * 0.5;
                Transform.set_localPosition(lVar4,&local_28,0);
                if (*(int64 *)(this + 200) != 0) {
                  lVar5 = GameObject.get_transform(*(int64 *)(this + 200),0);
                  if (lVar5 != null) {
                    lVar5 = Transform.Find(lVar5,"BlackBack",0);
                    if (lVar5 != null) {
                      lVar5 = Component.get_gameObject(lVar5,0);
                      if ((this.explorePanelData != null) && (lVar5 != null)) {
                        GameObject.SetActive(lVar5,this.explorePanelData.exploreType == 1,0)
                        ;
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

    // Token : 0x60013E4
    // RVA   : 0x93A070   Offset: 0x938870   Length: 0x496
    public void FinishExploreMap(bool success)
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        bool cVar1;
        ulong uVar2;
        long lVar4;
        long lVar5;
        ExploreController.HideExploreMap(this,0);
        lVar5 = **(int64 **)(DAT_181d8fc60 + 184);
        uVar2 = Component.get_gameObject(this,0);
        if (lVar5 == null) throw; // [null/range check failed]
        WeatherController.SetWeatherSpeActive(lVar5,1,uVar2,0);
        if (!success) {
          plVar3 = (int64 *)Resources.Load("Sound/SoundEffect/Fail");
          plVar6 = (int64 *)0;
          if ((plVar3 != (int64 *)0) && (*plVar3 == DAT_181d8a228)) {
            plVar6 = plVar3;
          }
          NGUITools.PlaySound(plVar6,0);
          cVar1 = String.op_Inequality(this.failCallPlot,"",0);
          if (cVar1) {
            lVar5 = this.failCallPlot;
            lVar4 = FUN_1800d60b0(DAT_181d7c118,1);
            if (lVar4 == null) throw; // [null/range check failed]
            if (*(int *)(lVar4 + 24) == 0) {
              uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar2,0);
            }
            *(uint16 *)(lVar4 + 32) = 126;
            if ((lVar5 == null) || (lVar5 = String.Split(lVar5,lVar4,0)) == null) throw; // [null/range check failed]
            if (1 < *(int *)(lVar5 + 24)) {
              lVar4 = FUN_18046c440(0);
              if (*(uint32 *)(lVar5 + 24) == 0) {
                uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar2,0);
              }
              if (*(uint32 *)(lVar5 + 24) < 2) {
                uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar2,0);
              }
              goto LAB_18093a3cb;
            }
            lVar4 = FUN_18046c440(0);
            if (*(int *)(lVar5 + 24) == 0) {
              uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar2,0);
            }
        LAB_18093a24d:
            if (lVar4 == null) throw; // [null/range check failed]
            Component.SendMessage(lVar4,*(uint64 *)(lVar5 + 32),0);
          }
        }
        else {
          plVar3 = (int64 *)Resources.Load("Sound/SoundEffect/BigBigSuccess",0);
          plVar6 = (int64 *)0;
          if ((plVar3 != (int64 *)0) && (*plVar3 == DAT_181d8a228)) {
            plVar6 = plVar3;
          }
          NGUITools.PlaySound(plVar6,0);
          cVar1 = String.op_Inequality(this.successCallPlot,"",0);
          if (cVar1) {
            lVar5 = this.successCallPlot;
            lVar4 = FUN_1800d60b0(DAT_181d7c118,1);
            if (lVar4 == null) throw; // [null/range check failed]
            if (*(int *)(lVar4 + 24) == 0) {
              uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar2,0);
            }
            *(uint16 *)(lVar4 + 32) = 126;
            if ((lVar5 == null) || (lVar5 = String.Split(lVar5,lVar4,0)) == null) throw; // [null/range check failed]
            if (*(int *)(lVar5 + 24) < 2) {
              lVar4 = FUN_18046c440(0);
              if (*(int *)(lVar5 + 24) == 0) {
                uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar2,0);
              }
              goto LAB_18093a24d;
            }
            lVar4 = FUN_18046c440(0);
            if (*(uint32 *)(lVar5 + 24) == 0) {
              uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar2,0);
            }
            if (*(uint32 *)(lVar5 + 24) < 2) {
              uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar2,0);
            }
        LAB_18093a3cb:
            if (lVar4 == null) throw; // [null/range check failed]
            Component.SendMessage(lVar4,*(uint64 *)(lVar5 + 32),*(uint64 *)(lVar5 + 40),0);
          }
        }
        if (*pStatics != 0) {
          GameController.ChangeHour(*pStatics,0x41c00000,0);
          return;
        }
    }

    // Token : 0x60013E5
    // RVA   : 0x93A5A0   Offset: 0x938DA0   Length: 0x2BE6
    public void GenerateExploreMapData(string eventName, string exploreParamString, float difficulty)
    {
        var pStatics_c960 = *(int64*)(DAT_181d6c960 + 184);
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        var pStatics_ef00 = *(int64*)(DAT_181d4ef00 + 184);
        void ExploreController.GenerateExploreMapData
                     (int64 this,uint64 eventName,int64 exploreParamString,uint32 difficulty)
        {
        int iVar1;
        char cVar2;
        uint8 uVar3;
        uint32 uVar4;
        uint32 uVar5;
        int iVar6;
        int iVar7;
        int64 *plVar8;
        int64 lVar9;
        int64 lVar10;
        int64 lVar11;
        int64 lVar12;
        uint64 uVar13;
        int64 lVar14;
        int64 lVar15;
        int64 lVar16;
        int64 *plVar17;
        uint32 uVar18;
        uint32 uVar19;
        uint64 uVar20;
        int64 *plVar21;
        int iVar22;
        int iVar23;
        float fVar24;
        float fVar25;
        double dVar26;
        uint8 auVar27 [16];
        uint8 auVar28 [16];
        float fVar29;
        int local_res10 [2];
        int local_108;
        int local_104;
        int64 local_100;
        int64 local_f8;
        int64 lStack_f0;
        int64 local_e8;
        uint64 uStack_e0;
        uint64 extraout_XMM0_Qb;
        plVar21 = (int64 *)0;
        local_res10[0] = 0;
        plVar8 = (int64 *)Resources.Load("Sound/SoundEffect/Eagle",0);
        plVar17 = plVar21;
        if ((plVar8 != (int64 *)0) && (*plVar8 == DAT_181d8a228)) {
          plVar17 = plVar8;
        }
        NGUITools.PlaySound(plVar17,0);
        lVar9 = il2cpp_internal(DAT_181da0d20);
        local_100 = lVar9;
        ExploreMapData.ctor(lVar9,0);
        if (lVar9 == null) throw; // [null/range check failed]
        lVar9._items = eventName;
        *(uint32 *)(lVar9 + 40) = difficulty;
        lVar10 = FUN_1800d60b0(DAT_181d7c118,1);
        if (lVar10 == null) throw; // [null/range check failed]
        if (lVar10.Count == null) {
          uVar13 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar13,0);
        }
        *(uint16 *)(lVar10 + 32) = 59;
        if (exploreParamString == null) throw; // [null/range check failed]
        lVar10 = String.Split(exploreParamString,lVar10,0);
        local_e8 = lVar10;
        var lVar11 = new ExplorePanelData(0);
        if (lVar10 == null) throw; // [null/range check failed]
        if (5 < (int)lVar10.Count) {
          if (lVar10.Count < 6) {
            uVar13 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar13,0);
          }
          cVar2 = String.op_Inequality(*(uint64 *)(lVar10 + 72),"",0);
          if (cVar2) {
            if (lVar10.Count < 6) {
              uVar13 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar13,0);
            }
            uVar4 = Int32.Parse(*(uint64 *)(lVar10 + 72),0);
            if (lVar11 == null) throw; // [null/range check failed]
            *(uint32 *)(lVar11 + 20) = uVar4;
          }
        }
        if (6 < (int)lVar10.Count) {
          if (lVar10.Count < 7) {
            uVar13 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar13,0);
          }
          cVar2 = String.op_Inequality(*(uint64 *)(lVar10 + 80),"",0);
          if (cVar2) {
            if (lVar10.Count < 7) {
              uVar13 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar13,0);
            }
            uVar3 = FUN_1816fd990(*(uint64 *)(lVar10 + 80),"true",0);
            if (lVar11 == null) throw; // [null/range check failed]
            *(uint8 *)(lVar11 + 84) = uVar3;
          }
        }
        if (lVar10.Count < 2) {
          uVar13 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar13,0);
        }
        cVar2 = String.op_Inequality(*(uint64 *)(lVar10 + 40),"",0);
        if (!cVar2) {
        LAB_18093ab4d:
          if (lVar10.Count < 2) {
            uVar13 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar13,0);
          }
          cVar2 = FUN_1816fd990(*(uint64 *)(lVar10 + 40),"",0);
          if (!cVar2) {
            if (lVar10.Count < 2) {
              uVar13 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar13,0);
            }
            fVar29 = (float)Single.Parse(*(uint64 *)(lVar10 + 40),0);
          }
          else {
            fVar29 = 1.0;
          }
          uVar4 = 9;
          if (lVar10.Count == null) {
            uVar13 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar13,0);
          }
          local_108 = Int32.Parse(*(uint64 *)(lVar10 + 32),0);
          if (local_108 == 0) {
            fVar24 = *(float *)(lVar9 + 40) * 0.6 + 11.0;
        LAB_18093abdd:
            uVar4 = Mathf.RoundToInt(fVar24 * fVar29,0);
          }
          else if (local_108 == 1) {
            fVar24 = *(float *)(lVar9 + 40) * 0.6 + 9.0;
            goto LAB_18093abdd;
          }
          uVar5 = Mathf.Min(uVar4,*(uint32 *)(pStatics_ef00 + 0x210),0);
          if (lVar11 == null) throw; // [null/range check failed]
          *(uint32 *)(lVar11 + 24) = uVar5;
          uVar4 = Mathf.Min(uVar4,*(uint32 *)(pStatics_ef00 + 0x214),0);
        }
        else {
          if (lVar10.Count < 2) {
            uVar13 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar13,0);
          }
          if (*(int64 *)(lVar10 + 40) == 0) throw; // [null/range check failed]
          cVar2 = String.Contains(*(int64 *)(lVar10 + 40),"x",0);
          if (!cVar2) goto LAB_18093ab4d;
          if (lVar10.Count < 2) {
            uVar13 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar13,0);
          }
          lVar9 = *(int64 *)(lVar10 + 40);
          lVar12 = FUN_1800d60b0(DAT_181d7c118,1);
          if (lVar12 == null) throw; // [null/range check failed]
          if (*(int *)(lVar12 + 24) == 0) {
            uVar13 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar13,0);
          }
          *(uint16 *)(lVar12 + 32) = 120;
          if ((lVar9 == null) || (lVar9 = String.Split(lVar9,lVar12,0)) == null) throw; // [null/range check failed]
          if (lVar9.Count == null) {
            uVar13 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar13,0);
          }
          uVar4 = Int32.Parse(*(uint64 *)(lVar9 + 32),0);
          if (lVar11 == null) throw; // [null/range check failed]
          *(uint32 *)(lVar11 + 24) = uVar4;
          if (lVar9.Count < 2) {
            uVar13 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar13,0);
          }
          uVar4 = Int32.Parse(*(uint64 *)(lVar9 + 40),0);
        }
        *(uint32 *)(lVar11 + 28) = uVar4;
        local_f8 = (int64)*(int *)(lVar11 + 24);
        lStack_f0 = (int64)*(int *)(lVar11 + 28);
        uVar13 = FUN_1800d6020(DAT_181d84840,&local_f8);
        *(uint64 *)(lVar11 + 40) = uVar13;
        if (lVar10.Count == null) {
          uVar13 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar13,0);
        }
        local_108 = Int32.Parse(*(uint64 *)(lVar10 + 32),0);
        if (local_108 == 0) {
          *(uint32 *)(lVar11 + 16) = 0;
        }
        else if (local_108 == 1) {
          *(uint32 *)(lVar11 + 16) = 1;
          lVar9 = **(int64 **)(DAT_181d8fc60 + 184);
          uVar13 = Component.get_gameObject(this,0);
          if (lVar9 == null) throw; // [null/range check failed]
          WeatherController.SetWeatherSpeActive(lVar9,0,uVar13,0);
        }
        if (lVar10.Count < 3) {
          uVar13 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar13,0);
        }
        if (*(int64 *)(lVar10 + 48) == 0) throw; // [null/range check failed]
        cVar2 = String.Contains(*(int64 *)(lVar10 + 48),"~",0);
        if (!cVar2) {
          if (lVar10.Count < 3) {
            uVar13 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar13,0);
          }
          *(uint64 *)(lVar11 + 64) = *(uint64 *)(lVar10 + 48);
          uVar13 = "";
        }
        else {
          if (lVar10.Count < 3) {
            uVar13 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar13,0);
          }
          lVar9 = *(int64 *)(lVar10 + 48);
          lVar10 = FUN_1800d60b0(DAT_181d7c118,1);
          if (lVar10 == null) throw; // [null/range check failed]
          if (lVar10.Count == null) {
            uVar13 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar13,0);
          }
          *(uint16 *)(lVar10 + 32) = 126;
          if ((lVar9 == null) || (lVar9 = String.Split(lVar9,lVar10,0)) == null) throw; // [null/range check failed]
          if (lVar9.Count == null) {
            uVar13 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar13,0);
          }
          *(uint64 *)(lVar11 + 64) = *(uint64 *)(lVar9 + 32);
          if (lVar9.Count < 2) {
            uVar13 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar13,0);
          }
          uVar13 = *(uint64 *)(lVar9 + 40);
        }
        *(uint64 *)(lVar11 + 72) = uVar13;
        plVar8 = plVar21;
        while (iVar23 = (int)plVar8, plVar8 = plVar21, iVar23 < *(int *)(lVar11 + 28)) {
          while (iVar22 = (int)plVar8, iVar22 < *(int *)(lVar11 + 24)) {
            var lVar9 = new ExploreTileData(0);
            if (lVar9 == null) throw; // [null/range check failed]
            if (*(int *)(lVar11 + 16) == 0) {
              *(uint32 *)(lVar9 + 72) = 1;
              uVar13 = "";
              lVar9.Count = "";
        LAB_18093ae9e:
              il2cpp_internal(lVar9 + 24,uVar13);
            }
            else if (*(int *)(lVar11 + 16) == 1) {
              *(uint32 *)(lVar9 + 72) = 0;
              uVar4 = FUN_180d8cf10(0xfffffffe,4,0);
              local_108 = Mathf.Clamp(uVar4,0,3);
              uVar13 = Int32.ToString(&local_108,0);
              uVar13 = String.Concat("BattleTile_Grass",uVar13,0);
              lVar9.Count = uVar13;
              goto LAB_18093ae9e;
            }
            *(int *)(lVar9 + 36) = iVar22;
            *(int *)(lVar9 + 32) = iVar23;
            if ((*(int64 *)(lVar11 + 32) == 0) ||
               (FUN_181827900(*(int64 *)(lVar11 + 32),lVar9,DAT_181d5f878),
               *(int64 *)(lVar11 + 40) == 0)) throw; // [null/range check failed]
            FUN_180127fe0();
            plVar8 = (int64 *)(uint64)(iVar22 + 1);
          }
          plVar8 = (int64 *)(uint64)(iVar23 + 1);
        }
        iVar23 = *(int *)(lVar11 + 16);
        if (iVar23 == 1) {
          local_res10[0] = 3;
          do {
            local_104 = 0;
            while (iVar22 = 0, iVar23 = local_104, local_104 < *(int *)(lVar11 + 28)) {
              for (; iVar22 < *(int *)(lVar11 + 24); iVar22 = iVar22 + 1) {
                if (*(int64 *)(lVar11 + 40) == 0) throw; // [null/range check failed]
                lVar10 = (int64)iVar23;
                lVar12 = (int64)iVar22;
                lVar9 = FUN_180127f50(*(int64 *)(lVar11 + 40),lVar12);
                if (lVar9 == null) throw; // [null/range check failed]
                lVar9 = lVar9.Count;
                uVar13 = Int32.ToString(local_res10,0);
                String.Concat("BattleTile_Grass",uVar13);
                if (lVar9 == null) throw; // [null/range check failed]
                cVar2 = String.Contains();
                iVar7 = local_res10[0];
                if (cVar2) {
                  if (0 < iVar23) {
                    if (((*(int64 *)(lVar11 + 40) == 0) ||
                        (lVar9 = FUN_180127f50(*(int64 *)(lVar11 + 40),lVar12,lVar10 + -1),
                        lVar9 == null)) || (lVar9.Count == null)) throw; // [null/range check failed]
                    String.Replace();
                    iVar6 = Int32.Parse();
                    iVar23 = local_104;
                    if (1 < iVar7 - iVar6) {
                      if (*(int64 *)(lVar11 + 40) == 0) throw; // [null/range check failed]
                      lVar9 = FUN_180127f50(*(int64 *)(lVar11 + 40),lVar12);
                      local_108 = local_res10[0] + -1;
                      uVar13 = Int32.ToString(&local_108,0);
                      uVar13 = String.Concat("BattleTile_Grass",uVar13);
                      if (lVar9 == null) throw; // [null/range check failed]
                      lVar9.Count = uVar13;
                      iVar23 = local_104;
                    }
                  }
                  iVar7 = local_res10[0];
                  if (0 < iVar22) {
                    if (((*(int64 *)(lVar11 + 40) == 0) ||
                        (lVar9 = FUN_180127f50(*(int64 *)(lVar11 + 40),lVar12 + -1,lVar10),
                        lVar9 == null)) || (lVar9.Count == null)) throw; // [null/range check failed]
                    String.Replace();
                    iVar6 = Int32.Parse();
                    iVar23 = local_104;
                    if (1 < iVar7 - iVar6) {
                      if (*(int64 *)(lVar11 + 40) == 0) throw; // [null/range check failed]
                      lVar9 = FUN_180127f50(*(int64 *)(lVar11 + 40),lVar12 + -1);
                      local_108 = local_res10[0] + -1;
                      uVar13 = Int32.ToString(&local_108,0);
                      uVar13 = String.Concat("BattleTile_Grass",uVar13);
                      if (lVar9 == null) throw; // [null/range check failed]
                      lVar9.Count = uVar13;
                      iVar23 = local_104;
                    }
                  }
                  iVar7 = local_res10[0];
                  if (iVar23 < *(int *)(lVar11 + 28) + -1) {
                    if (((*(int64 *)(lVar11 + 40) == 0) ||
                        (lVar9 = FUN_180127f50(*(int64 *)(lVar11 + 40),lVar12,lVar10 + 1), lVar9 == null
                        )) || (lVar9.Count == null)) throw; // [null/range check failed]
                    String.Replace();
                    iVar6 = Int32.Parse();
                    iVar23 = local_104;
                    if (1 < iVar7 - iVar6) {
                      if (*(int64 *)(lVar11 + 40) == 0) throw; // [null/range check failed]
                      lVar9 = FUN_180127f50(*(int64 *)(lVar11 + 40),lVar12);
                      local_108 = local_res10[0] + -1;
                      uVar13 = Int32.ToString(&local_108,0);
                      uVar13 = String.Concat("BattleTile_Grass",uVar13);
                      if (lVar9 == null) throw; // [null/range check failed]
                      lVar9.Count = uVar13;
                      iVar23 = local_104;
                    }
                  }
                  iVar7 = local_res10[0];
                  if (iVar22 < *(int *)(lVar11 + 24) + -1) {
                    if (((*(int64 *)(lVar11 + 40) == 0) ||
                        (lVar9 = FUN_180127f50(*(int64 *)(lVar11 + 40),lVar12 + 1,lVar10), lVar9 == null
                        )) || (lVar9.Count == null)) throw; // [null/range check failed]
                    String.Replace();
                    iVar6 = Int32.Parse();
                    if (1 < iVar7 - iVar6) {
                      if (*(int64 *)(lVar11 + 40) == 0) throw; // [null/range check failed]
                      lVar9 = FUN_180127f50(*(int64 *)(lVar11 + 40),lVar12 + 1);
                      local_108 = local_res10[0] + -1;
                      uVar13 = Int32.ToString(&local_108,0);
                      uVar13 = String.Concat("BattleTile_Grass",uVar13);
                      if (lVar9 == null) throw; // [null/range check failed]
                      lVar9.Count = uVar13;
                    }
                  }
                }
              }
              local_104 = iVar23 + 1;
            }
            local_res10[0] = local_res10[0] + -1;
          } while (0 < local_res10[0]);
          iVar23 = *(int *)(lVar11 + 16);
        }
        fVar29 = 0.0;
        if (iVar23 == 0) {
          uVar18 = *(uint32 *)(lVar11 + 20);
          if (-1 < (int)uVar18) {
            lVar9 = this.ExploreMapTypeDataBase;
            if (lVar9 == null) throw; // [null/range check failed]
            if (lVar9.Count <= uVar18) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar9 = lVar9._items[uVar18];
            if (lVar9 == null) throw; // [null/range check failed]
            fVar29 = lVar9.Count;
          }
          fVar29 = fVar29 + 0.225;
          fVar24 = (float)Random.Range();
          iVar23 = *(int *)(lVar11 + 24);
          fVar25 = (float)GlobalData.RandomRange();
          fVar24 = fVar25 * (float)iVar23 + fVar24;
          dVar26 = (double)GlobalData.RandomRangeDouble(0,0);
          lVar9 = local_100;
          if (dVar26 < (double)(*(float *)(local_100 + 40) * 0.015 + 0.15)) {
            dVar26 = (double)GlobalData.RandomRangeDouble(0,0);
            if (dVar26 < (double)(*(float *)(lVar9 + 40) * 0.03 + 0.35)) {
              fVar24 = (float)Random.Range();
              iVar23 = *(int *)(lVar11 + 24);
            }
            else {
              fVar24 = (float)Random.Range();
              iVar23 = *(int *)(lVar11 + 24);
            }
            fVar25 = (float)GlobalData.RandomRange();
            fVar24 = fVar25 * (float)iVar23 + fVar24;
          }
          uVar18 = *(uint32 *)(lVar11 + 20);
          if ((int)uVar18 < 0) {
            fVar25 = 0.0;
          }
          else {
            lVar10 = this.ExploreMapTypeDataBase;
            if (lVar10 == null) throw; // [null/range check failed]
            if (lVar10.Count <= uVar18) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar10 = lVar10._items[uVar18];
            if (lVar10 == null) throw; // [null/range check failed]
            fVar25 = lVar10._version;
          }
          ExplorePanelData.GenerateWildGround
                    (lVar11,(int)(fVar25 + fVar24),*(uint32 *)(lVar9 + 40),0);
          lVar9 = il2cpp_internal(DAT_181d6f030);
          local_f8 = lVar9;
          FUN_180f58a90(lVar9,DAT_181d678f8);
          lVar10 = il2cpp_internal(DAT_181d6f030);
          FUN_180f58a90(lVar10,DAT_181d678f8);
          uVar18 = 0;
          lVar12 = 32;
          while (lVar14 = *(int64 *)(lVar11 + 32)) != null {
            if ((int)lVar14.Count <= (int)uVar18) {
              local_104 = 0;
              fVar24 = (float)(*(int *)(lVar11 + 24) + *(int *)(lVar11 + 28)) * 0.075;
              if (fVar24 < 0.0) goto LAB_18093b76d;
              goto LAB_18093b640;
            }
            if (lVar14.Count <= uVar18) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar14 = *(int64 *)(lVar12 + lVar14._items);
            if (lVar14 == null) break;
            if (*(int *)(lVar14 + 72) != 0) {
              if ((*(int64 *)(lVar11 + 32) == 0) ||
                 (lVar14 = FUN_180002f80(*(int64 *)(lVar11 + 32),uVar18)) == null) break;
              if (*(int64 *)(lVar14 + 80) == 0) {
                if ((lVar9 == null) || (FUN_181814fa0(lVar9,uVar18,DAT_181d67a78), lVar10 == null)) break;
                FUN_181814fa0(lVar10,uVar18);
              }
            }
            uVar18 = uVar18 + 1;
            lVar12 = lVar12 + 8;
          }
          throw; // [null/range check failed]
        }
        if (iVar23 == 1) {
          if (-1 < *(int *)(lVar11 + 20)) {
            if ((this.ExploreMapTypeDataBase == null) ||
               (lVar9 = FUN_180002f80(this.ExploreMapTypeDataBase,*(int *)(lVar11 + 20),DAT_181d5f600)
               , lVar9 == null)) throw; // [null/range check failed]
            fVar29 = lVar9.Count;
          }
          lVar9 = *(int64 *)(lVar11 + 32);
          fVar29 = fVar29 + 0.175;
          if (lVar9 == null) throw; // [null/range check failed]
          uVar18 = lVar9.Count;
          if (uVar18 <= uVar18 - 1) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar9 = *(int64 *)(lVar9._items + 24 + (int64)(int)uVar18 * 8);
          if (lVar9 == null) throw; // [null/range check failed]
          *(uint32 *)(lVar9 + 56) = 0xffffffff;
          fVar24 = (float)GlobalData.RandomRange();
          if (*(int64 *)(lVar11 + 32) == 0) throw; // [null/range check failed]
          uVar4 = Mathf.RoundToInt((float)*(int *)(*(int64 *)(lVar11 + 32) + 24) * fVar24,0);
          dVar26 = (double)GlobalData.RandomRangeDouble(0,0);
          lVar9 = local_100;
          if (dVar26 < (double)(*(float *)(local_100 + 40) * 0.015 + 0.15)) {
            dVar26 = (double)GlobalData.RandomRangeDouble(0,0);
            if (dVar26 < (double)(*(float *)(lVar9 + 40) * 0.03 + 0.35)) {
            }
            else if (((*(byte *)(DAT_181d4ef00 + 0x133) & 4) != 0) &&
                    (*(int *)(DAT_181d4ef00 + 224) == 0)) {
              il2cpp_runtime_class_init();
            }
            fVar24 = (float)GlobalData.RandomRange();
            if (*(int64 *)(lVar11 + 32) == 0) throw; // [null/range check failed]
            uVar4 = Mathf.RoundToInt((float)*(int *)(*(int64 *)(lVar11 + 32) + 24) * fVar24,0);
          }
          ExplorePanelData.GenerateMazeGround(lVar11,uVar4,0,*(uint32 *)(lVar9 + 40),0);
          if (*(int64 *)(lVar11 + 32) == 0) throw; // [null/range check failed]
          lVar9 = FUN_18046c0a0(0);
          if (((lVar9 == null) || (*(int64 *)(lVar9 + 32) == 0)) ||
             (lVar9 = WorldData.Player(*(int64 *)(lVar9 + 32),0)) == null) throw; // [null/range check failed]
          HeroData.GetExploreStepRate(lVar9,0);
          goto LAB_18093baf5;
        }
        goto LAB_18093bb0f;
        LAB_18093bd40:
        lVar14 = *(int64 *)(lVar11 + 32);
        if (lVar14 == null) throw; // [null/range check failed]
        if ((int)lVar14.Count <= (int)uVar18) {
          if (*pStatics_c960 == 0) throw; // [null/range check failed]
          if (*(int64 *)(*pStatics_c960 + 152) == 0) {
        LAB_18093ca99:
            this.seedRandomSpe = 0;
            this.nowSeedSpe = 0;
            this.seedRandomBase = 0;
            this.nowSeedBase = 0;
          }
          else {
            if ((*pStatics_c960 == 0) ||
               (lVar10 = *(int64 *)(*pStatics_c960 + 152)) == null)
            throw; // [null/range check failed]
            if (*(int *)(lVar10 + 156) == 0) goto LAB_18093ca99;
            if (this.seedRandomBase == null) {
        LAB_18093c3bc:
              lVar10 = FUN_18046c440(0);
              if ((lVar10 == null) || (*(int64 *)(lVar10 + 152) == 0)) throw; // [null/range check failed]
              uVar4 = *(uint32 *)(*(int64 *)(lVar10 + 152) + 156);
              this.seedRandomBase = new Random(uVar4,0);
              lVar10 = FUN_18046c440(0);
              if ((lVar10 == null) || (*(int64 *)(lVar10 + 152) == 0)) throw; // [null/range check failed]
              this.nowSeedBase = *(uint32 *)(*(int64 *)(lVar10 + 152) + 156);
            }
            else {
              iVar23 = this.nowSeedBase;
              lVar10 = FUN_18046c440(0);
              if ((lVar10 == null) || (*(int64 *)(lVar10 + 152) == 0)) throw; // [null/range check failed]
              if (iVar23 != *(int *)(*(int64 *)(lVar10 + 152) + 156)) goto LAB_18093c3bc;
            }
            if (lVar9 == null) throw; // [null/range check failed]
            iVar23 = lVar9.Count;
            if (0 < iVar23) {
              uVar18 = GlobalData.RandomRange(0,iVar23,0,0);
              if (lVar9.Count <= uVar18) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              uVar4 = lVar9._items[uVar18];
              FUN_181801c10(lVar9,uVar4,DAT_181d67e70);
              plVar8 = &this.seedRandomSpe;
              if (this.seedRandomSpe == null) {
        LAB_18093c528:
                lVar10 = FUN_18046c440(0);
                if ((lVar10 == null) || (*(int64 *)(lVar10 + 152) == 0)) throw; // [null/range check failed]
                uVar5 = *(uint32 *)(*(int64 *)(lVar10 + 152) + 156);
                this.seedRandomSpe = new Random(uVar5,0);
                il2cpp_internal(plVar8,lVar10);
                lVar10 = FUN_18046c440(0);
                if ((lVar10 == null) || (*(int64 *)(lVar10 + 152) == 0)) throw; // [null/range check failed]
                this.nowSeedSpe = *(uint32 *)(*(int64 *)(lVar10 + 152) + 156);
              }
              else {
                iVar23 = this.nowSeedSpe;
                lVar10 = FUN_18046c440(0);
                if ((lVar10 == null) || (*(int64 *)(lVar10 + 152) == 0)) throw; // [null/range check failed]
                if (iVar23 != *(int *)(*(int64 *)(lVar10 + 152) + 156)) goto LAB_18093c528;
              }
              plVar21 = (int64 *)this.seedRandomSpe;
              if (plVar21 == (int64 *)0) throw; // [null/range check failed]
              dVar26 = (double)(**(code **)(*plVar21 + 0x1a8))(plVar21,*(uint64 *)(*plVar21 + 0x1b0));
              if (0.05000000074505806 <= dVar26) {
        LAB_18093c7a6:
                if (dVar26 < 0.15000000596046448) {
                  lVar10 = FUN_18046c0a0(0);
                  if ((lVar10 == null) || (*(int64 *)(lVar10 + 32) == 0)) throw; // [null/range check failed]
                  if (*(int *)(*(int64 *)(lVar10 + 32) + 0x1c8) < 3) {
                    if ((*(int64 *)(lVar11 + 32) != 0) &&
                       (lVar10 = FUN_180002f80(*(int64 *)(lVar11 + 32),uVar4,DAT_181d5faf8),
                       lVar10 != null)) {
                      *(uint32 *)(lVar10 + 56) = 25;
                      if (*(int64 *)(lVar11 + 32) != 0) {
                        lVar10 = FUN_180002f80(*(int64 *)(lVar11 + 32),uVar4,DAT_181d5faf8);
                        plVar21 = (int64 *)this.seedRandomSpe;
                        if ((plVar21 != (int64 *)0) &&
                           (uVar4 = (**(code **)(*plVar21 + 0x188))
                                              (plVar21,0,6,*(uint64 *)(*plVar21 + 400)), lVar10 != null))
                        {
                          *(uint32 *)(lVar10 + 68) = uVar4;
                          lVar10 = FUN_18046c300(0);
                          uVar13 = FUN_180004500(DAT_181d63120);
                          uVar13 = String.Format("察觉到一股奇异气息，此处应有高人出没",uVar13,0);
                          lVar12 = FUN_18046c100(0);
                          if ((lVar12 != null) && (lVar12 = *(int64 *)(lVar12 + 56)) != null) {
                            if (*(uint32 *)(lVar12 + 24) < 4) {
                              ThrowHelper.ThrowArgumentOutOfRangeException(0);
                            }
                            lVar12 = *(int64 *)(*(int64 *)(lVar12 + 16) + 56);
                            goto LAB_18093c73a;
                          }
                        }
                      }
                    }
                    throw; // [null/range check failed]
                  }
                }
              }
              else {
                lVar10 = FUN_18046c0a0(0);
                if ((lVar10 == null) || (*(int64 *)(lVar10 + 32) == 0)) throw; // [null/range check failed]
                if (0 < *(int *)(*(int64 *)(lVar10 + 32) + 0x1cc)) goto LAB_18093c7a6;
                if ((*(int64 *)(lVar11 + 32) == 0) ||
                   (lVar10 = FUN_180002f80(*(int64 *)(lVar11 + 32),uVar4,DAT_181d5faf8)) == null
                   ) throw; // [null/range check failed]
                *(uint32 *)(lVar10 + 56) = 24;
                if (*(int64 *)(lVar11 + 32) == 0) throw; // [null/range check failed]
                lVar10 = FUN_180002f80(*(int64 *)(lVar11 + 32),uVar4,DAT_181d5faf8);
                plVar21 = (int64 *)this.seedRandomSpe;
                if ((plVar21 == (int64 *)0) ||
                   (uVar4 = (**(code **)(*plVar21 + 0x188))(plVar21,0,6,*(uint64 *)(*plVar21 + 400)),
                   lVar10 == null)) throw; // [null/range check failed]
                *(uint32 *)(lVar10 + 68) = uVar4;
                lVar10 = FUN_18046c300(0);
                uVar13 = FUN_180004500(DAT_181d63120);
                uVar13 = String.Format("察觉到一股奇异气息，此处应有高人出没",uVar13,0);
                lVar12 = FUN_18046c100(0);
                if ((lVar12 == null) || (lVar12 = *(int64 *)(lVar12 + 56)) == null)
                throw; // [null/range check failed]
                if (*(uint32 *)(lVar12 + 24) < 5) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar12 = *(int64 *)(*(int64 *)(lVar12 + 16) + 64);
        LAB_18093c73a:
                if ((lVar12 == null) || (lVar10 == null)) throw; // [null/range check failed]
                local_f8 = *(int64 *)(lVar12 + 24);
                lStack_f0 = *(int64 *)(lVar12 + 32);
                InfoController.AddInfoTab
                          (lVar10,uVar13,"UIAtlas","问号","Woosh",0x3f800000,0x40a00000,
                           &local_f8,0);
              }
              lVar10 = FUN_18046c0a0(0);
              if (((lVar10 == null) || (*(int64 *)(lVar10 + 32) == 0)) ||
                 (lVar10 = WorldData.Player(*(int64 *)(lVar10 + 32),0)) == null)
              throw; // [null/range check failed]
              cVar2 = HeroData.HaveForceFunction(lVar10,6);
              if (cVar2) {
                plVar8 = (int64 *)*plVar8;
                if (plVar8 == (int64 *)0) throw; // [null/range check failed]
                dVar26 = (double)(**(code **)(*plVar8 + 0x1a8))(plVar8,*(uint64 *)(*plVar8 + 0x1b0));
                iVar23 = lVar9.Count;
                if ((0 < iVar23) && (dVar26 < 0.20000000298023224)) {
                  uVar4 = GlobalData.RandomRange(0,iVar23,0,0);
                  uVar4 = FUN_1800d6750(lVar9,uVar4,DAT_181d68270);
                  FUN_181801c10(lVar9,uVar4,DAT_181d67e70);
                  if ((*(int64 *)(lVar11 + 32) == 0) ||
                     (lVar9 = FUN_180002f80(*(int64 *)(lVar11 + 32),uVar4,DAT_181d5faf8)) == null
                     ) throw; // [null/range check failed]
                  *(uint32 *)(lVar9 + 56) = 26;
                  lVar9 = FUN_18046c300(0);
                  uVar13 = FUN_180004500(DAT_181d63120);
                  uVar13 = String.Format("此地磁场非同寻常，附近应有陨铁出现",uVar13,0);
                  if (lVar9 == null) throw; // [null/range check failed]
                  local_f8 = 0;
                  lStack_f0 = 0;
                  InfoController.AddInfoTab
                            (lVar9,uVar13,"UIAtlas","陨铁","Woosh",0x3f800000,0x40a00000,
                             &local_f8,0);
                }
              }
            }
          }
          lVar9 = local_100;
          iVar23 = 0;
          if (*(int64 *)(local_100 + 48) != 0) {
            FUN_181827900(*(int64 *)(local_100 + 48),lVar11,DAT_181d5f700);
            uVar18 = *(uint32 *)(local_e8 + 24);
            uVar13 = "";
            uVar20 = "";
            if (3 < (int)uVar18) {
              if (uVar18 < 4) {
                uVar13 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar13,0);
              }
              uVar13 = *(uint64 *)(local_e8 + 56);
              if (4 < (int)uVar18) {
                if (uVar18 < 5) {
                  uVar13 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar13,0);
                }
                uVar20 = *(uint64 *)(local_e8 + 64);
              }
            }
            ExploreController.GenerateExploreMap(this,lVar9,uVar13,uVar20,0);
            if (((this.exploreUIPanel != null) &&
                (lVar10 = GameObject.get_transform(this.exploreUIPanel,0)) != null) &&
               (lVar10 = Transform.Find(lVar10,"Name",0)) != null) {
              uVar13 = Component.GetComponent(lVar10,DAT_181d6d8c0);
              LTLocalization.SetText(uVar13,lVar9._items,0);
              iVar22 = Mathf.RoundToInt();
              lVar9 = this.exploreUIPanel;
              if (lVar9 != null) goto LAB_18093cbb8;
            }
          }
          throw; // [null/range check failed]
        }
        if (lVar14.Count <= uVar18) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        lVar14 = *(int64 *)(lVar12 + lVar14._items);
        if (lVar14 == null) throw; // [null/range check failed]
        if (*(int *)(lVar14 + 56) == 0) {
          lVar14 = *(int64 *)(lVar11 + 56);
          if (*(int64 *)(lVar11 + 32) == 0) throw; // [null/range check failed]
          lVar15 = FUN_180002f80(*(int64 *)(lVar11 + 32),uVar18);
          if (lVar14 != lVar15) {
            if ((*(int64 *)(lVar11 + 32) == 0) ||
               (lVar14 = FUN_180002f80(*(int64 *)(lVar11 + 32),uVar18)) == null)
            throw; // [null/range check failed]
            if (*(int *)(lVar14 + 48) == 0) {
              if ((*(int64 *)(lVar11 + 32) == 0) ||
                 (lVar14 = FUN_180002f80(*(int64 *)(lVar11 + 32),uVar18)) == null)
              throw; // [null/range check failed]
              if (*(int64 *)(lVar14 + 80) == 0) {
                fVar24 = (float)Random.get_value(0);
                if (fVar24 <= fVar29) {
                  if ((*(int64 *)(lVar11 + 32) == 0) ||
                     (lVar14 = FUN_180002f80(*(int64 *)(lVar11 + 32),uVar18,DAT_181d5faf8),
                     lVar10 == null)) throw; // [null/range check failed]
                  uVar4 = FUN_180d8cf10(0,lVar10.Count,0);
                  uVar4 = FUN_1800d6750(lVar10,uVar4,DAT_181d68270);
                  if (lVar14 == null) throw; // [null/range check failed]
                  *(uint32 *)(lVar14 + 56) = uVar4;
                  lVar14 = this.ExploreTileTypeDataBase;
                  if ((((*(int64 *)(lVar11 + 32) == 0) ||
                       (lVar15 = FUN_180002f80(*(int64 *)(lVar11 + 32),uVar18,DAT_181d5faf8),
                       lVar15 == null)) || (lVar14 == null)) ||
                     (lVar14 = FUN_180002f80(lVar14,*(uint32 *)(lVar15 + 56),DAT_181d5ff78),
                     lVar14 == null)) throw; // [null/range check failed]
                  cVar2 = FUN_1816fd990(lVar14._items,"凶险",0);
                  lVar14 = *(int64 *)(lVar11 + 32);
                  if (!cVar2) {
                    lVar15 = this.ExploreTileTypeDataBase;
                    if (((lVar14 == null) ||
                        (lVar14 = FUN_180002f80(lVar14,uVar18,DAT_181d5faf8)) == null) ||
                       ((lVar15 == null ||
                        (lVar14 = FUN_180002f80(lVar15,*(uint32 *)(lVar14 + 56))) == null)))
                    throw; // [null/range check failed]
                    cVar2 = FUN_1816fd990(lVar14._items,"采集");
                    if (cVar2) {
                      if (*(int64 *)(lVar11 + 32) == 0) throw; // [null/range check failed]
                      lVar15 = FUN_180002f80(*(int64 *)(lVar11 + 32),uVar18,DAT_181d5faf8);
                      lVar14 = this.ExploreTileTypeDataBase;
                      if (((*(int64 *)(lVar11 + 32) == 0) ||
                          (lVar16 = FUN_180002f80(*(int64 *)(lVar11 + 32),uVar18,DAT_181d5faf8),
                          lVar16 == null)) ||
                         ((lVar14 == null ||
                          ((lVar14 = FUN_180002f80(lVar14,*(uint32 *)(lVar16 + 56),DAT_181d5ff78),
                           lVar14 == null || (lVar14 = *(int64 *)(lVar14 + 40)) == null)))))
                      throw; // [null/range check failed]
                      if (lVar14.Count == null) {
                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                      }
                      lVar14 = *(int64 *)(lVar14._items + 32);
                      if ((lVar14 = lVar14?.Count) == null)
                      throw; // [null/range check failed]
                      if (lVar14.Count == null) {
                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                      }
                      fVar24 = *(float *)(lVar14._items + 32);
                      lVar14 = this.ExploreTileTypeDataBase;
                      if ((((*(int64 *)(lVar11 + 32) == 0) ||
                           (lVar16 = FUN_180002f80(*(int64 *)(lVar11 + 32),uVar18,DAT_181d5faf8),
                           lVar16 == null)) || (lVar14 == null)) ||
                         ((lVar14 = FUN_180002f80(lVar14,*(uint32 *)(lVar16 + 56)), lVar14 == null ||
                          (lVar14 = *(int64 *)(lVar14 + 40)) == null))) throw; // [null/range check failed]
                      if (lVar14.Count == null) {
                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                      }
                      lVar14 = *(int64 *)(lVar14._items + 32);
                      if ((lVar14 = lVar14?.Count) == null)
                      throw; // [null/range check failed]
                      if (lVar14.Count < 2) {
                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                      }
                      fVar25 = *(float *)(lVar14._items + 36);
                      uVar4 = GlobalData.RandomRange((int)fVar24,(int)fVar25,0,0);
                      if (lVar15 == null) throw; // [null/range check failed]
                      *(uint32 *)(lVar15 + 68) = uVar4;
                    }
                  }
                  else {
                    if (lVar14 == null) throw; // [null/range check failed]
                    lVar15 = FUN_180002f80(lVar14,uVar18,DAT_181d5faf8);
                    lVar14 = local_100;
                    fVar24 = *(float *)(local_100 + 40);
                    auVar27._0_8_ = GlobalData.RandomRange();
                    auVar27._8_8_ = extraout_XMM0_Qb;
                    auVar28._4_12_ = auVar27._4_12_;
                    auVar28._0_4_ = (float)auVar27._0_8_ + fVar24;
                    uVar4 = FUN_1810a8ba0(auVar28._0_8_);
                    if (lVar15 == null) throw; // [null/range check failed]
                    *(uint32 *)(lVar15 + 60) = uVar4;
                    lVar15 = FUN_18046c0a0(0);
                    if (((lVar15 == null) || (*(int64 *)(lVar15 + 32) == 0)) ||
                       (lVar15 = *(int64 *)(*(int64 *)(lVar15 + 32) + 0x260)) == null)
                    throw; // [null/range check failed]
                    CustomDifficultyData.GetDifficultyRate(lVar15,6);
                    if (*(int64 *)(lVar11 + 32) == 0) throw; // [null/range check failed]
                    lVar15 = FUN_180002f80(*(int64 *)(lVar11 + 32),uVar18);
                    GlobalData.RandomRange
                              (*(float *)(lVar14 + 40) * 0.05 + 0.5,
                               *(float *)(lVar14 + 40) * 0.15 + 2.0);
                    uVar4 = Mathf.RoundToInt();
                    uVar4 = Mathf.Max(1,uVar4);
                    if (lVar15 == null) throw; // [null/range check failed]
                    *(uint32 *)(lVar15 + 64) = uVar4;
                  }
                }
                else {
                  if (lVar9 == null) throw; // [null/range check failed]
                  FUN_181814fa0(lVar9,uVar18);
                }
              }
            }
          }
        }
        uVar18 = uVar18 + 1;
        lVar12 = lVar12 + 8;
        goto LAB_18093bd40;
        LAB_18093cbb8:
        lVar9 = GameObject.get_transform(lVar9,0);
        if ((lVar9 == null) || (lVar9 = Transform.Find(lVar9,"DifficultStarGrid",0)) == null)
        throw; // [null/range check failed]
        iVar7 = Transform.get_childCount(lVar9,0);
        if (iVar7 <= iVar23) {
          if (((this.exploreUIPanel != null) &&
              (lVar9 = GameObject.get_transform(this.exploreUIPanel,0)) != null) &&
             ((lVar9 = Transform.Find(lVar9,"DifficultStarGrid",0), lVar9 != null &&
              (lVar9 = Component.GetComponent(lVar9,DAT_181d6e0c0)) != null))) {
            UIGrid.set_repositionNow(lVar9,1,0);
            return;
          }
          throw; // [null/range check failed]
        }
        iVar7 = Mathf.CeilToInt();
        lVar9 = this.exploreUIPanel;
        if (iVar7 < iVar23) {
          if (((lVar9 == null) || (lVar9 = GameObject.get_transform(lVar9,0)) == null) ||
             ((lVar9 = Transform.Find(lVar9,"DifficultStarGrid"), lVar9 == null ||
              ((lVar9 = Transform.GetChild(lVar9), lVar9 == null ||
               (lVar9 = Component.get_gameObject(lVar9)) == null))))) throw; // [null/range check failed]
          GameObject.SetActive(lVar9);
        }
        else {
          if ((((lVar9 == null) || (lVar9 = GameObject.get_transform(lVar9,0)) == null) ||
              (lVar9 = Transform.Find(lVar9,"DifficultStarGrid",0)) == null) ||
             ((lVar9 = Transform.GetChild(lVar9,iVar23,0), lVar9 == null ||
              (lVar9 = Component.get_gameObject(lVar9,0)) == null))) throw; // [null/range check failed]
          GameObject.SetActive(lVar9,1,0);
          iVar7 = Mathf.FloorToInt();
          lVar9 = this.exploreUIPanel;
          if (iVar7 < iVar23) {
            if ((((lVar9 == null) || (lVar9 = GameObject.get_transform(lVar9,0)) == null) ||
                (lVar9 = Transform.Find(lVar9,"DifficultStarGrid",0)) == null) ||
               (lVar9 = Transform.GetChild(lVar9,iVar23,0)) == null) throw; // [null/range check failed]
            lVar9 = Component.GetComponent(lVar9,DAT_181d6bc40);
            lVar10 = FUN_18046c6c0(0);
            uVar13 = "难度星_空心";
          }
          else {
            if (((lVar9 == null) || (lVar9 = GameObject.get_transform(lVar9,0)) == null) ||
               ((lVar9 = Transform.Find(lVar9,"DifficultStarGrid",0), lVar9 == null ||
                (lVar9 = Transform.GetChild(lVar9,iVar23,0)) == null))) throw; // [null/range check failed]
            lVar9 = Component.GetComponent(lVar9,DAT_181d6bc40);
            lVar10 = FUN_18046c6c0(0);
            uVar13 = "难度星_实心";
          }
          if ((lVar10 == null) ||
             (uVar13 = TextureController.LoadAtlasSprite(lVar10,"UIAtlas",uVar13,0), lVar9 == null))
          throw; // [null/range check failed]
          Image.set_sprite(lVar9,uVar13,0);
          if (((this.exploreUIPanel == null) ||
              ((lVar9 = GameObject.get_transform(this.exploreUIPanel,0), lVar9 == null ||
               (lVar9 = Transform.Find(lVar9,"DifficultStarGrid",0)) == null))) ||
             (lVar9 = Transform.GetChild(lVar9,iVar23,0)) == null) throw; // [null/range check failed]
          plVar8 = (int64 *)Component.GetComponent(lVar9,DAT_181d6bc40);
          lVar9 = FUN_18046c100(0);
          if (lVar9 == null) throw; // [null/range check failed]
          lVar9 = *(int64 *)(lVar9 + 56);
          lVar10 = FUN_18046c100(0);
          if ((((lVar10 == null) || (*(int64 *)(lVar10 + 56) == 0)) ||
              (uVar4 = Mathf.Clamp((int)((float)iVar22 * 0.5),0,
                                    *(uint32 *)(*(int64 *)(lVar10 + 56) + 24),0), lVar9 == null))
             || ((lVar9 = FUN_180002f80(lVar9,uVar4,DAT_181d76758), lVar9 == null ||
                 (plVar8 == (int64 *)0)))) throw; // [null/range check failed]
          local_e8 = lVar9.Count;
          uStack_e0 = *(uint64 *)(lVar9 + 32);
          (**(code **)(*plVar8 + 0x2a8))(plVar8);
        }
        lVar9 = this.exploreUIPanel;
        iVar23 = iVar23 + 1;
        if (lVar9 == null) throw; // [null/range check failed]
        goto LAB_18093cbb8;
        while( true ) {
          if (0 < lVar10.Count) {
            uVar4 = FUN_180d8cf10(0,lVar10.Count,0);
            uVar4 = FUN_1800d6750(lVar10,uVar4,DAT_181d68270);
            if ((*(int64 *)(lVar11 + 32) == 0) ||
               (lVar9 = FUN_180002f80(*(int64 *)(lVar11 + 32),uVar4,DAT_181d5faf8)) == null)
            throw; // [null/range check failed]
            *(uint32 *)(lVar9 + 56) = 3;
            if ((*(int64 *)(lVar11 + 32) == 0) ||
               (lVar9 = FUN_180002f80(*(int64 *)(lVar11 + 32),uVar4,DAT_181d5faf8)) == null)
            throw; // [null/range check failed]
            iVar23 = *(int *)(lVar9 + 36);
            if ((*(int64 *)(lVar11 + 32) == 0) ||
               (lVar9 = FUN_180002f80(*(int64 *)(lVar11 + 32),uVar4)) == null)
            throw; // [null/range check failed]
            iVar7 = *(int *)(lVar9 + 32);
            iVar22 = iVar23 + -1;
            iVar23 = iVar23 + 1;
            if (iVar22 <= iVar23) {
              iVar6 = iVar7 + -1;
              iVar1 = iVar6;
              do {
                for (; iVar1 <= iVar7 + 1; iVar1 = iVar1 + 1) {
                  if ((((-1 < iVar22) && (-1 < iVar1)) && (iVar22 < *(int *)(lVar11 + 24))) &&
                     (iVar1 < *(int *)(lVar11 + 28))) {
                    uVar4 = ExplorePanelData.GetTileID(lVar11,iVar22,iVar1,0);
                    FUN_181801c10(lVar10,uVar4);
                  }
                }
                iVar22 = iVar22 + 1;
                iVar1 = iVar6;
              } while (iVar22 <= iVar23);
            }
          }
          local_104 = local_104 + 1;
          if (fVar24 < (float)local_104) break;
        LAB_18093b640:
          if (lVar10 == null) throw; // [null/range check failed]
        }
        lVar14 = *(int64 *)(lVar11 + 32);
        lVar9 = local_f8;
        LAB_18093b76d:
        if (lVar9 == null) throw; // [null/range check failed]
        uVar18 = FUN_180d8cf10(0,lVar9.Count,0);
        if (lVar9.Count <= uVar18) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        if (lVar14 == null) throw; // [null/range check failed]
        uVar18 = lVar9._items[uVar18];
        if (lVar14.Count <= uVar18) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        lVar9 = lVar14._items[uVar18];
        if ((lVar9 == null) ||
           (*(uint32 *)(lVar9 + 56) = 0xffffffff, *(int64 *)(lVar11 + 32) == 0))
        throw; // [null/range check failed]
        if (((*pStatics_df90 == 0) ||
            (lVar9 = *(int64 *)(*pStatics_df90 + 32)) == null) ||
           (lVar9 = WorldData.Player(lVar9,0)) == null) throw; // [null/range check failed]
        HeroData.GetExploreStepRate(lVar9,0);
        LAB_18093baf5:
        uVar4 = Mathf.RoundToInt();
        *(uint32 *)(lVar11 + 48) = uVar4;
        LAB_18093bb0f:
        lVar10 = il2cpp_internal(DAT_181d6f030);
        FUN_180f58a90(lVar10,DAT_181d678f8);
        uVar18 = 1;
        lVar9 = this.ExploreTileTypeDataBase;
        if (lVar9 != null) {
          lVar12 = 40;
          while( true ) {
            if (lVar9.Count <= (int)uVar18) {
              lVar9 = il2cpp_internal(DAT_181d6f030);
              FUN_180f58a90(lVar9,DAT_181d678f8);
              uVar18 = 0;
              lVar12 = 32;
              goto LAB_18093bd40;
            }
            if (lVar9 == null) break;
            if (lVar9.Count <= uVar18) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar9 = *(int64 *)(lVar12 + lVar9._items);
            if ((lVar9 == null) || (lVar9 = *(int64 *)(lVar9 + 32)) == null) break;
            cVar2 = FUN_181815240(lVar9,*(uint32 *)(lVar11 + 16));
            uVar19 = (uint32)(cVar2);
            if (-1 < *(int *)(lVar11 + 20)) {
              iVar23 = 0;
              while( true ) {
                if (((this.ExploreMapTypeDataBase == null) ||
                    (lVar9 = FUN_180002f80(this.ExploreMapTypeDataBase,*(uint32 *)(lVar11 + 20)),
                    lVar9 == null)) || (*(int64 *)(lVar9 + 32) == 0)) throw; // [null/range check failed]
                if (*(int *)(*(int64 *)(lVar9 + 32) + 24) <= iVar23) break;
                if (((this.ExploreMapTypeDataBase == null) ||
                    (lVar9 = FUN_180002f80(this.ExploreMapTypeDataBase,*(uint32 *)(lVar11 + 20),
                                           DAT_181d5f600), lVar9 == null)) ||
                   ((*(int64 *)(lVar9 + 32) == 0 ||
                    (lVar9 = FUN_180002f80(*(int64 *)(lVar9 + 32),iVar23,DAT_181d5f580)) == null)
                   )) throw; // [null/range check failed]
                if (lVar9._items == uVar18) {
                  if (((this.ExploreMapTypeDataBase == null) ||
                      (lVar9 = FUN_180002f80(this.ExploreMapTypeDataBase,*(uint32 *)(lVar11 + 20),
                                             DAT_181d5f600), lVar9 == null)) ||
                     ((*(int64 *)(lVar9 + 32) == 0 ||
                      (lVar9 = FUN_180002f80(*(int64 *)(lVar9 + 32),iVar23,DAT_181d5f580), lVar9 == null
                      )))) throw; // [null/range check failed]
                  uVar19 = uVar19 + *(int *)(lVar9 + 20);
                }
                iVar23 = iVar23 + 1;
              }
            }
            iVar23 = 0;
            if (0 < (int)uVar19) {
              do {
                if (lVar10 == null) throw; // [null/range check failed]
                FUN_181814fa0(lVar10,uVar18);
                iVar23 = iVar23 + 1;
              } while (iVar23 < (int)uVar19);
            }
            uVar18 = uVar18 + 1;
            lVar12 = lVar12 + 8;
            lVar9 = this.ExploreTileTypeDataBase;
            if (lVar9 == null) break;
          }
        }
    }

    // Token : 0x60013E6
    // RVA   : 0x93D190   Offset: 0x93B990   Length: 0x3B6
    public void GenerateExploreMap(ExploreMapData targetExploreMapData, string successCallPlotString, string failCallPlotString)
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        void ExploreController.GenerateExploreMap
                     (int64 this,int64 targetExploreMapData,uint64 successCallPlotString,uint64 failCallPlotString)
        {
        char cVar1;
        uint32 uVar2;
        uint64 uVar3;
        int64 lVar4;
        uint32 uVar5;
        int64 lVar6;
        if (!this.inited) {
          ExploreController.InitExploreGround(this,0);
          this.inited = 1;
        }
        this.exploreMapData = targetExploreMapData;
        this.successCallPlot = successCallPlotString;
        this.failCallPlot = failCallPlotString;
        lVar4 = this.checkDisableObj;
        uVar5 = 0;
        if (lVar4 != null) {
          lVar6 = 32;
          while ((int)uVar5 < lVar4.Count) {
            if (lVar4 == null) throw; // [null/range check failed]
            if (lVar4.Count <= uVar5) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar4 = *(int64 *)(lVar6 + lVar4._items);
            if (lVar4 == null) throw; // [null/range check failed]
            cVar1 = GameObject.get_activeSelf(lVar4,0);
            if (cVar1) {
              lVar4 = this.checkEnableObj;
              if ((((this.checkDisableObj == null) ||
                   (uVar3 = FUN_180002f80(this.checkDisableObj,uVar5,DAT_181d62178), lVar4 == null))
                  || (FUN_181827900(lVar4,uVar3,DAT_181d61bf8), this.checkDisableObj == null)) ||
                 (lVar4 = FUN_180002f80()) == null) throw; // [null/range check failed]
              GameObject.SetActive(lVar4,0,0);
            }
            lVar4 = this.checkDisableObj;
            uVar5 = uVar5 + 1;
            lVar6 = lVar6 + 8;
            if (lVar4 == null) throw; // [null/range check failed]
          }
          if (this.exploreUIPanel != null) {
            GameObject.SetActive(this.exploreUIPanel,1,0);
            if (this.exploreObj != null) {
              GameObject.SetActive(this.exploreObj,1,0);
              if ((this.exploreObj != null) &&
                 (lVar4 = GameObject.GetComponent(this.exploreObj,DAT_181da2330),
                 lVar4 != null)) {
                UITweener.ResetToBeginning(lVar4,0);
                if ((this.exploreObj != null) &&
                   (lVar4 = GameObject.GetComponent(this.exploreObj,DAT_181da2330),
                   lVar4 != null)) {
                  UITweener.PlayForward(lVar4,0);
                  if (*pStatics != 0) {
                    lVar4 = *(int64 *)(*pStatics + 32);
                    if ((*pStatics != 0) &&
                       (lVar6 = *(int64 *)(*pStatics + 32)) != null)
                    {
                      lVar6 = WorldData.Player(lVar6,0);
                      if ((lVar6 != null) &&
                         ((uVar2 = HeroData.GetAreaID(lVar6,1,0), lVar4 != null &&
                          (lVar4 = WorldData.GetArea(lVar4,uVar2,0)) != null))) {
                        this.backgroundType = *(uint64 *)(lVar4 + 48);
                        if ((targetExploreMapData != null) && (lVar4 = *(int64 *)(targetExploreMapData + 48)) != null) {
                          if (lVar4.Count == null) {
                            ThrowHelper.ThrowArgumentOutOfRangeException(0);
                          }
                          ExploreController.GenerateExplorePanel
                                    (this,*(uint64 *)(lVar4._items + 32),0);
                          ExploreController.SetExploreBackground(this,0);
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

    // Token : 0x60013E7
    // RVA   : 0x93D550   Offset: 0x93BD50   Length: 0x2264
    public void GenerateExplorePanel(ExplorePanelData targetExplorePanelData)
    {
        var pStatics_0c98 = *(int64*)(DAT_181da0c98 + 184);
        var pStatics_2bf0 = *(int64*)(DAT_181d92bf0 + 184);
        int iVar1;
        uint uVar2;
        bool cVar3;
        long lVar4;
        long lVar6;
        long lVar7;
        long lVar8;
        ulong uVar10;
        ulong uVar11;
        uint uVar13;
        uint uVar14;
        long lVar15;
        uint uVar16;
        long lVar17;
        uint uVar18;
        uint uVar19;
        ulong local_468;
        float fStack_460;
        uint32 uStack_45c;
        uint32 local_458;
        float local_448;
        float fStack_444;
        float local_440;
        int local_438 [4];
        uint64 local_428;
        float local_420;
        uint64 local_418;
        uint32 local_410;
        float local_408;
        float fStack_404;
        float local_400;
        float local_3f8;
        float fStack_3f4;
        float local_3f0;
        float local_3e8;
        float fStack_3e4;
        float local_3e0;
        float local_3d8;
        float fStack_3d4;
        float local_3d0;
        float local_3c8;
        float fStack_3c4;
        float local_3c0;
        float local_3b8;
        float fStack_3b4;
        float local_3b0;
        float local_3a8;
        float fStack_3a4;
        float local_3a0;
        float local_398;
        float fStack_394;
        float local_390;
        uint64 local_388;
        uint32 local_380;
        uint64 local_378;
        uint32 local_370;
        uint64 local_368;
        uint32 local_360;
        uint64 local_358;
        float local_350;
        float local_340;
        uint64 local_338;
        float local_330;
        float local_320;
        uint64 local_318;
        float local_310;
        float local_300;
        uint64 local_2f8;
        float local_2f0;
        float local_2e0;
        uint64 local_2d8;
        float local_2d0;
        float local_2c0;
        uint64 local_2b8;
        float local_2b0;
        float local_2a0;
        uint64 local_298;
        float local_290;
        float local_280;
        uint64 local_278;
        float local_270;
        float local_260;
        uint64 local_258;
        uint32 local_250;
        float local_240;
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
        uint8 local_e8 [16];
        uint8 local_d8 [16];
        uint8 local_c8 [16];
        uint8 local_b8 [16];
        uint8 local_a8 [16];
        uint8 local_98 [96];
        uVar19 = 0;
        local_438[0] = 0;
        if (*pStatics_2bf0 != 0) {
          CloudAnimController.PlayerCloudAnim(*pStatics_2bf0,0);
          if ((this.exploreUIPanel != null) &&
             (lVar4 = GameObject.get_transform(this.exploreUIPanel,0)) != null) {
            lVar4 = Transform.Find(lVar4,"KeyNum",0);
            puVar5 = (uint64 *)Vector3.get_zero(&local_468,0);
            if (lVar4 != null) {
              local_410 = *(uint32 *)(puVar5 + 1);
              local_418 = *puVar5;
              Transform.set_localScale(lVar4,&local_418,0);
              this.explorePanelData = targetExplorePanelData;
              if (targetExplorePanelData != null) {
                bVar20 = !DAT_181e78072;
                this.leftPower = *(uint32 *)(targetExplorePanelData + 48);
                if (bVar20) {
                  il2cpp_runtime_class_init(&DAT_181d58e90);
                  il2cpp_runtime_class_init(&DAT_181d58f90);
                  DAT_181e78072 = true;
                }
                lVar4 = this.exploreRateRewarded;
                uVar14 = uVar19;
                while (lVar4 != null) {
                  if (lVar4.Count <= (int)uVar14) {
                    if (this.exploreGridRoot != null) {
                      lVar4 = GameObject.get_transform(this.exploreGridRoot,0);
                      if (lVar4 != null) {
                        local_440 = 0.0;
                        local_448 = (float)(*(int *)(targetExplorePanelData + 24) + -1) * -0.5;
                        fStack_444 = (float)(*(int *)(targetExplorePanelData + 28) + -1) * -0.5;
                        Transform.set_localPosition(lVar4,&local_448,0);
                        uVar14 = uVar19;
                        goto LAB_18093da41;
                      }
                    }
                    break;
                  }
                  if (lVar4 == null) break;
                  FUN_181814bb0(lVar4,uVar14);
                  uVar14 = uVar14 + 1;
                  lVar4 = this.exploreRateRewarded;
                }
              }
            }
          }
        }
        LAB_18093f7a9:
                          // WARNING: Subroutine does not return
        FUN_1800d6620();
        LAB_18093da41:
        uVar2 = uVar19;
        if ((int)uVar14 < *(int *)(targetExplorePanelData + 28)) {
        LAB_18093da53:
          local_458 = uVar2;
          if (*(int *)(targetExplorePanelData + 24) <= (int)local_458) goto LAB_18093f324;
          if (*(int64 *)(targetExplorePanelData + 32) == 0) goto LAB_18093f7a9;
          lVar4 = FUN_180002f80(*(int64 *)(targetExplorePanelData + 32),
                                *(int *)(targetExplorePanelData + 24) * uVar14 + local_458);
          if (lVar4 == null) {
        LAB_18093f319:
            uVar2 = local_458 + 1;
            goto LAB_18093da53;
          }
          if (this.gridUnits == null) goto LAB_18093f7a9;
          lVar15 = (int64)(int)local_458;
          lVar17 = (int64)(int)uVar14;
          lVar6 = FUN_180127f50(this.gridUnits,lVar15,lVar17);
          if (this.gridPool == null) goto LAB_18093f7a9;
          FUN_181827900(this.gridPool,lVar6);
          cVar3 = Object.op_Inequality(lVar6,0);
          if (!cVar3) goto LAB_18093f319;
          if ((lVar6 == null) || (lVar7 = GameObject.GetComponent(lVar6,DAT_181d9f5d0)) == null)
          goto LAB_18093f7a9;
          *(int64 *)(lVar7 + 24) = lVar4;
          cVar3 = String.op_Inequality(lVar4.Count,"",0);
          if (!cVar3) {
            lVar7 = GameObject.get_transform(lVar6,0);
            if (((lVar7 == null) || (lVar7 = Transform.Find(lVar7,"Ground",0)) == null) ||
               (lVar7 = Component.get_gameObject(lVar7,0)) == null) goto LAB_18093f7a9;
            cVar3 = GameObject.get_activeSelf(lVar7,0);
            if (cVar3) {
              lVar7 = GameObject.get_transform(lVar6,0);
              if (((lVar7 == null) || (lVar7 = Transform.Find(lVar7,"Ground",0)) == null) ||
                 (lVar7 = Component.get_gameObject(lVar7,0)) == null) goto LAB_18093f7a9;
              GameObject.SetActive(lVar7,0,0);
            }
          }
          else {
            lVar7 = GameObject.get_transform(lVar6,0);
            if (((lVar7 == null) || (lVar7 = Transform.Find(lVar7,"Ground",0)) == null) ||
               (lVar7 = Component.get_gameObject(lVar7,0)) == null) goto LAB_18093f7a9;
            cVar3 = GameObject.get_activeSelf(lVar7,0);
            if (!cVar3) {
              lVar7 = GameObject.get_transform(lVar6,0);
              if (((lVar7 == null) || (lVar7 = Transform.Find(lVar7,"Ground",0)) == null) ||
                 (lVar7 = Component.get_gameObject(lVar7,0)) == null) goto LAB_18093f7a9;
              GameObject.SetActive(lVar7,1,0);
            }
            lVar7 = GameObject.get_transform(lVar6,0);
            if (((lVar7 == null) || (lVar7 = Transform.Find(lVar7,"Ground",0)) == null) ||
               ((lVar7 = Component.GetComponent(lVar7,DAT_181d6d540), lVar7 == null ||
                ((lVar7 = SpriteRenderer.get_sprite(lVar7,0), lVar7 == null ||
                 (lVar7 = Object.get_name(lVar7,0)) == null))))) goto LAB_18093f7a9;
            cVar3 = String.Contains(lVar7,lVar4.Count,0);
            if (!cVar3) {
              lVar7 = GameObject.get_transform(lVar6,0);
              if ((lVar7 == null) || (lVar7 = Transform.Find(lVar7,"Ground",0)) == null)
              goto LAB_18093f7a9;
              lVar7 = Component.GetComponent(lVar7,DAT_181d6d540);
              lVar8 = FUN_18046c6c0(0);
              if ((lVar8 == null) ||
                 (uVar10 = TextureController.LoadAtlasSprite
                                     (lVar8,"TileAtlas",lVar4.Count), lVar7 == null))
              goto LAB_18093f7a9;
              SpriteRenderer.set_sprite(lVar7,uVar10,0);
            }
          }
          iVar1 = *(int *)(lVar4 + 40);
          if (iVar1 == 0) {
            if ((this.gridUnits == null) ||
               (lVar7 = FUN_180127f50(this.gridUnits,lVar15,lVar17)) == null)
            goto LAB_18093f7a9;
            lVar7 = GameObject.get_transform(lVar7,0);
            puVar9 = (uint64 *)Vector3.get_zero(local_1a8,0);
            puVar5 = &local_258;
            local_250 = *(uint32 *)(puVar9 + 1);
            local_258 = *puVar9;
            puVar12 = local_178;
        LAB_18093dea3:
            puVar5 = (uint64 *)Quaternion.Euler(puVar12,puVar5,0);
            if (lVar7 == null) goto LAB_18093f7a9;
            local_468 = *puVar5;
            fStack_460 = *(float *)(puVar5 + 1);
            uStack_45c = *(uint32 *)((int64)puVar5 + 12);
            Transform.set_localRotation(lVar7,&local_468,0);
          }
          else {
            if (iVar1 == 1) {
              if ((this.gridUnits != null) &&
                 (lVar7 = FUN_180127f50(this.gridUnits,lVar15,lVar17)) != null) {
                lVar7 = GameObject.get_transform(lVar7,0);
                local_378 = 0;
                puVar5 = &local_378;
                local_370 = 0x42b40000;
                puVar12 = local_188;
                goto LAB_18093dea3;
              }
              goto LAB_18093f7a9;
            }
            if (iVar1 == 2) {
              if ((this.gridUnits != null) &&
                 (lVar7 = FUN_180127f50(this.gridUnits,lVar15,lVar17)) != null) {
                lVar7 = GameObject.get_transform(lVar7,0);
                local_388 = 0;
                puVar5 = &local_388;
                local_380 = 0x43340000;
                puVar12 = local_198;
                goto LAB_18093dea3;
              }
              goto LAB_18093f7a9;
            }
          }
          if (((this.gridUnits == null) ||
              (lVar17 = FUN_180127f50(this.gridUnits,lVar15,lVar17)) == null) ||
             (lVar17 = GameObject.GetComponent(lVar17,DAT_181da19b0)) == null) goto LAB_18093f7a9;
          SpriteRenderer.set_flipX(lVar17,*(uint8 *)(lVar4 + 44),0);
          if (((this.gridUnits == null) ||
              (lVar15 = FUN_180127f50(this.gridUnits,lVar15)) == null) ||
             (lVar15 = GameObject.GetComponent(lVar15,DAT_181da19b0)) == null) goto LAB_18093f7a9;
          SpriteRenderer.set_flipY(lVar15,*(uint8 *)(lVar4 + 45));
          if (1 < *(uint32 *)(lVar4 + 72)) {
            lVar15 = il2cpp_internal(DAT_181d72a30);
            FUN_180f58a90(lVar15,DAT_181d7c250);
            if (lVar15 == null) goto LAB_18093f7a9;
            FUN_181827900(lVar15,"forest",DAT_181d7c3d0);
            FUN_181827900(lVar15,"mountain",DAT_181d7c3d0);
            FUN_181827900(lVar15,"river",DAT_181d7c3d0);
            lVar17 = GameObject.GetComponent(lVar6,DAT_181d9f5d0);
            uVar10 = FUN_180002f80(lVar15,*(int *)(lVar4 + 72) + -2,DAT_181d7c9c0);
            uVar10 = String.Concat("Skeleton/Explore/",uVar10,"/skeleton_SkeletonData",0);
            puVar5 = (uint64 *)Vector3.get_one(local_228,0);
            local_468 = *puVar5;
            fStack_460 = *(float *)(puVar5 + 1);
            fStack_404 = (float)((uint64)local_468 >> 32) / 1.6;
            local_408 = (float)local_468 / 1.6;
            local_400 = fStack_460 / 1.6;
            local_240 = fStack_460;
            uVar11 = FUN_180002f80(lVar15,*(int *)(lVar4 + 72) + -2,DAT_181d7c9c0);
            uVar11 = String.Format("{0}{1}_0",uVar11,this.backgroundType,0);
            local_358 = CONCAT44(fStack_404,local_408);
            local_350 = local_400;
            lVar15 = GlobalData.GenerateSkeletonAnimation
                               (lVar6,uVar10,&local_358,"idle",1,uVar11,0);
            if ((lVar15 == null) || (uVar10 = Component.get_gameObject(lVar15,0), lVar17 == null))
            goto LAB_18093f7a9;
            *(uint64 *)(lVar17 + 32) = uVar10;
            lVar15 = GameObject.GetComponent(lVar6,DAT_181d9f5d0);
            if ((lVar15 == null) ||
               ((*(int64 *)(lVar15 + 32) == 0 ||
                (lVar15 = GameObject.get_transform(*(int64 *)(lVar15 + 32),0)) == null)))
            goto LAB_18093f7a9;
            local_368 = 0;
            local_360 = 0xbd4ccccd;
            Transform.set_localPosition(lVar15,&local_368);
          }
          if ((*(int *)(targetExplorePanelData + 16) != 0) || (*(int *)(lVar4 + 72) != 0)) goto LAB_18093f016;
          lVar15 = il2cpp_internal(DAT_181d6f030);
          FUN_180f58a90(lVar15,DAT_181d678f8);
          uVar2 = local_458;
          uVar16 = uVar19;
          do {
            lVar17 = ExplorePanelData.GetGridDataByDir(targetExplorePanelData,uVar14,uVar2,uVar16,0);
            if (lVar17 == null) {
        LAB_18093e20e:
              if (lVar15 == null) goto LAB_18093f7a9;
              FUN_181814fa0(lVar15,uVar16,DAT_181d67a78);
            }
            else {
              lVar17 = ExplorePanelData.GetGridDataByDir(targetExplorePanelData,uVar14,uVar2,uVar16,0);
              if (lVar17 == null) goto LAB_18093f7a9;
              if (*(int *)(lVar17 + 72) == 0) goto LAB_18093e20e;
            }
            uVar16 = uVar16 + 1;
          } while ((int)uVar16 < 4);
          if (lVar15 == null) goto LAB_18093f7a9;
          local_438[0] = *(int *)(lVar15 + 24);
          if (local_438[0] == 1) {
            lVar17 = GameObject.GetComponent(lVar6,DAT_181d9f5d0);
            puVar5 = (uint64 *)Vector3.get_one(local_238,0);
            local_468 = *puVar5;
            fStack_460 = *(float *)(puVar5 + 1);
            fStack_444 = (float)((uint64)local_468 >> 32) / 1.5;
            local_448 = (float)local_468 / 1.5;
            local_440 = fStack_460 / 1.5;
            local_260 = fStack_460;
            uVar10 = String.Format("road0_{0}_0",this.backgroundType,0);
            local_428 = CONCAT44(fStack_444,local_448);
            local_420 = local_440;
            lVar7 = GlobalData.GenerateSkeletonAnimation
                              (lVar6,"Skeleton/Explore/road0/skeleton_SkeletonData",&local_428,"idle",1,uVar10,0);
            if ((lVar7 == null) || (uVar10 = Component.get_gameObject(lVar7,0), lVar17 == null))
            goto LAB_18093f7a9;
            *(uint64 *)(lVar17 + 32) = uVar10;
            if (*(int *)(lVar15 + 24) == 0) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            iVar1 = *(int *)(*(int64 *)(lVar15 + 16) + 32);
            if (iVar1 == 0) {
              lVar15 = GameObject.GetComponent(lVar6,DAT_181d9f5d0);
              if ((lVar15 != null) && (*(int64 *)(lVar15 + 32) != 0)) {
                lVar17 = GameObject.get_transform(*(int64 *)(lVar15 + 32),0);
                puVar12 = local_98;
                goto LAB_18093ef8f;
              }
              goto LAB_18093f7a9;
            }
            if (iVar1 == 1) {
              lVar15 = GameObject.GetComponent(lVar6,DAT_181d9f5d0);
              if ((lVar15 != null) && (*(int64 *)(lVar15 + 32) != 0)) {
                lVar17 = GameObject.get_transform(*(int64 *)(lVar15 + 32),0);
                puVar12 = local_a8;
                goto LAB_18093ef8f;
              }
              goto LAB_18093f7a9;
            }
            if (iVar1 == 2) {
              lVar15 = GameObject.GetComponent(lVar6,DAT_181d9f5d0);
              if ((lVar15 != null) && (*(int64 *)(lVar15 + 32) != 0)) {
                lVar17 = GameObject.get_transform(*(int64 *)(lVar15 + 32),0);
                puVar12 = local_b8;
                goto LAB_18093ef8f;
              }
              goto LAB_18093f7a9;
            }
            if (iVar1 == 3) {
              lVar15 = GameObject.GetComponent(lVar6,DAT_181d9f5d0);
              if ((lVar15 != null) && (*(int64 *)(lVar15 + 32) != 0)) {
                lVar17 = GameObject.get_transform(*(int64 *)(lVar15 + 32),0);
                puVar12 = local_c8;
                goto LAB_18093ef8f;
              }
              goto LAB_18093f7a9;
            }
          }
          else {
            if (local_438[0] == 2) {
              cVar3 = FUN_181815240(lVar15,0,DAT_181d67bf8);
              if ((!cVar3) || (cVar3 = FUN_181815240(lVar15,1,DAT_181d67bf8), !cVar3)) {
                cVar3 = FUN_181815240(lVar15,2,DAT_181d67bf8);
                if ((!cVar3) || (cVar3 = FUN_181815240(lVar15,3,DAT_181d67bf8), !cVar3)) {
                  cVar3 = FUN_181815240(lVar15,0,DAT_181d67bf8);
                  if (!cVar3) {
                    cVar3 = FUN_181815240(lVar15,1);
                    if (!cVar3) goto LAB_18093efc0;
                    lVar17 = GameObject.GetComponent(lVar6,DAT_181d9f5d0);
                    puVar5 = (uint64 *)Vector3.get_one(local_1c8,0);
                    local_468 = *puVar5;
                    fStack_460 = *(float *)(puVar5 + 1);
                    fStack_3b4 = (float)((uint64)local_468 >> 32) / 1.5;
                    local_3b8 = (float)local_468 / 1.5;
                    local_3b0 = fStack_460 / 1.5;
                    local_2a0 = fStack_460;
                    uVar10 = String.Format("road2_{0}_0",this.backgroundType,0);
                    local_298 = CONCAT44(fStack_3b4,local_3b8);
                    local_290 = local_3b0;
                    lVar7 = GlobalData.GenerateSkeletonAnimation
                                      (lVar6,"Skeleton/Explore/road2/skeleton_SkeletonData",&local_298,"idle",1,uVar10,0);
                    if ((lVar7 == null) || (uVar10 = Component.get_gameObject(lVar7,0), lVar17 == null))
                    goto LAB_18093f7a9;
                    *(uint64 *)(lVar17 + 32) = uVar10;
                    lVar17 = GameObject.GetComponent(lVar6,DAT_181d9f5d0);
                    if ((lVar17 == null) || (*(int64 *)(lVar17 + 32) == 0)) goto LAB_18093f7a9;
                    lVar17 = GameObject.get_transform(*(int64 *)(lVar17 + 32),0);
                    cVar3 = FUN_181815240(lVar15,2);
                    if (!cVar3) {
                      puVar12 = local_e8;
                    }
                    else {
                      puVar12 = local_e8;
                    }
                  }
                  else {
                    lVar17 = GameObject.GetComponent(lVar6,DAT_181d9f5d0);
                    puVar5 = (uint64 *)Vector3.get_one(local_1b8,0);
                    local_468 = *puVar5;
                    fStack_460 = *(float *)(puVar5 + 1);
                    fStack_3a4 = (float)((uint64)local_468 >> 32) / 1.5;
                    local_3a8 = (float)local_468 / 1.5;
                    local_3a0 = fStack_460 / 1.5;
                    local_280 = fStack_460;
                    uVar10 = String.Format("road2_{0}_0",this.backgroundType,0);
                    local_278 = CONCAT44(fStack_3a4,local_3a8);
                    local_270 = local_3a0;
                    lVar7 = GlobalData.GenerateSkeletonAnimation
                                      (lVar6,"Skeleton/Explore/road2/skeleton_SkeletonData",&local_278,"idle",1,uVar10,0);
                    if ((lVar7 == null) || (uVar10 = Component.get_gameObject(lVar7,0), lVar17 == null))
                    goto LAB_18093f7a9;
                    *(uint64 *)(lVar17 + 32) = uVar10;
                    lVar17 = GameObject.GetComponent(lVar6,DAT_181d9f5d0);
                    if ((lVar17 == null) || (*(int64 *)(lVar17 + 32) == 0)) goto LAB_18093f7a9;
                    lVar17 = GameObject.get_transform(*(int64 *)(lVar17 + 32),0);
                    cVar3 = FUN_181815240(lVar15,2);
                    if (!cVar3) {
                      puVar12 = local_d8;
                    }
                    else {
                      puVar12 = local_d8;
                    }
                  }
                }
                else {
                  lVar15 = GameObject.GetComponent(lVar6,DAT_181d9f5d0);
                  puVar5 = (uint64 *)Vector3.get_one(local_1d8,0);
                  local_468 = *puVar5;
                  fStack_460 = *(float *)(puVar5 + 1);
                  fStack_394 = (float)((uint64)local_468 >> 32) / 1.5;
                  local_398 = (float)local_468 / 1.5;
                  local_390 = fStack_460 / 1.5;
                  local_2c0 = fStack_460;
                  uVar10 = String.Format("road1_{0}_0",this.backgroundType,0);
                  local_2b8 = CONCAT44(fStack_394,local_398);
                  local_2b0 = local_390;
                  lVar17 = GlobalData.GenerateSkeletonAnimation
                                     (lVar6,"Skeleton/Explore/road1/skeleton_SkeletonData",&local_2b8,"idle",1,uVar10,0);
                  if ((lVar17 == null) || (uVar10 = Component.get_gameObject(lVar17,0), lVar15 == null))
                  goto LAB_18093f7a9;
                  *(uint64 *)(lVar15 + 32) = uVar10;
                  lVar15 = GameObject.GetComponent(lVar6,DAT_181d9f5d0);
                  if ((lVar15 == null) || (*(int64 *)(lVar15 + 32) == 0)) goto LAB_18093f7a9;
                  lVar17 = GameObject.get_transform(*(int64 *)(lVar15 + 32),0);
                  puVar12 = local_f8;
                }
              }
              else {
                lVar15 = GameObject.GetComponent(lVar6,DAT_181d9f5d0);
                puVar5 = (uint64 *)Vector3.get_one(local_1e8,0);
                local_468 = *puVar5;
                fStack_460 = *(float *)(puVar5 + 1);
                fStack_3c4 = (float)((uint64)local_468 >> 32) / 1.5;
                local_3c8 = (float)local_468 / 1.5;
                local_3c0 = fStack_460 / 1.5;
                local_2e0 = fStack_460;
                uVar10 = String.Format("road1_{0}_0",this.backgroundType,0);
                local_2d8 = CONCAT44(fStack_3c4,local_3c8);
                local_2d0 = local_3c0;
                lVar17 = GlobalData.GenerateSkeletonAnimation
                                   (lVar6,"Skeleton/Explore/road1/skeleton_SkeletonData",&local_2d8,"idle",1,uVar10,0);
                if ((lVar17 == null) || (uVar10 = Component.get_gameObject(lVar17,0), lVar15 == null))
                goto LAB_18093f7a9;
                *(uint64 *)(lVar15 + 32) = uVar10;
                lVar15 = GameObject.GetComponent(lVar6,DAT_181d9f5d0);
                if ((lVar15 == null) || (*(int64 *)(lVar15 + 32) == 0)) goto LAB_18093f7a9;
                lVar17 = GameObject.get_transform(*(int64 *)(lVar15 + 32),0);
                puVar12 = local_108;
              }
        LAB_18093ef8f:
              puVar5 = (uint64 *)Quaternion.Euler(puVar12);
              if (lVar17 == null) goto LAB_18093f7a9;
            }
            else {
              if (local_438[0] == 3) {
                lVar17 = GameObject.GetComponent(lVar6,DAT_181d9f5d0);
                puVar5 = (uint64 *)Vector3.get_one(local_1f8,0);
                local_468 = *puVar5;
                fStack_460 = *(float *)(puVar5 + 1);
                fStack_3d4 = (float)((uint64)local_468 >> 32) / 1.5;
                local_3d8 = (float)local_468 / 1.5;
                local_3d0 = fStack_460 / 1.5;
                local_300 = fStack_460;
                uVar10 = String.Format("road3_{0}_0",this.backgroundType,0);
                local_2f8 = CONCAT44(fStack_3d4,local_3d8);
                local_2f0 = local_3d0;
                lVar7 = GlobalData.GenerateSkeletonAnimation
                                  (lVar6,"Skeleton/Explore/road3/skeleton_SkeletonData",&local_2f8,"idle",1,uVar10,0);
                if ((lVar7 == null) || (uVar10 = Component.get_gameObject(lVar7,0), lVar17 == null))
                goto LAB_18093f7a9;
                *(uint64 *)(lVar17 + 32) = uVar10;
                cVar3 = FUN_181815240(lVar15,0);
                if (!cVar3) {
                  lVar15 = GameObject.GetComponent(lVar6,DAT_181d9f5d0);
                  if ((lVar15 == null) || (*(int64 *)(lVar15 + 32) == 0)) goto LAB_18093f7a9;
                  lVar17 = GameObject.get_transform(*(int64 *)(lVar15 + 32),0);
                  puVar12 = local_118;
                }
                else {
                  cVar3 = FUN_181815240(lVar15,1);
                  if (!cVar3) {
                    lVar15 = GameObject.GetComponent(lVar6,DAT_181d9f5d0);
                    if ((lVar15 == null) || (*(int64 *)(lVar15 + 32) == 0)) goto LAB_18093f7a9;
                    lVar17 = GameObject.get_transform(*(int64 *)(lVar15 + 32),0);
                    puVar12 = local_128;
                  }
                  else {
                    cVar3 = FUN_181815240(lVar15,2);
                    if (cVar3) {
                      lVar15 = GameObject.GetComponent(lVar6);
                      if ((lVar15 != null) && (*(int64 *)(lVar15 + 32) != 0)) {
                        lVar17 = GameObject.get_transform(*(int64 *)(lVar15 + 32),0);
                        puVar12 = local_148;
                        goto LAB_18093ef8f;
                      }
                      goto LAB_18093f7a9;
                    }
                    lVar15 = GameObject.GetComponent(lVar6,DAT_181d9f5d0);
                    if ((lVar15 == null) || (*(int64 *)(lVar15 + 32) == 0)) goto LAB_18093f7a9;
                    lVar17 = GameObject.get_transform(*(int64 *)(lVar15 + 32),0);
                    puVar12 = local_138;
                  }
                }
                goto LAB_18093ef8f;
              }
              if (local_438[0] == 4) {
                lVar15 = GameObject.GetComponent(lVar6);
                puVar5 = (uint64 *)Vector3.get_one(local_208,0);
                local_468 = *puVar5;
                fStack_460 = *(float *)(puVar5 + 1);
                fStack_3e4 = (float)((uint64)local_468 >> 32) / 1.5;
                local_3e8 = (float)local_468 / 1.5;
                local_3e0 = fStack_460 / 1.5;
                local_320 = fStack_460;
                uVar10 = String.Format("road4_{0}_0",this.backgroundType,0);
                local_318 = CONCAT44(fStack_3e4,local_3e8);
                local_310 = local_3e0;
                lVar17 = GlobalData.GenerateSkeletonAnimation
                                   (lVar6,"Skeleton/Explore/road4/skeleton_SkeletonData",&local_318,"idle",1,uVar10,0);
                if ((lVar17 == null) || (uVar10 = Component.get_gameObject(lVar17,0), lVar15 == null))
                goto LAB_18093f7a9;
                *(uint64 *)(lVar15 + 32) = uVar10;
                lVar15 = GameObject.GetComponent(lVar6,DAT_181d9f5d0);
                if ((lVar15 == null) || (*(int64 *)(lVar15 + 32) == 0)) throw; // [null/range check failed]
                lVar17 = GameObject.get_transform(*(int64 *)(lVar15 + 32),0);
                puVar5 = (uint64 *)Quaternion.Euler(local_158);
              }
              else {
                lVar15 = GameObject.GetComponent(lVar6);
                puVar5 = (uint64 *)Vector3.get_one(local_218,0);
                local_468 = *puVar5;
                fStack_460 = *(float *)(puVar5 + 1);
                fStack_3f4 = (float)((uint64)local_468 >> 32) / 1.5;
                local_3f8 = (float)local_468 / 1.5;
                local_3f0 = fStack_460 / 1.5;
                local_340 = fStack_460;
                uVar10 = String.Format("road0_{0}_0",this.backgroundType,0);
                local_338 = CONCAT44(fStack_3f4,local_3f8);
                local_330 = local_3f0;
                lVar17 = GlobalData.GenerateSkeletonAnimation
                                   (lVar6,"Skeleton/Explore/road0/skeleton_SkeletonData",&local_338,"idle",1,uVar10,0);
                if ((lVar17 == null) || (uVar10 = Component.get_gameObject(lVar17,0), lVar15 == null))
                throw; // [null/range check failed]
                *(uint64 *)(lVar15 + 32) = uVar10;
                lVar15 = GameObject.GetComponent(lVar6,DAT_181d9f5d0);
                if ((lVar15 == null) || (*(int64 *)(lVar15 + 32) == 0)) throw; // [null/range check failed]
                lVar17 = GameObject.get_transform(*(int64 *)(lVar15 + 32),0);
                puVar5 = (uint64 *)Quaternion.Euler(local_168);
              }
              if (lVar17 == null) throw; // [null/range check failed]
            }
            local_468 = *puVar5;
            fStack_460 = *(float *)(puVar5 + 1);
            uStack_45c = *(uint32 *)((int64)puVar5 + 12);
            Transform.set_rotation(lVar17,&local_468);
          }
        LAB_18093efc0:
          lVar15 = GameObject.GetComponent(lVar6,DAT_181d9f5d0);
          if (((lVar15 == null) || (*(int64 *)(lVar15 + 32) == 0)) ||
             (lVar15 = GameObject.get_transform(*(int64 *)(lVar15 + 32),0)) == null)
          throw; // [null/range check failed]
          local_418 = 0;
          local_410 = 0xbd4ccccd;
          Transform.set_localPosition(lVar15,&local_418);
        LAB_18093f016:
          lVar15 = FUN_180fa1260(lVar6,0);
          if (lVar15 == null) throw; // [null/range check failed]
          GameObject.SetActive(lVar15,1);
          lVar15 = GameObject.GetComponent(lVar6,DAT_181d9f5d0);
          if (*(int *)(lVar4 + 56) < 0) {
        LAB_18093f07c:
            uVar10 = 0;
          }
          else {
            if ((this.ExploreTileTypeDataBase == null) || (lVar17 = FUN_180002f80()) == null)
            throw; // [null/range check failed]
            if (*(char *)(lVar17 + 24) == false) goto LAB_18093f07c;
            uVar10 = 1;
          }
          if (lVar15 == null) throw; // [null/range check failed]
          ExploreTileUnitController.set_Seen(lVar15,uVar10);
          lVar15 = GameObject.GetComponent(lVar6,DAT_181d9f5d0);
          if (lVar15 == null) throw; // [null/range check failed]
          ExploreTileUnitController.set_Been(lVar15,0);
          lVar15 = GameObject.GetComponent(lVar6,DAT_181d9f5d0);
          if (lVar15 == null) throw; // [null/range check failed]
          ExploreTileUnitController.set_FinalTile(lVar15,*(int *)(lVar4 + 56) == -1);
          if (*(int *)(lVar4 + 56) == -1) {
            this.finalGrid = lVar6;
            if (*(char *)(targetExplorePanelData + 84) != false) {
              lVar4 = GameObject.GetComponent(lVar6,DAT_181d9f5d0);
              if (lVar4 == null) throw; // [null/range check failed]
              ExploreTileUnitController.set_Seen(lVar4,1,0);
            }
            lVar4 = GameObject.get_transform(lVar6,0);
            if ((lVar4 == null) || (lVar4 = Transform.Find(lVar4,"ExploreEvent",0)) == null)
            throw; // [null/range check failed]
            lVar6 = Component.GetComponent(lVar4,DAT_181d6d540);
            lVar15 = FUN_18046c6c0(0);
          }
          else {
            if (*(int *)(lVar4 + 56) < 1) {
              if (*(int64 *)(lVar4 + 80) == 0) goto LAB_18093f319;
              lVar6 = GameObject.get_transform(lVar6,0);
              if ((lVar6 == null) || (lVar6 = Transform.Find(lVar6,"ExploreEvent",0)) == null)
              throw; // [null/range check failed]
              lVar6 = Component.GetComponent(lVar6,DAT_181d6d540);
              lVar15 = FUN_18046c6c0(0);
              if ((*(int64 *)(lVar4 + 80) == 0) || (*pStatics_0c98 == 0))
              throw; // [null/range check failed]
              uVar10 = FUN_180002f80(*pStatics_0c98,
                                     *(uint32 *)(*(int64 *)(lVar4 + 80) + 16),DAT_181d7c9c0);
            }
            else {
              lVar6 = GameObject.get_transform(lVar6,0);
              if ((lVar6 == null) || (lVar6 = Transform.Find(lVar6,"ExploreEvent",0)) == null)
              throw; // [null/range check failed]
              lVar6 = Component.GetComponent(lVar6,DAT_181d6d540);
              lVar15 = FUN_18046c6c0(0);
              if ((this.ExploreTileTypeDataBase == null) ||
                 (lVar4 = FUN_180002f80(this.ExploreTileTypeDataBase,*(uint32 *)(lVar4 + 56),
                                        DAT_181d5ff78), lVar4 == null)) throw; // [null/range check failed]
              uVar10 = lVar4._items;
            }
            String.Concat("探索_",uVar10,0);
          }
          if ((lVar15 == null) ||
             (uVar10 = TextureController.LoadAtlasSprite(lVar15,"TileAtlas"), lVar6 == null))
          throw; // [null/range check failed]
          SpriteRenderer.set_sprite(lVar6,uVar10);
          uVar2 = local_458 + 1;
          goto LAB_18093da53;
        }
        goto LAB_18093f32d;
        LAB_18093f324:
        uVar14 = uVar14 + 1;
        goto LAB_18093da41;
        LAB_18093f32d:
        uVar10 = this.playerSkeleton;
        cVar3 = Object.op_Equality(uVar10,0,0);
        if (!cVar3) {
          lVar4 = FUN_18046c0a0(0);
          if (((lVar4 == null) || (*(int64 *)(lVar4 + 32) == 0)) ||
             (lVar4 = WorldData.Player(*(int64 *)(lVar4 + 32),0)) == null) throw; // [null/range check failed]
          HeroData.RefreshHeroSkeleton(lVar4,this.playerSkeleton,0);
        }
        else {
          lVar4 = FUN_18046c0a0(0);
          if ((lVar4 == null) || (*(int64 *)(lVar4 + 32) == 0)) throw; // [null/range check failed]
          lVar4 = WorldData.Player(*(int64 *)(lVar4 + 32),0);
          uVar10 = this.playerIcon;
          puVar5 = (uint64 *)Vector3.get_one(local_238,0);
          if (lVar4 == null) throw; // [null/range check failed]
          local_420 = *(float *)(puVar5 + 1);
          local_428 = *puVar5;
          uVar10 = HeroData.GenerateHeroSkeleton(lVar4,uVar10,&local_428,0);
          this.playerSkeleton = uVar10;
          if ((this.playerIcon == null) ||
             (lVar4 = GameObject.AddComponent(this.playerIcon,DAT_181d9c4f0)) == null)
          throw; // [null/range check failed]
          FootStepController.Init(lVar4,this.playerSkeleton,0);
        }
        if (this.playerSkeleton != null) {
          lVar4 = Component.get_transform(this.playerSkeleton,0);
          puVar5 = (uint64 *)Vector3.get_one(local_238,0);
          if (*(int *)(targetExplorePanelData + 16) == 1) {
            local_440 = 0.3;
          }
          else {
            local_440 = 0.25;
          }
          local_428 = *puVar5;
          local_420 = *(float *)(puVar5 + 1);
          fStack_444 = (float)((uint64)local_428 >> 32) * local_440;
          local_448 = (float)local_428 * local_440;
          local_440 = local_420 * local_440;
          if (lVar4 != null) {
            local_428 = CONCAT44(fStack_444,local_448);
            local_420 = local_440;
            Transform.set_localScale(lVar4,&local_428,0);
            if (this.explorePanelData != null) {
              lVar4 = this.explorePanelData.startTile;
              if (lVar4 == null) {
                uVar18 = 0;
                uVar13 = 0;
              }
              else {
                uVar18 = *(uint32 *)(lVar4 + 32);
                uVar13 = *(uint32 *)(lVar4 + 36);
              }
              ExploreController.PlayerEnterGrid(this,uVar13,uVar18,1,0);
              if (this.explorePanelData != null) {
                if (this.explorePanelData.exploreType == 1) {
                  if (this.playerSkeleton == null) throw; // [null/range check failed]
                  lVar4 = SkeletonAnimation.get_AnimationState(this.playerSkeleton,0);
                  local_438[0] = FUN_180d8cf10(0,4);
                  uVar10 = Int32.ToString(local_438,0);
                  uVar10 = String.Concat("entrance_",uVar10,0);
                  if (lVar4 == null) throw; // [null/range check failed]
                  AnimationState.SetAnimation(lVar4,1,uVar10,0,0);
                  if ((this.playerSkeleton == null) ||
                     (lVar4 = SkeletonAnimation.get_AnimationState(this.playerSkeleton,0),
                     lVar4 == null)) throw; // [null/range check failed]
                  AnimationState.AddEmptyAnimation(lVar4,1);
                }
                if (*(int *)(targetExplorePanelData + 16) == 0) {
                  lVar4 = this.gridPool;
                  if (lVar4 != null) {
                    lVar6 = 32;
                    while( true ) {
                      if (lVar4.Count <= (int)uVar19) {
                        return;
                      }
                      if (lVar4 == null) break;
                      if (lVar4.Count <= uVar19) {
                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                      }
                      lVar4 = *(int64 *)(lVar6 + lVar4._items);
                      if (((lVar4 == null) ||
                          (lVar4 = GameObject.GetComponent(lVar4,DAT_181d9f5d0)) == null) ||
                         (lVar4.Count == null)) break;
                      if (*(int *)(lVar4.Count + 72) == 0) {
                        if (((this.gridPool == null) ||
                            (lVar4 = FUN_180002f80(this.gridPool,uVar19,DAT_181d62178),
                            lVar4 == null)) ||
                           (lVar4 = GameObject.GetComponent(lVar4,DAT_181d9f5d0)) == null) break;
                        ExploreTileUnitController.set_Seen(lVar4,1,0);
                      }
                      lVar4 = this.gridPool;
                      uVar19 = uVar19 + 1;
                      lVar6 = lVar6 + 8;
                      if (lVar4 == null) break;
                    }
                  }
                }
                else {
                  if (*(int *)(targetExplorePanelData + 16) != 1) {
                    return;
                  }
                  lVar4 = this.gridPool;
                  if (lVar4 != null) {
                    uVar19 = lVar4.Count;
                    if (uVar19 <= uVar19 - 1) {
                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                    }
                    lVar4 = *(int64 *)(lVar4._items + 24 + (int64)(int)uVar19 * 8);
                    if ((lVar4 != null) &&
                       (lVar4 = GameObject.GetComponent(lVar4,DAT_181d9f5d0)) != null) {
                      ExploreTileUnitController.set_Seen(lVar4,1,0);
                      return;
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x60013E8
    // RVA   : 0x946F90   Offset: 0x945790   Length: 0xD5
    public void SeeAllTile()
    {
        long lVar1;
        long lVar2;
        uint uVar3;
        lVar1 = this.gridPool;
        uVar3 = 0;
        if (lVar1 != null) {
          lVar2 = 32;
          while( true ) {
            if (lVar1.Count <= (int)uVar3) {
              return;
            }
            if (lVar1 == null) break;
            if (lVar1.Count <= uVar3) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar1 = *(int64 *)(lVar2 + lVar1._items);
            if ((lVar1 == null) || (lVar1 = GameObject.GetComponent(lVar1,DAT_181d9f5d0)) == null)
            break;
            ExploreTileUnitController.set_Seen(lVar1,1,0);
            lVar1 = this.gridPool;
            uVar3 = uVar3 + 1;
            lVar2 = lVar2 + 8;
            if (lVar1 == null) break;
          }
        }
    }

    // Token : 0x60013E9
    // RVA   : 0x940460   Offset: 0x93EC60   Length: 0x46B
    public void ManageMoveStepLimit()
    {
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        var pStatics_ef00 = *(int64*)(DAT_181d4ef00 + 184);
        long lVar1;
        ulong uVar2;
        ulong uVar3;
        long lVar4;
        float fVar5;
        float[] local_res8 = new float[2];
        ulong uVar6;
        ulong in_stack_ffffffffffffffb0;
        uint uVar8;
        ulong uVar7;
        ulong in_stack_ffffffffffffffb8;
        uint uVar9;
        ulong local_28;
        ulong uStack_20;
        uVar8 = (uint32)((uint64)in_stack_ffffffffffffffb0 >> 32);
        uVar9 = (uint32)((uint64)in_stack_ffffffffffffffb8 >> 32);
        if (-1 < this.leftPower) {
          return;
        }
        fVar5 = (float)this.leftPower * 0.05;
        lVar4 = **(int64 **)(DAT_181d5a578 + 184);
        if (((*pStatics_df90 != 0) &&
            (lVar1 = *(int64 *)(*pStatics_df90 + 32)) != null) &&
           (lVar1 = WorldData.Player(lVar1,0)) != null) {
          uVar3 = *(uint64 *)(lVar1 + 104);
          local_res8[0] = fVar5 * 100.0;
          uVar2 = il2cpp_value_box(DAT_181d7d0b8,local_res8);
          uVar3 = String.Format("{0}精疲力尽，状态下降{1}%",uVar3,uVar2,0);
          if (lVar4 != null) {
            local_28 = *(uint64 *)(pStatics_ef00 + 0x2e8);
            uStack_20 = *(uint64 *)(pStatics_ef00 + 0x2f0);
            uVar7 = CONCAT44(uVar8,0x3f800000);
            uVar2 = "StateDown";
            InfoController.AddInfoTab
                      (lVar4,uVar3,"UIAtlas","从事工作_闲逛","StateDown",uVar7,
                       CONCAT44(uVar9,0x40a00000),&local_28,0);
            if ((*pStatics_df90 != 0) &&
               (lVar4 = *(int64 *)(*pStatics_df90 + 32)) != null) {
              lVar4 = WorldData.Player(lVar4,0);
              if ((((*pStatics_df90 != 0) &&
                   (lVar1 = *(int64 *)(*pStatics_df90 + 32)) != null) &&
                  (lVar1 = WorldData.Player(lVar1,0)) != null) && (lVar4 != null)) {
                uVar6 = CONCAT71((int7)((uint64)uVar2 >> 8),1);
                HeroData.ChangeHp(lVar4,fVar5 * *(float *)(lVar1 + 0x17c),1,0,uVar6,
                                   uVar7 & 0xffffffffffffff00,0);
                if ((*pStatics_df90 != 0) &&
                   (lVar4 = *(int64 *)(*pStatics_df90 + 32)) != null) {
                  lVar4 = WorldData.Player(lVar4,0);
                  if ((((*pStatics_df90 != 0) &&
                       (lVar1 = *(int64 *)(*pStatics_df90 + 32)) != null)
                      && (lVar1 = WorldData.Player(lVar1,0)) != null) && (lVar4 != null)) {
                    HeroData.ChangeMana
                              (lVar4,fVar5 * *(float *)(lVar1 + 0x194),1,1,uVar6 & 0xffffffffffffff00,0);
                    return;
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x60013EA
    // RVA   : 0x946300   Offset: 0x944B00   Length: 0x2C
    public void PlayerEnterGrid(ExploreTileData exploreTileData, bool quickEnter)
    {
        var pStatics = *(int64*)(DAT_181d8b128 + 184);
        ulong uVar2;
        float fVar3;
        long lVar4;
        bool cVar5;
        long lVar6;
        long lVar8;
        ulong uVar9;
        ulong uVar11;
        uint uVar12;
        uint uVar13;
        uint uVar14;
        float local_68;
        float fStack_64;
        ulong local_58;
        ulong local_48;
        float local_40;
        ulong local_38;
        float fStack_30;
        uint32 uStack_2c;
        lVar6 = this.playerGrid;
        cVar5 = Object.op_Inequality(lVar6,0,0);
        if (cVar5) {
          fVar3 = local_40;
          if (((*plVar1 == 0) ||
              (lVar6 = GameObject.GetComponent(*plVar1,DAT_181d9f5d0), fVar3 = local_40) == null) ||
             (lVar6.Count == null)) goto LAB_180946230;
          if (*(int *)(lVar6.Count + 36) < (int)exploreTileData) {
            if (this.playerSkeleton == null) goto LAB_180946230;
            lVar6 = Component.get_transform(this.playerSkeleton,0);
            puVar7 = (uint32 *)Quaternion.get_identity(&local_38,0);
            fVar3 = local_40;
            if (lVar6 == null) goto LAB_180946230;
            uVar13 = *puVar7;
            uVar14 = puVar7[1];
            fStack_30 = (float)puVar7[2];
            uStack_2c = puVar7[3];
        LAB_180945b2d:
            local_38 = CONCAT44(uVar14,uVar13);
            Transform.set_localRotation(lVar6,&local_38,0);
          }
          else {
            if (((*plVar1 == 0) ||
                (lVar6 = GameObject.GetComponent(*plVar1,DAT_181d9f5d0), fVar3 = local_40) == null)
               || (lVar6.Count == null)) goto LAB_180946230;
            if ((int)exploreTileData < *(int *)(lVar6.Count + 36)) {
              if (this.playerSkeleton == null) goto LAB_180946230;
              lVar6 = Component.get_transform(this.playerSkeleton,0);
              lVar8 = *(int64 *)(DAT_181d4ef00 + 184);
              fVar3 = local_40;
              if (lVar6 == null) goto LAB_180946230;
              uVar13 = *(uint32 *)(lVar8 + 0x688);
              uVar14 = *(uint32 *)(lVar8 + 0x68c);
              fStack_30 = *(float *)(lVar8 + 0x690);
              uStack_2c = *(uint32 *)(lVar8 + 0x694);
              goto LAB_180945b2d;
            }
          }
          fVar3 = local_40;
          if (((*plVar1 == 0) ||
              (lVar6 = GameObject.GetComponent(*plVar1,DAT_181d9f5d0), fVar3 = local_40) == null) ||
             (lVar6.Count == null)) goto LAB_180946230;
          if (0 < *(int *)(lVar6.Count + 32)) {
            lVar6 = this.gridUnits;
            if (((*plVar1 == 0) ||
                (lVar8 = GameObject.GetComponent(*plVar1,DAT_181d9f5d0), fVar3 = local_40) == null)
               || (*(int64 *)(lVar8 + 24) == 0)) goto LAB_180946230;
            uVar12 = *(uint32 *)(*(int64 *)(lVar8 + 24) + 36);
            if (((*plVar1 == 0) ||
                (lVar8 = GameObject.GetComponent(*plVar1,DAT_181d9f5d0), fVar3 = local_40) == null)
               || ((*(int64 *)(lVar8 + 24) == 0 || (lVar6 == null)))) goto LAB_180946230;
            lVar8 = (int64)*(int *)(*(int64 *)(lVar8 + 24) + 32) + -1;
            if (*lVar6._items <= uVar12) {
              uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar9,0);
            }
            lVar4 = *(int64 *)(lVar6._items + 4);
            if ((uint32)lVar4 <= (uint32)lVar8) {
              uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar9,0);
            }
            lVar6 = *(int64 *)(lVar6 + 32 + ((int)uVar12 * lVar4 + lVar8) * 8);
            if ((lVar6 == null) ||
               (lVar6 = GameObject.GetComponent(lVar6,DAT_181d9f5d0), fVar3 = local_40) == null)
            goto LAB_180946230;
            *(uint8 *)(lVar6 + 58) = 1;
          }
        }
        lVar6 = this.gridUnits;
        fVar3 = local_40;
        if (lVar6 == null) goto LAB_180946230;
        if (*lVar6._items <= exploreTileData) {
          uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar9,0);
        }
        lVar8 = *(int64 *)(lVar6._items + 4);
        if ((uint32)lVar8 <= quickEnter) {
          uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar9,0);
        }
        *plVar1 = *(int64 *)(lVar6 + 32 + (lVar8 * (int)exploreTileData + (int64)(int)quickEnter) * 8);
        il2cpp_internal(plVar1);
        if (0 < (int)quickEnter) {
          lVar6 = this.gridUnits;
          fVar3 = local_40;
          if (lVar6 == null) goto LAB_180946230;
          lVar8 = (int64)(int)quickEnter + -1;
          if (*lVar6._items <= exploreTileData) {
            uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar9,0);
          }
          lVar4 = *(int64 *)(lVar6._items + 4);
          if ((uint32)lVar4 <= (uint32)lVar8) {
            uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar9,0);
          }
          lVar6 = *(int64 *)(lVar6 + 32 + (lVar4 * (int)exploreTileData + lVar8) * 8);
          if ((lVar6 == null) ||
             (lVar6 = GameObject.GetComponent(lVar6,DAT_181d9f5d0), fVar3 = local_40) == null)
          goto LAB_180946230;
          *(uint8 *)(lVar6 + 58) = 1;
        }
        fVar3 = local_40;
        if (!param_4) {
          if (this.playerSkeleton == null) goto LAB_180946230;
          lVar6 = SkeletonAnimation.get_AnimationState(this.playerSkeleton,0);
          fVar3 = local_40;
          if (this.explorePanelData == null) goto LAB_180946230;
          uVar9 = "walk";
          if (this.explorePanelData.exploreType != 1) {
            lVar8 = FUN_18046c0a0(0);
            fVar3 = local_40;
            if (((lVar8 == null) || (*(int64 *)(lVar8 + 32) == 0)) ||
               (lVar8 = WorldData.Player(*(int64 *)(lVar8 + 32),0), fVar3 = local_40) == null)
            goto LAB_180946230;
            uVar9 = HeroData.GetSkeletonHorseWalkAnim(lVar8,0);
          }
          fVar3 = local_40;
          if (lVar6 == null) goto LAB_180946230;
          AnimationState.SetAnimation(lVar6,0,uVar9,1,0);
          fVar3 = local_40;
          if (this.playerSkeleton == null) goto LAB_180946230;
          *(uint32 *)(this.playerSkeleton + 300) = 0x40800000;
        }
        else {
          if (this.playerIcon == null) goto LAB_180946230;
          lVar6 = GameObject.get_transform(this.playerIcon,0);
          fVar3 = local_40;
          if ((*plVar1 == 0) ||
             (lVar8 = GameObject.get_transform(*plVar1,0), fVar3 = local_40) == null)
          goto LAB_180946230;
          puVar10 = (uint64 *)Transform.get_localPosition(&local_38,lVar8,0);
          uVar9 = *puVar10;
          local_40 = *(float *)(puVar10 + 1);
          local_68 = (float)uVar9;
          fStack_64 = (float)((uint64)uVar9 >> 32);
          local_38 = *(uint64 *)(pStatics + 28);
          fStack_30 = *(float *)(pStatics + 36);
          local_40 = local_40 + fStack_30;
          local_58 = CONCAT44(fStack_64 + (float)((uint64)local_38 >> 32),local_68 + (float)local_38)
          ;
          local_48 = local_38;
          fVar3 = fStack_30;
          if (lVar6 == null) goto LAB_180946230;
          local_48 = local_58;
          Transform.set_localPosition(lVar6,&local_48,0);
          fVar3 = local_40;
          if (this.playerSkeleton == null) goto LAB_180946230;
          lVar6 = SkeletonAnimation.get_AnimationState(this.playerSkeleton,0);
          fVar3 = local_40;
          if (this.explorePanelData == null) goto LAB_180946230;
          uVar9 = "idle";
          if (this.explorePanelData.exploreType != 1) {
            lVar8 = FUN_18046c0a0(0);
            fVar3 = local_40;
            if (((lVar8 == null) || (*(int64 *)(lVar8 + 32) == 0)) ||
               (lVar8 = WorldData.Player(*(int64 *)(lVar8 + 32),0), fVar3 = local_40) == null)
            goto LAB_180946230;
            uVar9 = HeroData.GetSkeletonHorseIdleAnim(lVar8,0);
          }
          fVar3 = local_40;
          if (lVar6 == null) goto LAB_180946230;
          AnimationState.SetAnimation(lVar6,0,uVar9,1,0);
          fVar3 = local_40;
          if (this.playerSkeleton == null) goto LAB_180946230;
          *(uint32 *)(this.playerSkeleton + 300) = 0x3f800000;
        }
        uVar12 = 0;
        fVar3 = local_40;
        if (this.playerIcon != null) {
          uVar9 = GameObject.get_transform(this.playerIcon,0);
          fVar3 = local_40;
          if ((*plVar1 != 0) &&
             (lVar6 = GameObject.get_transform(*plVar1,0), fVar3 = local_40) != null) {
            puVar10 = (uint64 *)Transform.get_localPosition(&local_38,lVar6,0);
            uVar11 = *puVar10;
            fVar3 = *(float *)(puVar10 + 1);
            local_58._4_4_ = (float)((uint64)uVar11 >> 32);
            uVar2 = *(uint64 *)(pStatics + 28);
            local_58._0_4_ = (float)uVar11;
            local_40 = fVar3 + *(float *)(pStatics + 36);
            local_48 = CONCAT44(local_58._4_4_ + (float)((uint64)uVar2 >> 32),
                                (float)uVar2 + (float)local_58);
            fStack_30 = local_40;
            uVar9 = ShortcutExtensions.DOLocalMove(uVar9,&local_48,0x3f000000,0,0);
            uVar11 = new OnTooltipCB(this,DAT_181d91968,0);
            uVar9 = TweenSettingsExtensions.OnComplete(uVar9,uVar11,DAT_181d96ee8);
            TweenSettingsExtensions.SetUpdate(uVar9,1,DAT_181d98af0);
            fVar3 = local_40;
            if ((*plVar1 != 0) &&
               (lVar6 = GameObject.get_transform(*plVar1,0), fVar3 = local_40) != null) {
              puVar10 = (uint64 *)Transform.get_localPosition(&local_48,lVar6,0);
              uVar9 = *puVar10;
              lVar6 = this.gridPool;
              this.tweenFocusTarget = (int)uVar9;
              *(int *)(this + 0x100) = (int)((uint64)uVar9 >> 32);
              fVar3 = local_40;
              if (lVar6 != null) {
                lVar8 = 32;
                while( true ) {
                  if (lVar6.Count <= (int)uVar12) {
                    return;
                  }
                  fVar3 = local_40;
                  if (lVar6 == null) break;
                  if (lVar6.Count <= uVar12) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  lVar6 = *(int64 *)(lVar8 + lVar6._items);
                  fVar3 = local_40;
                  if ((lVar6 == null) ||
                     (lVar6 = GameObject.GetComponent(lVar6,DAT_181d9f5d0), fVar3 = local_40) == null
                     ) break;
                  cVar5 = ExploreTileUnitController.get_MoveAble(lVar6,0);
                  if (cVar5) {
                    fVar3 = local_40;
                    if (((this.gridPool == null) ||
                        (lVar6 = FUN_180002f80(this.gridPool,uVar12,DAT_181d62178),
                        fVar3 = local_40, lVar6 == null)) ||
                       (lVar6 = GameObject.GetComponent(lVar6,DAT_181d9f5d0), fVar3 = local_40,
                       lVar6 == null)) break;
                    ExploreTileUnitController.set_MoveAble(lVar6,0,0);
                  }
                  lVar6 = this.gridPool;
                  uVar12 = uVar12 + 1;
                  lVar8 = lVar8 + 8;
                  fVar3 = local_40;
                  if (lVar6 == null) break;
                }
              }
            }
          }
        }
        LAB_180946230:
        local_40 = fVar3;
    }

    // Token : 0x60013EB
    // RVA   : 0x946240   Offset: 0x944A40   Length: 0xB1
    public void PlayerEnterGrid(GameObject targetGrid, bool quickEnter)
    {
        var pStatics = *(int64*)(DAT_181d8b128 + 184);
        ulong uVar2;
        float fVar3;
        long lVar4;
        bool cVar5;
        long lVar6;
        long lVar8;
        ulong uVar9;
        ulong uVar11;
        uint uVar12;
        uint uVar13;
        uint uVar14;
        float local_68;
        float fStack_64;
        ulong local_58;
        ulong local_48;
        float local_40;
        ulong local_38;
        float fStack_30;
        uint32 uStack_2c;
        lVar6 = this.playerGrid;
        cVar5 = Object.op_Inequality(lVar6,0,0);
        if (cVar5) {
          fVar3 = local_40;
          if (((*plVar1 == 0) ||
              (lVar6 = GameObject.GetComponent(*plVar1,DAT_181d9f5d0), fVar3 = local_40) == null) ||
             (lVar6.Count == null)) goto LAB_180946230;
          if (*(int *)(lVar6.Count + 36) < (int)targetGrid) {
            if (this.playerSkeleton == null) goto LAB_180946230;
            lVar6 = Component.get_transform(this.playerSkeleton,0);
            puVar7 = (uint32 *)Quaternion.get_identity(&local_38,0);
            fVar3 = local_40;
            if (lVar6 == null) goto LAB_180946230;
            uVar13 = *puVar7;
            uVar14 = puVar7[1];
            fStack_30 = (float)puVar7[2];
            uStack_2c = puVar7[3];
        LAB_180945b2d:
            local_38 = CONCAT44(uVar14,uVar13);
            Transform.set_localRotation(lVar6,&local_38,0);
          }
          else {
            if (((*plVar1 == 0) ||
                (lVar6 = GameObject.GetComponent(*plVar1,DAT_181d9f5d0), fVar3 = local_40) == null)
               || (lVar6.Count == null)) goto LAB_180946230;
            if ((int)targetGrid < *(int *)(lVar6.Count + 36)) {
              if (this.playerSkeleton == null) goto LAB_180946230;
              lVar6 = Component.get_transform(this.playerSkeleton,0);
              lVar8 = *(int64 *)(DAT_181d4ef00 + 184);
              fVar3 = local_40;
              if (lVar6 == null) goto LAB_180946230;
              uVar13 = *(uint32 *)(lVar8 + 0x688);
              uVar14 = *(uint32 *)(lVar8 + 0x68c);
              fStack_30 = *(float *)(lVar8 + 0x690);
              uStack_2c = *(uint32 *)(lVar8 + 0x694);
              goto LAB_180945b2d;
            }
          }
          fVar3 = local_40;
          if (((*plVar1 == 0) ||
              (lVar6 = GameObject.GetComponent(*plVar1,DAT_181d9f5d0), fVar3 = local_40) == null) ||
             (lVar6.Count == null)) goto LAB_180946230;
          if (0 < *(int *)(lVar6.Count + 32)) {
            lVar6 = this.gridUnits;
            if (((*plVar1 == 0) ||
                (lVar8 = GameObject.GetComponent(*plVar1,DAT_181d9f5d0), fVar3 = local_40) == null)
               || (*(int64 *)(lVar8 + 24) == 0)) goto LAB_180946230;
            uVar12 = *(uint32 *)(*(int64 *)(lVar8 + 24) + 36);
            if (((*plVar1 == 0) ||
                (lVar8 = GameObject.GetComponent(*plVar1,DAT_181d9f5d0), fVar3 = local_40) == null)
               || ((*(int64 *)(lVar8 + 24) == 0 || (lVar6 == null)))) goto LAB_180946230;
            lVar8 = (int64)*(int *)(*(int64 *)(lVar8 + 24) + 32) + -1;
            if (*lVar6._items <= uVar12) {
              uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar9,0);
            }
            lVar4 = *(int64 *)(lVar6._items + 4);
            if ((uint32)lVar4 <= (uint32)lVar8) {
              uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar9,0);
            }
            lVar6 = *(int64 *)(lVar6 + 32 + ((int)uVar12 * lVar4 + lVar8) * 8);
            if ((lVar6 == null) ||
               (lVar6 = GameObject.GetComponent(lVar6,DAT_181d9f5d0), fVar3 = local_40) == null)
            goto LAB_180946230;
            *(uint8 *)(lVar6 + 58) = 1;
          }
        }
        lVar6 = this.gridUnits;
        fVar3 = local_40;
        if (lVar6 == null) goto LAB_180946230;
        if (*lVar6._items <= targetGrid) {
          uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar9,0);
        }
        lVar8 = *(int64 *)(lVar6._items + 4);
        if ((uint32)lVar8 <= quickEnter) {
          uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar9,0);
        }
        *plVar1 = *(int64 *)(lVar6 + 32 + (lVar8 * (int)targetGrid + (int64)(int)quickEnter) * 8);
        il2cpp_internal(plVar1);
        if (0 < (int)quickEnter) {
          lVar6 = this.gridUnits;
          fVar3 = local_40;
          if (lVar6 == null) goto LAB_180946230;
          lVar8 = (int64)(int)quickEnter + -1;
          if (*lVar6._items <= targetGrid) {
            uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar9,0);
          }
          lVar4 = *(int64 *)(lVar6._items + 4);
          if ((uint32)lVar4 <= (uint32)lVar8) {
            uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar9,0);
          }
          lVar6 = *(int64 *)(lVar6 + 32 + (lVar4 * (int)targetGrid + lVar8) * 8);
          if ((lVar6 == null) ||
             (lVar6 = GameObject.GetComponent(lVar6,DAT_181d9f5d0), fVar3 = local_40) == null)
          goto LAB_180946230;
          *(uint8 *)(lVar6 + 58) = 1;
        }
        fVar3 = local_40;
        if (!param_4) {
          if (this.playerSkeleton == null) goto LAB_180946230;
          lVar6 = SkeletonAnimation.get_AnimationState(this.playerSkeleton,0);
          fVar3 = local_40;
          if (this.explorePanelData == null) goto LAB_180946230;
          uVar9 = "walk";
          if (this.explorePanelData.exploreType != 1) {
            lVar8 = FUN_18046c0a0(0);
            fVar3 = local_40;
            if (((lVar8 == null) || (*(int64 *)(lVar8 + 32) == 0)) ||
               (lVar8 = WorldData.Player(*(int64 *)(lVar8 + 32),0), fVar3 = local_40) == null)
            goto LAB_180946230;
            uVar9 = HeroData.GetSkeletonHorseWalkAnim(lVar8,0);
          }
          fVar3 = local_40;
          if (lVar6 == null) goto LAB_180946230;
          AnimationState.SetAnimation(lVar6,0,uVar9,1,0);
          fVar3 = local_40;
          if (this.playerSkeleton == null) goto LAB_180946230;
          *(uint32 *)(this.playerSkeleton + 300) = 0x40800000;
        }
        else {
          if (this.playerIcon == null) goto LAB_180946230;
          lVar6 = GameObject.get_transform(this.playerIcon,0);
          fVar3 = local_40;
          if ((*plVar1 == 0) ||
             (lVar8 = GameObject.get_transform(*plVar1,0), fVar3 = local_40) == null)
          goto LAB_180946230;
          puVar10 = (uint64 *)Transform.get_localPosition(&local_38,lVar8,0);
          uVar9 = *puVar10;
          local_40 = *(float *)(puVar10 + 1);
          local_68 = (float)uVar9;
          fStack_64 = (float)((uint64)uVar9 >> 32);
          local_38 = *(uint64 *)(pStatics + 28);
          fStack_30 = *(float *)(pStatics + 36);
          local_40 = local_40 + fStack_30;
          local_58 = CONCAT44(fStack_64 + (float)((uint64)local_38 >> 32),local_68 + (float)local_38)
          ;
          local_48 = local_38;
          fVar3 = fStack_30;
          if (lVar6 == null) goto LAB_180946230;
          local_48 = local_58;
          Transform.set_localPosition(lVar6,&local_48,0);
          fVar3 = local_40;
          if (this.playerSkeleton == null) goto LAB_180946230;
          lVar6 = SkeletonAnimation.get_AnimationState(this.playerSkeleton,0);
          fVar3 = local_40;
          if (this.explorePanelData == null) goto LAB_180946230;
          uVar9 = "idle";
          if (this.explorePanelData.exploreType != 1) {
            lVar8 = FUN_18046c0a0(0);
            fVar3 = local_40;
            if (((lVar8 == null) || (*(int64 *)(lVar8 + 32) == 0)) ||
               (lVar8 = WorldData.Player(*(int64 *)(lVar8 + 32),0), fVar3 = local_40) == null)
            goto LAB_180946230;
            uVar9 = HeroData.GetSkeletonHorseIdleAnim(lVar8,0);
          }
          fVar3 = local_40;
          if (lVar6 == null) goto LAB_180946230;
          AnimationState.SetAnimation(lVar6,0,uVar9,1,0);
          fVar3 = local_40;
          if (this.playerSkeleton == null) goto LAB_180946230;
          *(uint32 *)(this.playerSkeleton + 300) = 0x3f800000;
        }
        uVar12 = 0;
        fVar3 = local_40;
        if (this.playerIcon != null) {
          uVar9 = GameObject.get_transform(this.playerIcon,0);
          fVar3 = local_40;
          if ((*plVar1 != 0) &&
             (lVar6 = GameObject.get_transform(*plVar1,0), fVar3 = local_40) != null) {
            puVar10 = (uint64 *)Transform.get_localPosition(&local_38,lVar6,0);
            uVar11 = *puVar10;
            fVar3 = *(float *)(puVar10 + 1);
            local_58._4_4_ = (float)((uint64)uVar11 >> 32);
            uVar2 = *(uint64 *)(pStatics + 28);
            local_58._0_4_ = (float)uVar11;
            local_40 = fVar3 + *(float *)(pStatics + 36);
            local_48 = CONCAT44(local_58._4_4_ + (float)((uint64)uVar2 >> 32),
                                (float)uVar2 + (float)local_58);
            fStack_30 = local_40;
            uVar9 = ShortcutExtensions.DOLocalMove(uVar9,&local_48,0x3f000000,0,0);
            uVar11 = new OnTooltipCB(this,DAT_181d91968,0);
            uVar9 = TweenSettingsExtensions.OnComplete(uVar9,uVar11,DAT_181d96ee8);
            TweenSettingsExtensions.SetUpdate(uVar9,1,DAT_181d98af0);
            fVar3 = local_40;
            if ((*plVar1 != 0) &&
               (lVar6 = GameObject.get_transform(*plVar1,0), fVar3 = local_40) != null) {
              puVar10 = (uint64 *)Transform.get_localPosition(&local_48,lVar6,0);
              uVar9 = *puVar10;
              lVar6 = this.gridPool;
              this.tweenFocusTarget = (int)uVar9;
              *(int *)(this + 0x100) = (int)((uint64)uVar9 >> 32);
              fVar3 = local_40;
              if (lVar6 != null) {
                lVar8 = 32;
                while( true ) {
                  if (lVar6.Count <= (int)uVar12) {
                    return;
                  }
                  fVar3 = local_40;
                  if (lVar6 == null) break;
                  if (lVar6.Count <= uVar12) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  lVar6 = *(int64 *)(lVar8 + lVar6._items);
                  fVar3 = local_40;
                  if ((lVar6 == null) ||
                     (lVar6 = GameObject.GetComponent(lVar6,DAT_181d9f5d0), fVar3 = local_40) == null
                     ) break;
                  cVar5 = ExploreTileUnitController.get_MoveAble(lVar6,0);
                  if (cVar5) {
                    fVar3 = local_40;
                    if (((this.gridPool == null) ||
                        (lVar6 = FUN_180002f80(this.gridPool,uVar12,DAT_181d62178),
                        fVar3 = local_40, lVar6 == null)) ||
                       (lVar6 = GameObject.GetComponent(lVar6,DAT_181d9f5d0), fVar3 = local_40,
                       lVar6 == null)) break;
                    ExploreTileUnitController.set_MoveAble(lVar6,0,0);
                  }
                  lVar6 = this.gridPool;
                  uVar12 = uVar12 + 1;
                  lVar8 = lVar8 + 8;
                  fVar3 = local_40;
                  if (lVar6 == null) break;
                }
              }
            }
          }
        }
        LAB_180946230:
        local_40 = fVar3;
    }

    // Token : 0x60013EC
    // RVA   : 0x945920   Offset: 0x944120   Length: 0x915
    public void PlayerEnterGrid(int column, int row, bool quickEnter)
    {
        var pStatics = *(int64*)(DAT_181d8b128 + 184);
        ulong uVar2;
        float fVar3;
        long lVar4;
        bool cVar5;
        long lVar6;
        long lVar8;
        ulong uVar9;
        ulong uVar11;
        uint uVar12;
        uint uVar13;
        uint uVar14;
        float local_68;
        float fStack_64;
        ulong local_58;
        ulong local_48;
        float local_40;
        ulong local_38;
        float fStack_30;
        uint32 uStack_2c;
        lVar6 = this.playerGrid;
        cVar5 = Object.op_Inequality(lVar6,0,0);
        if (cVar5) {
          fVar3 = local_40;
          if (((*plVar1 == 0) ||
              (lVar6 = GameObject.GetComponent(*plVar1,DAT_181d9f5d0), fVar3 = local_40) == null) ||
             (lVar6.Count == null)) goto LAB_180946230;
          if (*(int *)(lVar6.Count + 36) < (int)column) {
            if (this.playerSkeleton == null) goto LAB_180946230;
            lVar6 = Component.get_transform(this.playerSkeleton,0);
            puVar7 = (uint32 *)Quaternion.get_identity(&local_38,0);
            fVar3 = local_40;
            if (lVar6 == null) goto LAB_180946230;
            uVar13 = *puVar7;
            uVar14 = puVar7[1];
            fStack_30 = (float)puVar7[2];
            uStack_2c = puVar7[3];
        LAB_180945b2d:
            local_38 = CONCAT44(uVar14,uVar13);
            Transform.set_localRotation(lVar6,&local_38,0);
          }
          else {
            if (((*plVar1 == 0) ||
                (lVar6 = GameObject.GetComponent(*plVar1,DAT_181d9f5d0), fVar3 = local_40) == null)
               || (lVar6.Count == null)) goto LAB_180946230;
            if ((int)column < *(int *)(lVar6.Count + 36)) {
              if (this.playerSkeleton == null) goto LAB_180946230;
              lVar6 = Component.get_transform(this.playerSkeleton,0);
              lVar8 = *(int64 *)(DAT_181d4ef00 + 184);
              fVar3 = local_40;
              if (lVar6 == null) goto LAB_180946230;
              uVar13 = *(uint32 *)(lVar8 + 0x688);
              uVar14 = *(uint32 *)(lVar8 + 0x68c);
              fStack_30 = *(float *)(lVar8 + 0x690);
              uStack_2c = *(uint32 *)(lVar8 + 0x694);
              goto LAB_180945b2d;
            }
          }
          fVar3 = local_40;
          if (((*plVar1 == 0) ||
              (lVar6 = GameObject.GetComponent(*plVar1,DAT_181d9f5d0), fVar3 = local_40) == null) ||
             (lVar6.Count == null)) goto LAB_180946230;
          if (0 < *(int *)(lVar6.Count + 32)) {
            lVar6 = this.gridUnits;
            if (((*plVar1 == 0) ||
                (lVar8 = GameObject.GetComponent(*plVar1,DAT_181d9f5d0), fVar3 = local_40) == null)
               || (*(int64 *)(lVar8 + 24) == 0)) goto LAB_180946230;
            uVar12 = *(uint32 *)(*(int64 *)(lVar8 + 24) + 36);
            if (((*plVar1 == 0) ||
                (lVar8 = GameObject.GetComponent(*plVar1,DAT_181d9f5d0), fVar3 = local_40) == null)
               || ((*(int64 *)(lVar8 + 24) == 0 || (lVar6 == null)))) goto LAB_180946230;
            lVar8 = (int64)*(int *)(*(int64 *)(lVar8 + 24) + 32) + -1;
            if (*lVar6._items <= uVar12) {
              uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar9,0);
            }
            lVar4 = *(int64 *)(lVar6._items + 4);
            if ((uint32)lVar4 <= (uint32)lVar8) {
              uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar9,0);
            }
            lVar6 = *(int64 *)(lVar6 + 32 + ((int)uVar12 * lVar4 + lVar8) * 8);
            if ((lVar6 == null) ||
               (lVar6 = GameObject.GetComponent(lVar6,DAT_181d9f5d0), fVar3 = local_40) == null)
            goto LAB_180946230;
            *(uint8 *)(lVar6 + 58) = 1;
          }
        }
        lVar6 = this.gridUnits;
        fVar3 = local_40;
        if (lVar6 == null) goto LAB_180946230;
        if (*lVar6._items <= column) {
          uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar9,0);
        }
        lVar8 = *(int64 *)(lVar6._items + 4);
        if ((uint32)lVar8 <= row) {
          uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar9,0);
        }
        *plVar1 = *(int64 *)(lVar6 + 32 + (lVar8 * (int)column + (int64)(int)row) * 8);
        il2cpp_internal(plVar1);
        if (0 < (int)row) {
          lVar6 = this.gridUnits;
          fVar3 = local_40;
          if (lVar6 == null) goto LAB_180946230;
          lVar8 = (int64)(int)row + -1;
          if (*lVar6._items <= column) {
            uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar9,0);
          }
          lVar4 = *(int64 *)(lVar6._items + 4);
          if ((uint32)lVar4 <= (uint32)lVar8) {
            uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar9,0);
          }
          lVar6 = *(int64 *)(lVar6 + 32 + (lVar4 * (int)column + lVar8) * 8);
          if ((lVar6 == null) ||
             (lVar6 = GameObject.GetComponent(lVar6,DAT_181d9f5d0), fVar3 = local_40) == null)
          goto LAB_180946230;
          *(uint8 *)(lVar6 + 58) = 1;
        }
        fVar3 = local_40;
        if (!quickEnter) {
          if (this.playerSkeleton == null) goto LAB_180946230;
          lVar6 = SkeletonAnimation.get_AnimationState(this.playerSkeleton,0);
          fVar3 = local_40;
          if (this.explorePanelData == null) goto LAB_180946230;
          uVar9 = "walk";
          if (this.explorePanelData.exploreType != 1) {
            lVar8 = FUN_18046c0a0(0);
            fVar3 = local_40;
            if (((lVar8 == null) || (*(int64 *)(lVar8 + 32) == 0)) ||
               (lVar8 = WorldData.Player(*(int64 *)(lVar8 + 32),0), fVar3 = local_40) == null)
            goto LAB_180946230;
            uVar9 = HeroData.GetSkeletonHorseWalkAnim(lVar8,0);
          }
          fVar3 = local_40;
          if (lVar6 == null) goto LAB_180946230;
          AnimationState.SetAnimation(lVar6,0,uVar9,1,0);
          fVar3 = local_40;
          if (this.playerSkeleton == null) goto LAB_180946230;
          *(uint32 *)(this.playerSkeleton + 300) = 0x40800000;
        }
        else {
          if (this.playerIcon == null) goto LAB_180946230;
          lVar6 = GameObject.get_transform(this.playerIcon,0);
          fVar3 = local_40;
          if ((*plVar1 == 0) ||
             (lVar8 = GameObject.get_transform(*plVar1,0), fVar3 = local_40) == null)
          goto LAB_180946230;
          puVar10 = (uint64 *)Transform.get_localPosition(&local_38,lVar8,0);
          uVar9 = *puVar10;
          local_40 = *(float *)(puVar10 + 1);
          local_68 = (float)uVar9;
          fStack_64 = (float)((uint64)uVar9 >> 32);
          local_38 = *(uint64 *)(pStatics + 28);
          fStack_30 = *(float *)(pStatics + 36);
          local_40 = local_40 + fStack_30;
          local_58 = CONCAT44(fStack_64 + (float)((uint64)local_38 >> 32),local_68 + (float)local_38)
          ;
          local_48 = local_38;
          fVar3 = fStack_30;
          if (lVar6 == null) goto LAB_180946230;
          local_48 = local_58;
          Transform.set_localPosition(lVar6,&local_48,0);
          fVar3 = local_40;
          if (this.playerSkeleton == null) goto LAB_180946230;
          lVar6 = SkeletonAnimation.get_AnimationState(this.playerSkeleton,0);
          fVar3 = local_40;
          if (this.explorePanelData == null) goto LAB_180946230;
          uVar9 = "idle";
          if (this.explorePanelData.exploreType != 1) {
            lVar8 = FUN_18046c0a0(0);
            fVar3 = local_40;
            if (((lVar8 == null) || (*(int64 *)(lVar8 + 32) == 0)) ||
               (lVar8 = WorldData.Player(*(int64 *)(lVar8 + 32),0), fVar3 = local_40) == null)
            goto LAB_180946230;
            uVar9 = HeroData.GetSkeletonHorseIdleAnim(lVar8,0);
          }
          fVar3 = local_40;
          if (lVar6 == null) goto LAB_180946230;
          AnimationState.SetAnimation(lVar6,0,uVar9,1,0);
          fVar3 = local_40;
          if (this.playerSkeleton == null) goto LAB_180946230;
          *(uint32 *)(this.playerSkeleton + 300) = 0x3f800000;
        }
        uVar12 = 0;
        fVar3 = local_40;
        if (this.playerIcon != null) {
          uVar9 = GameObject.get_transform(this.playerIcon,0);
          fVar3 = local_40;
          if ((*plVar1 != 0) &&
             (lVar6 = GameObject.get_transform(*plVar1,0), fVar3 = local_40) != null) {
            puVar10 = (uint64 *)Transform.get_localPosition(&local_38,lVar6,0);
            uVar11 = *puVar10;
            fVar3 = *(float *)(puVar10 + 1);
            local_58._4_4_ = (float)((uint64)uVar11 >> 32);
            uVar2 = *(uint64 *)(pStatics + 28);
            local_58._0_4_ = (float)uVar11;
            local_40 = fVar3 + *(float *)(pStatics + 36);
            local_48 = CONCAT44(local_58._4_4_ + (float)((uint64)uVar2 >> 32),
                                (float)uVar2 + (float)local_58);
            fStack_30 = local_40;
            uVar9 = ShortcutExtensions.DOLocalMove(uVar9,&local_48,0x3f000000,0,0);
            uVar11 = new OnTooltipCB(this,DAT_181d91968,0);
            uVar9 = TweenSettingsExtensions.OnComplete(uVar9,uVar11,DAT_181d96ee8);
            TweenSettingsExtensions.SetUpdate(uVar9,1,DAT_181d98af0);
            fVar3 = local_40;
            if ((*plVar1 != 0) &&
               (lVar6 = GameObject.get_transform(*plVar1,0), fVar3 = local_40) != null) {
              puVar10 = (uint64 *)Transform.get_localPosition(&local_48,lVar6,0);
              uVar9 = *puVar10;
              lVar6 = this.gridPool;
              this.tweenFocusTarget = (int)uVar9;
              *(int *)(this + 0x100) = (int)((uint64)uVar9 >> 32);
              fVar3 = local_40;
              if (lVar6 != null) {
                lVar8 = 32;
                while( true ) {
                  if (lVar6.Count <= (int)uVar12) {
                    return;
                  }
                  fVar3 = local_40;
                  if (lVar6 == null) break;
                  if (lVar6.Count <= uVar12) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  lVar6 = *(int64 *)(lVar8 + lVar6._items);
                  fVar3 = local_40;
                  if ((lVar6 == null) ||
                     (lVar6 = GameObject.GetComponent(lVar6,DAT_181d9f5d0), fVar3 = local_40) == null
                     ) break;
                  cVar5 = ExploreTileUnitController.get_MoveAble(lVar6,0);
                  if (cVar5) {
                    fVar3 = local_40;
                    if (((this.gridPool == null) ||
                        (lVar6 = FUN_180002f80(this.gridPool,uVar12,DAT_181d62178),
                        fVar3 = local_40, lVar6 == null)) ||
                       (lVar6 = GameObject.GetComponent(lVar6,DAT_181d9f5d0), fVar3 = local_40,
                       lVar6 == null)) break;
                    ExploreTileUnitController.set_MoveAble(lVar6,0,0);
                  }
                  lVar6 = this.gridPool;
                  uVar12 = uVar12 + 1;
                  lVar8 = lVar8 + 8;
                  fVar3 = local_40;
                  if (lVar6 == null) break;
                }
              }
            }
          }
        }
        LAB_180946230:
        local_40 = fVar3;
    }

    // Token : 0x60013ED
    // RVA   : 0x946330   Offset: 0x944B30   Length: 0x93B
    public void PlayerFinishMove()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        uint uVar1;
        uint uVar2;
        bool cVar3;
        long lVar4;
        ulong uVar5;
        long lVar6;
        uint uVar7;
        uint uVar8;
        if (this.playerSkeleton != null) {
          lVar4 = SkeletonAnimation.get_AnimationState(this.playerSkeleton,0);
          if (this.explorePanelData != null) {
            uVar5 = "idle";
            if (this.explorePanelData.exploreType != 1) {
              if (((*pStatics == 0) ||
                  (lVar6 = *(int64 *)(*pStatics + 32)) == null) ||
                 (lVar6 = WorldData.Player(lVar6,0)) == null) throw; // [null/range check failed]
              uVar5 = HeroData.GetSkeletonHorseIdleAnim(lVar6,0);
            }
            if (lVar4 != null) {
              AnimationState.SetAnimation(lVar4,0,uVar5,1,0);
              if (this.playerSkeleton != null) {
                *(uint32 *)(this.playerSkeleton + 300) = 0x3f800000;
                if (((this.playerGrid != null) &&
                    (lVar4 = GameObject.GetComponent(this.playerGrid,DAT_181d9f5d0),
                    lVar4 != null)) && (lVar4.mapWidth != null)) {
                  uVar1 = *(uint32 *)(lVar4.mapWidth + 36);
                  if (((this.playerGrid != null) &&
                      (lVar4 = GameObject.GetComponent(this.playerGrid,DAT_181d9f5d0),
                      lVar4 != null)) && (lVar4.mapWidth != null)) {
                    lVar6 = this.gridUnits;
                    uVar2 = *(uint32 *)(lVar4.mapWidth + 32);
                    if (lVar6 != null) {
                      if (**(uint32 **)(lVar6 + 16) <= uVar1) {
                        uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar5,0);
                      }
                      lVar4 = *(int64 *)(*(uint32 **)(lVar6 + 16) + 4);
                      if ((uint32)lVar4 <= uVar2) {
                        uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar5,0);
                      }
                      lVar4 = *(int64 *)
                               (lVar6 + 32 + ((int)uVar1 * lVar4 + (int64)(int)uVar2) * 8);
                      if ((lVar4 != null) &&
                         (lVar4 = GameObject.GetComponent(lVar4,DAT_181d9f5d0)) != null) {
                        if (*(char *)(lVar4 + 41) == false) {
                          if (((*pStatics != 0) &&
                              (lVar4 = *(int64 *)(*pStatics + 32),
                              lVar4 != null)) && (lVar4 = WorldData.Player(lVar4,0)) != null) {
                            if (0.0 < *(float *)(lVar4 + 0x178)) {
                              if ((this.playerGrid != null) &&
                                 (lVar4 = GameObject.GetComponent
                                                    (this.playerGrid,DAT_181d9f5d0),
                                 lVar4 != null)) {
                                ExploreTileUnitController.set_Seen(lVar4,1,0);
                                if ((this.playerGrid != null) &&
                                   (lVar4 = GameObject.GetComponent
                                                      (this.playerGrid,DAT_181d9f5d0),
                                   lVar4 != null)) {
                                  ExploreTileUnitController.set_Been(lVar4,1,0);
                                  uVar8 = uVar1 - 1;
                                  if ((int)uVar8 <= (int)(uVar1 + 1)) {
                                    do {
                                      for (uVar7 = uVar2 - 1; (int)uVar7 <= (int)(uVar2 + 1);
                                          uVar7 = uVar7 + 1) {
                                        if (((uVar8 != uVar1) || (uVar7 != uVar2)) &&
                                           ((-1 < (int)uVar8 && (-1 < (int)uVar7)))) {
                                          lVar4 = this.explorePanelData;
                                          if (lVar4 == null) throw; // [null/range check failed]
                                          if (((int)uVar8 < lVar4.mapWidth) &&
                                             ((int)uVar7 < lVar4.mapHeight)) {
                                            if (uVar8 == uVar1) {
                                              bVar9 = true;
                                            }
                                            else {
                                              if (uVar7 != uVar2) {
                                                if ((lVar4.exploreTileMap == null) ||
                                                   (lVar4 = FUN_180127f50(lVar4.exploreTileMap,
                                                                          (int64)(int)uVar8,
                                                                          (int64)(int)uVar2),
                                                   lVar4 == null)) throw; // [null/range check failed]
                                                if (lVar4.maxPower != null) {
                                                  if (((this.explorePanelData == null) ||
                                                      (lVar4 = *(int64 *)
                                                                (this.explorePanelData + 40),
                                                      lVar4 == null)) ||
                                                     (lVar4 = FUN_180127f50(lVar4,(int64)(int)uVar1,
                                                                            (int64)(int)uVar7),
                                                     lVar4 == null)) throw; // [null/range check failed]
                                                  if (lVar4.maxPower == null)
                                                  {
                                                    }
                                                    }
                                                    bVar9 = uVar7 == uVar2;
                                                    }
                                                    ExploreController.ManagePlayerAroundGrid
                                                    (this,uVar8,uVar7,bVar9,0);
                                                    }
                                                    }
                                                  }
                                      }
                                      uVar8 = uVar8 + 1;
                                    } while ((int)uVar8 <= (int)(uVar1 + 1));
                                  }
                                  if (((this.playerGrid != null) &&
                                      (lVar4 = GameObject.GetComponent
                                                         (this.playerGrid,DAT_181d9f5d0),
                                      lVar4 != null)) && (lVar4.mapWidth != null)) {
                                    if (*(int *)(lVar4.mapWidth + 56) == 0) {
                                      return;
                                    }
                                    if (((this.playerGrid != null) &&
                                        (lVar4 = GameObject.GetComponent
                                                           (this.playerGrid,DAT_181d9f5d0),
                                        lVar4 != null)) && (lVar4.mapWidth != null)) {
                                      if (*(char *)(lVar4.mapWidth + 53) != false) {
                                        return;
                                      }
                                      if (((this.playerGrid != null) &&
                                          (lVar4 = GameObject.get_transform
                                                             (this.playerGrid,0), lVar4 != null
                                          )) && (lVar4 = Transform.Find(lVar4,"ExploreEvent",0),
                                                lVar4 != null)) {
                                        uVar5 = Component.GetComponent(lVar4,DAT_181d6d540);
                                        uVar5 = DOTweenModuleSprite.DOFade(uVar5,0,0x3e99999a,0);
                                        TweenSettingsExtensions.SetUpdate(uVar5,1,DAT_181d98958);
                                        if ((this.playerGrid != null) &&
                                           (lVar4 = GameObject.get_transform
                                                              (this.playerGrid,0),
                                           lVar4 != null)) {
                                          uVar5 = Transform.Find(lVar4,"ExploreEvent",0);
                                          uVar5 = ShortcutExtensions.DOScale
                                                            (uVar5,0x40000000,0x3e99999a,0);
                                          TweenSettingsExtensions.SetUpdate(uVar5,1,DAT_181d98af0);
                                          if ((this.playerGrid != null) &&
                                             (lVar4 = GameObject.GetComponent
                                                                (this.playerGrid,
                                                                 DAT_181d9f5d0), lVar4 != null)) {
                                            ExploreController.ManageTileEvent
                                                      (this,lVar4.mapWidth,0);
                                            return;
                                          }
                                        }
                                      }
                                    }
                                  }
                                }
                              }
                            }
                            else {
                              lVar4 = FUN_18046c0a0(0);
                              if (((lVar4 != null) && (lVar4.exploreTiles != null)) &&
                                 (lVar4 = WorldData.Player(lVar4.exploreTiles,0)) != null) {
                                HeroData.DeadToAlive(lVar4,0);
                                lVar4 = **(int64 **)(DAT_181d6c960 + 184);
                                lVar6 = il2cpp_internal(DAT_181d72a30);
                                FUN_180f58a90(lVar6,DAT_181d7c250);
                                if (lVar6 != null) {
                                  FUN_181827900(lVar6,"留得青山在;HideInteractUI",DAT_181d7c3d0);
                                  uVar5 = new SinglePlotData("#$PlayerName#行至山穷水尽，精疲力竭，不得不原路折返",lVar6,0);
                                  if (lVar4 != null) {
                                    PlotController.AddPlot(lVar4,uVar5,0);
                                    uVar5 = 0;
                                    goto LAB_180946b0c;
                                  }
                                }
                              }
                            }
                          }
                        }
                        else if (this.explorePanelData != null) {
                          lVar4 = this.explorePanelData.finishFuc;
                          if ((lVar4 == null) ||
                             (cVar3 = String.op_Inequality(lVar4,"",0), !cVar3)) {
                            uVar5 = 1;
        LAB_180946b0c:
                            ExploreController.FinishExploreMap(this,uVar5,0);
                            return;
                          }
                          if (this.explorePanelData != null) {
                            lVar4 = this.explorePanelData.finishParam;
                            if ((lVar4 == null) ||
                               (cVar3 = String.op_Inequality(lVar4,"",0), !cVar3)) {
                              lVar4 = FUN_18046c440(0);
                              if ((this.explorePanelData != null) && (lVar4 != null)) {
                                Component.SendMessage
                                          (lVar4,this.explorePanelData.finishFuc,0);
                                return;
                              }
                            }
                            else {
                              lVar6 = FUN_18046c440(0);
                              lVar4 = this.explorePanelData;
                              if ((lVar4 != null) && (lVar6 != null)) {
                                Component.SendMessage
                                          (lVar6,lVar4.finishFuc,
                                           lVar4.finishParam,0);
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

    // Token : 0x60013EE
    // RVA   : 0x9408D0   Offset: 0x93F0D0   Length: 0x1C3
    public void ManagePlayerAroundGrid(int column, int row, bool moveAble)
    {
        void ExploreController.ManagePlayerAroundGrid
                     (int64 this,uint32 column,uint32 row,uint8 moveAble)
        {
        int64 lVar1;
        int64 lVar2;
        uint64 uVar3;
        int64 lVar4;
        int64 lVar5;
        lVar4 = (int64)(int)row;
        lVar5 = (int64)(int)column;
        lVar2 = this.gridUnits;
        if (lVar2 != null) {
          if (**(uint32 **)(lVar2 + 16) <= column) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          lVar1 = *(int64 *)(*(uint32 **)(lVar2 + 16) + 4);
          if ((uint32)lVar1 <= row) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          lVar2 = *(int64 *)(lVar2 + 32 + (lVar5 * lVar1 + lVar4) * 8);
          if ((lVar2 != null) && (lVar2 = GameObject.GetComponent(lVar2,DAT_181d9f5d0)) != null) {
            ExploreTileUnitController.set_Seen(lVar2,1,0);
            if ((this.explorePanelData != null) &&
               (lVar2 = this.explorePanelData.exploreTileMap) != null) {
              if (**(uint32 **)(lVar2 + 16) <= column) {
                uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar3,0);
              }
              lVar1 = *(int64 *)(*(uint32 **)(lVar2 + 16) + 4);
              if ((uint32)lVar1 <= row) {
                uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar3,0);
              }
              lVar2 = *(int64 *)(lVar2 + 32 + (lVar5 * lVar1 + lVar4) * 8);
              if (lVar2 != null) {
                if (*(int *)(lVar2 + 48) == 1) {
                  return;
                }
                lVar2 = this.gridUnits;
                if (lVar2 != null) {
                  if (**(uint32 **)(lVar2 + 16) <= column) {
                    uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar3,0);
                  }
                  lVar1 = *(int64 *)(*(uint32 **)(lVar2 + 16) + 4);
                  if ((uint32)lVar1 <= row) {
                    uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar3,0);
                  }
                  lVar4 = *(int64 *)(lVar2 + 32 + (lVar5 * lVar1 + lVar4) * 8);
                  if ((lVar4 != null) && (lVar4 = GameObject.GetComponent(lVar4,DAT_181d9f5d0)) != null)
                  {
                    ExploreTileUnitController.set_MoveAble(lVar4,moveAble,0);
                    return;
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x60013EF
    // RVA   : 0x940AA0   Offset: 0x93F2A0   Length: 0x49E8
    public void ManageTileEvent(ExploreTileData targetTileData)
    {
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        var pStatics_ef00 = *(int64*)(DAT_181d4ef00 + 184);
        uint uVar2;
        bool cVar3;
        uint uVar4;
        uint uVar5;
        uint uVar6;
        uint uVar7;
        int iVar8;
        ulong uVar9;
        long lVar12;
        long lVar13;
        long lVar16;
        long lVar17;
        ulong uVar18;
        float fVar20;
        double dVar21;
        byte[] auVar22 = new byte[16];
        byte[] auVar23 = new byte[16];
        float[] local_res10 = new float[4];
        uint[] local_res20 = new uint[2];
        ulong in_stack_fffffffffffffed8;
        ulong uVar24;
        ulong in_stack_fffffffffffffee0;
        uint uVar27;
        ulong uVar25;
        ulong uVar26;
        ulong in_stack_fffffffffffffee8;
        ulong in_stack_fffffffffffffef0;
        ulong uVar28;
        ulong in_stack_ffffffffffffff00;
        float[] local_c8 = new float[4];
        byte[] local_b8 = new byte[16];
        int local_a8;
        int local_a4;
        uint[] local_a0 = new uint[2];
        long[] local_98 = new long[2];
        float local_88;
        uint[] local_84 = new uint[19];
        uint64 extraout_XMM0_Qb;
        uVar5 = (uint32)((uint64)in_stack_fffffffffffffef0 >> 32);
        uVar27 = (uint32)((uint64)in_stack_fffffffffffffee0 >> 32);
        uVar6 = (uint32)((uint64)in_stack_fffffffffffffee8 >> 32);
        plVar14 = (int64 *)0;
        local_88 = 0.0;
        local_res20[0] = 0;
        if (targetTileData == null) throw; // [null/range check failed]
        uVar2 = *(uint32 *)(targetTileData + 56);
        *(uint8 *)(targetTileData + 53) = 1;
        if ((int)uVar2 < 0) {
          return;
        }
        lVar16 = this.ExploreTileTypeDataBase;
        if (lVar16 == null) throw; // [null/range check failed]
        if (lVar16.Count <= uVar2) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        lVar16 = lVar16._items[uVar2];
        if (lVar16 == null) throw; // [null/range check failed]
        if ((*(int64 *)(lVar16 + 48) != 0) &&
           (cVar3 = String.op_Inequality(*(int64 *)(lVar16 + 48),"",0), cVar3)) {
          uVar9 = String.Concat("Sound/SoundEffect/",*(uint64 *)(lVar16 + 48),0);
          plVar10 = (int64 *)Resources.Load(uVar9,0);
          plVar19 = plVar14;
          if ((plVar10 != (int64 *)0) && (*plVar10 == DAT_181d8a228)) {
            plVar19 = plVar10;
          }
          NGUITools.PlaySound(plVar19,0);
        }
        lVar17 = *(int64 *)(lVar16 + 40);
        if (lVar17 == null) throw; // [null/range check failed]
        if (*(int *)(lVar17 + 24) < 1) {
          return;
        }
        uVar4 = FUN_180d8cf10(0,*(int *)(lVar17 + 24),0);
        if (*(uint32 *)(lVar17 + 24) <= uVar4) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        lVar17 = lVar17[uVar4];
        if ((lVar17 == null) || (lVar12 = *(int64 *)(lVar17 + 24)) == null) throw; // [null/range check failed]
        iVar8 = *(int *)(lVar12 + 24);
        if (iVar8 == 0) {
          local_res10[0] = 0.0;
        }
        else if (iVar8 < 2) {
          if (iVar8 == 0) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          local_res10[0] = *(float *)(*(int64 *)(lVar12 + 16) + 32);
        }
        else {
          if (iVar8 == 0) {
            local_98[0] = lVar12;
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
            lVar12 = *(int64 *)(lVar17 + 24);
          }
          local_98[0] = lVar12;
          if (lVar12 == null) throw; // [null/range check failed]
          if (*(uint32 *)(lVar12 + 24) < 2) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          local_res10[0] =
               (float)Random.Range(local_98[0],*(uint32 *)(*(int64 *)(local_98[0] + 16) + 36),
                                    0);
        }
        switch(*(uint32 *)(lVar17 + 16)) {
        case 1:
          lVar17 = *(int64 *)(lVar17 + 24);
          if (lVar17 != null) {
            if (*(int *)(lVar17 + 24) == 0) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            if (0.0 < *(float *)(*(int64 *)(lVar17 + 16) + 32)) {
              lVar17 = FUN_18046c300(0);
              lVar12 = FUN_18046c0a0(0);
              if (((lVar12 == null) || (*(int64 *)(lVar12 + 32) == 0)) ||
                 (lVar12 = WorldData.Player(*(int64 *)(lVar12 + 32),0)) == null) break;
              uVar9 = String.Format("{0}在{1}中稍息片刻，精神倍增",*(uint64 *)(lVar12 + 104),
                                     lVar16._items,0);
              if ((this.ExploreTileTypeDataBase == null) ||
                 (lVar16 = FUN_180002f80(this.ExploreTileTypeDataBase,uVar2,DAT_181d5ff78)) == null)
              break;
              uVar18 = String.Concat("探索_",lVar16._items,0);
              uVar24 = "BuffGood";
            }
            else {
              lVar17 = FUN_18046c300(0);
              lVar12 = FUN_18046c0a0(0);
              if (((lVar12 == null) || (*(int64 *)(lVar12 + 32) == 0)) ||
                 (lVar12 = WorldData.Player(*(int64 *)(lVar12 + 32),0)) == null) break;
              uVar9 = String.Format("{0}在{1}中艰难跋涉，精疲力尽",*(uint64 *)(lVar12 + 104),
                                     lVar16._items,0);
              if ((this.ExploreTileTypeDataBase == null) ||
                 (lVar16 = FUN_180002f80(this.ExploreTileTypeDataBase,uVar2,DAT_181d5ff78)) == null)
              break;
              uVar18 = String.Concat("探索_",lVar16._items,0);
              uVar24 = "StateDown";
            }
            if (lVar17 != null) {
              local_b8._0_12_ = ZEXT812(0);
              local_b8._12_4_ = 0;
              InfoController.AddInfoTab
                        (lVar17,uVar9,"TileAtlas",uVar18,uVar24,CONCAT44(uVar27,0x3f800000),
                         CONCAT44(uVar6,0x40a00000),local_b8,0);
              if (this.exploreMapData != null) {
                uVar6 = Mathf.RoundToInt((this.exploreMapData.exploreDifficulty * 0.15 + 1.0)
                                          * local_res10[0],0);
                ExploreController.ChangeMoveStep(this,uVar6,1,0);
                return;
              }
            }
          }
          break;
        case 2:
          plVar14 = this.seedRandomBase;
          if ((plVar14 == (int64 *)0) ||
             (dVar21 = (double)(**(code **)(*plVar14 + 0x1a8))(plVar14,*(uint64 *)(*plVar14 + 0x1b0)),
             0.05999999865889549 < dVar21)) {
            if ((this.finalGrid != null) &&
               (lVar17 = GameObject.GetComponent(this.finalGrid,DAT_181d9f5d0),
               lVar17 != null)) {
              cVar3 = ExploreTileUnitController.get_Seen(lVar17,0);
              if ((cVar3) || (fVar20 = (float)Random.get_value(0), 0.05 < fVar20)) {
                lVar17 = FUN_18046c300(0);
                lVar12 = FUN_18046c0a0(0);
                if (((lVar12 != null) && (*(int64 *)(lVar12 + 32) != 0)) &&
                   (lVar12 = WorldData.Player(*(int64 *)(lVar12 + 32),0)) != null) {
                  uVar9 = String.Format("{0}在{1}中发现了部分地点信息",*(uint64 *)(lVar12 + 104),
                                         lVar16._items,0);
                  if (((this.ExploreTileTypeDataBase != null) &&
                      (lVar16 = FUN_180002f80(this.ExploreTileTypeDataBase,uVar2,DAT_181d5ff78),
                      lVar16 != null)) &&
                     (uVar18 = String.Concat("探索_",lVar16._items,0), lVar17 != null
                     )) {
                    local_b8 = ZEXT816(0);
                    InfoController.AddInfoTab
                              (lVar17,uVar9,"TileAtlas",uVar18,"Woosh",CONCAT44(uVar27,0x3f800000)
                               ,CONCAT44(uVar6,0x40a00000),local_b8,0);
                    if ((this.explorePanelData != null) &&
                       (lVar16 = this.explorePanelData.exploreTiles) != null) {
                      uVar6 = Mathf.RoundToInt((float)lVar16.Count * local_res10[0],0);
                      ExploreController.WatchRandomTile(this,uVar6,0);
                      return;
                    }
                  }
                }
              }
              else {
                lVar17 = FUN_18046c300(0);
                lVar12 = FUN_18046c0a0(0);
                if (((lVar12 != null) && (*(int64 *)(lVar12 + 32) != 0)) &&
                   (lVar12 = WorldData.Player(*(int64 *)(lVar12 + 32),0)) != null) {
                  uVar9 = String.Format("{0}在{1}中发现了终点信息",*(uint64 *)(lVar12 + 104),
                                         lVar16._items,0);
                  if (((this.ExploreTileTypeDataBase != null) &&
                      (lVar16 = FUN_180002f80(this.ExploreTileTypeDataBase,uVar2,DAT_181d5ff78),
                      lVar16 != null)) &&
                     (uVar18 = String.Concat("探索_",lVar16._items,0), lVar17 != null
                     )) {
                    local_b8 = ZEXT816(0);
                    InfoController.AddInfoTab
                              (lVar17,uVar9,"TileAtlas",uVar18,"PencilWriting",CONCAT44(uVar27,0x3f800000)
                               ,CONCAT44(uVar6,0x40a00000),local_b8,0);
                    if ((this.finalGrid != null) &&
                       (lVar16 = GameObject.GetComponent(this.finalGrid,DAT_181d9f5d0),
                       lVar16 != null)) {
                      ExploreTileUnitController.set_Seen(lVar16,1,0);
                      if ((this.finalGrid != null) &&
                         (lVar16 = GameObject.get_transform(this.finalGrid,0), lVar16 != null
                         )) {
                        puVar11 = (uint64 *)Transform.get_localPosition(local_98,lVar16,0);
                        uVar9 = *puVar11;
                        this.tweenFocusTarget = (int)uVar9;
                        *(int *)(this + 0x100) = (int)((uint64)uVar9 >> 32);
                        return;
                      }
                    }
                  }
                }
              }
            }
            break;
          }
          lVar17 = FUN_18046c440(0);
          uVar9 = FUN_180004500(DAT_181d63120);
          uVar18 = String.Format("这似乎是一张......藏宝地图？！\n也不知是谁人留在这儿，若是得空可前去挖掘一番。",uVar9,0);
          lVar16 = il2cpp_internal(DAT_181d72a30);
          FUN_180f58a90(lVar16,DAT_181d7c250);
          if (lVar16 == null) break;
          FUN_181827900(lVar16,"收入囊中;GetTreasureMapMissionPlot",DAT_181d7c3d0);
          uVar9 = il2cpp_internal(DAT_181d7d2b0);
          SinglePlotData.ctor
                    (uVar9,uVar18,lVar16,1,0,CONCAT44(uVar27,3),"0",CONCAT44(uVar5,1),0,0);
          if (lVar17 == null) break;
          goto LAB_180943f96;
        case 3:
          lVar17 = FUN_18046c300(0);
          lVar12 = FUN_18046c0a0(0);
          if (((lVar12 != null) && (*(int64 *)(lVar12 + 32) != 0)) &&
             (lVar12 = WorldData.Player(*(int64 *)(lVar12 + 32),0)) != null) {
            uVar9 = String.Format("{0}在{1}中登高远望，了解了周边信息",*(uint64 *)(lVar12 + 104),
                                   lVar16._items,0);
            if (((this.ExploreTileTypeDataBase != null) &&
                (lVar16 = FUN_180002f80(this.ExploreTileTypeDataBase,uVar2,DAT_181d5ff78)) != null)
               && (uVar18 = String.Concat("探索_",lVar16._items,0), lVar17 != null))
            {
              local_b8 = ZEXT816(0);
              InfoController.AddInfoTab
                        (lVar17,uVar9,"TileAtlas",uVar18,"Woosh",CONCAT44(uVar27,0x3f800000),
                         CONCAT44(uVar6,0x40a00000),local_b8,0);
              uVar6 = Mathf.RoundToInt();
              ExploreController.WatchRoundTile(this,uVar6,0);
              return;
            }
          }
          break;
        case 4:
          lVar17 = FUN_18046c300(0);
          lVar12 = FUN_18046c0a0(0);
          if (((lVar12 != null) && (*(int64 *)(lVar12 + 32) != 0)) &&
             (lVar12 = WorldData.Player(*(int64 *)(lVar12 + 32),0)) != null) {
            uVar9 = String.Format("{0}在{1}中发现了一些资源",*(uint64 *)(lVar12 + 104),
                                   lVar16._items,0);
            if (((this.ExploreTileTypeDataBase != null) &&
                (lVar16 = FUN_180002f80(this.ExploreTileTypeDataBase,uVar2,DAT_181d5ff78)) != null)
               && (uVar18 = String.Concat("探索_",lVar16._items,0), lVar17 != null))
            {
              local_b8 = ZEXT816(0);
              InfoController.AddInfoTab
                        (lVar17,uVar9,"TileAtlas",uVar18,"Woosh",CONCAT44(uVar27,0x3f800000),
                         CONCAT44(uVar6,0x40a00000),local_b8,0);
              lVar16 = *(int64 *)(pStatics_ef00 + 0x430);
              if (((lVar16 != null) &&
                  (uVar6 = FUN_180d8cf10(0,lVar16.Count + -1,0),
                  this.exploreMapData != null)) &&
                 (lVar16 = *(int64 *)(pStatics_ef00 + 0x440)) != null) {
                FUN_1800d6780(lVar16,uVar6,DAT_181d796d8);
                Mathf.RoundToInt();
                lVar16 = FUN_18046c0a0(0);
                if (((lVar16 != null) && (*(int64 *)(lVar16 + 32) != 0)) &&
                   (lVar16 = WorldData.Player(*(int64 *)(lVar16 + 32),0)) != null) {
                  HeroData.ChangeResource(lVar16,uVar6);
                  return;
                }
              }
            }
          }
          break;
        case 5:
          lVar17 = FUN_18046c300(0);
          lVar12 = FUN_18046c0a0(0);
          if (((lVar12 != null) && (*(int64 *)(lVar12 + 32) != 0)) &&
             (lVar12 = WorldData.Player(*(int64 *)(lVar12 + 32),0)) != null) {
            uVar9 = String.Format("{0}在{1}中发现了一些银两",*(uint64 *)(lVar12 + 104),
                                   lVar16._items,0);
            if (((this.ExploreTileTypeDataBase != null) &&
                (lVar16 = FUN_180002f80(this.ExploreTileTypeDataBase,uVar2,DAT_181d5ff78)) != null)
               && (uVar18 = String.Concat("探索_",lVar16._items,0), lVar17 != null))
            {
              local_b8 = ZEXT816(0);
              InfoController.AddInfoTab
                        (lVar17,uVar9,"TileAtlas",uVar18,"Woosh",CONCAT44(uVar27,0x3f800000),
                         CONCAT44(uVar6,0x40a00000),local_b8,0);
              lVar16 = FUN_18046c0a0(0);
              if ((lVar16 != null) && (*(int64 *)(lVar16 + 32) != 0)) {
                lVar16 = WorldData.Player(*(int64 *)(lVar16 + 32),0);
                if ((this.exploreMapData != null) &&
                   (uVar6 = Mathf.RoundToInt((this.exploreMapData.exploreDifficulty * 0.5 +
                                              1.0) * local_res10[0] * 5.0,0), lVar16 != null)) {
                  HeroData.ChangeMoney(lVar16,uVar6,1,0);
                  return;
                }
              }
            }
          }
          break;
        case 6:
          lVar16 = *(int64 *)(pStatics_ef00 + 0x4a8);
          if (lVar16 != null) {
            uVar6 = FUN_180d8cf10(0,lVar16.Count,0);
            lVar16 = FUN_18046c0a0(0);
            if ((lVar16 != null) && (*(int64 *)(lVar16 + 32) != 0)) {
              lVar16 = WorldData.Player(*(int64 *)(lVar16 + 32),0);
              if ((this.exploreMapData != null) &&
                 (Mathf.RoundToInt((this.exploreMapData.exploreDifficulty * 0.5 + 1.0) *
                                    local_res10[0],0), lVar16 != null)) {
                HeroData.ChangeLivingSkillExp(lVar16,uVar6);
                return;
              }
            }
          }
          break;
        case 7:
          lVar17 = *(int64 *)(lVar17 + 24);
          if (lVar17 != null) {
            if (*(int *)(lVar17 + 24) == 0) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            if (0.0 < *(float *)(*(int64 *)(lVar17 + 16) + 32)) {
              lVar17 = FUN_18046c300(0);
              plVar10 = (int64 *)FUN_1800d60b0(DAT_181d7f180,4);
              lVar12 = FUN_18046c0a0(0);
              if (((lVar12 == null) || (*(int64 *)(lVar12 + 32) == 0)) ||
                 ((lVar12 = WorldData.Player(*(int64 *)(lVar12 + 32),0), lVar12 == null ||
                  (lVar12 = *(int64 *)(lVar12 + 104), plVar10 == (int64 *)0)))) {
        LAB_1809453f6:
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              if ((lVar12 != null) &&
                 (lVar13 = il2cpp_internal(lVar12,*(uint64 *)(*plVar10 + 64))) == null) {
                uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar9,0);
              }
              if ((int)plVar10[3] == 0) {
                uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar9,0);
              }
              plVar10[4] = lVar12;
              il2cpp_internal(plVar10 + 4,lVar12);
              lVar16 = lVar16._items;
              if ((lVar16 != null) &&
                 (lVar12 = il2cpp_internal(lVar16,*(uint64 *)(*plVar10 + 64))) == null) {
                uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar9,0);
              }
              if (*(uint32 *)(plVar10 + 3) < 2) {
                uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar9,0);
              }
              plVar10[5] = lVar16;
              il2cpp_internal(plVar10 + 5,lVar16);
              local_c8[0] = local_res10[0] * 100.0;
              lVar16 = il2cpp_value_box(DAT_181d7d0b8,local_c8);
              if ((lVar16 != null) &&
                 (lVar12 = il2cpp_internal(lVar16,*(uint64 *)(*plVar10 + 64))) == null) {
                uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar9,0);
              }
              if (*(uint32 *)(plVar10 + 3) < 3) {
                uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar9,0);
              }
              plVar10[6] = lVar16;
              il2cpp_internal(plVar10 + 6,lVar16);
              lVar16 = FUN_18046c0a0(0);
              if ((((lVar16 == null) || (*(int64 *)(lVar16 + 32) == 0)) ||
                  (lVar16 = WorldData.Player(*(int64 *)(lVar16 + 32),0), uVar9 = "{0}在{1}中休整疗养，{3}生命内力恢复{2}%",
                  lVar16 == null)) || (*(int64 *)(lVar16 + 0x2f8) == 0)) goto LAB_1809453f6;
              lVar12 = "全队";
              if (*(int *)(*(int64 *)(lVar16 + 0x2f8) + 24) < 1) {
                lVar12 = "";
              }
              if ((lVar12 != null) &&
                 (lVar16 = il2cpp_internal(lVar12,*(uint64 *)(*plVar10 + 64))) == null) {
                uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar9,0);
              }
              FUN_180002fd0(plVar10,3,lVar12);
              uVar9 = String.Format(uVar9,plVar10,0);
              if ((this.ExploreTileTypeDataBase == null) ||
                 (lVar16 = FUN_180002f80(this.ExploreTileTypeDataBase,uVar2,DAT_181d5ff78)) == null)
              break;
              uVar18 = String.Concat("探索_",lVar16._items,0);
              uVar24 = "BuffGood";
            }
            else {
              lVar17 = FUN_18046c300(0);
              plVar10 = (int64 *)FUN_1800d60b0(DAT_181d7f180,4);
              lVar12 = FUN_18046c0a0(0);
              if ((((lVar12 == null) || (*(int64 *)(lVar12 + 32) == 0)) ||
                  (lVar12 = WorldData.Player(*(int64 *)(lVar12 + 32),0)) == null) ||
                 (lVar12 = *(int64 *)(lVar12 + 104), plVar10 == (int64 *)0)) {
        LAB_180945380:
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              if ((lVar12 != null) &&
                 (lVar13 = il2cpp_internal(lVar12,*(uint64 *)(*plVar10 + 64))) == null) {
                uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar9,0);
              }
              if ((int)plVar10[3] == 0) {
                uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar9,0);
              }
              plVar10[4] = lVar12;
              il2cpp_internal(plVar10 + 4,lVar12);
              lVar16 = lVar16._items;
              if ((lVar16 != null) &&
                 (lVar12 = il2cpp_internal(lVar16,*(uint64 *)(*plVar10 + 64))) == null) {
                uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar9,0);
              }
              if (*(uint32 *)(plVar10 + 3) < 2) {
                uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar9,0);
              }
              plVar10[5] = lVar16;
              il2cpp_internal(plVar10 + 5,lVar16);
              local_c8[0] = -local_res10[0] * 100.0;
              lVar16 = il2cpp_value_box(DAT_181d7d0b8,local_c8);
              if ((lVar16 != null) &&
                 (lVar12 = il2cpp_internal(lVar16,*(uint64 *)(*plVar10 + 64))) == null) {
                uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar9,0);
              }
              if (*(uint32 *)(plVar10 + 3) < 3) {
                uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar9,0);
              }
              plVar10[6] = lVar16;
              il2cpp_internal(plVar10 + 6,lVar16);
              lVar16 = FUN_18046c0a0(0);
              if ((((lVar16 == null) || (*(int64 *)(lVar16 + 32) == 0)) ||
                  (lVar16 = WorldData.Player(*(int64 *)(lVar16 + 32),0), uVar9 = "{0}在{1}中艰难跋涉，{3}生命内力降低{2}%",
                  lVar16 == null)) || (*(int64 *)(lVar16 + 0x2f8) == 0)) goto LAB_180945380;
              lVar12 = "全队";
              if (*(int *)(*(int64 *)(lVar16 + 0x2f8) + 24) < 1) {
                lVar12 = "";
              }
              if ((lVar12 != null) &&
                 (lVar16 = il2cpp_internal(lVar12,*(uint64 *)(*plVar10 + 64))) == null) {
                uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar9,0);
              }
              FUN_180002fd0(plVar10,3,lVar12);
              uVar9 = String.Format(uVar9,plVar10,0);
              if ((this.ExploreTileTypeDataBase == null) ||
                 (lVar16 = FUN_180002f80(this.ExploreTileTypeDataBase,uVar2,DAT_181d5ff78)) == null)
              break;
              uVar18 = String.Concat("探索_",lVar16._items,0);
              uVar24 = "StateDown";
            }
            if (lVar17 != null) {
              local_b8._0_12_ = ZEXT812(0);
              local_b8._12_4_ = 0;
              uVar25 = CONCAT44(uVar27,0x3f800000);
              InfoController.AddInfoTab
                        (lVar17,uVar9,"TileAtlas",uVar18,uVar24,uVar25,CONCAT44(uVar6,0x40a00000),
                         local_b8,0);
              lVar16 = FUN_18046c0a0(0);
              if ((lVar16 != null) && (*(int64 *)(lVar16 + 32) != 0)) {
                lVar16 = WorldData.Player(*(int64 *)(lVar16 + 32),0);
                lVar17 = FUN_18046c0a0(0);
                if ((lVar17 != null) &&
                   (((*(int64 *)(lVar17 + 32) != 0 &&
                     (lVar17 = WorldData.Player(*(int64 *)(lVar17 + 32),0)) != null) &&
                    (lVar16 != null)))) {
                  uVar24 = CONCAT71((int7)(uVar24 >> 8),1);
                  HeroData.ChangeHp(lVar16,local_res10[0] * *(float *)(lVar17 + 0x17c),1,1,uVar24,
                                     uVar25 & 0xffffffffffffff00,0);
                  lVar16 = FUN_18046c0a0(0);
                  if ((lVar16 != null) && (*(int64 *)(lVar16 + 32) != 0)) {
                    lVar16 = WorldData.Player(*(int64 *)(lVar16 + 32),0);
                    lVar17 = FUN_18046c0a0(0);
                    if ((lVar17 != null) &&
                       (((*(int64 *)(lVar17 + 32) != 0 &&
                         (lVar17 = WorldData.Player(*(int64 *)(lVar17 + 32),0)) != null) &&
                        (lVar16 != null)))) {
                      uVar25 = 0;
                      uVar24 = uVar24 & 0xffffffffffffff00;
                      HeroData.ChangeMana
                                (lVar16,local_res10[0] * *(float *)(lVar17 + 0x194),1,1,uVar24,0);
                      while( true ) {
                        if ((((*pStatics_df90 == 0) ||
                             (lVar16 = *(int64 *)(*pStatics_df90 + 32),
                             lVar16 == null)) || (lVar16 = WorldData.Player(lVar16,0)) == null) ||
                           (*(int64 *)(lVar16 + 0x2f8) == 0)) break;
                        if (*(int *)(*(int64 *)(lVar16 + 0x2f8) + 24) <= (int)plVar14) {
                          return;
                        }
                        lVar16 = FUN_18046c0a0(0);
                        if (lVar16 == null) break;
                        lVar16 = *(int64 *)(lVar16 + 32);
                        lVar17 = FUN_18046c0a0(0);
                        if (((lVar17 == null) || (*(int64 *)(lVar17 + 32) == 0)) ||
                           ((lVar17 = WorldData.Player(*(int64 *)(lVar17 + 32),0), lVar17 == null ||
                            (((*(int64 *)(lVar17 + 0x2f8) == 0 ||
                              (uVar6 = FUN_1800d6750(*(int64 *)(lVar17 + 0x2f8),plVar14,DAT_181d68270),
                              lVar16 == null)) || (lVar16 = WorldData.GetHero(lVar16,uVar6,0)) == null)
                            )))) break;
                        uVar24 = CONCAT71((int7)(uVar24 >> 8),1);
                        HeroData.ChangeHp(lVar16,local_res10[0] * *(float *)(lVar16 + 0x17c),1,1,uVar24,
                                           uVar25 & 0xffffffffffffff00,0);
                        uVar25 = 0;
                        uVar24 = uVar24 & 0xffffffffffffff00;
                        HeroData.ChangeMana
                                  (lVar16,local_res10[0] * *(float *)(lVar16 + 0x194),1,1,uVar24,0);
                        plVar14 = (int64 *)(uint64)((int)plVar14 + 1);
                      }
                    }
                  }
                }
              }
            }
          }
          break;
        case 8:
          lVar17 = *(int64 *)(lVar17 + 24);
          if (lVar17 != null) {
            if (*(int *)(lVar17 + 24) == 0) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            pfVar1 = (float *)(*(int64 *)(lVar17 + 16) + 32);
            if (*pfVar1 <= 0.0 && *pfVar1 != 0.0) {
              lVar17 = FUN_18046c300(0);
              lVar12 = FUN_18046c0a0(0);
              if (((lVar12 == null) || (*(int64 *)(lVar12 + 32) == 0)) ||
                 (lVar12 = WorldData.Player(*(int64 *)(lVar12 + 32),0)) == null) break;
              uVar9 = String.Format("{0}在{1}中运功调息，疗养内伤",*(uint64 *)(lVar12 + 104),
                                     lVar16._items,0);
              if ((this.ExploreTileTypeDataBase == null) ||
                 (lVar16 = FUN_180002f80(this.ExploreTileTypeDataBase,uVar2,DAT_181d5ff78)) == null)
              break;
              uVar18 = String.Concat("探索_",lVar16._items,0);
              uVar24 = "BuffGood";
            }
            else {
              lVar17 = FUN_18046c300(0);
              lVar12 = FUN_18046c0a0(0);
              if (((lVar12 == null) || (*(int64 *)(lVar12 + 32) == 0)) ||
                 (lVar12 = WorldData.Player(*(int64 *)(lVar12 + 32),0)) == null) break;
              uVar9 = String.Format("{0}在{1}中吸入迷香，内息紊乱",*(uint64 *)(lVar12 + 104),
                                     lVar16._items,0);
              if ((this.ExploreTileTypeDataBase == null) ||
                 (lVar16 = FUN_180002f80(this.ExploreTileTypeDataBase,uVar2,DAT_181d5ff78)) == null)
              break;
              uVar18 = String.Concat("探索_",lVar16._items,0);
              uVar24 = "StateDown";
            }
            if (lVar17 != null) {
              local_b8._0_12_ = ZEXT812(0);
              local_b8._12_4_ = 0;
              InfoController.AddInfoTab
                        (lVar17,uVar9,"TileAtlas",uVar18,uVar24,CONCAT44(uVar27,0x3f800000),
                         CONCAT44(uVar6,0x40a00000),local_b8,0);
              if (this.exploreMapData != null) {
                if (0.0 <= local_res10[0]) {
                  lVar16 = FUN_18046c0a0(0);
                  if ((lVar16 == null) || (*(int64 *)(lVar16 + 32) == 0)) break;
                }
                iVar8 = Mathf.RoundToInt();
                lVar16 = FUN_18046c0a0(0);
                if ((lVar16 != null) && (*(int64 *)(lVar16 + 32) != 0)) {
                  lVar16 = WorldData.Player(*(int64 *)(lVar16 + 32),0);
                  if (lVar16 != null) {
                    uVar24 = uVar24 & 0xffffffffffffff00;
                    HeroData.ChangeInternalInjury(lVar16,(float)iVar8,1,0,uVar24,0);
                    while( true ) {
                      lVar16 = FUN_18046c0a0(0);
                      if ((((lVar16 == null) || (*(int64 *)(lVar16 + 32) == 0)) ||
                          (lVar16 = WorldData.Player(*(int64 *)(lVar16 + 32),0)) == null) ||
                         (*(int64 *)(lVar16 + 0x2f8) == 0)) break;
                      if (*(int *)(*(int64 *)(lVar16 + 0x2f8) + 24) <= (int)plVar14) {
                        return;
                      }
                      lVar16 = FUN_18046c0a0(0);
                      if (lVar16 == null) break;
                      lVar16 = *(int64 *)(lVar16 + 32);
                      lVar17 = FUN_18046c0a0(0);
                      if (((lVar17 == null) || (*(int64 *)(lVar17 + 32) == 0)) ||
                         ((lVar17 = WorldData.Player(*(int64 *)(lVar17 + 32),0), lVar17 == null ||
                          (((*(int64 *)(lVar17 + 0x2f8) == 0 ||
                            (uVar6 = FUN_1800d6750(*(int64 *)(lVar17 + 0x2f8),plVar14,DAT_181d68270),
                            lVar16 == null)) || (lVar16 = WorldData.GetHero(lVar16,uVar6,0)) == null)))
                         )) break;
                      uVar24 = uVar24 & 0xffffffffffffff00;
                      HeroData.ChangeInternalInjury(lVar16,(float)iVar8,1,0,uVar24,0);
                      plVar14 = (int64 *)(uint64)((int)plVar14 + 1);
                    }
                  }
                  goto LAB_180945405;
                }
              }
            }
          }
          break;
        case 9:
          if (*(int64 *)(lVar17 + 24) != 0) {
            fVar20 = (float)FUN_1800d6780(*(int64 *)(lVar17 + 24),0,DAT_181d796d8);
            if (fVar20 < 0.0) {
              lVar17 = FUN_18046c300(0);
              lVar12 = FUN_18046c0a0(0);
              if (((lVar12 == null) || (*(int64 *)(lVar12 + 32) == 0)) ||
                 (lVar12 = WorldData.Player(*(int64 *)(lVar12 + 32),0)) == null)
              goto LAB_180945405;
              uVar9 = String.Format("{0}在{1}中发现了解毒药草",*(uint64 *)(lVar12 + 104),
                                     lVar16._items,0);
              if ((this.ExploreTileTypeDataBase == null) ||
                 (lVar16 = FUN_180002f80(this.ExploreTileTypeDataBase,uVar2,DAT_181d5ff78)) == null)
              goto LAB_180945405;
              uVar18 = String.Concat("探索_",lVar16._items,0);
              uVar24 = "BuffGood";
            }
            else {
              lVar17 = FUN_18046c300(0);
              lVar12 = FUN_18046c0a0(0);
              if (((lVar12 == null) || (*(int64 *)(lVar12 + 32) == 0)) ||
                 (lVar12 = WorldData.Player(*(int64 *)(lVar12 + 32),0)) == null)
              goto LAB_180945405;
              uVar9 = String.Format("{0}在{1}中遭毒虫叮咬，痛痒难耐",*(uint64 *)(lVar12 + 104),
                                     lVar16._items,0);
              if ((this.ExploreTileTypeDataBase == null) ||
                 (lVar16 = FUN_180002f80(this.ExploreTileTypeDataBase,uVar2,DAT_181d5ff78)) == null)
              goto LAB_180945405;
              uVar18 = String.Concat("探索_",lVar16._items,0);
              uVar24 = "StateDown";
            }
            if (lVar17 != null) {
              local_b8._0_12_ = ZEXT812(0);
              local_b8._12_4_ = 0;
              InfoController.AddInfoTab
                        (lVar17,uVar9,"TileAtlas",uVar18,uVar24,CONCAT44(uVar27,0x3f800000),
                         CONCAT44(uVar6,0x40a00000),local_b8,0);
              if (this.exploreMapData != null) {
                if (0.0 <= local_res10[0]) {
                  lVar16 = FUN_18046c0a0(0);
                  if ((lVar16 == null) || (*(int64 *)(lVar16 + 32) == 0)) goto LAB_180945405;
                }
                iVar8 = Mathf.RoundToInt();
                lVar16 = FUN_18046c0a0(0);
                if (((lVar16 != null) && (*(int64 *)(lVar16 + 32) != 0)) &&
                   (lVar16 = WorldData.Player(*(int64 *)(lVar16 + 32),0)) != null) {
                  uVar24 = uVar24 & 0xffffffffffffff00;
                  HeroData.ChangePoisonInjury(lVar16,(float)iVar8,1,0,uVar24,0);
                  while( true ) {
                    lVar16 = FUN_18046c0a0(0);
                    if (((lVar16 == null) || (*(int64 *)(lVar16 + 32) == 0)) ||
                       ((lVar16 = WorldData.Player(*(int64 *)(lVar16 + 32),0), lVar16 == null ||
                        (*(int64 *)(lVar16 + 0x2f8) == 0)))) break;
                    if (*(int *)(*(int64 *)(lVar16 + 0x2f8) + 24) <= (int)plVar14) {
                      return;
                    }
                    lVar16 = FUN_18046c0a0(0);
                    if (lVar16 == null) break;
                    lVar16 = *(int64 *)(lVar16 + 32);
                    lVar17 = FUN_18046c0a0(0);
                    if (((((lVar17 == null) || (*(int64 *)(lVar17 + 32) == 0)) ||
                         (lVar17 = WorldData.Player(*(int64 *)(lVar17 + 32),0)) == null) ||
                        ((*(int64 *)(lVar17 + 0x2f8) == 0 ||
                         (uVar6 = FUN_1800d6750(*(int64 *)(lVar17 + 0x2f8),plVar14,DAT_181d68270),
                         lVar16 == null)))) || (lVar16 = WorldData.GetHero(lVar16,uVar6,0)) == null)
                    break;
                    uVar24 = uVar24 & 0xffffffffffffff00;
                    HeroData.ChangePoisonInjury(lVar16,(float)iVar8,1,0,uVar24,0);
                    plVar14 = (int64 *)(uint64)((int)plVar14 + 1);
                  }
                }
              }
            }
          }
          goto LAB_180945405;
        case 10:
          lVar17 = FUN_18046c0a0(0);
          lVar12 = *(int64 *)(pStatics_ef00 + 0x4c8);
          if (lVar12 != null) {
            uVar6 = FUN_180d8cf10(0,*(uint32 *)(lVar12 + 24),0);
            if ((this.exploreMapData != null) && (lVar17 != null)) {
              uVar7 = 0;
              uVar9 = CONCAT44(uVar27,0xffffffff);
              local_98[0] = GameController.GenerateRandomItem
                                      (lVar17,uVar6,
                                       this.exploreMapData.exploreDifficulty * local_res10[0],0
                                       ,in_stack_fffffffffffffed8 & 0xffffffffffffff00,uVar9,0,0,0);
              uVar6 = (uint32)((uint64)uVar9 >> 32);
              lVar17 = FUN_18046c300(0);
              lVar12 = FUN_18046c0a0(0);
              if ((lVar12 != null) &&
                 ((*(int64 *)(lVar12 + 32) != 0 &&
                  (lVar12 = WorldData.Player(*(int64 *)(lVar12 + 32),0)) != null))) {
                uVar9 = *(uint64 *)(lVar12 + 104);
                if (lVar16._items != null) {
                  cVar3 = String.Contains(lVar16._items,"箱",0);
                  uVar18 = "{0}{1}发现了一个宝箱";
                  lVar12 = "";
                  if (!cVar3) {
                    lVar12 = String.Format("在{0}中",lVar16._items,0);
                  }
                  uVar9 = String.Format(uVar18,uVar9,lVar12,0);
                  if (((this.ExploreTileTypeDataBase != null) &&
                      (lVar16 = FUN_180002f80(this.ExploreTileTypeDataBase,uVar2,DAT_181d5ff78),
                      lVar16 != null)) &&
                     (uVar18 = String.Concat("探索_",lVar16._items,0), lVar17 != null
                     )) {
                    local_b8 = ZEXT816(0);
                    uVar24 = CONCAT44(uVar6,0x3f800000);
                    uVar26 = "Woosh";
                    InfoController.AddInfoTab
                              (lVar17,uVar9,"TileAtlas",uVar18,"Woosh",uVar24,
                               CONCAT44(uVar7,0x40a00000),local_b8,0);
                    uVar6 = (uint32)((uint64)uVar26 >> 32);
                    lVar16 = FUN_18046c0a0(0);
                    if (((lVar16 != null) && (*(int64 *)(lVar16 + 32) != 0)) &&
                       (lVar16 = WorldData.Player(*(int64 *)(lVar16 + 32),0)) != null) {
                      HeroData.GetItem(lVar16,local_98[0],1,1,CONCAT44(uVar6,1),
                                        uVar24 & 0xffffffffffffff00,0);
                      return;
                    }
                  }
                }
              }
            }
          }
          goto LAB_180945405;
        case 11:
          lVar17 = FUN_18046c440(0);
          uVar18 = "行至一处{0}时，\n突然窜出{1}道人影，将你的去路拦住！";
          uVar9 = lVar16._items;
          iVar8 = *(int *)(targetTileData + 64);
          uVar26 = "几";
          if (iVar8 != 0) {
            uVar26 = GlobalData.GetNumText(iVar8,0);
          }
          local_98[0] = String.Format(uVar18,uVar9,uVar26,0);
          lVar13 = il2cpp_internal(DAT_181d72a30);
          FUN_180f58a90(lVar13,DAT_181d7c250);
          uVar9 = "来战！;PlotStartFight;HardFight-ExploreRandomFightResult--{0}-{1}";
          lVar16 = "";
          lVar12 = "";
          if (*(int *)(targetTileData + 64) != 0) {
            local_88 = *(float *)(targetTileData + 60) * 0.5;
            lVar12 = Single.ToString(&local_88,0);
            lVar16 = "";
            if (*(int *)(targetTileData + 64) != 0) {
              lVar16 = Int32.ToString(targetTileData + 64,0);
            }
          }
          uVar9 = String.Format(uVar9,lVar12,lVar16,0);
          if (lVar13 == null) goto LAB_180945405;
          FUN_181827900(lVar13,uVar9,DAT_181d7c3d0);
          uVar9 = il2cpp_internal(DAT_181d7d2b0);
          SinglePlotData.ctor
                    (uVar9,local_98[0],lVar13,1,0,CONCAT44(uVar27,1),0,CONCAT44(uVar5,3),0,
                     in_stack_ffffffffffffff00 & 0xffffffffffffff00,"PlotImage/两人争斗",0,0,0,0);
          goto joined_r0x000180943f8a;
        case 12:
          lVar16 = *(int64 *)(lVar17 + 24);
          if (lVar16 != null) {
            if (lVar16.Count < 1) {
              lVar16 = FUN_18046c540(0);
              if (lVar16 == null) goto LAB_180945405;
              lVar16 = *(int64 *)(lVar16 + 64);
              lVar17 = FUN_18046c540(0);
              if (((lVar17 == null) || (*(int64 *)(lVar17 + 64) == 0)) ||
                 (uVar6 = FUN_180d8cf10(0,*(uint32 *)(*(int64 *)(lVar17 + 64) + 24),0),
                 lVar16 == null)) goto LAB_180945405;
              iVar8 = FUN_1800d6750(lVar16,uVar6,DAT_181d68270);
            }
            else {
              uVar6 = FUN_180d8cf10(0,lVar16.Count,0);
              fVar20 = (float)FUN_1800d6780(lVar16,uVar6,DAT_181d796d8);
              iVar8 = (int)fVar20;
            }
            lVar16 = FUN_18046c440(0);
            lVar17 = FUN_18046c540(0);
            if (((lVar17 != null) &&
                (lVar17 = RandomEventController.GetRandomEventDataBase(lVar17,iVar8,0)) != null) &&
               ((*(int64 *)(lVar17 + 120) != 0 &&
                (plVar10 = (int64 *)PlotData.Clone(*(int64 *)(lVar17 + 120),0), lVar16 != null)))) {
              if (plVar10 != (int64 *)0) {
              }
              PlotController.ChangePlot(lVar16,plVar14,0);
              return;
            }
          }
          goto LAB_180945405;
        default:
          goto switchD_1809411f8_caseD_d;
        case 14:
          lVar16 = FUN_18046c300(0);
          lVar17 = FUN_18046c0a0(0);
          if (((lVar17 != null) && (*(int64 *)(lVar17 + 32) != 0)) &&
             (lVar17 = WorldData.Player(*(int64 *)(lVar17 + 32),0)) != null) {
            uVar9 = String.Format("{0}一脚踏空落入暗道之中",*(uint64 *)(lVar17 + 104),0);
            if (((this.ExploreTileTypeDataBase != null) &&
                (lVar17 = FUN_180002f80(this.ExploreTileTypeDataBase,uVar2,DAT_181d5ff78)) != null)
               && (uVar18 = String.Concat("探索_",*(uint64 *)(lVar17 + 16),0), lVar16 != null))
            {
              local_b8 = ZEXT816(0);
              InfoController.AddInfoTab
                        (lVar16,uVar9,"TileAtlas",uVar18,"StateDown",CONCAT44(uVar27,0x3f800000),
                         CONCAT44(uVar6,0x40a00000),local_b8,0);
              lVar17 = il2cpp_internal(DAT_181d6f030);
              FUN_180f58a90(lVar17,DAT_181d678f8);
              lVar16 = this.gridPool;
              if (lVar16 != null) {
                lVar12 = 32;
                while (uVar5 = (uint32)plVar14, (int)uVar5 < lVar16.Count) {
                  if (lVar16 == null) goto LAB_180945405;
                  if (lVar16.Count <= uVar5) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  lVar16 = *(int64 *)(lVar12 + lVar16._items);
                  if (((lVar16 == null) ||
                      (lVar16 = GameObject.GetComponent(lVar16,DAT_181d9f5d0)) == null) ||
                     (lVar16.Count == null)) goto LAB_180945405;
                  iVar8 = *(int *)(lVar16.Count + 32);
                  if (((this.playerGrid == null) ||
                      (lVar16 = GameObject.GetComponent(this.playerGrid,DAT_181d9f5d0),
                      lVar16 == null)) || (lVar16.Count == null)) goto LAB_180945405;
                  local_c8[0] = (float)Mathf.Abs(iVar8 - *(int *)(lVar16.Count + 32),0)
                  ;
                  lVar16 = this.gridPool;
                  if (lVar16 == null) goto LAB_180945405;
                  if (lVar16.Count <= uVar5) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  lVar16 = *(int64 *)(lVar12 + lVar16._items);
                  if (((lVar16 == null) ||
                      (lVar16 = GameObject.GetComponent(lVar16,DAT_181d9f5d0)) == null) ||
                     (lVar16.Count == null)) goto LAB_180945405;
                  iVar8 = *(int *)(lVar16.Count + 36);
                  if (((this.playerGrid == null) ||
                      (lVar16 = GameObject.GetComponent(this.playerGrid,DAT_181d9f5d0),
                      lVar16 == null)) || (lVar16.Count == null)) goto LAB_180945405;
                  iVar8 = Mathf.Abs(iVar8 - *(int *)(lVar16.Count + 36),0);
                  lVar16 = this.gridPool;
                  iVar8 = iVar8 + (int)local_c8[0];
                  if (lVar16 == null) goto LAB_180945405;
                  if (lVar16.Count <= uVar5) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  if (((*(int64 *)(lVar12 + lVar16._items) == 0) ||
                      (lVar16 = GameObject.GetComponent()) == null) ||
                     (lVar16.Count == null)) goto LAB_180945405;
                  if (-1 < *(int *)(lVar16.Count + 56)) {
                    if ((((this.gridPool == null) ||
                         (lVar16 = FUN_180002f80(this.gridPool,plVar14,DAT_181d62178),
                         lVar16 == null)) || (lVar16 = GameObject.GetComponent(lVar16)) == null) ||
                       (lVar16.Count == null)) goto LAB_180945405;
                    if ((*(int *)(lVar16.Count + 48) == 0) && (iVar8 - 2U < 3)) {
                      if (lVar17 == null) goto LAB_180945405;
                      FUN_181814fa0(lVar17,plVar14,DAT_181d67a78);
                    }
                  }
                  lVar16 = this.gridPool;
                  plVar14 = (int64 *)(uint64)(uVar5 + 1);
                  lVar12 = lVar12 + 8;
                  if (lVar16 == null) goto LAB_180945405;
                }
                if (lVar17 != null) {
                  if (*(int *)(lVar17 + 24) < 1) {
                    return;
                  }
                  if (this.playerSkeleton != null) {
                    uVar9 = Component.get_transform(this.playerSkeleton,0);
                    uVar9 = ShortcutExtensions.DOScale(uVar9,0);
                    uVar9 = TweenSettingsExtensions.SetLoops(uVar9,2,1,DAT_181d98060);
                    uVar9 = TweenSettingsExtensions.SetUpdate(uVar9,1,DAT_181d98af0);
                    TweenSettingsExtensions.SetEase(uVar9,9,DAT_181d97ca8);
                    lVar16 = this.gridPool;
                    uVar6 = FUN_180d8cf10(0,*(uint32 *)(lVar17 + 24),0);
                    uVar6 = FUN_1800d6750(lVar17,uVar6,DAT_181d68270);
                    if (lVar16 != null) {
                      lVar16 = FUN_180002f80(lVar16,uVar6,DAT_181d62178);
                      if (((lVar16 != null) &&
                          (lVar17 = GameObject.GetComponent(lVar16,DAT_181d9f5d0)) != null) &&
                         (*(int64 *)(lVar17 + 24) != 0)) {
                        uVar6 = *(uint32 *)(*(int64 *)(lVar17 + 24) + 36);
                        lVar16 = GameObject.GetComponent(lVar16,DAT_181d9f5d0);
                        if ((lVar16 != null) && (lVar16.Count != null)) {
                          ExploreController.PlayerEnterGrid
                                    (this,uVar6,*(uint32 *)(lVar16.Count + 32),0,
                                     0);
                          return;
                        }
                      }
                    }
                  }
                }
              }
            }
          }
          goto LAB_180945405;
        case 15:
          lVar17 = *(int64 *)(lVar17 + 24);
          if (lVar17 != null) {
            if (*(int *)(lVar17 + 24) == 0) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            pfVar1 = (float *)(*(int64 *)(lVar17 + 16) + 32);
            if (*pfVar1 <= 0.0 && *pfVar1 != 0.0) {
              lVar17 = FUN_18046c300(0);
              lVar12 = FUN_18046c0a0(0);
              if (((lVar12 == null) || (*(int64 *)(lVar12 + 32) == 0)) ||
                 (lVar12 = WorldData.Player(*(int64 *)(lVar12 + 32),0)) == null) break;
              uVar9 = String.Format("{0}在{1}中发现了疗伤药草",*(uint64 *)(lVar12 + 104),
                                     lVar16._items,0);
              if ((this.ExploreTileTypeDataBase == null) ||
                 (lVar16 = FUN_180002f80(this.ExploreTileTypeDataBase,uVar2,DAT_181d5ff78)) == null)
              break;
              uVar18 = String.Concat("探索_",lVar16._items,0);
              uVar24 = "BuffGood";
            }
            else {
              lVar17 = FUN_18046c300(0);
              lVar12 = FUN_18046c0a0(0);
              if (((lVar12 == null) || (*(int64 *)(lVar12 + 32) == 0)) ||
                 (lVar12 = WorldData.Player(*(int64 *)(lVar12 + 32),0)) == null) break;
              uVar9 = String.Format("{0}在{1}中误触陷阱，身负外伤",*(uint64 *)(lVar12 + 104),
                                     lVar16._items,0);
              if ((this.ExploreTileTypeDataBase == null) ||
                 (lVar16 = FUN_180002f80(this.ExploreTileTypeDataBase,uVar2,DAT_181d5ff78)) == null)
              break;
              uVar18 = String.Concat("探索_",lVar16._items,0);
              uVar24 = "StateDown";
            }
            if (lVar17 != null) {
              local_b8._0_12_ = ZEXT812(0);
              local_b8._12_4_ = 0;
              InfoController.AddInfoTab
                        (lVar17,uVar9,"TileAtlas",uVar18,uVar24,CONCAT44(uVar27,0x3f800000),
                         CONCAT44(uVar6,0x40a00000),local_b8,0);
              if (this.exploreMapData != null) {
                if (0.0 <= local_res10[0]) {
                  lVar16 = FUN_18046c0a0(0);
                  if ((lVar16 == null) || (*(int64 *)(lVar16 + 32) == 0)) break;
                }
                iVar8 = Mathf.RoundToInt();
                lVar16 = FUN_18046c0a0(0);
                if (((lVar16 != null) && (*(int64 *)(lVar16 + 32) != 0)) &&
                   (lVar16 = WorldData.Player(*(int64 *)(lVar16 + 32),0)) != null) {
                  uVar24 = uVar24 & 0xffffffffffffff00;
                  HeroData.ChangeExternalInjury(lVar16,(float)iVar8,1,0,uVar24,0);
                  while( true ) {
                    if ((((*pStatics_df90 == 0) ||
                         (lVar16 = *(int64 *)(*pStatics_df90 + 32),
                         lVar16 == null)) || (lVar16 = WorldData.Player(lVar16,0)) == null) ||
                       (*(int64 *)(lVar16 + 0x2f8) == 0)) break;
                    if (*(int *)(*(int64 *)(lVar16 + 0x2f8) + 24) <= (int)plVar14) {
                      return;
                    }
                    lVar16 = FUN_18046c0a0(0);
                    if (lVar16 == null) break;
                    lVar16 = *(int64 *)(lVar16 + 32);
                    lVar17 = FUN_18046c0a0(0);
                    if (((lVar17 == null) || (*(int64 *)(lVar17 + 32) == 0)) ||
                       ((lVar17 = WorldData.Player(*(int64 *)(lVar17 + 32),0), lVar17 == null ||
                        (((*(int64 *)(lVar17 + 0x2f8) == 0 ||
                          (uVar6 = FUN_1800d6750(*(int64 *)(lVar17 + 0x2f8),plVar14,DAT_181d68270),
                          lVar16 == null)) || (lVar16 = WorldData.GetHero(lVar16,uVar6,0)) == null)))))
                    break;
                    uVar24 = uVar24 & 0xffffffffffffff00;
                    HeroData.ChangeExternalInjury(lVar16,(float)iVar8,1,0,uVar24,0);
                    plVar14 = (int64 *)(uint64)((int)plVar14 + 1);
                  }
                }
              }
            }
          }
          break;
        case 16:
          lVar16 = FUN_18046c300(0);
          lVar17 = FUN_18046c0a0(0);
          if (((lVar17 != null) && (*(int64 *)(lVar17 + 32) != 0)) &&
             (lVar17 = WorldData.Player(*(int64 *)(lVar17 + 32),0)) != null) {
            uVar9 = *(uint64 *)(lVar17 + 104);
            local_c8[0] = (float)Mathf.RoundToInt();
            uVar18 = il2cpp_value_box(DAT_181d5b2f8,local_c8);
            uVar9 = String.Format("{0}获得了{1}把钥匙",uVar9,uVar18,0);
            if (((this.ExploreTileTypeDataBase != null) &&
                (lVar17 = FUN_180002f80(this.ExploreTileTypeDataBase,uVar2,DAT_181d5ff78)) != null)
               && (uVar18 = String.Concat("探索_",*(uint64 *)(lVar17 + 16),0), lVar16 != null))
            {
              local_b8 = ZEXT816(0);
              InfoController.AddInfoTab
                        (lVar16,uVar9,"TileAtlas",uVar18,"Ding",CONCAT44(uVar27,0x3f800000),
                         CONCAT44(uVar6,0x40a00000),local_b8,0);
              uVar6 = Mathf.RoundToInt();
              ExploreController.ChangeKeyNum(this,uVar6,0);
              return;
            }
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        case 17:
          lVar16 = *(int64 *)(lVar17 + 24);
          if (lVar16 == null) goto LAB_180945405;
          if (lVar16.Count < 1) {
            iVar8 = FUN_180d8cf10(0,2,0);
          }
          else {
            uVar6 = FUN_180d8cf10(0,lVar16.Count,0);
            fVar20 = (float)FUN_1800d6780(lVar16,uVar6,DAT_181d796d8);
            iVar8 = (int)fVar20;
          }
          if (iVar8 == 0) {
            lVar17 = FUN_18046c440(0);
            lVar16 = il2cpp_internal(DAT_181d72a30);
            FUN_180f58a90(lVar16,DAT_181d7c250);
            if (this.exploreMapData == null) goto LAB_180945405;
            local_res20[0] =
                 Mathf.RoundToInt(this.exploreMapData.exploreDifficulty * 20.0 + 20.0,0);
            uVar9 = Int32.ToString(local_res20,0);
            uVar9 = String.Concat("了解周遭情况;ExploreWildPeopleSeePlot;0;0/",uVar9,0);
            if (lVar16 == null) goto LAB_180945405;
            FUN_181827900(lVar16,uVar9,DAT_181d7c3d0);
            if (this.exploreMapData == null) goto LAB_180945405;
            local_res20[0] =
                 Mathf.RoundToInt(this.exploreMapData.exploreDifficulty * 10.0 + 10.0,0);
            uVar9 = Int32.ToString(local_res20,0);
            uVar9 = String.Concat("了解远处情况;ExploreWildPeopleSeePlot;1;0/",uVar9,0);
            FUN_181827900(lVar16,uVar9,DAT_181d7c3d0);
            FUN_181827900(lVar16,"告辞;HideInteractUI",DAT_181d7c3d0);
            lVar12 = FUN_18046c440(0);
            if (lVar12 == null) goto LAB_180945405;
            uVar6 = 0;
            uVar26 = PlotController.GenerateEventNPCString
                               (lVar12,"猎户",0xfffffffc,0xffffffff,
                                in_stack_fffffffffffffed8 & 0xffffffff00000000,0);
            uVar9 = il2cpp_internal(DAT_181d7d2b0);
            uVar18 = "大侠神色匆匆，面露疑惑的样子，想必是迷路了吧。\n小的是此地的猎户，对附近地形熟悉的很。\n大侠若是愿意花上几两银子，小的便把此处地形如实相告，不知意下如何？";
          }
          else {
            if (iVar8 != 1) {
              return;
            }
            lVar17 = FUN_18046c440(0);
            lVar16 = il2cpp_internal(DAT_181d72a30);
            FUN_180f58a90(lVar16,DAT_181d7c250);
            if (this.exploreMapData == null) goto LAB_180945405;
            local_res20[0] =
                 Mathf.RoundToInt(this.exploreMapData.exploreDifficulty * 20.0 + 20.0,0);
            uVar9 = Int32.ToString(local_res20,0);
            uVar9 = String.Concat("充分休息;ExploreWildPeopleRestPlot;0;0/",uVar9,0);
            if (lVar16 == null) goto LAB_180945405;
            FUN_181827900(lVar16,uVar9,DAT_181d7c3d0);
            if (this.exploreMapData == null) goto LAB_180945405;
            local_res20[0] =
                 Mathf.RoundToInt(this.exploreMapData.exploreDifficulty * 10.0 + 10.0,0);
            uVar9 = Int32.ToString(local_res20,0);
            uVar9 = String.Concat("稍作休息;ExploreWildPeopleRestPlot;1;0/",uVar9,0);
            FUN_181827900(lVar16,uVar9,DAT_181d7c3d0);
            FUN_181827900(lVar16,"告辞;HideInteractUI",DAT_181d7c3d0);
            lVar12 = FUN_18046c440(0);
            if (lVar12 == null) goto LAB_180945405;
            uVar6 = 0;
            uVar26 = PlotController.GenerateEventNPCString
                               (lVar12,"农户",0xfffffffe,0xffffffff,
                                in_stack_fffffffffffffed8 & 0xffffffff00000000,0);
            uVar9 = il2cpp_internal(DAT_181d7d2b0);
            uVar18 = "大侠风尘仆仆，匆忙赶路的样子，想必是劳累了吧。\n小的是此地的农户，住处恰好就在这附近。\n大侠若是愿意花上几两银子，便能租用床位休憩一番，不知意下如何？";
          }
          SinglePlotData.ctor
                    (uVar9,uVar18,lVar16,5,uVar26,CONCAT44(uVar6,3),"0",(uint64)uVar5 << 32
                     ,0,in_stack_ffffffffffffff00 & 0xffffffffffffff00,"PlotImage/未知路人",0,0,0,0);
        joined_r0x000180943f8a:
          if (lVar17 == null) goto LAB_180945405;
          goto LAB_180943f96;
        case 18:
          lVar17 = FUN_18046c440(0);
          if (this.exploreMapData == null) {
        LAB_180945461:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          local_c8[0] = (float)Mathf.CeilToInt(this.exploreMapData.exploreDifficulty * 0.5 +
                                                2.0,0);
          uVar9 = il2cpp_value_box(DAT_181d5b2f8,local_c8);
          uVar18 = String.Format("这堆遗迹骨骸看似平平无奇，却似乎有几件古董掩埋其中。\n只可惜眼下时间和精力有限，就选择其中一件进行挖掘好了。\n(进行挖掘将消耗{0}点耐力)",uVar9,0);
          lVar16 = il2cpp_internal(DAT_181d72a30);
          FUN_180f58a90(lVar16,DAT_181d7c250);
          plVar14 = (int64 *)FUN_1800d60b0(DAT_181d80cc0,5);
          if (plVar14 == (int64 *)0) goto LAB_180945461;
          if (("选择挖掘;ChooseDigTreasure;" != 0) &&
             (lVar12 = il2cpp_internal("选择挖掘;ChooseDigTreasure;",*(uint64 *)(*plVar14 + 64))) == null)
          {
            uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar9,0);
          }
          FUN_180002fd0(plVar14,0,"选择挖掘;ChooseDigTreasure;");
          lVar12 = Single.ToString(local_res10,0);
          if ((lVar12 != null) &&
             (lVar13 = il2cpp_internal(lVar12,*(uint64 *)(*plVar14 + 64))) == null) {
            uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar9,0);
          }
          FUN_180002fd0(plVar14,1,lVar12);
          if (("-0.3-" != 0) &&
             (lVar12 = il2cpp_internal("-0.3-",*(uint64 *)(*plVar14 + 64))) == null)
          {
            uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar9,0);
          }
          FUN_180002fd0(plVar14,2,"-0.3-");
          local_res20[0] = 4;
          lVar12 = Int32.ToString(local_res20,0);
          if ((lVar12 != null) &&
             (lVar13 = il2cpp_internal(lVar12,*(uint64 *)(*plVar14 + 64))) == null) {
            uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar9,0);
          }
          FUN_180002fd0(plVar14,3,lVar12);
          if (("-false-0.35" != 0) &&
             (lVar12 = il2cpp_internal("-false-0.35",*(uint64 *)(*plVar14 + 64))) == null)
          {
            uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar9,0);
          }
          FUN_180002fd0(plVar14,4,"-false-0.35");
          uVar9 = String.Concat(plVar14,0);
          if (lVar16 == null) goto LAB_180945461;
          FUN_181827900(lVar16,uVar9,DAT_181d7c3d0);
          FUN_181827900(lVar16,"毫无兴趣;HideInteractUI",DAT_181d7c3d0);
          uVar9 = il2cpp_internal(DAT_181d7d2b0);
          SinglePlotData.ctor
                    (uVar9,uVar18,lVar16,1,0,CONCAT44(uVar27,3),"0",CONCAT44(uVar5,1),0,
                     in_stack_ffffffffffffff00 & 0xffffffffffffff00,"PlotImage/古董发掘",0,0,0,0);
          if (lVar17 == null) goto LAB_180945461;
          goto LAB_180943f96;
        case 19:
          lVar17 = FUN_18046c440(0);
          local_c8[0] = (float)ExploreController.GetOpenLockCost(this,0);
          uVar9 = il2cpp_value_box(DAT_181d5b2f8,local_c8);
          uVar18 = String.Format("这宝箱上有一个颇为坚固的铁锁，可以用这迷宫内找到的钥匙打开，\n实在不行也能用蛮力砸开，就是得耗上额外的时间与精力。\n(暴力破解将消耗{0}点耐力)",uVar9,0);
          lVar16 = il2cpp_internal(DAT_181d72a30);
          FUN_180f58a90(lVar16,DAT_181d7c250);
          if (lVar16 == null) {
        LAB_180945467:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          FUN_181827900(lVar16,"使用钥匙;OpenLockChest;0",DAT_181d7c3d0);
          FUN_181827900(lVar16,"暴力破解;OpenLockChest;1",DAT_181d7c3d0);
          FUN_181827900(lVar16,"还是算了;HideInteractUI",DAT_181d7c3d0);
          uVar9 = il2cpp_internal(DAT_181d7d2b0);
          SinglePlotData.ctor
                    (uVar9,uVar18,lVar16,1,0,CONCAT44(uVar27,3),"0",CONCAT44(uVar5,1),0,
                     in_stack_ffffffffffffff00 & 0xffffffffffffff00,"PlotImage/上锁宝箱",0,0,0,0);
          if (lVar17 == null) goto LAB_180945467;
          goto LAB_180943f96;
        case 20:
          lVar17 = FUN_18046c440(0);
          lVar16 = *(int64 *)(pStatics_ef00 + 0x430);
          if (lVar16 == null) {
        LAB_18094546d:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          uVar9 = FUN_180002f80(lVar16,*(uint32 *)(targetTileData + 68),DAT_181d7c9c0);
          if (this.exploreMapData == null) goto LAB_18094546d;
          local_c8[0] = (float)Mathf.CeilToInt(this.exploreMapData.exploreDifficulty * 0.25 +
                                                2.0,0);
          uVar18 = il2cpp_value_box(DAT_181d5b2f8,local_c8);
          uVar9 = String.Format("此处有一些{0}资源可供采集。\n若是有余力的话，还可从中精挑细选获取制造材料。\n(进行采集将消耗{1}点耐力)",uVar9,uVar18,0);
          local_b8._0_8_ = uVar9;
          lVar12 = il2cpp_internal(DAT_181d72a30);
          FUN_180f58a90(lVar12,DAT_181d7c250);
          local_84[0] = *(uint32 *)(targetTileData + 68);
          uVar9 = il2cpp_value_box(DAT_181d5b2f8,local_84);
          lVar16 = *(int64 *)(pStatics_ef00 + 0x438);
          if (lVar16 == null) goto LAB_18094546d;
          uVar2 = *(uint32 *)(targetTileData + 68);
          if (lVar16.Count <= uVar2) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          local_a4 = lVar16._items[uVar2];
          uVar18 = il2cpp_value_box(DAT_181d61070,&local_a4);
          lVar16 = FUN_18046c440(0);
          if (lVar16 == null) goto LAB_18094546d;
          local_a0[0] = PlotController.GetNowEventSkillNumNeed(lVar16,0x3f666666,0);
          uVar26 = il2cpp_value_box(DAT_181d5b2f8,local_a0);
          uVar9 = String.Format("精挑细选;ChooseCollectResource;0-{0};;;{1}/{2}",uVar9,uVar18,uVar26,0);
          if (lVar12 == null) goto LAB_18094546d;
          FUN_181827900(lVar12,uVar9,DAT_181d7c3d0);
          lVar16 = *(int64 *)(pStatics_ef00 + 0x430);
          if (lVar16 == null) goto LAB_18094546d;
          uVar9 = FUN_180002f80(lVar16,*(uint32 *)(targetTileData + 68),DAT_181d7c9c0);
          local_98[0] = CONCAT44(local_98[0]._4_4_,*(uint32 *)(targetTileData + 68));
          uVar18 = il2cpp_value_box(DAT_181d5b2f8,local_98);
          uVar9 = String.Format("采集{0};ChooseCollectResource;1-{1}",uVar9,uVar18,0);
          FUN_181827900(lVar12,uVar9,DAT_181d7c3d0);
          FUN_181827900(lVar12,"毫无兴趣;HideInteractUI",DAT_181d7c3d0);
          uVar9 = il2cpp_internal(DAT_181d7d2b0);
          SinglePlotData.ctor
                    (uVar9,local_b8._0_8_,lVar12,1,0,CONCAT44(uVar27,3),"0",CONCAT44(uVar5,1),0,
                     in_stack_ffffffffffffff00 & 0xffffffffffffff00,"PlotImage/古董发掘",0,0,0,0);
          if (lVar17 == null) goto LAB_18094546d;
          goto LAB_180943f96;
        case 21:
          iVar8 = *(int *)(targetTileData + 68) + 3;
          lVar16 = new PlotData(0);
          if (local_res10[0] == 0.0) {
            lVar17 = FUN_18046c0a0(0);
            if ((lVar17 == null) || (*(int64 *)(lVar17 + 32) == 0)) {
        LAB_180945473:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            piVar15 = (int *)(*(int64 *)(lVar17 + 32) + 0x1cc);
            *piVar15 = *piVar15 + 1;
            lVar17 = FUN_18046c440(0);
            lVar12 = FUN_18046c0a0(0);
            lVar13 = FUN_18046c440(0);
            if (lVar13 == null) goto LAB_180945473;
            PlotController.GetNowEventDifficulty(lVar13,0);
            local_b8._0_8_ = this.seedRandomSpe;
            GlobalData.RandomRange();
            uVar6 = Mathf.RoundToInt();
            if (lVar12 == null) goto LAB_180945473;
            uVar9 = this.seedRandomSpe;
            uVar26 = 0;
            uVar18 = GameController.GenerateBookSkillType(lVar12,uVar6);
            if (lVar17 == null) goto LAB_180945473;
            PlotController.SetPlotItem(lVar17,uVar18,1,0,uVar9,uVar26);
            uVar6 = (uint32)((uint64)uVar26 >> 32);
            if (lVar16 == null) goto LAB_180945473;
            lVar17 = *(int64 *)(lVar16 + 64);
            lVar12 = *(int64 *)(pStatics_ef00 + 0x180);
            if (lVar12 == null) goto LAB_180945473;
            uVar9 = FUN_180002f80(lVar12,*(uint32 *)(targetTileData + 68),DAT_181d7c9c0);
            lVar12 = *(int64 *)(pStatics_ef00 + 0x498);
            if (lVar12 == null) goto LAB_180945473;
            uVar18 = FUN_180002f80(lVar12,iVar8,DAT_181d7c9c0);
            uVar9 = String.Format("阁下难道就是......传说中的绝世高手，{0}？！\n江湖传闻，您老人家的{1}功夫出神入化，天下无敌。\n今日竟能得见前辈真容，当真是三生有幸！",uVar9,uVar18,0);
            lVar12 = *(int64 *)(pStatics_ef00 + 0x180);
            if (lVar12 == null) goto LAB_180945473;
            uVar18 = FUN_180002f80(lVar12,*(uint32 *)(targetTileData + 68),DAT_181d7c9c0);
            uVar26 = il2cpp_internal(DAT_181d7d2b0);
            uVar25 = CONCAT44(uVar5,1);
            uVar24 = CONCAT44(uVar6,3);
            SinglePlotData.ctor(uVar26,uVar9,0,5,uVar18,uVar24,"0",uVar25,0,0);
            if (lVar17 == null) goto LAB_180945473;
            FUN_181827900(lVar17,uVar26,DAT_181d79a58);
            lVar17 = *(int64 *)(lVar16 + 64);
            uVar9 = FUN_180004500(DAT_181d63120);
            uVar9 = String.Format("哼哼，皆是些虚名而已。\n不过能在这荒山野岭相遇，你我也算有些缘分。",uVar9,0);
            uVar18 = il2cpp_internal(DAT_181d7d2b0);
            uVar25 = uVar25 & 0xffffffff00000000;
            uVar24 = uVar24 & 0xffffffff00000000;
            SinglePlotData.ctor(uVar18,uVar9,0,0,0,uVar24,0,uVar25,0,0);
            if (lVar17 == null) goto LAB_180945473;
            FUN_181827900(lVar17,uVar18,DAT_181d79a58);
            lVar17 = *(int64 *)(lVar16 + 64);
            lVar12 = FUN_18046c440(0);
            if (lVar12 == null) goto LAB_180945473;
            uVar6 = PlotController.GetEventMaxFightSkill(lVar12,0x3f800000,0);
            local_98[0] = CONCAT44(local_98[0]._4_4_,uVar6);
            uVar9 = il2cpp_value_box(DAT_181d5b2f8,local_98);
            lVar12 = *(int64 *)(pStatics_ef00 + 0x498);
            if (lVar12 == null) goto LAB_180945473;
            uVar18 = FUN_180002f80(lVar12,iVar8,DAT_181d7c9c0);
            uVar9 = String.Format("我正好在此参悟武学，你若{1}修为足够，就将此功学去便是。\n即便修为不足，也可参悟一些武学心得，提升{1}实力。\n({1}潜力小于{0}时，修习可增加3点潜力，否则只增加3点技能)",uVar9,uVar18,0);
            local_b8._0_8_ = uVar9;
            lVar12 = il2cpp_internal(DAT_181d72a30);
            FUN_180f58a90(lVar12,DAT_181d7c250);
            local_a8 = iVar8;
            plVar14 = (int64 *)il2cpp_value_box(DAT_181da1da0,&local_a8);
            if (plVar14 == (int64 *)0) goto LAB_180945473;
            uVar9 = (**(code **)(*plVar14 + 0x168))(plVar14,*(uint64 *)(*plVar14 + 0x170));
            piVar15 = (int *)il2cpp_object_unbox(plVar14);
            local_a8 = *piVar15;
            lVar13 = FUN_18046c440(0);
            if (lVar13 == null) goto LAB_180945473;
            local_a0[0] = PlotController.GetNowEventSkillNumNeed(lVar13,0x3f800000,0);
            uVar18 = il2cpp_value_box(DAT_181d5b2f8,local_a0);
            uVar9 = String.Format("请教功法;FindSpeMasterEvent;book;;;{0}/{1}",uVar9,uVar18,0);
            if (lVar12 == null) goto LAB_180945473;
            FUN_181827900(lVar12,uVar9,DAT_181d7c3d0);
            lVar13 = *(int64 *)(pStatics_ef00 + 0x498);
            if (lVar13 == null) goto LAB_180945473;
            uVar9 = FUN_180002f80(lVar13,iVar8,DAT_181d7c9c0);
            local_a4 = iVar8;
            uVar18 = il2cpp_value_box(DAT_181d5b2f8,&local_a4);
            uVar9 = String.Format("请教{0}潜力;FindSpeMasterEvent;{1}",uVar9,uVar18,0);
            FUN_181827900(lVar12,uVar9,DAT_181d7c3d0);
            uVar9 = il2cpp_internal(DAT_181d7d2b0);
            SinglePlotData.ctor
                      (uVar9,local_b8._0_8_,lVar12,0,0,uVar24 & 0xffffffff00000000,0,
                       uVar25 & 0xffffffff00000000,0,0);
            if (lVar17 == null) goto LAB_180945473;
          }
          else {
            lVar17 = FUN_18046c0a0(0);
            if ((lVar17 == null) || (*(int64 *)(lVar17 + 32) == 0)) {
        LAB_180945479:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            piVar15 = (int *)(*(int64 *)(lVar17 + 32) + 0x1c8);
            *piVar15 = *piVar15 + 1;
            lVar17 = FUN_18046c440(0);
            lVar12 = FUN_18046c0a0(0);
            lVar13 = FUN_18046c440(0);
            if (lVar13 == null) goto LAB_180945479;
            fVar20 = (float)PlotController.GetNowEventDifficulty(lVar13,0);
            local_b8._0_8_ = this.seedRandomSpe;
            auVar22._0_8_ = GlobalData.RandomRange();
            auVar22._8_8_ = extraout_XMM0_Qb;
            auVar23._4_12_ = auVar22._4_12_;
            auVar23._0_4_ = (float)auVar22._0_8_ * fVar20;
            uVar6 = Mathf.RoundToInt(auVar23._0_8_,0);
            if (lVar12 == null) goto LAB_180945479;
            uVar9 = this.seedRandomSpe;
            uVar26 = 0;
            uVar18 = GameController.GenerateBookSkillType(lVar12,uVar6);
            if (lVar17 == null) goto LAB_180945479;
            PlotController.SetPlotItem(lVar17,uVar18,1,0,uVar9,uVar26);
            uVar6 = (uint32)((uint64)uVar26 >> 32);
            if (lVar16 == null) goto LAB_180945479;
            lVar17 = *(int64 *)(lVar16 + 64);
            lVar12 = *(int64 *)(pStatics_ef00 + 0x180);
            if (lVar12 == null) goto LAB_180945479;
            uVar9 = FUN_180002f80(lVar12,*(uint32 *)(targetTileData + 68),DAT_181d7c9c0);
            lVar12 = *(int64 *)(pStatics_ef00 + 0x498);
            if (lVar12 == null) goto LAB_180945479;
            uVar18 = FUN_180002f80(lVar12,iVar8,DAT_181d7c9c0);
            uVar9 = String.Format("今天真是走大运了，这石碑似乎乃前辈{0}所留！\n传闻此人{1}功夫天下无双，我若能参悟这石碑上所刻心法，定会大有裨益！",uVar9,uVar18,0);
            uVar18 = il2cpp_internal(DAT_181d7d2b0);
            uVar28 = CONCAT44(uVar5,1);
            uVar26 = CONCAT44(uVar6,3);
            SinglePlotData.ctor
                      (uVar18,uVar9,0,1,0,uVar26,"0",uVar28,0,
                       in_stack_ffffffffffffff00 & 0xffffffffffffff00,"PlotImage/神秘石碑",0,0,0,0);
            uVar6 = (uint32)((uint64)uVar26 >> 32);
            uVar27 = (uint32)((uint64)uVar28 >> 32);
            if (lVar17 == null) goto LAB_180945479;
            FUN_181827900(lVar17,uVar18,DAT_181d79a58);
            lVar17 = *(int64 *)(lVar16 + 64);
            lVar12 = FUN_18046c440(0);
            if (lVar12 == null) goto LAB_180945479;
            uVar7 = PlotController.GetEventMaxFightSkill(lVar12,0x3f800000,0);
            local_98[0] = CONCAT44(local_98[0]._4_4_,uVar7);
            uVar9 = il2cpp_value_box(DAT_181d5b2f8,local_98);
            lVar12 = *(int64 *)(pStatics_ef00 + 0x498);
            if (lVar12 == null) goto LAB_180945479;
            uVar18 = FUN_180002f80(lVar12,iVar8,DAT_181d7c9c0);
            uVar9 = String.Format("若我{1}修为足够，便可抄录上面所刻功法。\n即便修为不足，也可参悟一些武学心得，提升{1}实力。\n({1}潜力小于{0}时，修习可增加1点潜力，否则只增加1点技能)",uVar9,uVar18,0);
            local_b8._0_8_ = uVar9;
            lVar12 = il2cpp_internal(DAT_181d72a30);
            FUN_180f58a90(lVar12,DAT_181d7c250);
            local_a8 = iVar8;
            plVar14 = (int64 *)il2cpp_value_box(DAT_181da1da0,&local_a8);
            if (plVar14 == (int64 *)0) goto LAB_180945479;
            uVar9 = (**(code **)(*plVar14 + 0x168))(plVar14,*(uint64 *)(*plVar14 + 0x170));
            piVar15 = (int *)il2cpp_object_unbox(plVar14);
            local_a8 = *piVar15;
            lVar13 = FUN_18046c440(0);
            if (lVar13 == null) goto LAB_180945479;
            local_a0[0] = PlotController.GetNowEventSkillNumNeed(lVar13,0x3f4ccccd,0);
            uVar18 = il2cpp_value_box(DAT_181d5b2f8,local_a0);
            uVar9 = String.Format("抄录功法;FindSpeMasterSteleEvent;book;;;{0}/{1}",uVar9,uVar18,0);
            if (lVar12 == null) goto LAB_180945479;
            FUN_181827900(lVar12,uVar9,DAT_181d7c3d0);
            lVar13 = *(int64 *)(pStatics_ef00 + 0x498);
            if (lVar13 == null) goto LAB_180945479;
            uVar9 = FUN_180002f80(lVar13,iVar8,DAT_181d7c9c0);
            local_a4 = iVar8;
            uVar18 = il2cpp_value_box(DAT_181d5b2f8,&local_a4);
            uVar9 = String.Format("修习{0}潜力;FindSpeMasterSteleEvent;{1}",uVar9,uVar18,0);
            FUN_181827900(lVar12,uVar9,DAT_181d7c3d0);
            uVar9 = il2cpp_internal(DAT_181d7d2b0);
            SinglePlotData.ctor
                      (uVar9,local_b8._0_8_,lVar12,1,0,CONCAT44(uVar6,3),"0",CONCAT44(uVar27,1),
                       0,0);
            if (lVar17 == null) goto LAB_180945479;
          }
          FUN_181827900(lVar17,uVar9,DAT_181d79a58);
          lVar17 = FUN_18046c440(0);
          if (lVar17 != null) {
            PlotController.ChangePlot(lVar17,lVar16,0);
            return;
          }
        LAB_180945405:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        case 22:
          if (this.exploreMapData == null) {
        LAB_18094547f:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          iVar8 = Mathf.RoundToInt(this.exploreMapData.exploreDifficulty * 0.5,0);
          lVar16 = FUN_18046c0a0(0);
          if ((lVar16 == null) || (*(int64 *)(lVar16 + 32) == 0)) goto LAB_18094547f;
          WorldData.ChangeSpeEnhanceStoneNum(*(int64 *)(lVar16 + 32),iVar8 + 1,1,0);
          lVar17 = FUN_18046c440(0);
          local_98[0] = CONCAT44(local_98[0]._4_4_,iVar8 + 1);
          uVar9 = il2cpp_value_box(DAT_181d5b2f8,local_98);
          uVar18 = String.Format("在地磁干扰中心地带，果然发现了{0}枚世间罕见的陨铁矿石！\n在本门<b>剑池</b>之中，可使用陨铁对装备进行额外强化。",uVar9,0);
          uVar9 = il2cpp_internal(DAT_181d7d2b0);
          SinglePlotData.ctor
                    (uVar9,uVar18,0,1,0,CONCAT44(uVar27,3),"0",CONCAT44(uVar5,1),0,
                     in_stack_ffffffffffffff00 & 0xffffffffffffff00,"PlotImage/古董发掘",0,0,0,0);
          if (lVar17 == null) goto LAB_18094547f;
        LAB_180943f96:
          PlotController.ChangePlot(lVar17,uVar9,0);
        switchD_1809411f8_caseD_d:
          return;
        }
    }

    // Token : 0x60013F0
    // RVA   : 0x93F7C0   Offset: 0x93DFC0   Length: 0x32
    public int GetCollectResourceCost()
    {
        if (this.exploreMapData != null) {
          Mathf.CeilToInt(this.exploreMapData.exploreDifficulty * 0.25 + 2.0,0);
          return;
        }
    }

    // Token : 0x60013F1
    // RVA   : 0x93F800   Offset: 0x93E000   Length: 0x32
    public int GetDigTreasureCost()
    {
        if (this.exploreMapData != null) {
          Mathf.CeilToInt(this.exploreMapData.exploreDifficulty * 0.5 + 2.0,0);
          return;
        }
    }

    // Token : 0x60013F2
    // RVA   : 0x93F840   Offset: 0x93E040   Length: 0x32
    public int GetOpenLockCost()
    {
        if (this.exploreMapData != null) {
          Mathf.CeilToInt(this.exploreMapData.exploreDifficulty * 0.25 + 3.0,0);
          return;
        }
    }

    // Token : 0x60013F3
    // RVA   : 0x939220   Offset: 0x937A20   Length: 0x381
    public void ChangeKeyNum(int changeNum)
    {
        var pStatics = *(int64*)(DAT_181d4ef00 + 184);
        uint uVar2;
        ulong uVar3;
        long lVar4;
        long lVar6;
        ulong uVar7;
        uint uVar8;
        uint uVar9;
        uint uVar10;
        uint uVar11;
        int[] local_res10 = new int[2];
        ulong local_38;
        uint local_30;
        uint local_28;
        uint uStack_24;
        uint uStack_20;
        uint32 uStack_1c;
        local_res10[0] = changeNum;
        if (this.explorePanelData != null) {
          this.explorePanelData.keyNum = *piVar1 + local_res10[0];
          lVar6 = **(int64 **)(DAT_181d4df90 + 184);
          uVar3 = Int32.ToString(local_res10,"+0;-0;0",0);
          uVar3 = String.Concat("钥匙",uVar3,0);
          if ((this.playerSkeleton != null) &&
             (lVar4 = Component.get_transform(this.playerSkeleton,0)) != null) {
            puVar5 = (uint64 *)Transform.get_position(&local_38,lVar4,0);
            uVar7 = *puVar5;
            uVar2 = *(uint32 *)(puVar5 + 1);
            if (local_res10[0] < 1) {
              lVar4 = pStatics;
              uVar8 = *(uint32 *)(lVar4 + 0x2e8);
              uVar9 = *(uint32 *)(lVar4 + 0x2ec);
              uVar10 = *(uint32 *)(lVar4 + 0x2f0);
              uVar11 = *(uint32 *)(lVar4 + 0x2f4);
            }
            else {
              lVar4 = pStatics;
              uVar8 = *(uint32 *)(lVar4 + 0x280);
              uVar9 = *(uint32 *)(lVar4 + 0x284);
              uVar10 = *(uint32 *)(lVar4 + 0x288);
              uVar11 = *(uint32 *)(lVar4 + 0x28c);
            }
            if (lVar6 != null) {
              local_38 = uVar7;
              local_30 = uVar2;
              local_28 = uVar8;
              uStack_24 = uVar9;
              uStack_20 = uVar10;
              uStack_1c = uVar11;
              GameController.ShowTextAtPos(lVar6,uVar3,&local_38,20,&local_28,0);
              if (this.explorePanelData != null) {
                lVar6 = this.exploreUIPanel;
                if (this.explorePanelData.keyNum < 1) {
                  if ((lVar6 != null) && (lVar6 = GameObject.get_transform(lVar6,0)) != null) {
                    lVar6 = Transform.Find(lVar6,"KeyNum",0);
                    puVar5 = (uint64 *)Vector3.get_zero(&local_28,0);
                    if (lVar6 != null) {
                      local_30 = *(uint32 *)(puVar5 + 1);
                      local_38 = *puVar5;
                      Transform.set_localScale(lVar6,&local_38,0);
                      return;
                    }
                  }
                }
                else if ((lVar6 != null) && (lVar6 = GameObject.get_transform(lVar6,0)) != null) {
                  lVar6 = Transform.Find(lVar6,"KeyNum",0);
                  puVar5 = (uint64 *)Vector3.get_one(&local_28,0);
                  if (lVar6 != null) {
                    local_30 = *(uint32 *)(puVar5 + 1);
                    local_38 = *puVar5;
                    Transform.set_localScale(lVar6,&local_38,0);
                    if (((this.exploreUIPanel != null) &&
                        (lVar6 = GameObject.get_transform(this.exploreUIPanel,0)) != null)
                       && (lVar6 = Transform.Find(lVar6,"KeyNum",0)) != null) {
                      uVar3 = Component.GetComponent(lVar6,DAT_181d6d8c0);
                      if (this.explorePanelData != null) {
                        uVar7 = Int32.ToString(this.explorePanelData + 80,0);
                        LTLocalization.SetText(uVar3,uVar7,0);
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

    // Token : 0x60013F4
    // RVA   : 0x9491A0   Offset: 0x9479A0   Length: 0x371
    public void WatchRoundTile(int range)
    {
        bool cVar1;
        int iVar2;
        int iVar3;
        ulong uVar4;
        long lVar5;
        uint uVar6;
        long lVar7;
        int[] local_res10 = new int[2];
        ulong local_28;
        ulong uStack_20;
        lVar5 = **(int64 **)(DAT_181d5a578 + 184);
        local_res10[0] = range;
        uVar4 = il2cpp_value_box(DAT_181d5b2f8,local_res10);
        uVar4 = String.Format("探查了{0}格周边地块",uVar4,0);
        if (lVar5 == null) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620(0,uVar4);
        }
        uVar6 = 0;
        local_28 = 0;
        uStack_20 = 0;
        InfoController.AddInfoTab
                  (lVar5,uVar4,"TileAtlas","探索_地图","Eagle",0x3f800000,0x40a00000,&local_28,0
                  );
        lVar5 = this.gridPool;
        if (lVar5 != null) {
          lVar7 = 32;
          do {
            if (lVar5.Count <= (int)uVar6) {
              return;
            }
            if (lVar5 == null) break;
            if (lVar5.Count <= uVar6) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar5 = *(int64 *)(lVar7 + lVar5._items);
            if ((lVar5 == null) || (lVar5 = GameObject.GetComponent(lVar5,DAT_181d9f5d0)) == null)
            break;
            cVar1 = ExploreTileUnitController.get_Seen(lVar5,0);
            if (!cVar1) {
              if ((((this.gridPool == null) ||
                   (lVar5 = FUN_180002f80(this.gridPool,uVar6,DAT_181d62178)) == null)
                  || (lVar5 = GameObject.GetComponent(lVar5,DAT_181d9f5d0)) == null) ||
                 (lVar5.Count == null)) break;
              iVar2 = *(int *)(lVar5.Count + 36);
              if (((this.playerGrid == null) ||
                  (lVar5 = GameObject.GetComponent(this.playerGrid,DAT_181d9f5d0),
                  lVar5 == null)) || (lVar5.Count == null)) break;
              iVar2 = Mathf.Abs(iVar2 - *(int *)(lVar5.Count + 36),0);
              if (((this.gridPool == null) ||
                  (lVar5 = FUN_180002f80(this.gridPool,uVar6,DAT_181d62178)) == null)
                 || ((lVar5 = GameObject.GetComponent(lVar5,DAT_181d9f5d0), lVar5 == null ||
                     (lVar5.Count == null)))) break;
              iVar3 = *(int *)(lVar5.Count + 32);
              if (((this.playerGrid == null) ||
                  (lVar5 = GameObject.GetComponent(this.playerGrid,DAT_181d9f5d0),
                  lVar5 == null)) || (lVar5.Count == null)) break;
              iVar3 = Mathf.Abs(iVar3 - *(int *)(lVar5.Count + 32),0);
              if (iVar3 + iVar2 <= range) {
                if (((this.gridPool == null) ||
                    (lVar5 = FUN_180002f80(this.gridPool,uVar6,DAT_181d62178)) == null
                    ) || (lVar5 = GameObject.GetComponent(lVar5,DAT_181d9f5d0)) == null) break;
                ExploreTileUnitController.set_Seen(lVar5,1,0);
              }
            }
            lVar5 = this.gridPool;
            uVar6 = uVar6 + 1;
            lVar7 = lVar7 + 8;
          } while (lVar5 != null);
        }
    }

    // Token : 0x60013F5
    // RVA   : 0x948E60   Offset: 0x947660   Length: 0x331
    public void WatchRandomTile(int num)
    {
        bool cVar1;
        ulong uVar2;
        long lVar3;
        long lVar4;
        uint uVar5;
        long lVar6;
        int[] local_res10 = new int[2];
        ulong local_28;
        ulong uStack_20;
        lVar4 = **(int64 **)(DAT_181d5a578 + 184);
        local_res10[0] = num;
        uVar2 = il2cpp_value_box(DAT_181d5b2f8,local_res10);
        uVar2 = String.Format("探查了{0}处地块",uVar2,0);
        if (lVar4 == null) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620(0,uVar2);
        }
        uVar5 = 0;
        local_28 = 0;
        uStack_20 = 0;
        InfoController.AddInfoTab
                  (lVar4,uVar2,"TileAtlas","探索_地图","Paper",0x3f800000,0x40a00000,&local_28,0
                  );
        lVar3 = il2cpp_internal(DAT_181d6f030);
        FUN_180f58a90(lVar3,DAT_181d678f8);
        lVar4 = this.gridPool;
        if (lVar4 != null) {
          lVar6 = 32;
          while( true ) {
            if (lVar4.Count <= (int)uVar5) goto joined_r0x0001809490c5;
            if (lVar4 == null) break;
            if (lVar4.Count <= uVar5) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar4 = *(int64 *)(lVar6 + lVar4._items);
            if ((lVar4 == null) || (lVar4 = GameObject.GetComponent(lVar4,DAT_181d9f5d0)) == null)
            break;
            cVar1 = ExploreTileUnitController.get_Seen(lVar4,0);
            if (!cVar1) {
              if (lVar3 == null) break;
              FUN_181814fa0(lVar3,uVar5);
            }
            lVar4 = this.gridPool;
            uVar5 = uVar5 + 1;
            lVar6 = lVar6 + 8;
            if (lVar4 == null) break;
          }
        }
        LAB_18094918c:
                          // WARNING: Subroutine does not return
        FUN_1800d6620();
        joined_r0x0001809490c5:
        if (num < 1) {
          return;
        }
        if (lVar3 == null) goto LAB_18094918c;
        if (*(int *)(lVar3 + 24) < 1) {
          return;
        }
        uVar5 = FUN_180d8cf10(0,*(int *)(lVar3 + 24),0);
        if (*(uint32 *)(lVar3 + 24) <= uVar5) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        uVar5 = lVar3[uVar5];
        lVar4 = this.gridPool;
        if (lVar4 == null) goto LAB_18094918c;
        if (lVar4.Count <= uVar5) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        lVar4 = lVar4._items[uVar5];
        if ((lVar4 == null) || (lVar4 = GameObject.GetComponent(lVar4,DAT_181d9f5d0)) == null)
        goto LAB_18094918c;
        ExploreTileUnitController.set_Seen(lVar4,1,0);
        FUN_181801c10(lVar3,uVar5);
        num = num + -1;
        goto joined_r0x0001809490c5;
    }

    // Token : 0x60013F6
    // RVA   : 0x939A00   Offset: 0x938200   Length: 0xB
    public void ChangeMoveStep(int num)
    {
        var pStatics = *(int64*)(DAT_181d4ef00 + 184);
        ulong uVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        long lVar5;
        ulong uVar7;
        uint uVar8;
        uint uVar9;
        uint uVar10;
        uint uVar11;
        int[] local_res10 = new int[2];
        ulong uVar13;
        uint uVar14;
        ulong in_stack_ffffffffffffff70;
        uint uVar15;
        uint local_68;
        uint local_64;
        uint local_60;
        ulong local_58;
        uint local_50;
        uint local_48;
        uint uStack_44;
        uint uStack_40;
        uint32 uStack_3c;
        uVar15 = (uint32)((uint64)in_stack_ffffffffffffff70 >> 32);
        local_res10[0] = num;
        if (this.leftPower == 999) {
          return;
        }
        lVar2 = **(int64 **)(DAT_181d4df90 + 184);
        uVar4 = Int32.ToString(local_res10,"+0;-0;0",0);
        uVar4 = String.Concat("耐力",uVar4,0);
        if ((this.playerSkeleton != null) &&
           (lVar5 = Component.get_transform(this.playerSkeleton,0)) != null) {
          puVar6 = (uint64 *)Transform.get_position(&local_58,lVar5,0);
          uVar1 = *puVar6;
          uVar14 = *(uint32 *)(puVar6 + 1);
          if (local_res10[0] < 1) {
            lVar5 = pStatics;
            uVar8 = *(uint32 *)(lVar5 + 0x2e8);
            uVar9 = *(uint32 *)(lVar5 + 0x2ec);
            uVar10 = *(uint32 *)(lVar5 + 0x2f0);
            uVar11 = *(uint32 *)(lVar5 + 0x2f4);
          }
          else {
            lVar5 = pStatics;
            uVar8 = *(uint32 *)(lVar5 + 0x280);
            uVar9 = *(uint32 *)(lVar5 + 0x284);
            uVar10 = *(uint32 *)(lVar5 + 0x288);
            uVar11 = *(uint32 *)(lVar5 + 0x28c);
          }
          if (lVar2 != null) {
            uVar13 = this.playerIcon;
            puVar12 = &local_68;
            local_64 = 0x3dcccccd;
            local_68 = 0;
            local_60 = 0;
            local_58 = uVar1;
            local_50 = uVar14;
            local_48 = uVar8;
            uStack_44 = uVar9;
            uStack_40 = uVar10;
            uStack_3c = uVar11;
            GameController.ShowTextAtPos
                      (lVar2,uVar4,&local_58,18,&local_48,puVar12,uVar13,CONCAT44(uVar15,9),
                       "UIAtlas",0,0,0);
            uVar15 = (uint32)((uint64)puVar12 >> 32);
            uVar14 = (uint32)((uint64)uVar13 >> 32);
            if (param_3) {
              lVar2 = **(int64 **)(DAT_181d5a578 + 184);
              uVar4 = Int32.ToString(local_res10,"+0;-0;0",0);
              uVar7 = String.Concat("剩余耐力",uVar4,0);
              uVar3 = "BuffGood";
              uVar4 = "StateDown";
              uVar13 = "UIAtlas";
              uVar1 = "从事工作_闲逛";
              if (local_res10[0] < 1) {
                lVar5 = pStatics;
                uVar8 = *(uint32 *)(lVar5 + 0x2e8);
                uVar9 = *(uint32 *)(lVar5 + 0x2ec);
                uVar10 = *(uint32 *)(lVar5 + 0x2f0);
                uVar11 = *(uint32 *)(lVar5 + 0x2f4);
              }
              else {
                lVar5 = pStatics;
                uVar8 = *(uint32 *)(lVar5 + 0x280);
                uVar9 = *(uint32 *)(lVar5 + 0x284);
                uVar10 = *(uint32 *)(lVar5 + 0x288);
                uVar11 = *(uint32 *)(lVar5 + 0x28c);
                uVar4 = uVar3;
              }
              if (lVar2 == null) throw; // [null/range check failed]
              local_48 = uVar8;
              uStack_44 = uVar9;
              uStack_40 = uVar10;
              uStack_3c = uVar11;
              InfoController.AddInfoTab
                        (lVar2,uVar7,uVar13,uVar1,uVar4,CONCAT44(uVar15,0x3f800000),
                         CONCAT44(uVar14,0x40a00000),&local_48,0);
            }
            this.leftPower = this.leftPower + local_res10[0];
            return;
          }
        }
    }

    // Token : 0x60013F7
    // RVA   : 0x9395B0   Offset: 0x937DB0   Length: 0x445
    public void ChangeMoveStep(int num, bool showText)
    {
        var pStatics = *(int64*)(DAT_181d4ef00 + 184);
        ulong uVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        long lVar5;
        ulong uVar7;
        uint uVar8;
        uint uVar9;
        uint uVar10;
        uint uVar11;
        int[] local_res10 = new int[2];
        ulong uVar13;
        uint uVar14;
        ulong in_stack_ffffffffffffff70;
        uint uVar15;
        uint local_68;
        uint local_64;
        uint local_60;
        ulong local_58;
        uint local_50;
        uint local_48;
        uint uStack_44;
        uint uStack_40;
        uint32 uStack_3c;
        uVar15 = (uint32)((uint64)in_stack_ffffffffffffff70 >> 32);
        local_res10[0] = num;
        if (this.leftPower == 999) {
          return;
        }
        lVar2 = **(int64 **)(DAT_181d4df90 + 184);
        uVar4 = Int32.ToString(local_res10,"+0;-0;0",0);
        uVar4 = String.Concat("耐力",uVar4,0);
        if ((this.playerSkeleton != null) &&
           (lVar5 = Component.get_transform(this.playerSkeleton,0)) != null) {
          puVar6 = (uint64 *)Transform.get_position(&local_58,lVar5,0);
          uVar1 = *puVar6;
          uVar14 = *(uint32 *)(puVar6 + 1);
          if (local_res10[0] < 1) {
            lVar5 = pStatics;
            uVar8 = *(uint32 *)(lVar5 + 0x2e8);
            uVar9 = *(uint32 *)(lVar5 + 0x2ec);
            uVar10 = *(uint32 *)(lVar5 + 0x2f0);
            uVar11 = *(uint32 *)(lVar5 + 0x2f4);
          }
          else {
            lVar5 = pStatics;
            uVar8 = *(uint32 *)(lVar5 + 0x280);
            uVar9 = *(uint32 *)(lVar5 + 0x284);
            uVar10 = *(uint32 *)(lVar5 + 0x288);
            uVar11 = *(uint32 *)(lVar5 + 0x28c);
          }
          if (lVar2 != null) {
            uVar13 = this.playerIcon;
            puVar12 = &local_68;
            local_64 = 0x3dcccccd;
            local_68 = 0;
            local_60 = 0;
            local_58 = uVar1;
            local_50 = uVar14;
            local_48 = uVar8;
            uStack_44 = uVar9;
            uStack_40 = uVar10;
            uStack_3c = uVar11;
            GameController.ShowTextAtPos
                      (lVar2,uVar4,&local_58,18,&local_48,puVar12,uVar13,CONCAT44(uVar15,9),
                       "UIAtlas",0,0,0);
            uVar15 = (uint32)((uint64)puVar12 >> 32);
            uVar14 = (uint32)((uint64)uVar13 >> 32);
            if (showText) {
              lVar2 = **(int64 **)(DAT_181d5a578 + 184);
              uVar4 = Int32.ToString(local_res10,"+0;-0;0",0);
              uVar7 = String.Concat("剩余耐力",uVar4,0);
              uVar3 = "BuffGood";
              uVar4 = "StateDown";
              uVar13 = "UIAtlas";
              uVar1 = "从事工作_闲逛";
              if (local_res10[0] < 1) {
                lVar5 = pStatics;
                uVar8 = *(uint32 *)(lVar5 + 0x2e8);
                uVar9 = *(uint32 *)(lVar5 + 0x2ec);
                uVar10 = *(uint32 *)(lVar5 + 0x2f0);
                uVar11 = *(uint32 *)(lVar5 + 0x2f4);
              }
              else {
                lVar5 = pStatics;
                uVar8 = *(uint32 *)(lVar5 + 0x280);
                uVar9 = *(uint32 *)(lVar5 + 0x284);
                uVar10 = *(uint32 *)(lVar5 + 0x288);
                uVar11 = *(uint32 *)(lVar5 + 0x28c);
                uVar4 = uVar3;
              }
              if (lVar2 == null) throw; // [null/range check failed]
              local_48 = uVar8;
              uStack_44 = uVar9;
              uStack_40 = uVar10;
              uStack_3c = uVar11;
              InfoController.AddInfoTab
                        (lVar2,uVar7,uVar13,uVar1,uVar4,CONCAT44(uVar15,0x3f800000),
                         CONCAT44(uVar14,0x40a00000),&local_48,0);
            }
            this.leftPower = this.leftPower + local_res10[0];
            return;
          }
        }
    }

    // Token : 0x60013F8
    // RVA   : 0x93A540   Offset: 0x938D40   Length: 0x53
    public void FocusOnTarget(GameObject target)
    {
        ulong uVar1;
        uVar1 = *target;
        this.tweenFocusTarget = (int)uVar1;
        *(int *)(this + 0x100) = (int)((uint64)uVar1 >> 32);
    }

    // Token : 0x60013F9
    // RVA   : 0x93A510   Offset: 0x938D10   Length: 0x21
    public void FocusOnTarget(Vector3 position)
    {
        ulong uVar1;
        uVar1 = *position;
        this.tweenFocusTarget = (int)uVar1;
        *(int *)(this + 0x100) = (int)((uint64)uVar1 >> 32);
    }

    // Token : 0x60013FA
    // RVA   : 0x939BA0   Offset: 0x9383A0   Length: 0x63
    public void ExploreTileClicked(GameObject targetGrid)
    {
        uint uVar1;
        bool cVar2;
        int iVar3;
        long lVar4;
        long lVar5;
        ulong uVar8;
        uint[] local_res10 = new uint[2];
        ulong local_38;
        uint local_30;
        byte[] local_28 = new byte[16];
        plVar9 = (int64 *)0;
        local_res10[0] = 0;
        if (targetGrid == null) throw; // [null/range check failed]
        if (*(char *)(targetGrid + 89) == false) {
        LAB_180939dec:
          plVar7 = (int64 *)Resources.Load("Sound/SoundEffect/WrongClick",0);
          if ((plVar7 != (int64 *)0) && (*plVar7 == DAT_181d8a228)) {
            plVar9 = plVar7;
          }
          NGUITools.PlaySound(plVar9,0x3f800000,0);
          return;
        }
        if ((*(int64 *)(targetGrid + 80) != 0) && (*(int *)(*(int64 *)(targetGrid + 80) + 20) != 0))
        {
          lVar4 = FUN_18046c440(0);
          if ((*(int64 *)(targetGrid + 80) == 0) || (lVar4 == null)) throw; // [null/range check failed]
          cVar2 = PlotController.CheckMeetRequire
                            (lVar4,*(int *)(*(int64 *)(targetGrid + 80) + 16) + 7);
          if (!cVar2) {
            lVar4 = FUN_18046c0a0(0);
            if (this.playerGrid != null) {
              lVar5 = GameObject.get_transform(this.playerGrid,0);
              if (lVar5 != null) {
                puVar6 = (uint64 *)Transform.get_position(local_28,lVar5,0);
                if (lVar4 != null) {
                  local_38 = *puVar6;
                  local_30 = *(uint32 *)(puVar6 + 1);
                  GameController.ShowTextAtPos(lVar4,"通行技能不足",&local_38,0);
                  goto LAB_180939dec;
                }
              }
            }
            throw; // [null/range check failed]
          }
        }
        if ((*(int *)(targetGrid + 48) == 2) && (*(char *)(targetGrid + 52) == false)) {
          if (this.explorePanelData != null) {
            if (this.explorePanelData.keyNum < 1) {
              if (this.exploreMapData == null) throw; // [null/range check failed]
              iVar3 = Mathf.CeilToInt(this.exploreMapData.exploreDifficulty * 0.25 + 3.0,0);
              ExploreController.ChangeMoveStep(this,-iVar3,1,0);
              uVar8 = "Sound/SoundEffect/WoodenBoxDestroy";
            }
            else {
              ExploreController.ChangeKeyNum(this,0xffffffff);
              local_res10[0] = FUN_180d8cf10(0,7);
              uVar8 = Int32.ToString(local_res10,0);
              uVar8 = String.Concat("Sound/SoundEffect/Door/Door",uVar8,0);
            }
            plVar7 = (int64 *)Resources.Load(uVar8,0);
            if ((plVar7 != (int64 *)0) && (*plVar7 == DAT_181d8a228)) {
              plVar9 = plVar7;
            }
            NGUITools.PlaySound(plVar9,0x3f800000,0);
            if (this.gridUnits != null) {
              lVar4 = FUN_180127f50(this.gridUnits,(int64)*(int *)(targetGrid + 36),
                                    (int64)*(int *)(targetGrid + 32));
              if (lVar4 != null) {
                lVar4 = GameObject.get_transform(lVar4,0);
                if (lVar4 != null) {
                  lVar4 = Transform.Find(lVar4,"Door",0);
                  if (lVar4 != null) {
                    lVar4 = Component.GetComponent(lVar4,DAT_181d6cd40);
                    if (lVar4 != null) {
                      lVar4 = SkeletonAnimation.get_AnimationState(lVar4,0);
                      if (lVar4 != null) {
                        AnimationState.SetAnimation(lVar4,0,"open",0,0);
                        *(uint8 *)(targetGrid + 52) = 1;
                        goto LAB_18093a02f;
                      }
                    }
                  }
                }
              }
            }
          }
        }
        else {
          lVar4 = this.ExploreTileGroundDataBase;
          if (lVar4 != null) {
            uVar1 = *(uint32 *)(targetGrid + 72);
            if (lVar4.Count <= uVar1) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar4 = lVar4._items[uVar1];
            if (lVar4 != null) {
              ExploreController.ChangeMoveStep(this,-lVar4.Count,0,0);
        LAB_18093a02f:
              ExploreController.ManageMoveStepLimit(this,0);
              ExploreController.PlayerEnterGrid
                        (this,*(uint32 *)(targetGrid + 36),*(uint32 *)(targetGrid + 32),0,0);
              return;
            }
          }
        }
    }

    // Token : 0x60013FB
    // RVA   : 0x939C10   Offset: 0x938410   Length: 0x452
    public void ExploreTileClicked(ExploreTileData exploreTileData)
    {
        uint uVar1;
        bool cVar2;
        int iVar3;
        long lVar4;
        long lVar5;
        ulong uVar8;
        uint[] local_res10 = new uint[2];
        ulong local_38;
        uint local_30;
        byte[] local_28 = new byte[16];
        plVar9 = (int64 *)0;
        local_res10[0] = 0;
        if (exploreTileData == null) throw; // [null/range check failed]
        if (*(char *)(exploreTileData + 89) == false) {
        LAB_180939dec:
          plVar7 = (int64 *)Resources.Load("Sound/SoundEffect/WrongClick",0);
          if ((plVar7 != (int64 *)0) && (*plVar7 == DAT_181d8a228)) {
            plVar9 = plVar7;
          }
          NGUITools.PlaySound(plVar9,0x3f800000,0);
          return;
        }
        if ((*(int64 *)(exploreTileData + 80) != 0) && (*(int *)(*(int64 *)(exploreTileData + 80) + 20) != 0))
        {
          lVar4 = FUN_18046c440(0);
          if ((*(int64 *)(exploreTileData + 80) == 0) || (lVar4 == null)) throw; // [null/range check failed]
          cVar2 = PlotController.CheckMeetRequire
                            (lVar4,*(int *)(*(int64 *)(exploreTileData + 80) + 16) + 7);
          if (!cVar2) {
            lVar4 = FUN_18046c0a0(0);
            if (this.playerGrid != null) {
              lVar5 = GameObject.get_transform(this.playerGrid,0);
              if (lVar5 != null) {
                puVar6 = (uint64 *)Transform.get_position(local_28,lVar5,0);
                if (lVar4 != null) {
                  local_38 = *puVar6;
                  local_30 = *(uint32 *)(puVar6 + 1);
                  GameController.ShowTextAtPos(lVar4,"通行技能不足",&local_38,0);
                  goto LAB_180939dec;
                }
              }
            }
            throw; // [null/range check failed]
          }
        }
        if ((*(int *)(exploreTileData + 48) == 2) && (*(char *)(exploreTileData + 52) == false)) {
          if (this.explorePanelData != null) {
            if (this.explorePanelData.keyNum < 1) {
              if (this.exploreMapData == null) throw; // [null/range check failed]
              iVar3 = Mathf.CeilToInt(this.exploreMapData.exploreDifficulty * 0.25 + 3.0,0);
              ExploreController.ChangeMoveStep(this,-iVar3,1,0);
              uVar8 = "Sound/SoundEffect/WoodenBoxDestroy";
            }
            else {
              ExploreController.ChangeKeyNum(this,0xffffffff);
              local_res10[0] = FUN_180d8cf10(0,7);
              uVar8 = Int32.ToString(local_res10,0);
              uVar8 = String.Concat("Sound/SoundEffect/Door/Door",uVar8,0);
            }
            plVar7 = (int64 *)Resources.Load(uVar8,0);
            if ((plVar7 != (int64 *)0) && (*plVar7 == DAT_181d8a228)) {
              plVar9 = plVar7;
            }
            NGUITools.PlaySound(plVar9,0x3f800000,0);
            if (this.gridUnits != null) {
              lVar4 = FUN_180127f50(this.gridUnits,(int64)*(int *)(exploreTileData + 36),
                                    (int64)*(int *)(exploreTileData + 32));
              if (lVar4 != null) {
                lVar4 = GameObject.get_transform(lVar4,0);
                if (lVar4 != null) {
                  lVar4 = Transform.Find(lVar4,"Door",0);
                  if (lVar4 != null) {
                    lVar4 = Component.GetComponent(lVar4,DAT_181d6cd40);
                    if (lVar4 != null) {
                      lVar4 = SkeletonAnimation.get_AnimationState(lVar4,0);
                      if (lVar4 != null) {
                        AnimationState.SetAnimation(lVar4,0,"open",0,0);
                        *(uint8 *)(exploreTileData + 52) = 1;
                        goto LAB_18093a02f;
                      }
                    }
                  }
                }
              }
            }
          }
        }
        else {
          lVar4 = this.ExploreTileGroundDataBase;
          if (lVar4 != null) {
            uVar1 = *(uint32 *)(exploreTileData + 72);
            if (lVar4.Count <= uVar1) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar4 = lVar4._items[uVar1];
            if (lVar4 != null) {
              ExploreController.ChangeMoveStep(this,-lVar4.Count,0,0);
        LAB_18093a02f:
              ExploreController.ManageMoveStepLimit(this,0);
              ExploreController.PlayerEnterGrid
                        (this,*(uint32 *)(exploreTileData + 36),*(uint32 *)(exploreTileData + 32),0,0);
              return;
            }
          }
        }
    }

    // Token : 0x60013FC
    // RVA   : 0x945860   Offset: 0x944060   Length: 0xB4
    public bool PlayerCanPassObstacle(ExploreTileData exploreTileData, bool includeTeamMate)
    {
        long lVar1;
        ulong uVar2;
        if (exploreTileData != null) {
          lVar1 = *(int64 *)(exploreTileData + 80);
          if ((lVar1 == null) || (*(int *)(lVar1 + 20) == 0)) {
            return CONCAT71((int7)((uint64)lVar1 >> 8),1);
          }
          lVar1 = FUN_18046c440(0);
          if ((*(int64 *)(exploreTileData + 80) != 0) && (lVar1 != null)) {
            uVar2 = PlotController.CheckMeetRequire
                              (lVar1,*(int *)(*(int64 *)(exploreTileData + 80) + 16) + 7);
            return uVar2;
          }
        }
    }

    // Token : 0x60013FD
    // RVA   : 0x9454E0   Offset: 0x943CE0   Length: 0x264
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
        if ((fStackX_24 - fStack_64) * (fStackX_24 - fStack_64) +
            (local_res20 - local_68) * (local_res20 - local_68) < 9.9999994e-11) {
          return;
        }
        if (this.exploreGridRoot != null) {
          uVar4 = GameObject.GetComponent(this.exploreGridRoot,DAT_181da1930);
          cVar3 = Object.op_Equality(uVar4,0,0);
          if (!cVar3) {
            if ((this.exploreGridRoot == null) ||
               (lVar5 = GameObject.GetComponent(this.exploreGridRoot,DAT_181da1930)) == null
               ) throw; // [null/range check failed]
            cVar3 = Behaviour.get_isActiveAndEnabled(lVar5,0);
            if (cVar3) {
              return;
            }
          }
          if (this.exploreGridRoot != null) {
            lVar5 = GameObject.get_transform(this.exploreGridRoot,0);
            if ((this.exploreGridRoot != null) &&
               (lVar6 = GameObject.get_transform(this.exploreGridRoot,0)) != null) {
              puVar7 = (uint64 *)Transform.get_localPosition(local_48,lVar6,0);
              uVar2 = this.exploreGrid;
              uVar4 = *puVar7;
              fVar1 = *(float *)(puVar7 + 1);
              puVar7 = (uint64 *)
                       GlobalData.TransformScreenDeltaToLocalDelta(local_38,delta,uVar2,0);
              local_68 = (float)uVar4;
              fStack_64 = (float)((uint64)uVar4 >> 32);
              local_50 = fVar1 + *(float *)(puVar7 + 1);
              local_58 = CONCAT44(fStack_64 + (float)((uint64)*puVar7 >> 32),
                                  local_68 + (float)*puVar7);
              local_40 = local_50;
              puVar7 = (uint64 *)
                       ExploreController.LimitMapPos
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
    }

    // Token : 0x60013FE
    // RVA   : 0x945750   Offset: 0x943F50   Length: 0x100
    public void OnScroll(float delta)
    {
        ulong uVar1;
        bool cVar2;
        long lVar3;
        uint uVar4;
        if (delta != null.0) {
          if (this.exploreGridRoot == null) {
        LAB_18094584b:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          uVar1 = GameObject.GetComponent(this.exploreGridRoot,DAT_181da1930);
          cVar2 = Object.op_Equality(uVar1,0,0);
          if (!cVar2) {
            if ((this.exploreGridRoot == null) ||
               (lVar3 = GameObject.GetComponent(this.exploreGridRoot,DAT_181da1930)) == null
               ) goto LAB_18094584b;
            cVar2 = Behaviour.get_isActiveAndEnabled(lVar3,0);
            if (cVar2) {
              return;
            }
          }
          uVar4 = FUN_1810a8ba0(this.nowScale + delta,0x3f19999a,0x3fb33333,0);
          this.nowScale = uVar4;
        }
    }

    // Token : 0x60013FF
    // RVA   : 0x946C70   Offset: 0x945470   Length: 0xAF
    public void QuitExploreButtonClicked()
    {
        var pStatics = *(int64*)(DAT_181d834f0 + 184);
        if (*pStatics != 0) {
          SureMenu.CallSureMenu
                    (*pStatics,"要中止探索吗？\n这意味着本次探索将以失败告终！","ExploreFail","",
                     "ExploreController",0);
          return;
        }
    }

    // Token : 0x6001400
    // RVA   : 0x939A10   Offset: 0x938210   Length: 0x187
    public void ExploreFail()
    {
        long lVar1;
        long lVar2;
        ulong uVar3;
        lVar1 = **(int64 **)(DAT_181d6c960 + 184);
        lVar2 = il2cpp_internal(DAT_181d72a30);
        FUN_180f58a90(lVar2,DAT_181d7c250);
        if (lVar2 != null) {
          FUN_181827900(lVar2,"留得青山在;HideInteractUI",DAT_181d7c3d0);
          uVar3 = new SinglePlotData("#$PlayerName#行至山穷水尽，精疲力竭，不得不原路折返",lVar2,0);
          if (lVar1 != null) {
            PlotController.AddPlot(lVar1,uVar3,0);
            ExploreController.FinishExploreMap(this,0,0);
            return;
          }
        }
    }

    // Token : 0x6001401
    // RVA   : 0x949620   Offset: 0x947E20   Length: 0xE4
    public void /*ctor*/()
    {
        long lVar1;
        lVar1 = il2cpp_internal(DAT_181d6cb30);
        FUN_180f58a90(lVar1,DAT_181d58d10);
        if (lVar1 != null) {
          FUN_181805880(lVar1,0,DAT_181d58d90);
          FUN_181805880(lVar1,0,DAT_181d58d90);
          FUN_181805880(lVar1,0,DAT_181d58d90);
          FUN_181805880(lVar1,0,DAT_181d58d90);
          FUN_181805880(lVar1,0,DAT_181d58d90);
          this.exploreRateRewarded = lVar1;
          FUN_18044ef50(this,0);
          return;
        }
    }

    // Token : 0x6001402
    // RVA   : 0x949520   Offset: 0x947D20   Length: 0xF2
    private static void /*cctor*/()
    {
        long lVar2;
        lVar2 = il2cpp_internal(DAT_181d72a30);
        FUN_180f58a90(lVar2,DAT_181d7c250);
        if (lVar2 != null) {
          FUN_181827900(lVar2,"巨石",DAT_181d7c3d0);
          FUN_181827900(lVar2,"绝壁",DAT_181d7c3d0);
          FUN_181827900(lVar2,"激流",DAT_181d7c3d0);
          plVar1 = *(int64 **)(DAT_181da0c98 + 184);
          *plVar1 = lVar2;
          il2cpp_internal(plVar1,lVar2);
          return;
        }
    }

}
