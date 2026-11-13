// ============================================================
// Type  : ChooseController
// Token : 0x20001BD
// ============================================================

public class ChooseController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000C13
    public GameObject choosePanel;

    // Token: 0x4000C14
    public GameObject itemList;

    // Token: 0x4000C15
    public GameObject heroList;

    // Token: 0x4000C16
    public GameObject targetGrid;

    // Token: 0x4000C17
    public GameObject chooseRoot;

    // Token: 0x4000C18
    public ChooseType chooseType;

    // Token: 0x4000C19
    public GameObject chooseResult;

    // Token: 0x4000C1A
    public GameObject sendResultFucTarget;

    // Token: 0x4000C1B
    public string sendResultFuc;

    // Token: 0x4000C1C
    public string sendResultParam;

    // Token: 0x4000C1D
    public string cancelFuc;

    // Token: 0x4000C1E
    private GameObject newObj;

    // Token: 0x4000C1F
    private HeroData targetHero;

    // Token: 0x4000C20
    private static ChooseController _instance;

    // Token: 0x4000C21
    private bool inited;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000E89
    // RVA   : 0x6FDC10   Offset: 0x6FCA10   Length: 0x36
    public static ChooseController get_Instance()
    {
        return **(uint64 **)(DAT_181e977e8 + 184);
    }

    // Token : 0x6000E8A
    // RVA   : 0x6F5230   Offset: 0x6F4030   Length: 0x43
    private void Awake()
    {
        puVar1 = *(uint64 **)(DAT_181e977e8 + 184);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x6000E8B
    // RVA   : 0x6F5C80   Offset: 0x6F4A80   Length: 0x3F6
    public void Init()
    {
        long lVar1;
        ulong uVar2;
        int[] local_res8 = new int[2];
        uint local_18;
        uint uStack_14;
        uint uStack_10;
        uint32 uStack_c;
        this.inited = 1;
        local_res8[0] = 0;
        while (this.heroList != null) {
          lVar1 = GameObject.get_transform(this.heroList,0);
          if (lVar1 == null) break;
          lVar1 = Transform.Find(lVar1,"HeroFlitter",0);
          if (lVar1 == null) break;
          lVar1 = Transform.Find(lVar1,"HeroLvFlitter",0);
          uVar2 = Int32.ToString(local_res8,0);
          if (lVar1 == null) break;
          lVar1 = Transform.Find(lVar1,uVar2,0);
          if (lVar1 == null) break;
          lVar1 = Transform.Find(lVar1,"Label",0);
          if (lVar1 == null) break;
          plVar3 = (int64 *)Component.GetComponent(lVar1,DAT_181e79538);
          lVar1 = FUN_180210740(0);
          if ((lVar1 == null) || (*(int64 *)(lVar1 + 56) == 0)) break;
          lVar1 = FUN_1800024b0(*(int64 *)(lVar1 + 56),local_res8[0],DAT_181e80560);
          if ((lVar1 == null) || (plVar3 == (int64 *)0)) break;
          local_18 = *(uint32 *)(lVar1 + 24);
          uStack_14 = *(uint32 *)(lVar1 + 28);
          uStack_10 = *(uint32 *)(lVar1 + 32);
          uStack_c = *(uint32 *)(lVar1 + 36);
          (**(code **)(*plVar3 + 0x2a8))(plVar3,&local_18,*(uint64 *)(*plVar3 + 0x2b0));
          if (this.itemList == null) break;
          lVar1 = GameObject.get_transform(this.itemList,0);
          if (lVar1 == null) break;
          lVar1 = Transform.Find(lVar1,"ItemFlitter",0);
          if (lVar1 == null) break;
          lVar1 = Transform.Find(lVar1,"ItemLvFlitter",0);
          uVar2 = Int32.ToString(local_res8,0);
          if (lVar1 == null) break;
          lVar1 = Transform.Find(lVar1,uVar2,0);
          if (lVar1 == null) break;
          lVar1 = Transform.Find(lVar1,"Label",0);
          if (lVar1 == null) break;
          plVar3 = (int64 *)Component.GetComponent(lVar1,DAT_181e79538);
          lVar1 = FUN_180210740(0);
          if ((lVar1 == null) || (*(int64 *)(lVar1 + 56) == 0)) break;
          lVar1 = FUN_1800024b0(*(int64 *)(lVar1 + 56),local_res8[0],DAT_181e80560);
          if ((lVar1 == null) || (plVar3 == (int64 *)0)) break;
          local_18 = *(uint32 *)(lVar1 + 24);
          uStack_14 = *(uint32 *)(lVar1 + 28);
          uStack_10 = *(uint32 *)(lVar1 + 32);
          uStack_c = *(uint32 *)(lVar1 + 36);
          (**(code **)(*plVar3 + 0x2a8))(plVar3,&local_18,*(uint64 *)(*plVar3 + 0x2b0));
          if (this.itemList == null) break;
          lVar1 = GameObject.get_transform(this.itemList,0);
          if (lVar1 == null) break;
          lVar1 = Transform.Find(lVar1,"SkillFlitter",0);
          if (lVar1 == null) break;
          lVar1 = Transform.Find(lVar1,"SkillLvFlitter",0);
          uVar2 = Int32.ToString(local_res8,0);
          if (lVar1 == null) break;
          lVar1 = Transform.Find(lVar1,uVar2,0);
          if (lVar1 == null) break;
          lVar1 = Transform.Find(lVar1,"Label",0);
          if (lVar1 == null) break;
          plVar3 = (int64 *)Component.GetComponent(lVar1,DAT_181e79538);
          lVar1 = FUN_180210740(0);
          if ((lVar1 == null) || (*(int64 *)(lVar1 + 56) == 0)) break;
          lVar1 = FUN_1800024b0(*(int64 *)(lVar1 + 56),local_res8[0],DAT_181e80560);
          if ((lVar1 == null) || (plVar3 == (int64 *)0)) break;
          local_18 = *(uint32 *)(lVar1 + 24);
          uStack_14 = *(uint32 *)(lVar1 + 28);
          uStack_10 = *(uint32 *)(lVar1 + 32);
          uStack_c = *(uint32 *)(lVar1 + 36);
          (**(code **)(*plVar3 + 0x2a8))(plVar3);
          local_res8[0] = local_res8[0] + 1;
          if (5 < local_res8[0]) {
            return;
          }
        }
    }

    // Token : 0x6000E8C
    // RVA   : 0x6F7290   Offset: 0x6F6090   Length: 0x15A
    public void ShowChoosePanel(ChooseType _chooseType, List<HeroData> param, GameObject _sendResultFucTarget, string _sendResultFuc, string _sendResultParam, ChooseFilterType _filterType, string _cancelFuc)
    {
        var pStatics_38e8 = *(int64*)(DAT_181e538e8 + 184);
        void ChooseController.ShowChoosePanel
                     (int64 this,uint32 _chooseType,int64 param,uint64 _sendResultFucTarget,
                     uint64 _sendResultFuc,uint64 _sendResultParam,int _filterType,int64 _cancelFuc,uint64 param_9
                     )
        {
        bool bVar1;
        char cVar2;
        uint8 uVar3;
        int iVar4;
        uint32 uVar5;
        int64 *plVar6;
        int64 lVar7;
        int64 lVar8;
        uint64 *puVar9;
        uint64 uVar10;
        uint32 *puVar11;
        int64 *plVar12;
        int64 *plVar13;
        int *piVar14;
        uint64 uVar15;
        int64 lVar16;
        int64 *plVar17;
        float fVar18;
        int64 local_res8;
        int local_138;
        int local_134;
        int local_130;
        int local_12c;
        uint32 local_128 [2];
        int64 local_120;
        uint32 local_118;
        uint32 uStack_114;
        uint32 uStack_110;
        uint32 uStack_10c;
        uint64 local_108;
        uint64 uStack_100;
        uint64 local_f8;
        uint64 uStack_f0;
        uint64 local_e8;
        uint64 uStack_e0;
        uint64 local_d8;
        uint64 uStack_d0;
        uint8 local_c8 [16];
        uint8 local_b8 [16];
        uint8 local_a8 [16];
        uint8 local_98 [16];
        uint8 local_88 [96];
        plVar12 = (int64 *)0;
        local_134 = 0;
        local_12c = 0;
        local_128[0] = 0;
        local_138 = 0;
        local_130 = 0;
        local_108 = 0;
        uStack_100 = 0;
        if (!this.inited) {
          ChooseController.Init(this,0);
        }
        plVar6 = (int64 *)Resources.Load("Sound/SoundEffect/Paper",0);
        plVar13 = plVar12;
        if ((plVar6 != (int64 *)0) && (*plVar6 == DAT_181e8f4a0)) {
          plVar13 = plVar6;
        }
        NGUITools.PlaySound(plVar13,0);
        uVar10 = this.chooseRoot;
        GlobalData.DeleteAllChild(uVar10,0);
        if (this.choosePanel != null) {
          GameObject.SetActive(this.choosePanel,1,0);
          if ((this.choosePanel != null) &&
             (lVar7 = GameObject.get_transform(this.choosePanel,0)) != null) {
            lVar7 = Transform.Find(lVar7,"ChoosePanelRoot",0);
            lVar8 = Camera.get_main(0);
            puVar9 = (uint64 *)Input.get_mousePosition(local_c8,0);
            if (lVar8 != null) {
              uStack_110 = *(uint32 *)(puVar9 + 1);
              local_118 = (uint32)*puVar9;
              uStack_114 = (uint32)((uint64)*puVar9 >> 32);
              puVar9 = (uint64 *)Camera.ScreenToWorldPoint(local_b8,lVar8,&local_118,0);
              if (lVar7 != null) {
                uStack_110 = *(uint32 *)(puVar9 + 1);
                local_118 = (uint32)*puVar9;
                uStack_114 = (uint32)((uint64)*puVar9 >> 32);
                Transform.set_position(lVar7,&local_118,0);
                if ((this.choosePanel != null) &&
                   (lVar7 = GameObject.get_transform(this.choosePanel,0)) != null) {
                  uVar10 = Transform.Find(lVar7,"ChoosePanelRoot",0);
                  puVar9 = (uint64 *)Vector3.get_zero(local_a8,0);
                  uStack_110 = *(uint32 *)(puVar9 + 1);
                  local_118 = (uint32)*puVar9;
                  uStack_114 = (uint32)((uint64)*puVar9 >> 32);
                  uVar10 = ShortcutExtensions.DOMove(uVar10,&local_118,0x3e19999a,0,0);
                  uVar10 = TweenSettingsExtensions.SetEase(uVar10,2,DAT_181ea4b88);
                  TweenSettingsExtensions.SetUpdate(uVar10,1,DAT_181ea59e0);
                  if ((this.choosePanel != null) &&
                     (lVar7 = GameObject.get_transform(this.choosePanel,0)) != null) {
                    lVar7 = Transform.Find(lVar7,"ChoosePanelRoot",0);
                    puVar9 = (uint64 *)Vector3.get_zero(local_98,0);
                    if (lVar7 != null) {
                      uStack_110 = *(uint32 *)(puVar9 + 1);
                      local_118 = (uint32)*puVar9;
                      uStack_114 = (uint32)((uint64)*puVar9 >> 32);
                      Transform.set_localScale(lVar7,&local_118,0);
                      if ((this.choosePanel != null) &&
                         (lVar7 = GameObject.get_transform(this.choosePanel,0)) != null)
                      {
                        uVar10 = Transform.Find(lVar7,"ChoosePanelRoot",0);
                        uVar10 = ShortcutExtensions.DOScale(uVar10);
                        uVar10 = TweenSettingsExtensions.SetEase(uVar10,2,DAT_181ea4b88);
                        TweenSettingsExtensions.SetUpdate(uVar10,1,DAT_181ea59e0);
                        if ((this.choosePanel != null) &&
                           ((lVar7 = GameObject.get_transform(this.choosePanel,0),
                            lVar7 != null && (lVar7 = Transform.Find(lVar7,"BlackBackground",0)) != null)))
                        {
                          plVar6 = (int64 *)Component.GetComponent(lVar7,DAT_181e777b8);
                          puVar11 = (uint32 *)FUN_180af4e90(local_88,0);
                          if (plVar6 != (int64 *)0) {
                            local_118 = *puVar11;
                            uStack_114 = puVar11[1];
                            uStack_110 = puVar11[2];
                            uStack_10c = puVar11[3];
                            (**(code **)(*plVar6 + 0x2a8))
                                      (plVar6,&local_118,*(uint64 *)(*plVar6 + 0x2b0));
                            if (((this.choosePanel != null) &&
                                (lVar7 = GameObject.get_transform(this.choosePanel,0),
                                lVar7 != null)) &&
                               (lVar7 = Transform.Find(lVar7,"BlackBackground",0)) != null) {
                              uVar10 = Component.GetComponent(lVar7,DAT_181e777b8);
                              uVar10 = DOTweenModuleUI.DOFade(uVar10);
                              TweenSettingsExtensions.SetUpdate(uVar10,1,DAT_181ea5848);
                              this.chooseType = _chooseType;
                              this.sendResultFucTarget = _sendResultFucTarget;
                              this.sendResultFuc = _sendResultFuc;
                              this.sendResultParam = _sendResultParam;
                              this.cancelFuc = param_9;
                              iVar4 = this.chooseType;
                              if (iVar4 == 0) {
                                if (((this.itemList != null) &&
                                    (lVar7 = GameObject.get_transform(this.itemList,0),
                                    lVar7 != null)) &&
                                   ((lVar7 = Transform.Find(lVar7,"ItemFlitter",0), lVar7 != null &&
                                    (lVar7 = Component.get_gameObject(lVar7,0)) != null))) {
                                  GameObject.SetActive(lVar7,0,0);
                                  if (((this.itemList != null) &&
                                      (lVar7 = GameObject.get_transform(this.itemList,0),
                                      lVar7 != null)) &&
                                     ((lVar7 = Transform.Find(lVar7,"SkillFlitter",0), lVar7 != null &&
                                      (lVar7 = Component.get_gameObject(lVar7,0)) != null))) {
                                    GameObject.SetActive(lVar7,1,0);
                                    if ((((this.itemList != null) &&
                                         (lVar7 = GameObject.get_transform
                                                            (this.itemList,0), lVar7 != null)
                                         ) && (lVar7 = Transform.Find(lVar7,"Viewport",0)) != null
                                        ) && (lVar7 = Transform.Find(lVar7,"Content",0)) != null)
                                    {
                                      uVar10 = Component.get_gameObject(lVar7,0);
                                      this.targetGrid = uVar10;
                                      if (this.itemList != null) {
                                        GameObject.SetActive(this.itemList,1,0);
                                        if (this.heroList != null) {
                                          GameObject.SetActive(this.heroList,0,0);
                                          lVar7 = FUN_1802106e0(0);
                                          if ((lVar7 != null) &&
                                             (lVar7 = lVar7.summonControlable, param != null)) {
                                            if (*(int *)(param + 24) == 0) {
                                              ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                            }
                                            plVar6 = *(int64 **)(*(int64 *)(param + 16) + 32);
                                            if ((lVar7 != null) && (plVar6 != (int64 *)0)) {
                                              if (*(int64 *)(*plVar6 + 64) !=
                                                  *(int64 *)(DAT_181e60808 + 64)) {
                          // WARNING: Subroutine does not return
                                                FUN_1801dfd50(plVar6,DAT_181e60808);
                                              }
                                              puVar11 = (uint32 *)il2cpp_object_unbox();
                                              lVar7 = WorldData.GetHero(lVar7,*puVar11,0);
                                              this.targetHero = lVar7;
                                              plVar13 = plVar12;
                                              plVar17 = plVar12;
                                              if (1 < (int)*(uint32 *)(param + 24)) {
                                                if (*(uint32 *)(param + 24) < 2) {
                                                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                                }
                                                if (*(int64 *)(*(int64 *)(param + 16) + 40) !=
                                                    0) {
                                                  if (*(uint32 *)(param + 24) < 2) {
                                                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                                  }
                                                  plVar17 = *(int64 **)
                                                             (*(int64 *)(param + 16) + 40);
                                                  if (plVar17 != (int64 *)0) {
                                                    lVar7 = (**(code **)(*plVar17 + 0x168))
                                                                      (plVar17,*(uint64 *)
                                                                                (*plVar17 + 0x170));
                                                    lVar8 = FUN_1801dfd90(DAT_181e81128,1);
                                                    if (lVar8 != null) {
                                                      if (*(int *)(lVar8 + 24) == 0) {
                                                        uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                        FUN_1801e02d0(uVar10,0);
                                                      }
                                                      *(uint16 *)(lVar8 + 32) = 47;
                                                      if (lVar7 != null) {
                                                        uVar10 = String.Split(lVar7,lVar8,0);
                                                        plVar17 = (int64 *)
                                                                  il2cpp_internal(DAT_181e77728);
                                                        FUN_1817673a0(plVar17,uVar10,DAT_181e86270);
                                                        goto LAB_1806fb23c;
                                                      }
                                                    }
                                                  }
                                                  throw; // [null/range check failed]
                                                }
                                              }
        LAB_1806fb23c:
                                              do {
                                                while( true ) {
                                                  iVar4 = (int)plVar13;
                                                  local_134 = iVar4;
                                                  lVar7 = *(int64 *)
                                                           (pStatics_38e8 + 0x518);
                                                  if (lVar7 == null) throw; // [null/range check failed]
                                                  plVar13 = plVar12;
                                                  if (lVar7.summonLv <= iVar4) goto LAB_1806fb5a6;
                                                  if (2 < *(int *)(param + 24)) break;
        LAB_1806fb31a:
                                                  if (3 < *(int *)(param + 24)) {
                                                    plVar13 = (int64 *)
                                                              FUN_1800024b0(param,3,DAT_181e781e0);
                                                    if (plVar13 == (int64 *)0) throw; // [null/range check failed]
                                                    if (*(int64 *)(*plVar13 + 64) !=
                                                        *(int64 *)(DAT_181e60808 + 64)) {
                          // WARNING: Subroutine does not return
                                                      FUN_1801dfd50(plVar13,DAT_181e60808);
                                                    }
                                                    piVar14 = (int *)il2cpp_object_unbox();
                                                    iVar4 = local_134;
                                                    if (*piVar14 != -1) {
                                                      plVar13 = (int64 *)
                                                                FUN_1800024b0(param,3,DAT_181e781e0);
                                                      if (plVar13 == (int64 *)0) throw; // [null/range check failed]
                                                      if (*(int64 *)(*plVar13 + 64) !=
                                                          *(int64 *)(DAT_181e60808 + 64)) {
                          // WARNING: Subroutine does not return
                                                        FUN_1801dfd50(plVar13,DAT_181e60808);
                                                      }
                                                      piVar14 = (int *)il2cpp_object_unbox();
                                                      if (*piVar14 < iVar4) goto LAB_1806fb3b3;
                                                    }
                                                  }
                                                  if (((this.itemList == null) ||
                                                      (lVar7 = GameObject.get_transform
                                                                         (this.itemList,0)
                                                      , lVar7 == null)) ||
                                                     (lVar7 = Transform.Find(lVar7,"SkillFlitter"),
                                                     lVar7 == null)) throw; // [null/range check failed]
                                                  lVar7 = Transform.Find(lVar7,"SkillLvFlitter");
                                                  uVar10 = Int32.ToString(&local_134,0);
                                                  if (((lVar7 == null) ||
                                                      (lVar7 = Transform.Find(lVar7,uVar10)) == null)
                                                     || (lVar7 = Component.GetComponent
                                                                           (lVar7,DAT_181e796b8),
                                                        lVar7 == null)) throw; // [null/range check failed]
                                                  Selectable.set_interactable(lVar7);
                                                  plVar13 = (int64 *)(uint64)(local_134 + 1);
                                                }
                                                plVar13 = (int64 *)
                                                          FUN_1800024b0(param,2,DAT_181e781e0);
                                                if (plVar13 == (int64 *)0) break;
                                                if (*(int64 *)(*plVar13 + 64) !=
                                                    *(int64 *)(DAT_181e60808 + 64)) {
                          // WARNING: Subroutine does not return
                                                  FUN_1801dfd50(plVar13,DAT_181e60808);
                                                }
                                                piVar14 = (int *)il2cpp_object_unbox();
                                                iVar4 = local_134;
                                                if (*piVar14 == -1) goto LAB_1806fb31a;
                                                plVar13 = (int64 *)
                                                          FUN_1800024b0(param,2,DAT_181e781e0);
                                                if (plVar13 == (int64 *)0) break;
                                                if (*(int64 *)(*plVar13 + 64) !=
                                                    *(int64 *)(DAT_181e60808 + 64)) {
                          // WARNING: Subroutine does not return
                                                  FUN_1801dfd50(plVar13,DAT_181e60808);
                                                }
                                                piVar14 = (int *)il2cpp_object_unbox();
                                                if (*piVar14 <= iVar4) goto LAB_1806fb31a;
        LAB_1806fb3b3:
                                                if (((this.itemList == null) ||
                                                    (lVar7 = GameObject.get_transform
                                                                       (this.itemList,0),
                                                    lVar7 == null)) ||
                                                   (lVar7 = Transform.Find(lVar7,"SkillFlitter"),
                                                   lVar7 == null)) break;
                                                lVar7 = Transform.Find(lVar7,"SkillLvFlitter");
                                                uVar10 = Int32.ToString(&local_134,0);
                                                if (((lVar7 == null) ||
                                                    (lVar7 = Transform.Find(lVar7,uVar10)) == null)
                                                   || (lVar7 = Component.GetComponent
                                                                         (lVar7,DAT_181e796b8), lVar7 == null
                                                      )) break;
                                                Selectable.set_interactable(lVar7,0);
                                                if (((this.itemList == null) ||
                                                    (lVar7 = GameObject.get_transform
                                                                       (this.itemList,0),
                                                    lVar7 == null)) ||
                                                   (lVar7 = Transform.Find(lVar7,"SkillFlitter"),
                                                   lVar7 == null)) break;
                                                lVar7 = Transform.Find(lVar7,"SkillLvFlitter");
                                                uVar10 = Int32.ToString(&local_134,0);
                                                if (((lVar7 == null) ||
                                                    (lVar7 = Transform.Find(lVar7,uVar10)) == null)
                                                   || (lVar7 = Component.GetComponent(lVar7)) == null
                                                   ) break;
                                                Toggle.set_isOn(lVar7);
                                                plVar13 = (int64 *)(uint64)(local_134 + 1);
                                              } while( true );
                                            }
                                          }
                                        }
                                      }
                                    }
                                  }
                                }
                              }
                              else if (iVar4 == 1) {
                                if (((this.itemList != null) &&
                                    (lVar7 = GameObject.get_transform(this.itemList,0),
                                    lVar7 != null)) &&
                                   ((lVar7 = Transform.Find(lVar7,"ItemFlitter",0), lVar7 != null &&
                                    (lVar7 = Component.get_gameObject(lVar7,0)) != null))) {
                                  GameObject.SetActive(lVar7,1,0);
                                  if (((this.itemList != null) &&
                                      (lVar7 = GameObject.get_transform(this.itemList,0),
                                      lVar7 != null)) &&
                                     ((lVar7 = Transform.Find(lVar7,"SkillFlitter",0), lVar7 != null &&
                                      (lVar7 = Component.get_gameObject(lVar7,0)) != null))) {
                                    GameObject.SetActive(lVar7,0,0);
                                    if ((((this.itemList != null) &&
                                         (lVar7 = GameObject.get_transform
                                                            (this.itemList,0), lVar7 != null)
                                         ) && (lVar7 = Transform.Find(lVar7,"Viewport",0)) != null
                                        ) && (lVar7 = Transform.Find(lVar7,"Content",0)) != null)
                                    {
                                      uVar10 = Component.get_gameObject(lVar7,0);
                                      this.targetGrid = uVar10;
                                      if (this.itemList != null) {
                                        GameObject.SetActive(this.itemList,1,0);
                                        if (this.heroList != null) {
                                          GameObject.SetActive(this.heroList,0,0);
                                          lVar7 = FUN_1802106e0(0);
                                          if ((lVar7 != null) &&
                                             (lVar7 = lVar7.summonControlable, param != null)) {
                                            if (*(int *)(param + 24) == 0) {
                                              ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                            }
                                            plVar6 = *(int64 **)(*(int64 *)(param + 16) + 32);
                                            if ((lVar7 != null) && (plVar6 != (int64 *)0)) {
                                              if (*(int64 *)(*plVar6 + 64) !=
                                                  *(int64 *)(DAT_181e60808 + 64)) {
                          // WARNING: Subroutine does not return
                                                FUN_1801dfd50(plVar6,DAT_181e60808);
                                              }
                                              puVar11 = (uint32 *)il2cpp_object_unbox();
                                              lVar7 = WorldData.GetHero(lVar7,*puVar11,0);
                                              this.targetHero = lVar7;
                                              if (*(int *)(param + 24) == 0) {
                                                ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                              }
                                              plVar13 = *(int64 **)
                                                         (*(int64 *)(param + 16) + 32);
                                              if (plVar13 != (int64 *)0) {
                                                if (*(int64 *)(*plVar13 + 64) !=
                                                    *(int64 *)(DAT_181e60808 + 64)) {
                          // WARNING: Subroutine does not return
                                                  FUN_1801dfd50(plVar13,DAT_181e60808);
                                                }
                                                puVar11 = (uint32 *)il2cpp_object_unbox();
                                                local_128[0] = *puVar11;
                                                switch(local_128[0]) {
                                                case 0xffffff97:
                                                  local_120 = *(int64 *)
                                                               (*(int64 *)(DAT_181e528f8 + 184) + 24
                                                               );
                                                  break;
                                                case 0xffffff98:
                                                  lVar7 = FUN_1802106e0(0);
                                                  if ((lVar7 == null) || (lVar7.summonControlable == null))
                                                  throw; // [null/range check failed]
                                                  local_120 = *(int64 *)
                                                               (lVar7.summonControlable + 0x218);
                                                  break;
                                                case 0xffffff99:
                                                  lVar7 = FUN_180210a70(0);
                                                  if (((lVar7 == null) || (lVar7.hp == null)
                                                      ) || ((lVar7 = AreaBuildingData.GetArea
                                                                               (*(int64 *)
                                                                                 (lVar7 + 0x178),0),
                                                            lVar7 == null ||
                                                            (lVar7 = AreaData.GetForce(lVar7,0),
                                                            lVar7 == null)))) throw; // [null/range check failed]
                                                  local_120 = lVar7.thisMonthContribution;
                                                  break;
                                                case 0xffffff9a:
                                                  lVar7 = FUN_1802106e0(0);
                                                  if (((lVar7 == null) || (lVar7.summonControlable == null))
                                                     || (lVar7 = *(int64 *)
                                                                  (lVar7.summonControlable + 0x1b0),
                                                        lVar7 == null)) throw; // [null/range check failed]
                                                  local_120 = lVar7.summonLv;
                                                  break;
                                                case 0xffffff9b:
                                                  lVar7 = FUN_1802102e0(0);
                                                  if (lVar7 == null) throw; // [null/range check failed]
                                                  if (lVar7.summonLv == null) {
                                                    lVar7 = FUN_180210a70(0);
                                                    if ((lVar7 == null) ||
                                                       (lVar7.hp == null))
                                                    throw; // [null/range check failed]
                                                    local_120 = *(int64 *)
                                                                 (lVar7.hp + 40);
                                                  }
                                                  else {
                                                    lVar7 = FUN_1802102e0(0);
                                                    if ((lVar7 == null) || (lVar7.summonLv == null)
                                                       ) throw; // [null/range check failed]
                                                    local_120 = *(int64 *)
                                                                 (lVar7.summonLv + 40);
                                                  }
                                                  break;
                                                case 0xffffff9c:
                                                  lVar7 = FUN_180210a70(0);
                                                  if ((lVar7 == null) || (lVar7.forceJobCD == null))
                                                  throw; // [null/range check failed]
                                                  local_120 = *(int64 *)
                                                               (lVar7.forceJobCD + 128);
                                                  break;
                                                case 0xffffff9d:
                                                  lVar7 = FUN_180210a70(0);
                                                  if (lVar7 == null) throw; // [null/range check failed]
                                                  local_120 = lVar7.changeSkinCd;
                                                  break;
                                                default:
                                                  if (*plVar6 == 0) throw; // [null/range check failed]
                                                  local_120 = *(int64 *)(*plVar6 + 0x220);
                                                }
                                                local_res8 = 0;
                                                plVar6 = plVar12;
                                                if ((*(int *)(param + 24) < 2) ||
                                                   (lVar7 = FUN_1800024b0(param,1,DAT_181e781e0),
                                                   lVar7 == null)) {
        LAB_1806f8462:
                                                  do {
                                                    while( true ) {
                                                      iVar4 = (int)plVar6;
                                                      local_138 = iVar4;
                                                      lVar7 = *(int64 *)
                                                               (pStatics_38e8 +
                                                               0x510);
                                                      if (lVar7 == null) throw; // [null/range check failed]
                                                      plVar6 = plVar12;
                                                      if (lVar7.summonLv <= iVar4)
                                                      goto LAB_1806f87d6;
                                                      if (2 < *(int *)(param + 24)) break;
        LAB_1806f854a:
                                                      if (3 < *(int *)(param + 24)) {
                                                        plVar6 = (int64 *)
                                                                 FUN_1800024b0(param,3,DAT_181e781e0);
                                                        if (plVar6 == (int64 *)0) throw; // [null/range check failed]
                                                        if (*(int64 *)(*plVar6 + 64) !=
                                                            *(int64 *)(DAT_181e60808 + 64)) {
                          // WARNING: Subroutine does not return
                                                          FUN_1801dfd50(plVar6,DAT_181e60808);
                                                        }
                                                        piVar14 = (int *)il2cpp_object_unbox();
                                                        iVar4 = local_138;
                                                        if (*piVar14 != -1) {
                                                          plVar6 = (int64 *)
                                                                   FUN_1800024b0(param,3,DAT_181e781e0);
                                                          if (plVar6 == (int64 *)0)
                                                          throw; // [null/range check failed]
                                                          if (*(int64 *)(*plVar6 + 64) !=
                                                              *(int64 *)(DAT_181e60808 + 64)) {
                          // WARNING: Subroutine does not return
                                                            FUN_1801dfd50(plVar6,DAT_181e60808);
                                                          }
                                                          piVar14 = (int *)il2cpp_object_unbox();
                                                          if (*piVar14 < iVar4) goto LAB_1806f85e3;
                                                        }
                                                      }
                                                      if (((this.itemList == null) ||
                                                          (lVar7 = GameObject.get_transform
                                                                             (*(int64 *)
                                                                               (this + 32),0),
                                                          lVar7 == null)) ||
                                                         (lVar7 = Transform.Find(lVar7,"ItemFlitter"),
                                                         lVar7 == null)) throw; // [null/range check failed]
                                                      lVar7 = Transform.Find(lVar7,"ItemLvFlitter");
                                                      uVar10 = Int32.ToString(&local_138,0);
                                                      if (((lVar7 == null) ||
                                                          (lVar7 = Transform.Find(lVar7,uVar10),
                                                          lVar7 == null)) ||
                                                         (lVar7 = Component.GetComponent
                                                                            (lVar7,DAT_181e796b8),
                                                         lVar7 == null)) throw; // [null/range check failed]
                                                      Selectable.set_interactable(lVar7);
                                                      plVar6 = (int64 *)(uint64)(local_138 + 1);
                                                    }
                                                    plVar6 = (int64 *)
                                                             FUN_1800024b0(param,2,DAT_181e781e0);
                                                    if (plVar6 == (int64 *)0) throw; // [null/range check failed]
                                                    if (*(int64 *)(*plVar6 + 64) !=
                                                        *(int64 *)(DAT_181e60808 + 64)) {
                          // WARNING: Subroutine does not return
                                                      FUN_1801dfd50(plVar6,DAT_181e60808);
                                                    }
                                                    piVar14 = (int *)il2cpp_object_unbox();
                                                    iVar4 = local_138;
                                                    if (*piVar14 == -1) goto LAB_1806f854a;
                                                    plVar6 = (int64 *)
                                                             FUN_1800024b0(param,2,DAT_181e781e0);
                                                    if (plVar6 == (int64 *)0) throw; // [null/range check failed]
                                                    if (*(int64 *)(*plVar6 + 64) !=
                                                        *(int64 *)(DAT_181e60808 + 64)) {
                          // WARNING: Subroutine does not return
                                                      FUN_1801dfd50(plVar6,DAT_181e60808);
                                                    }
                                                    piVar14 = (int *)il2cpp_object_unbox();
                                                    if (*piVar14 <= iVar4) goto LAB_1806f854a;
        LAB_1806f85e3:
                                                    if (((this.itemList == null) ||
                                                        (lVar7 = GameObject.get_transform
                                                                           (this.itemList,
                                                                            0), lVar7 == null)) ||
                                                       (lVar7 = Transform.Find(lVar7,"ItemFlitter"),
                                                       lVar7 == null)) throw; // [null/range check failed]
                                                    lVar7 = Transform.Find(lVar7,"ItemLvFlitter");
                                                    uVar10 = Int32.ToString(&local_138,0);
                                                    if (((lVar7 == null) ||
                                                        (lVar7 = Transform.Find(lVar7,uVar10), lVar7 == null
                                                        )) || (lVar7 = Component.GetComponent
                                                                                 (lVar7,DAT_181e796b8),
                                                              lVar7 == null)) throw; // [null/range check failed]
                                                    Selectable.set_interactable(lVar7,0);
                                                    if (((this.itemList == null) ||
                                                        (lVar7 = GameObject.get_transform
                                                                           (this.itemList,
                                                                            0), lVar7 == null)) ||
                                                       (lVar7 = Transform.Find(lVar7,"ItemFlitter"),
                                                       lVar7 == null)) throw; // [null/range check failed]
                                                    lVar7 = Transform.Find(lVar7,"ItemLvFlitter");
                                                    uVar10 = Int32.ToString(&local_138,0);
                                                    if (((lVar7 == null) ||
                                                        (lVar7 = Transform.Find(lVar7,uVar10), lVar7 == null
                                                        )) || (lVar7 = Component.GetComponent(lVar7),
                                                              lVar7 == null)) throw; // [null/range check failed]
                                                    Toggle.set_isOn(lVar7);
                                                    plVar6 = (int64 *)(uint64)(local_138 + 1);
                                                  } while( true );
                                                }
                                                plVar13 = (int64 *)
                                                          FUN_1800024b0(param,1,DAT_181e781e0);
                                                if (plVar13 != (int64 *)0) {
                                                  lVar7 = (**(code **)(*plVar13 + 0x168))
                                                                    (plVar13,*(uint64 *)
                                                                              (*plVar13 + 0x170));
                                                  lVar8 = FUN_1801dfd90(DAT_181e81128,1);
                                                  if (lVar8 != null) {
                                                    if (*(int *)(lVar8 + 24) == 0) {
                                                      uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                      FUN_1801e02d0(uVar10,0);
                                                    }
                                                    *(uint16 *)(lVar8 + 32) = 47;
                                                    if (lVar7 != null) {
                                                      uVar10 = String.Split(lVar7,lVar8,0);
                                                      local_res8 = il2cpp_internal(DAT_181e77728);
                                                      FUN_1817673a0(local_res8,uVar10,DAT_181e86270);
                                                      goto LAB_1806f8462;
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
                              else if (iVar4 == 2) {
                                if ((((this.heroList != null) &&
                                     (lVar7 = GameObject.get_transform(this.heroList,0),
                                     lVar7 != null)) &&
                                    (lVar7 = Transform.Find(lVar7,"Viewport",0)) != null) &&
                                   (lVar7 = Transform.Find(lVar7,"Content",0)) != null) {
                                  uVar10 = Component.get_gameObject(lVar7,0);
                                  this.targetGrid = uVar10;
                                  if (this.itemList != null) {
                                    GameObject.SetActive(this.itemList,0,0);
                                    if ((this.heroList != null) &&
                                       (GameObject.SetActive(this.heroList,1,0),
                                       param != null)) {
        LAB_1806f7c10:
                                      do {
                                        uVar5 = (uint32)plVar12;
                                        if ((int)*(uint32 *)(param + 24) <= (int)uVar5)
                                        goto LAB_1806faecf;
                                        if (*(uint32 *)(param + 24) <= uVar5) {
                                          ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                        }
                                        plVar12 = *(int64 **)
                                                   (*(int64 *)(param + 16) + 32 +
                                                   (int64)(int)uVar5 * 8);
                                        if (plVar12 == (int64 *)0) {
                                          plVar6 = (int64 *)0;
                                        }
                                        else {
                                          plVar6 = plVar12;
                                        }
                                        if (_filterType == 9) {
                                          lVar7 = FUN_1802106e0(0);
                                          if ((lVar7 == null) || (lVar7.summonControlable == null)) break;
                                          plVar12 = (int64 *)WorldData.Player();
                                          if (plVar6 == plVar12) goto LAB_1806f7e91;
                                          if (((plVar6 == (int64 *)0) || (plVar6[97] == 0)) ||
                                             (lVar7 = *(int64 *)(plVar6[97] + 16)) == null)
                                          break;
                                          iVar4 = FUN_180002480(lVar7,16,DAT_181e71bf0);
                                          if (iVar4 < 1) {
                                            plVar12 = (int64 *)(uint64)(uVar5 + 1);
                                            goto LAB_1806f7c10;
                                          }
        LAB_1806f7db0:
                                          uVar10 = this.targetGrid;
                                          lVar7 = FUN_1802107e0(0);
                                          if (lVar7 == null) break;
                                          uVar15 = lVar7.forceJobType;
                                          uVar10 = GlobalData.AddChild(uVar10,uVar15,0);
                                          this.newObj = uVar10;
                                          if ((this.newObj == null) ||
                                             (lVar7 = GameObject.GetComponent
                                                                (this.newObj,
                                                                 DAT_181e54c18), lVar7 == null)) break;
                                          lVar7.summonControlable = plVar6;
                                          if ((this.newObj == null) ||
                                             (((lVar7 = GameObject.GetComponent
                                                                  (this.newObj,
                                                                   DAT_181e54c18), lVar7 == null ||
                                               (lVar7.summonLv = 3,
                                               this.newObj == null)) ||
                                              (lVar7 = GameObject.GetComponent()) == null))) break;
                                          HeroIconController.AutoSetName(lVar7);
                                        }
                                        else {
                                          if (_filterType != 10) goto LAB_1806f7db0;
                                          lVar7 = FUN_1802106e0(0);
                                          if ((lVar7 == null) || (lVar7.summonControlable == null)) break;
                                          plVar12 = (int64 *)WorldData.Player();
                                          if (plVar6 != plVar12) {
                                            if (((plVar6 == (int64 *)0) || (plVar6[97] == 0)) ||
                                               (lVar7 = *(int64 *)(plVar6[97] + 16)) == null)
                                            break;
                                            iVar4 = FUN_180002480(lVar7,17,DAT_181e71bf0);
                                            if (0 < iVar4) goto LAB_1806f7db0;
                                          }
                                        }
        LAB_1806f7e91:
                                        plVar12 = (int64 *)(uint64)(uVar5 + 1);
                                      } while( true );
                                    }
                                  }
                                }
                              }
                              else {
        LAB_1806faecf:
                                uVar10 = this.targetGrid;
                                GlobalData.SortChild(uVar10,0);
                                if (this.targetGrid != null) {
                                  uVar10 = GameObject.GetComponent
                                                     (this.targetGrid,DAT_181e55c90);
                                  LayoutRebuilder.ForceRebuildLayoutImmediate(uVar10,0);
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
        throw; // [null/range check failed]
        LAB_1806fb5a6:
        iVar4 = (int)plVar13;
        local_12c = iVar4;
        lVar7 = *(int64 *)(pStatics_38e8 + 0x4a8);
        if (lVar7 == null) throw; // [null/range check failed]
        if (iVar4 < lVar7.summonLv) {
          if (plVar17 == (int64 *)0) {
        LAB_1806fb76b:
            if (((this.itemList == null) ||
                (lVar7 = GameObject.get_transform(this.itemList,0)) == null) ||
               (lVar7 = Transform.Find(lVar7,"SkillFlitter")) == null) throw; // [null/range check failed]
            lVar7 = Transform.Find(lVar7,"SkillTypeFlitter");
            uVar10 = Int32.ToString(&local_12c,0);
            if (((lVar7 == null) || (lVar7 = Transform.Find(lVar7,uVar10)) == null) ||
               (lVar7 = Component.GetComponent(lVar7,DAT_181e796b8)) == null) throw; // [null/range check failed]
            Selectable.set_interactable(lVar7);
            plVar13 = (int64 *)(uint64)(local_12c + 1);
          }
          else {
            uVar10 = Int32.ToString(&local_12c,0);
            cVar2 = FUN_18175e190(plVar17,uVar10);
            if (cVar2) goto LAB_1806fb76b;
            if (((this.itemList == null) ||
                (lVar7 = GameObject.get_transform(this.itemList,0)) == null) ||
               (lVar7 = Transform.Find(lVar7,"SkillFlitter")) == null) throw; // [null/range check failed]
            lVar7 = Transform.Find(lVar7,"SkillTypeFlitter");
            uVar10 = Int32.ToString(&local_12c,0);
            if (((lVar7 == null) || (lVar7 = Transform.Find(lVar7,uVar10)) == null) ||
               (lVar7 = Component.GetComponent(lVar7,DAT_181e796b8)) == null) throw; // [null/range check failed]
            Selectable.set_interactable(lVar7,0);
            if (((this.itemList == null) ||
                (lVar7 = GameObject.get_transform(this.itemList,0)) == null) ||
               (lVar7 = Transform.Find(lVar7,"SkillFlitter")) == null) throw; // [null/range check failed]
            lVar7 = Transform.Find(lVar7,"SkillTypeFlitter");
            uVar10 = Int32.ToString(&local_12c,0);
            if (((lVar7 == null) || (lVar7 = Transform.Find(lVar7,uVar10)) == null) ||
               (lVar7 = Component.GetComponent(lVar7)) == null) throw; // [null/range check failed]
            Toggle.set_isOn(lVar7);
            plVar13 = (int64 *)(uint64)(local_12c + 1);
          }
          goto LAB_1806fb5a6;
        }
        lVar7 = *plVar6;
        if (lVar7 != null) goto LAB_1806fb830;
        throw; // [null/range check failed]
        LAB_1806fb830:
        if (lVar7.kungfuSkills == null) throw; // [null/range check failed]
        uVar5 = (uint32)plVar12;
        if (*(int *)(lVar7.kungfuSkills + 24) <= (int)uVar5) goto LAB_1806faecf;
        if ((lVar7 = lVar7?.kungfuSkills) == null) throw; // [null/range check failed]
        if (lVar7.summonLv <= uVar5) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        lVar7 = lVar7.isSummon[uVar5];
        if (plVar17 != (int64 *)0) {
          if (lVar7 == null) throw; // [null/range check failed]
          local_128[0] = KungfuSkillLvData.Type(lVar7,0);
          uVar10 = Int32.ToString(local_128,0);
          cVar2 = FUN_18175e190(plVar17,uVar10,DAT_181e86470);
          if (cVar2) goto LAB_1806fb8bd;
          goto LAB_1806fc6f9;
        }
        LAB_1806fb8bd:
        if (2 < *(int *)(param + 24)) {
          plVar6 = (int64 *)FUN_1800024b0(param,2,DAT_181e781e0);
          if (plVar6 == (int64 *)0) throw; // [null/range check failed]
          if (*(int64 *)(*plVar6 + 64) != *(int64 *)(DAT_181e60808 + 64)) {
                          // WARNING: Subroutine does not return
            FUN_1801dfd50(plVar6,DAT_181e60808);
          }
          piVar14 = (int *)il2cpp_object_unbox();
          if (*piVar14 != -1) {
            if ((lVar7 == null) || (lVar8 = KungfuSkillLvData.DataBase(lVar7,0)) == null)
            throw; // [null/range check failed]
            iVar4 = *(int *)(lVar8 + 52);
            plVar6 = (int64 *)FUN_1800024b0(param,2,DAT_181e781e0);
            if (plVar6 == (int64 *)0) throw; // [null/range check failed]
            if (*(int64 *)(*plVar6 + 64) != *(int64 *)(DAT_181e60808 + 64)) {
                          // WARNING: Subroutine does not return
              FUN_1801dfd50(plVar6,DAT_181e60808);
            }
            piVar14 = (int *)il2cpp_object_unbox();
            if (iVar4 < *piVar14) goto LAB_1806fc6f9;
          }
        }
        if (3 < *(int *)(param + 24)) {
          plVar6 = (int64 *)FUN_1800024b0(param,3,DAT_181e781e0);
          if (plVar6 == (int64 *)0) throw; // [null/range check failed]
          if (*(int64 *)(*plVar6 + 64) != *(int64 *)(DAT_181e60808 + 64)) {
                          // WARNING: Subroutine does not return
            FUN_1801dfd50(plVar6,DAT_181e60808);
          }
          piVar14 = (int *)il2cpp_object_unbox();
          if (*piVar14 != -1) {
            if ((lVar7 == null) || (lVar8 = KungfuSkillLvData.DataBase(lVar7,0)) == null)
            throw; // [null/range check failed]
            iVar4 = *(int *)(lVar8 + 52);
            plVar6 = (int64 *)FUN_1800024b0(param,3,DAT_181e781e0);
            if (plVar6 == (int64 *)0) throw; // [null/range check failed]
            if (*(int64 *)(*plVar6 + 64) != *(int64 *)(DAT_181e60808 + 64)) {
                          // WARNING: Subroutine does not return
              FUN_1801dfd50(plVar6,DAT_181e60808);
            }
            piVar14 = (int *)il2cpp_object_unbox();
            if (*piVar14 < iVar4) goto LAB_1806fc6f9;
          }
        }
        if (4 < *(int *)(param + 24)) {
          plVar6 = (int64 *)FUN_1800024b0(param,4,DAT_181e781e0);
          if (plVar6 == (int64 *)0) throw; // [null/range check failed]
          if (*(int64 *)(*plVar6 + 64) != *(int64 *)(DAT_181e60808 + 64)) {
                          // WARNING: Subroutine does not return
            FUN_1801dfd50(plVar6,DAT_181e60808);
          }
          piVar14 = (int *)il2cpp_object_unbox();
          if (*piVar14 != -1) {
            if (lVar7 == null) throw; // [null/range check failed]
            iVar4 = lVar7.summonID;
            plVar6 = (int64 *)FUN_1800024b0(param,4,DAT_181e781e0);
            if (plVar6 == (int64 *)0) throw; // [null/range check failed]
            if (*(int64 *)(*plVar6 + 64) != *(int64 *)(DAT_181e60808 + 64)) {
                          // WARNING: Subroutine does not return
              FUN_1801dfd50(plVar6,DAT_181e60808);
            }
            piVar14 = (int *)il2cpp_object_unbox();
            if (iVar4 < *piVar14) goto LAB_1806fc6f9;
          }
        }
        if (5 < *(int *)(param + 24)) {
          plVar6 = (int64 *)FUN_1800024b0(param,5,DAT_181e781e0);
          if (plVar6 == (int64 *)0) throw; // [null/range check failed]
          if (*(int64 *)(*plVar6 + 64) != *(int64 *)(DAT_181e60808 + 64)) {
                          // WARNING: Subroutine does not return
            FUN_1801dfd50(plVar6,DAT_181e60808);
          }
          piVar14 = (int *)il2cpp_object_unbox();
          if (*piVar14 != -1) {
            if (lVar7 == null) throw; // [null/range check failed]
            iVar4 = lVar7.summonID;
            plVar6 = (int64 *)FUN_1800024b0(param,5,DAT_181e781e0);
            if (plVar6 == (int64 *)0) throw; // [null/range check failed]
            if (*(int64 *)(*plVar6 + 64) != *(int64 *)(DAT_181e60808 + 64)) {
                          // WARNING: Subroutine does not return
              FUN_1801dfd50(plVar6,DAT_181e60808);
            }
            piVar14 = (int *)il2cpp_object_unbox();
            if (*piVar14 < iVar4) goto LAB_1806fc6f9;
          }
        }
        if (_filterType == 1) {
          if (lVar7 == null) throw; // [null/range check failed]
          cVar2 = KungfuSkillLvData.SkillMeetObstacleLv(lVar7,0);
          if ((cVar2) && (cVar2 = KungfuSkillLvData.CanUpgrade(lVar7,0), cVar2))
          goto switchD_1806fbc25_caseD_14;
          goto LAB_1806fc6f9;
        }
        if (_filterType == 12) {
        switchD_1806fbc25_caseD_17:
          lVar8 = FUN_1802106e0(0);
          if ((((lVar8 == null) || (*(int64 *)(lVar8 + 32) == 0)) ||
              (lVar8 = WorldData.Player(*(int64 *)(lVar8 + 32),0), lVar7 == null)) || (lVar8 == null))
          throw; // [null/range check failed]
          lVar7 = HeroData.FindSkill(lVar8,lVar7.isSummon,0);
          if (lVar7 != null) goto LAB_1806fc6f9;
          goto switchD_1806fbc25_caseD_14;
        }
        switch(_filterType) {
        case 18:
          lVar8 = FUN_180210a70(0);
          if (lVar8 == null) throw; // [null/range check failed]
          if (*(int64 *)(lVar8 + 112) != 0) {
            lVar8 = FUN_180210a70(0);
            if (((lVar8 == null) || (lVar7 == null)) || (*(int64 *)(lVar8 + 112) == 0)) throw; // [null/range check failed]
            lVar8 = HeroData.FindSkill(*(int64 *)(lVar8 + 112),lVar7.isSummon,0);
            if (lVar8 != null) {
              lVar8 = FUN_1802106e0(0);
              if (((lVar8 == null) || (*(int64 *)(lVar8 + 32) == 0)) ||
                 (lVar8 = WorldData.Player(*(int64 *)(lVar8 + 32),0)) == null)
              throw; // [null/range check failed]
              lVar8 = HeroData.FindSkill(lVar8,lVar7.isSummon,0);
              if (lVar8 != null) {
                lVar8 = FUN_180210a70(0);
                if (((lVar8 == null) || (*(int64 *)(lVar8 + 112) == 0)) ||
                   (lVar8 = HeroData.FindSkill(*(int64 *)(lVar8 + 112),lVar7.isSummon,
                                                0), lVar8 == null)) throw; // [null/range check failed]
                iVar4 = *(int *)(lVar8 + 20);
                lVar8 = FUN_1802106e0(0);
                if (((lVar8 == null) || (*(int64 *)(lVar8 + 32) == 0)) ||
                   ((lVar8 = WorldData.Player(*(int64 *)(lVar8 + 32),0), lVar8 == null ||
                    (lVar8 = HeroData.FindSkill(lVar8,lVar7.isSummon,0)) == null)))
                throw; // [null/range check failed]
                if (iVar4 <= *(int *)(lVar8 + 20)) {
                  lVar8 = FUN_180210a70(0);
                  if ((lVar8 == null) || (lVar8 = *(int64 *)(lVar8 + 112)) == null)
                  throw; // [null/range check failed]
        LAB_1806fbe12:
                  lVar7 = HeroData.FindSkill(lVar8,lVar7.isSummon,0);
                  if (lVar7 == null) throw; // [null/range check failed]
                  if (lVar7.summonID < 10) goto switchD_1806fbc25_caseD_14;
                }
              }
            }
          }
          break;
        case 19:
          lVar8 = FUN_180210a70(0);
          if (lVar8 == null) throw; // [null/range check failed]
          if (*(int64 *)(lVar8 + 112) != 0) {
            lVar8 = FUN_180210a70(0);
            if (((lVar8 == null) || (lVar7 == null)) || (*(int64 *)(lVar8 + 112) == 0)) throw; // [null/range check failed]
            lVar8 = HeroData.FindSkill(*(int64 *)(lVar8 + 112),lVar7.isSummon,0);
            if (lVar8 != null) {
              lVar8 = FUN_1802106e0(0);
              if (((lVar8 == null) || (*(int64 *)(lVar8 + 32) == 0)) ||
                 (lVar8 = WorldData.Player(*(int64 *)(lVar8 + 32),0)) == null)
              throw; // [null/range check failed]
              lVar8 = HeroData.FindSkill(lVar8,lVar7.isSummon,0);
              if (lVar8 != null) {
                lVar8 = FUN_180210a70(0);
                if (((lVar8 == null) || (*(int64 *)(lVar8 + 112) == 0)) ||
                   (lVar8 = HeroData.FindSkill(*(int64 *)(lVar8 + 112),lVar7.isSummon,
                                                0), lVar8 == null)) throw; // [null/range check failed]
                iVar4 = *(int *)(lVar8 + 20);
                lVar8 = FUN_1802106e0(0);
                if (((lVar8 == null) || (*(int64 *)(lVar8 + 32) == 0)) ||
                   ((lVar8 = WorldData.Player(*(int64 *)(lVar8 + 32),0), lVar8 == null ||
                    (lVar8 = HeroData.FindSkill(lVar8,lVar7.isSummon,0)) == null)))
                throw; // [null/range check failed]
                if (*(int *)(lVar8 + 20) <= iVar4) {
                  lVar8 = FUN_1802106e0(0);
                  if (((lVar8 != null) && (*(int64 *)(lVar8 + 32) != 0)) &&
                     (lVar8 = WorldData.Player(*(int64 *)(lVar8 + 32),0)) != null)
                  goto LAB_1806fbe12;
                  throw; // [null/range check failed]
                }
              }
            }
          }
          break;
        default:
          goto switchD_1806fbc25_caseD_14;
        case 22:
          lVar8 = FUN_180210a70(0);
          if (lVar8 == null) throw; // [null/range check failed]
          if (*(int64 *)(lVar8 + 112) == 0) break;
          lVar8 = FUN_180210a70(0);
          if (((lVar8 == null) || (lVar7 == null)) || (*(int64 *)(lVar8 + 112) == 0)) throw; // [null/range check failed]
          lVar8 = HeroData.FindSkill(*(int64 *)(lVar8 + 112),lVar7.isSummon,0);
          if (lVar8 != null) break;
          lVar8 = KungfuSkillLvData.DataBase(lVar7,0);
          if (lVar8 == null) throw; // [null/range check failed]
          iVar4 = *(int *)(lVar8 + 52);
          lVar8 = FUN_180210a70(0);
          if ((lVar8 == null) || (*(int64 *)(lVar8 + 112) == 0)) throw; // [null/range check failed]
          if (*(int *)(*(int64 *)(lVar8 + 112) + 184) < iVar4) break;
          lVar8 = FUN_1802106e0(0);
          if ((lVar8 == null) || (*(int64 *)(lVar8 + 32) == 0)) throw; // [null/range check failed]
          lVar8 = WorldData.Player(*(int64 *)(lVar8 + 32),0);
          lVar16 = FUN_180210a70(0);
          if (((lVar16 == null) || (*(int64 *)(lVar16 + 112) == 0)) || (lVar8 == null)) throw; // [null/range check failed]
          cVar2 = HeroData.HaveBrother(lVar8,*(uint32 *)(*(int64 *)(lVar16 + 112) + 88));
          if (!cVar2) {
            lVar8 = FUN_1802106e0(0);
            if ((lVar8 == null) || (*(int64 *)(lVar8 + 32) == 0)) throw; // [null/range check failed]
            lVar8 = WorldData.Player(*(int64 *)(lVar8 + 32),0);
            lVar16 = FUN_180210a70(0);
            if (((lVar16 == null) || (*(int64 *)(lVar16 + 112) == 0)) || (lVar8 == null))
            throw; // [null/range check failed]
            cVar2 = HeroData.HavePrelover(lVar8,*(uint32 *)(*(int64 *)(lVar16 + 112) + 88));
            if (cVar2) goto switchD_1806fbc25_caseD_14;
            lVar8 = FUN_1802106e0(0);
            if (((lVar8 == null) || (*(int64 *)(lVar8 + 32) == 0)) ||
               (lVar8 = WorldData.Player(*(int64 *)(lVar8 + 32),0)) == null) throw; // [null/range check failed]
            iVar4 = *(int *)(lVar8 + 0x328);
            lVar8 = FUN_180210a70(0);
            if ((lVar8 == null) || (*(int64 *)(lVar8 + 112) == 0)) throw; // [null/range check failed]
            if (iVar4 != *(int *)(*(int64 *)(lVar8 + 112) + 88)) {
              lVar7 = KungfuSkillLvData.DataBase(lVar7,0);
              if (lVar7 == null) throw; // [null/range check failed]
              if (4 < lVar7.manageAiHour) break;
            }
          }
          goto switchD_1806fbc25_caseD_14;
        case 23:
          goto switchD_1806fbc25_caseD_17;
        case 26:
          lVar8 = FUN_180210a70(0);
          if (lVar8 == null) throw; // [null/range check failed]
          if (*(int64 *)(lVar8 + 112) != 0) {
            lVar8 = FUN_180210a70(0);
            if (((lVar8 == null) || (lVar7 == null)) || (*(int64 *)(lVar8 + 112) == 0)) throw; // [null/range check failed]
            lVar8 = HeroData.FindSkill(*(int64 *)(lVar8 + 112),lVar7.isSummon,0);
            if (lVar8 == null) {
              lVar7 = KungfuSkillLvData.DataBase(lVar7,0);
              if (lVar7 == null) throw; // [null/range check failed]
              iVar4 = lVar7.manageAiHour;
              lVar7 = FUN_180210a70(0);
              if ((lVar7 == null) || (lVar7.heroFamilyName == null)) throw; // [null/range check failed]
              if (iVar4 <= *(int *)(lVar7.heroFamilyName + 184)) goto switchD_1806fbc25_caseD_14;
            }
          }
          break;
        case 28:
          lVar8 = FUN_180210a70(0);
          if (lVar8 == null) throw; // [null/range check failed]
          if (*(int64 *)(lVar8 + 112) != 0) {
            lVar8 = FUN_180210a70(0);
            if (((lVar8 == null) || (lVar7 == null)) || (*(int64 *)(lVar8 + 112) == 0)) throw; // [null/range check failed]
            lVar8 = HeroData.FindSkill(*(int64 *)(lVar8 + 112),lVar7.isSummon,0);
            if (lVar8 != null) {
              lVar8 = FUN_1802106e0(0);
              if (((lVar8 == null) || (*(int64 *)(lVar8 + 32) == 0)) ||
                 (lVar8 = WorldData.Player(*(int64 *)(lVar8 + 32),0)) == null)
              throw; // [null/range check failed]
              lVar7 = HeroData.FindSkill(lVar8,lVar7.isSummon,0);
              if (lVar7 != null) goto switchD_1806fbc25_caseD_14;
            }
          }
          break;
        case 29:
          if (lVar7 == null) throw; // [null/range check failed]
          iVar4 = lVar7.isSummon;
          if (*(int *)(pStatics_38e8 + 0x120) <= iVar4) break;
          lVar8 = KungfuSkillLvData.DataBase(lVar7,0);
          if (lVar8 == null) throw; // [null/range check failed]
          if (-1 < *(int *)(lVar8 + 128)) break;
          lVar8 = KungfuSkillLvData.DataBase(lVar7,0);
          if (lVar8 == null) throw; // [null/range check failed]
          if (*(int *)(lVar8 + 28) == 4) break;
          lVar8 = KungfuSkillLvData.DataBase(lVar7,0);
          if (lVar8 == null) throw; // [null/range check failed]
          if (2 < *(int *)(lVar8 + 48)) {
            lVar7 = KungfuSkillLvData.DataBase(lVar7,0);
            if (lVar7 != null) {
              if (lVar7.summonMoveRange != null) break;
              goto switchD_1806fbc25_caseD_14;
            }
            throw; // [null/range check failed]
          }
        switchD_1806fbc25_caseD_14:
          uVar10 = this.targetGrid;
          lVar7 = FUN_1802107e0(0);
          if (lVar7 == null) throw; // [null/range check failed]
          uVar15 = lVar7.thisYearContribution;
          uVar10 = GlobalData.AddChild(uVar10,uVar15,0);
          this.newObj = uVar10;
          if (this.newObj == null) throw; // [null/range check failed]
          lVar7 = GameObject.GetComponent(this.newObj,DAT_181e568c8);
          if (((this.targetHero == null) ||
              (lVar8 = this.targetHero.kungfuSkills) == null) ||
             (uVar10 = FUN_1800024b0(lVar8,plVar12), lVar7 == null)) throw; // [null/range check failed]
          lVar7.summonControlable = uVar10;
          if ((this.newObj == null) ||
             (lVar7 = GameObject.GetComponent(this.newObj,DAT_181e568c8)) == null)
          throw; // [null/range check failed]
          lVar7.summonSourceHero = 4;
          if ((this.newObj == null) ||
             (lVar7 = GameObject.GetComponent(this.newObj,DAT_181e568c8)) == null)
          throw; // [null/range check failed]
          lVar7.summonLv = uVar5;
          if ((this.newObj == null) ||
             (lVar7 = GameObject.GetComponent(this.newObj,DAT_181e568c8)) == null)
          throw; // [null/range check failed]
          SkillIconController.AutoSetName(lVar7,0,0,0);
        }
        LAB_1806fc6f9:
        lVar7 = this.targetHero;
        plVar12 = (int64 *)(uint64)(uVar5 + 1);
        if (lVar7 == null) throw; // [null/range check failed]
        goto LAB_1806fb830;
        LAB_1806f8a70:
        plVar13 = &this.targetHero;
        lVar7 = *(int64 *)(local_120 + 40);
        if (lVar7 == null) throw; // [null/range check failed]
        uVar5 = (uint32)plVar6;
        if (lVar7.summonLv <= (int)uVar5) {
          if (_filterType == 14) {
            lVar7 = FUN_1802106e0(0);
            if ((((lVar7 != null) && (lVar7.summonControlable != null)) &&
                (lVar7 = WorldData.Player(lVar7.summonControlable,0)) != null) &&
               (lVar7 = lVar7.selfStorage, plVar6 = plVar12) != null) goto LAB_1806fa980;
          }
          else if (_filterType == 8) {
            lVar7 = FUN_1802106e0(0);
            if ((((lVar7 != null) && (lVar7.summonControlable != null)) &&
                (lVar7 = WorldData.Player(lVar7.summonControlable,0)) != null) &&
               (lVar7 = lVar7.selfStorage) != null) goto LAB_1806fa860;
          }
          else if (_filterType == 6) {
            lVar7 = FUN_1802106e0(0);
            if ((((lVar7 != null) && (lVar7.summonControlable != null)) &&
                (lVar7 = WorldData.Player(lVar7.summonControlable,0)) != null) &&
               (lVar7 = lVar7.selfStorage) != null) goto LAB_1806fa780;
          }
          else if (_filterType == 25) {
            lVar7 = FUN_1802106e0(0);
            if ((((lVar7 != null) && (lVar7.summonControlable != null)) &&
                (lVar7 = WorldData.Player(lVar7.summonControlable,0)) != null) &&
               (lVar7 = lVar7.selfStorage) != null) goto LAB_1806fa370;
          }
          else {
            if (_filterType != 27) goto LAB_1806faecf;
            lVar7 = FUN_1802106e0(0);
            if (((lVar7 != null) && (lVar7.summonControlable != null)) &&
               ((lVar7 = WorldData.Player(lVar7.summonControlable,0), lVar7 != null &&
                (lVar7 = lVar7.selfStorage, plVar6 = plVar12) != null)))
            goto LAB_1806f9c10;
          }
          throw; // [null/range check failed]
        }
        if (lVar7.summonLv <= uVar5) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        lVar7 = lVar7.isSummon[uVar5];
        if (local_res8 != 0) {
          if (lVar7 != null) {
            local_128[0] = lVar7.summonID;
            uVar10 = Int32.ToString(local_128,0);
            cVar2 = FUN_18175e190(local_res8,uVar10);
            if (cVar2) goto LAB_1806f8ada;
            goto LAB_1806f9b63;
          }
          throw; // [null/range check failed]
        }
        LAB_1806f8ada:
        if (2 < *(int *)(param + 24)) {
          plVar6 = (int64 *)FUN_1800024b0(param,2,DAT_181e781e0);
          if (plVar6 == (int64 *)0) throw; // [null/range check failed]
          if (*(int64 *)(*plVar6 + 64) != *(int64 *)(DAT_181e60808 + 64)) {
                          // WARNING: Subroutine does not return
            FUN_1801dfd50(plVar6,DAT_181e60808);
          }
          piVar14 = (int *)il2cpp_object_unbox();
          if (*piVar14 != -1) {
            if (lVar7 == null) throw; // [null/range check failed]
            iVar4 = *(int *)(lVar7 + 60);
            plVar6 = (int64 *)FUN_1800024b0(param,2,DAT_181e781e0);
            if (plVar6 == (int64 *)0) throw; // [null/range check failed]
            if (*(int64 *)(*plVar6 + 64) != *(int64 *)(DAT_181e60808 + 64)) {
                          // WARNING: Subroutine does not return
              FUN_1801dfd50(plVar6,DAT_181e60808);
            }
            piVar14 = (int *)il2cpp_object_unbox();
            if (iVar4 < *piVar14) goto LAB_1806f9b63;
          }
        }
        if (3 < *(int *)(param + 24)) {
          plVar6 = (int64 *)FUN_1800024b0(param,3,DAT_181e781e0);
          if (plVar6 == (int64 *)0) throw; // [null/range check failed]
          if (*(int64 *)(*plVar6 + 64) != *(int64 *)(DAT_181e60808 + 64)) {
                          // WARNING: Subroutine does not return
            FUN_1801dfd50(plVar6,DAT_181e60808);
          }
          piVar14 = (int *)il2cpp_object_unbox();
          if (*piVar14 != -1) {
            if (lVar7 == null) throw; // [null/range check failed]
            iVar4 = *(int *)(lVar7 + 60);
            plVar6 = (int64 *)FUN_1800024b0(param,3,DAT_181e781e0);
            if (plVar6 == (int64 *)0) throw; // [null/range check failed]
            if (*(int64 *)(*plVar6 + 64) != *(int64 *)(DAT_181e60808 + 64)) {
                          // WARNING: Subroutine does not return
              FUN_1801dfd50(plVar6,DAT_181e60808);
            }
            piVar14 = (int *)il2cpp_object_unbox();
            if (*piVar14 < iVar4) goto LAB_1806f9b63;
          }
        }
        if (4 < *(int *)(param + 24)) {
          plVar6 = (int64 *)FUN_1800024b0(param,4,DAT_181e781e0);
          if (plVar6 == (int64 *)0) throw; // [null/range check failed]
          if (*(int64 *)(*plVar6 + 64) != *(int64 *)(DAT_181e60808 + 64)) {
                          // WARNING: Subroutine does not return
            FUN_1801dfd50(plVar6,DAT_181e60808);
          }
          piVar14 = (int *)il2cpp_object_unbox();
          if (*piVar14 != -1) {
            if (lVar7 == null) throw; // [null/range check failed]
            iVar4 = lVar7.summonLv;
            plVar6 = (int64 *)FUN_1800024b0(param,4,DAT_181e781e0);
            if (plVar6 == (int64 *)0) throw; // [null/range check failed]
            if (*(int64 *)(*plVar6 + 64) != *(int64 *)(DAT_181e60808 + 64)) {
                          // WARNING: Subroutine does not return
              FUN_1801dfd50(plVar6,DAT_181e60808);
            }
            piVar14 = (int *)il2cpp_object_unbox();
            if (iVar4 != *piVar14) goto LAB_1806f9b63;
          }
        }
        if (5 < *(int *)(param + 24)) {
          plVar6 = (int64 *)FUN_1800024b0(param,5,DAT_181e781e0);
          if (plVar6 == (int64 *)0) throw; // [null/range check failed]
          if (*(int64 *)(*plVar6 + 64) != *(int64 *)(DAT_181e60808 + 64)) {
                          // WARNING: Subroutine does not return
            FUN_1801dfd50(plVar6,DAT_181e60808);
          }
          piVar14 = (int *)il2cpp_object_unbox();
          if (*piVar14 != -1) {
            if (lVar7 == null) throw; // [null/range check failed]
            iVar4 = lVar7.dailyAIManaged;
            plVar6 = (int64 *)FUN_1800024b0(param,5,DAT_181e781e0);
            if (plVar6 == (int64 *)0) throw; // [null/range check failed]
            if (*(int64 *)(*plVar6 + 64) != *(int64 *)(DAT_181e60808 + 64)) {
                          // WARNING: Subroutine does not return
              FUN_1801dfd50(plVar6,DAT_181e60808);
            }
            piVar14 = (int *)il2cpp_object_unbox();
            if (iVar4 < *piVar14) goto LAB_1806f9b63;
          }
        }
        if (6 < *(int *)(param + 24)) {
          plVar6 = (int64 *)FUN_1800024b0(param,6,DAT_181e781e0);
          if (plVar6 == (int64 *)0) throw; // [null/range check failed]
          if (*(int64 *)(*plVar6 + 64) != *(int64 *)(DAT_181e60808 + 64)) {
                          // WARNING: Subroutine does not return
            FUN_1801dfd50(plVar6,DAT_181e60808);
          }
          piVar14 = (int *)il2cpp_object_unbox();
          if (*piVar14 == -1) goto LAB_1806f8e02;
          if (lVar7 == null) throw; // [null/range check failed]
          if (lVar7.summonID == null) {
            if (lVar7.hide != null) {
              iVar4 = *(int *)(lVar7.hide + 20);
              plVar6 = (int64 *)FUN_1800024b0(param,6,DAT_181e781e0);
              if (plVar6 != (int64 *)0) {
                if (*(int64 *)(*plVar6 + 64) != *(int64 *)(DAT_181e60808 + 64)) {
                          // WARNING: Subroutine does not return
                  FUN_1801dfd50(plVar6,DAT_181e60808);
                }
                piVar14 = (int *)il2cpp_object_unbox();
                if (iVar4 == *piVar14) goto LAB_1806f8e02;
                goto LAB_1806f9b63;
              }
            }
            throw; // [null/range check failed]
          }
          goto LAB_1806f9b63;
        }
        LAB_1806f8e02:
        switch(_filterType) {
        case 2:
          if (lVar7 == null) throw; // [null/range check failed]
          if (lVar7.summonID - 1U < 2) goto switchD_1806f8e27_caseD_9;
          plVar6 = (int64 *)(uint64)(uVar5 + 1);
          goto LAB_1806f8a70;
        case 3:
          if (lVar7 == null) throw; // [null/range check failed]
          if ((lVar7.summonID == 5) && (lVar7.summonLv < 2)) {
        LAB_1806f8e71:
            lVar8 = FUN_180210420();
            if (lVar8 == null) throw; // [null/range check failed]
            if (*(int64 *)(lVar8 + 48) != lVar7) {
              lVar8 = FUN_180210420();
              if (lVar8 == null) throw; // [null/range check failed]
              if (*(int64 *)(lVar8 + 64) != lVar7) goto switchD_1806f8e27_caseD_9;
              plVar6 = (int64 *)(uint64)(uVar5 + 1);
              goto LAB_1806f8a70;
            }
          }
          break;
        case 4:
          if (lVar7 == null) throw; // [null/range check failed]
          if ((lVar7.summonID == 5) && (lVar7.summonLv == 2)) goto LAB_1806f8e71;
          break;
        case 5:
          if (lVar7 == null) throw; // [null/range check failed]
          if ((lVar7.summonID == 5) && (lVar7.summonLv == 3)) goto LAB_1806f8e71;
          break;
        case 6:
          if (lVar7 == null) throw; // [null/range check failed]
          if ((lVar7.summonID == 3) && (lVar7.heroAIData < 5)) {
            if (this.targetHero == null) throw; // [null/range check failed]
            lVar8 = HeroData.FindSameBook(this.targetHero,lVar7);
            if (lVar8 != null) goto switchD_1806f8e27_caseD_9;
            plVar6 = (int64 *)(uint64)(uVar5 + 1);
            goto LAB_1806f8a70;
          }
          break;
        case 7:
          lVar8 = FUN_1802106e0(0);
          if (((lVar8 == null) || (*(int64 *)(lVar8 + 32) == 0)) ||
             (lVar8 = WorldData.Player(*(int64 *)(lVar8 + 32),0)) == null) throw; // [null/range check failed]
          fVar18 = (float)HeroData.GetIdentifyKnowledge(lVar8,0);
          lVar8 = FUN_1802102e0(0);
          if (lVar8 == null) throw; // [null/range check failed]
          iVar4 = 0;
          if (*(int64 *)(lVar8 + 24) != 0) {
            lVar8 = FUN_1802102e0(0);
            uVar3 = FUN_1816387f0(this.sendResultParam,"true");
            if (lVar8 == null) throw; // [null/range check failed]
            iVar4 = BuildingUIController.GetBuildingExtraKnowledge(lVar8,uVar3);
          }
          if ((lVar7 == null) || (lVar8 = lVar7.heroNickName) == null) throw; // [null/range check failed]
          if (*(char *)(lVar8 + 16) == false) {
            if (*(float *)(lVar8 + 20) <= (float)iVar4 + fVar18) goto switchD_1806f8e27_caseD_9;
            plVar6 = (int64 *)(uint64)(uVar5 + 1);
            goto LAB_1806f8a70;
          }
          break;
        case 8:
          if (lVar7 == null) throw; // [null/range check failed]
          if (lVar7.summonID == 3) {
            if ((lVar7.heroFamilyName == null) || (this.targetHero == null)) throw; // [null/range check failed]
            lVar8 = HeroData.FindSkill(this.targetHero,*(uint32 *)(lVar7.heroFamilyName + 16));
            if ((lVar8 == null) || (*(int *)(lVar8 + 20) < 10)) goto switchD_1806f8e27_caseD_9;
            plVar6 = (int64 *)(uint64)(uVar5 + 1);
            goto LAB_1806f8a70;
          }
          break;
        default:
          goto switchD_1806f8e27_caseD_9;
        case 11:
          if (lVar7 == null) throw; // [null/range check failed]
          cVar2 = ItemData.Equiped(lVar7,0);
          if (!cVar2) goto switchD_1806f8e27_caseD_9;
          plVar6 = (int64 *)(uint64)(uVar5 + 1);
          goto LAB_1806f8a70;
        case 13:
          lVar8 = FUN_180210a70(0);
          if (lVar8 == null) throw; // [null/range check failed]
          if (*(int64 *)(lVar8 + 112) != 0) {
            lVar8 = FUN_180210a70(0);
            if ((lVar8 == null) || (*(int64 *)(lVar8 + 112) == 0)) throw; // [null/range check failed]
            cVar2 = HeroData.HaveHobby(*(int64 *)(lVar8 + 112),lVar7);
            if (cVar2) goto switchD_1806f8e27_caseD_9;
            plVar6 = (int64 *)(uint64)(uVar5 + 1);
            goto LAB_1806f8a70;
          }
          goto switchD_1806f8e27_caseD_9;
        case 14:
          if (lVar7 == null) throw; // [null/range check failed]
          if (lVar7.summonID == 3) {
            if (lVar7.heroFamilyName == null) throw; // [null/range check failed]
            iVar4 = *(int *)(lVar7.heroFamilyName + 16);
            lVar8 = FUN_180210280();
            if ((lVar8 == null) || (*(int64 *)(lVar8 + 24) == 0)) throw; // [null/range check failed]
            if (iVar4 == *(int *)(*(int64 *)(lVar8 + 24) + 16)) goto switchD_1806f8e27_caseD_9;
            plVar6 = (int64 *)(uint64)(uVar5 + 1);
            goto LAB_1806f8a70;
          }
          break;
        case 15:
          if (lVar7 == null) throw; // [null/range check failed]
          if ((lVar7.summonID != 5) || (lVar7.summonLv != 4)) break;
          lVar8 = FUN_1802103e0(0);
          if (lVar8 == null) throw; // [null/range check failed]
          uVar10 = *(uint64 *)(lVar8 + 56);
          cVar2 = Object.op_Inequality(uVar10,0);
          if (cVar2) {
            lVar8 = FUN_1802103e0(0);
            if (((lVar8 == null) || (*(int64 *)(lVar8 + 56) == 0)) ||
               (lVar8 = GameObject.GetComponent(*(int64 *)(lVar8 + 56),DAT_181e55168)) == null)
            throw; // [null/range check failed]
            if (lVar7 == *(int64 *)(lVar8 + 32)) break;
          }
          lVar8 = FUN_1802103e0(0);
          if (lVar8 == null) throw; // [null/range check failed]
          uVar10 = *(uint64 *)(lVar8 + 72);
          cVar2 = Object.op_Inequality(uVar10,0);
          if (cVar2) {
            lVar8 = FUN_1802103e0(0);
            if (((lVar8 == null) || (*(int64 *)(lVar8 + 72) == 0)) ||
               (lVar8 = GameObject.GetComponent(*(int64 *)(lVar8 + 72),DAT_181e55168)) == null)
            throw; // [null/range check failed]
            if (lVar7 == *(int64 *)(lVar8 + 32)) break;
          }
          lVar8 = FUN_1802103e0(0);
          if (lVar8 == null) throw; // [null/range check failed]
          uVar10 = *(uint64 *)(lVar8 + 88);
          cVar2 = Object.op_Inequality(uVar10,0);
          if (cVar2) {
            lVar8 = FUN_1802103e0(0);
            if (((lVar8 == null) || (*(int64 *)(lVar8 + 88) == 0)) ||
               (lVar8 = GameObject.GetComponent(*(int64 *)(lVar8 + 88),DAT_181e55168)) == null)
            throw; // [null/range check failed]
            if (lVar7 != *(int64 *)(lVar8 + 32)) goto switchD_1806f8e27_caseD_9;
            plVar6 = (int64 *)(uint64)(uVar5 + 1);
            goto LAB_1806f8a70;
          }
          goto switchD_1806f8e27_caseD_9;
        case 16:
          if (((lVar7 == null) || (lVar7.hide == null)) ||
             (lVar8 = *(int64 *)(lVar7.hide + 64)) == null) throw; // [null/range check failed]
          if (0.0 < *(float *)(lVar8 + 16)) {
            plVar6 = (int64 *)(uint64)(uVar5 + 1);
            goto LAB_1806f8a70;
          }
        switchD_1806f8e27_caseD_9:
          uVar10 = this.targetGrid;
          lVar8 = FUN_1802107e0(0);
          if (lVar8 == null) throw; // [null/range check failed]
          uVar15 = *(uint64 *)(lVar8 + 160);
          uVar10 = GlobalData.AddChild(uVar10,uVar15);
          this.newObj = uVar10;
          if ((this.newObj == null) ||
             (lVar8 = GameObject.GetComponent(this.newObj,DAT_181e55168)) == null)
          throw; // [null/range check failed]
          *(int64 *)(lVar8 + 32) = lVar7;
          if ((this.newObj == null) ||
             (lVar8 = GameObject.GetComponent(this.newObj,DAT_181e55168)) == null)
          throw; // [null/range check failed]
          *(uint32 *)(lVar8 + 40) = 3;
          if ((this.newObj == null) ||
             (lVar8 = GameObject.GetComponent(this.newObj,DAT_181e55168)) == null)
          throw; // [null/range check failed]
          ItemIconController.AutoSetName(lVar8,1);
          if ((_cancelFuc != null) && (cVar2 = HeroData.HaveHobby(_cancelFuc,lVar7), cVar2)) {
            uVar10 = this.newObj;
            lVar7 = FUN_180210d00(0);
            if (lVar7 == null) throw; // [null/range check failed]
            uVar15 = TextureController.LoadAtlasSprite(lVar7,"UIAtlas","友善度",0);
            local_118 = 0x420c0000;
            uStack_114 = 0x420c0000;
            uStack_110 = 0;
            local_f8 = 0;
            uStack_f0 = 0;
            FUN_180de6c10(&local_f8,&local_118,DAT_181e9d678);
            local_108 = local_f8;
            uStack_100 = uStack_f0;
            local_d8 = 0;
            uStack_d0 = 0;
            lVar7 = GlobalData.AddImage(uVar10,"HobbyIcon",uVar15,&local_108,&local_d8,0);
            if (lVar7 == null) throw; // [null/range check failed]
            plVar6 = (int64 *)GameObject.GetComponent(lVar7,DAT_181e54f48);
            uVar10 = 0;
            local_e8 = 0;
            uStack_e0 = 0;
            Color.ctor(&local_e8);
            if (plVar6 == (int64 *)0) throw; // [null/range check failed]
            lVar8 = *plVar6;
            local_108 = local_e8;
            uStack_100 = uStack_e0;
            (**(code **)(lVar8 + 0x2a8))(plVar6,&local_108,*(uint64 *)(lVar8 + 0x2b0),lVar8,uVar10);
            plVar6 = (int64 *)GameObject.GetComponent(lVar7,DAT_181e54f48);
            if (plVar6 == (int64 *)0) throw; // [null/range check failed]
            (**(code **)(*plVar6 + 0x408))(plVar6,*(uint64 *)(*plVar6 + 0x410));
            lVar8 = GameObject.AddComponent(lVar7,DAT_181e51de0);
            if (lVar8 == null) throw; // [null/range check failed]
            *(uint64 *)(lVar8 + 24) = "对方喜好\n赠送好感加倍";
            lVar7 = GameObject.GetComponent(lVar7,DAT_181e56510);
            if (lVar7 == null) throw; // [null/range check failed]
            lVar7.summonSourceHero = 1;
          }
          break;
        case 17:
          if (lVar7 == null) throw; // [null/range check failed]
          if (0.0 < *(float *)(lVar7 + 76)) {
            cVar2 = ItemData.DetectPoisonNum(lVar7,0);
            if (cVar2) goto switchD_1806f8e27_caseD_9;
            plVar6 = (int64 *)(uint64)(uVar5 + 1);
            goto LAB_1806f8a70;
          }
          break;
        case 20:
          lVar8 = FUN_1806ef760();
          if (lVar8 == null) throw; // [null/range check failed]
          plVar6 = plVar12;
          if (*(int *)(lVar8 + 40) == 0) {
            if (lVar7 == null) throw; // [null/range check failed]
            if (lVar7.summonLv - 2U >= 2)
            {
              }
              else {
              if (lVar7 == null) throw; // [null/range check failed]
              if (lVar7.summonLv == 4) {
            }
              do {
                lVar8 = FUN_1806ef760(0);
                if ((lVar8 == null) || (*(int64 *)(lVar8 + 32) == 0)) throw; // [null/range check failed]
                if (*(int *)(*(int64 *)(lVar8 + 32) + 24) <= (int)plVar6)
                goto switchD_1806f8e27_caseD_9;
                lVar8 = FUN_1806ef760(0);
                if ((lVar8 == null) || (*(int64 *)(lVar8 + 32) == 0)) throw; // [null/range check failed]
                uVar10 = FUN_1800024b0(*(int64 *)(lVar8 + 32),plVar6);
                cVar2 = Object.op_Inequality(uVar10,0);
                if (cVar2) {
                  lVar8 = FUN_1806ef760(0);
                  if ((((lVar8 == null) || (*(int64 *)(lVar8 + 32) == 0)) ||
                      (lVar8 = FUN_1800024b0(*(int64 *)(lVar8 + 32),plVar6)) == null) ||
                     (lVar8 = GameObject.GetComponent(lVar8,DAT_181e55168)) == null)
                  throw; // [null/range check failed]
                  if (*(int64 *)(lVar8 + 32) == lVar7) break;
                }
                plVar6 = (int64 *)(uint64)((int)plVar6 + 1);
              } while( true );
            }
          }
          break;
        case 21:
          if (((lVar7 == null) || (lVar7.heroFamilyName == null)) ||
             (lVar8 = BookData.DataBase(lVar7.heroFamilyName,0)) == null) throw; // [null/range check failed]
          cVar2 = KungfuSkillData.HaveForce(lVar8,0);
          if (cVar2) {
            if ((lVar7.heroFamilyName == null) ||
               (lVar8 = BookData.DataBase(lVar7.heroFamilyName,0)) == null)
            throw; // [null/range check failed]
            iVar4 = *(int *)(lVar8 + 24);
            lVar8 = FUN_1802106e0(0);
            if (((lVar8 == null) || (*(int64 *)(lVar8 + 32) == 0)) ||
               (lVar8 = WorldData.Player(*(int64 *)(lVar8 + 32),0)) == null) throw; // [null/range check failed]
            plVar6 = plVar12;
            if (iVar4 != *(int *)(lVar8 + 132)) {
              while( true ) {
                lVar8 = FUN_1802106e0(0);
                if ((((lVar8 == null) || (*(int64 *)(lVar8 + 32) == 0)) ||
                    (lVar8 = *(int64 *)(*(int64 *)(lVar8 + 32) + 0x218)) == null) ||
                   (lVar8 = *(int64 *)(lVar8 + 40)) == null) throw; // [null/range check failed]
                if (*(int *)(lVar8 + 24) <= (int)plVar6) goto switchD_1806f8e27_caseD_9;
                lVar8 = FUN_1802106e0(0);
                if ((((lVar8 == null) || (*(int64 *)(lVar8 + 32) == 0)) ||
                    ((lVar8 = *(int64 *)(*(int64 *)(lVar8 + 32) + 0x218), lVar8 == null ||
                     (((lVar8 = *(int64 *)(lVar8 + 40), lVar8 == null ||
                       (lVar8 = FUN_1800024b0(lVar8,plVar6)) == null) ||
                      (*(int64 *)(lVar8 + 112) == 0)))))) || (lVar7.heroFamilyName == null))
                throw; // [null/range check failed]
                if (*(int *)(*(int64 *)(lVar8 + 112) + 16) ==
                    *(int *)(lVar7.heroFamilyName + 16)) break;
                plVar6 = (int64 *)(uint64)((int)plVar6 + 1);
              }
            }
          }
          break;
        case 24:
          lVar8 = FUN_180210a70();
          if (lVar8 == null) throw; // [null/range check failed]
          if (*(int64 *)(lVar8 + 112) == 0) {
            fVar18 = 0.0;
          }
          else {
            lVar8 = FUN_180210a70(0);
            if ((lVar8 == null) || (*(int64 *)(lVar8 + 112) == 0)) throw; // [null/range check failed]
            fVar18 = (float)HeroData.GetIdentifyKnowledge(*(int64 *)(lVar8 + 112),0);
          }
          if ((lVar7 == null) || (lVar8 = lVar7.heroNickName) == null) throw; // [null/range check failed]
          if (*(char *)(lVar8 + 16) != false) break;
          if (*(float *)(lVar8 + 20) <= fVar18) goto switchD_1806f8e27_caseD_9;
          plVar6 = (int64 *)(uint64)(uVar5 + 1);
          goto LAB_1806f8a70;
        case 27:
          if (lVar7 == null) throw; // [null/range check failed]
          if (lVar7.summonID == 3) {
            if ((lVar7.heroFamilyName == null) ||
               (lVar8 = BookData.DataBase(lVar7.heroFamilyName,0)) == null)
            throw; // [null/range check failed]
            iVar4 = *(int *)(lVar8 + 52);
            lVar8 = FUN_180210a70();
            if ((lVar8 == null) || (*(int64 *)(lVar8 + 112) == 0)) throw; // [null/range check failed]
            if (iVar4 <= *(int *)(*(int64 *)(lVar8 + 112) + 184)) {
              lVar8 = FUN_180210a70(0);
              if (lVar8 == null) throw; // [null/range check failed]
              if ((lVar7.heroFamilyName == null) || (*(int64 *)(lVar8 + 112) == 0))
              throw; // [null/range check failed]
              lVar8 = HeroData.FindSkill(*(int64 *)(lVar8 + 112),
                                          *(uint32 *)(lVar7.heroFamilyName + 16));
              if (lVar8 == null) goto switchD_1806f8e27_caseD_9;
            }
          }
        }
        LAB_1806f9b63:
        plVar6 = (int64 *)(uint64)(uVar5 + 1);
        goto LAB_1806f8a70;
        LAB_1806fa980:
        lVar8 = lVar7.summonSourceHero;
        if (lVar8 == null) throw; // [null/range check failed]
        uVar5 = (uint32)plVar6;
        if (*(int *)(lVar8 + 24) <= (int)uVar5) {
          lVar7 = FUN_1802106e0(0);
          if (((lVar7 != null) && (lVar7.summonControlable != null)) &&
             (lVar7 = WorldData.Player(lVar7.summonControlable,0)) != null) {
            lVar7 = HeroData.GetForce(lVar7,0,0);
            if (lVar7 == null) goto LAB_1806faecf;
            lVar7 = FUN_1802106e0(0);
            if ((((lVar7 != null) && (lVar7.summonControlable != null)) &&
                (lVar7 = WorldData.Player(lVar7.summonControlable,0)) != null) &&
               ((lVar7 = HeroData.GetForce(lVar7,0,0), lVar7 != null &&
                (lVar7 = lVar7.heroForceLv, plVar6 = plVar12) != null))) goto LAB_1806fab50;
          }
          throw; // [null/range check failed]
        }
        if (*(uint32 *)(lVar8 + 24) <= uVar5) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        lVar8 = lVar8[uVar5];
        if (lVar8 == null) throw; // [null/range check failed]
        if (*(int *)(lVar8 + 20) == 3) {
          if (((lVar7.summonSourceHero == null) || (lVar8 = FUN_1800024b0()) == null) ||
             (*(int64 *)(lVar8 + 112) == 0)) throw; // [null/range check failed]
          iVar4 = *(int *)(*(int64 *)(lVar8 + 112) + 16);
          lVar8 = FUN_180210280();
          if ((lVar8 == null) || (*(int64 *)(lVar8 + 24) == 0)) throw; // [null/range check failed]
          if (iVar4 == *(int *)(*(int64 *)(lVar8 + 24) + 16)) {
            if (lVar7.summonSourceHero == null) throw; // [null/range check failed]
            uVar10 = FUN_1800024b0(lVar7.summonSourceHero,plVar6,DAT_181e73170);
            ChooseController.CreateChooseItem(this,uVar10,"仓库",0);
          }
        }
        plVar6 = (int64 *)(uint64)(uVar5 + 1);
        goto LAB_1806fa980;
        LAB_1806fab50:
        lVar8 = lVar7.summonSourceHero;
        if (lVar8 == null) throw; // [null/range check failed]
        uVar5 = (uint32)plVar6;
        plVar13 = plVar12;
        if (*(int *)(lVar8 + 24) <= (int)uVar5) goto LAB_1806fac50;
        if (*(uint32 *)(lVar8 + 24) <= uVar5) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        lVar8 = lVar8[uVar5];
        if (lVar8 == null) throw; // [null/range check failed]
        if (*(int *)(lVar8 + 20) == 3) {
          if (((lVar7.summonSourceHero == null) || (lVar8 = FUN_1800024b0()) == null) ||
             (*(int64 *)(lVar8 + 112) == 0)) throw; // [null/range check failed]
          iVar4 = *(int *)(*(int64 *)(lVar8 + 112) + 16);
          lVar8 = FUN_180210280();
          if ((lVar8 == null) || (*(int64 *)(lVar8 + 24) == 0)) throw; // [null/range check failed]
          if (iVar4 == *(int *)(*(int64 *)(lVar8 + 24) + 16)) {
            if (lVar7.summonSourceHero == null) throw; // [null/range check failed]
            uVar10 = FUN_1800024b0(lVar7.summonSourceHero,plVar6,DAT_181e73170);
            ChooseController.CreateChooseItem(this,uVar10,"藏经阁",0);
          }
        }
        plVar6 = (int64 *)(uint64)(uVar5 + 1);
        goto LAB_1806fab50;
        LAB_1806fac50:
        if ((((GameController._instance == null) ||
             (lVar7 = GameController._instance.worldData) == null) ||
            (lVar7 = WorldData.Player(lVar7,0)) == null) ||
           ((lVar7 = HeroData.GetForce(lVar7,0,0), lVar7 == null || (lVar7.heroAIData == null))))
        throw; // [null/range check failed]
        if (*(int *)(lVar7.heroAIData + 24) <= (int)plVar13) goto LAB_1806faecf;
        lVar7 = FUN_1802106e0(0);
        if (lVar7 == null) throw; // [null/range check failed]
        lVar7 = lVar7.summonControlable;
        lVar8 = FUN_1802106e0(0);
        if ((((((lVar8 == null) || (*(int64 *)(lVar8 + 32) == 0)) ||
              (lVar8 = WorldData.Player(*(int64 *)(lVar8 + 32),0)) == null) ||
             ((lVar8 = HeroData.GetForce(lVar8,0,0), lVar8 == null || (*(int64 *)(lVar8 + 64) == 0))))
            || (FUN_180002480(*(int64 *)(lVar8 + 64),plVar13), lVar7 == null)) ||
           (lVar7 = WorldData.GetForce(lVar7)) == null) throw; // [null/range check failed]
        lVar7 = lVar7.heroForceLv;
        plVar6 = plVar12;
        while( true ) {
          if ((lVar7 == null) || (lVar7.summonSourceHero == null)) throw; // [null/range check failed]
          if (*(int *)(lVar7.summonSourceHero + 24) <= (int)plVar6) break;
          lVar8 = FUN_1800024b0();
          if (lVar8 == null) throw; // [null/range check failed]
          if (*(int *)(lVar8 + 20) == 3) {
            if (((lVar7.summonSourceHero == null) || (lVar8 = FUN_1800024b0()) == null) ||
               (*(int64 *)(lVar8 + 112) == 0)) throw; // [null/range check failed]
            iVar4 = *(int *)(*(int64 *)(lVar8 + 112) + 16);
            lVar8 = FUN_180210280(0);
            if ((lVar8 == null) || (*(int64 *)(lVar8 + 24) == 0)) throw; // [null/range check failed]
            if (iVar4 == *(int *)(*(int64 *)(lVar8 + 24) + 16)) {
              if (lVar7.summonSourceHero == null) throw; // [null/range check failed]
              uVar10 = FUN_1800024b0(lVar7.summonSourceHero,plVar6,DAT_181e73170);
              ChooseController.CreateChooseItem(this,uVar10,"附庸藏经阁",0);
            }
          }
          plVar6 = (int64 *)(uint64)((int)plVar6 + 1);
        }
        plVar13 = (int64 *)(uint64)((int)plVar13 + 1);
        goto LAB_1806fac50;
        LAB_1806fa860:
        lVar8 = lVar7.summonSourceHero;
        if (lVar8 == null) throw; // [null/range check failed]
        uVar5 = (uint32)plVar12;
        if (*(int *)(lVar8 + 24) <= (int)uVar5) goto LAB_1806faecf;
        if (*(uint32 *)(lVar8 + 24) <= uVar5) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        lVar8 = lVar8[uVar5];
        if (lVar8 == null) throw; // [null/range check failed]
        if (*(int *)(lVar8 + 20) == 3) {
          if ((*(int64 *)(lVar8 + 112) == 0) || (*plVar13 == 0)) throw; // [null/range check failed]
          lVar16 = HeroData.FindSkill(*plVar13,*(uint32 *)(*(int64 *)(lVar8 + 112) + 16),0);
          if (lVar16 != null) {
            if (((*(int64 *)(lVar8 + 112) == 0) || (*plVar13 == 0)) ||
               (lVar16 = HeroData.FindSkill(*plVar13,*(uint32 *)(*(int64 *)(lVar8 + 112) + 16),
                                             0), lVar16 == null)) throw; // [null/range check failed]
            if (9 >= *(int *)(lVar16 + 20))
            {
              }
              ChooseController.CreateChooseItem(this,lVar8,"仓库",0);
              }
            }
        plVar12 = (int64 *)(uint64)(uVar5 + 1);
        goto LAB_1806fa860;
        LAB_1806fa780:
        lVar8 = lVar7.summonSourceHero;
        if (lVar8 == null) throw; // [null/range check failed]
        uVar5 = (uint32)plVar12;
        if (*(int *)(lVar8 + 24) <= (int)uVar5) goto LAB_1806faecf;
        if (*(uint32 *)(lVar8 + 24) <= uVar5) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        lVar8 = lVar8[uVar5];
        if (lVar8 == null) throw; // [null/range check failed]
        if ((*(int *)(lVar8 + 20) == 3) && (*(int *)(lVar8 + 64) < 5)) {
          if (*plVar13 == 0) throw; // [null/range check failed]
          lVar16 = HeroData.FindSameBook(*plVar13,lVar8,0);
          if (lVar16 != null) {
            ChooseController.CreateChooseItem(this,lVar8,"仓库",0);
          }
        }
        plVar12 = (int64 *)(uint64)(uVar5 + 1);
        goto LAB_1806fa780;
        LAB_1806fa370:
        lVar8 = lVar7.summonSourceHero;
        if (lVar8 == null) throw; // [null/range check failed]
        uVar5 = (uint32)plVar12;
        if (*(int *)(lVar8 + 24) <= (int)uVar5) goto LAB_1806faecf;
        if (*(uint32 *)(lVar8 + 24) <= uVar5) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        lVar8 = lVar8[uVar5];
        if (local_res8 != 0) {
          if (lVar8 != null) {
            local_128[0] = *(uint32 *)(lVar8 + 20);
            uVar10 = Int32.ToString(local_128,0);
            cVar2 = FUN_18175e190(local_res8,uVar10,DAT_181e86470);
            if (cVar2) goto LAB_1806fa3da;
            goto LAB_1806fa713;
          }
          throw; // [null/range check failed]
        }
        LAB_1806fa3da:
        if (2 < *(int *)(param + 24)) {
          plVar12 = (int64 *)FUN_1800024b0(param,2,DAT_181e781e0);
          if (plVar12 == (int64 *)0) throw; // [null/range check failed]
          if (*(int64 *)(*plVar12 + 64) != *(int64 *)(DAT_181e60808 + 64)) {
                          // WARNING: Subroutine does not return
            FUN_1801dfd50(plVar12,DAT_181e60808);
          }
          piVar14 = (int *)il2cpp_object_unbox();
          if (*piVar14 != -1) {
            if (lVar8 == null) throw; // [null/range check failed]
            iVar4 = *(int *)(lVar8 + 60);
            plVar12 = (int64 *)FUN_1800024b0(param,2,DAT_181e781e0);
            if (plVar12 == (int64 *)0) throw; // [null/range check failed]
            if (*(int64 *)(*plVar12 + 64) != *(int64 *)(DAT_181e60808 + 64)) {
                          // WARNING: Subroutine does not return
              FUN_1801dfd50(plVar12,DAT_181e60808);
            }
            piVar14 = (int *)il2cpp_object_unbox();
            if (iVar4 < *piVar14) goto LAB_1806fa713;
          }
        }
        if (3 < *(int *)(param + 24)) {
          plVar12 = (int64 *)FUN_1800024b0(param,3,DAT_181e781e0);
          if (plVar12 == (int64 *)0) throw; // [null/range check failed]
          if (*(int64 *)(*plVar12 + 64) != *(int64 *)(DAT_181e60808 + 64)) {
                          // WARNING: Subroutine does not return
            FUN_1801dfd50(plVar12,DAT_181e60808);
          }
          piVar14 = (int *)il2cpp_object_unbox();
          if (*piVar14 != -1) {
            if (lVar8 == null) throw; // [null/range check failed]
            iVar4 = *(int *)(lVar8 + 60);
            plVar12 = (int64 *)FUN_1800024b0(param,3,DAT_181e781e0);
            if (plVar12 == (int64 *)0) throw; // [null/range check failed]
            if (*(int64 *)(*plVar12 + 64) != *(int64 *)(DAT_181e60808 + 64)) {
                          // WARNING: Subroutine does not return
              FUN_1801dfd50(plVar12,DAT_181e60808);
            }
            piVar14 = (int *)il2cpp_object_unbox();
            if (*piVar14 < iVar4) goto LAB_1806fa713;
          }
        }
        if (4 < *(int *)(param + 24)) {
          plVar12 = (int64 *)FUN_1800024b0(param,4,DAT_181e781e0);
          if (plVar12 == (int64 *)0) throw; // [null/range check failed]
          if (*(int64 *)(*plVar12 + 64) != *(int64 *)(DAT_181e60808 + 64)) {
                          // WARNING: Subroutine does not return
            FUN_1801dfd50(plVar12,DAT_181e60808);
          }
          piVar14 = (int *)il2cpp_object_unbox();
          if (*piVar14 != -1) {
            if (lVar8 == null) throw; // [null/range check failed]
            iVar4 = *(int *)(lVar8 + 24);
            plVar12 = (int64 *)FUN_1800024b0(param,4,DAT_181e781e0);
            if (plVar12 == (int64 *)0) throw; // [null/range check failed]
            if (*(int64 *)(*plVar12 + 64) != *(int64 *)(DAT_181e60808 + 64)) {
                          // WARNING: Subroutine does not return
              FUN_1801dfd50(plVar12,DAT_181e60808);
            }
            piVar14 = (int *)il2cpp_object_unbox();
            if (iVar4 != *piVar14) goto LAB_1806fa713;
          }
        }
        if (5 < *(int *)(param + 24)) {
          plVar12 = (int64 *)FUN_1800024b0(param,5,DAT_181e781e0);
          if (plVar12 == (int64 *)0) throw; // [null/range check failed]
          if (*(int64 *)(*plVar12 + 64) != *(int64 *)(DAT_181e60808 + 64)) {
                          // WARNING: Subroutine does not return
            FUN_1801dfd50(plVar12,DAT_181e60808);
          }
          piVar14 = (int *)il2cpp_object_unbox();
          if (*piVar14 != -1) {
            if (lVar8 == null) throw; // [null/range check failed]
            iVar4 = *(int *)(lVar8 + 56);
            plVar12 = (int64 *)FUN_1800024b0(param,5,DAT_181e781e0);
            if (plVar12 == (int64 *)0) throw; // [null/range check failed]
            if (*(int64 *)(*plVar12 + 64) != *(int64 *)(DAT_181e60808 + 64)) {
                          // WARNING: Subroutine does not return
              FUN_1801dfd50(plVar12,DAT_181e60808);
            }
            piVar14 = (int *)il2cpp_object_unbox();
            if (iVar4 < *piVar14) goto LAB_1806fa713;
          }
        }
        if (*(int *)(param + 24) < 7) {
        LAB_1806fa6fa:
          ChooseController.CreateChooseItem(this,lVar8,"仓库",0);
        }
        else {
          plVar12 = (int64 *)FUN_1800024b0(param,6,DAT_181e781e0);
          if (plVar12 == (int64 *)0) throw; // [null/range check failed]
          if (*(int64 *)(*plVar12 + 64) != *(int64 *)(DAT_181e60808 + 64)) {
                          // WARNING: Subroutine does not return
            FUN_1801dfd50(plVar12,DAT_181e60808);
          }
          piVar14 = (int *)il2cpp_object_unbox();
          if (*piVar14 == -1) goto LAB_1806fa6fa;
          if (lVar8 == null) throw; // [null/range check failed]
          if (*(int *)(lVar8 + 20) == 0) {
            if (*(int64 *)(lVar8 + 96) == 0) throw; // [null/range check failed]
            iVar4 = *(int *)(*(int64 *)(lVar8 + 96) + 20);
            plVar12 = (int64 *)FUN_1800024b0(param,6,DAT_181e781e0);
            if (plVar12 == (int64 *)0) throw; // [null/range check failed]
            if (*(int64 *)(*plVar12 + 64) != *(int64 *)(DAT_181e60808 + 64)) {
                          // WARNING: Subroutine does not return
              FUN_1801dfd50();
            }
            piVar14 = (int *)il2cpp_object_unbox();
            if (iVar4 == *piVar14) goto LAB_1806fa6fa;
          }
        }
        LAB_1806fa713:
        plVar12 = (int64 *)(uint64)(uVar5 + 1);
        goto LAB_1806fa370;
        LAB_1806f9c10:
        lVar8 = lVar7.summonSourceHero;
        if (lVar8 == null) throw; // [null/range check failed]
        uVar5 = (uint32)plVar6;
        if (*(int *)(lVar8 + 24) <= (int)uVar5) {
          lVar7 = FUN_1802106e0(0);
          if (((lVar7 != null) && (lVar7.summonControlable != null)) &&
             (lVar7 = WorldData.Player(lVar7.summonControlable,0)) != null) {
            lVar7 = HeroData.GetForce(lVar7,0,0);
            if (lVar7 == null) goto LAB_1806faecf;
            lVar7 = FUN_1802106e0(0);
            if (((lVar7 != null) && (lVar7.summonControlable != null)) &&
               ((lVar7 = WorldData.Player(lVar7.summonControlable,0), lVar7 != null &&
                ((lVar7 = HeroData.GetForce(lVar7,0,0), lVar7 != null &&
                 (lVar7 = lVar7.heroForceLv, plVar6 = plVar12) != null)))))
            goto LAB_1806f9e70;
          }
          throw; // [null/range check failed]
        }
        if (*(uint32 *)(lVar8 + 24) <= uVar5) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        lVar8 = lVar8[uVar5];
        if (lVar8 == null) throw; // [null/range check failed]
        if (*(int *)(lVar8 + 20) == 3) {
          if (((lVar7.summonSourceHero == null) || (lVar8 = FUN_1800024b0()) == null) ||
             ((*(int64 *)(lVar8 + 112) == 0 || (lVar8 = BookData.DataBase()) == null)))
          throw; // [null/range check failed]
          iVar4 = *(int *)(lVar8 + 52);
          lVar8 = FUN_180210a70();
          if ((lVar8 == null) || (*(int64 *)(lVar8 + 112) == 0)) throw; // [null/range check failed]
          if (iVar4 <= *(int *)(*(int64 *)(lVar8 + 112) + 184)) {
            lVar8 = FUN_180210a70(0);
            if (lVar8 == null) throw; // [null/range check failed]
            lVar8 = *(int64 *)(lVar8 + 112);
            if ((((lVar7.summonSourceHero == null) ||
                 (lVar16 = FUN_1800024b0(lVar7.summonSourceHero,plVar6)) == null) ||
                (*(int64 *)(lVar16 + 112) == 0)) || (lVar8 == null)) throw; // [null/range check failed]
            lVar8 = HeroData.FindSkill();
            if (lVar8 == null) {
              if (lVar7.summonSourceHero == null) throw; // [null/range check failed]
              uVar10 = FUN_1800024b0(lVar7.summonSourceHero,plVar6,DAT_181e73170);
              ChooseController.CreateChooseItem(this,uVar10,"仓库",0);
            }
          }
        }
        plVar6 = (int64 *)(uint64)(uVar5 + 1);
        goto LAB_1806f9c10;
        LAB_1806f9e70:
        lVar8 = lVar7.summonSourceHero;
        if (lVar8 == null) throw; // [null/range check failed]
        uVar5 = (uint32)plVar6;
        plVar13 = plVar12;
        if (*(int *)(lVar8 + 24) <= (int)uVar5) goto LAB_1806fa000;
        if (*(uint32 *)(lVar8 + 24) <= uVar5) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        lVar8 = lVar8[uVar5];
        if (lVar8 == null) throw; // [null/range check failed]
        if (*(int *)(lVar8 + 20) == 3) {
          if (((lVar7.summonSourceHero == null) || (lVar8 = FUN_1800024b0()) == null) ||
             ((*(int64 *)(lVar8 + 112) == 0 || (lVar8 = BookData.DataBase()) == null)))
          throw; // [null/range check failed]
          iVar4 = *(int *)(lVar8 + 52);
          lVar8 = FUN_180210a70();
          if ((lVar8 == null) || (*(int64 *)(lVar8 + 112) == 0)) throw; // [null/range check failed]
          if (iVar4 <= *(int *)(*(int64 *)(lVar8 + 112) + 184)) {
            lVar8 = FUN_180210a70(0);
            if (lVar8 == null) throw; // [null/range check failed]
            lVar8 = *(int64 *)(lVar8 + 112);
            if ((((lVar7.summonSourceHero == null) ||
                 (lVar16 = FUN_1800024b0(lVar7.summonSourceHero,plVar6)) == null) ||
                (*(int64 *)(lVar16 + 112) == 0)) || (lVar8 == null)) throw; // [null/range check failed]
            lVar8 = HeroData.FindSkill();
            if (lVar8 == null) {
              if (lVar7.summonSourceHero == null) throw; // [null/range check failed]
              uVar10 = FUN_1800024b0(lVar7.summonSourceHero,plVar6,DAT_181e73170);
              ChooseController.CreateChooseItem(this,uVar10,"藏经阁",0);
            }
          }
        }
        plVar6 = (int64 *)(uint64)(uVar5 + 1);
        goto LAB_1806f9e70;
        LAB_1806fa000:
        if ((((GameController._instance == null) ||
             (lVar7 = GameController._instance.worldData) == null) ||
            (lVar7 = WorldData.Player(lVar7,0)) == null) ||
           ((lVar7 = HeroData.GetForce(lVar7,0,0), lVar7 == null || (lVar7.heroAIData == null))))
        throw; // [null/range check failed]
        if (*(int *)(lVar7.heroAIData + 24) <= (int)plVar13) goto LAB_1806faecf;
        lVar7 = FUN_1802106e0(0);
        if (lVar7 == null) throw; // [null/range check failed]
        lVar7 = lVar7.summonControlable;
        lVar8 = FUN_1802106e0(0);
        if ((((lVar8 == null) || (*(int64 *)(lVar8 + 32) == 0)) ||
            (lVar8 = WorldData.Player(*(int64 *)(lVar8 + 32),0)) == null) ||
           (((lVar8 = HeroData.GetForce(lVar8,0,0), lVar8 == null || (*(int64 *)(lVar8 + 64) == 0)) ||
            ((FUN_180002480(*(int64 *)(lVar8 + 64),plVar13), lVar7 == null ||
             (lVar7 = WorldData.GetForce(lVar7)) == null))))) throw; // [null/range check failed]
        lVar7 = lVar7.heroForceLv;
        plVar6 = plVar12;
        while( true ) {
          if ((lVar7 == null) || (lVar7.summonSourceHero == null)) throw; // [null/range check failed]
          if (*(int *)(lVar7.summonSourceHero + 24) <= (int)plVar6) break;
          lVar8 = FUN_1800024b0();
          if (lVar8 == null) throw; // [null/range check failed]
          if (*(int *)(lVar8 + 20) == 3) {
            if ((((lVar7.summonSourceHero == null) || (lVar8 = FUN_1800024b0()) == null) ||
                (*(int64 *)(lVar8 + 112) == 0)) || (lVar8 = BookData.DataBase()) == null)
            throw; // [null/range check failed]
            iVar4 = *(int *)(lVar8 + 52);
            lVar8 = FUN_180210a70(0);
            if ((lVar8 == null) || (*(int64 *)(lVar8 + 112) == 0)) throw; // [null/range check failed]
            if (iVar4 <= *(int *)(*(int64 *)(lVar8 + 112) + 184)) {
              lVar8 = FUN_180210a70(0);
              if (lVar8 == null) throw; // [null/range check failed]
              lVar8 = *(int64 *)(lVar8 + 112);
              if ((((lVar7.summonSourceHero == null) ||
                   (lVar16 = FUN_1800024b0(lVar7.summonSourceHero,plVar6)) == null) ||
                  (*(int64 *)(lVar16 + 112) == 0)) || (lVar8 == null)) throw; // [null/range check failed]
              lVar8 = HeroData.FindSkill(lVar8);
              if (lVar8 == null) {
                if (lVar7.summonSourceHero == null) throw; // [null/range check failed]
                uVar10 = FUN_1800024b0(lVar7.summonSourceHero,plVar6,DAT_181e73170);
                ChooseController.CreateChooseItem(this,uVar10,"附庸藏经阁",0);
              }
            }
          }
          plVar6 = (int64 *)(uint64)((int)plVar6 + 1);
        }
        plVar13 = (int64 *)(uint64)((int)plVar13 + 1);
        goto LAB_1806fa000;
        LAB_1806f87d6:
        iVar4 = (int)plVar6;
        local_130 = iVar4;
        lVar7 = *(int64 *)(pStatics_38e8 + 0x4d8);
        if (lVar7 == null) throw; // [null/range check failed]
        if (iVar4 < lVar7.summonLv) {
          if (local_res8 == 0) {
        LAB_1806f899b:
            if (((this.itemList == null) ||
                (lVar7 = GameObject.get_transform(this.itemList,0)) == null) ||
               (lVar7 = Transform.Find(lVar7,"ItemFlitter")) == null) throw; // [null/range check failed]
            lVar7 = Transform.Find(lVar7,"ItemTypeFlitter");
            uVar10 = Int32.ToString(&local_130,0);
            if (((lVar7 == null) || (lVar7 = Transform.Find(lVar7,uVar10)) == null) ||
               (lVar7 = Component.GetComponent(lVar7,DAT_181e796b8)) == null) throw; // [null/range check failed]
            Selectable.set_interactable(lVar7);
            plVar6 = (int64 *)(uint64)(local_130 + 1);
          }
          else {
            uVar10 = Int32.ToString(&local_130,0);
            cVar2 = FUN_18175e190(local_res8,uVar10);
            if (cVar2) goto LAB_1806f899b;
            if (((this.itemList == null) ||
                (lVar7 = GameObject.get_transform(this.itemList,0)) == null) ||
               (lVar7 = Transform.Find(lVar7,"ItemFlitter")) == null) throw; // [null/range check failed]
            lVar7 = Transform.Find(lVar7,"ItemTypeFlitter");
            uVar10 = Int32.ToString(&local_130,0);
            if (((lVar7 == null) || (lVar7 = Transform.Find(lVar7,uVar10)) == null) ||
               (lVar7 = Component.GetComponent(lVar7,DAT_181e796b8)) == null) throw; // [null/range check failed]
            Selectable.set_interactable(lVar7,0);
            if (((this.itemList == null) ||
                (lVar7 = GameObject.get_transform(this.itemList,0)) == null) ||
               (lVar7 = Transform.Find(lVar7,"ItemFlitter")) == null) throw; // [null/range check failed]
            lVar7 = Transform.Find(lVar7,"ItemTypeFlitter");
            uVar10 = Int32.ToString(&local_130,0);
            if (((lVar7 == null) || (lVar7 = Transform.Find(lVar7,uVar10)) == null) ||
               (lVar7 = Component.GetComponent(lVar7)) == null) throw; // [null/range check failed]
            Toggle.set_isOn(lVar7);
            plVar6 = (int64 *)(uint64)(local_130 + 1);
          }
          goto LAB_1806f87d6;
        }
        plVar6 = plVar12;
        if (local_120 != 0) goto LAB_1806f8a70;
    }

    // Token : 0x6000E8D
    // RVA   : 0x6F73F0   Offset: 0x6F61F0   Length: 0x1A30
    public void ShowChoosePanel(ChooseType _chooseType, List<object> param, GameObject _sendResultFucTarget, string _sendResultFuc, string _sendResultParam, ChooseFilterType _filterType, HeroData targetFavorHero, string _cancelFuc)
    {
        var pStatics_38e8 = *(int64*)(DAT_181e538e8 + 184);
        void ChooseController.ShowChoosePanel
                     (int64 this,uint32 _chooseType,int64 param,uint64 _sendResultFucTarget,
                     uint64 _sendResultFuc,uint64 _sendResultParam,int _filterType,int64 targetFavorHero,uint64 _cancelFuc
                     )
        {
        bool bVar1;
        char cVar2;
        uint8 uVar3;
        int iVar4;
        uint32 uVar5;
        int64 *plVar6;
        int64 lVar7;
        int64 lVar8;
        uint64 *puVar9;
        uint64 uVar10;
        uint32 *puVar11;
        int64 *plVar12;
        int64 *plVar13;
        int *piVar14;
        uint64 uVar15;
        int64 lVar16;
        int64 *plVar17;
        float fVar18;
        int64 local_res8;
        int local_138;
        int local_134;
        int local_130;
        int local_12c;
        uint32 local_128 [2];
        int64 local_120;
        uint32 local_118;
        uint32 uStack_114;
        uint32 uStack_110;
        uint32 uStack_10c;
        uint64 local_108;
        uint64 uStack_100;
        uint64 local_f8;
        uint64 uStack_f0;
        uint64 local_e8;
        uint64 uStack_e0;
        uint64 local_d8;
        uint64 uStack_d0;
        uint8 local_c8 [16];
        uint8 local_b8 [16];
        uint8 local_a8 [16];
        uint8 local_98 [16];
        uint8 local_88 [96];
        plVar12 = (int64 *)0;
        local_134 = 0;
        local_12c = 0;
        local_128[0] = 0;
        local_138 = 0;
        local_130 = 0;
        local_108 = 0;
        uStack_100 = 0;
        if (!this.inited) {
          ChooseController.Init(this,0);
        }
        plVar6 = (int64 *)Resources.Load("Sound/SoundEffect/Paper",0);
        plVar13 = plVar12;
        if ((plVar6 != (int64 *)0) && (*plVar6 == DAT_181e8f4a0)) {
          plVar13 = plVar6;
        }
        NGUITools.PlaySound(plVar13,0);
        uVar10 = this.chooseRoot;
        GlobalData.DeleteAllChild(uVar10,0);
        if (this.choosePanel != null) {
          GameObject.SetActive(this.choosePanel,1,0);
          if ((this.choosePanel != null) &&
             (lVar7 = GameObject.get_transform(this.choosePanel,0)) != null) {
            lVar7 = Transform.Find(lVar7,"ChoosePanelRoot",0);
            lVar8 = Camera.get_main(0);
            puVar9 = (uint64 *)Input.get_mousePosition(local_c8,0);
            if (lVar8 != null) {
              uStack_110 = *(uint32 *)(puVar9 + 1);
              local_118 = (uint32)*puVar9;
              uStack_114 = (uint32)((uint64)*puVar9 >> 32);
              puVar9 = (uint64 *)Camera.ScreenToWorldPoint(local_b8,lVar8,&local_118,0);
              if (lVar7 != null) {
                uStack_110 = *(uint32 *)(puVar9 + 1);
                local_118 = (uint32)*puVar9;
                uStack_114 = (uint32)((uint64)*puVar9 >> 32);
                Transform.set_position(lVar7,&local_118,0);
                if ((this.choosePanel != null) &&
                   (lVar7 = GameObject.get_transform(this.choosePanel,0)) != null) {
                  uVar10 = Transform.Find(lVar7,"ChoosePanelRoot",0);
                  puVar9 = (uint64 *)Vector3.get_zero(local_a8,0);
                  uStack_110 = *(uint32 *)(puVar9 + 1);
                  local_118 = (uint32)*puVar9;
                  uStack_114 = (uint32)((uint64)*puVar9 >> 32);
                  uVar10 = ShortcutExtensions.DOMove(uVar10,&local_118,0x3e19999a,0,0);
                  uVar10 = TweenSettingsExtensions.SetEase(uVar10,2,DAT_181ea4b88);
                  TweenSettingsExtensions.SetUpdate(uVar10,1,DAT_181ea59e0);
                  if ((this.choosePanel != null) &&
                     (lVar7 = GameObject.get_transform(this.choosePanel,0)) != null) {
                    lVar7 = Transform.Find(lVar7,"ChoosePanelRoot",0);
                    puVar9 = (uint64 *)Vector3.get_zero(local_98,0);
                    if (lVar7 != null) {
                      uStack_110 = *(uint32 *)(puVar9 + 1);
                      local_118 = (uint32)*puVar9;
                      uStack_114 = (uint32)((uint64)*puVar9 >> 32);
                      Transform.set_localScale(lVar7,&local_118,0);
                      if ((this.choosePanel != null) &&
                         (lVar7 = GameObject.get_transform(this.choosePanel,0)) != null)
                      {
                        uVar10 = Transform.Find(lVar7,"ChoosePanelRoot",0);
                        uVar10 = ShortcutExtensions.DOScale(uVar10);
                        uVar10 = TweenSettingsExtensions.SetEase(uVar10,2,DAT_181ea4b88);
                        TweenSettingsExtensions.SetUpdate(uVar10,1,DAT_181ea59e0);
                        if ((this.choosePanel != null) &&
                           ((lVar7 = GameObject.get_transform(this.choosePanel,0),
                            lVar7 != null && (lVar7 = Transform.Find(lVar7,"BlackBackground",0)) != null)))
                        {
                          plVar6 = (int64 *)Component.GetComponent(lVar7,DAT_181e777b8);
                          puVar11 = (uint32 *)FUN_180af4e90(local_88,0);
                          if (plVar6 != (int64 *)0) {
                            local_118 = *puVar11;
                            uStack_114 = puVar11[1];
                            uStack_110 = puVar11[2];
                            uStack_10c = puVar11[3];
                            (**(code **)(*plVar6 + 0x2a8))
                                      (plVar6,&local_118,*(uint64 *)(*plVar6 + 0x2b0));
                            if (((this.choosePanel != null) &&
                                (lVar7 = GameObject.get_transform(this.choosePanel,0),
                                lVar7 != null)) &&
                               (lVar7 = Transform.Find(lVar7,"BlackBackground",0)) != null) {
                              uVar10 = Component.GetComponent(lVar7,DAT_181e777b8);
                              uVar10 = DOTweenModuleUI.DOFade(uVar10);
                              TweenSettingsExtensions.SetUpdate(uVar10,1,DAT_181ea5848);
                              this.chooseType = _chooseType;
                              this.sendResultFucTarget = _sendResultFucTarget;
                              this.sendResultFuc = _sendResultFuc;
                              this.sendResultParam = _sendResultParam;
                              this.cancelFuc = _cancelFuc;
                              iVar4 = this.chooseType;
                              if (iVar4 == 0) {
                                if (((this.itemList != null) &&
                                    (lVar7 = GameObject.get_transform(this.itemList,0),
                                    lVar7 != null)) &&
                                   ((lVar7 = Transform.Find(lVar7,"ItemFlitter",0), lVar7 != null &&
                                    (lVar7 = Component.get_gameObject(lVar7,0)) != null))) {
                                  GameObject.SetActive(lVar7,0,0);
                                  if (((this.itemList != null) &&
                                      (lVar7 = GameObject.get_transform(this.itemList,0),
                                      lVar7 != null)) &&
                                     ((lVar7 = Transform.Find(lVar7,"SkillFlitter",0), lVar7 != null &&
                                      (lVar7 = Component.get_gameObject(lVar7,0)) != null))) {
                                    GameObject.SetActive(lVar7,1,0);
                                    if ((((this.itemList != null) &&
                                         (lVar7 = GameObject.get_transform
                                                            (this.itemList,0), lVar7 != null)
                                         ) && (lVar7 = Transform.Find(lVar7,"Viewport",0)) != null
                                        ) && (lVar7 = Transform.Find(lVar7,"Content",0)) != null)
                                    {
                                      uVar10 = Component.get_gameObject(lVar7,0);
                                      this.targetGrid = uVar10;
                                      if (this.itemList != null) {
                                        GameObject.SetActive(this.itemList,1,0);
                                        if (this.heroList != null) {
                                          GameObject.SetActive(this.heroList,0,0);
                                          lVar7 = FUN_1802106e0(0);
                                          if ((lVar7 != null) &&
                                             (lVar7 = lVar7.summonControlable, param != null)) {
                                            if (*(int *)(param + 24) == 0) {
                                              ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                            }
                                            plVar6 = *(int64 **)(*(int64 *)(param + 16) + 32);
                                            if ((lVar7 != null) && (plVar6 != (int64 *)0)) {
                                              if (*(int64 *)(*plVar6 + 64) !=
                                                  *(int64 *)(DAT_181e60808 + 64)) {
                          // WARNING: Subroutine does not return
                                                FUN_1801dfd50(plVar6,DAT_181e60808);
                                              }
                                              puVar11 = (uint32 *)il2cpp_object_unbox();
                                              lVar7 = WorldData.GetHero(lVar7,*puVar11,0);
                                              this.targetHero = lVar7;
                                              plVar13 = plVar12;
                                              plVar17 = plVar12;
                                              if (1 < (int)*(uint32 *)(param + 24)) {
                                                if (*(uint32 *)(param + 24) < 2) {
                                                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                                }
                                                if (*(int64 *)(*(int64 *)(param + 16) + 40) !=
                                                    0) {
                                                  if (*(uint32 *)(param + 24) < 2) {
                                                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                                  }
                                                  plVar17 = *(int64 **)
                                                             (*(int64 *)(param + 16) + 40);
                                                  if (plVar17 != (int64 *)0) {
                                                    lVar7 = (**(code **)(*plVar17 + 0x168))
                                                                      (plVar17,*(uint64 *)
                                                                                (*plVar17 + 0x170));
                                                    lVar8 = FUN_1801dfd90(DAT_181e81128,1);
                                                    if (lVar8 != null) {
                                                      if (*(int *)(lVar8 + 24) == 0) {
                                                        uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                        FUN_1801e02d0(uVar10,0);
                                                      }
                                                      *(uint16 *)(lVar8 + 32) = 47;
                                                      if (lVar7 != null) {
                                                        uVar10 = String.Split(lVar7,lVar8,0);
                                                        plVar17 = (int64 *)
                                                                  il2cpp_internal(DAT_181e77728);
                                                        FUN_1817673a0(plVar17,uVar10,DAT_181e86270);
                                                        goto LAB_1806fb23c;
                                                      }
                                                    }
                                                  }
                                                  throw; // [null/range check failed]
                                                }
                                              }
        LAB_1806fb23c:
                                              do {
                                                while( true ) {
                                                  iVar4 = (int)plVar13;
                                                  local_134 = iVar4;
                                                  lVar7 = *(int64 *)
                                                           (pStatics_38e8 + 0x518);
                                                  if (lVar7 == null) throw; // [null/range check failed]
                                                  plVar13 = plVar12;
                                                  if (lVar7.summonLv <= iVar4) goto LAB_1806fb5a6;
                                                  if (2 < *(int *)(param + 24)) break;
        LAB_1806fb31a:
                                                  if (3 < *(int *)(param + 24)) {
                                                    plVar13 = (int64 *)
                                                              FUN_1800024b0(param,3,DAT_181e781e0);
                                                    if (plVar13 == (int64 *)0) throw; // [null/range check failed]
                                                    if (*(int64 *)(*plVar13 + 64) !=
                                                        *(int64 *)(DAT_181e60808 + 64)) {
                          // WARNING: Subroutine does not return
                                                      FUN_1801dfd50(plVar13,DAT_181e60808);
                                                    }
                                                    piVar14 = (int *)il2cpp_object_unbox();
                                                    iVar4 = local_134;
                                                    if (*piVar14 != -1) {
                                                      plVar13 = (int64 *)
                                                                FUN_1800024b0(param,3,DAT_181e781e0);
                                                      if (plVar13 == (int64 *)0) throw; // [null/range check failed]
                                                      if (*(int64 *)(*plVar13 + 64) !=
                                                          *(int64 *)(DAT_181e60808 + 64)) {
                          // WARNING: Subroutine does not return
                                                        FUN_1801dfd50(plVar13,DAT_181e60808);
                                                      }
                                                      piVar14 = (int *)il2cpp_object_unbox();
                                                      if (*piVar14 < iVar4) goto LAB_1806fb3b3;
                                                    }
                                                  }
                                                  if (((this.itemList == null) ||
                                                      (lVar7 = GameObject.get_transform
                                                                         (this.itemList,0)
                                                      , lVar7 == null)) ||
                                                     (lVar7 = Transform.Find(lVar7,"SkillFlitter"),
                                                     lVar7 == null)) throw; // [null/range check failed]
                                                  lVar7 = Transform.Find(lVar7,"SkillLvFlitter");
                                                  uVar10 = Int32.ToString(&local_134,0);
                                                  if (((lVar7 == null) ||
                                                      (lVar7 = Transform.Find(lVar7,uVar10)) == null)
                                                     || (lVar7 = Component.GetComponent
                                                                           (lVar7,DAT_181e796b8),
                                                        lVar7 == null)) throw; // [null/range check failed]
                                                  Selectable.set_interactable(lVar7);
                                                  plVar13 = (int64 *)(uint64)(local_134 + 1);
                                                }
                                                plVar13 = (int64 *)
                                                          FUN_1800024b0(param,2,DAT_181e781e0);
                                                if (plVar13 == (int64 *)0) break;
                                                if (*(int64 *)(*plVar13 + 64) !=
                                                    *(int64 *)(DAT_181e60808 + 64)) {
                          // WARNING: Subroutine does not return
                                                  FUN_1801dfd50(plVar13,DAT_181e60808);
                                                }
                                                piVar14 = (int *)il2cpp_object_unbox();
                                                iVar4 = local_134;
                                                if (*piVar14 == -1) goto LAB_1806fb31a;
                                                plVar13 = (int64 *)
                                                          FUN_1800024b0(param,2,DAT_181e781e0);
                                                if (plVar13 == (int64 *)0) break;
                                                if (*(int64 *)(*plVar13 + 64) !=
                                                    *(int64 *)(DAT_181e60808 + 64)) {
                          // WARNING: Subroutine does not return
                                                  FUN_1801dfd50(plVar13,DAT_181e60808);
                                                }
                                                piVar14 = (int *)il2cpp_object_unbox();
                                                if (*piVar14 <= iVar4) goto LAB_1806fb31a;
        LAB_1806fb3b3:
                                                if (((this.itemList == null) ||
                                                    (lVar7 = GameObject.get_transform
                                                                       (this.itemList,0),
                                                    lVar7 == null)) ||
                                                   (lVar7 = Transform.Find(lVar7,"SkillFlitter"),
                                                   lVar7 == null)) break;
                                                lVar7 = Transform.Find(lVar7,"SkillLvFlitter");
                                                uVar10 = Int32.ToString(&local_134,0);
                                                if (((lVar7 == null) ||
                                                    (lVar7 = Transform.Find(lVar7,uVar10)) == null)
                                                   || (lVar7 = Component.GetComponent
                                                                         (lVar7,DAT_181e796b8), lVar7 == null
                                                      )) break;
                                                Selectable.set_interactable(lVar7,0);
                                                if (((this.itemList == null) ||
                                                    (lVar7 = GameObject.get_transform
                                                                       (this.itemList,0),
                                                    lVar7 == null)) ||
                                                   (lVar7 = Transform.Find(lVar7,"SkillFlitter"),
                                                   lVar7 == null)) break;
                                                lVar7 = Transform.Find(lVar7,"SkillLvFlitter");
                                                uVar10 = Int32.ToString(&local_134,0);
                                                if (((lVar7 == null) ||
                                                    (lVar7 = Transform.Find(lVar7,uVar10)) == null)
                                                   || (lVar7 = Component.GetComponent(lVar7)) == null
                                                   ) break;
                                                Toggle.set_isOn(lVar7);
                                                plVar13 = (int64 *)(uint64)(local_134 + 1);
                                              } while( true );
                                            }
                                          }
                                        }
                                      }
                                    }
                                  }
                                }
                              }
                              else if (iVar4 == 1) {
                                if (((this.itemList != null) &&
                                    (lVar7 = GameObject.get_transform(this.itemList,0),
                                    lVar7 != null)) &&
                                   ((lVar7 = Transform.Find(lVar7,"ItemFlitter",0), lVar7 != null &&
                                    (lVar7 = Component.get_gameObject(lVar7,0)) != null))) {
                                  GameObject.SetActive(lVar7,1,0);
                                  if (((this.itemList != null) &&
                                      (lVar7 = GameObject.get_transform(this.itemList,0),
                                      lVar7 != null)) &&
                                     ((lVar7 = Transform.Find(lVar7,"SkillFlitter",0), lVar7 != null &&
                                      (lVar7 = Component.get_gameObject(lVar7,0)) != null))) {
                                    GameObject.SetActive(lVar7,0,0);
                                    if ((((this.itemList != null) &&
                                         (lVar7 = GameObject.get_transform
                                                            (this.itemList,0), lVar7 != null)
                                         ) && (lVar7 = Transform.Find(lVar7,"Viewport",0)) != null
                                        ) && (lVar7 = Transform.Find(lVar7,"Content",0)) != null)
                                    {
                                      uVar10 = Component.get_gameObject(lVar7,0);
                                      this.targetGrid = uVar10;
                                      if (this.itemList != null) {
                                        GameObject.SetActive(this.itemList,1,0);
                                        if (this.heroList != null) {
                                          GameObject.SetActive(this.heroList,0,0);
                                          lVar7 = FUN_1802106e0(0);
                                          if ((lVar7 != null) &&
                                             (lVar7 = lVar7.summonControlable, param != null)) {
                                            if (*(int *)(param + 24) == 0) {
                                              ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                            }
                                            plVar6 = *(int64 **)(*(int64 *)(param + 16) + 32);
                                            if ((lVar7 != null) && (plVar6 != (int64 *)0)) {
                                              if (*(int64 *)(*plVar6 + 64) !=
                                                  *(int64 *)(DAT_181e60808 + 64)) {
                          // WARNING: Subroutine does not return
                                                FUN_1801dfd50(plVar6,DAT_181e60808);
                                              }
                                              puVar11 = (uint32 *)il2cpp_object_unbox();
                                              lVar7 = WorldData.GetHero(lVar7,*puVar11,0);
                                              this.targetHero = lVar7;
                                              if (*(int *)(param + 24) == 0) {
                                                ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                              }
                                              plVar13 = *(int64 **)
                                                         (*(int64 *)(param + 16) + 32);
                                              if (plVar13 != (int64 *)0) {
                                                if (*(int64 *)(*plVar13 + 64) !=
                                                    *(int64 *)(DAT_181e60808 + 64)) {
                          // WARNING: Subroutine does not return
                                                  FUN_1801dfd50(plVar13,DAT_181e60808);
                                                }
                                                puVar11 = (uint32 *)il2cpp_object_unbox();
                                                local_128[0] = *puVar11;
                                                switch(local_128[0]) {
                                                case 0xffffff97:
                                                  local_120 = *(int64 *)
                                                               (*(int64 *)(DAT_181e528f8 + 184) + 24
                                                               );
                                                  break;
                                                case 0xffffff98:
                                                  lVar7 = FUN_1802106e0(0);
                                                  if ((lVar7 == null) || (lVar7.summonControlable == null))
                                                  throw; // [null/range check failed]
                                                  local_120 = *(int64 *)
                                                               (lVar7.summonControlable + 0x218);
                                                  break;
                                                case 0xffffff99:
                                                  lVar7 = FUN_180210a70(0);
                                                  if (((lVar7 == null) || (lVar7.hp == null)
                                                      ) || ((lVar7 = AreaBuildingData.GetArea
                                                                               (*(int64 *)
                                                                                 (lVar7 + 0x178),0),
                                                            lVar7 == null ||
                                                            (lVar7 = AreaData.GetForce(lVar7,0),
                                                            lVar7 == null)))) throw; // [null/range check failed]
                                                  local_120 = lVar7.thisMonthContribution;
                                                  break;
                                                case 0xffffff9a:
                                                  lVar7 = FUN_1802106e0(0);
                                                  if (((lVar7 == null) || (lVar7.summonControlable == null))
                                                     || (lVar7 = *(int64 *)
                                                                  (lVar7.summonControlable + 0x1b0),
                                                        lVar7 == null)) throw; // [null/range check failed]
                                                  local_120 = lVar7.summonLv;
                                                  break;
                                                case 0xffffff9b:
                                                  lVar7 = FUN_1802102e0(0);
                                                  if (lVar7 == null) throw; // [null/range check failed]
                                                  if (lVar7.summonLv == null) {
                                                    lVar7 = FUN_180210a70(0);
                                                    if ((lVar7 == null) ||
                                                       (lVar7.hp == null))
                                                    throw; // [null/range check failed]
                                                    local_120 = *(int64 *)
                                                                 (lVar7.hp + 40);
                                                  }
                                                  else {
                                                    lVar7 = FUN_1802102e0(0);
                                                    if ((lVar7 == null) || (lVar7.summonLv == null)
                                                       ) throw; // [null/range check failed]
                                                    local_120 = *(int64 *)
                                                                 (lVar7.summonLv + 40);
                                                  }
                                                  break;
                                                case 0xffffff9c:
                                                  lVar7 = FUN_180210a70(0);
                                                  if ((lVar7 == null) || (lVar7.forceJobCD == null))
                                                  throw; // [null/range check failed]
                                                  local_120 = *(int64 *)
                                                               (lVar7.forceJobCD + 128);
                                                  break;
                                                case 0xffffff9d:
                                                  lVar7 = FUN_180210a70(0);
                                                  if (lVar7 == null) throw; // [null/range check failed]
                                                  local_120 = lVar7.changeSkinCd;
                                                  break;
                                                default:
                                                  if (*plVar6 == 0) throw; // [null/range check failed]
                                                  local_120 = *(int64 *)(*plVar6 + 0x220);
                                                }
                                                local_res8 = 0;
                                                plVar6 = plVar12;
                                                if ((*(int *)(param + 24) < 2) ||
                                                   (lVar7 = FUN_1800024b0(param,1,DAT_181e781e0),
                                                   lVar7 == null)) {
        LAB_1806f8462:
                                                  do {
                                                    while( true ) {
                                                      iVar4 = (int)plVar6;
                                                      local_138 = iVar4;
                                                      lVar7 = *(int64 *)
                                                               (pStatics_38e8 +
                                                               0x510);
                                                      if (lVar7 == null) throw; // [null/range check failed]
                                                      plVar6 = plVar12;
                                                      if (lVar7.summonLv <= iVar4)
                                                      goto LAB_1806f87d6;
                                                      if (2 < *(int *)(param + 24)) break;
        LAB_1806f854a:
                                                      if (3 < *(int *)(param + 24)) {
                                                        plVar6 = (int64 *)
                                                                 FUN_1800024b0(param,3,DAT_181e781e0);
                                                        if (plVar6 == (int64 *)0) throw; // [null/range check failed]
                                                        if (*(int64 *)(*plVar6 + 64) !=
                                                            *(int64 *)(DAT_181e60808 + 64)) {
                          // WARNING: Subroutine does not return
                                                          FUN_1801dfd50(plVar6,DAT_181e60808);
                                                        }
                                                        piVar14 = (int *)il2cpp_object_unbox();
                                                        iVar4 = local_138;
                                                        if (*piVar14 != -1) {
                                                          plVar6 = (int64 *)
                                                                   FUN_1800024b0(param,3,DAT_181e781e0);
                                                          if (plVar6 == (int64 *)0)
                                                          throw; // [null/range check failed]
                                                          if (*(int64 *)(*plVar6 + 64) !=
                                                              *(int64 *)(DAT_181e60808 + 64)) {
                          // WARNING: Subroutine does not return
                                                            FUN_1801dfd50(plVar6,DAT_181e60808);
                                                          }
                                                          piVar14 = (int *)il2cpp_object_unbox();
                                                          if (*piVar14 < iVar4) goto LAB_1806f85e3;
                                                        }
                                                      }
                                                      if (((this.itemList == null) ||
                                                          (lVar7 = GameObject.get_transform
                                                                             (*(int64 *)
                                                                               (this + 32),0),
                                                          lVar7 == null)) ||
                                                         (lVar7 = Transform.Find(lVar7,"ItemFlitter"),
                                                         lVar7 == null)) throw; // [null/range check failed]
                                                      lVar7 = Transform.Find(lVar7,"ItemLvFlitter");
                                                      uVar10 = Int32.ToString(&local_138,0);
                                                      if (((lVar7 == null) ||
                                                          (lVar7 = Transform.Find(lVar7,uVar10),
                                                          lVar7 == null)) ||
                                                         (lVar7 = Component.GetComponent
                                                                            (lVar7,DAT_181e796b8),
                                                         lVar7 == null)) throw; // [null/range check failed]
                                                      Selectable.set_interactable(lVar7);
                                                      plVar6 = (int64 *)(uint64)(local_138 + 1);
                                                    }
                                                    plVar6 = (int64 *)
                                                             FUN_1800024b0(param,2,DAT_181e781e0);
                                                    if (plVar6 == (int64 *)0) throw; // [null/range check failed]
                                                    if (*(int64 *)(*plVar6 + 64) !=
                                                        *(int64 *)(DAT_181e60808 + 64)) {
                          // WARNING: Subroutine does not return
                                                      FUN_1801dfd50(plVar6,DAT_181e60808);
                                                    }
                                                    piVar14 = (int *)il2cpp_object_unbox();
                                                    iVar4 = local_138;
                                                    if (*piVar14 == -1) goto LAB_1806f854a;
                                                    plVar6 = (int64 *)
                                                             FUN_1800024b0(param,2,DAT_181e781e0);
                                                    if (plVar6 == (int64 *)0) throw; // [null/range check failed]
                                                    if (*(int64 *)(*plVar6 + 64) !=
                                                        *(int64 *)(DAT_181e60808 + 64)) {
                          // WARNING: Subroutine does not return
                                                      FUN_1801dfd50(plVar6,DAT_181e60808);
                                                    }
                                                    piVar14 = (int *)il2cpp_object_unbox();
                                                    if (*piVar14 <= iVar4) goto LAB_1806f854a;
        LAB_1806f85e3:
                                                    if (((this.itemList == null) ||
                                                        (lVar7 = GameObject.get_transform
                                                                           (this.itemList,
                                                                            0), lVar7 == null)) ||
                                                       (lVar7 = Transform.Find(lVar7,"ItemFlitter"),
                                                       lVar7 == null)) throw; // [null/range check failed]
                                                    lVar7 = Transform.Find(lVar7,"ItemLvFlitter");
                                                    uVar10 = Int32.ToString(&local_138,0);
                                                    if (((lVar7 == null) ||
                                                        (lVar7 = Transform.Find(lVar7,uVar10), lVar7 == null
                                                        )) || (lVar7 = Component.GetComponent
                                                                                 (lVar7,DAT_181e796b8),
                                                              lVar7 == null)) throw; // [null/range check failed]
                                                    Selectable.set_interactable(lVar7,0);
                                                    if (((this.itemList == null) ||
                                                        (lVar7 = GameObject.get_transform
                                                                           (this.itemList,
                                                                            0), lVar7 == null)) ||
                                                       (lVar7 = Transform.Find(lVar7,"ItemFlitter"),
                                                       lVar7 == null)) throw; // [null/range check failed]
                                                    lVar7 = Transform.Find(lVar7,"ItemLvFlitter");
                                                    uVar10 = Int32.ToString(&local_138,0);
                                                    if (((lVar7 == null) ||
                                                        (lVar7 = Transform.Find(lVar7,uVar10), lVar7 == null
                                                        )) || (lVar7 = Component.GetComponent(lVar7),
                                                              lVar7 == null)) throw; // [null/range check failed]
                                                    Toggle.set_isOn(lVar7);
                                                    plVar6 = (int64 *)(uint64)(local_138 + 1);
                                                  } while( true );
                                                }
                                                plVar13 = (int64 *)
                                                          FUN_1800024b0(param,1,DAT_181e781e0);
                                                if (plVar13 != (int64 *)0) {
                                                  lVar7 = (**(code **)(*plVar13 + 0x168))
                                                                    (plVar13,*(uint64 *)
                                                                              (*plVar13 + 0x170));
                                                  lVar8 = FUN_1801dfd90(DAT_181e81128,1);
                                                  if (lVar8 != null) {
                                                    if (*(int *)(lVar8 + 24) == 0) {
                                                      uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                      FUN_1801e02d0(uVar10,0);
                                                    }
                                                    *(uint16 *)(lVar8 + 32) = 47;
                                                    if (lVar7 != null) {
                                                      uVar10 = String.Split(lVar7,lVar8,0);
                                                      local_res8 = il2cpp_internal(DAT_181e77728);
                                                      FUN_1817673a0(local_res8,uVar10,DAT_181e86270);
                                                      goto LAB_1806f8462;
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
                              else if (iVar4 == 2) {
                                if ((((this.heroList != null) &&
                                     (lVar7 = GameObject.get_transform(this.heroList,0),
                                     lVar7 != null)) &&
                                    (lVar7 = Transform.Find(lVar7,"Viewport",0)) != null) &&
                                   (lVar7 = Transform.Find(lVar7,"Content",0)) != null) {
                                  uVar10 = Component.get_gameObject(lVar7,0);
                                  this.targetGrid = uVar10;
                                  if (this.itemList != null) {
                                    GameObject.SetActive(this.itemList,0,0);
                                    if ((this.heroList != null) &&
                                       (GameObject.SetActive(this.heroList,1,0),
                                       param != null)) {
        LAB_1806f7c10:
                                      do {
                                        uVar5 = (uint32)plVar12;
                                        if ((int)*(uint32 *)(param + 24) <= (int)uVar5)
                                        goto LAB_1806faecf;
                                        if (*(uint32 *)(param + 24) <= uVar5) {
                                          ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                        }
                                        plVar12 = *(int64 **)
                                                   (*(int64 *)(param + 16) + 32 +
                                                   (int64)(int)uVar5 * 8);
                                        if (plVar12 == (int64 *)0) {
                                          plVar6 = (int64 *)0;
                                        }
                                        else {
                                          plVar6 = plVar12;
                                        }
                                        if (_filterType == 9) {
                                          lVar7 = FUN_1802106e0(0);
                                          if ((lVar7 == null) || (lVar7.summonControlable == null)) break;
                                          plVar12 = (int64 *)WorldData.Player();
                                          if (plVar6 == plVar12) goto LAB_1806f7e91;
                                          if (((plVar6 == (int64 *)0) || (plVar6[97] == 0)) ||
                                             (lVar7 = *(int64 *)(plVar6[97] + 16)) == null)
                                          break;
                                          iVar4 = FUN_180002480(lVar7,16,DAT_181e71bf0);
                                          if (iVar4 < 1) {
                                            plVar12 = (int64 *)(uint64)(uVar5 + 1);
                                            goto LAB_1806f7c10;
                                          }
        LAB_1806f7db0:
                                          uVar10 = this.targetGrid;
                                          lVar7 = FUN_1802107e0(0);
                                          if (lVar7 == null) break;
                                          uVar15 = lVar7.forceJobType;
                                          uVar10 = GlobalData.AddChild(uVar10,uVar15,0);
                                          this.newObj = uVar10;
                                          if ((this.newObj == null) ||
                                             (lVar7 = GameObject.GetComponent
                                                                (this.newObj,
                                                                 DAT_181e54c18), lVar7 == null)) break;
                                          lVar7.summonControlable = plVar6;
                                          if ((this.newObj == null) ||
                                             (((lVar7 = GameObject.GetComponent
                                                                  (this.newObj,
                                                                   DAT_181e54c18), lVar7 == null ||
                                               (lVar7.summonLv = 3,
                                               this.newObj == null)) ||
                                              (lVar7 = GameObject.GetComponent()) == null))) break;
                                          HeroIconController.AutoSetName(lVar7);
                                        }
                                        else {
                                          if (_filterType != 10) goto LAB_1806f7db0;
                                          lVar7 = FUN_1802106e0(0);
                                          if ((lVar7 == null) || (lVar7.summonControlable == null)) break;
                                          plVar12 = (int64 *)WorldData.Player();
                                          if (plVar6 != plVar12) {
                                            if (((plVar6 == (int64 *)0) || (plVar6[97] == 0)) ||
                                               (lVar7 = *(int64 *)(plVar6[97] + 16)) == null)
                                            break;
                                            iVar4 = FUN_180002480(lVar7,17,DAT_181e71bf0);
                                            if (0 < iVar4) goto LAB_1806f7db0;
                                          }
                                        }
        LAB_1806f7e91:
                                        plVar12 = (int64 *)(uint64)(uVar5 + 1);
                                      } while( true );
                                    }
                                  }
                                }
                              }
                              else {
        LAB_1806faecf:
                                uVar10 = this.targetGrid;
                                GlobalData.SortChild(uVar10,0);
                                if (this.targetGrid != null) {
                                  uVar10 = GameObject.GetComponent
                                                     (this.targetGrid,DAT_181e55c90);
                                  LayoutRebuilder.ForceRebuildLayoutImmediate(uVar10,0);
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
        throw; // [null/range check failed]
        LAB_1806fb5a6:
        iVar4 = (int)plVar13;
        local_12c = iVar4;
        lVar7 = *(int64 *)(pStatics_38e8 + 0x4a8);
        if (lVar7 == null) throw; // [null/range check failed]
        if (iVar4 < lVar7.summonLv) {
          if (plVar17 == (int64 *)0) {
        LAB_1806fb76b:
            if (((this.itemList == null) ||
                (lVar7 = GameObject.get_transform(this.itemList,0)) == null) ||
               (lVar7 = Transform.Find(lVar7,"SkillFlitter")) == null) throw; // [null/range check failed]
            lVar7 = Transform.Find(lVar7,"SkillTypeFlitter");
            uVar10 = Int32.ToString(&local_12c,0);
            if (((lVar7 == null) || (lVar7 = Transform.Find(lVar7,uVar10)) == null) ||
               (lVar7 = Component.GetComponent(lVar7,DAT_181e796b8)) == null) throw; // [null/range check failed]
            Selectable.set_interactable(lVar7);
            plVar13 = (int64 *)(uint64)(local_12c + 1);
          }
          else {
            uVar10 = Int32.ToString(&local_12c,0);
            cVar2 = FUN_18175e190(plVar17,uVar10);
            if (cVar2) goto LAB_1806fb76b;
            if (((this.itemList == null) ||
                (lVar7 = GameObject.get_transform(this.itemList,0)) == null) ||
               (lVar7 = Transform.Find(lVar7,"SkillFlitter")) == null) throw; // [null/range check failed]
            lVar7 = Transform.Find(lVar7,"SkillTypeFlitter");
            uVar10 = Int32.ToString(&local_12c,0);
            if (((lVar7 == null) || (lVar7 = Transform.Find(lVar7,uVar10)) == null) ||
               (lVar7 = Component.GetComponent(lVar7,DAT_181e796b8)) == null) throw; // [null/range check failed]
            Selectable.set_interactable(lVar7,0);
            if (((this.itemList == null) ||
                (lVar7 = GameObject.get_transform(this.itemList,0)) == null) ||
               (lVar7 = Transform.Find(lVar7,"SkillFlitter")) == null) throw; // [null/range check failed]
            lVar7 = Transform.Find(lVar7,"SkillTypeFlitter");
            uVar10 = Int32.ToString(&local_12c,0);
            if (((lVar7 == null) || (lVar7 = Transform.Find(lVar7,uVar10)) == null) ||
               (lVar7 = Component.GetComponent(lVar7)) == null) throw; // [null/range check failed]
            Toggle.set_isOn(lVar7);
            plVar13 = (int64 *)(uint64)(local_12c + 1);
          }
          goto LAB_1806fb5a6;
        }
        lVar7 = *plVar6;
        if (lVar7 != null) goto LAB_1806fb830;
        throw; // [null/range check failed]
        LAB_1806fb830:
        if (lVar7.kungfuSkills == null) throw; // [null/range check failed]
        uVar5 = (uint32)plVar12;
        if (*(int *)(lVar7.kungfuSkills + 24) <= (int)uVar5) goto LAB_1806faecf;
        if ((lVar7 = lVar7?.kungfuSkills) == null) throw; // [null/range check failed]
        if (lVar7.summonLv <= uVar5) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        lVar7 = lVar7.isSummon[uVar5];
        if (plVar17 != (int64 *)0) {
          if (lVar7 == null) throw; // [null/range check failed]
          local_128[0] = KungfuSkillLvData.Type(lVar7,0);
          uVar10 = Int32.ToString(local_128,0);
          cVar2 = FUN_18175e190(plVar17,uVar10,DAT_181e86470);
          if (cVar2) goto LAB_1806fb8bd;
          goto LAB_1806fc6f9;
        }
        LAB_1806fb8bd:
        if (2 < *(int *)(param + 24)) {
          plVar6 = (int64 *)FUN_1800024b0(param,2,DAT_181e781e0);
          if (plVar6 == (int64 *)0) throw; // [null/range check failed]
          if (*(int64 *)(*plVar6 + 64) != *(int64 *)(DAT_181e60808 + 64)) {
                          // WARNING: Subroutine does not return
            FUN_1801dfd50(plVar6,DAT_181e60808);
          }
          piVar14 = (int *)il2cpp_object_unbox();
          if (*piVar14 != -1) {
            if ((lVar7 == null) || (lVar8 = KungfuSkillLvData.DataBase(lVar7,0)) == null)
            throw; // [null/range check failed]
            iVar4 = *(int *)(lVar8 + 52);
            plVar6 = (int64 *)FUN_1800024b0(param,2,DAT_181e781e0);
            if (plVar6 == (int64 *)0) throw; // [null/range check failed]
            if (*(int64 *)(*plVar6 + 64) != *(int64 *)(DAT_181e60808 + 64)) {
                          // WARNING: Subroutine does not return
              FUN_1801dfd50(plVar6,DAT_181e60808);
            }
            piVar14 = (int *)il2cpp_object_unbox();
            if (iVar4 < *piVar14) goto LAB_1806fc6f9;
          }
        }
        if (3 < *(int *)(param + 24)) {
          plVar6 = (int64 *)FUN_1800024b0(param,3,DAT_181e781e0);
          if (plVar6 == (int64 *)0) throw; // [null/range check failed]
          if (*(int64 *)(*plVar6 + 64) != *(int64 *)(DAT_181e60808 + 64)) {
                          // WARNING: Subroutine does not return
            FUN_1801dfd50(plVar6,DAT_181e60808);
          }
          piVar14 = (int *)il2cpp_object_unbox();
          if (*piVar14 != -1) {
            if ((lVar7 == null) || (lVar8 = KungfuSkillLvData.DataBase(lVar7,0)) == null)
            throw; // [null/range check failed]
            iVar4 = *(int *)(lVar8 + 52);
            plVar6 = (int64 *)FUN_1800024b0(param,3,DAT_181e781e0);
            if (plVar6 == (int64 *)0) throw; // [null/range check failed]
            if (*(int64 *)(*plVar6 + 64) != *(int64 *)(DAT_181e60808 + 64)) {
                          // WARNING: Subroutine does not return
              FUN_1801dfd50(plVar6,DAT_181e60808);
            }
            piVar14 = (int *)il2cpp_object_unbox();
            if (*piVar14 < iVar4) goto LAB_1806fc6f9;
          }
        }
        if (4 < *(int *)(param + 24)) {
          plVar6 = (int64 *)FUN_1800024b0(param,4,DAT_181e781e0);
          if (plVar6 == (int64 *)0) throw; // [null/range check failed]
          if (*(int64 *)(*plVar6 + 64) != *(int64 *)(DAT_181e60808 + 64)) {
                          // WARNING: Subroutine does not return
            FUN_1801dfd50(plVar6,DAT_181e60808);
          }
          piVar14 = (int *)il2cpp_object_unbox();
          if (*piVar14 != -1) {
            if (lVar7 == null) throw; // [null/range check failed]
            iVar4 = lVar7.summonID;
            plVar6 = (int64 *)FUN_1800024b0(param,4,DAT_181e781e0);
            if (plVar6 == (int64 *)0) throw; // [null/range check failed]
            if (*(int64 *)(*plVar6 + 64) != *(int64 *)(DAT_181e60808 + 64)) {
                          // WARNING: Subroutine does not return
              FUN_1801dfd50(plVar6,DAT_181e60808);
            }
            piVar14 = (int *)il2cpp_object_unbox();
            if (iVar4 < *piVar14) goto LAB_1806fc6f9;
          }
        }
        if (5 < *(int *)(param + 24)) {
          plVar6 = (int64 *)FUN_1800024b0(param,5,DAT_181e781e0);
          if (plVar6 == (int64 *)0) throw; // [null/range check failed]
          if (*(int64 *)(*plVar6 + 64) != *(int64 *)(DAT_181e60808 + 64)) {
                          // WARNING: Subroutine does not return
            FUN_1801dfd50(plVar6,DAT_181e60808);
          }
          piVar14 = (int *)il2cpp_object_unbox();
          if (*piVar14 != -1) {
            if (lVar7 == null) throw; // [null/range check failed]
            iVar4 = lVar7.summonID;
            plVar6 = (int64 *)FUN_1800024b0(param,5,DAT_181e781e0);
            if (plVar6 == (int64 *)0) throw; // [null/range check failed]
            if (*(int64 *)(*plVar6 + 64) != *(int64 *)(DAT_181e60808 + 64)) {
                          // WARNING: Subroutine does not return
              FUN_1801dfd50(plVar6,DAT_181e60808);
            }
            piVar14 = (int *)il2cpp_object_unbox();
            if (*piVar14 < iVar4) goto LAB_1806fc6f9;
          }
        }
        if (_filterType == 1) {
          if (lVar7 == null) throw; // [null/range check failed]
          cVar2 = KungfuSkillLvData.SkillMeetObstacleLv(lVar7,0);
          if ((cVar2) && (cVar2 = KungfuSkillLvData.CanUpgrade(lVar7,0), cVar2))
          goto switchD_1806fbc25_caseD_14;
          goto LAB_1806fc6f9;
        }
        if (_filterType == 12) {
        switchD_1806fbc25_caseD_17:
          lVar8 = FUN_1802106e0(0);
          if ((((lVar8 == null) || (*(int64 *)(lVar8 + 32) == 0)) ||
              (lVar8 = WorldData.Player(*(int64 *)(lVar8 + 32),0), lVar7 == null)) || (lVar8 == null))
          throw; // [null/range check failed]
          lVar7 = HeroData.FindSkill(lVar8,lVar7.isSummon,0);
          if (lVar7 != null) goto LAB_1806fc6f9;
          goto switchD_1806fbc25_caseD_14;
        }
        switch(_filterType) {
        case 18:
          lVar8 = FUN_180210a70(0);
          if (lVar8 == null) throw; // [null/range check failed]
          if (*(int64 *)(lVar8 + 112) != 0) {
            lVar8 = FUN_180210a70(0);
            if (((lVar8 == null) || (lVar7 == null)) || (*(int64 *)(lVar8 + 112) == 0)) throw; // [null/range check failed]
            lVar8 = HeroData.FindSkill(*(int64 *)(lVar8 + 112),lVar7.isSummon,0);
            if (lVar8 != null) {
              lVar8 = FUN_1802106e0(0);
              if (((lVar8 == null) || (*(int64 *)(lVar8 + 32) == 0)) ||
                 (lVar8 = WorldData.Player(*(int64 *)(lVar8 + 32),0)) == null)
              throw; // [null/range check failed]
              lVar8 = HeroData.FindSkill(lVar8,lVar7.isSummon,0);
              if (lVar8 != null) {
                lVar8 = FUN_180210a70(0);
                if (((lVar8 == null) || (*(int64 *)(lVar8 + 112) == 0)) ||
                   (lVar8 = HeroData.FindSkill(*(int64 *)(lVar8 + 112),lVar7.isSummon,
                                                0), lVar8 == null)) throw; // [null/range check failed]
                iVar4 = *(int *)(lVar8 + 20);
                lVar8 = FUN_1802106e0(0);
                if (((lVar8 == null) || (*(int64 *)(lVar8 + 32) == 0)) ||
                   ((lVar8 = WorldData.Player(*(int64 *)(lVar8 + 32),0), lVar8 == null ||
                    (lVar8 = HeroData.FindSkill(lVar8,lVar7.isSummon,0)) == null)))
                throw; // [null/range check failed]
                if (iVar4 <= *(int *)(lVar8 + 20)) {
                  lVar8 = FUN_180210a70(0);
                  if ((lVar8 == null) || (lVar8 = *(int64 *)(lVar8 + 112)) == null)
                  throw; // [null/range check failed]
        LAB_1806fbe12:
                  lVar7 = HeroData.FindSkill(lVar8,lVar7.isSummon,0);
                  if (lVar7 == null) throw; // [null/range check failed]
                  if (lVar7.summonID < 10) goto switchD_1806fbc25_caseD_14;
                }
              }
            }
          }
          break;
        case 19:
          lVar8 = FUN_180210a70(0);
          if (lVar8 == null) throw; // [null/range check failed]
          if (*(int64 *)(lVar8 + 112) != 0) {
            lVar8 = FUN_180210a70(0);
            if (((lVar8 == null) || (lVar7 == null)) || (*(int64 *)(lVar8 + 112) == 0)) throw; // [null/range check failed]
            lVar8 = HeroData.FindSkill(*(int64 *)(lVar8 + 112),lVar7.isSummon,0);
            if (lVar8 != null) {
              lVar8 = FUN_1802106e0(0);
              if (((lVar8 == null) || (*(int64 *)(lVar8 + 32) == 0)) ||
                 (lVar8 = WorldData.Player(*(int64 *)(lVar8 + 32),0)) == null)
              throw; // [null/range check failed]
              lVar8 = HeroData.FindSkill(lVar8,lVar7.isSummon,0);
              if (lVar8 != null) {
                lVar8 = FUN_180210a70(0);
                if (((lVar8 == null) || (*(int64 *)(lVar8 + 112) == 0)) ||
                   (lVar8 = HeroData.FindSkill(*(int64 *)(lVar8 + 112),lVar7.isSummon,
                                                0), lVar8 == null)) throw; // [null/range check failed]
                iVar4 = *(int *)(lVar8 + 20);
                lVar8 = FUN_1802106e0(0);
                if (((lVar8 == null) || (*(int64 *)(lVar8 + 32) == 0)) ||
                   ((lVar8 = WorldData.Player(*(int64 *)(lVar8 + 32),0), lVar8 == null ||
                    (lVar8 = HeroData.FindSkill(lVar8,lVar7.isSummon,0)) == null)))
                throw; // [null/range check failed]
                if (*(int *)(lVar8 + 20) <= iVar4) {
                  lVar8 = FUN_1802106e0(0);
                  if (((lVar8 != null) && (*(int64 *)(lVar8 + 32) != 0)) &&
                     (lVar8 = WorldData.Player(*(int64 *)(lVar8 + 32),0)) != null)
                  goto LAB_1806fbe12;
                  throw; // [null/range check failed]
                }
              }
            }
          }
          break;
        default:
          goto switchD_1806fbc25_caseD_14;
        case 22:
          lVar8 = FUN_180210a70(0);
          if (lVar8 == null) throw; // [null/range check failed]
          if (*(int64 *)(lVar8 + 112) == 0) break;
          lVar8 = FUN_180210a70(0);
          if (((lVar8 == null) || (lVar7 == null)) || (*(int64 *)(lVar8 + 112) == 0)) throw; // [null/range check failed]
          lVar8 = HeroData.FindSkill(*(int64 *)(lVar8 + 112),lVar7.isSummon,0);
          if (lVar8 != null) break;
          lVar8 = KungfuSkillLvData.DataBase(lVar7,0);
          if (lVar8 == null) throw; // [null/range check failed]
          iVar4 = *(int *)(lVar8 + 52);
          lVar8 = FUN_180210a70(0);
          if ((lVar8 == null) || (*(int64 *)(lVar8 + 112) == 0)) throw; // [null/range check failed]
          if (*(int *)(*(int64 *)(lVar8 + 112) + 184) < iVar4) break;
          lVar8 = FUN_1802106e0(0);
          if ((lVar8 == null) || (*(int64 *)(lVar8 + 32) == 0)) throw; // [null/range check failed]
          lVar8 = WorldData.Player(*(int64 *)(lVar8 + 32),0);
          lVar16 = FUN_180210a70(0);
          if (((lVar16 == null) || (*(int64 *)(lVar16 + 112) == 0)) || (lVar8 == null)) throw; // [null/range check failed]
          cVar2 = HeroData.HaveBrother(lVar8,*(uint32 *)(*(int64 *)(lVar16 + 112) + 88));
          if (!cVar2) {
            lVar8 = FUN_1802106e0(0);
            if ((lVar8 == null) || (*(int64 *)(lVar8 + 32) == 0)) throw; // [null/range check failed]
            lVar8 = WorldData.Player(*(int64 *)(lVar8 + 32),0);
            lVar16 = FUN_180210a70(0);
            if (((lVar16 == null) || (*(int64 *)(lVar16 + 112) == 0)) || (lVar8 == null))
            throw; // [null/range check failed]
            cVar2 = HeroData.HavePrelover(lVar8,*(uint32 *)(*(int64 *)(lVar16 + 112) + 88));
            if (cVar2) goto switchD_1806fbc25_caseD_14;
            lVar8 = FUN_1802106e0(0);
            if (((lVar8 == null) || (*(int64 *)(lVar8 + 32) == 0)) ||
               (lVar8 = WorldData.Player(*(int64 *)(lVar8 + 32),0)) == null) throw; // [null/range check failed]
            iVar4 = *(int *)(lVar8 + 0x328);
            lVar8 = FUN_180210a70(0);
            if ((lVar8 == null) || (*(int64 *)(lVar8 + 112) == 0)) throw; // [null/range check failed]
            if (iVar4 != *(int *)(*(int64 *)(lVar8 + 112) + 88)) {
              lVar7 = KungfuSkillLvData.DataBase(lVar7,0);
              if (lVar7 == null) throw; // [null/range check failed]
              if (4 < lVar7.manageAiHour) break;
            }
          }
          goto switchD_1806fbc25_caseD_14;
        case 23:
          goto switchD_1806fbc25_caseD_17;
        case 26:
          lVar8 = FUN_180210a70(0);
          if (lVar8 == null) throw; // [null/range check failed]
          if (*(int64 *)(lVar8 + 112) != 0) {
            lVar8 = FUN_180210a70(0);
            if (((lVar8 == null) || (lVar7 == null)) || (*(int64 *)(lVar8 + 112) == 0)) throw; // [null/range check failed]
            lVar8 = HeroData.FindSkill(*(int64 *)(lVar8 + 112),lVar7.isSummon,0);
            if (lVar8 == null) {
              lVar7 = KungfuSkillLvData.DataBase(lVar7,0);
              if (lVar7 == null) throw; // [null/range check failed]
              iVar4 = lVar7.manageAiHour;
              lVar7 = FUN_180210a70(0);
              if ((lVar7 == null) || (lVar7.heroFamilyName == null)) throw; // [null/range check failed]
              if (iVar4 <= *(int *)(lVar7.heroFamilyName + 184)) goto switchD_1806fbc25_caseD_14;
            }
          }
          break;
        case 28:
          lVar8 = FUN_180210a70(0);
          if (lVar8 == null) throw; // [null/range check failed]
          if (*(int64 *)(lVar8 + 112) != 0) {
            lVar8 = FUN_180210a70(0);
            if (((lVar8 == null) || (lVar7 == null)) || (*(int64 *)(lVar8 + 112) == 0)) throw; // [null/range check failed]
            lVar8 = HeroData.FindSkill(*(int64 *)(lVar8 + 112),lVar7.isSummon,0);
            if (lVar8 != null) {
              lVar8 = FUN_1802106e0(0);
              if (((lVar8 == null) || (*(int64 *)(lVar8 + 32) == 0)) ||
                 (lVar8 = WorldData.Player(*(int64 *)(lVar8 + 32),0)) == null)
              throw; // [null/range check failed]
              lVar7 = HeroData.FindSkill(lVar8,lVar7.isSummon,0);
              if (lVar7 != null) goto switchD_1806fbc25_caseD_14;
            }
          }
          break;
        case 29:
          if (lVar7 == null) throw; // [null/range check failed]
          iVar4 = lVar7.isSummon;
          if (*(int *)(pStatics_38e8 + 0x120) <= iVar4) break;
          lVar8 = KungfuSkillLvData.DataBase(lVar7,0);
          if (lVar8 == null) throw; // [null/range check failed]
          if (-1 < *(int *)(lVar8 + 128)) break;
          lVar8 = KungfuSkillLvData.DataBase(lVar7,0);
          if (lVar8 == null) throw; // [null/range check failed]
          if (*(int *)(lVar8 + 28) == 4) break;
          lVar8 = KungfuSkillLvData.DataBase(lVar7,0);
          if (lVar8 == null) throw; // [null/range check failed]
          if (2 < *(int *)(lVar8 + 48)) {
            lVar7 = KungfuSkillLvData.DataBase(lVar7,0);
            if (lVar7 != null) {
              if (lVar7.summonMoveRange != null) break;
              goto switchD_1806fbc25_caseD_14;
            }
            throw; // [null/range check failed]
          }
        switchD_1806fbc25_caseD_14:
          uVar10 = this.targetGrid;
          lVar7 = FUN_1802107e0(0);
          if (lVar7 == null) throw; // [null/range check failed]
          uVar15 = lVar7.thisYearContribution;
          uVar10 = GlobalData.AddChild(uVar10,uVar15,0);
          this.newObj = uVar10;
          if (this.newObj == null) throw; // [null/range check failed]
          lVar7 = GameObject.GetComponent(this.newObj,DAT_181e568c8);
          if (((this.targetHero == null) ||
              (lVar8 = this.targetHero.kungfuSkills) == null) ||
             (uVar10 = FUN_1800024b0(lVar8,plVar12), lVar7 == null)) throw; // [null/range check failed]
          lVar7.summonControlable = uVar10;
          if ((this.newObj == null) ||
             (lVar7 = GameObject.GetComponent(this.newObj,DAT_181e568c8)) == null)
          throw; // [null/range check failed]
          lVar7.summonSourceHero = 4;
          if ((this.newObj == null) ||
             (lVar7 = GameObject.GetComponent(this.newObj,DAT_181e568c8)) == null)
          throw; // [null/range check failed]
          lVar7.summonLv = uVar5;
          if ((this.newObj == null) ||
             (lVar7 = GameObject.GetComponent(this.newObj,DAT_181e568c8)) == null)
          throw; // [null/range check failed]
          SkillIconController.AutoSetName(lVar7,0,0,0);
        }
        LAB_1806fc6f9:
        lVar7 = this.targetHero;
        plVar12 = (int64 *)(uint64)(uVar5 + 1);
        if (lVar7 == null) throw; // [null/range check failed]
        goto LAB_1806fb830;
        LAB_1806f8a70:
        plVar13 = &this.targetHero;
        lVar7 = *(int64 *)(local_120 + 40);
        if (lVar7 == null) throw; // [null/range check failed]
        uVar5 = (uint32)plVar6;
        if (lVar7.summonLv <= (int)uVar5) {
          if (_filterType == 14) {
            lVar7 = FUN_1802106e0(0);
            if ((((lVar7 != null) && (lVar7.summonControlable != null)) &&
                (lVar7 = WorldData.Player(lVar7.summonControlable,0)) != null) &&
               (lVar7 = lVar7.selfStorage, plVar6 = plVar12) != null) goto LAB_1806fa980;
          }
          else if (_filterType == 8) {
            lVar7 = FUN_1802106e0(0);
            if ((((lVar7 != null) && (lVar7.summonControlable != null)) &&
                (lVar7 = WorldData.Player(lVar7.summonControlable,0)) != null) &&
               (lVar7 = lVar7.selfStorage) != null) goto LAB_1806fa860;
          }
          else if (_filterType == 6) {
            lVar7 = FUN_1802106e0(0);
            if ((((lVar7 != null) && (lVar7.summonControlable != null)) &&
                (lVar7 = WorldData.Player(lVar7.summonControlable,0)) != null) &&
               (lVar7 = lVar7.selfStorage) != null) goto LAB_1806fa780;
          }
          else if (_filterType == 25) {
            lVar7 = FUN_1802106e0(0);
            if ((((lVar7 != null) && (lVar7.summonControlable != null)) &&
                (lVar7 = WorldData.Player(lVar7.summonControlable,0)) != null) &&
               (lVar7 = lVar7.selfStorage) != null) goto LAB_1806fa370;
          }
          else {
            if (_filterType != 27) goto LAB_1806faecf;
            lVar7 = FUN_1802106e0(0);
            if (((lVar7 != null) && (lVar7.summonControlable != null)) &&
               ((lVar7 = WorldData.Player(lVar7.summonControlable,0), lVar7 != null &&
                (lVar7 = lVar7.selfStorage, plVar6 = plVar12) != null)))
            goto LAB_1806f9c10;
          }
          throw; // [null/range check failed]
        }
        if (lVar7.summonLv <= uVar5) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        lVar7 = lVar7.isSummon[uVar5];
        if (local_res8 != 0) {
          if (lVar7 != null) {
            local_128[0] = lVar7.summonID;
            uVar10 = Int32.ToString(local_128,0);
            cVar2 = FUN_18175e190(local_res8,uVar10);
            if (cVar2) goto LAB_1806f8ada;
            goto LAB_1806f9b63;
          }
          throw; // [null/range check failed]
        }
        LAB_1806f8ada:
        if (2 < *(int *)(param + 24)) {
          plVar6 = (int64 *)FUN_1800024b0(param,2,DAT_181e781e0);
          if (plVar6 == (int64 *)0) throw; // [null/range check failed]
          if (*(int64 *)(*plVar6 + 64) != *(int64 *)(DAT_181e60808 + 64)) {
                          // WARNING: Subroutine does not return
            FUN_1801dfd50(plVar6,DAT_181e60808);
          }
          piVar14 = (int *)il2cpp_object_unbox();
          if (*piVar14 != -1) {
            if (lVar7 == null) throw; // [null/range check failed]
            iVar4 = *(int *)(lVar7 + 60);
            plVar6 = (int64 *)FUN_1800024b0(param,2,DAT_181e781e0);
            if (plVar6 == (int64 *)0) throw; // [null/range check failed]
            if (*(int64 *)(*plVar6 + 64) != *(int64 *)(DAT_181e60808 + 64)) {
                          // WARNING: Subroutine does not return
              FUN_1801dfd50(plVar6,DAT_181e60808);
            }
            piVar14 = (int *)il2cpp_object_unbox();
            if (iVar4 < *piVar14) goto LAB_1806f9b63;
          }
        }
        if (3 < *(int *)(param + 24)) {
          plVar6 = (int64 *)FUN_1800024b0(param,3,DAT_181e781e0);
          if (plVar6 == (int64 *)0) throw; // [null/range check failed]
          if (*(int64 *)(*plVar6 + 64) != *(int64 *)(DAT_181e60808 + 64)) {
                          // WARNING: Subroutine does not return
            FUN_1801dfd50(plVar6,DAT_181e60808);
          }
          piVar14 = (int *)il2cpp_object_unbox();
          if (*piVar14 != -1) {
            if (lVar7 == null) throw; // [null/range check failed]
            iVar4 = *(int *)(lVar7 + 60);
            plVar6 = (int64 *)FUN_1800024b0(param,3,DAT_181e781e0);
            if (plVar6 == (int64 *)0) throw; // [null/range check failed]
            if (*(int64 *)(*plVar6 + 64) != *(int64 *)(DAT_181e60808 + 64)) {
                          // WARNING: Subroutine does not return
              FUN_1801dfd50(plVar6,DAT_181e60808);
            }
            piVar14 = (int *)il2cpp_object_unbox();
            if (*piVar14 < iVar4) goto LAB_1806f9b63;
          }
        }
        if (4 < *(int *)(param + 24)) {
          plVar6 = (int64 *)FUN_1800024b0(param,4,DAT_181e781e0);
          if (plVar6 == (int64 *)0) throw; // [null/range check failed]
          if (*(int64 *)(*plVar6 + 64) != *(int64 *)(DAT_181e60808 + 64)) {
                          // WARNING: Subroutine does not return
            FUN_1801dfd50(plVar6,DAT_181e60808);
          }
          piVar14 = (int *)il2cpp_object_unbox();
          if (*piVar14 != -1) {
            if (lVar7 == null) throw; // [null/range check failed]
            iVar4 = lVar7.summonLv;
            plVar6 = (int64 *)FUN_1800024b0(param,4,DAT_181e781e0);
            if (plVar6 == (int64 *)0) throw; // [null/range check failed]
            if (*(int64 *)(*plVar6 + 64) != *(int64 *)(DAT_181e60808 + 64)) {
                          // WARNING: Subroutine does not return
              FUN_1801dfd50(plVar6,DAT_181e60808);
            }
            piVar14 = (int *)il2cpp_object_unbox();
            if (iVar4 != *piVar14) goto LAB_1806f9b63;
          }
        }
        if (5 < *(int *)(param + 24)) {
          plVar6 = (int64 *)FUN_1800024b0(param,5,DAT_181e781e0);
          if (plVar6 == (int64 *)0) throw; // [null/range check failed]
          if (*(int64 *)(*plVar6 + 64) != *(int64 *)(DAT_181e60808 + 64)) {
                          // WARNING: Subroutine does not return
            FUN_1801dfd50(plVar6,DAT_181e60808);
          }
          piVar14 = (int *)il2cpp_object_unbox();
          if (*piVar14 != -1) {
            if (lVar7 == null) throw; // [null/range check failed]
            iVar4 = lVar7.dailyAIManaged;
            plVar6 = (int64 *)FUN_1800024b0(param,5,DAT_181e781e0);
            if (plVar6 == (int64 *)0) throw; // [null/range check failed]
            if (*(int64 *)(*plVar6 + 64) != *(int64 *)(DAT_181e60808 + 64)) {
                          // WARNING: Subroutine does not return
              FUN_1801dfd50(plVar6,DAT_181e60808);
            }
            piVar14 = (int *)il2cpp_object_unbox();
            if (iVar4 < *piVar14) goto LAB_1806f9b63;
          }
        }
        if (6 < *(int *)(param + 24)) {
          plVar6 = (int64 *)FUN_1800024b0(param,6,DAT_181e781e0);
          if (plVar6 == (int64 *)0) throw; // [null/range check failed]
          if (*(int64 *)(*plVar6 + 64) != *(int64 *)(DAT_181e60808 + 64)) {
                          // WARNING: Subroutine does not return
            FUN_1801dfd50(plVar6,DAT_181e60808);
          }
          piVar14 = (int *)il2cpp_object_unbox();
          if (*piVar14 == -1) goto LAB_1806f8e02;
          if (lVar7 == null) throw; // [null/range check failed]
          if (lVar7.summonID == null) {
            if (lVar7.hide != null) {
              iVar4 = *(int *)(lVar7.hide + 20);
              plVar6 = (int64 *)FUN_1800024b0(param,6,DAT_181e781e0);
              if (plVar6 != (int64 *)0) {
                if (*(int64 *)(*plVar6 + 64) != *(int64 *)(DAT_181e60808 + 64)) {
                          // WARNING: Subroutine does not return
                  FUN_1801dfd50(plVar6,DAT_181e60808);
                }
                piVar14 = (int *)il2cpp_object_unbox();
                if (iVar4 == *piVar14) goto LAB_1806f8e02;
                goto LAB_1806f9b63;
              }
            }
            throw; // [null/range check failed]
          }
          goto LAB_1806f9b63;
        }
        LAB_1806f8e02:
        switch(_filterType) {
        case 2:
          if (lVar7 == null) throw; // [null/range check failed]
          if (lVar7.summonID - 1U < 2) goto switchD_1806f8e27_caseD_9;
          plVar6 = (int64 *)(uint64)(uVar5 + 1);
          goto LAB_1806f8a70;
        case 3:
          if (lVar7 == null) throw; // [null/range check failed]
          if ((lVar7.summonID == 5) && (lVar7.summonLv < 2)) {
        LAB_1806f8e71:
            lVar8 = FUN_180210420();
            if (lVar8 == null) throw; // [null/range check failed]
            if (*(int64 *)(lVar8 + 48) != lVar7) {
              lVar8 = FUN_180210420();
              if (lVar8 == null) throw; // [null/range check failed]
              if (*(int64 *)(lVar8 + 64) != lVar7) goto switchD_1806f8e27_caseD_9;
              plVar6 = (int64 *)(uint64)(uVar5 + 1);
              goto LAB_1806f8a70;
            }
          }
          break;
        case 4:
          if (lVar7 == null) throw; // [null/range check failed]
          if ((lVar7.summonID == 5) && (lVar7.summonLv == 2)) goto LAB_1806f8e71;
          break;
        case 5:
          if (lVar7 == null) throw; // [null/range check failed]
          if ((lVar7.summonID == 5) && (lVar7.summonLv == 3)) goto LAB_1806f8e71;
          break;
        case 6:
          if (lVar7 == null) throw; // [null/range check failed]
          if ((lVar7.summonID == 3) && (lVar7.heroAIData < 5)) {
            if (this.targetHero == null) throw; // [null/range check failed]
            lVar8 = HeroData.FindSameBook(this.targetHero,lVar7);
            if (lVar8 != null) goto switchD_1806f8e27_caseD_9;
            plVar6 = (int64 *)(uint64)(uVar5 + 1);
            goto LAB_1806f8a70;
          }
          break;
        case 7:
          lVar8 = FUN_1802106e0(0);
          if (((lVar8 == null) || (*(int64 *)(lVar8 + 32) == 0)) ||
             (lVar8 = WorldData.Player(*(int64 *)(lVar8 + 32),0)) == null) throw; // [null/range check failed]
          fVar18 = (float)HeroData.GetIdentifyKnowledge(lVar8,0);
          lVar8 = FUN_1802102e0(0);
          if (lVar8 == null) throw; // [null/range check failed]
          iVar4 = 0;
          if (*(int64 *)(lVar8 + 24) != 0) {
            lVar8 = FUN_1802102e0(0);
            uVar3 = FUN_1816387f0(this.sendResultParam,"true");
            if (lVar8 == null) throw; // [null/range check failed]
            iVar4 = BuildingUIController.GetBuildingExtraKnowledge(lVar8,uVar3);
          }
          if ((lVar7 == null) || (lVar8 = lVar7.heroNickName) == null) throw; // [null/range check failed]
          if (*(char *)(lVar8 + 16) == false) {
            if (*(float *)(lVar8 + 20) <= (float)iVar4 + fVar18) goto switchD_1806f8e27_caseD_9;
            plVar6 = (int64 *)(uint64)(uVar5 + 1);
            goto LAB_1806f8a70;
          }
          break;
        case 8:
          if (lVar7 == null) throw; // [null/range check failed]
          if (lVar7.summonID == 3) {
            if ((lVar7.heroFamilyName == null) || (this.targetHero == null)) throw; // [null/range check failed]
            lVar8 = HeroData.FindSkill(this.targetHero,*(uint32 *)(lVar7.heroFamilyName + 16));
            if ((lVar8 == null) || (*(int *)(lVar8 + 20) < 10)) goto switchD_1806f8e27_caseD_9;
            plVar6 = (int64 *)(uint64)(uVar5 + 1);
            goto LAB_1806f8a70;
          }
          break;
        default:
          goto switchD_1806f8e27_caseD_9;
        case 11:
          if (lVar7 == null) throw; // [null/range check failed]
          cVar2 = ItemData.Equiped(lVar7,0);
          if (!cVar2) goto switchD_1806f8e27_caseD_9;
          plVar6 = (int64 *)(uint64)(uVar5 + 1);
          goto LAB_1806f8a70;
        case 13:
          lVar8 = FUN_180210a70(0);
          if (lVar8 == null) throw; // [null/range check failed]
          if (*(int64 *)(lVar8 + 112) != 0) {
            lVar8 = FUN_180210a70(0);
            if ((lVar8 == null) || (*(int64 *)(lVar8 + 112) == 0)) throw; // [null/range check failed]
            cVar2 = HeroData.HaveHobby(*(int64 *)(lVar8 + 112),lVar7);
            if (cVar2) goto switchD_1806f8e27_caseD_9;
            plVar6 = (int64 *)(uint64)(uVar5 + 1);
            goto LAB_1806f8a70;
          }
          goto switchD_1806f8e27_caseD_9;
        case 14:
          if (lVar7 == null) throw; // [null/range check failed]
          if (lVar7.summonID == 3) {
            if (lVar7.heroFamilyName == null) throw; // [null/range check failed]
            iVar4 = *(int *)(lVar7.heroFamilyName + 16);
            lVar8 = FUN_180210280();
            if ((lVar8 == null) || (*(int64 *)(lVar8 + 24) == 0)) throw; // [null/range check failed]
            if (iVar4 == *(int *)(*(int64 *)(lVar8 + 24) + 16)) goto switchD_1806f8e27_caseD_9;
            plVar6 = (int64 *)(uint64)(uVar5 + 1);
            goto LAB_1806f8a70;
          }
          break;
        case 15:
          if (lVar7 == null) throw; // [null/range check failed]
          if ((lVar7.summonID != 5) || (lVar7.summonLv != 4)) break;
          lVar8 = FUN_1802103e0(0);
          if (lVar8 == null) throw; // [null/range check failed]
          uVar10 = *(uint64 *)(lVar8 + 56);
          cVar2 = Object.op_Inequality(uVar10,0);
          if (cVar2) {
            lVar8 = FUN_1802103e0(0);
            if (((lVar8 == null) || (*(int64 *)(lVar8 + 56) == 0)) ||
               (lVar8 = GameObject.GetComponent(*(int64 *)(lVar8 + 56),DAT_181e55168)) == null)
            throw; // [null/range check failed]
            if (lVar7 == *(int64 *)(lVar8 + 32)) break;
          }
          lVar8 = FUN_1802103e0(0);
          if (lVar8 == null) throw; // [null/range check failed]
          uVar10 = *(uint64 *)(lVar8 + 72);
          cVar2 = Object.op_Inequality(uVar10,0);
          if (cVar2) {
            lVar8 = FUN_1802103e0(0);
            if (((lVar8 == null) || (*(int64 *)(lVar8 + 72) == 0)) ||
               (lVar8 = GameObject.GetComponent(*(int64 *)(lVar8 + 72),DAT_181e55168)) == null)
            throw; // [null/range check failed]
            if (lVar7 == *(int64 *)(lVar8 + 32)) break;
          }
          lVar8 = FUN_1802103e0(0);
          if (lVar8 == null) throw; // [null/range check failed]
          uVar10 = *(uint64 *)(lVar8 + 88);
          cVar2 = Object.op_Inequality(uVar10,0);
          if (cVar2) {
            lVar8 = FUN_1802103e0(0);
            if (((lVar8 == null) || (*(int64 *)(lVar8 + 88) == 0)) ||
               (lVar8 = GameObject.GetComponent(*(int64 *)(lVar8 + 88),DAT_181e55168)) == null)
            throw; // [null/range check failed]
            if (lVar7 != *(int64 *)(lVar8 + 32)) goto switchD_1806f8e27_caseD_9;
            plVar6 = (int64 *)(uint64)(uVar5 + 1);
            goto LAB_1806f8a70;
          }
          goto switchD_1806f8e27_caseD_9;
        case 16:
          if (((lVar7 == null) || (lVar7.hide == null)) ||
             (lVar8 = *(int64 *)(lVar7.hide + 64)) == null) throw; // [null/range check failed]
          if (0.0 < *(float *)(lVar8 + 16)) {
            plVar6 = (int64 *)(uint64)(uVar5 + 1);
            goto LAB_1806f8a70;
          }
        switchD_1806f8e27_caseD_9:
          uVar10 = this.targetGrid;
          lVar8 = FUN_1802107e0(0);
          if (lVar8 == null) throw; // [null/range check failed]
          uVar15 = *(uint64 *)(lVar8 + 160);
          uVar10 = GlobalData.AddChild(uVar10,uVar15);
          this.newObj = uVar10;
          if ((this.newObj == null) ||
             (lVar8 = GameObject.GetComponent(this.newObj,DAT_181e55168)) == null)
          throw; // [null/range check failed]
          *(int64 *)(lVar8 + 32) = lVar7;
          if ((this.newObj == null) ||
             (lVar8 = GameObject.GetComponent(this.newObj,DAT_181e55168)) == null)
          throw; // [null/range check failed]
          *(uint32 *)(lVar8 + 40) = 3;
          if ((this.newObj == null) ||
             (lVar8 = GameObject.GetComponent(this.newObj,DAT_181e55168)) == null)
          throw; // [null/range check failed]
          ItemIconController.AutoSetName(lVar8,1);
          if ((targetFavorHero != null) && (cVar2 = HeroData.HaveHobby(targetFavorHero,lVar7), cVar2)) {
            uVar10 = this.newObj;
            lVar7 = FUN_180210d00(0);
            if (lVar7 == null) throw; // [null/range check failed]
            uVar15 = TextureController.LoadAtlasSprite(lVar7,"UIAtlas","友善度",0);
            local_118 = 0x420c0000;
            uStack_114 = 0x420c0000;
            uStack_110 = 0;
            local_f8 = 0;
            uStack_f0 = 0;
            FUN_180de6c10(&local_f8,&local_118,DAT_181e9d678);
            local_108 = local_f8;
            uStack_100 = uStack_f0;
            local_d8 = 0;
            uStack_d0 = 0;
            lVar7 = GlobalData.AddImage(uVar10,"HobbyIcon",uVar15,&local_108,&local_d8,0);
            if (lVar7 == null) throw; // [null/range check failed]
            plVar6 = (int64 *)GameObject.GetComponent(lVar7,DAT_181e54f48);
            uVar10 = 0;
            local_e8 = 0;
            uStack_e0 = 0;
            Color.ctor(&local_e8);
            if (plVar6 == (int64 *)0) throw; // [null/range check failed]
            lVar8 = *plVar6;
            local_108 = local_e8;
            uStack_100 = uStack_e0;
            (**(code **)(lVar8 + 0x2a8))(plVar6,&local_108,*(uint64 *)(lVar8 + 0x2b0),lVar8,uVar10);
            plVar6 = (int64 *)GameObject.GetComponent(lVar7,DAT_181e54f48);
            if (plVar6 == (int64 *)0) throw; // [null/range check failed]
            (**(code **)(*plVar6 + 0x408))(plVar6,*(uint64 *)(*plVar6 + 0x410));
            lVar8 = GameObject.AddComponent(lVar7,DAT_181e51de0);
            if (lVar8 == null) throw; // [null/range check failed]
            *(uint64 *)(lVar8 + 24) = "对方喜好\n赠送好感加倍";
            lVar7 = GameObject.GetComponent(lVar7,DAT_181e56510);
            if (lVar7 == null) throw; // [null/range check failed]
            lVar7.summonSourceHero = 1;
          }
          break;
        case 17:
          if (lVar7 == null) throw; // [null/range check failed]
          if (0.0 < *(float *)(lVar7 + 76)) {
            cVar2 = ItemData.DetectPoisonNum(lVar7,0);
            if (cVar2) goto switchD_1806f8e27_caseD_9;
            plVar6 = (int64 *)(uint64)(uVar5 + 1);
            goto LAB_1806f8a70;
          }
          break;
        case 20:
          lVar8 = FUN_1806ef760();
          if (lVar8 == null) throw; // [null/range check failed]
          plVar6 = plVar12;
          if (*(int *)(lVar8 + 40) == 0) {
            if (lVar7 == null) throw; // [null/range check failed]
            if (lVar7.summonLv - 2U >= 2)
            {
              }
              else {
              if (lVar7 == null) throw; // [null/range check failed]
              if (lVar7.summonLv == 4) {
            }
              do {
                lVar8 = FUN_1806ef760(0);
                if ((lVar8 == null) || (*(int64 *)(lVar8 + 32) == 0)) throw; // [null/range check failed]
                if (*(int *)(*(int64 *)(lVar8 + 32) + 24) <= (int)plVar6)
                goto switchD_1806f8e27_caseD_9;
                lVar8 = FUN_1806ef760(0);
                if ((lVar8 == null) || (*(int64 *)(lVar8 + 32) == 0)) throw; // [null/range check failed]
                uVar10 = FUN_1800024b0(*(int64 *)(lVar8 + 32),plVar6);
                cVar2 = Object.op_Inequality(uVar10,0);
                if (cVar2) {
                  lVar8 = FUN_1806ef760(0);
                  if ((((lVar8 == null) || (*(int64 *)(lVar8 + 32) == 0)) ||
                      (lVar8 = FUN_1800024b0(*(int64 *)(lVar8 + 32),plVar6)) == null) ||
                     (lVar8 = GameObject.GetComponent(lVar8,DAT_181e55168)) == null)
                  throw; // [null/range check failed]
                  if (*(int64 *)(lVar8 + 32) == lVar7) break;
                }
                plVar6 = (int64 *)(uint64)((int)plVar6 + 1);
              } while( true );
            }
          }
          break;
        case 21:
          if (((lVar7 == null) || (lVar7.heroFamilyName == null)) ||
             (lVar8 = BookData.DataBase(lVar7.heroFamilyName,0)) == null) throw; // [null/range check failed]
          cVar2 = KungfuSkillData.HaveForce(lVar8,0);
          if (cVar2) {
            if ((lVar7.heroFamilyName == null) ||
               (lVar8 = BookData.DataBase(lVar7.heroFamilyName,0)) == null)
            throw; // [null/range check failed]
            iVar4 = *(int *)(lVar8 + 24);
            lVar8 = FUN_1802106e0(0);
            if (((lVar8 == null) || (*(int64 *)(lVar8 + 32) == 0)) ||
               (lVar8 = WorldData.Player(*(int64 *)(lVar8 + 32),0)) == null) throw; // [null/range check failed]
            plVar6 = plVar12;
            if (iVar4 != *(int *)(lVar8 + 132)) {
              while( true ) {
                lVar8 = FUN_1802106e0(0);
                if ((((lVar8 == null) || (*(int64 *)(lVar8 + 32) == 0)) ||
                    (lVar8 = *(int64 *)(*(int64 *)(lVar8 + 32) + 0x218)) == null) ||
                   (lVar8 = *(int64 *)(lVar8 + 40)) == null) throw; // [null/range check failed]
                if (*(int *)(lVar8 + 24) <= (int)plVar6) goto switchD_1806f8e27_caseD_9;
                lVar8 = FUN_1802106e0(0);
                if ((((lVar8 == null) || (*(int64 *)(lVar8 + 32) == 0)) ||
                    ((lVar8 = *(int64 *)(*(int64 *)(lVar8 + 32) + 0x218), lVar8 == null ||
                     (((lVar8 = *(int64 *)(lVar8 + 40), lVar8 == null ||
                       (lVar8 = FUN_1800024b0(lVar8,plVar6)) == null) ||
                      (*(int64 *)(lVar8 + 112) == 0)))))) || (lVar7.heroFamilyName == null))
                throw; // [null/range check failed]
                if (*(int *)(*(int64 *)(lVar8 + 112) + 16) ==
                    *(int *)(lVar7.heroFamilyName + 16)) break;
                plVar6 = (int64 *)(uint64)((int)plVar6 + 1);
              }
            }
          }
          break;
        case 24:
          lVar8 = FUN_180210a70();
          if (lVar8 == null) throw; // [null/range check failed]
          if (*(int64 *)(lVar8 + 112) == 0) {
            fVar18 = 0.0;
          }
          else {
            lVar8 = FUN_180210a70(0);
            if ((lVar8 == null) || (*(int64 *)(lVar8 + 112) == 0)) throw; // [null/range check failed]
            fVar18 = (float)HeroData.GetIdentifyKnowledge(*(int64 *)(lVar8 + 112),0);
          }
          if ((lVar7 == null) || (lVar8 = lVar7.heroNickName) == null) throw; // [null/range check failed]
          if (*(char *)(lVar8 + 16) != false) break;
          if (*(float *)(lVar8 + 20) <= fVar18) goto switchD_1806f8e27_caseD_9;
          plVar6 = (int64 *)(uint64)(uVar5 + 1);
          goto LAB_1806f8a70;
        case 27:
          if (lVar7 == null) throw; // [null/range check failed]
          if (lVar7.summonID == 3) {
            if ((lVar7.heroFamilyName == null) ||
               (lVar8 = BookData.DataBase(lVar7.heroFamilyName,0)) == null)
            throw; // [null/range check failed]
            iVar4 = *(int *)(lVar8 + 52);
            lVar8 = FUN_180210a70();
            if ((lVar8 == null) || (*(int64 *)(lVar8 + 112) == 0)) throw; // [null/range check failed]
            if (iVar4 <= *(int *)(*(int64 *)(lVar8 + 112) + 184)) {
              lVar8 = FUN_180210a70(0);
              if (lVar8 == null) throw; // [null/range check failed]
              if ((lVar7.heroFamilyName == null) || (*(int64 *)(lVar8 + 112) == 0))
              throw; // [null/range check failed]
              lVar8 = HeroData.FindSkill(*(int64 *)(lVar8 + 112),
                                          *(uint32 *)(lVar7.heroFamilyName + 16));
              if (lVar8 == null) goto switchD_1806f8e27_caseD_9;
            }
          }
        }
        LAB_1806f9b63:
        plVar6 = (int64 *)(uint64)(uVar5 + 1);
        goto LAB_1806f8a70;
        LAB_1806fa980:
        lVar8 = lVar7.summonSourceHero;
        if (lVar8 == null) throw; // [null/range check failed]
        uVar5 = (uint32)plVar6;
        if (*(int *)(lVar8 + 24) <= (int)uVar5) {
          lVar7 = FUN_1802106e0(0);
          if (((lVar7 != null) && (lVar7.summonControlable != null)) &&
             (lVar7 = WorldData.Player(lVar7.summonControlable,0)) != null) {
            lVar7 = HeroData.GetForce(lVar7,0,0);
            if (lVar7 == null) goto LAB_1806faecf;
            lVar7 = FUN_1802106e0(0);
            if ((((lVar7 != null) && (lVar7.summonControlable != null)) &&
                (lVar7 = WorldData.Player(lVar7.summonControlable,0)) != null) &&
               ((lVar7 = HeroData.GetForce(lVar7,0,0), lVar7 != null &&
                (lVar7 = lVar7.heroForceLv, plVar6 = plVar12) != null))) goto LAB_1806fab50;
          }
          throw; // [null/range check failed]
        }
        if (*(uint32 *)(lVar8 + 24) <= uVar5) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        lVar8 = lVar8[uVar5];
        if (lVar8 == null) throw; // [null/range check failed]
        if (*(int *)(lVar8 + 20) == 3) {
          if (((lVar7.summonSourceHero == null) || (lVar8 = FUN_1800024b0()) == null) ||
             (*(int64 *)(lVar8 + 112) == 0)) throw; // [null/range check failed]
          iVar4 = *(int *)(*(int64 *)(lVar8 + 112) + 16);
          lVar8 = FUN_180210280();
          if ((lVar8 == null) || (*(int64 *)(lVar8 + 24) == 0)) throw; // [null/range check failed]
          if (iVar4 == *(int *)(*(int64 *)(lVar8 + 24) + 16)) {
            if (lVar7.summonSourceHero == null) throw; // [null/range check failed]
            uVar10 = FUN_1800024b0(lVar7.summonSourceHero,plVar6,DAT_181e73170);
            ChooseController.CreateChooseItem(this,uVar10,"仓库",0);
          }
        }
        plVar6 = (int64 *)(uint64)(uVar5 + 1);
        goto LAB_1806fa980;
        LAB_1806fab50:
        lVar8 = lVar7.summonSourceHero;
        if (lVar8 == null) throw; // [null/range check failed]
        uVar5 = (uint32)plVar6;
        plVar13 = plVar12;
        if (*(int *)(lVar8 + 24) <= (int)uVar5) goto LAB_1806fac50;
        if (*(uint32 *)(lVar8 + 24) <= uVar5) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        lVar8 = lVar8[uVar5];
        if (lVar8 == null) throw; // [null/range check failed]
        if (*(int *)(lVar8 + 20) == 3) {
          if (((lVar7.summonSourceHero == null) || (lVar8 = FUN_1800024b0()) == null) ||
             (*(int64 *)(lVar8 + 112) == 0)) throw; // [null/range check failed]
          iVar4 = *(int *)(*(int64 *)(lVar8 + 112) + 16);
          lVar8 = FUN_180210280();
          if ((lVar8 == null) || (*(int64 *)(lVar8 + 24) == 0)) throw; // [null/range check failed]
          if (iVar4 == *(int *)(*(int64 *)(lVar8 + 24) + 16)) {
            if (lVar7.summonSourceHero == null) throw; // [null/range check failed]
            uVar10 = FUN_1800024b0(lVar7.summonSourceHero,plVar6,DAT_181e73170);
            ChooseController.CreateChooseItem(this,uVar10,"藏经阁",0);
          }
        }
        plVar6 = (int64 *)(uint64)(uVar5 + 1);
        goto LAB_1806fab50;
        LAB_1806fac50:
        if ((((GameController._instance == null) ||
             (lVar7 = GameController._instance.worldData) == null) ||
            (lVar7 = WorldData.Player(lVar7,0)) == null) ||
           ((lVar7 = HeroData.GetForce(lVar7,0,0), lVar7 == null || (lVar7.heroAIData == null))))
        throw; // [null/range check failed]
        if (*(int *)(lVar7.heroAIData + 24) <= (int)plVar13) goto LAB_1806faecf;
        lVar7 = FUN_1802106e0(0);
        if (lVar7 == null) throw; // [null/range check failed]
        lVar7 = lVar7.summonControlable;
        lVar8 = FUN_1802106e0(0);
        if ((((((lVar8 == null) || (*(int64 *)(lVar8 + 32) == 0)) ||
              (lVar8 = WorldData.Player(*(int64 *)(lVar8 + 32),0)) == null) ||
             ((lVar8 = HeroData.GetForce(lVar8,0,0), lVar8 == null || (*(int64 *)(lVar8 + 64) == 0))))
            || (FUN_180002480(*(int64 *)(lVar8 + 64),plVar13), lVar7 == null)) ||
           (lVar7 = WorldData.GetForce(lVar7)) == null) throw; // [null/range check failed]
        lVar7 = lVar7.heroForceLv;
        plVar6 = plVar12;
        while( true ) {
          if ((lVar7 == null) || (lVar7.summonSourceHero == null)) throw; // [null/range check failed]
          if (*(int *)(lVar7.summonSourceHero + 24) <= (int)plVar6) break;
          lVar8 = FUN_1800024b0();
          if (lVar8 == null) throw; // [null/range check failed]
          if (*(int *)(lVar8 + 20) == 3) {
            if (((lVar7.summonSourceHero == null) || (lVar8 = FUN_1800024b0()) == null) ||
               (*(int64 *)(lVar8 + 112) == 0)) throw; // [null/range check failed]
            iVar4 = *(int *)(*(int64 *)(lVar8 + 112) + 16);
            lVar8 = FUN_180210280(0);
            if ((lVar8 == null) || (*(int64 *)(lVar8 + 24) == 0)) throw; // [null/range check failed]
            if (iVar4 == *(int *)(*(int64 *)(lVar8 + 24) + 16)) {
              if (lVar7.summonSourceHero == null) throw; // [null/range check failed]
              uVar10 = FUN_1800024b0(lVar7.summonSourceHero,plVar6,DAT_181e73170);
              ChooseController.CreateChooseItem(this,uVar10,"附庸藏经阁",0);
            }
          }
          plVar6 = (int64 *)(uint64)((int)plVar6 + 1);
        }
        plVar13 = (int64 *)(uint64)((int)plVar13 + 1);
        goto LAB_1806fac50;
        LAB_1806fa860:
        lVar8 = lVar7.summonSourceHero;
        if (lVar8 == null) throw; // [null/range check failed]
        uVar5 = (uint32)plVar12;
        if (*(int *)(lVar8 + 24) <= (int)uVar5) goto LAB_1806faecf;
        if (*(uint32 *)(lVar8 + 24) <= uVar5) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        lVar8 = lVar8[uVar5];
        if (lVar8 == null) throw; // [null/range check failed]
        if (*(int *)(lVar8 + 20) == 3) {
          if ((*(int64 *)(lVar8 + 112) == 0) || (*plVar13 == 0)) throw; // [null/range check failed]
          lVar16 = HeroData.FindSkill(*plVar13,*(uint32 *)(*(int64 *)(lVar8 + 112) + 16),0);
          if (lVar16 != null) {
            if (((*(int64 *)(lVar8 + 112) == 0) || (*plVar13 == 0)) ||
               (lVar16 = HeroData.FindSkill(*plVar13,*(uint32 *)(*(int64 *)(lVar8 + 112) + 16),
                                             0), lVar16 == null)) throw; // [null/range check failed]
            if (9 >= *(int *)(lVar16 + 20))
            {
              }
              ChooseController.CreateChooseItem(this,lVar8,"仓库",0);
              }
            }
        plVar12 = (int64 *)(uint64)(uVar5 + 1);
        goto LAB_1806fa860;
        LAB_1806fa780:
        lVar8 = lVar7.summonSourceHero;
        if (lVar8 == null) throw; // [null/range check failed]
        uVar5 = (uint32)plVar12;
        if (*(int *)(lVar8 + 24) <= (int)uVar5) goto LAB_1806faecf;
        if (*(uint32 *)(lVar8 + 24) <= uVar5) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        lVar8 = lVar8[uVar5];
        if (lVar8 == null) throw; // [null/range check failed]
        if ((*(int *)(lVar8 + 20) == 3) && (*(int *)(lVar8 + 64) < 5)) {
          if (*plVar13 == 0) throw; // [null/range check failed]
          lVar16 = HeroData.FindSameBook(*plVar13,lVar8,0);
          if (lVar16 != null) {
            ChooseController.CreateChooseItem(this,lVar8,"仓库",0);
          }
        }
        plVar12 = (int64 *)(uint64)(uVar5 + 1);
        goto LAB_1806fa780;
        LAB_1806fa370:
        lVar8 = lVar7.summonSourceHero;
        if (lVar8 == null) throw; // [null/range check failed]
        uVar5 = (uint32)plVar12;
        if (*(int *)(lVar8 + 24) <= (int)uVar5) goto LAB_1806faecf;
        if (*(uint32 *)(lVar8 + 24) <= uVar5) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        lVar8 = lVar8[uVar5];
        if (local_res8 != 0) {
          if (lVar8 != null) {
            local_128[0] = *(uint32 *)(lVar8 + 20);
            uVar10 = Int32.ToString(local_128,0);
            cVar2 = FUN_18175e190(local_res8,uVar10,DAT_181e86470);
            if (cVar2) goto LAB_1806fa3da;
            goto LAB_1806fa713;
          }
          throw; // [null/range check failed]
        }
        LAB_1806fa3da:
        if (2 < *(int *)(param + 24)) {
          plVar12 = (int64 *)FUN_1800024b0(param,2,DAT_181e781e0);
          if (plVar12 == (int64 *)0) throw; // [null/range check failed]
          if (*(int64 *)(*plVar12 + 64) != *(int64 *)(DAT_181e60808 + 64)) {
                          // WARNING: Subroutine does not return
            FUN_1801dfd50(plVar12,DAT_181e60808);
          }
          piVar14 = (int *)il2cpp_object_unbox();
          if (*piVar14 != -1) {
            if (lVar8 == null) throw; // [null/range check failed]
            iVar4 = *(int *)(lVar8 + 60);
            plVar12 = (int64 *)FUN_1800024b0(param,2,DAT_181e781e0);
            if (plVar12 == (int64 *)0) throw; // [null/range check failed]
            if (*(int64 *)(*plVar12 + 64) != *(int64 *)(DAT_181e60808 + 64)) {
                          // WARNING: Subroutine does not return
              FUN_1801dfd50(plVar12,DAT_181e60808);
            }
            piVar14 = (int *)il2cpp_object_unbox();
            if (iVar4 < *piVar14) goto LAB_1806fa713;
          }
        }
        if (3 < *(int *)(param + 24)) {
          plVar12 = (int64 *)FUN_1800024b0(param,3,DAT_181e781e0);
          if (plVar12 == (int64 *)0) throw; // [null/range check failed]
          if (*(int64 *)(*plVar12 + 64) != *(int64 *)(DAT_181e60808 + 64)) {
                          // WARNING: Subroutine does not return
            FUN_1801dfd50(plVar12,DAT_181e60808);
          }
          piVar14 = (int *)il2cpp_object_unbox();
          if (*piVar14 != -1) {
            if (lVar8 == null) throw; // [null/range check failed]
            iVar4 = *(int *)(lVar8 + 60);
            plVar12 = (int64 *)FUN_1800024b0(param,3,DAT_181e781e0);
            if (plVar12 == (int64 *)0) throw; // [null/range check failed]
            if (*(int64 *)(*plVar12 + 64) != *(int64 *)(DAT_181e60808 + 64)) {
                          // WARNING: Subroutine does not return
              FUN_1801dfd50(plVar12,DAT_181e60808);
            }
            piVar14 = (int *)il2cpp_object_unbox();
            if (*piVar14 < iVar4) goto LAB_1806fa713;
          }
        }
        if (4 < *(int *)(param + 24)) {
          plVar12 = (int64 *)FUN_1800024b0(param,4,DAT_181e781e0);
          if (plVar12 == (int64 *)0) throw; // [null/range check failed]
          if (*(int64 *)(*plVar12 + 64) != *(int64 *)(DAT_181e60808 + 64)) {
                          // WARNING: Subroutine does not return
            FUN_1801dfd50(plVar12,DAT_181e60808);
          }
          piVar14 = (int *)il2cpp_object_unbox();
          if (*piVar14 != -1) {
            if (lVar8 == null) throw; // [null/range check failed]
            iVar4 = *(int *)(lVar8 + 24);
            plVar12 = (int64 *)FUN_1800024b0(param,4,DAT_181e781e0);
            if (plVar12 == (int64 *)0) throw; // [null/range check failed]
            if (*(int64 *)(*plVar12 + 64) != *(int64 *)(DAT_181e60808 + 64)) {
                          // WARNING: Subroutine does not return
              FUN_1801dfd50(plVar12,DAT_181e60808);
            }
            piVar14 = (int *)il2cpp_object_unbox();
            if (iVar4 != *piVar14) goto LAB_1806fa713;
          }
        }
        if (5 < *(int *)(param + 24)) {
          plVar12 = (int64 *)FUN_1800024b0(param,5,DAT_181e781e0);
          if (plVar12 == (int64 *)0) throw; // [null/range check failed]
          if (*(int64 *)(*plVar12 + 64) != *(int64 *)(DAT_181e60808 + 64)) {
                          // WARNING: Subroutine does not return
            FUN_1801dfd50(plVar12,DAT_181e60808);
          }
          piVar14 = (int *)il2cpp_object_unbox();
          if (*piVar14 != -1) {
            if (lVar8 == null) throw; // [null/range check failed]
            iVar4 = *(int *)(lVar8 + 56);
            plVar12 = (int64 *)FUN_1800024b0(param,5,DAT_181e781e0);
            if (plVar12 == (int64 *)0) throw; // [null/range check failed]
            if (*(int64 *)(*plVar12 + 64) != *(int64 *)(DAT_181e60808 + 64)) {
                          // WARNING: Subroutine does not return
              FUN_1801dfd50(plVar12,DAT_181e60808);
            }
            piVar14 = (int *)il2cpp_object_unbox();
            if (iVar4 < *piVar14) goto LAB_1806fa713;
          }
        }
        if (*(int *)(param + 24) < 7) {
        LAB_1806fa6fa:
          ChooseController.CreateChooseItem(this,lVar8,"仓库",0);
        }
        else {
          plVar12 = (int64 *)FUN_1800024b0(param,6,DAT_181e781e0);
          if (plVar12 == (int64 *)0) throw; // [null/range check failed]
          if (*(int64 *)(*plVar12 + 64) != *(int64 *)(DAT_181e60808 + 64)) {
                          // WARNING: Subroutine does not return
            FUN_1801dfd50(plVar12,DAT_181e60808);
          }
          piVar14 = (int *)il2cpp_object_unbox();
          if (*piVar14 == -1) goto LAB_1806fa6fa;
          if (lVar8 == null) throw; // [null/range check failed]
          if (*(int *)(lVar8 + 20) == 0) {
            if (*(int64 *)(lVar8 + 96) == 0) throw; // [null/range check failed]
            iVar4 = *(int *)(*(int64 *)(lVar8 + 96) + 20);
            plVar12 = (int64 *)FUN_1800024b0(param,6,DAT_181e781e0);
            if (plVar12 == (int64 *)0) throw; // [null/range check failed]
            if (*(int64 *)(*plVar12 + 64) != *(int64 *)(DAT_181e60808 + 64)) {
                          // WARNING: Subroutine does not return
              FUN_1801dfd50();
            }
            piVar14 = (int *)il2cpp_object_unbox();
            if (iVar4 == *piVar14) goto LAB_1806fa6fa;
          }
        }
        LAB_1806fa713:
        plVar12 = (int64 *)(uint64)(uVar5 + 1);
        goto LAB_1806fa370;
        LAB_1806f9c10:
        lVar8 = lVar7.summonSourceHero;
        if (lVar8 == null) throw; // [null/range check failed]
        uVar5 = (uint32)plVar6;
        if (*(int *)(lVar8 + 24) <= (int)uVar5) {
          lVar7 = FUN_1802106e0(0);
          if (((lVar7 != null) && (lVar7.summonControlable != null)) &&
             (lVar7 = WorldData.Player(lVar7.summonControlable,0)) != null) {
            lVar7 = HeroData.GetForce(lVar7,0,0);
            if (lVar7 == null) goto LAB_1806faecf;
            lVar7 = FUN_1802106e0(0);
            if (((lVar7 != null) && (lVar7.summonControlable != null)) &&
               ((lVar7 = WorldData.Player(lVar7.summonControlable,0), lVar7 != null &&
                ((lVar7 = HeroData.GetForce(lVar7,0,0), lVar7 != null &&
                 (lVar7 = lVar7.heroForceLv, plVar6 = plVar12) != null)))))
            goto LAB_1806f9e70;
          }
          throw; // [null/range check failed]
        }
        if (*(uint32 *)(lVar8 + 24) <= uVar5) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        lVar8 = lVar8[uVar5];
        if (lVar8 == null) throw; // [null/range check failed]
        if (*(int *)(lVar8 + 20) == 3) {
          if (((lVar7.summonSourceHero == null) || (lVar8 = FUN_1800024b0()) == null) ||
             ((*(int64 *)(lVar8 + 112) == 0 || (lVar8 = BookData.DataBase()) == null)))
          throw; // [null/range check failed]
          iVar4 = *(int *)(lVar8 + 52);
          lVar8 = FUN_180210a70();
          if ((lVar8 == null) || (*(int64 *)(lVar8 + 112) == 0)) throw; // [null/range check failed]
          if (iVar4 <= *(int *)(*(int64 *)(lVar8 + 112) + 184)) {
            lVar8 = FUN_180210a70(0);
            if (lVar8 == null) throw; // [null/range check failed]
            lVar8 = *(int64 *)(lVar8 + 112);
            if ((((lVar7.summonSourceHero == null) ||
                 (lVar16 = FUN_1800024b0(lVar7.summonSourceHero,plVar6)) == null) ||
                (*(int64 *)(lVar16 + 112) == 0)) || (lVar8 == null)) throw; // [null/range check failed]
            lVar8 = HeroData.FindSkill();
            if (lVar8 == null) {
              if (lVar7.summonSourceHero == null) throw; // [null/range check failed]
              uVar10 = FUN_1800024b0(lVar7.summonSourceHero,plVar6,DAT_181e73170);
              ChooseController.CreateChooseItem(this,uVar10,"仓库",0);
            }
          }
        }
        plVar6 = (int64 *)(uint64)(uVar5 + 1);
        goto LAB_1806f9c10;
        LAB_1806f9e70:
        lVar8 = lVar7.summonSourceHero;
        if (lVar8 == null) throw; // [null/range check failed]
        uVar5 = (uint32)plVar6;
        plVar13 = plVar12;
        if (*(int *)(lVar8 + 24) <= (int)uVar5) goto LAB_1806fa000;
        if (*(uint32 *)(lVar8 + 24) <= uVar5) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        lVar8 = lVar8[uVar5];
        if (lVar8 == null) throw; // [null/range check failed]
        if (*(int *)(lVar8 + 20) == 3) {
          if (((lVar7.summonSourceHero == null) || (lVar8 = FUN_1800024b0()) == null) ||
             ((*(int64 *)(lVar8 + 112) == 0 || (lVar8 = BookData.DataBase()) == null)))
          throw; // [null/range check failed]
          iVar4 = *(int *)(lVar8 + 52);
          lVar8 = FUN_180210a70();
          if ((lVar8 == null) || (*(int64 *)(lVar8 + 112) == 0)) throw; // [null/range check failed]
          if (iVar4 <= *(int *)(*(int64 *)(lVar8 + 112) + 184)) {
            lVar8 = FUN_180210a70(0);
            if (lVar8 == null) throw; // [null/range check failed]
            lVar8 = *(int64 *)(lVar8 + 112);
            if ((((lVar7.summonSourceHero == null) ||
                 (lVar16 = FUN_1800024b0(lVar7.summonSourceHero,plVar6)) == null) ||
                (*(int64 *)(lVar16 + 112) == 0)) || (lVar8 == null)) throw; // [null/range check failed]
            lVar8 = HeroData.FindSkill();
            if (lVar8 == null) {
              if (lVar7.summonSourceHero == null) throw; // [null/range check failed]
              uVar10 = FUN_1800024b0(lVar7.summonSourceHero,plVar6,DAT_181e73170);
              ChooseController.CreateChooseItem(this,uVar10,"藏经阁",0);
            }
          }
        }
        plVar6 = (int64 *)(uint64)(uVar5 + 1);
        goto LAB_1806f9e70;
        LAB_1806fa000:
        if ((((GameController._instance == null) ||
             (lVar7 = GameController._instance.worldData) == null) ||
            (lVar7 = WorldData.Player(lVar7,0)) == null) ||
           ((lVar7 = HeroData.GetForce(lVar7,0,0), lVar7 == null || (lVar7.heroAIData == null))))
        throw; // [null/range check failed]
        if (*(int *)(lVar7.heroAIData + 24) <= (int)plVar13) goto LAB_1806faecf;
        lVar7 = FUN_1802106e0(0);
        if (lVar7 == null) throw; // [null/range check failed]
        lVar7 = lVar7.summonControlable;
        lVar8 = FUN_1802106e0(0);
        if ((((lVar8 == null) || (*(int64 *)(lVar8 + 32) == 0)) ||
            (lVar8 = WorldData.Player(*(int64 *)(lVar8 + 32),0)) == null) ||
           (((lVar8 = HeroData.GetForce(lVar8,0,0), lVar8 == null || (*(int64 *)(lVar8 + 64) == 0)) ||
            ((FUN_180002480(*(int64 *)(lVar8 + 64),plVar13), lVar7 == null ||
             (lVar7 = WorldData.GetForce(lVar7)) == null))))) throw; // [null/range check failed]
        lVar7 = lVar7.heroForceLv;
        plVar6 = plVar12;
        while( true ) {
          if ((lVar7 == null) || (lVar7.summonSourceHero == null)) throw; // [null/range check failed]
          if (*(int *)(lVar7.summonSourceHero + 24) <= (int)plVar6) break;
          lVar8 = FUN_1800024b0();
          if (lVar8 == null) throw; // [null/range check failed]
          if (*(int *)(lVar8 + 20) == 3) {
            if ((((lVar7.summonSourceHero == null) || (lVar8 = FUN_1800024b0()) == null) ||
                (*(int64 *)(lVar8 + 112) == 0)) || (lVar8 = BookData.DataBase()) == null)
            throw; // [null/range check failed]
            iVar4 = *(int *)(lVar8 + 52);
            lVar8 = FUN_180210a70(0);
            if ((lVar8 == null) || (*(int64 *)(lVar8 + 112) == 0)) throw; // [null/range check failed]
            if (iVar4 <= *(int *)(*(int64 *)(lVar8 + 112) + 184)) {
              lVar8 = FUN_180210a70(0);
              if (lVar8 == null) throw; // [null/range check failed]
              lVar8 = *(int64 *)(lVar8 + 112);
              if ((((lVar7.summonSourceHero == null) ||
                   (lVar16 = FUN_1800024b0(lVar7.summonSourceHero,plVar6)) == null) ||
                  (*(int64 *)(lVar16 + 112) == 0)) || (lVar8 == null)) throw; // [null/range check failed]
              lVar8 = HeroData.FindSkill(lVar8);
              if (lVar8 == null) {
                if (lVar7.summonSourceHero == null) throw; // [null/range check failed]
                uVar10 = FUN_1800024b0(lVar7.summonSourceHero,plVar6,DAT_181e73170);
                ChooseController.CreateChooseItem(this,uVar10,"附庸藏经阁",0);
              }
            }
          }
          plVar6 = (int64 *)(uint64)((int)plVar6 + 1);
        }
        plVar13 = (int64 *)(uint64)((int)plVar13 + 1);
        goto LAB_1806fa000;
        LAB_1806f87d6:
        iVar4 = (int)plVar6;
        local_130 = iVar4;
        lVar7 = *(int64 *)(pStatics_38e8 + 0x4d8);
        if (lVar7 == null) throw; // [null/range check failed]
        if (iVar4 < lVar7.summonLv) {
          if (local_res8 == 0) {
        LAB_1806f899b:
            if (((this.itemList == null) ||
                (lVar7 = GameObject.get_transform(this.itemList,0)) == null) ||
               (lVar7 = Transform.Find(lVar7,"ItemFlitter")) == null) throw; // [null/range check failed]
            lVar7 = Transform.Find(lVar7,"ItemTypeFlitter");
            uVar10 = Int32.ToString(&local_130,0);
            if (((lVar7 == null) || (lVar7 = Transform.Find(lVar7,uVar10)) == null) ||
               (lVar7 = Component.GetComponent(lVar7,DAT_181e796b8)) == null) throw; // [null/range check failed]
            Selectable.set_interactable(lVar7);
            plVar6 = (int64 *)(uint64)(local_130 + 1);
          }
          else {
            uVar10 = Int32.ToString(&local_130,0);
            cVar2 = FUN_18175e190(local_res8,uVar10);
            if (cVar2) goto LAB_1806f899b;
            if (((this.itemList == null) ||
                (lVar7 = GameObject.get_transform(this.itemList,0)) == null) ||
               (lVar7 = Transform.Find(lVar7,"ItemFlitter")) == null) throw; // [null/range check failed]
            lVar7 = Transform.Find(lVar7,"ItemTypeFlitter");
            uVar10 = Int32.ToString(&local_130,0);
            if (((lVar7 == null) || (lVar7 = Transform.Find(lVar7,uVar10)) == null) ||
               (lVar7 = Component.GetComponent(lVar7,DAT_181e796b8)) == null) throw; // [null/range check failed]
            Selectable.set_interactable(lVar7,0);
            if (((this.itemList == null) ||
                (lVar7 = GameObject.get_transform(this.itemList,0)) == null) ||
               (lVar7 = Transform.Find(lVar7,"ItemFlitter")) == null) throw; // [null/range check failed]
            lVar7 = Transform.Find(lVar7,"ItemTypeFlitter");
            uVar10 = Int32.ToString(&local_130,0);
            if (((lVar7 == null) || (lVar7 = Transform.Find(lVar7,uVar10)) == null) ||
               (lVar7 = Component.GetComponent(lVar7)) == null) throw; // [null/range check failed]
            Toggle.set_isOn(lVar7);
            plVar6 = (int64 *)(uint64)(local_130 + 1);
          }
          goto LAB_1806f87d6;
        }
        plVar6 = plVar12;
        if (local_120 != 0) goto LAB_1806f8a70;
    }

    // Token : 0x6000E8E
    // RVA   : 0x6F53C0   Offset: 0x6F41C0   Length: 0x2A7
    public void CreateChooseItem(ItemData targetItem, string fromStorage)
    {
        var pStatics = *(int64*)(DAT_181e52a90 + 184);
        bool cVar1;
        ulong uVar2;
        long lVar3;
        ulong uVar4;
        uVar2 = this.targetGrid;
        if (*pStatics != 0) {
          uVar4 = *(uint64 *)(*pStatics + 160);
          uVar2 = GlobalData.AddChild(uVar2,uVar4,0);
          this.newObj = uVar2;
          if ((this.newObj != null) &&
             (lVar3 = GameObject.GetComponent(this.newObj,DAT_181e55168)) != null)
          {
            *(uint64 *)(lVar3 + 32) = targetItem;
            if ((this.newObj != null) &&
               (lVar3 = GameObject.GetComponent(this.newObj,DAT_181e55168)) != null
               ) {
              *(uint32 *)(lVar3 + 40) = 3;
              if ((this.newObj != null) &&
                 (lVar3 = GameObject.GetComponent(this.newObj,DAT_181e55168),
                 lVar3 != null)) {
                ItemIconController.AutoSetName(lVar3,1,0);
                if ((this.newObj != null) &&
                   (lVar3 = GameObject.GetComponent(this.newObj,DAT_181e55168),
                   lVar3 != null)) {
                  *(int64 *)(lVar3 + 72) = fromStorage;
                  if (fromStorage != null) {
                    cVar1 = FUN_1816387f0(fromStorage,"仓库",0);
                    if (!cVar1) {
                      cVar1 = FUN_1816387f0(fromStorage,"藏经阁",0);
                      if (!cVar1) {
                        cVar1 = FUN_1816387f0(fromStorage,"附庸藏经阁",0);
                        if (!cVar1) {
                          return;
                        }
                        lVar3 = this.newObj;
                        if (lVar3 == null) throw; // [null/range check failed]
                        uVar4 = Object.get_name(lVar3,0);
                        uVar2 = "99";
                      }
                      else {
                        lVar3 = this.newObj;
                        if (lVar3 == null) throw; // [null/range check failed]
                        uVar4 = Object.get_name(lVar3,0);
                        uVar2 = "98";
                      }
                    }
                    else {
                      lVar3 = this.newObj;
                      if (lVar3 == null) throw; // [null/range check failed]
                      uVar4 = Object.get_name(lVar3,0);
                      uVar2 = "97";
                    }
                    uVar2 = String.Concat(uVar2,uVar4,0);
                    Object.set_name(lVar3,uVar2,0);
                  }
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x6000E8F
    // RVA   : 0x6F5280   Offset: 0x6F4080   Length: 0x138
    public void ChooseObj(GameObject targetObj)
    {
        ulong uVar1;
        long lVar2;
        bool cVar3;
        uVar1 = this.sendResultFucTarget;
        cVar3 = Object.op_Inequality(uVar1,0,0);
        if (!cVar3) {
          return;
        }
        if (this.sendResultFuc == null) {
          return;
        }
        this.chooseResult = targetObj;
        if (this.chooseResult != null) {
          lVar2 = GameObject.get_transform(this.chooseResult,0);
          if ((this.chooseRoot != null) &&
             (uVar1 = GameObject.get_transform(this.chooseRoot,0), lVar2 != null)) {
            FUN_180b06720(lVar2,uVar1,0);
            if ((this.sendResultParam == null) ||
               (cVar3 = FUN_1816387f0(this.sendResultParam,"",0), cVar3)) {
              if (this.sendResultFucTarget == null) throw; // [null/range check failed]
              GameObject.SendMessage(this.sendResultFucTarget,this.sendResultFuc,0);
            }
            else {
              if (this.sendResultFucTarget == null) throw; // [null/range check failed]
              GameObject.SendMessage
                        (this.sendResultFucTarget,this.sendResultFuc,
                         this.sendResultParam,0);
            }
            ChooseController.HideChoosePanel(this,0);
            return;
          }
        }
    }

    // Token : 0x6000E90
    // RVA   : 0x6FDB50   Offset: 0x6FC950   Length: 0xBF
    public void UnshowChoosePanel()
    {
        plVar1 = (int64 *)Resources.Load("Sound/SoundEffect/PaperQuick",0);
        plVar2 = (int64 *)0;
        if ((plVar1 != (int64 *)0) && (*plVar1 == DAT_181e8f4a0)) {
          plVar2 = plVar1;
        }
        NGUITools.PlaySound(plVar2,0);
        if (this.cancelFuc != null) {
          if (this.sendResultFucTarget == null) {
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          GameObject.SendMessage(this.sendResultFucTarget,this.cancelFuc,0);
        }
        ChooseController.HideChoosePanel(this,0);
    }

    // Token : 0x6000E91
    // RVA   : 0x6F5670   Offset: 0x6F4470   Length: 0x60F
    public void HideChoosePanel()
    {
        ulong uVar1;
        int iVar2;
        int iVar3;
        long lVar4;
        ulong uVar5;
        int iVar6;
        if ((this.choosePanel != null) &&
           (lVar4 = GameObject.get_transform(this.choosePanel,0)) != null) {
          uVar1 = Transform.Find(lVar4,"ChoosePanelRoot",0);
          uVar1 = ShortcutExtensions.DOScale(uVar1,0,0x3dcccccd,0);
          uVar1 = TweenSettingsExtensions.SetUpdate(uVar1,1,DAT_181ea59e0);
          uVar5 = new OnTooltipCB(this,DAT_181e73c48,0);
          TweenSettingsExtensions.OnComplete(uVar1,uVar5,DAT_181ea3dc0);
          if ((this.choosePanel != null) &&
             ((lVar4 = GameObject.get_transform(this.choosePanel,0), lVar4 != null &&
              (lVar4 = Transform.Find(lVar4,"BlackBackground",0)) != null))) {
            uVar1 = Component.GetComponent(lVar4,DAT_181e777b8);
            uVar1 = DOTweenModuleUI.DOFade(uVar1,0,0x3dcccccd,0);
            TweenSettingsExtensions.SetUpdate(uVar1,1,DAT_181ea5848);
            uVar1 = this.targetGrid;
            GlobalData.DeleteAllChild(uVar1,0);
            iVar6 = this.chooseType;
            if (iVar6 == 0) {
              lVar4 = this.itemList;
              iVar6 = 0;
              if (lVar4 != null) {
                while ((lVar4 = GameObject.get_transform(lVar4,0), lVar4 != null &&
                       (lVar4 = Transform.Find(lVar4,"SkillFlitter",0)) != null)) {
                  iVar2 = Transform.get_childCount(lVar4,0);
                  if (iVar2 <= iVar6) {
                    return;
                  }
                  iVar2 = 0;
                  while( true ) {
                    if ((((this.itemList == null) ||
                         (lVar4 = GameObject.get_transform(this.itemList,0)) == null)
                        || (lVar4 = Transform.Find(lVar4,"SkillFlitter",0)) == null) ||
                       (lVar4 = Transform.GetChild(lVar4)) == null) throw; // [null/range check failed]
                    iVar3 = Transform.get_childCount(lVar4);
                    lVar4 = this.itemList;
                    if (iVar3 <= iVar2) break;
                    if ((((lVar4 == null) || (lVar4 = GameObject.get_transform(lVar4,0)) == null) ||
                        ((lVar4 = Transform.Find(lVar4,"SkillFlitter",0), lVar4 == null ||
                         ((lVar4 = Transform.GetChild(lVar4,iVar6), lVar4 == null ||
                          (lVar4 = Transform.GetChild(lVar4,iVar2)) == null))))) ||
                       (lVar4 = Component.GetComponent(lVar4,DAT_181e796b8)) == null)
                    throw; // [null/range check failed]
                    Toggle.set_isOn(lVar4);
                    iVar2 = iVar2 + 1;
                  }
                  iVar6 = iVar6 + 1;
                  if (lVar4 == null) break;
                }
              }
            }
            else if (iVar6 == 1) {
              lVar4 = this.itemList;
              iVar6 = 0;
              if (lVar4 != null) {
                while ((lVar4 = GameObject.get_transform(lVar4,0), lVar4 != null &&
                       (lVar4 = Transform.Find(lVar4,"ItemFlitter",0)) != null)) {
                  iVar2 = Transform.get_childCount(lVar4,0);
                  if (iVar2 <= iVar6) {
                    return;
                  }
                  iVar2 = 0;
                  while( true ) {
                    if ((((this.itemList == null) ||
                         (lVar4 = GameObject.get_transform(this.itemList,0)) == null)
                        || (lVar4 = Transform.Find(lVar4,"ItemFlitter",0)) == null) ||
                       (lVar4 = Transform.GetChild(lVar4)) == null) throw; // [null/range check failed]
                    iVar3 = Transform.get_childCount(lVar4);
                    lVar4 = this.itemList;
                    if (iVar3 <= iVar2) break;
                    if ((((lVar4 == null) || (lVar4 = GameObject.get_transform(lVar4,0)) == null) ||
                        ((lVar4 = Transform.Find(lVar4,"ItemFlitter",0), lVar4 == null ||
                         ((lVar4 = Transform.GetChild(lVar4,iVar6), lVar4 == null ||
                          (lVar4 = Transform.GetChild(lVar4,iVar2)) == null))))) ||
                       (lVar4 = Component.GetComponent(lVar4,DAT_181e796b8)) == null)
                    throw; // [null/range check failed]
                    Toggle.set_isOn(lVar4);
                    iVar2 = iVar2 + 1;
                  }
                  iVar6 = iVar6 + 1;
                  if (lVar4 == null) break;
                }
              }
            }
            else {
              if (iVar6 != 2) {
                return;
              }
              lVar4 = this.heroList;
              iVar6 = 0;
              if (lVar4 != null) {
                while ((lVar4 = GameObject.get_transform(lVar4,0), lVar4 != null &&
                       (lVar4 = Transform.Find(lVar4,"HeroFlitter",0)) != null)) {
                  iVar2 = Transform.get_childCount(lVar4,0);
                  if (iVar2 <= iVar6) {
                    return;
                  }
                  iVar2 = 0;
                  while( true ) {
                    if ((((this.heroList == null) ||
                         (lVar4 = GameObject.get_transform(this.heroList,0)) == null)
                        || (lVar4 = Transform.Find(lVar4,"HeroFlitter",0)) == null) ||
                       (lVar4 = Transform.GetChild(lVar4)) == null) throw; // [null/range check failed]
                    iVar3 = Transform.get_childCount(lVar4);
                    lVar4 = this.heroList;
                    if (iVar3 <= iVar2) break;
                    if ((((lVar4 == null) || (lVar4 = GameObject.get_transform(lVar4,0)) == null) ||
                        ((lVar4 = Transform.Find(lVar4,"HeroFlitter",0), lVar4 == null ||
                         ((lVar4 = Transform.GetChild(lVar4,iVar6), lVar4 == null ||
                          (lVar4 = Transform.GetChild(lVar4,iVar2)) == null))))) ||
                       (lVar4 = Component.GetComponent(lVar4,DAT_181e796b8)) == null)
                    throw; // [null/range check failed]
                    Toggle.set_isOn(lVar4);
                    iVar2 = iVar2 + 1;
                  }
                  iVar6 = iVar6 + 1;
                  if (lVar4 == null) break;
                }
              }
            }
          }
        }
    }

    // Token : 0x6000E92
    // RVA   : 0x6FC960   Offset: 0x6FB760   Length: 0x7A3
    public void TypeFlitterAllChanged(bool allOn)
    {
        int iVar1;
        long lVar3;
        plVar2 = (int64 *)Resources.Load("Sound/SoundEffect/Armor",0);
        plVar5 = (int64 *)0;
        plVar4 = plVar5;
        if ((plVar2 != (int64 *)0) && (plVar4 = (int64 *)0, *plVar2 == DAT_181e8f4a0)) {
          plVar4 = plVar2;
        }
        NGUITools.PlaySound(plVar4,0);
        iVar1 = this.chooseType;
        if (iVar1 == 2) {
          lVar3 = this.heroList;
          if (lVar3 != null) {
            while (((lVar3 = GameObject.get_transform(lVar3,0), lVar3 != null &&
                    (lVar3 = Transform.Find(lVar3,"HeroFlitter",0)) != null) &&
                   (lVar3 = Transform.Find(lVar3,"HeroTypeFlitter",0)) != null)) {
              iVar1 = Transform.get_childCount(lVar3,0);
              if (iVar1 <= (int)plVar5) {
                return;
              }
              if ((((this.heroList == null) ||
                   (lVar3 = GameObject.get_transform(this.heroList,0)) == null) ||
                  ((lVar3 = Transform.Find(lVar3,"HeroFlitter",0), lVar3 == null ||
                   ((lVar3 = Transform.Find(lVar3,"HeroTypeFlitter",0), lVar3 == null ||
                    (lVar3 = Transform.GetChild(lVar3,plVar5)) == null))))) ||
                 (lVar3 = Component.GetComponent(lVar3)) == null) break;
              if (*(char *)(lVar3 + 208) != false) {
                if (((((this.heroList == null) ||
                      (lVar3 = GameObject.get_transform(this.heroList,0)) == null) ||
                     (lVar3 = Transform.Find(lVar3,"HeroFlitter",0)) == null) ||
                    ((lVar3 = Transform.Find(lVar3,"HeroTypeFlitter",0), lVar3 == null ||
                     (lVar3 = Transform.GetChild(lVar3,plVar5)) == null))) ||
                   (lVar3 = Component.GetComponent(lVar3)) == null) break;
                if (*(char *)(lVar3 + 0x118) != allOn) {
                  if (((this.heroList == null) ||
                      (lVar3 = GameObject.get_transform(this.heroList,0)) == null) ||
                     ((lVar3 = Transform.Find(lVar3,"HeroFlitter",0), lVar3 == null ||
                      (((lVar3 = Transform.Find(lVar3,"HeroTypeFlitter",0), lVar3 == null ||
                        (lVar3 = Transform.GetChild(lVar3,plVar5)) == null) ||
                       (lVar3 = Component.GetComponent(lVar3,DAT_181e796b8)) == null))))) break;
                  Toggle.set_isOn(lVar3);
                }
              }
              lVar3 = this.heroList;
              plVar5 = (int64 *)(uint64)((int)plVar5 + 1);
              if (lVar3 == null) break;
            }
          }
        }
        else if (iVar1 == 0) {
          lVar3 = this.itemList;
          if (lVar3 != null) {
            while (((lVar3 = GameObject.get_transform(lVar3,0), lVar3 != null &&
                    (lVar3 = Transform.Find(lVar3,"SkillFlitter",0)) != null) &&
                   (lVar3 = Transform.Find(lVar3,"SkillTypeFlitter",0)) != null)) {
              iVar1 = Transform.get_childCount(lVar3,0);
              if (iVar1 <= (int)plVar5) {
                return;
              }
              if (((this.itemList == null) ||
                  (lVar3 = GameObject.get_transform(this.itemList,0)) == null) ||
                 ((lVar3 = Transform.Find(lVar3,"SkillFlitter",0), lVar3 == null ||
                  (((lVar3 = Transform.Find(lVar3,"SkillTypeFlitter",0), lVar3 == null ||
                    (lVar3 = Transform.GetChild(lVar3,plVar5)) == null) ||
                   (lVar3 = Component.GetComponent(lVar3)) == null))))) break;
              if (*(char *)(lVar3 + 208) != false) {
                if (((this.itemList == null) ||
                    (lVar3 = GameObject.get_transform(this.itemList,0)) == null) ||
                   (((lVar3 = Transform.Find(lVar3,"SkillFlitter",0), lVar3 == null ||
                     ((lVar3 = Transform.Find(lVar3,"SkillTypeFlitter",0), lVar3 == null ||
                      (lVar3 = Transform.GetChild(lVar3,plVar5)) == null))) ||
                    (lVar3 = Component.GetComponent(lVar3)) == null))) break;
                if (*(char *)(lVar3 + 0x118) != allOn) {
                  if (((((this.itemList == null) ||
                        (lVar3 = GameObject.get_transform(this.itemList,0)) == null)
                       || (lVar3 = Transform.Find(lVar3,"SkillFlitter",0)) == null) ||
                      ((lVar3 = Transform.Find(lVar3,"SkillTypeFlitter",0), lVar3 == null ||
                       (lVar3 = Transform.GetChild(lVar3,plVar5)) == null))) ||
                     (lVar3 = Component.GetComponent(lVar3,DAT_181e796b8)) == null) break;
                  Toggle.set_isOn(lVar3);
                }
              }
              lVar3 = this.itemList;
              plVar5 = (int64 *)(uint64)((int)plVar5 + 1);
              if (lVar3 == null) break;
            }
          }
        }
        else {
          if (iVar1 != 1) {
            return;
          }
          lVar3 = this.itemList;
          if (lVar3 != null) {
            while (((lVar3 = GameObject.get_transform(lVar3,0), lVar3 != null &&
                    (lVar3 = Transform.Find(lVar3,"ItemFlitter",0)) != null) &&
                   (lVar3 = Transform.Find(lVar3,"ItemTypeFlitter",0)) != null)) {
              iVar1 = Transform.get_childCount(lVar3,0);
              if (iVar1 <= (int)plVar5) {
                return;
              }
              if (((((this.itemList == null) ||
                    (lVar3 = GameObject.get_transform(this.itemList,0)) == null) ||
                   (lVar3 = Transform.Find(lVar3,"ItemFlitter",0)) == null) ||
                  ((lVar3 = Transform.Find(lVar3,"ItemTypeFlitter",0), lVar3 == null ||
                   (lVar3 = Transform.GetChild(lVar3,plVar5)) == null))) ||
                 (lVar3 = Component.GetComponent(lVar3)) == null) break;
              if (*(char *)(lVar3 + 208) != false) {
                if (((this.itemList == null) ||
                    (lVar3 = GameObject.get_transform(this.itemList,0)) == null) ||
                   ((lVar3 = Transform.Find(lVar3,"ItemFlitter",0), lVar3 == null ||
                    (((lVar3 = Transform.Find(lVar3,"ItemTypeFlitter",0), lVar3 == null ||
                      (lVar3 = Transform.GetChild(lVar3,plVar5)) == null) ||
                     (lVar3 = Component.GetComponent(lVar3)) == null))))) break;
                if (*(char *)(lVar3 + 0x118) != allOn) {
                  if ((((this.itemList == null) ||
                       (lVar3 = GameObject.get_transform(this.itemList,0)) == null)
                      || ((lVar3 = Transform.Find(lVar3,"ItemFlitter",0), lVar3 == null ||
                          ((lVar3 = Transform.Find(lVar3,"ItemTypeFlitter",0), lVar3 == null ||
                           (lVar3 = Transform.GetChild(lVar3,plVar5)) == null))))) ||
                     (lVar3 = Component.GetComponent(lVar3,DAT_181e796b8)) == null) break;
                  Toggle.set_isOn(lVar3);
                }
              }
              lVar3 = this.itemList;
              plVar5 = (int64 *)(uint64)((int)plVar5 + 1);
              if (lVar3 == null) break;
            }
          }
        }
    }

    // Token : 0x6000E93
    // RVA   : 0x6F6080   Offset: 0x6F4E80   Length: 0x7A3
    public void LvFlitterAllChanged(bool allOn)
    {
        int iVar1;
        long lVar3;
        plVar2 = (int64 *)Resources.Load("Sound/SoundEffect/Armor",0);
        plVar5 = (int64 *)0;
        plVar4 = plVar5;
        if ((plVar2 != (int64 *)0) && (plVar4 = (int64 *)0, *plVar2 == DAT_181e8f4a0)) {
          plVar4 = plVar2;
        }
        NGUITools.PlaySound(plVar4,0);
        iVar1 = this.chooseType;
        if (iVar1 == 2) {
          lVar3 = this.heroList;
          if (lVar3 != null) {
            while (((lVar3 = GameObject.get_transform(lVar3,0), lVar3 != null &&
                    (lVar3 = Transform.Find(lVar3,"HeroFlitter",0)) != null) &&
                   (lVar3 = Transform.Find(lVar3,"HeroLvFlitter",0)) != null)) {
              iVar1 = Transform.get_childCount(lVar3,0);
              if (iVar1 <= (int)plVar5) {
                return;
              }
              if ((((this.heroList == null) ||
                   (lVar3 = GameObject.get_transform(this.heroList,0)) == null) ||
                  ((lVar3 = Transform.Find(lVar3,"HeroFlitter",0), lVar3 == null ||
                   ((lVar3 = Transform.Find(lVar3,"HeroLvFlitter",0), lVar3 == null ||
                    (lVar3 = Transform.GetChild(lVar3,plVar5)) == null))))) ||
                 (lVar3 = Component.GetComponent(lVar3)) == null) break;
              if (*(char *)(lVar3 + 208) != false) {
                if (((((this.heroList == null) ||
                      (lVar3 = GameObject.get_transform(this.heroList,0)) == null) ||
                     (lVar3 = Transform.Find(lVar3,"HeroFlitter",0)) == null) ||
                    ((lVar3 = Transform.Find(lVar3,"HeroLvFlitter",0), lVar3 == null ||
                     (lVar3 = Transform.GetChild(lVar3,plVar5)) == null))) ||
                   (lVar3 = Component.GetComponent(lVar3)) == null) break;
                if (*(char *)(lVar3 + 0x118) != allOn) {
                  if (((this.heroList == null) ||
                      (lVar3 = GameObject.get_transform(this.heroList,0)) == null) ||
                     ((lVar3 = Transform.Find(lVar3,"HeroFlitter",0), lVar3 == null ||
                      (((lVar3 = Transform.Find(lVar3,"HeroLvFlitter",0), lVar3 == null ||
                        (lVar3 = Transform.GetChild(lVar3,plVar5)) == null) ||
                       (lVar3 = Component.GetComponent(lVar3,DAT_181e796b8)) == null))))) break;
                  Toggle.set_isOn(lVar3);
                }
              }
              lVar3 = this.heroList;
              plVar5 = (int64 *)(uint64)((int)plVar5 + 1);
              if (lVar3 == null) break;
            }
          }
        }
        else if (iVar1 == 0) {
          lVar3 = this.itemList;
          if (lVar3 != null) {
            while (((lVar3 = GameObject.get_transform(lVar3,0), lVar3 != null &&
                    (lVar3 = Transform.Find(lVar3,"SkillFlitter",0)) != null) &&
                   (lVar3 = Transform.Find(lVar3,"SkillLvFlitter",0)) != null)) {
              iVar1 = Transform.get_childCount(lVar3,0);
              if (iVar1 <= (int)plVar5) {
                return;
              }
              if (((this.itemList == null) ||
                  (lVar3 = GameObject.get_transform(this.itemList,0)) == null) ||
                 ((lVar3 = Transform.Find(lVar3,"SkillFlitter",0), lVar3 == null ||
                  (((lVar3 = Transform.Find(lVar3,"SkillLvFlitter",0), lVar3 == null ||
                    (lVar3 = Transform.GetChild(lVar3,plVar5)) == null) ||
                   (lVar3 = Component.GetComponent(lVar3)) == null))))) break;
              if (*(char *)(lVar3 + 208) != false) {
                if (((this.itemList == null) ||
                    (lVar3 = GameObject.get_transform(this.itemList,0)) == null) ||
                   (((lVar3 = Transform.Find(lVar3,"SkillFlitter",0), lVar3 == null ||
                     ((lVar3 = Transform.Find(lVar3,"SkillLvFlitter",0), lVar3 == null ||
                      (lVar3 = Transform.GetChild(lVar3,plVar5)) == null))) ||
                    (lVar3 = Component.GetComponent(lVar3)) == null))) break;
                if (*(char *)(lVar3 + 0x118) != allOn) {
                  if (((((this.itemList == null) ||
                        (lVar3 = GameObject.get_transform(this.itemList,0)) == null)
                       || (lVar3 = Transform.Find(lVar3,"SkillFlitter",0)) == null) ||
                      ((lVar3 = Transform.Find(lVar3,"SkillLvFlitter",0), lVar3 == null ||
                       (lVar3 = Transform.GetChild(lVar3,plVar5)) == null))) ||
                     (lVar3 = Component.GetComponent(lVar3,DAT_181e796b8)) == null) break;
                  Toggle.set_isOn(lVar3);
                }
              }
              lVar3 = this.itemList;
              plVar5 = (int64 *)(uint64)((int)plVar5 + 1);
              if (lVar3 == null) break;
            }
          }
        }
        else {
          if (iVar1 != 1) {
            return;
          }
          lVar3 = this.itemList;
          if (lVar3 != null) {
            while (((lVar3 = GameObject.get_transform(lVar3,0), lVar3 != null &&
                    (lVar3 = Transform.Find(lVar3,"ItemFlitter",0)) != null) &&
                   (lVar3 = Transform.Find(lVar3,"ItemLvFlitter",0)) != null)) {
              iVar1 = Transform.get_childCount(lVar3,0);
              if (iVar1 <= (int)plVar5) {
                return;
              }
              if (((((this.itemList == null) ||
                    (lVar3 = GameObject.get_transform(this.itemList,0)) == null) ||
                   (lVar3 = Transform.Find(lVar3,"ItemFlitter",0)) == null) ||
                  ((lVar3 = Transform.Find(lVar3,"ItemLvFlitter",0), lVar3 == null ||
                   (lVar3 = Transform.GetChild(lVar3,plVar5)) == null))) ||
                 (lVar3 = Component.GetComponent(lVar3)) == null) break;
              if (*(char *)(lVar3 + 208) != false) {
                if (((this.itemList == null) ||
                    (lVar3 = GameObject.get_transform(this.itemList,0)) == null) ||
                   ((lVar3 = Transform.Find(lVar3,"ItemFlitter",0), lVar3 == null ||
                    (((lVar3 = Transform.Find(lVar3,"ItemLvFlitter",0), lVar3 == null ||
                      (lVar3 = Transform.GetChild(lVar3,plVar5)) == null) ||
                     (lVar3 = Component.GetComponent(lVar3)) == null))))) break;
                if (*(char *)(lVar3 + 0x118) != allOn) {
                  if ((((this.itemList == null) ||
                       (lVar3 = GameObject.get_transform(this.itemList,0)) == null)
                      || ((lVar3 = Transform.Find(lVar3,"ItemFlitter",0), lVar3 == null ||
                          ((lVar3 = Transform.Find(lVar3,"ItemLvFlitter",0), lVar3 == null ||
                           (lVar3 = Transform.GetChild(lVar3,plVar5)) == null))))) ||
                     (lVar3 = Component.GetComponent(lVar3,DAT_181e796b8)) == null) break;
                  Toggle.set_isOn(lVar3);
                }
              }
              lVar3 = this.itemList;
              plVar5 = (int64 *)(uint64)((int)plVar5 + 1);
              if (lVar3 == null) break;
            }
          }
        }
    }

    // Token : 0x6000E94
    // RVA   : 0x6FD110   Offset: 0x6FBF10   Length: 0xA30
    public void TypeFlitterChanged(GameObject flitter)
    {
        int iVar3;
        int iVar4;
        long lVar6;
        ulong uVar7;
        long lVar8;
        plVar5 = (int64 *)Resources.Load("Sound/SoundEffect/Button/TabButton",0);
        plVar10 = (int64 *)0;
        plVar9 = plVar10;
        if ((plVar5 != (int64 *)0) && (plVar9 = (int64 *)0, *plVar5 == DAT_181e8f4a0)) {
          plVar9 = plVar5;
        }
        NGUITools.PlaySound(plVar9,0);
        if ((flitter != null) && (lVar6 = GameObject.GetComponent(flitter,DAT_181e57478)) != null) {
          bVar1 = *(byte *)(lVar6 + 0x118);
          uVar7 = Object.get_name(flitter,0);
          iVar3 = Int32.Parse(uVar7,0);
          if (this.chooseType != 2) {
            lVar6 = this.itemList;
            do {
              if ((((lVar6 == null) || (lVar6 = GameObject.get_transform(lVar6,0)) == null) ||
                  (lVar6 = Transform.Find(lVar6,"Viewport",0)) == null) ||
                 (lVar6 = Transform.Find(lVar6,"Content",0)) == null) throw; // [null/range check failed]
              iVar4 = Transform.get_childCount(lVar6);
              if (iVar4 <= (int)plVar10) {
                return;
              }
              if (this.chooseType == null) {
                if (((this.itemList == null) ||
                    (lVar6 = GameObject.get_transform(this.itemList,0)) == null) ||
                   (lVar6 = Transform.Find(lVar6,"SkillFlitter",0)) == null) throw; // [null/range check failed]
                lVar6 = Transform.Find(lVar6,"SkillLvFlitter",0);
                if (((this.itemList == null) ||
                    (lVar8 = GameObject.get_transform(this.itemList,0)) == null) ||
                   ((lVar8 = Transform.Find(lVar8,"Viewport",0), lVar8 == null ||
                    ((((((lVar8 = Transform.Find(lVar8,"Content",0), lVar8 == null ||
                         (lVar8 = Transform.GetChild(lVar8,plVar10)) == null) ||
                        (lVar8 = Component.GetComponent(lVar8,DAT_181e78e38)) == null) ||
                       ((*(int64 *)(lVar8 + 32) == 0 ||
                        (lVar8 = KungfuSkillLvData.DataBase(*(int64 *)(lVar8 + 32),0)) == null))
                       ) || (uVar7 = Int32.ToString(lVar8 + 52,0), lVar6 == null)) ||
                     ((lVar6 = Transform.Find(lVar6,uVar7,0), lVar6 == null ||
                      (lVar6 = Component.GetComponent(lVar6,DAT_181e796b8)) == null)))))))
                throw; // [null/range check failed]
                bVar11 = *(byte *)(lVar6 + 0x118);
                if ((((this.itemList == null) ||
                     (((lVar6 = GameObject.get_transform(this.itemList,0), lVar6 == null ||
                       (lVar6 = Transform.Find(lVar6,"Viewport",0)) == null) ||
                      (lVar6 = Transform.Find(lVar6,"Content",0)) == null))) ||
                    ((lVar6 = Transform.GetChild(lVar6,plVar10), lVar6 == null ||
                     (lVar6 = Component.GetComponent(lVar6)) == null))) ||
                   (*(int64 *)(lVar6 + 32) == 0)) throw; // [null/range check failed]
                iVar4 = KungfuSkillLvData.Type();
        LAB_1806fd69c:
                if (iVar4 == iVar3) {
                  if (((this.itemList == null) ||
                      (lVar6 = GameObject.get_transform(this.itemList,0)) == null) ||
                     ((lVar6 = Transform.Find(lVar6,"Viewport",0), lVar6 == null ||
                      (((lVar6 = Transform.Find(lVar6,"Content",0), lVar6 == null ||
                        (lVar6 = Transform.GetChild(lVar6)) == null) ||
                       (lVar6 = Component.get_gameObject(lVar6)) == null))))) throw; // [null/range check failed]
                  bVar2 = GameObject.get_activeSelf(lVar6);
                  if (bVar2 != (bVar11 & bVar1)) {
                    if ((((this.itemList == null) ||
                         (lVar6 = GameObject.get_transform(this.itemList,0)) == null)
                        || ((lVar6 = Transform.Find(lVar6,"Viewport",0), lVar6 == null ||
                            ((lVar6 = Transform.Find(lVar6,"Content",0), lVar6 == null ||
                             (lVar6 = Transform.GetChild(lVar6,plVar10)) == null))))) ||
                       (lVar6 = Component.get_gameObject(lVar6,0)) == null) throw; // [null/range check failed]
                    GameObject.SetActive(lVar6);
                  }
                }
              }
              else if (this.chooseType == 1) {
                if (((this.itemList != null) &&
                    (lVar6 = GameObject.get_transform(this.itemList,0)) != null) &&
                   (lVar6 = Transform.Find(lVar6,"ItemFlitter",0)) != null) {
                  lVar6 = Transform.Find(lVar6,"ItemLvFlitter",0);
                  if (((((this.itemList != null) &&
                        (lVar8 = GameObject.get_transform(this.itemList,0)) != null)
                       && (lVar8 = Transform.Find(lVar8,"Viewport",0)) != null) &&
                      (((lVar8 = Transform.Find(lVar8,"Content",0), lVar8 != null &&
                        (lVar8 = Transform.GetChild(lVar8,plVar10)) != null) &&
                       (((lVar8 = Component.GetComponent(lVar8,DAT_181e77938), lVar8 != null &&
                         ((*(int64 *)(lVar8 + 32) != 0 &&
                          (uVar7 = Int32.ToString(*(int64 *)(lVar8 + 32) + 60,0), lVar6 != null))))
                        && (lVar6 = Transform.Find(lVar6,uVar7,0)) != null))))) &&
                     (lVar6 = Component.GetComponent(lVar6,DAT_181e796b8)) != null) {
                    bVar11 = *(byte *)(lVar6 + 0x118);
                    if (((((this.itemList != null) &&
                          (lVar6 = GameObject.get_transform(this.itemList,0)) != null
                          ) && (lVar6 = Transform.Find(lVar6,"Viewport",0)) != null) &&
                        ((lVar6 = Transform.Find(lVar6,"Content",0), lVar6 != null &&
                         (lVar6 = Transform.GetChild(lVar6,plVar10)) != null))) &&
                       ((lVar6 = Component.GetComponent(lVar6), lVar6 != null &&
                        (*(int64 *)(lVar6 + 32) != 0)))) {
                      iVar4 = *(int *)(*(int64 *)(lVar6 + 32) + 20);
                      goto LAB_1806fd69c;
                    }
                  }
                }
                throw; // [null/range check failed]
              }
              lVar6 = this.itemList;
              plVar10 = (int64 *)(uint64)((int)plVar10 + 1);
            } while( true );
          }
          lVar6 = this.heroList;
          if (lVar6 != null) {
            while (((lVar6 = GameObject.get_transform(lVar6,0), lVar6 != null &&
                    (lVar6 = Transform.Find(lVar6,"Viewport",0)) != null) &&
                   (lVar6 = Transform.Find(lVar6,"Content",0)) != null)) {
              iVar4 = Transform.get_childCount(lVar6,0);
              if (iVar4 <= (int)plVar10) {
                return;
              }
              if (((this.heroList == null) ||
                  (lVar6 = GameObject.get_transform(this.heroList,0)) == null) ||
                 (lVar6 = Transform.Find(lVar6,"HeroFlitter",0)) == null) break;
              lVar6 = Transform.Find(lVar6,"HeroLvFlitter",0);
              if ((((this.heroList == null) ||
                   (lVar8 = GameObject.get_transform(this.heroList,0)) == null) ||
                  ((lVar8 = Transform.Find(lVar8,"Viewport",0), lVar8 == null ||
                   ((((lVar8 = Transform.Find(lVar8,"Content",0), lVar8 == null ||
                      (lVar8 = Transform.GetChild(lVar8,plVar10)) == null) ||
                     (lVar8 = Component.GetComponent(lVar8,DAT_181e77438)) == null) ||
                    ((*(int64 *)(lVar8 + 32) == 0 ||
                     (uVar7 = Int32.ToString(*(int64 *)(lVar8 + 32) + 184,0), lVar6 == null)))))))) ||
                 ((lVar6 = Transform.Find(lVar6,uVar7,0), lVar6 == null ||
                  (lVar6 = Component.GetComponent(lVar6,DAT_181e796b8)) == null))) break;
              bVar11 = *(byte *)(lVar6 + 0x118);
              if (((this.heroList == null) ||
                  (lVar6 = GameObject.get_transform(this.heroList,0)) == null) ||
                 (((lVar6 = Transform.Find(lVar6,"Viewport",0), lVar6 == null ||
                   (((lVar6 = Transform.Find(lVar6,"Content",0), lVar6 == null ||
                     (lVar6 = Transform.GetChild(lVar6,plVar10)) == null) ||
                    (lVar6 = Component.GetComponent(lVar6)) == null))) ||
                  (*(int64 *)(lVar6 + 32) == 0)))) break;
              if ((bool)*(char *)(*(int64 *)(lVar6 + 32) + 92) == (iVar3 == 0)) {
                if ((((this.heroList == null) ||
                     (lVar6 = GameObject.get_transform(this.heroList,0)) == null) ||
                    ((lVar6 = Transform.Find(lVar6,"Viewport",0), lVar6 == null ||
                     ((lVar6 = Transform.Find(lVar6,"Content",0), lVar6 == null ||
                      (lVar6 = Transform.GetChild(lVar6)) == null))))) ||
                   (lVar6 = Component.get_gameObject(lVar6)) == null) break;
                bVar2 = GameObject.get_activeSelf(lVar6);
                if (bVar2 != (bVar11 & bVar1)) {
                  if (((((this.heroList == null) ||
                        (lVar6 = GameObject.get_transform(this.heroList,0)) == null)
                       || (lVar6 = Transform.Find(lVar6,"Viewport",0)) == null) ||
                      ((lVar6 = Transform.Find(lVar6,"Content",0), lVar6 == null ||
                       (lVar6 = Transform.GetChild(lVar6,plVar10)) == null))) ||
                     (lVar6 = Component.get_gameObject(lVar6,0)) == null) break;
                  GameObject.SetActive(lVar6);
                }
              }
              lVar6 = this.heroList;
              plVar10 = (int64 *)(uint64)((int)plVar10 + 1);
              if (lVar6 == null) break;
            }
          }
        }
    }

    // Token : 0x6000E95
    // RVA   : 0x6F6830   Offset: 0x6F5630   Length: 0xA51
    public void LvFlitterChanged(GameObject flitter)
    {
        int iVar3;
        int iVar4;
        long lVar6;
        ulong uVar7;
        long lVar8;
        uint[] local_res10 = new uint[2];
        plVar11 = (int64 *)0;
        local_res10[0] = 0;
        plVar5 = (int64 *)Resources.Load("Sound/SoundEffect/Button/TabButton",0);
        plVar9 = plVar11;
        if ((plVar5 != (int64 *)0) && (*plVar5 == DAT_181e8f4a0)) {
          plVar9 = plVar5;
        }
        NGUITools.PlaySound(plVar9,0);
        if ((flitter != null) && (lVar6 = GameObject.GetComponent(flitter,DAT_181e57478)) != null) {
          bVar1 = *(byte *)(lVar6 + 0x118);
          uVar7 = Object.get_name(flitter,0);
          iVar3 = Int32.Parse(uVar7,0);
          if (this.chooseType != 2) {
            lVar6 = this.itemList;
            do {
              if ((((lVar6 == null) || (lVar6 = GameObject.get_transform(lVar6,0)) == null) ||
                  (lVar6 = Transform.Find(lVar6,"Viewport",0)) == null) ||
                 (lVar6 = Transform.Find(lVar6,"Content",0)) == null) throw; // [null/range check failed]
              iVar4 = Transform.get_childCount(lVar6);
              if (iVar4 <= (int)plVar11) {
                return;
              }
              if (this.chooseType == null) {
                if (((this.itemList == null) ||
                    (lVar6 = GameObject.get_transform(this.itemList,0)) == null) ||
                   (lVar6 = Transform.Find(lVar6,"SkillFlitter",0)) == null) throw; // [null/range check failed]
                lVar6 = Transform.Find(lVar6,"SkillTypeFlitter",0);
                if (((this.itemList == null) ||
                    (lVar8 = GameObject.get_transform(this.itemList,0)) == null) ||
                   ((lVar8 = Transform.Find(lVar8,"Viewport",0), lVar8 == null ||
                    ((((lVar8 = Transform.Find(lVar8,"Content",0), lVar8 == null ||
                       (lVar8 = Transform.GetChild(lVar8,plVar11)) == null) ||
                      (lVar8 = Component.GetComponent(lVar8,DAT_181e78e38)) == null) ||
                     (*(int64 *)(lVar8 + 32) == 0)))))) throw; // [null/range check failed]
                local_res10[0] = KungfuSkillLvData.Type(*(int64 *)(lVar8 + 32),0);
                uVar7 = Int32.ToString(local_res10,0);
                if (((lVar6 == null) || (lVar6 = Transform.Find(lVar6,uVar7,0)) == null) ||
                   (lVar6 = Component.GetComponent(lVar6,DAT_181e796b8)) == null) throw; // [null/range check failed]
                bVar10 = *(byte *)(lVar6 + 0x118);
                if ((((this.itemList == null) ||
                     (lVar6 = GameObject.get_transform(this.itemList,0)) == null) ||
                    ((lVar6 = Transform.Find(lVar6,"Viewport",0), lVar6 == null ||
                     (((lVar6 = Transform.Find(lVar6,"Content",0), lVar6 == null ||
                       (lVar6 = Transform.GetChild(lVar6,plVar11)) == null) ||
                      (lVar6 = Component.GetComponent(lVar6)) == null))))) ||
                   ((*(int64 *)(lVar6 + 32) == 0 ||
                    (lVar6 = KungfuSkillLvData.DataBase()) == null))) throw; // [null/range check failed]
                iVar4 = *(int *)(lVar6 + 52);
        LAB_1806f6de1:
                if (iVar4 == iVar3) {
                  if (((this.itemList == null) ||
                      (lVar6 = GameObject.get_transform(this.itemList,0)) == null) ||
                     ((lVar6 = Transform.Find(lVar6,"Viewport",0), lVar6 == null ||
                      (((lVar6 = Transform.Find(lVar6,"Content",0), lVar6 == null ||
                        (lVar6 = Transform.GetChild(lVar6)) == null) ||
                       (lVar6 = Component.get_gameObject(lVar6)) == null))))) throw; // [null/range check failed]
                  bVar2 = GameObject.get_activeSelf(lVar6);
                  if (bVar2 != (bVar10 & bVar1)) {
                    if (((this.itemList == null) ||
                        (lVar6 = GameObject.get_transform(this.itemList,0)) == null)
                       || (((lVar6 = Transform.Find(lVar6,"Viewport",0), lVar6 == null ||
                            ((lVar6 = Transform.Find(lVar6,"Content",0), lVar6 == null ||
                             (lVar6 = Transform.GetChild(lVar6,plVar11)) == null))) ||
                           (lVar6 = Component.get_gameObject(lVar6,0)) == null))) throw; // [null/range check failed]
                    GameObject.SetActive(lVar6);
                  }
                }
              }
              else if (this.chooseType == 1) {
                if (((this.itemList != null) &&
                    (lVar6 = GameObject.get_transform(this.itemList,0)) != null) &&
                   (lVar6 = Transform.Find(lVar6,"ItemFlitter",0)) != null) {
                  lVar6 = Transform.Find(lVar6,"ItemTypeFlitter",0);
                  if ((((this.itemList != null) &&
                       (lVar8 = GameObject.get_transform(this.itemList,0)) != null)
                      && (lVar8 = Transform.Find(lVar8,"Viewport",0)) != null) &&
                     (((lVar8 = Transform.Find(lVar8,"Content",0), lVar8 != null &&
                       (lVar8 = Transform.GetChild(lVar8,plVar11)) != null) &&
                      ((lVar8 = Component.GetComponent(lVar8,DAT_181e77938), lVar8 != null &&
                       (*(int64 *)(lVar8 + 32) != 0)))))) {
                    local_res10[0] = *(uint32 *)(*(int64 *)(lVar8 + 32) + 20);
                    uVar7 = Int32.ToString(local_res10,0);
                    if (((lVar6 != null) && (lVar6 = Transform.Find(lVar6,uVar7,0)) != null) &&
                       (lVar6 = Component.GetComponent(lVar6,DAT_181e796b8)) != null) {
                      bVar10 = *(byte *)(lVar6 + 0x118);
                      if ((((((this.itemList != null) &&
                             (lVar6 = GameObject.get_transform(this.itemList,0),
                             lVar6 != null)) && (lVar6 = Transform.Find(lVar6,"Viewport",0)) != null)
                           && ((lVar6 = Transform.Find(lVar6,"Content",0), lVar6 != null &&
                               (lVar6 = Transform.GetChild(lVar6,plVar11)) != null))) &&
                          (lVar6 = Component.GetComponent(lVar6)) != null) &&
                         (*(int64 *)(lVar6 + 32) != 0)) {
                        iVar4 = *(int *)(*(int64 *)(lVar6 + 32) + 60);
                        goto LAB_1806f6de1;
                      }
                    }
                  }
                }
                throw; // [null/range check failed]
              }
              lVar6 = this.itemList;
              plVar11 = (int64 *)(uint64)((int)plVar11 + 1);
            } while( true );
          }
          lVar6 = this.heroList;
          if (lVar6 != null) {
            while (((lVar6 = GameObject.get_transform(lVar6,0), lVar6 != null &&
                    (lVar6 = Transform.Find(lVar6,"Viewport",0)) != null) &&
                   (lVar6 = Transform.Find(lVar6,"Content",0)) != null)) {
              iVar4 = Transform.get_childCount(lVar6,0);
              if (iVar4 <= (int)plVar11) {
                return;
              }
              if (((this.heroList == null) ||
                  (lVar6 = GameObject.get_transform(this.heroList,0)) == null) ||
                 (lVar6 = Transform.Find(lVar6,"HeroFlitter",0)) == null) break;
              lVar6 = Transform.Find(lVar6,"HeroTypeFlitter",0);
              if (((this.heroList == null) ||
                  (lVar8 = GameObject.get_transform(this.heroList,0)) == null) ||
                 ((lVar8 = Transform.Find(lVar8,"Viewport",0), lVar8 == null ||
                  ((((lVar8 = Transform.Find(lVar8,"Content",0), lVar8 == null ||
                     (lVar8 = Transform.GetChild(lVar8,plVar11)) == null) ||
                    (lVar8 = Component.GetComponent(lVar8,DAT_181e77438)) == null) ||
                   (*(int64 *)(lVar8 + 32) == 0)))))) break;
              uVar7 = "1";
              if (*(char *)(*(int64 *)(lVar8 + 32) + 92) != false) {
                uVar7 = "0";
              }
              if (((lVar6 == null) || (lVar6 = Transform.Find(lVar6,uVar7,0)) == null) ||
                 (lVar6 = Component.GetComponent(lVar6,DAT_181e796b8)) == null) break;
              bVar10 = *(byte *)(lVar6 + 0x118);
              if ((((this.heroList == null) ||
                   (lVar6 = GameObject.get_transform(this.heroList,0)) == null) ||
                  ((lVar6 = Transform.Find(lVar6,"Viewport",0), lVar6 == null ||
                   (((lVar6 = Transform.Find(lVar6,"Content",0), lVar6 == null ||
                     (lVar6 = Transform.GetChild(lVar6,plVar11)) == null) ||
                    (lVar6 = Component.GetComponent(lVar6)) == null))))) ||
                 (*(int64 *)(lVar6 + 32) == 0)) break;
              if (*(int *)(*(int64 *)(lVar6 + 32) + 184) == iVar3) {
                if ((((this.heroList == null) ||
                     (lVar6 = GameObject.get_transform(this.heroList,0)) == null) ||
                    ((lVar6 = Transform.Find(lVar6,"Viewport",0), lVar6 == null ||
                     ((lVar6 = Transform.Find(lVar6,"Content",0), lVar6 == null ||
                      (lVar6 = Transform.GetChild(lVar6)) == null))))) ||
                   (lVar6 = Component.get_gameObject(lVar6)) == null) break;
                bVar2 = GameObject.get_activeSelf(lVar6);
                if (bVar2 != (bVar10 & bVar1)) {
                  if ((((this.heroList == null) ||
                       (lVar6 = GameObject.get_transform(this.heroList,0)) == null)
                      || (lVar6 = Transform.Find(lVar6,"Viewport",0)) == null) ||
                     (((lVar6 = Transform.Find(lVar6,"Content",0), lVar6 == null ||
                       (lVar6 = Transform.GetChild(lVar6,plVar11)) == null) ||
                      (lVar6 = Component.get_gameObject(lVar6,0)) == null))) break;
                  GameObject.SetActive(lVar6);
                }
              }
              lVar6 = this.heroList;
              plVar11 = (int64 *)(uint64)((int)plVar11 + 1);
              if (lVar6 == null) break;
            }
          }
        }
    }

    // Token : 0x6000E96
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

    // Token : 0x6000E97
    // RVA   : 0x52B140   Offset: 0x529F40   Length: 0x20
    private void <HideChoosePanel>b__24_0()
    {
        if (this.choosePanel != null) {
          GameObject.SetActive(this.choosePanel,0,0);
          return;
        }
    }

}
